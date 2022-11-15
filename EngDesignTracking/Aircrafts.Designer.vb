<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aircrafts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aircrafts))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsAircrafts1 = New EngDesignTracking.dsAircrafts()
        Me.bsAircrafts = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAircraft = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DsAircrafts1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAircrafts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        tblAircraftsLOVMaint.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblAircraftsLOVMaint"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=engdwgtest;Persist Security Info=" &
    "True;User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Aircraft", System.Data.SqlDbType.NVarChar, 0, "Aircraft"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@ProgramNumber", System.Data.SqlDbType.NVarChar, 0, "ProgramNumber"), New System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.NVarChar, 0, "ProjectName"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.NVarChar, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Aircraft", System.Data.SqlDbType.NVarChar, 0, "Aircraft"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@ProgramNumber", System.Data.SqlDbType.NVarChar, 0, "ProgramNumber"), New System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.NVarChar, 0, "ProjectName"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.NVarChar, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Aircraft", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Aircraft", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Aircraft", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aircraft", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Aircraft", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Aircraft", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Aircraft", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aircraft", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblAircraftsLOVMaint", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("Aircraft", "Aircraft"), New System.Data.Common.DataColumnMapping("ProgramName", "ProgramName"), New System.Data.Common.DataColumnMapping("ProgramNumber", "ProgramNumber"), New System.Data.Common.DataColumnMapping("ProjectName", "ProjectName"), New System.Data.Common.DataColumnMapping("ProjectNumber", "ProjectNumber"), New System.Data.Common.DataColumnMapping("Location", "Location")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DsAircrafts1
        '
        Me.DsAircrafts1.DataSetName = "dsAircrafts"
        Me.DsAircrafts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsAircrafts
        '
        Me.bsAircrafts.DataMember = "tblAircraftsLOVMaint"
        Me.bsAircrafts.DataSource = Me.DsAircrafts1
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsAircrafts
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GridControl1.Location = New System.Drawing.Point(24, 23)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(2004, 981)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colAircraft, Me.colProgramName, Me.colProgramNumber, Me.colProjectName, Me.colProjectNumber, Me.colLocation})
        Me.GridView1.DetailHeight = 673
        Me.GridView1.FixedLineWidth = 4
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.MinWidth = 40
        Me.colRecordID.Name = "colRecordID"
        Me.colRecordID.Visible = True
        Me.colRecordID.VisibleIndex = 0
        Me.colRecordID.Width = 150
        '
        'colAircraft
        '
        Me.colAircraft.Caption = "Manufacturer"
        Me.colAircraft.FieldName = "Aircraft"
        Me.colAircraft.MinWidth = 40
        Me.colAircraft.Name = "colAircraft"
        Me.colAircraft.Visible = True
        Me.colAircraft.VisibleIndex = 1
        Me.colAircraft.Width = 150
        '
        'colProgramName
        '
        Me.colProgramName.Caption = "Model"
        Me.colProgramName.FieldName = "ProgramName"
        Me.colProgramName.MinWidth = 40
        Me.colProgramName.Name = "colProgramName"
        Me.colProgramName.Visible = True
        Me.colProgramName.VisibleIndex = 2
        Me.colProgramName.Width = 150
        '
        'colProgramNumber
        '
        Me.colProgramNumber.FieldName = "ProgramNumber"
        Me.colProgramNumber.MinWidth = 40
        Me.colProgramNumber.Name = "colProgramNumber"
        Me.colProgramNumber.Visible = True
        Me.colProgramNumber.VisibleIndex = 3
        Me.colProgramNumber.Width = 150
        '
        'colProjectName
        '
        Me.colProjectName.FieldName = "ProjectName"
        Me.colProjectName.MinWidth = 40
        Me.colProjectName.Name = "colProjectName"
        Me.colProjectName.Visible = True
        Me.colProjectName.VisibleIndex = 4
        Me.colProjectName.Width = 150
        '
        'colProjectNumber
        '
        Me.colProjectNumber.FieldName = "ProjectNumber"
        Me.colProjectNumber.MinWidth = 40
        Me.colProjectNumber.Name = "colProjectNumber"
        Me.colProjectNumber.Visible = True
        Me.colProjectNumber.VisibleIndex = 5
        Me.colProjectNumber.Width = 150
        '
        'colLocation
        '
        Me.colLocation.FieldName = "Location"
        Me.colLocation.MinWidth = 40
        Me.colLocation.Name = "colLocation"
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 6
        Me.colLocation.Width = 150
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(630, 1015)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(226, 56)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(986, 1015)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(226, 56)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete Current"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtRecordID
        '
        Me.txtRecordID.Location = New System.Drawing.Point(630, 485)
        Me.txtRecordID.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(196, 31)
        Me.txtRecordID.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(691, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(247, 60)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Aircrafts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2052, 1094)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtRecordID)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Aircrafts"
        Me.Text = "Aircrafts"
        CType(Me.DsAircrafts1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAircrafts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DsAircrafts1 As dsAircrafts
    Friend WithEvents bsAircrafts As BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAircraft As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRecordID As TextBox
    Friend WithEvents Button1 As Button
End Class
