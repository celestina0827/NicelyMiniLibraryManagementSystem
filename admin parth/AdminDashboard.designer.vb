<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblDashboardTitle = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.pnlAdminProfileSystemStatus = New System.Windows.Forms.Panel()
        Me.lblLastDate = New System.Windows.Forms.Label()
        Me.lblLastReport = New System.Windows.Forms.Label()
        Me.picCalendarIcon = New System.Windows.Forms.PictureBox()
        Me.picGreenLightIcon = New System.Windows.Forms.PictureBox()
        Me.lblDatabaseConnected = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.picAdminIcon = New System.Windows.Forms.PictureBox()
        Me.lblAdminProfileSystemStatus = New System.Windows.Forms.Label()
        Me.picBookLogo = New System.Windows.Forms.PictureBox()
        Me.pnlChart = New System.Windows.Forms.Panel()
        Me.chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnldgv = New System.Windows.Forms.Panel()
        Me.dgvBorrow = New System.Windows.Forms.DataGridView()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.timerSidebar = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlCardTotalStudents = New System.Windows.Forms.Panel()
        Me.lblTotalStudentO = New System.Windows.Forms.Label()
        Me.picContactIcon = New System.Windows.Forms.PictureBox()
        Me.lblTotalStudent = New System.Windows.Forms.Label()
        Me.pnlCardBorrowedBooks = New System.Windows.Forms.Panel()
        Me.lblBorrowBookO = New System.Windows.Forms.Label()
        Me.picTrolleyIcon = New System.Windows.Forms.PictureBox()
        Me.lblBorrowedBooks = New System.Windows.Forms.Label()
        Me.pnlCardTotalBooks = New System.Windows.Forms.Panel()
        Me.lblTotalBookO = New System.Windows.Forms.Label()
        Me.picBookIcon = New System.Windows.Forms.PictureBox()
        Me.lblTotalBooks = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pnlAdminProfileSystemStatus.SuspendLayout()
        CType(Me.picCalendarIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreenLightIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAdminIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBookLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlChart.SuspendLayout()
        CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnldgv.SuspendLayout()
        CType(Me.dgvBorrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlCardTotalStudents.SuspendLayout()
        CType(Me.picContactIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCardBorrowedBooks.SuspendLayout()
        CType(Me.picTrolleyIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCardTotalBooks.SuspendLayout()
        CType(Me.picBookIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDashboardTitle
        '
        Me.lblDashboardTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDashboardTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardTitle.ForeColor = System.Drawing.Color.Black
        Me.lblDashboardTitle.Location = New System.Drawing.Point(243, 24)
        Me.lblDashboardTitle.Name = "lblDashboardTitle"
        Me.lblDashboardTitle.Size = New System.Drawing.Size(808, 36)
        Me.lblDashboardTitle.TabIndex = 4
        Me.lblDashboardTitle.Text = "ADMIN DASHBOARD - SYSTEM OVERVIEW"
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.BackColor = System.Drawing.Color.Transparent
        Me.lblLine.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine.ForeColor = System.Drawing.Color.Gold
        Me.lblLine.Location = New System.Drawing.Point(-4, 54)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(2182, 21)
        Me.lblLine.TabIndex = 5
        Me.lblLine.Text = resources.GetString("lblLine.Text")
        '
        'pnlAdminProfileSystemStatus
        '
        Me.pnlAdminProfileSystemStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAdminProfileSystemStatus.BackColor = System.Drawing.Color.Black
        Me.pnlAdminProfileSystemStatus.Controls.Add(Me.lblLastDate)
        Me.pnlAdminProfileSystemStatus.Controls.Add(Me.lblLastReport)
        Me.pnlAdminProfileSystemStatus.Controls.Add(Me.picCalendarIcon)
        Me.pnlAdminProfileSystemStatus.Controls.Add(Me.picGreenLightIcon)
        Me.pnlAdminProfileSystemStatus.Controls.Add(Me.lblDatabaseConnected)
        Me.pnlAdminProfileSystemStatus.Controls.Add(Me.lblAdmin)
        Me.pnlAdminProfileSystemStatus.Controls.Add(Me.picAdminIcon)
        Me.pnlAdminProfileSystemStatus.Controls.Add(Me.lblAdminProfileSystemStatus)
        Me.pnlAdminProfileSystemStatus.Location = New System.Drawing.Point(998, 77)
        Me.pnlAdminProfileSystemStatus.Name = "pnlAdminProfileSystemStatus"
        Me.pnlAdminProfileSystemStatus.Size = New System.Drawing.Size(253, 321)
        Me.pnlAdminProfileSystemStatus.TabIndex = 3
        '
        'lblLastDate
        '
        Me.lblLastDate.AutoSize = True
        Me.lblLastDate.BackColor = System.Drawing.Color.Transparent
        Me.lblLastDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastDate.ForeColor = System.Drawing.Color.Black
        Me.lblLastDate.Location = New System.Drawing.Point(76, 286)
        Me.lblLastDate.Name = "lblLastDate"
        Me.lblLastDate.Size = New System.Drawing.Size(0, 23)
        Me.lblLastDate.TabIndex = 15
        Me.lblLastDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLastReport
        '
        Me.lblLastReport.AutoSize = True
        Me.lblLastReport.BackColor = System.Drawing.Color.Transparent
        Me.lblLastReport.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastReport.ForeColor = System.Drawing.Color.Black
        Me.lblLastReport.Location = New System.Drawing.Point(76, 255)
        Me.lblLastReport.Name = "lblLastReport"
        Me.lblLastReport.Size = New System.Drawing.Size(156, 23)
        Me.lblLastReport.TabIndex = 14
        Me.lblLastReport.Text = "LAST REPORT:"
        Me.lblLastReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picCalendarIcon
        '
        Me.picCalendarIcon.Image = CType(resources.GetObject("picCalendarIcon.Image"), System.Drawing.Image)
        Me.picCalendarIcon.Location = New System.Drawing.Point(3, 255)
        Me.picCalendarIcon.Name = "picCalendarIcon"
        Me.picCalendarIcon.Size = New System.Drawing.Size(67, 52)
        Me.picCalendarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCalendarIcon.TabIndex = 11
        Me.picCalendarIcon.TabStop = False
        '
        'picGreenLightIcon
        '
        Me.picGreenLightIcon.Image = CType(resources.GetObject("picGreenLightIcon.Image"), System.Drawing.Image)
        Me.picGreenLightIcon.Location = New System.Drawing.Point(3, 186)
        Me.picGreenLightIcon.Name = "picGreenLightIcon"
        Me.picGreenLightIcon.Size = New System.Drawing.Size(67, 53)
        Me.picGreenLightIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGreenLightIcon.TabIndex = 11
        Me.picGreenLightIcon.TabStop = False
        '
        'lblDatabaseConnected
        '
        Me.lblDatabaseConnected.AutoSize = True
        Me.lblDatabaseConnected.BackColor = System.Drawing.Color.Transparent
        Me.lblDatabaseConnected.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatabaseConnected.ForeColor = System.Drawing.Color.Lime
        Me.lblDatabaseConnected.Location = New System.Drawing.Point(76, 196)
        Me.lblDatabaseConnected.Name = "lblDatabaseConnected"
        Me.lblDatabaseConnected.Size = New System.Drawing.Size(140, 46)
        Me.lblDatabaseConnected.TabIndex = 13
        Me.lblDatabaseConnected.Text = "DATABASE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CONNECTED"
        Me.lblDatabaseConnected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lblAdmin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.ForeColor = System.Drawing.Color.Black
        Me.lblAdmin.Location = New System.Drawing.Point(83, 157)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(77, 23)
        Me.lblAdmin.TabIndex = 12
        Me.lblAdmin.Text = "ADMIN"
        Me.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picAdminIcon
        '
        Me.picAdminIcon.Image = CType(resources.GetObject("picAdminIcon.Image"), System.Drawing.Image)
        Me.picAdminIcon.Location = New System.Drawing.Point(71, 56)
        Me.picAdminIcon.Name = "picAdminIcon"
        Me.picAdminIcon.Size = New System.Drawing.Size(108, 98)
        Me.picAdminIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAdminIcon.TabIndex = 11
        Me.picAdminIcon.TabStop = False
        '
        'lblAdminProfileSystemStatus
        '
        Me.lblAdminProfileSystemStatus.AutoSize = True
        Me.lblAdminProfileSystemStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblAdminProfileSystemStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminProfileSystemStatus.ForeColor = System.Drawing.Color.Black
        Me.lblAdminProfileSystemStatus.Location = New System.Drawing.Point(36, 10)
        Me.lblAdminProfileSystemStatus.Name = "lblAdminProfileSystemStatus"
        Me.lblAdminProfileSystemStatus.Size = New System.Drawing.Size(178, 46)
        Me.lblAdminProfileSystemStatus.TabIndex = 11
        Me.lblAdminProfileSystemStatus.Text = "ADMIN PROFILE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SYSTEM STATUS"
        Me.lblAdminProfileSystemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBookLogo
        '
        Me.picBookLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBookLogo.BackColor = System.Drawing.Color.Transparent
        Me.picBookLogo.Image = CType(resources.GetObject("picBookLogo.Image"), System.Drawing.Image)
        Me.picBookLogo.Location = New System.Drawing.Point(1179, 2)
        Me.picBookLogo.Name = "picBookLogo"
        Me.picBookLogo.Size = New System.Drawing.Size(72, 58)
        Me.picBookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBookLogo.TabIndex = 6
        Me.picBookLogo.TabStop = False
        '
        'pnlChart
        '
        Me.pnlChart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlChart.BackColor = System.Drawing.Color.Black
        Me.pnlChart.Controls.Add(Me.chart)
        Me.pnlChart.Location = New System.Drawing.Point(998, 410)
        Me.pnlChart.Name = "pnlChart"
        Me.pnlChart.Size = New System.Drawing.Size(253, 246)
        Me.pnlChart.TabIndex = 7
        '
        'chart
        '
        Me.chart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chart.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.chart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chart.Legends.Add(Legend2)
        Me.chart.Location = New System.Drawing.Point(17, 3)
        Me.chart.Name = "chart"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chart.Series.Add(Series2)
        Me.chart.Size = New System.Drawing.Size(236, 224)
        Me.chart.TabIndex = 0
        Me.chart.Text = "Chart1"
        '
        'pnldgv
        '
        Me.pnldgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnldgv.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnldgv.Controls.Add(Me.dgvBorrow)
        Me.pnldgv.Location = New System.Drawing.Point(250, 209)
        Me.pnldgv.Name = "pnldgv"
        Me.pnldgv.Size = New System.Drawing.Size(732, 453)
        Me.pnldgv.TabIndex = 3
        '
        'dgvBorrow
        '
        Me.dgvBorrow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrow.Location = New System.Drawing.Point(0, 3)
        Me.dgvBorrow.Name = "dgvBorrow"
        Me.dgvBorrow.RowTemplate.Height = 24
        Me.dgvBorrow.Size = New System.Drawing.Size(726, 447)
        Me.dgvBorrow.TabIndex = 0
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
        Me.pnlSidebar.Controls.Add(Me.btnStudent)
        Me.pnlSidebar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(237, 682)
        Me.pnlSidebar.TabIndex = 8
        '
        'btnBooks
        '
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.Color.White
        Me.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.Location = New System.Drawing.Point(15, 155)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnBooks.Size = New System.Drawing.Size(222, 40)
        Me.btnBooks.TabIndex = 9
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
        Me.btnLogOut.Location = New System.Drawing.Point(15, 339)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(222, 40)
        Me.btnLogOut.TabIndex = 8
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
        Me.btnSettings.Location = New System.Drawing.Point(15, 247)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnSettings.Size = New System.Drawing.Size(222, 40)
        Me.btnSettings.TabIndex = 6
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
        Me.btnAbout.Location = New System.Drawing.Point(15, 293)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnAbout.Size = New System.Drawing.Size(222, 40)
        Me.btnAbout.TabIndex = 5
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
        Me.btnReport.Location = New System.Drawing.Point(15, 201)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnReport.Size = New System.Drawing.Size(222, 40)
        Me.btnReport.TabIndex = 4
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
        Me.btnStudent.Location = New System.Drawing.Point(15, 109)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnStudent.Size = New System.Drawing.Size(222, 40)
        Me.btnStudent.TabIndex = 2
        Me.btnStudent.Text = "👨‍🎓 STUDENT"
        Me.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudent.UseVisualStyleBackColor = True
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
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "≡"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'timerSidebar
        '
        Me.timerSidebar.Interval = 10
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlCardTotalStudents, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlCardBorrowedBooks, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlCardTotalBooks, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(243, 77)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(736, 124)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'pnlCardTotalStudents
        '
        Me.pnlCardTotalStudents.BackColor = System.Drawing.Color.Black
        Me.pnlCardTotalStudents.Controls.Add(Me.lblTotalStudentO)
        Me.pnlCardTotalStudents.Controls.Add(Me.picContactIcon)
        Me.pnlCardTotalStudents.Controls.Add(Me.lblTotalStudent)
        Me.pnlCardTotalStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardTotalStudents.Location = New System.Drawing.Point(493, 3)
        Me.pnlCardTotalStudents.Name = "pnlCardTotalStudents"
        Me.pnlCardTotalStudents.Size = New System.Drawing.Size(240, 118)
        Me.pnlCardTotalStudents.TabIndex = 11
        '
        'lblTotalStudentO
        '
        Me.lblTotalStudentO.AutoSize = True
        Me.lblTotalStudentO.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalStudentO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStudentO.ForeColor = System.Drawing.Color.White
        Me.lblTotalStudentO.Location = New System.Drawing.Point(85, 66)
        Me.lblTotalStudentO.Name = "lblTotalStudentO"
        Me.lblTotalStudentO.Size = New System.Drawing.Size(0, 23)
        Me.lblTotalStudentO.TabIndex = 10
        '
        'picContactIcon
        '
        Me.picContactIcon.Image = CType(resources.GetObject("picContactIcon.Image"), System.Drawing.Image)
        Me.picContactIcon.Location = New System.Drawing.Point(15, 48)
        Me.picContactIcon.Name = "picContactIcon"
        Me.picContactIcon.Size = New System.Drawing.Size(64, 58)
        Me.picContactIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picContactIcon.TabIndex = 9
        Me.picContactIcon.TabStop = False
        '
        'lblTotalStudent
        '
        Me.lblTotalStudent.AutoSize = True
        Me.lblTotalStudent.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalStudent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStudent.ForeColor = System.Drawing.Color.White
        Me.lblTotalStudent.Location = New System.Drawing.Point(24, 10)
        Me.lblTotalStudent.Name = "lblTotalStudent"
        Me.lblTotalStudent.Size = New System.Drawing.Size(193, 23)
        Me.lblTotalStudent.TabIndex = 9
        Me.lblTotalStudent.Text = "TOTAL STUDENTS"
        '
        'pnlCardBorrowedBooks
        '
        Me.pnlCardBorrowedBooks.BackColor = System.Drawing.Color.Black
        Me.pnlCardBorrowedBooks.Controls.Add(Me.lblBorrowBookO)
        Me.pnlCardBorrowedBooks.Controls.Add(Me.picTrolleyIcon)
        Me.pnlCardBorrowedBooks.Controls.Add(Me.lblBorrowedBooks)
        Me.pnlCardBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardBorrowedBooks.Location = New System.Drawing.Point(248, 3)
        Me.pnlCardBorrowedBooks.Name = "pnlCardBorrowedBooks"
        Me.pnlCardBorrowedBooks.Size = New System.Drawing.Size(239, 118)
        Me.pnlCardBorrowedBooks.TabIndex = 5
        '
        'lblBorrowBookO
        '
        Me.lblBorrowBookO.AutoSize = True
        Me.lblBorrowBookO.BackColor = System.Drawing.Color.Transparent
        Me.lblBorrowBookO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowBookO.ForeColor = System.Drawing.Color.White
        Me.lblBorrowBookO.Location = New System.Drawing.Point(85, 66)
        Me.lblBorrowBookO.Name = "lblBorrowBookO"
        Me.lblBorrowBookO.Size = New System.Drawing.Size(0, 23)
        Me.lblBorrowBookO.TabIndex = 10
        '
        'picTrolleyIcon
        '
        Me.picTrolleyIcon.Image = CType(resources.GetObject("picTrolleyIcon.Image"), System.Drawing.Image)
        Me.picTrolleyIcon.Location = New System.Drawing.Point(15, 48)
        Me.picTrolleyIcon.Name = "picTrolleyIcon"
        Me.picTrolleyIcon.Size = New System.Drawing.Size(64, 58)
        Me.picTrolleyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTrolleyIcon.TabIndex = 9
        Me.picTrolleyIcon.TabStop = False
        '
        'lblBorrowedBooks
        '
        Me.lblBorrowedBooks.AutoSize = True
        Me.lblBorrowedBooks.BackColor = System.Drawing.Color.Transparent
        Me.lblBorrowedBooks.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowedBooks.ForeColor = System.Drawing.Color.White
        Me.lblBorrowedBooks.Location = New System.Drawing.Point(26, 10)
        Me.lblBorrowedBooks.Name = "lblBorrowedBooks"
        Me.lblBorrowedBooks.Size = New System.Drawing.Size(210, 23)
        Me.lblBorrowedBooks.TabIndex = 9
        Me.lblBorrowedBooks.Text = "BORROWED BOOKS"
        '
        'pnlCardTotalBooks
        '
        Me.pnlCardTotalBooks.BackColor = System.Drawing.Color.Black
        Me.pnlCardTotalBooks.Controls.Add(Me.lblTotalBookO)
        Me.pnlCardTotalBooks.Controls.Add(Me.picBookIcon)
        Me.pnlCardTotalBooks.Controls.Add(Me.lblTotalBooks)
        Me.pnlCardTotalBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardTotalBooks.Location = New System.Drawing.Point(3, 3)
        Me.pnlCardTotalBooks.Name = "pnlCardTotalBooks"
        Me.pnlCardTotalBooks.Size = New System.Drawing.Size(239, 118)
        Me.pnlCardTotalBooks.TabIndex = 4
        '
        'lblTotalBookO
        '
        Me.lblTotalBookO.AutoSize = True
        Me.lblTotalBookO.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalBookO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBookO.ForeColor = System.Drawing.Color.White
        Me.lblTotalBookO.Location = New System.Drawing.Point(85, 66)
        Me.lblTotalBookO.Name = "lblTotalBookO"
        Me.lblTotalBookO.Size = New System.Drawing.Size(0, 23)
        Me.lblTotalBookO.TabIndex = 9
        '
        'picBookIcon
        '
        Me.picBookIcon.Image = CType(resources.GetObject("picBookIcon.Image"), System.Drawing.Image)
        Me.picBookIcon.Location = New System.Drawing.Point(14, 48)
        Me.picBookIcon.Name = "picBookIcon"
        Me.picBookIcon.Size = New System.Drawing.Size(65, 56)
        Me.picBookIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBookIcon.TabIndex = 8
        Me.picBookIcon.TabStop = False
        '
        'lblTotalBooks
        '
        Me.lblTotalBooks.AutoSize = True
        Me.lblTotalBooks.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalBooks.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBooks.ForeColor = System.Drawing.Color.White
        Me.lblTotalBooks.Location = New System.Drawing.Point(46, 10)
        Me.lblTotalBooks.Name = "lblTotalBooks"
        Me.lblTotalBooks.Size = New System.Drawing.Size(157, 23)
        Me.lblTotalBooks.TabIndex = 8
        Me.lblTotalBooks.Text = "TOTAL BOOKS"
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1283, 682)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlAdminProfileSystemStatus)
        Me.Controls.Add(Me.pnldgv)
        Me.Controls.Add(Me.pnlChart)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.picBookLogo)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.lblDashboardTitle)
        Me.DoubleBuffered = True
        Me.Location = New System.Drawing.Point(840, 20)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlAdminProfileSystemStatus.ResumeLayout(False)
        Me.pnlAdminProfileSystemStatus.PerformLayout()
        CType(Me.picCalendarIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreenLightIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAdminIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBookLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlChart.ResumeLayout(False)
        CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnldgv.ResumeLayout(False)
        CType(Me.dgvBorrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlCardTotalStudents.ResumeLayout(False)
        Me.pnlCardTotalStudents.PerformLayout()
        CType(Me.picContactIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCardBorrowedBooks.ResumeLayout(False)
        Me.pnlCardBorrowedBooks.PerformLayout()
        CType(Me.picTrolleyIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCardTotalBooks.ResumeLayout(False)
        Me.pnlCardTotalBooks.PerformLayout()
        CType(Me.picBookIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDashboardTitle As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents pnlAdminProfileSystemStatus As System.Windows.Forms.Panel
    Friend WithEvents picBookLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pnlChart As System.Windows.Forms.Panel
    Friend WithEvents pnldgv As System.Windows.Forms.Panel
    Friend WithEvents lblAdminProfileSystemStatus As System.Windows.Forms.Label
    Friend WithEvents picAdminIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblAdmin As System.Windows.Forms.Label
    Friend WithEvents picGreenLightIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblDatabaseConnected As System.Windows.Forms.Label
    Friend WithEvents lblLastReport As System.Windows.Forms.Label
    Friend WithEvents picCalendarIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblLastDate As System.Windows.Forms.Label
    Friend WithEvents dgvBorrow As System.Windows.Forms.DataGridView
    Friend WithEvents chart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnStudent As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnBooks As System.Windows.Forms.Button
    Friend WithEvents timerSidebar As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlCardTotalBooks As System.Windows.Forms.Panel
    Friend WithEvents lblTotalBookO As System.Windows.Forms.Label
    Friend WithEvents picBookIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotalBooks As System.Windows.Forms.Label
    Friend WithEvents pnlCardBorrowedBooks As System.Windows.Forms.Panel
    Friend WithEvents lblBorrowBookO As System.Windows.Forms.Label
    Friend WithEvents picTrolleyIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblBorrowedBooks As System.Windows.Forms.Label
    Friend WithEvents pnlCardTotalStudents As System.Windows.Forms.Panel
    Friend WithEvents lblTotalStudentO As System.Windows.Forms.Label
    Friend WithEvents picContactIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotalStudent As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
