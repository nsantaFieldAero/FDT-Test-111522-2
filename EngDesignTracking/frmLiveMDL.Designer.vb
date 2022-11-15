<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiveMDL
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiveMDL))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOpenrev = New System.Windows.Forms.Button()
        Me.btnNewRev = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCreateNewMDL = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.cboRev = New System.Windows.Forms.ComboBox()
        Me.DataSet321 = New EngDesignTracking.DataSet32()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDocumentNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeq = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRevision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        Me.txtMDLNumber = New System.Windows.Forms.TextBox()
        Me.txtRev = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.btnMDLChangeParam = New System.Windows.Forms.Button()
        Me.gbProgress = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtProgram = New System.Windows.Forms.TextBox()
        Me.txtDocumentNumber = New System.Windows.Forms.TextBox()
        CType(Me.DataSet321, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(916, 457)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REV:"
        '
        'btnOpenrev
        '
        Me.btnOpenrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenrev.Location = New System.Drawing.Point(920, 494)
        Me.btnOpenrev.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpenrev.Name = "btnOpenrev"
        Me.btnOpenrev.Size = New System.Drawing.Size(131, 44)
        Me.btnOpenrev.TabIndex = 2
        Me.btnOpenrev.Text = "Open Rev"
        Me.btnOpenrev.UseVisualStyleBackColor = True
        '
        'btnNewRev
        '
        Me.btnNewRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRev.Location = New System.Drawing.Point(781, 494)
        Me.btnNewRev.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewRev.Name = "btnNewRev"
        Me.btnNewRev.Size = New System.Drawing.Size(131, 44)
        Me.btnNewRev.TabIndex = 3
        Me.btnNewRev.Text = "New Rev"
        Me.btnNewRev.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(643, 494)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(131, 44)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCreateNewMDL
        '
        Me.btnCreateNewMDL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNewMDL.Location = New System.Drawing.Point(16, 494)
        Me.btnCreateNewMDL.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateNewMDL.Name = "btnCreateNewMDL"
        Me.btnCreateNewMDL.Size = New System.Drawing.Size(131, 44)
        Me.btnCreateNewMDL.TabIndex = 5
        Me.btnCreateNewMDL.Text = "Create New MDL"
        Me.btnCreateNewMDL.UseVisualStyleBackColor = True
        Me.btnCreateNewMDL.Visible = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        vwLiveMDLRevisions.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            vwLiveMDLRevisions"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "vwLiveMDLRevisions", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Seq", "Seq"), New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("MDLNumber", "MDLNumber"), New System.Data.Common.DataColumnMapping("Title", "Title"), New System.Data.Common.DataColumnMapping("Revision", "Revision"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("Priority", "Priority"), New System.Data.Common.DataColumnMapping("DocumentNumber", "DocumentNumber")})})
        '
        'cboRev
        '
        Me.cboRev.FormattingEnabled = True
        Me.cboRev.Location = New System.Drawing.Point(969, 453)
        Me.cboRev.Margin = New System.Windows.Forms.Padding(4)
        Me.cboRev.Name = "cboRev"
        Me.cboRev.Size = New System.Drawing.Size(80, 24)
        Me.cboRev.TabIndex = 6
        '
        'DataSet321
        '
        Me.DataSet321.DataSetName = "DataSet32"
        Me.DataSet321.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "vwLiveMDLRevisions"
        Me.BindingSource1.DataSource = Me.DataSet321
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.Location = New System.Drawing.Point(16, 14)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1035, 430)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDocumentNumber, Me.colSeq, Me.colRecordID, Me.colMDLNumber, Me.colTitle, Me.colRevision, Me.colStatus})
        Me.GridView1.DetailHeight = 430
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colDocumentNumber
        '
        Me.colDocumentNumber.Caption = "MDL #"
        Me.colDocumentNumber.FieldName = "DocumentNumber"
        Me.colDocumentNumber.MinWidth = 25
        Me.colDocumentNumber.Name = "colDocumentNumber"
        Me.colDocumentNumber.Visible = True
        Me.colDocumentNumber.VisibleIndex = 0
        Me.colDocumentNumber.Width = 94
        '
        'colSeq
        '
        Me.colSeq.FieldName = "Seq"
        Me.colSeq.MinWidth = 27
        Me.colSeq.Name = "colSeq"
        Me.colSeq.Width = 100
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.MinWidth = 27
        Me.colRecordID.Name = "colRecordID"
        Me.colRecordID.Width = 100
        '
        'colMDLNumber
        '
        Me.colMDLNumber.FieldName = "MDLNumber"
        Me.colMDLNumber.MinWidth = 27
        Me.colMDLNumber.Name = "colMDLNumber"
        Me.colMDLNumber.Width = 100
        '
        'colTitle
        '
        Me.colTitle.FieldName = "Title"
        Me.colTitle.MinWidth = 27
        Me.colTitle.Name = "colTitle"
        Me.colTitle.Visible = True
        Me.colTitle.VisibleIndex = 1
        Me.colTitle.Width = 100
        '
        'colRevision
        '
        Me.colRevision.FieldName = "Revision"
        Me.colRevision.MinWidth = 27
        Me.colRevision.Name = "colRevision"
        Me.colRevision.Visible = True
        Me.colRevision.VisibleIndex = 2
        Me.colRevision.Width = 100
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.MinWidth = 27
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 3
        Me.colStatus.Width = 100
        '
        'txtRecordID
        '
        Me.txtRecordID.Location = New System.Drawing.Point(281, 203)
        Me.txtRecordID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(132, 22)
        Me.txtRecordID.TabIndex = 8
        '
        'txtMDLNumber
        '
        Me.txtMDLNumber.Location = New System.Drawing.Point(281, 235)
        Me.txtMDLNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMDLNumber.Name = "txtMDLNumber"
        Me.txtMDLNumber.Size = New System.Drawing.Size(132, 22)
        Me.txtMDLNumber.TabIndex = 9
        '
        'txtRev
        '
        Me.txtRev.Location = New System.Drawing.Point(281, 270)
        Me.txtRev.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRev.Name = "txtRev"
        Me.txtRev.Size = New System.Drawing.Size(132, 22)
        Me.txtRev.TabIndex = 10
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(281, 302)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(132, 22)
        Me.txtStatus.TabIndex = 11
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(281, 171)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(132, 22)
        Me.txtTitle.TabIndex = 12
        '
        'btnMDLChangeParam
        '
        Me.btnMDLChangeParam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMDLChangeParam.Location = New System.Drawing.Point(462, 494)
        Me.btnMDLChangeParam.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMDLChangeParam.Name = "btnMDLChangeParam"
        Me.btnMDLChangeParam.Size = New System.Drawing.Size(172, 44)
        Me.btnMDLChangeParam.TabIndex = 13
        Me.btnMDLChangeParam.Text = "Change MDL Parameters"
        Me.btnMDLChangeParam.UseVisualStyleBackColor = True
        '
        'gbProgress
        '
        Me.gbProgress.Controls.Add(Me.ProgressBar1)
        Me.gbProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProgress.Location = New System.Drawing.Point(62, 158)
        Me.gbProgress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbProgress.Name = "gbProgress"
        Me.gbProgress.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbProgress.Size = New System.Drawing.Size(932, 188)
        Me.gbProgress.TabIndex = 14
        Me.gbProgress.TabStop = False
        Me.gbProgress.Text = "Progress"
        Me.gbProgress.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(35, 69)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(860, 58)
        Me.ProgressBar1.TabIndex = 0
        '
        'txtProgram
        '
        Me.txtProgram.Location = New System.Drawing.Point(265, 366)
        Me.txtProgram.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(132, 22)
        Me.txtProgram.TabIndex = 15
        '
        'txtDocumentNumber
        '
        Me.txtDocumentNumber.Location = New System.Drawing.Point(441, 378)
        Me.txtDocumentNumber.Name = "txtDocumentNumber"
        Me.txtDocumentNumber.Size = New System.Drawing.Size(100, 22)
        Me.txtDocumentNumber.TabIndex = 16
        '
        'frmLiveMDL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.gbProgress)
        Me.Controls.Add(Me.btnMDLChangeParam)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.cboRev)
        Me.Controls.Add(Me.btnCreateNewMDL)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNewRev)
        Me.Controls.Add(Me.btnOpenrev)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtRev)
        Me.Controls.Add(Me.txtMDLNumber)
        Me.Controls.Add(Me.txtRecordID)
        Me.Controls.Add(Me.txtProgram)
        Me.Controls.Add(Me.txtDocumentNumber)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLiveMDL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLiveMDL"
        CType(Me.DataSet321, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProgress.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOpenrev As Button
    Friend WithEvents btnNewRev As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCreateNewMDL As Button
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents cboRev As ComboBox
    Friend WithEvents DataSet321 As DataSet32
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSeq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRevision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRecordID As TextBox
    Friend WithEvents txtMDLNumber As TextBox
    Friend WithEvents txtRev As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents btnMDLChangeParam As Button
    Friend WithEvents gbProgress As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents colDocumentNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDocumentNumber As TextBox
End Class
