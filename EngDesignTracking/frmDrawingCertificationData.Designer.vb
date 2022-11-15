<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrawingCertificationData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDrawingCertificationData))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDrawingTitle = New System.Windows.Forms.Label()
        Me.lblDrawingRevision = New System.Windows.Forms.Label()
        Me.lblDrawingNo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet91 = New EngDesignTracking.DataSet9()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet101 = New EngDesignTracking.DataSet10()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboCertificationReviewStatus = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet111 = New EngDesignTracking.DataSet11()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRecordID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFilePath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImgField = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileExt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.txtFileDescription = New System.Windows.Forms.TextBox()
        Me.btnDeleteAttachment = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtAttachRecordID = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSaveUMApprovals = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnFileAttachSubmit = New System.Windows.Forms.Button()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRecordID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAOMTName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAOMTSpecialty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAOMTRecommendApproval = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAOMTApproval = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colRequiredToApprove1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkShowAllUMApprovals = New System.Windows.Forms.CheckBox()
        Me.chkShowAllFAAOMTApprovals = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUMName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUMSpecialty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUMRecommendApproval = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colUMApproval = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colRequiredToApprove = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSyncUMApprovals = New System.Windows.Forms.Button()
        Me.btnSyncOMTApprovals = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet101, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet111, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblProgram)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.lblDrawingTitle)
        Me.GroupBox1.Controls.Add(Me.lblDrawingRevision)
        Me.GroupBox1.Controls.Add(Me.lblDrawingNo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1592, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Drawing Info"
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Location = New System.Drawing.Point(738, 83)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(57, 20)
        Me.lblProgram.TabIndex = 9
        Me.lblProgram.Text = "Label7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(616, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Program:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(120, 83)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(71, 20)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "lblStatus"
        '
        'lblDrawingTitle
        '
        Me.lblDrawingTitle.AutoSize = True
        Me.lblDrawingTitle.Location = New System.Drawing.Point(616, 49)
        Me.lblDrawingTitle.Name = "lblDrawingTitle"
        Me.lblDrawingTitle.Size = New System.Drawing.Size(57, 20)
        Me.lblDrawingTitle.TabIndex = 6
        Me.lblDrawingTitle.Text = "Label7"
        '
        'lblDrawingRevision
        '
        Me.lblDrawingRevision.AutoSize = True
        Me.lblDrawingRevision.Location = New System.Drawing.Point(396, 49)
        Me.lblDrawingRevision.Name = "lblDrawingRevision"
        Me.lblDrawingRevision.Size = New System.Drawing.Size(57, 20)
        Me.lblDrawingRevision.TabIndex = 5
        Me.lblDrawingRevision.Text = "Label7"
        '
        'lblDrawingNo
        '
        Me.lblDrawingNo.AutoSize = True
        Me.lblDrawingNo.Location = New System.Drawing.Point(146, 49)
        Me.lblDrawingNo.Name = "lblDrawingNo"
        Me.lblDrawingNo.Size = New System.Drawing.Size(57, 20)
        Me.lblDrawingNo.TabIndex = 4
        Me.lblDrawingNo.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Status:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(495, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Drawing Title:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Revison:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Drawing #:"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblDrawingCertUMApproval"
        Me.BindingSource1.DataSource = Me.DataSet91
        '
        'DataSet91
        '
        Me.DataSet91.DataSetName = "DataSet9"
        Me.DataSet91.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "tblDrawingCertFAAOMTApproval"
        Me.BindingSource2.DataSource = Me.DataSet101
        '
        'DataSet101
        '
        Me.DataSet101.DataSetName = "DataSet10"
        Me.DataSet101.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 158)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "UM Approvals"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 445)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "FAA OMT Approvals"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        RecordID, DwgRecordID, UMName, UMSpecialty, UMRecommendApproval, UM" &
    "Approval, RequiredToApprove, Comments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblDrawingCertUMApproval"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DwgRecordID", System.Data.SqlDbType.Int, 0, "DwgRecordID"), New System.Data.SqlClient.SqlParameter("@UMName", System.Data.SqlDbType.NVarChar, 0, "UMName"), New System.Data.SqlClient.SqlParameter("@UMSpecialty", System.Data.SqlDbType.NVarChar, 0, "UMSpecialty"), New System.Data.SqlClient.SqlParameter("@UMRecommendApproval", System.Data.SqlDbType.NVarChar, 0, "UMRecommendApproval"), New System.Data.SqlClient.SqlParameter("@UMApproval", System.Data.SqlDbType.NVarChar, 0, "UMApproval"), New System.Data.SqlClient.SqlParameter("@RequiredToApprove", System.Data.SqlDbType.Bit, 0, "RequiredToApprove"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DwgRecordID", System.Data.SqlDbType.Int, 0, "DwgRecordID"), New System.Data.SqlClient.SqlParameter("@UMName", System.Data.SqlDbType.NVarChar, 0, "UMName"), New System.Data.SqlClient.SqlParameter("@UMSpecialty", System.Data.SqlDbType.NVarChar, 0, "UMSpecialty"), New System.Data.SqlClient.SqlParameter("@UMRecommendApproval", System.Data.SqlDbType.NVarChar, 0, "UMRecommendApproval"), New System.Data.SqlClient.SqlParameter("@UMApproval", System.Data.SqlDbType.NVarChar, 0, "UMApproval"), New System.Data.SqlClient.SqlParameter("@RequiredToApprove", System.Data.SqlDbType.Bit, 0, "RequiredToApprove"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMSpecialty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMSpecialty", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMSpecialty", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMSpecialty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMRecommendApproval", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMRecommendApproval", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMRecommendApproval", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMRecommendApproval", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMApproval", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMApproval", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMApproval", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMApproval", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RequiredToApprove", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RequiredToApprove", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RequiredToApprove", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequiredToApprove", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMSpecialty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMSpecialty", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMSpecialty", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMSpecialty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMRecommendApproval", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMRecommendApproval", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMRecommendApproval", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMRecommendApproval", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMApproval", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMApproval", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMApproval", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMApproval", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RequiredToApprove", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RequiredToApprove", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RequiredToApprove", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequiredToApprove", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawingCertUMApproval", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DwgRecordID", "DwgRecordID"), New System.Data.Common.DataColumnMapping("UMName", "UMName"), New System.Data.Common.DataColumnMapping("UMSpecialty", "UMSpecialty"), New System.Data.Common.DataColumnMapping("UMRecommendApproval", "UMRecommendApproval"), New System.Data.Common.DataColumnMapping("UMApproval", "UMApproval"), New System.Data.Common.DataColumnMapping("RequiredToApprove", "RequiredToApprove"), New System.Data.Common.DataColumnMapping("Comments", "Comments")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        RecordID, DwgRecordID, FAAOMTName, FAAOMTSpecialty, FAAOMTRecommend" &
    "Approval, FAAOMTApproval, RequiredToApprove, Comments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblDrawin" &
    "gCertFAAOMTApproval"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DwgRecordID", System.Data.SqlDbType.Int, 0, "DwgRecordID"), New System.Data.SqlClient.SqlParameter("@FAAOMTName", System.Data.SqlDbType.NVarChar, 0, "FAAOMTName"), New System.Data.SqlClient.SqlParameter("@FAAOMTSpecialty", System.Data.SqlDbType.NVarChar, 0, "FAAOMTSpecialty"), New System.Data.SqlClient.SqlParameter("@FAAOMTRecommendApproval", System.Data.SqlDbType.Bit, 0, "FAAOMTRecommendApproval"), New System.Data.SqlClient.SqlParameter("@FAAOMTApproval", System.Data.SqlDbType.NVarChar, 0, "FAAOMTApproval"), New System.Data.SqlClient.SqlParameter("@RequiredToApprove", System.Data.SqlDbType.Bit, 0, "RequiredToApprove"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DwgRecordID", System.Data.SqlDbType.Int, 0, "DwgRecordID"), New System.Data.SqlClient.SqlParameter("@FAAOMTName", System.Data.SqlDbType.NVarChar, 0, "FAAOMTName"), New System.Data.SqlClient.SqlParameter("@FAAOMTSpecialty", System.Data.SqlDbType.NVarChar, 0, "FAAOMTSpecialty"), New System.Data.SqlClient.SqlParameter("@FAAOMTRecommendApproval", System.Data.SqlDbType.Bit, 0, "FAAOMTRecommendApproval"), New System.Data.SqlClient.SqlParameter("@FAAOMTApproval", System.Data.SqlDbType.NVarChar, 0, "FAAOMTApproval"), New System.Data.SqlClient.SqlParameter("@RequiredToApprove", System.Data.SqlDbType.Bit, 0, "RequiredToApprove"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAOMTName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAOMTName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAOMTName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAOMTName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAOMTSpecialty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAOMTSpecialty", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAOMTSpecialty", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAOMTSpecialty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAOMTRecommendApproval", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAOMTRecommendApproval", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAOMTRecommendApproval", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAOMTRecommendApproval", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAOMTApproval", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAOMTApproval", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAOMTApproval", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAOMTApproval", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RequiredToApprove", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RequiredToApprove", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RequiredToApprove", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequiredToApprove", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAOMTName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAOMTName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAOMTName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAOMTName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAOMTSpecialty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAOMTSpecialty", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAOMTSpecialty", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAOMTSpecialty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAOMTRecommendApproval", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAOMTRecommendApproval", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAOMTRecommendApproval", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAOMTRecommendApproval", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FAAOMTApproval", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FAAOMTApproval", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FAAOMTApproval", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FAAOMTApproval", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RequiredToApprove", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RequiredToApprove", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RequiredToApprove", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequiredToApprove", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawingCertFAAOMTApproval", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DwgRecordID", "DwgRecordID"), New System.Data.Common.DataColumnMapping("FAAOMTName", "FAAOMTName"), New System.Data.Common.DataColumnMapping("FAAOMTSpecialty", "FAAOMTSpecialty"), New System.Data.Common.DataColumnMapping("FAAOMTRecommendApproval", "FAAOMTRecommendApproval"), New System.Data.Common.DataColumnMapping("FAAOMTApproval", "FAAOMTApproval"), New System.Data.Common.DataColumnMapping("RequiredToApprove", "RequiredToApprove"), New System.Data.Common.DataColumnMapping("Comments", "Comments")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 728)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Certification Review Status"
        '
        'cboCertificationReviewStatus
        '
        Me.cboCertificationReviewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCertificationReviewStatus.FormattingEnabled = True
        Me.cboCertificationReviewStatus.Items.AddRange(New Object() {"Approved", "Not Approved"})
        Me.cboCertificationReviewStatus.Location = New System.Drawing.Point(285, 728)
        Me.cboCertificationReviewStatus.Name = "cboCertificationReviewStatus"
        Me.cboCertificationReviewStatus.Size = New System.Drawing.Size(385, 28)
        Me.cboCertificationReviewStatus.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(297, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "8100-9/FAA Approval Attachments"
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.BindingSource3
        Me.GridControl3.Location = New System.Drawing.Point(30, 62)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(1094, 160)
        Me.GridControl3.TabIndex = 9
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "tblDrawingCertAttachments"
        Me.BindingSource3.DataSource = Me.DataSet111
        '
        'DataSet111
        '
        Me.DataSet111.DataSetName = "DataSet11"
        Me.DataSet111.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID2, Me.colDwgRecordID2, Me.colFilePath, Me.colFileDescription, Me.colImgField, Me.colFileName, Me.colFileExt})
        Me.GridView3.DetailHeight = 349
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        '
        'colRecordID2
        '
        Me.colRecordID2.FieldName = "RecordID"
        Me.colRecordID2.MinWidth = 30
        Me.colRecordID2.Name = "colRecordID2"
        Me.colRecordID2.Visible = True
        Me.colRecordID2.VisibleIndex = 0
        '
        'colDwgRecordID2
        '
        Me.colDwgRecordID2.FieldName = "DwgRecordID"
        Me.colDwgRecordID2.MinWidth = 30
        Me.colDwgRecordID2.Name = "colDwgRecordID2"
        Me.colDwgRecordID2.Visible = True
        Me.colDwgRecordID2.VisibleIndex = 1
        '
        'colFilePath
        '
        Me.colFilePath.FieldName = "FilePath"
        Me.colFilePath.MinWidth = 30
        Me.colFilePath.Name = "colFilePath"
        Me.colFilePath.Visible = True
        Me.colFilePath.VisibleIndex = 2
        '
        'colFileDescription
        '
        Me.colFileDescription.FieldName = "FileDescription"
        Me.colFileDescription.MinWidth = 30
        Me.colFileDescription.Name = "colFileDescription"
        Me.colFileDescription.Visible = True
        Me.colFileDescription.VisibleIndex = 3
        '
        'colImgField
        '
        Me.colImgField.FieldName = "ImgField"
        Me.colImgField.MinWidth = 30
        Me.colImgField.Name = "colImgField"
        Me.colImgField.Visible = True
        Me.colImgField.VisibleIndex = 4
        '
        'colFileName
        '
        Me.colFileName.FieldName = "FileName"
        Me.colFileName.MinWidth = 30
        Me.colFileName.Name = "colFileName"
        Me.colFileName.Visible = True
        Me.colFileName.VisibleIndex = 5
        '
        'colFileExt
        '
        Me.colFileExt.FieldName = "FileExt"
        Me.colFileExt.MinWidth = 30
        Me.colFileExt.Name = "colFileExt"
        Me.colFileExt.Visible = True
        Me.colFileExt.VisibleIndex = 6
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Location = New System.Drawing.Point(1209, 286)
        Me.btnSaveNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(152, 35)
        Me.btnSaveNew.TabIndex = 19
        Me.btnSaveNew.Text = "Save New"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        Me.btnSaveNew.Visible = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(1038, 286)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(152, 35)
        Me.btnBrowse.TabIndex = 18
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label25.Location = New System.Drawing.Point(26, 294)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 19)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Path:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(26, 258)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(107, 19)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Description:"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(152, 294)
        Me.txtFilePath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(864, 26)
        Me.txtFilePath.TabIndex = 15
        '
        'txtFileDescription
        '
        Me.txtFileDescription.Location = New System.Drawing.Point(153, 258)
        Me.txtFileDescription.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFileDescription.Name = "txtFileDescription"
        Me.txtFileDescription.Size = New System.Drawing.Size(864, 26)
        Me.txtFileDescription.TabIndex = 14
        '
        'btnDeleteAttachment
        '
        Me.btnDeleteAttachment.Location = New System.Drawing.Point(1131, 165)
        Me.btnDeleteAttachment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDeleteAttachment.Name = "btnDeleteAttachment"
        Me.btnDeleteAttachment.Size = New System.Drawing.Size(294, 57)
        Me.btnDeleteAttachment.TabIndex = 13
        Me.btnDeleteAttachment.Text = "Delete Selected Attachment"
        Me.btnDeleteAttachment.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(1432, 165)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(222, 57)
        Me.btnView.TabIndex = 12
        Me.btnView.Text = "View Selected File"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT        tblDrawingCertAttachments.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblDrawingCertAttachme" &
    "nts"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DwgRecordID", System.Data.SqlDbType.Int, 0, "DwgRecordID"), New System.Data.SqlClient.SqlParameter("@FilePath", System.Data.SqlDbType.NVarChar, 0, "FilePath"), New System.Data.SqlClient.SqlParameter("@FileDescription", System.Data.SqlDbType.NVarChar, 0, "FileDescription"), New System.Data.SqlClient.SqlParameter("@ImgField", System.Data.SqlDbType.Image, 0, "ImgField"), New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.NVarChar, 0, "FileName"), New System.Data.SqlClient.SqlParameter("@FileExt", System.Data.SqlDbType.NVarChar, 0, "FileExt")})
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DwgRecordID", System.Data.SqlDbType.Int, 0, "DwgRecordID"), New System.Data.SqlClient.SqlParameter("@FilePath", System.Data.SqlDbType.NVarChar, 0, "FilePath"), New System.Data.SqlClient.SqlParameter("@FileDescription", System.Data.SqlDbType.NVarChar, 0, "FileDescription"), New System.Data.SqlClient.SqlParameter("@ImgField", System.Data.SqlDbType.Image, 0, "ImgField"), New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.NVarChar, 0, "FileName"), New System.Data.SqlClient.SqlParameter("@FileExt", System.Data.SqlDbType.NVarChar, 0, "FileExt"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FilePath", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FilePath", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FilePath", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FilePath", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileExt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileExt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FilePath", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FilePath", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FilePath", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FilePath", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileExt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileExt", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileExt", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.DeleteCommand = Me.SqlDeleteCommand3
        Me.SqlDataAdapter3.InsertCommand = Me.SqlInsertCommand3
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawingCertAttachments", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DwgRecordID", "DwgRecordID"), New System.Data.Common.DataColumnMapping("FilePath", "FilePath"), New System.Data.Common.DataColumnMapping("FileDescription", "FileDescription"), New System.Data.Common.DataColumnMapping("ImgField", "ImgField"), New System.Data.Common.DataColumnMapping("FileName", "FileName"), New System.Data.Common.DataColumnMapping("FileExt", "FileExt")})})
        Me.SqlDataAdapter3.UpdateCommand = Me.SqlUpdateCommand3
        '
        'txtAttachRecordID
        '
        Me.txtAttachRecordID.Location = New System.Drawing.Point(734, 835)
        Me.txtAttachRecordID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAttachRecordID.Name = "txtAttachRecordID"
        Me.txtAttachRecordID.Size = New System.Drawing.Size(148, 26)
        Me.txtAttachRecordID.TabIndex = 20
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSaveUMApprovals
        '
        Me.btnSaveUMApprovals.Location = New System.Drawing.Point(1461, 723)
        Me.btnSaveUMApprovals.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSaveUMApprovals.Name = "btnSaveUMApprovals"
        Me.btnSaveUMApprovals.Size = New System.Drawing.Size(198, 35)
        Me.btnSaveUMApprovals.TabIndex = 21
        Me.btnSaveUMApprovals.Text = "Save"
        Me.btnSaveUMApprovals.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Controls.Add(Me.btnFileAttachSubmit)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btnView)
        Me.GroupBox2.Controls.Add(Me.btnSaveNew)
        Me.GroupBox2.Controls.Add(Me.GridControl3)
        Me.GroupBox2.Controls.Add(Me.btnBrowse)
        Me.GroupBox2.Controls.Add(Me.btnDeleteAttachment)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtFileDescription)
        Me.GroupBox2.Controls.Add(Me.txtFilePath)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 768)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(1976, 349)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Attachments"
        '
        'btnFileAttachSubmit
        '
        Me.btnFileAttachSubmit.Location = New System.Drawing.Point(1662, 165)
        Me.btnFileAttachSubmit.Name = "btnFileAttachSubmit"
        Me.btnFileAttachSubmit.Size = New System.Drawing.Size(168, 57)
        Me.btnFileAttachSubmit.TabIndex = 20
        Me.btnFileAttachSubmit.Text = "Submit New"
        Me.btnFileAttachSubmit.UseVisualStyleBackColor = True
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.BindingSource2
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridControl2.Location = New System.Drawing.Point(28, 478)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox2})
        Me.GridControl2.Size = New System.Drawing.Size(1630, 220)
        Me.GridControl2.TabIndex = 24
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID1, Me.colDwgRecordID1, Me.colFAAOMTName, Me.colFAAOMTSpecialty, Me.colFAAOMTRecommendApproval, Me.colFAAOMTApproval, Me.colRequiredToApprove1, Me.colComments1})
        Me.GridView2.DetailHeight = 538
        Me.GridView2.FixedLineWidth = 3
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'colRecordID1
        '
        Me.colRecordID1.FieldName = "RecordID"
        Me.colRecordID1.MinWidth = 30
        Me.colRecordID1.Name = "colRecordID1"
        Me.colRecordID1.Width = 112
        '
        'colDwgRecordID1
        '
        Me.colDwgRecordID1.FieldName = "DwgRecordID"
        Me.colDwgRecordID1.MinWidth = 30
        Me.colDwgRecordID1.Name = "colDwgRecordID1"
        Me.colDwgRecordID1.Width = 112
        '
        'colFAAOMTName
        '
        Me.colFAAOMTName.FieldName = "FAAOMTName"
        Me.colFAAOMTName.MinWidth = 30
        Me.colFAAOMTName.Name = "colFAAOMTName"
        Me.colFAAOMTName.Visible = True
        Me.colFAAOMTName.VisibleIndex = 0
        Me.colFAAOMTName.Width = 112
        '
        'colFAAOMTSpecialty
        '
        Me.colFAAOMTSpecialty.FieldName = "FAAOMTSpecialty"
        Me.colFAAOMTSpecialty.MinWidth = 30
        Me.colFAAOMTSpecialty.Name = "colFAAOMTSpecialty"
        Me.colFAAOMTSpecialty.Visible = True
        Me.colFAAOMTSpecialty.VisibleIndex = 1
        Me.colFAAOMTSpecialty.Width = 112
        '
        'colFAAOMTRecommendApproval
        '
        Me.colFAAOMTRecommendApproval.FieldName = "FAAOMTRecommendApproval"
        Me.colFAAOMTRecommendApproval.MinWidth = 30
        Me.colFAAOMTRecommendApproval.Name = "colFAAOMTRecommendApproval"
        Me.colFAAOMTRecommendApproval.Width = 112
        '
        'colFAAOMTApproval
        '
        Me.colFAAOMTApproval.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colFAAOMTApproval.FieldName = "FAAOMTApproval"
        Me.colFAAOMTApproval.MinWidth = 30
        Me.colFAAOMTApproval.Name = "colFAAOMTApproval"
        Me.colFAAOMTApproval.Visible = True
        Me.colFAAOMTApproval.VisibleIndex = 3
        Me.colFAAOMTApproval.Width = 112
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"Not Submitted", "Submitted", "Accepted", "Rejected", "Approved"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        Me.RepositoryItemComboBox2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colRequiredToApprove1
        '
        Me.colRequiredToApprove1.FieldName = "RequiredToApprove"
        Me.colRequiredToApprove1.MinWidth = 30
        Me.colRequiredToApprove1.Name = "colRequiredToApprove1"
        Me.colRequiredToApprove1.Visible = True
        Me.colRequiredToApprove1.VisibleIndex = 2
        Me.colRequiredToApprove1.Width = 112
        '
        'colComments1
        '
        Me.colComments1.FieldName = "Comments"
        Me.colComments1.MinWidth = 30
        Me.colComments1.Name = "colComments1"
        Me.colComments1.Visible = True
        Me.colComments1.VisibleIndex = 4
        Me.colComments1.Width = 112
        '
        'chkShowAllUMApprovals
        '
        Me.chkShowAllUMApprovals.AutoSize = True
        Me.chkShowAllUMApprovals.Location = New System.Drawing.Point(878, 157)
        Me.chkShowAllUMApprovals.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkShowAllUMApprovals.Name = "chkShowAllUMApprovals"
        Me.chkShowAllUMApprovals.Size = New System.Drawing.Size(195, 24)
        Me.chkShowAllUMApprovals.TabIndex = 25
        Me.chkShowAllUMApprovals.Text = "Show All UM Members"
        Me.chkShowAllUMApprovals.UseVisualStyleBackColor = True
        '
        'chkShowAllFAAOMTApprovals
        '
        Me.chkShowAllFAAOMTApprovals.AutoSize = True
        Me.chkShowAllFAAOMTApprovals.Location = New System.Drawing.Point(878, 443)
        Me.chkShowAllFAAOMTApprovals.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkShowAllFAAOMTApprovals.Name = "chkShowAllFAAOMTApprovals"
        Me.chkShowAllFAAOMTApprovals.Size = New System.Drawing.Size(240, 24)
        Me.chkShowAllFAAOMTApprovals.TabIndex = 26
        Me.chkShowAllFAAOMTApprovals.Text = "Show All FAA OMT Members"
        Me.chkShowAllFAAOMTApprovals.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(693, 728)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Comments"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(798, 728)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(652, 26)
        Me.txtComments.TabIndex = 28
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridControl1.Location = New System.Drawing.Point(28, 183)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox3})
        Me.GridControl1.Size = New System.Drawing.Size(1630, 235)
        Me.GridControl1.TabIndex = 29
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colDwgRecordID, Me.colUMName, Me.colUMSpecialty, Me.colUMRecommendApproval, Me.colUMApproval, Me.colRequiredToApprove, Me.colComments})
        Me.GridView1.DetailHeight = 538
        Me.GridView1.FixedLineWidth = 3
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.MinWidth = 30
        Me.colRecordID.Name = "colRecordID"
        Me.colRecordID.Width = 112
        '
        'colDwgRecordID
        '
        Me.colDwgRecordID.FieldName = "DwgRecordID"
        Me.colDwgRecordID.MinWidth = 30
        Me.colDwgRecordID.Name = "colDwgRecordID"
        Me.colDwgRecordID.Width = 112
        '
        'colUMName
        '
        Me.colUMName.FieldName = "UMName"
        Me.colUMName.MinWidth = 30
        Me.colUMName.Name = "colUMName"
        Me.colUMName.Visible = True
        Me.colUMName.VisibleIndex = 0
        Me.colUMName.Width = 112
        '
        'colUMSpecialty
        '
        Me.colUMSpecialty.FieldName = "UMSpecialty"
        Me.colUMSpecialty.MinWidth = 30
        Me.colUMSpecialty.Name = "colUMSpecialty"
        Me.colUMSpecialty.Visible = True
        Me.colUMSpecialty.VisibleIndex = 1
        Me.colUMSpecialty.Width = 112
        '
        'colUMRecommendApproval
        '
        Me.colUMRecommendApproval.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colUMRecommendApproval.FieldName = "UMRecommendApproval"
        Me.colUMRecommendApproval.MinWidth = 30
        Me.colUMRecommendApproval.Name = "colUMRecommendApproval"
        Me.colUMRecommendApproval.Visible = True
        Me.colUMRecommendApproval.VisibleIndex = 4
        Me.colUMRecommendApproval.Width = 112
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Not Applicable", "Recommend Approval"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colUMApproval
        '
        Me.colUMApproval.ColumnEdit = Me.RepositoryItemComboBox3
        Me.colUMApproval.FieldName = "UMApproval"
        Me.colUMApproval.MinWidth = 30
        Me.colUMApproval.Name = "colUMApproval"
        Me.colUMApproval.Visible = True
        Me.colUMApproval.VisibleIndex = 3
        Me.colUMApproval.Width = 112
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Items.AddRange(New Object() {"Not Submitted", "Accepted", "Rejected", "Approved"})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        Me.RepositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colRequiredToApprove
        '
        Me.colRequiredToApprove.FieldName = "RequiredToApprove"
        Me.colRequiredToApprove.MinWidth = 30
        Me.colRequiredToApprove.Name = "colRequiredToApprove"
        Me.colRequiredToApprove.Visible = True
        Me.colRequiredToApprove.VisibleIndex = 2
        Me.colRequiredToApprove.Width = 112
        '
        'colComments
        '
        Me.colComments.FieldName = "Comments"
        Me.colComments.MinWidth = 30
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 5
        Me.colComments.Width = 112
        '
        'btnSyncUMApprovals
        '
        Me.btnSyncUMApprovals.Location = New System.Drawing.Point(1197, 138)
        Me.btnSyncUMApprovals.Name = "btnSyncUMApprovals"
        Me.btnSyncUMApprovals.Size = New System.Drawing.Size(192, 40)
        Me.btnSyncUMApprovals.TabIndex = 30
        Me.btnSyncUMApprovals.Text = "Sync UM Approvals"
        Me.btnSyncUMApprovals.UseVisualStyleBackColor = True
        '
        'btnSyncOMTApprovals
        '
        Me.btnSyncOMTApprovals.Location = New System.Drawing.Point(1197, 426)
        Me.btnSyncOMTApprovals.Name = "btnSyncOMTApprovals"
        Me.btnSyncOMTApprovals.Size = New System.Drawing.Size(192, 38)
        Me.btnSyncOMTApprovals.TabIndex = 31
        Me.btnSyncOMTApprovals.Text = "Sync OMT Approvals"
        Me.btnSyncOMTApprovals.UseVisualStyleBackColor = True
        '
        'frmDrawingCertificationData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2151, 1225)
        Me.Controls.Add(Me.btnSyncOMTApprovals)
        Me.Controls.Add(Me.btnSyncUMApprovals)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chkShowAllFAAOMTApprovals)
        Me.Controls.Add(Me.chkShowAllUMApprovals)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSaveUMApprovals)
        Me.Controls.Add(Me.cboCertificationReviewStatus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtAttachRecordID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmDrawingCertificationData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDrawingCertificationData"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet101, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet111, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDrawingTitle As Label
    Friend WithEvents lblDrawingRevision As Label
    Friend WithEvents lblDrawingNo As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet91 As DataSet9
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents lblProgram As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet101 As DataSet10
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents Label8 As Label
    Friend WithEvents cboCertificationReviewStatus As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSaveNew As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents txtFileDescription As TextBox
    Friend WithEvents btnDeleteAttachment As Button
    Friend WithEvents btnView As Button
    Friend WithEvents BindingSource3 As BindingSource
    Friend WithEvents DataSet111 As DataSet11
    Friend WithEvents colRecordID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRecordID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFilePath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImgField As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileExt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter3 As SqlClient.SqlDataAdapter
    Friend WithEvents txtAttachRecordID As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSaveUMApprovals As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnFileAttachSubmit As Button
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecordID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRecordID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAOMTName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAOMTSpecialty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAOMTRecommendApproval As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAOMTApproval As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colRequiredToApprove1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkShowAllUMApprovals As CheckBox
    Friend WithEvents chkShowAllFAAOMTApprovals As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtComments As TextBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMSpecialty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMRecommendApproval As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colUMApproval As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequiredToApprove As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnSyncUMApprovals As Button
    Friend WithEvents btnSyncOMTApprovals As Button
End Class
