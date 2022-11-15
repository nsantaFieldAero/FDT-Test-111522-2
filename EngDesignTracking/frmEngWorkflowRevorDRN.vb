Public Class frmEngWorkflowRevorDRN
    Dim ds As New DataSet
    Dim da As SqlClient.SqlDataAdapter
    Dim dsAIM As New DataSet
    Dim daAIM As SqlClient.SqlDataAdapter
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        RevOrDRN = "CANCEL"
        Me.Close()

    End Sub

    Private Sub btnDRN_Click(sender As Object, e As EventArgs) Handles btnDRN.Click
        RevOrDRN = "DRN"
        Me.btnNewRevision.Enabled = False
        btnADCN.Enabled = False
        Me.btnDRN.Enabled = False

        '*****Next 3 lines were commented out because now the system automatically chooses the next DRN available instead of the user choosing it
        'Me.lblDRN.Visible = True
        'Me.cboDRN.Visible = True
        'Me.btnContinue.Visible = True

        'lblChooseAIM.Visible = False
        cbChooseAIM.Visible = False
        'btnChosenAIM.Visible = False

        Me.Close()
    End Sub

    Private Sub btnNewRevision_Click(sender As Object, e As EventArgs) Handles btnNewRevision.Click
        RevOrDRN = "REV"
        Me.Close()

    End Sub

    '*****Next block of code was commented out because now the system automatically chooses the next DRN available instead of the user choosing it
    'Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
    '    DRN = Me.cboDRN.Text
    '    If DRN <> "" Then
    '        Me.Close()
    '    Else
    '        MsgBox("You must select a valid DRN.  Select a valid DRN and then hit continue.")
    '    End If
    'End Sub

    Private Sub frmEngWorkflowRevorDRN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AIMChosen = ""
        cbChooseAIM.Visible = False
        'btnChosenAIM.Visible = False
        mskADCN.Visible = False
        lblChooseAIM.Visible = False

        SqlConnection1.ConnectionString = sqlString
        If DrnAllowed = "True" Then
            btnDRN.Visible = True

            SqlConnection1.ConnectionString = sqlString
            Dim i = 0

            'Load AssignmentName
            da = New SqlClient.SqlDataAdapter("Select * from tblDRNADCN Where Active = 'True' Order By Seq Asc", SqlConnection1)
            da.Fill(ds, "DRNADCN")

            While i <= ds.Tables("DRNADCN").Rows.Count - 1
                Me.cboDRN.Items.Add(ds.Tables("DRNADCN").Rows(i).Item("Name"))
                'Me.cboADCN.Items.Add(ds.Tables("DRNADCN").Rows(i).Item("Name"))
                i = i + 1

            End While

            ds.Tables("DRNADCN").Clear()
            ds.Tables("DRNADCN").Dispose()
        Else
            btnDRN.Visible = False
        End If


        If AdcnAllowed = "True" Then
            btnADCN.Visible = "True"
        Else
            btnADCN.Visible = "False"
        End If
    End Sub

    Private Sub btnADCN_Click(sender As Object, e As EventArgs) Handles btnADCN.Click
        RevOrDRN = "ADCN"
        Me.btnNewRevision.Enabled = False
        Me.btnDRN.Enabled = False
        btnADCN.Enabled = False
        Me.btnEnterADCN.Visible = True
        Me.mskADCN.Visible = True
        Me.lblEnterADCN.Visible = True
        'Me.btnContinue.Visible = True
        'lblChooseAIM.Visible = True
        cbChooseAIM.Visible = False
        'btnChosenAIM.Visible = True
        AIMChosen = ""


        'Get a new AIM number to assign it to ADCN or use a previous one
        If MsgBox("System will create a new AIM number. Or select cancel to use a pre-existing AIM.", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            cbChooseAIM.Visible = False
            lblChooseAIM.Visible = False
            frmEngWorkflow.GetAIMNumber()
            mskADCN.Text = AIMChosen
            mskADCN.Enabled = False

        Else

            'Get pre-existing AIM number to assign it to ADCN
            lblChooseAIM.Visible = True
            cbChooseAIM.Visible = True
            mskADCN.Visible = False
            lblEnterADCN.Visible = False

            'Get existing AIM numbers for this document because the same AIM/ADCN cannot be re-used within the same document
            Dim a = 0
            Dim AimNotIncluded As String = ""
            da = New SqlClient.SqlDataAdapter("Select Distinct AIM From tblDrawings where DrawingNumber = '" & DrawingNumberBeingModified & "' And AIM is not null And AIM <> '0' and AIM <> '' UNION Select Distinct ADCN FROM tblDrawings where DrawingNumber = '" & DrawingNumberBeingModified & "' And ADCN is not null And ADCN <> '0' and ADCN <> '' And (AIM is null Or AIM = '' or AIM = '0')", SqlConnection1)
            da.Fill(ds, "PreviousAIMNumbersForThisDoc")
            If ds.Tables("PreviousAIMNumbersForThisDoc").Rows.Count > 0 Then
                While a <= ds.Tables("PreviousAIMNumbersForThisDoc").Rows.Count - 1
                    If a > 0 Then
                        AimNotIncluded = AimNotIncluded & ", "
                    End If
                    AimNotIncluded = AimNotIncluded & "'" & ds.Tables("PreviousAIMNumbersForThisDoc").Rows(a).Item("AIM") & "'"
                    a = a + 1
                End While
                AimNotIncluded = "AIM Not In (" & AimNotIncluded & ") And "
            Else
                AimNotIncluded = ""
            End If
            ds.Tables("PreviousAIMNumbersForThisDoc").Clear()
            ds.Tables("PreviousAIMNumbersForThisDoc").Dispose()
            a = 0


            'Load AIM Numbers
            SqlConnection1.ConnectionString = sqlString
            daAIM = New SqlClient.SqlDataAdapter("Select Distinct AIM From tblDrawings Where " & AimNotIncluded & "Aim Is Not Null And AIM <> '0' And AIM <> '' And SUBSTRING(AIM, 1, 7) != 'DELETED' Order By AIM Desc", SqlConnection1)
            daAIM.Fill(dsAIM, "AIMNumbers")

            Dim i = 0
            While i <= dsAIM.Tables("AIMNumbers").Rows.Count - 1
                Me.cbChooseAIM.Items.Add(dsAIM.Tables("AIMNumbers").Rows(i).Item("AIM"))
                i = i + 1
            End While

            dsAIM.Tables("AIMNumbers").Clear()
            dsAIM.Tables("AIMNumbers").Dispose()
        End If
    End Sub

    Private Sub btnEnterADCN_Click(sender As Object, e As EventArgs) Handles btnEnterADCN.Click
        ADCN = Me.mskADCN.Text

        If ADCN <> "" Then
            Me.Close()
        Else
            MsgBox("You must select an ADCN number.")
            AIMChosen = ""
        End If
    End Sub

    Private Sub cbChooseAIM_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbChooseAIM.SelectedValueChanged
        'Set and get AIM number for ADCNs that will use a new one
        Dim DropDownValue As String = cbChooseAIM.Text
        mskADCN.Text = DropDownValue
        mskADCN.Enabled = False
    End Sub

End Class








'Public Class frmEngWorkflowRevorDRN
'    Dim ds As New DataSet
'    Dim da As SqlClient.SqlDataAdapter
'    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
'        RevOrDRN = "CANCEL"
'        Me.Close()

'    End Sub

'    Private Sub btnDRN_Click(sender As Object, e As EventArgs) Handles btnDRN.Click
'        RevOrDRN = "DRN"
'        Me.btnNewRevision.Enabled = False
'        btnADCN.Enabled = False
'        Me.btnDRN.Enabled = False
'        Me.lblDRN.Visible = True
'        Me.cboDRN.Visible = True
'        Me.btnContinue.Visible = True


'    End Sub

'    Private Sub btnNewRevision_Click(sender As Object, e As EventArgs) Handles btnNewRevision.Click
'        RevOrDRN = "REV"
'        Me.Close()

'    End Sub

'    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
'        DRN = Me.cboDRN.Text
'        If DRN <> "" Then
'            Me.Close()
'        Else
'            MsgBox("You must select a valid DRN.  Select a valid DRN and then hit continue.")
'        End If
'    End Sub

'    Private Sub frmEngWorkflowRevorDRN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        SqlConnection1.ConnectionString = sqlString
'        Dim i = 0

'        'Load AssignmentName
'        da = New SqlClient.SqlDataAdapter("Select * from tblDRNADCN Where Active = 'True' Order By Seq Asc", SqlConnection1)
'        da.Fill(ds, "DRNADCN")

'        While i <= ds.Tables("DRNADCN").Rows.Count - 1
'            Me.cboDRN.Items.Add(ds.Tables("DRNADCN").Rows(i).Item("Name"))
'            'Me.cboADCN.Items.Add(ds.Tables("DRNADCN").Rows(i).Item("Name"))
'            i = i + 1

'        End While

'        ds.Tables("DRNADCN").Clear()
'        ds.Tables("DRNADCN").Dispose()



'        If DrnAllowed = "True" Then
'            btnDRN.Visible = True
'        Else
'            btnDRN.Visible = False
'        End If

'        If AdcnAllowed = "True" Then
'            btnADCN.Visible = True
'        Else
'            btnADCN.Visible = False
'        End If
'    End Sub

'    Private Sub btnADCN_Click(sender As Object, e As EventArgs) Handles btnADCN.Click
'        RevOrDRN = "ADCN"
'        Me.btnNewRevision.Enabled = False
'        Me.btnDRN.Enabled = False
'        btnADCN.Enabled = False
'        Me.btnEnterADCN.Visible = True
'        Me.mskADCN.Visible = True
'        Me.lblEnterADCN.Visible = True
'        'Me.btnContinue.Visible = True

'    End Sub

'    Private Sub btnEnterADCN_Click(sender As Object, e As EventArgs) Handles btnEnterADCN.Click
'        ADCN = Me.mskADCN.Text
'        If ADCN <> "" Then
'            Me.Close()
'        Else
'            MsgBox("You must select a ADCN number.")
'        End If
'    End Sub
'End Class