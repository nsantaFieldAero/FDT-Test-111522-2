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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDeleteProject = New System.Windows.Forms.Button()
        Me.txtAddProjNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.optLegacy = New System.Windows.Forms.RadioButton()
        Me.optStd = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddProjDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSetPath = New System.Windows.Forms.Button()
        Me.btnTestPath = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboActive = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPDFFolder = New System.Windows.Forms.TextBox()
        Me.txtShortForm = New System.Windows.Forms.TextBox()
        Me.txtActNumber = New System.Windows.Forms.TextBox()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.txtProjectNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.btnSaveRolesNotifications = New System.Windows.Forms.Button()
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
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT RecordID, ProgramName, Active, Standard, Legacy, ProjectNumber, ACTNo, PDF" &
    "Folder, ShortForm, DocNumbering, ProductGroup, DocumentPath" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     tblProgram" &
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.VarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.VarChar, 0, "Active"), New System.Data.SqlClient.SqlParameter("@Standard", System.Data.SqlDbType.Bit, 0, "Standard"), New System.Data.SqlClient.SqlParameter("@Legacy", System.Data.SqlDbType.Bit, 0, "Legacy"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.Int, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@ACTNo", System.Data.SqlDbType.NVarChar, 0, "ACTNo"), New System.Data.SqlClient.SqlParameter("@PDFFolder", System.Data.SqlDbType.NVarChar, 0, "PDFFolder"), New System.Data.SqlClient.SqlParameter("@ShortForm", System.Data.SqlDbType.NVarChar, 0, "ShortForm"), New System.Data.SqlClient.SqlParameter("@DocNumbering", System.Data.SqlDbType.NVarChar, 0, "DocNumbering"), New System.Data.SqlClient.SqlParameter("@ProductGroup", System.Data.SqlDbType.NVarChar, 0, "ProductGroup"), New System.Data.SqlClient.SqlParameter("@DocumentPath", System.Data.SqlDbType.NVarChar, 0, "DocumentPath")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.VarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.VarChar, 0, "Active"), New System.Data.SqlClient.SqlParameter("@Standard", System.Data.SqlDbType.Bit, 0, "Standard"), New System.Data.SqlClient.SqlParameter("@Legacy", System.Data.SqlDbType.Bit, 0, "Legacy"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.Int, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@ACTNo", System.Data.SqlDbType.NVarChar, 0, "ACTNo"), New System.Data.SqlClient.SqlParameter("@PDFFolder", System.Data.SqlDbType.NVarChar, 0, "PDFFolder"), New System.Data.SqlClient.SqlParameter("@ShortForm", System.Data.SqlDbType.NVarChar, 0, "ShortForm"), New System.Data.SqlClient.SqlParameter("@DocNumbering", System.Data.SqlDbType.NVarChar, 0, "DocNumbering"), New System.Data.SqlClient.SqlParameter("@ProductGroup", System.Data.SqlDbType.NVarChar, 0, "ProductGroup"), New System.Data.SqlClient.SqlParameter("@DocumentPath", System.Data.SqlDbType.NVarChar, 0, "DocumentPath"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Standard", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Standard", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Standard", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Standard", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Legacy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Legacy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Legacy", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Legacy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ACTNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ACTNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ACTNo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ACTNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PDFFolder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PDFFolder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PDFFolder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PDFFolder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ShortForm", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ShortForm", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ShortForm", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShortForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocNumbering", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocNumbering", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocNumbering", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocNumbering", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductGroup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductGroup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductGroup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductGroup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocumentPath", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocumentPath", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocumentPath", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentPath", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Standard", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Standard", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Standard", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Standard", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Legacy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Legacy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Legacy", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Legacy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ACTNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ACTNo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ACTNo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ACTNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PDFFolder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PDFFolder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PDFFolder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PDFFolder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ShortForm", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ShortForm", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ShortForm", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShortForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocNumbering", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocNumbering", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocNumbering", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocNumbering", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductGroup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductGroup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductGroup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductGroup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocumentPath", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocumentPath", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocumentPath", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentPath", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblProgram", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("ProgramName", "ProgramName"), New System.Data.Common.DataColumnMapping("Active", "Active"), New System.Data.Common.DataColumnMapping("Standard", "Standard"), New System.Data.Common.DataColumnMapping("Legacy", "Legacy"), New System.Data.Common.DataColumnMapping("ProjectNumber", "ProjectNumber"), New System.Data.Common.DataColumnMapping("ACTNo", "ACTNo"), New System.Data.Common.DataColumnMapping("PDFFolder", "PDFFolder"), New System.Data.Common.DataColumnMapping("ShortForm", "ShortForm"), New System.Data.Common.DataColumnMapping("DocNumbering", "DocNumbering"), New System.Data.Common.DataColumnMapping("ProductGroup", "ProductGroup"), New System.Data.Common.DataColumnMapping("DocumentPath", "DocumentPath")})})
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
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.Location = New System.Drawing.Point(8, 23)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(408, 714)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colProgramName, Me.colActive, Me.colStandard, Me.colLegacy, Me.colProjectNumber, Me.colACTNo, Me.colPDFFolder, Me.colShortForm})
        Me.GridView1.DetailHeight = 431
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.MinWidth = 27
        Me.colRecordID.Name = "colRecordID"
        Me.colRecordID.Width = 100
        '
        'colProgramName
        '
        Me.colProgramName.FieldName = "ProgramName"
        Me.colProgramName.MinWidth = 27
        Me.colProgramName.Name = "colProgramName"
        Me.colProgramName.Visible = True
        Me.colProgramName.VisibleIndex = 1
        Me.colProgramName.Width = 311
        '
        'colActive
        '
        Me.colActive.FieldName = "Active"
        Me.colActive.MinWidth = 27
        Me.colActive.Name = "colActive"
        Me.colActive.Width = 100
        '
        'colStandard
        '
        Me.colStandard.FieldName = "Standard"
        Me.colStandard.MinWidth = 27
        Me.colStandard.Name = "colStandard"
        Me.colStandard.Width = 100
        '
        'colLegacy
        '
        Me.colLegacy.FieldName = "Legacy"
        Me.colLegacy.MinWidth = 27
        Me.colLegacy.Name = "colLegacy"
        Me.colLegacy.Width = 100
        '
        'colProjectNumber
        '
        Me.colProjectNumber.FieldName = "ProjectNumber"
        Me.colProjectNumber.MinWidth = 27
        Me.colProjectNumber.Name = "colProjectNumber"
        Me.colProjectNumber.Visible = True
        Me.colProjectNumber.VisibleIndex = 0
        Me.colProjectNumber.Width = 127
        '
        'colACTNo
        '
        Me.colACTNo.FieldName = "ACTNo"
        Me.colACTNo.MinWidth = 27
        Me.colACTNo.Name = "colACTNo"
        Me.colACTNo.Width = 100
        '
        'colPDFFolder
        '
        Me.colPDFFolder.FieldName = "PDFFolder"
        Me.colPDFFolder.MinWidth = 27
        Me.colPDFFolder.Name = "colPDFFolder"
        Me.colPDFFolder.Width = 100
        '
        'colShortForm
        '
        Me.colShortForm.FieldName = "ShortForm"
        Me.colShortForm.MinWidth = 27
        Me.colShortForm.Name = "colShortForm"
        Me.colShortForm.Width = 100
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.GridControl1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnAddNew)
        Me.GroupBox1.Controls.Add(Me.btnDeleteProject)
        Me.GroupBox1.Controls.Add(Me.txtAddProjNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.optLegacy)
        Me.GroupBox1.Controls.Add(Me.optStd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAddProjDesc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRecordID)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(429, 961)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Projects:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(4, 779)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(415, 6)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Label10"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(325, 911)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 28)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(224, 911)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(93, 28)
        Me.btnAddNew.TabIndex = 9
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnDeleteProject
        '
        Me.btnDeleteProject.Location = New System.Drawing.Point(209, 745)
        Me.btnDeleteProject.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteProject.Name = "btnDeleteProject"
        Me.btnDeleteProject.Size = New System.Drawing.Size(207, 28)
        Me.btnDeleteProject.TabIndex = 8
        Me.btnDeleteProject.Text = "Delete Selected Project Above"
        Me.btnDeleteProject.UseVisualStyleBackColor = True
        '
        'txtAddProjNo
        '
        Me.txtAddProjNo.Location = New System.Drawing.Point(128, 911)
        Me.txtAddProjNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddProjNo.Name = "txtAddProjNo"
        Me.txtAddProjNo.Size = New System.Drawing.Size(87, 22)
        Me.txtAddProjNo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 911)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Project #:"
        '
        'optLegacy
        '
        Me.optLegacy.AutoSize = True
        Me.optLegacy.Location = New System.Drawing.Point(128, 874)
        Me.optLegacy.Margin = New System.Windows.Forms.Padding(4)
        Me.optLegacy.Name = "optLegacy"
        Me.optLegacy.Size = New System.Drawing.Size(121, 21)
        Me.optLegacy.TabIndex = 5
        Me.optLegacy.TabStop = True
        Me.optLegacy.Text = "Legacy / FAEL"
        Me.optLegacy.UseVisualStyleBackColor = True
        '
        'optStd
        '
        Me.optStd.AutoSize = True
        Me.optStd.Location = New System.Drawing.Point(128, 846)
        Me.optStd.Margin = New System.Windows.Forms.Padding(4)
        Me.optStd.Name = "optStd"
        Me.optStd.Size = New System.Drawing.Size(137, 21)
        Me.optStd.TabIndex = 4
        Me.optStd.TabStop = True
        Me.optStd.Text = "Standard / FAWL"
        Me.optStd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 846)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Format:"
        '
        'txtAddProjDesc
        '
        Me.txtAddProjDesc.Location = New System.Drawing.Point(128, 796)
        Me.txtAddProjDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddProjDesc.Name = "txtAddProjDesc"
        Me.txtAddProjDesc.Size = New System.Drawing.Size(208, 22)
        Me.txtAddProjDesc.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 796)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "New Project:"
        '
        'txtRecordID
        '
        Me.txtRecordID.Location = New System.Drawing.Point(269, 415)
        Me.txtRecordID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(132, 22)
        Me.txtRecordID.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSetPath)
        Me.GroupBox2.Controls.Add(Me.btnTestPath)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtDirectory)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cboActive)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtPDFFolder)
        Me.GroupBox2.Controls.Add(Me.txtShortForm)
        Me.GroupBox2.Controls.Add(Me.txtActNumber)
        Me.GroupBox2.Controls.Add(Me.txtProjectName)
        Me.GroupBox2.Controls.Add(Me.txtProjectNumber)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(440, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1613, 208)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Project Details:"
        '
        'btnSetPath
        '
        Me.btnSetPath.Location = New System.Drawing.Point(1384, 112)
        Me.btnSetPath.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSetPath.Name = "btnSetPath"
        Me.btnSetPath.Size = New System.Drawing.Size(137, 28)
        Me.btnSetPath.TabIndex = 12
        Me.btnSetPath.Text = "Set Path"
        Me.btnSetPath.UseVisualStyleBackColor = True
        '
        'btnTestPath
        '
        Me.btnTestPath.Location = New System.Drawing.Point(1239, 112)
        Me.btnTestPath.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTestPath.Name = "btnTestPath"
        Me.btnTestPath.Size = New System.Drawing.Size(137, 28)
        Me.btnTestPath.TabIndex = 11
        Me.btnTestPath.Text = "Test Path"
        Me.btnTestPath.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(489, 161)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(572, 17)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Relative Path Required.  Example:  \\ken-resourcesan.fieldcorp.local\fileshares\f" &
    "ieldshare\"
        '
        'txtDirectory
        '
        Me.txtDirectory.Location = New System.Drawing.Point(493, 118)
        Me.txtDirectory.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(736, 22)
        Me.txtDirectory.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(295, 118)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(188, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Document Storage Location:"
        '
        'cboActive
        '
        Me.cboActive.FormattingEnabled = True
        Me.cboActive.Location = New System.Drawing.Point(1239, 32)
        Me.cboActive.Margin = New System.Windows.Forms.Padding(4)
        Me.cboActive.Name = "cboActive"
        Me.cboActive.Size = New System.Drawing.Size(160, 24)
        Me.cboActive.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1173, 33)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Active?"
        '
        'txtPDFFolder
        '
        Me.txtPDFFolder.Location = New System.Drawing.Point(133, 118)
        Me.txtPDFFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPDFFolder.Name = "txtPDFFolder"
        Me.txtPDFFolder.Size = New System.Drawing.Size(132, 22)
        Me.txtPDFFolder.TabIndex = 7
        '
        'txtShortForm
        '
        Me.txtShortForm.Location = New System.Drawing.Point(539, 78)
        Me.txtShortForm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShortForm.Name = "txtShortForm"
        Me.txtShortForm.Size = New System.Drawing.Size(132, 22)
        Me.txtShortForm.TabIndex = 6
        '
        'txtActNumber
        '
        Me.txtActNumber.Location = New System.Drawing.Point(369, 33)
        Me.txtActNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtActNumber.Name = "txtActNumber"
        Me.txtActNumber.Size = New System.Drawing.Size(132, 22)
        Me.txtActNumber.TabIndex = 5
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(133, 78)
        Me.txtProjectName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.ReadOnly = True
        Me.txtProjectName.Size = New System.Drawing.Size(307, 22)
        Me.txtProjectName.TabIndex = 4
        '
        'txtProjectNumber
        '
        Me.txtProjectNumber.Location = New System.Drawing.Point(105, 33)
        Me.txtProjectNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProjectNumber.Name = "txtProjectNumber"
        Me.txtProjectNumber.Size = New System.Drawing.Size(132, 22)
        Me.txtProjectNumber.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 118)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "PDF Folder:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(449, 78)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Short Form:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 78)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Project Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(307, 33)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ACT #:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Project #:"
        '
        'btnCertificationManager
        '
        Me.btnCertificationManager.Location = New System.Drawing.Point(1700, 898)
        Me.btnCertificationManager.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCertificationManager.Name = "btnCertificationManager"
        Me.btnCertificationManager.Size = New System.Drawing.Size(173, 41)
        Me.btnCertificationManager.TabIndex = 3
        Me.btnCertificationManager.Text = "Certification Manager"
        Me.btnCertificationManager.UseVisualStyleBackColor = True
        '
        'GridNotifications
        '
        Me.GridNotifications.DataSource = Me.bsNotifications
        Me.GridNotifications.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridNotifications.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridNotifications.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridNotifications.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridNotifications.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridNotifications.Location = New System.Drawing.Point(440, 219)
        Me.GridNotifications.MainView = Me.GridView2
        Me.GridNotifications.Margin = New System.Windows.Forms.Padding(4)
        Me.GridNotifications.Name = "GridNotifications"
        Me.GridNotifications.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3, Me.RepositoryItemComboBox4})
        Me.GridNotifications.Size = New System.Drawing.Size(1613, 522)
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordId1, Me.colProgram, Me.colName, Me.colUser, Me.colRole, Me.colEmail, Me.colActive1, Me.colGate0, Me.colGate1, Me.colGate2, Me.colGate3, Me.colGate4, Me.colGate5, Me.colGate6})
        Me.GridView2.DetailHeight = 431
        Me.GridView2.GridControl = Me.GridNotifications
        Me.GridView2.Name = "GridView2"
        '
        'colRecordId1
        '
        Me.colRecordId1.FieldName = "RecordId"
        Me.colRecordId1.MinWidth = 27
        Me.colRecordId1.Name = "colRecordId1"
        Me.colRecordId1.Visible = True
        Me.colRecordId1.VisibleIndex = 0
        Me.colRecordId1.Width = 45
        '
        'colProgram
        '
        Me.colProgram.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colProgram.FieldName = "Program"
        Me.colProgram.MinWidth = 27
        Me.colProgram.Name = "colProgram"
        Me.colProgram.Visible = True
        Me.colProgram.VisibleIndex = 1
        Me.colProgram.Width = 243
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colName
        '
        Me.colName.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colName.FieldName = "Name"
        Me.colName.MinWidth = 27
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 2
        Me.colName.Width = 153
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
        Me.colUser.MinWidth = 27
        Me.colUser.Name = "colUser"
        Me.colUser.Visible = True
        Me.colUser.VisibleIndex = 3
        Me.colUser.Width = 160
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
        Me.colRole.MinWidth = 27
        Me.colRole.Name = "colRole"
        Me.colRole.Visible = True
        Me.colRole.VisibleIndex = 4
        Me.colRole.Width = 159
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
        Me.colEmail.MinWidth = 27
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 5
        Me.colEmail.Width = 316
        '
        'colActive1
        '
        Me.colActive1.FieldName = "Active"
        Me.colActive1.MinWidth = 27
        Me.colActive1.Name = "colActive1"
        Me.colActive1.Visible = True
        Me.colActive1.VisibleIndex = 6
        Me.colActive1.Width = 55
        '
        'colGate0
        '
        Me.colGate0.FieldName = "Gate0"
        Me.colGate0.MinWidth = 27
        Me.colGate0.Name = "colGate0"
        Me.colGate0.Visible = True
        Me.colGate0.VisibleIndex = 7
        Me.colGate0.Width = 63
        '
        'colGate1
        '
        Me.colGate1.FieldName = "Gate1"
        Me.colGate1.MinWidth = 27
        Me.colGate1.Name = "colGate1"
        Me.colGate1.Visible = True
        Me.colGate1.VisibleIndex = 8
        Me.colGate1.Width = 60
        '
        'colGate2
        '
        Me.colGate2.FieldName = "Gate2"
        Me.colGate2.MinWidth = 27
        Me.colGate2.Name = "colGate2"
        Me.colGate2.Visible = True
        Me.colGate2.VisibleIndex = 9
        Me.colGate2.Width = 63
        '
        'colGate3
        '
        Me.colGate3.FieldName = "Gate3"
        Me.colGate3.MinWidth = 27
        Me.colGate3.Name = "colGate3"
        Me.colGate3.Visible = True
        Me.colGate3.VisibleIndex = 10
        Me.colGate3.Width = 56
        '
        'colGate4
        '
        Me.colGate4.FieldName = "Gate4"
        Me.colGate4.MinWidth = 27
        Me.colGate4.Name = "colGate4"
        Me.colGate4.Visible = True
        Me.colGate4.VisibleIndex = 11
        Me.colGate4.Width = 63
        '
        'colGate5
        '
        Me.colGate5.FieldName = "Gate5"
        Me.colGate5.MinWidth = 27
        Me.colGate5.Name = "colGate5"
        Me.colGate5.Visible = True
        Me.colGate5.VisibleIndex = 12
        Me.colGate5.Width = 52
        '
        'colGate6
        '
        Me.colGate6.FieldName = "Gate6"
        Me.colGate6.MinWidth = 27
        Me.colGate6.Name = "colGate6"
        Me.colGate6.Visible = True
        Me.colGate6.VisibleIndex = 13
        Me.colGate6.Width = 103
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        RecordId, Program, Name, [User], Role, Email, Active, Gate0, Gate1," &
    " Gate2, Gate3, Gate4, Gate5, Gate6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblNotificationsGroups"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 0, "Name"), New System.Data.SqlClient.SqlParameter("@User", System.Data.SqlDbType.NVarChar, 0, "User"), New System.Data.SqlClient.SqlParameter("@Role", System.Data.SqlDbType.NVarChar, 0, "Role"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.Bit, 0, "Active"), New System.Data.SqlClient.SqlParameter("@Gate0", System.Data.SqlDbType.Bit, 0, "Gate0"), New System.Data.SqlClient.SqlParameter("@Gate1", System.Data.SqlDbType.Bit, 0, "Gate1"), New System.Data.SqlClient.SqlParameter("@Gate2", System.Data.SqlDbType.Bit, 0, "Gate2"), New System.Data.SqlClient.SqlParameter("@Gate3", System.Data.SqlDbType.Bit, 0, "Gate3"), New System.Data.SqlClient.SqlParameter("@Gate4", System.Data.SqlDbType.Bit, 0, "Gate4"), New System.Data.SqlClient.SqlParameter("@Gate5", System.Data.SqlDbType.Bit, 0, "Gate5"), New System.Data.SqlClient.SqlParameter("@Gate6", System.Data.SqlDbType.Bit, 0, "Gate6")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 0, "Name"), New System.Data.SqlClient.SqlParameter("@User", System.Data.SqlDbType.NVarChar, 0, "User"), New System.Data.SqlClient.SqlParameter("@Role", System.Data.SqlDbType.NVarChar, 0, "Role"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.Bit, 0, "Active"), New System.Data.SqlClient.SqlParameter("@Gate0", System.Data.SqlDbType.Bit, 0, "Gate0"), New System.Data.SqlClient.SqlParameter("@Gate1", System.Data.SqlDbType.Bit, 0, "Gate1"), New System.Data.SqlClient.SqlParameter("@Gate2", System.Data.SqlDbType.Bit, 0, "Gate2"), New System.Data.SqlClient.SqlParameter("@Gate3", System.Data.SqlDbType.Bit, 0, "Gate3"), New System.Data.SqlClient.SqlParameter("@Gate4", System.Data.SqlDbType.Bit, 0, "Gate4"), New System.Data.SqlClient.SqlParameter("@Gate5", System.Data.SqlDbType.Bit, 0, "Gate5"), New System.Data.SqlClient.SqlParameter("@Gate6", System.Data.SqlDbType.Bit, 0, "Gate6"), New System.Data.SqlClient.SqlParameter("@Original_RecordId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordId", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_User", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "User", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_User", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "User", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Role", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Role", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Role", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Role", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate0", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate0", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate0", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate0", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate1", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate2", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate3", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate4", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate5", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate5", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate6", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate6", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordId", System.Data.SqlDbType.Int, 4, "RecordId")})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordId", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_User", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "User", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_User", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "User", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Role", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Role", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Role", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Role", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate0", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate0", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate0", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate0", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate1", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate2", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate3", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate4", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate5", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate5", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Gate6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gate6", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Gate6", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gate6", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblNotificationsGroups", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordId", "RecordId"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("User", "User"), New System.Data.Common.DataColumnMapping("Role", "Role"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Active", "Active"), New System.Data.Common.DataColumnMapping("Gate0", "Gate0"), New System.Data.Common.DataColumnMapping("Gate1", "Gate1"), New System.Data.Common.DataColumnMapping("Gate2", "Gate2"), New System.Data.Common.DataColumnMapping("Gate3", "Gate3"), New System.Data.Common.DataColumnMapping("Gate4", "Gate4"), New System.Data.Common.DataColumnMapping("Gate5", "Gate5"), New System.Data.Common.DataColumnMapping("Gate6", "Gate6")})})
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
        Me.btnSaveRolesNotifications.Location = New System.Drawing.Point(1848, 742)
        Me.btnSaveRolesNotifications.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveRolesNotifications.Name = "btnSaveRolesNotifications"
        Me.btnSaveRolesNotifications.Size = New System.Drawing.Size(205, 41)
        Me.btnSaveRolesNotifications.TabIndex = 5
        Me.btnSaveRolesNotifications.Text = "Save Roles/Notifications"
        Me.btnSaveRolesNotifications.UseVisualStyleBackColor = True
        '
        'Programs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 951)
        Me.Controls.Add(Me.btnSaveRolesNotifications)
        Me.Controls.Add(Me.GridNotifications)
        Me.Controls.Add(Me.btnCertificationManager)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnDeleteProject As Button
    Friend WithEvents txtAddProjNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents optLegacy As RadioButton
    Friend WithEvents optStd As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddProjDesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboActive As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPDFFolder As TextBox
    Friend WithEvents txtShortForm As TextBox
    Friend WithEvents txtActNumber As TextBox
    Friend WithEvents txtProjectName As TextBox
    Friend WithEvents txtProjectNumber As TextBox
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
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDirectory As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSetPath As Button
    Friend WithEvents btnTestPath As Button
End Class
