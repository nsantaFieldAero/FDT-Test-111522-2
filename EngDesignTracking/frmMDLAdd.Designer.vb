<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDLAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDLAdd))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAddProjects = New System.Windows.Forms.Label()
        Me.txtMDLNumber = New System.Windows.Forms.TextBox()
        Me.txtMDLTitle = New System.Windows.Forms.TextBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet311 = New EngDesignTracking.DataSet31()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.cboProgram = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboProgramAdd = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboSystem = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboSystemAdd = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddProjectSystem = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPriority = New System.Windows.Forms.ComboBox()
        Me.lblAddMilestones = New System.Windows.Forms.Label()
        Me.cboAdditionalMilestones = New System.Windows.Forms.ComboBox()
        Me.btnAddMilestones = New System.Windows.Forms.Button()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet361 = New EngDesignTracking.DataSet36()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLRecordID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMilestone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet311, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProgram.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProgramAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSystem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSystemAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet361, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MDL Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MDL Title:"
        '
        'lblAddProjects
        '
        Me.lblAddProjects.AutoSize = True
        Me.lblAddProjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddProjects.Location = New System.Drawing.Point(14, 551)
        Me.lblAddProjects.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddProjects.Name = "lblAddProjects"
        Me.lblAddProjects.Size = New System.Drawing.Size(185, 20)
        Me.lblAddProjects.TabIndex = 3
        Me.lblAddProjects.Text = "Additional Programs:"
        Me.lblAddProjects.Visible = False
        '
        'txtMDLNumber
        '
        Me.txtMDLNumber.Location = New System.Drawing.Point(274, 103)
        Me.txtMDLNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMDLNumber.Name = "txtMDLNumber"
        Me.txtMDLNumber.Size = New System.Drawing.Size(295, 26)
        Me.txtMDLNumber.TabIndex = 5
        '
        'txtMDLTitle
        '
        Me.txtMDLTitle.Location = New System.Drawing.Point(274, 138)
        Me.txtMDLTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMDLTitle.Name = "txtMDLTitle"
        Me.txtMDLTitle.Size = New System.Drawing.Size(295, 26)
        Me.txtMDLTitle.TabIndex = 6
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.Location = New System.Drawing.Point(16, 594)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(876, 218)
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.GridControl1.Visible = False
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblLiveMDLProjectsSystems"
        Me.BindingSource1.DataSource = Me.DataSet311
        '
        'DataSet311
        '
        Me.DataSet311.DataSetName = "DataSet31"
        Me.DataSet311.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colMDLRecordID, Me.colMDLNumber, Me.colProgram, Me.colSystem})
        Me.GridView1.DetailHeight = 349
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.MinWidth = 30
        Me.colRecordID.Name = "colRecordID"
        '
        'colMDLRecordID
        '
        Me.colMDLRecordID.FieldName = "MDLRecordID"
        Me.colMDLRecordID.MinWidth = 30
        Me.colMDLRecordID.Name = "colMDLRecordID"
        '
        'colMDLNumber
        '
        Me.colMDLNumber.FieldName = "MDLNumber"
        Me.colMDLNumber.MinWidth = 30
        Me.colMDLNumber.Name = "colMDLNumber"
        '
        'colProgram
        '
        Me.colProgram.FieldName = "Program"
        Me.colProgram.MinWidth = 30
        Me.colProgram.Name = "colProgram"
        Me.colProgram.Visible = True
        Me.colProgram.VisibleIndex = 0
        '
        'colSystem
        '
        Me.colSystem.FieldName = "System"
        Me.colSystem.MinWidth = 30
        Me.colSystem.Name = "colSystem"
        Me.colSystem.Visible = True
        Me.colSystem.VisibleIndex = 1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'cboProgram
        '
        Me.cboProgram.Location = New System.Drawing.Point(274, 23)
        Me.cboProgram.Name = "cboProgram"
        Me.cboProgram.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProgram.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboProgram.Size = New System.Drawing.Size(296, 28)
        Me.cboProgram.TabIndex = 10
        '
        'cboProgramAdd
        '
        Me.cboProgramAdd.Location = New System.Drawing.Point(206, 546)
        Me.cboProgramAdd.Name = "cboProgramAdd"
        Me.cboProgramAdd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProgramAdd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboProgramAdd.Size = New System.Drawing.Size(296, 28)
        Me.cboProgramAdd.TabIndex = 11
        Me.cboProgramAdd.Visible = False
        '
        'cboSystem
        '
        Me.cboSystem.Location = New System.Drawing.Point(662, 23)
        Me.cboSystem.Name = "cboSystem"
        Me.cboSystem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSystem.Size = New System.Drawing.Size(284, 28)
        Me.cboSystem.TabIndex = 12
        '
        'cboSystemAdd
        '
        Me.cboSystemAdd.Location = New System.Drawing.Point(597, 546)
        Me.cboSystemAdd.Name = "cboSystemAdd"
        Me.cboSystemAdd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSystemAdd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSystemAdd.Size = New System.Drawing.Size(284, 28)
        Me.cboSystemAdd.TabIndex = 13
        Me.cboSystemAdd.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(663, 126)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(171, 43)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAddProjectSystem
        '
        Me.btnAddProjectSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProjectSystem.Location = New System.Drawing.Point(900, 540)
        Me.btnAddProjectSystem.Name = "btnAddProjectSystem"
        Me.btnAddProjectSystem.Size = New System.Drawing.Size(186, 40)
        Me.btnAddProjectSystem.TabIndex = 15
        Me.btnAddProjectSystem.Text = "Add Project/System"
        Me.btnAddProjectSystem.UseVisualStyleBackColor = True
        Me.btnAddProjectSystem.Visible = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        tblLiveMDLProjectsSystems.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblLiveMDLProjectsSyst" &
    "ems"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [tblLiveMDLProjectsSystems] ([MDLRecordID], [MDLNumber], [Program], [" &
    "System]) VALUES (@MDLRecordID, @MDLNumber, @Program, @System)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MDLRecordID", System.Data.SqlDbType.Int, 0, "MDLRecordID"), New System.Data.SqlClient.SqlParameter("@MDLNumber", System.Data.SqlDbType.Int, 0, "MDLNumber"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@System", System.Data.SqlDbType.NVarChar, 0, "System")})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblLiveMDLProjectsSystems", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("MDLRecordID", "MDLRecordID"), New System.Data.Common.DataColumnMapping("MDLNumber", "MDLNumber"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("System", "System")})})
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(900, 860)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(186, 52)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Milestone:"
        '
        'cboPriority
        '
        Me.cboPriority.FormattingEnabled = True
        Me.cboPriority.Location = New System.Drawing.Point(274, 65)
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.Size = New System.Drawing.Size(295, 28)
        Me.cboPriority.TabIndex = 18
        '
        'lblAddMilestones
        '
        Me.lblAddMilestones.AutoSize = True
        Me.lblAddMilestones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddMilestones.Location = New System.Drawing.Point(14, 254)
        Me.lblAddMilestones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddMilestones.Name = "lblAddMilestones"
        Me.lblAddMilestones.Size = New System.Drawing.Size(195, 20)
        Me.lblAddMilestones.TabIndex = 19
        Me.lblAddMilestones.Text = "Additional Milestones:"
        Me.lblAddMilestones.Visible = False
        '
        'cboAdditionalMilestones
        '
        Me.cboAdditionalMilestones.FormattingEnabled = True
        Me.cboAdditionalMilestones.Location = New System.Drawing.Point(273, 242)
        Me.cboAdditionalMilestones.Name = "cboAdditionalMilestones"
        Me.cboAdditionalMilestones.Size = New System.Drawing.Size(295, 28)
        Me.cboAdditionalMilestones.TabIndex = 20
        Me.cboAdditionalMilestones.Visible = False
        '
        'btnAddMilestones
        '
        Me.btnAddMilestones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMilestones.Location = New System.Drawing.Point(663, 242)
        Me.btnAddMilestones.Name = "btnAddMilestones"
        Me.btnAddMilestones.Size = New System.Drawing.Size(186, 40)
        Me.btnAddMilestones.TabIndex = 21
        Me.btnAddMilestones.Text = "Add Project/System"
        Me.btnAddMilestones.UseVisualStyleBackColor = True
        Me.btnAddMilestones.Visible = False
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.BindingSource2
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridControl2.Location = New System.Drawing.Point(18, 311)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(876, 200)
        Me.GridControl2.TabIndex = 22
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.GridControl2.Visible = False
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "tblLiveMDLMilestone"
        Me.BindingSource2.DataSource = Me.DataSet361
        '
        'DataSet361
        '
        Me.DataSet361.DataSetName = "DataSet36"
        Me.DataSet361.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID1, Me.colMDLRecordID1, Me.colMDLNumber1, Me.colMilestone})
        Me.GridView2.DetailHeight = 538
        Me.GridView2.FixedLineWidth = 3
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'colRecordID1
        '
        Me.colRecordID1.FieldName = "RecordID"
        Me.colRecordID1.MinWidth = 30
        Me.colRecordID1.Name = "colRecordID1"
        Me.colRecordID1.Width = 112
        '
        'colMDLRecordID1
        '
        Me.colMDLRecordID1.FieldName = "MDLRecordID"
        Me.colMDLRecordID1.MinWidth = 30
        Me.colMDLRecordID1.Name = "colMDLRecordID1"
        Me.colMDLRecordID1.Width = 112
        '
        'colMDLNumber1
        '
        Me.colMDLNumber1.FieldName = "MDLNumber"
        Me.colMDLNumber1.MinWidth = 30
        Me.colMDLNumber1.Name = "colMDLNumber1"
        Me.colMDLNumber1.Width = 112
        '
        'colMilestone
        '
        Me.colMilestone.FieldName = "Milestone"
        Me.colMilestone.MinWidth = 30
        Me.colMilestone.Name = "colMilestone"
        Me.colMilestone.Visible = True
        Me.colMilestone.VisibleIndex = 0
        Me.colMilestone.Width = 112
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        tblLiveMDLMilestone.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblLiveMDLMilestone"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO [tblLiveMDLMilestone] ([MDLRecordID], [MDLNumber], [Milestone]) VALUE" &
    "S (@MDLRecordID, @MDLNumber, @Milestone)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MDLRecordID", System.Data.SqlDbType.Int, 0, "MDLRecordID"), New System.Data.SqlClient.SqlParameter("@MDLNumber", System.Data.SqlDbType.Int, 0, "MDLNumber"), New System.Data.SqlClient.SqlParameter("@Milestone", System.Data.SqlDbType.NVarChar, 0, "Milestone")})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblLiveMDLMilestone", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("MDLRecordID", "MDLRecordID"), New System.Data.Common.DataColumnMapping("MDLNumber", "MDLNumber"), New System.Data.Common.DataColumnMapping("Milestone", "Milestone")})})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(578, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "System:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(508, 551)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Systems:"
        Me.Label6.Visible = False
        '
        'frmMDLAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(1126, 931)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.btnAddMilestones)
        Me.Controls.Add(Me.cboAdditionalMilestones)
        Me.Controls.Add(Me.lblAddMilestones)
        Me.Controls.Add(Me.cboPriority)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddProjectSystem)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboSystemAdd)
        Me.Controls.Add(Me.cboSystem)
        Me.Controls.Add(Me.cboProgramAdd)
        Me.Controls.Add(Me.cboProgram)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtMDLTitle)
        Me.Controls.Add(Me.txtMDLNumber)
        Me.Controls.Add(Me.lblAddProjects)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMDLAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMDLAdd"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet311, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProgram.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProgramAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSystem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSystemAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet361, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAddProjects As Label
    Friend WithEvents txtMDLNumber As TextBox
    Friend WithEvents txtMDLTitle As TextBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents cboProgram As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboProgramAdd As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboSystem As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboSystemAdd As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAddProjectSystem As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet311 As DataSet31
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents btnClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cboPriority As ComboBox
    Friend WithEvents lblAddMilestones As Label
    Friend WithEvents cboAdditionalMilestones As ComboBox
    Friend WithEvents btnAddMilestones As Button
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents DataSet361 As DataSet36
    Friend WithEvents colRecordID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLRecordID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLNumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMilestone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As SqlClient.SqlDataAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
