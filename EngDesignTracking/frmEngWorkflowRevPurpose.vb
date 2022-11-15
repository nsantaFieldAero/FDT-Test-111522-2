Imports System.ComponentModel

Public Class frmEngWorkflowRevPurpose
    Private Sub btnContinueRevPurpose_Click(sender As Object, e As EventArgs) Handles btnContinueRevPurpose.Click

        If chkboxEngineering.Checked = True And chkboxProduction.Checked = True Then
            MsgBox("You can only select one checkbox")
            Exit Sub
        End If

        If chkboxEngineering.Checked = False And chkboxProduction.Checked = False Then
            MsgBox("You must select one of the two checkboxes")
            Exit Sub
        End If

        If chkboxEngineering.Checked = True Then
            RevPurpose = "Initiated by Engineering"
        ElseIf chkboxProduction.Checked = True Then
            RevPurpose = "Initiated by Production"
        End If

        'If the user clicks the X button then do nothing
        CloseRevPurposeForm = "No"


        Me.Close()
    End Sub

    Private Sub btnExamples_Click(sender As Object, e As EventArgs) Handles btnExamples.Click

        Dim frmEngWorkflowExamplesRevPurpose As New frmEngWorkflowExamplesRevPurpose
        frmEngWorkflowExamplesRevPurpose.ShowDialog()

    End Sub
End Class