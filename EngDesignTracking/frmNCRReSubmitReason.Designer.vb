<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNCRReSubmitReason
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
        Me.rtxtResubmitReason = New System.Windows.Forms.RichTextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtxtResubmitReason
        '
        Me.rtxtResubmitReason.Location = New System.Drawing.Point(12, 12)
        Me.rtxtResubmitReason.Name = "rtxtResubmitReason"
        Me.rtxtResubmitReason.Size = New System.Drawing.Size(476, 301)
        Me.rtxtResubmitReason.TabIndex = 0
        Me.rtxtResubmitReason.Text = ""
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(65, 335)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(375, 47)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmNCRReSubmitReason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 381)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.rtxtResubmitReason)
        Me.Name = "frmNCRReSubmitReason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Re-Submit Reason"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtxtResubmitReason As RichTextBox
    Friend WithEvents btnOK As Button
End Class
