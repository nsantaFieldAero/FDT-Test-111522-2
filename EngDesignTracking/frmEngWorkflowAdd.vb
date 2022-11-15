Imports System.Text

Public Class frmEngWorkflowAdd
    Dim ds As New DataSet
    Dim da As SqlClient.SqlDataAdapter
    Dim NeedsAssigned As String = ""
    Dim FinalDocNumber As String = ""
    Dim CanadaOrUSA As String
    Dim TypeOfDoc As String = ""
    Dim NewRework As String = ""
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
    Dim LoopedAlreadyForTrailingZero As String = ""
    Dim LastSequenceReached As String = ""
    Dim ClassificationTypeAndLoc As String = ""
    Dim MessageAlreadyDisplayed As String = ""
    Dim ProgramNumber As String = ""
    Dim SelectedDocType As String = ""
    Dim ProjectNameSelected As String = ""
    Dim ProjectNumberSelected As String = ""
    Dim ProgramNameSelected As String = ""
    Dim ProgramNumberSelected As String = ""

    Private Sub frmEngWorkflowAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim userLocation As String = ""
        lblDocTypeSelected.Text = ""
        lblDocTypeSelectedLevelTwo.Text = ""
        lblSeriesSelected.Text = ""
        lblTextDocTypeSelected.Text = ""
        initialClick = False
        'Hide Series
        lblSeries.Visible = False
        TreeView2.Visible = False
        btnJASCCodes.Visible = False
        cboProject.Visible = False
        lblTextDocTypeSelected.Text = "No Doc Type Selected"


        SqlConnection1.ConnectionString = sqlString


        'Populate the Program drop-down. Before it was populated according to the location of the user
        da = New SqlClient.SqlDataAdapter("Select * from tblProgram Where Active = 'True' Order By ProgramName", SqlConnection1)
        da.Fill(ds, "Programs")

        Dim p As Integer = 0
        While p <= ds.Tables("Programs").Rows.Count - 1
            Me.cboProgram.Items.Add(ds.Tables("Programs").Rows(p).Item("ProjectNumber") & " - " & ds.Tables("Programs").Rows(p).Item("ProgramName"))
            p = p + 1
        End While

        ds.Tables("Programs").Clear()
        ds.Tables("Programs").Dispose()
    End Sub

    Private Sub cboProgram_TextChanged(sender As Object, e As EventArgs) Handles cboProgram.TextChanged

        cboProject.Visible = True


        'If Loc = "Toronto" Or Loc = "Calgary" Then
        '    userLocation = "Field Aerospace (Canada)"
        'ElseIf Loc = "OKC" Then
        '    userLocation = "Field Aerospace (OKC)"
        'End If
        'da = New SqlClient.SqlDataAdapter("Select * from tblProjects Where DocNumbering = '" & userLocation & "' Order By ProjectName", SqlConnection1) 


        Dim index As Integer = cboProgram.Text.IndexOf("-")
        ProgramNameSelected = cboProgram.Text.Substring(index + 2)
        ProgramNumberSelected = cboProgram.Text.Substring(0, cboProgram.Text.IndexOf("-") - 1)


        'Populate the Project drop-down. Before it was populated according to the location of the user(see above uncommented stuff)
        da = New SqlClient.SqlDataAdapter("Select ProjectName, ProjectNumber From tblProgram_Project Where ProgramName = '" & ProgramNameSelected & "' Order By ProjectName", SqlConnection1)
        da.Fill(ds, "Projects")

        Dim p As Integer = 0
        cboProject.Items.Clear()
        While p <= ds.Tables("Projects").Rows.Count - 1
            Me.cboProject.Items.Add(ds.Tables("Projects").Rows(p).Item("ProjectNumber") & " - " & ds.Tables("Projects").Rows(p).Item("ProjectName"))
            p = p + 1
        End While

        ds.Tables("Projects").Clear()
        ds.Tables("Projects").Dispose()


        If cboProject.Text = "" Then
            TreeView1.Visible = False
            TreeView2.Visible = False
        End If
    End Sub

    Private Sub cboProject_TextChanged(sender As Object, e As EventArgs) Handles cboProject.TextChanged
        lblDocTypeSelected.Text = ""
        lblDocTypeSelectedLevelTwo.Text = ""
        lblSeriesSelected.Text = ""
        lblTextSeriesSelected.Text = ""
        lblTextDocTypeSelected.Text = ""
        CanadaOrUSA = ""
        lblSeries.Visible = False
        TreeView2.Visible = False
        btnJASCCodes.Visible = False
        TreeView1.Visible = True

        Dim index As Integer = cboProject.Text.IndexOf("-")
        ProjectNameSelected = cboProject.Text.Substring(index + 2)
        ProjectNumberSelected = cboProject.Text.Substring(0, cboProject.Text.IndexOf("-") - 1)

        'Populate System dropdown
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


        'GET THE DOCUMENT NUMBERING TYPE: CANADA OR USA. Used to create the document number
        Dim i As Integer = 0
        da = New SqlClient.SqlDataAdapter("Select DocNumbering from tblProjects Where ProjectName = '" & ProjectNameSelected & "' Or ProjectNumber = '" & ProjectNumberSelected & "'", SqlConnection1)
        'da = New SqlClient.SqlDataAdapter("Select DocNumbering from tblProgram Where ProgramName = '" & cboProject.Text & "'", SqlConnection1)
        da.Fill(ds, "CanadaOrUsa")
        While i <= ds.Tables("CanadaOrUsa").Rows.Count - 1
            CanadaOrUSA = ds.Tables("CanadaOrUsa").Rows(i).Item("DocNumbering")
            i = i + 1
        End While

        ds.Tables("CanadaOrUsa").Clear()
        ds.Tables("CanadaOrUsa").Dispose()
        i = 0


        'If cboProject.Text <> "" Then
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
        'End If
        '------------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim frmEngWorkflowBrowse As New frmEngWorkflowBrowse
        frmEngWorkflowBrowse.ShowDialog()

        Me.txtNextHigherAssembly.Text = DocBrowse

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim Classification As String = ""
        Dim ProductGroupPrefix As String = ""
        Dim ProjectNumber As String = ""
        Dim JASCPrefix As String = ""
        Dim isDrawing As Boolean = False
        Dim DocumentTypeSelectedWithoutNums As String = ""

        DocTypeSelected = ""
        SeriesSelected = ""
        USAReportDocSeqIdentifier = ""
        USADrawingDocSeqIdentifier = ""
        CanadaReportDocSeqIdentifier = ""
        CanadaDrawingDocSeqIdentifier = ""
        FinalDocNumber = ""
        LoopedAlreadyForTrailingZero = ""
        LastSequenceReached = ""
        ClassificationTypeAndLoc = ""
        MessageAlreadyDisplayed = ""

        'VALIDATE DOC TYPE is selected all the way through
        If IsNothing(TreeView1.SelectedNode) = True Then
            MsgBox("Please select Document Type")
            Exit Sub

        Else
            DocTypeSelected = TreeView1.SelectedNode.Text

            'If DocTypeSelected = "59 Engineering Order (Mechanical)" Then
            '    DocTypeSelected = "Engineering Order (Mechanical)"
            'ElseIf DocTypeSelected = "59 Engineering Order (Electrical)" Then
            '    DocTypeSelected = "Engineering Order (Electrical)"
            'End If


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
                If DocTypeSelected = "Proposal (PRxxxx)" Or DocTypeSelected = "Sketch (SKxxxx)" Or DocTypeSelected = "Product & System Specification (SPEC-1xxx)" Or DocTypeSelected = "Tooling (T81xxx)" Then
                    da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "'", SqlConnection1)
                Else
                    da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where DocumentType = '" & DocTypeSelected & "' And Classification = 'Drawing'", SqlConnection1)    'Before was tblDocTypePrefixLevelTwo
                End If

                da.Fill(ds, "SelectionMadeDrawing")

                If ds.Tables("SelectionMadeDrawing").Rows.Count > 0 Then
                    'Nothing
                    ds.Tables("SelectionMadeDrawing").Clear()
                    ds.Tables("SelectionMadeDrawing").Dispose()
                    DrawingOrReport = "Drawing"
                Else

                    ''If DocTypeSelected <> "Drawings" Then
                    'docTypeNoLetters = ""
                    'docTypeNoLetters = RegularExpressions.Regex.Replace(DocTypeSelected, "[\d-]", String.Empty)
                    'docTypeNoLetters = docTypeNoLetters.Substring(1)

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

                'If DocTypeSelected = "Drawings" Then
                da = New SqlClient.SqlDataAdapter("Select * from tblDocTypeJASC_Series Where JASCAndDesc = '" & SeriesSelected & "'", SqlConnection1)
                da.Fill(ds, "SelectionMadeSeries")

                If ds.Tables("SelectionMadeSeries").Rows.Count > 0 Then
                    'Nothing
                    ds.Tables("SelectionMadeSeries").Clear()
                    ds.Tables("SelectionMadeSeries").Dispose()
                Else
                    MsgBox("Please select the Series")
                    Exit Sub
                End If
                'End If
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
        If Me.cboSystem.Text = "" Then
            msg = msg + "System is required to be selected." & vbCrLf
        End If
        If Me.txtTitle.Text = "" Then
            msg = msg + "Title is required to be filled in." & vbCrLf
        End If

        If msg = "" Then
            'If DocTypeSelected = "Master Data List" Then
            '******************COMMENTED BLOCK OF CODE BELOW BECAUSE IT WILL BE ADDED TO FORM B(ADD DOC NUMBER)*************************************
            '        'And Me.txtDocNumber.Text <> "" And Me.txtDocNumber.Text <> NeedsAssigned

            '        'Create MDL record in the MDL table.

            '        'Create a MDL Number
            '        Dim mdlint As Int64
            '        mdlint = Format(Now, "ddyymmss")

            '        u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDL (MDLNumber, DocumentNumber, Title, Revision, Status, LastRefresh, Priority) Values ('" & Val(mdlint) & "','" & Me.txtDocNumber.Text & "', '" & u.FTM(Me.txtTitle.Text) & "', 'IR', '-', '" & Now & "', '')")
            '        'Get the MDLRecordID value just generated
            '        da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID from tblLiveMDL Order By RecordID Desc", SqlConnection1)
            '        da.Fill(ds, "MDL")
            '        'Insert record into the tblLiveMDLProjectsSystems table
            '        u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLProjectsSystems (MDLRecordID, MDLNumber, DocumentNumber, Program, System) Values ('" & Val(ds.Tables("MDL").Rows(0).Item("RecordID")) & "',  '" & Val(mdlint) & "', '" & Me.txtDocNumber.Text & "', '" & Me.cboProgram.Text & "', '" & Me.cboSystem.Text & "')")
            'End If
        Else
            msg = msg + "Please fix errors and click continue again."
            MsgBox(msg)
            msg = ""
            Exit Sub
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
        'COMMENTED OUT: next 2 lines and matching Else (and everything in it) and End If are to be deleted once Form A gets fully rolled out
        Dim TestOrNot As String = "Testing"
        If TestOrNot <> "Testing" Then

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
                    ClassificationTypeAndLoc = "USADrawing"
                ElseIf CanadaOrUSA = "Field Aerospace (Canada)" Then
                    '5 Digit sequential number Drawing Canada
                    GetPrefixDrawingCanada("tblDocumentType")   'Before it was tblDocTypePrefixLevelTwo
                    FinalDocNumber = JASCPrefix & NextPrefixDrawingCanada
                    ClassificationTypeAndLoc = "CanadaDrawing"
                End If

                'REPORTS
            ElseIf DrawingOrReport = "Report" Then
                'Next 5 lines are for Report USA
                If DocTypeSelected = "Engineering Order (Mechanical)" Or DocTypeSelected = "Engineering Order (Electrical)" Or DocTypeSelected = "59 Engineering Order (Mechanical)" Or DocTypeSelected = "59 Engineering Order (Electrical)" Then
                    JASCPrefix = "EO"
                Else
                    JASCPrefix = "0000"
                End If

                If CanadaOrUSA = "Field Aerospace (OKC)" Then
                    GetPrefixReportUSA("tblDocTypePrefixLevelThree")
                    FinalDocNumber = ProductGroupPrefix & "-" & JASCPrefix & "-" & NextPrefixReportUSA
                    ClassificationTypeAndLoc = "USAReport"
                ElseIf CanadaOrUSA = "Field Aerospace (Canada)" Then
                    'Get 4 digits prefix: prefix + sequential number
                    GetPrefixReportCanada("tblDocumentType")    'Before it was tblDocTypePrefixLevelTwo
                    FinalDocNumber = ProjectNumber & NextPrefixReportCanada
                    ClassificationTypeAndLoc = "CanadaReport"
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
                                MsgBox("Drawing Number " & FinalDocNumber & " Already Exists. The program will look for the next available sequence. If no other sequences are available you will get an error message saying so.")
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

        Else
            FinalDocNumber = "NEEDS ASSIGNED " & Format(Now, "MMddyyyyHHmmss")
            NeedsAssigned = FinalDocNumber
        End If



        NewRework = ""
        NewRework = TreeView1.SelectedNode.FullPath
        NewRework = NewRework.Substring(0, 1)
        If NewRework = "R" Then
            NewRework = "New Report"
        ElseIf NewRework = "D" Then
            NewRework = "New Drawing"
        End If


        'SET THE GATE TO ZERO
        ''Dim GateZeroOrOne As String = txtDocNumber.Text
        Dim GateZeroOrOne As String = "GATE 0: CM Needs To Assign DWG Number"

        ''If GateZeroOrOne <> "" And GateZeroOrOne.Length < 21 Then
        ''    GateZeroOrOne = "GATE 1: DWG Ready For Drafter"
        ''If GateZeroOrOne = "" Or txtDocNumber.Text = NeedsAssigned Then
        ''GateZeroOrOne = "GATE 0: CM Needs To Assign DWG Number"
        ''Else
        ''    GateZeroOrOne = "GATE 1: DWG Ready For Drafter"
        ''End If


        'Check if document type is a Report when creating a new document, if it is this variable will be used to set Operations/Engineer field to "N/A"
        If NewRework = "New Report" Then
            DocumentTypeForOperations = "Report"
        ElseIf NewRework = "New Drawing" Then
            DocumentTypeForOperations = "Drawing"
        End If


        'INSERT THE NEW RECORD TO THE DRAWINGS TABLE  AND  SET OPERATIONS/ENGINEER FIELD TO "N/A" IF THE DOCUMENT CREATED IS A REPORT

        'Get the document type without the numbers showing in front of the doc type selected from drop-down; for Canada reports
        If CanadaOrUSA = "Field Aerospace (Canada)" And DrawingOrReport = "Report" Then
            da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "'", SqlConnection1)
            da.Fill(ds, "DocTypeWithoutNumbers")
            If ds.Tables("DocTypeWithoutNumbers").Rows.Count > 0 Then
                DocTypeSelected = ds.Tables("DocTypeWithoutNumbers").Rows(0).Item("DocumentType")
                ds.Tables("DocTypeWithoutNumbers").Clear()
                ds.Tables("DocTypeWithoutNumbers").Dispose()
            End If
        End If


        'Text to insert in col DocTypeSelected in tblDrawings
        Dim DocTypeSelectedLevel3 As String = DocTypeSelected


        'Get Doc Type selected by user. For USA we need to get the level 2 selection and not the level 3

        'Check if Drawings or Reports has been chosen. To use with following block of code
        Dim a As String = TreeView1.SelectedNode.FullPath
        Dim checkIfDrawingOrReport As String = a.Substring(0, a.IndexOf("\"))

        'The text that goes into DocumentType col in the database is not the level 3 text but level 2. Following code is to catch that
        If CanadaOrUSA = "Field Aerospace (OKC)" Then
            DocTypeSelected = TreeView1.SelectedNode.FullPath

            If checkIfDrawingOrReport = "Drawings" Then
                DocTypeSelected = DocTypeSelected.Substring(9)
                DocTypeSelected = DocTypeSelected.Substring(0, DocTypeSelected.IndexOf("\"))

            ElseIf checkIfDrawingOrReport = "Reports" Then

                DocTypeSelected = DocTypeSelected.Substring(8)

                If DocTypeSelected = "59 Engineering Order (Mechanical)" Then
                    da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "'", SqlConnection1)
                ElseIf DocTypeSelected = "59 Engineering Order (Electrical)" Then
                    da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "'", SqlConnection1)
                Else
                    DocTypeSelected = DocTypeSelected.Substring(0, DocTypeSelected.IndexOf("\"))
                    da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "'", SqlConnection1)
                End If

                da.Fill(ds, "DocTypeWithoutNumbers")
                DocTypeSelected = ds.Tables("DocTypeWithoutNumbers").Rows(0).Item("DocumentType")
                ds.Tables("DocTypeWithoutNumbers").Clear()
                ds.Tables("DocTypeWithoutNumbers").Dispose()
            End If

        Else
            'If Canada Reports use the doc type that was manipulated above, without the initial numbers 
            If DrawingOrReport = "Report" Then
                DocTypeSelected = DocTypeSelected
            Else
                DocTypeSelected = TreeView1.SelectedNode.Text
            End If
        End If

        'The only thing different between the two SQL queries below is that the one related to Report sets Engineer = N/A
        If NewRework = "New Drawing" Then
            u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, ProgramReal, Program, SystemDescription, DwgRevision, Type, DocumentType, DocTypeSelectedLevelThree, Series, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter,DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, DrawingOrReport, Updated, UpdatedDate, ADCN, ForecastStartDate, DrafterSignedOffBy, SrEngineerSignedOffBy, StressSignedOffBy, EngineerSignedOffBy, ReleaserSignedOffBy, CMSignedOffBy, IsDocNumConfirmed) Values ('" & FinalDocNumber & "', '" & u.FTM(txtTitle.Text) & "', '" & txtNextHigherAssembly.Text & "', '" & ProgramNameSelected & "', '" & ProjectNameSelected & "', '" & u.FTM(Me.cboSystem.Text) & "', 'IR', '', '" & u.FTM(DocTypeSelected) & "', '" & DocTypeSelectedLevel3 & "', '" & SeriesSelected & "', '', '" & Loc & "', '" & System.Environment.UserName & "', '" & Now & "', '', '" & GateZeroOrOne & "', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '', '', '" & username & "', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','','','','','','" & Now & "', '" & NewRework & "', '" & DocumentTypeForOperations & "', 0, '" & Now & "', '', '" & Now & "', '', '', '', '', '', '', 0)")
        ElseIf NewRework = "New Report" Then
            u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, ProgramReal, Program, SystemDescription, DwgRevision, Type, DocumentType, DocTypeSelectedLevelThree, Series, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter,DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, DrawingOrReport, Updated, UpdatedDate, ADCN, ForecastStartDate, DrafterSignedOffBy, SrEngineerSignedOffBy, StressSignedOffBy, EngineerSignedOffBy, ReleaserSignedOffBy, CMSignedOffBy, IsDocNumConfirmed) Values ('" & FinalDocNumber & "', '" & u.FTM(txtTitle.Text) & "', '" & txtNextHigherAssembly.Text & "', '" & ProgramNameSelected & "', '" & ProjectNameSelected & "', '" & u.FTM(Me.cboSystem.Text) & "', 'IR', '', '" & u.FTM(DocTypeSelected) & "', '" & DocTypeSelectedLevel3 & "', '" & SeriesSelected & "', '', '" & Loc & "', '" & System.Environment.UserName & "', '" & Now & "', '', '" & GateZeroOrOne & "', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '', '', '" & username & "', '01/01/1900', 'N/A', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','','','','','','" & Now & "', '" & NewRework & "', '" & DocumentTypeForOperations & "',  0, '" & Now & "', '', '" & Now & "', '', '', '', '', '', '', 0)")
        End If



        ''I might have to add the following block of code: it inserts a project for each program it is related to
        'Try
        'AddProjectsRelatedToPrograms()
        'Catch ex As Exception
        'MessageBox.Show("An error occured after clicking on Save." & vbLf & vbLf & ex.Message)
        'End Try
        '--------------------------------------------------------------------------------------------------------------------------------------------



        'GET THE RECORD ID
        da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID From tblDrawings Order By RecordID Desc", SqlConnection1)
        da.Fill(ds, "Top1")
        DocAdd = Val(ds.Tables("TOP1").Rows(0).Item("RecordID"))
        ds.Tables("Top1").Clear()
        ds.Tables("Top1").Dispose()


        'SEND NOTIFICATION TO PLANNER, LEAD ENGINEER AND CM
        ''Dim ID As String
        Try
            ''da = New SqlClient.SqlDataAdapter("Select ID From tblUsers Where Username = '" & User & "'", SqlConnection1)
            ''da.Fill(ds, "ID")
            ''Dim IdOfUser As String = ds.Tables("ID").Rows(0).Item("ID")

            ''da = New SqlClient.SqlDataAdapter("Select * From tblNotificationsGroups Where Program = '" & cboProgram.Text & "' And (Name = '" & User & "' Or User = '" & IdOfUser & "') And Role = 'Drafter'", SqlConnection1)
            ''da.Fill(ds, "IsAlreadyInNotificationsTable")
            ''ID = Val(ds.Tables("IsAlreadyInNotificationsTable").Rows(0).Item("ID"))
            ''If ds.Tables("IsAlreadyInNotificationsTable").Rows.Count > 0 Then
            ''    'Nothing
            ''Else
            ''    u.ExecuteSQL(SqlConnection1, "Insert into tblNotificationsGroups (Program, Name, Role, Active, [User], Gate0) Values ('" & cboProgram.Text & "','" & User & "','Drafter',1,'" & IdOfUser & "',1)")
            ''End If

            ''ds.Tables("ID").Clear()
            ''ds.Tables("ID").Dispose()
            ''ds.Tables("IsAlreadyInNotificationsTable").Clear()
            ''ds.Tables("IsAlreadyInNotificationsTable").Dispose()
            ''IdOfUser = ""


            ''Send notifications when creating a document. If the doc created does not have a doc number or is unassigned(Gate 0) send email to Planner, instead if it has
            ''a doc number the notification will be sent to the Drafter as this new doc will be set automatically to Gate 1
            ''If GateZeroOrOne = "GATE 0: CM Needs To Assign DWG Number" Then


            'SEND NOTIFICATION TO PLANNER, LEAD ENGINEER AND CM
            DrawingNumForEmails = FinalDocNumber
            ProgramName = ProgramNameSelected               'Program Name to use with Notifications
            RevisionForEmails = "IR"
            frmEngWorkflowSignOff.SendNotifications(7)


            ''ElseIf GateZeroOrOne = "GATE 1: DWG Ready For Drafter" Then
            ''    'Send notification to Drafter and Lead Engineer
            ''   frmEngWorkflowSignOff.SendNotifications(1)
            ''End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'Clearing variable(to say that a notification at gate 1 can be sent, since a new doc is being created). Need this because it was sending a notification to Gate 1 people twice, when saving with save btn and when saving with the signoff btn
        NotificationAlreadySentForGateOne = "No"
        'Update notifications label
        frmEngWorkflow.GetNumberTasksPending()

        'If the add drawing number button was clicked from EARR then next line will allow to run the code under btnAddDoc to run and add a response. The second line gets the draw # just added
        CreateRev = "Yes"
        DrawNumFromFormAorB = FinalDocNumber


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

    '                u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber) Values ('" & cboProject.Text & "', '" & cboSystem.Text & "', '" & FinalDocNumber & "', '" & ProgramNumbers & "')")
    '            End While

    '        ElseIf ds.Tables("ProgramNumbersInitial").Rows.Count = 1 Then
    '            u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber) Values ('" & cboProject.Text & "', '" & cboSystem.Text & "', '" & FinalDocNumber & "', '" & ds.Tables("ProgramNumbersInitial").Rows(0).Item("ProgramNumber") & "')")
    '        Else
    '            u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber) Values ('" & cboProject.Text & "', '" & cboSystem.Text & "', '" & FinalDocNumber & "', 'No Program Found')")
    '        End If

    '        ds.Tables("ProgramNumbersInitial").Clear()
    '        ds.Tables("ProgramNumbersInitial").Dispose()

    '        ds.Tables("ProjectsInserted").Clear()
    '        ds.Tables("ProjectsInserted").Dispose()
    '    End If
    'End Function

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


        If DocTypeSelected = "59 Engineering Order (Mechanical)" Then
            da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocTypePrefixLevelThree Where DocumentType = 'Engineering Order (Mechanical)' And DrawingOrReport = 'Report' Order By RecordID Desc", SqlConnection1)
        ElseIf DocTypeSelected = "59 Engineering Order (Electrical)" Then
            da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocTypePrefixLevelThree Where DocumentType = 'Engineering Order (Electrical)' And DrawingOrReport = 'Report' Order By RecordID Desc", SqlConnection1)
        Else
            da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocTypePrefixLevelThree Where DocumentType = '" & DocTypeSelected & "' And DrawingOrReport = 'Report' Order By RecordID Desc", SqlConnection1)
        End If
        da.Fill(ds, "USAReportDocSeqIdentifier")

        'Get Sequence JASC Prefix
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


        'PREVIOUS BLOCK OF CODE
        'If USAReportTrailing = "0" Then
        '    'Nothing
        'Else
        '    'If it is the last number in the sequence: 
        '    'get the first prefix of the doc type, delete all records where FirstPrefix <> to the first prefix just taken
        '    If USAReportDocSeqIdentifier = USAReportLastPrefix Then
        '        da = New SqlClient.SqlDataAdapter("Select TOP 1 * From tblDocTypePrefixLevelThree Where DocumentType = '" & DocTypeSelected & "' And DrawingOrReport = 'Report' Order By RecordID", SqlConnection1)
        '        da.Fill(ds, "FirstPrefixDrawing")
        '        FirstPrefix = ds.Tables("FirstPrefixDrawing").Rows(0).Item("Prefix")

        '        If FirstPrefix = "" Then
        '            'Nothing
        '        Else
        '            u.ExecuteSQL(SqlConnection1, "DELETE FROM tblDocTypePrefixLevelThree WHERE DocumentType = '" & DocTypeSelected & "' And Prefix != '" & FirstPrefix & "'  And DrawingOrReport = 'Report'")
        '        End If

        '        ds.Tables("FirstPrefixDrawing").Clear()
        '        ds.Tables("FirstPrefixDrawing").Dispose()
        '    Else
        '        'Add one to the prefix sequence and add to the table
        '        IncreasePrefixByOne(USAReportDocSeqIdentifier)
        '        u.ExecuteSQL(SqlConnection1, "Insert into " & tableToIncreaseSeq & " (Prefix,DocumentType,LastPrefix,Trailing,DrawingOrReport,Active) Values ('" & PrefixIncreasedByOne & "','" & USAReportDocType & "','" & USAReportLastPrefix & "','" & USAReportTrailing & "','" & USAReportClassification & "', 0)")
        '    End If
        'End If
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

            USADrawingRecordID = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("RecordID")
            USADrawingDocSeqIdentifier = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("Prefix")
            USADrawingDocType = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("DocumentType")
            USADrawingTrailing = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("Trailing")
            USADrawingLastPrefix = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("LastPrefix")
            NextPrefixDrawingUSA = ds.Tables("USADrawingNextDocSequence").Rows(0).Item("NextPrefix")
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


        da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocTypeInDropdown = '" & SelectedDocType & "'", SqlConnection1)
        'If DocTypeSelected = "59 Engineering Order (Mechanical)" Or DocTypeSelected = "59 Engineering Order (Electrical)" Then
        'da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "'", SqlConnection1)
        ''Else
        'da = New SqlClient.SqlDataAdapter("Select DocumentType from tblDocumentType Where DocumentType = '" & DocTypeSelected & "'", SqlConnection1)
        'End If

        'Get the document type without the numbers showing in front of the doc type selected from drop-down; for Canada reports
        da.Fill(ds, "DocTypeWithoutNumbers")
        DocTypeSelected = ds.Tables("DocTypeWithoutNumbers").Rows(0).Item("DocumentType")

        ds.Tables("DocTypeWithoutNumbers").Clear()
        ds.Tables("DocTypeWithoutNumbers").Dispose()


        'Get Sequence
        'If it is not the first sequence, code goes to another table that keeps track of the sequences

        'da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocumentType Where DocTypeInDropdown = '" & DocTypeSelected & "' And Classification = 'Report' Order By RecordID Desc", SqlConnection1)   'Before was tblDocTypePrefixLevelTwo
        If DocTypeSelected = "59 Engineering Order (Mechanical)" Or DocTypeSelected = "59 Engineering Order (Electrical)" Or DocTypeSelected = "Engineering Order (Mechanical)" Or DocTypeSelected = "Engineering Order (Electrical)" Then
            Dim DocTypeSelectEng As String = "Engineering Order"
            da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocumentType_NextSequences Where DocumentType = '" & DocTypeSelectEng & "' And Location = '" & CanadaOrUSA & "' And Program = '" & ProjectNameSelected & "' And DrawingOrReport = 'Report' Order By RecordID Desc", SqlConnection1)
        Else
            da = New SqlClient.SqlDataAdapter("Select TOP 1 * from tblDocumentType_NextSequences Where DocumentType = '" & DocTypeSelected & "' And Location = '" & CanadaOrUSA & "' And Program = '" & ProjectNameSelected & "' And DrawingOrReport = 'Report' Order By RecordID Desc", SqlConnection1)
        End If

        da.Fill(ds, "CanadaReportNextDocSeq")

        If ds.Tables("CanadaReportNextDocSeq").Rows.Count > 0 Then

            CanadaReportRecordID = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("RecordID")
            CanadaReportDocSeqIdentifier = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("Prefix")
            CanadaReportDocType = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("DocumentType")
            CanadaReportTrailing = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("Trailing")
            NextPrefixReportCanada = ds.Tables("CanadaReportNextDocSeq").Rows(0).Item("NextPrefix")
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
            CanadaReportRecordID = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("RecordID")
            CanadaReportDocSeqIdentifier = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("Prefix")
            CanadaReportDocType = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("DocumentType")
            If CanadaReportDocType = "Engineering Order (Mechanical)" Or CanadaReportDocType = "Engineering Order (Electrical)" Then
                CanadaReportDocType = "Engineering Order"
            End If
            CanadaReportTrailing = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("Trailing")
            CanadaReportLastPrefix = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("LastPrefix")
            NextPrefixReportCanada = ds.Tables("CanadaReportDocSeqIdentifier").Rows(0).Item("NextPrefix")
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
                'lblDocTypeSelectedLevelTwo.Text = "Test"
            Else
                lblDocTypeSelected.Text = ""
                lblDocTypeSelectedLevelTwo.Text = ""
                lblTextDocTypeSelected.Text = ""
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
                lblDocTypeSelectedLevelTwo.Text = DocTypeSelectedDisplayLevelTwo
            Else
                lblDocTypeSelected.Text = ""
                lblTextDocTypeSelected.Text = ""
                lblDocTypeSelectedLevelTwo.Text = ""
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
            da = New SqlClient.SqlDataAdapter("Select Distinct SectionNumAndDesc from tblDocTypeJASC_Series", SqlConnection1)
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

            If lblTextSeriesSelected.Text = "" Then
                lblTextSeriesSelected.Text = "No Series Selected"
            End If

            If lblTextDocTypeSelected.Text = "" Then
                lblTextDocTypeSelected.Text = "No Doc Type Selected"
            End If
            ds.Tables("DrawingsType").Clear()
            ds.Tables("DrawingsType").Dispose()
        End If
        'End If

        initialClick = True


        DocTypeForGuide = ""
        DocTypeForGuide = DrawingsOrReport      'Save if Drawing or Report, to use in the Guide form
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

    Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView2.AfterSelect

        'Show the selected value in the label displaying the selected value if the value has been selected all the way through

        'Get Series selected by user
        Dim SeriesSelected As String = TreeView2.SelectedNode.Text

        da = New SqlClient.SqlDataAdapter("Select * from tblDocTypeJASC_Series Where JASCAndDesc = '" & SeriesSelected & "'", SqlConnection1)
        da.Fill(ds, "SelectedSeries")

        If ds.Tables("SelectedSeries").Rows.Count > 0 Then
            lblSeriesSelected.Text = SeriesSelected
            lblTextSeriesSelected.Text = "Series Selected:"
        Else
            lblSeriesSelected.Text = ""
            lblTextSeriesSelected.Text = "No Series Selected"
        End If

        ds.Tables("SelectedSeries").Clear()
        ds.Tables("SelectedSeries").Dispose()
    End Sub


    'TO SELECT DISTINCT ON TWO FIELDS
    'Select * FROM
    '   (SELECT RecordID, DocumentType, Active, Classification, Notes, DocTypeInDropdown, Prefix, Trailing,
    '		    ROW_NUMBER() OVER (PARTITION BY DocumentType ORDER BY DocumentType) AS RowNumber 
    '    FROM [engdwgtest].[dbo].[tblDocumentType]) As a 
    '    WHERE a.RowNumber = 1

    'Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
    '    If initialClick = True Then
    '        'Dim test2 As String = TreeView1.SelectedNode.IsSelected
    '        'Dim test As String = TreeView1.SelectedNode.Text
    '        'Dim CurrentNode As TreeNode = TreeView1.SelectedNode
    '        'TreeView1.SelectedNode = CurrentNode

    '        'Dim DrawingsOrReport As String = TreeView1.SelectedNode.FullPath
    '        Dim DrawingsOrReport As String = TreeView1.SelectedNode.Text

    '        DrawingsOrReport = DrawingsOrReport.Substring(0, 1)

    '        If DrawingsOrReport = "R" Then
    '            DrawingsOrReport = "Report"
    '            lblSeries.Visible = False
    '            TreeView2.Visible = False
    '               btnJASCCodes.Visible = False
    '        ElseIf DrawingsOrReport = "D" Then
    '            DrawingsOrReport = "Drawing"
    '            lblSeries.Visible = True
    '            TreeView2.Visible = True
    '           btnJASCCodes.Visible = True
    '        End If
    '    End If
    'End Sub




    'Private Sub TreeView1_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterExpand

    '    If initialClick = True Then
    '        Dim DrawingsOrReport As String = TreeView1.SelectedNode.FullPath
    '        Dim CurrentNode As TreeNode = TreeView1.SelectedNode
    '        TreeView1.SelectedNode = CurrentNode
    '        Dim test As String = TreeView1.SelectedNode.Text


    '        DrawingsOrReport = DrawingsOrReport.Substring(0, 1)

    '        If DrawingsOrReport = "R" Then
    '            DrawingsOrReport = "Report"
    '            lblSeries.Visible = False
    '            TreeView2.Visible = False
    '        ElseIf DrawingsOrReport = "D" Then
    '            DrawingsOrReport = "Drawing"
    '            lblSeries.Visible = True
    '            TreeView2.Visible = True
    '        End If
    '    End If
    'End Sub

    'Private Sub cboProgram_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProgram.KeyDown

    'End Sub

    'Private Sub cboProgram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProgram.SelectedIndexChanged

    'End Sub

    'Private Sub cboProgram_TabIndexChanged(sender As Object, e As EventArgs) Handles cboProgram.TabIndexChanged

    'End Sub

    'Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick

    'End Sub

    'Private Sub TreeView1_AfterCollapse(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterCollapse

    'End Sub
End Class