Public Class frmLovType
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.SqlDataAdapter1.Update(DataSet141.tblType)
        Search()
    End Sub

    Private Sub frmLovType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        Search()


    End Sub

    Public Function Search()

        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet141.tblType.Clear()

        Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += " Order By Type Asc"

        Try
            Me.SqlDataAdapter1.Fill(DataSet141.tblType)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet141.Tables("tblType").Rows.Count <> 0 Then
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        u.ExecuteSQL(SqlConnection1, "Delete from tblType Where RecordID = '" & Val(txtRecordID.Text) & "'")
        Search()

    End Sub
End Class