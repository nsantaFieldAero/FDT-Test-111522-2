<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEARRUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEARRUsers))
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.bsEARRUsers = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEARRUsers1 = New EngDesignTracking.dsEARRUsers()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daEARRUsers = New System.Data.SqlClient.SqlDataAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsername = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJaguarProgram = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colE6Program = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSherpa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnterEARR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJaguar16082 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSignedName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReadOnly = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCBP16033 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJaguarOnly = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRepetitiveSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIT192181 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSCG1903 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCAE16190 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJaguar2635 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMMSAC2640 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSuperUser = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.bsEARRUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEARRUsers1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(1, 12)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(164, 43)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'bsEARRUsers
        '
        Me.bsEARRUsers.DataMember = "tblUsers"
        Me.bsEARRUsers.DataSource = Me.DsEARRUsers1
        '
        'DsEARRUsers1
        '
        Me.DsEARRUsers1.DataSetName = "dsEARRUsers"
        Me.DsEARRUsers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.NVarChar, 0, "Username"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@JaguarProgram", System.Data.SqlDbType.Bit, 0, "JaguarProgram"), New System.Data.SqlClient.SqlParameter("@E6Program", System.Data.SqlDbType.Bit, 0, "E6Program"), New System.Data.SqlClient.SqlParameter("@Sherpa", System.Data.SqlDbType.Bit, 0, "Sherpa"), New System.Data.SqlClient.SqlParameter("@EnterEARR", System.Data.SqlDbType.Bit, 0, "EnterEARR"), New System.Data.SqlClient.SqlParameter("@Jaguar16082", System.Data.SqlDbType.Bit, 0, "Jaguar16082"), New System.Data.SqlClient.SqlParameter("@SignedName", System.Data.SqlDbType.NVarChar, 0, "SignedName"), New System.Data.SqlClient.SqlParameter("@ReadOnly", System.Data.SqlDbType.Bit, 0, "ReadOnly"), New System.Data.SqlClient.SqlParameter("@CBP16033", System.Data.SqlDbType.Bit, 0, "CBP16033"), New System.Data.SqlClient.SqlParameter("@JaguarOnly", System.Data.SqlDbType.Bit, 0, "JaguarOnly"), New System.Data.SqlClient.SqlParameter("@RepetitiveSale", System.Data.SqlDbType.Bit, 0, "RepetitiveSale"), New System.Data.SqlClient.SqlParameter("@MIT192181", System.Data.SqlDbType.Bit, 0, "MIT192181"), New System.Data.SqlClient.SqlParameter("@SCG1903", System.Data.SqlDbType.Bit, 0, "SCG1903"), New System.Data.SqlClient.SqlParameter("@CAE16190", System.Data.SqlDbType.Bit, 0, "CAE16190"), New System.Data.SqlClient.SqlParameter("@Jaguar2635", System.Data.SqlDbType.Bit, 0, "Jaguar2635"), New System.Data.SqlClient.SqlParameter("@MMSAC2640", System.Data.SqlDbType.Bit, 0, "MMSAC2640"), New System.Data.SqlClient.SqlParameter("@SuperUser", System.Data.SqlDbType.Bit, 0, "SuperUser"), New System.Data.SqlClient.SqlParameter("@MITN108EW", System.Data.SqlDbType.Bit, 0, "MITN108EW"), New System.Data.SqlClient.SqlParameter("@BAS16142", System.Data.SqlDbType.Bit, 0, "BAS16142"), New System.Data.SqlClient.SqlParameter("@DRAKEN4610", System.Data.SqlDbType.Bit, 0, "DRAKEN4610")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.NVarChar, 0, "Username"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@JaguarProgram", System.Data.SqlDbType.Bit, 0, "JaguarProgram"), New System.Data.SqlClient.SqlParameter("@E6Program", System.Data.SqlDbType.Bit, 0, "E6Program"), New System.Data.SqlClient.SqlParameter("@Sherpa", System.Data.SqlDbType.Bit, 0, "Sherpa"), New System.Data.SqlClient.SqlParameter("@EnterEARR", System.Data.SqlDbType.Bit, 0, "EnterEARR"), New System.Data.SqlClient.SqlParameter("@Jaguar16082", System.Data.SqlDbType.Bit, 0, "Jaguar16082"), New System.Data.SqlClient.SqlParameter("@SignedName", System.Data.SqlDbType.NVarChar, 0, "SignedName"), New System.Data.SqlClient.SqlParameter("@ReadOnly", System.Data.SqlDbType.Bit, 0, "ReadOnly"), New System.Data.SqlClient.SqlParameter("@CBP16033", System.Data.SqlDbType.Bit, 0, "CBP16033"), New System.Data.SqlClient.SqlParameter("@JaguarOnly", System.Data.SqlDbType.Bit, 0, "JaguarOnly"), New System.Data.SqlClient.SqlParameter("@RepetitiveSale", System.Data.SqlDbType.Bit, 0, "RepetitiveSale"), New System.Data.SqlClient.SqlParameter("@MIT192181", System.Data.SqlDbType.Bit, 0, "MIT192181"), New System.Data.SqlClient.SqlParameter("@SCG1903", System.Data.SqlDbType.Bit, 0, "SCG1903"), New System.Data.SqlClient.SqlParameter("@CAE16190", System.Data.SqlDbType.Bit, 0, "CAE16190"), New System.Data.SqlClient.SqlParameter("@Jaguar2635", System.Data.SqlDbType.Bit, 0, "Jaguar2635"), New System.Data.SqlClient.SqlParameter("@MMSAC2640", System.Data.SqlDbType.Bit, 0, "MMSAC2640"), New System.Data.SqlClient.SqlParameter("@SuperUser", System.Data.SqlDbType.Bit, 0, "SuperUser"), New System.Data.SqlClient.SqlParameter("@MITN108EW", System.Data.SqlDbType.Bit, 0, "MITN108EW"), New System.Data.SqlClient.SqlParameter("@BAS16142", System.Data.SqlDbType.Bit, 0, "BAS16142"), New System.Data.SqlClient.SqlParameter("@DRAKEN4610", System.Data.SqlDbType.Bit, 0, "DRAKEN4610"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_JaguarProgram", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "JaguarProgram", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_JaguarProgram", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JaguarProgram", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_E6Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "E6Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_E6Program", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "E6Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Sherpa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Sherpa", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Sherpa", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sherpa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EnterEARR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EnterEARR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EnterEARR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EnterEARR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Jaguar16082", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Jaguar16082", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Jaguar16082", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Jaguar16082", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SignedName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SignedName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SignedName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignedName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReadOnly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReadOnly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReadOnly", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReadOnly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CBP16033", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CBP16033", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CBP16033", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBP16033", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_JaguarOnly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "JaguarOnly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_JaguarOnly", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JaguarOnly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RepetitiveSale", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RepetitiveSale", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RepetitiveSale", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RepetitiveSale", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MIT192181", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MIT192181", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MIT192181", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MIT192181", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SCG1903", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SCG1903", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SCG1903", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SCG1903", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CAE16190", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CAE16190", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CAE16190", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAE16190", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Jaguar2635", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Jaguar2635", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Jaguar2635", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Jaguar2635", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MMSAC2640", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MMSAC2640", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MMSAC2640", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MMSAC2640", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SuperUser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SuperUser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SuperUser", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SuperUser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MITN108EW", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MITN108EW", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MITN108EW", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MITN108EW", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_BAS16142", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "BAS16142", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_BAS16142", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAS16142", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DRAKEN4610", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DRAKEN4610", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DRAKEN4610", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DRAKEN4610", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_JaguarProgram", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "JaguarProgram", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_JaguarProgram", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JaguarProgram", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_E6Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "E6Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_E6Program", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "E6Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Sherpa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Sherpa", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Sherpa", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sherpa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EnterEARR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EnterEARR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EnterEARR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EnterEARR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Jaguar16082", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Jaguar16082", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Jaguar16082", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Jaguar16082", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SignedName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SignedName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SignedName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignedName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReadOnly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReadOnly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReadOnly", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReadOnly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CBP16033", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CBP16033", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CBP16033", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBP16033", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_JaguarOnly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "JaguarOnly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_JaguarOnly", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JaguarOnly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RepetitiveSale", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RepetitiveSale", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RepetitiveSale", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RepetitiveSale", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MIT192181", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MIT192181", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MIT192181", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MIT192181", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SCG1903", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SCG1903", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SCG1903", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SCG1903", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CAE16190", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CAE16190", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CAE16190", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAE16190", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Jaguar2635", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Jaguar2635", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Jaguar2635", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Jaguar2635", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MMSAC2640", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MMSAC2640", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MMSAC2640", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MMSAC2640", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SuperUser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SuperUser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SuperUser", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SuperUser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MITN108EW", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MITN108EW", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MITN108EW", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MITN108EW", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_BAS16142", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "BAS16142", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_BAS16142", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAS16142", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DRAKEN4610", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DRAKEN4610", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DRAKEN4610", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DRAKEN4610", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daEARRUsers
        '
        Me.daEARRUsers.DeleteCommand = Me.SqlDeleteCommand1
        Me.daEARRUsers.InsertCommand = Me.SqlInsertCommand1
        Me.daEARRUsers.SelectCommand = Me.SqlSelectCommand1
        Me.daEARRUsers.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblUsers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("Username", "Username"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("JaguarProgram", "JaguarProgram"), New System.Data.Common.DataColumnMapping("E6Program", "E6Program"), New System.Data.Common.DataColumnMapping("Sherpa", "Sherpa"), New System.Data.Common.DataColumnMapping("EnterEARR", "EnterEARR"), New System.Data.Common.DataColumnMapping("Jaguar16082", "Jaguar16082"), New System.Data.Common.DataColumnMapping("SignedName", "SignedName"), New System.Data.Common.DataColumnMapping("ReadOnly", "ReadOnly"), New System.Data.Common.DataColumnMapping("CBP16033", "CBP16033"), New System.Data.Common.DataColumnMapping("JaguarOnly", "JaguarOnly"), New System.Data.Common.DataColumnMapping("RepetitiveSale", "RepetitiveSale"), New System.Data.Common.DataColumnMapping("MIT192181", "MIT192181"), New System.Data.Common.DataColumnMapping("SCG1903", "SCG1903"), New System.Data.Common.DataColumnMapping("CAE16190", "CAE16190"), New System.Data.Common.DataColumnMapping("Jaguar2635", "Jaguar2635"), New System.Data.Common.DataColumnMapping("MMSAC2640", "MMSAC2640"), New System.Data.Common.DataColumnMapping("SuperUser", "SuperUser"), New System.Data.Common.DataColumnMapping("MITN108EW", "MITN108EW"), New System.Data.Common.DataColumnMapping("BAS16142", "BAS16142"), New System.Data.Common.DataColumnMapping("DRAKEN4610", "DRAKEN4610")})})
        Me.daEARRUsers.UpdateCommand = Me.SqlUpdateCommand1
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsEARRUsers
        Me.GridControl1.Location = New System.Drawing.Point(1, 61)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1290, 538)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colUsername, Me.colEmail, Me.colJaguarProgram, Me.colE6Program, Me.colSherpa, Me.colEnterEARR, Me.colJaguar16082, Me.colSignedName, Me.colReadOnly, Me.colCBP16033, Me.colJaguarOnly, Me.colRepetitiveSale, Me.colMIT192181, Me.colSCG1903, Me.colCAE16190, Me.colJaguar2635, Me.colMMSAC2640, Me.colSuperUser})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        Me.colUsername.Width = 224
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 1
        Me.colEmail.Width = 255
        '
        'colJaguarProgram
        '
        Me.colJaguarProgram.FieldName = "JaguarProgram"
        Me.colJaguarProgram.Name = "colJaguarProgram"
        Me.colJaguarProgram.Width = 90
        '
        'colE6Program
        '
        Me.colE6Program.FieldName = "E6Program"
        Me.colE6Program.Name = "colE6Program"
        Me.colE6Program.Width = 61
        '
        'colSherpa
        '
        Me.colSherpa.FieldName = "Sherpa"
        Me.colSherpa.Name = "colSherpa"
        Me.colSherpa.Width = 46
        '
        'colEnterEARR
        '
        Me.colEnterEARR.FieldName = "EnterEARR"
        Me.colEnterEARR.Name = "colEnterEARR"
        Me.colEnterEARR.Width = 64
        '
        'colJaguar16082
        '
        Me.colJaguar16082.FieldName = "Jaguar16082"
        Me.colJaguar16082.Name = "colJaguar16082"
        Me.colJaguar16082.Width = 71
        '
        'colSignedName
        '
        Me.colSignedName.FieldName = "SignedName"
        Me.colSignedName.Name = "colSignedName"
        Me.colSignedName.Width = 74
        '
        'colReadOnly
        '
        Me.colReadOnly.FieldName = "ReadOnly"
        Me.colReadOnly.Name = "colReadOnly"
        Me.colReadOnly.Width = 62
        '
        'colCBP16033
        '
        Me.colCBP16033.FieldName = "CBP16033"
        Me.colCBP16033.Name = "colCBP16033"
        Me.colCBP16033.Width = 58
        '
        'colJaguarOnly
        '
        Me.colJaguarOnly.FieldName = "JaguarOnly"
        Me.colJaguarOnly.Name = "colJaguarOnly"
        Me.colJaguarOnly.Width = 67
        '
        'colRepetitiveSale
        '
        Me.colRepetitiveSale.FieldName = "RepetitiveSale"
        Me.colRepetitiveSale.Name = "colRepetitiveSale"
        Me.colRepetitiveSale.Width = 80
        '
        'colMIT192181
        '
        Me.colMIT192181.FieldName = "MIT192181"
        Me.colMIT192181.Name = "colMIT192181"
        Me.colMIT192181.Width = 63
        '
        'colSCG1903
        '
        Me.colSCG1903.FieldName = "SCG1903"
        Me.colSCG1903.Name = "colSCG1903"
        Me.colSCG1903.Width = 58
        '
        'colCAE16190
        '
        Me.colCAE16190.FieldName = "CAE16190"
        Me.colCAE16190.Name = "colCAE16190"
        Me.colCAE16190.Width = 61
        '
        'colJaguar2635
        '
        Me.colJaguar2635.FieldName = "Jaguar2635"
        Me.colJaguar2635.Name = "colJaguar2635"
        Me.colJaguar2635.Width = 67
        '
        'colMMSAC2640
        '
        Me.colMMSAC2640.FieldName = "MMSAC2640"
        Me.colMMSAC2640.Name = "colMMSAC2640"
        Me.colMMSAC2640.Width = 70
        '
        'colSuperUser
        '
        Me.colSuperUser.FieldName = "SuperUser"
        Me.colSuperUser.Name = "colSuperUser"
        Me.colSuperUser.Visible = True
        Me.colSuperUser.VisibleIndex = 2
        Me.colSuperUser.Width = 63
        '
        'frmEARRUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 612)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "frmEARRUsers"
        Me.Text = "EARR Users"
        CType(Me.bsEARRUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEARRUsers1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUpdate As Button
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents daEARRUsers As SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents bsEARRUsers As BindingSource
    Friend WithEvents DsEARRUsers1 As dsEARRUsers
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsername As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJaguarProgram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colE6Program As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSherpa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnterEARR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJaguar16082 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignedName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReadOnly As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCBP16033 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJaguarOnly As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRepetitiveSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIT192181 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSCG1903 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCAE16190 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJaguar2635 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMMSAC2640 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSuperUser As DevExpress.XtraGrid.Columns.GridColumn
End Class
