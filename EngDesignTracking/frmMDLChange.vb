Public Class frmMDLChange
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmMDLChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        da = New SqlClient.SqlDataAdapter("Select * from tblProgram Order By ProgramName", SqlConnection1)
        da.Fill(ds, "Programs")

        Dim i As Integer = 0
        While i <= ds.Tables("Programs").Rows.Count - 1
            'RepositoryItemComboBox1.Items.Add(ds.Tables("Programs").Rows(i).Item("ProgramName"))
            Me.cboProgramAdd.Properties.Items.Add(ds.Tables("Programs").Rows(i).Item("ProgramName"))
            i = i + 1
        End While

        ds.Tables("Programs").Clear()
        ds.Tables("Programs").Dispose()

        da = New SqlClient.SqlDataAdapter("Select Distinct Priority from tblDrawings Where Priority <> 'NULL' Order By Priority Asc", SqlConnection1)
        da.Fill(ds, "Priority")
        i = 0
        While i <= ds.Tables("Priority").Rows.Count - 1
            'RepositoryItemComboBox1.Items.Add(ds.Tables("Programs").Rows(i).Item("ProgramName"))
            Me.cboAdditionalMilestones.Items.Add(ds.Tables("Priority").Rows(i).Item("Priority"))
            i = i + 1
        End While

        ds.Tables("Priority").Clear()
        ds.Tables("Priority").Dispose()

        da = New SqlClient.SqlDataAdapter("Select * from tblLiveMDL where RecordID = '" & Val(MDLChangeRecordID) & "'", SqlConnection1)
        da.Fill(ds, "CurrentMDL")

        Me.txtMDLNumber.Text = ds.Tables("CurrentMDL").Rows(0).Item("MDLNumber")
        Me.txtDocumentNumber.Text = ds.Tables("CurrentMDL").Rows(0).Item("DocumentNumber")
        Me.txtMDLTitle.Text = ds.Tables("CurrentMDL").Rows(0).Item("Title")

        ds.Tables("CurrentMDL").Clear()
        ds.Tables("CurrentMDL").Dispose()


        Search()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        u.ExecuteSQL(SqlConnection1, "Update tblLiveMDL Set MDLNumber = '" & Me.txtMDLNumber.Text & "', Title = '" & Me.txtMDLTitle.Text & "' Where RecordID = '" & Val(MDLChangeRecordID) & "'")
    End Sub

    Public Function Search()
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet371.tblLiveMDLMilestone.Clear()

        Me.txtMilestoneRecordId.DataBindings.Clear()


        Dim cmdSave As String

        SqlString = " Where MDLRecordID = '" & Val(MDLChangeRecordID) & "' Order By Milestone Asc"

        'SqlString = " Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' Order By Seq Asc"


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter1.Fill(Me.DataSet371.tblLiveMDLMilestone)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet371.Tables("tblLiveMDLMilestone").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            'Search = True

            'Create DataBindings
            Me.txtMilestoneRecordId.DataBindings.Add("Text",
            Me.BindingSource1, "RecordID")

        End If


        'MsgBox(Me.txtLastName.Text)

        Me.DataSet381.tblLiveMDLProjectsSystems.Clear()
        txtProgramSystemRecordID.DataBindings.Clear()


        SqlString = " Where MDLRecordID = '" & Val(MDLChangeRecordID) & "' Order By Program Asc"

        'SqlString = " Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' Order By Seq Asc"


        cmdSave = Me.SqlDataAdapter2.SelectCommand.CommandText
        Me.SqlDataAdapter2.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter2.Fill(Me.DataSet381.tblLiveMDLProjectsSystems)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter2.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet381.Tables("tblLiveMDLProjectsSystems").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            'Search = True

            'Create DataBindings
            Me.txtProgramSystemRecordID.DataBindings.Add("Text",
            Me.BindingSource2, "RecordID")

        End If
    End Function

    Private Sub btnAddMilestones_Click(sender As Object, e As EventArgs) Handles btnAddMilestones.Click
        u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLMilestone (MDLRecordID, MDLNumber, Milestone) Values ('" & Val(MDLChangeRecordID) & "', '" & Val(Me.txtMDLNumber.Text) & "', '" & Me.cboAdditionalMilestones.Text & "')")
        Search()

    End Sub

    Private Sub btnAddProjectSystem_Click(sender As Object, e As EventArgs) Handles btnAddProjectSystem.Click
        u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLProjectsSystems (MDLRecordID, MDLNumber, Program, System) Values ('" & Val(MDLChangeRecordID) & "', '" & Val(Me.txtMDLNumber.Text) & "', '" & Me.cboProgramAdd.Text & "', '" & Me.cboSystemAdd.Text & "')")
        Search()

    End Sub

    Private Sub cboProgramAdd_TextChanged(sender As Object, e As EventArgs) Handles cboProgramAdd.TextChanged
        da = New SqlClient.SqlDataAdapter("Select SystemDescription from tblSystemDescription Where Program = '" & Me.cboProgramAdd.Text & "' and Active = 'True' Order By SystemDescription Asc", SqlConnection1)
        da.Fill(ds, "GetSys")

        Me.cboSystemAdd.Properties.Items.Clear()

        If ds.Tables("GetSys").Rows.Count > 0 Then
            Dim z As Integer = 0

            While z <= ds.Tables("GetSys").Rows.Count - 1
                Me.cboSystemAdd.Properties.Items.Add(ds.Tables("GetSys").Rows(z).Item("SystemDescription"))
                z = z + 1
            End While
        End If
        Me.cboSystemAdd.Properties.Items.Add("Unspecified")
        ds.Tables("GetSys").Clear()
        ds.Tables("GetSys").Dispose()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnDeleteMilestone_Click(sender As Object, e As EventArgs) Handles btnDeleteMilestone.Click
        u.ExecuteSQL(SqlConnection1, "Delete from tblLiveMDLMileStone where RecordID = '" & Val(Me.txtMilestoneRecordId.Text) & "'")
        Search()

    End Sub

    Private Sub btnDeleteProgramSystem_Click(sender As Object, e As EventArgs) Handles btnDeleteProgramSystem.Click
        u.ExecuteSQL(SqlConnection1, "Delete from tblLiveMDLProjectsSystems Where RecordID = '" & Val(Me.txtProgramSystemRecordID.Text) & "'")
        Search()

    End Sub

    Private Sub txtProgramSystemRecordID_TextChanged(sender As Object, e As EventArgs) Handles txtProgramSystemRecordID.TextChanged

    End Sub
End Class