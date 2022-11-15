Public Class frmNCRAbortReason
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If rtxtAbortReason.Text = "" Then
            MsgBox("You must enter the Aborted Reason")
            Exit Sub
        End If

        AbortedReason = rtxtAbortReason.Text

        Me.Close()

    End Sub
End Class