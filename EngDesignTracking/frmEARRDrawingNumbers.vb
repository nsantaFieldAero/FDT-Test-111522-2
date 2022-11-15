Public Class frmEARRDrawingNumbers
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmEARRDrawingNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString
        Search()
    End Sub

    Public Function Search()

        Dim SqlString As String

        Me.DsDrawNums1.tblDrawings.Clear()
        Me.txtDocNumber.DataBindings.Clear()

        Dim cmdSave As String
        SqlString = "Select DrawingNumber,DrawingTitle,DwgRevision,SystemDescription,DrawingType,Program,RecordID From (SELECT DrawingNumber,DrawingTitle,DwgRevision,SystemDescription,DrawingType,Program,RecordID,Seq,ROW_NUMBER() OVER (PARTITION BY DrawingNumber ORDER BY Seq Desc, RecordID Desc) AS RowNumber FROM vwDrawingsRev Where Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' And RecordID = RecordID) A Where RowNumber = 1 Order By DrawingNumber, Seq Desc"

        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        'Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString
        Me.SqlDataAdapter1.SelectCommand.CommandText() = SqlString

        Try
            Me.SqlDataAdapter1.Fill(Me.DsDrawNums1.tblDrawings)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave


        Me.txtDocNumber.DataBindings.Add("Text", Me.bsDrawNums, "DrawingNumber")

    End Function

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        'RecordIDBrowse = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecordID")
        DocBrowseDrawNum = Me.txtDocNumber.Text

        'Get the revision of the last document at gate 6
        da = New SqlClient.SqlDataAdapter("Select DwgRevision, DrawingTitle From vwDrawingsRev where DrawingNumber = '" & DocBrowseDrawNum & "' And Status = 'GATE 6: Complete' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq Desc, RecordID Desc", SqlConnection1)
        da.Fill(ds, "RevOfDrawNum")
        If ds.Tables("RevOfDrawNum").Rows.Count > 0 Then
            RevBrowseDrawNum = ds.Tables("RevOfDrawNum").Rows(0).Item("DwgRevision")
            TitleBrowseDrawNum = ds.Tables("RevOfDrawNum").Rows(0).Item("DrawingTitle")

            ds.Tables("RevOfDrawNum").Clear()
            ds.Tables("RevOfDrawNum").Dispose()
        Else
            'Allow to select the document number when the "Add Existing Doc" on the "Liaison Info" tab(EARRApproval) is clicked, even if the latest record is not at gate 6
            If RunIfNotGateSix = "Yes" Then
                'Nothing
            Else
                MsgBox("The document number selected does not have a doc number at Gate 6 from which to select the revision letter")
                DocBrowseDrawNum = ""
                Exit Sub
            End If
        End If

        RunIfNotGateSix = ""
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class