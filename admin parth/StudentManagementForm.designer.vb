<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentManagementForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentManagementForm))
        Me.picBookLogo = New System.Windows.Forms.PictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblStudentSummary = New System.Windows.Forms.Label()
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.pnlStudentList = New System.Windows.Forms.Panel()
        Me.lblSearchStudent = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlOutOfStock = New System.Windows.Forms.Panel()
        Me.lblNewStudentsCount = New System.Windows.Forms.Label()
        Me.picStudiesIcon = New System.Windows.Forms.PictureBox()
        Me.lblNewStudents = New System.Windows.Forms.Label()
        Me.pnlCategories = New System.Windows.Forms.Panel()
        Me.lblOverdueCount = New System.Windows.Forms.Label()
        Me.picOverdueIcon = New System.Windows.Forms.PictureBox()
        Me.lblOverdue = New System.Windows.Forms.Label()
        Me.pnlCopies = New System.Windows.Forms.Panel()
        Me.picContactIcon = New System.Windows.Forms.PictureBox()
        Me.lblTotalStudentsCount = New System.Windows.Forms.Label()
        Me.lblTotalStudents = New System.Windows.Forms.Label()
        Me.pnlTitles = New System.Windows.Forms.Panel()
        Me.lblActiveRegCount = New System.Windows.Forms.Label()
        Me.picRegisterIcon = New System.Windows.Forms.PictureBox()
        Me.lblActiveReg = New System.Windows.Forms.Label()
        Me.timerSidebar = New System.Windows.Forms.Timer(Me.components)
        Me.pnlStudentDetails = New System.Windows.Forms.Panel()
        Me.txtStuID = New System.Windows.Forms.TextBox()
        Me.picAdminIcon = New System.Windows.Forms.PictureBox()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.lblStuPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblStuEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.lblStuID = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnDeleteStudent = New System.Windows.Forms.Button()
        Me.lblStudentsDetailsAndManagement = New System.Windows.Forms.Label()
        Me.btnUpdateStudent = New System.Windows.Forms.Button()
        CType(Me.picBookLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStudentList.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlOutOfStock.SuspendLayout()
        CType(Me.picStudiesIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCategories.SuspendLayout()
        CType(Me.picOverdueIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCopies.SuspendLayout()
        CType(Me.picContactIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitles.SuspendLayout()
        CType(Me.picRegisterIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStudentDetails.SuspendLayout()
        CType(Me.picAdminIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBookLogo
        '
        Me.picBookLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBookLogo.BackColor = System.Drawing.Color.Transparent
        Me.picBookLogo.Image = CType(resources.GetObject("picBookLogo.Image"), System.Drawing.Image)
        Me.picBookLogo.Location = New System.Drawing.Point(1836, 0)
        Me.picBookLogo.Name = "picBookLogo"
        Me.picBookLogo.Size = New System.Drawing.Size(72, 60)
        Me.picBookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBookLogo.TabIndex = 7
        Me.picBookLogo.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Black
        Me.lblFormTitle.Location = New System.Drawing.Point(236, 14)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(808, 36)
        Me.lblFormTitle.TabIndex = 8
        Me.lblFormTitle.Text = "STUDENT MANAGEMENT"
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
        'lblStudentSummary
        '
        Me.lblStudentSummary.AutoSize = True
        Me.lblStudentSummary.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentSummary.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentSummary.ForeColor = System.Drawing.Color.White
        Me.lblStudentSummary.Location = New System.Drawing.Point(238, 69)
        Me.lblStudentSummary.Name = "lblStudentSummary"
        Me.lblStudentSummary.Size = New System.Drawing.Size(324, 26)
        Me.lblStudentSummary.TabIndex = 10
        Me.lblStudentSummary.Text = "STUDENT SUMMARY              "
        '
        'dgvStudent
        '
        Me.dgvStudent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Location = New System.Drawing.Point(236, 378)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.ReadOnly = True
        Me.dgvStudent.RowTemplate.Height = 24
        Me.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudent.Size = New System.Drawing.Size(838, 726)
        Me.dgvStudent.TabIndex = 14
        '
        'pnlStudentList
        '
        Me.pnlStudentList.BackColor = System.Drawing.Color.Black
        Me.pnlStudentList.Controls.Add(Me.lblSearchStudent)
        Me.pnlStudentList.Controls.Add(Me.txtSearch)
        Me.pnlStudentList.Controls.Add(Me.btnClear)
        Me.pnlStudentList.Controls.Add(Me.lblFilter)
        Me.pnlStudentList.Controls.Add(Me.btnSearch)
        Me.pnlStudentList.Location = New System.Drawing.Point(239, 182)
        Me.pnlStudentList.Name = "pnlStudentList"
        Me.pnlStudentList.Size = New System.Drawing.Size(838, 190)
        Me.pnlStudentList.TabIndex = 13
        '
        'lblSearchStudent
        '
        Me.lblSearchStudent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSearchStudent.AutoSize = True
        Me.lblSearchStudent.BackColor = System.Drawing.Color.Transparent
        Me.lblSearchStudent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchStudent.ForeColor = System.Drawing.Color.White
        Me.lblSearchStudent.Location = New System.Drawing.Point(90, 68)
        Me.lblSearchStudent.Name = "lblSearchStudent"
        Me.lblSearchStudent.Size = New System.Drawing.Size(326, 26)
        Me.lblSearchStudent.TabIndex = 19
        Me.lblSearchStudent.Text = "Search by ID, Name or Email:"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtSearch.Location = New System.Drawing.Point(476, 64)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(261, 30)
        Me.txtSearch.TabIndex = 16
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(666, 142)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(139, 39)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.BackColor = System.Drawing.Color.Transparent
        Me.lblFilter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilter.ForeColor = System.Drawing.Color.White
        Me.lblFilter.Location = New System.Drawing.Point(15, 3)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(175, 26)
        Me.lblFilter.TabIndex = 18
        Me.lblFilter.Text = "STUDENT LIST"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(522, 142)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(134, 39)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
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
        Me.pnlSidebar.Controls.Add(Me.btnSettings)
        Me.pnlSidebar.Controls.Add(Me.btnAbout)
        Me.pnlSidebar.Controls.Add(Me.btnReport)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(230, 1103)
        Me.pnlSidebar.TabIndex = 15
        '
        'btnBooks
        '
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.Color.White
        Me.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.Location = New System.Drawing.Point(0, 140)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnBooks.Size = New System.Drawing.Size(222, 40)
        Me.btnBooks.TabIndex = 37
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
        Me.btnLogOut.Location = New System.Drawing.Point(0, 324)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(222, 40)
        Me.btnLogOut.TabIndex = 36
        Me.btnLogOut.Text = "↩ LOG OUT"
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(0, 231)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnSettings.Size = New System.Drawing.Size(222, 40)
        Me.btnSettings.TabIndex = 35
        Me.btnSettings.Text = "👨‍ SETTINGS"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(0, 277)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnAbout.Size = New System.Drawing.Size(222, 40)
        Me.btnAbout.TabIndex = 34
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
        Me.btnReport.Location = New System.Drawing.Point(0, 185)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnReport.Size = New System.Drawing.Size(222, 40)
        Me.btnReport.TabIndex = 33
        Me.btnReport.Text = "📋 REPORT"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 94)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(222, 40)
        Me.btnDashboard.TabIndex = 31
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlOutOfStock, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlCategories, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlCopies, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlTitles, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(236, 94)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1688, 85)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'pnlOutOfStock
        '
        Me.pnlOutOfStock.BackColor = System.Drawing.Color.Black
        Me.pnlOutOfStock.Controls.Add(Me.lblNewStudentsCount)
        Me.pnlOutOfStock.Controls.Add(Me.picStudiesIcon)
        Me.pnlOutOfStock.Controls.Add(Me.lblNewStudents)
        Me.pnlOutOfStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOutOfStock.Location = New System.Drawing.Point(847, 3)
        Me.pnlOutOfStock.Name = "pnlOutOfStock"
        Me.pnlOutOfStock.Size = New System.Drawing.Size(416, 79)
        Me.pnlOutOfStock.TabIndex = 17
        '
        'lblNewStudentsCount
        '
        Me.lblNewStudentsCount.AutoSize = True
        Me.lblNewStudentsCount.BackColor = System.Drawing.Color.Transparent
        Me.lblNewStudentsCount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewStudentsCount.ForeColor = System.Drawing.Color.White
        Me.lblNewStudentsCount.Location = New System.Drawing.Point(82, 47)
        Me.lblNewStudentsCount.Name = "lblNewStudentsCount"
        Me.lblNewStudentsCount.Size = New System.Drawing.Size(22, 23)
        Me.lblNewStudentsCount.TabIndex = 19
        Me.lblNewStudentsCount.Text = "0"
        '
        'picStudiesIcon
        '
        Me.picStudiesIcon.BackColor = System.Drawing.Color.Transparent
        Me.picStudiesIcon.Image = CType(resources.GetObject("picStudiesIcon.Image"), System.Drawing.Image)
        Me.picStudiesIcon.Location = New System.Drawing.Point(4, 11)
        Me.picStudiesIcon.Name = "picStudiesIcon"
        Me.picStudiesIcon.Size = New System.Drawing.Size(72, 60)
        Me.picStudiesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStudiesIcon.TabIndex = 16
        Me.picStudiesIcon.TabStop = False
        '
        'lblNewStudents
        '
        Me.lblNewStudents.AutoSize = True
        Me.lblNewStudents.BackColor = System.Drawing.Color.Transparent
        Me.lblNewStudents.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewStudents.ForeColor = System.Drawing.Color.White
        Me.lblNewStudents.Location = New System.Drawing.Point(81, 11)
        Me.lblNewStudents.Name = "lblNewStudents"
        Me.lblNewStudents.Size = New System.Drawing.Size(299, 26)
        Me.lblNewStudents.TabIndex = 18
        Me.lblNewStudents.Text = "NEW STUDENTS (MONTH)"
        '
        'pnlCategories
        '
        Me.pnlCategories.BackColor = System.Drawing.Color.Black
        Me.pnlCategories.Controls.Add(Me.lblOverdueCount)
        Me.pnlCategories.Controls.Add(Me.picOverdueIcon)
        Me.pnlCategories.Controls.Add(Me.lblOverdue)
        Me.pnlCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCategories.Location = New System.Drawing.Point(1269, 3)
        Me.pnlCategories.Name = "pnlCategories"
        Me.pnlCategories.Size = New System.Drawing.Size(416, 79)
        Me.pnlCategories.TabIndex = 16
        '
        'lblOverdueCount
        '
        Me.lblOverdueCount.AutoSize = True
        Me.lblOverdueCount.BackColor = System.Drawing.Color.Transparent
        Me.lblOverdueCount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverdueCount.ForeColor = System.Drawing.Color.White
        Me.lblOverdueCount.Location = New System.Drawing.Point(95, 47)
        Me.lblOverdueCount.Name = "lblOverdueCount"
        Me.lblOverdueCount.Size = New System.Drawing.Size(22, 23)
        Me.lblOverdueCount.TabIndex = 20
        Me.lblOverdueCount.Text = "0"
        '
        'picOverdueIcon
        '
        Me.picOverdueIcon.BackColor = System.Drawing.Color.Transparent
        Me.picOverdueIcon.Image = CType(resources.GetObject("picOverdueIcon.Image"), System.Drawing.Image)
        Me.picOverdueIcon.Location = New System.Drawing.Point(13, 8)
        Me.picOverdueIcon.Name = "picOverdueIcon"
        Me.picOverdueIcon.Size = New System.Drawing.Size(72, 60)
        Me.picOverdueIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOverdueIcon.TabIndex = 18
        Me.picOverdueIcon.TabStop = False
        '
        'lblOverdue
        '
        Me.lblOverdue.AutoSize = True
        Me.lblOverdue.BackColor = System.Drawing.Color.Transparent
        Me.lblOverdue.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverdue.ForeColor = System.Drawing.Color.White
        Me.lblOverdue.Location = New System.Drawing.Point(92, 11)
        Me.lblOverdue.Name = "lblOverdue"
        Me.lblOverdue.Size = New System.Drawing.Size(329, 26)
        Me.lblOverdue.TabIndex = 17
        Me.lblOverdue.Text = "STUDENTS' OVERDUE BOOK"
        '
        'pnlCopies
        '
        Me.pnlCopies.BackColor = System.Drawing.Color.Black
        Me.pnlCopies.Controls.Add(Me.picContactIcon)
        Me.pnlCopies.Controls.Add(Me.lblTotalStudentsCount)
        Me.pnlCopies.Controls.Add(Me.lblTotalStudents)
        Me.pnlCopies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCopies.Location = New System.Drawing.Point(3, 3)
        Me.pnlCopies.Name = "pnlCopies"
        Me.pnlCopies.Size = New System.Drawing.Size(416, 79)
        Me.pnlCopies.TabIndex = 15
        '
        'picContactIcon
        '
        Me.picContactIcon.Image = CType(resources.GetObject("picContactIcon.Image"), System.Drawing.Image)
        Me.picContactIcon.Location = New System.Drawing.Point(3, 3)
        Me.picContactIcon.Name = "picContactIcon"
        Me.picContactIcon.Size = New System.Drawing.Size(68, 68)
        Me.picContactIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picContactIcon.TabIndex = 20
        Me.picContactIcon.TabStop = False
        '
        'lblTotalStudentsCount
        '
        Me.lblTotalStudentsCount.AutoSize = True
        Me.lblTotalStudentsCount.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalStudentsCount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStudentsCount.ForeColor = System.Drawing.Color.White
        Me.lblTotalStudentsCount.Location = New System.Drawing.Point(86, 47)
        Me.lblTotalStudentsCount.Name = "lblTotalStudentsCount"
        Me.lblTotalStudentsCount.Size = New System.Drawing.Size(22, 23)
        Me.lblTotalStudentsCount.TabIndex = 17
        Me.lblTotalStudentsCount.Text = "0"
        '
        'lblTotalStudents
        '
        Me.lblTotalStudents.AutoSize = True
        Me.lblTotalStudents.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalStudents.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStudents.ForeColor = System.Drawing.Color.White
        Me.lblTotalStudents.Location = New System.Drawing.Point(86, 11)
        Me.lblTotalStudents.Name = "lblTotalStudents"
        Me.lblTotalStudents.Size = New System.Drawing.Size(193, 23)
        Me.lblTotalStudents.TabIndex = 16
        Me.lblTotalStudents.Text = "TOTAL STUDENTS"
        '
        'pnlTitles
        '
        Me.pnlTitles.BackColor = System.Drawing.Color.Black
        Me.pnlTitles.Controls.Add(Me.lblActiveRegCount)
        Me.pnlTitles.Controls.Add(Me.picRegisterIcon)
        Me.pnlTitles.Controls.Add(Me.lblActiveReg)
        Me.pnlTitles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTitles.Location = New System.Drawing.Point(425, 3)
        Me.pnlTitles.Name = "pnlTitles"
        Me.pnlTitles.Size = New System.Drawing.Size(416, 79)
        Me.pnlTitles.TabIndex = 14
        '
        'lblActiveRegCount
        '
        Me.lblActiveRegCount.AutoSize = True
        Me.lblActiveRegCount.BackColor = System.Drawing.Color.Transparent
        Me.lblActiveRegCount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveRegCount.ForeColor = System.Drawing.Color.White
        Me.lblActiveRegCount.Location = New System.Drawing.Point(96, 47)
        Me.lblActiveRegCount.Name = "lblActiveRegCount"
        Me.lblActiveRegCount.Size = New System.Drawing.Size(22, 23)
        Me.lblActiveRegCount.TabIndex = 18
        Me.lblActiveRegCount.Text = "0"
        '
        'picRegisterIcon
        '
        Me.picRegisterIcon.BackColor = System.Drawing.Color.Transparent
        Me.picRegisterIcon.Image = CType(resources.GetObject("picRegisterIcon.Image"), System.Drawing.Image)
        Me.picRegisterIcon.Location = New System.Drawing.Point(17, 11)
        Me.picRegisterIcon.Name = "picRegisterIcon"
        Me.picRegisterIcon.Size = New System.Drawing.Size(72, 60)
        Me.picRegisterIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRegisterIcon.TabIndex = 15
        Me.picRegisterIcon.TabStop = False
        '
        'lblActiveReg
        '
        Me.lblActiveReg.AutoSize = True
        Me.lblActiveReg.BackColor = System.Drawing.Color.Transparent
        Me.lblActiveReg.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveReg.ForeColor = System.Drawing.Color.White
        Me.lblActiveReg.Location = New System.Drawing.Point(92, 11)
        Me.lblActiveReg.Name = "lblActiveReg"
        Me.lblActiveReg.Size = New System.Drawing.Size(256, 23)
        Me.lblActiveReg.TabIndex = 15
        Me.lblActiveReg.Text = "ACTIVE REGISTRATIONS"
        '
        'timerSidebar
        '
        Me.timerSidebar.Interval = 10
        '
        'pnlStudentDetails
        '
        Me.pnlStudentDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStudentDetails.BackColor = System.Drawing.Color.Black
        Me.pnlStudentDetails.Controls.Add(Me.txtStuID)
        Me.pnlStudentDetails.Controls.Add(Me.picAdminIcon)
        Me.pnlStudentDetails.Controls.Add(Me.btnAddStudent)
        Me.pnlStudentDetails.Controls.Add(Me.btnResetPassword)
        Me.pnlStudentDetails.Controls.Add(Me.lblStuPassword)
        Me.pnlStudentDetails.Controls.Add(Me.txtPassword)
        Me.pnlStudentDetails.Controls.Add(Me.lblStuEmail)
        Me.pnlStudentDetails.Controls.Add(Me.txtEmail)
        Me.pnlStudentDetails.Controls.Add(Me.lblStuName)
        Me.pnlStudentDetails.Controls.Add(Me.lblStuID)
        Me.pnlStudentDetails.Controls.Add(Me.txtName)
        Me.pnlStudentDetails.Controls.Add(Me.btnDeleteStudent)
        Me.pnlStudentDetails.Controls.Add(Me.lblStudentsDetailsAndManagement)
        Me.pnlStudentDetails.Controls.Add(Me.btnUpdateStudent)
        Me.pnlStudentDetails.Location = New System.Drawing.Point(1083, 185)
        Me.pnlStudentDetails.Name = "pnlStudentDetails"
        Me.pnlStudentDetails.Size = New System.Drawing.Size(839, 906)
        Me.pnlStudentDetails.TabIndex = 20
        '
        'txtStuID
        '
        Me.txtStuID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtStuID.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtStuID.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStuID.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtStuID.Location = New System.Drawing.Point(435, 132)
        Me.txtStuID.Name = "txtStuID"
        Me.txtStuID.ReadOnly = True
        Me.txtStuID.Size = New System.Drawing.Size(257, 30)
        Me.txtStuID.TabIndex = 31
        '
        'picAdminIcon
        '
        Me.picAdminIcon.Image = CType(resources.GetObject("picAdminIcon.Image"), System.Drawing.Image)
        Me.picAdminIcon.Location = New System.Drawing.Point(26, 112)
        Me.picAdminIcon.Name = "picAdminIcon"
        Me.picAdminIcon.Size = New System.Drawing.Size(78, 66)
        Me.picAdminIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAdminIcon.TabIndex = 30
        Me.picAdminIcon.TabStop = False
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddStudent.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.ForeColor = System.Drawing.Color.Black
        Me.btnAddStudent.Location = New System.Drawing.Point(184, 679)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(171, 82)
        Me.btnAddStudent.TabIndex = 28
        Me.btnAddStudent.Text = "ADD NEW STUDENT"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'btnResetPassword
        '
        Me.btnResetPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResetPassword.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPassword.ForeColor = System.Drawing.Color.Black
        Me.btnResetPassword.Location = New System.Drawing.Point(582, 445)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(241, 42)
        Me.btnResetPassword.TabIndex = 27
        Me.btnResetPassword.Text = "RESET PASSWORD"
        Me.btnResetPassword.UseVisualStyleBackColor = True
        '
        'lblStuPassword
        '
        Me.lblStuPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStuPassword.AutoSize = True
        Me.lblStuPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblStuPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuPassword.ForeColor = System.Drawing.Color.White
        Me.lblStuPassword.Location = New System.Drawing.Point(236, 368)
        Me.lblStuPassword.Name = "lblStuPassword"
        Me.lblStuPassword.Size = New System.Drawing.Size(126, 26)
        Me.lblStuPassword.TabIndex = 24
        Me.lblStuPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtPassword.Location = New System.Drawing.Point(435, 366)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(257, 30)
        Me.txtPassword.TabIndex = 23
        '
        'lblStuEmail
        '
        Me.lblStuEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStuEmail.AutoSize = True
        Me.lblStuEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblStuEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuEmail.ForeColor = System.Drawing.Color.White
        Me.lblStuEmail.Location = New System.Drawing.Point(236, 318)
        Me.lblStuEmail.Name = "lblStuEmail"
        Me.lblStuEmail.Size = New System.Drawing.Size(78, 26)
        Me.lblStuEmail.TabIndex = 22
        Me.lblStuEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtEmail.Location = New System.Drawing.Point(435, 316)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(257, 30)
        Me.txtEmail.TabIndex = 21
        '
        'lblStuName
        '
        Me.lblStuName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStuName.AutoSize = True
        Me.lblStuName.BackColor = System.Drawing.Color.Transparent
        Me.lblStuName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuName.ForeColor = System.Drawing.Color.White
        Me.lblStuName.Location = New System.Drawing.Point(236, 269)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(81, 26)
        Me.lblStuName.TabIndex = 20
        Me.lblStuName.Text = "Name:"
        '
        'lblStuID
        '
        Me.lblStuID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStuID.AutoSize = True
        Me.lblStuID.BackColor = System.Drawing.Color.Transparent
        Me.lblStuID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuID.ForeColor = System.Drawing.Color.White
        Me.lblStuID.Location = New System.Drawing.Point(236, 139)
        Me.lblStuID.Name = "lblStuID"
        Me.lblStuID.Size = New System.Drawing.Size(91, 26)
        Me.lblStuID.TabIndex = 19
        Me.lblStuID.Text = "Stu. ID:"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtName.Location = New System.Drawing.Point(435, 267)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(257, 30)
        Me.txtName.TabIndex = 16
        '
        'btnDeleteStudent
        '
        Me.btnDeleteStudent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDeleteStudent.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteStudent.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteStudent.Location = New System.Drawing.Point(571, 679)
        Me.btnDeleteStudent.Name = "btnDeleteStudent"
        Me.btnDeleteStudent.Size = New System.Drawing.Size(171, 82)
        Me.btnDeleteStudent.TabIndex = 15
        Me.btnDeleteStudent.Text = "DELETE STUDENT"
        Me.btnDeleteStudent.UseVisualStyleBackColor = True
        '
        'lblStudentsDetailsAndManagement
        '
        Me.lblStudentsDetailsAndManagement.AutoSize = True
        Me.lblStudentsDetailsAndManagement.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentsDetailsAndManagement.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentsDetailsAndManagement.ForeColor = System.Drawing.Color.White
        Me.lblStudentsDetailsAndManagement.Location = New System.Drawing.Point(15, 3)
        Me.lblStudentsDetailsAndManagement.Name = "lblStudentsDetailsAndManagement"
        Me.lblStudentsDetailsAndManagement.Size = New System.Drawing.Size(461, 26)
        Me.lblStudentsDetailsAndManagement.TabIndex = 18
        Me.lblStudentsDetailsAndManagement.Text = "STUDENTS DETAILS AND MANAGEMENT"
        '
        'btnUpdateStudent
        '
        Me.btnUpdateStudent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdateStudent.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStudent.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateStudent.Location = New System.Drawing.Point(375, 679)
        Me.btnUpdateStudent.Name = "btnUpdateStudent"
        Me.btnUpdateStudent.Size = New System.Drawing.Size(171, 82)
        Me.btnUpdateStudent.TabIndex = 14
        Me.btnUpdateStudent.Text = "UPDATE STUDENT"
        Me.btnUpdateStudent.UseVisualStyleBackColor = True
        '
        'StudentManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 989)
        Me.Controls.Add(Me.pnlStudentDetails)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlStudentList)
        Me.Controls.Add(Me.dgvStudent)
        Me.Controls.Add(Me.lblStudentSummary)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.picBookLogo)
        Me.DoubleBuffered = True
        Me.Name = "StudentManagementForm"
        Me.Text = "ReportForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picBookLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStudentList.ResumeLayout(False)
        Me.pnlStudentList.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlOutOfStock.ResumeLayout(False)
        Me.pnlOutOfStock.PerformLayout()
        CType(Me.picStudiesIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCategories.ResumeLayout(False)
        Me.pnlCategories.PerformLayout()
        CType(Me.picOverdueIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCopies.ResumeLayout(False)
        Me.pnlCopies.PerformLayout()
        CType(Me.picContactIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitles.ResumeLayout(False)
        Me.pnlTitles.PerformLayout()
        CType(Me.picRegisterIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStudentDetails.ResumeLayout(False)
        Me.pnlStudentDetails.PerformLayout()
        CType(Me.picAdminIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBookLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents lblStudentSummary As System.Windows.Forms.Label
    Friend WithEvents dgvStudent As System.Windows.Forms.DataGridView
    Friend WithEvents pnlStudentList As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlOutOfStock As System.Windows.Forms.Panel
    Friend WithEvents picOverdueIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblNewStudents As System.Windows.Forms.Label
    Friend WithEvents pnlCategories As System.Windows.Forms.Panel
    Friend WithEvents lblOverdue As System.Windows.Forms.Label
    Friend WithEvents pnlCopies As System.Windows.Forms.Panel
    Friend WithEvents picStudiesIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotalStudents As System.Windows.Forms.Label
    Friend WithEvents pnlTitles As System.Windows.Forms.Panel
    Friend WithEvents picRegisterIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblActiveReg As System.Windows.Forms.Label
    Friend WithEvents timerSidebar As System.Windows.Forms.Timer
    Friend WithEvents lblNewStudentsCount As System.Windows.Forms.Label
    Friend WithEvents lblOverdueCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalStudentsCount As System.Windows.Forms.Label
    Friend WithEvents lblActiveRegCount As System.Windows.Forms.Label
    Friend WithEvents lblSearchStudent As System.Windows.Forms.Label
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents pnlStudentDetails As System.Windows.Forms.Panel
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents btnResetPassword As System.Windows.Forms.Button
    Friend WithEvents lblStuPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblStuEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblStuName As System.Windows.Forms.Label
    Friend WithEvents lblStuID As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnDeleteStudent As System.Windows.Forms.Button
    Friend WithEvents lblStudentsDetailsAndManagement As System.Windows.Forms.Label
    Friend WithEvents btnUpdateStudent As System.Windows.Forms.Button
    Friend WithEvents picAdminIcon As System.Windows.Forms.PictureBox
    Friend WithEvents txtStuID As System.Windows.Forms.TextBox
    Friend WithEvents picContactIcon As System.Windows.Forms.PictureBox
    Friend WithEvents btnBooks As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
End Class
