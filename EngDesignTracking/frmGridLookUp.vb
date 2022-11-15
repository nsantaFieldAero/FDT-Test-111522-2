
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports System.ComponentModel

Imports System
Imports System.IO
Imports System.Text

Public Class frmGridLookUp
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim da2 As SqlClient.SqlDataAdapter
    Dim ds2 As New DataSet
    Dim Path As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "XtraGrid_SaveLayoutToXML.xml")
    Dim JaguarOnly As Boolean
    Dim SaveGrid As String

    Private Sub frmGridLookUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        If System.Environment.UserName = "rwatson" Or System.Environment.UserName = "cnguyen" Or System.Environment.UserName = "pcampbell" Or System.Environment.UserName = "jwebster" Or System.Environment.UserName = "fmiller" Or System.Environment.UserName = "opalacio" Then
        Else
            Me.btnDrawingCert.Enabled = False

        End If

        'Check if the xml file that will contain the settings saved exists
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



        SqlConnection1.ConnectionString = sqlString

        'Fill program drop down, that you get by selecting a cell under the program column, with values from database
        da = New SqlClient.SqlDataAdapter("Select * from tblProgram Order By ProgramName", SqlConnection1)
        da.Fill(ds, "Programs")

        Dim i As Integer = 0
        While i <= ds.Tables("Programs").Rows.Count - 1
            RepositoryItemComboBox1.Items.Add(ds.Tables("Programs").Rows(i).Item("ProgramName"))
            i = i + 1
        End While

        ds.Tables("Programs").Clear()
        ds.Tables("Programs").Dispose()

        '''Fill program drop down, that you get by selecting a cell under the program column, with values from database
        ''da = New SqlClient.SqlDataAdapter("Select * from tblPriority Where Active = 'True' Order By Name Asc", SqlConnection1)
        ''da.Fill(ds, "Priority")

        ''i = 0
        ''While i <= ds.Tables("Priority").Rows.Count - 1
        ''    RepositoryItemComboBox7.Items.Add(ds.Tables("Priority").Rows(i).Item("Name"))
        ''    i = i + 1
        ''End While

        ''ds.Tables("Priority").Clear()
        ''ds.Tables("Priority").Dispose()

        i = 0

        'Load DocumentType
        da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where Active = 'True' Order By DocumentType Asc", SqlConnection1)
        da.Fill(ds, "DocType")

        While i <= ds.Tables("DocType").Rows.Count - 1
            Me.RepositoryItemComboBox5.Items.Add(ds.Tables("DocType").Rows(i).Item("DocumentType"))
            i = i + 1
        End While

        ds.Tables("DocType").Clear()
        ds.Tables("DocType").Dispose()

        i = 0

        'Load DocumentType
        da = New SqlClient.SqlDataAdapter("Select * from tblWhiteBoardNumber Where Active = 'True' Order By Sequence Asc", SqlConnection1)
        da.Fill(ds, "WB")

        While i <= ds.Tables("WB").Rows.Count - 1
            Me.RepositoryItemComboBox8.Items.Add(ds.Tables("WB").Rows(i).Item("Name"))
            i = i + 1
        End While

        ds.Tables("WB").Clear()
        ds.Tables("WB").Dispose()




        'SqlConnection1.ConnectionString = sqlString

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

            If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
                'Do Nothing
            Else
                Me.btnDelete.Visible = False
            End If
            If SaveGrid = "T" Then
                Me.btnSaveGrid.Enabled = True
            Else
                Me.btnSaveGrid.Enabled = False
            End If
            If ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
                Me.UsersToolStripMenuItem.Enabled = True
                Me.ProgramsToolStripMenuItem.Enabled = True
                Me.CertificationStaffToolStripMenuItem.Enabled = True
                Me.LovMaintenanceToolStripMenuItem.Enabled = True
            Else
                Me.UsersToolStripMenuItem.Enabled = False
                Me.ProgramsToolStripMenuItem.Enabled = False
                Me.CertificationStaffToolStripMenuItem.Enabled = False
                Me.LovMaintenanceToolStripMenuItem.Enabled = False
            End If
            If ds.Tables("USERAUTHENtICATE").Rows(0).Item("ProjectSync") = True Then
                Me.ProjectServerWorkflowSyncToolStripMenuItem.Enabled = True
            Else
                Me.ProjectServerWorkflowSyncToolStripMenuItem.Enabled = False

            End If

            Search()
        Else
            MsgBox("You are not setup as an authorized user.")
            Application.Exit()
        End If


        'Commented it out because they requested not to have it
        'GridView1.BestFitColumns()

    End Sub

    Private Sub frmGridLookUp_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        ' Save the layout/formatting of the grid to an XML file when the form gets closed
        GridControl1.MainView.SaveLayoutToXml(Path)

    End Sub

 Public Function Search()

        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet21.tblDrawings.Clear()

        Me.txtRecordID.DataBindings.Clear()
        Me.txtLocation.DataBindings.Clear()
        Me.txtProgram.DataBindings.Clear()
        Me.txtStatus.DataBindings.Clear()
        Me.txtDrawingNumber.DataBindings.Clear



        Dim cmdSave As String
        SqlString = " Where RecordID = RecordID"
        If chkShowStageComplete.Checked = False Then
            SqlString = SqlString + " And Status NOT IN ('GATE 6: Complete', 'GATE 9: Complete')"
        Else
        End If

        If JaguarOnly = True Then
            SqlString = SqlString + " and Program = 'Jaguar'"
            SqlString = SqlString + " OR Program = '2635 – Jaguar'"
            If chkShowStageComplete.Checked = False Then
                SqlString = SqlString + " And Status NOT IN ('GATE 6: Complete', 'GATE 9: Complete')"
            Else
            End If
        End If

        If JaguarOnly = True Then

        End If

        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter1.Fill(DataSet21.tblDrawings)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet21.Tables("tblDrawings").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            Search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text",
            Me.BindingSource2, "RecordID")

            Me.txtLocation.DataBindings.Add("Text",
            Me.BindingSource2, "Location")
            Me.txtProgram.DataBindings.Add("Text",
Me.BindingSource2, "Program")
            Me.txtStatus.DataBindings.Add("Text",
            Me.BindingSource2, "Status")
            Me.txtDrawingNumber.DataBindings.Add("Text",
Me.BindingSource2, "DrawingNumber")

        Else
            MsgBox("No Records Exist")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If

    End Function

    Private Sub btnSubmitNewDrawingRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitNewDrawingRequest.Click
        ConfirmSave()

        'Opening frmNewDWGRequest form
        Dim frmNewDWGRequest As New frmNewDWGRequest

        'We are calling the ShowDialog Method.  The ShowDialog method opens the form and suspends activity on this current form.  When the form frmNewDwgRequest is closed, activity will continue on this form
        'and the code Search() will execute.
        frmNewDWGRequest.ShowDialog()
        Search()

    End Sub

    Private Sub btnEditandViewRow_Click(sender As Object, e As EventArgs) Handles btnEditandViewRow.Click
        ConfirmSave()
        RecordToEdit = Val(txtRecordID.Text)
        DrawingNumberToEdit = Me.txtDrawingNumber.Text
        Dim frmEditRecord As New frmEditRecord
        frmEditRecord.ShowDialog()
        Search()

    End Sub

    Private Sub btnSaveGrid_Click(sender As Object, e As EventArgs) Handles btnSaveGrid.Click
        Me.SqlDataAdapter1.Update(DataSet21.tblDrawings)
        Search()
    End Sub

    Private Sub btnExportGrid_Click(sender As Object, e As EventArgs) Handles btnExportGrid.Click
        GridControl1.ExportToXlsx("C:\Temp\Export.xlsx")
        MsgBox("Grid has been exported to c:\temp\export.xlsx.")
        'Open the excel file.

    End Sub

    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles txtLocation.TextChanged

        RepositoryItemComboBox2.Items.Clear()



        ''If txtLocation.Text = "Toronto" Then
        ''    RepositoryItemComboBox2.Items.Add("GATE 0: CM Needs To Assign DWG Number")
        ''    RepositoryItemComboBox2.Items.Add("GATE 1: DWG Ready For Drafter")
        ''    RepositoryItemComboBox2.Items.Add("GATE 2: DWG Ready For Checker/Engineer")
        ''    RepositoryItemComboBox2.Items.Add("GATE 3: DWG Ready For Flammability")
        ''    RepositoryItemComboBox2.Items.Add("GATE 4: DWG Ready For Stress")
        ''    RepositoryItemComboBox2.Items.Add("GATE 5: DWG Ready For Avionics")
        ''    RepositoryItemComboBox2.Items.Add("GATE 6: DWG Ready For Mechanical")
        ''    RepositoryItemComboBox2.Items.Add("GATE 7: DWG Ready For Release")
        ''    RepositoryItemComboBox2.Items.Add("GATE 8: DWG Released")
        ''    RepositoryItemComboBox2.Items.Add("GATE 9: Complete")
        ''ElseIf txtLocation.Text = "OKC" Then
        RepositoryItemComboBox2.Items.Add("GATE 0: CM Needs To Assign DWG Number")
            RepositoryItemComboBox2.Items.Add("GATE 1: DWG Ready For Drafter")
        RepositoryItemComboBox2.Items.Add("GATE 2: DWG Ready For Operations")
        RepositoryItemComboBox2.Items.Add("GATE 3: DWG Ready For Sr Engineer")
            RepositoryItemComboBox2.Items.Add("GATE 4: DWG Ready For Release")
            RepositoryItemComboBox2.Items.Add("GATE 5: DWG Released")
            RepositoryItemComboBox2.Items.Add("GATE 6: Complete")

        'RepositoryItemComboBox1.Items.Add(ProgramsBindingSource)
        'End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Here I am checking a value in the dataset that was filled in the form load event.  I am not connecting to the database.  I am only looking at the dataset
        'created dynamically.
        If ds.Tables("USERAUTHENTICATE").Rows.Count > 0 Then
            If ds.Tables("USERAUTHENTICATE").Rows(0).Item("GridEdit") = "T" Then
                ConfirmSave()
            Else
            End If
        End If
        Dim frmMain As New frmMain
        frmMain.Show()
        Me.Close()
    End Sub

    Public Function ConfirmSave()

        If SaveGrid = "T" Then
            Dim result As DialogResult = MessageBox.Show("Would you like to save changes to the grid before closing?",
                          "Title",
                          MessageBoxButtons.YesNo)

            If (result = DialogResult.Yes) Then
                Me.SqlDataAdapter1.Update(DataSet21.tblDrawings)
            Else
                'Nothing
            End If
        Else
            'Do Nothing because user is not allow to save grid changes.
        End If

    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtStatus.Text = "GATE 6: Complete" Then

            If CM = True Then
                Dim result As DialogResult = MessageBox.Show("Please confirm you would like to delete the current selected record.",
              "Title",
              MessageBoxButtons.YesNo)

                If (result = DialogResult.Yes) Then

                    u.ExecuteSQL(SqlConnection1, "DELETE from tblDrawings where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
                    MsgBox("Record has been deleted.  The screen will now be refreshed.")
                    Search()
                End If
            Else
                MsgBox("You cannot delete a record sitting at GATE 6.")
            End If

        Else
            Dim result As DialogResult = MessageBox.Show("Please confirm you would like to delete the current selected record.",
                          "Title",
                          MessageBoxButtons.YesNo)

            If (result = DialogResult.Yes) Then

                u.ExecuteSQL(SqlConnection1, "DELETE from tblDrawings where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
                MsgBox("Record has been deleted.  The screen will now be refreshed.")
                Search()
            End If
        End If

    End Sub

    Private Sub btnReturnToMainMenu_Click(sender As Object, e As EventArgs) Handles btnReturnToMainMenu.Click
        Dim frmMain As New frmMain
        frmMain.Show()
        Me.Close()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Search()

    End Sub

    Private Sub CertificationStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificationStaffToolStripMenuItem.Click
        Dim frmCertificationStaff As New frmCertificationStaff
        frmCertificationStaff.Show()

    End Sub

    Private Sub btnDrawingCert_Click(sender As Object, e As EventArgs) Handles btnDrawingCert.Click
        ConfirmSave()
        RecordToEdit = Val(txtRecordID.Text)

        Dim frmDrawingCertificationData As New frmDrawingCertificationData
        frmDrawingCertificationData.Show()

    End Sub

    Private Sub ProgramsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramsToolStripMenuItem.Click
        Dim Programs As New Programs
        Programs.Show()
        'Me.Close()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Dim AdminScreen As New AdminScreen
        AdminScreen.Show()
        'Me.Close()
    End Sub

    Private Sub SystemDescriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemDescriptionToolStripMenuItem.Click
        Dim frmlovSystemDescription As New frmlovSystemDescription
        frmlovSystemDescription.Show()
    End Sub

    Private Sub DocumentTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentTypeToolStripMenuItem.Click
        Dim frmlovDocumentType As New frmlovDocumentType
        frmlovDocumentType.Show()

    End Sub

    Private Sub ResourceTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResourceTypeToolStripMenuItem.Click
        Dim frmlovType As New frmLovType
        frmlovType.Show()

    End Sub

    Private Sub NameAssignmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NameAssignmentsToolStripMenuItem.Click
        Dim frmlovAssignmentNames As New frmlovAssignmentNames
        frmlovAssignmentNames.Show()

    End Sub

    Private Sub PriorityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PriorityToolStripMenuItem.Click
        Dim frmlovPriority As New frmlovPriority
        frmlovPriority.Show()

    End Sub

    Private Sub DRNADCNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DRNADCNToolStripMenuItem.Click
        Dim frmlovDRNADCN As New frmlovDRNADCN
        frmlovDRNADCN.Show()

    End Sub

    Private Sub NewReworkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewReworkToolStripMenuItem.Click
        Dim frmlovNewRework As New frmlovNewRework
        frmlovNewRework.Show()

    End Sub


    Private Sub txtProgram_TextChanged(sender As Object, e As EventArgs) Handles txtProgram.TextChanged
        'Fill program drop down, that you get by selecting a cell under the program column, with values from database

        RepositoryItemComboBox7.Items.Clear()

        da = New SqlClient.SqlDataAdapter("Select * from tblPriority Where Active = 'True' and Program = '" & Me.txtProgram.Text & "' Order By Name Asc", SqlConnection1)
        da.Fill(ds, "Priority")

        Dim i = 0
        While i <= ds.Tables("Priority").Rows.Count - 1
            RepositoryItemComboBox7.Items.Add(ds.Tables("Priority").Rows(i).Item("Name"))
            i = i + 1
        End While

        ds.Tables("Priority").Clear()
        ds.Tables("Priority").Dispose()
    End Sub

    Private Sub WhiteBoardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteBoardToolStripMenuItem.Click
        Dim frmlovWhiteBoard As New frmlovWhiteBoard
        frmlovWhiteBoard.Show()

    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub ProjectServerWorkflowSyncToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectServerWorkflowSyncToolStripMenuItem.Click
        Dim frmProjectWorkflowSync As New frmProjectWorkflowSync
        frmProjectWorkflowSync.Show()
    End Sub

    Private Sub CertificationFilterGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificationFilterGridToolStripMenuItem.Click
        Dim frmcertgrid As New frmCertGrid
        frmcertgrid.Show()
    End Sub

    Private Sub CertificationMassUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificationMassUpdateToolStripMenuItem.Click

    End Sub
End Class