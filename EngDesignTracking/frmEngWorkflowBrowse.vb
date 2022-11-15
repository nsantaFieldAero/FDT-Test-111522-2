Public Class frmEngWorkflowBrowse
    Public Function Search()

        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet221.tblDrawings.Clear()

        Me.txtDocNumber.DataBindings.Clear()

        Dim cmdSave As String
        'SqlString = " Where RecordID = RecordID"
        SqlString = "Select DrawingNumber,DrawingTitle,SystemDescription,DrawingType,Program,RecordID From (SELECT DrawingNumber,DrawingTitle,SystemDescription,DrawingType,Program,RecordID,Seq,ROW_NUMBER() OVER (PARTITION BY DrawingNumber ORDER BY Seq Desc, RecordID Desc) AS RowNumber FROM vwDrawingsRev Where Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' And RecordID = RecordID) A Where RowNumber = 1 Order By DrawingNumber, Seq Desc"


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        'Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString
        Me.SqlDataAdapter1.SelectCommand.CommandText() = SqlString

        Try
            Me.SqlDataAdapter1.Fill(Me.DataSet221.tblDrawings)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.txtDocNumber.DataBindings.Add("Text",
            Me.BindingSource1, "DrawingNumber")

    End Function

    Private Sub frmEngWorkflowBrowse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString
        Search()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        DocBrowse = Me.txtDocNumber.Text
        TitleBrowseAssembly = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DrawingTitle")
        RecordIDBrowse = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecordID")

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class