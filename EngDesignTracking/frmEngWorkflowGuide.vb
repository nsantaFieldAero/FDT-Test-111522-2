Public Class frmEngWorkflowGuide
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmEngWorkflowGuide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString

        If DocTypeForGuide = "" Then
            da = New SqlClient.SqlDataAdapter("Select RecordID, DocumentType, Classification, Notes From tblDocumentType Order By Classification", SqlConnection1)
        ElseIf DocTypeForGuide = "Drawing" Then
            da = New SqlClient.SqlDataAdapter("Select RecordID, DocumentType, Classification, Notes From tblDocumentType Where Classification = 'Drawing'", SqlConnection1)
        ElseIf DocTypeForGuide = "Report" Then
            da = New SqlClient.SqlDataAdapter("Select RecordID, DocumentType, Classification, Notes From tblDocumentType Where Classification = 'Report'", SqlConnection1)
        End If
        da.Fill(ds, "Guide")
        Me.bsGuide.DataSource = ds.Tables("Guide")
        GridControl1.DataSource = Me.bsGuide

    End Sub
End Class