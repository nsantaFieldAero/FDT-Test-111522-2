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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewDWGRequest))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProgram = New System.Windows.Forms.ComboBox()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.txtDrawingTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboWhiteBoardNumber = New System.Windows.Forms.ComboBox()
        Me.cboNewRework = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboDRNADCN = New System.Windows.Forms.ComboBox()
        Me.cboDrafter = New System.Windows.Forms.ComboBox()
        Me.cboSystemDescription = New System.Windows.Forms.ComboBox()
        Me.cboCompanyFlightTestRequired = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboPSCPDocsRequired = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFAAProjectNo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtInstallationDrawing = New System.Windows.Forms.TextBox()
        Me.dtpDrafterPlanned = New System.Windows.Forms.DateTimePicker()
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
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.Label5.Location = New System.Drawing.Point(696, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Document Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "System Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Document Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(794, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Program:"
        '
        'cboProgram
        '
        Me.cboProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProgram.FormattingEnabled = True
        Me.cboProgram.Location = New System.Drawing.Point(868, 115)
        Me.cboProgram.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboProgram.Name = "cboProgram"
        Me.cboProgram.Size = New System.Drawing.Size(220, 28)
        Me.cboProgram.TabIndex = 8
        '
        'cboLocation
        '
        Me.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Items.AddRange(New Object() {"Calgary", "OKC", "Toronto"})
        Me.cboLocation.Location = New System.Drawing.Point(512, 115)
        Me.cboLocation.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(220, 28)
        Me.cboLocation.TabIndex = 3
        '
        'txtDrawingTitle
        '
        Me.txtDrawingTitle.Location = New System.Drawing.Point(224, 185)
        Me.txtDrawingTitle.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtDrawingTitle.Name = "txtDrawingTitle"
        Me.txtDrawingTitle.Size = New System.Drawing.Size(986, 26)
        Me.txtDrawingTitle.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Location:"
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.SystemColors.Window
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(174, 115)
        Me.cboType.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(187, 28)
        Me.cboType.TabIndex = 1
        '
        'cboDrawingType
        '
        Me.cboDrawingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDrawingType.FormattingEnabled = True
        Me.cboDrawingType.Location = New System.Drawing.Point(822, 55)
        Me.cboDrawingType.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboDrawingType.Name = "cboDrawingType"
        Me.cboDrawingType.Size = New System.Drawing.Size(220, 28)
        Me.cboDrawingType.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Resource Type:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(1537, 463)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(171, 45)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Document #:"
        '
        'txtDrawingNumber
        '
        Me.txtDrawingNumber.Location = New System.Drawing.Point(142, 55)
        Me.txtDrawingNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDrawingNumber.Name = "txtDrawingNumber"
        Me.txtDrawingNumber.Size = New System.Drawing.Size(186, 26)
        Me.txtDrawingNumber.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(344, 62)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(335, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Leave empty unless drawing number is known."
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1345, 463)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(171, 45)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close, Don't Submit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1050, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Doc Revision:"
        '
        'cboDrawingRevision
        '
        Me.cboDrawingRevision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDrawingRevision.Enabled = False
        Me.cboDrawingRevision.FormattingEnabled = True
        Me.cboDrawingRevision.Location = New System.Drawing.Point(1167, 51)
        Me.cboDrawingRevision.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboDrawingRevision.Name = "cboDrawingRevision"
        Me.cboDrawingRevision.Size = New System.Drawing.Size(220, 28)
        Me.cboDrawingRevision.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cboWhiteBoardNumber)
        Me.GroupBox1.Controls.Add(Me.cboNewRework)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cboDRNADCN)
        Me.GroupBox1.Controls.Add(Me.cboDrafter)
        Me.GroupBox1.Controls.Add(Me.cboSystemDescription)
        Me.GroupBox1.Controls.Add(Me.cboCompanyFlightTestRequired)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cboPSCPDocsRequired)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtFAAProjectNo)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtInstallationDrawing)
        Me.GroupBox1.Controls.Add(Me.dtpDrafterPlanned)
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
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDrawingTitle)
        Me.GroupBox1.Controls.Add(Me.cboLocation)
        Me.GroupBox1.Controls.Add(Me.cboProgram)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 65)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1718, 523)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please fill out the fields and click submit."
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(784, 459)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(542, 49)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "If a value is entered in DRN/ADCN, the New/Rework type will become Rework Drawing" &
    ""
        '
        'cboWhiteBoardNumber
        '
        Me.cboWhiteBoardNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWhiteBoardNumber.FormattingEnabled = True
        Me.cboWhiteBoardNumber.Location = New System.Drawing.Point(597, 346)
        Me.cboWhiteBoardNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboWhiteBoardNumber.Name = "cboWhiteBoardNumber"
        Me.cboWhiteBoardNumber.Size = New System.Drawing.Size(180, 28)
        Me.cboWhiteBoardNumber.TabIndex = 50
        '
        'cboNewRework
        '
        Me.cboNewRework.Enabled = False
        Me.cboNewRework.FormattingEnabled = True
        Me.cboNewRework.Location = New System.Drawing.Point(1528, 51)
        Me.cboNewRework.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboNewRework.Name = "cboNewRework"
        Me.cboNewRework.Size = New System.Drawing.Size(180, 28)
        Me.cboNewRework.TabIndex = 49
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(1414, 52)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 20)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "New/Rework:"
        '
        'cboDRNADCN
        '
        Me.cboDRNADCN.FormattingEnabled = True
        Me.cboDRNADCN.Location = New System.Drawing.Point(514, 471)
        Me.cboDRNADCN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboDRNADCN.Name = "cboDRNADCN"
        Me.cboDRNADCN.Size = New System.Drawing.Size(262, 28)
        Me.cboDRNADCN.TabIndex = 47
        '
        'cboDrafter
        '
        Me.cboDrafter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDrafter.FormattingEnabled = True
        Me.cboDrafter.Location = New System.Drawing.Point(116, 409)
        Me.cboDrafter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboDrafter.Name = "cboDrafter"
        Me.cboDrafter.Size = New System.Drawing.Size(302, 28)
        Me.cboDrafter.TabIndex = 46
        '
        'cboSystemDescription
        '
        Me.cboSystemDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSystemDescription.FormattingEnabled = True
        Me.cboSystemDescription.Location = New System.Drawing.Point(224, 237)
        Me.cboSystemDescription.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboSystemDescription.Name = "cboSystemDescription"
        Me.cboSystemDescription.Size = New System.Drawing.Size(986, 28)
        Me.cboSystemDescription.TabIndex = 45
        '
        'cboCompanyFlightTestRequired
        '
        Me.cboCompanyFlightTestRequired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompanyFlightTestRequired.FormattingEnabled = True
        Me.cboCompanyFlightTestRequired.Items.AddRange(New Object() {"Yes", "No", "Do not know"})
        Me.cboCompanyFlightTestRequired.Location = New System.Drawing.Point(1482, 185)
        Me.cboCompanyFlightTestRequired.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboCompanyFlightTestRequired.Name = "cboCompanyFlightTestRequired"
        Me.cboCompanyFlightTestRequired.Size = New System.Drawing.Size(228, 28)
        Me.cboCompanyFlightTestRequired.TabIndex = 44
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1248, 185)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(227, 20)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Company Flight Test Required:"
        '
        'cboPSCPDocsRequired
        '
        Me.cboPSCPDocsRequired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPSCPDocsRequired.FormattingEnabled = True
        Me.cboPSCPDocsRequired.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboPSCPDocsRequired.Location = New System.Drawing.Point(1316, 120)
        Me.cboPSCPDocsRequired.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboPSCPDocsRequired.Name = "cboPSCPDocsRequired"
        Me.cboPSCPDocsRequired.Size = New System.Drawing.Size(152, 28)
        Me.cboPSCPDocsRequired.TabIndex = 42
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(1142, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(165, 20)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "PSCP Docs Required:"
        '
        'txtFAAProjectNo
        '
        Me.txtFAAProjectNo.Location = New System.Drawing.Point(1044, 409)
        Me.txtFAAProjectNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFAAProjectNo.Name = "txtFAAProjectNo"
        Me.txtFAAProjectNo.Size = New System.Drawing.Size(169, 26)
        Me.txtFAAProjectNo.TabIndex = 40
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(926, 414)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 20)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "FAA Project #:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(406, 472)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 20)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "DRN/ADCN"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(406, 351)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(178, 20)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "White Board Tracking #:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(855, 294)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 20)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Installation Drawing:"
        '
        'txtInstallationDrawing
        '
        Me.txtInstallationDrawing.Location = New System.Drawing.Point(1034, 291)
        Me.txtInstallationDrawing.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInstallationDrawing.Name = "txtInstallationDrawing"
        Me.txtInstallationDrawing.Size = New System.Drawing.Size(220, 26)
        Me.txtInstallationDrawing.TabIndex = 33
        '
        'dtpDrafterPlanned
        '
        Me.dtpDrafterPlanned.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDrafterPlanned.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDrafterPlanned.Location = New System.Drawing.Point(669, 414)
        Me.dtpDrafterPlanned.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpDrafterPlanned.Name = "dtpDrafterPlanned"
        Me.dtpDrafterPlanned.Size = New System.Drawing.Size(220, 26)
        Me.dtpDrafterPlanned.TabIndex = 32
        Me.dtpDrafterPlanned.Value = New Date(2019, 4, 24, 0, 0, 0, 0)
        Me.dtpDrafterPlanned.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(429, 414)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(236, 20)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Drafter Planned Complete Date:"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(44, 414)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 20)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Drafter:"
        '
        'lblNextHigherAssembly
        '
        Me.lblNextHigherAssembly.AutoSize = True
        Me.lblNextHigherAssembly.Location = New System.Drawing.Point(424, 294)
        Me.lblNextHigherAssembly.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNextHigherAssembly.Name = "lblNextHigherAssembly"
        Me.lblNextHigherAssembly.Size = New System.Drawing.Size(168, 20)
        Me.lblNextHigherAssembly.TabIndex = 28
        Me.lblNextHigherAssembly.Text = "Next Higher Assembly:"
        '
        'txtboxNextHigherAssembly
        '
        Me.txtboxNextHigherAssembly.Location = New System.Drawing.Point(603, 291)
        Me.txtboxNextHigherAssembly.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxNextHigherAssembly.Name = "txtboxNextHigherAssembly"
        Me.txtboxNextHigherAssembly.Size = New System.Drawing.Size(220, 26)
        Me.txtboxNextHigherAssembly.TabIndex = 27
        '
        'txtEstimatedDurationHours
        '
        Me.txtEstimatedDurationHours.Location = New System.Drawing.Point(248, 472)
        Me.txtEstimatedDurationHours.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEstimatedDurationHours.Name = "txtEstimatedDurationHours"
        Me.txtEstimatedDurationHours.Size = New System.Drawing.Size(142, 26)
        Me.txtEstimatedDurationHours.TabIndex = 26
        '
        'EstimatedDuration
        '
        Me.EstimatedDuration.AutoSize = True
        Me.EstimatedDuration.Location = New System.Drawing.Point(44, 472)
        Me.EstimatedDuration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EstimatedDuration.Name = "EstimatedDuration"
        Me.EstimatedDuration.Size = New System.Drawing.Size(197, 20)
        Me.EstimatedDuration.TabIndex = 24
        Me.EstimatedDuration.Text = "Estimated Duration Hours:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 351)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Forecast Start Date"
        '
        'txtForecastStartDate
        '
        Me.txtForecastStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.txtForecastStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtForecastStartDate.Location = New System.Drawing.Point(201, 351)
        Me.txtForecastStartDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtForecastStartDate.Name = "txtForecastStartDate"
        Me.txtForecastStartDate.Size = New System.Drawing.Size(188, 26)
        Me.txtForecastStartDate.TabIndex = 21
        Me.txtForecastStartDate.Value = New Date(2019, 4, 24, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1248, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "WO #:"
        '
        'txtWONo
        '
        Me.txtWONo.Location = New System.Drawing.Point(1312, 242)
        Me.txtWONo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWONo.Name = "txtWONo"
        Me.txtWONo.Size = New System.Drawing.Size(186, 26)
        Me.txtWONo.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(945, 596)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 34)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'frmNewDWGRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1767, 634)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmNewDWGRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpDrafterPlanned As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents txtInstallationDrawing As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cboCompanyFlightTestRequired As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cboPSCPDocsRequired As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtFAAProjectNo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cboSystemDescription As ComboBox
    Friend WithEvents cboDrafter As ComboBox
    Friend WithEvents cboDRNADCN As ComboBox
    Friend WithEvents cboNewRework As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cboWhiteBoardNumber As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Button1 As Button
End Class
