'CHONG JIA HUI- A25DW0032 (Section J1)
Imports MySql.Data.MySqlClient

Public Class BookForm
    Private isSidebarOpen As Boolean = False
    
#Region "Function"
    Private Sub BookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlLBG.HorizontalScroll.Visible = False
        pnlLBG.VerticalScroll.Visible = False

        cmbCategory.Items.Clear()
        cmbCategory.Items.Add("All Subject")
        cmbCategory.Items.Add("Computer Science")
        cmbCategory.Items.Add("Comic")
        cmbCategory.Items.Add("Psychology")
        cmbCategory.Items.Add("History")
        cmbCategory.Items.Add("Novel")
        cmbCategory.Items.Add("Available")
        cmbCategory.Items.Add("Unavailable")
        cmbCategory.SelectedIndex = 0

        MakePanel(pnlLBG)

        MakeButton(btnSearch)

        StyleButton(Btn_Nav_About)
        StyleButton(Btn_Nav_History)
        StyleButton(Btn_Nav_Dashboard)
        StyleButton(Btn_Nav_Borrows)
        StyleButton(Btn_Nav_Logout)
        StyleButton(Btn_Nav_Return)
        MakeCircleBtn(btnLeft)
        MakeCircleBtn(btnRight)

        MakeTextBox(txtsearch)
        MakePanel(pnlSearch)
        MakeFilter(cmbCategory)

        SidebarHelper.InitializeSidebar(
        Me,
        Panel_Sidebar3,
        Panel_Header,
        Timer_Sidebar)

    End Sub

    Private Sub LoadBook(ByVal keyword As String, ByVal ctg As String)
        Dim conn As MySqlConnection = DBConnection.GetConnection
        Try
            conn.Open()
            'search 
            Dim sql1 As String

            If ctg = "All Subject" Then

                sql1 = "SELECT book_ID,title,author,category,quantity,Status,Cover_image,description " &
                       "FROM book " &
                       "WHERE title LIKE @keyword OR author LIKE @keyword OR category LIKE @keyword OR Status LIKE @keyword"

            ElseIf ctg = "Available" Or ctg = "Unavailable" Then

                sql1 = "SELECT book_ID,title,author,category,quantity,Status,Cover_image,description " &
                       "FROM book " &
                       "WHERE (title LIKE @keyword OR author LIKE @keyword OR Status LIKE @keyword) " &
                       "AND Status=@ctg"

            Else

                sql1 = "SELECT book_ID,title,author,category,quantity,Status,Cover_image,description " &
                       "FROM book " &
                       "WHERE (title LIKE @keyword OR author LIKE @keyword OR Status LIKE @keyword) " &
                       "AND category=@ctg"

            End If
            Dim cmd As New MySqlCommand(sql1, conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
            If ctg <> "All Subject" Then
                cmd.Parameters.AddWithValue("@ctg", ctg)

            End If
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim found As Boolean = False
            While reader.Read()
                found = True
                Dim bookID As Integer = Convert.ToInt32(reader("book_ID"))
                Dim title As String = reader("title").ToString
                Dim author As String = reader("author").ToString
                Dim category As String = reader("category").ToString
                Dim quantity As String = reader("quantity").ToString
                Dim status As String = reader("Status").ToString

                Dim bookPanel As New Panel()
                bookPanel.Width = 200
                bookPanel.Height = 250
                bookPanel.BorderStyle = BorderStyle.None
                bookPanel.Margin = New Padding(0)

                Dim picbook As New PictureBox()
                picbook.Width = 105
                picbook.Height = 140
                picbook.Location = New Point(30, 10)
                picbook.SizeMode = PictureBoxSizeMode.Zoom

                Dim imagePath As String = ""

                If Not IsDBNull(reader("Cover_image")) Then
                    imagePath = reader("Cover_image").ToString()
                End If

                'Convert relative path to full path
                Dim fullPath As String =
                    IO.Path.Combine(Application.StartupPath, imagePath)

                'Load image
                If IO.File.Exists(fullPath) Then
                    picbook.Image = Image.FromFile(fullPath)
                Else
                    picbook.Image = Nothing
                End If

                Dim lbltitle As New Label()
                lbltitle.Text = title
                lbltitle.Location = New Point(40, 152)
                lbltitle.Width = 100
                lbltitle.Height = 60
                lbltitle.AutoEllipsis = True



                Dim btnView As New Button()
                btnView.Text = "View"
                btnView.Width = 60
                btnView.Height = 25
                btnView.Location = New Point(32, 220)
                btnView.Tag = bookID
                MakeButton(btnView)

                AddHandler btnView.Click, AddressOf ViewButton_Click
                bookPanel.Controls.Add(picbook)
                bookPanel.Controls.Add(lbltitle)
                bookPanel.Controls.Add(btnView)
                pnlLBG.Controls.Add(bookPanel)
            End While
            reader.Close()
            If found = False Then
                MessageBox.Show("No books found")
                txtsearch.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        If cmbCategory.SelectedIndex = -1 Then
            Exit Sub
        End If
        pnlLBG.Controls.Clear()
        LoadBook(txtsearch.Text.Trim(), cmbCategory.Text)
    End Sub
#End Region

#Region " Button Function"
    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        Dim moveAmount As Integer = 450
        Dim newValue As Integer = pnlLBG.HorizontalScroll.Value - moveAmount

        If newValue < pnlLBG.HorizontalScroll.Minimum Then
            newValue = pnlLBG.HorizontalScroll.Minimum
        End If
        pnlLBG.HorizontalScroll.Value = newValue

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        Dim moveAmount As Integer = 300
        Dim newValue As Integer = pnlLBG.HorizontalScroll.Value + moveAmount
        If newValue > pnlLBG.HorizontalScroll.Minimum Then
            newValue = pnlLBG.HorizontalScroll.Maximum
        End If
        pnlLBG.HorizontalScroll.Value = newValue
    End Sub

    'View
    Private Sub ViewButton_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim bookID As Integer = Convert.ToInt32(btn.Tag)
        Dim details As New BookDetailsForm(bookID)
        details.ShowDialog()
    End Sub

    'Search
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        pnlLBG.Controls.Clear()
        LoadBook(txtsearch.Text.Trim(), cmbCategory.Text)
    End Sub

    'Logout
    Private Sub Btn_Nav_Logout_Click(sender As Object, e As EventArgs) Handles Btn_Nav_Logout.Click
        Dim answer As DialogResult

        answer = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If answer = DialogResult.Yes Then
            ClearSession()
            Application.Exit()
        End If
    End Sub

    'dashboard
    Private Sub Btn_Nav_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Nav_Dashboard.Click
        Dim StuForm As New StudentForm()
        StuForm.ShowDialog()
    End Sub

    'about box
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles Btn_Nav_About.Click
        Dim AboutForm As New AboutBox()
        AboutForm.ShowDialog()
    End Sub

    Private Sub Btn_Nav_History_Click(sender As Object, e As EventArgs) Handles Btn_Nav_History.Click
        Dim bH As New BorrowHistoryForm()
        bH.ShowDialog()
    End Sub

    Private Sub Btn_Nav_Borrows_Click(sender As Object, e As EventArgs) Handles Btn_Nav_Borrows.Click
        Dim Borrow As New BorrowForm()
        Borrow.ShowDialog()
    End Sub


    Private Sub Btn_Nav_Return_Click(sender As Object, e As EventArgs) Handles Btn_Nav_Return.Click
        Dim Returns As New ReturnForm()
        Returns.ShowDialog()
    End Sub

#End Region

#Region "Design"
    Private Sub MakePanel(panel As Panel)
        panel.BackColor = Color.Transparent
        AddHandler panel.Paint, AddressOf DrawRoundedPanel

    End Sub

    Private Sub DrawRoundedPanel(sender As Object, e As PaintEventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim radius As Integer = 15
        Dim borderwidth As Integer = 2
        Dim padding As Integer = 3

        Dim rect As New Rectangle(padding, padding, panel.ClientSize.Width - padding * 2 - 1, panel.ClientSize.Height - padding * 2 - 1)
        Using path As New Drawing2D.GraphicsPath()
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
            path.CloseFigure()

            Using brush As New SolidBrush(Color.FromArgb(110, Color.Black))
                e.Graphics.FillPath(brush, path)
            End Using
            Using pen As New Pen(Color.Gold, 2)
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using

    End Sub

    Private Sub MakeButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.BorderColor = Color.Gold
        btn.BackColor = Color.Transparent
        btn.ForeColor = Color.Gold
        AddHandler btn.MouseEnter, Sub(sender, e)
                                       btn.ForeColor = Color.White
                                   End Sub

        AddHandler btn.MouseLeave, Sub(sender, e)
                                       btn.ForeColor = Color.Gold
                                   End Sub
        AddHandler btn.Paint, AddressOf DrawButtonBorder

    End Sub

    Private Sub DrawButtonBorder(sender As Object, e As PaintEventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim radius As Integer = 10
        Dim rect As New Rectangle(1, 1, btn.ClientSize.Width - 3, btn.ClientSize.Height - 3)
        Using path As New Drawing2D.GraphicsPath()
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
            path.CloseFigure()

            Using brush As New SolidBrush(Color.Black)
                e.Graphics.FillPath(brush, path)
            End Using
            Using pen As New Pen(Color.Gold, 2)
                e.Graphics.DrawPath(pen, path)
            End Using
            Using brush As New SolidBrush(btn.ForeColor)
                Dim textSize As SizeF = e.Graphics.MeasureString(btn.Text, btn.Font)

                Dim x As Single = (btn.ClientSize.Width - textSize.Width) / 2
                Dim y As Single = (btn.ClientSize.Height - textSize.Height) / 2

                e.Graphics.DrawString(btn.Text, btn.Font, brush, x, y)
            End Using
        End Using
    End Sub

    Private Sub StyleButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent

        btn.BackColor = Color.Transparent
        btn.ForeColor = Color.White

        AddHandler btn.MouseEnter, Sub(sender, e)
                                       btn.ForeColor = Color.Gold
                                   End Sub

        AddHandler btn.MouseLeave, Sub(sender, e)
                                       btn.ForeColor = Color.White
                                   End Sub

        AddHandler btn.Paint, AddressOf MakeRoundedBtn
    End Sub
    ' Change shape of button
    Private Sub MakeRoundedBtn(sender As Object, e As PaintEventArgs)
        Dim btn As Button = DirectCast(sender, Button)

        Dim path As New Drawing2D.GraphicsPath()

        path.AddArc(0, 0, 30, 30, 180, 90)
        path.AddArc(btn.Width - 30, 0, 30, 30, 270, 90)
        path.AddArc(btn.Width - 30, btn.Height - 30, 30, 30, 0, 90)
        path.AddArc(0, btn.Height - 30, 30, 30, 90, 90)

        path.CloseAllFigures()

        btn.Region = New Region(path)
    End Sub

    'change left and right button design
    Private Sub MakeCircleBtn(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.Transparent
        btn.ForeColor = Color.Gold
        AddHandler btn.MouseEnter, Sub(sender, e)
                                       btn.ForeColor = Color.White
                                   End Sub

        AddHandler btn.MouseLeave, Sub(sender, e)
                                       btn.ForeColor = Color.Gold
                                   End Sub
        AddHandler btn.Paint, AddressOf DrawCicleBtn
    End Sub

    Private Sub DrawCicleBtn(sender As Object, e As PaintEventArgs)
        Dim btn As Button = DirectCast(sender, Button)

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim rect As New Rectangle(1, 1, btn.ClientSize.Width - 3, btn.ClientSize.Height - 3)

        Using path As New Drawing2D.GraphicsPath()

            path.AddEllipse(rect)
            Using Brush As New SolidBrush(Color.Black)

                e.Graphics.FillPath(Brush, path)
            End Using
            Using pen As New Pen(Color.Gold, 2)
                e.Graphics.DrawPath(pen, path)

            End Using
            Using brush As New SolidBrush(btn.ForeColor)
                Dim textSize As SizeF = e.Graphics.MeasureString(btn.Text, btn.Font)

                Dim x As Single = (btn.ClientSize.Width - textSize.Width) / 2
                Dim y As Single = (btn.ClientSize.Height - textSize.Height) / 2

                e.Graphics.DrawString(btn.Text, btn.Font, brush, x, y)
            End Using
        End Using
    End Sub

    Private Sub MakeTextBox(txt As TextBox)

        txt.BackColor = Color.FromArgb(55, 55, 55)
        txt.ForeColor = Color.Gold
        txt.BorderStyle = BorderStyle.FixedSingle

        Dim radius As Integer = 12

        Using path As New Drawing2D.GraphicsPath()

            path.AddArc(0, 0, radius, radius, 180, 90)
            path.AddArc(txt.Width - radius, 0, radius, radius, 270, 90)
            path.AddArc(txt.Width - radius,
                        txt.Height - radius,
                        radius, radius, 0, 90)
            path.AddArc(0,
                        txt.Height - radius,
                        radius, radius, 90, 90)

            path.CloseFigure()

            txt.Region = New Region(path)

        End Using

    End Sub


    'design combo box
    Private Sub MakeFilter(cmb As ComboBox)
        cmb.BackColor = Color.FromArgb(35, 35, 35)
        cmb.ForeColor = Color.DarkGoldenrod
        cmb.FlatStyle = FlatStyle.Flat

    End Sub

    Private Sub Btn_toggle_Click(sender As Object, e As EventArgs) Handles Btn_toggle.Click
        SidebarHelper.ToggleSidebar(
       Panel_Sidebar3,
       Timer_Sidebar)
        Btn_toggle.BringToFront()
        Timer_Sidebar.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer_Sidebar.Tick
        SidebarHelper.HandleSidebarTick(
        Panel_Sidebar3,
        Panel_Header,
        Timer_Sidebar,
        isSidebarOpen)

    End Sub
#End Region


    
End Class