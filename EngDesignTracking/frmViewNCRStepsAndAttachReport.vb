Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
'Imports CrystalDecisions.Windows.Forms

Public Class frmViewNCRStepsAndAttachReport
    Dim daYo As SqlClient.SqlDataAdapter
    Dim dsYo As New DataSet
    Public Report2 As crNCRStepsAndAttachments

    Public ReportType As String

    Private Sub frmViewNCRStepsAndAttachReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''NCR Steps and Attachments Subreport
        'Dim crReport As New crNCRStepsAndAttachments
        'crReport.SetDatabaseLogon("sa1", "The water is wet!")

        'Dim sqlstring As String
        'sqlstring = "SELECT * FROM StepsAndAttachments Where NCRNumber = '" & NCRNumber & "' And (FileExt = 'jpeg' Or FileExt = 'jpg' Or FileExt Is Null) Order By ActualStep, Status Desc"

        'GlobalSqlString = sqlstring

        'Dim frm As New frmViewNCRStepsAndAttachReport
        'frm.ReportType = "NCRStepsAndAttachments"
        'frm.Report2 = crReport
        ''frm.Show()



        If ReportType = "NCRStepsAndAttachments" Then

            Me.CrystalReportViewer1.Zoom(100)
            daYo = New SqlClient.SqlDataAdapter(GlobalSqlString, SqlConnection1)
            daYo.Fill(dsYo, "Data")
            Report2.SetDataSource(dsYo.Tables("Data"))
            CrystalReportViewer1.ReportSource = Report2

        End If

    End Sub
End Class