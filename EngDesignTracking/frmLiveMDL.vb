Public Class frmLiveMDL

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


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnCreateNewMDL_Click(sender As Object, e As EventArgs) Handles btnCreateNewMDL.Click
        Dim frmMDLAdd As New frmMDLAdd
        frmMDLAdd.ShowDialog()

        Search()

    End Sub

    Public Function Search()
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet321.vwLiveMDLRevisions.Clear()

        Me.txtRecordID.DataBindings.Clear()
        Me.txtRev.DataBindings.Clear()
        Me.txtMDLNumber.DataBindings.Clear()
        Me.txtStatus.DataBindings.Clear()
        Me.cboRev.DataBindings.Clear()
        Me.txtProgram.DataBindings.Clear()
        Me.txtDocumentNumber.DataBindings.Clear()

        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        'Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString
        Me.SqlDataAdapter1.SelectCommand.CommandText = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY MDLNumber ORDER BY Seq DESC) AS row_num FROM vwLiveMDLRevisions) AS derived WHERE row_num = 1"
        Try
            Me.SqlDataAdapter1.Fill(Me.DataSet321.vwLiveMDLRevisions)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet321.Tables("vwLiveMDLRevisions").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            'Search = True
            Me.txtMDLNumber.DataBindings.Add("Text",
Me.BindingSource1, "MDLNumber")
            'Create DataBindings            
            Me.txtRecordID.DataBindings.Add("Text",
            Me.BindingSource1, "RecordID")
            Me.txtRev.DataBindings.Add("Text",
Me.BindingSource1, "Revision")

            Me.txtStatus.DataBindings.Add("Text",
Me.BindingSource1, "Status")
            Me.cboRev.DataBindings.Add("Text",
Me.BindingSource1, "Revision")
            Me.txtDocumentNumber.Databindings.add("Text",
                                                  Me.BindingSource1, "DocumentNumber")



        End If
    End Function

    Private Sub frmLiveMDL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        Search()

    End Sub

    Private Sub txtRecordID_TextChanged(sender As Object, e As EventArgs) Handles txtRecordID.TextChanged
        'Populate available revisions for current selected record.
        da = New SqlClient.SqlDataAdapter("Select Revision from vwLiveMDLRevisions Where MDLNumber = '" & Val(Me.txtMDLNumber.Text) & "' Order By Seq Desc", SqlConnection1)
        da.Fill(ds, "REV")

        Me.cboRev.Items.Clear()

        If ds.Tables("REV").Rows.Count > 0 Then

            Dim p As Integer = 0

            While p <= ds.Tables("REV").Rows.Count - 1

                cboRev.Items.Add(ds.Tables("REV").Rows(p).Item("Revision"))
                p = p + 1
            End While
        End If

        Me.cboRev.Text = Me.txtRev.Text

        ds.Tables("REV").Clear()
        ds.Tables("REV").Dispose()



    End Sub

    Private Sub btnOpenrev_Click(sender As Object, e As EventArgs) Handles btnOpenrev.Click
        'If Status = '-', then we are going to populate the MDL and move it to WIP status.

        'Go get status here.  
        da = New SqlClient.SqlDataAdapter("Select Status, RecordID, Priority from tblLiveMDL Where MDLNumber = '" & Val(Me.txtMDLNumber.Text) & "' And Revision = '" & Me.cboRev.Text & "'", SqlConnection1)
        da.Fill(ds, "CurrentDoc")

        u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Notes = '' Where Notes Is Null")

        CurrentDocStatus = ds.Tables("CurrentDoc").Rows(0).Item("Status")
        Priority = ds.Tables("CurrentDoc").Rows(0).Item("Priority")

        OpenMDL = Val(ds.Tables("CurrentDoc").Rows(0).Item("RecordID"))

        ds.Tables("CurrentDoc").Clear()
        ds.Tables("CurrentDoc").Dispose()


        If CurrentDocStatus = "-" Then

            Me.gbProgress.Visible = True
            ProgressBar1.Minimum = 0

            MsgBox("MDL is in a '-' Status.  MDL will now be populated and opened.")

            'Get the Programs and Systems Associated with the MDL

            da = New SqlClient.SqlDataAdapter("Select * from tblLiveMDLProjectsSystems Where MDLRecordID = '" & Val(OpenMDL) & "'", SqlConnection1)
            da.Fill(ds, "PROJSYS")

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
                    ProgressBar1.Maximum = ds.Tables("Set").Rows.Count

                    'Loop through each record, determining document type, level and insert record into tblLiveMDLDetail
                    Dim x As Integer = 0
                    While x <= ds.Tables("Set").Rows.Count - 1
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
                                u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLDetail (MDLRecordID, Revision, MDLNumber, DocumentNumber, LVL, DrawingNumber, DWgRevision, ActualFinishDate, DrawingTitle, Status, Notes, SystemDescription, DrawingType, LVLDesc, TopLVL, TopLVLDesc, LVLLVLDESC, Cancelled, DeferToNextMDL, ShowPreviousREv, OverrideDRNDetails, ShowRemarks, RemarksText, OverrideDRNText, ShowPreviousRevText) Values ('" & Val(OpenMDL) & "', '" & Me.cboRev.Text & "', '" & Val(Me.txtMDLNumber.Text) & "',, '" & Me.txtDocumentNumber.Text & "', '" & LVL & "', '" & ds.Tables("Set").Rows(x).Item("DrawingNumber") & "', '" & ds.Tables("Set").Rows(x).Item("DwgRevision") & "', '" & ds.Tables("Set").Rows(x).Item("ActualFinishDate") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("DrawingTitle")) & "', '" & ds.Tables("Set").Rows(x).Item("Status") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("Notes")) & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("SystemDescription")) & "', '" & ds.Tables("Set").Rows(x).Item("DrawingType") & "', '" & LVLDesc & "', '" & TopLVL & "', '" & TopLVLDesc & "', '" & LVLLVLDesc & "', 'False', 'False', 'False', 'False', 'False', '" & u.FTM(DRNADCN) & "', '', '')")



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


                    If ds.Tables("MS").Rows.Count = 0 Then
                        da = New SqlClient.SqlDataAdapter("SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' AND SystemDescription = '" & ds.Tables("PROJSYS").Rows(z).Item("System") & "'", SqlConnection1)
                    Else
                        Dim p As Integer = 0
                        Dim Str As String
                        While p <= ds.Tables("MS").Rows.Count - 1

                            If p = 0 Then
                                Str = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' AND SystemDescription = '" & ds.Tables("PROJSYS").Rows(z).Item("System") & "' And Priority = '" & ds.Tables("MS").Rows(p).Item("Milestone") & "'"
                            Else
                                Str = Str + " OR row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' AND SystemDescription = '" & ds.Tables("PROJSYS").Rows(z).Item("System") & "' And Priority = '" & ds.Tables("MS").Rows(p).Item("Milestone") & "'"
                            End If


                            p = p + 1
                        End While

                        da = New SqlClient.SqlDataAdapter(Str, SqlConnection1)
                    End If

                    ds.Tables("MS").Clear()
                    ds.Tables("MS").Dispose()

                    da.Fill(ds, "Set")
                    ProgressBar1.Maximum = ds.Tables("Set").Rows.Count


                    'Loop through each record, determining document type, level and insert record into tblLiveMDLDetail
                    Dim x As Integer = 0
                    While x <= ds.Tables("Set").Rows.Count - 1
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
                            u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLDetail (MDLRecordID, Revision, MDLNumber, DocumentNumber, LVL, DrawingNumber, DWgRevision, ActualFinishDate, DrawingTitle, Status, Notes, SystemDescription, DrawingType, LVLDesc, TopLVL, TopLVLDesc, LVLLVLDESC, Cancelled, DeferToNextMDL, ShowPreviousREv, OverrideDRNDetails, ShowRemarks, RemarksText, OverrideDRNText, ShowPreviousRevText) Values ('" & Val(OpenMDL) & "', '" & Me.cboRev.Text & "', '" & Val(Me.txtMDLNumber.Text) & "', '" & Me.txtDocumentNumber.Text & "', '" & LVL & "', '" & ds.Tables("Set").Rows(x).Item("DrawingNumber") & "', '" & ds.Tables("Set").Rows(x).Item("DwgRevision") & "', '" & ds.Tables("Set").Rows(x).Item("ActualFinishDate") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("DrawingTitle")) & "', '" & ds.Tables("Set").Rows(x).Item("Status") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("Notes")) & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("SystemDescription")) & "', '" & ds.Tables("Set").Rows(x).Item("DrawingType") & "', '" & LVLDesc & "', '" & TopLVL & "', '" & TopLVLDesc & "', '" & LVLLVLDesc & "', 'False', 'False', 'False', 'False', 'False', '" & u.FTM(DRNADCN) & "', '', '')")
                        End If

                        x = x + 1
                    End While

                    ds.Tables("Set").Clear()
                    ds.Tables("Set").Dispose()
                End If



                z = z + 1
            End While

            'Update MDL Record Status to 'WIP'
            Me.gbProgress.Visible = False

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


            ProgressBar1.Value = 0
            MsgBox("MDL Populated")
            u.ExecuteSQL(SqlConnection1, "Update tblLiveMDL Set Status = 'WIP' Where RecordID = '" & Val(OpenMDL) & "'")



        End If
        'Open up MDL screen and load current MDL
        OpenMDLRev = Me.cboRev.Text
        Dim frmLiveMDLCurrent As New frmLiveMDLCurrent
        frmLiveMDLCurrent.Show()

        Me.Close()



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

    Private Sub btnNewRev_Click(sender As Object, e As EventArgs) Handles btnNewRev.Click
        da = New SqlClient.SqlDataAdapter("Select * from vwLiveMDLRevisions Where MDLNumber = '" & Val(Me.txtMDLNumber.Text) & "' Order By Seq Desc", SqlConnection1)
        da.Fill(ds, "GetNewRev")

        u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Notes = '' Where Notes Is Null")

        Dim NextSeq As Integer
        NextSeq = Val(ds.Tables("GETNEWREV").Rows(0).Item("Seq")) + 1
        Priority = ds.Tables("GetNewRev").Rows(0).Item("Priority")

        ds.Tables("GetNewRev").Clear()
        ds.Tables("GetNewRev").Dispose()

        da = New SqlClient.SqlDataAdapter("Select * from tblDwgRevisions Where Seq = '" & Val(NextSeq) & "'", SqlConnection1)
        da.Fill(ds, "OK")

        Dim DwgNewRev As String
        DwgNewRev = ds.Tables("OK").Rows(0).Item("DwgRevision")

        ds.Tables("OK").Clear()
        ds.Tables("OK").Dispose()

        da = New SqlClient.SqlDataAdapter("Select * from tblLIveMDL where MDLNumber = '" & Me.txtMDLNumber.Text & "' and Revision = '" & DwgNewRev & "'", SqlConnection1)
        da.Fill(ds, "Check")

        If ds.Tables("CHECK").Rows.Count > 0 Then
            MsgBox("The MDL Number/Revision combo already exists.  Please enter a new MDL number and then click save.")
        Else

            'Create the tblLiveMDL record
            u.ExecuteSQL(SqlConnection1, "INSERT into tblLiveMDL (MDLNumber, DocumentNumber,  Title, Revision, Status, LastRefresh, Priority) Values ('" & Val(Me.txtMDLNumber.Text) & "', '" & Me.txtDocumentNumber.Text & "', '" & Me.txtTitle.Text & "', '" & DwgNewRev & "', 'WIP', '" & Now & "', '" & Priority & "')")

            'Insert a record into the tbldrawings table
            u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, Program, SystemDescription, DwgRevision, Type, DocumentType, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter,DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, Updated, UpdatedDate, ADCN, ForecastStartDate) Values ('" & Me.txtDocumentNumber.Text & "', '" & Me.txtTitle.Text & "', '', '" & Me.txtProgram.Text & "', '', 'IR', '', 'Master Data List', '', '" & Loc & "', '" & System.Environment.UserName & "', '" & Now & "', '', 'GATE 0: CM Needs To Assign DWG Number', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '', '', '" & username & "', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','','','','','','" & Now & "', '', 0, '" & Now & "', '', '" & Now & "')")
            Dim NewTopMDLRecordID As Integer
            da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID from tblLiveMDL Order By RecordID Desc", SqlConnection1)
            da.Fill(ds, "NewTopMDL")

            NewTopMDLRecordID = Val(ds.Tables("NewTopMDL").Rows(0).Item("RecordID"))

            OpenMDL = NewTopMDLRecordID

            ds.Tables("NewTopMDL").Clear()
            ds.Tables("NewTopMDL").Dispose()


            'Copy records in tblLiveMDLProejctsSystems from current revision to new
            da = New SqlClient.SqlDataAdapter("Select * from tblLiveMDLProjectsSystems Where MDLRecordID = '" & Val(Me.txtRecordID.Text) & "'", SqlConnection1)
            da.Fill(ds, "ProjSys")

            'Loop through and insert new into proj/sys table
            Dim g As Integer = 0

            While g <= ds.Tables("ProjSys").Rows.Count - 1

                u.ExecuteSQL(SqlConnection1, "INSERT into tblLiveMDLProjectsSystems (MDLRecordID, MDLNumber, DocumentNumber, Program, System) Values ('" & Val(NewTopMDLRecordID) & "', '" & Val(Me.txtMDLNumber.Text) & "', '" & txtDocumentNumber.Text & "', '" & ds.Tables("ProjSys").Rows(g).Item("Program") & "', '" & ds.Tables("ProjSys").Rows(g).Item("System") & "')")

                g = g + 1
            End While

            ds.Tables("ProjSys").Clear()
            ds.Tables("ProjSys").Dispose()

            'Populate the tblLiveMDLDetail table

            'Get the Programs and Systems Associated with the MDL

            da = New SqlClient.SqlDataAdapter("Select * from tblLiveMDLProjectsSystems Where MDLRecordID = '" & Val(NewTopMDLRecordID) & "'", SqlConnection1)
            da.Fill(ds, "PROJSYS")

            Dim z As Integer = 0
            'Loop through each Program and System, populate the MDL Detail Table.
            While z <= ds.Tables("PROJSYS").Rows.Count - 1
                'Populate MDL table
                If ds.Tables("PROJSYS").Rows(z).Item("System") = "Unspecified" Then
                    'Grab all records for program specified
                    'da = New SqlClient.SqlDataAdapter("SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' AND Status = 'GATE 6: Complete'", SqlConnection1)

                    da = New SqlClient.SqlDataAdapter("Select * from tblLIveMDLMileStone Where MDLRecordID = '" & Val(NewTopMDLRecordID) & "'", SqlConnection1)
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
                    ProgressBar1.Maximum = ds.Tables("Set").Rows.Count

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
                            u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLDetail (MDLRecordID, Revision, MDLNumber, DocumentNumber, LVL, DrawingNumber, DWgRevision, ActualFinishDate, DrawingTitle, Status, Notes, SystemDescription, DrawingType, LVLDesc, TopLVL, TopLVLDesc, LVLLVLDESC, Cancelled, DeferToNextMDL, ShowPreviousREv, OverrideDRNDetails, ShowRemarks, RemarksText, OverrideDRNText, ShowPreviousRevText) Values ('" & Val(NewTopMDLRecordID) & "', '" & DwgNewRev & "', '" & Val(Me.txtMDLNumber.Text) & "', '" & Me.txtDocumentNumber.Text & "', '" & LVL & "', '" & ds.Tables("Set").Rows(x).Item("DrawingNumber") & "', '" & ds.Tables("Set").Rows(x).Item("DwgRevision") & "', '" & ds.Tables("Set").Rows(x).Item("ActualFinishDate") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("DrawingTitle")) & "', '" & ds.Tables("Set").Rows(x).Item("Status") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("Notes")) & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("SystemDescription")) & "', '" & ds.Tables("Set").Rows(x).Item("DrawingType") & "', '" & LVLDesc & "', '" & TopLVL & "', '" & TopLVLDesc & "', '" & LVLLVLDesc & "', 'False', 'False', 'False', 'False', 'False',  '" & u.FTM(DRNADCN) & "', '', '')")
                        End If

                        x = x + 1
                    End While

                    ds.Tables("Set").Clear()
                    ds.Tables("Set").Dispose()


                Else
                    'Grab only those records for specific system.
                    'Grab all records for program specified
                    'da = New SqlClient.SqlDataAdapter("SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' AND SystemDescription = '" & ds.Tables("PROJSYS").Rows(z).Item("System") & "' AND Status = 'GATE 6: Complete'", SqlConnection1)

                    da = New SqlClient.SqlDataAdapter("Select * from tblLIveMDLMileStone Where MDLRecordID = '" & Val(NewTopMDLRecordID) & "'", SqlConnection1)
                    da.Fill(ds, "MS")


                    If ds.Tables("MS").Rows.Count = 0 Then
                        da = New SqlClient.SqlDataAdapter("SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' AND SystemDescription = '" & ds.Tables("PROJSYS").Rows(z).Item("System") & "'", SqlConnection1)
                    Else
                        Dim p As Integer = 0
                        Dim Str As String
                        While p <= ds.Tables("MS").Rows.Count - 1

                            If p = 0 Then
                                Str = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' AND SystemDescription = '" & ds.Tables("PROJSYS").Rows(z).Item("System") & "' And Priority = '" & ds.Tables("MS").Rows(p).Item("Milestone") & "'"
                            Else
                                Str = Str + " OR row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' AND SystemDescription = '" & ds.Tables("PROJSYS").Rows(z).Item("System") & "' And Priority = '" & ds.Tables("MS").Rows(p).Item("Milestone") & "'"
                            End If


                            p = p + 1
                        End While

                        da = New SqlClient.SqlDataAdapter(Str, SqlConnection1)
                    End If

                    ds.Tables("MS").Clear()
                    ds.Tables("MS").Dispose()

                    da.Fill(ds, "Set")
                    ProgressBar1.Maximum = ds.Tables("Set").Rows.Count

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
                            u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLDetail (MDLRecordID, Revision, MDLNumber, DocumentNumber, LVL, DrawingNumber, DWgRevision, ActualFinishDate, DrawingTitle, Status, Notes, SystemDescription, DrawingType, LVLDesc, TopLVL, TopLVLDesc, LVLLVLDESC, Cancelled, DeferToNextMDL, ShowPreviousREv, OverrideDRNDetails, ShowRemarks, RemarksText, OverrideDRNText, ShowPreviousRevText) Values ('" & Val(NewTopMDLRecordID) & "', '" & DwgNewRev & "', '" & Val(Me.txtMDLNumber.Text) & "', '" & Me.txtDocumentNumber.Text & "', '" & LVL & "', '" & ds.Tables("Set").Rows(x).Item("DrawingNumber") & "', '" & ds.Tables("Set").Rows(x).Item("DwgRevision") & "', '" & ds.Tables("Set").Rows(x).Item("ActualFinishDate") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("DrawingTitle")) & "', '" & ds.Tables("Set").Rows(x).Item("Status") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("Notes")) & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("SystemDescription")) & "', '" & ds.Tables("Set").Rows(x).Item("DrawingType") & "', '" & LVLDesc & "', '" & TopLVL & "', '" & TopLVLDesc & "', '" & LVLLVLDesc & "', 'False', 'False', 'False', 'False', 'False', '" & u.FTM(DRNADCN) & "', '', '')")
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
            Me.gbProgress.Visible = False
            ProgressBar1.Value = 0

            ds.Tables("PROJSYS").Clear()
            ds.Tables("PROJSYS").Dispose()

            'Now, open MDL on the MDL form by sending MDLRecordID to form.
            Dim frmLiveMDLCurrent As New frmLiveMDLCurrent
            frmLiveMDLCurrent.Show()

        End If
        ds.Tables("CHECK").Clear()
        ds.Tables("CHECK").Dispose()
    End Sub

    Private Sub btnMDLChangeParam_Click(sender As Object, e As EventArgs) Handles btnMDLChangeParam.Click
        MDLChangeRecordID = Me.txtRecordID.Text
        Dim frmMDLChange As New frmMDLChange
        frmMDLChange.ShowDialog()

        If Me.txtStatus.Text = "LOCKED" Or Me.txtStatus.Text = "REL" Then
            MsgBox("The MDL is in a released state.  You must rev the MDL to see the changes.")
        ElseIf Me.txtStatus.Text = "-" Then
            MsgBox("MDL has not be generated yet and is in a - status.  You must click the Open Rev button to move the MDL to WIP and populate the MDL.")

        Else

            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Notes = '' Where Notes Is Null")

            u.ExecuteSQL(SqlConnection1, "Delete from tblLiveMDLDetail Where MDLRecordID = '" & Val(Me.txtRecordID.Text) & "'")

            da = New SqlClient.SqlDataAdapter("Select * from tblLiveMDLProjectsSystems Where MDLRecordID = '" & Val(Me.txtRecordID.Text) & "'", SqlConnection1)
            da.Fill(ds, "PROJSYS")
            'u.ExecuteSQL(SqlConnection1, "Update tblLiveMDL Set LastRefresh = '" & Now & "' Where RecordID = '" & Val(OpenMDL) * "'")
            Dim z As Integer = 0
            'Loop through each Program and System, populate the MDL Detail Table.
            While z <= ds.Tables("PROJSYS").Rows.Count - 1
                'Populate MDL table
                If ds.Tables("PROJSYS").Rows(z).Item("System") = "Unspecified" Then
                    'Grab all records for program specified
                    da = New SqlClient.SqlDataAdapter("Select * from tblLIveMDLMileStone Where MDLRecordID = '" & Val(Me.txtRecordID.Text) & "'", SqlConnection1)
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
                                u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLDetail (MDLRecordID, Revision, MDLNumber, DocumentNumber, LVL, DrawingNumber, DWgRevision, ActualFinishDate, DrawingTitle, Status, Notes, SystemDescription, DrawingType, LVLDesc, TopLVL, TopLVLDesc, LVLLVLDESC, Cancelled, DeferToNextMDL, ShowPreviousREv, OverrideDRNDetails, ShowRemarks, RemarksText, OverrideDRNText, ShowPreviousRevText) Values ('" & Val(Me.txtRecordID.Text) & "', '" & Me.txtRev.Text & "', '" & Val(Me.txtMDLNumber.Text) & "', '" & Me.txtDocumentNumber.Text & "', '" & LVL & "', '" & ds.Tables("Set").Rows(x).Item("DrawingNumber") & "', '" & ds.Tables("Set").Rows(x).Item("DwgRevision") & "', '" & ds.Tables("Set").Rows(x).Item("ActualFinishDate") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("DrawingTitle")) & "', '" & ds.Tables("Set").Rows(x).Item("Status") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("Notes")) & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("SystemDescription")) & "', '" & ds.Tables("Set").Rows(x).Item("DrawingType") & "', '" & LVLDesc & "', '" & TopLVL & "', '" & TopLVLDesc & "', '" & LVLLVLDesc & "', 'False', 'False', 'False', 'False', 'False',  '" & u.FTM(DRNADCN) & "', '', '')")
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
                    da = New SqlClient.SqlDataAdapter("Select * from tblLIveMDLMileStone Where MDLRecordID = '" & Val(Me.txtRecordID.Text) & "'", SqlConnection1)
                    da.Fill(ds, "MS")
                    Dim p As Integer = 0

                    If ds.Tables("MS").Rows.Count = 0 Then
                        da = New SqlClient.SqlDataAdapter("SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' and SystemDescription = '" & ds.Tables("PROJSYS").Rows(z).Item("System") & "'", SqlConnection1)
                    Else

                        Dim Str As String
                        While p <= ds.Tables("MS").Rows.Count - 1

                            If p = 0 Then
                                Str = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev) AS derived WHERE row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' and Priority = '" & ds.Tables("MS").Rows(p).Item("Milestone") & "' and SystemDescription = '" & ds.Tables("PROJSYS").Rows(z).Item("System") & "'"
                            Else
                                Str = Str + " OR row_num = 1 AND Program = '" & ds.Tables("PROJSYS").Rows(z).Item("Program") & "' and Priority = '" & ds.Tables("MS").Rows(p).Item("Milestone") & "' and SystemDescription = '" & ds.Tables("PROJSYS").Rows(z).Item("System") & "'"
                            End If
                            p = p + 1
                        End While
                        da = New SqlClient.SqlDataAdapter(Str, SqlConnection1)
                        'MsgBox(Str)
                    End If


                    ds.Tables("MS").Clear()
                    ds.Tables("MS").Dispose()

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
                            If u.FTM(ds.Tables("Set").Rows(x).Item("ADCN")) = "0" Then
                                ADCN = ""
                            Else
                                ADCN = u.FTM(ds.Tables("Set").Rows(x).Item("ADCN"))
                            End If
                            DRNADCN = "DRN: " & u.FTM(ds.Tables("Set").Rows(x).Item("DRNADCN")) & "    ADCN:  " & u.FTM(ADCN)
                            u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLDetail (MDLRecordID, Revision, MDLNumber, DocumentNumber, LVL, DrawingNumber, DWgRevision, ActualFinishDate, DrawingTitle, Status, Notes, SystemDescription, DrawingType, LVLDesc, TopLVL, TopLVLDesc, LVLLVLDESC, Cancelled, DeferToNextMDL, ShowPreviousREv, OverrideDRNDetails, ShowRemarks, RemarksText, OverrideDRNText, ShowPreviousRevText) Values ('" & Val(Me.txtRecordID.Text) & "', '" & Me.txtRev.Text & "', '" & Val(Me.txtMDLNumber.Text) & "', '" & Me.txtDocumentNumber.Text & "', '" & LVL & "', '" & ds.Tables("Set").Rows(x).Item("DrawingNumber") & "', '" & ds.Tables("Set").Rows(x).Item("DwgRevision") & "', '" & ds.Tables("Set").Rows(x).Item("ActualFinishDate") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("DrawingTitle")) & "', '" & ds.Tables("Set").Rows(x).Item("Status") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("Notes")) & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("SystemDescription")) & "', '" & ds.Tables("Set").Rows(x).Item("DrawingType") & "', '" & LVLDesc & "', '" & TopLVL & "', '" & TopLVLDesc & "', '" & LVLLVLDesc & "', 'False', 'False', 'False', 'False', 'False', '" & u.FTM(DRNADCN) & "', '', '')")
                        End If

                        x = x + 1
                    End While

                    ds.Tables("Set").Clear()
                    ds.Tables("Set").Dispose()
                End If

                z = z + 1
            End While
            da = New SqlClient.SqlDataAdapter("select Distinct LVL from tblLiveMDLDetail Where MDLRecordID = '" & Val(Me.txtRecordID.Text) & "' Order By LVL Asc", SqlConnection1)
            da.Fill(ds, "L")

            Dim j As Integer = 0

            While j <= ds.Tables("L").Rows.Count - 1

                da = New SqlClient.SqlDataAdapter("Select Distinct SystemDescription from tblLiveMDLDetail Where MDLRecordID = '" & Val(Me.txtRecordID.Text) & "' AND LVL = '" & ds.Tables("L").Rows(j).Item("LVL") & "' Order By SystemDescription Asc", SqlConnection1)
                da.Fill(ds, "O")

                Dim inte As Integer = 1
                Dim f As Integer = 0

                While f <= ds.Tables("O").Rows.Count - 1
                    Dim syslvl As String
                    syslvl = ds.Tables("L").Rows(j).Item("LVL") & "." & inte
                    syslvl = syslvl & " " & ds.Tables("O").Rows(f).Item("SystemDescription")
                    u.ExecuteSQL(SqlConnection1, "Update tblLiveMDLDetail Set SystemDescription = '" & syslvl & "', SystemSeq = '" & Val(inte) & "' Where SystemDescription = '" & ds.Tables("O").Rows(f).Item("SystemDescription") & "' AND LVL = '" & ds.Tables("L").Rows(j).Item("LVL") & "' AND MDLRecordID = '" & Val(Me.txtRecordID.Text) & "'")
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
        End If


    End Sub
End Class