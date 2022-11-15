<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNCRSteps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNCRSteps))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsNCR = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNCR1 = New EngDesignTracking.dsNCR()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNCRNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLatestStep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAcceptedStep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualStep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAbortedReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerialNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerialNumType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRevision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkOrderStep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchaseOrderNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginatorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubmissionDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscrepancy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGraphicName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGraphics = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhereDiscovered = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colManufacturer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReportedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTypeOfError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDispositionType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatusNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateClosed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdditionalActions = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostIsSignificant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.dtpReturnDt = New System.Windows.Forms.DateTimePicker()
        Me.cboResponsibleDept = New System.Windows.Forms.ComboBox()
        Me.txtSupplierPurchaseOrder = New System.Windows.Forms.TextBox()
        Me.txtTotalQuantity = New System.Windows.Forms.TextBox()
        Me.txtSalesOrderNum = New System.Windows.Forms.TextBox()
        Me.txtMaterialReturnAuthNum = New System.Windows.Forms.TextBox()
        Me.txtCustomerNCRNum = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtCause = New System.Windows.Forms.TextBox()
        Me.txtResponsiblePerson = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.rtxtAdditionalActionNotes = New System.Windows.Forms.RichTextBox()
        Me.groupboxAdditionalActions = New System.Windows.Forms.GroupBox()
        Me.chkNone = New System.Windows.Forms.CheckBox()
        Me.chkOther = New System.Windows.Forms.CheckBox()
        Me.chkNotify = New System.Windows.Forms.CheckBox()
        Me.chkWriteCPAR = New System.Windows.Forms.CheckBox()
        Me.chkWriteCAR = New System.Windows.Forms.CheckBox()
        Me.chkWriteSCAR = New System.Windows.Forms.CheckBox()
        Me.lblDateClosed = New System.Windows.Forms.Label()
        Me.rtxtDispositionNotes = New System.Windows.Forms.RichTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboDispositionType = New System.Windows.Forms.ComboBox()
        Me.cboTypeOfError = New System.Windows.Forms.ComboBox()
        Me.txtReportedBy = New System.Windows.Forms.TextBox()
        Me.btnSaveOtherInfo = New System.Windows.Forms.Button()
        Me.txtQuantityRejected = New System.Windows.Forms.TextBox()
        Me.cboManufacturer = New System.Windows.Forms.ComboBox()
        Me.cboWhereDiscovered = New System.Windows.Forms.ComboBox()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblStatusNotes = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtAircraftIdentifier = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cboStep = New System.Windows.Forms.ComboBox()
        Me.btnSaveCreateTab = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.rtxtComments = New System.Windows.Forms.RichTextBox()
        Me.rtxtDiscrepancy = New System.Windows.Forms.RichTextBox()
        Me.txtPurchaseOrder = New System.Windows.Forms.TextBox()
        Me.cboWorkOrder = New System.Windows.Forms.ComboBox()
        Me.txtPartDescription = New System.Windows.Forms.TextBox()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.cboRev = New System.Windows.Forms.ComboBox()
        Me.txtDrawingNum = New System.Windows.Forms.TextBox()
        Me.cboSerialNumType = New System.Windows.Forms.ComboBox()
        Me.txtSerialNum = New System.Windows.Forms.TextBox()
        Me.cboPrograms = New System.Windows.Forms.ComboBox()
        Me.XtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.lblResubmitSelectedRow = New System.Windows.Forms.Label()
        Me.rtxtResubmitSelectedRow = New System.Windows.Forms.RichTextBox()
        Me.btnSaveDisposition = New System.Windows.Forms.Button()
        Me.btnAbort = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnCloseNCR = New System.Windows.Forms.Button()
        Me.btnAddStep = New System.Windows.Forms.Button()
        Me.GroupBoxNotifications = New System.Windows.Forms.GroupBox()
        Me.btnNotifyEngineers = New System.Windows.Forms.Button()
        Me.btnNotifyMRBs = New System.Windows.Forms.Button()
        Me.rtxtAddDisposition = New System.Windows.Forms.RichTextBox()
        Me.lblDisposition = New System.Windows.Forms.Label()
        Me.rtxtDisposition = New System.Windows.Forms.RichTextBox()
        Me.lblEnterDisposition = New System.Windows.Forms.Label()
        Me.btnDeleteSelectedRecord = New System.Windows.Forms.Button()
        Me.btnSaveAsEngineer = New System.Windows.Forms.Button()
        Me.btnSaveAsMRB = New System.Windows.Forms.Button()
        Me.btnSignOff = New System.Windows.Forms.Button()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.bsEngineersMRBs = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEngineersMRBs1 = New EngDesignTracking.dsEngineersMRBs()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNCRNumber2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStep2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLatestStep2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAcceptedStep2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualStep2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSignOffUserEng = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSignOffUserMRB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSignOffDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAbortedReason2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNumber2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRevision2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginatorName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubmissionDt2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateClosed2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRB2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colEngineer2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colChairperson1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.bsSteps = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsStepsOfNCR1 = New EngDesignTracking.dsStepsOfNCR()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNCRNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStep1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLatestStep1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAcceptedStep1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAbortedReason1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRevision1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginatorName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubmissionDt1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateClosed1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRB1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChairperson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtStep = New System.Windows.Forms.TextBox()
        Me.txtRecordIDSignOff = New System.Windows.Forms.TextBox()
        Me.txtMRB = New System.Windows.Forms.TextBox()
        Me.txtEngineer = New System.Windows.Forms.TextBox()
        Me.txtIsSignedOff = New System.Windows.Forms.TextBox()
        Me.txtAcceptedStep = New System.Windows.Forms.TextBox()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.btnFileAttachSubmit = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.txtFileDescription = New System.Windows.Forms.TextBox()
        Me.btnDeleteAttachment = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.bsAttachments = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNCRAttachments1 = New EngDesignTracking.dsNCRAttachments()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNCRID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFilePath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImgField = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileExt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAttachRecordID = New System.Windows.Forms.TextBox()
        Me.txtActualStepAttach = New System.Windows.Forms.TextBox()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daNCR = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daSteps = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.daEngineersMRBs = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.daAttachments = New System.Data.SqlClient.SqlDataAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnPrintSteps = New System.Windows.Forms.Button()
        Me.btnPrintNCR = New System.Windows.Forms.Button()
        Me.colActualStep1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsNCR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNCR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.groupboxAdditionalActions.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage.SuspendLayout()
        Me.GroupBoxNotifications.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEngineersMRBs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEngineersMRBs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSteps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsStepsOfNCR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNCRAttachments1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsNCR
        Me.GridControl1.Location = New System.Drawing.Point(1, 1)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1471, 112)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsNCR
        '
        Me.bsNCR.DataMember = "tblNCR"
        Me.bsNCR.DataSource = Me.DsNCR1
        '
        'DsNCR1
        '
        Me.DsNCR1.DataSetName = "dsNCR"
        Me.DsNCR1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colNCRNumber, Me.colStatus, Me.colStep, Me.colLatestStep, Me.colAcceptedStep, Me.colActualStep, Me.colLocation, Me.colAbortedReason, Me.colProgram, Me.colSerialNum, Me.colSerialNumType, Me.colDrawingNumber, Me.colDwgRevision, Me.colPartNumber, Me.colPartDescription, Me.colWorkOrderStep, Me.colPurchaseOrderNum, Me.colOriginatorName, Me.colSubmissionDt, Me.colDiscrepancy, Me.colComments, Me.colType, Me.colGraphicName, Me.colGraphics, Me.colWhereDiscovered, Me.colManufacturer, Me.colQuantity, Me.colReportedBy, Me.colTypeOfError, Me.colDispositionType, Me.colStatusNotes, Me.colDateClosed, Me.colAdditionalActions, Me.colNotes, Me.colCostIsSignificant, Me.colMRB, Me.colEngineer})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.Name = "colRecordID"
        '
        'colNCRNumber
        '
        Me.colNCRNumber.FieldName = "NCRNumber"
        Me.colNCRNumber.Name = "colNCRNumber"
        Me.colNCRNumber.Visible = True
        Me.colNCRNumber.VisibleIndex = 0
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 1
        Me.colStatus.Width = 49
        '
        'colStep
        '
        Me.colStep.FieldName = "Step"
        Me.colStep.Name = "colStep"
        Me.colStep.Visible = True
        Me.colStep.VisibleIndex = 10
        Me.colStep.Width = 55
        '
        'colLatestStep
        '
        Me.colLatestStep.FieldName = "LatestStep"
        Me.colLatestStep.Name = "colLatestStep"
        '
        'colAcceptedStep
        '
        Me.colAcceptedStep.FieldName = "AcceptedStep"
        Me.colAcceptedStep.Name = "colAcceptedStep"
        '
        'colActualStep
        '
        Me.colActualStep.FieldName = "ActualStep"
        Me.colActualStep.Name = "colActualStep"
        '
        'colLocation
        '
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        '
        'colAbortedReason
        '
        Me.colAbortedReason.FieldName = "AbortedReason"
        Me.colAbortedReason.Name = "colAbortedReason"
        '
        'colProgram
        '
        Me.colProgram.FieldName = "Program"
        Me.colProgram.Name = "colProgram"
        Me.colProgram.Visible = True
        Me.colProgram.VisibleIndex = 6
        Me.colProgram.Width = 79
        '
        'colSerialNum
        '
        Me.colSerialNum.FieldName = "SerialNum"
        Me.colSerialNum.Name = "colSerialNum"
        Me.colSerialNum.Visible = True
        Me.colSerialNum.VisibleIndex = 12
        '
        'colSerialNumType
        '
        Me.colSerialNumType.FieldName = "SerialNumType"
        Me.colSerialNumType.Name = "colSerialNumType"
        Me.colSerialNumType.Visible = True
        Me.colSerialNumType.VisibleIndex = 11
        '
        'colDrawingNumber
        '
        Me.colDrawingNumber.FieldName = "DrawingNumber"
        Me.colDrawingNumber.Name = "colDrawingNumber"
        Me.colDrawingNumber.Visible = True
        Me.colDrawingNumber.VisibleIndex = 5
        Me.colDrawingNumber.Width = 88
        '
        'colDwgRevision
        '
        Me.colDwgRevision.FieldName = "DwgRevision"
        Me.colDwgRevision.Name = "colDwgRevision"
        '
        'colPartNumber
        '
        Me.colPartNumber.FieldName = "PartNumber"
        Me.colPartNumber.Name = "colPartNumber"
        Me.colPartNumber.Visible = True
        Me.colPartNumber.VisibleIndex = 13
        '
        'colPartDescription
        '
        Me.colPartDescription.FieldName = "PartDescription"
        Me.colPartDescription.Name = "colPartDescription"
        Me.colPartDescription.Visible = True
        Me.colPartDescription.VisibleIndex = 14
        Me.colPartDescription.Width = 89
        '
        'colWorkOrderStep
        '
        Me.colWorkOrderStep.FieldName = "WorkOrderStep"
        Me.colWorkOrderStep.Name = "colWorkOrderStep"
        Me.colWorkOrderStep.Visible = True
        Me.colWorkOrderStep.VisibleIndex = 4
        Me.colWorkOrderStep.Width = 91
        '
        'colPurchaseOrderNum
        '
        Me.colPurchaseOrderNum.FieldName = "PurchaseOrderNum"
        Me.colPurchaseOrderNum.Name = "colPurchaseOrderNum"
        Me.colPurchaseOrderNum.Visible = True
        Me.colPurchaseOrderNum.VisibleIndex = 15
        Me.colPurchaseOrderNum.Width = 108
        '
        'colOriginatorName
        '
        Me.colOriginatorName.FieldName = "OriginatorName"
        Me.colOriginatorName.Name = "colOriginatorName"
        Me.colOriginatorName.Visible = True
        Me.colOriginatorName.VisibleIndex = 7
        Me.colOriginatorName.Width = 91
        '
        'colSubmissionDt
        '
        Me.colSubmissionDt.FieldName = "SubmissionDt"
        Me.colSubmissionDt.Name = "colSubmissionDt"
        Me.colSubmissionDt.Visible = True
        Me.colSubmissionDt.VisibleIndex = 8
        '
        'colDiscrepancy
        '
        Me.colDiscrepancy.FieldName = "Discrepancy"
        Me.colDiscrepancy.Name = "colDiscrepancy"
        Me.colDiscrepancy.Visible = True
        Me.colDiscrepancy.VisibleIndex = 2
        Me.colDiscrepancy.Width = 158
        '
        'colComments
        '
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 9
        Me.colComments.Width = 208
        '
        'colType
        '
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 3
        Me.colType.Width = 56
        '
        'colGraphicName
        '
        Me.colGraphicName.FieldName = "GraphicName"
        Me.colGraphicName.Name = "colGraphicName"
        '
        'colGraphics
        '
        Me.colGraphics.FieldName = "Graphics"
        Me.colGraphics.Name = "colGraphics"
        '
        'colWhereDiscovered
        '
        Me.colWhereDiscovered.FieldName = "WhereDiscovered"
        Me.colWhereDiscovered.Name = "colWhereDiscovered"
        '
        'colManufacturer
        '
        Me.colManufacturer.FieldName = "Manufacturer"
        Me.colManufacturer.Name = "colManufacturer"
        '
        'colQuantity
        '
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        '
        'colReportedBy
        '
        Me.colReportedBy.FieldName = "ReportedBy"
        Me.colReportedBy.Name = "colReportedBy"
        '
        'colTypeOfError
        '
        Me.colTypeOfError.FieldName = "TypeOfError"
        Me.colTypeOfError.Name = "colTypeOfError"
        '
        'colDispositionType
        '
        Me.colDispositionType.FieldName = "DispositionType"
        Me.colDispositionType.Name = "colDispositionType"
        '
        'colStatusNotes
        '
        Me.colStatusNotes.FieldName = "StatusNotes"
        Me.colStatusNotes.Name = "colStatusNotes"
        '
        'colDateClosed
        '
        Me.colDateClosed.FieldName = "DateClosed"
        Me.colDateClosed.Name = "colDateClosed"
        '
        'colAdditionalActions
        '
        Me.colAdditionalActions.FieldName = "AdditionalActions"
        Me.colAdditionalActions.Name = "colAdditionalActions"
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        '
        'colCostIsSignificant
        '
        Me.colCostIsSignificant.FieldName = "CostIsSignificant"
        Me.colCostIsSignificant.Name = "colCostIsSignificant"
        '
        'colMRB
        '
        Me.colMRB.FieldName = "MRB"
        Me.colMRB.Name = "colMRB"
        '
        'colEngineer
        '
        Me.colEngineer.FieldName = "Engineer"
        Me.colEngineer.Name = "colEngineer"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(1, 132)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1471, 679)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage, Me.XtraTabPage1, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.dtpReturnDt)
        Me.XtraTabPage1.Controls.Add(Me.cboResponsibleDept)
        Me.XtraTabPage1.Controls.Add(Me.txtSupplierPurchaseOrder)
        Me.XtraTabPage1.Controls.Add(Me.txtTotalQuantity)
        Me.XtraTabPage1.Controls.Add(Me.txtSalesOrderNum)
        Me.XtraTabPage1.Controls.Add(Me.txtMaterialReturnAuthNum)
        Me.XtraTabPage1.Controls.Add(Me.txtCustomerNCRNum)
        Me.XtraTabPage1.Controls.Add(Me.txtCost)
        Me.XtraTabPage1.Controls.Add(Me.txtCause)
        Me.XtraTabPage1.Controls.Add(Me.txtResponsiblePerson)
        Me.XtraTabPage1.Controls.Add(Me.Label42)
        Me.XtraTabPage1.Controls.Add(Me.Label41)
        Me.XtraTabPage1.Controls.Add(Me.Label40)
        Me.XtraTabPage1.Controls.Add(Me.Label39)
        Me.XtraTabPage1.Controls.Add(Me.Label38)
        Me.XtraTabPage1.Controls.Add(Me.Label35)
        Me.XtraTabPage1.Controls.Add(Me.Label15)
        Me.XtraTabPage1.Controls.Add(Me.Label14)
        Me.XtraTabPage1.Controls.Add(Me.Label11)
        Me.XtraTabPage1.Controls.Add(Me.Label1)
        Me.XtraTabPage1.Controls.Add(Me.txtStatus)
        Me.XtraTabPage1.Controls.Add(Me.rtxtAdditionalActionNotes)
        Me.XtraTabPage1.Controls.Add(Me.groupboxAdditionalActions)
        Me.XtraTabPage1.Controls.Add(Me.lblDateClosed)
        Me.XtraTabPage1.Controls.Add(Me.rtxtDispositionNotes)
        Me.XtraTabPage1.Controls.Add(Me.Label20)
        Me.XtraTabPage1.Controls.Add(Me.Label19)
        Me.XtraTabPage1.Controls.Add(Me.Label18)
        Me.XtraTabPage1.Controls.Add(Me.Label17)
        Me.XtraTabPage1.Controls.Add(Me.Label16)
        Me.XtraTabPage1.Controls.Add(Me.cboDispositionType)
        Me.XtraTabPage1.Controls.Add(Me.cboTypeOfError)
        Me.XtraTabPage1.Controls.Add(Me.txtReportedBy)
        Me.XtraTabPage1.Controls.Add(Me.btnSaveOtherInfo)
        Me.XtraTabPage1.Controls.Add(Me.txtQuantityRejected)
        Me.XtraTabPage1.Controls.Add(Me.cboManufacturer)
        Me.XtraTabPage1.Controls.Add(Me.cboWhereDiscovered)
        Me.XtraTabPage1.Controls.Add(Me.cboLocation)
        Me.XtraTabPage1.Controls.Add(Me.cboType)
        Me.XtraTabPage1.Controls.Add(Me.lblNotes)
        Me.XtraTabPage1.Controls.Add(Me.Label13)
        Me.XtraTabPage1.Controls.Add(Me.Label12)
        Me.XtraTabPage1.Controls.Add(Me.lblStatusNotes)
        Me.XtraTabPage1.Controls.Add(Me.Label10)
        Me.XtraTabPage1.Controls.Add(Me.Label9)
        Me.XtraTabPage1.Controls.Add(Me.Label8)
        Me.XtraTabPage1.Controls.Add(Me.Label7)
        Me.XtraTabPage1.Controls.Add(Me.Label6)
        Me.XtraTabPage1.Controls.Add(Me.Label5)
        Me.XtraTabPage1.Controls.Add(Me.Label4)
        Me.XtraTabPage1.Controls.Add(Me.Label3)
        Me.XtraTabPage1.Controls.Add(Me.Label2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1465, 651)
        Me.XtraTabPage1.Text = "Other Info"
        '
        'dtpReturnDt
        '
        Me.dtpReturnDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReturnDt.Location = New System.Drawing.Point(134, 524)
        Me.dtpReturnDt.Name = "dtpReturnDt"
        Me.dtpReturnDt.Size = New System.Drawing.Size(234, 21)
        Me.dtpReturnDt.TabIndex = 31
        Me.dtpReturnDt.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'cboResponsibleDept
        '
        Me.cboResponsibleDept.FormattingEnabled = True
        Me.cboResponsibleDept.Items.AddRange(New Object() {"Other", "Repair*", "Return to Supplier", "Rework", "Scrap", "Use-As-Is*"})
        Me.cboResponsibleDept.Location = New System.Drawing.Point(134, 364)
        Me.cboResponsibleDept.Name = "cboResponsibleDept"
        Me.cboResponsibleDept.Size = New System.Drawing.Size(234, 21)
        Me.cboResponsibleDept.TabIndex = 24
        '
        'txtSupplierPurchaseOrder
        '
        Me.txtSupplierPurchaseOrder.Location = New System.Drawing.Point(134, 594)
        Me.txtSupplierPurchaseOrder.Name = "txtSupplierPurchaseOrder"
        Me.txtSupplierPurchaseOrder.Size = New System.Drawing.Size(234, 21)
        Me.txtSupplierPurchaseOrder.TabIndex = 34
        '
        'txtTotalQuantity
        '
        Me.txtTotalQuantity.Location = New System.Drawing.Point(134, 571)
        Me.txtTotalQuantity.Name = "txtTotalQuantity"
        Me.txtTotalQuantity.Size = New System.Drawing.Size(234, 21)
        Me.txtTotalQuantity.TabIndex = 33
        '
        'txtSalesOrderNum
        '
        Me.txtSalesOrderNum.Location = New System.Drawing.Point(134, 502)
        Me.txtSalesOrderNum.Name = "txtSalesOrderNum"
        Me.txtSalesOrderNum.Size = New System.Drawing.Size(234, 21)
        Me.txtSalesOrderNum.TabIndex = 30
        '
        'txtMaterialReturnAuthNum
        '
        Me.txtMaterialReturnAuthNum.Location = New System.Drawing.Point(158, 479)
        Me.txtMaterialReturnAuthNum.Name = "txtMaterialReturnAuthNum"
        Me.txtMaterialReturnAuthNum.Size = New System.Drawing.Size(210, 21)
        Me.txtMaterialReturnAuthNum.TabIndex = 29
        '
        'txtCustomerNCRNum
        '
        Me.txtCustomerNCRNum.Location = New System.Drawing.Point(134, 456)
        Me.txtCustomerNCRNum.Name = "txtCustomerNCRNum"
        Me.txtCustomerNCRNum.Size = New System.Drawing.Size(234, 21)
        Me.txtCustomerNCRNum.TabIndex = 28
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(134, 433)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(234, 21)
        Me.txtCost.TabIndex = 27
        '
        'txtCause
        '
        Me.txtCause.Location = New System.Drawing.Point(134, 410)
        Me.txtCause.Name = "txtCause"
        Me.txtCause.Size = New System.Drawing.Size(234, 21)
        Me.txtCause.TabIndex = 26
        '
        'txtResponsiblePerson
        '
        Me.txtResponsiblePerson.Location = New System.Drawing.Point(134, 387)
        Me.txtResponsiblePerson.Name = "txtResponsiblePerson"
        Me.txtResponsiblePerson.Size = New System.Drawing.Size(234, 21)
        Me.txtResponsiblePerson.TabIndex = 25
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(0, 597)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(134, 13)
        Me.Label42.TabIndex = 50
        Me.Label42.Text = "Supplier Purchase Order #"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(10, 574)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(76, 13)
        Me.Label41.TabIndex = 49
        Me.Label41.Text = "Total Quantity"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(10, 528)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(66, 13)
        Me.Label40.TabIndex = 48
        Me.Label40.Text = "Return Date"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(10, 505)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(74, 13)
        Me.Label39.TabIndex = 47
        Me.Label39.Text = "Sales Order #"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(-3, 482)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(159, 13)
        Me.Label38.TabIndex = 46
        Me.Label38.Text = "Material Return Authorization #"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(10, 459)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 13)
        Me.Label35.TabIndex = 45
        Me.Label35.Text = "Customer NCR #"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 436)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Cost"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 413)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Cause"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 390)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Responsible Person"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Responsible Department"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(134, 5)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(234, 21)
        Me.txtStatus.TabIndex = 15
        '
        'rtxtAdditionalActionNotes
        '
        Me.rtxtAdditionalActionNotes.Location = New System.Drawing.Point(134, 323)
        Me.rtxtAdditionalActionNotes.Name = "rtxtAdditionalActionNotes"
        Me.rtxtAdditionalActionNotes.Size = New System.Drawing.Size(582, 41)
        Me.rtxtAdditionalActionNotes.TabIndex = 23
        Me.rtxtAdditionalActionNotes.Text = ""
        '
        'groupboxAdditionalActions
        '
        Me.groupboxAdditionalActions.Controls.Add(Me.chkNone)
        Me.groupboxAdditionalActions.Controls.Add(Me.chkOther)
        Me.groupboxAdditionalActions.Controls.Add(Me.chkNotify)
        Me.groupboxAdditionalActions.Controls.Add(Me.chkWriteCPAR)
        Me.groupboxAdditionalActions.Controls.Add(Me.chkWriteCAR)
        Me.groupboxAdditionalActions.Controls.Add(Me.chkWriteSCAR)
        Me.groupboxAdditionalActions.Location = New System.Drawing.Point(134, 235)
        Me.groupboxAdditionalActions.Name = "groupboxAdditionalActions"
        Me.groupboxAdditionalActions.Size = New System.Drawing.Size(289, 85)
        Me.groupboxAdditionalActions.TabIndex = 37
        Me.groupboxAdditionalActions.TabStop = False
        Me.groupboxAdditionalActions.Text = "Additional Actions"
        '
        'chkNone
        '
        Me.chkNone.AutoSize = True
        Me.chkNone.Location = New System.Drawing.Point(6, 20)
        Me.chkNone.Name = "chkNone"
        Me.chkNone.Size = New System.Drawing.Size(192, 17)
        Me.chkNone.TabIndex = 31
        Me.chkNone.Text = "None - No Further Action Required"
        Me.chkNone.UseVisualStyleBackColor = True
        '
        'chkOther
        '
        Me.chkOther.AutoSize = True
        Me.chkOther.Location = New System.Drawing.Point(204, 66)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(54, 17)
        Me.chkOther.TabIndex = 36
        Me.chkOther.Text = "Other"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'chkNotify
        '
        Me.chkNotify.AutoSize = True
        Me.chkNotify.Location = New System.Drawing.Point(6, 43)
        Me.chkNotify.Name = "chkNotify"
        Me.chkNotify.Size = New System.Drawing.Size(196, 17)
        Me.chkNotify.TabIndex = 32
        Me.chkNotify.Text = "Notify Customer and/or FAA, TCCA"
        Me.chkNotify.UseVisualStyleBackColor = True
        '
        'chkWriteCPAR
        '
        Me.chkWriteCPAR.AutoSize = True
        Me.chkWriteCPAR.Location = New System.Drawing.Point(204, 43)
        Me.chkWriteCPAR.Name = "chkWriteCPAR"
        Me.chkWriteCPAR.Size = New System.Drawing.Size(82, 17)
        Me.chkWriteCPAR.TabIndex = 35
        Me.chkWriteCPAR.Text = "Write CPAR"
        Me.chkWriteCPAR.UseVisualStyleBackColor = True
        '
        'chkWriteCAR
        '
        Me.chkWriteCAR.AutoSize = True
        Me.chkWriteCAR.Location = New System.Drawing.Point(6, 66)
        Me.chkWriteCAR.Name = "chkWriteCAR"
        Me.chkWriteCAR.Size = New System.Drawing.Size(117, 17)
        Me.chkWriteCAR.TabIndex = 33
        Me.chkWriteCAR.Text = "Write Internal CAR"
        Me.chkWriteCAR.UseVisualStyleBackColor = True
        '
        'chkWriteSCAR
        '
        Me.chkWriteSCAR.AutoSize = True
        Me.chkWriteSCAR.Location = New System.Drawing.Point(204, 20)
        Me.chkWriteSCAR.Name = "chkWriteSCAR"
        Me.chkWriteSCAR.Size = New System.Drawing.Size(82, 17)
        Me.chkWriteSCAR.TabIndex = 34
        Me.chkWriteSCAR.Text = "Write SCAR"
        Me.chkWriteSCAR.UseVisualStyleBackColor = True
        '
        'lblDateClosed
        '
        Me.lblDateClosed.AutoSize = True
        Me.lblDateClosed.Location = New System.Drawing.Point(531, 8)
        Me.lblDateClosed.Name = "lblDateClosed"
        Me.lblDateClosed.Size = New System.Drawing.Size(0, 13)
        Me.lblDateClosed.TabIndex = 30
        '
        'rtxtDispositionNotes
        '
        Me.rtxtDispositionNotes.Location = New System.Drawing.Point(134, 189)
        Me.rtxtDispositionNotes.Name = "rtxtDispositionNotes"
        Me.rtxtDispositionNotes.Size = New System.Drawing.Size(582, 46)
        Me.rtxtDispositionNotes.TabIndex = 22
        Me.rtxtDispositionNotes.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(753, 199)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(518, 13)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "(3) Requires design authority approval if nonconformity results in departure from" &
    " regulatory requirements."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(753, 177)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(493, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "(2) Requires customer approval if nonconformity results in departure from the con" &
    "tract requirements;"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(753, 158)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(369, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "(1) Requires authorized representative of design organization concurrence;"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(753, 136)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(167, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "* Use-As-Is or Repair disposition:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(368, 169)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(391, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "---------------------------------------------------------------------------------" &
    "------------->"
        '
        'cboDispositionType
        '
        Me.cboDispositionType.FormattingEnabled = True
        Me.cboDispositionType.Items.AddRange(New Object() {"Other", "Repair*", "Return to Supplier", "Rework", "Scrap", "Use-As-Is*"})
        Me.cboDispositionType.Location = New System.Drawing.Point(134, 166)
        Me.cboDispositionType.Name = "cboDispositionType"
        Me.cboDispositionType.Size = New System.Drawing.Size(234, 21)
        Me.cboDispositionType.TabIndex = 21
        '
        'cboTypeOfError
        '
        Me.cboTypeOfError.FormattingEnabled = True
        Me.cboTypeOfError.Items.AddRange(New Object() {"Drawing Error", "Engineering Design Change / Obsolete", "Installation Error", "Field Aerospace Manufacturing Error", "Supplier Error", " "})
        Me.cboTypeOfError.Location = New System.Drawing.Point(134, 143)
        Me.cboTypeOfError.Name = "cboTypeOfError"
        Me.cboTypeOfError.Size = New System.Drawing.Size(234, 21)
        Me.cboTypeOfError.TabIndex = 20
        '
        'txtReportedBy
        '
        Me.txtReportedBy.Location = New System.Drawing.Point(134, 120)
        Me.txtReportedBy.Name = "txtReportedBy"
        Me.txtReportedBy.Size = New System.Drawing.Size(234, 21)
        Me.txtReportedBy.TabIndex = 19
        '
        'btnSaveOtherInfo
        '
        Me.btnSaveOtherInfo.Location = New System.Drawing.Point(719, 599)
        Me.btnSaveOtherInfo.Name = "btnSaveOtherInfo"
        Me.btnSaveOtherInfo.Size = New System.Drawing.Size(173, 35)
        Me.btnSaveOtherInfo.TabIndex = 40
        Me.btnSaveOtherInfo.Text = "Save Data"
        Me.btnSaveOtherInfo.UseVisualStyleBackColor = True
        '
        'txtQuantityRejected
        '
        Me.txtQuantityRejected.Location = New System.Drawing.Point(134, 548)
        Me.txtQuantityRejected.Name = "txtQuantityRejected"
        Me.txtQuantityRejected.Size = New System.Drawing.Size(234, 21)
        Me.txtQuantityRejected.TabIndex = 32
        '
        'cboManufacturer
        '
        Me.cboManufacturer.FormattingEnabled = True
        Me.cboManufacturer.Location = New System.Drawing.Point(134, 97)
        Me.cboManufacturer.Name = "cboManufacturer"
        Me.cboManufacturer.Size = New System.Drawing.Size(234, 21)
        Me.cboManufacturer.TabIndex = 18
        '
        'cboWhereDiscovered
        '
        Me.cboWhereDiscovered.FormattingEnabled = True
        Me.cboWhereDiscovered.Items.AddRange(New Object() {"Aircraft Install-Mod", "Manufacturing", "Other", "Receiving"})
        Me.cboWhereDiscovered.Location = New System.Drawing.Point(134, 74)
        Me.cboWhereDiscovered.Name = "cboWhereDiscovered"
        Me.cboWhereDiscovered.Size = New System.Drawing.Size(234, 21)
        Me.cboWhereDiscovered.TabIndex = 17
        '
        'cboLocation
        '
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Location = New System.Drawing.Point(134, 51)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(234, 21)
        Me.cboLocation.TabIndex = 16
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Electrical", "Mechanical"})
        Me.cboType.Location = New System.Drawing.Point(134, 28)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(234, 21)
        Me.cboType.TabIndex = 15
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(10, 329)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(118, 13)
        Me.lblNotes.TabIndex = 12
        Me.lblNotes.Text = "Additional Action Notes"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 235)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Additional Actions"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(426, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Date Closed"
        '
        'lblStatusNotes
        '
        Me.lblStatusNotes.AutoSize = True
        Me.lblStatusNotes.Location = New System.Drawing.Point(10, 192)
        Me.lblStatusNotes.Name = "lblStatusNotes"
        Me.lblStatusNotes.Size = New System.Drawing.Size(89, 13)
        Me.lblStatusNotes.TabIndex = 9
        Me.lblStatusNotes.Text = "Disposition Notes"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Disposition Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Type of Error"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Reported By"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 551)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Quantity Rejected*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Manufacturer / Supplier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Where Discovered"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Location*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Type*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Status"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Label37)
        Me.XtraTabPage3.Controls.Add(Me.txtAircraftIdentifier)
        Me.XtraTabPage3.Controls.Add(Me.Label36)
        Me.XtraTabPage3.Controls.Add(Me.cboStep)
        Me.XtraTabPage3.Controls.Add(Me.btnSaveCreateTab)
        Me.XtraTabPage3.Controls.Add(Me.Label21)
        Me.XtraTabPage3.Controls.Add(Me.Label22)
        Me.XtraTabPage3.Controls.Add(Me.Label23)
        Me.XtraTabPage3.Controls.Add(Me.Label24)
        Me.XtraTabPage3.Controls.Add(Me.Label25)
        Me.XtraTabPage3.Controls.Add(Me.Label26)
        Me.XtraTabPage3.Controls.Add(Me.Label27)
        Me.XtraTabPage3.Controls.Add(Me.Label28)
        Me.XtraTabPage3.Controls.Add(Me.Label29)
        Me.XtraTabPage3.Controls.Add(Me.Label30)
        Me.XtraTabPage3.Controls.Add(Me.Label31)
        Me.XtraTabPage3.Controls.Add(Me.rtxtComments)
        Me.XtraTabPage3.Controls.Add(Me.rtxtDiscrepancy)
        Me.XtraTabPage3.Controls.Add(Me.txtPurchaseOrder)
        Me.XtraTabPage3.Controls.Add(Me.cboWorkOrder)
        Me.XtraTabPage3.Controls.Add(Me.txtPartDescription)
        Me.XtraTabPage3.Controls.Add(Me.txtPartNumber)
        Me.XtraTabPage3.Controls.Add(Me.cboRev)
        Me.XtraTabPage3.Controls.Add(Me.txtDrawingNum)
        Me.XtraTabPage3.Controls.Add(Me.cboSerialNumType)
        Me.XtraTabPage3.Controls.Add(Me.txtSerialNum)
        Me.XtraTabPage3.Controls.Add(Me.cboPrograms)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1465, 651)
        Me.XtraTabPage3.Text = "Discrepancy"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(3, 82)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(90, 13)
        Me.Label37.TabIndex = 102
        Me.Label37.Text = "Aircraft Identifier"
        '
        'txtAircraftIdentifier
        '
        Me.txtAircraftIdentifier.Location = New System.Drawing.Point(160, 79)
        Me.txtAircraftIdentifier.Name = "txtAircraftIdentifier"
        Me.txtAircraftIdentifier.Size = New System.Drawing.Size(288, 21)
        Me.txtAircraftIdentifier.TabIndex = 26
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(299, 166)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(11, 13)
        Me.Label36.TabIndex = 49
        Me.Label36.Text = "."
        '
        'cboStep
        '
        Me.cboStep.FormattingEnabled = True
        Me.cboStep.Items.AddRange(New Object() {"Unaffiliated"})
        Me.cboStep.Location = New System.Drawing.Point(316, 159)
        Me.cboStep.Name = "cboStep"
        Me.cboStep.Size = New System.Drawing.Size(132, 21)
        Me.cboStep.TabIndex = 32
        '
        'btnSaveCreateTab
        '
        Me.btnSaveCreateTab.Location = New System.Drawing.Point(160, 534)
        Me.btnSaveCreateTab.Name = "btnSaveCreateTab"
        Me.btnSaveCreateTab.Size = New System.Drawing.Size(169, 33)
        Me.btnSaveCreateTab.TabIndex = 47
        Me.btnSaveCreateTab.Text = "Save"
        Me.btnSaveCreateTab.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 402)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Comments"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(-3, 269)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(163, 13)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Description of Non-Conformance"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 189)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(122, 13)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Purchase Order Number"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 162)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 13)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Work Order . Step"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 241)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(83, 13)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Part Description"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(3, 215)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(67, 13)
        Me.Label26.TabIndex = 41
        Me.Label26.Text = "Part Number"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 135)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(86, 13)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "DrawingRevision"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(3, 109)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(86, 13)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "Drawing Number"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(998, 77)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(100, 13)
        Me.Label29.TabIndex = 38
        Me.Label29.Text = "Serial Number Type"
        Me.Label29.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(3, 55)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 13)
        Me.Label30.TabIndex = 37
        Me.Label30.Text = "Serial Number"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(3, 28)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(77, 13)
        Me.Label31.TabIndex = 36
        Me.Label31.Text = "Program Name"
        '
        'rtxtComments
        '
        Me.rtxtComments.Location = New System.Drawing.Point(160, 399)
        Me.rtxtComments.Name = "rtxtComments"
        Me.rtxtComments.Size = New System.Drawing.Size(891, 127)
        Me.rtxtComments.TabIndex = 35
        Me.rtxtComments.Text = ""
        '
        'rtxtDiscrepancy
        '
        Me.rtxtDiscrepancy.Location = New System.Drawing.Point(160, 266)
        Me.rtxtDiscrepancy.Name = "rtxtDiscrepancy"
        Me.rtxtDiscrepancy.Size = New System.Drawing.Size(891, 127)
        Me.rtxtDiscrepancy.TabIndex = 34
        Me.rtxtDiscrepancy.Text = ""
        '
        'txtPurchaseOrder
        '
        Me.txtPurchaseOrder.Location = New System.Drawing.Point(160, 186)
        Me.txtPurchaseOrder.Name = "txtPurchaseOrder"
        Me.txtPurchaseOrder.Size = New System.Drawing.Size(288, 21)
        Me.txtPurchaseOrder.TabIndex = 33
        '
        'cboWorkOrder
        '
        Me.cboWorkOrder.FormattingEnabled = True
        Me.cboWorkOrder.Items.AddRange(New Object() {"Unaffiliated"})
        Me.cboWorkOrder.Location = New System.Drawing.Point(160, 159)
        Me.cboWorkOrder.Name = "cboWorkOrder"
        Me.cboWorkOrder.Size = New System.Drawing.Size(133, 21)
        Me.cboWorkOrder.TabIndex = 31
        '
        'txtPartDescription
        '
        Me.txtPartDescription.Location = New System.Drawing.Point(160, 238)
        Me.txtPartDescription.Name = "txtPartDescription"
        Me.txtPartDescription.Size = New System.Drawing.Size(288, 21)
        Me.txtPartDescription.TabIndex = 30
        '
        'txtPartNumber
        '
        Me.txtPartNumber.Location = New System.Drawing.Point(160, 212)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.Size = New System.Drawing.Size(288, 21)
        Me.txtPartNumber.TabIndex = 29
        '
        'cboRev
        '
        Me.cboRev.FormattingEnabled = True
        Me.cboRev.Location = New System.Drawing.Point(160, 132)
        Me.cboRev.Name = "cboRev"
        Me.cboRev.Size = New System.Drawing.Size(288, 21)
        Me.cboRev.TabIndex = 28
        '
        'txtDrawingNum
        '
        Me.txtDrawingNum.Location = New System.Drawing.Point(160, 106)
        Me.txtDrawingNum.Name = "txtDrawingNum"
        Me.txtDrawingNum.Size = New System.Drawing.Size(288, 21)
        Me.txtDrawingNum.TabIndex = 27
        '
        'cboSerialNumType
        '
        Me.cboSerialNumType.FormattingEnabled = True
        Me.cboSerialNumType.Items.AddRange(New Object() {"Aircraft", "Detail"})
        Me.cboSerialNumType.Location = New System.Drawing.Point(1149, 74)
        Me.cboSerialNumType.Name = "cboSerialNumType"
        Me.cboSerialNumType.Size = New System.Drawing.Size(288, 21)
        Me.cboSerialNumType.TabIndex = 100
        Me.cboSerialNumType.Visible = False
        '
        'txtSerialNum
        '
        Me.txtSerialNum.Location = New System.Drawing.Point(160, 52)
        Me.txtSerialNum.Name = "txtSerialNum"
        Me.txtSerialNum.Size = New System.Drawing.Size(288, 21)
        Me.txtSerialNum.TabIndex = 25
        '
        'cboPrograms
        '
        Me.cboPrograms.FormattingEnabled = True
        Me.cboPrograms.Location = New System.Drawing.Point(160, 25)
        Me.cboPrograms.Name = "cboPrograms"
        Me.cboPrograms.Size = New System.Drawing.Size(288, 21)
        Me.cboPrograms.TabIndex = 24
        '
        'XtraTabPage
        '
        Me.XtraTabPage.Controls.Add(Me.lblResubmitSelectedRow)
        Me.XtraTabPage.Controls.Add(Me.rtxtResubmitSelectedRow)
        Me.XtraTabPage.Controls.Add(Me.btnSaveDisposition)
        Me.XtraTabPage.Controls.Add(Me.btnAbort)
        Me.XtraTabPage.Controls.Add(Me.btnAccept)
        Me.XtraTabPage.Controls.Add(Me.btnCloseNCR)
        Me.XtraTabPage.Controls.Add(Me.btnAddStep)
        Me.XtraTabPage.Controls.Add(Me.GroupBoxNotifications)
        Me.XtraTabPage.Controls.Add(Me.rtxtAddDisposition)
        Me.XtraTabPage.Controls.Add(Me.lblDisposition)
        Me.XtraTabPage.Controls.Add(Me.rtxtDisposition)
        Me.XtraTabPage.Controls.Add(Me.lblEnterDisposition)
        Me.XtraTabPage.Controls.Add(Me.btnDeleteSelectedRecord)
        Me.XtraTabPage.Controls.Add(Me.btnSaveAsEngineer)
        Me.XtraTabPage.Controls.Add(Me.btnSaveAsMRB)
        Me.XtraTabPage.Controls.Add(Me.btnSignOff)
        Me.XtraTabPage.Controls.Add(Me.GridControl3)
        Me.XtraTabPage.Controls.Add(Me.GridControl2)
        Me.XtraTabPage.Controls.Add(Me.txtStep)
        Me.XtraTabPage.Controls.Add(Me.txtRecordIDSignOff)
        Me.XtraTabPage.Controls.Add(Me.txtMRB)
        Me.XtraTabPage.Controls.Add(Me.txtEngineer)
        Me.XtraTabPage.Controls.Add(Me.txtIsSignedOff)
        Me.XtraTabPage.Controls.Add(Me.txtAcceptedStep)
        Me.XtraTabPage.Name = "XtraTabPage"
        Me.XtraTabPage.Size = New System.Drawing.Size(1465, 651)
        Me.XtraTabPage.Text = "Disposition"
        '
        'lblResubmitSelectedRow
        '
        Me.lblResubmitSelectedRow.AutoSize = True
        Me.lblResubmitSelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblResubmitSelectedRow.Location = New System.Drawing.Point(688, 3)
        Me.lblResubmitSelectedRow.Name = "lblResubmitSelectedRow"
        Me.lblResubmitSelectedRow.Size = New System.Drawing.Size(205, 13)
        Me.lblResubmitSelectedRow.TabIndex = 35
        Me.lblResubmitSelectedRow.Text = "Re-Submit Reason of Selected Row"
        '
        'rtxtResubmitSelectedRow
        '
        Me.rtxtResubmitSelectedRow.Location = New System.Drawing.Point(690, 19)
        Me.rtxtResubmitSelectedRow.Name = "rtxtResubmitSelectedRow"
        Me.rtxtResubmitSelectedRow.ReadOnly = True
        Me.rtxtResubmitSelectedRow.Size = New System.Drawing.Size(516, 63)
        Me.rtxtResubmitSelectedRow.TabIndex = 34
        Me.rtxtResubmitSelectedRow.Text = ""
        '
        'btnSaveDisposition
        '
        Me.btnSaveDisposition.Location = New System.Drawing.Point(-1, 405)
        Me.btnSaveDisposition.Name = "btnSaveDisposition"
        Me.btnSaveDisposition.Size = New System.Drawing.Size(126, 34)
        Me.btnSaveDisposition.TabIndex = 33
        Me.btnSaveDisposition.Text = "Save Disposition"
        Me.btnSaveDisposition.UseVisualStyleBackColor = True
        '
        'btnAbort
        '
        Me.btnAbort.Location = New System.Drawing.Point(691, 405)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(126, 34)
        Me.btnAbort.TabIndex = 1
        Me.btnAbort.Text = "Abort"
        Me.btnAbort.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(690, 621)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(145, 34)
        Me.btnAccept.TabIndex = 0
        Me.btnAccept.Text = "Set Selected Disposition State Sign Offs Completed"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnCloseNCR
        '
        Me.btnCloseNCR.Location = New System.Drawing.Point(859, 621)
        Me.btnCloseNCR.Name = "btnCloseNCR"
        Me.btnCloseNCR.Size = New System.Drawing.Size(126, 34)
        Me.btnCloseNCR.TabIndex = 5
        Me.btnCloseNCR.Text = "Close NCR"
        Me.btnCloseNCR.UseVisualStyleBackColor = True
        '
        'btnAddStep
        '
        Me.btnAddStep.Location = New System.Drawing.Point(691, 282)
        Me.btnAddStep.Name = "btnAddStep"
        Me.btnAddStep.Size = New System.Drawing.Size(126, 34)
        Me.btnAddStep.TabIndex = 6
        Me.btnAddStep.Text = "Re-Submit"
        Me.btnAddStep.UseVisualStyleBackColor = True
        '
        'GroupBoxNotifications
        '
        Me.GroupBoxNotifications.Controls.Add(Me.btnNotifyEngineers)
        Me.GroupBoxNotifications.Controls.Add(Me.btnNotifyMRBs)
        Me.GroupBoxNotifications.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxNotifications.Location = New System.Drawing.Point(1304, 472)
        Me.GroupBoxNotifications.Name = "GroupBoxNotifications"
        Me.GroupBoxNotifications.Size = New System.Drawing.Size(161, 110)
        Me.GroupBoxNotifications.TabIndex = 30
        Me.GroupBoxNotifications.TabStop = False
        Me.GroupBoxNotifications.Text = "NOT VISIBLE- Send Notifications"
        Me.GroupBoxNotifications.Visible = False
        '
        'btnNotifyEngineers
        '
        Me.btnNotifyEngineers.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnNotifyEngineers.Location = New System.Drawing.Point(6, 30)
        Me.btnNotifyEngineers.Name = "btnNotifyEngineers"
        Me.btnNotifyEngineers.Size = New System.Drawing.Size(163, 34)
        Me.btnNotifyEngineers.TabIndex = 26
        Me.btnNotifyEngineers.Text = "Send Notification to Engineers"
        Me.btnNotifyEngineers.UseVisualStyleBackColor = True
        '
        'btnNotifyMRBs
        '
        Me.btnNotifyMRBs.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnNotifyMRBs.Location = New System.Drawing.Point(6, 70)
        Me.btnNotifyMRBs.Name = "btnNotifyMRBs"
        Me.btnNotifyMRBs.Size = New System.Drawing.Size(163, 34)
        Me.btnNotifyMRBs.TabIndex = 27
        Me.btnNotifyMRBs.Text = "Send Notification to MRBs"
        Me.btnNotifyMRBs.UseVisualStyleBackColor = True
        '
        'rtxtAddDisposition
        '
        Me.rtxtAddDisposition.AccessibleDescription = ""
        Me.rtxtAddDisposition.AccessibleName = ""
        Me.rtxtAddDisposition.Location = New System.Drawing.Point(-1, 344)
        Me.rtxtAddDisposition.Name = "rtxtAddDisposition"
        Me.rtxtAddDisposition.Size = New System.Drawing.Size(667, 58)
        Me.rtxtAddDisposition.TabIndex = 25
        Me.rtxtAddDisposition.Tag = ""
        Me.rtxtAddDisposition.Text = ""
        '
        'lblDisposition
        '
        Me.lblDisposition.AutoSize = True
        Me.lblDisposition.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDisposition.Location = New System.Drawing.Point(1, 3)
        Me.lblDisposition.Name = "lblDisposition"
        Me.lblDisposition.Size = New System.Drawing.Size(162, 13)
        Me.lblDisposition.TabIndex = 24
        Me.lblDisposition.Text = "Disposition of Selected Row"
        '
        'rtxtDisposition
        '
        Me.rtxtDisposition.Location = New System.Drawing.Point(-1, 19)
        Me.rtxtDisposition.Name = "rtxtDisposition"
        Me.rtxtDisposition.ReadOnly = True
        Me.rtxtDisposition.Size = New System.Drawing.Size(667, 63)
        Me.rtxtDisposition.TabIndex = 23
        Me.rtxtDisposition.Text = ""
        '
        'lblEnterDisposition
        '
        Me.lblEnterDisposition.AutoSize = True
        Me.lblEnterDisposition.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEnterDisposition.Location = New System.Drawing.Point(-4, 331)
        Me.lblEnterDisposition.Name = "lblEnterDisposition"
        Me.lblEnterDisposition.Size = New System.Drawing.Size(131, 13)
        Me.lblEnterDisposition.TabIndex = 22
        Me.lblEnterDisposition.Text = "Enter Disposition Text"
        '
        'btnDeleteSelectedRecord
        '
        Me.btnDeleteSelectedRecord.Location = New System.Drawing.Point(1406, 588)
        Me.btnDeleteSelectedRecord.Name = "btnDeleteSelectedRecord"
        Me.btnDeleteSelectedRecord.Size = New System.Drawing.Size(59, 73)
        Me.btnDeleteSelectedRecord.TabIndex = 14
        Me.btnDeleteSelectedRecord.Text = "NOT VISIBLE - Delete Selected Record"
        Me.btnDeleteSelectedRecord.UseVisualStyleBackColor = True
        Me.btnDeleteSelectedRecord.Visible = False
        '
        'btnSaveAsEngineer
        '
        Me.btnSaveAsEngineer.Location = New System.Drawing.Point(1, 621)
        Me.btnSaveAsEngineer.Name = "btnSaveAsEngineer"
        Me.btnSaveAsEngineer.Size = New System.Drawing.Size(126, 34)
        Me.btnSaveAsEngineer.TabIndex = 12
        Me.btnSaveAsEngineer.Text = "Save as Engineer"
        Me.btnSaveAsEngineer.UseVisualStyleBackColor = True
        '
        'btnSaveAsMRB
        '
        Me.btnSaveAsMRB.Location = New System.Drawing.Point(133, 621)
        Me.btnSaveAsMRB.Name = "btnSaveAsMRB"
        Me.btnSaveAsMRB.Size = New System.Drawing.Size(126, 34)
        Me.btnSaveAsMRB.TabIndex = 10
        Me.btnSaveAsMRB.Text = "Save as MRB"
        Me.btnSaveAsMRB.UseVisualStyleBackColor = True
        '
        'btnSignOff
        '
        Me.btnSignOff.Location = New System.Drawing.Point(404, 621)
        Me.btnSignOff.Name = "btnSignOff"
        Me.btnSignOff.Size = New System.Drawing.Size(126, 34)
        Me.btnSignOff.TabIndex = 9
        Me.btnSignOff.Text = "Sign Off Selected Row"
        Me.btnSignOff.UseVisualStyleBackColor = True
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.bsEngineersMRBs
        Me.GridControl3.Location = New System.Drawing.Point(-1, 442)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2})
        Me.GridControl3.Size = New System.Drawing.Size(666, 179)
        Me.GridControl3.TabIndex = 8
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'bsEngineersMRBs
        '
        Me.bsEngineersMRBs.DataMember = "tblNCRStepsSignOff"
        Me.bsEngineersMRBs.DataSource = Me.DsEngineersMRBs1
        '
        'DsEngineersMRBs1
        '
        Me.DsEngineersMRBs1.DataSetName = "dsEngineersMRBs"
        Me.DsEngineersMRBs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID2, Me.colNCRNumber2, Me.colStatus2, Me.colStep2, Me.colLatestStep2, Me.colAcceptedStep2, Me.colActualStep2, Me.colSignOffUserEng, Me.colSignOffUserMRB, Me.colSignOffDt, Me.colAbortedReason2, Me.colProgram2, Me.colDrawingNumber2, Me.colDwgRevision2, Me.colOriginatorName2, Me.colSubmissionDt2, Me.colDateClosed2, Me.colNotes2, Me.colMRB2, Me.colEngineer2, Me.colChairperson1})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colRecordID2
        '
        Me.colRecordID2.FieldName = "RecordID"
        Me.colRecordID2.Name = "colRecordID2"
        '
        'colNCRNumber2
        '
        Me.colNCRNumber2.FieldName = "NCRNumber"
        Me.colNCRNumber2.Name = "colNCRNumber2"
        '
        'colStatus2
        '
        Me.colStatus2.FieldName = "Status"
        Me.colStatus2.Name = "colStatus2"
        '
        'colStep2
        '
        Me.colStep2.FieldName = "Step"
        Me.colStep2.Name = "colStep2"
        '
        'colLatestStep2
        '
        Me.colLatestStep2.FieldName = "LatestStep"
        Me.colLatestStep2.Name = "colLatestStep2"
        '
        'colAcceptedStep2
        '
        Me.colAcceptedStep2.FieldName = "AcceptedStep"
        Me.colAcceptedStep2.Name = "colAcceptedStep2"
        '
        'colActualStep2
        '
        Me.colActualStep2.FieldName = "ActualStep"
        Me.colActualStep2.Name = "colActualStep2"
        '
        'colSignOffUserEng
        '
        Me.colSignOffUserEng.Caption = "User Signed Off"
        Me.colSignOffUserEng.FieldName = "SignOffUserEng"
        Me.colSignOffUserEng.Name = "colSignOffUserEng"
        Me.colSignOffUserEng.OptionsColumn.ReadOnly = True
        Me.colSignOffUserEng.Visible = True
        Me.colSignOffUserEng.VisibleIndex = 1
        '
        'colSignOffUserMRB
        '
        Me.colSignOffUserMRB.Caption = "User Signed Off"
        Me.colSignOffUserMRB.FieldName = "SignOffUserMRB"
        Me.colSignOffUserMRB.Name = "colSignOffUserMRB"
        Me.colSignOffUserMRB.OptionsColumn.ReadOnly = True
        Me.colSignOffUserMRB.Visible = True
        Me.colSignOffUserMRB.VisibleIndex = 3
        '
        'colSignOffDt
        '
        Me.colSignOffDt.FieldName = "SignOffDt"
        Me.colSignOffDt.Name = "colSignOffDt"
        Me.colSignOffDt.OptionsColumn.ReadOnly = True
        Me.colSignOffDt.Visible = True
        Me.colSignOffDt.VisibleIndex = 4
        '
        'colAbortedReason2
        '
        Me.colAbortedReason2.FieldName = "AbortedReason"
        Me.colAbortedReason2.Name = "colAbortedReason2"
        '
        'colProgram2
        '
        Me.colProgram2.FieldName = "Program"
        Me.colProgram2.Name = "colProgram2"
        '
        'colDrawingNumber2
        '
        Me.colDrawingNumber2.FieldName = "DrawingNumber"
        Me.colDrawingNumber2.Name = "colDrawingNumber2"
        '
        'colDwgRevision2
        '
        Me.colDwgRevision2.FieldName = "DwgRevision"
        Me.colDwgRevision2.Name = "colDwgRevision2"
        '
        'colOriginatorName2
        '
        Me.colOriginatorName2.FieldName = "OriginatorName"
        Me.colOriginatorName2.Name = "colOriginatorName2"
        '
        'colSubmissionDt2
        '
        Me.colSubmissionDt2.FieldName = "SubmissionDt"
        Me.colSubmissionDt2.Name = "colSubmissionDt2"
        '
        'colDateClosed2
        '
        Me.colDateClosed2.FieldName = "DateClosed"
        Me.colDateClosed2.Name = "colDateClosed2"
        '
        'colNotes2
        '
        Me.colNotes2.FieldName = "Notes"
        Me.colNotes2.Name = "colNotes2"
        '
        'colMRB2
        '
        Me.colMRB2.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colMRB2.FieldName = "MRB"
        Me.colMRB2.Name = "colMRB2"
        Me.colMRB2.Visible = True
        Me.colMRB2.VisibleIndex = 2
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'colEngineer2
        '
        Me.colEngineer2.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colEngineer2.FieldName = "Engineer"
        Me.colEngineer2.Name = "colEngineer2"
        Me.colEngineer2.Visible = True
        Me.colEngineer2.VisibleIndex = 0
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'colChairperson1
        '
        Me.colChairperson1.FieldName = "Chairperson"
        Me.colChairperson1.Name = "colChairperson1"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.bsSteps
        Me.GridControl2.Location = New System.Drawing.Point(-1, 88)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(667, 228)
        Me.GridControl2.TabIndex = 7
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bsSteps
        '
        Me.bsSteps.DataMember = "tblNCRSteps"
        Me.bsSteps.DataSource = Me.DsStepsOfNCR1
        '
        'DsStepsOfNCR1
        '
        Me.DsStepsOfNCR1.DataSetName = "dsStepsOfNCR"
        Me.DsStepsOfNCR1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID1, Me.colNCRNumber1, Me.colStatus1, Me.colStep1, Me.colLatestStep1, Me.colAcceptedStep1, Me.colAbortedReason1, Me.colProgram1, Me.colDrawingNumber1, Me.colDwgRevision1, Me.colOriginatorName1, Me.colSubmissionDt1, Me.colDateClosed1, Me.colNotes1, Me.colMRB1, Me.colEngineer1, Me.colChairperson, Me.GridColumn1, Me.GridColumn5, Me.GridColumn6})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colRecordID1
        '
        Me.colRecordID1.FieldName = "RecordID"
        Me.colRecordID1.Name = "colRecordID1"
        Me.colRecordID1.Width = 164
        '
        'colNCRNumber1
        '
        Me.colNCRNumber1.FieldName = "NCRNumber"
        Me.colNCRNumber1.Name = "colNCRNumber1"
        '
        'colStatus1
        '
        Me.colStatus1.FieldName = "Status"
        Me.colStatus1.Name = "colStatus1"
        '
        'colStep1
        '
        Me.colStep1.FieldName = "Step"
        Me.colStep1.Name = "colStep1"
        Me.colStep1.Width = 55
        '
        'colLatestStep1
        '
        Me.colLatestStep1.FieldName = "LatestStep"
        Me.colLatestStep1.Name = "colLatestStep1"
        '
        'colAcceptedStep1
        '
        Me.colAcceptedStep1.AppearanceCell.Options.UseTextOptions = True
        Me.colAcceptedStep1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colAcceptedStep1.FieldName = "AcceptedStep"
        Me.colAcceptedStep1.Name = "colAcceptedStep1"
        Me.colAcceptedStep1.Width = 53
        '
        'colAbortedReason1
        '
        Me.colAbortedReason1.FieldName = "AbortedReason"
        Me.colAbortedReason1.Name = "colAbortedReason1"
        '
        'colProgram1
        '
        Me.colProgram1.FieldName = "Program"
        Me.colProgram1.Name = "colProgram1"
        '
        'colDrawingNumber1
        '
        Me.colDrawingNumber1.FieldName = "DrawingNumber"
        Me.colDrawingNumber1.Name = "colDrawingNumber1"
        '
        'colDwgRevision1
        '
        Me.colDwgRevision1.FieldName = "DwgRevision"
        Me.colDwgRevision1.Name = "colDwgRevision1"
        '
        'colOriginatorName1
        '
        Me.colOriginatorName1.FieldName = "OriginatorName"
        Me.colOriginatorName1.Name = "colOriginatorName1"
        '
        'colSubmissionDt1
        '
        Me.colSubmissionDt1.Caption = "Submission Dt"
        Me.colSubmissionDt1.FieldName = "SubmissionDt"
        Me.colSubmissionDt1.Name = "colSubmissionDt1"
        Me.colSubmissionDt1.Visible = True
        Me.colSubmissionDt1.VisibleIndex = 3
        Me.colSubmissionDt1.Width = 138
        '
        'colDateClosed1
        '
        Me.colDateClosed1.FieldName = "DateClosed"
        Me.colDateClosed1.Name = "colDateClosed1"
        Me.colDateClosed1.Visible = True
        Me.colDateClosed1.VisibleIndex = 4
        Me.colDateClosed1.Width = 166
        '
        'colNotes1
        '
        Me.colNotes1.FieldName = "Notes"
        Me.colNotes1.Name = "colNotes1"
        '
        'colMRB1
        '
        Me.colMRB1.FieldName = "MRB"
        Me.colMRB1.Name = "colMRB1"
        '
        'colEngineer1
        '
        Me.colEngineer1.FieldName = "Engineer"
        Me.colEngineer1.Name = "colEngineer1"
        '
        'colChairperson
        '
        Me.colChairperson.FieldName = "Chairperson"
        Me.colChairperson.Name = "colChairperson"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "OriginatorName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 214
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Disposition"
        Me.GridColumn5.FieldName = "ActualStep"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 60
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Accepted"
        Me.GridColumn6.FieldName = "IsStepAccepted"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 71
        '
        'txtStep
        '
        Me.txtStep.Location = New System.Drawing.Point(107, 118)
        Me.txtStep.Name = "txtStep"
        Me.txtStep.Size = New System.Drawing.Size(100, 21)
        Me.txtStep.TabIndex = 11
        '
        'txtRecordIDSignOff
        '
        Me.txtRecordIDSignOff.Location = New System.Drawing.Point(222, 542)
        Me.txtRecordIDSignOff.Name = "txtRecordIDSignOff"
        Me.txtRecordIDSignOff.Size = New System.Drawing.Size(100, 21)
        Me.txtRecordIDSignOff.TabIndex = 13
        '
        'txtMRB
        '
        Me.txtMRB.Location = New System.Drawing.Point(119, 498)
        Me.txtMRB.Name = "txtMRB"
        Me.txtMRB.Size = New System.Drawing.Size(100, 21)
        Me.txtMRB.TabIndex = 16
        '
        'txtEngineer
        '
        Me.txtEngineer.Location = New System.Drawing.Point(119, 471)
        Me.txtEngineer.Name = "txtEngineer"
        Me.txtEngineer.Size = New System.Drawing.Size(100, 21)
        Me.txtEngineer.TabIndex = 15
        '
        'txtIsSignedOff
        '
        Me.txtIsSignedOff.Location = New System.Drawing.Point(106, 445)
        Me.txtIsSignedOff.Name = "txtIsSignedOff"
        Me.txtIsSignedOff.Size = New System.Drawing.Size(100, 21)
        Me.txtIsSignedOff.TabIndex = 17
        '
        'txtAcceptedStep
        '
        Me.txtAcceptedStep.Location = New System.Drawing.Point(222, 344)
        Me.txtAcceptedStep.Name = "txtAcceptedStep"
        Me.txtAcceptedStep.Size = New System.Drawing.Size(100, 21)
        Me.txtAcceptedStep.TabIndex = 32
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.Label32)
        Me.XtraTabPage4.Controls.Add(Me.btnViewAll)
        Me.XtraTabPage4.Controls.Add(Me.btnSaveNew)
        Me.XtraTabPage4.Controls.Add(Me.btnFileAttachSubmit)
        Me.XtraTabPage4.Controls.Add(Me.btnBrowse)
        Me.XtraTabPage4.Controls.Add(Me.Label33)
        Me.XtraTabPage4.Controls.Add(Me.Label34)
        Me.XtraTabPage4.Controls.Add(Me.txtFilePath)
        Me.XtraTabPage4.Controls.Add(Me.txtFileDescription)
        Me.XtraTabPage4.Controls.Add(Me.btnDeleteAttachment)
        Me.XtraTabPage4.Controls.Add(Me.btnView)
        Me.XtraTabPage4.Controls.Add(Me.GridControl4)
        Me.XtraTabPage4.Controls.Add(Me.txtAttachRecordID)
        Me.XtraTabPage4.Controls.Add(Me.txtActualStepAttach)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1465, 651)
        Me.XtraTabPage4.Text = "Attachments"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label32.Location = New System.Drawing.Point(107, 501)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(488, 19)
        Me.Label32.TabIndex = 22
        Me.Label32.Text = "***Only jpeg images will be shown in the Print NCR report"
        '
        'btnViewAll
        '
        Me.btnViewAll.Location = New System.Drawing.Point(1193, 491)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(126, 33)
        Me.btnViewAll.TabIndex = 21
        Me.btnViewAll.Text = "View All Files"
        Me.btnViewAll.UseVisualStyleBackColor = True
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Location = New System.Drawing.Point(806, 569)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(101, 23)
        Me.btnSaveNew.TabIndex = 20
        Me.btnSaveNew.Text = "Save New"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        Me.btnSaveNew.Visible = False
        '
        'btnFileAttachSubmit
        '
        Me.btnFileAttachSubmit.Location = New System.Drawing.Point(691, 448)
        Me.btnFileAttachSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFileAttachSubmit.Name = "btnFileAttachSubmit"
        Me.btnFileAttachSubmit.Size = New System.Drawing.Size(101, 37)
        Me.btnFileAttachSubmit.TabIndex = 19
        Me.btnFileAttachSubmit.Text = "Submit New"
        Me.btnFileAttachSubmit.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(691, 569)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(101, 23)
        Me.btnBrowse.TabIndex = 18
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label33.Location = New System.Drawing.Point(25, 569)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(36, 13)
        Me.Label33.TabIndex = 17
        Me.Label33.Text = "Path:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label34.Location = New System.Drawing.Point(25, 523)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(74, 13)
        Me.Label34.TabIndex = 16
        Me.Label34.Text = "Description:"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(109, 569)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(577, 21)
        Me.txtFilePath.TabIndex = 15
        '
        'txtFileDescription
        '
        Me.txtFileDescription.Location = New System.Drawing.Point(110, 523)
        Me.txtFileDescription.Name = "txtFileDescription"
        Me.txtFileDescription.Size = New System.Drawing.Size(577, 21)
        Me.txtFileDescription.TabIndex = 14
        '
        'btnDeleteAttachment
        '
        Me.btnDeleteAttachment.Location = New System.Drawing.Point(1036, 448)
        Me.btnDeleteAttachment.Name = "btnDeleteAttachment"
        Me.btnDeleteAttachment.Size = New System.Drawing.Size(151, 37)
        Me.btnDeleteAttachment.TabIndex = 13
        Me.btnDeleteAttachment.Text = "Delete Selected Attachment"
        Me.btnDeleteAttachment.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(1193, 448)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(126, 37)
        Me.btnView.TabIndex = 12
        Me.btnView.Text = "View Selected File"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'GridControl4
        '
        Me.GridControl4.DataSource = Me.bsAttachments
        Me.GridControl4.Location = New System.Drawing.Point(3, 14)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(1316, 419)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'bsAttachments
        '
        Me.bsAttachments.DataMember = "tblNCRAttach"
        Me.bsAttachments.DataSource = Me.DsNCRAttachments1
        '
        'DsNCRAttachments1
        '
        Me.DsNCRAttachments1.DataSetName = "dsNCRAttachments"
        Me.DsNCRAttachments1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID3, Me.colNCRID, Me.colFilePath, Me.colFileDescription, Me.colImgField, Me.colFileName, Me.colFileExt, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.ReadOnly = True
        '
        'colRecordID3
        '
        Me.colRecordID3.FieldName = "RecordID"
        Me.colRecordID3.Name = "colRecordID3"
        '
        'colNCRID
        '
        Me.colNCRID.FieldName = "NCRID"
        Me.colNCRID.Name = "colNCRID"
        '
        'colFilePath
        '
        Me.colFilePath.FieldName = "FilePath"
        Me.colFilePath.Name = "colFilePath"
        Me.colFilePath.Visible = True
        Me.colFilePath.VisibleIndex = 1
        Me.colFilePath.Width = 388
        '
        'colFileDescription
        '
        Me.colFileDescription.FieldName = "FileDescription"
        Me.colFileDescription.Name = "colFileDescription"
        Me.colFileDescription.Visible = True
        Me.colFileDescription.VisibleIndex = 2
        Me.colFileDescription.Width = 297
        '
        'colImgField
        '
        Me.colImgField.FieldName = "ImgField"
        Me.colImgField.Name = "colImgField"
        Me.colImgField.Visible = True
        Me.colImgField.VisibleIndex = 3
        Me.colImgField.Width = 89
        '
        'colFileName
        '
        Me.colFileName.FieldName = "FileName"
        Me.colFileName.Name = "colFileName"
        Me.colFileName.Visible = True
        Me.colFileName.VisibleIndex = 4
        Me.colFileName.Width = 303
        '
        'colFileExt
        '
        Me.colFileExt.FieldName = "FileExt"
        Me.colFileExt.Name = "colFileExt"
        Me.colFileExt.Visible = True
        Me.colFileExt.VisibleIndex = 5
        Me.colFileExt.Width = 60
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Step"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Width = 72
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Disposition"
        Me.GridColumn3.FieldName = "ActualStep"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 89
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "DateAdded"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 6
        '
        'txtAttachRecordID
        '
        Me.txtAttachRecordID.Location = New System.Drawing.Point(385, 168)
        Me.txtAttachRecordID.Name = "txtAttachRecordID"
        Me.txtAttachRecordID.Size = New System.Drawing.Size(100, 21)
        Me.txtAttachRecordID.TabIndex = 1
        '
        'txtActualStepAttach
        '
        Me.txtActualStepAttach.Location = New System.Drawing.Point(350, 154)
        Me.txtActualStepAttach.Name = "txtActualStepAttach"
        Me.txtActualStepAttach.Size = New System.Drawing.Size(100, 21)
        Me.txtActualStepAttach.TabIndex = 23
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=NCR;Persist Security Info=True;Us" &
    "er ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NCRNumber", System.Data.SqlDbType.Int, 0, "NCRNumber"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@Step", System.Data.SqlDbType.NVarChar, 0, "Step"), New System.Data.SqlClient.SqlParameter("@LatestStep", System.Data.SqlDbType.Int, 0, "LatestStep"), New System.Data.SqlClient.SqlParameter("@AcceptedStep", System.Data.SqlDbType.Int, 0, "AcceptedStep"), New System.Data.SqlClient.SqlParameter("@ActualStep", System.Data.SqlDbType.Int, 0, "ActualStep"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@AbortedReason", System.Data.SqlDbType.NVarChar, 0, "AbortedReason"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@SerialNum", System.Data.SqlDbType.NVarChar, 0, "SerialNum"), New System.Data.SqlClient.SqlParameter("@SerialNumType", System.Data.SqlDbType.NVarChar, 0, "SerialNumType"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@PartNumber", System.Data.SqlDbType.NVarChar, 0, "PartNumber"), New System.Data.SqlClient.SqlParameter("@PartDescription", System.Data.SqlDbType.NVarChar, 0, "PartDescription"), New System.Data.SqlClient.SqlParameter("@WorkOrderStep", System.Data.SqlDbType.NVarChar, 0, "WorkOrderStep"), New System.Data.SqlClient.SqlParameter("@PurchaseOrderNum", System.Data.SqlDbType.NVarChar, 0, "PurchaseOrderNum"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@SubmissionDt", System.Data.SqlDbType.[Date], 0, "SubmissionDt"), New System.Data.SqlClient.SqlParameter("@Discrepancy", System.Data.SqlDbType.NVarChar, 0, "Discrepancy"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@GraphicName", System.Data.SqlDbType.NVarChar, 0, "GraphicName"), New System.Data.SqlClient.SqlParameter("@Graphics", System.Data.SqlDbType.Image, 0, "Graphics"), New System.Data.SqlClient.SqlParameter("@WhereDiscovered", System.Data.SqlDbType.NVarChar, 0, "WhereDiscovered"), New System.Data.SqlClient.SqlParameter("@Manufacturer", System.Data.SqlDbType.NVarChar, 0, "Manufacturer"), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.NVarChar, 0, "Quantity"), New System.Data.SqlClient.SqlParameter("@ReportedBy", System.Data.SqlDbType.NVarChar, 0, "ReportedBy"), New System.Data.SqlClient.SqlParameter("@TypeOfError", System.Data.SqlDbType.NVarChar, 0, "TypeOfError"), New System.Data.SqlClient.SqlParameter("@DispositionType", System.Data.SqlDbType.NVarChar, 0, "DispositionType"), New System.Data.SqlClient.SqlParameter("@StatusNotes", System.Data.SqlDbType.NVarChar, 0, "StatusNotes"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.[Date], 0, "DateClosed"), New System.Data.SqlClient.SqlParameter("@AdditionalActions", System.Data.SqlDbType.NVarChar, 0, "AdditionalActions"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@CostIsSignificant", System.Data.SqlDbType.NVarChar, 0, "CostIsSignificant"), New System.Data.SqlClient.SqlParameter("@MRB", System.Data.SqlDbType.NVarChar, 0, "MRB"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@None", System.Data.SqlDbType.Bit, 0, "None"), New System.Data.SqlClient.SqlParameter("@NotifyCustomer", System.Data.SqlDbType.Bit, 0, "NotifyCustomer"), New System.Data.SqlClient.SqlParameter("@WriteCAR", System.Data.SqlDbType.Bit, 0, "WriteCAR"), New System.Data.SqlClient.SqlParameter("@WriteSCAR", System.Data.SqlDbType.Bit, 0, "WriteSCAR"), New System.Data.SqlClient.SqlParameter("@WriteCPAR", System.Data.SqlDbType.Bit, 0, "WriteCPAR"), New System.Data.SqlClient.SqlParameter("@Other", System.Data.SqlDbType.Bit, 0, "Other"), New System.Data.SqlClient.SqlParameter("@WorkOrder", System.Data.SqlDbType.NVarChar, 0, "WorkOrder"), New System.Data.SqlClient.SqlParameter("@StepWorkOrder", System.Data.SqlDbType.NVarChar, 0, "StepWorkOrder"), New System.Data.SqlClient.SqlParameter("@QuantityRejected", System.Data.SqlDbType.NVarChar, 0, "QuantityRejected"), New System.Data.SqlClient.SqlParameter("@AircraftIdentifier", System.Data.SqlDbType.NVarChar, 0, "AircraftIdentifier"), New System.Data.SqlClient.SqlParameter("@ResponsibleDept", System.Data.SqlDbType.NVarChar, 0, "ResponsibleDept"), New System.Data.SqlClient.SqlParameter("@ResponsiblePerson", System.Data.SqlDbType.NVarChar, 0, "ResponsiblePerson"), New System.Data.SqlClient.SqlParameter("@Cause", System.Data.SqlDbType.NVarChar, 0, "Cause"), New System.Data.SqlClient.SqlParameter("@Cost", System.Data.SqlDbType.NVarChar, 0, "Cost"), New System.Data.SqlClient.SqlParameter("@CustomerNCRNum", System.Data.SqlDbType.NVarChar, 0, "CustomerNCRNum"), New System.Data.SqlClient.SqlParameter("@MaterialReturnAuthNum", System.Data.SqlDbType.NVarChar, 0, "MaterialReturnAuthNum"), New System.Data.SqlClient.SqlParameter("@SalesOrderNum", System.Data.SqlDbType.NVarChar, 0, "SalesOrderNum"), New System.Data.SqlClient.SqlParameter("@ReturnDate", System.Data.SqlDbType.[Date], 0, "ReturnDate"), New System.Data.SqlClient.SqlParameter("@TotalQuantity", System.Data.SqlDbType.NVarChar, 0, "TotalQuantity"), New System.Data.SqlClient.SqlParameter("@SupplierPurchaseOrderNum", System.Data.SqlDbType.NVarChar, 0, "SupplierPurchaseOrderNum")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NCRNumber", System.Data.SqlDbType.Int, 0, "NCRNumber"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@Step", System.Data.SqlDbType.NVarChar, 0, "Step"), New System.Data.SqlClient.SqlParameter("@LatestStep", System.Data.SqlDbType.Int, 0, "LatestStep"), New System.Data.SqlClient.SqlParameter("@AcceptedStep", System.Data.SqlDbType.Int, 0, "AcceptedStep"), New System.Data.SqlClient.SqlParameter("@ActualStep", System.Data.SqlDbType.Int, 0, "ActualStep"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@AbortedReason", System.Data.SqlDbType.NVarChar, 0, "AbortedReason"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@SerialNum", System.Data.SqlDbType.NVarChar, 0, "SerialNum"), New System.Data.SqlClient.SqlParameter("@SerialNumType", System.Data.SqlDbType.NVarChar, 0, "SerialNumType"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@PartNumber", System.Data.SqlDbType.NVarChar, 0, "PartNumber"), New System.Data.SqlClient.SqlParameter("@PartDescription", System.Data.SqlDbType.NVarChar, 0, "PartDescription"), New System.Data.SqlClient.SqlParameter("@WorkOrderStep", System.Data.SqlDbType.NVarChar, 0, "WorkOrderStep"), New System.Data.SqlClient.SqlParameter("@PurchaseOrderNum", System.Data.SqlDbType.NVarChar, 0, "PurchaseOrderNum"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@SubmissionDt", System.Data.SqlDbType.[Date], 0, "SubmissionDt"), New System.Data.SqlClient.SqlParameter("@Discrepancy", System.Data.SqlDbType.NVarChar, 0, "Discrepancy"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@GraphicName", System.Data.SqlDbType.NVarChar, 0, "GraphicName"), New System.Data.SqlClient.SqlParameter("@Graphics", System.Data.SqlDbType.Image, 0, "Graphics"), New System.Data.SqlClient.SqlParameter("@WhereDiscovered", System.Data.SqlDbType.NVarChar, 0, "WhereDiscovered"), New System.Data.SqlClient.SqlParameter("@Manufacturer", System.Data.SqlDbType.NVarChar, 0, "Manufacturer"), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.NVarChar, 0, "Quantity"), New System.Data.SqlClient.SqlParameter("@ReportedBy", System.Data.SqlDbType.NVarChar, 0, "ReportedBy"), New System.Data.SqlClient.SqlParameter("@TypeOfError", System.Data.SqlDbType.NVarChar, 0, "TypeOfError"), New System.Data.SqlClient.SqlParameter("@DispositionType", System.Data.SqlDbType.NVarChar, 0, "DispositionType"), New System.Data.SqlClient.SqlParameter("@StatusNotes", System.Data.SqlDbType.NVarChar, 0, "StatusNotes"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.[Date], 0, "DateClosed"), New System.Data.SqlClient.SqlParameter("@AdditionalActions", System.Data.SqlDbType.NVarChar, 0, "AdditionalActions"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@CostIsSignificant", System.Data.SqlDbType.NVarChar, 0, "CostIsSignificant"), New System.Data.SqlClient.SqlParameter("@MRB", System.Data.SqlDbType.NVarChar, 0, "MRB"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@None", System.Data.SqlDbType.Bit, 0, "None"), New System.Data.SqlClient.SqlParameter("@NotifyCustomer", System.Data.SqlDbType.Bit, 0, "NotifyCustomer"), New System.Data.SqlClient.SqlParameter("@WriteCAR", System.Data.SqlDbType.Bit, 0, "WriteCAR"), New System.Data.SqlClient.SqlParameter("@WriteSCAR", System.Data.SqlDbType.Bit, 0, "WriteSCAR"), New System.Data.SqlClient.SqlParameter("@WriteCPAR", System.Data.SqlDbType.Bit, 0, "WriteCPAR"), New System.Data.SqlClient.SqlParameter("@Other", System.Data.SqlDbType.Bit, 0, "Other"), New System.Data.SqlClient.SqlParameter("@WorkOrder", System.Data.SqlDbType.NVarChar, 0, "WorkOrder"), New System.Data.SqlClient.SqlParameter("@StepWorkOrder", System.Data.SqlDbType.NVarChar, 0, "StepWorkOrder"), New System.Data.SqlClient.SqlParameter("@QuantityRejected", System.Data.SqlDbType.NVarChar, 0, "QuantityRejected"), New System.Data.SqlClient.SqlParameter("@AircraftIdentifier", System.Data.SqlDbType.NVarChar, 0, "AircraftIdentifier"), New System.Data.SqlClient.SqlParameter("@ResponsibleDept", System.Data.SqlDbType.NVarChar, 0, "ResponsibleDept"), New System.Data.SqlClient.SqlParameter("@ResponsiblePerson", System.Data.SqlDbType.NVarChar, 0, "ResponsiblePerson"), New System.Data.SqlClient.SqlParameter("@Cause", System.Data.SqlDbType.NVarChar, 0, "Cause"), New System.Data.SqlClient.SqlParameter("@Cost", System.Data.SqlDbType.NVarChar, 0, "Cost"), New System.Data.SqlClient.SqlParameter("@CustomerNCRNum", System.Data.SqlDbType.NVarChar, 0, "CustomerNCRNum"), New System.Data.SqlClient.SqlParameter("@MaterialReturnAuthNum", System.Data.SqlDbType.NVarChar, 0, "MaterialReturnAuthNum"), New System.Data.SqlClient.SqlParameter("@SalesOrderNum", System.Data.SqlDbType.NVarChar, 0, "SalesOrderNum"), New System.Data.SqlClient.SqlParameter("@ReturnDate", System.Data.SqlDbType.[Date], 0, "ReturnDate"), New System.Data.SqlClient.SqlParameter("@TotalQuantity", System.Data.SqlDbType.NVarChar, 0, "TotalQuantity"), New System.Data.SqlClient.SqlParameter("@SupplierPurchaseOrderNum", System.Data.SqlDbType.NVarChar, 0, "SupplierPurchaseOrderNum"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Step", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Step", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AbortedReason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AbortedReason", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNumType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNumType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNumType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PartNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PartNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PartNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PartDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PartDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PartDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WorkOrderStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WorkOrderStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WorkOrderStep", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WorkOrderStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PurchaseOrderNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PurchaseOrderNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PurchaseOrderNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchaseOrderNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SubmissionDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SubmissionDt", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Discrepancy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Discrepancy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Discrepancy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Discrepancy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_GraphicName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GraphicName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_GraphicName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GraphicName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WhereDiscovered", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WhereDiscovered", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WhereDiscovered", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WhereDiscovered", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Manufacturer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Manufacturer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Manufacturer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manufacturer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Quantity", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReportedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReportedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReportedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportedBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TypeOfError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TypeOfError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TypeOfError", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TypeOfError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DispositionType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DispositionType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DispositionType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DispositionType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StatusNotes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StatusNotes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StatusNotes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StatusNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateClosed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AdditionalActions", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AdditionalActions", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AdditionalActions", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AdditionalActions", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CostIsSignificant", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CostIsSignificant", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CostIsSignificant", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostIsSignificant", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MRB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MRB", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_None", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "None", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_None", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "None", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NotifyCustomer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NotifyCustomer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NotifyCustomer", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NotifyCustomer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WriteCAR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WriteCAR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WriteCAR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WriteCAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WriteSCAR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WriteSCAR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WriteSCAR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WriteSCAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WriteCPAR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WriteCPAR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WriteCPAR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WriteCPAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Other", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Other", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Other", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Other", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WorkOrder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WorkOrder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StepWorkOrder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StepWorkOrder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StepWorkOrder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StepWorkOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QuantityRejected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QuantityRejected", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QuantityRejected", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QuantityRejected", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AircraftIdentifier", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AircraftIdentifier", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AircraftIdentifier", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AircraftIdentifier", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResponsibleDept", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResponsibleDept", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResponsibleDept", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResponsibleDept", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResponsiblePerson", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResponsiblePerson", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResponsiblePerson", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResponsiblePerson", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Cause", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cause", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Cause", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cause", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Cost", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Cost", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CustomerNCRNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CustomerNCRNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CustomerNCRNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerNCRNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MaterialReturnAuthNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaterialReturnAuthNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MaterialReturnAuthNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaterialReturnAuthNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SalesOrderNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SalesOrderNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SalesOrderNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalesOrderNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReturnDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReturnDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReturnDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReturnDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TotalQuantity", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TotalQuantity", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TotalQuantity", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalQuantity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SupplierPurchaseOrderNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SupplierPurchaseOrderNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SupplierPurchaseOrderNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SupplierPurchaseOrderNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Step", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Step", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AbortedReason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AbortedReason", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNumType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNumType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNumType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PartNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PartNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PartNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PartDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PartDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PartDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WorkOrderStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WorkOrderStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WorkOrderStep", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WorkOrderStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PurchaseOrderNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PurchaseOrderNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PurchaseOrderNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchaseOrderNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SubmissionDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SubmissionDt", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Discrepancy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Discrepancy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Discrepancy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Discrepancy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_GraphicName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GraphicName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_GraphicName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GraphicName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WhereDiscovered", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WhereDiscovered", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WhereDiscovered", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WhereDiscovered", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Manufacturer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Manufacturer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Manufacturer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manufacturer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Quantity", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReportedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReportedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReportedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportedBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TypeOfError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TypeOfError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TypeOfError", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TypeOfError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DispositionType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DispositionType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DispositionType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DispositionType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StatusNotes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StatusNotes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StatusNotes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StatusNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateClosed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AdditionalActions", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AdditionalActions", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AdditionalActions", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AdditionalActions", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CostIsSignificant", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CostIsSignificant", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CostIsSignificant", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostIsSignificant", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MRB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MRB", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_None", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "None", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_None", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "None", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NotifyCustomer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NotifyCustomer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NotifyCustomer", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NotifyCustomer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WriteCAR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WriteCAR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WriteCAR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WriteCAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WriteSCAR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WriteSCAR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WriteSCAR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WriteSCAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WriteCPAR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WriteCPAR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WriteCPAR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WriteCPAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Other", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Other", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Other", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Other", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WorkOrder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WorkOrder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StepWorkOrder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StepWorkOrder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StepWorkOrder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StepWorkOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QuantityRejected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QuantityRejected", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QuantityRejected", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QuantityRejected", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AircraftIdentifier", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AircraftIdentifier", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AircraftIdentifier", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AircraftIdentifier", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResponsibleDept", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResponsibleDept", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResponsibleDept", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResponsibleDept", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResponsiblePerson", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResponsiblePerson", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResponsiblePerson", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResponsiblePerson", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Cause", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cause", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Cause", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cause", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Cost", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Cost", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CustomerNCRNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CustomerNCRNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CustomerNCRNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerNCRNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MaterialReturnAuthNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaterialReturnAuthNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MaterialReturnAuthNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaterialReturnAuthNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SalesOrderNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SalesOrderNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SalesOrderNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalesOrderNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReturnDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReturnDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReturnDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReturnDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TotalQuantity", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TotalQuantity", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TotalQuantity", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalQuantity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SupplierPurchaseOrderNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SupplierPurchaseOrderNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SupplierPurchaseOrderNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SupplierPurchaseOrderNum", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daNCR
        '
        Me.daNCR.DeleteCommand = Me.SqlDeleteCommand1
        Me.daNCR.InsertCommand = Me.SqlInsertCommand1
        Me.daNCR.SelectCommand = Me.SqlSelectCommand1
        Me.daNCR.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblNCR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("NCRNumber", "NCRNumber"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("Step", "Step"), New System.Data.Common.DataColumnMapping("LatestStep", "LatestStep"), New System.Data.Common.DataColumnMapping("AcceptedStep", "AcceptedStep"), New System.Data.Common.DataColumnMapping("ActualStep", "ActualStep"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("AbortedReason", "AbortedReason"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("SerialNum", "SerialNum"), New System.Data.Common.DataColumnMapping("SerialNumType", "SerialNumType"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("PartNumber", "PartNumber"), New System.Data.Common.DataColumnMapping("PartDescription", "PartDescription"), New System.Data.Common.DataColumnMapping("WorkOrderStep", "WorkOrderStep"), New System.Data.Common.DataColumnMapping("PurchaseOrderNum", "PurchaseOrderNum"), New System.Data.Common.DataColumnMapping("OriginatorName", "OriginatorName"), New System.Data.Common.DataColumnMapping("SubmissionDt", "SubmissionDt"), New System.Data.Common.DataColumnMapping("Discrepancy", "Discrepancy"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("GraphicName", "GraphicName"), New System.Data.Common.DataColumnMapping("Graphics", "Graphics"), New System.Data.Common.DataColumnMapping("WhereDiscovered", "WhereDiscovered"), New System.Data.Common.DataColumnMapping("Manufacturer", "Manufacturer"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("ReportedBy", "ReportedBy"), New System.Data.Common.DataColumnMapping("TypeOfError", "TypeOfError"), New System.Data.Common.DataColumnMapping("DispositionType", "DispositionType"), New System.Data.Common.DataColumnMapping("StatusNotes", "StatusNotes"), New System.Data.Common.DataColumnMapping("DateClosed", "DateClosed"), New System.Data.Common.DataColumnMapping("AdditionalActions", "AdditionalActions"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("CostIsSignificant", "CostIsSignificant"), New System.Data.Common.DataColumnMapping("MRB", "MRB"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("None", "None"), New System.Data.Common.DataColumnMapping("NotifyCustomer", "NotifyCustomer"), New System.Data.Common.DataColumnMapping("WriteCAR", "WriteCAR"), New System.Data.Common.DataColumnMapping("WriteSCAR", "WriteSCAR"), New System.Data.Common.DataColumnMapping("WriteCPAR", "WriteCPAR"), New System.Data.Common.DataColumnMapping("Other", "Other"), New System.Data.Common.DataColumnMapping("WorkOrder", "WorkOrder"), New System.Data.Common.DataColumnMapping("StepWorkOrder", "StepWorkOrder"), New System.Data.Common.DataColumnMapping("QuantityRejected", "QuantityRejected"), New System.Data.Common.DataColumnMapping("AircraftIdentifier", "AircraftIdentifier"), New System.Data.Common.DataColumnMapping("ResponsibleDept", "ResponsibleDept"), New System.Data.Common.DataColumnMapping("ResponsiblePerson", "ResponsiblePerson"), New System.Data.Common.DataColumnMapping("Cause", "Cause"), New System.Data.Common.DataColumnMapping("Cost", "Cost"), New System.Data.Common.DataColumnMapping("CustomerNCRNum", "CustomerNCRNum"), New System.Data.Common.DataColumnMapping("MaterialReturnAuthNum", "MaterialReturnAuthNum"), New System.Data.Common.DataColumnMapping("SalesOrderNum", "SalesOrderNum"), New System.Data.Common.DataColumnMapping("ReturnDate", "ReturnDate"), New System.Data.Common.DataColumnMapping("TotalQuantity", "TotalQuantity"), New System.Data.Common.DataColumnMapping("SupplierPurchaseOrderNum", "SupplierPurchaseOrderNum")})})
        Me.daNCR.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NCRNumber", System.Data.SqlDbType.Int, 0, "NCRNumber"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@Step", System.Data.SqlDbType.NVarChar, 0, "Step"), New System.Data.SqlClient.SqlParameter("@LatestStep", System.Data.SqlDbType.Int, 0, "LatestStep"), New System.Data.SqlClient.SqlParameter("@AcceptedStep", System.Data.SqlDbType.Int, 0, "AcceptedStep"), New System.Data.SqlClient.SqlParameter("@ActualStep", System.Data.SqlDbType.Int, 0, "ActualStep"), New System.Data.SqlClient.SqlParameter("@AbortedReason", System.Data.SqlDbType.NVarChar, 0, "AbortedReason"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@SubmissionDt", System.Data.SqlDbType.NVarChar, 0, "SubmissionDt"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.NVarChar, 0, "DateClosed"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@MRB", System.Data.SqlDbType.NVarChar, 0, "MRB"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@Chairperson", System.Data.SqlDbType.NVarChar, 0, "Chairperson"), New System.Data.SqlClient.SqlParameter("@Disposition", System.Data.SqlDbType.NVarChar, 0, "Disposition"), New System.Data.SqlClient.SqlParameter("@ResubmittedReason", System.Data.SqlDbType.NVarChar, 0, "ResubmittedReason"), New System.Data.SqlClient.SqlParameter("@ResubmittedBy", System.Data.SqlDbType.NVarChar, 0, "ResubmittedBy"), New System.Data.SqlClient.SqlParameter("@ResubmittedDt", System.Data.SqlDbType.NVarChar, 0, "ResubmittedDt"), New System.Data.SqlClient.SqlParameter("@IsStepAccepted", System.Data.SqlDbType.NVarChar, 0, "IsStepAccepted")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NCRNumber", System.Data.SqlDbType.Int, 0, "NCRNumber"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@Step", System.Data.SqlDbType.NVarChar, 0, "Step"), New System.Data.SqlClient.SqlParameter("@LatestStep", System.Data.SqlDbType.Int, 0, "LatestStep"), New System.Data.SqlClient.SqlParameter("@AcceptedStep", System.Data.SqlDbType.Int, 0, "AcceptedStep"), New System.Data.SqlClient.SqlParameter("@ActualStep", System.Data.SqlDbType.Int, 0, "ActualStep"), New System.Data.SqlClient.SqlParameter("@AbortedReason", System.Data.SqlDbType.NVarChar, 0, "AbortedReason"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@SubmissionDt", System.Data.SqlDbType.NVarChar, 0, "SubmissionDt"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.NVarChar, 0, "DateClosed"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@MRB", System.Data.SqlDbType.NVarChar, 0, "MRB"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@Chairperson", System.Data.SqlDbType.NVarChar, 0, "Chairperson"), New System.Data.SqlClient.SqlParameter("@Disposition", System.Data.SqlDbType.NVarChar, 0, "Disposition"), New System.Data.SqlClient.SqlParameter("@ResubmittedReason", System.Data.SqlDbType.NVarChar, 0, "ResubmittedReason"), New System.Data.SqlClient.SqlParameter("@ResubmittedBy", System.Data.SqlDbType.NVarChar, 0, "ResubmittedBy"), New System.Data.SqlClient.SqlParameter("@ResubmittedDt", System.Data.SqlDbType.NVarChar, 0, "ResubmittedDt"), New System.Data.SqlClient.SqlParameter("@IsStepAccepted", System.Data.SqlDbType.NVarChar, 0, "IsStepAccepted"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Step", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Step", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AbortedReason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AbortedReason", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SubmissionDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SubmissionDt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateClosed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MRB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MRB", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Chairperson", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Chairperson", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Chairperson", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Chairperson", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Disposition", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Disposition", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Disposition", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Disposition", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResubmittedReason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResubmittedReason", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResubmittedReason", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResubmittedReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResubmittedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResubmittedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResubmittedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResubmittedBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResubmittedDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResubmittedDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResubmittedDt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResubmittedDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IsStepAccepted", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IsStepAccepted", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IsStepAccepted", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IsStepAccepted", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Step", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Step", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AbortedReason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AbortedReason", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SubmissionDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SubmissionDt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateClosed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MRB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MRB", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Chairperson", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Chairperson", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Chairperson", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Chairperson", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Disposition", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Disposition", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Disposition", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Disposition", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResubmittedReason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResubmittedReason", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResubmittedReason", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResubmittedReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResubmittedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResubmittedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResubmittedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResubmittedBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResubmittedDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResubmittedDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResubmittedDt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResubmittedDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IsStepAccepted", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IsStepAccepted", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IsStepAccepted", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IsStepAccepted", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daSteps
        '
        Me.daSteps.DeleteCommand = Me.SqlDeleteCommand2
        Me.daSteps.InsertCommand = Me.SqlInsertCommand2
        Me.daSteps.SelectCommand = Me.SqlSelectCommand2
        Me.daSteps.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblNCRSteps", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("NCRNumber", "NCRNumber"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("Step", "Step"), New System.Data.Common.DataColumnMapping("LatestStep", "LatestStep"), New System.Data.Common.DataColumnMapping("AcceptedStep", "AcceptedStep"), New System.Data.Common.DataColumnMapping("ActualStep", "ActualStep"), New System.Data.Common.DataColumnMapping("AbortedReason", "AbortedReason"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("OriginatorName", "OriginatorName"), New System.Data.Common.DataColumnMapping("SubmissionDt", "SubmissionDt"), New System.Data.Common.DataColumnMapping("DateClosed", "DateClosed"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("MRB", "MRB"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("Chairperson", "Chairperson"), New System.Data.Common.DataColumnMapping("Disposition", "Disposition"), New System.Data.Common.DataColumnMapping("ResubmittedReason", "ResubmittedReason"), New System.Data.Common.DataColumnMapping("ResubmittedBy", "ResubmittedBy"), New System.Data.Common.DataColumnMapping("ResubmittedDt", "ResubmittedDt"), New System.Data.Common.DataColumnMapping("IsStepAccepted", "IsStepAccepted")})})
        Me.daSteps.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT        tblNCRStepsSignOff.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblNCRStepsSignOff"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NCRNumber", System.Data.SqlDbType.Int, 0, "NCRNumber"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@Step", System.Data.SqlDbType.NVarChar, 0, "Step"), New System.Data.SqlClient.SqlParameter("@LatestStep", System.Data.SqlDbType.Int, 0, "LatestStep"), New System.Data.SqlClient.SqlParameter("@AcceptedStep", System.Data.SqlDbType.Int, 0, "AcceptedStep"), New System.Data.SqlClient.SqlParameter("@ActualStep", System.Data.SqlDbType.Int, 0, "ActualStep"), New System.Data.SqlClient.SqlParameter("@SignOffUserEng", System.Data.SqlDbType.NVarChar, 0, "SignOffUserEng"), New System.Data.SqlClient.SqlParameter("@SignOffUserMRB", System.Data.SqlDbType.NVarChar, 0, "SignOffUserMRB"), New System.Data.SqlClient.SqlParameter("@SignOffDt", System.Data.SqlDbType.NVarChar, 0, "SignOffDt"), New System.Data.SqlClient.SqlParameter("@AbortedReason", System.Data.SqlDbType.NVarChar, 0, "AbortedReason"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@SubmissionDt", System.Data.SqlDbType.[Date], 0, "SubmissionDt"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.[Date], 0, "DateClosed"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@MRB", System.Data.SqlDbType.NVarChar, 0, "MRB"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@Chairperson", System.Data.SqlDbType.NVarChar, 0, "Chairperson")})
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NCRNumber", System.Data.SqlDbType.Int, 0, "NCRNumber"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@Step", System.Data.SqlDbType.NVarChar, 0, "Step"), New System.Data.SqlClient.SqlParameter("@LatestStep", System.Data.SqlDbType.Int, 0, "LatestStep"), New System.Data.SqlClient.SqlParameter("@AcceptedStep", System.Data.SqlDbType.Int, 0, "AcceptedStep"), New System.Data.SqlClient.SqlParameter("@ActualStep", System.Data.SqlDbType.Int, 0, "ActualStep"), New System.Data.SqlClient.SqlParameter("@SignOffUserEng", System.Data.SqlDbType.NVarChar, 0, "SignOffUserEng"), New System.Data.SqlClient.SqlParameter("@SignOffUserMRB", System.Data.SqlDbType.NVarChar, 0, "SignOffUserMRB"), New System.Data.SqlClient.SqlParameter("@SignOffDt", System.Data.SqlDbType.NVarChar, 0, "SignOffDt"), New System.Data.SqlClient.SqlParameter("@AbortedReason", System.Data.SqlDbType.NVarChar, 0, "AbortedReason"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@SubmissionDt", System.Data.SqlDbType.[Date], 0, "SubmissionDt"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.[Date], 0, "DateClosed"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@MRB", System.Data.SqlDbType.NVarChar, 0, "MRB"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@Chairperson", System.Data.SqlDbType.NVarChar, 0, "Chairperson"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Step", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Step", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SignOffUserEng", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SignOffUserEng", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SignOffUserEng", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignOffUserEng", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SignOffUserMRB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SignOffUserMRB", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SignOffUserMRB", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignOffUserMRB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SignOffDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SignOffDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SignOffDt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignOffDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AbortedReason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AbortedReason", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SubmissionDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SubmissionDt", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateClosed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MRB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MRB", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Chairperson", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Chairperson", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Chairperson", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Chairperson", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Step", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Step", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SignOffUserEng", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SignOffUserEng", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SignOffUserEng", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignOffUserEng", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SignOffUserMRB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SignOffUserMRB", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SignOffUserMRB", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignOffUserMRB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SignOffDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SignOffDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SignOffDt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignOffDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AbortedReason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AbortedReason", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SubmissionDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SubmissionDt", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateClosed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MRB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MRB", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Chairperson", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Chairperson", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Chairperson", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Chairperson", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daEngineersMRBs
        '
        Me.daEngineersMRBs.DeleteCommand = Me.SqlDeleteCommand3
        Me.daEngineersMRBs.InsertCommand = Me.SqlInsertCommand3
        Me.daEngineersMRBs.SelectCommand = Me.SqlSelectCommand3
        Me.daEngineersMRBs.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblNCRStepsSignOff", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("NCRNumber", "NCRNumber"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("Step", "Step"), New System.Data.Common.DataColumnMapping("LatestStep", "LatestStep"), New System.Data.Common.DataColumnMapping("AcceptedStep", "AcceptedStep"), New System.Data.Common.DataColumnMapping("ActualStep", "ActualStep"), New System.Data.Common.DataColumnMapping("SignOffUserEng", "SignOffUserEng"), New System.Data.Common.DataColumnMapping("SignOffUserMRB", "SignOffUserMRB"), New System.Data.Common.DataColumnMapping("SignOffDt", "SignOffDt"), New System.Data.Common.DataColumnMapping("AbortedReason", "AbortedReason"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("OriginatorName", "OriginatorName"), New System.Data.Common.DataColumnMapping("SubmissionDt", "SubmissionDt"), New System.Data.Common.DataColumnMapping("DateClosed", "DateClosed"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("MRB", "MRB"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("Chairperson", "Chairperson")})})
        Me.daEngineersMRBs.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'txtRecordID
        '
        Me.txtRecordID.Location = New System.Drawing.Point(406, 78)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(100, 20)
        Me.txtRecordID.TabIndex = 2
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT        RecordID, NCRID, FilePath, FileDescription, ImgField, FileName, Fil" &
    "eExt, Step, ActualStep, DateAdded" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblNCRAttach"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NCRID", System.Data.SqlDbType.Int, 0, "NCRID"), New System.Data.SqlClient.SqlParameter("@FilePath", System.Data.SqlDbType.NVarChar, 0, "FilePath"), New System.Data.SqlClient.SqlParameter("@FileDescription", System.Data.SqlDbType.NVarChar, 0, "FileDescription"), New System.Data.SqlClient.SqlParameter("@ImgField", System.Data.SqlDbType.Image, 0, "ImgField"), New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.NVarChar, 0, "FileName"), New System.Data.SqlClient.SqlParameter("@FileExt", System.Data.SqlDbType.NVarChar, 0, "FileExt"), New System.Data.SqlClient.SqlParameter("@Step", System.Data.SqlDbType.NVarChar, 0, "Step"), New System.Data.SqlClient.SqlParameter("@ActualStep", System.Data.SqlDbType.NVarChar, 0, "ActualStep"), New System.Data.SqlClient.SqlParameter("@DateAdded", System.Data.SqlDbType.[Date], 0, "DateAdded")})
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NCRID", System.Data.SqlDbType.Int, 0, "NCRID"), New System.Data.SqlClient.SqlParameter("@FilePath", System.Data.SqlDbType.NVarChar, 0, "FilePath"), New System.Data.SqlClient.SqlParameter("@FileDescription", System.Data.SqlDbType.NVarChar, 0, "FileDescription"), New System.Data.SqlClient.SqlParameter("@ImgField", System.Data.SqlDbType.Image, 0, "ImgField"), New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.NVarChar, 0, "FileName"), New System.Data.SqlClient.SqlParameter("@FileExt", System.Data.SqlDbType.NVarChar, 0, "FileExt"), New System.Data.SqlClient.SqlParameter("@Step", System.Data.SqlDbType.NVarChar, 0, "Step"), New System.Data.SqlClient.SqlParameter("@ActualStep", System.Data.SqlDbType.NVarChar, 0, "ActualStep"), New System.Data.SqlClient.SqlParameter("@DateAdded", System.Data.SqlDbType.[Date], 0, "DateAdded"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NCRID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NCRID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NCRID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCRID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FilePath", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FilePath", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FilePath", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FilePath", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileExt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileExt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Step", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Step", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualStep", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateAdded", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateAdded", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateAdded", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateAdded", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NCRID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NCRID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NCRID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCRID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FilePath", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FilePath", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FilePath", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FilePath", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileExt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileExt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Step", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Step", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualStep", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateAdded", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateAdded", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateAdded", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateAdded", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daAttachments
        '
        Me.daAttachments.DeleteCommand = Me.SqlDeleteCommand4
        Me.daAttachments.InsertCommand = Me.SqlInsertCommand4
        Me.daAttachments.SelectCommand = Me.SqlSelectCommand4
        Me.daAttachments.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblNCRAttach", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("NCRID", "NCRID"), New System.Data.Common.DataColumnMapping("FilePath", "FilePath"), New System.Data.Common.DataColumnMapping("FileDescription", "FileDescription"), New System.Data.Common.DataColumnMapping("ImgField", "ImgField"), New System.Data.Common.DataColumnMapping("FileName", "FileName"), New System.Data.Common.DataColumnMapping("FileExt", "FileExt"), New System.Data.Common.DataColumnMapping("Step", "Step"), New System.Data.Common.DataColumnMapping("ActualStep", "ActualStep"), New System.Data.Common.DataColumnMapping("DateAdded", "DateAdded")})})
        Me.daAttachments.UpdateCommand = Me.SqlUpdateCommand4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnPrintSteps
        '
        Me.btnPrintSteps.Location = New System.Drawing.Point(1248, 810)
        Me.btnPrintSteps.Name = "btnPrintSteps"
        Me.btnPrintSteps.Size = New System.Drawing.Size(156, 33)
        Me.btnPrintSteps.TabIndex = 3
        Me.btnPrintSteps.Text = "Print Steps"
        Me.btnPrintSteps.UseVisualStyleBackColor = True
        Me.btnPrintSteps.Visible = False
        '
        'btnPrintNCR
        '
        Me.btnPrintNCR.Location = New System.Drawing.Point(1086, 810)
        Me.btnPrintNCR.Name = "btnPrintNCR"
        Me.btnPrintNCR.Size = New System.Drawing.Size(156, 33)
        Me.btnPrintNCR.TabIndex = 4
        Me.btnPrintNCR.Text = "Print NCR"
        Me.btnPrintNCR.UseVisualStyleBackColor = True
        '
        'colActualStep1
        '
        Me.colActualStep1.AppearanceCell.Options.UseTextOptions = True
        Me.colActualStep1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colActualStep1.FieldName = "ActualStep"
        Me.colActualStep1.Name = "colActualStep1"
        Me.colActualStep1.Visible = True
        Me.colActualStep1.VisibleIndex = 0
        Me.colActualStep1.Width = 92
        '
        'frmNCRSteps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 842)
        Me.Controls.Add(Me.btnPrintNCR)
        Me.Controls.Add(Me.btnPrintSteps)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtRecordID)
        Me.Name = "frmNCRSteps"
        Me.Text = "NCR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsNCR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNCR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.groupboxAdditionalActions.ResumeLayout(False)
        Me.groupboxAdditionalActions.PerformLayout()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.XtraTabPage.ResumeLayout(False)
        Me.XtraTabPage.PerformLayout()
        Me.GroupBoxNotifications.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEngineersMRBs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEngineersMRBs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSteps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsStepsOfNCR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAttachments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNCRAttachments1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents bsNCR As BindingSource
    Friend WithEvents DsNCR1 As dsNCR
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNCRNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLatestStep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAcceptedStep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualStep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbortedReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerialNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerialNumType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRevision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkOrderStep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchaseOrderNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginatorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubmissionDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscrepancy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGraphicName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGraphics As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhereDiscovered As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colManufacturer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReportedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTypeOfError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDispositionType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatusNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateClosed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdditionalActions As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostIsSignificant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents daNCR As SqlClient.SqlDataAdapter
    Friend WithEvents btnSaveAsMRB As Button
    Friend WithEvents btnSignOff As Button
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As SqlClient.SqlCommand
    Friend WithEvents daSteps As SqlClient.SqlDataAdapter
    Friend WithEvents DsStepsOfNCR1 As dsStepsOfNCR
    Friend WithEvents txtStep As TextBox
    Friend WithEvents bsSteps As BindingSource
    Friend WithEvents colRecordID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNCRNumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStep1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLatestStep1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAcceptedStep1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbortedReason1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRevision1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginatorName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubmissionDt1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateClosed1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRB1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChairperson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsEngineersMRBs As BindingSource
    Friend WithEvents DsEngineersMRBs1 As dsEngineersMRBs
    Friend WithEvents colRecordID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNCRNumber2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStep2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLatestStep2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAcceptedStep2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualStep2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignOffUserEng As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignOffUserMRB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignOffDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbortedReason2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNumber2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRevision2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginatorName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubmissionDt2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateClosed2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRB2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineer2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChairperson1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As SqlClient.SqlCommand
    Friend WithEvents daEngineersMRBs As SqlClient.SqlDataAdapter
    Friend WithEvents btnSaveAsEngineer As Button
    Friend WithEvents txtRecordIDSignOff As TextBox
    Friend WithEvents btnDeleteSelectedRecord As Button
    Friend WithEvents txtMRB As TextBox
    Friend WithEvents txtEngineer As TextBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents txtIsSignedOff As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblStatusNotes As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents cboManufacturer As ComboBox
    Friend WithEvents cboWhereDiscovered As ComboBox
    Friend WithEvents txtQuantityRejected As TextBox
    Friend WithEvents btnSaveOtherInfo As Button
    Friend WithEvents txtReportedBy As TextBox
    Friend WithEvents cboTypeOfError As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cboDispositionType As ComboBox
    Friend WithEvents rtxtDispositionNotes As RichTextBox
    Friend WithEvents lblDateClosed As Label
    Friend WithEvents rtxtAdditionalActionNotes As RichTextBox
    Friend WithEvents groupboxAdditionalActions As GroupBox
    Friend WithEvents chkNone As CheckBox
    Friend WithEvents chkOther As CheckBox
    Friend WithEvents chkNotify As CheckBox
    Friend WithEvents chkWriteCPAR As CheckBox
    Friend WithEvents chkWriteCAR As CheckBox
    Friend WithEvents chkWriteSCAR As CheckBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents rtxtComments As RichTextBox
    Friend WithEvents rtxtDiscrepancy As RichTextBox
    Friend WithEvents txtPurchaseOrder As TextBox
    Friend WithEvents cboWorkOrder As ComboBox
    Friend WithEvents txtPartDescription As TextBox
    Friend WithEvents txtPartNumber As TextBox
    Friend WithEvents cboRev As ComboBox
    Friend WithEvents txtDrawingNum As TextBox
    Friend WithEvents cboSerialNumType As ComboBox
    Friend WithEvents txtSerialNum As TextBox
    Friend WithEvents cboPrograms As ComboBox
    Friend WithEvents btnSaveCreateTab As Button
    Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
    Friend WithEvents rtxtDisposition As RichTextBox
    Friend WithEvents lblEnterDisposition As Label
    Friend WithEvents rtxtAddDisposition As RichTextBox
    Friend WithEvents lblDisposition As Label
    Friend WithEvents btnNotifyMRBs As Button
    Friend WithEvents btnNotifyEngineers As Button
    Friend WithEvents txtRecordID As TextBox
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAttachRecordID As TextBox
    Friend WithEvents btnSaveNew As Button
    Friend WithEvents btnFileAttachSubmit As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents txtFileDescription As TextBox
    Friend WithEvents btnDeleteAttachment As Button
    Friend WithEvents btnView As Button
    Friend WithEvents bsAttachments As BindingSource
    Friend WithEvents DsNCRAttachments1 As dsNCRAttachments
    Friend WithEvents colRecordID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNCRID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFilePath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImgField As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileExt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As SqlClient.SqlCommand
    Friend WithEvents daAttachments As SqlClient.SqlDataAdapter
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnViewAll As Button
    Friend WithEvents btnPrintSteps As Button
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrintNCR As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents GroupBoxNotifications As GroupBox
    Friend WithEvents Label36 As Label
    Friend WithEvents cboStep As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtAircraftIdentifier As TextBox
    Friend WithEvents txtAcceptedStep As TextBox
    Friend WithEvents btnAbort As Button
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnCloseNCR As Button
    Friend WithEvents btnAddStep As Button
    Friend WithEvents btnSaveDisposition As Button
    Friend WithEvents lblResubmitSelectedRow As Label
    Friend WithEvents rtxtResubmitSelectedRow As RichTextBox
    Friend WithEvents txtSupplierPurchaseOrder As TextBox
    Friend WithEvents txtTotalQuantity As TextBox
    Friend WithEvents txtSalesOrderNum As TextBox
    Friend WithEvents txtMaterialReturnAuthNum As TextBox
    Friend WithEvents txtCustomerNCRNum As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtCause As TextBox
    Friend WithEvents txtResponsiblePerson As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboResponsibleDept As ComboBox
    Friend WithEvents dtpReturnDt As DateTimePicker
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualStep1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtActualStepAttach As TextBox
End Class
