Public Class AdminScreen
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub AdminScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.UsersDataAdapter.Fill(UsersDataset.tblUsers)

    End Sub

    Private Sub GridControl1_Leave(sender As Object, e As EventArgs) Handles GridControl1.LostFocus

        UsersDataAdapter.Update(Me.UsersDataset.tblUsers)

    End Sub


    'Private Sub DeleteSelectedRows(ByVal View As DevExpress.XtraGrid.Views.Grid.GridView)
    '    Dim Row As DataRow
    '    Dim Rows() As DataRow
    '    Dim I As Integer
    '    ReDim Rows(View.SelectedRowsCount - 1)
    '    For I = 0 To View.SelectedRowsCount - 1
    '        Rows(I) = View.GetDataRow(View.GetSelectedRows(I))
    '    Next
    '    View.BeginSort()
    '    Try
    '        For Each Row In Rows
    '            Row.Delete()
    '        Next
    '    Finally
    '        View.EndSort()
    '    End Try
    'End Sub

End Class