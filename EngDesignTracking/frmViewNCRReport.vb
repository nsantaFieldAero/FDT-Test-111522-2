Imports CrystalDecisions.Web
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
'Imports CrystalDecisions.Windows.Forms

Public Class frmViewNCRReport

    Dim daYo As SqlClient.SqlDataAdapter
    Dim dsYo As New DataSet
    Public Report1 As crNCRSteps

    Public ReportType As String

    Private Sub frmViewNCRReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ReportType = "NCR" Then

            Me.CrystalReportViewer1.Zoom(100)
            daYo = New SqlClient.SqlDataAdapter(GlobalSqlString, SqlConnection1)
            daYo.Fill(dsYo, "Data")
            Report1.SetDataSource(dsYo.Tables("Data"))
            CrystalReportViewer1.ReportSource = Report1

        End If

    End Sub
End Class