Imports System.Web.UI.WebControls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO
Imports System.Text


Public Class Programs
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim da2 As SqlClient.SqlDataAdapter
    Dim ds2 As New DataSet


    Private Sub Programs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString
        SqlConnection2.ConnectionString = sqlString


        Search()


        'GetNotificationsTableData()


        'GridView1.Columns("RecordID").Visible = False
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        u.ExecuteSQL(SqlConnection1, "Insert into tblProgram (ProgramName, Active, Standard, Legacy, ProjectNumber, ActNo, PDFFolder, ShortForm) Values ('" & u.FTM(Me.txtAddProjDesc.Text) & "', 'True', '" & optStd.Checked & "', '" & optLegacy.Checked & "', '" & Val(Me.txtAddProjNo.Text) & "', '', '', '')")
        u.ExecuteSQL(SqlConnection1, "Insert into tblProgramCertification (Program, FAAProjectNo, LeadCertEngineer) Values ('" & u.FTM(Me.txtAddProjDesc.Text) & "', '', '')")
        Search()
    End Sub

    Public Function Search()

        Dim StringSql As String


        Me.DsPrograms.tblProgram.Clear()

        Me.txtRecordID.DataBindings.Clear()
        Me.txtProjectNumber.DataBindings.Clear()
        Me.txtProjectName.DataBindings.Clear()
        Me.txtPDFFolder.DataBindings.Clear()
        Me.txtActNumber.DataBindings.Clear()
        Me.txtShortForm.DataBindings.Clear()
        Me.cboActive.DataBindings.Clear()
        Me.txtDirectory.DataBindings.Clear()



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
            Me.txtProjectNumber.DataBindings.Add("Text", Me.bsPrograms, "ProjectNumber")
            Me.txtProjectName.DataBindings.Add("Text", Me.bsPrograms, "ProgramName")
            Me.txtPDFFolder.DataBindings.Add("Text", Me.bsPrograms, "PDFFolder")
            Me.txtActNumber.DataBindings.Add("Text", Me.bsPrograms, "ActNo")
            Me.txtShortForm.DataBindings.Add("Text", Me.bsPrograms, "ShortForm")
            Me.cboActive.DataBindings.Add("Text", Me.bsPrograms, "Active")
            Me.txtDirectory.DataBindings.Add("Text", Me.bsPrograms, "DocumentPath")

        Else
            MsgBox("No Records Exist")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If
    End Function

    Private Sub btnDeleteProject_Click(sender As Object, e As EventArgs) Handles btnDeleteProject.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected project/program?",
                              "Title",
                              MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            u.ExecuteSQL(SqlConnection1, "Delete from tblProgram Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
            MsgBox("Program has been deleted.")
            Search()
        Else
            'Nothing
        End If
    End Sub

    Private Sub btnCertificationManager_Click(sender As Object, e As EventArgs) Handles btnCertificationManager.Click
        CertManagerProgram = Me.txtProjectName.Text
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


        ProgramSelected = txtProjectName.Text
        GetNotificationsTableData()

    End Sub

    Private Function GetNotificationsTableData()

        SqlConnection1.ConnectionString = sqlString
        SqlConnection2.ConnectionString = sqlString


        ProgramSelected = txtProjectName.Text


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

        End If


        GridView2.Columns("RecordId").Visible = False
        GridView2.Columns("Email").Visible = False
        GridView2.Columns("Name").Visible = False


        PopulateDropDowns()

    End Function

    Private Sub PopulateDropDowns()

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

    End Sub

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
        GridView2.SetRowCellValue(e.RowHandle, GridView2.Columns("Program"), txtProjectName.Text)
        GridView2.SetRowCellValue(e.RowHandle, GridView2.Columns("Active"), True)
        GridView2.SetRowCellValue(e.RowHandle, GridView2.Columns("Name"), User)

    End Sub

    Private Sub btnTestPath_Click(sender As Object, e As EventArgs) Handles btnTestPath.Click
        Dim Path As String = Me.txtDirectory.Text
        Dim fs As FileStream
        Try
            Path = Path + "\test.txt"
            fs = File.Create(Path)
        Catch ex As Exception
            MsgBox("The network path is not valid or you do not have access to the network path.")
            Exit Sub

        End Try

        'Dim info As Byte() = New UTF8Encoding(True).GetBytes("Test Text.")
        'fs.Write(info, 0, info.Length)
        'fs.Close()
        MsgBox("Success!")
        fs.Close()
        File.Delete(Path)

    End Sub

    Private Sub btnSetPath_Click(sender As Object, e As EventArgs) Handles btnSetPath.Click
        u.ExecuteSQL(SqlConnection1, "Update tblProgram Set DocumentPath = '" & Me.txtDirectory.Text & "' Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
        MsgBox("Path Set.")
    End Sub

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