
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports System.ComponentModel

Public Class frmGridLookUp
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim da2 As SqlClient.SqlDataAdapter
    Dim ds2 As New DataSet
    Dim fileName As String = "c:\XtraGrid_SaveLayoutToXML.xml"

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmGridLookUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'The next two lines of code gets the layout of the grid as it was when the page was closed.  This layout is saved in a xml file
        GridControl1.ForceInitialize()
        ' Restore the previously saved layout 
        GridControl1.MainView.RestoreLayoutFromXml(fileName)



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




        'SqlConnection1.ConnectionString = sqlString

        'CHECK USER TABLE to see if user exists.  If user exists, allow application to launch.

        'Declaring my data adapter and specifying my select statement to pull data from the dataset.  I am reusing sqlconnection1 as my connection which was generated 
        'when I drug the datadapter onto my form and configured for the grid control.
        da = New SqlClient.SqlDataAdapter("Select * from tblUsers Where Username = '" & System.Environment.UserName & "'", SqlConnection1)
        'I am filling the dataset (ds) from the data adapter created above and am specifying a table in the dataset.  This table name can be anything I want as long as I 
        'call the same table name when I want to query the dataset.
        da.Fill(ds, "USERAUTHENTICATE")

        'Here I am simply checking a value in the dataset that was filled above.  I am not connecting to the database at this point in anyway.
        If ds.Tables("USERAUTHENTICATE").Rows.Count > 0 Then
            If ds.Tables("USERAUTHENTICATE").Rows(0).Item("GridEdit") = "T" Then
                Me.btnSaveGrid.Enabled = True
            Else
                Me.btnSaveGrid.Enabled = False
            End If
            If ds.Tables("USERAUTHENTICATE").Rows(0).Item("Admin") = "T" Then
                Me.btnAdminUsers.Enabled = True
                Me.btnAdminPrograms.Enabled = True
            Else
                Me.btnAdminUsers.Enabled = False
                Me.btnAdminPrograms.Enabled = False
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
        GridControl1.MainView.SaveLayoutToXml(fileName)

    End Sub

    Public Function Search()

        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet21.tblDrawings.Clear()

        Me.txtRecordID.DataBindings.Clear()
        Me.txtLocation.DataBindings.Clear()

        Dim cmdSave As String

        If chkShowStageComplete.Checked = False Then
            SqlString = " Where Status NOT IN ('GATE 6: Complete', 'GATE 9: Complete')"
        Else
            SqlString = ""

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



        If txtLocation.Text = "Toronto" Then
            RepositoryItemComboBox2.Items.Add("GATE 0: CM Needs To Assign DWG Number")
            RepositoryItemComboBox2.Items.Add("GATE 1: DWG Ready For Drafter")
            RepositoryItemComboBox2.Items.Add("GATE 2: DWG Ready For Checker/Engineer")
            RepositoryItemComboBox2.Items.Add("GATE 3: DWG Ready For Flammability")
            RepositoryItemComboBox2.Items.Add("GATE 4: DWG Ready For Stress")
            RepositoryItemComboBox2.Items.Add("GATE 5: DWG Ready For Avionics")
            RepositoryItemComboBox2.Items.Add("GATE 6: DWG Ready For Mechanical")
            RepositoryItemComboBox2.Items.Add("GATE 7: DWG Ready For Release")
            RepositoryItemComboBox2.Items.Add("GATE 8: DWG Released")
            RepositoryItemComboBox2.Items.Add("GATE 9: Complete")
        ElseIf txtLocation.Text = "OKC" Then
            RepositoryItemComboBox2.Items.Add("GATE 0: CM Needs To Assign DWG Number")
            RepositoryItemComboBox2.Items.Add("GATE 1: DWG Ready For Drafter")
            RepositoryItemComboBox2.Items.Add("GATE 2: DWG Ready For Checker/Engineer")
            RepositoryItemComboBox2.Items.Add("GATE 3: DWG Ready For Sr Engineer")
            RepositoryItemComboBox2.Items.Add("GATE 4: DWG Ready For Release")
            RepositoryItemComboBox2.Items.Add("GATE 5: DWG Released")
            RepositoryItemComboBox2.Items.Add("GATE 6: Complete")

            'RepositoryItemComboBox1.Items.Add(ProgramsBindingSource)
        End If
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
        Dim result As DialogResult = MessageBox.Show("Would you like to save changes to the grid before closing?",
                      "Title",
                      MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Me.SqlDataAdapter1.Update(DataSet21.tblDrawings)
        Else
            'Nothing
        End If
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim result As DialogResult = MessageBox.Show("Please confirm you would like to delete the current selected record.",
                      "Title",
                      MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then

            u.ExecuteSQL(SqlConnection1, "DELETE from tblDrawings where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
            MsgBox("Record has been deleted.  The screen will now be refreshed.")
            Search()
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

    Private Sub AdminBtn_Click(sender As Object, e As EventArgs) Handles btnAdminUsers.Click
        Dim AdminScreen As New AdminScreen
        AdminScreen.Show()
        'Me.Close()
    End Sub

    Private Sub btnAdminPrograms_Click(sender As Object, e As EventArgs) Handles btnAdminPrograms.Click
        Dim Programs As New Programs
        Programs.Show()
        'Me.Close()
    End Sub

End Class