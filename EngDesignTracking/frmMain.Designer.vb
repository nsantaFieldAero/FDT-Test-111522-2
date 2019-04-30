<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEARR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExitApplication = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 46)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 91)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Engineering Drawing Design Flow"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEARR
        '
        Me.btnEARR.Location = New System.Drawing.Point(78, 258)
        Me.btnEARR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEARR.Name = "btnEARR"
        Me.btnEARR.Size = New System.Drawing.Size(164, 91)
        Me.btnEARR.TabIndex = 1
        Me.btnEARR.Text = "EARR"
        Me.btnEARR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(585, 149)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Engineering Drawing Design Process.  Tool holds current status for enginering des" &
    "ign drawing efforts."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(585, 149)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Users may submit EAAR requests and approve requests."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 569)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(303, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Compile Date:  12/10/2018 12:48 PM"
        '
        'btnExitApplication
        '
        Me.btnExitApplication.Location = New System.Drawing.Point(78, 432)
        Me.btnExitApplication.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExitApplication.Name = "btnExitApplication"
        Me.btnExitApplication.Size = New System.Drawing.Size(164, 91)
        Me.btnExitApplication.TabIndex = 5
        Me.btnExitApplication.Text = "Exit"
        Me.btnExitApplication.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(654, 566)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(57, 20)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Label4"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(886, 622)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnExitApplication)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEARR)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Engineering Workflow Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnEARR As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExitApplication As Button
    Friend WithEvents lblUsername As Label
End Class
