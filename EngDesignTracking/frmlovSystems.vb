Imports DevExpress.XtraGrid.Views.Base

Public Class frmlovSystems

    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmlovSystems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString

        Search()
    End Sub

    Public Function Search()

        Dim SqlString As String
        Dim cmdSave As String

        Me.DsSystemsList1.tblSystems.Clear()
        Me.txtRecordID.DataBindings.Clear()


        cmdSave = Me.daSystemsList.SelectCommand.CommandText
        Me.daSystemsList.SelectCommand.CommandText() += " Order By System"

        Try
            Me.daSystemsList.Fill(DsSystemsList1.tblSystems)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.daSystemsList.SelectCommand.CommandText = cmdSave


        If Me.DsSystemsList1.Tables("tblSystems").Rows.Count <> 0 Then

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text", Me.bsSystemsList, "RecordID")

        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.daSystemsList.Update(DsSystemsList1.tblSystems)
        Search()
        MsgBox("Record Saved")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        u.ExecuteSQL(SqlConnection1, "Delete From tblSystems Where RecordID = '" & Val(txtRecordID.Text) & "'")
        Search()
        MsgBox("Record Deleted")
    End Sub

    Private Sub GridView1_BeforeLeaveRow(sender As Object, e As RowAllowEventArgs) Handles GridView1.BeforeLeaveRow
        Me.daSystemsList.Update(DsSystemsList1.tblSystems)
        Search()
    End Sub
End Class