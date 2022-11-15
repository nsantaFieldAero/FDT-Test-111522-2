<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCertificationManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCertificationManager))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblShortForm = New System.Windows.Forms.Label()
        Me.lblPDFFolder = New System.Windows.Forms.Label()
        Me.lblActNo = New System.Windows.Forms.Label()
        Me.lblProjectNumber = New System.Windows.Forms.Label()
        Me.lblProgramName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFAAProjectNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboLeadCertEngineer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.lstUnitMember = New System.Windows.Forms.ListBox()
        Me.lstFAAOMTMember = New System.Windows.Forms.ListBox()
        Me.lstProgramUnitMember = New System.Windows.Forms.ListBox()
        Me.lstProgramFAAOMTMember = New System.Windows.Forms.ListBox()
        Me.btnProgramUnitMemberInclude = New System.Windows.Forms.Button()
        Me.btnProgramUnitMemberExclude = New System.Windows.Forms.Button()
        Me.btnProgramFAAOMTMemberExclude = New System.Windows.Forms.Button()
        Me.btnProgramFAAOMTUnitMemberInclude = New System.Windows.Forms.Button()
        Me.btnSavePreferences = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblShortForm)
        Me.GroupBox1.Controls.Add(Me.lblPDFFolder)
        Me.GroupBox1.Controls.Add(Me.lblActNo)
        Me.GroupBox1.Controls.Add(Me.lblProjectNumber)
        Me.GroupBox1.Controls.Add(Me.lblProgramName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1410, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Program Information"
        '
        'lblShortForm
        '
        Me.lblShortForm.AutoSize = True
        Me.lblShortForm.Location = New System.Drawing.Point(299, 69)
        Me.lblShortForm.Name = "lblShortForm"
        Me.lblShortForm.Size = New System.Drawing.Size(65, 13)
        Me.lblShortForm.TabIndex = 9
        Me.lblShortForm.Text = "lblShortForm"
        '
        'lblPDFFolder
        '
        Me.lblPDFFolder.AutoSize = True
        Me.lblPDFFolder.Location = New System.Drawing.Point(115, 69)
        Me.lblPDFFolder.Name = "lblPDFFolder"
        Me.lblPDFFolder.Size = New System.Drawing.Size(67, 13)
        Me.lblPDFFolder.TabIndex = 8
        Me.lblPDFFolder.Text = "lblPDFFolder"
        '
        'lblActNo
        '
        Me.lblActNo.AutoSize = True
        Me.lblActNo.Location = New System.Drawing.Point(470, 35)
        Me.lblActNo.Name = "lblActNo"
        Me.lblActNo.Size = New System.Drawing.Size(47, 13)
        Me.lblActNo.TabIndex = 7
        Me.lblActNo.Text = "lblActNo"
        '
        'lblProjectNumber
        '
        Me.lblProjectNumber.AutoSize = True
        Me.lblProjectNumber.Location = New System.Drawing.Point(299, 35)
        Me.lblProjectNumber.Name = "lblProjectNumber"
        Me.lblProjectNumber.Size = New System.Drawing.Size(87, 13)
        Me.lblProjectNumber.TabIndex = 6
        Me.lblProjectNumber.Text = "lblProjectNumber"
        '
        'lblProgramName
        '
        Me.lblProgramName.AutoSize = True
        Me.lblProgramName.Location = New System.Drawing.Point(115, 35)
        Me.lblProgramName.Name = "lblProgramName"
        Me.lblProgramName.Size = New System.Drawing.Size(84, 13)
        Me.lblProgramName.TabIndex = 5
        Me.lblProgramName.Text = "lblProgramName"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(232, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Short Form:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "PDF Folder #:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(423, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Act #:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Project #:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Program Name:"
        '
        'txtFAAProjectNo
        '
        Me.txtFAAProjectNo.Location = New System.Drawing.Point(185, 165)
        Me.txtFAAProjectNo.Name = "txtFAAProjectNo"
        Me.txtFAAProjectNo.Size = New System.Drawing.Size(213, 20)
        Me.txtFAAProjectNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FAA Project #:"
        '
        'cboLeadCertEngineer
        '
        Me.cboLeadCertEngineer.FormattingEnabled = True
        Me.cboLeadCertEngineer.Location = New System.Drawing.Point(185, 219)
        Me.cboLeadCertEngineer.Name = "cboLeadCertEngineer"
        Me.cboLeadCertEngineer.Size = New System.Drawing.Size(213, 21)
        Me.cboLeadCertEngineer.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lead Certification Engineer:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Unit Member:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 486)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "FAA/OMT Member:"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'lstUnitMember
        '
        Me.lstUnitMember.FormattingEnabled = True
        Me.lstUnitMember.Location = New System.Drawing.Point(185, 266)
        Me.lstUnitMember.Name = "lstUnitMember"
        Me.lstUnitMember.Size = New System.Drawing.Size(213, 199)
        Me.lstUnitMember.TabIndex = 7
        '
        'lstFAAOMTMember
        '
        Me.lstFAAOMTMember.FormattingEnabled = True
        Me.lstFAAOMTMember.Location = New System.Drawing.Point(185, 486)
        Me.lstFAAOMTMember.Name = "lstFAAOMTMember"
        Me.lstFAAOMTMember.Size = New System.Drawing.Size(213, 199)
        Me.lstFAAOMTMember.TabIndex = 8
        '
        'lstProgramUnitMember
        '
        Me.lstProgramUnitMember.FormattingEnabled = True
        Me.lstProgramUnitMember.Location = New System.Drawing.Point(485, 266)
        Me.lstProgramUnitMember.Name = "lstProgramUnitMember"
        Me.lstProgramUnitMember.Size = New System.Drawing.Size(213, 199)
        Me.lstProgramUnitMember.TabIndex = 9
        '
        'lstProgramFAAOMTMember
        '
        Me.lstProgramFAAOMTMember.FormattingEnabled = True
        Me.lstProgramFAAOMTMember.Location = New System.Drawing.Point(485, 486)
        Me.lstProgramFAAOMTMember.Name = "lstProgramFAAOMTMember"
        Me.lstProgramFAAOMTMember.Size = New System.Drawing.Size(213, 199)
        Me.lstProgramFAAOMTMember.TabIndex = 10
        '
        'btnProgramUnitMemberInclude
        '
        Me.btnProgramUnitMemberInclude.Location = New System.Drawing.Point(404, 332)
        Me.btnProgramUnitMemberInclude.Name = "btnProgramUnitMemberInclude"
        Me.btnProgramUnitMemberInclude.Size = New System.Drawing.Size(75, 23)
        Me.btnProgramUnitMemberInclude.TabIndex = 11
        Me.btnProgramUnitMemberInclude.Text = ">>"
        Me.btnProgramUnitMemberInclude.UseVisualStyleBackColor = True
        '
        'btnProgramUnitMemberExclude
        '
        Me.btnProgramUnitMemberExclude.Location = New System.Drawing.Point(404, 371)
        Me.btnProgramUnitMemberExclude.Name = "btnProgramUnitMemberExclude"
        Me.btnProgramUnitMemberExclude.Size = New System.Drawing.Size(75, 23)
        Me.btnProgramUnitMemberExclude.TabIndex = 12
        Me.btnProgramUnitMemberExclude.Text = "<<"
        Me.btnProgramUnitMemberExclude.UseVisualStyleBackColor = True
        '
        'btnProgramFAAOMTMemberExclude
        '
        Me.btnProgramFAAOMTMemberExclude.Location = New System.Drawing.Point(404, 576)
        Me.btnProgramFAAOMTMemberExclude.Name = "btnProgramFAAOMTMemberExclude"
        Me.btnProgramFAAOMTMemberExclude.Size = New System.Drawing.Size(75, 23)
        Me.btnProgramFAAOMTMemberExclude.TabIndex = 14
        Me.btnProgramFAAOMTMemberExclude.Text = "<<"
        Me.btnProgramFAAOMTMemberExclude.UseVisualStyleBackColor = True
        '
        'btnProgramFAAOMTUnitMemberInclude
        '
        Me.btnProgramFAAOMTUnitMemberInclude.Location = New System.Drawing.Point(404, 537)
        Me.btnProgramFAAOMTUnitMemberInclude.Name = "btnProgramFAAOMTUnitMemberInclude"
        Me.btnProgramFAAOMTUnitMemberInclude.Size = New System.Drawing.Size(75, 23)
        Me.btnProgramFAAOMTUnitMemberInclude.TabIndex = 13
        Me.btnProgramFAAOMTUnitMemberInclude.Text = ">>"
        Me.btnProgramFAAOMTUnitMemberInclude.UseVisualStyleBackColor = True
        '
        'btnSavePreferences
        '
        Me.btnSavePreferences.Location = New System.Drawing.Point(745, 662)
        Me.btnSavePreferences.Name = "btnSavePreferences"
        Me.btnSavePreferences.Size = New System.Drawing.Size(171, 41)
        Me.btnSavePreferences.TabIndex = 15
        Me.btnSavePreferences.Text = "Save Program Cert Preferences"
        Me.btnSavePreferences.UseVisualStyleBackColor = True
        '
        'frmCertificationManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 707)
        Me.Controls.Add(Me.btnSavePreferences)
        Me.Controls.Add(Me.btnProgramFAAOMTMemberExclude)
        Me.Controls.Add(Me.btnProgramFAAOMTUnitMemberInclude)
        Me.Controls.Add(Me.btnProgramUnitMemberExclude)
        Me.Controls.Add(Me.btnProgramUnitMemberInclude)
        Me.Controls.Add(Me.lstProgramFAAOMTMember)
        Me.Controls.Add(Me.lstProgramUnitMember)
        Me.Controls.Add(Me.lstFAAOMTMember)
        Me.Controls.Add(Me.lstUnitMember)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboLeadCertEngineer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFAAProjectNo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCertificationManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCertificationManager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFAAProjectNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboLeadCertEngineer As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents lstUnitMember As ListBox
    Friend WithEvents lstFAAOMTMember As ListBox
    Friend WithEvents lstProgramUnitMember As ListBox
    Friend WithEvents lstProgramFAAOMTMember As ListBox
    Friend WithEvents btnProgramUnitMemberInclude As Button
    Friend WithEvents btnProgramUnitMemberExclude As Button
    Friend WithEvents btnProgramFAAOMTMemberExclude As Button
    Friend WithEvents btnProgramFAAOMTUnitMemberInclude As Button
    Friend WithEvents lblShortForm As Label
    Friend WithEvents lblPDFFolder As Label
    Friend WithEvents lblActNo As Label
    Friend WithEvents lblProjectNumber As Label
    Friend WithEvents lblProgramName As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSavePreferences As Button
End Class
