Public Class frmEngWorkflowObsoleteRemarks
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        ObsoleteRemarks = txtRemarks.Text
        Me.Close()

    End Sub
End Class