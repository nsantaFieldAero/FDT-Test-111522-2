<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEARR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewEARR))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkIncorpRedLineNo = New System.Windows.Forms.CheckBox()
        Me.chkIncorpRedLineYes = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDrawingReqForConformityNo = New System.Windows.Forms.CheckBox()
        Me.chkDrawingReqForConformityYes = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboEARRType = New System.Windows.Forms.ComboBox()
        Me.cboProgramName = New System.Windows.Forms.ComboBox()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.txtWorkOrder = New System.Windows.Forms.TextBox()
        Me.txtRequest = New System.Windows.Forms.TextBox()
        Me.dtEARRResponseDate = New System.Windows.Forms.DateTimePicker()
        Me.txtOriginatorName = New System.Windows.Forms.TextBox()
        Me.dtOriginatorDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSubmitEARR = New System.Windows.Forms.Button()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEARRNumber = New System.Windows.Forms.TextBox()
        Me.chkFabShop = New System.Windows.Forms.CheckBox()
        Me.txtEndItemType = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtEstCompletionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.btnRemoveDrawNum = New System.Windows.Forms.Button()
        Me.btnAddDrawNum = New System.Windows.Forms.Button()
        Me.btnBrowseDrawNum = New System.Windows.Forms.Button()
        Me.txtDrawNum = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsDrawingsOfEARR = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDrawingsOfEARR1 = New EngDesignTracking.dsDrawingsOfEARR()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEarr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRev = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDrawingsOfEARR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDrawingsOfEARR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1017, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fill out the information contained on this screen.  When you submit, the engineer" &
    "ing liaison will be notified based on the program selected below."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(350, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EARR Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(635, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Program Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "S/N:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Work Order.Step:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 380)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Request:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkIncorpRedLineNo)
        Me.GroupBox1.Controls.Add(Me.chkIncorpRedLineYes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 448)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox1.Size = New System.Drawing.Size(275, 62)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Incorporate Red Line Drawing?"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'chkIncorpRedLineNo
        '
        Me.chkIncorpRedLineNo.AutoSize = True
        Me.chkIncorpRedLineNo.Location = New System.Drawing.Point(138, 32)
        Me.chkIncorpRedLineNo.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkIncorpRedLineNo.Name = "chkIncorpRedLineNo"
        Me.chkIncorpRedLineNo.Size = New System.Drawing.Size(54, 24)
        Me.chkIncorpRedLineNo.TabIndex = 12
        Me.chkIncorpRedLineNo.Text = "N/A"
        Me.chkIncorpRedLineNo.UseVisualStyleBackColor = True
        '
        'chkIncorpRedLineYes
        '
        Me.chkIncorpRedLineYes.AutoSize = True
        Me.chkIncorpRedLineYes.Location = New System.Drawing.Point(22, 32)
        Me.chkIncorpRedLineYes.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkIncorpRedLineYes.Name = "chkIncorpRedLineYes"
        Me.chkIncorpRedLineYes.Size = New System.Drawing.Size(56, 24)
        Me.chkIncorpRedLineYes.TabIndex = 11
        Me.chkIncorpRedLineYes.Text = "Yes"
        Me.chkIncorpRedLineYes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkDrawingReqForConformityNo)
        Me.GroupBox2.Controls.Add(Me.chkDrawingReqForConformityYes)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(354, 448)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox2.Size = New System.Drawing.Size(275, 62)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Drawing Required For Conformity?"
        Me.GroupBox2.UseCompatibleTextRendering = True
        '
        'chkDrawingReqForConformityNo
        '
        Me.chkDrawingReqForConformityNo.AutoSize = True
        Me.chkDrawingReqForConformityNo.Location = New System.Drawing.Point(122, 32)
        Me.chkDrawingReqForConformityNo.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkDrawingReqForConformityNo.Name = "chkDrawingReqForConformityNo"
        Me.chkDrawingReqForConformityNo.Size = New System.Drawing.Size(48, 24)
        Me.chkDrawingReqForConformityNo.TabIndex = 14
        Me.chkDrawingReqForConformityNo.Text = "No"
        Me.chkDrawingReqForConformityNo.UseVisualStyleBackColor = True
        '
        'chkDrawingReqForConformityYes
        '
        Me.chkDrawingReqForConformityYes.AutoSize = True
        Me.chkDrawingReqForConformityYes.Location = New System.Drawing.Point(3, 32)
        Me.chkDrawingReqForConformityYes.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkDrawingReqForConformityYes.Name = "chkDrawingReqForConformityYes"
        Me.chkDrawingReqForConformityYes.Size = New System.Drawing.Size(56, 24)
        Me.chkDrawingReqForConformityYes.TabIndex = 13
        Me.chkDrawingReqForConformityYes.Text = "Yes"
        Me.chkDrawingReqForConformityYes.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 546)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "EARR Response Date:"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 511)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Originator Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(366, 517)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 20)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Originator Date:"
        '
        'cboEARRType
        '
        Me.cboEARRType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEARRType.FormattingEnabled = True
        Me.cboEARRType.Items.AddRange(New Object() {"Electrical", "Mechanical"})
        Me.cboEARRType.Location = New System.Drawing.Point(455, 97)
        Me.cboEARRType.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cboEARRType.Name = "cboEARRType"
        Me.cboEARRType.Size = New System.Drawing.Size(152, 28)
        Me.cboEARRType.TabIndex = 3
        '
        'cboProgramName
        '
        Me.cboProgramName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProgramName.FormattingEnabled = True
        Me.cboProgramName.Items.AddRange(New Object() {"Jaguar", "Sherpa", "QCTEST", "16033-CBP", "192181 – MIT ASTB", "Repetitive Sale", "16190 - CAE", "192303 - SCG", "2640 - Missionized Interior MMSA-C (G550)"})
        Me.cboProgramName.Location = New System.Drawing.Point(774, 97)
        Me.cboProgramName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cboProgramName.Name = "cboProgramName"
        Me.cboProgramName.Size = New System.Drawing.Size(182, 28)
        Me.cboProgramName.TabIndex = 4
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialNumber.Location = New System.Drawing.Point(76, 169)
        Me.txtSerialNumber.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(119, 26)
        Me.txtSerialNumber.TabIndex = 6
        '
        'txtWorkOrder
        '
        Me.txtWorkOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkOrder.Location = New System.Drawing.Point(329, 169)
        Me.txtWorkOrder.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtWorkOrder.Name = "txtWorkOrder"
        Me.txtWorkOrder.Size = New System.Drawing.Size(148, 26)
        Me.txtWorkOrder.TabIndex = 7
        '
        'txtRequest
        '
        Me.txtRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequest.Location = New System.Drawing.Point(100, 382)
        Me.txtRequest.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtRequest.MaxLength = 2000
        Me.txtRequest.Multiline = True
        Me.txtRequest.Name = "txtRequest"
        Me.txtRequest.Size = New System.Drawing.Size(994, 64)
        Me.txtRequest.TabIndex = 10
        '
        'dtEARRResponseDate
        '
        Me.dtEARRResponseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEARRResponseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEARRResponseDate.Location = New System.Drawing.Point(204, 549)
        Me.dtEARRResponseDate.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dtEARRResponseDate.Name = "dtEARRResponseDate"
        Me.dtEARRResponseDate.Size = New System.Drawing.Size(144, 26)
        Me.dtEARRResponseDate.TabIndex = 17
        Me.dtEARRResponseDate.Visible = False
        '
        'txtOriginatorName
        '
        Me.txtOriginatorName.Enabled = False
        Me.txtOriginatorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOriginatorName.Location = New System.Drawing.Point(158, 511)
        Me.txtOriginatorName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtOriginatorName.Name = "txtOriginatorName"
        Me.txtOriginatorName.Size = New System.Drawing.Size(160, 26)
        Me.txtOriginatorName.TabIndex = 15
        '
        'dtOriginatorDate
        '
        Me.dtOriginatorDate.Enabled = False
        Me.dtOriginatorDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtOriginatorDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtOriginatorDate.Location = New System.Drawing.Point(494, 515)
        Me.dtOriginatorDate.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dtOriginatorDate.Name = "dtOriginatorDate"
        Me.dtOriginatorDate.Size = New System.Drawing.Size(144, 26)
        Me.dtOriginatorDate.TabIndex = 16
        '
        'btnSubmitEARR
        '
        Me.btnSubmitEARR.Location = New System.Drawing.Point(965, 578)
        Me.btnSubmitEARR.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnSubmitEARR.Name = "btnSubmitEARR"
        Me.btnSubmitEARR.Size = New System.Drawing.Size(116, 39)
        Me.btnSubmitEARR.TabIndex = 23
        Me.btnSubmitEARR.Text = "Create EARR"
        Me.btnSubmitEARR.UseVisualStyleBackColor = True
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=EARR;Persist Security Info=True;U" &
    "ser ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(830, 578)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(116, 39)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 94)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 20)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "EARR Number:"
        '
        'txtEARRNumber
        '
        Me.txtEARRNumber.Enabled = False
        Me.txtEARRNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEARRNumber.Location = New System.Drawing.Point(137, 94)
        Me.txtEARRNumber.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtEARRNumber.Name = "txtEARRNumber"
        Me.txtEARRNumber.Size = New System.Drawing.Size(209, 26)
        Me.txtEARRNumber.TabIndex = 2
        '
        'chkFabShop
        '
        Me.chkFabShop.AutoSize = True
        Me.chkFabShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFabShop.Location = New System.Drawing.Point(28, 56)
        Me.chkFabShop.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkFabShop.Name = "chkFabShop"
        Me.chkFabShop.Size = New System.Drawing.Size(421, 24)
        Me.chkFabShop.TabIndex = 1
        Me.chkFabShop.Text = "Fab Shop EARR - Use for OKC only (Check box for yes)"
        Me.chkFabShop.UseVisualStyleBackColor = True
        '
        'txtEndItemType
        '
        Me.txtEndItemType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndItemType.Location = New System.Drawing.Point(137, 133)
        Me.txtEndItemType.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtEndItemType.Name = "txtEndItemType"
        Me.txtEndItemType.Size = New System.Drawing.Size(209, 26)
        Me.txtEndItemType.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 133)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 20)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "End Item Type:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(366, 549)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 20)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Est Completion Date:"
        Me.Label14.Visible = False
        '
        'dtEstCompletionDate
        '
        Me.dtEstCompletionDate.Enabled = False
        Me.dtEstCompletionDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEstCompletionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEstCompletionDate.Location = New System.Drawing.Point(540, 549)
        Me.dtEstCompletionDate.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dtEstCompletionDate.Name = "dtEstCompletionDate"
        Me.dtEstCompletionDate.Size = New System.Drawing.Size(144, 26)
        Me.dtEstCompletionDate.TabIndex = 31
        Me.dtEstCompletionDate.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 586)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 20)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Comments:"
        Me.Label15.Visible = False
        '
        'txtComments
        '
        Me.txtComments.Enabled = False
        Me.txtComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.Location = New System.Drawing.Point(118, 586)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(569, 26)
        Me.txtComments.TabIndex = 33
        Me.txtComments.Visible = False
        '
        'btnRemoveDrawNum
        '
        Me.btnRemoveDrawNum.Location = New System.Drawing.Point(969, 326)
        Me.btnRemoveDrawNum.Name = "btnRemoveDrawNum"
        Me.btnRemoveDrawNum.Size = New System.Drawing.Size(139, 39)
        Me.btnRemoveDrawNum.TabIndex = 60
        Me.btnRemoveDrawNum.Text = "Remove Drawing Number"
        Me.btnRemoveDrawNum.UseVisualStyleBackColor = True
        '
        'btnAddDrawNum
        '
        Me.btnAddDrawNum.Location = New System.Drawing.Point(970, 282)
        Me.btnAddDrawNum.Name = "btnAddDrawNum"
        Me.btnAddDrawNum.Size = New System.Drawing.Size(139, 38)
        Me.btnAddDrawNum.TabIndex = 59
        Me.btnAddDrawNum.Text = "Add Drawing Number"
        Me.btnAddDrawNum.UseVisualStyleBackColor = True
        '
        'btnBrowseDrawNum
        '
        Me.btnBrowseDrawNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseDrawNum.Location = New System.Drawing.Point(969, 233)
        Me.btnBrowseDrawNum.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowseDrawNum.Name = "btnBrowseDrawNum"
        Me.btnBrowseDrawNum.Size = New System.Drawing.Size(139, 44)
        Me.btnBrowseDrawNum.TabIndex = 58
        Me.btnBrowseDrawNum.Text = "Browse"
        Me.btnBrowseDrawNum.UseVisualStyleBackColor = True
        '
        'txtDrawNum
        '
        Me.txtDrawNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrawNum.Location = New System.Drawing.Point(969, 208)
        Me.txtDrawNum.Name = "txtDrawNum"
        Me.txtDrawNum.ReadOnly = True
        Me.txtDrawNum.Size = New System.Drawing.Size(139, 20)
        Me.txtDrawNum.TabIndex = 57
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 208)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(131, 20)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "Drawing Number:"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsDrawingsOfEARR
        Me.GridControl1.Location = New System.Drawing.Point(137, 208)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(826, 157)
        Me.GridControl1.TabIndex = 61
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsDrawingsOfEARR
        '
        Me.bsDrawingsOfEARR.DataMember = "tblDrawingsOfEARR"
        Me.bsDrawingsOfEARR.DataSource = Me.DsDrawingsOfEARR1
        '
        'DsDrawingsOfEARR1
        '
        Me.DsDrawingsOfEARR1.DataSetName = "dsDrawingsOfEARR"
        Me.DsDrawingsOfEARR1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colEarr, Me.colDrawNum, Me.colRev})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.Name = "colRecordID"
        '
        'colEarr
        '
        Me.colEarr.FieldName = "Earr"
        Me.colEarr.Name = "colEarr"
        '
        'colDrawNum
        '
        Me.colDrawNum.FieldName = "DrawNum"
        Me.colDrawNum.Name = "colDrawNum"
        Me.colDrawNum.Visible = True
        Me.colDrawNum.VisibleIndex = 0
        '
        'colRev
        '
        Me.colRev.FieldName = "Rev"
        Me.colRev.Name = "colRev"
        Me.colRev.Visible = True
        Me.colRev.VisibleIndex = 1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        RecordID, Earr, DrawNum, Rev" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblDrawingsOfEARR"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [tblDrawingsOfEARR] ([Earr], [DrawNum], [Rev]) VALUES (@Earr, @DrawNu" &
    "m, @Rev);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT RecordID, Earr, DrawNum, Rev FROM tblDrawingsOfEARR WHERE (Rec" &
    "ordID = SCOPE_IDENTITY())"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection2
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Earr", System.Data.SqlDbType.NVarChar, 0, "Earr"), New System.Data.SqlClient.SqlParameter("@DrawNum", System.Data.SqlDbType.NVarChar, 0, "DrawNum"), New System.Data.SqlClient.SqlParameter("@Rev", System.Data.SqlDbType.NVarChar, 0, "Rev")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Earr", System.Data.SqlDbType.NVarChar, 0, "Earr"), New System.Data.SqlClient.SqlParameter("@DrawNum", System.Data.SqlDbType.NVarChar, 0, "DrawNum"), New System.Data.SqlClient.SqlParameter("@Rev", System.Data.SqlDbType.NVarChar, 0, "Rev"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Earr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Earr", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Earr", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Earr", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Rev", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Rev", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Rev", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Rev", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Earr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Earr", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Earr", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Earr", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Rev", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Rev", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Rev", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Rev", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawingsOfEARR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("Earr", "Earr"), New System.Data.Common.DataColumnMapping("DrawNum", "DrawNum"), New System.Data.Common.DataColumnMapping("Rev", "Rev")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'NewEARR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 617)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btnRemoveDrawNum)
        Me.Controls.Add(Me.btnAddDrawNum)
        Me.Controls.Add(Me.btnBrowseDrawNum)
        Me.Controls.Add(Me.txtDrawNum)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtEstCompletionDate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtEndItemType)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chkFabShop)
        Me.Controls.Add(Me.txtEARRNumber)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmitEARR)
        Me.Controls.Add(Me.dtOriginatorDate)
        Me.Controls.Add(Me.txtOriginatorName)
        Me.Controls.Add(Me.dtEARRResponseDate)
        Me.Controls.Add(Me.txtRequest)
        Me.Controls.Add(Me.txtWorkOrder)
        Me.Controls.Add(Me.txtSerialNumber)
        Me.Controls.Add(Me.cboProgramName)
        Me.Controls.Add(Me.cboEARRType)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "NewEARR"
        Me.Text = "NewEARR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDrawingsOfEARR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDrawingsOfEARR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents chkIncorpRedLineNo As CheckBox
    Friend WithEvents chkIncorpRedLineYes As CheckBox
    Friend WithEvents chkDrawingReqForConformityNo As CheckBox
    Friend WithEvents chkDrawingReqForConformityYes As CheckBox
    Friend WithEvents cboEARRType As ComboBox
    Friend WithEvents cboProgramName As ComboBox
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents txtWorkOrder As TextBox
    Friend WithEvents txtRequest As TextBox
    Friend WithEvents dtEARRResponseDate As DateTimePicker
    Friend WithEvents txtOriginatorName As TextBox
    Friend WithEvents dtOriginatorDate As DateTimePicker
    Friend WithEvents btnSubmitEARR As Button
    Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEARRNumber As TextBox
    Friend WithEvents chkFabShop As CheckBox
    Friend WithEvents txtEndItemType As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dtEstCompletionDate As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents txtComments As TextBox
    Friend WithEvents btnRemoveDrawNum As Button
    Friend WithEvents btnAddDrawNum As Button
    Friend WithEvents btnBrowseDrawNum As Button
    Friend WithEvents txtDrawNum As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsDrawingsOfEARR As BindingSource
    Friend WithEvents DsDrawingsOfEARR1 As dsDrawingsOfEARR
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEarr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
End Class
