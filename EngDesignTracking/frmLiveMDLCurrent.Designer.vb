<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLiveMDLCurrent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiveMDLCurrent))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPrepForIssue = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnLoadNew = New System.Windows.Forms.Button()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        Me.txtRev = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtDrawingNumber = New System.Windows.Forms.TextBox()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet331 = New EngDesignTracking.DataSet33()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRevision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMDLNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLVL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRevision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualFinishDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLVLDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTopLVL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTopLVLDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLVLLVLDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCancelled = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeferToNextMDL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShowPreviousRev = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOverrideDRNDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShowRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarksText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOverrideDRNText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShowPreviousRevText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLastRefresh = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbProgress = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMDLNo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblRev = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnUnlock = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblDocumentNumber = New System.Windows.Forms.Label()
        Me.txtDocumentNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet331, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbProgress.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(151, 37)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(71, 25)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPrepForIssue)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.btnView)
        Me.GroupBox1.Controls.Add(Me.btnLoadNew)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(548, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(932, 112)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'btnPrepForIssue
        '
        Me.btnPrepForIssue.Location = New System.Drawing.Point(658, 42)
        Me.btnPrepForIssue.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrepForIssue.Name = "btnPrepForIssue"
        Me.btnPrepForIssue.Size = New System.Drawing.Size(203, 46)
        Me.btnPrepForIssue.TabIndex = 3
        Me.btnPrepForIssue.Text = "Prep For Issue"
        Me.btnPrepForIssue.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(448, 42)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(203, 46)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(238, 42)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(203, 46)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnLoadNew
        '
        Me.btnLoadNew.Location = New System.Drawing.Point(28, 42)
        Me.btnLoadNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLoadNew.Name = "btnLoadNew"
        Me.btnLoadNew.Size = New System.Drawing.Size(203, 46)
        Me.btnLoadNew.TabIndex = 0
        Me.btnLoadNew.Text = "Load / New"
        Me.btnLoadNew.UseVisualStyleBackColor = True
        '
        'txtRecordID
        '
        Me.txtRecordID.Location = New System.Drawing.Point(205, 642)
        Me.txtRecordID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(132, 22)
        Me.txtRecordID.TabIndex = 4
        '
        'txtRev
        '
        Me.txtRev.Location = New System.Drawing.Point(347, 642)
        Me.txtRev.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRev.Name = "txtRev"
        Me.txtRev.Size = New System.Drawing.Size(132, 22)
        Me.txtRev.TabIndex = 5
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(508, 640)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(132, 22)
        Me.txtTitle.TabIndex = 6
        '
        'txtDrawingNumber
        '
        Me.txtDrawingNumber.Location = New System.Drawing.Point(642, 702)
        Me.txtDrawingNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDrawingNumber.Name = "txtDrawingNumber"
        Me.txtDrawingNumber.Size = New System.Drawing.Size(89, 22)
        Me.txtDrawingNumber.TabIndex = 7
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT tblLiveMDLDetail.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   tblLiveMDLDetail"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MDLRecordID", System.Data.SqlDbType.Int, 0, "MDLRecordID"), New System.Data.SqlClient.SqlParameter("@Revision", System.Data.SqlDbType.NVarChar, 0, "Revision"), New System.Data.SqlClient.SqlParameter("@MDLNumber", System.Data.SqlDbType.Int, 0, "MDLNumber"), New System.Data.SqlClient.SqlParameter("@LVL", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(1, Byte), "LVL", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@ActualFinishDate", System.Data.SqlDbType.[Date], 0, "ActualFinishDate"), New System.Data.SqlClient.SqlParameter("@DrawingTitle", System.Data.SqlDbType.NVarChar, 0, "DrawingTitle"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@SystemDescription", System.Data.SqlDbType.NVarChar, 0, "SystemDescription"), New System.Data.SqlClient.SqlParameter("@DrawingType", System.Data.SqlDbType.NVarChar, 0, "DrawingType"), New System.Data.SqlClient.SqlParameter("@LVLDesc", System.Data.SqlDbType.NVarChar, 0, "LVLDesc"), New System.Data.SqlClient.SqlParameter("@TopLVL", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(1, Byte), "TopLVL", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TopLVLDesc", System.Data.SqlDbType.NVarChar, 0, "TopLVLDesc"), New System.Data.SqlClient.SqlParameter("@LVLLVLDesc", System.Data.SqlDbType.NVarChar, 0, "LVLLVLDesc"), New System.Data.SqlClient.SqlParameter("@Cancelled", System.Data.SqlDbType.Bit, 0, "Cancelled"), New System.Data.SqlClient.SqlParameter("@DeferToNextMDL", System.Data.SqlDbType.Bit, 0, "DeferToNextMDL"), New System.Data.SqlClient.SqlParameter("@ShowPreviousRev", System.Data.SqlDbType.Bit, 0, "ShowPreviousRev"), New System.Data.SqlClient.SqlParameter("@OverrideDRNDetails", System.Data.SqlDbType.Bit, 0, "OverrideDRNDetails"), New System.Data.SqlClient.SqlParameter("@ShowRemarks", System.Data.SqlDbType.Bit, 0, "ShowRemarks"), New System.Data.SqlClient.SqlParameter("@RemarksText", System.Data.SqlDbType.NVarChar, 0, "RemarksText"), New System.Data.SqlClient.SqlParameter("@OverrideDRNText", System.Data.SqlDbType.NVarChar, 0, "OverrideDRNText"), New System.Data.SqlClient.SqlParameter("@ShowPreviousRevText", System.Data.SqlDbType.NVarChar, 0, "ShowPreviousRevText")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MDLRecordID", System.Data.SqlDbType.Int, 0, "MDLRecordID"), New System.Data.SqlClient.SqlParameter("@Revision", System.Data.SqlDbType.NVarChar, 0, "Revision"), New System.Data.SqlClient.SqlParameter("@MDLNumber", System.Data.SqlDbType.Int, 0, "MDLNumber"), New System.Data.SqlClient.SqlParameter("@LVL", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(1, Byte), "LVL", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@ActualFinishDate", System.Data.SqlDbType.[Date], 0, "ActualFinishDate"), New System.Data.SqlClient.SqlParameter("@DrawingTitle", System.Data.SqlDbType.NVarChar, 0, "DrawingTitle"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 0, "Notes"), New System.Data.SqlClient.SqlParameter("@SystemDescription", System.Data.SqlDbType.NVarChar, 0, "SystemDescription"), New System.Data.SqlClient.SqlParameter("@DrawingType", System.Data.SqlDbType.NVarChar, 0, "DrawingType"), New System.Data.SqlClient.SqlParameter("@LVLDesc", System.Data.SqlDbType.NVarChar, 0, "LVLDesc"), New System.Data.SqlClient.SqlParameter("@TopLVL", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(1, Byte), "TopLVL", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TopLVLDesc", System.Data.SqlDbType.NVarChar, 0, "TopLVLDesc"), New System.Data.SqlClient.SqlParameter("@LVLLVLDesc", System.Data.SqlDbType.NVarChar, 0, "LVLLVLDesc"), New System.Data.SqlClient.SqlParameter("@Cancelled", System.Data.SqlDbType.Bit, 0, "Cancelled"), New System.Data.SqlClient.SqlParameter("@DeferToNextMDL", System.Data.SqlDbType.Bit, 0, "DeferToNextMDL"), New System.Data.SqlClient.SqlParameter("@ShowPreviousRev", System.Data.SqlDbType.Bit, 0, "ShowPreviousRev"), New System.Data.SqlClient.SqlParameter("@OverrideDRNDetails", System.Data.SqlDbType.Bit, 0, "OverrideDRNDetails"), New System.Data.SqlClient.SqlParameter("@ShowRemarks", System.Data.SqlDbType.Bit, 0, "ShowRemarks"), New System.Data.SqlClient.SqlParameter("@RemarksText", System.Data.SqlDbType.NVarChar, 0, "RemarksText"), New System.Data.SqlClient.SqlParameter("@OverrideDRNText", System.Data.SqlDbType.NVarChar, 0, "OverrideDRNText"), New System.Data.SqlClient.SqlParameter("@ShowPreviousRevText", System.Data.SqlDbType.NVarChar, 0, "ShowPreviousRevText"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MDLRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MDLRecordID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MDLRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MDLRecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Revision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Revision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Revision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Revision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MDLNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MDLNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MDLNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MDLNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LVL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LVL", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LVL", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(1, Byte), "LVL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SystemDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SystemDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LVLDesc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LVLDesc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LVLDesc", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LVLDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TopLVL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TopLVL", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TopLVL", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(1, Byte), "TopLVL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TopLVLDesc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TopLVLDesc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TopLVLDesc", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopLVLDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LVLLVLDesc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LVLLVLDesc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LVLLVLDesc", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LVLLVLDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Cancelled", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cancelled", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Cancelled", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cancelled", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DeferToNextMDL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DeferToNextMDL", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DeferToNextMDL", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeferToNextMDL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ShowPreviousRev", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ShowPreviousRev", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ShowPreviousRev", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShowPreviousRev", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OverrideDRNDetails", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OverrideDRNDetails", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OverrideDRNDetails", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OverrideDRNDetails", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ShowRemarks", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ShowRemarks", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ShowRemarks", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShowRemarks", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RemarksText", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RemarksText", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RemarksText", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RemarksText", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OverrideDRNText", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OverrideDRNText", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OverrideDRNText", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OverrideDRNText", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ShowPreviousRevText", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ShowPreviousRevText", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ShowPreviousRevText", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShowPreviousRevText", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MDLRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MDLRecordID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MDLRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MDLRecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Revision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Revision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Revision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Revision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_MDLNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MDLNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_MDLNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MDLNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LVL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LVL", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LVL", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(1, Byte), "LVL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ActualFinishDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ActualFinishDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ActualFinishDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SystemDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SystemDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LVLDesc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LVLDesc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LVLDesc", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LVLDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TopLVL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TopLVL", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TopLVL", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(1, Byte), "TopLVL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TopLVLDesc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TopLVLDesc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TopLVLDesc", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TopLVLDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LVLLVLDesc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LVLLVLDesc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LVLLVLDesc", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LVLLVLDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Cancelled", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cancelled", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Cancelled", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cancelled", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DeferToNextMDL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DeferToNextMDL", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DeferToNextMDL", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeferToNextMDL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ShowPreviousRev", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ShowPreviousRev", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ShowPreviousRev", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShowPreviousRev", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OverrideDRNDetails", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OverrideDRNDetails", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OverrideDRNDetails", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OverrideDRNDetails", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ShowRemarks", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ShowRemarks", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ShowRemarks", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShowRemarks", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RemarksText", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RemarksText", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RemarksText", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RemarksText", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OverrideDRNText", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OverrideDRNText", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OverrideDRNText", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OverrideDRNText", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ShowPreviousRevText", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ShowPreviousRevText", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ShowPreviousRevText", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShowPreviousRevText", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblLiveMDLDetail", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("MDLRecordID", "MDLRecordID"), New System.Data.Common.DataColumnMapping("Revision", "Revision"), New System.Data.Common.DataColumnMapping("MDLNumber", "MDLNumber"), New System.Data.Common.DataColumnMapping("LVL", "LVL"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("ActualFinishDate", "ActualFinishDate"), New System.Data.Common.DataColumnMapping("DrawingTitle", "DrawingTitle"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("SystemDescription", "SystemDescription"), New System.Data.Common.DataColumnMapping("DrawingType", "DrawingType"), New System.Data.Common.DataColumnMapping("LVLDesc", "LVLDesc"), New System.Data.Common.DataColumnMapping("TopLVL", "TopLVL"), New System.Data.Common.DataColumnMapping("TopLVLDesc", "TopLVLDesc"), New System.Data.Common.DataColumnMapping("LVLLVLDesc", "LVLLVLDesc"), New System.Data.Common.DataColumnMapping("Cancelled", "Cancelled"), New System.Data.Common.DataColumnMapping("DeferToNextMDL", "DeferToNextMDL"), New System.Data.Common.DataColumnMapping("ShowPreviousRev", "ShowPreviousRev"), New System.Data.Common.DataColumnMapping("OverrideDRNDetails", "OverrideDRNDetails"), New System.Data.Common.DataColumnMapping("ShowRemarks", "ShowRemarks"), New System.Data.Common.DataColumnMapping("RemarksText", "RemarksText"), New System.Data.Common.DataColumnMapping("OverrideDRNText", "OverrideDRNText"), New System.Data.Common.DataColumnMapping("ShowPreviousRevText", "ShowPreviousRevText")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Location = New System.Drawing.Point(11, 298)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1880, 615)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblLiveMDLDetail"
        Me.BindingSource1.DataSource = Me.DataSet331
        '
        'DataSet331
        '
        Me.DataSet331.DataSetName = "DataSet33"
        Me.DataSet331.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colRecordID, Me.colMDLRecordID, Me.colRevision, Me.colMDLNumber, Me.colLVL, Me.colDrawingNumber, Me.colDwgRevision, Me.colActualFinishDate, Me.colDrawingTitle, Me.colStatus, Me.colNotes, Me.colSystemDescription, Me.colDrawingType, Me.colLVLDesc, Me.colTopLVL, Me.colTopLVLDesc, Me.colLVLLVLDesc, Me.colCancelled, Me.colDeferToNextMDL, Me.colShowPreviousRev, Me.colOverrideDRNDetails, Me.colShowRemarks, Me.colRemarksText, Me.colOverrideDRNText, Me.colShowPreviousRevText})
        Me.GridView1.DetailHeight = 279
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 2
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTopLVLDesc, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colLVLLVLDesc, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.GridColumn1.DisplayFormat.FormatString = "DD-MMM-YYYY"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn1.MinWidth = 27
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 83
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.MinWidth = 27
        Me.colRecordID.Name = "colRecordID"
        Me.colRecordID.Width = 100
        '
        'colMDLRecordID
        '
        Me.colMDLRecordID.FieldName = "MDLRecordID"
        Me.colMDLRecordID.MinWidth = 27
        Me.colMDLRecordID.Name = "colMDLRecordID"
        Me.colMDLRecordID.Width = 100
        '
        'colRevision
        '
        Me.colRevision.FieldName = "Revision"
        Me.colRevision.MinWidth = 27
        Me.colRevision.Name = "colRevision"
        Me.colRevision.Width = 100
        '
        'colMDLNumber
        '
        Me.colMDLNumber.FieldName = "MDLNumber"
        Me.colMDLNumber.MinWidth = 27
        Me.colMDLNumber.Name = "colMDLNumber"
        Me.colMDLNumber.Width = 100
        '
        'colLVL
        '
        Me.colLVL.FieldName = "LVL"
        Me.colLVL.MinWidth = 27
        Me.colLVL.Name = "colLVL"
        Me.colLVL.Width = 100
        '
        'colDrawingNumber
        '
        Me.colDrawingNumber.Caption = "Number"
        Me.colDrawingNumber.FieldName = "DrawingNumber"
        Me.colDrawingNumber.MinWidth = 27
        Me.colDrawingNumber.Name = "colDrawingNumber"
        Me.colDrawingNumber.Visible = True
        Me.colDrawingNumber.VisibleIndex = 1
        Me.colDrawingNumber.Width = 222
        '
        'colDwgRevision
        '
        Me.colDwgRevision.Caption = "Rev"
        Me.colDwgRevision.FieldName = "DwgRevision"
        Me.colDwgRevision.MinWidth = 27
        Me.colDwgRevision.Name = "colDwgRevision"
        Me.colDwgRevision.Visible = True
        Me.colDwgRevision.VisibleIndex = 2
        Me.colDwgRevision.Width = 222
        '
        'colActualFinishDate
        '
        Me.colActualFinishDate.Caption = "Date"
        Me.colActualFinishDate.DisplayFormat.FormatString = "dd-MMM-yyyy"
        Me.colActualFinishDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActualFinishDate.FieldName = "ActualFinishDate"
        Me.colActualFinishDate.MinWidth = 27
        Me.colActualFinishDate.Name = "colActualFinishDate"
        Me.colActualFinishDate.Visible = True
        Me.colActualFinishDate.VisibleIndex = 3
        Me.colActualFinishDate.Width = 222
        '
        'colDrawingTitle
        '
        Me.colDrawingTitle.Caption = "Title"
        Me.colDrawingTitle.FieldName = "DrawingTitle"
        Me.colDrawingTitle.MinWidth = 27
        Me.colDrawingTitle.Name = "colDrawingTitle"
        Me.colDrawingTitle.Visible = True
        Me.colDrawingTitle.VisibleIndex = 4
        Me.colDrawingTitle.Width = 222
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.MinWidth = 27
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 5
        Me.colStatus.Width = 222
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.MinWidth = 27
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Width = 100
        '
        'colSystemDescription
        '
        Me.colSystemDescription.FieldName = "SystemDescription"
        Me.colSystemDescription.MinWidth = 27
        Me.colSystemDescription.Name = "colSystemDescription"
        Me.colSystemDescription.Width = 100
        '
        'colDrawingType
        '
        Me.colDrawingType.FieldName = "DrawingType"
        Me.colDrawingType.MinWidth = 27
        Me.colDrawingType.Name = "colDrawingType"
        Me.colDrawingType.Width = 100
        '
        'colLVLDesc
        '
        Me.colLVLDesc.FieldName = "LVLDesc"
        Me.colLVLDesc.MinWidth = 27
        Me.colLVLDesc.Name = "colLVLDesc"
        Me.colLVLDesc.Width = 100
        '
        'colTopLVL
        '
        Me.colTopLVL.FieldName = "TopLVL"
        Me.colTopLVL.MinWidth = 27
        Me.colTopLVL.Name = "colTopLVL"
        Me.colTopLVL.Width = 100
        '
        'colTopLVLDesc
        '
        Me.colTopLVLDesc.Caption = " "
        Me.colTopLVLDesc.FieldName = "TopLVLDesc"
        Me.colTopLVLDesc.MinWidth = 27
        Me.colTopLVLDesc.Name = "colTopLVLDesc"
        Me.colTopLVLDesc.Visible = True
        Me.colTopLVLDesc.VisibleIndex = 7
        Me.colTopLVLDesc.Width = 100
        '
        'colLVLLVLDesc
        '
        Me.colLVLLVLDesc.Caption = "Section"
        Me.colLVLLVLDesc.FieldName = "LVLLVLDesc"
        Me.colLVLLVLDesc.MinWidth = 27
        Me.colLVLLVLDesc.Name = "colLVLLVLDesc"
        Me.colLVLLVLDesc.Visible = True
        Me.colLVLLVLDesc.VisibleIndex = 6
        Me.colLVLLVLDesc.Width = 100
        '
        'colCancelled
        '
        Me.colCancelled.FieldName = "Cancelled"
        Me.colCancelled.MinWidth = 27
        Me.colCancelled.Name = "colCancelled"
        Me.colCancelled.Width = 100
        '
        'colDeferToNextMDL
        '
        Me.colDeferToNextMDL.FieldName = "DeferToNextMDL"
        Me.colDeferToNextMDL.MinWidth = 27
        Me.colDeferToNextMDL.Name = "colDeferToNextMDL"
        Me.colDeferToNextMDL.Width = 100
        '
        'colShowPreviousRev
        '
        Me.colShowPreviousRev.FieldName = "ShowPreviousRev"
        Me.colShowPreviousRev.MinWidth = 27
        Me.colShowPreviousRev.Name = "colShowPreviousRev"
        Me.colShowPreviousRev.Width = 100
        '
        'colOverrideDRNDetails
        '
        Me.colOverrideDRNDetails.FieldName = "OverrideDRNDetails"
        Me.colOverrideDRNDetails.MinWidth = 27
        Me.colOverrideDRNDetails.Name = "colOverrideDRNDetails"
        Me.colOverrideDRNDetails.Width = 100
        '
        'colShowRemarks
        '
        Me.colShowRemarks.FieldName = "ShowRemarks"
        Me.colShowRemarks.MinWidth = 27
        Me.colShowRemarks.Name = "colShowRemarks"
        Me.colShowRemarks.Width = 100
        '
        'colRemarksText
        '
        Me.colRemarksText.Caption = "Remarks"
        Me.colRemarksText.FieldName = "RemarksText"
        Me.colRemarksText.MinWidth = 27
        Me.colRemarksText.Name = "colRemarksText"
        Me.colRemarksText.Visible = True
        Me.colRemarksText.VisibleIndex = 6
        Me.colRemarksText.Width = 232
        '
        'colOverrideDRNText
        '
        Me.colOverrideDRNText.FieldName = "OverrideDRNText"
        Me.colOverrideDRNText.MinWidth = 27
        Me.colOverrideDRNText.Name = "colOverrideDRNText"
        Me.colOverrideDRNText.Width = 100
        '
        'colShowPreviousRevText
        '
        Me.colShowPreviousRevText.FieldName = "ShowPreviousRevText"
        Me.colShowPreviousRevText.MinWidth = 27
        Me.colShowPreviousRevText.Name = "colShowPreviousRevText"
        Me.colShowPreviousRevText.Width = 100
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.HotPink
        Me.label1.Location = New System.Drawing.Point(1613, 316)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(21, 22)
        Me.label1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1735, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 22)
        Me.Label2.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1648, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Canceled"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1762, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Rev in Progress"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLastRefresh)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1506, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(391, 59)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Last Refresh"
        '
        'lblLastRefresh
        '
        Me.lblLastRefresh.AutoSize = True
        Me.lblLastRefresh.Location = New System.Drawing.Point(44, 27)
        Me.lblLastRefresh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastRefresh.Name = "lblLastRefresh"
        Me.lblLastRefresh.Size = New System.Drawing.Size(57, 17)
        Me.lblLastRefresh.TabIndex = 0
        Me.lblLastRefresh.Text = "Label7"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(1419, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 22)
        Me.Label5.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1458, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Defer to Next MDL"
        '
        'gbProgress
        '
        Me.gbProgress.Controls.Add(Me.ProgressBar1)
        Me.gbProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProgress.Location = New System.Drawing.Point(428, 324)
        Me.gbProgress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbProgress.Name = "gbProgress"
        Me.gbProgress.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbProgress.Size = New System.Drawing.Size(932, 188)
        Me.gbProgress.TabIndex = 16
        Me.gbProgress.TabStop = False
        Me.gbProgress.Text = "Progress"
        Me.gbProgress.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(35, 69)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(860, 58)
        Me.ProgressBar1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Status:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(151, 74)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(71, 25)
        Me.lblStatus.TabIndex = 18
        Me.lblStatus.Text = "Label8"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 37)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Title:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 255)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 25)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "MDL #:"
        Me.Label9.Visible = False
        '
        'lblMDLNo
        '
        Me.lblMDLNo.AutoSize = True
        Me.lblMDLNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMDLNo.Location = New System.Drawing.Point(152, 255)
        Me.lblMDLNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMDLNo.Name = "lblMDLNo"
        Me.lblMDLNo.Size = New System.Drawing.Size(71, 25)
        Me.lblMDLNo.TabIndex = 21
        Me.lblMDLNo.Text = "Label8"
        Me.lblMDLNo.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 160)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "REV:"
        '
        'lblRev
        '
        Me.lblRev.AutoSize = True
        Me.lblRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRev.Location = New System.Drawing.Point(151, 160)
        Me.lblRev.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRev.Name = "lblRev"
        Me.lblRev.Size = New System.Drawing.Size(71, 25)
        Me.lblRev.TabIndex = 23
        Me.lblRev.Text = "Label8"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnUnlock)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(548, 142)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(483, 108)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status Options"
        '
        'btnUnlock
        '
        Me.btnUnlock.Location = New System.Drawing.Point(44, 39)
        Me.btnUnlock.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(205, 32)
        Me.btnUnlock.TabIndex = 0
        Me.btnUnlock.Text = "Unlock (back to WIP)"
        Me.btnUnlock.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 115)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 25)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "MDL #:"
        '
        'lblDocumentNumber
        '
        Me.lblDocumentNumber.AutoSize = True
        Me.lblDocumentNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentNumber.Location = New System.Drawing.Point(151, 115)
        Me.lblDocumentNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDocumentNumber.Name = "lblDocumentNumber"
        Me.lblDocumentNumber.Size = New System.Drawing.Size(189, 25)
        Me.lblDocumentNumber.TabIndex = 26
        Me.lblDocumentNumber.Text = "lblDocumentNumber"
        '
        'txtDocumentNumber
        '
        Me.txtDocumentNumber.Location = New System.Drawing.Point(548, 274)
        Me.txtDocumentNumber.Name = "txtDocumentNumber"
        Me.txtDocumentNumber.Size = New System.Drawing.Size(8, 22)
        Me.txtDocumentNumber.TabIndex = 27
        '
        'frmLiveMDLCurrent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1710, 844)
        Me.Controls.Add(Me.txtDocumentNumber)
        Me.Controls.Add(Me.lblDocumentNumber)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblRev)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblMDLNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gbProgress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtDrawingNumber)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtRev)
        Me.Controls.Add(Me.txtRecordID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLiveMDLCurrent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLiveMDLCurrent"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet331, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbProgress.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents lblTitle As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLoadNew As Button
    Friend WithEvents btnPrepForIssue As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnView As Button
    Friend WithEvents txtRecordID As TextBox
    Friend WithEvents txtRev As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtDrawingNumber As TextBox
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet331 As DataSet33
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRevision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMDLNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLVL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRevision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualFinishDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLVLDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTopLVL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTopLVLDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLVLLVLDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCancelled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeferToNextMDL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShowPreviousRev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOverrideDRNDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShowRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarksText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOverrideDRNText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShowPreviousRevText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblLastRefresh As Label
    Friend WithEvents gbProgress As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label7 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblMDLNo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblRev As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnUnlock As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents lblDocumentNumber As Label
    Friend WithEvents txtDocumentNumber As TextBox
End Class
