<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEngWorkflowChangeDrawingNumber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEngWorkflowChangeDrawingNumber))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDocNumber = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewDocNumber = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtActualDocType = New System.Windows.Forms.TextBox()
        Me.cboChangeDocType = New System.Windows.Forms.ComboBox()
        Me.txtDocTypeInDropdown = New System.Windows.Forms.TextBox()
        Me.lblDocTypeInDropdown = New System.Windows.Forms.Label()
        Me.btnChangeDocType = New System.Windows.Forms.Button()
        Me.btnCancelDocType = New System.Windows.Forms.Button()
        Me.lblChangeItTo = New System.Windows.Forms.Label()
        Me.lblSelectDocType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Document Number You Are Changing:"
        '
        'lblDocNumber
        '
        Me.lblDocNumber.AutoSize = True
        Me.lblDocNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocNumber.Location = New System.Drawing.Point(324, 9)
        Me.lblDocNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDocNumber.Name = "lblDocNumber"
        Me.lblDocNumber.Size = New System.Drawing.Size(63, 20)
        Me.lblDocNumber.TabIndex = 1
        Me.lblDocNumber.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Document Number You are Changing To:"
        '
        'txtNewDocNumber
        '
        Me.txtNewDocNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewDocNumber.Location = New System.Drawing.Point(340, 39)
        Me.txtNewDocNumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNewDocNumber.Name = "txtNewDocNumber"
        Me.txtNewDocNumber.Size = New System.Drawing.Size(287, 26)
        Me.txtNewDocNumber.TabIndex = 3
        '
        'btnChange
        '
        Me.btnChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(433, 69)
        Me.btnChange.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(194, 31)
        Me.btnChange.TabIndex = 4
        Me.btnChange.Text = "Change Document #"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(310, 69)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 31)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-132, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(903, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "_________________________________________________________________________________" &
    "_______________________________________________"
        '
        'txtActualDocType
        '
        Me.txtActualDocType.Location = New System.Drawing.Point(196, 137)
        Me.txtActualDocType.Name = "txtActualDocType"
        Me.txtActualDocType.ReadOnly = True
        Me.txtActualDocType.Size = New System.Drawing.Size(440, 20)
        Me.txtActualDocType.TabIndex = 24
        '
        'cboChangeDocType
        '
        Me.cboChangeDocType.FormattingEnabled = True
        Me.cboChangeDocType.Location = New System.Drawing.Point(195, 169)
        Me.cboChangeDocType.Name = "cboChangeDocType"
        Me.cboChangeDocType.Size = New System.Drawing.Size(441, 21)
        Me.cboChangeDocType.TabIndex = 23
        '
        'txtDocTypeInDropdown
        '
        Me.txtDocTypeInDropdown.Location = New System.Drawing.Point(210, 202)
        Me.txtDocTypeInDropdown.Name = "txtDocTypeInDropdown"
        Me.txtDocTypeInDropdown.Size = New System.Drawing.Size(426, 20)
        Me.txtDocTypeInDropdown.TabIndex = 22
        Me.txtDocTypeInDropdown.Visible = False
        '
        'lblDocTypeInDropdown
        '
        Me.lblDocTypeInDropdown.AutoSize = True
        Me.lblDocTypeInDropdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocTypeInDropdown.Location = New System.Drawing.Point(0, 203)
        Me.lblDocTypeInDropdown.Name = "lblDocTypeInDropdown"
        Me.lblDocTypeInDropdown.Size = New System.Drawing.Size(203, 20)
        Me.lblDocTypeInDropdown.TabIndex = 21
        Me.lblDocTypeInDropdown.Text = "Doc Type in Drop-Down:"
        Me.lblDocTypeInDropdown.Visible = False
        '
        'btnChangeDocType
        '
        Me.btnChangeDocType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeDocType.Location = New System.Drawing.Point(445, 229)
        Me.btnChangeDocType.Name = "btnChangeDocType"
        Me.btnChangeDocType.Size = New System.Drawing.Size(191, 31)
        Me.btnChangeDocType.TabIndex = 20
        Me.btnChangeDocType.Text = "Change Doc Type"
        Me.btnChangeDocType.UseVisualStyleBackColor = True
        '
        'btnCancelDocType
        '
        Me.btnCancelDocType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelDocType.Location = New System.Drawing.Point(319, 229)
        Me.btnCancelDocType.Name = "btnCancelDocType"
        Me.btnCancelDocType.Size = New System.Drawing.Size(119, 31)
        Me.btnCancelDocType.TabIndex = 19
        Me.btnCancelDocType.Text = "Cancel"
        Me.btnCancelDocType.UseVisualStyleBackColor = True
        '
        'lblChangeItTo
        '
        Me.lblChangeItTo.AutoSize = True
        Me.lblChangeItTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeItTo.Location = New System.Drawing.Point(-1, 167)
        Me.lblChangeItTo.Name = "lblChangeItTo"
        Me.lblChangeItTo.Size = New System.Drawing.Size(112, 20)
        Me.lblChangeItTo.TabIndex = 18
        Me.lblChangeItTo.Text = "Change it to:"
        '
        'lblSelectDocType
        '
        Me.lblSelectDocType.AutoSize = True
        Me.lblSelectDocType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectDocType.Location = New System.Drawing.Point(-1, 135)
        Me.lblSelectDocType.Name = "lblSelectDocType"
        Me.lblSelectDocType.Size = New System.Drawing.Size(190, 20)
        Me.lblSelectDocType.TabIndex = 17
        Me.lblSelectDocType.Text = "Actual Document Type"
        '
        'frmEngWorkflowChangeDrawingNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 266)
        Me.Controls.Add(Me.txtActualDocType)
        Me.Controls.Add(Me.cboChangeDocType)
        Me.Controls.Add(Me.txtDocTypeInDropdown)
        Me.Controls.Add(Me.lblDocTypeInDropdown)
        Me.Controls.Add(Me.btnChangeDocType)
        Me.Controls.Add(Me.btnCancelDocType)
        Me.Controls.Add(Me.lblChangeItTo)
        Me.Controls.Add(Me.lblSelectDocType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtNewDocNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDocNumber)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmEngWorkflowChangeDrawingNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEngWorkflowChangeDrawingNumber"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblDocNumber As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNewDocNumber As TextBox
    Friend WithEvents btnChange As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents Label3 As Label
    Friend WithEvents txtActualDocType As TextBox
    Friend WithEvents cboChangeDocType As ComboBox
    Friend WithEvents txtDocTypeInDropdown As TextBox
    Friend WithEvents lblDocTypeInDropdown As Label
    Friend WithEvents btnChangeDocType As Button
    Friend WithEvents btnCancelDocType As Button
    Friend WithEvents lblChangeItTo As Label
    Friend WithEvents lblSelectDocType As Label
End Class
