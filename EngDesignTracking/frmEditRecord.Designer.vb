<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditRecord))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet31 = New EngDesignTracking.DataSet3()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.txtWONumber = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtboxEstimatedDuration = New System.Windows.Forms.TextBox()
        Me.txtForecastStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblNextHigher = New System.Windows.Forms.Label()
        Me.txtboxNextHigherAssembly = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboProgram = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtInstallationDrawing = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtFAAProjectNo = New System.Windows.Forms.TextBox()
        Me.cboPSCPDocsRequired = New System.Windows.Forms.ComboBox()
        Me.cboCompanyFlightTestRequired = New System.Windows.Forms.ComboBox()
        Me.cboDRNADCN = New System.Windows.Forms.ComboBox()
        Me.cboWhiteBoardNumber = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtNewRework = New System.Windows.Forms.TextBox()
        Me.txtDocumentType = New System.Windows.Forms.TextBox()
        Me.txtPercentComplete = New System.Windows.Forms.MaskedTextBox()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GridControl1.Location = New System.Drawing.Point(9, 10)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1210, 123)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.colDocumentType, Me.colPriority, Me.colLocation})
        Me.GridView1.DetailHeight = 182
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.LevelIndent = 0
        Me.GridView1.Name = "GridView1"
        Me.GridView1.PreviewIndent = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Document #"
        Me.GridColumn1.FieldName = "DrawingNumber"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Document Rev"
        Me.GridColumn2.FieldName = "DwgRevision"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Document Type"
        Me.GridColumn3.FieldName = "DrawingType"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        '
        'colDocumentType
        '
        Me.colDocumentType.FieldName = "DocumentType"
        Me.colDocumentType.Name = "colDocumentType"
        Me.colDocumentType.Visible = True
        Me.colDocumentType.VisibleIndex = 3
        Me.colDocumentType.Width = 112
        '
        'colPriority
        '
        Me.colPriority.FieldName = "Priority"
        Me.colPriority.Name = "colPriority"
        Me.colPriority.OptionsColumn.ReadOnly = True
        Me.colPriority.Visible = True
        Me.colPriority.VisibleIndex = 2
        '
        'colLocation
        '
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.OptionsColumn.ReadOnly = True
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(911, 157)
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
        Me.Label5.Size = New System.Drawing.Size(151, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Document Folder Assign Date:"
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
        Me.Label9.Location = New System.Drawing.Point(29, 314)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Notes:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 417)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Drafter:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(208, 417)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Drafter Complete:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 458)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Operations:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(207, 458)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Operations Complete:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 498)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Sr Engineer:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(208, 498)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Sr Engineer Complete:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 621)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Flammability:"
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(209, 621)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Flammability Complete:"
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(21, 625)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Stress:"
        Me.Label18.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(207, 625)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 13)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Stress Complete:"
        Me.Label19.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(21, 544)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Releaser"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(208, 544)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(99, 13)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "Releaser Complete:"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(955, 158)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(264, 21)
        Me.cboStatus.TabIndex = 26
        '
        'txtDrawingFolderAssignDate
        '
        Me.txtDrawingFolderAssignDate.Location = New System.Drawing.Point(175, 246)
        Me.txtDrawingFolderAssignDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDrawingFolderAssignDate.Name = "txtDrawingFolderAssignDate"
        Me.txtDrawingFolderAssignDate.Size = New System.Drawing.Size(110, 20)
        Me.txtDrawingFolderAssignDate.TabIndex = 30
        '
        'txtDesignWIPDate
        '
        Me.txtDesignWIPDate.Location = New System.Drawing.Point(394, 247)
        Me.txtDesignWIPDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDesignWIPDate.Name = "txtDesignWIPDate"
        Me.txtDesignWIPDate.Size = New System.Drawing.Size(110, 20)
        Me.txtDesignWIPDate.TabIndex = 31
        '
        'txtModelTemplateDate
        '
        Me.txtModelTemplateDate.Location = New System.Drawing.Point(626, 246)
        Me.txtModelTemplateDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtModelTemplateDate.Name = "txtModelTemplateDate"
        Me.txtModelTemplateDate.Size = New System.Drawing.Size(110, 20)
        Me.txtModelTemplateDate.TabIndex = 32
        '
        'cboDrafter
        '
        Me.cboDrafter.FormattingEnabled = True
        Me.cboDrafter.Location = New System.Drawing.Point(103, 417)
        Me.cboDrafter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboDrafter.Name = "cboDrafter"
        Me.cboDrafter.Size = New System.Drawing.Size(98, 21)
        Me.cboDrafter.TabIndex = 34
        '
        'cboEngineer
        '
        Me.cboEngineer.FormattingEnabled = True
        Me.cboEngineer.Location = New System.Drawing.Point(101, 458)
        Me.cboEngineer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboEngineer.Name = "cboEngineer"
        Me.cboEngineer.Size = New System.Drawing.Size(98, 21)
        Me.cboEngineer.TabIndex = 36
        '
        'cboSrEngineer
        '
        Me.cboSrEngineer.FormattingEnabled = True
        Me.cboSrEngineer.Location = New System.Drawing.Point(103, 498)
        Me.cboSrEngineer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboSrEngineer.Name = "cboSrEngineer"
        Me.cboSrEngineer.Size = New System.Drawing.Size(98, 21)
        Me.cboSrEngineer.TabIndex = 38
        '
        'cboFlammability
        '
        Me.cboFlammability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFlammability.FormattingEnabled = True
        Me.cboFlammability.Location = New System.Drawing.Point(109, 620)
        Me.cboFlammability.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboFlammability.Name = "cboFlammability"
        Me.cboFlammability.Size = New System.Drawing.Size(98, 21)
        Me.cboFlammability.TabIndex = 40
        Me.cboFlammability.Visible = False
        '
        'cboStress
        '
        Me.cboStress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStress.FormattingEnabled = True
        Me.cboStress.Location = New System.Drawing.Point(101, 625)
        Me.cboStress.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboStress.Name = "cboStress"
        Me.cboStress.Size = New System.Drawing.Size(98, 21)
        Me.cboStress.TabIndex = 42
        Me.cboStress.Visible = False
        '
        'cboReleaser
        '
        Me.cboReleaser.FormattingEnabled = True
        Me.cboReleaser.Location = New System.Drawing.Point(103, 544)
        Me.cboReleaser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboReleaser.Name = "cboReleaser"
        Me.cboReleaser.Size = New System.Drawing.Size(98, 21)
        Me.cboReleaser.TabIndex = 44
        '
        'txtRecordID
        '
        Me.txtRecordID.Location = New System.Drawing.Point(437, 113)
        Me.txtRecordID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.txtNotes.Location = New System.Drawing.Point(79, 314)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawings", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DocumentType", "DocumentType"), New System.Data.Common.DataColumnMapping("Priority", "Priority"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("DwgRequestBy", "DwgRequestBy"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DwgRequestDate", "DwgRequestDate"), New System.Data.Common.DataColumnMapping("DrawingTitle", "DrawingTitle"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("DrawingType", "DrawingType"), New System.Data.Common.DataColumnMapping("SystemDescription", "SystemDescription"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("LastActionDate", "LastActionDate"), New System.Data.Common.DataColumnMapping("ActualFinishDate", "ActualFinishDate"), New System.Data.Common.DataColumnMapping("ForecastStartDate", "ForecastStartDate"), New System.Data.Common.DataColumnMapping("ForecastFinishDate", "ForecastFinishDate"), New System.Data.Common.DataColumnMapping("PlannedFinishDate", "PlannedFinishDate"), New System.Data.Common.DataColumnMapping("EstimatedDurationHours", "EstimatedDurationHours"), New System.Data.Common.DataColumnMapping("PercentComplete", "PercentComplete"), New System.Data.Common.DataColumnMapping("DrawingFolderAssignDate", "DrawingFolderAssignDate"), New System.Data.Common.DataColumnMapping("DesignWIPDate", "DesignWIPDate"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("ModelTemplateDate", "ModelTemplateDate"), New System.Data.Common.DataColumnMapping("Drafter", "Drafter"), New System.Data.Common.DataColumnMapping("DrafterComplete", "DrafterComplete"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerComplete", "EngineerComplete"), New System.Data.Common.DataColumnMapping("SrEngineer", "SrEngineer"), New System.Data.Common.DataColumnMapping("SrEngineerComplete", "SrEngineerComplete"), New System.Data.Common.DataColumnMapping("Releaser", "Releaser"), New System.Data.Common.DataColumnMapping("ReleaserCompelte", "ReleaserCompelte"), New System.Data.Common.DataColumnMapping("Flammability", "Flammability"), New System.Data.Common.DataColumnMapping("FlammabilityComplete", "FlammabilityComplete"), New System.Data.Common.DataColumnMapping("Stress", "Stress"), New System.Data.Common.DataColumnMapping("StressComplete", "StressComplete"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("RefID", "RefID"), New System.Data.Common.DataColumnMapping("DrafterPlannedCompleteDate", "DrafterPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("EngineerPlannedCompleteDate", "EngineerPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("SrEngineerPlannedCompleteDate", "SrEngineerPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("FlammabilityPlannedCompleteDate", "FlammabilityPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("StressPlannedCompleteDate", "StressPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("ReleaserPlannedCompleteDate", "ReleaserPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("Avionics", "Avionics"), New System.Data.Common.DataColumnMapping("AvionicsComplete", "AvionicsComplete"), New System.Data.Common.DataColumnMapping("AvionicsPlannedComplete", "AvionicsPlannedComplete"), New System.Data.Common.DataColumnMapping("Mechanical", "Mechanical"), New System.Data.Common.DataColumnMapping("MechanicalComplete", "MechanicalComplete"), New System.Data.Common.DataColumnMapping("MechanicalPlannedComplete", "MechanicalPlannedComplete"), New System.Data.Common.DataColumnMapping("WONumber", "WONumber"), New System.Data.Common.DataColumnMapping("NextHigherAssembly", "NextHigherAssembly"), New System.Data.Common.DataColumnMapping("InstallationDrawing", "InstallationDrawing"), New System.Data.Common.DataColumnMapping("WhiteBoardNumber", "WhiteBoardNumber"), New System.Data.Common.DataColumnMapping("DRNADCN", "DRNADCN"), New System.Data.Common.DataColumnMapping("FAAProjectNo", "FAAProjectNo"), New System.Data.Common.DataColumnMapping("PSCPDocsRequired", "PSCPDocsRequired"), New System.Data.Common.DataColumnMapping("CompanyFlightTestRequired", "CompanyFlightTestRequired"), New System.Data.Common.DataColumnMapping("DwgReqDate", "DwgReqDate"), New System.Data.Common.DataColumnMapping("NewRework", "NewRework"), New System.Data.Common.DataColumnMapping("Updated", "Updated"), New System.Data.Common.DataColumnMapping("Sort", "Sort")})})
        '
        'btnSaveRecord
        '
        Me.btnSaveRecord.Location = New System.Drawing.Point(1046, 617)
        Me.btnSaveRecord.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSaveRecord.Name = "btnSaveRecord"
        Me.btnSaveRecord.Size = New System.Drawing.Size(110, 34)
        Me.btnSaveRecord.TabIndex = 48
        Me.btnSaveRecord.Text = "Save Record"
        Me.btnSaveRecord.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(520, 417)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(157, 13)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "Drafter Planned Complete Date:"
        Me.Label22.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(519, 458)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(167, 13)
        Me.Label23.TabIndex = 50
        Me.Label23.Text = "Engineer Planned Complete Date:"
        Me.Label23.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(520, 498)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(180, 13)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Sr Engineer Planned Complete Date:"
        Me.Label24.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(523, 620)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(181, 13)
        Me.Label25.TabIndex = 52
        Me.Label25.Text = "Flammability Planned Complete Date:"
        Me.Label25.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(519, 625)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(154, 13)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "Stress Planned Complete Date:"
        Me.Label26.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(520, 544)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(167, 13)
        Me.Label27.TabIndex = 54
        Me.Label27.Text = "Releaser Planned Complete Date:"
        Me.Label27.Visible = False
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
        Me.Label28.Location = New System.Drawing.Point(90, 389)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 13)
        Me.Label28.TabIndex = 62
        Me.Label28.Text = "Name of Employee"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(314, 389)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(127, 13)
        Me.Label29.TabIndex = 63
        Me.Label29.Text = "Date Stage Complete"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(658, 389)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(177, 13)
        Me.Label30.TabIndex = 64
        Me.Label30.Text = "Planned Date Stage Complete"
        Me.Label30.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(12, 157)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(99, 13)
        Me.Label31.TabIndex = 65
        Me.Label31.Text = "Document Number:"
        '
        'txtDrawingNumber
        '
        Me.txtDrawingNumber.Location = New System.Drawing.Point(123, 157)
        Me.txtDrawingNumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDrawingNumber.Name = "txtDrawingNumber"
        Me.txtDrawingNumber.Size = New System.Drawing.Size(126, 20)
        Me.txtDrawingNumber.TabIndex = 66
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(23, 604)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(50, 13)
        Me.Label32.TabIndex = 67
        Me.Label32.Text = "Avionics:"
        Me.Label32.Visible = False
        '
        'cboAvionics
        '
        Me.cboAvionics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAvionics.FormattingEnabled = True
        Me.cboAvionics.Location = New System.Drawing.Point(103, 601)
        Me.cboAvionics.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboAvionics.Name = "cboAvionics"
        Me.cboAvionics.Size = New System.Drawing.Size(98, 21)
        Me.cboAvionics.TabIndex = 68
        Me.cboAvionics.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(209, 604)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(97, 13)
        Me.Label33.TabIndex = 69
        Me.Label33.Text = "Avionics Complete:"
        Me.Label33.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(521, 603)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(139, 13)
        Me.Label34.TabIndex = 70
        Me.Label34.Text = "Avionics Planned Complete:"
        Me.Label34.Visible = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(23, 634)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(65, 13)
        Me.Label35.TabIndex = 71
        Me.Label35.Text = "Mechanical:"
        Me.Label35.Visible = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(209, 634)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(112, 13)
        Me.Label36.TabIndex = 72
        Me.Label36.Text = "Mechanical Complete:"
        Me.Label36.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(521, 634)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(154, 13)
        Me.Label37.TabIndex = 73
        Me.Label37.Text = "Mechanical Planned Complete:"
        Me.Label37.Visible = False
        '
        'cboMechanical
        '
        Me.cboMechanical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMechanical.FormattingEnabled = True
        Me.cboMechanical.Location = New System.Drawing.Point(104, 634)
        Me.cboMechanical.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMechanical.Name = "cboMechanical"
        Me.cboMechanical.Size = New System.Drawing.Size(98, 21)
        Me.cboMechanical.TabIndex = 76
        Me.cboMechanical.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(944, 617)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 34)
        Me.btnClose.TabIndex = 79
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtDrawingTitle
        '
        Me.txtDrawingTitle.Location = New System.Drawing.Point(587, 157)
        Me.txtDrawingTitle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDrawingTitle.Name = "txtDrawingTitle"
        Me.txtDrawingTitle.Size = New System.Drawing.Size(126, 20)
        Me.txtDrawingTitle.TabIndex = 82
        '
        'lblDrawingTitle
        '
        Me.lblDrawingTitle.AutoSize = True
        Me.lblDrawingTitle.Location = New System.Drawing.Point(493, 157)
        Me.lblDrawingTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDrawingTitle.Name = "lblDrawingTitle"
        Me.lblDrawingTitle.Size = New System.Drawing.Size(82, 13)
        Me.lblDrawingTitle.TabIndex = 81
        Me.lblDrawingTitle.Text = "Document Title:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(271, 157)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(74, 13)
        Me.Label39.TabIndex = 83
        Me.Label39.Text = "Doc Revision:"
        '
        'cboDrawingRevision
        '
        Me.cboDrawingRevision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDrawingRevision.FormattingEnabled = True
        Me.cboDrawingRevision.Location = New System.Drawing.Point(365, 157)
        Me.cboDrawingRevision.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboDrawingRevision.Name = "cboDrawingRevision"
        Me.cboDrawingRevision.Size = New System.Drawing.Size(113, 21)
        Me.cboDrawingRevision.TabIndex = 84
        '
        'txtActualFinishDate
        '
        Me.txtActualFinishDate.CustomFormat = "dd-MMM-yyyy"
        Me.txtActualFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtActualFinishDate.Location = New System.Drawing.Point(127, 212)
        Me.txtActualFinishDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.cboDrafterComplete.Location = New System.Drawing.Point(338, 418)
        Me.cboDrafterComplete.Name = "cboDrafterComplete"
        Me.cboDrafterComplete.Size = New System.Drawing.Size(143, 20)
        Me.cboDrafterComplete.TabIndex = 88
        '
        'cboDrafterPlannedCompleteDate
        '
        Me.cboDrafterPlannedCompleteDate.CustomFormat = "dd-MMM-yyyy"
        Me.cboDrafterPlannedCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboDrafterPlannedCompleteDate.Location = New System.Drawing.Point(722, 414)
        Me.cboDrafterPlannedCompleteDate.Name = "cboDrafterPlannedCompleteDate"
        Me.cboDrafterPlannedCompleteDate.Size = New System.Drawing.Size(98, 20)
        Me.cboDrafterPlannedCompleteDate.TabIndex = 89
        Me.cboDrafterPlannedCompleteDate.Visible = False
        '
        'cboEngineerComplete
        '
        Me.cboEngineerComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboEngineerComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboEngineerComplete.Location = New System.Drawing.Point(337, 457)
        Me.cboEngineerComplete.Name = "cboEngineerComplete"
        Me.cboEngineerComplete.Size = New System.Drawing.Size(143, 20)
        Me.cboEngineerComplete.TabIndex = 90
        '
        'cboSrEngineerComplete
        '
        Me.cboSrEngineerComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboSrEngineerComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboSrEngineerComplete.Location = New System.Drawing.Point(337, 495)
        Me.cboSrEngineerComplete.Name = "cboSrEngineerComplete"
        Me.cboSrEngineerComplete.Size = New System.Drawing.Size(144, 20)
        Me.cboSrEngineerComplete.TabIndex = 91
        '
        'cboReleaserComplete
        '
        Me.cboReleaserComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboReleaserComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboReleaserComplete.Location = New System.Drawing.Point(335, 543)
        Me.cboReleaserComplete.Name = "cboReleaserComplete"
        Me.cboReleaserComplete.Size = New System.Drawing.Size(144, 20)
        Me.cboReleaserComplete.TabIndex = 92
        '
        'cboFlammabilityComplete
        '
        Me.cboFlammabilityComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboFlammabilityComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboFlammabilityComplete.Location = New System.Drawing.Point(344, 620)
        Me.cboFlammabilityComplete.Name = "cboFlammabilityComplete"
        Me.cboFlammabilityComplete.Size = New System.Drawing.Size(143, 20)
        Me.cboFlammabilityComplete.TabIndex = 93
        '
        'cboStressComplete
        '
        Me.cboStressComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboStressComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboStressComplete.Location = New System.Drawing.Point(337, 622)
        Me.cboStressComplete.Name = "cboStressComplete"
        Me.cboStressComplete.Size = New System.Drawing.Size(143, 20)
        Me.cboStressComplete.TabIndex = 94
        Me.cboStressComplete.Visible = False
        '
        'cboEngineerPlannedCompleteDate
        '
        Me.cboEngineerPlannedCompleteDate.CustomFormat = "dd-MMM-yyyy"
        Me.cboEngineerPlannedCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboEngineerPlannedCompleteDate.Location = New System.Drawing.Point(721, 458)
        Me.cboEngineerPlannedCompleteDate.Name = "cboEngineerPlannedCompleteDate"
        Me.cboEngineerPlannedCompleteDate.Size = New System.Drawing.Size(98, 20)
        Me.cboEngineerPlannedCompleteDate.TabIndex = 95
        Me.cboEngineerPlannedCompleteDate.Visible = False
        '
        'cboSrEngineerPlannedCompleteDate
        '
        Me.cboSrEngineerPlannedCompleteDate.CustomFormat = "dd-MMM-yyyy"
        Me.cboSrEngineerPlannedCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboSrEngineerPlannedCompleteDate.Location = New System.Drawing.Point(720, 494)
        Me.cboSrEngineerPlannedCompleteDate.Name = "cboSrEngineerPlannedCompleteDate"
        Me.cboSrEngineerPlannedCompleteDate.Size = New System.Drawing.Size(98, 20)
        Me.cboSrEngineerPlannedCompleteDate.TabIndex = 96
        Me.cboSrEngineerPlannedCompleteDate.Visible = False
        '
        'cboFlammabilityPlannedCompleteDate
        '
        Me.cboFlammabilityPlannedCompleteDate.CustomFormat = "dd-MMM-yyyy"
        Me.cboFlammabilityPlannedCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboFlammabilityPlannedCompleteDate.Location = New System.Drawing.Point(726, 621)
        Me.cboFlammabilityPlannedCompleteDate.Name = "cboFlammabilityPlannedCompleteDate"
        Me.cboFlammabilityPlannedCompleteDate.Size = New System.Drawing.Size(98, 20)
        Me.cboFlammabilityPlannedCompleteDate.TabIndex = 97
        Me.cboFlammabilityPlannedCompleteDate.Visible = False
        '
        'cboStressPlannedCompleteDate
        '
        Me.cboStressPlannedCompleteDate.CustomFormat = "dd-MMM-yyyy"
        Me.cboStressPlannedCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboStressPlannedCompleteDate.Location = New System.Drawing.Point(719, 626)
        Me.cboStressPlannedCompleteDate.Name = "cboStressPlannedCompleteDate"
        Me.cboStressPlannedCompleteDate.Size = New System.Drawing.Size(98, 20)
        Me.cboStressPlannedCompleteDate.TabIndex = 98
        Me.cboStressPlannedCompleteDate.Visible = False
        '
        'cboReleaserPlannedCompleteDate
        '
        Me.cboReleaserPlannedCompleteDate.CustomFormat = "dd-MMM-yyyy"
        Me.cboReleaserPlannedCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboReleaserPlannedCompleteDate.Location = New System.Drawing.Point(715, 540)
        Me.cboReleaserPlannedCompleteDate.Name = "cboReleaserPlannedCompleteDate"
        Me.cboReleaserPlannedCompleteDate.Size = New System.Drawing.Size(102, 20)
        Me.cboReleaserPlannedCompleteDate.TabIndex = 99
        Me.cboReleaserPlannedCompleteDate.Visible = False
        '
        'cboAvionicsComplete
        '
        Me.cboAvionicsComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboAvionicsComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboAvionicsComplete.Location = New System.Drawing.Point(339, 599)
        Me.cboAvionicsComplete.Name = "cboAvionicsComplete"
        Me.cboAvionicsComplete.Size = New System.Drawing.Size(144, 20)
        Me.cboAvionicsComplete.TabIndex = 100
        Me.cboAvionicsComplete.Visible = False
        '
        'cboAvionicsPlannedComplete
        '
        Me.cboAvionicsPlannedComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboAvionicsPlannedComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboAvionicsPlannedComplete.Location = New System.Drawing.Point(721, 601)
        Me.cboAvionicsPlannedComplete.Name = "cboAvionicsPlannedComplete"
        Me.cboAvionicsPlannedComplete.Size = New System.Drawing.Size(100, 20)
        Me.cboAvionicsPlannedComplete.TabIndex = 101
        Me.cboAvionicsPlannedComplete.Visible = False
        '
        'cboMechanicalComplete
        '
        Me.cboMechanicalComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboMechanicalComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboMechanicalComplete.Location = New System.Drawing.Point(339, 636)
        Me.cboMechanicalComplete.Name = "cboMechanicalComplete"
        Me.cboMechanicalComplete.Size = New System.Drawing.Size(143, 20)
        Me.cboMechanicalComplete.TabIndex = 102
        Me.cboMechanicalComplete.Visible = False
        '
        'cboMechanicalPlannedComplete
        '
        Me.cboMechanicalPlannedComplete.CustomFormat = "dd-MMM-yyyy"
        Me.cboMechanicalPlannedComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cboMechanicalPlannedComplete.Location = New System.Drawing.Point(721, 630)
        Me.cboMechanicalPlannedComplete.Name = "cboMechanicalPlannedComplete"
        Me.cboMechanicalPlannedComplete.Size = New System.Drawing.Size(100, 20)
        Me.cboMechanicalPlannedComplete.TabIndex = 103
        Me.cboMechanicalPlannedComplete.Visible = False
        '
        'txtWONumber
        '
        Me.txtWONumber.Location = New System.Drawing.Point(771, 158)
        Me.txtWONumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWONumber.Name = "txtWONumber"
        Me.txtWONumber.Size = New System.Drawing.Size(126, 20)
        Me.txtWONumber.TabIndex = 105
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(728, 157)
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
        Me.Label42.Location = New System.Drawing.Point(987, 295)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(130, 13)
        Me.Label42.TabIndex = 107
        Me.Label42.Text = "Estimated Duration Hours:"
        '
        'txtboxEstimatedDuration
        '
        Me.txtboxEstimatedDuration.Location = New System.Drawing.Point(1119, 293)
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
        Me.lblNextHigher.Location = New System.Drawing.Point(987, 325)
        Me.lblNextHigher.Name = "lblNextHigher"
        Me.lblNextHigher.Size = New System.Drawing.Size(113, 13)
        Me.lblNextHigher.TabIndex = 110
        Me.lblNextHigher.Text = "Next Higher Assembly:"
        '
        'txtboxNextHigherAssembly
        '
        Me.txtboxNextHigherAssembly.Location = New System.Drawing.Point(1119, 326)
        Me.txtboxNextHigherAssembly.Name = "txtboxNextHigherAssembly"
        Me.txtboxNextHigherAssembly.Size = New System.Drawing.Size(100, 20)
        Me.txtboxNextHigherAssembly.TabIndex = 111
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(983, 215)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(83, 13)
        Me.Label43.TabIndex = 113
        Me.Label43.Text = "Resource Type:"
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(1071, 213)
        Me.cboType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(148, 21)
        Me.cboType.TabIndex = 112
        '
        'cboProgram
        '
        Me.cboProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProgram.FormattingEnabled = True
        Me.cboProgram.Location = New System.Drawing.Point(125, 185)
        Me.cboProgram.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboProgram.Name = "cboProgram"
        Me.cboProgram.Size = New System.Drawing.Size(165, 21)
        Me.cboProgram.TabIndex = 115
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(31, 185)
        Me.Label44.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(80, 13)
        Me.Label44.TabIndex = 114
        Me.Label44.Text = "Program Name:"
        '
        'txtInstallationDrawing
        '
        Me.txtInstallationDrawing.Location = New System.Drawing.Point(1119, 360)
        Me.txtInstallationDrawing.Name = "txtInstallationDrawing"
        Me.txtInstallationDrawing.Size = New System.Drawing.Size(100, 20)
        Me.txtInstallationDrawing.TabIndex = 117
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(987, 359)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(102, 13)
        Me.Label45.TabIndex = 116
        Me.Label45.Text = "Installation Drawing:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(306, 185)
        Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(124, 13)
        Me.Label46.TabIndex = 118
        Me.Label46.Text = "White Board Tracking #:"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(983, 246)
        Me.Label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(69, 13)
        Me.Label47.TabIndex = 120
        Me.Label47.Text = "DRN/ADCN:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(29, 281)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(77, 13)
        Me.Label48.TabIndex = 122
        Me.Label48.Text = "FAAProjectNo:"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(243, 281)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(141, 13)
        Me.Label49.TabIndex = 123
        Me.Label49.Text = "PSCP Documents Required:"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(509, 281)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(152, 13)
        Me.Label50.TabIndex = 124
        Me.Label50.Text = "Company Flight Test Required:"
        '
        'txtFAAProjectNo
        '
        Me.txtFAAProjectNo.Location = New System.Drawing.Point(112, 278)
        Me.txtFAAProjectNo.Name = "txtFAAProjectNo"
        Me.txtFAAProjectNo.Size = New System.Drawing.Size(125, 20)
        Me.txtFAAProjectNo.TabIndex = 125
        '
        'cboPSCPDocsRequired
        '
        Me.cboPSCPDocsRequired.FormattingEnabled = True
        Me.cboPSCPDocsRequired.Location = New System.Drawing.Point(382, 281)
        Me.cboPSCPDocsRequired.Name = "cboPSCPDocsRequired"
        Me.cboPSCPDocsRequired.Size = New System.Drawing.Size(121, 21)
        Me.cboPSCPDocsRequired.TabIndex = 126
        '
        'cboCompanyFlightTestRequired
        '
        Me.cboCompanyFlightTestRequired.FormattingEnabled = True
        Me.cboCompanyFlightTestRequired.Location = New System.Drawing.Point(661, 280)
        Me.cboCompanyFlightTestRequired.Name = "cboCompanyFlightTestRequired"
        Me.cboCompanyFlightTestRequired.Size = New System.Drawing.Size(121, 21)
        Me.cboCompanyFlightTestRequired.TabIndex = 127
        '
        'cboDRNADCN
        '
        Me.cboDRNADCN.FormattingEnabled = True
        Me.cboDRNADCN.Location = New System.Drawing.Point(1071, 243)
        Me.cboDRNADCN.Name = "cboDRNADCN"
        Me.cboDRNADCN.Size = New System.Drawing.Size(148, 21)
        Me.cboDRNADCN.TabIndex = 128
        '
        'cboWhiteBoardNumber
        '
        Me.cboWhiteBoardNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWhiteBoardNumber.FormattingEnabled = True
        Me.cboWhiteBoardNumber.Location = New System.Drawing.Point(437, 185)
        Me.cboWhiteBoardNumber.Name = "cboWhiteBoardNumber"
        Me.cboWhiteBoardNumber.Size = New System.Drawing.Size(121, 21)
        Me.cboWhiteBoardNumber.TabIndex = 129
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(584, 185)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(74, 13)
        Me.Label38.TabIndex = 130
        Me.Label38.Text = "New/Rework:"
        '
        'txtNewRework
        '
        Me.txtNewRework.Location = New System.Drawing.Point(656, 185)
        Me.txtNewRework.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNewRework.Name = "txtNewRework"
        Me.txtNewRework.ReadOnly = True
        Me.txtNewRework.Size = New System.Drawing.Size(126, 20)
        Me.txtNewRework.TabIndex = 131
        '
        'txtDocumentType
        '
        Me.txtDocumentType.Location = New System.Drawing.Point(809, 113)
        Me.txtDocumentType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDocumentType.Name = "txtDocumentType"
        Me.txtDocumentType.Size = New System.Drawing.Size(68, 20)
        Me.txtDocumentType.TabIndex = 132
        '
        'txtPercentComplete
        '
        Me.txtPercentComplete.Location = New System.Drawing.Point(862, 243)
        Me.txtPercentComplete.Mask = "###"
        Me.txtPercentComplete.Name = "txtPercentComplete"
        Me.txtPercentComplete.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentComplete.TabIndex = 133
        '
        'frmEditRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 573)
        Me.Controls.Add(Me.txtPercentComplete)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtNewRework)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.cboWhiteBoardNumber)
        Me.Controls.Add(Me.cboDRNADCN)
        Me.Controls.Add(Me.cboCompanyFlightTestRequired)
        Me.Controls.Add(Me.cboPSCPDocsRequired)
        Me.Controls.Add(Me.txtFAAProjectNo)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.txtInstallationDrawing)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.cboProgram)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.cboType)
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
        Me.Controls.Add(Me.txtRecordID)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtDocumentType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmEditRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Field Engineering Drawing Status System - Edit Record"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents colPriority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents btnSaveRecord As Button
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
    Friend WithEvents txtWONumber As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents txtboxEstimatedDuration As TextBox
    Friend WithEvents txtForecastStartDate As DateTimePicker
    Friend WithEvents lblNextHigher As Label
    Friend WithEvents txtboxNextHigherAssembly As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents cboProgram As ComboBox
    Friend WithEvents Label44 As Label
    Friend WithEvents txtInstallationDrawing As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents txtFAAProjectNo As TextBox
    Friend WithEvents cboPSCPDocsRequired As ComboBox
    Friend WithEvents cboCompanyFlightTestRequired As ComboBox
    Friend WithEvents cboDRNADCN As ComboBox
    Friend WithEvents cboWhiteBoardNumber As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents txtNewRework As TextBox
    Friend WithEvents txtDocumentType As TextBox
    Friend WithEvents txtPercentComplete As MaskedTextBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataSet31 As DataSet3
    Friend WithEvents colDocumentType As DevExpress.XtraGrid.Columns.GridColumn
End Class
