<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEngWorkflowAddFormB
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
        Me.btnGuide = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.cboProject = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnJASCCodes = New System.Windows.Forms.Button()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.lblSeries = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtNextHigherAssembly = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.cboSystem = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDocNumber = New System.Windows.Forms.TextBox()
        Me.lblDocNumber = New System.Windows.Forms.Label()
        Me.btnMisc = New System.Windows.Forms.Button()
        Me.btnIssueNumber = New System.Windows.Forms.Button()
        Me.cboDrafterTwo = New System.Windows.Forms.ComboBox()
        Me.cboResourceType = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblDocTypeSelected = New System.Windows.Forms.Label()
        Me.lblSeriesSelected = New System.Windows.Forms.Label()
        Me.lblDocTypeExisting = New System.Windows.Forms.Label()
        Me.lblSeriesExisting = New System.Windows.Forms.Label()
        Me.lblTextDocTypeSelected = New System.Windows.Forms.Label()
        Me.lblTextSeriesSelected = New System.Windows.Forms.Label()
        Me.cboMilestone = New System.Windows.Forms.ComboBox()
        Me.lblMilestone = New System.Windows.Forms.Label()
        Me.lblDocTypeSelectedLevelTwo = New System.Windows.Forms.Label()
        Me.lblDocNumToModify = New System.Windows.Forms.Label()
        Me.lblDocumentNum = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboProgram = New System.Windows.Forms.ComboBox()
        Me.cboDrafter = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.cboDrafter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuide
        '
        Me.btnGuide.Location = New System.Drawing.Point(554, 61)
        Me.btnGuide.Name = "btnGuide"
        Me.btnGuide.Size = New System.Drawing.Size(80, 29)
        Me.btnGuide.TabIndex = 42
        Me.btnGuide.Text = "Guide >"
        Me.btnGuide.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(174, 61)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(357, 173)
        Me.TreeView1.TabIndex = 41
        '
        'cboProject
        '
        Me.cboProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProject.FormattingEnabled = True
        Me.cboProject.Location = New System.Drawing.Point(174, 29)
        Me.cboProject.Name = "cboProject"
        Me.cboProject.Size = New System.Drawing.Size(460, 28)
        Me.cboProject.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Project *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Document Type *"
        '
        'btnJASCCodes
        '
        Me.btnJASCCodes.Location = New System.Drawing.Point(554, 263)
        Me.btnJASCCodes.Name = "btnJASCCodes"
        Me.btnJASCCodes.Size = New System.Drawing.Size(80, 29)
        Me.btnJASCCodes.TabIndex = 55
        Me.btnJASCCodes.Text = "JASC Codes"
        Me.btnJASCCodes.UseVisualStyleBackColor = True
        '
        'TreeView2
        '
        Me.TreeView2.Location = New System.Drawing.Point(174, 263)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(357, 180)
        Me.TreeView2.TabIndex = 54
        '
        'lblSeries
        '
        Me.lblSeries.AutoSize = True
        Me.lblSeries.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeries.Location = New System.Drawing.Point(12, 263)
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Size = New System.Drawing.Size(57, 20)
        Me.lblSeries.TabIndex = 53
        Me.lblSeries.Text = "Series *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 713)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "* denotes required field"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(530, 706)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 28)
        Me.btnCancel.TabIndex = 51
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(614, 706)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(2)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(80, 28)
        Me.btnContinue.TabIndex = 50
        Me.btnContinue.Text = "Sign Off"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(451, 572)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(80, 28)
        Me.btnBrowse.TabIndex = 49
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtNextHigherAssembly
        '
        Me.txtNextHigherAssembly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNextHigherAssembly.Location = New System.Drawing.Point(174, 572)
        Me.txtNextHigherAssembly.Name = "txtNextHigherAssembly"
        Me.txtNextHigherAssembly.ReadOnly = True
        Me.txtNextHigherAssembly.Size = New System.Drawing.Size(272, 26)
        Me.txtNextHigherAssembly.TabIndex = 48
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(174, 540)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(357, 26)
        Me.txtTitle.TabIndex = 47
        '
        'cboSystem
        '
        Me.cboSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSystem.FormattingEnabled = True
        Me.cboSystem.Location = New System.Drawing.Point(174, 508)
        Me.cboSystem.Name = "cboSystem"
        Me.cboSystem.Size = New System.Drawing.Size(357, 28)
        Me.cboSystem.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 508)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "System *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 572)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Next Assembly Drawing"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 540)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Title *"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 602)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Drafter *"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 634)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Resource Type *"
        '
        'txtDocNumber
        '
        Me.txtDocNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocNumber.Location = New System.Drawing.Point(174, 476)
        Me.txtDocNumber.Name = "txtDocNumber"
        Me.txtDocNumber.Size = New System.Drawing.Size(357, 26)
        Me.txtDocNumber.TabIndex = 60
        '
        'lblDocNumber
        '
        Me.lblDocNumber.AutoSize = True
        Me.lblDocNumber.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocNumber.Location = New System.Drawing.Point(12, 476)
        Me.lblDocNumber.Name = "lblDocNumber"
        Me.lblDocNumber.Size = New System.Drawing.Size(84, 20)
        Me.lblDocNumber.TabIndex = 61
        Me.lblDocNumber.Text = "Doc Number"
        '
        'btnMisc
        '
        Me.btnMisc.Location = New System.Drawing.Point(554, 474)
        Me.btnMisc.Name = "btnMisc"
        Me.btnMisc.Size = New System.Drawing.Size(80, 30)
        Me.btnMisc.TabIndex = 62
        Me.btnMisc.Text = "Misc"
        Me.btnMisc.UseVisualStyleBackColor = True
        '
        'btnIssueNumber
        '
        Me.btnIssueNumber.Location = New System.Drawing.Point(554, 413)
        Me.btnIssueNumber.Name = "btnIssueNumber"
        Me.btnIssueNumber.Size = New System.Drawing.Size(80, 30)
        Me.btnIssueNumber.TabIndex = 63
        Me.btnIssueNumber.Text = "Issue Number"
        Me.btnIssueNumber.UseVisualStyleBackColor = True
        '
        'cboDrafterTwo
        '
        Me.cboDrafterTwo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDrafterTwo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDrafterTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDrafterTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDrafterTwo.FormattingEnabled = True
        Me.cboDrafterTwo.Location = New System.Drawing.Point(578, 602)
        Me.cboDrafterTwo.Name = "cboDrafterTwo"
        Me.cboDrafterTwo.Size = New System.Drawing.Size(357, 28)
        Me.cboDrafterTwo.TabIndex = 64
        Me.cboDrafterTwo.Visible = False
        '
        'cboResourceType
        '
        Me.cboResourceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboResourceType.FormattingEnabled = True
        Me.cboResourceType.Location = New System.Drawing.Point(174, 636)
        Me.cboResourceType.Name = "cboResourceType"
        Me.cboResourceType.Size = New System.Drawing.Size(357, 28)
        Me.cboResourceType.TabIndex = 65
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(782, 706)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 26)
        Me.btnDelete.TabIndex = 66
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblDocTypeSelected
        '
        Me.lblDocTypeSelected.AutoSize = True
        Me.lblDocTypeSelected.BackColor = System.Drawing.Color.White
        Me.lblDocTypeSelected.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocTypeSelected.Location = New System.Drawing.Point(644, 240)
        Me.lblDocTypeSelected.Name = "lblDocTypeSelected"
        Me.lblDocTypeSelected.Size = New System.Drawing.Size(49, 20)
        Me.lblDocTypeSelected.TabIndex = 67
        Me.lblDocTypeSelected.Text = "Label9"
        '
        'lblSeriesSelected
        '
        Me.lblSeriesSelected.AutoSize = True
        Me.lblSeriesSelected.BackColor = System.Drawing.Color.White
        Me.lblSeriesSelected.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeriesSelected.Location = New System.Drawing.Point(303, 451)
        Me.lblSeriesSelected.Name = "lblSeriesSelected"
        Me.lblSeriesSelected.Size = New System.Drawing.Size(56, 20)
        Me.lblSeriesSelected.TabIndex = 68
        Me.lblSeriesSelected.Text = "Label10"
        '
        'lblDocTypeExisting
        '
        Me.lblDocTypeExisting.AutoSize = True
        Me.lblDocTypeExisting.BackColor = System.Drawing.Color.White
        Me.lblDocTypeExisting.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocTypeExisting.Location = New System.Drawing.Point(561, 146)
        Me.lblDocTypeExisting.Name = "lblDocTypeExisting"
        Me.lblDocTypeExisting.Size = New System.Drawing.Size(0, 20)
        Me.lblDocTypeExisting.TabIndex = 69
        '
        'lblSeriesExisting
        '
        Me.lblSeriesExisting.AutoSize = True
        Me.lblSeriesExisting.BackColor = System.Drawing.Color.White
        Me.lblSeriesExisting.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeriesExisting.Location = New System.Drawing.Point(561, 349)
        Me.lblSeriesExisting.Name = "lblSeriesExisting"
        Me.lblSeriesExisting.Size = New System.Drawing.Size(0, 20)
        Me.lblSeriesExisting.TabIndex = 70
        '
        'lblTextDocTypeSelected
        '
        Me.lblTextDocTypeSelected.AutoSize = True
        Me.lblTextDocTypeSelected.BackColor = System.Drawing.Color.White
        Me.lblTextDocTypeSelected.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextDocTypeSelected.Location = New System.Drawing.Point(174, 240)
        Me.lblTextDocTypeSelected.Name = "lblTextDocTypeSelected"
        Me.lblTextDocTypeSelected.Size = New System.Drawing.Size(49, 20)
        Me.lblTextDocTypeSelected.TabIndex = 71
        Me.lblTextDocTypeSelected.Text = "Label9"
        '
        'lblTextSeriesSelected
        '
        Me.lblTextSeriesSelected.AutoSize = True
        Me.lblTextSeriesSelected.BackColor = System.Drawing.Color.White
        Me.lblTextSeriesSelected.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextSeriesSelected.Location = New System.Drawing.Point(174, 451)
        Me.lblTextSeriesSelected.Name = "lblTextSeriesSelected"
        Me.lblTextSeriesSelected.Size = New System.Drawing.Size(56, 20)
        Me.lblTextSeriesSelected.TabIndex = 72
        Me.lblTextSeriesSelected.Text = "Label10"
        '
        'cboMilestone
        '
        Me.cboMilestone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMilestone.FormattingEnabled = True
        Me.cboMilestone.Location = New System.Drawing.Point(174, 670)
        Me.cboMilestone.Name = "cboMilestone"
        Me.cboMilestone.Size = New System.Drawing.Size(357, 28)
        Me.cboMilestone.TabIndex = 73
        '
        'lblMilestone
        '
        Me.lblMilestone.AutoSize = True
        Me.lblMilestone.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilestone.Location = New System.Drawing.Point(14, 673)
        Me.lblMilestone.Name = "lblMilestone"
        Me.lblMilestone.Size = New System.Drawing.Size(67, 20)
        Me.lblMilestone.TabIndex = 74
        Me.lblMilestone.Text = "Milestone"
        '
        'lblDocTypeSelectedLevelTwo
        '
        Me.lblDocTypeSelectedLevelTwo.AutoSize = True
        Me.lblDocTypeSelectedLevelTwo.BackColor = System.Drawing.Color.White
        Me.lblDocTypeSelectedLevelTwo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocTypeSelectedLevelTwo.Location = New System.Drawing.Point(320, 240)
        Me.lblDocTypeSelectedLevelTwo.Name = "lblDocTypeSelectedLevelTwo"
        Me.lblDocTypeSelectedLevelTwo.Size = New System.Drawing.Size(49, 20)
        Me.lblDocTypeSelectedLevelTwo.TabIndex = 75
        Me.lblDocTypeSelectedLevelTwo.Text = "Label3"
        '
        'lblDocNumToModify
        '
        Me.lblDocNumToModify.AutoSize = True
        Me.lblDocNumToModify.BackColor = System.Drawing.Color.White
        Me.lblDocNumToModify.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocNumToModify.Location = New System.Drawing.Point(666, 6)
        Me.lblDocNumToModify.Name = "lblDocNumToModify"
        Me.lblDocNumToModify.Size = New System.Drawing.Size(91, 20)
        Me.lblDocNumToModify.TabIndex = 76
        Me.lblDocNumToModify.Text = "Document #: "
        '
        'lblDocumentNum
        '
        Me.lblDocumentNum.AutoSize = True
        Me.lblDocumentNum.BackColor = System.Drawing.Color.White
        Me.lblDocumentNum.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentNum.Location = New System.Drawing.Point(764, 6)
        Me.lblDocumentNum.Name = "lblDocumentNum"
        Me.lblDocumentNum.Size = New System.Drawing.Size(0, 20)
        Me.lblDocumentNum.TabIndex = 77
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 20)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Program *"
        '
        'cboProgram
        '
        Me.cboProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProgram.FormattingEnabled = True
        Me.cboProgram.Location = New System.Drawing.Point(174, 1)
        Me.cboProgram.Name = "cboProgram"
        Me.cboProgram.Size = New System.Drawing.Size(460, 28)
        Me.cboProgram.TabIndex = 79
        '
        'cboDrafter
        '
        Me.cboDrafter.Location = New System.Drawing.Point(174, 610)
        Me.cboDrafter.Name = "cboDrafter"
        Me.cboDrafter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDrafter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDrafter.Size = New System.Drawing.Size(357, 20)
        Me.cboDrafter.TabIndex = 80
        '
        'frmEngWorkflowAddFormB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 736)
        Me.Controls.Add(Me.cboDrafter)
        Me.Controls.Add(Me.cboProgram)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblDocumentNum)
        Me.Controls.Add(Me.lblDocNumToModify)
        Me.Controls.Add(Me.lblDocTypeSelectedLevelTwo)
        Me.Controls.Add(Me.lblMilestone)
        Me.Controls.Add(Me.cboMilestone)
        Me.Controls.Add(Me.lblTextSeriesSelected)
        Me.Controls.Add(Me.lblTextDocTypeSelected)
        Me.Controls.Add(Me.lblSeriesExisting)
        Me.Controls.Add(Me.lblDocTypeExisting)
        Me.Controls.Add(Me.lblSeriesSelected)
        Me.Controls.Add(Me.lblDocTypeSelected)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cboResourceType)
        Me.Controls.Add(Me.cboDrafterTwo)
        Me.Controls.Add(Me.btnIssueNumber)
        Me.Controls.Add(Me.btnMisc)
        Me.Controls.Add(Me.lblDocNumber)
        Me.Controls.Add(Me.txtDocNumber)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnJASCCodes)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.lblSeries)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtNextHigherAssembly)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.cboSystem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuide)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.cboProject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmEngWorkflowAddFormB"
        Me.Text = "frmEngWorkflowAddFormB"
        CType(Me.cboDrafter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuide As Button
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents cboProject As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnJASCCodes As Button
    Friend WithEvents TreeView2 As TreeView
    Friend WithEvents lblSeries As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtNextHigherAssembly As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents cboSystem As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDocNumber As TextBox
    Friend WithEvents lblDocNumber As Label
    Friend WithEvents btnMisc As Button
    Friend WithEvents btnIssueNumber As Button
    Friend WithEvents cboDrafterTwo As ComboBox
    Friend WithEvents cboResourceType As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblDocTypeSelected As Label
    Friend WithEvents lblSeriesSelected As Label
    Friend WithEvents lblDocTypeExisting As Label
    Friend WithEvents lblSeriesExisting As Label
    Friend WithEvents lblTextDocTypeSelected As Label
    Friend WithEvents lblTextSeriesSelected As Label
    Friend WithEvents cboMilestone As ComboBox
    Friend WithEvents lblMilestone As Label
    Friend WithEvents lblDocTypeSelectedLevelTwo As Label
    Friend WithEvents lblDocNumToModify As Label
    Friend WithEvents lblDocumentNum As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboProgram As ComboBox
    Friend WithEvents cboDrafter As DevExpress.XtraEditors.ComboBoxEdit
End Class
