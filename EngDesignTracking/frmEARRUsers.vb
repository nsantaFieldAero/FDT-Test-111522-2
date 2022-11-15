Public Class frmEARRUsers
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmEARRUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        daEARRUsers.Fill(DsEARRUsers1.tblUsers)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        daEARRUsers.Update(DsEARRUsers1.tblUsers)

        MsgBox("Data Updated")

    End Sub
End Class