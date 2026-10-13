<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookForm))
        Me.lblBook = New System.Windows.Forms.Label()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.pnlLBG = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblfilter = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Sidebar3 = New System.Windows.Forms.Panel()
        Me.Btn_Nav_Return = New System.Windows.Forms.Button()
        Me.Btn_Nav_Borrows = New System.Windows.Forms.Button()
        Me.Btn_Nav_Logout = New System.Windows.Forms.Button()
        Me.Btn_Nav_About = New System.Windows.Forms.Button()
        Me.Btn_Nav_History = New System.Windows.Forms.Button()
        Me.Btn_Nav_Dashboard = New System.Windows.Forms.Button()
        Me.lblbooks = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.Btn_toggle = New System.Windows.Forms.Button()
        Me.Timer_Sidebar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Header = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Sidebar3.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.Panel_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBook
        '
        Me.lblBook.AutoSize = True
        Me.lblBook.BackColor = System.Drawing.Color.Transparent
        Me.lblBook.Font = New System.Drawing.Font("Georgia", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.lblBook.Image = CType(resources.GetObject("lblBook.Image"), System.Drawing.Image)
        Me.lblBook.Location = New System.Drawing.Point(927, 75)
        Me.lblBook.Name = "lblBook"
        Me.lblBook.Size = New System.Drawing.Size(169, 49)
        Me.lblBook.TabIndex = 0
        Me.lblBook.Text = "Books "
        '
        'btnLeft
        '
        Me.btnLeft.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.Location = New System.Drawing.Point(209, 563)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(75, 41)
        Me.btnLeft.TabIndex = 7
        Me.btnLeft.Text = "<"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.Location = New System.Drawing.Point(1655, 573)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(75, 41)
        Me.btnRight.TabIndex = 8
        Me.btnRight.Text = ">"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'pnlLBG
        '
        Me.pnlLBG.AutoScroll = True
        Me.pnlLBG.ForeColor = System.Drawing.Color.Gold
        Me.pnlLBG.Location = New System.Drawing.Point(306, 371)
        Me.pnlLBG.Name = "pnlLBG"
        Me.pnlLBG.Size = New System.Drawing.Size(1314, 398)
        Me.pnlLBG.TabIndex = 9
        Me.pnlLBG.WrapContents = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Gold
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSearch.Location = New System.Drawing.Point(1307, 204)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(148, 48)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.BackColor = System.Drawing.Color.Transparent
        Me.lblsearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblsearch.Location = New System.Drawing.Point(455, 202)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(103, 28)
        Me.lblsearch.TabIndex = 13
        Me.lblsearch.Text = "Search:"
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Goldenrod
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.ForeColor = System.Drawing.Color.Gold
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(585, 283)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(249, 31)
        Me.cmbCategory.TabIndex = 16
        '
        'lblfilter
        '
        Me.lblfilter.AutoSize = True
        Me.lblfilter.BackColor = System.Drawing.Color.Transparent
        Me.lblfilter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfilter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblfilter.Location = New System.Drawing.Point(461, 278)
        Me.lblfilter.Name = "lblfilter"
        Me.lblfilter.Size = New System.Drawing.Size(81, 28)
        Me.lblfilter.TabIndex = 18
        Me.lblfilter.Text = "Filter:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1561, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 80)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Panel_Sidebar3
        '
        Me.Panel_Sidebar3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel_Sidebar3.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Sidebar3.BackgroundImage = CType(resources.GetObject("Panel_Sidebar3.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Sidebar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Return)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Borrows)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Logout)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_About)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_History)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Dashboard)
        Me.Panel_Sidebar3.Location = New System.Drawing.Point(3, 158)
        Me.Panel_Sidebar3.Name = "Panel_Sidebar3"
        Me.Panel_Sidebar3.Size = New System.Drawing.Size(10, 802)
        Me.Panel_Sidebar3.TabIndex = 14
        '
        'Btn_Nav_Return
        '
        Me.Btn_Nav_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Return.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Nav_Return.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Return.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Return.Location = New System.Drawing.Point(3, 335)
        Me.Btn_Nav_Return.Name = "Btn_Nav_Return"
        Me.Btn_Nav_Return.Size = New System.Drawing.Size(253, 38)
        Me.Btn_Nav_Return.TabIndex = 12
        Me.Btn_Nav_Return.Text = "↩ RETURN BOOK"
        Me.Btn_Nav_Return.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Return.UseVisualStyleBackColor = True
        '
        'Btn_Nav_Borrows
        '
        Me.Btn_Nav_Borrows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Borrows.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Nav_Borrows.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Borrows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Borrows.Location = New System.Drawing.Point(3, 265)
        Me.Btn_Nav_Borrows.Name = "Btn_Nav_Borrows"
        Me.Btn_Nav_Borrows.Size = New System.Drawing.Size(253, 38)
        Me.Btn_Nav_Borrows.TabIndex = 12
        Me.Btn_Nav_Borrows.Text = "🛒 BORROWS"
        Me.Btn_Nav_Borrows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Borrows.UseVisualStyleBackColor = True
        '
        'Btn_Nav_Logout
        '
        Me.Btn_Nav_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Logout.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Nav_Logout.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Logout.Location = New System.Drawing.Point(3, 476)
        Me.Btn_Nav_Logout.Name = "Btn_Nav_Logout"
        Me.Btn_Nav_Logout.Size = New System.Drawing.Size(209, 40)
        Me.Btn_Nav_Logout.TabIndex = 11
        Me.Btn_Nav_Logout.Text = "🚪LOGOUT"
        Me.Btn_Nav_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Logout.UseVisualStyleBackColor = True
        '
        'Btn_Nav_About
        '
        Me.Btn_Nav_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_About.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Nav_About.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_About.Location = New System.Drawing.Point(3, 401)
        Me.Btn_Nav_About.Name = "Btn_Nav_About"
        Me.Btn_Nav_About.Size = New System.Drawing.Size(209, 40)
        Me.Btn_Nav_About.TabIndex = 12
        Me.Btn_Nav_About.Text = "ℹ️ ABOUT"
        Me.Btn_Nav_About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_About.UseVisualStyleBackColor = True
        '
        'Btn_Nav_History
        '
        Me.Btn_Nav_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_History.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Nav_History.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_History.Location = New System.Drawing.Point(3, 147)
        Me.Btn_Nav_History.Name = "Btn_Nav_History"
        Me.Btn_Nav_History.Size = New System.Drawing.Size(268, 88)
        Me.Btn_Nav_History.TabIndex = 12
        Me.Btn_Nav_History.Text = "📜 BORROW HISTORY"
        Me.Btn_Nav_History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_History.UseVisualStyleBackColor = True
        '
        'Btn_Nav_Dashboard
        '
        Me.Btn_Nav_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Nav_Dashboard.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Nav_Dashboard.ForeColor = System.Drawing.Color.White
        Me.Btn_Nav_Dashboard.Location = New System.Drawing.Point(3, 79)
        Me.Btn_Nav_Dashboard.Name = "Btn_Nav_Dashboard"
        Me.Btn_Nav_Dashboard.Size = New System.Drawing.Size(268, 41)
        Me.Btn_Nav_Dashboard.TabIndex = 9
        Me.Btn_Nav_Dashboard.Text = "🏠 DASHBOARD"
        Me.Btn_Nav_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Dashboard.UseVisualStyleBackColor = True
        '
        'lblbooks
        '
        Me.lblbooks.AutoSize = True
        Me.lblbooks.BackColor = System.Drawing.Color.Transparent
        Me.lblbooks.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbooks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblbooks.Location = New System.Drawing.Point(370, 322)
        Me.lblbooks.Name = "lblbooks"
        Me.lblbooks.Size = New System.Drawing.Size(115, 34)
        Me.lblbooks.TabIndex = 20
        Me.lblbooks.Text = "Books:"
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.Gold
        Me.txtsearch.Location = New System.Drawing.Point(6, 7)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(685, 34)
        Me.txtsearch.TabIndex = 14
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.txtsearch)
        Me.pnlSearch.Location = New System.Drawing.Point(564, 197)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(700, 55)
        Me.pnlSearch.TabIndex = 21
        '
        'Btn_toggle
        '
        Me.Btn_toggle.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_toggle.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_toggle.ForeColor = System.Drawing.Color.Black
        Me.Btn_toggle.Location = New System.Drawing.Point(6, 73)
        Me.Btn_toggle.Name = "Btn_toggle"
        Me.Btn_toggle.Size = New System.Drawing.Size(70, 70)
        Me.Btn_toggle.TabIndex = 22
        Me.Btn_toggle.Tag = "9"
        Me.Btn_toggle.Text = "☰"
        Me.Btn_toggle.UseVisualStyleBackColor = False
        '
        'Timer_Sidebar
        '
        Me.Timer_Sidebar.Interval = 15
        '
        'Panel_Header
        '
        Me.Panel_Header.BackgroundImage = CType(resources.GetObject("Panel_Header.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Header.Controls.Add(Me.Btn_toggle)
        Me.Panel_Header.Controls.Add(Me.lblBook)
        Me.Panel_Header.Controls.Add(Me.PictureBox1)
        Me.Panel_Header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(1924, 155)
        Me.Panel_Header.TabIndex = 23
        '
        'BookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 755)
        Me.Controls.Add(Me.pnlLBG)
        Me.Controls.Add(Me.Panel_Sidebar3)
        Me.Controls.Add(Me.Panel_Header)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.lblbooks)
        Me.Controls.Add(Me.lblfilter)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblsearch)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Name = "BookForm"
        Me.Text = "BookForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Sidebar3.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.Panel_Header.ResumeLayout(False)
        Me.Panel_Header.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBook As System.Windows.Forms.Label
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents pnlLBG As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblfilter As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_Sidebar3 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Nav_About As System.Windows.Forms.Button
    Friend WithEvents Btn_Nav_History As System.Windows.Forms.Button
    Friend WithEvents Btn_Nav_Dashboard As System.Windows.Forms.Button
    Friend WithEvents lblbooks As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Btn_toggle As System.Windows.Forms.Button
    Friend WithEvents Timer_Sidebar As System.Windows.Forms.Timer
    Friend WithEvents Panel_Header As System.Windows.Forms.Panel
    Friend WithEvents Btn_Nav_Borrows As System.Windows.Forms.Button
    Friend WithEvents Btn_Nav_Logout As System.Windows.Forms.Button
    Friend WithEvents Btn_Nav_Return As System.Windows.Forms.Button
End Class
