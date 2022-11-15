Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class frmNCR
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    'Dim Path As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "XtraGrid_SaveLayoutToXMLForNCRCalgary.xml")
    Dim Path2 As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "XtraGrid_SaveLayoutToXMLForNCR.xml")

    Private Sub frmNCR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection2.ConnectionString = sqlString

        'Check Users Permissions
        da = New SqlClient.SqlDataAdapter("Select * From tblUsers Where Username = '" & User & "' And Active = 'True'", SqlConnection2)
        da.Fill(ds, "UserPermissionsNCR")

        If ds.Tables("UserPermissionsNCR").Rows.Count > 0 Then

            isNewNCR = ds.Tables("UserPermissionsNCR").Rows(0).Item("NewNCR")

            isQAManager = ds.Tables("UserPermissionsNCR").Rows(0).Item("QAManager")
            'isChairperson = ds.Tables("UserPermissionsNCR").Rows(0).Item("Chairperson")

            isEngineerNCR = ds.Tables("UserPermissionsNCR").Rows(0).Item("Engineer")

            'isMRB = ds.Tables("UserPermissionsNCR").Rows(0).Item("MRB")
            isProdMgr = ds.Tables("UserPermissionsNCR").Rows(0).Item("ProductionManager")
            isProgramMgr = ds.Tables("UserPermissionsNCR").Rows(0).Item("ProgramManager")
            isDAO = ds.Tables("UserPermissionsNCR").Rows(0).Item("DAO")
            isLeadEngineerNCR = ds.Tables("UserPermissionsNCR").Rows(0).Item("LeadEngineer")
            isStress = ds.Tables("UserPermissionsNCR").Rows(0).Item("Stress")
            isDesign = ds.Tables("UserPermissionsNCR").Rows(0).Item("Design")
            isLiaisonNCR = ds.Tables("UserPermissionsNCR").Rows(0).Item("LiaisonEngineer")

            isOperationsNCR = ds.Tables("UserPermissionsNCR").Rows(0).Item("Operations")

            isQC = ds.Tables("UserPermissionsNCR").Rows(0).Item("QC")

            isCloseNCR = ds.Tables("UserPermissionsNCR").Rows(0).Item("CloseNCR")
            isSuperUser = ds.Tables("UserPermissionsNCR").Rows(0).Item("SuperUser")
            isNCRAdmin = ds.Tables("UserPermissionsNCR").Rows(0).Item("Admin")

            If EmailUsername = "" Then
                If IsDBNull(ds.Tables("UserPermissionsNCR").Rows(0).Item("Email")) Then
                    EmailUsername = ""
                Else
                    EmailUsername = ds.Tables("UserPermissionsNCR").Rows(0).Item("Email")
                End If
            End If

        Else
            MsgBox("User not found in the Users table or not Active.")
            Exit Sub
        End If

        'Check if user is Program Manager or Production Supervisor
        Dim IDForBelow As String = ""
        da = New SqlClient.SqlDataAdapter("Select ID From tblUsers Where Username = '" & User & "'", SqlConnection2)
        da.Fill(ds, "IDForBelow")
        If ds.Tables("IDForBelow").Rows.Count > 0 Then
            IDForBelow = ds.Tables("IDForBelow").Rows(0).Item("ID")
            ds.Tables("IDForBelow").Clear()
            ds.Tables("IDForBelow").Dispose()
        End If

        da = New SqlClient.SqlDataAdapter("Select * From tblNotificationsGroups Where User = '" & IDForBelow & "' And Role = 'Program Manager' And Active = 1", SqlConnection2)
        da.Fill(ds, "UserPermissionsNCRTwo")
        If ds.Tables("UserPermissionsNCRTwo").Rows.Count > 0 Then
            isProgramMgr = "True"
            ds.Tables("UserPermissionsNCRTwo").Clear()
            ds.Tables("UserPermissionsNCRTwo").Dispose()
        Else
            isProgramMgr = "False"
        End If

        da = New SqlClient.SqlDataAdapter("Select * From tblNotificationsGroups Where User = '" & IDForBelow & "' And Role = 'Production Supervisor' And Active = 1", SqlConnection2)
        da.Fill(ds, "UserPermissionsNCRTwo")
        If ds.Tables("UserPermissionsNCRTwo").Rows.Count > 0 Then
            isProdSupervisor = "True"
            ds.Tables("UserPermissionsNCRTwo").Clear()
            ds.Tables("UserPermissionsNCRTwo").Dispose()
        Else
            isProdSupervisor = "False"
        End If


        'Control AdminToolStripMenu Visibility
        If isNCRAdmin = "T" Or isSuperUser = "True" Or isQAManager = "True" Then
            AdminToolStripMenuItem.Enabled = True
        Else
            AdminToolStripMenuItem.Enabled = False
        End If



        Search()


        'OPEN THE PAGE WITH THE SAME FILTERS APPLIED LAST TIME THE PAGE WAS CLOSED
        'Check if the xml file that will contain the settings saved exists

        'If isCalgary = "Yes" Then
        '    'Check if the xml file that will contain the settings saved exists
        '    If System.IO.File.Exists(Path) Then
        '        'The next two lines of code gets the layout of the grid as it was when the page was closed.  This layout is saved in a xml file
        '        GridControl1.ForceInitialize()
        '        ' Restore the previously saved layout 
        '        GridControl1.MainView.RestoreLayoutFromXml(Path)
        '    Else
        '        ' Create or overwrite the file.
        '        Dim fs As FileStream = File.Create(Path)

        '        ' Add text to the file.
        '        Dim sBody As String
        '        sBody = "<?xml version=""1.0"" ?>" & vbCrLf & vbCrLf & vbCrLf & "<XMLFileForMyProject>" & vbCrLf & vbCrLf & "</XMLFileForMyProject>"
        '        Dim info As Byte() = New UTF8Encoding(True).GetBytes(sBody)
        '        fs.Write(info, 0, info.Length)
        '        fs.Close()
        '    End If
        '    'End If

        'Else

        If System.IO.File.Exists(Path2) Then
                'The next two lines of code gets the layout of the grid as it was when the page was closed.  This layout is saved in a xml file
                GridControl1.ForceInitialize()
                ' Restore the previously saved layout 
                GridControl1.MainView.RestoreLayoutFromXml(Path2)
            Else
                ' Create or overwrite the file.
                Dim fs As FileStream = File.Create(Path2)

                ' Add text to the file.
                Dim sBody As String
                sBody = "<?xml version=""1.0"" ?>" & vbCrLf & vbCrLf & vbCrLf & "<XMLFileForMyProject>" & vbCrLf & vbCrLf & "</XMLFileForMyProject>"
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(sBody)
                fs.Write(info, 0, info.Length)
                fs.Close()
            End If
        'End If



        'If isCalgary = "Yes" Then
        '    GridView1.Columns("WorkOrderStep").Visible = False
        '    'GridView1.Columns("Title").Visible = False
        'Else
        '    GridView1.Columns("WorkOrder").Visible = False
        '    'GridView1.Columns("Title").Visible = True
        'End If

    End Sub

    Public Function Search()

        Dim SqlString As String
        Dim cmdSave As String

        Me.DsNCRMain1.tblNCR.Clear()

        Me.txtRecordID.DataBindings.Clear()
        Me.txtStep.DataBindings.Clear()
        Me.txtNCRNumber.DataBindings.Clear()
        Me.txtStatus.DataBindings.Clear()
        Me.txtOriginatorName.DataBindings.Clear()

        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString


        Try
            Me.SqlDataAdapter1.Fill(DsNCRMain1.tblNCR)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave


        If DsNCRMain1.Tables("tblNCR").Rows.Count > 0 Then

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text", bsNCRMain, "RecordID")
            Me.txtStep.DataBindings.Add("Text", bsNCRMain, "Step")
            Me.txtNCRNumber.DataBindings.Add("Text", bsNCRMain, "NCRNumber")
            Me.txtStatus.DataBindings.Add("Text", bsNCRMain, "Status")
            Me.txtOriginatorName.DataBindings.Add("Text", bsNCRMain, "OriginatorName")

        Else
            MsgBox("No Records Exist.")
        End If

    End Function

    Private Sub btnReturnMainMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMainMenu.Click
        Dim frmMain As New frmMain
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Search()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        GridControl1.ExportToXlsx("C:\Temp\ExportNCR.xlsx")
        MsgBox("Grid has been exported to c:\temp\exportNCR.xlsx.")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        RecordIDNCR = Me.txtRecordID.Text
        LatestStep = Me.txtStep.Text
        NCRNumber = Me.txtNCRNumber.Text
        OriginatorName = Me.txtOriginatorName.Text

        'If txtStatus.Text = "Closed" Then
        '    MsgBox("This NCR cannot be edited as it was closed")
        '    Exit Sub
        'ElseIf txtStatus.Text = "Aborted" Then
        '    MsgBox("This NCR cannot be edited as it was aborted")
        '    Exit Sub
        'Else

        Dim frmNCRSteps As New frmNCRSteps
        frmNCRSteps.Show()
        'End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim frmMain As New frmMain
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnSubmitNCR_Click(sender As Object, e As EventArgs) Handles btnSubmitNCR.Click

        If isQC = "True" Or isProgramMgr = "True" Or isNewNCR = "True" Or isNCRAdmin = "T" Or isQAManager = "True" Then

            Dim frmNCRAdd As New frmNCRAdd
            frmNCRAdd.Show()
            Me.Close()

        Else
            MsgBox("You do not have permission to create a NCR")
            Exit Sub
        End If

    End Sub

    Private Sub LocationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocationsToolStripMenuItem.Click
        Dim frmNCRLovLocations As New frmNCRLovLocations
        frmNCRLovLocations.Show()
    End Sub

    Private Sub ManufacturerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManufacturerToolStripMenuItem.Click
        Dim frmNCRLovManufacturers As New frmNCRLovManufacturers
        frmNCRLovManufacturers.Show()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Dim frmNCRUsers As New frmNCRUsers
        frmNCRUsers.Show()
    End Sub

    Private Sub frmNCR_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ' Save the layout/formatting of the grid to an XML file when the form gets closed
        'If isCalgary = "Yes" Then
        '    GridControl1.MainView.SaveLayoutToXml(Path)
        'Else
        GridControl1.MainView.SaveLayoutToXml(Path2)
        'End If

    End Sub

End Class