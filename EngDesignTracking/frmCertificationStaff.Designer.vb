<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCertificationStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCertificationStaff))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet81 = New EngDesignTracking.DataSet8()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLeadCertEngineer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitMember = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitMemberSpecialty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAOMTMember = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAOMTMemberSpecialty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet81, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        tblCertificationStaff.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblCertificationStaff"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 0, "Name"), New System.Data.SqlClient.SqlParameter("@LeadCertEngineer", System.Data.SqlDbType.Bit, 0, "LeadCertEngineer"), New System.Data.SqlClient.SqlParameter("@UnitMember", System.Data.SqlDbType.Bit, 0, "UnitMember"), New System.Data.SqlClient.SqlParameter("@UnitMemberSpecialty", System.Data.SqlDbType.NVarChar, 0, "UnitMemberSpecialty"), New System.Data.SqlClient.SqlParameter("@FAAOMTMember", System.Data.SqlDbType.Bit, 0, "FAAOMTMember"), New System.Data.SqlClient.SqlParameter("@FAAOMTMemberSpecialty", System.Data.SqlDbType.NVarChar, 0, "FAAOMTMemberSpecialty")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 0, "Name"), New System.Data.SqlClient.SqlParameter("@LeadCertEngineer", System.Data.SqlDbType.Bit, 0, "LeadCertEngineer"), New System.Data.SqlClient.SqlParameter("@UnitMember", System.Data.SqlDbType.Bit, 0, "UnitMember"), New System.Data.SqlClient.SqlParameter("@UnitMemberSpecialty", System.Data.SqlDbType.NVarChar, 0, "UnitMemberSpecialty"), New System.Data.SqlClient.SqlParameter("@FAAOMTMember", System.Data.SqlDbType.Bit, 0, "FAAOMTMember"), New System.Data.SqlClient.SqlParameter("@FAAOMTMemberSpecialty", System.Data.SqlDbType.NVarChar, 0, "FAAOMTMemberSpecialty"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LeadCertEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LeadCertEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LeadCertEngineer", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LeadCertEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UnitMember", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UnitMember", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UnitMember", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitMember", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UnitMemberSpecialty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UnitMemberSpecialty", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UnitMemberSpecialty", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitMemberSpecialty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAOMTMember", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAOMTMember", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAOMTMember", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAOMTMember", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAOMTMemberSpecialty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAOMTMemberSpecialty", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAOMTMemberSpecialty", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAOMTMemberSpecialty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LeadCertEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LeadCertEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LeadCertEngineer", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LeadCertEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UnitMember", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UnitMember", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UnitMember", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitMember", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UnitMemberSpecialty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UnitMemberSpecialty", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UnitMemberSpecialty", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitMemberSpecialty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAOMTMember", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAOMTMember", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAOMTMember", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAOMTMember", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAOMTMemberSpecialty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAOMTMemberSpecialty", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAOMTMemberSpecialty", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAOMTMemberSpecialty", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblCertificationStaff", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("LeadCertEngineer", "LeadCertEngineer"), New System.Data.Common.DataColumnMapping("UnitMember", "UnitMember"), New System.Data.Common.DataColumnMapping("UnitMemberSpecialty", "UnitMemberSpecialty"), New System.Data.Common.DataColumnMapping("FAAOMTMember", "FAAOMTMember"), New System.Data.Common.DataColumnMapping("FAAOMTMemberSpecialty", "FAAOMTMemberSpecialty")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblCertificationStaff"
        Me.BindingSource1.DataSource = Me.DataSet81
        '
        'DataSet81
        '
        Me.DataSet81.DataSetName = "DataSet8"
        Me.DataSet81.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridControl1.Location = New System.Drawing.Point(18, 18)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1654, 606)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colName, Me.colLeadCertEngineer, Me.colUnitMember, Me.colUnitMemberSpecialty, Me.colFAAOMTMember, Me.colFAAOMTMemberSpecialty})
        Me.GridView1.DetailHeight = 538
        Me.GridView1.FixedLineWidth = 3
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.MinWidth = 30
        Me.colRecordID.Name = "colRecordID"
        Me.colRecordID.Visible = True
        Me.colRecordID.VisibleIndex = 0
        Me.colRecordID.Width = 112
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.MinWidth = 30
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 1
        Me.colName.Width = 112
        '
        'colLeadCertEngineer
        '
        Me.colLeadCertEngineer.FieldName = "LeadCertEngineer"
        Me.colLeadCertEngineer.MinWidth = 30
        Me.colLeadCertEngineer.Name = "colLeadCertEngineer"
        Me.colLeadCertEngineer.Visible = True
        Me.colLeadCertEngineer.VisibleIndex = 2
        Me.colLeadCertEngineer.Width = 112
        '
        'colUnitMember
        '
        Me.colUnitMember.FieldName = "UnitMember"
        Me.colUnitMember.MinWidth = 30
        Me.colUnitMember.Name = "colUnitMember"
        Me.colUnitMember.Visible = True
        Me.colUnitMember.VisibleIndex = 3
        Me.colUnitMember.Width = 112
        '
        'colUnitMemberSpecialty
        '
        Me.colUnitMemberSpecialty.FieldName = "UnitMemberSpecialty"
        Me.colUnitMemberSpecialty.MinWidth = 30
        Me.colUnitMemberSpecialty.Name = "colUnitMemberSpecialty"
        Me.colUnitMemberSpecialty.Visible = True
        Me.colUnitMemberSpecialty.VisibleIndex = 4
        Me.colUnitMemberSpecialty.Width = 112
        '
        'colFAAOMTMember
        '
        Me.colFAAOMTMember.FieldName = "FAAOMTMember"
        Me.colFAAOMTMember.MinWidth = 30
        Me.colFAAOMTMember.Name = "colFAAOMTMember"
        Me.colFAAOMTMember.Visible = True
        Me.colFAAOMTMember.VisibleIndex = 5
        Me.colFAAOMTMember.Width = 112
        '
        'colFAAOMTMemberSpecialty
        '
        Me.colFAAOMTMemberSpecialty.FieldName = "FAAOMTMemberSpecialty"
        Me.colFAAOMTMemberSpecialty.MinWidth = 30
        Me.colFAAOMTMemberSpecialty.Name = "colFAAOMTMemberSpecialty"
        Me.colFAAOMTMemberSpecialty.Visible = True
        Me.colFAAOMTMemberSpecialty.VisibleIndex = 6
        Me.colFAAOMTMemberSpecialty.Width = 112
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1454, 638)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(219, 35)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmCertificationStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1690, 692)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GridControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCertificationStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCertificationStaff"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet81 As DataSet8
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLeadCertEngineer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitMember As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitMemberSpecialty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAOMTMember As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAOMTMemberSpecialty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSave As Button
End Class
