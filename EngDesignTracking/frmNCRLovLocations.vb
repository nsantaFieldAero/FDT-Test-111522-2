Public Class frmNCRLovLocations
    Private Sub frmNCRLovLocations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        daLocations.Fill(DsNCRLocations1.tblNCRLocations)

    End Sub

    Private Sub GridControl1_Leave(sender As Object, e As EventArgs) Handles GridControl1.Leave

        daLocations.Update(DsNCRLocations1.tblNCRLocations)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        daLocations.Update(DsNCRLocations1.tblNCRLocations)

    End Sub

    'Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

    '    daLocations.Fill(DsNCRLocations1.tblNCRLocations)

    'End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'Delete Record Selected
        Dim LocationToDelete As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Location")

        u.ExecuteSQL(SqlConnection1, "Delete From tblNCRLocations Where Location = '" & LocationToDelete & "'")


        'Clear the dataset and then refill it again with the new data(without the deleted item)
        DsNCRLocations1.Clear()
        DsNCRLocations1.Dispose()

        daLocations.Fill(DsNCRLocations1.tblNCRLocations)

    End Sub
End Class