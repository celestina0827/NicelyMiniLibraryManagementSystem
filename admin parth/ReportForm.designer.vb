<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportForm))
        Me.picBookLogo = New System.Windows.Forms.PictureBox()
        Me.lblReportTitle = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblReportSummary = New System.Windows.Forms.Label()
        Me.pnlNvgMenu = New System.Windows.Forms.Panel()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.btnExportCSV = New System.Windows.Forms.Button()
        Me.lblNavMenu = New System.Windows.Forms.Label()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.pnlFilters = New System.Windows.Forms.Panel()
        Me.cmbSort = New System.Windows.Forms.ComboBox()
        Me.lblSortBy = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblFilterTips = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.lblKeyword = New System.Windows.Forms.Label()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlOutOfStock = New System.Windows.Forms.Panel()
        Me.lblOutOfStock = New System.Windows.Forms.Label()
        Me.picOutOfStockIcon = New System.Windows.Forms.PictureBox()
        Me.lblStat4 = New System.Windows.Forms.Label()
        Me.pnlCategories = New System.Windows.Forms.Panel()
        Me.lblCategories = New System.Windows.Forms.Label()
        Me.picCategoriesIcon = New System.Windows.Forms.PictureBox()
        Me.lblStat3 = New System.Windows.Forms.Label()
        Me.pnlCopies = New System.Windows.Forms.Panel()
        Me.lblTotalCopies = New System.Windows.Forms.Label()
        Me.picCopiesIcon = New System.Windows.Forms.PictureBox()
        Me.lblStat2 = New System.Windows.Forms.Label()
        Me.pnlTitles = New System.Windows.Forms.Panel()
        Me.lblTotalTitles = New System.Windows.Forms.Label()
        Me.picTitleIcon = New System.Windows.Forms.PictureBox()
        Me.lblStat1 = New System.Windows.Forms.Label()
        Me.timerSidebar = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picBookLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNvgMenu.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilters.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlOutOfStock.SuspendLayout()
        CType(Me.picOutOfStockIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCategories.SuspendLayout()
        CType(Me.picCategoriesIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCopies.SuspendLayout()
        CType(Me.picCopiesIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitles.SuspendLayout()
        CType(Me.picTitleIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBookLogo
        '
        Me.picBookLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBookLogo.BackColor = System.Drawing.Color.Transparent
        Me.picBookLogo.Image = CType(resources.GetObject("picBookLogo.Image"), System.Drawing.Image)
        Me.picBookLogo.Location = New System.Drawing.Point(1369, 0)
        Me.picBookLogo.Name = "picBookLogo"
        Me.picBookLogo.Size = New System.Drawing.Size(72, 60)
        Me.picBookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBookLogo.TabIndex = 7
        Me.picBookLogo.TabStop = False
        '
        'lblReportTitle
        '
        Me.lblReportTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblReportTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportTitle.ForeColor = System.Drawing.Color.Black
        Me.lblReportTitle.Location = New System.Drawing.Point(266, 14)
        Me.lblReportTitle.Name = "lblReportTitle"
        Me.lblReportTitle.Size = New System.Drawing.Size(808, 36)
        Me.lblReportTitle.TabIndex = 8
        Me.lblReportTitle.Text = "REPORT PREVIEW"
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
        'lblReportSummary
        '
        Me.lblReportSummary.AutoSize = True
        Me.lblReportSummary.BackColor = System.Drawing.Color.Transparent
        Me.lblReportSummary.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportSummary.ForeColor = System.Drawing.Color.White
        Me.lblReportSummary.Location = New System.Drawing.Point(269, 69)
        Me.lblReportSummary.Name = "lblReportSummary"
        Me.lblReportSummary.Size = New System.Drawing.Size(271, 23)
        Me.lblReportSummary.TabIndex = 10
        Me.lblReportSummary.Text = "REPORT SUMMARY              "
        '
        'pnlNvgMenu
        '
        Me.pnlNvgMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlNvgMenu.Controls.Add(Me.btnExportExcel)
        Me.pnlNvgMenu.Controls.Add(Me.btnExportCSV)
        Me.pnlNvgMenu.Location = New System.Drawing.Point(265, 215)
        Me.pnlNvgMenu.Name = "pnlNvgMenu"
        Me.pnlNvgMenu.Size = New System.Drawing.Size(230, 225)
        Me.pnlNvgMenu.TabIndex = 13
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.ForeColor = System.Drawing.Color.Black
        Me.btnExportExcel.Image = CType(resources.GetObject("btnExportExcel.Image"), System.Drawing.Image)
        Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportExcel.Location = New System.Drawing.Point(8, 119)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(205, 94)
        Me.btnExportExcel.TabIndex = 11
        Me.btnExportExcel.Text = "EXPORT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TO EXCEL"
        Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportExcel.UseVisualStyleBackColor = True
        '
        'btnExportCSV
        '
        Me.btnExportCSV.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportCSV.ForeColor = System.Drawing.Color.Black
        Me.btnExportCSV.Image = CType(resources.GetObject("btnExportCSV.Image"), System.Drawing.Image)
        Me.btnExportCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportCSV.Location = New System.Drawing.Point(8, 3)
        Me.btnExportCSV.Name = "btnExportCSV"
        Me.btnExportCSV.Size = New System.Drawing.Size(205, 94)
        Me.btnExportCSV.TabIndex = 10
        Me.btnExportCSV.Text = "EXPORT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TO CSV"
        Me.btnExportCSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportCSV.UseVisualStyleBackColor = True
        '
        'lblNavMenu
        '
        Me.lblNavMenu.AutoSize = True
        Me.lblNavMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblNavMenu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNavMenu.ForeColor = System.Drawing.Color.White
        Me.lblNavMenu.Location = New System.Drawing.Point(261, 190)
        Me.lblNavMenu.Name = "lblNavMenu"
        Me.lblNavMenu.Size = New System.Drawing.Size(397, 23)
        Me.lblNavMenu.TabIndex = 9
        Me.lblNavMenu.Text = "REPORT NAVIGATION MENU                     "
        '
        'dgvReport
        '
        Me.dgvReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(262, 446)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.RowTemplate.Height = 24
        Me.dgvReport.Size = New System.Drawing.Size(1179, 222)
        Me.dgvReport.TabIndex = 14
        '
        'pnlFilters
        '
        Me.pnlFilters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFilters.BackColor = System.Drawing.Color.Black
        Me.pnlFilters.Controls.Add(Me.cmbSort)
        Me.pnlFilters.Controls.Add(Me.lblSortBy)
        Me.pnlFilters.Controls.Add(Me.cmbCategory)
        Me.pnlFilters.Controls.Add(Me.lblCategory)
        Me.pnlFilters.Controls.Add(Me.lblFilterTips)
        Me.pnlFilters.Controls.Add(Me.lblStatus1)
        Me.pnlFilters.Controls.Add(Me.lblKeyword)
        Me.pnlFilters.Controls.Add(Me.lblFilter)
        Me.pnlFilters.Controls.Add(Me.cmbStatus)
        Me.pnlFilters.Controls.Add(Me.txtSearch)
        Me.pnlFilters.Controls.Add(Me.btnClear)
        Me.pnlFilters.Controls.Add(Me.btnSearch)
        Me.pnlFilters.Location = New System.Drawing.Point(556, 215)
        Me.pnlFilters.Name = "pnlFilters"
        Me.pnlFilters.Size = New System.Drawing.Size(898, 228)
        Me.pnlFilters.TabIndex = 13
        '
        'cmbSort
        '
        Me.cmbSort.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbSort.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSort.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSort.ForeColor = System.Drawing.Color.Goldenrod
        Me.cmbSort.FormattingEnabled = True
        Me.cmbSort.Items.AddRange(New Object() {"Default", "Title (A-Z)", "Title (Z-A)", "Quantity (High - Low)", "Quantity (Low - High)"})
        Me.cmbSort.Location = New System.Drawing.Point(534, 153)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(201, 31)
        Me.cmbSort.TabIndex = 27
        '
        'lblSortBy
        '
        Me.lblSortBy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSortBy.AutoSize = True
        Me.lblSortBy.BackColor = System.Drawing.Color.Transparent
        Me.lblSortBy.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSortBy.ForeColor = System.Drawing.Color.White
        Me.lblSortBy.Location = New System.Drawing.Point(195, 160)
        Me.lblSortBy.Name = "lblSortBy"
        Me.lblSortBy.Size = New System.Drawing.Size(87, 23)
        Me.lblSortBy.TabIndex = 26
        Me.lblSortBy.Text = "Sort By:"
        '
        'cmbCategory
        '
        Me.cmbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.ForeColor = System.Drawing.Color.Goldenrod
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"All Categories", "Comic", "Computer Science", "History", "Novel", "Psychology"})
        Me.cmbCategory.Location = New System.Drawing.Point(534, 110)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(201, 31)
        Me.cmbCategory.TabIndex = 25
        '
        'lblCategory
        '
        Me.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.White
        Me.lblCategory.Location = New System.Drawing.Point(195, 117)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(191, 23)
        Me.lblCategory.TabIndex = 22
        Me.lblCategory.Text = "Filter by Category:"
        '
        'lblFilterTips
        '
        Me.lblFilterTips.AutoSize = True
        Me.lblFilterTips.BackColor = System.Drawing.Color.Transparent
        Me.lblFilterTips.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilterTips.ForeColor = System.Drawing.Color.Gray
        Me.lblFilterTips.Location = New System.Drawing.Point(3, 207)
        Me.lblFilterTips.Name = "lblFilterTips"
        Me.lblFilterTips.Size = New System.Drawing.Size(460, 19)
        Me.lblFilterTips.TabIndex = 21
        Me.lblFilterTips.Text = "* Tip: You can search books by entering Book ID, Title, or Author's name."
        '
        'lblStatus1
        '
        Me.lblStatus1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStatus1.AutoSize = True
        Me.lblStatus1.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus1.ForeColor = System.Drawing.Color.White
        Me.lblStatus1.Location = New System.Drawing.Point(530, 38)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(162, 23)
        Me.lblStatus1.TabIndex = 20
        Me.lblStatus1.Text = "Filter by Status:"
        '
        'lblKeyword
        '
        Me.lblKeyword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblKeyword.AutoSize = True
        Me.lblKeyword.BackColor = System.Drawing.Color.Transparent
        Me.lblKeyword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeyword.ForeColor = System.Drawing.Color.White
        Me.lblKeyword.Location = New System.Drawing.Point(195, 38)
        Me.lblKeyword.Name = "lblKeyword"
        Me.lblKeyword.Size = New System.Drawing.Size(179, 23)
        Me.lblKeyword.TabIndex = 19
        Me.lblKeyword.Text = "Search Keyword:"
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.BackColor = System.Drawing.Color.Transparent
        Me.lblFilter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilter.ForeColor = System.Drawing.Color.White
        Me.lblFilter.Location = New System.Drawing.Point(15, 3)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(168, 23)
        Me.lblFilter.TabIndex = 18
        Me.lblFilter.Text = "REPORT FILTER"
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.ForeColor = System.Drawing.Color.Goldenrod
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"All Status", "Available", "Out of Stock"})
        Me.cmbStatus.Location = New System.Drawing.Point(534, 68)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(201, 31)
        Me.cmbStatus.TabIndex = 17
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtSearch.Location = New System.Drawing.Point(199, 68)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(300, 30)
        Me.txtSearch.TabIndex = 16
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(800, 194)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 31)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(693, 194)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(102, 31)
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
        Me.pnlSidebar.Controls.Add(Me.btnStudent)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(255, 682)
        Me.pnlSidebar.TabIndex = 15
        '
        'btnBooks
        '
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.Color.White
        Me.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.Location = New System.Drawing.Point(0, 186)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnBooks.Size = New System.Drawing.Size(222, 40)
        Me.btnBooks.TabIndex = 23
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
        Me.btnLogOut.Location = New System.Drawing.Point(0, 325)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(222, 40)
        Me.btnLogOut.TabIndex = 22
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
        Me.btnSettings.Location = New System.Drawing.Point(0, 232)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnSettings.Size = New System.Drawing.Size(222, 40)
        Me.btnSettings.TabIndex = 21
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
        Me.btnAbout.Location = New System.Drawing.Point(0, 278)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnAbout.Size = New System.Drawing.Size(222, 40)
        Me.btnAbout.TabIndex = 20
        Me.btnAbout.Text = "ℹ️ ABOUT"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnStudent
        '
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudent.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.White
        Me.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudent.Location = New System.Drawing.Point(0, 140)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnStudent.Size = New System.Drawing.Size(222, 40)
        Me.btnStudent.TabIndex = 18
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
        Me.btnDashboard.Location = New System.Drawing.Point(0, 94)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(222, 40)
        Me.btnDashboard.TabIndex = 17
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(262, 94)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1195, 85)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'pnlOutOfStock
        '
        Me.pnlOutOfStock.BackColor = System.Drawing.Color.Black
        Me.pnlOutOfStock.Controls.Add(Me.lblOutOfStock)
        Me.pnlOutOfStock.Controls.Add(Me.picOutOfStockIcon)
        Me.pnlOutOfStock.Controls.Add(Me.lblStat4)
        Me.pnlOutOfStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOutOfStock.Location = New System.Drawing.Point(599, 3)
        Me.pnlOutOfStock.Name = "pnlOutOfStock"
        Me.pnlOutOfStock.Size = New System.Drawing.Size(292, 79)
        Me.pnlOutOfStock.TabIndex = 17
        '
        'lblOutOfStock
        '
        Me.lblOutOfStock.AutoSize = True
        Me.lblOutOfStock.BackColor = System.Drawing.Color.Transparent
        Me.lblOutOfStock.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutOfStock.ForeColor = System.Drawing.Color.White
        Me.lblOutOfStock.Location = New System.Drawing.Point(82, 47)
        Me.lblOutOfStock.Name = "lblOutOfStock"
        Me.lblOutOfStock.Size = New System.Drawing.Size(0, 23)
        Me.lblOutOfStock.TabIndex = 19
        '
        'picOutOfStockIcon
        '
        Me.picOutOfStockIcon.BackColor = System.Drawing.Color.Transparent
        Me.picOutOfStockIcon.Image = CType(resources.GetObject("picOutOfStockIcon.Image"), System.Drawing.Image)
        Me.picOutOfStockIcon.Location = New System.Drawing.Point(3, 11)
        Me.picOutOfStockIcon.Name = "picOutOfStockIcon"
        Me.picOutOfStockIcon.Size = New System.Drawing.Size(72, 60)
        Me.picOutOfStockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOutOfStockIcon.TabIndex = 18
        Me.picOutOfStockIcon.TabStop = False
        '
        'lblStat4
        '
        Me.lblStat4.AutoSize = True
        Me.lblStat4.BackColor = System.Drawing.Color.Transparent
        Me.lblStat4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStat4.ForeColor = System.Drawing.Color.White
        Me.lblStat4.Location = New System.Drawing.Point(81, 11)
        Me.lblStat4.Name = "lblStat4"
        Me.lblStat4.Size = New System.Drawing.Size(164, 23)
        Me.lblStat4.TabIndex = 18
        Me.lblStat4.Text = "OUT OF STOCK"
        '
        'pnlCategories
        '
        Me.pnlCategories.BackColor = System.Drawing.Color.Black
        Me.pnlCategories.Controls.Add(Me.lblCategories)
        Me.pnlCategories.Controls.Add(Me.picCategoriesIcon)
        Me.pnlCategories.Controls.Add(Me.lblStat3)
        Me.pnlCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCategories.Location = New System.Drawing.Point(897, 3)
        Me.pnlCategories.Name = "pnlCategories"
        Me.pnlCategories.Size = New System.Drawing.Size(295, 79)
        Me.pnlCategories.TabIndex = 16
        '
        'lblCategories
        '
        Me.lblCategories.AutoSize = True
        Me.lblCategories.BackColor = System.Drawing.Color.Transparent
        Me.lblCategories.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategories.ForeColor = System.Drawing.Color.White
        Me.lblCategories.Location = New System.Drawing.Point(95, 47)
        Me.lblCategories.Name = "lblCategories"
        Me.lblCategories.Size = New System.Drawing.Size(0, 23)
        Me.lblCategories.TabIndex = 20
        '
        'picCategoriesIcon
        '
        Me.picCategoriesIcon.BackColor = System.Drawing.Color.Transparent
        Me.picCategoriesIcon.Image = CType(resources.GetObject("picCategoriesIcon.Image"), System.Drawing.Image)
        Me.picCategoriesIcon.Location = New System.Drawing.Point(14, 11)
        Me.picCategoriesIcon.Name = "picCategoriesIcon"
        Me.picCategoriesIcon.Size = New System.Drawing.Size(72, 60)
        Me.picCategoriesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCategoriesIcon.TabIndex = 17
        Me.picCategoriesIcon.TabStop = False
        '
        'lblStat3
        '
        Me.lblStat3.AutoSize = True
        Me.lblStat3.BackColor = System.Drawing.Color.Transparent
        Me.lblStat3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStat3.ForeColor = System.Drawing.Color.White
        Me.lblStat3.Location = New System.Drawing.Point(92, 11)
        Me.lblStat3.Name = "lblStat3"
        Me.lblStat3.Size = New System.Drawing.Size(143, 23)
        Me.lblStat3.TabIndex = 17
        Me.lblStat3.Text = "CATEGORIES"
        '
        'pnlCopies
        '
        Me.pnlCopies.BackColor = System.Drawing.Color.Black
        Me.pnlCopies.Controls.Add(Me.lblTotalCopies)
        Me.pnlCopies.Controls.Add(Me.picCopiesIcon)
        Me.pnlCopies.Controls.Add(Me.lblStat2)
        Me.pnlCopies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCopies.Location = New System.Drawing.Point(3, 3)
        Me.pnlCopies.Name = "pnlCopies"
        Me.pnlCopies.Size = New System.Drawing.Size(292, 79)
        Me.pnlCopies.TabIndex = 15
        '
        'lblTotalCopies
        '
        Me.lblTotalCopies.AutoSize = True
        Me.lblTotalCopies.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCopies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCopies.ForeColor = System.Drawing.Color.White
        Me.lblTotalCopies.Location = New System.Drawing.Point(87, 47)
        Me.lblTotalCopies.Name = "lblTotalCopies"
        Me.lblTotalCopies.Size = New System.Drawing.Size(0, 23)
        Me.lblTotalCopies.TabIndex = 17
        '
        'picCopiesIcon
        '
        Me.picCopiesIcon.BackColor = System.Drawing.Color.Transparent
        Me.picCopiesIcon.Image = CType(resources.GetObject("picCopiesIcon.Image"), System.Drawing.Image)
        Me.picCopiesIcon.Location = New System.Drawing.Point(8, 11)
        Me.picCopiesIcon.Name = "picCopiesIcon"
        Me.picCopiesIcon.Size = New System.Drawing.Size(72, 60)
        Me.picCopiesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCopiesIcon.TabIndex = 16
        Me.picCopiesIcon.TabStop = False
        '
        'lblStat2
        '
        Me.lblStat2.AutoSize = True
        Me.lblStat2.BackColor = System.Drawing.Color.Transparent
        Me.lblStat2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStat2.ForeColor = System.Drawing.Color.White
        Me.lblStat2.Location = New System.Drawing.Point(86, 11)
        Me.lblStat2.Name = "lblStat2"
        Me.lblStat2.Size = New System.Drawing.Size(159, 23)
        Me.lblStat2.TabIndex = 16
        Me.lblStat2.Text = "TOTAL COPIES"
        '
        'pnlTitles
        '
        Me.pnlTitles.BackColor = System.Drawing.Color.Black
        Me.pnlTitles.Controls.Add(Me.lblTotalTitles)
        Me.pnlTitles.Controls.Add(Me.picTitleIcon)
        Me.pnlTitles.Controls.Add(Me.lblStat1)
        Me.pnlTitles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTitles.Location = New System.Drawing.Point(301, 3)
        Me.pnlTitles.Name = "pnlTitles"
        Me.pnlTitles.Size = New System.Drawing.Size(292, 79)
        Me.pnlTitles.TabIndex = 14
        '
        'lblTotalTitles
        '
        Me.lblTotalTitles.AutoSize = True
        Me.lblTotalTitles.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalTitles.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTitles.ForeColor = System.Drawing.Color.White
        Me.lblTotalTitles.Location = New System.Drawing.Point(96, 47)
        Me.lblTotalTitles.Name = "lblTotalTitles"
        Me.lblTotalTitles.Size = New System.Drawing.Size(0, 23)
        Me.lblTotalTitles.TabIndex = 18
        '
        'picTitleIcon
        '
        Me.picTitleIcon.BackColor = System.Drawing.Color.Transparent
        Me.picTitleIcon.Image = CType(resources.GetObject("picTitleIcon.Image"), System.Drawing.Image)
        Me.picTitleIcon.Location = New System.Drawing.Point(17, 11)
        Me.picTitleIcon.Name = "picTitleIcon"
        Me.picTitleIcon.Size = New System.Drawing.Size(72, 60)
        Me.picTitleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTitleIcon.TabIndex = 15
        Me.picTitleIcon.TabStop = False
        '
        'lblStat1
        '
        Me.lblStat1.AutoSize = True
        Me.lblStat1.BackColor = System.Drawing.Color.Transparent
        Me.lblStat1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStat1.ForeColor = System.Drawing.Color.White
        Me.lblStat1.Location = New System.Drawing.Point(92, 11)
        Me.lblStat1.Name = "lblStat1"
        Me.lblStat1.Size = New System.Drawing.Size(153, 23)
        Me.lblStat1.TabIndex = 15
        Me.lblStat1.Text = "TOTAL TITLES"
        '
        'timerSidebar
        '
        Me.timerSidebar.Interval = 10
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1457, 680)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlFilters)
        Me.Controls.Add(Me.lblNavMenu)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.pnlNvgMenu)
        Me.Controls.Add(Me.lblReportSummary)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.lblReportTitle)
        Me.Controls.Add(Me.picBookLogo)
        Me.DoubleBuffered = True
        Me.Name = "ReportForm"
        Me.Text = "ReportForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picBookLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNvgMenu.ResumeLayout(False)
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilters.ResumeLayout(False)
        Me.pnlFilters.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlOutOfStock.ResumeLayout(False)
        Me.pnlOutOfStock.PerformLayout()
        CType(Me.picOutOfStockIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCategories.ResumeLayout(False)
        Me.pnlCategories.PerformLayout()
        CType(Me.picCategoriesIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCopies.ResumeLayout(False)
        Me.pnlCopies.PerformLayout()
        CType(Me.picCopiesIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitles.ResumeLayout(False)
        Me.pnlTitles.PerformLayout()
        CType(Me.picTitleIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBookLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblReportTitle As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents lblReportSummary As System.Windows.Forms.Label
    Friend WithEvents pnlNvgMenu As System.Windows.Forms.Panel
    Friend WithEvents btnExportCSV As System.Windows.Forms.Button
    Friend WithEvents lblNavMenu As System.Windows.Forms.Label
    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents btnExportExcel As System.Windows.Forms.Button
    Friend WithEvents pnlFilters As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlOutOfStock As System.Windows.Forms.Panel
    Friend WithEvents picOutOfStockIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblStat4 As System.Windows.Forms.Label
    Friend WithEvents pnlCategories As System.Windows.Forms.Panel
    Friend WithEvents picCategoriesIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblStat3 As System.Windows.Forms.Label
    Friend WithEvents pnlCopies As System.Windows.Forms.Panel
    Friend WithEvents picCopiesIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblStat2 As System.Windows.Forms.Label
    Friend WithEvents pnlTitles As System.Windows.Forms.Panel
    Friend WithEvents picTitleIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblStat1 As System.Windows.Forms.Label
    Friend WithEvents timerSidebar As System.Windows.Forms.Timer
    Friend WithEvents lblOutOfStock As System.Windows.Forms.Label
    Friend WithEvents lblCategories As System.Windows.Forms.Label
    Friend WithEvents lblTotalCopies As System.Windows.Forms.Label
    Friend WithEvents lblTotalTitles As System.Windows.Forms.Label
    Friend WithEvents lblStatus1 As System.Windows.Forms.Label
    Friend WithEvents lblKeyword As System.Windows.Forms.Label
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblFilterTips As System.Windows.Forms.Label
    Friend WithEvents cmbSort As System.Windows.Forms.ComboBox
    Friend WithEvents lblSortBy As System.Windows.Forms.Label
    Friend WithEvents btnBooks As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnStudent As System.Windows.Forms.Button
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
End Class
