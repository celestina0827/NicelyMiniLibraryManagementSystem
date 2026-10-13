<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentForm))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlGoldLine = New System.Windows.Forms.Panel()
        Me.lblDashboardTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnBorrowHistory = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlHeader.BackgroundImage = CType(resources.GetObject("pnlHeader.BackgroundImage"), System.Drawing.Image)
        Me.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlHeader.Controls.Add(Me.PictureBox1)
        Me.pnlHeader.Controls.Add(Me.pnlGoldLine)
        Me.pnlHeader.Controls.Add(Me.lblDashboardTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1702, 155)
        Me.pnlHeader.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1577, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 80)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'pnlGoldLine
        '
        Me.pnlGoldLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlGoldLine.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlGoldLine.Location = New System.Drawing.Point(0, 153)
        Me.pnlGoldLine.Name = "pnlGoldLine"
        Me.pnlGoldLine.Size = New System.Drawing.Size(1702, 2)
        Me.pnlGoldLine.TabIndex = 1
        '
        'lblDashboardTitle
        '
        Me.lblDashboardTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDashboardTitle.Font = New System.Drawing.Font("Georgia", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblDashboardTitle.Location = New System.Drawing.Point(719, 60)
        Me.lblDashboardTitle.Name = "lblDashboardTitle"
        Me.lblDashboardTitle.Size = New System.Drawing.Size(700, 56)
        Me.lblDashboardTitle.TabIndex = 0
        Me.lblDashboardTitle.Text = "STUDENT DASHBOARD"
        Me.lblDashboardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Black
        Me.lblWelcome.Location = New System.Drawing.Point(738, 175)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(600, 42)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome, Student"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudentID
        '
        Me.lblStudentID.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblStudentID.Location = New System.Drawing.Point(850, 233)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(400, 28)
        Me.lblStudentID.TabIndex = 2
        Me.lblStudentID.Text = "Student ID: 001"
        Me.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBooks
        '
        Me.btnBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBooks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnBooks.FlatAppearance.BorderSize = 2
        Me.btnBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnBooks.Image = CType(resources.GetObject("btnBooks.Image"), System.Drawing.Image)
        Me.btnBooks.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBooks.Location = New System.Drawing.Point(353, 328)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(300, 136)
        Me.btnBooks.TabIndex = 3
        Me.btnBooks.Text = "BOOKS"
        Me.btnBooks.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBooks.UseVisualStyleBackColor = False
        '
        'btnBorrow
        '
        Me.btnBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnBorrow.FlatAppearance.BorderSize = 2
        Me.btnBorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrow.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnBorrow.Image = CType(resources.GetObject("btnBorrow.Image"), System.Drawing.Image)
        Me.btnBorrow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrow.Location = New System.Drawing.Point(855, 328)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(300, 136)
        Me.btnBorrow.TabIndex = 6
        Me.btnBorrow.Text = "BORROW"
        Me.btnBorrow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBorrow.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnReturn.FlatAppearance.BorderSize = 2
        Me.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnReturn.Image = CType(resources.GetObject("btnReturn.Image"), System.Drawing.Image)
        Me.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReturn.Location = New System.Drawing.Point(1389, 328)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(300, 136)
        Me.btnReturn.TabIndex = 7
        Me.btnReturn.Text = "RETURN"
        Me.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnBorrowHistory
        '
        Me.btnBorrowHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnBorrowHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrowHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnBorrowHistory.FlatAppearance.BorderSize = 2
        Me.btnBorrowHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnBorrowHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnBorrowHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowHistory.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnBorrowHistory.Image = CType(resources.GetObject("btnBorrowHistory.Image"), System.Drawing.Image)
        Me.btnBorrowHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrowHistory.Location = New System.Drawing.Point(365, 614)
        Me.btnBorrowHistory.Name = "btnBorrowHistory"
        Me.btnBorrowHistory.Size = New System.Drawing.Size(300, 136)
        Me.btnBorrowHistory.TabIndex = 8
        Me.btnBorrowHistory.Text = "BORROW HISTORY"
        Me.btnBorrowHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrowHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBorrowHistory.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnAbout.FlatAppearance.BorderSize = 2
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAbout.Location = New System.Drawing.Point(855, 614)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(300, 136)
        Me.btnAbout.TabIndex = 9
        Me.btnAbout.Text = "ABOUT"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 2
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogout.Location = New System.Drawing.Point(1389, 614)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(300, 136)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1702, 859)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnBorrowHistory)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnBooks)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nicely Mini Library - Student Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlGoldLine As System.Windows.Forms.Panel
    Friend WithEvents lblDashboardTitle As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblStudentID As System.Windows.Forms.Label
    Friend WithEvents btnBooks As System.Windows.Forms.Button
    Friend WithEvents btnBorrow As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnBorrowHistory As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
