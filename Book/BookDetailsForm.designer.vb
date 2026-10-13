<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDetailsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookDetailsForm))
        Me.lblBookDetails = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelAuthor = New System.Windows.Forms.Label()
        Me.lblansCategory = New System.Windows.Forms.Label()
        Me.lblansStatus = New System.Windows.Forms.Label()
        Me.lblansquantity = New System.Windows.Forms.Label()
        Me.Btn_Nav_Exit = New System.Windows.Forms.Button()
        Me.Btn_Borrow = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Author = New System.Windows.Forms.Label()
        Me.Panel_Sidebar3 = New System.Windows.Forms.Panel()
        Me.Btn_Nav_Logout = New System.Windows.Forms.Button()
        Me.Btn_Nav_Return = New System.Windows.Forms.Button()
        Me.Btn_Nav_About = New System.Windows.Forms.Button()
        Me.Btn_Nav_History = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.Btn_Nav_DashBoard = New System.Windows.Forms.Button()
        Me.Timer_Sidebar = New System.Windows.Forms.Timer(Me.components)
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.Btn_Toggle = New System.Windows.Forms.Button()
        Me.pnlDecsription = New System.Windows.Forms.Panel()
        Me.picCover = New System.Windows.Forms.PictureBox()
        Me.pnlPicture = New System.Windows.Forms.Panel()
        Me.Panel_Sidebar3.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Header.SuspendLayout()
        Me.pnlDecsription.SuspendLayout()
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPicture.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBookDetails
        '
        Me.lblBookDetails.AutoSize = True
        Me.lblBookDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblBookDetails.Font = New System.Drawing.Font("Georgia", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.lblBookDetails.Image = CType(resources.GetObject("lblBookDetails.Image"), System.Drawing.Image)
        Me.lblBookDetails.Location = New System.Drawing.Point(869, 85)
        Me.lblBookDetails.Name = "lblBookDetails"
        Me.lblBookDetails.Size = New System.Drawing.Size(303, 49)
        Me.lblBookDetails.TabIndex = 1
        Me.lblBookDetails.Text = "Book Details"
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitle.Font = New System.Drawing.Font("Bernard MT Condensed", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.Black
        Me.LabelTitle.Location = New System.Drawing.Point(804, 187)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(92, 39)
        Me.LabelTitle.TabIndex = 2
        Me.LabelTitle.Tag = "12"
        Me.LabelTitle.Text = "label1"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAuthor
        '
        Me.LabelAuthor.AutoSize = True
        Me.LabelAuthor.BackColor = System.Drawing.Color.Transparent
        Me.LabelAuthor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAuthor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelAuthor.Location = New System.Drawing.Point(203, 27)
        Me.LabelAuthor.Name = "LabelAuthor"
        Me.LabelAuthor.Size = New System.Drawing.Size(83, 28)
        Me.LabelAuthor.TabIndex = 3
        Me.LabelAuthor.Tag = "12"
        Me.LabelAuthor.Text = "label2"
        Me.LabelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblansCategory
        '
        Me.lblansCategory.AutoSize = True
        Me.lblansCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblansCategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblansCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblansCategory.Location = New System.Drawing.Point(713, 27)
        Me.lblansCategory.Name = "lblansCategory"
        Me.lblansCategory.Size = New System.Drawing.Size(83, 28)
        Me.lblansCategory.TabIndex = 4
        Me.lblansCategory.Tag = "12"
        Me.lblansCategory.Text = "label4"
        Me.lblansCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblansStatus
        '
        Me.lblansStatus.AutoSize = True
        Me.lblansStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblansStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblansStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblansStatus.Location = New System.Drawing.Point(692, 106)
        Me.lblansStatus.Name = "lblansStatus"
        Me.lblansStatus.Size = New System.Drawing.Size(83, 28)
        Me.lblansStatus.TabIndex = 5
        Me.lblansStatus.Tag = "12"
        Me.lblansStatus.Text = "label5"
        Me.lblansStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblansquantity
        '
        Me.lblansquantity.AutoSize = True
        Me.lblansquantity.BackColor = System.Drawing.Color.Transparent
        Me.lblansquantity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblansquantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblansquantity.Location = New System.Drawing.Point(203, 106)
        Me.lblansquantity.Name = "lblansquantity"
        Me.lblansquantity.Size = New System.Drawing.Size(83, 28)
        Me.lblansquantity.TabIndex = 6
        Me.lblansquantity.Tag = "12"
        Me.lblansquantity.Text = "label3"
        Me.lblansquantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Nav_Exit
        '
        Me.Btn_Nav_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Exit.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_Exit.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Exit.Location = New System.Drawing.Point(25, 429)
        Me.Btn_Nav_Exit.Name = "Btn_Nav_Exit"
        Me.Btn_Nav_Exit.Size = New System.Drawing.Size(209, 45)
        Me.Btn_Nav_Exit.TabIndex = 12
        Me.Btn_Nav_Exit.Text = "🚶‍♀️ EXIT"
        Me.Btn_Nav_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Exit.UseVisualStyleBackColor = True
        '
        'Btn_Borrow
        '
        Me.Btn_Borrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Borrow.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Borrow.ForeColor = System.Drawing.Color.Black
        Me.Btn_Borrow.Location = New System.Drawing.Point(1040, 844)
        Me.Btn_Borrow.Name = "Btn_Borrow"
        Me.Btn_Borrow.Size = New System.Drawing.Size(209, 62)
        Me.Btn_Borrow.TabIndex = 8
        Me.Btn_Borrow.Text = "Borrow"
        Me.Btn_Borrow.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Location = New System.Drawing.Point(629, 187)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(98, 38)
        Me.Title.TabIndex = 9
        Me.Title.Tag = "12"
        Me.Title.Text = "Title:"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Author
        '
        Me.Author.AutoSize = True
        Me.Author.BackColor = System.Drawing.Color.Transparent
        Me.Author.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Author.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Author.Location = New System.Drawing.Point(28, 27)
        Me.Author.Name = "Author"
        Me.Author.Size = New System.Drawing.Size(98, 28)
        Me.Author.TabIndex = 10
        Me.Author.Tag = "12"
        Me.Author.Text = "Author:"
        Me.Author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_Sidebar3
        '
        Me.Panel_Sidebar3.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Sidebar3.BackgroundImage = CType(resources.GetObject("Panel_Sidebar3.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Sidebar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Logout)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Return)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_About)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_History)
        Me.Panel_Sidebar3.Controls.Add(Me.btnBooks)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Exit)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_DashBoard)
        Me.Panel_Sidebar3.Location = New System.Drawing.Point(2, 151)
        Me.Panel_Sidebar3.Name = "Panel_Sidebar3"
        Me.Panel_Sidebar3.Size = New System.Drawing.Size(337, 699)
        Me.Panel_Sidebar3.TabIndex = 11
        '
        'Btn_Nav_Logout
        '
        Me.Btn_Nav_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Logout.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_Logout.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Logout.Location = New System.Drawing.Point(25, 499)
        Me.Btn_Nav_Logout.Name = "Btn_Nav_Logout"
        Me.Btn_Nav_Logout.Size = New System.Drawing.Size(209, 44)
        Me.Btn_Nav_Logout.TabIndex = 18
        Me.Btn_Nav_Logout.Text = "🚪 LOGOUT"
        Me.Btn_Nav_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Logout.UseVisualStyleBackColor = True
        '
        'Btn_Nav_Return
        '
        Me.Btn_Nav_Return.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Return.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_Return.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Return.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Return.Location = New System.Drawing.Point(25, 208)
        Me.Btn_Nav_Return.Name = "Btn_Nav_Return"
        Me.Btn_Nav_Return.Size = New System.Drawing.Size(286, 46)
        Me.Btn_Nav_Return.TabIndex = 17
        Me.Btn_Nav_Return.Text = "↩ RETURN BOOKS"
        Me.Btn_Nav_Return.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Return.UseVisualStyleBackColor = False
        '
        'Btn_Nav_About
        '
        Me.Btn_Nav_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_About.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_About.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_About.Location = New System.Drawing.Point(25, 350)
        Me.Btn_Nav_About.Name = "Btn_Nav_About"
        Me.Btn_Nav_About.Size = New System.Drawing.Size(209, 45)
        Me.Btn_Nav_About.TabIndex = 12
        Me.Btn_Nav_About.Text = "ℹ️ ABOUT"
        Me.Btn_Nav_About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_About.UseVisualStyleBackColor = True
        '
        'Btn_Nav_History
        '
        Me.Btn_Nav_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_History.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_History.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_History.Location = New System.Drawing.Point(25, 276)
        Me.Btn_Nav_History.Name = "Btn_Nav_History"
        Me.Btn_Nav_History.Size = New System.Drawing.Size(286, 44)
        Me.Btn_Nav_History.TabIndex = 12
        Me.Btn_Nav_History.Text = "📜 BORROW HISTORY"
        Me.Btn_Nav_History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_History.UseVisualStyleBackColor = True
        '
        'btnBooks
        '
        Me.btnBooks.BackColor = System.Drawing.Color.Transparent
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.Color.White
        Me.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.Location = New System.Drawing.Point(25, 132)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(209, 46)
        Me.btnBooks.TabIndex = 12
        Me.btnBooks.Text = "📖 BOOKS"
        Me.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.UseVisualStyleBackColor = False
        '
        'Btn_Nav_DashBoard
        '
        Me.Btn_Nav_DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_DashBoard.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_DashBoard.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_DashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_DashBoard.Location = New System.Drawing.Point(25, 66)
        Me.Btn_Nav_DashBoard.Name = "Btn_Nav_DashBoard"
        Me.Btn_Nav_DashBoard.Size = New System.Drawing.Size(220, 47)
        Me.Btn_Nav_DashBoard.TabIndex = 12
        Me.Btn_Nav_DashBoard.Text = "🏠 DASHBOARD"
        Me.Btn_Nav_DashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_DashBoard.UseVisualStyleBackColor = True
        '
        'Timer_Sidebar
        '
        Me.Timer_Sidebar.Interval = 10
        '
        'pnlDetails
        '
        Me.pnlDetails.BackColor = System.Drawing.Color.Transparent
        Me.pnlDetails.Controls.Add(Me.LabelAuthor)
        Me.pnlDetails.Controls.Add(Me.lblansCategory)
        Me.pnlDetails.Controls.Add(Me.lblansquantity)
        Me.pnlDetails.Controls.Add(Me.lblquantity)
        Me.pnlDetails.Controls.Add(Me.lblStatus)
        Me.pnlDetails.Controls.Add(Me.Author)
        Me.pnlDetails.Controls.Add(Me.lblcategory)
        Me.pnlDetails.Controls.Add(Me.lblansStatus)
        Me.pnlDetails.Location = New System.Drawing.Point(634, 244)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(982, 176)
        Me.pnlDetails.TabIndex = 12
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.BackColor = System.Drawing.Color.Transparent
        Me.lblquantity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblquantity.Location = New System.Drawing.Point(28, 106)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(117, 28)
        Me.lblquantity.TabIndex = 11
        Me.lblquantity.Tag = "12"
        Me.lblquantity.Text = "Quantity:"
        Me.lblquantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStatus.Location = New System.Drawing.Point(553, 106)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(93, 28)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Tag = "12"
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.BackColor = System.Drawing.Color.Transparent
        Me.lblcategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcategory.Location = New System.Drawing.Point(538, 27)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(127, 28)
        Me.lblcategory.TabIndex = 12
        Me.lblcategory.Tag = "12"
        Me.lblcategory.Text = "Category:"
        Me.lblcategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(22, 25)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 28)
        Me.lblDescription.TabIndex = 16
        Me.lblDescription.Text = "label6"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Description
        '
        Me.Description.AutoSize = True
        Me.Description.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Description.Location = New System.Drawing.Point(657, 452)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(155, 28)
        Me.Description.TabIndex = 15
        Me.Description.Text = "Description:"
        Me.Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1549, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 80)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Panel_Header
        '
        Me.Panel_Header.BackgroundImage = CType(resources.GetObject("Panel_Header.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Header.Controls.Add(Me.Btn_Toggle)
        Me.Panel_Header.Controls.Add(Me.PictureBox1)
        Me.Panel_Header.Controls.Add(Me.lblBookDetails)
        Me.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(1687, 155)
        Me.Panel_Header.TabIndex = 21
        '
        'Btn_Toggle
        '
        Me.Btn_Toggle.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Btn_Toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Toggle.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Toggle.ForeColor = System.Drawing.Color.Black
        Me.Btn_Toggle.Location = New System.Drawing.Point(3, 64)
        Me.Btn_Toggle.Name = "Btn_Toggle"
        Me.Btn_Toggle.Size = New System.Drawing.Size(70, 70)
        Me.Btn_Toggle.TabIndex = 9
        Me.Btn_Toggle.Text = "☰"
        Me.Btn_Toggle.UseVisualStyleBackColor = False
        '
        'pnlDecsription
        '
        Me.pnlDecsription.AllowDrop = True
        Me.pnlDecsription.BackColor = System.Drawing.Color.Transparent
        Me.pnlDecsription.Controls.Add(Me.lblDescription)
        Me.pnlDecsription.Location = New System.Drawing.Point(636, 511)
        Me.pnlDecsription.Name = "pnlDecsription"
        Me.pnlDecsription.Size = New System.Drawing.Size(1010, 294)
        Me.pnlDecsription.TabIndex = 22
        '
        'picCover
        '
        Me.picCover.Location = New System.Drawing.Point(54, 49)
        Me.picCover.Name = "picCover"
        Me.picCover.Size = New System.Drawing.Size(240, 351)
        Me.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCover.TabIndex = 0
        Me.picCover.TabStop = False
        '
        'pnlPicture
        '
        Me.pnlPicture.AllowDrop = True
        Me.pnlPicture.BackColor = System.Drawing.Color.Transparent
        Me.pnlPicture.Controls.Add(Me.picCover)
        Me.pnlPicture.Location = New System.Drawing.Point(159, 244)
        Me.pnlPicture.Name = "pnlPicture"
        Me.pnlPicture.Size = New System.Drawing.Size(343, 436)
        Me.pnlPicture.TabIndex = 23
        '
        'BookDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1687, 940)
        Me.Controls.Add(Me.Panel_Sidebar3)
        Me.Controls.Add(Me.pnlPicture)
        Me.Controls.Add(Me.pnlDecsription)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Panel_Header)
        Me.Controls.Add(Me.Btn_Borrow)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.LabelTitle)
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.Name = "BookDetailsForm"
        Me.Text = "BookDetailsForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Sidebar3.ResumeLayout(False)
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Header.ResumeLayout(False)
        Me.Panel_Header.PerformLayout()
        Me.pnlDecsription.ResumeLayout(False)
        Me.pnlDecsription.PerformLayout()
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPicture.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBookDetails As System.Windows.Forms.Label
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents LabelAuthor As System.Windows.Forms.Label
    Friend WithEvents lblansCategory As System.Windows.Forms.Label
    Friend WithEvents lblansStatus As System.Windows.Forms.Label
    Friend WithEvents lblansquantity As System.Windows.Forms.Label
    Friend WithEvents Btn_Nav_Exit As System.Windows.Forms.Button
    Friend WithEvents Btn_Borrow As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Author As System.Windows.Forms.Label
    Friend WithEvents Panel_Sidebar3 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Nav_DashBoard As System.Windows.Forms.Button
    Friend WithEvents btnBooks As System.Windows.Forms.Button
    Friend WithEvents Timer_Sidebar As System.Windows.Forms.Timer
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents lblquantity As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblcategory As System.Windows.Forms.Label
    Friend WithEvents Btn_Nav_About As System.Windows.Forms.Button
    Friend WithEvents Btn_Nav_History As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_Header As System.Windows.Forms.Panel
    Friend WithEvents Btn_Toggle As System.Windows.Forms.Button
    Friend WithEvents Btn_Nav_Return As System.Windows.Forms.Button
    Friend WithEvents Btn_Nav_Logout As System.Windows.Forms.Button
    Friend WithEvents Description As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents pnlDecsription As System.Windows.Forms.Panel
    Friend WithEvents picCover As System.Windows.Forms.PictureBox
    Friend WithEvents pnlPicture As System.Windows.Forms.Panel
End Class
