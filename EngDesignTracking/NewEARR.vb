Public Class NewEARR

    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim QC As String
    Dim QCBackup As String
    Dim OriginatorSignOff As Date
    Dim LiaisonEngineer As String
    Dim LiaisonEngineerBackup As String
    Dim EngineerManager As String
    Dim EngineerManagerBackup As String
    Dim Planner1 As String
    Dim Planner2 As String
    Dim EARRNUmber As Integer

    Private Sub btnSubmitEARR_Click(sender As Object, e As EventArgs) Handles btnSubmitEARR.Click
        Dim errors As String = ""



        If Me.txtEARRNumber.Text = "" Then
            errors = "You are required to enter a earr number." & Environment.NewLine & "" & Environment.NewLine & ""

        End If
        If cboEARRType.Text = "" Then
            errors = errors + "You are required to enter a EARR type." & Environment.NewLine & "" & Environment.NewLine & ""

        End If
        If Me.cboProgramName.Text = "" Then
            errors = errors + "You are required to enter a program name." & Environment.NewLine & "" & Environment.NewLine & ""

        End If
        If Me.txtEndItemType.Text = "" Then
            errors = errors + "Your are required to enter a end item type." & Environment.NewLine & "" & Environment.NewLine & ""

        End If
        If Me.txtSerialNumber.Text = "" Then
            errors = errors + "You are required to enter a serial number." & Environment.NewLine & "" & Environment.NewLine & ""

        End If

        If Me.txtWorkOrder.Text = "" Then
            errors = errors + "You are required to enter a work order.seq number." & Environment.NewLine & "" & Environment.NewLine & ""

        End If

        If Me.txtDrawingNumber.Text = "" Then
            errors = errors + "You are required to enter a drawing number." & Environment.NewLine & "" & Environment.NewLine & ""

        End If

        If Me.txtDrawingRevision.Text = "" Then
            errors = errors + "You are required to enter a drawing revision." & Environment.NewLine & "" & Environment.NewLine & ""

        End If

        If Me.txtRequest.Text = "" Then
            errors = errors + "You are required to enter a request." & Environment.NewLine & "" & Environment.NewLine & ""

        End If

        If Me.chkIncorpRedLineNo.Checked = False And Me.chkIncorpRedLineYes.Checked = False Then
            errors = errors + "You are required to check a box in the incorporate redline section." & Environment.NewLine & "" & Environment.NewLine & ""

        End If

        If Me.chkDrawingReqForConformityNo.Checked = False And Me.chkDrawingReqForConformityYes.Checked = False Then
            errors = errors + "You are required to check a box in the drawing required for conformity section." & Environment.NewLine & "" & Environment.NewLine & ""

        End If

        If errors <> "" Then
            errors = errors + "Please correct the errors above and submit."
            MsgBox(errors)
            Exit Sub

        End If
        '******NEEED TO GET NEXT EARR NUMBER!

        If Me.cboProgramName.Text = "" Or Me.cboEARRType.Text = "" Then
            MsgBox("You must select a Program Name and EARR Type before continuining.")
            Exit Sub
        End If

        If Me.txtWorkOrder.Text = "" Then
            MsgBox("IMPORTANT:  You must enter a valid work order and step in the format of wonumber.step in the work order number field unless you have checked fab shop.  If the EARR is for a work order with no step, enter the workordernumber.0")
        End If


        'If chkFabShop.Checked = True Then
        '    Me.txtWorkOrder.Text = "N/A"
        '    Me.txtEARRNumber.Text = Format(Now, "mmddyyyyhhss")


        'Else
        'Look for prior work.step records.
        da = New SqlClient.SqlDataAdapter("Select * from tblEARR Where WorkOrder = '" & Me.txtWorkOrder.Text & "' Order By RecordID Desc", SqlConnection2)
            da.Fill(ds, "EXIST")

            If ds.Tables("EXIST").Rows.Count > 0 Then
                Dim s As String
                s = ds.Tables("EXIST").Rows(0).Item("EARRNUmber")
                Trim(s)
                Dim words As String() = s.Split(New Char() {"."c})

                Dim i As Integer
                i = Val(words(2)) + 1

                Me.txtEARRNumber.Text = Me.txtWorkOrder.Text + "." + Format(i, "")
            Else
                Me.txtEARRNumber.Text = Me.txtWorkOrder.Text + ".100"
            End If

        'End If


        'If exist, need to look at EARR number and get the last value.



        'Step 1:  Have Originator Confirm they intend to submit this.

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to submit this EARR?  By confirming yes you are agreeing that everything stated on the EARR is accurate to the best of your knowledge.",
                      "Title",
                      MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            OriginatorSignOff = Now
        Else
            MsgBox("This screen will now be closed.  If you want to re-enter a EARR you can at a later time.")
            Me.Close()
        End If

        'Step 2:  Based on program/EARR Type, populate the LiaisonManager name and the backup.

        If cboProgramName.Text = "Jaguar" And cboEARRType.Text = "Mechanical" Then
            LiaisonEngineer = "jslater@fieldaero.com"
            LiaisonEngineerBackup = "dgriffin@fieldaero.com"
            'No current Backup.
        ElseIf cboProgramName.Text = "Jaguar" And cboEARRType.Text = "Electrical" Then
            LiaisonEngineer = "mwebe@fieldaero.com"
            LiaisonEngineerBackup = "nhorstman@fieldaero.com"
        End If

        If cboProgramName.Text = "Sherpa" And cboEARRType.Text = "Mechanical" Then
            LiaisonEngineer = "jslater@fieldaero.com"
            LiaisonEngineerBackup = "alee@fieldaero.com"
        ElseIf cboProgramName.Text = "Sherpa" And cboEARRType.Text = "Electrical" Then
            LiaisonEngineer = "dmolloy@fieldaero.com"
            LiaisonEngineerBackup = "pdonnell@fieldaero.com"
            'No current Backup.
        End If
        If cboProgramName.Text = "16082 - Jaguar" Then
            LiaisonEngineer = "mpoma@fieldav.com"
        End If

        'Step 3:  Based on the program/EARR Type, populate the Engineering Manager name and the backup

        If cboProgramName.Text = "Jaguar" And cboEARRType.Text = "Mechanical" Then
            EngineerManager = "ohaswell@fieldav.com"
            EngineerManagerBackup = "alee@fieldaero.com"

        ElseIf cboProgramName.Text = "Jaguar" And cboEARRType.Text = "Electrical" Then

            EngineerManager = "jspillane@fieldaero.com"
            EngineerManagerBackup = "PDONNELL@fieldaero.com"

        End If

        If cboProgramName.Text = "Sherpa" And cboEARRType.Text = "Mechanical" Then
            EngineerManager = "ohaswell@fieldav.com"
            EngineerManagerBackup = "alee@fieldaero.com"

        ElseIf cboProgramName.Text = "Sherpa" And cboEARRType.Text = "Electrical" Then

            EngineerManager = "jspillane@fieldaero.com"
            EngineerManagerBackup = "PDONNELL@fieldaero.com"

        End If

        If cboProgramName.Text = "16082 - Jaguar" Then
            EngineerManager = "mpoma@fieldav.com"
        End If

        'Step 4:  Based on the program/EARR Type, populate the planner1 and planner2.

        If cboProgramName.Text = "Jaguar" Then

            Planner1 = "GGOODLAN@fieldaero.com"
            Planner2 = "RPATTERS@fieldaero.com"
            If chkFabShop.Checked = True Then
                QC = "twahnon@fieldaero.com"
                QCBackup = "dnolting@fieldaero.com"
            Else
                QC = "rburr@fieldaero.com"
                QCBackup = "sstokes@fieldaero.com"
            End If

        End If

        If Me.cboProgramName.Text = "QCTEST" Then
            Planner1 = "acooper@fieldaero.com"
            Planner2 = "acooper@fieldaero.com"
            QC = "acooper@fieldaero.com"
            QCBackup = "acooper@fieldaero.com"
            LiaisonEngineer = "acooper@fieldaero.com"
            LiaisonEngineerBackup = "acooper@fieldaero.com"
            EngineerManager = "acooper@fieldaer.com"
            EngineerManagerBackup = "acooper@fieldaero.com"
        End If

        If cboProgramName.Text = "Sherpa" Then
            Planner1 = "dfuentez@fieldaero.com"
            Planner2 = "rpatters@fieldaero.com"
            QC = "rdclark@fieldaero.com"
            QCBackup = "dnolting@fieldaero.com"
        End If

        If cboProgramName.Text = "16082 - Jaguar" Then
            Planner1 = "kticknor@fieldav.com"
        End If

        If chkFabShop.Checked = True Then
            Planner1 = "rmartin@fieldaero.com"
            Planner2 = ""
        End If

        'Step 5:  Submit to database.
        u.ExecuteSQL(SqlConnection2, "INSERT INTO tblEARR (EARRNumber,EARRStatus,EARRType,SerialNumber,WorkOrder,ProgramName,DrawingNumber,DrawingRevision,Request,IncorpRedLineYes,IncorpRedLineNo,DRawingReqForConformityYes,DrawingReqForConformityNo,EARRResponseDate,OriginatorName,OriginatorDate,OriginatorSignedOff,ReplyInstructions,EffectivityAll,EffectivityOther,EffectivityOtherText,DeviationMinor,DeviationMajor,AdditionalEngReqNoAction,AdditionalEngReqUpdate,ACFTInterface,Manufacturability,ProductImprovement,DWGError,DesignError,LiaisonManagerName,LiaisonManagerNameBackup,LiaisonManagerSignOffDate,EngineeringManagerName,EngineeringManagerNameBackup,EngineeringManagerSignOffDate,Planner1,Planner2, QCName, QCNameBackup, QCSignOff, FabShop, ProductionError, QCNotes, PlannerSignOffDate, PlannerNotes, EndItemType, DeviationNA) Values ('" & Me.txtEARRNumber.Text & "', 'Pending', '" & u.FTM(Me.cboEARRType.Text) & "', '" & Me.txtSerialNumber.Text & "', '" & Me.txtWorkOrder.Text & "', '" & u.FTM(Me.cboProgramName.Text) & "', '" & Me.txtDrawingNumber.Text & "', '" & u.FTM(Me.txtDrawingRevision.Text) & "', '" & u.FTM(Me.txtRequest.Text) & "', '" & chkIncorpRedLineYes.CheckState & "', '" & Me.chkIncorpRedLineNo.CheckState & "','" & Me.chkDrawingReqForConformityYes.CheckState & "', '" & Me.chkDrawingReqForConformityNo.CheckState & "', '01/01/1900', '" & u.FTM(txtOriginatorName.Text) & "', '" & Me.dtOriginatorDate.Value & "', '" & Now & "', '',0,0,'', 0,0,0,0,0,0,0,0,0,'" & LiaisonEngineer & "', '" & LiaisonEngineerBackup & "', '01/01/1900', '" & EngineerManager & "', '" & EngineerManagerBackup & "', '01/01/1900', '" & Planner1 & "', '" & Planner2 & "', '" & Me.QC & "', '" & Me.QCBackup & "', '01/01/1900', '" & Me.chkFabShop.Checked & "', 'False', '', '01/01/1900', '', '" & u.FTM(Me.txtEndItemType.Text) & "', 'False')")
        MsgBox("EARR has been submitted!")

        'Send Email to planners and eng liaisons

        u.SendEmail("system@fieldaero.com", Planner1 + "; " + Planner2 + "; " + LiaisonEngineer + "; " + LiaisonEngineerBackup, "A new EARR has been submitted for program:  " + Me.cboProgramName.Text, "Please respond to the EARR.  The EARR Number is:  " + Me.txtEARRNumber.Text)

        Dim frmEARRGrid As New frmEARRGrid
        frmEARRGrid.Show()
        Me.Close()

    End Sub

    Private Sub NewEARR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection2.ConnectionString = sqlString1
        Me.txtEARRNumber.Text = "Pending EARR Number"
        txtOriginatorName.Text = EARRORIGNAME
        dtOriginatorDate.Value = Now
        dtEARRResponseDate.Value = "01/01/1900"

        MsgBox("IMPORTANT:  You must enter a valid work order and step in the format of wonumber.step in the work order number field.  If the EARR is for a work order with no step, enter the workordernumber.0")

        ''Load Revisions Information
        'da = New SqlClient.SqlDataAdapter("Select * from tblRevisionsLookup Order By Sort Asc", SqlConnection2)
        'da.Fill(ds, "Revisions")

        'Dim i As Integer = 0
        'While i <= ds.Tables("Revisions").Rows.Count - 1
        '    Me.txtDrawingRevision.Items.Add(ds.Tables("Revisions").Rows(i).Item("Rev"))
        '    i = i + 1
        'End While



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim frmEARRGrid As New frmEARRGrid
        frmEARRGrid.Show()
        Me.Close()
    End Sub

    Private Sub chkFabShop_CheckStateChanged(sender As Object, e As EventArgs) Handles chkFabShop.CheckStateChanged
        If Me.chkFabShop.Checked = True Then
            Me.txtWorkOrder.Text = "FAB.0"
        Else

            Me.txtWorkOrder.Text = ""
            MsgBox("You need to enter the work order.step number in the work order field.")

        End If
    End Sub
End Class