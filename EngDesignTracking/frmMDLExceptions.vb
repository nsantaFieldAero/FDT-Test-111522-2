Public Class frmMDLExceptions
    Private Sub frmMDLExceptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        Search()

    End Sub
    Public Function Search()

        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet391.vwMDLExceptions.Clear()

        'Me.txtRecordID.DataBindings.Clear()
        Me.txtMDLNumber.DataBindings.Clear()
        Me.txtMDLRevision.DataBindings.Clear()

        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        'Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString
        Me.SqlDataAdapter1.SelectCommand.CommandText = "Select * from vwMDLExceptions Where MDLRecordID = '" & Val(OpenMDL) & "' and Status1 <> 'GATE 6: Complete' and ShowPreviousRev = 'False' and DeferToNextMDL = 'False' and Cancelled = 'False'"
        Try
            Me.SqlDataAdapter1.Fill(Me.DataSet391.vwMDLExceptions)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet391.Tables("vwMDLExceptions").Rows.Count <> 0 Then
            MsgBox("Exceptions Exist.  They must be cleared in order to release MDL.")
            'Me.btnSavePerson.Enabled = True
            'Search = True
            Me.txtMDLNumber.DataBindings.Add("Text",
        Me.BindingSource1, "MDLNumber")
            'Create DataBindings            
            Me.txtMDLRevision.DataBindings.Add("Text",
            Me.BindingSource1, "Revision")

        Else
            MsgBox("No Exceptions Reported.")
            Dim result As DialogResult = MessageBox.Show("MDL may be moved to a locked status.  Would you like to do this now?",
             "Title",
             MessageBoxButtons.YesNo)

            If (result = DialogResult.Yes) Then

                u.ExecuteSQL(SqlConnection1, "Update tblLiveMDL set Status = 'LOCKED' where RecordID = '" & Val(OpenMDL) & "'")
                MsgBox("MDL has been released.")


                Dim crReport As New crMDLPrint

                crReport.SetDatabaseLogon("sa1", "The water is wet!")

                Dim str As String

                str = "SELECT * from tblLiveMDL, tblLiveMDLDetail where tblLiveMDL.RecordID = '" & Val(OpenMDL) & "' and tblLIveMDL.RecordID = tblLIveMDLDetail.MDLRecordID And Cancelled = 'False' and DeferToNextMDL = 'False'"

                GlobalSqlString = str

                Dim frm As New frmViewReport
                frm.ReportType = "MDLGridView"
                frm.Report3 = crReport
                frm.Show()
            End If
        End If


    End Function

    Private Sub btnExportGrid_Click(sender As Object, e As EventArgs) Handles btnExportGrid.Click
        GridControl1.ExportToXlsx("C:\Temp\MDLExceptions.xlsx")
        MsgBox("Grid has been exported to c:\temp\MDLExceptions.xlsx.")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class