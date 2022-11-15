<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEngWorkflowAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEngWorkflowAdd))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboProject = New System.Windows.Forms.ComboBox()
        Me.cboSystem = New System.Windows.Forms.ComboBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtNextHigherAssembly = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSeries = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.btnJASCCodes = New System.Windows.Forms.Button()
        Me.btnGuide = New System.Windows.Forms.Button()
        Me.lblDocTypeSelected = New System.Windows.Forms.Label()
        Me.lblSeriesSelected = New System.Windows.Forms.Label()
        Me.lblTextDocTypeSelected = New System.Windows.Forms.Label()
        Me.lblTextSeriesSelected = New System.Windows.Forms.Label()
        Me.lblDocTypeSelectedLevelTwo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboProgram = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 523)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Title *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Document Type *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 549)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Next Assembly Drawing"
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProject.Location = New System.Drawing.Point(28, 31)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(60, 20)
        Me.lblProject.TabIndex = 22
        Me.lblProject.Text = "Project *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 490)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "System *"
        '
        'cboProject
        '
        Me.cboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProject.FormattingEnabled = True
        Me.cboProject.Location = New System.Drawing.Point(190, 28)
        Me.cboProject.Name = "cboProject"
        Me.cboProject.Size = New System.Drawing.Size(460, 28)
        Me.cboProject.TabIndex = 24
        '
        'cboSystem
        '
        Me.cboSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSystem.FormattingEnabled = True
        Me.cboSystem.Location = New System.Drawing.Point(190, 487)
        Me.cboSystem.Name = "cboSystem"
        Me.cboSystem.Size = New System.Drawing.Size(357, 28)
        Me.cboSystem.TabIndex = 25
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(190, 519)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(357, 26)
        Me.txtTitle.TabIndex = 27
        '
        'txtNextHigherAssembly
        '
        Me.txtNextHigherAssembly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNextHigherAssembly.Location = New System.Drawing.Point(190, 549)
        Me.txtNextHigherAssembly.Name = "txtNextHigherAssembly"
        Me.txtNextHigherAssembly.Size = New System.Drawing.Size(272, 26)
        Me.txtNextHigherAssembly.TabIndex = 28
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(467, 549)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(80, 28)
        Me.btnBrowse.TabIndex = 29
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(672, 581)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(2)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(80, 28)
        Me.btnContinue.TabIndex = 30
        Me.btnContinue.Text = "Submit"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(570, 581)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 28)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 588)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "* denotes required field"
        '
        'lblSeries
        '
        Me.lblSeries.AutoSize = True
        Me.lblSeries.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeries.Location = New System.Drawing.Point(28, 262)
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Size = New System.Drawing.Size(57, 20)
        Me.lblSeries.TabIndex = 33
        Me.lblSeries.Text = "Series *"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(190, 62)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(357, 171)
        Me.TreeView1.TabIndex = 34
        '
        'TreeView2
        '
        Me.TreeView2.Location = New System.Drawing.Point(190, 262)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(357, 192)
        Me.TreeView2.TabIndex = 35
        '
        'btnJASCCodes
        '
        Me.btnJASCCodes.Location = New System.Drawing.Point(570, 262)
        Me.btnJASCCodes.Name = "btnJASCCodes"
        Me.btnJASCCodes.Size = New System.Drawing.Size(80, 29)
        Me.btnJASCCodes.TabIndex = 36
        Me.btnJASCCodes.Text = "JASC Codes"
        Me.btnJASCCodes.UseVisualStyleBackColor = True
        '
        'btnGuide
        '
        Me.btnGuide.Location = New System.Drawing.Point(570, 73)
        Me.btnGuide.Name = "btnGuide"
        Me.btnGuide.Size = New System.Drawing.Size(80, 29)
        Me.btnGuide.TabIndex = 37
        Me.btnGuide.Text = "Guide >"
        Me.btnGuide.UseVisualStyleBackColor = True
        '
        'lblDocTypeSelected
        '
        Me.lblDocTypeSelected.AutoSize = True
        Me.lblDocTypeSelected.BackColor = System.Drawing.Color.White
        Me.lblDocTypeSelected.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocTypeSelected.Location = New System.Drawing.Point(663, 236)
        Me.lblDocTypeSelected.Name = "lblDocTypeSelected"
        Me.lblDocTypeSelected.Size = New System.Drawing.Size(49, 20)
        Me.lblDocTypeSelected.TabIndex = 38
        Me.lblDocTypeSelected.Text = "Label2"
        '
        'lblSeriesSelected
        '
        Me.lblSeriesSelected.AutoSize = True
        Me.lblSeriesSelected.BackColor = System.Drawing.Color.White
        Me.lblSeriesSelected.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeriesSelected.Location = New System.Drawing.Point(322, 463)
        Me.lblSeriesSelected.Name = "lblSeriesSelected"
        Me.lblSeriesSelected.Size = New System.Drawing.Size(49, 20)
        Me.lblSeriesSelected.TabIndex = 39
        Me.lblSeriesSelected.Text = "Label8"
        '
        'lblTextDocTypeSelected
        '
        Me.lblTextDocTypeSelected.AutoSize = True
        Me.lblTextDocTypeSelected.BackColor = System.Drawing.Color.White
        Me.lblTextDocTypeSelected.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextDocTypeSelected.Location = New System.Drawing.Point(187, 236)
        Me.lblTextDocTypeSelected.Name = "lblTextDocTypeSelected"
        Me.lblTextDocTypeSelected.Size = New System.Drawing.Size(0, 20)
        Me.lblTextDocTypeSelected.TabIndex = 40
        '
        'lblTextSeriesSelected
        '
        Me.lblTextSeriesSelected.AutoSize = True
        Me.lblTextSeriesSelected.BackColor = System.Drawing.Color.White
        Me.lblTextSeriesSelected.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextSeriesSelected.Location = New System.Drawing.Point(190, 463)
        Me.lblTextSeriesSelected.Name = "lblTextSeriesSelected"
        Me.lblTextSeriesSelected.Size = New System.Drawing.Size(0, 20)
        Me.lblTextSeriesSelected.TabIndex = 41
        '
        'lblDocTypeSelectedLevelTwo
        '
        Me.lblDocTypeSelectedLevelTwo.AutoSize = True
        Me.lblDocTypeSelectedLevelTwo.BackColor = System.Drawing.Color.White
        Me.lblDocTypeSelectedLevelTwo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocTypeSelectedLevelTwo.Location = New System.Drawing.Point(335, 236)
        Me.lblDocTypeSelectedLevelTwo.Name = "lblDocTypeSelectedLevelTwo"
        Me.lblDocTypeSelectedLevelTwo.Size = New System.Drawing.Size(49, 20)
        Me.lblDocTypeSelectedLevelTwo.TabIndex = 42
        Me.lblDocTypeSelectedLevelTwo.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Program *"
        '
        'cboProgram
        '
        Me.cboProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProgram.FormattingEnabled = True
        Me.cboProgram.Location = New System.Drawing.Point(190, 0)
        Me.cboProgram.Name = "cboProgram"
        Me.cboProgram.Size = New System.Drawing.Size(460, 28)
        Me.cboProgram.TabIndex = 44
        '
        'frmEngWorkflowAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 610)
        Me.Controls.Add(Me.cboProgram)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDocTypeSelectedLevelTwo)
        Me.Controls.Add(Me.lblTextSeriesSelected)
        Me.Controls.Add(Me.lblTextDocTypeSelected)
        Me.Controls.Add(Me.lblSeriesSelected)
        Me.Controls.Add(Me.lblDocTypeSelected)
        Me.Controls.Add(Me.btnGuide)
        Me.Controls.Add(Me.btnJASCCodes)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.lblSeries)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtNextHigherAssembly)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.cboSystem)
        Me.Controls.Add(Me.cboProject)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblProject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEngWorkflowAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEngWorkflowAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblProject As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboProject As ComboBox
    Friend WithEvents cboSystem As ComboBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtNextHigherAssembly As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSeries As Label
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents TreeView2 As TreeView
    Friend WithEvents btnJASCCodes As Button
    Friend WithEvents btnGuide As Button
    Friend WithEvents lblDocTypeSelected As Label
    Friend WithEvents lblSeriesSelected As Label
    Friend WithEvents lblTextDocTypeSelected As Label
    Friend WithEvents lblTextSeriesSelected As Label
    Friend WithEvents lblDocTypeSelectedLevelTwo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboProgram As ComboBox
End Class
