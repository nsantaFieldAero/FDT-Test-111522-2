Public Class frmMDLAdd
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim Top1 As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMDLNumber.TextChanged

    End Sub

    Private Sub frmMDLAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        da = New SqlClient.SqlDataAdapter("Select * from tblProgram Order By ProgramName", SqlConnection1)
        da.Fill(ds, "Programs")

        Dim i As Integer = 0
        While i <= ds.Tables("Programs").Rows.Count - 1
            'RepositoryItemComboBox1.Items.Add(ds.Tables("Programs").Rows(i).Item("ProgramName"))
            Me.cboProgram.Properties.Items.Add(ds.Tables("Programs").Rows(i).Item("ProgramName"))
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
            Me.cboPriority.Items.Add(ds.Tables("Priority").Rows(i).Item("Priority"))
            Me.cboAdditionalMilestones.Items.Add(ds.Tables("Priority").Rows(i).Item("Priority"))
            i = i + 1
        End While

        ds.Tables("Priority").Clear()
        ds.Tables("Priority").Dispose()
    End Sub

    Private Sub cboProgram_TextChanged(sender As Object, e As EventArgs) Handles cboProgram.TextChanged
        da = New SqlClient.SqlDataAdapter("Select SystemDescription from tblSystemDescription Where Program = '" & cboProgram.Text & "' and Active = 'True' Order By SystemDescription Asc", SqlConnection1)
        da.Fill(ds, "GetSys")

        Me.cboSystem.Properties.Items.Clear()

        If ds.Tables("GetSys").Rows.Count > 0 Then
            Dim z As Integer = 0

            While z <= ds.Tables("GetSys").Rows.Count - 1
                Me.cboSystem.Properties.Items.Add(ds.Tables("GetSys").Rows(z).Item("SystemDescription"))
                z = z + 1
            End While
        End If
        Me.cboSystem.Properties.Items.Add("Unspecified")

        ds.Tables("GetSys").Clear()
            ds.Tables("GetSys").Dispose()
    End Sub

    Private Sub cboProgramAdd_TextChanged(sender As Object, e As EventArgs) Handles cboProgramAdd.TextChanged
        da = New SqlClient.SqlDataAdapter("Select SystemDescription from tblSystemDescription Where Program = '" & cboProgram.Text & "' and Active = 'True' Order By SystemDescription Asc", SqlConnection1)
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Check to make sure MDL Number/Revision combo doesn't exist.  If it doesn't, proceed.

        da = New SqlClient.SqlDataAdapter("Select * from tblLIveMDL where MDLNumber = '" & Me.txtMDLNumber.Text & "' and Revision = 'IR'", SqlConnection1)
        da.Fill(ds, "Check")

        If ds.Tables("CHECK").Rows.Count > 0 Then
            MsgBox("The MDL Number/Revision combo already exists.  Please enter a new MDL number and then click save.")
        Else

            u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDL (MDLNumber, Title, Revision, Status, LastRefresh, Priority) Values ( '" & Me.txtMDLNumber.Text & "', '" & Me.txtMDLTitle.Text & "', 'IR', '-', '" & Now & "', '" & Me.cboPriority.Text & "')")

            'Insert a record into the tbldrawings table
            u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, Program, SystemDescription, DwgRevision, Type, DocumentType, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter,DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, Updated, UpdatedDate, ADCN, ForecastStartDate) Values ('" & Me.txtMDLNumber.Text & "', '" & Me.txtMDLTitle.Text & "', '', '" & Me.cboProgram.Text & "', '', 'IR', '', 'Master Data List', '', '" & Loc & "', '" & System.Environment.UserName & "', '" & Now & "', '', 'GATE 0: CM Needs To Assign DWG Number', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '', '', '" & username & "', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','','','','','','" & Now & "', '', 0, '" & Now & "', '', '" & Now & "')")


            'Get the top 1 immediately RecordID from tblLiveMDL so we can add an entry to tblLiveMDLProjectsSystems
            da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID from tblLIveMDL Order By RecordID Desc", SqlConnection1)
            da.Fill(ds, "TOP")


            Top1 = Val(ds.Tables("TOP").Rows(0).Item("RecordID"))

            u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLProjectsSystems (MDLRecordID, MDLNumber, Program, System) Values ('" & Val(Top1) & "', '" & Val(Me.txtMDLNumber.Text) & "', '" & Me.cboProgram.Text & "', '" & Me.cboSystem.Text & "')")
            u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLMilestone (MDLRecordID, MDLNumber, Milestone) Values ('" & Val(Top1) & "', '" & Val(Me.txtMDLNumber.Text) & "', '" & Me.cboPriority.Text & "')")
            Search()


            Me.btnSave.Visible = False
            Me.lblAddProjects.Visible = True
            Me.cboProgramAdd.Visible = True
            Me.cboSystemAdd.Visible = True
            Me.GridControl1.Visible = True
            Me.lblAddMilestones.Visible = True
            Me.cboAdditionalMilestones.Visible = True
            Me.btnAddMilestones.Visible = True
            Me.GridControl2.Visible = True

            Me.btnAddProjectSystem.Visible = True
            Me.cboProgram.Enabled = False
            Me.cboSystem.Enabled = False
            Me.txtMDLNumber.Enabled = False
            Me.txtMDLTitle.Enabled = False
        End If

        ds.Tables("CHECK").Clear()
        ds.Tables("CHECK").Dispose()


    End Sub

    Private Sub btnAddProjectSystem_Click(sender As Object, e As EventArgs) Handles btnAddProjectSystem.Click

        u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLProjectsSystems (MDLRecordID, MDLNumber, Program, System) Values ('" & Val(Top1) & "', '" & Val(Me.txtMDLNumber.Text) & "', '" & Me.cboProgramAdd.Text & "', '" & Me.cboSystemAdd.Text & "')")
        Search()

    End Sub

    Public Function Search()
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        Me.DataSet311.tblLiveMDLProjectsSystems.Clear()

        Dim cmdSave As String

        SqlString = " Where MDLRecordID = '" & Val(Top1) & "' Order By Program Asc"

        'SqlString = " Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' Order By Seq Asc"


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter1.Fill(Me.DataSet311.tblLiveMDLProjectsSystems)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet311.Tables("tblLiveMDLProjectsSystems").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            'Search = True

            'Create DataBindings
            'Me.txtMainRecordID.DataBindings.Add("Text",
            'Me.bsMainGrid, "RecordID")

        End If


        'MsgBox(Me.txtLastName.Text)

        Me.DataSet361.tblLiveMDLMilestone.Clear()



        SqlString = " Where MDLRecordID = '" & Val(Top1) & "' Order By Milestone Asc"

        'SqlString = " Where DrawingNumber = '" & Me.txtMainDrawingNumber.Text & "' Order By Seq Asc"


        cmdSave = Me.SqlDataAdapter2.SelectCommand.CommandText
        Me.SqlDataAdapter2.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter2.Fill(Me.DataSet361.tblLiveMDLMilestone)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter2.SelectCommand.CommandText = cmdSave

        'colDrafterPlannedCompleteDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime

        If Me.DataSet361.Tables("tblLiveMDLMilestone").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            'Search = True

            'Create DataBindings
            'Me.txtMainRecordID.DataBindings.Add("Text",
            'Me.bsMainGrid, "RecordID")

        End If
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddMilestones_Click(sender As Object, e As EventArgs) Handles btnAddMilestones.Click
        u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLMilestone (MDLRecordID, MDLNumber, Milestone) Values ('" & Val(Top1) & "', '" & Val(Me.txtMDLNumber.Text) & "', '" & Me.cboAdditionalMilestones.Text & "')")
        Search()
    End Sub
End Class