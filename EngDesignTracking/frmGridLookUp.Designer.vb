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
        Me.btnAdminUsers = New System.Windows.Forms.Button()
        Me.btnAdminPrograms = New System.Windows.Forms.Button()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.ProgramsDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
        Me.dtsPrograms = New EngDesignTracking.dtsPrograms()
        Me.ProgramsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPrograms = New EngDesignTracking.dsPrograms()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.frmGridLookUpLayoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRecordIDitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtLocationitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.chkShowStageCompleteitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnAdminProgramsitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnAdminUsersitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnReturnToMainMenuitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnRefreshitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnDeleteitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridControl1item = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnExportGriditem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnCloseitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnSaveGriditem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnEditandViewRowitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnSubmitNewDrawingRequestitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.frmGridLookUpLayoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmGridLookUpLayoutControl1ConvertedLayout.SuspendLayout()
        CType(Me.txtRecordIDitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocationitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowStageCompleteitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdminProgramsitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdminUsersitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnReturnToMainMenuitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefreshitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportGriditem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveGriditem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditandViewRowitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSubmitNewDrawingRequestitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtRecordID.Location = New System.Drawing.Point(566, 680)
        Me.txtRecordID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(265, 20)
        Me.txtRecordID.TabIndex = 2
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource2
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(12, 53)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3, Me.RepositoryItemComboBox4, Me.RepositoryItemComboBox5, Me.RepositoryItemComboBox6, Me.RepositoryItemComboBox7})
        Me.GridControl1.Size = New System.Drawing.Size(1410, 705)
        Me.GridControl1.TabIndex = 3
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgram, Me.colLocation, Me.colPriority, Me.colType, Me.colDwgRequestBy, Me.colDrawingNumber, Me.colWONumber, Me.colDwgRevision, Me.colDwgRequestDate, Me.colDrawingTitle, Me.colDrawingType, Me.colSystemDescription, Me.colStatus, Me.colLastActionDate, Me.colActualFinishDate, Me.colPlannedFinishDate, Me.colForecastFinishDate, Me.colPercentComplete, Me.colDrawingFolderAssignDate, Me.colDesignWIPDate, Me.colNotes, Me.colModelTemplateDate, Me.colDrafter, Me.colDrafterComplete, Me.colDrafterPlannedCompleteDate, Me.colEngineer, Me.colEngineerComplete, Me.colEngineerPlannedCompleteDate, Me.colSrEngineer, Me.colSrEngineerComplete, Me.colSrEngineerPlannedCompleteDate, Me.colMechanical, Me.colMechanicalComplete, Me.colMechanicalPlannedComplete, Me.colAvionics, Me.colAvionicsComplete, Me.colAvionicsPlannedComplete, Me.colReleaser, Me.colReleaserCompelte, Me.colReleaserPlannedCompleteDate, Me.colFlammability, Me.colFlammabilityComplete, Me.colFlammabilityPlannedCompleteDate, Me.colStress, Me.colStressComplete, Me.ForecastStartDate, Me.EstimatedDurationHours, Me.colNextHigherAssembly})
        Me.GridView1.DetailHeight = 174
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
        Me.GridView1.PreviewIndent = 0
        Me.GridView1.RowHeight = 0
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colProgram, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPriority, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.GridView1.ViewCaptionHeight = 0
        '
        'colProgram
        '
        Me.colProgram.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colProgram.DisplayFormat.FormatString = "d"
        Me.colProgram.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colProgram.FieldName = "Program"
        Me.colProgram.Name = "colProgram"
        Me.colProgram.Visible = True
        Me.colProgram.VisibleIndex = 1
        Me.colProgram.Width = 74
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
        Me.colLocation.Name = "colLocation"
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 2
        Me.colLocation.Width = 74
        '
        'RepositoryItemComboBox6
        '
        Me.RepositoryItemComboBox6.AutoHeight = False
        Me.RepositoryItemComboBox6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox6.Items.AddRange(New Object() {"Calgary", "OKC", "Toronto"})
        Me.RepositoryItemComboBox6.Name = "RepositoryItemComboBox6"
        '
        'colPriority
        '
        Me.colPriority.ColumnEdit = Me.RepositoryItemComboBox7
        Me.colPriority.FieldName = "Priority"
        Me.colPriority.Name = "colPriority"
        Me.colPriority.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colPriority.Visible = True
        Me.colPriority.VisibleIndex = 0
        Me.colPriority.Width = 74
        '
        'RepositoryItemComboBox7
        '
        Me.RepositoryItemComboBox7.AutoHeight = False
        Me.RepositoryItemComboBox7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox7.Items.AddRange(New Object() {"Low", "Normal", "High", "ON HOLD"})
        Me.RepositoryItemComboBox7.Name = "RepositoryItemComboBox7"
        '
        'colType
        '
        Me.colType.ColumnEdit = Me.RepositoryItemComboBox3
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 3
        Me.colType.Width = 74
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Items.AddRange(New Object() {"M", "E", "S", "RWK", "RPT"})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        Me.RepositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colDwgRequestBy
        '
        Me.colDwgRequestBy.FieldName = "DwgRequestBy"
        Me.colDwgRequestBy.Name = "colDwgRequestBy"
        Me.colDwgRequestBy.Visible = True
        Me.colDwgRequestBy.VisibleIndex = 28
        Me.colDwgRequestBy.Width = 74
        '
        'colDrawingNumber
        '
        Me.colDrawingNumber.FieldName = "DrawingNumber"
        Me.colDrawingNumber.Name = "colDrawingNumber"
        Me.colDrawingNumber.Visible = True
        Me.colDrawingNumber.VisibleIndex = 4
        Me.colDrawingNumber.Width = 74
        '
        'colWONumber
        '
        Me.colWONumber.Caption = "WO Number"
        Me.colWONumber.FieldName = "WONumber"
        Me.colWONumber.Name = "colWONumber"
        Me.colWONumber.Visible = True
        Me.colWONumber.VisibleIndex = 19
        '
        'colDwgRevision
        '
        Me.colDwgRevision.FieldName = "DwgRevision"
        Me.colDwgRevision.Name = "colDwgRevision"
        Me.colDwgRevision.Visible = True
        Me.colDwgRevision.VisibleIndex = 5
        Me.colDwgRevision.Width = 74
        '
        'colDwgRequestDate
        '
        Me.colDwgRequestDate.FieldName = "DwgRequestDate"
        Me.colDwgRequestDate.Name = "colDwgRequestDate"
        Me.colDwgRequestDate.Visible = True
        Me.colDwgRequestDate.VisibleIndex = 29
        Me.colDwgRequestDate.Width = 74
        '
        'colDrawingTitle
        '
        Me.colDrawingTitle.FieldName = "DrawingTitle"
        Me.colDrawingTitle.Name = "colDrawingTitle"
        Me.colDrawingTitle.Visible = True
        Me.colDrawingTitle.VisibleIndex = 6
        Me.colDrawingTitle.Width = 230
        '
        'colDrawingType
        '
        Me.colDrawingType.ColumnEdit = Me.RepositoryItemComboBox5
        Me.colDrawingType.FieldName = "DrawingType"
        Me.colDrawingType.Name = "colDrawingType"
        Me.colDrawingType.Visible = True
        Me.colDrawingType.VisibleIndex = 20
        Me.colDrawingType.Width = 74
        '
        'RepositoryItemComboBox5
        '
        Me.RepositoryItemComboBox5.AutoHeight = False
        Me.RepositoryItemComboBox5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox5.Items.AddRange(New Object() {"Assembly", "Detail", "General Arrangement", "Harness Assembly", "Installation", "Provisions", "Rework", "Specification", "Tooling", "Wire Diagram", "Wire Routing Diagram", "Report", "Presentation", "Repair"})
        Me.RepositoryItemComboBox5.Name = "RepositoryItemComboBox5"
        '
        'colSystemDescription
        '
        Me.colSystemDescription.FieldName = "SystemDescription"
        Me.colSystemDescription.Name = "colSystemDescription"
        Me.colSystemDescription.Visible = True
        Me.colSystemDescription.VisibleIndex = 7
        Me.colSystemDescription.Width = 230
        '
        'colStatus
        '
        Me.colStatus.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 8
        Me.colStatus.Width = 230
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"GATE 0: CM Needs To Assign DWG Number", "GATE 1: WIP", "GATE 2: DWG Ready For Review", "GATE 3: DWG Ready For Checker/Engineer", "GATE 4: DWG Ready For Stress", "GATE 5: DWG Ready For Flammability", "GATE 6: DWG Ready For Sr Engineer", "GATE 7: DWG Ready For Release", "GATE 8 : DWG Released"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'colLastActionDate
        '
        Me.colLastActionDate.FieldName = "LastActionDate"
        Me.colLastActionDate.Name = "colLastActionDate"
        Me.colLastActionDate.Visible = True
        Me.colLastActionDate.VisibleIndex = 30
        Me.colLastActionDate.Width = 74
        '
        'colActualFinishDate
        '
        Me.colActualFinishDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colActualFinishDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualFinishDate.FieldName = "ActualFinishDate"
        Me.colActualFinishDate.Name = "colActualFinishDate"
        Me.colActualFinishDate.Visible = True
        Me.colActualFinishDate.VisibleIndex = 31
        Me.colActualFinishDate.Width = 74
        '
        'colPlannedFinishDate
        '
        Me.colPlannedFinishDate.Caption = "Baseline Finish Date (IMS)"
        Me.colPlannedFinishDate.DisplayFormat.FormatString = "d"
        Me.colPlannedFinishDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPlannedFinishDate.FieldName = "PlannedFinishDate"
        Me.colPlannedFinishDate.Name = "colPlannedFinishDate"
        Me.colPlannedFinishDate.Visible = True
        Me.colPlannedFinishDate.VisibleIndex = 17
        Me.colPlannedFinishDate.Width = 74
        '
        'colForecastFinishDate
        '
        Me.colForecastFinishDate.Caption = "Forecast Finish Date"
        Me.colForecastFinishDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colForecastFinishDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colForecastFinishDate.FieldName = "ForecastFinishDate"
        Me.colForecastFinishDate.Name = "colForecastFinishDate"
        Me.colForecastFinishDate.Visible = True
        Me.colForecastFinishDate.VisibleIndex = 16
        Me.colForecastFinishDate.Width = 74
        '
        'colPercentComplete
        '
        Me.colPercentComplete.FieldName = "PercentComplete"
        Me.colPercentComplete.Name = "colPercentComplete"
        Me.colPercentComplete.Visible = True
        Me.colPercentComplete.VisibleIndex = 32
        Me.colPercentComplete.Width = 74
        '
        'colDrawingFolderAssignDate
        '
        Me.colDrawingFolderAssignDate.FieldName = "DrawingFolderAssignDate"
        Me.colDrawingFolderAssignDate.Name = "colDrawingFolderAssignDate"
        Me.colDrawingFolderAssignDate.Visible = True
        Me.colDrawingFolderAssignDate.VisibleIndex = 33
        Me.colDrawingFolderAssignDate.Width = 74
        '
        'colDesignWIPDate
        '
        Me.colDesignWIPDate.FieldName = "DesignWIPDate"
        Me.colDesignWIPDate.Name = "colDesignWIPDate"
        Me.colDesignWIPDate.Visible = True
        Me.colDesignWIPDate.VisibleIndex = 34
        Me.colDesignWIPDate.Width = 74
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 10
        Me.colNotes.Width = 230
        '
        'colModelTemplateDate
        '
        Me.colModelTemplateDate.FieldName = "ModelTemplateDate"
        Me.colModelTemplateDate.Name = "colModelTemplateDate"
        Me.colModelTemplateDate.Visible = True
        Me.colModelTemplateDate.VisibleIndex = 35
        Me.colModelTemplateDate.Width = 74
        '
        'colDrafter
        '
        Me.colDrafter.FieldName = "Drafter"
        Me.colDrafter.Name = "colDrafter"
        Me.colDrafter.Visible = True
        Me.colDrafter.VisibleIndex = 9
        Me.colDrafter.Width = 74
        '
        'colDrafterComplete
        '
        Me.colDrafterComplete.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colDrafterComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDrafterComplete.FieldName = "DrafterComplete"
        Me.colDrafterComplete.GroupFormat.FormatString = "MM/dd/yyyy"
        Me.colDrafterComplete.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDrafterComplete.Name = "colDrafterComplete"
        Me.colDrafterComplete.Visible = True
        Me.colDrafterComplete.VisibleIndex = 21
        Me.colDrafterComplete.Width = 74
        '
        'colDrafterPlannedCompleteDate
        '
        Me.colDrafterPlannedCompleteDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colDrafterPlannedCompleteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDrafterPlannedCompleteDate.FieldName = "DrafterPlannedCompleteDate"
        Me.colDrafterPlannedCompleteDate.Name = "colDrafterPlannedCompleteDate"
        Me.colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.colDrafterPlannedCompleteDate.Visible = True
        Me.colDrafterPlannedCompleteDate.VisibleIndex = 11
        Me.colDrafterPlannedCompleteDate.Width = 74
        '
        'colEngineer
        '
        Me.colEngineer.FieldName = "Engineer"
        Me.colEngineer.Name = "colEngineer"
        Me.colEngineer.Visible = True
        Me.colEngineer.VisibleIndex = 22
        Me.colEngineer.Width = 74
        '
        'colEngineerComplete
        '
        Me.colEngineerComplete.FieldName = "EngineerComplete"
        Me.colEngineerComplete.Name = "colEngineerComplete"
        Me.colEngineerComplete.Visible = True
        Me.colEngineerComplete.VisibleIndex = 23
        Me.colEngineerComplete.Width = 74
        '
        'colEngineerPlannedCompleteDate
        '
        Me.colEngineerPlannedCompleteDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colEngineerPlannedCompleteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEngineerPlannedCompleteDate.FieldName = "EngineerPlannedCompleteDate"
        Me.colEngineerPlannedCompleteDate.Name = "colEngineerPlannedCompleteDate"
        Me.colEngineerPlannedCompleteDate.Visible = True
        Me.colEngineerPlannedCompleteDate.VisibleIndex = 12
        Me.colEngineerPlannedCompleteDate.Width = 74
        '
        'colSrEngineer
        '
        Me.colSrEngineer.FieldName = "SrEngineer"
        Me.colSrEngineer.Name = "colSrEngineer"
        Me.colSrEngineer.Visible = True
        Me.colSrEngineer.VisibleIndex = 24
        Me.colSrEngineer.Width = 74
        '
        'colSrEngineerComplete
        '
        Me.colSrEngineerComplete.FieldName = "SrEngineerComplete"
        Me.colSrEngineerComplete.Name = "colSrEngineerComplete"
        Me.colSrEngineerComplete.Visible = True
        Me.colSrEngineerComplete.VisibleIndex = 25
        Me.colSrEngineerComplete.Width = 74
        '
        'colSrEngineerPlannedCompleteDate
        '
        Me.colSrEngineerPlannedCompleteDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colSrEngineerPlannedCompleteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSrEngineerPlannedCompleteDate.FieldName = "SrEngineerPlannedCompleteDate"
        Me.colSrEngineerPlannedCompleteDate.Name = "colSrEngineerPlannedCompleteDate"
        Me.colSrEngineerPlannedCompleteDate.Visible = True
        Me.colSrEngineerPlannedCompleteDate.VisibleIndex = 13
        Me.colSrEngineerPlannedCompleteDate.Width = 74
        '
        'colMechanical
        '
        Me.colMechanical.FieldName = "Mechanical"
        Me.colMechanical.Name = "colMechanical"
        Me.colMechanical.Visible = True
        Me.colMechanical.VisibleIndex = 36
        Me.colMechanical.Width = 74
        '
        'colMechanicalComplete
        '
        Me.colMechanicalComplete.FieldName = "MechanicalComplete"
        Me.colMechanicalComplete.Name = "colMechanicalComplete"
        Me.colMechanicalComplete.Visible = True
        Me.colMechanicalComplete.VisibleIndex = 37
        Me.colMechanicalComplete.Width = 74
        '
        'colMechanicalPlannedComplete
        '
        Me.colMechanicalPlannedComplete.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colMechanicalPlannedComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colMechanicalPlannedComplete.FieldName = "MechanicalPlannedComplete"
        Me.colMechanicalPlannedComplete.Name = "colMechanicalPlannedComplete"
        Me.colMechanicalPlannedComplete.Visible = True
        Me.colMechanicalPlannedComplete.VisibleIndex = 38
        Me.colMechanicalPlannedComplete.Width = 74
        '
        'colAvionics
        '
        Me.colAvionics.FieldName = "Avionics"
        Me.colAvionics.Name = "colAvionics"
        Me.colAvionics.Visible = True
        Me.colAvionics.VisibleIndex = 40
        Me.colAvionics.Width = 74
        '
        'colAvionicsComplete
        '
        Me.colAvionicsComplete.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colAvionicsComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colAvionicsComplete.FieldName = "AvionicsComplete"
        Me.colAvionicsComplete.Name = "colAvionicsComplete"
        Me.colAvionicsComplete.Visible = True
        Me.colAvionicsComplete.VisibleIndex = 39
        Me.colAvionicsComplete.Width = 74
        '
        'colAvionicsPlannedComplete
        '
        Me.colAvionicsPlannedComplete.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colAvionicsPlannedComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colAvionicsPlannedComplete.FieldName = "AvionicsPlannedComplete"
        Me.colAvionicsPlannedComplete.Name = "colAvionicsPlannedComplete"
        Me.colAvionicsPlannedComplete.Visible = True
        Me.colAvionicsPlannedComplete.VisibleIndex = 41
        Me.colAvionicsPlannedComplete.Width = 74
        '
        'colReleaser
        '
        Me.colReleaser.FieldName = "Releaser"
        Me.colReleaser.Name = "colReleaser"
        Me.colReleaser.Visible = True
        Me.colReleaser.VisibleIndex = 26
        Me.colReleaser.Width = 74
        '
        'colReleaserCompelte
        '
        Me.colReleaserCompelte.Caption = "Releaser Complete"
        Me.colReleaserCompelte.FieldName = "ReleaserCompelte"
        Me.colReleaserCompelte.Name = "colReleaserCompelte"
        Me.colReleaserCompelte.Visible = True
        Me.colReleaserCompelte.VisibleIndex = 27
        Me.colReleaserCompelte.Width = 74
        '
        'colReleaserPlannedCompleteDate
        '
        Me.colReleaserPlannedCompleteDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colReleaserPlannedCompleteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colReleaserPlannedCompleteDate.FieldName = "ReleaserPlannedCompleteDate"
        Me.colReleaserPlannedCompleteDate.Name = "colReleaserPlannedCompleteDate"
        Me.colReleaserPlannedCompleteDate.Visible = True
        Me.colReleaserPlannedCompleteDate.VisibleIndex = 14
        Me.colReleaserPlannedCompleteDate.Width = 74
        '
        'colFlammability
        '
        Me.colFlammability.FieldName = "Flammability"
        Me.colFlammability.Name = "colFlammability"
        Me.colFlammability.Visible = True
        Me.colFlammability.VisibleIndex = 42
        Me.colFlammability.Width = 74
        '
        'colFlammabilityComplete
        '
        Me.colFlammabilityComplete.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colFlammabilityComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFlammabilityComplete.FieldName = "FlammabilityComplete"
        Me.colFlammabilityComplete.Name = "colFlammabilityComplete"
        Me.colFlammabilityComplete.Visible = True
        Me.colFlammabilityComplete.VisibleIndex = 43
        Me.colFlammabilityComplete.Width = 74
        '
        'colFlammabilityPlannedCompleteDate
        '
        Me.colFlammabilityPlannedCompleteDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colFlammabilityPlannedCompleteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFlammabilityPlannedCompleteDate.FieldName = "FlammabilityPlannedCompleteDate"
        Me.colFlammabilityPlannedCompleteDate.Name = "colFlammabilityPlannedCompleteDate"
        Me.colFlammabilityPlannedCompleteDate.Visible = True
        Me.colFlammabilityPlannedCompleteDate.VisibleIndex = 46
        Me.colFlammabilityPlannedCompleteDate.Width = 74
        '
        'colStress
        '
        Me.colStress.FieldName = "Stress"
        Me.colStress.Name = "colStress"
        Me.colStress.Visible = True
        Me.colStress.VisibleIndex = 44
        Me.colStress.Width = 74
        '
        'colStressComplete
        '
        Me.colStressComplete.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colStressComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colStressComplete.FieldName = "StressComplete"
        Me.colStressComplete.Name = "colStressComplete"
        Me.colStressComplete.Visible = True
        Me.colStressComplete.VisibleIndex = 45
        Me.colStressComplete.Width = 74
        '
        'ForecastStartDate
        '
        Me.ForecastStartDate.Caption = "Forecast Start Date"
        Me.ForecastStartDate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.ForecastStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ForecastStartDate.FieldName = "ForecastStartDate"
        Me.ForecastStartDate.Name = "ForecastStartDate"
        Me.ForecastStartDate.Visible = True
        Me.ForecastStartDate.VisibleIndex = 15
        '
        'EstimatedDurationHours
        '
        Me.EstimatedDurationHours.Caption = "Estimated Duration Hours"
        Me.EstimatedDurationHours.FieldName = "EstimatedDurationHours"
        Me.EstimatedDurationHours.Name = "EstimatedDurationHours"
        Me.EstimatedDurationHours.Visible = True
        Me.EstimatedDurationHours.VisibleIndex = 18
        '
        'colNextHigherAssembly
        '
        Me.colNextHigherAssembly.Caption = "Next Higher Assembly"
        Me.colNextHigherAssembly.FieldName = "NextHigherAssembly"
        Me.colNextHigherAssembly.Name = "colNextHigherAssembly"
        Me.colNextHigherAssembly.Visible = True
        Me.colNextHigherAssembly.VisibleIndex = 47
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DocumentType", System.Data.SqlDbType.NVarChar, 0, "DocumentType"), New System.Data.SqlClient.SqlParameter("@Priority", System.Data.SqlDbType.NVarChar, 0, "Priority"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@DwgRequestBy", System.Data.SqlDbType.NVarChar, 0, "DwgRequestBy"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRequestDate", System.Data.SqlDbType.NVarChar, 0, "DwgRequestDate"), New System.Data.SqlClient.SqlParameter("@DrawingTitle", System.Data.SqlDbType.NVarChar, 0, "DrawingTitle"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@DrawingType", System.Data.SqlDbType.NVarChar, 0, "DrawingType"), New System.Data.SqlClient.SqlParameter("@SystemDescription", System.Data.SqlDbType.NVarChar, 0, "SystemDescription"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@LastActionDate", System.Data.SqlDbType.NVarChar, 0, "LastActionDate"), New System.Data.SqlClient.SqlParameter("@ActualFinishDate", System.Data.SqlDbType.[Date], 0, "ActualFinishDate"), New System.Data.SqlClient.SqlParameter("@ForecastFinishDate", System.Data.SqlDbType.[Date], 0, "ForecastFinishDate"), New System.Data.SqlClient.SqlParameter("@PlannedFinishDate", System.Data.SqlDbType.[Date], 0, "PlannedFinishDate"), New System.Data.SqlClient.SqlParameter("@PercentComplete", System.Data.SqlDbType.NVarChar, 0, "PercentComplete"), New System.Data.SqlClient.SqlParameter("@DrawingFolderAssignDate", System.Data.SqlDbType.NVarChar, 0, "DrawingFolderAssignDate"), New System.Data.SqlClient.SqlParameter("@DesignWIPDate", System.Data.SqlDbType.NVarChar, 0, "DesignWIPDate"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@ModelTemplateDate", System.Data.SqlDbType.NVarChar, 0, "ModelTemplateDate"), New System.Data.SqlClient.SqlParameter("@Drafter", System.Data.SqlDbType.NVarChar, 0, "Drafter"), New System.Data.SqlClient.SqlParameter("@DrafterComplete", System.Data.SqlDbType.[Date], 0, "DrafterComplete"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@EngineerComplete", System.Data.SqlDbType.[Date], 0, "EngineerComplete"), New System.Data.SqlClient.SqlParameter("@SrEngineer", System.Data.SqlDbType.NVarChar, 0, "SrEngineer"), New System.Data.SqlClient.SqlParameter("@SrEngineerComplete", System.Data.SqlDbType.[Date], 0, "SrEngineerComplete"), New System.Data.SqlClient.SqlParameter("@Releaser", System.Data.SqlDbType.NVarChar, 0, "Releaser"), New System.Data.SqlClient.SqlParameter("@ReleaserCompelte", System.Data.SqlDbType.[Date], 0, "ReleaserCompelte"), New System.Data.SqlClient.SqlParameter("@Flammability", System.Data.SqlDbType.NVarChar, 0, "Flammability"), New System.Data.SqlClient.SqlParameter("@FlammabilityComplete", System.Data.SqlDbType.[Date], 0, "FlammabilityComplete"), New System.Data.SqlClient.SqlParameter("@Stress", System.Data.SqlDbType.NVarChar, 0, "Stress"), New System.Data.SqlClient.SqlParameter("@StressComplete", System.Data.SqlDbType.[Date], 0, "StressComplete"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@RefID", System.Data.SqlDbType.Int, 0, "RefID"), New System.Data.SqlClient.SqlParameter("@DrafterPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "DrafterPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@EngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "EngineerPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@SrEngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "SrEngineerPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@FlammabilityPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "FlammabilityPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@StressPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "StressPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@ReleaserPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "ReleaserPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@Avionics", System.Data.SqlDbType.NVarChar, 0, "Avionics"), New System.Data.SqlClient.SqlParameter("@AvionicsComplete", System.Data.SqlDbType.[Date], 0, "AvionicsComplete"), New System.Data.SqlClient.SqlParameter("@AvionicsPlannedComplete", System.Data.SqlDbType.[Date], 0, "AvionicsPlannedComplete"), New System.Data.SqlClient.SqlParameter("@Mechanical", System.Data.SqlDbType.NVarChar, 0, "Mechanical"), New System.Data.SqlClient.SqlParameter("@MechanicalComplete", System.Data.SqlDbType.[Date], 0, "MechanicalComplete"), New System.Data.SqlClient.SqlParameter("@MechanicalPlannedComplete", System.Data.SqlDbType.[Date], 0, "MechanicalPlannedComplete"), New System.Data.SqlClient.SqlParameter("@WONumber", System.Data.SqlDbType.NVarChar, 0, "WONumber")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DocumentType", System.Data.SqlDbType.NVarChar, 0, "DocumentType"), New System.Data.SqlClient.SqlParameter("@Priority", System.Data.SqlDbType.NVarChar, 0, "Priority"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@DwgRequestBy", System.Data.SqlDbType.NVarChar, 0, "DwgRequestBy"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRequestDate", System.Data.SqlDbType.NVarChar, 0, "DwgRequestDate"), New System.Data.SqlClient.SqlParameter("@DrawingTitle", System.Data.SqlDbType.NVarChar, 0, "DrawingTitle"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@DrawingType", System.Data.SqlDbType.NVarChar, 0, "DrawingType"), New System.Data.SqlClient.SqlParameter("@SystemDescription", System.Data.SqlDbType.NVarChar, 0, "SystemDescription"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@LastActionDate", System.Data.SqlDbType.NVarChar, 0, "LastActionDate"), New System.Data.SqlClient.SqlParameter("@ActualFinishDate", System.Data.SqlDbType.[Date], 0, "ActualFinishDate"), New System.Data.SqlClient.SqlParameter("@ForecastFinishDate", System.Data.SqlDbType.[Date], 0, "ForecastFinishDate"), New System.Data.SqlClient.SqlParameter("@PlannedFinishDate", System.Data.SqlDbType.[Date], 0, "PlannedFinishDate"), New System.Data.SqlClient.SqlParameter("@PercentComplete", System.Data.SqlDbType.NVarChar, 0, "PercentComplete"), New System.Data.SqlClient.SqlParameter("@DrawingFolderAssignDate", System.Data.SqlDbType.NVarChar, 0, "DrawingFolderAssignDate"), New System.Data.SqlClient.SqlParameter("@DesignWIPDate", System.Data.SqlDbType.NVarChar, 0, "DesignWIPDate"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@ModelTemplateDate", System.Data.SqlDbType.NVarChar, 0, "ModelTemplateDate"), New System.Data.SqlClient.SqlParameter("@Drafter", System.Data.SqlDbType.NVarChar, 0, "Drafter"), New System.Data.SqlClient.SqlParameter("@DrafterComplete", System.Data.SqlDbType.[Date], 0, "DrafterComplete"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@EngineerComplete", System.Data.SqlDbType.[Date], 0, "EngineerComplete"), New System.Data.SqlClient.SqlParameter("@SrEngineer", System.Data.SqlDbType.NVarChar, 0, "SrEngineer"), New System.Data.SqlClient.SqlParameter("@SrEngineerComplete", System.Data.SqlDbType.[Date], 0, "SrEngineerComplete"), New System.Data.SqlClient.SqlParameter("@Releaser", System.Data.SqlDbType.NVarChar, 0, "Releaser"), New System.Data.SqlClient.SqlParameter("@ReleaserCompelte", System.Data.SqlDbType.[Date], 0, "ReleaserCompelte"), New System.Data.SqlClient.SqlParameter("@Flammability", System.Data.SqlDbType.NVarChar, 0, "Flammability"), New System.Data.SqlClient.SqlParameter("@FlammabilityComplete", System.Data.SqlDbType.[Date], 0, "FlammabilityComplete"), New System.Data.SqlClient.SqlParameter("@Stress", System.Data.SqlDbType.NVarChar, 0, "Stress"), New System.Data.SqlClient.SqlParameter("@StressComplete", System.Data.SqlDbType.[Date], 0, "StressComplete"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@RefID", System.Data.SqlDbType.Int, 0, "RefID"), New System.Data.SqlClient.SqlParameter("@DrafterPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "DrafterPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@EngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "EngineerPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@SrEngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "SrEngineerPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@FlammabilityPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "FlammabilityPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@StressPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "StressPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@ReleaserPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "ReleaserPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@Avionics", System.Data.SqlDbType.NVarChar, 0, "Avionics"), New System.Data.SqlClient.SqlParameter("@AvionicsComplete", System.Data.SqlDbType.[Date], 0, "AvionicsComplete"), New System.Data.SqlClient.SqlParameter("@AvionicsPlannedComplete", System.Data.SqlDbType.[Date], 0, "AvionicsPlannedComplete"), New System.Data.SqlClient.SqlParameter("@Mechanical", System.Data.SqlDbType.NVarChar, 0, "Mechanical"), New System.Data.SqlClient.SqlParameter("@MechanicalComplete", System.Data.SqlDbType.[Date], 0, "MechanicalComplete"), New System.Data.SqlClient.SqlParameter("@MechanicalPlannedComplete", System.Data.SqlDbType.[Date], 0, "MechanicalPlannedComplete"), New System.Data.SqlClient.SqlParameter("@WONumber", System.Data.SqlDbType.NVarChar, 0, "WONumber"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocumentType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocumentType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Priority", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Priority", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRequestBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRequestBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRequestBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRequestBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRequestDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRequestDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRequestDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRequestDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SystemDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SystemDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LastActionDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastActionDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LastActionDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastActionDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ForecastFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ForecastFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ForecastFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ForecastFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannedFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannedFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannedFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannedFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PercentComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PercentComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PercentComplete", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PercentComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingFolderAssignDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingFolderAssignDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingFolderAssignDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingFolderAssignDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignWIPDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignWIPDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignWIPDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignWIPDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ModelTemplateDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ModelTemplateDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ModelTemplateDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModelTemplateDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Drafter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Drafter", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Releaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Releaser", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserCompelte", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserCompelte", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Flammability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Flammability", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FlammabilityComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FlammabilityComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FlammabilityComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FlammabilityComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Stress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Stress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RefID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RefID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RefID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RefID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FlammabilityPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FlammabilityPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FlammabilityPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FlammabilityPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Avionics", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Avionics", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Avionics", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Avionics", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AvionicsComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AvionicsComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AvionicsComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AvionicsComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AvionicsPlannedComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AvionicsPlannedComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AvionicsPlannedComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AvionicsPlannedComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Mechanical", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Mechanical", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Mechanical", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mechanical", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MechanicalComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MechanicalComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MechanicalComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MechanicalComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MechanicalPlannedComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MechanicalPlannedComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MechanicalPlannedComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MechanicalPlannedComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WONumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WONumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WONumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WONumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocumentType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocumentType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Priority", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Priority", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRequestBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRequestBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRequestBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRequestBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRequestDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRequestDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRequestDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRequestDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SystemDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SystemDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LastActionDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastActionDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LastActionDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastActionDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ForecastFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ForecastFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ForecastFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ForecastFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannedFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannedFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannedFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannedFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PercentComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PercentComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PercentComplete", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PercentComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingFolderAssignDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingFolderAssignDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingFolderAssignDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingFolderAssignDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignWIPDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignWIPDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignWIPDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignWIPDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ModelTemplateDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ModelTemplateDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ModelTemplateDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModelTemplateDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Drafter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Drafter", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Releaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Releaser", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserCompelte", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserCompelte", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Flammability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Flammability", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FlammabilityComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FlammabilityComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FlammabilityComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FlammabilityComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Stress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Stress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RefID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RefID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RefID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RefID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FlammabilityPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FlammabilityPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FlammabilityPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FlammabilityPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Avionics", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Avionics", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Avionics", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Avionics", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AvionicsComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AvionicsComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AvionicsComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AvionicsComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AvionicsPlannedComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AvionicsPlannedComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AvionicsPlannedComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AvionicsPlannedComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Mechanical", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Mechanical", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Mechanical", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mechanical", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MechanicalComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MechanicalComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MechanicalComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MechanicalComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MechanicalPlannedComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MechanicalPlannedComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MechanicalPlannedComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MechanicalPlannedComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WONumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WONumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WONumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WONumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawings", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DocumentType", "DocumentType"), New System.Data.Common.DataColumnMapping("Priority", "Priority"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("DwgRequestBy", "DwgRequestBy"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DwgRequestDate", "DwgRequestDate"), New System.Data.Common.DataColumnMapping("DrawingTitle", "DrawingTitle"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("DrawingType", "DrawingType"), New System.Data.Common.DataColumnMapping("SystemDescription", "SystemDescription"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("LastActionDate", "LastActionDate"), New System.Data.Common.DataColumnMapping("ActualFinishDate", "ActualFinishDate"), New System.Data.Common.DataColumnMapping("ForecastFinishDate", "ForecastFinishDate"), New System.Data.Common.DataColumnMapping("PlannedFinishDate", "PlannedFinishDate"), New System.Data.Common.DataColumnMapping("PercentComplete", "PercentComplete"), New System.Data.Common.DataColumnMapping("DrawingFolderAssignDate", "DrawingFolderAssignDate"), New System.Data.Common.DataColumnMapping("DesignWIPDate", "DesignWIPDate"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("ModelTemplateDate", "ModelTemplateDate"), New System.Data.Common.DataColumnMapping("Drafter", "Drafter"), New System.Data.Common.DataColumnMapping("DrafterComplete", "DrafterComplete"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerComplete", "EngineerComplete"), New System.Data.Common.DataColumnMapping("SrEngineer", "SrEngineer"), New System.Data.Common.DataColumnMapping("SrEngineerComplete", "SrEngineerComplete"), New System.Data.Common.DataColumnMapping("Releaser", "Releaser"), New System.Data.Common.DataColumnMapping("ReleaserCompelte", "ReleaserCompelte"), New System.Data.Common.DataColumnMapping("Flammability", "Flammability"), New System.Data.Common.DataColumnMapping("FlammabilityComplete", "FlammabilityComplete"), New System.Data.Common.DataColumnMapping("Stress", "Stress"), New System.Data.Common.DataColumnMapping("StressComplete", "StressComplete"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("RefID", "RefID"), New System.Data.Common.DataColumnMapping("DrafterPlannedCompleteDate", "DrafterPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("EngineerPlannedCompleteDate", "EngineerPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("SrEngineerPlannedCompleteDate", "SrEngineerPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("FlammabilityPlannedCompleteDate", "FlammabilityPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("StressPlannedCompleteDate", "StressPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("ReleaserPlannedCompleteDate", "ReleaserPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("Avionics", "Avionics"), New System.Data.Common.DataColumnMapping("AvionicsComplete", "AvionicsComplete"), New System.Data.Common.DataColumnMapping("AvionicsPlannedComplete", "AvionicsPlannedComplete"), New System.Data.Common.DataColumnMapping("Mechanical", "Mechanical"), New System.Data.Common.DataColumnMapping("MechanicalComplete", "MechanicalComplete"), New System.Data.Common.DataColumnMapping("MechanicalPlannedComplete", "MechanicalPlannedComplete"), New System.Data.Common.DataColumnMapping("WONumber", "WONumber")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'btnSaveGrid
        '
        Me.btnSaveGrid.Location = New System.Drawing.Point(502, 779)
        Me.btnSaveGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveGrid.Name = "btnSaveGrid"
        Me.btnSaveGrid.Size = New System.Drawing.Size(243, 20)
        Me.btnSaveGrid.TabIndex = 4
        Me.btnSaveGrid.Text = "Save Grid Data"
        Me.btnSaveGrid.UseVisualStyleBackColor = True
        '
        'btnEditandViewRow
        '
        Me.btnEditandViewRow.Location = New System.Drawing.Point(12, 779)
        Me.btnEditandViewRow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditandViewRow.Name = "btnEditandViewRow"
        Me.btnEditandViewRow.Size = New System.Drawing.Size(241, 20)
        Me.btnEditandViewRow.TabIndex = 5
        Me.btnEditandViewRow.Text = "Edit/View Row"
        Me.btnEditandViewRow.UseVisualStyleBackColor = True
        '
        'btnSubmitNewDrawingRequest
        '
        Me.btnSubmitNewDrawingRequest.Location = New System.Drawing.Point(749, 779)
        Me.btnSubmitNewDrawingRequest.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmitNewDrawingRequest.Name = "btnSubmitNewDrawingRequest"
        Me.btnSubmitNewDrawingRequest.Size = New System.Drawing.Size(197, 20)
        Me.btnSubmitNewDrawingRequest.TabIndex = 6
        Me.btnSubmitNewDrawingRequest.Text = "Submit New Drawing Request"
        Me.btnSubmitNewDrawingRequest.UseVisualStyleBackColor = True
        '
        'btnExportGrid
        '
        Me.btnExportGrid.Location = New System.Drawing.Point(1160, 12)
        Me.btnExportGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExportGrid.Name = "btnExportGrid"
        Me.btnExportGrid.Size = New System.Drawing.Size(262, 20)
        Me.btnExportGrid.TabIndex = 7
        Me.btnExportGrid.Text = "Export Grid"
        Me.btnExportGrid.UseVisualStyleBackColor = True
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(566, 704)
        Me.txtLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(265, 20)
        Me.txtLocation.TabIndex = 8
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(950, 779)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(472, 20)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(257, 779)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(241, 20)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete current record"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'chkShowStageComplete
        '
        Me.chkShowStageComplete.Location = New System.Drawing.Point(522, 12)
        Me.chkShowStageComplete.Margin = New System.Windows.Forms.Padding(2)
        Me.chkShowStageComplete.Name = "chkShowStageComplete"
        Me.chkShowStageComplete.Size = New System.Drawing.Size(134, 20)
        Me.chkShowStageComplete.TabIndex = 11
        Me.chkShowStageComplete.Text = "Show Status Complete"
        Me.chkShowStageComplete.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(903, 12)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(253, 20)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh Grid"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnReturnToMainMenu
        '
        Me.btnReturnToMainMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnReturnToMainMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturnToMainMenu.Name = "btnReturnToMainMenu"
        Me.btnReturnToMainMenu.Size = New System.Drawing.Size(95, 20)
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
        'btnAdminUsers
        '
        Me.btnAdminUsers.Location = New System.Drawing.Point(181, 12)
        Me.btnAdminUsers.Name = "btnAdminUsers"
        Me.btnAdminUsers.Size = New System.Drawing.Size(139, 20)
        Me.btnAdminUsers.TabIndex = 15
        Me.btnAdminUsers.Text = "Admin Users"
        Me.btnAdminUsers.UseVisualStyleBackColor = True
        '
        'btnAdminPrograms
        '
        Me.btnAdminPrograms.Location = New System.Drawing.Point(324, 12)
        Me.btnAdminPrograms.Name = "btnAdminPrograms"
        Me.btnAdminPrograms.Size = New System.Drawing.Size(130, 20)
        Me.btnAdminPrograms.TabIndex = 16
        Me.btnAdminPrograms.Text = "Admin Programs"
        Me.btnAdminPrograms.UseVisualStyleBackColor = True
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
        'frmGridLookUpLayoutControl1ConvertedLayout
        '
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.LabelControl5)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.LabelControl4)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.LabelControl3)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.LabelControl2)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.LabelControl1)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.chkShowStageComplete)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.btnAdminPrograms)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.btnAdminUsers)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.btnReturnToMainMenu)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.btnRefresh)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.btnDelete)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.GridControl1)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.btnClose)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.btnExportGrid)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.btnSubmitNewDrawingRequest)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.btnEditandViewRow)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.btnSaveGrid)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.txtRecordID)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Controls.Add(Me.txtLocation)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmGridLookUpLayoutControl1ConvertedLayout.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.txtRecordIDitem, Me.txtLocationitem})
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Name = "frmGridLookUpLayoutControl1ConvertedLayout"
        Me.frmGridLookUpLayoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(839, 563, 650, 400)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmGridLookUpLayoutControl1ConvertedLayout.Size = New System.Drawing.Size(1434, 811)
        Me.frmGridLookUpLayoutControl1ConvertedLayout.TabIndex = 17
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(823, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl4.StyleController = Me.frmGridLookUpLayoutControl1ConvertedLayout
        Me.LabelControl4.TabIndex = 20
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(458, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl3.StyleController = Me.frmGridLookUpLayoutControl1ConvertedLayout
        Me.LabelControl3.TabIndex = 19
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(111, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 20)
        Me.LabelControl2.StyleController = Me.frmGridLookUpLayoutControl1ConvertedLayout
        Me.LabelControl2.TabIndex = 18
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 762)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(1410, 13)
        Me.LabelControl1.StyleController = Me.frmGridLookUpLayoutControl1ConvertedLayout
        Me.LabelControl1.TabIndex = 17
        '
        'txtRecordIDitem
        '
        Me.txtRecordIDitem.Control = Me.txtRecordID
        Me.txtRecordIDitem.Location = New System.Drawing.Point(554, 668)
        Me.txtRecordIDitem.Name = "txtRecordIDitem"
        Me.txtRecordIDitem.Size = New System.Drawing.Size(269, 24)
        Me.txtRecordIDitem.TextSize = New System.Drawing.Size(0, 0)
        Me.txtRecordIDitem.TextVisible = False
        '
        'txtLocationitem
        '
        Me.txtLocationitem.Control = Me.txtLocation
        Me.txtLocationitem.Location = New System.Drawing.Point(554, 692)
        Me.txtLocationitem.Name = "txtLocationitem"
        Me.txtLocationitem.Size = New System.Drawing.Size(269, 24)
        Me.txtLocationitem.TextSize = New System.Drawing.Size(0, 0)
        Me.txtLocationitem.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.chkShowStageCompleteitem, Me.btnAdminProgramsitem, Me.btnAdminUsersitem, Me.btnReturnToMainMenuitem, Me.btnRefreshitem, Me.btnDeleteitem, Me.GridControl1item, Me.btnExportGriditem, Me.btnCloseitem, Me.btnSaveGriditem, Me.btnEditandViewRowitem, Me.btnSubmitNewDrawingRequestitem, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1434, 811)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'chkShowStageCompleteitem
        '
        Me.chkShowStageCompleteitem.Control = Me.chkShowStageComplete
        Me.chkShowStageCompleteitem.Location = New System.Drawing.Point(510, 0)
        Me.chkShowStageCompleteitem.Name = "chkShowStageCompleteitem"
        Me.chkShowStageCompleteitem.Size = New System.Drawing.Size(301, 24)
        Me.chkShowStageCompleteitem.Text = "(OKC:  Gate 6, Canada:  Gate 9) "
        Me.chkShowStageCompleteitem.TextLocation = DevExpress.Utils.Locations.Right
        Me.chkShowStageCompleteitem.TextSize = New System.Drawing.Size(160, 13)
        '
        'btnAdminProgramsitem
        '
        Me.btnAdminProgramsitem.Control = Me.btnAdminPrograms
        Me.btnAdminProgramsitem.Location = New System.Drawing.Point(312, 0)
        Me.btnAdminProgramsitem.Name = "btnAdminProgramsitem"
        Me.btnAdminProgramsitem.Size = New System.Drawing.Size(134, 24)
        Me.btnAdminProgramsitem.TextSize = New System.Drawing.Size(0, 0)
        Me.btnAdminProgramsitem.TextVisible = False
        '
        'btnAdminUsersitem
        '
        Me.btnAdminUsersitem.Control = Me.btnAdminUsers
        Me.btnAdminUsersitem.Location = New System.Drawing.Point(169, 0)
        Me.btnAdminUsersitem.Name = "btnAdminUsersitem"
        Me.btnAdminUsersitem.Size = New System.Drawing.Size(143, 24)
        Me.btnAdminUsersitem.TextSize = New System.Drawing.Size(0, 0)
        Me.btnAdminUsersitem.TextVisible = False
        '
        'btnReturnToMainMenuitem
        '
        Me.btnReturnToMainMenuitem.Control = Me.btnReturnToMainMenu
        Me.btnReturnToMainMenuitem.Location = New System.Drawing.Point(0, 0)
        Me.btnReturnToMainMenuitem.Name = "btnReturnToMainMenuitem"
        Me.btnReturnToMainMenuitem.Size = New System.Drawing.Size(99, 24)
        Me.btnReturnToMainMenuitem.TextSize = New System.Drawing.Size(0, 0)
        Me.btnReturnToMainMenuitem.TextVisible = False
        '
        'btnRefreshitem
        '
        Me.btnRefreshitem.Control = Me.btnRefresh
        Me.btnRefreshitem.Location = New System.Drawing.Point(891, 0)
        Me.btnRefreshitem.Name = "btnRefreshitem"
        Me.btnRefreshitem.Size = New System.Drawing.Size(257, 24)
        Me.btnRefreshitem.TextSize = New System.Drawing.Size(0, 0)
        Me.btnRefreshitem.TextVisible = False
        '
        'btnDeleteitem
        '
        Me.btnDeleteitem.Control = Me.btnDelete
        Me.btnDeleteitem.Location = New System.Drawing.Point(245, 767)
        Me.btnDeleteitem.Name = "btnDeleteitem"
        Me.btnDeleteitem.Size = New System.Drawing.Size(245, 24)
        Me.btnDeleteitem.TextSize = New System.Drawing.Size(0, 0)
        Me.btnDeleteitem.TextVisible = False
        '
        'GridControl1item
        '
        Me.GridControl1item.Control = Me.GridControl1
        Me.GridControl1item.Location = New System.Drawing.Point(0, 41)
        Me.GridControl1item.Name = "GridControl1item"
        Me.GridControl1item.Size = New System.Drawing.Size(1414, 709)
        Me.GridControl1item.TextSize = New System.Drawing.Size(0, 0)
        Me.GridControl1item.TextVisible = False
        '
        'btnExportGriditem
        '
        Me.btnExportGriditem.Control = Me.btnExportGrid
        Me.btnExportGriditem.Location = New System.Drawing.Point(1148, 0)
        Me.btnExportGriditem.Name = "btnExportGriditem"
        Me.btnExportGriditem.Size = New System.Drawing.Size(266, 24)
        Me.btnExportGriditem.TextSize = New System.Drawing.Size(0, 0)
        Me.btnExportGriditem.TextVisible = False
        '
        'btnCloseitem
        '
        Me.btnCloseitem.Control = Me.btnClose
        Me.btnCloseitem.Location = New System.Drawing.Point(938, 767)
        Me.btnCloseitem.Name = "btnCloseitem"
        Me.btnCloseitem.Size = New System.Drawing.Size(476, 24)
        Me.btnCloseitem.TextSize = New System.Drawing.Size(0, 0)
        Me.btnCloseitem.TextVisible = False
        '
        'btnSaveGriditem
        '
        Me.btnSaveGriditem.Control = Me.btnSaveGrid
        Me.btnSaveGriditem.Location = New System.Drawing.Point(490, 767)
        Me.btnSaveGriditem.Name = "btnSaveGriditem"
        Me.btnSaveGriditem.Size = New System.Drawing.Size(247, 24)
        Me.btnSaveGriditem.TextSize = New System.Drawing.Size(0, 0)
        Me.btnSaveGriditem.TextVisible = False
        '
        'btnEditandViewRowitem
        '
        Me.btnEditandViewRowitem.Control = Me.btnEditandViewRow
        Me.btnEditandViewRowitem.Location = New System.Drawing.Point(0, 767)
        Me.btnEditandViewRowitem.MaxSize = New System.Drawing.Size(1414, 69)
        Me.btnEditandViewRowitem.MinSize = New System.Drawing.Size(24, 24)
        Me.btnEditandViewRowitem.Name = "btnEditandViewRowitem"
        Me.btnEditandViewRowitem.Size = New System.Drawing.Size(245, 24)
        Me.btnEditandViewRowitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.btnEditandViewRowitem.TextSize = New System.Drawing.Size(0, 0)
        Me.btnEditandViewRowitem.TextVisible = False
        '
        'btnSubmitNewDrawingRequestitem
        '
        Me.btnSubmitNewDrawingRequestitem.Control = Me.btnSubmitNewDrawingRequest
        Me.btnSubmitNewDrawingRequestitem.Location = New System.Drawing.Point(737, 767)
        Me.btnSubmitNewDrawingRequestitem.Name = "btnSubmitNewDrawingRequestitem"
        Me.btnSubmitNewDrawingRequestitem.Size = New System.Drawing.Size(201, 24)
        Me.btnSubmitNewDrawingRequestitem.TextSize = New System.Drawing.Size(0, 0)
        Me.btnSubmitNewDrawingRequestitem.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.LabelControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 750)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1414, 17)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LabelControl2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(99, 0)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(70, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.LabelControl3
        Me.LayoutControlItem3.Location = New System.Drawing.Point(446, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(64, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.LabelControl4
        Me.LayoutControlItem4.Location = New System.Drawing.Point(811, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(80, 24)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(188, 24)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(438, 743)
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 36)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(1410, 13)
        Me.LabelControl5.StyleController = Me.frmGridLookUpLayoutControl1ConvertedLayout
        Me.LabelControl5.TabIndex = 21
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.LabelControl5
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1414, 17)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'frmGridLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1434, 811)
        Me.Controls.Add(Me.frmGridLookUpLayoutControl1ConvertedLayout)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmGridLookUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Field Engineering Drawing Status System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.frmGridLookUpLayoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmGridLookUpLayoutControl1ConvertedLayout.ResumeLayout(False)
        CType(Me.txtRecordIDitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocationitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowStageCompleteitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdminProgramsitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdminUsersitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnReturnToMainMenuitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefreshitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportGriditem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveGriditem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditandViewRowitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSubmitNewDrawingRequestitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents btnAdminUsers As Button
    Friend WithEvents ForecastStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EstimatedDurationHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAdminPrograms As Button
    Friend WithEvents colNextHigherAssembly As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents ProgramsDataAdapter As SqlClient.SqlDataAdapter
    Friend WithEvents dtsPrograms As dtsPrograms
    Friend WithEvents ProgramsBindingSource As BindingSource
    Friend WithEvents DsPrograms As dsPrograms
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents frmGridLookUpLayoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents chkShowStageCompleteitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnAdminProgramsitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnAdminUsersitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnReturnToMainMenuitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnRefreshitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnCloseitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnExportGriditem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnEditandViewRowitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnSaveGriditem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtRecordIDitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtLocationitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1item As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnSubmitNewDrawingRequestitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDeleteitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
