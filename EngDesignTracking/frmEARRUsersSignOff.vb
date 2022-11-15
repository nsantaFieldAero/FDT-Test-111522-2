Public Class frmEARRUsersSignOff

    Private Sub frmEARRUsersSignOff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString1

        SqlDataAdapter1.Fill(DsEARRUsersSignOff1.tblUsersCreateEARR)

    End Sub

    Private Sub btnSubstitute_Click(sender As Object, e As EventArgs) Handles btnSubstitute.Click

        RecordIDSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecordID")
        EmailSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Email")
        ProgramSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Program")
        ProgramTwoSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Program2")
        ProgramThreeSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Program3")
        ProgramFourSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Program4")
        TypeSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Type")
        TypeTwoSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Type2")

        PreviousUsernameSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Username")
        PreviousEmailSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Email")

        Dim frmEARRSubSignOffUsers As New frmEARRSubSignOffUsers
        frmEARRSubSignOffUsers.Show()

        Me.Close()

    End Sub
End Class