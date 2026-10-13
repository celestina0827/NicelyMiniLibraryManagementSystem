<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BorrowHistoryForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowHistoryForm))
        Me.Timer_Sidebar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Card = New System.Windows.Forms.Panel()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtStuID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Detail = New System.Windows.Forms.Panel()
        Me.txtNotesRemarks = New System.Windows.Forms.TextBox()
        Me.lblNotesHeader = New System.Windows.Forms.Label()
        Me.lblConditionValue = New System.Windows.Forms.Label()
        Me.lblScribblingValue = New System.Windows.Forms.Label()
        Me.lblPagesIntactValue = New System.Windows.Forms.Label()
        Me.lblCoverIntactValue = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblChecklistHeader = New System.Windows.Forms.Label()
        Me.lblOverdueDaysValue = New System.Windows.Forms.Label()
        Me.lblReturnDateValue = New System.Windows.Forms.Label()
        Me.lblDueDateValue = New System.Windows.Forms.Label()
        Me.lblBorrowDateValue = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTimeTrailHeader = New System.Windows.Forms.Label()
        Me.lblStatusValue = New System.Windows.Forms.Label()
        Me.lblBookTitleValue = New System.Windows.Forms.Label()
        Me.lblStudentNameValue = New System.Windows.Forms.Label()
        Me.lblBorrowIDValue = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblInspectionTitle = New System.Windows.Forms.Label()
        Me.dgvBorrowHistory = New System.Windows.Forms.DataGridView()
        Me.borrow_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stu_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrow_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.return_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Btn_Toggle = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_Sidebar3 = New System.Windows.Forms.Panel()
        Me.Btn_Nav_Logout = New System.Windows.Forms.Button()
        Me.Btn_Nav_About = New System.Windows.Forms.Button()
        Me.Btn_Nav_Return = New System.Windows.Forms.Button()
        Me.Btn_Nav_Dashboard = New System.Windows.Forms.Button()
        Me.Btn_Nav_Books = New System.Windows.Forms.Button()
        Me.Btn_Nav_Borrows = New System.Windows.Forms.Button()
        Me.Panel_Card.SuspendLayout()
        Me.Panel_Detail.SuspendLayout()
        CType(Me.dgvBorrowHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Header.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Sidebar3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_Sidebar
        '
        '
        'Panel_Card
        '
        Me.Panel_Card.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Card.BackgroundImage = Global.Nicely_Mini_Library_System.My.Resources.Resources.white_marble
        Me.Panel_Card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Card.Controls.Add(Me.Label1)
        Me.Panel_Card.Controls.Add(Me.btnFind)
        Me.Panel_Card.Controls.Add(Me.cmbStatus)
        Me.Panel_Card.Controls.Add(Me.lblStatus)
        Me.Panel_Card.Controls.Add(Me.txtStuID)
        Me.Panel_Card.Controls.Add(Me.Panel_Detail)
        Me.Panel_Card.Controls.Add(Me.dgvBorrowHistory)
        Me.Panel_Card.Location = New System.Drawing.Point(15, 115)
        Me.Panel_Card.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Card.Name = "Panel_Card"
        Me.Panel_Card.Size = New System.Drawing.Size(1534, 796)
        Me.Panel_Card.TabIndex = 9
        '
        'btnFind
        '
        Me.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnFind.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Location = New System.Drawing.Point(1038, 25)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(144, 32)
        Me.btnFind.TabIndex = 4
        Me.btnFind.Text = "FIND"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"All", "Borrowed", "Returned", "Overdue"})
        Me.cmbStatus.Location = New System.Drawing.Point(693, 27)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(271, 33)
        Me.cmbStatus.TabIndex = 3
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.Location = New System.Drawing.Point(602, 29)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(77, 25)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "Status :"
        '
        'txtStuID
        '
        Me.txtStuID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtStuID.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStuID.Location = New System.Drawing.Point(303, 27)
        Me.txtStuID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStuID.Name = "txtStuID"
        Me.txtStuID.Size = New System.Drawing.Size(243, 32)
        Me.txtStuID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(183, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID :"
        '
        'Panel_Detail
        '
        Me.Panel_Detail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Panel_Detail.Controls.Add(Me.txtNotesRemarks)
        Me.Panel_Detail.Controls.Add(Me.lblNotesHeader)
        Me.Panel_Detail.Controls.Add(Me.lblConditionValue)
        Me.Panel_Detail.Controls.Add(Me.lblScribblingValue)
        Me.Panel_Detail.Controls.Add(Me.lblPagesIntactValue)
        Me.Panel_Detail.Controls.Add(Me.lblCoverIntactValue)
        Me.Panel_Detail.Controls.Add(Me.Label15)
        Me.Panel_Detail.Controls.Add(Me.Label14)
        Me.Panel_Detail.Controls.Add(Me.Label13)
        Me.Panel_Detail.Controls.Add(Me.Label12)
        Me.Panel_Detail.Controls.Add(Me.lblChecklistHeader)
        Me.Panel_Detail.Controls.Add(Me.lblOverdueDaysValue)
        Me.Panel_Detail.Controls.Add(Me.lblReturnDateValue)
        Me.Panel_Detail.Controls.Add(Me.lblDueDateValue)
        Me.Panel_Detail.Controls.Add(Me.lblBorrowDateValue)
        Me.Panel_Detail.Controls.Add(Me.Label10)
        Me.Panel_Detail.Controls.Add(Me.Label9)
        Me.Panel_Detail.Controls.Add(Me.Label8)
        Me.Panel_Detail.Controls.Add(Me.Label2)
        Me.Panel_Detail.Controls.Add(Me.lblTimeTrailHeader)
        Me.Panel_Detail.Controls.Add(Me.lblStatusValue)
        Me.Panel_Detail.Controls.Add(Me.lblBookTitleValue)
        Me.Panel_Detail.Controls.Add(Me.lblStudentNameValue)
        Me.Panel_Detail.Controls.Add(Me.lblBorrowIDValue)
        Me.Panel_Detail.Controls.Add(Me.Label5)
        Me.Panel_Detail.Controls.Add(Me.Label6)
        Me.Panel_Detail.Controls.Add(Me.Label7)
        Me.Panel_Detail.Controls.Add(Me.Label4)
        Me.Panel_Detail.Controls.Add(Me.lblInspectionTitle)
        Me.Panel_Detail.Location = New System.Drawing.Point(31, 419)
        Me.Panel_Detail.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Detail.Name = "Panel_Detail"
        Me.Panel_Detail.Size = New System.Drawing.Size(1474, 304)
        Me.Panel_Detail.TabIndex = 6
        '
        'txtNotesRemarks
        '
        Me.txtNotesRemarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotesRemarks.BackColor = System.Drawing.Color.Gray
        Me.txtNotesRemarks.ForeColor = System.Drawing.SystemColors.Info
        Me.txtNotesRemarks.Location = New System.Drawing.Point(1107, 80)
        Me.txtNotesRemarks.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNotesRemarks.Multiline = True
        Me.txtNotesRemarks.Name = "txtNotesRemarks"
        Me.txtNotesRemarks.ReadOnly = True
        Me.txtNotesRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotesRemarks.Size = New System.Drawing.Size(342, 153)
        Me.txtNotesRemarks.TabIndex = 28
        '
        'lblNotesHeader
        '
        Me.lblNotesHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotesHeader.AutoSize = True
        Me.lblNotesHeader.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblNotesHeader.ForeColor = System.Drawing.Color.Gold
        Me.lblNotesHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNotesHeader.Location = New System.Drawing.Point(1103, 29)
        Me.lblNotesHeader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNotesHeader.Name = "lblNotesHeader"
        Me.lblNotesHeader.Size = New System.Drawing.Size(197, 25)
        Me.lblNotesHeader.TabIndex = 27
        Me.lblNotesHeader.Text = "📝 NOTES & REMARKS"
        '
        'lblConditionValue
        '
        Me.lblConditionValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConditionValue.AutoSize = True
        Me.lblConditionValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConditionValue.ForeColor = System.Drawing.Color.Gold
        Me.lblConditionValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblConditionValue.Location = New System.Drawing.Point(888, 200)
        Me.lblConditionValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConditionValue.Name = "lblConditionValue"
        Me.lblConditionValue.Size = New System.Drawing.Size(31, 23)
        Me.lblConditionValue.TabIndex = 26
        Me.lblConditionValue.Text = "---"
        '
        'lblScribblingValue
        '
        Me.lblScribblingValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblScribblingValue.AutoSize = True
        Me.lblScribblingValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScribblingValue.ForeColor = System.Drawing.Color.Gold
        Me.lblScribblingValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblScribblingValue.Location = New System.Drawing.Point(888, 159)
        Me.lblScribblingValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblScribblingValue.Name = "lblScribblingValue"
        Me.lblScribblingValue.Size = New System.Drawing.Size(31, 23)
        Me.lblScribblingValue.TabIndex = 25
        Me.lblScribblingValue.Text = "---"
        '
        'lblPagesIntactValue
        '
        Me.lblPagesIntactValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPagesIntactValue.AutoSize = True
        Me.lblPagesIntactValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagesIntactValue.ForeColor = System.Drawing.Color.Gold
        Me.lblPagesIntactValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPagesIntactValue.Location = New System.Drawing.Point(888, 119)
        Me.lblPagesIntactValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPagesIntactValue.Name = "lblPagesIntactValue"
        Me.lblPagesIntactValue.Size = New System.Drawing.Size(31, 23)
        Me.lblPagesIntactValue.TabIndex = 24
        Me.lblPagesIntactValue.Text = "---"
        '
        'lblCoverIntactValue
        '
        Me.lblCoverIntactValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCoverIntactValue.AutoSize = True
        Me.lblCoverIntactValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoverIntactValue.ForeColor = System.Drawing.Color.Gold
        Me.lblCoverIntactValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCoverIntactValue.Location = New System.Drawing.Point(888, 80)
        Me.lblCoverIntactValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCoverIntactValue.Name = "lblCoverIntactValue"
        Me.lblCoverIntactValue.Size = New System.Drawing.Size(31, 23)
        Me.lblCoverIntactValue.TabIndex = 23
        Me.lblCoverIntactValue.Text = "---"
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gold
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Location = New System.Drawing.Point(719, 200)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 23)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "[★] Condition :"
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gold
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Location = New System.Drawing.Point(719, 159)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 23)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "[✓] Scribbling :"
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gold
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.Location = New System.Drawing.Point(719, 119)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 23)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "[✓] Pages Intact :"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gold
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(719, 80)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 23)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "[✓] Cover Intact :"
        '
        'lblChecklistHeader
        '
        Me.lblChecklistHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChecklistHeader.AutoSize = True
        Me.lblChecklistHeader.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblChecklistHeader.ForeColor = System.Drawing.Color.Gold
        Me.lblChecklistHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblChecklistHeader.Location = New System.Drawing.Point(697, 29)
        Me.lblChecklistHeader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChecklistHeader.Name = "lblChecklistHeader"
        Me.lblChecklistHeader.Size = New System.Drawing.Size(138, 25)
        Me.lblChecklistHeader.TabIndex = 18
        Me.lblChecklistHeader.Text = "🔍 CHECKLIST"
        '
        'lblOverdueDaysValue
        '
        Me.lblOverdueDaysValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOverdueDaysValue.AutoSize = True
        Me.lblOverdueDaysValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverdueDaysValue.ForeColor = System.Drawing.Color.Gold
        Me.lblOverdueDaysValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOverdueDaysValue.Location = New System.Drawing.Point(537, 200)
        Me.lblOverdueDaysValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOverdueDaysValue.Name = "lblOverdueDaysValue"
        Me.lblOverdueDaysValue.Size = New System.Drawing.Size(31, 23)
        Me.lblOverdueDaysValue.TabIndex = 17
        Me.lblOverdueDaysValue.Text = "---"
        '
        'lblReturnDateValue
        '
        Me.lblReturnDateValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReturnDateValue.AutoSize = True
        Me.lblReturnDateValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnDateValue.ForeColor = System.Drawing.Color.Gold
        Me.lblReturnDateValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblReturnDateValue.Location = New System.Drawing.Point(537, 159)
        Me.lblReturnDateValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReturnDateValue.Name = "lblReturnDateValue"
        Me.lblReturnDateValue.Size = New System.Drawing.Size(31, 23)
        Me.lblReturnDateValue.TabIndex = 16
        Me.lblReturnDateValue.Text = "---"
        '
        'lblDueDateValue
        '
        Me.lblDueDateValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDueDateValue.AutoSize = True
        Me.lblDueDateValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDateValue.ForeColor = System.Drawing.Color.Gold
        Me.lblDueDateValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDueDateValue.Location = New System.Drawing.Point(537, 119)
        Me.lblDueDateValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDueDateValue.Name = "lblDueDateValue"
        Me.lblDueDateValue.Size = New System.Drawing.Size(31, 23)
        Me.lblDueDateValue.TabIndex = 15
        Me.lblDueDateValue.Text = "---"
        '
        'lblBorrowDateValue
        '
        Me.lblBorrowDateValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBorrowDateValue.AutoSize = True
        Me.lblBorrowDateValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowDateValue.ForeColor = System.Drawing.Color.Gold
        Me.lblBorrowDateValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBorrowDateValue.Location = New System.Drawing.Point(537, 80)
        Me.lblBorrowDateValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBorrowDateValue.Name = "lblBorrowDateValue"
        Me.lblBorrowDateValue.Size = New System.Drawing.Size(31, 23)
        Me.lblBorrowDateValue.TabIndex = 14
        Me.lblBorrowDateValue.Text = "---"
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(393, 80)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 23)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Borrow Date :"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(393, 119)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 23)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Due Date :"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(393, 159)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Return Date :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(393, 200)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Overdue Days :"
        '
        'lblTimeTrailHeader
        '
        Me.lblTimeTrailHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimeTrailHeader.AutoSize = True
        Me.lblTimeTrailHeader.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTimeTrailHeader.ForeColor = System.Drawing.Color.Gold
        Me.lblTimeTrailHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTimeTrailHeader.Location = New System.Drawing.Point(381, 29)
        Me.lblTimeTrailHeader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTimeTrailHeader.Name = "lblTimeTrailHeader"
        Me.lblTimeTrailHeader.Size = New System.Drawing.Size(141, 25)
        Me.lblTimeTrailHeader.TabIndex = 9
        Me.lblTimeTrailHeader.Text = "🕒 TIME TRAIL"
        '
        'lblStatusValue
        '
        Me.lblStatusValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatusValue.AutoSize = True
        Me.lblStatusValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusValue.ForeColor = System.Drawing.Color.Gold
        Me.lblStatusValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblStatusValue.Location = New System.Drawing.Point(179, 200)
        Me.lblStatusValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatusValue.Name = "lblStatusValue"
        Me.lblStatusValue.Size = New System.Drawing.Size(31, 23)
        Me.lblStatusValue.TabIndex = 8
        Me.lblStatusValue.Text = "---"
        '
        'lblBookTitleValue
        '
        Me.lblBookTitleValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBookTitleValue.AutoSize = True
        Me.lblBookTitleValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitleValue.ForeColor = System.Drawing.Color.Gold
        Me.lblBookTitleValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBookTitleValue.Location = New System.Drawing.Point(179, 159)
        Me.lblBookTitleValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookTitleValue.Name = "lblBookTitleValue"
        Me.lblBookTitleValue.Size = New System.Drawing.Size(31, 23)
        Me.lblBookTitleValue.TabIndex = 7
        Me.lblBookTitleValue.Text = "---"
        '
        'lblStudentNameValue
        '
        Me.lblStudentNameValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentNameValue.AutoSize = True
        Me.lblStudentNameValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNameValue.ForeColor = System.Drawing.Color.Gold
        Me.lblStudentNameValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblStudentNameValue.Location = New System.Drawing.Point(179, 119)
        Me.lblStudentNameValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentNameValue.Name = "lblStudentNameValue"
        Me.lblStudentNameValue.Size = New System.Drawing.Size(31, 23)
        Me.lblStudentNameValue.TabIndex = 6
        Me.lblStudentNameValue.Text = "---"
        '
        'lblBorrowIDValue
        '
        Me.lblBorrowIDValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBorrowIDValue.AutoSize = True
        Me.lblBorrowIDValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowIDValue.ForeColor = System.Drawing.Color.Gold
        Me.lblBorrowIDValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBorrowIDValue.Location = New System.Drawing.Point(179, 80)
        Me.lblBorrowIDValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBorrowIDValue.Name = "lblBorrowIDValue"
        Me.lblBorrowIDValue.Size = New System.Drawing.Size(31, 23)
        Me.lblBorrowIDValue.TabIndex = 5
        Me.lblBorrowIDValue.Text = "---"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(30, 119)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Student Name :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(30, 159)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Book Title : "
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(30, 200)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Status : "
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(30, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Borrow ID : "
        '
        'lblInspectionTitle
        '
        Me.lblInspectionTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInspectionTitle.AutoSize = True
        Me.lblInspectionTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblInspectionTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblInspectionTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblInspectionTitle.Location = New System.Drawing.Point(22, 29)
        Me.lblInspectionTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInspectionTitle.Name = "lblInspectionTitle"
        Me.lblInspectionTitle.Size = New System.Drawing.Size(305, 25)
        Me.lblInspectionTitle.TabIndex = 0
        Me.lblInspectionTitle.Text = "📋 INSPECTION AND TIME TRAIL"
        '
        'dgvBorrowHistory
        '
        Me.dgvBorrowHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBorrowHistory.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBorrowHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBorrowHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrowHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.borrow_ID, Me.stu_ID, Me.student_name, Me.book_title, Me.borrow_date, Me.due_date, Me.return_date, Me.status})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBorrowHistory.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBorrowHistory.EnableHeadersVisualStyles = False
        Me.dgvBorrowHistory.Location = New System.Drawing.Point(38, 91)
        Me.dgvBorrowHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvBorrowHistory.Name = "dgvBorrowHistory"
        Me.dgvBorrowHistory.RowHeadersWidth = 62
        Me.dgvBorrowHistory.RowTemplate.Height = 28
        Me.dgvBorrowHistory.Size = New System.Drawing.Size(1474, 292)
        Me.dgvBorrowHistory.TabIndex = 5
        '
        'borrow_ID
        '
        Me.borrow_ID.HeaderText = "Borrow ID"
        Me.borrow_ID.MinimumWidth = 8
        Me.borrow_ID.Name = "borrow_ID"
        Me.borrow_ID.Width = 190
        '
        'stu_ID
        '
        Me.stu_ID.HeaderText = "Student ID"
        Me.stu_ID.MinimumWidth = 8
        Me.stu_ID.Name = "stu_ID"
        Me.stu_ID.Width = 190
        '
        'student_name
        '
        Me.student_name.HeaderText = "Student Name"
        Me.student_name.MinimumWidth = 8
        Me.student_name.Name = "student_name"
        Me.student_name.Width = 200
        '
        'book_title
        '
        Me.book_title.HeaderText = "Book Title"
        Me.book_title.MinimumWidth = 8
        Me.book_title.Name = "book_title"
        Me.book_title.Width = 230
        '
        'borrow_date
        '
        Me.borrow_date.HeaderText = "Borrow Date"
        Me.borrow_date.MinimumWidth = 8
        Me.borrow_date.Name = "borrow_date"
        Me.borrow_date.Width = 200
        '
        'due_date
        '
        Me.due_date.HeaderText = "Due Date"
        Me.due_date.MinimumWidth = 8
        Me.due_date.Name = "due_date"
        Me.due_date.Width = 200
        '
        'return_date
        '
        Me.return_date.HeaderText = "Return Date"
        Me.return_date.MinimumWidth = 8
        Me.return_date.Name = "return_date"
        Me.return_date.Width = 200
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 8
        Me.status.Name = "status"
        Me.status.Width = 200
        '
        'Panel_Header
        '
        Me.Panel_Header.BackColor = System.Drawing.Color.Black
        Me.Panel_Header.BackgroundImage = Global.Nicely_Mini_Library_System.My.Resources.Resources.photo_2026_09_01_22_58_08
        Me.Panel_Header.Controls.Add(Me.PictureBox1)
        Me.Panel_Header.Controls.Add(Me.btnPrint)
        Me.Panel_Header.Controls.Add(Me.Btn_Toggle)
        Me.Panel_Header.Controls.Add(Me.Label3)
        Me.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Header.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(1527, 114)
        Me.Panel_Header.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1413, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(1405, 82)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(122, 32)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "🖨️ PRINT REPORT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Btn_Toggle
        '
        Me.Btn_Toggle.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Toggle.FlatAppearance.BorderSize = 0
        Me.Btn_Toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Toggle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Toggle.ForeColor = System.Drawing.Color.Black
        Me.Btn_Toggle.Location = New System.Drawing.Point(2, 53)
        Me.Btn_Toggle.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Toggle.Name = "Btn_Toggle"
        Me.Btn_Toggle.Size = New System.Drawing.Size(58, 58)
        Me.Btn_Toggle.TabIndex = 9
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
        Me.Label3.Location = New System.Drawing.Point(585, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(478, 49)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "BORROW HISTORY "
        '
        'Panel_Sidebar3
        '
        Me.Panel_Sidebar3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel_Sidebar3.BackgroundImage = Global.Nicely_Mini_Library_System.My.Resources.Resources.photo_2026_09_01_22_58_08
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Borrows)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Logout)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_About)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Return)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Dashboard)
        Me.Panel_Sidebar3.Controls.Add(Me.Btn_Nav_Books)
        Me.Panel_Sidebar3.Location = New System.Drawing.Point(1, 112)
        Me.Panel_Sidebar3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Sidebar3.Name = "Panel_Sidebar3"
        Me.Panel_Sidebar3.Size = New System.Drawing.Size(10, 817)
        Me.Panel_Sidebar3.TabIndex = 8
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
        Me.Btn_Nav_Logout.Location = New System.Drawing.Point(25, 350)
        Me.Btn_Nav_Logout.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_Logout.Name = "Btn_Nav_Logout"
        Me.Btn_Nav_Logout.Size = New System.Drawing.Size(209, 45)
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
        Me.Btn_Nav_About.Location = New System.Drawing.Point(25, 276)
        Me.Btn_Nav_About.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_About.Name = "Btn_Nav_About"
        Me.Btn_Nav_About.Size = New System.Drawing.Size(209, 45)
        Me.Btn_Nav_About.TabIndex = 15
        Me.Btn_Nav_About.Text = "ℹ️ ABOUT"
        Me.Btn_Nav_About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_About.UseVisualStyleBackColor = False
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
        Me.Btn_Nav_Return.Location = New System.Drawing.Point(25, 276)
        Me.Btn_Nav_Return.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Nav_Return.Name = "Btn_Nav_Return"
        Me.Btn_Nav_Return.Size = New System.Drawing.Size(286, 44)
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
        Me.Btn_Nav_Dashboard.Size = New System.Drawing.Size(270, 48)
        Me.Btn_Nav_Dashboard.TabIndex = 7
        Me.Btn_Nav_Dashboard.Text = "🏠 DASHBOARD"
        Me.Btn_Nav_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Dashboard.UseVisualStyleBackColor = False
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
        Me.Btn_Nav_Books.Size = New System.Drawing.Size(234, 41)
        Me.Btn_Nav_Books.TabIndex = 12
        Me.Btn_Nav_Books.Text = "📖 BOOKS"
        Me.Btn_Nav_Books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Books.UseVisualStyleBackColor = False
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
        Me.Btn_Nav_Borrows.TabIndex = 26
        Me.Btn_Nav_Borrows.Text = "🛒 BORROWS"
        Me.Btn_Nav_Borrows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Nav_Borrows.UseVisualStyleBackColor = False
        '
        'BorrowHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1527, 879)
        Me.Controls.Add(Me.Panel_Card)
        Me.Controls.Add(Me.Panel_Header)
        Me.Controls.Add(Me.Panel_Sidebar3)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(1463, 739)
        Me.Name = "BorrowHistoryForm"
        Me.Text = "BorrowHistoryForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Card.ResumeLayout(False)
        Me.Panel_Card.PerformLayout()
        Me.Panel_Detail.ResumeLayout(False)
        Me.Panel_Detail.PerformLayout()
        CType(Me.dgvBorrowHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Header.ResumeLayout(False)
        Me.Panel_Header.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Sidebar3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Header As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Toggle As Button
    Friend WithEvents Panel_Sidebar3 As Panel
    Friend WithEvents Btn_Nav_Logout As Button
    Friend WithEvents Btn_Nav_About As Button
    Friend WithEvents Btn_Nav_Books As Button
    Friend WithEvents Btn_Nav_Return As Button
    Friend WithEvents Btn_Nav_Dashboard As Button
    Friend WithEvents Panel_Card As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStuID As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbStatus As ComboBox

    Private Sub txtSearchStuID_TextChanged(sender As Object, e As EventArgs) Handles txtStuID.TextChanged

    End Sub

    Friend WithEvents btnPrint As Button
    Friend WithEvents Panel_Detail As Panel
    Friend WithEvents txtNotesRemarks As TextBox
    Friend WithEvents lblNotesHeader As Label
    Friend WithEvents lblConditionValue As Label
    Friend WithEvents lblScribblingValue As Label
    Friend WithEvents lblPagesIntactValue As Label
    Friend WithEvents lblCoverIntactValue As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblChecklistHeader As Label
    Friend WithEvents lblOverdueDaysValue As Label
    Friend WithEvents lblReturnDateValue As Label
    Friend WithEvents lblDueDateValue As Label
    Friend WithEvents lblBorrowDateValue As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTimeTrailHeader As Label
    Friend WithEvents lblStatusValue As Label
    Friend WithEvents lblBookTitleValue As Label
    Friend WithEvents lblStudentNameValue As Label
    Friend WithEvents lblBorrowIDValue As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblInspectionTitle As Label
    Friend WithEvents dgvBorrowHistory As DataGridView
    Friend WithEvents borrow_ID As DataGridViewTextBoxColumn
    Friend WithEvents stu_ID As DataGridViewTextBoxColumn
    Friend WithEvents student_name As DataGridViewTextBoxColumn
    Friend WithEvents book_title As DataGridViewTextBoxColumn
    Friend WithEvents borrow_date As DataGridViewTextBoxColumn
    Friend WithEvents due_date As DataGridViewTextBoxColumn
    Friend WithEvents return_date As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents btnFind As Button

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Card.Paint

    End Sub

    Friend WithEvents Timer_Sidebar As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Nav_Borrows As System.Windows.Forms.Button
End Class
