'CELESTINA ONG YING XUAN- A25DW0191 (SECTION J1)
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class ReportForm

    ' --- Global Variables & Constants ---
    Dim connString As String = "server=localhost;userid=root;password=;database=nicelymini"
    Dim isSidebarOpen As Boolean = False
    Const SidebarWidth As Integer = 200
    Const HideX As Integer = -200
    Const ShowX As Integer = 0

#Region "Form Load & Initialization"

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Auto maximize the form on load
        Me.WindowState = FormWindowState.Maximized

        ' 2. Initialize sidebar position (hidden off-screen to the left)
        pnlSidebar.Width = SidebarWidth
        pnlSidebar.Height = Me.ClientSize.Height
        pnlSidebar.Location = New Point(HideX, 0)
        pnlSidebar.BringToFront()
        btnMenu.BringToFront()

        ' 3. Initialize the sidebar navigation buttons dynamically
        Dim navButtons() As Button = {btnDashboard, btnStudent, btnBooks, btnSettings, btnAbout, btnLogOut}
        For Each btn As Button In navButtons
            AddHandler btn.Click, AddressOf NavButton_ClickHandler
            AddHandler btn.MouseEnter, AddressOf NavButton_MouseEnter
            AddHandler btn.MouseLeave, AddressOf NavButton_MouseLeave
            StyleSidebarButton(btn)
        Next

        ' 4. Initialize action buttons with hover effects
        Dim actionButtons() As Button = {btnExportCSV, btnExportExcel, btnSearch, btnClear}
        For Each btn As Button In actionButtons
            AddHandler btn.MouseEnter, AddressOf ActionButton_MouseEnter
            AddHandler btn.MouseLeave, AddressOf ActionButton_MouseLeave
            StyleActionButton(btn)
        Next

        ' 5. Apply table styles, load inventory data, and summary statistics
        StyleDataGridView()
        LoadBookInventory()
        LoadReportSummary()

        ' 6. Initialize all dropdowns to their default first item (e.g., "All Categories")
        If cmbStatus.Items.Count > 0 Then cmbStatus.SelectedIndex = 0
        If cmbCategory.Items.Count > 0 Then cmbCategory.SelectedIndex = 0
        If cmbSort.Items.Count > 0 Then cmbSort.SelectedIndex = 0
    End Sub

#End Region

#Region "Sidebar Animation & Navigation Engine"

    ' Keep sidebar height matched to window size on resize
    Private Sub ReportForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        pnlSidebar.Height = Me.ClientSize.Height
    End Sub

    ' Trigger animation when menu button is clicked
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        pnlSidebar.BringToFront()
        btnMenu.BringToFront()
        timerSidebar.Start()
    End Sub

    ' Timer animation engine for smooth sliding effect
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

    ' Apply golden text and transparent highlight on hover
    Private Sub NavButton_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = ShallowGoldColor
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 240, 210, 100)
    End Sub

    ' Revert button appearance when mouse leaves
    Private Sub NavButton_MouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = Color.White
    End Sub

    ' Apply distinct gold gradient highlight for functional action buttons
    Private Sub ActionButton_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.BackgroundImage = GetHoverGoldGradient(btn.Width, btn.Height)
    End Sub

    ' Revert action button appearance
    Private Sub ActionButton_MouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.BackgroundImage = GetGoldGradient(btn.Width, btn.Height)
    End Sub

    ' Centralized click handler for all sidebar navigation buttons
    Private Sub NavButton_ClickHandler(sender As Object, e As EventArgs)
        Dim clickedButton As Button = CType(sender, Button)

        Select Case clickedButton.Name

            Case "btnDashboard"
                Dim dashPage As New AdminDashboard()
                Me.Hide()
                dashPage.ShowDialog()
                Me.Close()

            Case "btnBooks"
                Dim bookPage As New ManageBookForm()
                Me.Hide()
                bookPage.ShowDialog()
                Me.Close()

            Case "btnSettings"
                Dim SettingsPage As New SettingsForm()
                Me.Hide()
                SettingsPage.ShowDialog()
                Me.Close()

            Case "btnStudent"
                Dim StudentPage As New StudentManagementForm()
                Me.Hide()
                StudentPage.ShowDialog()
                Me.Close()

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

#Region "UI Styling & Custom Drawing Helpers"

    ' Specific style for sidebar navigation buttons (Transparent background, white text)
    Private Sub StyleSidebarButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.Transparent
        btn.BackgroundImage = Nothing
        btn.ForeColor = Color.White
        btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btn.TextImageRelation = TextImageRelation.ImageBeforeText
        btn.ImageAlign = ContentAlignment.MiddleLeft
        btn.TextAlign = ContentAlignment.MiddleLeft
        btn.Padding = New Padding(10, 0, 0, 0)

        If btn.Image IsNot Nothing Then
            btn.Image = New Bitmap(btn.Image, New Size(24, 24))
        End If
    End Sub

    ' Specific style for action buttons (Search, Export) with gold gradients
    Private Sub StyleActionButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackgroundImageLayout = ImageLayout.Stretch
        btn.BackgroundImage = GetGoldGradient(btn.Width, btn.Height)
        btn.FlatAppearance.MouseDownBackColor = Color.DarkGoldenrod
        btn.ForeColor = Color.Black
        btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        If btn.Image IsNot Nothing Then
            btn.Image = New Bitmap(btn.Image, New Size(42, 42))
            btn.Padding = New Padding(5, 0, 5, 0)
        End If
    End Sub

    ' Generate standard gold gradient background
    Private Function GetGoldGradient(w As Integer, h As Integer) As Bitmap
        If w <= 0 Then w = 1
        If h <= 0 Then h = 1

        Dim bmp As New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim rect As New Rectangle(0, 0, w, h)
            Dim lightGold As Color = Color.FromArgb(255, 235, 130)
            Dim darkGold As Color = Color.FromArgb(180, 135, 20)

            Using brush As New LinearGradientBrush(rect, lightGold, darkGold, 90.0!)
                g.FillRectangle(brush, rect)
            End Using
        End Using
        Return bmp
    End Function

    ' Generate bright hover gold gradient background
    Private Function GetHoverGoldGradient(w As Integer, h As Integer) As Bitmap
        If w <= 0 Then w = 1
        If h <= 0 Then h = 1

        Dim bmp As New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim rect As New Rectangle(0, 0, w, h)
            Dim lightYellow As Color = Color.FromArgb(255, 255, 220)
            Dim strongGold As Color = Color.FromArgb(255, 190, 0)

            Using brush As New LinearGradientBrush(rect, lightYellow, strongGold, 90.0!)
                g.FillRectangle(brush, rect)
            End Using
        End Using
        Return bmp
    End Function

    ' Apply Black and Gold theme to the DataGridView
    Private Sub StyleDataGridView()
        ' Disable automatic row addition to keep the report visually clean
        dgvReport.AllowUserToAddRows = False

        dgvReport.EnableHeadersVisualStyles = False
        dgvReport.BackgroundColor = Color.FromArgb(20, 20, 20)
        dgvReport.BorderStyle = BorderStyle.None
        dgvReport.GridColor = Color.FromArgb(180, 130, 40)

        ' Header Styling
        dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 212, 175, 55)
        dgvReport.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgvReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        ' Cell Styling
        dgvReport.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)
        dgvReport.DefaultCellStyle.ForeColor = Color.White
        dgvReport.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        dgvReport.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 212, 175, 55)
        dgvReport.DefaultCellStyle.SelectionForeColor = Color.Black

        dgvReport.RowHeadersVisible = False
        dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    ' Base calculation for drawing rounded corners
    Private Function GetRoundedRectPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim diameter As Integer = radius * 2
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()
        Return path
    End Function

#End Region

#Region "Custom Paint Events (Panels & Labels)"

    ' Custom paint event for panels that require a solid black background with gold borders
    Private Sub BlackPanels_Paint(sender As Object, e As PaintEventArgs) Handles pnlFilters.Paint
        Dim pnl As Panel = CType(sender, Panel)
        Dim radius As Integer = 15
        Dim rect As New Rectangle(0, 0, pnl.Width, pnl.Height)

        Using path As GraphicsPath = GetRoundedRectPath(rect, radius)
            pnl.Region = New Region(path)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

            Using blackBgBrush As New SolidBrush(Color.FromArgb(180, 0, 0, 0))
                e.Graphics.FillPath(blackBgBrush, path)
            End Using
        End Using

        Dim borderWidth As Integer = 2
        Dim borderRect As New Rectangle(CInt(borderWidth / 2), CInt(borderWidth / 2), pnl.Width - borderWidth, pnl.Height - borderWidth)
        Using borderPath As GraphicsPath = GetRoundedRectPath(borderRect, radius)
            Using goldPen As New Pen(Color.FromArgb(255, 212, 175, 55), borderWidth)
                e.Graphics.DrawPath(goldPen, borderPath)
            End Using
        End Using
    End Sub

    ' Custom paint event to draw gradient gold text on specific titles
    Private Sub TitleLabels_Paint(sender As Object, e As PaintEventArgs) Handles lblReportTitle.Paint
        Dim lbl As Label = CType(sender, Label)
        If lbl.Width > 0 AndAlso lbl.Height > 0 Then
            Dim lightGold As Color = Color.FromArgb(255, 230, 150)
            Dim darkGold As Color = Color.FromArgb(180, 130, 40)
            Dim brush As New LinearGradientBrush(lbl.ClientRectangle, lightGold, darkGold, LinearGradientMode.Vertical)

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
            e.Graphics.DrawString(lbl.Text, lbl.Font, brush, New RectangleF(0, 0, lbl.Width, lbl.Height))
        End If
    End Sub

#End Region

#Region "Report Summary Statistics (Database)"

    ' Fetches real-time counts from MySQL and updates the 4 summary cards
    Private Sub LoadReportSummary()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' 1. Total Copies
                Dim queryCopies As String = "SELECT IFNULL(SUM(quantity), 0) FROM book"
                Using cmd As New MySqlCommand(queryCopies, conn)
                    lblTotalCopies.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' 2. Total Titles
                Dim queryTitles As String = "SELECT COUNT(*) FROM book"
                Using cmd As New MySqlCommand(queryTitles, conn)
                    lblTotalTitles.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' 3. Out Of Stock
                Dim queryOutOfStock As String = "SELECT COUNT(*) FROM book WHERE quantity = 0 OR Status = 'Out of Stock'"
                Using cmd As New MySqlCommand(queryOutOfStock, conn)
                    lblOutOfStock.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' 4. Categories
                Dim queryCategories As String = "SELECT COUNT(DISTINCT category) FROM book"
                Using cmd As New MySqlCommand(queryCategories, conn)
                    lblCategories.Text = cmd.ExecuteScalar().ToString()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to load summary statistics: " & vbCrLf & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Database Operations & Export Functions"

    ' Fetches book inventory data and binds it to the DataGridView
    Private Sub LoadBookInventory()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT book_ID AS 'Book ID', title AS 'Title', author AS 'Author', category AS 'Category', quantity AS 'Quantity', Status AS 'Status' FROM book"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()

                adapter.Fill(dt)
                dgvReport.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Cannot Connect Database:" & vbCrLf & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 1. Export DataGridView to CSV File
    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCSV.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data available to export.", "Export Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV File (*.csv)|*.csv"
            sfd.FileName = "Book_Inventory_Report_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".csv"

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using sw As New IO.StreamWriter(sfd.FileName, False, System.Text.Encoding.UTF8)
                        ' Write column headers
                        Dim headers As String = ""
                        For i As Integer = 0 To dgvReport.Columns.Count - 1
                            headers &= dgvReport.Columns(i).HeaderText
                            If i < dgvReport.Columns.Count - 1 Then headers &= ","
                        Next
                        sw.WriteLine(headers)

                        ' Write row data
                        For Each row As DataGridViewRow In dgvReport.Rows
                            If Not row.IsNewRow Then
                                Dim line As String = ""
                                For i As Integer = 0 To dgvReport.Columns.Count - 1
                                    Dim val As Object = row.Cells(i).Value
                                    Dim cellText As String = If(val IsNot Nothing, val.ToString().Replace(",", " "), "")
                                    line &= """" & cellText & """"
                                    If i < dgvReport.Columns.Count - 1 Then line &= ","
                                Next
                                sw.WriteLine(line)
                            End If
                        Next
                    End Using

                    MessageBox.Show("Data successfully exported to CSV!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error exporting file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    ' 2. Export DataGridView to TRUE Excel (.xlsx) using Excel Engine (Late Binding)
    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data available to export.", "Export Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
            sfd.FileName = "Book_Inventory_Excel_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".xlsx"

            If sfd.ShowDialog() = DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor

                Dim xlApp As Object = Nothing
                Dim xlWorkBook As Object = Nothing
                Dim xlWorkSheet As Object = Nothing

                Try
                    xlApp = CreateObject("Excel.Application")
                    If xlApp Is Nothing Then
                        MessageBox.Show("Microsoft Excel is not installed on this computer.", "Excel Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    xlApp.Visible = False
                    xlApp.DisplayAlerts = False
                    xlWorkBook = xlApp.Workbooks.Add()
                    xlWorkSheet = xlWorkBook.Worksheets(1)
                    xlWorkSheet.Name = "Inventory Report"

                    ' Write header row
                    For i As Integer = 0 To dgvReport.Columns.Count - 1
                        xlWorkSheet.Cells(1, i + 1) = dgvReport.Columns(i).HeaderText
                        xlWorkSheet.Cells(1, i + 1).Font.Bold = True
                    Next

                    ' Populate table data rows
                    Dim rowIndex As Integer = 2
                    For Each row As DataGridViewRow In dgvReport.Rows
                        If Not row.IsNewRow Then
                            For colIndex As Integer = 0 To dgvReport.Columns.Count - 1
                                Dim val As Object = row.Cells(colIndex).Value
                                xlWorkSheet.Cells(rowIndex, colIndex + 1) = If(val IsNot Nothing, val.ToString(), "")
                            Next
                            rowIndex += 1
                        End If
                    Next

                    xlWorkSheet.Columns.AutoFit()

                    ' Save as authentic Excel OpenXML format
                    xlWorkBook.SaveAs(sfd.FileName, 51)

                    MessageBox.Show("Data successfully exported to a genuine Excel file!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Error exporting to Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Release COM objects to prevent memory leaks
                    If xlWorkBook IsNot Nothing Then
                        xlWorkBook.Close(False)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
                    End If
                    If xlApp IsNot Nothing Then
                        xlApp.Quit()
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
                    End If
                    Me.Cursor = Cursors.Default
                End Try
            End If
        End Using
    End Sub

#End Region

#Region "Search & Filter Operations"

    ' Executes a dynamic database search based on multiple filters and sorting
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim query As String = "SELECT book_ID AS 'Book ID', title AS 'Title', author AS 'Author', category AS 'Category', quantity AS 'Quantity', Status AS 'Status' FROM book WHERE 1=1"

                ' 1. Keyword Filter
                Dim keyword As String = txtSearch.Text.Trim()
                If Not String.IsNullOrEmpty(keyword) Then
                    query &= " AND (title LIKE @keyword OR author LIKE @keyword OR book_ID LIKE @keyword)"
                End If

                ' 2. Status Filter
                If cmbStatus.SelectedItem IsNot Nothing AndAlso cmbStatus.SelectedItem.ToString() <> "All Status" Then
                    query &= " AND Status = @status"
                End If

                ' 3. Category Filter
                If cmbCategory.SelectedItem IsNot Nothing AndAlso cmbCategory.SelectedItem.ToString() <> "All Categories" Then
                    query &= " AND category = @category"
                End If

                ' 4. Sort Logic
                If cmbSort.SelectedItem IsNot Nothing Then
                    Select Case cmbSort.SelectedItem.ToString()
                        Case "Title (A-Z)"
                            query &= " ORDER BY title ASC"
                        Case "Title (Z-A)"
                            query &= " ORDER BY title DESC"
                        Case "Quantity (High - Low)"
                            query &= " ORDER BY quantity DESC"
                        Case "Quantity (Low - High)"
                            query &= " ORDER BY quantity ASC"
                        Case Else
                            query &= " ORDER BY book_ID ASC"
                    End Select
                Else
                    query &= " ORDER BY book_ID ASC"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    ' Safely bind parameters
                    If Not String.IsNullOrEmpty(keyword) Then
                        cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    End If

                    If cmbStatus.SelectedItem IsNot Nothing AndAlso cmbStatus.SelectedItem.ToString() <> "All Status" Then
                        cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString())
                    End If

                    If cmbCategory.SelectedItem IsNot Nothing AndAlso cmbCategory.SelectedItem.ToString() <> "All Categories" Then
                        cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem.ToString())
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvReport.DataSource = dt

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No records found matching your criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error executing search: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Resets all filter inputs and reloads the complete inventory data
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Clear()

        If cmbStatus.Items.Count > 0 Then cmbStatus.SelectedIndex = 0
        If cmbCategory.Items.Count > 0 Then cmbCategory.SelectedIndex = 0
        If cmbSort.Items.Count > 0 Then cmbSort.SelectedIndex = 0

        LoadBookInventory()
        txtSearch.Focus()
    End Sub

#End Region
End Class