<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.picBookLogo = New System.Windows.Forms.PictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.pnlAccount = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAdminID = New System.Windows.Forms.Label()
        Me.txtAdminName = New System.Windows.Forms.TextBox()
        Me.lblAdminNameTitle = New System.Windows.Forms.Label()
        Me.picAdminIcon = New System.Windows.Forms.PictureBox()
        Me.grpChangePassword = New System.Windows.Forms.GroupBox()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblOldPassword = New System.Windows.Forms.Label()
        Me.picPasswordIcon = New System.Windows.Forms.PictureBox()
        Me.lblAccProfile = New System.Windows.Forms.Label()
        Me.btnSaveProfile = New System.Windows.Forms.Button()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.timerSidebar = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSystem = New System.Windows.Forms.Panel()
        Me.lblLibraryPolicies = New System.Windows.Forms.Label()
        Me.nudBorrowPeriod = New System.Windows.Forms.NumericUpDown()
        Me.nudMaxBooks = New System.Windows.Forms.NumericUpDown()
        Me.lblMaxBooks = New System.Windows.Forms.Label()
        Me.lblBorrowPeriod = New System.Windows.Forms.Label()
        Me.lblDbStatusText = New System.Windows.Forms.Label()
        Me.picDbStatus = New System.Windows.Forms.PictureBox()
        Me.btnTestDataConnection = New System.Windows.Forms.Button()
        Me.lblDbConnectionTitle = New System.Windows.Forms.Label()
        Me.txtDBConnectionPath = New System.Windows.Forms.TextBox()
        Me.lblConnectionPath = New System.Windows.Forms.Label()
        Me.btnBrowsePath = New System.Windows.Forms.Button()
        Me.lblSystemPathsTitle = New System.Windows.Forms.Label()
        Me.txtReportExportPath = New System.Windows.Forms.TextBox()
        Me.lblReportPath = New System.Windows.Forms.Label()
        Me.picDbIcon = New System.Windows.Forms.PictureBox()
        Me.picPolicyIcon = New System.Windows.Forms.PictureBox()
        Me.picSystemPathsIcon = New System.Windows.Forms.PictureBox()
        Me.lblSystemConfiguration = New System.Windows.Forms.Label()
        Me.btnSaveConfig = New System.Windows.Forms.Button()
        Me.fbdReportPath = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.picBookLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAccount.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAdminIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChangePassword.SuspendLayout()
        CType(Me.picPasswordIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlSystem.SuspendLayout()
        CType(Me.nudBorrowPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDbStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPolicyIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSystemPathsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBookLogo
        '
        Me.picBookLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBookLogo.BackColor = System.Drawing.Color.Transparent
        Me.picBookLogo.Image = CType(resources.GetObject("picBookLogo.Image"), System.Drawing.Image)
        Me.picBookLogo.Location = New System.Drawing.Point(1736, 0)
        Me.picBookLogo.Name = "picBookLogo"
        Me.picBookLogo.Size = New System.Drawing.Size(72, 60)
        Me.picBookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBookLogo.TabIndex = 7
        Me.picBookLogo.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Black
        Me.lblFormTitle.Location = New System.Drawing.Point(266, 14)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(841, 38)
        Me.lblFormTitle.TabIndex = 8
        Me.lblFormTitle.Text = "ADMIN SETTINGS - PROFILE & CONFIGURATION        "
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.BackColor = System.Drawing.Color.Transparent
        Me.lblLine.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine.ForeColor = System.Drawing.Color.Gold
        Me.lblLine.Location = New System.Drawing.Point(-510, 50)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(2842, 21)
        Me.lblLine.TabIndex = 9
        Me.lblLine.Text = resources.GetString("lblLine.Text")
        '
        'pnlAccount
        '
        Me.pnlAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlAccount.BackColor = System.Drawing.Color.Black
        Me.pnlAccount.Controls.Add(Me.PictureBox1)
        Me.pnlAccount.Controls.Add(Me.lblAdminID)
        Me.pnlAccount.Controls.Add(Me.txtAdminName)
        Me.pnlAccount.Controls.Add(Me.lblAdminNameTitle)
        Me.pnlAccount.Controls.Add(Me.picAdminIcon)
        Me.pnlAccount.Controls.Add(Me.grpChangePassword)
        Me.pnlAccount.Controls.Add(Me.lblAccProfile)
        Me.pnlAccount.Controls.Add(Me.btnSaveProfile)
        Me.pnlAccount.Location = New System.Drawing.Point(243, 82)
        Me.pnlAccount.Name = "pnlAccount"
        Me.pnlAccount.Size = New System.Drawing.Size(778, 856)
        Me.pnlAccount.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 347)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'lblAdminID
        '
        Me.lblAdminID.AutoSize = True
        Me.lblAdminID.BackColor = System.Drawing.Color.Black
        Me.lblAdminID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminID.ForeColor = System.Drawing.Color.White
        Me.lblAdminID.Location = New System.Drawing.Point(104, 175)
        Me.lblAdminID.Name = "lblAdminID"
        Me.lblAdminID.Size = New System.Drawing.Size(42, 23)
        Me.lblAdminID.TabIndex = 31
        Me.lblAdminID.Text = "ID: "
        '
        'txtAdminName
        '
        Me.txtAdminName.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtAdminName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminName.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtAdminName.Location = New System.Drawing.Point(108, 143)
        Me.txtAdminName.Name = "txtAdminName"
        Me.txtAdminName.Size = New System.Drawing.Size(632, 30)
        Me.txtAdminName.TabIndex = 30
        '
        'lblAdminNameTitle
        '
        Me.lblAdminNameTitle.AutoSize = True
        Me.lblAdminNameTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblAdminNameTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminNameTitle.ForeColor = System.Drawing.Color.White
        Me.lblAdminNameTitle.Location = New System.Drawing.Point(104, 119)
        Me.lblAdminNameTitle.Name = "lblAdminNameTitle"
        Me.lblAdminNameTitle.Size = New System.Drawing.Size(140, 23)
        Me.lblAdminNameTitle.TabIndex = 29
        Me.lblAdminNameTitle.Text = "Admin Name:"
        '
        'picAdminIcon
        '
        Me.picAdminIcon.Image = CType(resources.GetObject("picAdminIcon.Image"), System.Drawing.Image)
        Me.picAdminIcon.Location = New System.Drawing.Point(11, 119)
        Me.picAdminIcon.Name = "picAdminIcon"
        Me.picAdminIcon.Size = New System.Drawing.Size(78, 61)
        Me.picAdminIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAdminIcon.TabIndex = 28
        Me.picAdminIcon.TabStop = False
        '
        'grpChangePassword
        '
        Me.grpChangePassword.Controls.Add(Me.chkShowPassword)
        Me.grpChangePassword.Controls.Add(Me.lblConfirmPassword)
        Me.grpChangePassword.Controls.Add(Me.txtConfirmPassword)
        Me.grpChangePassword.Controls.Add(Me.txtNewPassword)
        Me.grpChangePassword.Controls.Add(Me.txtOldPassword)
        Me.grpChangePassword.Controls.Add(Me.lblNewPassword)
        Me.grpChangePassword.Controls.Add(Me.lblOldPassword)
        Me.grpChangePassword.Controls.Add(Me.picPasswordIcon)
        Me.grpChangePassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpChangePassword.ForeColor = System.Drawing.Color.White
        Me.grpChangePassword.Location = New System.Drawing.Point(95, 347)
        Me.grpChangePassword.Name = "grpChangePassword"
        Me.grpChangePassword.Size = New System.Drawing.Size(653, 191)
        Me.grpChangePassword.TabIndex = 19
        Me.grpChangePassword.TabStop = False
        Me.grpChangePassword.Text = "CHANGE PASSWORD       "
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.Location = New System.Drawing.Point(486, 167)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(137, 20)
        Me.chkShowPassword.TabIndex = 38
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.Black
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.White
        Me.lblConfirmPassword.Location = New System.Drawing.Point(6, 121)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(225, 23)
        Me.lblConfirmPassword.TabIndex = 36
        Me.lblConfirmPassword.Text = "Confirm Password：   "
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtConfirmPassword.Location = New System.Drawing.Point(264, 118)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(359, 31)
        Me.txtConfirmPassword.TabIndex = 35
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtNewPassword.Location = New System.Drawing.Point(264, 74)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(359, 31)
        Me.txtNewPassword.TabIndex = 34
        '
        'txtOldPassword
        '
        Me.txtOldPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtOldPassword.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtOldPassword.Location = New System.Drawing.Point(264, 31)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(359, 31)
        Me.txtOldPassword.TabIndex = 32
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.BackColor = System.Drawing.Color.Black
        Me.lblNewPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.White
        Me.lblNewPassword.Location = New System.Drawing.Point(6, 77)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(201, 23)
        Me.lblNewPassword.TabIndex = 33
        Me.lblNewPassword.Text = "New Password:        "
        '
        'lblOldPassword
        '
        Me.lblOldPassword.AutoSize = True
        Me.lblOldPassword.BackColor = System.Drawing.Color.Black
        Me.lblOldPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldPassword.ForeColor = System.Drawing.Color.White
        Me.lblOldPassword.Location = New System.Drawing.Point(6, 34)
        Me.lblOldPassword.Name = "lblOldPassword"
        Me.lblOldPassword.Size = New System.Drawing.Size(196, 23)
        Me.lblOldPassword.TabIndex = 32
        Me.lblOldPassword.Text = "Old Password：      "
        '
        'picPasswordIcon
        '
        Me.picPasswordIcon.Image = CType(resources.GetObject("picPasswordIcon.Image"), System.Drawing.Image)
        Me.picPasswordIcon.Location = New System.Drawing.Point(255, 0)
        Me.picPasswordIcon.Name = "picPasswordIcon"
        Me.picPasswordIcon.Size = New System.Drawing.Size(36, 25)
        Me.picPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPasswordIcon.TabIndex = 32
        Me.picPasswordIcon.TabStop = False
        '
        'lblAccProfile
        '
        Me.lblAccProfile.AutoSize = True
        Me.lblAccProfile.BackColor = System.Drawing.Color.Transparent
        Me.lblAccProfile.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccProfile.ForeColor = System.Drawing.Color.White
        Me.lblAccProfile.Location = New System.Drawing.Point(7, 6)
        Me.lblAccProfile.Name = "lblAccProfile"
        Me.lblAccProfile.Size = New System.Drawing.Size(253, 23)
        Me.lblAccProfile.TabIndex = 18
        Me.lblAccProfile.Text = "ACCOUNT AND PROFILE"
        '
        'btnSaveProfile
        '
        Me.btnSaveProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveProfile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveProfile.ForeColor = System.Drawing.Color.Black
        Me.btnSaveProfile.Location = New System.Drawing.Point(500, 783)
        Me.btnSaveProfile.Name = "btnSaveProfile"
        Me.btnSaveProfile.Size = New System.Drawing.Size(259, 51)
        Me.btnSaveProfile.TabIndex = 14
        Me.btnSaveProfile.Text = "SAVE PROFILE CHANGES"
        Me.btnSaveProfile.UseVisualStyleBackColor = True
        '
        'pnlSidebar
        '
        Me.pnlSidebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlSidebar.BackColor = System.Drawing.Color.Black
        Me.pnlSidebar.BackgroundImage = CType(resources.GetObject("pnlSidebar.BackgroundImage"), System.Drawing.Image)
        Me.pnlSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSidebar.Controls.Add(Me.btnBooks)
        Me.pnlSidebar.Controls.Add(Me.btnLogOut)
        Me.pnlSidebar.Controls.Add(Me.btnAbout)
        Me.pnlSidebar.Controls.Add(Me.btnReport)
        Me.pnlSidebar.Controls.Add(Me.btnStudent)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(237, 967)
        Me.pnlSidebar.TabIndex = 15
        '
        'btnBooks
        '
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.Color.White
        Me.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.Location = New System.Drawing.Point(0, 174)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnBooks.Size = New System.Drawing.Size(222, 40)
        Me.btnBooks.TabIndex = 30
        Me.btnBooks.Text = "📖 BOOK"
        Me.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBooks.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(0, 312)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(222, 40)
        Me.btnLogOut.TabIndex = 29
        Me.btnLogOut.Text = "↩ LOG OUT"
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(0, 266)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnAbout.Size = New System.Drawing.Size(222, 40)
        Me.btnAbout.TabIndex = 27
        Me.btnAbout.Text = "ℹ️ ABOUT"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(0, 220)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnReport.Size = New System.Drawing.Size(222, 40)
        Me.btnReport.TabIndex = 26
        Me.btnReport.Text = "📋 REPORT"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnStudent
        '
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudent.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.White
        Me.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudent.Location = New System.Drawing.Point(0, 128)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnStudent.Size = New System.Drawing.Size(222, 40)
        Me.btnStudent.TabIndex = 25
        Me.btnStudent.Text = "👨‍🎓 STUDENT"
        Me.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudent.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 82)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(222, 40)
        Me.btnDashboard.TabIndex = 24
        Me.btnDashboard.Text = "🏠 DASHBOARD"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMenu.Location = New System.Drawing.Point(0, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(49, 40)
        Me.btnMenu.TabIndex = 16
        Me.btnMenu.Text = "≡"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'timerSidebar
        '
        Me.timerSidebar.Interval = 10
        '
        'pnlSystem
        '
        Me.pnlSystem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlSystem.BackColor = System.Drawing.Color.Black
        Me.pnlSystem.Controls.Add(Me.lblLibraryPolicies)
        Me.pnlSystem.Controls.Add(Me.nudBorrowPeriod)
        Me.pnlSystem.Controls.Add(Me.nudMaxBooks)
        Me.pnlSystem.Controls.Add(Me.lblMaxBooks)
        Me.pnlSystem.Controls.Add(Me.lblBorrowPeriod)
        Me.pnlSystem.Controls.Add(Me.lblDbStatusText)
        Me.pnlSystem.Controls.Add(Me.picDbStatus)
        Me.pnlSystem.Controls.Add(Me.btnTestDataConnection)
        Me.pnlSystem.Controls.Add(Me.lblDbConnectionTitle)
        Me.pnlSystem.Controls.Add(Me.txtDBConnectionPath)
        Me.pnlSystem.Controls.Add(Me.lblConnectionPath)
        Me.pnlSystem.Controls.Add(Me.btnBrowsePath)
        Me.pnlSystem.Controls.Add(Me.lblSystemPathsTitle)
        Me.pnlSystem.Controls.Add(Me.txtReportExportPath)
        Me.pnlSystem.Controls.Add(Me.lblReportPath)
        Me.pnlSystem.Controls.Add(Me.picDbIcon)
        Me.pnlSystem.Controls.Add(Me.picPolicyIcon)
        Me.pnlSystem.Controls.Add(Me.picSystemPathsIcon)
        Me.pnlSystem.Controls.Add(Me.lblSystemConfiguration)
        Me.pnlSystem.Controls.Add(Me.btnSaveConfig)
        Me.pnlSystem.Location = New System.Drawing.Point(1030, 82)
        Me.pnlSystem.Name = "pnlSystem"
        Me.pnlSystem.Size = New System.Drawing.Size(778, 856)
        Me.pnlSystem.TabIndex = 27
        '
        'lblLibraryPolicies
        '
        Me.lblLibraryPolicies.AutoSize = True
        Me.lblLibraryPolicies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibraryPolicies.ForeColor = System.Drawing.Color.White
        Me.lblLibraryPolicies.Location = New System.Drawing.Point(103, 532)
        Me.lblLibraryPolicies.Name = "lblLibraryPolicies"
        Me.lblLibraryPolicies.Size = New System.Drawing.Size(196, 23)
        Me.lblLibraryPolicies.TabIndex = 55
        Me.lblLibraryPolicies.Text = "LIBRARY POLICIES"
        '
        'nudBorrowPeriod
        '
        Me.nudBorrowPeriod.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.nudBorrowPeriod.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudBorrowPeriod.ForeColor = System.Drawing.Color.Goldenrod
        Me.nudBorrowPeriod.Location = New System.Drawing.Point(530, 557)
        Me.nudBorrowPeriod.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nudBorrowPeriod.Name = "nudBorrowPeriod"
        Me.nudBorrowPeriod.Size = New System.Drawing.Size(227, 31)
        Me.nudBorrowPeriod.TabIndex = 54
        '
        'nudMaxBooks
        '
        Me.nudMaxBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.nudMaxBooks.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMaxBooks.ForeColor = System.Drawing.Color.Goldenrod
        Me.nudMaxBooks.Location = New System.Drawing.Point(530, 593)
        Me.nudMaxBooks.Name = "nudMaxBooks"
        Me.nudMaxBooks.Size = New System.Drawing.Size(227, 31)
        Me.nudMaxBooks.TabIndex = 53
        '
        'lblMaxBooks
        '
        Me.lblMaxBooks.AutoSize = True
        Me.lblMaxBooks.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxBooks.ForeColor = System.Drawing.Color.White
        Me.lblMaxBooks.Location = New System.Drawing.Point(103, 597)
        Me.lblMaxBooks.Name = "lblMaxBooks"
        Me.lblMaxBooks.Size = New System.Drawing.Size(303, 23)
        Me.lblMaxBooks.TabIndex = 52
        Me.lblMaxBooks.Text = "Max Borrowed Books (Admin):"
        '
        'lblBorrowPeriod
        '
        Me.lblBorrowPeriod.AutoSize = True
        Me.lblBorrowPeriod.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowPeriod.ForeColor = System.Drawing.Color.White
        Me.lblBorrowPeriod.Location = New System.Drawing.Point(103, 562)
        Me.lblBorrowPeriod.Name = "lblBorrowPeriod"
        Me.lblBorrowPeriod.Size = New System.Drawing.Size(300, 23)
        Me.lblBorrowPeriod.TabIndex = 48
        Me.lblBorrowPeriod.Text = "Default Borrow Period (Days):"
        '
        'lblDbStatusText
        '
        Me.lblDbStatusText.AutoSize = True
        Me.lblDbStatusText.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDbStatusText.ForeColor = System.Drawing.Color.White
        Me.lblDbStatusText.Location = New System.Drawing.Point(154, 373)
        Me.lblDbStatusText.Name = "lblDbStatusText"
        Me.lblDbStatusText.Size = New System.Drawing.Size(374, 23)
        Me.lblDbStatusText.TabIndex = 47
        Me.lblDbStatusText.Text = "Database Link Status: Connected        "
        '
        'picDbStatus
        '
        Me.picDbStatus.Image = CType(resources.GetObject("picDbStatus.Image"), System.Drawing.Image)
        Me.picDbStatus.Location = New System.Drawing.Point(103, 362)
        Me.picDbStatus.Name = "picDbStatus"
        Me.picDbStatus.Size = New System.Drawing.Size(48, 41)
        Me.picDbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDbStatus.TabIndex = 46
        Me.picDbStatus.TabStop = False
        '
        'btnTestDataConnection
        '
        Me.btnTestDataConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTestDataConnection.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestDataConnection.ForeColor = System.Drawing.Color.Black
        Me.btnTestDataConnection.Location = New System.Drawing.Point(638, 322)
        Me.btnTestDataConnection.Name = "btnTestDataConnection"
        Me.btnTestDataConnection.Size = New System.Drawing.Size(119, 31)
        Me.btnTestDataConnection.TabIndex = 42
        Me.btnTestDataConnection.Text = "TEST"
        Me.btnTestDataConnection.UseVisualStyleBackColor = True
        '
        'lblDbConnectionTitle
        '
        Me.lblDbConnectionTitle.AutoSize = True
        Me.lblDbConnectionTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDbConnectionTitle.ForeColor = System.Drawing.Color.White
        Me.lblDbConnectionTitle.Location = New System.Drawing.Point(103, 275)
        Me.lblDbConnectionTitle.Name = "lblDbConnectionTitle"
        Me.lblDbConnectionTitle.Size = New System.Drawing.Size(264, 23)
        Me.lblDbConnectionTitle.TabIndex = 45
        Me.lblDbConnectionTitle.Text = "DATABASE CONNECTION"
        '
        'txtDBConnectionPath
        '
        Me.txtDBConnectionPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtDBConnectionPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDBConnectionPath.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtDBConnectionPath.Location = New System.Drawing.Point(109, 330)
        Me.txtDBConnectionPath.Name = "txtDBConnectionPath"
        Me.txtDBConnectionPath.ReadOnly = True
        Me.txtDBConnectionPath.Size = New System.Drawing.Size(485, 30)
        Me.txtDBConnectionPath.TabIndex = 43
        '
        'lblConnectionPath
        '
        Me.lblConnectionPath.AutoSize = True
        Me.lblConnectionPath.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnectionPath.ForeColor = System.Drawing.Color.White
        Me.lblConnectionPath.Location = New System.Drawing.Point(105, 306)
        Me.lblConnectionPath.Name = "lblConnectionPath"
        Me.lblConnectionPath.Size = New System.Drawing.Size(176, 23)
        Me.lblConnectionPath.TabIndex = 44
        Me.lblConnectionPath.Text = "Connection Path:"
        '
        'btnBrowsePath
        '
        Me.btnBrowsePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowsePath.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePath.ForeColor = System.Drawing.Color.Black
        Me.btnBrowsePath.Location = New System.Drawing.Point(638, 128)
        Me.btnBrowsePath.Name = "btnBrowsePath"
        Me.btnBrowsePath.Size = New System.Drawing.Size(119, 31)
        Me.btnBrowsePath.TabIndex = 38
        Me.btnBrowsePath.Text = "BROWSE"
        Me.btnBrowsePath.UseVisualStyleBackColor = True
        '
        'lblSystemPathsTitle
        '
        Me.lblSystemPathsTitle.AutoSize = True
        Me.lblSystemPathsTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemPathsTitle.ForeColor = System.Drawing.Color.White
        Me.lblSystemPathsTitle.Location = New System.Drawing.Point(103, 65)
        Me.lblSystemPathsTitle.Name = "lblSystemPathsTitle"
        Me.lblSystemPathsTitle.Size = New System.Drawing.Size(165, 23)
        Me.lblSystemPathsTitle.TabIndex = 41
        Me.lblSystemPathsTitle.Text = "SYSTEM PATHS"
        '
        'txtReportExportPath
        '
        Me.txtReportExportPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtReportExportPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportExportPath.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtReportExportPath.Location = New System.Drawing.Point(103, 134)
        Me.txtReportExportPath.Name = "txtReportExportPath"
        Me.txtReportExportPath.ReadOnly = True
        Me.txtReportExportPath.Size = New System.Drawing.Size(489, 30)
        Me.txtReportExportPath.TabIndex = 38
        '
        'lblReportPath
        '
        Me.lblReportPath.AutoSize = True
        Me.lblReportPath.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportPath.ForeColor = System.Drawing.Color.White
        Me.lblReportPath.Location = New System.Drawing.Point(99, 110)
        Me.lblReportPath.Name = "lblReportPath"
        Me.lblReportPath.Size = New System.Drawing.Size(204, 23)
        Me.lblReportPath.TabIndex = 40
        Me.lblReportPath.Text = "Report Output Path:"
        '
        'picDbIcon
        '
        Me.picDbIcon.Image = CType(resources.GetObject("picDbIcon.Image"), System.Drawing.Image)
        Me.picDbIcon.Location = New System.Drawing.Point(19, 279)
        Me.picDbIcon.Name = "picDbIcon"
        Me.picDbIcon.Size = New System.Drawing.Size(78, 61)
        Me.picDbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDbIcon.TabIndex = 39
        Me.picDbIcon.TabStop = False
        '
        'picPolicyIcon
        '
        Me.picPolicyIcon.Image = CType(resources.GetObject("picPolicyIcon.Image"), System.Drawing.Image)
        Me.picPolicyIcon.Location = New System.Drawing.Point(19, 532)
        Me.picPolicyIcon.Name = "picPolicyIcon"
        Me.picPolicyIcon.Size = New System.Drawing.Size(78, 61)
        Me.picPolicyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPolicyIcon.TabIndex = 38
        Me.picPolicyIcon.TabStop = False
        '
        'picSystemPathsIcon
        '
        Me.picSystemPathsIcon.Image = CType(resources.GetObject("picSystemPathsIcon.Image"), System.Drawing.Image)
        Me.picSystemPathsIcon.Location = New System.Drawing.Point(19, 80)
        Me.picSystemPathsIcon.Name = "picSystemPathsIcon"
        Me.picSystemPathsIcon.Size = New System.Drawing.Size(78, 61)
        Me.picSystemPathsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSystemPathsIcon.TabIndex = 38
        Me.picSystemPathsIcon.TabStop = False
        '
        'lblSystemConfiguration
        '
        Me.lblSystemConfiguration.AutoSize = True
        Me.lblSystemConfiguration.BackColor = System.Drawing.Color.Transparent
        Me.lblSystemConfiguration.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemConfiguration.ForeColor = System.Drawing.Color.White
        Me.lblSystemConfiguration.Location = New System.Drawing.Point(15, 3)
        Me.lblSystemConfiguration.Name = "lblSystemConfiguration"
        Me.lblSystemConfiguration.Size = New System.Drawing.Size(270, 23)
        Me.lblSystemConfiguration.TabIndex = 18
        Me.lblSystemConfiguration.Text = "SYSTEM CONFIGURATION"
        '
        'btnSaveConfig
        '
        Me.btnSaveConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveConfig.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveConfig.ForeColor = System.Drawing.Color.Black
        Me.btnSaveConfig.Location = New System.Drawing.Point(515, 783)
        Me.btnSaveConfig.Name = "btnSaveConfig"
        Me.btnSaveConfig.Size = New System.Drawing.Size(246, 51)
        Me.btnSaveConfig.TabIndex = 14
        Me.btnSaveConfig.Text = "SAVE CONFIGURATION"
        Me.btnSaveConfig.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1824, 965)
        Me.Controls.Add(Me.pnlSystem)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlAccount)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.picBookLogo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Settings Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picBookLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAccount.ResumeLayout(False)
        Me.pnlAccount.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAdminIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChangePassword.ResumeLayout(False)
        Me.grpChangePassword.PerformLayout()
        CType(Me.picPasswordIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSystem.ResumeLayout(False)
        Me.pnlSystem.PerformLayout()
        CType(Me.nudBorrowPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaxBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDbStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPolicyIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSystemPathsIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBookLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents pnlAccount As System.Windows.Forms.Panel
    Friend WithEvents btnSaveProfile As System.Windows.Forms.Button
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents timerSidebar As System.Windows.Forms.Timer
    Friend WithEvents lblAccProfile As System.Windows.Forms.Label
    Friend WithEvents pnlSystem As System.Windows.Forms.Panel
    Friend WithEvents lblSystemConfiguration As System.Windows.Forms.Label
    Friend WithEvents btnSaveConfig As System.Windows.Forms.Button
    Friend WithEvents grpChangePassword As System.Windows.Forms.GroupBox
    Friend WithEvents lblAdminID As System.Windows.Forms.Label
    Friend WithEvents txtAdminName As System.Windows.Forms.TextBox
    Friend WithEvents lblAdminNameTitle As System.Windows.Forms.Label
    Friend WithEvents picAdminIcon As System.Windows.Forms.PictureBox
    Friend WithEvents picPasswordIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
    Friend WithEvents lblOldPassword As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents picPolicyIcon As System.Windows.Forms.PictureBox
    Friend WithEvents picSystemPathsIcon As System.Windows.Forms.PictureBox
    Friend WithEvents picDbIcon As System.Windows.Forms.PictureBox
    Friend WithEvents txtReportExportPath As System.Windows.Forms.TextBox
    Friend WithEvents lblReportPath As System.Windows.Forms.Label
    Friend WithEvents btnTestDataConnection As System.Windows.Forms.Button
    Friend WithEvents lblDbConnectionTitle As System.Windows.Forms.Label
    Friend WithEvents txtDBConnectionPath As System.Windows.Forms.TextBox
    Friend WithEvents lblConnectionPath As System.Windows.Forms.Label
    Friend WithEvents btnBrowsePath As System.Windows.Forms.Button
    Friend WithEvents lblSystemPathsTitle As System.Windows.Forms.Label
    Friend WithEvents lblDbStatusText As System.Windows.Forms.Label
    Friend WithEvents picDbStatus As System.Windows.Forms.PictureBox
    Friend WithEvents lblLibraryPolicies As System.Windows.Forms.Label
    Friend WithEvents nudBorrowPeriod As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMaxBooks As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMaxBooks As System.Windows.Forms.Label
    Friend WithEvents lblBorrowPeriod As System.Windows.Forms.Label
    Friend WithEvents fbdReportPath As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnBooks As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnStudent As System.Windows.Forms.Button
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
End Class
