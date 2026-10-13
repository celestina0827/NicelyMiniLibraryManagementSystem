'CELESTINA ONG YING XUAN- A25DW0191 (SECTION J1)
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Drawing2D

Public Class SettingsForm

    ' --- Global Variables & Constants ---
    Dim connString As String = "server=localhost;userid=root;password=;database=nicelymini"
    Dim currentAdminID As Integer = 1 ' Current logged-in Admin ID

    ' Sidebar animation variables
    Dim isSidebarOpen As Boolean = False
    Const SidebarWidth As Integer = 180
    Const HideX As Integer = -180
    Const ShowX As Integer = 0

#Region "Form Load & Initialization"

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Initialize sidebar position
        pnlSidebar.BackColor = Color.FromArgb(20, 20, 20)
        pnlSidebar.Width = SidebarWidth
        pnlSidebar.Height = Me.ClientSize.Height
        pnlSidebar.Location = New Point(HideX, 0)
        pnlSidebar.BringToFront()
        btnMenu.BringToFront()

        ' 2. Bind sidebar navigation buttons dynamically
        Dim navButtons() As Button = {btnDashboard, btnStudent, btnBooks, btnReport, btnAbout, btnLogOut}
        For Each btn As Button In navButtons
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.Transparent
            btn.ForeColor = Color.White
            AddHandler btn.MouseEnter, AddressOf NavButton_MouseEnter
            AddHandler btn.MouseLeave, AddressOf NavButton_MouseLeave
            AddHandler btn.Click, AddressOf NavButton_ClickHandler
        Next

        ' 3. Initialize password mask characters for security
        txtOldPassword.PasswordChar = "*"c
        txtNewPassword.PasswordChar = "*"c
        txtConfirmPassword.PasswordChar = "*"c

        ' 4. Load Data & Configure UI
        LoadAdminProfile()
        LoadSystemConfigurations()

        ' 5. Apply standard gold styling to specific action buttons
        Dim actionBtns() As Button = {btnSaveProfile, btnSaveConfig, btnBrowsePath, btnTestDataConnection}
        For Each btn As Button In actionBtns
            StyleGoldButton(btn)
            AddHandler btn.MouseEnter, AddressOf ActionButton_MouseEnter
            AddHandler btn.MouseLeave, AddressOf ActionButton_MouseLeave
        Next
    End Sub

#End Region

#Region "Account & Profile Logic (Database)"

    ' Fetches the Admin profile from MySQL and binds it to the UI
    Private Sub LoadAdminProfile()
        Try
            ' 【BUG FIXED】: Display the current Admin ID on the label
            lblAdminID.Text = "ID: " & currentAdminID.ToString()

            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT admin_Name FROM admin WHERE admin_ID = @id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", currentAdminID)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        txtAdminName.Text = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Toggles password visibility
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtOldPassword.PasswordChar = ControlChars.NullChar
            txtNewPassword.PasswordChar = ControlChars.NullChar
            txtConfirmPassword.PasswordChar = ControlChars.NullChar
        Else
            txtOldPassword.PasswordChar = "*"c
            txtNewPassword.PasswordChar = "*"c
            txtConfirmPassword.PasswordChar = "*"c
        End If
    End Sub

    ' Validates and updates the Admin name and password in the database
    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        Dim newName As String = txtAdminName.Text.Trim()
        Dim oldPass As String = txtOldPassword.Text.Trim()
        Dim newPass As String = txtNewPassword.Text.Trim()
        Dim confirmPass As String = txtConfirmPassword.Text.Trim()

        If String.IsNullOrEmpty(newName) Then
            MessageBox.Show("Admin Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Proceed with password change if user provided inputs
        If Not String.IsNullOrEmpty(oldPass) OrElse Not String.IsNullOrEmpty(newPass) Then
            If newPass <> confirmPass Then
                MessageBox.Show("New passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                Using conn As New MySqlConnection(connString)
                    conn.Open()

                    ' Verify old password first
                    Dim verifyQuery As String = "SELECT COUNT(*) FROM admin WHERE admin_ID = @id AND admin_password = @oldPass"
                    Using verifyCmd As New MySqlCommand(verifyQuery, conn)
                        verifyCmd.Parameters.AddWithValue("@id", currentAdminID)
                        verifyCmd.Parameters.AddWithValue("@oldPass", oldPass)
                        Dim count As Integer = Convert.ToInt32(verifyCmd.ExecuteScalar())

                        If count > 0 Then
                            ' Update both name and password
                            Dim updateQuery As String = "UPDATE admin SET admin_Name = @name, admin_password = @newPass WHERE admin_ID = @id"
                            Using updateCmd As New MySqlCommand(updateQuery, conn)
                                updateCmd.Parameters.AddWithValue("@name", newName)
                                updateCmd.Parameters.AddWithValue("@newPass", newPass)
                                updateCmd.Parameters.AddWithValue("@id", currentAdminID)
                                updateCmd.ExecuteNonQuery()
                            End Using

                            MessageBox.Show("Profile and password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Clear sensitive inputs
                            txtOldPassword.Clear()
                            txtNewPassword.Clear()
                            txtConfirmPassword.Clear()
                        Else
                            MessageBox.Show("Incorrect old password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Update name only if password fields are empty
            Try
                Using conn As New MySqlConnection(connString)
                    conn.Open()
                    Dim updateQuery As String = "UPDATE admin SET admin_Name = @name WHERE admin_ID = @id"
                    Using updateCmd As New MySqlCommand(updateQuery, conn)
                        updateCmd.Parameters.AddWithValue("@name", newName)
                        updateCmd.Parameters.AddWithValue("@id", currentAdminID)
                        updateCmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Profile name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

#End Region

#Region "System Configuration Logic (My.Settings)"

    ' Load settings from application local storage
    Private Sub LoadSystemConfigurations()
        txtReportExportPath.Text = If(String.IsNullOrEmpty(My.Settings.ReportExportPath), "C:\Reports", My.Settings.ReportExportPath)
        txtDBConnectionPath.Text = connString
        nudBorrowPeriod.Value = If(My.Settings.DefaultBorrowPeriod = 0, 14, My.Settings.DefaultBorrowPeriod)
        nudMaxBooks.Value = If(My.Settings.MaxAdminBooks = 0, 5, My.Settings.MaxAdminBooks)
    End Sub

    ' Opens a dialog to select the report export folder
    Private Sub btnBrowsePath_Click(sender As Object, e As EventArgs) Handles btnBrowsePath.Click
        If fbdReportPath.ShowDialog() = DialogResult.OK Then
            txtReportExportPath.Text = fbdReportPath.SelectedPath
        End If
    End Sub

    ' Tests the current database connection string
    Private Sub btnTestDataConnection_Click(sender As Object, e As EventArgs) Handles btnTestDataConnection.Click
        Dim testConnString As String = txtDBConnectionPath.Text.Trim()
        Try
            Using conn As New MySqlConnection(testConnString)
                conn.Open()
                lblDbStatusText.Text = "Database Link Status: Connected"
                lblDbStatusText.ForeColor = Color.LightGreen
                MessageBox.Show("Connection Successful!", "Test Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            lblDbStatusText.Text = "Database Link Status: Failed"
            lblDbStatusText.ForeColor = Color.Red
            MessageBox.Show("Connection Failed: " & ex.Message, "Test Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Saves the configurations persistently to My.Settings
    Private Sub btnSaveConfig_Click(sender As Object, e As EventArgs) Handles btnSaveConfig.Click
        My.Settings.ReportExportPath = txtReportExportPath.Text
        My.Settings.DefaultBorrowPeriod = Convert.ToInt32(nudBorrowPeriod.Value)
        My.Settings.MaxAdminBooks = Convert.ToInt32(nudMaxBooks.Value)
        My.Settings.Save()

        MessageBox.Show("System configurations saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region

#Region "Sidebar Animation & Navigation Engine"

    Private Sub SettingsForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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
    ' Generates the base gold gradient background
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

    ' Generates the high-visibility hover gold gradient
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

    ' Apply default styling and rounded corners to action buttons
    Private Sub StyleGoldButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.ForeColor = Color.Black
        btn.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btn.BackgroundImageLayout = ImageLayout.Stretch
        btn.BackgroundImage = GetGoldGradient(btn.Width, btn.Height)

        Dim radius As Integer = 10
        Dim rect As New Rectangle(0, 0, btn.Width, btn.Height)
        Dim path As GraphicsPath = GetRoundedRectPath(rect, radius)
        btn.Region = New Region(path)
    End Sub

    ' Render gradient text for titles
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

    ' Calculation for drawing rounded corners
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

    ' Draw smooth golden borders around the main content panels
    Private Sub Panel_Paint_GoldBorder(sender As Object, e As PaintEventArgs) Handles pnlAccount.Paint, pnlSystem.Paint
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