Imports DevExpress.XtraGrid.Views.Grid

Public Class frmLiveMDLCurrent
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Dim DocumentType As String
    Dim LVL As Decimal
    Dim LVLDesc As String
    Dim TopLVL As Decimal
    Dim TopLVLDesc As String
    Dim LVLLVLDesc As String
    Dim CurrentDocStatus
    Dim Priority As String
    Dim DRNADCN As String
    Dim ADCN As String

    Private Sub frmLiveMDLCurrent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        da = New SqlClient.SqlDataAdapter("Select * from tblLiveMDL Where RecordID = '" & Val(OpenMDL) & "'", SqlConnection1)
        da.Fill(ds, "MDL")

        lblTitle.Text = ds.Tables("MDL").Rows(0).Item("Title")
        Priority = ds.Tables("MDL").Rows(0).Item("Priority")
        lblStatus.Text = ds.Tables("MDL").Rows(0).Item("Status")
        lblMDLNo.Text = ds.Tables("MDL").Rows(0).Item("MDLNumber")
        lblRev.Text = ds.Tables("MDL").Rows(0).Item("Revision")
        lblDocumentNumber.Text = ds.Tables("MDL").Rows(0).Item("DocumentNumber")


        lblLastRefresh.Text = ds.Tables("MDL").Rows(0).Item("LastRefresh")

        Search()

        If lblStatus.Text = "REL" Or lblStatus.Text = "LOCKED" Then
            Me.btnRefresh.Enabled = False
            Me.btnPrepForIssue.Enabled = False




        Else
            Me.btnRefresh.Enabled = True
            Me.btnPrepForIssue.Enabled = True

        End If

        If lblStatus.Text = "LOCKED" And MDLUnlocked = True Then
            Me.btnUnlock.Enabled = True
        Else
            Me.btnUnlock.Enabled = False
        End If



    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Function Classify()
        'Get level from the database.
        da = New SqlClient.SqlDataAdapter("Select LVL, LVLDesc, TopLVL, TopLVLDesc from tblDocumentType Where DocumentType = '" & DocumentType & "'", SqlConnection1)
        da.Fill(ds, "LVL1")

        If ds.Tables("LVL1").Rows.Count > 0 Then
            LVL = ds.Tables("LVL1").Rows(0).Item("LVL")
            LVLDesc = ds.Tables("LVL1").Rows(0).Item("LVLDesc")
            TopLVL = ds.Tables("LVL1").Rows(0).Item("TopLVL")
            TopLVLDesc = ds.Tables("LVL1").Rows(0).Item("TopLVLDesc")
            LVLLVLDesc = ds.Tables("LVL1").Rows(0).Item("LVL") & "-" & ds.Tables("LVL1").Rows(0).Item("LVLDesc")
        Else
            LVL = "0"
        End If

        ds.Tables("LVL1").Clear()
        ds.Tables("LVL1").Dispose()

    End Function
    Public Function Search()
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet331.tblLiveMDLDetail.Clear()

        Me.txtRecordID.DataBindings.Clear()
        Me.txtRev.DataBindings.Clear()
        Me.txtTitle.DataBindings.Clear()
        Me.txtDrawingNumber.DataBindings.Clear()
        Me.txtDocumentNumber.DataBindings.Clear()


        'Me.txtStatus.DataBindings.Clear()
        'Me.cboRev.DataBindings.Clear()
        Dim cmdSave As String

        SqlString = " Where MDLRecordID = '" & Val(OpenMDL) & "'"
        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString
        'Me.SqlDataAdapter1.SelectCommand.CommandText = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY MDLNumber ORDER BY Seq DESC) AS row_num FROM vwLiveMDLRevisions) AS derived WHERE row_num = 1"
        Try
            Me.SqlDataAdapter1.Fill(Me.DataSet331.tblLiveMDLDetail)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet331.Tables("tblLiveMDLDetail").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            'Search = True

            'Create DataBindings            
            Me.txtRecordID.DataBindings.Add("Text",
            Me.BindingSource1, "RecordID")
            Me.txtRev.DataBindings.Add("Text",
            Me.BindingSource1, "DwgRevision")
            Me.txtTitle.DataBindings.Add("Text",
            Me.BindingSource1, "DrawingTitle")
            Me.txtDrawingNumber.DataBindings.Add("Text",
Me.BindingSource1, "DrawingNumber")
            Me.txtDocumentNumber.DataBindings.Add("text",
                                                  Me.BindingSource1, "DocumentNumber")
            '            Me.txtStatus.DataBindings.Add("Text",
            'Me.BindingSource1, "Status")
            '            Me.cboRev.DataBindings.Add("Text",
            'Me.BindingSource1, "Revision")


        End If

        GridView1.ExpandAllGroups()
        'GridView1.CollapseGroupLevel(GridView1.GroupCount - 1)

    End Function

    Private Sub btnLoadNew_Click(sender As Object, e As EventArgs) Handles btnLoadNew.Click
        Dim frmLIveMDL As New frmLiveMDL
        frmLIveMDL.Show()

        Me.Close()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        MsgBox("Would you like to refresh?")

        Dim result As DialogResult = MessageBox.Show("Please confirm you would like to refresh the MDL.",
              "Title",
              MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then

            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Notes = '' Where Notes Is Null")

            u.ExecuteSQL(SqlConnection1, "Delete from tblLiveMDLDetail Where MDLRecordID = '" & Val(OpenMDL) & "'")

            da = New SqlClient.SqlDataAdapter("Select * from tblLiveMDLProjectsSystems Where MDLRecordID = '" & Val(OpenMDL) & "'", SqlConnection1)
            da.Fill(ds, "PROJSYS")
            'u.ExecuteSQL(SqlConnection1, "Update tblLiveMDL Set LastRefresh = '" & Now & "' Where RecordID = '" & Val(OpenMDL) * "'")
            Dim z As Integer = 0
            'Loop through each Program and System, populate the MDL Detail Table.
            While z <= ds.Tables("PROJSYS").Rows.Count - 1
                'Populate MDL table
                If ds.Tables("PROJSYS").Rows(z).Item("System") = "Unspecified" Then
                    'Grab all records for program specified
                    da = New SqlClient.SqlDataAdapter("Select * from tblLIveMDLMileStone Where MDLRecordID = '" & Val(OpenMDL) & "'", SqlConnection1)
                    da.Fill(ds, "MS")
                    Dim p As Integer = 0

                    If ds.Tables("MS").Rows.Count = 0 Then
                        da = New SqlClient.SqlDataAdapter("SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "'", SqlConnection1)
                    Else

                        Dim Str As String
                        While p <= ds.Tables("MS").Rows.Count - 1

                            If p = 0 Then
                                Str = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' and Priority = '" & ds.Tables("MS").Rows(p).Item("Milestone") & "'"
                            Else
                                Str = Str + " OR row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' and Priority = '" & ds.Tables("MS").Rows(p).Item("Milestone") & "'"
                            End If
                            p = p + 1
                        End While
                        da = New SqlClient.SqlDataAdapter(Str, SqlConnection1)
                    End If

                    ds.Tables("MS").Clear()
                    ds.Tables("MS").Dispose()

                    'da = New SqlClient.SqlDataAdapter("SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' AND Status = 'GATE 6: Complete'", SqlConnection1)
                    da.Fill(ds, "Set")

                    'Loop through each record, determining document type, level and insert record into tblLiveMDLDetail
                    Dim x As Integer = 0
                    While x <= ds.Tables("Set").Rows.Count - 1
                        Me.gbProgress.Visible = True
                        ProgressBar1.Maximum = ds.Tables("SET").Rows.Count
                        ProgressBar1.Minimum = 0
                        ProgressBar1.Value = x
                        DocumentType = ds.Tables("Set").Rows(x).Item("DrawingType")
                        Classify()

                        If LVL = "0" Then
                            'Do Nothing
                        Else
                            'Need to insert a record
                            Try
                                If u.FTM(ds.Tables("Set").Rows(x).Item("ADCN")) = "0" Then
                                    ADCN = ""
                                Else
                                    ADCN = u.FTM(ds.Tables("Set").Rows(x).Item("ADCN"))
                                End If

                                DRNADCN = "DRN: " & u.FTM(ds.Tables("Set").Rows(x).Item("DRNADCN")) & "    ADCN:  " & u.FTM(ADCN)
                                u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLDetail (MDLRecordID, Revision, MDLNumber, DocumentNumber, LVL, DrawingNumber, DWgRevision, ActualFinishDate, DrawingTitle, Status, Notes, SystemDescription, DrawingType, LVLDesc, TopLVL, TopLVLDesc, LVLLVLDESC, Cancelled, DeferToNextMDL, ShowPreviousREv, OverrideDRNDetails, ShowRemarks, RemarksText, OverrideDRNText, ShowPreviousRevText) Values ('" & Val(OpenMDL) & "', '" & ds.Tables("MDL").Rows(0).Item("Revision") & "', '" & Val(ds.Tables("MDL").Rows(0).Item("MDLNumber")) & "', '" & ds.Tables("MDL").Rows(0).Item("DocumentNumber") & "', '" & LVL & "', '" & ds.Tables("Set").Rows(x).Item("DrawingNumber") & "', '" & ds.Tables("Set").Rows(x).Item("DwgRevision") & "', '" & ds.Tables("Set").Rows(x).Item("ActualFinishDate") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("DrawingTitle")) & "', '" & ds.Tables("Set").Rows(x).Item("Status") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("Notes")) & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("SystemDescription")) & "', '" & ds.Tables("Set").Rows(x).Item("DrawingType") & "', '" & LVLDesc & "', '" & TopLVL & "', '" & TopLVLDesc & "', '" & LVLLVLDesc & "', 'False', 'False', 'False', 'False', 'False', '" & u.FTM(DRNADCN) & "', '', '')")
                            Catch ex As Exception
                                MsgBox(ds.Tables("set").Rows(x).Item("RecordID"))
                                MsgBox(ex.ToString)
                            End Try

                        End If

                        x = x + 1
                    End While

                    ds.Tables("Set").Clear()
                    ds.Tables("Set").Dispose()


                Else
                    'Grab only those records for specific system.
                    'Grab all records for program specified
                    'da = New SqlClient.SqlDataAdapter("SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' AND SystemDescription = '" & ds.Tables("PROJSYS").Rows(z).Item("System") & "' AND Status = 'GATE 6: Complete'", SqlConnection1)
                    da = New SqlClient.SqlDataAdapter("Select * from tblLIveMDLMileStone Where MDLRecordID = '" & Val(OpenMDL) & "'", SqlConnection1)
                    da.Fill(ds, "MS")
                    Dim p As Integer = 0

                    If ds.Tables("MS").Rows.Count = 0 Then
                        da = New SqlClient.SqlDataAdapter("SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "'", SqlConnection1)
                    Else

                        Dim Str As String
                        While p <= ds.Tables("MS").Rows.Count - 1

                            If p = 0 Then
                                Str = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' and Priority = '" & ds.Tables("MS").Rows(p).Item("Milestone") & "'"
                            Else
                                Str = Str + " OR row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' and Priority = '" & ds.Tables("MS").Rows(p).Item("Milestone") & "'"
                            End If
                            p = p + 1
                        End While
                        da = New SqlClient.SqlDataAdapter(Str, SqlConnection1)
                    End If

                    ds.Tables("MS").Clear()
                    ds.Tables("MS").Dispose()

                    da.Fill(ds, "Set")

                    'Loop through each record, determining document type, level and insert record into tblLiveMDLDetail
                    Dim x As Integer = 0
                    While x <= ds.Tables("Set").Rows.Count - 1
                        Me.gbProgress.Visible = True
                        ProgressBar1.Minimum = 0
                        ProgressBar1.Maximum = ds.Tables("SET").Rows.Count
                        ProgressBar1.Value = x
                        DocumentType = ds.Tables("Set").Rows(x).Item("DrawingType")
                        Classify()

                        If LVL = "0" Then
                            'Do Nothing
                        Else
                            'Need to insert a record
                            If u.FTM(ds.Tables("Set").Rows(x).Item("ADCN")) = "0" Then
                                ADCN = ""
                            Else
                                ADCN = u.FTM(ds.Tables("Set").Rows(x).Item("ADCN"))
                            End If
                            DRNADCN = "DRN: " & u.FTM(ds.Tables("Set").Rows(x).Item("DRNADCN")) & "    ADCN:  " & u.FTM(ADCN)
                            u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLDetail (MDLRecordID, Revision, MDLNumber, DocumentNumber, LVL, DrawingNumber, DWgRevision, ActualFinishDate, DrawingTitle, Status, Notes, SystemDescription, DrawingType, LVLDesc, TopLVL, TopLVLDesc, LVLLVLDESC, Cancelled, DeferToNextMDL, ShowPreviousREv, OverrideDRNDetails, ShowRemarks, RemarksText, OverrideDRNText, ShowPreviousRevText) Values ('" & Val(OpenMDL) & "', '" & ds.Tables("MDL").Rows(0).Item("Revision") & "', '" & Val(ds.Tables("MDL").Rows(0).Item("MDLNumber")) & "', '" & ds.Tables("MDL").Rows(0).Item("DocumentNumber") & "', '" & LVL & "', '" & ds.Tables("Set").Rows(x).Item("DrawingNumber") & "', '" & ds.Tables("Set").Rows(x).Item("DwgRevision") & "', '" & ds.Tables("Set").Rows(x).Item("ActualFinishDate") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("DrawingTitle")) & "', '" & ds.Tables("Set").Rows(x).Item("Status") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("Notes")) & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("SystemDescription")) & "', '" & ds.Tables("Set").Rows(x).Item("DrawingType") & "', '" & LVLDesc & "', '" & TopLVL & "', '" & TopLVLDesc & "', '" & LVLLVLDesc & "', 'False', 'False', 'False', 'False', 'False', '" & u.FTM(DRNADCN) & "', '', '')")
                        End If

                        x = x + 1
                    End While

                    ds.Tables("Set").Clear()
                    ds.Tables("Set").Dispose()
                End If



                z = z + 1
            End While

            'Populate System
            da = New SqlClient.SqlDataAdapter("select Distinct LVL from tblLiveMDLDetail Where MDLRecordID = '" & Val(OpenMDL) & "' Order By LVL Asc", SqlConnection1)
            da.Fill(ds, "L")

            Dim j As Integer = 0

            While j <= ds.Tables("L").Rows.Count - 1

                da = New SqlClient.SqlDataAdapter("Select Distinct SystemDescription from tblLiveMDLDetail Where MDLRecordID = '" & Val(OpenMDL) & "' AND LVL = '" & ds.Tables("L").Rows(j).Item("LVL") & "' Order By SystemDescription Asc", SqlConnection1)
                da.Fill(ds, "O")

                Dim inte As Integer = 1
                Dim f As Integer = 0

                While f <= ds.Tables("O").Rows.Count - 1
                    Dim syslvl As String
                    syslvl = ds.Tables("L").Rows(j).Item("LVL") & "." & inte
                    syslvl = syslvl & " " & ds.Tables("O").Rows(f).Item("SystemDescription")
                    u.ExecuteSQL(SqlConnection1, "Update tblLiveMDLDetail Set SystemDescription = '" & syslvl & "', SystemSeq = '" & Val(inte) & "' Where SystemDescription = '" & ds.Tables("O").Rows(f).Item("SystemDescription") & "' AND LVL = '" & ds.Tables("L").Rows(j).Item("LVL") & "' AND MDLRecordID = '" & Val(OpenMDL) & "'")
                    inte = inte + 1
                    f = f + 1
                End While

                ds.Tables("O").Clear()
                ds.Tables("O").Dispose()

                j = j + 1
            End While

            ds.Tables("L").Clear()
            ds.Tables("L").Dispose()
            gbProgress.Visible = False
            ProgressBar1.Value = 0
            'Update MDL Record Status to 'WIP'
            MsgBox("MDL Populated")


            Search()
            lblLastRefresh.Text = Now

        Else

        End If
        'Get the Programs and Systems Associated with the MDL


    End Sub



    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit1.Click

        If lblStatus.Text = "REL" Or lblStatus.Text = "LOCKED" Then
            MsgBox("You cannot edit line options because the MDL is either LOCKED or RELEASED.")
            Exit Sub
        End If
        MDLOptionsRecordID = Me.txtRecordID.Text
        MDLOptionsDrawingRev = Me.txtRev.Text
        MDLOptionsDrawingTitle = Me.txtTitle.Text
        MDLOptionsDrawingNumber = Me.txtDrawingNumber.Text

        Dim frmMDLLiveOptionsMenu As New frmLiveMDLOptionsMenu

        frmMDLLiveOptionsMenu.ShowDialog()
        Search()
    End Sub

    Private Sub GridView1_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView1.RowStyle

        Dim Status As String = GridView1.GetRowCellValue(e.RowHandle, "Status")
        Dim Cancelled As Boolean = GridView1.GetRowCellValue(e.RowHandle, "Cancelled")
        Dim DeferToNextMDL As Boolean = GridView1.GetRowCellValue(e.RowHandle, "DeferToNextMDL")

        If Status <> "GATE 6: Complete" And Status <> "Cancelled" And Status <> "" Then
            e.Appearance.BackColor = Color.Green
        End If

        If Cancelled = True Then
            e.Appearance.BackColor = Color.Pink
            Using font As Font = New Font(e.Appearance.Font, FontStyle.Strikeout)
            End Using
        End If

        If DeferToNextMDL = True Then
            e.Appearance.BackColor = Color.Gray

        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

        Dim crReport As New crMDLPrint

        crReport.SetDatabaseLogon("sa1", "The water is wet!")

        Dim sqlstring As String

        sqlstring = "SELECT * from tblLiveMDL, tblLiveMDLDetail where tblLiveMDL.RecordID = '" & Val(OpenMDL) & "' and tblLIveMDL.RecordID = tblLIveMDLDetail.MDLRecordID And Cancelled = 'False' and DeferToNextMDL = 'False'"

        GlobalSqlString = sqlstring

        Dim frm As New frmViewReport
        frm.ReportType = "MDLGridView"
        frm.Report3 = crReport
        frm.Show()
    End Sub

    Private Sub btnPrepForIssue_Click(sender As Object, e As EventArgs) Handles btnPrepForIssue.Click
        'da = New SqlClient.SqlDataAdapter("Select * from vwMDLExceptions Where MDLNumber = '" & Val(OpenMDL) & "' and Status1 <> 'Gate 6: Complete' and ShowPreviousRev = 'False' and DeferToNextMDL = 'False' and Cancelled = 'False'", SqlConnection1)
        'da.Fill(ds, "Ex")

        Dim frmMDLExceptions As New frmMDLExceptions
        frmMDLExceptions.ShowDialog()
        Search()


        'loop through and insert exception into an exception table.
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        u.ExecuteSQL(SqlConnection1, "Update tblLiveMDL Set Status = 'WIP' Where RecordID = '" & Val(OpenMDL) & "'")
        lblStatus.Text = "WIP"

        Me.btnRefresh.Enabled = True
        Me.btnPrepForIssue.Enabled = True

    End Sub
End Class