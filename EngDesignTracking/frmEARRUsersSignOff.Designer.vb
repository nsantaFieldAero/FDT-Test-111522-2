<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEARRUsersSignOff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEARRUsersSignOff))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsEARRUsersSignOff1 = New EngDesignTracking.dsEARRUsersSignOff()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsername = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSignedName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabShop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLiaison = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLiaisonBackup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerBackup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQCBackup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanner1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanner2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReadOnly = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnterEARR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSubstitute = New System.Windows.Forms.Button()
        CType(Me.DsEARRUsersSignOff1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=EARR;Persist Security Info=True;U" &
    "ser ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.NVarChar, 0, "Username"), New System.Data.SqlClient.SqlParameter("@SignedName", System.Data.SqlDbType.NVarChar, 0, "SignedName"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@Program2", System.Data.SqlDbType.NVarChar, 0, "Program2"), New System.Data.SqlClient.SqlParameter("@Program3", System.Data.SqlDbType.NVarChar, 0, "Program3"), New System.Data.SqlClient.SqlParameter("@Program4", System.Data.SqlDbType.NVarChar, 0, "Program4"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@Type2", System.Data.SqlDbType.NVarChar, 0, "Type2"), New System.Data.SqlClient.SqlParameter("@FabShop", System.Data.SqlDbType.Bit, 0, "FabShop"), New System.Data.SqlClient.SqlParameter("@Liaison", System.Data.SqlDbType.Bit, 0, "Liaison"), New System.Data.SqlClient.SqlParameter("@LiaisonBackup", System.Data.SqlDbType.Bit, 0, "LiaisonBackup"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.Bit, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@EngineerBackup", System.Data.SqlDbType.Bit, 0, "EngineerBackup"), New System.Data.SqlClient.SqlParameter("@QC", System.Data.SqlDbType.Bit, 0, "QC"), New System.Data.SqlClient.SqlParameter("@QCBackup", System.Data.SqlDbType.Bit, 0, "QCBackup"), New System.Data.SqlClient.SqlParameter("@Planner1", System.Data.SqlDbType.Bit, 0, "Planner1"), New System.Data.SqlClient.SqlParameter("@Planner2", System.Data.SqlDbType.Bit, 0, "Planner2"), New System.Data.SqlClient.SqlParameter("@ReadOnly", System.Data.SqlDbType.Bit, 0, "ReadOnly"), New System.Data.SqlClient.SqlParameter("@EnterEARR", System.Data.SqlDbType.Bit, 0, "EnterEARR")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.NVarChar, 0, "Username"), New System.Data.SqlClient.SqlParameter("@SignedName", System.Data.SqlDbType.NVarChar, 0, "SignedName"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@Program2", System.Data.SqlDbType.NVarChar, 0, "Program2"), New System.Data.SqlClient.SqlParameter("@Program3", System.Data.SqlDbType.NVarChar, 0, "Program3"), New System.Data.SqlClient.SqlParameter("@Program4", System.Data.SqlDbType.NVarChar, 0, "Program4"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@Type2", System.Data.SqlDbType.NVarChar, 0, "Type2"), New System.Data.SqlClient.SqlParameter("@FabShop", System.Data.SqlDbType.Bit, 0, "FabShop"), New System.Data.SqlClient.SqlParameter("@Liaison", System.Data.SqlDbType.Bit, 0, "Liaison"), New System.Data.SqlClient.SqlParameter("@LiaisonBackup", System.Data.SqlDbType.Bit, 0, "LiaisonBackup"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.Bit, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@EngineerBackup", System.Data.SqlDbType.Bit, 0, "EngineerBackup"), New System.Data.SqlClient.SqlParameter("@QC", System.Data.SqlDbType.Bit, 0, "QC"), New System.Data.SqlClient.SqlParameter("@QCBackup", System.Data.SqlDbType.Bit, 0, "QCBackup"), New System.Data.SqlClient.SqlParameter("@Planner1", System.Data.SqlDbType.Bit, 0, "Planner1"), New System.Data.SqlClient.SqlParameter("@Planner2", System.Data.SqlDbType.Bit, 0, "Planner2"), New System.Data.SqlClient.SqlParameter("@ReadOnly", System.Data.SqlDbType.Bit, 0, "ReadOnly"), New System.Data.SqlClient.SqlParameter("@EnterEARR", System.Data.SqlDbType.Bit, 0, "EnterEARR"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SignedName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SignedName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SignedName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignedName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program3", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program4", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FabShop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FabShop", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Liaison", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Liaison", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Liaison", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Liaison", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonBackup", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerBackup", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QC", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QC", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCBackup", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner1", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner2", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReadOnly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReadOnly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReadOnly", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReadOnly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EnterEARR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EnterEARR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EnterEARR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EnterEARR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SignedName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SignedName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SignedName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignedName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program3", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program4", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FabShop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FabShop", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Liaison", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Liaison", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Liaison", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Liaison", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonBackup", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerBackup", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QC", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QC", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCBackup", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner1", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner2", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReadOnly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReadOnly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReadOnly", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReadOnly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EnterEARR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EnterEARR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EnterEARR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EnterEARR", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblUsersCreateEARR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("Username", "Username"), New System.Data.Common.DataColumnMapping("SignedName", "SignedName"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("Program2", "Program2"), New System.Data.Common.DataColumnMapping("Program3", "Program3"), New System.Data.Common.DataColumnMapping("Program4", "Program4"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("Type2", "Type2"), New System.Data.Common.DataColumnMapping("FabShop", "FabShop"), New System.Data.Common.DataColumnMapping("Liaison", "Liaison"), New System.Data.Common.DataColumnMapping("LiaisonBackup", "LiaisonBackup"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerBackup", "EngineerBackup"), New System.Data.Common.DataColumnMapping("QC", "QC"), New System.Data.Common.DataColumnMapping("QCBackup", "QCBackup"), New System.Data.Common.DataColumnMapping("Planner1", "Planner1"), New System.Data.Common.DataColumnMapping("Planner2", "Planner2"), New System.Data.Common.DataColumnMapping("ReadOnly", "ReadOnly"), New System.Data.Common.DataColumnMapping("EnterEARR", "EnterEARR")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DsEARRUsersSignOff1
        '
        Me.DsEARRUsersSignOff1.DataSetName = "dsEARRUsersSignOff"
        Me.DsEARRUsersSignOff1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblUsersCreateEARR"
        Me.BindingSource1.DataSource = Me.DsEARRUsersSignOff1
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.Location = New System.Drawing.Point(5, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1278, 699)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colUsername, Me.colSignedName, Me.colEmail, Me.colProgram, Me.colProgram2, Me.colProgram3, Me.colProgram4, Me.colType, Me.colType2, Me.colFabShop, Me.colLiaison, Me.colLiaisonBackup, Me.colEngineer, Me.colEngineerBackup, Me.colQC, Me.colQCBackup, Me.colPlanner1, Me.colPlanner2, Me.colReadOnly, Me.colEnterEARR})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
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
        Me.colUsername.Width = 105
        '
        'colSignedName
        '
        Me.colSignedName.FieldName = "SignedName"
        Me.colSignedName.Name = "colSignedName"
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 1
        Me.colEmail.Width = 104
        '
        'colProgram
        '
        Me.colProgram.FieldName = "Program"
        Me.colProgram.Name = "colProgram"
        Me.colProgram.Visible = True
        Me.colProgram.VisibleIndex = 2
        Me.colProgram.Width = 120
        '
        'colProgram2
        '
        Me.colProgram2.FieldName = "Program2"
        Me.colProgram2.Name = "colProgram2"
        Me.colProgram2.Visible = True
        Me.colProgram2.VisibleIndex = 3
        Me.colProgram2.Width = 119
        '
        'colProgram3
        '
        Me.colProgram3.FieldName = "Program3"
        Me.colProgram3.Name = "colProgram3"
        Me.colProgram3.Visible = True
        Me.colProgram3.VisibleIndex = 4
        Me.colProgram3.Width = 114
        '
        'colProgram4
        '
        Me.colProgram4.FieldName = "Program4"
        Me.colProgram4.Name = "colProgram4"
        Me.colProgram4.Visible = True
        Me.colProgram4.VisibleIndex = 5
        Me.colProgram4.Width = 102
        '
        'colType
        '
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 6
        Me.colType.Width = 69
        '
        'colType2
        '
        Me.colType2.FieldName = "Type2"
        Me.colType2.Name = "colType2"
        Me.colType2.Visible = True
        Me.colType2.VisibleIndex = 7
        Me.colType2.Width = 60
        '
        'colFabShop
        '
        Me.colFabShop.FieldName = "FabShop"
        Me.colFabShop.Name = "colFabShop"
        Me.colFabShop.Visible = True
        Me.colFabShop.VisibleIndex = 8
        Me.colFabShop.Width = 55
        '
        'colLiaison
        '
        Me.colLiaison.FieldName = "Liaison"
        Me.colLiaison.Name = "colLiaison"
        Me.colLiaison.Visible = True
        Me.colLiaison.VisibleIndex = 9
        Me.colLiaison.Width = 40
        '
        'colLiaisonBackup
        '
        Me.colLiaisonBackup.FieldName = "LiaisonBackup"
        Me.colLiaisonBackup.Name = "colLiaisonBackup"
        Me.colLiaisonBackup.Visible = True
        Me.colLiaisonBackup.VisibleIndex = 10
        Me.colLiaisonBackup.Width = 77
        '
        'colEngineer
        '
        Me.colEngineer.Caption = "Eng"
        Me.colEngineer.FieldName = "Engineer"
        Me.colEngineer.Name = "colEngineer"
        Me.colEngineer.Visible = True
        Me.colEngineer.VisibleIndex = 11
        Me.colEngineer.Width = 31
        '
        'colEngineerBackup
        '
        Me.colEngineerBackup.Caption = "Eng Backup"
        Me.colEngineerBackup.FieldName = "EngineerBackup"
        Me.colEngineerBackup.Name = "colEngineerBackup"
        Me.colEngineerBackup.Visible = True
        Me.colEngineerBackup.VisibleIndex = 12
        Me.colEngineerBackup.Width = 64
        '
        'colQC
        '
        Me.colQC.FieldName = "QC"
        Me.colQC.Name = "colQC"
        Me.colQC.Visible = True
        Me.colQC.VisibleIndex = 13
        Me.colQC.Width = 25
        '
        'colQCBackup
        '
        Me.colQCBackup.FieldName = "QCBackup"
        Me.colQCBackup.Name = "colQCBackup"
        Me.colQCBackup.Visible = True
        Me.colQCBackup.VisibleIndex = 14
        Me.colQCBackup.Width = 63
        '
        'colPlanner1
        '
        Me.colPlanner1.Caption = "Plan1"
        Me.colPlanner1.FieldName = "Planner1"
        Me.colPlanner1.Name = "colPlanner1"
        Me.colPlanner1.Visible = True
        Me.colPlanner1.VisibleIndex = 15
        Me.colPlanner1.Width = 44
        '
        'colPlanner2
        '
        Me.colPlanner2.Caption = "Plan2"
        Me.colPlanner2.FieldName = "Planner2"
        Me.colPlanner2.Name = "colPlanner2"
        Me.colPlanner2.Visible = True
        Me.colPlanner2.VisibleIndex = 16
        Me.colPlanner2.Width = 61
        '
        'colReadOnly
        '
        Me.colReadOnly.FieldName = "ReadOnly"
        Me.colReadOnly.Name = "colReadOnly"
        '
        'colEnterEARR
        '
        Me.colEnterEARR.FieldName = "EnterEARR"
        Me.colEnterEARR.Name = "colEnterEARR"
        '
        'btnSubstitute
        '
        Me.btnSubstitute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubstitute.Location = New System.Drawing.Point(5, 717)
        Me.btnSubstitute.Name = "btnSubstitute"
        Me.btnSubstitute.Size = New System.Drawing.Size(302, 43)
        Me.btnSubstitute.TabIndex = 1
        Me.btnSubstitute.Text = "Substitute Selected Users"
        Me.btnSubstitute.UseVisualStyleBackColor = True
        '
        'frmEARRUsersSignOff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 761)
        Me.Controls.Add(Me.btnSubstitute)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmEARRUsersSignOff"
        Me.Text = "frmEARRUsersSignOff"
        CType(Me.DsEARRUsersSignOff1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DsEARRUsersSignOff1 As dsEARRUsersSignOff
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsername As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignedName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabShop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLiaison As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLiaisonBackup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerBackup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQCBackup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanner1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanner2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReadOnly As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnterEARR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSubstitute As Button
End Class
