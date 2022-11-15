Imports DevExpress.XtraGrid.Views.Base

Public Class frmlovSystemDescription
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmlovSystemDescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString

        'Fill project(before program) drop down, that you get by selecting a cell under the program column, with values from database
        da = New SqlClient.SqlDataAdapter("Select * From tblProjects Order By ProjectName", SqlConnection1)
        da.Fill(ds, "Projects")

        Dim i As Integer = 0
        While i <= ds.Tables("Projects").Rows.Count - 1
            RepositoryItemComboBox2.Items.Add(ds.Tables("Projects").Rows(i).Item("ProjectName"))
            i = i + 1
        End While

        ds.Tables("Projects").Clear()
        ds.Tables("Projects").Dispose()

        search()



        'PREVIOUS BLOCK OF CODE
        'SqlConnection1.ConnectionString = sqlString 'Fill program drop down, that you get by selecting a cell under the program column, with values from database
        'da = New SqlClient.SqlDataAdapter("Select * from tblProgram Order By ProgramName", SqlConnection1)
        'da.Fill(ds, "Programs")

        'Dim i As Integer = 0
        'While i <= ds.Tables("Programs").Rows.Count - 1
        '    RepositoryItemComboBox2.Items.Add(ds.Tables("Programs").Rows(i).Item("ProgramName"))
        '    i = i + 1
        'End While

        'ds.Tables("Programs").Clear()
        'ds.Tables("Programs").Dispose()

        'search()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.SqlDataAdapter1.Update(DataSet121.tblSystemDescription)
        search()
    End Sub

    Public Function search()

        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet121.tblSystemDescription.Clear()

        Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += " Order By SystemDescription Asc"

        Try
            Me.SqlDataAdapter1.Fill(DataSet121.tblSystemDescription)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet121.Tables("tblSystemDescription").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text",
            Me.BindingSource1, "RecordID")

        Else
            'MsgBox("No Records Exist")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        u.ExecuteSQL(SqlConnection1, "Delete from tblSystemDescription Where RecordID = '" & Val(txtRecordID.Text) & "'")
        search()

    End Sub

    Private Sub GridView1_BeforeLeaveRow(sender As Object, e As RowAllowEventArgs) Handles GridView1.BeforeLeaveRow
        Me.SqlDataAdapter1.Update(DataSet121.tblSystemDescription)
        search()
    End Sub
End Class