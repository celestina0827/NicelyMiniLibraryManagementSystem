'CHEAH WEI EN -A25DW0096 (SECTION J1)
Imports MySql.Data.MySqlClient
Imports System.Drawing.Text

Public Class ReturnForm
    ' 1. Global Variables & Field Parameters
    Private isSidebarOpen As Boolean = False
    Private Const SidebarWidth As Integer = 280
    Private Const HideX As Integer = -280
    Private Const ShowX As Integer = 0
    Private Const HeaderHeight As Integer = 70

    Private ReadOnly Color_Normal_White As Color = Color.White
    Private ReadOnly Color_Hover_Gold As Color = Color.FromArgb(212, 175, 55)

    ' Connection string targeting 'nicelymini' database
    Private Const ConnString As String = "Server=localhost;Database=nicelymini;Uid=root;Pwd=;"

    ' 2. Form Load & Initializations
    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
           
            ' 1. Strictly restrict access to Student role only
            If UserSession.CurrentRole <> "Student" Then
                MessageBox.Show("Access Denied! This page is restricted to students only.", "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
                Exit Sub
            End If

            ' 2. Bind and lock the current logged-in Student ID to prevent processing returns for other users
            If txtStudentID IsNot Nothing Then
                txtStudentID.Text = UserSession.CurrentUserID
                txtStudentID.ReadOnly = True ' Prevent manual editing of student ID
            End If
            ' ==================================================================================

            ' --- Explicitly enable and display system title bar (icon, title, minimize, maximize, close X) ---
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.ControlBox = True
            Me.MinimizeBox = True
            Me.MaximizeBox = True
            Me.Text = "ReturnForm"
            Me.WindowState = FormWindowState.Maximized

            If dgvActiveBorrows IsNot Nothing Then
                dgvActiveBorrows.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                ConfigureDataGridViewStyles()
            End If

            If Panel_Sidebar1 IsNot Nothing Then
                Panel_Sidebar1.Size = New Size(SidebarWidth, Me.ClientSize.Height - HeaderHeight)
                Panel_Sidebar1.Location = New Point(HideX, HeaderHeight)
                Panel_Sidebar1.BringToFront()
            End If

            If Timer_Sidebar IsNot Nothing Then
                Timer_Sidebar.Interval = 10
            End If

            InitializeNavButtonStyles()
            InitializeReturnCardControls()

            ' Automatically load active borrow records for the current logged-in student
            LoadActiveBorrows(UserSession.CurrentUserID)

        Catch ex As Exception
            MessageBox.Show("Initialization Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ReturnForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Panel_Sidebar1 IsNot Nothing Then
            Panel_Sidebar1.Height = Me.ClientSize.Height - HeaderHeight
        End If
    End Sub

    ' Apply DataGridView CellStyles Programmatically to Bypass Visual Studio Designer Validation Errors
    Private Sub ConfigureDataGridViewStyles()
        If dgvActiveBorrows Is Nothing Then Return

        With dgvActiveBorrows
            .EnableHeadersVisualStyles = False

            ' Column Headers Default CellStyle Configuration
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.Tan
                .ForeColor = Color.Black
                .SelectionBackColor = Color.Beige   ' Highlight selection color for headers
                .SelectionForeColor = Color.Black
                .Alignment = DataGridViewContentAlignment.MiddleCenter
                .Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
                .WrapMode = DataGridViewTriState.False
                .Padding = New Padding(0)
            End With

            ' Row Header Style (Leftmost cell)
            .RowHeadersDefaultCellStyle.SelectionBackColor = Color.Beige   ' Highlight selection color for row headers

            ' Data Cells Default CellStyle Configuration
            With .DefaultCellStyle
                .BackColor = Color.FromArgb(8, 10, 12)
                .ForeColor = Color.FromArgb(215, 215, 215)
                .SelectionBackColor = Color.FromArgb(197, 140, 20)
                .SelectionForeColor = Color.Black
                .Alignment = DataGridViewContentAlignment.MiddleCenter
                .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
                .WrapMode = DataGridViewTriState.True
                .Padding = New Padding(0)
            End With

            ' Alternating Rows Default CellStyle Configuration
            With .AlternatingRowsDefaultCellStyle
                .BackColor = Color.Black
                .ForeColor = Color.Goldenrod
                .SelectionBackColor = Color.DarkGoldenrod
                .SelectionForeColor = Color.Black
                .Alignment = DataGridViewContentAlignment.MiddleCenter
                .WrapMode = DataGridViewTriState.NotSet
                .Padding = New Padding(0)
            End With
        End With
    End Sub

    ' 3. Sliding Drawer Sidebar Animation
    Private Sub Btn_Toggle_Click(sender As Object, e As EventArgs) Handles Btn_Toggle.Click
        If Panel_Sidebar1 IsNot Nothing AndAlso Timer_Sidebar IsNot Nothing Then
            Panel_Sidebar1.BringToFront()
            Timer_Sidebar.Start()
        End If
    End Sub

    Private Sub Timer_Sidebar_Tick(sender As Object, e As EventArgs) Handles Timer_Sidebar.Tick
        If Panel_Sidebar1 Is Nothing Then Return
        Dim currentX As Integer = Panel_Sidebar1.Location.X

        If isSidebarOpen Then
            currentX -= 30
            If currentX <= HideX Then
                Panel_Sidebar1.Location = New Point(HideX, HeaderHeight)
                isSidebarOpen = False
                Timer_Sidebar.Stop()
            Else
                Panel_Sidebar1.Location = New Point(currentX, HeaderHeight)
            End If
        Else
            currentX += 30
            If currentX >= ShowX Then
                Panel_Sidebar1.Location = New Point(ShowX, HeaderHeight)
                isSidebarOpen = True
                Timer_Sidebar.Stop()
            Else
                Panel_Sidebar1.Location = New Point(currentX, HeaderHeight)
            End If
        End If
    End Sub

    ' 4. Sidebar Navigation Button Styles & Events
    Private Sub InitializeNavButtonStyles()
        Dim navButtons() As Button = {
            Btn_Nav_Dashboard, Btn_Nav_Books, Btn_Nav_Borrows, Btn_Nav_History,
            Btn_Nav_About, Btn_Nav_Logout
        }

        For Each btn As Button In navButtons
            If btn IsNot Nothing Then
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 212, 175, 55)
                btn.BackColor = Color.Transparent
                btn.ForeColor = Color_Normal_White

                AddHandler btn.Click, AddressOf NavButton_Click
            End If
        Next
    End Sub

    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles _
        Btn_Nav_Dashboard.MouseEnter, Btn_Nav_Books.MouseEnter, Btn_Nav_Borrows.MouseEnter,
         Btn_Nav_History.MouseEnter,
        Btn_Nav_About.MouseEnter, Btn_Nav_Logout.MouseEnter

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing Then btn.ForeColor = Color_Hover_Gold
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles _
        Btn_Nav_Dashboard.MouseLeave, Btn_Nav_Books.MouseLeave, Btn_Nav_Borrows.MouseLeave,
         Btn_Nav_History.MouseLeave,
        Btn_Nav_About.MouseLeave, Btn_Nav_Logout.MouseLeave

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing Then btn.ForeColor = Color_Normal_White
    End Sub

    ' Dedicated sidebar navigation routing for ReturnForm (using Me.Hide to prevent application exit)
    Private Sub NavButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = TryCast(sender, Button)
        If clickedButton Is Nothing Then Return
        Dim targetForm As Form = Nothing

        Select Case clickedButton.Name
            Case "Btn_Nav_Dashboard"

                targetForm = New StudentForm()
            Case "Btn_Nav_Books"

                targetForm = New BookForm()
            Case "Btn_Nav_Borrows"
                targetForm = New BorrowForm()

            Case "Btn_Nav_History"
                targetForm = New BorrowHistoryForm()

            Case "Btn_Nav_About"

                targetForm = New AboutBox()
            Case "Btn_Nav_Logout"
                MessageBox.Show("Login page is under development.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearSession()
                Application.Exit()

        End Select

        If targetForm IsNot Nothing Then
            If isSidebarOpen AndAlso Timer_Sidebar IsNot Nothing Then
                Panel_Sidebar1.Location = New Point(HideX, HeaderHeight)
                isSidebarOpen = False
            End If
            targetForm.ShowDialog()
        End If
    End Sub

    ' 5. UI Controls Initialization & Custom Drawing for Beige Selection
    Private Sub InitializeReturnCardControls()
        If cmbCondition IsNot Nothing Then
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList
            cmbCondition.DrawMode = DrawMode.OwnerDrawFixed

            RemoveHandler cmbCondition.DrawItem, AddressOf cmbCondition_DrawItem
            AddHandler cmbCondition.DrawItem, AddressOf cmbCondition_DrawItem

            cmbCondition.Items.Clear()
            cmbCondition.Items.Add("Good (Ready to Shelve)")
            cmbCondition.Items.Add("Damaged (Needs Repair)")
            cmbCondition.Items.Add("Lost (Charge Fine)")
            If cmbCondition.Items.Count > 0 Then cmbCondition.SelectedIndex = 0
        End If

        Dim checkBoxes() As CheckBox = {chkCoverIntact, chkNoMissingPages, chkNoScribbling}
        For Each chk In checkBoxes
            If chk IsNot Nothing Then
                chk.FlatStyle = FlatStyle.Flat
                chk.FlatAppearance.CheckedBackColor = Color.Beige
                chk.FlatAppearance.BorderColor = Color.DarkGoldenrod
            End If
        Next

        If chkCoverIntact IsNot Nothing Then chkCoverIntact.Checked = True
        If chkNoMissingPages IsNot Nothing Then chkNoMissingPages.Checked = True
        If chkNoScribbling IsNot Nothing Then chkNoScribbling.Checked = True
    End Sub

    ' ComboBox Custom Drawing Logic: Replace default blue selection background with beige
    Private Sub cmbCondition_DrawItem(sender As Object, e As DrawItemEventArgs)
        If e.Index < 0 Then Return

        Dim cb As ComboBox = CType(sender, ComboBox)
        Dim isSelected As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected

        Dim backColor As Color = If(isSelected, Color.Beige, cb.BackColor)
        Dim textColor As Color = If(isSelected, Color.Black, cb.ForeColor)

        Using bgBrush As New SolidBrush(backColor), textBrush As New SolidBrush(textColor)
            e.Graphics.FillRectangle(bgBrush, e.Bounds)
            e.Graphics.DrawString(cb.Items(e.Index).ToString(), e.Font, textBrush, e.Bounds.X + 2, e.Bounds.Y + 2)
        End Using

        e.DrawFocusRectangle()
    End Sub

    Private Sub txtStudentID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudentID.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Force loading records for current logged-in student only
            LoadActiveBorrows(UserSession.CurrentUserID)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub LoadActiveBorrows(studentID As String)
        ' Enforce using current session user ID
        Dim currentID As String = UserSession.CurrentUserID
        If String.IsNullOrWhiteSpace(currentID) Then Return

        Dim query As String = "SELECT b.borrow_ID, b.stu_ID, b.book_ID, bk.title, bk.author, b.borrow_date, b.due_date " &
                              "FROM borrow b " &
                              "JOIN book bk ON b.book_ID = bk.book_ID " &
                              "WHERE b.stu_ID = @stuID AND b.borrow_status = 'Borrowed'"

        Using conn As New MySqlConnection(ConnString)
            Try
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@stuID", currentID)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                If dgvActiveBorrows IsNot Nothing Then
                    dgvActiveBorrows.DataSource = table
                End If
            Catch ex As Exception
                MessageBox.Show("Failed to load active borrows: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' 6. Database Return Transaction Processing
    Private Sub btnProcessReturn_Click(sender As Object, e As EventArgs) Handles btnProcessReturn.Click
        If dgvActiveBorrows Is Nothing OrElse dgvActiveBorrows.CurrentRow Is Nothing OrElse dgvActiveBorrows.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an active borrow record from the table.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Enforce security by reading student ID directly from UserSession
        Dim studentID As String = UserSession.CurrentUserID
        If String.IsNullOrWhiteSpace(studentID) Then
            MessageBox.Show("Invalid session student ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedBorrowID As Integer = Convert.ToInt32(dgvActiveBorrows.CurrentRow.Cells("borrow_ID").Value)
        Dim selectedBookID As Integer = Convert.ToInt32(dgvActiveBorrows.CurrentRow.Cells("book_ID").Value)
        Dim conditionText As String = If(cmbCondition.SelectedItem IsNot Nothing, cmbCondition.SelectedItem.ToString(), "Good")
        Dim noteText As String = If(txtNotes IsNot Nothing, txtNotes.Text.Trim(), "")

        Using conn As New MySqlConnection(ConnString)
            Try
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim sqlReturn As String = "INSERT INTO returns (borrow_ID, stu_ID, book_ID, is_cover_intact, is_no_missing_pages, is_no_scribbling, overall_condition, notes) " &
                                                  "VALUES (@bID, @sID, @bkID, @chk1, @chk2, @chk3, @cond, @notes)"
                        Using cmd1 As New MySqlCommand(sqlReturn, conn, transaction)
                            cmd1.Parameters.AddWithValue("@bID", selectedBorrowID)
                            cmd1.Parameters.AddWithValue("@sID", studentID)
                            cmd1.Parameters.AddWithValue("@bkID", selectedBookID)
                            cmd1.Parameters.AddWithValue("@chk1", If(chkCoverIntact IsNot Nothing AndAlso chkCoverIntact.Checked, 1, 0))
                            cmd1.Parameters.AddWithValue("@chk2", If(chkNoMissingPages IsNot Nothing AndAlso chkNoMissingPages.Checked, 1, 0))
                            cmd1.Parameters.AddWithValue("@chk3", If(chkNoScribbling IsNot Nothing AndAlso chkNoScribbling.Checked, 1, 0))
                            cmd1.Parameters.AddWithValue("@cond", conditionText)
                            cmd1.Parameters.AddWithValue("@notes", noteText)
                            cmd1.ExecuteNonQuery()
                        End Using

                        Dim sqlBorrow As String = "UPDATE borrow SET borrow_status = 'Returned', actual_return_date = CURDATE() WHERE borrow_ID = @bID"
                        Using cmd2 As New MySqlCommand(sqlBorrow, conn, transaction)
                            cmd2.Parameters.AddWithValue("@bID", selectedBorrowID)
                            cmd2.ExecuteNonQuery()
                        End Using

                        Dim bookStatus As String = "Available"
                        If conditionText.Contains("Damaged") Then
                            bookStatus = "Maintenance"
                        ElseIf conditionText.Contains("Lost") Then
                            bookStatus = "Lost"
                        End If

                        Dim sqlBook As String = "UPDATE book SET  quantity = 1, Status = @status WHERE book_ID = @bkID"
                        Using cmd3 As New MySqlCommand(sqlBook, conn, transaction)
                            cmd3.Parameters.AddWithValue("@status", bookStatus)
                            cmd3.Parameters.AddWithValue("@bkID", selectedBookID)
                            cmd3.ExecuteNonQuery()
                        End Using

                        transaction.Commit()
                        MessageBox.Show("Book return processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        If txtNotes IsNot Nothing Then txtNotes.Clear()
                        LoadActiveBorrows(studentID)

                    Catch ex As Exception
                        transaction.Rollback()
                        MessageBox.Show("Database Transaction Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Connection Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Panel_Header_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Header.Paint

    End Sub
End Class