Public Class frmEARRGrid
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim da1 As SqlClient.SqlDataAdapter

    Private Sub btnExportGrid_Click(sender As Object, e As EventArgs) Handles btnExportGrid.Click
        GridControl1.ExportToXlsx("C:\Temp\ExportEARR.xlsx")
        MsgBox("Grid has been exported to c:\temp\exportEARR.xlsx.")
    End Sub

    Private Sub frmEARRGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection2.ConnectionString = sqlString1
        SqlConnection1.ConnectionString = sqlString1

        'MsgBox(System.Environment.UserName)

        da = New SqlClient.SqlDataAdapter("Select * from tblUsers Where Username = '" & User & "'", SqlConnection1)
        da.Fill(ds, "USERAUTHENTICATE")
        If ds.Tables("USERAUTHENTICATE").Rows.Count > 0 Then
            'If ds.Tables("USERAUTHENTICATE").Rows(0).Item("GridEdit") = "T" Then
            '    Me.btnSaveGrid.Enabled = True
            'Else
            '    Me.btnSaveGrid.Enabled = False
            'End If
            EARRORIGNAME = ds.Tables("USERAUTHENTICATE").Rows(0).Item("SignedName")
            EARRREADONLY = ds.Tables("USERAUTHENTICATE").Rows(0).Item("ReadOnly")
            Search()
            ThingsToApprove()
            If EARRREADONLY = "-1" Then

                Me.btnSubmitNewDrawingRequest.Enabled = False
            Else
                Me.btnSubmitNewDrawingRequest.Enabled = True
            End If

        Else
            MsgBox("You are not setup as an authorized user.")
            Application.Exit()


        End If

        If ds.Tables("USERAUTHENTICATE").Rows(0).Item("EnterEARR") = False Then
            Me.btnSubmitNewDrawingRequest.Enabled = False
        End If

        GridView1.BestFitColumns()
    End Sub

    Public Function Search()
        Dim strSwitch As String = "0"
        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet41.tblEARR.Clear()

        Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String
        SqlString = " Where RecordID = RecordID"




        SqlString = SqlString + " AND ProgramName = 'QCTEST'"
        strSwitch = 1

            If chkShowCompletedEARRS.Checked = False Then
            SqlString = SqlString + " AND EARRStatus <> 'Complete' AND EARRStatus <> 'Aborted'"
        End If


        If ds.Tables("USERAUTHENTICATE").Rows(0).Item("JaguarProgram") = True Then


            SqlString = SqlString + " OR ProgramName = 'Jaguar'"
            'strSwitch = 1

            If chkShowCompletedEARRS.Checked = False Then
                SqlString = SqlString + " AND EARRStatus <> 'Complete' AND EARRStatus <> 'Aborted'"
            End If
        End If


        If ds.Tables("USERAUTHENTICATE").Rows(0).Item("Sherpa") = True Then
            If strSwitch = 0 Then
                SqlString = SqlString + " AND ProgramName = 'Sherpa'"
                strSwitch = 1
                If chkShowCompletedEARRS.Checked = False Then
                    SqlString = SqlString + " AND EARRStatus <> 'Complete' And EARRStatus <> 'Aborted'"
                End If
            Else
                SqlString = SqlString + " OR ProgramName = 'Sherpa'"
                If chkShowCompletedEARRS.Checked = False Then
                    SqlString = SqlString + " AND EARRStatus <> 'Complete' AND EARRSTATUS <> 'Aborted'"
                End If
            End If
        End If

        If ds.Tables("USERAUTHENTICATE").Rows(0).Item("Jaguar16082") = True Then
            If strSwitch = 0 Then
                SqlString = SqlString + " AND ProgramName = '16082 - Jaguar'"
                strSwitch = 1
                If chkShowCompletedEARRS.Checked = False Then
                    SqlString = SqlString + " AND EARRStatus <> 'Complete'"
                End If
            Else
                SqlString = SqlString + " OR ProgramName = '16082 - Jaguar'"
                If chkShowCompletedEARRS.Checked = False Then
                    SqlString = SqlString + " AND EARRStatus <> 'Complete'"
                End If
            End If
        End If

        SqlString = SqlString + " ORDER By OriginatorDate Asc"

        If strSwitch = "0" Then
            MsgBox("You need access to a program to view EARRs")
            Dim frmMain As New frmMain
            frmMain.Show()
            Me.Close()
        End If


        'If chkShowCompletedEARRS.Checked = False Then
        '    SqlString = " Where EARRStatus <> 'Complete' Order By OriginatorDate Asc"
        'Else

        'End If

        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString


        ''If Me.cboSchoolYearEnrolledIn.Text = "2013" And Me.txtLastNameSearch.Text = "" And BackToPerson = 0 Then
        ''	Me.SqlDataAdapter1.SelectCommand.CommandText() = "SELECT * FROM vwStudents  A INNER JOIN tblStudents B ON  A.RecordID = B.RecordID INNER JOIN  tblClassEnrollment C ON B.RecordID = C.StudentID Where C.SchoolYear = '2013' ORDER BY C.StudentLast Asc"
        ''End If

        Try
            Me.SqlDataAdapter1.Fill(DataSet41.tblEARR)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        If Me.DataSet41.Tables("tblEARR").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            Search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text",
            Me.BindingSource1, "RecordID")

        Else
            MsgBox("No Records Exist.  You may perform a new search or enter a new person.")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If

    End Function

    Private Sub btnSubmitNewDrawingRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitNewDrawingRequest.Click
        Dim NewEAAR As New NewEARR
        NewEAAR.Show()
        Me.Close()

    End Sub

    Public Function ThingsToApprove()

        '1.  Get users Email Address.
        da = New SqlClient.SqlDataAdapter("Select Email from tblUsers Where Username = '" & User & "'", SqlConnection2)
        da.Fill(ds, "GETEMAIL")


        da1 = New SqlClient.SqlDataAdapter("Select RecordID from tblEARR Where LiaisonManagerName = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND LiaisonManagerSignOffDate = '01/01/1900' OR LiaisonManagerNameBackup = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND LiaisonManagerSignOffDate = '01/01/1900' OR EngineeringManagerName = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND EngineeringManagerSignOffDate = '01/01/1900' OR EngineeringManagerNameBackup = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND EngineeringManagerSignOffDate = '01/01/1900' OR QCName = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND QCSignOff = '01/01/1900' OR QCNameBackup = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND QCSignOff = '01/01/1900' OR Planner1 = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND EARRNumber = 'Pending EARR Number' OR Planner2 = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND EARRNumber = 'Pending EARR Number' OR Planner1 = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND PlannerSignOffDate = '01/01/1900' OR Planner2 = '" & ds.Tables("GETEMAIL").Rows(0).Item("Email") & "' AND PlannerSignOffDate = '01/01/1900'", SqlConnection2)
        da1.Fill(ds, "NOTOAPPROVE")
        If ds.Tables("NOTOAPPROVE").Rows.Count > 0 Then
            lblAction.Text = ds.Tables("NOTOAPPROVE").Rows.Count
            Me.btnEARRApproval.Visible = True
        Else
            Me.btnEARRApproval.Visible = False
            lblAction.Text = "0"
        End If

        ds.Tables("GETEMAIL").Clear()
        ds.Tables("GETEMAIL").Dispose()

        ds.Tables("NOTOAPPROVE").Clear()
        ds.Tables("NOTOAPPROVE").Dispose()

    End Function

    Private Sub btnEARRApproval_Click(sender As Object, e As EventArgs) Handles btnEARRApproval.Click
        Dim frmEARRApproval As New frmEARRApproval
        frmEARRApproval.Show()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Search()
        ThingsToApprove()

    End Sub

    Private Sub btnEditandViewRow_Click(sender As Object, e As EventArgs) Handles btnEditandViewRow.Click
        EditEARR = Me.txtRecordID.Text
        Dim frmEARRApproval As New frmEARRApproval
        frmEARRApproval.Show()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Dim frmMain As New frmMain
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim frmMain As New frmMain
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub btnExportForm_Click(sender As Object, e As EventArgs) Handles btnExportForm.Click

        Dim crReport As New crEARRBlankFinal
        crReport.SetDatabaseLogon("sa1", "The water is wet!")

        Dim sqlstring As String

        sqlstring = ""

        GlobalSqlString = sqlstring

        Dim frm As New frmViewReport
        frm.ReportType = "BLANKEARR"
        frm.Report2 = crReport
        frm.Show()
    End Sub
End Class