<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditRecord))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet31 = New EngDesignTracking.DataSet3()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.txtDrawingFolderAssignDate = New System.Windows.Forms.TextBox()
        Me.txtDesignWIPDate = New System.Windows.Forms.TextBox()
        Me.txtModelTemplateDate = New System.Windows.Forms.TextBox()
        Me.txtPercentComplete = New System.Windows.Forms.TextBox()
        Me.cboDrafter = New System.Windows.Forms.ComboBox()
        Me.cboEngineer = New System.Windows.Forms.ComboBox()
        Me.cboSrEngineer = New System.Windows.Forms.ComboBox()
        Me.cboFlammability = New System.Windows.Forms.ComboBox()
        Me.cboStress = New System.Windows.Forms.ComboBox()
        Me.cboReleaser = New System.Windows.Forms.ComboBox()
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.btnSaveRecord = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtDrawingNumber = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cboAvionics = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cboMechanical = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtDrawingTitle = New System.Windows.Forms.TextBox()
        Me.lblDrawingTitle = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cboDrawingRevision = New System.Windows.Forms.ComboBox()
        Me.txtActualFinishDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPlannedFinishDate = New System.Windows.Forms.DateTimePicker()
        Me.txtForecastFinishDate = New System.Windows.Forms.DateTimePicker()
        Me.cboDrafterComplete = New System.Windows.Forms.DateTimePicker()
        Me.cboDrafterPlannedCompleteDate = New System.Windows.Forms.DateTimePicker()
        Me.cboEngineerComplete = New System.Windows.Forms.DateTimePicker()
        Me.cboSrEngineerComplete = New System.Windows.Forms.DateTimePicker()
        Me.cboReleaserComplete = New System.Windows.Forms.DateTimePicker()
        Me.cboFlammabilityComplete = New System.Windows.Forms.DateTimePicker()
        Me.cboStressComplete = New System.Windows.Forms.DateTimePicker()
        Me.cboEngineerPlannedCompleteDate = New System.Windows.Forms.DateTimePicker()
        Me.cboSrEngineerPlannedCompleteDate = New System.Windows.Forms.DateTimePicker()
        Me.cboFlammabilityPlannedCompleteDate = New System.Windows.Forms.DateTimePicker()
        Me.cboStressPlannedCompleteDate = New System.Windows.Forms.DateTimePicker()
        Me.cboReleaserPlannedCompleteDate = New System.Windows.Forms.DateTimePicker()
        Me.cboAvionicsComplete = New System.Windows.Forms.DateTimePicker()
        Me.cboAvionicsPlannedComplete = New System.Windows.Forms.DateTimePicker()
        Me.cboMechanicalComplete = New System.Windows.Forms.DateTimePicker()
        Me.cboMechanicalPlannedComplete = New System.Windows.Forms.DateTimePicker()
        Me.TblRevisionsLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtWONumber = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtboxEstimatedDuration = New System.Windows.Forms.TextBox()
        Me.txtForecastStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblNextHigher = New System.Windows.Forms.Label()
        Me.txtboxNextHigherAssembly = New System.Windows.Forms.TextBox()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRevisionsLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl1.Location = New System.Drawing.Point(12, 18)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1210, 158)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblDrawings"
        Me.BindingSource1.DataSource = Me.DataSet31
        '
        'DataSet31
        '
        Me.DataSet31.DataSetName = "DataSet3"
        Me.DataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPriority, Me.colLocation, Me.colDwgRequestBy, Me.colDrawingType})
        Me.GridView1.DetailHeight = 182
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.LevelIndent = 0
        Me.GridView1.Name = "GridView1"
        Me.GridView1.PreviewIndent = 0
        '
        'colPriority
        '
        Me.colPriority.FieldName = "Priority"
        Me.colPriority.Name = "colPriority"
        Me.colPriority.Visible = True
        Me.colPriority.VisibleIndex = 0
        '
        'colLocation
        '
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 1
        '
        'colDwgRequestBy
        '
        Me.colDwgRequestBy.FieldName = "DwgRequestBy"
        Me.colDwgRequestBy.Name = "colDwgRequestBy"
        Me.colDwgRequestBy.Visible = True
        Me.colDwgRequestBy.VisibleIndex = 3
        '
        'colDrawingType
        '
        Me.colDrawingType.FieldName = "DrawingType"
        Me.colDrawingType.Name = "colDrawingType"
        Me.colDrawingType.Visible = True
        Me.colDrawingType.VisibleIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(909, 178)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 217)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Actual Finish date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 217)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Baseline Finish Date (IMS):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(750, 217)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Forecast Finish Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 246)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Drawing Folder Assign Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(295, 246)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Design WIP Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(509, 246)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Model Template Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(763, 246)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Percent Complete:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 271)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Notes:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 372)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Drafter:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(216, 372)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Drafter Complete:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 419)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Engineer:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(216, 419)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Engineer Complete:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 462)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Sr Engineer:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(216, 462)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Sr Engineer Complete:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(31, 505)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Flammability:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(216, 505)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Flammability Complete:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(31, 546)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Stress:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(216, 546)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 13)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Stress Complete:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(29, 645)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Releaser"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(216, 645)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(99, 13)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "Releaser Complete:"
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(953, 179)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(176, 21)
        Me.cboStatus.TabIndex = 26
        '
        'txtDrawingFolderAssignDate
        '
        Me.txtDrawingFolderAssignDate.Location = New System.Drawing.Point(175, 246)
        Me.txtDrawingFolderAssignDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDrawingFolderAssignDate.Name = "txtDrawingFolderAssignDate"
        Me.txtDrawingFolderAssignDate.Size = New System.Drawing.Size(110, 20)
        Me.txtDrawingFolderAssignDate.TabIndex = 30
        '
        'txtDesignWIPDate
        '
        Me.txtDesignWIPDate.Location = New System.Drawing.Point(394, 247)
        Me.txtDesignWIPDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesignWIPDate.Name = "txtDesignWIPDate"
        Me.txtDesignWIPDate.Size = New System.Drawing.Size(110, 20)
        Me.txtDesignWIPDate.TabIndex = 31
        '
        'txtModelTemplateDate
        '
        Me.txtModelTemplateDate.Location = New System.Drawing.Point(626, 246)
        Me.txtModelTemplateDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModelTemplateDate.Name = "txtModelTemplateDate"
        Me.txtModelTemplateDate.Size = New System.Drawing.Size(110, 20)
        Me.txtModelTemplateDate.TabIndex = 32
        '
        'txtPercentComplete
        '
        Me.txtPercentComplete.Location = New System.Drawing.Point(861, 246)
        Me.txtPercentComplete.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPercentComplete.Name = "txtPercentComplete"
        Me.txtPercentComplete.Size = New System.Drawing.Size(111, 20)
        Me.txtPercentComplete.TabIndex = 33
        '
        'cboDrafter
        '
        Me.cboDrafter.FormattingEnabled = True
        Me.cboDrafter.Location = New System.Drawing.Point(111, 372)
        Me.cboDrafter.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDrafter.Name = "cboDrafter"
        Me.cboDrafter.Size = New System.Drawing.Size(98, 21)
        Me.cboDrafter.TabIndex = 34
        '
        'cboEngineer
        '
        Me.cboEngineer.FormattingEnabled = True
        Me.cboEngineer.Location = New System.Drawing.Point(111, 419)
        Me.cboEngineer.Margin = New System.Windows.Forms.Padding(2)
        Me.cboEngineer.Name = "cboEngineer"
        Me.cboEngineer.Size = New System.Drawing.Size(98, 21)
        Me.cboEngineer.TabIndex = 36
        '
        'cboSrEngineer
        '
        Me.cboSrEngineer.FormattingEnabled = True
        Me.cboSrEngineer.Location = New System.Drawing.Point(111, 462)
        Me.cboSrEngineer.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSrEngineer.Name = "cboSrEngineer"
        Me.cboSrEngineer.Size = New System.Drawing.Size(98, 21)
        Me.cboSrEngineer.TabIndex = 38
        '
        'cboFlammability
        '
        Me.cboFlammability.FormattingEnabled = True
        Me.cboFlammability.Location = New System.Drawing.Point(111, 505)
        Me.cboFlammability.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFlammability.Name = "cboFlammability"
        Me.cboFlammability.Size = New System.Drawing.Size(98, 21)
        Me.cboFlammability.TabIndex = 40
        '
        'cboStress
        '
        Me.cboStress.FormattingEnabled = True
        Me.cboStress.Location = New System.Drawing.Point(111, 546)
        Me.cboStress.Margin = New System.Windows.Forms.Padding(2)
        Me.cboStress.Name = "cboStress"
        Me.cboStress.Size = New System.Drawing.Size(98, 21)
        Me.cboStress.TabIndex = 42
        '
        'cboReleaser
        '
        Me.cboReleaser.FormattingEnabled = True
        Me.cboReleaser.Location = New System.Drawing.Point(111, 645)
        Me.cboReleaser.Margin = New System.Windows.Forms.Padding(2)
        Me.cboReleaser.Name = "cboReleaser"
        Me.cboReleaser.Size = New System.Drawing.Size(98, 21)
        Me.cboReleaser.TabIndex = 44
        '
        'txtRecordID
        '
        Me.txtRecordID.Location = New System.Drawing.Point(494, 151)
        Me.txtRecordID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(52, 20)
        Me.txtRecordID.TabIndex = 46
        '
        'SqlConnection1
        '
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(79, 271)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(903, 48)
        Me.txtNotes.TabIndex = 47
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection2
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DocumentType", System.Data.SqlDbType.NVarChar, 0, "DocumentType"), New System.Data.SqlClient.SqlParameter("@Priority", System.Data.SqlDbType.NVarChar, 0, "Priority"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@DwgRequestBy", System.Data.SqlDbType.NVarChar, 0, "DwgRequestBy"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRequestDate", System.Data.SqlDbType.NVarChar, 0, "DwgRequestDate"), New System.Data.SqlClient.SqlParameter("@DrawingTitle", System.Data.SqlDbType.NVarChar, 0, "DrawingTitle"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@DrawingType", System.Data.SqlDbType.NVarChar, 0, "DrawingType"), New System.Data.SqlClient.SqlParameter("@SystemDescription", System.Data.SqlDbType.NVarChar, 0, "SystemDescription"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@LastActionDate", System.Data.SqlDbType.NVarChar, 0, "LastActionDate"), New System.Data.SqlClient.SqlParameter("@ActualFinishDate", System.Data.SqlDbType.[Date], 0, "ActualFinishDate"), New System.Data.SqlClient.SqlParameter("@ForecastFinishDate", System.Data.SqlDbType.[Date], 0, "ForecastFinishDate"), New System.Data.SqlClient.SqlParameter("@PlannedFinishDate", System.Data.SqlDbType.[Date], 0, "PlannedFinishDate"), New System.Data.SqlClient.SqlParameter("@PercentComplete", System.Data.SqlDbType.NVarChar, 0, "PercentComplete"), New System.Data.SqlClient.SqlParameter("@DrawingFolderAssignDate", System.Data.SqlDbType.NVarChar, 0, "DrawingFolderAssignDate"), New System.Data.SqlClient.SqlParameter("@DesignWIPDate", System.Data.SqlDbType.NVarChar, 0, "DesignWIPDate"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@ModelTemplateDate", System.Data.SqlDbType.NVarChar, 0, "ModelTemplateDate"), New System.Data.SqlClient.SqlParameter("@Drafter", System.Data.SqlDbType.NVarChar, 0, "Drafter"), New System.Data.SqlClient.SqlParameter("@DrafterComplete", System.Data.SqlDbType.[Date], 0, "DrafterComplete"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@EngineerComplete", System.Data.SqlDbType.[Date], 0, "EngineerComplete"), New System.Data.SqlClient.SqlParameter("@SrEngineer", System.Data.SqlDbType.NVarChar, 0, "SrEngineer"), New System.Data.SqlClient.SqlParameter("@SrEngineerComplete", System.Data.SqlDbType.[Date], 0, "SrEngineerComplete"), New System.Data.SqlClient.SqlParameter("@Releaser", System.Data.SqlDbType.NVarChar, 0, "Releaser"), New System.Data.SqlClient.SqlParameter("@ReleaserCompelte", System.Data.SqlDbType.[Date], 0, "ReleaserCompelte"), New System.Data.SqlClient.SqlParameter("@Flammability", System.Data.SqlDbType.NVarChar, 0, "Flammability"), New System.Data.SqlClient.SqlParameter("@FlammabilityComplete", System.Data.SqlDbType.[Date], 0, "FlammabilityComplete"), New System.Data.SqlClient.SqlParameter("@Stress", System.Data.SqlDbType.NVarChar, 0, "Stress"), New System.Data.SqlClient.SqlParameter("@StressComplete", System.Data.SqlDbType.[Date], 0, "StressComplete"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@RefID", System.Data.SqlDbType.Int, 0, "RefID"), New System.Data.SqlClient.SqlParameter("@DrafterPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "DrafterPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@EngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "EngineerPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@SrEngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "SrEngineerPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@FlammabilityPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "FlammabilityPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@StressPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "StressPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@ReleaserPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "ReleaserPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@MechanicalPlannedComplete", System.Data.SqlDbType.[Date], 0, "MechanicalPlannedComplete"), New System.Data.SqlClient.SqlParameter("@MechanicalComplete", System.Data.SqlDbType.[Date], 0, "MechanicalComplete"), New System.Data.SqlClient.SqlParameter("@Mechanical", System.Data.SqlDbType.NVarChar, 0, "Mechanical"), New System.Data.SqlClient.SqlParameter("@AvionicsPlannedComplete", System.Data.SqlDbType.[Date], 0, "AvionicsPlannedComplete"), New System.Data.SqlClient.SqlParameter("@Avionics", System.Data.SqlDbType.NVarChar, 0, "Avionics"), New System.Data.SqlClient.SqlParameter("@AvionicsComplete", System.Data.SqlDbType.[Date], 0, "AvionicsComplete"), New System.Data.SqlClient.SqlParameter("@WONumber", System.Data.SqlDbType.NVarChar, 0, "WONumber")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DocumentType", System.Data.SqlDbType.NVarChar, 0, "DocumentType"), New System.Data.SqlClient.SqlParameter("@Priority", System.Data.SqlDbType.NVarChar, 0, "Priority"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@DwgRequestBy", System.Data.SqlDbType.NVarChar, 0, "DwgRequestBy"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRequestDate", System.Data.SqlDbType.NVarChar, 0, "DwgRequestDate"), New System.Data.SqlClient.SqlParameter("@DrawingTitle", System.Data.SqlDbType.NVarChar, 0, "DrawingTitle"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@DrawingType", System.Data.SqlDbType.NVarChar, 0, "DrawingType"), New System.Data.SqlClient.SqlParameter("@SystemDescription", System.Data.SqlDbType.NVarChar, 0, "SystemDescription"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@LastActionDate", System.Data.SqlDbType.NVarChar, 0, "LastActionDate"), New System.Data.SqlClient.SqlParameter("@ActualFinishDate", System.Data.SqlDbType.[Date], 0, "ActualFinishDate"), New System.Data.SqlClient.SqlParameter("@ForecastFinishDate", System.Data.SqlDbType.[Date], 0, "ForecastFinishDate"), New System.Data.SqlClient.SqlParameter("@PlannedFinishDate", System.Data.SqlDbType.[Date], 0, "PlannedFinishDate"), New System.Data.SqlClient.SqlParameter("@PercentComplete", System.Data.SqlDbType.NVarChar, 0, "PercentComplete"), New System.Data.SqlClient.SqlParameter("@DrawingFolderAssignDate", System.Data.SqlDbType.NVarChar, 0, "DrawingFolderAssignDate"), New System.Data.SqlClient.SqlParameter("@DesignWIPDate", System.Data.SqlDbType.NVarChar, 0, "DesignWIPDate"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@ModelTemplateDate", System.Data.SqlDbType.NVarChar, 0, "ModelTemplateDate"), New System.Data.SqlClient.SqlParameter("@Drafter", System.Data.SqlDbType.NVarChar, 0, "Drafter"), New System.Data.SqlClient.SqlParameter("@DrafterComplete", System.Data.SqlDbType.[Date], 0, "DrafterComplete"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@EngineerComplete", System.Data.SqlDbType.[Date], 0, "EngineerComplete"), New System.Data.SqlClient.SqlParameter("@SrEngineer", System.Data.SqlDbType.NVarChar, 0, "SrEngineer"), New System.Data.SqlClient.SqlParameter("@SrEngineerComplete", System.Data.SqlDbType.[Date], 0, "SrEngineerComplete"), New System.Data.SqlClient.SqlParameter("@Releaser", System.Data.SqlDbType.NVarChar, 0, "Releaser"), New System.Data.SqlClient.SqlParameter("@ReleaserCompelte", System.Data.SqlDbType.[Date], 0, "ReleaserCompelte"), New System.Data.SqlClient.SqlParameter("@Flammability", System.Data.SqlDbType.NVarChar, 0, "Flammability"), New System.Data.SqlClient.SqlParameter("@FlammabilityComplete", System.Data.SqlDbType.[Date], 0, "FlammabilityComplete"), New System.Data.SqlClient.SqlParameter("@Stress", System.Data.SqlDbType.NVarChar, 0, "Stress"), New System.Data.SqlClient.SqlParameter("@StressComplete", System.Data.SqlDbType.[Date], 0, "StressComplete"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@RefID", System.Data.SqlDbType.Int, 0, "RefID"), New System.Data.SqlClient.SqlParameter("@DrafterPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "DrafterPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@EngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "EngineerPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@SrEngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "SrEngineerPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@FlammabilityPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "FlammabilityPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@StressPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "StressPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@ReleaserPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, "ReleaserPlannedCompleteDate"), New System.Data.SqlClient.SqlParameter("@MechanicalPlannedComplete", System.Data.SqlDbType.[Date], 0, "MechanicalPlannedComplete"), New System.Data.SqlClient.SqlParameter("@MechanicalComplete", System.Data.SqlDbType.[Date], 0, "MechanicalComplete"), New System.Data.SqlClient.SqlParameter("@Mechanical", System.Data.SqlDbType.NVarChar, 0, "Mechanical"), New System.Data.SqlClient.SqlParameter("@AvionicsPlannedComplete", System.Data.SqlDbType.[Date], 0, "AvionicsPlannedComplete"), New System.Data.SqlClient.SqlParameter("@Avionics", System.Data.SqlDbType.NVarChar, 0, "Avionics"), New System.Data.SqlClient.SqlParameter("@AvionicsComplete", System.Data.SqlDbType.[Date], 0, "AvionicsComplete"), New System.Data.SqlClient.SqlParameter("@WONumber", System.Data.SqlDbType.NVarChar, 0, "WONumber"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocumentType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocumentType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Priority", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Priority", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRequestBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRequestBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRequestBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRequestBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRequestDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRequestDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRequestDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRequestDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SystemDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SystemDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LastActionDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastActionDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LastActionDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastActionDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ForecastFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ForecastFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ForecastFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ForecastFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannedFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannedFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannedFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannedFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PercentComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PercentComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PercentComplete", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PercentComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingFolderAssignDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingFolderAssignDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingFolderAssignDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingFolderAssignDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignWIPDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignWIPDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignWIPDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignWIPDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ModelTemplateDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ModelTemplateDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ModelTemplateDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModelTemplateDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Drafter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Drafter", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Releaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Releaser", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserCompelte", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserCompelte", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Flammability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Flammability", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FlammabilityComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FlammabilityComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FlammabilityComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FlammabilityComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Stress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Stress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RefID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RefID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RefID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RefID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FlammabilityPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FlammabilityPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FlammabilityPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FlammabilityPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MechanicalPlannedComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MechanicalPlannedComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MechanicalPlannedComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MechanicalPlannedComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MechanicalComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MechanicalComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MechanicalComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MechanicalComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Mechanical", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Mechanical", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Mechanical", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mechanical", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AvionicsPlannedComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AvionicsPlannedComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AvionicsPlannedComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AvionicsPlannedComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Avionics", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Avionics", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Avionics", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Avionics", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AvionicsComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AvionicsComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AvionicsComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AvionicsComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WONumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WONumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WONumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WONumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocumentType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocumentType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Priority", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Priority", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRequestBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRequestBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRequestBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRequestBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRequestDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRequestDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRequestDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRequestDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SystemDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SystemDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LastActionDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastActionDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LastActionDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastActionDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ForecastFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ForecastFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ForecastFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ForecastFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannedFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannedFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannedFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannedFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PercentComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PercentComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PercentComplete", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PercentComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingFolderAssignDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingFolderAssignDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingFolderAssignDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingFolderAssignDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignWIPDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignWIPDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignWIPDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignWIPDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ModelTemplateDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ModelTemplateDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ModelTemplateDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModelTemplateDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Drafter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Drafter", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Releaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Releaser", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserCompelte", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserCompelte", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Flammability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Flammability", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FlammabilityComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FlammabilityComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FlammabilityComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FlammabilityComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Stress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Stress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RefID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RefID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RefID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RefID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FlammabilityPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FlammabilityPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FlammabilityPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FlammabilityPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserPlannedCompleteDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserPlannedCompleteDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserPlannedCompleteDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserPlannedCompleteDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MechanicalPlannedComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MechanicalPlannedComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MechanicalPlannedComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MechanicalPlannedComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MechanicalComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MechanicalComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MechanicalComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MechanicalComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Mechanical", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Mechanical", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Mechanical", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mechanical", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AvionicsPlannedComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AvionicsPlannedComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AvionicsPlannedComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AvionicsPlannedComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Avionics", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Avionics", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Avionics", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Avionics", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AvionicsComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AvionicsComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AvionicsComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AvionicsComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WONumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WONumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WONumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WONumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawings", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DocumentType", "DocumentType"), New System.Data.Common.DataColumnMapping("Priority", "Priority"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("DwgRequestBy", "DwgRequestBy"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DwgRequestDate", "DwgRequestDate"), New System.Data.Common.DataColumnMapping("DrawingTitle", "DrawingTitle"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("DrawingType", "DrawingType"), New System.Data.Common.DataColumnMapping("SystemDescription", "SystemDescription"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("LastActionDate", "LastActionDate"), New System.Data.Common.DataColumnMapping("ActualFinishDate", "ActualFinishDate"), New System.Data.Common.DataColumnMapping("ForecastFinishDate", "ForecastFinishDate"), New System.Data.Common.DataColumnMapping("PlannedFinishDate", "PlannedFinishDate"), New System.Data.Common.DataColumnMapping("PercentComplete", "PercentComplete"), New System.Data.Common.DataColumnMapping("DrawingFolderAssignDate", "DrawingFolderAssignDate"), New System.Data.Common.DataColumnMapping("DesignWIPDate", "DesignWIPDate"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("ModelTemplateDate", "ModelTemplateDate"), New System.Data.Common.DataColumnMapping("Drafter", "Drafter"), New System.Data.Common.DataColumnMapping("DrafterComplete", "DrafterComplete"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerComplete", "EngineerComplete"), New System.Data.Common.DataColumnMapping("SrEngineer", "SrEngineer"), New System.Data.Common.DataColumnMapping("SrEngineerComplete", "SrEngineerComplete"), New System.Data.Common.DataColumnMapping("Releaser", "Releaser"), New System.Data.Common.DataColumnMapping("ReleaserCompelte", "ReleaserCompelte"), New System.Data.Common.DataColumnMapping("Flammability", "Flammability"), New System.Data.Common.DataColumnMapping("FlammabilityComplete", "FlammabilityComplete"), New System.Data.Common.DataColumnMapping("Stress", "Stress"), New System.Data.Common.DataColumnMapping("StressComplete", "StressComplete"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("RefID", "RefID"), New System.Data.Common.DataColumnMapping("DrafterPlannedCompleteDate", "DrafterPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("EngineerPlannedCompleteDate", "EngineerPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("SrEngineerPlannedCompleteDate", "SrEngineerPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("FlammabilityPlannedCompleteDate", "FlammabilityPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("StressPlannedCompleteDate", "StressPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("ReleaserPlannedCompleteDate", "ReleaserPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("MechanicalPlannedComplete", "MechanicalPlannedComplete"), New System.Data.Common.DataColumnMapping("MechanicalComplete", "MechanicalComplete"), New System.Data.Common.DataColumnMapping("Mechanical", "Mechanical"), New System.Data.Common.DataColumnMapping("AvionicsPlannedComplete", "AvionicsPlannedComplete"), New System.Data.Common.DataColumnMapping("Avionics", "Avionics"), New System.Data.Common.DataColumnMapping("AvionicsComplete", "AvionicsComplete"), New System.Data.Common.DataColumnMapping("WONumber", "WONumber")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'btnSaveRecord
        '
        Me.btnSaveRecord.Location = New System.Drawing.Point(936, 632)
        Me.btnSaveRecord.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveRecord.Name = "btnSaveRecord"
        Me.btnSaveRecord.Size = New System.Drawing.Size(110, 34)
        Me.btnSaveRecord.TabIndex = 48
        Me.btnSaveRecord.Text = "Save Record"
        Me.btnSaveRecord.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(528, 372)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(157, 13)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "Drafter Planned Complete Date:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(528, 419)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(167, 13)
        Me.Label23.TabIndex = 50
        Me.Label23.Text = "Engineer Planned Complete Date:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(528, 462)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(180, 13)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Sr Engineer Planned Complete Date:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(528, 505)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(181, 13)
        Me.Label25.TabIndex = 52
        Me.Label25.Text = "Flammability Planned Complete Date:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(528, 546)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(154, 13)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "Stress Planned Complete Date:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(528, 645)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(167, 13)
        Me.Label27.TabIndex = 54
        Me.Label27.Text = "Releaser Planned Complete Date:"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(488, 113)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(218, 20)
        Me.txtLocation.TabIndex = 61
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(98, 344)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 13)
        Me.Label28.TabIndex = 62
        Me.Label28.Text = "Name of Employee"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(322, 344)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(127, 13)
        Me.Label29.TabIndex = 63
        Me.Label29.Text = "Date Stage Complete"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(666, 344)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(177, 13)
        Me.Label30.TabIndex = 64
        Me.Label30.Text = "Planned Date Stage Complete"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(29, 178)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(89, 13)
        Me.Label31.TabIndex = 65
        Me.Label31.Text = "Drawing Number:"
        '
        'txtDrawingNumber
        '
        Me.txtDrawingNumber.Location = New System.Drawing.Point(122, 178)
        Me.txtDrawingNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDrawingNumber.Name = "txtDrawingNumber"
        Me.txtDrawingNumber.Size = New System.Drawing.Size(126, 20)
        Me.txtDrawingNumber.TabIndex = 66
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(29, 585)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(50, 13)
        Me.Label32.TabIndex = 67
        Me.Label32.Text = "Avionics:"
        '
        'cboAvionics
        '
        Me.cboAvionics.FormattingEnabled = True
        Me.cboAvionics.Location = New System.Drawing.Point(110, 581)
        Me.cboAvionics.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAvionics.Name = "cboAvionics"
        Me.cboAvionics.Size = New System.Drawing.Size(98, 21)
        Me.cboAvionics.TabIndex = 68
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(216, 585)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(97, 13)
        Me.Label33.TabIndex = 69
        Me.Label33.Text = "Avionics Complete:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(528, 582)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(139, 13)
        Me.Label34.TabIndex = 70
        Me.Label34.Text = "Avionics Planned Complete:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(29, 616)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(65, 13)
        Me.Label35.TabIndex = 71
        Me.Label35.Text = "Mechanical:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(216, 616)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(112, 13)
        Me.Label36.TabIndex = 72
        Me.Label36.Text = "Mechanical Complete:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(528, 616)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(154, 13)
        Me.Label37.TabIndex = 73
        Me.Label37.Text = "Mechanical Planned Complete:"
        '
        'cboMechanical
        '
        Me.cboMechanical.FormattingEnabled = True
        Me.cboMechanical.Location = New System.Drawing.Point(111, 616)
        Me.cboMechanical.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMechanical.Name = "cboMechanical"
        Me.cboMechanical.Size = New System.Drawing.Size(98, 21)
        Me.cboMechanical.TabIndex = 76
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(834, 632)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 34)
        Me.btnClose.TabIndex = 79
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(309, 319)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(370, 20)
        Me.Label38.TabIndex = 80
        Me.Label38.Text = "All dates should be entered as MM/DD/YYYY"
        '
        'txtDrawingTitle
        '
        Me.txtDrawingTitle.Location = New System.Drawing.Point(585, 178)
        Me.txtDrawingTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDrawingTitle.Name = "txtDrawingTitle"
        Me.txtDrawingTitle.Size = New System.Drawing.Size(126, 20)
        Me.txtDrawingTitle.TabIndex = 82
        '
        'lblDrawingTitle
        '
        Me.lblDrawingTitle.AutoSize = True
        Me.lblDrawingTitle.Location = New System.Drawing.Point(492, 178)
        Me.lblDrawingTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDrawingTitle.Name = "lblDrawingTitle"
        Me.lblDrawingTitle.Size = New System.Drawing.Size(72, 13)
        Me.lblDrawingTitle.TabIndex = 81
        Me.lblDrawingTitle.Text = "Drawing Title:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(269, 178)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(93, 13)
        Me.Label39.TabIndex = 83
        Me.Label39.Text = "Drawing Revision:"
        '
        'cboDrawingRevision
        '
        Me.cboDrawingRevision.FormattingEnabled = True
        Me.cboDrawingRevision.Location = New System.Drawing.Point(364, 178)
        Me.cboDrawingRevision.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDrawingRevision.Name = "cboDrawingRevision"
        Me.cboDrawingRevision.Size = New System.Drawing.Size(113, 21)
        Me.cboDrawingRevision.TabIndex = 84
        '
        'txtActualFinishDate
        '
        Me.txtActualFinishDate.CustomFormat = "dd-MMM-yyyy"
        Me.txtActualFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtActualFinishDate.Location = New System.Drawing.Point(127, 212)
        Me.txtActualFinishDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtActualFinishDate.Name = "txtActualFinishDate"
        Me.txtActualFinishDate.Size = New System.Drawing.Size(113, 20)
        Me.txtActualFinishDate.TabIndex = 85
        '
        'txtPlannedFinishDate
        '
        Me.txtPlannedFinishDate.CustomFormat = "dd-MMM-yyyy"
        Me.txtPlannedFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtPlannedFinishDate.Location = New System.Drawing.Point(394, 212)
        Me.txtPlannedFinishDate.Name = "txtPlannedFinishDate"
        Me.txtPlannedFinishDate.Size = New System.Drawing.Size(110, 20)
        Me.txtPlannedFinishDate.TabIndex = 86
        '
        'txtForecastFinishDate
        '
        Me.txtForecastFinishDate.CustomFormat = "dd-MMM-yyyy"
        Me.txtForecastFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtForecastFinishDate.Location = New System.Drawing.Point(862, 212)
        Me.txtForecastFinishDate.Name = "txtForecastFinishDate"
        Me.txtForecastFinishDate.Size = New System.Drawing.Size(110, 20)
        Me.txtForecastFinishDate.TabIndex = 87
        '
        'cboDrafterComplete
        '
        Me.cboDrafterComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboDrafterComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboDrafterComplete.Location = New System.Drawing.Point(346, 373)
        Me.cboDrafterComplete.Name = "cboDrafterComplete"
        Me.cboDrafterComplete.Size = New System.Drawing.Size(143, 20)
        Me.cboDrafterComplete.TabIndex = 88
        '
        'cboDrafterPlannedCompleteDate
        '
        Me.cboDrafterPlannedCompleteDate.CustomFormat = "dd-MMM-yyyy"
        Me.cboDrafterPlannedCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboDrafterPlannedCompleteDate.Location = New System.Drawing.Point(730, 369)
        Me.cboDrafterPlannedCompleteDate.Name = "cboDrafterPlannedCompleteDate"
        Me.cboDrafterPlannedCompleteDate.Size = New System.Drawing.Size(98, 20)
        Me.cboDrafterPlannedCompleteDate.TabIndex = 89
        '
        'cboEngineerComplete
        '
        Me.cboEngineerComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboEngineerComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboEngineerComplete.Location = New System.Drawing.Point(346, 418)
        Me.cboEngineerComplete.Name = "cboEngineerComplete"
        Me.cboEngineerComplete.Size = New System.Drawing.Size(143, 20)
        Me.cboEngineerComplete.TabIndex = 90
        '
        'cboSrEngineerComplete
        '
        Me.cboSrEngineerComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboSrEngineerComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboSrEngineerComplete.Location = New System.Drawing.Point(345, 459)
        Me.cboSrEngineerComplete.Name = "cboSrEngineerComplete"
        Me.cboSrEngineerComplete.Size = New System.Drawing.Size(144, 20)
        Me.cboSrEngineerComplete.TabIndex = 91
        '
        'cboReleaserComplete
        '
        Me.cboReleaserComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboReleaserComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboReleaserComplete.Location = New System.Drawing.Point(345, 651)
        Me.cboReleaserComplete.Name = "cboReleaserComplete"
        Me.cboReleaserComplete.Size = New System.Drawing.Size(144, 20)
        Me.cboReleaserComplete.TabIndex = 92
        '
        'cboFlammabilityComplete
        '
        Me.cboFlammabilityComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboFlammabilityComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboFlammabilityComplete.Location = New System.Drawing.Point(346, 505)
        Me.cboFlammabilityComplete.Name = "cboFlammabilityComplete"
        Me.cboFlammabilityComplete.Size = New System.Drawing.Size(143, 20)
        Me.cboFlammabilityComplete.TabIndex = 93
        '
        'cboStressComplete
        '
        Me.cboStressComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboStressComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboStressComplete.Location = New System.Drawing.Point(346, 543)
        Me.cboStressComplete.Name = "cboStressComplete"
        Me.cboStressComplete.Size = New System.Drawing.Size(143, 20)
        Me.cboStressComplete.TabIndex = 94
        '
        'cboEngineerPlannedCompleteDate
        '
        Me.cboEngineerPlannedCompleteDate.CustomFormat = "dd-MMM-yyyy"
        Me.cboEngineerPlannedCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboEngineerPlannedCompleteDate.Location = New System.Drawing.Point(730, 419)
        Me.cboEngineerPlannedCompleteDate.Name = "cboEngineerPlannedCompleteDate"
        Me.cboEngineerPlannedCompleteDate.Size = New System.Drawing.Size(98, 20)
        Me.cboEngineerPlannedCompleteDate.TabIndex = 95
        '
        'cboSrEngineerPlannedCompleteDate
        '
        Me.cboSrEngineerPlannedCompleteDate.CustomFormat = "dd-MMM-yyyy"
        Me.cboSrEngineerPlannedCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboSrEngineerPlannedCompleteDate.Location = New System.Drawing.Point(728, 458)
        Me.cboSrEngineerPlannedCompleteDate.Name = "cboSrEngineerPlannedCompleteDate"
        Me.cboSrEngineerPlannedCompleteDate.Size = New System.Drawing.Size(98, 20)
        Me.cboSrEngineerPlannedCompleteDate.TabIndex = 96
        '
        'cboFlammabilityPlannedCompleteDate
        '
        Me.cboFlammabilityPlannedCompleteDate.CustomFormat = "dd-MMM-yyyy"
        Me.cboFlammabilityPlannedCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboFlammabilityPlannedCompleteDate.Location = New System.Drawing.Point(728, 506)
        Me.cboFlammabilityPlannedCompleteDate.Name = "cboFlammabilityPlannedCompleteDate"
        Me.cboFlammabilityPlannedCompleteDate.Size = New System.Drawing.Size(98, 20)
        Me.cboFlammabilityPlannedCompleteDate.TabIndex = 97
        '
        'cboStressPlannedCompleteDate
        '
        Me.cboStressPlannedCompleteDate.CustomFormat = "dd-MMM-yyyy"
        Me.cboStressPlannedCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboStressPlannedCompleteDate.Location = New System.Drawing.Point(728, 547)
        Me.cboStressPlannedCompleteDate.Name = "cboStressPlannedCompleteDate"
        Me.cboStressPlannedCompleteDate.Size = New System.Drawing.Size(98, 20)
        Me.cboStressPlannedCompleteDate.TabIndex = 98
        '
        'cboReleaserPlannedCompleteDate
        '
        Me.cboReleaserPlannedCompleteDate.CustomFormat = "dd-MMM-yyyy"
        Me.cboReleaserPlannedCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboReleaserPlannedCompleteDate.Location = New System.Drawing.Point(728, 646)
        Me.cboReleaserPlannedCompleteDate.Name = "cboReleaserPlannedCompleteDate"
        Me.cboReleaserPlannedCompleteDate.Size = New System.Drawing.Size(102, 20)
        Me.cboReleaserPlannedCompleteDate.TabIndex = 99
        '
        'cboAvionicsComplete
        '
        Me.cboAvionicsComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboAvionicsComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboAvionicsComplete.Location = New System.Drawing.Point(345, 579)
        Me.cboAvionicsComplete.Name = "cboAvionicsComplete"
        Me.cboAvionicsComplete.Size = New System.Drawing.Size(144, 20)
        Me.cboAvionicsComplete.TabIndex = 100
        '
        'cboAvionicsPlannedComplete
        '
        Me.cboAvionicsPlannedComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboAvionicsPlannedComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboAvionicsPlannedComplete.Location = New System.Drawing.Point(728, 582)
        Me.cboAvionicsPlannedComplete.Name = "cboAvionicsPlannedComplete"
        Me.cboAvionicsPlannedComplete.Size = New System.Drawing.Size(100, 20)
        Me.cboAvionicsPlannedComplete.TabIndex = 101
        '
        'cboMechanicalComplete
        '
        Me.cboMechanicalComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboMechanicalComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboMechanicalComplete.Location = New System.Drawing.Point(346, 618)
        Me.cboMechanicalComplete.Name = "cboMechanicalComplete"
        Me.cboMechanicalComplete.Size = New System.Drawing.Size(143, 20)
        Me.cboMechanicalComplete.TabIndex = 102
        '
        'cboMechanicalPlannedComplete
        '
        Me.cboMechanicalPlannedComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboMechanicalPlannedComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboMechanicalPlannedComplete.Location = New System.Drawing.Point(728, 612)
        Me.cboMechanicalPlannedComplete.Name = "cboMechanicalPlannedComplete"
        Me.cboMechanicalPlannedComplete.Size = New System.Drawing.Size(100, 20)
        Me.cboMechanicalPlannedComplete.TabIndex = 103
        '
        'txtWONumber
        '
        Me.txtWONumber.Location = New System.Drawing.Point(770, 179)
        Me.txtWONumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWONumber.Name = "txtWONumber"
        Me.txtWONumber.Size = New System.Drawing.Size(126, 20)
        Me.txtWONumber.TabIndex = 105
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(727, 178)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(39, 13)
        Me.Label40.TabIndex = 104
        Me.Label40.Text = "WO #:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(519, 216)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(102, 13)
        Me.Label41.TabIndex = 106
        Me.Label41.Text = "Forecast Start Date:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(989, 216)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(130, 13)
        Me.Label42.TabIndex = 107
        Me.Label42.Text = "Estimated Duration Hours:"
        '
        'txtboxEstimatedDuration
        '
        Me.txtboxEstimatedDuration.Location = New System.Drawing.Point(1122, 214)
        Me.txtboxEstimatedDuration.Name = "txtboxEstimatedDuration"
        Me.txtboxEstimatedDuration.Size = New System.Drawing.Size(100, 20)
        Me.txtboxEstimatedDuration.TabIndex = 108
        '
        'txtForecastStartDate
        '
        Me.txtForecastStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.txtForecastStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtForecastStartDate.Location = New System.Drawing.Point(626, 212)
        Me.txtForecastStartDate.Name = "txtForecastStartDate"
        Me.txtForecastStartDate.Size = New System.Drawing.Size(110, 20)
        Me.txtForecastStartDate.TabIndex = 109
        '
        'lblNextHigher
        '
        Me.lblNextHigher.AutoSize = True
        Me.lblNextHigher.Location = New System.Drawing.Point(989, 246)
        Me.lblNextHigher.Name = "lblNextHigher"
        Me.lblNextHigher.Size = New System.Drawing.Size(113, 13)
        Me.lblNextHigher.TabIndex = 110
        Me.lblNextHigher.Text = "Next Higher Assembly:"
        '
        'txtboxNextHigherAssembly
        '
        Me.txtboxNextHigherAssembly.Location = New System.Drawing.Point(1122, 247)
        Me.txtboxNextHigherAssembly.Name = "txtboxNextHigherAssembly"
        Me.txtboxNextHigherAssembly.Size = New System.Drawing.Size(100, 20)
        Me.txtboxNextHigherAssembly.TabIndex = 111
        '
        'frmEditRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 682)
        Me.Controls.Add(Me.txtboxNextHigherAssembly)
        Me.Controls.Add(Me.lblNextHigher)
        Me.Controls.Add(Me.txtForecastStartDate)
        Me.Controls.Add(Me.txtboxEstimatedDuration)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.txtWONumber)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.cboMechanicalPlannedComplete)
        Me.Controls.Add(Me.cboMechanicalComplete)
        Me.Controls.Add(Me.cboAvionicsPlannedComplete)
        Me.Controls.Add(Me.cboAvionicsComplete)
        Me.Controls.Add(Me.cboReleaserPlannedCompleteDate)
        Me.Controls.Add(Me.cboStressPlannedCompleteDate)
        Me.Controls.Add(Me.cboFlammabilityPlannedCompleteDate)
        Me.Controls.Add(Me.cboSrEngineerPlannedCompleteDate)
        Me.Controls.Add(Me.cboEngineerPlannedCompleteDate)
        Me.Controls.Add(Me.cboStressComplete)
        Me.Controls.Add(Me.cboFlammabilityComplete)
        Me.Controls.Add(Me.cboReleaserComplete)
        Me.Controls.Add(Me.cboSrEngineerComplete)
        Me.Controls.Add(Me.cboEngineerComplete)
        Me.Controls.Add(Me.cboDrafterPlannedCompleteDate)
        Me.Controls.Add(Me.cboDrafterComplete)
        Me.Controls.Add(Me.txtForecastFinishDate)
        Me.Controls.Add(Me.txtPlannedFinishDate)
        Me.Controls.Add(Me.txtActualFinishDate)
        Me.Controls.Add(Me.cboDrawingRevision)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.txtDrawingTitle)
        Me.Controls.Add(Me.lblDrawingTitle)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cboMechanical)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.cboAvionics)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txtDrawingNumber)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnSaveRecord)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.cboReleaser)
        Me.Controls.Add(Me.cboStress)
        Me.Controls.Add(Me.cboFlammability)
        Me.Controls.Add(Me.cboSrEngineer)
        Me.Controls.Add(Me.cboEngineer)
        Me.Controls.Add(Me.cboDrafter)
        Me.Controls.Add(Me.txtPercentComplete)
        Me.Controls.Add(Me.txtModelTemplateDate)
        Me.Controls.Add(Me.txtDesignWIPDate)
        Me.Controls.Add(Me.txtDrawingFolderAssignDate)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtRecordID)
        Me.Controls.Add(Me.txtLocation)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEditRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Field Engineering Drawing Status System - Edit Record"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRevisionsLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
	Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents Label16 As Label
	Friend WithEvents Label17 As Label
	Friend WithEvents Label18 As Label
	Friend WithEvents Label19 As Label
	Friend WithEvents Label20 As Label
	Friend WithEvents Label21 As Label
	Friend WithEvents cboStatus As ComboBox
    Friend WithEvents txtDrawingFolderAssignDate As TextBox
    Friend WithEvents txtDesignWIPDate As TextBox
    Friend WithEvents txtModelTemplateDate As TextBox
    Friend WithEvents txtPercentComplete As TextBox
    Friend WithEvents cboDrafter As ComboBox
    Friend WithEvents cboEngineer As ComboBox
    Friend WithEvents cboSrEngineer As ComboBox
    Friend WithEvents cboFlammability As ComboBox
    Friend WithEvents cboStress As ComboBox
    Friend WithEvents cboReleaser As ComboBox
    Friend WithEvents txtRecordID As TextBox
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet31 As DataSet3
    Friend WithEvents colPriority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRequestBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents btnSaveRecord As Button
    Friend WithEvents colDrawingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtDrawingNumber As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents cboAvionics As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents cboMechanical As ComboBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label38 As Label
    Friend WithEvents txtDrawingTitle As TextBox
    Friend WithEvents lblDrawingTitle As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents cboDrawingRevision As ComboBox
    Friend WithEvents txtActualFinishDate As DateTimePicker
    Friend WithEvents txtPlannedFinishDate As DateTimePicker
    Friend WithEvents txtForecastFinishDate As DateTimePicker
    Friend WithEvents cboDrafterComplete As DateTimePicker
    Friend WithEvents cboDrafterPlannedCompleteDate As DateTimePicker
    Friend WithEvents cboEngineerComplete As DateTimePicker
    Friend WithEvents cboSrEngineerComplete As DateTimePicker
    Friend WithEvents cboReleaserComplete As DateTimePicker
    Friend WithEvents cboFlammabilityComplete As DateTimePicker
    Friend WithEvents cboStressComplete As DateTimePicker
    Friend WithEvents cboEngineerPlannedCompleteDate As DateTimePicker
    Friend WithEvents cboSrEngineerPlannedCompleteDate As DateTimePicker
    Friend WithEvents cboFlammabilityPlannedCompleteDate As DateTimePicker
    Friend WithEvents cboStressPlannedCompleteDate As DateTimePicker
    Friend WithEvents cboReleaserPlannedCompleteDate As DateTimePicker
    Friend WithEvents cboAvionicsComplete As DateTimePicker
    Friend WithEvents cboAvionicsPlannedComplete As DateTimePicker
    Friend WithEvents cboMechanicalComplete As DateTimePicker
    Friend WithEvents cboMechanicalPlannedComplete As DateTimePicker
    Friend WithEvents TblRevisionsLookupBindingSource As BindingSource
    Friend WithEvents txtWONumber As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents txtboxEstimatedDuration As TextBox
    Friend WithEvents txtForecastStartDate As DateTimePicker
    Friend WithEvents lblNextHigher As Label
    Friend WithEvents txtboxNextHigherAssembly As TextBox
End Class
