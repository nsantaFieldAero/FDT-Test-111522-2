<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDLChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDLChange))
        Me.btnAddMilestones = New System.Windows.Forms.Button()
        Me.cboAdditionalMilestones = New System.Windows.Forms.ComboBox()
        Me.lblAddMilestones = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAddProjectSystem = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboSystemAdd = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboProgramAdd = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtMDLTitle = New System.Windows.Forms.TextBox()
        Me.txtMDLNumber = New System.Windows.Forms.TextBox()
        Me.lblAddProjects = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet371 = New EngDesignTracking.DataSet37()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMilestone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet381 = New EngDesignTracking.DataSet38()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLRecordID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtMilestoneRecordId = New System.Windows.Forms.TextBox()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtProgramSystemRecordID = New System.Windows.Forms.TextBox()
        Me.btnDeleteMilestone = New System.Windows.Forms.Button()
        Me.btnDeleteProgramSystem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDocumentNumber = New System.Windows.Forms.TextBox()
        CType(Me.cboSystemAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProgramAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet371, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet381, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddMilestones
        '
        Me.btnAddMilestones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMilestones.Location = New System.Drawing.Point(606, 158)
        Me.btnAddMilestones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddMilestones.Name = "btnAddMilestones"
        Me.btnAddMilestones.Size = New System.Drawing.Size(165, 32)
        Me.btnAddMilestones.TabIndex = 34
        Me.btnAddMilestones.Text = "Add Milestone"
        Me.btnAddMilestones.UseVisualStyleBackColor = True
        '
        'cboAdditionalMilestones
        '
        Me.cboAdditionalMilestones.FormattingEnabled = True
        Me.cboAdditionalMilestones.Location = New System.Drawing.Point(260, 158)
        Me.cboAdditionalMilestones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboAdditionalMilestones.Name = "cboAdditionalMilestones"
        Me.cboAdditionalMilestones.Size = New System.Drawing.Size(263, 24)
        Me.cboAdditionalMilestones.TabIndex = 33
        '
        'lblAddMilestones
        '
        Me.lblAddMilestones.AutoSize = True
        Me.lblAddMilestones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddMilestones.Location = New System.Drawing.Point(29, 169)
        Me.lblAddMilestones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddMilestones.Name = "lblAddMilestones"
        Me.lblAddMilestones.Size = New System.Drawing.Size(167, 17)
        Me.lblAddMilestones.TabIndex = 32
        Me.lblAddMilestones.Text = "Additional Milestones:"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(805, 654)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(165, 42)
        Me.btnClose.TabIndex = 31
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAddProjectSystem
        '
        Me.btnAddProjectSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProjectSystem.Location = New System.Drawing.Point(805, 398)
        Me.btnAddProjectSystem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddProjectSystem.Name = "btnAddProjectSystem"
        Me.btnAddProjectSystem.Size = New System.Drawing.Size(165, 32)
        Me.btnAddProjectSystem.TabIndex = 30
        Me.btnAddProjectSystem.Text = "Add Program/System"
        Me.btnAddProjectSystem.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(606, 76)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(152, 34)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cboSystemAdd
        '
        Me.cboSystemAdd.Location = New System.Drawing.Point(548, 402)
        Me.cboSystemAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboSystemAdd.Name = "cboSystemAdd"
        Me.cboSystemAdd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSystemAdd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSystemAdd.Size = New System.Drawing.Size(252, 22)
        Me.cboSystemAdd.TabIndex = 28
        '
        'cboProgramAdd
        '
        Me.cboProgramAdd.Location = New System.Drawing.Point(200, 402)
        Me.cboProgramAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboProgramAdd.Name = "cboProgramAdd"
        Me.cboProgramAdd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProgramAdd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboProgramAdd.Size = New System.Drawing.Size(237, 22)
        Me.cboProgramAdd.TabIndex = 27
        '
        'txtMDLTitle
        '
        Me.txtMDLTitle.Location = New System.Drawing.Point(261, 76)
        Me.txtMDLTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMDLTitle.Name = "txtMDLTitle"
        Me.txtMDLTitle.ReadOnly = True
        Me.txtMDLTitle.Size = New System.Drawing.Size(263, 22)
        Me.txtMDLTitle.TabIndex = 26
        '
        'txtMDLNumber
        '
        Me.txtMDLNumber.Location = New System.Drawing.Point(261, 226)
        Me.txtMDLNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMDLNumber.Name = "txtMDLNumber"
        Me.txtMDLNumber.ReadOnly = True
        Me.txtMDLNumber.Size = New System.Drawing.Size(263, 22)
        Me.txtMDLNumber.TabIndex = 25
        '
        'lblAddProjects
        '
        Me.lblAddProjects.AutoSize = True
        Me.lblAddProjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddProjects.Location = New System.Drawing.Point(29, 406)
        Me.lblAddProjects.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddProjects.Name = "lblAddProjects"
        Me.lblAddProjects.Size = New System.Drawing.Size(159, 17)
        Me.lblAddProjects.TabIndex = 24
        Me.lblAddProjects.Text = "Additional Programs:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "MDL Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "MDL Number:"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridControl1.Location = New System.Drawing.Point(34, 197)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(937, 180)
        Me.GridControl1.TabIndex = 35
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblLiveMDLMilestone"
        Me.BindingSource1.DataSource = Me.DataSet371
        '
        'DataSet371
        '
        Me.DataSet371.DataSetName = "DataSet37"
        Me.DataSet371.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colMDLRecordID, Me.colMDLNumber, Me.colMilestone})
        Me.GridView1.DetailHeight = 430
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.MinWidth = 27
        Me.colRecordID.Name = "colRecordID"
        Me.colRecordID.Width = 100
        '
        'colMDLRecordID
        '
        Me.colMDLRecordID.FieldName = "MDLRecordID"
        Me.colMDLRecordID.MinWidth = 27
        Me.colMDLRecordID.Name = "colMDLRecordID"
        Me.colMDLRecordID.Width = 100
        '
        'colMDLNumber
        '
        Me.colMDLNumber.FieldName = "MDLNumber"
        Me.colMDLNumber.MinWidth = 27
        Me.colMDLNumber.Name = "colMDLNumber"
        Me.colMDLNumber.Width = 100
        '
        'colMilestone
        '
        Me.colMilestone.FieldName = "Milestone"
        Me.colMilestone.MinWidth = 27
        Me.colMilestone.Name = "colMilestone"
        Me.colMilestone.Visible = True
        Me.colMilestone.VisibleIndex = 0
        Me.colMilestone.Width = 100
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.BindingSource2
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridControl2.Location = New System.Drawing.Point(34, 450)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(937, 180)
        Me.GridControl2.TabIndex = 36
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "tblLiveMDLProjectsSystems"
        Me.BindingSource2.DataSource = Me.DataSet381
        '
        'DataSet381
        '
        Me.DataSet381.DataSetName = "DataSet38"
        Me.DataSet381.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID1, Me.colMDLRecordID1, Me.colMDLNumber1, Me.colProgram, Me.colSystem})
        Me.GridView2.DetailHeight = 430
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'colRecordID1
        '
        Me.colRecordID1.FieldName = "RecordID"
        Me.colRecordID1.MinWidth = 27
        Me.colRecordID1.Name = "colRecordID1"
        Me.colRecordID1.Width = 100
        '
        'colMDLRecordID1
        '
        Me.colMDLRecordID1.FieldName = "MDLRecordID"
        Me.colMDLRecordID1.MinWidth = 27
        Me.colMDLRecordID1.Name = "colMDLRecordID1"
        Me.colMDLRecordID1.Width = 100
        '
        'colMDLNumber1
        '
        Me.colMDLNumber1.FieldName = "MDLNumber"
        Me.colMDLNumber1.MinWidth = 27
        Me.colMDLNumber1.Name = "colMDLNumber1"
        Me.colMDLNumber1.Width = 100
        '
        'colProgram
        '
        Me.colProgram.FieldName = "Program"
        Me.colProgram.MinWidth = 27
        Me.colProgram.Name = "colProgram"
        Me.colProgram.Visible = True
        Me.colProgram.VisibleIndex = 0
        Me.colProgram.Width = 100
        '
        'colSystem
        '
        Me.colSystem.FieldName = "System"
        Me.colSystem.MinWidth = 27
        Me.colSystem.Name = "colSystem"
        Me.colSystem.Visible = True
        Me.colSystem.VisibleIndex = 1
        Me.colSystem.Width = 100
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT   tblLiveMDLMilestone.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         tblLiveMDLMilestone"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [tblLiveMDLMilestone] ([MDLRecordID], [MDLNumber], [Milestone]) VALUE" &
    "S (@MDLRecordID, @MDLNumber, @Milestone)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MDLRecordID", System.Data.SqlDbType.Int, 0, "MDLRecordID"), New System.Data.SqlClient.SqlParameter("@MDLNumber", System.Data.SqlDbType.Int, 0, "MDLNumber"), New System.Data.SqlClient.SqlParameter("@Milestone", System.Data.SqlDbType.NVarChar, 0, "Milestone")})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblLiveMDLMilestone", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("MDLRecordID", "MDLRecordID"), New System.Data.Common.DataColumnMapping("MDLNumber", "MDLNumber"), New System.Data.Common.DataColumnMapping("Milestone", "Milestone")})})
        '
        'txtMilestoneRecordId
        '
        Me.txtMilestoneRecordId.Location = New System.Drawing.Point(347, 283)
        Me.txtMilestoneRecordId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMilestoneRecordId.Name = "txtMilestoneRecordId"
        Me.txtMilestoneRecordId.Size = New System.Drawing.Size(132, 22)
        Me.txtMilestoneRecordId.TabIndex = 37
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT   tblLiveMDLProjectsSystems.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         tblLiveMDLProjectsSystems"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO [tblLiveMDLProjectsSystems] ([MDLRecordID], [MDLNumber], [Program], [" &
    "System]) VALUES (@MDLRecordID, @MDLNumber, @Program, @System)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MDLRecordID", System.Data.SqlDbType.Int, 0, "MDLRecordID"), New System.Data.SqlClient.SqlParameter("@MDLNumber", System.Data.SqlDbType.Int, 0, "MDLNumber"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@System", System.Data.SqlDbType.NVarChar, 0, "System")})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblLiveMDLProjectsSystems", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("MDLRecordID", "MDLRecordID"), New System.Data.Common.DataColumnMapping("MDLNumber", "MDLNumber"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("System", "System")})})
        '
        'txtProgramSystemRecordID
        '
        Me.txtProgramSystemRecordID.Location = New System.Drawing.Point(224, 576)
        Me.txtProgramSystemRecordID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProgramSystemRecordID.Name = "txtProgramSystemRecordID"
        Me.txtProgramSystemRecordID.Size = New System.Drawing.Size(132, 22)
        Me.txtProgramSystemRecordID.TabIndex = 38
        '
        'btnDeleteMilestone
        '
        Me.btnDeleteMilestone.Location = New System.Drawing.Point(583, 210)
        Me.btnDeleteMilestone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeleteMilestone.Name = "btnDeleteMilestone"
        Me.btnDeleteMilestone.Size = New System.Drawing.Size(380, 28)
        Me.btnDeleteMilestone.TabIndex = 39
        Me.btnDeleteMilestone.Text = "Delete Current Selected Milestone"
        Me.btnDeleteMilestone.UseVisualStyleBackColor = True
        '
        'btnDeleteProgramSystem
        '
        Me.btnDeleteProgramSystem.Location = New System.Drawing.Point(583, 462)
        Me.btnDeleteProgramSystem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeleteProgramSystem.Name = "btnDeleteProgramSystem"
        Me.btnDeleteProgramSystem.Size = New System.Drawing.Size(380, 28)
        Me.btnDeleteProgramSystem.TabIndex = 40
        Me.btnDeleteProgramSystem.Text = "Delete Current Selected System"
        Me.btnDeleteProgramSystem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(466, 406)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Systems:"
        '
        'txtDocumentNumber
        '
        Me.txtDocumentNumber.Location = New System.Drawing.Point(260, 48)
        Me.txtDocumentNumber.Name = "txtDocumentNumber"
        Me.txtDocumentNumber.ReadOnly = True
        Me.txtDocumentNumber.Size = New System.Drawing.Size(263, 22)
        Me.txtDocumentNumber.TabIndex = 42
        '
        'frmMDLChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 745)
        Me.Controls.Add(Me.txtDocumentNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeleteProgramSystem)
        Me.Controls.Add(Me.btnDeleteMilestone)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btnAddMilestones)
        Me.Controls.Add(Me.cboAdditionalMilestones)
        Me.Controls.Add(Me.lblAddMilestones)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddProjectSystem)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboSystemAdd)
        Me.Controls.Add(Me.cboProgramAdd)
        Me.Controls.Add(Me.txtMDLTitle)
        Me.Controls.Add(Me.txtMDLNumber)
        Me.Controls.Add(Me.lblAddProjects)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProgramSystemRecordID)
        Me.Controls.Add(Me.txtMilestoneRecordId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMDLChange"
        Me.Text = "frmMDLChange"
        CType(Me.cboSystemAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProgramAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet371, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet381, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddMilestones As Button
    Friend WithEvents cboAdditionalMilestones As ComboBox
    Friend WithEvents lblAddMilestones As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAddProjectSystem As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cboSystemAdd As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboProgramAdd As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtMDLTitle As TextBox
    Friend WithEvents txtMDLNumber As TextBox
    Friend WithEvents lblAddProjects As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet371 As DataSet37
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMilestone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents DataSet381 As DataSet38
    Friend WithEvents colRecordID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLRecordID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLNumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMilestoneRecordId As TextBox
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As SqlClient.SqlDataAdapter
    Friend WithEvents txtProgramSystemRecordID As TextBox
    Friend WithEvents btnDeleteMilestone As Button
    Friend WithEvents btnDeleteProgramSystem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDocumentNumber As TextBox
End Class
