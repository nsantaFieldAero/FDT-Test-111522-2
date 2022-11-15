Imports System.ComponentModel
Imports System.IO
Public Class frmDrawingCertificationData
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Private Sub frmDrawingCertificationData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RecordToEdit
        SqlConnection1.ConnectionString = sqlString
        da = New SqlClient.SqlDataAdapter("Select DrawingNumber, DrawingTitle, Status, DwgRevision, Program From tblDrawings Where RecordID = '" & Val(RecordToEdit) & "'", SqlConnection1)
        da.Fill(ds, "DrawingInfo") '

        Me.lblDrawingNo.Text = ds.Tables("DrawingInfo").Rows(0).Item("DrawingNumber")
        Me.lblDrawingRevision.Text = ds.Tables("DrawingInfo").Rows(0).Item("DwgRevision")
        Me.lblDrawingTitle.Text = ds.Tables("DrawingInfo").Rows(0).Item("DrawingTitle")
        Me.lblStatus.Text = ds.Tables("DrawingInfo").Rows(0).Item("Status")
        Me.lblProgram.Text = ds.Tables("DrawingInfo").Rows(0).Item("Program")

        ds.Tables("DrawingInfo").Clear()
        ds.Tables("Drawinginfo").Dispose()


        'Load tblDrawingcertUMApproval

        '1.  A, do records exist.  If yes, load, if no, see if program definition already exists and load.
        da = New SqlClient.SqlDataAdapter("select * from tblDrawingCert where DwgRecordID = '" & Val(RecordToEdit) & "'", SqlConnection1)
        da.Fill(ds, "DrawingCert")

        If ds.Tables("DrawingCert").Rows.Count > 0 Then
            Me.cboCertificationReviewStatus.Text = ds.Tables("DrawingCert").Rows(0).Item("Status")
            Me.txtComments.Text = ds.Tables("DrawingCert").Rows(0).Item("Comments")
        Else
            'Check tblProgramCertificationUM for records, if exist load to tblDrawingCertUMApproval and then call SearchUMApproval

            u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingCert (DwgRecordID, Status, Comments) Values('" & Val(RecordToEdit) & "', 'Not Submitted', '')")
            Me.cboCertificationReviewStatus.Text = "Not Submitted"

        End If

        ds.Tables("DrawingCert").Clear()
        ds.Tables("DrawingCert").Dispose()

        'Step 1

        'Load tblDrawingcertUMApproval

        '1.  A, do records exist.  If yes, load, if no, see if program definition already exists and load.
        da = New SqlClient.SqlDataAdapter("select * from tblDrawingCertUMApproval where DwgRecordID = '" & Val(RecordToEdit) & "'", SqlConnection1)
        da.Fill(ds, "CheckDrawingcertUMApproval")

        If ds.Tables("CheckDrawingCertUMApproval").Rows.Count > 0 Then
            SearchUMApproval()
        Else
            'Check tblProgramCertificationUM for records, if exist load to tblDrawingCertUMApproval and then call SearchUMApproval
            da = New SqlClient.SqlDataAdapter("Select * from tblProgramCertificationUM where Program = '" & lblProgram.text & "'", SqlConnection1)
            da.Fill(ds, "FILL")

            If ds.Tables("FILL").Rows.Count > 0 Then
                Dim a As Integer = 0
                While a <= ds.Tables("FILL").Rows.Count - 1
                    u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingCertUMApproval (DwgRecordID, UMName, UMSpecialty, UMRecommendApproval, UMApproval, RequiredToApprove, Comments) Values('" & Val(RecordToEdit) & "','" & ds.Tables("FILL").Rows(a).Item("Name") & "', '" & ds.Tables("FILL").Rows(a).Item("UnitMemberSpecialty") & "', 'Not Applicable', '', 'False', '')")
                    a = a + 1
                End While
                SearchUMApproval()
            End If
            ds.Tables("FILL").Clear()
            ds.Tables("FILL").Dispose()
        End If

        ds.Tables("CheckDrawingCertUMApproval").Clear()
        ds.Tables("CheckDrawingCertUMApproval").Dispose()

        'Load tblDrawingCertFAAOMTApproval

        '1.  A, do records exist.  If yes, load, if no, see if program definition already exists and load.
        da = New SqlClient.SqlDataAdapter("select * from tblDrawingCertFAAOMTApproval where DwgRecordID = '" & Val(RecordToEdit) & "'", SqlConnection1)
        da.Fill(ds, "CheckDrawingcertFAAOMTApproval")

        If ds.Tables("CheckDrawingcertFAAOMTApproval").Rows.Count > 0 Then
            SearchFAAOMTApproval()
        Else
            'Check tblProgramCertificationUM for records, if exist load to tblDrawingCertUMApproval and then call SearchUMApproval
            da = New SqlClient.SqlDataAdapter("Select * from tblProgramCertificationFAAOMTMember where Program = '" & lblProgram.Text & "'", SqlConnection1)
            da.Fill(ds, "FILL1")

            If ds.Tables("FILL1").Rows.Count > 0 Then
                Dim a As Integer = 0
                While a <= ds.Tables("FILL1").Rows.Count - 1
                    u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingCertFAAOMTApproval (DwgRecordID, FAAOMTName, FAAOMTSpecialty, FAAOMTRecommendApproval, FAAOMTApproval, RequiredToApprove, Comments) Values('" & Val(RecordToEdit) & "','" & ds.Tables("FILL1").Rows(a).Item("Name") & "', '" & ds.Tables("FILL1").Rows(a).Item("FAAOMTMemberSpecialty") & "', 'False', '', 'False', '')")
                    a = a + 1
                End While
                SearchFAAOMTApproval()
            End If
            ds.Tables("FILL1").Clear()
            ds.Tables("FILL1").Dispose()
        End If

        ds.Tables("CheckDrawingcertFAAOMTApproval").Clear()
        ds.Tables("CheckDrawingcertFAAOMTApproval").Dispose()

        SearchAttachments()

    End Sub

    Public Function SearchUMApproval()
        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet91.tblDrawingCertUMApproval.Clear()

        'Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        If Me.chkShowAllUMApprovals.Checked = True Then
            Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString + " Where DwgRecordID = '" & Val(RecordToEdit) & "'"
        Else
            Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString + " Where DwgRecordID = '" & Val(RecordToEdit) & "' and RequiredToApprove = 'True'"

        End If


        Try
            Me.SqlDataAdapter1.Fill(DataSet91.tblDrawingCertUMApproval)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet91.Tables("tblDrawingCertUMApproval").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            'Search = True

            'Create DataBindings
            'Me.txtRecordID.DataBindings.Add("Text",
            'Me.BindingSource2, "RecordID")

        Else
            'MsgBox("No Records Exist")
        End If
    End Function

    Public Function SearchFAAOMTApproval()
        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet101.tblDrawingCertFAAOMTApproval.Clear()

        'Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter2.SelectCommand.CommandText
        If Me.chkShowAllFAAOMTApprovals.Checked = True Then
            Me.SqlDataAdapter2.SelectCommand.CommandText() += SqlString + " Where DwgRecordID = '" & Val(RecordToEdit) & "'"
        Else
            Me.SqlDataAdapter2.SelectCommand.CommandText() += SqlString + " Where DwgRecordID = '" & Val(RecordToEdit) & "' and RequiredToApprove = 'True'"
        End If

        Try
            Me.SqlDataAdapter2.Fill(DataSet101.tblDrawingCertFAAOMTApproval)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter2.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet101.Tables("tblDrawingCertFAAOMTApproval").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            'Search = True

            'Create DataBindings
            'Me.txtRecordID.DataBindings.Add("Text",
            'Me.BindingSource2, "RecordID")

        Else
            'MsgBox("No Records Exist")
        End If
    End Function

    Public Function SearchAttachments()
        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet111.tblDrawingCertAttachments.Clear()

        Me.txtAttachRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter3.SelectCommand.CommandText
        Me.SqlDataAdapter3.SelectCommand.CommandText() += SqlString + " Where DwgRecordID = '" & Val(RecordToEdit) & "'"

        Try
            Me.SqlDataAdapter3.Fill(DataSet111.tblDrawingCertAttachments)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter3.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet111.Tables("tblDrawingCertAttachments").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            'Search = True

            'Create DataBindings
            Me.txtAttachRecordID.DataBindings.Add("Text",
            Me.BindingSource3, "RecordID")

        Else
            'MsgBox("No Records Exist")
        End If
    End Function



    Private Sub btnDeleteAttachment_Click(sender As Object, e As EventArgs) Handles btnDeleteAttachment.Click
        If Me.txtAttachRecordID.Text = "" Then
            MsgBox("There are no files to delete.", MsgBoxStyle.Information, "Drawing Workflow")
        Else
            Dim answer
            answer = MsgBox("Are you sure you want to delete this file?", MsgBoxStyle.YesNo, "Drawing Workflow")

            If answer = 6 Then
                u.ExecuteSQL(SqlConnection1, "DELETE FROM tblDrawingCertAttachments WHERE RecordID = '" & Val(Me.txtAttachRecordID.Text) & "'")
                MsgBox("The file has been deleted.", MsgBoxStyle.Information, "Drawing Workflow")
                Me.SearchAttachments()
                'GetElectronicStatus()
            Else
                MsgBox("Deletion of file was canceled.", MsgBoxStyle.Information, "Drawing Workflow")
            End If
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If Me.txtAttachRecordID.Text = "" Then
            MsgBox("There are no files to view.", MsgBoxStyle.Information, "EARR APP")
        Else
            DeleteTempFilesFromViewing()

            da = New SqlClient.SqlDataAdapter("SELECT * FROM tblDrawingCertAttachments WHERE RecordID = '" & Me.txtAttachRecordID.Text & "'", SqlConnection1)
            Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)

            SqlConnection1.Open()

            da.Fill(ds, "MyImages")
            Dim myRow As DataRow
            myRow = ds.Tables("MyImages").Rows(0)

            Dim MyData() As Byte
            MyData = myRow("ImgField")
            Dim Extension As String
            Extension = myRow("FileExt")

            Dim K As Long
            K = UBound(MyData)

            Dim FileDest As String

            'FileDest = Environment.SpecialFolder.MyDocuments.ToString + Format(Now, "MMddyyyyhhmmss") + "." + Extension
            FileDest = "C:\Temp\" + Format(Now, "MMddyyyyhhmmss") + "." + Extension
            Dim fs As New FileStream(FileDest, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(MyData, 0, K)
            fs.Close()
            fs = Nothing
            MyCB = Nothing
            ds.Tables("MyImages").Clear()

            Process.Start(FileDest)

            SqlConnection1.Close()
        End If
    End Sub

    Private Sub DeleteTempFilesFromViewing()
        Dim File As String

        For Each File In Directory.GetFiles("C:\Temp\")
            Dim File2 As New FileInfo(File)
            Try
                File2.Delete()
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Me.OpenFileDialog1.InitialDirectory = "C:\"
        Me.OpenFileDialog1.Filter = "All files (*.*)|*.*"
        Me.OpenFileDialog1.FilterIndex = 1
        Me.OpenFileDialog1.RestoreDirectory = True

        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Me.OpenFileDialog1.FileName
            Me.txtFilePath.Text = Me.OpenFileDialog1.FileName.ToString
        End If
    End Sub

    Private Sub btnSaveNew_Click(sender As Object, e As EventArgs) Handles btnSaveNew.Click
        Dim FileUploadSave As String = "AddNew"
        If FileUploadSave = "AddNew" Then
            Dim ToPath As String
            ToPath = Me.txtFilePath.Text
            ToPath = ToPath.Substring(ToPath.LastIndexOf("\") + 1)

            Dim FileName As String
            FileName = ToPath
            Dim FileExt As String
            FileExt = ToPath.Substring(ToPath.LastIndexOf(".") + 1)

            da = New SqlClient.SqlDataAdapter("SELECT * FROM tblDrawingCertAttachments where RecordID = '" & Val(Me.txtAttachRecordID.Text) & "'", SqlConnection1)
            Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey

            Dim fs As New FileStream(Me.txtFilePath.Text, FileMode.OpenOrCreate, FileAccess.Read)
            Dim MyData(fs.Length) As Byte
            fs.Read(MyData, 0, fs.Length)
            fs.Close()

            SqlConnection1.Open()

            da.Fill(ds, "MyImages")
            Dim myRow As DataRow
            myRow = ds.Tables("MyImages").NewRow

            myRow("DwgRecordID") = Val(RecordToEdit)
            myRow("FilePath") = ToPath
            myRow("FileDescription") = u.FTM(Me.txtFileDescription.Text)
            myRow("ImgField") = MyData
            myRow("FileName") = FileName
            myRow("FileExt") = FileExt

            ds.Tables("MyImages").Rows.Add(myRow)
            da.Update(ds, "MyImages")

            fs = Nothing
            MyCB = Nothing
            ds.Tables("MyImages").Clear()

            SqlConnection1.Close()
            MsgBox("Document Saved to Database")

            Me.SearchAttachments()
            Me.btnSaveNew.Visible = False
            'GetElectronicStatus()
        End If
    End Sub



    Private Sub btnSaveUMApprovals_Click(sender As Object, e As EventArgs) Handles btnSaveUMApprovals.Click
        Me.SqlDataAdapter1.Update(DataSet91.tblDrawingCertUMApproval)
        Me.SqlDataAdapter2.Update(DataSet101.tblDrawingCertFAAOMTApproval)
        u.ExecuteSQL(SqlConnection1, "Update tblDrawingCert Set Status = '" & Me.cboCertificationReviewStatus.Text & "', Comments = '" & u.FTM(Me.txtComments.Text) & "' Where DwgRecordID = '" & RecordToEdit & "'")
        Me.Close()
    End Sub

    Private Sub btnFileAttachSubmit_Click(sender As Object, e As EventArgs) Handles btnFileAttachSubmit.Click
        btnSaveNew.Visible = True
        Me.txtFileDescription.Text = ""
        Me.txtFilePath.Text = ""
        MsgBox("Fill in the description and browse for the file and click Save New")
    End Sub

    Private Sub chkShowAllUMApprovals_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowAllUMApprovals.CheckedChanged
        SearchUMApproval()
    End Sub

    Private Sub chkShowAllFAAOMTApprovals_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowAllFAAOMTApprovals.CheckedChanged
        SearchFAAOMTApproval()
    End Sub

    Private Sub btnSyncUMApprovals_Click(sender As Object, e As EventArgs) Handles btnSyncUMApprovals.Click
        da = New SqlClient.SqlDataAdapter("SELECT * FROM tblProgramCertificationUM Where Program = '" & Me.lblProgram.Text & "'", SqlConnection1)
        da.Fill(ds, "SYNCUM")

        Dim d As Integer = 0
        While d <= ds.Tables("SYNCUM").Rows.Count - 1

            da = New SqlClient.SqlDataAdapter("Select * from tbldrawingcertUMApproval Where UMName = '" & ds.Tables("SYNCUM").Rows(d).Item("Name") & "' and DwgRecordID = '" & RecordToEdit & "'", SqlConnection1)
            da.Fill(ds, "RA")

            If ds.Tables("RA").Rows.Count > 0 Then
            Else
                u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawingCertUMApproval (UMName, DWGRecordID, UMSpecialty, UMRecommendApproval, UMApproval, RequiredToApprove, Comments) Values ('" & u.FTM(ds.Tables("SYNCUM").Rows(d).Item("Name")) & "', '" & RecordToEdit & "', '" & u.FTM(ds.Tables("SYNCUM").Rows(d).Item("UnitMemberSpecialty")) & "', 'Not Applicable', '','False','')")
            End If

            ds.Tables("RA").Clear()
            ds.Tables("RA").Dispose()

            d = d + 1
        End While
        ds.Tables("SYNCUM").Clear()
        ds.Tables("SYNCUM").Dispose()

        SearchUMApproval()

    End Sub

    Private Sub btnSyncOMTApprovals_Click(sender As Object, e As EventArgs) Handles btnSyncOMTApprovals.Click
        da = New SqlClient.SqlDataAdapter("SELECT * FROM tblProgramCertificationFAAOMTMember Where Program = '" & Me.lblProgram.Text & "'", SqlConnection1)
        da.Fill(ds, "SYNCUM")


        Dim d As Integer = 0
        While d <= ds.Tables("SYNCUM").Rows.Count - 1

            da = New SqlClient.SqlDataAdapter("Select * from tbldrawingcertFAAOMTApproval Where FAAOMTName = '" & ds.Tables("SYNCUM").Rows(d).Item("Name") & "' and DwgRecordID = '" & RecordToEdit & "'", SqlConnection1)
            da.Fill(ds, "RA")
            If ds.Tables("RA").Rows.Count > 0 Then
            Else
                u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawingCertFAAOMTApproval (FAAOMTName, DWGRecordID, FAAOMTSpecialty, FAAOMTRecommendApproval, FAAOMTApproval, RequiredToApprove, Comments) Values ('" & u.FTM(ds.Tables("SYNCUM").Rows(d).Item("Name")) & "', '" & RecordToEdit & "', '" & u.FTM(ds.Tables("SYNCUM").Rows(d).Item("FAAOMTMemberSpecialty")) & "', 'False',  '', 'False', '')")
            End If
            ds.Tables("RA").Clear()
            ds.Tables("RA").Dispose()
            d = d + 1
        End While
        ds.Tables("SYNCUM").Clear()
        ds.Tables("SYNCUM").Dispose()

        Me.SearchFAAOMTApproval()
    End Sub
End Class