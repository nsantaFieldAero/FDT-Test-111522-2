Public Class frmCertGrid
    Private Sub frmCertGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        SearchUMApproval()
        GridView1.BeginInit()

        GridView1.SetAutoFilterValue(colRequiredToApprove, 1, True)

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExportGrid_Click(sender As Object, e As EventArgs) Handles btnExportGrid.Click
        GridControl1.ExportToXlsx("C:\Temp\UMApproval.xlsx")
        MsgBox("Grid has been exported to c:\temp\UMApproval.xlsx.")
        'Open the excel file.
    End Sub

    Public Function SearchUMApproval()
        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet291.vwDrawingsCert.Clear()

        'Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String

        If cboView.Text = "In Design" Then
            Me.SqlDataAdapter2.SelectCommand.CommandText = "Select * from vwDrawingsCert"



            SqlString = SqlString + " Where Status Not In ('GATE 6: Complete', 'GATE 9: Complete')"


        ElseIf Me.cboView.Text = "In Design and Completed" Then
            Me.SqlDataAdapter2.SelectCommand.CommandText = "Select * from vwDrawingsCert"

            'SqlString = SqlString + " Where RecordID = RecordID"


        ElseIf Me.cboView.Text = "Current Revision" Then


            Me.SqlDataAdapter2.SelectCommand.CommandText = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber, UMName ORDER BY Seq DESC) AS row_num FROM vwDrawingsCert) AS derived WHERE row_num = 1"



        End If


        cmdSave = Me.SqlDataAdapter2.SelectCommand.CommandText


        Try
            Me.SqlDataAdapter2.Fill(DataSet291.vwDrawingsCert)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter2.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime


    End Function

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        SearchUMApproval()
    End Sub
End Class