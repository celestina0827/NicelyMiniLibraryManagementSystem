'CHEAH WEI EN -A25DW0096 (SECTION J1)
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Drawing.Text

Public Class BorrowHistoryForm

    ' Database connection string
    Private connectionString As String = "server=localhost;database=nicelymini;uid=root;pwd=;"

    ' Sidebar drawer animation variables
    Private isSidebarOpen As Boolean = False
    Private Const SidebarWidth As Integer = 280
    Private Const HideX As Integer = -280
    Private Const ShowX As Integer = 0

    ' Sidebar button hover colors
    Private ReadOnly Color_Normal_White As Color = Color.White
    Private ReadOnly Color_Hover_Gold As Color = Color.FromArgb(212, 175, 55)

    ' Form Load Event
    Private Sub BorrowHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

        ' STRICT STUDENT PERMISSION & LOCK CONTROL
        ' 1. Strictly restrict access to Student role only
        If UserSession.CurrentRole <> "Student" Then
            MessageBox.Show("Access Denied! This page is restricted to students only.", "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Exit Sub
        End If

        ' 2. Bind and lock the current logged-in Student ID to prevent checking other users
        If txtStuID IsNot Nothing Then
            txtStuID.Text = UserSession.CurrentUserID
            txtStuID.ReadOnly = True ' Prevent manual editing of student ID
        End If

        ' Enable Find button for status filtering
        If btnFind IsNot Nothing Then
            btnFind.Enabled = True
        End If

        ' Dynamically mount Panel_Sidebar3 control
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

        ' Initialize status dropdown items
        If cmbStatus IsNot Nothing Then
            cmbStatus.Items.Clear()
            cmbStatus.Items.Add("All")
            cmbStatus.Items.Add("Borrowed")
            cmbStatus.Items.Add("Returned")
            cmbStatus.Items.Add("Overdue")
            cmbStatus.SelectedIndex = 0
        End If

        InitializeNavButtonStyles()
        ConfigureDataGridView()

        ' Automatically load ONLY the current student's borrow history upon opening
        LoadBorrowHistory(UserSession.CurrentUserID, "All")
    End Sub

    ' Adjust sidebar height on form resize
    Private Sub BorrowHistoryForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Panel_Sidebar3 IsNot Nothing AndAlso Panel_Header IsNot Nothing Then
            Panel_Sidebar3.Height = Me.ClientSize.Height - Panel_Header.Height
        End If
    End Sub

    ' Sidebar sliding animation toggle
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

    ' Close sidebar when clicking outside on the background card
    Private Sub Panel_Card_Click(sender As Object, e As EventArgs) Handles Panel_Card.Click
        If isSidebarOpen AndAlso Timer_Sidebar IsNot Nothing Then
            Timer_Sidebar.Start()
        End If
    End Sub

    ' Initialize navigation button styles and event routing
    Private Sub InitializeNavButtonStyles()
        Dim navButtons() As Button = {
            Btn_Nav_Dashboard, Btn_Nav_Books, Btn_Nav_Borrows,
            Btn_Nav_Return, Btn_Nav_About, Btn_Nav_Logout
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
        Btn_Nav_Return.MouseEnter, Btn_Nav_About.MouseEnter,
        Btn_Nav_Logout.MouseEnter

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing Then btn.ForeColor = Color_Hover_Gold
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles _
        Btn_Nav_Dashboard.MouseLeave, Btn_Nav_Books.MouseLeave,
        Btn_Nav_Return.MouseLeave, Btn_Nav_About.MouseLeave,
        Btn_Nav_Logout.MouseLeave

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing Then btn.ForeColor = Color_Normal_White
    End Sub

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
            Case "Btn_Nav_Return"
                targetForm = New ReturnForm()
            Case "Btn_Nav_About"
                targetForm = New AboutBox()

            Case "Btn_Nav_Logout"
                MessageBox.Show("Login page is under development.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Application.Exit()
                ClearSession()

        End Select

        If targetForm IsNot Nothing Then
            If isSidebarOpen AndAlso Panel_Header IsNot Nothing AndAlso Panel_Sidebar3 IsNot Nothing Then
                Panel_Sidebar3.Location = New Point(HideX, Panel_Header.Height)
                isSidebarOpen = False
            End If
            targetForm.ShowDialog()
        End If
    End Sub

    ' Configure DataGridView styling and bind designer-created columns
    Private Sub ConfigureDataGridView()
        If dgvBorrowHistory Is Nothing Then Return
        With dgvBorrowHistory
            .AutoGenerateColumns = False

            Dim colMappings As New Dictionary(Of String, String) From {
                {"borrow_ID", "borrow_ID"},
                {"stu_ID", "stu_ID"},
                {"student_name", "student_name"},
                {"book_title", "book_title"},
                {"borrow_date", "borrow_date"},
                {"due_date", "due_date"},
                {"return_date", "return_date"},
                {"status", "status"}
            }

            Dim colIndex As Integer = 0
            For Each propName In colMappings.Values
                If .Columns.Contains(propName) Then
                    .Columns(propName).DataPropertyName = propName
                ElseIf colIndex < .Columns.Count Then
                    .Columns(colIndex).DataPropertyName = propName
                End If
                colIndex += 1
            Next

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
            .MultiSelect = False
            .BackgroundColor = Color.Black

            .DefaultCellStyle.BackColor = Color.Black
            .DefaultCellStyle.ForeColor = Color.Goldenrod
            .DefaultCellStyle.SelectionBackColor = Color.DarkGoldenrod
            .DefaultCellStyle.SelectionForeColor = Color.Black

            .AlternatingRowsDefaultCellStyle.BackColor = Color.Black
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.Goldenrod
            .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.DarkGoldenrod
            .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black

            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Black
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Gold
            .ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Beige
            .ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black

            .RowHeadersDefaultCellStyle.SelectionBackColor = Color.Beige
        End With
    End Sub

    ' Load and filter borrow history records (Forced Student Privacy Isolation + NULL Safe)
    Private Sub LoadBorrowHistory(Optional ByVal studentIDFilter As String = "", Optional ByVal statusFilter As String = "All")
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                'Use `IFNULL` to ensure that borrowed items that have not been returned (with no record in the `returns` table) are still fully retrieved.

                Dim query As String = "SELECT br.borrow_ID, br.stu_ID, s.stu_name AS student_name, b.title AS book_title, " &
                                      "br.borrow_date, br.due_date, br.actual_return_date AS return_date, br.borrow_status As status, " &
                                      "IFNULL(rt.is_cover_intact, -1) AS is_cover_intact, " &
                                      "IFNULL(rt.is_no_missing_pages, -1) AS is_no_missing_pages, " &
                                      "IFNULL(rt.is_no_scribbling, -1) AS is_no_scribbling, " &
                                      "IFNULL(rt.overall_condition, 'N/A') AS overall_condition, " &
                                      "IFNULL(rt.notes, 'None') AS notes " &
                                      "FROM borrow br " &
                                      "LEFT JOIN student s ON br.stu_ID = s.stu_ID " &
                                      "LEFT JOIN book b ON br.book_ID = b.book_ID " &
                                      "LEFT JOIN returns rt ON br.borrow_ID = rt.borrow_ID WHERE 1=1"

                ' Force SQL query to filter by Current Logged-in Student ID only
                If Not String.IsNullOrWhiteSpace(studentIDFilter) Then
                    query &= " AND br.stu_ID = @stuID"
                End If

                'Use `LOWER` and `TRIM` to prevent search failures caused by extra spaces or inconsistent letter casing in the database status field.
                If Not String.IsNullOrWhiteSpace(statusFilter) AndAlso Not statusFilter.Equals("All", StringComparison.OrdinalIgnoreCase) Then
                    query &= " AND LOWER(TRIM(br.borrow_status)) = LOWER(@status)"
                End If

                query &= " ORDER BY br.borrow_ID DESC"

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrWhiteSpace(studentIDFilter) Then
                        cmd.Parameters.AddWithValue("@stuID", studentIDFilter.Trim())
                    End If
                    If Not String.IsNullOrWhiteSpace(statusFilter) AndAlso Not statusFilter.Equals("All", StringComparison.OrdinalIgnoreCase) Then
                        cmd.Parameters.AddWithValue("@status", statusFilter.Trim())
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If dgvBorrowHistory IsNot Nothing Then
                        dgvBorrowHistory.DataSource = table
                        SetGridHeaderNames()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Failed to load borrow history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Rename DataGridView column headers
    Private Sub SetGridHeaderNames()
        If dgvBorrowHistory IsNot Nothing AndAlso dgvBorrowHistory.Columns.Count > 0 Then
            If dgvBorrowHistory.Columns.Contains("borrow_ID") Then dgvBorrowHistory.Columns("borrow_ID").HeaderText = "Borrow ID"
            If dgvBorrowHistory.Columns.Contains("stu_ID") Then dgvBorrowHistory.Columns("stu_ID").HeaderText = "Student ID"
            If dgvBorrowHistory.Columns.Contains("student_name") Then dgvBorrowHistory.Columns("student_name").HeaderText = "Student Name"
            If dgvBorrowHistory.Columns.Contains("book_title") Then dgvBorrowHistory.Columns("book_title").HeaderText = "Book Title"
            If dgvBorrowHistory.Columns.Contains("borrow_date") Then dgvBorrowHistory.Columns("borrow_date").HeaderText = "Borrow Date"
            If dgvBorrowHistory.Columns.Contains("due_date") Then dgvBorrowHistory.Columns("due_date").HeaderText = "Due Date"
            If dgvBorrowHistory.Columns.Contains("return_date") Then dgvBorrowHistory.Columns("return_date").HeaderText = "Return Date"
            If dgvBorrowHistory.Columns.Contains("status") Then dgvBorrowHistory.Columns("status").HeaderText = "Status"
        End If
    End Sub

    ' FIND button click event / Status dropdown change handler
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        ' Force filtering using UserSession.CurrentUserID to prevent unauthorized search
        Dim stuID As String = UserSession.CurrentUserID
        Dim selectedStatus As String = If(cmbStatus IsNot Nothing AndAlso cmbStatus.SelectedItem IsNot Nothing, cmbStatus.SelectedItem.ToString(), "All")

        LoadBorrowHistory(stuID, selectedStatus)
    End Sub

    ' Row selection change event to populate bottom detail cards
    Private Sub dgvBorrowHistory_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBorrowHistory.SelectionChanged
        If dgvBorrowHistory IsNot Nothing AndAlso dgvBorrowHistory.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvBorrowHistory.SelectedRows(0)

            ' Inspection Info
            lblBorrowIDValue.Text = GetRowValue(row, "borrow_ID")
            lblStudentNameValue.Text = GetRowValue(row, "student_name")
            lblBookTitleValue.Text = GetRowValue(row, "book_title")
            lblStatusValue.Text = GetRowValue(row, "status")

            ' Time Trail Info
            Dim borrowDateStr As String = GetRowValue(row, "borrow_date", "")
            Dim dueDateStr As String = GetRowValue(row, "due_date", "")
            Dim returnDateStr As String = GetRowValue(row, "return_date", "")

            Dim parsedBorrowDate As DateTime
            If DateTime.TryParse(borrowDateStr, parsedBorrowDate) Then
                lblBorrowDateValue.Text = parsedBorrowDate.ToString("yyyy-MM-dd")
            Else
                lblBorrowDateValue.Text = "---"
            End If

            Dim parsedDueDate As DateTime
            If DateTime.TryParse(dueDateStr, parsedDueDate) Then
                lblDueDateValue.Text = parsedDueDate.ToString("yyyy-MM-dd")
            Else
                lblDueDateValue.Text = "---"
            End If

            Dim parsedReturnDate As DateTime
            Dim hasReturned As Boolean = DateTime.TryParse(returnDateStr, parsedReturnDate)
            If hasReturned Then
                lblReturnDateValue.Text = parsedReturnDate.ToString("yyyy-MM-dd")
            Else
                lblReturnDateValue.Text = "---"
            End If

            ' Calculate Overdue Days
            If hasReturned OrElse DateTime.TryParse(dueDateStr, parsedDueDate) Then
                Dim endDate As DateTime = If(hasReturned, parsedReturnDate, DateTime.Now)
                Dim overdueDays As Integer = CInt((endDate - parsedDueDate).TotalDays)

                lblOverdueDaysValue.Text = If(overdueDays > 0, overdueDays.ToString() & " Days", "0 Days")
            Else
                lblOverdueDaysValue.Text = "---"
            End If

            lblCoverIntactValue.Text = FormatChecklistValue(GetRowValue(row, "is_cover_intact", ""))
            lblPagesIntactValue.Text = FormatChecklistValue(GetRowValue(row, "is_no_missing_pages", ""))
            lblScribblingValue.Text = FormatChecklistValue(GetRowValue(row, "is_no_scribbling", ""))
            lblConditionValue.Text = GetRowValue(row, "overall_condition", "---")

            If txtNotesRemarks IsNot Nothing Then
                txtNotesRemarks.Text = GetRowValue(row, "notes", "")
            End If
        Else
            ResetDetailLabels()
        End If
    End Sub

    ' Reset bottom detail panels
    Private Sub ResetDetailLabels()
        lblBorrowIDValue.Text = "---"
        lblStudentNameValue.Text = "---"
        lblBookTitleValue.Text = "---"
        lblStatusValue.Text = "---"

        lblBorrowDateValue.Text = "---"
        lblDueDateValue.Text = "---"
        lblReturnDateValue.Text = "---"
        lblOverdueDaysValue.Text = "---"

        lblCoverIntactValue.Text = "---"
        lblPagesIntactValue.Text = "---"
        lblScribblingValue.Text = "---"
        lblConditionValue.Text = "---"

        If txtNotesRemarks IsNot Nothing Then txtNotesRemarks.Clear()
    End Sub

    ' PRINT button click event
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgvBorrowHistory IsNot Nothing AndAlso dgvBorrowHistory.Rows.Count > 0 Then
            Dim printDoc As New PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage

            Dim printPreview As New PrintPreviewDialog()
            printPreview.Document = printDoc
            printPreview.ShowDialog()
        Else
            MessageBox.Show("No borrow history records to print!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Draw printable page for the detailed history report
    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics

        ' Set high rendering quality
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality

        ' Color Palette Setup
        Dim colorPrimary As Color = Color.FromArgb(20, 24, 33)
        Dim colorAccent As Color = Color.FromArgb(212, 175, 55)
        Dim colorBgCard As Color = Color.FromArgb(250, 250, 252)
        Dim colorBorder As Color = Color.FromArgb(210, 215, 222)
        Dim colorTextDark As Color = Color.FromArgb(30, 41, 59)
        Dim colorTextMuted As Color = Color.FromArgb(100, 116, 139)

        ' Font Definitions
        Dim fontTitle As New Font("Segoe UI", 16, FontStyle.Bold, GraphicsUnit.Point)
        Dim fontSubTitle As New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        Dim fontBadge As New Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        Dim fontHeader As New Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        Dim fontLabel As New Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        Dim fontValue As New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)

        ' Dimensions & Margins
        Dim leftMargin As Single = 40
        Dim rightMargin As Single = e.MarginBounds.Right + 30
        Dim yPos As Single = 30
        Dim printableWidth As Single = rightMargin - leftMargin

        ' 1. Draw Top Header Banner
        g.FillRectangle(New SolidBrush(colorPrimary), leftMargin, yPos, printableWidth, 55)
        g.FillRectangle(New SolidBrush(colorAccent), leftMargin, yPos + 51, printableWidth, 4)

        g.DrawString("PERSONAL BORROW & RETURN HISTORY REPORT", fontTitle, Brushes.White, leftMargin + 15, yPos + 10)
        g.DrawString("GENERATED ON: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").ToUpper(), fontSubTitle, New SolidBrush(Color.FromArgb(180, 200, 220)), leftMargin + 16, yPos + 34)

        yPos += 75

        ' 2. Iterate and Render Card Blocks
        For Each row As DataGridViewRow In dgvBorrowHistory.Rows
            If Not row.IsNewRow Then

                Dim cardHeight As Single = 125

                ' Page overflow logic
                If yPos + cardHeight > e.MarginBounds.Bottom - 30 Then
                    e.HasMorePages = True
                    Return
                End If

                ' Data Extraction
                Dim bID As String = GetRowValue(row, "borrow_ID", "---")
                Dim sID As String = GetRowValue(row, "stu_ID", "---")
                Dim sName As String = GetRowValue(row, "student_name", "---")
                Dim title As String = GetRowValue(row, "book_title", "---")
                Dim status As String = GetRowValue(row, "status", "---")

                Dim bDate As String = GetRowValue(row, "borrow_date", "")
                Dim dDate As String = GetRowValue(row, "due_date", "")
                Dim rDate As String = GetRowValue(row, "return_date", "")

                Dim parsedBDate, parsedDDate, parsedRDate As DateTime
                Dim strBDate As String = If(DateTime.TryParse(bDate, parsedBDate), parsedBDate.ToString("yyyy-MM-dd"), "---")
                Dim strDDate As String = If(DateTime.TryParse(dDate, parsedDDate), parsedDDate.ToString("yyyy-MM-dd"), "---")
                Dim hasReturned As Boolean = DateTime.TryParse(rDate, parsedRDate)
                Dim strRDate As String = If(hasReturned, parsedRDate.ToString("yyyy-MM-dd"), "---")

                ' Calculate Overdue
                Dim overdueStr As String = "0 Days"
                Dim isOverdue As Boolean = False
                If hasReturned OrElse DateTime.TryParse(dDate, parsedDDate) Then
                    Dim endDate As DateTime = If(hasReturned, parsedRDate, DateTime.Now)
                    Dim overdueDays As Integer = CInt((endDate - parsedDDate).TotalDays)
                    If overdueDays > 0 Then
                        overdueStr = overdueDays.ToString() & " Days"
                        isOverdue = True
                    End If
                End If

                Dim coverIntact As String = FormatChecklistValue(GetRowValue(row, "is_cover_intact", ""))
                Dim pagesIntact As String = FormatChecklistValue(GetRowValue(row, "is_no_missing_pages", ""))
                Dim scribbling As String = FormatChecklistValue(GetRowValue(row, "is_no_scribbling", ""))
                Dim condition As String = GetRowValue(row, "overall_condition", "---")
                Dim notes As String = GetRowValue(row, "notes", "None")

                ' Status Bar Color Indicator (Left Strip)
                Dim statusStripColor As Color = Color.FromArgb(71, 85, 105)
                If status.Equals("Returned", StringComparison.OrdinalIgnoreCase) Then
                    statusStripColor = Color.FromArgb(16, 185, 129) ' Green
                ElseIf status.Equals("Borrowed", StringComparison.OrdinalIgnoreCase) Then
                    statusStripColor = Color.FromArgb(245, 158, 11) ' Amber Gold
                ElseIf isOverdue OrElse status.Equals("Overdue", StringComparison.OrdinalIgnoreCase) Then
                    statusStripColor = Color.FromArgb(239, 68, 68) ' Red
                End If

                ' Card Container Base
                g.FillRectangle(New SolidBrush(colorBgCard), leftMargin, yPos, printableWidth, cardHeight)
                g.DrawRectangle(New Pen(colorBorder, 1.0F), leftMargin, yPos, printableWidth, cardHeight)
                ' Left Accent Color Bar
                g.FillRectangle(New SolidBrush(statusStripColor), leftMargin, yPos, 6, cardHeight)

                Dim contentX As Single = leftMargin + 18
                Dim currentY As Single = yPos + 10

                ' Row 1: Header Line
                g.DrawString("#BID-" & bID, fontHeader, New SolidBrush(colorPrimary), contentX, currentY)
                g.DrawString("Student: ", fontLabel, New SolidBrush(colorTextMuted), contentX + 85, currentY)
                g.DrawString(sName & " (" & sID & ")", fontBadge, New SolidBrush(colorTextDark), contentX + 138, currentY)

                g.DrawString("Book: ", fontLabel, New SolidBrush(colorTextMuted), contentX + 370, currentY)
                g.DrawString(If(title.Length > 28, title.Substring(0, 25) & "...", title), fontBadge, New SolidBrush(colorTextDark), contentX + 410, currentY)

                ' Status Badge Right Corner
                Dim badgeRect As New RectangleF(rightMargin - 95, currentY - 2, 85, 20)
                g.FillRectangle(New SolidBrush(Color.FromArgb(25, statusStripColor)), badgeRect)
                g.DrawRectangle(New Pen(statusStripColor, 1.0F), badgeRect.X, badgeRect.Y, badgeRect.Width, badgeRect.Height)

                Dim sf As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
                g.DrawString(status.ToUpper(), fontBadge, New SolidBrush(statusStripColor), badgeRect, sf)

                ' Sub Separator Line
                currentY += 24
                g.DrawLine(New Pen(colorBorder), contentX, currentY, rightMargin - 15, currentY)
                currentY += 10

                ' Row 2: Time Trail Grid
                g.DrawString("TIME TRAIL", fontLabel, New SolidBrush(colorAccent), contentX, currentY)
                currentY += 16
                g.DrawString("Borrow:" & strBDate, fontValue, New SolidBrush(colorTextDark), contentX, currentY)
                g.DrawString("Due: " & strDDate, fontValue, New SolidBrush(colorTextDark), contentX + 140, currentY)
                g.DrawString("Returned:" & strRDate, fontValue, New SolidBrush(colorTextDark), contentX + 280, currentY)
                g.DrawString("Overdue: " & overdueStr, fontValue, If(isOverdue, Brushes.Red, New SolidBrush(colorTextDark)), contentX + 430, currentY)

                ' Row 3: Inspection & Condition Grid
                currentY += 20
                g.DrawString("INSPECTION", fontLabel, New SolidBrush(colorAccent), contentX, currentY)
                currentY += 16
                g.DrawString("Cover:" & coverIntact, fontValue, New SolidBrush(colorTextDark), contentX, currentY)
                g.DrawString("Pages:" & pagesIntact, fontValue, New SolidBrush(colorTextDark), contentX + 140, currentY)
                g.DrawString("Scribble:" & scribbling, fontValue, New SolidBrush(colorTextDark), contentX + 280, currentY)
                g.DrawString("Condition:" & condition, fontValue, New SolidBrush(colorTextDark), contentX + 430, currentY)

                ' Row 4: Remarks Footer
                currentY += 18
                g.DrawString("Notes:" & notes, fontValue, New SolidBrush(colorTextMuted), contentX, currentY)

                ' Spacing for Next Card Block
                yPos += cardHeight + 14
            End If
        Next

        ' 3. Report Footer
        Dim footerY As Single = e.MarginBounds.Bottom + 10
        g.DrawLine(New Pen(colorBorder), leftMargin, footerY, rightMargin, footerY)
        g.DrawString("Library Management System — Personal Borrow History Report", fontSubTitle, New SolidBrush(colorTextMuted), leftMargin, footerY + 5)
        g.DrawString("Page 1", fontSubTitle, New SolidBrush(colorTextMuted), rightMargin - 40, footerY + 5)

        e.HasMorePages = False
    End Sub

    ' Helper Functions
    Private Function FormatChecklistValue(ByVal rawVal As String) As String
        If rawVal = "1" OrElse rawVal.Equals("True", StringComparison.OrdinalIgnoreCase) Then
            Return "[√] Yes"
        ElseIf rawVal = "0" OrElse rawVal.Equals("False", StringComparison.OrdinalIgnoreCase) Then
            Return "[X] No"
        Else
            Return "---"
        End If
    End Function

    Private Function GetRowValue(ByVal row As DataGridViewRow, ByVal columnName As String, Optional ByVal defaultValue As String = "---") As String
        If row.DataBoundItem IsNot Nothing Then
            Dim drv As DataRowView = TryCast(row.DataBoundItem, DataRowView)
            If drv IsNot Nothing AndAlso drv.Row.Table.Columns.Contains(columnName) Then
                Dim val = drv.Row(columnName)
                If val IsNot Nothing AndAlso Not IsDBNull(val) Then
                    Return val.ToString()
                End If
            End If
        End If

        If row.DataGridView IsNot Nothing AndAlso row.DataGridView.Columns.Contains(columnName) Then
            Dim val = row.Cells(columnName).Value
            If val IsNot Nothing AndAlso Not IsDBNull(val) Then Return val.ToString()
        End If

        Return defaultValue
    End Function
End Class