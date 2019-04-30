<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewDWGRequest
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
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProgram = New System.Windows.Forms.ComboBox()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.txtDrawingTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSystemDescription = New System.Windows.Forms.TextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboDrawingType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDrawingNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboDrawingRevision = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpDrafterPlanned = New System.Windows.Forms.DateTimePicker()
        Me.txtboxDrafter = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblNextHigherAssembly = New System.Windows.Forms.Label()
        Me.txtboxNextHigherAssembly = New System.Windows.Forms.TextBox()
        Me.txtEstimatedDurationHours = New System.Windows.Forms.TextBox()
        Me.EstimatedDuration = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtForecastStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtWONo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 191)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Drawing Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 157)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "System Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 120)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Drawing Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(529, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Program:"
        '
        'cboProgram
        '
        Me.cboProgram.FormattingEnabled = True
        Me.cboProgram.Location = New System.Drawing.Point(579, 75)
        Me.cboProgram.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboProgram.Name = "cboProgram"
        Me.cboProgram.Size = New System.Drawing.Size(148, 21)
        Me.cboProgram.TabIndex = 8
        '
        'cboLocation
        '
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Items.AddRange(New Object() {"Calgary", "OKC", "Toronto"})
        Me.cboLocation.Location = New System.Drawing.Point(341, 75)
        Me.cboLocation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(148, 21)
        Me.cboLocation.TabIndex = 3
        '
        'txtDrawingTitle
        '
        Me.txtDrawingTitle.Location = New System.Drawing.Point(149, 120)
        Me.txtDrawingTitle.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDrawingTitle.Name = "txtDrawingTitle"
        Me.txtDrawingTitle.Size = New System.Drawing.Size(659, 20)
        Me.txtDrawingTitle.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Location:"
        '
        'txtSystemDescription
        '
        Me.txtSystemDescription.Location = New System.Drawing.Point(149, 156)
        Me.txtSystemDescription.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSystemDescription.Name = "txtSystemDescription"
        Me.txtSystemDescription.Size = New System.Drawing.Size(659, 20)
        Me.txtSystemDescription.TabIndex = 10
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.SystemColors.Window
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"M", "E", "S", "RWK = Rework", "RPT = Document/Reports"})
        Me.cboType.Location = New System.Drawing.Point(95, 75)
        Me.cboType.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(126, 21)
        Me.cboType.TabIndex = 1
        '
        'cboDrawingType
        '
        Me.cboDrawingType.FormattingEnabled = True
        Me.cboDrawingType.Items.AddRange(New Object() {"Assembly", "Detail", "General Arrangement", "Harness Assembly", "Installation", "Provisions", "Rework", "Specification", "Tooling", "Wire Diagram", "Wire Routing Diagram", "Report", "Presentation", "Repair"})
        Me.cboDrawingType.Location = New System.Drawing.Point(113, 191)
        Me.cboDrawingType.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboDrawingType.Name = "cboDrawingType"
        Me.cboDrawingType.Size = New System.Drawing.Size(148, 21)
        Me.cboDrawingType.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(814, 298)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(114, 29)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 36)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Drawing #:"
        '
        'txtDrawingNumber
        '
        Me.txtDrawingNumber.Location = New System.Drawing.Point(95, 36)
        Me.txtDrawingNumber.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDrawingNumber.Name = "txtDrawingNumber"
        Me.txtDrawingNumber.Size = New System.Drawing.Size(125, 20)
        Me.txtDrawingNumber.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(229, 40)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(227, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Leave empty unless drawing number is known."
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(686, 298)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 29)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close, Don't Submit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(482, 36)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Drawing Revision:"
        '
        'cboDrawingRevision
        '
        Me.cboDrawingRevision.FormattingEnabled = True
        Me.cboDrawingRevision.Location = New System.Drawing.Point(579, 34)
        Me.cboDrawingRevision.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboDrawingRevision.Name = "cboDrawingRevision"
        Me.cboDrawingRevision.Size = New System.Drawing.Size(148, 21)
        Me.cboDrawingRevision.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDrafterPlanned)
        Me.GroupBox1.Controls.Add(Me.txtboxDrafter)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblNextHigherAssembly)
        Me.GroupBox1.Controls.Add(Me.txtboxNextHigherAssembly)
        Me.GroupBox1.Controls.Add(Me.txtEstimatedDurationHours)
        Me.GroupBox1.Controls.Add(Me.EstimatedDuration)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtForecastStartDate)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtWONo)
        Me.GroupBox1.Controls.Add(Me.cboDrawingRevision)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtDrawingNumber)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnSubmit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboDrawingType)
        Me.GroupBox1.Controls.Add(Me.cboType)
        Me.GroupBox1.Controls.Add(Me.txtSystemDescription)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDrawingTitle)
        Me.GroupBox1.Controls.Add(Me.cboLocation)
        Me.GroupBox1.Controls.Add(Me.cboProgram)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 42)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(932, 340)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please fill out the fields and click submit."
        '
        'dtpDrafterPlanned
        '
        Me.dtpDrafterPlanned.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDrafterPlanned.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDrafterPlanned.Location = New System.Drawing.Point(446, 269)
        Me.dtpDrafterPlanned.Name = "dtpDrafterPlanned"
        Me.dtpDrafterPlanned.Size = New System.Drawing.Size(148, 20)
        Me.dtpDrafterPlanned.TabIndex = 32
        Me.dtpDrafterPlanned.Value = New Date(2019, 4, 24, 0, 0, 0, 0)
        '
        'txtboxDrafter
        '
        Me.txtboxDrafter.Location = New System.Drawing.Point(113, 266)
        Me.txtboxDrafter.Name = "txtboxDrafter"
        Me.txtboxDrafter.Size = New System.Drawing.Size(148, 20)
        Me.txtboxDrafter.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(286, 269)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(157, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Drafter Planned Complete Date:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 269)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Drafter:"
        '
        'lblNextHigherAssembly
        '
        Me.lblNextHigherAssembly.AutoSize = True
        Me.lblNextHigherAssembly.Location = New System.Drawing.Point(327, 194)
        Me.lblNextHigherAssembly.Name = "lblNextHigherAssembly"
        Me.lblNextHigherAssembly.Size = New System.Drawing.Size(113, 13)
        Me.lblNextHigherAssembly.TabIndex = 28
        Me.lblNextHigherAssembly.Text = "Next Higher Assembly:"
        '
        'txtboxNextHigherAssembly
        '
        Me.txtboxNextHigherAssembly.Location = New System.Drawing.Point(446, 192)
        Me.txtboxNextHigherAssembly.Name = "txtboxNextHigherAssembly"
        Me.txtboxNextHigherAssembly.Size = New System.Drawing.Size(148, 20)
        Me.txtboxNextHigherAssembly.TabIndex = 27
        '
        'txtEstimatedDurationHours
        '
        Me.txtEstimatedDurationHours.Location = New System.Drawing.Point(165, 307)
        Me.txtEstimatedDurationHours.Name = "txtEstimatedDurationHours"
        Me.txtEstimatedDurationHours.Size = New System.Drawing.Size(96, 20)
        Me.txtEstimatedDurationHours.TabIndex = 26
        '
        'EstimatedDuration
        '
        Me.EstimatedDuration.AutoSize = True
        Me.EstimatedDuration.Location = New System.Drawing.Point(29, 307)
        Me.EstimatedDuration.Name = "EstimatedDuration"
        Me.EstimatedDuration.Size = New System.Drawing.Size(130, 13)
        Me.EstimatedDuration.TabIndex = 24
        Me.EstimatedDuration.Text = "Estimated Duration Hours:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 228)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Forecast Start Date"
        '
        'txtForecastStartDate
        '
        Me.txtForecastStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.txtForecastStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtForecastStartDate.Location = New System.Drawing.Point(134, 228)
        Me.txtForecastStartDate.Name = "txtForecastStartDate"
        Me.txtForecastStartDate.Size = New System.Drawing.Size(127, 20)
        Me.txtForecastStartDate.TabIndex = 21
        Me.txtForecastStartDate.Value = New Date(2019, 4, 24, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(761, 34)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "WO #:"
        '
        'txtWONo
        '
        Me.txtWONo.Location = New System.Drawing.Point(804, 34)
        Me.txtWONo.Margin = New System.Windows.Forms.Padding(1)
        Me.txtWONo.Name = "txtWONo"
        Me.txtWONo.Size = New System.Drawing.Size(125, 20)
        Me.txtWONo.TabIndex = 19
        '
        'frmNewDWGRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 412)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmNewDWGRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Field Engineering Drawing Status System - New Record"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboProgram As ComboBox
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents txtDrawingTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSystemDescription As TextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents cboDrawingType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDrawingNumber As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cboDrawingRevision As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtWONo As TextBox
    Friend WithEvents txtForecastStartDate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents EstimatedDuration As Label
    Friend WithEvents txtEstimatedDurationHours As TextBox
    Friend WithEvents lblNextHigherAssembly As Label
    Friend WithEvents txtboxNextHigherAssembly As TextBox
    Friend WithEvents txtboxDrafter As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpDrafterPlanned As DateTimePicker
End Class
