<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiveMDLOptionsMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiveMDLOptionsMenu))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboShowPreviousRevText = New System.Windows.Forms.ComboBox()
        Me.chkShowPreviousRev = New System.Windows.Forms.CheckBox()
        Me.txtOverrideDRNText = New System.Windows.Forms.TextBox()
        Me.chkCancelled = New System.Windows.Forms.CheckBox()
        Me.chkDeferToNextMDL = New System.Windows.Forms.CheckBox()
        Me.chkOverrideDRNDetails = New System.Windows.Forms.CheckBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.chkShowRemarks = New System.Windows.Forms.CheckBox()
        Me.txtRemarksText = New System.Windows.Forms.TextBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboShowPreviousRevText)
        Me.GroupBox1.Controls.Add(Me.chkShowPreviousRev)
        Me.GroupBox1.Controls.Add(Me.txtOverrideDRNText)
        Me.GroupBox1.Controls.Add(Me.chkCancelled)
        Me.GroupBox1.Controls.Add(Me.chkDeferToNextMDL)
        Me.GroupBox1.Controls.Add(Me.chkOverrideDRNDetails)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 85)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1056, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exceptions"
        '
        'cboShowPreviousRevText
        '
        Me.cboShowPreviousRevText.FormattingEnabled = True
        Me.cboShowPreviousRevText.Location = New System.Drawing.Point(612, 88)
        Me.cboShowPreviousRevText.Name = "cboShowPreviousRevText"
        Me.cboShowPreviousRevText.Size = New System.Drawing.Size(121, 28)
        Me.cboShowPreviousRevText.TabIndex = 6
        '
        'chkShowPreviousRev
        '
        Me.chkShowPreviousRev.AutoSize = True
        Me.chkShowPreviousRev.Location = New System.Drawing.Point(387, 88)
        Me.chkShowPreviousRev.Name = "chkShowPreviousRev"
        Me.chkShowPreviousRev.Size = New System.Drawing.Size(197, 24)
        Me.chkShowPreviousRev.TabIndex = 5
        Me.chkShowPreviousRev.Text = "Show Previous Rev"
        Me.chkShowPreviousRev.UseVisualStyleBackColor = True
        '
        'txtOverrideDRNText
        '
        Me.txtOverrideDRNText.Location = New System.Drawing.Point(387, 43)
        Me.txtOverrideDRNText.Name = "txtOverrideDRNText"
        Me.txtOverrideDRNText.Size = New System.Drawing.Size(639, 26)
        Me.txtOverrideDRNText.TabIndex = 4
        '
        'chkCancelled
        '
        Me.chkCancelled.AutoSize = True
        Me.chkCancelled.Location = New System.Drawing.Point(32, 122)
        Me.chkCancelled.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkCancelled.Name = "chkCancelled"
        Me.chkCancelled.Size = New System.Drawing.Size(221, 24)
        Me.chkCancelled.TabIndex = 3
        Me.chkCancelled.Text = "Cancel this Document"
        Me.chkCancelled.UseVisualStyleBackColor = True
        '
        'chkDeferToNextMDL
        '
        Me.chkDeferToNextMDL.AutoSize = True
        Me.chkDeferToNextMDL.Location = New System.Drawing.Point(32, 88)
        Me.chkDeferToNextMDL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkDeferToNextMDL.Name = "chkDeferToNextMDL"
        Me.chkDeferToNextMDL.Size = New System.Drawing.Size(344, 24)
        Me.chkDeferToNextMDL.TabIndex = 2
        Me.chkDeferToNextMDL.Text = "Defer this Rev to next MDL Revision"
        Me.chkDeferToNextMDL.UseVisualStyleBackColor = True
        '
        'chkOverrideDRNDetails
        '
        Me.chkOverrideDRNDetails.AutoSize = True
        Me.chkOverrideDRNDetails.Location = New System.Drawing.Point(32, 54)
        Me.chkOverrideDRNDetails.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkOverrideDRNDetails.Name = "chkOverrideDRNDetails"
        Me.chkOverrideDRNDetails.Size = New System.Drawing.Size(219, 24)
        Me.chkOverrideDRNDetails.TabIndex = 0
        Me.chkOverrideDRNDetails.Text = "Override DRN Details"
        Me.chkOverrideDRNDetails.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(890, 285)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(183, 35)
        Me.btnApply.TabIndex = 1
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(691, 285)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(190, 35)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(28, 285)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(190, 35)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Open Entry"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'chkShowRemarks
        '
        Me.chkShowRemarks.AutoSize = True
        Me.chkShowRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowRemarks.Location = New System.Drawing.Point(50, 31)
        Me.chkShowRemarks.Name = "chkShowRemarks"
        Me.chkShowRemarks.Size = New System.Drawing.Size(155, 24)
        Me.chkShowRemarks.TabIndex = 4
        Me.chkShowRemarks.Text = "Show Remarks"
        Me.chkShowRemarks.UseVisualStyleBackColor = True
        '
        'txtRemarksText
        '
        Me.txtRemarksText.Location = New System.Drawing.Point(240, 29)
        Me.txtRemarksText.Name = "txtRemarksText"
        Me.txtRemarksText.Size = New System.Drawing.Size(547, 26)
        Me.txtRemarksText.TabIndex = 5
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'frmLiveMDLOptionsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1092, 339)
        Me.Controls.Add(Me.txtRemarksText)
        Me.Controls.Add(Me.chkShowRemarks)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLiveMDLOptionsMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLiveMDLOptionsMenu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkCancelled As CheckBox
    Friend WithEvents chkDeferToNextMDL As CheckBox
    Friend WithEvents chkOverrideDRNDetails As CheckBox
    Friend WithEvents btnApply As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents chkShowRemarks As CheckBox
    Friend WithEvents cboShowPreviousRevText As ComboBox
    Friend WithEvents chkShowPreviousRev As CheckBox
    Friend WithEvents txtOverrideDRNText As TextBox
    Friend WithEvents txtRemarksText As TextBox
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
End Class
