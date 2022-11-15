<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEngWorkflowSignOff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEngWorkflowSignOff))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Responsibility = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDrafterAssigned = New System.Windows.Forms.TextBox()
        Me.txtSrEngineerAssigned = New System.Windows.Forms.TextBox()
        Me.txtStressAssigned = New System.Windows.Forms.TextBox()
        Me.txtOperationsAssigned = New System.Windows.Forms.TextBox()
        Me.txtReleaserAssigned = New System.Windows.Forms.TextBox()
        Me.txtCMAssigned = New System.Windows.Forms.TextBox()
        Me.txtDrafterSignedOffBy = New System.Windows.Forms.TextBox()
        Me.txtSrEngineerSignedOffBy = New System.Windows.Forms.TextBox()
        Me.txtStressSignedOffBy = New System.Windows.Forms.TextBox()
        Me.txtOperationsSignedOffBy = New System.Windows.Forms.TextBox()
        Me.txtReleaserSignedOffBy = New System.Windows.Forms.TextBox()
        Me.txtCMSignedOffBy = New System.Windows.Forms.TextBox()
        Me.dtDrafterSignOff = New System.Windows.Forms.DateTimePicker()
        Me.dtSrEngineerSignOff = New System.Windows.Forms.DateTimePicker()
        Me.dtStressSignOff = New System.Windows.Forms.DateTimePicker()
        Me.dtOperationsSignOff = New System.Windows.Forms.DateTimePicker()
        Me.dtReleaserSignOff = New System.Windows.Forms.DateTimePicker()
        Me.dtCMSignOff = New System.Windows.Forms.DateTimePicker()
        Me.lblDrafterStatus = New System.Windows.Forms.Label()
        Me.lblSrEngineerStatus = New System.Windows.Forms.Label()
        Me.lblStressStatus = New System.Windows.Forms.Label()
        Me.lblOperationsStatus = New System.Windows.Forms.Label()
        Me.lblReleaserStatus = New System.Windows.Forms.Label()
        Me.lblCMStatus = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.DataSet401 = New EngDesignTracking.DataSet40()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDrafterSignoff = New System.Windows.Forms.Button()
        Me.btnSrEngineerSignoff = New System.Windows.Forms.Button()
        Me.btnStressSignoff = New System.Windows.Forms.Button()
        Me.btnOperationsSignoff = New System.Windows.Forms.Button()
        Me.btnReleaserSignoff = New System.Windows.Forms.Button()
        Me.btnCMSignOff = New System.Windows.Forms.Button()
        CType(Me.DataSet401, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Review Status"
        '
        'Responsibility
        '
        Me.Responsibility.AutoSize = True
        Me.Responsibility.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Responsibility.Location = New System.Drawing.Point(163, 52)
        Me.Responsibility.Name = "Responsibility"
        Me.Responsibility.Size = New System.Drawing.Size(106, 20)
        Me.Responsibility.TabIndex = 1
        Me.Responsibility.Text = "Responsibility"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Assigned To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Signed Off By"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(549, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Sign Off Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(163, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Drafter"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(163, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Sr. Engineer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(163, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Stress"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(163, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Operations"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(163, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Releaser"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(163, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "CM"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(731, 10)
        Me.Label11.TabIndex = 11
        '
        'txtDrafterAssigned
        '
        Me.txtDrafterAssigned.Enabled = False
        Me.txtDrafterAssigned.Location = New System.Drawing.Point(301, 101)
        Me.txtDrafterAssigned.Name = "txtDrafterAssigned"
        Me.txtDrafterAssigned.Size = New System.Drawing.Size(100, 20)
        Me.txtDrafterAssigned.TabIndex = 12
        '
        'txtSrEngineerAssigned
        '
        Me.txtSrEngineerAssigned.Enabled = False
        Me.txtSrEngineerAssigned.Location = New System.Drawing.Point(301, 139)
        Me.txtSrEngineerAssigned.Name = "txtSrEngineerAssigned"
        Me.txtSrEngineerAssigned.Size = New System.Drawing.Size(100, 20)
        Me.txtSrEngineerAssigned.TabIndex = 13
        '
        'txtStressAssigned
        '
        Me.txtStressAssigned.Enabled = False
        Me.txtStressAssigned.Location = New System.Drawing.Point(301, 183)
        Me.txtStressAssigned.Name = "txtStressAssigned"
        Me.txtStressAssigned.Size = New System.Drawing.Size(100, 20)
        Me.txtStressAssigned.TabIndex = 14
        '
        'txtOperationsAssigned
        '
        Me.txtOperationsAssigned.Enabled = False
        Me.txtOperationsAssigned.Location = New System.Drawing.Point(301, 227)
        Me.txtOperationsAssigned.Name = "txtOperationsAssigned"
        Me.txtOperationsAssigned.Size = New System.Drawing.Size(100, 20)
        Me.txtOperationsAssigned.TabIndex = 15
        '
        'txtReleaserAssigned
        '
        Me.txtReleaserAssigned.Enabled = False
        Me.txtReleaserAssigned.Location = New System.Drawing.Point(301, 263)
        Me.txtReleaserAssigned.Name = "txtReleaserAssigned"
        Me.txtReleaserAssigned.Size = New System.Drawing.Size(100, 20)
        Me.txtReleaserAssigned.TabIndex = 16
        '
        'txtCMAssigned
        '
        Me.txtCMAssigned.Location = New System.Drawing.Point(301, 303)
        Me.txtCMAssigned.Name = "txtCMAssigned"
        Me.txtCMAssigned.Size = New System.Drawing.Size(100, 20)
        Me.txtCMAssigned.TabIndex = 17
        Me.txtCMAssigned.Visible = False
        '
        'txtDrafterSignedOffBy
        '
        Me.txtDrafterSignedOffBy.Location = New System.Drawing.Point(415, 101)
        Me.txtDrafterSignedOffBy.Name = "txtDrafterSignedOffBy"
        Me.txtDrafterSignedOffBy.ReadOnly = True
        Me.txtDrafterSignedOffBy.Size = New System.Drawing.Size(100, 20)
        Me.txtDrafterSignedOffBy.TabIndex = 18
        '
        'txtSrEngineerSignedOffBy
        '
        Me.txtSrEngineerSignedOffBy.Location = New System.Drawing.Point(415, 141)
        Me.txtSrEngineerSignedOffBy.Name = "txtSrEngineerSignedOffBy"
        Me.txtSrEngineerSignedOffBy.ReadOnly = True
        Me.txtSrEngineerSignedOffBy.Size = New System.Drawing.Size(100, 20)
        Me.txtSrEngineerSignedOffBy.TabIndex = 19
        '
        'txtStressSignedOffBy
        '
        Me.txtStressSignedOffBy.Location = New System.Drawing.Point(415, 183)
        Me.txtStressSignedOffBy.Name = "txtStressSignedOffBy"
        Me.txtStressSignedOffBy.ReadOnly = True
        Me.txtStressSignedOffBy.Size = New System.Drawing.Size(100, 20)
        Me.txtStressSignedOffBy.TabIndex = 20
        '
        'txtOperationsSignedOffBy
        '
        Me.txtOperationsSignedOffBy.Location = New System.Drawing.Point(415, 227)
        Me.txtOperationsSignedOffBy.Name = "txtOperationsSignedOffBy"
        Me.txtOperationsSignedOffBy.ReadOnly = True
        Me.txtOperationsSignedOffBy.Size = New System.Drawing.Size(100, 20)
        Me.txtOperationsSignedOffBy.TabIndex = 21
        '
        'txtReleaserSignedOffBy
        '
        Me.txtReleaserSignedOffBy.Location = New System.Drawing.Point(415, 265)
        Me.txtReleaserSignedOffBy.Name = "txtReleaserSignedOffBy"
        Me.txtReleaserSignedOffBy.ReadOnly = True
        Me.txtReleaserSignedOffBy.Size = New System.Drawing.Size(100, 20)
        Me.txtReleaserSignedOffBy.TabIndex = 22
        '
        'txtCMSignedOffBy
        '
        Me.txtCMSignedOffBy.Location = New System.Drawing.Point(415, 303)
        Me.txtCMSignedOffBy.Name = "txtCMSignedOffBy"
        Me.txtCMSignedOffBy.ReadOnly = True
        Me.txtCMSignedOffBy.Size = New System.Drawing.Size(100, 20)
        Me.txtCMSignedOffBy.TabIndex = 23
        '
        'dtDrafterSignOff
        '
        Me.dtDrafterSignOff.CustomFormat = "MM/dd/yyyy"
        Me.dtDrafterSignOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDrafterSignOff.Location = New System.Drawing.Point(553, 100)
        Me.dtDrafterSignOff.Name = "dtDrafterSignOff"
        Me.dtDrafterSignOff.Size = New System.Drawing.Size(111, 20)
        Me.dtDrafterSignOff.TabIndex = 24
        '
        'dtSrEngineerSignOff
        '
        Me.dtSrEngineerSignOff.CustomFormat = "MM/dd/yyyy"
        Me.dtSrEngineerSignOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSrEngineerSignOff.Location = New System.Drawing.Point(553, 141)
        Me.dtSrEngineerSignOff.Name = "dtSrEngineerSignOff"
        Me.dtSrEngineerSignOff.Size = New System.Drawing.Size(111, 20)
        Me.dtSrEngineerSignOff.TabIndex = 25
        '
        'dtStressSignOff
        '
        Me.dtStressSignOff.CustomFormat = "MM/dd/yyyy"
        Me.dtStressSignOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtStressSignOff.Location = New System.Drawing.Point(553, 183)
        Me.dtStressSignOff.Name = "dtStressSignOff"
        Me.dtStressSignOff.Size = New System.Drawing.Size(111, 20)
        Me.dtStressSignOff.TabIndex = 26
        '
        'dtOperationsSignOff
        '
        Me.dtOperationsSignOff.CustomFormat = "MM/dd/yyyy"
        Me.dtOperationsSignOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtOperationsSignOff.Location = New System.Drawing.Point(553, 227)
        Me.dtOperationsSignOff.Name = "dtOperationsSignOff"
        Me.dtOperationsSignOff.Size = New System.Drawing.Size(111, 20)
        Me.dtOperationsSignOff.TabIndex = 27
        '
        'dtReleaserSignOff
        '
        Me.dtReleaserSignOff.CustomFormat = "MM/dd/yyyy"
        Me.dtReleaserSignOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReleaserSignOff.Location = New System.Drawing.Point(553, 265)
        Me.dtReleaserSignOff.Name = "dtReleaserSignOff"
        Me.dtReleaserSignOff.Size = New System.Drawing.Size(111, 20)
        Me.dtReleaserSignOff.TabIndex = 28
        '
        'dtCMSignOff
        '
        Me.dtCMSignOff.CustomFormat = "MM/dd/yyyy"
        Me.dtCMSignOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtCMSignOff.Location = New System.Drawing.Point(553, 303)
        Me.dtCMSignOff.Name = "dtCMSignOff"
        Me.dtCMSignOff.Size = New System.Drawing.Size(111, 20)
        Me.dtCMSignOff.TabIndex = 29
        '
        'lblDrafterStatus
        '
        Me.lblDrafterStatus.AutoSize = True
        Me.lblDrafterStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrafterStatus.Location = New System.Drawing.Point(29, 101)
        Me.lblDrafterStatus.Name = "lblDrafterStatus"
        Me.lblDrafterStatus.Size = New System.Drawing.Size(59, 20)
        Me.lblDrafterStatus.TabIndex = 30
        Me.lblDrafterStatus.Text = "Drafter"
        '
        'lblSrEngineerStatus
        '
        Me.lblSrEngineerStatus.AutoSize = True
        Me.lblSrEngineerStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSrEngineerStatus.Location = New System.Drawing.Point(29, 141)
        Me.lblSrEngineerStatus.Name = "lblSrEngineerStatus"
        Me.lblSrEngineerStatus.Size = New System.Drawing.Size(59, 20)
        Me.lblSrEngineerStatus.TabIndex = 31
        Me.lblSrEngineerStatus.Text = "Drafter"
        '
        'lblStressStatus
        '
        Me.lblStressStatus.AutoSize = True
        Me.lblStressStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStressStatus.Location = New System.Drawing.Point(29, 184)
        Me.lblStressStatus.Name = "lblStressStatus"
        Me.lblStressStatus.Size = New System.Drawing.Size(59, 20)
        Me.lblStressStatus.TabIndex = 32
        Me.lblStressStatus.Text = "Drafter"
        '
        'lblOperationsStatus
        '
        Me.lblOperationsStatus.AutoSize = True
        Me.lblOperationsStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperationsStatus.Location = New System.Drawing.Point(29, 225)
        Me.lblOperationsStatus.Name = "lblOperationsStatus"
        Me.lblOperationsStatus.Size = New System.Drawing.Size(59, 20)
        Me.lblOperationsStatus.TabIndex = 33
        Me.lblOperationsStatus.Text = "Drafter"
        '
        'lblReleaserStatus
        '
        Me.lblReleaserStatus.AutoSize = True
        Me.lblReleaserStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReleaserStatus.Location = New System.Drawing.Point(29, 261)
        Me.lblReleaserStatus.Name = "lblReleaserStatus"
        Me.lblReleaserStatus.Size = New System.Drawing.Size(59, 20)
        Me.lblReleaserStatus.TabIndex = 34
        Me.lblReleaserStatus.Text = "Drafter"
        '
        'lblCMStatus
        '
        Me.lblCMStatus.AutoSize = True
        Me.lblCMStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCMStatus.Location = New System.Drawing.Point(29, 301)
        Me.lblCMStatus.Name = "lblCMStatus"
        Me.lblCMStatus.Size = New System.Drawing.Size(59, 20)
        Me.lblCMStatus.TabIndex = 35
        Me.lblCMStatus.Text = "Drafter"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=engdwgtest;Persist Security Info=" &
    "True;User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection2
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ActualFinishDate", System.Data.SqlDbType.[Date], 0, "ActualFinishDate"), New System.Data.SqlClient.SqlParameter("@Drafter", System.Data.SqlDbType.NVarChar, 0, "Drafter"), New System.Data.SqlClient.SqlParameter("@DrafterComplete", System.Data.SqlDbType.[Date], 0, "DrafterComplete"), New System.Data.SqlClient.SqlParameter("@DrafterSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "DrafterSignedOffBy"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@EngineerSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "EngineerSignedOffBy"), New System.Data.SqlClient.SqlParameter("@EngineerComplete", System.Data.SqlDbType.[Date], 0, "EngineerComplete"), New System.Data.SqlClient.SqlParameter("@SrEngineer", System.Data.SqlDbType.NVarChar, 0, "SrEngineer"), New System.Data.SqlClient.SqlParameter("@SrEngineerSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "SrEngineerSignedOffBy"), New System.Data.SqlClient.SqlParameter("@SrEngineerComplete", System.Data.SqlDbType.[Date], 0, "SrEngineerComplete"), New System.Data.SqlClient.SqlParameter("@ReleaserSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "ReleaserSignedOffBy"), New System.Data.SqlClient.SqlParameter("@Releaser", System.Data.SqlDbType.NVarChar, 0, "Releaser"), New System.Data.SqlClient.SqlParameter("@ReleaserCompelte", System.Data.SqlDbType.[Date], 0, "ReleaserCompelte"), New System.Data.SqlClient.SqlParameter("@CMSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "CMSignedOffBy"), New System.Data.SqlClient.SqlParameter("@Stress", System.Data.SqlDbType.NVarChar, 0, "Stress"), New System.Data.SqlClient.SqlParameter("@StressComplete", System.Data.SqlDbType.[Date], 0, "StressComplete"), New System.Data.SqlClient.SqlParameter("@StressSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "StressSignedOffBy")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ActualFinishDate", System.Data.SqlDbType.[Date], 0, "ActualFinishDate"), New System.Data.SqlClient.SqlParameter("@Drafter", System.Data.SqlDbType.NVarChar, 0, "Drafter"), New System.Data.SqlClient.SqlParameter("@DrafterComplete", System.Data.SqlDbType.[Date], 0, "DrafterComplete"), New System.Data.SqlClient.SqlParameter("@DrafterSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "DrafterSignedOffBy"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.NVarChar, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@EngineerSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "EngineerSignedOffBy"), New System.Data.SqlClient.SqlParameter("@EngineerComplete", System.Data.SqlDbType.[Date], 0, "EngineerComplete"), New System.Data.SqlClient.SqlParameter("@SrEngineer", System.Data.SqlDbType.NVarChar, 0, "SrEngineer"), New System.Data.SqlClient.SqlParameter("@SrEngineerSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "SrEngineerSignedOffBy"), New System.Data.SqlClient.SqlParameter("@SrEngineerComplete", System.Data.SqlDbType.[Date], 0, "SrEngineerComplete"), New System.Data.SqlClient.SqlParameter("@ReleaserSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "ReleaserSignedOffBy"), New System.Data.SqlClient.SqlParameter("@Releaser", System.Data.SqlDbType.NVarChar, 0, "Releaser"), New System.Data.SqlClient.SqlParameter("@ReleaserCompelte", System.Data.SqlDbType.[Date], 0, "ReleaserCompelte"), New System.Data.SqlClient.SqlParameter("@CMSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "CMSignedOffBy"), New System.Data.SqlClient.SqlParameter("@Stress", System.Data.SqlDbType.NVarChar, 0, "Stress"), New System.Data.SqlClient.SqlParameter("@StressComplete", System.Data.SqlDbType.[Date], 0, "StressComplete"), New System.Data.SqlClient.SqlParameter("@StressSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "StressSignedOffBy"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Drafter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Drafter", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Releaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Releaser", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserCompelte", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserCompelte", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CMSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CMSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CMSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CMSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Stress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Stress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Drafter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Drafter", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drafter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrafterSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrafterSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrafterSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrafterSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SrEngineerComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SrEngineerComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SrEngineerComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Releaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Releaser", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Releaser", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReleaserCompelte", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReleaserCompelte", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReleaserCompelte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CMSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CMSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CMSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CMSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Stress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Stress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressComplete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressComplete", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_StressSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "StressSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_StressSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StressSignedOffBy", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawings", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("ActualFinishDate", "ActualFinishDate"), New System.Data.Common.DataColumnMapping("Drafter", "Drafter"), New System.Data.Common.DataColumnMapping("DrafterComplete", "DrafterComplete"), New System.Data.Common.DataColumnMapping("DrafterSignedOffBy", "DrafterSignedOffBy"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerSignedOffBy", "EngineerSignedOffBy"), New System.Data.Common.DataColumnMapping("EngineerComplete", "EngineerComplete"), New System.Data.Common.DataColumnMapping("SrEngineer", "SrEngineer"), New System.Data.Common.DataColumnMapping("SrEngineerSignedOffBy", "SrEngineerSignedOffBy"), New System.Data.Common.DataColumnMapping("SrEngineerComplete", "SrEngineerComplete"), New System.Data.Common.DataColumnMapping("ReleaserSignedOffBy", "ReleaserSignedOffBy"), New System.Data.Common.DataColumnMapping("Releaser", "Releaser"), New System.Data.Common.DataColumnMapping("ReleaserCompelte", "ReleaserCompelte"), New System.Data.Common.DataColumnMapping("CMSignedOffBy", "CMSignedOffBy"), New System.Data.Common.DataColumnMapping("Stress", "Stress"), New System.Data.Common.DataColumnMapping("StressComplete", "StressComplete"), New System.Data.Common.DataColumnMapping("StressSignedOffBy", "StressSignedOffBy")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DataSet401
        '
        Me.DataSet401.DataSetName = "DataSet40"
        Me.DataSet401.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblDrawings"
        Me.BindingSource1.DataSource = Me.DataSet401
        '
        'btnDrafterSignoff
        '
        Me.btnDrafterSignoff.Location = New System.Drawing.Point(670, 100)
        Me.btnDrafterSignoff.Name = "btnDrafterSignoff"
        Me.btnDrafterSignoff.Size = New System.Drawing.Size(75, 23)
        Me.btnDrafterSignoff.TabIndex = 36
        Me.btnDrafterSignoff.Text = "Button1"
        Me.btnDrafterSignoff.UseVisualStyleBackColor = True
        '
        'btnSrEngineerSignoff
        '
        Me.btnSrEngineerSignoff.Location = New System.Drawing.Point(670, 142)
        Me.btnSrEngineerSignoff.Name = "btnSrEngineerSignoff"
        Me.btnSrEngineerSignoff.Size = New System.Drawing.Size(75, 23)
        Me.btnSrEngineerSignoff.TabIndex = 37
        Me.btnSrEngineerSignoff.Text = "Button1"
        Me.btnSrEngineerSignoff.UseVisualStyleBackColor = True
        '
        'btnStressSignoff
        '
        Me.btnStressSignoff.Location = New System.Drawing.Point(670, 184)
        Me.btnStressSignoff.Name = "btnStressSignoff"
        Me.btnStressSignoff.Size = New System.Drawing.Size(75, 23)
        Me.btnStressSignoff.TabIndex = 38
        Me.btnStressSignoff.Text = "Button1"
        Me.btnStressSignoff.UseVisualStyleBackColor = True
        '
        'btnOperationsSignoff
        '
        Me.btnOperationsSignoff.Location = New System.Drawing.Point(670, 227)
        Me.btnOperationsSignoff.Name = "btnOperationsSignoff"
        Me.btnOperationsSignoff.Size = New System.Drawing.Size(75, 23)
        Me.btnOperationsSignoff.TabIndex = 39
        Me.btnOperationsSignoff.Text = "Button1"
        Me.btnOperationsSignoff.UseVisualStyleBackColor = True
        '
        'btnReleaserSignoff
        '
        Me.btnReleaserSignoff.Location = New System.Drawing.Point(670, 266)
        Me.btnReleaserSignoff.Name = "btnReleaserSignoff"
        Me.btnReleaserSignoff.Size = New System.Drawing.Size(75, 23)
        Me.btnReleaserSignoff.TabIndex = 40
        Me.btnReleaserSignoff.Text = "Button1"
        Me.btnReleaserSignoff.UseVisualStyleBackColor = True
        '
        'btnCMSignOff
        '
        Me.btnCMSignOff.Location = New System.Drawing.Point(670, 304)
        Me.btnCMSignOff.Name = "btnCMSignOff"
        Me.btnCMSignOff.Size = New System.Drawing.Size(75, 23)
        Me.btnCMSignOff.TabIndex = 41
        Me.btnCMSignOff.Text = "Button1"
        Me.btnCMSignOff.UseVisualStyleBackColor = True
        '
        'frmEngWorkflowSignOff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 372)
        Me.Controls.Add(Me.btnCMSignOff)
        Me.Controls.Add(Me.btnReleaserSignoff)
        Me.Controls.Add(Me.btnOperationsSignoff)
        Me.Controls.Add(Me.btnStressSignoff)
        Me.Controls.Add(Me.btnSrEngineerSignoff)
        Me.Controls.Add(Me.btnDrafterSignoff)
        Me.Controls.Add(Me.lblCMStatus)
        Me.Controls.Add(Me.lblReleaserStatus)
        Me.Controls.Add(Me.lblOperationsStatus)
        Me.Controls.Add(Me.lblStressStatus)
        Me.Controls.Add(Me.lblSrEngineerStatus)
        Me.Controls.Add(Me.lblDrafterStatus)
        Me.Controls.Add(Me.dtCMSignOff)
        Me.Controls.Add(Me.dtReleaserSignOff)
        Me.Controls.Add(Me.dtOperationsSignOff)
        Me.Controls.Add(Me.dtStressSignOff)
        Me.Controls.Add(Me.dtSrEngineerSignOff)
        Me.Controls.Add(Me.dtDrafterSignOff)
        Me.Controls.Add(Me.txtCMSignedOffBy)
        Me.Controls.Add(Me.txtReleaserSignedOffBy)
        Me.Controls.Add(Me.txtOperationsSignedOffBy)
        Me.Controls.Add(Me.txtStressSignedOffBy)
        Me.Controls.Add(Me.txtSrEngineerSignedOffBy)
        Me.Controls.Add(Me.txtDrafterSignedOffBy)
        Me.Controls.Add(Me.txtCMAssigned)
        Me.Controls.Add(Me.txtReleaserAssigned)
        Me.Controls.Add(Me.txtOperationsAssigned)
        Me.Controls.Add(Me.txtStressAssigned)
        Me.Controls.Add(Me.txtSrEngineerAssigned)
        Me.Controls.Add(Me.txtDrafterAssigned)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Responsibility)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEngWorkflowSignOff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FDT - Sign Off"
        CType(Me.DataSet401, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Responsibility As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDrafterAssigned As TextBox
    Friend WithEvents txtSrEngineerAssigned As TextBox
    Friend WithEvents txtStressAssigned As TextBox
    Friend WithEvents txtOperationsAssigned As TextBox
    Friend WithEvents txtReleaserAssigned As TextBox
    Friend WithEvents txtCMAssigned As TextBox
    Friend WithEvents txtDrafterSignedOffBy As TextBox
    Friend WithEvents txtSrEngineerSignedOffBy As TextBox
    Friend WithEvents txtStressSignedOffBy As TextBox
    Friend WithEvents txtOperationsSignedOffBy As TextBox
    Friend WithEvents txtReleaserSignedOffBy As TextBox
    Friend WithEvents txtCMSignedOffBy As TextBox
    Friend WithEvents dtDrafterSignOff As DateTimePicker
    Friend WithEvents dtSrEngineerSignOff As DateTimePicker
    Friend WithEvents dtStressSignOff As DateTimePicker
    Friend WithEvents dtOperationsSignOff As DateTimePicker
    Friend WithEvents dtReleaserSignOff As DateTimePicker
    Friend WithEvents dtCMSignOff As DateTimePicker
    Friend WithEvents lblDrafterStatus As Label
    Friend WithEvents lblSrEngineerStatus As Label
    Friend WithEvents lblStressStatus As Label
    Friend WithEvents lblOperationsStatus As Label
    Friend WithEvents lblReleaserStatus As Label
    Friend WithEvents lblCMStatus As Label
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet401 As DataSet40
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btnDrafterSignoff As Button
    Friend WithEvents btnSrEngineerSignoff As Button
    Friend WithEvents btnStressSignoff As Button
    Friend WithEvents btnOperationsSignoff As Button
    Friend WithEvents btnReleaserSignoff As Button
    Friend WithEvents btnCMSignOff As Button
End Class
