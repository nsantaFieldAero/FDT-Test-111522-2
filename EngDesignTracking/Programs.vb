Public Class Programs
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Private Sub Programs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SqlDataAdapter1.Fill(DsPrograms.tblProgram)

    End Sub

    Private Sub GridControl1_Leave(sender As Object, e As EventArgs) Handles GridControl1.LostFocus

        SqlDataAdapter1.Update(Me.DsPrograms.tblProgram)

    End Sub

End Class