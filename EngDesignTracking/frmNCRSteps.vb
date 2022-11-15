Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmNCRSteps
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Public RowSelectedSteps
    Public RowSelectedSignOff
    Dim LastRecordID As String = ""
    Dim StepSelected As String
    Dim ActualStepSelected As String
    Dim AcceptedStepSelected As String
    Public Disposition As String
    Dim ThereIsAnOpenDisposition As String = ""
    Dim NCRIsClosed As String = ""

    Private Sub frmNCRSteps_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection2.ConnectionString = sqlString


        'Get LatestStep and ActualStep of NCR
        da = New SqlClient.SqlDataAdapter("Select * From tblNCRSteps Where NCRNumber = '" & NCRNumber & "' And Status != 'Aborted' And Status != 'Closed' Order By RecordID Desc", SqlConnection1)
        da.Fill(ds, "NCRData")

        If ds.Tables("NCRData").Rows.Count > 0 Then
            LatestStep = ds.Tables("NCRData").Rows(0).Item("LatestStep")
            ActualStep = ds.Tables("NCRData").Rows(0).Item("ActualStep")

            If IsDBNull(ds.Tables("NCRData").Rows(0).Item("AcceptedStep")) Then
                AcceptedStep = ""
            Else
                AcceptedStep = ds.Tables("NCRData").Rows(0).Item("AcceptedStep")
            End If

            If IsDBNull(ds.Tables("NCRData").Rows(0).Item("Disposition")) Then
                Disposition = ""
            Else
                Disposition = ds.Tables("NCRData").Rows(0).Item("Disposition")
            End If

            ds.Tables("NCRData").Clear()
            ds.Tables("NCRData").Dispose()
        End If



        ''Get Step and Actual Step of selected step to use when saving attachments
        'StepSelected = LatestStep
        'ActualStepSelected = ActualStep




        'OTHER INFO TAB -----------------------------------------------------------------

        'Populate Location dropdown in Other Info tabs
        da = New SqlClient.SqlDataAdapter("Select Distinct Location From tblNCRLocations", SqlConnection1)
        da.Fill(ds, "NCRLocations")

        Dim b As Integer = 0
        While b <= ds.Tables("NCRLocations").Rows.Count - 1
            cboLocation.Items.Add(ds.Tables("NCRLocations").Rows(b).Item("Location"))
            b = b + 1
        End While

        ds.Tables("NCRLocations").Clear()
        ds.Tables("NCRLocations").Dispose()


        'Populate the Where Discovered drop-down
        da = New SqlClient.SqlDataAdapter("Select * From DropdownWhereDiscovered", SqlConnection1)
        da.Fill(ds, "WhereDiscovered")

        Dim z As Integer = 0
        While z <= ds.Tables("WhereDiscovered").Rows.Count - 1
            Me.cboWhereDiscovered.Items.Add(ds.Tables("WhereDiscovered").Rows(z).Item("WhereDiscovered"))
            z = z + 1
        End While

        ds.Tables("WhereDiscovered").Clear()
        ds.Tables("WhereDiscovered").Dispose()


        'Populate the Responsible Department drop-down
        da = New SqlClient.SqlDataAdapter("Select * From DropdownResponsible", SqlConnection1)
        da.Fill(ds, "ResponsibleDept")

        Dim g As Integer = 0
        While g <= ds.Tables("ResponsibleDept").Rows.Count - 1
            Me.cboResponsibleDept.Items.Add(ds.Tables("ResponsibleDept").Rows(g).Item("Responsible"))
            g = g + 1
        End While

        ds.Tables("ResponsibleDept").Clear()
        ds.Tables("ResponsibleDept").Dispose()


        'Populate Manufacturer dropdown in Other Info tabs
        da = New SqlClient.SqlDataAdapter("Select Distinct Manufacturer From tblNCRManufacturers", SqlConnection1)
        da.Fill(ds, "NCRManufacturers")

        Dim c As Integer = 0
        While c <= ds.Tables("NCRManufacturers").Rows.Count - 1
            cboManufacturer.Items.Add(ds.Tables("NCRManufacturers").Rows(c).Item("Manufacturer"))
            c = c + 1
        End While

        ds.Tables("NCRManufacturers").Clear()
        ds.Tables("NCRManufacturers").Dispose()

        ''If Location Not Calgary then make the labels Status/Notes equal to Disposition Notes AND Notes equal to Additional Action Notes
        'If isCalgary <> "Yes" Then
        '    lblStatusNotes.Text = "Disposition Notes"
        '    lblNotes.Text = "Additional Action Notes"
        'End If

        '---------------------------------------------------------------------------



        'DATA FOR DISCREPANCY TAB ---------------------------------------------------------

        'Populate the Program drop-down
        da = New SqlClient.SqlDataAdapter("Select * from tblProgram Where Active = 'True' Order By ProgramName", SqlConnection2)
        da.Fill(ds, "Programs")

        Dim p As Integer = 0
        While p <= ds.Tables("Programs").Rows.Count - 1
            Me.cboPrograms.Items.Add(ds.Tables("Programs").Rows(p).Item("ProgramName"))     'ds.Tables("Programs").Rows(p).Item("ProjectNumber") & " - " & 
            p = p + 1
        End While

        ds.Tables("Programs").Clear()
        ds.Tables("Programs").Dispose()

        'Load Revisions Information
        da = New SqlClient.SqlDataAdapter("Select * From tblDwgRevisions Order By RecordID Asc", SqlConnection2)
        da.Fill(ds, "Revisions")

        Dim i As Integer = 0
        While i <= ds.Tables("Revisions").Rows.Count - 1
            Me.cboRev.Items.Add(ds.Tables("Revisions").Rows(i).Item("DwgRevision"))
            i = i + 1
        End While

        ds.Tables("Revisions").Clear()
        ds.Tables("Revisions").Dispose()



        'STEPS ----------------------------------------------------------------------

        'Populate Engineer dropdown in Engineers/MRBs grid
        RepositoryItemComboBox1.Items.Clear()
        da = New SqlClient.SqlDataAdapter("Select Distinct Username From tblUsers Where Engineer = 'T' Order By Username", SqlConnection2)
        da.Fill(ds, "NCRUsernames")

        Dim d As Integer = 0
        While d <= ds.Tables("NCRUsernames").Rows.Count - 1
            RepositoryItemComboBox1.Items.Add(ds.Tables("NCRUsernames").Rows(d).Item("Username"))
            d = d + 1
        End While

        ds.Tables("NCRUsernames").Clear()
        ds.Tables("NCRUsernames").Dispose()


        'Populate MRB dropdown in Engineers/MRBs grid
        RepositoryItemComboBox2.Items.Clear()
        da = New SqlClient.SqlDataAdapter("Select Distinct Username From tblUsers Where ProductionManager = 1 Or ProgramManager = 1 Or DAO = 1 Or LeadEngineer = 1 Or Stress = 'T' Or Design = 1 Or LiaisonEngineer = 'T' Order By Username", SqlConnection2)
        'MAYBE TO ADD: NCR Point 4, add below line instead of above
        'da = New SqlClient.SqlDataAdapter("Select Distinct ID From tblUsers Where ProductionManager = 1 Or ProgramManager = 1 Or DAO = 1 Or LeadEngineer = 1 Or Stress = 'T' Or Design = 1 Or LiaisonEngineer = 'T' Order By Username", SqlConnection2)
        da.Fill(ds, "NCRUsernamesMRB")

        Dim a As Integer = 0
        While a <= ds.Tables("NCRUsernamesMRB").Rows.Count - 1
            RepositoryItemComboBox2.Items.Add(ds.Tables("NCRUsernamesMRB").Rows(a).Item("Username"))
            a = a + 1
        End While

        ds.Tables("NCRUsernamesMRB").Clear()
        ds.Tables("NCRUsernamesMRB").Dispose()



        Search()
        SearchSteps()
        SearchEngineersMRBs()


        'Disable controls in the Other Info tab and Discrepancy tab if step is 2 or above
        If LatestStep <> "1" Then
            If isSuperUser = "True" Or isQAManager = "True" Or isQC = "True" Or isNCRAdmin = "T" Then
                'Nothing
            Else
                DisableOtherInfoControls()
            End If
        End If


        'Disable Disposition Type and Additional Actions if user is the Originator and it is not a QA/SuperUser/Admin
        If OriginatorName = User Then
            If isSuperUser <> "True" And isQAManager <> "True" And isNCRAdmin <> "T" Then
                groupboxAdditionalActions.Enabled = False
                cboDispositionType.Enabled = False
            End If
        End If


        'Disable controls if latest step is Aborted or Closed
        da = New SqlClient.SqlDataAdapter("Select Status From tblNCR Where NCRNumber = '" & NCRNumber & "' Order By RecordID Desc", SqlConnection1)
        da.Fill(ds, "StatusTblNCR")

        If ds.Tables("StatusTblNCR").Rows.Count > 0 Then
            If ds.Tables("StatusTblNCR").Rows(0).Item("Status") = "Aborted" Or ds.Tables("StatusTblNCR").Rows(0).Item("Status") = "Closed" Then
                DisableControls()
                DisableOtherInfoControls()
                DisableAttachmentsControls()
            End If

            ds.Tables("StatusTblNCR").Clear()
            ds.Tables("StatusTblNCR").Dispose()
        End If


        'If user is coming from adding a new NCR then have the Other Info tab selected, so the user can enter the rest of the stuff
        If UserComingFromAddNCR = "Yes" Then
            XtraTabControl1.SelectedTabPage = XtraTabPage1
            UserComingFromAddNCR = ""
        Else
            XtraTabControl1.SelectedTabPage = XtraTabPage
        End If



        ''If Disposition of Step 1 is empty then make the Disposition of Selected Step enabled so that the user enters it before accepting step 1
        'If ActualStep = "1" And Disposition = "" Then       'And rtxtDisposition.Text = "" Then
        '    rtxtDisposition.ReadOnly = False
        'Else
        '    rtxtDisposition.ReadOnly = True
        'End If

    End Sub

    Public Function Search()

        Dim SqlString As String
        Dim cmdSave As String

        Me.DsNCR1.tblNCR.Clear()

        Me.txtRecordID.DataBindings.Clear()
        Me.txtStatus.DataBindings.Clear()
        Me.cboType.DataBindings.Clear()
        Me.cboLocation.DataBindings.Clear()
        Me.cboWhereDiscovered.DataBindings.Clear()
        Me.cboManufacturer.DataBindings.Clear()
        Me.txtQuantityRejected.DataBindings.Clear()
        Me.txtReportedBy.DataBindings.Clear()
        Me.cboTypeOfError.DataBindings.Clear()
        Me.cboDispositionType.DataBindings.Clear()
        Me.rtxtDispositionNotes.DataBindings.Clear()
        Me.lblDateClosed.DataBindings.Clear()
        Me.chkNone.DataBindings.Clear()
        Me.chkNotify.DataBindings.Clear()
        Me.chkWriteCAR.DataBindings.Clear()
        Me.chkWriteSCAR.DataBindings.Clear()
        Me.chkWriteCPAR.DataBindings.Clear()
        Me.chkOther.DataBindings.Clear()
        Me.rtxtAdditionalActionNotes.DataBindings.Clear()
        Me.cboResponsibleDept.DataBindings.Clear()
        Me.txtResponsiblePerson.DataBindings.Clear()
        Me.txtCause.DataBindings.Clear()
        Me.txtCost.DataBindings.Clear()
        Me.txtCustomerNCRNum.DataBindings.Clear()
        Me.txtMaterialReturnAuthNum.DataBindings.Clear()
        Me.txtSalesOrderNum.DataBindings.Clear()
        Me.dtpReturnDt.DataBindings.Clear()
        Me.txtTotalQuantity.DataBindings.Clear()
        Me.txtSupplierPurchaseOrder.DataBindings.Clear()
        'Me.cboCostIsSignificant.DataBindings.Clear()

        Me.cboPrograms.DataBindings.Clear()
        Me.txtSerialNum.DataBindings.Clear()
        Me.cboSerialNumType.DataBindings.Clear()
        Me.txtAircraftIdentifier.DataBindings.Clear()
        Me.txtDrawingNum.DataBindings.Clear()
        Me.cboRev.DataBindings.Clear()
        Me.txtPartNumber.DataBindings.Clear()
        Me.txtPartDescription.DataBindings.Clear()
        Me.cboWorkOrder.DataBindings.Clear()
        Me.cboStep.DataBindings.Clear()
        Me.txtPurchaseOrder.DataBindings.Clear()
        Me.rtxtDiscrepancy.DataBindings.Clear()
        Me.rtxtComments.DataBindings.Clear()

        'Me.txtAbortedReason.DataBindings.Clear()



        If RecordIDNCR <> 0 Then
            SqlString = " Where RecordID = '" & Val(RecordIDNCR) & "'"
        End If

        'RecordIDNCR = 0


        cmdSave = Me.daNCR.SelectCommand.CommandText
        Me.daNCR.SelectCommand.CommandText() += SqlString


        Try
            Me.daNCR.Fill(DsNCR1.tblNCR)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.daNCR.SelectCommand.CommandText = cmdSave

        If Me.DsNCR1.Tables("tblNCR").Rows.Count <> 0 Then

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text", Me.bsNCR, "RecordID")
            Me.txtStatus.DataBindings.Add("Text", Me.bsNCR, "Status")
            Me.cboType.DataBindings.Add("Text", Me.bsNCR, "Type")
            Me.cboLocation.DataBindings.Add("Text", Me.bsNCR, "Location")
            Me.cboWhereDiscovered.DataBindings.Add("Text", Me.bsNCR, "WhereDiscovered")
            Me.cboManufacturer.DataBindings.Add("Text", Me.bsNCR, "Manufacturer")
            Me.txtQuantityRejected.DataBindings.Add("Text", Me.bsNCR, "QuantityRejected")
            Me.txtReportedBy.DataBindings.Add("Text", Me.bsNCR, "ReportedBy")
            Me.cboTypeOfError.DataBindings.Add("Text", Me.bsNCR, "TypeOfError")
            Me.cboDispositionType.DataBindings.Add("Text", Me.bsNCR, "DispositionType")
            Me.rtxtDispositionNotes.DataBindings.Add("Text", Me.bsNCR, "StatusNotes")
            Me.lblDateClosed.DataBindings.Add("Text", Me.bsNCR, "DateClosed")
            Me.chkNone.DataBindings.Add("Checked", Me.bsNCR, "None")
            Me.chkNotify.DataBindings.Add("Checked", Me.bsNCR, "NotifyCustomer")
            Me.chkWriteCAR.DataBindings.Add("Checked", Me.bsNCR, "WriteCAR")
            Me.chkWriteSCAR.DataBindings.Add("Checked", Me.bsNCR, "WriteSCAR")
            Me.chkWriteCPAR.DataBindings.Add("Checked", Me.bsNCR, "WriteCPAR")
            Me.chkOther.DataBindings.Add("Checked", Me.bsNCR, "Other")
            Me.rtxtAdditionalActionNotes.DataBindings.Add("Text", Me.bsNCR, "Notes")
            Me.cboResponsibleDept.DataBindings.Add("Text", Me.bsNCR, "ResponsibleDept")
            Me.txtResponsiblePerson.DataBindings.Add("Text", Me.bsNCR, "ResponsiblePerson")
            Me.txtCause.DataBindings.Add("Text", Me.bsNCR, "Cause")
            Me.txtCost.DataBindings.Add("Text", Me.bsNCR, "Cost")
            Me.txtCustomerNCRNum.DataBindings.Add("Text", Me.bsNCR, "CustomerNCRNum")
            Me.txtMaterialReturnAuthNum.DataBindings.Add("Text", Me.bsNCR, "MaterialReturnAuthNum")
            Me.txtSalesOrderNum.DataBindings.Add("Text", Me.bsNCR, "SalesOrderNum")
            Me.dtpReturnDt.DataBindings.Add("Text", Me.bsNCR, "ReturnDate")
            Me.txtTotalQuantity.DataBindings.Add("Text", Me.bsNCR, "TotalQuantity")
            Me.txtSupplierPurchaseOrder.DataBindings.Add("Text", Me.bsNCR, "SupplierPurchaseOrderNum")
            'Me.cboCostIsSignificant.DataBindings.Add("Text", Me.bsNCR, "CostIsSignificant")
            ' Me.dtOriginatorDate.DataBindings.Add("Value", Me.BindingSource1, "OriginatorDate")

            Me.cboPrograms.DataBindings.Add("Text", Me.bsNCR, "Program")
            Me.txtSerialNum.DataBindings.Add("Text", Me.bsNCR, "SerialNum")
            Me.cboSerialNumType.DataBindings.Add("Text", Me.bsNCR, "SerialNumType")
            Me.txtAircraftIdentifier.DataBindings.Add("Text", Me.bsNCR, "AircraftIdentifier")
            Me.txtDrawingNum.DataBindings.Add("Text", Me.bsNCR, "DrawingNumber")
            Me.cboRev.DataBindings.Add("Text", Me.bsNCR, "DwgRevision")
            Me.txtPartNumber.DataBindings.Add("Text", Me.bsNCR, "PartNumber")
            Me.txtPartDescription.DataBindings.Add("Text", Me.bsNCR, "PartDescription")
            Me.cboWorkOrder.DataBindings.Add("Text", Me.bsNCR, "WorkOrder")
            Me.cboStep.DataBindings.Add("Text", Me.bsNCR, "StepWorkOrder")
            Me.txtPurchaseOrder.DataBindings.Add("Text", Me.bsNCR, "PurchaseOrderNum")
            Me.rtxtDiscrepancy.DataBindings.Add("Text", Me.bsNCR, "Discrepancy")
            Me.rtxtComments.DataBindings.Add("Text", Me.bsNCR, "Comments")

            'Me.txtAbortedReason.DataBindings.Add("Text", Me.bsNCR, "AbortedReason")

        End If
    End Function

    Public Function SearchSteps()

        Dim SqlString As String
        Dim cmdSave As String

        Me.DsStepsOfNCR1.tblNCRSteps.Clear()

        Me.txtStep.DataBindings.Clear()
        Me.rtxtDisposition.DataBindings.Clear()
        'Me.rtxtReSubmitReason.DataBindings.Clear()
        Me.rtxtResubmitSelectedRow.DataBindings.Clear()
        Me.txtAcceptedStep.DataBindings.Clear()


        SqlString = " Where NCRNumber = '" & NCRNumber & "' Order By RecordID Desc"

        cmdSave = Me.daSteps.SelectCommand.CommandText
        Me.daSteps.SelectCommand.CommandText() += SqlString


        Try
            Me.daSteps.Fill(DsStepsOfNCR1.tblNCRSteps)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.daSteps.SelectCommand.CommandText = cmdSave

        If Me.DsStepsOfNCR1.Tables("tblNCRSteps").Rows.Count <> 0 Then

            'Create DataBindings
            ' Me.txtRecordID.DataBindings.Add("Text",
            ' Me.BindingSource1, "RecordID")
            Me.txtStep.DataBindings.Add("Text", Me.bsSteps, "Step")
            Me.rtxtDisposition.DataBindings.Add("Text", Me.bsSteps, "Disposition")
            'Me.rtxtReSubmitReason.DataBindings.Add("Text", Me.bsSteps, "ResubmittedReason")
            Me.rtxtResubmitSelectedRow.DataBindings.Add("Text", Me.bsSteps, "ResubmittedReason")
            Me.txtAcceptedStep.DataBindings.Add("Text", Me.bsSteps, "AcceptedStep")
            ' Me.chkIncorpRedLineNo.DataBindings.Add("Checked",
            'Me.BindingSource1, "IncorpRedLineNo")
            ' Me.dtOriginatorDate.DataBindings.Add("Value",
            'Me.BindingSource1, "OriginatorDate")

        End If
    End Function

    Public Function SearchEngineersMRBs()

        Dim SqlString As String
        Dim cmdSave As String

        Me.DsEngineersMRBs1.tblNCRStepsSignOff.Clear()

        Me.txtRecordIDSignOff.DataBindings.Clear()
        Me.txtEngineer.DataBindings.Clear()
        Me.txtMRB.DataBindings.Clear()
        Me.txtIsSignedOff.DataBindings.Clear()

        'SqlString = " Where Step = '" & txtStep.Text & "'"
        SqlString = " Where NCRNumber = '" & NCRNumber & "' Order By RecordID Desc"

        cmdSave = Me.daEngineersMRBs.SelectCommand.CommandText
        Me.daEngineersMRBs.SelectCommand.CommandText() += SqlString


        Try
            Me.daEngineersMRBs.Fill(DsEngineersMRBs1.tblNCRStepsSignOff)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.daEngineersMRBs.SelectCommand.CommandText = cmdSave

        If Me.DsEngineersMRBs1.Tables("tblNCRStepsSignOff").Rows.Count <> 0 Then

            'Create DataBindings
            Me.txtRecordIDSignOff.DataBindings.Add("Text",
            Me.bsEngineersMRBs, "RecordID")
            Me.txtEngineer.DataBindings.Add("Text",
            Me.bsEngineersMRBs, "Engineer")
            Me.txtMRB.DataBindings.Add("Text",
            Me.bsEngineersMRBs, "MRB")
            Me.txtIsSignedOff.DataBindings.Add("Text",
           Me.bsEngineersMRBs, "SignOffDt")
            ' Me.chkIncorpRedLineNo.DataBindings.Add("Checked",
            'Me.BindingSource1, "IncorpRedLineNo")
            ' Me.dtOriginatorDate.DataBindings.Add("Value",
            'Me.BindingSource1, "OriginatorDate")

        End If
    End Function

    Private Sub btnAcceptStepOne_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

        RowSelectedSteps = GridView2.FocusedRowHandle

        If LatestStep = 1 Then
            If isSuperUser = "True" Or isQAManager = "True" Or isNCRAdmin = "T" Then
                'Nothing
            Else
                MsgBox("Cannot accept disposition 1 if not a QA")
                Exit Sub
            End If

        ElseIf LatestStep = 2 Then
            If ValidateOtherInfoTab() = False Then
                Exit Sub
            End If

            If isSuperUser = "True" Or isQAManager = "True" Or isEngineerNCR = "T" Or isProdMgr = "True" Or isProgramMgr = "True" Or isDAO = "True" Or isLeadEngineerNCR = "True" Or isStress = "T" Or isDesign = "True" Or isLiaisonNCR = "T" Or isNCRAdmin = "T" Then
                'Nothing
            Else
                MsgBox("Cannot accept disposition 2 if not a QA or engineer or MRB")
                Exit Sub
            End If

        ElseIf LatestStep = 3 Then
            If isSuperUser = "True" Or isQAManager = "True" Or isEngineerNCR = "T" Or isProdMgr = "True" Or isProgramMgr = "True" Or isDAO = "True" Or isLeadEngineerNCR = "True" Or isStress = "T" Or isDesign = "True" Or isLiaisonNCR = "T" Or isNCRAdmin = "T" Then
                'Nothing
            Else
                MsgBox("Cannot accept disposition 3 if not a QA or engineer or MRB")
                Exit Sub
            End If

        ElseIf LatestStep = 4 Then
            If isSuperUser = "True" Or isOperationsNCR = "T" Or isQAManager = "True" Or isProdSupervisor = "True" Or isNCRAdmin = "T" Or isProgramMgr = "True" Then
                'Nothing
            Else
                MsgBox("Cannot accept disposition 4 if not a QA or Operations or Prod Supervisor or Program Manager")
                Exit Sub
            End If

        ElseIf LatestStep = 5 Then
            If isSuperUser = "True" Or isQAManager = "True" Or isQC = "True" Or isCloseNCR = "True" Or isNCRAdmin = "T" Then
                'Nothing
            Else
                MsgBox("Cannot accept disposition 5 if not a QA or QC or CloseNCR")
                Exit Sub
            End If
        End If


        'If LatestStep <> 1 Then
        '    MsgBox("This button can only be used when step is at 1")
        '    Exit Sub
        'End If

        'If IsDBNull(AcceptedStep) Then
        '    'Nothing
        'ElseIf AcceptedStep = "1" Then
        '    MsgBox("Step 1 was already accepted")
        '    Exit Sub
        'End If

        If IsDBNull(AcceptedStep) Or AcceptedStep = "" Then
            'Nothing
        Else
            MsgBox("disposition was already accepted")
            Exit Sub
        End If


        ''Check there is at least one engineer to sign off
        'da = New SqlClient.SqlDataAdapter("Select * From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And Engineer != '' And Engineer Is Not Null And (SignOffDt = '' Or SignOffDt Is Null) Order By RecordID Desc", SqlConnection1)  'And Status != 'Aborted' And Status != 'Closed'
        'da.Fill(ds, "AtLeastOneEngineer")

        'If ds.Tables("AtLeastOneEngineer").Rows.Count < 1 Then
        '    MsgBox("You must enter at least one engineer")
        '    Exit Sub
        'Else
        '    ds.Tables("AtLeastOneEngineer").Clear()
        '    ds.Tables("AtLeastOneEngineer").Dispose()
        'End If

        ''Check there is at least one MRB to sign off
        'da = New SqlClient.SqlDataAdapter("Select * From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And MRB != '' And MRB Is Not Null And (SignOffDt = '' Or SignOffDt Is Null) Order By RecordID Desc", SqlConnection1)    'And Status != 'Aborted' And Status != 'Closed'
        'da.Fill(ds, "AtLeastOneMRB")

        'If ds.Tables("AtLeastOneMRB").Rows.Count < 1 Then
        '    MsgBox("You must enter at least one MRB")
        '    Exit Sub
        'Else
        '    ds.Tables("AtLeastOneMRB").Clear()
        '    ds.Tables("AtLeastOneMRB").Dispose()
        'End If



        'Check engineers and MRBs signed off
        If CheckAllEngineersSignedOff() = False Or CheckAllMRBsSignedOff() = False Then
            Exit Sub
        End If


        'Disposition of last Step must be populated with something before signing off the Engineer/MRB
        da = New SqlClient.SqlDataAdapter("Select * From tblNCRSteps Where NCRNumber = '" & NCRNumber & "' And Status != 'Aborted' And Status != 'Closed' Order By RecordID Desc", SqlConnection1)
        da.Fill(ds, "IsDispositionEntered")

        Dim LastDisposition As String = ds.Tables("IsDispositionEntered").Rows(0).Item("Disposition")

        If LastDisposition = "" Then
            MsgBox("The Disposition text must be entered and saved before signing off the selected disposition " & ActualStep)
            rtxtDisposition.Focus()
            ds.Tables("IsDispositionEntered").Clear()
            ds.Tables("IsDispositionEntered").Dispose()
            Exit Sub
        End If

        ds.Tables("IsDispositionEntered").Clear()
        ds.Tables("IsDispositionEntered").Dispose()



        ''Disposition of Selected Step for Actual Step = 1 must be populated with something
        'If ActualStep = "1" Then
        '    If rtxtDisposition.Text = "" Then
        '        MsgBox("You need to enter Disposition for Step 1")
        '        rtxtDisposition.Focus()
        '        Exit Sub
        '    End If
        'End If


        'Advise the user if there were no Engineers/MRBs added and in that case if it wants to add one first before accepting the disposition
        If CheckThereWereAnyEngineersMRBsAdded() = False Then
            If MsgBox("There were no Engineers/MRBs added for the latest disposition. Would you like to add one before accepting the disposition?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Exit Sub
            End If
        End If


        u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRSteps SET AcceptedStep = '" & LatestStep & "', LatestStep = '" & LatestStep & "', Step = '" & LatestStep & "', AcceptedBy = '" & User & "', AcceptedByDt = '" & Now & "', Disposition = '" & rtxtDisposition.Text & "', IsStepAccepted = 'Accepted' Where NCRNumber = '" & NCRNumber & "' And ActualStep = '" & ActualStep & "'")
        'AcceptedStep = 1
        AcceptedStep = LatestStep

        'Save who signed off
        u.ExecuteSQL(SqlConnection1, "Insert Into tblUsersWhoSignedOff (Username,SignOffDt,Email,NCRNumber,Status,Step,ActualStep) Values ('" & User & "', '" & Now & "', '" & EmailUsername & "', '" & NCRNumber & "', 'Open','" & LatestStep & "', '" & ActualStep & "')")


        If LatestStep = 2 Then
            If isSuperUser = "True" Or isQC = "True" Or isQAManager = "True" Or isNCRAdmin = "T" Then
                'Nothing
            Else
                DisableOtherInfoControls()
            End If
        End If


        rtxtAddDisposition.Text = ""
        'rtxtReSubmitReason.Text = ""
        'rtxtDisposition.ReadOnly = True

        SearchSteps()
        SearchEngineersMRBs()


        GridView2.FocusedRowHandle = RowSelectedSteps
        GridView2.SelectRow(RowSelectedSteps)
    End Sub

    'Private Sub btnAcceptStepTwo_Click(sender As Object, e As EventArgs) Handles btnAcceptStepTwo.Click

    '    RowSelectedSteps = GridView2.FocusedRowHandle

    '    If isSuperUser = "True" Or isEngineerNCR = "T" Or isQAManager = "True" Or isNCRAdmin = "T" Then

    '        If LatestStep <> 2 Then
    '            MsgBox("This button can only be used when step is at 2")
    '            Exit Sub
    '        End If

    '        If IsDBNull(AcceptedStep) Then
    '            'Nothing
    '        ElseIf AcceptedStep = "2" Then
    '            MsgBox("Step 2 was already accepted")
    '            Exit Sub
    '        End If


    '        If ValidateOtherInfoTab() = False Then
    '            Exit Sub
    '        End If


    '        'Check there is at least one engineer to sign off
    '        da = New SqlClient.SqlDataAdapter("Select * From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And Engineer != '' And Engineer Is Not Null And (SignOffDt = '' Or SignOffDt Is Null) Order By RecordID Desc", SqlConnection1)  'And Status != 'Aborted' And Status != 'Closed'
    '        da.Fill(ds, "AtLeastOneEngineer")

    '        If ds.Tables("AtLeastOneEngineer").Rows.Count < 1 Then
    '            MsgBox("You must enter at least one engineer")
    '            ds.Tables("AtLeastOneEngineer").Clear()
    '            ds.Tables("AtLeastOneEngineer").Dispose()
    '            Exit Sub
    '        End If

    '        u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRSteps SET AcceptedStep = 2, LatestStep = '" & LatestStep & "', Step = '" & LatestStep & "', AcceptedBy = '" & User & "', AcceptedByDt = '" & Now & "' Where NCRNumber = '" & NCRNumber & "' And ActualStep = '" & ActualStep & "'")
    '        AcceptedStep = 2

    '        'Save who signed off
    '        u.ExecuteSQL(SqlConnection1, "Insert Into tblUsersWhoSignedOff (Username,SignOffDt,Email,NCRNumber,Status,Step,ActualStep) Values ('" & User & "', '" & Now & "', '" & EmailUsername & "', '" & NCRNumber & "', 'Open','2', '" & ActualStep & "')")

    '        rtxtAddDisposition.Text = ""

    '    Else
    '        MsgBox("Cannot accept step 2 if you do not have Engineer permission or QA")
    '        Exit Sub
    '    End If


    '    SearchSteps()
    '    SearchEngineersMRBs()


    '    If isSuperUser = "True" Or isQC = "True" Or isQAManager = "True" Or isNCRAdmin = "T" Then
    '        'Nothing
    '    Else
    '        DisableOtherInfoControls()
    '    End If


    '    GridView2.FocusedRowHandle = RowSelectedSteps
    '    GridView2.SelectRow(RowSelectedSteps)
    'End Sub

    'Private Sub btnAcceptStepThree_Click(sender As Object, e As EventArgs) Handles btnAcceptStepThree.Click

    '    RowSelectedSteps = GridView2.FocusedRowHandle

    '    If isSuperUser = "True" Or isQAManager = "True" Or isProdMgr = "True" Or isProgramMgr = "True" Or isDAO = "True" Or isLeadEngineerNCR = "True" Or isStress = "T" Or isDesign = "True" Or isLiaisonNCR = "T" Or isNCRAdmin = "T" Then

    '        If LatestStep <> 3 Then
    '            MsgBox("This button can only be used when step is at 3")
    '            Exit Sub
    '        End If

    '        If IsDBNull(AcceptedStep) Then
    '            'Nothing
    '        ElseIf AcceptedStep = "3" Then
    '            MsgBox("Step 3 was already accepted")
    '            Exit Sub
    '        End If

    '        'Check there is at least one MRB to sign off
    '        da = New SqlClient.SqlDataAdapter("Select * From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And MRB != '' And MRB Is Not Null And (SignOffDt = '' Or SignOffDt Is Null) Order By RecordID Desc", SqlConnection1)    'And Status != 'Aborted' And Status != 'Closed'
    '        da.Fill(ds, "AtLeastOneMRB")

    '        If ds.Tables("AtLeastOneMRB").Rows.Count < 1 Then
    '            MsgBox("You must enter at least one MRB")
    '            ds.Tables("AtLeastOneMRB").Clear()
    '            ds.Tables("AtLeastOneMRB").Dispose()
    '            Exit Sub
    '        End If

    '        GetRecordIDLatestStep()

    '        u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRSteps SET AcceptedStep = 3, LatestStep = '" & LatestStep & "', Step = '" & LatestStep & "', AcceptedBy = '" & User & "', AcceptedByDt = '" & Now & "' Where NCRNumber = '" & NCRNumber & "' And ActualStep = '" & ActualStep & "' And RecordID = '" & LastRecordID & "'")
    '        AcceptedStep = 3

    '        'Save who signed off
    '        u.ExecuteSQL(SqlConnection1, "Insert Into tblUsersWhoSignedOff (Username,SignOffDt,Email,NCRNumber,Status,Step,ActualStep) Values ('" & User & "', '" & Now & "', '" & EmailUsername & "', '" & NCRNumber & "', 'Open','3', '" & ActualStep & "')")

    '        rtxtAddDisposition.Text = ""

    '    Else
    '        MsgBox("Cannot accept step 3 if not one of the MRBs roles or QA")
    '        Exit Sub
    '    End If


    '    SearchSteps()
    '    SearchEngineersMRBs()

    '    GridView2.FocusedRowHandle = RowSelectedSteps
    '    GridView2.SelectRow(RowSelectedSteps)
    'End Sub

    'Private Sub btnAcceptStepFour_Click(sender As Object, e As EventArgs) Handles btnAcceptStepFour.Click

    '    RowSelectedSteps = GridView2.FocusedRowHandle

    '    If isSuperUser = "True" Or isOperationsNCR = "T" Or isQAManager = "True" Or isProdSupervisor = "True" Or isNCRAdmin = "T" Or isProgramMgr = "True" Then

    '        If LatestStep <> 4 Then
    '            MsgBox("This button can only be used when step is at 4")
    '            Exit Sub
    '        End If

    '        If IsDBNull(AcceptedStep) Then
    '            'Nothing
    '        ElseIf AcceptedStep = "4" Then
    '            MsgBox("Step 4 was already accepted")
    '            Exit Sub
    '        End If


    '        'If CheckAllEngineersSignedOff() = False Or CheckAllMRBsSignedOff() = False Then
    '        '    Exit Sub
    '        'End If

    '        GetRecordIDLatestStep()

    '        u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRSteps SET AcceptedStep = 4, LatestStep = '" & LatestStep & "', Step = '" & LatestStep & "', AcceptedBy = '" & User & "', AcceptedByDt = '" & Now & "' Where NCRNumber = '" & NCRNumber & "' And ActualStep = '" & ActualStep & "' And RecordID = '" & LastRecordID & "'")
    '        AcceptedStep = 4

    '        'Save who signed off
    '        u.ExecuteSQL(SqlConnection1, "Insert Into tblUsersWhoSignedOff (Username,SignOffDt,Email,NCRNumber,Status,Step,ActualStep) Values ('" & User & "', '" & Now & "', '" & EmailUsername & "', '" & NCRNumber & "', 'Open','4', '" & ActualStep & "')")

    '        rtxtAddDisposition.Text = ""

    '    Else
    '        MsgBox("Cannot accept step 4 if not Operations or Production Supervisor or QA")
    '        Exit Sub
    '    End If


    '    SearchSteps()
    '    SearchEngineersMRBs()

    '    GridView2.FocusedRowHandle = RowSelectedSteps
    '    GridView2.SelectRow(RowSelectedSteps)
    'End Sub

    Private Sub btnCloseNCR_Click(sender As Object, e As EventArgs) Handles btnCloseNCR.Click

        RowSelectedSteps = GridView2.FocusedRowHandle

        If isSuperUser = "True" Or isQAManager = "True" Or isQC = "True" Or isCloseNCR = "True" Or isNCRAdmin = "T" Then

            'If LatestStep <> 5 Then
            '    MsgBox("This button can only be used when step is at 5")
            '    Exit Sub
            'End If

            'If IsDBNull(AcceptedStep) Then
            '    'Nothing
            'ElseIf AcceptedStep = "5" Then
            '    MsgBox("Step 5 was already accepted")
            '    Exit Sub
            'End If



            If CheckAllMRBsSignedOff() = False Or CheckAllEngineersSignedOff() = False Then
                Exit Sub
            End If


            'The last step must be accepted before closing the NCR
            If LatestStep = AcceptedStep Then
                'Nothing
            Else
                MsgBox("You must accept the last disposition before closing the NCR")
                Exit Sub
            End If


            'If fields Program, DrawNum, Step, WorkOrder and Rev in the Discrepancy tab are empty advise the user if it wants to enter them
            If CheckDiscrepancyTabItemsAreEntered() = True Then
                Exit Sub
            End If


            'If MsgBox("Do you want to close?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            GetRecordIDLatestStep()


            u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRSteps SET AcceptedStep = '" & AcceptedStep & "', LatestStep = '" & LatestStep & "', Step = '" & LatestStep & "', ClosedBy = '" & User & "', DateClosed = '" & Now & "', AcceptedBy = '" & User & "', AcceptedByDt = '" & Now & "', IsStepAccepted = 'Closed', Status = 'Closed' Where NCRNumber = '" & NCRNumber & "' And ActualStep = '" & ActualStep & "' And RecordID = '" & LastRecordID & "'")
            u.ExecuteSQL(SqlConnection1, "UPDATE tblNCR SET Status = 'Closed', ClosedBy = '" & User & "', DateClosed = '" & Now & "' Where NCRNumber = '" & NCRNumber & "'")

            'Save who signed off
            u.ExecuteSQL(SqlConnection1, "Insert Into tblUsersWhoSignedOff (Username,SignOffDt,Email,NCRNumber,Status,Step,ActualStep) Values ('" & User & "', '" & Now & "', '" & EmailUsername & "', '" & NCRNumber & "', 'Closed','" & LatestStep & "', '" & ActualStep & "')")

            NCRIsClosed = "Yes"

            DisableControls()
            DisableOtherInfoControls()
            DisableAttachmentsControls()

            SendNotifications("Closed")
            SendNotifications("ClosedTwo")
            SendNotifications("Engineers")
            SendNotifications("MRBs")

            'Else
            ''Get RecordID of last record before adding a new one so that this last record can be updated
            'GetRecordIDLatestStep()

            '    'ActualStep = LatestStep + 1
            '    ActualStep = ActualStep + 1
            '    u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRSteps SET DateClosed = '" & Now & "', AcceptedStep = 5, AcceptedBy = '" & User & "', AcceptedByDt = '" & Now & "' Where RecordID = '" & LastRecordID & "' And NCRNumber = '" & NCRNumber & "' And Step = '5'")
            '    u.ExecuteSQL(SqlConnection1, "Insert Into tblNCRSteps (LatestStep,ActualStep,AcceptedStep,Step,Status,NCRNumber,SubmissionDt) Values (1, '" & ActualStep & "', NULL, '1', 'Open','" & NCRNumber & "','" & Now & "')")
            '    'u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRStepsSignOff SET SignOffDt = Null, SignOffUserEng = '', SignOffUserMRB = '' Where NCRNumber = '" & NCRNumber & "'")
            '    u.ExecuteSQL(SqlConnection1, "UPDATE tblNCR SET LatestStep = '1', ActualStep = '" & ActualStep & "', Step = '1' Where NCRNumber = '" & NCRNumber & "'")

            '    'Save who signed off
            '    u.ExecuteSQL(SqlConnection1, "Insert Into tblUsersWhoSignedOff (Username,SignOffDt,Email,NCRNumber,Status,Step,ActualStep) Values ('" & User & "', '" & Now & "', '" & EmailUsername & "', '" & NCRNumber & "', 'Open','5', '" & ActualStep & "')")

            '    SendNotifications("Step1")

            '    EnableOtherInfoControls()
            'End If


            'AcceptedStep = 5

            rtxtAddDisposition.Text = ""
            'rtxtReSubmitReason.Text = ""

        Else
            MsgBox("Cannot close NCR as you do not have CloseNCR permission or are a QA or QC")
            Exit Sub
        End If


        Search()
        SearchSteps()
        SearchEngineersMRBs()


        GridView2.FocusedRowHandle = RowSelectedSteps
        GridView2.SelectRow(RowSelectedSteps)
    End Sub

    Private Sub btnAddStep_Click(sender As Object, e As EventArgs) Handles btnAddStep.Click
        Dim StatusNCR As String = ""


        'Get LatestStep, ActualStep and AcceptedStep of NCR
        da = New SqlClient.SqlDataAdapter("Select * From tblNCRSteps Where NCRNumber = '" & NCRNumber & "' And Status != 'Aborted' And Status != 'Closed' Order By RecordID Desc", SqlConnection1)
        da.Fill(ds, "StepsData")

        If ds.Tables("StepsData").Rows.Count > 0 Then
            LatestStep = ds.Tables("StepsData").Rows(0).Item("LatestStep")
            ActualStep = ds.Tables("StepsData").Rows(0).Item("ActualStep")
            If IsDBNull(ds.Tables("StepsData").Rows(0).Item("AcceptedStep")) Then
                AcceptedStep = ""
            Else
                AcceptedStep = ds.Tables("StepsData").Rows(0).Item("AcceptedStep")
            End If

            ds.Tables("StepsData").Clear()
            ds.Tables("StepsData").Dispose()
        End If


        'Cannot add another step if the latest one is not accepted first
        If AcceptedStep = "" Or IsDBNull(AcceptedStep) Then
            MsgBox("disposition cannot be added. Latest disposition must be accepted first.")
            Exit Sub
        End If


        'Enter Re-Submit Reason
        Dim frmNCRReSubmitReason As New frmNCRReSubmitReason
        frmNCRReSubmitReason.ShowDialog()

        If ReSubmitReason = "" Then
            MsgBox("Re-Submit Reason was not entered. Click on Re-Submit button again.")
            Exit Sub
        End If


        ''Add Disposition before adding another step
        'If rtxtAddDisposition.Text = "" Then
        '    MsgBox("You must enter the Disposition before adding a step")
        '    Exit Sub
        'End If

        ''Add Resubmit Reason before adding another step
        'If rtxtReSubmitReason.Text = "" Then
        '    MsgBox("Please enter re-submit reason")
        '    Exit Sub
        'End If


        ''Check there is at least one engineer to sign off for locations other than Calgary
        ''If isCalgary <> "Yes" Then     'TO ADD: uncomment this line and matching End If for NCR Point 1
        'da = New SqlClient.SqlDataAdapter("Select * From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And Engineer != '' And Engineer Is Not Null And (SignOffDt = '' Or SignOffDt Is Null) Order By RecordID Desc", SqlConnection1)  'And Status != 'Aborted' And Status != 'Closed'
        'da.Fill(ds, "AtLeastOneEngineer")

        'If ds.Tables("AtLeastOneEngineer").Rows.Count < 1 Then
        '    MsgBox("You must enter at least one engineer that is not signed off")
        '    Exit Sub
        'Else
        '    ds.Tables("AtLeastOneEngineer").Clear()
        '    ds.Tables("AtLeastOneEngineer").Dispose()
        'End If
        ''End If

        ''Check there is at least one MRB to sign off
        'da = New SqlClient.SqlDataAdapter("Select * From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And MRB != '' And MRB Is Not Null And (SignOffDt = '' Or SignOffDt Is Null) Order By RecordID Desc", SqlConnection1)    'And Status != 'Aborted' And Status != 'Closed'
        'da.Fill(ds, "AtLeastOneMRB")

        'If ds.Tables("AtLeastOneMRB").Rows.Count < 1 Then
        '    MsgBox("You must enter at least one MRB that is not signed off")
        '    Exit Sub
        'Else
        '    ds.Tables("AtLeastOneMRB").Clear()
        '    ds.Tables("AtLeastOneMRB").Dispose()
        'End If



        'Add Step        
        Select Case LatestStep

            Case 1
                If isSuperUser = "True" Or isQAManager = "True" Or isNCRAdmin = "T" Then

                    LatestStep += 1
                    ActualStep += 1
                    StatusNCR = "Disposition 2"

                    SendNotifications("Step2")

                Else
                    MsgBox("You cannot add a disposition if you are not a QA")
                    Exit Sub
                End If

            Case 2
                If isSuperUser = "True" Or isQAManager = "True" Or isEngineerNCR = "T" Or isProdMgr = "True" Or isProgramMgr = "True" Or isDAO = "True" Or isLeadEngineerNCR = "True" Or isStress = "T" Or isDesign = "True" Or isLiaisonNCR = "T" Or isNCRAdmin = "T" Then

                    LatestStep += 1
                    ActualStep += 1
                    StatusNCR = "Disposition 3"

                    SendNotifications("Step3")

                Else
                    MsgBox("You cannot add a disposition if you are not an Engineer or MRB or QA")
                    Exit Sub
                End If

            Case 3
                If isSuperUser = "True" Or isQAManager = "True" Or isEngineerNCR = "T" Or isProdMgr = "True" Or isProgramMgr = "True" Or isDAO = "True" Or isLeadEngineerNCR = "True" Or isStress = "T" Or isDesign = "True" Or isLiaisonNCR = "T" Or isNCRAdmin = "T" Then

                    'If CheckAllMRBsSignedOff() = False Or CheckAllEngineersSignedOff() = False Then
                    '    Exit Sub
                    'End If

                    LatestStep += 1
                    ActualStep += 1
                    StatusNCR = "Disposition 4"

                    SendNotifications("Step4")

                Else
                    MsgBox("You cannot add a disposition if you are not one of the MRBs or Engineer or QA")
                    Exit Sub
                End If

            Case 4
                If isSuperUser = "True" Or isOperationsNCR = "T" Or isQAManager = "True" Or isNCRAdmin = "T" Then

                    LatestStep += 1
                    ActualStep += 1
                    StatusNCR = "Disposition 5"

                    SendNotifications("Step5")

                Else
                    MsgBox("You cannot add a disposition if you are not Operations or QA")
                    Exit Sub
                End If

            Case 5
                'MsgBox("You cannot add another step after step 5")
                'Exit Sub

                If isSuperUser = "True" Or isQAManager = "True" Or isNCRAdmin = "T" Then

                    LatestStep = 1
                    ActualStep += 1
                    StatusNCR = "Disposition 1"

                    SendNotifications("Step1")

                Else
                    MsgBox("You cannot add a disposition if you are not a QA")
                    Exit Sub
                End If

                EnableOtherInfoControls()
        End Select


        u.ExecuteSQL(SqlConnection1, "Insert Into tblNCRSteps (LatestStep,ActualStep,AcceptedStep,Step,Status,NCRNumber,SubmissionDt,OriginatorName,AddedBy,AddedByDt,Disposition,SortForReport,IsStepAccepted) Values ('" & LatestStep & "', '" & ActualStep & "', NULL, '" & LatestStep & "', '" & StatusNCR & "','" & NCRNumber & "', '" & Now & "', '" & User & "', '" & User & "', '" & Now & "', '', 1, '')")    'Disposition,     , '" & rtxtAddDisposition.Text & "'
        u.ExecuteSQL(SqlConnection1, "UPDATE tblNCR SET LatestStep = '" & LatestStep & "', ActualStep = '" & ActualStep & "', Step = '" & LatestStep & "', Status = '" & StatusNCR & "' Where NCRNumber = '" & NCRNumber & "'")

        'Add the re-submit reason to the previous step
        u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRsteps SET ResubmittedReason = '" & ReSubmitReason & "', ResubmittedBy = '" & User & "', ResubmittedDt = '" & Now & "' Where NCRNumber = '" & NCRNumber & "' And ActualStep = " & ActualStep - 1 & "")

        AcceptedStep = ""
        rtxtAddDisposition.Text = ""
        ReSubmitReason = ""
        'rtxtReSubmitReason.Text = ""
        'rtxtDisposition.Enabled = False


        Search()
        SearchSteps() '" & LatestStep & "'
        SearchEngineersMRBs()
    End Sub

    Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click

        'RowSelectedSteps = GridView2.FocusedRowHandle

        If LatestStep = 1 Or LatestStep = 2 Then
            'Nothing
        Else
            MsgBox("You can only abort at disposition 1 or 2")
            Exit Sub
        End If

        'If txtAbortedReason.Text = "" Then
        '    MsgBox("Please enter abort reason")
        '    Exit Sub
        'End If


        'Enter Aborted Reason
        Dim frmNCRAbortReason As New frmNCRAbortReason
        frmNCRAbortReason.ShowDialog()

        If AbortedReason = "" Then
            MsgBox("Aborted Reason was not entered. Click on Abort button again.")
            Exit Sub
        End If


        If isSuperUser = "True" Or isQAManager = "True" Or isProdMgr = "True" Or isProgramMgr = "True" Or isDAO = "True" Or isNCRAdmin = "T" Then

            u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRSteps SET Status = 'Aborted', AbortedReason = '" & AbortedReason & "', AbortedBy = '" & User & "', AbortedDt = '" & Now & "' Where NCRNumber = '" & NCRNumber & "'")     ', Step = 'Aborted'
            u.ExecuteSQL(SqlConnection1, "UPDATE tblNCR SET Status = 'Aborted', Step = 'Aborted', DateClosed = '" & Now & "', AbortedReason = '" & AbortedReason & "', UsernameWhoAborted = '" & User & "', AbortedDt = '" & Now & "', AbortedBy = '" & User & "' Where NCRNumber = '" & NCRNumber & "'")

            'Set Status to Aborted for the usernames that were supposed to get a notification
            u.ExecuteSQL(SqlConnection1, "UPDATE tblUsersWhoSignedOff SET Status = 'Aborted' Where NCRNumber = '" & NCRNumber & "'")

            SendNotifications("Aborted")
            SendNotifications("AbortedTwo")
            SendNotifications("AbortedThree")
            SendNotifications("AbortedFour")

            rtxtAddDisposition.Text = ""

        Else
            MsgBox("Cannot abort if not a QA or MRB")
            Exit Sub
        End If


        Search()
        SearchSteps()
        SearchEngineersMRBs()

        DisableControls()
        DisableOtherInfoControls()
        DisableAttachmentsControls()

        AbortedReason = ""

        'GridView2.FocusedRowHandle = RowSelectedSteps
        'GridView2.SelectRow(RowSelectedSteps)
    End Sub

    Private Sub btnSignOff_Click(sender As Object, e As EventArgs) Handles btnSignOff.Click

        Dim isCalgaryAndAllSignedOff As String = ""

        RowSelectedSignOff = GridView3.FocusedRowHandle


        If txtIsSignedOff.Text <> "" Then
            MsgBox("Record has already been signed off")
            Exit Sub
        End If


        'Disposition of last Step must be populated with something before signing off the Engineer/MRB
        da = New SqlClient.SqlDataAdapter("Select * From tblNCRSteps Where NCRNumber = '" & NCRNumber & "' And Status != 'Aborted' And Status != 'Closed' Order By RecordID Desc", SqlConnection1)
        da.Fill(ds, "IsDispositionEntered")

        Dim LastDisposition As String = ds.Tables("IsDispositionEntered").Rows(0).Item("Disposition")

        If LastDisposition = "" Then
            MsgBox("The Disposition text must be entered and saved before signing off the selected disposition " & ActualStep)
            rtxtDisposition.Focus()
            ds.Tables("IsDispositionEntered").Clear()
            ds.Tables("IsDispositionEntered").Dispose()
            Exit Sub
        End If

        ds.Tables("IsDispositionEntered").Clear()
        ds.Tables("IsDispositionEntered").Dispose()




        'TO ADD: NCR Point 5; next 4 lines and matching End If
        ''If is Calgary and all engineers/MRBs added have signed off then do not validate if the user can signoff or not. Calgary can sign off without an engineer and/or MRB
        'If isCalgary = "Yes" And CheckAllEngineersSignedOff() = True And CheckAllMRBsSignedOff() = True Then '
        '    'Nothing
        '   isCalgaryAndAllSignedOff = "Yes"
        'Else

        'Only the engineer/mrb listed in the selected record can sign off as engineer or mrb
        If txtEngineer.Text <> "" Then
            If txtEngineer.Text <> User Then
                If isSuperUser <> "True" Then
                    If isNCRAdmin <> "T" Then
                        MsgBox("You cannot signoff for another engineer")
                        Exit Sub
                    End If
                End If
            End If

        ElseIf txtMRB.Text <> "" Then
            If txtMRB.Text <> User Then
                If isSuperUser <> "True" Then
                    If isNCRAdmin <> "T" Then
                        MsgBox("You cannot signoff for another MRB")
                        Exit Sub
                    End If
                End If
            End If

        Else
            Exit Sub
        End If

        'End If



        'TO ADD, MAYBE: NCR Point 5, next 4 lines and matching End If
        ''Do not need to update who signed off and the date of the signoff if it is Calgary and there are no engineers/MRBs to sign off
        'If isCalgaryAndAllSignedOff = "Yes" Then
        '    'Nothing
        'Else

        If isSuperUser = "True" Or isQAManager = "True" Or isEngineerNCR = "T" Or isProdMgr = "True" Or isProgramMgr = "True" Or isDAO = "True" Or isLeadEngineerNCR = "True" Or isStress = "T" Or isDesign = "True" Or isLiaisonNCR = "T" Or isNCRAdmin = "T" Then      '??????
            If txtEngineer.Text <> "" Then
                u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRStepsSignOff Set SignOffDt = '" & Now & "', SignOffUserEng = '" & Id & "' Where RecordID = '" & txtRecordIDSignOff.Text & "'")
                'Save who signed off
                u.ExecuteSQL(SqlConnection1, "Insert Into tblUsersWhoSignedOff (Username,SignOffDt,Email,NCRNumber,Status,Step,ActualStep) Values ('" & User & "', '" & Now & "', '" & EmailUsername & "', '" & NCRNumber & "', 'Open','" & LatestStep & "', '" & ActualStep & "')")

            ElseIf txtMRB.Text <> "" Then
                u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRStepsSignOff Set SignOffDt = '" & Now & "', SignOffUserMRB = '" & Id & "' Where RecordID = '" & txtRecordIDSignOff.Text & "'")

                'Save who signed off
                u.ExecuteSQL(SqlConnection1, "Insert Into tblUsersWhoSignedOff (Username,SignOffDt,Email,NCRNumber,Status,Step,ActualStep) Values ('" & User & "', '" & Now & "', '" & EmailUsername & "', '" & NCRNumber & "', 'Open','" & LatestStep & "', '" & ActualStep & "')")

                'Else
                '    u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRStepsSignOff Set SignOffDt = '" & Now & "', SignOffUserEng = '" & User & "', SignOffUserMRB = '" & User & "' Where RecordID = '" & txtRecordIDSignOff.Text & "'")

            Else
                MsgBox("Did not find engineer or mrb")
            End If
        Else
            MsgBox("Cannot sign off if not an Engineer or one of MRBs or a QA")
            Exit Sub
        End If

        'End If


        'TO ADD: NCR Point 2, next block of code
        ''Accept Step if all engineers and MRBs have signed off
        'If CheckAllEngineersSignedOff() = False Or CheckAllMRBsSignedOff() = False Then
        '    'Nothing
        'Else
        '    btnAccept.PerformClick()
        'End If


        SearchEngineersMRBs()

        GridView3.FocusedRowHandle = RowSelectedSignOff
        GridView3.SelectRow(RowSelectedSignOff)
    End Sub

    Private Sub GridView3_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView3.InitNewRow

        GridView3.SetRowCellValue(e.RowHandle, GridView3.Columns("Step"), LatestStep)
        GridView3.SetRowCellValue(e.RowHandle, GridView3.Columns("ActualStep"), ActualStep)
        GridView3.SetRowCellValue(e.RowHandle, GridView3.Columns("NCRNumber"), NCRNumber)

    End Sub

    Private Sub btnSaveAsEngineer_Click(sender As Object, e As EventArgs) Handles btnSaveAsEngineer.Click

        If isQAManager = "True" Or isSuperUser = "True" Or isEngineerNCR = "T" Or isProdMgr = "True" Or isDAO = "True" Or isLeadEngineerNCR = "True" Or isStress = "T" Or isDesign = "True" Or isLiaisonNCR = "T" Or isNCRAdmin = "T" Then

            'If LatestStep <> "2" And LatestStep <> "3" Then
            '    MsgBox("An engineer cannot be added if the latest step is not 2 or 3")
            '    Exit Sub
            'Else

            Try

                'Cannot Add an Engineer if there is not an open(not accepted) disposition
                da = New SqlClient.SqlDataAdapter("Select * From tblNCRSteps Where NCRNumber = '" & NCRNumber & "' And (AcceptedStep Is Null Or AcceptedStep = '') And Status != 'Aborted' And Status != 'Closed' Order By RecordID Desc", SqlConnection1)
                da.Fill(ds, "ThereIsAnOpenDisposition")

                If ds.Tables("ThereIsAnOpenDisposition").Rows.Count > 0 Then

                    Me.daEngineersMRBs.Update(DsEngineersMRBs1.tblNCRStepsSignOff)

                    SendNotifications("Engineers")

                    ds.Tables("ThereIsAnOpenDisposition").Clear()
                    ds.Tables("ThereIsAnOpenDisposition").Dispose()
                Else
                    MsgBox("Engineer cannot be added if you do not have an open disposition")
                    SearchEngineersMRBs()
                    Exit Sub
                End If




                '        u.ExecuteSQL(SqlConnection1, "Update tblNCRStepsSignOff Set SignOffUserEng = '" & User & "' Where (SignOffUserEng = '' Or SignOffUserEng Is Null) And NCRNumber = '" & NCRNumber & "' And Step = '" & LatestStep & "' And Engineer != '' And Engineer Is Not Null And ActualStep = '" & ActualStep & "'")
                '        'u.ExecuteSQL(SqlConnection1, "Insert Into tblNCRStepsSignOff (Step,ActualStep,Engineer,SignOffUserEng,SignOffDt,NCRNumber) Values ('" & LatestStep & "', '" & ActualStep & "', '" & txtEngineer.Text & "', '" & User & "', '" & Now & "', '" & NCRNumber & "')")

                MsgBox("Saved")

            Catch ex As Exception
                MessageBox.Show("An error occured after clicking on Save As Engineer." & vbLf & vbLf & ex.Message)
            End Try
            'End If

        Else
            MsgBox("Cannot add the engineer if you are not an Engineer or QA or Production Manager or DAO or Lead Engineer or Stress or Design or Liaison")
            Exit Sub
        End If


        SearchEngineersMRBs()
    End Sub

    Private Sub btnSaveEngineerMRB_Click(sender As Object, e As EventArgs) Handles btnSaveAsMRB.Click

        If isSuperUser = "True" Or isQAManager = "True" Or isProdMgr = "True" Or isProgramMgr = "True" Or isDAO = "True" Or isLeadEngineerNCR = "True" Or isStress = "T" Or isDesign = "True" Or isLiaisonNCR = "T" Or isNCRAdmin = "T" Then

            'If LatestStep <> "2" And LatestStep <> "3" Then
            '    MsgBox("A MRB cannot be added if the latest step is not 2 or 3")
            '    Exit Sub
            'Else

            Try

                'Cannot Add a MRB if there is not an open(not accepted) disposition
                da = New SqlClient.SqlDataAdapter("Select * From tblNCRSteps Where NCRNumber = '" & NCRNumber & "' And (AcceptedStep Is Null Or AcceptedStep = '') And Status != 'Aborted' And Status != 'Closed' Order By RecordID Desc", SqlConnection1)
                da.Fill(ds, "ThereIsAnOpenDisposition")

                If ds.Tables("ThereIsAnOpenDisposition").Rows.Count > 0 Then

                    Me.daEngineersMRBs.Update(DsEngineersMRBs1.tblNCRStepsSignOff)

                    SendNotifications("MRBs")

                    ds.Tables("ThereIsAnOpenDisposition").Clear()
                    ds.Tables("ThereIsAnOpenDisposition").Dispose()
                Else
                    MsgBox("MRB cannot be added if you do not have an open disposition")
                    SearchEngineersMRBs()
                    Exit Sub
                End If

                '        u.ExecuteSQL(SqlConnection1, "Update tblNCRStepsSignOff Set SignOffUserEng = '" & User & "' Where (SignOffUserEng = '' Or SignOffUserEng Is Null) And NCRNumber = '" & NCRNumber & "' And Step = '" & LatestStep & "' And Engineer != '' And Engineer Is Not Null And ActualStep = '" & ActualStep & "'")
                '        'u.ExecuteSQL(SqlConnection1, "Insert Into tblNCRStepsSignOff (Step,ActualStep,MRB,SignOffUserMRB,SignOffDt,NCRNumber) Values ('" & LatestStep & "', '" & ActualStep & "', '" & txtMRB.Text & "', '" & User & "', '" & Now & "', '" & NCRNumber & "')")

                MsgBox("Saved")

            Catch ex As Exception
                MessageBox.Show("An error occured after clicking on Save As MRB." & vbLf & vbLf & ex.Message)
            End Try
            'End If

        Else
            MsgBox("Cannot add a MRB if you are not a QA or Production Manager or Program Manager or DAO or LeadEngineer or Stress or Design or Liaison")
            Exit Sub
        End If


        SearchEngineersMRBs()
    End Sub

    Public Function CheckAllEngineersSignedOff()

        'da = New SqlClient.SqlDataAdapter("Select * From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And (SignOffUserEng = '' Or SignOffUserEng Is Null) Order By RecordID Desc", SqlConnection1)  'And Status != 'Aborted' And Status != 'Closed'
        da = New SqlClient.SqlDataAdapter("Select * From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And (SignOffDt = '' Or SignOffDt Is Null) And Engineer != '' And Engineer Is Not Null Order By RecordID Desc", SqlConnection1)  'And Status != 'Aborted' And Status != 'Closed'
        da.Fill(ds, "UnsignedEngineers")

        If ds.Tables("UnsignedEngineers").Rows.Count > 0 Then
            MsgBox("Not all engineers have signed off")
            ds.Tables("UnsignedEngineers").Clear()
            ds.Tables("UnsignedEngineers").Dispose()
            Return False
        Else
            Return True
        End If

    End Function

    Public Function CheckAllMRBsSignedOff()

        'da = New SqlClient.SqlDataAdapter("Select * From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And (SignOffUserMRB = '' Or SignOffUserMRB Is Null) Order By RecordID Desc", SqlConnection1)  'And Status != 'Aborted' And Status != 'Closed'
        da = New SqlClient.SqlDataAdapter("Select * From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And (SignOffDt = '' Or SignOffDt Is Null) And MRB != '' And MRB Is Not Null Order By RecordID Desc", SqlConnection1)  'And Status != 'Aborted' And Status != 'Closed'
        da.Fill(ds, "UnsignedMRBs")

        If ds.Tables("UnsignedMRBs").Rows.Count > 0 Then
            MsgBox("Not all MRBs have signed off")
            ds.Tables("UnsignedMRBs").Clear()
            ds.Tables("UnsignedMRBs").Dispose()
            Return False
        Else
            Return True
        End If

    End Function

    Public Function CheckThereWereAnyEngineersMRBsAdded()

        'Check if at least one engineer or one mrb was added for the latest step
        da = New SqlClient.SqlDataAdapter("Select * From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And ActualStep = '" & ActualStep & "' Order By RecordID Desc", SqlConnection1)  'And Status != 'Aborted' And Status != 'Closed'
        da.Fill(ds, "AtLeastOneEngMrb")

        If ds.Tables("AtLeastOneEngMrb").Rows.Count < 1 Then
            Return False
        Else
            ds.Tables("AtLeastOneEngMrb").Clear()
            ds.Tables("AtLeastOneEngMrb").Dispose()
            Return True
        End If

    End Function

    Public Function CheckDiscrepancyTabItemsAreEntered()
        Dim IsDataMissing As String = ""

        Dim errors As String = "You did not enter the following fields in the Discrepancy tab:" & Environment.NewLine & "" & Environment.NewLine & ""

        If Me.cboPrograms.Text = "" Then
            errors = errors + "Program" & Environment.NewLine & "" & Environment.NewLine & ""
            IsDataMissing = "Yes"
        End If

        If Me.txtDrawingNum.Text = "" Then
            errors = errors + "Drawing Number." & Environment.NewLine & "" & Environment.NewLine & ""
            IsDataMissing = "Yes"
        End If

        If Me.cboRev.Text = "" Then
            errors = errors + "Revision." & Environment.NewLine & "" & Environment.NewLine & ""
            IsDataMissing = "Yes"
        End If

        If Me.cboWorkOrder.Text = "" Or Not IsNumeric(cboWorkOrder.Text) Then
            If cboWorkOrder.Text <> "Unaffiliated" Then
                errors = errors + "Work Order (or select Unaffiliated)" & Environment.NewLine & "" & Environment.NewLine & ""
                IsDataMissing = "Yes"
            End If
        End If

        If Me.cboStep.Text = "" Or Not IsNumeric(cboStep.Text) Then
            If cboStep.Text <> "Unaffiliated" Then
                errors = errors + "Step (or select Unaffiliated)" & Environment.NewLine & "" & Environment.NewLine & ""
                IsDataMissing = "Yes"
            End If
        End If


        If IsDataMissing = "Yes" Then
            errors = errors + "Would you like to enter them?"

            If MsgBox(errors, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Return True
            Else
                Return False
            End If
        End If

    End Function

    Public Function DisableControls()

        btnAccept.Enabled = False
        'btnAcceptStepTwo.Enabled = False
        'btnAcceptStepThree.Enabled = False
        'btnAcceptStepFour.Enabled = False
        btnCloseNCR.Enabled = False
        btnAddStep.Enabled = False
        btnAbort.Enabled = False
        btnSignOff.Enabled = False
        btnSaveAsEngineer.Enabled = False
        btnSaveAsMRB.Enabled = False
        btnNotifyEngineers.Enabled = False
        btnNotifyMRBs.Enabled = False
        btnDeleteSelectedRecord.Enabled = False
        'btnReSubmit.Enabled = False
        'txtAbortedReason.Enabled = False
        btnSaveDisposition.Enabled = False

    End Function

    Public Function DisableAttachmentsControls()

        btnFileAttachSubmit.Enabled = False
        btnBrowse.Enabled = False
        btnSaveNew.Enabled = False
        btnDeleteAttachment.Enabled = False

    End Function

    Public Function DisableOtherInfoControls()

        cboType.Enabled = False
        cboWhereDiscovered.Enabled = False
        cboLocation.Enabled = False
        cboManufacturer.Enabled = False
        txtQuantityRejected.Enabled = False
        txtReportedBy.Enabled = False
        cboTypeOfError.Enabled = False
        cboDispositionType.Enabled = False
        rtxtDispositionNotes.Enabled = False
        groupboxAdditionalActions.Enabled = False
        rtxtAdditionalActionNotes.Enabled = False
        cboResponsibleDept.Enabled = False
        txtResponsiblePerson.Enabled = False
        txtCause.Enabled = False
        txtCost.Enabled = False
        txtCustomerNCRNum.Enabled = False
        txtMaterialReturnAuthNum.Enabled = False
        txtSalesOrderNum.Enabled = False
        dtpReturnDt.Enabled = False
        txtTotalQuantity.Enabled = False
        txtSupplierPurchaseOrder.Enabled = False
        'cboCostIsSignificant.Enabled = False
        btnSaveOtherInfo.Enabled = False

        'DISCREPANCY TAB
        cboPrograms.Enabled = False
        txtSerialNum.Enabled = False
        cboSerialNumType.Enabled = False
        txtAircraftIdentifier.Enabled = False
        txtDrawingNum.Enabled = False
        cboRev.Enabled = False
        txtPartNumber.Enabled = False
        txtPartDescription.Enabled = False
        cboWorkOrder.Enabled = False
        cboStep.Enabled = False
        txtPurchaseOrder.Enabled = False
        rtxtDiscrepancy.Enabled = False
        rtxtComments.Enabled = False
        btnSaveCreateTab.Enabled = False

    End Function

    Public Function EnableOtherInfoControls()

        cboType.Enabled = True
        cboWhereDiscovered.Enabled = True
        cboLocation.Enabled = True
        cboManufacturer.Enabled = True
        txtQuantityRejected.Enabled = True
        txtReportedBy.Enabled = True
        cboTypeOfError.Enabled = True
        rtxtDispositionNotes.Enabled = True
        rtxtAdditionalActionNotes.Enabled = True
        cboResponsibleDept.Enabled = True
        txtResponsiblePerson.Enabled = True
        txtCause.Enabled = True
        txtCost.Enabled = True
        txtCustomerNCRNum.Enabled = True
        txtMaterialReturnAuthNum.Enabled = True
        txtSalesOrderNum.Enabled = True
        dtpReturnDt.Enabled = True
        txtTotalQuantity.Enabled = True
        txtSupplierPurchaseOrder.Enabled = True
        'cboCostIsSignificant.Enabled = True
        btnSaveOtherInfo.Enabled = True

        'DISCREPANCY TAB
        cboPrograms.Enabled = True
        txtSerialNum.Enabled = True
        cboSerialNumType.Enabled = True
        txtAircraftIdentifier.Enabled = True
        txtDrawingNum.Enabled = True
        cboRev.Enabled = True
        txtPartNumber.Enabled = True
        txtPartDescription.Enabled = True
        cboWorkOrder.Enabled = True
        cboStep.Enabled = True
        txtPurchaseOrder.Enabled = True
        rtxtDiscrepancy.Enabled = True
        rtxtComments.Enabled = True
        btnSaveCreateTab.Enabled = True

        'Disable Disposition Type and Additional Actions if user is the Originator and it is not a QA/SuperUser/Admin
        If OriginatorName = User Then
            If isSuperUser <> "True" And isQAManager <> "True" And isNCRAdmin <> "T" Then
                groupboxAdditionalActions.Enabled = False
                cboDispositionType.Enabled = False
            Else
                groupboxAdditionalActions.Enabled = True
                cboDispositionType.Enabled = True
            End If
        Else
            groupboxAdditionalActions.Enabled = True
            cboDispositionType.Enabled = True
        End If

    End Function

    'Private Sub btnDeleteSelectedRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteSelectedRecord.Click

    '    If txtRecordIDSignOff.Text <> "" Then
    '        u.ExecuteSQL(SqlConnection1, "DELETE From tblNCRStepsSignOff Where RecordId = '" & txtRecordIDSignOff.Text & "'")
    '    End If

    '    SearchEngineersMRBs()
    'End Sub

    'Private Sub btnReSubmit_Click(sender As Object, e As EventArgs) Handles btnReSubmit.Click

    '    If isSuperUser = "True" Or isNCRAdmin = "T" Or isQAManager = "True" Or isOperationsNCR = "T" Or isQC = "True" Or isProdMgr = "True" Or isProgramMgr = "True" Then


    '        GetRecordIDLatestStep()

    '        'Set latest step to Re-Submitted
    '        u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRSteps SET Step = 'Step " & LatestStep & " - Re-Submitted', DateClosed = '" & Now & "', Status = 'Re-Submitted', ResubmittedBy = '" & User & "' Where NCRNumber = '" & NCRNumber & "' And ActualStep = '" & ActualStep & "' And RecordID = '" & LastRecordID & "'")


    '        'Get the last actual step to user in the following Insert statement
    '        da = New SqlClient.SqlDataAdapter("Select * From tblNCRSteps Where NCRNumber = '" & NCRNumber & "' And Step = '1' And Status != 'Aborted' And Status != 'Closed' Order By RecordID Desc", SqlConnection1)
    '        da.Fill(ds, "NCRStepsData")

    '        If ds.Tables("NCRStepsData").Rows.Count > 0 Then
    '            ActualStep = ds.Tables("NCRStepsData").Rows(0).Item("ActualStep")

    '            ds.Tables("NCRStepsData").Clear()
    '            ds.Tables("NCRStepsData").Dispose()
    '        End If


    '        u.ExecuteSQL(SqlConnection1, "Insert Into tblNCRSteps (LatestStep,ActualStep,AcceptedStep,Step,Status,NCRNumber,SubmissionDt) Values (1, '" & ActualStep & "', NULL, '1', 'Open','" & NCRNumber & "','" & Now & "')")
    '        u.ExecuteSQL(SqlConnection1, "UPDATE tblNCR SET Status = 'Re-Submitted', ResubmittedBy = '" & User & "' Where NCRNumber = '" & NCRNumber & "'")
    '        LatestStep = "1"
    '        AcceptedStep = "5"

    '        'Set Status to Resubmitted for the usernames that were supposed to get a notification
    '        u.ExecuteSQL(SqlConnection1, "UPDATE tblUsersWhoSignedOff SET Status = 'Resubmitted' Where NCRNumber = '" & NCRNumber & "'")

    '        SendNotifications("Resubmitted")
    '        SendNotifications("ResubmittedTwo")
    '        SendNotifications("ResubmittedThree")
    '        SendNotifications("ResubmittedFour")


    '        rtxtAddDisposition.Text = ""

    '        ''THIS CODE MAY HAVE TO BE ADDED:  Re-add the Engineers and MRBs that already signed off
    '        'da = New SqlClient.SqlDataAdapter("Select * From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And (SignOffDt != '' Or SignOffDt Is Not Null)", SqlConnection1)
    '        'da.Fill(ds, "EngMRBsThatSignedOff")

    '        'If ds.Tables("EngMRBsThatSignedOff").Rows.Count > 0 Then

    '        '    Dim p As Integer = 0
    '        '    Dim StepForResubmit As String
    '        '    Dim ActualStepForResubmit As String
    '        '    Dim EngForResubmit As String
    '        '    Dim MRBForResubmit As String

    '        '    While p <= ds.Tables("EngMRBsThatSignedOff").Rows.Count - 1
    '        '        EngForResubmit = ds.Tables("EngMRBsThatSignedOff").Rows(0).Item("Engineer")
    '        '        MRBForResubmit = ds.Tables("EngMRBsThatSignedOff").Rows(0).Item("MRB")

    '        '        u.ExecuteSQL(SqlConnection1, "Insert Into tblNCRStepsSignOff (Step,ActualStep,Engineer,MRB,SignOffUserEng,SignOffUserMRB,SignOffDt,NCRNumber) Values ('" & LatestStep & "', '" & ActualStep & "', '" & EngForResubmit & "', '" & MRBForResubmit & "', '', '', NULL, '" & NCRNumber & "')")

    '        '        p = p + 1
    '        '    End While

    '        '    ds.Tables("EngMRBsThatSignedOff").Clear()
    '        '    ds.Tables("EngMRBsThatSignedOff").Dispose()
    '        'End If


    '        SearchSteps()
    '        EnableOtherInfoControls()

    '    Else
    '        MsgBox("You cannot re-submit if you are not a QA or QC or Operations or Production Manager or Program Manager")
    '        Exit Sub
    '    End If
    'End Sub

    Public Function GetRecordIDLatestStep()

        'Get RecordID of last record to use in the following Update
        da = New SqlClient.SqlDataAdapter("Select * From tblNCRSteps Where NCRNumber = '" & NCRNumber & "' And Status != 'Aborted' And Status != 'Closed' Order By RecordID Desc", SqlConnection1)
        da.Fill(ds, "LastRecID")
        If ds.Tables("LastRecID").Rows.Count > 0 Then
            LastRecordID = ds.Tables("LastRecID").Rows(0).Item("RecordID")
            ds.Tables("LastRecID").Clear()
            ds.Tables("LastRecID").Dispose()
        End If

    End Function

    Public Function GetRecordIDLastNCRAdded()

        'Get RecordID of last NCR added
        da = New SqlClient.SqlDataAdapter("Select * From tblNCR Where Status != 'Aborted' And Status != 'Closed' Order By RecordID Desc", SqlConnection1)
        da.Fill(ds, "LastRecIDofNCR")
        If ds.Tables("LastRecIDofNCR").Rows.Count > 0 Then
            RecordIDNCR = ds.Tables("LastRecIDofNCR").Rows(0).Item("RecordID")
            ds.Tables("LastRecIDofNCR").Clear()
            ds.Tables("LastRecIDofNCR").Dispose()
        End If

    End Function

    Private Sub btnSaveOtherInfo_Click(sender As Object, e As EventArgs) Handles btnSaveOtherInfo.Click

        If isSuperUser = "True" Or isQAManager = "True" Or isEngineerNCR = "T" Or isQC = "True" Or isNCRAdmin = "T" Then

            If ValidateOtherInfoTab() = False Then
                Exit Sub
            End If


            u.ExecuteSQL(SqlConnection1, "UPDATE tblNCR SET Type = '" & cboType.Text & "', Location = '" & cboLocation.Text & "', WhereDiscovered = '" & cboWhereDiscovered.Text & "', Manufacturer = '" & cboManufacturer.Text & "', QuantityRejected = '" & txtQuantityRejected.Text & "', ReportedBy = '" & txtReportedBy.Text & "', TypeOfError = '" & cboTypeOfError.Text & "', DispositionType = '" & cboDispositionType.Text & "', StatusNotes = '" & rtxtDispositionNotes.Text & "', None = '" & chkNone.CheckState & "', NotifyCustomer = '" & chkNotify.CheckState & "', WriteCAR = '" & chkWriteCAR.CheckState & "', WriteSCAR = '" & chkWriteSCAR.CheckState & "', WriteCPAR = '" & chkWriteCPAR.CheckState & "', Other = '" & chkOther.CheckState & "', Notes = '" & rtxtAdditionalActionNotes.Text & "', ResponsibleDept = '" & cboResponsibleDept.Text & "', ResponsiblePerson = '" & txtResponsiblePerson.Text & "', Cause = '" & txtCause.Text & "', Cost = '" & txtCost.Text & "', CustomerNCRNum = '" & txtCustomerNCRNum.Text & "', MaterialReturnAuthNum = '" & txtMaterialReturnAuthNum.Text & "', SalesOrderNum = '" & txtSalesOrderNum.Text & "', ReturnDate = '" & dtpReturnDt.Text & "', TotalQuantity = '" & txtTotalQuantity.Text & "', SupplierPurchaseOrderNum = '" & txtSupplierPurchaseOrder.Text & "' Where RecordID = '" & Val(RecordIDNCR) & "'")      ', CostIsSignificant = '" & cboCostIsSignificant.Text & "'

            MsgBox("Saved")

            Search()

        Else
            MsgBox("You need to be an Engineer or QA or QC to save")
            Exit Sub
        End If
    End Sub

    Public Function ValidateOtherInfoTab()

        Dim errors As String = ""

        If cboType.Text = "" Then
            errors = "You are required to enter the Type in the Other Info tab." & Environment.NewLine & "" & Environment.NewLine & ""
        End If

        If cboLocation.Text = "" Then
            errors = errors & "You are required to enter the Location in the Other Info tab." & Environment.NewLine & "" & Environment.NewLine & ""
        End If

        'If isCalgary = "Yes" Then
        '    'Nothing
        'Else
        '    If cboManufacturer.Text = "" Then
        '        errors = errors & "You are required to enter Manufacturer/Supplier in the Other Info tab." & Environment.NewLine & "" & Environment.NewLine & ""
        '    End If
        'End If

        If txtQuantityRejected.Text = "" Then
            errors = errors & "You are required to enter Quantity Rejected of 1 or greater in the Other Info tab." & Environment.NewLine & "" & Environment.NewLine & ""
        ElseIf Not (IsNumeric(txtQuantityRejected.Text)) Then
            errors = errors & "You are required to enter Quantity Rejected of 1 or greater in the Other Info tab." & Environment.NewLine & "" & Environment.NewLine & ""
        ElseIf Integer.Parse(txtQuantityRejected.Text) < 1 Then
            errors = errors & "You are required to enter Quantity Rejected of 1 or greater in the Other Info tab." & Environment.NewLine & "" & Environment.NewLine & ""
        End If

        'If txtReportedBy.Text = "" Then
        '    errors = "You are required to enter Reported By." & Environment.NewLine & "" & Environment.NewLine & ""
        'End If

        'If rtxtStatusNotes.Text = "" Then
        '    errors = "You are required to enter Status / Notes." & Environment.NewLine & "" & Environment.NewLine & ""
        'End If

        'If isCalgary = "Yes" Then
        '    If rtxtNotes.Text = "" Then
        '        errors = "You are required to enter Notes in the Other Info tab." & Environment.NewLine & "" & Environment.NewLine & ""
        '    End If
        'End If


        If errors <> "" Then
            errors = errors + "Please correct the errors above in the Other Info tab and submit."
            MsgBox(errors)
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnSaveCreateTab_Click(sender As Object, e As EventArgs) Handles btnSaveCreateTab.Click

        If isSuperUser = "True" Or isNCRAdmin = "T" Or isQAManager = "True" Then


            Dim errors As String = ""


            'If isCalgary <> "Yes" Then
            '    If Me.cboPrograms.Text = "" Then
            '        errors = "You are required to enter a Program." & Environment.NewLine & "" & Environment.NewLine & ""
            '    End If


            '    If Me.txtDrawingNum.Text = "" Then
            '        errors = errors + "You are required to enter ONE Drawing Number." & Environment.NewLine & "" & Environment.NewLine & ""
            '    End If

            '    If Me.cboRev.Text = "" Then
            '        errors = errors + "You are required to enter a Revision." & Environment.NewLine & "" & Environment.NewLine & ""
            '    End If
            'End If

            If Me.txtPartNumber.Text = "" Then
                errors = errors + "You are required to enter a Part Number." & Environment.NewLine & "" & Environment.NewLine & ""
            End If

            If Me.txtPartDescription.Text = "" Then
                errors = errors + "You are required to enter a Part Description." & Environment.NewLine & "" & Environment.NewLine & ""
            End If

            'If Me.cboWorkOrder.Text = "" Or Not IsNumeric(cboWorkOrder.Text) Then
            '    If cboWorkOrder.Text <> "Unaffiliated" Then
            '        errors = errors + "You are required to enter a numeric Work Order or select Unaffiliated from the drop down." & Environment.NewLine & "" & Environment.NewLine & ""
            '    End If
            'End If

            ''If isCalgary <> "Yes" Then
            'If Me.cboStep.Text = "" Or Not IsNumeric(cboStep.Text) Then
            '    If cboStep.Text <> "Unaffiliated" Then
            '        errors = errors + "You are required to enter a numeric Step or select Unaffiliated from the drop down." & Environment.NewLine & "" & Environment.NewLine & ""
            '    End If
            'End If
            ''End If

            If Me.rtxtDiscrepancy.Text = "" Then
                errors = errors + "You are required to enter a Discrepancy." & Environment.NewLine & "" & Environment.NewLine & ""
            End If


            'If Me.chkDrawingReqForConformityNo.Checked = False And Me.chkDrawingReqForConformityYes.Checked = False Then
            '    errors = errors + "You are required to check a box in the drawing required for conformity section." & Environment.NewLine & "" & Environment.NewLine & ""
            'End If

            If txtPurchaseOrder.Text <> "" Then
                If Not (IsNumeric(txtPurchaseOrder.Text)) Then
                    errors = errors + "You are required to enter a numeric Purchase Order Number." & Environment.NewLine & "" & Environment.NewLine & ""
                End If
            End If

            If errors <> "" Then
                errors = errors + "Please correct the errors above and submit."
                MsgBox(errors)
                Exit Sub
            End If


            'Make the WorkOrder and Step in format WorkOrder.Step
            Dim WorkOrderStep As String = ""
            If cboWorkOrder.Text = "Unaffiliated" Then
                WorkOrderStep = "Unaffiliated"
            Else
                'If isCalgary = "Yes" And cboStep.Text <> "" Then
                '    WorkOrderStep = cboWorkOrder.Text & "." & cboStep.Text
                'ElseIf isCalgary = "Yes" Then
                '    WorkOrderStep = cboWorkOrder.Text
                'Else
                '    WorkOrderStep = cboWorkOrder.Text & "." & cboStep.Text
                'End If

                If cboStep.Text = "" Or cboStep.Text = "Unaffiliated" Then
                    WorkOrderStep = cboWorkOrder.Text
                Else
                    WorkOrderStep = cboWorkOrder.Text & "." & cboStep.Text
                End If
            End If


            u.ExecuteSQL(SqlConnection1, "UPDATE tblNCR SET Program = '" & cboPrograms.Text & "', SerialNum = '" & txtSerialNum.Text & "', SerialNumType = '" & cboSerialNumType.Text & "', AircraftIdentifier = '" & txtAircraftIdentifier.Text & "', DrawingNumber = '" & txtDrawingNum.Text & "', DwgRevision = '" & cboRev.Text & "', PartNumber = '" & txtPartNumber.Text & "', PartDescription = '" & txtPartDescription.Text & "', WorkOrderStep = '" & WorkOrderStep & "', PurchaseOrderNum = '" & txtPurchaseOrder.Text & "', Discrepancy = '" & rtxtDiscrepancy.Text & "', Comments = '" & rtxtComments.Text & "', WorkOrder = '" & cboWorkOrder.Text & "', StepWorkOrder = '" & cboStep.Text & "' Where RecordID = '" & Val(RecordIDNCR) & "'")


            MsgBox("Saved")


            Search()

        Else
            MsgBox("You need to be QA or QC to save changes")
            Exit Sub
        End If
    End Sub

    Private Sub btnNotifyEngineers_Click(sender As Object, e As EventArgs) Handles btnNotifyEngineers.Click
        SendNotifications("Engineers")
    End Sub

    Private Sub btnNotifyMRBs_Click(sender As Object, e As EventArgs) Handles btnNotifyMRBs.Click
        SendNotifications("MRBs")
    End Sub

    Public Function SendNotifications(TypeOfNotification As String)
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim c As Integer = 0
        Dim EngineersList As String = ""
        Dim MRBsList As String = ""
        Dim Recipients As String = ""
        Dim Subject As String = ""
        Dim BodyEmail As String = ""


        Select Case TypeOfNotification

            Case "NewNCR"

                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where QAManager = 1 And Active = 1", SqlConnection2)

                Subject = "A new NCR " & NCRNumber & " has been created"
                BodyEmail = "A new NCR " & NCRNumber & " has been created"


            Case "Step1"

                'da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where QAManager = 1 And Active = 1", SqlConnection2)
                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Active = 1 And (QAManager = 1 Or QC = 1)", SqlConnection2)

                Subject = "NCR number " & NCRNumber & " is at disposition 1 and needs to be signed off"
                BodyEmail = "NCR number " & NCRNumber & " is at disposition 1 and needs to be signed off"


            Case "Step2"

                'da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Engineer = 'T' And Active = 1", SqlConnection2)
                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Active = 1 And (QAManager = 1 Or QC = 1)", SqlConnection2)

                Subject = "NCR number " & NCRNumber & " is at disposition 2 and needs to be signed off"
                BodyEmail = "NCR number " & NCRNumber & " is at disposition 2 and needs to be signed off"


            Case "Step3"

                'da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Active = 1 And (ProductionManager = 1 Or ProgramManager = 1 Or DAO = 1 Or LeadEngineer = 1 Or Stress = 'T' Or Design = 1 Or LiaisonEngineer = 'T')", SqlConnection2)
                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Active = 1 And (QAManager = 1 Or QC = 1)", SqlConnection2)

                Subject = "NCR number " & NCRNumber & " is at disposition 3 and needs to be signed off"
                BodyEmail = "NCR number " & NCRNumber & " is at disposition 3 and needs to be signed off"


            Case "Step4"

                'da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Operations = 'T' And Active = 1", SqlConnection2)
                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Active = 1 And (QAManager = 1 Or QC = 1)", SqlConnection2)

                Subject = "NCR number " & NCRNumber & " is at disposition 4 and needs to be signed off"
                BodyEmail = "NCR number " & NCRNumber & " is at disposition 4 and needs to be signed off"


            Case "Step5"

                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Active = 1 And (QAManager = 1 Or QC = 1 Or CloseNCR = 1)", SqlConnection2)

                Subject = "NCR number " & NCRNumber & " is at disposition 5 and needs to be signed off"
                BodyEmail = "NCR number " & NCRNumber & " is at disposition 5 and needs to be signed off"



            'Email Engineers after clicking on button "Send Notification to Engineers"
            Case "Engineers"

                If NCRIsClosed = "Yes" Then
                    da = New SqlClient.SqlDataAdapter("Select Distinct Engineer From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And Engineer Is Not Null And Engineer != ''", SqlConnection1)
                Else
                    da = New SqlClient.SqlDataAdapter("Select Distinct Engineer From tblNCRStepsSignOff Where (SignOffDt Is Null Or SignOffDt = '') And NCRNumber = '" & NCRNumber & "' And Engineer Is Not Null And Engineer != ''", SqlConnection1)
                End If

                da.Fill(ds, "GetEngineers")

                If ds.Tables("GetEngineers").Rows.Count > 0 Then
                    While a <= ds.Tables("GetEngineers").Rows.Count - 1

                        If EngineersList = "" Then
                            If IsDBNull(ds.Tables("GetEngineers").Rows(a).Item("Engineer")) Then
                                EngineersList = ""
                            Else
                                EngineersList = "'" & ds.Tables("GetEngineers").Rows(a).Item("Engineer") & "'"
                            End If

                        Else

                            If IsDBNull(ds.Tables("GetEngineers").Rows(a).Item("Engineer")) Then
                                'Nothing
                            Else
                                EngineersList = EngineersList & ", '" & ds.Tables("GetEngineers").Rows(a).Item("Engineer") & "'"
                            End If
                        End If

                        a = a + 1
                    End While

                    ds.Tables("GetEngineers").Clear()
                    ds.Tables("GetEngineers").Dispose()

                Else
                    GoTo DONOTSENDEMAIL
                End If


                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Active = 1 And UserName IN (" & EngineersList & ")", SqlConnection2)

                If NCRIsClosed = "Yes" Then
                    Subject = "NCR number " & NCRNumber & " was closed"
                    BodyEmail = "NCR number " & NCRNumber & " was closed"
                Else
                    Subject = "NCR number " & NCRNumber & " needs to be signed off"
                    BodyEmail = "NCR number " & NCRNumber & " needs to be signed off"
                End If


                'Email MRBs after clicking on button "Send Notification to MRBs"
            Case "MRBs"

                If NCRIsClosed = "Yes" Then
                    da = New SqlClient.SqlDataAdapter("Select Distinct MRB From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And MRB Is Not Null And MRB != ''", SqlConnection1)
                Else
                    da = New SqlClient.SqlDataAdapter("Select Distinct MRB From tblNCRStepsSignOff Where (SignOffDt Is Null Or SignOffDt = '') And NCRNumber = '" & NCRNumber & "' And MRB Is Not Null And MRB != ''", SqlConnection1)
                End If

                da.Fill(ds, "GetMRBs")

                If ds.Tables("GetMRBs").Rows.Count > 0 Then
                    While c <= ds.Tables("GetMRBs").Rows.Count - 1

                        If MRBsList = "" Then
                            If IsDBNull(ds.Tables("GetMRBs").Rows(c).Item("MRB")) Then
                                MRBsList = ""
                            Else
                                MRBsList = "'" & ds.Tables("GetMRBs").Rows(c).Item("MRB") & "'"
                            End If

                        Else

                            If IsDBNull(ds.Tables("GetMRBs").Rows(c).Item("MRB")) Then
                                'Nothing
                            Else
                                MRBsList = MRBsList & ", '" & ds.Tables("GetMRBs").Rows(c).Item("MRB") & "'"
                            End If
                        End If

                        c = c + 1
                    End While

                    ds.Tables("GetMRBs").Clear()
                    ds.Tables("GetMRBs").Dispose()
                Else
                    GoTo DONOTSENDEMAIL
                End If


                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Active = 1 And UserName IN (" & MRBsList & ")", SqlConnection2)

                If NCRIsClosed = "Yes" Then
                    Subject = "NCR number " & NCRNumber & " was closed"
                    BodyEmail = "NCR number " & NCRNumber & " was closed"
                Else
                    Subject = "NCR number " & NCRNumber & " needs to be signed off"
                    BodyEmail = "NCR number " & NCRNumber & " needs to be signed off"
                End If


'-------------------------------------------------------------------------------------------------------
            Case "Closed"

                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsersWhoSignedOff Where NCRNumber = '" & NCRNumber & "' And Status != 'Aborted' And Status != 'Resubmitted'", SqlConnection1)

                Subject = "NCR number " & NCRNumber & " was closed"
                BodyEmail = "NCR number " & NCRNumber & " was closed"


            Case "ClosedTwo"

                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where QAManager = 1 And Active = 1", SqlConnection2)

                Subject = "NCR number " & NCRNumber & " was closed"
                BodyEmail = "NCR number " & NCRNumber & " was closed"


'-------------------------------------------------------------------------------------------------------
                'When Aborted, email people who signed off so far
            Case "Aborted"

                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsersWhoSignedOff Where NCRNumber = '" & NCRNumber & "' And Status != 'Aborted' And Status != 'Resubmitted'", SqlConnection1)

                Subject = "NCR number " & NCRNumber & " was aborted"
                BodyEmail = "NCR number " & NCRNumber & " was aborted"


                'When Aborted, email engineers that were added
            Case "AbortedTwo"

                da = New SqlClient.SqlDataAdapter("Select Distinct Engineer From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And Engineer Is Not Null And Engineer != ''", SqlConnection1)
                da.Fill(ds, "GetEngineers")

                If ds.Tables("GetEngineers").Rows.Count > 0 Then
                    While a <= ds.Tables("GetEngineers").Rows.Count - 1

                        If EngineersList = "" Then
                            If IsDBNull(ds.Tables("GetEngineers").Rows(a).Item("Engineer")) Then
                                EngineersList = ""
                            Else
                                EngineersList = "'" & ds.Tables("GetEngineers").Rows(a).Item("Engineer") & "'"
                            End If

                        Else

                            If IsDBNull(ds.Tables("GetEngineers").Rows(a).Item("Engineer")) Then
                                'Nothing
                            Else
                                EngineersList = EngineersList & ", '" & ds.Tables("GetEngineers").Rows(a).Item("Engineer") & "'"
                            End If
                        End If

                        a = a + 1
                    End While

                    ds.Tables("GetEngineers").Clear()
                    ds.Tables("GetEngineers").Dispose()
                Else
                    GoTo DONOTSENDEMAIL
                End If


                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Active = 1 And UserName IN (" & EngineersList & ")", SqlConnection2)

                Subject = "NCR number " & NCRNumber & " was aborted"
                BodyEmail = "NCR number " & NCRNumber & " was aborted"


                 'When Aborted, email MRBs that were added
            Case "AbortedThree"

                da = New SqlClient.SqlDataAdapter("Select Distinct MRB From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And MRB Is Not Null And MRB != ''", SqlConnection1)
                da.Fill(ds, "GetMRBs")

                If ds.Tables("GetMRBs").Rows.Count > 0 Then
                    While c <= ds.Tables("GetMRBs").Rows.Count - 1

                        If MRBsList = "" Then
                            If IsDBNull(ds.Tables("GetMRBs").Rows(c).Item("MRB")) Then
                                MRBsList = ""
                            Else
                                MRBsList = "'" & ds.Tables("GetMRBs").Rows(c).Item("MRB") & "'"
                            End If

                        Else

                            If IsDBNull(ds.Tables("GetMRBs").Rows(c).Item("MRB")) Then
                                'Nothing
                            Else
                                MRBsList = MRBsList & ", '" & ds.Tables("GetMRBs").Rows(c).Item("MRB") & "'"
                            End If
                        End If

                        c = c + 1
                    End While

                    ds.Tables("GetMRBs").Clear()
                    ds.Tables("GetMRBs").Dispose()
                Else
                    GoTo DONOTSENDEMAIL
                End If


                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Active = 1 And UserName IN (" & MRBsList & ")", SqlConnection2)

                Subject = "NCR number " & NCRNumber & " was aborted"
                BodyEmail = "NCR number " & NCRNumber & " was aborted"

'When Aborted, email QAs
            Case "AbortedFour"

                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where QAManager = 1 And Active = 1", SqlConnection2)

                Subject = "NCR number " & NCRNumber & " was aborted"
                BodyEmail = "NCR number " & NCRNumber & " was aborted"


'-------------------------------------------------------------------------------------------------------
                'After Re-Submit, email all people who signed off
            Case "Resubmitted"

                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsersWhoSignedOff Where NCRNumber = '" & NCRNumber & "' And Status != 'Aborted' And Status != 'Resubmitted'", SqlConnection1)

                Subject = "NCR number " & NCRNumber & " was resubmitted"
                BodyEmail = "NCR number " & NCRNumber & " was resubmitted"


                'After Re-Submit, email the QA Manager
            Case "ResubmittedTwo"

                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where QAManager = 1 And Active = 1", SqlConnection2)

                Subject = "NCR number " & NCRNumber & " was resubmitted"
                BodyEmail = "NCR number " & NCRNumber & " was resubmitted"


                'After Re-Submit, email all engineers that were added
            Case "ResubmittedThree"

                da = New SqlClient.SqlDataAdapter("Select Distinct Engineer From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And Engineer Is Not Null And Engineer != ''", SqlConnection1)
                da.Fill(ds, "GetEngineers")

                If ds.Tables("GetEngineers").Rows.Count > 0 Then
                    While a <= ds.Tables("GetEngineers").Rows.Count - 1

                        If EngineersList = "" Then
                            If IsDBNull(ds.Tables("GetEngineers").Rows(a).Item("Engineer")) Then
                                EngineersList = ""
                            Else
                                EngineersList = "'" & ds.Tables("GetEngineers").Rows(a).Item("Engineer") & "'"
                            End If

                        Else

                            If IsDBNull(ds.Tables("GetEngineers").Rows(a).Item("Engineer")) Then
                                'Nothing
                            Else
                                EngineersList = EngineersList & ", '" & ds.Tables("GetEngineers").Rows(a).Item("Engineer") & "'"
                            End If
                        End If

                        a = a + 1
                    End While

                    ds.Tables("GetEngineers").Clear()
                    ds.Tables("GetEngineers").Dispose()
                Else
                    GoTo DONOTSENDEMAIL
                End If


                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Active = 1 And UserName IN (" & EngineersList & ")", SqlConnection2)

                Subject = "NCR number " & NCRNumber & " was resubmitted"
                BodyEmail = "NCR number " & NCRNumber & " was resubmitted"


                'After Re-Submit, email all MRBs that were added
            Case "ResubmittedFour"

                da = New SqlClient.SqlDataAdapter("Select Distinct MRB From tblNCRStepsSignOff Where NCRNumber = '" & NCRNumber & "' And MRB Is Not Null And MRB != ''", SqlConnection1)
                da.Fill(ds, "GetMRBs")

                If ds.Tables("GetMRBs").Rows.Count > 0 Then
                    While c <= ds.Tables("GetMRBs").Rows.Count - 1

                        If MRBsList = "" Then
                            If IsDBNull(ds.Tables("GetMRBs").Rows(c).Item("MRB")) Then
                                MRBsList = ""
                            Else
                                MRBsList = "'" & ds.Tables("GetMRBs").Rows(c).Item("MRB") & "'"
                            End If

                        Else

                            If IsDBNull(ds.Tables("GetMRBs").Rows(c).Item("MRB")) Then
                                'Nothing
                            Else
                                MRBsList = MRBsList & ", '" & ds.Tables("GetMRBs").Rows(c).Item("MRB") & "'"
                            End If
                        End If

                        c = c + 1
                    End While

                    ds.Tables("GetMRBs").Clear()
                    ds.Tables("GetMRBs").Dispose()
                Else
                    GoTo DONOTSENDEMAIL
                End If


                da = New SqlClient.SqlDataAdapter("Select Distinct Email From tblUsers Where Active = 1 And UserName IN (" & MRBsList & ")", SqlConnection2)

                Subject = "NCR number " & NCRNumber & " was resubmitted"
                BodyEmail = "NCR number " & NCRNumber & " was resubmitted"

        End Select


        'Get recipients of the email
        da.Fill(ds, "Emails")

        While b <= ds.Tables("Emails").Rows.Count - 1

            If Recipients = "" Then
                If IsDBNull(ds.Tables("Emails").Rows(b).Item("Email")) Then
                    Recipients = ""
                Else
                    Recipients = ds.Tables("Emails").Rows(b).Item("Email")
                End If

            Else
                If IsDBNull(ds.Tables("Emails").Rows(b).Item("Email")) Then
                    'Nothing
                Else
                    Recipients = Recipients & "; " & ds.Tables("Emails").Rows(b).Item("Email")
                End If
            End If

            b = b + 1
        End While

        ds.Tables("Emails").Clear()
        ds.Tables("Emails").Dispose()



        u.SendEmail("system@fieldaero.com", Recipients, Subject, BodyEmail)


DONOTSENDEMAIL:

    End Function

    'Disallow the free type text in the comboboxes  
    Private Sub cboType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboType.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboLocation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboLocation.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboWhereDiscovered_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboWhereDiscovered.KeyPress
        e.Handled = True
    End Sub
    Private Sub cboResponsibleDept_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboResponsibleDept.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboManufacturer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboManufacturer.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboTypeOfError_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTypeOfError.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboDispositionType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDispositionType.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboPrograms_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboPrograms.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboSerialNumType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboSerialNumType.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboRev_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboRev.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtPartDescription_Validated(sender As Object, e As EventArgs) Handles txtPartDescription.Validated
        txtPartDescription.Text = UCase(txtPartDescription.Text)
    End Sub


    'ATTACHMENTS --------------------------------------------------------------------------------------------------------------


    Private Sub txtRecordID_TextChanged(sender As Object, e As EventArgs) Handles txtRecordID.TextChanged
        GetFileUploadRecords()
    End Sub

    Private Sub GetFileUploadRecords()
        Dim sqlString1 As String

        Me.DsNCRAttachments1.tblNCRAttach.Clear()
        sqlString1 = " WHERE RecordID = RecordID"

        Me.txtAttachRecordID.DataBindings.Clear()
        Me.txtFileDescription.DataBindings.Clear()
        Me.txtFilePath.DataBindings.Clear()
        Me.txtActualStepAttach.DataBindings.Clear()

        sqlString1 = sqlString1 + " AND NCRID = '" & Val(Me.txtRecordID.Text) & "' Order By ActualStep Desc"

        Dim cmdSave As String

        cmdSave = Me.daAttachments.SelectCommand.CommandText
        Me.daAttachments.SelectCommand.CommandText += sqlString1
        Try
            Me.daAttachments.Fill(Me.DsNCRAttachments1.tblNCRAttach)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.daAttachments.SelectCommand.CommandText = cmdSave

        If Me.DsNCRAttachments1.Tables("tblNCRAttach").Rows.Count > 0 Then
            Me.txtAttachRecordID.DataBindings.Add("Text",
            Me.bsAttachments, "RecordID")
            Me.txtFileDescription.DataBindings.Add("Text",
            Me.bsAttachments, "FileDescription")
            Me.txtFilePath.DataBindings.Add("Text",
            Me.bsAttachments, "FilePath")
            Me.txtActualStepAttach.DataBindings.Add("Text",
           Me.bsAttachments, "ActualStep")
        Else
            ' MsgBox("No Attachments Currently Exist For This Record.")
        End If

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Me.OpenFileDialog1.InitialDirectory = "C:\"
        Me.OpenFileDialog1.Filter = "All files (*.*)|*.*"
        Me.OpenFileDialog1.FilterIndex = 1
        Me.OpenFileDialog1.RestoreDirectory = True

        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Me.OpenFileDialog1.FileName
            Me.txtFilePath.Text = Me.OpenFileDialog1.FileName.ToString
        End If

    End Sub

    Private Sub btnSaveNew_Click(sender As Object, e As EventArgs) Handles btnSaveNew.Click

        If isSuperUser = "True" Or isQAManager = "True" Or isQC = "True" Or isEngineerNCR = "T" Or isProdMgr = "True" Or isProgramMgr = "True" Or isDAO = "True" Or isLeadEngineerNCR = "True" Or isStress = "T" Or isDesign = "True" Or isLiaisonNCR = "T" Or isOperationsNCR = "T" Or isNCRAdmin = "T" Then
            'Nothing
        Else
            MsgBox("You do not have permission to save new attachment.")
            Exit Sub
        End If


        If txtFilePath.Text = "" Then
            MsgBox("You must Browse to a file")
            Exit Sub
        End If


        If txtFileDescription.Text = "" Then
            MsgBox("Please enter the File Description")
            Exit Sub
        End If


        'If MsgBox("FYI, you are adding the attachment to disposition " & ActualStepSelected & ". If you want to add it to another disposition, go to the Disposition tab and select a different disposition", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '    'Nothing
        'Else
        '    Exit Sub
        'End If



        Dim FileUploadSave As String = "AddNew"
        If FileUploadSave = "AddNew" Then
            Dim ToPath As String
            ToPath = Me.txtFilePath.Text
            ToPath = ToPath.Substring(ToPath.LastIndexOf("\") + 1)

            Dim FileName As String
            FileName = ToPath
            Dim FileExt As String
            FileExt = ToPath.Substring(ToPath.LastIndexOf(".") + 1)

            da = New SqlClient.SqlDataAdapter("SELECT * FROM tblNCRAttach where RecordID = '" & Val(Me.txtAttachRecordID.Text) & "'", SqlConnection1)
            Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey

            Dim fs As New FileStream(Me.txtFilePath.Text, FileMode.OpenOrCreate, FileAccess.Read)
            Dim MyData(fs.Length) As Byte
            fs.Read(MyData, 0, fs.Length)
            fs.Close()

            SqlConnection1.Open()

            da.Fill(ds, "MyImages")
            Dim myRow As DataRow
            myRow = ds.Tables("MyImages").NewRow

            myRow("NCRID") = Val(Me.txtRecordID.Text)
            myRow("FilePath") = ToPath
            myRow("FileDescription") = u.FTM(Me.txtFileDescription.Text)
            myRow("ImgField") = MyData
            myRow("FileName") = FileName
            myRow("FileExt") = FileExt

            ds.Tables("MyImages").Rows.Add(myRow)
            da.Update(ds, "MyImages")

            fs = Nothing
            MyCB = Nothing
            ds.Tables("MyImages").Clear()

            SqlConnection1.Close()
            MsgBox("Document Saved to Database")

            Me.btnSaveNew.Visible = False


            'Associate the attachment to the latest added Step
            u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRAttach SET Step = '" & LatestStep & "', ActualStep = '" & ActualStep & "', DateAdded = '" & Now & "', NCRNumber = '" & NCRNumber & "', SortForReport = 1 Where RecordID = (Select MAX(RecordID) From tblNCRAttach)")


            GetFileUploadRecords()
        End If

    End Sub

    Private Sub btnDeleteAttachment_Click(sender As Object, e As EventArgs) Handles btnDeleteAttachment.Click

        'If isSuperUser = "True" Or isQAManager = "True" Or isQC = "True" Or isEngineerNCR = "T" Or isProdMgr = "True" Or isProgramMgr = "True" Or isDAO = "True" Or isLeadEngineerNCR = "True" Or isStress = "T" Or isDesign = "True" Or isLiaisonNCR = "T" Or isOperationsNCR = "T" Or isNCRAdmin = "T" Then
        If isSuperUser = "True" Or isNCRAdmin = "T" Then

            If Me.txtAttachRecordID.Text = "" Then
                MsgBox("There are no files to delete.", MsgBoxStyle.Information, "NCR Application")
            Else
                Dim answer
                answer = MsgBox("Are you sure you want to delete this file?", MsgBoxStyle.YesNo, "NCR Application")

                If answer = 6 Then
                    u.ExecuteSQL(SqlConnection1, "DELETE FROM tblNCRAttach WHERE RecordID = '" & Val(Me.txtAttachRecordID.Text) & "'")
                    MsgBox("The file has been deleted.", MsgBoxStyle.Information, "NCR Application")

                    GetFileUploadRecords()

                Else
                    MsgBox("Deletion of file was canceled.", MsgBoxStyle.Information, "NCR Application")
                End If
            End If

        Else
            MsgBox("You do not have permission to delete an attachment. You must be a Super User or an Admin.")
            Exit Sub
        End If

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

        If Me.txtAttachRecordID.Text = "" Then
            MsgBox("There are no files to view.", MsgBoxStyle.Information, "NCR APP")
        Else
            DeleteTempFilesFromViewing()

            da = New SqlClient.SqlDataAdapter("SELECT * FROM tblNCRAttach WHERE RecordID = '" & Me.txtAttachRecordID.Text & "'", SqlConnection1)
            Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)

            SqlConnection1.Open()

            da.Fill(ds, "MyImages")
            Dim myRow As DataRow
            myRow = ds.Tables("MyImages").Rows(0)

            Dim MyData() As Byte
            MyData = myRow("ImgField")

            Dim Extension As String
            Extension = myRow("FileExt")
            Dim FileDesc As String
            FileDesc = myRow("FileDescription")

            Dim K As Long
            K = UBound(MyData)

            Dim FileDest As String

            'FileDest = Environment.SpecialFolder.MyDocuments.ToString + Format(Now, "MMddyyyyhhmmss") + "." + Extension
            FileDest = "C:\Temp\" + FileDesc + " " + Format(Now, "MMddyyyyhhmmss") + "." + Extension
            Dim fs As New FileStream(FileDest, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(MyData, 0, K)
            fs.Close()
            fs = Nothing
            MyCB = Nothing
            ds.Tables("MyImages").Clear()

            Process.Start(FileDest)

            SqlConnection1.Close()
        End If

    End Sub

    Private Sub DeleteTempFilesFromViewing()
        Dim File As String

        For Each File In Directory.GetFiles("C:\Temp\")
            Dim File2 As New FileInfo(File)
            Try
                File2.Delete()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next
    End Sub

    Private Sub btnFileAttachSubmit_Click(sender As Object, e As EventArgs) Handles btnFileAttachSubmit.Click

        If isSuperUser = "True" Or isQAManager = "True" Or isQC = "True" Or isEngineerNCR = "T" Or isProdMgr = "True" Or isProgramMgr = "True" Or isDAO = "True" Or isLeadEngineerNCR = "True" Or isStress = "T" Or isDesign = "True" Or isLiaisonNCR = "T" Or isOperationsNCR = "T" Or isNCRAdmin = "T" Then

            btnSaveNew.Visible = True
            Me.txtFileDescription.Text = ""
            Me.txtFilePath.Text = ""
            MsgBox("Fill in the description and browse for the file. Then click Save New")

        Else
            MsgBox("You do not have the permission to add an attachment")
            Exit Sub
        End If
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Dim i As Integer = 0


        If Me.txtAttachRecordID.Text = "" Then
            MsgBox("There are no files to view.", MsgBoxStyle.Information, "NCR APP")
        Else
            DeleteTempFilesFromViewing()

            da = New SqlClient.SqlDataAdapter("SELECT * FROM tblNCRAttach WHERE NCRID = '" & Me.txtRecordID.Text & "'", SqlConnection1)
            Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)

            SqlConnection1.Open()

            da.Fill(ds, "MyImages")


            While i <= ds.Tables("MyImages").Rows.Count - 1

                Dim myRow As DataRow
                myRow = ds.Tables("MyImages").Rows(i)

                Dim MyData() As Byte
                MyData = myRow("ImgField")

                Dim Extension As String
                Extension = myRow("FileExt")
                Dim FileDesc As String
                FileDesc = myRow("FileDescription")

                Dim K As Long
                K = UBound(MyData)

                Dim FileDest As String

                'FileDest = Environment.SpecialFolder.MyDocuments.ToString + Format(Now, "MMddyyyyhhmmss") + "." + Extension
                FileDest = "C:\Temp\" + FileDesc + " " + Format(Now, "MMddyyyyhhmmss") + "." + Extension
                Dim fs As New FileStream(FileDest, FileMode.OpenOrCreate, FileAccess.Write)
                fs.Write(MyData, 0, K)
                fs.Close()
                fs = Nothing
                MyCB = Nothing

                Process.Start(FileDest)

                i = i + 1

            End While


            ds.Tables("MyImages").Clear()
            ds.Tables("MyImages").Dispose()

            SqlConnection1.Close()
        End If

    End Sub

    Private Sub btnPrintSteps_Click(sender As Object, e As EventArgs) Handles btnPrintSteps.Click

        Dim crReport As New crNCRSteps
        crReport.SetDatabaseLogon("sa1", "The water is wet!")

        Dim sqlstring As String

        sqlstring = "SELECT * From tblNCRSteps where NCRNumber = '" & NCRNumber & "'"

        GlobalSqlString = sqlstring

        Dim frm As New frmViewNCRReport
        frm.ReportType = "NCR"
        frm.Report1 = crReport
        frm.Show()

    End Sub

    Private Sub GridView2_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        'If rtxtReSubmitReason.Text = "" Then
        '    rtxtReSubmitReason.Enabled = True
        'Else
        '    rtxtReSubmitReason.Enabled = False
        'End If


        ''Get Step and Actual Step of selected step to use for attachments
        'StepSelected = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Step")
        'ActualStepSelected = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "ActualStep")    'TO ADD: NCR Point 3, this gets executed even if Actual Step column is hidden. Nothing to do here.


        'Make the Save Disposition disabled for records that were already signed off/accepted
        If IsDBNull(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "AcceptedStep")) Then
            AcceptedStepSelected = ""
        Else
            AcceptedStepSelected = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "AcceptedStep")
        End If

        If AcceptedStepSelected <> "" Then
            btnSaveDisposition.Enabled = False
            rtxtAddDisposition.Enabled = False
        Else
            btnSaveDisposition.Enabled = True
            rtxtAddDisposition.Enabled = True
        End If

    End Sub

    Private Sub btnPrintNCR_Click(sender As Object, e As EventArgs) Handles btnPrintNCR.Click

        ''NCR Main Report
        'Dim crReportMain As New crNCRMain
        'crReportMain.SetDatabaseLogon("sa1", "The water is wet!")

        'Dim sqlstringNCRMain As String
        'sqlstringNCRMain = "SELECT * FROM tblNCR Where NCRNumber = '" & NCRNumber & "'"

        'GlobalSqlString2 = sqlstringNCRMain

        'Dim frmNCRMain As New frmViewNCRMain
        'frmNCRMain.ReportTypeNCRMain = "NCRMain"
        'frmNCRMain.Report3 = crReportMain
        'frmNCRMain.Show()



        'NCR Steps and Attachments Report
        Dim crReport As New crNCRStepsAndAttachments
        crReport.SetDatabaseLogon("sa1", "The water is wet!")

        Dim sqlstring As String
        sqlstring = "SELECT * FROM StepsAndAttachments Where NCRNumber = '" & NCRNumber & "' And (FileExt = 'jpeg' Or FileExt = 'jpg' Or FileExt = 'pdf' Or FileExt Is Null) Order By ActualStep, Status Desc, NCRID, SignOffDt"     'SortForReport, 

        GlobalSqlString = sqlstring

        Dim frm As New frmViewNCRStepsAndAttachReport
        frm.ReportType = "NCRStepsAndAttachments"
        frm.Report2 = crReport
        frm.Show()

    End Sub


    'If the user is not a SuperUser, QA or Admin, it cannot enter the Disposition
    Private Sub rtxtAddDisposition_MouseDown(sender As Object, e As MouseEventArgs) Handles rtxtAddDisposition.MouseDown

        'If isCalgary <> "Yes" Then
        If isSuperUser = "True" Or isQAManager = "True" Or isNCRAdmin = "T" Then
            'Nothing
        Else
            MsgBox("You cannot enter the Disposition if you are not a QA, SuperUser or Admin")
            lblEnterDisposition.Focus()
            Exit Sub
        End If
        'End If

    End Sub

    Private Sub btnSaveDisposition_Click(sender As Object, e As EventArgs) Handles btnSaveDisposition.Click

        u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRSteps SET Disposition = '" & rtxtAddDisposition.Text & "' Where NCRNumber = '" & NCRNumber & "' And ActualStep = '" & ActualStep & "'")
        SearchSteps()
        MsgBox("Saved")
        rtxtAddDisposition.Text = ""

    End Sub

    Private Sub GridView4_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView4.FocusedRowChanged

        'Do not allow to delete an attachment(disable the delete button) that does not belong to the latest step
        If ActualStep <> txtActualStepAttach.Text Then
            If isSuperUser = "True" Then
                btnDeleteAttachment.Enabled = True
            Else
                btnDeleteAttachment.Enabled = False
            End If

        Else
            btnDeleteAttachment.Enabled = True
        End If

    End Sub

End Class