<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageBookForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageBookForm))
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.txtImage = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblauthor = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblImage = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.txtboxDesc = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblpic = New System.Windows.Forms.Label()
        Me.btnBrowseImage = New System.Windows.Forms.Button()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvBook = New System.Windows.Forms.DataGridView()
        Me.BookIDColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ImagePathColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.timerSideBar = New System.Windows.Forms.Timer(Me.components)
        Me.lblLine = New System.Windows.Forms.Label()
        Me.picBookLogo = New System.Windows.Forms.PictureBox()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.pnlData.SuspendLayout()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBookLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBookID
        '
        Me.txtBookID.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtBookID.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtBookID.Location = New System.Drawing.Point(182, 23)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(507, 31)
        Me.txtBookID.TabIndex = 0
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtAuthor.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtAuthor.Location = New System.Drawing.Point(182, 130)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(507, 31)
        Me.txtAuthor.TabIndex = 1
        '
        'txttitle
        '
        Me.txttitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txttitle.ForeColor = System.Drawing.Color.Goldenrod
        Me.txttitle.Location = New System.Drawing.Point(182, 77)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(507, 31)
        Me.txttitle.TabIndex = 2
        '
        'txtImage
        '
        Me.txtImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtImage.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtImage.Location = New System.Drawing.Point(831, 79)
        Me.txtImage.Name = "txtImage"
        Me.txtImage.Size = New System.Drawing.Size(266, 31)
        Me.txtImage.TabIndex = 3
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtQuantity.Location = New System.Drawing.Point(182, 245)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(507, 31)
        Me.txtQuantity.TabIndex = 4
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbCategory.ForeColor = System.Drawing.Color.Goldenrod
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Computer Science", "Comic", "Psychology", "History", "Novel"})
        Me.cmbCategory.Location = New System.Drawing.Point(182, 184)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(507, 31)
        Me.cmbCategory.TabIndex = 5
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.BackColor = System.Drawing.Color.Transparent
        Me.lblBookID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.ForeColor = System.Drawing.Color.White
        Me.lblBookID.Location = New System.Drawing.Point(27, 31)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(91, 23)
        Me.lblBookID.TabIndex = 6
        Me.lblBookID.Text = "Book ID:"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Location = New System.Drawing.Point(27, 82)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(58, 23)
        Me.lbltitle.TabIndex = 7
        Me.lbltitle.Text = "Title:"
        '
        'lblauthor
        '
        Me.lblauthor.AutoSize = True
        Me.lblauthor.BackColor = System.Drawing.Color.Transparent
        Me.lblauthor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblauthor.ForeColor = System.Drawing.Color.White
        Me.lblauthor.Location = New System.Drawing.Point(27, 135)
        Me.lblauthor.Name = "lblauthor"
        Me.lblauthor.Size = New System.Drawing.Size(82, 23)
        Me.lblauthor.TabIndex = 8
        Me.lblauthor.Text = "Author:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.White
        Me.lblQuantity.Location = New System.Drawing.Point(27, 246)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(98, 23)
        Me.lblQuantity.TabIndex = 9
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblImage
        '
        Me.lblImage.AutoSize = True
        Me.lblImage.ForeColor = System.Drawing.Color.White
        Me.lblImage.Location = New System.Drawing.Point(727, 86)
        Me.lblImage.Name = "lblImage"
        Me.lblImage.Size = New System.Drawing.Size(77, 23)
        Me.lblImage.TabIndex = 10
        Me.lblImage.Text = "Image:"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.White
        Me.lblCategory.Location = New System.Drawing.Point(27, 190)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(107, 23)
        Me.lblCategory.TabIndex = 11
        Me.lblCategory.Text = "Category:"
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbStatus.ForeColor = System.Drawing.Color.Goldenrod
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.cmbStatus.Location = New System.Drawing.Point(831, 28)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(266, 31)
        Me.cmbStatus.TabIndex = 12
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(727, 31)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(78, 23)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "Status:"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(484, 581)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 35)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(815, 581)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 35)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(1458, 581)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 35)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(1350, 128)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(106, 35)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'pnlData
        '
        Me.pnlData.BackColor = System.Drawing.Color.Black
        Me.pnlData.Controls.Add(Me.txtboxDesc)
        Me.pnlData.Controls.Add(Me.lblDescription)
        Me.pnlData.Controls.Add(Me.lblpic)
        Me.pnlData.Controls.Add(Me.btnBrowseImage)
        Me.pnlData.Controls.Add(Me.pictureBox)
        Me.pnlData.Controls.Add(Me.txtBookID)
        Me.pnlData.Controls.Add(Me.lblBookID)
        Me.pnlData.Controls.Add(Me.txttitle)
        Me.pnlData.Controls.Add(Me.lbltitle)
        Me.pnlData.Controls.Add(Me.txtAuthor)
        Me.pnlData.Controls.Add(Me.lblStatus)
        Me.pnlData.Controls.Add(Me.lblauthor)
        Me.pnlData.Controls.Add(Me.cmbStatus)
        Me.pnlData.Controls.Add(Me.txtQuantity)
        Me.pnlData.Controls.Add(Me.lblCategory)
        Me.pnlData.Controls.Add(Me.lblQuantity)
        Me.pnlData.Controls.Add(Me.cmbCategory)
        Me.pnlData.Controls.Add(Me.lblImage)
        Me.pnlData.Controls.Add(Me.Button8)
        Me.pnlData.Controls.Add(Me.txtImage)
        Me.pnlData.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlData.ForeColor = System.Drawing.Color.White
        Me.pnlData.Location = New System.Drawing.Point(376, 184)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(1346, 380)
        Me.pnlData.TabIndex = 18
        '
        'txtboxDesc
        '
        Me.txtboxDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtboxDesc.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtboxDesc.Location = New System.Drawing.Point(182, 298)
        Me.txtboxDesc.Name = "txtboxDesc"
        Me.txtboxDesc.Size = New System.Drawing.Size(507, 31)
        Me.txtboxDesc.TabIndex = 25
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(27, 299)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(129, 23)
        Me.lblDescription.TabIndex = 26
        Me.lblDescription.Text = "Description:"
        '
        'lblpic
        '
        Me.lblpic.AutoSize = True
        Me.lblpic.ForeColor = System.Drawing.Color.White
        Me.lblpic.Location = New System.Drawing.Point(921, 339)
        Me.lblpic.Name = "lblpic"
        Me.lblpic.Size = New System.Drawing.Size(80, 23)
        Me.lblpic.TabIndex = 24
        Me.lblpic.Text = "Picture"
        '
        'btnBrowseImage
        '
        Me.btnBrowseImage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseImage.ForeColor = System.Drawing.Color.Black
        Me.btnBrowseImage.Location = New System.Drawing.Point(1154, 71)
        Me.btnBrowseImage.Name = "btnBrowseImage"
        Me.btnBrowseImage.Size = New System.Drawing.Size(108, 35)
        Me.btnBrowseImage.TabIndex = 23
        Me.btnBrowseImage.Text = "BROWSER"
        Me.btnBrowseImage.UseVisualStyleBackColor = True
        '
        'pictureBox
        '
        Me.pictureBox.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox.BackgroundImage = CType(resources.GetObject("pictureBox.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox.Location = New System.Drawing.Point(865, 135)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(190, 193)
        Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox.TabIndex = 22
        Me.pictureBox.TabStop = False
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(439, 401)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(105, 35)
        Me.Button8.TabIndex = 15
        Me.Button8.Text = "UPDATE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(1155, 576)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 40)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtSearch.Location = New System.Drawing.Point(581, 132)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(713, 38)
        Me.txtSearch.TabIndex = 19
        '
        'dgvBook
        '
        Me.dgvBook.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBook.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDColumn, Me.BookNameColumn, Me.AuthorColumn, Me.CategoryColumn, Me.QuantityColumn, Me.StatusColumn, Me.ImageColumn, Me.ImagePathColumn, Me.descColumn})
        Me.dgvBook.Location = New System.Drawing.Point(376, 643)
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.RowTemplate.Height = 27
        Me.dgvBook.Size = New System.Drawing.Size(1346, 254)
        Me.dgvBook.TabIndex = 20
        '
        'BookIDColumn
        '
        Me.BookIDColumn.HeaderText = "Book ID"
        Me.BookIDColumn.Name = "BookIDColumn"
        '
        'BookNameColumn
        '
        Me.BookNameColumn.HeaderText = "Title"
        Me.BookNameColumn.Name = "BookNameColumn"
        '
        'AuthorColumn
        '
        Me.AuthorColumn.HeaderText = "Author"
        Me.AuthorColumn.Name = "AuthorColumn"
        '
        'CategoryColumn
        '
        Me.CategoryColumn.HeaderText = "Category"
        Me.CategoryColumn.Name = "CategoryColumn"
        '
        'QuantityColumn
        '
        Me.QuantityColumn.HeaderText = "Quantity"
        Me.QuantityColumn.Name = "QuantityColumn"
        '
        'StatusColumn
        '
        Me.StatusColumn.HeaderText = "Status"
        Me.StatusColumn.Name = "StatusColumn"
        '
        'ImageColumn
        '
        Me.ImageColumn.HeaderText = "Image"
        Me.ImageColumn.Name = "ImageColumn"
        Me.ImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ImagePathColumn
        '
        Me.ImagePathColumn.HeaderText = "Image Path"
        Me.ImagePathColumn.Name = "ImagePathColumn"
        '
        'descColumn
        '
        Me.descColumn.HeaderText = "Description"
        Me.descColumn.Name = "descColumn"
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Black
        Me.lblFormTitle.Location = New System.Drawing.Point(773, 37)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(590, 44)
        Me.lblFormTitle.TabIndex = 21
        Me.lblFormTitle.Text = "BOOK MANAGEMENT SYSTEM"
        '
        'timerSideBar
        '
        Me.timerSideBar.Interval = 10
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.BackColor = System.Drawing.Color.Transparent
        Me.lblLine.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine.ForeColor = System.Drawing.Color.Gold
        Me.lblLine.Location = New System.Drawing.Point(-472, 81)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(2842, 21)
        Me.lblLine.TabIndex = 26
        Me.lblLine.Text = resources.GetString("lblLine.Text")
        '
        'picBookLogo
        '
        Me.picBookLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBookLogo.BackColor = System.Drawing.Color.Transparent
        Me.picBookLogo.Image = CType(resources.GetObject("picBookLogo.Image"), System.Drawing.Image)
        Me.picBookLogo.Location = New System.Drawing.Point(1725, 17)
        Me.picBookLogo.Name = "picBookLogo"
        Me.picBookLogo.Size = New System.Drawing.Size(72, 64)
        Me.picBookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBookLogo.TabIndex = 27
        Me.picBookLogo.TabStop = False
        '
        'pnlSidebar
        '
        Me.pnlSidebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlSidebar.BackColor = System.Drawing.Color.Black
        Me.pnlSidebar.BackgroundImage = CType(resources.GetObject("pnlSidebar.BackgroundImage"), System.Drawing.Image)
        Me.pnlSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSidebar.Controls.Add(Me.btnLogOut)
        Me.pnlSidebar.Controls.Add(Me.btnSettings)
        Me.pnlSidebar.Controls.Add(Me.btnAbout)
        Me.pnlSidebar.Controls.Add(Me.btnReport)
        Me.pnlSidebar.Controls.Add(Me.btnStudent)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(230, 820)
        Me.pnlSidebar.TabIndex = 28
        '
        'btnLogOut
        '
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(0, 377)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(222, 43)
        Me.btnLogOut.TabIndex = 15
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
        Me.btnSettings.Location = New System.Drawing.Point(0, 279)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnSettings.Size = New System.Drawing.Size(222, 43)
        Me.btnSettings.TabIndex = 14
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
        Me.btnAbout.Location = New System.Drawing.Point(0, 328)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnAbout.Size = New System.Drawing.Size(222, 43)
        Me.btnAbout.TabIndex = 13
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
        Me.btnReport.Location = New System.Drawing.Point(0, 230)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnReport.Size = New System.Drawing.Size(222, 43)
        Me.btnReport.TabIndex = 12
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
        Me.btnStudent.Location = New System.Drawing.Point(0, 181)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnStudent.Size = New System.Drawing.Size(222, 43)
        Me.btnStudent.TabIndex = 11
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
        Me.btnDashboard.Location = New System.Drawing.Point(0, 132)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(222, 43)
        Me.btnDashboard.TabIndex = 10
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
        Me.btnMenu.Size = New System.Drawing.Size(49, 43)
        Me.btnMenu.TabIndex = 26
        Me.btnMenu.Text = "≡"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'ManageBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1809, 816)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.picBookLogo)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.dgvBook)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.pnlData)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnUpdate)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Goldenrod
        Me.Name = "ManageBookForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageBookForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlData.ResumeLayout(False)
        Me.pnlData.PerformLayout()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBookLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBookID As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents txtImage As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblBookID As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents lblauthor As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblImage As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pnlData As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvBook As System.Windows.Forms.DataGridView
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents btnBrowseImage As System.Windows.Forms.Button
    Friend WithEvents pictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents timerSideBar As System.Windows.Forms.Timer
    Friend WithEvents lblpic As System.Windows.Forms.Label
    Friend WithEvents txtboxDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents picBookLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnStudent As System.Windows.Forms.Button
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents BookIDColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookNameColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ImagePathColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
