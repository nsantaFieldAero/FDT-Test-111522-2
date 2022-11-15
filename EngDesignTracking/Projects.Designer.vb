<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Projects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Projects))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsProjects = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProjects1 = New EngDesignTracking.dsProjects()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocNumbering = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStandard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLegacy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPDFFolder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShortForm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDeleteProject = New System.Windows.Forms.Button()
        Me.txtAddProjNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddProjDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPDFFolder = New System.Windows.Forms.TextBox()
        Me.txtShortForm = New System.Windows.Forms.TextBox()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboProjectNumSave = New System.Windows.Forms.ComboBox()
        Me.cboProductGroupSave = New System.Windows.Forms.ComboBox()
        Me.cboDocNumberingSave = New System.Windows.Forms.ComboBox()
        Me.lblProductGroupSave = New System.Windows.Forms.Label()
        Me.lblDocNumberingSave = New System.Windows.Forms.Label()
        Me.btnSaveProject = New System.Windows.Forms.Button()
        Me.cboActive = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.bsSystems = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSystems1 = New EngDesignTracking.dsSystems()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colactive1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridAircrafts = New DevExpress.XtraGrid.GridControl()
        Me.bsAircrafts = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAircraftsProjectsScreen1 = New EngDesignTracking.dsAircraftsProjectsScreen()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAircraft = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colProgramName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.bsAircraftSerial = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAircraftSerial1 = New EngDesignTracking.dsAircraftSerial()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerialNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAircraft1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSaveSystems = New System.Windows.Forms.Button()
        Me.btnDeleteSystems = New System.Windows.Forms.Button()
        Me.btnDeleteAssociatedAircraft = New System.Windows.Forms.Button()
        Me.btnSaveAssociatedAircraft = New System.Windows.Forms.Button()
        Me.btnDeleteSerialNum = New System.Windows.Forms.Button()
        Me.btnSaveSerialNum = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtRecordIDSystems = New System.Windows.Forms.TextBox()
        Me.lstAssignedPrograms = New System.Windows.Forms.ListBox()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtRecordIDAircrafts = New System.Windows.Forms.TextBox()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtRecordIDSerial = New System.Windows.Forms.TextBox()
        Me.btnCertificationManager = New System.Windows.Forms.Button()
        Me.txtProjectNameBeforeSaveChanges = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProjects1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSystems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSystems1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAircrafts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAircrafts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAircraftsProjectsScreen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAircraftSerial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAircraftSerial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridControl1)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnAddNew)
        Me.GroupBox1.Controls.Add(Me.btnDeleteProject)
        Me.GroupBox1.Controls.Add(Me.txtAddProjNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAddProjDesc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRecordID)
        Me.GroupBox1.Controls.Add(Me.txtProjectNameBeforeSaveChanges)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 799)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Projects"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsProjects
        Me.GridControl1.Location = New System.Drawing.Point(6, 19)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(319, 662)
        Me.GridControl1.TabIndex = 21
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsProjects
        '
        Me.bsProjects.DataMember = "tblProjects"
        Me.bsProjects.DataSource = Me.DsProjects1
        '
        'DsProjects1
        '
        Me.DsProjects1.DataSetName = "dsProjects"
        Me.DsProjects1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colProjectName, Me.colProjectNumber, Me.colProgramName, Me.colActive, Me.colDocNumbering, Me.colProductGroup, Me.colStandard, Me.colLegacy, Me.colPDFFolder, Me.colShortForm})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.Name = "colRecordID"
        '
        'colProjectName
        '
        Me.colProjectName.FieldName = "ProjectName"
        Me.colProjectName.Name = "colProjectName"
        Me.colProjectName.Visible = True
        Me.colProjectName.VisibleIndex = 1
        Me.colProjectName.Width = 218
        '
        'colProjectNumber
        '
        Me.colProjectNumber.FieldName = "ProjectNumber"
        Me.colProjectNumber.Name = "colProjectNumber"
        Me.colProjectNumber.Visible = True
        Me.colProjectNumber.VisibleIndex = 0
        Me.colProjectNumber.Width = 83
        '
        'colProgramName
        '
        Me.colProgramName.FieldName = "ProgramName"
        Me.colProgramName.Name = "colProgramName"
        '
        'colActive
        '
        Me.colActive.FieldName = "Active"
        Me.colActive.Name = "colActive"
        '
        'colDocNumbering
        '
        Me.colDocNumbering.FieldName = "DocNumbering"
        Me.colDocNumbering.Name = "colDocNumbering"
        '
        'colProductGroup
        '
        Me.colProductGroup.FieldName = "ProductGroup"
        Me.colProductGroup.Name = "colProductGroup"
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
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(254, 771)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(70, 23)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 733)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(311, 5)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Label10"
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(178, 771)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(70, 23)
        Me.btnAddNew.TabIndex = 18
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnDeleteProject
        '
        Me.btnDeleteProject.Location = New System.Drawing.Point(152, 687)
        Me.btnDeleteProject.Name = "btnDeleteProject"
        Me.btnDeleteProject.Size = New System.Drawing.Size(155, 23)
        Me.btnDeleteProject.TabIndex = 17
        Me.btnDeleteProject.Text = "Delete Selected Project Above"
        Me.btnDeleteProject.UseVisualStyleBackColor = True
        '
        'txtAddProjNo
        '
        Me.txtAddProjNo.Location = New System.Drawing.Point(74, 773)
        Me.txtAddProjNo.Name = "txtAddProjNo"
        Me.txtAddProjNo.Size = New System.Drawing.Size(98, 20)
        Me.txtAddProjNo.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 773)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Project #:"
        '
        'txtAddProjDesc
        '
        Me.txtAddProjDesc.Location = New System.Drawing.Point(115, 742)
        Me.txtAddProjDesc.Name = "txtAddProjDesc"
        Me.txtAddProjDesc.Size = New System.Drawing.Size(209, 20)
        Me.txtAddProjDesc.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 742)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "New Project Desc:"
        '
        'txtRecordID
        '
        Me.txtRecordID.Location = New System.Drawing.Point(115, 397)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(100, 20)
        Me.txtRecordID.TabIndex = 22
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
        'txtPDFFolder
        '
        Me.txtPDFFolder.Location = New System.Drawing.Point(100, 78)
        Me.txtPDFFolder.Name = "txtPDFFolder"
        Me.txtPDFFolder.Size = New System.Drawing.Size(231, 20)
        Me.txtPDFFolder.TabIndex = 7
        '
        'txtShortForm
        '
        Me.txtShortForm.Location = New System.Drawing.Point(418, 50)
        Me.txtShortForm.Name = "txtShortForm"
        Me.txtShortForm.Size = New System.Drawing.Size(176, 20)
        Me.txtShortForm.TabIndex = 6
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(100, 50)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(231, 20)
        Me.txtProjectName.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboProjectNumSave)
        Me.GroupBox2.Controls.Add(Me.cboProductGroupSave)
        Me.GroupBox2.Controls.Add(Me.cboDocNumberingSave)
        Me.GroupBox2.Controls.Add(Me.lblProductGroupSave)
        Me.GroupBox2.Controls.Add(Me.lblDocNumberingSave)
        Me.GroupBox2.Controls.Add(Me.btnSaveProject)
        Me.GroupBox2.Controls.Add(Me.cboActive)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtPDFFolder)
        Me.GroupBox2.Controls.Add(Me.txtShortForm)
        Me.GroupBox2.Controls.Add(Me.txtProjectName)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(340, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1092, 161)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Project Details:"
        '
        'cboProjectNumSave
        '
        Me.cboProjectNumSave.FormattingEnabled = True
        Me.cboProjectNumSave.Location = New System.Drawing.Point(100, 19)
        Me.cboProjectNumSave.Name = "cboProjectNumSave"
        Me.cboProjectNumSave.Size = New System.Drawing.Size(231, 21)
        Me.cboProjectNumSave.TabIndex = 17
        '
        'cboProductGroupSave
        '
        Me.cboProductGroupSave.FormattingEnabled = True
        Me.cboProductGroupSave.Location = New System.Drawing.Point(418, 107)
        Me.cboProductGroupSave.Name = "cboProductGroupSave"
        Me.cboProductGroupSave.Size = New System.Drawing.Size(176, 21)
        Me.cboProductGroupSave.TabIndex = 16
        '
        'cboDocNumberingSave
        '
        Me.cboDocNumberingSave.FormattingEnabled = True
        Me.cboDocNumberingSave.Items.AddRange(New Object() {"Field Aerospace (OKC)", "Field Aerospace (Canada)", "Field Aerospace (Combined)"})
        Me.cboDocNumberingSave.Location = New System.Drawing.Point(100, 107)
        Me.cboDocNumberingSave.Name = "cboDocNumberingSave"
        Me.cboDocNumberingSave.Size = New System.Drawing.Size(231, 21)
        Me.cboDocNumberingSave.TabIndex = 15
        '
        'lblProductGroupSave
        '
        Me.lblProductGroupSave.AutoSize = True
        Me.lblProductGroupSave.Location = New System.Drawing.Point(341, 110)
        Me.lblProductGroupSave.Name = "lblProductGroupSave"
        Me.lblProductGroupSave.Size = New System.Drawing.Size(79, 13)
        Me.lblProductGroupSave.TabIndex = 14
        Me.lblProductGroupSave.Text = "Product Group:"
        '
        'lblDocNumberingSave
        '
        Me.lblDocNumberingSave.AutoSize = True
        Me.lblDocNumberingSave.Location = New System.Drawing.Point(20, 110)
        Me.lblDocNumberingSave.Name = "lblDocNumberingSave"
        Me.lblDocNumberingSave.Size = New System.Drawing.Size(84, 13)
        Me.lblDocNumberingSave.TabIndex = 13
        Me.lblDocNumberingSave.Text = "Doc Numbering:"
        '
        'btnSaveProject
        '
        Me.btnSaveProject.Location = New System.Drawing.Point(23, 134)
        Me.btnSaveProject.Name = "btnSaveProject"
        Me.btnSaveProject.Size = New System.Drawing.Size(118, 23)
        Me.btnSaveProject.TabIndex = 8
        Me.btnSaveProject.Text = "Save Changes"
        Me.btnSaveProject.UseVisualStyleBackColor = True
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "PDF Folder:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(341, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Short Form:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Project Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Project #:"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        RecordID, ProjectName, ProjectNumber, ProgramName, Active, DocNumbe" &
    "ring, ProductGroup, Standard, Legacy, PDFFolder, ShortForm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblP" &
    "rojects"
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.NVarChar, 0, "ProjectName"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.NVarChar, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.VarChar, 0, "Active"), New System.Data.SqlClient.SqlParameter("@DocNumbering", System.Data.SqlDbType.NVarChar, 0, "DocNumbering"), New System.Data.SqlClient.SqlParameter("@ProductGroup", System.Data.SqlDbType.NVarChar, 0, "ProductGroup"), New System.Data.SqlClient.SqlParameter("@Standard", System.Data.SqlDbType.Bit, 0, "Standard"), New System.Data.SqlClient.SqlParameter("@Legacy", System.Data.SqlDbType.Bit, 0, "Legacy"), New System.Data.SqlClient.SqlParameter("@PDFFolder", System.Data.SqlDbType.NVarChar, 0, "PDFFolder"), New System.Data.SqlClient.SqlParameter("@ShortForm", System.Data.SqlDbType.NVarChar, 0, "ShortForm")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.NVarChar, 0, "ProjectName"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.NVarChar, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.VarChar, 0, "Active"), New System.Data.SqlClient.SqlParameter("@DocNumbering", System.Data.SqlDbType.NVarChar, 0, "DocNumbering"), New System.Data.SqlClient.SqlParameter("@ProductGroup", System.Data.SqlDbType.NVarChar, 0, "ProductGroup"), New System.Data.SqlClient.SqlParameter("@Standard", System.Data.SqlDbType.Bit, 0, "Standard"), New System.Data.SqlClient.SqlParameter("@Legacy", System.Data.SqlDbType.Bit, 0, "Legacy"), New System.Data.SqlClient.SqlParameter("@PDFFolder", System.Data.SqlDbType.NVarChar, 0, "PDFFolder"), New System.Data.SqlClient.SqlParameter("@ShortForm", System.Data.SqlDbType.NVarChar, 0, "ShortForm"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocNumbering", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocNumbering", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocNumbering", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocNumbering", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductGroup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductGroup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductGroup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductGroup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Standard", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Standard", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Standard", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Standard", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Legacy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Legacy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Legacy", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Legacy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PDFFolder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PDFFolder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PDFFolder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PDFFolder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ShortForm", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ShortForm", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ShortForm", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShortForm", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocNumbering", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocNumbering", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocNumbering", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocNumbering", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProductGroup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductGroup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProductGroup", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductGroup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Standard", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Standard", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Standard", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Standard", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Legacy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Legacy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Legacy", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Legacy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_PDFFolder", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PDFFolder", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_PDFFolder", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PDFFolder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ShortForm", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ShortForm", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ShortForm", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShortForm", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblProjects", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("ProjectName", "ProjectName"), New System.Data.Common.DataColumnMapping("ProjectNumber", "ProjectNumber"), New System.Data.Common.DataColumnMapping("ProgramName", "ProgramName"), New System.Data.Common.DataColumnMapping("Active", "Active"), New System.Data.Common.DataColumnMapping("DocNumbering", "DocNumbering"), New System.Data.Common.DataColumnMapping("ProductGroup", "ProductGroup"), New System.Data.Common.DataColumnMapping("Standard", "Standard"), New System.Data.Common.DataColumnMapping("Legacy", "Legacy"), New System.Data.Common.DataColumnMapping("PDFFolder", "PDFFolder"), New System.Data.Common.DataColumnMapping("ShortForm", "ShortForm")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.bsSystems
        Me.GridControl2.Location = New System.Drawing.Point(342, 192)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
        Me.GridControl2.Size = New System.Drawing.Size(387, 558)
        Me.GridControl2.TabIndex = 4
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bsSystems
        '
        Me.bsSystems.DataMember = "tblSystemDescription"
        Me.bsSystems.DataSource = Me.DsSystems1
        '
        'DsSystems1
        '
        Me.DsSystems1.DataSetName = "dsSystems"
        Me.DsSystems1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID1, Me.colProgram, Me.colSystemDescription, Me.colactive1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colRecordID1
        '
        Me.colRecordID1.FieldName = "RecordID"
        Me.colRecordID1.Name = "colRecordID1"
        '
        'colProgram
        '
        Me.colProgram.FieldName = "Program"
        Me.colProgram.Name = "colProgram"
        '
        'colSystemDescription
        '
        Me.colSystemDescription.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colSystemDescription.FieldName = "SystemDescription"
        Me.colSystemDescription.Name = "colSystemDescription"
        Me.colSystemDescription.Visible = True
        Me.colSystemDescription.VisibleIndex = 0
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colactive1
        '
        Me.colactive1.FieldName = "active"
        Me.colactive1.Name = "colactive1"
        '
        'gridAircrafts
        '
        Me.gridAircrafts.DataSource = Me.bsAircrafts
        Me.gridAircrafts.Location = New System.Drawing.Point(735, 192)
        Me.gridAircrafts.MainView = Me.GridView3
        Me.gridAircrafts.Name = "gridAircrafts"
        Me.gridAircrafts.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox2})
        Me.gridAircrafts.Size = New System.Drawing.Size(397, 258)
        Me.gridAircrafts.TabIndex = 5
        Me.gridAircrafts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'bsAircrafts
        '
        Me.bsAircrafts.DataMember = "tblAircrafts"
        Me.bsAircrafts.DataSource = Me.DsAircraftsProjectsScreen1
        '
        'DsAircraftsProjectsScreen1
        '
        Me.DsAircraftsProjectsScreen1.DataSetName = "dsAircraftsProjectsScreen"
        Me.DsAircraftsProjectsScreen1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID2, Me.colAircraft, Me.colProgramName1, Me.colProgramNumber, Me.colProjectName1, Me.colProjectNumber1, Me.colLocation})
        Me.GridView3.GridControl = Me.gridAircrafts
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colRecordID2
        '
        Me.colRecordID2.FieldName = "RecordID"
        Me.colRecordID2.Name = "colRecordID2"
        '
        'colAircraft
        '
        Me.colAircraft.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colAircraft.FieldName = "Aircraft"
        Me.colAircraft.Name = "colAircraft"
        Me.colAircraft.Visible = True
        Me.colAircraft.VisibleIndex = 0
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        Me.RepositoryItemComboBox2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colProgramName1
        '
        Me.colProgramName1.FieldName = "ProgramName"
        Me.colProgramName1.Name = "colProgramName1"
        '
        'colProgramNumber
        '
        Me.colProgramNumber.FieldName = "ProgramNumber"
        Me.colProgramNumber.Name = "colProgramNumber"
        '
        'colProjectName1
        '
        Me.colProjectName1.FieldName = "ProjectName"
        Me.colProjectName1.Name = "colProjectName1"
        '
        'colProjectNumber1
        '
        Me.colProjectNumber1.FieldName = "ProjectNumber"
        Me.colProjectNumber1.Name = "colProjectNumber1"
        '
        'colLocation
        '
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        '
        'GridControl4
        '
        Me.GridControl4.DataSource = Me.bsAircraftSerial
        Me.GridControl4.Location = New System.Drawing.Point(735, 507)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox3})
        Me.GridControl4.Size = New System.Drawing.Size(400, 243)
        Me.GridControl4.TabIndex = 6
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'bsAircraftSerial
        '
        Me.bsAircraftSerial.DataMember = "tblAircraftSerialNums"
        Me.bsAircraftSerial.DataSource = Me.DsAircraftSerial1
        '
        'DsAircraftSerial1
        '
        Me.DsAircraftSerial1.DataSetName = "dsAircraftSerial"
        Me.DsAircraftSerial1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID3, Me.colSerialNum, Me.colAircraft1, Me.colDescription, Me.colProgram1, Me.colProject, Me.colSystem})
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colRecordID3
        '
        Me.colRecordID3.FieldName = "RecordID"
        Me.colRecordID3.Name = "colRecordID3"
        '
        'colSerialNum
        '
        Me.colSerialNum.FieldName = "SerialNum"
        Me.colSerialNum.Name = "colSerialNum"
        Me.colSerialNum.Visible = True
        Me.colSerialNum.VisibleIndex = 0
        '
        'colAircraft1
        '
        Me.colAircraft1.ColumnEdit = Me.RepositoryItemComboBox3
        Me.colAircraft1.FieldName = "Aircraft"
        Me.colAircraft1.Name = "colAircraft1"
        Me.colAircraft1.Visible = True
        Me.colAircraft1.VisibleIndex = 1
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        Me.RepositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 2
        '
        'colProgram1
        '
        Me.colProgram1.FieldName = "Program"
        Me.colProgram1.Name = "colProgram1"
        '
        'colProject
        '
        Me.colProject.FieldName = "Project"
        Me.colProject.Name = "colProject"
        '
        'colSystem
        '
        Me.colSystem.FieldName = "System"
        Me.colSystem.Name = "colSystem"
        '
        'btnSaveSystems
        '
        Me.btnSaveSystems.Location = New System.Drawing.Point(442, 756)
        Me.btnSaveSystems.Name = "btnSaveSystems"
        Me.btnSaveSystems.Size = New System.Drawing.Size(98, 23)
        Me.btnSaveSystems.TabIndex = 7
        Me.btnSaveSystems.Text = "Save"
        Me.btnSaveSystems.UseVisualStyleBackColor = True
        '
        'btnDeleteSystems
        '
        Me.btnDeleteSystems.Location = New System.Drawing.Point(546, 756)
        Me.btnDeleteSystems.Name = "btnDeleteSystems"
        Me.btnDeleteSystems.Size = New System.Drawing.Size(98, 23)
        Me.btnDeleteSystems.TabIndex = 8
        Me.btnDeleteSystems.Text = "Delete"
        Me.btnDeleteSystems.UseVisualStyleBackColor = True
        '
        'btnDeleteAssociatedAircraft
        '
        Me.btnDeleteAssociatedAircraft.Location = New System.Drawing.Point(933, 456)
        Me.btnDeleteAssociatedAircraft.Name = "btnDeleteAssociatedAircraft"
        Me.btnDeleteAssociatedAircraft.Size = New System.Drawing.Size(98, 23)
        Me.btnDeleteAssociatedAircraft.TabIndex = 10
        Me.btnDeleteAssociatedAircraft.Text = "Delete"
        Me.btnDeleteAssociatedAircraft.UseVisualStyleBackColor = True
        '
        'btnSaveAssociatedAircraft
        '
        Me.btnSaveAssociatedAircraft.Location = New System.Drawing.Point(829, 456)
        Me.btnSaveAssociatedAircraft.Name = "btnSaveAssociatedAircraft"
        Me.btnSaveAssociatedAircraft.Size = New System.Drawing.Size(98, 23)
        Me.btnSaveAssociatedAircraft.TabIndex = 9
        Me.btnSaveAssociatedAircraft.Text = "Save"
        Me.btnSaveAssociatedAircraft.UseVisualStyleBackColor = True
        '
        'btnDeleteSerialNum
        '
        Me.btnDeleteSerialNum.Location = New System.Drawing.Point(935, 757)
        Me.btnDeleteSerialNum.Name = "btnDeleteSerialNum"
        Me.btnDeleteSerialNum.Size = New System.Drawing.Size(98, 23)
        Me.btnDeleteSerialNum.TabIndex = 12
        Me.btnDeleteSerialNum.Text = "Delete"
        Me.btnDeleteSerialNum.UseVisualStyleBackColor = True
        '
        'btnSaveSerialNum
        '
        Me.btnSaveSerialNum.Location = New System.Drawing.Point(831, 757)
        Me.btnSaveSerialNum.Name = "btnSaveSerialNum"
        Me.btnSaveSerialNum.Size = New System.Drawing.Size(98, 23)
        Me.btnSaveSerialNum.TabIndex = 11
        Me.btnSaveSerialNum.Text = "Save"
        Me.btnSaveSerialNum.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(340, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Systems:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(732, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Associated Aircraft:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(735, 491)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Aircraft Serial Numbers:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1137, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Assigned to Program(s)"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        RecordID, Program, SystemDescription, active" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblSy" &
    "stemDescription"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@SystemDescription", System.Data.SqlDbType.NVarChar, 0, "SystemDescription"), New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 0, "active")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@SystemDescription", System.Data.SqlDbType.NVarChar, 0, "SystemDescription"), New System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.Bit, 0, "active"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SystemDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SystemDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "active", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SystemDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SystemDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "active", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "active", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblSystemDescription", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("SystemDescription", "SystemDescription"), New System.Data.Common.DataColumnMapping("active", "active")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'txtRecordIDSystems
        '
        Me.txtRecordIDSystems.Location = New System.Drawing.Point(380, 429)
        Me.txtRecordIDSystems.Name = "txtRecordIDSystems"
        Me.txtRecordIDSystems.Size = New System.Drawing.Size(100, 20)
        Me.txtRecordIDSystems.TabIndex = 18
        '
        'lstAssignedPrograms
        '
        Me.lstAssignedPrograms.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAssignedPrograms.FormattingEnabled = True
        Me.lstAssignedPrograms.ItemHeight = 18
        Me.lstAssignedPrograms.Location = New System.Drawing.Point(1140, 192)
        Me.lstAssignedPrograms.Name = "lstAssignedPrograms"
        Me.lstAssignedPrograms.Size = New System.Drawing.Size(402, 562)
        Me.lstAssignedPrograms.TabIndex = 19
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT        RecordID, Aircraft, ProgramName, ProgramNumber, ProjectName, Projec" &
    "tNumber, Location" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblAircrafts"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection2
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=engdwgtest;Persist Security Info=" &
    "True;User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection2
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Aircraft", System.Data.SqlDbType.NVarChar, 0, "Aircraft"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@ProgramNumber", System.Data.SqlDbType.NVarChar, 0, "ProgramNumber"), New System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.NVarChar, 0, "ProjectName"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.NVarChar, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location")})
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Aircraft", System.Data.SqlDbType.NVarChar, 0, "Aircraft"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@ProgramNumber", System.Data.SqlDbType.NVarChar, 0, "ProgramNumber"), New System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.NVarChar, 0, "ProjectName"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.NVarChar, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.NVarChar, 0, "Location"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Aircraft", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Aircraft", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Aircraft", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aircraft", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Aircraft", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Aircraft", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Aircraft", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aircraft", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Location", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Location", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.DeleteCommand = Me.SqlDeleteCommand3
        Me.SqlDataAdapter3.InsertCommand = Me.SqlInsertCommand3
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblAircrafts", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("Aircraft", "Aircraft"), New System.Data.Common.DataColumnMapping("ProgramName", "ProgramName"), New System.Data.Common.DataColumnMapping("ProgramNumber", "ProgramNumber"), New System.Data.Common.DataColumnMapping("ProjectName", "ProjectName"), New System.Data.Common.DataColumnMapping("ProjectNumber", "ProjectNumber"), New System.Data.Common.DataColumnMapping("Location", "Location")})})
        Me.SqlDataAdapter3.UpdateCommand = Me.SqlUpdateCommand3
        '
        'txtRecordIDAircrafts
        '
        Me.txtRecordIDAircrafts.Location = New System.Drawing.Point(803, 357)
        Me.txtRecordIDAircrafts.Name = "txtRecordIDAircrafts"
        Me.txtRecordIDAircrafts.Size = New System.Drawing.Size(100, 20)
        Me.txtRecordIDAircrafts.TabIndex = 20
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT        RecordID, SerialNum, Aircraft, Description, Program, Project, Syste" &
    "m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblAircraftSerialNums"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection2
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SerialNum", System.Data.SqlDbType.NVarChar, 0, "SerialNum"), New System.Data.SqlClient.SqlParameter("@Aircraft", System.Data.SqlDbType.NVarChar, 0, "Aircraft"), New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 0, "Description"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@Project", System.Data.SqlDbType.NVarChar, 0, "Project"), New System.Data.SqlClient.SqlParameter("@System", System.Data.SqlDbType.NVarChar, 0, "System")})
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SerialNum", System.Data.SqlDbType.NVarChar, 0, "SerialNum"), New System.Data.SqlClient.SqlParameter("@Aircraft", System.Data.SqlDbType.NVarChar, 0, "Aircraft"), New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 0, "Description"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@Project", System.Data.SqlDbType.NVarChar, 0, "Project"), New System.Data.SqlClient.SqlParameter("@System", System.Data.SqlDbType.NVarChar, 0, "System"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Aircraft", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Aircraft", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Aircraft", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aircraft", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Project", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Project", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Project", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Project", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_System", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "System", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_System", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "System", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SerialNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SerialNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SerialNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Aircraft", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Aircraft", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Aircraft", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aircraft", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Project", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Project", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Project", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Project", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_System", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "System", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_System", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "System", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.DeleteCommand = Me.SqlDeleteCommand4
        Me.SqlDataAdapter4.InsertCommand = Me.SqlInsertCommand4
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblAircraftSerialNums", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("SerialNum", "SerialNum"), New System.Data.Common.DataColumnMapping("Aircraft", "Aircraft"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("Project", "Project"), New System.Data.Common.DataColumnMapping("System", "System")})})
        Me.SqlDataAdapter4.UpdateCommand = Me.SqlUpdateCommand4
        '
        'txtRecordIDSerial
        '
        Me.txtRecordIDSerial.Location = New System.Drawing.Point(790, 657)
        Me.txtRecordIDSerial.Name = "txtRecordIDSerial"
        Me.txtRecordIDSerial.Size = New System.Drawing.Size(100, 20)
        Me.txtRecordIDSerial.TabIndex = 21
        '
        'btnCertificationManager
        '
        Me.btnCertificationManager.Location = New System.Drawing.Point(1379, 782)
        Me.btnCertificationManager.Name = "btnCertificationManager"
        Me.btnCertificationManager.Size = New System.Drawing.Size(161, 23)
        Me.btnCertificationManager.TabIndex = 22
        Me.btnCertificationManager.Text = "Certification Manager"
        Me.btnCertificationManager.UseVisualStyleBackColor = True
        '
        'txtProjectNameBeforeSaveChanges
        '
        Me.txtProjectNameBeforeSaveChanges.Location = New System.Drawing.Point(140, 235)
        Me.txtProjectNameBeforeSaveChanges.Name = "txtProjectNameBeforeSaveChanges"
        Me.txtProjectNameBeforeSaveChanges.Size = New System.Drawing.Size(100, 20)
        Me.txtProjectNameBeforeSaveChanges.TabIndex = 23
        '
        'Projects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1552, 811)
        Me.Controls.Add(Me.btnCertificationManager)
        Me.Controls.Add(Me.lstAssignedPrograms)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDeleteSerialNum)
        Me.Controls.Add(Me.btnSaveSerialNum)
        Me.Controls.Add(Me.btnDeleteAssociatedAircraft)
        Me.Controls.Add(Me.btnSaveAssociatedAircraft)
        Me.Controls.Add(Me.btnDeleteSystems)
        Me.Controls.Add(Me.btnSaveSystems)
        Me.Controls.Add(Me.GridControl4)
        Me.Controls.Add(Me.gridAircrafts)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRecordIDSystems)
        Me.Controls.Add(Me.txtRecordIDAircrafts)
        Me.Controls.Add(Me.txtRecordIDSerial)
        Me.Name = "Projects"
        Me.Text = "Projects"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProjects1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSystems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSystems1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAircrafts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAircrafts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAircraftsProjectsScreen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAircraftSerial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAircraftSerial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPDFFolder As TextBox
    Friend WithEvents txtShortForm As TextBox
    Friend WithEvents txtProjectName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSaveProject As Button
    Friend WithEvents cboActive As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnDeleteProject As Button
    Friend WithEvents txtAddProjNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddProjDesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents bsProjects As BindingSource
    Friend WithEvents DsProjects1 As dsProjects
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocNumbering As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStandard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLegacy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPDFFolder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShortForm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboProductGroupSave As ComboBox
    Friend WithEvents cboDocNumberingSave As ComboBox
    Friend WithEvents lblProductGroupSave As Label
    Friend WithEvents lblDocNumberingSave As Label
    Friend WithEvents txtRecordID As TextBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridAircrafts As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSaveSystems As Button
    Friend WithEvents btnDeleteSystems As Button
    Friend WithEvents btnDeleteAssociatedAircraft As Button
    Friend WithEvents btnSaveAssociatedAircraft As Button
    Friend WithEvents btnDeleteSerialNum As Button
    Friend WithEvents btnSaveSerialNum As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents bsSystems As BindingSource
    Friend WithEvents DsSystems1 As dsSystems
    Friend WithEvents colRecordID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colactive1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As SqlClient.SqlDataAdapter
    Friend WithEvents txtRecordIDSystems As TextBox
    Friend WithEvents lstAssignedPrograms As ListBox
    Friend WithEvents bsAircrafts As BindingSource
    Friend WithEvents DsAircraftsProjectsScreen1 As dsAircraftsProjectsScreen
    Friend WithEvents colRecordID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAircraft As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectNumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter3 As SqlClient.SqlDataAdapter
    Friend WithEvents txtRecordIDAircrafts As TextBox
    Friend WithEvents bsAircraftSerial As BindingSource
    Friend WithEvents DsAircraftSerial1 As dsAircraftSerial
    Friend WithEvents colRecordID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerialNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAircraft1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter4 As SqlClient.SqlDataAdapter
    Friend WithEvents txtRecordIDSerial As TextBox
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cboProjectNumSave As ComboBox
    Friend WithEvents btnCertificationManager As Button
    Friend WithEvents txtProjectNameBeforeSaveChanges As TextBox
End Class
