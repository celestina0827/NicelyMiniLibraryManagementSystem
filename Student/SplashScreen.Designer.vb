<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTagline = New System.Windows.Forms.Label()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.tmrSplash = New System.Windows.Forms.Timer(Me.components)
        Me.lblLogo = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.pnlProgressTrack = New System.Windows.Forms.Panel()
        Me.pnlProgressFill = New System.Windows.Forms.Panel()
        CType(Me.lblLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitle.Font = New System.Drawing.Font("Georgia", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(119, 216)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(500, 45)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "NICELY MINI LIBRARY"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTagline
        '
        Me.lblTagline.BackColor = System.Drawing.Color.Transparent
        Me.lblTagline.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTagline.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagline.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTagline.Location = New System.Drawing.Point(219, 251)
        Me.lblTagline.Name = "lblTagline"
        Me.lblTagline.Size = New System.Drawing.Size(300, 25)
        Me.lblTagline.TabIndex = 3
        Me.lblTagline.Text = "Read • Learn • Grow"
        Me.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoading
        '
        Me.lblLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoading.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblLoading.Location = New System.Drawing.Point(154, 331)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(200, 20)
        Me.lblLoading.TabIndex = 5
        Me.lblLoading.Text = "loading"
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblVersion.Location = New System.Drawing.Point(556, 401)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(130, 21)
        Me.lblVersion.TabIndex = 6
        Me.lblVersion.Text = "Version 1.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmrSplash
        '
        Me.tmrSplash.Interval = 60
        '
        'lblLogo
        '
        Me.lblLogo.BackColor = System.Drawing.Color.Transparent
        Me.lblLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLogo.Image = CType(resources.GetObject("lblLogo.Image"), System.Drawing.Image)
        Me.lblLogo.Location = New System.Drawing.Point(329, 81)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(90, 90)
        Me.lblLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.lblLogo.TabIndex = 7
        Me.lblLogo.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWelcome.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblWelcome.Location = New System.Drawing.Point(284, 196)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(180, 20)
        Me.lblWelcome.TabIndex = 8
        Me.lblWelcome.Text = "WELCOME TO"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPercent
        '
        Me.lblPercent.BackColor = System.Drawing.Color.Transparent
        Me.lblPercent.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPercent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.ForeColor = System.Drawing.Color.Gold
        Me.lblPercent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPercent.Location = New System.Drawing.Point(534, 331)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(60, 20)
        Me.lblPercent.TabIndex = 9
        Me.lblPercent.Text = "100%"
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlProgressTrack
        '
        Me.pnlProgressTrack.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlProgressTrack.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlProgressTrack.Location = New System.Drawing.Point(154, 316)
        Me.pnlProgressTrack.Name = "pnlProgressTrack"
        Me.pnlProgressTrack.Size = New System.Drawing.Size(440, 4)
        Me.pnlProgressTrack.TabIndex = 10
        '
        'pnlProgressFill
        '
        Me.pnlProgressFill.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlProgressFill.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlProgressFill.Location = New System.Drawing.Point(154, 316)
        Me.pnlProgressFill.Name = "pnlProgressFill"
        Me.pnlProgressFill.Size = New System.Drawing.Size(0, 4)
        Me.pnlProgressFill.TabIndex = 11
        '
        'SplashScreen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 432)
        Me.Controls.Add(Me.pnlProgressFill)
        Me.Controls.Add(Me.pnlProgressTrack)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.lblTagline)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        CType(Me.lblLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTagline As System.Windows.Forms.Label
    Friend WithEvents lblLoading As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents tmrSplash As System.Windows.Forms.Timer
    Friend WithEvents lblLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents pnlProgressTrack As System.Windows.Forms.Panel
    Friend WithEvents pnlProgressFill As System.Windows.Forms.Panel
End Class
