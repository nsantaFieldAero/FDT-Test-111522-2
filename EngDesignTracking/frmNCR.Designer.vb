<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNCR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNCR))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsNCRMain = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNCRMain1 = New EngDesignTracking.dsSteps()
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
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSubmitNCR = New System.Windows.Forms.Button()
        Me.btnReturnMainMenu = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        Me.txtStep = New System.Windows.Forms.TextBox()
        Me.txtNCRNumber = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOVMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManufacturerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtOriginatorName = New System.Windows.Forms.TextBox()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsNCRMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNCRMain1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsNCRMain
        Me.GridControl1.Location = New System.Drawing.Point(0, 68)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1472, 628)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsNCRMain
        '
        Me.bsNCRMain.DataMember = "tblNCR"
        Me.bsNCRMain.DataSource = Me.DsNCRMain1
        '
        'DsNCRMain1
        '
        Me.DsNCRMain1.DataSetName = "dsNCRMain"
        Me.DsNCRMain1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colNCRNumber, Me.colStatus, Me.colStep, Me.colLatestStep, Me.colAcceptedStep, Me.colActualStep, Me.colLocation, Me.colAbortedReason, Me.colProgram, Me.colSerialNum, Me.colSerialNumType, Me.colDrawingNumber, Me.colDwgRevision, Me.colPartDescription, Me.colWorkOrderStep, Me.colPurchaseOrderNum, Me.colOriginatorName, Me.colSubmissionDt, Me.colDiscrepancy, Me.colComments, Me.colType, Me.colGraphicName, Me.colGraphics, Me.colWhereDiscovered, Me.colManufacturer, Me.colQuantity, Me.colReportedBy, Me.colTypeOfError, Me.colDispositionType, Me.colStatusNotes, Me.colDateClosed, Me.colAdditionalActions, Me.colNotes, Me.colCostIsSignificant, Me.colMRB, Me.colEngineer, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
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
        Me.colNCRNumber.Width = 71
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 1
        '
        'colStep
        '
        Me.colStep.FieldName = "Step"
        Me.colStep.Name = "colStep"
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
        Me.colProgram.VisibleIndex = 4
        '
        'colSerialNum
        '
        Me.colSerialNum.FieldName = "SerialNum"
        Me.colSerialNum.Name = "colSerialNum"
        '
        'colSerialNumType
        '
        Me.colSerialNumType.FieldName = "SerialNumType"
        Me.colSerialNumType.Name = "colSerialNumType"
        '
        'colDrawingNumber
        '
        Me.colDrawingNumber.FieldName = "DrawingNumber"
        Me.colDrawingNumber.Name = "colDrawingNumber"
        Me.colDrawingNumber.Visible = True
        Me.colDrawingNumber.VisibleIndex = 3
        Me.colDrawingNumber.Width = 90
        '
        'colDwgRevision
        '
        Me.colDwgRevision.FieldName = "DwgRevision"
        Me.colDwgRevision.Name = "colDwgRevision"
        '
        'colPartDescription
        '
        Me.colPartDescription.FieldName = "PartDescription"
        Me.colPartDescription.Name = "colPartDescription"
        '
        'colWorkOrderStep
        '
        Me.colWorkOrderStep.FieldName = "WorkOrderStep"
        Me.colWorkOrderStep.Name = "colWorkOrderStep"
        Me.colWorkOrderStep.Visible = True
        Me.colWorkOrderStep.VisibleIndex = 6
        Me.colWorkOrderStep.Width = 89
        '
        'colPurchaseOrderNum
        '
        Me.colPurchaseOrderNum.FieldName = "PurchaseOrderNum"
        Me.colPurchaseOrderNum.Name = "colPurchaseOrderNum"
        '
        'colOriginatorName
        '
        Me.colOriginatorName.FieldName = "OriginatorName"
        Me.colOriginatorName.Name = "colOriginatorName"
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
        '
        'colComments
        '
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 9
        Me.colComments.Width = 302
        '
        'colType
        '
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 7
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
        Me.colDateClosed.Visible = True
        Me.colDateClosed.VisibleIndex = 12
        Me.colDateClosed.Width = 145
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
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Title"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 175
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Location"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 69
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "WorkOrder"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "PartNumber"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 10
        Me.GridColumn4.Width = 141
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "PartDescription"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 11
        Me.GridColumn5.Width = 230
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(13, 716)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(146, 33)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit / View Row"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(165, 716)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(146, 33)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSubmitNCR
        '
        Me.btnSubmitNCR.Location = New System.Drawing.Point(317, 716)
        Me.btnSubmitNCR.Name = "btnSubmitNCR"
        Me.btnSubmitNCR.Size = New System.Drawing.Size(146, 33)
        Me.btnSubmitNCR.TabIndex = 3
        Me.btnSubmitNCR.Text = "Submit New NCR"
        Me.btnSubmitNCR.UseVisualStyleBackColor = True
        '
        'btnReturnMainMenu
        '
        Me.btnReturnMainMenu.Location = New System.Drawing.Point(13, 32)
        Me.btnReturnMainMenu.Name = "btnReturnMainMenu"
        Me.btnReturnMainMenu.Size = New System.Drawing.Size(131, 30)
        Me.btnReturnMainMenu.TabIndex = 4
        Me.btnReturnMainMenu.Text = "<< Return to Main Menu"
        Me.btnReturnMainMenu.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(393, 32)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(131, 30)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh Grid"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(530, 32)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(131, 30)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "Export Grid"
        Me.btnExport.UseVisualStyleBackColor = True
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NCRNumber", System.Data.SqlDbType.Int, 0, "NCRNumber"), New System.Data.SqlClient.SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 0, "Title"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@Step", System.Data.SqlDbType.NVarChar, 0, "Step"), New System.Data.SqlClient.SqlParameter("@LatestStep", System.Data.SqlDbType.Int, 0, "LatestStep"), New System.Data.SqlClient.SqlParameter("@AcceptedStep", System.Data.SqlDbType.Int, 0, "AcceptedStep"), New System.Data.SqlClient.SqlParameter("@ActualStep", System.Data.SqlDbType.Int, 0, "ActualStep"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@AbortedReason", System.Data.SqlDbType.NVarChar, 0, "AbortedReason"), New System.Data.SqlClient.SqlParameter("@AbortedBy", System.Data.SqlDbType.NVarChar, 0, "AbortedBy"), New System.Data.SqlClient.SqlParameter("@ResubmittedReason", System.Data.SqlDbType.NVarChar, 0, "ResubmittedReason"), New System.Data.SqlClient.SqlParameter("@ResubmittedBy", System.Data.SqlDbType.NVarChar, 0, "ResubmittedBy"), New System.Data.SqlClient.SqlParameter("@ResubmittedDt", System.Data.SqlDbType.NVarChar, 0, "ResubmittedDt"), New System.Data.SqlClient.SqlParameter("@UsernameWhoAborted", System.Data.SqlDbType.NVarChar, 0, "UsernameWhoAborted"), New System.Data.SqlClient.SqlParameter("@AbortedDt", System.Data.SqlDbType.NVarChar, 0, "AbortedDt"), New System.Data.SqlClient.SqlParameter("@UsernameWhoResubmitted", System.Data.SqlDbType.NVarChar, 0, "UsernameWhoResubmitted"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@SerialNum", System.Data.SqlDbType.NVarChar, 0, "SerialNum"), New System.Data.SqlClient.SqlParameter("@SerialNumType", System.Data.SqlDbType.NVarChar, 0, "SerialNumType"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@PartNumber", System.Data.SqlDbType.NVarChar, 0, "PartNumber"), New System.Data.SqlClient.SqlParameter("@PartDescription", System.Data.SqlDbType.NVarChar, 0, "PartDescription"), New System.Data.SqlClient.SqlParameter("@WorkOrderStep", System.Data.SqlDbType.NVarChar, 0, "WorkOrderStep"), New System.Data.SqlClient.SqlParameter("@PurchaseOrderNum", System.Data.SqlDbType.NVarChar, 0, "PurchaseOrderNum"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@SubmissionDt", System.Data.SqlDbType.[Date], 0, "SubmissionDt"), New System.Data.SqlClient.SqlParameter("@Discrepancy", System.Data.SqlDbType.NVarChar, 0, "Discrepancy"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@GraphicName", System.Data.SqlDbType.NVarChar, 0, "GraphicName"), New System.Data.SqlClient.SqlParameter("@Graphics", System.Data.SqlDbType.Image, 0, "Graphics"), New System.Data.SqlClient.SqlParameter("@WhereDiscovered", System.Data.SqlDbType.NVarChar, 0, "WhereDiscovered"), New System.Data.SqlClient.SqlParameter("@Manufacturer", System.Data.SqlDbType.NVarChar, 0, "Manufacturer"), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.NVarChar, 0, "Quantity"), New System.Data.SqlClient.SqlParameter("@ReportedBy", System.Data.SqlDbType.NVarChar, 0, "ReportedBy"), New System.Data.SqlClient.SqlParameter("@TypeOfError", System.Data.SqlDbType.NVarChar, 0, "TypeOfError"), New System.Data.SqlClient.SqlParameter("@DispositionType", System.Data.SqlDbType.NVarChar, 0, "DispositionType"), New System.Data.SqlClient.SqlParameter("@StatusNotes", System.Data.SqlDbType.NVarChar, 0, "StatusNotes"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.[Date], 0, "DateClosed"), New System.Data.SqlClient.SqlParameter("@AdditionalActions", System.Data.SqlDbType.NVarChar, 0, "AdditionalActions"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@CostIsSignificant", System.Data.SqlDbType.NVarChar, 0, "CostIsSignificant"), New System.Data.SqlClient.SqlParameter("@MRB", System.Data.SqlDbType.NVarChar, 0, "MRB"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@None", System.Data.SqlDbType.Bit, 0, "None"), New System.Data.SqlClient.SqlParameter("@NotifyCustomer", System.Data.SqlDbType.Bit, 0, "NotifyCustomer"), New System.Data.SqlClient.SqlParameter("@WriteCAR", System.Data.SqlDbType.Bit, 0, "WriteCAR"), New System.Data.SqlClient.SqlParameter("@WriteSCAR", System.Data.SqlDbType.Bit, 0, "WriteSCAR"), New System.Data.SqlClient.SqlParameter("@WriteCPAR", System.Data.SqlDbType.Bit, 0, "WriteCPAR"), New System.Data.SqlClient.SqlParameter("@Other", System.Data.SqlDbType.Bit, 0, "Other"), New System.Data.SqlClient.SqlParameter("@ERAS", System.Data.SqlDbType.NVarChar, 0, "ERAS"), New System.Data.SqlClient.SqlParameter("@DateERASUpdated", System.Data.SqlDbType.[Date], 0, "DateERASUpdated"), New System.Data.SqlClient.SqlParameter("@ERASUpdatedBy", System.Data.SqlDbType.NVarChar, 0, "ERASUpdatedBy"), New System.Data.SqlClient.SqlParameter("@WorkOrder", System.Data.SqlDbType.NVarChar, 0, "WorkOrder"), New System.Data.SqlClient.SqlParameter("@StepWorkOrder", System.Data.SqlDbType.NVarChar, 0, "StepWorkOrder")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NCRNumber", System.Data.SqlDbType.Int, 0, "NCRNumber"), New System.Data.SqlClient.SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 0, "Title"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@Step", System.Data.SqlDbType.NVarChar, 0, "Step"), New System.Data.SqlClient.SqlParameter("@LatestStep", System.Data.SqlDbType.Int, 0, "LatestStep"), New System.Data.SqlClient.SqlParameter("@AcceptedStep", System.Data.SqlDbType.Int, 0, "AcceptedStep"), New System.Data.SqlClient.SqlParameter("@ActualStep", System.Data.SqlDbType.Int, 0, "ActualStep"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@AbortedReason", System.Data.SqlDbType.NVarChar, 0, "AbortedReason"), New System.Data.SqlClient.SqlParameter("@AbortedBy", System.Data.SqlDbType.NVarChar, 0, "AbortedBy"), New System.Data.SqlClient.SqlParameter("@ResubmittedReason", System.Data.SqlDbType.NVarChar, 0, "ResubmittedReason"), New System.Data.SqlClient.SqlParameter("@ResubmittedBy", System.Data.SqlDbType.NVarChar, 0, "ResubmittedBy"), New System.Data.SqlClient.SqlParameter("@ResubmittedDt", System.Data.SqlDbType.NVarChar, 0, "ResubmittedDt"), New System.Data.SqlClient.SqlParameter("@UsernameWhoAborted", System.Data.SqlDbType.NVarChar, 0, "UsernameWhoAborted"), New System.Data.SqlClient.SqlParameter("@AbortedDt", System.Data.SqlDbType.NVarChar, 0, "AbortedDt"), New System.Data.SqlClient.SqlParameter("@UsernameWhoResubmitted", System.Data.SqlDbType.NVarChar, 0, "UsernameWhoResubmitted"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@SerialNum", System.Data.SqlDbType.NVarChar, 0, "SerialNum"), New System.Data.SqlClient.SqlParameter("@SerialNumType", System.Data.SqlDbType.NVarChar, 0, "SerialNumType"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@PartNumber", System.Data.SqlDbType.NVarChar, 0, "PartNumber"), New System.Data.SqlClient.SqlParameter("@PartDescription", System.Data.SqlDbType.NVarChar, 0, "PartDescription"), New System.Data.SqlClient.SqlParameter("@WorkOrderStep", System.Data.SqlDbType.NVarChar, 0, "WorkOrderStep"), New System.Data.SqlClient.SqlParameter("@PurchaseOrderNum", System.Data.SqlDbType.NVarChar, 0, "PurchaseOrderNum"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@SubmissionDt", System.Data.SqlDbType.[Date], 0, "SubmissionDt"), New System.Data.SqlClient.SqlParameter("@Discrepancy", System.Data.SqlDbType.NVarChar, 0, "Discrepancy"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@GraphicName", System.Data.SqlDbType.NVarChar, 0, "GraphicName"), New System.Data.SqlClient.SqlParameter("@Graphics", System.Data.SqlDbType.Image, 0, "Graphics"), New System.Data.SqlClient.SqlParameter("@WhereDiscovered", System.Data.SqlDbType.NVarChar, 0, "WhereDiscovered"), New System.Data.SqlClient.SqlParameter("@Manufacturer", System.Data.SqlDbType.NVarChar, 0, "Manufacturer"), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.NVarChar, 0, "Quantity"), New System.Data.SqlClient.SqlParameter("@ReportedBy", System.Data.SqlDbType.NVarChar, 0, "ReportedBy"), New System.Data.SqlClient.SqlParameter("@TypeOfError", System.Data.SqlDbType.NVarChar, 0, "TypeOfError"), New System.Data.SqlClient.SqlParameter("@DispositionType", System.Data.SqlDbType.NVarChar, 0, "DispositionType"), New System.Data.SqlClient.SqlParameter("@StatusNotes", System.Data.SqlDbType.NVarChar, 0, "StatusNotes"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.[Date], 0, "DateClosed"), New System.Data.SqlClient.SqlParameter("@AdditionalActions", System.Data.SqlDbType.NVarChar, 0, "AdditionalActions"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@CostIsSignificant", System.Data.SqlDbType.NVarChar, 0, "CostIsSignificant"), New System.Data.SqlClient.SqlParameter("@MRB", System.Data.SqlDbType.NVarChar, 0, "MRB"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@None", System.Data.SqlDbType.Bit, 0, "None"), New System.Data.SqlClient.SqlParameter("@NotifyCustomer", System.Data.SqlDbType.Bit, 0, "NotifyCustomer"), New System.Data.SqlClient.SqlParameter("@WriteCAR", System.Data.SqlDbType.Bit, 0, "WriteCAR"), New System.Data.SqlClient.SqlParameter("@WriteSCAR", System.Data.SqlDbType.Bit, 0, "WriteSCAR"), New System.Data.SqlClient.SqlParameter("@WriteCPAR", System.Data.SqlDbType.Bit, 0, "WriteCPAR"), New System.Data.SqlClient.SqlParameter("@Other", System.Data.SqlDbType.Bit, 0, "Other"), New System.Data.SqlClient.SqlParameter("@ERAS", System.Data.SqlDbType.NVarChar, 0, "ERAS"), New System.Data.SqlClient.SqlParameter("@DateERASUpdated", System.Data.SqlDbType.[Date], 0, "DateERASUpdated"), New System.Data.SqlClient.SqlParameter("@ERASUpdatedBy", System.Data.SqlDbType.NVarChar, 0, "ERASUpdatedBy"), New System.Data.SqlClient.SqlParameter("@WorkOrder", System.Data.SqlDbType.NVarChar, 0, "WorkOrder"), New System.Data.SqlClient.SqlParameter("@StepWorkOrder", System.Data.SqlDbType.NVarChar, 0, "StepWorkOrder"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Title", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Title", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Title", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Title", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Step", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Step", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AbortedReason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AbortedReason", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AbortedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AbortedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AbortedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AbortedBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResubmittedReason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResubmittedReason", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResubmittedReason", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResubmittedReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResubmittedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResubmittedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResubmittedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResubmittedBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResubmittedDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResubmittedDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResubmittedDt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResubmittedDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UsernameWhoAborted", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UsernameWhoAborted", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UsernameWhoAborted", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UsernameWhoAborted", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AbortedDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AbortedDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AbortedDt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AbortedDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UsernameWhoResubmitted", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UsernameWhoResubmitted", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UsernameWhoResubmitted", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UsernameWhoResubmitted", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNumType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNumType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNumType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PartNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PartNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PartNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PartDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PartDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PartDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WorkOrderStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WorkOrderStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WorkOrderStep", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WorkOrderStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PurchaseOrderNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PurchaseOrderNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PurchaseOrderNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchaseOrderNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SubmissionDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SubmissionDt", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Discrepancy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Discrepancy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Discrepancy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Discrepancy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_GraphicName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GraphicName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_GraphicName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GraphicName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WhereDiscovered", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WhereDiscovered", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WhereDiscovered", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WhereDiscovered", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Manufacturer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Manufacturer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Manufacturer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manufacturer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Quantity", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReportedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReportedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReportedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportedBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TypeOfError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TypeOfError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TypeOfError", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TypeOfError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DispositionType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DispositionType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DispositionType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DispositionType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StatusNotes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StatusNotes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StatusNotes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StatusNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateClosed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AdditionalActions", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AdditionalActions", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AdditionalActions", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AdditionalActions", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CostIsSignificant", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CostIsSignificant", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CostIsSignificant", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostIsSignificant", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MRB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MRB", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_None", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "None", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_None", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "None", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NotifyCustomer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NotifyCustomer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NotifyCustomer", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NotifyCustomer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WriteCAR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WriteCAR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WriteCAR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WriteCAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WriteSCAR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WriteSCAR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WriteSCAR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WriteSCAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WriteCPAR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WriteCPAR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WriteCPAR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WriteCPAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Other", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Other", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Other", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Other", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ERAS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ERAS", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ERAS", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ERAS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateERASUpdated", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateERASUpdated", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateERASUpdated", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateERASUpdated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ERASUpdatedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ERASUpdatedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ERASUpdatedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ERASUpdatedBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WorkOrder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WorkOrder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StepWorkOrder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StepWorkOrder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StepWorkOrder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StepWorkOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NCRNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCRNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Title", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Title", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Title", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Title", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Step", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Step", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Step", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LatestStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LatestStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AcceptedStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcceptedStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AbortedReason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AbortedReason", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AbortedReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AbortedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AbortedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AbortedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AbortedBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResubmittedReason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResubmittedReason", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResubmittedReason", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResubmittedReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResubmittedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResubmittedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResubmittedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResubmittedBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ResubmittedDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ResubmittedDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ResubmittedDt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResubmittedDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UsernameWhoAborted", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UsernameWhoAborted", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UsernameWhoAborted", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UsernameWhoAborted", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AbortedDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AbortedDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AbortedDt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AbortedDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UsernameWhoResubmitted", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UsernameWhoResubmitted", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UsernameWhoResubmitted", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UsernameWhoResubmitted", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNumType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNumType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNumType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PartNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PartNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PartNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PartDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PartDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PartDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WorkOrderStep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WorkOrderStep", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WorkOrderStep", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WorkOrderStep", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PurchaseOrderNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PurchaseOrderNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PurchaseOrderNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PurchaseOrderNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SubmissionDt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SubmissionDt", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubmissionDt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Discrepancy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Discrepancy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Discrepancy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Discrepancy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_GraphicName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GraphicName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_GraphicName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GraphicName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WhereDiscovered", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WhereDiscovered", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WhereDiscovered", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WhereDiscovered", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Manufacturer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Manufacturer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Manufacturer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Manufacturer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Quantity", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReportedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReportedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReportedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportedBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TypeOfError", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TypeOfError", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TypeOfError", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TypeOfError", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DispositionType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DispositionType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DispositionType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DispositionType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StatusNotes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StatusNotes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StatusNotes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StatusNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateClosed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_AdditionalActions", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AdditionalActions", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_AdditionalActions", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AdditionalActions", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CostIsSignificant", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CostIsSignificant", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CostIsSignificant", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostIsSignificant", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MRB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MRB", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MRB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_None", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "None", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_None", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "None", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NotifyCustomer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NotifyCustomer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NotifyCustomer", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NotifyCustomer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WriteCAR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WriteCAR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WriteCAR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WriteCAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WriteSCAR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WriteSCAR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WriteSCAR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WriteSCAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WriteCPAR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WriteCPAR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WriteCPAR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WriteCPAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Other", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Other", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Other", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Other", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ERAS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ERAS", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ERAS", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ERAS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateERASUpdated", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateERASUpdated", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateERASUpdated", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateERASUpdated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ERASUpdatedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ERASUpdatedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ERASUpdatedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ERASUpdatedBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_WorkOrder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_WorkOrder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WorkOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StepWorkOrder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StepWorkOrder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StepWorkOrder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StepWorkOrder", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblNCR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("NCRNumber", "NCRNumber"), New System.Data.Common.DataColumnMapping("Title", "Title"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("Step", "Step"), New System.Data.Common.DataColumnMapping("LatestStep", "LatestStep"), New System.Data.Common.DataColumnMapping("AcceptedStep", "AcceptedStep"), New System.Data.Common.DataColumnMapping("ActualStep", "ActualStep"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("AbortedReason", "AbortedReason"), New System.Data.Common.DataColumnMapping("AbortedBy", "AbortedBy"), New System.Data.Common.DataColumnMapping("ResubmittedReason", "ResubmittedReason"), New System.Data.Common.DataColumnMapping("ResubmittedBy", "ResubmittedBy"), New System.Data.Common.DataColumnMapping("ResubmittedDt", "ResubmittedDt"), New System.Data.Common.DataColumnMapping("UsernameWhoAborted", "UsernameWhoAborted"), New System.Data.Common.DataColumnMapping("AbortedDt", "AbortedDt"), New System.Data.Common.DataColumnMapping("UsernameWhoResubmitted", "UsernameWhoResubmitted"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("SerialNum", "SerialNum"), New System.Data.Common.DataColumnMapping("SerialNumType", "SerialNumType"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("PartNumber", "PartNumber"), New System.Data.Common.DataColumnMapping("PartDescription", "PartDescription"), New System.Data.Common.DataColumnMapping("WorkOrderStep", "WorkOrderStep"), New System.Data.Common.DataColumnMapping("PurchaseOrderNum", "PurchaseOrderNum"), New System.Data.Common.DataColumnMapping("OriginatorName", "OriginatorName"), New System.Data.Common.DataColumnMapping("SubmissionDt", "SubmissionDt"), New System.Data.Common.DataColumnMapping("Discrepancy", "Discrepancy"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("GraphicName", "GraphicName"), New System.Data.Common.DataColumnMapping("Graphics", "Graphics"), New System.Data.Common.DataColumnMapping("WhereDiscovered", "WhereDiscovered"), New System.Data.Common.DataColumnMapping("Manufacturer", "Manufacturer"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("ReportedBy", "ReportedBy"), New System.Data.Common.DataColumnMapping("TypeOfError", "TypeOfError"), New System.Data.Common.DataColumnMapping("DispositionType", "DispositionType"), New System.Data.Common.DataColumnMapping("StatusNotes", "StatusNotes"), New System.Data.Common.DataColumnMapping("DateClosed", "DateClosed"), New System.Data.Common.DataColumnMapping("AdditionalActions", "AdditionalActions"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("CostIsSignificant", "CostIsSignificant"), New System.Data.Common.DataColumnMapping("MRB", "MRB"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("None", "None"), New System.Data.Common.DataColumnMapping("NotifyCustomer", "NotifyCustomer"), New System.Data.Common.DataColumnMapping("WriteCAR", "WriteCAR"), New System.Data.Common.DataColumnMapping("WriteSCAR", "WriteSCAR"), New System.Data.Common.DataColumnMapping("WriteCPAR", "WriteCPAR"), New System.Data.Common.DataColumnMapping("Other", "Other"), New System.Data.Common.DataColumnMapping("ERAS", "ERAS"), New System.Data.Common.DataColumnMapping("DateERASUpdated", "DateERASUpdated"), New System.Data.Common.DataColumnMapping("ERASUpdatedBy", "ERASUpdatedBy"), New System.Data.Common.DataColumnMapping("WorkOrder", "WorkOrder"), New System.Data.Common.DataColumnMapping("StepWorkOrder", "StepWorkOrder")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'txtRecordID
        '
        Me.txtRecordID.Location = New System.Drawing.Point(361, 226)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(100, 20)
        Me.txtRecordID.TabIndex = 7
        '
        'txtStep
        '
        Me.txtStep.Location = New System.Drawing.Point(360, 314)
        Me.txtStep.Name = "txtStep"
        Me.txtStep.Size = New System.Drawing.Size(100, 20)
        Me.txtStep.TabIndex = 8
        '
        'txtNCRNumber
        '
        Me.txtNCRNumber.Location = New System.Drawing.Point(308, 331)
        Me.txtNCRNumber.Name = "txtNCRNumber"
        Me.txtNCRNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNCRNumber.TabIndex = 9
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(222, 415)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtStatus.TabIndex = 10
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1484, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOVMaintenanceToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'LOVMaintenanceToolStripMenuItem
        '
        Me.LOVMaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocationsToolStripMenuItem, Me.ManufacturerToolStripMenuItem, Me.UsersToolStripMenuItem})
        Me.LOVMaintenanceToolStripMenuItem.Name = "LOVMaintenanceToolStripMenuItem"
        Me.LOVMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LOVMaintenanceToolStripMenuItem.Text = "LOV Maintenance"
        '
        'LocationsToolStripMenuItem
        '
        Me.LocationsToolStripMenuItem.Name = "LocationsToolStripMenuItem"
        Me.LocationsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.LocationsToolStripMenuItem.Text = "Locations"
        '
        'ManufacturerToolStripMenuItem
        '
        Me.ManufacturerToolStripMenuItem.Name = "ManufacturerToolStripMenuItem"
        Me.ManufacturerToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ManufacturerToolStripMenuItem.Text = "Manufacturer"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtOriginatorName
        '
        Me.txtOriginatorName.Location = New System.Drawing.Point(556, 262)
        Me.txtOriginatorName.Name = "txtOriginatorName"
        Me.txtOriginatorName.Size = New System.Drawing.Size(100, 20)
        Me.txtOriginatorName.TabIndex = 12
        '
        'frmNCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 761)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnReturnMainMenu)
        Me.Controls.Add(Me.btnSubmitNCR)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtRecordID)
        Me.Controls.Add(Me.txtStep)
        Me.Controls.Add(Me.txtNCRNumber)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtOriginatorName)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNCR"
        Me.Text = "NCR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsNCRMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNCRMain1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSubmitNCR As Button
    Friend WithEvents btnReturnMainMenu As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents bsNCRMain As BindingSource
    Friend WithEvents DsNCRMain1 As dsSteps
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
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents txtRecordID As TextBox
    Friend WithEvents txtStep As TextBox
    Friend WithEvents txtNCRNumber As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOVMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ManufacturerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtOriginatorName As TextBox
End Class
