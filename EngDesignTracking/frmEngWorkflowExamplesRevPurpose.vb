Public Class frmEngWorkflowExamplesRevPurpose
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.SqlDataAdapter1.Update(DsExamplesRevPurpose1.tblExamplesRevPurpose)
        Search()
    End Sub

    Private Sub frmEngWorkflowExamplesRevPurpose_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString

        If isAdmin = "T" Then
            btnSave.Enabled = True
            btnDelete.Enabled = True
        Else
            btnSave.Enabled = False
            btnDelete.Enabled = False
        End If

        Search()
    End Sub

    Public Function Search()

        Dim SqlString As String

        Me.DsExamplesRevPurpose1.tblExamplesRevPurpose.Clear()

        Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter1.Fill(DsExamplesRevPurpose1.tblExamplesRevPurpose)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave


        If DsExamplesRevPurpose1.Tables("tblExamplesRevPurpose").Rows.Count <> 0 Then
            Search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text", Me.bsExamplesRevPurpose, "RecordID")

        End If
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        u.ExecuteSQL(SqlConnection1, "Delete From tblExamplesRevPurpose Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
        Search()
    End Sub
End Class