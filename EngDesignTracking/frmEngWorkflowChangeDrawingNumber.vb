Public Class frmEngWorkflowChangeDrawingNumber
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmEngWorkflowChangeDrawingNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString

        lblDocNumber.Text = ChangeDocNumber
        txtActualDocType.Text = ChangeDocTYpe

        'Fill out Doc Type drop-down
        da = New SqlClient.SqlDataAdapter("Select * From tblDocumentType Where Active = 'True' Order By Classification, DocumentType Asc", SqlConnection1)
        da.Fill(ds, "DocType")
        Dim i As Integer = 0
        While i <= ds.Tables("DocType").Rows.Count - 1
            cboChangeDocType.Items.Add(ds.Tables("DocType").Rows(i).Item("DocumentType"))
            i = i + 1
        End While

        ds.Tables("DocType").Clear()
        ds.Tables("DocType").Dispose()

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to change the Document #?",
              "Title",
              MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DrawingNumber = '" & Me.txtNewDocNumber.Text & "', Status = 'GATE 1: DWG Ready For Drafter' Where DrawingNumber = '" & ChangeDocNumber & "'")

            'Check and see if Document Type is Master Data List
            If DocumentType = "Master Data List" Then
                'see If document existed prior to change in MDL
                da = New SqlClient.SqlDataAdapter("Select * from tblLiveMDL Where MDLNumber = '" & ChangeDocNumber & "'", SqlConnection1)
                Try
                    da.Fill(ds, "Verify")
                Catch ex As Exception
                End Try

                Dim Dummy As Integer
                Try
                    Dummy = CInt(Me.txtNewDocNumber.Text)
                Catch ex As Exception
                    MsgBox("An Error Occurred.  A MDL document type must contain a integer only document number!  Please fix your error and retry.")
                    Exit Sub
                End Try

                If ds.Tables("Verify").Rows.Count > 0 Then
                    'Update MDL tables where appropriate with new document #
                    u.ExecuteSQL(SqlConnection1, "Update tblLiveMDLProjectsSystems Set MDLNumber = '" & Val(Me.txtNewDocNumber.Text) & "' WHERE MDLNumber = '" & Val(ChangeDocNumber) & "'")
                    u.ExecuteSQL(SqlConnection1, "Update tblLiveMDL Set  MDLNumber = '" & Val(Me.txtNewDocNumber.Text) & "' WHERE MDLNumber = '" & Val(ChangeDocNumber) & "'")
                    u.ExecuteSQL(SqlConnection1, "Update tblLiveMDLMilestone Set  MDLNumber = '" & Val(Me.txtNewDocNumber.Text) & "' WHERE MDLNumber = '" & Val(ChangeDocNumber) & "'")
                    u.ExecuteSQL(SqlConnection1, "Update tblLiveMDLDetail Set  MDLNumber = '" & Val(Me.txtNewDocNumber.Text) & "' WHERE MDLNumber = '" & Val(ChangeDocNumber) & "'")

                Else
                    'Create new MDL entry.
                    u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDL (MDLNumber, Title, Revision, Status, LastRefresh, Priority) Values ('" & Val(Me.txtNewDocNumber.Text) & "', '" & u.FTM(Title) & "', 'IR', '-', '" & Now & "', '')")
                    'Get the MDLRecordID value just generated
                    da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID from tblLiveMDL Order By RecordID Desc", SqlConnection1)
                    da.Fill(ds, "MDL")
                    'Insert record into the tblLiveMDLProjectsSystems table
                    u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLProjectsSystems (MDLRecordID, MDLNumber, Program, System) Values ('" & Val(ds.Tables("MDL").Rows(0).Item("RecordID")) & "', '" & Val(Me.txtNewDocNumber.Text) & "', '" & Program & "', '" & Systems & "')")
                    ds.Tables("MDL").Clear()
                    ds.Tables("MDL").Dispose()
                End If

                ds.Tables("Verify").Clear()
                ds.Tables("Verify").Dispose()

            Else

            End If


            'If Master Data List, 

            'If it existed, update MDL entries with new document #/MDL #

            'If didn't exist, create MDL.



            MsgBox("Document Number Changed.")
            ChangeDocNumber = Me.txtNewDocNumber.Text


            'Send notification to Drafter
            frmEngWorkflowSignOff.SendNotifications(1)


            frmEngWorkflow.Activate()

            frmEngWorkflow.Search()


            Me.Close()

        Else
            MsgBox("Document Number Has Not Been Changed.")
            ChangeDocNumber = ""
            Me.Close()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ChangeDocNumber = ""
        Me.Close()
    End Sub

    Private Sub btnCancelDocType_Click(sender As Object, e As EventArgs) Handles btnCancelDocType.Click
        Me.Close()
        ChangeDocNumber = ""
    End Sub

    Private Sub btnChangeDocType_Click(sender As Object, e As EventArgs) Handles btnChangeDocType.Click
        Dim RecordID As String = ""
        'Dim Classification As String = ""
        'Dim ExistingDocTypeInDropdown As String = ""


        Dim result As DialogResult = MessageBox.Show("Are you sure you want to change the Document Type?", "Title", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then

            'da = New SqlClient.SqlDataAdapter("Select RecordId From tblDocumentType Where DocumentType = '" & cboSelectDocType.Text & "'", SqlConnection1)
            'da.Fill(ds, "RecordID")

            'If ds.Tables("RecordID").Rows.Count > 0 Then
            '    RecordID = ds.Tables("RecordID").Rows(0).Item("RecordID")
            '    'Classification = ds.Tables("RecordID").Rows(0).Item("Classification")
            '    'ExistingDocTypeInDropdown = ds.Tables("RecordID").Rows(0).Item("DocTypeInDropdown")
            '    ds.Tables("RecordID").Clear()
            '    ds.Tables("RecordID").Dispose()
            'End If

            'If Classification = "" And (ExistingDocTypeInDropdown <> "Proposal (PRxxxx)" Or ExistingDocTypeInDropdown <> "Sketch (SKxxxx)" Or ExistingDocTypeInDropdown <> "Product & System Specification(SPEC-1xxx)" Or ExistingDocTypeInDropdown <> "Toolig (T81xxx)") Then
            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DocumentType = '" & cboChangeDocType.Text & "' Where DrawingNumber = '" & ChangeDocNumber & "'")
            'End If

            MsgBox("Doc Type Updated")
            'txtChangeDocType.Text = ""
            cboChangeDocType.Text = ""
            txtDocTypeInDropdown.Text = ""
            txtActualDocType.Text = ""
        Else

            'txtChangeDocType.Text = ""
            cboChangeDocType.Text = ""
            ChangeDocNumber = ""
            txtActualDocType.Text = ""

            Me.Close()
        End If

    End Sub

    'Make this textbox non-typeable
    Private Sub cboSelectDocType_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cboChangeDocType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboChangeDocType.KeyPress
        e.Handled = True
    End Sub

End Class







'PREVIOUS CODE FOR ENTIRE FORM 12/03/21

'Private Sub frmEngWorkflowChangeDrawingNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    SqlConnection1.ConnectionString = sqlString
'    lblDocNumber.Text = ChangeDocNumber

'End Sub

'Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

'    Dim result As DialogResult = MessageBox.Show("Are you sure you want to change the Document #?",
'          "Title",
'          MessageBoxButtons.YesNo)

'    If (result = DialogResult.Yes) Then
'        u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set DrawingNumber = '" & Me.txtNewDocNumber.Text & "', Status = 'GATE 1: DWG Ready For Drafter' Where DrawingNumber = '" & ChangeDocNumber & "'")

'        'Check and see if Document Type is Master Data List
'        If DocumentType = "Master Data List" Then
'            'see If document existed prior to change in MDL
'            da = New SqlClient.SqlDataAdapter("Select * from tblLiveMDL Where MDLNumber = '" & ChangeDocNumber & "'", SqlConnection1)
'            Try
'                da.Fill(ds, "Verify")
'            Catch ex As Exception
'            End Try

'            Dim Dummy As Integer
'            Try
'                Dummy = CInt(Me.txtNewDocNumber.Text)
'            Catch ex As Exception
'                MsgBox("An Error Occurred.  A MDL document type must contain a integer only document number!  Please fix your error and retry.")
'                Exit Sub
'            End Try

'            If ds.Tables("Verify").Rows.Count > 0 Then
'                'Update MDL tables where appropriate with new document #
'                u.ExecuteSQL(SqlConnection1, "Update tblLiveMDLProjectsSystems Set MDLNumber = '" & Val(Me.txtNewDocNumber.Text) & "' WHERE MDLNumber = '" & Val(ChangeDocNumber) & "'")
'                u.ExecuteSQL(SqlConnection1, "Update tblLiveMDL Set  MDLNumber = '" & Val(Me.txtNewDocNumber.Text) & "' WHERE MDLNumber = '" & Val(ChangeDocNumber) & "'")
'                u.ExecuteSQL(SqlConnection1, "Update tblLiveMDLMilestone Set  MDLNumber = '" & Val(Me.txtNewDocNumber.Text) & "' WHERE MDLNumber = '" & Val(ChangeDocNumber) & "'")
'                u.ExecuteSQL(SqlConnection1, "Update tblLiveMDLDetail Set  MDLNumber = '" & Val(Me.txtNewDocNumber.Text) & "' WHERE MDLNumber = '" & Val(ChangeDocNumber) & "'")

'            Else
'                'Create new MDL entry.
'                u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDL (MDLNumber, Title, Revision, Status, LastRefresh, Priority) Values ('" & Val(Me.txtNewDocNumber.Text) & "', '" & u.FTM(Title) & "', 'IR', '-', '" & Now & "', '')")
'                'Get the MDLRecordID value just generated
'                da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID from tblLiveMDL Order By RecordID Desc", SqlConnection1)
'                da.Fill(ds, "MDL")
'                'Insert record into the tblLiveMDLProjectsSystems table
'                u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLProjectsSystems (MDLRecordID, MDLNumber, Program, System) Values ('" & Val(ds.Tables("MDL").Rows(0).Item("RecordID")) & "', '" & Val(Me.txtNewDocNumber.Text) & "', '" & Program & "', '" & Systems & "')")
'                ds.Tables("MDL").Clear()
'                ds.Tables("MDL").Dispose()
'            End If

'            ds.Tables("Verify").Clear()
'            ds.Tables("Verify").Dispose()

'        Else

'        End If


'        'If Master Data List, 

'        'If it existed, update MDL entries with new document #/MDL #

'        'If didn't exist, create MDL.

'        MsgBox("Document Number Changed.")
'        ChangeDocNumber = Me.txtNewDocNumber.Text


'        'Send notification to Drafter
'        frmEngWorkflowSignOff.SendNotifications(1)


'        Me.Close()
'    Else
'        MsgBox("Document Number Has Not Been Changed.")
'        ChangeDocNumber = ""
'        Me.Close()
'    End If

'End Sub

'Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
'    ChangeDocNumber = ""
'    Me.Close()

'End Sub
