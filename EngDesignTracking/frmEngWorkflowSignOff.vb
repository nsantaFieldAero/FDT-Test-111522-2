Imports System.Net.Mail

Public Class frmEngWorkflowSignOff
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim da2 As SqlClient.SqlDataAdapter
    Dim ds2 As New DataSet
    Public CanSignOff As String = ""

    Dim ReleaserBtnClicked As String

    Private Sub frmEngWorkflowSignOff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString
        SqlConnection2.ConnectionString = sqlString
        SignedOffAdcnDrnGateSix = ""

        'Users cannot move to Gate 2 or Gate 6 unless all Redlines for the current drawing number are set to Incorporated
        da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & DrawNumForSignOff & "' And Status != 'Incorporated' And Status != 'No Action Required' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)   'And Rev = '" & RedlineRev & "' 
        da.Fill(ds, "CheckAllPreviousRevsAreIncorporated")

        If ds.Tables("CheckAllPreviousRevsAreIncorporated").Rows.Count > 0 Then
            CanSignOff = "No"
            ds.Tables("CheckAllPreviousRevsAreIncorporated").Clear()
            ds.Tables("CheckAllPreviousRevsAreIncorporated").Dispose()
        End If


        If CM = True Then
            Me.btnCMSignOff.Enabled = True
        Else
            Me.btnCMSignOff.Enabled = False
        End If


        Search()
        CheckReviewStatus()


        If Me.txtDrafterAssigned.Text = username Or CM = True Then
            Me.btnDrafterSignoff.Enabled = True
        Else
            Me.btnDrafterSignoff.Enabled = False
        End If

        If Me.txtSrEngineerAssigned.Text = username Or CM = True Then
            Me.btnSrEngineerSignoff.Enabled = True
        Else
            Me.btnSrEngineerSignoff.Enabled = False
        End If

        If Me.txtStressAssigned.Text = username Or CM = True Then
            Me.btnStressSignoff.Enabled = True
        Else
            Me.btnStressSignoff.Enabled = False
        End If

        If Me.txtOperationsAssigned.Text = username Or CM = True Then
            Me.btnOperationsSignoff.Enabled = True
        Else
            Me.btnOperationsSignoff.Enabled = False
        End If

        If Me.txtReleaserAssigned.Text = username Or CM = True Then
            Me.btnReleaserSignoff.Enabled = True
        Else
            Me.btnReleaserSignoff.Enabled = False
        End If
        If CM = True Then
            Me.btnCMSignOff.Enabled = True
        Else
            Me.btnCMSignOff.Enabled = False
        End If


        'Disable dates fields if not a CM. The dates are set to today's date anyway after each signoff button is clicked
        If CM <> True Then
            dtDrafterSignOff.Enabled = False
            dtSrEngineerSignOff.Enabled = False
            dtStressSignOff.Enabled = False
            dtOperationsSignOff.Enabled = False
            dtReleaserSignOff.Enabled = False
            dtCMSignOff.Enabled = False
        End If


        'Disable Releaser signoff button if the other roles have not signed off
        If btnDrafterSignoff.Text = "Rescind" And btnSrEngineerSignoff.Text = "Rescind" And btnStressSignoff.Text = "Rescind" And btnOperationsSignoff.Text = "Rescind" Then
            If CM = True Then
                btnReleaserSignoff.Enabled = True
            End If
        Else
            btnReleaserSignoff.Enabled = False

            'Enable Releaser button if one of the below roles have to be signed off and Releaser button is equal to Rescind
            If btnDrafterSignoff.Text = "Sign Off" Or btnSrEngineerSignoff.Text = "Sign Off" Or btnStressSignoff.Text = "Sign Off" Or btnOperationsSignoff.Text = "Sign Off" Then
                If CM = True And btnReleaserSignoff.Text = "Rescind" Then
                    btnReleaserSignoff.Enabled = True
                End If
            Else
                btnReleaserSignoff.Enabled = False
            End If
        End If

        'Disable CM signoff button if the other roles have not signed off
        If btnDrafterSignoff.Text = "Rescind" And btnSrEngineerSignoff.Text = "Rescind" And btnStressSignoff.Text = "Rescind" And btnOperationsSignoff.Text = "Rescind" And btnReleaserSignoff.Text = "Rescind" Then
            If CM = True Then
                btnCMSignOff.Enabled = True
            End If
        Else
            btnCMSignOff.Enabled = False
        End If
        'End If


        'Disable All SignOff Buttons If Every Role Has Been Signed Off
        If btnDrafterSignoff.Text = "Rescind" And btnSrEngineerSignoff.Text = "Rescind" And btnStressSignoff.Text = "Rescind" And btnOperationsSignoff.Text = "Rescind" And btnReleaserSignoff.Text = "Rescind" And btnCMSignOff.Text = "Rescind" Then
            If isAdmin = "T" Then
                btnDrafterSignoff.Enabled = True
                btnSrEngineerSignoff.Enabled = True
                btnStressSignoff.Enabled = True
                btnOperationsSignoff.Enabled = True
                btnReleaserSignoff.Enabled = True
                btnCMSignOff.Enabled = True
            Else
                btnDrafterSignoff.Enabled = False
                btnSrEngineerSignoff.Enabled = False
                btnStressSignoff.Enabled = False
                btnOperationsSignoff.Enabled = False
                btnReleaserSignoff.Enabled = False
                btnCMSignOff.Enabled = False
            End If
        End If


        'If the record has been cancelled disable all buttons, else run the code as normal(as it was running before, no changes)
        If GateStatus = "Cancelled" Or GateStatus = "Canceled" Or GateStatus = "Obsolete" Or GateStatus = "Deleted" Then

            btnDrafterSignoff.Enabled = False
            btnSrEngineerSignoff.Enabled = False
            btnStressSignoff.Enabled = False
            btnOperationsSignoff.Enabled = False
            btnReleaserSignoff.Enabled = False
            btnCMSignOff.Enabled = False
            dtDrafterSignOff.Enabled = False
            dtSrEngineerSignOff.Enabled = False
            dtStressSignOff.Enabled = False
            dtOperationsSignOff.Enabled = False
            dtReleaserSignOff.Enabled = False
            dtCMSignOff.Enabled = False
        End If

    End Sub

    Public Function CheckReviewStatus()

        If Me.dtDrafterSignOff.Value <> "01/01/1900" And dtDrafterSignOff.Value <> "01/01/2000" Or txtDrafterAssigned.Text = "N/A" Then
            Me.lblDrafterStatus.Text = "Signed Off"
            'Button Code
            Me.btnDrafterSignoff.Text = "Rescind"
        Else
            Me.lblDrafterStatus.Text = "Pending"
            Me.btnDrafterSignoff.Text = "Sign Off"
        End If

        If Me.dtSrEngineerSignOff.Value <> "01/01/1900" And dtSrEngineerSignOff.Value <> "01/01/2000" Or txtSrEngineerAssigned.Text = "N/A" Then
            Me.lblSrEngineerStatus.Text = "Signed Off"
            Me.btnSrEngineerSignoff.Text = "Rescind"
            'Button Code
        Else
            Me.lblSrEngineerStatus.Text = "Pending"
            Me.btnSrEngineerSignoff.Text = "Sign Off"
        End If

        'ADD (DONE) TO PROD: change 1 line; change it to the line below
        If txtStressAssigned.Text = "N/A" Then      'Me.dtStressSignOff.Value <> "01/01/1900" And dtStressSignOff.Value <> "01/01/2000" Or 
            Me.lblStressStatus.Text = "Signed Off"
            Me.btnStressSignoff.Text = "Rescind"
            'ADD (DONE) TO PROD: next 6 lines
        ElseIf txtStressAssigned.Text = "" Then
            Me.lblStressStatus.Text = "Pending"
            Me.btnStressSignoff.Text = "Sign Off"
        ElseIf txtStressAssigned.Text <> "N/A" And txtStressAssigned.Text <> "" And dtStressSignOff.Value <> "01/01/1900" Then   'And txtStressSignedOffBy.Text = ""
            Me.lblStressStatus.Text = "Signed Off"
            Me.btnStressSignoff.Text = "Rescind"
        Else
            Me.lblStressStatus.Text = "Pending"
            Me.btnStressSignoff.Text = "Sign Off"
        End If

        'ADD (DONE) TO PROD: next block of code and comment the block following(which was the pre-existing one)
        If txtOperationsAssigned.Text = "N/A" Then      'Me.dtStressSignOff.Value <> "01/01/1900" And dtStressSignOff.Value <> "01/01/2000" Or 
            Me.lblOperationsStatus.Text = "Signed Off"
            Me.btnOperationsSignoff.Text = "Rescind"
            'ADD (DONE) TO PROD: next 6 lines
        ElseIf txtOperationsAssigned.Text = "" Then
            Me.lblOperationsStatus.Text = "Pending"
            Me.btnOperationsSignoff.Text = "Sign Off"
        ElseIf txtOperationsAssigned.Text <> "N/A" And txtOperationsAssigned.Text <> "" And dtOperationsSignOff.Value <> "01/01/1900" Then   'And txtStressSignedOffBy.Text = ""
            Me.lblOperationsStatus.Text = "Signed Off"
            Me.btnOperationsSignoff.Text = "Rescind"
        Else
            Me.lblOperationsStatus.Text = "Pending"
            Me.btnOperationsSignoff.Text = "Sign Off"
        End If

        'If Me.dtOperationsSignOff.Value <> "01/01/1900" And dtOperationsSignOff.Value <> "01/01/2000" Or txtOperationsAssigned.Text = "N/A" Then
        '    Me.lblOperationsStatus.Text = "Signed Off"
        '    Me.btnOperationsSignoff.Text = "Rescind"
        'Else
        '    Me.lblOperationsStatus.Text = "Pending"
        '    Me.btnOperationsSignoff.Text = "Sign Off"
        'End If

        If Me.dtReleaserSignOff.Value <> "01/01/1900" And dtReleaserSignOff.Value <> "01/01/2000" Or txtReleaserAssigned.Text = "N/A" Then
            Me.lblReleaserStatus.Text = "Signed Off"
            Me.btnReleaserSignoff.Text = "Rescind"
        Else
            Me.lblReleaserStatus.Text = "Pending"
            Me.btnReleaserSignoff.Text = "Sign Off"
        End If

        If Me.dtCMSignOff.Value <> "01/01/1900" And dtDrafterSignOff.Value <> "01/01/2000" Then
            Me.lblCMStatus.Text = "Signed Off"
            Me.btnCMSignOff.Text = "Rescind"
        Else
            Me.lblCMStatus.Text = "Pending"
            Me.btnCMSignOff.Text = "Sign Off"
        End If

        'ADD (DONE) TO PROD: next 6 lines
        'Disable Releaser signoff button if the other roles have not signed off
        If btnDrafterSignoff.Text = "Rescind" And btnSrEngineerSignoff.Text = "Rescind" And btnStressSignoff.Text = "Rescind" And btnOperationsSignoff.Text = "Rescind" Then
            btnReleaserSignoff.Enabled = True
        Else
            btnReleaserSignoff.Enabled = False
        End If

        'ADD (DONE) TO PROD: next 6 lines
        'Disable CM signoff button if the other roles have not signed off
        If btnDrafterSignoff.Text = "Rescind" And btnSrEngineerSignoff.Text = "Rescind" And btnStressSignoff.Text = "Rescind" And btnOperationsSignoff.Text = "Rescind" And btnReleaserSignoff.Text = "Rescind" Then
            btnCMSignOff.Enabled = True
        Else
            btnCMSignOff.Enabled = False
        End If


        'Update notifications label on main screen. Adding this line of code here because this is a function that always gets called when clicking on any signoff button
        'frmEngWorkflow.GetNumberTasksPending()

    End Function

    Public Function Search()

        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet401.tblDrawings.Clear()

        Me.txtDrafterAssigned.DataBindings.Clear()
        Me.txtSrEngineerAssigned.DataBindings.Clear()
        Me.txtStressAssigned.DataBindings.Clear()
        Me.txtOperationsAssigned.DataBindings.Clear()
        Me.txtReleaserAssigned.DataBindings.Clear()
        Me.txtCMAssigned.DataBindings.Clear()
        Me.txtDrafterSignedOffBy.DataBindings.Clear()
        Me.txtSrEngineerSignedOffBy.DataBindings.Clear()
        Me.txtStressSignedOffBy.DataBindings.Clear()
        Me.txtOperationsSignedOffBy.DataBindings.Clear()
        Me.txtReleaserSignedOffBy.DataBindings.Clear()
        Me.txtCMSignedOffBy.DataBindings.Clear()
        Me.dtDrafterSignOff.DataBindings.Clear()
        Me.dtSrEngineerSignOff.DataBindings.Clear()
        Me.dtStressSignOff.DataBindings.Clear()
        Me.dtOperationsSignOff.DataBindings.Clear()
        Me.dtReleaserSignOff.DataBindings.Clear()
        Me.dtCMSignOff.DataBindings.Clear()

        Dim cmdSave As String

        SqlString = " Where RecordID = '" & Val(Document) & "'"

        Me.SqlDataAdapter1.SelectCommand.CommandText() = "SELECT RecordID, ActualFinishDate, Drafter, DrafterComplete, DrafterSignedOffBy, Engineer, EngineerSignedOffBy, EngineerComplete, SrEngineer, SrEngineerSignedOffBy, SrEngineerComplete, ReleaserSignedOffBy, Releaser, ReleaserCompelte, CMSignedOffBy, Stress, StressComplete, StressSignedOffBy FROM tblDrawings"
        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter1.Fill(DataSet401.tblDrawings)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText() = cmdSave

        If Me.DataSet401.Tables("tblDrawings").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            Search = True

            'Create DataBindings

            Me.txtDrafterAssigned.DataBindings.Add("Text",
Me.BindingSource1, "Drafter")

            Me.txtSrEngineerAssigned.DataBindings.Add("Text",
Me.BindingSource1, "SrEngineer")

            Me.txtStressAssigned.DataBindings.Add("Text",
Me.BindingSource1, "Stress")

            Me.txtOperationsAssigned.DataBindings.Add("Text",
Me.BindingSource1, "Engineer")

            Me.txtReleaserAssigned.DataBindings.Add("Text",
Me.BindingSource1, "Releaser")

            Me.txtDrafterSignedOffBy.DataBindings.Add("Text",
Me.BindingSource1, "DrafterSignedOffBy")

            Me.txtSrEngineerSignedOffBy.DataBindings.Add("Text",
Me.BindingSource1, "SrEngineerSignedOffBy")

            Me.txtStressSignedOffBy.DataBindings.Add("Text",
Me.BindingSource1, "StressSignedOffBy")

            Me.txtOperationsSignedOffBy.DataBindings.Add("Text",
Me.BindingSource1, "EngineerSignedOffBy")

            Me.txtReleaserSignedOffBy.DataBindings.Add("Text",
Me.BindingSource1, "ReleaserSignedOffBy")

            Me.txtCMSignedOffBy.DataBindings.Add("Text",
Me.BindingSource1, "CMSignedOffBy")

            Me.dtDrafterSignOff.DataBindings.Add("Value",
Me.BindingSource1, "DrafterComplete")

            Me.dtSrEngineerSignOff.DataBindings.Add("Value",
Me.BindingSource1, "SrEngineerComplete")

            Me.dtStressSignOff.DataBindings.Add("Value",
Me.BindingSource1, "StressComplete")

            Me.dtOperationsSignOff.DataBindings.Add("Value",
Me.BindingSource1, "EngineerComplete")

            Me.dtReleaserSignOff.DataBindings.Add("Value",
Me.BindingSource1, "ReleaserCompelte")


            Me.dtCMSignOff.DataBindings.Add("Value",
Me.BindingSource1, "ActualFinishDate")



        Else
            MsgBox("")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If

    End Function

    Private Sub btnDrafterSignoff_Click(sender As Object, e As EventArgs) Handles btnDrafterSignoff.Click
        SqlConnection1.ConnectionString = sqlString

        SrEngineerSignOff = txtSrEngineerAssigned.Text
        StressSignOff = txtStressAssigned.Text


        '--------------------------------------------------------------------
        If btnDrafterSignoff.Text = "Sign Off" Then

            If txtDrafterAssigned.Text = "" Then
                MsgBox("You need a value for Drafter")
                Me.Close()
                Exit Sub
            End If

            'Check Sr Engineer and Stress persons have been chosen in the Main grid
            If txtSrEngineerAssigned.Text = "" Or txtStressAssigned.Text = "" Then
                MsgBox("You need a value for Sr Engineer and Stress")
                Me.Close()
                Exit Sub
            End If

            'If the roles above(Sr Engineer, Stress, Operations, Releaser and CM) have been signed off then set Status to Gate 6(the gate of the CM)
            If (btnStressSignoff.Text <> "Sign Off") And (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") And (dtOperationsSignOff.Value <> "01/01/1900" Or btnOperationsSignoff.Text <> "Sign Off") And (dtReleaserSignOff.Value <> "01/01/1900" Or btnReleaserSignoff.Text <> "Sign Off") And (dtCMSignOff.Value <> "01/01/1900" Or btnCMSignOff.Text <> "Sign Off") Then

                'Users cannot move to Gate 2 unless all Redlines are set to Incorporated
                If CanSignOff = "No" Then
                    MsgBox("You cannot sign off and move to Gate 6 before all redlines are set to Incorporated")
                    Me.Close()
                    Exit Sub
                End If

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DrafterSignedOffBy = '" & System.Environment.UserName & "', DrafterComplete = '" & Now & "', Status = 'GATE 6: Complete', PercentComplete = '100' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(2)

                SetIncorporatedRevForRedlines()

                'After a Drn or Adcn is moved to gate 6 then the btnAddRedline can be enabled, even if it was disabled once the redlines were set to incorporated
                If isADCN <> "" Or isDRN <> "" Then
                    SignedOffAdcnDrnGateSix = "Yes"
                End If

                Me.dtDrafterSignOff.Value = Now
                Me.txtDrafterSignedOffBy.Text = System.Environment.UserName

                'If the roles above(Sr Engineer, Stress, Operations and Releaser) have been signed off, then set Status to Gate 5
            ElseIf (btnStressSignoff.Text <> "Sign Off") And (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") And (dtOperationsSignOff.Value <> "01/01/1900" Or btnOperationsSignoff.Text <> "Sign Off") And (dtReleaserSignOff.Value <> "01/01/1900" Or btnReleaserSignoff.Text <> "Sign Off") Then

                'Users cannot move to Gate 2 unless all Redlines are set to Incorporated
                If CanSignOff = "No" Then
                    MsgBox("You cannot sign off Gate 2 or passing Gate 2 before all redlines are set to Incorporated")
                    Me.Close()
                    Exit Sub
                End If

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DrafterSignedOffBy = '" & System.Environment.UserName & "', DrafterComplete = '" & Now & "', Status = 'GATE 5: DWG Released', PercentComplete = '95' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(2)
                Me.dtDrafterSignOff.Value = Now
                Me.txtDrafterSignedOffBy.Text = System.Environment.UserName

                'If the role above(Sr Engineer, Stress and Operations) have been signed off then set Status to Gate 4
            ElseIf (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") And (btnStressSignoff.Text <> "Sign Off") And (dtOperationsSignOff.Value <> "01/01/1900" Or btnOperationsSignoff.Text <> "Sign Off") Then

                'Users cannot move to Gate 2 unless all Redlines are set to Incorporated
                If CanSignOff = "No" Then
                    MsgBox("You cannot sign off Gate 2 or passing Gate 2 before all redlines are set to Incorporated")
                    Me.Close()
                    Exit Sub
                End If

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DrafterSignedOffBy = '" & System.Environment.UserName & "', DrafterComplete = '" & Now & "', Status = 'GATE 4: DWG Ready For Release', PercentComplete = '90' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(2)
                Me.dtDrafterSignOff.Value = Now
                Me.txtDrafterSignedOffBy.Text = System.Environment.UserName

                'If Sr Engineer and Stress roles have been signed off then set the Gate to 3
            ElseIf (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") And txtStressAssigned.Text <> "" Then

                'Users cannot move to Gate 2 unless all Redlines are set to Incorporated
                If CanSignOff = "No" Then
                    MsgBox("You cannot sign off Gate 2 or passing Gate 2 before all redlines are set to Incorporated")
                    Me.Close()
                    Exit Sub
                End If

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DrafterSignedOffBy = '" & System.Environment.UserName & "', DrafterComplete = '" & Now & "', Status = 'GATE 3: DWG Ready For Operations', PercentComplete = '80' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(2)
                Me.dtDrafterSignOff.Value = Now
                Me.txtDrafterSignedOffBy.Text = System.Environment.UserName

                'Only Sign Off Drafter
            Else

                'Users cannot move to Gate 2 unless all Redlines are set to Incorporated
                If CanSignOff = "No" Then
                    MsgBox("You cannot sign off and move to Gate 2 before all redlines are set to Incorporated")
                    Me.Close()
                    Exit Sub
                End If

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DrafterSignedOffBy = '" & System.Environment.UserName & "', DrafterComplete = '" & Now & "', Status = 'GATE 2: DWG Ready For Sr Engineer', PercentComplete = '70' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(2)
                Me.dtDrafterSignOff.Value = Now
                Me.txtDrafterSignedOffBy.Text = System.Environment.UserName
            End If

            'RESCIND
        Else
            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DrafterSignedOffBy = '', DrafterComplete = '01/01/1900', Status = 'GATE 1: DWG Ready For Drafter', PercentComplete = '65' Where RecordID = '" & Val(Document) & "'")
            Me.dtDrafterSignOff.Value = "01/01/1900"
            Me.txtDrafterSignedOffBy.Text = ""
        End If
        '-----------------------------------------------------------------------------------------


        ''Make sure there is a value for assigned Drafter, Sr Engineer and Stress. Senior Engineer and Stress are needed because they will be used to search their email
        'If txtDrafterAssigned.Text = "" Or txtSrEngineerAssigned.Text = "" Or txtStressAssigned.Text = "" Then          'Or dtDrafterSignOff.Value = "01/01/1900"
        '    MsgBox("You need a value for assigned Sr Engineer and Stress.")
        '    Exit Sub
        'End If

        ''Not signed, off, sign off.
        '' TODO : Need to roll status too.
        'u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DrafterSignedOffBy = '" & System.Environment.UserName & "', DrafterComplete = '" & Now & "', Status = 'GATE 2: DWG Ready For Sr Engineer', PercentComplete = '70' Where RecordID = '" & Val(Document) & "'")
        'SendNotifications(2)
        'Me.dtDrafterSignOff.Value = Now
        'Me.txtDrafterSignedOffBy.Text = System.Environment.UserName



        CheckReviewStatus()
        'EvaluateStatus()


        CloseSignedOffForm = "No"
        NotificationAlreadySentForGateOne = "No"   'Clearing variable(to say that a notification at gate 1 can be sent, since a new doc is being created). Need this because it was sending a notification to Gate 1 people twice, when saving with save btn and when saving with the signoff btn

        Me.Close()
    End Sub

    Private Sub btnSrEngineerSignoff_Click(sender As Object, e As EventArgs) Handles btnSrEngineerSignoff.Click
        SqlConnection1.ConnectionString = sqlString

        OperationsSignOff = txtOperationsAssigned.Text


        '--------------------------------------------------------------------
        If btnSrEngineerSignoff.Text = "Sign Off" Then

            'Check Sr Engineer and Stress, and Operations person has been chosen in the Main grid
            If txtSrEngineerAssigned.Text = "" And txtStressAssigned.Text = "" Then
                MsgBox("You need a value for Sr Engineer and Stress")
                Me.Close()
                Exit Sub
            End If

            If txtOperationsAssigned.Text = "" Then
                MsgBox("You need a value for Operations")
                Me.Close()
                Exit Sub
            End If

            'If the roles above(Stress, Operations, Releaser and CM)  and everything below have been signed off then set Status to Gate 6(the gate of the CM)
            If (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") And (btnStressSignoff.Text <> "Sign Off") And (dtOperationsSignOff.Value <> "01/01/1900" Or btnOperationsSignoff.Text <> "Sign Off") And (dtReleaserSignOff.Value <> "01/01/1900" Or btnReleaserSignoff.Text <> "Sign Off") And (dtCMSignOff.Value <> "01/01/1900" Or btnCMSignOff.Text <> "Sign Off") Then

                'Users cannot move to Gate 2 unless all Redlines are set to Incorporated
                If CanSignOff = "No" Then
                    MsgBox("You cannot sign off and move to Gate 2 before all redlines are set to Incorporated")
                    Me.Close()
                    Exit Sub
                End If

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set SrEngineerSignedOffBy = '" & System.Environment.UserName & "', SrEngineerComplete = '" & Now & "', Status = 'GATE 6: Complete', PercentComplete = '100' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(3)

                SetIncorporatedRevForRedlines()

                'After a Drn or Adcn is moved to gate 6 then the btnAddRedline can be enabled, even if it was disabled once the redlines were set to incorporated
                If isADCN <> "" Or isDRN <> "" Then
                    SignedOffAdcnDrnGateSix = "Yes"
                End If

                Me.dtSrEngineerSignOff.Value = Now
                Me.txtSrEngineerSignedOffBy.Text = System.Environment.UserName

                'If the roles above(Operations and Releaser) and everything with and below has been signed off, then set Status to Gate 5(the gate of the releaser)
            ElseIf (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") And (btnStressSignoff.Text <> "Sign Off") And (dtOperationsSignOff.Value <> "01/01/1900" Or btnOperationsSignoff.Text <> "Sign Off") And (dtReleaserSignOff.Value <> "01/01/1900" Or btnReleaserSignoff.Text <> "Sign Off") Then

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set SrEngineerSignedOffBy = '" & System.Environment.UserName & "', SrEngineerComplete = '" & Now & "', Status = 'GATE 5: DWG Released', PercentComplete = '95' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(3)
                Me.dtSrEngineerSignOff.Value = Now
                Me.txtSrEngineerSignedOffBy.Text = System.Environment.UserName

                'If the role above(Operations) and Stress, and Drafter has been signed off then set Status to Gate 4
            ElseIf (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") And (btnStressSignoff.Text <> "Sign Off") And (dtOperationsSignOff.Value <> "01/01/1900" Or btnOperationsSignoff.Text <> "Sign Off") Then

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set SrEngineerSignedOffBy = '" & System.Environment.UserName & "', SrEngineerComplete = '" & Now & "', Status = 'GATE 4: DWG Ready For Release', PercentComplete = '90' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(3)
                Me.dtSrEngineerSignOff.Value = Now
                Me.txtSrEngineerSignedOffBy.Text = System.Environment.UserName

                'If only everything below the Sr Engineer role has been signed off then set the Gate to 3
            ElseIf (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") Then
                If txtStressAssigned.Text = "N/A" Or (txtStressAssigned.Text <> "" And dtStressSignOff.Value <> "01/01/1900") Then
                    u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set SrEngineerSignedOffBy = '" & System.Environment.UserName & "', SrEngineerComplete = '" & Now & "', Status = 'GATE 3: DWG Ready For Operations', PercentComplete = '80' Where RecordID = '" & Val(Document) & "'")
                    SendNotifications(3)
                    Me.dtSrEngineerSignOff.Value = Now
                    Me.txtSrEngineerSignedOffBy.Text = System.Environment.UserName
                Else
                    u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set SrEngineerSignedOffBy = '" & System.Environment.UserName & "', SrEngineerComplete = '" & Now & "' Where RecordID = '" & Val(Document) & "'")
                    Me.dtSrEngineerSignOff.Value = Now
                    Me.txtSrEngineerSignedOffBy.Text = System.Environment.UserName
                End If

                'If there are roles below still to be signed off then just sign off Sr Engineer but do not touch the Gate
            Else
                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set SrEngineerSignedOffBy = '" & System.Environment.UserName & "', SrEngineerComplete = '" & Now & "' Where RecordID = '" & Val(Document) & "'")   ', PercentComplete = '80'
                SendNotifications(3)
                Me.dtSrEngineerSignOff.Value = Now
                Me.txtSrEngineerSignedOffBy.Text = System.Environment.UserName
            End If

            'RESCIND
        Else
            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set SrEngineerSignedOffBy = '', SrEngineerComplete = '01/01/1900', Status = 'GATE 1: DWG Ready For Drafter', PercentComplete = '65' Where RecordID = '" & Val(Document) & "'")
            Me.dtSrEngineerSignOff.Value = "01/01/1900"
            Me.txtSrEngineerSignedOffBy.Text = ""
        End If
        '---------------------------------------------------------------------------


        'PREVIOUS BLOCK OF CODE
        ''Make sure there is a value for assigned Senior Engineer
        'If txtSrEngineerAssigned.Text = "" Then     'Or dtSrEngineerSignOff.Value = "01/01/1900" 
        '    MsgBox("You need a value for assigned Senior Engineer")
        '    Exit Sub
        'End If

        ''If both Sr Engineer and Stress have a value make sure Operations has one as well. Operations is needed because they will be used to search their email
        'If txtSrEngineerAssigned.Text <> "" And txtStressAssigned.Text <> "" Then       'And dtSrEngineerSignOff.Value <> "01/01/1900" And dtStressSignOff.Value <> "01/01/1900" 
        '    If txtOperationsAssigned.Text = "" Then
        '        MsgBox("You need a value for Operations")
        '        Exit Sub
        '    End If
        'End If

        ''Not signed, off, sign off.
        '' TODO : Need to roll status too.
        'If txtStressAssigned.Text <> "" And (btnStressSignoff.Text = "Sign Off" Or btnStressSignoff.Text = "Rescind") Then
        '    u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set SrEngineerSignedOffBy = '" & System.Environment.UserName & "', SrEngineerComplete = '" & Now & "', Status = 'GATE 3: DWG Ready For Operations', PercentComplete = '80' Where RecordID = '" & Val(Document) & "'")
        '    SendNotifications(3)
        'Else
        '    u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set SrEngineerSignedOffBy = '" & System.Environment.UserName & "', SrEngineerComplete = '" & Now & "', PercentComplete = '80' Where RecordID = '" & Val(Document) & "'")
        'End If

        'Me.dtSrEngineerSignOff.Value = Now
        'Me.txtSrEngineerSignedOffBy.Text = System.Environment.UserName



        CheckReviewStatus()
        'EvaluateStatus()


        Dim CloseSignedOffForm As String = "No"
        NotificationAlreadySentForGateOne = "No"   'Clearing variable(to say that a notification at gate 1 can be sent, since a new doc is being created). Need this because it was sending a notification to Gate 1 people twice, when saving with save btn and when saving with the signoff btn

        Me.Close()
    End Sub

    Private Sub btnStressSignoff_Click(sender As Object, e As EventArgs) Handles btnStressSignoff.Click
        SqlConnection1.ConnectionString = sqlString

        OperationsSignOff = txtOperationsAssigned.Text


        '--------------------------------------------------------------------
        If btnStressSignoff.Text = "Sign Off" Then

            'Check Sr Engineer and Stress, and Operations person has been chosen in the Main grid
            If txtSrEngineerAssigned.Text = "" Or txtStressAssigned.Text = "" Then
                MsgBox("You need a value for Sr Engineer and Stress")
                Me.Close()
                Exit Sub
            End If

            'Check Operations person has been chosen in the Main grid
            If txtOperationsAssigned.Text = "" Then
                MsgBox("You need a value for assigned Operations")
                Me.Close()
                Exit Sub
            End If

            'If the roles above(Operations, Releaser and CM) and everything below have been signed off then set Status to Gate 6(the gate of the CM)
            If (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") And (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") And (dtOperationsSignOff.Value <> "01/01/1900" Or btnOperationsSignoff.Text <> "Sign Off") And (dtReleaserSignOff.Value <> "01/01/1900" Or btnReleaserSignoff.Text <> "Sign Off") And (dtCMSignOff.Value <> "01/01/1900" Or btnCMSignOff.Text <> "Sign Off") Then

                'Users cannot move to Gate 2 unless all Redlines are set to Incorporated
                If CanSignOff = "No" Then
                    MsgBox("You cannot sign off and move to Gate 2 before all redlines are set to Incorporated")
                    Me.Close()
                    Exit Sub
                End If

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set StressSignedOffBy = '" & System.Environment.UserName & "', StressComplete = '" & Now & "', Status = 'GATE 6: Complete', PercentComplete = '100' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(3)

                SetIncorporatedRevForRedlines()

                'After a Drn or Adcn is moved to gate 6 then the btnAddRedline can be enabled, even if it was disabled once the redlines were set to incorporated
                If isADCN <> "" Or isDRN <> "" Then
                    SignedOffAdcnDrnGateSix = "Yes"
                End If

                Me.dtStressSignOff.Value = Now
                Me.txtStressSignedOffBy.Text = System.Environment.UserName

                'If the roles above(Operations and Releaser) and everything below has been signed off then set Status to Gate 5(the gate of the releaser)
            ElseIf (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") And (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") And (dtOperationsSignOff.Value <> "01/01/1900" Or btnOperationsSignoff.Text <> "Sign Off") And (dtReleaserSignOff.Value <> "01/01/1900" Or btnReleaserSignoff.Text <> "Sign Off") Then

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set StressSignedOffBy = '" & System.Environment.UserName & "', StressComplete = '" & Now & "', Status = 'GATE 5: DWG Released', PercentComplete = '95' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(3)
                Me.dtStressSignOff.Value = Now
                Me.txtStressSignedOffBy.Text = System.Environment.UserName

                'If the role above(Operations) and everything below has been signed off then set Status to Gate 4(the gate of Operations)
            ElseIf (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") And (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") And (dtOperationsSignOff.Value <> "01/01/1900" Or btnOperationsSignoff.Text <> "Sign Off") Then

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set StressSignedOffBy = '" & System.Environment.UserName & "', StressComplete = '" & Now & "', Status = 'GATE 4: DWG Ready For Release', PercentComplete = '90' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(3)
                Me.dtStressSignOff.Value = Now
                Me.txtStressSignedOffBy.Text = System.Environment.UserName

                'If only everything below the Stress role has been signed off then set the Gate to 4(the gate of Operations)
            ElseIf (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") And (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") Then

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set StressSignedOffBy = '" & System.Environment.UserName & "', StressComplete = '" & Now & "', Status = 'GATE 3: DWG Ready For Operations', PercentComplete = '80' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(3)
                Me.dtStressSignOff.Value = Now
                Me.txtStressSignedOffBy.Text = System.Environment.UserName

                'If there are roles below still to be signed off then just sign off Stress but do not touch the Gate
            Else
                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set StressSignedOffBy = '" & System.Environment.UserName & "', StressComplete = '" & Now & "' Where RecordID = '" & Val(Document) & "'")   ', PercentComplete = '80'
                SendNotifications(3)
                Me.dtStressSignOff.Value = Now
                Me.txtStressSignedOffBy.Text = System.Environment.UserName
            End If

            'RESCIND
        Else
            If txtStressAssigned.Text = "N/A" Then
                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set StressSignedOffBy = '', StressComplete = '01/01/1900', Stress = '', Status = 'GATE 1: DWG Ready For Drafter', PercentComplete = '65' Where RecordID = '" & Val(Document) & "'")   ', EngineerComplete = '01/01/1900'
            Else
                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set StressSignedOffBy = '', StressComplete = '01/01/1900', Status = 'GATE 1: DWG Ready For Drafter', PercentComplete = '65' Where RecordID = '" & Val(Document) & "'")   ', EngineerComplete = '01/01/1900'
            End If
            Me.dtStressSignOff.Value = "01/01/1900"
            Me.txtStressSignedOffBy.Text = ""
        End If
        '-----------------------------------------------------------------------------------



        'PREVIOUS BLOCK OF CODE
        ''Make sure there is a value for assigned Stress
        'If txtStressAssigned.Text = "" Then     'Or dtStressSignOff.Value = "01/01/1900"
        '    MsgBox("You need a value for assigned Stress")
        '    Exit Sub
        'End If

        ''If both Sr Engineer and Stress have a value make sure Operations has one as well. Operations is needed because they will be used to search their email
        'If txtSrEngineerAssigned.Text <> "" And txtStressAssigned.Text <> "" Then       'And dtSrEngineerSignOff.Value <> "01/01/1900" And dtStressSignOff.Value <> "01/01/1900" 
        '    If txtOperationsAssigned.Text = "" Then
        '        MsgBox("You need a value for Operations")
        '        Exit Sub
        '    End If
        'End If

        ''Not signed, off, sign off.
        '' TODO : Need to roll status too.
        'If txtSrEngineerAssigned.Text <> "" And btnSrEngineerSignoff.Text <> "Sign Off" Then
        '    u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set StressSignedOffBy = '" & System.Environment.UserName & "', StressComplete = '" & Now & "', Status = 'GATE 3: DWG Ready For Operations', PercentComplete = '80' Where RecordID = '" & Val(Document) & "'")
        '    SendNotifications(3)
        'Else
        '    u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set StressSignedOffBy = '" & System.Environment.UserName & "', StressComplete = '" & Now & "', PercentComplete = '80' Where RecordID = '" & Val(Document) & "'")
        'End If
        'Me.dtStressSignOff.Value = Now
        'Me.txtStressSignedOffBy.Text = System.Environment.UserName




        CheckReviewStatus()
        'EvaluateStatus()


        Dim CloseSignedOffForm As String = "No"
        NotificationAlreadySentForGateOne = "No"   'Clearing variable(to say that a notification at gate 1 can be sent, since a new doc is being created). Need this because it was sending a notification to Gate 1 people twice, when saving with save btn and when saving with the signoff btn

        Me.Close()
    End Sub

    Private Sub btnOperationsSignoff_Click(sender As Object, e As EventArgs) Handles btnOperationsSignoff.Click
        SqlConnection1.ConnectionString = sqlString

        ReleaserSignOff = txtReleaserAssigned.Text

        '--------------------------------------------------------------------
        If btnOperationsSignoff.Text = "Sign Off" Then

            If txtOperationsAssigned.Text = "" Then
                MsgBox("You need a value for assigned Operations")
                Me.Close()
                Exit Sub
            End If

            'Check Releaser person has been chosen in the Main grid
            If txtReleaserAssigned.Text = "" Then       'Or dtOperationsSignOff.Value = "01/01/1900" 
                MsgBox("You need a value for assigned Releaser")
                Me.Close()
                Exit Sub
            End If

            'If the roles above(Releaser and CM) and everything below have been signed off then set Status to Gate 6(the gate of the CM)
            If (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") And (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") And (btnStressSignoff.Text <> "Sign Off") And (dtReleaserSignOff.Value <> "01/01/1900" Or btnReleaserSignoff.Text <> "Sign Off") And (dtCMSignOff.Value <> "01/01/1900" Or btnCMSignOff.Text <> "Sign Off") Then

                'Users cannot move to Gate 2 unless all Redlines are set to Incorporated
                If CanSignOff = "No" Then
                    MsgBox("You cannot sign off and move to Gate 2 before all redlines are set to Incorporated")
                    Me.Close()
                    Exit Sub
                End If

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set EngineerSignedOffBy = '" & System.Environment.UserName & "', EngineerComplete = '" & Now & "', Status = 'GATE 6: Complete', PercentComplete = '100' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(4)

                SetIncorporatedRevForRedlines()

                'After a Drn or Adcn is moved to gate 6 then the btnAddRedline can be enabled, even if it was disabled once the redlines were set to incorporated
                If isADCN <> "" Or isDRN <> "" Then
                    SignedOffAdcnDrnGateSix = "Yes"
                End If

                Me.dtOperationsSignOff.Value = Now
                Me.txtOperationsSignedOffBy.Text = System.Environment.UserName

                'If the role above(Releaser) and everything below has been signed off then set Status to Gate 5(the gate of the releaser)
            ElseIf (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") And (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") And (btnStressSignoff.Text <> "Sign Off") And (dtReleaserSignOff.Value <> "01/01/1900" Or btnReleaserSignoff.Text <> "Sign Off") Then

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set EngineerSignedOffBy = '" & System.Environment.UserName & "', EngineerComplete = '" & Now & "', Status = 'GATE 5: DWG Released', PercentComplete = '95' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(4)
                Me.dtOperationsSignOff.Value = Now
                Me.txtOperationsSignedOffBy.Text = System.Environment.UserName

                'If only everything below the Operations role has been signed off then set the Gate to 4(the gate of Operations)
            ElseIf (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") And (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") And (btnStressSignoff.Text <> "Sign Off") Then

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set EngineerSignedOffBy = '" & System.Environment.UserName & "', EngineerComplete = '" & Now & "', Status = 'GATE 4: DWG Ready For Release', PercentComplete = '90' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(4)
                Me.dtOperationsSignOff.Value = Now
                Me.txtOperationsSignedOffBy.Text = System.Environment.UserName

                'If there are roles below still to be signed off then just sign off Operations but do not touch the Gate
            Else
                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set EngineerSignedOffBy = '" & System.Environment.UserName & "', EngineerComplete = '" & Now & "' Where RecordID = '" & Val(Document) & "'")   ', PercentComplete = '90'
                SendNotifications(4)
                Me.dtOperationsSignOff.Value = Now
                Me.txtOperationsSignedOffBy.Text = System.Environment.UserName
            End If

        Else
            'RESCIND
            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set EngineerSignedOffBy = '', EngineerComplete = '01/01/1900', Status = 'GATE 1: DWG Ready For Drafter', PercentComplete = '65' Where RecordID = '" & Val(Document) & "'")
            Me.dtOperationsSignOff.Value = "01/01/1900"
            Me.txtOperationsSignedOffBy.Text = ""
        End If
        '--------------------------------------------------------------------


        'PREVIOUS BLOCK OF CODE
        ''Make sure there is a value for assigned Operations and Releaser
        'If txtSrEngineerSignedOffBy.Text = "" Or txtStressSignedOffBy.Text = "" Then
        '    MsgBox("You need to sign off Sr Engineer and Stress")
        '    Exit Sub
        '    If txtReleaserAssigned.Text = "" Then       'txtOperationsAssigned.Text = "" Or         'Or dtOperationsSignOff.Value = "01/01/1900" 
        '        MsgBox("You need a value for assigned Releaser")
        '        Exit Sub
        '    End If
        'End If

        ''Not signed, off, sign off.
        '' TODO : Need to roll status too.
        'u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set EngineerSignedOffBy = '" & System.Environment.UserName & "', EngineerComplete = '" & Now & "', Status = 'GATE 4: DWG Ready For Release', PercentComplete = '90' Where RecordID = '" & Val(Document) & "'")
        'SendNotifications(4)
        'Me.dtOperationsSignOff.Value = Now
        'Me.txtOperationsSignedOffBy.Text = System.Environment.UserName



        CheckReviewStatus()
        'EvaluateStatus()


        'Disable Releaser signoff button if the other roles have not signed off, otherwise enable it
        If btnDrafterSignoff.Text = "Rescind" And btnSrEngineerSignoff.Text = "Rescind" And btnStressSignoff.Text = "Rescind" And btnOperationsSignoff.Text = "Rescind" Then
            If CM = True Then
                btnReleaserSignoff.Enabled = True
            End If
        Else
            btnReleaserSignoff.Enabled = False
        End If



        Dim CloseSignedOffForm As String = "No"

        Me.Close()
    End Sub

    Private Sub btnReleaserSignoff_Click(sender As Object, e As EventArgs) Handles btnReleaserSignoff.Click
        SqlConnection1.ConnectionString = sqlString

        ReleaserBtnClicked = "Yes"


        '--------------------------------------------------------------------
        If btnReleaserSignoff.Text = "Sign Off" Then

            If txtReleaserAssigned.Text = "" Then
                MsgBox("You need a value for assigned Releaser")
                Me.Close()
                Exit Sub
            End If

            'If the roles above(CM) and everything below have been signed off then set Status to Gate 6(the gate of the CM)
            If (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") And (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") And (btnStressSignoff.Text <> "Sign Off") And (dtOperationsSignOff.Value <> "01/01/1900" Or btnOperationsSignoff.Text <> "Sign Off") And (dtCMSignOff.Value <> "01/01/1900" Or btnCMSignOff.Text <> "Sign Off") Then

                'Users cannot move to Gate 2 unless all Redlines are set to Incorporated
                If CanSignOff = "No" Then
                    MsgBox("You cannot sign off and move to Gate 2 before all redlines are set to Incorporated")
                    Me.Close()
                    Exit Sub
                End If

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set ReleaserSignedOffBy = '" & System.Environment.UserName & "', ReleaserCompelte = '" & Now & "', Status = 'GATE 6: Complete', PercentComplete = '100' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(5)

                SetIncorporatedRevForRedlines()

                'After a Drn or Adcn is moved to gate 6 then the btnAddRedline can be enabled, even if it was disabled once the redlines were set to incorporated
                If isADCN <> "" Or isDRN <> "" Then
                    SignedOffAdcnDrnGateSix = "Yes"
                End If

                Me.dtReleaserSignOff.Value = Now
                Me.txtReleaserSignedOffBy.Text = System.Environment.UserName

                'If everything below the Releaser role has been signed off then set the Gate to 5(the gate of Releaser)
            ElseIf (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") And (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") And (btnStressSignoff.Text <> "Sign Off") And (dtOperationsSignOff.Value <> "01/01/1900" Or btnOperationsSignoff.Text <> "Sign Off") Then

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set ReleaserSignedOffBy = '" & System.Environment.UserName & "', ReleaserCompelte = '" & Now & "', Status = 'GATE 5: DWG Released', PercentComplete = '95' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(5)
                Me.dtReleaserSignOff.Value = Now
                Me.txtReleaserSignedOffBy.Text = System.Environment.UserName

            Else
                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set ReleaserSignedOffBy = '" & System.Environment.UserName & "', ReleaserCompelte = '" & Now & "' Where RecordID = '" & Val(Document) & "'")   ', PercentComplete = '95' 
                SendNotifications(5)
                Me.dtReleaserSignOff.Value = Now
                Me.txtReleaserSignedOffBy.Text = System.Environment.UserName
            End If

            'RESCIND
        Else
            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set ReleaserSignedOffBy = '', ReleaserCompelte = '01/01/1900', Status = 'GATE 1: DWG Ready For Drafter', PercentComplete = '65' Where RecordID = '" & Val(Document) & "'")
            Me.dtReleaserSignOff.Value = "01/01/1900"
            Me.txtReleaserSignedOffBy.Text = ""
        End If
        '-----------------------------------------------------------------------------------------

        'PREVIOUS BLOCK OF CODE
        ''Make sure there is a value for assigned Releaser 
        'If txtReleaserAssigned.Text = "" Then       'Or dtReleaserSignOff.Value = "01/01/1900" 
        '    MsgBox("You need a name for assigned Releaser")
        '    Exit Sub
        'End If

        ''Not signed, off, sign off.
        '' TODO : Need to roll status too.
        'u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set ReleaserSignedOffBy = '" & System.Environment.UserName & "', ReleaserCompelte = '" & Now & "', Status = 'GATE 5: DWG Released', PercentComplete = '95' Where RecordID = '" & Val(Document) & "'")
        'SendNotifications(5)
        'Me.dtReleaserSignOff.Value = Now
        'Me.txtReleaserSignedOffBy.Text = System.Environment.UserName


        CheckReviewStatus()
        'EvaluateStatus()


        'Disable CM signoff button if the other roles have not signed off, otherwise enable it
        If btnDrafterSignoff.Text = "Rescind" And btnSrEngineerSignoff.Text = "Rescind" And btnStressSignoff.Text = "Rescind" And btnOperationsSignoff.Text = "Rescind" And btnReleaserSignoff.Text = "Rescind" Then
            If CM = True Then
                btnCMSignOff.Enabled = True
            End If
        Else
            btnCMSignOff.Enabled = False
        End If



        Dim CloseSignedOffForm As String = "No"

        ReleaserBtnClicked = ""

        Me.Close()
    End Sub

    Private Sub btnCMSignOff_Click(sender As Object, e As EventArgs) Handles btnCMSignOff.Click
        SqlConnection1.ConnectionString = sqlString


        If btnCMSignOff.Text = "Sign Off" Then

            ''Check CM person has been chosen in the Main grid
            'If txtCMAssigned.Text = "" Then
            '    MsgBox("You need a value for assigned CM")
            '    Me.Close()
            '    Exit Sub
            'End If


            If (dtDrafterSignOff.Value <> "01/01/1900" Or btnDrafterSignoff.Text <> "Sign Off") And (dtSrEngineerSignOff.Value <> "01/01/1900" Or btnSrEngineerSignoff.Text <> "Sign Off") And (btnStressSignoff.Text <> "Sign Off") And (dtOperationsSignOff.Value <> "01/01/1900" Or btnOperationsSignoff.Text <> "Sign Off") And (dtReleaserSignOff.Value <> "01/01/1900" Or btnReleaserSignoff.Text <> "Sign Off") Then

                'Users cannot move to Gate 2 unless all Redlines are set to Incorporated
                If CanSignOff = "No" Then
                    MsgBox("You cannot sign off and move to Gate 6 before all redlines are set to Incorporated")
                    Me.Close()
                    Exit Sub
                End If

                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set CMSignedOffBy = '" & System.Environment.UserName & "', ActualFinishDate = '" & Now & "', Status = 'GATE 6: Complete', PercentComplete = '100' Where RecordID = '" & Val(Document) & "'")
                SendNotifications(6)

                SetIncorporatedRevForRedlines()

                'After a Drn or Adcn is moved to gate 6 then the btnAddRedline can be enabled, even if it was disabled once the redlines were set to incorporated
                If isADCN <> "" Or isDRN <> "" Then
                    SignedOffAdcnDrnGateSix = "Yes"
                End If

                Me.dtCMSignOff.Value = Now
                Me.txtCMSignedOffBy.Text = System.Environment.UserName

                'If there are roles below still to be signed off then just sign off CM but do not touch the Gate
            Else
                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set CMSignedOffBy = '" & System.Environment.UserName & "', ActualFinishDate = '" & Now & "' Where RecordID = '" & Val(Document) & "'")     ', PercentComplete = '100'
                SendNotifications(6)
                Me.dtCMSignOff.Value = Now
                Me.txtCMSignedOffBy.Text = System.Environment.UserName
            End If

            'RESCIND
        Else

            If isAdmin = "T" Then
                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set CMSignedOffBy = '', ActualFinishDate = '01/01/1900', Status = 'GATE 1: DWG Ready For Drafter', PercentComplete = '65' Where RecordID = '" & Val(Document) & "'")
                Me.dtCMSignOff.Value = "01/01/1900"
                Me.txtCMSignedOffBy.Text = ""
            Else
                MsgBox("You cannot Rescind CM as you are not an administrator")
                Me.Close()
                Exit Sub
            End If
        End If
        '--------------------------------------------------------------------------

        'PREVIOUS BLOCK OF CODE
        ''If dtCMSignOff.Value = "01/01/1900" Then
        ''    MsgBox("You need a CM date")
        ''    Exit Sub
        ''End If

        ''Not signed, off, sign off.
        '' TODO : Need to roll status too.
        'u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set CMSignedOffBy = '" & System.Environment.UserName & "', ActualFinishDate = '" & Now & "', Status = 'GATE 6: Complete', PercentComplete = '100' Where RecordID = '" & Val(Document) & "'")
        'SendNotifications(6)
        'Me.dtCMSignOff.Value = Now
        'Me.txtCMSignedOffBy.Text = System.Environment.UserName


        CheckReviewStatus()
        'EvaluateStatus()


        Dim CloseSignedOffForm As String = "No"

        Me.Close()
    End Sub

    Public Function SetIncorporatedRevForRedlines()

        Dim LastDrn As String = ""
        Dim LastAdcn As String = ""
        Dim LastRevForIncorporatedRev As String = ""
        Dim RevToBeChanged As String = ""

        'Get the Rev of the redlines that belong to the rev previous to the actual one(the last one). This rev taken will then be used in the block of code following this one
        'to set the IncorporatedRev for the redlines of the rev previous to the last one
        da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & DrawNumForSignOff & "' And DwgRevision != '" & InitialRevValue & "' And Status = 'GATE 6: Complete' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq desc, RecordID Desc", SqlConnection1)   'And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '')
        da.Fill(ds, "RevBeforeTheLast")

        If ds.Tables("RevBeforeTheLast").Rows.Count > 0 Then
            RevToBeChanged = ds.Tables("RevBeforeTheLast").Rows(0).Item("DwgRevision")


            'When any Rev is moved to gate 6 then make the IncorporatedRev for the latest redlines for that draw# equal to to the latest rev(the one just added)
            da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & DrawNumForSignOff & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq desc, RecordID Desc", SqlConnection1)   'And Status = 'GATE 6: Complete' And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '')
            da.Fill(ds, "LastRevForIncorporatedRev")

            If ds.Tables("LastRevForIncorporatedRev").Rows.Count > 0 Then
                LastDrn = ds.Tables("LastRevForIncorporatedRev").Rows(0).Item("DRNADCN")
                LastAdcn = ds.Tables("LastRevForIncorporatedRev").Rows(0).Item("ADCN")

                If LastDrn <> "" Then
                    'In case of DRN the last redlines are set to the last rev and not the one before the last
                    da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & DrawNumForSignOff & "' And Status = 'GATE 6: Complete' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq desc, RecordID Desc", SqlConnection1)   'And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '')
                    da.Fill(ds, "LastRevForDRNOrADCN")
                    RevToBeChanged = ds.Tables("LastRevForDRNOrADCN").Rows(0).Item("DwgRevision")

                    u.ExecuteSQL(SqlConnection1, "Update tblRedlines Set IncorporatedRev = '" & LastDrn & "' Where Rev = '" & RevToBeChanged & "' And DrawingNum = '" & DrawNumForSignOff & "' And (IncorporatedRev = '' Or IncorporatedRev Is Null)")    'And Rev = '" & RevSelectedRedline & "' 

                    ds.Tables("LastRevForIncorporatedRev").Clear()
                    ds.Tables("LastRevForIncorporatedRev").Dispose()

                ElseIf LastAdcn <> "" Then
                    'In case of ADCN the last redlines are set to the last rev and not the one before the last
                    da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & DrawNumForSignOff & "' And Status = 'GATE 6: Complete' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq desc, RecordID Desc", SqlConnection1)   'And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '')
                    da.Fill(ds, "LastRevForDRNOrADCN")
                    RevToBeChanged = ds.Tables("LastRevForDRNOrADCN").Rows(0).Item("DwgRevision")

                    u.ExecuteSQL(SqlConnection1, "Update tblRedlines Set IncorporatedRev = '" & LastAdcn & "' Where Rev = '" & RevToBeChanged & "' And DrawingNum = '" & DrawNumForSignOff & "' And (IncorporatedRev = '' Or IncorporatedRev Is Null)")    'And Rev = '" & RevSelectedRedline & "' 

                    ds.Tables("LastRevForIncorporatedRev").Clear()
                    ds.Tables("LastRevForIncorporatedRev").Dispose()

                Else
                    LastRevForIncorporatedRev = ds.Tables("LastRevForIncorporatedRev").Rows(0).Item("DwgRevision")

                    u.ExecuteSQL(SqlConnection1, "Update tblRedlines Set IncorporatedRev = '" & LastRevForIncorporatedRev & "' Where Rev = '" & RevToBeChanged & "' And DrawingNum = '" & DrawNumForSignOff & "' And (IncorporatedRev = '' Or IncorporatedRev Is Null)")    'And Rev = '" & RevSelectedRedline & "' 
                End If

                ds.Tables("LastRevForIncorporatedRev").Clear()
                ds.Tables("LastRevForIncorporatedRev").Dispose()
            End If

            ds.Tables("RevBeforeTheLast").Clear()
            ds.Tables("RevBeforeTheLast").Dispose()

            'This is when the only Rev is IR, so there is only one. This code should actually never do anything because it is not possible to add a redline when there is only an IR
        Else

            'When any Rev is moved to gate 6 then make the IncorporatedRev for the latest redlines for that draw# equal to to the latest rev
            da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & DrawNumForSignOff & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq desc, RecordID Desc", SqlConnection1)   'And Status = 'GATE 6: Complete' And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '')
            da.Fill(ds, "LastRevForIncorporatedRev")

            If ds.Tables("LastRevForIncorporatedRev").Rows.Count > 0 Then
                LastDrn = ds.Tables("LastRevForIncorporatedRev").Rows(0).Item("DRNADCN")
                LastAdcn = ds.Tables("LastRevForIncorporatedRev").Rows(0).Item("ADCN")

                If LastDrn <> "" Then
                    'In case of DRN the last redlines are set to the last rev and not the one before the last
                    da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & DrawNumForSignOff & "' And Status = 'GATE 6: Complete' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq desc, RecordID Desc", SqlConnection1)   'And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '')
                    da.Fill(ds, "LastRevForDRNOrADCN")
                    RevToBeChanged = ds.Tables("LastRevForDRNOrADCN").Rows(0).Item("DwgRevision")

                    u.ExecuteSQL(SqlConnection1, "Update tblRedlines Set IncorporatedRev = '" & LastDrn & "' Where DrawingNum = '" & DrawNumForSignOff & "' And (IncorporatedRev = '' Or IncorporatedRev Is Null)")    'And Rev = '" & RevSelectedRedline & "' 

                    ds.Tables("LastRevForIncorporatedRev").Clear()
                    ds.Tables("LastRevForIncorporatedRev").Dispose()

                ElseIf LastAdcn <> "" Then
                    'In case of ADCN the last redlines are set to the last rev and not the one before the last
                    da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & DrawNumForSignOff & "' And Status = 'GATE 6: Complete' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq desc, RecordID Desc", SqlConnection1)   'And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '')
                    da.Fill(ds, "LastRevForDRNOrADCN")
                    RevToBeChanged = ds.Tables("LastRevForDRNOrADCN").Rows(0).Item("DwgRevision")

                    u.ExecuteSQL(SqlConnection1, "Update tblRedlines Set IncorporatedRev = '" & LastAdcn & "' Where DrawingNum = '" & DrawNumForSignOff & "' And (IncorporatedRev = '' Or IncorporatedRev Is Null)")    'And Rev = '" & RevSelectedRedline & "' 

                    ds.Tables("LastRevForIncorporatedRev").Clear()
                    ds.Tables("LastRevForIncorporatedRev").Dispose()

                Else
                    LastRevForIncorporatedRev = ds.Tables("LastRevForIncorporatedRev").Rows(0).Item("DwgRevision")

                    u.ExecuteSQL(SqlConnection1, "Update tblRedlines Set IncorporatedRev = '" & LastRevForIncorporatedRev & "' Where DrawingNum = '" & DrawNumForSignOff & "' And (IncorporatedRev = '' Or IncorporatedRev Is Null)")    'And Rev = '" & RevSelectedRedline & "' 
                End If

                ds.Tables("LastRevForIncorporatedRev").Clear()
                ds.Tables("LastRevForIncorporatedRev").Dispose()
            End If

            ds.Tables("RevBeforeTheLast").Clear()
            ds.Tables("RevBeforeTheLast").Dispose()
        End If

    End Function

    'Public Function EvaluateStatus()



    '    'COMMENTED OUT AS OF 01/27/2021
    '    If dtDrafterSignOff.Value = "01/01/1900" Or dtDrafterSignOff.Value = "01/01/2000" Then

    '        u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 1: DWG Ready For Drafter', PercentComplete = '0' Where RecordID = '" & Val(Document) & "'")
    '        SendNotifications(1)

    '    ElseIf dtDrafterSignOff.Value <> "01/01/1900" And dtSrEngineerSignOff.Value = "01/01/1900" And dtStressSignOff.Value = "01/01/1900" And txtStressAssigned.Text <> "N/A" Or dtDrafterSignOff.Value <> "01/01/1900" And dtSrEngineerSignOff.Value <> "01/01/1900" And dtStressSignOff.Value = "01/01/1900" And txtStressAssigned.Text <> "N/A" Then

    '        'Notification to CM
    '        If txtDrafterAssigned.Text <> "" And txtSrEngineerAssigned.Text <> "" And txtStressAssigned.Text <> "" And txtOperationsAssigned.Text <> "" And txtReleaserAssigned.Text <> "" Then
    '            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 5: DWG Released', PercentComplete = '95' Where RecordID = '" & Val(Document) & "'")
    '            SendNotifications(5)
    '        ElseIf txtSrEngineerAssigned.Text <> "" Then
    '            'Notification to Operations
    '            SendNotifications(3)
    '            If txtSrEngineerAssigned.Text <> "" And txtStressAssigned.Text <> "" Then       'Set Status to Gate 3 only if both Sr Engineer and Stress have a value
    '                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 3: DWG Ready For Operations', PercentComplete = '80' Where RecordID = '" & Val(Document) & "'")
    '            End If
    '        Else
    '            'Notification to Senior Engineer/Stress
    '            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 2: DWG Ready For Sr Engineer', PercentComplete = '70' Where RecordID = '" & Val(Document) & "'")
    '            SendNotifications(2)
    '        End If

    '    ElseIf dtDrafterSignOff.Value <> "01/01/1900" And dtSrEngineerSignOff.Value <> "01/01/1900" And (dtStressSignOff.Value <> "01/01/1900" Or Me.txtStressAssigned.Text = "N/A") And dtOperationsSignOff.Value = "01/01/1900" Then

    '        If txtDrafterAssigned.Text <> "" And txtSrEngineerAssigned.Text <> "" And txtStressAssigned.Text <> "" And txtOperationsAssigned.Text <> "" And txtReleaserAssigned.Text <> "" And ReleaserBtnClicked = "Yes" Then
    '            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 5: DWG Released', PercentComplete = '95' Where RecordID = '" & Val(Document) & "'")
    '            'Notification to CM
    '            SendNotifications(5)
    '        ElseIf txtDrafterAssigned.Text <> "" And txtSrEngineerAssigned.Text <> "" And txtStressAssigned.Text <> "" And txtOperationsAssigned.Text <> "" And txtReleaserAssigned.Text <> "" Then
    '            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 6: Complete', PercentComplete = '100' Where RecordID = '" & Val(Document) & "'")
    '            'Notification to Integrated Program Team
    '            SendNotifications(6)
    '        ElseIf txtReleaserAssigned.Text <> "" Then
    '            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 5: DWG Released', PercentComplete = '95' Where RecordID = '" & Val(Document) & "'")
    '            'Notification to CM
    '            SendNotifications(5)
    '        ElseIf txtOperationsAssigned.Text = "N/A" Then
    '            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 4: DWG Ready For Release', PercentComplete = '90', EngineerComplete = '" & Now & "'  Where RecordID = '" & Val(Document) & "'")
    '            'Notification to Releaser
    '            SendNotifications(4)
    '        Else
    '            'Notification to Operations
    '            SendNotifications(3)
    '            If txtSrEngineerAssigned.Text <> "" And txtStressAssigned.Text <> "" Then       'Set Status to Gate 3 only if both Sr Engineer and Stress have a value
    '                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 3: DWG Ready For Operations', PercentComplete = '80' Where RecordID = '" & Val(Document) & "'")
    '            End If
    '        End If

    '    ElseIf dtDrafterSignOff.Value <> "01/01/1900" And dtSrEngineerSignOff.Value <> "01/01/1900" And (dtStressSignOff.Value <> "01/01/1900" Or txtStressAssigned.Text = "N/A") And dtOperationsSignOff.Value <> "01/01/1900" And dtReleaserSignOff.Value = "01/01/1900" Or dtDrafterSignOff.Value <> "01/01/1900" And dtSrEngineerSignOff.Value <> "01/01/1900" And dtStressSignOff.Value <> "01/01/1900" And Me.txtOperationsAssigned.Text = "N/A" And dtReleaserSignOff.Value = "01/01/1900" Then
    '        u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 4: DWG Ready For Release', PercentComplete = '90' Where RecordID = '" & Val(Document) & "'")
    '        'Notification to Releaser
    '        SendNotifications(4)

    '    ElseIf dtDrafterSignOff.Value <> "01/01/1900" And dtSrEngineerSignOff.Value <> "01/01/1900" And (dtStressSignOff.Value <> "01/01/1900" Or txtStressAssigned.Text = "N/A") And (Me.txtOperationsAssigned.Text = "N/A" Or dtOperationsSignOff.Value <> "01/01/1900") And dtReleaserSignOff.Value <> "01/01/1900" And dtCMSignOff.Value = "01/01/1900" Or dtDrafterSignOff.Value <> "01/01/1900" And dtSrEngineerSignOff.Value <> "01/01/1900" And dtStressSignOff.Value <> "01/01/1900" And dtOperationsSignOff.Value <> "01/01/1900" And dtReleaserSignOff.Value <> "01/01/1900" And dtCMSignOff.Value = "01/01/1900" Then
    '        u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 5: DWG Released', PercentComplete = '95' Where RecordID = '" & Val(Document) & "'")
    '        'Notification to CM
    '        SendNotifications(5)

    '    ElseIf dtDrafterSignOff.Value <> "01/01/1900" And dtSrEngineerSignOff.Value <> "01/01/1900" And (dtStressSignOff.Value <> "01/01/1900" Or txtStressAssigned.Text = "N/A") And dtOperationsSignOff.Value <> "01/01/1900" And dtReleaserSignOff.Value <> "01/01/1900" And dtCMSignOff.Value <> "01/01/1900" Or dtDrafterSignOff.Value <> "01/01/1900" And dtSrEngineerSignOff.Value <> "01/01/1900" And dtStressSignOff.Value <> "01/01/1900" And Me.txtOperationsAssigned.Text = "N/A" And dtReleaserSignOff.Value <> "01/01/1900" And dtCMSignOff.Value <> "01/01/1900" Then
    '        u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 6: Complete', PercentComplete = '100' Where RecordID = '" & Val(Document) & "'")
    '        'Notification to Integrated Program Team
    '        SendNotifications(6)

    '        'For sending email to CM, after releaser has been filled out
    '    ElseIf txtDrafterAssigned.Text <> "" And txtSrEngineerAssigned.Text <> "" And txtStressAssigned.Text <> "" And txtOperationsAssigned.Text <> "" And txtReleaserAssigned.Text <> "" Then
    '        u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 5: DWG Released', PercentComplete = '95' Where RecordID = '" & Val(Document) & "'")
    '        SendNotifications(5)
    '    Else

    '        'SendNotifications(4) is used for sending message to Releaser
    '        If txtOperationsAssigned.Text <> "" Then
    '            'This is for when Senior Engineer is N/A and stress is filled out
    '            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 4: DWG Ready For Release', PercentComplete = '90' Where RecordID = '" & Val(Document) & "'")
    '            SendNotifications(4)
    '        Else
    '            'Notification to Operations
    '            SendNotifications(3)
    '            If txtSrEngineerAssigned.Text <> "" And txtStressAssigned.Text <> "" Then       'Set Status to Gate 3 only if both Sr Engineer and Stress have a value
    '                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 3: DWG Ready For Operations', PercentComplete = '80' Where RecordID = '" & Val(Document) & "'")
    '            End If
    '        End If
    '    End If
    'End Function

    Public Function SendNotifications(Gate As Integer, Optional ByVal SMTPServer As String = "172.16.3.14")
        Dim client As SmtpClient
        Dim myMessage As MailMessage
        Dim emailFrom As MailAddress
        Dim emailTo As MailAddress
        Dim Email As String
        Dim MoreEmails As String
        Dim EmailSubject As String
        Dim EmailBody As String
        SqlConnection1.ConnectionString = sqlString

        Dim ListOfUserIDs As String = ""
        Dim ListOfUsernames As String = ""


        'GET ID OF PEOPLE IN NOTIFICATIONS TABLE TO WHOM SEND EMAIL
        If Gate = 0 Then            'Planner and Lead Engineer
            'da = New SqlClient.SqlDataAdapter("Select Email from tblNotificationsGroups Where Gate0 = 1 And (Role = 'Planner' Or Role = 'Lead Engineer') And Program = '" & ProgramName & "' And Active = 1", SqlConnection1)
            da = New SqlClient.SqlDataAdapter("Select [User] from tblNotificationsGroups Where (Gate0 = 1 And (Role = 'Planner' Or Role = 'Lead Engineer') And Program = '" & ProgramName & "' And Active = 1) Or (Gate0 = 1 And Program = '" & ProgramName & "' And Active = 1)", SqlConnection1)

        ElseIf Gate = 1 Then        'Drafter and Lead Engineer
            'da = New SqlClient.SqlDataAdapter("Select Email from tblNotificationsGroups Where Gate1 = 1 And ([User] = '" & User & "' Or Role = 'Lead Engineer') And Program = '" & ProgramName & "' And Active = 1", SqlConnection1)
            da = New SqlClient.SqlDataAdapter("Select [User] from tblNotificationsGroups Where (Gate1 = 1 And Role = 'Lead Engineer' And Program = '" & ProgramName & "' And Active = 1) Or (Gate1 = 1 And Program = '" & ProgramName & "' And Active = 1)", SqlConnection1)

        ElseIf Gate = 2 Then        'Sr Engineer, Stress and Lead Engineer
            'da = New SqlClient.SqlDataAdapter("Select Email from tblNotificationsGroups Where Gate2 = 1 And ([User] = '" & SrEngineerSignOff & "' Or [User] = '" & StressSignOff & "' Or Role = 'Lead Engineer') And Program = '" & ProgramName & "' And Active = 1", SqlConnection1)
            da = New SqlClient.SqlDataAdapter("Select [User] from tblNotificationsGroups Where (Gate2 = 1 And Role = 'Lead Engineer' And Program = '" & ProgramName & "' And Active = 1) Or (Gate2 = 1 And Program = '" & ProgramName & "' And Active = 1)", SqlConnection1)

            'Send email also to users that are listed to sign off the relative gate on the main FDT screen
            ListOfUserIDs = "'" & SrEngineerSignOff & "'"
            If ListOfUserIDs = "" Then
                ListOfUserIDs = "'" & StressSignOff & "'"
            Else
                ListOfUserIDs = ListOfUserIDs & ", '" & StressSignOff & "'"
            End If

        ElseIf Gate = 3 Then        'Operations and Lead Engineer
            'Send emails only if both Sr Engineer and Stress assigned are filled out
            'If txtSrEngineerAssigned.Text <> "" And txtStressAssigned.Text <> "" And dtSrEngineerSignOff.Value <> "01/01/1900" And dtStressSignOff.Value <> "01/01/1900" Then
            'da = New SqlClient.SqlDataAdapter("Select Email from tblNotificationsGroups Where Gate3 = 1 And ([User] = '" & OperationsSignOff & "' Or Role = 'Lead Engineer') And Program = '" & ProgramName & "' And Active = 1", SqlConnection1)
            da = New SqlClient.SqlDataAdapter("Select [User] from tblNotificationsGroups Where (Gate3 = 1 And Role = 'Lead Engineer' And Program = '" & ProgramName & "' And Active = 1) Or (Gate3 = 1 And Program = '" & ProgramName & "' And Active = 1)", SqlConnection1)
            'Else
            '    MsgBox("You need a name value and a date for Sr Engineer and Stress")
            '    GoTo DONOTSENDEMAIL
            'End If

            'Send email also to users that are listed to sign off the relative gate on the main FDT screen
            ListOfUserIDs = "'" & OperationsSignOff & "'"

        ElseIf Gate = 4 Then        'Releaser and Lead Engineer
            'da = New SqlClient.SqlDataAdapter("Select Email from tblNotificationsGroups Where Gate4 = 1 And ([User] = '" & ReleaserSignOff & "' Or Role = 'Lead Engineer') And Program = '" & ProgramName & "' And Active = 1", SqlConnection1)
            da = New SqlClient.SqlDataAdapter("Select [User] from tblNotificationsGroups Where (Gate4 = 1 And Role = 'Lead Engineer' And Program = '" & ProgramName & "' And Active = 1) Or (Gate4 = 1 And Program = '" & ProgramName & "' And Active = 1)", SqlConnection1)

            'Send email also to users that are listed to sign off the relative gate on the main FDT screen
            ListOfUserIDs = "'" & ReleaserSignOff & "'"

        ElseIf Gate = 5 Then        'CM Administrator and Lead Engineer
            'da = New SqlClient.SqlDataAdapter("Select Email from tblNotificationsGroups Where Gate5 = 1 And ( Role = 'Configuration Management Administrator' Or Role = 'Lead Engineer') And Program = '" & ProgramName & "' And Active = 1", SqlConnection1)
            da = New SqlClient.SqlDataAdapter("Select [User] from tblNotificationsGroups Where (Gate5 = 1 And (Role = 'Configuration Management' Or Role = 'Lead Engineer') And Program = '" & ProgramName & "' And Active = 1) Or (Gate5 = 1 And Program = '" & ProgramName & "' And Active = 1)", SqlConnection1)

        ElseIf Gate = 6 Then        'Programs Team
            'da = New SqlClient.SqlDataAdapter("Select Email from tblNotificationsGroups Where Gate6 = 1 And (Role = 'Integrated Program Team') And Program = '" & ProgramName & "' And Active = 1", SqlConnection1)
            da = New SqlClient.SqlDataAdapter("Select [User] from tblNotificationsGroups Where (Gate6 = 1 And (Role = 'Integrated Program Team' Or Role = 'Lead Engineer') And Program = '" & ProgramName & "' And Active = 1) Or (Gate6 = 1 And Program = '" & ProgramName & "' And Active = 1)", SqlConnection1)
        ElseIf Gate = 7 Then        'Planner, CM Administrator and Lead Engineer
            da = New SqlClient.SqlDataAdapter("Select [User] from tblNotificationsGroups Where (Gate0 = 1 And (Role = 'Configuration Management' Or Role = 'Lead Engineer' Or Role = 'Planner') And Program = '" & ProgramName & "' And Active = 1) Or (Gate0 = 1 And Program = '" & ProgramName & "' And Active = 1)", SqlConnection1)

        Else
            GoTo GETEMAILADDRESSES
        End If


        da.Fill(ds, "UserID")


        ''Jim Added this for situations where no program/users exist  02/23/2021
        If ListOfUserIDs = "" Then
            If ds.Tables("UserID").Rows.Count = 0 Then
                GoTo DONOTSENDEMAIL
            End If
        End If

        Dim a As Integer = 0
        While a <= ds.Tables("UserID").Rows.Count - 1
            If ListOfUserIDs = "" Then
                ListOfUserIDs = "'" & ds.Tables("UserID").Rows(a).Item("User") & "'"
            Else
                ListOfUserIDs = ListOfUserIDs & ", '" & ds.Tables("UserID").Rows(a).Item("User") & "'"
            End If
            a = a + 1
        End While

        ds.Tables("UserID").Clear()
        ds.Tables("UserID").Dispose()



GETEMAILADDRESSES:
        'GET EMAILS OF PEOPLE
        If Gate = 0 Then            'Planner and Lead Engineer
            da = New SqlClient.SqlDataAdapter("Select Email from tblUsers Where (ID IN(" & ListOfUserIDs & "))", SqlConnection1)
            EmailBody = "A new record has been created " & DrawingNumForEmails & " " & RevisionForEmails     'Document
            EmailSubject = "New Record Created " & DrawingNumForEmails & " " & RevisionForEmails
        ElseIf Gate = 1 Then        'Drafter and Lead Engineer
            da = New SqlClient.SqlDataAdapter("Select Email from tblUsers Where (ID IN(" & ListOfUserIDs & ")) Or (ID = '" & DrafterSignOff & "' And Drafter = 'T' And Active = 1)", SqlConnection1)
            EmailBody = "You have a new task pending " & DrawingNumForEmails & " " & RevisionForEmails      'Document
            EmailSubject = "New Task Pending " & DrawingNumForEmails & " " & RevisionForEmails
        ElseIf Gate = 2 Then        'Sr Engineer, Stress and Lead Engineer
            da = New SqlClient.SqlDataAdapter("Select Email from tblUsers Where (ID IN(" & ListOfUserIDs & ")) Or (ID = '" & SrEngineerSignOff & "' And SrEngineer = 'T' And Active = 1) Or (ID = '" & StressSignOff & "' And Stress = 'T' And Active = 1)", SqlConnection1)
            EmailBody = "You have a record to sign off " & DrawingNumForEmails & " " & RevisionForEmails     'Document
            EmailSubject = "Sign Off Pending " & DrawingNumForEmails & " " & RevisionForEmails
        ElseIf Gate = 3 Then        'Operations and Lead Engineer
            'Send emails only if both Sr Engineer and Stress assigned are filled out
            If txtSrEngineerAssigned.Text <> "" And txtStressAssigned.Text <> "" Then
                da = New SqlClient.SqlDataAdapter("Select Email from tblUsers Where (ID IN(" & ListOfUserIDs & ")) Or (ID = '" & OperationsSignOff & "' And Engineer = 'T' And Active = 1)", SqlConnection1)
            Else
                MsgBox("You need a name value for Sr Engineer and Stress. Otherwise enter N/A.")
                GoTo DONOTSENDEMAIL
            End If
            EmailBody = "You have a record to sign off " & DrawingNumForEmails & " " & RevisionForEmails     'Document
            EmailSubject = "Sign Off Pending " & DrawingNumForEmails & " " & RevisionForEmails

        ElseIf Gate = 4 Then        'Releaser and Lead Engineer
            da = New SqlClient.SqlDataAdapter("Select Email from tblUsers Where (ID IN(" & ListOfUserIDs & ")) Or (ID = '" & ReleaserSignOff & "' And Releaser = 'T' And Active = 1)", SqlConnection1)
            EmailBody = "You have a record to sign off " & DrawingNumForEmails & " " & RevisionForEmails     'Document
            EmailSubject = "Sign Off Pending " & DrawingNumForEmails & " " & RevisionForEmails
        ElseIf Gate = 5 Then        'CM Administrator and Lead Engineer
            da = New SqlClient.SqlDataAdapter("Select Email from tblUsers Where (ID IN(" & ListOfUserIDs & "))", SqlConnection1)
            EmailBody = "You have a record to sign off " & DrawingNumForEmails & " " & RevisionForEmails     'Document
            EmailSubject = "Sign Off Pending " & DrawingNumForEmails & " " & RevisionForEmails
        ElseIf Gate = 6 Then        'Programs Team
            da = New SqlClient.SqlDataAdapter("Select Email from tblUsers Where (ID IN(" & ListOfUserIDs & "))", SqlConnection1)
            EmailBody = "Document released from Engineering " & DrawingNumForEmails & " " & RevisionForEmails     'Document
            EmailSubject = "Released " & DrawingNumForEmails & " " & RevisionForEmails
        ElseIf Gate = 7 Then        'Planner, CM Administrator and Lead Engineer
            da = New SqlClient.SqlDataAdapter("Select Email from tblUsers Where (ID IN(" & ListOfUserIDs & "))", SqlConnection1)
            EmailBody = "You have a record to sign off " & DrawingNumForEmails & " " & RevisionForEmails     'Document
            EmailSubject = "Sign Off Pending " & DrawingNumForEmails & " " & RevisionForEmails
        ElseIf Gate = 8 Then        'Drafter email for Form B, when creating a new document
            da = New SqlClient.SqlDataAdapter("Select Email from tblUsers Where ID = '" & DrafterFormB & "' And Drafter = 'T'", SqlConnection1)
            EmailBody = "You have a record to sign off " & DrawingNumForEmails & " " & RevisionForEmails     'Document
            EmailSubject = "Sign Off Pending " & DrawingNumForEmails & " " & RevisionForEmails
        Else
            'Nothing
        End If


        da.Fill(ds, "Emails")

        'GET EMAIL ADDRESSES
        'da.Fill(ds, "Emails")
        Dim i As Integer = 0
        While i <= ds.Tables("Emails").Rows.Count - 1
            ''If Email = "" Then
            ''    Email = ds.Tables("Emails").Rows(i).Item("Email")

            ''    emailFrom = New MailAddress("ar@fieldav.com")
            ''    emailTo = New MailAddress(Email)
            ''    myMessage = New MailMessage(emailFrom, emailTo)
            ''Else
            ''    MoreEmails = ds.Tables("Emails").Rows(i).Item("Email")

            ''    myMessage.To.Add(New MailAddress(MoreEmails))
            ''End If

            If IsDBNull(ds.Tables("Emails").Rows(i).Item("Email")) Then
                i = i + 1
                Continue While
            Else
                u.SendEmail("fdt@fieldaero.com", ds.Tables("Emails").Rows(i).Item("Email"), EmailSubject, EmailBody)
            End If

            i = i + 1
        End While

        ds.Tables("Emails").Clear()
        ds.Tables("Emails").Dispose()



        'SEND EMAIL
        ''If Email <> "" Then
        ''    myMessage.Subject = EmailSubject
        ''    myMessage.Body = EmailBody
        ''    'Dim emailBCC As MailAddress = New MailAddress("jwebster@fieldaero.com")
        ''    'myMessage.Bcc.Add(emailBCC)

        ''    client = New SmtpClient(SMTPServer)
        ''    client.Credentials = Net.CredentialCache.DefaultNetworkCredentials

        ''    'client.Credentials = New NetworkCredential("user@somecompany.com", "password")

        ''    client.Send(myMessage)
        ''End If


DONOTSENDEMAIL:
        Email = ""
        MoreEmails = ""
        EmailBody = ""
        EmailSubject = ""










        'Dim EmailTo As String
        'Dim EmailFrom As String

        'emailFrom = "ar@fieldav.com"
        'emailTo = "nsantagata@fieldaero.com; jwebster@fieldaero.com"          '"bhorwitz@fieldaero.com; mhalvordson@fieldaero.com"     CHANGE TO THIS
        ''sCC(0) = Email2
        ''sBCC = "as@test.com"

        'Dim emailApp As Microsoft.Office.Interop.Outlook.Application
        'emailApp = New Microsoft.Office.Interop.Outlook.Application
        'Dim emailMsg As Microsoft.Office.Interop.Outlook.MailItem
        'emailMsg = emailApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)

        'Dim EmailDisplayName As String = "List of emails sent out today " & Today
        'Dim EmailSubject As String = "List of Invoice Emails Sent to Customers"
        ''myMessage.IsBodyHtml = True        'CHANGE THIS: uncomment it?
        ''Dim Link As String = "<a href=""http://localhost:" & partUrl & "/test.aspx?autoNum=" & autoNum & """>Click here</a>"
        'Dim Link As String = "<a href=""\\CIN-JDE-REPORTS\DataSource\ARCustomerStatements\ArchivePDFs\" & todaysDate & "\"">\\CIN-JDE-REPORTS\DataSource\ARCustomerStatements\ArchivePDFs\</a>"
        'Dim EmailBody As String = "List of emails sent out today " & vbCrLf & "<br>" & Link

        'emailMsg.Subject = EmailSubject
        ''oMsg.Body = sBody
        'emailMsg.HTMLBody = EmailBody
        'emailMsg.To = emailTo
        ''oMsg.SentOnBehalfOfName = EmailFrom
        ''oMsg.CC = sCC(0)
        ''oMsg.BCC = sBCC

        'Dim stringS As String = AttachFileName
        'Dim stringN As String = EmailDisplayName
        ''If sFileName <> "" Then
        'Dim emailBodyLen As Integer = Int(EmailBody.Length)
        'Dim emailAttachs As Microsoft.Office.Interop.Outlook.Attachments = emailMsg.Attachments
        'Dim emailAttach As Microsoft.Office.Interop.Outlook.Attachment
        'emailAttach = emailAttachs.Add(stringS, , emailBodyLen, stringN)
        ''End If

        'emailMsg.Send()
    End Function

End Class