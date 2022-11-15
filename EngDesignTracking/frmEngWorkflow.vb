Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports System.Net.Mail

Public Class frmEngWorkflow
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim da1 As SqlClient.SqlDataAdapter
    Dim ds1 As New DataSet
    Dim ds2 As New DataSet
    Dim da2 As SqlClient.SqlDataAdapter
    Dim Path As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "XtraGrid_SaveLayoutToXML1.xml")
    Dim JaguarOnly As Boolean
    Dim SaveGrid As String
    Dim RevAdd As Integer
    Dim Location As String
    Dim AIMNumber As String = ""
    Dim InitialDRNADCNStatusValue As String
    Dim StressDateDisabled As String
    Dim DataSavedWithSaveBtn As String
    Dim DrnCellValue As String
    Dim AdcnCellValue As String
    Dim SeqChangedToForIncorporated As Integer

    Dim isIncorporated As String
    'Dim isDRN As String
    'Dim isADCN As String
    Dim isGateSix As String

    Dim countForSave As Integer = 0

    Dim documentType As String = ""

    'Dim isNewRecord As String      'ADD THIS LINE (UNCOMMENT) 07/14/2022
    Dim IsDocNumConfirmed As String
    Public RowSelectedDrawingsGrid
    Public RowSelectedMainGrid
    Dim secondTime As Integer
    Dim IndexBeforeDelete As String
    Dim RevBeforeDelete As String

    Dim TypeOfIssue As String

    'MAIN EVENT THAT CHANGES WHEN MOVING BETWEEN DOCUMENTS AND REVISIONS IS  txtMainInfoRecordID


    Public Function PopulateDropDowns()
        Dim i As Integer = 0

        'Fill program drop down, that you get by selecting a cell under the program column, with values from database
        da = New SqlClient.SqlDataAdapter("Select * from tblProgram Order By ProgramName", SqlConnection1)
        da.Fill(ds, "Programs")


        'While i <= ds.Tables("Programs").Rows.Count - 1
        '    'RepositoryItemComboBox1.Items.Add(ds.Tables("Programs").Rows(i).Item("ProgramName"))
        '    Me.cboDetailsProgram.Properties.Items.Add(ds.Tables("Programs").Rows(i).Item("ProgramName"))
        '    i = i + 1
        'End While

        'ds.Tables("Programs").Clear()
        'ds.Tables("Programs").Dispose()


        If System.IO.File.Exists(Path) Then
            'The next two lines of code gets the layout of the grid as it was when the page was closed.  This layout is saved in a xml file
            GridControl1.ForceInitialize()
            ' Restore the previously saved layout 
            GridControl1.MainView.RestoreLayoutFromXml(Path)
        Else
            ' Create or overwrite the file.
            Dim fs As FileStream = File.Create(Path)

            ' Add text to the file.
            Dim sBody As String
            sBody = "Then<?xml version=""1.0"" ?>" & vbCrLf & vbCrLf & vbCrLf & "<XMLFileForMyProject>" & vbCrLf & vbCrLf & "</XMLFileForMyProject>"
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(sBody)
            fs.Write(info, 0, info.Length)
            fs.Close()
        End If
        ''i = 0
        Me.cboMainStatus.Properties.Items.Add("GATE 0: CM Needs To Assign DWG Number")
        Me.cboMainStatus.Properties.Items.Add("GATE 1: DWG Ready For Drafter")
        Me.cboMainStatus.Properties.Items.Add("GATE 2: DWG Ready For Sr Engineer")
        Me.cboMainStatus.Properties.Items.Add("GATE 3: DWG Ready For Operations")
        Me.cboMainStatus.Properties.Items.Add("GATE 4: DWG Ready For Release")
        Me.cboMainStatus.Properties.Items.Add("GATE 5: DWG Released")
        'Commented this so that the user cannot change anything to gate 6 as that can only get done via the signoff form. I mainly did this to solve the problem I would have 
        'when trying to set a DRN or ADCN that is at gate 6 to incorporated(after getting error message). I could not change this for a previous DRN or ADCN that is at gate 6
        'Me.cboMainStatus.Properties.Items.Add("GATE 6: Complete")

        '''Load DocumentType
        ''da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where Active = 'True' Order By DocumentType Asc", SqlConnection1)
        ''da.Fill(ds, "DocType")

        ''While i <= ds.Tables("DocType").Rows.Count - 1
        ''    Me.RepositoryItemComboBox5.Items.Add(ds.Tables("DocType").Rows(i).Item("DocumentType"))
        ''    i = i + 1
        ''End While

        ''ds.Tables("DocType").Clear()
        ''ds.Tables("DocType").Dispose()

        i = 0

        'Load DocumentType
        da = New SqlClient.SqlDataAdapter("Select * from tblWhiteBoardNumber Where Active = 'True' Order By Sequence Asc", SqlConnection1)
        da.Fill(ds, "WB")

        While i <= ds.Tables("WB").Rows.Count - 1
            Me.cboSchedWhiteBoard.Properties.Items.Add(ds.Tables("WB").Rows(i).Item("Name"))
            i = i + 1
        End While

        ds.Tables("WB").Clear()
        ds.Tables("WB").Dispose()

        i = 0

        'Load AssignmentName
        da = New SqlClient.SqlDataAdapter("Select * from tblNameAssignment Where Active = 'True' Order By Name Asc", SqlConnection1)
        da.Fill(ds, "AssignmentName")

        While i <= ds.Tables("AssignmentName").Rows.Count - 1
            Me.cbomaininfodrafter.Properties.Items.Add(ds.Tables("AssignmentName").Rows(i).Item("Name"))
            Me.cbomaininfoengineer.Properties.Items.Add(ds.Tables("AssignmentName").Rows(i).Item("Name"))
            Me.cbomaininfosrengineer.Properties.Items.Add(ds.Tables("AssignmentName").Rows(i).Item("Name"))
            'Me.cboFlammability.Items.Add(ds.Tables("AssignmentName").Rows(i).Item("Name"))
            'Me.cboStress.Items.Add(ds.Tables("AssignmentName").Rows(i).Item("Name"))
            'Me.cboAvionics.Items.Add(ds.Tables("AssignmentName").Rows(i).Item("Name"))
            'Me.cboMechanical.Items.Add(ds.Tables("AssignmentName").Rows(i).Item("Name"))
            Me.cbomaininforeleaser.Properties.Items.Add(ds.Tables("AssignmentName").Rows(i).Item("Name"))
            Me.cbomaininfoStress.Properties.Items.Add(ds.Tables("AssignmentName").Rows(i).Item("Name"))

            'DRNADCN Incorporated By combo box in DRN/ADCN tab
            Me.cboDRNADCNIncorporatedBy.Items.Add(ds.Tables("AssignmentName").Rows(i).Item("Name"))

            i = i + 1
        End While

        ds.Tables("AssignmentName").Clear()
        ds.Tables("AssignmentName").Dispose()

        da = New SqlClient.SqlDataAdapter("Select * from tblType Where Active = 'True' Order By Type Asc", SqlConnection1)
        da.Fill(ds, "Type")
        i = 0
        While i <= ds.Tables("Type").Rows.Count - 1
            Me.cboDetailsResourceType.Properties.Items.Add(ds.Tables("Type").Rows(i).Item("Type"))
            i = i + 1
        End While

        ds.Tables("Type").Clear()
        ds.Tables("Type").Dispose()

        'Load DocumentType
        da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where Active = 'True' Order By DocumentType Asc", SqlConnection1)
        da.Fill(ds, "DocType")
        i = 0
        While i <= ds.Tables("DocType").Rows.Count - 1
            Me.cboDetailsDocumentType.Properties.Items.Add(ds.Tables("DocType").Rows(i).Item("DocumentType"))
            i = i + 1
        End While

        ds.Tables("DocType").Clear()
        ds.Tables("DocType").Dispose()

        i = 0

        'Load AssignmentName
        da = New SqlClient.SqlDataAdapter("Select * from tblDRNADCN Where Active = 'True' Order By Seq Asc", SqlConnection1)
        da.Fill(ds, "DRNADCN")

        While i <= ds.Tables("DRNADCN").Rows.Count - 1
            Me.cboDRN.Properties.Items.Add(ds.Tables("DRNADCN").Rows(i).Item("Name"))
            'Me.cboADCN.Items.Add(ds.Tables("DRNADCN").Rows(i).Item("Name"))
            i = i + 1

        End While

        ds.Tables("DRNADCN").Clear()
        ds.Tables("DRNADCN").Dispose()

        i = 0

        'Load DocumentType
        da = New SqlClient.SqlDataAdapter("Select * from tblWhiteBoardNumber Where Active = 'True' Order By Sequence Asc", SqlConnection1)
        da.Fill(ds, "WB")

        While i <= ds.Tables("WB").Rows.Count - 1
            Me.cboSchedWhiteBoard.Properties.Items.Add(ds.Tables("WB").Rows(i).Item("Name"))
            i = i + 1
        End While

        ds.Tables("WB").Clear()
        ds.Tables("WB").Dispose()

        'Load Revisions Information
        da = New SqlClient.SqlDataAdapter("Select * From tblDwgRevisions Order By RecordID Asc", SqlConnection1)
        da.Fill(ds, "Revisions")

        i = 0
        While i <= ds.Tables("Revisions").Rows.Count - 1
            Me.cboMainRev.Properties.Items.Add(ds.Tables("Revisions").Rows(i).Item("DwgRevision"))
            i = i + 1
        End While

        'Loads Incorporated Rev combobox in DRN/ADCN tab; from above da/ds
        i = 0
        While i <= ds.Tables("Revisions").Rows.Count - 1
            Me.cboIncorporatedRev.Items.Add(ds.Tables("Revisions").Rows(i).Item("DwgRevision"))
            i = i + 1
        End While

        ds.Tables("Revisions").Clear()
        ds.Tables("Revisions").Dispose()
        i = 0

    End Function

    Private Sub frmEngWorkflow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

SHOWSELECTEDFROMTREE:

        SqlConnection1.ConnectionString = sqlString
        SqlConnection2.ConnectionString = sqlString
        SqlConnection3.ConnectionString = sqlString



        TabControl2.TabPages.Remove(tabAttachments)

        'Fill the View Combobox with whatever was selected when closing the application.  When closing the application the value in that combobox is saved in a variable contained in MyProject/Settings


        If My.Settings.CboViewVariable = "" Then
            Me.cboView.Text = "Current Revision"
        Else
            cboView.Text = My.Settings.CboViewVariable
        End If


        Me.TabPage1.Show()
        Me.TabPage3.Show()
        Me.TabPage4.Show()
        Me.TabPage5.Show()
        Me.TabPage6.Show()
        Me.TabPage7.Show()
        Me.TabPage8.Show()
        Me.tabAttachments.Show()


        ''If System.Environment.UserName = "rwatson" Or System.Environment.UserName = "cnguyen" Or System.Environment.UserName = "pcampbell" Or System.Environment.UserName = "jwebster" Or System.Environment.UserName = "fmiller" Then
        ''Else
        ''    Me.btnDrawingCert.Enabled = False

        ''End If

        'Check if the xml file that will contain the settings saved exists
        ''If System.IO.File.Exists(Path) Then
        ''    'The next two lines of code gets the layout of the grid as it was when the page was closed.  This layout is saved in a xml file
        ''    GridControl1.ForceInitialize()
        ''    ' Restore the previously saved layout 
        ''    GridControl1.MainView.RestoreLayoutFromXml(Path)
        ''Else
        ''    ' Create or overwrite the file.
        ''    Dim fs As FileStream = File.Create(Path)

        ''    ' Add text to the file.
        ''    Dim sBody As String
        ''    sBody = "<?xml version=""1.0"" ?>" & vbCrLf & vbCrLf & vbCrLf & "<XMLFileForMyProject>" & vbCrLf & vbCrLf & "</XMLFileForMyProject>"
        ''    Dim info As Byte() = New UTF8Encoding(True).GetBytes(sBody)
        ''    fs.Write(info, 0, info.Length)
        ''    fs.Close()
        ''End If




        'CHECK USER TABLE to see if user exists.  If user exists, allow application to launch.

        'Declaring my data adapter and specifying my select statement to pull data from the dataset.  I am reusing sqlconnection1 as my connection which was generated 
        'when I drug the datadapter onto my form and configured for the grid control.
        da = New SqlClient.SqlDataAdapter("Select * from tblUsers Where Username = '" & LCase(System.Environment.UserName) & "'", SqlConnection1)

        'I am filling the dataset (ds) from the data adapter created above and am specifying a table in the dataset.  This table name can be anything I want as long as I 
        'call the same table name when I want to query the dataset.
        da.Fill(ds, "USERAUTHENTICATE")



        'Here I am simply checking a value in the dataset that was filled above.  I am not connecting to the database at this point in anyway.
        If ds.Tables("USERAUTHENTICATE").Rows.Count > 0 Then
            JaguarOnly = ds.Tables("USERAUTHENTICATE").Rows(0).Item("JaguarOnly")
            username = ds.Tables("USERAUTHENTICATE").Rows(0).Item("ID")
            SaveGrid = ds.Tables("USERAUTHENTICATE").Rows(0).Item("GridEdit")
            CM = ds.Tables("USERAUTHENTICATE").Rows(0).Item("CM")
            Loc = ds.Tables("USERAUTHENTICATE").Rows(0).Item("Location")
            MDL = ds.Tables("USERAUTHENTICATE").Rows(0).Item("MDL")
            MDLUnlocked = ds.Tables("USERAUTHENTICATE").Rows(0).Item("MDLUnlock")
            isAdmin = ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin")
            isLiaison = ds.Tables("USERAUTHENTICATE").Rows(0).Item("LiaisonEngineer")
            isOperations = ds.Tables("USERAUTHENTICATE").Rows(0).Item("Operations")
            isDrafter = ds.Tables("USERAUTHENTICATE").Rows(0).Item("Drafter")
            ChangeRedline = ds.Tables("USERAUTHENTICATE").Rows(0).Item("ChangeRedline")
            MoveGates = ds.Tables("USERAUTHENTICATE").Rows(0).Item("MoveGates")
            'ChangeRedline = "T"
            'MoveGates = "T"

            If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
                'ChangeDocumentNumberToolStripMenuItem.Enabled = True
                AIMNumbersListToolStripMenuItem.Enabled = True
                'Me.dtmaininfoactualfinishdt.Enabled = True
                Me.maskedDetailsDCN.Visible = True
                lblDCN.Visible = True
                cboDRN.Enabled = True
                cboADCN.Enabled = True
                cboDRNADCNStatus.Enabled = True
                cboDRNADCNIncorporatedBy.Enabled = True
                cboIncorporatedRev.Enabled = True
            Else
                cboIncorporatedRev.Enabled = False
                cboDRN.Enabled = False
                cboDRNADCNIncorporatedBy.Enabled = False
                AIMNumbersListToolStripMenuItem.Enabled = False

                'Me.dtmaininfoactualfinishdt.Enabled = False
                Me.maskedDetailsDCN.Visible = False
                lblDCN.Visible = False
                cboDRN.Enabled = False
                cboADCN.Enabled = False
                cboDRNADCNStatus.Enabled = False
                cboDRNADCNIncorporatedBy.Enabled = False
                cboIncorporatedRev.Enabled = False
                'ChangeDocumentNumberToolStripMenuItem.Enabled = False
            End If
            If SaveGrid = "T" Then
                GridEditToolStripMenuItem.Enabled = True
            Else
                GridEditToolStripMenuItem.Enabled = False
            End If
            If ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
                Me.UsersToolStripMenuItem.Enabled = True
                Me.CertificationStaffToolStripMenuItem.Enabled = True
                Me.LovMaintenanceToolStripMenuItem.Enabled = True
                Me.AIMNumbersListToolStripMenuItem.Enabled = True
                Me.ProjectsToolStripMenuItem.Enabled = True
                Me.ProgramsToolStripMenuItem.Enabled = True
                'If System.Environment.UserName = "ohaswell" Then
                '    Me.ChangeDrawingNumberToolStripMenuItem.Enabled = True
                'Else
                '    Me.ChangeDrawingNumberToolStripMenuItem.Enabled = False
                'End If
            Else
                Me.UsersToolStripMenuItem.Enabled = False
                Me.CertificationStaffToolStripMenuItem.Enabled = False
                Me.LovMaintenanceToolStripMenuItem.Enabled = False
                Me.AIMNumbersListToolStripMenuItem.Enabled = False
                Me.ProjectsToolStripMenuItem.Enabled = False
                Me.ProgramsToolStripMenuItem.Enabled = False
                Me.ChangeDrawingNumberToolStripMenuItem.Enabled = False
            End If
            If ds.Tables("USERAUTHENTICATE").Rows(0).Item("ProjectSync") = True Then
                Me.ProjectServerWorkflowSyncToolStripMenuItem.Enabled = True
            Else
                Me.ProjectServerWorkflowSyncToolStripMenuItem.Enabled = False

            End If

            Search()
        Else
            MsgBox("You are not setup as an authorized user.")
            Application.Exit()
        End If


        'Check if it is CM/ADMIN/LeadEng and NewRecord is true. To use when showing or not the Number button
        If IsDBNull(ds.Tables("USERAUTHENTICATE").Rows(0).Item("LeadEngineer")) Then
            isLeadEngineer = "False"
        ElseIf ds.Tables("USERAUTHENTICATE").Rows(0).Item("LeadEngineer") = "False" Then
            isLeadEngineer = "False"
        Else
            isLeadEngineer = "True"
        End If

        If IsDBNull(ds.Tables("USERAUTHENTICATE").Rows(0).Item("NewRecord")) Then
            isNewRecord = "False"
        ElseIf ds.Tables("USERAUTHENTICATE").Rows(0).Item("NewRecord") = 0 Then
            isNewRecord = "False"
        Else
            isNewRecord = "True"
        End If


        If (CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Or isLeadEngineer = "True") And isLeadEngineer = "True" And isNewRecord = "True" Then
            isCM_LeadEng_Admin = "True"
            'btnAdd.Visible = False
        Else
            isCM_LeadEng_Admin = "False"
            'btnNumber.Visible = False
        End If



        PopulateDropDowns()

        If MDL = True Then
            Me.MDLToolStripMenuItem.Enabled = True
        Else
            Me.MDLToolStripMenuItem.Enabled = False
        End If


        'Save the initial Status of the revision for use in the code that checks is the status/gate has been moved backward
        initialStatus = cboMainStatus.Text



        GridView1.Columns("DCN").Visible = False
        'GridView1.Columns("NextHigherAssembly").Visible = False



        'EnableOrDisableCombosInDrnAdcnTab()


        'DrawingNumberBeingModified = txtMainDrawingNumber.Text



        HighlightRedTextboxesWithDefaultDate()



        'valueInitialRev = cboMainRev.Text    delete this
        'valueChangedToRev = cboMainRev.Text    delete this


        'Get Number of Tasks Pending for the User
        GetNumberTasksPending()


        'Next two lines are used for saving functionality: for saving regularly OR saving when they change something and forget to save
        countForSave = 1
        DataIsSaved = ""


        ''DRN/ADCN Change. Tab fills with another binding source
        ''Fill out grid of the DRN/ADCN tab. To get rid of records that do not have a DRN or ADCN. This was a requested change
        'da = New SqlClient.SqlDataAdapter("SELECT DwgRevision,DRNADCN,ADCN,Status,DRNADCNStatus,IncorporatedRev,ActualFinishDate,Drafter,DrafterComplete,SrEngineer,SrEngineerComplete,Stress,StressComplete,Engineer,EngineerComplete,Releaser,IncorporatedRev FROM tblDrawings Where DrawingNumber = '" & txtMainDrawingNumber.Text & "'", SqlConnection1)
        'da.Fill(ds, "RecordsWithDrnAdcn")
        'Me.bsDrnAdcn.DataSource = ds.Tables("RecordsWithDrnAdcn")
        'GridControl5.DataSource = Me.bsDrnAdcnbtnAddRedline

        'GridView5.Columns("DRNADCN").FilterInfo = New ColumnFilterInfo("[DRNADCN] NOT LIKE ''")
        'GridView5.Columns("ADCN").FilterInfo = New ColumnFilterInfo("[ADCN] NOT LIKE ''")


        If CM = True And isNewRecord = "True" Then   'Added per 09/28/22 ticket
            btncancelobsolete.Visible = True
        End If



        'Do not send notification if record is at Gate 1, since that means that the notification has already been sent
        If cboMainStatus.Text = "GATE 1: DWG Ready For Drafter" Then
            NotificationAlreadySentForGateOne = "Yes"
        End If


        'BLOCK OF CODE BELOW IS TO BE COMMENTED OUT
        'If System.Environment.UserName = "ohaswell" Or System.Environment.UserName = "apptestcm1" Or System.Environment.UserName = "jwebster" Or System.Environment.UserName = "nsantagata" Or System.Environment.UserName = "rduwel" Or System.Environment.UserName = "llewis" Or System.Environment.UserName = "jsprigg" Or System.Environment.UserName = "rdetillier" Or System.Environment.UserName = "jrovenstine" Or System.Environment.UserName = "alee" Or System.Environment.UserName = "pcampbell" Or System.Environment.UserName = "rrathwell" Or System.Environment.UserName = "mpoma" Or System.Environment.UserName = "uniaz" Then
        If isNewRecord = "True" Then    'ADDED THIS LINE 07/14/2022, per Owen
            btnAdd.Visible = True       'ADDED THIS LINE 07/14/2022, per Owen
        Else
            btnNumber.Visible = False

            'COMMENTED OUT: The next 7 lines will be deleted except for the sixth line which will remain (eventually also the sixth line and everything in this block will be deleted)
            'Dim testUsername As String = "AppTestEng1"
            If System.Environment.UserName = "brauenbuehler" Or System.Environment.UserName = "AppTestEng1" Or System.Environment.UserName = "kticknor" Or System.Environment.UserName = "preteshwars" Or System.Environment.UserName = "rhaggan" Or System.Environment.UserName = "prakhe" Or System.Environment.UserName = "rkumar" Or System.Environment.UserName = "dchristian" Then
                btnAdd.Visible = True
            Else
                btnAdd.Visible = False
            End If

            'btnAdd.Visible = False
        End If

    End Sub

    Public Function Search()

        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet241.vwDrawingsRev.Clear()

        Me.txtMainRecordID.DataBindings.Clear()
        Me.txtMainLocation.DataBindings.Clear()
        Me.txtMainProgram.DataBindings.Clear()  'This will actually contain Project
        Me.txtMainStatus.DataBindings.Clear()
        Me.txtMainDrawingNumber.DataBindings.Clear()
        Me.txtMainTitle.DataBindings.Clear()



        Dim cmdSave As String
        SqlString = ""

        'Show Drawing Number Selected in the Assembly Grid
        If ShowAssemblyClicked = "Yes" Then

            Me.SqlDataAdapter1.SelectCommand.CommandText = "Select * From vwDrawingsRev"

            If JaguarOnly = True Then
                SqlString = " Where DrawingNumber = '" & DrawingNumFromAssembly & "' And RecordID = RecordID And Status != 'Cancelled' And Status != 'Obsolete' AND Program = 'Jaguar' OR RecordID = RecordID AND Program = '2635 – Jaguar' And Status != 'Cancelled' And Status != 'Obsolete' OR RecordID = RecordID AND Program = 'Jaguar - BE-1900D' And Status != 'Cancelled' And Status != 'Obsolete' OR RecordID = RecordID AND Program = '2640 - Missionized Interior MMSA-C (G550)' And Status != 'Cancelled' And Status != 'Obsolete'"
            Else
                SqlString = " Where DrawingNumber = '" & DrawingNumFromAssembly & "' And RecordID = RecordID And Status != 'Cancelled' And Status != 'Obsolete'"
            End If


            'Show Drawing Number selected in upper grids
        Else

            ''If DocAdd > 0 Then
            ''    Me.SqlDataAdapter1.SelectCommand.CommandText = "Select * from vwDrawingsRev"
            ''    SqlString = " Where RecordID = RecordID"
            ''    SqlString = SqlString + " And RecordID = '" & Val(DocAdd) & "'"
            ''    DocAdd = 0
            If cboView.Text = "In Design" Then
                Me.SqlDataAdapter1.SelectCommand.CommandText = "Select * from vwDrawingsRev"


                If JaguarOnly = True Then
                    'SqlString = SqlString + " Where RecordID = RecordID AND Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = 'JAGUAR' OR RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = '2635 - Jaguar'"
                    'Following line substituted line above, per SOW 10/23/202
                    SqlString = SqlString + " Where RecordID = RecordID And Status != 'Canceled' And Status != 'Obsolete' AND Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = 'Jaguar' OR RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = '2635 – Jaguar' And Status != 'Cancelled' And Status != 'Obsolete' OR RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = 'Jaguar - BE-1900D' And Status != 'Cancelled' And Status != 'Obsolete' OR RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = '2640 - Missionized Interior MMSA-C (G550)' And Status != 'Cancelled' And Status != 'Obsolete'"
                Else
                    'SqlString = SqlString + " Where RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete')"
                    'Following line substituted line above, per SOW 10/23/2020
                    SqlString = SqlString + " Where RecordID = RecordID And Status != 'Canceled' And Status != 'Obsolete' And Status Not In ('GATE 6: Complete', 'GATE 9: Complete')"
                End If

            ElseIf Me.cboView.Text = "In Design and Completed" Then
                Me.SqlDataAdapter1.SelectCommand.CommandText = "Select * from vwDrawingsRev"


                If JaguarOnly = True Then
                    SqlString = SqlString + " Where (RecordID = RecordID And Program = 'Jaguar' And Status != 'Canceled' And Status != 'Obsolete') OR (RecordID = RecordID and Program = '2635 – Jaguar' And Status != 'Canceled' And Status != 'Obsolete') OR (RecordID = RecordID and Program = 'Jaguar - BE-1900D' And Status != 'Canceled' And Status != 'Obsolete') OR (RecordID = RecordID and Program = '2640 - Missionized Interior MMSA-C (G550)' And Status != 'Canceled' And Status != 'Obsolete')"
                Else
                    SqlString = SqlString + " Where RecordID = RecordID And Status != 'Canceled' And Status != 'Obsolete'"
                End If

            ElseIf Me.cboView.Text = "Current Revision" Then

                If JaguarOnly = True Then
                    'Me.SqlDataAdapter1.SelectCommand.CommandText = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev Where Status != 'Canceled' And Status != 'Cancelled' And Status != 'Obsolete') AS derived WHERE row_num = 1 AND Program = 'Jaguar' And Status != 'Canceled' And Status != 'Cancelled' And Status != 'Obsolete' OR row_num = 1 AND Program = '2635 – Jaguar' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' OR row_num = 1 AND Program = '2640 - Missionized Interior MMSA-C (G550)' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' OR row_num = 1 AND Program = 'Jaguar - BE-1900D' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete'"
                    Me.SqlDataAdapter1.SelectCommand.CommandText = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC, RecordID DESC) AS row_num FROM vwDrawingsRev Where Status != 'Canceled' And Status != 'Cancelled' And Status != 'Obsolete') AS derived WHERE row_num = 1 And ((DRNADCN Is Not Null And DRNADCN != '') Or (ADCN Is Not Null And ADCN != '')) AND Program = 'Jaguar' And Status != 'Canceled' And Status != 'Cancelled' And Status != 'Obsolete' OR row_num = 1 And ((DRNADCN Is Not Null And DRNADCN != '') Or (ADCN Is Not Null And ADCN != '')) AND Program = '2635 – Jaguar' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' OR row_num = 1 And ((DRNADCN Is Not Null And DRNADCN != '') Or (ADCN Is Not Null And ADCN != '')) AND Program = '2640 - Missionized Interior MMSA-C (G550)' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' OR row_num = 1 And ((DRNADCN Is Not Null And DRNADCN != '') Or (ADCN Is Not Null And ADCN != '')) AND Program = 'Jaguar - BE-1900D' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' UNION SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC, RecordID DESC) AS row_num FROM vwDrawingsRev Where Status != 'Canceled' And Status != 'Cancelled' And Status != 'Obsolete' And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '')) AS derived WHERE row_num = 1 AND Program = 'Jaguar' And Status != 'Canceled' And Status != 'Cancelled' And Status != 'Obsolete' OR row_num = 1 AND Program = '2635 – Jaguar' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' OR row_num = 1 AND Program = '2640 - Missionized Interior MMSA-C (G550)' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' OR row_num = 1 AND Program = 'Jaguar - BE-1900D' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete'"
                Else
                    'Me.SqlDataAdapter1.SelectCommand.CommandText = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC) AS row_num FROM vwDrawingsRev Where Status != 'Canceled' And Status != 'Cancelled' And Status != 'Obsolete') AS derived WHERE row_num = 1"
                    Me.SqlDataAdapter1.SelectCommand.CommandText = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC, RecordID Desc) AS row_num FROM vwDrawingsRev Where Status != 'Canceled' And Status != 'Cancelled' And Status != 'Obsolete') AS derived WHERE row_num = 1 And ((DRNADCN Is Not Null And DRNADCN != '') Or (ADCN Is Not Null And ADCN != '')) UNION SELECT * FROM (SELECT *, ROW_NUMBER() OVER(PARTITION BY DrawingNumber ORDER BY Seq DESC, RecordID Desc) AS row_num FROM vwDrawingsRev Where Status != 'Canceled' And Status != 'Cancelled' And Status != 'Obsolete' And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '')) AS derived WHERE row_num = 1"
                End If

            ElseIf Me.cboView.Text = "Cancelled" Then

                Me.SqlDataAdapter1.SelectCommand.CommandText = "Select * from vwDrawingsRev"


                If JaguarOnly = True Then
                    SqlString = SqlString + " Where RecordID = RecordID And Program = 'Jaguar' And Status = 'Canceled' OR RecordID = RecordID and Program = '2635 – Jaguar' And Status = 'Canceled' OR RecordID = RecordID and Program = 'Jaguar - BE-1900D' And Status = 'Canceled' OR RecordID = RecordID and Program = '2640 - Missionized Interior MMSA-C (G550)' And Status = 'Canceled'"
                Else
                    SqlString = SqlString + " Where RecordID = RecordID And Status = 'Canceled'"
                End If

            ElseIf Me.cboView.Text = "Obsolete" Then

                Me.SqlDataAdapter1.SelectCommand.CommandText = "Select * from vwDrawingsRev"


                If JaguarOnly = True Then
                    SqlString = SqlString + " Where RecordID = RecordID And Program = 'Jaguar' And Status = 'Obsolete' OR RecordID = RecordID and Program = '2635 – Jaguar' And Status = 'Obsolete' OR RecordID = RecordID and Program = '2640 - Missionized Interior MMSA-C (G550)' And Status = 'Obsolete' OR RecordID = RecordID and Program = 'Jaguar - BE-1900D' And Status = 'Obsolete'"
                Else
                    SqlString = SqlString + " Where RecordID = RecordID And Status = 'Obsolete'"
                End If

            ElseIf Me.cboView.Text = "All" Then

                Me.SqlDataAdapter1.SelectCommand.CommandText = "Select * From vwDrawingsRev"

                If JaguarOnly = True Then
                    SqlString = SqlString + " Where (RecordID = RecordID And Program = 'Jaguar') OR (RecordID = RecordID and Program = '2635 – Jaguar') OR (RecordID = RecordID and Program = 'Jaguar - BE-1900D') OR (RecordID = RecordID and Program = '2640 - Missionized Interior MMSA-C (G550)')"
                Else
                    SqlString = SqlString + " Where RecordID = RecordID"
                End If

            ElseIf Me.cboView.Text = "Notifications" Then

                GetNumberTasksPending()

                Me.SqlDataAdapter1.SelectCommand.CommandText = SelectNotificationsView
                SelectNotificationsView = ""

            End If

        End If


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter1.Fill(DataSet241.vwDrawingsRev)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet241.Tables("vwDrawingsRev").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True           

            Search = True
            Me.txtMainDrawingNumber.DataBindings.Add("Text", Me.bsMainGrid, "DrawingNumber")
            'Create DataBindings
            Me.txtMainRecordID.DataBindings.Add("Text", Me.bsMainGrid, "RecordID")
            Me.txtMainLocation.DataBindings.Add("Text", Me.bsMainGrid, "Location")
            Me.txtMainProgram.DataBindings.Add("Text", Me.bsMainGrid, "Program")    'txtMainProgram will actually contain project
            Me.txtMainStatus.DataBindings.Add("Text", Me.bsMainGrid, "Status")
            Me.txtMainTitle.DataBindings.Add("Text", Me.bsMainGrid, "DrawingTitle")

            SearchMainInformation()

        Else
            MsgBox("No Records Exist")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If


        If DocAdd > 0 Then

            GridView1.FocusedRowHandle = GridView1.LocateByValue("RecordID", DocAdd)
            'GridView1.Appearance.HideSelectionRow.BackColor = Color.LimeGreen
            DocAdd = 0
        End If

        If RevAdd > 0 Then
            GridView1.FocusedRowHandle = GridView1.LocateByValue("RecordID", RevAdd)
            'GridView1.Appearance.HideSelectionRow.BackColor = Color.LimeGreen
            RevAdd = 0
        End If

        If ChangeDocNumber <> "" Then
            GridView1.FocusedRowHandle = GridView1.LocateByValue("DrawingNumber", ChangeDocNumber)
            'ChangeDocNumber = ""
        End If
    End Function


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Search()
        HighlightRedTextboxesWithDefaultDate()
    End Sub

    Private Sub btnExportGrid_Click(sender As Object, e As EventArgs) Handles btnExportGrid.Click
        GridControl1.ExportToXlsx("C:\Temp\Export.xlsx")
        MsgBox("Grid has been exported to c:\temp\export.xlsx.")
        'Open the excel file.

    End Sub

    Private Sub txtMainRecordID_TextChanged(sender As Object, e As EventArgs) Handles txtMainRecordID.TextChanged

        SearchMainInformation()


        'VALIDATION: CHECK IF REVISION IS A REPORT OR A DRAWING. DRNs and ADCNs CANNOT BE CREATED IF DOCUMENT TYPE IS A REPORT. ALSO WHEN LOCATION IS TORONTO NO ADCN; WHEN LOCATION IS OKC NO DRN
        AllowDrnAdcn()
        'Dim test As String = txtMainInfoRecordID.Text & " " & txtMainDrawingNumber.Text & " " & DrnAllowed & " " & AdcnAllowed & " " & LocationForDrnAdcn

    End Sub

    Public Function SearchMainInformation()

        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet211.tblDrawings.Clear()

        Me.cboMainRev.DataBindings.Clear()
        Me.cboMainStatus.DataBindings.Clear()
        Me.txtmaininfotitle.DataBindings.Clear()
        Me.dtmaininfoactualfinishdt.DataBindings.Clear()
        Me.cbomaininfodrafter.DataBindings.Clear()
        Me.cbomaininfoengineer.DataBindings.Clear()
        Me.cbomaininfosrengineer.DataBindings.Clear()
        Me.cbomaininforeleaser.DataBindings.Clear()
        Me.cbomaininfoStress.DataBindings.Clear()
        Me.dtmaininfodraftercomp.DataBindings.Clear()
        Me.dtmaininfoengcomp.DataBindings.Clear()
        Me.dtmaininfosrengcomp.DataBindings.Clear()
        Me.dtmaininforeleasercomp.DataBindings.Clear()
        Me.dtmaininfoStressComp.DataBindings.Clear()
        Me.txtMainInfoRecordID.DataBindings.Clear()


        'Details Tab Bindings
        'Me.cboDetailsProgram.DataBindings.Clear()
        Me.txtMainProjectName.DataBindings.Clear()
        Me.cboDetailsSystem.DataBindings.Clear()
        Me.cboDetailsLocation.DataBindings.Clear()
        Me.cboDetailsResourceType.DataBindings.Clear()
        Me.cboDetailsDocumentType.DataBindings.Clear()
        Me.txtDetailsNextAssemblyDrawing.DataBindings.Clear()
        Me.maskedDetailsDCN.DataBindings.Clear()

        'Notes Tab Bindings
        Me.txtNotesNotes.DataBindings.Clear()

        Me.cboDRN.DataBindings.Clear()
        Me.cboADCN.DataBindings.Clear()
        Me.cboDRNADCNStatus.DataBindings.Clear()
        Me.cboDRNADCNIncorporatedBy.DataBindings.Clear()
        Me.cboIncorporatedRev.DataBindings.Clear()

        Me.txtSchedWorkOrder.DataBindings.Clear()
        Me.dtSchedForecastStart.DataBindings.Clear()
        Me.dtSchedForecastFinish.DataBindings.Clear()
        Me.mskSchedDuration.DataBindings.Clear()
        'Me.cboSchedPercComp.DataBindings.Clear()   'Previous one instead of the below line when I used the now hidden cboSchedPercComp masked textbox
        Me.cboPercentComplete.DataBindings.Clear()
        Me.cboSchedMilestone.DataBindings.Clear()
        Me.cboSchedWhiteBoard.DataBindings.Clear()
        txtDetailsInstallationDrawing.DataBindings.Clear()





        Dim cmdSave As String

        If Me.txtMainDrawingNumber.Text = "" Then

            'I added the And in the Where clause to not select records that were "Record Was Deleted" (basically do not include deleted records if is not a CM or Admin)
            da = New SqlClient.SqlDataAdapter("Select * from tblUsers Where Username = '" & LCase(System.Environment.UserName) & "'", SqlConnection1)
            da.Fill(ds, "USERAUTHENTICATE")

            If ds.Tables("USERAUTHENTICATE").Rows.Count > 0 Then
                If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
                    SqlString = " Where tbldrawings.RecordID = '" & Val(Me.txtMainRecordID.Text) & "' Order By Seq Desc, ADCN Desc, SeqDRN Desc"
                Else
                    SqlString = " Where tbldrawings.RecordID = '" & Val(Me.txtMainRecordID.Text) & "' And (RIGHT(tblDrawings.AIM, 18) != 'Record Was Marked Obsolete' Or tblDrawings.AIM Is Null) Order By Seq Desc, ADCN Desc, SeqDRN Desc"
                End If
            Else
                SqlString = " Where tbldrawings.RecordID = '" & Val(Me.txtMainRecordID.Text) & "' And (RIGHT(tblDrawings.AIM, 18) != 'Record Was Marked Obsolete' Or tblDrawings.AIM Is Null) Order By Seq Desc, ADCN Desc, SeqDRN Desc"
            End If

        Else
            'I added the And in the Where clause to not select records that were "Record Was Deleted" (basically do not include deleted records)
            If ds.Tables("USERAUTHENTICATE").Rows.Count > 0 Then
                If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
                    SqlString = " Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' Order By Seq Desc, ADCN Desc, SeqDRN Desc"
                Else
                    SqlString = " Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And (RIGHT(tblDrawings.AIM, 18) != 'Record Was Marked Obsolete' Or tblDrawings.AIM Is Null) Order By Seq Desc, ADCN Desc, SeqDRN Desc"
                End If
            Else
                SqlString = " Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And (RIGHT(tblDrawings.AIM, 18) != 'Record Was Marked Obsolete' Or tblDrawings.AIM Is Null) Order By Seq Desc, ADCN Desc, SeqDRN Desc"
            End If

        End If

        'SqlString = " Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' Order By Seq Asc"


        cmdSave = Me.SqlDataAdapter2.SelectCommand.CommandText
        'I added the next line of code to create the code needed to filter by doc rev, then adcn and then drn. To implement this I had to LEFT JOIN another table to get the DRN sequence. This way I did not have to change DataAdapter2 nor any dataset.  
        Me.SqlDataAdapter2.SelectCommand.CommandText = "SELECT tblDrawings.RecordID, tblDrawings.DocumentType, tblDrawings.Priority, tblDrawings.Location, tblDrawings.Type, tblDrawings.DwgRequestBy, tblDrawings.DrawingNumber, tblDrawings.DwgRequestDate, tblDrawings.DrawingTitle, tblDrawings.Program, tblDrawings.ProgramReal, tblDrawings.DrawingType, tblDrawings.SystemDescription, tblDrawings.Status, tblDrawings.LastActionDate, tblDrawings.ActualFinishDate, tblDrawings.ForecastStartDate, tblDrawings.ForecastFinishDate, tblDrawings.PlannedFinishDate, tblDrawings.EstimatedDurationHours, tblDrawings.PercentComplete, tblDrawings.DrawingFolderAssignDate, tblDrawings.DesignWIPDate, tblDrawings.Notes, tblDrawings.ModelTemplateDate, tblDrawings.Drafter, tblDrawings.DrafterComplete, tblDrawings.Engineer, tblDrawings.EngineerComplete, tblDrawings.SrEngineer, tblDrawings.SrEngineerComplete, tblDrawings.Releaser, tblDrawings.ReleaserCompelte, tblDrawings.Flammability, tblDrawings.FlammabilityComplete, tblDrawings.Stress, tblDrawings.StressComplete, tblDrawings.DwgRevision AS Expr2, tblDrawings.RefID, tblDrawings.DrafterPlannedCompleteDate, tblDrawings.EngineerPlannedCompleteDate, tblDrawings.SrEngineerPlannedCompleteDate, tblDrawings.FlammabilityPlannedCompleteDate, tblDrawings.StressPlannedCompleteDate, tblDrawings.ReleaserPlannedCompleteDate, tblDrawings.Avionics, tblDrawings.AvionicsComplete, tblDrawings.AvionicsPlannedComplete, tblDrawings.Mechanical, tblDrawings.MechanicalComplete, tblDrawings.MechanicalPlannedComplete, tblDrawings.WONumber, tblDrawings.NextHigherAssembly, tblDrawings.InstallationDrawing, tblDrawings.WhiteBoardNumber, tblDrawings.DRNADCN, tblDrawings.FAAProjectNo, tblDrawings.PSCPDocsRequired, tblDrawings.CompanyFlightTestRequired, tblDrawings.DwgReqDate, tblDrawings.NewRework, tblDrawings.Updated, tblDrawings.UpdatedDate, tblDwgRevisions.DwgRevision, tblDwgRevisions.Seq, tblDrawings.ADCN, tblDrawings.DCN, tblDrawings.DRNADCNStatus, tblDrawings.DRNADCNIncorporatedBy, tblDrawings.IncorporatedRev, tblDRNADCN.Seq as SeqDRN FROM tblDrawings INNER JOIN tblDwgRevisions ON tblDrawings.DwgRevision = tblDwgRevisions.DwgRevision LEFT JOIN tblDRNADCN ON tblDrawings.DRNADCN = tblDRNADCN.Name"
        Me.SqlDataAdapter2.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter2.Fill(Me.DataSet211.tblDrawings)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter2.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet211.Tables("tblDrawings").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            'Search = True

            'Create DataBindings
            'Me.txtMainRecordID.DataBindings.Add("Text",
            'Me.bsMainGrid, "RecordID")


            'VALIDATION: In Details tab, hide masked DCN column and DCN input box if location is Toronto
            If IsDBNull(DataSet211.Tables("tblDrawings").Rows(0).Item("Location")) Then
                Location = ""
            Else
                Location = DataSet211.Tables("tblDrawings").Rows(0).Item("Location")
            End If

            If Location = "Toronto" Then
                GridView3.Columns("DCN").Visible = False
                maskedDetailsDCN.Visible = False
                lblDCN.Visible = False
            Else
                GridView3.Columns("DCN").Visible = True
                maskedDetailsDCN.Visible = True
                lblDCN.Visible = True
            End If





            Me.cboMainRev.DataBindings.Add("Text",
                                           Me.bsMainInformationTab, "DwgRevision")

            Me.txtmaininfotitle.DataBindings.Add("Text",
                                           Me.bsMainInformationTab, "DrawingTitle")
            Me.dtmaininfoactualfinishdt.DataBindings.Add("Text",
                                           Me.bsMainInformationTab, "ActualFinishDate")
            Me.cbomaininfodrafter.DataBindings.Add("Text",
                                           Me.bsMainInformationTab, "Drafter")
            Me.cbomaininfoengineer.DataBindings.Add("Text",
                                           Me.bsMainInformationTab, "Engineer")
            Me.cbomaininfosrengineer.DataBindings.Add("Text",
                                           Me.bsMainInformationTab, "srengineer")
            Me.cbomaininforeleaser.DataBindings.Add("Text",
                                           Me.bsMainInformationTab, "Releaser")
            Me.cbomaininfoStress.DataBindings.Add("Text",
                                           Me.bsMainInformationTab, "Stress")
            Me.dtmaininfodraftercomp.DataBindings.Add("Text",
                                           Me.bsMainInformationTab, "DrafterComplete")
            Me.dtmaininfoengcomp.DataBindings.Add("Text",
                                           Me.bsMainInformationTab, "EngineerComplete")
            Me.dtmaininfosrengcomp.DataBindings.Add("Text",
                                           Me.bsMainInformationTab, "SrEngineerComplete")
            Me.dtmaininforeleasercomp.DataBindings.Add("Text",
                                           Me.bsMainInformationTab, "ReleaserCompelte")
            Me.dtmaininfoStressComp.DataBindings.Add("Text",
                                           Me.bsMainInformationTab, "StressComplete")

            'Details Bindings           
            Me.cboDetailsSystem.DataBindings.Add("Text",
                               Me.bsMainInformationTab, "SystemDescription")
            Me.cboDetailsLocation.DataBindings.Add("Text",
                               Me.bsMainInformationTab, "Location")
            Me.cboDetailsResourceType.DataBindings.Add("Text",
                               Me.bsMainInformationTab, "Type")
            Me.cboDetailsDocumentType.DataBindings.Add("Text",
                               Me.bsMainInformationTab, "DocumentType")
            Me.maskedDetailsDCN.DataBindings.Add("Text", Me.bsMainInformationTab, "DCN")

            'Notes Bindings
            Me.txtNotesNotes.DataBindings.Add("Text",
                   Me.bsMainInformationTab, "Notes")

            'Notes Bindings
            Me.cboDRN.DataBindings.Add("Text", Me.bsMainInformationTab, "DRNADCN")
            Me.cboADCN.DataBindings.Add("Text", Me.bsMainInformationTab, "ADCN")
            Me.cboDRNADCNStatus.DataBindings.Add("Text", Me.bsMainInformationTab, "DRNADCNStatus")
            Me.cboDRNADCNIncorporatedBy.DataBindings.Add("Text", Me.bsMainInformationTab, "DRNADCNIncorporatedBy")
            Me.cboIncorporatedRev.DataBindings.Add("Text", Me.bsMainInformationTab, "IncorporatedRev")


            Me.txtSchedWorkOrder.DataBindings.Add("Text",
                   Me.bsMainInformationTab, "WONumber")
            Me.dtSchedForecastStart.DataBindings.Add("Text",
                   Me.bsMainInformationTab, "ForecastStartDate")
            Me.dtSchedForecastFinish.DataBindings.Add("Text",
                   Me.bsMainInformationTab, "FOrecastFinishDate")
            Me.mskSchedDuration.DataBindings.Add("Text",
                   Me.bsMainInformationTab, "EstimatedDurationHours")
            'Me.cboSchedPercComp.DataBindings.Add("Text",
            '       Me.bsMainInformationTab, "PercentComplete")     'Previous one instead of the below line when I used the now hidden cboSchedPercComp masked textbox
            Me.cboPercentComplete.DataBindings.Add("Text",
                   Me.bsMainInformationTab, "PercentComplete")
            Me.cboSchedMilestone.DataBindings.Add("Text",
                   Me.bsMainInformationTab, "Priority")
            Me.cboSchedWhiteBoard.DataBindings.Add("Text",
                   Me.bsMainInformationTab, "WhiteBoardNumber")
            'Me.txtDetailsNextAssemblyDrawing.DataBindings.Add("Text",
            '                                                  Me.bsMainInformationTab, "NextHigherAssembly")

            Me.txtDetailsInstallationDrawing.DataBindings.Add("Text",
                                      Me.bsMainInformationTab, "InstallationDrawing")
            Me.cboMainStatus.DataBindings.Add("Text",
                               Me.bsMainInformationTab, "Status")
            Me.txtMainInfoRecordID.DataBindings.Add("Text",
                               Me.bsMainInformationTab, "RecordID")
            'Me.cboDetailsProgram.DataBindings.Add("Text", Me.bsMainInformationTab, "Program")

            Me.txtMainProjectName.DataBindings.Add("Text", Me.bsMainInformationTab, "Program")  'This contains Project           


            'Below contains Program
            cboDetailsProgram.Text = ""
            da = New SqlClient.SqlDataAdapter("Select ProgramReal From tblDrawings Where RecordID = '" & txtMainInfoRecordID.Text & "'", SqlConnection1)
            da.Fill(ds, "ProgramReal")
            If ds.Tables("ProgramReal").Rows.Count > 0 Then
                If IsDBNull(ds.Tables("ProgramReal").Rows(0).Item("ProgramReal")) Then
                    ProgramName = ""
                ElseIf ds.Tables("ProgramReal").Rows(0).Item("ProgramReal") = "" Then
                    ProgramName = ""
                Else
                    cboDetailsProgram.Text = ds.Tables("ProgramReal").Rows(0).Item("ProgramReal")
                    ProgramName = cboDetailsProgram.Text
                End If
                ds.Tables("ProgramReal").Clear()
                ds.Tables("ProgramReal").Dispose()
            End If
        Else
            'MsgBox("No Records Exist")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If


        'Hide InstallationDrawing and NextHigherAssembly columns in the Details tab as they are not needed anymore
        GridView3.Columns("InstallationDrawing").Visible = False
        'GridView3.Columns("NextHigherAssembly").Visible = False

    End Function


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'If allowed user and is New Program then open Form B, otherwise Form A
        If isCM_LeadEng_Admin = "True" Then     'And IsDocNumConfirmed = "No" 
            CreateOrModifyDocNum = "Create"

            Dim frmEngWorkflowAddFormB As New frmEngWorkflowAddFormB
            frmEngWorkflowAddFormB.ShowDialog()

        Else
            Dim frmEngWorkflowAdd As New frmEngWorkflowAdd
            frmEngWorkflowAdd.ShowDialog()
        End If


        Search()



        'Get the latest revision for the drawing # displayed on the form.

        'Determine based on the latest revision what the next revision should be.

        'Confirm with user to create new revision now.
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Dim AdminScreen As New AdminScreen
        AdminScreen.Show()
        'Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim frmMain As New frmMain
        frmMain.Show()

        Me.Close()

    End Sub

    Private Sub btnAddNewRev_Click(sender As Object, e As EventArgs) Handles btnAddNewRev.Click
        Dim EnterWOAndDateNow As String = ""

        SqlConnection1.ConnectionString = sqlString


        NotificationAlreadySentForGateOne = "No"   'Clearing variable(to say that a notification at gate 1 can be sent, since a new doc is being created). Need this because it was sending a notification to Gate 1 people twice, when saving with save btn and when saving with the signoff btn


        Dim StatusCellValue As String

        DrawingNumberBeingModified = txtMainDrawingNumber.Text



        If Me.txtMainDrawingNumber.Text = "" Then
            MsgBox("A Document Number does not exist for the record.  You cannot rev a document with no number.  A revision will not be created.")
            CreateRev = "No"
            Exit Sub

        Else

            'Cannot add a revision if the drawing number was marked Obsolete
            If cboMainStatus.Text = "Obsolete" Then
                MsgBox("You cannot create a new revision or a DRN or an ADCN if the drawing number was marked obsolete")
                CreateRev = "No"
                Exit Sub
            End If


            'VALIDATION: CHECK ALL REVISIONS ARE AT GATE 6 BEFORE CREATING A NEW REVISION
            da = New SqlClient.SqlDataAdapter("Select * from vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And (RIGHT(vwDrawingsRev.AIM, 18) != 'Record Was Marked Obsolete' and Status != 'Canceled' Or vwDrawingsRev.AIM Is Null) and Status != 'Deleted' Order By Seq Desc", SqlConnection1)
            da.Fill(ds, "CheckIfAllRevisionsAreStatusSix")
            If ds.Tables("CheckIfAllRevisionsAreStatusSix").Rows.Count > 0 Then
                Dim x As Integer = 0
                Dim checkStatus As String
                While x <= ds.Tables("CheckIfAllRevisionsAreStatusSix").Rows.Count - 1
                    If ds.Tables("CheckIfAllRevisionsAreStatusSix").Rows(x).Item("Status") <> "GATE 6: Complete" And ds.Tables("CheckIfAllRevisionsAreStatusSix").Rows(x).Item("Status") <> "Canceled" Then
                        If AddRevFromRedline = "Yes" Then
                            'Nothing
                        Else
                            MsgBox("All revisions must be at gate 6 before adding a new revision")
                            ds.Tables("CheckIfAllRevisionsAreStatusSix").Clear()
                            ds.Tables("CheckIfAllRevisionsAreStatusSix").Dispose()
                            x = 0
                            checkStatus = ""
                            CreateRev = "No"
                            Exit Sub
                        End If

                    End If
                    x = x + 1
                End While
                x = 0
                checkStatus = ""
            End If

            ds.Tables("CheckIfAllRevisionsAreStatusSix").Clear()
            ds.Tables("CheckIfAllRevisionsAreStatusSix").Dispose()


            'COMMENTED THE BLOCK OF CODE BELOW(18 LINES) ON 02/14/2022 BECAUSE IT WAS BEING FIRED FOR NO REASON
            ''VALIDATION: THIS BLOCK OF CODE COULD BE COMMENTED OUT BECAUSE OF THE BLOCK OF CODE ABOVE.  FOR NOW I LEAVE IT AS IT IS, AS ORIGINALLY WAS
            'da = New SqlClient.SqlDataAdapter("Select Top 1 * from vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And (RIGHT(vwDrawingsRev.AIM, 18) != 'Record Was Marked Obsolete' and Status != 'Canceled' Or vwDrawingsRev.AIM Is Null) Order By Seq Desc", SqlConnection1)
            'da.Fill(ds, "CheckIfStatusSix")
            'If ds.Tables("CheckIfStatusSix").Rows.Count > 0 Then
            '    If ds.Tables("CheckIfStatusSix").Rows(0).Item("Status") <> "GATE 6: Complete" And ds.Tables("CheckIfStatusSix").Rows(0).Item("Status") <> "Canceled" Then
            '        MsgBox("Latest Revision must be at gate 6 to add a new revision or DRN.  Please advance the latest revision first.  New revision creation has been cancelled.")
            '        ds.Tables("CheckIfStatusSix").Clear()
            '        ds.Tables("CheckIfStatusSix").Dispose()
            '        Exit Sub
            '        'End If
            '    Else
            '        ds.Tables("CheckIfStatusSix").Clear()
            '        ds.Tables("CheckIfStatusSix").Dispose()
            '    End If
            'Else

            '    ds.Tables("CheckIfStatusSix").Clear()
            '    ds.Tables("CheckIfStatusSix").Dispose()
            'End If



            'CHECK IF REVISION IS A REPORT OR A DRAWING. DRNs and ADCNs CANNOT BE CREATED IF DOCUMENT TYPE IS A REPORT. ALSO WHEN LOCATION IS TORONTO NO ADCN; WHEN LOCATION IS OKC NO DRN
            AllowDrnAdcn()
            'Dim test As String = txtMainInfoRecordID.Text & " " & txtMainDrawingNumber.Text & " " & DrnAllowed & " " & AdcnAllowed & " " & LocationForDrnAdcn


            Dim RevLastRevision As String = ""
            da = New SqlClient.SqlDataAdapter("Select * From vwDrawingsRev Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq Desc, RecordID Desc", SqlConnection1)
            da.Fill(ds, "RevLastRevision")
            If ds.Tables("RevLastRevision").Rows.Count > 0 Then
                RevLastRevision = ds.Tables("RevLastRevision").Rows(0).Item("DwgRevision")
                ds.Tables("RevLastRevision").Clear()
                ds.Tables("RevLastRevision").Dispose()
            End If


            Dim frmEngWorkflowRevPurpose As New frmEngWorkflowRevPurpose
            frmEngWorkflowRevPurpose.ShowDialog()


            'If the user clicks the X button then do nothing
            If CloseRevPurposeForm <> "No" Then
                CloseRevPurposeForm = ""
                CreateRev = "No"
                Exit Sub
            End If
            CloseRevPurposeForm = ""


            'If AddRevFromRedline <> "Yes" Then         'Commented after including entering for the EARR response also DRN and ADCN
            Dim frmEngWorkflowRevorDRN As New frmEngWorkflowRevorDRN
            frmEngWorkflowRevorDRN.ShowDialog()
            'End If


            If AddRevFromEARR = "Yes" Then
                'InitialDrawNumFDT = txtMainDrawingNumber.Text
                txtMainDrawingNumber.Text = DrawNumFromEARR
            End If



            If RevOrDRN = "CANCEL" Then
                CreateRev = "No"
                Exit Sub

            ElseIf RevOrDRN = "DRN" Then

                da = New SqlClient.SqlDataAdapter("Select Top 1 * from vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And (RIGHT(vwDrawingsRev.AIM, 18) != 'Record Was Marked Obsolete' and Status != 'Canceled' Or vwDrawingsRev.AIM Is Null and Status != 'Canceled') Order By Seq Desc", SqlConnection1)
                da.Fill(ds, "TOP")

                If ds.Tables("TOP").Rows(0).Item("Status") <> "GATE 6: Complete" And ds.Tables("TOP").Rows(0).Item("Status") <> "Canceled" Then
                    MsgBox("Latest Revision must be at gate 6 to add a new revision or DRN.  Please advance the latest revision first.  New revision creation has been cancelled.")
                    ds.Tables("TOP").Clear()
                    ds.Tables("TOP").Dispose()
                    CreateRev = "No"
                    Exit Sub

                Else


                    'Get latest DRN for the drawing number selected on the main page
                    Dim latestDRN As String = ""
                    da = New SqlClient.SqlDataAdapter("Select Top 1 DRNADCN from vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And DRNADCN != '' And DRNADCN Is Not NULL And (RIGHT(vwDrawingsRev.AIM, 18) != 'Record Was Marked Obsolete' and Status != 'Canceled' Or vwDrawingsRev.AIM Is Null) Order By RecordID Desc", SqlConnection1)
                    da.Fill(ds, "LatestDrn")
                    If ds.Tables("LatestDrn").Rows.Count > 0 Then
                        latestDRN = ds.Tables("LatestDrn").Rows(0).Item("DRNADCN")
                        ds.Tables("LatestDrn").Clear()
                        ds.Tables("LatestDrn").Dispose()
                    Else
                        ds.Tables("LatestDrn").Clear()
                        ds.Tables("LatestDrn").Dispose()
                        latestDRN = ""
                    End If

                    'Get next available DRN number
                    Dim seqOfLatestDrnPlusOne As Integer
                    If latestDRN = "" Then
                        DRN = "DRN/1"
                    Else
                        da = New SqlClient.SqlDataAdapter("Select Seq from tblDRNADCN Where Active = 'True' And Name = '" & latestDRN & "' Order By Seq Asc", SqlConnection1)
                        da.Fill(ds, "DRNADCN")
                        seqOfLatestDrnPlusOne = ds.Tables("DRNADCN").Rows(0).Item("Seq") + 1
                        ds.Tables("DRNADCN").Clear()
                        ds.Tables("DRNADCN").Dispose()

                        'Get DRN name to assign to next DRN in the SQL insert below
                        da = New SqlClient.SqlDataAdapter("Select Name from tblDRNADCN Where Active = 'True' And Seq = '" & seqOfLatestDrnPlusOne & "' Order By Seq Asc", SqlConnection1)
                        da.Fill(ds, "DRNName")
                        DRN = ds.Tables("DRNName").Rows(0).Item("Name")
                        ds.Tables("DRNName").Clear()
                        ds.Tables("DRNName").Dispose()
                    End If


                    'Set value to use in the response of the drawing number of an EARR
                    RevEARR = DRN


                    'Get next revision
                    Dim NewRework As String
                    If ds.Tables("TOP").Rows(0).Item("NewRework") = "New Drawing" Then
                        NewRework = "Rework Drawing"
                    ElseIf ds.Tables("TOP").Rows(0).Item("NewRework") = "New Report" Then
                        NewRework = "Rework Report"
                    ElseIf ds.Tables("TOP").Rows(0).Item("NewRework") = "Rework Report" Then
                        NewRework = "Rework Report"
                    ElseIf ds.Tables("TOP").Rows(0).Item("NewRework") = "Rework Drawing" Then
                        NewRework = "Rework Drawing"
                    End If


                    'Insert new revision into tblDrawings
                    'u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawings (DrawingNumber, DrawingTitle, Program, SystemDescription, Location, Type, NextHigherAssembly, InstallationDrawing, Priority, DwgRevision) Values ('" & ds.Tables("TOP").Rows(0).Item("DrawingNumber") & "', '" & ds.Tables("TOP").Rows(0).Item("DrawingTitle") & "', '" & ds.Tables("TOP").Rows(0).Item("Program") & "','" & ds.Tables("TOP").Rows(0).Item("SystemDescription") & "','" & ds.Tables("TOP").Rows(0).Item("Location") & "','" & ds.Tables("TOP").Rows(0).Item("Type") & "','" & ds.Tables("TOP").Rows(0).Item("NextHigherAssembly") & "', '" & ds.Tables("TOP").Rows(0).Item("InstallationDrawing") & "', '" & ds.Tables("TOP").Rows(0).Item("Priority") & "', '" & rev & "')")
                    'u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, Program, SystemDescription, DwgRevision, Type, DocumentType, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter,DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, Updated, UpdatedDate, ADCN, DRNADCNStatus, ForecastStartDate, DrafterSignedOffBy, SrEngineerSignedOffBy, StressSignedOffBy, EngineerSignedOffBy, ReleaserSignedOffBy, CMSignedOffBy) Values ('" & ds.Tables("TOP").Rows(0).Item("DrawingNumber") & "', '" & u.FTM(ds.Tables("TOP").Rows(0).Item("DrawingTitle")) & "', '" & ds.Tables("TOP").Rows(0).Item("NextHigherAssembly") & "', '" & ds.Tables("TOP").Rows(0).Item("Program") & "', '" & ds.Tables("TOP").Rows(0).Item("SystemDescription") & "', '" & ds.Tables("TOP").Rows(0).Item("DwgRevision") & "', '" & ds.Tables("TOP").Rows(0).Item("Type") & "', '" & ds.Tables("TOP").Rows(0).Item("DocumentType") & "', '" & ds.Tables("TOP").Rows(0).Item("Priority") & "', '" & ds.Tables("TOP").Rows(0).Item("Location") & "', '" & System.Environment.UserName & "', '" & Now & "', '', 'GATE 0: CM Needs To Assign DWG Number', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '', '', '" & username & "', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','" & ds.Tables("TOP").Rows(0).Item("InstallationDrawing") & "','', '" & DRN & "','','','" & Now & "', '" & NewRework & "', 0, '" & Now & "', '', 'Not Incorporated', '" & Now & "', '','','','','','')")
                    u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, ProgramReal, Program, SystemDescription, DwgRevision, Type, DocumentType, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter,DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, Updated, UpdatedDate, ADCN, DRNADCNStatus, ForecastStartDate, DrafterSignedOffBy, SrEngineerSignedOffBy, StressSignedOffBy, EngineerSignedOffBy, ReleaserSignedOffBy, CMSignedOffBy, IsDocNumConfirmed, RevPurpose) Values ('" & ds.Tables("TOP").Rows(0).Item("DrawingNumber") & "', '" & u.FTM(ds.Tables("TOP").Rows(0).Item("DrawingTitle")) & "', '" & ds.Tables("TOP").Rows(0).Item("NextHigherAssembly") & "', '" & ds.Tables("TOP").Rows(0).Item("ProgramReal") & "', '" & ds.Tables("TOP").Rows(0).Item("Program") & "', '" & ds.Tables("TOP").Rows(0).Item("SystemDescription") & "', '" & ds.Tables("TOP").Rows(0).Item("DwgRevision") & "', '" & ds.Tables("TOP").Rows(0).Item("Type") & "', '" & ds.Tables("TOP").Rows(0).Item("DocumentType") & "', '" & ds.Tables("TOP").Rows(0).Item("Priority") & "', '" & ds.Tables("TOP").Rows(0).Item("Location") & "', '" & System.Environment.UserName & "', '" & Now & "', '', 'GATE 0: CM Needs To Assign DWG Number', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '', '', '" & username & "', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','" & ds.Tables("TOP").Rows(0).Item("InstallationDrawing") & "','', '" & DRN & "','','','" & Now & "', '" & NewRework & "', 0, '" & Now & "', '', 'Not Incorporated', '" & Now & "', '','','','','','', 1, '" & RevPurpose & "')")


                    UpdateAssembly()
                    UpdateProjectField()
                    UpdateSystemField()
                    UpdateProgramField()


                    'Grab the recordid we just added.
                    da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID from tblDrawings Order By RecordID Desc", SqlConnection1)
                    da.Fill(ds, "Top11")

                    RevAdd = Val(ds.Tables("TOP11").Rows(0).Item("RecordID"))



                    'Insert into certification tables.

                    'tblDrawingCertUMApproval
                    da = New SqlClient.SqlDataAdapter("Select * from tblDrawingCertUMApproval Where DwgRecordID = '" & Val(ds.Tables("TOP").Rows(0).Item("RecordID")) & "'", SqlConnection1)
                    da.Fill(ds, "DrawingCertUMApproval")

                    'Loop through and insert...

                    Dim x As Integer = 0

                    While x <= ds.Tables("DrawingCertUMApproval").Rows.Count - 1

                        u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawingCertUMApproval (DwgRecordID, UMName, UMSpecialty, UMRecommendApproval, UMApproval, RequiredToApprove, Comments) Values ('" & Val(RevAdd) & "', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("UMName") & "', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("UMSpecialty") & "', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("UMRecommendApproval") & "','Not Submitted', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("RequiredToApprove") & "', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("Comments") & "')")
                        x = x + 1
                    End While
                    x = 0

                    'tblDrawingCertFAAOMTApproval

                    da = New SqlClient.SqlDataAdapter("Select * from tblDrawingCertFAAOMTApproval Where DwgRecordID = '" & Val(ds.Tables("TOP").Rows(0).Item("RecordID")) & "'", SqlConnection1)
                    da.Fill(ds, "DrawingCertFAAOMTApproval")

                    'Loop through and insert
                    Dim p As Integer = 0

                    While p <= ds.Tables("DrawingCertFAAOMTApproval").Rows.Count - 1


                        u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingCertFAAOMTApproval (DwgRecordID, FAAOMTName, FAAOMTSpecialty, FAAOMTRecommendApproval, FAAOMTApproval, RequiredToApprove, Comments) Values ('" & Val(RevAdd) & "', '" & ds.Tables("DrawingCertFAAOMTApproval").Rows(p).Item("FAAOMTName") & "',  '" & ds.Tables("DrawingCertFAAOMTApproval").Rows(p).Item("FAAOMTSpecialty") & "',  'False',  '', 'False', '')")

                        p = p + 1

                    End While

                    'tblDrawingCert


                    'da = New SqlClient.SqlDataAdapter("Select * from tblDrawingCert Where DwgRecordID = '" & Val(ds.Tables("TOP").Rows(0).Item("RecordID")) & "'", SqlConnection1)
                    'da.Fill(ds, "DrawingCert")

                    'Dim v As Integer = 0

                    'While v <= ds.Tables("DrawingCert").Rows.Count - 1

                    u.ExecuteSQL(SqlConnection1, "INSERT into tblDrawingCert (DwgRecordID, Status, Comments) Values ('" & Val(RevAdd) & "', 'Not Approved', '')")

                    '    v = v + 1
                    'End While

                    ds.Tables("DrawingCertUMApproval").Clear()
                    ds.Tables("DrawingCertUMApproval").Dispose()

                    ds.Tables("DrawingCertFAAOMTApproval").Clear()
                    ds.Tables("DrawingCertFAAOMTApproval").Dispose()

                    'Reload with record we just added (recordID we saved above)
                    Search()
                End If
                ds.Tables("TOP").Clear()
                ds.Tables("TOP").Dispose()


                ''Send notification to Lead Engineer and Planner now that a new revision is being created
                'DrawingNumForEmails = txtMainDrawingNumber.Text
                'RevisionForEmails = cboMainRev.Text
                'frmEngWorkflowSignOff.SendNotifications(0)


            ElseIf RevOrDRN = "ADCN" Then

                da = New SqlClient.SqlDataAdapter("Select Top 1 * from vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And (RIGHT(vwDrawingsRev.AIM, 18) != 'Record Was Marked Obsolete' Or vwDrawingsRev.AIM Is Null) Order By Seq Desc", SqlConnection1)
                da.Fill(ds, "TOP")

                If ds.Tables("TOP").Rows(0).Item("Status") <> "GATE 6: Complete" And ds.Tables("TOP").Rows(0).Item("Status") <> "Canceled" Then
                    MsgBox("Latest Revision must be at gate 6 to add a new revision or DRN.  Please advance the latest revision first.  New revision creation has been canceled.")
                    ds.Tables("TOP").Clear()
                    ds.Tables("TOP").Dispose()
                    CreateRev = "No"
                    Exit Sub

                Else

                    'Insert new drawing into tblDrawings
                    'u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawings (DrawingNumber, DrawingTitle, Program, SystemDescription, Location, Type, NextHigherAssembly, InstallationDrawing, Priority, DwgRevision) Values ('" & ds.Tables("TOP").Rows(0).Item("DrawingNumber") & "', '" & ds.Tables("TOP").Rows(0).Item("DrawingTitle") & "', '" & ds.Tables("TOP").Rows(0).Item("Program") & "','" & ds.Tables("TOP").Rows(0).Item("SystemDescription") & "','" & ds.Tables("TOP").Rows(0).Item("Location") & "','" & ds.Tables("TOP").Rows(0).Item("Type") & "','" & ds.Tables("TOP").Rows(0).Item("NextHigherAssembly") & "', '" & ds.Tables("TOP").Rows(0).Item("InstallationDrawing") & "', '" & ds.Tables("TOP").Rows(0).Item("Priority") & "', '" & rev & "')")
                    Dim NewRework As String
                    If ds.Tables("TOP").Rows(0).Item("NewRework") = "New Drawing" Then
                        NewRework = "Rework Drawing"
                    ElseIf ds.Tables("TOP").Rows(0).Item("NewRework") = "New Report" Then
                        NewRework = "Rework Report"
                    ElseIf ds.Tables("TOP").Rows(0).Item("NewRework") = "Rework Report" Then
                        NewRework = "Rework Report"
                    ElseIf ds.Tables("TOP").Rows(0).Item("NewRework") = "Rework Drawing" Then
                        NewRework = "Rework Drawing"
                    End If


                    'Set value to use in the response of the drawing number of an EARR
                    RevEARR = ADCN


                    'u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, Program, SystemDescription, DwgRevision, Type, DocumentType, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter,DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, Updated, UpdatedDate, ADCN, DRNADCNStatus, ForecastStartDate, AIM, DrafterSignedOffBy, SrEngineerSignedOffBy, StressSignedOffBy, EngineerSignedOffBy, ReleaserSignedOffBy, CMSignedOffBy) Values ('" & ds.Tables("TOP").Rows(0).Item("DrawingNumber") & "', '" & u.FTM(ds.Tables("TOP").Rows(0).Item("DrawingTitle")) & "', '" & ds.Tables("TOP").Rows(0).Item("NextHigherAssembly") & "', '" & ds.Tables("TOP").Rows(0).Item("Program") & "', '" & ds.Tables("TOP").Rows(0).Item("SystemDescription") & "', '" & ds.Tables("TOP").Rows(0).Item("DwgRevision") & "', '" & ds.Tables("TOP").Rows(0).Item("Type") & "', '" & ds.Tables("TOP").Rows(0).Item("DocumentType") & "', '" & ds.Tables("TOP").Rows(0).Item("Priority") & "', '" & ds.Tables("TOP").Rows(0).Item("Location") & "', '" & System.Environment.UserName & "', '" & Now & "', '', 'GATE 0: CM Needs To Assign DWG Number', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '', '', '" & username & "', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','" & ds.Tables("TOP").Rows(0).Item("InstallationDrawing") & "','', '','','','" & Now & "', '" & NewRework & "', 0, '" & Now & "', '" & ADCN & "', 'Not Incorporated', '" & Now & "', '" & ADCN & "', '','','','','','')")
                    u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, ProgramReal, Program, SystemDescription, DwgRevision, Type, DocumentType, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter,DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, Updated, UpdatedDate, ADCN, DRNADCNStatus, ForecastStartDate, AIM, DrafterSignedOffBy, SrEngineerSignedOffBy, StressSignedOffBy, EngineerSignedOffBy, ReleaserSignedOffBy, CMSignedOffBy, IsDocNumConfirmed, RevPurpose) Values ('" & ds.Tables("TOP").Rows(0).Item("DrawingNumber") & "', '" & u.FTM(ds.Tables("TOP").Rows(0).Item("DrawingTitle")) & "', '" & ds.Tables("TOP").Rows(0).Item("NextHigherAssembly") & "', '" & ds.Tables("TOP").Rows(0).Item("ProgramReal") & "', '" & ds.Tables("TOP").Rows(0).Item("Program") & "', '" & ds.Tables("TOP").Rows(0).Item("SystemDescription") & "', '" & ds.Tables("TOP").Rows(0).Item("DwgRevision") & "', '" & ds.Tables("TOP").Rows(0).Item("Type") & "', '" & ds.Tables("TOP").Rows(0).Item("DocumentType") & "', '" & ds.Tables("TOP").Rows(0).Item("Priority") & "', '" & ds.Tables("TOP").Rows(0).Item("Location") & "', '" & System.Environment.UserName & "', '" & Now & "', '', 'GATE 0: CM Needs To Assign DWG Number', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '', '', '" & username & "', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','" & ds.Tables("TOP").Rows(0).Item("InstallationDrawing") & "','', '','','','" & Now & "', '" & NewRework & "', 0, '" & Now & "', '" & ADCN & "', 'Not Incorporated', '" & Now & "', '" & ADCN & "', '','','','','','', 1, '" & RevPurpose & "')")


                    UpdateAssembly()
                    UpdateProjectField()
                    UpdateSystemField()
                    UpdateProgramField()


                    'Grab the recordid we just added.
                    da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID from tblDrawings Order By RecordID Desc", SqlConnection1)
                    da.Fill(ds, "Top11")

                    RevAdd = Val(ds.Tables("TOP11").Rows(0).Item("RecordID"))

                    'Insert into certification tables.

                    'tblDrawingCertUMApproval
                    da = New SqlClient.SqlDataAdapter("Select * from tblDrawingCertUMApproval Where DwgRecordID = '" & Val(ds.Tables("TOP").Rows(0).Item("RecordID")) & "'", SqlConnection1)
                    da.Fill(ds, "DrawingCertUMApproval")

                    'Loop through and insert...

                    Dim x As Integer = 0

                    While x <= ds.Tables("DrawingCertUMApproval").Rows.Count - 1

                        u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawingCertUMApproval (DwgRecordID, UMName, UMSpecialty, UMRecommendApproval, UMApproval, RequiredToApprove, Comments) Values ('" & Val(RevAdd) & "', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("UMName") & "', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("UMSpecialty") & "', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("UMRecommendApproval") & "','Not Submitted', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("RequiredToApprove") & "', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("Comments") & "')")
                        x = x + 1
                    End While
                    x = 0

                    'tblDrawingCertFAAOMTApproval

                    da = New SqlClient.SqlDataAdapter("Select * from tblDrawingCertFAAOMTApproval Where DwgRecordID = '" & Val(ds.Tables("TOP").Rows(0).Item("RecordID")) & "'", SqlConnection1)
                    da.Fill(ds, "DrawingCertFAAOMTApproval")

                    'Loop through and insert
                    Dim p As Integer = 0

                    While p <= ds.Tables("DrawingCertFAAOMTApproval").Rows.Count - 1


                        u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingCertFAAOMTApproval (DwgRecordID, FAAOMTName, FAAOMTSpecialty, FAAOMTRecommendApproval, FAAOMTApproval, RequiredToApprove, Comments) Values ('" & Val(RevAdd) & "', '" & ds.Tables("DrawingCertFAAOMTApproval").Rows(p).Item("FAAOMTName") & "',  '" & ds.Tables("DrawingCertFAAOMTApproval").Rows(p).Item("FAAOMTSpecialty") & "',  'False',  '', 'False', '')")

                        p = p + 1

                    End While

                    'tblDrawingCert


                    'da = New SqlClient.SqlDataAdapter("Select * from tblDrawingCert Where DwgRecordID = '" & Val(ds.Tables("TOP").Rows(0).Item("RecordID")) & "'", SqlConnection1)
                    'da.Fill(ds, "DrawingCert")

                    'Dim v As Integer = 0

                    'While v <= ds.Tables("DrawingCert").Rows.Count - 1

                    u.ExecuteSQL(SqlConnection1, "INSERT into tblDrawingCert (DwgRecordID, Status, Comments) Values ('" & Val(RevAdd) & "', 'Not Approved', '')")

                    '    v = v + 1
                    'End While

                    ds.Tables("DrawingCertUMApproval").Clear()
                    ds.Tables("DrawingCertUMApproval").Dispose()

                    ds.Tables("DrawingCertFAAOMTApproval").Clear()
                    ds.Tables("DrawingCertFAAOMTApproval").Dispose()

                    'Reload with record we just added (recordID we saved above)
                    Search()
                End If
                ds.Tables("TOP").Clear()
                ds.Tables("TOP").Dispose()


                ''Send notification to Lead Engineer and Planner now that a new revision is being created
                'DrawingNumForEmails = txtMainDrawingNumber.Text
                'RevisionForEmails = cboMainRev.Text
                'frmEngWorkflowSignOff.SendNotifications(0)


            ElseIf RevOrDRN = "REV" Then

                da = New SqlClient.SqlDataAdapter("Select Top 1 * from vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And (RIGHT(vwDrawingsRev.AIM, 18) != 'Record Was Marked Obsolete' Or vwDrawingsRev.AIM Is Null) Order By Seq Desc", SqlConnection1)  'And Status != 'Canceled' And Status != 'Obsolete'   TAKEN OFF ON 09/19/22
                da.Fill(ds, "TOP")

                If ds.Tables("TOP").Rows(0).Item("Status") <> "GATE 6: Complete" And ds.Tables("TOP").Rows(0).Item("Status") <> "Canceled" Then
                    MsgBox("Latest Revision must be at gate 6 to add a new revision or DRN.  Please advance the latest revision first.  New revision creation has been cancelled.")
                    MsgBox(ds.Tables("TOP").Rows(0).Item("DrawingNumber") & " Dwg Field: " & Me.txtMainDrawingNumber.Text & " Seq: " & ds.Tables("TOP").Rows(0).Item("seq") & " DwgRev: " & ds.Tables("TOP").Rows(0).Item("dwgRevision") & " Status: " & ds.Tables("TOP").Rows(0).Item("Status"))
                    ds.Tables("TOP").Clear()
                    ds.Tables("TOP").Dispose()
                    CreateRev = "No"
                    Exit Sub

                Else

                    'Get AIM number to assign to DCN or ADCN
                    GetAIMNumber()

                    'Get next revision
                    Dim seqrev As Integer
                    Dim revOfSeq As String = ""

                    seqrev = Val(ds.Tables("TOP").Rows(0).Item("Seq"))
                    revOfSeq = ds.Tables("TOP").Rows(0).Item("DwgRevision")


                    If ds.Tables("TOP").Rows(0).Item("Status") = "Canceled" Then
                        'Nothing
                    Else

                        If revOfSeq = "NC" Then
                            seqrev = seqrev + 3
                        ElseIf revOfSeq = "-" Then
                            seqrev = seqrev + 2

                            'Exclude Rev I, O, P, Q, S, X and Z - per Owen 5/18/22 email
                        ElseIf revOfSeq = "H" Then
                            seqrev = seqrev + 2
                        ElseIf revOfSeq = "N" Then
                            seqrev = seqrev + 4
                        ElseIf revOfSeq = "O" Then
                            seqrev = seqrev + 3
                        ElseIf revOfSeq = "P" Then
                            seqrev = seqrev + 2
                        ElseIf revOfSeq = "R" Then
                            seqrev = seqrev + 2
                        ElseIf revOfSeq = "W" Then
                            seqrev = seqrev + 2
                        ElseIf revOfSeq = "Y" Then
                            seqrev = seqrev + 2

                        Else
                            seqrev = seqrev + 1
                        End If
                    End If

                    revOfSeq = "A"
                    'Get new revision value
                    da = New SqlClient.SqlDataAdapter("Select DwgRevision from tblDwgRevisions where seq = '" & Val(seqrev) & "'", SqlConnection1)
                    da.Fill(ds, "REVREV")

                    Dim rev As String
                    rev = ds.Tables("REVREV").Rows(0).Item("DwgRevision")
                    RevEARR = rev
                    rev = "A"
                    Dim NewRework As String
                    If ds.Tables("TOP").Rows(0).Item("NewRework") = "New Drawing" Then
                        NewRework = "Rework Drawing"
                    ElseIf ds.Tables("TOP").Rows(0).Item("NewRework") = "New Report" Then
                        NewRework = "Rework Report"
                    ElseIf ds.Tables("TOP").Rows(0).Item("NewRework") = "Rework Report" Then
                        NewRework = "Rework Report"
                    ElseIf ds.Tables("TOP").Rows(0).Item("NewRework") = "Rework Drawing" Then
                        NewRework = "Rework Drawing"
                    End If

                    '-----Insert new revision into tblDrawings
                    'If document type is a report set Operations field equal to N/A
                    If documentType = "Report" Then
                        u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, ProgramReal, Program, SystemDescription, DwgRevision, Type, DocumentType, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter,DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, Updated, UpdatedDate, ADCN, ForecastStartDate, DCN, AIM, DrafterSignedOffBy, SrEngineerSignedOffBy, StressSignedOffBy, EngineerSignedOffBy, ReleaserSignedOffBy, CMSignedOffBy, IsDocNumConfirmed, RevPurpose) Values ('" & ds.Tables("TOP").Rows(0).Item("DrawingNumber") & "', '" & u.FTM(ds.Tables("TOP").Rows(0).Item("DrawingTitle")) & "', '" & ds.Tables("TOP").Rows(0).Item("NextHigherAssembly") & "', '" & ds.Tables("TOP").Rows(0).Item("ProgramReal") & "', '" & ds.Tables("TOP").Rows(0).Item("Program") & "', '" & ds.Tables("TOP").Rows(0).Item("SystemDescription") & "', '" & rev & "', '" & ds.Tables("TOP").Rows(0).Item("Type") & "', '" & ds.Tables("TOP").Rows(0).Item("DocumentType") & "', '" & ds.Tables("TOP").Rows(0).Item("Priority") & "', '" & ds.Tables("TOP").Rows(0).Item("Location") & "', '" & System.Environment.UserName & "', '" & Now & "', '', 'GATE 0: CM Needs To Assign DWG Number', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '" & RevNotes & "', '', '" & username & "', '01/01/1900', 'N/A', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','" & ds.Tables("TOP").Rows(0).Item("InstallationDrawing") & "','','','','','" & Now & "',  '" & NewRework & "', 0, '" & Now & "', '', '" & Now & "', '" & AIMNumber & "', '" & AIMNumber & "', '','','','','','', 1, '" & RevPurpose & "')")
                    Else
                        'u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawings (DrawingNumber, DrawingTitle, Program, SystemDescription, Location, Type, NextHigherAssembly, InstallationDrawing, Priority, DwgRevision) Values ('" & ds.Tables("TOP").Rows(0).Item("DrawingNumber") & "', '" & ds.Tables("TOP").Rows(0).Item("DrawingTitle") & "', '" & ds.Tables("TOP").Rows(0).Item("Program") & "','" & ds.Tables("TOP").Rows(0).Item("SystemDescription") & "','" & ds.Tables("TOP").Rows(0).Item("Location") & "','" & ds.Tables("TOP").Rows(0).Item("Type") & "','" & ds.Tables("TOP").Rows(0).Item("NextHigherAssembly") & "', '" & ds.Tables("TOP").Rows(0).Item("InstallationDrawing") & "', '" & ds.Tables("TOP").Rows(0).Item("Priority") & "', '" & rev & "')")
                        u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, ProgramReal, Program, SystemDescription, DwgRevision, Type, DocumentType, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter,DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, Updated, UpdatedDate, ADCN, ForecastStartDate, DCN, AIM, DrafterSignedOffBy, SrEngineerSignedOffBy, StressSignedOffBy, EngineerSignedOffBy, ReleaserSignedOffBy, CMSignedOffBy, IsDocNumConfirmed, RevPurpose) Values ('" & ds.Tables("TOP").Rows(0).Item("DrawingNumber") & "', '" & u.FTM(ds.Tables("TOP").Rows(0).Item("DrawingTitle")) & "', '" & ds.Tables("TOP").Rows(0).Item("NextHigherAssembly") & "', '" & ds.Tables("TOP").Rows(0).Item("ProgramReal") & "', '" & ds.Tables("TOP").Rows(0).Item("Program") & "', '" & ds.Tables("TOP").Rows(0).Item("SystemDescription") & "', '" & rev & "', '" & ds.Tables("TOP").Rows(0).Item("Type") & "', '" & ds.Tables("TOP").Rows(0).Item("DocumentType") & "', '" & ds.Tables("TOP").Rows(0).Item("Priority") & "', '" & ds.Tables("TOP").Rows(0).Item("Location") & "', '" & System.Environment.UserName & "', '" & Now & "', '', 'GATE 0: CM Needs To Assign DWG Number', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '" & RevNotes & "', '', '" & username & "', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','" & ds.Tables("TOP").Rows(0).Item("InstallationDrawing") & "','','','','','" & Now & "',  '" & NewRework & "', 0, '" & Now & "', '', '" & Now & "', '" & AIMNumber & "', '" & AIMNumber & "','','','','','','', 1, '" & RevPurpose & "')")
                    End If


                    UpdateAssembly()
                    UpdateProjectField()
                    UpdateSystemField()
                    UpdateProgramField()


                    'Grab the recordid we just added.
                    da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID from tblDrawings Order By RecordID Desc", SqlConnection1)
                    da.Fill(ds, "Top11")

                    RevAdd = Val(ds.Tables("TOP11").Rows(0).Item("RecordID"))


                    '---------------------------------------------------------------------------------------------------------------------------------------------------------
                    'UPDATE tblTree.  Make the revision the latest one(since it is the latest one that is selected in the Tree)

                    Dim StatusForRev As String = ""
                    Dim RevForRev As String = ""
                    Dim SeqForRev As String = ""

                    da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq Desc, RecordID Desc", SqlConnection1)
                    da.Fill(ds, "DataRecordJustAdded")
                    If ds.Tables("DataRecordJustAdded").Rows.Count > 0 Then

                        RevForRev = ds.Tables("DataRecordJustAdded").Rows(0).Item("DwgRevision")
                        SeqForRev = ds.Tables("DataRecordJustAdded").Rows(0).Item("Seq")
                        StatusForRev = ds.Tables("DataRecordJustAdded").Rows(0).Item("Status")

                        u.ExecuteSQL(SqlConnection1, "Update tblTree Set Status = '" & StatusForRev & "', DwgRevision = '" & RevForRev & "', Seq = '" & SeqForRev & "' Where DrawingNumOriginal = '" & Me.txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'")

                        ds.Tables("DataRecordJustAdded").Clear()
                        ds.Tables("DataRecordJustAdded").Dispose()
                    End If
                    '---------------------------------------------------------------------------------------------------------------------------------------------------------



                    'Insert into certification tables.

                    'tblDrawingCertUMApproval
                    da = New SqlClient.SqlDataAdapter("Select * from tblDrawingCertUMApproval Where DwgRecordID = '" & Val(ds.Tables("TOP").Rows(0).Item("RecordID")) & "'", SqlConnection1)
                    da.Fill(ds, "DrawingCertUMApproval")

                    'Loop through and insert...

                    Dim x As Integer = 0

                    While x <= ds.Tables("DrawingCertUMApproval").Rows.Count - 1

                        u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawingCertUMApproval (DwgRecordID, UMName, UMSpecialty, UMRecommendApproval, UMApproval, RequiredToApprove, Comments) Values ('" & Val(RevAdd) & "', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("UMName") & "', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("UMSpecialty") & "', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("UMRecommendApproval") & "','Not Submitted', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("RequiredToApprove") & "', '" & ds.Tables("DrawingCertUMApproval").Rows(x).Item("Comments") & "')")
                        x = x + 1
                    End While
                    x = 0

                    'tblDrawingCertFAAOMTApproval

                    da = New SqlClient.SqlDataAdapter("Select * from tblDrawingCertFAAOMTApproval Where DwgRecordID = '" & Val(ds.Tables("TOP").Rows(0).Item("RecordID")) & "'", SqlConnection1)
                    da.Fill(ds, "DrawingCertFAAOMTApproval")

                    'Loop through and insert
                    Dim p As Integer = 0

                    While p <= ds.Tables("DrawingCertFAAOMTApproval").Rows.Count - 1


                        u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingCertFAAOMTApproval (DwgRecordID, FAAOMTName, FAAOMTSpecialty, FAAOMTRecommendApproval, FAAOMTApproval, RequiredToApprove, Comments) Values ('" & Val(RevAdd) & "', '" & ds.Tables("DrawingCertFAAOMTApproval").Rows(p).Item("FAAOMTName") & "',  '" & ds.Tables("DrawingCertFAAOMTApproval").Rows(p).Item("FAAOMTSpecialty") & "',  'False',  '', 'False', '')")

                        p = p + 1

                    End While

                    'tblDrawingCert


                    'da = New SqlClient.SqlDataAdapter("Select * from tblDrawingCert Where DwgRecordID = '" & Val(ds.Tables("TOP").Rows(0).Item("RecordID")) & "'", SqlConnection1)
                    'da.Fill(ds, "DrawingCert")

                    'Dim v As Integer = 0

                    'While v <= ds.Tables("DrawingCert").Rows.Count - 1

                    u.ExecuteSQL(SqlConnection1, "INSERT into tblDrawingCert (DwgRecordID, Status, Comments) Values ('" & Val(RevAdd) & "', 'Not Approved', '')")

                    '    v = v + 1
                    'End While


                    If AddRevFromRedline = "Yes" Then
                        MsgBox("New Revision Created.")
                    Else
                        'Ask the User to enter the Work Order and Forecast Finish Date when a new revision is created. If yes, open up the tab to enter that (also commented above line for this)
                        If MsgBox("New Revision Created." & Environment.NewLine & "" & Environment.NewLine & "" & "Would you like to enter the Work Order and Forecast Finish date now?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            EnterWOAndDateNow = "Yes"
                        End If
                    End If

                    ds.Tables("REVREV").Clear()
                    ds.Tables("REVREV").Dispose()

                    ds.Tables("DrawingCertUMApproval").Clear()
                    ds.Tables("DrawingCertUMApproval").Dispose()

                    ds.Tables("DrawingCertFAAOMTApproval").Clear()
                    ds.Tables("DrawingCertFAAOMTApproval").Dispose()

                    'Reload with record we just added (recordID we saved above)
                    Search()
                End If
                ds.Tables("TOP").Clear()
                ds.Tables("TOP").Dispose()


                ''Send notification to Lead Engineer and Planner now that a new revision is being created
                'If AddRevFromEARR = "Yes" Then
                '    DrawingNumForEmails = DrawNumFromEARR
                '    RevisionForEmails = RevEARR
                'Else
                '    DrawingNumForEmails = txtMainDrawingNumber.Text
                '    RevisionForEmails = cboMainRev.Text
                'End If

                'frmEngWorkflowSignOff.SendNotifications(0)

                'If AddRevFromEARR = "Yes" Then
                '    txtMainDrawingNumber.Text = InitialDrawNumFDT
                'End If
            End If


            'Send notification to Lead Engineer and Planner now that a new revision or DRN or ADCN is being created
            If AddRevFromEARR = "Yes" Then
                DrawingNumForEmails = DrawNumFromEARR
                RevisionForEmails = RevEARR
            Else
                DrawingNumForEmails = txtMainDrawingNumber.Text
                RevisionForEmails = cboMainRev.Text
            End If

            frmEngWorkflowSignOff.SendNotifications(0)

        End If


        ds.Tables("TOP").Clear()
        ds.Tables("TOP").Dispose()


        EnablingRedLineAddBtn()


        'After adding a new Rev the user gets asked if it wants to enter the Work Order and Forecast Finish Date, if they choose Yes then the Schedule tab containing them will be selected
        If EnterWOAndDateNow = "Yes" Then
            TabControl2.SelectedTab = TabPage7
        End If
    End Sub

    Public Function GetAIMNumber()
        Dim AlreadyExistsIncreaseByOne As String
        AIMNumber = ""
        Dim IncreaseAIMByOne As Integer = 0
        Dim AIMIncrease As String = ""
        Dim checkIfAIMNumberExists As String
        SqlConnection1.ConnectionString = sqlString

PROCESSBEGIN:
        SqlConnection1.ConnectionString = sqlString
        'Get AIM number to assign to DCN
        da1 = New SqlClient.SqlDataAdapter("Select TOP 1 * From tblAIMNumbers Where IncreaseByOne Is Not Null order by AIM desc", SqlConnection1)    'CHANGE DATABASE USED
        da1.Fill(ds1, "AIM")


        If ds1.Tables("AIM").Rows.Count > 0 Then
            checkIfAIMNumberExists = ds1.Tables("AIM").Rows(0).Item("AIM") + 1
        Else
            checkIfAIMNumberExists = "no data"
        End If

        da1 = New SqlClient.SqlDataAdapter("Select * From tblDrawings Where DCN = '" & checkIfAIMNumberExists & "' Or ADCN = '" & checkIfAIMNumberExists & "'", SqlConnection1)
                    da1.Fill(ds1, "CheckIfAIMExists")
        If ds1.Tables("CheckIfAIMExists").Rows.Count > 0 Then
            Dim AddOneToIncreaseByOne As String = ""
            AddOneToIncreaseByOne = Val(ds1.Tables("AIM").Rows(0).Item("IncreaseByOne")) + 1
            u.ExecuteSQL(SqlConnection1, "Insert into tblAIMNumbers (IncreaseByOne) Values (" & AddOneToIncreaseByOne & ")")
            ds1.Tables("CheckIfAIMExists").Clear()
            ds1.Tables("CheckIfAIMExists").Dispose()
            ds1.Tables("AIM").Clear()
            ds1.Tables("AIM").Dispose()
            checkIfAIMNumberExists = ""
            AddOneToIncreaseByOne = ""
            GoTo PROCESSBEGIN
        Else


            'Insert a new AIM number in the SQL AIM table
            If ds1.Tables("AIM").Rows.Count > 0 Then
                AIMNumber = ds1.Tables("AIM").Rows(0).Item("AIM")   'Used in the U.ExecuteSQL that inserts a new revision(in the Add New Document Revision)
                IncreaseAIMByOne = Val(ds1.Tables("AIM").Rows(0).Item("IncreaseByOne"))
                IncreaseAIMByOne = Val(ds1.Tables("AIM").Rows(0).Item("IncreaseByOne")) + 1
                AIMIncrease = ds1.Tables("AIM").Rows(0).Item("IncreaseByOne")
                u.ExecuteSQL(SqlConnection1, "Insert into tblAIMNumbers (IncreaseByOne) Values (" & IncreaseAIMByOne & ")")
            Else
                AIMNumber = "12812"
                IncreaseAIMByOne = 0
                AIMIncrease = "0"
                u.ExecuteSQL(SqlConnection1, "Insert into tblAIMNumbers (IncreaseByOne) Values (" & IncreaseAIMByOne & ")")
            End If


            da1 = New SqlClient.SqlDataAdapter("Select TOP 1 * From tblAIMNumbers order by AIM desc", SqlConnection1)    'CHANGE DATABASE USED
            da1.Fill(ds1, "AIMChosen")
            AIMNumber = ds1.Tables("AIMChosen").Rows(0).Item("AIM")      'Used for adding a new ADCN on frmEngWorkflowRevorDRN
            AIMChosen = AIMNumber                                       'Used for adding a new ADCN on frmEngWorkflowRevorDRN

            ''Populate the Drawing Number to which the AIM belongs to
            'If AIMIncrease <> "0" Then
            '    da1 = New SqlClient.SqlDataAdapter("Select TOP 1 DrawingNumber From tblDrawings order by RecordID desc", SqlConnection1)    'CHANGE DATABASE USED
            '    da1.Fill(ds1, "DrawingNumOfRevision")
            '    Dim drawingNum As String = ds1.Tables("DrawingNumOfRevision").Rows(0).Item("DrawingNumber")
            '    u.ExecuteSQL(SqlConnection1, "UPDATE tblAIMNumbers SET DrawingNumber = '" & drawingNum & "' WHERE IncreaseByOne = " & AIMIncrease & "")

            '    ds1.Tables("DrawingNumOfRevision").Clear()
            '    ds1.Tables("DrawingNumOfRevision").Dispose()
            'Else
            '    u.ExecuteSQL(SqlConnection1, "UPDATE tblAIMNumbers SET DrawingNumber = '" & DrawingNumberBeingModified & "' WHERE IncreaseByOne = " & AIMIncrease & "")
            'End If
        End If



        AlreadyExistsIncreaseByOne = ""
        AIMIncrease = ""
        IncreaseAIMByOne = 0
        ds1.Tables("AIM").Clear()
        ds1.Tables("AIM").Dispose()
        ds1.Tables("AIMChosen").Clear()
        ds1.Tables("AIMChosen").Dispose()
        ds1.Tables("CheckIfAIMExists").Clear()
        ds1.Tables("CheckIfAIMExists").Dispose()

    End Function




    Private Sub btnBrowseNextAssemblyDrawing_Click(sender As Object, e As EventArgs) Handles btnBrowseNextAssemblyDrawing.Click
        Dim frmEngWorkflowBrowse As New frmEngWorkflowBrowse
        frmEngWorkflowBrowse.ShowDialog()

        Me.txtDetailsNextAssemblyDrawing.Text = DocBrowse
    End Sub

    Private Sub btnBrowseInstallationDrawing_Click(sender As Object, e As EventArgs) Handles btnBrowseInstallationDrawing.Click
        Dim frmEngWorkflowBrowse As New frmEngWorkflowBrowse
        frmEngWorkflowBrowse.ShowDialog()

        Me.txtDetailsInstallationDrawing.Text = DocBrowse
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        OpenSignOffForm = ""
        RowSelectedUpperGrid = GridView1.FocusedRowHandle
        RowSelectedLowerGrid = GridView2.FocusedRowHandle


        Dim EngineerName As String = cbomaininfosrengineer.Text
        Dim StressName As String = cbomaininfoStress.Text
        Dim EngineerDate As String = (dtmaininfosrengcomp.Value).ToString("d")
        Dim StressDate As String = (dtmaininfoStressComp.Value).ToString("d")


        'VARIABLE USED FOR VALIDATION 
        Dim StatusChangedTo As String = cboMainStatus.Text

        'When a user clicks the save button then do not allow to save if the gate status was not equal to gate 0 or gate 1
        If initialStatus = "GATE 2: DWG Ready For Sr Engineer" Or initialStatus = "GATE 3: DWG Ready For Operations" Or initialStatus = "GATE 4: DWG Ready For Release" Or initialStatus = "GATE 5: DWG Released" Or initialStatus = "GATE 6: Complete" Then
            If initialStatus = cboMainStatus.Text Then
                AllowSignOffOpen = "Yes"
            Else
                AllowSignOffOpen = "No"
            End If
        Else
            AllowSignOffOpen = "No"
        End If


        If MoveGates <> "T" Then

            If initialStatus <> "GATE 0: CM Needs To Assign DWG Number" Or initialStatus <> "GATE 1: DWG Ready For Drafter" Then

                'Users can only change the Status to Gate 1, all other gates are changed with the SignOff screen
                If cboMainStatus.Text <> "GATE 0: CM Needs To Assign DWG Number" And cboMainStatus.Text <> "GATE 1: DWG Ready For Drafter" And cboMainStatus.Text <> "GATE 6: Complete" Then    'Added gate 6 to this line because of the error I was getting when trying to set older DRN or ADCN to Incorporated
                    If AllowSignOffOpen = "No" Or IsNothing(AllowSignOffOpen) Or AllowSignOffOpen = "" Then
                        MsgBox("You cannot change the Status to anything else other than Gate 1. Gates are only changed via the SignOff form.")
                        OpenSignOffForm = "No"
                        btnRefresh.PerformClick()

                        'Put the focus on the rows that were selected (for upper and lower grids) before hitting the save button
                        GridView1.FocusedRowHandle = RowSelectedUpperGrid
                        GridView1.SelectRow(RowSelectedUpperGrid)
                        GridView2.FocusedRowHandle = RowSelectedLowerGrid
                        GridView2.SelectRow(RowSelectedLowerGrid)

                        AllowSignOffOpen = Nothing
                        Exit Sub
                    End If
                End If

                'Users cannot go back to other gates via the Save btn, that is done in the SignOff form only via Rescind
                If cboMainStatus.Text = "GATE 0: CM Needs To Assign DWG Number" Or cboMainStatus.Text = "GATE 1: DWG Ready For Drafter" Then
                    If initialStatus <> "GATE 0: CM Needs To Assign DWG Number" And initialStatus <> "GATE 1: DWG Ready For Drafter" Then
                        MsgBox("You cannot change the Status. Gates are only changed via the SignOff form.")
                        OpenSignOffForm = "No"
                        btnRefresh.PerformClick()

                        'Put the focus on the rows that were selected (for upper and lower grids) before hitting the save button
                        GridView1.FocusedRowHandle = RowSelectedUpperGrid
                        GridView1.SelectRow(RowSelectedUpperGrid)
                        GridView2.FocusedRowHandle = RowSelectedLowerGrid
                        GridView2.SelectRow(RowSelectedLowerGrid)

                        Exit Sub
                    End If
                End If
            End If
        End If

        '-------------------------------------------------------------------------------------------Was trying something
        'FocusedRowData = GridView5.GetFocusedDataRow
        'If FocusedRowData <> initialRowData Then

        'Else

        'End If
        '--------------------------------------------------------------------------------------------




        'NEXT LINE NOT TESTED: Making the Percent Complete combobox equal to the below so it does not show as the Dropdownlist color(which is set up to that color when setting this combobox equal to Dropdownlist when the combobox gets the focus)
        cboPercentComplete.DropDownStyle = ComboBoxStyle.DropDown


        'Cannot save/change a revision if the drawing number was marked Obsolete
        Dim checkIfStatusObsolete As String = ""
        da = New SqlClient.SqlDataAdapter("Select Status From vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' and RecordID = " & txtMainInfoRecordID.Text & " Order By Seq Desc, RecordID Desc", SqlConnection1)
        da.Fill(ds, "checkIfStatusObsolete")
        If ds.Tables("checkIfStatusObsolete").Rows.Count > 0 Then
            checkIfStatusObsolete = ds.Tables("checkIfStatusObsolete").Rows(0).Item("Status")
            If checkIfStatusObsolete = "Obsolete" Then
                MsgBox("You cannot save because the drawing number was marked Obsolete")
                btnRefresh.PerformClick()
                Exit Sub
            ElseIf checkIfStatusObsolete = "Canceled" Then
                MsgBox("You cannot save because the drawing number was marked Canceled")
                OpenSignOffForm = "No"
                cboMainStatus.Text = "Canceled"
                Exit Sub
            End If

            ds.Tables("checkIfStatusObsolete").Clear()
            ds.Tables("checkIfStatusObsolete").Dispose()
        End If



        '*************************************************************************************************************************************************************
        'VALIDATION: CANNOT SET VALUE TO INCORPORATED UNLESS DRAWING REVISION IS DRN OR ADCN AND AT GATE 6, AND ANOTHER DRAWING REVISION THAT IS NOT DRN OR ADCN IS AT GATE 0 TO 5
        If cboDRNADCNStatus.Text = "Incorporated" Then

            'If the record is at Gate 6 and Incorporated and then the Gate is brought backward do nothing and let the user move it to a lower gate
            If initialStatus = "GATE 6: Complete" And StatusChangedTo <> "GATE 6: Complete" Then      'And initialIncorporatedStatus = "  Incorporated"
                'Nothing

            Else

                '--------12/02/20  Commented out the below block of code because StatusSelectedRowForIncorporated does not seem to be used anywhere, not sure why I had this code but will keep it
                'Dim StatusSelectedRowForIncorporated As String
                'Dim selectedRows() As Integer = GridView5.GetSelectedRows()
                'For Each rowHandle As Integer In selectedRows
                '    If rowHandle >= 0 Then
                '        StatusSelectedRowForIncorporated = GridView5.GetRowCellValue(rowHandle, colStatusCol)
                '    End If
                'Next rowHandle


                'Selected DRN or ADCN can be set to Incorporated after the below block of code: if latest revision is not at gate 6 and is not DRN or ADCN. I select the record next to the selected one, that is why the ...+ 1
                Dim checkIfDRN As String
                Dim checkIfADCN As String
                da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' Order By Seq Desc, RecordID Desc", SqlConnection1)   'Order By Seq Desc
                da.Fill(ds, "DRNADCNStatus")
                If ds.Tables("DRNADCNStatus").Rows.Count > 0 Then
                    checkIfDRN = ds.Tables("DRNADCNStatus").Rows(0).Item("DRNADCN")
                    checkIfADCN = ds.Tables("DRNADCNStatus").Rows(0).Item("ADCN")
                Else
                    checkIfDRN = ""
                    checkIfADCN = ""
                End If

                Dim StatusForBelowCode As String = ""
                If ds.Tables("DRNADCNStatus").Rows.Count > 0 Then
                    StatusForBelowCode = ds.Tables("DRNADCNStatus").Rows(0).Item("Status")
                End If
                'If StatusForBelowCode = "GATE 6: Complete" Or StatusForBelowCode = "" Or checkIfDRN <> "" Or checkIfADCN <> "" Then
                If StatusForBelowCode = "GATE 6: Complete" Or checkIfDRN <> "" Or checkIfADCN <> "" Then
                    If MsgBox("Latest Revision must be at gate 0 to 5 and must not be a DRN or ADCN to set DRN/ADCN Status to Incorporated", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                        cboDRNADCNStatus.SelectedIndex = 1
                        'cboDRNADCNStatus.SelectedIndex = -1
                        ds.Tables("DRNADCNStatus").Clear()
                        ds.Tables("DRNADCNStatus").Dispose()
                    End If

                    ds.Tables("DRNADCNStatus").Clear()
                    ds.Tables("DRNADCNStatus").Dispose()
                    SearchMainInformation()
                    CloseSignedOffForm = "Yes"
                    Exit Sub

                Else
                    ds.Tables("DRNADCNStatus").Clear()
                    ds.Tables("DRNADCNStatus").Dispose()
                End If
                ds.Tables("DRNADCNStatus").Clear()
                ds.Tables("DRNADCNStatus").Dispose()
                'End If

                ds.Tables("DRNADCNStatus").Clear()
                ds.Tables("DRNADCNStatus").Dispose()


                'Check if IncorporatedBy field has been populated
                Dim checkIncorporatedByPopulated As String = cboDRNADCNIncorporatedBy.Text
                If checkIncorporatedByPopulated = "" Then
                    MsgBox("Please populate Incorporated By")
                    SearchMainInformation()
                    CloseSignedOffForm = "Yes"
                    Exit Sub
                End If


                'Populate IncorporatedRev with the next revision sequence(DocRev), it it does not already has a value
                Dim checkIncorporatedRevPopulated As String = ""
                checkIncorporatedRevPopulated = cboIncorporatedRev.Text
                If checkIncorporatedRevPopulated = "" Then
                    PopulateIncorporatedRevWhenStatusIncorporated()
                End If

            End If
        End If
        '*************************************************************************************************************************************************



        '------------------------------------------------------------------------------------------------------------------------------------------------------------
        'THIS VARIABLE IS SO THAT WHEN DATA IS SAVED WITH THE SAVE BUTTON IT GETS RECORDED AS SUCH AND THE PROGRAM DOES NOT ASK TO SAVE WHEN MOVING TO ANOTHER RECORD
        DataSavedWithSaveBtn = "Yes"
        '------------------------------------------------------------------------------------------------------------------------------------------------------------



        '------------------------------------------------------------------------------------------------------------------------------------------------------------
        'WHEN SAVING GET THE ROW SELECTED FROM THE UPPER AND LOWER GRIDS, SO THAT I CAN HAVE THEM SELECTED AFTER ALL THE SAVE CODE IS EXECUTED
        RowSelectedUpperGrid = GridView1.FocusedRowHandle
        RowSelectedLowerGrid = GridView2.FocusedRowHandle
        '------------------------------------------------------------------------------------------------------------------------------------------------------------



        '**************************************************************************************************************************************************************
        ''VALIDATION: VERIFY IF THEY WANT TO PUT THE DATA BACK TO THE INITIAL VALUES WHEN THEY MOVE A GATE BACKWARD
        'If initialStatus <> StatusChangedTo Then
        '    'GoTo ExitSubToEnterDate

        '    da = New SqlClient.SqlDataAdapter("Select Seq From tblMovingGateBackward Where Status = '" & StatusChangedTo & "'", SqlConnection1)
        '    da.Fill(ds, "SeqStatusChangedTo")
        '    Dim SeqStatusChangedTo As Integer = ds.Tables("SeqStatusChangedTo").Rows(0).Item("Seq")

        '    da = New SqlClient.SqlDataAdapter("Select Seq From tblMovingGateBackward Where Status = '" & initialStatus & "'", SqlConnection1)
        '    da.Fill(ds, "SeqInitialStatus")
        '    Dim SeqInitialStatus As Integer = ds.Tables("SeqInitialStatus").Rows(0).Item("Seq")

        '    If SeqStatusChangedTo < SeqInitialStatus Then
        '        If MsgBox("Would you like to reset all data for the higher gates?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '            If StatusChangedTo = "GATE 0: CM Needs To Assign DWG Number" Then
        '                cbomaininfodrafter.Text = ""
        '                dtmaininfodraftercomp.Value = "1/1/1900"
        '                cbomaininfosrengineer.Text = ""
        '                dtmaininfosrengcomp.Value = "1/1/1900"
        '                cbomaininfoStress.Text = ""
        '                dtmaininfoStressComp.Value = "1/1/1900"
        '                cbomaininfoengineer.Text = ""
        '                dtmaininfoengcomp.Value = "1/1/1900"
        '                cbomaininforeleaser.Text = ""
        '                dtmaininforeleasercomp.Value = "1/1/1900"
        '                dtmaininfoactualfinishdt.Value = "1/1/1900"
        '            ElseIf StatusChangedTo = "GATE 1: DWG Ready For Drafter" Then
        '                'cboSchedPercComp.Text = "0"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
        '                cboPercentComplete.Text = "0"
        '                cbomaininfosrengineer.Text = ""
        '                dtmaininfosrengcomp.Value = "1/1/1900"
        '                cbomaininfoStress.Text = ""
        '                dtmaininfoStressComp.Value = "1/1/1900"
        '                cbomaininfoengineer.Text = ""
        '                dtmaininfoengcomp.Value = "1/1/1900"
        '                cbomaininforeleaser.Text = ""
        '                dtmaininforeleasercomp.Value = "1/1/1900"
        '                dtmaininfoactualfinishdt.Value = "1/1/1900"
        '            ElseIf StatusChangedTo = "GATE 2: DWG Ready For Sr Engineer" Then
        '                'cboSchedPercComp.Text = "70"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
        '                cboPercentComplete.Text = "70"
        '                cbomaininfoengineer.Text = ""
        '                dtmaininfoengcomp.Value = "1/1/1900"
        '                cbomaininforeleaser.Text = ""
        '                dtmaininforeleasercomp.Value = "1/1/1900"
        '                dtmaininfoactualfinishdt.Value = "1/1/1900"
        '            ElseIf StatusChangedTo = "GATE 3: DWG Ready For Operations" Then
        '                'cboSchedPercComp.Text = "80"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
        '                cboPercentComplete.Text = "80"
        '                cbomaininforeleaser.Text = ""
        '                dtmaininforeleasercomp.Value = "1/1/1900"
        '                dtmaininfoactualfinishdt.Value = "1/1/1900"
        '            ElseIf StatusChangedTo = "GATE 4: DWG Ready For Release" Then
        '                'cboSchedPercComp.Text = "90"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
        '                cboPercentComplete.Text = "90"
        '                dtmaininfoactualfinishdt.Value = "1/1/1900"
        '            ElseIf StatusChangedTo = "GATE 5: DWG Released" Then
        '                'cboSchedPercComp.Text = "95"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
        '                cboPercentComplete.Text = "95"
        '                dtmaininfoactualfinishdt.Value = "1/1/1900"
        '            End If
        '        Else
        '            'Reset Actual Finish Date because it cannot be set unless it is at gate 6
        '            dtmaininfoactualfinishdt.Value = "1/1/1900"
        '        End If
        '    End If

        '    ds.Tables("SeqStatusChangedTo").Clear()
        '    ds.Tables("SeqStatusChangedTo").Dispose()
        '    ds.Tables("SeqInitialStatus").Clear()
        '    ds.Tables("SeqInitialStatus").Dispose()
        'End If

        ''initialStatus = cboMainStatus.Text
        '*****************************************************************************************************************************************************




        '-----------------------------------------------------------------------------------------------------------------------------------------------------
        'GATE 0 SHOULD ALWAYS BE ZERO PERCENT
        If cboMainStatus.Text = "GATE 0: CM Needs To Assign DWG Number" Then
            cboPercentComplete.Text = "0"
        End If
        '-----------------------------------------------------------------------------------------------------------------------------------------------------




        '*****************************************************************************************************************************************************
        'VALIDATION: CHECK THAT RESOURCE TYPE HAS A VALUE AT GATES 1 AND HIGHER AND THAT DRAWING NUMBER IS NOT STILL EQUAL TO "NEEDS ASSIGNED"
        Dim DrawingNumberValue As String
        Dim DrawingNumberValueSub As String
        Dim DrawingNumberValueFinal As String

        If cboMainStatus.Text = "GATE 1: DWG Ready For Drafter" Or cboMainStatus.Text = "GATE 2: DWG Ready For Sr Engineer" Or cboMainStatus.Text = "GATE 3: DWG Ready For Operations" Or cboMainStatus.Text = "GATE 4: DWG Ready For Release" Or cboMainStatus.Text = "GATE 5: DWG Released" Or cboMainStatus.Text = "GATE 6: Complete" Then
            'Get Drawing Number of selected revision record
            Dim rowSelected() As Integer = GridView1.GetSelectedRows()
            For Each rowHandle As Integer In rowSelected
                If rowHandle >= 0 Then
                    DrawingNumberValue = GridView1.GetRowCellValue(rowHandle, colDrawingNumber)
                Else
                    DrawingNumberValue = ""
                End If
            Next rowHandle


            If DrawingNumberValue = Nothing Then    'Added 01/20/21
                'Nothing
            Else
                If DrawingNumberValue.Length < 14 Then
                    DrawingNumberValueFinal = DrawingNumberValue
                Else
                    DrawingNumberValueSub = DrawingNumberValue.Substring(0, 14)
                    If DrawingNumberValueSub = "NEEDS ASSIGNED" Then
                        DrawingNumberValueFinal = "NEEDS ASSIGNED"
                    Else
                        DrawingNumberValueFinal = DrawingNumberValue
                    End If
                End If
            End If

            If DrawingNumberValueFinal = "NEEDS ASSIGNED" Then
                MsgBox("Please assign a value to Drawing Number.")
                DrawingNumberValue = ""
                DrawingNumberValueSub = ""
                DrawingNumberValueFinal = ""
                Me.SearchMainInformation()
                CloseSignedOffForm = "Yes"
                Exit Sub
            End If
        End If
        '*****************************************************************************************************************************************************




        '*****************************************************************************************************************************************************
        'VALIDATION: CHECK VALUES BEFORE MOVING TO STATUS/GATE 1

        If cboMainStatus.Text = "GATE 1: DWG Ready For Drafter" Then
            If Me.cboDetailsResourceType.Text = "" Then    'Added this per 12/02/20 email, row 7 point 9
                MsgBox("The Resource Type must be filled in before saving at GATE 1.  Please fill in the resource type and then change the status and save the record.")
                'SearchMainInformation()
                CloseSignedOffForm = "Yes"
                Exit Sub
            End If
            '------------------------------------------------------------------------------------------------------------------------------------------------------------------
            '------12/07/2020 - Block of code below was commented out because Resource Type is filled and Drawing Number is NOT equal to "needs assigned" are both checked at any gates 1 or higher. Basically block of code below was added above
            ''Get Drawing Number of selected revision record
            'Dim rowSelected() As Integer = GridView1.GetSelectedRows()
            'For Each rowHandle As Integer In rowSelected
            '    If rowHandle >= 0 Then
            '        DrawingNumberValue = GridView1.GetRowCellValue(rowHandle, colDrawingNumber)
            '    Else
            '        DrawingNumberValue = ""
            '    End If
            'Next rowHandle

            'If DrawingNumberValue.Length < 14 Then
            '    DrawingNumberValueFinal = DrawingNumberValue
            'Else
            '    DrawingNumberValueSub = DrawingNumberValue.Substring(0, 14)
            '    If DrawingNumberValueSub = "NEEDS ASSIGNED" Then
            '        DrawingNumberValueFinal = "NEEDS ASSIGNED"
            '    Else
            '        DrawingNumberValueFinal = DrawingNumberValue
            '    End If
            'End If

            'If cboDetailsResourceType.Text = "" Or DrawingNumberValueFinal = "NEEDS ASSIGNED" Then
            '    MsgBox("Please select a value for Resource Type and assign a value to Drawing Number if it is still equal to NEEDS ASSIGNED.")
            '    DrawingNumberValue = ""
            '    DrawingNumberValueSub = ""
            '    DrawingNumberValueFinal = ""
            '    Exit Sub
            'End If
            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------


            'VALIDATION: Before moving to gate 2 they must have Sr Engineer Name and Stress Name should not be empty or not equal to n/a



            'If moving backward to Gate 1 set the percent complete to 20
            Dim valuePercentBeforeMovingGateBack As Integer = cboPercentComplete.Text
            If valuePercentBeforeMovingGateBack > 65 Then
                cboPercentComplete.Text = "65"
            End If


            'Send Notifications to Drafter and Lead Engineer when Gate is moved to 1
            DrawingNumForEmails = txtMainDrawingNumber.Text
            RevisionForEmails = cboMainRev.Text
            If NotificationAlreadySentForGateOne <> "Yes" Then
                frmEngWorkflowSignOff.SendNotifications(1)
                NotificationAlreadySentForGateOne = "Yes"           'Need this because it was sending a notification to Gate 1 people twice, when saving with save btn and when saving with the signoff btn
            End If
        End If

        DrawingNumberValue = ""
        DrawingNumberValueSub = ""
        DrawingNumberValueFinal = ""
        '*****************************************************************************************************************************************************



        '*****************************************************************************************************************************************************
        'CHECK VALUES BEFORE MOVING TO STATUS/GATE 2
        Dim DrafterName As String = cbomaininfodrafter.Text
        Dim DrafterDate As String = (dtmaininfodraftercomp.Value).ToString("d")

        If cboMainStatus.Text = "GATE 2: DWG Ready For Sr Engineer" Then

            'When moving the latest rev(that is not a DRN or ADCN) to Gate 2, make sure that the previous DRN/ADCN are set to incorporated
            Dim latestRev As String
            Dim DrnIncorporated As String
            Dim AdcnIncorporated As String

            'da = New SqlClient.SqlDataAdapter("Select DwgRevision,DRNADCN,ADCN, * From vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And ((ADCN = '' Or ADCN Is Null) And (DRNADCN = '' Or DRNADCN Is Null)) Order By Seq Desc", SqlConnection1)
            da = New SqlClient.SqlDataAdapter("Select DwgRevision,DRNADCN,ADCN, * From vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' Order By Seq Desc, RecordID Desc", SqlConnection1)
            da.Fill(ds, "LatestRev")
            If ds.Tables("LatestRev").Rows.Count > 0 Then
                latestRev = ds.Tables("LatestRev").Rows(0).Item("DwgRevision")
                DrnIncorporated = ds.Tables("LatestRev").Rows(0).Item("DRNADCN")
                AdcnIncorporated = ds.Tables("LatestRev").Rows(0).Item("ADCN")
                ds.Tables("LatestRev").Clear()
                ds.Tables("LatestRev").Dispose()
            End If

            'If cboMainRev.Text = latestRev Then
            If cboMainRev.Text = latestRev And DrnIncorporated = "" And AdcnIncorporated = "" Then
                da = New SqlClient.SqlDataAdapter("Select ADCN, DRNADCN, IncorporatedRev, * From tblDrawings Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And IncorporatedRev = '' And ((ADCN != '' And ADCN Is Not Null) Or (DRNADCN != '' And DRNADCN Is Not Null)) And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Cancelled' And Status != 'Deleted'", SqlConnection1)
                da.Fill(ds, "CheckIfEmptyIncorporated")
                If ds.Tables("CheckIfEmptyIncorporated").Rows.Count > 0 Then
                    MsgBox("All previous ADCN/DRN must be set to Incorporated before moving record to GATE 2. Record will not be saved.")
                    'I added the next line on my own but not sure if it will stay, before adding the below line the above line message the program still moves on and goes to the signoff form
                    Search()
                    CloseSignedOffForm = "Yes"
                    ds.Tables("CheckIfEmptyIncorporated").Clear()
                    ds.Tables("CheckIfEmptyIncorporated").Dispose()
                    Exit Sub
                End If
            End If



            If cbomaininfosrengineer.Text = "" Or cbomaininfoStress.Text = "" Then    'Added this per 12/02/20 email, row 7 point 9
                MsgBox("Remember to enter Sr Engineer name and Stress Name before moving to gate 2")
                'SearchMainInformation()
                CloseSignedOffForm = "Yes"
                Exit Sub
            End If
            '-----------------------------------------------------------------------------------------------------------------------------------------------
            '---------12/07/2020 - Commented out block of code below because the DrafterName value will be checked in the code that checks if all fields are populated before moving to a higher gate
            ''VALIDATION: Before moving to gate 2 they must have a drafter name
            'If DrafterName = "" Then
            '    MsgBox("You must enter a Drafter Name")
            '    Exit Sub
            'End If
            '-----------------------------------------------------------------------------------------------------------------------------------------------


            '-----------------------------------------------------------------------------------------------------------------------------------------------
            '---------12/07/2020 - Below block of code was commented out and added down below because it now checks that Next Assembly is populated for any gate 2 or higher
            ''VALIDATION: If document type is Drawing then verify that Next Assembly Drawing is not empty
            'Dim documentType As String = ""
            'da = New SqlClient.SqlDataAdapter("Select Classification From tblDocumentType B INNER JOIN tblDrawings A on A.DocumentType = B.DocumentType Where A.RecordID = '" & Me.txtMainInfoRecordID.Text & "' And A.DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "'", SqlConnection1)
            'da.Fill(ds, "DocumentTypeStatusTwo")
            'If ds.Tables("DocumentTypeStatusTwo").Rows.Count > 0 Then
            '    documentType = ds.Tables("DocumentTypeStatusTwo").Rows(0).Item("Classification")
            'Else
            '    documentType = ""
            'End If

            'If documentType = "Drawing" Then
            '    If txtDetailsNextAssemblyDrawing.Text = "" Then
            '        MsgBox("You must enter Next Assembly Drawing before moving to gate 2.")
            '        documentType = ""
            '        ds.Tables("DocumentTypeStatusTwo").Clear()
            '        ds.Tables("DocumentTypeStatusTwo").Dispose()
            '        Exit Sub
            '    End If
            'End If

            'ds.Tables("DocumentTypeStatusTwo").Clear()
            'ds.Tables("DocumentTypeStatusTwo").Dispose()
            '------------------------------------------------------------------------------------------------------------------------------------------------



            ''Before moving to gate 2 they must have Sr Engineer Name and Stress Name should not be empty or not equal to n/a
            'If cbomaininfosrengineer.Text = "" And (cbomaininfoStress.Text = "" Or cbomaininfoStress.Text <> "N/A") Then    'Added this per 12/02/20 email, row 7 point 9
            '    MsgBox("Enter Sr Engineer name and Stress Name before moving to gate 2")
            '    'SearchMainInformation()
            '    CloseSignedOffForm = "Yes"
            '    Exit Sub
            'End If


            '-----------------------------------------------------------------------------------------------------------------------------------------------------
            'When moving to Gate 2 make sure Operations name is selected. Important because this will be used from the SignOff form to get the email address of the person to whom email a notification
            If cbomaininfoengineer.Text = "" Then
                MsgBox("You must enter Operations Name.")
                CloseSignedOffForm = "Yes"
                Exit Sub
            End If
            '----------------------------------------------------------------------------------------------------------------------------------------------------

            '-----------------------------------------------------------------------------------------------------------------------------------------------------
            'VALIDATION: Before moving to gate 2 they must have drafter date
            '    If DrafterDate = "1/1/1900" Or DrafterDate = "" Then
            '        Dim result As DialogResult = MessageBox.Show("You must enter Drafter Date. Would you like to fill it with today's date?", "Title", MessageBoxButtons.YesNo)
            '        If (result = DialogResult.Yes) Then
            '            dtmaininfodraftercomp.CustomFormat = "MM/dd/yyyy"
            '            dtmaininfodraftercomp.Value = Now()

            '            DrafterName = ""
            '            DrafterDate = ""
            '            'GoTo ExitSubToEnterDate
            '        Else
            '            'Wait for the user to enter Drafter Date
            '            'MsgBox("Please enter Drafter Date Complete")
            '            'Exit Sub
            '            DrafterName = ""
            '            DrafterDate = ""

            '            dtmaininfodraftercomp.Select()
            '            SendKeys.Send("%{DOWN}")
            '            GoTo ExitSubToEnterDate
            '        End If
            '    Else
            '        'Set PercentComplete to 70 after all errors are solved
            '        'cboSchedPercComp.Text = "70"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
            '        cboPercentComplete.Text = "70"
            '    End If
            '------------------------------------------------------------------------------------------------------------------------------------------------------

        End If

        'DrafterName = ""
        'DrafterDate = ""
        '*****************************************************************************************************************************************************



        '*****************************************************************************************************************************************************
        'CHECK VALUES BEFORE MOVING TO STATUS/GATE 3
        If cboMainStatus.Text = "GATE 3: DWG Ready For Operations" Then


            If cbomaininforeleaser.Text = "" Then
                MsgBox("You must enter a releaser Name")
                CloseSignedOffForm = "Yes"
                Exit Sub
            End If

            '------------------------------------------------------------------------------------------------------------------------------------------------
            '12/07/2020 - Commented out block of code below because the DrafterName value will be checked in the code that checks if all fields are populated before moving to a higher gate
            ''VALIDATION: Before moving to gate 3 they must have a engineer and stress names. Stress name if it is nothing value N/A must be selected
            'If StressName = "N/A" Then              
            '    'Nothing
            'Else
            '   If EngineerName = "" Or StressName = "" Then
            '        MsgBox("You must enter Sr. Engineer Name and/or Stress Name. Stress Name can be N/A")
            '       CloseSignedOffForm = "Yes"
            '       Exit Sub
            '   End If
            'End If                                  
            '--------------------------------------------------------------------------------------------------------------------------------------------------


            '--------------------------------------------------------------------------------------------------------------------------------------------------
            'VALIDATION: Before moving to gate 3 they must have engineer date
            'If EngineerDate = "1/1/1900" Or EngineerDate = "" Then
            '    Dim result As DialogResult = MessageBox.Show("You must enter Sr. Engineer Date. Would you like to fill it with today's date?", "Title", MessageBoxButtons.YesNo)
            '    If (result = DialogResult.Yes) Then
            '        dtmaininfosrengcomp.CustomFormat = "MM/dd/yyyy"
            '        dtmaininfosrengcomp.Value = Now()

            '        EngineerName = ""
            '        EngineerDate = ""
            '        'GoTo ExitSubToEnterDate
            '    Else
            '        'Wait for the user to enter Drafter Date
            '        EngineerName = ""
            '        EngineerDate = ""

            '        dtmaininfosrengcomp.Select()
            '        SendKeys.Send("%{DOWN}")
            '        GoTo ExitSubToEnterDate
            '    End If
            'End If
            '---------------------------------------------------------------------------------------------------------------------------------------------------

            '---------------------------------------------------------------------------------------------------------------------------------------------------
            'VALIDATION: If Stress Name = N/A then the Stress Date should not be enabled
            'If cbomaininfoStress.Text = "N/A" Then
            '    dtmaininfoStressComp.Value = "01/01/1900"
            '    'dtmaininfoStressComp.Enabled = False
            '    StressDateDisabled = "Yes"
            'Else
            '    'dtmaininfoStressComp.Enabled = True
            '    StressDateDisabled = "No"
            'End If
            '----------------------------------------------------------------------------------------------------------------------------------------------------


            '----------------------------------------------------------------------------------------------------------------------------------------------------
            'VALIDATION: Before moving to gate 3 they must have stress date or if they do not need it they must enter N/A
            'If StressDateDisabled <> "Yes" Then
            'If StressDate = "1/1/1900" Or StressDate = "" Then
            '    Dim result As DialogResult = MessageBox.Show("You must enter Stress Date. Would you like to fill it with today's date?", "Title", MessageBoxButtons.YesNo)
            '    If (result = DialogResult.Yes) Then
            '        dtmaininfoStressComp.CustomFormat = "MM/dd/yyyy"
            '        dtmaininfoStressComp.Value = Now()

            '        StressName = ""
            '        StressDate = ""
            '        'GoTo ExitSubToEnterDate
            '    Else
            '        'Wait for the user to enter Drafter Date
            '        'MsgBox("Please enter Drafter Date Complete")
            '         CloseSignedOffForm = "Yes"
            '        'Exit Sub
            '        StressName = ""
            '        StressDate = ""

            '        dtmaininfoStressComp.Select()
            '        SendKeys.Send("%{DOWN}")
            '        GoTo ExitSubToEnterDate
            '    End If
            'Else
            '    'Set PercentComplete to 80 after all errors are solved
            '    'cboSchedPercComp.Text = "80"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
            '    cboPercentComplete.Text = "80"
            'End If

            'Else
            '    'Set PercentComplete to 80 after all errors are solved
            '    'cboSchedPercComp.Text = "80"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
            '    cboPercentComplete.Text = "80"
            'End If
            '-----------------------------------------------------------------------------------------------------------------------------------------------------

        End If

        'StressName = ""
        ''StressDate = ""
        '*****************************************************************************************************************************************************



        '*****************************************************************************************************************************************************
        'CHECK VALUES BEFORE MOVING TO STATUS/GATE 4
        'Dim OperationsName As String = cbomaininfoengineer.Text
        'Dim OperationsDate As String = (dtmaininfoengcomp.Value).ToString("d")

        If cboMainStatus.Text = "GATE 4: DWG Ready For Release" Then
            If cbomaininforeleaser.Text = "" Then           'Added this block on 01/25/21
                MsgBox("You must enter a releaser Name")
                CloseSignedOffForm = "Yes"
                Exit Sub
            End If                                          'Added this block on 01/25/21

            '--------------------------------------------------------------------------------------------------------------------------------------------------
            '    'VALIDATION: Check if document type is Drawing. If it is verify then go ahead with the validation below
            '    Dim documentTypeStatusFour As String = ""
            '    da = New SqlClient.SqlDataAdapter("Select Classification From tblDocumentType B INNER JOIN tblDrawings A on A.DocumentType = B.DocumentType Where A.RecordID = '" & Me.txtMainInfoRecordID.Text & "' And A.DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "'", SqlConnection1)
            '    da.Fill(ds, "DocumentTypeStatusFour")
            '    If ds.Tables("DocumentTypeStatusFour").Rows.Count > 0 Then
            '        documentTypeStatusFour = ds.Tables("DocumentTypeStatusFour").Rows(0).Item("Classification")
            '    Else
            '        documentTypeStatusFour = ""
            '    End If

            '    If documentTypeStatusFour = "Drawing" Then

            '        '---------12/07/2020 - Commented out block of code below because the DrafterName value will be checked in the code that checks if all fields are populated before moving to a higher gate
            '        ''Before moving to gate 4 they must have a operations name
            '        'If OperationsName = "" Then
            '        '    MsgBox("You must enter Operations Name")
            '        '    Exit Sub
            '        'End If

            '---------------------------------------------------------------------------------------------------------------------------------------------------------
            '        'VALIDATION: Before moving to gate 4 they must have operations date
            '        If OperationsDate = "1/1/1900" Or OperationsDate = "" Then
            '            Dim result As DialogResult = MessageBox.Show("You must enter Operations Date. Would you like to fill it with today's date?", "Title", MessageBoxButtons.YesNo)
            '            If (result = DialogResult.Yes) Then
            '                dtmaininfoengcomp.CustomFormat = "MM/dd/yyyy"
            '                dtmaininfoengcomp.Value = Now()

            '                OperationsName = ""
            '                OperationsDate = ""
            '                'GoTo ExitSubToEnterDate
            '            Else
            '                'Wait for the user to enter Operations Date
            '                OperationsName = ""
            '                OperationsDate = ""

            '                dtmaininfoengcomp.Select()
            '                SendKeys.Send("%{DOWN}")
            '                GoTo ExitSubToEnterDate
            '            End If
            '        Else
            '            'Set PercentComplete to 90 after all needed fields are populated
            '            'cboSchedPercComp.Text = "90"    'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
            '            cboPercentComplete.Text = "90"
            '        End If

            '    ElseIf documentTypeStatusFour = "Report" Then
            '        'Set PercentComplete to 90 after all errors are solved
            '        'cboSchedPercComp.Text = "90"    'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
            '        cboPercentComplete.Text = "90"
            'End If


            'ds.Tables("DocumentTypeStatusFour").Clear()
            'ds.Tables("DocumentTypeStatusFour").Dispose()
            'documentTypeStatusFour = ""
            '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        End If

        'OperationsName = ""
        'OperationsDate = ""



        '*****************************************************************************************************************************************************
        'CHECK VALUES BEFORE MOVING TO STATUS/GATE 5
        'Dim ReleaserName As String = cbomaininforeleaser.Text
        'Dim ReleaserDate As String = (dtmaininforeleasercomp.Value).ToString("d")

        If cboMainStatus.Text = "GATE 5: DWG Released" Then

            '----------------------------------------------------------------------------------------------------------------------------------------------
            '    '-------12/07/2020 - Commented out block of code below because the DrafterName value will be checked in the code that checks if all fields are populated before moving to a higher gate
            '    ''VALIDATION: Before moving to gate 5 they must have a releaser name
            '    'If ReleaserName = "" Then
            '    '    MsgBox("You must enter a releaser Name")
            '    '    Exit Sub
            '    'End If
            '----------------------------------------------------------------------------------------------------------------------------------------------

            '----------------------------------------------------------------------------------------------------------------------------------------------
            '    'VALIDATION: Before moving to gate 5 they must have releaser date
            '    If ReleaserDate = "1/1/1900" Or ReleaserDate = "" Then
            '        Dim result As DialogResult = MessageBox.Show("You must enter Releaser Date. Would you like to fill it with today's date?", "Title", MessageBoxButtons.YesNo)
            '        If (result = DialogResult.Yes) Then
            '            dtmaininforeleasercomp.CustomFormat = "MM/dd/yyyy"
            '            dtmaininforeleasercomp.Value = Now()

            '            ReleaserName = ""
            '            ReleaserDate = ""
            '            'GoTo ExitSubToEnterDate
            '        Else
            '            'Wait for the user to enter Releaser Date
            '            'MsgBox("Please enter Releaser Date Complete")
            '            'Exit Sub
            '            ReleaserName = ""
            '            ReleaserDate = ""

            '            dtmaininforeleasercomp.Select()
            '            SendKeys.Send("%{DOWN}")
            '            GoTo ExitSubToEnterDate
            '        End If
            '    Else
            '        'Set PercentComplete to 95 after all errors are solved
            '        'cboSchedPercComp.Text = "95"    'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
            '        cboPercentComplete.Text = "95"
            '    End If
            '-------------------------------------------------------------------------------------------------------------------------------------------------
        End If

        'ReleaserName = ""
        'ReleaserDate = ""
        '*****************************************************************************************************************************************************



        '*****************************************************************************************************************************************************
        'VALIDATION: CHECK IF DOCUMENT TYPE IS DRAWING. IF IT IS VERIFY THAT NEXT ASSEMBLY DRAWING IS NOT EMPTY AT GATES 2 OR HIGHER
        If cboMainStatus.Text = "GATE 2: DWG Ready For Sr Engineer" Or cboMainStatus.Text = "GATE 3: DWG Ready For Operations" Or cboMainStatus.Text = "GATE 4: DWG Ready For Release" Or cboMainStatus.Text = "GATE 5: DWG Released" Or cboMainStatus.Text = "GATE 6: Complete" Then

            Dim documentType As String = ""
            da = New SqlClient.SqlDataAdapter("Select Classification From tblDocumentType B INNER JOIN tblDrawings A on A.DocumentType = B.DocumentType Where A.RecordID = '" & Me.txtMainInfoRecordID.Text & "' And A.DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "'", SqlConnection1)
            da.Fill(ds, "DocumentTypeStatusTwo")
            If ds.Tables("DocumentTypeStatusTwo").Rows.Count > 0 Then
                documentType = ds.Tables("DocumentTypeStatusTwo").Rows(0).Item("Classification")
            Else
                documentType = ""
            End If

            'If documentType = "Drawing" Then
            '    'The below looks like it is checking for status but it is just seeing if in the next assembly grid there is at least one record, so it is basically checking if there is an assembly
            '    Dim checkIfHasNextAssembly As String = GridView12.GetRowCellValue(GridView12.FocusedRowHandle, "Status")
            '    'If txtDetailsNextAssemblyDrawing.Text = "" Then
            '    If checkIfHasNextAssembly = "" Then
            '        MsgBox("You must enter Next Assembly Drawing before moving to gate 2 or higher.")
            '        documentType = ""
            '        ds.Tables("DocumentTypeStatusTwo").Clear()
            '        ds.Tables("DocumentTypeStatusTwo").Dispose()
            '        SearchMainInformation()
            '        CloseSignedOffForm = "Yes"
            '        Exit Sub
            '    End If
            'End If

            ds.Tables("DocumentTypeStatusTwo").Clear()
            ds.Tables("DocumentTypeStatusTwo").Dispose()
        End If
        '*****************************************************************************************************************************************************




        '*****************************************************************************************************************************************************
        'VALIDATION: DO NOT ALLOW TO CHANGE THE STATUS OF A REVISION RECORD TO GATE 6(BEFORE THE CODE CHANGE IT WAS FOR GATES OTHER THAN 0 OR 1), 
        'UNLESS ALL PREVIOUS ADCN And DRN RECORDS HAVE DRNADCNSTATUS, INCORPORATEDBY And INCORPORATEDREV POPULATED
        Dim x As Integer = 0
        Dim valueOfDrn As String = ""
        Dim valueOfAdcn As String = ""
        Dim valueOfDrnAdcnStatus As String = ""
        Dim valueOfIncorporatedBy As String = ""
        Dim valueOfIncorporatedRev As String = ""

        'Catch the new status, the one the user changed it to
        StatusChangedToForIncorporated = cboMainStatus.Text

        GiveSequenceNumToChangedToStatuses()

        'Run block of code below only if user moves status to one bigger that the existing one
        If SeqChangedToForIncorporated > InitialSeqForIncorporated Then

            'Run block of code below only if user changes the status and then the status the user changed it to is not 0 or 1
            If InitialStatusForIncorporated <> StatusChangedToForIncorporated Then


                Dim StatusFocusedRow As String
                da = New SqlClient.SqlDataAdapter("SELECT Status FROM tblDrawings Where RecordID = '" & RecordIDForIncorporated & "'", SqlConnection1)
                da.Fill(ds, "StatusOfFocusedRow")
                StatusFocusedRow = ds.Tables("StatusOfFocusedRow").Rows(0).Item("Status")

                'If cboMainStatus.Text <> "GATE 0: CM Needs To Assign DWG Number" Or cboMainStatus.Text <> "GATE 1: DWG Ready For Drafter" Then
                'Before code was line above and not the below one
                'If cboMainStatus.Text = "GATE 6: Complete" Then
                'Before code was line above
                If StatusFocusedRow = "GATE 6: Complete" Then

                    'ONLY CHECK ADCNs AND DRNs THAT THEY ALL HAVE THE INCORPORATED FIELD POPULATED, BEFORE MOVING TO A HIGHER GATE
                    'da = New SqlClient.SqlDataAdapter("SELECT * FROM tblDrawings Where ((DrawingNumber = '" & txtMainDrawingNumber.Text & "') And (ADCN != '' And ADCN is not null)) Or ((DrawingNumber = '" & txtMainDrawingNumber.Text & "') And (DRNADCN != '' And DRNADCN is not null))", SqlConnection1)
                    da = New SqlClient.SqlDataAdapter("SELECT * FROM tblDrawings Where ((RecordID = '" & RecordIDForIncorporated & "') And (ADCN != '' And ADCN is not null)) Or ((RecordID = '" & RecordIDForIncorporated & "') And (DRNADCN != '' And DRNADCN is not null))", SqlConnection1)
                    da.Fill(ds, "StatusChangedToValue")
                    If ds.Tables("StatusChangedToValue").Rows.Count > 0 Then
                        While x <= ds.Tables("StatusChangedToValue").Rows.Count - 1
                            'valueOfDrnAdcnStatus = ds.Tables("StatusChangedToValue").Rows(x).Item("DRNADCNStatus")
                            'valueOfIncorporatedBy = ds.Tables("StatusChangedToValue").Rows(x).Item("DRNADCNIncorporatedBy")
                            'valueOfIncorporatedRev = ds.Tables("StatusChangedToValue").Rows(x).Item("IncorporatedRev")
                            valueOfDrnAdcnStatus = cboDRNADCNStatus.Text
                            valueOfIncorporatedBy = cboDRNADCNIncorporatedBy.Text
                            valueOfIncorporatedRev = cboIncorporatedRev.Text
                            valueOfDrn = ds.Tables("StatusChangedToValue").Rows(x).Item("DRNADCN")
                            valueOfAdcn = ds.Tables("StatusChangedToValue").Rows(x).Item("ADCN")
                            If valueOfDrnAdcnStatus = "" Or valueOfIncorporatedBy = "" Or valueOfIncorporatedRev = "" Then
                                MsgBox("Make sure DRNADCN Status, Incorporated By and Incorporated Rev fields for DRN or ADCN " & valueOfDrn & " " & valueOfAdcn & " are populated.")
                                valueOfDrn = ""
                                valueOfAdcn = ""
                                SearchMainInformation()
                                CloseSignedOffForm = "Yes"
                                Exit Sub
                            End If
                            x = x + 1
                        End While
                    End If

                    x = 0
                    valueOfDrn = ""
                    valueOfAdcn = ""
                    valueOfDrnAdcnStatus = ""
                    valueOfIncorporatedBy = ""
                    valueOfIncorporatedRev = ""
                    ds.Tables("StatusChangedToValue").Clear()
                    ds.Tables("StatusChangedToValue").Dispose()
                End If

                StatusFocusedRow = ""
                ds.Tables("StatusOfFocusedRow").Clear()
                ds.Tables("StatusOfFocusedRow").Dispose()




                Dim hasDRN As String
                Dim hasADCN As String
                Dim a As Integer = 0
                Dim selectedRowsDrnAdcnStatus() As Integer = GridView2.GetSelectedRows()
                For Each rowHandleTwo As Integer In selectedRowsDrnAdcnStatus
                    If rowHandleTwo >= 0 Then
                        If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colDRNADCN1)) Then
                            hasDRN = ""
                        Else
                            hasDRN = GridView2.GetRowCellValue(rowHandleTwo, colDRNADCN1)
                        End If
                        If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colADCN2)) Then
                            hasADCN = ""
                        Else
                            hasADCN = GridView2.GetRowCellValue(rowHandleTwo, colADCN2)
                        End If
                    End If
                Next rowHandleTwo
                If StatusChangedToForIncorporated = "GATE 6: Complete" And hasDRN = "" And hasADCN = "" Then
                    'THE NEWEST REVISION MUST HAVE THE INCORPORATED FIELD OF ALL THE PREVIOUS DRNs AND ADCNs SET TO INCORPORATED BEFORE MOVING TO GATE 6
                    Dim testrecordid As String = txtMainInfoRecordID.Text
                    da = New SqlClient.SqlDataAdapter("SELECT * FROM tblDrawings Where (((DrawingNumber = '" & txtMainDrawingNumber.Text & "') And (ADCN != '' And ADCN is not null And ADCN != '0')) Or ((DrawingNumber = '" & txtMainDrawingNumber.Text & "') And (DRNADCN != '' And DRNADCN is not null And DRNADCN != '0'))) And RecordID <= '" & txtMainInfoRecordID.Text & "'", SqlConnection1)
                    da.Fill(ds, "NonDrnMoveToGateSix")
                    While a <= ds.Tables("NonDrnMoveToGateSix").Rows.Count - 1
                        valueOfDrnAdcnStatus = ds.Tables("NonDrnMoveToGateSix").Rows(a).Item("DRNADCNStatus")
                        If valueOfDrnAdcnStatus = "" Or valueOfDrnAdcnStatus = "Not Incorporated" Then
                            MsgBox("Make sure all DRNs or ADCNs are set to incorporated before moving this revision to Gate 6")
                            cboMainStatus.Text = InitialStatusForIncorporated
                            ds.Tables("NonDrnMoveToGateSix").Clear()
                            ds.Tables("NonDrnMoveToGateSix").Dispose()
                            a = 0
                            HighlightRedTextboxesWithDefaultDate()
                            SearchMainInformation()
                            CloseSignedOffForm = "Yes"
                            Exit Sub
                        End If
                        a += 1
                        valueOfDrnAdcnStatus = ""
                    End While
                    valueOfDrnAdcnStatus = ""
                    ds.Tables("NonDrnMoveToGateSix").Clear()
                    ds.Tables("NonDrnMoveToGateSix").Dispose()
                    a = 0
                End If
            End If
        End If
        '*****************************************************************************************************************************************************



        '*****************************************************************************************************************************************************
        'VERIFY IF ANY DATA IS MISSED IN THE BETWEEN GATES WHEN ONE MOVES A GATE TO A HIGHER NUMBER

        If cbomaininfoStress.Text = "N/A" Then
            dtmaininfoStressComp.Value = "01/01/1900"
            ' dtmaininfoStressComp.Enabled = False
            StressDateDisabled = "Yes"
        Else
            'dtmaininfoStressComp.Enabled = True
            StressDateDisabled = "No"
        End If

        'If StatusChangedTo = "GATE 2: DWG Ready For Sr Engineer" Then
        '    If cbomaininfodrafter.Text = "" Or dtmaininfodraftercomp.Value = "1/1/1900" Then
        '        MsgBox("You must enter all data for the previous gates before you move to a higher gate")
        '        SearchMainInformation()
        '        Exit Sub
        '    End If

        'ElseIf StatusChangedTo = "GATE 3: DWG Ready For Operations" Then
        '    If StressDateDisabled <> "Yes" Then
        '        If cbomaininfodrafter.Text = "" Or dtmaininfodraftercomp.Value = "1/1/1900" Or cbomaininfosrengineer.Text = "" Or dtmaininfosrengcomp.Value = "1/1/1900" Or cbomaininfoStress.Text = "" Or dtmaininfoStressComp.Value = "1/1/1900" Or cboPercentComplete.Text = "" Then     'Changed cboSchedPercComp to cboPercentComplete
        '            MsgBox("You must enter all data for the previous gates before you move to a higher gate")
        '            SearchMainInformation()
        '            Exit Sub
        '        End If
        '    Else
        '        If cbomaininfodrafter.Text = "" Or dtmaininfodraftercomp.Value = "1/1/1900" Or cbomaininfosrengineer.Text = "" Or dtmaininfosrengcomp.Value = "1/1/1900" Or cbomaininfoStress.Text = "" Or cboPercentComplete.Text = "" Then     'Changed cboSchedPercComp to cboPercentComplete
        '            MsgBox("You must enter all data for the previous gates before you move to a higher gate")
        '            SearchMainInformation()
        '            Exit Sub
        '        End If
        '    End If

        'ElseIf StatusChangedTo = "GATE 4: DWG Ready For Release" Then
        '    If StressDateDisabled <> "Yes" Then
        '        If cbomaininfodrafter.Text = "" Or dtmaininfodraftercomp.Value = "1/1/1900" Or cbomaininfosrengineer.Text = "" Or dtmaininfosrengcomp.Value = "1/1/1900" Or cbomaininfoStress.Text = "" Or dtmaininfoStressComp.Value = "1/1/1900" Or cbomaininfoengineer.Text = "" Or dtmaininfoengcomp.Value = "1/1/1900" Or cboPercentComplete.Text = "" Then    'Changed cboSchedPercComp to cboPercentComplete
        '            MsgBox("You must enter all data for the previous gates before you move to a higher gate")
        '            SearchMainInformation()
        '            Exit Sub
        '        End If
        '    Else
        '        If cbomaininfodrafter.Text = "" Or dtmaininfodraftercomp.Value = "1/1/1900" Or cbomaininfosrengineer.Text = "" Or dtmaininfosrengcomp.Value = "1/1/1900" Or cbomaininfoStress.Text = "" Or cbomaininfoengineer.Text = "" Or dtmaininfoengcomp.Value = "1/1/1900" Or cboPercentComplete.Text = "" Then     'Changed cboSchedPercComp to cboPercentComplete
        '            MsgBox("You must enter all data for the previous gates before you move to a higher gate")
        '            SearchMainInformation()
        '            Exit Sub
        '        End If
        '    End If

        'ElseIf StatusChangedTo = "GATE 5: DWG Released" Then
        '    If StressDateDisabled <> "Yes" Then
        '        If cbomaininfodrafter.Text = "" Or dtmaininfodraftercomp.Value = "1/1/1900" Or cbomaininfosrengineer.Text = "" Or dtmaininfosrengcomp.Value = "1/1/1900" Or cbomaininfoStress.Text = "" Or dtmaininfoStressComp.Value = "1/1/1900" Or cbomaininfoengineer.Text = "" Or dtmaininfoengcomp.Value = "1/1/1900" Or cbomaininforeleaser.Text = "" Or dtmaininforeleasercomp.Value = "1/1/1900" Or cboPercentComplete.Text = "" Then   'Changed cboSchedPercComp to cboPercentComplete
        '            MsgBox("You must enter all data for the previous gates before you move to a higher gate")
        '            SearchMainInformation()
        '            Exit Sub
        '        End If
        '    Else
        '        If cbomaininfodrafter.Text = "" Or dtmaininfodraftercomp.Value = "1/1/1900" Or cbomaininfosrengineer.Text = "" Or dtmaininfosrengcomp.Value = "1/1/1900" Or cbomaininfoStress.Text = "" Or cbomaininfoengineer.Text = "" Or dtmaininfoengcomp.Value = "1/1/1900" Or cbomaininforeleaser.Text = "" Or dtmaininforeleasercomp.Value = "1/1/1900" Or cboPercentComplete.Text = "" Then    'Changed cboSchedPercComp to cboPercentComplete
        '            MsgBox("You must enter all data for the previous gates before you move to a higher gate")
        '            SearchMainInformation()
        '            Exit Sub
        '        End If
        '    End If

        '    'ElseIf StatusChangedTo = "GATE 6: Complete" Then
        '    '    If StressDateDisabled <> "Yes" Then
        '    '        If cbomaininfodrafter.Text = "" Or dtmaininfodraftercomp.Value = "1/1/1900" Or cbomaininfosrengineer.Text = "" Or dtmaininfosrengcomp.Value = "1/1/1900" Or cbomaininfoStress.Text = "" Or dtmaininfoStressComp.Value = "1/1/1900" Or cbomaininfoengineer.Text = "" Or dtmaininfoengcomp.Value = "1/1/1900" Or cbomaininforeleaser.Text = "" Or dtmaininforeleasercomp.Value = "1/1/1900" Or dtmaininfoactualfinishdt.Value = "1/1/1900" Or cboPercentComplete.Text = "" Then   'Changed cboSchedPercComp to cboPercentComplete
        '    '            MsgBox("You must enter all data for the previous gates before you move to a higher gate")
        '    '            SearchMainInformation()
        '    '            Exit Sub
        '    '        End If
        '    '    Else
        '    '        If cbomaininfodrafter.Text = "" Or dtmaininfodraftercomp.Value = "1/1/1900" Or cbomaininfosrengineer.Text = "" Or dtmaininfosrengcomp.Value = "1/1/1900" Or cbomaininfoStress.Text = "" Or cbomaininfoengineer.Text = "" Or dtmaininfoengcomp.Value = "1/1/1900" Or cbomaininforeleaser.Text = "" Or dtmaininforeleasercomp.Value = "1/1/1900" Or dtmaininfoactualfinishdt.Value = "1/1/1900" Or cboPercentComplete.Text = "" Then    'Changed cboSchedPercComp to cboPercentComplete
        '    '            MsgBox("You must enter all data for the previous gates before you move to a higher gate")
        '    '            SearchMainInformation()
        '    '            Exit Sub
        '    '        End If
        '    '    End If
        'End If
        '*****************************************************************************************************************************************************




        '*****************************************************************************************************************************************************
        'VERIFY IF THEY WANT TO PUT THE DATA BACK TO THE INITIAL VALUES WHEN THEY MOVE A GATE BACKWARD
        If initialStatus <> StatusChangedTo Then
            'GoTo ExitSubToEnterDate
            If StatusChangedTo = "GATE 6: Complete" Then
                da = New SqlClient.SqlDataAdapter("Select * from tblDrawings Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' and ADCN <> 0 and DRNADCNStatus = 'Not Incorporated' and dwgrevision <> '" & cboMainRev.Text & "' OR  DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' and DRNADCN <> '' and DRNADCNStatus = 'Not Incorporated' and dwgrevision <> '" & cboMainRev.Text & "'", SqlConnection1)
                da.Fill(ds, "DataOK")

                If ds.Tables("DataOK").Rows.Count > 0 Then
                    MsgBox("ADCN/DRN must be incorporated before moving record to GATE 6.  Record will not be saved.")
                    CloseSignedOffForm = "Yes"
                    ds.Tables("DataOK").Clear()
                    ds.Tables("DataOK").Dispose()
                    Exit Sub
                End If

            End If
            da = New SqlClient.SqlDataAdapter("Select Seq From tblMovingGateBackward Where Status = '" & StatusChangedTo & "'", SqlConnection1)
            da.Fill(ds, "SeqStatusChangedTo")
            Dim SeqStatusChangedTo As Integer = ds.Tables("SeqStatusChangedTo").Rows(0).Item("Seq")

            da = New SqlClient.SqlDataAdapter("Select Seq From tblMovingGateBackward Where Status = '" & initialStatus & "'", SqlConnection1)
            da.Fill(ds, "SeqInitialStatus")
            Dim SeqInitialStatus As Integer = ds.Tables("SeqInitialStatus").Rows(0).Item("Seq")

            If SeqStatusChangedTo < SeqInitialStatus Then
                If MsgBox("Would you like to reset all dates for the higher gates?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If StatusChangedTo = "GATE 0: CM Needs To Assign DWG Number" Then
                        cboPercentComplete.Text = "0"
                        'cbomaininfodrafter.Text = ""
                        dtmaininfodraftercomp.Value = "1/1/1900"
                        'cbomaininfosrengineer.Text = ""
                        dtmaininfosrengcomp.Value = "1/1/1900"
                        'cbomaininfoStress.Text = ""
                        dtmaininfoStressComp.Value = "1/1/1900"
                        'cbomaininfoengineer.Text = ""
                        dtmaininfoengcomp.Value = "1/1/1900"
                        'cbomaininforeleaser.Text = ""
                        dtmaininforeleasercomp.Value = "1/1/1900"
                        dtmaininfoactualfinishdt.Value = "1/1/1900"
                    ElseIf StatusChangedTo = "GATE 1: DWG Ready For Drafter" Then
                        'cboSchedPercComp.Text = "0"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
                        cboPercentComplete.Text = "65"
                        ' cbomaininfosrengineer.Text = ""
                        dtmaininfosrengcomp.Value = "1/1/1900"
                        'cbomaininfoStress.Text = ""
                        dtmaininfoStressComp.Value = "1/1/1900"
                        'cbomaininfoengineer.Text = ""
                        dtmaininfoengcomp.Value = "1/1/1900"
                        'cbomaininforeleaser.Text = ""
                        dtmaininforeleasercomp.Value = "1/1/1900"
                        dtmaininfoactualfinishdt.Value = "1/1/1900"
                    ElseIf StatusChangedTo = "GATE 2: DWG Ready For Sr Engineer" Then
                        'cboSchedPercComp.Text = "70"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
                        cboPercentComplete.Text = "70"
                        'cbomaininfoengineer.Text = ""
                        dtmaininfoengcomp.Value = "1/1/1900"
                        'cbomaininforeleaser.Text = ""
                        dtmaininforeleasercomp.Value = "1/1/1900"
                        dtmaininfoactualfinishdt.Value = "1/1/1900"
                    ElseIf StatusChangedTo = "GATE 3: DWG Ready For Operations" Then
                        'cboSchedPercComp.Text = "80"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
                        cboPercentComplete.Text = "80"
                        'cbomaininforeleaser.Text = ""
                        dtmaininforeleasercomp.Value = "1/1/1900"
                        dtmaininfoactualfinishdt.Value = "1/1/1900"
                    ElseIf StatusChangedTo = "GATE 4: DWG Ready For Release" Then
                        'cboSchedPercComp.Text = "90"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
                        cboPercentComplete.Text = "90"
                        dtmaininfoactualfinishdt.Value = "1/1/1900"
                    ElseIf StatusChangedTo = "GATE 5: DWG Released" Then
                        'cboSchedPercComp.Text = "95"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
                        cboPercentComplete.Text = "95"
                        dtmaininfoactualfinishdt.Value = "1/1/1900"
                    End If
                Else
                    'Reset Actual Finish Date because it cannot be set unless it is at gate 6
                    dtmaininfoactualfinishdt.Value = "1/1/1900"

                    'Reset Percent Complete to appropriate value according to gate, when moving to a smaller gate
                    If StatusChangedTo = "GATE 0: CM Needs To Assign DWG Number" Then
                        cboPercentComplete.Text = "0"
                    ElseIf StatusChangedTo = "GATE 1: DWG Ready For Drafter" Then
                        cboPercentComplete.Text = "65"
                    ElseIf StatusChangedTo = "GATE 2: DWG Ready For Sr Engineer" Then
                        cboPercentComplete.Text = "70"
                    ElseIf StatusChangedTo = "GATE 3: DWG Ready For Operations" Then
                        cboPercentComplete.Text = "80"
                    ElseIf StatusChangedTo = "GATE 4: DWG Ready For Release" Then
                        cboPercentComplete.Text = "90"
                    ElseIf StatusChangedTo = "GATE 5: DWG Released" Then
                        cboPercentComplete.Text = "95"
                    End If
                End If

                ds.Tables("SeqStatusChangedTo").Clear()
                ds.Tables("SeqStatusChangedTo").Dispose()
                ds.Tables("SeqInitialStatus").Clear()
                ds.Tables("SeqInitialStatus").Dispose()
            End If
        End If
        '*****************************************************************************************************************************************************



        '*****************************************************************************************************************************************************
        'VALIDATION: Check number for percentage and masked field
        'Try
        If cboPercentComplete.Text > 100 Or cboPercentComplete.Text < 0 Then
            MsgBox("Please enter a valid percent complete between 0 and 100 and then click save.")
            SearchMainInformation()
            CloseSignedOffForm = "Yes"
            Exit Sub
        End If
        'Catch ex As Exception
        '    cboPercentComplete.Text = "0"
        'End Try

        Try
            If mskSchedDuration.Text < 0 Then
                MsgBox("Please enter a number greater than 0 and then click save.")
                SearchMainInformation()
                CloseSignedOffForm = "Yes"
                Exit Sub
            End If
        Catch ex As Exception
            Me.mskSchedDuration.Text = "0"
        End Try
        '*****************************************************************************************************************************************************




        '*****************************************************************************************************************************************************
        'CHECK VALUES BEFORE MOVING TO STATUS/GATE 6
        Dim ActualFinishDate As String = (dtmaininfoactualfinishdt.Value).ToString("d")

        If cboMainStatus.Text = "GATE 6: Complete" Then

            'Before moving to gate 6 they must have actual finish date
            If ActualFinishDate = "1/1/1900" Or ActualFinishDate = "" Then
                Dim result As DialogResult = MessageBox.Show("Before you can save, enter Actual Finish Date. Add today's date? - *THEN SAVE AGAIN* - Choose No to rescind CM.", "Title", MessageBoxButtons.YesNo)
                If (result = DialogResult.Yes) Then
                    dtmaininfoactualfinishdt.CustomFormat = "MM/dd/yyyy"
                    dtmaininfoactualfinishdt.Value = Now()

                    ActualFinishDate = ""
                    btnSave.PerformClick()
                    'GoTo ExitSubToEnterDate
                Else
                    'Wait for the user to enter Actual Finish Date
                    'MsgBox("Please enter Actual Finish Date Complete")
                    'Exit Sub
                    ActualFinishDate = ""

                    dtmaininfoactualfinishdt.Select()
                    SendKeys.Send("%{DOWN}")
                    GoTo ExitSubToEnterDate
                End If
            Else
                'Set PercentComplete to 100 after all errors are solved
                'cboSchedPercComp.Text = "100"   'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
                cboPercentComplete.Text = "100"
            End If
        End If

        ActualFinishDate = ""
        '*****************************************************************************************************************************************************


        '*****************************************************************************************************************************************************
        'CHECK ALL REDLINES FOR THE PREVIOUS REVS ARE SET TO INCORPORATED BEFORE MOVING TO GATE 2 OR 6
        If (cboMainStatus.Text = "GATE 2: DWG Ready For Sr Engineer" Or cboMainStatus.Text = "GATE 6: Complete") And cboDRN.Text = "" And cboADCN.Text = "" Then

            da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Status != 'Incorporated' And Status != 'No Action Required' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)   'And Rev = '" & RedlineRev & "' 
            da.Fill(ds, "CheckAllPreviousRevsAreIncorporated")

            If ds.Tables("CheckAllPreviousRevsAreIncorporated").Rows.Count > 0 Then
                MsgBox("Not all Redlines are set to Incorporated. Fix that before moving the gate and sign off.")
                ds.Tables("CheckAllPreviousRevsAreIncorporated").Clear()
                ds.Tables("CheckAllPreviousRevsAreIncorporated").Dispose()
                CloseSignedOffForm = "Yes"
                SearchMainInformation()
                Exit Sub
            End If
        End If
        '*****************************************************************************************************************************************************




        '*****************************************************************************************************************************************************
        'VALIDATION: DO NOT ALLOW TO CHANGE ACTUAL FINISH DATE UNLESS GATE/STATUS IS 6
        'If cboMainStatus.Text <> "GATE 6: Complete" Then
        '    Dim ActualFinishDtForGateSix As String = (dtmaininfoactualfinishdt.Value).ToString("d")

        '    If ActualFinishDtForGateSix <> "01/01/1900" And ActualFinishDtForGateSix <> "01/01/2000" And ActualFinishDtForGateSix <> "1/1/1900" And ActualFinishDtForGateSix <> "1/1/2000" Then
        '        If ActualFinishDtForGateSix <> "" Then
        '            MsgBox("You cannot have Actual Finish Date unless Gate is at 6.")
        '            dtmaininfoactualfinishdt.Value = "01/01/1900"
        '            ActualFinishDtForGateSix = ""
        '            SearchMainInformation()
        '            Exit Sub
        '        End If
        '    End If

        '    ActualFinishDtForGateSix = ""
        'End If
        '*****************************************************************************************************************************************************

        If initialStatus = "Obsolete" Then
            If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
                'Continue
                If Me.cboMainStatus.Text = "Gate 6: Complete" Then
                    u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 6: Complete' Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "'")
                Else
                    MsgBox("You can only move a record that was obsolete back to Gate 6. Record will not be saved.")
                    Exit Sub
                End If
            Else
                MsgBox("A user with CM role or Administrator role can move a record back to Gate 6.  Status will not be moved from Obsolete.  Please contact CM or an administrator")
                Exit Sub
            End If
        End If

        '*****************************************************************************************************************************************************
        'USED FOR SAVING FUNCTIONALITY: FOR SAVING REGULARLY  OR  SAVING WHEN THEY CHANGE SOMETHING AND FORGET TO SAVE
        If SaveFrom = "SaveWithoutClickingSaveBtn" Then
            'Nothing
        Else
            SaveFrom = ""
            DataIsSaved = ""
        End If
        If SaveFrom = "SaveWithoutClickingSaveBtn" Then
            If DataIsSaved = "No" Then
                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DwgRevision = '" & RevForSave & "'  Where RecordID = '" & RecordIDForSave & "'")
                ', Status = '" & Me.cboMainStatus.Text & "', DrawingTitle = '" & u.FTM(Me.txtmaininfotitle.Text) & "', ActualFinishDate = '" & Me.dtmaininfoactualfinishdt.Value & "', Drafter = '" & u.FTM(Me.cbomaininfodrafter.Text) & "', Engineer = '" & u.FTM(Me.cbomaininfoengineer.Text) & "', SrEngineer = '" & u.FTM(Me.cbomaininfosrengineer.Text) & "', Releaser = '" & u.FTM(Me.cbomaininforeleaser.Text) & "', Stress = '" & u.FTM(Me.cbomaininfoStress.Text) & "', DrafterComplete = '" & Me.dtmaininfodraftercomp.Value & "', EngineerComplete = '" & Me.dtmaininfoengcomp.Value & "', SrEngineerComplete = '" & Me.dtmaininfosrengcomp.Value & "', ReleaserCompelte = '" & Me.dtmaininforeleasercomp.Value & "', StressComplete = '" & Me.dtmaininfoStressComp.Value & "', Program = '" & Me.cboDetailsProgram.Text & "', Location = '" & Me.cboDetailsLocation.Text & "', DocumentType = '" & Me.cboDetailsDocumentType.Text & "', DCN = '" & Me.maskedDetailsDCN.Text & "', NextHigherAssembly = '" & Me.txtDetailsNextAssemblyDrawing.Text & "', SystemDescription = '" & Me.cboDetailsSystem.Text & "', Type = '" & Me.cboDetailsResourceType.Text & "', InstallationDrawing = '" & Me.txtDetailsInstallationDrawing.Text & "', Notes = '" & u.FTM(Me.txtNotesNotes.Text) & "', DRNADCN = '" & u.FTM(Me.cboDRN.Text) & "', ADCN = '" & u.FTM(Me.cboADCN.Text) & "', WONumber = '" & Me.txtSchedWorkOrder.Text & "', ForecastStartDate = '" & Me.dtSchedForecastStart.Value & "', ForecastFinishDate = '" & Me.dtSchedForecastFinish.Value & "', EstimatedDurationHours = '" & mskSchedDuration.Text & "', PercentComplete = '" & Me.cboSchedPercComp.Text & "', Priority = '" & Me.cboSchedMilestone.Text & "', WhiteBoardNumber = '" & Me.cboSchedWhiteBoard.Text & "', DRNADCNStatus = '" & Me.cboDRNADCNStatus.Text & "', DRNADCNIncorporatedBy = '" & Me.cboDRNADCNIncorporatedBy.Text & "', IncorporatedRev = '" & Me.cboIncorporatedRev.Text & "'
                DataIsSaved = "Yes"
            Else
                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DwgRevision = '" & Me.cboMainRev.Text & "', Status = '" & Me.cboMainStatus.Text & "', DrawingTitle = '" & u.FTM(Me.txtmaininfotitle.Text) & "', ActualFinishDate = '" & Me.dtmaininfoactualfinishdt.Value & "', Drafter = '" & u.FTM(Me.cbomaininfodrafter.Text) & "', Engineer = '" & u.FTM(Me.cbomaininfoengineer.Text) & "', SrEngineer = '" & u.FTM(Me.cbomaininfosrengineer.Text) & "', Releaser = '" & u.FTM(Me.cbomaininforeleaser.Text) & "', Stress = '" & u.FTM(Me.cbomaininfoStress.Text) & "', Location = '" & Me.cboDetailsLocation.Text & "', DocumentType = '" & Me.cboDetailsDocumentType.Text & "', DCN = '" & Me.maskedDetailsDCN.Text & "', Type = '" & Me.cboDetailsResourceType.Text & "', InstallationDrawing = '" & Me.txtDetailsInstallationDrawing.Text & "', Notes = '" & u.FTM(Me.txtNotesNotes.Text) & "', DRNADCN = '" & u.FTM(Me.cboDRN.Text) & "', ADCN = '" & u.FTM(Me.cboADCN.Text) & "', WONumber = '" & Me.txtSchedWorkOrder.Text & "', ForecastStartDate = '" & Me.dtSchedForecastStart.Value & "', ForecastFinishDate = '" & Me.dtSchedForecastFinish.Value & "', EstimatedDurationHours = '" & mskSchedDuration.Text & "', PercentComplete = '" & Me.cboPercentComplete.Text & "', Priority = '" & Me.cboSchedMilestone.Text & "', WhiteBoardNumber = '" & Me.cboSchedWhiteBoard.Text & "', DRNADCNStatus = '" & Me.cboDRNADCNStatus.Text & "', DRNADCNIncorporatedBy = '" & Me.cboDRNADCNIncorporatedBy.Text & "', IncorporatedRev = '" & Me.cboIncorporatedRev.Text & "'  Where RecordID = '" & Val(txtMainInfoRecordID.Text) & "'")  ', NextHigherAssembly = '" & Me.txtDetailsNextAssemblyDrawing.Text & "'    'Changed cboSchedPercComp to cboPercentComplete      'SystemDescription = '" & Me.cboDetailsSystem.Text & "',
            End If
            SaveFrom = ""
        Else
            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DwgRevision = '" & Me.cboMainRev.Text & "', Status = '" & Me.cboMainStatus.Text & "', DrawingTitle = '" & u.FTM(Me.txtmaininfotitle.Text) & "', ActualFinishDate = '" & Me.dtmaininfoactualfinishdt.Value & "', Drafter = '" & u.FTM(Me.cbomaininfodrafter.Text) & "', Engineer = '" & u.FTM(Me.cbomaininfoengineer.Text) & "', SrEngineer = '" & u.FTM(Me.cbomaininfosrengineer.Text) & "', Releaser = '" & u.FTM(Me.cbomaininforeleaser.Text) & "', Stress = '" & u.FTM(Me.cbomaininfoStress.Text) & "', Location = '" & Me.cboDetailsLocation.Text & "', DocumentType = '" & Me.cboDetailsDocumentType.Text & "', DCN = '" & Me.maskedDetailsDCN.Text & "', Type = '" & Me.cboDetailsResourceType.Text & "', InstallationDrawing = '" & Me.txtDetailsInstallationDrawing.Text & "', Notes = '" & u.FTM(Me.txtNotesNotes.Text) & "', DRNADCN = '" & u.FTM(Me.cboDRN.Text) & "', ADCN = '" & u.FTM(Me.cboADCN.Text) & "', WONumber = '" & Me.txtSchedWorkOrder.Text & "', ForecastStartDate = '" & Me.dtSchedForecastStart.Value & "', ForecastFinishDate = '" & Me.dtSchedForecastFinish.Value & "', EstimatedDurationHours = '" & mskSchedDuration.Text & "', PercentComplete = '" & Me.cboPercentComplete.Text & "', Priority = '" & Me.cboSchedMilestone.Text & "', WhiteBoardNumber = '" & Me.cboSchedWhiteBoard.Text & "', DRNADCNStatus = '" & Me.cboDRNADCNStatus.Text & "', DRNADCNIncorporatedBy = '" & Me.cboDRNADCNIncorporatedBy.Text & "', IncorporatedRev = '" & Me.cboIncorporatedRev.Text & "'  Where RecordID = '" & Val(txtMainInfoRecordID.Text) & "'")   ', NextHigherAssembly = '" & Me.txtDetailsNextAssemblyDrawing.Text & "'      'Changed cboSchedPercComp to cboPercentComplete      'SystemDescription = '" & Me.cboDetailsSystem.Text & "', 
        End If
        '*****************************************************************************************************************************************************


        '---------------------------------------------------------------------------------------------------------------
        'Make the NewRework field for this record equal to Rework Drawing or Rework Report, but only for the records where the next line below is true
        If cboMainRev.Text <> "IR" And cboMainRev.Text <> "-" And cboMainRev.Text <> "NC" And cboMainRev.Text <> "P1" Then

            Dim ReportOrDrawing As String = ""

            'Check if document type is Report or Drawing
            da = New SqlClient.SqlDataAdapter("Select NewRework From tblDrawings Where RecordID = '" & Me.txtMainInfoRecordID.Text & "'", SqlConnection1)
            da.Fill(ds, "ClassificationSelectedRec")
            If ds.Tables("ClassificationSelectedRec").Rows.Count > 0 Then
                ReportOrDrawing = ds.Tables("ClassificationSelectedRec").Rows(0).Item("NewRework")
            End If

            ds.Tables("ClassificationSelectedRec").Clear()
            ds.Tables("ClassificationSelectedRec").Dispose()


            If ReportOrDrawing = "New Drawing" Then
                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set NewRework = 'Rework Drawing' Where RecordId = '" & txtMainInfoRecordID.Text & "'")  'Changed cboSchedPercComp to cboPercentComplete      ', SystemDescription = '" & Me.cboDetailsSystem.Text & "'
            ElseIf ReportOrDrawing = "New Report" Then
                u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set NewRework = 'Rework Report' Where RecordId = '" & txtMainInfoRecordID.Text & "'")  'Changed cboSchedPercComp to cboPercentComplete      ', SystemDescription = '" & Me.cboDetailsSystem.Text & "'
            End If

        End If
        '---------------------------------------------------------------------------------------------------------------



        '*****************************************************************************************************************************************************
        'CHECK TO SEE IF DOCUMENT IS A MASTER DATA LIST.  IF IT IS AND STATUS IS GATE 6, MAKE SURE MDL IS MOVED TO REL
        If Me.cboDetailsDocumentType.Text = "Master Data List" And Me.cboMainStatus.Text = "GATE 6: Complete" Then
            da = New SqlClient.SqlDataAdapter("Select * from tblLiveMDL Where MDLNumber = '" & Val(Me.txtMainDrawingNumber.Text) & "' and Status = 'LOCKED'", SqlConnection1)
            da.Fill(ds, "VerifyMDL")
            If ds.Tables("VerifyMDL").Rows.Count > 0 Then
                u.ExecuteSQL(SqlConnection1, "Update tblLiveMDL Set Status = 'REL' Where  MDLNumber = '" & Val(Me.txtMainDrawingNumber.Text) & "'")
            End If
        End If
        '*****************************************************************************************************************************************************



        '*****************************************************************************************************************************************************
        Search()
        CheckSignOffs()
        '*****************************************************************************************************************************************************



        ChangesLowerGridSaved = "Yes"



        'Put the focus on the rows that were selected (for upper and lower grids) before hitting the save button
        GridView1.FocusedRowHandle = RowSelectedUpperGrid
        GridView1.SelectRow(RowSelectedUpperGrid)
        GridView2.FocusedRowHandle = RowSelectedLowerGrid
        GridView2.SelectRow(RowSelectedLowerGrid)



        'Used for saving functionality: for saving regularly OR saving when they change something and forget to save
        DataIsSaved = "Yes"


        '------------------------------------------------------------------------------------------------------------
        'Update tblTree
        da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq desc, RecordID Desc", SqlConnection1)
        da.Fill(ds, "DataToUpdateTree")
        If ds.Tables("DataToUpdateTree").Rows.Count > 0 Then

            Dim RevToUpdateTree As String = ds.Tables("DataToUpdateTree").Rows(0).Item("DwgRevision")
            Dim TitleToUpdateTree As String = ds.Tables("DataToUpdateTree").Rows(0).Item("DrawingTitle")
            Dim StatusToUpdateTree As String = ds.Tables("DataToUpdateTree").Rows(0).Item("Status")
            Dim SeqToUpdateTree As String = ds.Tables("DataToUpdateTree").Rows(0).Item("Seq")
            'Dim SystemToUpdateTree As String = ds.Tables("DataToUpdateTree").Rows(0).Item("SystemDescription")

            'Dim checkIfThereAreAssemblies As String = GridView12.GetRowCellValue(GridView12.FocusedRowHandle, "DrawingTitle")
            'If checkIfThereAreAssemblies = "" Then      'Without Assembly
            '    'u.ExecuteSQL(SqlConnection1, "Update tblTree Set DwgRevision = '" & RevToUpdateTree & "', SystemDescription = '" & SystemToUpdateTree & "', DrawingTitle = '" & TitleToUpdateTree & "', Status = '" & StatusToUpdateTree & "', Seq = '" & SeqToUpdateTree & "' Where DrawingNumOriginal = '" & Me.txtMainDrawingNumber.Text & "' And NextHigherAssembly = '' And NextHigherAssembly Is Null And NextHigherAssembly = 'N/A' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'")
            'Else                                        'With Assembly
            '    u.ExecuteSQL(SqlConnection1, "Update tblTree Set DwgRevision = '" & RevToUpdateTree & "', DrawingTitleChildren = '" & TitleToUpdateTree & "', Status = '" & StatusToUpdateTree & "', Seq = '" & SeqToUpdateTree & "' Where DrawingNumOriginal = '" & Me.txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'")
            'End If


            da = New SqlClient.SqlDataAdapter("Select DrawingNumber From tblTree Where DrawingNumOriginal = '" & txtMainDrawingNumber.Text & "' And DrawingNumber != '' And DrawingNumber Is Not Null And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By DrawingNumber", SqlConnection1)
            da.Fill(ds, "AssembliesToInsert")

            If ds.Tables("AssembliesToInsert").Rows.Count > 0 Then
                u.ExecuteSQL(SqlConnection1, "Update tblTree Set DwgRevision = '" & RevToUpdateTree & "', DrawingTitleChildren = '" & TitleToUpdateTree & "', Status = '" & StatusToUpdateTree & "', Seq = '" & SeqToUpdateTree & "' Where DrawingNumOriginal = '" & Me.txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'")

                ds.Tables("AssembliesToInsert").Clear()
                ds.Tables("AssembliesToInsert").Dispose()
            End If


            ds.Tables("DataToUpdateTree").Clear()
            ds.Tables("DataToUpdateTree").Dispose()
        End If
        '-----------------------------------------------------------------------------------------------------------



ExitSubToEnterDate:

        HighlightRedTextboxesWithDefaultDate()


        'Drawing number to use for notification emails
        DrawingNumForEmails = txtMainDrawingNumber.Text
        RevisionForEmails = cboMainRev.Text


        'Update notifications label
        GetNumberTasksPending()


        UpdateAssembly()
        UpdateProjectField()
        UpdateSystemField()
        UpdateProgramField()


        CloseSignedOffForm = ""

    End Sub
    Public Function CheckSignOffs()
        If dtmaininfodraftercomp.Value <> "01/01/1900" And dtmaininfodraftercomp.Value <> "01/01/2000" Then
            Me.cbomaininfodrafter.Enabled = False
        Else
            Me.cbomaininfodrafter.Enabled = True
        End If
        If dtmaininfosrengcomp.Value <> "01/01/1900" And dtmaininfosrengcomp.Value <> "01/01/2000" Then
            Me.cbomaininfosrengineer.Enabled = False
        Else
            Me.cbomaininfosrengineer.Enabled = True
        End If

        If dtmaininfoengcomp.Value <> "01/01/1900" And dtmaininfoengcomp.Value <> "01/01/2000" Then
            Me.cbomaininfoengineer.Enabled = False
        Else
            Me.cbomaininfoengineer.Enabled = True
        End If

        If dtmaininfoStressComp.Value <> "01/01/1900" And dtmaininfoStressComp.Value <> "01/01/2000" And cbomaininfoStress.Text <> "" Then
            Me.cbomaininfoStress.Enabled = False
        ElseIf cbomaininfoStress.Text = "N/A" And dtmaininfosrengcomp.Value <> "01/01/1900" And dtmaininfosrengcomp.Value <> "01/01/2000" Then
            Me.cbomaininfoStress.Enabled = False
        Else
            Me.cbomaininfoStress.Enabled = True
        End If

        If dtmaininforeleasercomp.Value <> "01/01/1900" And dtmaininforeleasercomp.Value <> "01/01/2000" Then
            Me.cbomaininforeleaser.Enabled = False
        Else
            Me.cbomaininforeleaser.Enabled = True
        End If
    End Function
    Private Sub WhiteBoardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteBoardToolStripMenuItem.Click
        Dim frmlovWhiteBoard As New frmlovWhiteBoard
        frmlovWhiteBoard.Show()
    End Sub

    Private Sub NewReworkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewReworkToolStripMenuItem.Click
        Dim frmlovNewRework As New frmlovNewRework
        frmlovNewRework.Show()
    End Sub

    Private Sub DRNADCNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DRNADCNToolStripMenuItem.Click
        Dim frmlovDRNADCN As New frmlovDRNADCN
        frmlovDRNADCN.Show()

    End Sub

    Private Sub PriorityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PriorityToolStripMenuItem.Click
        Dim frmlovPriority As New frmlovPriority
        frmlovPriority.Show()
    End Sub

    Private Sub NameAssignmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NameAssignmentsToolStripMenuItem.Click
        Dim frmlovAssignmentNames As New frmlovAssignmentNames
        frmlovAssignmentNames.Show()
    End Sub

    Private Sub ResourceTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResourceTypeToolStripMenuItem.Click
        'Dim AdminScreen As New AdminScreen
        'AdminScreen.Show()
        Dim ResourceType As New frmLovType
        ResourceType.Show()
    End Sub

    Private Sub DocumentTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentTypeToolStripMenuItem.Click
        Dim frmlovDocumentType As New frmlovDocumentType
        frmlovDocumentType.Show()
    End Sub

    Private Sub SystemDescriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemDescriptionToolStripMenuItem.Click
        Dim frmlovSystems As New frmlovSystems
        frmlovSystems.Show()
    End Sub

    Private Sub CertificationStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificationStaffToolStripMenuItem.Click
        Dim frmCertificationStaff As New frmCertificationStaff
        frmCertificationStaff.Show()
    End Sub

    Private Sub ProgramsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramsToolStripMenuItem.Click
        Dim Programs As New Programs
        Programs.Show()
    End Sub

    Private Sub NotificationRolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationRolesToolStripMenuItem.Click
        Dim NotificationRoles As New frmlovNotificationRoles
        NotificationRoles.Show()
    End Sub

    Private Sub ProjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectsToolStripMenuItem.Click
        Dim Projects As New Projects
        Projects.Show()
    End Sub

    Private Sub txtMainInfoRecordID_TextChanged(sender As Object, e As EventArgs) Handles txtMainInfoRecordID.TextChanged
        SqlConnection1.ConnectionString = sqlString

        '----------------------------------------------------------------------------------
        'Get Program and Gate to use with notifications
        'ProgramName = cboDetailsProgram.Text    'This is good, as cboDetailsProgram will actually contain Program

        da = New SqlClient.SqlDataAdapter("Select ProgramReal From tblDrawings Where RecordID = '" & txtMainInfoRecordID.Text & "'", SqlConnection1)
        da.Fill(ds, "ProgramReal")
        If ds.Tables("ProgramReal").Rows.Count > 0 Then
            If IsDBNull(ds.Tables("ProgramReal").Rows(0).Item("ProgramReal")) Then
                ProgramName = ""
            ElseIf ds.Tables("ProgramReal").Rows(0).Item("ProgramReal") = "" Then
                ProgramName = ""
            Else
                cboDetailsProgram.Text = ds.Tables("ProgramReal").Rows(0).Item("ProgramReal")
                ProgramName = cboDetailsProgram.Text
            End If
            ds.Tables("ProgramReal").Clear()
            ds.Tables("ProgramReal").Dispose()
        End If

        GateStatus = cboMainStatus.Text
        '----------------------------------------------------------------------------------


        initialStatus = cboMainStatus.Text

        RevChangedToValue = cboMainRev.Text



        'Disable the Program and the Document Type drop-downs, otherwise there may be a disconnect; per Owen SOW
        'cboDetailsProgram.Enabled = False
        cboDetailsDocumentType.Enabled = False



        '---------------------------------------------------------------------------------------------------------------

        'If the drawing number has more than one record in tblDrawings then it is because it has revisions, in that case make the btnNumber not visible and the
        'Status drop-down enabled. Else just run the code how it was before (the one in the Else)
        da = New SqlClient.SqlDataAdapter("Select * From tblDrawings where DrawingNumber = '" & txtMainDrawingNumber.Text & "'", SqlConnection1)
        da.Fill(ds, "CheckIfHasRevisions")
        If ds.Tables("CheckIfHasRevisions").Rows.Count > 1 Then
            btnNumber.Visible = False
            cboMainStatus.Enabled = True

            ds.Tables("CheckIfHasRevisions").Clear()
            ds.Tables("CheckIfHasRevisions").Dispose()

            GoTo BYPASSNumberBtnAndcboMainStatusCode
        End If

        ds.Tables("CheckIfHasRevisions").Clear()
        ds.Tables("CheckIfHasRevisions").Dispose()





        'Check if document number has been confirmed in Form B.  If it is hide the NUMBER BUTTON (only for lead engineers, CMs and Admins)
        'Also disable the Status drop-down as the user cannot move the status to anything else when it is at gate zero: record is set to gate zero in Form A and gate 1 in Form B. Record can be moved to Gate 1 only after signoff on Form B
        IsDocNumConfirmed = ""
        If IsDBNull(ds.Tables("USERAUTHENTICATE").Rows(0).Item("NewRecord")) Then
            isNewRecord = "False"
        ElseIf ds.Tables("USERAUTHENTICATE").Rows(0).Item("NewRecord") = 0 Then
            isNewRecord = "False"
        Else
            isNewRecord = "True"
        End If


        da = New SqlClient.SqlDataAdapter("Select IsDocNumConfirmed, Status From tblDrawings where RecordID = '" & Val(Me.txtMainInfoRecordID.Text) & "'", SqlConnection1)
        da.Fill(ds, "DocConfirmed")

        'NUMBER BUTTON VISIBILITY CONTROL
        'If (CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Or isLeadEngineer = "True") And isNewRecord = "True" Then
        If isCM_LeadEng_Admin = "True" Then

            If ds.Tables("DocConfirmed").Rows.Count > 0 Then
                If IsDBNull(ds.Tables("DocConfirmed").Rows(0).Item("IsDocNumConfirmed")) And ds.Tables("DocConfirmed").Rows(0).Item("Status") <> "GATE 0: CM Needs To Assign DWG Number" Then
                    btnNumber.Visible = False
                    IsDocNumConfirmed = "Yes"
                ElseIf IsDBNull(ds.Tables("DocConfirmed").Rows(0).Item("IsDocNumConfirmed")) And ds.Tables("DocConfirmed").Rows(0).Item("Status") = "GATE 0: CM Needs To Assign DWG Number" Then
                    btnNumber.Visible = True
                    IsDocNumConfirmed = "No"
                    'cboMainStatus.Enabled = False
                ElseIf ds.Tables("DocConfirmed").Rows(0).Item("IsDocNumConfirmed") = False And ds.Tables("DocConfirmed").Rows(0).Item("Status") = "GATE 0: CM Needs To Assign DWG Number" Then
                    btnNumber.Visible = True
                    IsDocNumConfirmed = "No"
                    'cboMainStatus.Enabled = False
                ElseIf ds.Tables("DocConfirmed").Rows(0).Item("IsDocNumConfirmed") = False And ds.Tables("DocConfirmed").Rows(0).Item("Status") <> "GATE 0: CM Needs To Assign DWG Number" Then
                    btnNumber.Visible = False
                    IsDocNumConfirmed = "Yes"
                ElseIf ds.Tables("DocConfirmed").Rows(0).Item("IsDocNumConfirmed") = True Then
                    btnNumber.Visible = False
                    IsDocNumConfirmed = "Yes"
                ElseIf IsDBNull(ds.Tables("DocConfirmed").Rows(0).Item("IsDocNumConfirmed")) And ds.Tables("DocConfirmed").Rows(0).Item("Status") = "GATE 6: Complete" Then
                    btnNumber.Visible = True
                    IsDocNumConfirmed = "No"
                Else
                    btnNumber.Visible = True
                    IsDocNumConfirmed = "No"
                End If
            End If
        Else
            btnNumber.Visible = False
            'If ds.Tables("DocConfirmed").Rows.Count > 0 Then
            '    If ds.Tables("DocConfirmed").Rows(0).Item("Status") = "GATE 0: CM Needs To Assign DWG Number" Then
            '        cboMainStatus.Enabled = False
            '    End If
            'End If
        End If


        'cboMainStatus VISIBILITY WHEN SET TO GATE 0: Status dropdown is not enabled if gate 0 and doc has not been confirmed
        Dim DocHasBeenConfirmed As String = ""
        If ds.Tables("DocConfirmed").Rows.Count > 0 Then
            If IsDBNull(ds.Tables("DocConfirmed").Rows(0).Item("IsDocNumConfirmed")) Then
                DocHasBeenConfirmed = "False"
            ElseIf ds.Tables("DocConfirmed").Rows(0).Item("IsDocNumConfirmed") = False Then
                DocHasBeenConfirmed = "False"
            Else
                DocHasBeenConfirmed = ds.Tables("DocConfirmed").Rows(0).Item("IsDocNumConfirmed")
            End If
        End If

        'If IsCMOrLeadEngOrAdmin = "False" Then
        If ds.Tables("DocConfirmed").Rows.Count > 0 Then
            If DocHasBeenConfirmed = "False" And ds.Tables("DocConfirmed").Rows(0).Item("Status") = "GATE 0: CM Needs To Assign DWG Number" Then
                cboMainStatus.Enabled = False
            Else
                cboMainStatus.Enabled = True
            End If
        End If
        'Else
        '    cboMainStatus.Enabled = True
        'End If


        ds.Tables("DocConfirmed").Clear()
        ds.Tables("DocConfirmed").Dispose()

        '---------------------------------------------------------------------------------------------------------------




BYPASSNumberBtnAndcboMainStatusCode:

        '----------------------------------------------------------------------------------
        ''DRN/ADCN Change. Tab fills with another binding source
        'Fill out grid of the DRN/ADCN tab. To get rid of records that do not have a DRN or ADCN. This was a requested change but not being implemented because we substituted with grey color
        'da = New SqlClient.SqlDataAdapter("SELECT DwgRevision,DRNADCN,ADCN,Status,DRNADCNStatus,IncorporatedRev,ActualFinishDate,Drafter,DrafterComplete,SrEngineer,SrEngineerComplete,Stress,StressComplete,Engineer,EngineerComplete,Releaser,IncorporatedRev FROM tblDrawings Where DrawingNumber = '" & DrawingNumberBeingModified & "'", SqlConnection1)
        'da.Fill(ds, "RecordsWithDrnAdcn")
        'Me.bsDrnAdcn.DataSource = ds.Tables("RecordsWithDrnAdcn")
        'GridControl5.DataSource = Me.bsDrnAdcn
        '----------------------------------------------------------------------------------


        '----------------------------------------------------------------------------------------------------------------------------------------------
        'DO NOT UNCOMMENT AS THIS WAS NOT WORKING
        ''UNCOMMENT
        ''Dim AppJustOpened As Integer
        'AppJustOpened += 1

        ''ASK IF THEY WANT TO SAVE CHANGES BEFORE MOVING TO ANOTHER RECORD
        ''This variable is set to "Yes" when data is saved with the save button and so that the below group of code does not execute when changing the focus to another record
        'If DataSavedWithSaveBtn <> "Yes" Then
        '    'The variable in the line below is to avoid that the below group of code does not execute when the program first opens up. When code executes at the beginning this Sub gets accessed 4 times and that is why the ">4"
        '    If AppJustOpened > 4 Then
        '        If RevChangedToValue <> "" Then
        '            If InitialRevValue <> RevChangedToValue Then
        '                If MsgBox("Would you like to save changes before you move to a different row. If yes, save changes first.", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '                    InitialRevValue = ""
        '                    RevChangedToValue = ""
        '                Else
        '                    u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DwgRevision = '" & RevChangedToValue & "' Where RecordID = '" & MainRecordIDForSaveChanges & "'")
        '                    Exit Sub
        '                End If
        '            End If
        '        End If
        '    End If
        'End If
        'DataSavedWithSaveBtn = "No"
        ''UNCOMMENT
        '----------------------------------------------------------------------------------------------------------------------------------------------



        '----------------------------------------------------------------------------------------------------------------------------------------------
        'Get initial Status/Gate when moving focus to another revision
        'initialStatus = cboMainStatus.Text
        '----------------------------------------------------------------------------------------------------------------------------------------------




        If Me.txtMainInfoRecordID.Text <> "" Then

            '----------------------------------------------------------------------------------------------------------------------------------------------
            ''Set Incorporated Rev on DRN/ADCN tab equal to the next revision, when the selected revision is at Gate 6 and the next one is between 1 and 5
            'Dim StatusDRNADCNCellValue
            'Dim NextRevision As Integer = -1
            'Dim NextRevisionStatus As String = ""
            'Dim RevisionSelectedLine As String = ""
            'Dim RevisionValueToAssign As String = ""

            'Dim selectedRows() As Integer = GridView5.GetSelectedRows()
            'For Each rowHandle As Integer In selectedRows
            '    If rowHandle >= 0 Then
            '        'Get status and revision of selected revision record
            '        StatusDRNADCNCellValue = GridView5.GetRowCellValue(rowHandle, colDRNADCNStatus)
            '        RevisionSelectedLine = GridView5.GetRowCellValue(rowHandle, colExpr22)
            '        If rowHandle > 0 Then
            '            'Get revision value on next revision, if I need it, so that I give that value to the currently selected revision
            '            NextRevision = rowHandle - 1
            '            RevisionValueToAssign = GridView5.GetRowCellValue(NextRevision, colExpr22)
            '        End If
            '    End If
            'Next rowHandle

            'If IsDBNull(StatusDRNADCNCellValue) Then
            '    cboIncorporatedRev.SelectedIndex = -1
            'Else
            '    If StatusDRNADCNCellValue = "Incorporated" And RevisionSelectedLine <> "" Then
            '        da = New SqlClient.SqlDataAdapter("Select Top 1 * from vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "'And DwgRevision = '" & RevisionSelectedLine & "' Order By Seq Desc", SqlConnection1)
            '        da.Fill(ds, "TOP")

            '        If ds.Tables("TOP").Rows(0).Item("Status") <> "GATE 6: Complete" Then
            '            cboIncorporatedRev.SelectedIndex = -1
            '            'Set IncorporatedRev combobox to next revision, the one after the selected one. Only if current is at gate 6 and next one between gate 1 and 5
            '        ElseIf ds.Tables("TOP").Rows(0).Item("Status") = "GATE 6: Complete" And NextRevision >= 0 Then
            '            da = New SqlClient.SqlDataAdapter("Select Top 1 * from vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "'And DwgRevision = '" & RevisionValueToAssign & "' Order By Seq Desc", SqlConnection1)
            '            da.Fill(ds, "CheckIfGateOneToFive")
            '            If ds.Tables("CheckIfGateOneToFive").Rows(0).Item("Status") <> "GATE 6: Complete" Then
            '                cboIncorporatedRev.Text = RevisionValueToAssign
            '            Else
            '                cboIncorporatedRev.SelectedIndex = -1
            '            End If
            '            ds.Tables("CheckIfGateOneToFive").Clear()
            '            ds.Tables("CheckIfGateOneToFive").Dispose()
            '        Else
            '            cboIncorporatedRev.SelectedIndex = -1
            '        End If

            '        ds.Tables("TOP").Clear()
            '        ds.Tables("TOP").Dispose()
            '        'ds.Tables("NextRevision").Clear()
            '        'ds.Tables("NextRevision").Dispose()
            '    Else
            '        cboIncorporatedRev.SelectedIndex = -1
            '    End If
            'End If
            '----------------------------------------------------------------------------------------------------------------------------------------------



            '----------------------------------------------------------------------------------------------------------------------------------------------
            'GET RECORD ID OF REVISION.  IT WILL BE USED TO GET THE ATTACHMENTS FOR THE SELECTED REVISION
            RecordIDRevision = txtMainInfoRecordID.Text
            FillAttachmentsGridWithData()
            '----------------------------------------------------------------------------------------------------------------------------------------------



            '----------------------------------------------------------------------------------------------------------------------------------------------
            'VALIDATION: CHECK IF REVISION IS A REPORT OR A DRAWING. DRNs and ADCNs CANNOT BE CREATED IF DOCUMENT TYPE IS A REPORT. ALSO WHEN LOCATION IS TORONTO NO ADCN; WHEN LOCATION IS OKC NO DRN
            'Dim drawingNumForDocumentType As String = txtMainDrawingNumber.Text  'This is the DRAWING NUMBER
            'Dim test2 As String = txtMainInfoRecordID.Text  'This is the RECORDID
            AllowDrnAdcn()
            '----------------------------------------------------------------------------------------------------------------------------------------------



            '----------------------------------------------------------------------------------------------------------------------------------------------
            '1.  A, do records exist.  If yes, load, if no, see if program definition already exists and load.
            da = New SqlClient.SqlDataAdapter("select * from tblDrawingCert where DwgRecordID = '" & Val(Me.txtMainInfoRecordID.Text) & "'", SqlConnection1)
            da.Fill(ds, "DrawingCert")

            If ds.Tables("DrawingCert").Rows.Count > 0 Then
                Me.cboCertificationReviewStatus.Text = ds.Tables("DrawingCert").Rows(0).Item("Status")
                Me.txtComments.Text = ds.Tables("DrawingCert").Rows(0).Item("Comments")
            Else
                'Check tblProgramCertificationUM for records, if exist load to tblDrawingCertUMApproval and then call SearchUMApproval

                u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingCert (DwgRecordID, Status, Comments) Values('" & Val(Me.txtMainInfoRecordID.Text) & "', 'Not Submitted', '')")
                Me.cboCertificationReviewStatus.Text = "Not Submitted"

            End If

            ds.Tables("DrawingCert").Clear()
            ds.Tables("DrawingCert").Dispose()


            'Step 1

            'Load tblDrawingcertUMApproval

            '1.  A, do records exist.  If yes, load, if no, see if program definition already exists and load.
            da = New SqlClient.SqlDataAdapter("select * from tblDrawingCertUMApproval where DwgRecordID = '" & Val(Me.txtMainInfoRecordID.Text) & "'", SqlConnection1)
            da.Fill(ds, "CheckDrawingcertUMApproval")

            If ds.Tables("CheckDrawingCertUMApproval").Rows.Count > 0 Then
                SearchUMApproval()
            Else
                'Check tblProgramCertificationUM for records, if exist load to tblDrawingCertUMApproval and then call SearchUMApproval
                da = New SqlClient.SqlDataAdapter("Select * from tblProgramCertificationUM where Program = '" & Me.cboDetailsProgram.Text & "'", SqlConnection1)    'cboDetailsProgram will actually contain Program, so this is good 
                da.Fill(ds, "FILL")

                If ds.Tables("FILL").Rows.Count > 0 Then
                    Dim a As Integer = 0
                    While a <= ds.Tables("FILL").Rows.Count - 1
                        u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingCertUMApproval (DwgRecordID, UMName, UMSpecialty, UMRecommendApproval, UMApproval, RequiredToApprove, Comments) Values('" & Val(Me.txtMainInfoRecordID.Text) & "','" & ds.Tables("FILL").Rows(a).Item("Name") & "', '" & ds.Tables("FILL").Rows(a).Item("UnitMemberSpecialty") & "', 'Not Applicable', '', 'False', '')")
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
            da = New SqlClient.SqlDataAdapter("select * from tblDrawingCertFAAOMTApproval where DwgRecordID = '" & Val(Me.txtMainInfoRecordID.Text) & "'", SqlConnection1)
            da.Fill(ds, "CheckDrawingcertFAAOMTApproval")

            If ds.Tables("CheckDrawingcertFAAOMTApproval").Rows.Count > 0 Then
                SearchFAAOMTApproval()
            Else
                'Check tblProgramCertificationUM for records, if exist load to tblDrawingCertUMApproval and then call SearchUMApproval
                da = New SqlClient.SqlDataAdapter("Select * from tblProgramCertificationFAAOMTMember where Program = '" & Me.cboDetailsProgram.Text & "'", SqlConnection1)  'cboDetailsProgram will actually contain Program, so this is good 
                da.Fill(ds, "FILL1")

                If ds.Tables("FILL1").Rows.Count > 0 Then
                    Dim a As Integer = 0
                    While a <= ds.Tables("FILL1").Rows.Count - 1
                        u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingCertFAAOMTApproval (DwgRecordID, FAAOMTName, FAAOMTSpecialty, FAAOMTRecommendApproval, FAAOMTApproval, RequiredToApprove, Comments) Values('" & Val(Me.txtMainInfoRecordID.Text) & "','" & ds.Tables("FILL1").Rows(a).Item("Name") & "', '" & ds.Tables("FILL1").Rows(a).Item("FAAOMTMemberSpecialty") & "', 'False', '', 'False', '')")
                        a = a + 1
                    End While
                    SearchFAAOMTApproval()
                End If
                ds.Tables("FILL1").Clear()
                ds.Tables("FILL1").Dispose()
            End If

            ds.Tables("CheckDrawingcertFAAOMTApproval").Clear()
            ds.Tables("CheckDrawingcertFAAOMTApproval").Dispose()
            '----------------------------------------------------------------------------------------------------------------------------------------------


            '----------------------------------------------------------------------------------------------------------------------------------------------
            SearchAttachments()
            '----------------------------------------------------------------------------------------------------------------------------------------------

        End If



        'POPULATE DRAWINGS PROJECTS GRID
        PopulateDrawingsProjectsGrid()

        'POPULATE ASSEMBLIES GRID
        PopulateAssembliesGrid()

        'POPULATE PRODUCTION ISSUES TAB GRID
        SearchIssues()


        '----------------------------------------------------------------------------------------------------------------------------------------------
        'HIGHLIGHT RED THE BELOW LABEL IF RECORD IS DELETED(AIM = "...RECORD WAS DELETED)
        ''da = New SqlClient.SqlDataAdapter("Select AIM from tblDrawings where RecordID = '" & txtMainInfoRecordID.Text & "' And Right(tblDrawings.AIM, 18) = 'Record Was Marked Obsolete'", SqlConnection1)
        ''da.Fill(ds, "CheckIfDeleted")
        ''If ds.Tables("CheckIfDeleted").Rows.Count > 0 Then
        ''    lblRecordDeleted.Visible = True
        ''Else
        ''    lblRecordDeleted.Visible = False
        ''End If

        'ds.Tables("CheckIfDeleted").Clear()
        'ds.Tables("CheckIfDeleted").Dispose()
        '----------------------------------------------------------------------------------------------------------------------------------------------


        CheckSignOffs()
        'initialStatus = cboMainStatus.Text



        'BLOCK OF CODE BELOW IS TO BE COMMENTED OUT
        'If System.Environment.UserName = "ohaswell" Or System.Environment.UserName = "apptestcm1" Or System.Environment.UserName = "jwebster" Or System.Environment.UserName = "nsantagata" Or System.Environment.UserName = "rduwel" Or System.Environment.UserName = "llewis" Or System.Environment.UserName = "jsprigg" Or System.Environment.UserName = "rdetillier" Or System.Environment.UserName = "jrovenstine" Or System.Environment.UserName = "alee" Or System.Environment.UserName = "pcampbell" Or System.Environment.UserName = "rrathwell" Or System.Environment.UserName = "mpoma" Or System.Environment.UserName = "uniaz" Then
        If isNewRecord = "True" Then        'ADDED THIS LINE 07/14/2022, per Owen
            btnAdd.Visible = True           'ADDED THIS LINE 07/14/2022, per Owen
        Else
            btnNumber.Visible = False

            'COMMENTED OUT: The next 7 lines will be deleted except for the sixth line which will remain (eventually also the sixth line and everything in this block will be deleted)
            'Dim testUsername As String = "AppTestEng1"
            If System.Environment.UserName = "brauenbuehler" Or System.Environment.UserName = "AppTestEng1" Or System.Environment.UserName = "kticknor" Or System.Environment.UserName = "preteshwars" Or System.Environment.UserName = "rhaggan" Or System.Environment.UserName = "prakhe" Or System.Environment.UserName = "rkumar" Or System.Environment.UserName = "dchristian" Then
                btnAdd.Visible = True
            Else
                btnAdd.Visible = False
            End If

            'btnAdd.Visible = False
        End If



        '---REDLINES CODE ----------------------------------------------------------------------------
        SearchRedLines()

        'If it is the first record (IR) and is not at gate 6 then disable the btnAddRedline
        da = New SqlClient.SqlDataAdapter("Select * From tblDrawings Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And DwgRevision = 'IR' And Status <> 'GATE 6: Complete' And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '') And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)
        da.Fill(ds, "IsOnlyIRNotGateSix")
        If ds.Tables("IsOnlyIRNotGateSix").Rows.Count > 0 Then
            btnAddRedline.Enabled = False
            ds.Tables("IsOnlyIRNotGateSix").Clear()
            ds.Tables("IsOnlyIRNotGateSix").Dispose()
        Else
            EnablingRedLineAddBtn()
        End If

        'If it is an IR at Gate 6 then enable the btnAddRedline
        Dim RecIDLast As String = ""
        da = New SqlClient.SqlDataAdapter("Select * From vwDrawingsRev Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq Desc, RecordID Desc", SqlConnection1)
        da.Fill(ds, "IsOnlyIRAtGateSix")
        If ds.Tables("IsOnlyIRAtGateSix").Rows.Count > 0 Then
            RecIDLast = ds.Tables("IsOnlyIRAtGateSix").Rows(0).Item("RecordID")
            ds.Tables("IsOnlyIRAtGateSix").Clear()
            ds.Tables("IsOnlyIRAtGateSix").Dispose()
        End If

        If cboMainRev.Text = "IR" And isADCN = "" And isDRN = "" And cboMainStatus.Text = "GATE 6: Complete" Then   'And InitialRevValue = "IR" 
            If RecIDLast = txtMainInfoRecordID.Text Then
                btnAddRedline.Enabled = True
            End If
        End If

        'Allow Owen to always have the Redline button available
        If System.Environment.UserName = "ohaswell" Or System.Environment.UserName = "jsprigg" Then
            btnAddRedline.Enabled = True
        End If
    End Sub

    Function FillAttachmentsGridWithData()

        If ds2.Tables("Attachments") Is Nothing Then
            'Nothing
        Else
            ds2.Tables("Attachments").Clear()
        End If


        da2 = New SqlClient.SqlDataAdapter("Select RecordID,DwgRecordID,Target,FileName,IsActualDoc,FileDescription FROM tblAttachments Where DwgRecordID = " & RecordIDRevision, SqlConnection1)
        da2.Fill(ds2, "Attachments")
        Me.bsAttachments.DataSource = ds2.Tables("Attachments")
        GridControl10.DataSource = Me.bsAttachments

        GridView10.Columns("RecordID").Visible = False

        'ds2.Tables("Attachments").Clear()
        'ds2.Tables("Attachments").Dispose()
    End Function

    Public Function AllowDrnAdcn()

        documentType = ""

        'VALIDATION: CHECK IF REVISION IS A REPORT OR A DRAWING. DRNs and ADCNs CANNOT BE CREATED IF DOCUMENT TYPE IS A REPORT. ALSO WHEN LOCATION IS TORONTO NO ADCN; WHEN LOCATION IS OKC NO DRN
        If txtMainDrawingNumber.Text <> "" And txtMainInfoRecordID.Text <> "" Then
            Try
                ds.Tables("DocumentType").Clear()
                ds.Tables("DocumentType").Dispose()
            Catch ex As Exception

            End Try
            'Check if document type is Report or Drawing
            da = New SqlClient.SqlDataAdapter("Select B.Classification From tblDocumentType B INNER JOIN tblDrawings A on A.DocumentType = B.DocumentType Where A.RecordID = '" & Me.txtMainInfoRecordID.Text & "' And A.DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "'", SqlConnection1)
            da.Fill(ds, "DocumentType")
            If ds.Tables("DocumentType").Rows.Count > 0 Then
                documentType = ds.Tables("DocumentType").Rows(0).Item("Classification")
            Else
                documentType = ""
            End If

            'Dim test As String = txtMainInfoRecordID.Text & " " & txtMainDrawingNumber.Text & " " & DrnAllowed & " " & AdcnAllowed & " " & LocationForDrnAdcn

            'Wnen document type is Report no DRNs or ADCNs should be allowed to be created
            If documentType = "Report" Then
                DrnAllowed = "False"
                AdcnAllowed = "False"
                'GridView5.Columns("DRN").Visible = False
                cboDRN.Visible = False
                cboADCN.Visible = False
                cboDRNADCNStatus.Visible = False
                cboDRNADCNIncorporatedBy.Visible = False
                cboIncorporatedRev.Visible = False

            Else
                'If documentType is Drawing
                If Location = "Toronto" Then
                    DrnAllowed = "True"
                    AdcnAllowed = "False"
                    'GridView5.Columns("DRN").Visible = True
                    cboDRN.Visible = True
                    cboADCN.Visible = False
                    cboDRNADCNStatus.Visible = True
                    cboDRNADCNIncorporatedBy.Visible = True
                    cboIncorporatedRev.Visible = True
                    If cboDRN.Text = "" And cboADCN.Text = "" Then
                        'DrnAllowed = "False"
                        'AdcnAllowed = "False"
                        'GridView5.Columns("DRN").Visible = False
                        cboDRN.Visible = False
                        cboADCN.Visible = False
                        cboDRNADCNStatus.Visible = False
                        cboDRNADCNIncorporatedBy.Visible = False
                        cboIncorporatedRev.Visible = False
                    End If
                ElseIf Location = "OKC" Then
                    DrnAllowed = "False"
                    AdcnAllowed = "True"
                    'GridView5.Columns("DRN").Visible = True
                    cboDRN.Visible = False
                    cboADCN.Visible = True
                    cboDRNADCNStatus.Visible = True
                    cboDRNADCNIncorporatedBy.Visible = True
                    cboIncorporatedRev.Visible = True

                    If cboDRN.Text = "" And cboADCN.Text = "" Then
                        'DrnAllowed = "False"
                        'AdcnAllowed = "False"
                        'GridView5.Columns("DRN").Visible = False
                        cboDRN.Visible = False
                        cboADCN.Visible = False
                        cboDRNADCNStatus.Visible = False
                        cboDRNADCNIncorporatedBy.Visible = False
                        cboIncorporatedRev.Visible = False
                    End If
                Else
                    DrnAllowed = "True"
                    AdcnAllowed = "True"
                    'GridView5.Columns("DRN").Visible = True
                    cboDRN.Visible = True
                    cboADCN.Visible = True
                    cboDRNADCNStatus.Visible = True
                    cboDRNADCNIncorporatedBy.Visible = True
                    cboIncorporatedRev.Visible = True
                End If
            End If

            ds.Tables("DocumentType").Clear()
            ds.Tables("DocumentType").Dispose()
        End If
    End Function

    Public Function SearchUMApproval()
        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet251.tblDrawingCertUMApproval.Clear()

        'Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter3.SelectCommand.CommandText
        If Me.chkShowAllUMApprovals.Checked = True Then
            Me.SqlDataAdapter3.SelectCommand.CommandText() += SqlString + " Where DwgRecordID = '" & Val(Me.txtMainInfoRecordID.Text) & "'"
        Else
            Me.SqlDataAdapter3.SelectCommand.CommandText() += SqlString + " Where DwgRecordID = '" & Val(Me.txtMainInfoRecordID.Text) & "' and RequiredToApprove = 'True'"

        End If


        Try
            Me.SqlDataAdapter3.Fill(DataSet251.tblDrawingCertUMApproval)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter3.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet251.Tables("tblDrawingCertUMApproval").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            'Search = True

            'Create DataBindings
            'Me.txtRecordID.DataBindings.Add("Text",
            'Me.BindingSource2, "RecordID")

        Else
            'MsgBox("No Records Exist")
        End If
        GridView7.RefreshData()

    End Function

    Public Function SearchAttachments()
        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)


        Me.DataSet271.tblDrawingCertAttachments.Clear()

        Me.txtAttachRecordID.DataBindings.Clear()
        Me.txtFileDescription.DataBindings.Clear()
        Me.txtFilePath.DataBindings.Clear()
        Me.txtFileNameAttach.DataBindings.Clear()
        Me.cboConfigurationStatus.DataBindings.Clear()


        Dim cmdSave As String
        cmdSave = Me.SqlDataAdapter5.SelectCommand.CommandText
        Me.SqlDataAdapter5.SelectCommand.CommandText() += SqlString + " Where DwgRecordID = '" & Val(Me.txtMainInfoRecordID.Text) & "'"

        Try
            Me.SqlDataAdapter5.Fill(DataSet271.tblDrawingCertAttachments)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter5.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet271.Tables("tblDrawingCertAttachments").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            'Search = True

            'Create DataBindings
            Me.txtAttachRecordID.DataBindings.Add("Text",
            Me.bsSearchAttachments, "RecordID")
            Me.txtFileDescription.DataBindings.Add("Text",
            Me.bsSearchAttachments, "FileDescription")
            Me.txtFilePath.DataBindings.Add("Text",
           Me.bsSearchAttachments, "FilePath")
            Me.txtFileNameAttach.DataBindings.Add("Text",
           Me.bsSearchAttachments, "FileName")
            Me.cboConfigurationStatus.DataBindings.Add("Text",
           Me.bsSearchAttachments, "ConfigurationStatus")

        Else
            'MsgBox("No Records Exist")
        End If
    End Function

    Public Function SearchFAAOMTApproval()
        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet261.tblDrawingCertFAAOMTApproval.Clear()

        'Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter4.SelectCommand.CommandText
        If Me.chkShowAllFAAOMTApprovals.Checked = True Then
            Me.SqlDataAdapter4.SelectCommand.CommandText() += SqlString + " Where DwgRecordID = '" & Val(Me.txtMainInfoRecordID.Text) & "'"
        Else
            Me.SqlDataAdapter4.SelectCommand.CommandText() += SqlString + " Where DwgRecordID = '" & Val(Me.txtMainInfoRecordID.Text) & "' and RequiredToApprove = 'True'"
        End If

        Try
            Me.SqlDataAdapter4.Fill(DataSet261.tblDrawingCertFAAOMTApproval)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter4.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet261.Tables("tblDrawingCertFAAOMTApproval").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            'Search = True

            'Create DataBindings
            'Me.txtRecordID.DataBindings.Add("Text",
            'Me.BindingSource2, "RecordID")

        Else
            'MsgBox("No Records Exist")
        End If
    End Function

    Private Sub btnSaveUMApprovals_Click(sender As Object, e As EventArgs) Handles btnSaveUMApprovals.Click
        Me.SqlDataAdapter3.Update(DataSet251.tblDrawingCertUMApproval)
        Me.SqlDataAdapter4.Update(DataSet261.tblDrawingCertFAAOMTApproval)
        u.ExecuteSQL(SqlConnection1, "Update tblDrawingCert Set Status = '" & Me.cboCertificationReviewStatus.Text & "', Comments = '" & u.FTM(Me.txtComments.Text) & "' Where DwgRecordID = '" & Val(Me.txtMainInfoRecordID.Text) & "'")
        'Me.Close()
    End Sub

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
                MsgBox("Deletion of file was cancelled.", MsgBoxStyle.Information, "Drawing Workflow")
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

    Private Sub btnFileAttachSubmit_Click(sender As Object, e As EventArgs) Handles btnFileAttachSubmit.Click
        btnSaveNew.Visible = True
        Me.txtFileDescription.Text = ""
        Me.txtFilePath.Text = ""
        MsgBox("Fill in the description and browse for the file and click Save New")
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

            myRow("DwgRecordID") = Val(Me.txtMainInfoRecordID.Text)
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

    Private Sub btnSyncUMApprovals_Click(sender As Object, e As EventArgs) Handles btnSyncUMApprovals.Click
        Dim Sqlstr As String = "SELECT * FROM tblProgramCertificationUM Where Program = 'hsdfjshf'"
        da = New SqlClient.SqlDataAdapter("SELECT ProjectName from tblDrawingsProjects Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "'", SqlConnection1)
        da.Fill(ds, "LSTPROJS")

        If ds.Tables("LSTPROJS").Rows.Count > 0 Then

            Dim v As Integer = 0

            While v <= ds.Tables("LSTPROJS").Rows.Count - 1
                Sqlstr = Sqlstr + " Or Program = '" & ds.Tables("LSTPROJS").Rows(v).Item("ProjectName") & "'"

                v = v + 1
            End While

        End If

        Try
            ds.Tables("LSTPROJS").Clear()
            ds.Tables("LSTPROJS").Dispose()
        Catch ex As Exception

        End Try

        'da = New SqlClient.SqlDataAdapter("SELECT * FROM tblProgramCertificationUM Where Program = '" & Me.cboDetailsProgram.Text & "'", SqlConnection1)    'cboDetailsProgram will actually contain Program, so this is good 
        da = New SqlClient.SqlDataAdapter(Sqlstr, SqlConnection1)
        da.Fill(ds, "SYNCUM")


        Dim d As Integer = 0
        While d <= ds.Tables("SYNCUM").Rows.Count - 1

            da = New SqlClient.SqlDataAdapter("Select * from tbldrawingcertUMApproval Where UMName = '" & ds.Tables("SYNCUM").Rows(d).Item("Name") & "' and DwgRecordID = '" & Val(Me.txtMainInfoRecordID.Text) & "'", SqlConnection1)
            da.Fill(ds, "RA")

            If ds.Tables("RA").Rows.Count > 0 Then
            Else
                u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawingCertUMApproval (UMName, DWGRecordID, UMSpecialty, UMRecommendApproval, UMApproval, RequiredToApprove, Comments, DateSubmitted, DateNeeded, DateCommentsReturned) Values ('" & u.FTM(ds.Tables("SYNCUM").Rows(d).Item("Name")) & "', '" & Val(Me.txtMainInfoRecordID.Text) & "', '" & u.FTM(ds.Tables("SYNCUM").Rows(d).Item("UnitMemberSpecialty")) & "', 'Not Applicable', 'Not Submitted','False','', '01/01/1900', '01/01/1900', '01/01/1900')")
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


        Dim Sqlstr As String = "SELECT * FROM tblProgramCertificationFAAOMTMember Where Program = 'hsdfjshf'"
        da = New SqlClient.SqlDataAdapter("SELECT ProjectName from tblDrawingsProjects Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "'", SqlConnection1)
        da.Fill(ds, "LSTPROJS")

        If ds.Tables("LSTPROJS").Rows.Count > 0 Then

            Dim v As Integer = 0

            While v <= ds.Tables("LSTPROJS").Rows.Count - 1
                Sqlstr = Sqlstr + " Or Program = '" & ds.Tables("LSTPROJS").Rows(v).Item("ProjectName") & "'"

                v = v + 1
            End While

        End If

        Try
            ds.Tables("LSTPROJS").Clear()
            ds.Tables("LSTPROJS").Dispose()
        Catch ex As Exception

        End Try
        da = New SqlClient.SqlDataAdapter(Sqlstr, SqlConnection1)
        da.Fill(ds, "SYNCUM")


        Dim d As Integer = 0
        While d <= ds.Tables("SYNCUM").Rows.Count - 1

            da = New SqlClient.SqlDataAdapter("Select * from tbldrawingcertFAAOMTApproval Where FAAOMTName = '" & ds.Tables("SYNCUM").Rows(d).Item("Name") & "' and DwgRecordID = '" & Val(Me.txtMainInfoRecordID.Text) & "'", SqlConnection1)
            da.Fill(ds, "RA")
            If ds.Tables("RA").Rows.Count > 0 Then
            Else
                u.ExecuteSQL(SqlConnection1, "INSERT INTO tblDrawingCertFAAOMTApproval (FAAOMTName, DWGRecordID, FAAOMTSpecialty, FAAOMTRecommendApproval, FAAOMTApproval, RequiredToApprove, Comments) Values ('" & u.FTM(ds.Tables("SYNCUM").Rows(d).Item("Name")) & "', '" & Val(Me.txtMainInfoRecordID.Text) & "', '" & u.FTM(ds.Tables("SYNCUM").Rows(d).Item("FAAOMTMemberSpecialty")) & "', 'False',  '', 'False', '')")
            End If
            ds.Tables("RA").Clear()
            ds.Tables("RA").Dispose()
            d = d + 1
        End While
        ds.Tables("SYNCUM").Clear()
        ds.Tables("SYNCUM").Dispose()

        Me.SearchFAAOMTApproval()
    End Sub

    Private Sub chkShowAllUMApprovals_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowAllUMApprovals.CheckedChanged
        SearchUMApproval()
    End Sub

    Private Sub chkShowAllFAAOMTApprovals_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowAllFAAOMTApprovals.CheckedChanged
        Me.SearchFAAOMTApproval()
    End Sub

    Private Sub btnPercCompleteHelp_Click(sender As Object, e As EventArgs) Handles btnPercCompleteHelp.Click
        Dim frmPercentCompleteGuidance As New frmPercentCompleteGuidance
        frmPercentCompleteGuidance.Show()

    End Sub





    Private Sub FilterGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilterGridToolStripMenuItem.Click
        Dim frmcertgrid As New frmCertGrid
        frmcertgrid.Show()
    End Sub

    Public Function EnableAllFields()

        'ENABLE/DISABLE FIELDS
        cboMainRev.ReadOnly = False
        Me.txtmaininfotitle.ReadOnly = False
        'Me.dtmaininfoactualfinishdt.Enabled = True
        Me.cbomaininfodrafter.ReadOnly = False
        Me.cbomaininfosrengineer.ReadOnly = False
        Me.cbomaininfoStress.ReadOnly = False
        Me.cbomaininfoengineer.ReadOnly = False
        Me.cbomaininforeleaser.ReadOnly = False
        'dtmaininfodraftercomp.Enabled = True
        'Me.dtmaininfosrengcomp.Enabled = True
        'Me.dtmaininfoStressComp.Enabled = True
        'Me.dtmaininfoengcomp.Enabled = True
        'Me.dtmaininforeleasercomp.Enabled = True
        Me.cboDetailsProgram.ReadOnly = False
        Me.cboDetailsLocation.ReadOnly = False
        Me.cboDetailsDocumentType.ReadOnly = False
        Me.maskedDetailsDCN.ReadOnly = False
        'Me.txtDetailsNextAssemblyDrawing.ReadOnly = False
        Me.cboDetailsSystem.ReadOnly = False
        Me.cboDetailsResourceType.ReadOnly = False
        Me.txtDetailsInstallationDrawing.ReadOnly = False
        Me.txtNotesNotes.ReadOnly = False
        Me.cboDRN.ReadOnly = False
        Me.cboADCN.ReadOnly = False
        Me.cboDRNADCNStatus.Enabled = True
        Me.cboDRNADCNIncorporatedBy.Enabled = True
        Me.cboIncorporatedRev.Enabled = True
        Me.txtSchedWorkOrder.ReadOnly = False
        Me.dtSchedForecastStart.Enabled = True
        Me.dtSchedForecastFinish.Enabled = True
        Me.mskSchedDuration.ReadOnly = False
        Me.cboPercentComplete.Enabled = True
        Me.cboSchedMilestone.Enabled = True
        Me.cboSchedWhiteBoard.Enabled = True
        Me.cboSchedPercComp.Enabled = True

    End Function

    Public Function DisableAllFields()

        'ENABLE/DISABLE FIELDS
        cboMainRev.ReadOnly = True
        Me.txtmaininfotitle.ReadOnly = True
        'Me.dtmaininfoactualfinishdt.Enabled = False
        Me.cbomaininfodrafter.ReadOnly = True
        Me.cbomaininfosrengineer.ReadOnly = True
        Me.cbomaininfoStress.ReadOnly = True
        Me.cbomaininfoengineer.ReadOnly = True
        Me.cbomaininforeleaser.ReadOnly = True
        'dtmaininfodraftercomp.Enabled = False
        'Me.dtmaininfosrengcomp.Enabled = False
        'Me.dtmaininfoStressComp.Enabled = False
        'Me.dtmaininfoengcomp.Enabled = False
        'Me.dtmaininforeleasercomp.Enabled = False
        Me.cboDetailsProgram.ReadOnly = True
        Me.cboDetailsLocation.ReadOnly = True
        Me.cboDetailsDocumentType.ReadOnly = True
        Me.maskedDetailsDCN.ReadOnly = True
        Me.txtDetailsNextAssemblyDrawing.ReadOnly = True
        Me.cboDetailsSystem.ReadOnly = True
        Me.cboDetailsResourceType.ReadOnly = True
        Me.txtDetailsInstallationDrawing.ReadOnly = True
        Me.txtNotesNotes.ReadOnly = True
        Me.cboDRN.ReadOnly = True
        Me.cboADCN.ReadOnly = True
        Me.cboDRNADCNStatus.Enabled = False
        Me.cboDRNADCNIncorporatedBy.Enabled = False
        Me.cboIncorporatedRev.Enabled = False
        Me.txtSchedWorkOrder.ReadOnly = True
        Me.dtSchedForecastStart.Enabled = False
        Me.dtSchedForecastFinish.Enabled = False
        Me.mskSchedDuration.ReadOnly = True
        Me.cboPercentComplete.Enabled = False
        Me.cboSchedMilestone.Enabled = False
        Me.cboSchedWhiteBoard.Enabled = False
        Me.cboSchedPercComp.Enabled = False
    End Function

    Private Sub cboMainStatus_TextChanged(sender As Object, e As EventArgs) Handles cboMainStatus.TextChanged

        'ENABLE/DISABLE FIELDS, ETC WHEN AT THE DIFFERENT GATES

        If Me.cboMainStatus.Text = "GATE 6: Complete" Then
            'Me.cboSchedPercComp.Text = "100"     'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
            Me.cboPercentComplete.Text = "100"
            Me.cboPercentComplete.Enabled = False
            If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Or isDrafter = "T" Then

                'Enable Save
                Me.btnSave.Enabled = True
                Me.cboMainStatus.ReadOnly = False
                DisableAllFields()

            Else

                'Disable Save
                Me.btnSave.Enabled = False
                Me.cboMainStatus.ReadOnly = True
                DisableAllFields()
            End If

        ElseIf Me.cboMainStatus.Text = "GATE 0: CM Needs To Assign DWG Number" Then
            Me.cboPercentComplete.Items.Clear()
            Me.cboPercentComplete.Items.Add("0")
            Me.cboPercentComplete.Text = "0"

            EnableAllFields()
            Me.cboPercentComplete.Enabled = False
            Me.cboMainStatus.ReadOnly = False

        ElseIf Me.cboMainStatus.Text = "GATE 1: DWG Ready For Drafter" Then
            EnableAllFields()
            Me.cboMainStatus.ReadOnly = False

            Me.cboPercentComplete.Items.Clear()
            'Me.cboPercentComplete.Items.Add("0")       'Commented these 15 lines per Owen 09/22 email about PercentComplete not being what it is supposed to be
            'Me.cboPercentComplete.Items.Add("5")
            'Me.cboPercentComplete.Items.Add("10")
            'Me.cboPercentComplete.Items.Add("15")
            'Me.cboPercentComplete.Items.Add("20")
            'Me.cboPercentComplete.Items.Add("25")
            'Me.cboPercentComplete.Items.Add("30")
            'Me.cboPercentComplete.Items.Add("35")
            'Me.cboPercentComplete.Items.Add("40")
            'Me.cboPercentComplete.Items.Add("45")
            'Me.cboPercentComplete.Items.Add("50")
            'Me.cboPercentComplete.Items.Add("55")
            'Me.cboPercentComplete.Items.Add("60")
            'Me.cboPercentComplete.Items.Add("65")
            If Me.cboPercentComplete.Text = "" Then
                Me.cboPercentComplete.Text = "0"
            ElseIf Me.cboPercentComplete.Text = "0" Then
                Me.cboPercentComplete.Text = "0"
            Else
                Me.cboPercentComplete.Text = "65"
            End If
            'Me.cboPercentComplete.Text = "65"

        ElseIf Me.cboMainStatus.Text = "GATE 2: DWG Ready For Sr Engineer" Then
            EnableAllFields()
            Me.cboMainStatus.ReadOnly = False
            Me.cboPercentComplete.Items.Clear()
            Me.cboPercentComplete.Items.Add("70")
            Me.cboPercentComplete.Text = "70"
            Me.cboPercentComplete.Enabled = False
        ElseIf Me.cboMainStatus.Text = "GATE 3: DWG Ready For Operations" Then
            EnableAllFields()
            Me.cboMainStatus.ReadOnly = False
            Me.cboPercentComplete.Items.Clear()
            Me.cboPercentComplete.Items.Add("80")
            Me.cboPercentComplete.Text = "80"
            Me.cboPercentComplete.Enabled = False
        ElseIf Me.cboMainStatus.Text = "GATE 4: DWG Ready For Release" Then
            EnableAllFields()
            Me.cboMainStatus.ReadOnly = False
            Me.cboPercentComplete.Items.Clear()
            Me.cboPercentComplete.Items.Add("90")
            Me.cboPercentComplete.Text = "90"
            Me.cboPercentComplete.Enabled = False
        ElseIf Me.cboMainStatus.Text = "GATE 5: DWG Released" Then
            EnableAllFields()
            Me.cboMainStatus.ReadOnly = False
            Me.cboPercentComplete.Items.Clear()
            Me.cboPercentComplete.Items.Add("95")
            Me.cboPercentComplete.Text = "95"
            Me.cboPercentComplete.Enabled = False
        Else
            'Enable Save
            Me.btnSave.Enabled = True
            Me.cboMainStatus.ReadOnly = False
        End If


        'ENABLE/DISABLE FIELDS, ETC WHEN CANCELLED
        If Me.cboMainStatus.Text = "Cancelled" Then
            lblCanceled.Visible = True
            Me.txtMainDrawingNumber.BackColor = Color.Red
            Me.cboPercentComplete.Enabled = False
            Me.txtMainTitle.BackColor = Color.Red
            If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then

                'Enable Save
                Me.btnSave.Enabled = True
                Me.cboMainStatus.ReadOnly = False
                DisableAllFields()

            Else

                'Disable Save
                Me.btnSave.Enabled = False
                Me.cboMainStatus.ReadOnly = True
                DisableAllFields()
            End If
        Else
            lblCanceled.Visible = False
            Me.txtMainDrawingNumber.BackColor = Color.White
            Me.txtMainTitle.BackColor = Color.White
        End If


        'ENABLE/DISABLE FIELDS, ETC WHEN DELETED
        If Me.cboMainStatus.Text = "Obsolete" Then
            lblRecordDeleted.Visible = True
            Me.txtMainDrawingNumber.BackColor = Color.Red
            Me.cboPercentComplete.Enabled = False
            Me.txtMainTitle.BackColor = Color.Red
            If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then

                'Enable Save
                Me.btnSave.Enabled = True
                Me.cboMainStatus.ReadOnly = False
                DisableAllFields()

            Else

                'Disable Save
                Me.btnSave.Enabled = False
                Me.cboMainStatus.ReadOnly = True
                DisableAllFields()
            End If
        Else
            lblRecordDeleted.Visible = False
            Me.txtMainDrawingNumber.BackColor = Color.White
            Me.txtMainTitle.BackColor = Color.White
        End If


        'DRAWING NUMBER AND TITLE IF RECORD NOT EQUAL TO CANCELLED OR DELETED
        If Me.cboMainStatus.Text <> "Obsolete" And Me.cboMainStatus.Text <> "Cancelled" Then
            Me.txtMainDrawingNumber.BackColor = Color.White
            Me.txtMainTitle.BackColor = Color.White
        End If


        'initialStatus = cboMainStatus.Text
    End Sub

    Private Sub GridEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GridEditToolStripMenuItem.Click
        Dim frmEngWorkflowGridEdit As New frmEngWorkflowGridEdit
        frmEngWorkflowGridEdit.Show()
    End Sub

    'Private Sub ChangeDocumentNumberToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    ChangeDocNumber = Me.txtMainDrawingNumber.Text
    '    Dim frmEngWorkflowChangeDrawingNumber As New frmEngWorkflowChangeDrawingNumber
    '    documentType = Me.cboDetailsDocumentType.Text
    '    Title = Me.txtmaininfotitle.Text
    '    frmEngWorkflowChangeDrawingNumber.ShowDialog()

    '    If ChangeDocNumber <> "" Then
    '        Search()
    '    End If
    'End Sub

    Private Sub MDLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MDLToolStripMenuItem.Click
        Dim frmLiveMDL As New frmLiveMDL
        frmLiveMDL.Show()
    End Sub

    Private Sub frmEngWorkflow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GridControl1.MainView.SaveLayoutToXml(Path)

        'Save whatever it is selected in the View Combobox in a variable created in MyProject/Settings
        My.Settings.CboViewVariable = cboView.Text
    End Sub

    'This was the code for cboSchedPercComp masked textbox, which is now not used and therefore not visible
    'Private Sub cboSchedPercComp_Validating(sender As Object, e As CancelEventArgs) Handles cboSchedPercComp.Validating
    '    If cboSchedPercComp.Text > 100 Or cboSchedPercComp.Text < 0 Then
    '        MsgBox("Please enter a valid percent complete between 0 and 100.")
    '    End If
    'End Sub

    Private Sub txtMainProgram_TextChanged(sender As Object, e As EventArgs) Handles txtMainProgram.TextChanged

        da = New SqlClient.SqlDataAdapter("Select SystemDescription from tblSystemDescription Where Program = '" & Me.txtMainProjectName.Text & "' and Active = 'True' Order By SystemDescription Asc", SqlConnection1)
        da.Fill(ds, "GetSys")

        Me.cboDetailsSystem.Properties.Items.Clear()

        If ds.Tables("GetSys").Rows.Count > 0 Then
            Dim z As Integer = 0

            While z <= ds.Tables("GetSys").Rows.Count - 1
                Me.cboDetailsSystem.Properties.Items.Add(ds.Tables("GetSys").Rows(z).Item("SystemDescription"))
                z = z + 1
            End While

            ds.Tables("GetSys").Clear()
            ds.Tables("GetSys").Dispose()

        End If


        'cboDetailsProgram will actually contain Program, so this is good
        da = New SqlClient.SqlDataAdapter("Select Name from tblPriority Where Program = '" & Me.cboDetailsProgram.Text & "' and Active = 'True' Order By Name Asc", SqlConnection1)
        da.Fill(ds, "GetPriority")

        Me.cboSchedMilestone.Properties.Items.Clear()

        If ds.Tables("GetPriority").Rows.Count > 0 Then
            Dim z As Integer = 0

            While z <= ds.Tables("GetPriority").Rows.Count - 1
                Me.cboSchedMilestone.Properties.Items.Add(ds.Tables("GetPriority").Rows(z).Item("Name"))
                z = z + 1
            End While

            ds.Tables("GetPriority").Clear()
            ds.Tables("GetPriority").Dispose()

        End If
    End Sub

    Private Sub mskSchedDuration_Validating(sender As Object, e As CancelEventArgs) Handles mskSchedDuration.Validating
        If mskSchedDuration.Text < 0 Then
            MsgBox("Please enter a number greater than 0.")
        End If
    End Sub

    Private Sub txtSchedWorkOrder_Validating(sender As Object, e As CancelEventArgs) Handles txtSchedWorkOrder.Validating
        Me.txtSchedWorkOrder.Text = LTrim(Me.txtSchedWorkOrder.Text)
        Me.txtSchedWorkOrder.Text = RTrim(Me.txtSchedWorkOrder.Text)
    End Sub

    Private Sub cboADCN_Validating(sender As Object, e As CancelEventArgs) Handles cboADCN.Validating
        Me.cboADCN.Text = LTrim(Me.cboADCN.Text)
        Me.cboADCN.Text = RTrim(Me.cboADCN.Text)
    End Sub

    Private Sub txtmaininfotitle_Validated(sender As Object, e As EventArgs) Handles txtmaininfotitle.Validated
        Me.txtmaininfotitle.Text = UCase(Me.txtmaininfotitle.Text)
    End Sub

    Private Sub ProjectServerWorkflowSyncToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectServerWorkflowSyncToolStripMenuItem.Click
        Dim frmProjectWorkflowSync As New frmProjectWorkflowSync
        frmProjectWorkflowSync.Show()
    End Sub

    Private Sub cboDRNADCNStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDRNADCNStatus.SelectedIndexChanged

        'CANNOT CHANGE THESE COMBOBOXES IF NOT CM OR ADMIN
        'If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then

        'ENABLE/DISABLE DRN AND/OR ADCN
        'If record is not a DRN or ADCN disable the combos under DRN/ADCN tab
        If DrnCellValue <> "" Or AdcnCellValue <> "" Then
            If isGateSix <> "GATE 6: Complete" Then

                If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
                    cboDRN.Enabled = True
                    cboADCN.Enabled = True
                Else
                    cboDRN.Enabled = False
                    cboADCN.Enabled = False
                End If

                cboDRNADCNStatus.Enabled = True
                cboDRNADCNIncorporatedBy.Enabled = True
                cboIncorporatedRev.Enabled = True
            Else
                cboDRN.Enabled = False
                cboADCN.Enabled = False
                cboDRNADCNStatus.Enabled = False
                'cboDRNADCNIncorporatedBy.Enabled = False
                'cboIncorporatedRev.Enabled = False
            End If
        End If

        'Else
        'MsgBox("You cannot change the DRN/ADCN Status as you are not setup as an authorized user.")
        'cboDRNADCNStatus.Enabled = False
        'Exit Sub
        'End If


        'Adding this line of code because otherwise user gets an error when trying to make this combo equal to Incorporated for a record older than the latest one 
        'And that Is at gate 6
        AllowSignOffOpen = ""



        '***********************************CODE FOR INCORPORATED WAS HERE BEFORE MOVING IT IN THE SAVE BUTTON***********************************************************
        ''CANNOT SET VALUE TO INCORPORATED UNLESS DRAWING REVISION IS DRN OR ADCN AND AT GATE 6, AND ANOTHER DRAWING REVISION THAT IS NOT DRN OR ADCN IS AT GATE 0 TO 5
        'If cboDRNADCNStatus.Text = "Incorporated" Then

        '    Dim StatusSelectedRowForIncorporated As String

        '    Dim selectedRows() As Integer = GridView5.GetSelectedRows()
        '    For Each rowHandle As Integer In selectedRows
        '        If rowHandle >= 0 Then
        '            StatusSelectedRowForIncorporated = GridView5.GetRowCellValue(rowHandle, colStatusCol)
        '            'recorIDCurrentRecordSelected = GridView5.GetRowCellValue(rowHandle, colRecordID4)
        '        End If
        '    Next rowHandle

        '    '******************************************************************
        '    'Selected DRN or ADCN can be set to Incorporated after the below block of code: if latest revision is not at gate 6 and is not DRN or ADCN

        '    da = New SqlClient.SqlDataAdapter("Select Top 1 * from tblDrawings Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' Order By RecordID Desc", SqlConnection1)   'Order By Seq Desc
        '    da.Fill(ds, "DRNADCNStatus")
        '    Dim checkIfDRN As String = ds.Tables("DRNADCNStatus").Rows(0).Item("DRNADCN")
        '    Dim checkIfADCN As String = ds.Tables("DRNADCNStatus").Rows(0).Item("ADCN")
        '    'Dim recorIDLatestRevision As String = ds.Tables("DRNADCNStatus").Rows(0).Item("RecordID")
        '    'Dim statusLatestRevision As String = ds.Tables("DRNADCNStatus").Rows(0).Item("Status")
        '    Dim incorporateOfLatestRevision As String
        '    If IsDBNull(ds.Tables("DRNADCNStatus").Rows(0).Item("DRNADCNStatus")) Then
        '        incorporateOfLatestRevision = ""
        '    Else
        '        incorporateOfLatestRevision = ds.Tables("DRNADCNStatus").Rows(0).Item("DRNADCNStatus")
        '    End If
        '    Dim percentComplete As String = ds.Tables("DRNADCNStatus").Rows(0).Item("PercentComplete")

        '    'The next line is so that a recordd with DRN/ADCN that was set to Incorporated does not give the error following when the cursor is moved to it. Error was happening because a record was set to incorporated and the last revision was at gate 6(which it should not be at 6 when setting this record at incorporated, but after you would want the latest revision to be at 6 at some point
        '    'If recorIDCurrentRecordSelected = recorIDLatestRevision Then
        '    'If incorporateOfLatestRevision <> "" Or incorporateOfLatestRevision <> "Not Incorporated" Then 'And percentComplete = "100"  'And cboMainStatus.Enabled = False  'And checkIfDRN = "" And checkIfADCN = ""
        '    If checkIfDRN <> "" Or checkIfADCN <> "" Then
        '        If ds.Tables("DRNADCNStatus").Rows(0).Item("Status") = "GATE 6: Complete" Or checkIfDRN <> "" Or checkIfADCN <> "" Then
        '            'If statusLatestRevision <> "GATE 6: Complete" Then
        '            If MsgBox("Latest Revision must be at gate 0 to 5 and must not be a DRN or ADCN to set DRN/ADCN Status to Incorporated", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
        '                cboDRNADCNStatus.SelectedIndex = 1
        '                'cboDRNADCNStatus.SelectedIndex = -1
        '                ds.Tables("DRNADCNStatus").Clear()
        '                ds.Tables("DRNADCNStatus").Dispose()
        '            End If

        '            ds.Tables("DRNADCNStatus").Clear()
        '            ds.Tables("DRNADCNStatus").Dispose()
        '            Exit Sub



        '        Else
        '            ds.Tables("DRNADCNStatus").Clear()
        '            ds.Tables("DRNADCNStatus").Dispose()
        '        End If
        '        ds.Tables("DRNADCNStatus").Clear()
        '        ds.Tables("DRNADCNStatus").Dispose()
        '        '**********************************************************************************************
        '    End If

        '    ds.Tables("DRNADCNStatus").Clear()
        '    ds.Tables("DRNADCNStatus").Dispose()


        '    'Populate IncorporatedRev with next revision sequence(DocRev)
        '    PopulateIncorporatedRevWhenStatusIncorporated()
        'End If
    End Sub

    Public Function PopulateIncorporatedRevWhenStatusIncorporated()

        'Set Incorporated Rev on DRN/ADCN tab equal to the next revision, when the selected revision is at Gate 6 and the next one is between 1 and 5
        Dim StatusDRNADCNCellValue
        Dim NextRevision As Integer = -1
        Dim NextRevisionStatus As String = ""
        Dim RevisionSelectedLine As String = ""
        Dim RevisionValueToAssign As String = ""
        Dim IncorporatedRevForCombo As String = ""
        Dim StatusSelectedRow As String = ""

        Dim selectedRows() As Integer = GridView5.GetSelectedRows()
        For Each rowHandle As Integer In selectedRows
            If rowHandle >= 0 Then
                'Get status and revision of selected revision record
                StatusSelectedRow = GridView5.GetRowCellValue(rowHandle, colStatusCol)
            End If
        Next rowHandle


        If StatusSelectedRow = "GATE 6: Complete" Then
            da = New SqlClient.SqlDataAdapter("Select Top 1 * from vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' Order By Seq Desc", SqlConnection1)
            da.Fill(ds, "TOP")

            If ds.Tables("TOP").Rows(0).Item("Status") <> "GATE 6: Complete" Then
                Dim RevisionNextRecord As String = ds.Tables("TOP").Rows(0).Item("DwgRevision")
                If cboIncorporatedRev.Text = "" Then
                    cboIncorporatedRev.Text = RevisionNextRecord
                End If
            Else
                cboIncorporatedRev.SelectedIndex = -1
            End If

            ds.Tables("TOP").Clear()
            ds.Tables("TOP").Dispose()
        End If
    End Function

    Private Sub cboADCN_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles cboADCN.MaskInputRejected
        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            cboADCN.Enabled = True
        Else
            MsgBox("You cannot change the ADCN as you are not setup as an authorized user.")
            cboADCN.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub cboDRNADCNIncorporatedBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDRNADCNIncorporatedBy.SelectedIndexChanged

        'If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
        cboDRNADCNIncorporatedBy.Enabled = True
        'Else
        '    secondTime += 1
        '    If secondTime > 1 Then
        '        secondTime = 0
        '    Else
        '        MsgBox("You cannot change the DRN/ADCN Incorporated By as you are not setup as an authorized user.")
        '        cboDRNADCNIncorporatedBy.SelectedIndex = -1
        '        cboDRNADCNIncorporatedBy.Enabled = False
        '        Exit Sub
        '    End If
        'End If
    End Sub

    Private Sub AIMNumbersListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AIMNumbersListToolStripMenuItem.Click
        Dim frmAIMNumbersList As New frmEngWorkflowAIMNumbersList
        frmAIMNumbersList.ShowDialog()
    End Sub

    'AIM BUTTON FOR EXTERNAL USE
    'Private Sub btnAIMForExternalUse_Click(sender As Object, e As EventArgs) Handles btnAIMForExternalUse.Click

    '    'Code to assign an AIM number externally:  insert an AIM number first and then select it
    '    da = New SqlClient.SqlDataAdapter("Select Top 1 * from vwDrawingsRev Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' Order By Seq Desc", SqlConnection1)
    '    da.Fill(ds, "AIMForExternal")

    '    If ds.Tables("AIMForExternal").Rows(0).Item("Status") <> "GATE 6: Complete" Then
    '        MsgBox("Latest Revision must be at gate 6 to add a new revision or DRN.  Please advance the latest revision first.  New revision creation has been cancelled.")
    '        ds.Tables("AIMForExternal").Clear()
    '        ds.Tables("AIMForExternal").Dispose()
    '        Exit Sub
    '    Else
    '        u.ExecuteSQL(SqlConnection1, "INSERT into tblAIMNumbers (DrawingNumber) Values ('Assigned Externally')")

    '        da = New SqlClient.SqlDataAdapter("Select Top 1 AIM from tblAIMNumbers Order By AIM Desc", SqlConnection1)
    '        da.Fill(ds, "GetNextAIM")
    '        Dim AIMAssignedExternally As String = ds.Tables("GetNextAIM").Rows(0).Item("AIM")
    '        MsgBox("The AIM number assigned to you to use externally is: " & AIMAssignedExternally)
    '        ds.Tables("GetNextAIM").Clear()
    '        ds.Tables("GetNextAIM").Dispose()
    '    End If

    '    ds.Tables("AIMForExternal").Clear()
    '    ds.Tables("AIMForExternal").Dispose()
    'End Sub

    Private Sub btnBrowseAttachments_Click(sender As Object, e As EventArgs) Handles btnBrowseAttachments.Click
        Dim PathOfFile As String

        Me.OpenFileDialog2.InitialDirectory = "C:\"
        Me.OpenFileDialog2.Filter = "All files (*.*)|*.*"
        Me.OpenFileDialog2.FilterIndex = 1
        Me.OpenFileDialog2.RestoreDirectory = True

        If Me.OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Me.OpenFileDialog1.FileName
            Me.txtTargetAttach.Text = Me.OpenFileDialog2.FileName.ToString
            txtFileNameAttach.Text = System.IO.Path.GetFileName(OpenFileDialog2.FileName)
        End If
    End Sub

    Private Sub btnSaveAttachment_Click(sender As Object, e As EventArgs) Handles btnSaveAttachment.Click
        Dim Path1 As String
        '1.  Create a folder in the location referenced for the program. Folder name should be document number.  Only create if does not exist.
        'A.  Get the program path.
        da = New SqlClient.SqlDataAdapter("Select DocumentPath from tblProgram where ProgramName = '" & Me.txtMainProgram.Text & "'", SqlConnection1)
        da.Fill(ds, "DocPath")

        If ds.Tables("DocPath").Rows.Count = 0 Or ds.Tables("DocPath").Rows(0).Item("DocumentPath") = "" Then
            MsgBox("Cannot save record.  Document Path is not defined for the program yet.")
            Exit Sub

        Else
            Path1 = ds.Tables("DocPath").Rows(0).Item("DocumentPath") & "" & Me.txtMainDrawingNumber.Text
            If System.IO.Directory.Exists(Path1) = True Then
                'Save File to path1
                System.IO.File.Copy(Me.txtTargetAttach.Text, Path1)
            Else
                'Need to create folder
                System.IO.Directory.CreateDirectory(Path1)
                'Then need to copy file to path1
                System.IO.File.Copy(Me.txtTargetAttach.Text, Path1 & "\" & Me.txtFileNameAttach.Text)
            End If
        End If

        '3.  Update the target and other information on the attachment record.

        SqlConnection2.ConnectionString = sqlString
        u.ExecuteSQL(SqlConnection2, "INSERT into tblAttachments (DwgRecordID, Target, FileName, FileDescription) Values ('" & Val(RecordIDRevision) & "', '" & ds.Tables("DocPath").Rows(0).Item("DocumentPath") & "', '" & txtFileNameAttach.Text & "', '" & txtFieldDescriptionAttach.Text & "')")

        FillAttachmentsGridWithData()

        MsgBox("Saved")

        txtFileNameAttach.Text = ""
        txtTargetAttach.Text = ""
        txtFieldDescriptionAttach.Text = ""

    End Sub

    Private Sub btnDeleteAttach_Click(sender As Object, e As EventArgs) Handles btnDeleteAttach.Click

        Dim RecordIDCellValue As String

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "Confirm Delete", MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then

            Dim selectedRows() As Integer = GridView10.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    RecordIDCellValue = GridView10.GetRowCellValue(rowHandle, colRecordIDAttach)
                End If
            Next rowHandle

            SqlConnection2.ConnectionString = sqlString
            u.ExecuteSQL(SqlConnection2, "Delete From tblAttachments Where RecordID = " & RecordIDCellValue)
            FillAttachmentsGridWithData()
            MsgBox("Record Deleted")
        Else
            Exit Sub
        End If

    End Sub

    Private Sub cbomaininfoStress_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomaininfoStress.SelectedIndexChanged

        ''IF STRESS NAME = N/A THEN THE STRESS DATE SHOULD NOT BE ENABLED. ENABLE/DISABLE STRESS
        'If cbomaininfoStress.Text = "N/A" Then
        '    If cboMainStatus.Text = "GATE 3: DWG Ready For Operations" Then
        '        dtmaininfoStressComp.Value = "01/02/1900"
        '        dtmaininfoStressComp.Enabled = False
        '        StressDateDisabled = "Yes"
        '    End If
        'Else
        '    dtmaininfoStressComp.Enabled = True
        '    StressDateDisabled = "No"
        'End If
    End Sub

    Private Sub cboMainStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMainStatus.SelectedIndexChanged

        'Save the status of the revision, for use in the code that checks if the status/gate has been moved backward
        Dim selectedRows() As Integer = GridView5.GetSelectedRows()
        For Each rowHandle As Integer In selectedRows
            If rowHandle >= 0 Then
                initialStatus = GridView5.GetRowCellValue(rowHandle, colStatusCol)
                'InitialRecordIDForIncorporated = GridView5.GetRowCellValue(rowHandle, colRecordID)
            End If
        Next rowHandle

    End Sub

    Private Sub cboMainRev_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMainRev.SelectedIndexChanged

        MainRecordIDForSaveChanges = txtMainRecordID.Text


        Dim selectedRows() As Integer = GridView5.GetSelectedRows()
        For Each rowHandle As Integer In selectedRows
            If rowHandle >= 0 Then
                InitialRevValue = GridView5.GetRowCellValue(rowHandle, colDwgRevision1)
            End If
        Next rowHandle

    End Sub

    Private Sub maskedDetailsDCN_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles maskedDetailsDCN.MaskInputRejected
        'Cannot change DCN combobox if not CM or Admin
        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            maskedDetailsDCN.Enabled = True
        Else
            MsgBox("You cannot change DCN as you are not setup as an authorized user.")
            maskedDetailsDCN.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub GridView5_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView5.FocusedRowChanged

        'initialRowData = GridView5.GetFocusedDataRow


        '-----------------------------------------------------------------------------------------------------------------------------------
        'USED FOR SAVING FUNCTIONALITY: FOR SAVING REGULARLY  OR  SAVING WHEN THEY CHANGE SOMETHING AND FORGET TO SAVE
        If DataIsSaved = "No" Then
            If MsgBox("Would you like to save your changes before moving to another record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                SaveFrom = "SaveWithoutClickingSaveBtn"
                btnSave.PerformClick()
            End If
        End If
        '-----------------------------------------------------------------------------------------------------------------------------------



        ResetTextboxesColor()


        '-----------------------------------------------------------------------------------------------------------------------------------
        Dim selectedRows() As Integer = GridView5.GetSelectedRows()
        For Each rowHandle As Integer In selectedRows
            If rowHandle >= 0 Then
                'Used from the code that enables or disables combos under DRN/ADCN tab, based on record being DRN/ADCN or not
                If IsDBNull(GridView5.GetRowCellValue(rowHandle, colDRNADCN4)) Then
                    DrnCellValue = ""
                Else
                    DrnCellValue = GridView5.GetRowCellValue(rowHandle, colDRNADCN4)
                End If

                If IsDBNull(GridView5.GetRowCellValue(rowHandle, colADCN)) Then
                    AdcnCellValue = ""
                Else
                    AdcnCellValue = GridView5.GetRowCellValue(rowHandle, colADCN)
                End If

                'Next few lines get the RecordID and Status of the selected record. Then if the status is changed to something else, the code related to this in the save button executes
                RecordIDForIncorporated = GridView5.GetRowCellValue(rowHandle, colRecordID4)
                If IsDBNull(GridView5.GetRowCellValue(rowHandle, colStatusCol)) Then
                    InitialStatusForIncorporated = ""
                Else
                    InitialStatusForIncorporated = GridView5.GetRowCellValue(rowHandle, colStatusCol)
                End If

                'If not admin/CM/Drafter and record is at gate 6 save button is disabled
                If InitialStatusForIncorporated = "GATE 6: Complete" Then
                    If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Or isDrafter = "T" Then
                        btnSave.Enabled = True
                    Else
                        btnSave.Enabled = False
                    End If
                Else
                    btnSave.Enabled = True
                End If

            End If
        Next rowHandle
        '-----------------------------------------------------------------------------------------------------------------------------------


        '-----------------------------------------------------------------------------------------------------------------------------------
        'NEEDED TO GIVE A SEQUENCE NUMBER TO EACH STATUS. THIS WILL BE USED WHEN THE USER MOVES A RECORD TO A LOWER STATUS(WITH LOWER SEQUENCE NUMBER) 
        'BECAUSE WHEN THAT HAPPENS THE PROGRAM WILL NOT CHECK IF THE INCORPORATED FIELDS ARE POPULATED 
        GiveSequenceNumToInitialStatus()
        '-----------------------------------------------------------------------------------------------------------------------------------


        '-----------------------------------------------------------------------------------------------------------------------------------
        'IF RECORD IS NOT A DRN OR ADCN DISABLE THE COMBOS UNDER DRN/ADCN TAB. ENABLE/DISABLE FIELDS.
        If (DrnCellValue <> "" And DrnCellValue <> "0") Or (AdcnCellValue <> "" And AdcnCellValue <> "0") Then
            cboDRN.Enabled = True
            cboADCN.Enabled = True
            cboDRNADCNStatus.Enabled = True
            cboDRNADCNIncorporatedBy.Enabled = True
            cboIncorporatedRev.Enabled = True
        Else
            cboDRN.Enabled = False
            cboADCN.Enabled = False
            cboDRNADCNStatus.Enabled = False
            cboDRNADCNIncorporatedBy.Enabled = False
            cboIncorporatedRev.Enabled = False
        End If
        '-----------------------------------------------------------------------------------------------------------------------------------



        '-----------------------------------------------------------------------------------------------------------------------------------
        'DISABLE CONTROLS UNDER THE MAIN AND DRNADCN TABS IF
        'RECORDS HAVE DRN OR ADCN, ARE AT GATE 6 AND SET TO INCORPORATED
        'OR
        'RECORDS DO NOT HAVE DRN OR ADCN AND ARE AT GATE 6

        'First part of the IF runs for non-admin; DRN/ADCN records at gate 6 and set to incorporated
        If DisableControlsInMainAndDRNADCNTabs() = True Then
            If (isDRN <> "" Or isADCN <> "") And isGateSix = "GATE 6: Complete" And isIncorporated = "Incorporated" Then
                cboMainRev.Enabled = False
                cboMainStatus.Enabled = False
                txtmaininfotitle.Enabled = False
                'dtmaininfoactualfinishdt.Enabled = False
                cbomaininfodrafter.Enabled = False
                cbomaininfosrengineer.Enabled = False
                cbomaininfoStress.Enabled = False
                cbomaininfoengineer.Enabled = False
                cbomaininforeleaser.Enabled = False
                'dtmaininfodraftercomp.Enabled = False
                'dtmaininfosrengcomp.Enabled = False
                'dtmaininfoStressComp.Enabled = False
                'dtmaininfoengcomp.Enabled = False
                'dtmaininforeleasercomp.Enabled = False
                'cboDetailsProgram.Enabled = False
                cboDetailsLocation.Enabled = False
                cboDetailsDocumentType.Enabled = False
                maskedDetailsDCN.Enabled = False
                txtDetailsNextAssemblyDrawing.Enabled = False
                cboDetailsSystem.Enabled = False
                cboDetailsResourceType.Enabled = False
                txtDetailsInstallationDrawing.Enabled = False
                cboDRN.Enabled = False
                'cboADCN.Enabled = False
                cboDRNADCNStatus.Enabled = False
                cboDRNADCNIncorporatedBy.Enabled = False
                cboIncorporatedRev.Enabled = False
                txtSchedWorkOrder.Enabled = False
                dtSchedForecastStart.Enabled = False
                dtSchedForecastFinish.Enabled = False
                mskSchedDuration.Enabled = False
                'cboSchedPercComp.Enabled = False    'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
                cboPercentComplete.Enabled = False
                cboSchedMilestone.Enabled = False
                cboSchedWhiteBoard.Enabled = False
            Else
                'This part of the IF runs for non-admin; non-DRN/ADCN records at gate 6
                cboMainRev.Enabled = False
                cboMainStatus.Enabled = False
                txtmaininfotitle.Enabled = False
                'dtmaininfoactualfinishdt.Enabled = False
                cbomaininfodrafter.Enabled = False
                cbomaininfosrengineer.Enabled = False
                cbomaininfoStress.Enabled = False
                cbomaininfoengineer.Enabled = False
                cbomaininforeleaser.Enabled = False
                'dtmaininfodraftercomp.Enabled = False
                'dtmaininfosrengcomp.Enabled = False
                'dtmaininfoStressComp.Enabled = False
                'dtmaininfoengcomp.Enabled = False
                'dtmaininforeleasercomp.Enabled = False
                'cboDetailsProgram.Enabled = False
                cboDetailsLocation.Enabled = False
                cboDetailsDocumentType.Enabled = False
                maskedDetailsDCN.Enabled = False
                txtDetailsNextAssemblyDrawing.Enabled = False
                cboDetailsSystem.Enabled = False
                cboDetailsResourceType.Enabled = False
                txtDetailsInstallationDrawing.Enabled = False
                'cboDRN.Enabled = False
                'cboADCN.Enabled = False
                'cboDRNADCNStatus.Enabled = False
                'cboDRNADCNIncorporatedBy.Enabled = False
                'cboIncorporatedRev.Enabled = False
                txtSchedWorkOrder.Enabled = False
                dtSchedForecastStart.Enabled = False
                dtSchedForecastFinish.Enabled = False
                mskSchedDuration.Enabled = False
                'cboSchedPercComp.Enabled = False    'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
                cboPercentComplete.Enabled = False
                cboSchedMilestone.Enabled = False
                cboSchedWhiteBoard.Enabled = False
            End If
        Else
            'This part of the IF runs for non-admin(I think I make a mistake, this part is for admin); DRN/ADCN records at gate 6 and set to Not Incorporated
            If (isDRN <> "" Or isADCN <> "") And isGateSix = "GATE 6: Complete" And isIncorporated = "Not Incorporated" Then
                If ds.Tables("USERAUTHENTICATE").Rows.Count > 0 Then
                    If CM <> True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") <> "T" Then
                        cboMainRev.Enabled = False
                        cboMainStatus.Enabled = False
                        txtmaininfotitle.Enabled = False
                        'dtmaininfoactualfinishdt.Enabled = False
                        cbomaininfodrafter.Enabled = False
                        cbomaininfosrengineer.Enabled = False
                        cbomaininfoStress.Enabled = False
                        cbomaininfoengineer.Enabled = False
                        cbomaininforeleaser.Enabled = False
                        'dtmaininfodraftercomp.Enabled = False
                        'dtmaininfosrengcomp.Enabled = False
                        'dtmaininfoStressComp.Enabled = False
                        'dtmaininfoengcomp.Enabled = False
                        'dtmaininforeleasercomp.Enabled = False
                        'cboDetailsProgram.Enabled = False
                        cboDetailsLocation.Enabled = False
                        cboDetailsDocumentType.Enabled = False
                        maskedDetailsDCN.Enabled = False
                        txtDetailsNextAssemblyDrawing.Enabled = False
                        cboDetailsSystem.Enabled = False
                        cboDetailsResourceType.Enabled = False
                        txtDetailsInstallationDrawing.Enabled = False
                        cboDRN.Enabled = False      'Uncommented
                        'cboADCN.Enabled = False
                        cboDRNADCNStatus.Enabled = True
                        cboDRNADCNIncorporatedBy.Enabled = True
                        cboIncorporatedRev.Enabled = True
                        txtSchedWorkOrder.Enabled = False
                        dtSchedForecastStart.Enabled = False
                        dtSchedForecastFinish.Enabled = False
                        mskSchedDuration.Enabled = False
                        'cboSchedPercComp.Enabled = False    'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
                        cboPercentComplete.Enabled = False
                        cboSchedMilestone.Enabled = False
                        cboSchedWhiteBoard.Enabled = False
                    Else
                        'This part of the IF runs for admin; DRN/ADCN records at gate 6 and set to Not incorporated
                        cboMainRev.Enabled = False       'BEFORE 12/04/20 the below in this else was all set to False
                        cboMainStatus.Enabled = True
                        txtmaininfotitle.Enabled = False
                        'dtmaininfoactualfinishdt.Enabled = False
                        cbomaininfodrafter.Enabled = False
                        cbomaininfosrengineer.Enabled = False
                        cbomaininfoStress.Enabled = False
                        cbomaininfoengineer.Enabled = False
                        cbomaininforeleaser.Enabled = False
                        'dtmaininfodraftercomp.Enabled = False
                        ' dtmaininfosrengcomp.Enabled = False
                        'dtmaininfoStressComp.Enabled = False
                        ' dtmaininfoengcomp.Enabled = False
                        ' dtmaininforeleasercomp.Enabled = False
                        'cboDetailsProgram.Enabled = False
                        cboDetailsLocation.Enabled = False
                        cboDetailsDocumentType.Enabled = False
                        maskedDetailsDCN.Enabled = False
                        txtDetailsNextAssemblyDrawing.Enabled = False
                        cboDetailsSystem.Enabled = False
                        cboDetailsResourceType.Enabled = False
                        txtDetailsInstallationDrawing.Enabled = False
                        cboDRN.Enabled = False      'Uncommented
                        cboADCN.Enabled = False     'Uncommented
                        cboDRNADCNStatus.Enabled = True
                        cboDRNADCNIncorporatedBy.Enabled = True
                        cboIncorporatedRev.Enabled = True
                        txtSchedWorkOrder.Enabled = False
                        dtSchedForecastStart.Enabled = False
                        dtSchedForecastFinish.Enabled = False
                        mskSchedDuration.Enabled = False
                        'cboSchedPercComp.Enabled = True    'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
                        cboPercentComplete.Enabled = False
                        cboSchedMilestone.Enabled = False
                        cboSchedWhiteBoard.Enabled = False
                    End If
                End If

            ElseIf isGateSix = "GATE 6: Complete" And (isDRN <> "" Or isADCN <> "") Then
                cboMainRev.Enabled = False
                If CM <> True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") <> "T" Then
                    cboMainStatus.Enabled = False
                    If isIncorporated = "Not Incorporated" Then
                        cboDRNADCNStatus.Enabled = True
                        cboDRNADCNIncorporatedBy.Enabled = True
                        cboIncorporatedRev.Enabled = True
                    ElseIf isIncorporated = "Incorporated" Then
                        cboDRNADCNStatus.Enabled = False
                        cboDRNADCNIncorporatedBy.Enabled = False
                        cboIncorporatedRev.Enabled = False
                    End If
                Else
                    cboMainStatus.Enabled = True
                    cboDRNADCNStatus.Enabled = True
                    cboDRNADCNIncorporatedBy.Enabled = True
                    cboIncorporatedRev.Enabled = True
                End If
                txtmaininfotitle.Enabled = False
                'dtmaininfoactualfinishdt.Enabled = False
                cbomaininfodrafter.Enabled = False
                cbomaininfosrengineer.Enabled = False
                cbomaininfoStress.Enabled = False
                cbomaininfoengineer.Enabled = False
                cbomaininforeleaser.Enabled = False
                'dtmaininfodraftercomp.Enabled = False
                'dtmaininfosrengcomp.Enabled = False
                'dtmaininfoStressComp.Enabled = False
                'dtmaininfoengcomp.Enabled = False
                'dtmaininforeleasercomp.Enabled = False
                'cboDetailsProgram.Enabled = False
                cboDetailsLocation.Enabled = False
                cboDetailsDocumentType.Enabled = False
                maskedDetailsDCN.Enabled = False
                txtDetailsNextAssemblyDrawing.Enabled = False
                cboDetailsSystem.Enabled = False
                cboDetailsResourceType.Enabled = False
                txtDetailsInstallationDrawing.Enabled = False
                cboDRN.Enabled = False
                cboADCN.Enabled = False     'uncommented, all other cboADCN in these ifs are commented               
                txtSchedWorkOrder.Enabled = False
                dtSchedForecastStart.Enabled = False
                dtSchedForecastFinish.Enabled = False
                mskSchedDuration.Enabled = False
                'cboSchedPercComp.Enabled = False    'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
                cboPercentComplete.Enabled = False
                cboSchedMilestone.Enabled = False
                cboSchedWhiteBoard.Enabled = False

                'Prevent any changes if record is at Gate 6, except for Status for Admin and CM. Basically if it is not part of the Ifs and Elses above, a record at Gate 6 has the controls disabled except Status
            ElseIf isGateSix = "GATE 6: Complete" Or CheckIfRecordDeleted() = True Then  'ADDED FROM OWEN 11/30/20 EMAIL and 12/03/20 EMAIL
                cboMainRev.Enabled = False
                If CM <> True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") <> "T" Then
                    cboMainStatus.Enabled = False
                    cboDRNADCNStatus.Enabled = False
                    cboDRNADCNIncorporatedBy.Enabled = False
                    cboIncorporatedRev.Enabled = False
                Else
                    cboMainStatus.Enabled = True
                    'These 3 are here because only Admins can change when gate 6, is adcn and either incorporated or not incorporated. I placed the 3 lines here because the
                    'code goes here when the conditions just mentioned happen
                    If (isDRN = "" Or isDRN = "0") And (isADCN = "" Or isADCN = "0") Then
                        cboDRNADCNStatus.Enabled = False
                        cboDRNADCNIncorporatedBy.Enabled = False
                        cboIncorporatedRev.Enabled = False
                    End If
                End If
                txtmaininfotitle.Enabled = False
                ' dtmaininfoactualfinishdt.Enabled = False
                cbomaininfodrafter.Enabled = False
                cbomaininfosrengineer.Enabled = False
                cbomaininfoStress.Enabled = False
                cbomaininfoengineer.Enabled = False
                cbomaininforeleaser.Enabled = False
                ' dtmaininfodraftercomp.Enabled = False
                ' dtmaininfosrengcomp.Enabled = False
                ' dtmaininfoStressComp.Enabled = False
                ' dtmaininfoengcomp.Enabled = False
                '  dtmaininforeleasercomp.Enabled = False
                'cboDetailsProgram.Enabled = False
                cboDetailsLocation.Enabled = False
                cboDetailsDocumentType.Enabled = False
                maskedDetailsDCN.Enabled = False
                txtDetailsNextAssemblyDrawing.Enabled = False
                cboDetailsSystem.Enabled = False
                cboDetailsResourceType.Enabled = False
                txtDetailsInstallationDrawing.Enabled = False
                cboDRN.Enabled = False
                cboADCN.Enabled = False     'uncommented, all others in these ifs are commented
                'Next 3 were commented because inserted in the "If CM..." above
                'cboDRNADCNStatus.Enabled = False
                'cboDRNADCNIncorporatedBy.Enabled = False
                'cboIncorporatedRev.Enabled = False
                txtSchedWorkOrder.Enabled = False
                dtSchedForecastStart.Enabled = False
                dtSchedForecastFinish.Enabled = False
                mskSchedDuration.Enabled = False
                'cboSchedPercComp.Enabled = False    'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
                cboPercentComplete.Enabled = False
                cboSchedMilestone.Enabled = False
                cboSchedWhiteBoard.Enabled = False
            Else
                cboMainRev.Enabled = True
                cboMainStatus.Enabled = True
                txtmaininfotitle.Enabled = True
                '  dtmaininfoactualfinishdt.Enabled = True

                If dtmaininfodraftercomp.Value <> "01/01/1900" And dtmaininfodraftercomp.Value <> "01/01/2000" Then
                    Me.cbomaininfodrafter.Enabled = False
                Else
                    Me.cbomaininfodrafter.Enabled = True
                End If

                If dtmaininfosrengcomp.Value <> "01/01/1900" And dtmaininfosrengcomp.Value <> "01/01/2000" Then
                    cbomaininfosrengineer.Enabled = False
                Else
                    cbomaininfosrengineer.Enabled = True
                End If

                If dtmaininfoStressComp.Value <> "01/01/1900" And dtmaininfoStressComp.Value <> "01/01/2000" And cbomaininfoStress.Text <> "" Then
                    Me.cbomaininfoStress.Enabled = False
                ElseIf cbomaininfoStress.Text = "N/A" And dtmaininfosrengcomp.Value <> "01/01/1900" And dtmaininfosrengcomp.Value <> "01/01/2000" Then
                    Me.cbomaininfoStress.Enabled = False
                Else
                    Me.cbomaininfoStress.Enabled = True
                End If

                If dtmaininfoengcomp.Value <> "01/01/1900" And dtmaininfoengcomp.Value <> "01/01/2000" Then
                    cbomaininfoengineer.Enabled = False
                Else
                    cbomaininfoengineer.Enabled = True
                End If

                If dtmaininforeleasercomp.Value <> "01/01/1900" And dtmaininforeleasercomp.Value <> "01/01/2000" Then
                    cbomaininforeleaser.Enabled = False
                Else
                    cbomaininforeleaser.Enabled = True
                End If

                '  dtmaininfodraftercomp.Enabled = True
                ' dtmaininfosrengcomp.Enabled = True
                '  dtmaininfoStressComp.Enabled = True
                '  dtmaininfoengcomp.Enabled = True
                '  dtmaininforeleasercomp.Enabled = True
                cboDetailsProgram.Enabled = True
                cboDetailsLocation.Enabled = True
                cboDetailsDocumentType.Enabled = True
                maskedDetailsDCN.Enabled = True
                'txtDetailsNextAssemblyDrawing.Enabled = True
                cboDetailsSystem.Enabled = True
                cboDetailsResourceType.Enabled = True
                txtDetailsInstallationDrawing.Enabled = True
                'cboDRN.Enabled = True
                'cboADCN.Enabled = True
                'cboDRNADCNStatus.Enabled = True
                'cboDRNADCNIncorporatedBy.Enabled = True
                'cboIncorporatedRev.Enabled = True
                txtSchedWorkOrder.Enabled = True
                dtSchedForecastStart.Enabled = True
                dtSchedForecastFinish.Enabled = True
                mskSchedDuration.Enabled = True
                'cboSchedPercComp.Enabled = True    'Previous code instead of below line when I used the now hidden cboSchedPercComp masked textbox
                cboPercentComplete.Enabled = True
                cboSchedMilestone.Enabled = True
                cboSchedWhiteBoard.Enabled = True
            End If

            HighlightRedTextboxesWithDefaultDate()

        End If
    End Sub

    Function CheckIfRecordDeleted() As Boolean

        SqlConnection2.ConnectionString = sqlString

        da1 = New SqlClient.SqlDataAdapter("Select AIM from tblDrawings Where RecordId = '" & Val(Me.txtMainRecordID.Text) & "' And (RIGHT(AIM, 18) = 'Record Was Marked Obsolete')", SqlConnection2)
        da1.Fill(ds1, "CheckIfRecordDeleted")
        If ds1.Tables("CheckIfRecordDeleted").Rows.Count > 0 Then
            ds1.Tables("CheckIfRecordDeleted").Clear()
            ds1.Tables("CheckIfRecordDeleted").Dispose()
            Return True
        Else
            ds1.Tables("CheckIfRecordDeleted").Clear()
            ds1.Tables("CheckIfRecordDeleted").Dispose()
            Return False
        End If
    End Function

    Function DisableControlsInMainAndDRNADCNTabs() As Boolean

        'DISABLE CONTROLS UNDER THE MAIN AND DRNADCN TABS IF
        'RECORDS HAVE DRN OR ADCN, ARE AT GATE 6 AND SET TO INCORPORATED
        'OR
        'RECORDS DO NOT HAVE DRN OR ADCN AND ARE AT GATE 6.
        'ONLY FOR NON ADMIN

        Dim selectedRowsIncorporated() As Integer = GridView5.GetSelectedRows()
        For Each rowHandle As Integer In selectedRowsIncorporated
            If rowHandle >= 0 Then
                If IsDBNull(GridView5.GetRowCellValue(rowHandle, colDRNADCNStatus)) Then
                    isIncorporated = ""
                Else
                    isIncorporated = GridView5.GetRowCellValue(rowHandle, colDRNADCNStatus)
                End If
            End If
        Next rowHandle

        Dim selectedRowsDrnAdcnStatus() As Integer = GridView2.GetSelectedRows()
        For Each rowHandleTwo As Integer In selectedRowsDrnAdcnStatus
            If rowHandleTwo >= 0 Then
                If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colDRNADCN1)) Then
                    isDRN = ""
                Else
                    isDRN = GridView2.GetRowCellValue(rowHandleTwo, colDRNADCN1)
                End If

                If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colADCN2)) Then
                    isADCN = ""
                Else
                    isADCN = GridView2.GetRowCellValue(rowHandleTwo, colADCN2)
                End If

                If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colStatus1)) Then
                    isGateSix = ""
                Else
                    isGateSix = GridView2.GetRowCellValue(rowHandleTwo, colStatus1)
                End If
            End If
        Next rowHandleTwo


        'MAINLY THIS IS TO DISABLE COMBOBOXES AND TEXTBOXES IF NOT AN ADMIN, AND IF IT IS AN ADCN-DRN AT GATE 6 AND INCORPORATED
        If (isDRN <> "" Or isADCN <> "") And isGateSix = "GATE 6: Complete" And isIncorporated = "Incorporated" Then
            If ds.Tables("USERAUTHENTICATE").Rows.Count > 0 Then
                If CM <> True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") <> "T" Then
                    Return True     'Disable comboboxes and textboxes if condition above applies
                Else
                    Return False    'Enable Comboboxes and textboxes 
                End If
            Else
                Return True         'Disable Comboboxes and textboxes 
            End If


            'MAINLY THIS IS TO DISABLE COMBOBOXES AND TEXTBOXES IF NOT AN ADMIN, AND IF IT IS NOT AN ADCN-DRN AND AT GATE 6
        ElseIf (isDRN = "" Or isDRN = "0") And (isADCN = "" Or isADCN = "0") And isGateSix = "GATE 6: Complete" Then
            If ds.Tables("USERAUTHENTICATE").Rows.Count > 0 Then
                If CM <> True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") <> "T" Then
                    Return True     'Disable comboboxes and textboxes if condition above applies
                Else
                    Return False    'Enable Comboboxes and textboxes 
                End If
            Else
                Return True         'Disable Comboboxes and textboxes 
            End If


            'MAINLY THIS IS TO ENABLE COMBOBOXES AND TEXTBOXES IF NOT AN ADMIN
        Else
            Return False            'Enable comboboxes and textboxes
        End If

    End Function

    Function HighlightRedTextboxesWithDefaultDate()

        If cboMainStatus.Text = "GATE 1: DWG Ready For Drafter" Or cboMainStatus.Text = "GATE 2: DWG Ready For Sr Engineer" Or cboMainStatus.Text = "GATE 3: DWG Ready For Operations" Or cboMainStatus.Text = "GATE 4: DWG Ready For Release" Or cboMainStatus.Text = "GATE 5: DWG Released" Or cboMainStatus.Text = "GATE 6: Complete" Then
            If dtmaininfodraftercomp.Value = "01/01/1900" Or dtmaininfodraftercomp.Value = "01/01/2000" Then
                'Label9.ForeColor = Color.Red       'Commented per Owen 4/1/22 email
            Else
                Label9.ForeColor = Color.Black
            End If

            If cboMainStatus.Text = "GATE 2: DWG Ready For Sr Engineer" Or cboMainStatus.Text = "GATE 3: DWG Ready For Operations" Or cboMainStatus.Text = "GATE 4: DWG Ready For Release" Or cboMainStatus.Text = "GATE 5: DWG Released" Or cboMainStatus.Text = "GATE 6: Complete" Then
                If dtmaininfosrengcomp.Value = "01/01/1900" Or dtmaininfosrengcomp.Value = "01/01/2000" Then
                    'Label11.ForeColor = Color.Red      'Commented per Owen 4/1/22 email
                Else
                    Label11.ForeColor = Color.Black
                End If
            End If

            If cboMainStatus.Text = "GATE 3: DWG Ready For Operations" Or cboMainStatus.Text = "GATE 4: DWG Ready For Release" Or cboMainStatus.Text = "GATE 5: DWG Released" Or cboMainStatus.Text = "GATE 6: Complete" Then
                'Stress Date Label
                If dtmaininfoStressComp.Value = "01/01/1900" Or dtmaininfoStressComp.Value = "01/01/2000" Then
                    If cbomaininfoStress.Text = "N/A" Then
                        Label40.ForeColor = Color.Black
                    Else
                        'Label40.ForeColor = Color.Red      'Commented per Owen 4/1/22 email
                    End If
                Else
                    Label40.ForeColor = Color.Black
                End If
            End If

            If cboMainStatus.Text = "GATE 4: DWG Ready For Release" Or cboMainStatus.Text = "GATE 5: DWG Released" Or cboMainStatus.Text = "GATE 6: Complete" Then
                If dtmaininfoengcomp.Value = "01/01/1900" Or dtmaininfoengcomp.Value = "01/01/2000" Then
                    'Label10.ForeColor = Color.Red      'Commented per Owen 4/1/22 email
                Else
                    Label10.ForeColor = Color.Black
                End If
            End If

            If cboMainStatus.Text = "GATE 5: DWG Released" Or cboMainStatus.Text = "GATE 6: Complete" Then
                If dtmaininforeleasercomp.Value = "01/01/1900" Or dtmaininforeleasercomp.Value = "01/01/2000" Then
                    'Label12.ForeColor = Color.Red      'Commented per Owen 4/1/22 email
                Else
                    Label12.ForeColor = Color.Black
                End If
            End If

            If cboMainStatus.Text = "GATE 6: Complete" Then
                If dtmaininfoactualfinishdt.Value = "01/01/1900" Or dtmaininfoactualfinishdt.Value = "01/01/2000" Then
                    Label4.ForeColor = Color.Red
                Else
                    Label4.ForeColor = Color.Black
                End If
            End If
        End If
    End Function

    Function ResetTextboxesColor()
        Label9.ForeColor = Color.Black
        Label11.ForeColor = Color.Black
        Label40.ForeColor = Color.Black
        Label10.ForeColor = Color.Black
        Label12.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
    End Function

    Function GiveSequenceNumToInitialStatus()
        If InitialStatusForIncorporated = "GATE 0: CM Needs To Assign DWG Number" Then
            InitialSeqForIncorporated = 0
        ElseIf InitialStatusForIncorporated = "GATE 1: DWG Ready For Drafter" Then
            InitialSeqForIncorporated = 1
        ElseIf InitialStatusForIncorporated = "GATE 2: DWG Ready For Sr Engineer" Then
            InitialSeqForIncorporated = 2
        ElseIf InitialStatusForIncorporated = "GATE 3: DWG Ready For Operations" Then
            InitialSeqForIncorporated = 3
        ElseIf InitialStatusForIncorporated = "GATE 4: DWG Ready For Release" Then
            InitialSeqForIncorporated = 4
        ElseIf InitialStatusForIncorporated = "GATE 5: DWG Released" Then
            InitialSeqForIncorporated = 5
        ElseIf InitialStatusForIncorporated = "GATE 6: Complete" Then
            InitialSeqForIncorporated = 6
        ElseIf InitialStatusForIncorporated = "Obsolete" Then
            InitialSeqForIncorporated = 7
        End If
    End Function

    Function GiveSequenceNumToChangedToStatuses()
        If StatusChangedToForIncorporated = "GATE 0: CM Needs To Assign DWG Number" Then
            SeqChangedToForIncorporated = 0
        ElseIf StatusChangedToForIncorporated = "GATE 1: DWG Ready For Drafter" Then
            SeqChangedToForIncorporated = 1
        ElseIf StatusChangedToForIncorporated = "GATE 2: DWG Ready For Sr Engineer" Then
            SeqChangedToForIncorporated = 2
        ElseIf StatusChangedToForIncorporated = "GATE 3: DWG Ready For Operations" Then
            SeqChangedToForIncorporated = 3
        ElseIf StatusChangedToForIncorporated = "GATE 4: DWG Ready For Release" Then
            SeqChangedToForIncorporated = 4
        ElseIf StatusChangedToForIncorporated = "GATE 5: DWG Released" Then
            SeqChangedToForIncorporated = 5
        ElseIf StatusChangedToForIncorporated = "GATE 6: Complete" Then
            SeqChangedToForIncorporated = 6
        ElseIf StatusChangedToForIncorporated = "Cancelled" Then
            SeqChangedToForIncorporated = 7
        End If
    End Function

    Private Sub GridView2_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView2.RowStyle

        'GREY OUT RECORDS THAT HAVE DRN OR ADCN, ARE AT GATE 6 AND SET TO INCORPORATED
        'OR
        'GREY OUT RECORDS THAT DO NOT HAVE DRN OR ADCN AND ARE AT GATE 6
        Dim ViewForIncorporated As GridView = GridView5
        Dim isIncorporated As String = ViewForIncorporated.GetRowCellDisplayText(e.RowHandle, ViewForIncorporated.Columns("DRNADCNStatus"))

        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim isDRN As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("DRNADCN"))
            Dim isADCN As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ADCN"))
            Dim isGateSix As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))

            'If IsDBNull(StatusDRNADCNCellValue) Then
            If (isDRN <> "" Or isADCN <> "") And isGateSix = "GATE 6: Complete" And isIncorporated = "Incorporated" Then
                e.Appearance.BackColor = Color.Silver
            ElseIf (isDRN = "" Or isDRN = "0") And (isADCN = "" Or isADCN = "0") And isGateSix = "GATE 6: Complete" Then
                e.Appearance.BackColor = Color.Silver
            Else
                'Nothing
            End If

        End If

    End Sub

    Private Sub GridView3_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView3.RowStyle
        Dim isDRN As String
        Dim isADCN As String
        Dim isGateSix As String

        'GREY OUT RECORDS THAT HAVE DRN OR ADCN, ARE AT GATE 6 AND SET TO INCORPORATED
        'OR
        'GREY OUT RECORDS THAT DO NOT HAVE DRN OR ADCN AND ARE AT GATE 6
        Dim ViewForIncorporated As GridView = GridView5
        Dim isIncorporated As String = ViewForIncorporated.GetRowCellDisplayText(e.RowHandle, ViewForIncorporated.Columns("DRNADCNStatus"))

        Dim View3 As GridView = sender
        If (e.RowHandle >= 0) Then
            If IsDBNull(View3.GetRowCellDisplayText(e.RowHandle, View3.Columns("DRNADCN"))) Then
                isDRN = ""
            Else
                isDRN = View3.GetRowCellDisplayText(e.RowHandle, View3.Columns("DRNADCN"))
            End If
            If IsDBNull(View3.GetRowCellDisplayText(e.RowHandle, View3.Columns("ADCN"))) Then
                isADCN = ""
            Else
                isADCN = View3.GetRowCellDisplayText(e.RowHandle, View3.Columns("ADCN"))
            End If
            If IsDBNull(View3.GetRowCellDisplayText(e.RowHandle, View3.Columns("Status"))) Then
                isGateSix = ""
            Else
                isGateSix = View3.GetRowCellDisplayText(e.RowHandle, View3.Columns("Status"))
            End If

            'If IsDBNull(StatusDRNADCNCellValue) Then
            If (isDRN <> "" Or isADCN <> "") And isGateSix = "GATE 6: Complete" And isIncorporated = "Incorporated" Then
                e.Appearance.BackColor = Color.Silver
            ElseIf (isDRN = "" Or isDRN = "0") And (isADCN = "" Or isADCN = "0") And isGateSix = "GATE 6: Complete" Then
                e.Appearance.BackColor = Color.Silver
            Else
                'Nothing
            End If

        End If
    End Sub

    Private Sub GridView5_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView5.RowStyle

        'GREY OUT RECORDS THAT HAVE DRN OR ADCN, ARE AT GATE 6 AND SET TO INCORPORATED
        'OR
        'GREY OUT RECORDS THAT DO NOT HAVE DRN OR ADCN AND ARE AT GATE 6
        Dim ViewForIncorporated As GridView = GridView5
        Dim isIncorporated As String = ViewForIncorporated.GetRowCellDisplayText(e.RowHandle, ViewForIncorporated.Columns("DRNADCNStatus"))

        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim isDRN As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("DRNADCN"))
            Dim isADCN As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ADCN"))
            Dim isGateSix As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))

            'If IsDBNull(StatusDRNADCNCellValue) Then
            If (isDRN <> "" Or isADCN <> "") And isGateSix = "GATE 6: Complete" And isIncorporated = "Incorporated" Then
                e.Appearance.BackColor = Color.Silver
            ElseIf (isDRN = "" Or isDRN = "0") And (isADCN = "" Or isADCN = "0") And isGateSix = "GATE 6: Complete" Then
                e.Appearance.BackColor = Color.Silver
            Else
                'Nothing
            End If

        End If
    End Sub

    Private Sub GridView6_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView6.RowStyle

        'GREY OUT RECORDS THAT HAVE DRN OR ADCN, ARE AT GATE 6 AND SET TO INCORPORATED
        'OR
        'GREY OUT RECORDS THAT DO NOT HAVE DRN OR ADCN AND ARE AT GATE 6
        Dim ViewForIncorporated As GridView = GridView5
        Dim isIncorporated As String = ViewForIncorporated.GetRowCellDisplayText(e.RowHandle, ViewForIncorporated.Columns("DRNADCNStatus"))

        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim isDRN As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("DRNADCN"))
            Dim isADCN As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ADCN"))
            Dim isGateSix As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))

            'If IsDBNull(StatusDRNADCNCellValue) Then
            If (isDRN <> "" Or isADCN <> "") And isGateSix = "GATE 6: Complete" And isIncorporated = "Incorporated" Then
                e.Appearance.BackColor = Color.Silver
            ElseIf (isDRN = "" Or isDRN = "0") And (isADCN = "" Or isADCN = "0") And isGateSix = "GATE 6: Complete" Then
                e.Appearance.BackColor = Color.Silver
            Else
                'Nothing
            End If

        End If
    End Sub

    Private Sub cboMainRev_Modified(sender As Object, e As EventArgs) Handles cboMainRev.Modified

        'USED FOR SAVING FUNCTIONALITY: FOR SAVING REGULARLY  OR  SAVING WHEN THEY CHANGE SOMETHING AND FORGET TO SAVE
        If countForSave = 1 Then
            DataIsSaved = "No"
        End If

        'Get values textboxes and comboboxes were changed to
        RevForSave = cboMainRev.Text
        RecordIDForSave = Val(txtMainInfoRecordID.Text)

    End Sub

    Private Sub cboPercentComplete_GotFocus(sender As Object, e As EventArgs) Handles cboPercentComplete.GotFocus
        cboPercentComplete.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnSignOff_Click(sender As Object, e As EventArgs) Handles btnSignOff.Click

        DrafterSignOff = cbomaininfodrafter.Text
        SrEngineerSignOff = cbomaininfosrengineer.Text
        StressSignOff = cbomaininfoStress.Text
        OperationsSignOff = cbomaininfoengineer.Text
        ReleaserSignOff = cbomaininforeleaser.Text
        DrawNumForSignOff = txtMainDrawingNumber.Text


        'Get record selected in main grid so that, after the user is done with the SignOff form and it gets closed, the same record that was selected on the main form will still be selected
        RowSelectedUpperGrid = GridView1.FocusedRowHandle
        RowSelectedLowerGrid = GridView2.FocusedRowHandle


        If cboMainStatus.Text = "GATE 0: CM Needs To Assign DWG Number" Then
            MsgBox("Gate must be at 1 before starting to signoff")
            Exit Sub
        End If


        'When a user clicks the signoff button then allow the SignOff form to open if the gate status pre-existing was not equal to gate 0 or gate 1
        If initialStatus = "GATE 2: DWG Ready For Sr Engineer" Or initialStatus = "GATE 3: DWG Ready For Operations" Or initialStatus = "GATE 4: DWG Ready For Release" Or initialStatus = "GATE 5: DWG Released" Or initialStatus = "GATE 6: Complete" Then
            If initialStatus = cboMainStatus.Text Then
                AllowSignOffOpen = "Yes"
            Else
                AllowSignOffOpen = "No"
            End If
        Else
            AllowSignOffOpen = "No"
        End If


        'Do not allow to move to gate 2 if there are previous ADCN or DRN that were not set to Incorporated
        If cboMainStatus.Text = "GATE 1: DWG Ready For Drafter" Then
            da = New SqlClient.SqlDataAdapter("Select ADCN, DRNADCN, IncorporatedRev, * From tblDrawings Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And IncorporatedRev = '' And ((ADCN != '' And ADCN Is Not Null) Or (DRNADCN != '' And DRNADCN Is Not Null)) And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Cancelled' And Status != 'Deleted'", SqlConnection1)
            da.Fill(ds, "AllDrnAdcnAreIncorporated")
            If ds.Tables("AllDrnAdcnAreIncorporated").Rows.Count > 0 Then
                ds.Tables("AllDrnAdcnAreIncorporated").Clear()
                ds.Tables("AllDrnAdcnAreIncorporated").Dispose()

                If cboDRN.Text = "" And cboADCN.Text = "" Then      'Make the following message appear only if the record is not a DRN or ADCN
                    MsgBox("All previous ADCN/DRN must be set to Incorporated before moving record to GATE 2. Record will not be saved.")
                    Exit Sub
                End If
            End If
        End If


        Document = Val(Me.txtMainInfoRecordID.Text)
        btnSave.PerformClick()

        If CloseSignedOffForm = "Yes" Then  'Do not open the signed off form
            CloseSignedOffForm = "No"       'Reset the variable that decides if the signed off form should be opened or not
            'MsgBox("Fix the errors first before opening the sign off form")
        Else
            If OpenSignOffForm <> "No" Then
                Dim frmEngWorkflowSignOff As New frmEngWorkflowSignOff
                frmEngWorkflowSignOff.ShowDialog()
            End If

            'SearchMainInformation()

            'Added these 3 lines because after signing off if the Status filter was on then nothing would appear in the first grid and the second grid would have data 
            'from a different record, making it look Like there was no NextHigherAssembly
            Dim columnStatus As GridColumn = GridView1.Columns("Status")
            columnStatus.ClearFilter()
            btnRefresh.PerformClick()


            'Get number of tasks pending for the user after a signoff; to use in the main screen label
            GetNumberTasksPending()
            lblTasksPending.Text = TasksLabelText

            'Me.btnSave.PerformClick()      'BEFORE
        End If

        lblTasksPending.Text = TasksLabelText


        AllowSignOffOpen = Nothing


        EnablingRedLineAddBtn()


        'After the SignOff form closes, the same record that was selected before opening the SignOff form will be selected
        GridView1.FocusedRowHandle = RowSelectedUpperGrid
        GridView1.SelectRow(RowSelectedUpperGrid)
    End Sub

    Private Sub btnViewAttachment_Click(sender As Object, e As EventArgs) Handles btnViewAttachment.Click

        System.IO.File.Open(Me.txtFilePath.Text & "\" & Me.txtFileNameAttach.Text, FileMode.Open, FileAccess.Read)

        ''If Me.txtAttachRecordID.Text = "" Then
        ''    MsgBox("There are no files to view.", MsgBoxStyle.Information, "EARR APP")
        ''Else
        ''    DeleteTempFilesFromViewing()

        ''    da = New SqlClient.SqlDataAdapter("SELECT * FROM tblAttachments WHERE RecordID = '" & Me.txtAttachRecordID.Text & "'", SqlConnection1)
        ''    Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)

        ''    SqlConnection1.Open()

        ''    da.Fill(ds, "MyImages")
        ''    Dim myRow As DataRow
        ''    myRow = ds.Tables("MyImages").Rows(0)

        ''    Dim MyData() As Byte
        ''    MyData = myRow("ImgField")
        ''    Dim Extension As String
        ''    Extension = myRow("FileExt")

        ''    Dim K As Long
        ''    K = UBound(MyData)

        ''    Dim FileDest As String

        ''    'FileDest = Environment.SpecialFolder.MyDocuments.ToString + Format(Now, "MMddyyyyhhmmss") + "." + Extension
        ''    FileDest = "C:\Temp\" + Format(Now, "MMddyyyyhhmmss") + "." + Extension
        ''    Dim fs As New FileStream(FileDest, FileMode.OpenOrCreate, FileAccess.Write)
        ''    fs.Write(MyData, 0, K)
        ''    fs.Close()
        ''    fs = Nothing
        ''    MyCB = Nothing
        ''    ds.Tables("MyImages").Clear()

        ''    Process.Start(FileDest)

        ''    SqlConnection1.Close()
        ''End If
    End Sub

    Private Sub ReturnToMainMenuScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToMainMenuScreenToolStripMenuItem.Click
        Dim frmMain As New frmMain
        frmMain.Show()
        Me.Close()

    End Sub

    Public Function GetNumberTasksPending() As String

        Dim countTasksCMExcluded As Integer
        Dim ProgramsList As String
        Dim x As Integer = 0
        lblTasksPending.Text = ""
        TasksLabelText = ""
        SelectNotificationsView = ""

        SqlConnection1.ConnectionString = sqlString

        'Get the number of records the regular user has to still sign off
        If JaguarOnly = True Then
            'da = New SqlClient.SqlDataAdapter("Select * From vwDrawingsRev Where ((Drafter = '" & Id & "' and DrafterSignedOffBy = '') OR (SrEngineer = '" & Id & "' and SrEngineerSignedOffBy = '') OR (Stress = '" & Id & "' and StressSignedOffBy = '') OR (Engineer = '" & Id & "' and EngineerSignedOffBy = '') OR (Releaser = '" & Id & "' and ReleaserSignedOffBy = '')) And RecordID = RecordID And Status != 'Cancelled' And Status != 'Obsolete' AND Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = 'Jaguar' OR RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = '2635 – Jaguar' And Status != 'Cancelled' And Status != 'Deleted' OR RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = 'Jaguar - BE-1900D' And Status != 'Cancelled' And Status != 'Deleted' OR RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = '2640 - Missionized Interior MMSA-C (G550)' And Status != 'Cancelled' And Status != 'Deleted'", SqlConnection1)
            da = New SqlClient.SqlDataAdapter("Select * From (Select * From vwDrawingsRev Where Drafter = '" & Id & "' and DrafterSignedOffBy = '' UNION ALL Select * From vwDrawingsRev Where SrEngineer = '" & Id & "' and SrEngineerSignedOffBy = '' UNION ALL Select * From vwDrawingsRev Where Stress = '" & Id & "' and StressSignedOffBy = '' UNION ALL Select * From vwDrawingsRev Where Engineer = '" & Id & "' and EngineerSignedOffBy = '' UNION ALL Select * From vwDrawingsRev Where Releaser = '" & Id & "' and ReleaserSignedOffBy = '') A Where RecordID = RecordID And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' AND Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = 'Jaguar' OR RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = '2635 – Jaguar' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' OR RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = 'Jaguar - BE-1900D' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' OR RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = '2640 - Missionized Interior MMSA-C (G550)' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete'", SqlConnection1)
        Else
            'da = New SqlClient.SqlDataAdapter("Select * From vwDrawingsRev Where ((Drafter = '" & Id & "' and DrafterSignedOffBy = '') OR (SrEngineer = '" & Id & "' and SrEngineerSignedOffBy = '') OR (Stress = '" & Id & "' and StressSignedOffBy = '') OR (Engineer = '" & Id & "' and EngineerSignedOffBy = '') OR (Releaser = '" & Id & "' and ReleaserSignedOffBy = '')) And RecordID = RecordID And Status != 'Cancelled' And Status != 'Obsolete' And Status Not In ('GATE 6: Complete', 'GATE 9: Complete')", SqlConnection1)
            da = New SqlClient.SqlDataAdapter("Select * From (Select * From vwDrawingsRev Where Drafter = '" & Id & "' and DrafterSignedOffBy = '' UNION ALL Select * From vwDrawingsRev Where SrEngineer = '" & Id & "' and SrEngineerSignedOffBy = '' UNION ALL Select * From vwDrawingsRev Where Stress = '" & Id & "' and StressSignedOffBy = '' UNION ALL Select * From vwDrawingsRev Where Engineer = '" & Id & "' and EngineerSignedOffBy = '' UNION ALL Select * From vwDrawingsRev Where Releaser = '" & Id & "' and ReleaserSignedOffBy = '') A Where RecordID = RecordID And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' And Status Not In ('GATE 6: Complete', 'GATE 9: Complete')", SqlConnection1)
        End If
        da.Fill(ds, "TasksPending")

        If ds.Tables("TasksPending").Rows.Count > 0 Then
            TasksLabelText = ds.Tables("TasksPending").Rows.Count & " Task(s) Waiting for Action"
            lblTasksPending.Text = TasksLabelText
            countTasksCMExcluded = ds.Tables("TasksPending").Rows.Count     'To use in the block of code below, to sum regular user tasks to CM tasks, to get total

            'Select query for the Notifications view
            SelectNotificationsView = da.SelectCommand.CommandText
        Else
            lblTasksPending.Text = "0 Task(s) Waiting for Action"
            countTasksCMExcluded = 0
            SelectNotificationsView = ""
        End If

        ds.Tables("TasksPending").Clear()
        ds.Tables("TasksPending").Dispose()



        If CM = "True" Then

            'Verify the CM has the program of the record assigned to him/her. If it does get the program names he is on; to use in the next block of code to get number of records with sign-off pending for CM
            da = New SqlClient.SqlDataAdapter("Select Program From tblNotificationsGroups Where [User] = '" & Id & "'", SqlConnection1)
            da.Fill(ds, "UserPrograms")
            If ds.Tables("UserPrograms").Rows.Count > 0 Then
                For Each pr As DataRow In ds.Tables("UserPrograms").Rows
                    If ProgramsList = "" Then
                        'Nothing
                    Else
                        ProgramsList += ", "
                    End If
                    ProgramsList += "'" & ds.Tables("UserPrograms").Rows(x).Item("Program") & "'"
                    x += 1
                Next
            Else
                ProgramsList = "'0'"
            End If
            ds.Tables("UserPrograms").Clear()
            ds.Tables("UserPrograms").Dispose()
        End If


        'Verify it is a CM, if it is get the number of records with CM needed to sign off that are in one of the programs he/she takes care of,
        'plus all the other ones where it is his/her name but no signoff date
        If CM = "True" Then

            If JaguarOnly = True Then
                da = New SqlClient.SqlDataAdapter("Select * From vwDrawingsRev Where (ReleaserSignedOffBy != '' and CMSignedOffBy = '' And ProgramReal IN(" & ProgramsList & ")) And RecordID = RecordID And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' AND Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = 'Jaguar' OR RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = '2635 – Jaguar' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' OR RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = 'Jaguar - BE-1900D' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' OR RecordID = RecordID And Status Not In ('GATE 6: Complete', 'GATE 9: Complete') AND Program = '2640 - Missionized Interior MMSA-C (G550)' And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete'", SqlConnection1)
            Else
                da = New SqlClient.SqlDataAdapter("Select * From vwDrawingsRev Where (ReleaserSignedOffBy != '' and CMSignedOffBy = '' And ProgramReal IN(" & ProgramsList & ")) And RecordID = RecordID And Status != 'Cancelled' And Status != 'Canceled' And Status != 'Obsolete' And Status Not In ('GATE 6: Complete', 'GATE 9: Complete')", SqlConnection1)
            End If
            da.Fill(ds, "CMTasks")

            If ds.Tables("CMTasks").Rows.Count > 0 Then
                TasksLabelText = (Val(ds.Tables("CMTasks").Rows.Count) + countTasksCMExcluded) & " Task(s) Waiting for Action"
                lblTasksPending.Text = TasksLabelText
            Else
                If countTasksCMExcluded > 0 Then
                    lblTasksPending.Text = countTasksCMExcluded & " Task(s) Waiting for Action"
                Else
                    lblTasksPending.Text = "0 Task(s) Waiting for Action"
                End If
            End If

            'Select query for the Notifications view
            If SelectNotificationsView = "" Then
                SelectNotificationsView = da.SelectCommand.CommandText
            Else
                SelectNotificationsView += " UNION " & da.SelectCommand.CommandText
            End If



            countTasksCMExcluded = 0
            ds.Tables("CMTasks").Clear()
            ds.Tables("CMTasks").Dispose()
        End If


        ''Verify the CM has the program of the record assigned to him/her
        'da = New SqlClient.SqlDataAdapter("Select * From tblNotificationsGroups Where Program = '" & ProgramName & "' And [User] = '" & Id & "'", SqlConnection1)
        'da.Fill(ds, "ProgramAssign")
        'If ds.Tables("ProgramAssign").Rows.Count > 0 Then

        'End If

        'ds.Tables("ProgramAssign").Clear()
        'ds.Tables("ProgramAssign").Dispose()

    End Function


    'THIS IS TO MOVE THE GATE TO 4 AND SEND THE NOTIFICATION IF OPERATIONS IS SET TO N/A(SO THE SIGNOFF SCREEN AND BUTTON ARE NOT USED)
    Private Sub cbomaininfoengineer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomaininfoengineer.SelectedIndexChanged

        If cbomaininfoengineer.Text = "N/A" And cboMainStatus.Text = "GATE 3: DWG Ready For Operations" Then
            SqlConnection1.ConnectionString = sqlString
            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'GATE 4: DWG Ready For Release', Engineer = 'N/A', PercentComplete = '90' Where RecordID = '" & Val(Document) & "'")
            Search()
            'cbomaininfoengineer.Text = "N/A"
            DrawingNumForEmails = txtMainDrawingNumber.Text
            RevisionForEmails = cboMainRev.Text
            frmEngWorkflowSignOff.SendNotifications(4)

            'Put the focus on the rows that were selected (for upper and lower grids) before hitting the save button
            GridView1.FocusedRowHandle = RowSelectedUpperGrid
            GridView1.SelectRow(RowSelectedUpperGrid)
            GridView2.FocusedRowHandle = RowSelectedLowerGrid
            GridView2.SelectRow(RowSelectedLowerGrid)
        End If
    End Sub

    Private Sub btncancelobsolete_Click(sender As Object, e As EventArgs) Handles btncancelobsolete.Click

        '******Delete, now cancelled Code

        'Get the row the upper and lower grids were focused on so that after the delete code executes at the bottom of this Sub there is code to select the rows that were initially selected
        RowSelectedUpperGrid = GridView1.FocusedRowHandle
        RowSelectedLowerGrid = GridView2.FocusedRowHandle



        Dim AIMForDelete As String = ""

        If Me.cboMainStatus.Text = "GATE 6: Complete" Then

            If CM = True Then
                Dim result As DialogResult = MessageBox.Show("Please confirm you would like to oblsolete the current selected record.  You are obsoleting Drawing #" & Me.txtMainDrawingNumber.Text & ".",
                  "Title",
                  MessageBoxButtons.YesNo)

                If (result = DialogResult.Yes) Then

                    Dim frmEngWorkflowObsoleteRemarks As New frmEngWorkflowObsoleteRemarks
                    frmEngWorkflowObsoleteRemarks.ShowDialog()

                    If ObsoleteRemarks = "" Then
                        MsgBox("You left the obsolete remarks field blank.  Record will not be marked obsolete.")
                        Exit Sub
                    End If

                    AIMForDelete = ""




                    'u.ExecuteSQL(SqlConnection1, "DELETE from tblDrawings where RecordID =  '" & Val(txtMainInfoRecordID.Text) & "'")
                    u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set AIM = '" & AIMForDelete & " Record Was Marked Obsolete', Status = 'Obsolete', ObsoleteRemarks = '" & u.FTM(ObsoleteRemarks) & "' Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "'")
                    MsgBox("Drawing and all revisions of drawing have been marked obsolete.  The screen will now be refreshed.")
                    'Dim frmEngWorkflow As New frmEngWorkflow
                    'frmEngWorkflow.Show()
                    'Me.Close()


                    'Update tblTree ------------------------------------------------------------

                    'u.ExecuteSQL(SqlConnection1, "Update tblTree Set Status = 'Obsolete' Where DrawingNumOriginal = '" & Me.txtMainDrawingNumber.Text & "' Or DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "'")

                    da = New SqlClient.SqlDataAdapter("Select * From vwDrawingsRev where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq Desc, RecordID Desc", SqlConnection1)
                    da.Fill(ds, "CountRecordsDrawNum")
                    If ds.Tables("CountRecordsDrawNum").Rows.Count > 0 Then

                        If ds.Tables("CountRecordsDrawNum").Rows.Count > 0 Then

                            Dim SystemForObsolete As String
                            If IsDBNull(ds.Tables("CountRecordsDrawNum").Rows(0).Item("SystemDescription")) Then
                                SystemForObsolete = ""
                            Else
                                SystemForObsolete = ds.Tables("CountRecordsDrawNum").Rows(0).Item("SystemDescription")
                            End If

                            Dim StatusForObsolete As String = ds.Tables("CountRecordsDrawNum").Rows(0).Item("Status")
                            Dim DrawTitleForObsolete As String = ds.Tables("CountRecordsDrawNum").Rows(0).Item("DrawingTitle")
                            Dim RevForObsolete As String = ds.Tables("CountRecordsDrawNum").Rows(0).Item("DwgRevision")
                            Dim SeqForObsolete As String = ds.Tables("CountRecordsDrawNum").Rows(0).Item("Seq")

                            Dim NewReworkForObsolete As String
                            If IsDBNull(ds.Tables("CountRecordsDrawNum").Rows(0).Item("NewRework")) Then
                                NewReworkForObsolete = ""
                            Else
                                NewReworkForObsolete = ds.Tables("CountRecordsDrawNum").Rows(0).Item("NewRework")
                            End If

                            Dim DrawingOrReportForObsolete As String
                            If IsDBNull(ds.Tables("CountRecordsDrawNum").Rows(0).Item("DrawingOrReport")) Then
                                DrawingOrReportForObsolete = ""
                            Else
                                DrawingOrReportForObsolete = ds.Tables("CountRecordsDrawNum").Rows(0).Item("DrawingOrReport")
                            End If


                            'Update all the children rev
                            u.ExecuteSQL(SqlConnection1, "Update tblTree Set SystemDescription = '" & SystemForObsolete & "', Status = '" & StatusForObsolete & "', DrawingTitleChildren = '" & DrawTitleForObsolete & "', DwgRevision = '" & RevForObsolete & "', Seq = '" & SeqForObsolete & "', NewRework = '" & NewReworkForObsolete & "', DrawingOrReport = '" & DrawingOrReportForObsolete & "' Where DrawingNumOriginal = '" & Me.txtMainDrawingNumber.Text & "' And NextHigherAssembly != '' And NextHigherAssembly Is Not Null And NextHigherAssembly != 'N/A' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'")

                            ds.Tables("CountRecordsDrawNum").Clear()
                            ds.Tables("CountRecordsDrawNum").Dispose()
                        End If

                    ElseIf ds.Tables("CountRecordsDrawNum").Rows.Count <= 0 Then

                        u.ExecuteSQL(SqlConnection1, "Update tblTree Set Status = 'Obsolete' Where (DrawingNumOriginal = '" & Me.txtMainDrawingNumber.Text & "' Or DrawingNumber = '" & txtMainDrawingNumber.Text & "') And NextHigherAssembly != '' And NextHigherAssembly Is Not Null And NextHigherAssembly != 'N/A' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'")

                    End If
                    '--------------------------------------------------------------------------

                End If
            Else
                MsgBox("You cannot delete a record sitting at GATE 6.")
            End If

            ''Else
            ''    Dim result As DialogResult = MessageBox.Show("Please confirm you would like to delete the current selected record.  You are deleting revision:  " & Me.cboMainRev.Text & ".  Drawing #" & Me.txtMainDrawingNumber.Text & ".", "Title", MessageBoxButtons.YesNo)

            ''    If (result = DialogResult.Yes) Then

            ''        'Get AIM for below Update query
            ''        da = New SqlClient.SqlDataAdapter("Select AIM From tblDrawings where RecordID = '" & Val(txtMainInfoRecordID.Text) & "'", SqlConnection1)    'CHANGE DATABASE USED
            ''        da.Fill(ds, "AIMForDelete")

            ''        If ds.Tables("AIMForDelete").Rows.Count > 0 Then
            ''            If IsDBNull(ds.Tables("AIMForDelete").Rows(0).Item("AIM")) Then
            ''                AIMForDelete = ""
            ''            Else
            ''                AIMForDelete = ds.Tables("AIMForDelete").Rows(0).Item("AIM")
            ''            End If

            ''        Else
            ''            AIMForDelete = ""
            ''        End If

            ''        ds.Tables("AIMForDelete").Clear()
            ''        ds.Tables("AIMForDelete").Dispose()


            ''        'u.ExecuteSQL(SqlConnection1, "DELETE from tblDrawings where RecordID =  '" & Val(txtMainInfoRecordID.Text) & "'")
            ''        u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set AIM = '" & AIMForDelete & "  Record Was Marked Obsolete', Status = 'Obsolete' where RecordID = '" & Val(txtMainInfoRecordID.Text) & "'")
            ''        MsgBox("Record has been marked obsolete.  The screen will now be refreshed.")
            ''        'Dim frmEngWorkflow As New frmEngWorkflow
            ''        'frmEngWorkflow.Show()
            ''        'Me.Close()
            ''    End If
            ''End If



            'Put the focus on the rows that were selected (for upper and lower grids) before hitting the delete button
            GridView1.FocusedRowHandle = RowSelectedUpperGrid
            GridView1.SelectRow(RowSelectedUpperGrid)
            GridView2.FocusedRowHandle = RowSelectedLowerGrid
            GridView2.SelectRow(RowSelectedLowerGrid)


            'Highlight red record deleted label
            lblRecordDeleted.Visible = True


            'HighlightRedTextboxesWithDefaultDate()
        Else
            If CM = True Then
                Dim result As DialogResult = MessageBox.Show("Please confirm you would like to cancel the current selected record.  You are canceling Drawing #" & Me.txtMainDrawingNumber.Text & ". Revision " & Me.cboMainRev.Text & "",
                  "Title",
                  MessageBoxButtons.YesNo)

                If (result = DialogResult.Yes) Then

                    u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Status = 'Canceled' Where RecordID = '" & Val(Me.txtMainInfoRecordID.Text) & "'")


                    '------------------------------------------------------------------
                    ''Update tblTree

                    'u.ExecuteSQL(SqlConnection1, "Update tblTree Set Status = 'Cancelled' Where DrawingNumOriginal = '" & Me.txtMainDrawingNumber.Text & "' Or DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "'")

                    da = New SqlClient.SqlDataAdapter("Select * From vwDrawingsRev where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq Desc, RecordID Desc", SqlConnection1)
                    da.Fill(ds, "CountDrawNum")
                    If ds.Tables("CountDrawNum").Rows.Count > 0 Then

                        If ds.Tables("CountDrawNum").Rows.Count > 0 Then

                            Dim SystemForObsolete As String
                            If IsDBNull(ds.Tables("CountDrawNum").Rows(0).Item("SystemDescription")) Then
                                SystemForObsolete = ""
                            Else
                                SystemForObsolete = ds.Tables("CountDrawNum").Rows(0).Item("SystemDescription")
                            End If

                            Dim StatusForObsolete As String = ds.Tables("CountDrawNum").Rows(0).Item("Status")
                            Dim DrawTitleForObsolete As String = ds.Tables("CountDrawNum").Rows(0).Item("DrawingTitle")
                            Dim RevForObsolete As String = ds.Tables("CountDrawNum").Rows(0).Item("DwgRevision")
                            Dim SeqForObsolete As String = ds.Tables("CountDrawNum").Rows(0).Item("Seq")

                            Dim NewReworkForObsolete As String
                            If IsDBNull(ds.Tables("CountDrawNum").Rows(0).Item("NewRework")) Then
                                NewReworkForObsolete = ""
                            Else
                                NewReworkForObsolete = ds.Tables("CountDrawNum").Rows(0).Item("NewRework")
                            End If

                            Dim DrawingOrReportForObsolete As String
                            If IsDBNull(ds.Tables("CountDrawNum").Rows(0).Item("DrawingOrReport")) Then
                                DrawingOrReportForObsolete = ""
                            Else
                                DrawingOrReportForObsolete = ds.Tables("CountDrawNum").Rows(0).Item("DrawingOrReport")
                            End If

                            'Update all the children rev
                            u.ExecuteSQL(SqlConnection1, "Update tblTree Set SystemDescription = '" & SystemForObsolete & "', Status = '" & StatusForObsolete & "', DrawingTitleChildren = '" & DrawTitleForObsolete & "', DwgRevision = '" & RevForObsolete & "', Seq = '" & SeqForObsolete & "', NewRework = '" & NewReworkForObsolete & "', DrawingOrReport = '" & DrawingOrReportForObsolete & "' Where DrawingNumOriginal = '" & Me.txtMainDrawingNumber.Text & "' And NextHigherAssembly != '' And NextHigherAssembly Is Not Null And NextHigherAssembly != 'N/A' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'")

                            ds.Tables("CountDrawNum").Clear()
                            ds.Tables("CountDrawNum").Dispose()
                        End If

                    ElseIf ds.Tables("CountDrawNum").Rows.Count <= 0 Then

                        u.ExecuteSQL(SqlConnection1, "Update tblTree Set Status = 'Cancelled' Where (DrawingNumOriginal = '" & Me.txtMainDrawingNumber.Text & "' Or DrawingNumber = '" & txtMainDrawingNumber.Text & "') And NextHigherAssembly != '' And NextHigherAssembly Is Not Null And NextHigherAssembly != 'N/A' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'")

                    End If
                    '--------------------------------------------------------------------


                    Me.cboMainStatus.Text = "Canceled"
                    'btnSave.PerformClick()
                End If
            End If
        End If


        'Refresh the upper grid after canceling a record
        btnRefresh.PerformClick()

    End Sub

    Private Sub JASCCodesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JASCCodesToolStripMenuItem.Click
        Dim frmEngWorkflowJASCCodes As New frmEngWorkflowJASCCodes
        frmEngWorkflowJASCCodes.ShowDialog()
    End Sub

    Private Sub Level3DocTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Level3DocTypeToolStripMenuItem.Click
        Dim frmEngWorkflowLevelThreeDocType As New frmEngWorkflowLevelThreeDocType
        frmEngWorkflowLevelThreeDocType.ShowDialog()
    End Sub

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btnNumber.Click

        CreateOrModifyDocNum = "Modify"


        'GET RECORD ID, LOCATION, DOCUMENT TYPE AND CLASSIFICATION OF THE RECORD THAT WILL BE MODIFIED IN FORM B
        Dim a As Integer = 0
        Dim selectedRowsForUsingInFormB() As Integer = GridView2.GetSelectedRows()

        For Each rowHandleTwo As Integer In selectedRowsForUsingInFormB
            If rowHandleTwo >= 0 Then

                If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colRecordID)) Then
                    RecordIdDocNumToModify = ""
                Else
                    RecordIdDocNumToModify = GridView2.GetRowCellValue(rowHandleTwo, colRecordID)
                End If

                If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colDocumentType)) Then
                    DocTypeDocNumToModify = ""
                Else
                    DocTypeDocNumToModify = GridView2.GetRowCellValue(rowHandleTwo, colDocumentType)
                End If

                If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colLocation)) Then
                    LocationDocNumToModify = ""
                Else
                    LocationDocNumToModify = GridView2.GetRowCellValue(rowHandleTwo, colLocation)
                End If

                If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colSystemDescription)) Then
                    SystemDocNumToModify = ""
                Else
                    SystemDocNumToModify = GridView2.GetRowCellValue(rowHandleTwo, colSystemDescription)
                End If

                If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colDrawingTitle)) Then
                    TitleDocNumToModify = ""
                Else
                    TitleDocNumToModify = GridView2.GetRowCellValue(rowHandleTwo, colDrawingTitle)
                End If

                If IsDBNull(GridView3.GetRowCellValue(rowHandleTwo, colProgram)) Then
                    ProgramDocNumToModify = ""
                Else
                    ProgramDocNumToModify = GridView3.GetRowCellValue(rowHandleTwo, colProgram)     'This will actually be Project(contain project)
                End If

                If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colNextHigherAssembly)) Then
                    NextHigherAssemblyDocNumToModify = ""
                Else
                    NextHigherAssemblyDocNumToModify = GridView2.GetRowCellValue(rowHandleTwo, colNextHigherAssembly)
                End If

                If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colDrafter)) Then
                    DrafterDocNumToModify = ""
                Else
                    DrafterDocNumToModify = GridView2.GetRowCellValue(rowHandleTwo, colDrafter)
                End If

                If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colDrafter)) Then
                    DrafterDocNumToModify = ""
                Else
                    DrafterDocNumToModify = GridView2.GetRowCellValue(rowHandleTwo, colDrafter)
                End If

                If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colNewRework)) Then
                    ClassificationDocNumToModify = ""
                Else
                    ClassificationDocNumToModify = GridView2.GetRowCellValue(rowHandleTwo, colNewRework)
                End If

                If ClassificationDocNumToModify = "Rework Drawing" Then
                    NewReworkFormB = "New Drawing"
                    ClassificationDocNumToModify = "Drawing"
                ElseIf ClassificationDocNumToModify = "New Drawing" Then
                    NewReworkFormB = "New Drawing"
                    ClassificationDocNumToModify = "Drawing"
                ElseIf ClassificationDocNumToModify = "Rework Report" Then
                    NewReworkFormB = "New Report"
                    ClassificationDocNumToModify = "Report"
                ElseIf ClassificationDocNumToModify = "New Report" Then
                    NewReworkFormB = "New Report"
                    ClassificationDocNumToModify = "Report"
                End If

                If IsDBNull(GridView2.GetRowCellValue(rowHandleTwo, colDrawingNumber)) Then
                    DocNumberDocNumToModify = ""
                Else
                    DocNumberDocNumToModify = GridView2.GetRowCellValue(rowHandleTwo, colDrawingNumber)
                End If

                'Get Prefix.  To use in the ResetSequence in Form B
                If ClassificationDocNumToModify = "Drawing" And (LocationDocNumToModify = "Calgary" Or LocationDocNumToModify = "Toronto") Then
                    PrefixForCheckingReset = DocNumberDocNumToModify.Substring(DocNumberDocNumToModify.Length - 5)

                Else
                    PrefixForCheckingReset = DocNumberDocNumToModify.Substring(DocNumberDocNumToModify.Length - 4)

                    ''Get only numbers
                    'Dim nums As StringBuilder = New StringBuilder()
                    'For Each c As Char In PrefixForCheckingReset
                    '    If (Char.IsNumber(c)) Then
                    '        nums.Append(c)
                    '    End If
                    'Next
                    'PrefixForCheckingReset = nums.ToString

                End If

            End If
        Next rowHandleTwo


        'Get the selection that was made by the user for Level 3. To use in the ResetOrNot function. Also get the Resource Type to use in Form B in case modifying an existing doc number
        da = New SqlClient.SqlDataAdapter("Select DocTypeSelectedLevelThree,Type From tblDrawings Where RecordID = '" & RecordIdDocNumToModify & "'", SqlConnection1)
        da.Fill(ds, "DocTypeSelectedLevelThree")
        If ds.Tables("DocTypeSelectedLevelThree").Rows.Count > 0 Then
            If IsDBNull(ds.Tables("DocTypeSelectedLevelThree").Rows(0).Item("DocTypeSelectedLevelThree")) Then
                DocTypeSelectedLevelThree_DocNumToModify = ""
            Else
                DocTypeSelectedLevelThree_DocNumToModify = ds.Tables("DocTypeSelectedLevelThree").Rows(0).Item("DocTypeSelectedLevelThree")
            End If

            ResourceTypeDocNumToModify = ds.Tables("DocTypeSelectedLevelThree").Rows(0).Item("Type")
        End If
        ds.Tables("DocTypeSelectedLevelThree").Clear()
        ds.Tables("DocTypeSelectedLevelThree").Dispose()


        'Only allow to modify the selected record if user has permission And record has not been confirmed yet
        If isCM_LeadEng_Admin = "True" And IsDocNumConfirmed = "No" Then
            CreateOrModifyDocNum = "Modify"
            Dim frmEngWorkflowAddFormB As New frmEngWorkflowAddFormB
            frmEngWorkflowAddFormB.ShowDialog()

            Search()
        End If

    End Sub


    Private Sub btnShowTree_Click(sender As Object, e As EventArgs) Handles btnShowTree.Click
        'Dim result As DialogResult = MessageBox.Show("Display both drawings and reports?", "Title", MessageBoxButtons.YesNo)
        'If (result = DialogResult.Yes) Then
        '    DrawingsOnlyOrBoth = "DrawingsAndReports"
        'Else
        '    DrawingsOnlyOrBoth = "DrawingsOnly"
        'End If

        'UNCOMMENT 2 LINES BELOW
        'Dim frmEngWorkflowTree As New frmEngWorkflowTree
        'frmEngWorkflowTree.Show()

        ''DrawingsOnlyOrBoth = ""


        Dim result As DialogResult = MessageBox.Show("Display both drawings and reports?", "Title", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            DrawingsOnlyOrBoth = "DrawingsAndReports"
        Else
            DrawingsOnlyOrBoth = "DrawingsOnly"
        End If


        Dim frmEngWorkflowTree As New frmEngWorkflowTree
        frmEngWorkflowTree.Show()
        Me.Close()

        'DrawingsOnlyOrBoth = ""
    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Function PopulateDrawingsProjectsGrid()

        SqlConnection3.ConnectionString = sqlString

        'Clear previous data from DrawingsProjects grid if data already existed from before
        If IsNothing(ds.Tables("DrawingsProjects")) Then
            'nothing
        Else
            ds.Tables("DrawingsProjects").Clear()
            ds.Tables("DrawingsProjects").Dispose()
        End If


        Try
            'POPULATE DRAWINGS PROJECTS GRID WITH DATA
            'da = New SqlClient.SqlDataAdapter("Select * From tblDrawingsProjects Where RecordIDParent = '" & txtMainInfoRecordID.Text & "'", SqlConnection3)
            da = New SqlClient.SqlDataAdapter("Select * From tblDrawingsProjects Where DrawingNumber = '" & txtMainDrawingNumber.Text & "'", SqlConnection3)
            da.Fill(ds, "DrawingsProjects")
            Me.bsDrawingsProjects.DataSource = ds.Tables("DrawingsProjects")
            GridControl11.DataSource = Me.bsDrawingsProjects

            'Dim dsView As New DataView()
            'dsView = ds.Tables(0).DefaultView
            'bs.DataSource = dsView
            'GridControl1.DataSource = bs

            GridView11.Columns("RecordID").Visible = False
            GridView11.Columns("RecordIDParent").Visible = False
            GridView11.Columns("ProjectNumber").Visible = False
            GridView11.Columns("ProgramName").Visible = False
            GridView11.Columns("DrawingNumber").Visible = False
            'GridView1.Columns("PaymentNum").OptionsColumn.AllowEdit = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
        End Try


        'Populate Projects col dropdown inside the Projects grid
        RepositoryItemComboBox7.Items.Clear()

        da = New SqlClient.SqlDataAdapter("Select ProjectNumber + ' - ' + ProjectName ProjectName From tblProjects Where Active = 'True' Order By ProjectName", SqlConnection3)     'Where Program = '" & ProjectSelected & "' And Active = 1
        da.Fill(ds, "ProjectsForDrawingsProjects")

        Dim i As Integer = 0
        While i <= ds.Tables("ProjectsForDrawingsProjects").Rows.Count - 1
            RepositoryItemComboBox7.Items.Add(ds.Tables("ProjectsForDrawingsProjects").Rows(i).Item("ProjectName"))
            i = i + 1
        End While

        ds.Tables("ProjectsForDrawingsProjects").Clear()
        ds.Tables("ProjectsForDrawingsProjects").Dispose()


        'COMMENTED block of code below 08/04
        ''Populate System Description col dropdown inside the Projects grid
        'RepositoryItemComboBox6.Items.Clear()

        'da = New SqlClient.SqlDataAdapter("Select Distinct SystemDescription From tblSystemDescription Where Active = 1", SqlConnection3)     'Where Program = '" & ProjectSelected & "' And Active = 1
        'da.Fill(ds, "SystemsForDrawingsProjects")

        'Dim a As Integer = 0
        'While a <= ds.Tables("SystemsForDrawingsProjects").Rows.Count - 1
        '    RepositoryItemComboBox6.Items.Add(ds.Tables("SystemsForDrawingsProjects").Rows(a).Item("SystemDescription"))
        '    a = a + 1
        'End While

        'ds.Tables("SystemsForDrawingsProjects").Clear()
        'ds.Tables("SystemsForDrawingsProjects").Dispose()


        ''Populate Program col dropdown inside the Projects grid. It actually needs to be empty, they will not be able to select anything
        'RepositoryItemComboBox8.Items.Clear()

        'da = New SqlClient.SqlDataAdapter("Select '' As NoDataCol From tblDrawingsProjects", SqlConnection3)     'Where Program = '" & ProjectSelected & "' And Active = 1
        'da.Fill(ds, "ProgramForDrawingsProjects")

        'Dim d As Integer = 0
        'While d <= ds.Tables("ProgramForDrawingsProjects").Rows.Count - 1
        '    RepositoryItemComboBox8.Items.Add(ds.Tables("ProgramForDrawingsProjects").Rows(d).Item("NoDataCol"))
        '    d = d + 1
        'End While

        'ds.Tables("ProgramForDrawingsProjects").Clear()
        'ds.Tables("ProgramForDrawingsProjects").Dispose()

    End Function

    Private Sub btnSaveDrawingsProjects_Click(sender As Object, e As EventArgs) Handles btnSaveDrawingsProjects.Click

        '******---------------------------------------------------------------------------------------------------------
        'Per Owen, in this block of code what it also happens is: get Program names of where the project entered belong to. 
        'That is because when a new project is added and that belongs to two programs for example
        'then two records must be entered in tblDrawingsProjects:  Project 1 Program 1  AND  Project 1 Program 2
        '******---------------------------------------------------------------------------------------------------------


        'Dim RecordIDDrawingsProjectsSelected As String = ""
        Dim DrawingNumDrawingsProjectsSelected As String = ""
        'Dim RecordIDAssemblies As String = ""
        Dim DrawingNumberAssemblies As String = ""
        Dim ProjectAdded As String = ""
        Dim ProgramAdded As String = ""
        Dim SystemAdded As String = ""
        Dim ProgramNumber As String = ""
        Dim ProjectNames As String = ""
        Dim ProgramNumbers As String = ""
        Dim ProgramNames As String = ""
        Dim SystemNames As String = ""
        Dim ProjectNameToChange As String = ""
        Dim RecordIDProject As String = ""

        'WHEN SAVING GET THE ROW SELECTED FROM THE DRAWINGS AND MAIN GRIDS, SO THAT I CAN HAVE IT SELECTED AFTER ALL THE SAVE CODE IS EXECUTED
        RowSelectedDrawingsGrid = GridView1.FocusedRowHandle
        RowSelectedMainGrid = GridView2.FocusedRowHandle


        'ADD PROJECTS
        Me.daDrawingsProjects.Update(ds, "DrawingsProjects")


        'UPDATE PROJECT NUMBER OF THE PROJECTS JUST ADDED, SO IT IS NOT PROJECT NUMBER + PROJECT NAME BUT JUST PROJECT NUMBER
        da = New SqlClient.SqlDataAdapter("Select ProjectName, RecordID From tblDrawingsProjects Where DrawingNumber = '' Or DrawingNumber Is Null", SqlConnection3)
        da.Fill(ds, "ChangeProjectName")

        Dim s As Integer = 0
        While s <= ds.Tables("ChangeProjectName").Rows.Count - 1
            ProjectNameToChange = ds.Tables("ChangeProjectName").Rows(s).Item("ProjectName")
            RecordIDProject = ds.Tables("ChangeProjectName").Rows(s).Item("RecordID")

            If ProjectNameToChange = "" Then
                s += 1
                Continue While
            Else
                Dim index As Integer = ProjectNameToChange.IndexOf("-")
                ProjectNameToChange = ProjectNameToChange.Substring(index + 2)

                u.ExecuteSQL(SqlConnection3, "Update tblDrawingsProjects Set ProjectName = '" & ProjectNameToChange & "' Where RecordID = '" & RecordIDProject & "'")
                s += 1
            End If

        End While

        ds.Tables("ChangeProjectName").Clear()
        ds.Tables("ChangeProjectName").Dispose()



        Try

            'See if the project just added belongs to more than one program, in that case more records of other projects with the other programs are created
            da = New SqlClient.SqlDataAdapter("Select ProjectName, System From tblDrawingsProjects Where DrawingNumber = '' Or DrawingNumber Is Null", SqlConnection3)
            da.Fill(ds, "ProjectsInserted")

            Dim y As Integer = 0
            While y <= ds.Tables("ProjectsInserted").Rows.Count - 1

                ProjectNames = ds.Tables("ProjectsInserted").Rows(y).Item("ProjectName")
                If IsDBNull(ds.Tables("ProjectsInserted").Rows(y).Item("System")) Then
                    SystemNames = ""
                Else
                    SystemNames = ds.Tables("ProjectsInserted").Rows(y).Item("System")
                End If

                y = y + 1

                da = New SqlClient.SqlDataAdapter("Select Distinct ProgramNumber, ProgramName From tblProgram_Project Where ProjectName = '" & ProjectNames & "'", SqlConnection3)
                da.Fill(ds, "ProgramNumbersInitial")

                If ds.Tables("ProgramNumbersInitial").Rows.Count > 1 Then
                    Dim c As Integer = 0
                    While c <= ds.Tables("ProgramNumbersInitial").Rows.Count - 1
                        ProgramNumbers = ds.Tables("ProgramNumbersInitial").Rows(c).Item("ProgramNumber")
                        ProgramNames = ds.Tables("ProgramNumbersInitial").Rows(c).Item("ProgramName")
                        c = c + 1

                        u.ExecuteSQL(SqlConnection3, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber, ProgramName) Values ('" & ProjectNames & "', '" & SystemNames & "', '" & txtMainDrawingNumber.Text & "', '" & ProgramNumbers & "', '" & ProgramNames & "')")
                    End While

                ElseIf ds.Tables("ProgramNumbersInitial").Rows.Count = 1 Then
                    u.ExecuteSQL(SqlConnection3, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber, ProgramName) Values ('" & ProjectNames & "', '" & SystemNames & "', '" & txtMainDrawingNumber.Text & "', '" & ds.Tables("ProgramNumbersInitial").Rows(0).Item("ProgramNumber") & "', '" & ds.Tables("ProgramNumbersInitial").Rows(0).Item("ProgramName") & "')")
                Else
                    u.ExecuteSQL(SqlConnection3, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber) Values ('" & ProjectNames & "', '" & SystemNames & "', '" & txtMainDrawingNumber.Text & "', 'No Program Found')")
                End If


                ds.Tables("ProgramNumbersInitial").Clear()
                ds.Tables("ProgramNumbersInitial").Dispose()
            End While

            ds.Tables("ProjectsInserted").Clear()
            ds.Tables("ProjectsInserted").Dispose()


            'ADD PROJECTS TO CHILDREN
            If chbIncludeChildren.Checked = True Then

                'Get Drawing Numbers of the drawing numbers that have the Assembly field populated with the drawing number of the currently selected record.  
                'I will have to add the New projects to these drawing numbers as well
                da = New SqlClient.SqlDataAdapter("Select Distinct DrawingNumber from tblDrawings Where NextHigherAssembly = '" & txtMainDrawingNumber.Text & "'", SqlConnection3)
                da.Fill(ds, "DrawingNumbers")

                'If the drawing number does not have children jump to the GoTo
                If ds.Tables("DrawingNumbers").Rows.Count > 0 Then
                    'Nothing
                Else
                    u.ExecuteSQL(SqlConnection3, "DELETE From tblDrawingsProjects Where DrawingNumber = '' Or DrawingNumber Is Null")
                    GoTo ChildrenUncheckedOrNoChildren
                End If

                Dim p As Integer = 0
                While p <= ds.Tables("DrawingNumbers").Rows.Count - 1
                    DrawingNumberAssemblies = ds.Tables("DrawingNumbers").Rows(p).Item("DrawingNumber")
                    p = p + 1

                    'Get the projects just added that will be added to the assemblies(children) as well
                    da = New SqlClient.SqlDataAdapter("Select ProjectName, System from tblDrawingsProjects Where DrawingNumber = '' Or DrawingNumber Is Null", SqlConnection3)
                    da.Fill(ds, "ProjectsAdded")

                    Dim x As Integer = 0
                    While x <= ds.Tables("ProjectsAdded").Rows.Count - 1
                        If IsDBNull(ds.Tables("ProjectsAdded").Rows(x).Item("ProjectName")) Then
                            ProjectAdded = ""
                        Else
                            ProjectAdded = ds.Tables("ProjectsAdded").Rows(x).Item("ProjectName")
                        End If

                        If IsDBNull(ds.Tables("ProjectsAdded").Rows(x).Item("System")) Then
                            SystemAdded = ""
                        Else
                            SystemAdded = ds.Tables("ProjectsAdded").Rows(x).Item("System")
                        End If

                        x = x + 1

                        'Get Program names of where the projects belong to.  That is because when a new project is added and that belongs to two programs for example
                        'then two records must be entered:  Project 1 Program 1  AND  Project 1 Program 2
                        da = New SqlClient.SqlDataAdapter("Select Distinct ProgramNumber, ProgramName From tblProgram_Project Where ProjectName = '" & ProjectAdded & "'", SqlConnection3)
                        da.Fill(ds, "ProgramNumbers")

                        If ds.Tables("ProgramNumbers").Rows.Count > 1 Then
                            Dim z As Integer = 0
                            While z <= ds.Tables("ProgramNumbers").Rows.Count - 1
                                ProgramNumber = ds.Tables("ProgramNumbers").Rows(z).Item("ProgramNumber")
                                ProgramName = ds.Tables("ProgramNumbers").Rows(z).Item("ProgramName")
                                z = z + 1

                                u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber, ProgramName) Values ('" & ProjectAdded & "', '" & SystemAdded & "', '" & DrawingNumberAssemblies & "', '" & ProgramNumber & "', '" & ProgramName & "')")
                            End While

                        ElseIf ds.Tables("ProgramNumbers").Rows.Count = 1 Then
                            u.ExecuteSQL(SqlConnection3, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber, ProgramName) Values ('" & ProjectAdded & "', '" & SystemAdded & "', '" & DrawingNumberAssemblies & "', '" & ds.Tables("ProgramNumbers").Rows(0).Item("ProgramNumber") & "', '" & ds.Tables("ProgramNumbers").Rows(0).Item("ProgramName") & "')")
                        Else
                            u.ExecuteSQL(SqlConnection3, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber) Values ('" & ProjectAdded & "', '" & SystemAdded & "', '" & DrawingNumberAssemblies & "', 'No Program Found')")
                        End If

                        ds.Tables("ProgramNumbers").Clear()
                        ds.Tables("ProgramNumbers").Dispose()

                    End While

                    ds.Tables("ProjectsAdded").Clear()
                    ds.Tables("ProjectsAdded").Dispose()
                End While

                ds.Tables("DrawingNumbers").Clear()
                ds.Tables("DrawingNumbers").Dispose()

                'Following line the program deletes the initial projects that were created(the ones without a drawing number)
                'because they were re-created before the above if statement in case a project belonged to more than one program
                u.ExecuteSQL(SqlConnection3, "DELETE From tblDrawingsProjects Where DrawingNumber = '' Or DrawingNumber Is Null")

                'Enter the RecordID of the currently selected Drawing Number to the RecordIDParent of the projects just added
                u.ExecuteSQL(SqlConnection3, "Update tblDrawingsProjects Set DrawingNumber = '" & txtMainDrawingNumber.Text & "' Where DrawingNumber = '' Or DrawingNumber Is Null")

ChildrenUncheckedOrNoChildren:
            Else
                'Get the info from the projects just added. That will be used to see if the project belongs to other programs as well.
                'If it does then more records for the other project/program combination(s) are created
                da = New SqlClient.SqlDataAdapter("Select ProjectName, System from tblDrawingsProjects Where DrawingNumber = '' Or DrawingNumber Is Null", SqlConnection3)
                da.Fill(ds, "ProjectsAdded")

                Dim x As Integer = 0
                While x <= ds.Tables("ProjectsAdded").Rows.Count - 1
                    If IsDBNull(ds.Tables("ProjectsAdded").Rows(x).Item("ProjectName")) Then
                        ProjectAdded = ""
                    Else
                        ProjectAdded = ds.Tables("ProjectsAdded").Rows(x).Item("ProjectName")
                    End If

                    If IsDBNull(ds.Tables("ProjectsAdded").Rows(x).Item("System")) Then
                        SystemAdded = ""
                    Else
                        SystemAdded = ds.Tables("ProjectsAdded").Rows(x).Item("System")
                    End If

                    x = x + 1

                    'Get Program names of where the projects belong to.  That is because when a new project is added and that belongs to two programs for example
                    'then two records must be entered:  Project 1 Program 1  AND  Project 1 Program 2
                    da = New SqlClient.SqlDataAdapter("Select Distinct ProgramNumber, ProgramName From tblProgram_Project Where ProjectName = '" & ProjectAdded & "'", SqlConnection3)
                    da.Fill(ds, "ProgramNumbers")

                    Dim z As Integer = 0
                    While z <= ds.Tables("ProgramNumbers").Rows.Count - 1
                        ProgramNumber = ds.Tables("ProgramNumbers").Rows(z).Item("ProgramNumber")
                        ProgramName = ds.Tables("ProgramNumbers").Rows(z).Item("ProgramName")
                        z = z + 1

                        u.ExecuteSQL(SqlConnection1, "Insert into tblDrawingsProjects (ProjectName, System, DrawingNumber, ProgramNumber, ProgramName) Values ('" & ProjectAdded & "', '" & SystemAdded & "', '" & DrawingNumberAssemblies & "', '" & ProgramNumber & "', '" & ProgramName & "')")
                    End While

                    ds.Tables("ProgramNumbers").Clear()
                    ds.Tables("ProgramNumbers").Dispose()
                End While

                'Following line the program deletes the initial projects that were created
                'because they were re-created before the above if statement in case a project belonged to more than one program
                u.ExecuteSQL(SqlConnection3, "DELETE From tblDrawingsProjects Where DrawingNumber = '' Or DrawingNumber Is Null")

                'Enter the RecordID of the currently selected Drawing Number to the RecordIDParent of the projects just added (not sure I need the following line)
                u.ExecuteSQL(SqlConnection3, "Update tblDrawingsProjects Set DrawingNumber = '" & txtMainDrawingNumber.Text & "' Where DrawingNumber = '' Or DrawingNumber Is Null")


                ds.Tables("ProjectsAdded").Clear()
                ds.Tables("ProjectsAdded").Dispose()
            End If


            PopulateDrawingsProjectsGrid()


            '------ Save all the systems for this document number in its SystemDescription field
            UpdateSystemField()

            '------ Save all the projects for this document number in its Program(Project) field
            UpdateProjectField()

            '------ Save all programs for this document number in its ProgramReal(Program) field
            UpdateProgramField()


            MsgBox("Data Saved")
            Search()

        Catch ex As Exception
            MessageBox.Show("An error occured after clicking on Save." & vbLf & vbLf & ex.Message)
        End Try


        'Put the focus on the row that was selected, for the Drawings and Main grids, before hitting the save button
        GridView1.FocusedRowHandle = RowSelectedDrawingsGrid
        GridView1.SelectRow(RowSelectedDrawingsGrid)

        GridView2.FocusedRowHandle = RowSelectedMainGrid
        GridView2.SelectRow(RowSelectedMainGrid)

    End Sub

    Private Sub btnDeleteDrawingsProjects_Click(sender As Object, e As EventArgs) Handles btnDeleteDrawingsProjects.Click

        Dim RecordIDDrawingsProjectsSelected As Integer

        If IsDBNull(GridView11.GetRowCellValue(GridView11.FocusedRowHandle, "RecordID")) Then
            MsgBox("You must first save the project and then you can delete it")
            Exit Sub
        Else
            RecordIDDrawingsProjectsSelected = GridView11.GetRowCellValue(GridView11.FocusedRowHandle, "RecordID")
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected project?", "Title", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then

            u.ExecuteSQL(SqlConnection3, "Delete from tblDrawingsProjects Where RecordID = '" & RecordIDDrawingsProjectsSelected & "'")


            '------ Save all the systems for this document number in its SystemDescription field
            UpdateSystemField()

            '------ Save all the projects for this document number in its Program(Project) field
            UpdateProjectField()

            '------ Save all programs for this document number in its ProgramReal(Program) field
            UpdateProgramField()


            MsgBox("Project deleted.")
            Search()
        Else
            'Nothing
        End If

    End Sub

    Public Function UpdateSystemField()

        Dim Systems As String = ""

        '------ Save all the systems for this document number in its SystemDescription field
        da = New SqlClient.SqlDataAdapter("Select * From (SELECT RecordID, System, ROW_NUMBER() OVER (PARTITION BY System ORDER BY RecordID Desc) AS RowNumber FROM tblDrawingsProjects  Where DrawingNumber = '" & txtMainDrawingNumber.Text & "') As A WHERE RowNumber = 1 Order By RecordID Desc", SqlConnection3)
        da.Fill(ds, "Systems")

        If ds.Tables("Systems").Rows.Count > 0 Then
            Dim z As Integer = 0

            While z <= ds.Tables("Systems").Rows.Count - 1
                If Systems = "" Then
                    Systems = ds.Tables("Systems").Rows(z).Item("System")
                Else
                    Systems = Systems & ", " & ds.Tables("Systems").Rows(z).Item("System")
                End If

                z = z + 1
            End While

            ds.Tables("Systems").Clear()
            ds.Tables("Systems").Dispose()
        End If

        u.ExecuteSQL(SqlConnection3, "Update tblDrawings Set SystemDescription = '" & Systems & "' Where DrawingNumber = '" & txtMainDrawingNumber.Text & "'")

    End Function

    Public Function UpdateProjectField()

        Dim Projects As String = ""

        '------ Save all the projects for this document number in its Program(Project) field
        da = New SqlClient.SqlDataAdapter("Select * From (SELECT RecordID, ProjectName, ROW_NUMBER() OVER (PARTITION BY ProjectName ORDER BY RecordID Desc) AS RowNumber FROM tblDrawingsProjects  Where DrawingNumber = '" & txtMainDrawingNumber.Text & "') As A WHERE RowNumber = 1 Order By RecordID Desc", SqlConnection3)
        da.Fill(ds, "Projects")

        If ds.Tables("Projects").Rows.Count > 0 Then
            Dim z As Integer = 0

            While z <= ds.Tables("Projects").Rows.Count - 1
                If Projects = "" Then
                    Projects = ds.Tables("Projects").Rows(z).Item("ProjectName")
                Else
                    Projects = Projects & ", " & ds.Tables("Projects").Rows(z).Item("ProjectName")
                End If

                z = z + 1
            End While

            ds.Tables("Projects").Clear()
            ds.Tables("Projects").Dispose()
        End If

        u.ExecuteSQL(SqlConnection3, "Update tblDrawings Set Program = '" & Projects & "' Where DrawingNumber = '" & txtMainDrawingNumber.Text & "'")

    End Function

    Public Function UpdateProgramField()

        Dim Programs As String = ""

        '------ Save all the Programs for this document number in its ProgramReal(Program) field
        da = New SqlClient.SqlDataAdapter("Select * From (SELECT RecordID, ProgramName, ROW_NUMBER() OVER (PARTITION BY ProgramName ORDER BY RecordID Desc) AS RowNumber FROM tblDrawingsProjects  Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And ProgramName Is Not Null And ProgramName != '') As A WHERE RowNumber = 1 Order By RecordID Desc", SqlConnection3)
        da.Fill(ds, "UpdatePrograms")

        If ds.Tables("UpdatePrograms").Rows.Count > 0 Then
            Dim z As Integer = 0

            While z <= ds.Tables("UpdatePrograms").Rows.Count - 1

                If Programs = "" Then
                    Programs = ds.Tables("UpdatePrograms").Rows(z).Item("ProgramName")
                Else
                    Programs = Programs & ", " & ds.Tables("UpdatePrograms").Rows(z).Item("ProgramName")
                End If

                z = z + 1
            End While

            ds.Tables("UpdatePrograms").Clear()
            ds.Tables("UpdatePrograms").Dispose()
        End If

        u.ExecuteSQL(SqlConnection3, "Update tblDrawings Set ProgramReal = '" & Programs & "' Where DrawingNumber = '" & txtMainDrawingNumber.Text & "'")

    End Function


    '--------------------------------------------------------------------------------------------------------
    'ASSEMBLIES CODE
    Public Function PopulateAssembliesGrid()

        '*************************************************************************************************************
        '-------------------------------------------------------------------------------------------------------------
        '**************** NextHigherAssembly, DrawingNumber And DrawingTitle in tblTree contain info about the parent and is used in the Assembly grid of the Details tab
        '**************** DrawingNumOriginal, DwgRevision, DrawingTitleChildren, Status... contain info about the children and is used in the creation of the Tree
        '-------------------------------------------------------------------------------------------------------------
        '*************************************************************************************************************


        SqlConnection3.ConnectionString = sqlString

        'Clear previous data from Assemblies grid if data already existed from before
        If IsNothing(ds.Tables("Assemblies")) Then
            'nothing
        Else
            ds.Tables("Assemblies").Clear()
            ds.Tables("Assemblies").Dispose()
        End If


        Try
            'POPULATE ASSEMBLIES GRID WITH DATA
            da = New SqlClient.SqlDataAdapter("Select * From (Select ROW_NUMBER() OVER (PARTITION BY DrawingNumber ORDER BY RecordID desc) AS RowNumber, RecordID,RecordIDFromDrawings,DrawingNumber,DrawingNumOriginal,DocumentType,Priority,DwgReqDate,DrawingType,SystemDescription,Status,DrawingTitle,DwgRevision,DwgRevisionOriginal,NextHigherAssembly,ADCN,DCN,Seq,NewRework,DrawingOrReport From tblTree Where DrawingNumOriginal = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted') A WHERE RowNumber = 1 Order By DrawingNumber", SqlConnection3)    'And NextHigherAssembly != '' And NextHigherAssembly Is Not Null And NextHigherAssembly != 'N/A' 
            da.Fill(ds, "Assemblies")
            Me.bsAssemblies.DataSource = ds.Tables("Assemblies")
            GridControl12.DataSource = Me.bsAssemblies

            'Dim dsView As New DataView()
            'dsView = ds.Tables(0).DefaultView
            'bs.DataSource = dsView
            'GridControl1.DataSource = bs

            'GridView11.Columns("RecordID").Visible = False
            'GridView1.Columns("PaymentNum").OptionsColumn.AllowEdit = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
        End Try


        ''Populate Projects col dropdown inside the Projects grid
        'RepositoryItemComboBox7.Items.Clear()

        'da = New SqlClient.SqlDataAdapter("Select Distinct ProjectName From tblProjects Where Active = 'True'", SqlConnection3)     'Where Program = '" & ProjectSelected & "' And Active = 1
        'da.Fill(ds, "ProjectsForDrawingsProjects")

        'Dim i As Integer = 0
        'While i <= ds.Tables("ProjectsForDrawingsProjects").Rows.Count - 1
        '    RepositoryItemComboBox7.Items.Add(ds.Tables("ProjectsForDrawingsProjects").Rows(i).Item("ProjectName"))
        '    i = i + 1
        'End While

        'ds.Tables("ProjectsForDrawingsProjects").Clear()
        'ds.Tables("ProjectsForDrawingsProjects").Dispose()

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddAssembly.Click

        '*************************************************************************************************************
        '-------------------------------------------------------------------------------------------------------------
        '**************** NextHigherAssembly, DrawingNumber And DrawingTitle in tblTree contain info about the parent and is used in the Assembly grid of the Details tab
        '**************** DrawingNumOriginal, DwgRevision, DrawingTitleChildren, Status... contain info about the children and is used in the creation of the Tree
        '-------------------------------------------------------------------------------------------------------------
        '*************************************************************************************************************


        Dim SystemDesc As String = ""
        Dim StatusBrowse As String = ""
        Dim RevisionBrowse As String = ""
        Dim TitleChild As String = ""
        Dim Assembly As String = ""
        Dim SeqBrowse As String = ""
        Dim NewReworkBrowse As String = ""
        Dim DrawOrReportBrowse As String = ""
        Dim DwgReqDateBrowse As String = ""
        'Dim RecordIDBrowse As String = ""
        Dim recordIDForUpdate As String = ""

        SqlConnection3.ConnectionString = sqlString

        If txtDetailsNextAssemblyDrawing.Text = "" Then
            MsgBox("Select a drawing number from the Browse button first")
            Exit Sub
        End If

        'da = New SqlClient.SqlDataAdapter("Select RecordID,SystemDescription,Status,DwgRevision,Seq,NewRework,DrawingOrReport,DwgRequestDate From vwDrawingsRev Where RecordID = '" & RecordIDBrowse & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq Desc", SqlConnection3)
        da = New SqlClient.SqlDataAdapter("Select RecordID,SystemDescription,Status,DwgRevision,Seq,DrawingTitle,NewRework,DrawingOrReport,DwgRequestDate From vwDrawingsRev Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq Desc, RecordID Desc", SqlConnection3)
        da.Fill(ds, "AssemblyData")
        If ds.Tables("AssemblyData").Rows.Count > 0 Then

            If IsDBNull(ds.Tables("AssemblyData").Rows(0).Item("SystemDescription")) Then
                SystemDesc = ""
            Else
                SystemDesc = ds.Tables("AssemblyData").Rows(0).Item("SystemDescription")
            End If

            StatusBrowse = ds.Tables("AssemblyData").Rows(0).Item("Status")
            RevisionBrowse = ds.Tables("AssemblyData").Rows(0).Item("DwgRevision")
            SeqBrowse = ds.Tables("AssemblyData").Rows(0).Item("Seq")

            If IsDBNull(ds.Tables("AssemblyData").Rows(0).Item("DrawingTitle")) Then
                TitleChild = ""
            Else
                TitleChild = ds.Tables("AssemblyData").Rows(0).Item("DrawingTitle")
            End If
            'RecordIDBrowse = ds.Tables("AssemblyData").Rows(0).Item("RecordID")

            If IsDBNull(ds.Tables("AssemblyData").Rows(0).Item("DwgRequestDate")) Then
                DwgReqDateBrowse = ""
            Else
                DwgReqDateBrowse = ds.Tables("AssemblyData").Rows(0).Item("DwgRequestDate")
            End If

            If IsDBNull(ds.Tables("AssemblyData").Rows(0).Item("NewRework")) Then
                NewReworkBrowse = ""
            Else
                NewReworkBrowse = ds.Tables("AssemblyData").Rows(0).Item("NewRework")
            End If

            If IsDBNull(ds.Tables("AssemblyData").Rows(0).Item("DrawingOrReport")) Then
                DrawOrReportBrowse = ""
            Else
                DrawOrReportBrowse = ds.Tables("AssemblyData").Rows(0).Item("DrawingOrReport")
            End If

            If DrawOrReportBrowse = "Report" Or NewReworkBrowse = "Rework Report" Or NewReworkBrowse = "New Report" Then
                DrawOrReportBrowse = "Report"
                NewReworkBrowse = "Report"
            ElseIf DrawOrReportBrowse = "Drawing" Or NewReworkBrowse = "Rework Drawing" Or NewReworkBrowse = "New Drawing" Then
                DrawOrReportBrowse = "Drawing"
                NewReworkBrowse = "Drawing"
            End If

            'da = New SqlClient.SqlDataAdapter("Select RecordID From tblTree Where DrawingNumOriginal = '" & DocBrowse & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection3)
            'da.Fill(ds, "RecordIDForNextAssemblyField")
            'If ds.Tables("RecordIDForNextAssemblyField").Rows.Count > 0 Then
            '    Assembly = ds.Tables("RecordIDForNextAssemblyField").Rows(0).Item("RecordID")
            'Else
            '    MsgBox("Cannot find the RecordID of the record selected in the Browse screen")
            '    Exit Sub
            'End If

            'ds.Tables("RecordIDForNextAssemblyField").Clear()
            'ds.Tables("RecordIDForNextAssemblyField").Dispose()
        End If

        ds.Tables("AssemblyData").Clear()
        ds.Tables("AssemblyData").Dispose()

        u.ExecuteSQL(SqlConnection1, "INSERT into tblTree (DrawingNumber,DrawingTitle,DrawingNumOriginal,Status,DrawingTitleChildren,DwgRevision,Seq,NewRework,DrawingOrReport,SystemDescription) Values ('" & DocBrowse & "', '" & u.FTM(TitleBrowseAssembly) & "', '" & Me.txtMainDrawingNumber.Text & "', '" & StatusBrowse & "', '" & u.FTM(TitleChild) & "', '" & RevisionBrowse & "', '" & SeqBrowse & "', '" & NewReworkBrowse & "', '" & DrawOrReportBrowse & "', '" & SystemDesc & "')")


        ''If this record did not have any assemblies and now it does then populate the doc number NextHigherAssembly field
        'Dim checkIfThereAreAssemblies As String = GridView12.GetRowCellValue(GridView12.FocusedRowHandle, "DrawingTitle")
        'If checkIfThereAreAssemblies <> "" Then      'Without Assembly
        'u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set NextHigherAssembly = '" & DocBrowse & "' Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And (NextHigherAssembly = '' Or NextHigherAssembly Is Null) And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'")
        'End If

        ''10/14/21:  This substitues the block of code above(5 lines). It sets the NextHigherAssembly of the drawing number to the latest one added
        'u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set NextHigherAssembly = '" & DocBrowse & "' Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'")

        'Next line substitutes the line above. Now the NextHigherAssembly field will Not contain only the latest Assembly added but all related To the DrawingNumber selected
        UpdateAssembly()


        PopulateAssembliesGrid()

        txtDetailsNextAssemblyDrawing.Text = ""
    End Sub

    Public Function UpdateAssembly()

        Dim DrawingNumber As String = ""

        SqlConnection1.ConnectionString = sqlString

        'WHEN SAVING GET THE ROW SELECTED FROM THE UPPER AND LOWER GRIDS, SO THAT I CAN HAVE THEM SELECTED AFTER ALL THE SAVE CODE IS EXECUTED
        RowSelectedUpperGrid = GridView1.FocusedRowHandle
        RowSelectedLowerGrid = GridView2.FocusedRowHandle


        da = New SqlClient.SqlDataAdapter("Select * From (Select DrawingNumber, ROW_NUMBER() OVER (PARTITION BY DrawingNumber ORDER BY DrawingNumber) AS RowNumber From tblTree Where DrawingNumOriginal = '" & txtMainDrawingNumber.Text & "' And DrawingNumber != '' And DrawingNumber Is Not Null And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted') As A WHERE RowNumber = 1 Order By DrawingNumber", SqlConnection1)
        da.Fill(ds, "AssembliesToInsert")
        Dim z As Integer = 0

        While z <= ds.Tables("AssembliesToInsert").Rows.Count - 1

            If DrawingNumber = "" Then
                DrawingNumber = ds.Tables("AssembliesToInsert").Rows(z).Item("DrawingNumber")
                z += 1
                Continue While
            Else
                DrawingNumber = DrawingNumber & ", " & ds.Tables("AssembliesToInsert").Rows(z).Item("DrawingNumber")
                z += 1
            End If

        End While

        u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set NextHigherAssembly = '" & DrawingNumber & "' Where DrawingNumber = '" & txtMainDrawingNumber.Text & "'")

        DrawingNumber = ""
        ds.Tables("AssembliesToInsert").Clear()
        ds.Tables("AssembliesToInsert").Dispose()


        Search()


        'Put the focus on the rows that were selected (for upper and lower grids) before hitting the save button
        GridView1.FocusedRowHandle = RowSelectedUpperGrid
        GridView1.SelectRow(RowSelectedUpperGrid)
        GridView2.FocusedRowHandle = RowSelectedLowerGrid
        GridView2.SelectRow(RowSelectedLowerGrid)

    End Function

    Private Sub btnRemoveAssembly_Click(sender As Object, e As EventArgs) Handles btnRemoveAssembly.Click

        Dim DrawNumAssemblySelected As String = GridView12.GetRowCellValue(GridView12.FocusedRowHandle, "DrawingNumber")
        Dim TitleAssemblySelected As String = GridView12.GetRowCellValue(GridView12.FocusedRowHandle, "DrawingTitle")

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected Assembly?", "Title", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            u.ExecuteSQL(SqlConnection3, "Delete From tblTree Where DrawingNumber = '" & DrawNumAssemblySelected & "' And DrawingTitle = '" & TitleAssemblySelected & "' And DrawingNumOriginal = '" & txtMainDrawingNumber.Text & "'")
            MsgBox("Assembly deleted.")

            PopulateAssembliesGrid()
            'Search()


            'Next line substitutes the block Of code below. Now the NextHigherAssembly field will Not contain only the latest Assembly added but all related To the DrawingNumber selected
            UpdateAssembly()

            ''If there are no next assemblies set the drawing number's NextAssembly equal to empty, otherwise set it to the latest one
            'Dim checkIfThereAreAssemblies As String = GridView12.GetRowCellValue(GridView12.FocusedRowHandle, "DrawingTitle")
            'If IsNothing(checkIfThereAreAssemblies) = True Or checkIfThereAreAssemblies = "" Then      'Without Assembly
            '    u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set NextHigherAssembly = '' Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'")
            'Else

            '    Dim LatestAssembly As String

            '    da = New SqlClient.SqlDataAdapter("Select Top 1 * From tblTree Where DrawingNumOriginal = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By RecordID Desc", SqlConnection3)
            '    da.Fill(ds, "LatestAssembly")
            '    If ds.Tables("LatestAssembly").Rows.Count > 0 Then
            '        LatestAssembly = ds.Tables("LatestAssembly").Rows(0).Item("DrawingNumber")
            '    End If


            '    u.ExecuteSQL(SqlConnection3, "Update tblDrawings Set NextHigherAssembly = '" & LatestAssembly & "' Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' And (NextHigherAssembly <> '' Or NextHigherAssembly Is Not Null) And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'")
            '    'u.ExecuteSQL(SqlConnection3, "Update tblDrawings Set NextHigherAssembly = '' Where DrawingNumber = '" & DrawNumAssemblySelected & "' And DrawingTitle = '" & TitleAssemblySelected & "' And DrawingNumOriginal = '" & txtMainDrawingNumber.Text & "'")

            '    ds.Tables("LatestAssembly").Clear()
            '    ds.Tables("LatestAssembly").Dispose()
            'End If
        Else
            'Nothing
        End If

    End Sub

    Private Sub btnShowAssembly_Click(sender As Object, e As EventArgs) Handles btnShowAssembly.Click

        ShowAssemblyClicked = "Yes"

        'Show record selected in Assembly grid  
        DrawingNumFromAssembly = GridView12.GetRowCellValue(GridView12.FocusedRowHandle, "DrawingNumber")
        Search()
        GridView1.ClearColumnsFilter()

        ShowAssemblyClicked = ""
        DrawingNumFromAssembly = ""
    End Sub



    '---------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub GridView11_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView11.CellValueChanged

        Dim projectForSystem As String = ""
        projectForSystem = GridView11.GetRowCellValue(e.RowHandle, GridView11.Columns("ProjectName")).ToString()


        'Get Project Number to use to select the System in the Details tab, SO IT IS NOT PROJECT NUMBER + PROJECT NAME BUT JUST PROJECT NUMBER
        Dim index As Integer = projectForSystem.IndexOf("-")
        projectForSystem = projectForSystem.Substring(index + 2)


        'Populate System Description col dropdown inside the Projects grid
        RepositoryItemComboBox6.Items.Clear()

        da = New SqlClient.SqlDataAdapter("Select Distinct SystemDescription From tblSystemDescription Where Program = '" & projectForSystem & "' And Active = 1", SqlConnection3)     'Where Program = '" & ProjectSelected & "' And Active = 1
        da.Fill(ds, "SystemsForDrawingsProjects")

        Dim a As Integer = 0
        While a <= ds.Tables("SystemsForDrawingsProjects").Rows.Count - 1
            RepositoryItemComboBox6.Items.Add(ds.Tables("SystemsForDrawingsProjects").Rows(a).Item("SystemDescription"))
            a = a + 1
        End While

        ds.Tables("SystemsForDrawingsProjects").Clear()
        ds.Tables("SystemsForDrawingsProjects").Dispose()
    End Sub


    'Clear the System dropdown in the Details tab
    Private Sub GridView11_RowCountChanged(sender As Object, e As EventArgs) Handles GridView11.RowCountChanged
        RepositoryItemComboBox6.Items.Clear()
    End Sub

    Private Sub GridView11_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GridView11.ShowingEditor

        'This is to disallow editing in existing rows(and allow to create a new row) in the DrawingsProjects grid of the Details tab
        Dim rowHandle As Integer = GridView11.FocusedRowHandle
        If GridView11.FocusedRowHandle >= 0 Then
            e.Cancel = True
        End If
    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub AircraftsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AircraftsToolStripMenuItem.Click
        Dim AircraftsScreen As New Aircrafts
        AircraftsScreen.Show()
    End Sub

    Private Sub ProductGroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductGroupToolStripMenuItem.Click
        Dim frmEngWorkflowProductGroup As New frmEngWorkflowProductGroup
        frmEngWorkflowProductGroup.ShowDialog()
    End Sub

    Private Sub ChangeDrawingNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeDrawingNumberToolStripMenuItem.Click

        '    ChangeDocNumber = Me.txtMainDrawingNumber.Text
        '    documentType = Me.cboDetailsDocumentType.Text
        '    Title = Me.txtmaininfotitle.Text


        ChangeDocNumber = Me.txtMainDrawingNumber.Text
        ChangeDocTYpe = cboDetailsDocumentType.Text

        Dim ChangeDrawingNumber As New frmEngWorkflowChangeDrawingNumber
        ChangeDrawingNumber.ShowDialog()


        If ChangeDocNumber <> "" Then
            Search()
        End If

    End Sub

    Private Sub HelpManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpManualToolStripMenuItem.Click
        Process.Start("\\ken-resourcesan.fieldcorp.local\fieldcorp\public\EngDesignTrack\FDT User Guide.pdf")
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------------------------







    '**************------REDLINES ----------------------------------------------------------------------------------------------------------------------
    Private Sub btnAddRedline_Click(sender As Object, e As EventArgs) Handles btnAddRedline.Click

        btnLiaisonSignOff.Enabled = True
        btnPlannerSignOff.Enabled = False
        btnDesignSignOff.Enabled = False


        'If the latest gate-6-rev (that is not drn or adcn) has anything other than released then do not allow to add redline
        da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And Status = 'GATE 6: Complete' And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '') And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq desc, RecordID Desc", SqlConnection1)
        da.Fill(ds, "LatestRedlineRev")

        If ds.Tables("LatestRedlineRev").Rows.Count > 0 Then

            LatestRedlineRev = ds.Tables("LatestRedlineRev").Rows(0).Item("DwgRevision")
            ds.Tables("LatestRedlineRev").Clear()
            ds.Tables("LatestRedlineRev").Dispose()

            'Redlines for all revisions in that doc number cannot be anything else other than Released
            da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And (Status = 'Work In Progress' Or Status = 'Ready for Engineering Change') And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)  'Or Status = 'Incorporated'   'And Rev = '" & RedlineRev & "' 
            da.Fill(ds, "RedlinesAddBtn")

            If ds.Tables("RedlinesAddBtn").Rows.Count > 0 Then
                'MsgBox("Not all redlines are set to released or incorporated. Correct that if possible before adding a new redline")
                ds.Tables("RedlinesAddBtn").Clear()
                ds.Tables("RedlinesAddBtn").Dispose()
                Exit Sub
            Else
                da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Status = 'Released' And LiaisonSignedOffBy = '' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)   'And Rev = '" & RedlineRev & "' 
                da.Fill(ds, "LiaisonDidNotSign")
                If ds.Tables("LiaisonDidNotSign").Rows.Count > 0 Then
                    MsgBox("Cannot add a redline until the Liaison signs off")
                    ds.Tables("LiaisonDidNotSign").Clear()
                    ds.Tables("LiaisonDidNotSign").Dispose()
                    Exit Sub
                End If
            End If


            GetIndexNum()
            GetRedlineFileName()
            GetRedlineCount()
            u.ExecuteSQL(SqlConnection1, "Insert Into tblRedlines (DrawingNum,Rev,Status,RequestBy,IndexNum,FileName,RedlineNumber,RedlineCount,LiaisonSignedOffBy,OperationsSignedOffBy,DesignEngSignedOffBy,LiaisonSignedOffDate,OperationsSignedOffDate,DesignEngSignedOffDate) Values ('" & txtMainDrawingNumber.Text & "', '" & LatestRedlineRev & "', 'Work In Progress', '" & System.Environment.UserName & "', '" & NextIndexNum & "', '" & RedlineFileName & "', '" & LatestRedlineRev & "." & NextIndexNum & "', '" & RedlinesCount & "', '', '', '', '', '', '')")
            SearchRedLines()

            'If the Latest Rev is Gate 6, and it is the first one for that rev (and therefore no higher rev yet) then automatically execute the AddRev button
            da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq desc, RecordID Desc", SqlConnection1)   'And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '')
            da.Fill(ds, "LatestRevStatus")
            da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Status = 'Work In Progress' And Rev = '" & LatestRedlineRev & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)   'And Rev = '" & RedlineRev & "' 
            da.Fill(ds, "RevLastRedlineAdded")

            If ds.Tables("LatestRevStatus").Rows.Count > 0 Then
                'Do not automatically create a new Rev
                If (ds.Tables("LatestRevStatus").Rows(0).Item("DRNADCN") <> "" Or ds.Tables("LatestRevStatus").Rows(0).Item("ADCN") <> "") And ds.Tables("LatestRevStatus").Rows(0).Item("Status") <> "GATE 6: Complete" Then
                    'Nothing
                    ds.Tables("LatestRevStatus").Clear()
                    ds.Tables("LatestRevStatus").Dispose()

                    'Automatically create Rev if is a DRN or ADCN and is at Gate 6
                ElseIf (ds.Tables("LatestRevStatus").Rows(0).Item("DRNADCN") <> "" Or ds.Tables("LatestRevStatus").Rows(0).Item("ADCN") <> "") And ds.Tables("LatestRevStatus").Rows(0).Item("Status") = "GATE 6: Complete" Then

                    AddRevFromRedline = "Yes"
                    RevNotes = Now & " - Redline generated document change"
                    RevOrDRN = "REV"
                    btnAddNewRev.PerformClick()
                    AddRevFromRedline = ""
                    RevNotes = ""
                    ds.Tables("LatestRevStatus").Clear()
                    ds.Tables("LatestRevStatus").Dispose()
                    ds.Tables("RevLastRedlineAdded").Clear()
                    ds.Tables("RevLastRedlineAdded").Dispose()

                    'Else    'Automatically create a new Rev
                ElseIf ds.Tables("LatestRevStatus").Rows.Count > 0 And ds.Tables("RevLastRedlineAdded").Rows.Count > 0 Then
                    If ds.Tables("LatestRevStatus").Rows(0).Item("Status") = "GATE 6: Complete" And ds.Tables("RevLastRedlineAdded").Rows(0).Item("IndexNum") = "01" Then
                        AddRevFromRedline = "Yes"
                        RevNotes = Now & " - Redline generated document change"
                        RevOrDRN = "REV"
                        btnAddNewRev.PerformClick()
                        AddRevFromRedline = ""
                        RevNotes = ""
                        ds.Tables("LatestRevStatus").Clear()
                        ds.Tables("LatestRevStatus").Dispose()
                        ds.Tables("RevLastRedlineAdded").Clear()
                        ds.Tables("RevLastRedlineAdded").Dispose()

                    ElseIf ds.Tables("LatestRevStatus").Rows(0).Item("Status") = "GATE 6: Complete" And ds.Tables("LatestRevStatus").Rows(0).Item("DwgRevision") = LatestRedlineRev Then
                        AddRevFromRedline = "Yes"
                        RevNotes = Now & " - Redline generated document change"
                        RevOrDRN = "REV"
                        btnAddNewRev.PerformClick()
                        AddRevFromRedline = ""
                        RevNotes = ""

                    Else
                        ds.Tables("LatestRevStatus").Clear()
                        ds.Tables("LatestRevStatus").Dispose()
                        ds.Tables("RevLastRedlineAdded").Clear()
                        ds.Tables("RevLastRedlineAdded").Dispose()
                    End If
                    'End If

                    ds.Tables("LatestRedlineRev").Clear()
                    ds.Tables("LatestRedlineRev").Dispose()
                End If
            End If

        Else
            MsgBox("You cannot add a redline since there are no revisions at gate 6")
            Exit Sub
        End If

        SearchRedLines()
    End Sub

    'Private Sub btnSaveStatus_Click(sender As Object, e As EventArgs) Handles btnSaveStatus.Click

    '    RowSelectedUpperGrid = GridView13.FocusedRowHandle

    '    If cboRedlineStatus.Text = "Released" Then
    '        If CM = True Or isAdmin = "T" Or isLiaison = "T" Then
    '            u.ExecuteSQL(SqlConnection1, "Update tblRedlines Set Status = '" & cboRedlineStatus.Text & "' Where RecordID = '" & Me.txtRedlineRecordID.Text & "'")
    '        Else
    '            MsgBox("You are not a Liaison Engineer and cannot change the status to Released")
    '            Exit Sub
    '        End If

    '    ElseIf cboRedlineStatus.Text = "Ready for Engineering Change" Then
    '        If isOperations = "T" Then
    '            u.ExecuteSQL(SqlConnection1, "Update tblRedlines Set Status = '" & cboRedlineStatus.Text & "' Where RecordID = '" & Me.txtRedlineRecordID.Text & "'")
    '        Else
    '            MsgBox("You are not a Planner and cannot change the status to Ready for Engineering Change")
    '            Exit Sub
    '        End If

    '    ElseIf cboRedlineStatus.Text = "Incorporated" Then
    '        If isDrafter = "T" Then
    '            u.ExecuteSQL(SqlConnection1, "Update tblRedlines Set Status = '" & cboRedlineStatus.Text & "' Where RecordID = '" & Me.txtRedlineRecordID.Text & "'")
    '        Else
    '            MsgBox("You are not a Design Engineer and cannot change the status to Incorporated")
    '            Exit Sub
    '        End If
    '    End If

    '    SearchRedLines()


    '    'Put the focus on the rows that were selected (for upper and lower grids) before hitting the save button
    '    GridView13.FocusedRowHandle = RowSelectedUpperGrid
    '    GridView13.SelectRow(RowSelectedUpperGrid)
    'End Sub

    Private Sub btnDeleteRedline_Click(sender As Object, e As EventArgs) Handles btnDeleteRedline.Click

        If CM = True Or isAdmin = "T" Or isLiaison = "T" Then

            da = New SqlClient.SqlDataAdapter("Select * From tblRedlinesIndexNum Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Rev = '" & RevBeforeDelete & "' Order By RecordID Desc", SqlConnection1)
            da.Fill(ds, "IndexNumToDelete")

            If ds.Tables("IndexNumToDelete").Rows.Count > 0 Then

                Dim IndexNumToDelete As Integer = ds.Tables("IndexNumToDelete").Rows(0).Item("IndexNum")
                Dim RecordIDToDelete As Integer = ds.Tables("IndexNumToDelete").Rows(0).Item("RecordID")

                u.ExecuteSQL(SqlConnection1, "DELETE FROM tblRedlinesIndexNum WHERE RecordID = '" & RecordIDToDelete & "' And IndexNum = '" & IndexNumToDelete & "'")
                u.ExecuteSQL(SqlConnection1, "UPDATE tblRedlines Set Status = 'Deleted' WHERE Status = 'Work In Progress' And DrawingNum = '" & txtMainDrawingNumber.Text & "' And Rev = '" & RevBeforeDelete & "'")
                SearchRedLines()

                ds.Tables("IndexNumToDelete").Clear()
                ds.Tables("IndexNumToDelete").Dispose()
            End If

        Else
            MsgBox("You are not authorized to delete the redline")
            Exit Sub
        End If
    End Sub

    Public Function EnablingRedLineAddBtn()
        Dim RedlineRev As String = ""
        Dim RedlineDrawingNum As String = ""
        Dim CheckIfGateSix As String = ""

        'Only allow the Redline Add button to be visible to CMs, Admins and Liaison Engineers
        If CM = True Or isAdmin = "T" Or isLiaison = "T" Then

            'If the last gate 6 rev has any of the redlines that are Incorporated or Ready for Engineering Change(all of them should be like that) then disable the btnRedlineAdd
            'da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And Status = 'GATE 6: Complete' And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '') And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq desc, RecordID Desc", SqlConnection1)
            'da.Fill(ds, "Redlines")

            'If ds.Tables("Redlines").Rows.Count > 0 Then

            '    RedlineRev = ds.Tables("Redlines").Rows(0).Item("DwgRevision")
            '    RedlineDrawingNum = ds.Tables("Redlines").Rows(0).Item("DrawingNumber")


            'Allow to add a Redline if drawing record is at gate 6 and is the latest rev, and it does not have any redlines that are anything else other than Released
            da = New SqlClient.SqlDataAdapter("Select TOP 1 * From vwDrawingsRev Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '') And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq Desc, RecordID Desc", SqlConnection1)
            da.Fill(ds, "LatestRevGateSix")

            If ds.Tables("LatestRevGateSix").Rows.Count > 0 Then
                CheckIfGateSix = ds.Tables("LatestRevGateSix").Rows(0).Item("Status")
                Dim RevRecordSelected As String = ds.Tables("LatestRevGateSix").Rows(0).Item("DwgRevision")

                '*** FIRST PART - IF THIS GETS EXECUTED THEN THE SECOND PART WILL NOT ----------------------------------------------------------------------------------------------
                If CheckIfGateSix = "GATE 6: Complete" Then
                    da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Rev = '" & RevRecordSelected & "' And (Status = 'Work In Progress' Or Status = 'Ready for Engineering Change') And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)
                    'Or Status = 'Incorporated'
                    da.Fill(ds, "CheckLastRevGateSixHasRedlines")

                    If ds.Tables("CheckLastRevGateSixHasRedlines").Rows.Count > 0 Then
                        btnAddRedline.Enabled = False
                        ds.Tables("LatestRevGateSix").Clear()
                        ds.Tables("LatestRevGateSix").Dispose()
                        ds.Tables("CheckLastRevGateSixHasRedlines").Clear()
                        ds.Tables("CheckLastRevGateSixHasRedlines").Dispose()
                        GoTo FINISHENABLINGADDBTN
                    Else
                        'Do not enable the btnAddRedline if the redlines for the rev are set to Incorporated and IncorporatedRev is empty.  So user cannot add a redline
                        'if the DRN/ADCN is at gate 6 and the redlines for its related rev are incorporated.   
                        da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Rev = '" & RevRecordSelected & "' And Status = 'Incorporated' And (IncorporatedRev Is Null Or IncorporatedRev = '') And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)
                        da.Fill(ds, "IncorporatedAndIncorporatedRev")
                        If ds.Tables("IncorporatedAndIncorporatedRev").Rows.Count > 0 Then
                            btnAddRedline.Enabled = False
                            ds.Tables("IncorporatedAndIncorporatedRev").Clear()
                            ds.Tables("IncorporatedAndIncorporatedRev").Dispose()
                        Else
                            'If there are two or more DRN/ADCN and the first DRN/ADCN after it is moved to gate 6 populates the IncorporatedRev field of all the
                            'incorporated redlines then the code right above is not going to disable the btnAddRedline. Therefore this is in case we have two or more
                            'DRN/ADCN
                            da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Rev = '" & RevRecordSelected & "' And Status = 'Incorporated' And (IncorporatedRev Is Not Null Or IncorporatedRev != '') And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)
                            da.Fill(ds, "MoreThanOneDrnAdcn")
                            If ds.Tables("MoreThanOneDrnAdcn").Rows.Count > 0 Then
                                If SignedOffAdcnDrnGateSix = "Yes" Then
                                    btnAddRedline.Enabled = True
                                Else
                                    ''Next 9 lines and two matching End Ifs(plus the .Clear and .Dispose) were added on 3/3/22 and are not going to be added for now
                                    ''When there are two or more DRN/ADCN, after a Drn or Adcn is moved to gate 6 
                                    ''then the btnAddRedline can be enabled, even if it was disabled once the redlines were set to incorporated
                                    'da = New SqlClient.SqlDataAdapter("Select * From vwDrawingsRev Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And DwgRevision = '" & RevRecordSelected & "' And ((DRNADCN Is Not Null And DRNADCN != '') Or (ADCN Is Not Null And ADCN != '')) And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq Desc, RecordID Desc", SqlConnection1)
                                    'da.Fill(ds, "LastDrnAdcn")
                                    'If ds.Tables("LastDrnAdcn").Rows.Count > 0 Then
                                    '    If ds.Tables("LastDrnAdcn").Rows(0).Item("Status") = "GATE 6: Complete" Then
                                    '        btnAddRedline.Enabled = True
                                    '    Else
                                    '        'This was the pre-existing line before 3/3/22, the above in the two IFs was added after
                                    btnAddRedline.Enabled = False
                                    '    End If

                                    '    ds.Tables("LastDrnAdcn").Clear()
                                    '    ds.Tables("LastDrnAdcn").Dispose()
                                    'End If
                                End If

                                ds.Tables("MoreThanOneDrnAdcn").Clear()
                                ds.Tables("MoreThanOneDrnAdcn").Dispose()
                            Else

                                Dim ItIsDrn As String = ""
                                Dim ItIsAdcn As String = ""
                                Dim StatusLastDrnAdcn As String = ""

                                da = New SqlClient.SqlDataAdapter("Select TOP 1 * From vwDrawingsRev Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq Desc, RecordID Desc", SqlConnection1)
                                da.Fill(ds, "CheckIfAdcnDrnAndStatus")
                                If ds.Tables("CheckIfAdcnDrnAndStatus").Rows.Count > 0 Then
                                    ItIsDrn = ds.Tables("CheckIfAdcnDrnAndStatus").Rows(0).Item("DRNADCN")
                                    ItIsAdcn = ds.Tables("CheckIfAdcnDrnAndStatus").Rows(0).Item("ADCN")
                                    StatusLastDrnAdcn = ds.Tables("CheckIfAdcnDrnAndStatus").Rows(0).Item("Status")

                                    ds.Tables("CheckIfAdcnDrnAndStatus").Clear()
                                    ds.Tables("CheckIfAdcnDrnAndStatus").Dispose()
                                End If

                                'The code in the If should run only if the latest record is DRN/ADCN and the gate is 2 or higher. The line in the Else was pre-existing
                                If (ItIsDrn <> "" Or ItIsAdcn <> "") And (StatusLastDrnAdcn = "GATE 2: DWG Ready For Sr Engineer" Or StatusLastDrnAdcn = "GATE 3: DWG Ready For Operations" Or StatusLastDrnAdcn = "GATE 4: DWG Ready For Release" Or StatusLastDrnAdcn = "GATE 5: DWG Released") Then          'Or StatusLastDrnAdcn = "GATE 6: Complete"
                                    btnAddRedline.Enabled = False
                                Else
                                    btnAddRedline.Enabled = True
                                End If

                            End If
                        End If

                        ds.Tables("LatestRevGateSix").Clear()
                        ds.Tables("LatestRevGateSix").Dispose()
                        GoTo FINISHENABLINGADDBTN
                    End If
                End If

                ds.Tables("LatestRevGateSix").Clear()
                ds.Tables("LatestRevGateSix").Dispose()
            End If




            '*** SECOND PART - IT EXECUTES IF THE FIRST PART DOES NOT ----------------------------------------------------------------------------------------------
            'Do not allow to add a Redline if the latest rev has Redlines set to anything else other than Released
            da = New SqlClient.SqlDataAdapter("Select Top 1 * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By RecordID Desc", SqlConnection1)
            da.Fill(ds, "Redlines")
            If ds.Tables("Redlines").Rows.Count > 0 Then
                RedlineRev = ds.Tables("Redlines").Rows(0).Item("Rev")
                ds.Tables("Redlines").Clear()
                ds.Tables("Redlines").Dispose()
            End If

            'Do not allow to add a Redline if the latest rev has Redlines set to anything else other than Released
            da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Rev = '" & RedlineRev & "' And (Status = 'Work In Progress' Or Status = 'Ready for Engineering Change') And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)   'Or Status = 'Incorporated' 
            'Or Status = 'Incorporated'
            da.Fill(ds, "IncorporatedRecs")

            If ds.Tables("IncorporatedRecs").Rows.Count > 0 Then
                btnAddRedline.Enabled = False
                ds.Tables("IncorporatedRecs").Clear()
                ds.Tables("IncorporatedRecs").Dispose()
            Else
                'When Redlines are all set to Incorporated, if the latest rev (that is not a DRN or ADCN) is at Gate 6 then allow the btnAddRedline, otherwise disable it
                If CheckIfGateSix = "GATE 6: Complete" Then
                    btnAddRedline.Enabled = True
                Else
                    'If the latest rev IS NOT at gate 6 but the Redlines are Released and not incorporated then enable the btnAddRedline
                    da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Rev = '" & RedlineRev & "' And Status = 'Released' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)   'Or Status = 'Incorporated' 
                    da.Fill(ds, "ReleasedRecs")
                    If ds.Tables("ReleasedRecs").Rows.Count > 0 Then
                        btnAddRedline.Enabled = True
                        ds.Tables("ReleasedRecs").Clear()
                        ds.Tables("ReleasedRecs").Dispose()
                    Else
                        'If the higher rev is at gate 0 or 1 and for the previous rev there are no redlines or if there are they are Released THEN enable the btnAddRedline.
                        'Otherwise if there are redlines for the previous rev and they are all set to Incorporated and gate is 0/1 THEN enable the btnAddRedline
                        Dim LastRev As String = ""
                        da = New SqlClient.SqlDataAdapter("Select * From vwDrawingsRev Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And Status = 'GATE 6: Complete' And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '') And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq Desc, RecordID Desc", SqlConnection1)
                        da.Fill(ds, "LastRev")
                        If ds.Tables("LastRev").Rows.Count > 0 Then
                            LastRev = ds.Tables("LastRev").Rows(0).Item("DwgRevision")
                            ds.Tables("LastRev").Clear()
                            ds.Tables("LastRev").Dispose()
                        End If

                        da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Rev = '" & LastRev & "' And (Status = 'Work In Progress' Or Status = 'Ready for Engineering Change' Or Status = 'Incorporated') And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)   'Or Status = 'Incorporated' 
                        da.Fill(ds, "CheckIfAllReleased")
                        If (CheckIfGateSix = "GATE 0: CM Needs To Assign DWG Number" Or CheckIfGateSix = "GATE 1: DWG Ready For Drafter") And ds.Tables("CheckIfAllReleased").Rows.Count = 0 Then
                            btnAddRedline.Enabled = True
                        Else
                            ''The next 7 lines and matching End If were added on 3/3/22 and are not going to be added for now
                            ''If there are redlines for the previous rev and they are all set to Incorporated and gate is 0/1 THEN enable the btnAddRedline
                            'da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Rev = '" & LastRev & "' And Status != 'Incorporated' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)
                            'da.Fill(ds, "IsAllIncorporated")
                            'If (CheckIfGateSix = "GATE 0: CM Needs To Assign DWG Number" Or CheckIfGateSix = "GATE 1: DWG Ready For Drafter") And ds.Tables("IsAllIncorporated").Rows.Count = 0 Then
                            '    btnAddRedline.Enabled = True
                            'Else
                            '    'This line was pre-existing before 3/3/22, the above in the If was added after
                            btnAddRedline.Enabled = False
                            'End If

                            'ds.Tables("IsAllIncorporated").Clear()
                            'ds.Tables("IsAllIncorporated").Dispose()
                        End If

                        ds.Tables("CheckIfAllReleased").Clear()
                        ds.Tables("CheckIfAllReleased").Dispose()
                    End If
                End If
            End If

            'End If
FINISHENABLINGADDBTN:
        Else
            btnAddRedline.Enabled = False
        End If


        'Allow users with permission to always have the Redline button available
        If ChangeRedline = "T" Then
            btnAddRedline.Enabled = True
        End If
    End Function

    'Populate the Redline grid
    Public Function SearchRedLines()

        Dim SqlString As String

        DsRedlines1.tblRedlines.Clear()

        Me.txtRedlineRecordID.DataBindings.Clear()
        Me.cboRedlineStatus.DataBindings.Clear()
        Me.txtRedlineFileName.DataBindings.Clear()


        Dim cmdSave As String
        cmdSave = Me.daRedlines.SelectCommand.CommandText
        Me.daRedlines.SelectCommand.CommandText() += SqlString + " Where DrawingNum = '" & Me.txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By RecordID Desc"       'And Rev = '" & Me.cboMainRev.Text & "' 

        Try
            Me.daRedlines.Fill(DsRedlines1.tblRedlines)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.daRedlines.SelectCommand.CommandText = cmdSave

        If Me.DsRedlines1.Tables("tblRedlines").Rows.Count <> 0 Then

            'Create DataBindings          
            Me.cboRedlineStatus.DataBindings.Add("Text", Me.bsRedlines, "Status")
            Me.txtRedlineRecordID.DataBindings.Add("Text", Me.bsRedlines, "RecordID")
            Me.txtRedlineFileName.DataBindings.Add("Text", Me.bsRedlines, "FileName")

        End If

        ''Hide InstallationDrawing and NextHigherAssembly columns in the Details tab as they are not needed anymore
        'GridView3.Columns("InstallationDrawing").Visible = False


        If Me.DsRedlines1.Tables("tblRedlines").Rows.Count = 0 Then
            btnLiaisonSignOff.Enabled = False
            btnPlannerSignOff.Enabled = False
            btnDesignSignOff.Enabled = False
        End If


        'Give capability to change IncorporatedRev and/or redline Status to people that have permission to ChangeRedline, so that they can change them for older redlines(the pre-existing ones)
        If ChangeRedline = "T" Then
            colIncorporatedRev.OptionsColumn.ReadOnly = False
            colStatus7.OptionsColumn.ReadOnly = False
            btnSaveIncorporatedRev.Visible = True
        Else
            colIncorporatedRev.OptionsColumn.ReadOnly = True
            colStatus7.OptionsColumn.ReadOnly = True
            btnSaveIncorporatedRev.Visible = False
        End If

    End Function

    Public Function GetIndexNum()

        da = New SqlClient.SqlDataAdapter("Select * From tblRedlinesIndexNum Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Rev = '" & LatestRedlineRev & "' Order By RecordID Desc", SqlConnection1)
        da.Fill(ds, "GetIndexNum")

        If ds.Tables("GetIndexNum").Rows.Count > 0 Then

            Dim currentIndexNum As Integer = ds.Tables("GetIndexNum").Rows(0).Item("IndexNum")
            NextIndexNum = currentIndexNum + 1
            If NextIndexNum.Length = 1 Then
                NextIndexNum = "0" & NextIndexNum
            End If

            ds.Tables("GetIndexNum").Clear()
            ds.Tables("GetIndexNum").Dispose()

        Else
            NextIndexNum = "01"
        End If

        u.ExecuteSQL(SqlConnection1, "Insert Into tblRedlinesIndexNum (IndexNum,DrawingNum,Rev) Values ('" & NextIndexNum & "', '" & txtMainDrawingNumber.Text & "', '" & LatestRedlineRev & "')")

    End Function

    Public Function GetRedlineFileName()

        Dim RevForFilename As String = LatestRedlineRev
        If RevForFilename = "IR" Then
            RevForFilename = ""
        End If

        RedlineFileName = txtMainDrawingNumber.Text & RevForFilename & "-R" & NextIndexNum

    End Function

    Public Function GetRedlineCount()

        da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)
        da.Fill(ds, "GetCount")

        If ds.Tables("GetCount").Rows.Count > 0 Then
            RedlinesCount = ds.Tables("GetCount").Rows.Count + 1

            ds.Tables("GetCount").Clear()
            ds.Tables("GetCount").Dispose()
        Else
            RedlinesCount = 1
        End If

    End Function

    Private Sub txtRedlineRecordID_TextChanged(sender As Object, e As EventArgs) Handles txtRedlineRecordID.TextChanged
        Dim LiaisonIsSignedOff As String
        Dim OperationsIsSignedOff As String
        Dim DesignIsSignedOff As String

        cboRedlineStatus.Properties.Items.Clear()


        'Populate the Status dropdown only with values for the next available status
        da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where RecordID = '" & txtRedlineRecordID.Text & "'", SqlConnection1)
        da.Fill(ds, "LatestStatus")

        If ds.Tables("LatestStatus").Rows.Count > 0 Then
            RevSelectedRedline = ds.Tables("LatestStatus").Rows(0).Item("Rev")
            LiaisonIsSignedOff = ds.Tables("LatestStatus").Rows(0).Item("LiaisonSignedOffBy")
            OperationsIsSignedOff = ds.Tables("LatestStatus").Rows(0).Item("OperationsSignedOffBy")
            DesignIsSignedOff = ds.Tables("LatestStatus").Rows(0).Item("DesignEngSignedOffBy")

            Dim LatestStatus As String = ds.Tables("LatestStatus").Rows(0).Item("Status")
            cboRedlineStatus.Text = LatestStatus

            'If LatestStatus = "" Then
            '    Me.cboRedlineStatus.Properties.Items.Add("Work In Progress")
            '    'Me.cboRedlineStatus.Properties.Items.Add("Released")
            '    'Me.cboRedlineStatus.Properties.Items.Add("Ready for Engineering Change")
            '    'Me.cboRedlineStatus.Properties.Items.Add("Incorporated")
            'ElseIf LatestStatus = "Work In Progress" Then
            '    Me.cboRedlineStatus.Properties.Items.Add("Released")
            'ElseIf LatestStatus = "Released" And LiaisonIsSignedOff <> "" Then
            '    Me.cboRedlineStatus.Properties.Items.Add("Ready for Engineering Change")
            'ElseIf LatestStatus = "Ready for Engineering Change" And OperationsIsSignedOff <> "" Then
            '    Me.cboRedlineStatus.Properties.Items.Add("Incorporated")
            'End If

            'Get Redline filename to be used when sending Redline emails
            RedlineFilenameForEmail = ds.Tables("LatestStatus").Rows(0).Item("FileName")

            ds.Tables("LatestStatus").Clear()
            ds.Tables("LatestStatus").Dispose()
        End If


        'Visibility of the AddRedline button
        EnablingRedLineAddBtn()

        'Visibility of the SignOff buttons
        If cboRedlineStatus.Text = "Work In Progress" And (CM = True Or isAdmin = "T" Or isLiaison = "T") Then
            btnLiaisonSignOff.Enabled = True
            btnPlannerSignOff.Enabled = False
            btnDesignSignOff.Enabled = False
        ElseIf cboRedlineStatus.Text = "Released" And (CM = True Or isAdmin = "T" Or isOperations = "T") And CheckThereAreWorkInProgress() <> True Then
            btnLiaisonSignOff.Enabled = False
            btnPlannerSignOff.Enabled = True
            btnDesignSignOff.Enabled = False
        ElseIf cboRedlineStatus.Text = "Released" And (CM = True Or isAdmin = "T" Or isLiaison = "T") And LiaisonIsSignedOff <> "" Then
            btnLiaisonSignOff.Enabled = False
            btnPlannerSignOff.Enabled = False
            btnDesignSignOff.Enabled = False
        ElseIf cboRedlineStatus.Text = "Ready for Engineering Change" And isDrafter = "T" Then
            btnLiaisonSignOff.Enabled = False
            btnPlannerSignOff.Enabled = False
            btnDesignSignOff.Enabled = True
        ElseIf cboRedlineStatus.Text = "Ready for Engineering Change" And isDrafter = "T" And OperationsIsSignedOff <> "" Then
            btnLiaisonSignOff.Enabled = False
            btnPlannerSignOff.Enabled = False
            btnDesignSignOff.Enabled = False
        ElseIf cboRedlineStatus.Text = "Incorporated" Then
            btnLiaisonSignOff.Enabled = False
            btnPlannerSignOff.Enabled = False
            btnDesignSignOff.Enabled = False
        ElseIf cboRedlineStatus.Text = "Incorporated" And DesignIsSignedOff <> "" Then
            btnLiaisonSignOff.Enabled = False
            btnPlannerSignOff.Enabled = False
            btnDesignSignOff.Enabled = False
        ElseIf cboRedlineStatus.Text = "Canceled" Or cboRedlineStatus.Text = "Deleted" Then
            btnLiaisonSignOff.Enabled = False
            btnPlannerSignOff.Enabled = False
            btnDesignSignOff.Enabled = False
        End If


        'Get the latest redline and check the status. Only the latest redline that is Work In Progress can be deleted
        da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By RecordID Desc", SqlConnection1)
        da.Fill(ds, "EnablingDeleteBtn")

        If ds.Tables("EnablingDeleteBtn").Rows.Count > 0 Then
            Dim isWorkInProgress As String = ds.Tables("EnablingDeleteBtn").Rows(0).Item("Status")
            Dim recordIDLastRedline As String = ds.Tables("EnablingDeleteBtn").Rows(0).Item("RecordID")

            IndexBeforeDelete = ds.Tables("EnablingDeleteBtn").Rows(0).Item("IndexNum") 'Variable to use when deleting a redline under the btnDeleteRedline
            RevBeforeDelete = ds.Tables("EnablingDeleteBtn").Rows(0).Item("Rev")        'Variable to use when deleting a redline under the btnDeleteRedline

            If isWorkInProgress = "Work In Progress" And recordIDLastRedline = txtRedlineRecordID.Text Then
                btnDeleteRedline.Enabled = True
            Else
                btnDeleteRedline.Enabled = False
            End If

            ds.Tables("EnablingDeleteBtn").Clear()
            ds.Tables("EnablingDeleteBtn").Dispose()
        End If

    End Sub

    Private Sub btnRedlineSignOff_Click(sender As Object, e As EventArgs) Handles btnLiaisonSignOff.Click

        RowSelectedUpperGrid = GridView13.FocusedRowHandle


        If cboRedlineStatus.Text = "Work In Progress" And (CM = True Or isAdmin = "T" Or isLiaison = "T") And CheckThereAreWorkInProgress() <> True Then

            u.ExecuteSQL(SqlConnection1, "Update tblRedlines Set LiaisonSignedOffBy = '" & LCase(System.Environment.UserName) & "', LiaisonSignedOffDate = '" & Now & "', Status = 'Released', RedlineDate = '" & Now & "' Where RecordID = '" & Me.txtRedlineRecordID.Text & "'")

        ElseIf cboRedlineStatus.Text = "Released" Then

            'da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Status = 'Released' And LiaisonSignedOffBy = '' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)   'And Rev = '" & RedlineRev & "' 
            'da.Fill(ds, "LiaisonDidNotSignOff")

            'If ds.Tables("LiaisonDidNotSignOff").Rows.Count > 0 Then
            '    u.ExecuteSQL(SqlConnection1, "Update tblRedlines Set LiaisonSignedOffBy = '" & LCase(System.Environment.UserName) & "', LiaisonSignedOffDate = '" & Now & "', Status = 'Released', RedlineDate = '" & Now & "' Where RecordID = '" & Me.txtRedlineRecordID.Text & "'")
            'End If

            MsgBox("Liaison cannot sign off a redline set to Released")
            Exit Sub

        ElseIf cboRedlineStatus.Text = "Ready for Engineering Change" Then
            MsgBox("Liaison cannot sign off a redline set to Ready for Engineering Change")
            Exit Sub
        ElseIf cboRedlineStatus.Text = "Incorporated" Then
            MsgBox("Liaison cannot sign off a redline set to Incorporated")
            Exit Sub
        End If

        SearchRedLines()

        'Send Email to people selected as Redlines on the tblNotificationsGroups
        SendRedlineEmail("Liaison")

        'Put the focus on the rows that were selected (for upper and lower grids) before hitting the save button
        GridView13.FocusedRowHandle = RowSelectedUpperGrid
        GridView13.SelectRow(RowSelectedUpperGrid)
    End Sub

    Private Sub btnPlannerSignOff_Click(sender As Object, e As EventArgs) Handles btnPlannerSignOff.Click

        RowSelectedUpperGrid = GridView13.FocusedRowHandle


        If cboRedlineStatus.Text = "Released" And isOperations = "T" And CheckThereAreWorkInProgress() <> True Then

            u.ExecuteSQL(SqlConnection1, "Update tblRedlines Set OperationsSignedOffBy = '" & LCase(System.Environment.UserName) & "', OperationsSignedOffDate = '" & Now & "', Status = 'Ready for Engineering Change' Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Rev = '" & RevSelectedRedline & "' And Status != 'Deleted' And Status != 'Incorporated'")

        ElseIf cboRedlineStatus.Text = "Work In Progress" Then
            MsgBox("Planner cannot sign off a redline set to Work In Progress")
            Exit Sub
        ElseIf cboRedlineStatus.Text = "Ready for Engineering Change" Then
            MsgBox("Planner cannot sign off a redline set to Ready for Engineering Change")
            Exit Sub
        ElseIf cboRedlineStatus.Text = "Incorporated" Then
            MsgBox("Planner cannot sign off a redline set to Incorporated")
            Exit Sub
        End If

        SearchRedLines()

        'Send Email to people selected as Redlines on the tblNotificationsGroups
        SendRedlineEmail("Planner")

        'Put the focus on the rows that were selected (for upper and lower grids) before hitting the save button
        GridView13.FocusedRowHandle = RowSelectedUpperGrid
        GridView13.SelectRow(RowSelectedUpperGrid)
    End Sub

    Private Sub btnDesignSignOff_Click(sender As Object, e As EventArgs) Handles btnDesignSignOff.Click

        RowSelectedUpperGrid = GridView13.FocusedRowHandle

        'Commented next block of code because I found a situation where I was trying to move a record to gate 2 and got an error saying that all redlines should be set to
        'incorporated before doing that. So I went to click on Design Sign Off to do that and I got the error saying there would need to be a higher rev before signing off design, 
        'but I could not do that before I would set the initial record I was working with to gate 6. So it is a never ending cycle
        ''Next block of code(14 lines) may not be needed since normally a new rev is created when adding a redline for a gate 6 and there is no higher rev
        ''User cannot signoff the Design if there Is Not a higher rev
        'Dim lastRev As String = ""
        'da = New SqlClient.SqlDataAdapter("Select Top 1 * From vwDrawingsRev Where DrawingNumber = '" & txtMainDrawingNumber.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By Seq desc, RecordID Desc", SqlConnection1)   'And Status = 'GATE 6: Complete' And (DRNADCN Is Null Or DRNADCN = '') And (ADCN Is Null Or ADCN = '')
        'da.Fill(ds, "LastRev")
        'If ds.Tables("LastRev").Rows.Count > 0 Then
        '    lastRev = ds.Tables("LastRev").Rows(0).Item("DwgRevision")
        '    ds.Tables("LastRev").Clear()
        '    ds.Tables("LastRev").Dispose()
        'End If

        'If lastRev = RevSelectedRedline Then
        '    MsgBox("You cannot signoff as there is no higher rev")
        '    Exit Sub
        'End If



        If cboRedlineStatus.Text = "Ready for Engineering Change" And isDrafter = "T" And CheckThereAreWorkInProgress() <> True Then

            u.ExecuteSQL(SqlConnection1, "Update tblRedlines Set DesignEngSignedOffBy = '" & LCase(System.Environment.UserName) & "', DesignEngSignedOffDate = '" & Now & "', Status = 'Incorporated' Where DrawingNum = '" & txtMainDrawingNumber.Text & "' And Rev = '" & RevSelectedRedline & "' And Status != 'Deleted' And Status != 'Incorporated'")

        ElseIf cboRedlineStatus.Text = "Work In Progress" Then
            MsgBox("Design engineer cannot sign off a redline set to Work In Progress")
            Exit Sub
        ElseIf cboRedlineStatus.Text = "Released" Then
            MsgBox("Design engineer cannot sign off a redline set to Ready for Engineering Change")
            Exit Sub
        ElseIf cboRedlineStatus.Text = "Ready for Engineering Change" Then
            MsgBox("Design engineer cannot sign off a redline set to Incorporated")
            Exit Sub
        End If


        SearchRedLines()


        'Put the focus on the rows that were selected (for upper and lower grids) before hitting the save button
        GridView13.FocusedRowHandle = RowSelectedUpperGrid
        GridView13.SelectRow(RowSelectedUpperGrid)
    End Sub

    Public Function CheckThereAreWorkInProgress()

        da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where RecordID = '" & txtRedlineRecordID.Text & "'", SqlConnection1)
        da.Fill(ds, "RecordIDRedline")

        If ds.Tables("RecordIDRedline").Rows.Count > 0 Then

            Dim DrawNumRecord As String = ds.Tables("RecordIDRedline").Rows(0).Item("DrawingNum")
            Dim RevRecord As String = ds.Tables("RecordIDRedline").Rows(0).Item("Rev")

            da = New SqlClient.SqlDataAdapter("Select * From tblRedlines Where DrawingNum = '" & DrawNumRecord & "' And Rev = '" & RevRecord & "' And Status = 'Work In Progress' And RecordID != '" & txtRedlineRecordID.Text & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", SqlConnection1)
            da.Fill(ds, "CheckIfAnyWorkInProgress")
            If ds.Tables("CheckIfAnyWorkInProgress").Rows.Count > 0 Then
                ds.Tables("CheckIfAnyWorkInProgress").Clear()
                ds.Tables("CheckIfAnyWorkInProgress").Dispose()
                Return True
            End If

            ds.Tables("RecordIDRedline").Clear()
            ds.Tables("RecordIDRedline").Dispose()
        End If

    End Function

    Private Sub btnSaveIncorporatedRev_Click(sender As Object, e As EventArgs) Handles btnSaveIncorporatedRev.Click
        daRedlines.Update(DsRedlines1.tblRedlines)
    End Sub

    Public Function SendRedlineEmail(Role As String, Optional ByVal SMTPServer As String = "172.16.3.14")

        Dim client As SmtpClient
        Dim myMessage As MailMessage
        Dim emailFrom As MailAddress
        Dim emailTo As MailAddress
        Dim Email As String
        Dim MoreEmails As String
        Dim EmailSubject As String
        Dim EmailBody As String
        SqlConnection1.ConnectionString = sqlString

        Dim ListOfUserIDs As String = ""
        Dim ListOfUsernames As String = ""


        'GET ID OF PEOPLE IN tblNotificationsGroups TABLE TO WHOM SEND THE EMAIL
        If Role = "Liaison" Then
            da = New SqlClient.SqlDataAdapter("Select [User] From tblNotificationsGroups Where Active = 1 And Redline = 1", SqlConnection1)

        ElseIf Role = "Planner" Then
            da = New SqlClient.SqlDataAdapter("Select [User] from tblNotificationsGroups Where Active = 1 And Redline = 1", SqlConnection1)

        End If


        da.Fill(ds, "UserID")


        If ds.Tables("UserID").Rows.Count = 0 Then
            GoTo DONOTSENDEMAIL
        End If

        Dim a As Integer = 0
        While a <= ds.Tables("UserID").Rows.Count - 1
            If ListOfUserIDs = "" Then
                ListOfUserIDs = "'" & ds.Tables("UserID").Rows(a).Item("User") & "'"
            Else
                ListOfUserIDs = ListOfUserIDs & ", '" & ds.Tables("UserID").Rows(a).Item("User") & "'"
            End If
            a = a + 1
        End While

        ds.Tables("UserID").Clear()
        ds.Tables("UserID").Dispose()

GETEMAILADDRESSES:
        'GET EMAILS OF PEOPLE
        If Role = "Liaison" Then
            da = New SqlClient.SqlDataAdapter("Select Email from tblUsers Where (ID IN(" & ListOfUserIDs & "))", SqlConnection1)
            EmailBody = "Engineering has released a redline " & RedlineFilenameForEmail
            EmailSubject = "Engineering Redline Change Notification " & RedlineFilenameForEmail
        ElseIf Role = "Planner" Then
            da = New SqlClient.SqlDataAdapter("Select Email from tblUsers Where (ID IN(" & ListOfUserIDs & "))", SqlConnection1)
            EmailBody = "Operations request for Engineering document revision to incorporate redlines " & RedlineFilenameForEmail
            EmailSubject = "Engineering Change Request " & RedlineFilenameForEmail
        End If


        da.Fill(ds, "Emails")

        'GET EMAIL ADDRESSES
        'da.Fill(ds, "Emails")
        Dim i As Integer = 0
        While i <= ds.Tables("Emails").Rows.Count - 1
            ''If Email = "" Then
            ''    Email = ds.Tables("Emails").Rows(i).Item("Email")

            ''    emailFrom = New MailAddress("ar@fieldav.com")
            ''    emailTo = New MailAddress(Email)
            ''    myMessage = New MailMessage(emailFrom, emailTo)
            ''Else
            ''    MoreEmails = ds.Tables("Emails").Rows(i).Item("Email")

            ''    myMessage.To.Add(New MailAddress(MoreEmails))
            ''End If
            If IsDBNull(ds.Tables("Emails").Rows(i).Item("Email")) Then
                i = i + 1
                Continue While
            Else
                u.SendEmail("fdt@fieldaero.com", ds.Tables("Emails").Rows(i).Item("Email"), EmailSubject, EmailBody)
            End If

            i = i + 1
        End While

        ds.Tables("Emails").Clear()
        ds.Tables("Emails").Dispose()



        'SEND EMAIL
        ''If Email <> "" Then
        ''    myMessage.Subject = EmailSubject
        ''    myMessage.Body = EmailBody
        ''    'Dim emailBCC As MailAddress = New MailAddress("jwebster@fieldaero.com")
        ''    'myMessage.Bcc.Add(emailBCC)

        ''    client = New SmtpClient(SMTPServer)
        ''    client.Credentials = Net.CredentialCache.DefaultNetworkCredentials

        ''    'client.Credentials = New NetworkCredential("user@somecompany.com", "password")

        ''    client.Send(myMessage)
        ''End If


DONOTSENDEMAIL:
        Email = ""
        MoreEmails = ""
        EmailBody = ""
        EmailSubject = ""

    End Function

    Private Sub GridView13_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView13.RowStyle

        'GREY OUT RECORDS THAT ARE SET TO INCORPORATED
        Dim ViewIncorporated As GridView = GridView13
        Dim isRedIncorporated As String = ViewIncorporated.GetRowCellDisplayText(e.RowHandle, ViewIncorporated.Columns("Status"))

        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim isIncorporated As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))

            If isIncorporated = "Incorporated" Then
                e.Appearance.BackColor = Color.Silver
            End If

        End If
    End Sub




    '*** ISSUES/EQN ---------------------------------------------------------------------------------------------------------------------------------------------
    Public Function SearchIssues()

        Dim SqlString As String

        DsIssues1.tblDrawingsOfEARR.Clear()

        txtIssuesRecordID.DataBindings.Clear()
        txtTypeOfIssue.DataBindings.Clear()
        txtEarrNumIssues.DataBindings.Clear()

        Dim cmdSave As String
        cmdSave = daIssues.SelectCommand.CommandText
        SqlString = " Where DrawNum = '" & Me.txtMainDrawingNumber.Text & "' UNION SELECT RecordID,Earr,IssueNumber,DrawNum,Rev,DrawNumRev,DrawTitle,Response,IssueType,Status,OriginatorName,OriginatorDate,DateClosed,Request,ProgramName,Comments,Type,DateIncorporated,Project,EQNNumber,Category, ERAS, DateERASUpdated, ERASUpdatedBy FROM tblDrawingsOfEQN Where DrawNum = '" & Me.txtMainDrawingNumber.Text & "' UNION Select RecordID,CONVERT(varchar(100),NCRNumber) Earr,CONVERT(varchar(100),NCRNumber) NCRNumber,DrawingNumber,DwgRevision,DrawingNumber + ' ' + DwgRevision,'','',Type,Status,OriginatorName,SubmissionDt,CONVERT(varchar(100),DateClosed),Discrepancy,Program,Comments,'NCR','','',CONVERT(varchar(100),NCRNumber) NCRNumber,'',ERAS,DateERASUpdated,ERASUpdatedBy From NCR.dbo.tblNCR Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' Order By Type, RecordID"
        daIssues.SelectCommand.CommandText() += SqlString

        Try
            daIssues.Fill(DsIssues1.tblDrawingsOfEARR)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        daIssues.SelectCommand.CommandText = cmdSave

        If DsIssues1.Tables("tblDrawingsOfEARR").Rows.Count <> 0 Then
            'Create DataBindings          
            txtIssuesRecordID.DataBindings.Add("Text", bsIssues, "RecordID")
            txtTypeOfIssue.DataBindings.Add("Text", bsIssues, "Type")
        End If

    End Function


    Private Sub btnViewIssue_Click(sender As Object, e As EventArgs) Handles btnViewIssue.Click

        If TypeOfIssue = "NCR" Then

            'View the Edit screen of the NCR number of the record selected in the grid
            If IsNothing(NCRNumIssues) Or IsDBNull(NCRNumIssues) Then
                NCRNumIssues = ""
            End If

            If NCRNumIssues = "" Then

                Dim selectedRows() As Integer = GridView14.GetSelectedRows()
                For Each rowHandle As Integer In selectedRows
                    If rowHandle >= 0 Then
                        'Get NCR Number and Type of selected record
                        If IsDBNull(GridView14.GetRowCellValue(rowHandle, colEarr)) Then
                            NCRNumIssues = ""
                        Else
                            NCRNumIssues = GridView14.GetRowCellValue(rowHandle, colEarr)
                        End If
                    End If
                Next rowHandle

                If NCRNumIssues <> "" Then
                    da1 = New SqlClient.SqlDataAdapter("Select RecordID From tblNCR Where NCRNumber = '" & NCRNumIssues & "'", SqlConnection5)
                    da1.Fill(ds, "RecIDIssues")
                    If ds.Tables("RecIDIssues").Rows.Count > 0 Then
                        RecordIDNCR = ds.Tables("RecIDIssues").Rows(0).Item("RecordId")

                        ds.Tables("RecIDIssues").Clear()
                        ds.Tables("RecIDIssues").Dispose()
                    End If

                    NCRNumIssues = ""

                    frmNCRSteps.Show()
                End If

            Else

                da1 = New SqlClient.SqlDataAdapter("Select RecordID From tblNCR Where NCRNumber = '" & NCRNumIssues & "'", SqlConnection5)
                da1.Fill(ds, "RecIDIssues")
                If ds.Tables("RecIDIssues").Rows.Count > 0 Then
                    RecordIDNCR = ds.Tables("RecIDIssues").Rows(0).Item("RecordId")

                    ds.Tables("RecIDIssues").Clear()
                    ds.Tables("RecIDIssues").Dispose()
                End If

                NCRNumIssues = ""

                frmNCRSteps.Show()
                'frmEARRApproval.Activate()
                'Me.Close()
            End If


        Else

            'View the Edit screen of the EARR number of the record selected in the grid
            If IsNothing(EarrNumIssues) Or IsDBNull(EarrNumIssues) Then
                EarrNumIssues = ""
            End If

            If EarrNumIssues = "" Then

                Dim selectedRows() As Integer = GridView14.GetSelectedRows()
                For Each rowHandle As Integer In selectedRows
                    If rowHandle >= 0 Then
                        'Get EarrNumber and Type of selected record
                        If IsDBNull(GridView14.GetRowCellValue(rowHandle, colEarr)) Then
                            EarrNumIssues = ""
                        Else
                            EarrNumIssues = GridView14.GetRowCellValue(rowHandle, colEarr)
                        End If
                    End If
                Next rowHandle

                If EarrNumIssues <> "" Then
                    da1 = New SqlClient.SqlDataAdapter("Select RecordID From tblEARR Where EARRNumber = '" & EarrNumIssues & "'", SqlConnection4)
                    da1.Fill(ds, "RecIDIssues")
                    If ds.Tables("RecIDIssues").Rows.Count > 0 Then
                        EditEARR = ds.Tables("RecIDIssues").Rows(0).Item("RecordId")

                        ds.Tables("RecIDIssues").Clear()
                        ds.Tables("RecIDIssues").Dispose()
                    End If

                    EarrNumIssues = ""

                    frmEARRApproval.Show()
                End If

            Else

                da1 = New SqlClient.SqlDataAdapter("Select RecordID From tblEARR Where EARRNumber = '" & EarrNumIssues & "'", SqlConnection4)
                da1.Fill(ds, "RecIDIssues")
                If ds.Tables("RecIDIssues").Rows.Count > 0 Then
                    EditEARR = ds.Tables("RecIDIssues").Rows(0).Item("RecordId")

                    ds.Tables("RecIDIssues").Clear()
                    ds.Tables("RecIDIssues").Dispose()
                End If

                EarrNumIssues = ""

                frmEARRApproval.Show()
                'frmEARRApproval.Activate()
                'Me.Close()
            End If

        End If
    End Sub

    Private Sub btnExportIssue_Click(sender As Object, e As EventArgs) Handles btnExportIssue.Click

        'GET SEQUENCE NUMBER TO MAKE FILENAME TO SAVE UNIQUE
        Dim SeqNum As Integer = 0
        Dim TodaysDate As String = DateTime.Now.ToString("MMddyyyy")

        da = New SqlClient.SqlDataAdapter("Select TOP 1 * From tblIncreaseFileNameByOne Where Date = '" & TodaysDate & "' And UsedFor = 'EARR' Order by RecordID desc", SqlConnection4)
        da.Fill(ds, "GetSeqEarr")
        If ds.Tables("GetSeqEarr").Rows.Count > 0 Then
            SeqNum = ds.Tables("GetSeqEarr").Rows(0).Item("Seq")
        Else
            SeqNum = 1
        End If


        GridControl14.ExportToXlsx("C:\Temp\ExportIssue_" & TodaysDate & "_" & SeqNum & ".xlsx")
        MsgBox("Grid has been exported to c:\temp\ExportIssue_" & TodaysDate & "_" & SeqNum & ".xlsx")


        'ENTER NEXT SEQUENCE NUMBER THAT WILL BE USED FOR NEXT FILE THAT WILL BE SAVED
        SeqNum += 1
        u.ExecuteSQL(SqlConnection4, "Insert Into tblIncreaseFileNameByOne (Seq, Date, UsedFor) Values (" & SeqNum & ", '" & TodaysDate & "', 'EARR')")


        ds.Tables("GetSeqEarr").Clear()
        ds.Tables("GetSeqEarr").Dispose()
        SeqNum = 0
    End Sub

    Private Sub GridView14_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView14.FocusedRowChanged

        Dim selectedRows() As Integer = GridView14.GetSelectedRows()
        For Each rowHandle As Integer In selectedRows
            If rowHandle >= 0 Then
                'Get EarrNumber and Type of selected record
                If IsDBNull(GridView14.GetRowCellValue(rowHandle, colEarr)) Then
                    EarrNumIssues = ""
                    NCRNumIssues = ""
                Else
                    EarrNumIssues = GridView14.GetRowCellValue(rowHandle, colEarr)
                    NCRNumIssues = GridView14.GetRowCellValue(rowHandle, colEarr)
                End If

                If IsDBNull(GridView14.GetRowCellValue(rowHandle, colTypeIssues)) Then
                    TypeOfIssue = ""
                Else
                    TypeOfIssue = GridView14.GetRowCellValue(rowHandle, colTypeIssues)
                End If

            End If
        Next rowHandle

        'EQNs do not have to be edited
        If TypeOfIssue = "EQN" Then
            btnViewIssue.Enabled = False
        Else
            btnViewIssue.Enabled = True
        End If


        'Control visibility of the button that reverses the ERAS of an Earr (in Production Issues tab) in case it was closed in error 
        Dim ERAS As String = GridView14.GetRowCellValue(GridView14.FocusedRowHandle, "ERAS")

        If CM = True Or isAdmin = "T" Then
            If ERAS = "Closed" Then
                btnReverseClosedEarr.Visible = True
            Else
                btnReverseClosedEarr.Visible = False
            End If
        Else
            btnReverseClosedEarr.Visible = False
        End If

    End Sub

    Private Sub btnCloseIssue_Click(sender As Object, e As EventArgs) Handles btnCloseIssue.Click

        RowSelectedUpperGrid = GridView14.FocusedRowHandle


        If Me.txtTypeOfIssue.Text = "EQN" Then
            u.ExecuteSQL(SqlConnection4, "Update tblDrawingsofEQN Set ERAS = 'Closed', DateERASUpdated = '" & Now & "', ERASUpdatedBy = '" & System.Environment.UserName & "' Where RecordID = '" & Val(Me.txtIssuesRecordID.Text) & "'")
        ElseIf Me.txtTypeOfIssue.Text = "EARR" Then
            u.ExecuteSQL(SqlConnection4, "Update tblDrawingsofEARR Set ERAS = 'Closed', DateERASUpdated = '" & Now & "', ERASUpdatedBy = '" & System.Environment.UserName & "' Where RecordID = '" & Val(Me.txtIssuesRecordID.Text) & "'")
        ElseIf Me.txtTypeOfIssue.Text = "EARR - ResponseDoc" Then   'Added this line because the Type seemed to be set to "EARR - ResponseDoc" and therefore none of the 3 Ifs where being executed to close the issue
            u.ExecuteSQL(SqlConnection4, "Update tblDrawingsofEARR Set ERAS = 'Closed', DateERASUpdated = '" & Now & "', ERASUpdatedBy = '" & System.Environment.UserName & "' Where RecordID = '" & Val(Me.txtIssuesRecordID.Text) & "'")
        ElseIf Me.txtTypeOfIssue.Text = "NCR" Then
            u.ExecuteSQL(SqlConnection5, "Update tblNCR Set ERAS = 'Closed', DateERASUpdated = '" & Now & "', ERASUpdatedBy = '" & System.Environment.UserName & "' Where RecordID = '" & Val(Me.txtIssuesRecordID.Text) & "'")
        End If

        SearchIssues()

        'Put the focus on the rows that were selected (for upper and lower grids) before hitting the save button
        GridView14.FocusedRowHandle = RowSelectedUpperGrid
        GridView14.SelectRow(RowSelectedUpperGrid)
    End Sub

    Private Sub btnReverseClosedEarr_Click(sender As Object, e As EventArgs) Handles btnReverseClosedEarr.Click

        RowSelectedUpperGrid = GridView14.FocusedRowHandle


        If Me.txtTypeOfIssue.Text = "EQN" Then
            u.ExecuteSQL(SqlConnection4, "Update tblDrawingsofEQN Set ERAS = 'Open', DateERASUpdated = '', ERASUpdatedBy = '' Where RecordID = '" & Val(Me.txtIssuesRecordID.Text) & "'")
        ElseIf Me.txtTypeOfIssue.Text = "EARR" Then
            u.ExecuteSQL(SqlConnection4, "Update tblDrawingsofEARR Set ERAS = 'Open', DateERASUpdated = '', ERASUpdatedBy = '' Where RecordID = '" & Val(Me.txtIssuesRecordID.Text) & "'")
        ElseIf Me.txtTypeOfIssue.Text = "EARR - ResponseDoc" Then   'Added this line because the Type seemed to be set to "EARR - ResponseDoc" and therefore none of the 3 Ifs where being executed to close the issue
            u.ExecuteSQL(SqlConnection4, "Update tblDrawingsofEARR Set ERAS = 'Open', DateERASUpdated = '', ERASUpdatedBy = '' Where RecordID = '" & Val(Me.txtIssuesRecordID.Text) & "'")
        ElseIf Me.txtTypeOfIssue.Text = "NCR" Then
            u.ExecuteSQL(SqlConnection5, "Update tblNCR Set ERAS = 'Open', DateERASUpdated = '', ERASUpdatedBy = '' Where RecordID = '" & Val(Me.txtIssuesRecordID.Text) & "'")
        End If

        SearchIssues()

        'Put the focus on the rows that were selected (for upper and lower grids) before hitting the save button
        GridView14.FocusedRowHandle = RowSelectedUpperGrid
        GridView14.SelectRow(RowSelectedUpperGrid)
    End Sub




    'Private Sub GridView5_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView5.CellValueChanged
    '    Dim selectedRows() As Integer = GridView5.GetSelectedRows()
    '    For Each rowHandle As Integer In selectedRows
    '        If rowHandle >= 0 Then
    '            Dim cellValue = GridView5.GetRowCellValue(rowHandle, colDRNADCNStatus)
    '        End If
    '    Next rowHandle
    'End Sub


    ''Private Sub Button1_Click(sender As Object, e As EventArgs)
    ''    da = New SqlClient.SqlDataAdapter("Select * from tblDrawings Where DocumentType = 'Drawing Request'", SqlConnection1)
    ''    da.Fill(ds, "UpdateMe")

    ''    Dim x As Integer = 0

    ''    While x <= ds.Tables("UpdateMe").Rows.Count - 1
    ''        u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DocumentType = '" & ds.Tables("UpdateMe").Rows(x).Item("DrawingType") & "' Where RecordID = '" & Val(ds.Tables("UpdateMe").Rows(x).Item("RecordID")) & "'")

    ''        x = x + 1
    ''    End While

    ''    MsgBox("Done.")
    ''End Sub

    ''Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ''    da = New SqlClient.SqlDataAdapter("SELECT * from tblVisible1", SqlConnection1)
    ''    da.Fill(ds, "ROOT")

    ''    Dim z As Integer = 0

    ''    While z <= ds.Tables("ROOT").Rows.Count - 1
    ''        u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Visible = 'False' Where RecordID = '" & Val(ds.Tables("ROOT").Rows(z).Item("RecordID")) & "'")
    ''        z = z + 1
    ''    End While

    ''    MsgBox("Done")
    ''End Sub
End Class
