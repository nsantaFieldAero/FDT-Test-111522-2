<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNCRAbortReason
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
        Me.rtxtAbortReason = New System.Windows.Forms.RichTextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtxtAbortReason
        '
        Me.rtxtAbortReason.Location = New System.Drawing.Point(12, 12)
        Me.rtxtAbortReason.Name = "rtxtAbortReason"
        Me.rtxtAbortReason.Size = New System.Drawing.Size(367, 210)
        Me.rtxtAbortReason.TabIndex = 0
        Me.rtxtAbortReason.Text = ""
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(72, 229)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(256, 31)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmNCRAbortReason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 264)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.rtxtAbortReason)
        Me.Name = "frmNCRAbortReason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Aborted Reason"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtxtAbortReason As RichTextBox
    Friend WithEvents btnOK As Button
End Class
