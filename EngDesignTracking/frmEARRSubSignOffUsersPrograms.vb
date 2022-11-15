Public Class frmEARRSubSignOffUsersPrograms

    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim QueryForType As String = ""

    Private Sub frmEARRSubSignOffUsersPrograms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString1

        da = New SqlClient.SqlDataAdapter("Select Distinct ProgramName From tblEARR Where EARRStatus != 'Aborted' And EARRStatus != 'Complete' And ProgramName != '' And ProgramName Is Not Null And (LiaisonManagerName = '" & PreviousUsernameSubEARR & "' Or LiaisonManagerName = '" & PreviousEmailSubEARR & "' Or LiaisonManagerNameBackup = '" & PreviousUsernameSubEARR & "' Or LiaisonManagerNameBackup = '" & PreviousEmailSubEARR & "' Or EngineeringManagerName = '" & PreviousUsernameSubEARR & "' Or EngineeringManagerName = '" & PreviousEmailSubEARR & "' Or EngineeringManagerNameBackup = '" & PreviousUsernameSubEARR & "' Or EngineeringManagerNameBackup = '" & PreviousEmailSubEARR & "' Or QCName = '" & PreviousUsernameSubEARR & "' Or QCName = '" & PreviousEmailSubEARR & "' Or QCNameBackup = '" & PreviousUsernameSubEARR & "' Or QCNameBackup = '" & PreviousEmailSubEARR & "' Or Planner1 = '" & PreviousUsernameSubEARR & "' Or Planner1 = '" & PreviousEmailSubEARR & "' Or Planner2 = '" & PreviousUsernameSubEARR & "' Or Planner2 = '" & PreviousEmailSubEARR & "')", SqlConnection1)
        da.Fill(ds, "ProgramNames")
        Dim b As Integer = 0

        If ds.Tables("ProgramNames").Rows.Count > 0 Then
            While b <= ds.Tables("ProgramNames").Rows.Count - 1
                cboPrograms.Items.Add(ds.Tables("ProgramNames").Rows(b).Item("ProgramName"))
                b = b + 1
            End While

            cboPrograms.Items.Add("All")
            ds.Tables("ProgramNames").Clear()
            ds.Tables("ProgramNames").Dispose()
        Else
            cboPrograms.Items.Add("All")
        End If


        da = New SqlClient.SqlDataAdapter("Select Distinct EARRType From tblEARR Where EARRStatus != 'Aborted' And EARRStatus != 'Complete' And ProgramName != '' And ProgramName Is Not Null And (LiaisonManagerName = '" & PreviousUsernameSubEARR & "' Or LiaisonManagerName = '" & PreviousEmailSubEARR & "' Or LiaisonManagerNameBackup = '" & PreviousUsernameSubEARR & "' Or LiaisonManagerNameBackup = '" & PreviousEmailSubEARR & "' Or EngineeringManagerName = '" & PreviousUsernameSubEARR & "' Or EngineeringManagerName = '" & PreviousEmailSubEARR & "' Or EngineeringManagerNameBackup = '" & PreviousUsernameSubEARR & "' Or EngineeringManagerNameBackup = '" & PreviousEmailSubEARR & "' Or QCName = '" & PreviousUsernameSubEARR & "' Or QCName = '" & PreviousEmailSubEARR & "' Or QCNameBackup = '" & PreviousUsernameSubEARR & "' Or QCNameBackup = '" & PreviousEmailSubEARR & "' Or Planner1 = '" & PreviousUsernameSubEARR & "' Or Planner1 = '" & PreviousEmailSubEARR & "' Or Planner2 = '" & PreviousUsernameSubEARR & "' Or Planner2 = '" & PreviousEmailSubEARR & "')", SqlConnection1)
        da.Fill(ds, "EARRType")

        If ds.Tables("EARRType").Rows.Count > 0 Then

            Dim a As Integer = 0
            While a <= ds.Tables("EARRType").Rows.Count - 1
                cboType.Items.Add(ds.Tables("EARRType").Rows(a).Item("EARRType"))
                a = a + 1
            End While

            cboType.Items.Add("All")
            ds.Tables("EARRType").Clear()
            ds.Tables("EARRType").Dispose()
        Else
            cboType.Items.Add("All")
        End If

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If cboPrograms.Text = "" Then
            MsgBox("Please choose program")
            Exit Sub
        End If

        If cboType.Text = "" Then
            MsgBox("Please choose type")
            Exit Sub
        End If


        SubbedUserProgram = cboPrograms.Text
        SubbedUserType = cboType.Text

        'If cboPrograms.Text = "All" Then
        '    SubbedUserProgram = ""
        'End If

        'If cboType.Text = "All" Then
        '    SubbedUserType = ""
        'End If




        ''If for example the program the user is assigned to is QCTEST, which does not have either type Mechanical or Electrical selected, then the program will
        ''make Type and Type2 equal to Mechanical and Electrical. Otherwise the updates below will not update all records since when a user creates a EARR a
        ''Type is always required
        'If TypeSubEARR = "" And TypeTwoSubEARR = "" Then
        '    TypeSubEARR = "Mechanical"
        '    TypeTwoSubEARR = "Electrical"
        'End If

        If SubbedUserType = "All" Then
            QueryForType = ""
        Else
            QueryForType = " And EARRType = '" & SubbedUserType & "'"
        End If

        If SubbedUserProgram = "All" Then

            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set LiaisonManagerName = '" & NewSubbedEmail & "' Where (LiaisonManagerName = '" & PreviousEmailSubEARR & "' OR LiaisonManagerName = '" & PreviousUsernameSubEARR & "') And LiaisonManagerSignOffDate = '01/01/1900' And (ProgramName = '" & ProgramSubEARR & "' Or ProgramName = '" & ProgramTwoSubEARR & "' Or ProgramName = '" & ProgramThreeSubEARR & "' Or ProgramName = '" & ProgramFourSubEARR & "')" & QueryForType & " And EARRStatus!= 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set LiaisonManagerNameBackup = '" & NewSubbedEmail & "' Where (LiaisonManagerNameBackup = '" & PreviousEmailSubEARR & "' OR LiaisonManagerNameBackup = '" & PreviousUsernameSubEARR & "') And LiaisonManagerSignOffDate = '01/01/1900' And (ProgramName = '" & ProgramSubEARR & "' Or ProgramName = '" & ProgramTwoSubEARR & "' Or ProgramName = '" & ProgramThreeSubEARR & "' Or ProgramName = '" & ProgramFourSubEARR & "')" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set EngineeringManagerName = '" & NewSubbedEmail & "' Where (EngineeringManagerName = '" & PreviousEmailSubEARR & "' OR EngineeringManagerName = '" & PreviousUsernameSubEARR & "') And EngineeringManagerSignOffDate = '01/01/1900' And (ProgramName = '" & ProgramSubEARR & "' Or ProgramName = '" & ProgramTwoSubEARR & "' Or ProgramName = '" & ProgramThreeSubEARR & "' Or ProgramName = '" & ProgramFourSubEARR & "')" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set EngineeringManagerNameBackup = '" & NewSubbedEmail & "' Where (EngineeringManagerNameBackup = '" & PreviousEmailSubEARR & "' OR EngineeringManagerNameBackup = '" & PreviousUsernameSubEARR & "') And EngineeringManagerSignOffDate = '01/01/1900' And (ProgramName = '" & ProgramSubEARR & "' Or ProgramName = '" & ProgramTwoSubEARR & "' Or ProgramName = '" & ProgramThreeSubEARR & "' Or ProgramName = '" & ProgramFourSubEARR & "')" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set QCName = '" & NewSubbedEmail & "' Where (QCName = '" & PreviousEmailSubEARR & "' OR QCName = '" & PreviousUsernameSubEARR & "') And QCSignOff = '01/01/1900' And (ProgramName = '" & ProgramSubEARR & "' Or ProgramName = '" & ProgramTwoSubEARR & "' Or ProgramName = '" & ProgramThreeSubEARR & "' Or ProgramName = '" & ProgramFourSubEARR & "')" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set QCNameBackup = '" & NewSubbedEmail & "' Where (QCNameBackup = '" & PreviousEmailSubEARR & "' OR QCNameBackup = '" & PreviousUsernameSubEARR & "') And QCSignOff = '01/01/1900' And (ProgramName = '" & ProgramSubEARR & "' Or ProgramName = '" & ProgramTwoSubEARR & "' Or ProgramName = '" & ProgramThreeSubEARR & "' Or ProgramName = '" & ProgramFourSubEARR & "')" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set Planner1 = '" & NewSubbedEmail & "' Where (Planner1 = '" & PreviousEmailSubEARR & "' OR Planner1 = '" & PreviousUsernameSubEARR & "') And PlannerSignOffDate = '01/01/1900' And (ProgramName = '" & ProgramSubEARR & "' Or ProgramName = '" & ProgramTwoSubEARR & "' Or ProgramName = '" & ProgramThreeSubEARR & "' Or ProgramName = '" & ProgramFourSubEARR & "')" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set Planner2 = '" & NewSubbedEmail & "' Where (Planner2 = '" & PreviousEmailSubEARR & "' OR Planner2 = '" & PreviousUsernameSubEARR & "') And PlannerSignOffDate = '01/01/1900' And (ProgramName = '" & ProgramSubEARR & "' Or ProgramName = '" & ProgramTwoSubEARR & "' Or ProgramName = '" & ProgramThreeSubEARR & "' Or ProgramName = '" & ProgramFourSubEARR & "')" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")

        Else
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set LiaisonManagerName = '" & NewSubbedEmail & "' Where (LiaisonManagerName = '" & PreviousEmailSubEARR & "' OR LiaisonManagerName = '" & PreviousUsernameSubEARR & "') And LiaisonManagerSignOffDate = '01/01/1900' And ProgramName = '" & SubbedUserProgram & "'" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set LiaisonManagerNameBackup = '" & NewSubbedEmail & "' Where (LiaisonManagerNameBackup = '" & PreviousEmailSubEARR & "' OR LiaisonManagerNameBackup = '" & PreviousUsernameSubEARR & "') And LiaisonManagerSignOffDate = '01/01/1900' And ProgramName = '" & SubbedUserProgram & "'" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set EngineeringManagerName = '" & NewSubbedEmail & "' Where (EngineeringManagerName = '" & PreviousEmailSubEARR & "' OR EngineeringManagerName = '" & PreviousUsernameSubEARR & "') And EngineeringManagerSignOffDate = '01/01/1900' And ProgramName = '" & SubbedUserProgram & "'" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set EngineeringManagerNameBackup = '" & NewSubbedEmail & "' Where (EngineeringManagerNameBackup = '" & PreviousEmailSubEARR & "' OR EngineeringManagerNameBackup = '" & PreviousUsernameSubEARR & "') And EngineeringManagerSignOffDate = '01/01/1900' And ProgramName = '" & SubbedUserProgram & "'" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set QCName = '" & NewSubbedEmail & "' Where (QCName = '" & PreviousEmailSubEARR & "' OR QCName = '" & PreviousUsernameSubEARR & "') And QCSignOff = '01/01/1900' And ProgramName = '" & SubbedUserProgram & "'" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set QCNameBackup = '" & NewSubbedEmail & "' Where (QCNameBackup = '" & PreviousEmailSubEARR & "' OR QCNameBackup = '" & PreviousUsernameSubEARR & "') And QCSignOff = '01/01/1900' And ProgramName = '" & SubbedUserProgram & "'" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set Planner1 = '" & NewSubbedEmail & "' Where (Planner1 = '" & PreviousEmailSubEARR & "' OR Planner1 = '" & PreviousUsernameSubEARR & "') And PlannerSignOffDate = '01/01/1900' And ProgramName = '" & SubbedUserProgram & "'" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")
            u.ExecuteSQL(SqlConnection1, "Update tblEARR Set Planner2 = '" & NewSubbedEmail & "' Where (Planner2 = '" & PreviousEmailSubEARR & "' OR Planner2 = '" & PreviousUsernameSubEARR & "') And PlannerSignOffDate = '01/01/1900' And ProgramName = '" & SubbedUserProgram & "'" & QueryForType & " And EARRStatus != 'Aborted' And EARRStatus != 'Complete'")

        End If


        'PreviousEmailSubEARR = NewSubbedEmail
        'PreviousUsernameSubEARR = cboUsername.Text
        SubbedUserProgram = ""
        SubbedUserType = ""
        Me.Close()

        Dim frmEARRRUsersSignOff As New frmEARRUsersSignOff
        frmEARRUsersSignOff.Show()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class