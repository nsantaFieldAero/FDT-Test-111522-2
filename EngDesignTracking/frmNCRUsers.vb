Public Class frmNCRUsers
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmNCRUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection2.ConnectionString = sqlString

        daNCRUsers.Fill(DsNCRUsers1.tblUsers)

    End Sub

    'Private Sub GridControl1_Leave(sender As Object, e As EventArgs) Handles GridControl1.Leave

    '    daNCRUsers.Update(DsNCRUsers1.tblUsersNCR)

    'End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Dim NCRUserUsername As String = ""
        'Dim NCRUserEngineer As String
        'Dim NCRUserLeadEngineer As String
        'Dim NCRUserStress As String
        'Dim NCRUserLiaison As String
        'Dim NCRUserOperations As String
        'Dim NCRUserAdmin As String
        'Dim NCRUserActive As String
        'Dim FDTUserRecordID As Integer
        'Dim b As Integer = 0


        daNCRUsers.Update(DsNCRUsers1.tblUsers)

        MsgBox("Data Updated")

        'da = New SqlClient.SqlDataAdapter("Select * From tblUsers Where AddedToFDTUsersTbl Is Null And Active = 'True'", SqlConnection2)
        'da.Fill(ds, "UserToAddToFDTUsers")
        'If ds.Tables("FDTUser").Rows.Count > 0 Then

        '    While b <= ds.Tables("UserToAddToFDTUsers").Rows.Count - 1

        '        If IsDBNull(ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Username")) Then
        '            NCRUserUsername = ""
        '        Else
        '            NCRUserUsername = ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Username")
        '        End If

        '        If IsDBNull(ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Engineer")) Then
        '            NCRUserEngineer = "F"
        '        ElseIf ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Engineer") = True Then
        '            NCRUserEngineer = "T"
        '        End If

        '        If IsDBNull(ds.Tables("UserToAddToFDTUsers").Rows(b).Item("LeadEngineer")) Then
        '            NCRUserLeadEngineer = 0
        '        ElseIf ds.Tables("UserToAddToFDTUsers").Rows(b).Item("LeadEngineer") = True Then
        '            NCRUserLeadEngineer = "1"
        '        End If

        '        If IsDBNull(ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Stress")) Then
        '            NCRUserStress = "F"
        '        ElseIf ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Stress") = "True" Then
        '            NCRUserStress = "T"
        '        End If

        '        If IsDBNull(ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Liaison")) Then
        '            NCRUserLiaison = "F"
        '        ElseIf ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Liaison") = "True" Then
        '            NCRUserLiaison = "T"
        '        End If

        '        If IsDBNull(ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Operations")) Then
        '            NCRUserOperations = "F"
        '        ElseIf ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Operations") = True Then
        '            NCRUserOperations = "T"
        '        End If

        '        If IsDBNull(ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Admin")) Then
        '            NCRUserAdmin = "F"
        '        ElseIf ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Admin") = True Then
        '            NCRUserAdmin = "T"
        '        End If

        '        If IsDBNull(ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Active")) Then
        '            NCRUserActive = 0
        '        ElseIf ds.Tables("UserToAddToFDTUsers").Rows(b).Item("Active") = True Then
        '            NCRUserActive = "1"
        '        End If



        '        da = New SqlClient.SqlDataAdapter("Select Username,RecordID From tblUsers Where Username = '" & NCRUserUsername & "'", SqlConnection2)
        '        da.Fill(ds, "FDTUser")
        '        If ds.Tables("FDTUser").Rows.Count > 0 Then

        '            FDTUserRecordID = ds.Tables("FDTUser").Rows(0).Item("RecordID")

        '            u.ExecuteSQL(SqlConnection2, "UPDATE tblUser SET Engineer = '" & NCRUserUsername & "', LeadEngineer = '" & NCRUserLeadEngineer & "', Stress = '" & NCRUserStress & "', LiaisonEngineer = '" & NCRUserLiaison & "', Operations = '" & NCRUserOperations & "', Admin = '" & NCRUserAdmin & "', Active = '" & NCRUserActive & "'  Where RecordID = '" & FDTUserRecordID & "'")

        '            ds.Tables("FDTUser").Clear()
        '            ds.Tables("FDTUser").Dispose()

        '        Else
        '            u.ExecuteSQL(SqlConnection2, "Insert Into tblUsers (Username,Engineer,LeadEngineer,Stress,LiaisonEngineer,Operations,Admin,Active) Values ('" & NCRUserUsername & "', '" & NCRUserEngineer & "', '" & NCRUserLeadEngineer & "', '" & NCRUserStress & "', '" & NCRUserLiaison & "', '" & NCRUserOperations & "', '" & NCRUserAdmin & "', '" & NCRUserActive & "')")
        '        End If


        '        b = b + 1
        '    End While

        '    ds.Tables("UserToAddToFDTUsers").Clear()
        '    ds.Tables("UserToAddToFDTUsers").Dispose()
        'End If


        'u.ExecuteSQL(SqlConnection1, "UPDATE tblUsersNCR SET AddedToFDTUsersTbl = 'Yes'")

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'Delete Record Selected
        Dim UserToDelete As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Username")

        u.ExecuteSQL(SqlConnection2, "Delete From tblUsers Where Username = '" & UserToDelete & "'")


        'Clear the dataset and then refill it again with the new data(without the deleted item)
        DsNCRUsers1.Clear()
        DsNCRUsers1.Dispose()

        daNCRUsers.Fill(DsNCRUsers1.tblUsers)

        MsgBox("Record Deleted")

    End Sub

End Class