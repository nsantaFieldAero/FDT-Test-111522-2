<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGridLookUp
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGridLookUp))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet21 = New EngDesignTracking.DataSet2()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNewRework = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgReqDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADCN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhiteBoardNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox8 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colProgram = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox6 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox7 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDwgRequestBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWONumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRevision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox5 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colSystemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colLastActionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualFinishDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannedFinishDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForecastFinishDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercentComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingFolderAssignDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignWIPDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModelTemplateDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterPlannedCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerPlannedCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerPlannedCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanical = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalPlannedComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionics = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsPlannedComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserCompelte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserPlannedCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammability = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityPlannedCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStressComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ForecastStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EstimatedDurationHours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstallationDrawing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNextHigherAssembly = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.btnSaveGrid = New System.Windows.Forms.Button()
        Me.btnEditandViewRow = New System.Windows.Forms.Button()
        Me.btnSubmitNewDrawingRequest = New System.Windows.Forms.Button()
        Me.btnExportGrid = New System.Windows.Forms.Button()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.chkShowStageComplete = New System.Windows.Forms.CheckBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnReturnToMainMenu = New System.Windows.Forms.Button()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.ProgramsDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
        Me.dtsPrograms = New EngDesignTracking.dtsPrograms()
        Me.ProgramsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPrograms = New EngDesignTracking.dsPrograms()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDrawingCert = New System.Windows.Forms.Button()
        Me.txtProgram = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtDrawingNumber = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificationStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LovMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemDescriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResourceTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameAssignmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriorityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DRNADCNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewReworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteBoardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectServerWorkflowSyncToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificationFilterGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificationMassUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsPrograms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrograms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'txtRecordID
        '
        Me.txtRecordID.BackColor = System.Drawing.Color.White
        Me.txtRecordID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecordID.ForeColor = System.Drawing.Color.White
        Me.txtRecordID.Location = New System.Drawing.Point(1728, 948)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(154, 20)
        Me.txtRecordID.TabIndex = 2
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.BindingSource2
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Enabled = False
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(16, 39)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3, Me.RepositoryItemComboBox4, Me.RepositoryItemComboBox5, Me.RepositoryItemComboBox6, Me.RepositoryItemComboBox7, Me.RepositoryItemComboBox8})
        Me.GridControl1.Size = New System.Drawing.Size(2115, 1000)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "tblDrawings"
        Me.BindingSource2.DataSource = Me.DataSet21
        '
        'DataSet21
        '
        Me.DataSet21.DataSetName = "DataSet2"
        Me.DataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 0
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNewRework, Me.colDwgReqDate, Me.GridColumn1, Me.colADCN, Me.colWhiteBoardNumber, Me.colProgram, Me.colLocation, Me.colPriority, Me.colType, Me.colDwgRequestBy, Me.colDrawingNumber, Me.colWONumber, Me.colDwgRevision, Me.colDwgRequestDate, Me.colDrawingTitle, Me.colDrawingType, Me.colSystemDescription, Me.colStatus, Me.colLastActionDate, Me.colActualFinishDate, Me.colPlannedFinishDate, Me.colForecastFinishDate, Me.colPercentComplete, Me.colDrawingFolderAssignDate, Me.colDesignWIPDate, Me.colNotes, Me.colModelTemplateDate, Me.colDrafter, Me.colDrafterComplete, Me.colDrafterPlannedCompleteDate, Me.colEngineer, Me.colEngineerComplete, Me.colEngineerPlannedCompleteDate, Me.colSrEngineer, Me.colSrEngineerComplete, Me.colSrEngineerPlannedCompleteDate, Me.colMechanical, Me.colMechanicalComplete, Me.colMechanicalPlannedComplete, Me.colAvionics, Me.colAvionicsComplete, Me.colAvionicsPlannedComplete, Me.colReleaser, Me.colReleaserCompelte, Me.colReleaserPlannedCompleteDate, Me.colFlammability, Me.colFlammabilityComplete, Me.colFlammabilityPlannedCompleteDate, Me.colStress, Me.colStressComplete, Me.ForecastStartDate, Me.EstimatedDurationHours, Me.colInstallationDrawing, Me.colNextHigherAssembly})
        Me.GridView1.DetailHeight = 261
        Me.GridView1.FixedLineWidth = 1
        Me.GridView1.FooterPanelHeight = 0
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupRowHeight = 0
        Me.GridView1.LevelIndent = 0
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsLayout.StoreAllOptions = True
        Me.GridView1.OptionsLayout.StoreAppearance = True
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.PreviewIndent = 0
        Me.GridView1.RowHeight = 0
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colProgram, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPriority, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.GridView1.ViewCaptionHeight = 0
        '
        'colNewRework
        '
        Me.colNewRework.Caption = "New/Rework"
        Me.colNewRework.FieldName = "NewRework"
        Me.colNewRework.MinWidth = 30
        Me.colNewRework.Name = "colNewRework"
        Me.colNewRework.Visible = True
        Me.colNewRework.VisibleIndex = 3
        Me.colNewRework.Width = 112
        '
        'colDwgReqDate
        '
        Me.colDwgReqDate.Caption = "Document Req Date"
        Me.colDwgReqDate.FieldName = "DwgReqDate"
        Me.colDwgReqDate.MinWidth = 30
        Me.colDwgReqDate.Name = "colDwgReqDate"
        Me.colDwgReqDate.Visible = True
        Me.colDwgReqDate.VisibleIndex = 2
        Me.colDwgReqDate.Width = 199
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "DRN"
        Me.GridColumn1.FieldName = "DRNADCN"
        Me.GridColumn1.MinWidth = 30
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'colADCN
        '
        Me.colADCN.Caption = "ADCN"
        Me.colADCN.FieldName = "ADCN"
        Me.colADCN.MinWidth = 30
        Me.colADCN.Name = "colADCN"
        Me.colADCN.Visible = True
        Me.colADCN.VisibleIndex = 30
        Me.colADCN.Width = 112
        '
        'colWhiteBoardNumber
        '
        Me.colWhiteBoardNumber.Caption = "White Board Number"
        Me.colWhiteBoardNumber.ColumnEdit = Me.RepositoryItemComboBox8
        Me.colWhiteBoardNumber.FieldName = "WhiteBoardNumber"
        Me.colWhiteBoardNumber.MinWidth = 30
        Me.colWhiteBoardNumber.Name = "colWhiteBoardNumber"
        Me.colWhiteBoardNumber.Visible = True
        Me.colWhiteBoardNumber.VisibleIndex = 0
        Me.colWhiteBoardNumber.Width = 112
        '
        'RepositoryItemComboBox8
        '
        Me.RepositoryItemComboBox8.AutoHeight = False
        Me.RepositoryItemComboBox8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox8.Name = "RepositoryItemComboBox8"
        Me.RepositoryItemComboBox8.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colProgram
        '
        Me.colProgram.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colProgram.DisplayFormat.FormatString = "d"
        Me.colProgram.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colProgram.FieldName = "Program"
        Me.colProgram.MinWidth = 30
        Me.colProgram.Name = "colProgram"
        Me.colProgram.Visible = True
        Me.colProgram.VisibleIndex = 5
        Me.colProgram.Width = 111
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colLocation
        '
        Me.colLocation.ColumnEdit = Me.RepositoryItemComboBox6
        Me.colLocation.FieldName = "Location"
        Me.colLocation.MinWidth = 30
        Me.colLocation.Name = "colLocation"
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 6
        Me.colLocation.Width = 111
        '
        'RepositoryItemComboBox6
        '
        Me.RepositoryItemComboBox6.AutoHeight = False
        Me.RepositoryItemComboBox6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox6.Items.AddRange(New Object() {"Calgary", "OKC", "Toronto"})
        Me.RepositoryItemComboBox6.Name = "RepositoryItemComboBox6"
        Me.RepositoryItemComboBox6.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colPriority
        '
        Me.colPriority.ColumnEdit = Me.RepositoryItemComboBox7
        Me.colPriority.FieldName = "Priority"
        Me.colPriority.MinWidth = 30
        Me.colPriority.Name = "colPriority"
        Me.colPriority.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colPriority.Visible = True
        Me.colPriority.VisibleIndex = 4
        Me.colPriority.Width = 111
        '
        'RepositoryItemComboBox7
        '
        Me.RepositoryItemComboBox7.AutoHeight = False
        Me.RepositoryItemComboBox7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox7.Name = "RepositoryItemComboBox7"
        '
        'colType
        '
        Me.colType.Caption = "Resource Type"
        Me.colType.ColumnEdit = Me.RepositoryItemComboBox3
        Me.colType.FieldName = "Type"
        Me.colType.MinWidth = 30
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 7
        Me.colType.Width = 111
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Items.AddRange(New Object() {"Certification", "Electrical", "Mechanical"})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        Me.RepositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colDwgRequestBy
        '
        Me.colDwgRequestBy.Caption = "Doc Request By"
        Me.colDwgRequestBy.FieldName = "DwgRequestBy"
        Me.colDwgRequestBy.MinWidth = 30
        Me.colDwgRequestBy.Name = "colDwgRequestBy"
        Me.colDwgRequestBy.Visible = True
        Me.colDwgRequestBy.VisibleIndex = 28
        Me.colDwgRequestBy.Width = 111
        '
        'colDrawingNumber
        '
        Me.colDrawingNumber.Caption = "Document Number"
        Me.colDrawingNumber.FieldName = "DrawingNumber"
        Me.colDrawingNumber.MinWidth = 30
        Me.colDrawingNumber.Name = "colDrawingNumber"
        Me.colDrawingNumber.Visible = True
        Me.colDrawingNumber.VisibleIndex = 8
        Me.colDrawingNumber.Width = 165
        '
        'colWONumber
        '
        Me.colWONumber.Caption = "WO Number"
        Me.colWONumber.FieldName = "WONumber"
        Me.colWONumber.MinWidth = 30
        Me.colWONumber.Name = "colWONumber"
        Me.colWONumber.Visible = True
        Me.colWONumber.VisibleIndex = 19
        Me.colWONumber.Width = 112
        '
        'colDwgRevision
        '
        Me.colDwgRevision.Caption = "Document Rev"
        Me.colDwgRevision.FieldName = "DwgRevision"
        Me.colDwgRevision.MinWidth = 30
        Me.colDwgRevision.Name = "colDwgRevision"
        Me.colDwgRevision.Visible = True
        Me.colDwgRevision.VisibleIndex = 9
        Me.colDwgRevision.Width = 264
        '
        'colDwgRequestDate
        '
        Me.colDwgRequestDate.FieldName = "DwgRequestDate"
        Me.colDwgRequestDate.MinWidth = 30
        Me.colDwgRequestDate.Name = "colDwgRequestDate"
        Me.colDwgRequestDate.Width = 111
        '
        'colDrawingTitle
        '
        Me.colDrawingTitle.Caption = "Document Title"
        Me.colDrawingTitle.FieldName = "DrawingTitle"
        Me.colDrawingTitle.MinWidth = 30
        Me.colDrawingTitle.Name = "colDrawingTitle"
        Me.colDrawingTitle.Visible = True
        Me.colDrawingTitle.VisibleIndex = 10
        Me.colDrawingTitle.Width = 345
        '
        'colDrawingType
        '
        Me.colDrawingType.Caption = "Document Type"
        Me.colDrawingType.ColumnEdit = Me.RepositoryItemComboBox5
        Me.colDrawingType.FieldName = "DrawingType"
        Me.colDrawingType.MinWidth = 30
        Me.colDrawingType.Name = "colDrawingType"
        Me.colDrawingType.Visible = True
        Me.colDrawingType.VisibleIndex = 20
        Me.colDrawingType.Width = 111
        '
        'RepositoryItemComboBox5
        '
        Me.RepositoryItemComboBox5.AutoHeight = False
        Me.RepositoryItemComboBox5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox5.Name = "RepositoryItemComboBox5"
        Me.RepositoryItemComboBox5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colSystemDescription
        '
        Me.colSystemDescription.FieldName = "SystemDescription"
        Me.colSystemDescription.MinWidth = 30
        Me.colSystemDescription.Name = "colSystemDescription"
        Me.colSystemDescription.Visible = True
        Me.colSystemDescription.VisibleIndex = 11
        Me.colSystemDescription.Width = 345
        '
        'colStatus
        '
        Me.colStatus.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colStatus.FieldName = "Status"
        Me.colStatus.MinWidth = 30
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 12
        Me.colStatus.Width = 345
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"GATE 0: CM Needs To Assign DWG Number", "GATE 1: DWG Ready For Drafter", "GATE 2: DWG Ready For Operations", "GATE 3: DWG Ready For Sr Engineer", "GATE 4: DWG Ready For Release", "GATE 5: DWG Released", "GATE 6: Complete"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        Me.RepositoryItemComboBox2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colLastActionDate
        '
        Me.colLastActionDate.FieldName = "LastActionDate"
        Me.colLastActionDate.MinWidth = 30
        Me.colLastActionDate.Name = "colLastActionDate"
        Me.colLastActionDate.Visible = True
        Me.colLastActionDate.VisibleIndex = 29
        Me.colLastActionDate.Width = 111
        '
        'colActualFinishDate
        '
        Me.colActualFinishDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colActualFinishDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualFinishDate.FieldName = "ActualFinishDate"
        Me.colActualFinishDate.MinWidth = 30
        Me.colActualFinishDate.Name = "colActualFinishDate"
        Me.colActualFinishDate.Visible = True
        Me.colActualFinishDate.VisibleIndex = 31
        Me.colActualFinishDate.Width = 111
        '
        'colPlannedFinishDate
        '
        Me.colPlannedFinishDate.Caption = "Baseline Finish Date (IMS)"
        Me.colPlannedFinishDate.DisplayFormat.FormatString = "d"
        Me.colPlannedFinishDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPlannedFinishDate.FieldName = "PlannedFinishDate"
        Me.colPlannedFinishDate.MinWidth = 30
        Me.colPlannedFinishDate.Name = "colPlannedFinishDate"
        Me.colPlannedFinishDate.Visible = True
        Me.colPlannedFinishDate.VisibleIndex = 17
        Me.colPlannedFinishDate.Width = 111
        '
        'colForecastFinishDate
        '
        Me.colForecastFinishDate.Caption = "Forecast Finish Date"
        Me.colForecastFinishDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colForecastFinishDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colForecastFinishDate.FieldName = "ForecastFinishDate"
        Me.colForecastFinishDate.MinWidth = 30
        Me.colForecastFinishDate.Name = "colForecastFinishDate"
        Me.colForecastFinishDate.Visible = True
        Me.colForecastFinishDate.VisibleIndex = 16
        Me.colForecastFinishDate.Width = 111
        '
        'colPercentComplete
        '
        Me.colPercentComplete.FieldName = "PercentComplete"
        Me.colPercentComplete.MinWidth = 30
        Me.colPercentComplete.Name = "colPercentComplete"
        Me.colPercentComplete.Visible = True
        Me.colPercentComplete.VisibleIndex = 32
        Me.colPercentComplete.Width = 111
        '
        'colDrawingFolderAssignDate
        '
        Me.colDrawingFolderAssignDate.Caption = "Doc Folder Assign Date"
        Me.colDrawingFolderAssignDate.FieldName = "DrawingFolderAssignDate"
        Me.colDrawingFolderAssignDate.MinWidth = 30
        Me.colDrawingFolderAssignDate.Name = "colDrawingFolderAssignDate"
        Me.colDrawingFolderAssignDate.Visible = True
        Me.colDrawingFolderAssignDate.VisibleIndex = 33
        Me.colDrawingFolderAssignDate.Width = 111
        '
        'colDesignWIPDate
        '
        Me.colDesignWIPDate.FieldName = "DesignWIPDate"
        Me.colDesignWIPDate.MinWidth = 30
        Me.colDesignWIPDate.Name = "colDesignWIPDate"
        Me.colDesignWIPDate.Visible = True
        Me.colDesignWIPDate.VisibleIndex = 34
        Me.colDesignWIPDate.Width = 111
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.MinWidth = 30
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 14
        Me.colNotes.Width = 345
        '
        'colModelTemplateDate
        '
        Me.colModelTemplateDate.FieldName = "ModelTemplateDate"
        Me.colModelTemplateDate.MinWidth = 30
        Me.colModelTemplateDate.Name = "colModelTemplateDate"
        Me.colModelTemplateDate.Visible = True
        Me.colModelTemplateDate.VisibleIndex = 35
        Me.colModelTemplateDate.Width = 111
        '
        'colDrafter
        '
        Me.colDrafter.FieldName = "Drafter"
        Me.colDrafter.MinWidth = 30
        Me.colDrafter.Name = "colDrafter"
        Me.colDrafter.Visible = True
        Me.colDrafter.VisibleIndex = 13
        Me.colDrafter.Width = 111
        '
        'colDrafterComplete
        '
        Me.colDrafterComplete.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colDrafterComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDrafterComplete.FieldName = "DrafterComplete"
        Me.colDrafterComplete.GroupFormat.FormatString = "MM/dd/yyyy"
        Me.colDrafterComplete.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDrafterComplete.MinWidth = 30
        Me.colDrafterComplete.Name = "colDrafterComplete"
        Me.colDrafterComplete.Visible = True
        Me.colDrafterComplete.VisibleIndex = 21
        Me.colDrafterComplete.Width = 111
        '
        'colDrafterPlannedCompleteDate
        '
        Me.colDrafterPlannedCompleteDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colDrafterPlannedCompleteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDrafterPlannedCompleteDate.FieldName = "DrafterPlannedCompleteDate"
        Me.colDrafterPlannedCompleteDate.MinWidth = 30
        Me.colDrafterPlannedCompleteDate.Name = "colDrafterPlannedCompleteDate"
        Me.colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.colDrafterPlannedCompleteDate.Width = 111
        '
        'colEngineer
        '
        Me.colEngineer.Caption = "Operations"
        Me.colEngineer.FieldName = "Engineer"
        Me.colEngineer.MinWidth = 30
        Me.colEngineer.Name = "colEngineer"
        Me.colEngineer.Visible = True
        Me.colEngineer.VisibleIndex = 22
        Me.colEngineer.Width = 111
        '
        'colEngineerComplete
        '
        Me.colEngineerComplete.Caption = "Operations Complete"
        Me.colEngineerComplete.FieldName = "EngineerComplete"
        Me.colEngineerComplete.MinWidth = 30
        Me.colEngineerComplete.Name = "colEngineerComplete"
        Me.colEngineerComplete.Visible = True
        Me.colEngineerComplete.VisibleIndex = 23
        Me.colEngineerComplete.Width = 111
        '
        'colEngineerPlannedCompleteDate
        '
        Me.colEngineerPlannedCompleteDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colEngineerPlannedCompleteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEngineerPlannedCompleteDate.FieldName = "EngineerPlannedCompleteDate"
        Me.colEngineerPlannedCompleteDate.MinWidth = 30
        Me.colEngineerPlannedCompleteDate.Name = "colEngineerPlannedCompleteDate"
        Me.colEngineerPlannedCompleteDate.Width = 111
        '
        'colSrEngineer
        '
        Me.colSrEngineer.FieldName = "SrEngineer"
        Me.colSrEngineer.MinWidth = 30
        Me.colSrEngineer.Name = "colSrEngineer"
        Me.colSrEngineer.Visible = True
        Me.colSrEngineer.VisibleIndex = 24
        Me.colSrEngineer.Width = 111
        '
        'colSrEngineerComplete
        '
        Me.colSrEngineerComplete.FieldName = "SrEngineerComplete"
        Me.colSrEngineerComplete.MinWidth = 30
        Me.colSrEngineerComplete.Name = "colSrEngineerComplete"
        Me.colSrEngineerComplete.Visible = True
        Me.colSrEngineerComplete.VisibleIndex = 25
        Me.colSrEngineerComplete.Width = 111
        '
        'colSrEngineerPlannedCompleteDate
        '
        Me.colSrEngineerPlannedCompleteDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colSrEngineerPlannedCompleteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSrEngineerPlannedCompleteDate.FieldName = "SrEngineerPlannedCompleteDate"
        Me.colSrEngineerPlannedCompleteDate.MinWidth = 30
        Me.colSrEngineerPlannedCompleteDate.Name = "colSrEngineerPlannedCompleteDate"
        Me.colSrEngineerPlannedCompleteDate.Width = 111
        '
        'colMechanical
        '
        Me.colMechanical.FieldName = "Mechanical"
        Me.colMechanical.MinWidth = 30
        Me.colMechanical.Name = "colMechanical"
        Me.colMechanical.Visible = True
        Me.colMechanical.VisibleIndex = 36
        Me.colMechanical.Width = 111
        '
        'colMechanicalComplete
        '
        Me.colMechanicalComplete.FieldName = "MechanicalComplete"
        Me.colMechanicalComplete.MinWidth = 30
        Me.colMechanicalComplete.Name = "colMechanicalComplete"
        Me.colMechanicalComplete.Visible = True
        Me.colMechanicalComplete.VisibleIndex = 37
        Me.colMechanicalComplete.Width = 111
        '
        'colMechanicalPlannedComplete
        '
        Me.colMechanicalPlannedComplete.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colMechanicalPlannedComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colMechanicalPlannedComplete.FieldName = "MechanicalPlannedComplete"
        Me.colMechanicalPlannedComplete.MinWidth = 30
        Me.colMechanicalPlannedComplete.Name = "colMechanicalPlannedComplete"
        Me.colMechanicalPlannedComplete.Width = 111
        '
        'colAvionics
        '
        Me.colAvionics.FieldName = "Avionics"
        Me.colAvionics.MinWidth = 30
        Me.colAvionics.Name = "colAvionics"
        Me.colAvionics.Visible = True
        Me.colAvionics.VisibleIndex = 39
        Me.colAvionics.Width = 111
        '
        'colAvionicsComplete
        '
        Me.colAvionicsComplete.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colAvionicsComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colAvionicsComplete.FieldName = "AvionicsComplete"
        Me.colAvionicsComplete.MinWidth = 30
        Me.colAvionicsComplete.Name = "colAvionicsComplete"
        Me.colAvionicsComplete.Visible = True
        Me.colAvionicsComplete.VisibleIndex = 38
        Me.colAvionicsComplete.Width = 111
        '
        'colAvionicsPlannedComplete
        '
        Me.colAvionicsPlannedComplete.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colAvionicsPlannedComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colAvionicsPlannedComplete.FieldName = "AvionicsPlannedComplete"
        Me.colAvionicsPlannedComplete.MinWidth = 30
        Me.colAvionicsPlannedComplete.Name = "colAvionicsPlannedComplete"
        Me.colAvionicsPlannedComplete.Width = 111
        '
        'colReleaser
        '
        Me.colReleaser.FieldName = "Releaser"
        Me.colReleaser.MinWidth = 30
        Me.colReleaser.Name = "colReleaser"
        Me.colReleaser.Visible = True
        Me.colReleaser.VisibleIndex = 26
        Me.colReleaser.Width = 111
        '
        'colReleaserCompelte
        '
        Me.colReleaserCompelte.Caption = "Releaser Complete"
        Me.colReleaserCompelte.FieldName = "ReleaserCompelte"
        Me.colReleaserCompelte.MinWidth = 30
        Me.colReleaserCompelte.Name = "colReleaserCompelte"
        Me.colReleaserCompelte.Visible = True
        Me.colReleaserCompelte.VisibleIndex = 27
        Me.colReleaserCompelte.Width = 111
        '
        'colReleaserPlannedCompleteDate
        '
        Me.colReleaserPlannedCompleteDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colReleaserPlannedCompleteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colReleaserPlannedCompleteDate.FieldName = "ReleaserPlannedCompleteDate"
        Me.colReleaserPlannedCompleteDate.MinWidth = 30
        Me.colReleaserPlannedCompleteDate.Name = "colReleaserPlannedCompleteDate"
        Me.colReleaserPlannedCompleteDate.Width = 111
        '
        'colFlammability
        '
        Me.colFlammability.FieldName = "Flammability"
        Me.colFlammability.MinWidth = 30
        Me.colFlammability.Name = "colFlammability"
        Me.colFlammability.Visible = True
        Me.colFlammability.VisibleIndex = 40
        Me.colFlammability.Width = 111
        '
        'colFlammabilityComplete
        '
        Me.colFlammabilityComplete.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colFlammabilityComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFlammabilityComplete.FieldName = "FlammabilityComplete"
        Me.colFlammabilityComplete.MinWidth = 30
        Me.colFlammabilityComplete.Name = "colFlammabilityComplete"
        Me.colFlammabilityComplete.Visible = True
        Me.colFlammabilityComplete.VisibleIndex = 41
        Me.colFlammabilityComplete.Width = 111
        '
        'colFlammabilityPlannedCompleteDate
        '
        Me.colFlammabilityPlannedCompleteDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colFlammabilityPlannedCompleteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFlammabilityPlannedCompleteDate.FieldName = "FlammabilityPlannedCompleteDate"
        Me.colFlammabilityPlannedCompleteDate.MinWidth = 30
        Me.colFlammabilityPlannedCompleteDate.Name = "colFlammabilityPlannedCompleteDate"
        Me.colFlammabilityPlannedCompleteDate.Width = 111
        '
        'colStress
        '
        Me.colStress.FieldName = "Stress"
        Me.colStress.MinWidth = 30
        Me.colStress.Name = "colStress"
        Me.colStress.Visible = True
        Me.colStress.VisibleIndex = 42
        Me.colStress.Width = 111
        '
        'colStressComplete
        '
        Me.colStressComplete.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colStressComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colStressComplete.FieldName = "StressComplete"
        Me.colStressComplete.MinWidth = 30
        Me.colStressComplete.Name = "colStressComplete"
        Me.colStressComplete.Visible = True
        Me.colStressComplete.VisibleIndex = 43
        Me.colStressComplete.Width = 111
        '
        'ForecastStartDate
        '
        Me.ForecastStartDate.Caption = "Forecast Start Date"
        Me.ForecastStartDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.ForecastStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ForecastStartDate.FieldName = "ForecastStartDate"
        Me.ForecastStartDate.MinWidth = 30
        Me.ForecastStartDate.Name = "ForecastStartDate"
        Me.ForecastStartDate.Visible = True
        Me.ForecastStartDate.VisibleIndex = 15
        Me.ForecastStartDate.Width = 112
        '
        'EstimatedDurationHours
        '
        Me.EstimatedDurationHours.Caption = "Estimated Duration Hours"
        Me.EstimatedDurationHours.FieldName = "EstimatedDurationHours"
        Me.EstimatedDurationHours.MinWidth = 30
        Me.EstimatedDurationHours.Name = "EstimatedDurationHours"
        Me.EstimatedDurationHours.Visible = True
        Me.EstimatedDurationHours.VisibleIndex = 18
        Me.EstimatedDurationHours.Width = 112
        '
        'colInstallationDrawing
        '
        Me.colInstallationDrawing.Caption = "Installation Drawing"
        Me.colInstallationDrawing.FieldName = "InstallationDrawing"
        Me.colInstallationDrawing.MinWidth = 30
        Me.colInstallationDrawing.Name = "colInstallationDrawing"
        Me.colInstallationDrawing.Visible = True
        Me.colInstallationDrawing.VisibleIndex = 44
        Me.colInstallationDrawing.Width = 112
        '
        'colNextHigherAssembly
        '
        Me.colNextHigherAssembly.Caption = "Next Higher Assembly"
        Me.colNextHigherAssembly.FieldName = "NextHigherAssembly"
        Me.colNextHigherAssembly.MinWidth = 30
        Me.colNextHigherAssembly.Name = "colNextHigherAssembly"
        Me.colNextHigherAssembly.Visible = True
        Me.colNextHigherAssembly.VisibleIndex = 45
        Me.colNextHigherAssembly.Width = 112
        '
        'RepositoryItemComboBox4
        '
        Me.RepositoryItemComboBox4.AutoHeight = False
        Me.RepositoryItemComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox4.Name = "RepositoryItemComboBox4"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DocumentType", System.Data.SqlDbType.NVarChar, 0, "DocumentType"), New System.Data.SqlClient.SqlParameter("@Priority", System.Data.SqlDbType.NVarChar, 0, "Priority"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@DwgRequestBy", System.Data.SqlDbType.NVarChar, 0, "DwgRequestBy"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRequestDate", System.Data.SqlDbType.NVarChar, 0, "DwgRequestDate"), New System.Data.SqlClient.SqlParameter("@DrawingTitle", System.Data.SqlDbType.NVarChar, 0, "DrawingTitle"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@DrawingType", System.Data.SqlDbType.NVarChar, 0, "DrawingType"), New System.Data.SqlClient.SqlParameter("@SystemDescription", System.Data.SqlDbType.NVarChar, 0, "SystemDescription"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@LastActionDate", System.Data.SqlDbType.NVarChar, 0, "LastActionDate"), New System.Data.SqlClient.SqlParameter("@ActualFinishDate", System.Data.SqlDbType.[Date], 0, "ActualFinishDate"), New System.Data.SqlClient.SqlParameter("@ForecastStartDate", System.Data.SqlDbType.[Date], 0, "ForecastStartDate"), New System.Data.SqlClient.SqlParameter("@ForecastFinishDate", System.Data.SqlDbType.[Date], 0, "ForecastFinishDate"), New System.Data.SqlClient.SqlParameter("@PlannedFinishDate", System.Data.SqlDbType.[Date], 0, "PlannedFinishDate"), New System.Data.SqlClient.SqlParameter("@EstimatedDurationHours", System.Data.SqlDbType.NVarChar, 0, "EstimatedDurationHours"), New System.Data.SqlClient.SqlParameter("@PercentComplete", System.Data.SqlDbType.Int, 0, "PercentComplete"), New System.Data.SqlClient.SqlParameter("@DrawingFolderAssignDate", System.Data.SqlDbType.NVarChar, 0, "DrawingFolderAssignDate"), New System.Data.SqlClient.SqlParameter("@DesignWIPDate", System.Data.SqlDbType.NVarChar, 0, "DesignWIPDate"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@ModelTemplateDate", System.Data.SqlDbType.NVarChar, 0, "ModelTemplateDate"), New System.Data.SqlClient.SqlParameter("@Drafter", System.Data.SqlDbType.NVarChar, 0, "Drafter"), New System.Data.SqlClient.SqlParameter("@DrafterComplete", System.Data.SqlDbType.[Date], 0, "DrafterComplete"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@EngineerComplete", System.Data.SqlDbType.[Date], 0, "EngineerComplete"), New System.Data.SqlClient.SqlParameter("@SrEngineer", System.Data.SqlDbType.NVarChar, 0, "SrEngineer"), New System.Data.SqlClient.SqlParameter("@SrEngineerComplete", System.Data.SqlDbType.[Date], 0, "SrEngineerComplete"), New System.Data.SqlClient.SqlParameter("@Releaser", System.Data.SqlDbType.NVarChar, 0, "Releaser"), New System.Data.SqlClient.SqlParameter("@ReleaserCompelte", System.Data.SqlDbType.[Date], 0, "ReleaserCompelte"), New System.Data.SqlClient.SqlParameter("@Flammability", System.Data.SqlDbType.NVarChar, 0, "Flammability"), New System.Data.SqlClient.SqlParameter("@FlammabilityComplete", System.Data.SqlDbType.[Date], 0, "FlammabilityComplete"), New System.Data.SqlClient.SqlParameter("@Stress", System.Data.SqlDbType.NVarChar, 0, "Stress"), New System.Data.SqlClient.SqlParameter("@StressComplete", System.Data.SqlDbType.[Date], 0, "StressComplete"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@RefID", System.Data.SqlDbType.Int, 0, "RefID"), New System.Data.SqlClient.SqlParameter("@DrafterPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "DrafterPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@EngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "EngineerPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@SrEngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "SrEngineerPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@FlammabilityPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "FlammabilityPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@StressPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "StressPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@ReleaserPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "ReleaserPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@Avionics", System.Data.SqlDbType.NVarChar, 0, "Avionics"), New System.Data.SqlClient.SqlParameter("@AvionicsComplete", System.Data.SqlDbType.[Date], 0, "AvionicsComplete"), New System.Data.SqlClient.SqlParameter("@AvionicsPlannedComplete", System.Data.SqlDbType.[Date], 0, "AvionicsPlannedComplete"), New System.Data.SqlClient.SqlParameter("@Mechanical", System.Data.SqlDbType.NVarChar, 0, "Mechanical"), New System.Data.SqlClient.SqlParameter("@MechanicalComplete", System.Data.SqlDbType.[Date], 0, "MechanicalComplete"), New System.Data.SqlClient.SqlParameter("@MechanicalPlannedComplete", System.Data.SqlDbType.[Date], 0, "MechanicalPlannedComplete"), New System.Data.SqlClient.SqlParameter("@WONumber", System.Data.SqlDbType.NVarChar, 0, "WONumber"), New System.Data.SqlClient.SqlParameter("@NextHigherAssembly", System.Data.SqlDbType.NVarChar, 0, "NextHigherAssembly"), New System.Data.SqlClient.SqlParameter("@InstallationDrawing", System.Data.SqlDbType.NVarChar, 0, "InstallationDrawing"), New System.Data.SqlClient.SqlParameter("@WhiteBoardNumber", System.Data.SqlDbType.NVarChar, 0, "WhiteBoardNumber"), New System.Data.SqlClient.SqlParameter("@DRNADCN", System.Data.SqlDbType.NVarChar, 0, "DRNADCN"), New System.Data.SqlClient.SqlParameter("@DwgReqDate", System.Data.SqlDbType.[Date], 0, "DwgReqDate"), New System.Data.SqlClient.SqlParameter("@CompanyFlightTestRequired", System.Data.SqlDbType.NVarChar, 0, "CompanyFlightTestRequired"), New System.Data.SqlClient.SqlParameter("@PSCPDocsRequired", System.Data.SqlDbType.NVarChar, 0, "PSCPDocsRequired"), New System.Data.SqlClient.SqlParameter("@FAAProjectNo", System.Data.SqlDbType.NVarChar, 0, "FAAProjectNo"), New System.Data.SqlClient.SqlParameter("@NewRework", System.Data.SqlDbType.NVarChar, 0, "NewRework"), New System.Data.SqlClient.SqlParameter("@ADCN", System.Data.SqlDbType.NVarChar, 0, "ADCN")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DocumentType", System.Data.SqlDbType.NVarChar, 0, "DocumentType"), New System.Data.SqlClient.SqlParameter("@Priority", System.Data.SqlDbType.NVarChar, 0, "Priority"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@DwgRequestBy", System.Data.SqlDbType.NVarChar, 0, "DwgRequestBy"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRequestDate", System.Data.SqlDbType.NVarChar, 0, "DwgRequestDate"), New System.Data.SqlClient.SqlParameter("@DrawingTitle", System.Data.SqlDbType.NVarChar, 0, "DrawingTitle"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@DrawingType", System.Data.SqlDbType.NVarChar, 0, "DrawingType"), New System.Data.SqlClient.SqlParameter("@SystemDescription", System.Data.SqlDbType.NVarChar, 0, "SystemDescription"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@LastActionDate", System.Data.SqlDbType.NVarChar, 0, "LastActionDate"), New System.Data.SqlClient.SqlParameter("@ActualFinishDate", System.Data.SqlDbType.[Date], 0, "ActualFinishDate"), New System.Data.SqlClient.SqlParameter("@ForecastStartDate", System.Data.SqlDbType.[Date], 0, "ForecastStartDate"), New System.Data.SqlClient.SqlParameter("@ForecastFinishDate", System.Data.SqlDbType.[Date], 0, "ForecastFinishDate"), New System.Data.SqlClient.SqlParameter("@PlannedFinishDate", System.Data.SqlDbType.[Date], 0, "PlannedFinishDate"), New System.Data.SqlClient.SqlParameter("@EstimatedDurationHours", System.Data.SqlDbType.NVarChar, 0, "EstimatedDurationHours"), New System.Data.SqlClient.SqlParameter("@PercentComplete", System.Data.SqlDbType.Int, 0, "PercentComplete"), New System.Data.SqlClient.SqlParameter("@DrawingFolderAssignDate", System.Data.SqlDbType.NVarChar, 0, "DrawingFolderAssignDate"), New System.Data.SqlClient.SqlParameter("@DesignWIPDate", System.Data.SqlDbType.NVarChar, 0, "DesignWIPDate"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@ModelTemplateDate", System.Data.SqlDbType.NVarChar, 0, "ModelTemplateDate"), New System.Data.SqlClient.SqlParameter("@Drafter", System.Data.SqlDbType.NVarChar, 0, "Drafter"), New System.Data.SqlClient.SqlParameter("@DrafterComplete", System.Data.SqlDbType.[Date], 0, "DrafterComplete"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@EngineerComplete", System.Data.SqlDbType.[Date], 0, "EngineerComplete"), New System.Data.SqlClient.SqlParameter("@SrEngineer", System.Data.SqlDbType.NVarChar, 0, "SrEngineer"), New System.Data.SqlClient.SqlParameter("@SrEngineerComplete", System.Data.SqlDbType.[Date], 0, "SrEngineerComplete"), New System.Data.SqlClient.SqlParameter("@Releaser", System.Data.SqlDbType.NVarChar, 0, "Releaser"), New System.Data.SqlClient.SqlParameter("@ReleaserCompelte", System.Data.SqlDbType.[Date], 0, "ReleaserCompelte"), New System.Data.SqlClient.SqlParameter("@Flammability", System.Data.SqlDbType.NVarChar, 0, "Flammability"), New System.Data.SqlClient.SqlParameter("@FlammabilityComplete", System.Data.SqlDbType.[Date], 0, "FlammabilityComplete"), New System.Data.SqlClient.SqlParameter("@Stress", System.Data.SqlDbType.NVarChar, 0, "Stress"), New System.Data.SqlClient.SqlParameter("@StressComplete", System.Data.SqlDbType.[Date], 0, "StressComplete"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@RefID", System.Data.SqlDbType.Int, 0, "RefID"), New System.Data.SqlClient.SqlParameter("@DrafterPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "DrafterPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@EngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "EngineerPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@SrEngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "SrEngineerPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@FlammabilityPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "FlammabilityPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@StressPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "StressPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@ReleaserPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "ReleaserPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@Avionics", System.Data.SqlDbType.NVarChar, 0, "Avionics"), New System.Data.SqlClient.SqlParameter("@AvionicsComplete", System.Data.SqlDbType.[Date], 0, "AvionicsComplete"), New System.Data.SqlClient.SqlParameter("@AvionicsPlannedComplete", System.Data.SqlDbType.[Date], 0, "AvionicsPlannedComplete"), New System.Data.SqlClient.SqlParameter("@Mechanical", System.Data.SqlDbType.NVarChar, 0, "Mechanical"), New System.Data.SqlClient.SqlParameter("@MechanicalComplete", System.Data.SqlDbType.[Date], 0, "MechanicalComplete"), New System.Data.SqlClient.SqlParameter("@MechanicalPlannedComplete", System.Data.SqlDbType.[Date], 0, "MechanicalPlannedComplete"), New System.Data.SqlClient.SqlParameter("@WONumber", System.Data.SqlDbType.NVarChar, 0, "WONumber"), New System.Data.SqlClient.SqlParameter("@NextHigherAssembly", System.Data.SqlDbType.NVarChar, 0, "NextHigherAssembly"), New System.Data.SqlClient.SqlParameter("@InstallationDrawing", System.Data.SqlDbType.NVarChar, 0, "InstallationDrawing"), New System.Data.SqlClient.SqlParameter("@WhiteBoardNumber", System.Data.SqlDbType.NVarChar, 0, "WhiteBoardNumber"), New System.Data.SqlClient.SqlParameter("@DRNADCN", System.Data.SqlDbType.NVarChar, 0, "DRNADCN"), New System.Data.SqlClient.SqlParameter("@DwgReqDate", System.Data.SqlDbType.[Date], 0, "DwgReqDate"), New System.Data.SqlClient.SqlParameter("@CompanyFlightTestRequired", System.Data.SqlDbType.NVarChar, 0, "CompanyFlightTestRequired"), New System.Data.SqlClient.SqlParameter("@PSCPDocsRequired", System.Data.SqlDbType.NVarChar, 0, "PSCPDocsRequired"), New System.Data.SqlClient.SqlParameter("@FAAProjectNo", System.Data.SqlDbType.NVarChar, 0, "FAAProjectNo"), New System.Data.SqlClient.SqlParameter("@NewRework", System.Data.SqlDbType.NVarChar, 0, "NewRework"), New System.Data.SqlClient.SqlParameter("@ADCN", System.Data.SqlDbType.NVarChar, 0, "ADCN"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocumentType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocumentType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Priority", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Priority", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRequestBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRequestBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRequestBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRequestBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRequestDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRequestDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRequestDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRequestDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SystemDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SystemDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LastActionDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastActionDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LastActionDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastActionDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ForecastStartDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ForecastStartDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ForecastStartDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ForecastStartDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ForecastFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ForecastFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ForecastFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ForecastFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannedFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannedFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannedFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannedFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EstimatedDurationHours", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EstimatedDurationHours", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EstimatedDurationHours", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EstimatedDurationHours", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PercentComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PercentComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PercentComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PercentComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingFolderAssignDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingFolderAssignDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingFolderAssignDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingFolderAssignDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignWIPDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignWIPDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignWIPDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignWIPDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ModelTemplateDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ModelTemplateDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ModelTemplateDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModelTemplateDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Drafter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Drafter", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Releaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Releaser", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserCompelte", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserCompelte", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Flammability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Flammability", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FlammabilityComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FlammabilityComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FlammabilityComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FlammabilityComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Stress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Stress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RefID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RefID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RefID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RefID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FlammabilityPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FlammabilityPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FlammabilityPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FlammabilityPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Avionics", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Avionics", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Avionics", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Avionics", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AvionicsComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AvionicsComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AvionicsComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AvionicsComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AvionicsPlannedComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AvionicsPlannedComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AvionicsPlannedComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AvionicsPlannedComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Mechanical", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Mechanical", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Mechanical", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mechanical", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MechanicalComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MechanicalComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MechanicalComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MechanicalComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MechanicalPlannedComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MechanicalPlannedComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MechanicalPlannedComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MechanicalPlannedComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WONumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WONumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WONumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WONumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NextHigherAssembly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NextHigherAssembly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NextHigherAssembly", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextHigherAssembly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_InstallationDrawing", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "InstallationDrawing", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_InstallationDrawing", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InstallationDrawing", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WhiteBoardNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WhiteBoardNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WhiteBoardNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WhiteBoardNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DRNADCN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DRNADCN", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DRNADCN", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DRNADCN", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgReqDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgReqDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgReqDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgReqDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CompanyFlightTestRequired", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CompanyFlightTestRequired", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CompanyFlightTestRequired", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyFlightTestRequired", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PSCPDocsRequired", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PSCPDocsRequired", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PSCPDocsRequired", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PSCPDocsRequired", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAProjectNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAProjectNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAProjectNo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAProjectNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NewRework", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NewRework", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NewRework", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NewRework", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ADCN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ADCN", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ADCN", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ADCN", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocumentType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocumentType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Priority", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Priority", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRequestBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRequestBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRequestBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRequestBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRequestDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRequestDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRequestDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRequestDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SystemDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SystemDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LastActionDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastActionDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LastActionDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastActionDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ForecastStartDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ForecastStartDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ForecastStartDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ForecastStartDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ForecastFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ForecastFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ForecastFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ForecastFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannedFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannedFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannedFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannedFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EstimatedDurationHours", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EstimatedDurationHours", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EstimatedDurationHours", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EstimatedDurationHours", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PercentComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PercentComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PercentComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PercentComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingFolderAssignDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingFolderAssignDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingFolderAssignDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingFolderAssignDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignWIPDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignWIPDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignWIPDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignWIPDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ModelTemplateDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ModelTemplateDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ModelTemplateDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModelTemplateDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Drafter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Drafter", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Releaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Releaser", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserCompelte", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserCompelte", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Flammability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Flammability", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FlammabilityComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FlammabilityComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FlammabilityComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FlammabilityComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Stress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Stress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RefID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RefID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RefID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RefID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FlammabilityPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FlammabilityPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FlammabilityPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FlammabilityPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Avionics", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Avionics", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Avionics", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Avionics", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AvionicsComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AvionicsComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AvionicsComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AvionicsComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AvionicsPlannedComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AvionicsPlannedComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AvionicsPlannedComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AvionicsPlannedComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Mechanical", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Mechanical", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Mechanical", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mechanical", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MechanicalComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MechanicalComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MechanicalComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MechanicalComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MechanicalPlannedComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MechanicalPlannedComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MechanicalPlannedComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MechanicalPlannedComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WONumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WONumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WONumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WONumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NextHigherAssembly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NextHigherAssembly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NextHigherAssembly", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextHigherAssembly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_InstallationDrawing", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "InstallationDrawing", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_InstallationDrawing", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InstallationDrawing", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WhiteBoardNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WhiteBoardNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WhiteBoardNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WhiteBoardNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DRNADCN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DRNADCN", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DRNADCN", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DRNADCN", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgReqDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgReqDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgReqDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgReqDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CompanyFlightTestRequired", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CompanyFlightTestRequired", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CompanyFlightTestRequired", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyFlightTestRequired", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PSCPDocsRequired", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PSCPDocsRequired", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PSCPDocsRequired", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PSCPDocsRequired", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAProjectNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAProjectNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAProjectNo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAProjectNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NewRework", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NewRework", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NewRework", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NewRework", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ADCN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ADCN", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ADCN", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ADCN", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawings", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DocumentType", "DocumentType"), New System.Data.Common.DataColumnMapping("Priority", "Priority"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("DwgRequestBy", "DwgRequestBy"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DwgRequestDate", "DwgRequestDate"), New System.Data.Common.DataColumnMapping("DrawingTitle", "DrawingTitle"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("DrawingType", "DrawingType"), New System.Data.Common.DataColumnMapping("SystemDescription", "SystemDescription"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("LastActionDate", "LastActionDate"), New System.Data.Common.DataColumnMapping("ActualFinishDate", "ActualFinishDate"), New System.Data.Common.DataColumnMapping("ForecastStartDate", "ForecastStartDate"), New System.Data.Common.DataColumnMapping("ForecastFinishDate", "ForecastFinishDate"), New System.Data.Common.DataColumnMapping("PlannedFinishDate", "PlannedFinishDate"), New System.Data.Common.DataColumnMapping("EstimatedDurationHours", "EstimatedDurationHours"), New System.Data.Common.DataColumnMapping("PercentComplete", "PercentComplete"), New System.Data.Common.DataColumnMapping("DrawingFolderAssignDate", "DrawingFolderAssignDate"), New System.Data.Common.DataColumnMapping("DesignWIPDate", "DesignWIPDate"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("ModelTemplateDate", "ModelTemplateDate"), New System.Data.Common.DataColumnMapping("Drafter", "Drafter"), New System.Data.Common.DataColumnMapping("DrafterComplete", "DrafterComplete"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerComplete", "EngineerComplete"), New System.Data.Common.DataColumnMapping("SrEngineer", "SrEngineer"), New System.Data.Common.DataColumnMapping("SrEngineerComplete", "SrEngineerComplete"), New System.Data.Common.DataColumnMapping("Releaser", "Releaser"), New System.Data.Common.DataColumnMapping("ReleaserCompelte", "ReleaserCompelte"), New System.Data.Common.DataColumnMapping("Flammability", "Flammability"), New System.Data.Common.DataColumnMapping("FlammabilityComplete", "FlammabilityComplete"), New System.Data.Common.DataColumnMapping("Stress", "Stress"), New System.Data.Common.DataColumnMapping("StressComplete", "StressComplete"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("RefID", "RefID"), New System.Data.Common.DataColumnMapping("DrafterPlannedCompleteDate", "DrafterPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("EngineerPlannedCompleteDate", "EngineerPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("SrEngineerPlannedCompleteDate", "SrEngineerPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("FlammabilityPlannedCompleteDate", "FlammabilityPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("StressPlannedCompleteDate", "StressPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("ReleaserPlannedCompleteDate", "ReleaserPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("Avionics", "Avionics"), New System.Data.Common.DataColumnMapping("AvionicsComplete", "AvionicsComplete"), New System.Data.Common.DataColumnMapping("AvionicsPlannedComplete", "AvionicsPlannedComplete"), New System.Data.Common.DataColumnMapping("Mechanical", "Mechanical"), New System.Data.Common.DataColumnMapping("MechanicalComplete", "MechanicalComplete"), New System.Data.Common.DataColumnMapping("MechanicalPlannedComplete", "MechanicalPlannedComplete"), New System.Data.Common.DataColumnMapping("WONumber", "WONumber"), New System.Data.Common.DataColumnMapping("NextHigherAssembly", "NextHigherAssembly"), New System.Data.Common.DataColumnMapping("InstallationDrawing", "InstallationDrawing"), New System.Data.Common.DataColumnMapping("WhiteBoardNumber", "WhiteBoardNumber"), New System.Data.Common.DataColumnMapping("DRNADCN", "DRNADCN"), New System.Data.Common.DataColumnMapping("DwgReqDate", "DwgReqDate"), New System.Data.Common.DataColumnMapping("CompanyFlightTestRequired", "CompanyFlightTestRequired"), New System.Data.Common.DataColumnMapping("PSCPDocsRequired", "PSCPDocsRequired"), New System.Data.Common.DataColumnMapping("FAAProjectNo", "FAAProjectNo"), New System.Data.Common.DataColumnMapping("NewRework", "NewRework"), New System.Data.Common.DataColumnMapping("ADCN", "ADCN")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'btnSaveGrid
        '
        Me.btnSaveGrid.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSaveGrid.Location = New System.Drawing.Point(740, 1045)
        Me.btnSaveGrid.Name = "btnSaveGrid"
        Me.btnSaveGrid.Size = New System.Drawing.Size(364, 66)
        Me.btnSaveGrid.TabIndex = 4
        Me.btnSaveGrid.Text = "Save Grid Data"
        Me.btnSaveGrid.UseVisualStyleBackColor = True
        '
        'btnEditandViewRow
        '
        Me.btnEditandViewRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditandViewRow.Location = New System.Drawing.Point(3, 1045)
        Me.btnEditandViewRow.Name = "btnEditandViewRow"
        Me.btnEditandViewRow.Size = New System.Drawing.Size(226, 66)
        Me.btnEditandViewRow.TabIndex = 5
        Me.btnEditandViewRow.Text = "Edit/View Row"
        Me.btnEditandViewRow.UseVisualStyleBackColor = True
        '
        'btnSubmitNewDrawingRequest
        '
        Me.btnSubmitNewDrawingRequest.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSubmitNewDrawingRequest.Location = New System.Drawing.Point(1110, 1045)
        Me.btnSubmitNewDrawingRequest.Name = "btnSubmitNewDrawingRequest"
        Me.btnSubmitNewDrawingRequest.Size = New System.Drawing.Size(292, 66)
        Me.btnSubmitNewDrawingRequest.TabIndex = 6
        Me.btnSubmitNewDrawingRequest.Text = "Submit New Drawing Request"
        Me.btnSubmitNewDrawingRequest.UseVisualStyleBackColor = True
        '
        'btnExportGrid
        '
        Me.btnExportGrid.Location = New System.Drawing.Point(1728, 3)
        Me.btnExportGrid.Name = "btnExportGrid"
        Me.btnExportGrid.Size = New System.Drawing.Size(390, 30)
        Me.btnExportGrid.TabIndex = 7
        Me.btnExportGrid.Text = "Export Grid"
        Me.btnExportGrid.UseVisualStyleBackColor = True
        '
        'txtLocation
        '
        Me.txtLocation.BackColor = System.Drawing.Color.White
        Me.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLocation.ForeColor = System.Drawing.Color.White
        Me.txtLocation.Location = New System.Drawing.Point(1302, 873)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(30, 20)
        Me.txtLocation.TabIndex = 8
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.Location = New System.Drawing.Point(1408, 1045)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(238, 66)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Location = New System.Drawing.Point(471, 1045)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(262, 66)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete current record"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'chkShowStageComplete
        '
        Me.chkShowStageComplete.Location = New System.Drawing.Point(1010, 4)
        Me.chkShowStageComplete.Name = "chkShowStageComplete"
        Me.chkShowStageComplete.Size = New System.Drawing.Size(304, 30)
        Me.chkShowStageComplete.TabIndex = 11
        Me.chkShowStageComplete.Text = "Show GATE 6: Complete"
        Me.chkShowStageComplete.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(1341, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(381, 30)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh Grid"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnReturnToMainMenu
        '
        Me.btnReturnToMainMenu.Location = New System.Drawing.Point(3, 3)
        Me.btnReturnToMainMenu.Name = "btnReturnToMainMenu"
        Me.btnReturnToMainMenu.Size = New System.Drawing.Size(142, 30)
        Me.btnReturnToMainMenu.TabIndex = 14
        Me.btnReturnToMainMenu.Text = "<< Return to Main Menu"
        Me.btnReturnToMainMenu.UseVisualStyleBackColor = True
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=Time;Persist Security Info=True;U" &
    "ser ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT DISTINCT Program" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblDrawings" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (Program IS NO" &
    "T NULL) AND (Program <> ' ')"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'ProgramsDataAdapter
        '
        Me.ProgramsDataAdapter.SelectCommand = Me.SqlSelectCommand2
        Me.ProgramsDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawings", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Program", "Program")})})
        '
        'dtsPrograms
        '
        Me.dtsPrograms.DataSetName = "dtsPrograms"
        Me.dtsPrograms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProgramsBindingSource
        '
        Me.ProgramsBindingSource.DataMember = "tblDrawings"
        Me.ProgramsBindingSource.DataSource = Me.dtsPrograms
        '
        'DsPrograms
        '
        Me.DsPrograms.DataSetName = "dsPrograms"
        Me.DsPrograms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(3, 39)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(0, 19)
        Me.LabelControl5.TabIndex = 21
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(1220, 3)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(0, 19)
        Me.LabelControl4.TabIndex = 20
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(672, 3)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(0, 19)
        Me.LabelControl3.TabIndex = 19
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(152, 3)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(0, 19)
        Me.LabelControl2.TabIndex = 18
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 1070)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(0, 19)
        Me.LabelControl1.TabIndex = 17
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(188, 24)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(438, 743)
        '
        'GroupControl1
        '
        Me.GroupControl1.AutoSize = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.btnDrawingCert)
        Me.GroupControl1.Controls.Add(Me.chkShowStageComplete)
        Me.GroupControl1.Controls.Add(Me.btnReturnToMainMenu)
        Me.GroupControl1.Controls.Add(Me.btnRefresh)
        Me.GroupControl1.Controls.Add(Me.btnDelete)
        Me.GroupControl1.Controls.Add(Me.btnExportGrid)
        Me.GroupControl1.Controls.Add(Me.btnClose)
        Me.GroupControl1.Controls.Add(Me.btnSaveGrid)
        Me.GroupControl1.Controls.Add(Me.btnEditandViewRow)
        Me.GroupControl1.Controls.Add(Me.btnSubmitNewDrawingRequest)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtRecordID)
        Me.GroupControl1.Controls.Add(Me.txtLocation)
        Me.GroupControl1.Controls.Add(Me.txtProgram)
        Me.GroupControl1.Controls.Add(Me.txtStatus)
        Me.GroupControl1.Controls.Add(Me.txtDrawingNumber)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 35)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(2151, 1159)
        Me.GroupControl1.TabIndex = 18
        Me.GroupControl1.Text = "Root"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(984, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 24
        '
        'btnDrawingCert
        '
        Me.btnDrawingCert.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDrawingCert.Location = New System.Drawing.Point(254, 1045)
        Me.btnDrawingCert.Name = "btnDrawingCert"
        Me.btnDrawingCert.Size = New System.Drawing.Size(210, 66)
        Me.btnDrawingCert.TabIndex = 22
        Me.btnDrawingCert.Text = "Certification Status"
        Me.btnDrawingCert.UseVisualStyleBackColor = True
        '
        'txtProgram
        '
        Me.txtProgram.Location = New System.Drawing.Point(924, 362)
        Me.txtProgram.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(148, 27)
        Me.txtProgram.TabIndex = 23
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(1020, 566)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(100, 27)
        Me.txtStatus.TabIndex = 25
        '
        'txtDrawingNumber
        '
        Me.txtDrawingNumber.Location = New System.Drawing.Point(862, 420)
        Me.txtDrawingNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDrawingNumber.Name = "txtDrawingNumber"
        Me.txtDrawingNumber.Size = New System.Drawing.Size(148, 27)
        Me.txtDrawingNumber.TabIndex = 26
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AdminToolStripMenuItem, Me.CertificationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(2151, 35)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem, Me.ProgramsToolStripMenuItem, Me.CertificationStaffToolStripMenuItem, Me.LovMaintenanceToolStripMenuItem, Me.ProjectServerWorkflowSyncToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(77, 29)
        Me.AdminToolStripMenuItem.Text = "&Admin"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(328, 30)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'ProgramsToolStripMenuItem
        '
        Me.ProgramsToolStripMenuItem.Name = "ProgramsToolStripMenuItem"
        Me.ProgramsToolStripMenuItem.Size = New System.Drawing.Size(328, 30)
        Me.ProgramsToolStripMenuItem.Text = "Programs"
        '
        'CertificationStaffToolStripMenuItem
        '
        Me.CertificationStaffToolStripMenuItem.Name = "CertificationStaffToolStripMenuItem"
        Me.CertificationStaffToolStripMenuItem.Size = New System.Drawing.Size(328, 30)
        Me.CertificationStaffToolStripMenuItem.Text = "Certification Staff"
        '
        'LovMaintenanceToolStripMenuItem
        '
        Me.LovMaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemDescriptionToolStripMenuItem, Me.DocumentTypeToolStripMenuItem, Me.ResourceTypeToolStripMenuItem, Me.NameAssignmentsToolStripMenuItem, Me.PriorityToolStripMenuItem, Me.DRNADCNToolStripMenuItem, Me.NewReworkToolStripMenuItem, Me.WhiteBoardToolStripMenuItem})
        Me.LovMaintenanceToolStripMenuItem.Name = "LovMaintenanceToolStripMenuItem"
        Me.LovMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(328, 30)
        Me.LovMaintenanceToolStripMenuItem.Text = "lov maintenance"
        '
        'SystemDescriptionToolStripMenuItem
        '
        Me.SystemDescriptionToolStripMenuItem.Name = "SystemDescriptionToolStripMenuItem"
        Me.SystemDescriptionToolStripMenuItem.Size = New System.Drawing.Size(250, 30)
        Me.SystemDescriptionToolStripMenuItem.Text = "System Description"
        '
        'DocumentTypeToolStripMenuItem
        '
        Me.DocumentTypeToolStripMenuItem.Name = "DocumentTypeToolStripMenuItem"
        Me.DocumentTypeToolStripMenuItem.Size = New System.Drawing.Size(250, 30)
        Me.DocumentTypeToolStripMenuItem.Text = "Document Type"
        '
        'ResourceTypeToolStripMenuItem
        '
        Me.ResourceTypeToolStripMenuItem.Name = "ResourceTypeToolStripMenuItem"
        Me.ResourceTypeToolStripMenuItem.Size = New System.Drawing.Size(250, 30)
        Me.ResourceTypeToolStripMenuItem.Text = "Resource Type"
        '
        'NameAssignmentsToolStripMenuItem
        '
        Me.NameAssignmentsToolStripMenuItem.Name = "NameAssignmentsToolStripMenuItem"
        Me.NameAssignmentsToolStripMenuItem.Size = New System.Drawing.Size(250, 30)
        Me.NameAssignmentsToolStripMenuItem.Text = "Name Assignments"
        '
        'PriorityToolStripMenuItem
        '
        Me.PriorityToolStripMenuItem.Name = "PriorityToolStripMenuItem"
        Me.PriorityToolStripMenuItem.Size = New System.Drawing.Size(250, 30)
        Me.PriorityToolStripMenuItem.Text = "Priority"
        '
        'DRNADCNToolStripMenuItem
        '
        Me.DRNADCNToolStripMenuItem.Name = "DRNADCNToolStripMenuItem"
        Me.DRNADCNToolStripMenuItem.Size = New System.Drawing.Size(250, 30)
        Me.DRNADCNToolStripMenuItem.Text = "DRNADCN"
        '
        'NewReworkToolStripMenuItem
        '
        Me.NewReworkToolStripMenuItem.Name = "NewReworkToolStripMenuItem"
        Me.NewReworkToolStripMenuItem.Size = New System.Drawing.Size(250, 30)
        Me.NewReworkToolStripMenuItem.Text = "New/Rework"
        '
        'WhiteBoardToolStripMenuItem
        '
        Me.WhiteBoardToolStripMenuItem.Name = "WhiteBoardToolStripMenuItem"
        Me.WhiteBoardToolStripMenuItem.Size = New System.Drawing.Size(250, 30)
        Me.WhiteBoardToolStripMenuItem.Text = "White Board"
        '
        'ProjectServerWorkflowSyncToolStripMenuItem
        '
        Me.ProjectServerWorkflowSyncToolStripMenuItem.Enabled = False
        Me.ProjectServerWorkflowSyncToolStripMenuItem.Name = "ProjectServerWorkflowSyncToolStripMenuItem"
        Me.ProjectServerWorkflowSyncToolStripMenuItem.Size = New System.Drawing.Size(328, 30)
        Me.ProjectServerWorkflowSyncToolStripMenuItem.Text = "Project Server/Workflow Sync"
        '
        'CertificationToolStripMenuItem
        '
        Me.CertificationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CertificationFilterGridToolStripMenuItem, Me.CertificationMassUpdateToolStripMenuItem})
        Me.CertificationToolStripMenuItem.Name = "CertificationToolStripMenuItem"
        Me.CertificationToolStripMenuItem.Size = New System.Drawing.Size(118, 29)
        Me.CertificationToolStripMenuItem.Text = "Certification"
        '
        'CertificationFilterGridToolStripMenuItem
        '
        Me.CertificationFilterGridToolStripMenuItem.Name = "CertificationFilterGridToolStripMenuItem"
        Me.CertificationFilterGridToolStripMenuItem.Size = New System.Drawing.Size(299, 30)
        Me.CertificationFilterGridToolStripMenuItem.Text = "Certification Filter Grid"
        '
        'CertificationMassUpdateToolStripMenuItem
        '
        Me.CertificationMassUpdateToolStripMenuItem.Name = "CertificationMassUpdateToolStripMenuItem"
        Me.CertificationMassUpdateToolStripMenuItem.Size = New System.Drawing.Size(299, 30)
        Me.CertificationMassUpdateToolStripMenuItem.Text = "Certification Mass Update"
        '
        'frmGridLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(2151, 1194)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGridLookUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Field Engineering Drawing Status System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsPrograms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrograms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
	Friend WithEvents txtRecordID As TextBox
	Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
	Friend WithEvents BindingSource2 As BindingSource
	Friend WithEvents DataSet21 As DataSet2
	Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colPriority As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
	Friend WithEvents colDwgRequestBy As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDrawingNumber As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDwgRequestDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDrawingTitle As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colProgram As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
	Friend WithEvents colDrawingType As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents RepositoryItemComboBox5 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
	Friend WithEvents colSystemDescription As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
	Friend WithEvents colLastActionDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colActualFinishDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPlannedFinishDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colForecastFinishDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPercentComplete As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDrawingFolderAssignDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDesignWIPDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colModelTemplateDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDrafter As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDrafterComplete As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colEngineer As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colEngineerComplete As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSrEngineer As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSrEngineerComplete As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colReleaser As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colReleaserCompelte As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colFlammability As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colFlammabilityComplete As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colStress As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colStressComplete As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDwgRevision As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents RepositoryItemComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
	Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
	Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
	Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
	Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
	Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
	Friend WithEvents btnSaveGrid As Button
	Friend WithEvents btnEditandViewRow As Button
	Friend WithEvents btnSubmitNewDrawingRequest As Button
	Friend WithEvents btnExportGrid As Button
	Friend WithEvents txtLocation As TextBox
	Friend WithEvents btnClose As Button
	Friend WithEvents colMechanical As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMechanicalComplete As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colMechanicalPlannedComplete As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colAvionics As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colAvionicsComplete As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colAvionicsPlannedComplete As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colDrafterPlannedCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colEngineerPlannedCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSrEngineerPlannedCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colReleaserPlannedCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colFlammabilityPlannedCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnDelete As Button
	Friend WithEvents chkShowStageComplete As CheckBox
	Friend WithEvents btnRefresh As Button
    Friend WithEvents btnReturnToMainMenu As Button
    Friend WithEvents RepositoryItemComboBox6 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox7 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents colWONumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ForecastStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EstimatedDurationHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNextHigherAssembly As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents ProgramsDataAdapter As SqlClient.SqlDataAdapter
    Friend WithEvents dtsPrograms As dtsPrograms
    Friend WithEvents ProgramsBindingSource As BindingSource
    Friend WithEvents DsPrograms As dsPrograms
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colInstallationDrawing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhiteBoardNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CertificationStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnDrawingCert As Button
    Friend WithEvents LovMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemDescriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents colDwgReqDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DocumentTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResourceTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NameAssignmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PriorityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DRNADCNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewReworkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents colNewRework As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents WhiteBoardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RepositoryItemComboBox8 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents ProjectServerWorkflowSyncToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtDrawingNumber As TextBox
    Friend WithEvents CertificationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CertificationFilterGridToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CertificationMassUpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents colADCN As DevExpress.XtraGrid.Columns.GridColumn
End Class
