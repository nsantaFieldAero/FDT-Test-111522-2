<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEngWorkflowLevelThreeDocType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEngWorkflowLevelThreeDocType))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsLevelThree = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsLevelThree1 = New EngDesignTracking.dsLevelThree()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrefix = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNextPrefix = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTrailing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFirstPrefix = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreviousPrefix = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastPrefix = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingOrReport = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLevelThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLevelThree1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsLevelThree
        Me.GridControl1.Location = New System.Drawing.Point(13, 13)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1089, 612)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsLevelThree
        '
        Me.bsLevelThree.DataMember = "tblDocTypePrefixLevelThree"
        Me.bsLevelThree.DataSource = Me.DsLevelThree1
        '
        'DsLevelThree1
        '
        Me.DsLevelThree1.DataSetName = "dsLevelThree"
        Me.DsLevelThree1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colDocumentType, Me.colPrefix, Me.colNextPrefix, Me.colTrailing, Me.colFirstPrefix, Me.colPreviousPrefix, Me.colLastPrefix, Me.colDrawingOrReport, Me.colActive})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.Name = "colRecordID"
        '
        'colDocumentType
        '
        Me.colDocumentType.FieldName = "DocumentType"
        Me.colDocumentType.Name = "colDocumentType"
        Me.colDocumentType.Visible = True
        Me.colDocumentType.VisibleIndex = 0
        Me.colDocumentType.Width = 515
        '
        'colPrefix
        '
        Me.colPrefix.FieldName = "Prefix"
        Me.colPrefix.Name = "colPrefix"
        Me.colPrefix.Visible = True
        Me.colPrefix.VisibleIndex = 1
        Me.colPrefix.Width = 62
        '
        'colNextPrefix
        '
        Me.colNextPrefix.FieldName = "NextPrefix"
        Me.colNextPrefix.Name = "colNextPrefix"
        Me.colNextPrefix.Visible = True
        Me.colNextPrefix.VisibleIndex = 3
        Me.colNextPrefix.Width = 71
        '
        'colTrailing
        '
        Me.colTrailing.FieldName = "Trailing"
        Me.colTrailing.Name = "colTrailing"
        Me.colTrailing.Visible = True
        Me.colTrailing.VisibleIndex = 5
        Me.colTrailing.Width = 58
        '
        'colFirstPrefix
        '
        Me.colFirstPrefix.FieldName = "FirstPrefix"
        Me.colFirstPrefix.Name = "colFirstPrefix"
        '
        'colPreviousPrefix
        '
        Me.colPreviousPrefix.FieldName = "PreviousPrefix"
        Me.colPreviousPrefix.Name = "colPreviousPrefix"
        Me.colPreviousPrefix.Visible = True
        Me.colPreviousPrefix.VisibleIndex = 4
        Me.colPreviousPrefix.Width = 88
        '
        'colLastPrefix
        '
        Me.colLastPrefix.FieldName = "LastPrefix"
        Me.colLastPrefix.Name = "colLastPrefix"
        Me.colLastPrefix.Visible = True
        Me.colLastPrefix.VisibleIndex = 2
        Me.colLastPrefix.Width = 68
        '
        'colDrawingOrReport
        '
        Me.colDrawingOrReport.Caption = "Classification"
        Me.colDrawingOrReport.FieldName = "DrawingOrReport"
        Me.colDrawingOrReport.Name = "colDrawingOrReport"
        Me.colDrawingOrReport.Visible = True
        Me.colDrawingOrReport.VisibleIndex = 6
        Me.colDrawingOrReport.Width = 148
        '
        'colActive
        '
        Me.colActive.FieldName = "Active"
        Me.colActive.Name = "colActive"
        Me.colActive.Visible = True
        Me.colActive.VisibleIndex = 7
        Me.colActive.Width = 61
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(260, 631)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 35)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(409, 631)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(119, 35)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete Current"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        RecordID, DocumentType, Prefix, NextPrefix, Trailing, FirstPrefix, " &
    "PreviousPrefix, LastPrefix, DrawingOrReport, Active" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblDocTypeP" &
    "refixLevelThree"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DocumentType", System.Data.SqlDbType.NVarChar, 0, "DocumentType"), New System.Data.SqlClient.SqlParameter("@Prefix", System.Data.SqlDbType.NVarChar, 0, "Prefix"), New System.Data.SqlClient.SqlParameter("@NextPrefix", System.Data.SqlDbType.NVarChar, 0, "NextPrefix"), New System.Data.SqlClient.SqlParameter("@Trailing", System.Data.SqlDbType.Int, 0, "Trailing"), New System.Data.SqlClient.SqlParameter("@FirstPrefix", System.Data.SqlDbType.NVarChar, 0, "FirstPrefix"), New System.Data.SqlClient.SqlParameter("@PreviousPrefix", System.Data.SqlDbType.NVarChar, 0, "PreviousPrefix"), New System.Data.SqlClient.SqlParameter("@LastPrefix", System.Data.SqlDbType.NVarChar, 0, "LastPrefix"), New System.Data.SqlClient.SqlParameter("@DrawingOrReport", System.Data.SqlDbType.NVarChar, 0, "DrawingOrReport"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.Bit, 0, "Active")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DocumentType", System.Data.SqlDbType.NVarChar, 0, "DocumentType"), New System.Data.SqlClient.SqlParameter("@Prefix", System.Data.SqlDbType.NVarChar, 0, "Prefix"), New System.Data.SqlClient.SqlParameter("@NextPrefix", System.Data.SqlDbType.NVarChar, 0, "NextPrefix"), New System.Data.SqlClient.SqlParameter("@Trailing", System.Data.SqlDbType.Int, 0, "Trailing"), New System.Data.SqlClient.SqlParameter("@FirstPrefix", System.Data.SqlDbType.NVarChar, 0, "FirstPrefix"), New System.Data.SqlClient.SqlParameter("@PreviousPrefix", System.Data.SqlDbType.NVarChar, 0, "PreviousPrefix"), New System.Data.SqlClient.SqlParameter("@LastPrefix", System.Data.SqlDbType.NVarChar, 0, "LastPrefix"), New System.Data.SqlClient.SqlParameter("@DrawingOrReport", System.Data.SqlDbType.NVarChar, 0, "DrawingOrReport"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.Bit, 0, "Active"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocumentType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocumentType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Prefix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Prefix", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Prefix", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prefix", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NextPrefix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NextPrefix", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NextPrefix", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextPrefix", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Trailing", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Trailing", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Trailing", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Trailing", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FirstPrefix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FirstPrefix", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FirstPrefix", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstPrefix", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PreviousPrefix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PreviousPrefix", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PreviousPrefix", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PreviousPrefix", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LastPrefix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastPrefix", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LastPrefix", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastPrefix", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingOrReport", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingOrReport", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingOrReport", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingOrReport", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocumentType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocumentType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Prefix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Prefix", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Prefix", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prefix", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NextPrefix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NextPrefix", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NextPrefix", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextPrefix", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Trailing", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Trailing", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Trailing", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Trailing", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FirstPrefix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FirstPrefix", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FirstPrefix", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstPrefix", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PreviousPrefix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PreviousPrefix", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PreviousPrefix", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PreviousPrefix", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LastPrefix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastPrefix", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LastPrefix", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastPrefix", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingOrReport", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingOrReport", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingOrReport", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingOrReport", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDocTypePrefixLevelThree", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DocumentType", "DocumentType"), New System.Data.Common.DataColumnMapping("Prefix", "Prefix"), New System.Data.Common.DataColumnMapping("NextPrefix", "NextPrefix"), New System.Data.Common.DataColumnMapping("Trailing", "Trailing"), New System.Data.Common.DataColumnMapping("FirstPrefix", "FirstPrefix"), New System.Data.Common.DataColumnMapping("PreviousPrefix", "PreviousPrefix"), New System.Data.Common.DataColumnMapping("LastPrefix", "LastPrefix"), New System.Data.Common.DataColumnMapping("DrawingOrReport", "DrawingOrReport"), New System.Data.Common.DataColumnMapping("Active", "Active")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'txtRecordID
        '
        Me.txtRecordID.Location = New System.Drawing.Point(343, 287)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(100, 20)
        Me.txtRecordID.TabIndex = 3
        '
        'frmEngWorkflowLevelThreeDocType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 678)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtRecordID)
        Me.Name = "frmEngWorkflowLevelThreeDocType"
        Me.Text = "Level Three Document Type"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLevelThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLevelThree1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents bsLevelThree As BindingSource
    Friend WithEvents DsLevelThree1 As dsLevelThree
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrefix As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNextPrefix As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTrailing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFirstPrefix As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreviousPrefix As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastPrefix As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingOrReport As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents txtRecordID As TextBox
End Class
