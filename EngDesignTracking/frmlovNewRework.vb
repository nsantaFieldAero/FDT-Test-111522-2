Imports DevExpress.XtraGrid.Views.Base

Public Class frmlovNewRework
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SqlDataAdapter1.Update(DataSet181.tblNewRework)
        Search()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        u.ExecuteSQL(SqlConnection1, "Delete from tblNewRework Where RecordID = '" & Val(txtRecordID.Text) & "'")
        Search()

    End Sub

    Private Sub frmlovNewRework_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        Search()

    End Sub

    Private Sub GridView1_BeforeLeaveRow(sender As Object, e As RowAllowEventArgs) Handles GridView1.BeforeLeaveRow
        SqlDataAdapter1.Update(DataSet181.tblNewRework)
        Search()
    End Sub

    Public Function Search()
        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet181.tblNewRework.Clear()

        Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += " Order By Name Asc"

        Try
            Me.SqlDataAdapter1.Fill(DataSet181.tblNewRework)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet181.Tables("tblNewRework").Rows.Count <> 0 Then
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
End Class