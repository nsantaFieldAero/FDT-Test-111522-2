Imports DevExpress.XtraGrid.Views.Base

Public Class frmlovAssignmentNames
    Private Sub frmlovAssignmentNames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        Search()

    End Sub

    Public Function Search()
        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet151.tblNameAssignment.Clear()

        Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += " Order By Name Asc"

        Try
            Me.SqlDataAdapter1.Fill(DataSet151.tblNameAssignment)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet151.Tables("tblNameAssignment").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            Search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text",
            Me.BindingSource1, "RecordID")

        Else
            'MsgBox("No Records Exist")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.SqlDataAdapter1.Update(DataSet151.tblNameAssignment)
        Search()
        MsgBox("Saved")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        u.ExecuteSQL(SqlConnection1, "Delete from tblNameAssignment Where RecordID = '" & Val(txtRecordID.Text) & "'")
        Search()
        MsgBox("Record Deleted")
    End Sub

    Private Sub GridView1_BeforeLeaveRow(sender As Object, e As RowAllowEventArgs) Handles GridView1.BeforeLeaveRow
        Me.SqlDataAdapter1.Update(DataSet151.tblNameAssignment)
        Search()
    End Sub
End Class