Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class Projects

    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim da2 As SqlClient.SqlDataAdapter
    Dim ds2 As New DataSet
    Dim da3 As SqlClient.SqlDataAdapter
    Dim ds3 As New DataSet
    Dim da4 As SqlClient.SqlDataAdapter
    Dim ds4 As New DataSet
    Dim RecordIDSystemSelected As String
    Dim AircraftSelected As String
    Public RowSelectedProjectsGrid
    Dim PageJustOpened As String
    Dim b As Integer = 0
    Dim AddBtnClicked As String = ""

    Private Sub Projects_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString
        SqlConnection2.ConnectionString = sqlString


        'txtAddProjNo.Enabled = False


        'Project grid
        Search()


        'Check User Access Privileges
        SqlConnection1.Open()
        da = New SqlClient.SqlDataAdapter("Select * from tblUsers Where Username = '" & LCase(System.Environment.UserName) & "'", SqlConnection1)
        da.Fill(ds, "USERAUTHENTICATE")
        If ds.Tables("USERAUTHENTICATE").Rows.Count > 0 Then
            CM = ds.Tables("USERAUTHENTICATE").Rows(0).Item("CM")
        End If


        ''Populate Aircrafts grid
        'SearchAircrafts()


        ''Populate Aircraft Serial Numbers grid
        'SearchAircraftsSerialNum()

        SqlConnection1.Close()
        b = 0
        AddBtnClicked = "No"
    End Sub

    'PROJECTS GRID
    Public Function Search()

        Dim StringSql As String


        Me.DsProjects1.tblProjects.Clear()

        Me.txtRecordID.DataBindings.Clear()
        Me.cboProjectNumSave.DataBindings.Clear()
        Me.txtProjectName.DataBindings.Clear()
        Me.txtPDFFolder.DataBindings.Clear()
        Me.txtShortForm.DataBindings.Clear()
        Me.cboActive.DataBindings.Clear()
        Me.cboDocNumberingSave.DataBindings.Clear()
        Me.cboProductGroupSave.DataBindings.Clear()
        Me.txtProjectNameBeforeSaveChanges.DataBindings.Clear()



        'SqlConnection1.ConnectionString = sqlString
        Dim cmdSave As String
        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += StringSql

        Try
            Me.SqlDataAdapter1.Fill(DsProjects1.tblProjects)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        If Me.DsProjects1.Tables("tblProjects").Rows.Count <> 0 Then
            Search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text", Me.bsProjects, "RecordID")
            Me.cboProjectNumSave.DataBindings.Add("Text", Me.bsProjects, "ProjectNumber")
            Me.txtProjectName.DataBindings.Add("Text", Me.bsProjects, "ProjectName")
            Me.txtPDFFolder.DataBindings.Add("Text", Me.bsProjects, "PDFFolder")
            Me.txtShortForm.DataBindings.Add("Text", Me.bsProjects, "ShortForm")
            Me.cboActive.DataBindings.Add("Text", Me.bsProjects, "Active")
            Me.cboDocNumberingSave.DataBindings.Add("Text", Me.bsProjects, "DocNumbering")
            Me.cboProductGroupSave.DataBindings.Add("Text", Me.bsProjects, "ProductGroup")
            Me.txtProjectNameBeforeSaveChanges.DataBindings.Add("Text", Me.bsProjects, "ProjectName")

        Else
            MsgBox("No Records Exist")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If
    End Function

    'AIRCRAFTS GRID
    Public Function SearchAircrafts()

        Me.DsAircraftsProjectsScreen1.tblAircrafts.Clear()
        Me.txtRecordIDAircrafts.DataBindings.Clear()

        Dim cmdSave As String
        Dim StringSql As String = " Where ProjectName = '" & ProjectSelected & "'"

        cmdSave = Me.SqlDataAdapter3.SelectCommand.CommandText
        Me.SqlDataAdapter3.SelectCommand.CommandText() += StringSql



        If (SqlConnection2.State = ConnectionState.Open) Then
            SqlConnection2.Close()
        Else
            SqlConnection2.Open()
        End If


        Try
            Me.SqlDataAdapter3.Fill(DsAircraftsProjectsScreen1.tblAircrafts)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter3.SelectCommand.CommandText = cmdSave



        If DsAircraftsProjectsScreen1.Tables("tblAircrafts").Rows.Count <> 0 Then
            'Create DataBindings
            Me.txtRecordIDAircrafts.DataBindings.Add("Text", Me.bsAircrafts, "RecordID")
        End If


        'Populate Aircraft col dropdown inside the Associated Aircrafts grid
        If (SqlConnection1.State = ConnectionState.Open) Then
            SqlConnection1.Close()
        Else
            SqlConnection1.Open()
        End If

        RepositoryItemComboBox2.Items.Clear()
        da4 = New SqlClient.SqlDataAdapter("Select Aircraft From tblAircraftsLOVMaint", SqlConnection1)     'Where Program = '" & ProjectSelected & "' And Active = 1
        da4.Fill(ds4, "Aircraft")
        If (SqlConnection1.State = ConnectionState.Open) Then
            SqlConnection1.Close()
        End If

        Dim i As Integer = 0
        While i <= ds4.Tables("Aircraft").Rows.Count - 1
            RepositoryItemComboBox2.Items.Add(ds4.Tables("Aircraft").Rows(i).Item("Aircraft"))
            i = i + 1
        End While

        ds4.Tables("Aircraft").Clear()
        ds4.Tables("Aircraft").Dispose()
    End Function

    'SERIAL NUMBERS GRID
    Public Function SearchAircraftsSerialNum()

        Me.DsAircraftSerial1.tblAircraftSerialNums.Clear()
        Me.txtRecordIDSerial.DataBindings.Clear()


        If IsDBNull(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Aircraft")) Then
            AircraftSelected = ""
        Else
            AircraftSelected = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Aircraft")
        End If


        Dim cmdSave As String
        Dim StringSql As String = " Where Aircraft = '" & AircraftSelected & "' And Project = '" & ProjectSelected & "'"

        cmdSave = Me.SqlDataAdapter4.SelectCommand.CommandText
        Me.SqlDataAdapter4.SelectCommand.CommandText() += StringSql


        If (SqlConnection2.State = ConnectionState.Open) Then
            SqlConnection2.Close()
        Else
            SqlConnection2.Open()
        End If


        Try
            Me.SqlDataAdapter4.Fill(DsAircraftSerial1.tblAircraftSerialNums)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter4.SelectCommand.CommandText = cmdSave



        If DsAircraftSerial1.Tables("tblAircraftSerialNums").Rows.Count <> 0 Then

            'Create DataBindings
            Me.txtRecordIDSerial.DataBindings.Add("Text", Me.bsAircraftSerial, "RecordID")

        End If


        'Populate Aircraft col dropdown inside the Serial Numbers grid
        RepositoryItemComboBox3.Items.Clear()

        da4 = New SqlClient.SqlDataAdapter("Select Distinct Aircraft From tblAircrafts Where ProjectName = '" & txtProjectName.Text & "'", SqlConnection2)
        da4.Fill(ds4, "Aircraft")

        Dim i As Integer = 0
        While i <= ds4.Tables("Aircraft").Rows.Count - 1
            RepositoryItemComboBox3.Items.Add(ds4.Tables("Aircraft").Rows(i).Item("Aircraft"))
            i = i + 1
        End While

        ds4.Tables("Aircraft").Clear()
        ds4.Tables("Aircraft").Dispose()
    End Function

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim ProductGroupAdd As String = ""


        AddBtnClicked = "Yes"
        b = 0


        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If


        'AddNew = "Yes"

        If txtAddProjDesc.Text = "" Then
            MsgBox("Please enter Project Description")
            Exit Sub
        End If


        ''Get Sequence for Project number
        'u.ExecuteSQL(SqlConnection1, "Insert into tblProjectsNumbering (ProjectName) Values ('IncreaseOne')")

        'da = New SqlClient.SqlDataAdapter("Select Top 1 Sequence From tblProjectsNumbering Order By Sequence Desc", SqlConnection1)
        'da.Fill(ds, "Top1")
        'Dim Sequence As Integer = Val(ds.Tables("Top1").Rows(0).Item("Sequence"))
        ''Dim Year As String = Date.Today.Year       'Per Owen, Commented this block of code as the year does not go in the project number
        ''Year = Year.Substring(2, 2)
        ''ds.Tables("Top1").Clear()
        ''ds.Tables("Top1").Dispose()

        'txtAddProjNo.Text = Sequence


        If txtAddProjNo.Text = "" Or txtAddProjNo.Text.Length <> 4 Or Not (IsNumeric(txtAddProjNo.Text)) Then
            MsgBox("Please enter a 4 digits numeric format Project Number")
            Exit Sub
        End If

        'SqlConnection1.Open()
        u.ExecuteSQL(SqlConnection1, "Insert into tblProjects (ProjectName, ProjectNumber, ProgramName) Values ('" & u.FTM(Me.txtAddProjDesc.Text) & "', '" & Val(Me.txtAddProjNo.Text) & "', '" & u.FTM(Me.txtAddProjDesc.Text) & "')")
        u.ExecuteSQL(SqlConnection1, "Insert into tblProgramCertification (Program, FAAProjectNo, LeadCertEngineer) Values ('" & u.FTM(Me.txtAddProjDesc.Text) & "', '', '')")  'Per ticket # 4728, added this line. Since the program changed to projects, now it is the projects that need to be added to the table in this line

        'SqlConnection1.Close()


        Search()



        ProjectSelected = txtProjectName.Text

        GetSystemsTableData()

        'Populate Aircrafts grid
        SearchAircrafts()

        'Populate Aircraft Serial Numbers grid
        SearchAircraftsSerialNum()


        MsgBox("Project Added")

        'AddNew = "No"
        txtAddProjDesc.Text = ""
        txtAddProjNo.Text = ""
        'cbAddDocNumbering.SelectedIndex = -1
        'cbAddProductGroup.SelectedIndex = -1

        AddBtnClicked = "No"
        b += 1
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        ''GridView2.Columns.Clear()


        'Clear previous data from Systems grid if data already existed from before
        If IsNothing(DsSystems1.Tables("tblSystemDescription")) Then
            'nothing
        Else
            DsSystems1.Tables("tblSystemDescription").Clear()
            DsSystems1.Tables("tblSystemDescription").Dispose()
        End If


        ProjectSelected = txtProjectName.Text


        'Populate the list containing the programs to which the selected project has been assigned to
        'If (SqlConnection1.State = ConnectionState.Open) Then
        '    'Nothing
        'Else
        '    SqlConnection1.Open()
        'End If

        da2 = New SqlClient.SqlDataAdapter("Select ProgramName From tblProgram_Project Where ProjectName = '" & txtProjectName.Text & "'", SqlConnection2)
        da2.Fill(ds2, "Programs")
        'SqlConnection1.Close()

        Dim i As Integer = 0
        lstAssignedPrograms.Items.Clear()
        While i <= ds2.Tables("Programs").Rows.Count - 1
            lstAssignedPrograms.Items.Add(ds2.Tables("Programs").Rows(i).Item("ProgramName"))
            i = i + 1
        End While

        ds2.Tables("Programs").Clear()
        ds2.Tables("Programs").Dispose()


        'Populate Systems grid according to the selection in the Projects grid. The Ifs statements are to only run it once when the Add New button is clicked(otherwise errors out)
        If AddBtnClicked = "Yes" Then
            If b = 0 Then
                GetSystemsTableData()
                b += 1
            End If
        Else
            GetSystemsTableData()
        End If
        'If b = 1 Then

        'End If

        'Populate Aircrafts grid
        SearchAircrafts()

        'Populate Aircraft Serial Numbers grid
        SearchAircraftsSerialNum()


        'Doc Numbering and Product Group is not visible when Canada
        Dim DocNumberingProjectSelected As String
        If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocNumbering")) Then
            DocNumberingProjectSelected = ""
        Else
            DocNumberingProjectSelected = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocNumbering")
        End If

        If DocNumberingProjectSelected = "Field Aerospace (Canada)" Then
            cboProductGroupSave.Visible = False
            lblProductGroupSave.Visible = False
        Else
            cboProductGroupSave.Visible = True
            lblProductGroupSave.Visible = True
        End If

    End Sub

    Public Function GetSystemsTableData()

        'SqlConnection1.ConnectionString = sqlString


        Me.DsSystems1.tblSystemDescription.Clear()


        ProjectSelected = txtProjectName.Text
        Dim StringSql As String = " Where Program = '" & ProjectSelected & "' And Active = 1"
        Dim cmdSave As String
        cmdSave = Me.SqlDataAdapter2.SelectCommand.CommandText
        Me.SqlDataAdapter2.SelectCommand.CommandText() += StringSql


        If (SqlConnection1.State = ConnectionState.Open) Then
            SqlConnection1.Close()
        Else
            SqlConnection1.Open()
        End If


        Try
            Me.SqlDataAdapter2.Fill(DsSystems1.tblSystemDescription)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter2.SelectCommand.CommandText = cmdSave

        'If (SqlConnection1.State = ConnectionState.Open) Then
        '    SqlConnection1.Close()
        'End If


        'Populate System Description col dropdown inside the Systems grid
        RepositoryItemComboBox1.Items.Clear()

        da3 = New SqlClient.SqlDataAdapter("Select Distinct System From tblSystems Where Active = 1", SqlConnection2)       'Program = '" & ProjectSelected & "' And 
        da3.Fill(ds3, "SystemDesc")
        'SqlConnection1.Close()

        Dim i As Integer = 0
        While i <= ds3.Tables("SystemDesc").Rows.Count - 1
            RepositoryItemComboBox1.Items.Add(ds3.Tables("SystemDesc").Rows(i).Item("System"))
            i = i + 1
        End While

        ds3.Tables("SystemDesc").Clear()
        ds3.Tables("SystemDesc").Dispose()

    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtAddProjNo.Text = ""
        txtAddProjDesc.Text = ""
    End Sub

    Private Sub btnDeleteProject_Click(sender As Object, e As EventArgs) Handles btnDeleteProject.Click

        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If


        'SqlConnection1.Open()

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected project?", "Title", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            u.ExecuteSQL(SqlConnection1, "Delete from tblProjects Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
            u.ExecuteSQL(SqlConnection1, "Delete from tblProgramCertification Where Program = '" & txtProjectNameBeforeSaveChanges.Text & "'")
            u.ExecuteSQL(SqlConnection1, "Delete from tblProgramCertificationUM Where Program = '" & txtProjectNameBeforeSaveChanges.Text & "'")
            u.ExecuteSQL(SqlConnection1, "Delete from tblProgramCertificationFAAOMTMember Where Program = '" & txtProjectNameBeforeSaveChanges.Text & "'")

            MsgBox("Project has been deleted.")
            Search()
        Else
            'Nothing
        End If

        'SqlConnection1.Close()
    End Sub

    Private Sub btnSaveSystems_Click(sender As Object, e As EventArgs) Handles btnSaveSystems.Click

        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If


        'Dim StringSql As String = " Where Program = '" & ProjectSelected & "' And Active = 1"

        'SqlConnection1.ConnectionString = sqlString

        'Dim cmdSave As String
        'cmdSave = Me.SqlDataAdapter2.SelectCommand.CommandText
        'Me.SqlDataAdapter2.SelectCommand.CommandText() += StringSql

        'Try
        '    Me.SqlDataAdapter2.Fill(DsSystems1.tblSystemDescription)
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        'Me.SqlDataAdapter2.SelectCommand.CommandText = cmdSave

        Try
            Me.SqlDataAdapter2.Update(DsSystems1, "tblSystemDescription")

            'Add to what Project the System(s) added belong to
            If (SqlConnection1.State = ConnectionState.Open) Then
                SqlConnection1.Close()
            Else
                SqlConnection1.Open()
            End If

            u.ExecuteSQL(SqlConnection1, "Update tblSystemDescription Set Program = '" & txtProjectName.Text & "', Active = 1 Where Program = '' Or Program Is Null")
            'SqlConnection1.Close()
            MsgBox("Data Saved")

        Catch ex As Exception
            MessageBox.Show("An error occured after clicking on Save for Systems." & vbLf & vbLf & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteSystems_Click(sender As Object, e As EventArgs) Handles btnDeleteSystems.Click
        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If


        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected system?", "Title", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            RecordIDSystemSelected = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "RecordID")

            If (SqlConnection1.State = ConnectionState.Open) Then
                SqlConnection1.Close()
            Else
                SqlConnection1.Open()
            End If

            u.ExecuteSQL(SqlConnection1, "Delete from tblSystemDescription Where RecordID = '" & RecordIDSystemSelected & "'")
            'SqlConnection1.Close()
            MsgBox("System has been deleted.")

            GetSystemsTableData()
        End If
    End Sub

    Private Sub btnSaveAssociatedAircraft_Click(sender As Object, e As EventArgs) Handles btnSaveAssociatedAircraft.Click
        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If


        Try
            Me.SqlDataAdapter3.Update(DsAircraftsProjectsScreen1.tblAircrafts)

            'Add to what Project the Aircraft(s) added belong to
            If (SqlConnection1.State = ConnectionState.Open) Then
                SqlConnection1.Close()
            Else
                SqlConnection1.Open()
            End If

            u.ExecuteSQL(SqlConnection1, "Update tblAircrafts Set ProjectName = '" & txtProjectName.Text & "' Where ProjectName = '' Or ProjectName Is Null")
            'SqlConnection1.Close()
            MsgBox("Data Saved")

            'SearchAircrafts()

            SearchAircraftsSerialNum()

        Catch ex As Exception
            MessageBox.Show("An error occured after clicking on Save for Associated Aircraft." & vbLf & vbLf & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteAssociatedAircraft_Click(sender As Object, e As EventArgs) Handles btnDeleteAssociatedAircraft.Click
        Dim AircraftToDelete As String = ""

        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If


        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected aircraft?", "Title", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            AircraftToDelete = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "RecordID")
            u.ExecuteSQL(SqlConnection2, "Delete from tblAircrafts Where RecordID = '" & AircraftToDelete & "'")    'Val(Me.txtRecordIDAircrafts.Text)
            SearchAircrafts()
        End If
    End Sub

    Private Sub btnSaveSerialNum_Click(sender As Object, e As EventArgs) Handles btnSaveSerialNum.Click
        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If


        Try
            Me.SqlDataAdapter4.Update(DsAircraftSerial1.tblAircraftSerialNums)

            'COMMENTED block of code below 08/03
            'Add to what Aircraft the Aircraft Serial(s) added belong to
            If (SqlConnection1.State = ConnectionState.Open) Then
                SqlConnection1.Close()
            Else
                SqlConnection1.Open()
            End If

            ''u.ExecuteSQL(SqlConnection1, "Update tblAircraftSerialNums Set Project = '" & txtProjectName.Text & "', Aircraft = '" & AircraftSelected & "' Where Project = '' Or Project Is Null")
            'ADDED line below and commented the one above
            u.ExecuteSQL(SqlConnection1, "Update tblAircraftSerialNums Set Project = '" & txtProjectName.Text & "' Where Project = '' Or Project Is Null")
            SqlConnection1.Close()
            MsgBox("Data Saved")

            ''SearchAircraftsSerialNum()

        Catch ex As Exception
            MessageBox.Show("An error occured after clicking on Save for Aircraft Serial Number." & vbLf & vbLf & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteSerialNum_Click(sender As Object, e As EventArgs) Handles btnDeleteSerialNum.Click
        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected serial number?", "Title", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then

            If (SqlConnection1.State = ConnectionState.Open) Then
                SqlConnection1.Close()
            Else
                SqlConnection1.Open()
            End If

            u.ExecuteSQL(SqlConnection1, "Delete from tblAircraftSerialNums Where RecordID = '" & Val(Me.txtRecordIDSerial.Text) & "'")
            SqlConnection1.Close()

            SearchAircraftsSerialNum()
        End If
    End Sub

    Private Sub btnSaveProject_Click(sender As Object, e As EventArgs) Handles btnSaveProject.Click

        Dim ProjectNum As String = ""
        Dim ShortForm As String = ""
        Dim PDFFolder As String = ""
        Dim Active As String = ""

        AddBtnClicked = "Yes"
        b = 0


        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If


        'WHEN SAVING GET THE ROW SELECTED FROM THE PROJECTS GRID, SO THAT I CAN HAVE IT SELECTED AFTER ALL THE SAVE CODE IS EXECUTED
        RowSelectedProjectsGrid = GridView1.FocusedRowHandle


        'SAVE
        If cboProjectNumSave.Text = "" Then
            MsgBox("Please enter the Project Number")
            Exit Sub
        End If
        ProjectNum = cboProjectNumSave.Text
        ShortForm = txtShortForm.Text
        PDFFolder = txtPDFFolder.Text
        Active = cboActive.Text


        'Updates to the Project Number fields
        If (SqlConnection1.State = ConnectionState.Open) Then
            SqlConnection1.Close()
        Else
            SqlConnection1.Open()
        End If



        u.ExecuteSQL(SqlConnection1, "Update tblProjects Set ProjectName = '" & txtProjectName.Text & "', ProjectNumber = '" & ProjectNum & "', ShortForm = '" & ShortForm & "', PDFFolder = '" & PDFFolder & "', Active = '" & Active & "', DocNumbering = '" & cboDocNumberingSave.Text & "', ProductGroup = '" & cboProductGroupSave.Text & "' Where RecordID = '" & txtRecordID.Text & "'")
        u.ExecuteSQL(SqlConnection1, "Update tblProgramCertification Set Program = '" & txtProjectName.Text & "' Where Program = '" & txtProjectNameBeforeSaveChanges.Text & "'")   'Per ticket # 4968 (original 4728)
        u.ExecuteSQL(SqlConnection1, "Update tblProgramCertificationUM Set Program = '" & txtProjectName.Text & "' Where Program = '" & txtProjectNameBeforeSaveChanges.Text & "'")   'Per ticket # 4968 (original 4728)
        u.ExecuteSQL(SqlConnection1, "Update tblProgramCertificationFAAOMTMember Set Program = '" & txtProjectName.Text & "' Where Program = '" & txtProjectNameBeforeSaveChanges.Text & "'")   'Per ticket # 4968 (original 4728)


        SqlConnection1.Close()

        MsgBox("Changes Saved")



        ProjectSelected = txtProjectName.Text

        'AddNew = "Yes"
        Search()
        'AddNew = "No"

        'Populate Aircrafts grid
        SearchAircrafts()

        'Populate Aircraft Serial Numbers grid
        SearchAircraftsSerialNum()



        'Put the focus on the row that was selected, for the Projects grid, before hitting the save button
        GridView1.FocusedRowHandle = RowSelectedProjectsGrid
        GridView1.SelectRow(RowSelectedProjectsGrid)


        GetSystemsTableData()


        AddBtnClicked = "No"
        b += 1
    End Sub

    Private Sub cboProjectNumSave_Click(sender As Object, e As EventArgs) Handles cboProjectNumSave.Click

        Me.cboProjectNumSave.Items.Clear()

        'Populate Product Group drop-down for saving
        If (SqlConnection1.State = ConnectionState.Open) Then
            SqlConnection1.Close()
        Else
            SqlConnection1.Open()
        End If

        da = New SqlClient.SqlDataAdapter("Select Distinct ProjectNumber From tblProjects Order By ProjectNumber", SqlConnection1)
        da.Fill(ds, "Projects")
        SqlConnection1.Close()

        Dim p As Integer = 0
        While p <= ds.Tables("Projects").Rows.Count - 1
            Me.cboProjectNumSave.Items.Add(ds.Tables("Projects").Rows(p).Item("ProjectNumber"))
            p = p + 1
        End While

        ds.Tables("Projects").Clear()
        ds.Tables("Projects").Dispose()
    End Sub

    Private Sub cboProductGroupSave_Click(sender As Object, e As EventArgs) Handles cboProductGroupSave.Click

        Me.cboProductGroupSave.Items.Clear()

        'Populate Product Group drop-down for saving
        If (SqlConnection1.State = ConnectionState.Open) Then
            SqlConnection1.Close()
        Else
            SqlConnection1.Open()
        End If

        da = New SqlClient.SqlDataAdapter("Select * from tblProductGroup Order By ProductGroup", SqlConnection1)
        da.Fill(ds, "ProductGroup")
        SqlConnection1.Close()

        Dim p As Integer = 0
        While p <= ds.Tables("ProductGroup").Rows.Count - 1
            Me.cboProductGroupSave.Items.Add(ds.Tables("ProductGroup").Rows(p).Item("ProductGroup"))
            p = p + 1
        End While

        ds.Tables("ProductGroup").Clear()
        ds.Tables("ProductGroup").Dispose()

    End Sub

    Private Sub txtRecordID_TextChanged(sender As Object, e As EventArgs) Handles txtRecordID.TextChanged

        'ProjectSelected = txtProjectName.Text
        'GetSystemsTableData()

        'SearchAircrafts()
    End Sub

    Private Sub txtRecordIDAircrafts_TextChanged(sender As Object, e As EventArgs) Handles txtRecordIDAircrafts.TextChanged
        SearchAircraftsSerialNum()
    End Sub

    'This is so that the user cannot free type text in the combobox Project Number
    Private Sub cboProjectNumSave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProjectNumSave.KeyPress
        e.Handled = True
    End Sub

    'This is so that the user cannot free type text in the combobox Product Group
    Private Sub cboProductGroupSave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProductGroupSave.KeyPress
        e.Handled = True
    End Sub

    'This is so that the user cannot free type text in the combobox Doc Numbering
    Private Sub cboDocNumberingSave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDocNumberingSave.KeyPress
        e.Handled = True
    End Sub

    Private Sub GridView2_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GridView2.ShowingEditor

        'This is to disallow editing in existing rows(and allow to create a new row)
        Dim rowHandle As Integer = GridView2.FocusedRowHandle
        If GridView2.FocusedRowHandle >= 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub GridView3_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GridView3.ShowingEditor

        'This is to disallow editing in existing rows(and allow to create a new row)
        Dim rowHandle As Integer = GridView3.FocusedRowHandle
        If GridView3.FocusedRowHandle >= 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub GridView4_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GridView4.ShowingEditor

        'This is to disallow editing in existing rows(and allow to create a new row)
        Dim rowHandle As Integer = GridView4.FocusedRowHandle
        If GridView4.FocusedRowHandle >= 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnCertificationManager_Click(sender As Object, e As EventArgs) Handles btnCertificationManager.Click
        CertManagerProgram = Me.txtProjectName.Text
        Dim frmCertificationManager As New frmCertificationManager
        frmCertificationManager.Show()
    End Sub



    'THE FOLLOWING TWO BLOCKS OF CODE WERE IN THE ORIGINAL PROGRAMS FORM
    'Private Sub btnTestPath_Click(sender As Object, e As EventArgs) Handles btnTestPath.Click
    '    Dim Path As String = Me.txtDirectory.Text
    '    Dim fs As FileStream
    '    Try
    '        Path = Path + "\test.txt"
    '        fs = File.Create(Path)
    '    Catch ex As Exception
    '        MsgBox("The network path is not valid or you do not have access to the network path.")
    '        Exit Sub

    '    End Try

    '    'Dim info As Byte() = New UTF8Encoding(True).GetBytes("Test Text.")
    '    'fs.Write(info, 0, info.Length)
    '    'fs.Close()
    '    MsgBox("Success!")
    '    fs.Close()
    '    File.Delete(Path)

    'End Sub

    'Private Sub btnSetPath_Click(sender As Object, e As EventArgs) Handles btnSetPath.Click
    '    u.ExecuteSQL(SqlConnection1, "Update tblProgram Set DocumentPath = '" & Me.txtDirectory.Text & "' Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
    '    MsgBox("Path Set.")
    'End Sub



    ''Private Sub GridView3_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView3.FocusedRowChanged

    ''    'Used to show in the Serial grid the serials related to the Aircraft selected
    ''    AircraftSelected = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Aircraft")

    ''    'Populate Aircrafts grid
    ''    If PageJustOpened = "" Then
    ''        PageJustOpened = "False"
    ''    Else
    ''        SearchAircraftsSerialNum()
    ''    End If
    ''End Sub

    ''Private Sub GridView2_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
    ''    'GridView1.FocusedRowHandle = GridView1.LocateByValue("RecordID", DocAdd)

    ''    RecordIDSystemSelected = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "RecordID")
    ''End Sub

End Class