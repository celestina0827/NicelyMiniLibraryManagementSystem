<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BorrowForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowForm))
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer_Sidebar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_Toggle = New System.Windows.Forms.Button()
        Me.Panel_Sidebar2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_Card = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirmBorrow = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvAvailableBooks = New System.Windows.Forms.DataGridView()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtStuID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Sidebar3 = New System.Windows.Forms.Panel()
        Me.Btn_Nav_Logout = New System.Windows.Forms.Button()
        Me.Btn_Nav_About = New System.Windows.Forms.Button()
        Me.Btn_Nav_History = New System.Windows.Forms.Button()
        Me.Btn_Nav_Books = New System.Windows.Forms.Button()
        Me.Btn_Nav_Return = New System.Windows.Forms.Button()
        Me.Btn_Nav_Dashboard = New System.Windows.Forms.Button()
        Me.Panel_Header.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Card.SuspendLayout()
        CType(Me.dgvAvailableBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Sidebar3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_Sidebar
        '
        Me.Timer_Sidebar.Interval = 10
        '
        'Panel_Header
        '
        Me.Panel_Header.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Header.BackgroundImage = Global.Nicely_Mini_Library_System.My.Resources.Resources.photo_2026_09_01_22_58_08
        Me.Panel_Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Header.Controls.Add(Me.PictureBox1)
        Me.Panel_Header.Controls.Add(Me.Btn_Toggle)
        Me.Panel_Header.Controls.Add(Me.Panel_Sidebar2)
        Me.Panel_Header.Controls.Add(Me.Label3)
        Me.Panel_Header.Location = New System.Drawing.Point(-1, 0)
        Me.Panel_Header.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(1484, 134)
        Me.Panel_Header.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1326, 39)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Btn_Toggle
        '
        Me.Btn_Toggle.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Toggle.FlatAppearance.BorderSize = 0
        Me.Btn_Toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Toggle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Toggle.ForeColor = System.Drawing.Color.Black
        Me.Btn_Toggle.Location = New System.Drawing.Point(-1, 75)
        Me.Btn_Toggle.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Toggle.Name = "Btn_Toggle"
        Me.Btn_Toggle.Size = New System.Drawing.Size(58, 58)
        Me.Btn_Toggle.TabIndex = 8
        Me.Btn_Toggle.Text = "☰"
        Me.Btn_Toggle.UseVisualStyleBackColor = False
        '
        'Panel_Sidebar2
        '
        Me.Panel_Sidebar2.BackgroundImage = Global.Nicely_Mini_Library_System.My.Resources.Resources.photo_2026_09_01_22_58_08
        Me.Panel_Sidebar2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Sidebar2.Location = New System.Drawing.Point(2, 131)
        Me.Panel_Sidebar2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Sidebar2.Name = "Panel_Sidebar2"
        Me.Panel_Sidebar2.Size = New System.Drawing.Size(212, 551)
        Me.Panel_Sidebar2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Georgia", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(600, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(399, 51)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "BORROW BOOK"
        '
        'Panel_Card
        '
        Me.Panel_Card.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Card.BackgroundImage = Global.Nicely_Mini_Library_System.My.Resources.Resources.white_marble
        Me.Panel_Card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Card.Controls.Add(Me.btnCancel)
        Me.Panel_Card.Controls.Add(Me.btnConfirmBorrow)
        Me.Panel_Card.Controls.Add(Me.Label2)
        Me.Panel_Card.Controls.Add(Me.dgvAvailableBooks)
        Me.Panel_Card.Controls.Add(Me.btnFind)
        Me.Panel_Card.Controls.Add(Me.txtStuID)
        Me.Panel_Card.Controls.Add(Me.Label1)
        Me.Panel_Card.Location = New System.Drawing.Point(4, 134)
        Me.Panel_Card.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Card.Name = "Panel_Card"
        Me.Panel_Card.Size = New System.Drawing.Size(1440, 582)
        Me.Panel_Card.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.BackColor = System.Drawing.Color.Khaki
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(571, 511)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(316, 51)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnConfirmBorrow
        '
        Me.btnConfirmBorrow.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConfirmBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnConfirmBorrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConfirmBorrow.Font = New System.Drawing.Font("Noto Sans SC", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmBorrow.Location = New System.Drawing.Point(377, 452)
        Me.btnConfirmBorrow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirmBorrow.Name = "btnConfirmBorrow"
        Me.btnConfirmBorrow.Size = New System.Drawing.Size(660, 53)
        Me.btnConfirmBorrow.TabIndex = 5
        Me.btnConfirmBorrow.Text = "CONFIRM BORROW"
        Me.btnConfirmBorrow.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Noto Sans SC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 127)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "AVAILABLE BOOKS"
        '
        'dgvAvailableBooks
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvAvailableBooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvAvailableBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAvailableBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAvailableBooks.BackgroundColor = System.Drawing.Color.Black
        Me.dgvAvailableBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.Tan
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAvailableBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.dgvAvailableBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer))
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAvailableBooks.DefaultCellStyle = DataGridViewCellStyle30
        Me.dgvAvailableBooks.EnableHeadersVisualStyles = False
        Me.dgvAvailableBooks.GridColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvAvailableBooks.Location = New System.Drawing.Point(58, 162)
        Me.dgvAvailableBooks.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvAvailableBooks.Name = "dgvAvailableBooks"
        Me.dgvAvailableBooks.RowHeadersVisible = False
        Me.dgvAvailableBooks.RowHeadersWidth = 62
        Me.dgvAvailableBooks.RowTemplate.Height = 28
        Me.dgvAvailableBooks.Size = New System.Drawing.Size(1332, 273)
        Me.dgvAvailableBooks.TabIndex = 3
        '
        'btnFind
        '
        Me.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.ForeColor = System.Drawing.Color.Black
        Me.btnFind.Location = New System.Drawing.Point(893, 61)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(207, 42)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'txtStuID
        '
        Me.txtStuID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtStuID.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtStuID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStuID.Font = New System.Drawing.Font("Noto Sans SC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStuID.Location = New System.Drawing.Point(455, 63)
        Me.txtStuID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStuID.Name = "txtStuID"
        Me.txtStuID.Size = New System.Drawing.Size(372, 36)
        Me.txtStuID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Sans SC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT ID："
        '
        'Panel_Sidebar3
        '
        Me.Panel_Sidebar3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel_Sidebar3.BackgroundImage = Global.Nicely_Mini_Library_System.My.Resources.Resources.photo_2026_09_01_22_58_08
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Logout)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_About)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_History)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Books)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Return)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Dashboard)
        Me.Panel_Sidebar3.Location = New System.Drawing.Point(2, 139)
        Me.Panel_Sidebar3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Sidebar3.Name = "Panel_Sidebar3"
        Me.Panel_Sidebar3.Size = New System.Drawing.Size(268, 543)
        Me.Panel_Sidebar3.TabIndex = 7
        '
        'Btn_Nav_Logout
        '
        Me.Btn_Nav_Logout.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_Logout.FlatAppearance.BorderSize = 0
        Me.Btn_Nav_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Nav_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Logout.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_Logout.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Logout.Location = New System.Drawing.Point(25, 429)
        Me.Btn_Nav_Logout.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_Logout.Name = "Btn_Nav_Logout"
        Me.Btn_Nav_Logout.Size = New System.Drawing.Size(242, 46)
        Me.Btn_Nav_Logout.TabIndex = 16
        Me.Btn_Nav_Logout.Text = "🚪 LOGOUT"
        Me.Btn_Nav_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Logout.UseVisualStyleBackColor = False
        '
        'Btn_Nav_About
        '
        Me.Btn_Nav_About.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_About.FlatAppearance.BorderSize = 0
        Me.Btn_Nav_About.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_About.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Nav_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_About.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_About.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_About.Location = New System.Drawing.Point(25, 350)
        Me.Btn_Nav_About.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_About.Name = "Btn_Nav_About"
        Me.Btn_Nav_About.Size = New System.Drawing.Size(242, 49)
        Me.Btn_Nav_About.TabIndex = 15
        Me.Btn_Nav_About.Text = "ℹ️ ABOUT"
        Me.Btn_Nav_About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_About.UseVisualStyleBackColor = False
        '
        'Btn_Nav_History
        '
        Me.Btn_Nav_History.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_History.FlatAppearance.BorderSize = 0
        Me.Btn_Nav_History.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_History.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Nav_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_History.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_History.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_History.Location = New System.Drawing.Point(25, 276)
        Me.Btn_Nav_History.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_History.Name = "Btn_Nav_History"
        Me.Btn_Nav_History.Size = New System.Drawing.Size(332, 45)
        Me.Btn_Nav_History.TabIndex = 13
        Me.Btn_Nav_History.Text = "📜 BORROW HISTORY"
        Me.Btn_Nav_History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_History.UseVisualStyleBackColor = False
        '
        'Btn_Nav_Books
        '
        Me.Btn_Nav_Books.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_Books.FlatAppearance.BorderSize = 0
        Me.Btn_Nav_Books.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_Books.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Nav_Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Books.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_Books.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Books.Location = New System.Drawing.Point(25, 132)
        Me.Btn_Nav_Books.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_Books.Name = "Btn_Nav_Books"
        Me.Btn_Nav_Books.Size = New System.Drawing.Size(222, 45)
        Me.Btn_Nav_Books.TabIndex = 12
        Me.Btn_Nav_Books.Text = "📖 BOOKS"
        Me.Btn_Nav_Books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Books.UseVisualStyleBackColor = False
        '
        'Btn_Nav_Return
        '
        Me.Btn_Nav_Return.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_Return.FlatAppearance.BorderSize = 0
        Me.Btn_Nav_Return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_Return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Nav_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Return.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_Return.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Return.Location = New System.Drawing.Point(19, 207)
        Me.Btn_Nav_Return.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_Return.Name = "Btn_Nav_Return"
        Me.Btn_Nav_Return.Size = New System.Drawing.Size(273, 34)
        Me.Btn_Nav_Return.TabIndex = 8
        Me.Btn_Nav_Return.Text = "↩  RETURN BOOK"
        Me.Btn_Nav_Return.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Return.UseVisualStyleBackColor = False
        '
        'Btn_Nav_Dashboard
        '
        Me.Btn_Nav_Dashboard.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_Dashboard.FlatAppearance.BorderSize = 0
        Me.Btn_Nav_Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Nav_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Dashboard.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_Dashboard.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Dashboard.Location = New System.Drawing.Point(25, 66)
        Me.Btn_Nav_Dashboard.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_Dashboard.Name = "Btn_Nav_Dashboard"
        Me.Btn_Nav_Dashboard.Size = New System.Drawing.Size(273, 43)
        Me.Btn_Nav_Dashboard.TabIndex = 7
        Me.Btn_Nav_Dashboard.Text = "🏠 DASHBOARD"
        Me.Btn_Nav_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Dashboard.UseVisualStyleBackColor = False
        '
        'BorrowForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1442, 685)
        Me.Controls.Add(Me.Panel_Header)
        Me.Controls.Add(Me.Panel_Card)
        Me.Controls.Add(Me.Panel_Sidebar3)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BorrowForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BorrowForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Header.ResumeLayout(False)
        Me.Panel_Header.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Card.ResumeLayout(False)
        Me.Panel_Card.PerformLayout()
        CType(Me.dgvAvailableBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Sidebar3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Card As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_Header As Panel
    Friend WithEvents txtStuID As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvAvailableBooks As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirmBorrow As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel_Sidebar2 As Panel
    Friend WithEvents Panel_Sidebar3 As Panel
    Friend WithEvents Btn_Nav_Books As Button
    Friend WithEvents Btn_Nav_Return As Button
    Friend WithEvents Btn_Nav_Dashboard As Button
    Friend WithEvents Timer_Sidebar As Timer
    Friend WithEvents Btn_Toggle As Button
    Friend WithEvents Btn_Nav_History As Button
    Friend WithEvents Btn_Nav_About As Button
    Friend WithEvents Btn_Nav_Logout As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
