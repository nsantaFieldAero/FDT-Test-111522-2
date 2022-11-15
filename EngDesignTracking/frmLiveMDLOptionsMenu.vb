Public Class frmLiveMDLOptionsMenu
    Dim DocumentType As String
    Dim LVL As Decimal
    Dim LVLDesc As String
    Dim TopLVL As Decimal
    Dim TopLVLDesc As String
    Dim LVLLVLDesc As String
    Dim CurrentDocStatus
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmLiveMDLOptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = sqlString
        Me.cboShowPreviousRevText.Enabled = False

        Me.Text = MDLOptionsDrawingNumber & " " & MDLOptionsDrawingRev & "-" & MDLOptionsDrawingTitle

        'Load the current values...
        da = New SqlClient.SqlDataAdapter("Select * from tblLiveMDLDetail Where RecordID = '" & Val(MDLOptionsRecordID) & "'", SqlConnection1)
        da.Fill(ds, "FIRE")

        Me.chkCancelled.Checked = ds.Tables("FIRE").Rows(0).Item("Cancelled")
        Me.chkDeferToNextMDL.Checked = ds.Tables("FIRE").Rows(0).Item("DeferToNextMDL")
        Me.chkShowPreviousRev.Checked = ds.Tables("FIRE").Rows(0).Item("ShowPreviousRev")
        Me.chkOverrideDRNDetails.Checked = ds.Tables("FIRE").Rows(0).Item("OverrideDRNDetails")
        Me.chkShowRemarks.Checked = ds.Tables("FIRE").Rows(0).Item("ShowRemarks")
        Me.txtRemarksText.Text = ds.Tables("FIRE").Rows(0).Item("RemarksText")
        Me.txtOverrideDRNText.Text = ds.Tables("FIRE").Rows(0).Item("OverrideDRNText")
        Me.cboShowPreviousRevText.Text = ds.Tables("FIRE").Rows(0).Item("ShowPreviousRevText")

        ds.Tables("FIRE").Clear()
        ds.Tables("FIRE").Dispose()

        da = New SqlClient.SqlDataAdapter("Select DwgRevision from vwDrawingsRev Where DrawingNumber = '" & MDLOptionsDrawingNumber & "' Order by seq Desc", SqlConnection1)
        da.Fill(ds, "REV")

        Dim x As Integer = 0

        While x <= ds.Tables("REV").Rows.Count - 1

            Me.cboShowPreviousRevText.Items.Add(ds.Tables("REV").Rows(x).Item("DwgRevision"))

            x = x + 1
        End While

        ds.Tables("REV").Clear()
        ds.Tables("REV").Dispose()


    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        u.ExecuteSQL(SqlConnection1, "Update tblLiveMDLDetail Set Cancelled = '" & Me.chkCancelled.CheckState & "', DeferToNextMDL = '" & Me.chkDeferToNextMDL.CheckState & "', ShowPreviousRev = '" & Me.chkShowPreviousRev.CheckState & "', OverrideDRNDetails = '" & Me.chkOverrideDRNDetails.CheckState & "', ShowRemarks = '" & Me.chkShowRemarks.CheckState & "', RemarksText = '" & u.FTM(Me.txtRemarksText.Text) & "', OverrideDRNText = '" & u.FTM(Me.txtOverrideDRNText.Text) & "', ShowPreviousRevText = '" & u.FTM(Me.cboShowPreviousRevText.Text) & "' Where RecordID = '" & Val(MDLOptionsRecordID) & "'")

        If Me.chkShowPreviousRev.Checked = True Then
            'Step 1 - See if drawing/rev already exists in the MDLDetail Table.

            da = New SqlClient.SqlDataAdapter("Select * from tblLiveMDLDetail Where RecordID = '" & Val(MDLOptionsRecordID) & "'", SqlConnection1)
            da.Fill(ds, "FIRE")

            da = New SqlClient.SqlDataAdapter("Select * from tblLiveMDLDetail Where DrawingNumber = '" & MDLOptionsDrawingNumber & "' and DWGRevision = '" & Me.cboShowPreviousRevText.Text & "'", SqlConnection1)
            da.Fill(ds, "SHOP")

            If ds.Tables("SHOP").Rows.Count > 0 Then
                'If it does, do nothing.
            Else
                da = New SqlClient.SqlDataAdapter("SELECT * FROM vwDrawingsRev Where DrawingNumber = '" & MDLOptionsDrawingNumber & "' AND DwgRevision = '" & Me.cboShowPreviousRevText.Text & "'", SqlConnection1)
                da.Fill(ds, "Set")

                'Loop through each record, determining document type, level and insert record into tblLiveMDLDetail
                Dim x As Integer = 0
                While x <= ds.Tables("Set").Rows.Count - 1

                    DocumentType = ds.Tables("Set").Rows(x).Item("DrawingType")
                    Classify()

                    If LVL = "0" Then
                        'Do Nothing
                    Else
                        'Need to insert a record
                        u.ExecuteSQL(SqlConnection1, "Insert into tblLiveMDLDetail (MDLRecordID, Revision, MDLNumber, LVL, DrawingNumber, DWgRevision, ActualFinishDate, DrawingTitle, Status, Notes, SystemDescription, DrawingType, LVLDesc, TopLVL, TopLVLDesc, LVLLVLDESC, Cancelled, DeferToNextMDL, ShowPreviousREv, OverrideDRNDetails, ShowRemarks, RemarksText, OverrideDRNText, ShowPreviousRevText) Values ('" & ds.Tables("FIRE").Rows(0).Item("MDLRecordID") & "', '" & ds.Tables("FIRE").Rows(0).Item("Revision") & "', '" & ds.Tables("FIRE").Rows(0).Item("MDLNumber") & "', '" & LVL & "', '" & ds.Tables("Set").Rows(x).Item("DrawingNumber") & "', '" & ds.Tables("Set").Rows(x).Item("DwgRevision") & "', '" & ds.Tables("Set").Rows(x).Item("ActualFinishDate") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("DrawingTitle")) & "', '" & ds.Tables("Set").Rows(x).Item("Status") & "', '" & u.FTM(ds.Tables("Set").Rows(x).Item("Notes")) & "', '" & ds.Tables("Set").Rows(x).Item("SystemDescription") & "', '" & ds.Tables("Set").Rows(x).Item("DrawingType") & "', '" & LVLDesc & "', '" & TopLVL & "', '" & TopLVLDesc & "', '" & LVLLVLDesc & "', 'False', 'False', 'False', 'False', 'False', '', '', '')")
                    End If

                    x = x + 1
                End While



                ds.Tables("Set").Clear()
                ds.Tables("Set").Dispose()

            End If
            ds.Tables("FIRE").Clear()
            ds.Tables("FIRE").Dispose()
            ds.Tables("SHOP").Clear()
            ds.Tables("SHOP").Dispose()

            'If it doesn't, insert the revision/MDL
        End If
        'MsgBox("Options Saved.") 'Removed at request of Paul C.
        Me.Close()

    End Sub

    Private Sub chkShowPreviousRev_CheckStateChanged(sender As Object, e As EventArgs) Handles chkShowPreviousRev.CheckStateChanged
        If chkShowPreviousRev.Checked = True Then
            Me.cboShowPreviousRevText.Enabled = True
        Else
            Me.cboShowPreviousRevText.Text = ""
            Me.cboShowPreviousRevText.Enabled = False
        End If
    End Sub

    Public Function Classify()
        'Get level from the database.
        da = New SqlClient.SqlDataAdapter("Select LVL, LVLDesc, TopLVL, TopLVLDesc from tblDocumentType Where DocumentType = '" & DocumentType & "'", SqlConnection1)
        da.Fill(ds, "LVL1")

        If ds.Tables("LVL1").Rows.Count > 0 Then
            LVL = ds.Tables("LVL1").Rows(0).Item("LVL")
            LVLDesc = ds.Tables("LVL1").Rows(0).Item("LVLDesc")
            TopLVL = ds.Tables("LVL1").Rows(0).Item("TopLVL")
            TopLVLDesc = ds.Tables("LVL1").Rows(0).Item("TopLVLDesc")
            LVLLVLDesc = ds.Tables("LVL1").Rows(0).Item("LVL") & "-" & ds.Tables("LVL1").Rows(0).Item("LVLDesc")
        Else
            LVL = "0"
        End If

        ds.Tables("LVL1").Clear()
        ds.Tables("LVL1").Dispose()

    End Function
End Class