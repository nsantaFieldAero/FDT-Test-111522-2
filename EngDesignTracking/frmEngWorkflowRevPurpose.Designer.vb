<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEngWorkflowRevPurpose
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExamples = New System.Windows.Forms.Button()
        Me.btnContinueRevPurpose = New System.Windows.Forms.Button()
        Me.chkboxProduction = New System.Windows.Forms.CheckBox()
        Me.chkboxEngineering = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Please select one of the two options"
        '
        'btnExamples
        '
        Me.btnExamples.Location = New System.Drawing.Point(214, 50)
        Me.btnExamples.Name = "btnExamples"
        Me.btnExamples.Size = New System.Drawing.Size(75, 23)
        Me.btnExamples.TabIndex = 8
        Me.btnExamples.Text = "Examples"
        Me.btnExamples.UseVisualStyleBackColor = True
        '
        'btnContinueRevPurpose
        '
        Me.btnContinueRevPurpose.Location = New System.Drawing.Point(29, 154)
        Me.btnContinueRevPurpose.Name = "btnContinueRevPurpose"
        Me.btnContinueRevPurpose.Size = New System.Drawing.Size(208, 52)
        Me.btnContinueRevPurpose.TabIndex = 7
        Me.btnContinueRevPurpose.Text = "Continue"
        Me.btnContinueRevPurpose.UseVisualStyleBackColor = True
        '
        'chkboxProduction
        '
        Me.chkboxProduction.AutoSize = True
        Me.chkboxProduction.Location = New System.Drawing.Point(29, 94)
        Me.chkboxProduction.Name = "chkboxProduction"
        Me.chkboxProduction.Size = New System.Drawing.Size(131, 17)
        Me.chkboxProduction.TabIndex = 6
        Me.chkboxProduction.Text = "Initiated by Production"
        Me.chkboxProduction.UseVisualStyleBackColor = True
        '
        'chkboxEngineering
        '
        Me.chkboxEngineering.AutoSize = True
        Me.chkboxEngineering.Location = New System.Drawing.Point(29, 54)
        Me.chkboxEngineering.Name = "chkboxEngineering"
        Me.chkboxEngineering.Size = New System.Drawing.Size(136, 17)
        Me.chkboxEngineering.TabIndex = 5
        Me.chkboxEngineering.Text = "Initiated by Engineering"
        Me.chkboxEngineering.UseVisualStyleBackColor = True
        '
        'frmEngWorkflowRevPurpose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 228)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExamples)
        Me.Controls.Add(Me.btnContinueRevPurpose)
        Me.Controls.Add(Me.chkboxProduction)
        Me.Controls.Add(Me.chkboxEngineering)
        Me.Name = "frmEngWorkflowRevPurpose"
        Me.Text = "frmEngWorkflowRevPurpose"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnExamples As Button
    Friend WithEvents btnContinueRevPurpose As Button
    Friend WithEvents chkboxProduction As CheckBox
    Friend WithEvents chkboxEngineering As CheckBox
End Class
