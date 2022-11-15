<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDLExceptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDLExceptions))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet391 = New EngDesignTracking.DataSet39()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRevision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastRefresh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLVL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRevision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualFinishDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLVLDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTopLVL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTopLVLDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLVLLVLDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCancelled = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeferToNextMDL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShowPreviousRev = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOverrideDRNDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShowRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarksText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOverrideDRNText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShowPreviousRevText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMDLNumber = New System.Windows.Forms.TextBox()
        Me.txtMDLRevision = New System.Windows.Forms.TextBox()
        Me.btnExportGrid = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet391, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1186, 89)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The following documents have created an exception requiring action.  The exceptio" &
    "n is that the document is not at Gate 6 or has not been cancelled or deffered."
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridControl1.Location = New System.Drawing.Point(24, 188)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1218, 902)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "vwMDLExceptions"
        Me.BindingSource1.DataSource = Me.DataSet391
        '
        'DataSet391
        '
        Me.DataSet391.DataSetName = "DataSet39"
        Me.DataSet391.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colMDLRecordID, Me.colMDLNumber, Me.colTitle, Me.colRevision, Me.colStatus, Me.colLastRefresh, Me.colLVL, Me.colDrawingNumber, Me.colDwgRevision, Me.colActualFinishDate, Me.colDrawingTitle, Me.colStatus1, Me.colNotes, Me.colDrawingType, Me.colLVLDesc, Me.colTopLVL, Me.colTopLVLDesc, Me.colLVLLVLDesc, Me.colCancelled, Me.colDeferToNextMDL, Me.colShowPreviousRev, Me.colOverrideDRNDetails, Me.colShowRemarks, Me.colRemarksText, Me.colOverrideDRNText, Me.colShowPreviousRevText})
        Me.GridView1.DetailHeight = 538
        Me.GridView1.FixedLineWidth = 3
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.MinWidth = 30
        Me.colRecordID.Name = "colRecordID"
        Me.colRecordID.Width = 112
        '
        'colMDLRecordID
        '
        Me.colMDLRecordID.FieldName = "MDLRecordID"
        Me.colMDLRecordID.MinWidth = 30
        Me.colMDLRecordID.Name = "colMDLRecordID"
        Me.colMDLRecordID.Width = 112
        '
        'colMDLNumber
        '
        Me.colMDLNumber.FieldName = "MDLNumber"
        Me.colMDLNumber.MinWidth = 30
        Me.colMDLNumber.Name = "colMDLNumber"
        Me.colMDLNumber.Width = 112
        '
        'colTitle
        '
        Me.colTitle.FieldName = "Title"
        Me.colTitle.MinWidth = 30
        Me.colTitle.Name = "colTitle"
        Me.colTitle.Width = 112
        '
        'colRevision
        '
        Me.colRevision.FieldName = "Revision"
        Me.colRevision.MinWidth = 30
        Me.colRevision.Name = "colRevision"
        Me.colRevision.Width = 112
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.MinWidth = 30
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 112
        '
        'colLastRefresh
        '
        Me.colLastRefresh.FieldName = "LastRefresh"
        Me.colLastRefresh.MinWidth = 30
        Me.colLastRefresh.Name = "colLastRefresh"
        Me.colLastRefresh.Width = 112
        '
        'colLVL
        '
        Me.colLVL.FieldName = "LVL"
        Me.colLVL.MinWidth = 30
        Me.colLVL.Name = "colLVL"
        Me.colLVL.Width = 112
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
        'colDwgRevision
        '
        Me.colDwgRevision.FieldName = "DwgRevision"
        Me.colDwgRevision.MinWidth = 30
        Me.colDwgRevision.Name = "colDwgRevision"
        Me.colDwgRevision.Visible = True
        Me.colDwgRevision.VisibleIndex = 1
        Me.colDwgRevision.Width = 112
        '
        'colActualFinishDate
        '
        Me.colActualFinishDate.FieldName = "ActualFinishDate"
        Me.colActualFinishDate.MinWidth = 30
        Me.colActualFinishDate.Name = "colActualFinishDate"
        Me.colActualFinishDate.Width = 112
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
        'colStatus1
        '
        Me.colStatus1.FieldName = "Status1"
        Me.colStatus1.MinWidth = 30
        Me.colStatus1.Name = "colStatus1"
        Me.colStatus1.Visible = True
        Me.colStatus1.VisibleIndex = 3
        Me.colStatus1.Width = 112
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.MinWidth = 30
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Width = 112
        '
        'colDrawingType
        '
        Me.colDrawingType.FieldName = "DrawingType"
        Me.colDrawingType.MinWidth = 30
        Me.colDrawingType.Name = "colDrawingType"
        Me.colDrawingType.Visible = True
        Me.colDrawingType.VisibleIndex = 4
        Me.colDrawingType.Width = 112
        '
        'colLVLDesc
        '
        Me.colLVLDesc.FieldName = "LVLDesc"
        Me.colLVLDesc.MinWidth = 30
        Me.colLVLDesc.Name = "colLVLDesc"
        Me.colLVLDesc.Width = 112
        '
        'colTopLVL
        '
        Me.colTopLVL.FieldName = "TopLVL"
        Me.colTopLVL.MinWidth = 30
        Me.colTopLVL.Name = "colTopLVL"
        Me.colTopLVL.Width = 112
        '
        'colTopLVLDesc
        '
        Me.colTopLVLDesc.FieldName = "TopLVLDesc"
        Me.colTopLVLDesc.MinWidth = 30
        Me.colTopLVLDesc.Name = "colTopLVLDesc"
        Me.colTopLVLDesc.Width = 112
        '
        'colLVLLVLDesc
        '
        Me.colLVLLVLDesc.FieldName = "LVLLVLDesc"
        Me.colLVLLVLDesc.MinWidth = 30
        Me.colLVLLVLDesc.Name = "colLVLLVLDesc"
        Me.colLVLLVLDesc.Width = 112
        '
        'colCancelled
        '
        Me.colCancelled.FieldName = "Cancelled"
        Me.colCancelled.MinWidth = 30
        Me.colCancelled.Name = "colCancelled"
        Me.colCancelled.Width = 112
        '
        'colDeferToNextMDL
        '
        Me.colDeferToNextMDL.FieldName = "DeferToNextMDL"
        Me.colDeferToNextMDL.MinWidth = 30
        Me.colDeferToNextMDL.Name = "colDeferToNextMDL"
        Me.colDeferToNextMDL.Width = 112
        '
        'colShowPreviousRev
        '
        Me.colShowPreviousRev.FieldName = "ShowPreviousRev"
        Me.colShowPreviousRev.MinWidth = 30
        Me.colShowPreviousRev.Name = "colShowPreviousRev"
        Me.colShowPreviousRev.Width = 112
        '
        'colOverrideDRNDetails
        '
        Me.colOverrideDRNDetails.FieldName = "OverrideDRNDetails"
        Me.colOverrideDRNDetails.MinWidth = 30
        Me.colOverrideDRNDetails.Name = "colOverrideDRNDetails"
        Me.colOverrideDRNDetails.Width = 112
        '
        'colShowRemarks
        '
        Me.colShowRemarks.FieldName = "ShowRemarks"
        Me.colShowRemarks.MinWidth = 30
        Me.colShowRemarks.Name = "colShowRemarks"
        Me.colShowRemarks.Width = 112
        '
        'colRemarksText
        '
        Me.colRemarksText.FieldName = "RemarksText"
        Me.colRemarksText.MinWidth = 30
        Me.colRemarksText.Name = "colRemarksText"
        Me.colRemarksText.Width = 112
        '
        'colOverrideDRNText
        '
        Me.colOverrideDRNText.FieldName = "OverrideDRNText"
        Me.colOverrideDRNText.MinWidth = 30
        Me.colOverrideDRNText.Name = "colOverrideDRNText"
        Me.colOverrideDRNText.Width = 112
        '
        'colShowPreviousRevText
        '
        Me.colShowPreviousRevText.FieldName = "ShowPreviousRevText"
        Me.colShowPreviousRevText.MinWidth = 30
        Me.colShowPreviousRevText.Name = "colShowPreviousRevText"
        Me.colShowPreviousRevText.Width = 112
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        vwMDLExceptions.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            vwMDLExceptions"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "vwMDLExceptions", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("MDLRecordID", "MDLRecordID"), New System.Data.Common.DataColumnMapping("MDLNumber", "MDLNumber"), New System.Data.Common.DataColumnMapping("Title", "Title"), New System.Data.Common.DataColumnMapping("Revision", "Revision"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("LastRefresh", "LastRefresh"), New System.Data.Common.DataColumnMapping("LVL", "LVL"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("ActualFinishDate", "ActualFinishDate"), New System.Data.Common.DataColumnMapping("DrawingTitle", "DrawingTitle"), New System.Data.Common.DataColumnMapping("Status1", "Status1"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("DrawingType", "DrawingType"), New System.Data.Common.DataColumnMapping("LVLDesc", "LVLDesc"), New System.Data.Common.DataColumnMapping("TopLVL", "TopLVL"), New System.Data.Common.DataColumnMapping("TopLVLDesc", "TopLVLDesc"), New System.Data.Common.DataColumnMapping("LVLLVLDesc", "LVLLVLDesc"), New System.Data.Common.DataColumnMapping("Cancelled", "Cancelled"), New System.Data.Common.DataColumnMapping("DeferToNextMDL", "DeferToNextMDL"), New System.Data.Common.DataColumnMapping("ShowPreviousRev", "ShowPreviousRev"), New System.Data.Common.DataColumnMapping("OverrideDRNDetails", "OverrideDRNDetails"), New System.Data.Common.DataColumnMapping("ShowRemarks", "ShowRemarks"), New System.Data.Common.DataColumnMapping("RemarksText", "RemarksText"), New System.Data.Common.DataColumnMapping("OverrideDRNText", "OverrideDRNText"), New System.Data.Common.DataColumnMapping("ShowPreviousRevText", "ShowPreviousRevText")})})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MDL Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(332, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "MDL Revision:"
        '
        'txtMDLNumber
        '
        Me.txtMDLNumber.Location = New System.Drawing.Point(138, 46)
        Me.txtMDLNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMDLNumber.Name = "txtMDLNumber"
        Me.txtMDLNumber.Size = New System.Drawing.Size(148, 26)
        Me.txtMDLNumber.TabIndex = 4
        '
        'txtMDLRevision
        '
        Me.txtMDLRevision.Location = New System.Drawing.Point(472, 46)
        Me.txtMDLRevision.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMDLRevision.Name = "txtMDLRevision"
        Me.txtMDLRevision.Size = New System.Drawing.Size(148, 26)
        Me.txtMDLRevision.TabIndex = 5
        '
        'btnExportGrid
        '
        Me.btnExportGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportGrid.Image = CType(resources.GetObject("btnExportGrid.Image"), System.Drawing.Image)
        Me.btnExportGrid.Location = New System.Drawing.Point(838, 132)
        Me.btnExportGrid.Name = "btnExportGrid"
        Me.btnExportGrid.Size = New System.Drawing.Size(224, 48)
        Me.btnExportGrid.TabIndex = 14
        Me.btnExportGrid.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1068, 132)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(174, 48)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMDLExceptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 1108)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnExportGrid)
        Me.Controls.Add(Me.txtMDLRevision)
        Me.Controls.Add(Me.txtMDLNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMDLExceptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMDLExceptions"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet391, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet391 As DataSet39
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRevision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastRefresh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLVL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRevision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualFinishDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLVLDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTopLVL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTopLVLDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLVLLVLDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCancelled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeferToNextMDL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShowPreviousRev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOverrideDRNDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShowRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarksText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOverrideDRNText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShowPreviousRevText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMDLNumber As TextBox
    Friend WithEvents txtMDLRevision As TextBox
    Friend WithEvents btnExportGrid As Button
    Friend WithEvents btnClose As Button
End Class
