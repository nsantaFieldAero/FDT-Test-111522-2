Public Class frmViewNCRMain
    Dim daYo As SqlClient.SqlDataAdapter
    Dim dsYo As New DataSet
    Public Report3 As crNCRMain

    Public ReportTypeNCRMain As String

    Private Sub frmViewNCRMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ReportTypeNCRMain = "NCRMain" Then

            Me.CrystalReportViewer1.Zoom(100)
            daYo = New SqlClient.SqlDataAdapter(GlobalSqlString2, SqlConnection1)
            daYo.Fill(dsYo, "Data")
            Report3.SetDataSource(dsYo.Tables("Data"))
            CrystalReportViewer1.ReportSource = Report3

        End If

    End Sub

End Class