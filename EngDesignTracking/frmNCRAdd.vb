Imports System.ComponentModel

Public Class frmNCRAdd
    Dim NCRNumberAdd As String = ""
    Dim NCRAdded As String = ""
    Public SupplierName As String = ""
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim daOra As Oracle.ManagedDataAccess.Client.OracleDataAdapter

    Private Sub frmNCRAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection2.ConnectionString = sqlString


        ''BELOW IS AN EXAMPLE HOW TO GET THE WORK ORDER FROM JDE
        'Dim daOra As Oracle.ManagedDataAccess.Client.OracleDataAdapter
        ''Create WO Number that is one number bigger than the highest numbered one
        'da = New OracleClient.OracleDataAdapter("Select MAX(WADOCO)+1 As WorkOrderNumber From CRPDTA.F4801", OracleConnection1)
        'daOra = New Oracle.ManagedDataAccess.Client.OracleDataAdapter("SELECT YAAN8, YAALPH, YAMCU, YAHMCO, YAANPA, YAPAST, YAUN, YAJBCD, YAHMCU From proddta.F060116 Where YAAN8 = '" & Me.txtEmpNumber.Text & "' AND YAPAST = '0' OR YAAN8 = '" & Me.txtEmpNumber.Text & "' AND YAPAST = '3' OR YAAN8 = '" & Me.txtEmpNumber.Text & "' AND YAPAST = '4' OR YAAN8 = '" & Me.txtEmpNumber.Text & "' AND YAPAST = '9' ", oracleConnection1)
        'daOra.Fill(ds, "EMP")
        'EmpType = ds.Tables("EMP").Rows(0).Item("YAUN")


        Try
            'Get next NCR Number
            da = New SqlClient.SqlDataAdapter("Select NCRNumber From tblNCRNumbering Order By RecordID Desc", SqlConnection1)
            da.Fill(ds, "NCRNumber")

            If ds.Tables("NCRNumber").Rows.Count > 0 Then
                NCRNumberAdd = ds.Tables("NCRNumber").Rows(0).Item("NCRNumber")
                lblNCRNumber.Text = NCRNumberAdd

                If NCRNumberAdd = "999999" Then
                    MsgBox("You reached the last NCR Number sequence. No other NCR numbers will be created.")
                Else

                    Dim NextNCRNum As String = ""
                    NextNCRNum = NCRNumberAdd + 1
                    If NextNCRNum.Count = 4 Then
                        NextNCRNum = "00" & NextNCRNum
                    ElseIf NextNCRNum.Count = 5 Then
                        NextNCRNum = "0" & NextNCRNum
                    ElseIf NextNCRNum.Count = 6 Then
                        'Nothing
                    End If

                    u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRNumbering Set NCRNumber = '" & NextNCRNum & "'")

                End If
            End If

            ds.Tables("NCRNumber").Clear()
            ds.Tables("NCRNumber").Dispose()


            'Populate the Program drop-down
            da = New SqlClient.SqlDataAdapter("Select * From tblProgram Where Active = 'True' Order By ProgramName", SqlConnection2)
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


            '

        Catch ex As Exception
            'In case of error, set the sequence for the NCR Number to the initial one
            u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRNumbering Set NCRNumber = '" & NCRNumberAdd & "'")

            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim errors As String = ""


        'If isCalgary <> "Yes" Then
        '    If Me.cboPrograms.Text = "" Then
        '        errors = "You are required to enter a Program." & Environment.NewLine & "" & Environment.NewLine & ""
        '    End If

        '    'If Me.txtTitle.Text = "" Then
        '    '    errors = errors + "You are required to enter the Title." & Environment.NewLine & "" & Environment.NewLine & ""
        '    'End If
        'End If

        'If isCalgary <> "Yes" Then
        '    If Me.txtDrawingNum.Text = "" Then
        '        errors = errors + "You are required to enter ONE Drawing Number." & Environment.NewLine & "" & Environment.NewLine & ""
        '    End If

        '    If Me.cboRev.Text = "" Then
        '        errors = errors + "You are required to enter a Revision." & Environment.NewLine & "" & Environment.NewLine & ""
        '    End If
        'End If

        'If Me.cboWorkOrder.Text = "" Or Not IsNumeric(cboWorkOrder.Text) Then
        '    If cboWorkOrder.Text <> "Unaffiliated" Then
        '        errors = errors + "You are required to enter a numeric Work Order or select Unaffiliated from the drop down." & Environment.NewLine & "" & Environment.NewLine & ""
        '    End If
        'End If

        'If txtPurchaseOrder.Text <> "" Then
        '    If Not (IsNumeric(txtPurchaseOrder.Text)) Then
        '        errors = errors + "You are required to enter a numeric Purchase Order Number." & Environment.NewLine & "" & Environment.NewLine & ""
        '    End If
        'End If

        If Me.txtPartNumber.Text = "" Then
            errors = errors + "You are required to enter a Part Number." & Environment.NewLine & "" & Environment.NewLine & ""
        End If

        If Me.txtPartDescription.Text = "" Then
            errors = errors + "You are required to enter a Part Description." & Environment.NewLine & "" & Environment.NewLine & ""
        End If

        'If isCalgary <> "Yes" Then
        '    If Me.cboStep.Text = "" Or Not IsNumeric(cboStep.Text) Then
        '        If cboStep.Text <> "Unaffiliated" Then
        '            errors = errors + "You are required to enter a numeric Step or select Unaffiliated from the drop down." & Environment.NewLine & "" & Environment.NewLine & ""
        '        End If
        '    End If
        'End If

        'If Me.chkDrawingReqForConformityNo.Checked = False And Me.chkDrawingReqForConformityYes.Checked = False Then
        '    errors = errors + "You are required to check a box in the drawing required for conformity section." & Environment.NewLine & "" & Environment.NewLine & ""
        'End If

        If Not (IsNumeric(txtQuantityRejected.Text)) Then
            errors = errors + "You are required to enter a numeric Quantity Rejected." & Environment.NewLine & "" & Environment.NewLine & ""
        End If

        If Me.rtxtDiscrepancy.Text = "" Then
            errors = errors + "You are required to enter Description of Non-Conformance." & Environment.NewLine & "" & Environment.NewLine & ""
        End If

        If errors <> "" Then
            errors = errors + "Please correct the errors above and submit."
            MsgBox(errors)
            Exit Sub
        End If


        'If cboWorkOrder.Text = "" Then
        '    MsgBox("IMPORTANT: You must enter a valid work order and step in the format of wonumber.step in the work order number field.  If the EARR is for a work order with no step, enter the workordernumber.0")
        'End If

        ''Look for prior work.step records
        'da = New SqlClient.SqlDataAdapter("Select * from tblNCR Where WorkOrder = '" & cboWorkOrder.Text & "' Order By RecordID Desc", SqlConnection2)
        'da.Fill(ds, "EXIST")

        'If ds.Tables("EXIST").Rows.Count > 0 Then
        '    Dim s As String
        '    s = ds.Tables("EXIST").Rows(0).Item("EARRNUmber")
        '    Trim(s)
        '    Dim words As String() = s.Split(New Char() {"."c})

        '    Dim i As Integer
        '    i = Val(words(2)) + 1

        '    Me.txtEARRNumber.Text = Me.txtWorkOrder.Text + "." + Format(i, "")
        'Else
        '    Me.txtEARRNumber.Text = Me.txtWorkOrder.Text + ".1"
        'End If


        'Make the WorkOrder and Step in format WorkOrder.Step
        Dim WorkOrderStep As String = ""
        If cboWorkOrder.Text = "Unaffiliated" Or cboStep.Text = "Unaffiliated" Then
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

        'Insert New Record
        u.ExecuteSQL(SqlConnection1, "Insert Into tblNCRSteps (LatestStep,ActualStep,AcceptedStep,Step,Status,NCRNumber,SubmissionDt,OriginatorName,Disposition,AddedBy,AddedByDt,SortForReport,IsStepAccepted) Values (1, 1, Null, '1', 'Open','" & NCRNumberAdd & "', '" & Now & "', '" & System.Environment.UserName & "', '', '" & System.Environment.UserName & "', '" & Now & "', 1, '')")

        u.ExecuteSQL(SqlConnection1, "Insert Into tblNCR (LatestStep,ActualStep,Step,Status,NCRNumber,SubmissionDt,OriginatorName,Program,SerialNum,SerialNumType,AircraftIdentifier,DrawingNumber,DwgRevision,PartNumber,PartDescription,WorkOrderStep,PurchaseOrderNum,Discrepancy,Comments,Quantity,ReportedBy,Location,None,NotifyCustomer,WriteCAR,WriteSCAR,WriteCPAR,Other,Title,SortForReport,WorkOrder,StepWorkOrder,QuantityRejected,WhereDiscovered,ResponsibleDept,ResponsiblePerson,Cause,Cost,CustomerNCRNum,MaterialReturnAuthNum,SalesOrderNum,ReturnDate,TotalQuantity,SupplierPurchaseOrderNum,IsStepAccepted,Manufacturer) Values (1, 1,'1','Open','" & NCRNumberAdd & "','" & Now & "','" & System.Environment.UserName & "','" & cboPrograms.Text & "','" & txtSerialNum.Text & "','" & cboSerialNumType.Text & "','" & txtAircraftIdentifier.Text & "','" & txtDrawingNum.Text & "','" & cboRev.Text & "','" & txtPartNumber.Text & "','" & txtPartDescription.Text & "','" & WorkOrderStep & "','" & txtPurchaseOrder.Text & "','" & rtxtDiscrepancy.Text & "','" & rtxtComments.Text & "','1','" & System.Environment.UserName & "','" & LocationNCR & "',0,0,0,0,0,0,'" & txtTitle.Text & "', 1,'" & cboWorkOrder.Text & "','" & cboStep.Text & "','" & txtQuantityRejected.Text & "','" & cboWhereDiscovered.Text & "','','','','','','','','01/01/1900','','','','" & SupplierName & "')")
        NCRAdded = "Yes"


        NCRNumber = NCRNumberAdd
        frmNCRSteps.SendNotifications("NewNCR")


        MsgBox("NCR Added")

        frmNCRSteps.SendNotifications("NewNCR")

        Clear()

        Me.Close()


        'Open up the Other Info tab of the Steps form so that user can enter the rest of the info
        UserComingFromAddNCR = "Yes"
        frmNCRSteps.GetRecordIDLastNCRAdded()
        frmNCRSteps.ShowDialog()
        'frmNCRSteps.Activate()

    End Sub

    Private Sub txtPartDescription_Validated(sender As Object, e As EventArgs) Handles txtPartDescription.Validated
        txtPartDescription.Text = UCase(txtPartDescription.Text)
    End Sub

    'This is to disallow free text entry in the combobox
    Private Sub cboPrograms_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboPrograms.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboSerialNumType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboSerialNumType.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboRev_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboRev.KeyPress
        e.Handled = True
    End Sub

    Private Sub frmNCRAdd_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'Reset the NCR Number if the X is clicked to close the page
        If NCRAdded <> "Yes" Then
            u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRNumbering Set NCRNumber = '" & NCRNumberAdd & "'")
        End If


        'Me.Close()
        Dim frmNCR As New frmNCR
        frmNCR.Show()
    End Sub

    Public Function Clear()

        txtTitle.Text = ""
        lblNCRNumber.Text = ""
        cboPrograms.Text = ""
        txtSerialNum.Text = ""
        cboSerialNumType.Text = ""
        txtDrawingNum.Text = ""
        cboRev.Text = ""
        txtPartNumber.Text = ""
        txtPartDescription.Text = ""
        cboWorkOrder.Text = ""
        txtPurchaseOrder.Text = ""
        txtQuantityRejected.Text = ""
        cboWhereDiscovered.Text = ""
        rtxtDiscrepancy.Text = ""
        rtxtComments.Text = ""

    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        NCRAdded = "No"


        'Reset the NCR Number
        u.ExecuteSQL(SqlConnection1, "UPDATE tblNCRNumbering Set NCRNumber = '" & NCRNumberAdd & "'")


        'Dim frmNCR As New frmNCR
        'frmNCR.Show()
        Me.Close()

    End Sub

    'Private Sub cboWorkOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles cboWorkOrder.KeyDown

    '    If e.KeyCode = Keys.Enter Then

    '    Dim i As Integer = 0
    '    Dim PartNum As String = ""
    '    Dim PartDesc As String = ""
    '    Dim SupplierNum As String = ""
    '    Dim PurchaseOrderNum As String = ""
    '    SupplierName = ""
    '    txtPartNumber.Text = ""
    '    txtPartDescription.Text = ""

    '    'GET PART NUMBER, PART DESCRIPTION AND SUPPLIER NAME USING THE WORK ORDER ENTERED; UNLESS WE GOT THESE FROM THE PURCHASE ORDER ENTERED
    '    If txtPurchaseOrder.Text = "" And cboWorkOrder.Text <> "" Then

    '        'GET PART NUMBER:
    '        'WALITM = Part Number;  WARORN = Purchase Order
    '        daOra = New Oracle.ManagedDataAccess.Client.OracleDataAdapter("Select WALITM, WARORN From Proddta.F4801 Where WADOCO = '" & Val(cboWorkOrder.Text) & "'", oracleConnection1)
    '        daOra.Fill(ds, "PartNum")

    '        If ds.Tables("PartNum").Rows.Count > 0 Then
    '            PartNum = ds.Tables("PartNum").Rows(0).Item("WALITM")
    '            PurchaseOrderNum = ds.Tables("PartNum").Rows(0).Item("WARORN")
    '            txtPartNumber.Text = PartNum

    '            ds.Tables("PartNum").Clear()
    '            ds.Tables("PartNum").Dispose()
    '        End If


    '        'GET PART DESCRIPTION:
    '        If PartNum <> "" Then
    '            'IMDSC1 = Part Description;  IMLITM = Part Number
    '            daOra = New Oracle.ManagedDataAccess.Client.OracleDataAdapter("Select IMDSC1 From Proddta.F4101 Where IMLITM = '" & PartNum & "'", oracleConnection1)
    '            daOra.Fill(ds, "PartDesc")

    '            If ds.Tables("PartDesc").Rows.Count > 0 Then
    '                PartDesc = ds.Tables("PartDesc").Rows(0).Item("IMDSC1")
    '                txtPartDescription.Text = PartDesc

    '                ds.Tables("PartDesc").Clear()
    '                ds.Tables("PartDesc").Dispose()
    '            End If
    '        End If


    '        'GET SUPPLIER NAME:
    '        If PurchaseOrderNum <> "" Then

    '            'PHAN8 = Supplier Number;  PHDOCO = Purchase Order Number
    '            daOra = New Oracle.ManagedDataAccess.Client.OracleDataAdapter("Select PHAN8 From Proddta.F4301 Where PHDOCO = '" & PurchaseOrderNum & "'", oracleConnection1)
    '            daOra.Fill(ds, "SupplierNum")

    '            If ds.Tables("SupplierNum").Rows.Count > 0 Then
    '                SupplierNum = ds.Tables("SupplierNum").Rows(0).Item("PHAN8")

    '                ds.Tables("SupplierNum").Clear()
    '                ds.Tables("SupplierNum").Dispose()
    '            End If


    '            If SupplierNum <> "" Then
    '                'ABALPH = Supplier Name;  ABAN8 = Supplier Number
    '                daOra = New Oracle.ManagedDataAccess.Client.OracleDataAdapter("Select ABALPH From Proddta.F0101 Where ABAN8 = '" & SupplierNum & "'", oracleConnection1)
    '                daOra.Fill(ds, "SupplierName")

    '                If ds.Tables("SupplierName").Rows.Count > 0 Then
    '                    SupplierName = ds.Tables("SupplierName").Rows(0).Item("ABALPH")

    '                    ds.Tables("SupplierName").Clear()
    '                    ds.Tables("SupplierName").Dispose()
    '                End If
    '            End If

    '        End If

    '    End If

    '    'cboProgram.Items.Add(ds.Tables("Programs").Rows(p).Item("ProjectNumber")

    'End If

    'End Sub

    Private Sub txtPurchaseOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPurchaseOrder.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim PartNum As String = ""
            Dim PartDesc As String = ""
            Dim SupplierNum As String = ""
            SupplierName = ""
            txtPartNumber.Text = ""
            txtPartDescription.Text = ""

            'GET PART NUMBER, PART DESCRIPTION AND SUPPLIER NAME USING THE PURCHASE ORDER ENTERED; UNLESS WE GOT THESE FROM THE WORK ORDER ENTERED
            If txtPurchaseOrder.Text <> "" Then     'cboWorkOrder.Text = "" And 

                'GET PART NUMBER:
                'If txtPartNumber.Text = "" Then
                'PDLITM = Part Number;  PDAN8 = Supplier Number
                daOra = New Oracle.ManagedDataAccess.Client.OracleDataAdapter("Select PDLITM, PDAN8 From Proddta.F4311 Where PDDOCO = '" & Val(txtPurchaseOrder.Text) & "'", oracleConnection1)
                daOra.Fill(ds, "PartNum")

                If ds.Tables("PartNum").Rows.Count > 0 Then
                    PartNum = ds.Tables("PartNum").Rows(0).Item("PDLITM")
                    SupplierNum = ds.Tables("PartNum").Rows(0).Item("PDAN8")
                    txtPartNumber.Text = PartNum

                    ds.Tables("PartNum").Clear()
                    ds.Tables("PartNum").Dispose()
                End If
                'Else
                '    PartNum = txtPartNumber.Text
                'End If


                'GET PART DESCRIPTION:
                If PartNum <> "" Then
                    'IMDSC1 = Part Description;  IMLITM = Part Number
                    daOra = New Oracle.ManagedDataAccess.Client.OracleDataAdapter("Select IMDSC1 From Proddta.F4101 Where IMLITM = '" & PartNum & "'", oracleConnection1)
                    daOra.Fill(ds, "PartDesc")

                    If ds.Tables("PartDesc").Rows.Count > 0 Then
                        PartDesc = ds.Tables("PartDesc").Rows(0).Item("IMDSC1")
                        txtPartDescription.Text = PartDesc

                        ds.Tables("PartDesc").Clear()
                        ds.Tables("PartDesc").Dispose()
                    End If
                End If


                'GET SUPPLIER NAME:
                If SupplierNum <> "" Then
                    'ABALPH = Supplier Name;  ABAN8 = Supplier Number
                    daOra = New Oracle.ManagedDataAccess.Client.OracleDataAdapter("Select ABALPH From Proddta.F0101 Where ABAN8 = '" & SupplierNum & "'", oracleConnection1)
                    daOra.Fill(ds, "SupplierName")

                    If ds.Tables("SupplierName").Rows.Count > 0 Then
                        SupplierName = ds.Tables("SupplierName").Rows(0).Item("ABALPH")

                        ds.Tables("SupplierName").Clear()
                        ds.Tables("SupplierName").Dispose()
                    End If
                End If

            End If

        End If
    End Sub

    'The two Subs below can also be used for the above:
    'Private Sub txtPurchaseOrder_Leave(sender As Object, e As EventArgs) Handles txtPurchaseOrder.Leave

    'End Sub

    'Private Sub txtPurchaseOrder_Validating(sender As Object, e As CancelEventArgs) Handles txtPurchaseOrder.Validating

    'End Sub

End Class