Imports System.IO

Public Class frmEARRApproval
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim ReturnID As Integer
    Dim SignedName As String = ""
    Private Sub frmEARRApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If EARRREADONLY = "-1" Then

            Me.btnSaveEARR.Enabled = False
        Else
            Me.btnSaveEARR.Enabled = True
        End If

        SqlConnection1.ConnectionString = sqlString1

        da = New SqlClient.SqlDataAdapter("Select * from tblUsers Where Username = '" & User & "'", SqlConnection1)
        da.Fill(ds, "GETEMAIL")

        SignedName = ds.Tables("GETEMAIL").Rows(0).Item("SignedName")

        Search()
        GridView1.BestFitColumns()

        XtraTabControl1.SelectedTabPage = XtraTabPage1
        XtraTabControl1.SelectedTabPage = XtraTabPage2
        XtraTabControl1.SelectedTabPage = XtraTabPage3
        XtraTabControl1.SelectedTabPage = XtraTabPage4
        XtraTabControl1.SelectedTabPage = XtraTabPage5
        XtraTabControl1.SelectedTabPage = XtraTabPage1

        GetFileUploadRecords()

    End Sub

    Public Function Search()

        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet51.tblEARR.Clear()

        Me.txtRecordID.DataBindings.Clear()
        Me.cboProgramName.DataBindings.Clear()
        Me.txtSerialNumber.DataBindings.Clear()
        Me.txtWorkOrder.DataBindings.Clear()
        Me.cboEARRType.DataBindings.Clear()
        Me.txtDrawingNumber.DataBindings.Clear()
        Me.txtDrawingRevision.DataBindings.Clear()
        Me.txtRequest.DataBindings.Clear()
        Me.chkIncorpRedLineNo.DataBindings.Clear()
        Me.chkIncorpRedLineYes.DataBindings.Clear()
        Me.chkDrawingRequestForConformityNo.DataBindings.Clear()
        Me.chkDrawingRequestForConformityYes.DataBindings.Clear()
        Me.dtEARRResponseDate.DataBindings.Clear()
        Me.txtOriginatorName.DataBindings.Clear()
        Me.dtOriginatorDate.DataBindings.Clear()
        'Me.dtOriginatorSignedOff.DataBindings.Clear()
        Me.txtReplyInstructions.DataBindings.Clear()
        Me.chkEffectivityAll.DataBindings.Clear()
        Me.chkEffectivityOther.DataBindings.Clear()
        Me.txtEffectivityOtherText.DataBindings.Clear()
        Me.chkDeviationMajor.DataBindings.Clear()
        Me.chkDeviationMinor.DataBindings.Clear()
        Me.chkDeviationNA.DataBindings.Clear()
        Me.chkAdditionalEngReqNoAction.DataBindings.Clear()
        Me.chkAdditionalEngReqUpdate.DataBindings.Clear()
        Me.chkACFTInterface.DataBindings.Clear()
        Me.chkManufacturability.DataBindings.Clear()
        Me.chkProductImprovement.DataBindings.Clear()
        Me.chkDWGError.DataBindings.Clear()
        Me.chkDesignError.DataBindings.Clear()
        Me.txtLiaisonManagerName.DataBindings.Clear()
        Me.txtLiaisonManagerNameBackup.DataBindings.Clear()
        Me.dtLiaisonManagerSignOffDate.DataBindings.Clear()
        Me.txtEngineeringManagerName.DataBindings.Clear()
        Me.txtEngineeringManagerNameBackup.DataBindings.Clear()
        Me.dtEngineeringManagerSignOffDate.DataBindings.Clear()
        Me.txtEARRNumber.DataBindings.Clear()
        Me.txtQCName.DataBindings.Clear()
        Me.txtQCNameBackup.DataBindings.Clear()
        Me.txtPlanner1.DataBindings.Clear()
        Me.txtPlanner2.DataBindings.Clear()
        Me.chkProductionError.DataBindings.Clear()
        Me.txtQCNotes.DataBindings.Clear()
        Me.dtPlanningSignOffDate.DataBindings.Clear()
        Me.txtPlanningNotes.DataBindings.Clear()
        Me.txtEndItemType.DataBindings.Clear()
        Me.txtEARRStatus.DataBindings.Clear()



        Dim cmdSave As String


        If EditEARR <> 0 Then
            SqlString = " Where RecordID = '" & Val(EditEARR) & "'"
        Else
            SqlString = " Where LiaisonManagerName = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND LiaisonManagerSignOffDate = '01/01/1900' OR LiaisonManagerNameBackup = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND LiaisonManagerSignOffDate = '01/01/1900' OR EngineeringManagerName = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND EngineeringManagerSignOffDate = '01/01/1900' OR EngineeringManagerNameBackup = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND EngineeringManagerSignOffDate = '01/01/1900' OR QCName = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND QCSignOff = '01/01/1900' OR QCNameBackup = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND QCSignOff = '01/01/1900' OR Planner1 = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND EARRNumber = 'Pending EARR Number' OR Planner2 = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND EARRNumber = 'Pending EARR Number' OR Planner1 = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND PlannerSignOffDate = '01/01/1900' OR Planner2 = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND PlannerSignOffDate = '01/01/1900'"

        End If
        EditEARR = 0


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString


        ''If Me.cboSchoolYearEnrolledIn.Text = "2013" And Me.txtLastNameSearch.Text = "" And BackToPerson = 0 Then
        ''	Me.SqlDataAdapter1.SelectCommand.CommandText() = "SELECT * FROM vwStudents  A INNER JOIN tblStudents B ON  A.RecordID = B.RecordID INNER JOIN  tblClassEnrollment C ON B.RecordID = C.StudentID Where C.SchoolYear = '2013' ORDER BY C.StudentLast Asc"
        ''End If

        Try
            Me.SqlDataAdapter1.Fill(DataSet51.tblEARR)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        If Me.DataSet51.Tables("tblEARR").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            Search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text",
            Me.BindingSource1, "RecordID")
            Me.cboProgramName.DataBindings.Add("Text",
            Me.BindingSource1, "ProgramName")
            Me.txtSerialNumber.DataBindings.Add("Text",
            Me.BindingSource1, "SerialNumber")
            Me.txtWorkOrder.DataBindings.Add("Text",
            Me.BindingSource1, "WorkOrder")
            Me.cboEARRType.DataBindings.Add("Text",
            Me.BindingSource1, "EARRType")
            Me.txtDrawingNumber.DataBindings.Add("Text",
            Me.BindingSource1, "DrawingNumber")
            Me.txtDrawingRevision.DataBindings.Add("Text",
            Me.BindingSource1, "DrawingRevision")
            Me.txtRequest.DataBindings.Add("Text",
            Me.BindingSource1, "Request")
            Me.chkIncorpRedLineNo.DataBindings.Add("Checked",
            Me.BindingSource1, "IncorpRedLineNo")
            Me.chkIncorpRedLineYes.DataBindings.Add("Checked",
            Me.BindingSource1, "IncorpRedLineYes")
            Me.chkDrawingRequestForConformityNo.DataBindings.Add("Checked",
            Me.BindingSource1, "DrawingReqForConformityNo")
            Me.chkDrawingRequestForConformityYes.DataBindings.Add("Checked",
            Me.BindingSource1, "DrawingReqForConformityYes")
            Me.dtEARRResponseDate.DataBindings.Add("Value",
            Me.BindingSource1, "EARRResponseDate")
            Me.txtOriginatorName.DataBindings.Add("Text",
            Me.BindingSource1, "OriginatorName")
            Me.dtOriginatorDate.DataBindings.Add("Value",
            Me.BindingSource1, "OriginatorDate")
            'Me.dtOriginatorSignedOff.DataBindings.Add("Value",
            'Me.BindingSource1, "OriginatorSignedOff")
            Me.txtReplyInstructions.DataBindings.Add("Text",
            Me.BindingSource1, "ReplyInstructions")
            Me.chkEffectivityAll.DataBindings.Add("Checked",
            Me.BindingSource1, "EffectivityAll")
            Me.chkEffectivityOther.DataBindings.Add("Checked",
            Me.BindingSource1, "EffectivityOther")
            Me.txtEffectivityOtherText.DataBindings.Add("Text",
            Me.BindingSource1, "EffectivityOtherText")
            Me.chkDeviationMajor.DataBindings.Add("Checked",
            Me.BindingSource1, "DeviationMajor")
            Me.chkDeviationMinor.DataBindings.Add("Checked",
            Me.BindingSource1, "DeviationMinor")
            Me.chkDeviationNA.DataBindings.Add("Checked",
            Me.BindingSource1, "DeviationNA")
            Me.chkAdditionalEngReqNoAction.DataBindings.Add("Checked",
            Me.BindingSource1, "AdditionalEngReqNoAction")
            Me.chkAdditionalEngReqUpdate.DataBindings.Add("Checked",
            Me.BindingSource1, "AdditionalEngReqUpdate")
            Me.chkACFTInterface.DataBindings.Add("Checked",
            Me.BindingSource1, "ACFTInterface")
            Me.chkManufacturability.DataBindings.Add("Checked",
            Me.BindingSource1, "Manufacturability")
            Me.chkProductImprovement.DataBindings.Add("Checked",
            Me.BindingSource1, "ProductImprovement")
            Me.chkDWGError.DataBindings.Add("Checked",
            Me.BindingSource1, "DWGError")
            Me.chkDesignError.DataBindings.Add("Checked",
            Me.BindingSource1, "DesignError")
            Me.txtLiaisonManagerName.DataBindings.Add("Text",
            Me.BindingSource1, "LiaisonManagerName")
            Me.txtLiaisonManagerNameBackup.DataBindings.Add("Text",
            Me.BindingSource1, "LiaisonManagerNameBackup")
            Me.dtLiaisonManagerSignOffDate.DataBindings.Add("Value",
            Me.BindingSource1, "LiaisonManagerSignOffDate")
            Me.txtEngineeringManagerName.DataBindings.Add("Text",
            Me.BindingSource1, "EngineeringManagerName")
            Me.txtEngineeringManagerNameBackup.DataBindings.Add("Text",
            Me.BindingSource1, "EngineeringManagerNameBackup")
            Me.dtEngineeringManagerSignOffDate.DataBindings.Add("Value",
            Me.BindingSource1, "EngineeringManagerSignOffDate")
            Me.txtEARRNumber.DataBindings.Add("Text",
            Me.BindingSource1, "EARRNumber")
            Me.txtQCName.DataBindings.Add("Text",
            Me.BindingSource1, "QCName")
            Me.txtQCNameBackup.DataBindings.Add("Text",
            Me.BindingSource1, "QCNameBackup")
            Me.dtQCDateSignoff.DataBindings.Add("Value",
            Me.BindingSource1, "QCSignOff")
            Me.txtPlanner1.DataBindings.Add("Text",
Me.BindingSource1, "Planner1")
            Me.txtPlanner2.DataBindings.Add("Text",
Me.BindingSource1, "Planner2")
            Me.chkProductionError.DataBindings.Add("Checked",
Me.BindingSource1, "ProductionError")
            Me.txtQCNotes.DataBindings.Add("Text",
Me.BindingSource1, "QCNotes")
            Me.dtPlanningSignOffDate.DataBindings.Add("Value",
Me.BindingSource1, "PlannerSignOffDate")
            Me.txtPlanningNotes.DataBindings.Add("Text",
Me.BindingSource1, "PlannerNotes")
            Me.txtEndItemType.DataBindings.Add("Text",
Me.BindingSource1, "EndItemType")
            Me.txtEARRStatus.DataBindings.Add("Text",
Me.BindingSource1, "EARRStatus")

        Else
            MsgBox("You have no records to approve.  Click close to return to the main screen and search for another EARR.")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If

    End Function

    Private Sub btnLiaisonSignOff_Click(sender As Object, e As EventArgs) Handles btnLiaisonSignOff.Click
        Dim errors As String = ""



        If Me.txtReplyInstructions.Text = "" Then
            errors = "Data is required in the reply instructions field.  Please enter data in the reply instructions field and sign-off." & Environment.NewLine & "" & Environment.NewLine & ""

        End If
        If chkEffectivityAll.Checked = False And chkEffectivityOther.Checked = False Then
            errors = errors + "You are required to select a effectivity check box." & Environment.NewLine & "" & Environment.NewLine & ""

        End If
        If chkDeviationMinor.Checked = False And chkDeviationMajor.Checked = False And chkDeviationNA.Checked = False Then
            errors = errors + "You are required to select a deviation type." & Environment.NewLine & "" & Environment.NewLine & ""

        End If
        If chkAdditionalEngReqNoAction.Checked = False And chkAdditionalEngReqUpdate.Checked = False Then
            errors = errors + "Your are required to select a engineering action." & Environment.NewLine & "" & Environment.NewLine & ""

        End If
        If chkACFTInterface.Checked = False And chkManufacturability.Checked = False And chkProductImprovement.Checked = False And chkDWGError.Checked = False And chkDesignError.Checked = False And chkProductionError.Checked = False Then
            errors = errors + "You are required To Select a category before signing off." & Environment.NewLine & "" & Environment.NewLine & ""

        End If

        If errors <> "" Then
            errors = errors + "Please correct the errors above and sign-off."
            MsgBox(errors)
            Exit Sub

        End If



        If Me.txtLiaisonManagerName.Text = ds.Tables("GETEMAIL").Rows(0).Item("Email") Or Me.txtLiaisonManagerNameBackup.Text = ds.Tables("GETEMAIL").Rows(0).Item("Email") Then

            Me.txtLiaisonManagerName.Text = SignedName
            u.ExecuteSQL(SqlConnection1, "UPDATE tblEARR Set LiaisonManagerName = '" & Me.txtLiaisonManagerName.Text & "', LiaisonManagerSignOffDate = '" & Now & "', EARRStatus = 'Liaison Signed Off' Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
            MsgBox("EARR has been signed off.  Screen will now be refreshed.")
            'MsgBox("system@fieldaero.com", Me.txtEngineeringManagerName.Text + "; " + Me.txtEngineeringManagerNameBackup.Text, "An EARR has been signed off by the Liaison.", "A EARR has been signed off by engineer liaison:  " + Me.cboProgramName.Text, "Please respond to the EARR.")
            u.SendEmail("system@fieldaero.com", Me.txtEngineeringManagerName.Text + "; " + Me.txtEngineeringManagerNameBackup.Text, "An EARR has been signed off by the Liaison Engineer.", "A EARR has been signed off by liaison engineer for proram:  " + Me.cboProgramName.Text + "  The EARR Number is: " + Me.txtEARRNumber.Text + "Please respond to the EARR.")
            EditEARR = Val(Me.txtRecordID.Text)
            btnSaveSelectedEARR.PerformClick()

            Dim frmEARRApproval As New frmEARRApproval
            frmEARRApproval.Show()
            Me.Close()
        Else

            MsgBox("You are not allowed to sign off as Liaison Engineer.")

        End If

    End Sub

    Private Sub btnEngManagerSignOff_Click(sender As Object, e As EventArgs) Handles btnEngManagerSignOff.Click
        If Me.txtEngineeringManagerName.Text = ds.Tables("GETEMAIL").Rows(0).Item("Email") Or Me.txtEngineeringManagerNameBackup.Text = ds.Tables("GETEMAIL").Rows(0).Item("Email") Then

            Me.txtEngineeringManagerName.Text = SignedName
            u.ExecuteSQL(SqlConnection1, "UPDATE tblEARR Set EngineeringManagerName = '" & Me.txtEngineeringManagerName.Text & "', EngineeringManagerSignOffDate = '" & Now & "', EARRStatus = 'Engineering Manager Signed Off' Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
            MsgBox("EARR has been signed off.  Screen will now be refreshed.")
            Me.btnSaveSelectedEARR.PerformClick()

            If Me.cboProgramName.Text = "16082 - Jaguar" Then
                u.SendEmail("system@fieldaero.com", "tsingh@fieldav.com", "EARR HAS BEEN SIGNED OFF BY ENG MANAGER", "A EARR has been signed off by the Engineering Manager.  The program is:  " + Me.cboProgramName.Text + "  The EARR number is " + Me.txtEARRNumber.Text + ".")
            Else
                u.SendEmail("system@fieldaero.com", Me.txtQCName.Text + "; " + Me.txtQCNameBackup.Text, "EARR SIGNED OFF BY ENG MANAGER", "A EARR has been signed off by the Engineering Manager.  The program is:  " + Me.cboProgramName.Text + " and the Earr Number is: " + Me.txtEARRNumber.Text + "Please respond to the EARR.")
            End If
            EditEARR = Val(Me.txtRecordID.Text)
            Dim frmEARRApproval As New frmEARRApproval
            frmEARRApproval.Show()
            Me.Close()
        Else

            MsgBox("You are not allowed to sign off as Engineering Manager.")

        End If
    End Sub

    Private Sub btnSaveSelectedEARR_Click(sender As Object, e As EventArgs) Handles btnSaveSelectedEARR.Click
        u.ExecuteSQL(SqlConnection1, "Update tblEARR Set EARRNumber = '" & Me.txtEARRNumber.Text & "', EARRType = '" & u.FTM(Me.cboEARRType.Text) & "', SerialNumber = '" & u.FTM(Me.txtSerialNumber.Text) & "', WorkOrder = '" & Me.txtWorkOrder.Text & "', ProgramName = '" & u.FTM(Me.cboProgramName.Text) & "', DrawingNumber = '" & Me.txtDrawingNumber.Text & "', DrawingRevision = '" & Me.txtDrawingRevision.Text & "', Request = '" & u.FTM(Me.txtRequest.Text) & "', IncorpRedLineYes = '" & Me.chkIncorpRedLineYes.CheckState & "', IncorpRedLineNo = '" & Me.chkIncorpRedLineNo.CheckState & "', DrawingReqForConformityYes = '" & Me.chkDrawingRequestForConformityYes.CheckState & "', DrawingReqForConformityNo = '" & Me.chkDrawingRequestForConformityNo.CheckState & "', EARRResponseDate = '" & dtEARRResponseDate.Value & "', OriginatorName = '" & u.FTM(Me.txtOriginatorName.Text) & "', OriginatorDate = '" & Me.dtOriginatorDate.Value & "', ReplyInstructions = '" & u.FTM(Me.txtReplyInstructions.Text) & "', EffectivityAll = '" & Me.chkEffectivityAll.CheckState & "', EffectivityOther = '" & Me.chkEffectivityOther.CheckState & "', EffectivityOtherText = '" & u.FTM(Me.txtEffectivityOtherText.Text) & "', DeviationMinor = '" & Me.chkDeviationMinor.CheckState & "', DeviationMajor = '" & Me.chkDeviationMajor.CheckState & "', DeviationNA = '" & Me.chkDeviationNA.CheckState & "', AdditionalEngReqNoAction = '" & Me.chkAdditionalEngReqNoAction.CheckState & "', AdditionalEngReqUpdate = '" & Me.chkAdditionalEngReqUpdate.CheckState & "', ACFTInterface = '" & Me.chkACFTInterface.CheckState & "', Manufacturability = '" & Me.chkManufacturability.CheckState & "', ProductImprovement = '" & Me.chkProductImprovement.CheckState & "', DWGError = '" & Me.chkDWGError.CheckState & "', DesignError = '" & Me.chkDesignError.CheckState & "', ProductionError = '" & Me.chkProductionError.CheckState & "', EndItemType = '" & u.FTM(Me.txtEndItemType.Text) & "' Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
        MsgBox("Record Has Been Saved.")

    End Sub

    Private Sub btnQCSignOff_Click(sender As Object, e As EventArgs) Handles btnQCSignOff.Click

        If Me.txtQCNotes.Text = "" Then
            MsgBox("You have to enter something in the QC Notes field.")
            Exit Sub

        End If

        If Me.txtQCName.Text = ds.Tables("GETEMAIL").Rows(0).Item("Email") Or Me.txtQCNameBackup.Text = ds.Tables("GETEMAIL").Rows(0).Item("Email") Then
            Me.txtQCName.Text = SignedName
            u.ExecuteSQL(SqlConnection1, "UPDATE tblEARR Set QCName = '" & Me.txtQCName.Text & "', QCSignOff = '" & Now & "', EARRStatus = 'Signed Off By QC', QCNotes = '" & u.FTM(Me.txtQCNotes.Text) & "' Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
            MsgBox("EARR has been signed off.  Screen will now be refreshed.")

            da = New SqlClient.SqlDataAdapter("Select email from tblusers where username = '" & System.Environment.UserName & "'", SqlConnection1)
            da.Fill(ds, "ORIGEMAIL")

            'Send to CM
            'u.SendEmail("system@fieldaero.com", Me.txtPlanner1.Text + "; " + Me.txtPlanner2.Text + "; " + "RDUWEL@fieldaero.com; dwelchel@fieldaero.com", ds.Tables("ORIGEMAIL").Rows(0).Item("email"), "CM, a EARR has been signed off by QC.  The program is:  " + Me.cboProgramName.Text + "And the EARR Number is: " + Me.txtEARRNumber.Text + "Please proceed with release and notify planning.")

            'Send to Planning
            u.SendEmail("system@fieldaero.com", Me.txtPlanner1.Text + "; " + Me.txtPlanner2.Text + "; " + ds.Tables("ORIGEMAIL").Rows(0).Item("email"), "EARR signed off by QC", "Planning, a EARR has been signed off by QC.  The program is:  " + Me.cboProgramName.Text + "And the EARR Number is: " + Me.txtEARRNumber.Text + "Please sign off.")
            EditEARR = Val(Me.txtRecordID.Text)
            Dim frmEARRApproval As New frmEARRApproval
            frmEARRApproval.Show()
            Me.Close()
        Else

            MsgBox("You are not allowed to sign off as QC.")

        End If
    End Sub

    Private Sub btnRescind_Click(sender As Object, e As EventArgs) Handles btnRescind.Click

        If Me.txtEARRStatus.Text = "Signed Off By QC" Or Me.txtEARRStatus.Text = "Complete" Then
            MsgBox("The EARR status is Signed Off by QC or Complete.  You cannot rescind this EARR.")
            Exit Sub
        End If
        If Me.txtEngineeringManagerName.Text = ds.Tables("GETEMAIL").Rows(0).Item("Email") Or Me.txtEngineeringManagerNameBackup.Text = ds.Tables("GETEMAIL").Rows(0).Item("Email") Then

            u.ExecuteSQL(SqlConnection1, "UPDATE tblEARR Set EARRStatus = 'Rescinded', EngineeringManagerSignOffDate = '" & Now & "', EngineeringManagerName = '' Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
            MsgBox("EARR has been rescinded.  Screen will now be refreshed.")
            u.SendEmail("system@fieldaero.com", Me.txtPlanner1.Text + "; " + Me.txtPlanner2.Text + "; " + Me.txtQCName.Text + "; " + Me.txtQCNameBackup.Text, "EARR has been rescinded.", "An EARR has been rescinded by the engineering manager.  The program is:  " + Me.cboProgramName.Text + " and the EARR Number is: " + Me.txtEARRNumber.Text + ".")
            EditEARR = Val(Me.txtRecordID.Text)
            Dim frmEARRApproval As New frmEARRApproval
            frmEARRApproval.Show()
            Me.Close()
        Else

            MsgBox("You are not allowed to rescind as Engineering Manager.")

        End If
    End Sub

    Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
        If Me.txtPlanner1.Text = ds.Tables("GETEMAIL").Rows(0).Item("Email") Or Me.txtPlanner2.Text = ds.Tables("GETEMAIL").Rows(0).Item("Email") Then

            u.ExecuteSQL(SqlConnection1, "UPDATE tblEARR Set EARRStatus = 'Aborted', PlannerSignOffDate = '" & Now & "' Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
            MsgBox("EARR has been Aborted.  Screen will now be refreshed.")
            EditEARR = Val(Me.txtRecordID.Text)
            Dim frmEARRApproval As New frmEARRApproval
            frmEARRApproval.Show()
            Me.Close()
        Else

            MsgBox("You are not allowed to Abort.")

        End If
    End Sub

    Private Sub btnPlanningSignOff_Click(sender As Object, e As EventArgs) Handles btnPlanningSignOff.Click
        If Me.txtPlanner1.Text = ds.Tables("GETEMAIL").Rows(0).Item("Email") Or Me.txtPlanner2.Text = ds.Tables("GETEMAIL").Rows(0).Item("Email") Then

            Me.txtPlanner1.Text = SignedName
            u.ExecuteSQL(SqlConnection1, "UPDATE tblEARR Set Planner1 = '" & Me.txtPlanner1.Text & "', PlannerSignOffDate = '" & Now & "', EARRStatus = 'Complete', PlannerNotes = '" & u.FTM(Me.txtPlanningNotes.Text) & "' Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
            MsgBox("EARR has been signed off.  Screen will now be refreshed.")
            Me.btnSaveSelectedEARR.PerformClick()

            If Me.cboProgramName.Text = "16082 - Jaguar" Then
                'u.sendEmail("system@fieldaero.com", "tsingh@fieldav.com", "EARR HAS BEEN SIGNED OFF BY ENG MANAGER", "A EARR has been signed off by the Engineering Manager.  The program is:  " + Me.cboProgramName.Text, "  The EARR number is " + Me.txtEARRNumber.Text + ".")
            Else
                u.SendEmail("system@fieldaero.com", "rduwel@fieldaero.com; dwelchel@fieldaero.com", "EARR SIGNED OFF BY PLANNING", "A EARR has been signed off by the Engineering Manager.  The program is:  " + Me.cboProgramName.Text + " The EARR Number is: " + Me.txtEARRNumber.Text + "Please respond to the EARR.")
            End If
            EditEARR = Val(Me.txtRecordID.Text)
            Dim frmEARRApproval As New frmEARRApproval
            frmEARRApproval.Show()
            Me.Close()
        Else

            MsgBox("You are not allowed to sign off as Engineering Manager.")

        End If
    End Sub

    Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles XtraTabControl1.Click

    End Sub

    Private Sub btnPrintEarr_Click(sender As Object, e As EventArgs) Handles btnPrintEarr.Click

        Dim crReport As New crEARR
        crReport.SetDatabaseLogon("sa1", "The water is wet!")

        Dim sqlstring As String

        sqlstring = "SELECT * from tblEARR where RecordID = '" & Val(Me.txtRecordID.Text) & "'"

        GlobalSqlString = sqlstring

        Dim frm As New frmViewReport
        frm.ReportType = "EARR"
        frm.Report1 = crReport
        frm.Show()
    End Sub






    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Me.OpenFileDialog1.InitialDirectory = "C:\"
        Me.OpenFileDialog1.Filter = "All files (*.*)|*.*"
        Me.OpenFileDialog1.FilterIndex = 1
        Me.OpenFileDialog1.RestoreDirectory = True

        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtFilePath.Text = Me.OpenFileDialog1.FileName.ToString
        End If
    End Sub
    Private Sub GetFileUploadRecords()
        Dim sqlString1 As String

        Me.DataSet71.tblEARRAttach.Clear()
        sqlString1 = " WHERE RecordID = RecordID"

        Me.txtAttachRecordID.DataBindings.Clear()
        Me.txtFileDescription.DataBindings.Clear()
        Me.txtFilePath.DataBindings.Clear()

        sqlString1 = sqlString1 + " AND EARRID = '" & Val(Me.txtRecordID.Text) & "'"

        Dim cmdSave As String

        cmdSave = Me.SqlDataAdapter4.SelectCommand.CommandText
        Me.SqlDataAdapter4.SelectCommand.CommandText += sqlString1
        Try
            Me.SqlDataAdapter4.Fill(Me.DataSet71.tblEARRAttach)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter4.SelectCommand.CommandText = cmdSave

        If Me.DataSet71.Tables("tblEARRAttach").Rows.Count > 0 Then
            Me.txtAttachRecordID.DataBindings.Add("Text",
            Me.BindingSource3, "RecordID")
            Me.txtFileDescription.DataBindings.Add("Text",
            Me.BindingSource3, "FileDescription")
            Me.txtFilePath.DataBindings.Add("Text",
            Me.BindingSource3, "FilePath")
        Else
            ' MsgBox("No Attachments Currently Exist For This Record.")
        End If

    End Sub
    Private Sub btnFileAttachSubmit_Click(sender As Object, e As EventArgs) Handles btnFileAttachSubmit.Click
        btnSaveNew.Visible = True
        Me.txtFileDescription.Text = ""
        Me.txtFilePath.Text = ""
        MsgBox("Fill in the description and browse for the file and click Save New")
    End Sub

    Private Sub btnDeleteAttachment_Click(sender As Object, e As EventArgs) Handles btnDeleteAttachment.Click
        If Me.txtAttachRecordID.Text = "" Then
            MsgBox("There are no files to delete.", MsgBoxStyle.Information, "EARR Application")
        Else
            Dim answer
            answer = MsgBox("Are you sure you want to delete this file?", MsgBoxStyle.YesNo, "EARR Application")

            If answer = 6 Then
                u.ExecuteSQL(SqlConnection1, "DELETE FROM tblEARRAttach WHERE RecordID = '" & Val(Me.txtAttachRecordID.Text) & "'")
                MsgBox("The file has been deleted.", MsgBoxStyle.Information, "EARR Application")
                GetFileUploadRecords()
                'GetElectronicStatus()
            Else
                MsgBox("Deletion of file was canceled.", MsgBoxStyle.Information, "EARR Application")
            End If
        End If
    End Sub

    Private Sub SqlDataAdapter4_RowUpdated(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs) Handles SqlDataAdapter4.RowUpdated

    End Sub

    Private Sub DeleteTempFilesFromViewing()
        Dim File As String

        For Each File In Directory.GetFiles("C:\Temp\")
            Dim File2 As New FileInfo(File)
            Try
                File2.Delete()
            Catch ex As Exception

            End Try
        Next
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If Me.txtAttachRecordID.Text = "" Then
            MsgBox("There are no files to view.", MsgBoxStyle.Information, "EARR APP")
        Else
            DeleteTempFilesFromViewing()

            da = New SqlClient.SqlDataAdapter("SELECT * FROM tblEARRAttach WHERE RecordID = '" & Me.txtAttachRecordID.Text & "'", SqlConnection1)
            Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)

            SqlConnection1.Open()

            da.Fill(ds, "MyImages")
            Dim myRow As DataRow
            myRow = ds.Tables("MyImages").Rows(0)

            Dim MyData() As Byte
            MyData = myRow("ImgField")
            Dim Extension As String
            Extension = myRow("FileExt")

            Dim K As Long
            K = UBound(MyData)

            Dim FileDest As String

            'FileDest = Environment.SpecialFolder.MyDocuments.ToString + Format(Now, "MMddyyyyhhmmss") + "." + Extension
            FileDest = "C:\Temp\" + Format(Now, "MMddyyyyhhmmss") + "." + Extension
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

    Private Sub btnSaveNew_Click(sender As Object, e As EventArgs) Handles btnSaveNew.Click
        Dim FileUploadSave As String = "AddNew"
        If FileUploadSave = "AddNew" Then
            Dim ToPath As String
            ToPath = Me.txtFilePath.Text
            ToPath = ToPath.Substring(ToPath.LastIndexOf("\") + 1)

            Dim FileName As String
            FileName = ToPath
            Dim FileExt As String
            FileExt = ToPath.Substring(ToPath.LastIndexOf(".") + 1)

            da = New SqlClient.SqlDataAdapter("SELECT * FROM tblEARRAttach where RecordID = '" & Val(Me.txtAttachRecordID.Text) & "'", SqlConnection1)
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

            myRow("EARRID") = Val(Me.txtRecordID.Text)
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

            GetFileUploadRecords()
            Me.btnSaveNew.Visible = False
            'GetElectronicStatus()
        End If
    End Sub

    Private Sub txtRecordID_TextChanged(sender As Object, e As EventArgs) Handles txtRecordID.TextChanged
        GetFileUploadRecords()
    End Sub

    Private Sub btnSaveEARR_Click(sender As Object, e As EventArgs) Handles btnSaveEARR.Click
        u.ExecuteSQL(SqlConnection1, "Update tblEARR Set EARRNumber = '" & Me.txtEARRNumber.Text & "', EARRType = '" & u.FTM(Me.cboEARRType.Text) & "', SerialNumber = '" & u.FTM(Me.txtSerialNumber.Text) & "', WorkOrder = '" & Me.txtWorkOrder.Text & "', ProgramName = '" & u.FTM(Me.cboProgramName.Text) & "', DrawingNumber = '" & Me.txtDrawingNumber.Text & "', DrawingRevision = '" & Me.txtDrawingRevision.Text & "', Request = '" & u.FTM(Me.txtRequest.Text) & "', IncorpRedLineYes = '" & Me.chkIncorpRedLineYes.CheckState & "', IncorpRedLineNo = '" & Me.chkIncorpRedLineNo.CheckState & "', DrawingReqForConformityYes = '" & Me.chkDrawingRequestForConformityYes.CheckState & "', DrawingReqForConformityNo = '" & Me.chkDrawingRequestForConformityNo.CheckState & "', EARRResponseDate = '" & dtEARRResponseDate.Value & "', OriginatorName = '" & u.FTM(Me.txtOriginatorName.Text) & "', OriginatorDate = '" & Me.dtOriginatorDate.Value & "', ReplyInstructions = '" & u.FTM(Me.txtReplyInstructions.Text) & "', EffectivityAll = '" & Me.chkEffectivityAll.CheckState & "', EffectivityOther = '" & Me.chkEffectivityOther.CheckState & "', EffectivityOtherText = '" & u.FTM(Me.txtEffectivityOtherText.Text) & "', DeviationMinor = '" & Me.chkDeviationMinor.CheckState & "', DeviationMajor = '" & Me.chkDeviationMajor.CheckState & "', DeviationNA = '" & Me.chkDeviationNA.CheckState & "', AdditionalEngReqNoAction = '" & Me.chkAdditionalEngReqNoAction.CheckState & "', AdditionalEngReqUpdate = '" & Me.chkAdditionalEngReqUpdate.CheckState & "', ACFTInterface = '" & Me.chkACFTInterface.CheckState & "', Manufacturability = '" & Me.chkManufacturability.CheckState & "', ProductImprovement = '" & Me.chkProductImprovement.CheckState & "', DWGError = '" & Me.chkDWGError.CheckState & "', DesignError = '" & Me.chkDesignError.CheckState & "', ProductionError = '" & Me.chkProductionError.CheckState & "', EndItemType = '" & u.FTM(Me.txtEndItemType.Text) & "' Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
        MsgBox("Record Has Been Saved.")
    End Sub

    ''Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ''    u.SendEmail("system@fieldaero.com", "jspillane@fieldaero.com; jwebster@fieldaero.com", "TEST EMAIL FROM SYS TO JOHN SPILLANE", "THIS IS A TEST EMAIL...")
    ''End Sub

    'Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
    '    Me.OpenFileDialog1.InitialDirectory = "C:\"
    '    Me.OpenFileDialog1.Filter = "All files (*.*)|*.*"
    '    Me.OpenFileDialog1.FilterIndex = 1
    '    Me.OpenFileDialog1.RestoreDirectory = True

    '    If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Me.txtAttachPath.Text = Me.OpenFileDialog1.FileName.ToString
    '    End If
    'End Sub

    'Public Function GetAttach()

    '    Dim sqlString1 As String

    '    Me.DataSet61.tblAttachments.Clear()
    '    sqlString1 = " WHERE RecordID = RecordID"

    '    Me.txtAttachRecordID.DataBindings.Clear()
    '    Me.txtAttachDesc.DataBindings.Clear()
    '    Me.txtAttachPath.DataBindings.Clear()

    '    sqlString1 = sqlString1 + " AND EARRID = '" & Val(Me.txtRecordID.Text) & "'"

    '    Dim cmdSave As String

    '    cmdSave = Me.SqlDataAdapter2.SelectCommand.CommandText
    '    Me.SqlDataAdapter2.SelectCommand.CommandText += sqlString1
    '    Try
    '        Me.SqlDataAdapter2.Fill(Me.DataSet61.tblAttachments)
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    '    Me.SqlDataAdapter2.SelectCommand.CommandText = cmdSave

    '    If Me.DataSet61.Tables("tblattachments").Rows.Count > 0 Then
    '        Me.txtAttachRecordID.DataBindings.Add("Text",
    'Me.BindingSource2, "RecordID")
    '        Me.txtAttachDesc.DataBindings.Add("Text",
    'Me.BindingSource2, "Description")
    '        Me.txtAttachPath.DataBindings.Add("Text",
    'Me.BindingSource2, "Path")
    '    Else
    '        ' MsgBox("No Attachments Currently Exist For This Record.")
    '    End If

    'End Function

    'Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
    '    If Me.txtAttachRecordID.Text = "" Then
    '        MsgBox("There are no files to view.", MsgBoxStyle.Information, "EARR")
    '    Else
    '        DeleteTempFilesFromViewing()

    '        da = New SqlClient.SqlDataAdapter("SELECT * FROM tblAttachments WHERE RecordID = '" & Me.txtAttachRecordID.Text & "'", SqlConnection1)
    '        Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)

    '        SqlConnection1.Open()

    '        da.Fill(ds, "MyImages")
    '        Dim myRow As DataRow
    '        myRow = ds.Tables("MyImages").Rows(0)

    '        Dim MyData() As Byte
    '        MyData = myRow("ImgField")
    '        Dim Extension As String
    '        Extension = myRow("FileExt")

    '        Dim K As Long
    '        K = UBound(MyData)

    '        Dim FileDest As String

    '        FileDest = Environment.SpecialFolder.MyDocuments.ToString + Format(Now, "MMddyyyyhhmmss") + "." + Extension

    '        Dim fs As New FileStream(FileDest, FileMode.OpenOrCreate, FileAccess.Write)
    '        fs.Write(MyData, 0, K)
    '        fs.Close()

    '        fs = Nothing
    '        MyCB = Nothing
    '        ds.Tables("MyImages").Clear()

    '        Process.Start(FileDest)

    '        SqlConnection1.Close()
    '    End If
    'End Sub
End Class