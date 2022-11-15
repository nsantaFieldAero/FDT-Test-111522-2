<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEARRGrid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEARRGrid))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet41 = New EngDesignTracking.DataSet4()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEARRNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEARRStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEARRType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabShop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox6 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colEARRResponseDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginatorDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstCompletionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineeringManagerSignOffDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLiaisonManagerSignOffDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannerSignOffDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQCSignOff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox5 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.chkShowCompletedEARRS = New System.Windows.Forms.CheckBox()
        Me.btnExportGrid = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSubmitNewDrawingRequest = New System.Windows.Forms.Button()
        Me.btnEditandViewRow = New System.Windows.Forms.Button()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.btnEARRApproval = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.btnExportForm = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SignOffUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GridControl1.Location = New System.Drawing.Point(9, 58)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3, Me.RepositoryItemComboBox4, Me.RepositoryItemComboBox5, Me.RepositoryItemComboBox6})
        Me.GridControl1.Size = New System.Drawing.Size(1300, 577)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblEARR"
        Me.BindingSource1.DataSource = Me.DataSet41
        '
        'DataSet41
        '
        Me.DataSet41.DataSetName = "DataSet4"
        Me.DataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 0
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEARRNumber, Me.colEARRStatus, Me.colEARRType, Me.colWorkOrder, Me.colProgramName, Me.colFabShop, Me.colComments, Me.colPriority, Me.colEARRResponseDate, Me.colOriginatorDate, Me.colEstCompletionDate, Me.colEngineeringManagerSignOffDate, Me.colLiaisonManagerSignOffDate, Me.colPlannerSignOffDate, Me.colQCSignOff})
        Me.GridView1.DetailHeight = 181
        Me.GridView1.FixedLineWidth = 1
        Me.GridView1.FooterPanelHeight = 0
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupRowHeight = 0
        Me.GridView1.LevelIndent = 0
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.PreviewIndent = 0
        Me.GridView1.RowHeight = 0
        Me.GridView1.ViewCaptionHeight = 0
        '
        'colEARRNumber
        '
        Me.colEARRNumber.FieldName = "EARRNumber"
        Me.colEARRNumber.MinWidth = 19
        Me.colEARRNumber.Name = "colEARRNumber"
        Me.colEARRNumber.Visible = True
        Me.colEARRNumber.VisibleIndex = 0
        Me.colEARRNumber.Width = 71
        '
        'colEARRStatus
        '
        Me.colEARRStatus.FieldName = "EARRStatus"
        Me.colEARRStatus.MinWidth = 19
        Me.colEARRStatus.Name = "colEARRStatus"
        Me.colEARRStatus.Visible = True
        Me.colEARRStatus.VisibleIndex = 2
        Me.colEARRStatus.Width = 71
        '
        'colEARRType
        '
        Me.colEARRType.FieldName = "EARRType"
        Me.colEARRType.MinWidth = 19
        Me.colEARRType.Name = "colEARRType"
        Me.colEARRType.Visible = True
        Me.colEARRType.VisibleIndex = 3
        Me.colEARRType.Width = 71
        '
        'colWorkOrder
        '
        Me.colWorkOrder.FieldName = "WorkOrder"
        Me.colWorkOrder.MinWidth = 19
        Me.colWorkOrder.Name = "colWorkOrder"
        Me.colWorkOrder.Visible = True
        Me.colWorkOrder.VisibleIndex = 4
        Me.colWorkOrder.Width = 71
        '
        'colProgramName
        '
        Me.colProgramName.FieldName = "ProgramName"
        Me.colProgramName.MinWidth = 19
        Me.colProgramName.Name = "colProgramName"
        Me.colProgramName.Visible = True
        Me.colProgramName.VisibleIndex = 5
        Me.colProgramName.Width = 71
        '
        'colFabShop
        '
        Me.colFabShop.FieldName = "FabShop"
        Me.colFabShop.MinWidth = 19
        Me.colFabShop.Name = "colFabShop"
        Me.colFabShop.Visible = True
        Me.colFabShop.VisibleIndex = 6
        Me.colFabShop.Width = 71
        '
        'colComments
        '
        Me.colComments.Caption = "Comments"
        Me.colComments.FieldName = "Comments"
        Me.colComments.MinWidth = 100
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 7
        Me.colComments.Width = 200
        '
        'colPriority
        '
        Me.colPriority.Caption = "Priority"
        Me.colPriority.ColumnEdit = Me.RepositoryItemComboBox6
        Me.colPriority.FieldName = "Priority"
        Me.colPriority.Name = "colPriority"
        Me.colPriority.Visible = True
        Me.colPriority.VisibleIndex = 1
        '
        'RepositoryItemComboBox6
        '
        Me.RepositoryItemComboBox6.AutoHeight = False
        Me.RepositoryItemComboBox6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox6.Items.AddRange(New Object() {"Normal", "High"})
        Me.RepositoryItemComboBox6.Name = "RepositoryItemComboBox6"
        Me.RepositoryItemComboBox6.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colEARRResponseDate
        '
        Me.colEARRResponseDate.Caption = "Response Req Date"
        Me.colEARRResponseDate.FieldName = "EARRResponseDate"
        Me.colEARRResponseDate.Name = "colEARRResponseDate"
        Me.colEARRResponseDate.Width = 50
        '
        'colOriginatorDate
        '
        Me.colOriginatorDate.Caption = "Date Raised"
        Me.colOriginatorDate.FieldName = "OriginatorDate"
        Me.colOriginatorDate.Name = "colOriginatorDate"
        '
        'colEstCompletionDate
        '
        Me.colEstCompletionDate.FieldName = "EstCompletionDate"
        Me.colEstCompletionDate.Name = "colEstCompletionDate"
        '
        'colEngineeringManagerSignOffDate
        '
        Me.colEngineeringManagerSignOffDate.FieldName = "EngineeringManagerSignOffDate"
        Me.colEngineeringManagerSignOffDate.Name = "colEngineeringManagerSignOffDate"
        '
        'colLiaisonManagerSignOffDate
        '
        Me.colLiaisonManagerSignOffDate.FieldName = "LiaisonManagerSignOffDate"
        Me.colLiaisonManagerSignOffDate.Name = "colLiaisonManagerSignOffDate"
        '
        'colPlannerSignOffDate
        '
        Me.colPlannerSignOffDate.FieldName = "PlannerSignOffDate"
        Me.colPlannerSignOffDate.Name = "colPlannerSignOffDate"
        '
        'colQCSignOff
        '
        Me.colQCSignOff.FieldName = "QCSignOff"
        Me.colQCSignOff.Name = "colQCSignOff"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Aselsan", "Jaguar"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"GATE 0: CM Needs To Assign DWG Number", "GATE 1: WIP", "GATE 2: DWG Ready For Review", "GATE 3: DWG Ready For Checker/Engineer", "GATE 4: DWG Ready For Stress", "GATE 5: DWG Ready For Flammability", "GATE 6: DWG Ready For Sr Engineer", "GATE 7: DWG Ready For Release", "GATE 8 : DWG Released"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Items.AddRange(New Object() {"M", "E", "S"})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        '
        'RepositoryItemComboBox4
        '
        Me.RepositoryItemComboBox4.AutoHeight = False
        Me.RepositoryItemComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox4.Name = "RepositoryItemComboBox4"
        '
        'RepositoryItemComboBox5
        '
        Me.RepositoryItemComboBox5.AutoHeight = False
        Me.RepositoryItemComboBox5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox5.Items.AddRange(New Object() {"Assembly", "Detail", "General Arrangement", "Harness Assembly", "Installation", "Provisions", "Rework", "Specification", "Tooling", "Wire Diagram", "Wire Routing Diagram"})
        Me.RepositoryItemComboBox5.Name = "RepositoryItemComboBox5"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(887, 31)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "Refresh Grid"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'chkShowCompletedEARRS
        '
        Me.chkShowCompletedEARRS.AutoSize = True
        Me.chkShowCompletedEARRS.Location = New System.Drawing.Point(684, 34)
        Me.chkShowCompletedEARRS.Margin = New System.Windows.Forms.Padding(1)
        Me.chkShowCompletedEARRS.Name = "chkShowCompletedEARRS"
        Me.chkShowCompletedEARRS.Size = New System.Drawing.Size(180, 17)
        Me.chkShowCompletedEARRS.TabIndex = 14
        Me.chkShowCompletedEARRS.Text = "Show Complete/Aborted EARRs"
        Me.chkShowCompletedEARRS.UseVisualStyleBackColor = True
        '
        'btnExportGrid
        '
        Me.btnExportGrid.Location = New System.Drawing.Point(977, 31)
        Me.btnExportGrid.Name = "btnExportGrid"
        Me.btnExportGrid.Size = New System.Drawing.Size(75, 23)
        Me.btnExportGrid.TabIndex = 13
        Me.btnExportGrid.Text = "Export Grid"
        Me.btnExportGrid.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(684, 650)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(189, 29)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSubmitNewDrawingRequest
        '
        Me.btnSubmitNewDrawingRequest.Location = New System.Drawing.Point(883, 650)
        Me.btnSubmitNewDrawingRequest.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnSubmitNewDrawingRequest.Name = "btnSubmitNewDrawingRequest"
        Me.btnSubmitNewDrawingRequest.Size = New System.Drawing.Size(189, 29)
        Me.btnSubmitNewDrawingRequest.TabIndex = 18
        Me.btnSubmitNewDrawingRequest.Text = "Submit New EARR"
        Me.btnSubmitNewDrawingRequest.UseVisualStyleBackColor = True
        '
        'btnEditandViewRow
        '
        Me.btnEditandViewRow.Location = New System.Drawing.Point(491, 650)
        Me.btnEditandViewRow.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnEditandViewRow.Name = "btnEditandViewRow"
        Me.btnEditandViewRow.Size = New System.Drawing.Size(189, 29)
        Me.btnEditandViewRow.TabIndex = 17
        Me.btnEditandViewRow.Text = "Edit/View Row"
        Me.btnEditandViewRow.UseVisualStyleBackColor = True
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=EARR;Persist Security Info=True;U" &
    "ser ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection2
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EARRNumber", System.Data.SqlDbType.NVarChar, 0, "EARRNumber"), New System.Data.SqlClient.SqlParameter("@EARRStatus", System.Data.SqlDbType.NVarChar, 0, "EARRStatus"), New System.Data.SqlClient.SqlParameter("@EARRType", System.Data.SqlDbType.NVarChar, 0, "EARRType"), New System.Data.SqlClient.SqlParameter("@SerialNumber", System.Data.SqlDbType.NVarChar, 0, "SerialNumber"), New System.Data.SqlClient.SqlParameter("@WorkOrder", System.Data.SqlDbType.NVarChar, 0, "WorkOrder"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DrawingRevision", System.Data.SqlDbType.NVarChar, 0, "DrawingRevision"), New System.Data.SqlClient.SqlParameter("@Request", System.Data.SqlDbType.NVarChar, 0, "Request"), New System.Data.SqlClient.SqlParameter("@IncorpRedLineYes", System.Data.SqlDbType.Bit, 0, "IncorpRedLineYes"), New System.Data.SqlClient.SqlParameter("@IncorpRedLineNo", System.Data.SqlDbType.Bit, 0, "IncorpRedLineNo"), New System.Data.SqlClient.SqlParameter("@DrawingReqForConformityYes", System.Data.SqlDbType.Bit, 0, "DrawingReqForConformityYes"), New System.Data.SqlClient.SqlParameter("@DrawingReqForConformityNo", System.Data.SqlDbType.Bit, 0, "DrawingReqForConformityNo"), New System.Data.SqlClient.SqlParameter("@EARRResponseDate", System.Data.SqlDbType.[Date], 0, "EARRResponseDate"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@OriginatorDate", System.Data.SqlDbType.[Date], 0, "OriginatorDate"), New System.Data.SqlClient.SqlParameter("@OriginatorSignedOff", System.Data.SqlDbType.[Date], 0, "OriginatorSignedOff"), New System.Data.SqlClient.SqlParameter("@ReplyInstructions", System.Data.SqlDbType.NVarChar, 0, "ReplyInstructions"), New System.Data.SqlClient.SqlParameter("@EffectivityAll", System.Data.SqlDbType.Bit, 0, "EffectivityAll"), New System.Data.SqlClient.SqlParameter("@EffectivityOther", System.Data.SqlDbType.Bit, 0, "EffectivityOther"), New System.Data.SqlClient.SqlParameter("@EffectivityOtherText", System.Data.SqlDbType.NVarChar, 0, "EffectivityOtherText"), New System.Data.SqlClient.SqlParameter("@DeviationMinor", System.Data.SqlDbType.Bit, 0, "DeviationMinor"), New System.Data.SqlClient.SqlParameter("@DeviationMajor", System.Data.SqlDbType.Bit, 0, "DeviationMajor"), New System.Data.SqlClient.SqlParameter("@AdditionalEngReqNoAction", System.Data.SqlDbType.Bit, 0, "AdditionalEngReqNoAction"), New System.Data.SqlClient.SqlParameter("@AdditionalEngReqUpdate", System.Data.SqlDbType.Bit, 0, "AdditionalEngReqUpdate"), New System.Data.SqlClient.SqlParameter("@ACFTInterface", System.Data.SqlDbType.Bit, 0, "ACFTInterface"), New System.Data.SqlClient.SqlParameter("@Manufacturability", System.Data.SqlDbType.Bit, 0, "Manufacturability"), New System.Data.SqlClient.SqlParameter("@ProductImprovement", System.Data.SqlDbType.Bit, 0, "ProductImprovement"), New System.Data.SqlClient.SqlParameter("@DWGError", System.Data.SqlDbType.Bit, 0, "DWGError"), New System.Data.SqlClient.SqlParameter("@DesignError", System.Data.SqlDbType.Bit, 0, "DesignError"), New System.Data.SqlClient.SqlParameter("@LiaisonManagerName", System.Data.SqlDbType.NVarChar, 0, "LiaisonManagerName"), New System.Data.SqlClient.SqlParameter("@LiaisonManagerSignOffDate", System.Data.SqlDbType.[Date], 0, "LiaisonManagerSignOffDate"), New System.Data.SqlClient.SqlParameter("@EngineeringManagerName", System.Data.SqlDbType.NVarChar, 0, "EngineeringManagerName"), New System.Data.SqlClient.SqlParameter("@EngineeringManagerSignOffDate", System.Data.SqlDbType.[Date], 0, "EngineeringManagerSignOffDate"), New System.Data.SqlClient.SqlParameter("@LiaisonManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, "LiaisonManagerNameBackup"), New System.Data.SqlClient.SqlParameter("@EngineeringManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, "EngineeringManagerNameBackup"), New System.Data.SqlClient.SqlParameter("@Planner1", System.Data.SqlDbType.NVarChar, 0, "Planner1"), New System.Data.SqlClient.SqlParameter("@Planner2", System.Data.SqlDbType.NVarChar, 0, "Planner2"), New System.Data.SqlClient.SqlParameter("@QCName", System.Data.SqlDbType.NVarChar, 0, "QCName"), New System.Data.SqlClient.SqlParameter("@QCSignOff", System.Data.SqlDbType.[Date], 0, "QCSignOff"), New System.Data.SqlClient.SqlParameter("@QCNameBackup", System.Data.SqlDbType.NVarChar, 0, "QCNameBackup"), New System.Data.SqlClient.SqlParameter("@FabShop", System.Data.SqlDbType.Bit, 0, "FabShop"), New System.Data.SqlClient.SqlParameter("@QCNotes", System.Data.SqlDbType.NVarChar, 0, "QCNotes"), New System.Data.SqlClient.SqlParameter("@ProductionError", System.Data.SqlDbType.Bit, 0, "ProductionError"), New System.Data.SqlClient.SqlParameter("@EstCompletionDate", System.Data.SqlDbType.[Date], 0, "EstCompletionDate"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments"), New System.Data.SqlClient.SqlParameter("@EndItemType", System.Data.SqlDbType.NVarChar, 0, "EndItemType"), New System.Data.SqlClient.SqlParameter("@PlannerNotes", System.Data.SqlDbType.NVarChar, 0, "PlannerNotes"), New System.Data.SqlClient.SqlParameter("@PlannerSignOffDate", System.Data.SqlDbType.[Date], 0, "PlannerSignOffDate"), New System.Data.SqlClient.SqlParameter("@Priority", System.Data.SqlDbType.NVarChar, 0, "Priority")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EARRNumber", System.Data.SqlDbType.NVarChar, 0, "EARRNumber"), New System.Data.SqlClient.SqlParameter("@EARRStatus", System.Data.SqlDbType.NVarChar, 0, "EARRStatus"), New System.Data.SqlClient.SqlParameter("@EARRType", System.Data.SqlDbType.NVarChar, 0, "EARRType"), New System.Data.SqlClient.SqlParameter("@SerialNumber", System.Data.SqlDbType.NVarChar, 0, "SerialNumber"), New System.Data.SqlClient.SqlParameter("@WorkOrder", System.Data.SqlDbType.NVarChar, 0, "WorkOrder"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DrawingRevision", System.Data.SqlDbType.NVarChar, 0, "DrawingRevision"), New System.Data.SqlClient.SqlParameter("@Request", System.Data.SqlDbType.NVarChar, 0, "Request"), New System.Data.SqlClient.SqlParameter("@IncorpRedLineYes", System.Data.SqlDbType.Bit, 0, "IncorpRedLineYes"), New System.Data.SqlClient.SqlParameter("@IncorpRedLineNo", System.Data.SqlDbType.Bit, 0, "IncorpRedLineNo"), New System.Data.SqlClient.SqlParameter("@DrawingReqForConformityYes", System.Data.SqlDbType.Bit, 0, "DrawingReqForConformityYes"), New System.Data.SqlClient.SqlParameter("@DrawingReqForConformityNo", System.Data.SqlDbType.Bit, 0, "DrawingReqForConformityNo"), New System.Data.SqlClient.SqlParameter("@EARRResponseDate", System.Data.SqlDbType.[Date], 0, "EARRResponseDate"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@OriginatorDate", System.Data.SqlDbType.[Date], 0, "OriginatorDate"), New System.Data.SqlClient.SqlParameter("@OriginatorSignedOff", System.Data.SqlDbType.[Date], 0, "OriginatorSignedOff"), New System.Data.SqlClient.SqlParameter("@ReplyInstructions", System.Data.SqlDbType.NVarChar, 0, "ReplyInstructions"), New System.Data.SqlClient.SqlParameter("@EffectivityAll", System.Data.SqlDbType.Bit, 0, "EffectivityAll"), New System.Data.SqlClient.SqlParameter("@EffectivityOther", System.Data.SqlDbType.Bit, 0, "EffectivityOther"), New System.Data.SqlClient.SqlParameter("@EffectivityOtherText", System.Data.SqlDbType.NVarChar, 0, "EffectivityOtherText"), New System.Data.SqlClient.SqlParameter("@DeviationMinor", System.Data.SqlDbType.Bit, 0, "DeviationMinor"), New System.Data.SqlClient.SqlParameter("@DeviationMajor", System.Data.SqlDbType.Bit, 0, "DeviationMajor"), New System.Data.SqlClient.SqlParameter("@AdditionalEngReqNoAction", System.Data.SqlDbType.Bit, 0, "AdditionalEngReqNoAction"), New System.Data.SqlClient.SqlParameter("@AdditionalEngReqUpdate", System.Data.SqlDbType.Bit, 0, "AdditionalEngReqUpdate"), New System.Data.SqlClient.SqlParameter("@ACFTInterface", System.Data.SqlDbType.Bit, 0, "ACFTInterface"), New System.Data.SqlClient.SqlParameter("@Manufacturability", System.Data.SqlDbType.Bit, 0, "Manufacturability"), New System.Data.SqlClient.SqlParameter("@ProductImprovement", System.Data.SqlDbType.Bit, 0, "ProductImprovement"), New System.Data.SqlClient.SqlParameter("@DWGError", System.Data.SqlDbType.Bit, 0, "DWGError"), New System.Data.SqlClient.SqlParameter("@DesignError", System.Data.SqlDbType.Bit, 0, "DesignError"), New System.Data.SqlClient.SqlParameter("@LiaisonManagerName", System.Data.SqlDbType.NVarChar, 0, "LiaisonManagerName"), New System.Data.SqlClient.SqlParameter("@LiaisonManagerSignOffDate", System.Data.SqlDbType.[Date], 0, "LiaisonManagerSignOffDate"), New System.Data.SqlClient.SqlParameter("@EngineeringManagerName", System.Data.SqlDbType.NVarChar, 0, "EngineeringManagerName"), New System.Data.SqlClient.SqlParameter("@EngineeringManagerSignOffDate", System.Data.SqlDbType.[Date], 0, "EngineeringManagerSignOffDate"), New System.Data.SqlClient.SqlParameter("@LiaisonManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, "LiaisonManagerNameBackup"), New System.Data.SqlClient.SqlParameter("@EngineeringManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, "EngineeringManagerNameBackup"), New System.Data.SqlClient.SqlParameter("@Planner1", System.Data.SqlDbType.NVarChar, 0, "Planner1"), New System.Data.SqlClient.SqlParameter("@Planner2", System.Data.SqlDbType.NVarChar, 0, "Planner2"), New System.Data.SqlClient.SqlParameter("@QCName", System.Data.SqlDbType.NVarChar, 0, "QCName"), New System.Data.SqlClient.SqlParameter("@QCSignOff", System.Data.SqlDbType.[Date], 0, "QCSignOff"), New System.Data.SqlClient.SqlParameter("@QCNameBackup", System.Data.SqlDbType.NVarChar, 0, "QCNameBackup"), New System.Data.SqlClient.SqlParameter("@FabShop", System.Data.SqlDbType.Bit, 0, "FabShop"), New System.Data.SqlClient.SqlParameter("@QCNotes", System.Data.SqlDbType.NVarChar, 0, "QCNotes"), New System.Data.SqlClient.SqlParameter("@ProductionError", System.Data.SqlDbType.Bit, 0, "ProductionError"), New System.Data.SqlClient.SqlParameter("@EstCompletionDate", System.Data.SqlDbType.[Date], 0, "EstCompletionDate"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments"), New System.Data.SqlClient.SqlParameter("@EndItemType", System.Data.SqlDbType.NVarChar, 0, "EndItemType"), New System.Data.SqlClient.SqlParameter("@PlannerNotes", System.Data.SqlDbType.NVarChar, 0, "PlannerNotes"), New System.Data.SqlClient.SqlParameter("@PlannerSignOffDate", System.Data.SqlDbType.[Date], 0, "PlannerSignOffDate"), New System.Data.SqlClient.SqlParameter("@Priority", System.Data.SqlDbType.NVarChar, 0, "Priority"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRStatus", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRStatus", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRStatus", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRStatus", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WorkOrder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WorkOrder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Request", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Request", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Request", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Request", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IncorpRedLineYes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IncorpRedLineYes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IncorpRedLineYes", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorpRedLineYes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IncorpRedLineNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IncorpRedLineNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IncorpRedLineNo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorpRedLineNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingReqForConformityYes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityYes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingReqForConformityYes", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityYes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingReqForConformityNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingReqForConformityNo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRResponseDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRResponseDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRResponseDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRResponseDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorSignedOff", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorSignedOff", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorSignedOff", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorSignedOff", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReplyInstructions", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReplyInstructions", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReplyInstructions", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReplyInstructions", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EffectivityAll", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EffectivityAll", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EffectivityAll", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityAll", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EffectivityOther", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EffectivityOther", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EffectivityOther", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityOther", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EffectivityOtherText", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EffectivityOtherText", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EffectivityOtherText", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityOtherText", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DeviationMinor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DeviationMinor", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DeviationMinor", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeviationMinor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DeviationMajor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DeviationMajor", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DeviationMajor", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeviationMajor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AdditionalEngReqNoAction", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AdditionalEngReqNoAction", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AdditionalEngReqNoAction", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AdditionalEngReqNoAction", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AdditionalEngReqUpdate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AdditionalEngReqUpdate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AdditionalEngReqUpdate", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AdditionalEngReqUpdate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ACFTInterface", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ACFTInterface", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ACFTInterface", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ACFTInterface", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Manufacturability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Manufacturability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Manufacturability", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manufacturability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductImprovement", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductImprovement", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductImprovement", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductImprovement", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DWGError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DWGError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DWGError", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DWGError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignError", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonManagerName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonManagerName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonManagerName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonManagerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonManagerSignOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonManagerSignOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonManagerSignOffDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonManagerSignOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineeringManagerName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineeringManagerName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineeringManagerName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineeringManagerSignOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineeringManagerSignOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineeringManagerSignOffDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerSignOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonManagerNameBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonManagerNameBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonManagerNameBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineeringManagerNameBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineeringManagerNameBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineeringManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerNameBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCSignOff", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCSignOff", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCSignOff", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCSignOff", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCNameBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCNameBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCNameBackup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCNameBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FabShop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FabShop", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCNotes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCNotes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCNotes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductionError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductionError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductionError", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EstCompletionDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EstCompletionDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EstCompletionDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EstCompletionDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EndItemType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EndItemType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EndItemType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndItemType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannerNotes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannerNotes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannerNotes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannerNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannerSignOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannerSignOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannerSignOffDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannerSignOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Priority", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Priority", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRStatus", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRStatus", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRStatus", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRStatus", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WorkOrder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WorkOrder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Request", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Request", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Request", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Request", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IncorpRedLineYes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IncorpRedLineYes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IncorpRedLineYes", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorpRedLineYes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IncorpRedLineNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IncorpRedLineNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IncorpRedLineNo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorpRedLineNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingReqForConformityYes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityYes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingReqForConformityYes", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityYes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingReqForConformityNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingReqForConformityNo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRResponseDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRResponseDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRResponseDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRResponseDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorSignedOff", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorSignedOff", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorSignedOff", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorSignedOff", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReplyInstructions", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReplyInstructions", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReplyInstructions", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReplyInstructions", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EffectivityAll", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EffectivityAll", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EffectivityAll", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityAll", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EffectivityOther", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EffectivityOther", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EffectivityOther", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityOther", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EffectivityOtherText", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EffectivityOtherText", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EffectivityOtherText", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityOtherText", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DeviationMinor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DeviationMinor", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DeviationMinor", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeviationMinor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DeviationMajor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DeviationMajor", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DeviationMajor", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeviationMajor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AdditionalEngReqNoAction", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AdditionalEngReqNoAction", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AdditionalEngReqNoAction", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AdditionalEngReqNoAction", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AdditionalEngReqUpdate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AdditionalEngReqUpdate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AdditionalEngReqUpdate", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AdditionalEngReqUpdate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ACFTInterface", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ACFTInterface", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ACFTInterface", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ACFTInterface", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Manufacturability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Manufacturability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Manufacturability", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manufacturability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductImprovement", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductImprovement", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductImprovement", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductImprovement", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DWGError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DWGError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DWGError", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DWGError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignError", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonManagerName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonManagerName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonManagerName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonManagerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonManagerSignOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonManagerSignOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonManagerSignOffDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonManagerSignOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineeringManagerName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineeringManagerName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineeringManagerName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineeringManagerSignOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineeringManagerSignOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineeringManagerSignOffDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerSignOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonManagerNameBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonManagerNameBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonManagerNameBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineeringManagerNameBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineeringManagerNameBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineeringManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerNameBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCSignOff", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCSignOff", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCSignOff", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCSignOff", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCNameBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCNameBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCNameBackup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCNameBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FabShop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FabShop", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCNotes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCNotes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCNotes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductionError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductionError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductionError", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EstCompletionDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EstCompletionDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EstCompletionDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EstCompletionDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EndItemType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EndItemType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EndItemType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndItemType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannerNotes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannerNotes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannerNotes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannerNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannerSignOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannerSignOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannerSignOffDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannerSignOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Priority", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Priority", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblEARR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("EARRNumber", "EARRNumber"), New System.Data.Common.DataColumnMapping("EARRStatus", "EARRStatus"), New System.Data.Common.DataColumnMapping("EARRType", "EARRType"), New System.Data.Common.DataColumnMapping("SerialNumber", "SerialNumber"), New System.Data.Common.DataColumnMapping("WorkOrder", "WorkOrder"), New System.Data.Common.DataColumnMapping("ProgramName", "ProgramName"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DrawingRevision", "DrawingRevision"), New System.Data.Common.DataColumnMapping("Request", "Request"), New System.Data.Common.DataColumnMapping("IncorpRedLineYes", "IncorpRedLineYes"), New System.Data.Common.DataColumnMapping("IncorpRedLineNo", "IncorpRedLineNo"), New System.Data.Common.DataColumnMapping("DrawingReqForConformityYes", "DrawingReqForConformityYes"), New System.Data.Common.DataColumnMapping("DrawingReqForConformityNo", "DrawingReqForConformityNo"), New System.Data.Common.DataColumnMapping("EARRResponseDate", "EARRResponseDate"), New System.Data.Common.DataColumnMapping("OriginatorName", "OriginatorName"), New System.Data.Common.DataColumnMapping("OriginatorDate", "OriginatorDate"), New System.Data.Common.DataColumnMapping("OriginatorSignedOff", "OriginatorSignedOff"), New System.Data.Common.DataColumnMapping("ReplyInstructions", "ReplyInstructions"), New System.Data.Common.DataColumnMapping("EffectivityAll", "EffectivityAll"), New System.Data.Common.DataColumnMapping("EffectivityOther", "EffectivityOther"), New System.Data.Common.DataColumnMapping("EffectivityOtherText", "EffectivityOtherText"), New System.Data.Common.DataColumnMapping("DeviationMinor", "DeviationMinor"), New System.Data.Common.DataColumnMapping("DeviationMajor", "DeviationMajor"), New System.Data.Common.DataColumnMapping("AdditionalEngReqNoAction", "AdditionalEngReqNoAction"), New System.Data.Common.DataColumnMapping("AdditionalEngReqUpdate", "AdditionalEngReqUpdate"), New System.Data.Common.DataColumnMapping("ACFTInterface", "ACFTInterface"), New System.Data.Common.DataColumnMapping("Manufacturability", "Manufacturability"), New System.Data.Common.DataColumnMapping("ProductImprovement", "ProductImprovement"), New System.Data.Common.DataColumnMapping("DWGError", "DWGError"), New System.Data.Common.DataColumnMapping("DesignError", "DesignError"), New System.Data.Common.DataColumnMapping("LiaisonManagerName", "LiaisonManagerName"), New System.Data.Common.DataColumnMapping("LiaisonManagerSignOffDate", "LiaisonManagerSignOffDate"), New System.Data.Common.DataColumnMapping("EngineeringManagerName", "EngineeringManagerName"), New System.Data.Common.DataColumnMapping("EngineeringManagerSignOffDate", "EngineeringManagerSignOffDate"), New System.Data.Common.DataColumnMapping("LiaisonManagerNameBackup", "LiaisonManagerNameBackup"), New System.Data.Common.DataColumnMapping("EngineeringManagerNameBackup", "EngineeringManagerNameBackup"), New System.Data.Common.DataColumnMapping("Planner1", "Planner1"), New System.Data.Common.DataColumnMapping("Planner2", "Planner2"), New System.Data.Common.DataColumnMapping("QCName", "QCName"), New System.Data.Common.DataColumnMapping("QCSignOff", "QCSignOff"), New System.Data.Common.DataColumnMapping("QCNameBackup", "QCNameBackup"), New System.Data.Common.DataColumnMapping("FabShop", "FabShop"), New System.Data.Common.DataColumnMapping("QCNotes", "QCNotes"), New System.Data.Common.DataColumnMapping("ProductionError", "ProductionError"), New System.Data.Common.DataColumnMapping("EstCompletionDate", "EstCompletionDate"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("EndItemType", "EndItemType"), New System.Data.Common.DataColumnMapping("PlannerNotes", "PlannerNotes"), New System.Data.Common.DataColumnMapping("PlannerSignOffDate", "PlannerSignOffDate"), New System.Data.Common.DataColumnMapping("Priority", "Priority")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'txtRecordID
        '
        Me.txtRecordID.Location = New System.Drawing.Point(110, 217)
        Me.txtRecordID.Margin = New System.Windows.Forms.Padding(1)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(135, 20)
        Me.txtRecordID.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "# of EARRs requiring action by you:"
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.Location = New System.Drawing.Point(454, 36)
        Me.lblAction.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(27, 20)
        Me.lblAction.TabIndex = 22
        Me.lblAction.Text = "00"
        '
        'btnEARRApproval
        '
        Me.btnEARRApproval.Location = New System.Drawing.Point(506, 29)
        Me.btnEARRApproval.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEARRApproval.Name = "btnEARRApproval"
        Me.btnEARRApproval.Size = New System.Drawing.Size(174, 27)
        Me.btnEARRApproval.TabIndex = 23
        Me.btnEARRApproval.Text = "EARR Approval Screen"
        Me.btnEARRApproval.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(9, 34)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(1)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(155, 22)
        Me.btnMainMenu.TabIndex = 24
        Me.btnMainMenu.Text = "<< Return to Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnExportForm
        '
        Me.btnExportForm.Location = New System.Drawing.Point(1067, 31)
        Me.btnExportForm.Name = "btnExportForm"
        Me.btnExportForm.Size = New System.Drawing.Size(75, 23)
        Me.btnExportForm.TabIndex = 25
        Me.btnExportForm.Text = "Export Form"
        Me.btnExportForm.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1307, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem1, Me.SignOffUsersToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'UsersToolStripMenuItem1
        '
        Me.UsersToolStripMenuItem1.Name = "UsersToolStripMenuItem1"
        Me.UsersToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.UsersToolStripMenuItem1.Text = "Users"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'SignOffUsersToolStripMenuItem
        '
        Me.SignOffUsersToolStripMenuItem.Name = "SignOffUsersToolStripMenuItem"
        Me.SignOffUsersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SignOffUsersToolStripMenuItem.Text = "Sign Off Users"
        '
        'frmEARRGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1307, 690)
        Me.Controls.Add(Me.btnExportForm)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnEARRApproval)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSubmitNewDrawingRequest)
        Me.Controls.Add(Me.btnEditandViewRow)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.chkShowCompletedEARRS)
        Me.Controls.Add(Me.btnExportGrid)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtRecordID)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "frmEARRGrid"
        Me.Text = "frmEARRGrid"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
	Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
	Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
	Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
	Friend WithEvents RepositoryItemComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
	Friend WithEvents RepositoryItemComboBox5 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
	Friend WithEvents btnRefresh As Button
	Friend WithEvents chkShowCompletedEARRS As CheckBox
	Friend WithEvents btnExportGrid As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSubmitNewDrawingRequest As Button
	Friend WithEvents btnEditandViewRow As Button
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet41 As DataSet4
    Friend WithEvents txtRecordID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAction As Label
    Friend WithEvents btnEARRApproval As Button
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents colEARRNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEARRStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEARRType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabShop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExportForm As Button
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox6 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colEARRResponseDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginatorDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstCompletionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineeringManagerSignOffDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLiaisonManagerSignOffDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlannerSignOffDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQCSignOff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SignOffUsersToolStripMenuItem As ToolStripMenuItem
End Class
