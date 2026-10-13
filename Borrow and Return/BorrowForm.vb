'CHEAH WEI EN -A25DW0096 (SECTION J1)
Imports MySql.Data.MySqlClient
Imports System.Drawing.Text

Public Class BorrowForm

    ' Database connection string
    Private connectionString As String = "server=localhost;database=nicelymini;uid=root;pwd=;"

    ' Flag to track whether the Student/Member ID has been successfully verified via Find button
    Private isStudentValid As Boolean = False

    ' Sidebar Drawer Animation Controls
    Private isSidebarOpen As Boolean = False
    Private Const SidebarWidth As Integer = 280
    Private Const HideX As Integer = -280
    Private Const ShowX As Integer = 0

    ' Color definitions for sidebar button hover states
    Private ReadOnly Color_Normal_White As Color = Color.White
    Private ReadOnly Color_Hover_Gold As Color = Color.FromArgb(212, 175, 55)
    Private selectedBookID As Integer = -1

    Public Sub New(Optional bookID As Integer = -1)
        InitializeComponent()
        selectedBookID = bookID
    End Sub

    ' Form Load & Initialization Events
    Private Sub BorrowForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Strictly restrict access to Student role only
        If UserSession.CurrentRole <> "Student" Then
            MessageBox.Show("Access Denied! This page is restricted to students only.", "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Exit Sub
        End If
        ' ==================================================================

        If Panel_Sidebar3 IsNot Nothing AndAlso Not Me.Controls.Contains(Panel_Sidebar3) Then
            Me.Controls.Add(Panel_Sidebar3)
        End If

        If Panel_Sidebar3 IsNot Nothing AndAlso Panel_Header IsNot Nothing Then
            Dim headerH As Integer = Panel_Header.Height
            Panel_Sidebar3.Size = New Size(SidebarWidth, Me.ClientSize.Height - headerH)
            Panel_Sidebar3.Location = New Point(HideX, headerH)
            Panel_Sidebar3.BringToFront()
        End If


        If Timer_Sidebar IsNot Nothing Then
            Timer_Sidebar.Interval = 10
        End If

        InitializeNavButtonStyles()
        ConfigureDataGridView()
        LoadAvailableBooks()
    End Sub

    Private Sub BorrowForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Panel_Sidebar3 IsNot Nothing AndAlso Panel_Header IsNot Nothing Then
            Panel_Sidebar3.Height = Me.ClientSize.Height - Panel_Header.Height
        End If
    End Sub

    ' Sliding Drawer Sidebar Animation Logic
    Private Sub Btn_Toggle_Click(sender As Object, e As EventArgs) Handles Btn_Toggle.Click
        If Panel_Sidebar3 IsNot Nothing AndAlso Timer_Sidebar IsNot Nothing Then
            Panel_Sidebar3.BringToFront()
            Timer_Sidebar.Start()
        End If
    End Sub

    Private Sub Timer_Sidebar_Tick(sender As Object, e As EventArgs) Handles Timer_Sidebar.Tick
        If Panel_Sidebar3 Is Nothing OrElse Panel_Header Is Nothing Then Return
        Dim currentX As Integer = Panel_Sidebar3.Location.X
        Dim headerH As Integer = Panel_Header.Height

        If isSidebarOpen Then
            currentX -= 30
            If currentX <= HideX Then
                Panel_Sidebar3.Location = New Point(HideX, headerH)
                isSidebarOpen = False
                Timer_Sidebar.Stop()
            Else
                Panel_Sidebar3.Location = New Point(currentX, headerH)
            End If
        Else
            currentX += 30
            If currentX >= ShowX Then
                Panel_Sidebar3.Location = New Point(ShowX, headerH)
                isSidebarOpen = True
                Timer_Sidebar.Stop()
            Else
                Panel_Sidebar3.Location = New Point(currentX, headerH)
            End If
        End If
    End Sub

    Private Sub Panel_Card_Click(sender As Object, e As EventArgs) Handles Panel_Card.Click
        If isSidebarOpen AndAlso Timer_Sidebar IsNot Nothing Then
            Timer_Sidebar.Start()
        End If
    End Sub

    ' Sidebar Navigation Buttons Style & Events
    Private Sub InitializeNavButtonStyles()
        Dim navButtons() As Button = {
            Btn_Nav_Dashboard, Btn_Nav_Books,
            Btn_Nav_Return, Btn_Nav_History,
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
        Btn_Nav_Dashboard.MouseEnter, Btn_Nav_Books.MouseEnter,
        Btn_Nav_Return.MouseEnter, Btn_Nav_History.MouseEnter,
        Btn_Nav_About.MouseEnter, Btn_Nav_Logout.MouseEnter

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing Then btn.ForeColor = Color_Hover_Gold
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles _
        Btn_Nav_Dashboard.MouseLeave, Btn_Nav_Books.MouseLeave,
        Btn_Nav_Return.MouseLeave, Btn_Nav_History.MouseLeave,
        Btn_Nav_About.MouseLeave, Btn_Nav_Logout.MouseLeave

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing Then btn.ForeColor = Color_Normal_White
    End Sub

    ' Sidebar Navigation Routing
    Private Sub NavButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = TryCast(sender, Button)
        If clickedButton Is Nothing Then Return
        Dim targetForm As Form = Nothing

        Select Case clickedButton.Name
            Case "Btn_Nav_Dashboard"
                targetForm = New StudentForm()

            Case "Btn_Nav_Books"
                targetForm = New BookForm()

            Case "Btn_Nav_Return"
                targetForm = New ReturnForm()

            Case "Btn_Nav_History"
                targetForm = New BorrowHistoryForm()

            Case "Btn_Nav_About"
                targetForm = New AboutBox()
            Case "Btn_Nav_Logout"
                MessageBox.Show("Login page is under development.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Application.Exit()
                ClearSession()
        End Select

        ' Navigate and hide current form only when a valid target form is created
        If targetForm IsNot Nothing Then
            If isSidebarOpen AndAlso Panel_Header IsNot Nothing AndAlso Panel_Sidebar3 IsNot Nothing Then
                Panel_Sidebar3.Location = New Point(HideX, Panel_Header.Height)
                isSidebarOpen = False
            End If
            targetForm.ShowDialog()
        End If
    End Sub

    Private Sub ConfigureDataGridView()
        If dgvAvailableBooks Is Nothing Then Return
        With dgvAvailableBooks
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
            .MultiSelect = False
            .BackgroundColor = Color.Black
            .DefaultCellStyle.BackColor = Color.Black
            .DefaultCellStyle.ForeColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 175, 55)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Black
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Gold
        End With
    End Sub

    Private Sub LoadAvailableBooks()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT book_ID, title, author, category, Status FROM book"
                Dim cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                If dgvAvailableBooks IsNot Nothing Then
                    dgvAvailableBooks.DataSource = table
                    If dgvAvailableBooks.Columns.Count > 0 Then
                        If dgvAvailableBooks.Columns.Contains("book_ID") Then dgvAvailableBooks.Columns("book_ID").HeaderText = "Book ID"
                        If dgvAvailableBooks.Columns.Contains("title") Then dgvAvailableBooks.Columns("title").HeaderText = "Title"
                        If dgvAvailableBooks.Columns.Contains("author") Then dgvAvailableBooks.Columns("author").HeaderText = "Author"
                        If dgvAvailableBooks.Columns.Contains("category") Then dgvAvailableBooks.Columns("category").HeaderText = "Category"
                        If dgvAvailableBooks.Columns.Contains("Status") Then dgvAvailableBooks.Columns("Status").HeaderText = "Status"
                    End If
                    ' Automatically select the book passed from Book Detail
                    If selectedBookID <> -1 Then
                        For Each row As DataGridViewRow In dgvAvailableBooks.Rows

                            If row.Cells("book_ID").Value IsNot Nothing AndAlso
                               Not IsDBNull(row.Cells("book_ID").Value) Then

                                If Convert.ToInt32(row.Cells("book_ID").Value) = selectedBookID Then
                                    row.Selected = True
                                    dgvAvailableBooks.CurrentCell = row.Cells("title")
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Failed to load book list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If txtStuID Is Nothing OrElse String.IsNullOrWhiteSpace(txtStuID.Text) Then
            MessageBox.Show("Please enter a Member ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            isStudentValid = False
            Return
        End If

        Dim stuID As Integer
        If Not Integer.TryParse(txtStuID.Text.Trim(), stuID) Then
            MessageBox.Show("Member ID must be a numeric value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            isStudentValid = False
            Return
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM student WHERE stu_ID = @stuID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@stuID", stuID)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        isStudentValid = True
                        MessageBox.Show("Student verified successfully! You may proceed to borrow books.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        isStudentValid = False
                        MessageBox.Show("Member ID not found. Please check your input or register the student first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while validating the student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                isStudentValid = False
            End Try
        End Using
    End Sub

    Private Sub btnConfirmBorrow_Click(sender As Object, e As EventArgs) Handles btnConfirmBorrow.Click
        If txtStuID Is Nothing OrElse String.IsNullOrWhiteSpace(txtStuID.Text) Then
            MessageBox.Show("Please enter a Member ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not isStudentValid Then
            MessageBox.Show("Please click the 'Find' button to verify the Member ID first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If dgvAvailableBooks Is Nothing OrElse dgvAvailableBooks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a book to borrow from the table above!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cellValue = dgvAvailableBooks.SelectedRows(0).Cells("Status").Value
        Dim currentStatus As String = If(cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue), cellValue.ToString(), "")

        If Not currentStatus.Equals("Available", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("This book is currently unavailable for borrowing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim stuID As Integer = Convert.ToInt32(txtStuID.Text.Trim())
        Dim bookID As Integer = Convert.ToInt32(dgvAvailableBooks.SelectedRows(0).Cells("book_ID").Value)
        Dim borrowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim dueDate As String = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd")

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim insertQuery As String = "INSERT INTO borrow (stu_ID, book_ID, borrow_date, due_date, borrow_status) VALUES (@stuID, @bookID, @borrowDate, @dueDate, 'Borrowed')"
                        Using cmdInsert As New MySqlCommand(insertQuery, conn, transaction)
                            cmdInsert.Parameters.AddWithValue("@stuID", stuID)
                            cmdInsert.Parameters.AddWithValue("@bookID", bookID)
                            cmdInsert.Parameters.AddWithValue("@borrowDate", borrowDate)
                            cmdInsert.Parameters.AddWithValue("@dueDate", dueDate)
                            cmdInsert.ExecuteNonQuery()
                        End Using

                        Dim updateQuery As String = "UPDATE book SET quantity = 0, Status = 'Borrowed' WHERE book_ID = @bookID"
                        Using cmdUpdate As New MySqlCommand(updateQuery, conn, transaction)
                            cmdUpdate.Parameters.AddWithValue("@bookID", bookID)
                            cmdUpdate.ExecuteNonQuery()
                        End Using

                        transaction.Commit()
                        MessageBox.Show("Book borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txtStuID.Clear()
                        isStudentValid = False
                        LoadAvailableBooks()

                    Catch ex As Exception
                        transaction.Rollback()
                        MessageBox.Show("Database Transaction failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            Catch ex As Exception
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If txtStuID IsNot Nothing Then txtStuID.Clear()
        isStudentValid = False
        If dgvAvailableBooks IsNot Nothing AndAlso dgvAvailableBooks.Rows.Count > 0 Then
            dgvAvailableBooks.ClearSelection()
        End If
    End Sub

End Class