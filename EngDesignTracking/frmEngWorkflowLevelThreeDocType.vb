Imports DevExpress.XtraGrid.Views.Base

Public Class frmEngWorkflowLevelThreeDocType
    Private Sub frmEngWorkflowLevelThreeDocType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        Search()
    End Sub

    Public Function Search()

        Dim SqlString As String

        DsLevelThree1.tblDocTypePrefixLevelThree.Clear()

        Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter1.Fill(DsLevelThree1.tblDocTypePrefixLevelThree)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave


        If DsLevelThree1.Tables("tblDocTypePrefixLevelThree").Rows.Count <> 0 Then
            Search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text",
            bsLevelThree, "RecordID")

        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.SqlDataAdapter1.Update(DsLevelThree1.tblDocTypePrefixLevelThree)
        Search()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        u.ExecuteSQL(SqlConnection1, "Delete from tblDocTypePrefixLevelThree Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
        Search()
    End Sub

    Private Sub GridView1_BeforeLeaveRow(sender As Object, e As RowAllowEventArgs) Handles GridView1.BeforeLeaveRow
        Me.SqlDataAdapter1.Update(DsLevelThree1.tblDocTypePrefixLevelThree)
        Search()
    End Sub
End Class