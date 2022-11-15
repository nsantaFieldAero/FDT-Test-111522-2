Public Class frmViewReport
    Dim daYo As SqlClient.SqlDataAdapter
    Dim dsYo As New DataSet
    Public Report1 As crEARR
    Public Report2 As crEARRBlankFinal
    Public Report3 As crMDLPrint


    Public ReportType As String


    Private Sub frmViewReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        'SqlConn.ConnectionString = SqlConnString
        If ReportType = "EARR" Then
            Me.CrystalReportViewer1.Zoom(100)
            daYo = New SqlClient.SqlDataAdapter(GlobalSqlString, SqlConnection1)
            daYo.Fill(dsYo, "Data")
            Report1.SetDataSource(dsYo.Tables("Data"))
            CrystalReportViewer1.ReportSource = Report1
        ElseIf ReportType = "BLANKEARR" Then
            Me.CrystalReportViewer1.Zoom(100)
            CrystalReportViewer1.ReportSource = Report2
        ElseIf ReportType = "MDLGridView" Then
            Me.CrystalReportViewer1.Zoom(100)
            daYo = New SqlClient.SqlDataAdapter(GlobalSqlString, SqlConnection2)
            daYo.Fill(dsYo, "Data")
            Report3.SetDataSource(dsYo.Tables("Data"))
            CrystalReportViewer1.ReportSource = Report3
        End If
    End Sub
End Class