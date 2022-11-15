Imports DevExpress.XtraGrid.Views.Base

Public Class frmEngWorkflowJASCCodes
    'Dim da As SqlClient.SqlDataAdapter
    'Dim ds As New DataSet

    Private Sub frmEngWorkflowJASCCodes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'SqlConnection1.ConnectionString = sqlString

        'da = New SqlClient.SqlDataAdapter("Select RecordID, SectionNumAndDesc, JASCAndDesc, JASCPrefix From tblDocTypeJASC_Series", SqlConnection1)
        'da.Fill(ds, "JascCodes")
        'Me.bsJASCCodes.DataSource = ds.Tables("JascCodes")
        'GridControl1.DataSource = Me.bsJASCCodes

        SqlConnection1.ConnectionString = sqlString


        If JASCBtnFormA = "Yes" Then
            btnSave.Enabled = False
            btnDelete.Enabled = False
            GridView1.OptionsBehavior.ReadOnly = True
            GridView1.NewItemRowText = False
        Else
            If IsCMOrLeadEngOrAdmin = "True" Then
                btnSave.Enabled = True
                btnDelete.Enabled = True
            Else
                btnSave.Enabled = False
                btnDelete.Enabled = False
            End If
        End If


        Search()


        JASCBtnFormA = ""
    End Sub

    Public Function Search()

        Dim SqlString As String

        Me.DsJASCCodes1.tblDocTypeJASC_Series.Clear()

        Me.txtRecordID.DataBindings.Clear()


        Dim cmdSave As String


        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString

        Try
            Me.SqlDataAdapter1.Fill(DsJASCCodes1.tblDocTypeJASC_Series)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave


        If DsJASCCodes1.Tables("tblDocTypeJASC_Series").Rows.Count <> 0 Then
            Search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text",
            Me.bsJASCCodes, "RecordID")

        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.SqlDataAdapter1.Update(DsJASCCodes1.tblDocTypeJASC_Series)
        Search()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        u.ExecuteSQL(SqlConnection1, "Delete from tblDocTypeJASC_Series Where RecordID = '" & Val(Me.txtRecordID.Text) & "'")
        Search()
    End Sub

    'Private Sub GridView1_BeforeLeaveRow(sender As Object, e As RowAllowEventArgs) Handles GridView1.BeforeLeaveRow

    '    If IsCMOrLeadEngOrAdmin = "True" Then
    '        Me.SqlDataAdapter1.Update(DsJASCCodes1.tblDocTypeJASC_Series)
    '        Search()
    '    End If
    'End Sub
End Class