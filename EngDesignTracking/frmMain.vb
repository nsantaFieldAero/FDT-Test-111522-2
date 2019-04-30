Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmGridLookup As New frmGridLookUp
        frmGridLookup.Show()
        Me.Close()
    End Sub

    Private Sub btnEARR_Click(sender As Object, e As EventArgs) Handles btnEARR.Click
        Dim frmEARRGrid As New frmEARRGrid
        frmEARRGrid.Show()
        Me.Close()

    End Sub

    Private Sub btnExitApplication_Click(sender As Object, e As EventArgs) Handles btnExitApplication.Click
        Application.Exit()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User = System.Environment.UserName
        lblUsername.Text = User
    End Sub

End Class