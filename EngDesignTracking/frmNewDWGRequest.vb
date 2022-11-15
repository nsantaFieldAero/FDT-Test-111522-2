Public Class frmNewDWGRequest
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmNewDWGRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString

        cboDrafter.Items.Insert(0, username)
        cboDrafter.SelectedIndex = 0

        cboWhiteBoardNumber.Items.Insert(0, "00")
        cboWhiteBoardNumber.SelectedIndex = 0

        'Load Revisions Information
        da = New SqlClient.SqlDataAdapter("Select * from tblRevisionsLookup Order By Sort Asc", SqlConnection1)
        da.Fill(ds, "Revisions")

        Dim i As Integer = 0
        While i <= ds.Tables("Revisions").Rows.Count - 1
            Me.cboDrawingRevision.Items.Add(ds.Tables("Revisions").Rows(i).Item("Rev"))
            i = i + 1
        End While

        ds.Tables("Revisions").Clear()
        ds.Tables("Revisions").Dispose()
        i = 0

        'Load DocumentType
        da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where Active = 'True' Order By DocumentType Asc", SqlConnection1)
        da.Fill(ds, "DocType")

        While i <= ds.Tables("DocType").Rows.Count - 1
            Me.cboDrawingType.Items.Add(ds.Tables("DocType").Rows(i).Item("DocumentType"))
            i = i + 1
        End While

        ds.Tables("DocType").Clear()
        ds.Tables("DocType").Dispose()

        i = 0

        'Load DocumentType
        da = New SqlClient.SqlDataAdapter("Select * from tblType Where Active = 'True' Order By Type Asc", SqlConnection1)
        da.Fill(ds, "Type")

        While i <= ds.Tables("Type").Rows.Count - 1
            Me.cboType.Items.Add(ds.Tables("Type").Rows(i).Item("Type"))
            i = i + 1
        End While

        ds.Tables("Type").Clear()
        ds.Tables("Type").Dispose()

        i = 0

        'Load AssignmentName
        da = New SqlClient.SqlDataAdapter("Select * from tblNameAssignment Where Active = 'True' Order By Name Asc", SqlConnection1)
        da.Fill(ds, "AssignmentName")

        While i <= ds.Tables("AssignmentName").Rows.Count - 1
            Me.cboDrafter.Items.Add(ds.Tables("AssignmentName").Rows(i).Item("Name"))
            i = i + 1
        End While

        ds.Tables("AssignmentName").Clear()
        ds.Tables("AssignmentName").Dispose()

        i = 0

        'Load AssignmentName
        da = New SqlClient.SqlDataAdapter("Select * from tblDRNADCN Where Active = 'True' Order By Seq Asc", SqlConnection1)
        da.Fill(ds, "DRNADCN")

        While i <= ds.Tables("DRNADCN").Rows.Count - 1
            Me.cboDRNADCN.Items.Add(ds.Tables("DRNADCN").Rows(i).Item("Name"))
            i = i + 1

        End While

        ds.Tables("DRNADCN").Clear()
        ds.Tables("DRNADCN").Dispose()

        i = 0

        'Load DocumentType
        da = New SqlClient.SqlDataAdapter("Select * from tblWhiteBoardNumber Where Active = 'True' Order By Sequence Asc", SqlConnection1)
        da.Fill(ds, "WB")

        While i <= ds.Tables("WB").Rows.Count - 1
            Me.cboWhiteBoardNumber.Items.Add(ds.Tables("WB").Rows(i).Item("Name"))
            i = i + 1
        End While

        ds.Tables("WB").Clear()
        ds.Tables("WB").Dispose()


        'Load Programs Information
        da = New SqlClient.SqlDataAdapter("Select * from tblProgram Order By ProgramName", SqlConnection1)
        da.Fill(ds, "Programs")

        Dim p As Integer = 0
        While p <= ds.Tables("Programs").Rows.Count - 1
            Me.cboProgram.Items.Add(ds.Tables("Programs").Rows(p).Item("ProgramName"))
            p = p + 1
        End While

        ds.Tables("Programs").Clear()
        ds.Tables("Programs").Dispose()

        Me.txtForecastStartDate.Value = Now

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If cboDrawingRevision.Text = "Select Required" Then
            MsgBox("You must select a revision to continue.  For new, select IR or P#.  Please select the revision and then click submit again.")
            Exit Sub

        End If
        'If dtpDrafterPlanned.Value <= txtForecastStartDate.Value Then
        '    MsgBox("Please enter a drafter planned complete date that Is bigger than the forecast start date")
        '    Exit Sub
        'End If
        If cboDrafter.Text = "" Then
            MsgBox("Please enter a drafter")
            Exit Sub
        End If

        If cboDRNADCN.Text <> "" Then
            Me.cboNewRework.Text = "Rework Drawing"
        End If

        'If they select OKC, the following 3 fields, Flammability, Stress, Avionics and Mechanical, must default to "Not Required".  I will add that text and functionality to these fields in the SQL passage below
        'Also, in the following the various dates are calculated to be entered in the UPDATEs below, based on if the user selects OKC or Calgary/Toronto for the location
        Dim NotRequired As String
        'OKC dates
        Dim EngineerPlannedComplete As Date = DateAdd("d", 3, dtpDrafterPlanned.Value)
        Dim SrEngineerPlannedComplete As Date = DateAdd("d", 3, EngineerPlannedComplete)
        Dim PlannedFinishDate As Date
        Dim ForecastFinishDate As Date
        'Toronto and Calgary dates
        Dim FlammabilityPlannedComplete As Date = DateAdd("d", 3, EngineerPlannedComplete)
        Dim StressPlannedComplete As Date = DateAdd("d", 3, FlammabilityPlannedComplete)
        Dim AvionicsPlannedComplete As Date = DateAdd("d", 3, StressPlannedComplete)
        Dim MechanicalPlannedComplete As Date = DateAdd("d", 3, AvionicsPlannedComplete)
        'Canada and OKC
        Dim ReleaserPlannedComplete As Date


        If cboLocation.Text = "OKC" Then
            NotRequired = "Not Required"
            ReleaserPlannedComplete = DateAdd("d", 3, SrEngineerPlannedComplete)
            PlannedFinishDate = ReleaserPlannedComplete
            ForecastFinishDate = ReleaserPlannedComplete
            FlammabilityPlannedComplete = "1/1/1900"
            StressPlannedComplete = "1/1/1900"
            AvionicsPlannedComplete = "1/1/1900"
            MechanicalPlannedComplete = "1/1/1900"

            'If Location is Calgary or Toronto
        ElseIf cboLocation.Text = "Calgary" Or cboLocation.Text = "Toronto" Then
            NotRequired = " "
            ReleaserPlannedComplete = DateAdd("d", 3, MechanicalPlannedComplete)
            SrEngineerPlannedComplete = "1/1/1900"
            PlannedFinishDate = "1/1/1900"

        ElseIf cboLocation.Text = "" Then
            MsgBox("Please select a location")
            Exit Sub
        End If


        'Check and see if Drawing Number/Drawing Revision already exist If drawing number is not blank

        If Me.txtDrawingNumber.Text <> "" Then
            da = New SqlClient.SqlDataAdapter("Select * from tblDrawings where DrawingNumber = '" & Me.txtDrawingNumber.Text & "' And DwgRevision = '" & Me.cboDrawingRevision.Text & "'", SqlConnection1)
            da.Fill(ds, "DwgExist")

            If ds.Tables("DWGExist").Rows.Count > 0 And Me.cboDRNADCN.Text = "" Then
                MsgBox("The Drawing Number/Revision Combo Exists Already.  You must specify a different drawing number/revision.")
                Exit Sub
            Else
                'EDIT 04/17/19: when they enter a new drawing if location is OKC(cboLocation.text = "OKC"; above) make Flammability, Stress, Avionics and Mechanical equal to "Not Required"
                u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawings (DrawingNumber, DocumentType, DwgRequestBy, DwgRequestDate, DwgReqDate, Status, Location, Type, DrawingTitle, Program, SystemDescription, DrawingType, DWGRevision, ActualFinishDate, ForecastStartDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, DrafterComplete, DrafterPlannedCompleteDate, EngineerComplete, SrEngineerComplete, ReleaserCompelte, FlammabilityComplete, StressComplete, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate,FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate, AvionicsComplete, AvionicsPlannedComplete, MechanicalComplete, MechanicalPlannedComplete, WONumber, Flammability, Stress, Avionics, Mechanical, NextHigherAssembly, Drafter, InstallationDrawing, WhiteBoardNumber, DRNADCN, FAAProjectNo, PSCPDocsRequired, CompanyFlightTestRequired, NewRework, PercentComplete) Values ('" & Me.txtDrawingNumber.Text & "', '" & Me.cboDrawingType.Text & "', '" & System.Environment.UserName & "', '" & Now & "', '" & Now & "', 'GATE 0: CM Needs To Assign DWG Number', '" & Me.cboLocation.Text & "', '" & Me.cboType.Text & "', '" & u.FTM(Me.txtDrawingTitle.Text) & "', '" & Me.cboProgram.Text & "', '" & u.FTM(Me.cboSystemDescription.Text) & "', '" & Me.cboDrawingType.Text & "', '" & Me.cboDrawingRevision.Text & "', '1/1/1900', '" & txtForecastStartDate.Text & "', '" & ForecastFinishDate & "', '" & PlannedFinishDate & "', '" & txtEstimatedDurationHours.Text & "', '1/1/1900', '" & Me.dtpDrafterPlanned.Value & "', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '" & EngineerPlannedComplete & "', '" & SrEngineerPlannedComplete & "', '" & FlammabilityPlannedComplete & "', '" & StressPlannedComplete & "', '" & ReleaserPlannedComplete & "', '1/1/1900', '" & AvionicsPlannedComplete & "', '1/1/1900', '" & MechanicalPlannedComplete & "', '" & u.FTM(Me.txtWONo.Text) & "', '" & NotRequired & "', '" & NotRequired & "', '" & NotRequired & "', '" & NotRequired & "', '" & Me.txtboxNextHigherAssembly.Text & "', '" & Me.cboDrafter.Text & "', '" & u.FTM(Me.txtInstallationDrawing.Text) & "', '" & Me.cboWhiteBoardNumber.Text & "', '" & cboDRNADCN.Text & "', '" & Me.txtFAAProjectNo.Text & "', '" & Me.cboPSCPDocsRequired.Text & "', '" & Me.cboCompanyFlightTestRequired.Text & "', '" & Me.cboNewRework.Text & "', '0')")
                MsgBox("Drawing Request Has Been Entered.")
                'If Me.cboProgram.Text = "Jaguar" Then
                'u.SendEmail("jwebster@fieldaero.com", "rduwel@fieldaero.com; jwebster@fieldaero.com", "DWG Request Added", "A new record has just been added.  A drawing number needs to be assigned.  Drawing Number: " + Me.txtDrawingNumber.Text + "  Drawing Title: " + Me.txtDrawingTitle.Text + "  System Desc: " + Me.txtSystemDescription.Text)
                'u.SendEmail("jwebster@fieldaero.com", "cjohnson@fieldaero.com", "DWG Request Added", "A new record has just been added.  Please assign the JDE Charge code sequence numbers and create folders.  Drawing Number: " + Me.txtDrawingNumber.Text + "  Drawing Title: " + Me.txtDrawingTitle.Text + "  System Desc: " + Me.txtSystemDescription.Text)
                'u.SendEmail("jwebster@fieldaero.com", "stelford@fieldaero.com", "DWG Request Added", "A new record has just been added.  Please assign the JDE Charge code sequence numbers and create folders.Drawing Number: " + Me.txtDrawingNumber.Text + "  Drawing Title: " + Me.txtDrawingTitle.Text + "  System Desc: " + Me.txtSystemDescription.Text)
                'End If


                'Commenting the two lines below because it opens a new instance of the frmGridLookup page every time the submit button is hit
                'Dim frmGridLookup As New frmGridLookUp
                'frmGridLookUp.Show()
                Me.Close()
            End If

        Else
            'EDIT 04/17/19: when they enter a new drawing if location is OKC(cboLocation.text = "OKC"; above) make Flammability, Stress, Avionics and Mechanical equal to "Not Required"
            u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawings (DrawingNumber, DocumentType, DwgRequestBy, DwgRequestDate, DwgReqDate, Status, Location, Type, DrawingTitle, Program, SystemDescription, DrawingType, DWGRevision, ActualFinishDate, ForecastStartDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, DrafterComplete, DrafterPlannedCompleteDate, EngineerComplete, SrEngineerComplete, ReleaserCompelte, FlammabilityComplete, StressComplete, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate,FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate, AvionicsComplete, AvionicsPlannedComplete, MechanicalComplete, MechanicalPlannedComplete, WONumber, Flammability, Stress, Avionics, Mechanical, NextHigherAssembly, Drafter, InstallationDrawing, WhiteBoardNumber, DRNADCN, FAAProjectNo, PSCPDocsRequired, CompanyFlightTestRequired, NewRework, PercentComplete) Values ('" & Me.txtDrawingNumber.Text & "', '" & Me.cboDrawingType.Text & "', '" & System.Environment.UserName & "', '" & Now & "', '" & Now & "', 'GATE 0: CM Needs To Assign DWG Number', '" & Me.cboLocation.Text & "', '" & Me.cboType.Text & "', '" & u.FTM(Me.txtDrawingTitle.Text) & "', '" & Me.cboProgram.Text & "', '" & u.FTM(Me.cboSystemDescription.Text) & "', '" & Me.cboDrawingType.Text & "', '" & Me.cboDrawingRevision.Text & "', '1/1/1900', '" & txtForecastStartDate.Text & "', '" & ForecastFinishDate & "', '" & PlannedFinishDate & "', '" & txtEstimatedDurationHours.Text & "', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '" & EngineerPlannedComplete & "', '" & SrEngineerPlannedComplete & "', '" & FlammabilityPlannedComplete & "', '" & StressPlannedComplete & "', '" & ReleaserPlannedComplete & "', '1/1/1900', '" & AvionicsPlannedComplete & "', '1/1/1900', '" & MechanicalPlannedComplete & "', '" & u.FTM(Me.txtWONo.Text) & "', '" & NotRequired & "', '" & NotRequired & "', '" & NotRequired & "', '" & NotRequired & "', '" & Me.txtboxNextHigherAssembly.Text & "', '" & Me.cboDrafter.Text & "', '" & u.FTM(Me.txtInstallationDrawing.Text) & "', '" & Me.cboWhiteBoardNumber.Text & "', '" & cboDRNADCN.Text & "', '" & Me.txtFAAProjectNo.Text & "', '" & Me.cboPSCPDocsRequired.Text & "', '" & Me.cboCompanyFlightTestRequired.Text & "', '" & Me.cboNewRework.Text & "', '0')")
            MsgBox("Drawing Request Has Been Entered.")
            'If Me.cboProgram.Text = "Jaguar" Then
            'u.SendEmail("jwebster@fieldaero.com", "rduwel@fieldaero.com", "DWG Request Added", "A new record has just been added.  A drawing number needs to be assigned.  Drawing Number: " + Me.txtDrawingNumber.Text + "  Drawing Title: " + Me.txtDrawingTitle.Text + "  System Desc: " + Me.txtSystemDescription.Text)
            'u.SendEmail("jwebster@fieldaero.com", "cjohnson@fieldaero.com", "DWG Request Added", "A new record has just been added.  Please assign the JDE Charge code sequence numbers and create folders.  Drawing Number: " + Me.txtDrawingNumber.Text + "  Drawing Title: " + Me.txtDrawingTitle.Text + "  System Desc: " + Me.txtSystemDescription.Text)
            'u.SendEmail("jwebster@fieldaero.com", "stelford@fieldaero.com", "DWG Request Added", "A new record has just been added.  Please assign the JDE Charge code sequence numbers and create folders.Drawing Number: " + Me.txtDrawingNumber.Text + "  Drawing Title: " + Me.txtDrawingTitle.Text + "  System Desc: " + Me.txtSystemDescription.Text)
            'End If

            'Commenting the two lines below because it opens a new instance of the frmGridLookup page every time the submit button is hit
            'Dim frmGridLookup As New frmGridLookUp
            'frmGridLookup.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub cboProgram_TextChanged(sender As Object, e As EventArgs) Handles cboProgram.TextChanged

        'Get FAA Project Number
        da = New SqlClient.SqlDataAdapter("Select FAAProjectNo from tblProgramCertification Where Program = '" & cboProgram.Text & "'", SqlConnection1)
        da.Fill(ds, "GetProjNo")

        If ds.Tables("GetProjNo").Rows.Count > 0 Then
            Me.txtFAAProjectNo.Text = ds.Tables("GetProjNo").Rows(0).Item("FAAProjectNo")

            ds.Tables("GetProjNo").Clear()
            ds.Tables("GetProjNo").Dispose()

        End If

        'Get SystemDescription Value Possibilities.
        da = New SqlClient.SqlDataAdapter("Select SystemDescription from tblSystemDescription Where Program = '" & cboProgram.Text & "' and Active = 'True' Order By SystemDescription Asc", SqlConnection1)
        da.Fill(ds, "GetSys")

        Me.cboSystemDescription.Items.Clear()

        If ds.Tables("GetSys").Rows.Count > 0 Then
            Dim z As Integer = 0

            While z <= ds.Tables("GetSys").Rows.Count - 1
                Me.cboSystemDescription.Items.Add(ds.Tables("GetSys").Rows(z).Item("SystemDescription"))
                z = z + 1
            End While

            ds.Tables("GetSys").Clear()
            ds.Tables("GetSys").Dispose()

        End If
    End Sub

    Private Sub cboDrawingType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDrawingType.SelectedIndexChanged
        'Is the document type a drawing or a report?
        Me.cboDrawingRevision.Enabled = True
        MsgBox("Please select document revision now.")


    End Sub

    Private Sub cboDrawingRevision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDrawingRevision.SelectedIndexChanged

        da = New SqlClient.SqlDataAdapter("Select Classification from tblDocumentType Where DocumentType = '" & cboDrawingType.Text & "'", SqlConnection1)
        da.Fill(ds, "Class")

        If ds.Tables("Class").Rows.Count > 0 Then
            If cboDrawingRevision.Text = "IR" Or cboDrawingRevision.Text Like "P1" Or cboDrawingRevision.Text Like "P2" Or cboDrawingRevision.Text Like "P3" Or cboDrawingRevision.Text Like "P4" Or cboDrawingRevision.Text Like "P5" Or cboDrawingRevision.Text Like "P6" Or cboDrawingRevision.Text Like "P7" Or cboDrawingRevision.Text Like "P8" Or cboDrawingRevision.Text Like "P9" Or cboDrawingRevision.Text Like "P10" Or cboDrawingRevision.Text Like "P11" Or cboDrawingRevision.Text Like "P12" Or cboDrawingRevision.Text Like "P13" Or cboDrawingRevision.Text Like "P14" Or cboDrawingRevision.Text Like "P15" Or cboDrawingRevision.Text Like "P16" Or cboDrawingRevision.Text Like "P17" Or cboDrawingRevision.Text Like "P18" Or cboDrawingRevision.Text Like "P19" Or cboDrawingRevision.Text Like "P20" Or cboDrawingRevision.Text = "NC" Or cboDrawingRevision.Text = "-" Then
                If ds.Tables("Class").Rows(0).Item("Classification") = "Report" Then
                    cboNewRework.Text = "New Report"
                Else
                    cboNewRework.Text = "New Drawing"
                End If
            Else
                If ds.Tables("Class").Rows(0).Item("Classification") = "Report" Then
                    cboNewRework.Text = "Rework Report"
                Else
                    cboNewRework.Text = "Rework Drawing"
                End If
            End If
        Else
            MsgBox("You must first select a valid document type.")
        End If

        ds.Tables("Class").Clear()
        ds.Tables("Class").Dispose()

        If cboDRNADCN.Text <> "" Then
            cboNewRework.Text = "Rework Drawing"
        End If


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        da = New SqlClient.SqlDataAdapter("Select * from tblDrawings Where DrawingType = 'Wire Diagram'", SqlConnection1)
        da.Fill(ds, "CHECKME")

        Dim Type As String

        Dim z As Integer = 0

        While z <= ds.Tables("CHECKME").Rows.Count - 1

            'da = New SqlClient.SqlDataAdapter("Select Classification from tblDocumentType Where DocumentType = '" & ds.Tables("CHECKME").Rows(z).Item("DrawingType") & "'", SqlConnection1)
            'da.Fill(ds, "Class")

            'If ds.Tables("Class").Rows.Count > 0 Then
            If ds.Tables("CHECKME").Rows(z).Item("DWGRevision") = "IR" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P1" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P2" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P3" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P4" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P5" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P6" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P7" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P8" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P9" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P10" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P11" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P12" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P13" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P14" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P15" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P16" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P17" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P18" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P19" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") Like "P20" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") = "NC" Or ds.Tables("CHECKME").Rows(z).Item("DWGRevision") = "-" Then
                'If ds.Tables("CHECKME").Rows(z).Item("DrawingType") = "Report" Then
                Type = "New Drawing"
                'Else
                '    Type = "New Drawing"
                'End If
            Else
                'If ds.Tables("CHECKME").Rows(z).Item("Classification") = "Report" Then
                Type = "Rework Drawing"
                ' Else
                'Type = "Rework Drawing"
                'End If
                'End If
                'Else
                'Type = "ERROR"
            End If

            u.ExecuteSQL(SqlConnection1, "UPDATE tblDrawings Set NewRework = '" & Type & "' Where RecordID = '" & Val(ds.Tables("CHECKME").Rows(z).Item("RecordID")) & "'")

            'ds.Tables("Class").Clear()
            'ds.Tables("Class").Dispose()

            z = z + 1
        End While
        MsgBox("Done.")
    End Sub
End Class