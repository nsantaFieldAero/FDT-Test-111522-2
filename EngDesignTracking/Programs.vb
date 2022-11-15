Imports System.ComponentModel
Imports System.Web.UI.WebControls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class Programs
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim da2 As SqlClient.SqlDataAdapter
    Dim ds2 As New DataSet
    Dim da3 As SqlClient.SqlDataAdapter
    Dim ds3 As New DataSet

    Dim AddNew As String
    Public RowSelectedProgramsGrid

    Private Sub Programs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddNew = "No"

        SqlConnection1.ConnectionString = sqlString
        SqlConnection2.ConnectionString = sqlString
        SqlConnection3.ConnectionString = sqlString
        SqlConnection4.ConnectionString = sqlString


        Search()

        'GetNotificationsTableData()


        'GridView1.Columns("RecordID").Visible = False


        'Fill Export grid with data
        da3 = New SqlClient.SqlDataAdapter("SELECT RecordID, ProgramNumber, ProgramName, ProjectNumber, ProjectName FROM tblProgram_Project ORDER BY ProgramNumber, ProjectNumber", SqlConnection4)
        da3.Fill(ds3, "Export")
        Me.bsExport.DataSource = ds3.Tables("Export")
        GridExport.DataSource = Me.bsExport

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim ProductGroupAdd As String = ""


        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If


        AddNew = "Yes"


        If txtAddProgramDesc.Text = "" Then
            MsgBox("Please enter New Program description")
            Exit Sub
        End If

        'Commented out per Owen 10/20/21
        'If txtAddProgramNo.Text = "" Or txtAddProgramNo.Text.Length <> 6 Or Not (IsNumeric(txtAddProgramNo.Text)) Then
        '    MsgBox("Please enter numeric 6 digits ACT Number")
        '    Exit Sub
        'End If


        'If cbAddDocNumbering.Text = "Field Aerospace (Canada)" Then

        '    If cbAddDocNumbering.Text = "" Or txtAddProjNo.Text = "" Then
        '        MsgBox("Select Doc Numbering and Project Number")
        '        Exit Sub
        '    End If

        '    ProductGroupAdd = ""

        'Else
        '    If cbAddDocNumbering.Text = "" Or cbAddProductGroup.Text = "" Or txtAddProjNo.Text = "" Then
        '        MsgBox("Select Doc Numbering, Product Group and Project Number")
        '        Exit Sub
        '    End If

        '   ProductGroupAdd = cbAddProductGroup.Text
        'End If


        If txtAddProgramNo.Text = "" Then
            txtAddProgramNo.Text = "0"
        End If

        u.ExecuteSQL(SqlConnection1, "Insert into tblProgram (ProgramName, Active, ProjectNumber, ActNo, PDFFolder, ShortForm, Standard, Legacy, DocNumbering, ProductGroup) Values ('" & u.FTM(Me.txtAddProgramDesc.Text) & "', 'True', '" & Val(Me.txtAddProgramNo.Text) & "', '', '', '', 'False', 'False', '', '')")   ''" & optStd.Checked & "', '" & optLegacy.Checked & "',
        u.ExecuteSQL(SqlConnection1, "Insert into tblProgramCertification (Program, FAAProjectNo, LeadCertEngineer) Values ('" & u.FTM(Me.txtAddProgramDesc.Text) & "', '', '')")
        MsgBox("Program Added")

        Search()

        AddNew = "No"

        GetNotificationsTableData()
        GetProjectsOfProgram()


        txtAddProgramDesc.Text = ""
        txtAddProgramNo.Text = ""
        'cbAddDocNumbering.SelectedIndex = -1
        'cbAddProductGroup.SelectedIndex = -1
    End Sub

    Public Function Search()

        Dim StringSql As String


        Me.DsPrograms.tblProgram.Clear()

        Me.txtRecordID.DataBindings.Clear()
        Me.txtProgramNumber.DataBindings.Clear()
        Me.txtProgramName.DataBindings.Clear()
        'Me.txtPDFFolder.DataBindings.Clear()
        'Me.txtActNumber.DataBindings.Clear()
        Me.txtShortForm.DataBindings.Clear()
        Me.cboActive.DataBindings.Clear()
        'Me.cbAddDocNumbering.DataBindings.Clear()
        'Me.cbAddProductGroup.DataBindings.Clear()
        'Me.cboDocNumberingSave.DataBindings.Clear()
        'Me.cboProductGroupSave.DataBindings.Clear()



        SqlConnection1.ConnectionString = sqlString
        Dim cmdSave As String
        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += StringSql

        Try
            Me.SqlDataAdapter1.Fill(DsPrograms.tblProgram)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DsPrograms.Tables("tblProgram").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            Search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text", Me.bsPrograms, "RecordID")
            Me.txtProgramNumber.DataBindings.Add("Text", Me.bsPrograms, "ProjectNumber")
            Me.txtProgramName.DataBindings.Add("Text", Me.bsPrograms, "ProgramName")
            'Me.txtPDFFolder.DataBindings.Add("Text", Me.bsPrograms, "PDFFolder")
            'Me.txtActNumber.DataBindings.Add("Text", Me.bsPrograms, "ActNo")
            Me.txtShortForm.DataBindings.Add("Text", Me.bsPrograms, "ShortForm")
            Me.cboActive.DataBindings.Add("Text", Me.bsPrograms, "Active")
            'Me.cbAddDocNumbering.DataBindings.Add("Text", Me.bsPrograms, "DocNumbering")
            'Me.cbAddProductGroup.DataBindings.Add("Text", Me.bsPrograms, "ProductGroup")
            'Me.cboDocNumberingSave.DataBindings.Add("Text", Me.bsPrograms, "DocNumbering")
            'Me.cboProductGroupSave.DataBindings.Add("Text", Me.bsPrograms, "ProductGroup")

        Else
            MsgBox("No Records Exist")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If
    End Function

    Private Sub btnDeleteProject_Click(sender As Object, e As EventArgs) Handles btnDeleteProgram.Click

        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If


        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected program?", "Title", MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            u.ExecuteSQL(SqlConnection1, "Delete from tblProgram Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
            MsgBox("Program has been deleted.")

            Search()
            GetNotificationsTableData()
            GetProjectsOfProgram()
        End If

    End Sub

    Private Sub btnCertificationManager_Click(sender As Object, e As EventArgs) Handles btnCertificationManager.Click
        CertManagerProgram = Me.txtProgramName.Text
        Dim frmCertificationManager As New frmCertificationManager
        frmCertificationManager.Show()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        'GridView2.Columns.Clear()


        'Clear previous data from Notifications grid if data already existed from before
        If IsNothing(ds2.Tables("Notifications")) Then
            'nothing
        Else
            ds2.Tables("Notifications").Clear()
            ds2.Tables("Notifications").Dispose()
        End If

        'Clear previous data from ProjectsOfProgram grid if data already existed from before
        If IsNothing(ds.Tables("ProjectsOfProgram")) Then
            'nothing
        Else
            ds.Tables("ProjectsOfProgram").Clear()
            ds.Tables("ProjectsOfProgram").Dispose()
        End If


        ProgramSelected = txtProgramName.Text

        'Populate Notifications and ProjectsOfProgram grids
        GetNotificationsTableData()
        GetProjectsOfProgram()

    End Sub

    Private Function GetNotificationsTableData()

        If AddNew = "Yes" Then
            Exit Function
            'Else
            '    SqlConnection1.ConnectionString = sqlString
            '    SqlConnection2.ConnectionString = sqlString
        End If

        ProgramSelected = txtProgramName.Text


        If (SqlConnection1.State = ConnectionState.Open) Then
            SqlConnection1.Close()
        End If

        da = New SqlClient.SqlDataAdapter("Select * from tblUsers Where Username = '" & LCase(System.Environment.UserName) & "'", SqlConnection1)
        da.Fill(ds, "USERAUTHENTICATE")

        If ds.Tables("USERAUTHENTICATE").Rows.Count > 0 Then
            CM = ds.Tables("USERAUTHENTICATE").Rows(0).Item("CM")

            If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
                da2 = New SqlClient.SqlDataAdapter("Select * from tblNotificationsGroups Where Program = '" & ProgramSelected & "' Order By Name, Program", SqlConnection2)
            Else
                da2 = New SqlClient.SqlDataAdapter("Select * from tblNotificationsGroups Where Name = '" & User & "' And Program = '" & ProgramSelected & "' Order By Name, Program", SqlConnection2)
            End If

            'Fill notifications datagrid with data
            da2.Fill(ds2, "Notifications")
            Me.bsNotifications.DataSource = ds2.Tables("Notifications")
            GridNotifications.DataSource = Me.bsNotifications

            'ds.Tables("USERAUTHENTICATE").Clear()
            'ds.Tables("USERAUTHENTICATE").Dispose()
        End If


        GridView2.Columns("RecordId").Visible = False
        GridView2.Columns("Email").Visible = False
        GridView2.Columns("Name").Visible = False
        GridView2.Columns("Program").Visible = False


        PopulateDropDowns()

    End Function

    Private Sub PopulateDropDowns()
        'User = "nsantagata"

        'Populate Programs dropdown
        RepositoryItemComboBox1.Items.Clear()
        da = New SqlClient.SqlDataAdapter("Select * from tblProgram Order By ProgramName", SqlConnection1)
        da.Fill(ds, "Programs")

        Dim i As Integer = 0
        While i <= ds.Tables("Programs").Rows.Count - 1
            RepositoryItemComboBox1.Items.Add(ds.Tables("Programs").Rows(i).Item("ProgramName"))
            i = i + 1
        End While

        ds.Tables("Programs").Clear()
        ds.Tables("Programs").Dispose()


        'Populate Name dropdown
        RepositoryItemComboBox2.Items.Clear()
        RepositoryItemComboBox2.Items.Add(User)


        'Populate User dropdown
        RepositoryItemComboBox3.Items.Clear()
        da = New SqlClient.SqlDataAdapter("Select Distinct Name from tblNameAssignment Where Active = 1 Order By Name", SqlConnection1)
        da.Fill(ds, "NotificationsUser")

        i = 0
        While i <= ds.Tables("NotificationsUser").Rows.Count - 1
            RepositoryItemComboBox3.Items.Add(ds.Tables("NotificationsUser").Rows(i).Item("Name"))
            i = i + 1
        End While

        ds.Tables("NotificationsUser").Clear()
        ds.Tables("NotificationsUser").Dispose()


        'Populate Role dropdown
        RepositoryItemComboBox4.Items.Clear()
        da = New SqlClient.SqlDataAdapter("Select Distinct Roles from tblNotificationsRoles Where Active = 1 Order By Roles", SqlConnection1)
        da.Fill(ds, "Roles")

        i = 0
        While i <= ds.Tables("Roles").Rows.Count - 1
            RepositoryItemComboBox4.Items.Add(ds.Tables("Roles").Rows(i).Item("Roles"))
            i = i + 1
        End While

        ds.Tables("Roles").Clear()
        ds.Tables("Roles").Dispose()


        ''Populate Project Name dropdown
        'RepositoryItemComboBox5.Items.Clear()
        'da = New SqlClient.SqlDataAdapter("Select Distinct ProjectName from tblProjects Where Active = 'True'", SqlConnection1)
        ''ADDED line below and commented line above
        ''da = New SqlClient.SqlDataAdapter("Select ProjectNumber + ' - ' + ProjectName As ProjectName From tblProjects Where Active = 'True'", SqlConnection1)
        'da.Fill(ds, "Projects")

        'i = 0
        'While i <= ds.Tables("Projects").Rows.Count - 1
        '    RepositoryItemComboBox5.Items.Add(ds.Tables("Projects").Rows(i).Item("ProjectName"))
        '    i = i + 1
        'End While

        'ds.Tables("Projects").Clear()
        'ds.Tables("Projects").Dispose()

        'Populate Project Number dropdown
        RepositoryItemComboBox6.Items.Clear()
        da = New SqlClient.SqlDataAdapter("Select Distinct ProjectNumber From tblProjects Where Active = 'True'", SqlConnection1)
        da.Fill(ds, "Projects")

        i = 0
        While i <= ds.Tables("Projects").Rows.Count - 1
            RepositoryItemComboBox6.Items.Add(ds.Tables("Projects").Rows(i).Item("ProjectNumber"))
            i = i + 1
        End While

        ds.Tables("Projects").Clear()
        ds.Tables("Projects").Dispose()

    End Sub

    Private Function GetProjectsOfProgram()

        If AddNew = "Yes" Then
            Exit Function
        End If


        'Clear previous data from ProjectsOfProgram grid if data already existed from before
        If IsNothing(ds.Tables("ProjectsOfProgram")) Then
            'nothing
        Else
            ds.Tables("ProjectsOfProgram").Clear()
            ds.Tables("ProjectsOfProgram").Dispose()
        End If


        'Fill Projects datagrid with data
        da = New SqlClient.SqlDataAdapter("Select RecordID, ProjectName, ProjectNumber from tblProgram_Project Where ProgramName = '" & txtProgramName.Text & "'", SqlConnection3)
        'da = New SqlClient.SqlDataAdapter("Select RecordID, ProjectNumber + ' - ' + ProjectName As ProjectName, '' ProjectNumber From tblProgram_Project Where ProgramName = '" & txtProgramName.Text & "'", SqlConnection3)
        da.Fill(ds, "ProjectsOfProgram")
        Me.bsProjectsOfProgram.DataSource = ds.Tables("ProjectsOfProgram")
        gridProjectsOfProgram.DataSource = Me.bsProjectsOfProgram


        'GridView2.Columns("RecordId").Visible = False
    End Function

    'Private Sub GridView2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    '    'Dim test As String
    '    'Dim view As GridView = TryCast(sender, GridView)
    '    'view.SetRowCellValue(e.RowHandle, view.Columns("Var"), test)
    '    'view.SetRowCellValue(e.RowHandle, view.Columns("Checked"), True)


    '    Dim Col As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Program")
    '    Dim Col2 As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Active")
    '    'If Col Is Nothing Then Exit Sub
    '    'Obtain the number of data rows.  
    '    Dim DataRowCount As Integer = GridView1.DataRowCount
    '    DataRowCount -= 1
    '    'Dim CellValue As Object = GridView1.GetRowCellValue(0, Col)
    '    'Dim NewValue As Integer = Convert.ToDouble(CellValue)
    '    'GridView1.SetRowCellValue(DataRowCount, Col, NewValue)
    '    GridView2.SetRowCellValue(DataRowCount, Col, txtProjectName.Text)
    '    GridView2.SetRowCellValue(DataRowCount, Col2, True)

    'End Sub

    Private Sub btnSaveRolesNotifications_Click(sender As Object, e As EventArgs) Handles btnSaveRolesNotifications.Click

        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If


        Try
            Me.SqlDataAdapter2.Update(ds2, "Notifications")
            MsgBox("Data Saved")
            'dataSaved = "yes"
            'changesSaved = "yes"

        Catch ex As Exception
            MessageBox.Show("An error occured after clicking on Save Grid." & vbLf & vbLf & ex.Message)
        End Try

    End Sub

    Private Sub GridView2_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView2.InitNewRow

        'Dim Col As DevExpress.XtraGrid.Columns.GridColumn = GridView2.Columns.ColumnByFieldName("Program")
        'Dim Col2 As DevExpress.XtraGrid.Columns.GridColumn = GridView2.Columns.ColumnByFieldName("Active")
        ''If Col Is Nothing Then Exit Sub
        ''Obtain the number of data rows.  
        'Dim DataRowCount As Integer = GridView2.DataRowCount
        'DataRowCount += 1
        ''Dim CellValue As Object = GridView1.GetRowCellValue(0, Col)
        ''Dim NewValue As Integer = Convert.ToDouble(CellValue)
        ''GridView1.SetRowCellValue(DataRowCount, Col, NewValue)
        'GridView2.SetRowCellValue(DataRowCount, Col, txtProjectName.Text)
        'GridView2.SetRowCellValue(DataRowCount, Col2, True)


        'POPULATE PROGRAM CELL OF NEW ROW, CHECK ACTIVE AND SET NAME TO THE USERNAME LOGGED IN
        'Dim view As GridView = TryCast(sender, GridView)
        GridView2.SetRowCellValue(e.RowHandle, GridView2.Columns("Program"), txtProgramName.Text)
        GridView2.SetRowCellValue(e.RowHandle, GridView2.Columns("Active"), True)
        GridView2.SetRowCellValue(e.RowHandle, GridView2.Columns("Name"), User)

    End Sub

    Private Sub btnSaveProject_Click(sender As Object, e As EventArgs) Handles btnSaveProgram.Click
        Dim ProgramNum As String = ""
        'Dim ACTNum As String = ""
        Dim ShortForm As String = ""
        'Dim PDFFolder As String = ""
        Dim Active As String = ""

        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If


        'WHEN SAVING GET THE ROW SELECTED FROM THE PROGRAMS GRID, SO THAT I CAN HAVE IT SELECTED AFTER ALL THE SAVE CODE IS EXECUTED
        RowSelectedProgramsGrid = GridView1.FocusedRowHandle


        If txtProgramNumber.Text = "" Or txtProgramNumber.Text.Length <> 6 Or Not (IsNumeric(txtProgramNumber.Text)) Then
            MsgBox("Please enter 6 digits numeric ACT Number")
            Exit Sub
        End If

        ProgramNum = txtProgramNumber.Text
        'ACTNum = txtActNumber.Text
        ShortForm = txtShortForm.Text
        'PDFFolder = txtPDFFolder.Text
        Active = cboActive.Text

        'Updates to the Program Number fields
        u.ExecuteSQL(SqlConnection1, "Update tblProgram Set ProgramName = '" & txtProgramName.Text & "', ProjectNumber = '" & ProgramNum & "', ShortForm = '" & ShortForm & "', Active = '" & Active & "' Where RecordID = '" & txtRecordID.Text & "'")
        MsgBox("Changes Saved")

        AddNew = "Yes"
        Search()
        AddNew = "No"

        GetNotificationsTableData()
        GetProjectsOfProgram()


        'Put the focus on the row that was selected, for the Programs grid, before hitting the save button
        GridView1.FocusedRowHandle = RowSelectedProgramsGrid
        GridView1.SelectRow(RowSelectedProgramsGrid)
    End Sub

    'Private Sub cbAddDocNumbering_TextChanged(sender As Object, e As EventArgs)

    '    'Doc Numbering and Product Group is not visible when Canada
    '    If cbAddDocNumbering.Text = "Field Aerospace (Canada)" Then
    '        cbAddProductGroup.Visible = False
    '        lblProductGroupAdd.Visible = False
    '        cboProductGroupSave.Visible = False
    '        lblProductGroupSave.Visible = False
    '    Else
    '        cbAddProductGroup.Visible = True
    '        lblProductGroupAdd.Visible = True
    '        cboProductGroupSave.Visible = True
    '        lblProductGroupSave.Visible = True
    '    End If
    'End Sub

    ''This is so that the user cannot free type text in the combobox
    'Private Sub cboDocNumberingSave_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    e.Handled = True
    'End Sub

    ''This is so that the user cannot free type text in the combobox
    'Private Sub cboProductGroupSave_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    e.Handled = True
    'End Sub

    'Private Sub cboProductGroupSave_Click(sender As Object, e As EventArgs)

    '    Me.cboProductGroupSave.Items.Clear()

    '    'Populate Product Group drop-down for saving
    '    da = New SqlClient.SqlDataAdapter("Select * from tblProductGroup Order By ProductGroup", SqlConnection1)
    '    da.Fill(ds, "ProductGroup")
    '    Dim p As Integer = 0
    '    While p <= ds.Tables("ProductGroup").Rows.Count - 1
    '        Me.cboProductGroupSave.Items.Add(ds.Tables("ProductGroup").Rows(p).Item("ProductGroup"))
    '        p = p + 1
    '    End While

    '    ds.Tables("ProductGroup").Clear()
    '    ds.Tables("ProductGroup").Dispose()
    'End Sub

    'Private Sub cbAddProductGroup_Click(sender As Object, e As EventArgs)

    '    Me.cbAddProductGroup.Items.Clear()

    '    'Populate Product Group drop-down for saving
    '    da = New SqlClient.SqlDataAdapter("Select * from tblProductGroup Order By ProductGroup", SqlConnection1)
    '    da.Fill(ds, "ProductGroup")
    '    Dim p As Integer = 0
    '    While p <= ds.Tables("ProductGroup").Rows.Count - 1
    '        Me.cbAddProductGroup.Items.Add(ds.Tables("ProductGroup").Rows(p).Item("ProductGroup"))
    '        p = p + 1
    '    End While

    '    ds.Tables("ProductGroup").Clear()
    '    ds.Tables("ProductGroup").Dispose()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        GridExport.Visible = True
        GridExport.ExportToXlsx("C:\Temp\Export.xlsx")
        GridExport.Visible = False
        MsgBox("Exported to c:\temp\export.xlsx.")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtAddProgramNo.Text = ""
        txtAddProgramDesc.Text = ""
    End Sub

    Private Sub btnSaveProject_Click_1(sender As Object, e As EventArgs) Handles btnSaveProject.Click

        If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
            'Nothing
        Else
            MsgBox("You are not an authorized user")
            Exit Sub
        End If


        Try
            Me.SqlDataAdapter3.Update(ds, "ProjectsOfProgram")

            u.ExecuteSQL(SqlConnection1, "Update tblProgram_Project Set ProgramName = '" & txtProgramName.Text & "', ProgramNumber = '" & txtProgramNumber.Text & "' Where ProgramName = '' Or ProgramName Is Null")

            u.ExecuteSQL(SqlConnection1, "Update tblProgram_Project Set ProgramName = '' Where ProgramName Is Null")
            u.ExecuteSQL(SqlConnection1, "Update tblProgram_Project Set ProgramNumber = '' Where ProgramNumber Is Null")

            MsgBox("Project Saved")
            'dataSaved = "yes"
            'changesSaved = "yes"

        Catch ex As Exception
            MessageBox.Show("An error occured after clicking on Save Project." & vbLf & vbLf & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteProject_Click_1(sender As Object, e As EventArgs) Handles btnDeleteProject.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected project?", "Title", MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            u.ExecuteSQL(SqlConnection1, "Delete from tblProgram_Project Where ProgramName = '" & txtProgramName.Text & "' And ProjectName = '" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ProjectName") & "' And ProjectNumber = '" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ProjectNumber") & "'")
            MsgBox("Project has been deleted.")

            'Search()
            'GetNotificationsTableData()
            GetProjectsOfProgram()
        End If

    End Sub

    Private Sub GridView3_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView3.CellValueChanged

        'Get Project Number, then the Project Name will populate according to it
        Dim valueProjNum As String = ""
        valueProjNum = GridView3.GetRowCellValue(e.RowHandle, GridView3.Columns("ProjectNumber")).ToString()


        ''Get Project Number, SO IT IS NOT PROJECT NUMBER + PROJECT NAME BUT JUST PROJECT NUMBER
        'Dim index As Integer = valueProjNum.IndexOf("-")
        'valueProjNum = valueProjNum.Substring(index + 2)


        'Populate Project Name col dropdown inside the gridProjectsOfProgram grid
        RepositoryItemComboBox5.Items.Clear()

        da = New SqlClient.SqlDataAdapter("Select Distinct ProjectName From tblProjects Where ProjectNumber = '" & valueProjNum & "' And Active = 'True'", SqlConnection3)
        da.Fill(ds, "ProjectName")

        Dim a As Integer = 0
        While a <= ds.Tables("ProjectName").Rows.Count - 1
            RepositoryItemComboBox5.Items.Add(ds.Tables("ProjectName").Rows(a).Item("ProjectName"))
            a = a + 1
        End While

        ds.Tables("ProjectName").Clear()
        ds.Tables("ProjectName").Dispose()
    End Sub

    'Clear the ProjectName dropdown
    Private Sub GridView3_RowCountChanged(sender As Object, e As EventArgs) Handles GridView3.RowCountChanged
        RepositoryItemComboBox5.Items.Clear()
    End Sub

    Private Sub GridView3_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GridView3.ShowingEditor

        'This is to disallow editing in existing rows(and allow to create a new row)
        Dim rowHandle As Integer = GridView3.FocusedRowHandle
        If GridView3.FocusedRowHandle >= 0 Then
            e.Cancel = True
        End If
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






    'Public Function ReloadNotificationsGridData()

    '    If CM = True Or ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
    '        da2 = New SqlClient.SqlDataAdapter("Select * from tblNotificationsGroups Where Program = '" & ProgramSelected & "' Order By Name, Program", SqlConnection2)
    '    Else
    '        da2 = New SqlClient.SqlDataAdapter("Select * from tblNotificationsGroups Where Name = '" & User & "' And Program = '" & ProgramSelected & "' Order By Name, Program", SqlConnection2)
    '    End If

    '    da2.Fill(ds2, "Notifications")
    '    Me.bsNotifications.DataSource = ds2.Tables("Notifications")
    '    GridNotifications.DataSource = Me.bsNotifications

    'End Function

End Class