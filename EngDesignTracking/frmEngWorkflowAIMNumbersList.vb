Public Class frmEngWorkflowAIMNumbersList
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmEngWorkflowAIMNumbersList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadGridDataAIMNumbers()

        SqlConnection1.ConnectionString = sqlString

        'colLocation.BestFit()
        'colDwgRequestBy.BestFit()
        'colDwgRequestDate.BestFit()
        'colActualFinishDate.BestFit()
        'colADCN.BestFit()
        'colDCN.BestFit()
        'colReleaser.BestFit()
        'colStatus.BestFit()
        'colProgram.BestFit()

        'colDrawingNumber.BestFit()
        'colAIM.BestFit()
        GridView1.BestFitColumns()
        GridView1.RefreshData()
    End Sub

    Private Sub btnExportToXLS_Click(sender As Object, e As EventArgs) Handles btnExportToXLS.Click

        'GET SEQUENCE NUMBER TO MAKE FILENAME TO SAVE UNIQUE
        Dim SeqNum As Integer
        Dim TodaysDate As String = DateTime.Now.ToString("MMddyyyy")

        da = New SqlClient.SqlDataAdapter("Select TOP 1 * From tblIncreaseFileNameByOne Where Date = '" & TodaysDate & "' Order by RecordID desc", SqlConnection1)    'CHANGE DATABASE USED
        da.Fill(ds, "GetSeq")
        If ds.Tables("GetSeq").Rows.Count > 0 Then
            SeqNum = ds.Tables("GetSeq").Rows(0).Item("Seq")
        Else
            SeqNum = 1
        End If


        'Dim PathToSaveExcel As String = "ExportedAIM_" & Now & ".xlsx"
        GridControl1.ExportToXlsx("C:\Temp\ExportedAIM_" & TodaysDate & "_" & SeqNum & ".xlsx")
        MsgBox("Grid has been exported to c:\temp\")


        'ENTER NEXT SEQUENCE NUMBER THAT WILL BE USED FOR NEXT FILE THAT WILL BE SAVED
        SqlConnection1.ConnectionString = sqlString
        SeqNum += 1
        u.ExecuteSQL(SqlConnection1, "Insert into tblIncreaseFileNameByOne (Seq, Date) Values (" & SeqNum & ", '" & TodaysDate & "')")


        ds.Tables("GetSeq").Clear()
        ds.Tables("GetSeq").Dispose()
        SeqNum = 0
    End Sub

    Private Sub btnAIMExternalUse_Click(sender As Object, e As EventArgs) Handles btnAIMExternalUse.Click

        Dim lastAimNumber As String = ""
        Dim IncreaseAIMByOne As Integer = 0
        Dim AIMIncrease As String = ""

        'Get AIM number to assign to DCN
        da = New SqlClient.SqlDataAdapter("Select TOP 1 * From tblAIMNumbers Where IncreaseByOne Is Not Null order by AIM desc", SqlConnection1)    'CHANGE DATABASE USED
        da.Fill(ds, "GetLastAimToIncreaseByOne")

        If ds.Tables("GetLastAimToIncreaseByOne").Rows.Count > 0 Then
            'lastAimNumber = ds.Tables("GetLastAimToIncreaseByOne").Rows(0).Item("AIM")   'Used in the U.ExecuteSQL that inserts a new revision(in the Add New Document Revision)
            'IncreaseAIMByOne = Val(ds.Tables("GetLastAimToIncreaseByOne").Rows(0).Item("IncreaseByOne"))
            IncreaseAIMByOne = Val(ds.Tables("GetLastAimToIncreaseByOne").Rows(0).Item("IncreaseByOne")) + 1
            'AIMIncrease = ds.Tables("GetLastAimToIncreaseByOne").Rows(0).Item("IncreaseByOne")
            'u.ExecuteSQL(SqlConnection1, "Insert into tblAIMNumbers (IncreaseByOne) Values (" & IncreaseAIMByOne & ")")
        Else
            'lastAimNumber = "10001"
            IncreaseAIMByOne = 0
            'AIMIncrease = "0"
            'u.ExecuteSQL(SqlConnection1, "Insert into tblAIMNumbers (IncreaseByOne) Values (" & IncreaseAIMByOne & ")")
        End If
        ds.Tables("GetLastAimToIncreaseByOne").Clear()
        ds.Tables("GetLastAimToIncreaseByOne").Dispose()



        'Code to assign an AIM number externally:  insert an AIM number first and then select it
        SqlConnection1.ConnectionString = sqlString
        u.ExecuteSQL(SqlConnection1, "INSERT into tblAIMNumbers (DrawingNumber, IncreaseByOne) Values ('Assigned Externally', '" & IncreaseAIMByOne & "')")

        da = New SqlClient.SqlDataAdapter("Select Top 1 AIM from tblAIMNumbers Order By AIM Desc", SqlConnection1)
        da.Fill(ds, "GetNextAIM")
        Dim AIMAssignedExternally As String = ds.Tables("GetNextAIM").Rows(0).Item("AIM")
        MsgBox("The AIM number assigned to you to use externally is: " & AIMAssignedExternally)
        ds.Tables("GetNextAIM").Clear()
        ds.Tables("GetNextAIM").Dispose()


        u.ExecuteSQL(SqlConnection1, "INSERT into tblDrawings (AIM, DocumentType, DrawingNumber, DrawingTitle) Values ('" & AIMAssignedExternally & "', 'Assigned Externally', 'Assigned Externally', 'Assigned Externally')")


        ds.Tables("AIMNumbers").Clear()
        ds.Tables("AIMNumbers").Dispose()
        LoadGridDataAIMNumbers()

    End Sub

    Public Function LoadGridDataAIMNumbers()

        'frmEngWorkflow.SqlConnection1.ConnectionString = sqlString


        'da = New SqlClient.SqlDataAdapter("SELECT Program,DrawingNumber,DrawingTitle,Location,ADCN,DCN,DwgReqDate,DwgRequestBy,Releaser,Status,ActualFinishDate,Notes,RecordID FROM tblDrawings Where ADCN != '' And ADCN Is Not Null And ADCN != '0' And (DCN = '' Or DCN is Null) UNION SELECT Program,DrawingNumber,DrawingTitle,Location,ADCN,DCN,DwgReqDate,DwgRequestBy,Releaser,Status,ActualFinishDate,Notes,RecordID FROM tblDrawings Where DCN != '' And DCN Is Not Null And DCN != '0' Order By RecordID Desc", SqlConnection1)
        '',ReleaserCompelte,DocumentType,Type,DwgRequestDate,DrawingType,DwgRevision,WONumber,DRNADCN,DRNADCNStatus,DRNADCNIncorporatedBy,IncorporatedRev
        da = New SqlClient.SqlDataAdapter("SELECT AIM,Program,DrawingNumber,DrawingTitle,Location,ADCN,DCN,DocumentType,DwgRevision,DwgRequestBy,DwgRequestDate,Releaser,Status,ActualFinishDate,Notes,RecordID FROM tblDrawings Where AIM != '' And AIM Is Not Null And AIM != '0' Order By AIM", SqlConnection1)
        da.Fill(ds, "AIMNumbers")
        Me.bsAimNums.DataSource = ds.Tables("AIMNumbers")
        GridControl1.DataSource = Me.bsAimNums

        'ds.Tables("AIMNumbers").Clear()
        'ds.Tables("AIMNumbers").Dispose()

    End Function

    Private Sub btnDeleteAIM_Click(sender As Object, e As EventArgs) Handles btnDeleteAIM.Click

        'Set text of ADCN or DCN field for record with AIM they typed in equal to "DELETED AIM Number"
        da = New SqlClient.SqlDataAdapter("Select * from tblDrawings Where AIM = '" & txtDeleteAIM.Text & "'", SqlConnection1)
        da.Fill(ds, "CheckIfThereAreMoreThanOneAIM")

        If ds.Tables("CheckIfThereAreMoreThanOneAIM").Rows.Count = 0 Then
            MsgBox("There are no AIM numbers with that number")
            ds.Tables("CheckIfThereAreMoreThanOneAIM").Clear()
            ds.Tables("CheckIfThereAreMoreThanOneAIM").Dispose()
            Exit Sub

        ElseIf ds.Tables("CheckIfThereAreMoreThanOneAIM").Rows.Count = 1 Then
            If MsgBox("Are you sure you want to cancel AIM " & txtDeleteAIM.Text & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DCN = '', ADCN = '', AIM = '" & txtDeleteAIM.Text & " DELETED AIM Number' Where AIM = '" & txtDeleteAIM.Text & "'")
                MsgBox("AIM " & txtDeleteAIM.Text & " was canceled.")
                txtDeleteAIM.Text = ""
            Else
                Exit Sub
            End If

        ElseIf ds.Tables("CheckIfThereAreMoreThanOneAIM").Rows.Count > 1 Then
            MsgBox("There is more than 1 AIM with that number")
            ds.Tables("CheckIfThereAreMoreThanOneAIM").Clear()
            ds.Tables("CheckIfThereAreMoreThanOneAIM").Dispose()
            Exit Sub
        End If


        ds.Tables("AIMNumbers").Clear()
        ds.Tables("AIMNumbers").Dispose()
        LoadGridDataAIMNumbers()
    End Sub
End Class