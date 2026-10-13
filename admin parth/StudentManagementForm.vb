'CELESTINA ONG YING XUAN- A25DW0191 (SECTION J1)
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class StudentManagementForm

    ' --- Global Variables & Constants ---
    Dim connString As String = "server=localhost;userid=root;password=;database=nicelymini"
    Dim currentAdminID As Integer = 1

    ' Sidebar animation variables
    Dim isSidebarOpen As Boolean = False
    Const SidebarWidth As Integer = 180
    Const HideX As Integer = -180
    Const ShowX As Integer = 0

#Region "Form Load & Initialization"

    Private Sub StudentManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Initialize sidebar position
        pnlSidebar.BackColor = Color.FromArgb(20, 20, 20)
        pnlSidebar.Width = SidebarWidth
        pnlSidebar.Height = Me.ClientSize.Height
        pnlSidebar.Location = New Point(HideX, 0)
        pnlSidebar.BringToFront()
        btnMenu.BringToFront()

        ' 2. Bind sidebar button hover and click effects dynamically
        Dim navButtons() As Button = {btnDashboard, btnBooks, btnReport, btnSettings, btnAbout, btnLogOut}
        For Each btn As Button In navButtons
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.Transparent
            btn.ForeColor = Color.White
            AddHandler btn.MouseEnter, AddressOf NavButton_MouseEnter
            AddHandler btn.MouseLeave, AddressOf NavButton_MouseLeave
            AddHandler btn.Click, AddressOf NavButton_ClickHandler
        Next

        ' 3. Apply Gold Style and Rounded Corners to core action buttons
        Dim actionBtns() As Button = {btnSearch, btnClear, btnResetPassword, btnAddStudent, btnUpdateStudent, btnDeleteStudent}
        For Each btn As Button In actionBtns
            StyleGoldButton(btn)
            AddHandler btn.MouseEnter, AddressOf ActionButton_MouseEnter
            AddHandler btn.MouseLeave, AddressOf ActionButton_MouseLeave
        Next

        ' 4. Hide password characters for security
        txtPassword.PasswordChar = "*"c

        ' 5. Load data and apply DataGridView styles
        StyleDataGridView()
        LoadStudentData()
        UpdateStatistics()
    End Sub

#End Region

#Region "Core CRUD Operations (Database)"

    ' [READ] Load all students from MySQL into DataGridView (supports fuzzy search)
    Private Sub LoadStudentData(Optional searchQuery As String = "")
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT stu_ID As 'Student ID', stu_name As 'Name', email As 'Email' FROM student"

                If Not String.IsNullOrEmpty(searchQuery) Then
                    query &= " WHERE stu_ID LIKE @search OR stu_name LIKE @search OR email LIKE @search"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrEmpty(searchQuery) Then
                        cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvStudent.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' [CREATE] Add a new student
    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse String.IsNullOrWhiteSpace(txtEmail.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please fill in Name, Email, and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "INSERT INTO student (admin_ID, stu_name, email, stu_password) VALUES (@adminID, @name, @email, @password)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@adminID", currentAdminID)
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("New student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                LoadStudentData()
                UpdateStatistics()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' [UPDATE] Update student details (Name and Email only)
    Private Sub btnUpdateStudent_Click(sender As Object, e As EventArgs) Handles btnUpdateStudent.Click
        If String.IsNullOrWhiteSpace(txtStuID.Text) Then
            MessageBox.Show("Please select a student from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "UPDATE student SET stu_name = @name, email = @email WHERE stu_ID = @id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", txtStuID.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Student details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadStudentData()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' [DELETE] Delete a student
    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        If String.IsNullOrWhiteSpace(txtStuID.Text) Then
            MessageBox.Show("Please select a student from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this student? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(connString)
                    conn.Open()
                    Dim query As String = "DELETE FROM student WHERE stu_ID = @id"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", txtStuID.Text.Trim())
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Student deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                    LoadStudentData()
                    UpdateStatistics()
                End Using
            Catch ex As Exception
                MessageBox.Show("Cannot delete student. They might have active borrow records.", "Foreign Key Constraint", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Special Action: Force reset student password
    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        If String.IsNullOrWhiteSpace(txtStuID.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please select a student and enter a new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "UPDATE student SET stu_password = @password WHERE stu_ID = @id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", txtStuID.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Student password has been reset successfully!", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPassword.Clear()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error resetting password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Search, Click & Statistics"

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadStudentData(txtSearch.Text.Trim())
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Clear()
        LoadStudentData()
    End Sub

    ' Populate input fields when a DataGridView row is clicked
    Private Sub dgvStudent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvStudent.Rows(e.RowIndex)
            txtStuID.Text = row.Cells("Student ID").Value.ToString()
            txtName.Text = row.Cells("Name").Value.ToString()
            txtEmail.Text = row.Cells("Email").Value.ToString()
            txtPassword.Clear() ' Keep password blank for security purposes
        End If
    End Sub

    Private Sub ClearFields()
        txtStuID.Clear()
        txtName.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
    End Sub

    ' Update the top summary cards
    Private Sub UpdateStatistics()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' 1. Total Students & Active Registrations
                Dim queryTotal As String = "SELECT COUNT(*) FROM student"
                Using cmd As New MySqlCommand(queryTotal, conn)
                    Dim total As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblTotalStudentsCount.Text = total.ToString()
                    lblActiveRegCount.Text = total.ToString()
                End Using

                ' 2. New Students this month
                lblNewStudentsCount.Text = "0"

                ' 3. Overdue Students
                Try
                    Dim queryOverdue As String = "SELECT COUNT(DISTINCT stu_ID) FROM borrow WHERE borrow_status = 'Borrowed' AND due_date < CURDATE()"
                    Using cmdOverdue As New MySqlCommand(queryOverdue, conn)
                        lblOverdueCount.Text = Convert.ToInt32(cmdOverdue.ExecuteScalar()).ToString()
                    End Using
                Catch
                    lblOverdueCount.Text = "-"
                End Try

            End Using
        Catch ex As Exception
            lblTotalStudentsCount.Text = "-"
            lblActiveRegCount.Text = "-"
            lblNewStudentsCount.Text = "-"
            lblOverdueCount.Text = "-"
        End Try
    End Sub

#End Region

#Region "Sidebar Animation & Navigation Engine"

    Private Sub StudentManagementForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        pnlSidebar.Height = Me.ClientSize.Height
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        pnlSidebar.BringToFront()
        btnMenu.BringToFront()
        timerSidebar.Start()
    End Sub

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

    Private Sub NavButton_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = ShallowGoldColor
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 240, 210, 100)
    End Sub

    Private Sub NavButton_MouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = Color.White
    End Sub

    Private Sub NavButton_ClickHandler(sender As Object, e As EventArgs)
        Dim clickedButton As Button = CType(sender, Button)

        Select Case clickedButton.Name
            Case "btnDashboard"
                Dim dashboardPage As New AdminDashboard()
                Me.Hide()
                dashboardPage.ShowDialog()
                Me.Close()

            Case "btnBooks"
                Dim bookPage As New ManageBookForm()
                Me.Hide()
                bookPage.ShowDialog()
                Me.Close()

            Case "btnReport"
                Dim reportPage As New ReportForm()
                Me.Hide()
                reportPage.ShowDialog()
                Me.Close()

            Case "btnSettings"
                Dim settingsPage As New SettingsForm()
                Me.Hide()
                settingsPage.ShowDialog()
                Me.Close()

            Case "btnAbout"
                Dim about As New AboutBox()
                about.ShowDialog()

            Case "btnLogOut"
                If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ClearSession()
                    Application.Exit()
                End If
        End Select
    End Sub

#End Region

#Region "UI Styling (Grid, Buttons, Labels, & Panels)"

    ' Apply Black and Gold theme to DataGridView
    Private Sub StyleDataGridView()
        ' Disable automatic row addition to keep the grid clean
        dgvStudent.AllowUserToAddRows = False

        dgvStudent.EnableHeadersVisualStyles = False
        dgvStudent.BackgroundColor = Color.FromArgb(20, 20, 20)
        dgvStudent.BorderStyle = BorderStyle.None
        dgvStudent.GridColor = Color.FromArgb(180, 130, 40)

        ' Header Styling
        dgvStudent.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        dgvStudent.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 212, 175, 55)
        dgvStudent.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgvStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        ' Cell Styling
        dgvStudent.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)
        dgvStudent.DefaultCellStyle.ForeColor = Color.White
        dgvStudent.DefaultCellStyle.Font = New Font("Segoe UI", 9)
        dgvStudent.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 212, 175, 55)
        dgvStudent.DefaultCellStyle.SelectionForeColor = Color.Black

        dgvStudent.RowHeadersVisible = False
        dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    ' Generate Gold Gradient Background
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

    ' Generate high-visibility hover gold gradient
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

    Private Sub ActionButton_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.BackgroundImage = GetHoverGoldGradient(btn.Width, btn.Height)
    End Sub

    Private Sub ActionButton_MouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.BackgroundImage = GetGoldGradient(btn.Width, btn.Height)
    End Sub

    ' Apply gold theme and rounded corners to buttons
    Private Sub StyleGoldButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.ForeColor = Color.Black
        btn.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btn.BackgroundImageLayout = ImageLayout.Stretch
        btn.BackgroundImage = GetGoldGradient(btn.Width, btn.Height)

        Dim radius As Integer = 12
        Dim rect As New Rectangle(0, 0, btn.Width, btn.Height)
        Dim path As GraphicsPath = GetRoundedRectPath(rect, radius)
        btn.Region = New Region(path)
    End Sub

    ' Render gold gradient text for the title
    Private Sub lblFormTitle_Paint(sender As Object, e As PaintEventArgs) Handles lblFormTitle.Paint
        Dim lbl As Label = CType(sender, Label)
        If lbl.Width > 0 AndAlso lbl.Height > 0 Then
            Dim lightGold As Color = Color.FromArgb(255, 230, 150)
            Dim darkGold As Color = Color.FromArgb(180, 130, 40)
            Dim brush As New LinearGradientBrush(lbl.ClientRectangle, lightGold, darkGold, LinearGradientMode.Vertical)

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
            e.Graphics.DrawString(lbl.Text, lbl.Font, brush, New RectangleF(0, 0, lbl.Width, lbl.Height))
        End If
    End Sub

    ' Algorithm for rounded corners
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

    ' Draw golden rounded borders for panels
    Private Sub Panel_Paint_GoldBorder(sender As Object, e As PaintEventArgs) Handles pnlStudentList.Paint, pnlStudentDetails.Paint
        Dim pnl As Panel = CType(sender, Panel)
        Dim radius As Integer = 10
        Dim rect As New Rectangle(0, 0, pnl.Width, pnl.Height)

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim borderWidth As Integer = 2
        Dim borderRect As New Rectangle(CInt(borderWidth / 2), CInt(borderWidth / 2), pnl.Width - borderWidth, pnl.Height - borderWidth)

        Using borderPath As GraphicsPath = GetRoundedRectPath(borderRect, radius)
            Using goldPen As New Pen(Color.FromArgb(255, 212, 175, 55), borderWidth)
                e.Graphics.DrawPath(goldPen, borderPath)
            End Using
        End Using
    End Sub

#End Region

    
End Class