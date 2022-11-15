Public Class frmEARRSubSignOffUsers

    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmEARRSubSignOffUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString1

        Label1.Text = "Enter the email address and username of the user you want to sub " & PreviousUsernameSubEARR & " with."
        lblEmail.Visible = False
        txtEmail.Visible = False


        da = New SqlClient.SqlDataAdapter("Select * From tblUsers Order By Username", SqlConnection1)
        da.Fill(ds, "Usernames")

        Dim i As Integer = 0
        While i <= ds.Tables("Usernames").Rows.Count - 1
            cboUsername.Items.Add(ds.Tables("Usernames").Rows(i).Item("Username"))
            i = i + 1
        End While

        ds.Tables("Usernames").Clear()
        ds.Tables("Usernames").Dispose()

    End Sub

    Private Sub cboUsername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUsername.SelectedIndexChanged

        lblEmail.Visible = True
        txtEmail.Visible = True

        da = New SqlClient.SqlDataAdapter("Select Email From tblUsers Where Username = '" & cboUsername.Text & "'", SqlConnection1)
        da.Fill(ds, "Email")

        If ds.Tables("Email").Rows.Count > 0 Then
            txtEmail.Text = ds.Tables("Email").Rows(0).Item("Email")

            ds.Tables("Email").Clear()
            ds.Tables("Email").Dispose()
        End If



        NewSubbedEmail = txtEmail.Text


        If cboUsername.Text = "" Then
            MsgBox("Please select username")
            Exit Sub
        Else
            u.ExecuteSQL(SqlConnection1, "Update tblUsersCreateEARR Set Username = '" & cboUsername.Text & "', Email = '" & txtEmail.Text & "' Where RecordID = '" & RecordIDSubEARR & "'")
        End If



        Dim result As DialogResult = MessageBox.Show("Would you like to update the main EARR table?", "Confirm Update", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then

            Me.Close()
            Dim frmEARRSubSignOffUsersPrograms As New frmEARRSubSignOffUsersPrograms
            frmEARRSubSignOffUsersPrograms.Show()

        Else

            Me.Close()
            Dim frmEARRRUsersSignOff As New frmEARRUsersSignOff
            frmEARRUsersSignOff.Show()

        End If

    End Sub

End Class