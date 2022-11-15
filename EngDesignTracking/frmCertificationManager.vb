Public Class frmCertificationManager
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Private Sub frmCertificationManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString

        'Get Project Information
        'da = New SqlClient.SqlDataAdapter("Select ProgramName, ProjectNumber, ACTNo, PDFFolder, ShortForm from tblProgram Where ProgramName = '" & CertManagerProgram & "'", SqlConnection1)
        da = New SqlClient.SqlDataAdapter("Select ProgramName, ProjectNumber, ACTNo, PDFFolder, ShortForm from tblProjects Where ProgramName = '" & CertManagerProgram & "' Or ProjectName = '" & CertManagerProgram & "'", SqlConnection1)
        da.Fill(ds, "CurrentProgram")

        lblProgramName.Text = ds.Tables("CurrentProgram").Rows(0).Item("ProgramName")
        If IsDBNull(ds.Tables("CurrentProgram").Rows(0).Item("ProjectNumber")) Then
            'Nothing
        Else
            lblProjectNumber.Text = ds.Tables("CurrentProgram").Rows(0).Item("ProjectNumber")
        End If

        If IsDBNull(ds.Tables("CurrentProgram").Rows(0).Item("ActNo")) Then
            'Nothing
        Else
            lblActNo.Text = ds.Tables("CurrentProgram").Rows(0).Item("ActNo")
        End If

        If IsDBNull(ds.Tables("CurrentProgram").Rows(0).Item("PDFFolder")) Then
            'Nothing
        Else
            lblPDFFolder.Text = ds.Tables("CurrentProgram").Rows(0).Item("PDFFolder")
        End If

        If IsDBNull(ds.Tables("CurrentProgram").Rows(0).Item("ShortForm")) Then
            'Nothing
        Else
            Me.lblShortForm.Text = ds.Tables("CurrentProgram").Rows(0).Item("ShortForm")
        End If

        ds.Tables("CurrentProgram").Clear()
        ds.Tables("CurrentProgram").Dispose()



        da = New SqlClient.SqlDataAdapter("Select Program, FAAProjectNo, LeadCertEngineer from tblProgramCertification Where Program = '" & CertManagerProgram & "'", SqlConnection1)
        da.Fill(ds, "ProgramCert")

        Me.cboLeadCertEngineer.Text = ds.Tables("ProgramCert").Rows(0).Item("LeadCertEngineer")
        Me.txtFAAProjectNo.Text = ds.Tables("ProgramCert").Rows(0).Item("FAAProjectNo")

        ds.Tables("ProgramCert").Clear()
        ds.Tables("ProgramCert").Dispose()


        'Next, need to load lstProgramUnitMember
        da = New SqlClient.SqlDataAdapter("Select Program, Name, UnitMemberSpecialty From tblProgramCertificationUM Where Program = '" & CertManagerProgram & "'", SqlConnection1)
        da.Fill(ds, "CertUM")
        Dim i As Integer = 0
        If ds.Tables("CertUM").Rows.Count > 0 Then

            While i <= ds.Tables("CertUM").Rows.Count - 1

                lstProgramUnitMember.Items.Add(ds.Tables("CertUM").Rows(i).Item("Name") & "-" & ds.Tables("CertUM").Rows(i).Item("UnitMemberSpecialty"))
                i = i + 1
            End While

            ds.Tables("CertUM").Clear()
            ds.Tables("CertUM").Dispose()
        End If


        'Next, need to load lstProgramFAAOMTMember 
        da = New SqlClient.SqlDataAdapter("Select Program, Name, FAAOMTMemberSpecialty From tblProgramCertificationFAAOMTMember Where Program = '" & CertManagerProgram & "'", SqlConnection1)
        da.Fill(ds, "CertFAAOMT")
        Dim z As Integer = 0
        If ds.Tables("CertFAAOMT").Rows.Count > 0 Then

            While z <= ds.Tables("CertFAAOMT").Rows.Count - 1

                Me.lstProgramFAAOMTMember.Items.Add(ds.Tables("CertFAAOMT").Rows(z).Item("Name") & "-" & ds.Tables("CertFAAOMT").Rows(z).Item("FAAOMTMemberSpecialty"))
                z = z + 1
            End While

            ds.Tables("CertFAAOMT").Clear()
            ds.Tables("CertFAAOMT").Dispose()
        End If


        '  da = New SqlClient.SqlDataAdapter("Select ")

        da = New SqlClient.SqlDataAdapter("Select Name from tblCertificationStaff Where LeadCertEngineer = 'True'", SqlConnection1)
        da.Fill(ds, "LeadCertEng")

        Dim x As Integer = 0

        While x <= ds.Tables("LeadCertEng").Rows.Count - 1
            Me.cboLeadCertEngineer.Items.Add(ds.Tables("LeadCertEng").Rows(x).Item("Name"))
            x = x + 1
        End While

        ds.Tables("LeadCertEng").Clear()
        ds.Tables("LeadCertEng").Dispose()

        'chklstunitmember
        da = New SqlClient.SqlDataAdapter("Select Name, UnitMemberSpecialty from tblCertificationStaff Where UnitMember = 'True'", SqlConnection1)
        da.Fill(ds, "UnitMember")

        i = 0

        While i <= ds.Tables("UnitMember").Rows.Count - 1
            Me.lstUnitMember.Items.Add(ds.Tables("UnitMember").Rows(i).Item("Name") & "-" & ds.Tables("UnitMember").Rows(i).Item("UnitMemberSpecialty"))
            i = i + 1
        End While

        ds.Tables("UnitMember").Clear()
        ds.Tables("UnitMember").Dispose()

        'chklstFAAOMTMember

        da = New SqlClient.SqlDataAdapter("Select Name, FAAOMTMemberSpecialty from tblCertificationStaff Where FAAOMTMember = 'True'", SqlConnection1)
        da.Fill(ds, "FAAOMTMember")

        i = 0

        While i <= ds.Tables("FAAOMTMember").Rows.Count - 1
            Me.lstFAAOMTMember.Items.Add(ds.Tables("FAAOMTMember").Rows(i).Item("Name") & "-" & ds.Tables("FAAOMTMember").Rows(i).Item("FAAOMTMemberSpecialty"))
            i = i + 1
        End While

        ds.Tables("FAAOMTMember").Clear()
        ds.Tables("FAAOMTMember").Dispose()
    End Sub

    Private Sub btnProgramUnitMemberInclude_Click(sender As Object, e As EventArgs) Handles btnProgramUnitMemberInclude.Click
        lstProgramUnitMember.Items.Add(lstUnitMember.SelectedItem.ToString)
    End Sub

    Private Sub btnProgramUnitMemberExclude_Click(sender As Object, e As EventArgs) Handles btnProgramUnitMemberExclude.Click
        lstProgramUnitMember.Items.Remove(lstProgramUnitMember.SelectedItem)
    End Sub

    Private Sub btnProgramFAAOMTUnitMemberInclude_Click(sender As Object, e As EventArgs) Handles btnProgramFAAOMTUnitMemberInclude.Click
        Me.lstProgramFAAOMTMember.Items.Add(lstFAAOMTMember.SelectedItem.ToString)
    End Sub

    Private Sub btnProgramFAAOMTMemberExclude_Click(sender As Object, e As EventArgs) Handles btnProgramFAAOMTMemberExclude.Click
        Me.lstProgramFAAOMTMember.Items.Remove(lstProgramFAAOMTMember.SelectedItem)
    End Sub

    Private Sub btnSavePreferences_Click(sender As Object, e As EventArgs) Handles btnSavePreferences.Click
        'Save tblProgramCertification data
        u.ExecuteSQL(SqlConnection1, "Update tblProgramCertification Set FAAProjectNo = '" & Me.txtFAAProjectNo.Text & "', LeadCertEngineer = '" & Me.cboLeadCertEngineer.Text & "' Where Program = '" & CertManagerProgram & "'")

        'Save tblProgramCertificationUM data           
        u.ExecuteSQL(SqlConnection1, "Delete from tblProgramCertificationUM Where Program = '" & CertManagerProgram & "'")
        For x As Integer = 0 To lstProgramUnitMember.Items.Count - 1
            Dim Str As String
            Str = lstProgramUnitMember.Items(x).ToString
            Dim split() As String
            split = Str.Split("-")
            'Split String

            'Clear Records from table and insert new records

            u.ExecuteSQL(SqlConnection1, "Insert into tblProgramCertificationUM (Program, Name, UnitMemberSpecialty) Values ('" & CertManagerProgram & "', '" & split(0) & "', '" & split(1) & "')")

        Next

        'Save tblProgramCertificationFAAOMTMember data  
        u.ExecuteSQL(SqlConnection1, "Delete from tblProgramCertificationFAAOMTMember Where Program = '" & CertManagerProgram & "'")
        For z As Integer = 0 To lstProgramFAAOMTMember.Items.Count - 1
            Dim str1 As String
            str1 = lstProgramFAAOMTMember.Items(z).ToString
            Dim split1() As String
            split1 = str1.Split("-")
            'Split String

            'Clear records from table and insert new records

            u.ExecuteSQL(SqlConnection1, "Insert into tblProgramCertificationFAAOMTMember (Program, Name, FAAOMTMemberSpecialty) Values ('" & CertManagerProgram & "', '" & split1(0) & "', '" & split1(1) & "')")
        Next
        MsgBox("Data Saved.")
    End Sub
End Class