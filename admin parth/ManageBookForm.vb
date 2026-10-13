'CELESTINA ONG YING XUAN- A25DW0191 (SECTION J1)
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class ManageBookForm

    ' --- Global Variables & Constants ---
    Dim connString As String = "server=localhost;userid=root;password=;database=nicelymini"
    Dim currentAdminID As Integer = 1

    ' Sidebar animation variables
    Dim isSidebarOpen As Boolean = False
    Const SidebarWidth As Integer = 180
    Const HideX As Integer = -180
    Const ShowX As Integer = 0

#Region "Form Load & Initialization"

    Private Sub ManageBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Initialize sidebar position
        pnlSidebar.BackColor = Color.FromArgb(20, 20, 20)
        pnlSidebar.Width = SidebarWidth
        pnlSidebar.Height = Me.ClientSize.Height
        pnlSidebar.Location = New Point(HideX, 0)
        pnlSidebar.BringToFront()
        btnMenu.BringToFront()

        ' 2. Bind sidebar button hover and click effects dynamically
        Dim navButtons() As Button = {btnDashboard, btnStudent, btnReport, btnSettings, btnAbout, btnLogOut}
        For Each btn As Button In navButtons
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.Transparent
            btn.ForeColor = Color.White
            AddHandler btn.MouseEnter, AddressOf NavButton_MouseEnter
            AddHandler btn.MouseLeave, AddressOf NavButton_MouseLeave
            AddHandler btn.Click, AddressOf NavButton_ClickHandler
        Next

        ' 3. Apply Gold Style, Rounded Corners, and Hover Effects to action buttons
        Dim actionBtns() As Button = {btnAdd, btnClear, btnDelete, btnSearch, btnUpdate, btnBrowseImage}
        For Each btn As Button In actionBtns
            StyleGoldButton(btn)
            AddHandler btn.MouseEnter, AddressOf ActionButton_MouseEnter
            AddHandler btn.MouseLeave, AddressOf ActionButton_MouseLeave
        Next

        ' 4. Initialize DataGridView and Dropdown styles
        StyleDataGridView()
        StyleFilter(cmbCategory)
        StyleFilter(cmbStatus)

        ' 5. Load Database Records
        LoadBookData()
    End Sub

#End Region

#Region "Core CRUD Operations (Database) & Image Handling"

    ' [READ] Fetch and load books into DataGridView
    Private Sub LoadBookData()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT book_ID, title, author, category, quantity, Status, Cover_image, description FROM book"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvBook.Rows.Clear()

                        While reader.Read()
                            ' Use a 1x1 transparent bitmap as a fallback to prevent the Red X error
                            Dim images As Image = New Bitmap(1, 1)
                            Dim imagePath As String = ""

                            ' Image processing logic
                            If Not IsDBNull(reader("Cover_image")) Then
                                imagePath = reader("Cover_image").ToString()
                                Dim fullPath As String = IO.Path.Combine(Application.StartupPath, imagePath)

                                If IO.File.Exists(fullPath) Then
                                    Using originalImage As Image = Image.FromFile(fullPath)
                                        Dim ratio As Double = Math.Min(180 / originalImage.Width, 180 / originalImage.Height)
                                        Dim newWidth As Integer = CInt(originalImage.Width * ratio)
                                        Dim newHeight As Integer = CInt(originalImage.Height * ratio)
                                        images = New Bitmap(originalImage, newWidth, newHeight)
                                    End Using
                                End If
                            End If

                            ' Add row data strictly matching the 9 UI columns
                            dgvBook.Rows.Add(
                                reader("book_ID").ToString(),
                                reader("title").ToString(),
                                reader("author").ToString(),
                                reader("category").ToString(),
                                reader("quantity").ToString(),
                                reader("Status").ToString(),
                                images,
                                imagePath,
                                reader("description").ToString()
                            )
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading books: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' [CREATE] Add New Book
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "INSERT INTO book(book_ID, admin_ID, title, author, category, quantity, Status, Cover_image, description) " &
                                      "VALUES(@book_ID, @admin_ID, @title, @author, @category, @quantity, @Status, @Cover_image, @description)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@book_ID", txtBookID.Text.Trim())
                    cmd.Parameters.AddWithValue("@admin_ID", currentAdminID)
                    cmd.Parameters.AddWithValue("@title", txttitle.Text.Trim())
                    cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim())
                    cmd.Parameters.AddWithValue("@category", cmbCategory.Text)
                    cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text.Trim())
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                    cmd.Parameters.AddWithValue("@Cover_image", txtImage.Text.Trim())
                    cmd.Parameters.AddWithValue("@description", txtboxDesc.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadBookData()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error adding book: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' [UPDATE] Update Book Details
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtBookID.Text) Then
            MessageBox.Show("Please select a book to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "UPDATE book SET title=@title, author=@author, category=@category, quantity=@quantity, " &
                                      "Status=@Status, Cover_image=@Cover_image, description=@description WHERE book_ID=@book_ID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@book_ID", txtBookID.Text.Trim())
                    cmd.Parameters.AddWithValue("@title", txttitle.Text.Trim())
                    cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim())
                    cmd.Parameters.AddWithValue("@category", cmbCategory.Text)
                    cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text.Trim())
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                    cmd.Parameters.AddWithValue("@Cover_image", txtImage.Text.Trim())
                    cmd.Parameters.AddWithValue("@description", txtboxDesc.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadBookData()

        Catch ex As Exception
            MessageBox.Show("Error updating book: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' [DELETE] Delete Book
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtBookID.Text) Then
            MessageBox.Show("Please select a book to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(connString)
                    conn.Open()
                    Dim query As String = "DELETE FROM book WHERE book_ID=@book_ID"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@book_ID", txtBookID.Text.Trim())
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                LoadBookData()

            Catch ex As Exception
                MessageBox.Show("Error deleting book: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' [SEARCH] Search Books dynamically
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT book_ID, title, author, category, quantity, Status, Cover_image, description FROM book " &
                                      "WHERE book_ID LIKE @search " &
                                      "OR title LIKE @search " &
                                      "OR author LIKE @search " &
                                      "OR category LIKE @search " &
                                      "OR quantity LIKE @search " &
                                      "OR Status LIKE @search " &
                                      "OR description LIKE @search"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvBook.Rows.Clear()

                        While reader.Read()
                            Dim images As Image = New Bitmap(1, 1)
                            Dim imagePath As String = ""

                            If Not IsDBNull(reader("Cover_image")) Then
                                imagePath = reader("Cover_image").ToString()
                                Dim fullPath As String = IO.Path.Combine(Application.StartupPath, imagePath)

                                If IO.File.Exists(fullPath) Then
                                    Using originalImage As Image = Image.FromFile(fullPath)
                                        Dim ratio As Double = Math.Min(180 / originalImage.Width, 180 / originalImage.Height)
                                        Dim newWidth As Integer = CInt(originalImage.Width * ratio)
                                        Dim newHeight As Integer = CInt(originalImage.Height * ratio)

                                        images = New Bitmap(originalImage, newWidth, newHeight)
                                    End Using
                                End If
                            End If

                            dgvBook.Rows.Add(
                                reader("book_ID").ToString(),
                                reader("title").ToString(),
                                reader("author").ToString(),
                                reader("category").ToString(),
                                reader("quantity").ToString(),
                                reader("Status").ToString(),
                                images,
                                imagePath,
                                reader("description").ToString()
                            )
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching books: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Clear Inputs
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
        LoadBookData()
    End Sub

    Private Sub ClearFields()
        txtBookID.Clear()
        txttitle.Clear()
        txtAuthor.Clear()
        txtImage.Clear()
        txtQuantity.Clear()
        txtboxDesc.Clear()
        txtSearch.Clear()
        cmbCategory.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        pictureBox.Image = Nothing
    End Sub

    ' Click Row to Fill TextBoxes and PictureBox
    Private Sub dgvBook_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBook.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBook.Rows(e.RowIndex)
            txtBookID.Text = Convert.ToString(row.Cells(0).Value)
            txttitle.Text = Convert.ToString(row.Cells(1).Value)
            txtAuthor.Text = Convert.ToString(row.Cells(2).Value)
            cmbCategory.Text = Convert.ToString(row.Cells(3).Value)
            txtQuantity.Text = Convert.ToString(row.Cells(4).Value)
            cmbStatus.Text = Convert.ToString(row.Cells(5).Value)

            ' Fetch path from index 7 (Index 6 holds the actual Image object)
            txtImage.Text = Convert.ToString(row.Cells(7).Value)
            txtboxDesc.Text = Convert.ToString(row.Cells(8).Value)

            ' Render the image in the PictureBox without locking the file
            Dim imgPath As String = txtImage.Text
            Dim fullPath As String = IO.Path.Combine(Application.StartupPath, imgPath)

            If IO.File.Exists(fullPath) Then
                Using fs As New IO.FileStream(fullPath, IO.FileMode.Open, IO.FileAccess.Read)
                    pictureBox.Image = Image.FromStream(fs)
                End Using
            Else
                pictureBox.Image = Nothing
            End If
        End If
    End Sub

    ' Browse Image (Using FileStream to prevent file locking issues)
    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Using openFile As New OpenFileDialog()
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

            If openFile.ShowDialog() = DialogResult.OK Then
                Dim fileName As String = IO.Path.GetFileName(openFile.FileName)
                Dim imageFolder As String = IO.Path.Combine(Application.StartupPath, "image")
                Dim destination As String = IO.Path.Combine(imageFolder, fileName)

                ' Render preview
                Using fs As New IO.FileStream(openFile.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                    pictureBox.Image = Image.FromStream(fs)
                End Using

                If Not IO.Directory.Exists(imageFolder) Then
                    IO.Directory.CreateDirectory(imageFolder)
                End If

                ' Prevent conflict if user selects an image already in the output directory
                If openFile.FileName.ToLower() <> destination.ToLower() Then
                    IO.File.Copy(openFile.FileName, destination, True)
                End If

                txtImage.Text = "image\" & fileName
            End If
        End Using
    End Sub

#End Region

#Region "Sidebar Animation & Navigation Engine"

    Private Sub ManageBookForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        pnlSidebar.Height = Me.ClientSize.Height
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        pnlSidebar.BringToFront()
        btnMenu.BringToFront()
        timerSidebar.Start()
    End Sub

    Private Sub timerSidebar_Tick(sender As Object, e As EventArgs) Handles timerSideBar.Tick
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

    Private Sub NavButton_MouseEnter(sender As Object, e As EventArgs) Handles btnDashboard.MouseEnter, btnReport.MouseEnter, btnStudent.MouseEnter, btnSettings.MouseEnter, btnAbout.MouseEnter, btnLogOut.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = ShallowGoldColor
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 240, 210, 100)
    End Sub

    Private Sub NavButton_MouseLeave(sender As Object, e As EventArgs) Handles btnDashboard.MouseLeave, btnReport.MouseLeave, btnStudent.MouseLeave, btnSettings.MouseLeave, btnAbout.MouseLeave, btnLogOut.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = Color.White
    End Sub

    Private Sub NavButton_ClickHandler(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnReport.Click, btnStudent.Click, btnSettings.Click, btnAbout.Click, btnLogOut.Click
        Dim clickedButton As Button = CType(sender, Button)

        Select Case clickedButton.Name
            Case "btnDashboard"
                Dim dashboardPage As New AdminDashboard()
                Me.Hide()
                dashboardPage.ShowDialog()
                Me.Close()

            Case "btnStudent"
                Dim studentPage As New StudentManagementForm()
                Me.Hide()
                studentPage.ShowDialog()
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

    ' Apply Black and Gold theme to the DataGridView
    Private Sub StyleDataGridView()
        ' Disable automatic row addition to prevent the Red X error at the bottom of the grid
        dgvBook.AllowUserToAddRows = False

        dgvBook.EnableHeadersVisualStyles = False
        dgvBook.BackgroundColor = Color.FromArgb(20, 20, 20)
        dgvBook.BorderStyle = BorderStyle.None
        dgvBook.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvBook.GridColor = Color.FromArgb(180, 130, 40)

        ' Header Styling
        dgvBook.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        dgvBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 212, 175, 55)
        dgvBook.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgvBook.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvBook.ColumnHeadersHeight = 40

        ' Cell Styling
        dgvBook.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)
        dgvBook.DefaultCellStyle.ForeColor = Color.White
        dgvBook.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 212, 175, 55)
        dgvBook.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvBook.DefaultCellStyle.Font = New Font("Segoe UI", 9)

        dgvBook.RowHeadersVisible = False
        dgvBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Row Height
        dgvBook.RowTemplate.Height = 80

        ' Image Column Scaling configuration
        If dgvBook.Columns.Contains("ImageColumn") Then
            Dim imgCol As DataGridViewImageColumn = CType(dgvBook.Columns("ImageColumn"), DataGridViewImageColumn)
            imgCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            imgCol.Width = 150
            imgCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
            imgCol.DefaultCellStyle.NullValue = New Bitmap(1, 1)
        End If
    End Sub

    Private Sub StyleFilter(cmb As ComboBox)
        cmb.BackColor = Color.FromArgb(30, 30, 30)
        cmb.ForeColor = Color.FromArgb(255, 212, 175, 55)
        cmb.FlatStyle = FlatStyle.Flat
    End Sub

    ' Generates standard gold gradient for action buttons
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

    ' Generates high-visibility hover gold gradient
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

    ' Apply Gold Style and Rounded Corners
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

    ' Draws a custom golden border around input panels
    Private Sub Panel_Paint_GoldBorder(sender As Object, e As PaintEventArgs) Handles pnlData.Paint
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