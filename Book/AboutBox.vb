'CHONG JIA HUI- A25DW0032 (Section J1)
Public NotInheritable Class AboutBox

    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.lblSystemName.Text = My.Application.Info.ProductName
        Me.lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.lblCopyright.Text = My.Application.Info.Copyright
        Me.lblCompanyName.Text = My.Application.Info.CompanyName
        Me.txtDescription.Text = My.Application.Info.Description

        lblSystemName.Text = "Nicely Mini Library Management System"
        lblVersion.Text = "Version 1.0"
        lblCompanyName.Text = "Nicely Mini Library"
        lblCopyright.Text = "2026 Nicely Mini Library"
        txtDescription.Text = "Nicely Mini Library system is a library management system for students and administrators." & vbCrLf & vbCrLf &
            "Developed by Section J1:" & vbCrLf & "CELESTINA ONG YING XUAN (A25DW0191)" & vbCrLf & "CHEAH WEI EN (A25DW0096)" & vbCrLf &
            "NG ZHENG KAI (A25DW0699)" & vbCrLf & "CHONG JIA HUI (A25DW0032)"

        StyleButton(OKButton)
    End Sub
    Private Sub StyleButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent

        btn.BackColor = Color.Goldenrod
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
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
