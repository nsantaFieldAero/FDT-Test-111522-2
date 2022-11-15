Imports DevExpress.XtraGrid.Views.Base

Public Class frmEngWorkflowProductGroup
    Private Sub frmEngWorkflowProductGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        Search()
    End Sub

    Public Function Search()

        Dim SqlString As String

        DsProductGroup1.tblProductGroup.Clear()

        Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter1.Fill(DsProductGroup1.tblProductGroup)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave


        If DsProductGroup1.Tables("tblProductGroup").Rows.Count <> 0 Then
            Search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text", bsProductGroup, "RecordID")

        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.SqlDataAdapter1.Update(DsProductGroup1.tblProductGroup)
        Search()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        u.ExecuteSQL(SqlConnection1, "Delete from tblProductGroup Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
        Search()
    End Sub

    Private Sub GridView1_BeforeLeaveRow(sender As Object, e As RowAllowEventArgs) Handles GridView1.BeforeLeaveRow
        Me.SqlDataAdapter1.Update(DsProductGroup1.tblProductGroup)
        Search()
    End Sub
End Class