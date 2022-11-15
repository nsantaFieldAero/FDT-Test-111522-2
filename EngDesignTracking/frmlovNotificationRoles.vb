Imports DevExpress.XtraGrid.Views.Base

Public Class frmlovNotificationRoles
    Private Sub frmlovNotificationRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        Search()

        'Add row to add a new record to the top of the grid
        GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    End Sub

    Public Function Search()

        Dim SqlString As String


        Me.DsNotificationsRoles1.tblNotificationsRoles.Clear()

        Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String
        cmdSave = Me.SqlDataAdapter2.SelectCommand.CommandText
        Me.SqlDataAdapter2.SelectCommand.CommandText() += " Order By Roles"

        Try
            Me.SqlDataAdapter2.Fill(DsNotificationsRoles1.tblNotificationsRoles)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter2.SelectCommand.CommandText = cmdSave


        If Me.DsNotificationsRoles1.Tables("tblNotificationsRoles").Rows.Count <> 0 Then
            Search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text", Me.bsNotificationsRoles, "RecordId")

        Else
            'MsgBox("No Records Exist")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If


        GridView1.Columns("RecordId").Visible = False

    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.SqlDataAdapter2.Update(DsNotificationsRoles1.tblNotificationsRoles)
        Search()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        u.ExecuteSQL(SqlConnection1, "Delete from tblNotificationsRoles Where RecordId = '" & Val(txtRecordID.Text) & "'")
        Search()
    End Sub

    Private Sub GridView1_BeforeLeaveRow(sender As Object, e As RowAllowEventArgs) Handles GridView1.BeforeLeaveRow
        Me.SqlDataAdapter2.Update(DsNotificationsRoles1.tblNotificationsRoles)
        Search()
    End Sub
End Class