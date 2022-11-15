Public Class frmNCRReSubmitReason
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If rtxtResubmitReason.Text = "" Then
            MsgBox("You must enter the Re-Submit Reason")
            Exit Sub
        End If

        ReSubmitReason = rtxtResubmitReason.Text

        Me.Close()

    End Sub
End Class