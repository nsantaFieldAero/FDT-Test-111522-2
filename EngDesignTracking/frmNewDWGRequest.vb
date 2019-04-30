Public Class frmNewDWGRequest
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmNewDWGRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString

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
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If dtpDrafterPlanned.Value <= txtForecastStartDate.Value Then
            MsgBox("Please enter a drafter planned complete date that is bigger than the forecast start date")
            Exit Sub
        End If
        If txtboxDrafter.Text = "" Then
            MsgBox("Please enter a drafter")
            Exit Sub
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

            If ds.Tables("DWGExist").Rows.Count > 0 Then
                MsgBox("The Drawing Number/Revision Combo Exists Already.  You must specify a different drawing number/revision.")
                Exit Sub
            Else
                'EDIT 04/17/19: when they enter a new drawing if location is OKC(cboLocation.text = "OKC"; above) make Flammability, Stress, Avionics and Mechanical equal to "Not Required"
                u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawings (DrawingNumber, DocumentType, DwgRequestBy, DwgRequestDate, Status, Location, Type, DrawingTitle, Program, SystemDescription, DrawingType, DWGRevision, ActualFinishDate, ForecastStartDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, DrafterComplete, DrafterPlannedCompleteDate, EngineerComplete, SrEngineerComplete, ReleaserCompelte, FlammabilityComplete, StressComplete, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate,FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate, AvionicsComplete, AvionicsPlannedComplete, MechanicalComplete, MechanicalPlannedComplete, WONumber, Flammability, Stress, Avionics, Mechanical, NextHigherAssembly) Values ('" & Me.txtDrawingNumber.Text & "', 'Drawing Request', '" & System.Environment.UserName & "', '" & Now & "', 'GATE 0: CM Needs To Assign DWG Number', '" & Me.cboLocation.Text & "', '" & Me.cboType.Text & "', '" & u.FTM(Me.txtDrawingTitle.Text) & "', '" & Me.cboProgram.Text & "', '" & u.FTM(Me.txtSystemDescription.Text) & "', '" & Me.cboDrawingType.Text & "', '" & Me.cboDrawingRevision.Text & "', '1/1/1900', '" & txtForecastStartDate.Text & "', '" & ForecastFinishDate & "', '" & PlannedFinishDate & "', '" & txtEstimatedDurationHours.Text & "', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '" & EngineerPlannedComplete & "', '" & SrEngineerPlannedComplete & "', '" & FlammabilityPlannedComplete & "', '" & StressPlannedComplete & "', '" & ReleaserPlannedComplete & "', '1/1/1900', '" & AvionicsPlannedComplete & "', '1/1/1900', '" & MechanicalPlannedComplete & "', '" & u.FTM(Me.txtWONo.Text) & "', '" & NotRequired & "', '" & NotRequired & "', '" & NotRequired & "', '" & NotRequired & "', '" & Me.txtboxNextHigherAssembly.Text & "')")
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
            u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawings (DrawingNumber, DocumentType, DwgRequestBy, DwgRequestDate, Status, Location, Type, DrawingTitle, Program, SystemDescription, DrawingType, DWGRevision, ActualFinishDate, ForecastStartDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, DrafterComplete, DrafterPlannedCompleteDate, EngineerComplete, SrEngineerComplete, ReleaserCompelte, FlammabilityComplete, StressComplete, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate,FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate, AvionicsComplete, AvionicsPlannedComplete, MechanicalComplete, MechanicalPlannedComplete, WONumber, Flammability, Stress, Avionics, Mechanical, NextHigherAssembly) Values ('" & Me.txtDrawingNumber.Text & "', 'Drawing Request', '" & System.Environment.UserName & "', '" & Now & "', 'GATE 0: CM Needs To Assign DWG Number', '" & Me.cboLocation.Text & "', '" & Me.cboType.Text & "', '" & u.FTM(Me.txtDrawingTitle.Text) & "', '" & Me.cboProgram.Text & "', '" & u.FTM(Me.txtSystemDescription.Text) & "', '" & Me.cboDrawingType.Text & "', '" & Me.cboDrawingRevision.Text & "', '1/1/1900', '" & txtForecastStartDate.Text & "', '" & ForecastFinishDate & "', '" & PlannedFinishDate & "', '" & txtEstimatedDurationHours.Text & "', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '1/1/1900', '" & EngineerPlannedComplete & "', '" & SrEngineerPlannedComplete & "', '" & FlammabilityPlannedComplete & "', '" & StressPlannedComplete & "', '" & ReleaserPlannedComplete & "', '1/1/1900', '" & AvionicsPlannedComplete & "', '1/1/1900', '" & MechanicalPlannedComplete & "', '" & u.FTM(Me.txtWONo.Text) & "', '" & NotRequired & "', '" & NotRequired & "', '" & NotRequired & "', '" & NotRequired & "', '" & Me.txtboxNextHigherAssembly.Text & "')")
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


End Class