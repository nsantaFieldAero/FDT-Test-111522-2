<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Programs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Programs))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsPrograms = New EngDesignTracking.dsPrograms()
        Me.bsPrograms = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStandard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLegacy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACTNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPDFFolder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShortForm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDeleteProgram = New System.Windows.Forms.Button()
        Me.txtAddProgramNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddProgramDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSaveProgram = New System.Windows.Forms.Button()
        Me.cboActive = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtShortForm = New System.Windows.Forms.TextBox()
        Me.txtProgramName = New System.Windows.Forms.TextBox()
        Me.txtProgramNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCertificationManager = New System.Windows.Forms.Button()
        Me.GridNotifications = New DevExpress.XtraGrid.GridControl()
        Me.bsNotifications = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNotificationsGroups1 = New EngDesignTracking.dsNotificationsGroups()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colRole = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActive1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGate0 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGate6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRedlines = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.btnSaveRolesNotifications = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.gridProjectsOfProgram = New DevExpress.XtraGrid.GridControl()
        Me.bsProjectsOfProgram = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProjectsOfProgram1 = New EngDesignTracking.dsProjectsOfProgram()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox5 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colProjectNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox6 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
        Me.btnSaveProject = New System.Windows.Forms.Button()
        Me.btnDeleteProject = New System.Windows.Forms.Button()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.GridExport = New DevExpress.XtraGrid.GridControl()
        Me.bsExport = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExport1 = New EngDesignTracking.dsExport()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectNumber2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlConnection4 = New System.Data.SqlClient.SqlConnection()
        CType(Me.DsPrograms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPrograms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNotificationsGroups1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProjectsOfProgram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProjectsOfProgram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProjectsOfProgram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        RecordID, ProgramName, Active, Standard, Legacy, ProjectNumber, ACT" &
    "No, PDFFolder, ShortForm, DocNumbering, ProductGroup" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblProgram" &
    ""
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.VarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.VarChar, 0, "Active"), New System.Data.SqlClient.SqlParameter("@Standard", System.Data.SqlDbType.Bit, 0, "Standard"), New System.Data.SqlClient.SqlParameter("@Legacy", System.Data.SqlDbType.Bit, 0, "Legacy"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.Int, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@ACTNo", System.Data.SqlDbType.NVarChar, 0, "ACTNo"), New System.Data.SqlClient.SqlParameter("@PDFFolder", System.Data.SqlDbType.NVarChar, 0, "PDFFolder"), New System.Data.SqlClient.SqlParameter("@ShortForm", System.Data.SqlDbType.NVarChar, 0, "ShortForm"), New System.Data.SqlClient.SqlParameter("@DocNumbering", System.Data.SqlDbType.NVarChar, 0, "DocNumbering"), New System.Data.SqlClient.SqlParameter("@ProductGroup", System.Data.SqlDbType.NVarChar, 0, "ProductGroup")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.VarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.VarChar, 0, "Active"), New System.Data.SqlClient.SqlParameter("@Standard", System.Data.SqlDbType.Bit, 0, "Standard"), New System.Data.SqlClient.SqlParameter("@Legacy", System.Data.SqlDbType.Bit, 0, "Legacy"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.Int, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@ACTNo", System.Data.SqlDbType.NVarChar, 0, "ACTNo"), New System.Data.SqlClient.SqlParameter("@PDFFolder", System.Data.SqlDbType.NVarChar, 0, "PDFFolder"), New System.Data.SqlClient.SqlParameter("@ShortForm", System.Data.SqlDbType.NVarChar, 0, "ShortForm"), New System.Data.SqlClient.SqlParameter("@DocNumbering", System.Data.SqlDbType.NVarChar, 0, "DocNumbering"), New System.Data.SqlClient.SqlParameter("@ProductGroup", System.Data.SqlDbType.NVarChar, 0, "ProductGroup"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Standard", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Standard", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Standard", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Standard", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Legacy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Legacy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Legacy", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Legacy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ACTNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ACTNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ACTNo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ACTNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PDFFolder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PDFFolder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PDFFolder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PDFFolder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ShortForm", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ShortForm", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ShortForm", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShortForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocNumbering", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocNumbering", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocNumbering", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocNumbering", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductGroup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductGroup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductGroup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductGroup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Standard", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Standard", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Standard", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Standard", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Legacy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Legacy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Legacy", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Legacy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ACTNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ACTNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ACTNo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ACTNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PDFFolder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PDFFolder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PDFFolder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PDFFolder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ShortForm", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ShortForm", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ShortForm", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShortForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocNumbering", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocNumbering", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocNumbering", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocNumbering", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductGroup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductGroup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductGroup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductGroup", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblProgram", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("ProgramName", "ProgramName"), New System.Data.Common.DataColumnMapping("Active", "Active"), New System.Data.Common.DataColumnMapping("Standard", "Standard"), New System.Data.Common.DataColumnMapping("Legacy", "Legacy"), New System.Data.Common.DataColumnMapping("ProjectNumber", "ProjectNumber"), New System.Data.Common.DataColumnMapping("ACTNo", "ACTNo"), New System.Data.Common.DataColumnMapping("PDFFolder", "PDFFolder"), New System.Data.Common.DataColumnMapping("ShortForm", "ShortForm"), New System.Data.Common.DataColumnMapping("DocNumbering", "DocNumbering"), New System.Data.Common.DataColumnMapping("ProductGroup", "ProductGroup")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DsPrograms
        '
        Me.DsPrograms.DataSetName = "dsPrograms"
        Me.DsPrograms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsPrograms
        '
        Me.bsPrograms.DataMember = "tblProgram"
        Me.bsPrograms.DataSource = Me.DsPrograms
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsPrograms
        Me.GridControl1.Location = New System.Drawing.Point(6, 19)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(306, 663)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colProgramName, Me.colActive, Me.colStandard, Me.colLegacy, Me.colProjectNumber, Me.colACTNo, Me.colPDFFolder, Me.colShortForm})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.Name = "colRecordID"
        '
        'colProgramName
        '
        Me.colProgramName.FieldName = "ProgramName"
        Me.colProgramName.Name = "colProgramName"
        Me.colProgramName.Visible = True
        Me.colProgramName.VisibleIndex = 1
        Me.colProgramName.Width = 233
        '
        'colActive
        '
        Me.colActive.FieldName = "Active"
        Me.colActive.Name = "colActive"
        '
        'colStandard
        '
        Me.colStandard.FieldName = "Standard"
        Me.colStandard.Name = "colStandard"
        '
        'colLegacy
        '
        Me.colLegacy.FieldName = "Legacy"
        Me.colLegacy.Name = "colLegacy"
        '
        'colProjectNumber
        '
        Me.colProjectNumber.Caption = "Program Number"
        Me.colProjectNumber.FieldName = "ProjectNumber"
        Me.colProjectNumber.Name = "colProjectNumber"
        Me.colProjectNumber.Visible = True
        Me.colProjectNumber.VisibleIndex = 0
        Me.colProjectNumber.Width = 95
        '
        'colACTNo
        '
        Me.colACTNo.FieldName = "ACTNo"
        Me.colACTNo.Name = "colACTNo"
        '
        'colPDFFolder
        '
        Me.colPDFFolder.FieldName = "PDFFolder"
        Me.colPDFFolder.Name = "colPDFFolder"
        '
        'colShortForm
        '
        Me.colShortForm.FieldName = "ShortForm"
        Me.colShortForm.Name = "colShortForm"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.GridControl1)
        Me.GroupBox1.Controls.Add(Me.btnAddNew)
        Me.GroupBox1.Controls.Add(Me.btnDeleteProgram)
        Me.GroupBox1.Controls.Add(Me.txtAddProgramNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAddProgramDesc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRecordID)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 806)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Programs:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(249, 777)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(70, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(3, 728)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(311, 5)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Label10"
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(173, 777)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(70, 23)
        Me.btnAddNew.TabIndex = 9
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnDeleteProgram
        '
        Me.btnDeleteProgram.Location = New System.Drawing.Point(134, 688)
        Me.btnDeleteProgram.Name = "btnDeleteProgram"
        Me.btnDeleteProgram.Size = New System.Drawing.Size(180, 23)
        Me.btnDeleteProgram.TabIndex = 8
        Me.btnDeleteProgram.Text = "Delete Selected Program Above"
        Me.btnDeleteProgram.UseVisualStyleBackColor = True
        '
        'txtAddProgramNo
        '
        Me.txtAddProgramNo.Location = New System.Drawing.Point(86, 776)
        Me.txtAddProgramNo.Name = "txtAddProgramNo"
        Me.txtAddProgramNo.Size = New System.Drawing.Size(81, 20)
        Me.txtAddProgramNo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 777)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ACT #:"
        '
        'txtAddProgramDesc
        '
        Me.txtAddProgramDesc.Location = New System.Drawing.Point(86, 751)
        Me.txtAddProgramDesc.Name = "txtAddProgramDesc"
        Me.txtAddProgramDesc.Size = New System.Drawing.Size(236, 20)
        Me.txtAddProgramDesc.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 751)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "New Program:"
        '
        'txtRecordID
        '
        Me.txtRecordID.Location = New System.Drawing.Point(202, 337)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(100, 20)
        Me.txtRecordID.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSaveProgram)
        Me.GroupBox2.Controls.Add(Me.cboActive)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtShortForm)
        Me.GroupBox2.Controls.Add(Me.txtProgramName)
        Me.GroupBox2.Controls.Add(Me.txtProgramNumber)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(330, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1092, 128)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Program Details:"
        '
        'btnSaveProgram
        '
        Me.btnSaveProgram.Location = New System.Drawing.Point(23, 98)
        Me.btnSaveProgram.Name = "btnSaveProgram"
        Me.btnSaveProgram.Size = New System.Drawing.Size(118, 23)
        Me.btnSaveProgram.TabIndex = 8
        Me.btnSaveProgram.Text = "Save Changes"
        Me.btnSaveProgram.UseVisualStyleBackColor = True
        '
        'cboActive
        '
        Me.cboActive.FormattingEnabled = True
        Me.cboActive.Items.AddRange(New Object() {"True", "False"})
        Me.cboActive.Location = New System.Drawing.Point(929, 26)
        Me.cboActive.Name = "cboActive"
        Me.cboActive.Size = New System.Drawing.Size(121, 21)
        Me.cboActive.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(880, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Active?"
        '
        'txtShortForm
        '
        Me.txtShortForm.Location = New System.Drawing.Point(418, 63)
        Me.txtShortForm.Name = "txtShortForm"
        Me.txtShortForm.Size = New System.Drawing.Size(176, 20)
        Me.txtShortForm.TabIndex = 6
        '
        'txtProgramName
        '
        Me.txtProgramName.Location = New System.Drawing.Point(100, 63)
        Me.txtProgramName.Name = "txtProgramName"
        Me.txtProgramName.Size = New System.Drawing.Size(231, 20)
        Me.txtProgramName.TabIndex = 4
        '
        'txtProgramNumber
        '
        Me.txtProgramNumber.Location = New System.Drawing.Point(100, 26)
        Me.txtProgramNumber.Name = "txtProgramNumber"
        Me.txtProgramNumber.Size = New System.Drawing.Size(231, 20)
        Me.txtProgramNumber.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(341, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Short Form:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Program Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ACT #:"
        '
        'btnCertificationManager
        '
        Me.btnCertificationManager.Location = New System.Drawing.Point(937, 766)
        Me.btnCertificationManager.Name = "btnCertificationManager"
        Me.btnCertificationManager.Size = New System.Drawing.Size(154, 33)
        Me.btnCertificationManager.TabIndex = 3
        Me.btnCertificationManager.Text = "Certification Manager"
        Me.btnCertificationManager.UseVisualStyleBackColor = True
        Me.btnCertificationManager.Visible = False
        '
        'GridNotifications
        '
        Me.GridNotifications.DataSource = Me.bsNotifications
        Me.GridNotifications.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridNotifications.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridNotifications.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridNotifications.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridNotifications.Location = New System.Drawing.Point(622, 152)
        Me.GridNotifications.MainView = Me.GridView2
        Me.GridNotifications.Name = "GridNotifications"
        Me.GridNotifications.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3, Me.RepositoryItemComboBox4})
        Me.GridNotifications.Size = New System.Drawing.Size(928, 450)
        Me.GridNotifications.TabIndex = 4
        Me.GridNotifications.UseEmbeddedNavigator = True
        Me.GridNotifications.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bsNotifications
        '
        Me.bsNotifications.DataMember = "tblNotificationsGroups"
        Me.bsNotifications.DataSource = Me.DsNotificationsGroups1
        '
        'DsNotificationsGroups1
        '
        Me.DsNotificationsGroups1.DataSetName = "dsNotificationsGroups"
        Me.DsNotificationsGroups1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordId1, Me.colProgram, Me.colName, Me.colUser, Me.colRole, Me.colEmail, Me.colActive1, Me.colGate0, Me.colGate1, Me.colGate2, Me.colGate3, Me.colGate4, Me.colGate5, Me.colGate6, Me.colRedlines})
        Me.GridView2.GridControl = Me.GridNotifications
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colRecordId1
        '
        Me.colRecordId1.FieldName = "RecordId"
        Me.colRecordId1.Name = "colRecordId1"
        Me.colRecordId1.Visible = True
        Me.colRecordId1.VisibleIndex = 0
        Me.colRecordId1.Width = 20
        '
        'colProgram
        '
        Me.colProgram.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colProgram.FieldName = "Program"
        Me.colProgram.Name = "colProgram"
        Me.colProgram.Visible = True
        Me.colProgram.VisibleIndex = 1
        Me.colProgram.Width = 124
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.ReadOnly = True
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colName
        '
        Me.colName.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 2
        Me.colName.Width = 114
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        Me.RepositoryItemComboBox2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colUser
        '
        Me.colUser.ColumnEdit = Me.RepositoryItemComboBox3
        Me.colUser.FieldName = "User"
        Me.colUser.Name = "colUser"
        Me.colUser.Visible = True
        Me.colUser.VisibleIndex = 3
        Me.colUser.Width = 82
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        Me.RepositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colRole
        '
        Me.colRole.ColumnEdit = Me.RepositoryItemComboBox4
        Me.colRole.FieldName = "Role"
        Me.colRole.Name = "colRole"
        Me.colRole.Visible = True
        Me.colRole.VisibleIndex = 4
        Me.colRole.Width = 99
        '
        'RepositoryItemComboBox4
        '
        Me.RepositoryItemComboBox4.AutoHeight = False
        Me.RepositoryItemComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox4.Name = "RepositoryItemComboBox4"
        Me.RepositoryItemComboBox4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 5
        Me.colEmail.Width = 83
        '
        'colActive1
        '
        Me.colActive1.FieldName = "Active"
        Me.colActive1.Name = "colActive1"
        Me.colActive1.Visible = True
        Me.colActive1.VisibleIndex = 7
        Me.colActive1.Width = 40
        '
        'colGate0
        '
        Me.colGate0.FieldName = "Gate0"
        Me.colGate0.Name = "colGate0"
        Me.colGate0.Visible = True
        Me.colGate0.VisibleIndex = 8
        Me.colGate0.Width = 38
        '
        'colGate1
        '
        Me.colGate1.FieldName = "Gate1"
        Me.colGate1.Name = "colGate1"
        Me.colGate1.Visible = True
        Me.colGate1.VisibleIndex = 9
        Me.colGate1.Width = 40
        '
        'colGate2
        '
        Me.colGate2.FieldName = "Gate2"
        Me.colGate2.Name = "colGate2"
        Me.colGate2.Visible = True
        Me.colGate2.VisibleIndex = 10
        Me.colGate2.Width = 39
        '
        'colGate3
        '
        Me.colGate3.FieldName = "Gate3"
        Me.colGate3.Name = "colGate3"
        Me.colGate3.Visible = True
        Me.colGate3.VisibleIndex = 11
        Me.colGate3.Width = 38
        '
        'colGate4
        '
        Me.colGate4.FieldName = "Gate4"
        Me.colGate4.Name = "colGate4"
        Me.colGate4.Visible = True
        Me.colGate4.VisibleIndex = 12
        Me.colGate4.Width = 39
        '
        'colGate5
        '
        Me.colGate5.FieldName = "Gate5"
        Me.colGate5.Name = "colGate5"
        Me.colGate5.Visible = True
        Me.colGate5.VisibleIndex = 13
        Me.colGate5.Width = 43
        '
        'colGate6
        '
        Me.colGate6.FieldName = "Gate6"
        Me.colGate6.Name = "colGate6"
        Me.colGate6.Visible = True
        Me.colGate6.VisibleIndex = 14
        Me.colGate6.Width = 62
        '
        'colRedlines
        '
        Me.colRedlines.Caption = "Redlines"
        Me.colRedlines.FieldName = "Redline"
        Me.colRedlines.Name = "colRedlines"
        Me.colRedlines.Visible = True
        Me.colRedlines.VisibleIndex = 6
        Me.colRedlines.Width = 49
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        RecordId, Program, Name, [User], Role, Email, Active, Gate0, Gate1," &
    " Gate2, Gate3, Gate4, Gate5, Gate6, Redline" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblNotificationsGro" &
    "ups"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 0, "Name"), New System.Data.SqlClient.SqlParameter("@User", System.Data.SqlDbType.NVarChar, 0, "User"), New System.Data.SqlClient.SqlParameter("@Role", System.Data.SqlDbType.NVarChar, 0, "Role"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.Bit, 0, "Active"), New System.Data.SqlClient.SqlParameter("@Gate0", System.Data.SqlDbType.Bit, 0, "Gate0"), New System.Data.SqlClient.SqlParameter("@Gate1", System.Data.SqlDbType.Bit, 0, "Gate1"), New System.Data.SqlClient.SqlParameter("@Gate2", System.Data.SqlDbType.Bit, 0, "Gate2"), New System.Data.SqlClient.SqlParameter("@Gate3", System.Data.SqlDbType.Bit, 0, "Gate3"), New System.Data.SqlClient.SqlParameter("@Gate4", System.Data.SqlDbType.Bit, 0, "Gate4"), New System.Data.SqlClient.SqlParameter("@Gate5", System.Data.SqlDbType.Bit, 0, "Gate5"), New System.Data.SqlClient.SqlParameter("@Gate6", System.Data.SqlDbType.Bit, 0, "Gate6"), New System.Data.SqlClient.SqlParameter("@Redline", System.Data.SqlDbType.Bit, 0, "Redline")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 0, "Name"), New System.Data.SqlClient.SqlParameter("@User", System.Data.SqlDbType.NVarChar, 0, "User"), New System.Data.SqlClient.SqlParameter("@Role", System.Data.SqlDbType.NVarChar, 0, "Role"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.Bit, 0, "Active"), New System.Data.SqlClient.SqlParameter("@Gate0", System.Data.SqlDbType.Bit, 0, "Gate0"), New System.Data.SqlClient.SqlParameter("@Gate1", System.Data.SqlDbType.Bit, 0, "Gate1"), New System.Data.SqlClient.SqlParameter("@Gate2", System.Data.SqlDbType.Bit, 0, "Gate2"), New System.Data.SqlClient.SqlParameter("@Gate3", System.Data.SqlDbType.Bit, 0, "Gate3"), New System.Data.SqlClient.SqlParameter("@Gate4", System.Data.SqlDbType.Bit, 0, "Gate4"), New System.Data.SqlClient.SqlParameter("@Gate5", System.Data.SqlDbType.Bit, 0, "Gate5"), New System.Data.SqlClient.SqlParameter("@Gate6", System.Data.SqlDbType.Bit, 0, "Gate6"), New System.Data.SqlClient.SqlParameter("@Redline", System.Data.SqlDbType.Bit, 0, "Redline"), New System.Data.SqlClient.SqlParameter("@Original_RecordId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordId", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_User", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "User", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_User", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "User", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Role", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Role", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Role", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Role", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate0", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate0", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate0", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate0", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate1", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate2", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate3", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate4", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate5", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate5", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate6", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate6", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Redline", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Redline", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Redline", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Redline", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordId", System.Data.SqlDbType.Int, 4, "RecordId")})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordId", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_User", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "User", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_User", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "User", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Role", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Role", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Role", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Role", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate0", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate0", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate0", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate0", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate1", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate2", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate3", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate4", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate5", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate5", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate6", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate6", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Redline", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Redline", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Redline", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Redline", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblNotificationsGroups", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordId", "RecordId"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("User", "User"), New System.Data.Common.DataColumnMapping("Role", "Role"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Active", "Active"), New System.Data.Common.DataColumnMapping("Gate0", "Gate0"), New System.Data.Common.DataColumnMapping("Gate1", "Gate1"), New System.Data.Common.DataColumnMapping("Gate2", "Gate2"), New System.Data.Common.DataColumnMapping("Gate3", "Gate3"), New System.Data.Common.DataColumnMapping("Gate4", "Gate4"), New System.Data.Common.DataColumnMapping("Gate5", "Gate5"), New System.Data.Common.DataColumnMapping("Gate6", "Gate6"), New System.Data.Common.DataColumnMapping("Redline", "Redline")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'btnSaveRolesNotifications
        '
        Me.btnSaveRolesNotifications.Location = New System.Drawing.Point(648, 608)
        Me.btnSaveRolesNotifications.Name = "btnSaveRolesNotifications"
        Me.btnSaveRolesNotifications.Size = New System.Drawing.Size(154, 33)
        Me.btnSaveRolesNotifications.TabIndex = 5
        Me.btnSaveRolesNotifications.Text = "Save Roles/Notifications"
        Me.btnSaveRolesNotifications.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(648, 766)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(154, 33)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "Export to Excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'gridProjectsOfProgram
        '
        Me.gridProjectsOfProgram.DataSource = Me.bsProjectsOfProgram
        Me.gridProjectsOfProgram.Location = New System.Drawing.Point(331, 152)
        Me.gridProjectsOfProgram.MainView = Me.GridView3
        Me.gridProjectsOfProgram.Name = "gridProjectsOfProgram"
        Me.gridProjectsOfProgram.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox5, Me.RepositoryItemComboBox6})
        Me.gridProjectsOfProgram.Size = New System.Drawing.Size(285, 533)
        Me.gridProjectsOfProgram.TabIndex = 7
        Me.gridProjectsOfProgram.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'bsProjectsOfProgram
        '
        Me.bsProjectsOfProgram.DataMember = "tblProgram_Project"
        Me.bsProjectsOfProgram.DataSource = Me.DsProjectsOfProgram1
        '
        'DsProjectsOfProgram1
        '
        Me.DsProjectsOfProgram1.DataSetName = "dsProjectsOfProgram"
        Me.DsProjectsOfProgram1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID2, Me.colProjectName, Me.colProjectNumber1})
        Me.GridView3.GridControl = Me.gridProjectsOfProgram
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colRecordID2
        '
        Me.colRecordID2.FieldName = "RecordID"
        Me.colRecordID2.Name = "colRecordID2"
        '
        'colProjectName
        '
        Me.colProjectName.ColumnEdit = Me.RepositoryItemComboBox5
        Me.colProjectName.FieldName = "ProjectName"
        Me.colProjectName.Name = "colProjectName"
        Me.colProjectName.Visible = True
        Me.colProjectName.VisibleIndex = 1
        '
        'RepositoryItemComboBox5
        '
        Me.RepositoryItemComboBox5.AutoHeight = False
        Me.RepositoryItemComboBox5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox5.Name = "RepositoryItemComboBox5"
        Me.RepositoryItemComboBox5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colProjectNumber1
        '
        Me.colProjectNumber1.ColumnEdit = Me.RepositoryItemComboBox6
        Me.colProjectNumber1.FieldName = "ProjectNumber"
        Me.colProjectNumber1.Name = "colProjectNumber1"
        Me.colProjectNumber1.Visible = True
        Me.colProjectNumber1.VisibleIndex = 0
        '
        'RepositoryItemComboBox6
        '
        Me.RepositoryItemComboBox6.AutoHeight = False
        Me.RepositoryItemComboBox6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox6.Name = "RepositoryItemComboBox6"
        Me.RepositoryItemComboBox6.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT        RecordID, ProjectName, ProjectNumber" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblProgram_Pr" &
    "oject"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection3
        '
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=engdwgtest;Persist Security Info=" &
    "True;User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection3.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection3
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.NVarChar, 0, "ProjectName"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.NVarChar, 0, "ProjectNumber")})
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection3
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.NVarChar, 0, "ProjectName"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.NVarChar, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection3
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.DeleteCommand = Me.SqlDeleteCommand3
        Me.SqlDataAdapter3.InsertCommand = Me.SqlInsertCommand3
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblProgram_Project", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("ProjectName", "ProjectName"), New System.Data.Common.DataColumnMapping("ProjectNumber", "ProjectNumber")})})
        Me.SqlDataAdapter3.UpdateCommand = Me.SqlUpdateCommand3
        '
        'btnSaveProject
        '
        Me.btnSaveProject.Location = New System.Drawing.Point(331, 691)
        Me.btnSaveProject.Name = "btnSaveProject"
        Me.btnSaveProject.Size = New System.Drawing.Size(130, 23)
        Me.btnSaveProject.TabIndex = 8
        Me.btnSaveProject.Text = "Save Project"
        Me.btnSaveProject.UseVisualStyleBackColor = True
        '
        'btnDeleteProject
        '
        Me.btnDeleteProject.Location = New System.Drawing.Point(486, 691)
        Me.btnDeleteProject.Name = "btnDeleteProject"
        Me.btnDeleteProject.Size = New System.Drawing.Size(130, 23)
        Me.btnDeleteProject.TabIndex = 9
        Me.btnDeleteProject.Text = "Delete Selected Project"
        Me.btnDeleteProject.UseVisualStyleBackColor = True
        '
        'GridExport
        '
        Me.GridExport.DataSource = Me.bsExport
        Me.GridExport.Location = New System.Drawing.Point(622, 647)
        Me.GridExport.MainView = Me.GridView4
        Me.GridExport.Name = "GridExport"
        Me.GridExport.Size = New System.Drawing.Size(681, 113)
        Me.GridExport.TabIndex = 10
        Me.GridExport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        Me.GridExport.Visible = False
        '
        'bsExport
        '
        Me.bsExport.DataMember = "tblProgram_Project"
        Me.bsExport.DataSource = Me.DsExport1
        '
        'DsExport1
        '
        Me.DsExport1.DataSetName = "dsExport"
        Me.DsExport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID3, Me.colProgramNumber, Me.colProgramName1, Me.colProjectNumber2, Me.colProjectName1})
        Me.GridView4.GridControl = Me.GridExport
        Me.GridView4.Name = "GridView4"
        '
        'colRecordID3
        '
        Me.colRecordID3.FieldName = "RecordID"
        Me.colRecordID3.Name = "colRecordID3"
        '
        'colProgramNumber
        '
        Me.colProgramNumber.FieldName = "ProgramNumber"
        Me.colProgramNumber.Name = "colProgramNumber"
        Me.colProgramNumber.Visible = True
        Me.colProgramNumber.VisibleIndex = 0
        '
        'colProgramName1
        '
        Me.colProgramName1.FieldName = "ProgramName"
        Me.colProgramName1.Name = "colProgramName1"
        Me.colProgramName1.Visible = True
        Me.colProgramName1.VisibleIndex = 1
        '
        'colProjectNumber2
        '
        Me.colProjectNumber2.FieldName = "ProjectNumber"
        Me.colProjectNumber2.Name = "colProjectNumber2"
        Me.colProjectNumber2.Visible = True
        Me.colProjectNumber2.VisibleIndex = 2
        '
        'colProjectName1
        '
        Me.colProjectName1.FieldName = "ProjectName"
        Me.colProjectName1.Name = "colProjectName1"
        Me.colProjectName1.Visible = True
        Me.colProjectName1.VisibleIndex = 3
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT        RecordID,  ProgramNumber, ProgramName, ProjectNumber, ProjectName" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "FROM            tblProgram_Project" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Order By ProgramNumber, ProjectNumber"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection3
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection3
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProgramNumber", System.Data.SqlDbType.NVarChar, 0, "ProgramNumber"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.NVarChar, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.NVarChar, 0, "ProjectName")})
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection3
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProgramNumber", System.Data.SqlDbType.NVarChar, 0, "ProgramNumber"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.NVarChar, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.NVarChar, 0, "ProjectName"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection3
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.DeleteCommand = Me.SqlDeleteCommand4
        Me.SqlDataAdapter4.InsertCommand = Me.SqlInsertCommand4
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblProgram_Project", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("ProgramNumber", "ProgramNumber"), New System.Data.Common.DataColumnMapping("ProgramName", "ProgramName"), New System.Data.Common.DataColumnMapping("ProjectNumber", "ProjectNumber"), New System.Data.Common.DataColumnMapping("ProjectName", "ProjectName")})})
        Me.SqlDataAdapter4.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlConnection4
        '
        Me.SqlConnection4.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=engdwgtest;Persist Security Info=" &
    "True;User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection4.FireInfoMessageEventOnUserErrors = False
        '
        'Programs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1552, 811)
        Me.Controls.Add(Me.GridExport)
        Me.Controls.Add(Me.btnDeleteProject)
        Me.Controls.Add(Me.btnSaveProject)
        Me.Controls.Add(Me.gridProjectsOfProgram)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnSaveRolesNotifications)
        Me.Controls.Add(Me.GridNotifications)
        Me.Controls.Add(Me.btnCertificationManager)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Programs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programs"
        CType(Me.DsPrograms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPrograms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridNotifications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsNotifications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNotificationsGroups1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProjectsOfProgram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProjectsOfProgram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProjectsOfProgram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DsPrograms As dsPrograms
    Friend WithEvents bsPrograms As BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStandard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLegacy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACTNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPDFFolder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShortForm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnDeleteProgram As Button
    Friend WithEvents txtAddProgramNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddProgramDesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboActive As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtShortForm As TextBox
    Friend WithEvents txtProgramName As TextBox
    Friend WithEvents txtProgramNumber As TextBox
    Friend WithEvents txtRecordID As TextBox
    Friend WithEvents btnCertificationManager As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents GridNotifications As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecordId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRole As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActive1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGate0 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGate6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As SqlClient.SqlDataAdapter
    Friend WithEvents DsNotificationsGroups1 As dsNotificationsGroups
    Friend WithEvents bsNotifications As BindingSource
    Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
    Friend WithEvents btnSaveRolesNotifications As Button
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnSaveProgram As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents gridProjectsOfProgram As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection3 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter3 As SqlClient.SqlDataAdapter
    Friend WithEvents DsProjectsOfProgram1 As dsProjectsOfProgram
    Friend WithEvents bsProjectsOfProgram As BindingSource
    Friend WithEvents colRecordID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectNumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSaveProject As Button
    Friend WithEvents btnDeleteProject As Button
    Friend WithEvents RepositoryItemComboBox5 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents GridExport As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlSelectCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter4 As SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection4 As SqlClient.SqlConnection
    Friend WithEvents bsExport As BindingSource
    Friend WithEvents DsExport1 As dsExport
    Friend WithEvents colRecordID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectNumber2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox6 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colRedlines As DevExpress.XtraGrid.Columns.GridColumn
End Class
