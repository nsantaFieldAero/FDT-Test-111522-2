Imports DevExpress.XtraGrid.Views.Base

Public Class Aircrafts
    Private Sub Aircrafts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString
        Search()


        GridView1.Columns("RecordID").Visible = False
        'GridView1.Columns("ProgramName").Visible = False
        GridView1.Columns("ProgramNumber").Visible = False
        GridView1.Columns("ProjectName").Visible = False
        GridView1.Columns("ProjectNumber").Visible = False
        GridView1.Columns("Location").Visible = False
    End Sub

    Public Function Search()

        Dim SqlString As String

        DsAircrafts1.tblAircraftsLOVMaint.Clear()

        Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter1.Fill(DsAircrafts1.tblAircraftsLOVMaint)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave


        If DsAircrafts1.Tables("tblAircraftsLOVMaint").Rows.Count <> 0 Then
            Search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text", bsAircrafts, "RecordID")

        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.SqlDataAdapter1.Update(DsAircrafts1.tblAircraftsLOVMaint)
        Search()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        u.ExecuteSQL(SqlConnection1, "Delete from tblAircraftsLOVMaint Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
        Search()
    End Sub

    Private Sub GridView1_BeforeLeaveRow(sender As Object, e As RowAllowEventArgs) Handles GridView1.BeforeLeaveRow
        Me.SqlDataAdapter1.Update(DsAircrafts1.tblAircraftsLOVMaint)
        Search()
    End Sub
End Class