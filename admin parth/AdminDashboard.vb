'CELESTINA ONG YING XUAN- A25DW0191 (SECTION J1)
Imports MySql.Data.MySqlClient

Public Class AdminDashboard

    ' --- Global Variables & Constants ---
    Dim connString As String = "server=localhost;userid=root;password=;database=nicelymini"
    Dim isSidebarOpen As Boolean = False
    Const SidebarWidth As Integer = 180
    Const HideX As Integer = -180
    Const ShowX As Integer = 0

#Region "Form Load & Initialization"

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Initialize sidebar position (Full height, hidden off-screen to the left)
        pnlSidebar.BackColor = Color.FromArgb(20, 20, 20)
        pnlSidebar.Width = SidebarWidth
        pnlSidebar.Height = Me.ClientSize.Height
        pnlSidebar.Location = New Point(HideX, 0)
        pnlSidebar.BringToFront()
        btnMenu.BringToFront()

        ' 2. Initialize the sidebar navigation buttons
        Dim navButtons() As Button = {btnStudent, btnBooks, btnReport, btnSettings, btnAbout, btnLogOut}
        For Each btn As Button In navButtons
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.Transparent
            btn.ForeColor = Color.White

            ' Attach hover and click events dynamically
            AddHandler btn.MouseEnter, AddressOf NavButton_MouseEnter
            AddHandler btn.MouseLeave, AddressOf NavButton_MouseLeave
            AddHandler btn.Click, AddressOf NavButton_ClickHandler
        Next

        ' 3. Load data and apply system styles
        LoadGridData()            ' Fetch recent borrow records
        StyleDataGridView()       ' Apply black and gold theme to the table
        UpdateLastBorrowDate()    ' Fetch the latest borrow date
        UpdateDashboardCounters() ' Update summary cards and doughnut chart
    End Sub

#End Region

#Region "Data Loading Methods"

    ' Fetches the latest 10 borrow records and displays them in the grid
    Private Sub LoadGridData()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT stu_ID, book_ID, borrow_date, borrow_status FROM borrow ORDER BY borrow_date DESC LIMIT 10"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()

                adapter.Fill(dt)
                dgvBorrow.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Cannot Connect Database:" & vbCrLf & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Fetches the most recent borrow date and updates the top label
    Private Sub UpdateLastBorrowDate()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT MAX(borrow_date) FROM borrow"

                Using cmd As New MySqlCommand(query, conn)
                    Dim result As Object = cmd.ExecuteScalar()

                    ' Check if the database returned a valid date
                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        Dim lastDate As DateTime = Convert.ToDateTime(result)
                        lblLastDate.Text = lastDate.ToString("dd-MMM-yyyy")
                    Else
                        lblLastDate.Text = "No Records"
                    End If
                End Using
            End Using
        Catch ex As Exception
            lblLastDate.Text = "Error"
        End Try
    End Sub

    ' Initializes static data for the Doughnut chart (Replaced by UpdateChartWithRealData dynamically)
    Private Sub LoadChartData()
        chart.Series.Clear()
        chart.Titles.Clear()

        Dim chartTitle As New DataVisualization.Charting.Title("SYSTEM OVERVIEW")
        chartTitle.ForeColor = Color.FromArgb(255, 212, 175, 55)
        chartTitle.Font = New Font("Arial", 12, FontStyle.Bold)
        chart.Titles.Add(chartTitle)

        Dim series As New DataVisualization.Charting.Series("Stats")
        series.ChartType = DataVisualization.Charting.SeriesChartType.Doughnut

        chart.ChartAreas(0).BackColor = Color.Transparent
        series.LabelForeColor = Color.White
        series.Font = New Font("Arial", 10, FontStyle.Bold)

        series.Points.AddXY("Total Books", 125)
        series.Points.AddXY("Borrowed", 42)
        series.Points.AddXY("Students", 88)

        series.Points(0).Color = Color.FromArgb(255, 212, 175, 55)
        series.Points(1).Color = Color.FromArgb(180, 130, 40)
        series.Points(2).Color = Color.FromArgb(255, 235, 130)

        chart.Series.Add(series)
    End Sub

#End Region

#Region "UI Styling & Custom Drawing Helpers"

    ' Applies flat style and gold gradient to a specific action button
    Private Sub StyleNavigationButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackgroundImageLayout = ImageLayout.Stretch
        btn.BackgroundImage = GetGoldGradient(btn.Width, btn.Height)
        btn.FlatAppearance.MouseDownBackColor = Color.DarkGoldenrod
    End Sub

    ' Generates a vertical gold gradient image for button backgrounds
    Private Function GetGoldGradient(w As Integer, h As Integer) As Bitmap
        If w <= 0 Then w = 1
        If h <= 0 Then h = 1

        Dim bmp As New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim rect As New Rectangle(0, 0, w, h)
            Dim lightGold As Color = Color.FromArgb(255, 235, 130)
            Dim darkGold As Color = Color.FromArgb(180, 135, 20)

            Using brush As New System.Drawing.Drawing2D.LinearGradientBrush(rect, lightGold, darkGold, 90.0!)
                g.FillRectangle(brush, rect)
            End Using
        End Using

        Return bmp
    End Function

    ' Applies the black and gold theme to the DataGridView
    Private Sub StyleDataGridView()
        dgvBorrow.EnableHeadersVisualStyles = False

        ' Grid background and lines
        dgvBorrow.BackgroundColor = Color.FromArgb(20, 20, 20)
        dgvBorrow.BorderStyle = BorderStyle.None
        dgvBorrow.GridColor = Color.FromArgb(180, 130, 40)

        ' Header styling
        dgvBorrow.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        dgvBorrow.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 212, 175, 55)
        dgvBorrow.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgvBorrow.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        ' Row styling
        dgvBorrow.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)
        dgvBorrow.DefaultCellStyle.ForeColor = Color.White
        dgvBorrow.DefaultCellStyle.Font = New Font("Segoe UI", 9)

        ' Highlight styling
        dgvBorrow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 212, 175, 55)
        dgvBorrow.DefaultCellStyle.SelectionForeColor = Color.Black

        dgvBorrow.RowHeadersVisible = False
        dgvBorrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    ' Calculates the mathematical path for rounded corners
    Private Function GetRoundedRectPath(rect As Rectangle, radius As Integer) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath()
        Dim diameter As Integer = radius * 2

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()

        Return path
    End Function

#End Region

#Region "Custom Paint Events"

    ' Draws a solid gold background with rounded corners for specific panels
    Private Sub GoldPanels_Paint(sender As Object, e As PaintEventArgs)
        Dim pnl As Panel = CType(sender, Panel)
        Dim radius As Integer = 15
        Dim rect As New Rectangle(0, 0, pnl.Width, pnl.Height)

        Using path As Drawing2D.GraphicsPath = GetRoundedRectPath(rect, radius)
            pnl.Region = New Region(path)
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

            Using goldBgBrush As New SolidBrush(Color.FromArgb(20, 252, 240, 210))
                e.Graphics.FillPath(goldBgBrush, path)
            End Using
        End Using

        Dim borderWidth As Integer = 2
        Dim borderRect As New Rectangle(CInt(borderWidth / 2), CInt(borderWidth / 2), pnl.Width - borderWidth, pnl.Height - borderWidth)

        Using borderPath As Drawing2D.GraphicsPath = GetRoundedRectPath(borderRect, radius)
            Using goldPen As New Pen(Color.FromArgb(255, 212, 175, 55), borderWidth)
                e.Graphics.DrawPath(goldPen, borderPath)
            End Using
        End Using
    End Sub

    ' Draws a solid black background with gold borders for specific panels
    Private Sub BlackPanels_Paint(sender As Object, e As PaintEventArgs) Handles pnlAdminProfileSystemStatus.Paint, pnlChart.Paint
        Dim pnl As Panel = CType(sender, Panel)
        Dim radius As Integer = 15
        Dim rect As New Rectangle(0, 0, pnl.Width, pnl.Height)

        Using path As Drawing2D.GraphicsPath = GetRoundedRectPath(rect, radius)
            pnl.Region = New Region(path)
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

            Using blackBgBrush As New SolidBrush(Color.FromArgb(180, 0, 0, 0))
                e.Graphics.FillPath(blackBgBrush, path)
            End Using
        End Using

        Dim borderWidth As Integer = 2
        Dim borderRect As New Rectangle(CInt(borderWidth / 2), CInt(borderWidth / 2), pnl.Width - borderWidth, pnl.Height - borderWidth)

        Using borderPath As Drawing2D.GraphicsPath = GetRoundedRectPath(borderRect, radius)
            Using goldPen As New Pen(Color.FromArgb(255, 212, 175, 55), borderWidth)
                e.Graphics.DrawPath(goldPen, borderPath)
            End Using
        End Using
    End Sub

    ' Draws gradient gold text on specific labels
    Private Sub lblDashboardTitle_Paint(sender As Object, e As PaintEventArgs) Handles lblDashboardTitle.Paint, lblAdmin.Paint, lblLastReport.Paint, lblLastDate.Paint, lblAdminProfileSystemStatus.Paint
        Dim lbl As Label = CType(sender, Label)

        If lbl.Width > 0 AndAlso lbl.Height > 0 Then
            Dim lightGold As Color = Color.FromArgb(255, 230, 150)
            Dim darkGold As Color = Color.FromArgb(180, 130, 40)
            Dim brush As New System.Drawing.Drawing2D.LinearGradientBrush(lbl.ClientRectangle, lightGold, darkGold, System.Drawing.Drawing2D.LinearGradientMode.Vertical)

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
            e.Graphics.DrawString(lbl.Text, lbl.Font, brush, New RectangleF(0, 0, lbl.Width, lbl.Height))
        End If
    End Sub

#End Region

#Region "Dashboard Counters & Dynamic Chart"

    ' Automatically calculates and updates data for the main cards and chart
    Private Sub UpdateDashboardCounters()
        Dim totalBooks As Integer = 0
        Dim borrowedBooks As Integer = 0
        Dim totalStudents As Integer = 0

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' 1. Calculate total books
                Dim queryBooks As String = "SELECT IFNULL(SUM(quantity), 0) FROM book"
                Using cmd As New MySqlCommand(queryBooks, conn)
                    totalBooks = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' 2. Calculate borrowed books
                Dim queryBorrowed As String = "SELECT COUNT(*) FROM borrow WHERE borrow_status = 'Borrowed'"
                Using cmd As New MySqlCommand(queryBorrowed, conn)
                    borrowedBooks = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' 3. Calculate total students
                Dim queryStudents As String = "SELECT COUNT(*) FROM student"
                Using cmd As New MySqlCommand(queryStudents, conn)
                    totalStudents = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using

            ' Update UI labels
            lblTotalBookO.Text = totalBooks.ToString()
            lblBorrowBookO.Text = borrowedBooks.ToString()
            lblTotalStudentO.Text = totalStudents.ToString()

            ' Pass dynamic data to the chart
            UpdateChartWithRealData(totalBooks, borrowedBooks, totalStudents)

        Catch ex As Exception
            ' Fallback display if database connection fails
            lblTotalBookO.Text = "-"
            lblBorrowBookO.Text = "-"
            lblTotalStudentO.Text = "-"
        End Try
    End Sub

    ' Generates the Doughnut chart using live database metrics
    Private Sub UpdateChartWithRealData(books As Integer, borrowed As Integer, students As Integer)
        chart.Series.Clear()
        chart.Titles.Clear()

        Dim chartTitle As New DataVisualization.Charting.Title("SYSTEM OVERVIEW")
        chartTitle.ForeColor = Color.FromArgb(255, 212, 175, 55)
        chartTitle.Font = New Font("Arial", 12, FontStyle.Bold)
        chart.Titles.Add(chartTitle)

        Dim series As New DataVisualization.Charting.Series("Stats")
        series.ChartType = DataVisualization.Charting.SeriesChartType.Doughnut

        chart.ChartAreas(0).BackColor = Color.Transparent
        series.LabelForeColor = Color.White
        series.Font = New Font("Arial", 10, FontStyle.Bold)

        series.Points.AddXY("Total Books", books)
        series.Points.AddXY("Borrowed", borrowed)
        series.Points.AddXY("Students", students)

        series.Points(0).Color = Color.FromArgb(255, 212, 175, 55)
        series.Points(1).Color = Color.FromArgb(180, 130, 40)
        series.Points(2).Color = Color.FromArgb(255, 235, 130)

        chart.Series.Add(series)
    End Sub

#End Region

#Region "Sidebar Animation & Navigation Engine"

    ' Keeps sidebar height matched to window size on resize
    Private Sub AdminDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        pnlSidebar.Height = Me.ClientSize.Height
    End Sub

    ' Triggers the animation timer when menu button is clicked
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        pnlSidebar.BringToFront()
        btnMenu.BringToFront()
        timerSidebar.Start()
    End Sub

    ' Executes the sliding animation frame by frame
    Private Sub timerSidebar_Tick(sender As Object, e As EventArgs) Handles timerSidebar.Tick
        If isSidebarOpen Then
            ' Slide left to hide
            pnlSidebar.Left -= 30
            If pnlSidebar.Left <= HideX Then
                pnlSidebar.Left = HideX
                isSidebarOpen = False
                timerSidebar.Stop()
            End If
        Else
            ' Slide right to show
            pnlSidebar.Left += 30
            If pnlSidebar.Left >= ShowX Then
                pnlSidebar.Left = ShowX
                isSidebarOpen = True
                timerSidebar.Stop()
            End If
        End If
    End Sub

    Private ReadOnly ShallowGoldColor As Color = Color.FromArgb(240, 210, 100)

    ' Applies golden text and transparent background on hover
    Private Sub NavButton_MouseEnter(sender As Object, e As EventArgs) Handles btnBooks.MouseEnter, btnReport.MouseEnter, btnStudent.MouseEnter, btnSettings.MouseEnter, btnAbout.MouseEnter, btnLogOut.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = ShallowGoldColor
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 240, 210, 100)
    End Sub

    ' Reverts button appearance when mouse leaves
    Private Sub NavButton_MouseLeave(sender As Object, e As EventArgs) Handles btnBooks.MouseLeave, btnReport.MouseLeave, btnStudent.MouseLeave, btnSettings.MouseLeave, btnAbout.MouseLeave, btnLogOut.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = Color.White
    End Sub

    ' Centralized navigation handler for sidebar buttons
    Private Sub NavButton_ClickHandler(sender As Object, e As EventArgs) Handles btnBooks.Click, btnReport.Click, btnStudent.Click, btnSettings.Click, btnAbout.Click, btnLogOut.Click
        Dim clickedButton As Button = CType(sender, Button)

        Select Case clickedButton.Name

            Case "btnBooks"
                Dim bookPage As New ManageBookForm()
                bookPage.ShowDialog()


            Case "btnReport"
                Dim reportPage As New ReportForm()
                reportPage.ShowDialog()


            Case "btnStudent"
                Dim StudentPage As New StudentManagementForm()
                StudentPage.ShowDialog()


            Case "btnSettings"
                Dim SettingsPage As New SettingsForm()
                SettingsPage.ShowDialog()


            Case "btnAbout"
                Dim about As New AboutBox()
                about.ShowDialog()

            Case "btnLogOut"
                Dim answer As DialogResult

                answer = MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                )

                If answer = DialogResult.Yes Then

                    ClearSession()
                    Application.Exit()

                End If
        End Select
    End Sub

#End Region


End Class