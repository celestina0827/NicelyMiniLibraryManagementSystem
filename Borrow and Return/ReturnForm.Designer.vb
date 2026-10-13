<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReturnForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnForm))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_Toggle = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.MySqlCommand2 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.Timer_Sidebar = New System.Windows.Forms.Timer(Me.components)
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.dgvActiveBorrows = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblChecklistHeader = New System.Windows.Forms.Label()
        Me.Panel_Checklist = New System.Windows.Forms.Panel()
        Me.chkNoScribbling = New System.Windows.Forms.CheckBox()
        Me.chkNoMissingPages = New System.Windows.Forms.CheckBox()
        Me.chkCoverIntact = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCondition = New System.Windows.Forms.ComboBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnProcessReturn = New System.Windows.Forms.Button()
        Me.Panel_Card = New System.Windows.Forms.Panel()
        Me.Btn_Nav_Dashboard = New System.Windows.Forms.Button()
        Me.Btn_Nav_Borrows = New System.Windows.Forms.Button()
        Me.Btn_Nav_Books = New System.Windows.Forms.Button()
        Me.Panel_Sidebar1 = New System.Windows.Forms.Panel()
        Me.Btn_Nav_Logout = New System.Windows.Forms.Button()
        Me.Btn_Nav_About = New System.Windows.Forms.Button()
        Me.Btn_Nav_History = New System.Windows.Forms.Button()
        Me.Panel_Header.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvActiveBorrows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Checklist.SuspendLayout()
        Me.Panel_Card.SuspendLayout()
        Me.Panel_Sidebar1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel_Header.Controls.Add(Me.Label3)
        Me.Panel_Header.Location = New System.Drawing.Point(2, -1)
        Me.Panel_Header.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(1601, 106)
        Me.Panel_Header.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1451, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Btn_Toggle
        '
        Me.Btn_Toggle.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Toggle.FlatAppearance.BorderSize = 0
        Me.Btn_Toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Toggle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Toggle.ForeColor = System.Drawing.Color.Black
        Me.Btn_Toggle.Location = New System.Drawing.Point(2, 28)
        Me.Btn_Toggle.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Toggle.Name = "Btn_Toggle"
        Me.Btn_Toggle.Size = New System.Drawing.Size(58, 58)
        Me.Btn_Toggle.TabIndex = 21
        Me.Btn_Toggle.Text = "☰"
        Me.Btn_Toggle.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Georgia", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(643, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(371, 49)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "RETURN BOOK"
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'MySqlCommand2
        '
        Me.MySqlCommand2.CacheAge = 0
        Me.MySqlCommand2.Connection = Nothing
        Me.MySqlCommand2.EnableCaching = False
        Me.MySqlCommand2.Transaction = Nothing
        '
        'Timer_Sidebar
        '
        Me.Timer_Sidebar.Interval = 10
        '
        'lblStudentID
        '
        Me.lblStudentID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Noto Sans SC", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblStudentID.Location = New System.Drawing.Point(452, 17)
        Me.lblStudentID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(136, 27)
        Me.lblStudentID.TabIndex = 0
        Me.lblStudentID.Text = "STUDENT ID :"
        '
        'txtStudentID
        '
        Me.txtStudentID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtStudentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentID.Font = New System.Drawing.Font("Noto Sans SC", 11.0!)
        Me.txtStudentID.Location = New System.Drawing.Point(600, 17)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(372, 34)
        Me.txtStudentID.TabIndex = 1
        '
        'dgvActiveBorrows
        '
        Me.dgvActiveBorrows.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvActiveBorrows.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvActiveBorrows.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.dgvActiveBorrows.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Tan
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActiveBorrows.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvActiveBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvActiveBorrows.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvActiveBorrows.EnableHeadersVisualStyles = False
        Me.dgvActiveBorrows.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.dgvActiveBorrows.Location = New System.Drawing.Point(40, 97)
        Me.dgvActiveBorrows.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvActiveBorrows.Name = "dgvActiveBorrows"
        Me.dgvActiveBorrows.RowHeadersWidth = 62
        Me.dgvActiveBorrows.RowTemplate.Height = 28
        Me.dgvActiveBorrows.Size = New System.Drawing.Size(1526, 281)
        Me.dgvActiveBorrows.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Sans SC", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(35, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 27)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ACTIVE BORROWS TO RETURN"
        '
        'lblChecklistHeader
        '
        Me.lblChecklistHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblChecklistHeader.AutoSize = True
        Me.lblChecklistHeader.Font = New System.Drawing.Font("Noto Sans SC", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblChecklistHeader.Location = New System.Drawing.Point(92, 380)
        Me.lblChecklistHeader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChecklistHeader.Name = "lblChecklistHeader"
        Me.lblChecklistHeader.Size = New System.Drawing.Size(126, 27)
        Me.lblChecklistHeader.TabIndex = 23
        Me.lblChecklistHeader.Text = "CHECKLIST :"
        '
        'Panel_Checklist
        '
        Me.Panel_Checklist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel_Checklist.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel_Checklist.Controls.Add(Me.chkNoScribbling)
        Me.Panel_Checklist.Controls.Add(Me.chkNoMissingPages)
        Me.Panel_Checklist.Controls.Add(Me.chkCoverIntact)
        Me.Panel_Checklist.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Checklist.Location = New System.Drawing.Point(97, 412)
        Me.Panel_Checklist.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Checklist.Name = "Panel_Checklist"
        Me.Panel_Checklist.Size = New System.Drawing.Size(298, 154)
        Me.Panel_Checklist.TabIndex = 24
        '
        'chkNoScribbling
        '
        Me.chkNoScribbling.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkNoScribbling.AutoSize = True
        Me.chkNoScribbling.BackColor = System.Drawing.Color.Transparent
        Me.chkNoScribbling.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chkNoScribbling.ForeColor = System.Drawing.Color.Black
        Me.chkNoScribbling.Location = New System.Drawing.Point(27, 108)
        Me.chkNoScribbling.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNoScribbling.Name = "chkNoScribbling"
        Me.chkNoScribbling.Size = New System.Drawing.Size(250, 32)
        Me.chkNoScribbling.TabIndex = 2
        Me.chkNoScribbling.Text = "No Scribbling/Damage"
        Me.chkNoScribbling.UseVisualStyleBackColor = False
        '
        'chkNoMissingPages
        '
        Me.chkNoMissingPages.AutoSize = True
        Me.chkNoMissingPages.BackColor = System.Drawing.Color.Transparent
        Me.chkNoMissingPages.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chkNoMissingPages.ForeColor = System.Drawing.Color.Black
        Me.chkNoMissingPages.Location = New System.Drawing.Point(27, 60)
        Me.chkNoMissingPages.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNoMissingPages.Name = "chkNoMissingPages"
        Me.chkNoMissingPages.Size = New System.Drawing.Size(202, 32)
        Me.chkNoMissingPages.TabIndex = 1
        Me.chkNoMissingPages.Text = "No Missing Pages"
        Me.chkNoMissingPages.UseVisualStyleBackColor = False
        '
        'chkCoverIntact
        '
        Me.chkCoverIntact.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkCoverIntact.AutoSize = True
        Me.chkCoverIntact.BackColor = System.Drawing.Color.Transparent
        Me.chkCoverIntact.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chkCoverIntact.ForeColor = System.Drawing.Color.Black
        Me.chkCoverIntact.Location = New System.Drawing.Point(27, 10)
        Me.chkCoverIntact.Margin = New System.Windows.Forms.Padding(2)
        Me.chkCoverIntact.Name = "chkCoverIntact"
        Me.chkCoverIntact.Size = New System.Drawing.Size(203, 32)
        Me.chkCoverIntact.TabIndex = 0
        Me.chkCoverIntact.Text = "Book Cover Intact"
        Me.chkCoverIntact.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Noto Sans SC", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(468, 382)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 27)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Overall Book Condition : "
        '
        'cmbCondition
        '
        Me.cmbCondition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCondition.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCondition.FormattingEnabled = True
        Me.cmbCondition.Items.AddRange(New Object() {"Good (Ready to Shelve)", "Damaged ", "Lost"})
        Me.cmbCondition.Location = New System.Drawing.Point(473, 424)
        Me.cmbCondition.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCondition.Name = "cmbCondition"
        Me.cmbCondition.Size = New System.Drawing.Size(436, 31)
        Me.cmbCondition.TabIndex = 26
        '
        'lblNotes
        '
        Me.lblNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Noto Sans SC", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblNotes.Location = New System.Drawing.Point(986, 382)
        Me.lblNotes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(203, 27)
        Me.lblNotes.TabIndex = 27
        Me.lblNotes.Text = "NOTES (CONDITION)"
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNotes.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.ForeColor = System.Drawing.Color.White
        Me.txtNotes.Location = New System.Drawing.Point(991, 412)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(538, 154)
        Me.txtNotes.TabIndex = 28
        '
        'btnProcessReturn
        '
        Me.btnProcessReturn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcessReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnProcessReturn.FlatAppearance.BorderSize = 0
        Me.btnProcessReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnProcessReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcessReturn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessReturn.ForeColor = System.Drawing.Color.Black
        Me.btnProcessReturn.Location = New System.Drawing.Point(40, 592)
        Me.btnProcessReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProcessReturn.Name = "btnProcessReturn"
        Me.btnProcessReturn.Size = New System.Drawing.Size(1526, 62)
        Me.btnProcessReturn.TabIndex = 29
        Me.btnProcessReturn.Text = "PROCESS RETURN"
        Me.btnProcessReturn.UseVisualStyleBackColor = False
        '
        'Panel_Card
        '
        Me.Panel_Card.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Card.BackgroundImage = Global.Nicely_Mini_Library_System.My.Resources.Resources.white_marble
        Me.Panel_Card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Card.Controls.Add(Me.btnProcessReturn)
        Me.Panel_Card.Controls.Add(Me.txtNotes)
        Me.Panel_Card.Controls.Add(Me.lblNotes)
        Me.Panel_Card.Controls.Add(Me.cmbCondition)
        Me.Panel_Card.Controls.Add(Me.Label2)
        Me.Panel_Card.Controls.Add(Me.Panel_Checklist)
        Me.Panel_Card.Controls.Add(Me.lblChecklistHeader)
        Me.Panel_Card.Controls.Add(Me.Label1)
        Me.Panel_Card.Controls.Add(Me.dgvActiveBorrows)
        Me.Panel_Card.Controls.Add(Me.txtStudentID)
        Me.Panel_Card.Controls.Add(Me.lblStudentID)
        Me.Panel_Card.Location = New System.Drawing.Point(15, 109)
        Me.Panel_Card.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Card.Name = "Panel_Card"
        Me.Panel_Card.Size = New System.Drawing.Size(1607, 666)
        Me.Panel_Card.TabIndex = 3
        '
        'Btn_Nav_Dashboard
        '
        Me.Btn_Nav_Dashboard.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Nav_Dashboard.FlatAppearance.BorderSize = 0
        Me.Btn_Nav_Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Btn_Nav_Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Nav_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Dashboard.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_Dashboard.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Dashboard.Location = New System.Drawing.Point(25, 66)
        Me.Btn_Nav_Dashboard.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_Dashboard.Name = "Btn_Nav_Dashboard"
        Me.Btn_Nav_Dashboard.Size = New System.Drawing.Size(293, 42)
        Me.Btn_Nav_Dashboard.TabIndex = 21
        Me.Btn_Nav_Dashboard.Text = "🏠 DASHBOARD"
        Me.Btn_Nav_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Dashboard.UseVisualStyleBackColor = False
        '
        'Btn_Nav_Borrows
        '
        Me.Btn_Nav_Borrows.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_Borrows.FlatAppearance.BorderSize = 0
        Me.Btn_Nav_Borrows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Btn_Nav_Borrows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Nav_Borrows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Borrows.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_Borrows.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Borrows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Borrows.Location = New System.Drawing.Point(25, 208)
        Me.Btn_Nav_Borrows.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_Borrows.Name = "Btn_Nav_Borrows"
        Me.Btn_Nav_Borrows.Size = New System.Drawing.Size(214, 42)
        Me.Btn_Nav_Borrows.TabIndex = 25
        Me.Btn_Nav_Borrows.Text = "🛒 BORROWS"
        Me.Btn_Nav_Borrows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Borrows.UseVisualStyleBackColor = False
        '
        'Btn_Nav_Books
        '
        Me.Btn_Nav_Books.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Nav_Books.FlatAppearance.BorderSize = 0
        Me.Btn_Nav_Books.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Btn_Nav_Books.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Nav_Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Books.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nav_Books.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Books.Location = New System.Drawing.Point(25, 132)
        Me.Btn_Nav_Books.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_Books.Name = "Btn_Nav_Books"
        Me.Btn_Nav_Books.Size = New System.Drawing.Size(214, 42)
        Me.Btn_Nav_Books.TabIndex = 26
        Me.Btn_Nav_Books.Text = "📖 BOOKS"
        Me.Btn_Nav_Books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Books.UseVisualStyleBackColor = False
        '
        'Panel_Sidebar1
        '
        Me.Panel_Sidebar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel_Sidebar1.BackgroundImage = Global.Nicely_Mini_Library_System.My.Resources.Resources.photo_2026_09_01_22_58_08
        Me.Panel_Sidebar1.Controls.Add(Me.Btn_Nav_Logout)
        Me.Panel_Sidebar1.Controls.Add(Me.Btn_Nav_About)
        Me.Panel_Sidebar1.Controls.Add(Me.Btn_Nav_History)
        Me.Panel_Sidebar1.Controls.Add(Me.Btn_Nav_Books)
        Me.Panel_Sidebar1.Controls.Add(Me.Btn_Nav_Borrows)
        Me.Panel_Sidebar1.Controls.Add(Me.Btn_Nav_Dashboard)
        Me.Panel_Sidebar1.Location = New System.Drawing.Point(0, 92)
        Me.Panel_Sidebar1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Sidebar1.Name = "Panel_Sidebar1"
        Me.Panel_Sidebar1.Size = New System.Drawing.Size(11, 688)
        Me.Panel_Sidebar1.TabIndex = 20
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
        Me.Btn_Nav_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Logout.Location = New System.Drawing.Point(25, 429)
        Me.Btn_Nav_Logout.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_Logout.Name = "Btn_Nav_Logout"
        Me.Btn_Nav_Logout.Size = New System.Drawing.Size(216, 47)
        Me.Btn_Nav_Logout.TabIndex = 31
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
        Me.Btn_Nav_About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_About.Location = New System.Drawing.Point(25, 350)
        Me.Btn_Nav_About.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_About.Name = "Btn_Nav_About"
        Me.Btn_Nav_About.Size = New System.Drawing.Size(216, 44)
        Me.Btn_Nav_About.TabIndex = 30
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
        Me.Btn_Nav_History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_History.Location = New System.Drawing.Point(25, 276)
        Me.Btn_Nav_History.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_History.Name = "Btn_Nav_History"
        Me.Btn_Nav_History.Size = New System.Drawing.Size(306, 48)
        Me.Btn_Nav_History.TabIndex = 28
        Me.Btn_Nav_History.Text = "📜 BORROW HISTORY"
        Me.Btn_Nav_History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_History.UseVisualStyleBackColor = False
        '
        'ReturnForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1602, 761)
        Me.Controls.Add(Me.Panel_Card)
        Me.Controls.Add(Me.Panel_Sidebar1)
        Me.Controls.Add(Me.Panel_Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ReturnForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReturnForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Header.ResumeLayout(False)
        Me.Panel_Header.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvActiveBorrows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Checklist.ResumeLayout(False)
        Me.Panel_Checklist.PerformLayout()
        Me.Panel_Card.ResumeLayout(False)
        Me.Panel_Card.PerformLayout()
        Me.Panel_Sidebar1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Header As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents MySqlCommand2 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Timer_Sidebar As Timer
    Friend WithEvents Btn_Toggle As Button
    Friend WithEvents lblStudentID As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents dgvActiveBorrows As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblChecklistHeader As Label
    Friend WithEvents Panel_Checklist As Panel
    Friend WithEvents chkNoScribbling As CheckBox
    Friend WithEvents chkNoMissingPages As CheckBox
    Friend WithEvents chkCoverIntact As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCondition As ComboBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnProcessReturn As Button
    Friend WithEvents Panel_Card As Panel
    Friend WithEvents Btn_Nav_Dashboard As Button
    Friend WithEvents Btn_Nav_Borrows As Button
    Friend WithEvents Btn_Nav_Books As Button
    Friend WithEvents Panel_Sidebar1 As Panel
    Friend WithEvents Btn_Nav_History As Button
    Friend WithEvents Btn_Nav_About As Button
    Friend WithEvents Btn_Nav_Logout As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
