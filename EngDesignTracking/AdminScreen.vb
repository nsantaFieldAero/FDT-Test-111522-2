Public Class AdminScreen
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub AdminScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString

        Me.UsersDataAdapter.Fill(UsersDataset.tblUsers)

    End Sub


    Private Sub GridControl1_Leave(sender As Object, e As EventArgs) Handles GridControl1.Leave
        UsersDataAdapter.Update(Me.UsersDataset.tblUsers)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        UsersDataAdapter.Update(Me.UsersDataset.tblUsers)

        u.ExecuteSQL(SqlConnection1, "Update tblUsers Set QAManager = '' Where QAManager Is Null")
        u.ExecuteSQL(SqlConnection1, "Update tblUsers Set MRB = '' Where MRB Is Null")
        u.ExecuteSQL(SqlConnection1, "Update tblUsers Set ProductionManager = '' Where ProductionManager Is Null")
        u.ExecuteSQL(SqlConnection1, "Update tblUsers Set ProgramManager = '' Where ProgramManager Is Null")
        u.ExecuteSQL(SqlConnection1, "Update tblUsers Set DAO = '' Where DAO Is Null")
        u.ExecuteSQL(SqlConnection1, "Update tblUsers Set Design = '' Where Design Is Null")
        u.ExecuteSQL(SqlConnection1, "Update tblUsers Set QC = '' Where QC Is Null")
        u.ExecuteSQL(SqlConnection1, "Update tblUsers Set NewNCR = '' Where NewNCR Is Null")
        u.ExecuteSQL(SqlConnection1, "Update tblUsers Set CloseNCR = '' Where CloseNCR Is Null")
        u.ExecuteSQL(SqlConnection1, "Update tblUsers Set SuperUser = '' Where SuperUser Is Null")

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.UsersDataAdapter.Fill(UsersDataset.tblUsers)
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