Public Class frmNCRLovManufacturers
    Private Sub frmNCRLovManufacturers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        daManufacturer.Fill(DsNCRManufacturers1.tblNCRManufacturers)

    End Sub

    Private Sub GridControl1_Leave(sender As Object, e As EventArgs) Handles GridControl1.Leave

        daManufacturer.Update(DsNCRManufacturers1.tblNCRManufacturers)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        daManufacturer.Update(DsNCRManufacturers1.tblNCRManufacturers)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'Delete Record Selected
        Dim ManufacturerToDelete As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Manufacturer")

        u.ExecuteSQL(SqlConnection1, "Delete From tblNCRManufacturers Where Manufacturer = '" & ManufacturerToDelete & "'")


        'Clear the dataset and then refill it again with the new data(without the deleted item)
        DsNCRManufacturers1.Clear()
        DsNCRManufacturers1.Dispose()

        daManufacturer.Fill(DsNCRManufacturers1.tblNCRManufacturers)

    End Sub
End Class