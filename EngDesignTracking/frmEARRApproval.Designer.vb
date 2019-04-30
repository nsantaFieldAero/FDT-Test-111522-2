<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEARRApproval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEARRApproval))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet51 = New EngDesignTracking.DataSet5()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEARRNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEARRStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEARRType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabShop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox5 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.DataSet51BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnRescind = New System.Windows.Forms.Button()
        Me.btnEngManagerSignOff = New System.Windows.Forms.Button()
        Me.dtEngineeringManagerSignOffDate = New System.Windows.Forms.DateTimePicker()
        Me.txtEngineeringManagerNameBackup = New System.Windows.Forms.TextBox()
        Me.txtEngineeringManagerName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtEndItemType = New System.Windows.Forms.TextBox()
        Me.dtEARRResponseDate = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEARRNumber = New System.Windows.Forms.TextBox()
        Me.dtOriginatorDate = New System.Windows.Forms.DateTimePicker()
        Me.txtOriginatorName = New System.Windows.Forms.TextBox()
        Me.txtRequest = New System.Windows.Forms.TextBox()
        Me.txtDrawingRevision = New System.Windows.Forms.TextBox()
        Me.txtDrawingNumber = New System.Windows.Forms.TextBox()
        Me.txtWorkOrder = New System.Windows.Forms.TextBox()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.cboEARRType = New System.Windows.Forms.ComboBox()
        Me.cboProgramName = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDrawingRequestForConformityNo = New System.Windows.Forms.CheckBox()
        Me.chkDrawingRequestForConformityYes = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkIncorpRedLineNo = New System.Windows.Forms.CheckBox()
        Me.chkIncorpRedLineYes = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnLiaisonSignOff = New System.Windows.Forms.Button()
        Me.dtLiaisonManagerSignOffDate = New System.Windows.Forms.DateTimePicker()
        Me.txtLiaisonManagerNameBackup = New System.Windows.Forms.TextBox()
        Me.txtLiaisonManagerName = New System.Windows.Forms.TextBox()
        Me.txtReplyInstructions = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkProductionError = New System.Windows.Forms.CheckBox()
        Me.chkDesignError = New System.Windows.Forms.CheckBox()
        Me.chkDWGError = New System.Windows.Forms.CheckBox()
        Me.chkProductImprovement = New System.Windows.Forms.CheckBox()
        Me.chkManufacturability = New System.Windows.Forms.CheckBox()
        Me.chkACFTInterface = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkAdditionalEngReqUpdate = New System.Windows.Forms.CheckBox()
        Me.chkAdditionalEngReqNoAction = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkDeviationNA = New System.Windows.Forms.CheckBox()
        Me.chkDeviationMajor = New System.Windows.Forms.CheckBox()
        Me.chkDeviationMinor = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtEffectivityOtherText = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkEffectivityOther = New System.Windows.Forms.CheckBox()
        Me.chkEffectivityAll = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtQCNotes = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnQCSignOff = New System.Windows.Forms.Button()
        Me.dtQCDateSignoff = New System.Windows.Forms.DateTimePicker()
        Me.txtQCNameBackup = New System.Windows.Forms.TextBox()
        Me.txtQCName = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtPlanningNotes = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnAbort = New System.Windows.Forms.Button()
        Me.btnPlanningSignOff = New System.Windows.Forms.Button()
        Me.dtPlanningSignOffDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPlanner2 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtPlanner1 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet71 = New EngDesignTracking.DataSet7()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEARRID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFilePath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImgField = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileExt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnFileAttachSubmit = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.txtFileDescription = New System.Windows.Forms.TextBox()
        Me.btnDeleteAttachment = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtAttachRecordID = New System.Windows.Forms.TextBox()
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        Me.btnSaveSelectedEARR = New System.Windows.Forms.Button()
        Me.btnPrintEarr = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.DataSet61 = New EngDesignTracking.DataSet6()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtEARRStatus = New System.Windows.Forms.TextBox()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter()
        Me.btnSaveEARR = New System.Windows.Forms.Button()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet51BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GridControl1.Location = New System.Drawing.Point(6, 7)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3, Me.RepositoryItemComboBox4, Me.RepositoryItemComboBox5})
        Me.GridControl1.Size = New System.Drawing.Size(1227, 181)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblEARR"
        Me.BindingSource1.DataSource = Me.DataSet51
        '
        'DataSet51
        '
        Me.DataSet51.DataSetName = "DataSet5"
        Me.DataSet51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 0
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEARRNumber, Me.colEARRStatus, Me.colProgramName, Me.colEARRType, Me.colFabShop})
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
        Me.colEARRNumber.Name = "colEARRNumber"
        Me.colEARRNumber.Visible = True
        Me.colEARRNumber.VisibleIndex = 0
        '
        'colEARRStatus
        '
        Me.colEARRStatus.FieldName = "EARRStatus"
        Me.colEARRStatus.Name = "colEARRStatus"
        Me.colEARRStatus.Visible = True
        Me.colEARRStatus.VisibleIndex = 1
        '
        'colProgramName
        '
        Me.colProgramName.FieldName = "ProgramName"
        Me.colProgramName.Name = "colProgramName"
        Me.colProgramName.Visible = True
        Me.colProgramName.VisibleIndex = 3
        '
        'colEARRType
        '
        Me.colEARRType.FieldName = "EARRType"
        Me.colEARRType.Name = "colEARRType"
        Me.colEARRType.Visible = True
        Me.colEARRType.VisibleIndex = 2
        '
        'colFabShop
        '
        Me.colFabShop.FieldName = "FabShop"
        Me.colFabShop.MinWidth = 19
        Me.colFabShop.Name = "colFabShop"
        Me.colFabShop.Visible = True
        Me.colFabShop.VisibleIndex = 4
        Me.colFabShop.Width = 70
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=EARR;Persist Security Info=True;U" &
    "ser ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EARRNumber", System.Data.SqlDbType.NVarChar, 0, "EARRNumber"), New System.Data.SqlClient.SqlParameter("@EARRStatus", System.Data.SqlDbType.NVarChar, 0, "EARRStatus"), New System.Data.SqlClient.SqlParameter("@EARRType", System.Data.SqlDbType.NVarChar, 0, "EARRType"), New System.Data.SqlClient.SqlParameter("@SerialNumber", System.Data.SqlDbType.NVarChar, 0, "SerialNumber"), New System.Data.SqlClient.SqlParameter("@WorkOrder", System.Data.SqlDbType.NVarChar, 0, "WorkOrder"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DrawingRevision", System.Data.SqlDbType.NVarChar, 0, "DrawingRevision"), New System.Data.SqlClient.SqlParameter("@Request", System.Data.SqlDbType.NVarChar, 0, "Request"), New System.Data.SqlClient.SqlParameter("@IncorpRedLineYes", System.Data.SqlDbType.Bit, 0, "IncorpRedLineYes"), New System.Data.SqlClient.SqlParameter("@IncorpRedLineNo", System.Data.SqlDbType.Bit, 0, "IncorpRedLineNo"), New System.Data.SqlClient.SqlParameter("@DrawingReqForConformityYes", System.Data.SqlDbType.Bit, 0, "DrawingReqForConformityYes"), New System.Data.SqlClient.SqlParameter("@DrawingReqForConformityNo", System.Data.SqlDbType.Bit, 0, "DrawingReqForConformityNo"), New System.Data.SqlClient.SqlParameter("@EARRResponseDate", System.Data.SqlDbType.[Date], 0, "EARRResponseDate"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@OriginatorDate", System.Data.SqlDbType.[Date], 0, "OriginatorDate"), New System.Data.SqlClient.SqlParameter("@OriginatorSignedOff", System.Data.SqlDbType.[Date], 0, "OriginatorSignedOff"), New System.Data.SqlClient.SqlParameter("@ReplyInstructions", System.Data.SqlDbType.NVarChar, 0, "ReplyInstructions"), New System.Data.SqlClient.SqlParameter("@EffectivityAll", System.Data.SqlDbType.Bit, 0, "EffectivityAll"), New System.Data.SqlClient.SqlParameter("@EffectivityOther", System.Data.SqlDbType.Bit, 0, "EffectivityOther"), New System.Data.SqlClient.SqlParameter("@EffectivityOtherText", System.Data.SqlDbType.NVarChar, 0, "EffectivityOtherText"), New System.Data.SqlClient.SqlParameter("@DeviationMinor", System.Data.SqlDbType.Bit, 0, "DeviationMinor"), New System.Data.SqlClient.SqlParameter("@DeviationMajor", System.Data.SqlDbType.Bit, 0, "DeviationMajor"), New System.Data.SqlClient.SqlParameter("@AdditionalEngReqNoAction", System.Data.SqlDbType.Bit, 0, "AdditionalEngReqNoAction"), New System.Data.SqlClient.SqlParameter("@AdditionalEngReqUpdate", System.Data.SqlDbType.Bit, 0, "AdditionalEngReqUpdate"), New System.Data.SqlClient.SqlParameter("@ACFTInterface", System.Data.SqlDbType.Bit, 0, "ACFTInterface"), New System.Data.SqlClient.SqlParameter("@Manufacturability", System.Data.SqlDbType.Bit, 0, "Manufacturability"), New System.Data.SqlClient.SqlParameter("@ProductImprovement", System.Data.SqlDbType.Bit, 0, "ProductImprovement"), New System.Data.SqlClient.SqlParameter("@DWGError", System.Data.SqlDbType.Bit, 0, "DWGError"), New System.Data.SqlClient.SqlParameter("@DesignError", System.Data.SqlDbType.Bit, 0, "DesignError"), New System.Data.SqlClient.SqlParameter("@LiaisonManagerName", System.Data.SqlDbType.NVarChar, 0, "LiaisonManagerName"), New System.Data.SqlClient.SqlParameter("@LiaisonManagerSignOffDate", System.Data.SqlDbType.[Date], 0, "LiaisonManagerSignOffDate"), New System.Data.SqlClient.SqlParameter("@EngineeringManagerName", System.Data.SqlDbType.NVarChar, 0, "EngineeringManagerName"), New System.Data.SqlClient.SqlParameter("@EngineeringManagerSignOffDate", System.Data.SqlDbType.[Date], 0, "EngineeringManagerSignOffDate"), New System.Data.SqlClient.SqlParameter("@LiaisonManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, "LiaisonManagerNameBackup"), New System.Data.SqlClient.SqlParameter("@EngineeringManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, "EngineeringManagerNameBackup"), New System.Data.SqlClient.SqlParameter("@Planner1", System.Data.SqlDbType.NVarChar, 0, "Planner1"), New System.Data.SqlClient.SqlParameter("@Planner2", System.Data.SqlDbType.NVarChar, 0, "Planner2"), New System.Data.SqlClient.SqlParameter("@QCName", System.Data.SqlDbType.NVarChar, 0, "QCName"), New System.Data.SqlClient.SqlParameter("@QCSignOff", System.Data.SqlDbType.[Date], 0, "QCSignOff"), New System.Data.SqlClient.SqlParameter("@QCNameBackup", System.Data.SqlDbType.NVarChar, 0, "QCNameBackup"), New System.Data.SqlClient.SqlParameter("@FabShop", System.Data.SqlDbType.Bit, 0, "FabShop"), New System.Data.SqlClient.SqlParameter("@ProductionError", System.Data.SqlDbType.Bit, 0, "ProductionError"), New System.Data.SqlClient.SqlParameter("@QCNotes", System.Data.SqlDbType.NVarChar, 0, "QCNotes"), New System.Data.SqlClient.SqlParameter("@PlannerSignOffDate", System.Data.SqlDbType.[Date], 0, "PlannerSignOffDate"), New System.Data.SqlClient.SqlParameter("@PlannerNotes", System.Data.SqlDbType.NVarChar, 0, "PlannerNotes"), New System.Data.SqlClient.SqlParameter("@EndItemType", System.Data.SqlDbType.NVarChar, 0, "EndItemType"), New System.Data.SqlClient.SqlParameter("@DeviationNA", System.Data.SqlDbType.Bit, 0, "DeviationNA")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EARRNumber", System.Data.SqlDbType.NVarChar, 0, "EARRNumber"), New System.Data.SqlClient.SqlParameter("@EARRStatus", System.Data.SqlDbType.NVarChar, 0, "EARRStatus"), New System.Data.SqlClient.SqlParameter("@EARRType", System.Data.SqlDbType.NVarChar, 0, "EARRType"), New System.Data.SqlClient.SqlParameter("@SerialNumber", System.Data.SqlDbType.NVarChar, 0, "SerialNumber"), New System.Data.SqlClient.SqlParameter("@WorkOrder", System.Data.SqlDbType.NVarChar, 0, "WorkOrder"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DrawingRevision", System.Data.SqlDbType.NVarChar, 0, "DrawingRevision"), New System.Data.SqlClient.SqlParameter("@Request", System.Data.SqlDbType.NVarChar, 0, "Request"), New System.Data.SqlClient.SqlParameter("@IncorpRedLineYes", System.Data.SqlDbType.Bit, 0, "IncorpRedLineYes"), New System.Data.SqlClient.SqlParameter("@IncorpRedLineNo", System.Data.SqlDbType.Bit, 0, "IncorpRedLineNo"), New System.Data.SqlClient.SqlParameter("@DrawingReqForConformityYes", System.Data.SqlDbType.Bit, 0, "DrawingReqForConformityYes"), New System.Data.SqlClient.SqlParameter("@DrawingReqForConformityNo", System.Data.SqlDbType.Bit, 0, "DrawingReqForConformityNo"), New System.Data.SqlClient.SqlParameter("@EARRResponseDate", System.Data.SqlDbType.[Date], 0, "EARRResponseDate"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@OriginatorDate", System.Data.SqlDbType.[Date], 0, "OriginatorDate"), New System.Data.SqlClient.SqlParameter("@OriginatorSignedOff", System.Data.SqlDbType.[Date], 0, "OriginatorSignedOff"), New System.Data.SqlClient.SqlParameter("@ReplyInstructions", System.Data.SqlDbType.NVarChar, 0, "ReplyInstructions"), New System.Data.SqlClient.SqlParameter("@EffectivityAll", System.Data.SqlDbType.Bit, 0, "EffectivityAll"), New System.Data.SqlClient.SqlParameter("@EffectivityOther", System.Data.SqlDbType.Bit, 0, "EffectivityOther"), New System.Data.SqlClient.SqlParameter("@EffectivityOtherText", System.Data.SqlDbType.NVarChar, 0, "EffectivityOtherText"), New System.Data.SqlClient.SqlParameter("@DeviationMinor", System.Data.SqlDbType.Bit, 0, "DeviationMinor"), New System.Data.SqlClient.SqlParameter("@DeviationMajor", System.Data.SqlDbType.Bit, 0, "DeviationMajor"), New System.Data.SqlClient.SqlParameter("@AdditionalEngReqNoAction", System.Data.SqlDbType.Bit, 0, "AdditionalEngReqNoAction"), New System.Data.SqlClient.SqlParameter("@AdditionalEngReqUpdate", System.Data.SqlDbType.Bit, 0, "AdditionalEngReqUpdate"), New System.Data.SqlClient.SqlParameter("@ACFTInterface", System.Data.SqlDbType.Bit, 0, "ACFTInterface"), New System.Data.SqlClient.SqlParameter("@Manufacturability", System.Data.SqlDbType.Bit, 0, "Manufacturability"), New System.Data.SqlClient.SqlParameter("@ProductImprovement", System.Data.SqlDbType.Bit, 0, "ProductImprovement"), New System.Data.SqlClient.SqlParameter("@DWGError", System.Data.SqlDbType.Bit, 0, "DWGError"), New System.Data.SqlClient.SqlParameter("@DesignError", System.Data.SqlDbType.Bit, 0, "DesignError"), New System.Data.SqlClient.SqlParameter("@LiaisonManagerName", System.Data.SqlDbType.NVarChar, 0, "LiaisonManagerName"), New System.Data.SqlClient.SqlParameter("@LiaisonManagerSignOffDate", System.Data.SqlDbType.[Date], 0, "LiaisonManagerSignOffDate"), New System.Data.SqlClient.SqlParameter("@EngineeringManagerName", System.Data.SqlDbType.NVarChar, 0, "EngineeringManagerName"), New System.Data.SqlClient.SqlParameter("@EngineeringManagerSignOffDate", System.Data.SqlDbType.[Date], 0, "EngineeringManagerSignOffDate"), New System.Data.SqlClient.SqlParameter("@LiaisonManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, "LiaisonManagerNameBackup"), New System.Data.SqlClient.SqlParameter("@EngineeringManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, "EngineeringManagerNameBackup"), New System.Data.SqlClient.SqlParameter("@Planner1", System.Data.SqlDbType.NVarChar, 0, "Planner1"), New System.Data.SqlClient.SqlParameter("@Planner2", System.Data.SqlDbType.NVarChar, 0, "Planner2"), New System.Data.SqlClient.SqlParameter("@QCName", System.Data.SqlDbType.NVarChar, 0, "QCName"), New System.Data.SqlClient.SqlParameter("@QCSignOff", System.Data.SqlDbType.[Date], 0, "QCSignOff"), New System.Data.SqlClient.SqlParameter("@QCNameBackup", System.Data.SqlDbType.NVarChar, 0, "QCNameBackup"), New System.Data.SqlClient.SqlParameter("@FabShop", System.Data.SqlDbType.Bit, 0, "FabShop"), New System.Data.SqlClient.SqlParameter("@ProductionError", System.Data.SqlDbType.Bit, 0, "ProductionError"), New System.Data.SqlClient.SqlParameter("@QCNotes", System.Data.SqlDbType.NVarChar, 0, "QCNotes"), New System.Data.SqlClient.SqlParameter("@PlannerSignOffDate", System.Data.SqlDbType.[Date], 0, "PlannerSignOffDate"), New System.Data.SqlClient.SqlParameter("@PlannerNotes", System.Data.SqlDbType.NVarChar, 0, "PlannerNotes"), New System.Data.SqlClient.SqlParameter("@EndItemType", System.Data.SqlDbType.NVarChar, 0, "EndItemType"), New System.Data.SqlClient.SqlParameter("@DeviationNA", System.Data.SqlDbType.Bit, 0, "DeviationNA"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRStatus", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRStatus", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRStatus", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRStatus", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WorkOrder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WorkOrder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Request", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Request", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Request", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Request", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IncorpRedLineYes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IncorpRedLineYes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IncorpRedLineYes", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorpRedLineYes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IncorpRedLineNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IncorpRedLineNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IncorpRedLineNo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorpRedLineNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingReqForConformityYes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityYes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingReqForConformityYes", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityYes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingReqForConformityNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingReqForConformityNo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRResponseDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRResponseDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRResponseDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRResponseDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorSignedOff", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorSignedOff", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorSignedOff", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorSignedOff", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReplyInstructions", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReplyInstructions", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReplyInstructions", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReplyInstructions", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EffectivityAll", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EffectivityAll", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EffectivityAll", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityAll", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EffectivityOther", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EffectivityOther", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EffectivityOther", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityOther", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EffectivityOtherText", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EffectivityOtherText", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EffectivityOtherText", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityOtherText", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DeviationMinor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DeviationMinor", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DeviationMinor", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeviationMinor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DeviationMajor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DeviationMajor", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DeviationMajor", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeviationMajor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AdditionalEngReqNoAction", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AdditionalEngReqNoAction", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AdditionalEngReqNoAction", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AdditionalEngReqNoAction", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AdditionalEngReqUpdate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AdditionalEngReqUpdate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AdditionalEngReqUpdate", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AdditionalEngReqUpdate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ACFTInterface", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ACFTInterface", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ACFTInterface", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ACFTInterface", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Manufacturability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Manufacturability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Manufacturability", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manufacturability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductImprovement", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductImprovement", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductImprovement", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductImprovement", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DWGError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DWGError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DWGError", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DWGError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignError", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonManagerName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonManagerName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonManagerName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonManagerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonManagerSignOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonManagerSignOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonManagerSignOffDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonManagerSignOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineeringManagerName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineeringManagerName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineeringManagerName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineeringManagerSignOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineeringManagerSignOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineeringManagerSignOffDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerSignOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonManagerNameBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonManagerNameBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonManagerNameBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineeringManagerNameBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineeringManagerNameBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineeringManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerNameBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCSignOff", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCSignOff", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCSignOff", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCSignOff", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCNameBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCNameBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCNameBackup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCNameBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FabShop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FabShop", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductionError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductionError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductionError", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCNotes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCNotes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCNotes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannerSignOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannerSignOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannerSignOffDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannerSignOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannerNotes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannerNotes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannerNotes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannerNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EndItemType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EndItemType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EndItemType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndItemType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DeviationNA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DeviationNA", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DeviationNA", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeviationNA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRStatus", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRStatus", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRStatus", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRStatus", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WorkOrder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WorkOrder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Request", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Request", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Request", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Request", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IncorpRedLineYes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IncorpRedLineYes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IncorpRedLineYes", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorpRedLineYes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IncorpRedLineNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IncorpRedLineNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IncorpRedLineNo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorpRedLineNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingReqForConformityYes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityYes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingReqForConformityYes", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityYes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingReqForConformityNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingReqForConformityNo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingReqForConformityNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRResponseDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRResponseDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRResponseDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRResponseDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorSignedOff", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorSignedOff", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorSignedOff", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorSignedOff", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReplyInstructions", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReplyInstructions", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReplyInstructions", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReplyInstructions", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EffectivityAll", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EffectivityAll", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EffectivityAll", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityAll", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EffectivityOther", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EffectivityOther", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EffectivityOther", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityOther", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EffectivityOtherText", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EffectivityOtherText", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EffectivityOtherText", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EffectivityOtherText", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DeviationMinor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DeviationMinor", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DeviationMinor", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeviationMinor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DeviationMajor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DeviationMajor", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DeviationMajor", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeviationMajor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AdditionalEngReqNoAction", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AdditionalEngReqNoAction", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AdditionalEngReqNoAction", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AdditionalEngReqNoAction", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AdditionalEngReqUpdate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AdditionalEngReqUpdate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AdditionalEngReqUpdate", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AdditionalEngReqUpdate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ACFTInterface", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ACFTInterface", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ACFTInterface", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ACFTInterface", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Manufacturability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Manufacturability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Manufacturability", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manufacturability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductImprovement", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductImprovement", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductImprovement", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductImprovement", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DWGError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DWGError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DWGError", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DWGError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignError", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonManagerName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonManagerName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonManagerName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonManagerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonManagerSignOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonManagerSignOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonManagerSignOffDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonManagerSignOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineeringManagerName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineeringManagerName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineeringManagerName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineeringManagerSignOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineeringManagerSignOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineeringManagerSignOffDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerSignOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonManagerNameBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonManagerNameBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonManagerNameBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineeringManagerNameBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineeringManagerNameBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineeringManagerNameBackup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineeringManagerNameBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCSignOff", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCSignOff", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCSignOff", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCSignOff", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCNameBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCNameBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCNameBackup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCNameBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FabShop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FabShop", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductionError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductionError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductionError", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductionError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCNotes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCNotes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCNotes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannerSignOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannerSignOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannerSignOffDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannerSignOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PlannerNotes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PlannerNotes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PlannerNotes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlannerNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EndItemType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EndItemType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EndItemType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndItemType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DeviationNA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DeviationNA", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DeviationNA", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeviationNA", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblEARR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("EARRNumber", "EARRNumber"), New System.Data.Common.DataColumnMapping("EARRStatus", "EARRStatus"), New System.Data.Common.DataColumnMapping("EARRType", "EARRType"), New System.Data.Common.DataColumnMapping("SerialNumber", "SerialNumber"), New System.Data.Common.DataColumnMapping("WorkOrder", "WorkOrder"), New System.Data.Common.DataColumnMapping("ProgramName", "ProgramName"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DrawingRevision", "DrawingRevision"), New System.Data.Common.DataColumnMapping("Request", "Request"), New System.Data.Common.DataColumnMapping("IncorpRedLineYes", "IncorpRedLineYes"), New System.Data.Common.DataColumnMapping("IncorpRedLineNo", "IncorpRedLineNo"), New System.Data.Common.DataColumnMapping("DrawingReqForConformityYes", "DrawingReqForConformityYes"), New System.Data.Common.DataColumnMapping("DrawingReqForConformityNo", "DrawingReqForConformityNo"), New System.Data.Common.DataColumnMapping("EARRResponseDate", "EARRResponseDate"), New System.Data.Common.DataColumnMapping("OriginatorName", "OriginatorName"), New System.Data.Common.DataColumnMapping("OriginatorDate", "OriginatorDate"), New System.Data.Common.DataColumnMapping("OriginatorSignedOff", "OriginatorSignedOff"), New System.Data.Common.DataColumnMapping("ReplyInstructions", "ReplyInstructions"), New System.Data.Common.DataColumnMapping("EffectivityAll", "EffectivityAll"), New System.Data.Common.DataColumnMapping("EffectivityOther", "EffectivityOther"), New System.Data.Common.DataColumnMapping("EffectivityOtherText", "EffectivityOtherText"), New System.Data.Common.DataColumnMapping("DeviationMinor", "DeviationMinor"), New System.Data.Common.DataColumnMapping("DeviationMajor", "DeviationMajor"), New System.Data.Common.DataColumnMapping("AdditionalEngReqNoAction", "AdditionalEngReqNoAction"), New System.Data.Common.DataColumnMapping("AdditionalEngReqUpdate", "AdditionalEngReqUpdate"), New System.Data.Common.DataColumnMapping("ACFTInterface", "ACFTInterface"), New System.Data.Common.DataColumnMapping("Manufacturability", "Manufacturability"), New System.Data.Common.DataColumnMapping("ProductImprovement", "ProductImprovement"), New System.Data.Common.DataColumnMapping("DWGError", "DWGError"), New System.Data.Common.DataColumnMapping("DesignError", "DesignError"), New System.Data.Common.DataColumnMapping("LiaisonManagerName", "LiaisonManagerName"), New System.Data.Common.DataColumnMapping("LiaisonManagerSignOffDate", "LiaisonManagerSignOffDate"), New System.Data.Common.DataColumnMapping("EngineeringManagerName", "EngineeringManagerName"), New System.Data.Common.DataColumnMapping("EngineeringManagerSignOffDate", "EngineeringManagerSignOffDate"), New System.Data.Common.DataColumnMapping("LiaisonManagerNameBackup", "LiaisonManagerNameBackup"), New System.Data.Common.DataColumnMapping("EngineeringManagerNameBackup", "EngineeringManagerNameBackup"), New System.Data.Common.DataColumnMapping("Planner1", "Planner1"), New System.Data.Common.DataColumnMapping("Planner2", "Planner2"), New System.Data.Common.DataColumnMapping("QCName", "QCName"), New System.Data.Common.DataColumnMapping("QCSignOff", "QCSignOff"), New System.Data.Common.DataColumnMapping("QCNameBackup", "QCNameBackup"), New System.Data.Common.DataColumnMapping("FabShop", "FabShop"), New System.Data.Common.DataColumnMapping("ProductionError", "ProductionError"), New System.Data.Common.DataColumnMapping("QCNotes", "QCNotes"), New System.Data.Common.DataColumnMapping("PlannerSignOffDate", "PlannerSignOffDate"), New System.Data.Common.DataColumnMapping("PlannerNotes", "PlannerNotes"), New System.Data.Common.DataColumnMapping("EndItemType", "EndItemType"), New System.Data.Common.DataColumnMapping("DeviationNA", "DeviationNA")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DataSet51BindingSource
        '
        Me.DataSet51BindingSource.DataSource = Me.DataSet51
        Me.DataSet51BindingSource.Position = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(6, 210)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl1.Size = New System.Drawing.Size(1234, 482)
        Me.XtraTabControl1.TabIndex = 6
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Label27)
        Me.XtraTabPage3.Controls.Add(Me.btnRescind)
        Me.XtraTabPage3.Controls.Add(Me.btnEngManagerSignOff)
        Me.XtraTabPage3.Controls.Add(Me.dtEngineeringManagerSignOffDate)
        Me.XtraTabPage3.Controls.Add(Me.txtEngineeringManagerNameBackup)
        Me.XtraTabPage3.Controls.Add(Me.txtEngineeringManagerName)
        Me.XtraTabPage3.Controls.Add(Me.Label18)
        Me.XtraTabPage3.Controls.Add(Me.Label17)
        Me.XtraTabPage3.Controls.Add(Me.Label16)
        Me.XtraTabPage3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1228, 399)
        Me.XtraTabPage3.Text = "Engineering Manager"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Italic)
        Me.Label27.Location = New System.Drawing.Point(374, 32)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(309, 13)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "Once signed off, name in this field is the person who signed off"
        '
        'btnRescind
        '
        Me.btnRescind.Location = New System.Drawing.Point(487, 115)
        Me.btnRescind.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRescind.Name = "btnRescind"
        Me.btnRescind.Size = New System.Drawing.Size(90, 27)
        Me.btnRescind.TabIndex = 19
        Me.btnRescind.Text = "Rescind"
        Me.btnRescind.UseVisualStyleBackColor = True
        '
        'btnEngManagerSignOff
        '
        Me.btnEngManagerSignOff.Location = New System.Drawing.Point(376, 115)
        Me.btnEngManagerSignOff.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEngManagerSignOff.Name = "btnEngManagerSignOff"
        Me.btnEngManagerSignOff.Size = New System.Drawing.Size(90, 27)
        Me.btnEngManagerSignOff.TabIndex = 18
        Me.btnEngManagerSignOff.Text = "Sign Off"
        Me.btnEngManagerSignOff.UseVisualStyleBackColor = True
        '
        'dtEngineeringManagerSignOffDate
        '
        Me.dtEngineeringManagerSignOffDate.Enabled = False
        Me.dtEngineeringManagerSignOffDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEngineeringManagerSignOffDate.Location = New System.Drawing.Point(204, 115)
        Me.dtEngineeringManagerSignOffDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtEngineeringManagerSignOffDate.Name = "dtEngineeringManagerSignOffDate"
        Me.dtEngineeringManagerSignOffDate.Size = New System.Drawing.Size(158, 21)
        Me.dtEngineeringManagerSignOffDate.TabIndex = 5
        '
        'txtEngineeringManagerNameBackup
        '
        Me.txtEngineeringManagerNameBackup.Enabled = False
        Me.txtEngineeringManagerNameBackup.Location = New System.Drawing.Point(204, 73)
        Me.txtEngineeringManagerNameBackup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEngineeringManagerNameBackup.Name = "txtEngineeringManagerNameBackup"
        Me.txtEngineeringManagerNameBackup.Size = New System.Drawing.Size(158, 21)
        Me.txtEngineeringManagerNameBackup.TabIndex = 4
        '
        'txtEngineeringManagerName
        '
        Me.txtEngineeringManagerName.Enabled = False
        Me.txtEngineeringManagerName.Location = New System.Drawing.Point(204, 32)
        Me.txtEngineeringManagerName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEngineeringManagerName.Name = "txtEngineeringManagerName"
        Me.txtEngineeringManagerName.Size = New System.Drawing.Size(158, 21)
        Me.txtEngineeringManagerName.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(32, 115)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(141, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Engineering Manager Action"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(32, 73)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(145, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Engineering Manager Backup"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(32, 34)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Engineering Manager"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Label33)
        Me.XtraTabPage1.Controls.Add(Me.txtEndItemType)
        Me.XtraTabPage1.Controls.Add(Me.dtEARRResponseDate)
        Me.XtraTabPage1.Controls.Add(Me.Label29)
        Me.XtraTabPage1.Controls.Add(Me.Label20)
        Me.XtraTabPage1.Controls.Add(Me.txtEARRNumber)
        Me.XtraTabPage1.Controls.Add(Me.dtOriginatorDate)
        Me.XtraTabPage1.Controls.Add(Me.txtOriginatorName)
        Me.XtraTabPage1.Controls.Add(Me.txtRequest)
        Me.XtraTabPage1.Controls.Add(Me.txtDrawingRevision)
        Me.XtraTabPage1.Controls.Add(Me.txtDrawingNumber)
        Me.XtraTabPage1.Controls.Add(Me.txtWorkOrder)
        Me.XtraTabPage1.Controls.Add(Me.txtSerialNumber)
        Me.XtraTabPage1.Controls.Add(Me.cboEARRType)
        Me.XtraTabPage1.Controls.Add(Me.cboProgramName)
        Me.XtraTabPage1.Controls.Add(Me.Label9)
        Me.XtraTabPage1.Controls.Add(Me.Label8)
        Me.XtraTabPage1.Controls.Add(Me.GroupBox2)
        Me.XtraTabPage1.Controls.Add(Me.GroupBox1)
        Me.XtraTabPage1.Controls.Add(Me.Label7)
        Me.XtraTabPage1.Controls.Add(Me.Label6)
        Me.XtraTabPage1.Controls.Add(Me.Label5)
        Me.XtraTabPage1.Controls.Add(Me.Label4)
        Me.XtraTabPage1.Controls.Add(Me.Label3)
        Me.XtraTabPage1.Controls.Add(Me.Label2)
        Me.XtraTabPage1.Controls.Add(Me.Label1)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1228, 454)
        Me.XtraTabPage1.Text = "General EARR Info"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(236, 10)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(77, 13)
        Me.Label33.TabIndex = 32
        Me.Label33.Text = "End Item Type"
        '
        'txtEndItemType
        '
        Me.txtEndItemType.Location = New System.Drawing.Point(318, 10)
        Me.txtEndItemType.Name = "txtEndItemType"
        Me.txtEndItemType.Size = New System.Drawing.Size(122, 21)
        Me.txtEndItemType.TabIndex = 31
        '
        'dtEARRResponseDate
        '
        Me.dtEARRResponseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEARRResponseDate.Location = New System.Drawing.Point(741, 158)
        Me.dtEARRResponseDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtEARRResponseDate.Name = "dtEARRResponseDate"
        Me.dtEARRResponseDate.Size = New System.Drawing.Size(188, 21)
        Me.dtEARRResponseDate.TabIndex = 30
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(602, 158)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(138, 13)
        Me.Label29.TabIndex = 29
        Me.Label29.Text = "Earr Response Required By"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(20, 10)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 13)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "EARR Number"
        '
        'txtEARRNumber
        '
        Me.txtEARRNumber.Location = New System.Drawing.Point(102, 10)
        Me.txtEARRNumber.Name = "txtEARRNumber"
        Me.txtEARRNumber.Size = New System.Drawing.Size(122, 21)
        Me.txtEARRNumber.TabIndex = 22
        '
        'dtOriginatorDate
        '
        Me.dtOriginatorDate.Enabled = False
        Me.dtOriginatorDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtOriginatorDate.Location = New System.Drawing.Point(325, 219)
        Me.dtOriginatorDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtOriginatorDate.Name = "dtOriginatorDate"
        Me.dtOriginatorDate.Size = New System.Drawing.Size(101, 21)
        Me.dtOriginatorDate.TabIndex = 20
        '
        'txtOriginatorName
        '
        Me.txtOriginatorName.Enabled = False
        Me.txtOriginatorName.Location = New System.Drawing.Point(119, 219)
        Me.txtOriginatorName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOriginatorName.Name = "txtOriginatorName"
        Me.txtOriginatorName.Size = New System.Drawing.Size(116, 21)
        Me.txtOriginatorName.TabIndex = 19
        '
        'txtRequest
        '
        Me.txtRequest.Location = New System.Drawing.Point(76, 73)
        Me.txtRequest.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRequest.Multiline = True
        Me.txtRequest.Name = "txtRequest"
        Me.txtRequest.Size = New System.Drawing.Size(1150, 49)
        Me.txtRequest.TabIndex = 18
        '
        'txtDrawingRevision
        '
        Me.txtDrawingRevision.Location = New System.Drawing.Point(541, 10)
        Me.txtDrawingRevision.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDrawingRevision.Name = "txtDrawingRevision"
        Me.txtDrawingRevision.Size = New System.Drawing.Size(130, 21)
        Me.txtDrawingRevision.TabIndex = 17
        '
        'txtDrawingNumber
        '
        Me.txtDrawingNumber.Location = New System.Drawing.Point(900, 36)
        Me.txtDrawingNumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDrawingNumber.Name = "txtDrawingNumber"
        Me.txtDrawingNumber.Size = New System.Drawing.Size(106, 21)
        Me.txtDrawingNumber.TabIndex = 16
        '
        'txtWorkOrder
        '
        Me.txtWorkOrder.Location = New System.Drawing.Point(706, 36)
        Me.txtWorkOrder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWorkOrder.Name = "txtWorkOrder"
        Me.txtWorkOrder.Size = New System.Drawing.Size(104, 21)
        Me.txtWorkOrder.TabIndex = 15
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Location = New System.Drawing.Point(486, 36)
        Me.txtSerialNumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(130, 21)
        Me.txtSerialNumber.TabIndex = 14
        '
        'cboEARRType
        '
        Me.cboEARRType.FormattingEnabled = True
        Me.cboEARRType.Location = New System.Drawing.Point(286, 36)
        Me.cboEARRType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboEARRType.Name = "cboEARRType"
        Me.cboEARRType.Size = New System.Drawing.Size(122, 21)
        Me.cboEARRType.TabIndex = 13
        '
        'cboProgramName
        '
        Me.cboProgramName.FormattingEnabled = True
        Me.cboProgramName.Items.AddRange(New Object() {"QCTEST"})
        Me.cboProgramName.Location = New System.Drawing.Point(102, 36)
        Me.cboProgramName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboProgramName.Name = "cboProgramName"
        Me.cboProgramName.Size = New System.Drawing.Size(122, 21)
        Me.cboProgramName.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(236, 219)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Originator Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 219)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Originator Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkDrawingRequestForConformityNo)
        Me.GroupBox2.Controls.Add(Me.chkDrawingRequestForConformityYes)
        Me.GroupBox2.Location = New System.Drawing.Point(318, 132)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(268, 57)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Drawing Required For Conformity?"
        '
        'chkDrawingRequestForConformityNo
        '
        Me.chkDrawingRequestForConformityNo.AutoSize = True
        Me.chkDrawingRequestForConformityNo.Location = New System.Drawing.Point(84, 26)
        Me.chkDrawingRequestForConformityNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDrawingRequestForConformityNo.Name = "chkDrawingRequestForConformityNo"
        Me.chkDrawingRequestForConformityNo.Size = New System.Drawing.Size(39, 17)
        Me.chkDrawingRequestForConformityNo.TabIndex = 22
        Me.chkDrawingRequestForConformityNo.Text = "No"
        Me.chkDrawingRequestForConformityNo.UseVisualStyleBackColor = True
        '
        'chkDrawingRequestForConformityYes
        '
        Me.chkDrawingRequestForConformityYes.AutoSize = True
        Me.chkDrawingRequestForConformityYes.Location = New System.Drawing.Point(20, 26)
        Me.chkDrawingRequestForConformityYes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDrawingRequestForConformityYes.Name = "chkDrawingRequestForConformityYes"
        Me.chkDrawingRequestForConformityYes.Size = New System.Drawing.Size(43, 17)
        Me.chkDrawingRequestForConformityYes.TabIndex = 21
        Me.chkDrawingRequestForConformityYes.Text = "Yes"
        Me.chkDrawingRequestForConformityYes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkIncorpRedLineNo)
        Me.GroupBox1.Controls.Add(Me.chkIncorpRedLineYes)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 132)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(268, 57)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Incorporate Red Line?"
        '
        'chkIncorpRedLineNo
        '
        Me.chkIncorpRedLineNo.AutoSize = True
        Me.chkIncorpRedLineNo.Location = New System.Drawing.Point(77, 26)
        Me.chkIncorpRedLineNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkIncorpRedLineNo.Name = "chkIncorpRedLineNo"
        Me.chkIncorpRedLineNo.Size = New System.Drawing.Size(39, 17)
        Me.chkIncorpRedLineNo.TabIndex = 20
        Me.chkIncorpRedLineNo.Text = "No"
        Me.chkIncorpRedLineNo.UseVisualStyleBackColor = True
        '
        'chkIncorpRedLineYes
        '
        Me.chkIncorpRedLineYes.AutoSize = True
        Me.chkIncorpRedLineYes.Location = New System.Drawing.Point(12, 26)
        Me.chkIncorpRedLineYes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkIncorpRedLineYes.Name = "chkIncorpRedLineYes"
        Me.chkIncorpRedLineYes.Size = New System.Drawing.Size(43, 17)
        Me.chkIncorpRedLineYes.TabIndex = 19
        Me.chkIncorpRedLineYes.Text = "Yes"
        Me.chkIncorpRedLineYes.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 73)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Request"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(452, 10)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Drawing Revision"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(810, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Drawing Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(617, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Work Order.Step"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(410, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Serial Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Program Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EARR Type"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Label26)
        Me.XtraTabPage2.Controls.Add(Me.btnLiaisonSignOff)
        Me.XtraTabPage2.Controls.Add(Me.dtLiaisonManagerSignOffDate)
        Me.XtraTabPage2.Controls.Add(Me.txtLiaisonManagerNameBackup)
        Me.XtraTabPage2.Controls.Add(Me.txtLiaisonManagerName)
        Me.XtraTabPage2.Controls.Add(Me.txtReplyInstructions)
        Me.XtraTabPage2.Controls.Add(Me.Label14)
        Me.XtraTabPage2.Controls.Add(Me.Label13)
        Me.XtraTabPage2.Controls.Add(Me.Label12)
        Me.XtraTabPage2.Controls.Add(Me.GroupBox6)
        Me.XtraTabPage2.Controls.Add(Me.GroupBox5)
        Me.XtraTabPage2.Controls.Add(Me.GroupBox4)
        Me.XtraTabPage2.Controls.Add(Me.GroupBox3)
        Me.XtraTabPage2.Controls.Add(Me.Label11)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1228, 454)
        Me.XtraTabPage2.Text = "Liaison Info"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Italic)
        Me.Label26.Location = New System.Drawing.Point(716, 184)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(309, 13)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Once signed off, name in this field is the person who signed off"
        '
        'btnLiaisonSignOff
        '
        Me.btnLiaisonSignOff.Location = New System.Drawing.Point(718, 255)
        Me.btnLiaisonSignOff.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLiaisonSignOff.Name = "btnLiaisonSignOff"
        Me.btnLiaisonSignOff.Size = New System.Drawing.Size(90, 27)
        Me.btnLiaisonSignOff.TabIndex = 17
        Me.btnLiaisonSignOff.Text = "Sign Off"
        Me.btnLiaisonSignOff.UseVisualStyleBackColor = True
        '
        'dtLiaisonManagerSignOffDate
        '
        Me.dtLiaisonManagerSignOffDate.Enabled = False
        Me.dtLiaisonManagerSignOffDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtLiaisonManagerSignOffDate.Location = New System.Drawing.Point(521, 255)
        Me.dtLiaisonManagerSignOffDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtLiaisonManagerSignOffDate.Name = "dtLiaisonManagerSignOffDate"
        Me.dtLiaisonManagerSignOffDate.Size = New System.Drawing.Size(188, 21)
        Me.dtLiaisonManagerSignOffDate.TabIndex = 14
        '
        'txtLiaisonManagerNameBackup
        '
        Me.txtLiaisonManagerNameBackup.Enabled = False
        Me.txtLiaisonManagerNameBackup.Location = New System.Drawing.Point(521, 216)
        Me.txtLiaisonManagerNameBackup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLiaisonManagerNameBackup.Name = "txtLiaisonManagerNameBackup"
        Me.txtLiaisonManagerNameBackup.Size = New System.Drawing.Size(188, 21)
        Me.txtLiaisonManagerNameBackup.TabIndex = 13
        '
        'txtLiaisonManagerName
        '
        Me.txtLiaisonManagerName.Enabled = False
        Me.txtLiaisonManagerName.Location = New System.Drawing.Point(521, 181)
        Me.txtLiaisonManagerName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLiaisonManagerName.Name = "txtLiaisonManagerName"
        Me.txtLiaisonManagerName.Size = New System.Drawing.Size(188, 21)
        Me.txtLiaisonManagerName.TabIndex = 12
        '
        'txtReplyInstructions
        '
        Me.txtReplyInstructions.Location = New System.Drawing.Point(120, 29)
        Me.txtReplyInstructions.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtReplyInstructions.Multiline = True
        Me.txtReplyInstructions.Name = "txtReplyInstructions"
        Me.txtReplyInstructions.Size = New System.Drawing.Size(1074, 57)
        Me.txtReplyInstructions.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(382, 255)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Eng Liaison Approval"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(382, 217)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Backup Engineer Liaison"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(382, 181)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Engineer Liaison"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkProductionError)
        Me.GroupBox6.Controls.Add(Me.chkDesignError)
        Me.GroupBox6.Controls.Add(Me.chkDWGError)
        Me.GroupBox6.Controls.Add(Me.chkProductImprovement)
        Me.GroupBox6.Controls.Add(Me.chkManufacturability)
        Me.GroupBox6.Controls.Add(Me.chkACFTInterface)
        Me.GroupBox6.Location = New System.Drawing.Point(26, 226)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox6.Size = New System.Drawing.Size(310, 202)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Category"
        '
        'chkProductionError
        '
        Me.chkProductionError.AutoSize = True
        Me.chkProductionError.Location = New System.Drawing.Point(24, 175)
        Me.chkProductionError.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkProductionError.Name = "chkProductionError"
        Me.chkProductionError.Size = New System.Drawing.Size(104, 17)
        Me.chkProductionError.TabIndex = 14
        Me.chkProductionError.Text = "Production Error"
        Me.chkProductionError.UseVisualStyleBackColor = True
        '
        'chkDesignError
        '
        Me.chkDesignError.AutoSize = True
        Me.chkDesignError.Location = New System.Drawing.Point(24, 147)
        Me.chkDesignError.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDesignError.Name = "chkDesignError"
        Me.chkDesignError.Size = New System.Drawing.Size(85, 17)
        Me.chkDesignError.TabIndex = 13
        Me.chkDesignError.Text = "Design Error"
        Me.chkDesignError.UseVisualStyleBackColor = True
        '
        'chkDWGError
        '
        Me.chkDWGError.AutoSize = True
        Me.chkDWGError.Location = New System.Drawing.Point(24, 119)
        Me.chkDWGError.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDWGError.Name = "chkDWGError"
        Me.chkDWGError.Size = New System.Drawing.Size(77, 17)
        Me.chkDWGError.TabIndex = 13
        Me.chkDWGError.Text = "DWG Error"
        Me.chkDWGError.UseVisualStyleBackColor = True
        '
        'chkProductImprovement
        '
        Me.chkProductImprovement.AutoSize = True
        Me.chkProductImprovement.Location = New System.Drawing.Point(24, 90)
        Me.chkProductImprovement.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkProductImprovement.Name = "chkProductImprovement"
        Me.chkProductImprovement.Size = New System.Drawing.Size(127, 17)
        Me.chkProductImprovement.TabIndex = 13
        Me.chkProductImprovement.Text = "ProductImprovement"
        Me.chkProductImprovement.UseVisualStyleBackColor = True
        '
        'chkManufacturability
        '
        Me.chkManufacturability.AutoSize = True
        Me.chkManufacturability.Location = New System.Drawing.Point(24, 59)
        Me.chkManufacturability.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkManufacturability.Name = "chkManufacturability"
        Me.chkManufacturability.Size = New System.Drawing.Size(109, 17)
        Me.chkManufacturability.TabIndex = 13
        Me.chkManufacturability.Text = "Manufacturability"
        Me.chkManufacturability.UseVisualStyleBackColor = True
        '
        'chkACFTInterface
        '
        Me.chkACFTInterface.AutoSize = True
        Me.chkACFTInterface.Location = New System.Drawing.Point(24, 28)
        Me.chkACFTInterface.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkACFTInterface.Name = "chkACFTInterface"
        Me.chkACFTInterface.Size = New System.Drawing.Size(100, 17)
        Me.chkACFTInterface.TabIndex = 13
        Me.chkACFTInterface.Text = "ACFT Interface"
        Me.chkACFTInterface.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkAdditionalEngReqUpdate)
        Me.GroupBox5.Controls.Add(Me.chkAdditionalEngReqNoAction)
        Me.GroupBox5.Location = New System.Drawing.Point(26, 170)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(310, 52)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Additional Engineering Required"
        '
        'chkAdditionalEngReqUpdate
        '
        Me.chkAdditionalEngReqUpdate.AutoSize = True
        Me.chkAdditionalEngReqUpdate.Location = New System.Drawing.Point(118, 23)
        Me.chkAdditionalEngReqUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkAdditionalEngReqUpdate.Name = "chkAdditionalEngReqUpdate"
        Me.chkAdditionalEngReqUpdate.Size = New System.Drawing.Size(61, 17)
        Me.chkAdditionalEngReqUpdate.TabIndex = 12
        Me.chkAdditionalEngReqUpdate.Text = "Update"
        Me.chkAdditionalEngReqUpdate.UseVisualStyleBackColor = True
        '
        'chkAdditionalEngReqNoAction
        '
        Me.chkAdditionalEngReqNoAction.AutoSize = True
        Me.chkAdditionalEngReqNoAction.Location = New System.Drawing.Point(15, 23)
        Me.chkAdditionalEngReqNoAction.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkAdditionalEngReqNoAction.Name = "chkAdditionalEngReqNoAction"
        Me.chkAdditionalEngReqNoAction.Size = New System.Drawing.Size(72, 17)
        Me.chkAdditionalEngReqNoAction.TabIndex = 11
        Me.chkAdditionalEngReqNoAction.Text = "No Action"
        Me.chkAdditionalEngReqNoAction.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkDeviationNA)
        Me.GroupBox4.Controls.Add(Me.chkDeviationMajor)
        Me.GroupBox4.Controls.Add(Me.chkDeviationMinor)
        Me.GroupBox4.Location = New System.Drawing.Point(385, 87)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(310, 52)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Type of Deviation"
        '
        'chkDeviationNA
        '
        Me.chkDeviationNA.AutoSize = True
        Me.chkDeviationNA.Location = New System.Drawing.Point(148, 26)
        Me.chkDeviationNA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDeviationNA.Name = "chkDeviationNA"
        Me.chkDeviationNA.Size = New System.Drawing.Size(44, 17)
        Me.chkDeviationNA.TabIndex = 12
        Me.chkDeviationNA.Text = "N/A"
        Me.chkDeviationNA.UseVisualStyleBackColor = True
        '
        'chkDeviationMajor
        '
        Me.chkDeviationMajor.AutoSize = True
        Me.chkDeviationMajor.Location = New System.Drawing.Point(88, 27)
        Me.chkDeviationMajor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDeviationMajor.Name = "chkDeviationMajor"
        Me.chkDeviationMajor.Size = New System.Drawing.Size(53, 17)
        Me.chkDeviationMajor.TabIndex = 11
        Me.chkDeviationMajor.Text = "Major"
        Me.chkDeviationMajor.UseVisualStyleBackColor = True
        '
        'chkDeviationMinor
        '
        Me.chkDeviationMinor.AutoSize = True
        Me.chkDeviationMinor.Location = New System.Drawing.Point(24, 26)
        Me.chkDeviationMinor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDeviationMinor.Name = "chkDeviationMinor"
        Me.chkDeviationMinor.Size = New System.Drawing.Size(52, 17)
        Me.chkDeviationMinor.TabIndex = 0
        Me.chkDeviationMinor.Text = "Minor"
        Me.chkDeviationMinor.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtEffectivityOtherText)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.chkEffectivityOther)
        Me.GroupBox3.Controls.Add(Me.chkEffectivityAll)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 87)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(310, 80)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Effectivity"
        '
        'txtEffectivityOtherText
        '
        Me.txtEffectivityOtherText.Location = New System.Drawing.Point(107, 53)
        Me.txtEffectivityOtherText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEffectivityOtherText.Name = "txtEffectivityOtherText"
        Me.txtEffectivityOtherText.Size = New System.Drawing.Size(191, 21)
        Me.txtEffectivityOtherText.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 53)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "If Other, Specify:"
        '
        'chkEffectivityOther
        '
        Me.chkEffectivityOther.AutoSize = True
        Me.chkEffectivityOther.Location = New System.Drawing.Point(68, 27)
        Me.chkEffectivityOther.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkEffectivityOther.Name = "chkEffectivityOther"
        Me.chkEffectivityOther.Size = New System.Drawing.Size(54, 17)
        Me.chkEffectivityOther.TabIndex = 11
        Me.chkEffectivityOther.Text = "Other"
        Me.chkEffectivityOther.UseVisualStyleBackColor = True
        '
        'chkEffectivityAll
        '
        Me.chkEffectivityAll.AutoSize = True
        Me.chkEffectivityAll.Location = New System.Drawing.Point(15, 27)
        Me.chkEffectivityAll.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkEffectivityAll.Name = "chkEffectivityAll"
        Me.chkEffectivityAll.Size = New System.Drawing.Size(37, 17)
        Me.chkEffectivityAll.TabIndex = 0
        Me.chkEffectivityAll.Text = "All"
        Me.chkEffectivityAll.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 29)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Reply Instructions"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.txtQCNotes)
        Me.XtraTabPage4.Controls.Add(Me.Label28)
        Me.XtraTabPage4.Controls.Add(Me.btnQCSignOff)
        Me.XtraTabPage4.Controls.Add(Me.dtQCDateSignoff)
        Me.XtraTabPage4.Controls.Add(Me.txtQCNameBackup)
        Me.XtraTabPage4.Controls.Add(Me.txtQCName)
        Me.XtraTabPage4.Controls.Add(Me.Label21)
        Me.XtraTabPage4.Controls.Add(Me.Label22)
        Me.XtraTabPage4.Controls.Add(Me.Label23)
        Me.XtraTabPage4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1228, 454)
        Me.XtraTabPage4.Text = "QC"
        '
        'txtQCNotes
        '
        Me.txtQCNotes.Location = New System.Drawing.Point(28, 148)
        Me.txtQCNotes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtQCNotes.Multiline = True
        Me.txtQCNotes.Name = "txtQCNotes"
        Me.txtQCNotes.Size = New System.Drawing.Size(954, 62)
        Me.txtQCNotes.TabIndex = 27
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Italic)
        Me.Label28.Location = New System.Drawing.Point(368, 23)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(309, 13)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "Once signed off, name in this field is the person who signed off"
        '
        'btnQCSignOff
        '
        Me.btnQCSignOff.Location = New System.Drawing.Point(28, 221)
        Me.btnQCSignOff.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnQCSignOff.Name = "btnQCSignOff"
        Me.btnQCSignOff.Size = New System.Drawing.Size(90, 27)
        Me.btnQCSignOff.TabIndex = 25
        Me.btnQCSignOff.Text = "Sign Off"
        Me.btnQCSignOff.UseVisualStyleBackColor = True
        '
        'dtQCDateSignoff
        '
        Me.dtQCDateSignoff.Enabled = False
        Me.dtQCDateSignoff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtQCDateSignoff.Location = New System.Drawing.Point(198, 106)
        Me.dtQCDateSignoff.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtQCDateSignoff.Name = "dtQCDateSignoff"
        Me.dtQCDateSignoff.Size = New System.Drawing.Size(158, 21)
        Me.dtQCDateSignoff.TabIndex = 24
        '
        'txtQCNameBackup
        '
        Me.txtQCNameBackup.Enabled = False
        Me.txtQCNameBackup.Location = New System.Drawing.Point(198, 64)
        Me.txtQCNameBackup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtQCNameBackup.Name = "txtQCNameBackup"
        Me.txtQCNameBackup.Size = New System.Drawing.Size(158, 21)
        Me.txtQCNameBackup.TabIndex = 23
        '
        'txtQCName
        '
        Me.txtQCName.Enabled = False
        Me.txtQCName.Location = New System.Drawing.Point(198, 23)
        Me.txtQCName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtQCName.Name = "txtQCName"
        Me.txtQCName.Size = New System.Drawing.Size(158, 21)
        Me.txtQCName.TabIndex = 22
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(26, 106)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 13)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "QC Signoff"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(26, 64)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "QC Backup"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(26, 25)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(22, 13)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "QC"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.txtPlanningNotes)
        Me.XtraTabPage5.Controls.Add(Me.Label19)
        Me.XtraTabPage5.Controls.Add(Me.btnAbort)
        Me.XtraTabPage5.Controls.Add(Me.btnPlanningSignOff)
        Me.XtraTabPage5.Controls.Add(Me.dtPlanningSignOffDate)
        Me.XtraTabPage5.Controls.Add(Me.txtPlanner2)
        Me.XtraTabPage5.Controls.Add(Me.Label30)
        Me.XtraTabPage5.Controls.Add(Me.Label31)
        Me.XtraTabPage5.Controls.Add(Me.txtPlanner1)
        Me.XtraTabPage5.Controls.Add(Me.Label32)
        Me.XtraTabPage5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(1228, 399)
        Me.XtraTabPage5.Text = "Planning"
        '
        'txtPlanningNotes
        '
        Me.txtPlanningNotes.Location = New System.Drawing.Point(26, 151)
        Me.txtPlanningNotes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPlanningNotes.Multiline = True
        Me.txtPlanningNotes.Name = "txtPlanningNotes"
        Me.txtPlanningNotes.Size = New System.Drawing.Size(954, 62)
        Me.txtPlanningNotes.TabIndex = 36
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Italic)
        Me.Label19.Location = New System.Drawing.Point(365, 26)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(309, 13)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Once signed off, name in this field is the person who signed off"
        '
        'btnAbort
        '
        Me.btnAbort.Location = New System.Drawing.Point(138, 226)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(76, 25)
        Me.btnAbort.TabIndex = 28
        Me.btnAbort.Text = "Abort"
        Me.btnAbort.UseVisualStyleBackColor = True
        '
        'btnPlanningSignOff
        '
        Me.btnPlanningSignOff.Location = New System.Drawing.Point(26, 224)
        Me.btnPlanningSignOff.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPlanningSignOff.Name = "btnPlanningSignOff"
        Me.btnPlanningSignOff.Size = New System.Drawing.Size(90, 27)
        Me.btnPlanningSignOff.TabIndex = 34
        Me.btnPlanningSignOff.Text = "Sign Off"
        Me.btnPlanningSignOff.UseVisualStyleBackColor = True
        '
        'dtPlanningSignOffDate
        '
        Me.dtPlanningSignOffDate.Enabled = False
        Me.dtPlanningSignOffDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPlanningSignOffDate.Location = New System.Drawing.Point(196, 109)
        Me.dtPlanningSignOffDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtPlanningSignOffDate.Name = "dtPlanningSignOffDate"
        Me.dtPlanningSignOffDate.Size = New System.Drawing.Size(158, 21)
        Me.dtPlanningSignOffDate.TabIndex = 33
        '
        'txtPlanner2
        '
        Me.txtPlanner2.Enabled = False
        Me.txtPlanner2.Location = New System.Drawing.Point(199, 67)
        Me.txtPlanner2.Name = "txtPlanner2"
        Me.txtPlanner2.Size = New System.Drawing.Size(135, 21)
        Me.txtPlanner2.TabIndex = 27
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(24, 109)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(89, 13)
        Me.Label30.TabIndex = 30
        Me.Label30.Text = "Planning Sign Off"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(24, 67)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(52, 13)
        Me.Label31.TabIndex = 29
        Me.Label31.Text = "Planner 2"
        '
        'txtPlanner1
        '
        Me.txtPlanner1.Enabled = False
        Me.txtPlanner1.Location = New System.Drawing.Point(196, 28)
        Me.txtPlanner1.Name = "txtPlanner1"
        Me.txtPlanner1.Size = New System.Drawing.Size(138, 21)
        Me.txtPlanner1.TabIndex = 26
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(24, 28)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(52, 13)
        Me.Label32.TabIndex = 28
        Me.Label32.Text = "Planner 1"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.btnSaveNew)
        Me.XtraTabPage6.Controls.Add(Me.GridControl2)
        Me.XtraTabPage6.Controls.Add(Me.btnFileAttachSubmit)
        Me.XtraTabPage6.Controls.Add(Me.btnBrowse)
        Me.XtraTabPage6.Controls.Add(Me.Label25)
        Me.XtraTabPage6.Controls.Add(Me.Label24)
        Me.XtraTabPage6.Controls.Add(Me.txtFilePath)
        Me.XtraTabPage6.Controls.Add(Me.txtFileDescription)
        Me.XtraTabPage6.Controls.Add(Me.btnDeleteAttachment)
        Me.XtraTabPage6.Controls.Add(Me.btnView)
        Me.XtraTabPage6.Controls.Add(Me.txtAttachRecordID)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(1228, 399)
        Me.XtraTabPage6.Text = "Attachments"
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Location = New System.Drawing.Point(800, 336)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(101, 23)
        Me.btnSaveNew.TabIndex = 11
        Me.btnSaveNew.Text = "Save New"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        Me.btnSaveNew.Visible = False
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.BindingSource3
        Me.GridControl2.Location = New System.Drawing.Point(5, 12)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1131, 200)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "tblEARRAttach"
        Me.BindingSource3.DataSource = Me.DataSet71
        '
        'DataSet71
        '
        Me.DataSet71.DataSetName = "DataSet7"
        Me.DataSet71.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colEARRID, Me.colFilePath, Me.colFileDescription, Me.colImgField, Me.colFileName, Me.colFileExt})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.MinWidth = 19
        Me.colRecordID.Name = "colRecordID"
        Me.colRecordID.Width = 70
        '
        'colEARRID
        '
        Me.colEARRID.FieldName = "EARRID"
        Me.colEARRID.MinWidth = 19
        Me.colEARRID.Name = "colEARRID"
        Me.colEARRID.Width = 70
        '
        'colFilePath
        '
        Me.colFilePath.FieldName = "FilePath"
        Me.colFilePath.MinWidth = 19
        Me.colFilePath.Name = "colFilePath"
        Me.colFilePath.Visible = True
        Me.colFilePath.VisibleIndex = 0
        Me.colFilePath.Width = 70
        '
        'colFileDescription
        '
        Me.colFileDescription.FieldName = "FileDescription"
        Me.colFileDescription.MinWidth = 19
        Me.colFileDescription.Name = "colFileDescription"
        Me.colFileDescription.Visible = True
        Me.colFileDescription.VisibleIndex = 1
        Me.colFileDescription.Width = 70
        '
        'colImgField
        '
        Me.colImgField.FieldName = "ImgField"
        Me.colImgField.MinWidth = 19
        Me.colImgField.Name = "colImgField"
        Me.colImgField.Width = 70
        '
        'colFileName
        '
        Me.colFileName.FieldName = "FileName"
        Me.colFileName.MinWidth = 19
        Me.colFileName.Name = "colFileName"
        Me.colFileName.Visible = True
        Me.colFileName.VisibleIndex = 2
        Me.colFileName.Width = 70
        '
        'colFileExt
        '
        Me.colFileExt.FieldName = "FileExt"
        Me.colFileExt.MinWidth = 19
        Me.colFileExt.Name = "colFileExt"
        Me.colFileExt.Visible = True
        Me.colFileExt.VisibleIndex = 3
        Me.colFileExt.Width = 70
        '
        'btnFileAttachSubmit
        '
        Me.btnFileAttachSubmit.Location = New System.Drawing.Point(1024, 217)
        Me.btnFileAttachSubmit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFileAttachSubmit.Name = "btnFileAttachSubmit"
        Me.btnFileAttachSubmit.Size = New System.Drawing.Size(112, 37)
        Me.btnFileAttachSubmit.TabIndex = 10
        Me.btnFileAttachSubmit.Text = "Submit New"
        Me.btnFileAttachSubmit.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(685, 336)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(101, 23)
        Me.btnBrowse.TabIndex = 9
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label25.Location = New System.Drawing.Point(19, 336)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 13)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Path:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(19, 290)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(74, 13)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Description:"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(103, 336)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(577, 21)
        Me.txtFilePath.TabIndex = 6
        '
        'txtFileDescription
        '
        Me.txtFileDescription.Location = New System.Drawing.Point(104, 290)
        Me.txtFileDescription.Name = "txtFileDescription"
        Me.txtFileDescription.Size = New System.Drawing.Size(577, 21)
        Me.txtFileDescription.TabIndex = 5
        '
        'btnDeleteAttachment
        '
        Me.btnDeleteAttachment.Location = New System.Drawing.Point(651, 218)
        Me.btnDeleteAttachment.Name = "btnDeleteAttachment"
        Me.btnDeleteAttachment.Size = New System.Drawing.Size(196, 37)
        Me.btnDeleteAttachment.TabIndex = 3
        Me.btnDeleteAttachment.Text = "Delete Selected Attachment"
        Me.btnDeleteAttachment.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(853, 218)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(148, 37)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "View Selected File"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'txtAttachRecordID
        '
        Me.txtAttachRecordID.Location = New System.Drawing.Point(508, 182)
        Me.txtAttachRecordID.Name = "txtAttachRecordID"
        Me.txtAttachRecordID.Size = New System.Drawing.Size(100, 21)
        Me.txtAttachRecordID.TabIndex = 4
        '
        'txtRecordID
        '
        Me.txtRecordID.Location = New System.Drawing.Point(504, 108)
        Me.txtRecordID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(128, 20)
        Me.txtRecordID.TabIndex = 7
        '
        'btnSaveSelectedEARR
        '
        Me.btnSaveSelectedEARR.Location = New System.Drawing.Point(1071, 707)
        Me.btnSaveSelectedEARR.Name = "btnSaveSelectedEARR"
        Me.btnSaveSelectedEARR.Size = New System.Drawing.Size(164, 23)
        Me.btnSaveSelectedEARR.TabIndex = 8
        Me.btnSaveSelectedEARR.Text = "Save Selected EARR"
        Me.btnSaveSelectedEARR.UseVisualStyleBackColor = True
        '
        'btnPrintEarr
        '
        Me.btnPrintEarr.Location = New System.Drawing.Point(877, 708)
        Me.btnPrintEarr.Name = "btnPrintEarr"
        Me.btnPrintEarr.Size = New System.Drawing.Size(164, 23)
        Me.btnPrintEarr.TabIndex = 9
        Me.btnPrintEarr.Text = "Print EARR"
        Me.btnPrintEarr.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        tblAttachments.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblAttachments"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 0, "Description"), New System.Data.SqlClient.SqlParameter("@Path", System.Data.SqlDbType.NVarChar, 0, "Path"), New System.Data.SqlClient.SqlParameter("@FileExt", System.Data.SqlDbType.NVarChar, 0, "FileExt")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 0, "Description"), New System.Data.SqlClient.SqlParameter("@Path", System.Data.SqlDbType.NVarChar, 0, "Path"), New System.Data.SqlClient.SqlParameter("@FileExt", System.Data.SqlDbType.NVarChar, 0, "FileExt"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Path", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Path", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Path", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Path", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileExt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileExt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Path", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Path", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Path", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Path", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileExt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileExt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblAttachments", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Path", "Path"), New System.Data.Common.DataColumnMapping("FileExt", "FileExt")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'DataSet61
        '
        Me.DataSet61.DataSetName = "DataSet6"
        Me.DataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "tblAttachments"
        Me.BindingSource2.DataSource = Me.DataSet61
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.DeleteCommand = Me.SqlDeleteCommand3
        Me.SqlDataAdapter3.InsertCommand = Me.SqlInsertCommand3
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.UpdateCommand = Me.SqlUpdateCommand3
        '
        'txtEARRStatus
        '
        Me.txtEARRStatus.Location = New System.Drawing.Point(557, 50)
        Me.txtEARRStatus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEARRStatus.Name = "txtEARRStatus"
        Me.txtEARRStatus.Size = New System.Drawing.Size(76, 20)
        Me.txtEARRStatus.TabIndex = 10
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT tblEARRAttach.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     tblEARRAttach"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EARRID", System.Data.SqlDbType.Int, 0, "EARRID"), New System.Data.SqlClient.SqlParameter("@FilePath", System.Data.SqlDbType.NVarChar, 0, "FilePath"), New System.Data.SqlClient.SqlParameter("@FileDescription", System.Data.SqlDbType.NVarChar, 0, "FileDescription"), New System.Data.SqlClient.SqlParameter("@ImgField", System.Data.SqlDbType.Image, 0, "ImgField"), New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.NVarChar, 0, "FileName"), New System.Data.SqlClient.SqlParameter("@FileExt", System.Data.SqlDbType.NVarChar, 0, "FileExt")})
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EARRID", System.Data.SqlDbType.Int, 0, "EARRID"), New System.Data.SqlClient.SqlParameter("@FilePath", System.Data.SqlDbType.NVarChar, 0, "FilePath"), New System.Data.SqlClient.SqlParameter("@FileDescription", System.Data.SqlDbType.NVarChar, 0, "FileDescription"), New System.Data.SqlClient.SqlParameter("@ImgField", System.Data.SqlDbType.Image, 0, "ImgField"), New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.NVarChar, 0, "FileName"), New System.Data.SqlClient.SqlParameter("@FileExt", System.Data.SqlDbType.NVarChar, 0, "FileExt"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FilePath", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FilePath", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FilePath", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FilePath", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileExt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileExt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EARRID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EARRID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EARRID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EARRID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FilePath", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FilePath", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FilePath", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FilePath", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileExt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileExt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.DeleteCommand = Me.SqlDeleteCommand4
        Me.SqlDataAdapter4.InsertCommand = Me.SqlInsertCommand4
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblEARRAttach", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("EARRID", "EARRID"), New System.Data.Common.DataColumnMapping("FilePath", "FilePath"), New System.Data.Common.DataColumnMapping("FileDescription", "FileDescription"), New System.Data.Common.DataColumnMapping("ImgField", "ImgField"), New System.Data.Common.DataColumnMapping("FileName", "FileName"), New System.Data.Common.DataColumnMapping("FileExt", "FileExt")})})
        Me.SqlDataAdapter4.UpdateCommand = Me.SqlUpdateCommand4
        '
        'btnSaveEARR
        '
        Me.btnSaveEARR.Location = New System.Drawing.Point(1039, 192)
        Me.btnSaveEARR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSaveEARR.Name = "btnSaveEARR"
        Me.btnSaveEARR.Size = New System.Drawing.Size(196, 34)
        Me.btnSaveEARR.TabIndex = 11
        Me.btnSaveEARR.Text = "Save Selected EARR"
        Me.btnSaveEARR.UseVisualStyleBackColor = True
        '
        'frmEARRApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 682)
        Me.Controls.Add(Me.btnSaveEARR)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btnPrintEarr)
        Me.Controls.Add(Me.btnSaveSelectedEARR)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.txtRecordID)
        Me.Controls.Add(Me.txtEARRStatus)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmEARRApproval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEARRApproval"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet51BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage5.PerformLayout()
        Me.XtraTabPage6.ResumeLayout(False)
        Me.XtraTabPage6.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet51 As DataSet5
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEARRNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEARRStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEARRType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox5 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet51BindingSource As BindingSource
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dtLiaisonManagerSignOffDate As DateTimePicker
    Friend WithEvents txtLiaisonManagerNameBackup As TextBox
    Friend WithEvents txtLiaisonManagerName As TextBox
    Friend WithEvents txtReplyInstructions As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents chkDesignError As CheckBox
    Friend WithEvents chkDWGError As CheckBox
    Friend WithEvents chkProductImprovement As CheckBox
    Friend WithEvents chkManufacturability As CheckBox
    Friend WithEvents chkACFTInterface As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents chkAdditionalEngReqUpdate As CheckBox
    Friend WithEvents chkAdditionalEngReqNoAction As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkDeviationMajor As CheckBox
    Friend WithEvents chkDeviationMinor As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtEffectivityOtherText As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents chkEffectivityOther As CheckBox
    Friend WithEvents chkEffectivityAll As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dtOriginatorDate As DateTimePicker
    Friend WithEvents txtOriginatorName As TextBox
    Friend WithEvents txtRequest As TextBox
    Friend WithEvents txtDrawingRevision As TextBox
    Friend WithEvents txtDrawingNumber As TextBox
    Friend WithEvents txtWorkOrder As TextBox
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents cboEARRType As ComboBox
    Friend WithEvents cboProgramName As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkDrawingRequestForConformityNo As CheckBox
    Friend WithEvents chkDrawingRequestForConformityYes As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkIncorpRedLineNo As CheckBox
    Friend WithEvents chkIncorpRedLineYes As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dtEngineeringManagerSignOffDate As DateTimePicker
    Friend WithEvents txtEngineeringManagerNameBackup As TextBox
    Friend WithEvents txtEngineeringManagerName As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtRecordID As TextBox
    Friend WithEvents btnLiaisonSignOff As Button
    Friend WithEvents btnEngManagerSignOff As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents txtEARRNumber As TextBox
    Friend WithEvents btnSaveSelectedEARR As Button
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnQCSignOff As Button
    Friend WithEvents dtQCDateSignoff As DateTimePicker
    Friend WithEvents txtQCNameBackup As TextBox
    Friend WithEvents txtQCName As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents btnRescind As Button
    Friend WithEvents txtPlanner2 As TextBox
    Friend WithEvents txtPlanner1 As TextBox
    Friend WithEvents btnAbort As Button
    Friend WithEvents colFabShop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkProductionError As CheckBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents dtEARRResponseDate As DateTimePicker
    Friend WithEvents Label29 As Label
    Friend WithEvents txtQCNotes As TextBox
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtPlanningNotes As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnPlanningSignOff As Button
    Friend WithEvents dtPlanningSignOffDate As DateTimePicker
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents btnPrintEarr As Button
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents txtFileDescription As TextBox
    Friend WithEvents txtAttachRecordID As TextBox
    Friend WithEvents btnDeleteAttachment As Button
    Friend WithEvents btnView As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnBrowse As Button
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet61 As DataSet6
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter3 As SqlClient.SqlDataAdapter
    Friend WithEvents Label33 As Label
    Friend WithEvents txtEndItemType As TextBox
    Friend WithEvents txtEARRStatus As TextBox
    Friend WithEvents chkDeviationNA As CheckBox
    Friend WithEvents btnFileAttachSubmit As Button
    Friend WithEvents SqlSelectCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter4 As SqlClient.SqlDataAdapter
    Friend WithEvents BindingSource3 As BindingSource
    Friend WithEvents DataSet71 As DataSet7
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEARRID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFilePath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImgField As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileExt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSaveNew As Button
    Friend WithEvents btnSaveEARR As Button
End Class
