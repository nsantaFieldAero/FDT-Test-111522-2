Public Class frmEngWorkflowAdd
    Dim ds As New DataSet
    Dim da As SqlClient.SqlDataAdapter
    Dim NeedsAssigned As String = ""

    Private Sub frmEngWorkflowAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Programs Information
        SqlConnection1.ConnectionString = sqlString
        da = New SqlClient.SqlDataAdapter("Select * from tblProgram Order By ProgramName", SqlConnection1)
        da.Fill(ds, "Programs")

        Dim p As Integer = 0
        While p <= ds.Tables("Programs").Rows.Count - 1
            Me.cboProgram.Items.Add(ds.Tables("Programs").Rows(p).Item("ProgramName"))
            p = p + 1
        End While

        ds.Tables("Programs").Clear()
        ds.Tables("Programs").Dispose()

        Dim i As Integer = 0

        da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where Active = 'True' and Classification = 'Drawing' Order By DocumentType Asc", SqlConnection1)
        da.Fill(ds, "Type")
        Me.cboDocumentType.Items.Add("------Drawings------")
        While i <= ds.Tables("Type").Rows.Count - 1

            Me.cboDocumentType.Items.Add(ds.Tables("Type").Rows(i).Item("DocumentType"))
            i = i + 1
        End While

        ds.Tables("Type").Clear()
        ds.Tables("Type").Dispose()
        i = 0

        da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType Where Active = 'True' and Classification = 'Report' Order By DocumentType Asc", SqlConnection1)
        da.Fill(ds, "Type")
        Me.cboDocumentType.Items.Add("------Reports------")
        While i <= ds.Tables("Type").Rows.Count - 1

            Me.cboDocumentType.Items.Add(ds.Tables("Type").Rows(i).Item("DocumentType"))
            i = i + 1
        End While

        ds.Tables("Type").Clear()
        ds.Tables("Type").Dispose()
        i = 0

    End Sub

    Private Sub cboProgram_TextChanged(sender As Object, e As EventArgs) Handles cboProgram.TextChanged
        da = New SqlClient.SqlDataAdapter("Select SystemDescription from tblSystemDescription Where Program = '" & cboProgram.Text & "' and Active = 'True' Order By SystemDescription Asc", SqlConnection1)
        da.Fill(ds, "GetSys")

        Me.cboSystem.Items.Clear()

        If ds.Tables("GetSys").Rows.Count > 0 Then
            Dim z As Integer = 0

            While z <= ds.Tables("GetSys").Rows.Count - 1
                Me.cboSystem.Items.Add(ds.Tables("GetSys").Rows(z).Item("SystemDescription"))
                z = z + 1
            End While

            ds.Tables("GetSys").Clear()
            ds.Tables("GetSys").Dispose()

        End If
        'Me.cboSystem.Items.Add("Unspecified")
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim frmEngWorkflowBrowse As New frmEngWorkflowBrowse
        frmEngWorkflowBrowse.ShowDialog()

        Me.txtNextHigherAssembly.Text = DocBrowse

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        'Check if drawing number already exits
        If Me.txtDocNumber.Text <> "" Then
            da = New SqlClient.SqlDataAdapter("Select * from tblDrawings Where DrawingNumber = '" & Me.txtDocNumber.Text & "'", SqlConnection1)
            da.Fill(ds, "Getit")

            If ds.Tables("Getit").Rows.Count > 0 Then
                MsgBox("Drawing Number Already Exists.  Please enter a new drawing number and click continue.")
                ds.Tables("Getit").Clear()
                ds.Tables("Getit").Dispose()
                Exit Sub
            Else
            End If
        Else
            Me.txtDocNumber.Text = "NEEDS ASSIGNED " & Format(Now, "MMddyyyyHHmmss")
            NeedsAssigned = Me.txtDocNumber.Text

        End If


        If Me.cboDocumentType.Text = "------Reports------" Or Me.cboDocumentType.Text = "------Drawings------" Then
            MsgBox("Please select a valid Document Type and then click continue.")
            Exit Sub
        End If


        'Get Drafter name from user table F. Lastname
        'Get Location

        Dim msg As String = ""

        If Me.txtTitle.Text = "" Then
            msg = msg + "Title is required to be filled in." & vbCrLf

        End If
        If Me.cboDocumentType.Text = "" Then
            msg = msg + "Document Type is required to be filled in." & vbCrLf

        End If
        If Me.cboProgram.Text = "" Then
            msg = msg + "Program is required to be selected." & vbCrLf
        End If

        If Me.cboSystem.Text = "" Then
            msg = msg + "System is required to be selected." & vbCrLf
        End If

        '***If drawing number exits in database then don't allow need to add.
        Dim NewRework As String



        da = New SqlClient.SqlDataAdapter("Select * from tblDocumentType where DocumentType = '" & Me.cboDocumentType.Text & "'", SqlConnection1)
        da.Fill(ds, "GETTYPE")

        If ds.Tables("GETTYPE").Rows.Count > 0 Then
            If ds.Tables("GETTYPE").Rows(0).Item("Classification") = "Drawing" Then
                NewRework = "New Drawing"
            ElseIf ds.Tables("GETTYPE").Rows(0).Item("Classification") = "Report" Then
                NewRework = "New Report"
            Else
                NewRework = ""
            End If
        Else
            NewRework = ""
        End If



        If msg = "" Then

            If Me.cboDocumentType.Text = "Master Data List" And Me.txtDocNumber.Text <> "" And Me.txtDocNumber.Text <> NeedsAssigned Then
                'Create MDL record in the MDL table.

                'Create a MDL Number
                Dim mdlint As Int64
                mdlint = Format(Now, "ddyymmss")

                u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDL (MDLNumber, DocumentNumber, Title, Revision, Status, LastRefresh, Priority) Values ('" & Val(mdlint) & "','" & Me.txtDocNumber.Text & "', '" & u.FTM(Me.txtTitle.Text) & "', 'IR', '-', '" & Now & "', '')")
                'Get the MDLRecordID value just generated
                da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID from tblLiveMDL Order By RecordID Desc", SqlConnection1)
                da.Fill(ds, "MDL")
                'Insert record into the tblLiveMDLProjectsSystems table
                u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLProjectsSystems (MDLRecordID, MDLNumber, DocumentNumber, Program, System) Values ('" & Val(ds.Tables("MDL").Rows(0).Item("RecordID")) & "',  '" & Val(mdlint) & "', '" & Me.txtDocNumber.Text & "', '" & Me.cboProgram.Text & "', '" & Me.cboSystem.Text & "')")
            End If
        Else
            msg = msg + "Please fix errors and click continue again."
            MsgBox(msg)
            msg = ""
            Exit Sub
        End If



        'Set Operations/Engineer field to "N/A" if the document created is a report
        'da = New SqlClient.SqlDataAdapter("Select Classification From tblDocumentType Where DocumentType = '" & cboDocumentType.Text & "'", SqlConnection1)
        'da.Fill(ds, "Classification")
        'If ds.Tables("Classification").Rows.Count > 0 Then
        '    DocumentTypeForOperations = ds.Tables("Classification").Rows(0).Item("Classification")
        'Else
        '    DocumentTypeForOperations = ""
        'End If



        ''Set the gate to zero if no document number was provided, otherwise set it to one. To use in the below block of code
        'Dim GateZeroOrOne As String = txtDocNumber.Text
        Dim GateZeroOrOne As String = "GATE 0: CM Needs To Assign DWG Number"

        ''If GateZeroOrOne <> "" And GateZeroOrOne.Length < 21 Then
        ''    GateZeroOrOne = "GATE 1: DWG Ready For Drafter"
        'If GateZeroOrOne = "" Or txtDocNumber.Text = NeedsAssigned Then
        'GateZeroOrOne = "GATE 0: CM Needs To Assign DWG Number"
        'Else
        '    GateZeroOrOne = "GATE 1: DWG Ready For Drafter"
        'End If



        'Set Operations/Engineer field to "N/A" if the document created is a report
        If ds.Tables("GETTYPE").Rows.Count > 0 Then
            'The only thing different between the two SQL queries below is that the one related to Report sets Engineer = N/A
            If ds.Tables("GETTYPE").Rows(0).Item("Classification") = "Drawing" Then
                u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, Program, SystemDescription, DwgRevision, Type, DocumentType, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter,DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, Updated, UpdatedDate, ADCN, ForecastStartDate, DrafterSignedOffBy, SrEngineerSignedOffBy, StressSignedOffBy, EngineerSignedOffBy, ReleaserSignedOffBy, CMSignedOffBy) Values ('" & txtDocNumber.Text & "', '" & u.FTM(txtTitle.Text) & "', '" & txtNextHigherAssembly.Text & "', '" & Me.cboProgram.Text & "', '" & u.FTM(Me.cboSystem.Text) & "', 'IR', '', '" & Me.cboDocumentType.Text & "', '', '" & Loc & "', '" & System.Environment.UserName & "', '" & Now & "', '', '" & GateZeroOrOne & "', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '', '', '" & username & "', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','','','','','','" & Now & "', '" & NewRework & "', 0, '" & Now & "', '', '" & Now & "', '', '', '', '', '', '')")

            Else ds.Tables("GETTYPE").Rows(0).Item("Classification") = "Report"
                u.ExecuteSQL(SqlConnection1, "Insert into tblDrawings (DrawingNumber, DrawingTitle, NextHigherAssembly, Program, SystemDescription, DwgRevision, Type, DocumentType, Priority, Location, DwgRequestBy, DwgRequestDate, DrawingType, Status, LastActionDate, ActualFinishDate, ForecastFinishDate, PlannedFinishDate, EstimatedDurationHours, PercentComplete, DrawingFolderAssignDate, DesignWipDate, Notes, ModelTemplateDate, Drafter,DrafterComplete, Engineer, EngineerComplete, SrEngineer, SrEngineerComplete, Releaser, ReleaserCompelte, Flammability, FlammabilityCOmplete, Stress, StressComplete, RefID, DrafterPlannedCompleteDate, EngineerPlannedCompleteDate, SrEngineerPlannedCompleteDate, FlammabilityPlannedCompleteDate, StressPlannedCompleteDate, ReleaserPlannedCompleteDate,Avionics, AvionicsComplete, AvionicsPlannedComplete, Mechanical, MechanicalComplete, MechanicalPlannedComplete, WONumber, InstallationDrawing, WhiteBoardNumber, DRNADCN, PSCPDocsRequired, CompanyFlightTestRequired, DwgReqDate, NewRework, Updated, UpdatedDate, ADCN, ForecastStartDate, DrafterSignedOffBy, SrEngineerSignedOffBy, StressSignedOffBy, EngineerSignedOffBy, ReleaserSignedOffBy, CMSignedOffBy) Values ('" & txtDocNumber.Text & "', '" & u.FTM(txtTitle.Text) & "', '" & txtNextHigherAssembly.Text & "', '" & Me.cboProgram.Text & "', '" & u.FTM(Me.cboSystem.Text) & "', 'IR', '', '" & Me.cboDocumentType.Text & "', '', '" & Loc & "', '" & System.Environment.UserName & "', '" & Now & "', '', '" & GateZeroOrOne & "', '', '01/01/1900','01/01/1900','01/01/1900','0',0,'', '', '', '', '" & username & "', '01/01/1900', 'N/A', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', '', '01/01/1900', 0,'01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900','01/01/1900', '', '01/01/1900', '01/01/1900', '','01/01/1900','01/01/1900', '','','','','','','" & Now & "', '" & NewRework & "', 0, '" & Now & "', '', '" & Now & "', '', '', '', '', '', '')")
            End If
        End If

        ds.Tables("GETTYPE").Clear()
        ds.Tables("GETTYPE").Dispose()



        'Get the recordid
        da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID From tblDrawings Order By RecordID Desc", SqlConnection1)
        da.Fill(ds, "Top1")

        DocAdd = Val(ds.Tables("TOP1").Rows(0).Item("RecordID"))
        ds.Tables("Top1").Clear()
        ds.Tables("Top1").Dispose()


        'Check if document type is a Report when creating a new document, if it is this variable will be used to set Operations/Engineer field to "N/A"
        DocumentTypeForOperations = cboDocumentType.Text



        'Send notification.  Before it would also Insert Drafter in the Notifications Table if it was not already present
        'Dim ID As String
        Try
            'da = New SqlClient.SqlDataAdapter("Select ID From tblUsers Where Username = '" & User & "'", SqlConnection1)
            'da.Fill(ds, "ID")
            'Dim IdOfUser As String = ds.Tables("ID").Rows(0).Item("ID")

            'da = New SqlClient.SqlDataAdapter("Select * From tblNotificationsGroups Where Program = '" & cboProgram.Text & "' And (Name = '" & User & "' Or User = '" & IdOfUser & "') And Role = 'Drafter'", SqlConnection1)
            'da.Fill(ds, "IsAlreadyInNotificationsTable")
            ''ID = Val(ds.Tables("IsAlreadyInNotificationsTable").Rows(0).Item("ID"))
            'If ds.Tables("IsAlreadyInNotificationsTable").Rows.Count > 0 Then
            '    'Nothing
            'Else
            '    u.ExecuteSQL(SqlConnection1, "Insert into tblNotificationsGroups (Program, Name, Role, Active, [User], Gate0) Values ('" & cboProgram.Text & "','" & User & "','Drafter',1,'" & IdOfUser & "',1)")
            'End If

            'ds.Tables("ID").Clear()
            'ds.Tables("ID").Dispose()
            'ds.Tables("IsAlreadyInNotificationsTable").Clear()
            'ds.Tables("IsAlreadyInNotificationsTable").Dispose()
            'IdOfUser = ""


            ''Send notifications when creating a document. If the doc created does not have a doc number or is unassigned(Gate 0) send email to Planner, instead if it has
            ''a doc number the notification will be sent to the Drafter as this new doc will be set automatically to Gate 1
            ''If GateZeroOrOne = "GATE 0: CM Needs To Assign DWG Number" Then
            ''    'Send notification to Planner and Lead Engineer
            DrawingNumForEmails = txtDocNumber.Text
            ProgramName = cboProgram.Text               'Program Name to use with Notifications
            frmEngWorkflowSignOff.SendNotifications(0)
            ''ElseIf GateZeroOrOne = "GATE 1: DWG Ready For Drafter" Then
            ''    'Send notification to Drafter and Lead Engineer
            ''   frmEngWorkflowSignOff.SendNotifications(1)
            ''End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'Clearing variable(to say that a notification at gate 1 can be sent, since a new doc is being created). Need this because it was sending a notification to Gate 1 people twice, when saving with save btn and when saving with the signoff btn
        NotificationAlreadySentForGateOne = "No"
        'Update notifications label
        frmEngWorkflow.GetNumberTasksPending()


        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged

    End Sub

    Private Sub txtTitle_Validated(sender As Object, e As EventArgs) Handles txtTitle.Validated
        Me.txtTitle.Text = UCase(Me.txtTitle.Text)
    End Sub


End Class