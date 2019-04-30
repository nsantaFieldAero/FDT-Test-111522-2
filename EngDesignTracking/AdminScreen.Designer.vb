<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminScreen))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.UsersBindingSrc = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersDataset = New EngDesignTracking.UsersDataset()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsername = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGridEdit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammability = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdmin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.UsersDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSrc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.UsersBindingSrc
        Me.GridControl1.Location = New System.Drawing.Point(39, 27)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(841, 605)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'UsersBindingSrc
        '
        Me.UsersBindingSrc.DataMember = "tblUsers"
        Me.UsersBindingSrc.DataSource = Me.UsersDataset
        '
        'UsersDataset
        '
        Me.UsersDataset.DataSetName = "UsersDataset"
        Me.UsersDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colUsername, Me.colGridEdit, Me.colEngineer, Me.colDrafter, Me.colSrEngineer, Me.colReleaser, Me.colFlammability, Me.colStress, Me.colID, Me.colLocation, Me.colAdmin})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.Name = "colRecordID"
        Me.colRecordID.Visible = True
        Me.colRecordID.VisibleIndex = 0
        '
        'colUsername
        '
        Me.colUsername.FieldName = "Username"
        Me.colUsername.Name = "colUsername"
        Me.colUsername.Visible = True
        Me.colUsername.VisibleIndex = 1
        '
        'colGridEdit
        '
        Me.colGridEdit.FieldName = "GridEdit"
        Me.colGridEdit.Name = "colGridEdit"
        Me.colGridEdit.Visible = True
        Me.colGridEdit.VisibleIndex = 2
        '
        'colEngineer
        '
        Me.colEngineer.FieldName = "Engineer"
        Me.colEngineer.Name = "colEngineer"
        Me.colEngineer.Visible = True
        Me.colEngineer.VisibleIndex = 3
        '
        'colDrafter
        '
        Me.colDrafter.FieldName = "Drafter"
        Me.colDrafter.Name = "colDrafter"
        Me.colDrafter.Visible = True
        Me.colDrafter.VisibleIndex = 4
        '
        'colSrEngineer
        '
        Me.colSrEngineer.FieldName = "SrEngineer"
        Me.colSrEngineer.Name = "colSrEngineer"
        Me.colSrEngineer.Visible = True
        Me.colSrEngineer.VisibleIndex = 5
        '
        'colReleaser
        '
        Me.colReleaser.FieldName = "Releaser"
        Me.colReleaser.Name = "colReleaser"
        Me.colReleaser.Visible = True
        Me.colReleaser.VisibleIndex = 6
        '
        'colFlammability
        '
        Me.colFlammability.FieldName = "Flammability"
        Me.colFlammability.Name = "colFlammability"
        Me.colFlammability.Visible = True
        Me.colFlammability.VisibleIndex = 7
        '
        'colStress
        '
        Me.colStress.FieldName = "Stress"
        Me.colStress.Name = "colStress"
        Me.colStress.Visible = True
        Me.colStress.VisibleIndex = 8
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 9
        '
        'colLocation
        '
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 10
        '
        'colAdmin
        '
        Me.colAdmin.FieldName = "Admin"
        Me.colAdmin.Name = "colAdmin"
        Me.colAdmin.Visible = True
        Me.colAdmin.VisibleIndex = 11
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        tblUsers.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblUsers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY Location, RecordID, " &
    "Username"
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.NVarChar, 0, "Username"), New System.Data.SqlClient.SqlParameter("@GridEdit", System.Data.SqlDbType.NVarChar, 0, "GridEdit"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@Drafter", System.Data.SqlDbType.NVarChar, 0, "Drafter"), New System.Data.SqlClient.SqlParameter("@SrEngineer", System.Data.SqlDbType.NVarChar, 0, "SrEngineer"), New System.Data.SqlClient.SqlParameter("@Releaser", System.Data.SqlDbType.NVarChar, 0, "Releaser"), New System.Data.SqlClient.SqlParameter("@Flammability", System.Data.SqlDbType.NVarChar, 0, "Flammability"), New System.Data.SqlClient.SqlParameter("@Stress", System.Data.SqlDbType.NVarChar, 0, "Stress"), New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.NVarChar, 0, "ID"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@Admin", System.Data.SqlDbType.NVarChar, 0, "Admin")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.NVarChar, 0, "Username"), New System.Data.SqlClient.SqlParameter("@GridEdit", System.Data.SqlDbType.NVarChar, 0, "GridEdit"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@Drafter", System.Data.SqlDbType.NVarChar, 0, "Drafter"), New System.Data.SqlClient.SqlParameter("@SrEngineer", System.Data.SqlDbType.NVarChar, 0, "SrEngineer"), New System.Data.SqlClient.SqlParameter("@Releaser", System.Data.SqlDbType.NVarChar, 0, "Releaser"), New System.Data.SqlClient.SqlParameter("@Flammability", System.Data.SqlDbType.NVarChar, 0, "Flammability"), New System.Data.SqlClient.SqlParameter("@Stress", System.Data.SqlDbType.NVarChar, 0, "Stress"), New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.NVarChar, 0, "ID"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@Admin", System.Data.SqlDbType.NVarChar, 0, "Admin"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_GridEdit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GridEdit", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_GridEdit", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GridEdit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Drafter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Drafter", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Releaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Releaser", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Flammability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Flammability", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Stress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Stress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Admin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Admin", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Admin", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Admin", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_GridEdit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GridEdit", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_GridEdit", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GridEdit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Drafter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Drafter", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Releaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Releaser", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Flammability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Flammability", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Stress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Stress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Admin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Admin", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Admin", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Admin", System.Data.DataRowVersion.Original, Nothing)})
        '
        'UsersDataAdapter
        '
        Me.UsersDataAdapter.DeleteCommand = Me.SqlDeleteCommand1
        Me.UsersDataAdapter.InsertCommand = Me.SqlInsertCommand1
        Me.UsersDataAdapter.SelectCommand = Me.SqlSelectCommand1
        Me.UsersDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblUsers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("Username", "Username"), New System.Data.Common.DataColumnMapping("GridEdit", "GridEdit"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("Drafter", "Drafter"), New System.Data.Common.DataColumnMapping("SrEngineer", "SrEngineer"), New System.Data.Common.DataColumnMapping("Releaser", "Releaser"), New System.Data.Common.DataColumnMapping("Flammability", "Flammability"), New System.Data.Common.DataColumnMapping("Stress", "Stress"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("Admin", "Admin")})})
        Me.UsersDataAdapter.UpdateCommand = Me.SqlUpdateCommand1
        '
        'AdminScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 709)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "AdminScreen"
        Me.Text = "AdminScreen"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSrc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UsersBindingSrc As BindingSource
    Friend WithEvents UsersDataset As UsersDataset
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsername As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGridEdit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammability As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdmin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents UsersDataAdapter As SqlClient.SqlDataAdapter
End Class
