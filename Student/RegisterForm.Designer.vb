<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.picRegisterIcon = New System.Windows.Forms.PictureBox()
        Me.lblRegisterSubtitle = New System.Windows.Forms.Label()
        Me.lblStudentAccess = New System.Windows.Forms.Label()
        Me.lblAdminNote = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtStuName = New System.Windows.Forms.TextBox()
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.txtStuID = New System.Windows.Forms.TextBox()
        Me.lblStuID = New System.Windows.Forms.Label()
        Me.lblRegisterTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblWelcomeLeft = New System.Windows.Forms.Label()
        Me.lblBrandNicely = New System.Windows.Forms.Label()
        Me.lblBrandLibrary = New System.Windows.Forms.Label()
        Me.lblGoldLine = New System.Windows.Forms.Label()
        Me.lblTaglineLeft = New System.Windows.Forms.Label()
        Me.pnlCard.SuspendLayout()
        CType(Me.picRegisterIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCard
        '
        Me.pnlCard.BackColor = System.Drawing.Color.Transparent
        Me.pnlCard.Controls.Add(Me.picRegisterIcon)
        Me.pnlCard.Controls.Add(Me.lblRegisterSubtitle)
        Me.pnlCard.Controls.Add(Me.lblStudentAccess)
        Me.pnlCard.Controls.Add(Me.lblAdminNote)
        Me.pnlCard.Controls.Add(Me.lblStatus)
        Me.pnlCard.Controls.Add(Me.btnBack)
        Me.pnlCard.Controls.Add(Me.btnRegister)
        Me.pnlCard.Controls.Add(Me.chkShowPassword)
        Me.pnlCard.Controls.Add(Me.txtConfirmPassword)
        Me.pnlCard.Controls.Add(Me.lblConfirmPassword)
        Me.pnlCard.Controls.Add(Me.txtPassword)
        Me.pnlCard.Controls.Add(Me.lblPassword)
        Me.pnlCard.Controls.Add(Me.txtEmail)
        Me.pnlCard.Controls.Add(Me.lblEmail)
        Me.pnlCard.Controls.Add(Me.txtStuName)
        Me.pnlCard.Controls.Add(Me.lblStuName)
        Me.pnlCard.Controls.Add(Me.txtStuID)
        Me.pnlCard.Controls.Add(Me.lblStuID)
        Me.pnlCard.Controls.Add(Me.lblRegisterTitle)
        Me.pnlCard.Location = New System.Drawing.Point(287, 0)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(533, 642)
        Me.pnlCard.TabIndex = 1
        '
        'picRegisterIcon
        '
        Me.picRegisterIcon.Image = CType(resources.GetObject("picRegisterIcon.Image"), System.Drawing.Image)
        Me.picRegisterIcon.Location = New System.Drawing.Point(236, 9)
        Me.picRegisterIcon.Name = "picRegisterIcon"
        Me.picRegisterIcon.Size = New System.Drawing.Size(60, 23)
        Me.picRegisterIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRegisterIcon.TabIndex = 19
        Me.picRegisterIcon.TabStop = False
        '
        'lblRegisterSubtitle
        '
        Me.lblRegisterSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblRegisterSubtitle.Location = New System.Drawing.Point(50, 103)
        Me.lblRegisterSubtitle.Name = "lblRegisterSubtitle"
        Me.lblRegisterSubtitle.Size = New System.Drawing.Size(433, 23)
        Me.lblRegisterSubtitle.TabIndex = 18
        Me.lblRegisterSubtitle.Text = "Join the library and begin your reading journey."
        Me.lblRegisterSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudentAccess
        '
        Me.lblStudentAccess.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentAccess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.lblStudentAccess.Location = New System.Drawing.Point(60, 38)
        Me.lblStudentAccess.Name = "lblStudentAccess"
        Me.lblStudentAccess.Size = New System.Drawing.Size(413, 19)
        Me.lblStudentAccess.TabIndex = 16
        Me.lblStudentAccess.Text = "N E W  S T U D E N T  A C C E S S"
        Me.lblStudentAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdminNote
        '
        Me.lblAdminNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblAdminNote.Location = New System.Drawing.Point(45, 520)
        Me.lblAdminNote.Name = "lblAdminNote"
        Me.lblAdminNote.Size = New System.Drawing.Size(443, 38)
        Me.lblAdminNote.TabIndex = 15
        Me.lblAdminNote.Text = "Your account details will be stored securely in the library system."
        Me.lblAdminNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.Firebrick
        Me.lblStatus.Location = New System.Drawing.Point(45, 492)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(443, 26)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(154, 464)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(225, 26)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back to Student Login"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnRegister.Location = New System.Drawing.Point(45, 398)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(443, 43)
        Me.btnRegister.TabIndex = 11
        Me.btnRegister.Text = "CREATE ACCOUNT"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(45, 361)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(133, 19)
        Me.chkShowPassword.TabIndex = 10
        Me.chkShowPassword.Text = "Show password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(278, 317)
        Me.txtConfirmPassword.MaxLength = 50
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(210, 30)
        Me.txtConfirmPassword.TabIndex = 9
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblConfirmPassword.Location = New System.Drawing.Point(278, 295)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(210, 19)
        Me.lblConfirmPassword.TabIndex = 8
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(45, 317)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(210, 30)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.Location = New System.Drawing.Point(45, 295)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(210, 19)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(45, 247)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(443, 30)
        Me.txtEmail.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.Location = New System.Drawing.Point(45, 225)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(443, 19)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email Address"
        '
        'txtStuName
        '
        Me.txtStuName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtStuName.Location = New System.Drawing.Point(278, 176)
        Me.txtStuName.MaxLength = 50
        Me.txtStuName.Name = "txtStuName"
        Me.txtStuName.Size = New System.Drawing.Size(210, 30)
        Me.txtStuName.TabIndex = 3
        '
        'lblStuName
        '
        Me.lblStuName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStuName.Location = New System.Drawing.Point(278, 155)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(210, 19)
        Me.lblStuName.TabIndex = 2
        Me.lblStuName.Text = "Student Name"
        '
        'txtStuID
        '
        Me.txtStuID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtStuID.Location = New System.Drawing.Point(45, 176)
        Me.txtStuID.MaxLength = 11
        Me.txtStuID.Name = "txtStuID"
        Me.txtStuID.Size = New System.Drawing.Size(210, 30)
        Me.txtStuID.TabIndex = 1
        '
        'lblStuID
        '
        Me.lblStuID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStuID.Location = New System.Drawing.Point(45, 155)
        Me.lblStuID.Name = "lblStuID"
        Me.lblStuID.Size = New System.Drawing.Size(210, 19)
        Me.lblStuID.TabIndex = 0
        Me.lblStuID.Text = "Student ID"
        '
        'lblRegisterTitle
        '
        Me.lblRegisterTitle.Font = New System.Drawing.Font("Georgia", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblRegisterTitle.Location = New System.Drawing.Point(50, 61)
        Me.lblRegisterTitle.Name = "lblRegisterTitle"
        Me.lblRegisterTitle.Size = New System.Drawing.Size(433, 42)
        Me.lblRegisterTitle.TabIndex = 17
        Me.lblRegisterTitle.Text = "Create Your Account"
        Me.lblRegisterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(104, 84)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(80, 75)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'lblWelcomeLeft
        '
        Me.lblWelcomeLeft.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcomeLeft.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeLeft.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblWelcomeLeft.Location = New System.Drawing.Point(35, 188)
        Me.lblWelcomeLeft.Name = "lblWelcomeLeft"
        Me.lblWelcomeLeft.Size = New System.Drawing.Size(217, 21)
        Me.lblWelcomeLeft.TabIndex = 3
        Me.lblWelcomeLeft.Text = "W E L C O M E  T O"
        Me.lblWelcomeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBrandNicely
        '
        Me.lblBrandNicely.BackColor = System.Drawing.Color.Transparent
        Me.lblBrandNicely.Font = New System.Drawing.Font("Georgia", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandNicely.ForeColor = System.Drawing.Color.White
        Me.lblBrandNicely.Location = New System.Drawing.Point(20, 220)
        Me.lblBrandNicely.Name = "lblBrandNicely"
        Me.lblBrandNicely.Size = New System.Drawing.Size(247, 33)
        Me.lblBrandNicely.TabIndex = 4
        Me.lblBrandNicely.Text = "NICELY"
        Me.lblBrandNicely.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBrandLibrary
        '
        Me.lblBrandLibrary.BackColor = System.Drawing.Color.Transparent
        Me.lblBrandLibrary.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandLibrary.ForeColor = System.Drawing.Color.White
        Me.lblBrandLibrary.Location = New System.Drawing.Point(15, 253)
        Me.lblBrandLibrary.Name = "lblBrandLibrary"
        Me.lblBrandLibrary.Size = New System.Drawing.Size(257, 36)
        Me.lblBrandLibrary.TabIndex = 5
        Me.lblBrandLibrary.Text = "MINI LIBRARY"
        Me.lblBrandLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGoldLine
        '
        Me.lblGoldLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblGoldLine.Location = New System.Drawing.Point(118, 305)
        Me.lblGoldLine.Name = "lblGoldLine"
        Me.lblGoldLine.Size = New System.Drawing.Size(50, 3)
        Me.lblGoldLine.TabIndex = 6
        Me.lblGoldLine.Text = " "
        '
        'lblTaglineLeft
        '
        Me.lblTaglineLeft.BackColor = System.Drawing.Color.Transparent
        Me.lblTaglineLeft.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaglineLeft.ForeColor = System.Drawing.Color.Silver
        Me.lblTaglineLeft.Location = New System.Drawing.Point(43, 323)
        Me.lblTaglineLeft.Name = "lblTaglineLeft"
        Me.lblTaglineLeft.Size = New System.Drawing.Size(200, 23)
        Me.lblTaglineLeft.TabIndex = 7
        Me.lblTaglineLeft.Text = "Read ?Learn ?Grow"
        Me.lblTaglineLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegisterForm
        '
        Me.AcceptButton = Me.btnRegister
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(822, 645)
        Me.Controls.Add(Me.lblTaglineLeft)
        Me.Controls.Add(Me.lblGoldLine)
        Me.Controls.Add(Me.lblBrandLibrary)
        Me.Controls.Add(Me.lblBrandNicely)
        Me.Controls.Add(Me.lblWelcomeLeft)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.pnlCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nicely Mini Library - Student Registration"
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        CType(Me.picRegisterIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents lblStuID As System.Windows.Forms.Label
    Friend WithEvents txtStuID As System.Windows.Forms.TextBox
    Friend WithEvents lblStuName As System.Windows.Forms.Label
    Friend WithEvents txtStuName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents chkShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblAdminNote As System.Windows.Forms.Label
    Friend WithEvents lblRegisterSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblStudentAccess As System.Windows.Forms.Label
    Friend WithEvents lblRegisterTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcomeLeft As System.Windows.Forms.Label
    Friend WithEvents lblBrandNicely As System.Windows.Forms.Label
    Friend WithEvents lblBrandLibrary As System.Windows.Forms.Label
    Friend WithEvents lblGoldLine As System.Windows.Forms.Label
    Friend WithEvents lblTaglineLeft As System.Windows.Forms.Label
    Friend WithEvents picRegisterIcon As System.Windows.Forms.PictureBox
End Class
