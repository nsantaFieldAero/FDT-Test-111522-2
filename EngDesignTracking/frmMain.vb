
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports System.Net.Mail

Public Class frmMain
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmGridLookup As New frmGridLookUp
        frmGridLookup.Show()
        Me.Close()
    End Sub

    Private Sub btnEARR_Click(sender As Object, e As EventArgs) Handles btnEARR.Click
        Dim frmEARRGrid As New frmEARRGrid
        frmEARRGrid.Show()
    End Sub

    Private Sub btnExitApplication_Click(sender As Object, e As EventArgs) Handles btnExitApplication.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'btnNCR.Enabled = False

        SqlConnection1.ConnectionString = sqlString

        'User = "tlee"
        'User = "apptesteng1"       '"apptestcm1"
        User = LCase(System.Environment.UserName)
        lblUsername.Text = User



        da = New SqlClient.SqlDataAdapter("Select * from tblUsers Where username = '" & User & "'", SqlConnection1)
        da.Fill(ds, "USER")

        If ds.Tables("USER").Rows.Count > 0 Then
            If Me.ds.Tables("USER").Rows(0).Item("LegacyForm") = True Or Me.ds.Tables("USER").Rows(0).Item("Admin") = "T" Then
                Button1.Visible = True
            Else
                Button1.Visible = False
            End If

            If Me.ds.Tables("USER").Rows(0).Item("NewForm") = True Then
                Button2.Visible = True
            Else
                Button2.Visible = False
            End If


            'Get User ID and Other Permissions
            Id = ds.Tables("USER").Rows(0).Item("ID")

            If IsDBNull(ds.Tables("USER").Rows(0).Item("Email")) Then
                EmailUsername = ""
            Else
                EmailUsername = ds.Tables("USER").Rows(0).Item("Email")
            End If

            CM = ds.Tables("USER").Rows(0).Item("CM")
            isAdmin = ds.Tables("USER").Rows(0).Item("Admin")
            isLiaison = ds.Tables("USER").Rows(0).Item("LiaisonEngineer")
            isOperations = ds.Tables("USER").Rows(0).Item("Operations")
            isDrafter = ds.Tables("USER").Rows(0).Item("Drafter")

            LocationNCR = ds.Tables("USER").Rows(0).Item("Location")
        End If

        'NCR Permission
        da = New SqlClient.SqlDataAdapter("Select * From tblUsers Where Username = '" & User & "' And Active = 'True'", SqlConnection1)
        da.Fill(ds, "NCRUser")

        If ds.Tables("NCRUser").Rows.Count > 0 Then
            btnNCR.Visible = True

            ds.Tables("NCRUser").Clear()
            ds.Tables("NCRUser").Dispose()

        ElseIf ds.Tables("USER").Rows.Count > 0 Then
            If ds.Tables("USER").Rows(0).Item("Admin") = "T" Then
                btnNCR.Visible = True
            End If
        Else
                btnNCR.Visible = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmEngWorkflow As New frmEngWorkflow
        frmEngWorkflow.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnNCR.Click

        ''Check if user is Calgary
        'If MsgBox("Are you a Calgary user?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    isCalgary = "Yes"
        '    LocationNCR = "Calgary"
        'Else
        '    isCalgary = ""
        '    LocationNCR = "Toronto"
        'End If


        Dim frmNCR As New frmNCR
        frmNCR.Show()
    End Sub
End Class