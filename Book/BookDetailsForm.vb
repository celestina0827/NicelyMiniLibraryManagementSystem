'CHONG JIA HUI- A25DW0032 (Section J1)
Imports MySql.Data.MySqlClient

Public Class BookDetailsForm
    Private isSidebarOpen As Boolean = False
    Private bookID As Integer

    Public Sub New(ByVal id As Integer)
        InitializeComponent()
        bookID = id
    End Sub
#Region "Function"
    Private Sub BookDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As MySqlConnection = DBConnection.GetConnection
        Try
            conn.Open()
            Dim sql As String = "SELECT title,author,category,quantity,Status,Cover_image,description FROM Book WHERE book_ID=@bookID"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.Add("@bookID", MySqlDbType.Int32)
            cmd.Parameters("@bookID").Value = bookID

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                LabelTitle.Text = reader("title").ToString
                LabelAuthor.Text = reader("author").ToString
                lblansCategory.Text = reader("category").ToString
                lblansquantity.Text = reader("quantity").ToString
                lblansStatus.Text = reader("Status").ToString
                lblansStatus.Text = reader("Status").ToString

                If reader("Status").ToString() = "Borrowed" Then
                    Btn_Borrow.Enabled = False
                Else
                    Btn_Borrow.Enabled = True
                End If

                lblDescription.Text = reader("description").ToString
                lblDescription.Text = reader("description").ToString
                lblDescription.AutoSize = False
                lblDescription.Width = 750
                lblDescription.Height = 150
                lblDescription.TextAlign = ContentAlignment.TopLeft

                Dim imagePath As String = ""

                If Not IsDBNull(reader("Cover_image")) Then
                    imagePath = reader("Cover_image").ToString()
                End If

                'Convert relative path to full path
                Dim fullPath As String =
                    IO.Path.Combine(Application.StartupPath, imagePath)

                'Load image
                If IO.File.Exists(fullPath) Then
                    picCover.Image = Image.FromFile(fullPath)
                Else
                    picCover.Image = Nothing
                End If

            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
            Panel_Sidebar3.Width = 0
        End Try
        MakePanel(pnlDetails)
        MakePanel(pnlPicture)
        MakeButton(Btn_Borrow)
        MakePanel(pnlDecsription)

        StyleButton(Btn_Nav_About)
        StyleButton(btnBooks)
        StyleButton(Btn_Nav_History)
        StyleButton(Btn_Nav_Exit)
        StyleButton(Btn_Nav_DashBoard)
        StyleButton(Btn_Nav_Return)
        StyleButton(Btn_Nav_Logout)
        SidebarHelper.InitializeSidebar(
       Me,
       Panel_Sidebar3,
       Panel_Header,
       Timer_Sidebar)


    End Sub
#End Region

#Region " Button"
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles Btn_Nav_Exit.Click
        Me.Close()
    End Sub


    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles Btn_Nav_DashBoard.Click
        Dim StuForm As New StudentForm()
        StuForm.ShowDialog()
    End Sub

    Private Sub Viewbtn_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        Dim myform As New BookForm()
        myform.ShowDialog()
    End Sub

    Private Sub Btn_Nav_Logout_Click(sender As Object, e As EventArgs) Handles Btn_Nav_Logout.Click
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
    End Sub

    Private Sub Btn_Borrow_Click(sender As Object, e As EventArgs) Handles Btn_Borrow.Click
        Dim brw As New BorrowForm(bookID)
        brw.ShowDialog()
    End Sub

    Private Sub Btn_Nav_Return_Click(sender As Object, e As EventArgs) Handles Btn_Nav_Return.Click
        Dim retrn As New ReturnForm()
        retrn.ShowDialog()
    End Sub

    Private Sub Btn_Nav_About_Click(sender As Object, e As EventArgs) Handles Btn_Nav_About.Click
        Dim about As New AboutBox()
        about.ShowDialog()
    End Sub


    Private Sub Btn_Nav_History_Click(sender As Object, e As EventArgs) Handles Btn_Nav_History.Click
        Dim bh As New BorrowHistoryForm()
        bh.ShowDialog()
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

            Using brush As New SolidBrush(Color.FromArgb(80, Color.Black))
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
        btn.FlatAppearance.MouseOverBackColor = Color.Gold
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

            If btn.Enabled = False Then

                'Disabled
                Using brush As New SolidBrush(Color.Gray)
                    e.Graphics.FillPath(brush, path)
                End Using

                Using pen As New Pen(Color.DarkGray, 2)
                    e.Graphics.DrawPath(pen, path)
                End Using

                Using brush As New SolidBrush(Color.LightGray)

                    Dim textSize As SizeF =
                        e.Graphics.MeasureString(btn.Text, btn.Font)

                    Dim x As Single =
                        (btn.ClientSize.Width - textSize.Width) / 2

                    Dim y As Single =
                        (btn.ClientSize.Height - textSize.Height) / 2

                    e.Graphics.DrawString(
                        btn.Text,
                        btn.Font,
                        brush,
                        x,
                        y)

                End Using
            Else

                'Normal
                Using brush As New SolidBrush(Color.Black)
                    e.Graphics.FillPath(brush, path)
                End Using

                Using pen As New Pen(Color.Gold, 2)
                    e.Graphics.DrawPath(pen, path)
                End Using

                Using brush As New SolidBrush(btn.ForeColor)

                    Dim textSize As SizeF =
                        e.Graphics.MeasureString(btn.Text, btn.Font)

                    Dim x As Single =
                        (btn.ClientSize.Width - textSize.Width) / 2

                    Dim y As Single =
                        (btn.ClientSize.Height - textSize.Height) / 2

                    e.Graphics.DrawString(
                        btn.Text,
                        btn.Font,
                        brush,
                        x,
                        y)
                End Using
            End If
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


    Private Sub Btn_toggle_Click(sender As Object, e As EventArgs) Handles Btn_Toggle.Click
        SidebarHelper.ToggleSidebar(
       Panel_Sidebar3,
       Timer_Sidebar)

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