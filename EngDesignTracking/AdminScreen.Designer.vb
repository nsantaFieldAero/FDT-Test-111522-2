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
        Me.UsersBindingSrc = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersDataset = New EngDesignTracking.UsersDataset()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.UsersDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
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
        Me.colCM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectSync = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJaguarOnly = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLegacyForm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewForm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLUnlock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewRecord = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLeadEngineer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLiaisonEngineer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperations = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.UsersBindingSrc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.NVarChar, 0, "Username"), New System.Data.SqlClient.SqlParameter("@GridEdit", System.Data.SqlDbType.NVarChar, 0, "GridEdit"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@Drafter", System.Data.SqlDbType.NVarChar, 0, "Drafter"), New System.Data.SqlClient.SqlParameter("@SrEngineer", System.Data.SqlDbType.NVarChar, 0, "SrEngineer"), New System.Data.SqlClient.SqlParameter("@Releaser", System.Data.SqlDbType.NVarChar, 0, "Releaser"), New System.Data.SqlClient.SqlParameter("@Flammability", System.Data.SqlDbType.NVarChar, 0, "Flammability"), New System.Data.SqlClient.SqlParameter("@Stress", System.Data.SqlDbType.NVarChar, 0, "Stress"), New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.NVarChar, 0, "ID"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@Admin", System.Data.SqlDbType.NVarChar, 0, "Admin"), New System.Data.SqlClient.SqlParameter("@CM", System.Data.SqlDbType.Bit, 0, "CM"), New System.Data.SqlClient.SqlParameter("@ProjectSync", System.Data.SqlDbType.Bit, 0, "ProjectSync"), New System.Data.SqlClient.SqlParameter("@JaguarOnly", System.Data.SqlDbType.Bit, 0, "JaguarOnly"), New System.Data.SqlClient.SqlParameter("@LegacyForm", System.Data.SqlDbType.Bit, 0, "LegacyForm"), New System.Data.SqlClient.SqlParameter("@NewForm", System.Data.SqlDbType.Bit, 0, "NewForm"), New System.Data.SqlClient.SqlParameter("@MDL", System.Data.SqlDbType.Bit, 0, "MDL"), New System.Data.SqlClient.SqlParameter("@MDLUnlock", System.Data.SqlDbType.Bit, 0, "MDLUnlock"), New System.Data.SqlClient.SqlParameter("@LeadEngineer", System.Data.SqlDbType.Bit, 0, "LeadEngineer"), New System.Data.SqlClient.SqlParameter("@NewRecord", System.Data.SqlDbType.Bit, 0, "NewRecord"), New System.Data.SqlClient.SqlParameter("@LiaisonEngineer", System.Data.SqlDbType.NVarChar, 0, "LiaisonEngineer"), New System.Data.SqlClient.SqlParameter("@Operations", System.Data.SqlDbType.NVarChar, 0, "Operations"), New System.Data.SqlClient.SqlParameter("@Airworthiness", System.Data.SqlDbType.NVarChar, 0, "Airworthiness"), New System.Data.SqlClient.SqlParameter("@ChangeRedline", System.Data.SqlDbType.NVarChar, 0, "ChangeRedline"), New System.Data.SqlClient.SqlParameter("@MoveGates", System.Data.SqlDbType.NVarChar, 0, "MoveGates"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.Bit, 0, "Active"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.NVarChar, 0, "Username"), New System.Data.SqlClient.SqlParameter("@GridEdit", System.Data.SqlDbType.NVarChar, 0, "GridEdit"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@Drafter", System.Data.SqlDbType.NVarChar, 0, "Drafter"), New System.Data.SqlClient.SqlParameter("@SrEngineer", System.Data.SqlDbType.NVarChar, 0, "SrEngineer"), New System.Data.SqlClient.SqlParameter("@Releaser", System.Data.SqlDbType.NVarChar, 0, "Releaser"), New System.Data.SqlClient.SqlParameter("@Flammability", System.Data.SqlDbType.NVarChar, 0, "Flammability"), New System.Data.SqlClient.SqlParameter("@Stress", System.Data.SqlDbType.NVarChar, 0, "Stress"), New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.NVarChar, 0, "ID"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@Admin", System.Data.SqlDbType.NVarChar, 0, "Admin"), New System.Data.SqlClient.SqlParameter("@CM", System.Data.SqlDbType.Bit, 0, "CM"), New System.Data.SqlClient.SqlParameter("@ProjectSync", System.Data.SqlDbType.Bit, 0, "ProjectSync"), New System.Data.SqlClient.SqlParameter("@JaguarOnly", System.Data.SqlDbType.Bit, 0, "JaguarOnly"), New System.Data.SqlClient.SqlParameter("@LegacyForm", System.Data.SqlDbType.Bit, 0, "LegacyForm"), New System.Data.SqlClient.SqlParameter("@NewForm", System.Data.SqlDbType.Bit, 0, "NewForm"), New System.Data.SqlClient.SqlParameter("@MDL", System.Data.SqlDbType.Bit, 0, "MDL"), New System.Data.SqlClient.SqlParameter("@MDLUnlock", System.Data.SqlDbType.Bit, 0, "MDLUnlock"), New System.Data.SqlClient.SqlParameter("@LeadEngineer", System.Data.SqlDbType.Bit, 0, "LeadEngineer"), New System.Data.SqlClient.SqlParameter("@NewRecord", System.Data.SqlDbType.Bit, 0, "NewRecord"), New System.Data.SqlClient.SqlParameter("@LiaisonEngineer", System.Data.SqlDbType.NVarChar, 0, "LiaisonEngineer"), New System.Data.SqlClient.SqlParameter("@Operations", System.Data.SqlDbType.NVarChar, 0, "Operations"), New System.Data.SqlClient.SqlParameter("@Airworthiness", System.Data.SqlDbType.NVarChar, 0, "Airworthiness"), New System.Data.SqlClient.SqlParameter("@ChangeRedline", System.Data.SqlDbType.NVarChar, 0, "ChangeRedline"), New System.Data.SqlClient.SqlParameter("@MoveGates", System.Data.SqlDbType.NVarChar, 0, "MoveGates"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.Bit, 0, "Active"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_GridEdit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GridEdit", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_GridEdit", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GridEdit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Drafter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Drafter", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Releaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Releaser", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Flammability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Flammability", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Stress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Stress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Admin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Admin", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Admin", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Admin", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CM", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CM", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CM", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectSync", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectSync", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectSync", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectSync", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_JaguarOnly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "JaguarOnly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_JaguarOnly", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JaguarOnly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LegacyForm", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LegacyForm", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LegacyForm", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LegacyForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NewForm", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NewForm", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NewForm", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NewForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MDL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MDL", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MDL", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MDL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MDLUnlock", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MDLUnlock", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MDLUnlock", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MDLUnlock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LeadEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LeadEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LeadEngineer", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LeadEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NewRecord", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NewRecord", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NewRecord", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NewRecord", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Operations", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Operations", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Operations", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Operations", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Airworthiness", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Airworthiness", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Airworthiness", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Airworthiness", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ChangeRedline", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ChangeRedline", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ChangeRedline", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChangeRedline", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MoveGates", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MoveGates", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MoveGates", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MoveGates", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_GridEdit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GridEdit", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_GridEdit", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GridEdit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Drafter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Drafter", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Releaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Releaser", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Flammability", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Flammability", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Flammability", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Stress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Stress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Admin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Admin", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Admin", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Admin", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CM", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CM", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CM", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectSync", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectSync", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectSync", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectSync", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_JaguarOnly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "JaguarOnly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_JaguarOnly", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JaguarOnly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LegacyForm", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LegacyForm", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LegacyForm", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LegacyForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NewForm", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NewForm", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NewForm", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NewForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MDL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MDL", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MDL", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MDL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MDLUnlock", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MDLUnlock", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MDLUnlock", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MDLUnlock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LeadEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LeadEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LeadEngineer", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LeadEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NewRecord", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NewRecord", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NewRecord", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NewRecord", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Operations", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Operations", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Operations", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Operations", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Airworthiness", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Airworthiness", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Airworthiness", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Airworthiness", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ChangeRedline", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ChangeRedline", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ChangeRedline", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChangeRedline", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MoveGates", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MoveGates", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MoveGates", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MoveGates", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing)})
        '
        'UsersDataAdapter
        '
        Me.UsersDataAdapter.DeleteCommand = Me.SqlDeleteCommand1
        Me.UsersDataAdapter.InsertCommand = Me.SqlInsertCommand1
        Me.UsersDataAdapter.SelectCommand = Me.SqlSelectCommand1
        Me.UsersDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblUsers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("Username", "Username"), New System.Data.Common.DataColumnMapping("GridEdit", "GridEdit"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("Drafter", "Drafter"), New System.Data.Common.DataColumnMapping("SrEngineer", "SrEngineer"), New System.Data.Common.DataColumnMapping("Releaser", "Releaser"), New System.Data.Common.DataColumnMapping("Flammability", "Flammability"), New System.Data.Common.DataColumnMapping("Stress", "Stress"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("Admin", "Admin"), New System.Data.Common.DataColumnMapping("CM", "CM"), New System.Data.Common.DataColumnMapping("ProjectSync", "ProjectSync"), New System.Data.Common.DataColumnMapping("JaguarOnly", "JaguarOnly"), New System.Data.Common.DataColumnMapping("LegacyForm", "LegacyForm"), New System.Data.Common.DataColumnMapping("NewForm", "NewForm"), New System.Data.Common.DataColumnMapping("MDL", "MDL"), New System.Data.Common.DataColumnMapping("MDLUnlock", "MDLUnlock"), New System.Data.Common.DataColumnMapping("LeadEngineer", "LeadEngineer"), New System.Data.Common.DataColumnMapping("NewRecord", "NewRecord"), New System.Data.Common.DataColumnMapping("LiaisonEngineer", "LiaisonEngineer"), New System.Data.Common.DataColumnMapping("Operations", "Operations"), New System.Data.Common.DataColumnMapping("Airworthiness", "Airworthiness"), New System.Data.Common.DataColumnMapping("ChangeRedline", "ChangeRedline"), New System.Data.Common.DataColumnMapping("MoveGates", "MoveGates"), New System.Data.Common.DataColumnMapping("Active", "Active"), New System.Data.Common.DataColumnMapping("Email", "Email")})})
        Me.UsersDataAdapter.UpdateCommand = Me.SqlUpdateCommand1
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.UsersBindingSrc
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl1.Location = New System.Drawing.Point(1, 8)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1573, 754)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colUsername, Me.colGridEdit, Me.colEngineer, Me.colDrafter, Me.colSrEngineer, Me.colReleaser, Me.colFlammability, Me.colStress, Me.colID, Me.colLocation, Me.colAdmin, Me.colCM, Me.colProjectSync, Me.colJaguarOnly, Me.colLegacyForm, Me.colNewForm, Me.colMDL, Me.colMDLUnlock, Me.colNewRecord, Me.colLeadEngineer, Me.GridColumn1, Me.colLiaisonEngineer, Me.colOperations, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.GridView1.DetailHeight = 227
        Me.GridView1.FixedLineWidth = 1
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.Name = "colRecordID"
        '
        'colUsername
        '
        Me.colUsername.FieldName = "Username"
        Me.colUsername.Name = "colUsername"
        Me.colUsername.Visible = True
        Me.colUsername.VisibleIndex = 0
        Me.colUsername.Width = 64
        '
        'colGridEdit
        '
        Me.colGridEdit.FieldName = "GridEdit"
        Me.colGridEdit.Name = "colGridEdit"
        '
        'colEngineer
        '
        Me.colEngineer.FieldName = "Engineer"
        Me.colEngineer.Name = "colEngineer"
        '
        'colDrafter
        '
        Me.colDrafter.FieldName = "Drafter"
        Me.colDrafter.Name = "colDrafter"
        '
        'colSrEngineer
        '
        Me.colSrEngineer.FieldName = "SrEngineer"
        Me.colSrEngineer.Name = "colSrEngineer"
        '
        'colReleaser
        '
        Me.colReleaser.FieldName = "Releaser"
        Me.colReleaser.Name = "colReleaser"
        '
        'colFlammability
        '
        Me.colFlammability.FieldName = "Flammability"
        Me.colFlammability.Name = "colFlammability"
        '
        'colStress
        '
        Me.colStress.FieldName = "Stress"
        Me.colStress.Name = "colStress"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 1
        Me.colID.Width = 49
        '
        'colLocation
        '
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 2
        Me.colLocation.Width = 49
        '
        'colAdmin
        '
        Me.colAdmin.FieldName = "Admin"
        Me.colAdmin.Name = "colAdmin"
        Me.colAdmin.Visible = True
        Me.colAdmin.VisibleIndex = 3
        Me.colAdmin.Width = 48
        '
        'colCM
        '
        Me.colCM.FieldName = "CM"
        Me.colCM.Name = "colCM"
        Me.colCM.Visible = True
        Me.colCM.VisibleIndex = 4
        Me.colCM.Width = 27
        '
        'colProjectSync
        '
        Me.colProjectSync.FieldName = "ProjectSync"
        Me.colProjectSync.Name = "colProjectSync"
        Me.colProjectSync.Visible = True
        Me.colProjectSync.VisibleIndex = 12
        Me.colProjectSync.Width = 68
        '
        'colJaguarOnly
        '
        Me.colJaguarOnly.FieldName = "JaguarOnly"
        Me.colJaguarOnly.Name = "colJaguarOnly"
        Me.colJaguarOnly.Visible = True
        Me.colJaguarOnly.VisibleIndex = 13
        Me.colJaguarOnly.Width = 69
        '
        'colLegacyForm
        '
        Me.colLegacyForm.FieldName = "LegacyForm"
        Me.colLegacyForm.Name = "colLegacyForm"
        Me.colLegacyForm.Visible = True
        Me.colLegacyForm.VisibleIndex = 14
        Me.colLegacyForm.Width = 53
        '
        'colNewForm
        '
        Me.colNewForm.FieldName = "NewForm"
        Me.colNewForm.Name = "colNewForm"
        Me.colNewForm.Visible = True
        Me.colNewForm.VisibleIndex = 15
        Me.colNewForm.Width = 60
        '
        'colMDL
        '
        Me.colMDL.FieldName = "MDL"
        Me.colMDL.Name = "colMDL"
        Me.colMDL.Visible = True
        Me.colMDL.VisibleIndex = 16
        Me.colMDL.Width = 31
        '
        'colMDLUnlock
        '
        Me.colMDLUnlock.FieldName = "MDLUnlock"
        Me.colMDLUnlock.Name = "colMDLUnlock"
        Me.colMDLUnlock.Visible = True
        Me.colMDLUnlock.VisibleIndex = 17
        Me.colMDLUnlock.Width = 62
        '
        'colNewRecord
        '
        Me.colNewRecord.FieldName = "NewRecord"
        Me.colNewRecord.Name = "colNewRecord"
        Me.colNewRecord.Visible = True
        Me.colNewRecord.VisibleIndex = 11
        Me.colNewRecord.Width = 60
        '
        'colLeadEngineer
        '
        Me.colLeadEngineer.FieldName = "LeadEngineer"
        Me.colLeadEngineer.Name = "colLeadEngineer"
        Me.colLeadEngineer.Visible = True
        Me.colLeadEngineer.VisibleIndex = 8
        Me.colLeadEngineer.Width = 62
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Drafter"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 56
        '
        'colLiaisonEngineer
        '
        Me.colLiaisonEngineer.FieldName = "LiaisonEngineer"
        Me.colLiaisonEngineer.Name = "colLiaisonEngineer"
        Me.colLiaisonEngineer.Visible = True
        Me.colLiaisonEngineer.VisibleIndex = 6
        Me.colLiaisonEngineer.Width = 70
        '
        'colOperations
        '
        Me.colOperations.FieldName = "Operations"
        Me.colOperations.Name = "colOperations"
        Me.colOperations.Visible = True
        Me.colOperations.VisibleIndex = 7
        Me.colOperations.Width = 57
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "GridEdit"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 18
        Me.GridColumn2.Width = 51
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "Engineer"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 21
        Me.GridColumn3.Width = 41
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "SrEngineer"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 22
        Me.GridColumn4.Width = 49
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "Releaser"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 9
        Me.GridColumn5.Width = 53
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "Flammability"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 23
        Me.GridColumn6.Width = 49
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "Stress"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 24
        Me.GridColumn7.Width = 46
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "Airworthiness"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 10
        Me.GridColumn8.Width = 77
        '
        'GridColumn9
        '
        Me.GridColumn9.FieldName = "Active"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 25
        Me.GridColumn9.Width = 41
        '
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "Email"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 26
        Me.GridColumn10.Width = 112
        '
        'GridColumn11
        '
        Me.GridColumn11.FieldName = "ChangeRedline"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 19
        Me.GridColumn11.Width = 84
        '
        'GridColumn12
        '
        Me.GridColumn12.FieldName = "MoveGates"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 20
        Me.GridColumn12.Width = 67
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(874, 14)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 25)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(764, 14)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 25)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'AdminScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1575, 773)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.GridControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminScreen"
        CType(Me.UsersBindingSrc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UsersBindingSrc As BindingSource
    Friend WithEvents UsersDataset As UsersDataset
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents UsersDataAdapter As SqlClient.SqlDataAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents colCM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectSync As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJaguarOnly As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLegacyForm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewForm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents colMDL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLUnlock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewRecord As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLeadEngineer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLiaisonEngineer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperations As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
End Class
