Public Class frmCertificationStaff
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.SqlDataAdapter1.Update(DataSet81.tblCertificationStaff)
        Search()
    End Sub
    Public Function Search()

        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet81.tblCertificationStaff.Clear()

        'Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter1.Fill(DataSet81.tblCertificationStaff)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet81.Tables("tblCertificationStaff").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            Search = True

            'Create DataBindings
            'Me.txtRecordID.DataBindings.Add("Text",
            'Me.BindingSource2, "RecordID")

        Else
            MsgBox("No Records Exist")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If

    End Function

    Private Sub frmCertificationStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        Search()

    End Sub
End Class