Imports System.Text

Public Class frmEngWorkflowAddFormB
    Dim ds As New DataSet
    Dim da As SqlClient.SqlDataAdapter
    Dim NeedsAssigned As String = ""
    Dim FinalDocNumber As String = ""
    Dim CanadaOrUSA As String
    Dim TypeOfDoc As String = ""
    Dim initialClick As Boolean = False
    Dim DocTypeSelected As String
    Dim SeriesSelected As String
    Dim USAReportDocSeqIdentifier As String
    Dim USADrawingDocSeqIdentifier As String
    Dim CanadaReportDocSeqIdentifier As String
    Dim CanadaDrawingDocSeqIdentifier As String
    Dim PrefixIncreasedByOne As String
    Dim DrawingOrReport As String
    'Dim docTypeNoLetters As String
    Dim CanadaReportTrailing As String = ""
    Dim NextPrefixReportCanada As String = ""
    Dim NextPrefixDrawingCanada As String = ""
    Dim NextPrefixReportUSA As String = ""
    Dim NextPrefixDrawingUSA As String = ""
    Dim MiscOrIssueNumber As String = ""
    Dim DocTypeSelectedForMDL As String = ""
    Dim LoopedAlreadyForTrailingZero As String = ""
    Dim LastSequenceReached As String = ""
    Dim ClassificationTypeAndLoc As String = ""
    Dim MessageAlreadyDisplayed As String = ""
    Dim DocTypeSelectedLevelThree As String = ""
    Dim NoPrefix As String
    Dim ProgramNumber As String = ""
    Dim SelectedDocType As String = ""
    Dim UpdateDocType As String = ""
    Dim UpdateDocTypeLevelThree As String = ""
    Dim UpdateSeries As String = ""
    Dim ProjectNameSelected As String = ""
    Dim ProjectNumberSelected As String = ""
    Dim ProgramNameSelected As String = ""
    Dim ProgramNumberSelected As String = ""
    Dim FirstTimeMiscClicked As String = ""
    Dim DocTypePrefixEmpty As Boolean

    Private Sub frmEngWorkflowAddFormB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim userLocation As String = ""
        txtDocNumber.Text = ""
        initialClick = False
        MiscOrIssueNumber = ""
        'Hide Series
        lblSeries.Visible = False
        TreeView2.Visible = False
        btnJASCCodes.Visible = False
        lblTextDocTypeSelected.Text = ""
        lblTextSeriesSelected.Text = ""
        lblDocTypeSelected.Text = ""
        lblDocTypeSelectedLevelTwo.Text = ""
        lblSeriesSelected.Text = ""
        btnIssueNumber.Enabled = False

        If CreateOrModifyDocNum = "Modify" Then
            btnDelete.Visible = True
            lblDocTypeExisting.Visible = True
            lblSeriesExisting.Visible = True
            btnContinue.Enabled = True
            cboProject.Visible = True
        Else
            btnDelete.Visible = False
            lblDocTypeExisting.Visible = False
            lblSeriesExisting.Visible = False
            lblDocNumToModify.Text = ""
            btnContinue.Enabled = False
            cboProject.Visible = False
            TreeView1.Visible = False
            TreeView2.Visible = False
        End If


        SqlConnection1.ConnectionString = sqlString


        ''Populate the Program drop-down according to the location of the user
        'If Loc = "Toronto" Or Loc = "Calgary" Then
        '    userLocation = "Field Aerospace (Canada)"
        'ElseIf Loc = "OKC" Then
        '    userLocation = "Field Aerospace (OKC)"
        'End If
        'da = New SqlClient.SqlDataAdapter("Select * from tblProjects Where DocNumbering = '" & userLocation & "' Order By ProjectName", SqlConnection1)


        'Populate the Program drop-down. Before it was populated according to the location of the user(see above uncommented stuff)
        da = New SqlClient.SqlDataAdapter("Select * from tblProgram Where Active = 'True' Order By ProgramName", SqlConnection1)
        da.Fill(ds, "Programs")

        Dim p As Integer = 0
        While p <= ds.Tables("Programs").Rows.Count - 1
            Me.cboProgram.Items.Add(ds.Tables("Programs").Rows(p).Item("ProjectNumber") & " - " & ds.Tables("Programs").Rows(p).Item("ProgramName"))
            p = p + 1
        End While

        ds.Tables("Programs").Clear()
        ds.Tables("Programs").Dispose()


        'Populate System drop-down
        'ProgramDocNumToModify actually contains Project
        da = New SqlClient.SqlDataAdapter("Select SystemDescription from tblSystemDescription Where Program = '" & ProgramDocNumToModify & "' and Active = 'True' Order By SystemDescription Asc", SqlConnection1)
        da.Fill(ds, "GetSys")
        Me.cboSystem.Items.Clear()
        If ds.Tables("GetSys").Rows.Count > 0 Then
            Dim z As Integer = 0

            While z <= ds.Tables("GetSys").Rows.Count - 1
                Me.cboSystem.Items.Add(ds.Tables("GetSys").Rows(z).Item("SystemDescription"))
                z = z + 1
            End While

            ds.Tables("GetSys").Clear()
            ds.Tables("GetSys").Dispose()
        End If


        'Populate Drafter drop-down
        Dim i As Integer = 0
        da = New SqlClient.SqlDataAdapter("Select * from tblNameAssignment Where Active = 'True' Order By Name Asc", SqlConnection1)
        da.Fill(ds, "Drafter")

        While i <= ds.Tables("Drafter").Rows.Count - 1
            'cboDrafter.Items.Add(ds.Tables("Drafter").Rows(i).Item("Name"))
            cboDrafter.Properties.Items.Add(ds.Tables("Drafter").Rows(i).Item("Name"))
            i = i + 1
        End While

        ds.Tables("Drafter").Clear()
        ds.Tables("Drafter").Dispose()


        'Populate Resource Type drop-down
        da = New SqlClient.SqlDataAdapter("Select * from tblType Where Active = 'True' Order By Type Asc", SqlConnection1)
        da.Fill(ds, "Type")
        Dim a As String = 0
        While a <= ds.Tables("Type").Rows.Count - 1
            cboResourceType.Items.Add(ds.Tables("Type").Rows(a).Item("Type"))
            a = a + 1
        End While

        ds.Tables("Type").Clear()
        ds.Tables("Type").Dispose()


        'Populate Milestone drop-down
        If CreateOrModifyDocNum = "Modify" Then
            da = New SqlClient.SqlDataAdapter("Select Name from tblPriority Where Program = '" & ProgramDocNumToModify & "' And Active = 'True' Order By Name", SqlConnection1)
            da.Fill(ds, "Milestone")
            Dim h As String = 0
            cboMilestone.Items.Clear()
            While h <= ds.Tables("Milestone").Rows.Count - 1
                cboMilestone.Items.Add(ds.Tables("Milestone").Rows(h).Item("Name"))
                h = h + 1
            End While

            ds.Tables("Milestone").Clear()
            ds.Tables("Milestone").Dispose()
        End If


        'Get the Series and Program (ProgramReal)
        da = New SqlClient.SqlDataAdapter("Select Series, ProgramReal from tblDrawings Where DrawingNumber = '" & DocNumberDocNumToModify & "' And RecordID = '" & RecordIdDocNumToModify & "'", SqlConnection1)
        da.Fill(ds, "Series")
        If ds.Tables("Series").Rows.Count > 0 Then
            If IsDBNull(ds.Tables("Series").Rows(0).Item("Series")) Then
                SeriesDocNumToModify = ""
            Else
                SeriesDocNumToModify = ds.Tables("Series").Rows(0).Item("Series")
            End If

            ProgramRealDocNumToModify = ds.Tables("Series").Rows(0).Item("ProgramReal")
        End If
        ds.Tables("Series").Clear()
        ds.Tables("Series").Dispose()


        'If document is being modified and not created fill out the combos and textboxes with the pre-existing entries(from Form A)
        If CreateOrModifyDocNum = "Modify" Then

            '------------------------------------------------------------
            'This will display what was selected for Program in Form A: the full text - programNumber + programName
            da = New SqlClient.SqlDataAdapter("Select ProgramName, ProjectNumber From tblProgram Where ProgramName = '" & ProgramRealDocNumToModify & "'", SqlConnection1)
            da.Fill(ds, "Programs")

            If ds.Tables("Programs").Rows.Count > 0 Then
                ProgramRealDocNumToModify = ds.Tables("Programs").Rows(0).Item("ProjectNumber") & " - " & ds.Tables("Programs").Rows(0).Item("ProgramName")
                ds.Tables("Programs").Clear()
                ds.Tables("Programs").Dispose()

                cboProgram.Text = ProgramRealDocNumToModify

                'This 3 lines are used in case the user does not make any changes to Program
                Dim index As Integer = ProgramRealDocNumToModify.IndexOf("-")
                ProgramNameSelected = ProgramRealDocNumToModify.Substring(index + 2)
                ProgramNumberSelected = ProgramRealDocNumToModify.Substring(0, ProgramRealDocNumToModify.IndexOf("-") - 1)

            Else
                cboProgram.Text = ProgramRealDocNumToModify

                ProgramNameSelected = ProgramRealDocNumToModify
                ProgramNumberSelected = ProgramRealDocNumToModify
            End If

            '---------------------------------------------------------


            '---------------------------------------------------------
            'This will display what was selected for Project in Form A: the full text - projectNumber + projectName
            '2 Lines ADDED 08/02
            'This is to get the initial value of ProgramDocNumToModify because it is then used in the ResetOrNot function
            Dim projectOfDocToModify As String = ProgramDocNumToModify

            da = New SqlClient.SqlDataAdapter("Select ProjectName, ProjectNumber From tblProjects Where ProjectName = '" & ProgramDocNumToModify & "'", SqlConnection1)
            da.Fill(ds, "Projects")
            If ds.Tables("Projects").Rows.Count > 0 Then
                ProgramDocNumToModify = ds.Tables("Projects").Rows(0).Item("ProjectNumber") & " - " & ds.Tables("Projects").Rows(0).Item("ProjectName")
                ds.Tables("Projects").Clear()
                ds.Tables("Projects").Dispose()
            End If

            'This 3 lines are used in case the user does not make any changes to Project
            If ProgramDocNumToModify <> "" Then
                Dim indexTwo As Integer = ProgramDocNumToModify.IndexOf("-")
                ProjectNameSelected = ProgramDocNumToModify.Substring(indexTwo + 2)
                ProjectNumberSelected = ProgramDocNumToModify.Substring(0, ProgramDocNumToModify.IndexOf("-") - 1)
            End If

            cboProject.Text = ProgramDocNumToModify     'ProgramDocNumToModify actually contains Project. No need to change this line

            '2 Lines ADDED 08/02
            'Make ProgramDocNumToModify equal to the initial value since it is then used in the ResetOrNot function
            ProgramDocNumToModify = projectOfDocToModify
            '------------------------------------------------------


            lblDocumentNum.Text = DocNumberDocNumToModify
            cboResourceType.Text = ResourceTypeDocNumToModify


            lblDocTypeExisting.Text = "Pre-Existing: " & DocTypeDocNumToModify

            If SeriesDocNumToModify <> "" Then
                lblSeriesExisting.Text = "Pre-Existing: " & SeriesDocNumToModify
            End If

            txtDocNumber.Text = DocNumberDocNumToModify
            cboSystem.Text = SystemDocNumToModify
            txtTitle.Text = TitleDocNumToModify
            txtNextHigherAssembly.Text = NextHigherAssemblyDocNumToModify
            cboDrafter.Text = DrafterDocNumToModify


            'Get the Program Number to use in the Update that updates this project, which was added to the drawing number
            da = New SqlClient.SqlDataAdapter("Select ProjectNumber From tblProgram Where ProgramName = '" & ProgramNameSelected & "'", SqlConnection1)
            da.Fill(ds, "ProgramNumber")
            If ds.Tables("ProgramNumber").Rows.Count > 0 Then
                ProgramNumber = ds.Tables("ProgramNumber").Rows(0).Item("ProjectNumber")
            End If

            ds.Tables("ProgramNumber").Clear()
            ds.Tables("ProgramNumber").Dispose()


            TreeView1.Visible = True
        End If


        txtDocNumber.Enabled = False
        ProgramRealDocNumToModify = ""
    End Sub

    Private Sub cboProgram_TextChanged(sender As Object, e As EventArgs) Handles cboProgram.TextChanged

        cboProject.Visible = True

        If ProgramRealDocNumToModify = "" Then
            Dim index As Integer = cboProgram.Text.IndexOf("-")
            If cboProgram.Text = "" Then
                'Nothing
            Else
                ProgramNameSelected = cboProgram.Text.Substring(index + 2)
                ProgramNumberSelected = cboProgram.Text.Substring(0, cboProgram.Text.IndexOf("-") - 1)
            End If

            'Populate Projects drop-down. Before it was populated according to the location of the user(see above uncommented stuff)
            da = New SqlClient.SqlDataAdapter("Select ProjectName, ProjectNumber From tblProgram_Project Where ProgramName = '" & ProgramNameSelected & "' Order By ProjectName", SqlConnection1)
            da.Fill(ds, "Projects")

            Dim p As Integer = 0
            cboProject.Items.Clear()
            'cboProject.Text = ""
            While p <= ds.Tables("Projects").Rows.Count - 1
                Me.cboProject.Items.Add(ds.Tables("Projects").Rows(p).Item("ProjectNumber") & " - " & ds.Tables("Projects").Rows(p).Item("ProjectName"))
                p = p + 1
            End While

            ds.Tables("Projects").Clear()
            ds.Tables("Projects").Dispose()

        Else
            'Nothing
        End If


        'Get the Program Number to use in the Insert Into that adds the project selected to the newly created drawing number
        If CreateOrModifyDocNum <> "Modify" Then
            da = New SqlClient.SqlDataAdapter("Select ProjectNumber From tblProgram Where ProgramName = '" & ProgramNameSelected & "'", SqlConnection1)
            da.Fill(ds, "ProgramNumber")
            If ds.Tables("ProgramNumber").Rows.Count > 0 Then
                ProgramNumber = ds.Tables("ProgramNumber").Rows(0).Item("ProjectNumber")
            End If

            ds.Tables("ProgramNumber").Clear()
            ds.Tables("ProgramNumber").Dispose()
        End If



        If cboProject.Text = "" Then
            TreeView1.Visible = False
            TreeView2.Visible = False
        End If

        'ProgramDocNumToModify = ""
        cboProject.Text = ""
    End Sub

    Private Sub cboProject_TextChanged(sender As Object, e As EventArgs) Handles cboProject.TextChanged
        lblDocTypeSelected.Text = ""
        lblDocTypeSelectedLevelTwo.Text = ""
        lblSeriesSelected.Text = ""
        CanadaOrUSA = ""
        lblSeries.Visible = False
        TreeView2.Visible = False
        btnJASCCodes.Visible = False

        'If CreateOrModifyDocNum = "Modify" Then
        If cboProject.Text = "" Then
            TreeView1.Visible = False
        Else
            TreeView1.Visible = True
        End If


        If cboProject.Text <> "" And ProgramRealDocNumToModify = "" Then
            Dim index As Integer = cboProject.Text.IndexOf("-")
            ProjectNameSelected = cboProject.Text.Substring(index + 2)
            ProjectNumberSelected = cboProject.Text.Substring(0, cboProject.Text.IndexOf("-") - 1)

            'Populate System Dropdown
            da = New SqlClient.SqlDataAdapter("Select SystemDescription from tblSystemDescription Where Program = '" & ProjectNameSelected & "' and Active = 'True' Order By SystemDescription Asc", SqlConnection1)
            da.Fill(ds, "GetSys")
            Me.cboSystem.Items.Clear()
            If ds.Tables("GetSys").Rows.Count > 0 Then
                Dim z As Integer = 0

                While z <= ds.Tables("GetSys").Rows.Count - 1
                    Me.cboSystem.Items.Add(ds.Tables("GetSys").Rows(z).Item("SystemDescription"))
                    z = z + 1
                End While

                ds.Tables("GetSys").Clear()
                ds.Tables("GetSys").Dispose()
            End If
        Else
            'Nothing
        End If


        'Populate Milestone drop-down; Program-related
        da = New SqlClient.SqlDataAdapter("Select Name from tblPriority Where Program = '" & ProgramNameSelected & "' And Active = 'True' Order By Name", SqlConnection1)
        da.Fill(ds, "Milestone")
        cboMilestone.Items.Clear()
        Dim p As Integer = 0
        While p <= ds.Tables("Milestone").Rows.Count - 1
            Me.cboMilestone.Items.Add(ds.Tables("Milestone").Rows(p).Item("Name"))
            p = p + 1
        End While

        ds.Tables("Milestone").Clear()
        ds.Tables("Milestone").Dispose()


        'GET THE DOCUMENT NUMBERING TYPE: CANADA OR USA. Used to create the document number
        Dim i As Integer = 0

        'If CreateOrModifyDocNum = "Modify" Then

        'Else
        da = New SqlClient.SqlDataAdapter("Select DocNumbering from tblProjects Where ProjectNumber = '" & ProjectNumberSelected & "' Or ProjectName = '" & ProjectNameSelected & "'", SqlConnection1)
        'da = New SqlClient.SqlDataAdapter("Select DocNumbering from tblProgram Where ProgramName = '" & cboProject.Text & "'", SqlConnection1)
        'End If

        da.Fill(ds, "CanadaOrUsa")
        While i <= ds.Tables("CanadaOrUsa").Rows.Count - 1
            CanadaOrUSA = ds.Tables("CanadaOrUsa").Rows(i).Item("DocNumbering")
            i = i + 1
        End While

        ds.Tables("CanadaOrUsa").Clear()
        ds.Tables("CanadaOrUsa").Dispose()
        i = 0


        '---------------------------------------------------------------------------------------------------------
        'START CREATING DOC TYPE TREEVIEW: DRAWINGS OR REPORTS
        TreeView1.Nodes.Clear()

        'Creating the root node for Drawings
        Dim root = New TreeNode("Drawings")
        TreeView1.Nodes.Add(root)
        'Creating the root node for Reports
        Dim root2 = New TreeNode("Reports")
        TreeView1.Nodes.Add(root2)

        '---------------------------------------------------------------------------------------------------------
        'LEVEL 2 Doc Type dropdown for DRAWINGS (USA Only)
        'DRAWINGS
        'If CanadaOrUSA = "Field Aerospace (OKC)" Then
        da = New SqlClient.SqlDataAdapter("Select DocTypeInDropdown from tblDocumentType Where Classification = 'Drawing' And Active = 1", SqlConnection1)
        da.Fill(ds, "DrawingsTypeUSA")
        For loopindex As Integer = 0 To ds.Tables("DrawingsTypeUSA").Rows.Count - 1
            If IsDBNull(ds.Tables("DrawingsTypeUSA").Rows(loopindex).Item("DocTypeInDropdown")) Then
                Continue For
            End If

            TreeView1.Nodes(0).Nodes.Add(New TreeNode(ds.Tables("DrawingsTypeUSA").Rows(loopindex).Item("DocTypeInDropdown")))

            'Level 3 Doc Type dropdown for Drawings (USA Only)
            If CanadaOrUSA = "Field Aerospace (OKC)" Then
                da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocTypePrefixLevelThree Where DrawingOrReport = 'Drawing' And Active = 1", SqlConnection1)
                da.Fill(ds, "ReportsTypeLevel3")
                For indexloop As Integer = 0 To ds.Tables("ReportsTypeLevel3").Rows.Count - 1
                    TreeView1.Nodes(0).Nodes(loopindex).Nodes.Add(New TreeNode(ds.Tables("ReportsTypeLevel3").Rows(indexloop).Item("DocumentType")))
                Next indexloop

                ds.Tables("ReportsTypeLevel3").Clear()
                ds.Tables("ReportsTypeLevel3").Dispose()
            End If
        Next loopindex

        ds.Tables("DrawingsTypeUSA").Clear()
        ds.Tables("DrawingsTypeUSA").Dispose()


        '---------------------------------------------------------------------------------------------------

        '***LEVEL 2 Doc Type dropdown for REPORTS (USA and Canada)
        da = New SqlClient.SqlDataAdapter("Select DocTypeInDropdown from tblDocumentType Where Classification = 'Report' And Active = 1", SqlConnection1)
        da.Fill(ds, "ReportsType")
        For loopindex As Integer = 0 To ds.Tables("ReportsType").Rows.Count - 1
            If IsDBNull(ds.Tables("ReportsType").Rows(loopindex).Item("DocTypeInDropdown")) Then
                Continue For
            End If

            TreeView1.Nodes(1).Nodes.Add(New TreeNode(ds.Tables("ReportsType").Rows(loopindex).Item("DocTypeInDropdown")))

            '***LEVEL 3 Doc Type dropdown for REPORTS (USA Only)
            If CanadaOrUSA = "Field Aerospace (OKC)" Then
                If ds.Tables("ReportsType").Rows(loopindex).Item("DocTypeInDropdown") = "59 Engineering Order (Mechanical)" Or ds.Tables("ReportsType").Rows(loopindex).Item("DocTypeInDropdown") = "59 Engineering Order (Electrical)" Then
                    'Nothing
                Else
                    da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocTypePrefixLevelThree Where DrawingOrReport = 'Report' And DocumentType != 'Engineering Order (Mechanical)' And DocumentType != 'Engineering Order (Electrical)' And Active = 1", SqlConnection1)
                    da.Fill(ds, "DrawingsTypeLevel3")
                    For indexloop As Integer = 0 To ds.Tables("DrawingsTypeLevel3").Rows.Count - 1
                        TreeView1.Nodes(1).Nodes(loopindex).Nodes.Add(New TreeNode(ds.Tables("DrawingsTypeLevel3").Rows(indexloop).Item("DocumentType")))
                    Next indexloop

                    ds.Tables("DrawingsTypeLevel3").Clear()
                    ds.Tables("DrawingsTypeLevel3").Dispose()
                End If
            End If

        Next loopindex

        ds.Tables("ReportsType").Clear()
        ds.Tables("ReportsType").Dispose()
        '------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim frmEngWorkflowBrowse As New frmEngWorkflowBrowse
        frmEngWorkflowBrowse.ShowDialog()

        Me.txtNextHigherAssembly.Text = DocBrowse

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        'If user enters the doc number manually through the Misc button control there is not a duplicate
        If MiscOrIssueNumber = "Misc" Then
            'CHECK IF DRAWING NUMBER ALREADY EXISTS
            If txtDocNumber.Text = "" Then
                MsgBox("Please enter the doc number since you clicked the Misc button")
                Exit Sub
            Else
                da = New SqlClient.SqlDataAdapter("Select * from tblDrawings Where DrawingNumber = '" & txtDocNumber.Text & "'", SqlConnection1)
                da.Fill(ds, "Getit")

                If ds.Tables("Getit").Rows.Count > 0 Then
                    MsgBox("Drawing Number Already Exists. Enter a different doc number.")
                    ds.Tables("Getit").Clear()
                    ds.Tables("Getit").Dispose()
                    Exit Sub
                End If
            End If
        End If


        'VALIDATION
        Dim msg As String = ""

        'If Me.cboProgram.Text = "" Then
        '    msg = msg + "Program is required to be selected." & vbCrLf
        'End If
        'If DocTypeSelected = "" Then
        '    msg = msg + "Document Type selection required." & vbCrLf
        'End If
        'If DrawingOrReport = "Drawing" Then
        '    If SeriesSelected = "" Then
        '        msg = msg + "Series selection required." & vbCrLf
        '    End If
        'End If
        If Me.txtDocNumber.Text = "" Then
            msg = msg + "Document Number is not populated." & vbCrLf
        Else
            FinalDocNumber = txtDocNumber.Text
        End If
        If Me.cboSystem.Text = "" Then
            msg = msg + "System is required to be selected." & vbCrLf
        End If
        If Me.txtTitle.Text = "" Then
            msg = msg + "Title is required to be filled in." & vbCrLf
        End If
        If Me.cboDrafter.Text = "" Then
            msg = msg + "Drafter is required to be selected." & vbCrLf
        End If
        If Me.cboResourceType.Text = "" Then
            msg = msg + "Resource Type is required to be selected." & vbCrLf
        End If

        If msg = "" Then
            'Nothing
        Else
            msg = msg + "Please fix errors and click continue again."
            MsgBox(msg)
            msg = ""
            Exit Sub
        End If


        '-------------------------------------------------------------------------------------------------------------------
        'THE FOLLOWING BLOCK OF CODE IS ALREADY EXECUTED IN THE ISSUE NUMBER BUTTON
        'If MiscOrIssueNumber = "Issue Number" Then
        '    If NewReworkFormB = "" Then
        '        NewReworkFormB = TreeView1.SelectedNode.FullPath
        '        NewReworkFormB = NewReworkFormB.Substring(0, 1)
        '        If NewReworkFormB = "R" Then
        '            NewReworkFormB = "New Report"
        '        ElseIf NewReworkFormB = "D" Then
        '            NewReworkFormB = "New Drawing"
        '        End If
        '    End If
        'End If
        '-------------------------------------------------------------------------------------------------------------------


        'SET THE GATE TO ONE
        'Dim GateZeroOrOne As String = "GATE 1: DWG Ready For Drafter"
        Dim GateZeroOrOne As String = "GATE 0: CM Needs To Assign DWG Number"


        'INSERT THE NEW RECORD TO THE DRAWINGS TABLE OR UPDATE THE PRE-EXISTING RECORD, AND SET OPERATIONS/ENGINEER FIELD TO "N/A" IF THE DOCUMENT CREATED IS A REPORT
        'If Misc or IssueNumber buttons are clicked then execute code below
        If MiscOrIssueNumber <> "" Then

            da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "' And Classification = 'Report'", SqlConnection1)   'Before was tblDocTypePrefixLevelTwo
            da.Fill(ds, "SelectionMade")
            If ds.Tables("SelectionMade").Rows.Count > 0 Then
                'Nothing
                ds.Tables("SelectionMade").Clear()
                ds.Tables("SelectionMade").Dispose()
                DrawingOrReport = "Report"
            End If


            'If modifying an existing record
            If CreateOrModifyDocNum = "Modify" Then

                If ProjectNameSelected = "" Then
                    ProjectNameSelected = cboProject.Text
                End If

                'Get the DocumentType that will be inserted in the database. This is the one if the user changes a doc created in form A
                da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocTypeInDropdown = '" & lblDocTypeSelected.Text & "' And Classification = 'Report'", SqlConnection1)
                da.Fill(ds, "UpdateDocType")
                If ds.Tables("UpdateDocType").Rows.Count > 0 Then
                    UpdateDocType = ds.Tables("UpdateDocType").Rows(0).Item("DocumentType")
                    ds.Tables("UpdateDocType").Clear()
                    ds.Tables("UpdateDocType").Dispose()
                End If

                'Update Program, Project, DocType and Series if user changed these selections by clicking on "Issue Number". Or just update to the new entries made after clicking Misc button
                If MiscOrIssueNumber = "Issue Number" Then
                    u.ExecuteSQL(SqlConnection1, "UPDATE tblDrawings SET ProgramReal = '" & ProgramNameSelected & "', Program = '" & ProjectNameSelected & "', DocumentType = '" & UpdateDocType & "', DocTypeSelectedLevelThree = '" & UpdateDocTypeLevelThree & "', Series = '" & UpdateSeries & "', DrawingNumber = '" & txtDocNumber.Text & "', Status = '" & GateZeroOrOne & "', SystemDescription = '" & cboSystem.Text & "', DrawingTitle = '" & txtTitle.Text & "', NextHigherAssembly = '" & txtNextHigherAssembly.Text & "', Drafter = '" & cboDrafter.Text & "', Type = '" & cboResourceType.Text & "', IsDocNumConfirmed = 1, Priority = '" & cboMilestone.Text & "' Where RecordID = '" & RecordIdDocNumToModify & "'")
                Else
                    u.ExecuteSQL(SqlConnection1, "UPDATE tblDrawings SET DrawingNumber = '" & txtDocNumber.Text & "', ProgramReal = '" & ProgramNameSelected & "', Program = '" & ProjectNameSelected & "', DocumentType = '" & UpdateDocType & "', DocTypeSelectedLevelThree = '" & UpdateDocTypeLevelThree & "', Series = '" & UpdateSeries & "', Status = '" & GateZeroOrOne & "', SystemDescription = '" & cboSystem.Text & "', DrawingTitle = '" & txtTitle.Text & "', NextHigherAssembly = '" & txtNextHigherAssembly.Text & "', Drafter = '" & cboDrafter.Text & "', Type = '" & cboResourceType.Text & "', IsDocNumConfirmed = 1, Priority = '" & cboMilestone.Text & "' Where RecordID = '" & RecordIdDocNumToModify & "'")
                End If

                ''Add project to drawing number         COMMENTED ON 08/18/21
                'u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber) Values ('" & ProjectNameSelected & "', '" & cboSystem.Text & "', '" & txtDocNumber.Text & "', '" & ProgramNumber & "')")


                'If Creating a New Record
            Else

                'Get Doc Type selected by user. For USA we need to insert in the database the level 2 selection and not the level 3
                GetLevelTwoSelectedAndNotLevelThree()

                'The only thing different between the two SQL queries below is that the one related to Report sets Engineer = N/A
                If NewReworkFormB = "New Drawing" Then
                    u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, ProgramReal, Program, SystemDescription, DwgRevision, Type, DocumentType, DocTypeSelectedLevelThree, Series, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter, DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, Updated, UpdatedDate, ADCN, ForecastStartDate, DrafterSignedOffBy, SrEngineerSignedOffBy, StressSignedOffBy, EngineerSignedOffBy, ReleaserSignedOffBy, CMSignedOffBy, IsDocNumConfirmed, DrawingOrReport) Values ('" & txtDocNumber.Text & "', '" & u.FTM(txtTitle.Text) & "', '" & txtNextHigherAssembly.Text & "', '" & ProgramNameSelected & "', '" & ProjectNameSelected & "', '" & u.FTM(Me.cboSystem.Text) & "', 'IR', '" & cboResourceType.Text & "', '" & u.FTM(DocTypeSelected) & "', '" & DocTypeSelectedLevelThree & "', '" & SeriesSelected & "', '" & cboMilestone.Text & "', '" & Loc & "', '" & System.Environment.UserName & "', '" & Now & "', '', '" & GateZeroOrOne & "', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '', '', '" & cboDrafter.Text & "', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','','','','','','" & Now & "', '" & NewReworkFormB & "', 0, '" & Now & "', '', '" & Now & "', '', '', '', '', '', '', 1, '" & ClassificationFormB & "')")
                ElseIf NewReworkFormB = "New Report" Then
                    u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, ProgramReal, Program, SystemDescription, DwgRevision, Type, DocumentType, DocTypeSelectedLevelThree, Series, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter, DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, Updated, UpdatedDate, ADCN, ForecastStartDate, DrafterSignedOffBy, SrEngineerSignedOffBy, StressSignedOffBy, EngineerSignedOffBy, ReleaserSignedOffBy, CMSignedOffBy, IsDocNumConfirmed, DrawingOrReport) Values ('" & txtDocNumber.Text & "', '" & u.FTM(txtTitle.Text) & "', '" & txtNextHigherAssembly.Text & "', '" & ProgramNameSelected & "', '" & ProjectNameSelected & "', '" & u.FTM(Me.cboSystem.Text) & "', 'IR', '" & cboResourceType.Text & "', '" & u.FTM(DocTypeSelected) & "', '" & DocTypeSelectedLevelThree & "', '" & SeriesSelected & "', '" & cboMilestone.Text & "', '" & Loc & "', '" & System.Environment.UserName & "', '" & Now & "', '', '" & GateZeroOrOne & "', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '', '', '" & cboDrafter.Text & "', '01/01/1900', 'N/A', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','','','','','','" & Now & "', '" & NewReworkFormB & "', 0, '" & Now & "', '', '" & Now & "', '', '', '', '', '', '', 1, '" & ClassificationFormB & "')")
                End If

                ''I might have to add the following block of code: it inserts a project for each program it is related to
                'Try
                'AddProjectsRelatedToPrograms()
                'Catch ex As Exception
                'MessageBox.Show("An error occured after clicking on Save." & vbLf & vbLf & ex.Message)
                'End Try
            End If

            'Add project to drawing number
            u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber, ProgramName) Values ('" & ProjectNameSelected & "', '" & cboSystem.Text & "', '" & txtDocNumber.Text & "', '" & ProgramNumber & "', '" & ProgramNameSelected & "')")


            'Run this if the user accepts the doc number as it is, without making any changes. Modifying doc already created in Form A so just Update
        Else

            If CreateOrModifyDocNum = "Modify" Then
                u.ExecuteSQL(SqlConnection1, "UPDATE tblDrawings SET IsDocNumConfirmed = 1, Status = 'GATE 1: DWG Ready For Drafter', SystemDescription = '" & cboSystem.Text & "', DrawingTitle = '" & txtTitle.Text & "', NextHigherAssembly = '" & txtNextHigherAssembly.Text & "' , Drafter = '" & cboDrafter.Text & "', Type = '" & cboResourceType.Text & "', Priority = '" & cboMilestone.Text & "' Where RecordID = '" & RecordIdDocNumToModify & "'")

                'Add project to drawing number
                u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber, ProgramName) Values ('" & ProjectNameSelected & "', '" & cboSystem.Text & "', '" & txtDocNumber.Text & "', '" & ProgramNumber & "', '" & ProgramNameSelected & "')")
            End If

        End If


        '-----------------------------------------------------------------------------------------------------------

        'GET THE RECORD ID
        da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID From tblDrawings Order By RecordID Desc", SqlConnection1)
        da.Fill(ds, "Top1")
        DocAdd = Val(ds.Tables("TOP1").Rows(0).Item("RecordID"))
        ds.Tables("Top1").Clear()
        ds.Tables("Top1").Dispose()
        '-------------------------------------------------------------------------------------------------------------



        '------------------------------------------------------------------------------------------------------------------------
        'INSERT INTO tblTree
        '*************************************************************************************************************
        '-------------------------------------------------------------------------------------------------------------
        '**************** NextHigherAssembly, DrawingNumber And DrawingTitle in tblTree contain info about the parent and is used in the Assembly grid of the Details tab
        '**************** DrawingNumOriginal, DwgRevision, DrawingTitleChildren, Status... contain info about the children and is used in the creation of the Tree
        '-------------------------------------------------------------------------------------------------------------
        '*************************************************************************************************************
        'Add record to tblTree, for the Tree viewing

        'Dim c As Integer = 0
        'Dim RecordIDFromDrawings As String = ""
        'Dim Assembly As String = ""
        'Dim NewReworkToEnter As String = ""
        'Dim DrawOrReportToEnter As String = ""

        Dim DrawingNumOriginalToEnter As String = ""
        Dim DrawingTitleToEnter As String = ""
        Dim StatusToEnter As String = ""
        Dim DwgRevisionToEnter As String = ""
        Dim SeqToEnter As String = ""
        Dim DrawOrReportToEnter As String = ""
        Dim NewReworkToEnter As String = ""
        Dim SystemToEnter As String = ""
        Dim DrawingNumberParent As String = ""
        Dim DrawingTitleParent As String = ""

        '------------------------------------------------------------------------------------------------------------------------
        '*************************************************************************************************************
        '-------------------------------------------------------------------------------------------------------------
        '**************** NextHigherAssembly, DrawingNumber And DrawingTitle in tblTree contain info about the parent and is used in the Assembly grid of the Details tab
        '**************** DrawingNumOriginal, DwgRevision, DrawingTitleChildren, Status... contain info about the children and is used in the creation of the Tree
        '-------------------------------------------------------------------------------------------------------------
        '*************************************************************************************************************

        'INSERT INTO tblTree
        If txtNextHigherAssembly.Text <> "" Then    'With Assembly

            'Get Children Data to Insert Into tblTree
            If FinalDocNumber = "" Then
                FinalDocNumber = txtDocNumber.Text
            End If

            da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & FinalDocNumber & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq Desc, RecordID Desc", SqlConnection1)
            da.Fill(ds, "DataRecordJustAdded")

            If ds.Tables("DataRecordJustAdded").Rows.Count > 0 Then
                DrawingNumOriginalToEnter = ds.Tables("DataRecordJustAdded").Rows(0).Item("DrawingNumber")
                DrawingTitleToEnter = ds.Tables("DataRecordJustAdded").Rows(0).Item("DrawingTitle")
                StatusToEnter = ds.Tables("DataRecordJustAdded").Rows(0).Item("Status")
                DwgRevisionToEnter = ds.Tables("DataRecordJustAdded").Rows(0).Item("DwgRevision")
                SeqToEnter = ds.Tables("DataRecordJustAdded").Rows(0).Item("Seq")
                DrawOrReportToEnter = ds.Tables("DataRecordJustAdded").Rows(0).Item("DrawingOrReport")
                NewReworkToEnter = ds.Tables("DataRecordJustAdded").Rows(0).Item("NewRework")
                If IsDBNull(ds.Tables("DataRecordJustAdded").Rows(0).Item("SystemDescription")) Then
                    SystemToEnter = ""
                Else
                    SystemToEnter = ds.Tables("DataRecordJustAdded").Rows(0).Item("SystemDescription")
                End If

                'Data parent
                da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & txtNextHigherAssembly.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order by Seq Desc, RecordID Desc", SqlConnection1)
                da.Fill(ds, "ParentData")

                'If ds.Tables("ParentData").Rows.Count > 1 Then     'Commented this line for the one following on 09/30/21, this way I add the DrawingNumber and DrawingTitle of the parent record
                If ds.Tables("ParentData").Rows.Count > 0 Then
                    DrawingNumberParent = ds.Tables("ParentData").Rows(0).Item("DrawingNumber")
                    DrawingTitleParent = ds.Tables("ParentData").Rows(0).Item("DrawingTitle")
                End If

                'Insert Into tblTree Data From Two Selects Above
                u.ExecuteSQL(SqlConnection1, "INSERT into tblTree (DrawingNumOriginal,DrawingTitleChildren,Status,DwgRevision,Seq,DrawingOrReport,NewRework,DrawingNumber,DrawingTitle,SystemDescription) Values ('" & DrawingNumOriginalToEnter & "', '" & u.FTM(DrawingTitleToEnter) & "', '" & StatusToEnter & "', '" & DwgRevisionToEnter & "', '" & SeqToEnter & "', '" & DrawOrReportToEnter & "', '" & NewReworkToEnter & "', '" & DrawingNumberParent & "', '" & u.FTM(DrawingTitleParent) & "', '" & u.FTM(SystemToEnter) & "')")
                'Added the system in the query above on 09/30/21

                ds.Tables("DataRecordJustAdded").Clear()
                ds.Tables("DataRecordJustAdded").Dispose()
                ds.Tables("ParentData").Clear()
                ds.Tables("ParentData").Dispose()
            End If
        End If
        '-------------------------------------------------------------------------------------------------------------------------



        'Check if document type is a Report when creating a new document, if it is this variable will be used to set Operations/Engineer field to "N/A"
        If NewReworkFormB = "New Report" Then
            DocumentTypeForOperations = "Report"
        ElseIf NewReworkFormB = "New Drawing" Then
            DocumentTypeForOperations = "Drawing"
        End If


        '---------------------------------------------------------------------------------------------------------
        'Create MDL record in the MDL table
        'Create a MDL Number
        Try
            If MiscOrIssueNumber <> "Misc" Then
                If DocTypeDocNumToModify = "Master Data List" Then
                    'Dim DocTypeNoZeroes As String = DocTypeSelected.Substring(3, 16)
                    Dim mdlint As Int64
                    mdlint = Format(Now, "ddyymmss")

                    u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDL (MDLNumber, DocumentNumber, Title, Revision, Status, LastRefresh, Priority) Values ('" & Val(mdlint) & "','" & DocTypeDocNumToModify & "', '" & u.FTM(Me.txtTitle.Text) & "', 'IR', '-', '" & Now & "', '" & cboMilestone.Text & "')")
                    'Get the MDLRecordID value just generated
                    da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID from tblLiveMDL Order By RecordID Desc", SqlConnection1)
                    da.Fill(ds, "MDL")
                    'Insert record into the tblLiveMDLProjectsSystems table
                    u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLProjectsSystems (MDLRecordID, MDLNumber, DocumentNumber, Program, System) Values ('" & Val(ds.Tables("MDL").Rows(0).Item("RecordID")) & "',  '" & Val(mdlint) & "', '" & DocTypeDocNumToModify & "', '" & ProgramNameSelected & "', '" & Me.cboSystem.Text & "')")

                    MDLNumberCreatedFormB = "Yes"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '---------------------------------------------------------------------------------------------------------------


        'SEND NOTIFICATION TO DRAFTER AND LEAD ENGINEER
        Try
            DrawingNumForEmails = FinalDocNumber
            ProgramName = ProgramNameSelected               'Program Name to use with Notifications
            DrafterFormB = cboDrafter.Text
            RevisionForEmails = "IR"
            frmEngWorkflowSignOff.SendNotifications(8)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



        'Clearing variable(to say that a notification at gate 1 can be sent, since a new doc is being created). Need this because it was sending a notification to Gate 1 people twice, when saving with save btn and when saving with the signoff btn
        NotificationAlreadySentForGateOne = "No"
        'Update notifications label
        frmEngWorkflow.GetNumberTasksPending()

        'If the add drawing number button was clicked from EARR then next line will allow to run the code under btnAddDoc to run and add a response. The second line gets the draw # just added
        CreateRev = "Yes"
        DrawNumFromFormAorB = txtDocNumber.Text


        Me.Close()
    End Sub

    ''I might have to add the following Function: it inserts a project for each program it is related to
    'Public Function AddProjectsRelatedToPrograms()
    '    Dim ProgramNumbers As String = ""

    '    If CreateOrModifyDocNum <> "Modify" Then

    '        'See if the project just added belongs to more than one program, in that case more records of other projects with the other programs is created
    '        da = New SqlClient.SqlDataAdapter("Select Distinct ProgramNumber From tblProgram_Project Where ProjectName = '" & cboProject.Text & "'", SqlConnection1)
    '        da.Fill(ds, "ProgramNumbersInitial")

    '        If ds.Tables("ProgramNumbersInitial").Rows.Count > 1 Then
    '            Dim c As Integer = 0
    '            While c <= ds.Tables("ProgramNumbersInitial").Rows.Count - 1
    '                ProgramNumbers = ds.Tables("ProgramNumbersInitial").Rows(c).Item("ProgramNumber")
    '                c = c + 1

    '                u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber) Values ('" & cboProject.Text & "', '" & cboSystem.Text & "', '" & txtDocNumber.Text & "', '" & ProgramNumbers & "')")
    '            End While

    '        ElseIf ds.Tables("ProgramNumbersInitial").Rows.Count = 1 Then
    '            u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber) Values ('" & cboProject.Text & "', '" & cboSystem.Text & "', '" & txtDocNumber.Text & "', '" & ds.Tables("ProgramNumbersInitial").Rows(0).Item("ProgramNumber") & "')")
    '        Else
    '            u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber) Values ('" & cboProject.Text & "', '" & cboSystem.Text & "', '" & txtDocNumber.Text & "', 'No Program Found')")
    '        End If

    '        ds.Tables("ProgramNumbersInitial").Clear()
    '        ds.Tables("ProgramNumbersInitial").Dispose()

    '        ds.Tables("ProjectsInserted").Clear()
    '        ds.Tables("ProjectsInserted").Dispose()
    '    End If
    'End Function

    Public Function GetLevelTwoSelectedAndNotLevelThree()

        'Get Doc Type selected by user. For USA we need to get the level 2 selection and not the level 3

        'Check if Drawings or Reports has been chosen. To use with following block of code
        Dim a As String = TreeView1.SelectedNode.FullPath
        Dim checkIfDrawingOrReport As String = a.Substring(0, a.IndexOf("\"))

        If CanadaOrUSA = "Field Aerospace (OKC)" Then
            DocTypeSelected = TreeView1.SelectedNode.FullPath

            If checkIfDrawingOrReport = "Drawings" Then

                'Text to insert in col DocTypeSelectedLevelThree in tblDrawings
                DocTypeSelectedLevelThree = TreeView1.SelectedNode.Text

                'Text to insert in col DocType in tblDrawings
                DocTypeSelected = DocTypeSelected.Substring(9)
                DocTypeSelected = DocTypeSelected.Substring(0, DocTypeSelected.IndexOf("\"))

            ElseIf checkIfDrawingOrReport = "Reports" Then

                If DocTypeSelected = "Reports\59 Engineering Order (Mechanical)" Then
                    DocTypeSelectedLevelThree = DocTypeSelected.Substring(11)
                    DocTypeSelected = DocTypeSelected.Substring(11)
                    da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocTypeInDropdown = 'Engineering Order (Mechanical)'", SqlConnection1)
                    da.Fill(ds, "DocTypeWithoutNumbers")
                ElseIf DocTypeSelected = "Reports\59 Engineering Order (Electrical)" Then
                    DocTypeSelectedLevelThree = DocTypeSelected.Substring(11)
                    DocTypeSelected = DocTypeSelected.Substring(11)
                    da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocTypeInDropdown = 'Engineering Order (Electrical)'", SqlConnection1)
                    da.Fill(ds, "DocTypeWithoutNumbers")
                Else
                    DocTypeSelectedLevelThree = TreeView1.SelectedNode.Text
                    DocTypeSelected = DocTypeSelected.Substring(8)
                    DocTypeSelected = DocTypeSelected.Substring(0, DocTypeSelected.IndexOf("\"))
                    da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "'", SqlConnection1)
                    da.Fill(ds, "DocTypeWithoutNumbers")
                    DocTypeSelected = ds.Tables("DocTypeWithoutNumbers").Rows(0).Item("DocumentType")
                End If

                ds.Tables("DocTypeWithoutNumbers").Clear()
                ds.Tables("DocTypeWithoutNumbers").Dispose()
            End If

        Else

            'Get the document type without the numbers showing in front of the doc type selected from drop-down; for Canada reports
            If CanadaOrUSA = "Field Aerospace (Canada)" And DrawingOrReport = "Report" Then
                'ADD (DONE) TO REDLINES CODE, although it is not related to it: comment next line and add following 5 lines
                'DocTypeSelected = DocTypeSelected
                da = New SqlClient.SqlDataAdapter("Select DocumentType From tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "'", SqlConnection1)
                da.Fill(ds, "DocTypeWithoutNums")
                If ds.Tables("DocTypeWithoutNums").Rows.Count > 0 Then
                    DocTypeSelected = ds.Tables("DocTypeWithoutNums").Rows(0).Item("DocumentType")
                    ds.Tables("DocTypeWithoutNums").Clear()
                    ds.Tables("DocTypeWithoutNums").Dispose()
                Else
                    da = New SqlClient.SqlDataAdapter("Select DocumentType From tblDocumentType Where DocTypeInDropdown = '" & lblDocTypeSelected.Text & "'", SqlConnection1)
                    da.Fill(ds, "DocTypeWithoutNumsOptionTwo")
                    If ds.Tables("DocTypeWithoutNumsOptionTwo").Rows.Count > 0 Then
                        DocTypeSelected = ds.Tables("DocTypeWithoutNumsOptionTwo").Rows(0).Item("DocumentType")
                        ds.Tables("DocTypeWithoutNumsOptionTwo").Clear()
                        ds.Tables("DocTypeWithoutNumsOptionTwo").Dispose()
                    End If
                End If

            Else
                'ADD (DONE) TO PROD, Point 50: next 8 lines and comment the 10th line which was pre-existing
                'Get the DocumentType that will be inserted in the database. Before the DocTypeSelected also included the number for Canada Report, which it should not be included
                da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocTypeInDropdown = '" & lblDocTypeSelected.Text & "' And Classification = 'Report'", SqlConnection1)
                da.Fill(ds, "UpdateDocType")
                If ds.Tables("UpdateDocType").Rows.Count > 0 Then
                    DocTypeSelected = ds.Tables("UpdateDocType").Rows(0).Item("DocumentType")
                    ds.Tables("UpdateDocType").Clear()
                    ds.Tables("UpdateDocType").Dispose()
                Else
                    da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "' And Classification = 'Report'", SqlConnection1)
                    da.Fill(ds, "DocTypeOptionTwo")
                    If ds.Tables("DocTypeOptionTwo").Rows.Count > 0 Then
                        DocTypeSelected = ds.Tables("DocTypeOptionTwo").Rows(0).Item("DocumentType")
                        ds.Tables("DocTypeOptionTwo").Clear()
                        ds.Tables("DocTypeOptionTwo").Dispose()
                    End If
                End If

                'DocTypeSelected = TreeView1.SelectedNode.Text
            End If

        End If
    End Function

    Public Function IncreasePrefixByOne(PrefixToIncrease As String)
        PrefixIncreasedByOne = ""
        Dim zeroes As String = ""

        Dim numHasZeroFirstPosition As String = PrefixToIncrease.Substring(0, 1)
        Dim numHasZeroSecondPosition As String = PrefixToIncrease.Substring(1, 1)
        Dim characters As StringBuilder = New StringBuilder()
        Dim nums As StringBuilder = New StringBuilder()

        For Each c As Char In PrefixToIncrease

            If CanadaOrUSA = "Field Aerospace (Canada)" And DrawingOrReport = "Drawing" Then    '***CANADA DRAWING
                If (Char.IsNumber(c)) Then
                    nums.Append(c)
                    If c = "0" Then
                        zeroes += "0"
                    End If
                ElseIf (Char.IsLetter(c)) Then
                    characters.Append(c)
                End If

            Else                                                                                '***CANADA REPORT and USA REPORT
                If (Char.IsNumber(c)) Then
                    nums.Append(c)
                    If numHasZeroFirstPosition = "0" Or numHasZeroSecondPosition = "0" Then
                        If c = "0" Then
                            zeroes += "0"
                        End If
                    End If
                ElseIf (Char.IsLetter(c)) Then
                    characters.Append(c)
                End If
            End If
        Next

        Dim IntNum As Integer = IntNum.Parse(nums.ToString()) + 1   'Number increased by one
        Dim StringNum As String = CStr(IntNum)      'Number increased by one in string format
        PrefixIncreasedByOne = characters.ToString  'Letter characters

        'If CanadaOrUSA = "Field Aerospace (OKC)" And DrawingOrReport = "Report" And DocTypeSelected = "59 Engineering Order (Mechanical)" Then '***ENGINEERING MECHANICAL-USA REPORT
        'ADDED one line below instead of above 08/02
        If CanadaOrUSA = "Field Aerospace (OKC)" And DrawingOrReport = "Report" And (DocTypeSelected = "Engineering Order (Mechanical)" Or DocTypeSelected = "59 Engineering Order (Mechanical)") Then '***ENGINEERING MECHANICAL-USA REPORT
            If zeroes = "000" Then
                zeroes = "00"
            ElseIf zeroes = "00" And StringNum.Length > 1 Then
                zeroes = "0"
            ElseIf StringNum = "100" Then
                zeroes = ""
            ElseIf zeroes = "0" And StringNum <> "99" Then
                zeroes = "0"
            End If
            'ElseIf CanadaOrUSA = "Field Aerospace (OKC)" And DrawingOrReport = "Report" And DocTypeSelected = "59 Engineering Order (Electrical)" Then '***ENGINEERING ELECTRICAL-USA REPORT
            'ADDED one line below instead of above 08/02
        ElseIf CanadaOrUSA = "Field Aerospace (OKC)" And DrawingOrReport = "Report" And (DocTypeSelected = "Engineering Order (Electrical)" Or DocTypeSelected = "59 Engineering Order (Electrical)") Then '***ENGINEERING ELECTRICAL-USA REPORT
            If zeroes = "000" Then
                zeroes = "00"
            ElseIf zeroes = "00" And StringNum.Length > 1 Then
                zeroes = "0"
            ElseIf StringNum = "100" Then
                zeroes = ""
            ElseIf zeroes = "0" And StringNum <> "99" Then
                zeroes = "0"
            End If

            'This is for when the user chooses Reports MDL as it was adding an extra zero in front
        ElseIf CanadaOrUSA = “Field Aerospace (OKC)” And DrawingOrReport = "Report" And DocTypeSelected = “Master Drawing / Document List (MDL)” Then
            If (zeroes = "0" Or zeroes = "00" Or zeroes = "000" Or zeroes = "0000") And StringNum.Length > 3 Then
                zeroes = ""
            ElseIf (zeroes = "0" Or zeroes = "00" Or zeroes = "000" Or zeroes = "0000") And StringNum.Length = 3 Then
                zeroes = ""
            ElseIf (zeroes = "0" Or zeroes = "00" Or zeroes = "000" Or zeroes = "0000") And StringNum.Length = 2 Then
                zeroes = "0"
            ElseIf (zeroes = "0" Or zeroes = "00" Or zeroes = "000" Or zeroes = "0000") And StringNum.Length = 1 Then
                zeroes = "00"
            End If

            'This is for the 4 extra/unique Canada Drawings, it adds a zero in front so I am taking it off
            'ElseIf CanadaOrUSA = "Field Aerospace (Canada)" And DrawingOrReport = "Drawing" And (lblDocTypeSelected.Text = "Proposal (PRxxxx)" Or lblDocTypeSelected.Text = "Tooling (T81xxx)" Or lblDocTypeSelected.Text = "Product & System Specification (SPEC-1xxx)" Or lblDocTypeSelected.Text = "Sketch (SKxxxx)") Then
        ElseIf CanadaOrUSA = "Field Aerospace (Canada)" And DrawingOrReport = "Drawing" And (lblSeriesSelected.Text = "Proposal (PRxxxx)" Or lblSeriesSelected.Text = "Tooling (T81xxx)" Or lblSeriesSelected.Text = "Product & System Specification (SPEC-1xxx)" Or lblSeriesSelected.Text = "Sketch (SKxxxx)") Then

            If lblSeriesSelected.Text = "Product & System Specification (SPEC-1xxx)" Or lblSeriesSelected.Text = "Tooling (T81xxx)" Then
                If (zeroes = "0" Or zeroes = "00" Or zeroes = "000" Or zeroes = "0000") And StringNum.Length > 3 Then
                    zeroes = ""
                ElseIf (zeroes = "0" Or zeroes = "00" Or zeroes = "000" Or zeroes = "0000") And StringNum.Length = 3 Then
                    zeroes = ""
                ElseIf (zeroes = "0" Or zeroes = "00" Or zeroes = "000" Or zeroes = "0000") And StringNum.Length = 2 Then
                    zeroes = "0"
                ElseIf (zeroes = "0" Or zeroes = "00" Or zeroes = "000" Or zeroes = "0000") And StringNum.Length = 1 Then
                    zeroes = "00"
                End If
            Else
                If (zeroes = "0" Or zeroes = "00" Or zeroes = "000" Or zeroes = "0000") And StringNum.Length = 1 Then
                    zeroes = "000"
                ElseIf (zeroes = "0" Or zeroes = "00" Or zeroes = "000" Or zeroes = "0000") And StringNum.Length = 2 Then
                    zeroes = "00"
                ElseIf (zeroes = "0" Or zeroes = "00" Or zeroes = "000" Or zeroes = "0000") And StringNum.Length = 3 Then
                    zeroes = "0"
                ElseIf (zeroes = "0" Or zeroes = "00" Or zeroes = "000" Or zeroes = "0000") And StringNum.Length = 4 Then
                    zeroes = ""
                End If
            End If

        ElseIf CanadaOrUSA = "Field Aerospace (Canada)" And DrawingOrReport = "Drawing" Then
            If zeroes = "00000" And StringNum.Length = 1 Then
                zeroes = "0000"
            ElseIf zeroes = "0000" And StringNum.Length = 2 Then
                zeroes = "000"
            ElseIf (zeroes = "0000" Or zeroes = "000") And StringNum.Length = 3 Then
                zeroes = "00"
            ElseIf (zeroes = "0000" Or zeroes = "000" Or zeroes = "00") And StringNum.Length = 4 Then
                zeroes = "0"
            ElseIf (zeroes = "0000" Or zeroes = "000" Or zeroes = "00" Or zeroes = "0") And StringNum.Length = 5 Then
                zeroes = ""
            End If
        End If

        PrefixIncreasedByOne += zeroes
        PrefixIncreasedByOne += StringNum   'Final Prefix number increased by one.  Then in some instances it will be changed in the below two blocks of code


        If CanadaOrUSA = "Field Aerospace (Canada)" And DrawingOrReport = "Report" Then         '***CANADA REPORT
            If PrefixIncreasedByOne.Length = 5 Then
                PrefixIncreasedByOne = PrefixIncreasedByOne.Substring(1, 4)
            ElseIf PrefixIncreasedByOne.Length = 6 Then
                PrefixIncreasedByOne = PrefixIncreasedByOne.Substring(2, 4)
            ElseIf PrefixIncreasedByOne.Length = 7 Then
                PrefixIncreasedByOne = PrefixIncreasedByOne.Substring(3, 4)
            End If
        End If


        If CanadaOrUSA = "Field Aerospace (OKC)" And DrawingOrReport = "Drawing" Then           '***USA DRAWING
            If Char.IsLetter(PrefixIncreasedByOne.Substring(0, 1)) And PrefixIncreasedByOne.Length > 4 Then
                PrefixIncreasedByOne = PrefixIncreasedByOne.Substring(0, 1) + PrefixIncreasedByOne.Substring(2, 3)
            End If

            If PrefixIncreasedByOne.Length = 5 Then
                PrefixIncreasedByOne = PrefixIncreasedByOne.Substring(1, 4)
            ElseIf PrefixIncreasedByOne.Length = 6 Then
                PrefixIncreasedByOne = PrefixIncreasedByOne.Substring(2, 4)
            ElseIf PrefixIncreasedByOne.Length = 7 Then
                PrefixIncreasedByOne = PrefixIncreasedByOne.Substring(3, 4)
            End If
        End If

    End Function

    Public Function GetPrefixReportUSA(tableToIncreaseSeq As String)
        Dim USAReportRecordID As String = ""
        Dim USAReportDocType As String = ""
        Dim USAReportTrailing As String = ""
        Dim USAReportClassification As String = ""
        Dim USAReportActive As String = ""
        Dim USAReportLastPrefix As String = ""
        Dim USAReportPreviousPrefix As String = ""
        Dim FirstPrefix As String = ""
        PrefixIncreasedByOne = ""

        'Get Sequence JASC Prefix
        If DocTypeSelected = "59 Engineering Order (Mechanical)" Then
            da = New SqlClient.SqlDataAdapter("Select * from tblDocTypePrefixLevelThree Where DocumentType = 'Engineering Order (Mechanical)' And DrawingOrReport = 'Report'", SqlConnection1)
        ElseIf DocTypeSelected = "59 Engineering Order (Electrical)" Then
            da = New SqlClient.SqlDataAdapter("Select * from tblDocTypePrefixLevelThree Where DocumentType = 'Engineering Order (Electrical)' And DrawingOrReport = 'Report'", SqlConnection1)
        Else
            da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocTypePrefixLevelThree Where DocumentType = '" & DocTypeSelected & "' And DrawingOrReport = 'Report' Order By RecordID Desc", SqlConnection1)
        End If
        da.Fill(ds, "USAReportDocSeqIdentifier")

        USAReportRecordID = ds.Tables("USAReportDocSeqIdentifier").Rows(0).Item("RecordID")
        USAReportDocSeqIdentifier = ds.Tables("USAReportDocSeqIdentifier").Rows(0).Item("Prefix")
        USAReportDocType = ds.Tables("USAReportDocSeqIdentifier").Rows(0).Item("DocumentType")
        USAReportTrailing = ds.Tables("USAReportDocSeqIdentifier").Rows(0).Item("Trailing")
        USAReportLastPrefix = ds.Tables("USAReportDocSeqIdentifier").Rows(0).Item("LastPrefix")
        NextPrefixReportUSA = ds.Tables("USAReportDocSeqIdentifier").Rows(0).Item("NextPrefix")
        USAReportPreviousPrefix = ds.Tables("USAReportDocSeqIdentifier").Rows(0).Item("PreviousPrefix")
        USAReportClassification = ds.Tables("USAReportDocSeqIdentifier").Rows(0).Item("DrawingOrReport")
        USAReportActive = ds.Tables("USAReportDocSeqIdentifier").Rows(0).Item("Active")
        ds.Tables("USAReportDocSeqIdentifier").Clear()
        ds.Tables("USAReportDocSeqIdentifier").Dispose()

        'If trailing is zero there is no need to increase the sequence
        If USAReportTrailing = "0" Then
            LoopedAlreadyForTrailingZero = "True"

            'Increase Sequence if needed
        Else

            'If the sequence is the last one, if it is already been used fire msgbox; if it is not been used use it and then set PreviousPrefix to LastPrefix -> 
            'so that next time if the sequence Is the last one again it does Not get used
            If NextPrefixReportUSA = USAReportLastPrefix Then

                If USAReportPreviousPrefix = USAReportLastPrefix Then
                    MsgBox("Last Sequence Reached. You have no available sequences for the selection you made")
                    LastSequenceReached = "True"
                    ''If the prefix just taken above is the last one, set the prefix to the first one           'I MAY NEED THE LINE OF CODE BELOW IN THE FUTURE
                    'u.ExecuteSQL(SqlConnection1, "UPDATE tblDocTypePrefixLevelThree SET NextPrefix = '" & USAReportDocSeqIdentifier & "', PreviousPrefix = '" & USAReportDocSeqIdentifier & "' Where RecordID = '" & USAReportRecordID & "'")
                Else
                    u.ExecuteSQL(SqlConnection1, "UPDATE tblDocTypePrefixLevelThree SET PreviousPrefix = '" & USAReportLastPrefix & "' Where RecordID = '" & USAReportRecordID & "'")
                End If

                'Increase sequence if the sequence just used is not the last one
            Else
                'Add one to the prefix sequence and to the table
                IncreasePrefixByOne(NextPrefixReportUSA)
                u.ExecuteSQL(SqlConnection1, "UPDATE tblDocTypePrefixLevelThree SET NextPrefix = '" & PrefixIncreasedByOne & "', PreviousPrefix = '" & NextPrefixReportUSA & "' Where RecordID = '" & USAReportRecordID & "'")
            End If
        End If
    End Function
    Public Function GetPrefixDrawingUSA(tableToIncreaseSeq As String)
        Dim USADrawingRecordID As String = ""
        Dim USADrawingDocType As String = ""
        Dim USADrawingTrailing As String = ""
        Dim USADrawingClassification As String = ""
        Dim USADrawingActive As String = ""
        Dim USADrawingLastPrefix As String = ""
        Dim USADrawingPreviousPrefix As String = ""
        Dim FirstPrefixDrawing As String = ""
        PrefixIncreasedByOne = ""

        'Get Sequence
        'If it is not the first sequence code goes to another table that keeps track of the sequences
        da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocTypePrefixLevelThree_NextSequences Where DocumentType = '" & DocTypeSelected & "' And Series = '" & SeriesSelected & "' And Location = '" & CanadaOrUSA & "' And DrawingOrReport = 'Drawing' Order By RecordID Desc", SqlConnection1)
        da.Fill(ds, "USADrawingNextDocSequence")
        If ds.Tables("USADrawingNextDocSequence").Rows.Count > 0 Then

            NextPrefixDrawingUSA = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("NextPrefix")
            USADrawingRecordID = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("RecordID")
            USADrawingDocSeqIdentifier = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("Prefix")
            USADrawingDocType = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("DocumentType")
            USADrawingTrailing = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("Trailing")
            USADrawingLastPrefix = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("LastPrefix")
            USADrawingPreviousPrefix = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("PreviousPrefix")
            USADrawingClassification = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("DrawingOrReport")
            ds.Tables("USADrawingNextDocSequence").Clear()
            ds.Tables("USADrawingNextDocSequence").Dispose()


            'If trailing is zero there is no need to increase the sequence
            If USADrawingTrailing = "0" Then
                LoopedAlreadyForTrailingZero = "True"

                'Increase Sequence if needed
            Else

                'If the sequence is the last one, if it is already been used fire msgbox; if it is not been used use it and then set PreviousPrefix to LastPrefix -> 
                'so that next time if the sequence Is the last one again it does Not get used
                If NextPrefixDrawingUSA = USADrawingLastPrefix Then

                    If USADrawingPreviousPrefix = USADrawingLastPrefix Then
                        MsgBox("Last Sequence Reached. You have no available sequences for the selection you made")
                        LastSequenceReached = "True"
                        ''If the prefix just taken above is the last one, set the prefix to the first one   I MAY NEED THE LINE OF CODE BELOW IN THE FUTURE
                        'u.ExecuteSQL(SqlConnection1, "DELETE FROM tblDocTypePrefixLevelThree_NextSequences WHERE Where DocumentType = '" & DocTypeSelected & "' And Series = '" & SeriesSelected & "' And Location = '" & CanadaOrUSA & "' And DrawingOrReport = 'Drawing'")
                    Else
                        u.ExecuteSQL(SqlConnection1, "UPDATE tblDocTypePrefixLevelThree_NextSequences SET PreviousPrefix = '" & USADrawingLastPrefix & "' Where RecordID = '" & USADrawingRecordID & "'")
                    End If

                    'Increase sequence if the sequence just used is not the last one
                Else
                    'Add one to the prefix sequence and to the table
                    IncreasePrefixByOne(NextPrefixDrawingUSA)
                    u.ExecuteSQL(SqlConnection1, "UPDATE tblDocTypePrefixLevelThree_NextSequences SET NextPrefix = '" & PrefixIncreasedByOne & "', PreviousPrefix = '" & NextPrefixDrawingUSA & "' Where DocumentType = '" & DocTypeSelected & "' And Series = '" & SeriesSelected & "' And Location = '" & CanadaOrUSA & "' And DrawingOrReport = 'Drawing'")
                End If

            End If

            'If it is the first sequence run the Else below
        Else

            da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocTypePrefixLevelThree Where DocumentType = '" & DocTypeSelected & "' And DrawingOrReport = 'Drawing' Order By RecordID Desc", SqlConnection1)
            da.Fill(ds, "USADrawingDocSeqIdentifier")
            USADrawingRecordID = ds.Tables("USADrawingDocSeqIdentifier").Rows(0).Item("RecordID")
            USADrawingDocSeqIdentifier = ds.Tables("USADrawingDocSeqIdentifier").Rows(0).Item("Prefix")
            USADrawingDocType = ds.Tables("USADrawingDocSeqIdentifier").Rows(0).Item("DocumentType")
            USADrawingTrailing = ds.Tables("USADrawingDocSeqIdentifier").Rows(0).Item("Trailing")
            USADrawingLastPrefix = ds.Tables("USADrawingDocSeqIdentifier").Rows(0).Item("LastPrefix")
            NextPrefixDrawingUSA = ds.Tables("USADrawingDocSeqIdentifier").Rows(0).Item("NextPrefix")
            USADrawingPreviousPrefix = ds.Tables("USADrawingDocSeqIdentifier").Rows(0).Item("PreviousPrefix")
            USADrawingClassification = ds.Tables("USADrawingDocSeqIdentifier").Rows(0).Item("DrawingOrReport")
            'USADrawingActive = ds.Tables("USADrawingDocSeqIdentifier").Rows(0).Item("Active")
            ds.Tables("USADrawingDocSeqIdentifier").Clear()
            ds.Tables("USADrawingDocSeqIdentifier").Dispose()

            If USADrawingTrailing = "0" Then
                LoopedAlreadyForTrailingZero = "True"
            Else
                IncreasePrefixByOne(NextPrefixDrawingUSA)
                u.ExecuteSQL(SqlConnection1, "Insert into tblDocTypePrefixLevelThree_NextSequences (DocumentType, Series, Prefix, NextPrefix, PreviousPrefix, LastPrefix, Trailing, DrawingOrReport, Location) Values ('" & USADrawingDocType & "', '" & SeriesSelected & "', '" & USADrawingDocSeqIdentifier & "', '" & PrefixIncreasedByOne & "', '" & USADrawingDocSeqIdentifier & "', '" & USADrawingLastPrefix & "', '" & USADrawingTrailing & "', 'Drawing', '" & CanadaOrUSA & "')")
            End If
        End If

        'PREVIOUS BLOCK OF CODE
        'If USADrawingTrailing = "0" Then
        '    'Nothing
        'Else
        '    'If it is the last number in the sequence: 
        '    'get the first prefix of the doc type, delete all records where FirstPrefix <> to the first prefix just taken
        '    If USADrawingDocSeqIdentifier = USADrawingLastPrefix Then
        '        da = New SqlClient.SqlDataAdapter("Select TOP 1 * From tblDocTypePrefixLevelThree Where DocumentType = '" & DocTypeSelected & "' And DrawingOrReport = 'Drawing' Order By RecordID", SqlConnection1)
        '        da.Fill(ds, "FirstPrefixDrawing")
        '        FirstPrefixDrawing = ds.Tables("FirstPrefixDrawing").Rows(0).Item("Prefix")

        '        If FirstPrefixDrawing = "" Then
        '            'Nothing
        '        Else
        '            u.ExecuteSQL(SqlConnection1, "DELETE FROM tblDocTypePrefixLevelThree WHERE DocumentType = '" & DocTypeSelected & "' And Prefix != '" & FirstPrefixDrawing & "' And DrawingOrReport = 'Drawing'")
        '        End If

        '        ds.Tables("FirstPrefixDrawing").Clear()
        '        ds.Tables("FirstPrefixDrawing").Dispose()
        '    Else
        '        'Add one to the prefix sequence and to the table
        '        IncreasePrefixByOne(USADrawingDocSeqIdentifier)
        '        u.ExecuteSQL(SqlConnection1, "Insert into " & tableToIncreaseSeq & " (Prefix,DocumentType,LastPrefix,Trailing,DrawingOrReport,Active) Values ('" & PrefixIncreasedByOne & "','" & USADrawingDocType & "','" & USADrawingLastPrefix & "','" & USADrawingTrailing & "','" & USADrawingClassification & "', 0)")
        '    End If
        'End If
    End Function

    'REPORT CANADA PREFIX
    Public Function GetPrefixReportCanada(tableToIncreaseSeq As String)
        Dim CanadaReportRecordID As String = ""
        Dim CanadaReportDocType As String = ""
        Dim CanadaReportClassification As String = ""
        'Dim CanadaReportActive As String = ""
        Dim CanadaReportLastPrefix As String = ""
        Dim CanadaReportPreviousPrefix As String = ""
        Dim FirstPrefixReport As String = ""
        PrefixIncreasedByOne = ""

        'Get the document type without the numbers showing in front of the doc type selected from drop-down; for Canada reports
        da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocTypeInDropdown = '" & SelectedDocType & "'", SqlConnection1)
        da.Fill(ds, "DocTypeWithoutNumbers")
        DocTypeSelected = ds.Tables("DocTypeWithoutNumbers").Rows(0).Item("DocumentType")
        ds.Tables("DocTypeWithoutNumbers").Clear()
        ds.Tables("DocTypeWithoutNumbers").Dispose()


        'Get Sequence
        'If it is not the first sequence code goes to another table that keeps track of the sequences

        If ProjectNameSelected = "" Then
            ProjectNameSelected = cboProject.Text
        End If

        'da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "' And Classification = 'Report' Order By RecordID Desc", SqlConnection1)   'Before was tblDocTypePrefixLevelTwo
        If DocTypeSelected = "59 Engineering Order (Mechanical)" Or DocTypeSelected = "59 Engineering Order (Electrical)" Or DocTypeSelected = "Engineering Order (Mechanical)" Or DocTypeSelected = "Engineering Order (Electrical)" Then
            Dim DocTypeSelectEng As String = "Engineering Order"
            da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocumentType_NextSequences Where DocumentType = '" & DocTypeSelectEng & "' And Location = '" & CanadaOrUSA & "' And Program = '" & ProjectNameSelected & "' And DrawingOrReport = 'Report' Order By RecordID Desc", SqlConnection1)
        Else
            da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocumentType_NextSequences Where DocumentType = '" & DocTypeSelected & "' And Location = '" & CanadaOrUSA & "' And Program = '" & ProjectNameSelected & "' And DrawingOrReport = 'Report' Order By RecordID Desc", SqlConnection1)
        End If

        da.Fill(ds, "CanadaReportNextDocSeq")

        If ds.Tables("CanadaReportNextDocSeq").Rows.Count > 0 Then

            NextPrefixReportCanada = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("NextPrefix")
            CanadaReportRecordID = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("RecordID")
            CanadaReportDocSeqIdentifier = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("Prefix")
            CanadaReportDocType = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("DocumentType")
            CanadaReportTrailing = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("Trailing")
            CanadaReportLastPrefix = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("LastPrefix")
            CanadaReportPreviousPrefix = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("PreviousPrefix")
            CanadaReportClassification = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("DrawingOrReport")
            'CanadaReportActive = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("Active")
            ds.Tables("CanadaReportNextDocSeq").Clear()
            ds.Tables("CanadaReportNextDocSeq").Dispose()

            'If trailing is zero there is no need to increase the sequence
            If CanadaReportTrailing = "0" Then
                LoopedAlreadyForTrailingZero = "True"

                'Increase Sequence if needed
            Else

                'If the sequence is the last one, if it is already been used fire msgbox; if it is not been used use it and then set PreviousPrefix to LastPrefix -> 
                'so that next time if the sequence Is the last one again it does Not get used
                If NextPrefixReportCanada = CanadaReportLastPrefix Then

                    If CanadaReportPreviousPrefix = CanadaReportLastPrefix Then
                        MsgBox("Last Sequence Reached. You have no available sequences for the selection you made")
                        LastSequenceReached = "True"
                        ''If the prefix just taken above is the last one, set the prefix to the first one           'I MAY NEED THE LINE OF CODE BELOW IN THE FUTURE
                        'u.ExecuteSQL(SqlConnection1, "DELETE FROM tblDocumentType_NextSequences WHERE Where DocumentType = '" & DocTypeSelected & "' And Series = '" & SeriesSelected & "' And Location = '" & CanadaOrUSA & "' And DrawingOrReport = 'Report'")
                    Else
                        u.ExecuteSQL(SqlConnection1, "UPDATE tblDocumentType_NextSequences SET PreviousPrefix = '" & CanadaReportLastPrefix & "' Where RecordID = '" & CanadaReportRecordID & "'")
                    End If

                    'Increase sequence if the sequence just used is not the last one
                Else
                    'Add one to the prefix sequence and to the table
                    IncreasePrefixByOne(NextPrefixReportCanada)
                    u.ExecuteSQL(SqlConnection1, "UPDATE tblDocumentType_NextSequences SET NextPrefix = '" & PrefixIncreasedByOne & "', PreviousPrefix = '" & NextPrefixReportCanada & "' Where RecordID = '" & CanadaReportRecordID & "'")
                End If
            End If

            'If it is the first sequence run the Else below
        Else

            da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocumentType Where DocumentType = '" & DocTypeSelected & "' And Classification = 'Report' Order By RecordID Desc", SqlConnection1)
            da.Fill(ds, "CanadaReportDocSeqIdentifier")

            ''Next block of code is to add in case they start selecting Active document types that have no prefix populated and get an error(in the tblDocumentType in this case). Then this would have to be done to the other types as well
            ''Do not move along if there is no prefix
            'If IsDBNull(ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("NextPrefix")) Then
            '    MsgBox("There was no prefix for your selection")
            '    NoPrefix = "Yes"
            '    Exit Function
            'ElseIf ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("NextPrefix") = "" Then
            '    MsgBox("There was no prefix for your selection")
            '    NoPrefix = "Yes"
            '    Exit Function
            'End If

            NextPrefixReportCanada = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("NextPrefix")
            CanadaReportRecordID = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("RecordID")
            CanadaReportDocSeqIdentifier = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("Prefix")
            CanadaReportDocType = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("DocumentType")
            If CanadaReportDocType = "Engineering Order (Mechanical)" Or CanadaReportDocType = "Engineering Order (Electrical)" Then
                CanadaReportDocType = "Engineering Order"
            End If
            CanadaReportTrailing = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("Trailing")
            CanadaReportLastPrefix = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("LastPrefix")
            CanadaReportPreviousPrefix = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("PreviousPrefix")
            CanadaReportClassification = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("Classification")
            ds.Tables("CanadaReportDocSeqIdentifier").Clear()
            ds.Tables("CanadaReportDocSeqIdentifier").Dispose()

            If CanadaReportTrailing = "0" Then
                LoopedAlreadyForTrailingZero = "True"
            Else
                IncreasePrefixByOne(NextPrefixReportCanada)
                u.ExecuteSQL(SqlConnection1, "Insert into tblDocumentType_NextSequences (DocumentType, Program, Prefix, NextPrefix, PreviousPrefix, LastPrefix, Trailing, DrawingOrReport, Location) Values ('" & CanadaReportDocType & "', '" & ProjectNameSelected & "', '" & CanadaReportDocSeqIdentifier & "', '" & PrefixIncreasedByOne & "', '" & CanadaReportDocSeqIdentifier & "', '" & CanadaReportLastPrefix & "', '" & CanadaReportTrailing & "', 'Report', '" & CanadaOrUSA & "')")
            End If
        End If


        'PREVIOUS BLOCK OF CODE
        'Dim CanadaReportRecordID As String = ""
        'Dim CanadaReportDocType As String = ""
        'Dim CanadaReportClassification As String = ""
        'Dim CanadaReportActive As String = ""
        'Dim CanadaReportLastPrefix As String = ""
        'Dim FirstPrefixReport As String = ""
        'PrefixIncreasedByOne = ""

        ''Get Sequence Prefix
        'da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "' And Classification = 'Report' Order By RecordID Desc", SqlConnection1)   'Before was tblDocTypePrefixLevelTwo
        'da.Fill(ds, "CanadaReportDocSeqIdentifier")
        'CanadaReportRecordID = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("RecordID")
        'CanadaReportDocSeqIdentifier = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("Prefix")
        'CanadaReportDocType = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("DocumentType")
        'CanadaReportTrailing = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("Trailing")
        'NextPrefixReportCanada = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("NextPrefix")
        'CanadaReportLastPrefix = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("LastPrefix")
        'CanadaReportClassification = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("Classification")
        'CanadaReportActive = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("Active")
        'ds.Tables("CanadaReportDocSeqIdentifier").Clear()
        'ds.Tables("CanadaReportDocSeqIdentifier").Dispose()

        'If CanadaReportTrailing = "0" Then
        '    'Nothing
        'Else

        '    'If the prefix just taken above is the last one, set the prefix to the first one
        '    If NextPrefixReportCanada = CanadaReportLastPrefix Then
        '        u.ExecuteSQL(SqlConnection1, "UPDATE tblDocumentType SET NextPrefix = '" & CanadaReportDocSeqIdentifier & "', PreviousPrefix = '" & CanadaReportDocSeqIdentifier & "' Where RecordID = '" & CanadaReportRecordID & "'")
        '    Else
        '        'Add one to the prefix sequence and to the table
        '        IncreasePrefixByOne(NextPrefixReportCanada)
        '        u.ExecuteSQL(SqlConnection1, "UPDATE tblDocumentType SET NextPrefix = '" & PrefixIncreasedByOne & "', PreviousPrefix = '" & NextPrefixReportCanada & "' Where RecordID = '" & CanadaReportRecordID & "'")
        '    End If

        'End If
    End Function

    'DRAWING CANADA 5 DIGIT SEQUENTIAL PREFIX
    Public Function GetPrefixDrawingCanada(tableToIncreaseSeq As String)
        Dim CanadaDrawingRecordID As String = ""
        Dim CanadaDrawingDocType As String = ""
        Dim CanadaDrawingTrailing As String = ""
        Dim CanadaDrawingClassification As String = ""
        Dim CanadaDrawingActive As String = ""
        Dim CanadaDrawingLastPrefix As String = ""
        Dim CanadaDrawingPreviousPrefix As String = ""
        Dim FirstPrefixDrawing As String = ""
        PrefixIncreasedByOne = ""

        'Get Sequence
        'If it is not the first sequence code goes to another table that keeps track of the sequences
        'da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocumentType_NextSequences Where DocumentType = '" & DocTypeSelected & "' And Series = '" & SeriesSelected & "' And Location = '" & CanadaOrUSA & "' And DrawingOrReport = 'Drawing' Order By RecordID Desc", SqlConnection1)   'Before was tblDocTypePrefixLevelTwo
        da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocumentType_NextSequences_DrawCanada Where Series = '" & SeriesSelected & "' And Location = '" & CanadaOrUSA & "' And DrawingOrReport = 'Drawing' Order By RecordID Desc", SqlConnection1)   'Before was tblDocTypePrefixLevelTwo
        da.Fill(ds, "CanadaDrawingNextDocSeq")

        If ds.Tables("CanadaDrawingNextDocSeq").Rows.Count > 0 Then
            CanadaDrawingRecordID = ds.Tables("CanadaDrawingNextDocSeq").Rows(0).Item("RecordID")
            CanadaDrawingDocSeqIdentifier = ds.Tables("CanadaDrawingNextDocSeq").Rows(0).Item("Prefix")
            'CanadaDrawingDocType = ds.Tables("CanadaDrawingNextDocSeq").Rows(0).Item("DocumentType")
            CanadaDrawingTrailing = ds.Tables("CanadaDrawingNextDocSeq").Rows(0).Item("Trailing")
            NextPrefixDrawingCanada = ds.Tables("CanadaDrawingNextDocSeq").Rows(0).Item("NextPrefix")
            CanadaDrawingLastPrefix = ds.Tables("CanadaDrawingNextDocSeq").Rows(0).Item("LastPrefix")
            CanadaDrawingPreviousPrefix = ds.Tables("CanadaDrawingNextDocSeq").Rows(0).Item("PreviousPrefix")
            CanadaDrawingClassification = ds.Tables("CanadaDrawingNextDocSeq").Rows(0).Item("DrawingOrReport")
            'CanadaDrawingActive = ds.Tables("CanadaDrawingDocSeqIdentifier").Rows(0).Item("Active")
            ds.Tables("CanadaDrawingNextDocSeq").Clear()
            ds.Tables("CanadaDrawingNextDocSeq").Dispose()

            'If trailing is zero there is no need to increase the sequence
            If CanadaDrawingTrailing = "0" Then
                LoopedAlreadyForTrailingZero = "True"

                'Increase Sequence if needed
            Else

                'If the sequence is the last one, if it is already been used fire msgbox; if it is not been used use it and then set PreviousPrefix to LastPrefix -> 
                'so that next time if the sequence Is the last one again it does Not get used
                If NextPrefixDrawingCanada = CanadaDrawingLastPrefix Then

                    If CanadaDrawingPreviousPrefix = CanadaDrawingLastPrefix Then
                        MsgBox("Last Sequence Reached. You have no available sequences for the selection you made")
                        LastSequenceReached = "True"
                        ''If the prefix just taken above is the last one, set the prefix to the first one           'I MAY NEED THE LINE OF CODE BELOW IN THE FUTURE
                        'u.ExecuteSQL(SqlConnection1, "DELETE FROM tblDocumentType_NextSequences WHERE Where DocumentType = '" & DocTypeSelected & "' And Series = '" & SeriesSelected & "' And Location = '" & CanadaOrUSA & "' And DrawingOrReport = 'Drawing'")
                    Else
                        'u.ExecuteSQL(SqlConnection1, "UPDATE tblDocumentType_NextSequences SET PreviousPrefix = '" & CanadaDrawingLastPrefix & "' Where RecordID = '" & CanadaDrawingRecordID & "'")
                        u.ExecuteSQL(SqlConnection1, "UPDATE tblDocumentType_NextSequences_DrawCanada SET PreviousPrefix = '" & CanadaDrawingLastPrefix & "' Where RecordID = '" & CanadaDrawingRecordID & "'")
                    End If

                    'Increase sequence if the sequence just used is not the last one
                Else
                    'Add one to the prefix sequence and to the table
                    IncreasePrefixByOne(NextPrefixDrawingCanada)
                    'u.ExecuteSQL(SqlConnection1, "Insert into " & tableToIncreaseSeq & " (Prefix,DocumentType,LastPrefix,Trailing,Classification,Active) Values ('" & PrefixIncreasedByOne & "','" & CanadaDrawingDocType & "','" & CanadaDrawingLastPrefix & "','" & CanadaDrawingTrailing & "','" & CanadaDrawingClassification & "', 0)")
                    'u.ExecuteSQL(SqlConnection1, "UPDATE tblDocumentType_NextSequences SET NextPrefix = '" & PrefixIncreasedByOne & "', PreviousPrefix = '" & NextPrefixDrawingCanada & "' Where RecordID = '" & CanadaDrawingRecordID & "'")
                    u.ExecuteSQL(SqlConnection1, "UPDATE tblDocumentType_NextSequences_DrawCanada SET NextPrefix = '" & PrefixIncreasedByOne & "', PreviousPrefix = '" & NextPrefixDrawingCanada & "' Where RecordID = '" & CanadaDrawingRecordID & "'")
                End If
            End If

            '    'If it is the first sequence run the Else below
            'Else

            '    da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocumentType Where DocumentType = '" & DocTypeSelected & "' And Classification = 'Drawing' Order By RecordID Desc", SqlConnection1)
            '    da.Fill(ds, "CanadaDrawingDocSeqIdentifier")
            '    CanadaDrawingRecordID = ds.Tables("CanadaDrawingDocSeqIdentifier").Rows(0).Item("RecordID")
            '    CanadaDrawingDocSeqIdentifier = ds.Tables("CanadaDrawingDocSeqIdentifier").Rows(0).Item("Prefix")
            '    CanadaDrawingDocType = ds.Tables("CanadaDrawingDocSeqIdentifier").Rows(0).Item("DocumentType")
            '    CanadaDrawingTrailing = ds.Tables("CanadaDrawingDocSeqIdentifier").Rows(0).Item("Trailing")
            '    CanadaDrawingLastPrefix = ds.Tables("CanadaDrawingDocSeqIdentifier").Rows(0).Item("LastPrefix")
            '    NextPrefixDrawingCanada = ds.Tables("CanadaDrawingDocSeqIdentifier").Rows(0).Item("NextPrefix")
            '    CanadaDrawingPreviousPrefix = ds.Tables("CanadaDrawingDocSeqIdentifier").Rows(0).Item("PreviousPrefix")
            '    CanadaDrawingClassification = ds.Tables("CanadaDrawingDocSeqIdentifier").Rows(0).Item("Classification")
            '    ds.Tables("CanadaDrawingDocSeqIdentifier").Clear()
            '    ds.Tables("CanadaDrawingDocSeqIdentifier").Dispose()

            '    If CanadaDrawingTrailing = "0" Then
            '        LoopedAlreadyForTrailingZero = "True"
            '    Else
            '        IncreasePrefixByOne(NextPrefixDrawingCanada)
            '        u.ExecuteSQL(SqlConnection1, "Insert into tblDocumentType_NextSequences (DocumentType, Series, Prefix, NextPrefix, PreviousPrefix, LastPrefix, Trailing, DrawingOrReport, Location) Values ('" & CanadaDrawingDocType & "', '" & SeriesSelected & "', '" & CanadaDrawingDocSeqIdentifier & "', '" & PrefixIncreasedByOne & "', '" & CanadaDrawingDocSeqIdentifier & "', '" & CanadaDrawingLastPrefix & "', '" & CanadaDrawingTrailing & "', 'Drawing', '" & CanadaOrUSA & "')")
            '    End If

        End If
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtTitle_Validated(sender As Object, e As EventArgs) Handles txtTitle.Validated
        Me.txtTitle.Text = UCase(Me.txtTitle.Text)
    End Sub

    'SHOW THE SERIES TREEVIEW IF IT IS CANADA AND DRAWINGS - LEVEL 3
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        'Get Doc Type selected by user
        DocTypeSelected = TreeView1.SelectedNode.Text


        'Get the text that will display in the label that shows the level 2 selection when there are 3 levels
        'Check if Drawings or Reports has been chosen. To use with following block of code
        Dim DocTypeSelectedDisplayLevelTwo As String = TreeView1.SelectedNode.FullPath
        Dim seeIfDrawingOrReport As String = ""
        If DocTypeSelectedDisplayLevelTwo = "Drawings" Then
            'Nothing
        ElseIf DocTypeSelectedDisplayLevelTwo = "Reports" Then
            'Nothing
        Else

            seeIfDrawingOrReport = DocTypeSelectedDisplayLevelTwo.Substring(0, DocTypeSelectedDisplayLevelTwo.IndexOf("\"))

            'Get selected level 2 text
            If CanadaOrUSA = "Field Aerospace (OKC)" Then
                If seeIfDrawingOrReport = "Drawings" Then
                    DocTypeSelectedDisplayLevelTwo = DocTypeSelectedDisplayLevelTwo.Substring(9)

                    da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where DocumentType = '" & DocTypeSelectedDisplayLevelTwo & "'", SqlConnection1)
                    da.Fill(ds, "CheckIfDocLevelTwoWasSelected")
                    If ds.Tables("CheckIfDocLevelTwoWasSelected").Rows.Count > 0 Then
                        DocTypeSelectedDisplayLevelTwo = ""
                        ds.Tables("CheckIfDocLevelTwoWasSelected").Clear()
                        ds.Tables("CheckIfDocLevelTwoWasSelected").Dispose()
                    Else
                        DocTypeSelectedDisplayLevelTwo = DocTypeSelectedDisplayLevelTwo.Substring(0, DocTypeSelectedDisplayLevelTwo.IndexOf("\"))
                    End If

                ElseIf seeIfDrawingOrReport = "Reports" Then

                    DocTypeSelectedDisplayLevelTwo = DocTypeSelectedDisplayLevelTwo.Substring(8)

                    da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelectedDisplayLevelTwo & "'", SqlConnection1)
                    da.Fill(ds, "CheckIfDocLevelTwoWasSelected")
                    If ds.Tables("CheckIfDocLevelTwoWasSelected").Rows.Count > 0 Then
                        DocTypeSelectedDisplayLevelTwo = ""
                        ds.Tables("CheckIfDocLevelTwoWasSelected").Clear()
                        ds.Tables("CheckIfDocLevelTwoWasSelected").Dispose()
                    Else
                        DocTypeSelectedDisplayLevelTwo = DocTypeSelectedDisplayLevelTwo.Substring(0, DocTypeSelectedDisplayLevelTwo.IndexOf("\"))
                    End If

                End If
            End If
        End If



        'Only show the selected value in the label displaying the selected value if the value has been selected all the way through
        Dim textDisplayedInDocTypeLabel As String

        Dim a As String = TreeView1.SelectedNode.FullPath
        Dim checkIfDrawingOrReport As String = a.Substring(0, 1)

        If CanadaOrUSA = "Field Aerospace (Canada)" Then

            If checkIfDrawingOrReport = "R" Then
                da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "'", SqlConnection1)
            Else
                da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where DocumentType = '" & DocTypeSelected & "'", SqlConnection1)
            End If

            da.Fill(ds, "SelectedDocType")

            If ds.Tables("SelectedDocType").Rows.Count > 0 Then
                lblDocTypeSelected.Text = DocTypeSelected
                lblTextDocTypeSelected.Text = "Doc Type Selected:"
                lblDocTypeExisting.Text = ""
            Else
                lblDocTypeSelected.Text = ""
                lblTextDocTypeSelected.Text = ""
                lblDocTypeSelectedLevelTwo.Text = ""
            End If

            ds.Tables("SelectedDocType").Clear()
            ds.Tables("SelectedDocType").Dispose()

        ElseIf CanadaOrUSA = "Field Aerospace (OKC)" Then

            If DocTypeSelected = "59 Engineering Order (Mechanical)" Then
                da = New SqlClient.SqlDataAdapter("Select * from tblDocTypePrefixLevelThree Where DocumentType = 'Engineering Order (Mechanical)'", SqlConnection1)
            ElseIf DocTypeSelected = "59 Engineering Order (Electrical)" Then
                da = New SqlClient.SqlDataAdapter("Select * from tblDocTypePrefixLevelThree Where DocumentType = 'Engineering Order (Mechanical)'", SqlConnection1)
            Else
                da = New SqlClient.SqlDataAdapter("Select * from tblDocTypePrefixLevelThree Where DocumentType = '" & DocTypeSelected & "'", SqlConnection1)
            End If
            da.Fill(ds, "SelectedDocType")

            If ds.Tables("SelectedDocType").Rows.Count > 0 Then
                lblDocTypeSelected.Text = DocTypeSelected
                lblTextDocTypeSelected.Text = "Doc Type Selected:"
                lblDocTypeExisting.Text = ""
                lblDocTypeSelectedLevelTwo.Text = DocTypeSelectedDisplayLevelTwo
            Else
                lblDocTypeSelected.Text = ""
                lblTextDocTypeSelected.Text = ""
            End If

            ds.Tables("SelectedDocType").Clear()
            ds.Tables("SelectedDocType").Dispose()
        End If



        'Show the Series Treeview if it is Canada and Drawings - Level 3
        'If CanadaOrUSA = "Field Aerospace (Canada)" Then
        Dim DrawingsOrReport As String = TreeView1.SelectedNode.FullPath
        DrawingsOrReport = DrawingsOrReport.Substring(0, 1)

        If DrawingsOrReport = "R" Then
            If lblTextDocTypeSelected.Text = "Doc Type Selected:" Then
                'Nothing
            Else
                lblTextDocTypeSelected.Text = "No Doc Type Selected"
            End If
            DrawingsOrReport = "Report"
            lblSeries.Visible = False
            TreeView2.Visible = False
            btnJASCCodes.Visible = False
            lblTextSeriesSelected.Text = ""
            lblSeriesSelected.Text = ""
        ElseIf DrawingsOrReport = "D" Then
            DrawingsOrReport = "Drawing"
            lblSeries.Visible = True
            TreeView2.Visible = True
            btnJASCCodes.Visible = True
            TreeView2.Nodes.Clear()

            'Populate Series dropdown for Drawings - JASC Series - Level 3
            If CanadaOrUSA = "Field Aerospace (Canada)" And (DrawingsOrReport = "D" Or DrawingsOrReport = "Drawing") Then
                da = New SqlClient.SqlDataAdapter("Select Distinct SectionNumAndDesc from tblDocTypeJASC_Series", SqlConnection1)
            Else
                da = New SqlClient.SqlDataAdapter("Select Distinct SectionNumAndDesc From tblDocTypeJASC_Series Where SectionNumAndDesc != 'OTHER'", SqlConnection1)
            End If

            da.Fill(ds, "DrawingsType")

            For loopindex As Integer = 0 To ds.Tables("DrawingsType").Rows.Count - 1

                Dim root = New TreeNode(ds.Tables("DrawingsType").Rows(loopindex).Item("SectionNumAndDesc"))
                TreeView2.Nodes.Add(root)

                Dim SectionNumAndDesc As String = ds.Tables("DrawingsType").Rows(loopindex).Item("SectionNumAndDesc")

                da = New SqlClient.SqlDataAdapter("Select JASCAndDesc from tblDocTypeJASC_Series Where SectionNumAndDesc = '" & SectionNumAndDesc & "'", SqlConnection1)
                da.Fill(ds, "JASCDesc")
                For indexloop As Integer = 0 To ds.Tables("JASCDesc").Rows.Count - 1
                    TreeView2.Nodes(loopindex).Nodes.Add(New TreeNode(ds.Tables("JASCDesc").Rows(indexloop).Item("JASCAndDesc")))
                Next indexloop

                ds.Tables("JASCDesc").Clear()
                ds.Tables("JASCDesc").Dispose()
            Next loopindex


            If lblTextDocTypeSelected.Text = "" Then
                lblTextDocTypeSelected.Text = "No Doc Type Selected"
                lblDocTypeSelectedLevelTwo.Text = ""
                If lblDocTypeSelected.Text <> "" Then
                    lblTextDocTypeSelected.Text = "Doc Type Selected:"
                End If
            End If

            If lblTextSeriesSelected.Text = "" Then
                If MiscOrIssueNumber <> "Misc" Then
                    lblTextSeriesSelected.Text = "No Series Selected"
                End If
            End If

            ds.Tables("DrawingsType").Clear()
            ds.Tables("DrawingsType").Dispose()
        End If
        'End If


        initialClick = True


        DocTypeForGuide = ""
        DocTypeForGuide = DrawingsOrReport      'Save if Drawing or Report, to use in the Guide form


        'If user is modifying an existing doc number when it clicks on this treeview disable the signoff button. It will be re-enabled once they click on Issue Number
        If CreateOrModifyDocNum = "Modify" Then
            btnContinue.Enabled = False
        End If

        'Enable Issue Number button once they make a selection in the Treeview
        If MiscOrIssueNumber = "Misc" Then
            btnIssueNumber.Enabled = False

        Else
            'BLOCK OF CODE BELOW IS TO BE COMMENTED OUT (9 LINES), THEN LINE COMMENTED OUT "btnIssueNumber.Enabled = True" NEEDS TO BE UNCOMMENTED (only that line)
            If lblDocTypeSelected.Text = "Flammability Test Specimens" Then     'lblDocTypeSelected.Text = "Specification" Or lblDocTypeSelected.Text = "Tooling" Or lblDocTypeSelected.Text = "Vendor Supplied (Mechanical)" Or lblDocTypeSelected.Text = "Definition" Then
                btnIssueNumber.Enabled = False
            Else
                'If System.Environment.UserName = "ohaswell" Or System.Environment.UserName = "apptestcm1" Or System.Environment.UserName = "jwebster" Or System.Environment.UserName = "nsantagata" Or System.Environment.UserName = "jsprigg" Or System.Environment.UserName = "alee" Or System.Environment.UserName = "rdetillier" Or System.Environment.UserName = "llewis" Or System.Environment.UserName = "karcinas" Or System.Environment.UserName = "rduwel" Or System.Environment.UserName = "jrovenstine" Then
                If isNewRecord = "True" Then
                    btnIssueNumber.Enabled = True
                Else
                    btnIssueNumber.Enabled = False
                End If
            End If

            'btnIssueNumber.Enabled = True
        End If


        ''THIS BLOCK OF CODE (3 LINES) WILL BE COMMENTED OUT WHEN I GET THE LIST FROM JEFF SPRIGG. FOR NOW ALL THE CANADIAN DOCUMENTS CAN ONLY CHOOSE THE MISC BUTTON, AND NOT THE ISSUE ONE
        'If CanadaOrUSA = "Field Aerospace (Canada)" Then
        '    btnIssueNumber.Enabled = False
        'End If


        'If the document type selected is a Canada Drawing and it does not have a prefix then disable the btnIssueNumber button
        If CanadaOrUSA = "Field Aerospace (Canada)" And seeIfDrawingOrReport = "Drawings" Then

            da = New SqlClient.SqlDataAdapter("Select Prefix From tblDocumentType Where DocumentType = '" & DocTypeSelected & "' And Classification = 'Drawing'", SqlConnection1)
            da.Fill(ds, "IsPrefixEmpty")

            If ds.Tables("IsPrefixEmpty").Rows.Count > 0 Then
                If IsDBNull(ds.Tables("IsPrefixEmpty").Rows(0).Item("Prefix")) Then
                    DocTypePrefixEmpty = True
                    btnIssueNumber.Enabled = False
                ElseIf ds.Tables("IsPrefixEmpty").Rows(0).Item("Prefix") = "" Then
                    DocTypePrefixEmpty = True
                    btnIssueNumber.Enabled = False
                Else
                    DocTypePrefixEmpty = False
                End If
            End If

            ds.Tables("IsPrefixEmpty").Clear()
            ds.Tables("IsPrefixEmpty").Dispose()
        End If

    End Sub

    Private Sub btnJASCCodes_Click(sender As Object, e As EventArgs) Handles btnJASCCodes.Click
        JASCBtnFormA = "Yes"

        Dim frmEngWorkflowJASCCodes As New frmEngWorkflowJASCCodes
        frmEngWorkflowJASCCodes.ShowDialog()
    End Sub


    Private Sub btnGuide_Click(sender As Object, e As EventArgs) Handles btnGuide.Click
        Dim frmEngWorkflowGuide As New frmEngWorkflowGuide
        frmEngWorkflowGuide.ShowDialog()
    End Sub

    Private Sub btnIssueNumber_Click(sender As Object, e As EventArgs) Handles btnIssueNumber.Click

        '*****--------------------------------------------------------------------
        'The Issue Number button must be clicked to create a Doc Number
        'When instead the user clicks on Misc, all the previous choices are canceled(if it is a doc num created on Form A). The user must select all(Program,Project,DocType,Series)
        '*****--------------------------------------------------------------------


        'Dim Classification As String = ""
        Dim ProductGroupPrefix As String = ""
        Dim ProjectNumber As String = ""
        Dim JASCPrefix As String = ""
        Dim isDrawing As Boolean = False

        DocTypeSelected = ""
        SeriesSelected = ""
        USAReportDocSeqIdentifier = ""
        USADrawingDocSeqIdentifier = ""
        CanadaReportDocSeqIdentifier = ""
        CanadaDrawingDocSeqIdentifier = ""
        FinalDocNumber = ""
        MiscOrIssueNumber = ""
        LoopedAlreadyForTrailingZero = ""
        LastSequenceReached = ""
        ClassificationTypeAndLoc = ""
        MessageAlreadyDisplayed = ""
        NoPrefix = ""
        lblDocumentNum.Text = ""

        'btnCancel.Enabled = False
        btnDelete.Enabled = False
        btnContinue.Enabled = True


        txtDocNumber.Text = ""
        btnMisc.Enabled = False
        MiscOrIssueNumber = "Issue Number"

        If CreateOrModifyDocNum = "Modify" Then
            Dim result As DialogResult = MessageBox.Show("WARNING: Issuing another New Document Number will leave the document number currently assigned unavailable for use. Are you sure you want to assign another document number?", "Title", MessageBoxButtons.OKCancel)
            If (result = DialogResult.Cancel) Then
                Exit Sub
            End If
        End If

        'VALIDATE DOC TYPE is selected all the way through
        If IsNothing(TreeView1.SelectedNode) = True Then
            MsgBox("Please select Document Type")
            Exit Sub

        Else
            DocTypeSelected = TreeView1.SelectedNode.Text

            If CanadaOrUSA = "Field Aerospace (OKC)" Then

                'Check USA has a drawing or report selected all the way through
                da = New SqlClient.SqlDataAdapter("Select * from tblDocTypePrefixLevelThree Where DocumentType = '" & DocTypeSelected & "' And DrawingOrReport = 'Drawing'", SqlConnection1)
                da.Fill(ds, "SelectionMadeDrawing")

                If ds.Tables("SelectionMadeDrawing").Rows.Count > 0 Then
                    'Nothing
                    ds.Tables("SelectionMadeDrawing").Clear()
                    ds.Tables("SelectionMadeDrawing").Dispose()
                    DrawingOrReport = "Drawing"
                Else
                    If DocTypeSelected = "59 Engineering Order (Mechanical)" Then
                        da = New SqlClient.SqlDataAdapter("Select * from tblDocTypePrefixLevelThree Where DocumentType = 'Engineering Order (Mechanical)' And DrawingOrReport = 'Report'", SqlConnection1)
                    ElseIf DocTypeSelected = "59 Engineering Order (Electrical)" Then
                        da = New SqlClient.SqlDataAdapter("Select * from tblDocTypePrefixLevelThree Where DocumentType = 'Engineering Order (Electrical)' And DrawingOrReport = 'Report'", SqlConnection1)
                    Else
                        da = New SqlClient.SqlDataAdapter("Select * from tblDocTypePrefixLevelThree Where DocumentType = '" & DocTypeSelected & "' And DrawingOrReport = 'Report'", SqlConnection1)
                    End If

                    da.Fill(ds, "SelectionMade")

                    If ds.Tables("SelectionMade").Rows.Count > 0 Then
                        'Nothing
                        ds.Tables("SelectionMade").Clear()
                        ds.Tables("SelectionMade").Dispose()
                        DrawingOrReport = "Report"
                    Else
                        MsgBox("Please select the Document Type")
                        Exit Sub
                    End If
                End If

            ElseIf CanadaOrUSA = "Field Aerospace (Canada)" Then

                'Check Canada has a drawing or report selected all the way through
                da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where DocumentType = '" & DocTypeSelected & "' And Classification = 'Drawing'", SqlConnection1)    'Before was tblDocTypePrefixLevelTwo
                da.Fill(ds, "SelectionMadeDrawing")

                If ds.Tables("SelectionMadeDrawing").Rows.Count > 0 Then
                    'Nothing
                    ds.Tables("SelectionMadeDrawing").Clear()
                    ds.Tables("SelectionMadeDrawing").Dispose()
                    DrawingOrReport = "Drawing"

                Else
                    If DocTypeSelected = "Engineering Order (Mechanical)" Then
                        SelectedDocType = "59 Engineering Order (Mechanical)"
                    ElseIf DocTypeSelected = "Engineering Order (Electrical)" Then
                        SelectedDocType = "59 Engineering Order (Electrical)"
                    Else
                        SelectedDocType = DocTypeSelected
                    End If

                    da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where DocTypeInDropdown = '" & SelectedDocType & "' And Classification = 'Report'", SqlConnection1)   'Before was tblDocTypePrefixLevelTwo
                    da.Fill(ds, "SelectionMade")

                    If ds.Tables("SelectionMade").Rows.Count > 0 Then
                        'Nothing
                        ds.Tables("SelectionMade").Clear()
                        ds.Tables("SelectionMade").Dispose()
                        DrawingOrReport = "Report"
                    Else
                        MsgBox("Please select the Document Type")
                        Exit Sub
                    End If
                End If
            End If
        End If


        'VALIDATE SERIES is selected all the way through
        If DrawingOrReport = "Drawing" Then
            If IsNothing(TreeView2.SelectedNode) = True Then
                MsgBox("Please select Series")
                Exit Sub
            Else
                SeriesSelected = TreeView2.SelectedNode.Text

                da = New SqlClient.SqlDataAdapter("Select * from tblDocTypeJASC_Series Where JASCAndDesc = '" & SeriesSelected & "'", SqlConnection1)
                da.Fill(ds, "SelectionMadeSeries")

                If ds.Tables("SelectionMadeSeries").Rows.Count > 0 Then
                    'Nothing
                    ds.Tables("SelectionMadeSeries").Clear()
                    ds.Tables("SelectionMadeSeries").Dispose()
                Else
                    If MiscOrIssueNumber <> "Misc" Then
                        MsgBox("Please select the Series")
                        Exit Sub
                    End If
                End If
                End If
        End If


        'VALIDATION
        Dim msg As String = ""

        If Me.cboProgram.Text = "" Then
            msg = msg + "Program is required to be selected." & vbCrLf
        End If
        If Me.cboProject.Text = "" Then
            msg = msg + "Project is required to be selected." & vbCrLf
        End If
        If DocTypeSelected = "" Then
            msg = msg + "Document Type selection required." & vbCrLf
        End If
        If DrawingOrReport = "Drawing" Then
            If SeriesSelected = "" Then
                msg = msg + "Series selection required." & vbCrLf
            End If
        End If

        If msg = "" Then
            'Nothing
        Else
            msg = msg + "Please fix errors and click continue again."
            MsgBox(msg)
            msg = ""
            Exit Sub
        End If


        'Clear out label containing Doc Type and Series selected in Form A
        lblDocTypeExisting.Text = ""
        lblSeriesExisting.Text = ""


        'IF ISSUING ANOTHER DOC NUMBER DIFFERENT FROM THE ONE CREATED IN FORM A THEN THE SEQUENCE NEED TO BE RESET; RESET ONLY IF THE DOC NUMBER HAS THE LAST SEQUENCE USED
        If CreateOrModifyDocNum = "Modify" Then
            ResetOrNot()
        End If

        'START GETTING DATA TO CREATE DOC NUMBER -------------------------------------------

        'Get Product Group Prefix and Project Number: Product Group for USA Drawing and Report; Project Number for Canada Report
        If ProjectNameSelected = "" Then
            ProjectNameSelected = cboProject.Text
        End If

        da = New SqlClient.SqlDataAdapter("Select ProductGroup, ProjectNumber from tblProjects Where ProjectName = '" & ProjectNameSelected & "'", SqlConnection1)
        'da = New SqlClient.SqlDataAdapter("Select ProductGroup, ProjectNumber from tblProgram Where ProgramName = '" & cboProject.Text & "'", SqlConnection1)
        da.Fill(ds, "ProjectsTable")
        If CanadaOrUSA = "Field Aerospace (OKC)" Then
            ProductGroupPrefix = ds.Tables("ProjectsTable").Rows(0).Item("ProductGroup")
        ElseIf CanadaOrUSA = "Field Aerospace (Canada)" Then
            ProjectNumber = ds.Tables("ProjectsTable").Rows(0).Item("ProjectNumber")
            If ProjectNumber = "0" Then
                ProjectNumber = "0000"
            End If
        End If
        ds.Tables("ProjectsTable").Clear()
        ds.Tables("ProjectsTable").Dispose()

GETANOTHERPREFIX:
        'DRAWINGS
        If DrawingOrReport = "Drawing" Then
            'If Drawing always get the 4 digits JASC code
            da = New SqlClient.SqlDataAdapter("Select JASCPrefix from tblDocTypeJASC_Series Where JASCAndDesc = '" & SeriesSelected & "'", SqlConnection1)
            da.Fill(ds, "JASCPrefix")
            JASCPrefix = ds.Tables("JASCPrefix").Rows(0).Item("JASCPrefix")
            ds.Tables("JASCPrefix").Clear()
            ds.Tables("JASCPrefix").Dispose()

            If CanadaOrUSA = "Field Aerospace (OKC)" Then
                'Get 4 digits prefix: 2 digits level-3-Drawing-Sequence-Identifier + sequential number
                GetPrefixDrawingUSA("tblDocTypePrefixLevelThree")
                FinalDocNumber = ProductGroupPrefix & "-" & JASCPrefix & "-" & NextPrefixDrawingUSA
            ElseIf CanadaOrUSA = "Field Aerospace (Canada)" Then
                '5 Digit sequential number Drawing Canada
                GetPrefixDrawingCanada("tblDocumentType")   'Before it was tblDocTypePrefixLevelTwo
                FinalDocNumber = JASCPrefix & NextPrefixDrawingCanada
            End If

            'REPORTS
        ElseIf DrawingOrReport = "Report" Then
            'Next 5 lines are for Report USA

            'If DocTypeSelected = "59 Engineering Order (Mechanical)" Or DocTypeSelected = "59 Engineering Order (Electrical)" Then
            'ADDED next line and commented line above 08/02
            If DocTypeSelected = "Engineering Order (Mechanical)" Or DocTypeSelected = "Engineering Order (Electrical)" Or DocTypeSelected = "59 Engineering Order (Mechanical)" Or DocTypeSelected = "59 Engineering Order (Electrical)" Then
                JASCPrefix = "EO"
            Else
                JASCPrefix = "0000"
            End If

            If CanadaOrUSA = "Field Aerospace (OKC)" Then
                GetPrefixReportUSA("tblDocTypePrefixLevelThree")
                FinalDocNumber = ProductGroupPrefix & "-" & JASCPrefix & "-" & NextPrefixReportUSA
            ElseIf CanadaOrUSA = "Field Aerospace (Canada)" Then
                'Get 4 digits prefix: prefix + sequential number
                GetPrefixReportCanada("tblDocumentType")    'Before it was tblDocTypePrefixLevelTwo
                'Next block of code is to add in case they start selecting Active document types that have no prefix populated and get an error(in the tblDocumentType in this case). Then this would have to be done to the other types as well
                'If NoPrefix = "Yes" Then   
                '    NoPrefix = ""
                '    Exit Sub
                'End If
                FinalDocNumber = ProjectNumber & NextPrefixReportCanada
            End If
        End If


        'CHECK IF DRAWING NUMBER ALREADY EXISTS
        If FinalDocNumber <> "" Then
            da = New SqlClient.SqlDataAdapter("Select * from tblDrawings Where DrawingNumber = '" & FinalDocNumber & "'", SqlConnection1)
            da.Fill(ds, "Getit")

            If ds.Tables("Getit").Rows.Count > 0 Then
                If LoopedAlreadyForTrailingZero = "True" Then
                    'If the prefix of a sequence with a zero trailing has already been used
                    MsgBox("Only one sequence was available for the selection you made and it was already used.")
                    ds.Tables("Getit").Clear()
                    ds.Tables("Getit").Dispose()
                    Exit Sub
                Else
                    If LastSequenceReached = "True" Then
                        ds.Tables("Getit").Clear()
                        ds.Tables("Getit").Dispose()
                        Exit Sub
                    Else
                        If MessageAlreadyDisplayed <> "True" Then
                            MsgBox("Drawing Number " & FinalDocNumber & " Already Exists. The program will look for the next available sequence")
                            MessageAlreadyDisplayed = "True"
                            ds.Tables("Getit").Clear()
                            ds.Tables("Getit").Dispose()
                        Else
                            'Nothing
                            ds.Tables("Getit").Clear()
                            ds.Tables("Getit").Dispose()
                        End If

                        GoTo GETANOTHERPREFIX
                    End If
                End If

                ds.Tables("Getit").Clear()
                ds.Tables("Getit").Dispose()
            End If

        Else
            FinalDocNumber = "NEEDS ASSIGNED " & Format(Now, "MMddyyyyHHmmss")
            NeedsAssigned = FinalDocNumber
        End If




        'NewReworkFormB is used in the Sign Off button
        NewReworkFormB = ""
        NewReworkFormB = TreeView1.SelectedNode.FullPath
        NewReworkFormB = NewReworkFormB.Substring(0, 1)
        If NewReworkFormB = "R" Then
            NewReworkFormB = "New Report"
            ClassificationFormB = "Report"
        ElseIf NewReworkFormB = "D" Then
            NewReworkFormB = "New Drawing"
            ClassificationFormB = "Drawing"
        End If



        'The below 3 lines are used in the Sign Off button to insert an MDL
        If DocTypeSelected = "00 Master Data List" Then
            DocTypeDocNumToModify = "Master Data List"
        End If


        'Get the data to update tblDrawings: if modifying a doc and after clicking on Issue Number
        UpdateDocType = lblDocTypeSelectedLevelTwo.Text
        UpdateDocTypeLevelThree = lblDocTypeSelected.Text
        UpdateSeries = lblSeriesSelected.Text

        If UpdateDocTypeLevelThree = "59 Engineering Order (Mechanical)" Then
            UpdateDocType = "Engineering Order (Mechanical)"
            UpdateDocTypeLevelThree = "Engineering Order (Mechanical)"
        ElseIf UpdateDocTypeLevelThree = "59 Engineering Order (Electrical)" Then
            UpdateDocType = "Engineering Order (Electrical)"
            UpdateDocTypeLevelThree = "Engineering Order (Electrical)"
        End If


        'Populate Doc Num textbox
        txtDocNumber.Text = FinalDocNumber
        txtDocNumber.Enabled = False
        'btnIssueNumber.Enabled = False


        lblTextDocTypeSelected.Text = "Doc Type Selected:"
        If lblSeriesSelected.Text <> "" Then
            lblTextSeriesSelected.Text = "Series Selected:"
        End If
        lblDocTypeExisting.Text = ""
        lblSeriesExisting.Text = ""

    End Sub

    Private Sub btnMisc_Click(sender As Object, e As EventArgs) Handles btnMisc.Click

        'DocTypeSelected = ""
        'SeriesSelected = ""
        MiscOrIssueNumber = ""
        MiscOrIssueNumber = "Misc"
        'TreeView1.Visible = False
        btnContinue.Enabled = True
        btnIssueNumber.Enabled = False
        btnMisc.Enabled = False
        'btnCancel.Enabled = False
        btnDelete.Enabled = False
        txtDocNumber.Enabled = True
        txtDocNumber.Text = ""

        'lblTextDocTypeSelected.Text = ""
        'lblDocTypeSelectedLevelTwo.Text = ""
        'lblDocTypeSelected.Text = ""
        'lblSeriesSelected.Text = ""

        lblDocTypeExisting.Text = ""
        lblSeriesExisting.Text = ""

        'Make the Series label empty(and not equal to No Series Selected) because when the Misc button is clicked the Series is not required for any of the selections made
        lblTextSeriesSelected.Text = ""


        'Initial Check; if you are not modifying an existing doc make sure that both doc type and series are not set to "not selected"
        If CreateOrModifyDocNum <> "Modify" Then
            If lblTextDocTypeSelected.Text = "No Doc Type Selected" Then
                MsgBox("Please select doc type")
                btnMisc.Enabled = True
                txtDocNumber.Enabled = False
                btnContinue.Enabled = False
                Exit Sub
            End If
            If lblTextSeriesSelected.Text = "No Series Selected" Then
                If MiscOrIssueNumber <> "Misc" Then     'Added this line because when the Misc button is clicked the Series is not required to be selected, in any scenario
                    MsgBox("Please select series")
                    btnMisc.Enabled = True
                    txtDocNumber.Enabled = False
                    btnContinue.Enabled = False
                    Exit Sub
                End If
            End If
        End If


        'CODE TO EXECUTE IF MODIFYING AN EXISTING DOC NUM
        If CreateOrModifyDocNum = "Modify" Then

            btnIssueNumber.Enabled = False

            If cboProgram.Text = "" Then
                MsgBox("Please select program")
                btnMisc.Enabled = True
                txtDocNumber.Enabled = False
                btnContinue.Enabled = False
                Exit Sub
            End If
            If cboProject.Text = "" Then
                MsgBox("Please select project")
                btnMisc.Enabled = True
                txtDocNumber.Enabled = False
                btnContinue.Enabled = False
                Exit Sub
            End If

            If lblDocTypeExisting.Text = "" Then
                If FirstTimeMiscClicked = "" Then
                    FirstTimeMiscClicked = "Yes"
                    btnMisc.Enabled = True
                    If lblDocTypeSelectedLevelTwo.Text = "" Then
                        txtDocNumber.Enabled = False
                    End If
                Else
                        FirstTimeMiscClicked = "No"
                End If

                If FirstTimeMiscClicked <> "Yes" Then
                    If lblTextDocTypeSelected.Text = "No Doc Type Selected" Or lblTextDocTypeSelected.Text = "" Then    'The second part in this If is needed, otherwise the doc type may not be selected
                        MsgBox("Please select doc type")
                        btnMisc.Enabled = True
                        txtDocNumber.Enabled = False
                        btnContinue.Enabled = False
                        Exit Sub
                        If IsNothing(TreeView1.SelectedNode) = True Then
                            MsgBox("Please select doc type")
                            btnMisc.Enabled = True
                            txtDocNumber.Enabled = False
                            btnContinue.Enabled = False
                            Exit Sub
                        End If
                    End If
                End If
            End If

            'Check Series is selected if needs be(if doc type has been re-selected)
            'If lblDocTypeSelectedLevelTwo.Text <> "" Then
            If IsNothing(TreeView1.SelectedNode) = False Then

                'Check if drawing or report; for validation below
                Dim a As String = TreeView1.SelectedNode.FullPath
                Dim checkIfDrawingOrReport As String = a.Substring(0, a.IndexOf("\"))

                'Validate Series is selected all the way through and get the series selected to insert into tblDrawings when the relative code executes
                If checkIfDrawingOrReport = "Drawings" Then
                    If IsNothing(TreeView2.SelectedNode) = True And lblSeriesSelected.Text = "" Then
                        'Per Owen 09/12/21, commented out next block of code since the Series does not have to be selected once the Misc btn is clicked(for any selections made)
                        'MsgBox("Please select Series")
                        'btnMisc.Enabled = True
                        'txtDocNumber.Enabled = False
                        'btnContinue.Enabled = False
                        'Exit Sub

                        NewReworkFormB = "New Drawing"
                        ClassificationFormB = "Drawing"

                    Else
                        NewReworkFormB = "New Drawing"
                        ClassificationFormB = "Drawing"

                        'SeriesSelected = TreeView2.SelectedNode.Text
                        SeriesSelected = lblSeriesSelected.Text

                        da = New SqlClient.SqlDataAdapter("Select * from tblDocTypeJASC_Series Where JASCAndDesc = '" & SeriesSelected & "'", SqlConnection1)
                        da.Fill(ds, "SelectionMadeSeries")

                        If ds.Tables("SelectionMadeSeries").Rows.Count > 0 Then
                            'Nothing
                            ds.Tables("SelectionMadeSeries").Clear()
                            ds.Tables("SelectionMadeSeries").Dispose()
                        Else
                            'Per Owen, commented out next block of code since the Series does not have to be selected once the Misc btn is clicked(for any selections made)
                            'MsgBox("Please select the Series")
                            'btnMisc.Enabled = True
                            'txtDocNumber.Enabled = False
                            'btnContinue.Enabled = False
                            'Exit Sub
                        End If
                    End If
                Else
                    NewReworkFormB = "New Report"
                    ClassificationFormB = "Report"
                End If

                'Get the data to update tblDrawings: if modifying a doc and after clicking on Issue Number
                UpdateDocType = lblDocTypeSelectedLevelTwo.Text
                UpdateDocTypeLevelThree = lblDocTypeSelected.Text
                UpdateSeries = lblSeriesSelected.Text

                If UpdateDocTypeLevelThree = "59 Engineering Order (Mechanical)" Then
                    UpdateDocType = "Engineering Order (Mechanical)"
                    UpdateDocTypeLevelThree = "Engineering Order (Mechanical)"
                ElseIf UpdateDocTypeLevelThree = "59 Engineering Order (Electrical)" Then
                    UpdateDocType = "Engineering Order (Electrical)"
                    UpdateDocTypeLevelThree = "Engineering Order (Electrical)"
                End If
            End If

            'If IsNothing(TreeView1.SelectedNode) = True Then
            '    MsgBox("Please select Document Type")
            '    btnMisc.Enabled = True
            '    Exit Sub
            'End If

            'Get the Doc Type to be inserted in the database after clicking on SignOff btn
            UpdateDocType = lblDocTypeExisting.Text
            If UpdateDocType = "" Then
                UpdateDocType = lblDocTypeSelected.Text
            End If

            txtDocNumber.Enabled = True


            'CODE TO EXECUTE FOR A NEW DOC NUMBER
        Else
            'Check Program, Project and Doc Type are populated
            If cboProgram.Text = "" Then
                MsgBox("Please select program")
                btnMisc.Enabled = True
                txtDocNumber.Enabled = False
                btnContinue.Enabled = False
                Exit Sub
            End If
            If cboProject.Text = "" Then
                MsgBox("Please select project")
                btnMisc.Enabled = True
                txtDocNumber.Enabled = False
                btnContinue.Enabled = False
                Exit Sub
            End If
            If lblTextDocTypeSelected.Text = "No Doc Type Selected" Then
                MsgBox("Please select doc type")
                btnMisc.Enabled = True
                txtDocNumber.Enabled = False
                btnContinue.Enabled = False
                Exit Sub
                If IsNothing(TreeView1.SelectedNode) = True Then
                    MsgBox("Please select doc type")
                    btnMisc.Enabled = True
                    txtDocNumber.Enabled = False
                    btnContinue.Enabled = False
                    Exit Sub
                End If
            End If

            'Check if drawing or report; for validation below
            Dim checkIfDrawingOrReport As String
            If IsNothing(TreeView1.SelectedNode) = True Then
                MsgBox("Please Select Document Type")
                btnMisc.Enabled = True
                txtDocNumber.Enabled = False
                btnContinue.Enabled = False
                Exit Sub
            Else
                Dim a As String = TreeView1.SelectedNode.FullPath
                checkIfDrawingOrReport = a.Substring(0, a.IndexOf("\"))
            End If

            'Validate Series is selected all the way through and get the series selected to insert into tblDrawings when the relative code executes
            If checkIfDrawingOrReport = "Drawings" Then
                If lblSeriesSelected.Text = "" Then
                    'Per Owen 09/13/21, commented out next block of code since the Series does not have to be selected once the Misc btn is clicked(for any selections made)
                    'MsgBox("Please select Series")
                    'btnMisc.Enabled = True
                    'txtDocNumber.Enabled = False
                    'btnContinue.Enabled = False
                    'Exit Sub

                    NewReworkFormB = "New Drawing"
                    ClassificationFormB = "Drawing"

                Else
                    NewReworkFormB = "New Drawing"
                    ClassificationFormB = "Drawing"

                    'Per Owen, commented out next block of code since the Series does not have to be selected once the Misc btn is clicked(for any selections made)
                    'SeriesSelected = TreeView2.SelectedNode.Text

                    'da = New SqlClient.SqlDataAdapter("Select * from tblDocTypeJASC_Series Where JASCAndDesc = '" & SeriesSelected & "'", SqlConnection1)
                    'da.Fill(ds, "SelectionMadeSeries")

                    'If ds.Tables("SelectionMadeSeries").Rows.Count > 0 Then
                    '    'Nothing
                    '    ds.Tables("SelectionMadeSeries").Clear()
                    '    ds.Tables("SelectionMadeSeries").Dispose()
                    'Else
                    '    MsgBox("Please select the Series")
                    '    btnMisc.Enabled = True
                    '    txtDocNumber.Enabled = False
                    '    btnContinue.Enabled = False
                    '    Exit Sub
                    'End If
                End If
            Else
                NewReworkFormB = "New Report"
                ClassificationFormB = "Report"
            End If
        End If

        ''Get if Report or Drawing. To use for the Insert query in the Sign Off button code
        'If CreateOrModifyDocNum <> "Modify" Then
        '    Dim result As DialogResult = MessageBox.Show("Will this be a Report?", "Report or Drawing?", MessageBoxButtons.YesNo)
        '    If (result = DialogResult.Yes) Then
        '        NewReworkFormB = "New Report"
        '        ClassificationFormB = "Report"
        '    Else
        '        NewReworkFormB = "New Drawing"
        '        ClassificationFormB = "Drawing"
        '    End If
        'End If


        'IF ISSUING ANOTHER DOC NUMBER DIFFERENT FROM THE ONE CREATED IN FORM A THEN THE SEQUENCE NEED TO BE RESET; RESET ONLY IF THE DOC NUMBER HAS THE LAST SEQUENCE 
        If CreateOrModifyDocNum = "Modify" Then
            ResetOrNot()
        End If


        btnContinue.Enabled = True
        FirstTimeMiscClicked = "No"

        'Added the second part to the line below because when creating a new doc on Form B, after clicking on Misc, the Doc Number field was greyed out
        ' PREVIOUS ONE 9/21/21, did not make sense:  If lblDocTypeSelectedLevelTwo.Text = "" And CreateOrModifyDocNum = "Modify" Then              
        If lblDocTypeSelected.Text = "" And CreateOrModifyDocNum = "Modify" Then    'Maybe need the following instead of the second part of this line:  'MiscOrIssueNumber <> "Misc"
            btnMisc.Enabled = True  'Also added this on 9/21/21
            txtDocNumber.Enabled = False
        End If


        txtDocNumber.Select()
    End Sub

    Public Function ResetSequence(Type As String)
        Dim PreviousSequence As String = ""
        Dim TableToReset As String = ""

        If Type = "Modify" Then     'And MiscOrIssueNumber = "Issue Number" 

            ''Check if record is Canada or USA
            'CanadaOrUSA = ""
            'Dim i As Integer
            ''da = New SqlClient.SqlDataAdapter("Select DocNumbering from tblProjects Where ProjectName = '" & cboProject.Text & "'", SqlConnection1)
            'da = New SqlClient.SqlDataAdapter("Select DocNumbering from tblProgram Where ProgramName = '" & cboProject.Text & "'", SqlConnection1) 'CHANGE TO LINE ABOVE
            'da.Fill(ds, "CanadaOrUsa")
            'While i <= ds.Tables("CanadaOrUsa").Rows.Count - 1
            '    CanadaOrUSA = ds.Tables("CanadaOrUsa").Rows(i).Item("DocNumbering")
            '    i = i + 1
            'End While
            'ds.Tables("CanadaOrUsa").Clear()
            'ds.Tables("CanadaOrUsa").Dispose()


            ''Reset prefix to previous one
            ''If LocationDocNumToModify = "Toronto" Or LocationDocNumToModify = "Calgary" Then
            'If CanadaOrUSA = "Field Aerospace (Canada)" Or CanadaOrUSA = "Field Aerospace (Calgary)" Or CanadaOrUSA = "Field Aerospace (Toronto)" Then
            'da = New SqlClient.SqlDataAdapter("Select PreviousPrefix from tblDocumentType Where DocTypeInDropdown = '" & DocTypeDocNumToModify & "'", SqlConnection1)
            'TableToReset = "tblDocumentType"
            ''ElseIf LocationDocNumToModify = "OKC" Then
            ''    da = New SqlClient.SqlDataAdapter("Select PreviousPrefix from tblDocTypePrefixLevelThree Where DocumentType = '" & DocTypeDocNumToModify & "'", SqlConnection1)
            ''    TableToReset = "tblDocTypePrefixLevelThree"
            'End If

            'da.Fill(ds, "PreviousPrefix")
            'PreviousSequence = ds.Tables("PreviousPrefix").Rows(0).Item("PreviousPrefix")
            'ds.Tables("PreviousPrefix").Clear()
            'ds.Tables("PreviousPrefix").Dispose()


            'THE BELOW LINE IS ONLY FOR USA REPORTS
            'u.ExecuteSQL(SqlConnection1, "UPDATE " & TableToReset & " SET NextPrefix = '" & PreviousSequence & "' Where DocumentType = '" & DocTypeDocNumToModify & "'")
            u.ExecuteSQL(SqlConnection1, "UPDATE tblDocTypePrefixLevelThree SET NextPrefix = '" & PrefixForCheckingReset & "' Where DocumentType = '" & DocTypeSelectedLevelThree_DocNumToModify & "'")

        End If
    End Function

    Public Function ResetOrNot()
        Dim PreviousSequence As String = ""
        Dim PreviousPrefixForReset As String = ""
        Dim UsaOrCanadaLocation As String = ""

        'IF ISSUING ANOTHER DOC NUMBER DIFFERENT FROM THE ONE CREATED IN FORM A THEN THE SEQUENCE NEED TO BE RESET; RESET ONLY IF THE DOC NUMBER HAS THE LAST SEQUENCE USED
        If CreateOrModifyDocNum = "Modify" Then

            'Get if Program is Canada or USA to see which reset part below to use

            da = New SqlClient.SqlDataAdapter("Select DocNumbering from tblProjects Where ProjectName = '" & ProgramDocNumToModify & "'", SqlConnection1)    'ProgramDocNumToModify actually contains Project
            'da = New SqlClient.SqlDataAdapter("Select DocNumbering from tblProgram Where ProgramName = '" & ProgramDocNumToModify & "'", SqlConnection1)    'ProgramDocNumToModify actually contains Project
            da.Fill(ds, "CanadaOrUsa")
            UsaOrCanadaLocation = ds.Tables("CanadaOrUsa").Rows(0).Item("DocNumbering")
            ds.Tables("CanadaOrUsa").Clear()
            ds.Tables("CanadaOrUsa").Dispose()


            '----------------------USA DRAWING RESET---------------------------------------------------------------------------
            If (UsaOrCanadaLocation = "Field Aerospace (OKC)" Or UsaOrCanadaLocation = "Field Aerospace (USA)") And ClassificationDocNumToModify = "Drawing" Then

                'Get Level 3 Doc Type since it is needed in the reset code below, for USA Drawings. This is not taken here if it is already taken when clicking on the Delete button
                If DocTypeSelectedLevelThree = "" Then
                    da = New SqlClient.SqlDataAdapter("Select DocTypeSelectedLevelThree from tblDrawings Where RecordID = '" & RecordIdDocNumToModify & "'", SqlConnection1)
                    da.Fill(ds, "DocTypeLevelThree")
                    If ds.Tables("DocTypeLevelThree").Rows.Count > 0 Then
                        DocTypeSelectedLevelThree = ds.Tables("DocTypeLevelThree").Rows(0).Item("DocTypeSelectedLevelThree")
                    End If
                    ds.Tables("DocTypeLevelThree").Clear()
                    ds.Tables("DocTypeLevelThree").Dispose()
                End If

                'Only reset if the sequence used is the latest one
                da = New SqlClient.SqlDataAdapter("Select PreviousPrefix from tblDocTypePrefixLevelThree_NextSequences Where DocumentType = '" & DocTypeSelectedLevelThree & "' And Series = '" & SeriesDocNumToModify & "' And (Location = 'Field Aerospace (OKC)' Or Location = 'Field Aerospace (USA)') And DrawingOrReport = '" & ClassificationDocNumToModify & "' Order By RecordID Desc", SqlConnection1)
                da.Fill(ds, "PreviousPrefix")
                If ds.Tables("PreviousPrefix").Rows.Count > 0 Then
                    PreviousPrefixForReset = ds.Tables("PreviousPrefix").Rows(0).Item("PreviousPrefix")
                    ds.Tables("PreviousPrefix").Clear()
                    ds.Tables("PreviousPrefix").Dispose()
                End If

                If PrefixForCheckingReset = PreviousPrefixForReset Then

                    da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocTypePrefixLevelThree_NextSequences Where DocumentType = '" & DocTypeSelectedLevelThree & "' And Series = '" & SeriesDocNumToModify & "' And (Location = 'Field Aerospace (OKC)' Or Location = 'Field Aerospace (USA)') And DrawingOrReport = '" & ClassificationDocNumToModify & "' Order By RecordID Desc", SqlConnection1)
                    da.Fill(ds, "PreviousAndFirstPrefix")
                    If ds.Tables("PreviousAndFirstPrefix").Rows.Count > 0 Then
                        Dim previousPrefix As String = ds.Tables("PreviousAndFirstPrefix").Rows(0).Item("PreviousPrefix")
                        Dim firstPrefix As String = ds.Tables("PreviousAndFirstPrefix").Rows(0).Item("Prefix")
                        ds.Tables("PreviousAndFirstPrefix").Clear()
                        ds.Tables("PreviousAndFirstPrefix").Dispose()

                        If previousPrefix = firstPrefix Then
                            u.ExecuteSQL(SqlConnection1, "DELETE FROM tblDocTypePrefixLevelThree_NextSequences Where DocumentType = '" & DocTypeSelectedLevelThree & "' And Series = '" & SeriesDocNumToModify & "' And (Location = 'Field Aerospace (OKC)' Or Location = 'Field Aerospace (USA)') And DrawingOrReport = '" & ClassificationDocNumToModify & "'")
                        Else
                            da = New SqlClient.SqlDataAdapter("Select PreviousPrefix from tblDocTypePrefixLevelThree_NextSequences Where DocumentType = '" & DocTypeSelectedLevelThree & "' And Series = '" & SeriesDocNumToModify & "' And (Location = 'Field Aerospace (OKC)' Or Location = 'Field Aerospace (USA)') And DrawingOrReport = '" & ClassificationDocNumToModify & "'", SqlConnection1)
                            da.Fill(ds, "PreviousPrefix")
                            PreviousSequence = ds.Tables("PreviousPrefix").Rows(0).Item("PreviousPrefix")
                            ds.Tables("PreviousPrefix").Clear()
                            ds.Tables("PreviousPrefix").Dispose()
                            u.ExecuteSQL(SqlConnection1, "UPDATE tblDocTypePrefixLevelThree_NextSequences SET NextPrefix = '" & PreviousSequence & "' Where DocumentType = '" & DocTypeSelectedLevelThree & "' And Series = '" & SeriesDocNumToModify & "' And (Location = 'Field Aerospace (OKC)' Or Location = 'Field Aerospace (USA)') And DrawingOrReport = '" & ClassificationDocNumToModify & "'")
                            PreviousSequence = ""
                        End If
                    End If
                End If

                '------------------USA REPORT RESET--------------------------------------------------------------------------------
            ElseIf (UsaOrCanadaLocation = "Field Aerospace (OKC)" Or UsaOrCanadaLocation = "Field Aerospace (USA)") And ClassificationDocNumToModify = "Report" Then

                If DocTypeSelectedLevelThree_DocNumToModify = "59 Engineering Order (Mechanical)" Then
                    da = New SqlClient.SqlDataAdapter("Select PreviousPrefix from tblDocTypePrefixLevelThree Where DocumentType = 'Engineering Order (Mechanical)'", SqlConnection1)
                ElseIf DocTypeSelectedLevelThree_DocNumToModify = "59 Engineering Order (Electrical)" Then
                    da = New SqlClient.SqlDataAdapter("Select PreviousPrefix from tblDocTypePrefixLevelThree Where DocumentType = 'Engineering Order (Electrical)'", SqlConnection1)
                Else
                    da = New SqlClient.SqlDataAdapter("Select PreviousPrefix from tblDocTypePrefixLevelThree Where DocumentType = '" & DocTypeSelectedLevelThree_DocNumToModify & "'", SqlConnection1)
                End If

                da.Fill(ds, "PreviousPrefix")
                PreviousPrefixForReset = ds.Tables("PreviousPrefix").Rows(0).Item("PreviousPrefix")

                If PrefixForCheckingReset = PreviousPrefixForReset Then
                    ResetSequence("Modify")
                End If

                ds.Tables("PreviousPrefix").Clear()
                ds.Tables("PreviousPrefix").Dispose()
                PreviousPrefixForReset = ""
            End If


            '------------------CANADA REPORT RESET--------------------------------------------------------------------------------
            If (UsaOrCanadaLocation = "Field Aerospace (Canada)" Or UsaOrCanadaLocation = "Field Aerospace (Calgary)" Or UsaOrCanadaLocation = "Field Aerospace (Toronto)") And ClassificationDocNumToModify = "Report" Then

                'Only reset if the sequence used is the latest one
                'ProgramDocNumToModify actually contains Project
                da = New SqlClient.SqlDataAdapter("Select PreviousPrefix from tblDocumentType_NextSequences Where DocumentType = '" & DocTypeDocNumToModify & "' And (Location = 'Field Aerospace (Canada)' Or Location = 'Field Aerospace (Calgary)' Or Location = 'Field Aerospace (Toronto)') And Program = '" & ProgramDocNumToModify & "' And DrawingOrReport = '" & ClassificationDocNumToModify & "' Order By RecordID Desc", SqlConnection1)
                da.Fill(ds, "PreviousPrefix")
                If ds.Tables("PreviousPrefix").Rows.Count > 0 Then
                    PreviousPrefixForReset = ds.Tables("PreviousPrefix").Rows(0).Item("PreviousPrefix")
                    ds.Tables("PreviousPrefix").Clear()
                    ds.Tables("PreviousPrefix").Dispose()
                End If

                If PrefixForCheckingReset = PreviousPrefixForReset Then
                    'ProgramDocNumToModify actually contains Project
                    da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocumentType_NextSequences Where DocumentType = '" & DocTypeDocNumToModify & "' And Program = '" & ProgramDocNumToModify & "' And (Location = 'Field Aerospace (Canada)' Or Location = 'Field Aerospace (Calgary)' Or Location = 'Field Aerospace (Toronto)') And DrawingOrReport = '" & ClassificationDocNumToModify & "' Order By RecordID Desc", SqlConnection1)
                    da.Fill(ds, "PreviousAndFirstPrefixCanada")
                    If ds.Tables("PreviousAndFirstPrefixCanada").Rows.Count > 0 Then
                        Dim previousPrefix As String = ds.Tables("PreviousAndFirstPrefixCanada").Rows(0).Item("PreviousPrefix")
                        Dim firstPrefix As String = ds.Tables("PreviousAndFirstPrefixCanada").Rows(0).Item("Prefix")
                        ds.Tables("PreviousAndFirstPrefixCanada").Clear()
                        ds.Tables("PreviousAndFirstPrefixCanada").Dispose()

                        If previousPrefix = firstPrefix Then
                            'ProgramDocNumToModify actually contains Project
                            u.ExecuteSQL(SqlConnection1, "DELETE FROM tblDocumentType_NextSequences Where DocumentType = '" & DocTypeDocNumToModify & "' And Program = '" & ProgramDocNumToModify & "' And (Location = 'Field Aerospace (Canada)' Or Location = 'Field Aerospace (Calgary)' Or Location = 'Field Aerospace (Toronto)') And DrawingOrReport = '" & ClassificationDocNumToModify & "'")
                        Else
                            'ProgramDocNumToModify actually contains Project
                            da = New SqlClient.SqlDataAdapter("Select PreviousPrefix from tblDocumentType_NextSequences Where DocumentType = '" & DocTypeDocNumToModify & "' And Program = '" & ProgramDocNumToModify & "' And (Location = 'Field Aerospace (Canada)' Or Location = 'Field Aerospace (Calgary)' Or Location = 'Field Aerospace (Toronto)') And DrawingOrReport = '" & ClassificationDocNumToModify & "'", SqlConnection1)
                            da.Fill(ds, "PreviousPrefixCanada")
                            PreviousSequence = ds.Tables("PreviousPrefixCanada").Rows(0).Item("PreviousPrefix")
                            ds.Tables("PreviousPrefixCanada").Clear()
                            ds.Tables("PreviousPrefixCanada").Dispose()
                            u.ExecuteSQL(SqlConnection1, "UPDATE tblDocumentType_NextSequences SET NextPrefix = '" & PreviousSequence & "' Where DocumentType = '" & DocTypeDocNumToModify & "' And Program = '" & ProgramDocNumToModify & "' And (Location = 'Field Aerospace (Canada)' Or Location = 'Field Aerospace (Calgary)' Or Location = 'Field Aerospace (Toronto)') And DrawingOrReport = '" & ClassificationDocNumToModify & "'")
                            PreviousSequence = ""
                        End If
                    End If
                End If

                'PREVIOUS BLOCK OF CODE
                'da = New SqlClient.SqlDataAdapter("Select PreviousPrefix from tblDocumentType Where DocumentType = '" & DocTypeDocNumToModify & "'", SqlConnection1)
                'da.Fill(ds, "PreviousPrefix")
                'PreviousPrefixForReset = ds.Tables("PreviousPrefix").Rows(0).Item("PreviousPrefix")

                'If PrefixForCheckingReset = PreviousPrefixForReset Then
                '    ResetSequence("Modify")
                'End If

                'ds.Tables("PreviousPrefix").Clear()
                'ds.Tables("PreviousPrefix").Dispose()

                '------------------CANADA DRAWING RESET--------------------------------------------------------------------------------
            ElseIf (UsaOrCanadaLocation = "Field Aerospace (Canada)" Or UsaOrCanadaLocation = "Field Aerospace (Calgary)" Or UsaOrCanadaLocation = "Field Aerospace (Toronto)") And ClassificationDocNumToModify = "Drawing" Then

                'Only reset if the sequence used is the latest one
                da = New SqlClient.SqlDataAdapter("Select PreviousPrefix from tblDocumentType_NextSequences Where DocumentType = '" & DocTypeDocNumToModify & "' And Series = '" & SeriesDocNumToModify & "' And (Location = 'Field Aerospace (Canada)' Or Location = 'Field Aerospace (Calgary)' Or Location = 'Field Aerospace (Toronto)') And DrawingOrReport = '" & ClassificationDocNumToModify & "' Order By RecordID Desc", SqlConnection1)
                da.Fill(ds, "PreviousPrefix")
                If ds.Tables("PreviousPrefix").Rows.Count > 0 Then
                    PreviousPrefixForReset = ds.Tables("PreviousPrefix").Rows(0).Item("PreviousPrefix")
                    ds.Tables("PreviousPrefix").Clear()
                    ds.Tables("PreviousPrefix").Dispose()
                End If

                If PrefixForCheckingReset = PreviousPrefixForReset Then

                    da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocumentType_NextSequences Where DocumentType = '" & DocTypeDocNumToModify & "' And Series = '" & SeriesDocNumToModify & "' And (Location = 'Field Aerospace (Canada)' Or Location = 'Field Aerospace (Calgary)' Or Location = 'Field Aerospace (Toronto)') And DrawingOrReport = '" & ClassificationDocNumToModify & "' Order By RecordID Desc", SqlConnection1)
                    da.Fill(ds, "PreviousAndFirstPrefixCanada")
                    If ds.Tables("PreviousAndFirstPrefixCanada").Rows.Count > 0 Then
                        Dim previousPrefix As String = ds.Tables("PreviousAndFirstPrefixCanada").Rows(0).Item("PreviousPrefix")
                        Dim firstPrefix As String = ds.Tables("PreviousAndFirstPrefixCanada").Rows(0).Item("Prefix")
                        ds.Tables("PreviousAndFirstPrefixCanada").Clear()
                        ds.Tables("PreviousAndFirstPrefixCanada").Dispose()

                        If previousPrefix = firstPrefix Then
                            u.ExecuteSQL(SqlConnection1, "DELETE FROM tblDocumentType_NextSequences Where DocumentType = '" & DocTypeDocNumToModify & "' And Series = '" & SeriesDocNumToModify & "' And (Location = 'Field Aerospace (Canada)' Or Location = 'Field Aerospace (Calgary)' Or Location = 'Field Aerospace (Toronto)') And DrawingOrReport = '" & ClassificationDocNumToModify & "'")
                        Else
                            da = New SqlClient.SqlDataAdapter("Select PreviousPrefix from tblDocumentType_NextSequences Where DocumentType = '" & DocTypeDocNumToModify & "' And Series = '" & SeriesDocNumToModify & "' And (Location = 'Field Aerospace (Canada)' Or Location = 'Field Aerospace (Calgary)' Or Location = 'Field Aerospace (Toronto)') And DrawingOrReport = '" & ClassificationDocNumToModify & "'", SqlConnection1)
                            da.Fill(ds, "PreviousPrefixCanada")
                            PreviousSequence = ds.Tables("PreviousPrefixCanada").Rows(0).Item("PreviousPrefix")
                            ds.Tables("PreviousPrefixCanada").Clear()
                            ds.Tables("PreviousPrefixCanada").Dispose()
                            u.ExecuteSQL(SqlConnection1, "UPDATE tblDocumentType_NextSequences SET NextPrefix = '" & PreviousSequence & "' Where DocumentType = '" & DocTypeDocNumToModify & "' And Series = '" & SeriesDocNumToModify & "' And (Location = 'Field Aerospace (Canada)' Or Location = 'Field Aerospace (Calgary)' Or Location = 'Field Aerospace (Toronto)') And DrawingOrReport = '" & ClassificationDocNumToModify & "'")
                            PreviousSequence = ""
                        End If
                    End If
                End If
            End If
        End If


        DocTypeSelectedLevelThree = ""
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If CreateOrModifyDocNum = "Modify" Then

            'Get Level 3 Doc Type since it is needed in the reset code for USA Drawings
            da = New SqlClient.SqlDataAdapter("Select DocTypeSelectedLevelThree from tblDrawings Where RecordID = '" & RecordIdDocNumToModify & "'", SqlConnection1)
            da.Fill(ds, "DocTypeLevelThree")
            If ds.Tables("DocTypeLevelThree").Rows.Count > 0 Then
                DocTypeSelectedLevelThree = ds.Tables("DocTypeLevelThree").Rows(0).Item("DocTypeSelectedLevelThree")
            End If
            ds.Tables("DocTypeLevelThree").Clear()
            ds.Tables("DocTypeLevelThree").Dispose()


            u.ExecuteSQL(SqlConnection1, "DELETE FROM tblDrawings WHERE RecordID = '" & RecordIdDocNumToModify & "'")


            ResetOrNot()


            DocTypeSelectedLevelThree = ""
            Me.Close()
        End If
    End Sub

    Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView2.AfterSelect

        'Show the selected value in the label displaying the selected value if the value has been selected all the way through

        'Get Series selected by user
        Dim SeriesSelected As String = TreeView2.SelectedNode.Text

        da = New SqlClient.SqlDataAdapter("Select * from tblDocTypeJASC_Series Where JASCAndDesc = '" & SeriesSelected & "'", SqlConnection1)
        da.Fill(ds, "SelectedSeries")

        If ds.Tables("SelectedSeries").Rows.Count > 0 Then
            lblSeriesSelected.Text = SeriesSelected
            lblTextSeriesSelected.Text = "Series Selected: "
            lblSeriesExisting.Text = ""
        Else
            lblSeriesSelected.Text = ""
            lblTextSeriesSelected.Text = "No Series Selected"
        End If

        ds.Tables("SelectedSeries").Clear()
        ds.Tables("SelectedSeries").Dispose()


        'If user is modifying an existing doc number when it clicks on this treeview disable the signoff button. It will be re-enabled once they click on Issue Number
        If CreateOrModifyDocNum = "Modify" Then
            btnContinue.Enabled = False
        End If

        'Enable Issue Number button once they make a selection in the Treeview, except when
        If MiscOrIssueNumber = "Misc" Then
            btnIssueNumber.Enabled = False

        Else
            'BLOCK OF CODE BELOW (9 LINES) IS TO BE COMMENTED OUT, THEN LINE COMMENTED OUT "btnIssueNumber.Enabled = True" NEEDS TO BE UNCOMMENTED (only that line)
            ' 'If CM = True Or isNewRecord = "True" Then      'ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Or isLeadEngineer = "True") And isLeadEngineer = "True" Then
            If lblDocTypeSelected.Text = "Flammability Test Specimens" Then     'lblDocTypeSelected.Text = "Specification" Or lblDocTypeSelected.Text = "Tooling" Or lblDocTypeSelected.Text = "Vendor Supplied (Mechanical)" Or lblDocTypeSelected.Text = "Definition" Then
                btnIssueNumber.Enabled = False
            Else
                'If System.Environment.UserName = "ohaswell" Or System.Environment.UserName = "apptestcm1" Or System.Environment.UserName = "jwebster" Or System.Environment.UserName = "nsantagata" Or System.Environment.UserName = "jsprigg" Or System.Environment.UserName = "alee" Or System.Environment.UserName = "rdetillier" Or System.Environment.UserName = "llewis" Or System.Environment.UserName = "karcinas" Or System.Environment.UserName = "rduwel" Or System.Environment.UserName = "jrovenstine" Then
                If isNewRecord = "True" Then
                    btnIssueNumber.Enabled = True
                Else
                    btnIssueNumber.Enabled = False
                End If
            End If

            'btnIssueNumber.Enabled = True

        End If


        ''THIS BLOCK OF CODE (3 LINES) WILL BE COMMENTED OUT WHEN I GET THE LIST FROM JEFF SPRIGG. FOR NOW ALL THE CANADIAN DOCUMENTS CAN ONLY CHOOSE THE MISC BUTTON, AND NOT THE ISSUE ONE
        'If CanadaOrUSA = "Field Aerospace (Canada)" Then
        '    btnIssueNumber.Enabled = False
        'End If


        'If the document type selected is a Canada Drawing and it does not have a prefix then disable the btnIssueNumber button
        If DocTypePrefixEmpty = True Then
            btnIssueNumber.Enabled = False
        End If
    End Sub

    'Disable Free Text Entry in the Resource Type Combobox
    Private Sub cboResourceType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboResourceType.KeyPress
        e.Handled = True
    End Sub

    'Disable Free Text Entry in the Milestone Combobox
    Private Sub cboMilestone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboMilestone.KeyPress
        e.Handled = True
    End Sub

    'Disable Free Text Entry
    Private Sub cboProgram_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProgram.KeyPress
        e.Handled = True
    End Sub

    'Disable Free Text Entry
    Private Sub cboProject_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProject.KeyPress
        e.Handled = True
    End Sub

    'Disable Free Text Entry
    Private Sub cboSystem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboSystem.KeyPress
        e.Handled = True
    End Sub

    'Disable Free Text Entry
    'Private Sub cboDrafter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDrafter.KeyPress
    'e.Handled = True
    'End Sub

End Class