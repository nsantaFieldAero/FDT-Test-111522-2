<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEARR
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkIncorpRedLineNo = New System.Windows.Forms.CheckBox()
        Me.chkIncorpRedLineYes = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDrawingReqForConformityNo = New System.Windows.Forms.CheckBox()
        Me.chkDrawingReqForConformityYes = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboEARRType = New System.Windows.Forms.ComboBox()
        Me.cboProgramName = New System.Windows.Forms.ComboBox()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.txtWorkOrder = New System.Windows.Forms.TextBox()
        Me.txtDrawingNumber = New System.Windows.Forms.TextBox()
        Me.txtRequest = New System.Windows.Forms.TextBox()
        Me.dtEARRResponseDate = New System.Windows.Forms.DateTimePicker()
        Me.txtOriginatorName = New System.Windows.Forms.TextBox()
        Me.dtOriginatorDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSubmitEARR = New System.Windows.Forms.Button()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtDrawingRevision = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEARRNumber = New System.Windows.Forms.TextBox()
        Me.chkFabShop = New System.Windows.Forms.CheckBox()
        Me.txtEndItemType = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1246, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fill out the information contained on this screen.  When you submit, the engineer" &
    "ing liaison will be notified based on the program selected below."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(467, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EARR Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(846, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Program Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "S/N:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(267, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Work Order.Step:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(667, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Drawing Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1083, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Drawing Revision:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Request:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkIncorpRedLineNo)
        Me.GroupBox1.Controls.Add(Me.chkIncorpRedLineYes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 402)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(366, 76)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Incorporate Red Line Drawing?"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'chkIncorpRedLineNo
        '
        Me.chkIncorpRedLineNo.AutoSize = True
        Me.chkIncorpRedLineNo.Location = New System.Drawing.Point(184, 39)
        Me.chkIncorpRedLineNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkIncorpRedLineNo.Name = "chkIncorpRedLineNo"
        Me.chkIncorpRedLineNo.Size = New System.Drawing.Size(68, 29)
        Me.chkIncorpRedLineNo.TabIndex = 12
        Me.chkIncorpRedLineNo.Text = "N/A"
        Me.chkIncorpRedLineNo.UseVisualStyleBackColor = True
        '
        'chkIncorpRedLineYes
        '
        Me.chkIncorpRedLineYes.AutoSize = True
        Me.chkIncorpRedLineYes.Location = New System.Drawing.Point(29, 39)
        Me.chkIncorpRedLineYes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkIncorpRedLineYes.Name = "chkIncorpRedLineYes"
        Me.chkIncorpRedLineYes.Size = New System.Drawing.Size(68, 29)
        Me.chkIncorpRedLineYes.TabIndex = 11
        Me.chkIncorpRedLineYes.Text = "Yes"
        Me.chkIncorpRedLineYes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkDrawingReqForConformityNo)
        Me.GroupBox2.Controls.Add(Me.chkDrawingReqForConformityYes)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(472, 402)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(366, 76)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Drawing Required For Conformity?"
        Me.GroupBox2.UseCompatibleTextRendering = True
        '
        'chkDrawingReqForConformityNo
        '
        Me.chkDrawingReqForConformityNo.AutoSize = True
        Me.chkDrawingReqForConformityNo.Location = New System.Drawing.Point(163, 39)
        Me.chkDrawingReqForConformityNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkDrawingReqForConformityNo.Name = "chkDrawingReqForConformityNo"
        Me.chkDrawingReqForConformityNo.Size = New System.Drawing.Size(59, 29)
        Me.chkDrawingReqForConformityNo.TabIndex = 14
        Me.chkDrawingReqForConformityNo.Text = "No"
        Me.chkDrawingReqForConformityNo.UseVisualStyleBackColor = True
        '
        'chkDrawingReqForConformityYes
        '
        Me.chkDrawingReqForConformityYes.AutoSize = True
        Me.chkDrawingReqForConformityYes.Location = New System.Drawing.Point(4, 39)
        Me.chkDrawingReqForConformityYes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkDrawingReqForConformityYes.Name = "chkDrawingReqForConformityYes"
        Me.chkDrawingReqForConformityYes.Size = New System.Drawing.Size(68, 29)
        Me.chkDrawingReqForConformityYes.TabIndex = 13
        Me.chkDrawingReqForConformityYes.Text = "Yes"
        Me.chkDrawingReqForConformityYes.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 606)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(210, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "EARR Response Date:"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 525)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 25)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Originator Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(469, 525)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 25)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Originator Date:"
        '
        'cboEARRType
        '
        Me.cboEARRType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEARRType.FormattingEnabled = True
        Me.cboEARRType.Items.AddRange(New Object() {"Electrical", "Mechanical"})
        Me.cboEARRType.Location = New System.Drawing.Point(606, 119)
        Me.cboEARRType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboEARRType.Name = "cboEARRType"
        Me.cboEARRType.Size = New System.Drawing.Size(201, 33)
        Me.cboEARRType.TabIndex = 3
        '
        'cboProgramName
        '
        Me.cboProgramName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProgramName.FormattingEnabled = True
        Me.cboProgramName.Items.AddRange(New Object() {"Jaguar", "Sherpa", "QCTEST"})
        Me.cboProgramName.Location = New System.Drawing.Point(1032, 119)
        Me.cboProgramName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboProgramName.Name = "cboProgramName"
        Me.cboProgramName.Size = New System.Drawing.Size(241, 33)
        Me.cboProgramName.TabIndex = 4
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialNumber.Location = New System.Drawing.Point(101, 231)
        Me.txtSerialNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(157, 30)
        Me.txtSerialNumber.TabIndex = 6
        '
        'txtWorkOrder
        '
        Me.txtWorkOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkOrder.Location = New System.Drawing.Point(439, 231)
        Me.txtWorkOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtWorkOrder.Name = "txtWorkOrder"
        Me.txtWorkOrder.Size = New System.Drawing.Size(196, 30)
        Me.txtWorkOrder.TabIndex = 7
        '
        'txtDrawingNumber
        '
        Me.txtDrawingNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrawingNumber.Location = New System.Drawing.Point(857, 231)
        Me.txtDrawingNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDrawingNumber.Name = "txtDrawingNumber"
        Me.txtDrawingNumber.Size = New System.Drawing.Size(177, 30)
        Me.txtDrawingNumber.TabIndex = 8
        '
        'txtRequest
        '
        Me.txtRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequest.Location = New System.Drawing.Point(131, 290)
        Me.txtRequest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRequest.Multiline = True
        Me.txtRequest.Name = "txtRequest"
        Me.txtRequest.Size = New System.Drawing.Size(1324, 78)
        Me.txtRequest.TabIndex = 10
        '
        'dtEARRResponseDate
        '
        Me.dtEARRResponseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEARRResponseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEARRResponseDate.Location = New System.Drawing.Point(273, 610)
        Me.dtEARRResponseDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtEARRResponseDate.Name = "dtEARRResponseDate"
        Me.dtEARRResponseDate.Size = New System.Drawing.Size(191, 30)
        Me.dtEARRResponseDate.TabIndex = 17
        Me.dtEARRResponseDate.Visible = False
        '
        'txtOriginatorName
        '
        Me.txtOriginatorName.Enabled = False
        Me.txtOriginatorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOriginatorName.Location = New System.Drawing.Point(211, 525)
        Me.txtOriginatorName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOriginatorName.Name = "txtOriginatorName"
        Me.txtOriginatorName.Size = New System.Drawing.Size(212, 30)
        Me.txtOriginatorName.TabIndex = 15
        '
        'dtOriginatorDate
        '
        Me.dtOriginatorDate.Enabled = False
        Me.dtOriginatorDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtOriginatorDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtOriginatorDate.Location = New System.Drawing.Point(660, 529)
        Me.dtOriginatorDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtOriginatorDate.Name = "dtOriginatorDate"
        Me.dtOriginatorDate.Size = New System.Drawing.Size(191, 30)
        Me.dtOriginatorDate.TabIndex = 16
        '
        'btnSubmitEARR
        '
        Me.btnSubmitEARR.Location = New System.Drawing.Point(1277, 665)
        Me.btnSubmitEARR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmitEARR.Name = "btnSubmitEARR"
        Me.btnSubmitEARR.Size = New System.Drawing.Size(155, 48)
        Me.btnSubmitEARR.TabIndex = 23
        Me.btnSubmitEARR.Text = "Create EARR"
        Me.btnSubmitEARR.UseVisualStyleBackColor = True
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=EARR;Persist Security Info=True;U" &
    "ser ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1097, 665)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(155, 48)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtDrawingRevision
        '
        Me.txtDrawingRevision.FormattingEnabled = True
        Me.txtDrawingRevision.Location = New System.Drawing.Point(1257, 231)
        Me.txtDrawingRevision.Name = "txtDrawingRevision"
        Me.txtDrawingRevision.Size = New System.Drawing.Size(183, 24)
        Me.txtDrawingRevision.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(32, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 25)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "EARR Number:"
        '
        'txtEARRNumber
        '
        Me.txtEARRNumber.Enabled = False
        Me.txtEARRNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEARRNumber.Location = New System.Drawing.Point(183, 116)
        Me.txtEARRNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEARRNumber.Name = "txtEARRNumber"
        Me.txtEARRNumber.Size = New System.Drawing.Size(278, 30)
        Me.txtEARRNumber.TabIndex = 2
        '
        'chkFabShop
        '
        Me.chkFabShop.AutoSize = True
        Me.chkFabShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFabShop.Location = New System.Drawing.Point(37, 69)
        Me.chkFabShop.Name = "chkFabShop"
        Me.chkFabShop.Size = New System.Drawing.Size(354, 29)
        Me.chkFabShop.TabIndex = 1
        Me.chkFabShop.Text = "Fab Shop EARR (Check box for yes)"
        Me.chkFabShop.UseVisualStyleBackColor = True
        '
        'txtEndItemType
        '
        Me.txtEndItemType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndItemType.Location = New System.Drawing.Point(183, 172)
        Me.txtEndItemType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEndItemType.Name = "txtEndItemType"
        Me.txtEndItemType.Size = New System.Drawing.Size(278, 30)
        Me.txtEndItemType.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(145, 25)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "End Item Type:"
        '
        'NewEARR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 732)
        Me.Controls.Add(Me.txtEndItemType)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chkFabShop)
        Me.Controls.Add(Me.txtEARRNumber)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDrawingRevision)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmitEARR)
        Me.Controls.Add(Me.dtOriginatorDate)
        Me.Controls.Add(Me.txtOriginatorName)
        Me.Controls.Add(Me.dtEARRResponseDate)
        Me.Controls.Add(Me.txtRequest)
        Me.Controls.Add(Me.txtDrawingNumber)
        Me.Controls.Add(Me.txtWorkOrder)
        Me.Controls.Add(Me.txtSerialNumber)
        Me.Controls.Add(Me.cboProgramName)
        Me.Controls.Add(Me.cboEARRType)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "NewEARR"
        Me.Text = "NewEARR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents chkIncorpRedLineNo As CheckBox
    Friend WithEvents chkIncorpRedLineYes As CheckBox
    Friend WithEvents chkDrawingReqForConformityNo As CheckBox
    Friend WithEvents chkDrawingReqForConformityYes As CheckBox
    Friend WithEvents cboEARRType As ComboBox
    Friend WithEvents cboProgramName As ComboBox
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents txtWorkOrder As TextBox
    Friend WithEvents txtDrawingNumber As TextBox
    Friend WithEvents txtRequest As TextBox
    Friend WithEvents dtEARRResponseDate As DateTimePicker
    Friend WithEvents txtOriginatorName As TextBox
    Friend WithEvents dtOriginatorDate As DateTimePicker
    Friend WithEvents btnSubmitEARR As Button
    Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtDrawingRevision As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEARRNumber As TextBox
    Friend WithEvents chkFabShop As CheckBox
    Friend WithEvents txtEndItemType As TextBox
    Friend WithEvents Label13 As Label
End Class
