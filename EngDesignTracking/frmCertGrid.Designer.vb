<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCertGrid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCertGrid))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.btnExportGrid = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.cboView = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.DataSet291 = New EngDesignTracking.DataSet29()
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDrawingNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUMName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUMSpecialty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUMRecommendApproval = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUMApproval = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequiredToApprove = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRevision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADCN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDRNADCN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeq = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataSet291, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'btnExportGrid
        '
        Me.btnExportGrid.Location = New System.Drawing.Point(1403, 12)
        Me.btnExportGrid.Name = "btnExportGrid"
        Me.btnExportGrid.Size = New System.Drawing.Size(170, 30)
        Me.btnExportGrid.TabIndex = 8
        Me.btnExportGrid.Text = "Export Grid"
        Me.btnExportGrid.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "vwDrawingsCert", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("DrawingTitle", "DrawingTitle"), New System.Data.Common.DataColumnMapping("SystemDescription", "SystemDescription"), New System.Data.Common.DataColumnMapping("UMName", "UMName"), New System.Data.Common.DataColumnMapping("UMSpecialty", "UMSpecialty"), New System.Data.Common.DataColumnMapping("UMRecommendApproval", "UMRecommendApproval"), New System.Data.Common.DataColumnMapping("UMApproval", "UMApproval"), New System.Data.Common.DataColumnMapping("RequiredToApprove", "RequiredToApprove"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("Priority", "Priority"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("ADCN", "ADCN"), New System.Data.Common.DataColumnMapping("DRNADCN", "DRNADCN"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("Seq", "Seq")})})
        '
        'cboView
        '
        Me.cboView.FormattingEnabled = True
        Me.cboView.Items.AddRange(New Object() {"In Design", "In Design and Completed", "Current Revision"})
        Me.cboView.Location = New System.Drawing.Point(888, 12)
        Me.cboView.Name = "cboView"
        Me.cboView.Size = New System.Drawing.Size(276, 28)
        Me.cboView.TabIndex = 10
        Me.cboView.Text = "Current Revision"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(1217, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(170, 30)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'DataSet291
        '
        Me.DataSet291.DataSetName = "DataSet29"
        Me.DataSet291.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "vwDrawingsCert"
        Me.BindingSource3.DataSource = Me.DataSet291
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource3
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EnabledAutoRepeat = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(2151, 1225)
        Me.GridControl1.TabIndex = 12
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDrawingNumber, Me.colProgram, Me.colDrawingTitle, Me.colSystemDescription, Me.colUMName, Me.colUMSpecialty, Me.colUMRecommendApproval, Me.colUMApproval, Me.colRequiredToApprove, Me.colComments, Me.colPriority, Me.colDwgRevision, Me.colADCN, Me.colDRNADCN, Me.colStatus, Me.colSeq})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colDrawingNumber
        '
        Me.colDrawingNumber.FieldName = "DrawingNumber"
        Me.colDrawingNumber.MinWidth = 30
        Me.colDrawingNumber.Name = "colDrawingNumber"
        Me.colDrawingNumber.Visible = True
        Me.colDrawingNumber.VisibleIndex = 0
        Me.colDrawingNumber.Width = 112
        '
        'colProgram
        '
        Me.colProgram.FieldName = "Program"
        Me.colProgram.MinWidth = 30
        Me.colProgram.Name = "colProgram"
        Me.colProgram.Visible = True
        Me.colProgram.VisibleIndex = 1
        Me.colProgram.Width = 112
        '
        'colDrawingTitle
        '
        Me.colDrawingTitle.FieldName = "DrawingTitle"
        Me.colDrawingTitle.MinWidth = 30
        Me.colDrawingTitle.Name = "colDrawingTitle"
        Me.colDrawingTitle.Visible = True
        Me.colDrawingTitle.VisibleIndex = 2
        Me.colDrawingTitle.Width = 112
        '
        'colSystemDescription
        '
        Me.colSystemDescription.FieldName = "SystemDescription"
        Me.colSystemDescription.MinWidth = 30
        Me.colSystemDescription.Name = "colSystemDescription"
        Me.colSystemDescription.Visible = True
        Me.colSystemDescription.VisibleIndex = 3
        Me.colSystemDescription.Width = 112
        '
        'colUMName
        '
        Me.colUMName.FieldName = "UMName"
        Me.colUMName.MinWidth = 30
        Me.colUMName.Name = "colUMName"
        Me.colUMName.Visible = True
        Me.colUMName.VisibleIndex = 4
        Me.colUMName.Width = 112
        '
        'colUMSpecialty
        '
        Me.colUMSpecialty.FieldName = "UMSpecialty"
        Me.colUMSpecialty.MinWidth = 30
        Me.colUMSpecialty.Name = "colUMSpecialty"
        Me.colUMSpecialty.Visible = True
        Me.colUMSpecialty.VisibleIndex = 5
        Me.colUMSpecialty.Width = 112
        '
        'colUMRecommendApproval
        '
        Me.colUMRecommendApproval.FieldName = "UMRecommendApproval"
        Me.colUMRecommendApproval.MinWidth = 30
        Me.colUMRecommendApproval.Name = "colUMRecommendApproval"
        Me.colUMRecommendApproval.Visible = True
        Me.colUMRecommendApproval.VisibleIndex = 6
        Me.colUMRecommendApproval.Width = 112
        '
        'colUMApproval
        '
        Me.colUMApproval.FieldName = "UMApproval"
        Me.colUMApproval.MinWidth = 30
        Me.colUMApproval.Name = "colUMApproval"
        Me.colUMApproval.Visible = True
        Me.colUMApproval.VisibleIndex = 7
        Me.colUMApproval.Width = 112
        '
        'colRequiredToApprove
        '
        Me.colRequiredToApprove.FieldName = "RequiredToApprove"
        Me.colRequiredToApprove.MinWidth = 30
        Me.colRequiredToApprove.Name = "colRequiredToApprove"
        Me.colRequiredToApprove.Visible = True
        Me.colRequiredToApprove.VisibleIndex = 8
        Me.colRequiredToApprove.Width = 112
        '
        'colComments
        '
        Me.colComments.FieldName = "Comments"
        Me.colComments.MinWidth = 30
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 9
        Me.colComments.Width = 112
        '
        'colPriority
        '
        Me.colPriority.FieldName = "Priority"
        Me.colPriority.MinWidth = 30
        Me.colPriority.Name = "colPriority"
        Me.colPriority.Visible = True
        Me.colPriority.VisibleIndex = 10
        Me.colPriority.Width = 112
        '
        'colDwgRevision
        '
        Me.colDwgRevision.FieldName = "DwgRevision"
        Me.colDwgRevision.MinWidth = 30
        Me.colDwgRevision.Name = "colDwgRevision"
        Me.colDwgRevision.Visible = True
        Me.colDwgRevision.VisibleIndex = 11
        Me.colDwgRevision.Width = 112
        '
        'colADCN
        '
        Me.colADCN.FieldName = "ADCN"
        Me.colADCN.MinWidth = 30
        Me.colADCN.Name = "colADCN"
        Me.colADCN.Visible = True
        Me.colADCN.VisibleIndex = 12
        Me.colADCN.Width = 112
        '
        'colDRNADCN
        '
        Me.colDRNADCN.FieldName = "DRNADCN"
        Me.colDRNADCN.MinWidth = 30
        Me.colDRNADCN.Name = "colDRNADCN"
        Me.colDRNADCN.Visible = True
        Me.colDRNADCN.VisibleIndex = 13
        Me.colDRNADCN.Width = 112
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.MinWidth = 30
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 14
        Me.colStatus.Width = 112
        '
        'colSeq
        '
        Me.colSeq.FieldName = "Seq"
        Me.colSeq.MinWidth = 30
        Me.colSeq.Name = "colSeq"
        Me.colSeq.Visible = True
        Me.colSeq.VisibleIndex = 15
        Me.colSeq.Width = 112
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(822, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "View:"
        '
        'frmCertGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2151, 1225)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExportGrid)
        Me.Controls.Add(Me.cboView)
        Me.Controls.Add(Me.GridControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCertGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCertGrid"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSet291, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents btnExportGrid As Button
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As SqlClient.SqlDataAdapter
    Friend WithEvents cboView As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DataSet291 As DataSet29
    Friend WithEvents BindingSource3 As BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDrawingNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMSpecialty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMRecommendApproval As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMApproval As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequiredToApprove As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRevision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADCN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDRNADCN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
End Class
