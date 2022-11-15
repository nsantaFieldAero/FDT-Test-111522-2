<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEngWorkflowRevorDRN
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
        Me.btnNewRevision = New System.Windows.Forms.Button()
        Me.btnDRN = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cboDRN = New System.Windows.Forms.ComboBox()
        Me.lblDRN = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.lblEnterADCN = New System.Windows.Forms.Label()
        Me.mskADCN = New System.Windows.Forms.MaskedTextBox()
        Me.btnEnterADCN = New System.Windows.Forms.Button()
        Me.btnADCN = New System.Windows.Forms.Button()
        Me.cbChooseAIM = New System.Windows.Forms.ComboBox()
        Me.lblChooseAIM = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Revision Type below to continue."
        '
        'btnNewRevision
        '
        Me.btnNewRevision.Location = New System.Drawing.Point(33, 85)
        Me.btnNewRevision.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewRevision.Name = "btnNewRevision"
        Me.btnNewRevision.Size = New System.Drawing.Size(106, 34)
        Me.btnNewRevision.TabIndex = 1
        Me.btnNewRevision.Text = "New Revision"
        Me.btnNewRevision.UseVisualStyleBackColor = True
        '
        'btnDRN
        '
        Me.btnDRN.Location = New System.Drawing.Point(157, 85)
        Me.btnDRN.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDRN.Name = "btnDRN"
        Me.btnDRN.Size = New System.Drawing.Size(106, 34)
        Me.btnDRN.TabIndex = 2
        Me.btnDRN.Text = "DRN"
        Me.btnDRN.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(391, 85)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(106, 34)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cboDRN
        '
        Me.cboDRN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDRN.FormattingEnabled = True
        Me.cboDRN.Location = New System.Drawing.Point(189, 141)
        Me.cboDRN.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDRN.Name = "cboDRN"
        Me.cboDRN.Size = New System.Drawing.Size(143, 21)
        Me.cboDRN.TabIndex = 4
        Me.cboDRN.Visible = False
        '
        'lblDRN
        '
        Me.lblDRN.AutoSize = True
        Me.lblDRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRN.Location = New System.Drawing.Point(30, 141)
        Me.lblDRN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDRN.Name = "lblDRN"
        Me.lblDRN.Size = New System.Drawing.Size(143, 20)
        Me.lblDRN.TabIndex = 5
        Me.lblDRN.Text = "Select new DRN #:"
        Me.lblDRN.Visible = False
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(341, 133)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(2)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(106, 34)
        Me.btnContinue.TabIndex = 6
        Me.btnContinue.Text = ">>"
        Me.btnContinue.UseVisualStyleBackColor = True
        Me.btnContinue.Visible = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'lblEnterADCN
        '
        Me.lblEnterADCN.AutoSize = True
        Me.lblEnterADCN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterADCN.Location = New System.Drawing.Point(102, 188)
        Me.lblEnterADCN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEnterADCN.Name = "lblEnterADCN"
        Me.lblEnterADCN.Size = New System.Drawing.Size(71, 20)
        Me.lblEnterADCN.TabIndex = 7
        Me.lblEnterADCN.Text = "ADCN #:"
        Me.lblEnterADCN.Visible = False
        '
        'mskADCN
        '
        Me.mskADCN.Location = New System.Drawing.Point(189, 190)
        Me.mskADCN.Margin = New System.Windows.Forms.Padding(2)
        Me.mskADCN.Mask = "#####"
        Me.mskADCN.Name = "mskADCN"
        Me.mskADCN.Size = New System.Drawing.Size(143, 20)
        Me.mskADCN.TabIndex = 8
        Me.mskADCN.Visible = False
        '
        'btnEnterADCN
        '
        Me.btnEnterADCN.Location = New System.Drawing.Point(341, 204)
        Me.btnEnterADCN.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnterADCN.Name = "btnEnterADCN"
        Me.btnEnterADCN.Size = New System.Drawing.Size(106, 34)
        Me.btnEnterADCN.TabIndex = 9
        Me.btnEnterADCN.Text = ">>"
        Me.btnEnterADCN.UseVisualStyleBackColor = True
        Me.btnEnterADCN.Visible = False
        '
        'btnADCN
        '
        Me.btnADCN.Location = New System.Drawing.Point(273, 85)
        Me.btnADCN.Margin = New System.Windows.Forms.Padding(2)
        Me.btnADCN.Name = "btnADCN"
        Me.btnADCN.Size = New System.Drawing.Size(106, 34)
        Me.btnADCN.TabIndex = 10
        Me.btnADCN.Text = "ADCN"
        Me.btnADCN.UseVisualStyleBackColor = True
        '
        'cbChooseAIM
        '
        Me.cbChooseAIM.FormattingEnabled = True
        Me.cbChooseAIM.Location = New System.Drawing.Point(189, 236)
        Me.cbChooseAIM.Name = "cbChooseAIM"
        Me.cbChooseAIM.Size = New System.Drawing.Size(143, 21)
        Me.cbChooseAIM.TabIndex = 11
        '
        'lblChooseAIM
        '
        Me.lblChooseAIM.AutoSize = True
        Me.lblChooseAIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseAIM.Location = New System.Drawing.Point(59, 234)
        Me.lblChooseAIM.Name = "lblChooseAIM"
        Me.lblChooseAIM.Size = New System.Drawing.Size(114, 20)
        Me.lblChooseAIM.TabIndex = 12
        Me.lblChooseAIM.Text = "Choose AIM #:"
        '
        'frmEngWorkflowRevorDRN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(533, 283)
        Me.Controls.Add(Me.lblChooseAIM)
        Me.Controls.Add(Me.cbChooseAIM)
        Me.Controls.Add(Me.btnADCN)
        Me.Controls.Add(Me.btnEnterADCN)
        Me.Controls.Add(Me.mskADCN)
        Me.Controls.Add(Me.lblEnterADCN)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblDRN)
        Me.Controls.Add(Me.cboDRN)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDRN)
        Me.Controls.Add(Me.btnNewRevision)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEngWorkflowRevorDRN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEngWorkflowRevorDRN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnNewRevision As Button
    Friend WithEvents btnDRN As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cboDRN As ComboBox
    Friend WithEvents lblDRN As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents lblEnterADCN As Label
    Friend WithEvents mskADCN As MaskedTextBox
    Friend WithEvents btnEnterADCN As Button
    Friend WithEvents btnADCN As Button
    Friend WithEvents cbChooseAIM As ComboBox
    Friend WithEvents lblChooseAIM As Label
End Class
