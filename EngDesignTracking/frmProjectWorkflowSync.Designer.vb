<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectWorkflowSync
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjectWorkflowSync))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlProjServer = New System.Data.SqlClient.SqlConnection()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.optServertoWorkflow = New System.Windows.Forms.RadioButton()
        Me.cboProjectServerProjectNames = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboEngWorkflowProjects = New System.Windows.Forms.ComboBox()
        Me.btnSync = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlProjServer
        '
        Me.SqlProjServer.ConnectionString = "Data Source=172.16.3.9;Initial Catalog=ProjectWebAppProd;Persist Security Info=Tr" &
    "ue;User ID=sa1;Password=""The water is wet!"""
        Me.SqlProjServer.FireInfoMessageEventOnUserErrors = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.optServertoWorkflow)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 34)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1156, 145)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Synchronization Direction"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(82, 98)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(360, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Engineering Workflow > Project Server"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'optServertoWorkflow
        '
        Me.optServertoWorkflow.AutoSize = True
        Me.optServertoWorkflow.Location = New System.Drawing.Point(82, 46)
        Me.optServertoWorkflow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optServertoWorkflow.Name = "optServertoWorkflow"
        Me.optServertoWorkflow.Size = New System.Drawing.Size(360, 24)
        Me.optServertoWorkflow.TabIndex = 0
        Me.optServertoWorkflow.TabStop = True
        Me.optServertoWorkflow.Text = "Project Server > Engineering Workflow"
        Me.optServertoWorkflow.UseVisualStyleBackColor = True
        '
        'cboProjectServerProjectNames
        '
        Me.cboProjectServerProjectNames.FormattingEnabled = True
        Me.cboProjectServerProjectNames.Location = New System.Drawing.Point(362, 208)
        Me.cboProjectServerProjectNames.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboProjectServerProjectNames.Name = "cboProjectServerProjectNames"
        Me.cboProjectServerProjectNames.Size = New System.Drawing.Size(544, 28)
        Me.cboProjectServerProjectNames.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 208)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Project Server Project Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 285)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Engineering Workflow Project Name:"
        '
        'cboEngWorkflowProjects
        '
        Me.cboEngWorkflowProjects.FormattingEnabled = True
        Me.cboEngWorkflowProjects.Location = New System.Drawing.Point(362, 285)
        Me.cboEngWorkflowProjects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboEngWorkflowProjects.Name = "cboEngWorkflowProjects"
        Me.cboEngWorkflowProjects.Size = New System.Drawing.Size(544, 28)
        Me.cboEngWorkflowProjects.TabIndex = 4
        '
        'btnSync
        '
        Me.btnSync.Location = New System.Drawing.Point(966, 409)
        Me.btnSync.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSync.Name = "btnSync"
        Me.btnSync.Size = New System.Drawing.Size(164, 35)
        Me.btnSync.TabIndex = 5
        Me.btnSync.Text = "Sync"
        Me.btnSync.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(771, 409)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 35)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmProjectWorkflowSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 458)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSync)
        Me.Controls.Add(Me.cboEngWorkflowProjects)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboProjectServerProjectNames)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmProjectWorkflowSync"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProjectWorkflowSync"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlProjServer As SqlClient.SqlConnection
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents optServertoWorkflow As RadioButton
    Friend WithEvents cboProjectServerProjectNames As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboEngWorkflowProjects As ComboBox
    Friend WithEvents btnSync As Button
    Friend WithEvents Button2 As Button
End Class
