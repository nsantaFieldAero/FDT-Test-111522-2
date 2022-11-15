<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEngWorkflow
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEngWorkflow))
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.bsMainGrid = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet241 = New EngDesignTracking.DataSet24()
        Me.DataSet201 = New EngDesignTracking.DataSet20()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cbomaininfoStress = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbomaininforeleaser = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbomaininfosrengineer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbomaininfoengineer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbomaininfodrafter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboMainRev = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboMainStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtmaininfoStressComp = New System.Windows.Forms.DateTimePicker()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.dtmaininforeleasercomp = New System.Windows.Forms.DateTimePicker()
        Me.dtmaininfosrengcomp = New System.Windows.Forms.DateTimePicker()
        Me.dtmaininfoengcomp = New System.Windows.Forms.DateTimePicker()
        Me.dtmaininfodraftercomp = New System.Windows.Forms.DateTimePicker()
        Me.txtmaininfotitle = New System.Windows.Forms.TextBox()
        Me.dtmaininfoactualfinishdt = New System.Windows.Forms.DateTimePicker()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.bsMainInformationTab = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet211 = New EngDesignTracking.DataSet21()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDwgRevision1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDRNADCN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADCN2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingTitle1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualFinishDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafter1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterComplete1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerComplete1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerComplete1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaser1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserCompelte1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriority1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestBy1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystemDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActionDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForecastStartDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForecastFinishDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannedFinishDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDurationHours1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercentComplete1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingFolderAssignDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignWIPDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModelTemplateDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammability1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityComplete1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStress1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStressComplete1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterPlannedCompleteDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerPlannedCompleteDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerPlannedCompleteDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityPlannedCompleteDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStressPlannedCompleteDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserPlannedCompleteDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionics1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsComplete1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsPlannedComplete1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanical1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalComplete1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalPlannedComplete1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWONumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNextHigherAssembly1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstallationDrawing1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhiteBoardNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAProjectNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPSCPDocsRequired1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyFlightTestRequired1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgReqDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewRework1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdated1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdatedDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnShowAssembly = New System.Windows.Forms.Button()
        Me.btnRemoveAssembly = New System.Windows.Forms.Button()
        Me.GridControl12 = New DevExpress.XtraGrid.GridControl()
        Me.bsAssemblies = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAssemblies1 = New EngDesignTracking.dsAssemblies()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordIDFromDrawings = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNumber7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentType6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriority6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgReqDate6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingType6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystemDescription6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRevision6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNextHigherAssembly6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADCN5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDCN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRowNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSequence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAddAssembly = New System.Windows.Forms.Button()
        Me.GridControl11 = New DevExpress.XtraGrid.GridControl()
        Me.bsDrawingsProjects = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDrawingsProjects1 = New EngDesignTracking.dsDrawingsProjects()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordIDParent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox7 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colProjectNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox6 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDrawingNumber6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox8 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.chbIncludeChildren = New System.Windows.Forms.CheckBox()
        Me.btnDeleteDrawingsProjects = New System.Windows.Forms.Button()
        Me.btnSaveDrawingsProjects = New System.Windows.Forms.Button()
        Me.maskedDetailsDCN = New System.Windows.Forms.MaskedTextBox()
        Me.lblDCN = New System.Windows.Forms.Label()
        Me.cboDetailsResourceType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDetailsSystem = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDetailsDocumentType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDetailsLocation = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnBrowseInstallationDrawing = New System.Windows.Forms.Button()
        Me.btnBrowseNextAssemblyDrawing = New System.Windows.Forms.Button()
        Me.txtDetailsInstallationDrawing = New System.Windows.Forms.TextBox()
        Me.txtDetailsNextAssemblyDrawing = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colExpr2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystemDescription2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNextHigherAssembly2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADCN3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstallationDrawing2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentType2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriority2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestBy2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNumber2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingTitle2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingType2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActionDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualFinishDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForecastStartDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForecastFinishDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannedFinishDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDurationHours2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercentComplete2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingFolderAssignDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignWIPDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModelTemplateDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafter2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterComplete2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineer2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerComplete2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineer2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerComplete2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaser2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserCompelte2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammability2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityComplete2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStress2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStressComplete2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterPlannedCompleteDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerPlannedCompleteDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerPlannedCompleteDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityPlannedCompleteDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStressPlannedCompleteDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserPlannedCompleteDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionics2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsComplete2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsPlannedComplete2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanical2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalComplete2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalPlannedComplete2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWONumber2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhiteBoardNumber2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDRNADCN2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAProjectNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPSCPDocsRequired2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyFlightTestRequired2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgReqDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewRework2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdated2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdatedDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRevision2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeq = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDCNDetailsTab = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDRNDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramRealDetailsTab = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDetailsProgram = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtMainProjectName = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.txtNotesNotes = New System.Windows.Forms.TextBox()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colExpr21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentType3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriority3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestBy3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNumber3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingTitle3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingType3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystemDescription3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActionDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualFinishDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForecastStartDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForecastFinishDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannedFinishDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDurationHours3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercentComplete3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingFolderAssignDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignWIPDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModelTemplateDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafter3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterComplete3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineer3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerComplete3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineer3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerComplete3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaser3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserCompelte3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammability3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityComplete3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStress3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStressComplete3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterPlannedCompleteDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerPlannedCompleteDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerPlannedCompleteDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityPlannedCompleteDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStressPlannedCompleteDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserPlannedCompleteDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionics3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsComplete3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsPlannedComplete3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanical3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalComplete3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalPlannedComplete3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWONumber3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNextHigherAssembly3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstallationDrawing3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhiteBoardNumber3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDRNADCN3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAProjectNo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPSCPDocsRequired3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyFlightTestRequired3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgReqDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewRework3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdated3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdatedDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRevision3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeq1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDRNNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADCNNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cboIncorporatedRev = New System.Windows.Forms.ComboBox()
        Me.cboDRNADCNStatus = New System.Windows.Forms.ComboBox()
        Me.cboDRNADCNIncorporatedBy = New System.Windows.Forms.ComboBox()
        Me.cboDRN = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboADCN = New System.Windows.Forms.MaskedTextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentType4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriority4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestBy4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNumber4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingTitle4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingType4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystemDescription4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActionDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualFinishDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForecastStartDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForecastFinishDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannedFinishDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDurationHours4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercentComplete4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingFolderAssignDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignWIPDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModelTemplateDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafter4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterComplete4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineer4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerComplete4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineer4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerComplete4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaser4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserCompelte4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammability4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityComplete4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStress4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStressComplete4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpr22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefID4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterPlannedCompleteDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerPlannedCompleteDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerPlannedCompleteDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityPlannedCompleteDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStressPlannedCompleteDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserPlannedCompleteDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionics4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsComplete4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsPlannedComplete4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanical4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalComplete4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalPlannedComplete4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWONumber4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNextHigherAssembly4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstallationDrawing4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhiteBoardNumber4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDRNADCN4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAProjectNo4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPSCPDocsRequired4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyFlightTestRequired4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgReqDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewRework4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdated4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdatedDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRevision4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeq2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADCN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatusCol = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDRNADCNStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIncorporatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GridControl13 = New DevExpress.XtraGrid.GridControl()
        Me.bsRedlines = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsRedlines1 = New EngDesignTracking.dsRedlines()
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRev = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequestBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRedlineDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndexNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIncorporatedRev = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRedlineNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRedlineCount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLiaisonSignedOffBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLiaisonSignedOffDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperationsSignedOffBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperationsSignedOffDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignEngSignedOffBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignEngSignedOffDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSaveIncorporatedRev = New System.Windows.Forms.Button()
        Me.txtRedlineFileName = New System.Windows.Forms.TextBox()
        Me.lblRedlineFilename = New System.Windows.Forms.Label()
        Me.btnDesignSignOff = New System.Windows.Forms.Button()
        Me.btnPlannerSignOff = New System.Windows.Forms.Button()
        Me.btnLiaisonSignOff = New System.Windows.Forms.Button()
        Me.btnDeleteRedline = New System.Windows.Forms.Button()
        Me.btnAddRedline = New System.Windows.Forms.Button()
        Me.txtRedlineRecordID = New System.Windows.Forms.TextBox()
        Me.cboRedlineStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.cboPercentComplete = New System.Windows.Forms.ComboBox()
        Me.cboSchedMilestone = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboSchedWhiteBoard = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboSchedPercComp = New System.Windows.Forms.MaskedTextBox()
        Me.txtSchedWorkOrder = New System.Windows.Forms.MaskedTextBox()
        Me.btnPercCompleteHelp = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.mskSchedDuration = New System.Windows.Forms.MaskedTextBox()
        Me.dtSchedForecastFinish = New System.Windows.Forms.DateTimePicker()
        Me.dtSchedForecastStart = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GridControl6 = New DevExpress.XtraGrid.GridControl()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colExpr23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWONumber5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannedFinishDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForecastStartDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForecastFinishDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDurationHours5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercentComplete5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriority5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhiteBoardNumber5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordID5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentType5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestBy5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNumber5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingTitle5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgram5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingType5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystemDescription5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActionDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualFinishDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingFolderAssignDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignWIPDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModelTemplateDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafter5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterComplete5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineer5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerComplete5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineer5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerComplete5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaser5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserCompelte5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammability5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityComplete5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStress5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStressComplete5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefID5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterPlannedCompleteDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerPlannedCompleteDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerPlannedCompleteDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityPlannedCompleteDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStressPlannedCompleteDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserPlannedCompleteDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionics5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsComplete5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADCN4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsPlannedComplete5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanical5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalComplete5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalPlannedComplete5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNextHigherAssembly5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstallationDrawing5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDRNADCN5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAProjectNo5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPSCPDocsRequired5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyFlightTestRequired5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgReqDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewRework5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdated5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdatedDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRevision5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeq3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDRNSchedule = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.cboCertificationReviewStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnSyncOMTApprovals = New System.Windows.Forms.Button()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.chkShowAllFAAOMTApprovals = New System.Windows.Forms.CheckBox()
        Me.GridControl8 = New DevExpress.XtraGrid.GridControl()
        Me.bsOMTApproval = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet261 = New EngDesignTracking.DataSet26()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRecordID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAOMTName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAOMTSpecialty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAOMTRecommendApproval = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAOMTApproval = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox5 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colRequiredToApprove1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSaveUMApprovals = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.btnSyncUMApprovals = New System.Windows.Forms.Button()
        Me.GridControl7 = New DevExpress.XtraGrid.GridControl()
        Me.BSUMApproval = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet251 = New EngDesignTracking.DataSet25()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUMName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUMSpecialty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUMRecommendApproval = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colUMApproval = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDateSubmitted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateNeeded = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateCommentsReturned = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequiredToApprove = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkShowAllUMApprovals = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GridControl9 = New DevExpress.XtraGrid.GridControl()
        Me.bsSearchAttachments = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet271 = New EngDesignTracking.DataSet27()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRecordID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFilePath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImgField = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileExt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnFileAttachSubmit = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnDeleteAttachment = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtFileDescription = New System.Windows.Forms.TextBox()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.txtAttachRecordID = New System.Windows.Forms.TextBox()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.btnReverseClosedEarr = New System.Windows.Forms.Button()
        Me.btnCloseIssue = New System.Windows.Forms.Button()
        Me.btnExportIssue = New System.Windows.Forms.Button()
        Me.btnViewIssue = New System.Windows.Forms.Button()
        Me.GridControl14 = New DevExpress.XtraGrid.GridControl()
        Me.bsIssues = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsIssues1 = New EngDesignTracking.dsIssues()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEarr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRev1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawNumRev = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResponse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginatorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginatorDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateClosed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueTypes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateIncorporated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEQNNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colERAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colERASUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateERASUpdated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtIssuesRecordID = New System.Windows.Forms.TextBox()
        Me.txtTypeOfIssue = New System.Windows.Forms.TextBox()
        Me.txtEarrNumIssues = New System.Windows.Forms.TextBox()
        Me.tabAttachments = New System.Windows.Forms.TabPage()
        Me.GridControl10 = New DevExpress.XtraGrid.GridControl()
        Me.bsAttachments = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAttachments1 = New EngDesignTracking.dsAttachments()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordIDAttach = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRecordID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTarget = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsActualDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboConfigurationStatus = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.btnViewAttachment = New System.Windows.Forms.Button()
        Me.txtFieldDescriptionAttach = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.btnDeleteAttach = New System.Windows.Forms.Button()
        Me.btnSaveAttachment = New System.Windows.Forms.Button()
        Me.btnBrowseAttachments = New System.Windows.Forms.Button()
        Me.txtFileNameAttach = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtTargetAttach = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.DsIssues = New EngDesignTracking.dsIssues()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.chkShowStageComplete = New System.Windows.Forms.CheckBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExportGrid = New System.Windows.Forms.Button()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtMainDrawingNumber = New System.Windows.Forms.TextBox()
        Me.txtMainTitle = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToMainMenuScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificationStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LovMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemDescriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResourceTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameAssignmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriorityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DRNADCNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewReworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteBoardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationRolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JASCCodesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Level3DocTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AircraftsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectServerWorkflowSyncToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AIMNumbersListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeDrawingNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MDLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtMainRecordID = New System.Windows.Forms.TextBox()
        Me.txtMainProgram = New System.Windows.Forms.TextBox()
        Me.txtMainStatus = New System.Windows.Forms.TextBox()
        Me.txtMainLocation = New System.Windows.Forms.TextBox()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtMainInfoRecordID = New System.Windows.Forms.TextBox()
        Me.btnAddNewRev = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSignOff = New System.Windows.Forms.Button()
        Me.btncancelobsolete = New System.Windows.Forms.Button()
        Me.btnNumber = New System.Windows.Forms.Button()
        Me.cboView = New System.Windows.Forms.ComboBox()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgram = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewRework = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRevision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDRNADCN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADCN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhiteBoardNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgRequestDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastActionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualFinishDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForecastStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForecastFinishDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannedFinishDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDurationHours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercentComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrawingFolderAssignDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignWIPDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModelTemplateDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserCompelte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammability = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStressComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrafterPlannedCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerPlannedCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSrEngineerPlannedCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFlammabilityPlannedCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStressPlannedCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaserPlannedCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionics = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvionicsPlannedComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanical = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMechanicalPlannedComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWONumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNextHigherAssembly = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstallationDrawing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAAProjectNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPSCPDocsRequired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyFlightTestRequired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDwgReqDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeq4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDCNUpperGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramReal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRevPurpose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter5 = New System.Data.SqlClient.SqlDataAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblCanceled = New System.Windows.Forms.Label()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter6 = New System.Data.SqlClient.SqlDataAdapter()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.DataSet11 = New EngDesignTracking.DataSet1()
        Me.bsDrnAdcn = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblRecordDeleted = New System.Windows.Forms.Label()
        Me.lblTasksPending = New System.Windows.Forms.Label()
        Me.btnShowTree = New System.Windows.Forms.Button()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.daDrawingsProjects = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.daAssemblies = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.daRedlines = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection4 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.daIssues = New System.Data.SqlClient.SqlDataAdapter()
        Me.colTypeIssues = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlConnection5 = New System.Data.SqlClient.SqlConnection()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMainGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet241, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet201, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.cbomaininfoStress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbomaininforeleaser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbomaininfosrengineer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbomaininfoengineer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbomaininfodrafter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMainRev.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMainStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMainInformationTab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet211, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.GridControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAssemblies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAssemblies1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDrawingsProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDrawingsProjects1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDetailsResourceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDetailsSystem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDetailsDocumentType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDetailsLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDetailsProgram.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.cboDRN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridControl13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRedlines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRedlines1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRedlineStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.cboSchedMilestone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSchedWhiteBoard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.cboCertificationReviewStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOMTApproval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet261, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSUMApproval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet251, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSearchAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet271, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        CType(Me.GridControl14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsIssues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIssues1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAttachments.SuspendLayout()
        CType(Me.GridControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAttachments1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIssues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDrnAdcn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'bsMainGrid
        '
        Me.bsMainGrid.DataMember = "vwDrawingsRev"
        Me.bsMainGrid.DataSource = Me.DataSet241
        '
        'DataSet241
        '
        Me.DataSet241.DataSetName = "DataSet24"
        Me.DataSet241.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet201
        '
        Me.DataSet201.DataSetName = "DataSet20"
        Me.DataSet201.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Controls.Add(Me.tabAttachments)
        Me.TabControl2.Location = New System.Drawing.Point(5, 400)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1510, 414)
        Me.TabControl2.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label46)
        Me.TabPage3.Controls.Add(Me.Label45)
        Me.TabPage3.Controls.Add(Me.Label44)
        Me.TabPage3.Controls.Add(Me.Label43)
        Me.TabPage3.Controls.Add(Me.Label42)
        Me.TabPage3.Controls.Add(Me.cbomaininfoStress)
        Me.TabPage3.Controls.Add(Me.cbomaininforeleaser)
        Me.TabPage3.Controls.Add(Me.cbomaininfosrengineer)
        Me.TabPage3.Controls.Add(Me.cbomaininfoengineer)
        Me.TabPage3.Controls.Add(Me.cbomaininfodrafter)
        Me.TabPage3.Controls.Add(Me.cboMainRev)
        Me.TabPage3.Controls.Add(Me.cboMainStatus)
        Me.TabPage3.Controls.Add(Me.dtmaininfoStressComp)
        Me.TabPage3.Controls.Add(Me.Label40)
        Me.TabPage3.Controls.Add(Me.Label41)
        Me.TabPage3.Controls.Add(Me.dtmaininforeleasercomp)
        Me.TabPage3.Controls.Add(Me.dtmaininfosrengcomp)
        Me.TabPage3.Controls.Add(Me.dtmaininfoengcomp)
        Me.TabPage3.Controls.Add(Me.dtmaininfodraftercomp)
        Me.TabPage3.Controls.Add(Me.txtmaininfotitle)
        Me.TabPage3.Controls.Add(Me.dtmaininfoactualfinishdt)
        Me.TabPage3.Controls.Add(Me.GridControl2)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1502, 388)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Main Information"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(352, 236)
        Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(51, 13)
        Me.Label46.TabIndex = 49
        Me.Label46.Text = "GATE 2"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(696, 236)
        Me.Label45.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(51, 13)
        Me.Label45.TabIndex = 48
        Me.Label45.Text = "GATE 4"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(519, 236)
        Me.Label44.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(51, 13)
        Me.Label44.TabIndex = 47
        Me.Label44.Text = "GATE 3"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(183, 236)
        Me.Label43.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(51, 13)
        Me.Label43.TabIndex = 46
        Me.Label43.Text = "GATE 2"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(15, 236)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(51, 13)
        Me.Label42.TabIndex = 45
        Me.Label42.Text = "GATE 1"
        '
        'cbomaininfoStress
        '
        Me.cbomaininfoStress.Location = New System.Drawing.Point(355, 271)
        Me.cbomaininfoStress.Name = "cbomaininfoStress"
        Me.cbomaininfoStress.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbomaininfoStress.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbomaininfoStress.Size = New System.Drawing.Size(160, 20)
        Me.cbomaininfoStress.TabIndex = 44
        '
        'cbomaininforeleaser
        '
        Me.cbomaininforeleaser.Location = New System.Drawing.Point(693, 271)
        Me.cbomaininforeleaser.Name = "cbomaininforeleaser"
        Me.cbomaininforeleaser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbomaininforeleaser.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbomaininforeleaser.Size = New System.Drawing.Size(166, 20)
        Me.cbomaininforeleaser.TabIndex = 43
        '
        'cbomaininfosrengineer
        '
        Me.cbomaininfosrengineer.Location = New System.Drawing.Point(187, 271)
        Me.cbomaininfosrengineer.Name = "cbomaininfosrengineer"
        Me.cbomaininfosrengineer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbomaininfosrengineer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbomaininfosrengineer.Size = New System.Drawing.Size(163, 20)
        Me.cbomaininfosrengineer.TabIndex = 42
        '
        'cbomaininfoengineer
        '
        Me.cbomaininfoengineer.Location = New System.Drawing.Point(521, 271)
        Me.cbomaininfoengineer.Name = "cbomaininfoengineer"
        Me.cbomaininfoengineer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbomaininfoengineer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbomaininfoengineer.Size = New System.Drawing.Size(166, 20)
        Me.cbomaininfoengineer.TabIndex = 41
        '
        'cbomaininfodrafter
        '
        Me.cbomaininfodrafter.Location = New System.Drawing.Point(17, 271)
        Me.cbomaininfodrafter.Name = "cbomaininfodrafter"
        Me.cbomaininfodrafter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbomaininfodrafter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbomaininfodrafter.Size = New System.Drawing.Size(163, 20)
        Me.cbomaininfodrafter.TabIndex = 40
        '
        'cboMainRev
        '
        Me.cboMainRev.Location = New System.Drawing.Point(18, 208)
        Me.cboMainRev.Name = "cboMainRev"
        Me.cboMainRev.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMainRev.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboMainRev.Size = New System.Drawing.Size(80, 20)
        Me.cboMainRev.TabIndex = 39
        '
        'cboMainStatus
        '
        Me.cboMainStatus.Location = New System.Drawing.Point(117, 210)
        Me.cboMainStatus.Name = "cboMainStatus"
        Me.cboMainStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMainStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboMainStatus.Size = New System.Drawing.Size(185, 20)
        Me.cboMainStatus.TabIndex = 38
        '
        'dtmaininfoStressComp
        '
        Me.dtmaininfoStressComp.CustomFormat = "MM/dd/yyyy"
        Me.dtmaininfoStressComp.Enabled = False
        Me.dtmaininfoStressComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmaininfoStressComp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmaininfoStressComp.Location = New System.Drawing.Point(358, 318)
        Me.dtmaininfoStressComp.Name = "dtmaininfoStressComp"
        Me.dtmaininfoStressComp.Size = New System.Drawing.Size(140, 20)
        Me.dtmaininfoStressComp.TabIndex = 36
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(352, 292)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(109, 13)
        Me.Label40.TabIndex = 35
        Me.Label40.Text = "Stress Complete Date"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(352, 255)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(36, 13)
        Me.Label41.TabIndex = 34
        Me.Label41.Text = "Stress"
        '
        'dtmaininforeleasercomp
        '
        Me.dtmaininforeleasercomp.CustomFormat = "MM/dd/yyyy"
        Me.dtmaininforeleasercomp.Enabled = False
        Me.dtmaininforeleasercomp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmaininforeleasercomp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmaininforeleasercomp.Location = New System.Drawing.Point(699, 318)
        Me.dtmaininforeleasercomp.Name = "dtmaininforeleasercomp"
        Me.dtmaininforeleasercomp.Size = New System.Drawing.Size(140, 20)
        Me.dtmaininforeleasercomp.TabIndex = 29
        '
        'dtmaininfosrengcomp
        '
        Me.dtmaininfosrengcomp.CustomFormat = "MM/dd/yyyy"
        Me.dtmaininfosrengcomp.Enabled = False
        Me.dtmaininfosrengcomp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmaininfosrengcomp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmaininfosrengcomp.Location = New System.Drawing.Point(190, 318)
        Me.dtmaininfosrengcomp.Name = "dtmaininfosrengcomp"
        Me.dtmaininfosrengcomp.Size = New System.Drawing.Size(140, 20)
        Me.dtmaininfosrengcomp.TabIndex = 28
        '
        'dtmaininfoengcomp
        '
        Me.dtmaininfoengcomp.CustomFormat = "MM/dd/yyyy"
        Me.dtmaininfoengcomp.Enabled = False
        Me.dtmaininfoengcomp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmaininfoengcomp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmaininfoengcomp.Location = New System.Drawing.Point(525, 318)
        Me.dtmaininfoengcomp.Name = "dtmaininfoengcomp"
        Me.dtmaininfoengcomp.Size = New System.Drawing.Size(140, 20)
        Me.dtmaininfoengcomp.TabIndex = 27
        '
        'dtmaininfodraftercomp
        '
        Me.dtmaininfodraftercomp.CustomFormat = "MM/dd/yyyy"
        Me.dtmaininfodraftercomp.Enabled = False
        Me.dtmaininfodraftercomp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmaininfodraftercomp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmaininfodraftercomp.Location = New System.Drawing.Point(17, 317)
        Me.dtmaininfodraftercomp.Name = "dtmaininfodraftercomp"
        Me.dtmaininfodraftercomp.Size = New System.Drawing.Size(140, 20)
        Me.dtmaininfodraftercomp.TabIndex = 26
        '
        'txtmaininfotitle
        '
        Me.txtmaininfotitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmaininfotitle.Location = New System.Drawing.Point(314, 211)
        Me.txtmaininfotitle.Name = "txtmaininfotitle"
        Me.txtmaininfotitle.Size = New System.Drawing.Size(330, 20)
        Me.txtmaininfotitle.TabIndex = 25
        '
        'dtmaininfoactualfinishdt
        '
        Me.dtmaininfoactualfinishdt.CustomFormat = "MM/dd/yyyy"
        Me.dtmaininfoactualfinishdt.Enabled = False
        Me.dtmaininfoactualfinishdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmaininfoactualfinishdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmaininfoactualfinishdt.Location = New System.Drawing.Point(657, 211)
        Me.dtmaininfoactualfinishdt.Name = "dtmaininfoactualfinishdt"
        Me.dtmaininfoactualfinishdt.Size = New System.Drawing.Size(200, 20)
        Me.dtmaininfoactualfinishdt.TabIndex = 24
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.bsMainInformationTab
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl2.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl2.Location = New System.Drawing.Point(5, 6)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1390, 177)
        Me.GridControl2.TabIndex = 16
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bsMainInformationTab
        '
        Me.bsMainInformationTab.DataMember = "tblDrawings"
        Me.bsMainInformationTab.DataSource = Me.DataSet211
        '
        'DataSet211
        '
        Me.DataSet211.DataSetName = "DataSet21"
        Me.DataSet211.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDwgRevision1, Me.colDRNADCN1, Me.colADCN2, Me.colDrawingTitle1, Me.colActualFinishDate1, Me.colDrafter1, Me.colDrafterComplete1, Me.colEngineer1, Me.colEngineerComplete1, Me.colSrEngineer1, Me.colSrEngineerComplete1, Me.colReleaser1, Me.colReleaserCompelte1, Me.colRecordID1, Me.colDocumentType1, Me.colPriority1, Me.colLocation1, Me.colType1, Me.colDwgRequestBy1, Me.colDrawingNumber1, Me.colDwgRequestDate1, Me.colProgram1, Me.colDrawingType1, Me.colSystemDescription1, Me.colStatus1, Me.colLastActionDate1, Me.colForecastStartDate1, Me.colForecastFinishDate1, Me.colPlannedFinishDate1, Me.colEstimatedDurationHours1, Me.colPercentComplete1, Me.colDrawingFolderAssignDate1, Me.colDesignWIPDate1, Me.colNotes1, Me.colModelTemplateDate1, Me.colFlammability1, Me.colFlammabilityComplete1, Me.colStress1, Me.colStressComplete1, Me.colRefID1, Me.colDrafterPlannedCompleteDate1, Me.colEngineerPlannedCompleteDate1, Me.colSrEngineerPlannedCompleteDate1, Me.colFlammabilityPlannedCompleteDate1, Me.colStressPlannedCompleteDate1, Me.colReleaserPlannedCompleteDate1, Me.colAvionics1, Me.colAvionicsComplete1, Me.colAvionicsPlannedComplete1, Me.colMechanical1, Me.colMechanicalComplete1, Me.colMechanicalPlannedComplete1, Me.colWONumber1, Me.colNextHigherAssembly1, Me.colInstallationDrawing1, Me.colWhiteBoardNumber1, Me.colFAAProjectNo1, Me.colPSCPDocsRequired1, Me.colCompanyFlightTestRequired1, Me.colDwgReqDate1, Me.colNewRework1, Me.colUpdated1, Me.colUpdatedDate1})
        Me.GridView2.DetailHeight = 349
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.LevelIndent = 0
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.PreviewIndent = 0
        '
        'colDwgRevision1
        '
        Me.colDwgRevision1.Caption = "Doc Rev"
        Me.colDwgRevision1.FieldName = "DwgRevision"
        Me.colDwgRevision1.Name = "colDwgRevision1"
        Me.colDwgRevision1.OptionsColumn.ReadOnly = True
        Me.colDwgRevision1.Visible = True
        Me.colDwgRevision1.VisibleIndex = 0
        Me.colDwgRevision1.Width = 48
        '
        'colDRNADCN1
        '
        Me.colDRNADCN1.Caption = "DRN"
        Me.colDRNADCN1.FieldName = "DRNADCN"
        Me.colDRNADCN1.Name = "colDRNADCN1"
        Me.colDRNADCN1.OptionsColumn.ReadOnly = True
        Me.colDRNADCN1.Visible = True
        Me.colDRNADCN1.VisibleIndex = 1
        Me.colDRNADCN1.Width = 88
        '
        'colADCN2
        '
        Me.colADCN2.Caption = "ADCN"
        Me.colADCN2.FieldName = "ADCN"
        Me.colADCN2.Name = "colADCN2"
        Me.colADCN2.Visible = True
        Me.colADCN2.VisibleIndex = 2
        Me.colADCN2.Width = 88
        '
        'colDrawingTitle1
        '
        Me.colDrawingTitle1.Caption = "Document Title"
        Me.colDrawingTitle1.FieldName = "DrawingTitle"
        Me.colDrawingTitle1.Name = "colDrawingTitle1"
        Me.colDrawingTitle1.OptionsColumn.ReadOnly = True
        Me.colDrawingTitle1.Visible = True
        Me.colDrawingTitle1.VisibleIndex = 3
        Me.colDrawingTitle1.Width = 90
        '
        'colActualFinishDate1
        '
        Me.colActualFinishDate1.FieldName = "ActualFinishDate"
        Me.colActualFinishDate1.Name = "colActualFinishDate1"
        Me.colActualFinishDate1.OptionsColumn.ReadOnly = True
        Me.colActualFinishDate1.Visible = True
        Me.colActualFinishDate1.VisibleIndex = 4
        Me.colActualFinishDate1.Width = 90
        '
        'colDrafter1
        '
        Me.colDrafter1.FieldName = "Drafter"
        Me.colDrafter1.Name = "colDrafter1"
        Me.colDrafter1.OptionsColumn.ReadOnly = True
        Me.colDrafter1.Visible = True
        Me.colDrafter1.VisibleIndex = 5
        Me.colDrafter1.Width = 90
        '
        'colDrafterComplete1
        '
        Me.colDrafterComplete1.Caption = "Drafter Complete Date"
        Me.colDrafterComplete1.FieldName = "DrafterComplete"
        Me.colDrafterComplete1.Name = "colDrafterComplete1"
        Me.colDrafterComplete1.OptionsColumn.ReadOnly = True
        Me.colDrafterComplete1.Visible = True
        Me.colDrafterComplete1.VisibleIndex = 6
        Me.colDrafterComplete1.Width = 90
        '
        'colEngineer1
        '
        Me.colEngineer1.Caption = "Operations"
        Me.colEngineer1.FieldName = "Engineer"
        Me.colEngineer1.Name = "colEngineer1"
        Me.colEngineer1.OptionsColumn.ReadOnly = True
        Me.colEngineer1.Visible = True
        Me.colEngineer1.VisibleIndex = 7
        Me.colEngineer1.Width = 90
        '
        'colEngineerComplete1
        '
        Me.colEngineerComplete1.Caption = "Operations Complete"
        Me.colEngineerComplete1.FieldName = "EngineerComplete"
        Me.colEngineerComplete1.Name = "colEngineerComplete1"
        Me.colEngineerComplete1.OptionsColumn.ReadOnly = True
        Me.colEngineerComplete1.Visible = True
        Me.colEngineerComplete1.VisibleIndex = 8
        Me.colEngineerComplete1.Width = 127
        '
        'colSrEngineer1
        '
        Me.colSrEngineer1.FieldName = "SrEngineer"
        Me.colSrEngineer1.Name = "colSrEngineer1"
        Me.colSrEngineer1.OptionsColumn.ReadOnly = True
        Me.colSrEngineer1.Visible = True
        Me.colSrEngineer1.VisibleIndex = 9
        Me.colSrEngineer1.Width = 90
        '
        'colSrEngineerComplete1
        '
        Me.colSrEngineerComplete1.FieldName = "SrEngineerComplete"
        Me.colSrEngineerComplete1.Name = "colSrEngineerComplete1"
        Me.colSrEngineerComplete1.OptionsColumn.ReadOnly = True
        Me.colSrEngineerComplete1.Visible = True
        Me.colSrEngineerComplete1.VisibleIndex = 10
        Me.colSrEngineerComplete1.Width = 90
        '
        'colReleaser1
        '
        Me.colReleaser1.FieldName = "Releaser"
        Me.colReleaser1.Name = "colReleaser1"
        Me.colReleaser1.OptionsColumn.ReadOnly = True
        Me.colReleaser1.Visible = True
        Me.colReleaser1.VisibleIndex = 11
        Me.colReleaser1.Width = 90
        '
        'colReleaserCompelte1
        '
        Me.colReleaserCompelte1.Caption = "Releaser Complete"
        Me.colReleaserCompelte1.FieldName = "ReleaserCompelte"
        Me.colReleaserCompelte1.Name = "colReleaserCompelte1"
        Me.colReleaserCompelte1.OptionsColumn.ReadOnly = True
        Me.colReleaserCompelte1.Visible = True
        Me.colReleaserCompelte1.VisibleIndex = 12
        Me.colReleaserCompelte1.Width = 90
        '
        'colRecordID1
        '
        Me.colRecordID1.FieldName = "RecordID"
        Me.colRecordID1.Name = "colRecordID1"
        '
        'colDocumentType1
        '
        Me.colDocumentType1.FieldName = "DocumentType"
        Me.colDocumentType1.Name = "colDocumentType1"
        '
        'colPriority1
        '
        Me.colPriority1.FieldName = "Priority"
        Me.colPriority1.Name = "colPriority1"
        '
        'colLocation1
        '
        Me.colLocation1.FieldName = "Location"
        Me.colLocation1.Name = "colLocation1"
        '
        'colType1
        '
        Me.colType1.FieldName = "Type"
        Me.colType1.Name = "colType1"
        '
        'colDwgRequestBy1
        '
        Me.colDwgRequestBy1.FieldName = "DwgRequestBy"
        Me.colDwgRequestBy1.Name = "colDwgRequestBy1"
        '
        'colDrawingNumber1
        '
        Me.colDrawingNumber1.FieldName = "DrawingNumber"
        Me.colDrawingNumber1.Name = "colDrawingNumber1"
        '
        'colDwgRequestDate1
        '
        Me.colDwgRequestDate1.FieldName = "DwgRequestDate"
        Me.colDwgRequestDate1.Name = "colDwgRequestDate1"
        '
        'colProgram1
        '
        Me.colProgram1.FieldName = "Program"
        Me.colProgram1.Name = "colProgram1"
        '
        'colDrawingType1
        '
        Me.colDrawingType1.FieldName = "DrawingType"
        Me.colDrawingType1.Name = "colDrawingType1"
        '
        'colSystemDescription1
        '
        Me.colSystemDescription1.FieldName = "SystemDescription"
        Me.colSystemDescription1.Name = "colSystemDescription1"
        '
        'colStatus1
        '
        Me.colStatus1.FieldName = "Status"
        Me.colStatus1.Name = "colStatus1"
        '
        'colLastActionDate1
        '
        Me.colLastActionDate1.FieldName = "LastActionDate"
        Me.colLastActionDate1.Name = "colLastActionDate1"
        '
        'colForecastStartDate1
        '
        Me.colForecastStartDate1.FieldName = "ForecastStartDate"
        Me.colForecastStartDate1.Name = "colForecastStartDate1"
        '
        'colForecastFinishDate1
        '
        Me.colForecastFinishDate1.FieldName = "ForecastFinishDate"
        Me.colForecastFinishDate1.Name = "colForecastFinishDate1"
        '
        'colPlannedFinishDate1
        '
        Me.colPlannedFinishDate1.FieldName = "PlannedFinishDate"
        Me.colPlannedFinishDate1.Name = "colPlannedFinishDate1"
        '
        'colEstimatedDurationHours1
        '
        Me.colEstimatedDurationHours1.FieldName = "EstimatedDurationHours"
        Me.colEstimatedDurationHours1.Name = "colEstimatedDurationHours1"
        '
        'colPercentComplete1
        '
        Me.colPercentComplete1.FieldName = "PercentComplete"
        Me.colPercentComplete1.Name = "colPercentComplete1"
        '
        'colDrawingFolderAssignDate1
        '
        Me.colDrawingFolderAssignDate1.FieldName = "DrawingFolderAssignDate"
        Me.colDrawingFolderAssignDate1.Name = "colDrawingFolderAssignDate1"
        '
        'colDesignWIPDate1
        '
        Me.colDesignWIPDate1.FieldName = "DesignWIPDate"
        Me.colDesignWIPDate1.Name = "colDesignWIPDate1"
        '
        'colNotes1
        '
        Me.colNotes1.FieldName = "Notes"
        Me.colNotes1.Name = "colNotes1"
        '
        'colModelTemplateDate1
        '
        Me.colModelTemplateDate1.FieldName = "ModelTemplateDate"
        Me.colModelTemplateDate1.Name = "colModelTemplateDate1"
        '
        'colFlammability1
        '
        Me.colFlammability1.FieldName = "Flammability"
        Me.colFlammability1.Name = "colFlammability1"
        '
        'colFlammabilityComplete1
        '
        Me.colFlammabilityComplete1.FieldName = "FlammabilityComplete"
        Me.colFlammabilityComplete1.Name = "colFlammabilityComplete1"
        '
        'colStress1
        '
        Me.colStress1.FieldName = "Stress"
        Me.colStress1.Name = "colStress1"
        Me.colStress1.Visible = True
        Me.colStress1.VisibleIndex = 13
        Me.colStress1.Width = 90
        '
        'colStressComplete1
        '
        Me.colStressComplete1.FieldName = "StressComplete"
        Me.colStressComplete1.Name = "colStressComplete1"
        Me.colStressComplete1.Visible = True
        Me.colStressComplete1.VisibleIndex = 14
        Me.colStressComplete1.Width = 120
        '
        'colRefID1
        '
        Me.colRefID1.FieldName = "RefID"
        Me.colRefID1.Name = "colRefID1"
        '
        'colDrafterPlannedCompleteDate1
        '
        Me.colDrafterPlannedCompleteDate1.FieldName = "DrafterPlannedCompleteDate"
        Me.colDrafterPlannedCompleteDate1.Name = "colDrafterPlannedCompleteDate1"
        '
        'colEngineerPlannedCompleteDate1
        '
        Me.colEngineerPlannedCompleteDate1.FieldName = "EngineerPlannedCompleteDate"
        Me.colEngineerPlannedCompleteDate1.Name = "colEngineerPlannedCompleteDate1"
        '
        'colSrEngineerPlannedCompleteDate1
        '
        Me.colSrEngineerPlannedCompleteDate1.FieldName = "SrEngineerPlannedCompleteDate"
        Me.colSrEngineerPlannedCompleteDate1.Name = "colSrEngineerPlannedCompleteDate1"
        '
        'colFlammabilityPlannedCompleteDate1
        '
        Me.colFlammabilityPlannedCompleteDate1.FieldName = "FlammabilityPlannedCompleteDate"
        Me.colFlammabilityPlannedCompleteDate1.Name = "colFlammabilityPlannedCompleteDate1"
        '
        'colStressPlannedCompleteDate1
        '
        Me.colStressPlannedCompleteDate1.FieldName = "StressPlannedCompleteDate"
        Me.colStressPlannedCompleteDate1.Name = "colStressPlannedCompleteDate1"
        '
        'colReleaserPlannedCompleteDate1
        '
        Me.colReleaserPlannedCompleteDate1.FieldName = "ReleaserPlannedCompleteDate"
        Me.colReleaserPlannedCompleteDate1.Name = "colReleaserPlannedCompleteDate1"
        '
        'colAvionics1
        '
        Me.colAvionics1.FieldName = "Avionics"
        Me.colAvionics1.Name = "colAvionics1"
        '
        'colAvionicsComplete1
        '
        Me.colAvionicsComplete1.FieldName = "AvionicsComplete"
        Me.colAvionicsComplete1.Name = "colAvionicsComplete1"
        '
        'colAvionicsPlannedComplete1
        '
        Me.colAvionicsPlannedComplete1.FieldName = "AvionicsPlannedComplete"
        Me.colAvionicsPlannedComplete1.Name = "colAvionicsPlannedComplete1"
        '
        'colMechanical1
        '
        Me.colMechanical1.FieldName = "Mechanical"
        Me.colMechanical1.Name = "colMechanical1"
        '
        'colMechanicalComplete1
        '
        Me.colMechanicalComplete1.FieldName = "MechanicalComplete"
        Me.colMechanicalComplete1.Name = "colMechanicalComplete1"
        '
        'colMechanicalPlannedComplete1
        '
        Me.colMechanicalPlannedComplete1.FieldName = "MechanicalPlannedComplete"
        Me.colMechanicalPlannedComplete1.Name = "colMechanicalPlannedComplete1"
        '
        'colWONumber1
        '
        Me.colWONumber1.FieldName = "WONumber"
        Me.colWONumber1.Name = "colWONumber1"
        '
        'colNextHigherAssembly1
        '
        Me.colNextHigherAssembly1.FieldName = "NextHigherAssembly"
        Me.colNextHigherAssembly1.Name = "colNextHigherAssembly1"
        '
        'colInstallationDrawing1
        '
        Me.colInstallationDrawing1.FieldName = "InstallationDrawing"
        Me.colInstallationDrawing1.Name = "colInstallationDrawing1"
        '
        'colWhiteBoardNumber1
        '
        Me.colWhiteBoardNumber1.FieldName = "WhiteBoardNumber"
        Me.colWhiteBoardNumber1.Name = "colWhiteBoardNumber1"
        '
        'colFAAProjectNo1
        '
        Me.colFAAProjectNo1.FieldName = "FAAProjectNo"
        Me.colFAAProjectNo1.Name = "colFAAProjectNo1"
        '
        'colPSCPDocsRequired1
        '
        Me.colPSCPDocsRequired1.FieldName = "PSCPDocsRequired"
        Me.colPSCPDocsRequired1.Name = "colPSCPDocsRequired1"
        '
        'colCompanyFlightTestRequired1
        '
        Me.colCompanyFlightTestRequired1.FieldName = "CompanyFlightTestRequired"
        Me.colCompanyFlightTestRequired1.Name = "colCompanyFlightTestRequired1"
        '
        'colDwgReqDate1
        '
        Me.colDwgReqDate1.FieldName = "DwgReqDate"
        Me.colDwgReqDate1.Name = "colDwgReqDate1"
        '
        'colNewRework1
        '
        Me.colNewRework1.FieldName = "NewRework"
        Me.colNewRework1.Name = "colNewRework1"
        '
        'colUpdated1
        '
        Me.colUpdated1.FieldName = "Updated"
        Me.colUpdated1.Name = "colUpdated1"
        '
        'colUpdatedDate1
        '
        Me.colUpdatedDate1.FieldName = "UpdatedDate"
        Me.colUpdatedDate1.Name = "colUpdatedDate1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(693, 292)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Releaser Complete Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(184, 292)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = " Sr Engineer Complete Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(519, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Operations Complete Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Drafter Complete Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(693, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Releaser"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(183, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Sr Engineer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(519, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Operations"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Drafter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(654, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Actual Finish Date (Rev Date)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(310, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Rev"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnShowAssembly)
        Me.TabPage4.Controls.Add(Me.btnRemoveAssembly)
        Me.TabPage4.Controls.Add(Me.GridControl12)
        Me.TabPage4.Controls.Add(Me.btnAddAssembly)
        Me.TabPage4.Controls.Add(Me.GridControl11)
        Me.TabPage4.Controls.Add(Me.chbIncludeChildren)
        Me.TabPage4.Controls.Add(Me.btnDeleteDrawingsProjects)
        Me.TabPage4.Controls.Add(Me.btnSaveDrawingsProjects)
        Me.TabPage4.Controls.Add(Me.maskedDetailsDCN)
        Me.TabPage4.Controls.Add(Me.lblDCN)
        Me.TabPage4.Controls.Add(Me.cboDetailsResourceType)
        Me.TabPage4.Controls.Add(Me.cboDetailsSystem)
        Me.TabPage4.Controls.Add(Me.cboDetailsDocumentType)
        Me.TabPage4.Controls.Add(Me.cboDetailsLocation)
        Me.TabPage4.Controls.Add(Me.btnBrowseInstallationDrawing)
        Me.TabPage4.Controls.Add(Me.btnBrowseNextAssemblyDrawing)
        Me.TabPage4.Controls.Add(Me.txtDetailsInstallationDrawing)
        Me.TabPage4.Controls.Add(Me.txtDetailsNextAssemblyDrawing)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.GridControl3)
        Me.TabPage4.Controls.Add(Me.cboDetailsProgram)
        Me.TabPage4.Controls.Add(Me.txtMainProjectName)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1502, 388)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Details"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnShowAssembly
        '
        Me.btnShowAssembly.Location = New System.Drawing.Point(1219, 363)
        Me.btnShowAssembly.Name = "btnShowAssembly"
        Me.btnShowAssembly.Size = New System.Drawing.Size(75, 23)
        Me.btnShowAssembly.TabIndex = 52
        Me.btnShowAssembly.Text = "Show"
        Me.btnShowAssembly.UseVisualStyleBackColor = True
        '
        'btnRemoveAssembly
        '
        Me.btnRemoveAssembly.Location = New System.Drawing.Point(1300, 362)
        Me.btnRemoveAssembly.Name = "btnRemoveAssembly"
        Me.btnRemoveAssembly.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveAssembly.TabIndex = 51
        Me.btnRemoveAssembly.Text = "Remove"
        Me.btnRemoveAssembly.UseVisualStyleBackColor = True
        '
        'GridControl12
        '
        Me.GridControl12.DataSource = Me.bsAssemblies
        Me.GridControl12.Location = New System.Drawing.Point(905, 159)
        Me.GridControl12.MainView = Me.GridView12
        Me.GridControl12.Name = "GridControl12"
        Me.GridControl12.Size = New System.Drawing.Size(491, 201)
        Me.GridControl12.TabIndex = 50
        Me.GridControl12.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView12})
        '
        'bsAssemblies
        '
        Me.bsAssemblies.DataMember = "tblTree"
        Me.bsAssemblies.DataSource = Me.DsAssemblies1
        '
        'DsAssemblies1
        '
        Me.DsAssemblies1.DataSetName = "dsAssemblies"
        Me.DsAssemblies1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView12
        '
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID7, Me.colRecordIDFromDrawings, Me.colDrawingNumber7, Me.colDocumentType6, Me.colPriority6, Me.colDwgReqDate6, Me.colDrawingType6, Me.colSystemDescription6, Me.colStatus6, Me.colTitle, Me.colDwgRevision6, Me.colNextHigherAssembly6, Me.colADCN5, Me.colDCN, Me.colRowNumber, Me.colSequence})
        Me.GridView12.CustomizationFormBounds = New System.Drawing.Rectangle(827, 411, 260, 232)
        Me.GridView12.GridControl = Me.GridControl12
        Me.GridView12.LevelIndent = 0
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsView.ShowGroupPanel = False
        Me.GridView12.PreviewIndent = 0
        '
        'colRecordID7
        '
        Me.colRecordID7.FieldName = "RecordID"
        Me.colRecordID7.Name = "colRecordID7"
        '
        'colRecordIDFromDrawings
        '
        Me.colRecordIDFromDrawings.FieldName = "RecordIDFromDrawings"
        Me.colRecordIDFromDrawings.Name = "colRecordIDFromDrawings"
        '
        'colDrawingNumber7
        '
        Me.colDrawingNumber7.FieldName = "DrawingNumber"
        Me.colDrawingNumber7.Name = "colDrawingNumber7"
        Me.colDrawingNumber7.Visible = True
        Me.colDrawingNumber7.VisibleIndex = 1
        '
        'colDocumentType6
        '
        Me.colDocumentType6.FieldName = "DocumentType"
        Me.colDocumentType6.Name = "colDocumentType6"
        '
        'colPriority6
        '
        Me.colPriority6.FieldName = "Priority"
        Me.colPriority6.Name = "colPriority6"
        '
        'colDwgReqDate6
        '
        Me.colDwgReqDate6.FieldName = "DwgReqDate"
        Me.colDwgReqDate6.Name = "colDwgReqDate6"
        '
        'colDrawingType6
        '
        Me.colDrawingType6.FieldName = "DrawingType"
        Me.colDrawingType6.Name = "colDrawingType6"
        '
        'colSystemDescription6
        '
        Me.colSystemDescription6.FieldName = "SystemDescription"
        Me.colSystemDescription6.Name = "colSystemDescription6"
        '
        'colStatus6
        '
        Me.colStatus6.FieldName = "Status"
        Me.colStatus6.Name = "colStatus6"
        '
        'colTitle
        '
        Me.colTitle.FieldName = "DrawingTitle"
        Me.colTitle.Name = "colTitle"
        Me.colTitle.Visible = True
        Me.colTitle.VisibleIndex = 0
        '
        'colDwgRevision6
        '
        Me.colDwgRevision6.FieldName = "DwgRevision"
        Me.colDwgRevision6.Name = "colDwgRevision6"
        '
        'colNextHigherAssembly6
        '
        Me.colNextHigherAssembly6.FieldName = "NextHigherAssembly"
        Me.colNextHigherAssembly6.Name = "colNextHigherAssembly6"
        '
        'colADCN5
        '
        Me.colADCN5.FieldName = "ADCN"
        Me.colADCN5.Name = "colADCN5"
        '
        'colDCN
        '
        Me.colDCN.FieldName = "DCN"
        Me.colDCN.Name = "colDCN"
        '
        'colRowNumber
        '
        Me.colRowNumber.FieldName = "RowNumber"
        Me.colRowNumber.Name = "colRowNumber"
        '
        'colSequence
        '
        Me.colSequence.FieldName = "Sequence"
        Me.colSequence.Name = "colSequence"
        '
        'btnAddAssembly
        '
        Me.btnAddAssembly.Location = New System.Drawing.Point(1059, 363)
        Me.btnAddAssembly.Name = "btnAddAssembly"
        Me.btnAddAssembly.Size = New System.Drawing.Size(75, 23)
        Me.btnAddAssembly.TabIndex = 49
        Me.btnAddAssembly.Text = "Add"
        Me.btnAddAssembly.UseVisualStyleBackColor = True
        '
        'GridControl11
        '
        Me.GridControl11.DataSource = Me.bsDrawingsProjects
        Me.GridControl11.Location = New System.Drawing.Point(6, 159)
        Me.GridControl11.MainView = Me.GridView11
        Me.GridControl11.Name = "GridControl11"
        Me.GridControl11.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox6, Me.RepositoryItemComboBox7, Me.RepositoryItemComboBox8})
        Me.GridControl11.Size = New System.Drawing.Size(649, 201)
        Me.GridControl11.TabIndex = 48
        Me.GridControl11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView11})
        '
        'bsDrawingsProjects
        '
        Me.bsDrawingsProjects.DataMember = "tblDrawingsProjects"
        Me.bsDrawingsProjects.DataSource = Me.DsDrawingsProjects1
        '
        'DsDrawingsProjects1
        '
        Me.DsDrawingsProjects1.DataSetName = "dsDrawingsProjects"
        Me.DsDrawingsProjects1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView11
        '
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID6, Me.colRecordIDParent, Me.colProjectName, Me.colProjectNumber, Me.colProgramName, Me.colProgramNumber, Me.colSystem, Me.colDrawingNumber6})
        Me.GridView11.GridControl = Me.GridControl11
        Me.GridView11.LevelIndent = 0
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView11.OptionsView.ShowGroupPanel = False
        Me.GridView11.PreviewIndent = 0
        '
        'colRecordID6
        '
        Me.colRecordID6.FieldName = "RecordID"
        Me.colRecordID6.Name = "colRecordID6"
        Me.colRecordID6.Visible = True
        Me.colRecordID6.VisibleIndex = 0
        Me.colRecordID6.Width = 57
        '
        'colRecordIDParent
        '
        Me.colRecordIDParent.FieldName = "RecordIDParent"
        Me.colRecordIDParent.Name = "colRecordIDParent"
        Me.colRecordIDParent.Visible = True
        Me.colRecordIDParent.VisibleIndex = 1
        Me.colRecordIDParent.Width = 93
        '
        'colProjectName
        '
        Me.colProjectName.Caption = "Project"
        Me.colProjectName.ColumnEdit = Me.RepositoryItemComboBox7
        Me.colProjectName.FieldName = "ProjectName"
        Me.colProjectName.Name = "colProjectName"
        Me.colProjectName.Visible = True
        Me.colProjectName.VisibleIndex = 2
        Me.colProjectName.Width = 69
        '
        'RepositoryItemComboBox7
        '
        Me.RepositoryItemComboBox7.AutoHeight = False
        Me.RepositoryItemComboBox7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox7.Name = "RepositoryItemComboBox7"
        Me.RepositoryItemComboBox7.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colProjectNumber
        '
        Me.colProjectNumber.FieldName = "ProjectNumber"
        Me.colProjectNumber.Name = "colProjectNumber"
        Me.colProjectNumber.Visible = True
        Me.colProjectNumber.VisibleIndex = 3
        Me.colProjectNumber.Width = 82
        '
        'colProgramName
        '
        Me.colProgramName.FieldName = "ProgramName"
        Me.colProgramName.Name = "colProgramName"
        Me.colProgramName.Visible = True
        Me.colProgramName.VisibleIndex = 4
        Me.colProgramName.Width = 81
        '
        'colProgramNumber
        '
        Me.colProgramNumber.Caption = "ACT #"
        Me.colProgramNumber.FieldName = "ProgramNumber"
        Me.colProgramNumber.Name = "colProgramNumber"
        Me.colProgramNumber.OptionsColumn.ReadOnly = True
        Me.colProgramNumber.Visible = True
        Me.colProgramNumber.VisibleIndex = 5
        '
        'colSystem
        '
        Me.colSystem.ColumnEdit = Me.RepositoryItemComboBox6
        Me.colSystem.FieldName = "System"
        Me.colSystem.Name = "colSystem"
        Me.colSystem.Visible = True
        Me.colSystem.VisibleIndex = 6
        Me.colSystem.Width = 69
        '
        'RepositoryItemComboBox6
        '
        Me.RepositoryItemComboBox6.AutoHeight = False
        Me.RepositoryItemComboBox6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox6.Name = "RepositoryItemComboBox6"
        Me.RepositoryItemComboBox6.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colDrawingNumber6
        '
        Me.colDrawingNumber6.FieldName = "DrawingNumber"
        Me.colDrawingNumber6.Name = "colDrawingNumber6"
        Me.colDrawingNumber6.Visible = True
        Me.colDrawingNumber6.VisibleIndex = 7
        Me.colDrawingNumber6.Width = 105
        '
        'RepositoryItemComboBox8
        '
        Me.RepositoryItemComboBox8.AutoHeight = False
        Me.RepositoryItemComboBox8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox8.Name = "RepositoryItemComboBox8"
        '
        'chbIncludeChildren
        '
        Me.chbIncludeChildren.AutoSize = True
        Me.chbIncludeChildren.Location = New System.Drawing.Point(251, 366)
        Me.chbIncludeChildren.Name = "chbIncludeChildren"
        Me.chbIncludeChildren.Size = New System.Drawing.Size(102, 17)
        Me.chbIncludeChildren.TabIndex = 47
        Me.chbIncludeChildren.Text = "Include Children"
        Me.chbIncludeChildren.UseVisualStyleBackColor = True
        '
        'btnDeleteDrawingsProjects
        '
        Me.btnDeleteDrawingsProjects.Location = New System.Drawing.Point(119, 362)
        Me.btnDeleteDrawingsProjects.Name = "btnDeleteDrawingsProjects"
        Me.btnDeleteDrawingsProjects.Size = New System.Drawing.Size(93, 23)
        Me.btnDeleteDrawingsProjects.TabIndex = 46
        Me.btnDeleteDrawingsProjects.Text = "Delete"
        Me.btnDeleteDrawingsProjects.UseVisualStyleBackColor = True
        '
        'btnSaveDrawingsProjects
        '
        Me.btnSaveDrawingsProjects.Location = New System.Drawing.Point(16, 362)
        Me.btnSaveDrawingsProjects.Name = "btnSaveDrawingsProjects"
        Me.btnSaveDrawingsProjects.Size = New System.Drawing.Size(93, 23)
        Me.btnSaveDrawingsProjects.TabIndex = 45
        Me.btnSaveDrawingsProjects.Text = "Save"
        Me.btnSaveDrawingsProjects.UseVisualStyleBackColor = True
        '
        'maskedDetailsDCN
        '
        Me.maskedDetailsDCN.Location = New System.Drawing.Point(661, 246)
        Me.maskedDetailsDCN.Mask = "00000"
        Me.maskedDetailsDCN.Name = "maskedDetailsDCN"
        Me.maskedDetailsDCN.Size = New System.Drawing.Size(189, 20)
        Me.maskedDetailsDCN.TabIndex = 40
        Me.maskedDetailsDCN.ValidatingType = GetType(Integer)
        '
        'lblDCN
        '
        Me.lblDCN.AutoSize = True
        Me.lblDCN.Location = New System.Drawing.Point(661, 230)
        Me.lblDCN.Name = "lblDCN"
        Me.lblDCN.Size = New System.Drawing.Size(30, 13)
        Me.lblDCN.TabIndex = 39
        Me.lblDCN.Text = "DCN"
        '
        'cboDetailsResourceType
        '
        Me.cboDetailsResourceType.Location = New System.Drawing.Point(661, 285)
        Me.cboDetailsResourceType.Name = "cboDetailsResourceType"
        Me.cboDetailsResourceType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDetailsResourceType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDetailsResourceType.Size = New System.Drawing.Size(189, 20)
        Me.cboDetailsResourceType.TabIndex = 38
        '
        'cboDetailsSystem
        '
        Me.cboDetailsSystem.Location = New System.Drawing.Point(547, 364)
        Me.cboDetailsSystem.Name = "cboDetailsSystem"
        Me.cboDetailsSystem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDetailsSystem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDetailsSystem.Size = New System.Drawing.Size(91, 20)
        Me.cboDetailsSystem.TabIndex = 37
        Me.cboDetailsSystem.Visible = False
        '
        'cboDetailsDocumentType
        '
        Me.cboDetailsDocumentType.Location = New System.Drawing.Point(661, 207)
        Me.cboDetailsDocumentType.Name = "cboDetailsDocumentType"
        Me.cboDetailsDocumentType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDetailsDocumentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDetailsDocumentType.Size = New System.Drawing.Size(189, 20)
        Me.cboDetailsDocumentType.TabIndex = 36
        '
        'cboDetailsLocation
        '
        Me.cboDetailsLocation.Location = New System.Drawing.Point(661, 170)
        Me.cboDetailsLocation.Name = "cboDetailsLocation"
        Me.cboDetailsLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDetailsLocation.Properties.Items.AddRange(New Object() {"OKC", "Toronto"})
        Me.cboDetailsLocation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDetailsLocation.Size = New System.Drawing.Size(189, 20)
        Me.cboDetailsLocation.TabIndex = 35
        '
        'btnBrowseInstallationDrawing
        '
        Me.btnBrowseInstallationDrawing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseInstallationDrawing.Location = New System.Drawing.Point(863, 366)
        Me.btnBrowseInstallationDrawing.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowseInstallationDrawing.Name = "btnBrowseInstallationDrawing"
        Me.btnBrowseInstallationDrawing.Size = New System.Drawing.Size(52, 20)
        Me.btnBrowseInstallationDrawing.TabIndex = 33
        Me.btnBrowseInstallationDrawing.Text = "Browse"
        Me.btnBrowseInstallationDrawing.UseVisualStyleBackColor = True
        Me.btnBrowseInstallationDrawing.Visible = False
        '
        'btnBrowseNextAssemblyDrawing
        '
        Me.btnBrowseNextAssemblyDrawing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseNextAssemblyDrawing.Location = New System.Drawing.Point(1139, 363)
        Me.btnBrowseNextAssemblyDrawing.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowseNextAssemblyDrawing.Name = "btnBrowseNextAssemblyDrawing"
        Me.btnBrowseNextAssemblyDrawing.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseNextAssemblyDrawing.TabIndex = 32
        Me.btnBrowseNextAssemblyDrawing.Text = "Browse"
        Me.btnBrowseNextAssemblyDrawing.UseVisualStyleBackColor = True
        '
        'txtDetailsInstallationDrawing
        '
        Me.txtDetailsInstallationDrawing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetailsInstallationDrawing.Location = New System.Drawing.Point(673, 366)
        Me.txtDetailsInstallationDrawing.Name = "txtDetailsInstallationDrawing"
        Me.txtDetailsInstallationDrawing.Size = New System.Drawing.Size(189, 20)
        Me.txtDetailsInstallationDrawing.TabIndex = 31
        Me.txtDetailsInstallationDrawing.Visible = False
        '
        'txtDetailsNextAssemblyDrawing
        '
        Me.txtDetailsNextAssemblyDrawing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetailsNextAssemblyDrawing.Location = New System.Drawing.Point(940, 364)
        Me.txtDetailsNextAssemblyDrawing.Name = "txtDetailsNextAssemblyDrawing"
        Me.txtDetailsNextAssemblyDrawing.ReadOnly = True
        Me.txtDetailsNextAssemblyDrawing.Size = New System.Drawing.Size(113, 20)
        Me.txtDetailsNextAssemblyDrawing.TabIndex = 30
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(661, 347)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 13)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Installation Drawing"
        Me.Label19.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(661, 269)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Resource Type"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(500, 366)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "System"
        Me.Label17.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(661, 191)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Document Type"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(661, 154)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Location"
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.bsMainInformationTab
        Me.GridControl3.Location = New System.Drawing.Point(6, 6)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(1390, 147)
        Me.GridControl3.TabIndex = 17
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colExpr2, Me.colProgram2, Me.colSystemDescription2, Me.colLocation2, Me.colType2, Me.colNextHigherAssembly2, Me.colADCN3, Me.colInstallationDrawing2, Me.colRecordID2, Me.colDocumentType2, Me.colPriority2, Me.colDwgRequestBy2, Me.colDrawingNumber2, Me.colDwgRequestDate2, Me.colDrawingTitle2, Me.colDrawingType2, Me.colStatus2, Me.colLastActionDate2, Me.colActualFinishDate2, Me.colForecastStartDate2, Me.colForecastFinishDate2, Me.colPlannedFinishDate2, Me.colEstimatedDurationHours2, Me.colPercentComplete2, Me.colDrawingFolderAssignDate2, Me.colDesignWIPDate2, Me.colNotes2, Me.colModelTemplateDate2, Me.colDrafter2, Me.colDrafterComplete2, Me.colEngineer2, Me.colEngineerComplete2, Me.colSrEngineer2, Me.colSrEngineerComplete2, Me.colReleaser2, Me.colReleaserCompelte2, Me.colFlammability2, Me.colFlammabilityComplete2, Me.colStress2, Me.colStressComplete2, Me.colRefID2, Me.colDrafterPlannedCompleteDate2, Me.colEngineerPlannedCompleteDate2, Me.colSrEngineerPlannedCompleteDate2, Me.colFlammabilityPlannedCompleteDate2, Me.colStressPlannedCompleteDate2, Me.colReleaserPlannedCompleteDate2, Me.colAvionics2, Me.colAvionicsComplete2, Me.colAvionicsPlannedComplete2, Me.colMechanical2, Me.colMechanicalComplete2, Me.colMechanicalPlannedComplete2, Me.colWONumber2, Me.colWhiteBoardNumber2, Me.colDRNADCN2, Me.colFAAProjectNo2, Me.colPSCPDocsRequired2, Me.colCompanyFlightTestRequired2, Me.colDwgReqDate2, Me.colNewRework2, Me.colUpdated2, Me.colUpdatedDate2, Me.colDwgRevision2, Me.colSeq, Me.colDCNDetailsTab, Me.colDRNDetails, Me.colProgramRealDetailsTab})
        Me.GridView3.DetailHeight = 349
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.LevelIndent = 0
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowSort = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.PreviewIndent = 0
        '
        'colExpr2
        '
        Me.colExpr2.Caption = "Doc Rev"
        Me.colExpr2.FieldName = "Expr2"
        Me.colExpr2.Name = "colExpr2"
        Me.colExpr2.OptionsColumn.ReadOnly = True
        Me.colExpr2.Visible = True
        Me.colExpr2.VisibleIndex = 0
        Me.colExpr2.Width = 47
        '
        'colProgram2
        '
        Me.colProgram2.Caption = "Project"
        Me.colProgram2.FieldName = "Program"
        Me.colProgram2.Name = "colProgram2"
        Me.colProgram2.OptionsColumn.ReadOnly = True
        Me.colProgram2.Visible = True
        Me.colProgram2.VisibleIndex = 5
        Me.colProgram2.Width = 174
        '
        'colSystemDescription2
        '
        Me.colSystemDescription2.FieldName = "SystemDescription"
        Me.colSystemDescription2.Name = "colSystemDescription2"
        Me.colSystemDescription2.OptionsColumn.ReadOnly = True
        Me.colSystemDescription2.Visible = True
        Me.colSystemDescription2.VisibleIndex = 6
        Me.colSystemDescription2.Width = 114
        '
        'colLocation2
        '
        Me.colLocation2.FieldName = "Location"
        Me.colLocation2.Name = "colLocation2"
        Me.colLocation2.OptionsColumn.ReadOnly = True
        Me.colLocation2.Visible = True
        Me.colLocation2.VisibleIndex = 7
        Me.colLocation2.Width = 114
        '
        'colType2
        '
        Me.colType2.Caption = "Resource Type"
        Me.colType2.FieldName = "Type"
        Me.colType2.Name = "colType2"
        Me.colType2.OptionsColumn.ReadOnly = True
        Me.colType2.Visible = True
        Me.colType2.VisibleIndex = 8
        Me.colType2.Width = 114
        '
        'colNextHigherAssembly2
        '
        Me.colNextHigherAssembly2.Caption = "Next Assembly Drawing"
        Me.colNextHigherAssembly2.FieldName = "NextHigherAssembly"
        Me.colNextHigherAssembly2.Name = "colNextHigherAssembly2"
        Me.colNextHigherAssembly2.OptionsColumn.ReadOnly = True
        Me.colNextHigherAssembly2.Visible = True
        Me.colNextHigherAssembly2.VisibleIndex = 10
        Me.colNextHigherAssembly2.Width = 114
        '
        'colADCN3
        '
        Me.colADCN3.FieldName = "ADCN"
        Me.colADCN3.Name = "colADCN3"
        Me.colADCN3.Visible = True
        Me.colADCN3.VisibleIndex = 2
        Me.colADCN3.Width = 85
        '
        'colInstallationDrawing2
        '
        Me.colInstallationDrawing2.FieldName = "InstallationDrawing"
        Me.colInstallationDrawing2.Name = "colInstallationDrawing2"
        Me.colInstallationDrawing2.OptionsColumn.ReadOnly = True
        Me.colInstallationDrawing2.Visible = True
        Me.colInstallationDrawing2.VisibleIndex = 11
        Me.colInstallationDrawing2.Width = 157
        '
        'colRecordID2
        '
        Me.colRecordID2.FieldName = "RecordID"
        Me.colRecordID2.Name = "colRecordID2"
        Me.colRecordID2.Width = 112
        '
        'colDocumentType2
        '
        Me.colDocumentType2.FieldName = "DocumentType"
        Me.colDocumentType2.Name = "colDocumentType2"
        Me.colDocumentType2.OptionsColumn.ReadOnly = True
        Me.colDocumentType2.Visible = True
        Me.colDocumentType2.VisibleIndex = 9
        Me.colDocumentType2.Width = 114
        '
        'colPriority2
        '
        Me.colPriority2.FieldName = "Priority"
        Me.colPriority2.Name = "colPriority2"
        Me.colPriority2.Width = 112
        '
        'colDwgRequestBy2
        '
        Me.colDwgRequestBy2.FieldName = "DwgRequestBy"
        Me.colDwgRequestBy2.Name = "colDwgRequestBy2"
        Me.colDwgRequestBy2.Width = 112
        '
        'colDrawingNumber2
        '
        Me.colDrawingNumber2.FieldName = "DrawingNumber"
        Me.colDrawingNumber2.Name = "colDrawingNumber2"
        Me.colDrawingNumber2.Width = 112
        '
        'colDwgRequestDate2
        '
        Me.colDwgRequestDate2.FieldName = "DwgRequestDate"
        Me.colDwgRequestDate2.Name = "colDwgRequestDate2"
        Me.colDwgRequestDate2.Width = 112
        '
        'colDrawingTitle2
        '
        Me.colDrawingTitle2.FieldName = "DrawingTitle"
        Me.colDrawingTitle2.Name = "colDrawingTitle2"
        Me.colDrawingTitle2.Width = 112
        '
        'colDrawingType2
        '
        Me.colDrawingType2.Caption = "Document Type"
        Me.colDrawingType2.FieldName = "DrawingType"
        Me.colDrawingType2.Name = "colDrawingType2"
        Me.colDrawingType2.Width = 112
        '
        'colStatus2
        '
        Me.colStatus2.FieldName = "Status"
        Me.colStatus2.Name = "colStatus2"
        Me.colStatus2.Width = 112
        '
        'colLastActionDate2
        '
        Me.colLastActionDate2.FieldName = "LastActionDate"
        Me.colLastActionDate2.Name = "colLastActionDate2"
        Me.colLastActionDate2.Width = 112
        '
        'colActualFinishDate2
        '
        Me.colActualFinishDate2.FieldName = "ActualFinishDate"
        Me.colActualFinishDate2.Name = "colActualFinishDate2"
        Me.colActualFinishDate2.Width = 112
        '
        'colForecastStartDate2
        '
        Me.colForecastStartDate2.FieldName = "ForecastStartDate"
        Me.colForecastStartDate2.Name = "colForecastStartDate2"
        Me.colForecastStartDate2.Width = 112
        '
        'colForecastFinishDate2
        '
        Me.colForecastFinishDate2.FieldName = "ForecastFinishDate"
        Me.colForecastFinishDate2.Name = "colForecastFinishDate2"
        Me.colForecastFinishDate2.Width = 112
        '
        'colPlannedFinishDate2
        '
        Me.colPlannedFinishDate2.FieldName = "PlannedFinishDate"
        Me.colPlannedFinishDate2.Name = "colPlannedFinishDate2"
        Me.colPlannedFinishDate2.Width = 112
        '
        'colEstimatedDurationHours2
        '
        Me.colEstimatedDurationHours2.FieldName = "EstimatedDurationHours"
        Me.colEstimatedDurationHours2.Name = "colEstimatedDurationHours2"
        Me.colEstimatedDurationHours2.Width = 112
        '
        'colPercentComplete2
        '
        Me.colPercentComplete2.FieldName = "PercentComplete"
        Me.colPercentComplete2.Name = "colPercentComplete2"
        Me.colPercentComplete2.Width = 112
        '
        'colDrawingFolderAssignDate2
        '
        Me.colDrawingFolderAssignDate2.FieldName = "DrawingFolderAssignDate"
        Me.colDrawingFolderAssignDate2.Name = "colDrawingFolderAssignDate2"
        Me.colDrawingFolderAssignDate2.Width = 112
        '
        'colDesignWIPDate2
        '
        Me.colDesignWIPDate2.FieldName = "DesignWIPDate"
        Me.colDesignWIPDate2.Name = "colDesignWIPDate2"
        Me.colDesignWIPDate2.Width = 112
        '
        'colNotes2
        '
        Me.colNotes2.FieldName = "Notes"
        Me.colNotes2.Name = "colNotes2"
        Me.colNotes2.Width = 112
        '
        'colModelTemplateDate2
        '
        Me.colModelTemplateDate2.FieldName = "ModelTemplateDate"
        Me.colModelTemplateDate2.Name = "colModelTemplateDate2"
        Me.colModelTemplateDate2.Width = 112
        '
        'colDrafter2
        '
        Me.colDrafter2.FieldName = "Drafter"
        Me.colDrafter2.Name = "colDrafter2"
        Me.colDrafter2.Width = 112
        '
        'colDrafterComplete2
        '
        Me.colDrafterComplete2.FieldName = "DrafterComplete"
        Me.colDrafterComplete2.Name = "colDrafterComplete2"
        Me.colDrafterComplete2.Width = 112
        '
        'colEngineer2
        '
        Me.colEngineer2.FieldName = "Engineer"
        Me.colEngineer2.Name = "colEngineer2"
        Me.colEngineer2.Width = 112
        '
        'colEngineerComplete2
        '
        Me.colEngineerComplete2.FieldName = "EngineerComplete"
        Me.colEngineerComplete2.Name = "colEngineerComplete2"
        Me.colEngineerComplete2.Width = 112
        '
        'colSrEngineer2
        '
        Me.colSrEngineer2.FieldName = "SrEngineer"
        Me.colSrEngineer2.Name = "colSrEngineer2"
        Me.colSrEngineer2.Width = 112
        '
        'colSrEngineerComplete2
        '
        Me.colSrEngineerComplete2.FieldName = "SrEngineerComplete"
        Me.colSrEngineerComplete2.Name = "colSrEngineerComplete2"
        Me.colSrEngineerComplete2.Width = 112
        '
        'colReleaser2
        '
        Me.colReleaser2.FieldName = "Releaser"
        Me.colReleaser2.Name = "colReleaser2"
        Me.colReleaser2.Width = 112
        '
        'colReleaserCompelte2
        '
        Me.colReleaserCompelte2.FieldName = "ReleaserCompelte"
        Me.colReleaserCompelte2.Name = "colReleaserCompelte2"
        Me.colReleaserCompelte2.Width = 112
        '
        'colFlammability2
        '
        Me.colFlammability2.FieldName = "Flammability"
        Me.colFlammability2.Name = "colFlammability2"
        Me.colFlammability2.Width = 112
        '
        'colFlammabilityComplete2
        '
        Me.colFlammabilityComplete2.FieldName = "FlammabilityComplete"
        Me.colFlammabilityComplete2.Name = "colFlammabilityComplete2"
        Me.colFlammabilityComplete2.Width = 112
        '
        'colStress2
        '
        Me.colStress2.FieldName = "Stress"
        Me.colStress2.Name = "colStress2"
        Me.colStress2.Width = 112
        '
        'colStressComplete2
        '
        Me.colStressComplete2.FieldName = "StressComplete"
        Me.colStressComplete2.Name = "colStressComplete2"
        Me.colStressComplete2.Width = 112
        '
        'colRefID2
        '
        Me.colRefID2.FieldName = "RefID"
        Me.colRefID2.Name = "colRefID2"
        Me.colRefID2.Width = 112
        '
        'colDrafterPlannedCompleteDate2
        '
        Me.colDrafterPlannedCompleteDate2.FieldName = "DrafterPlannedCompleteDate"
        Me.colDrafterPlannedCompleteDate2.Name = "colDrafterPlannedCompleteDate2"
        Me.colDrafterPlannedCompleteDate2.Width = 112
        '
        'colEngineerPlannedCompleteDate2
        '
        Me.colEngineerPlannedCompleteDate2.FieldName = "EngineerPlannedCompleteDate"
        Me.colEngineerPlannedCompleteDate2.Name = "colEngineerPlannedCompleteDate2"
        Me.colEngineerPlannedCompleteDate2.Width = 112
        '
        'colSrEngineerPlannedCompleteDate2
        '
        Me.colSrEngineerPlannedCompleteDate2.FieldName = "SrEngineerPlannedCompleteDate"
        Me.colSrEngineerPlannedCompleteDate2.Name = "colSrEngineerPlannedCompleteDate2"
        Me.colSrEngineerPlannedCompleteDate2.Width = 112
        '
        'colFlammabilityPlannedCompleteDate2
        '
        Me.colFlammabilityPlannedCompleteDate2.FieldName = "FlammabilityPlannedCompleteDate"
        Me.colFlammabilityPlannedCompleteDate2.Name = "colFlammabilityPlannedCompleteDate2"
        Me.colFlammabilityPlannedCompleteDate2.Width = 112
        '
        'colStressPlannedCompleteDate2
        '
        Me.colStressPlannedCompleteDate2.FieldName = "StressPlannedCompleteDate"
        Me.colStressPlannedCompleteDate2.Name = "colStressPlannedCompleteDate2"
        Me.colStressPlannedCompleteDate2.Width = 112
        '
        'colReleaserPlannedCompleteDate2
        '
        Me.colReleaserPlannedCompleteDate2.FieldName = "ReleaserPlannedCompleteDate"
        Me.colReleaserPlannedCompleteDate2.Name = "colReleaserPlannedCompleteDate2"
        Me.colReleaserPlannedCompleteDate2.Width = 112
        '
        'colAvionics2
        '
        Me.colAvionics2.FieldName = "Avionics"
        Me.colAvionics2.Name = "colAvionics2"
        Me.colAvionics2.Width = 112
        '
        'colAvionicsComplete2
        '
        Me.colAvionicsComplete2.FieldName = "AvionicsComplete"
        Me.colAvionicsComplete2.Name = "colAvionicsComplete2"
        Me.colAvionicsComplete2.Width = 112
        '
        'colAvionicsPlannedComplete2
        '
        Me.colAvionicsPlannedComplete2.FieldName = "AvionicsPlannedComplete"
        Me.colAvionicsPlannedComplete2.Name = "colAvionicsPlannedComplete2"
        Me.colAvionicsPlannedComplete2.Width = 112
        '
        'colMechanical2
        '
        Me.colMechanical2.FieldName = "Mechanical"
        Me.colMechanical2.Name = "colMechanical2"
        Me.colMechanical2.Width = 112
        '
        'colMechanicalComplete2
        '
        Me.colMechanicalComplete2.FieldName = "MechanicalComplete"
        Me.colMechanicalComplete2.Name = "colMechanicalComplete2"
        Me.colMechanicalComplete2.Width = 112
        '
        'colMechanicalPlannedComplete2
        '
        Me.colMechanicalPlannedComplete2.FieldName = "MechanicalPlannedComplete"
        Me.colMechanicalPlannedComplete2.Name = "colMechanicalPlannedComplete2"
        Me.colMechanicalPlannedComplete2.Width = 112
        '
        'colWONumber2
        '
        Me.colWONumber2.FieldName = "WONumber"
        Me.colWONumber2.Name = "colWONumber2"
        Me.colWONumber2.Width = 112
        '
        'colWhiteBoardNumber2
        '
        Me.colWhiteBoardNumber2.FieldName = "WhiteBoardNumber"
        Me.colWhiteBoardNumber2.Name = "colWhiteBoardNumber2"
        Me.colWhiteBoardNumber2.Width = 112
        '
        'colDRNADCN2
        '
        Me.colDRNADCN2.FieldName = "DRNADCN"
        Me.colDRNADCN2.Name = "colDRNADCN2"
        Me.colDRNADCN2.Width = 112
        '
        'colFAAProjectNo2
        '
        Me.colFAAProjectNo2.FieldName = "FAAProjectNo"
        Me.colFAAProjectNo2.Name = "colFAAProjectNo2"
        Me.colFAAProjectNo2.Width = 112
        '
        'colPSCPDocsRequired2
        '
        Me.colPSCPDocsRequired2.FieldName = "PSCPDocsRequired"
        Me.colPSCPDocsRequired2.Name = "colPSCPDocsRequired2"
        Me.colPSCPDocsRequired2.Width = 112
        '
        'colCompanyFlightTestRequired2
        '
        Me.colCompanyFlightTestRequired2.FieldName = "CompanyFlightTestRequired"
        Me.colCompanyFlightTestRequired2.Name = "colCompanyFlightTestRequired2"
        Me.colCompanyFlightTestRequired2.Width = 112
        '
        'colDwgReqDate2
        '
        Me.colDwgReqDate2.FieldName = "DwgReqDate"
        Me.colDwgReqDate2.Name = "colDwgReqDate2"
        Me.colDwgReqDate2.Width = 112
        '
        'colNewRework2
        '
        Me.colNewRework2.FieldName = "NewRework"
        Me.colNewRework2.Name = "colNewRework2"
        Me.colNewRework2.Width = 112
        '
        'colUpdated2
        '
        Me.colUpdated2.FieldName = "Updated"
        Me.colUpdated2.Name = "colUpdated2"
        Me.colUpdated2.Width = 112
        '
        'colUpdatedDate2
        '
        Me.colUpdatedDate2.FieldName = "UpdatedDate"
        Me.colUpdatedDate2.Name = "colUpdatedDate2"
        Me.colUpdatedDate2.Width = 112
        '
        'colDwgRevision2
        '
        Me.colDwgRevision2.FieldName = "DwgRevision"
        Me.colDwgRevision2.Name = "colDwgRevision2"
        Me.colDwgRevision2.Width = 112
        '
        'colSeq
        '
        Me.colSeq.FieldName = "Seq"
        Me.colSeq.Name = "colSeq"
        Me.colSeq.Width = 112
        '
        'colDCNDetailsTab
        '
        Me.colDCNDetailsTab.FieldName = "DCN"
        Me.colDCNDetailsTab.Name = "colDCNDetailsTab"
        Me.colDCNDetailsTab.Visible = True
        Me.colDCNDetailsTab.VisibleIndex = 3
        Me.colDCNDetailsTab.Width = 89
        '
        'colDRNDetails
        '
        Me.colDRNDetails.Caption = "DRN"
        Me.colDRNDetails.FieldName = "DRNADCN"
        Me.colDRNDetails.Name = "colDRNDetails"
        Me.colDRNDetails.Visible = True
        Me.colDRNDetails.VisibleIndex = 1
        Me.colDRNDetails.Width = 82
        '
        'colProgramRealDetailsTab
        '
        Me.colProgramRealDetailsTab.Caption = "Program"
        Me.colProgramRealDetailsTab.FieldName = "ProgramReal"
        Me.colProgramRealDetailsTab.Name = "colProgramRealDetailsTab"
        Me.colProgramRealDetailsTab.Visible = True
        Me.colProgramRealDetailsTab.VisibleIndex = 4
        Me.colProgramRealDetailsTab.Width = 168
        '
        'cboDetailsProgram
        '
        Me.cboDetailsProgram.Location = New System.Drawing.Point(664, 365)
        Me.cboDetailsProgram.Name = "cboDetailsProgram"
        Me.cboDetailsProgram.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDetailsProgram.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDetailsProgram.Size = New System.Drawing.Size(133, 20)
        Me.cboDetailsProgram.TabIndex = 34
        Me.cboDetailsProgram.Visible = False
        '
        'txtMainProjectName
        '
        Me.txtMainProjectName.Location = New System.Drawing.Point(402, 106)
        Me.txtMainProjectName.Name = "txtMainProjectName"
        Me.txtMainProjectName.Size = New System.Drawing.Size(100, 20)
        Me.txtMainProjectName.TabIndex = 41
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtNotesNotes)
        Me.TabPage5.Controls.Add(Me.GridControl4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1502, 388)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Notes"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'txtNotesNotes
        '
        Me.txtNotesNotes.Location = New System.Drawing.Point(6, 148)
        Me.txtNotesNotes.Multiline = True
        Me.txtNotesNotes.Name = "txtNotesNotes"
        Me.txtNotesNotes.Size = New System.Drawing.Size(1380, 169)
        Me.txtNotesNotes.TabIndex = 19
        '
        'GridControl4
        '
        Me.GridControl4.DataSource = Me.bsMainInformationTab
        Me.GridControl4.Location = New System.Drawing.Point(6, 6)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(1380, 122)
        Me.GridControl4.TabIndex = 18
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colExpr21, Me.colNotes3, Me.colRecordID3, Me.colDocumentType3, Me.colPriority3, Me.colLocation3, Me.colType3, Me.colDwgRequestBy3, Me.colDrawingNumber3, Me.colDwgRequestDate3, Me.colDrawingTitle3, Me.colProgram3, Me.colDrawingType3, Me.colSystemDescription3, Me.colStatus3, Me.colLastActionDate3, Me.colActualFinishDate3, Me.colForecastStartDate3, Me.colForecastFinishDate3, Me.colPlannedFinishDate3, Me.colEstimatedDurationHours3, Me.colPercentComplete3, Me.colDrawingFolderAssignDate3, Me.colDesignWIPDate3, Me.colModelTemplateDate3, Me.colDrafter3, Me.colDrafterComplete3, Me.colEngineer3, Me.colEngineerComplete3, Me.colSrEngineer3, Me.colSrEngineerComplete3, Me.colReleaser3, Me.colReleaserCompelte3, Me.colFlammability3, Me.colFlammabilityComplete3, Me.colStress3, Me.colStressComplete3, Me.colRefID3, Me.colDrafterPlannedCompleteDate3, Me.colEngineerPlannedCompleteDate3, Me.colSrEngineerPlannedCompleteDate3, Me.colFlammabilityPlannedCompleteDate3, Me.colStressPlannedCompleteDate3, Me.colReleaserPlannedCompleteDate3, Me.colAvionics3, Me.colAvionicsComplete3, Me.colAvionicsPlannedComplete3, Me.colMechanical3, Me.colMechanicalComplete3, Me.colMechanicalPlannedComplete3, Me.colWONumber3, Me.colNextHigherAssembly3, Me.colInstallationDrawing3, Me.colWhiteBoardNumber3, Me.colDRNADCN3, Me.colFAAProjectNo3, Me.colPSCPDocsRequired3, Me.colCompanyFlightTestRequired3, Me.colDwgReqDate3, Me.colNewRework3, Me.colUpdated3, Me.colUpdatedDate3, Me.colDwgRevision3, Me.colSeq1, Me.colDRNNotes, Me.colADCNNotes})
        Me.GridView4.DetailHeight = 349
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.LevelIndent = 0
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsCustomization.AllowSort = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.PreviewIndent = 0
        '
        'colExpr21
        '
        Me.colExpr21.Caption = "Doc Rev"
        Me.colExpr21.FieldName = "Expr2"
        Me.colExpr21.Name = "colExpr21"
        Me.colExpr21.OptionsColumn.ReadOnly = True
        Me.colExpr21.Visible = True
        Me.colExpr21.VisibleIndex = 0
        Me.colExpr21.Width = 52
        '
        'colNotes3
        '
        Me.colNotes3.FieldName = "Notes"
        Me.colNotes3.Name = "colNotes3"
        Me.colNotes3.OptionsColumn.ReadOnly = True
        Me.colNotes3.Visible = True
        Me.colNotes3.VisibleIndex = 3
        Me.colNotes3.Width = 1029
        '
        'colRecordID3
        '
        Me.colRecordID3.FieldName = "RecordID"
        Me.colRecordID3.Name = "colRecordID3"
        '
        'colDocumentType3
        '
        Me.colDocumentType3.FieldName = "DocumentType"
        Me.colDocumentType3.Name = "colDocumentType3"
        '
        'colPriority3
        '
        Me.colPriority3.FieldName = "Priority"
        Me.colPriority3.Name = "colPriority3"
        '
        'colLocation3
        '
        Me.colLocation3.FieldName = "Location"
        Me.colLocation3.Name = "colLocation3"
        '
        'colType3
        '
        Me.colType3.FieldName = "Type"
        Me.colType3.Name = "colType3"
        '
        'colDwgRequestBy3
        '
        Me.colDwgRequestBy3.FieldName = "DwgRequestBy"
        Me.colDwgRequestBy3.Name = "colDwgRequestBy3"
        '
        'colDrawingNumber3
        '
        Me.colDrawingNumber3.FieldName = "DrawingNumber"
        Me.colDrawingNumber3.Name = "colDrawingNumber3"
        '
        'colDwgRequestDate3
        '
        Me.colDwgRequestDate3.FieldName = "DwgRequestDate"
        Me.colDwgRequestDate3.Name = "colDwgRequestDate3"
        '
        'colDrawingTitle3
        '
        Me.colDrawingTitle3.FieldName = "DrawingTitle"
        Me.colDrawingTitle3.Name = "colDrawingTitle3"
        '
        'colProgram3
        '
        Me.colProgram3.FieldName = "Program"
        Me.colProgram3.Name = "colProgram3"
        '
        'colDrawingType3
        '
        Me.colDrawingType3.FieldName = "DrawingType"
        Me.colDrawingType3.Name = "colDrawingType3"
        '
        'colSystemDescription3
        '
        Me.colSystemDescription3.FieldName = "SystemDescription"
        Me.colSystemDescription3.Name = "colSystemDescription3"
        '
        'colStatus3
        '
        Me.colStatus3.FieldName = "Status"
        Me.colStatus3.Name = "colStatus3"
        '
        'colLastActionDate3
        '
        Me.colLastActionDate3.FieldName = "LastActionDate"
        Me.colLastActionDate3.Name = "colLastActionDate3"
        '
        'colActualFinishDate3
        '
        Me.colActualFinishDate3.FieldName = "ActualFinishDate"
        Me.colActualFinishDate3.Name = "colActualFinishDate3"
        '
        'colForecastStartDate3
        '
        Me.colForecastStartDate3.FieldName = "ForecastStartDate"
        Me.colForecastStartDate3.Name = "colForecastStartDate3"
        '
        'colForecastFinishDate3
        '
        Me.colForecastFinishDate3.FieldName = "ForecastFinishDate"
        Me.colForecastFinishDate3.Name = "colForecastFinishDate3"
        '
        'colPlannedFinishDate3
        '
        Me.colPlannedFinishDate3.FieldName = "PlannedFinishDate"
        Me.colPlannedFinishDate3.Name = "colPlannedFinishDate3"
        '
        'colEstimatedDurationHours3
        '
        Me.colEstimatedDurationHours3.FieldName = "EstimatedDurationHours"
        Me.colEstimatedDurationHours3.Name = "colEstimatedDurationHours3"
        '
        'colPercentComplete3
        '
        Me.colPercentComplete3.FieldName = "PercentComplete"
        Me.colPercentComplete3.Name = "colPercentComplete3"
        '
        'colDrawingFolderAssignDate3
        '
        Me.colDrawingFolderAssignDate3.FieldName = "DrawingFolderAssignDate"
        Me.colDrawingFolderAssignDate3.Name = "colDrawingFolderAssignDate3"
        '
        'colDesignWIPDate3
        '
        Me.colDesignWIPDate3.FieldName = "DesignWIPDate"
        Me.colDesignWIPDate3.Name = "colDesignWIPDate3"
        '
        'colModelTemplateDate3
        '
        Me.colModelTemplateDate3.FieldName = "ModelTemplateDate"
        Me.colModelTemplateDate3.Name = "colModelTemplateDate3"
        '
        'colDrafter3
        '
        Me.colDrafter3.FieldName = "Drafter"
        Me.colDrafter3.Name = "colDrafter3"
        '
        'colDrafterComplete3
        '
        Me.colDrafterComplete3.FieldName = "DrafterComplete"
        Me.colDrafterComplete3.Name = "colDrafterComplete3"
        '
        'colEngineer3
        '
        Me.colEngineer3.FieldName = "Engineer"
        Me.colEngineer3.Name = "colEngineer3"
        '
        'colEngineerComplete3
        '
        Me.colEngineerComplete3.FieldName = "EngineerComplete"
        Me.colEngineerComplete3.Name = "colEngineerComplete3"
        '
        'colSrEngineer3
        '
        Me.colSrEngineer3.FieldName = "SrEngineer"
        Me.colSrEngineer3.Name = "colSrEngineer3"
        '
        'colSrEngineerComplete3
        '
        Me.colSrEngineerComplete3.FieldName = "SrEngineerComplete"
        Me.colSrEngineerComplete3.Name = "colSrEngineerComplete3"
        '
        'colReleaser3
        '
        Me.colReleaser3.FieldName = "Releaser"
        Me.colReleaser3.Name = "colReleaser3"
        '
        'colReleaserCompelte3
        '
        Me.colReleaserCompelte3.FieldName = "ReleaserCompelte"
        Me.colReleaserCompelte3.Name = "colReleaserCompelte3"
        '
        'colFlammability3
        '
        Me.colFlammability3.FieldName = "Flammability"
        Me.colFlammability3.Name = "colFlammability3"
        '
        'colFlammabilityComplete3
        '
        Me.colFlammabilityComplete3.FieldName = "FlammabilityComplete"
        Me.colFlammabilityComplete3.Name = "colFlammabilityComplete3"
        '
        'colStress3
        '
        Me.colStress3.FieldName = "Stress"
        Me.colStress3.Name = "colStress3"
        '
        'colStressComplete3
        '
        Me.colStressComplete3.FieldName = "StressComplete"
        Me.colStressComplete3.Name = "colStressComplete3"
        '
        'colRefID3
        '
        Me.colRefID3.FieldName = "RefID"
        Me.colRefID3.Name = "colRefID3"
        '
        'colDrafterPlannedCompleteDate3
        '
        Me.colDrafterPlannedCompleteDate3.FieldName = "DrafterPlannedCompleteDate"
        Me.colDrafterPlannedCompleteDate3.Name = "colDrafterPlannedCompleteDate3"
        '
        'colEngineerPlannedCompleteDate3
        '
        Me.colEngineerPlannedCompleteDate3.FieldName = "EngineerPlannedCompleteDate"
        Me.colEngineerPlannedCompleteDate3.Name = "colEngineerPlannedCompleteDate3"
        '
        'colSrEngineerPlannedCompleteDate3
        '
        Me.colSrEngineerPlannedCompleteDate3.FieldName = "SrEngineerPlannedCompleteDate"
        Me.colSrEngineerPlannedCompleteDate3.Name = "colSrEngineerPlannedCompleteDate3"
        '
        'colFlammabilityPlannedCompleteDate3
        '
        Me.colFlammabilityPlannedCompleteDate3.FieldName = "FlammabilityPlannedCompleteDate"
        Me.colFlammabilityPlannedCompleteDate3.Name = "colFlammabilityPlannedCompleteDate3"
        '
        'colStressPlannedCompleteDate3
        '
        Me.colStressPlannedCompleteDate3.FieldName = "StressPlannedCompleteDate"
        Me.colStressPlannedCompleteDate3.Name = "colStressPlannedCompleteDate3"
        '
        'colReleaserPlannedCompleteDate3
        '
        Me.colReleaserPlannedCompleteDate3.FieldName = "ReleaserPlannedCompleteDate"
        Me.colReleaserPlannedCompleteDate3.Name = "colReleaserPlannedCompleteDate3"
        '
        'colAvionics3
        '
        Me.colAvionics3.FieldName = "Avionics"
        Me.colAvionics3.Name = "colAvionics3"
        '
        'colAvionicsComplete3
        '
        Me.colAvionicsComplete3.FieldName = "AvionicsComplete"
        Me.colAvionicsComplete3.Name = "colAvionicsComplete3"
        '
        'colAvionicsPlannedComplete3
        '
        Me.colAvionicsPlannedComplete3.FieldName = "AvionicsPlannedComplete"
        Me.colAvionicsPlannedComplete3.Name = "colAvionicsPlannedComplete3"
        '
        'colMechanical3
        '
        Me.colMechanical3.FieldName = "Mechanical"
        Me.colMechanical3.Name = "colMechanical3"
        '
        'colMechanicalComplete3
        '
        Me.colMechanicalComplete3.FieldName = "MechanicalComplete"
        Me.colMechanicalComplete3.Name = "colMechanicalComplete3"
        '
        'colMechanicalPlannedComplete3
        '
        Me.colMechanicalPlannedComplete3.FieldName = "MechanicalPlannedComplete"
        Me.colMechanicalPlannedComplete3.Name = "colMechanicalPlannedComplete3"
        '
        'colWONumber3
        '
        Me.colWONumber3.FieldName = "WONumber"
        Me.colWONumber3.Name = "colWONumber3"
        '
        'colNextHigherAssembly3
        '
        Me.colNextHigherAssembly3.FieldName = "NextHigherAssembly"
        Me.colNextHigherAssembly3.Name = "colNextHigherAssembly3"
        '
        'colInstallationDrawing3
        '
        Me.colInstallationDrawing3.FieldName = "InstallationDrawing"
        Me.colInstallationDrawing3.Name = "colInstallationDrawing3"
        '
        'colWhiteBoardNumber3
        '
        Me.colWhiteBoardNumber3.FieldName = "WhiteBoardNumber"
        Me.colWhiteBoardNumber3.Name = "colWhiteBoardNumber3"
        '
        'colDRNADCN3
        '
        Me.colDRNADCN3.FieldName = "DRNADCN"
        Me.colDRNADCN3.Name = "colDRNADCN3"
        '
        'colFAAProjectNo3
        '
        Me.colFAAProjectNo3.FieldName = "FAAProjectNo"
        Me.colFAAProjectNo3.Name = "colFAAProjectNo3"
        '
        'colPSCPDocsRequired3
        '
        Me.colPSCPDocsRequired3.FieldName = "PSCPDocsRequired"
        Me.colPSCPDocsRequired3.Name = "colPSCPDocsRequired3"
        '
        'colCompanyFlightTestRequired3
        '
        Me.colCompanyFlightTestRequired3.FieldName = "CompanyFlightTestRequired"
        Me.colCompanyFlightTestRequired3.Name = "colCompanyFlightTestRequired3"
        '
        'colDwgReqDate3
        '
        Me.colDwgReqDate3.FieldName = "DwgReqDate"
        Me.colDwgReqDate3.Name = "colDwgReqDate3"
        '
        'colNewRework3
        '
        Me.colNewRework3.FieldName = "NewRework"
        Me.colNewRework3.Name = "colNewRework3"
        '
        'colUpdated3
        '
        Me.colUpdated3.FieldName = "Updated"
        Me.colUpdated3.Name = "colUpdated3"
        '
        'colUpdatedDate3
        '
        Me.colUpdatedDate3.FieldName = "UpdatedDate"
        Me.colUpdatedDate3.Name = "colUpdatedDate3"
        '
        'colDwgRevision3
        '
        Me.colDwgRevision3.FieldName = "DwgRevision"
        Me.colDwgRevision3.Name = "colDwgRevision3"
        '
        'colSeq1
        '
        Me.colSeq1.FieldName = "Seq"
        Me.colSeq1.Name = "colSeq1"
        '
        'colDRNNotes
        '
        Me.colDRNNotes.Caption = "DRN"
        Me.colDRNNotes.FieldName = "DRNADCN"
        Me.colDRNNotes.Name = "colDRNNotes"
        Me.colDRNNotes.Visible = True
        Me.colDRNNotes.VisibleIndex = 1
        Me.colDRNNotes.Width = 139
        '
        'colADCNNotes
        '
        Me.colADCNNotes.Caption = "ADCN"
        Me.colADCNNotes.FieldName = "ADCN"
        Me.colADCNNotes.Name = "colADCNNotes"
        Me.colADCNNotes.Visible = True
        Me.colADCNNotes.VisibleIndex = 2
        Me.colADCNNotes.Width = 141
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label48)
        Me.TabPage6.Controls.Add(Me.Label47)
        Me.TabPage6.Controls.Add(Me.Label39)
        Me.TabPage6.Controls.Add(Me.cboIncorporatedRev)
        Me.TabPage6.Controls.Add(Me.cboDRNADCNStatus)
        Me.TabPage6.Controls.Add(Me.cboDRNADCNIncorporatedBy)
        Me.TabPage6.Controls.Add(Me.cboDRN)
        Me.TabPage6.Controls.Add(Me.cboADCN)
        Me.TabPage6.Controls.Add(Me.Label30)
        Me.TabPage6.Controls.Add(Me.Label20)
        Me.TabPage6.Controls.Add(Me.GridControl5)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1502, 388)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "DRN/ADCN"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(739, 237)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(90, 13)
        Me.Label48.TabIndex = 30
        Me.Label48.Text = "Incorporated Rev"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(556, 237)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(144, 13)
        Me.Label47.TabIndex = 29
        Me.Label47.Text = "DRN/ADCN Incorporated By"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(390, 237)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(99, 13)
        Me.Label39.TabIndex = 28
        Me.Label39.Text = "DRN/ADCN Status"
        '
        'cboIncorporatedRev
        '
        Me.cboIncorporatedRev.FormattingEnabled = True
        Me.cboIncorporatedRev.Location = New System.Drawing.Point(742, 270)
        Me.cboIncorporatedRev.Name = "cboIncorporatedRev"
        Me.cboIncorporatedRev.Size = New System.Drawing.Size(121, 21)
        Me.cboIncorporatedRev.TabIndex = 27
        '
        'cboDRNADCNStatus
        '
        Me.cboDRNADCNStatus.FormattingEnabled = True
        Me.cboDRNADCNStatus.Items.AddRange(New Object() {"Incorporated", "Not Incorporated"})
        Me.cboDRNADCNStatus.Location = New System.Drawing.Point(393, 270)
        Me.cboDRNADCNStatus.Name = "cboDRNADCNStatus"
        Me.cboDRNADCNStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboDRNADCNStatus.TabIndex = 26
        '
        'cboDRNADCNIncorporatedBy
        '
        Me.cboDRNADCNIncorporatedBy.FormattingEnabled = True
        Me.cboDRNADCNIncorporatedBy.Location = New System.Drawing.Point(559, 271)
        Me.cboDRNADCNIncorporatedBy.Name = "cboDRNADCNIncorporatedBy"
        Me.cboDRNADCNIncorporatedBy.Size = New System.Drawing.Size(121, 21)
        Me.cboDRNADCNIncorporatedBy.TabIndex = 25
        '
        'cboDRN
        '
        Me.cboDRN.Location = New System.Drawing.Point(22, 269)
        Me.cboDRN.Name = "cboDRN"
        Me.cboDRN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDRN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDRN.Size = New System.Drawing.Size(194, 20)
        Me.cboDRN.TabIndex = 24
        '
        'cboADCN
        '
        Me.cboADCN.Location = New System.Drawing.Point(264, 270)
        Me.cboADCN.Margin = New System.Windows.Forms.Padding(2)
        Me.cboADCN.Mask = "#####"
        Me.cboADCN.Name = "cboADCN"
        Me.cboADCN.Size = New System.Drawing.Size(68, 20)
        Me.cboADCN.TabIndex = 23
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(261, 237)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 13)
        Me.Label30.TabIndex = 22
        Me.Label30.Text = "ADCN"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(19, 237)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "DRN"
        '
        'GridControl5
        '
        Me.GridControl5.DataSource = Me.bsMainInformationTab
        Me.GridControl5.Location = New System.Drawing.Point(3, 3)
        Me.GridControl5.MainView = Me.GridView5
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.Size = New System.Drawing.Size(1394, 223)
        Me.GridControl5.TabIndex = 19
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID4, Me.colDocumentType4, Me.colPriority4, Me.colLocation4, Me.colType4, Me.colDwgRequestBy4, Me.colDrawingNumber4, Me.colDwgRequestDate4, Me.colDrawingTitle4, Me.colProgram4, Me.colDrawingType4, Me.colSystemDescription4, Me.colStatus4, Me.colLastActionDate4, Me.colActualFinishDate4, Me.colForecastStartDate4, Me.colForecastFinishDate4, Me.colPlannedFinishDate4, Me.colEstimatedDurationHours4, Me.colPercentComplete4, Me.colDrawingFolderAssignDate4, Me.colDesignWIPDate4, Me.colNotes4, Me.colModelTemplateDate4, Me.colDrafter4, Me.colDrafterComplete4, Me.colEngineer4, Me.colEngineerComplete4, Me.colSrEngineer4, Me.colSrEngineerComplete4, Me.colReleaser4, Me.colReleaserCompelte4, Me.colFlammability4, Me.colFlammabilityComplete4, Me.colStress4, Me.colStressComplete4, Me.colExpr22, Me.colRefID4, Me.colDrafterPlannedCompleteDate4, Me.colEngineerPlannedCompleteDate4, Me.colSrEngineerPlannedCompleteDate4, Me.colFlammabilityPlannedCompleteDate4, Me.colStressPlannedCompleteDate4, Me.colReleaserPlannedCompleteDate4, Me.colAvionics4, Me.colAvionicsComplete4, Me.colAvionicsPlannedComplete4, Me.colMechanical4, Me.colMechanicalComplete4, Me.colMechanicalPlannedComplete4, Me.colWONumber4, Me.colNextHigherAssembly4, Me.colInstallationDrawing4, Me.colWhiteBoardNumber4, Me.colDRNADCN4, Me.colFAAProjectNo4, Me.colPSCPDocsRequired4, Me.colCompanyFlightTestRequired4, Me.colDwgReqDate4, Me.colNewRework4, Me.colUpdated4, Me.colUpdatedDate4, Me.colDwgRevision4, Me.colSeq2, Me.colADCN, Me.colStatusCol, Me.colDRNADCNStatus, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.colIncorporatedBy})
        Me.GridView5.DetailHeight = 349
        Me.GridView5.GridControl = Me.GridControl5
        Me.GridView5.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView5.LevelIndent = 0
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowSort = False
        Me.GridView5.OptionsView.ColumnAutoWidth = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.PreviewIndent = 0
        '
        'colRecordID4
        '
        Me.colRecordID4.FieldName = "RecordID"
        Me.colRecordID4.Name = "colRecordID4"
        '
        'colDocumentType4
        '
        Me.colDocumentType4.FieldName = "DocumentType"
        Me.colDocumentType4.Name = "colDocumentType4"
        '
        'colPriority4
        '
        Me.colPriority4.FieldName = "Priority"
        Me.colPriority4.Name = "colPriority4"
        '
        'colLocation4
        '
        Me.colLocation4.FieldName = "Location"
        Me.colLocation4.Name = "colLocation4"
        '
        'colType4
        '
        Me.colType4.FieldName = "Type"
        Me.colType4.Name = "colType4"
        '
        'colDwgRequestBy4
        '
        Me.colDwgRequestBy4.FieldName = "DwgRequestBy"
        Me.colDwgRequestBy4.Name = "colDwgRequestBy4"
        '
        'colDrawingNumber4
        '
        Me.colDrawingNumber4.FieldName = "DrawingNumber"
        Me.colDrawingNumber4.Name = "colDrawingNumber4"
        '
        'colDwgRequestDate4
        '
        Me.colDwgRequestDate4.FieldName = "DwgRequestDate"
        Me.colDwgRequestDate4.Name = "colDwgRequestDate4"
        '
        'colDrawingTitle4
        '
        Me.colDrawingTitle4.FieldName = "DrawingTitle"
        Me.colDrawingTitle4.Name = "colDrawingTitle4"
        '
        'colProgram4
        '
        Me.colProgram4.FieldName = "Program"
        Me.colProgram4.Name = "colProgram4"
        '
        'colDrawingType4
        '
        Me.colDrawingType4.FieldName = "DrawingType"
        Me.colDrawingType4.Name = "colDrawingType4"
        '
        'colSystemDescription4
        '
        Me.colSystemDescription4.FieldName = "SystemDescription"
        Me.colSystemDescription4.Name = "colSystemDescription4"
        '
        'colStatus4
        '
        Me.colStatus4.FieldName = "Status"
        Me.colStatus4.Name = "colStatus4"
        '
        'colLastActionDate4
        '
        Me.colLastActionDate4.FieldName = "LastActionDate"
        Me.colLastActionDate4.Name = "colLastActionDate4"
        '
        'colActualFinishDate4
        '
        Me.colActualFinishDate4.FieldName = "ActualFinishDate"
        Me.colActualFinishDate4.Name = "colActualFinishDate4"
        '
        'colForecastStartDate4
        '
        Me.colForecastStartDate4.FieldName = "ForecastStartDate"
        Me.colForecastStartDate4.Name = "colForecastStartDate4"
        '
        'colForecastFinishDate4
        '
        Me.colForecastFinishDate4.FieldName = "ForecastFinishDate"
        Me.colForecastFinishDate4.Name = "colForecastFinishDate4"
        '
        'colPlannedFinishDate4
        '
        Me.colPlannedFinishDate4.FieldName = "PlannedFinishDate"
        Me.colPlannedFinishDate4.Name = "colPlannedFinishDate4"
        '
        'colEstimatedDurationHours4
        '
        Me.colEstimatedDurationHours4.FieldName = "EstimatedDurationHours"
        Me.colEstimatedDurationHours4.Name = "colEstimatedDurationHours4"
        '
        'colPercentComplete4
        '
        Me.colPercentComplete4.FieldName = "PercentComplete"
        Me.colPercentComplete4.Name = "colPercentComplete4"
        '
        'colDrawingFolderAssignDate4
        '
        Me.colDrawingFolderAssignDate4.FieldName = "DrawingFolderAssignDate"
        Me.colDrawingFolderAssignDate4.Name = "colDrawingFolderAssignDate4"
        '
        'colDesignWIPDate4
        '
        Me.colDesignWIPDate4.FieldName = "DesignWIPDate"
        Me.colDesignWIPDate4.Name = "colDesignWIPDate4"
        '
        'colNotes4
        '
        Me.colNotes4.FieldName = "Notes"
        Me.colNotes4.Name = "colNotes4"
        '
        'colModelTemplateDate4
        '
        Me.colModelTemplateDate4.FieldName = "ModelTemplateDate"
        Me.colModelTemplateDate4.Name = "colModelTemplateDate4"
        '
        'colDrafter4
        '
        Me.colDrafter4.FieldName = "Drafter"
        Me.colDrafter4.Name = "colDrafter4"
        '
        'colDrafterComplete4
        '
        Me.colDrafterComplete4.FieldName = "DrafterComplete"
        Me.colDrafterComplete4.Name = "colDrafterComplete4"
        '
        'colEngineer4
        '
        Me.colEngineer4.FieldName = "Engineer"
        Me.colEngineer4.Name = "colEngineer4"
        '
        'colEngineerComplete4
        '
        Me.colEngineerComplete4.FieldName = "EngineerComplete"
        Me.colEngineerComplete4.Name = "colEngineerComplete4"
        '
        'colSrEngineer4
        '
        Me.colSrEngineer4.FieldName = "SrEngineer"
        Me.colSrEngineer4.Name = "colSrEngineer4"
        '
        'colSrEngineerComplete4
        '
        Me.colSrEngineerComplete4.FieldName = "SrEngineerComplete"
        Me.colSrEngineerComplete4.Name = "colSrEngineerComplete4"
        '
        'colReleaser4
        '
        Me.colReleaser4.FieldName = "Releaser"
        Me.colReleaser4.Name = "colReleaser4"
        '
        'colReleaserCompelte4
        '
        Me.colReleaserCompelte4.FieldName = "ReleaserCompelte"
        Me.colReleaserCompelte4.Name = "colReleaserCompelte4"
        '
        'colFlammability4
        '
        Me.colFlammability4.FieldName = "Flammability"
        Me.colFlammability4.Name = "colFlammability4"
        '
        'colFlammabilityComplete4
        '
        Me.colFlammabilityComplete4.FieldName = "FlammabilityComplete"
        Me.colFlammabilityComplete4.Name = "colFlammabilityComplete4"
        '
        'colStress4
        '
        Me.colStress4.FieldName = "Stress"
        Me.colStress4.Name = "colStress4"
        '
        'colStressComplete4
        '
        Me.colStressComplete4.FieldName = "StressComplete"
        Me.colStressComplete4.Name = "colStressComplete4"
        '
        'colExpr22
        '
        Me.colExpr22.Caption = "Doc Rev"
        Me.colExpr22.FieldName = "Expr2"
        Me.colExpr22.Name = "colExpr22"
        Me.colExpr22.OptionsColumn.ReadOnly = True
        Me.colExpr22.Visible = True
        Me.colExpr22.VisibleIndex = 0
        Me.colExpr22.Width = 54
        '
        'colRefID4
        '
        Me.colRefID4.FieldName = "RefID"
        Me.colRefID4.Name = "colRefID4"
        '
        'colDrafterPlannedCompleteDate4
        '
        Me.colDrafterPlannedCompleteDate4.FieldName = "DrafterPlannedCompleteDate"
        Me.colDrafterPlannedCompleteDate4.Name = "colDrafterPlannedCompleteDate4"
        '
        'colEngineerPlannedCompleteDate4
        '
        Me.colEngineerPlannedCompleteDate4.FieldName = "EngineerPlannedCompleteDate"
        Me.colEngineerPlannedCompleteDate4.Name = "colEngineerPlannedCompleteDate4"
        '
        'colSrEngineerPlannedCompleteDate4
        '
        Me.colSrEngineerPlannedCompleteDate4.FieldName = "SrEngineerPlannedCompleteDate"
        Me.colSrEngineerPlannedCompleteDate4.Name = "colSrEngineerPlannedCompleteDate4"
        '
        'colFlammabilityPlannedCompleteDate4
        '
        Me.colFlammabilityPlannedCompleteDate4.FieldName = "FlammabilityPlannedCompleteDate"
        Me.colFlammabilityPlannedCompleteDate4.Name = "colFlammabilityPlannedCompleteDate4"
        '
        'colStressPlannedCompleteDate4
        '
        Me.colStressPlannedCompleteDate4.FieldName = "StressPlannedCompleteDate"
        Me.colStressPlannedCompleteDate4.Name = "colStressPlannedCompleteDate4"
        '
        'colReleaserPlannedCompleteDate4
        '
        Me.colReleaserPlannedCompleteDate4.FieldName = "ReleaserPlannedCompleteDate"
        Me.colReleaserPlannedCompleteDate4.Name = "colReleaserPlannedCompleteDate4"
        '
        'colAvionics4
        '
        Me.colAvionics4.FieldName = "Avionics"
        Me.colAvionics4.Name = "colAvionics4"
        '
        'colAvionicsComplete4
        '
        Me.colAvionicsComplete4.FieldName = "AvionicsComplete"
        Me.colAvionicsComplete4.Name = "colAvionicsComplete4"
        '
        'colAvionicsPlannedComplete4
        '
        Me.colAvionicsPlannedComplete4.FieldName = "AvionicsPlannedComplete"
        Me.colAvionicsPlannedComplete4.Name = "colAvionicsPlannedComplete4"
        '
        'colMechanical4
        '
        Me.colMechanical4.FieldName = "Mechanical"
        Me.colMechanical4.Name = "colMechanical4"
        '
        'colMechanicalComplete4
        '
        Me.colMechanicalComplete4.FieldName = "MechanicalComplete"
        Me.colMechanicalComplete4.Name = "colMechanicalComplete4"
        '
        'colMechanicalPlannedComplete4
        '
        Me.colMechanicalPlannedComplete4.FieldName = "MechanicalPlannedComplete"
        Me.colMechanicalPlannedComplete4.Name = "colMechanicalPlannedComplete4"
        '
        'colWONumber4
        '
        Me.colWONumber4.FieldName = "WONumber"
        Me.colWONumber4.Name = "colWONumber4"
        '
        'colNextHigherAssembly4
        '
        Me.colNextHigherAssembly4.FieldName = "NextHigherAssembly"
        Me.colNextHigherAssembly4.Name = "colNextHigherAssembly4"
        '
        'colInstallationDrawing4
        '
        Me.colInstallationDrawing4.FieldName = "InstallationDrawing"
        Me.colInstallationDrawing4.Name = "colInstallationDrawing4"
        '
        'colWhiteBoardNumber4
        '
        Me.colWhiteBoardNumber4.FieldName = "WhiteBoardNumber"
        Me.colWhiteBoardNumber4.Name = "colWhiteBoardNumber4"
        '
        'colDRNADCN4
        '
        Me.colDRNADCN4.Caption = "DRN"
        Me.colDRNADCN4.FieldName = "DRNADCN"
        Me.colDRNADCN4.Name = "colDRNADCN4"
        Me.colDRNADCN4.OptionsColumn.ReadOnly = True
        Me.colDRNADCN4.Visible = True
        Me.colDRNADCN4.VisibleIndex = 1
        Me.colDRNADCN4.Width = 60
        '
        'colFAAProjectNo4
        '
        Me.colFAAProjectNo4.FieldName = "FAAProjectNo"
        Me.colFAAProjectNo4.Name = "colFAAProjectNo4"
        '
        'colPSCPDocsRequired4
        '
        Me.colPSCPDocsRequired4.FieldName = "PSCPDocsRequired"
        Me.colPSCPDocsRequired4.Name = "colPSCPDocsRequired4"
        '
        'colCompanyFlightTestRequired4
        '
        Me.colCompanyFlightTestRequired4.FieldName = "CompanyFlightTestRequired"
        Me.colCompanyFlightTestRequired4.Name = "colCompanyFlightTestRequired4"
        '
        'colDwgReqDate4
        '
        Me.colDwgReqDate4.FieldName = "DwgReqDate"
        Me.colDwgReqDate4.Name = "colDwgReqDate4"
        '
        'colNewRework4
        '
        Me.colNewRework4.FieldName = "NewRework"
        Me.colNewRework4.Name = "colNewRework4"
        '
        'colUpdated4
        '
        Me.colUpdated4.FieldName = "Updated"
        Me.colUpdated4.Name = "colUpdated4"
        '
        'colUpdatedDate4
        '
        Me.colUpdatedDate4.FieldName = "UpdatedDate"
        Me.colUpdatedDate4.Name = "colUpdatedDate4"
        '
        'colDwgRevision4
        '
        Me.colDwgRevision4.FieldName = "DwgRevision"
        Me.colDwgRevision4.Name = "colDwgRevision4"
        '
        'colSeq2
        '
        Me.colSeq2.FieldName = "Seq"
        Me.colSeq2.Name = "colSeq2"
        '
        'colADCN
        '
        Me.colADCN.Caption = "ADCN"
        Me.colADCN.FieldName = "ADCN"
        Me.colADCN.Name = "colADCN"
        Me.colADCN.OptionsColumn.ReadOnly = True
        Me.colADCN.Visible = True
        Me.colADCN.VisibleIndex = 2
        Me.colADCN.Width = 57
        '
        'colStatusCol
        '
        Me.colStatusCol.FieldName = "Status"
        Me.colStatusCol.Name = "colStatusCol"
        Me.colStatusCol.Visible = True
        Me.colStatusCol.VisibleIndex = 3
        Me.colStatusCol.Width = 96
        '
        'colDRNADCNStatus
        '
        Me.colDRNADCNStatus.FieldName = "DRNADCNStatus"
        Me.colDRNADCNStatus.Name = "colDRNADCNStatus"
        Me.colDRNADCNStatus.Visible = True
        Me.colDRNADCNStatus.VisibleIndex = 4
        Me.colDRNADCNStatus.Width = 108
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "IncorporatedRev"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 94
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "ActualFinishDate"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 99
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "Drafter"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 90
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Drafter Complete Date"
        Me.GridColumn9.FieldName = "DrafterComplete"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 106
        '
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "SrEngineer"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        Me.GridColumn10.Width = 85
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Sr Engineer Complete Dt"
        Me.GridColumn11.FieldName = "SrEngineerComplete"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        Me.GridColumn11.Width = 120
        '
        'GridColumn12
        '
        Me.GridColumn12.FieldName = "Stress"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        Me.GridColumn12.Width = 94
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Stress Complete Dt"
        Me.GridColumn13.FieldName = "StressComplete"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 12
        Me.GridColumn13.Width = 94
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Operations"
        Me.GridColumn14.FieldName = "Engineer"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 13
        Me.GridColumn14.Width = 86
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Operations Complete Dt"
        Me.GridColumn15.FieldName = "EngineerComplete"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 14
        Me.GridColumn15.Width = 109
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Releaser Complete Dt"
        Me.GridColumn16.FieldName = "ReleaserCompelte"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 15
        Me.GridColumn16.Width = 66
        '
        'colIncorporatedBy
        '
        Me.colIncorporatedBy.Caption = "Incorporated By"
        Me.colIncorporatedBy.FieldName = "DRNADCNIncorporatedBy"
        Me.colIncorporatedBy.Name = "colIncorporatedBy"
        Me.colIncorporatedBy.Visible = True
        Me.colIncorporatedBy.VisibleIndex = 16
        Me.colIncorporatedBy.Width = 162
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GridControl13)
        Me.TabPage2.Controls.Add(Me.btnSaveIncorporatedRev)
        Me.TabPage2.Controls.Add(Me.txtRedlineFileName)
        Me.TabPage2.Controls.Add(Me.lblRedlineFilename)
        Me.TabPage2.Controls.Add(Me.btnDesignSignOff)
        Me.TabPage2.Controls.Add(Me.btnPlannerSignOff)
        Me.TabPage2.Controls.Add(Me.btnLiaisonSignOff)
        Me.TabPage2.Controls.Add(Me.btnDeleteRedline)
        Me.TabPage2.Controls.Add(Me.btnAddRedline)
        Me.TabPage2.Controls.Add(Me.txtRedlineRecordID)
        Me.TabPage2.Controls.Add(Me.cboRedlineStatus)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1502, 388)
        Me.TabPage2.TabIndex = 8
        Me.TabPage2.Text = "Redlines"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GridControl13
        '
        Me.GridControl13.DataSource = Me.bsRedlines
        Me.GridControl13.Location = New System.Drawing.Point(3, 52)
        Me.GridControl13.MainView = Me.GridView13
        Me.GridControl13.Name = "GridControl13"
        Me.GridControl13.Size = New System.Drawing.Size(1396, 333)
        Me.GridControl13.TabIndex = 21
        Me.GridControl13.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView13})
        '
        'bsRedlines
        '
        Me.bsRedlines.DataMember = "tblRedlines"
        Me.bsRedlines.DataSource = Me.DsRedlines1
        '
        'DsRedlines1
        '
        Me.DsRedlines1.DataSetName = "dsRedlines"
        Me.DsRedlines1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView13
        '
        Me.GridView13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID8, Me.colDrawingNum, Me.colRev, Me.colStatus7, Me.colRequestBy, Me.colRedlineDate, Me.colIndexNum, Me.colIncorporatedRev, Me.colFileName2, Me.colRedlineNumber, Me.colRedlineCount, Me.colLiaisonSignedOffBy, Me.colLiaisonSignedOffDate, Me.colOperationsSignedOffBy, Me.colOperationsSignedOffDate, Me.colDesignEngSignedOffBy, Me.colDesignEngSignedOffDate})
        Me.GridView13.GridControl = Me.GridControl13
        Me.GridView13.LevelIndent = 0
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsView.ShowGroupPanel = False
        Me.GridView13.PreviewIndent = 0
        '
        'colRecordID8
        '
        Me.colRecordID8.FieldName = "RecordID"
        Me.colRecordID8.Name = "colRecordID8"
        '
        'colDrawingNum
        '
        Me.colDrawingNum.FieldName = "DrawingNum"
        Me.colDrawingNum.Name = "colDrawingNum"
        '
        'colRev
        '
        Me.colRev.FieldName = "Rev"
        Me.colRev.Name = "colRev"
        '
        'colStatus7
        '
        Me.colStatus7.FieldName = "Status"
        Me.colStatus7.Name = "colStatus7"
        Me.colStatus7.OptionsColumn.ReadOnly = True
        Me.colStatus7.Visible = True
        Me.colStatus7.VisibleIndex = 1
        Me.colStatus7.Width = 109
        '
        'colRequestBy
        '
        Me.colRequestBy.FieldName = "RequestBy"
        Me.colRequestBy.Name = "colRequestBy"
        Me.colRequestBy.OptionsColumn.ReadOnly = True
        Me.colRequestBy.Visible = True
        Me.colRequestBy.VisibleIndex = 2
        Me.colRequestBy.Width = 109
        '
        'colRedlineDate
        '
        Me.colRedlineDate.FieldName = "RedlineDate"
        Me.colRedlineDate.Name = "colRedlineDate"
        Me.colRedlineDate.OptionsColumn.ReadOnly = True
        Me.colRedlineDate.Visible = True
        Me.colRedlineDate.VisibleIndex = 3
        Me.colRedlineDate.Width = 106
        '
        'colIndexNum
        '
        Me.colIndexNum.FieldName = "IndexNum"
        Me.colIndexNum.Name = "colIndexNum"
        '
        'colIncorporatedRev
        '
        Me.colIncorporatedRev.FieldName = "IncorporatedRev"
        Me.colIncorporatedRev.Name = "colIncorporatedRev"
        Me.colIncorporatedRev.OptionsColumn.ReadOnly = True
        Me.colIncorporatedRev.Visible = True
        Me.colIncorporatedRev.VisibleIndex = 4
        Me.colIncorporatedRev.Width = 106
        '
        'colFileName2
        '
        Me.colFileName2.FieldName = "FileName"
        Me.colFileName2.Name = "colFileName2"
        Me.colFileName2.OptionsColumn.ReadOnly = True
        Me.colFileName2.Visible = True
        Me.colFileName2.VisibleIndex = 5
        Me.colFileName2.Width = 121
        '
        'colRedlineNumber
        '
        Me.colRedlineNumber.FieldName = "RedlineNumber"
        Me.colRedlineNumber.Name = "colRedlineNumber"
        Me.colRedlineNumber.OptionsColumn.ReadOnly = True
        Me.colRedlineNumber.Visible = True
        Me.colRedlineNumber.VisibleIndex = 0
        Me.colRedlineNumber.Width = 93
        '
        'colRedlineCount
        '
        Me.colRedlineCount.FieldName = "RedlineCount"
        Me.colRedlineCount.Name = "colRedlineCount"
        '
        'colLiaisonSignedOffBy
        '
        Me.colLiaisonSignedOffBy.FieldName = "LiaisonSignedOffBy"
        Me.colLiaisonSignedOffBy.Name = "colLiaisonSignedOffBy"
        Me.colLiaisonSignedOffBy.OptionsColumn.ReadOnly = True
        Me.colLiaisonSignedOffBy.Visible = True
        Me.colLiaisonSignedOffBy.VisibleIndex = 6
        Me.colLiaisonSignedOffBy.Width = 130
        '
        'colLiaisonSignedOffDate
        '
        Me.colLiaisonSignedOffDate.FieldName = "LiaisonSignedOffDate"
        Me.colLiaisonSignedOffDate.Name = "colLiaisonSignedOffDate"
        Me.colLiaisonSignedOffDate.OptionsColumn.ReadOnly = True
        Me.colLiaisonSignedOffDate.Visible = True
        Me.colLiaisonSignedOffDate.VisibleIndex = 7
        Me.colLiaisonSignedOffDate.Width = 119
        '
        'colOperationsSignedOffBy
        '
        Me.colOperationsSignedOffBy.FieldName = "OperationsSignedOffBy"
        Me.colOperationsSignedOffBy.Name = "colOperationsSignedOffBy"
        Me.colOperationsSignedOffBy.OptionsColumn.ReadOnly = True
        Me.colOperationsSignedOffBy.Visible = True
        Me.colOperationsSignedOffBy.VisibleIndex = 8
        Me.colOperationsSignedOffBy.Width = 124
        '
        'colOperationsSignedOffDate
        '
        Me.colOperationsSignedOffDate.FieldName = "OperationsSignedOffDate"
        Me.colOperationsSignedOffDate.Name = "colOperationsSignedOffDate"
        Me.colOperationsSignedOffDate.OptionsColumn.ReadOnly = True
        Me.colOperationsSignedOffDate.Visible = True
        Me.colOperationsSignedOffDate.VisibleIndex = 9
        Me.colOperationsSignedOffDate.Width = 115
        '
        'colDesignEngSignedOffBy
        '
        Me.colDesignEngSignedOffBy.FieldName = "DesignEngSignedOffBy"
        Me.colDesignEngSignedOffBy.Name = "colDesignEngSignedOffBy"
        Me.colDesignEngSignedOffBy.OptionsColumn.ReadOnly = True
        Me.colDesignEngSignedOffBy.Visible = True
        Me.colDesignEngSignedOffBy.VisibleIndex = 10
        Me.colDesignEngSignedOffBy.Width = 116
        '
        'colDesignEngSignedOffDate
        '
        Me.colDesignEngSignedOffDate.FieldName = "DesignEngSignedOffDate"
        Me.colDesignEngSignedOffDate.Name = "colDesignEngSignedOffDate"
        Me.colDesignEngSignedOffDate.OptionsColumn.ReadOnly = True
        Me.colDesignEngSignedOffDate.Visible = True
        Me.colDesignEngSignedOffDate.VisibleIndex = 11
        Me.colDesignEngSignedOffDate.Width = 130
        '
        'btnSaveIncorporatedRev
        '
        Me.btnSaveIncorporatedRev.Location = New System.Drawing.Point(1158, 8)
        Me.btnSaveIncorporatedRev.Name = "btnSaveIncorporatedRev"
        Me.btnSaveIncorporatedRev.Size = New System.Drawing.Size(272, 30)
        Me.btnSaveIncorporatedRev.TabIndex = 20
        Me.btnSaveIncorporatedRev.Text = "Save IncorporatedRev, Status"
        Me.btnSaveIncorporatedRev.UseVisualStyleBackColor = True
        '
        'txtRedlineFileName
        '
        Me.txtRedlineFileName.Location = New System.Drawing.Point(319, 23)
        Me.txtRedlineFileName.Name = "txtRedlineFileName"
        Me.txtRedlineFileName.ReadOnly = True
        Me.txtRedlineFileName.Size = New System.Drawing.Size(302, 20)
        Me.txtRedlineFileName.TabIndex = 19
        '
        'lblRedlineFilename
        '
        Me.lblRedlineFilename.AutoSize = True
        Me.lblRedlineFilename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRedlineFilename.Location = New System.Drawing.Point(243, 23)
        Me.lblRedlineFilename.Name = "lblRedlineFilename"
        Me.lblRedlineFilename.Size = New System.Drawing.Size(69, 15)
        Me.lblRedlineFilename.TabIndex = 18
        Me.lblRedlineFilename.Text = "FileName"
        '
        'btnDesignSignOff
        '
        Me.btnDesignSignOff.Location = New System.Drawing.Point(922, 3)
        Me.btnDesignSignOff.Name = "btnDesignSignOff"
        Me.btnDesignSignOff.Size = New System.Drawing.Size(128, 48)
        Me.btnDesignSignOff.TabIndex = 17
        Me.btnDesignSignOff.Text = "Incorporated Redlines (Design Sign Off)"
        Me.btnDesignSignOff.UseVisualStyleBackColor = True
        '
        'btnPlannerSignOff
        '
        Me.btnPlannerSignOff.Location = New System.Drawing.Point(756, 2)
        Me.btnPlannerSignOff.Name = "btnPlannerSignOff"
        Me.btnPlannerSignOff.Size = New System.Drawing.Size(160, 48)
        Me.btnPlannerSignOff.TabIndex = 16
        Me.btnPlannerSignOff.Text = "Ready for Engineering Change (Operations Sign Off)"
        Me.btnPlannerSignOff.UseVisualStyleBackColor = True
        '
        'btnLiaisonSignOff
        '
        Me.btnLiaisonSignOff.Location = New System.Drawing.Point(648, 2)
        Me.btnLiaisonSignOff.Name = "btnLiaisonSignOff"
        Me.btnLiaisonSignOff.Size = New System.Drawing.Size(102, 48)
        Me.btnLiaisonSignOff.TabIndex = 15
        Me.btnLiaisonSignOff.Text = "Redline Released (Liaison Sign Off) "
        Me.btnLiaisonSignOff.UseVisualStyleBackColor = True
        '
        'btnDeleteRedline
        '
        Me.btnDeleteRedline.Location = New System.Drawing.Point(111, 13)
        Me.btnDeleteRedline.Name = "btnDeleteRedline"
        Me.btnDeleteRedline.Size = New System.Drawing.Size(102, 33)
        Me.btnDeleteRedline.TabIndex = 14
        Me.btnDeleteRedline.Text = "Delete Redline"
        Me.btnDeleteRedline.UseVisualStyleBackColor = True
        '
        'btnAddRedline
        '
        Me.btnAddRedline.Location = New System.Drawing.Point(3, 13)
        Me.btnAddRedline.Name = "btnAddRedline"
        Me.btnAddRedline.Size = New System.Drawing.Size(102, 33)
        Me.btnAddRedline.TabIndex = 13
        Me.btnAddRedline.Text = "Add Redline"
        Me.btnAddRedline.UseVisualStyleBackColor = True
        '
        'txtRedlineRecordID
        '
        Me.txtRedlineRecordID.Location = New System.Drawing.Point(358, 198)
        Me.txtRedlineRecordID.Name = "txtRedlineRecordID"
        Me.txtRedlineRecordID.Size = New System.Drawing.Size(100, 20)
        Me.txtRedlineRecordID.TabIndex = 22
        '
        'cboRedlineStatus
        '
        Me.cboRedlineStatus.Location = New System.Drawing.Point(99, 198)
        Me.cboRedlineStatus.Name = "cboRedlineStatus"
        Me.cboRedlineStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRedlineStatus.Size = New System.Drawing.Size(100, 20)
        Me.cboRedlineStatus.TabIndex = 24
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.cboPercentComplete)
        Me.TabPage7.Controls.Add(Me.cboSchedMilestone)
        Me.TabPage7.Controls.Add(Me.cboSchedWhiteBoard)
        Me.TabPage7.Controls.Add(Me.cboSchedPercComp)
        Me.TabPage7.Controls.Add(Me.txtSchedWorkOrder)
        Me.TabPage7.Controls.Add(Me.btnPercCompleteHelp)
        Me.TabPage7.Controls.Add(Me.Label29)
        Me.TabPage7.Controls.Add(Me.mskSchedDuration)
        Me.TabPage7.Controls.Add(Me.dtSchedForecastFinish)
        Me.TabPage7.Controls.Add(Me.dtSchedForecastStart)
        Me.TabPage7.Controls.Add(Me.Label26)
        Me.TabPage7.Controls.Add(Me.Label25)
        Me.TabPage7.Controls.Add(Me.GridControl6)
        Me.TabPage7.Controls.Add(Me.Label24)
        Me.TabPage7.Controls.Add(Me.Label23)
        Me.TabPage7.Controls.Add(Me.Label22)
        Me.TabPage7.Controls.Add(Me.Label21)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1502, 388)
        Me.TabPage7.TabIndex = 4
        Me.TabPage7.Text = "Schedule"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'cboPercentComplete
        '
        Me.cboPercentComplete.FormattingEnabled = True
        Me.cboPercentComplete.Items.AddRange(New Object() {"0", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95", "100"})
        Me.cboPercentComplete.Location = New System.Drawing.Point(772, 258)
        Me.cboPercentComplete.Name = "cboPercentComplete"
        Me.cboPercentComplete.Size = New System.Drawing.Size(62, 21)
        Me.cboPercentComplete.TabIndex = 45
        '
        'cboSchedMilestone
        '
        Me.cboSchedMilestone.Location = New System.Drawing.Point(44, 322)
        Me.cboSchedMilestone.Name = "cboSchedMilestone"
        Me.cboSchedMilestone.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSchedMilestone.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSchedMilestone.Size = New System.Drawing.Size(200, 20)
        Me.cboSchedMilestone.TabIndex = 44
        '
        'cboSchedWhiteBoard
        '
        Me.cboSchedWhiteBoard.Location = New System.Drawing.Point(262, 322)
        Me.cboSchedWhiteBoard.Name = "cboSchedWhiteBoard"
        Me.cboSchedWhiteBoard.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSchedWhiteBoard.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSchedWhiteBoard.Size = New System.Drawing.Size(218, 20)
        Me.cboSchedWhiteBoard.TabIndex = 43
        '
        'cboSchedPercComp
        '
        Me.cboSchedPercComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSchedPercComp.Location = New System.Drawing.Point(772, 322)
        Me.cboSchedPercComp.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSchedPercComp.Mask = "###"
        Me.cboSchedPercComp.Name = "cboSchedPercComp"
        Me.cboSchedPercComp.Size = New System.Drawing.Size(62, 20)
        Me.cboSchedPercComp.TabIndex = 42
        Me.cboSchedPercComp.Visible = False
        '
        'txtSchedWorkOrder
        '
        Me.txtSchedWorkOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchedWorkOrder.Location = New System.Drawing.Point(44, 193)
        Me.txtSchedWorkOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSchedWorkOrder.Mask = "############"
        Me.txtSchedWorkOrder.Name = "txtSchedWorkOrder"
        Me.txtSchedWorkOrder.Size = New System.Drawing.Size(119, 20)
        Me.txtSchedWorkOrder.TabIndex = 41
        '
        'btnPercCompleteHelp
        '
        Me.btnPercCompleteHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPercCompleteHelp.Image = CType(resources.GetObject("btnPercCompleteHelp.Image"), System.Drawing.Image)
        Me.btnPercCompleteHelp.Location = New System.Drawing.Point(862, 245)
        Me.btnPercCompleteHelp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPercCompleteHelp.Name = "btnPercCompleteHelp"
        Me.btnPercCompleteHelp.Size = New System.Drawing.Size(45, 37)
        Me.btnPercCompleteHelp.TabIndex = 40
        Me.btnPercCompleteHelp.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(260, 301)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(106, 13)
        Me.Label29.TabIndex = 38
        Me.Label29.Text = "White Board Number"
        '
        'mskSchedDuration
        '
        Me.mskSchedDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskSchedDuration.Location = New System.Drawing.Point(556, 262)
        Me.mskSchedDuration.Mask = "####"
        Me.mskSchedDuration.Name = "mskSchedDuration"
        Me.mskSchedDuration.Size = New System.Drawing.Size(100, 20)
        Me.mskSchedDuration.TabIndex = 35
        '
        'dtSchedForecastFinish
        '
        Me.dtSchedForecastFinish.CustomFormat = "MM/dd/yyyy"
        Me.dtSchedForecastFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtSchedForecastFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSchedForecastFinish.Location = New System.Drawing.Point(262, 260)
        Me.dtSchedForecastFinish.Name = "dtSchedForecastFinish"
        Me.dtSchedForecastFinish.Size = New System.Drawing.Size(200, 20)
        Me.dtSchedForecastFinish.TabIndex = 34
        '
        'dtSchedForecastStart
        '
        Me.dtSchedForecastStart.CustomFormat = "MM/dd/yyyy"
        Me.dtSchedForecastStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtSchedForecastStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSchedForecastStart.Location = New System.Drawing.Point(45, 262)
        Me.dtSchedForecastStart.Name = "dtSchedForecastStart"
        Me.dtSchedForecastStart.Size = New System.Drawing.Size(200, 20)
        Me.dtSchedForecastStart.TabIndex = 33
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(41, 301)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 13)
        Me.Label26.TabIndex = 32
        Me.Label26.Text = "Milestone"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(41, 172)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 13)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "Work Order"
        '
        'GridControl6
        '
        Me.GridControl6.DataSource = Me.bsMainInformationTab
        Me.GridControl6.Location = New System.Drawing.Point(3, 6)
        Me.GridControl6.MainView = Me.GridView6
        Me.GridControl6.Name = "GridControl6"
        Me.GridControl6.Size = New System.Drawing.Size(1394, 160)
        Me.GridControl6.TabIndex = 25
        Me.GridControl6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colExpr23, Me.colWONumber5, Me.colPlannedFinishDate5, Me.colForecastStartDate5, Me.colForecastFinishDate5, Me.colEstimatedDurationHours5, Me.colPercentComplete5, Me.colPriority5, Me.colWhiteBoardNumber5, Me.colRecordID5, Me.colDocumentType5, Me.colLocation5, Me.colType5, Me.colDwgRequestBy5, Me.colDrawingNumber5, Me.colDwgRequestDate5, Me.colDrawingTitle5, Me.colProgram5, Me.colDrawingType5, Me.colSystemDescription5, Me.colStatus5, Me.colLastActionDate5, Me.colActualFinishDate5, Me.colDrawingFolderAssignDate5, Me.colDesignWIPDate5, Me.colNotes5, Me.colModelTemplateDate5, Me.colDrafter5, Me.colDrafterComplete5, Me.colEngineer5, Me.colEngineerComplete5, Me.colSrEngineer5, Me.colSrEngineerComplete5, Me.colReleaser5, Me.colReleaserCompelte5, Me.colFlammability5, Me.colFlammabilityComplete5, Me.colStress5, Me.colStressComplete5, Me.colRefID5, Me.colDrafterPlannedCompleteDate5, Me.colEngineerPlannedCompleteDate5, Me.colSrEngineerPlannedCompleteDate5, Me.colFlammabilityPlannedCompleteDate5, Me.colStressPlannedCompleteDate5, Me.colReleaserPlannedCompleteDate5, Me.colAvionics5, Me.colAvionicsComplete5, Me.colADCN4, Me.colAvionicsPlannedComplete5, Me.colMechanical5, Me.colMechanicalComplete5, Me.colMechanicalPlannedComplete5, Me.colNextHigherAssembly5, Me.colInstallationDrawing5, Me.colDRNADCN5, Me.colFAAProjectNo5, Me.colPSCPDocsRequired5, Me.colCompanyFlightTestRequired5, Me.colDwgReqDate5, Me.colNewRework5, Me.colUpdated5, Me.colUpdatedDate5, Me.colDwgRevision5, Me.colSeq3, Me.colDRNSchedule})
        Me.GridView6.DetailHeight = 349
        Me.GridView6.GridControl = Me.GridControl6
        Me.GridView6.LevelIndent = 0
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsCustomization.AllowFilter = False
        Me.GridView6.OptionsCustomization.AllowSort = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.PreviewIndent = 0
        '
        'colExpr23
        '
        Me.colExpr23.Caption = "Doc Rev"
        Me.colExpr23.FieldName = "DwgRevision"
        Me.colExpr23.Name = "colExpr23"
        Me.colExpr23.OptionsColumn.ReadOnly = True
        Me.colExpr23.Visible = True
        Me.colExpr23.VisibleIndex = 0
        Me.colExpr23.Width = 51
        '
        'colWONumber5
        '
        Me.colWONumber5.FieldName = "WONumber"
        Me.colWONumber5.Name = "colWONumber5"
        Me.colWONumber5.OptionsColumn.ReadOnly = True
        Me.colWONumber5.Visible = True
        Me.colWONumber5.VisibleIndex = 3
        Me.colWONumber5.Width = 127
        '
        'colPlannedFinishDate5
        '
        Me.colPlannedFinishDate5.Caption = "Baseline Finish Date"
        Me.colPlannedFinishDate5.FieldName = "PlannedFinishDate"
        Me.colPlannedFinishDate5.Name = "colPlannedFinishDate5"
        Me.colPlannedFinishDate5.OptionsColumn.ReadOnly = True
        Me.colPlannedFinishDate5.Visible = True
        Me.colPlannedFinishDate5.VisibleIndex = 4
        Me.colPlannedFinishDate5.Width = 106
        '
        'colForecastStartDate5
        '
        Me.colForecastStartDate5.FieldName = "ForecastStartDate"
        Me.colForecastStartDate5.Name = "colForecastStartDate5"
        Me.colForecastStartDate5.OptionsColumn.ReadOnly = True
        Me.colForecastStartDate5.Visible = True
        Me.colForecastStartDate5.VisibleIndex = 5
        Me.colForecastStartDate5.Width = 110
        '
        'colForecastFinishDate5
        '
        Me.colForecastFinishDate5.FieldName = "ForecastFinishDate"
        Me.colForecastFinishDate5.Name = "colForecastFinishDate5"
        Me.colForecastFinishDate5.OptionsColumn.ReadOnly = True
        Me.colForecastFinishDate5.Visible = True
        Me.colForecastFinishDate5.VisibleIndex = 6
        Me.colForecastFinishDate5.Width = 110
        '
        'colEstimatedDurationHours5
        '
        Me.colEstimatedDurationHours5.FieldName = "EstimatedDurationHours"
        Me.colEstimatedDurationHours5.Name = "colEstimatedDurationHours5"
        Me.colEstimatedDurationHours5.OptionsColumn.ReadOnly = True
        Me.colEstimatedDurationHours5.Visible = True
        Me.colEstimatedDurationHours5.VisibleIndex = 8
        Me.colEstimatedDurationHours5.Width = 138
        '
        'colPercentComplete5
        '
        Me.colPercentComplete5.AppearanceCell.Options.UseTextOptions = True
        Me.colPercentComplete5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPercentComplete5.FieldName = "PercentComplete"
        Me.colPercentComplete5.Name = "colPercentComplete5"
        Me.colPercentComplete5.OptionsColumn.ReadOnly = True
        Me.colPercentComplete5.Visible = True
        Me.colPercentComplete5.VisibleIndex = 9
        Me.colPercentComplete5.Width = 138
        '
        'colPriority5
        '
        Me.colPriority5.Caption = "Milestone"
        Me.colPriority5.FieldName = "Priority"
        Me.colPriority5.Name = "colPriority5"
        Me.colPriority5.OptionsColumn.ReadOnly = True
        Me.colPriority5.Visible = True
        Me.colPriority5.VisibleIndex = 7
        Me.colPriority5.Width = 138
        '
        'colWhiteBoardNumber5
        '
        Me.colWhiteBoardNumber5.FieldName = "WhiteBoardNumber"
        Me.colWhiteBoardNumber5.Name = "colWhiteBoardNumber5"
        Me.colWhiteBoardNumber5.OptionsColumn.ReadOnly = True
        Me.colWhiteBoardNumber5.Visible = True
        Me.colWhiteBoardNumber5.VisibleIndex = 10
        Me.colWhiteBoardNumber5.Width = 180
        '
        'colRecordID5
        '
        Me.colRecordID5.FieldName = "RecordID"
        Me.colRecordID5.Name = "colRecordID5"
        '
        'colDocumentType5
        '
        Me.colDocumentType5.FieldName = "DocumentType"
        Me.colDocumentType5.Name = "colDocumentType5"
        '
        'colLocation5
        '
        Me.colLocation5.FieldName = "Location"
        Me.colLocation5.Name = "colLocation5"
        '
        'colType5
        '
        Me.colType5.FieldName = "Type"
        Me.colType5.Name = "colType5"
        '
        'colDwgRequestBy5
        '
        Me.colDwgRequestBy5.FieldName = "DwgRequestBy"
        Me.colDwgRequestBy5.Name = "colDwgRequestBy5"
        '
        'colDrawingNumber5
        '
        Me.colDrawingNumber5.FieldName = "DrawingNumber"
        Me.colDrawingNumber5.Name = "colDrawingNumber5"
        '
        'colDwgRequestDate5
        '
        Me.colDwgRequestDate5.FieldName = "DwgRequestDate"
        Me.colDwgRequestDate5.Name = "colDwgRequestDate5"
        '
        'colDrawingTitle5
        '
        Me.colDrawingTitle5.FieldName = "DrawingTitle"
        Me.colDrawingTitle5.Name = "colDrawingTitle5"
        '
        'colProgram5
        '
        Me.colProgram5.FieldName = "Program"
        Me.colProgram5.Name = "colProgram5"
        '
        'colDrawingType5
        '
        Me.colDrawingType5.FieldName = "DrawingType"
        Me.colDrawingType5.Name = "colDrawingType5"
        '
        'colSystemDescription5
        '
        Me.colSystemDescription5.FieldName = "SystemDescription"
        Me.colSystemDescription5.Name = "colSystemDescription5"
        '
        'colStatus5
        '
        Me.colStatus5.FieldName = "Status"
        Me.colStatus5.Name = "colStatus5"
        '
        'colLastActionDate5
        '
        Me.colLastActionDate5.FieldName = "LastActionDate"
        Me.colLastActionDate5.Name = "colLastActionDate5"
        '
        'colActualFinishDate5
        '
        Me.colActualFinishDate5.FieldName = "ActualFinishDate"
        Me.colActualFinishDate5.Name = "colActualFinishDate5"
        '
        'colDrawingFolderAssignDate5
        '
        Me.colDrawingFolderAssignDate5.FieldName = "DrawingFolderAssignDate"
        Me.colDrawingFolderAssignDate5.Name = "colDrawingFolderAssignDate5"
        '
        'colDesignWIPDate5
        '
        Me.colDesignWIPDate5.FieldName = "DesignWIPDate"
        Me.colDesignWIPDate5.Name = "colDesignWIPDate5"
        '
        'colNotes5
        '
        Me.colNotes5.FieldName = "Notes"
        Me.colNotes5.Name = "colNotes5"
        '
        'colModelTemplateDate5
        '
        Me.colModelTemplateDate5.FieldName = "ModelTemplateDate"
        Me.colModelTemplateDate5.Name = "colModelTemplateDate5"
        '
        'colDrafter5
        '
        Me.colDrafter5.FieldName = "Drafter"
        Me.colDrafter5.Name = "colDrafter5"
        '
        'colDrafterComplete5
        '
        Me.colDrafterComplete5.FieldName = "DrafterComplete"
        Me.colDrafterComplete5.Name = "colDrafterComplete5"
        '
        'colEngineer5
        '
        Me.colEngineer5.FieldName = "Engineer"
        Me.colEngineer5.Name = "colEngineer5"
        '
        'colEngineerComplete5
        '
        Me.colEngineerComplete5.FieldName = "EngineerComplete"
        Me.colEngineerComplete5.Name = "colEngineerComplete5"
        '
        'colSrEngineer5
        '
        Me.colSrEngineer5.FieldName = "SrEngineer"
        Me.colSrEngineer5.Name = "colSrEngineer5"
        '
        'colSrEngineerComplete5
        '
        Me.colSrEngineerComplete5.FieldName = "SrEngineerComplete"
        Me.colSrEngineerComplete5.Name = "colSrEngineerComplete5"
        '
        'colReleaser5
        '
        Me.colReleaser5.FieldName = "Releaser"
        Me.colReleaser5.Name = "colReleaser5"
        '
        'colReleaserCompelte5
        '
        Me.colReleaserCompelte5.FieldName = "ReleaserCompelte"
        Me.colReleaserCompelte5.Name = "colReleaserCompelte5"
        '
        'colFlammability5
        '
        Me.colFlammability5.FieldName = "Flammability"
        Me.colFlammability5.Name = "colFlammability5"
        '
        'colFlammabilityComplete5
        '
        Me.colFlammabilityComplete5.FieldName = "FlammabilityComplete"
        Me.colFlammabilityComplete5.Name = "colFlammabilityComplete5"
        '
        'colStress5
        '
        Me.colStress5.FieldName = "Stress"
        Me.colStress5.Name = "colStress5"
        '
        'colStressComplete5
        '
        Me.colStressComplete5.FieldName = "StressComplete"
        Me.colStressComplete5.Name = "colStressComplete5"
        '
        'colRefID5
        '
        Me.colRefID5.FieldName = "RefID"
        Me.colRefID5.Name = "colRefID5"
        '
        'colDrafterPlannedCompleteDate5
        '
        Me.colDrafterPlannedCompleteDate5.FieldName = "DrafterPlannedCompleteDate"
        Me.colDrafterPlannedCompleteDate5.Name = "colDrafterPlannedCompleteDate5"
        '
        'colEngineerPlannedCompleteDate5
        '
        Me.colEngineerPlannedCompleteDate5.FieldName = "EngineerPlannedCompleteDate"
        Me.colEngineerPlannedCompleteDate5.Name = "colEngineerPlannedCompleteDate5"
        '
        'colSrEngineerPlannedCompleteDate5
        '
        Me.colSrEngineerPlannedCompleteDate5.FieldName = "SrEngineerPlannedCompleteDate"
        Me.colSrEngineerPlannedCompleteDate5.Name = "colSrEngineerPlannedCompleteDate5"
        '
        'colFlammabilityPlannedCompleteDate5
        '
        Me.colFlammabilityPlannedCompleteDate5.FieldName = "FlammabilityPlannedCompleteDate"
        Me.colFlammabilityPlannedCompleteDate5.Name = "colFlammabilityPlannedCompleteDate5"
        '
        'colStressPlannedCompleteDate5
        '
        Me.colStressPlannedCompleteDate5.FieldName = "StressPlannedCompleteDate"
        Me.colStressPlannedCompleteDate5.Name = "colStressPlannedCompleteDate5"
        '
        'colReleaserPlannedCompleteDate5
        '
        Me.colReleaserPlannedCompleteDate5.FieldName = "ReleaserPlannedCompleteDate"
        Me.colReleaserPlannedCompleteDate5.Name = "colReleaserPlannedCompleteDate5"
        '
        'colAvionics5
        '
        Me.colAvionics5.FieldName = "Avionics"
        Me.colAvionics5.Name = "colAvionics5"
        '
        'colAvionicsComplete5
        '
        Me.colAvionicsComplete5.FieldName = "AvionicsComplete"
        Me.colAvionicsComplete5.Name = "colAvionicsComplete5"
        '
        'colADCN4
        '
        Me.colADCN4.FieldName = "ADCN"
        Me.colADCN4.Name = "colADCN4"
        Me.colADCN4.Visible = True
        Me.colADCN4.VisibleIndex = 2
        Me.colADCN4.Width = 135
        '
        'colAvionicsPlannedComplete5
        '
        Me.colAvionicsPlannedComplete5.FieldName = "AvionicsPlannedComplete"
        Me.colAvionicsPlannedComplete5.Name = "colAvionicsPlannedComplete5"
        '
        'colMechanical5
        '
        Me.colMechanical5.FieldName = "Mechanical"
        Me.colMechanical5.Name = "colMechanical5"
        '
        'colMechanicalComplete5
        '
        Me.colMechanicalComplete5.FieldName = "MechanicalComplete"
        Me.colMechanicalComplete5.Name = "colMechanicalComplete5"
        '
        'colMechanicalPlannedComplete5
        '
        Me.colMechanicalPlannedComplete5.FieldName = "MechanicalPlannedComplete"
        Me.colMechanicalPlannedComplete5.Name = "colMechanicalPlannedComplete5"
        '
        'colNextHigherAssembly5
        '
        Me.colNextHigherAssembly5.FieldName = "NextHigherAssembly"
        Me.colNextHigherAssembly5.Name = "colNextHigherAssembly5"
        '
        'colInstallationDrawing5
        '
        Me.colInstallationDrawing5.FieldName = "InstallationDrawing"
        Me.colInstallationDrawing5.Name = "colInstallationDrawing5"
        '
        'colDRNADCN5
        '
        Me.colDRNADCN5.FieldName = "DRNADCN"
        Me.colDRNADCN5.Name = "colDRNADCN5"
        '
        'colFAAProjectNo5
        '
        Me.colFAAProjectNo5.FieldName = "FAAProjectNo"
        Me.colFAAProjectNo5.Name = "colFAAProjectNo5"
        '
        'colPSCPDocsRequired5
        '
        Me.colPSCPDocsRequired5.FieldName = "PSCPDocsRequired"
        Me.colPSCPDocsRequired5.Name = "colPSCPDocsRequired5"
        '
        'colCompanyFlightTestRequired5
        '
        Me.colCompanyFlightTestRequired5.FieldName = "CompanyFlightTestRequired"
        Me.colCompanyFlightTestRequired5.Name = "colCompanyFlightTestRequired5"
        '
        'colDwgReqDate5
        '
        Me.colDwgReqDate5.FieldName = "DwgReqDate"
        Me.colDwgReqDate5.Name = "colDwgReqDate5"
        '
        'colNewRework5
        '
        Me.colNewRework5.FieldName = "NewRework"
        Me.colNewRework5.Name = "colNewRework5"
        '
        'colUpdated5
        '
        Me.colUpdated5.FieldName = "Updated"
        Me.colUpdated5.Name = "colUpdated5"
        '
        'colUpdatedDate5
        '
        Me.colUpdatedDate5.FieldName = "UpdatedDate"
        Me.colUpdatedDate5.Name = "colUpdatedDate5"
        '
        'colDwgRevision5
        '
        Me.colDwgRevision5.FieldName = "DwgRevision"
        Me.colDwgRevision5.Name = "colDwgRevision5"
        '
        'colSeq3
        '
        Me.colSeq3.FieldName = "Seq"
        Me.colSeq3.Name = "colSeq3"
        '
        'colDRNSchedule
        '
        Me.colDRNSchedule.Caption = "DRN"
        Me.colDRNSchedule.FieldName = "DRNADCN"
        Me.colDRNSchedule.Name = "colDRNSchedule"
        Me.colDRNSchedule.Visible = True
        Me.colDRNSchedule.VisibleIndex = 1
        Me.colDRNSchedule.Width = 141
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(770, 238)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 13)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "% Complete"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(552, 238)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(133, 13)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "Estimated Duration (Hours)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(260, 238)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 13)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Forecast Finish Date"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(41, 238)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(99, 13)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "Forecast Start Date"
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.cboCertificationReviewStatus)
        Me.TabPage8.Controls.Add(Me.btnSyncOMTApprovals)
        Me.TabPage8.Controls.Add(Me.txtComments)
        Me.TabPage8.Controls.Add(Me.Label33)
        Me.TabPage8.Controls.Add(Me.chkShowAllFAAOMTApprovals)
        Me.TabPage8.Controls.Add(Me.GridControl8)
        Me.TabPage8.Controls.Add(Me.btnSaveUMApprovals)
        Me.TabPage8.Controls.Add(Me.Label34)
        Me.TabPage8.Controls.Add(Me.Label35)
        Me.TabPage8.Controls.Add(Me.btnSyncUMApprovals)
        Me.TabPage8.Controls.Add(Me.GridControl7)
        Me.TabPage8.Controls.Add(Me.chkShowAllUMApprovals)
        Me.TabPage8.Controls.Add(Me.Label32)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(1502, 388)
        Me.TabPage8.TabIndex = 5
        Me.TabPage8.Text = "Certification Status"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'cboCertificationReviewStatus
        '
        Me.cboCertificationReviewStatus.Location = New System.Drawing.Point(162, 327)
        Me.cboCertificationReviewStatus.Name = "cboCertificationReviewStatus"
        Me.cboCertificationReviewStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCertificationReviewStatus.Properties.Items.AddRange(New Object() {"Approved", "Not Approved"})
        Me.cboCertificationReviewStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCertificationReviewStatus.Size = New System.Drawing.Size(258, 20)
        Me.cboCertificationReviewStatus.TabIndex = 44
        '
        'btnSyncOMTApprovals
        '
        Me.btnSyncOMTApprovals.Location = New System.Drawing.Point(801, 169)
        Me.btnSyncOMTApprovals.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSyncOMTApprovals.Name = "btnSyncOMTApprovals"
        Me.btnSyncOMTApprovals.Size = New System.Drawing.Size(128, 24)
        Me.btnSyncOMTApprovals.TabIndex = 43
        Me.btnSyncOMTApprovals.Text = "Sync OMT Approvals"
        Me.btnSyncOMTApprovals.UseVisualStyleBackColor = True
        '
        'txtComments
        '
        Me.txtComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.Location = New System.Drawing.Point(535, 327)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(436, 20)
        Me.txtComments.TabIndex = 42
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(465, 327)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(56, 13)
        Me.Label33.TabIndex = 41
        Me.Label33.Text = "Comments"
        '
        'chkShowAllFAAOMTApprovals
        '
        Me.chkShowAllFAAOMTApprovals.AutoSize = True
        Me.chkShowAllFAAOMTApprovals.Location = New System.Drawing.Point(588, 174)
        Me.chkShowAllFAAOMTApprovals.Name = "chkShowAllFAAOMTApprovals"
        Me.chkShowAllFAAOMTApprovals.Size = New System.Drawing.Size(163, 17)
        Me.chkShowAllFAAOMTApprovals.TabIndex = 40
        Me.chkShowAllFAAOMTApprovals.Text = "Show All FAA OMT Members"
        Me.chkShowAllFAAOMTApprovals.UseVisualStyleBackColor = True
        '
        'GridControl8
        '
        Me.GridControl8.DataSource = Me.bsOMTApproval
        Me.GridControl8.Location = New System.Drawing.Point(26, 199)
        Me.GridControl8.MainView = Me.GridView8
        Me.GridControl8.Name = "GridControl8"
        Me.GridControl8.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox5})
        Me.GridControl8.Size = New System.Drawing.Size(1087, 113)
        Me.GridControl8.TabIndex = 39
        Me.GridControl8.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'bsOMTApproval
        '
        Me.bsOMTApproval.DataMember = "tblDrawingCertFAAOMTApproval"
        Me.bsOMTApproval.DataSource = Me.DataSet261
        '
        'DataSet261
        '
        Me.DataSet261.DataSetName = "DataSet26"
        Me.DataSet261.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.colDwgRecordID1, Me.colFAAOMTName, Me.colFAAOMTSpecialty, Me.colFAAOMTRecommendApproval, Me.colFAAOMTApproval, Me.colRequiredToApprove1, Me.colComments1})
        Me.GridView8.DetailHeight = 349
        Me.GridView8.GridControl = Me.GridControl8
        Me.GridView8.LevelIndent = 0
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsCustomization.AllowFilter = False
        Me.GridView8.OptionsCustomization.AllowSort = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.PreviewIndent = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "RecordID"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'colDwgRecordID1
        '
        Me.colDwgRecordID1.FieldName = "DwgRecordID"
        Me.colDwgRecordID1.Name = "colDwgRecordID1"
        '
        'colFAAOMTName
        '
        Me.colFAAOMTName.FieldName = "FAAOMTName"
        Me.colFAAOMTName.Name = "colFAAOMTName"
        Me.colFAAOMTName.Visible = True
        Me.colFAAOMTName.VisibleIndex = 0
        '
        'colFAAOMTSpecialty
        '
        Me.colFAAOMTSpecialty.FieldName = "FAAOMTSpecialty"
        Me.colFAAOMTSpecialty.Name = "colFAAOMTSpecialty"
        Me.colFAAOMTSpecialty.Visible = True
        Me.colFAAOMTSpecialty.VisibleIndex = 1
        '
        'colFAAOMTRecommendApproval
        '
        Me.colFAAOMTRecommendApproval.FieldName = "FAAOMTRecommendApproval"
        Me.colFAAOMTRecommendApproval.Name = "colFAAOMTRecommendApproval"
        '
        'colFAAOMTApproval
        '
        Me.colFAAOMTApproval.ColumnEdit = Me.RepositoryItemComboBox5
        Me.colFAAOMTApproval.FieldName = "FAAOMTApproval"
        Me.colFAAOMTApproval.Name = "colFAAOMTApproval"
        Me.colFAAOMTApproval.Visible = True
        Me.colFAAOMTApproval.VisibleIndex = 3
        '
        'RepositoryItemComboBox5
        '
        Me.RepositoryItemComboBox5.AutoHeight = False
        Me.RepositoryItemComboBox5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox5.Items.AddRange(New Object() {"Not Submitted", "Submitted", "Accepted", "Rejected", "Approved"})
        Me.RepositoryItemComboBox5.Name = "RepositoryItemComboBox5"
        Me.RepositoryItemComboBox5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colRequiredToApprove1
        '
        Me.colRequiredToApprove1.FieldName = "RequiredToApprove"
        Me.colRequiredToApprove1.Name = "colRequiredToApprove1"
        Me.colRequiredToApprove1.Visible = True
        Me.colRequiredToApprove1.VisibleIndex = 2
        '
        'colComments1
        '
        Me.colComments1.FieldName = "Comments"
        Me.colComments1.Name = "colComments1"
        Me.colComments1.Visible = True
        Me.colComments1.VisibleIndex = 4
        '
        'btnSaveUMApprovals
        '
        Me.btnSaveUMApprovals.Location = New System.Drawing.Point(977, 322)
        Me.btnSaveUMApprovals.Name = "btnSaveUMApprovals"
        Me.btnSaveUMApprovals.Size = New System.Drawing.Size(132, 23)
        Me.btnSaveUMApprovals.TabIndex = 38
        Me.btnSaveUMApprovals.Text = "Save"
        Me.btnSaveUMApprovals.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(22, 327)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(134, 13)
        Me.Label34.TabIndex = 36
        Me.Label34.Text = "Certification Review Status"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(22, 167)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(121, 13)
        Me.Label35.TabIndex = 35
        Me.Label35.Text = "FAA OMT Approvals"
        '
        'btnSyncUMApprovals
        '
        Me.btnSyncUMApprovals.Location = New System.Drawing.Point(801, 11)
        Me.btnSyncUMApprovals.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSyncUMApprovals.Name = "btnSyncUMApprovals"
        Me.btnSyncUMApprovals.Size = New System.Drawing.Size(128, 26)
        Me.btnSyncUMApprovals.TabIndex = 34
        Me.btnSyncUMApprovals.Text = "Sync UM Approvals"
        Me.btnSyncUMApprovals.UseVisualStyleBackColor = True
        '
        'GridControl7
        '
        Me.GridControl7.DataSource = Me.BSUMApproval
        Me.GridControl7.Location = New System.Drawing.Point(22, 41)
        Me.GridControl7.MainView = Me.GridView7
        Me.GridControl7.Name = "GridControl7"
        Me.GridControl7.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox3, Me.RepositoryItemComboBox4})
        Me.GridControl7.Size = New System.Drawing.Size(1087, 115)
        Me.GridControl7.TabIndex = 33
        Me.GridControl7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'BSUMApproval
        '
        Me.BSUMApproval.DataMember = "tblDrawingCertUMApproval"
        Me.BSUMApproval.DataSource = Me.DataSet251
        '
        'DataSet251
        '
        Me.DataSet251.DataSetName = "DataSet25"
        Me.DataSet251.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colDwgRecordID, Me.colUMName, Me.colUMSpecialty, Me.colUMRecommendApproval, Me.colUMApproval, Me.colDateSubmitted, Me.colDateNeeded, Me.colDateCommentsReturned, Me.colRequiredToApprove, Me.colComments})
        Me.GridView7.DetailHeight = 349
        Me.GridView7.GridControl = Me.GridControl7
        Me.GridView7.LevelIndent = 0
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsCustomization.AllowFilter = False
        Me.GridView7.OptionsCustomization.AllowSort = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.PreviewIndent = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "RecordID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colDwgRecordID
        '
        Me.colDwgRecordID.FieldName = "DwgRecordID"
        Me.colDwgRecordID.Name = "colDwgRecordID"
        '
        'colUMName
        '
        Me.colUMName.FieldName = "UMName"
        Me.colUMName.Name = "colUMName"
        Me.colUMName.Visible = True
        Me.colUMName.VisibleIndex = 0
        '
        'colUMSpecialty
        '
        Me.colUMSpecialty.FieldName = "UMSpecialty"
        Me.colUMSpecialty.Name = "colUMSpecialty"
        Me.colUMSpecialty.Visible = True
        Me.colUMSpecialty.VisibleIndex = 1
        '
        'colUMRecommendApproval
        '
        Me.colUMRecommendApproval.ColumnEdit = Me.RepositoryItemComboBox3
        Me.colUMRecommendApproval.FieldName = "UMRecommendApproval"
        Me.colUMRecommendApproval.Name = "colUMRecommendApproval"
        Me.colUMRecommendApproval.Visible = True
        Me.colUMRecommendApproval.VisibleIndex = 7
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Items.AddRange(New Object() {"Not Applicable", "Recommend Approval"})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        Me.RepositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colUMApproval
        '
        Me.colUMApproval.ColumnEdit = Me.RepositoryItemComboBox4
        Me.colUMApproval.FieldName = "UMApproval"
        Me.colUMApproval.Name = "colUMApproval"
        Me.colUMApproval.Visible = True
        Me.colUMApproval.VisibleIndex = 3
        '
        'RepositoryItemComboBox4
        '
        Me.RepositoryItemComboBox4.AutoHeight = False
        Me.RepositoryItemComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox4.Items.AddRange(New Object() {"Accepted", "Approved", "Not Submitted", "Rejected", "Submitted"})
        Me.RepositoryItemComboBox4.Name = "RepositoryItemComboBox4"
        Me.RepositoryItemComboBox4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colDateSubmitted
        '
        Me.colDateSubmitted.Caption = "Date Submitted"
        Me.colDateSubmitted.FieldName = "DateSubmitted"
        Me.colDateSubmitted.Name = "colDateSubmitted"
        Me.colDateSubmitted.Visible = True
        Me.colDateSubmitted.VisibleIndex = 4
        '
        'colDateNeeded
        '
        Me.colDateNeeded.Caption = "Date Needed"
        Me.colDateNeeded.FieldName = "DateNeeded"
        Me.colDateNeeded.Name = "colDateNeeded"
        Me.colDateNeeded.Visible = True
        Me.colDateNeeded.VisibleIndex = 5
        '
        'colDateCommentsReturned
        '
        Me.colDateCommentsReturned.Caption = "Date Comments Returned"
        Me.colDateCommentsReturned.FieldName = "DateCommentsReturned"
        Me.colDateCommentsReturned.Name = "colDateCommentsReturned"
        Me.colDateCommentsReturned.Visible = True
        Me.colDateCommentsReturned.VisibleIndex = 6
        '
        'colRequiredToApprove
        '
        Me.colRequiredToApprove.FieldName = "RequiredToApprove"
        Me.colRequiredToApprove.Name = "colRequiredToApprove"
        Me.colRequiredToApprove.Visible = True
        Me.colRequiredToApprove.VisibleIndex = 2
        '
        'colComments
        '
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 8
        '
        'chkShowAllUMApprovals
        '
        Me.chkShowAllUMApprovals.AutoSize = True
        Me.chkShowAllUMApprovals.Location = New System.Drawing.Point(588, 23)
        Me.chkShowAllUMApprovals.Name = "chkShowAllUMApprovals"
        Me.chkShowAllUMApprovals.Size = New System.Drawing.Size(133, 17)
        Me.chkShowAllUMApprovals.TabIndex = 32
        Me.chkShowAllUMApprovals.Text = "Show All UM Members"
        Me.chkShowAllUMApprovals.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(22, 24)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(86, 13)
        Me.Label32.TabIndex = 31
        Me.Label32.Text = "UM Approvals"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1502, 388)
        Me.TabPage1.TabIndex = 6
        Me.TabPage1.Text = "Certification-Continued"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Controls.Add(Me.GridControl9)
        Me.GroupBox2.Controls.Add(Me.btnFileAttachSubmit)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.btnView)
        Me.GroupBox2.Controls.Add(Me.btnSaveNew)
        Me.GroupBox2.Controls.Add(Me.btnBrowse)
        Me.GroupBox2.Controls.Add(Me.btnDeleteAttachment)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.txtFileDescription)
        Me.GroupBox2.Controls.Add(Me.txtFilePath)
        Me.GroupBox2.Controls.Add(Me.txtAttachRecordID)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1317, 227)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Attachments"
        '
        'GridControl9
        '
        Me.GridControl9.DataSource = Me.bsSearchAttachments
        Me.GridControl9.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl9.Location = New System.Drawing.Point(20, 41)
        Me.GridControl9.MainView = Me.GridView9
        Me.GridControl9.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl9.Name = "GridControl9"
        Me.GridControl9.Size = New System.Drawing.Size(729, 104)
        Me.GridControl9.TabIndex = 9
        Me.GridControl9.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'bsSearchAttachments
        '
        Me.bsSearchAttachments.DataMember = "tblDrawingCertAttachments"
        Me.bsSearchAttachments.DataSource = Me.DataSet271
        '
        'DataSet271
        '
        Me.DataSet271.DataSetName = "DataSet27"
        Me.DataSet271.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.colDwgRecordID2, Me.colFilePath, Me.colFileDescription, Me.colImgField, Me.colFileName, Me.colFileExt})
        Me.GridView9.DetailHeight = 227
        Me.GridView9.GridControl = Me.GridControl9
        Me.GridView9.LevelIndent = 0
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsCustomization.AllowFilter = False
        Me.GridView9.OptionsCustomization.AllowSort = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        Me.GridView9.PreviewIndent = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "RecordID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 50
        '
        'colDwgRecordID2
        '
        Me.colDwgRecordID2.FieldName = "DwgRecordID"
        Me.colDwgRecordID2.Name = "colDwgRecordID2"
        Me.colDwgRecordID2.Visible = True
        Me.colDwgRecordID2.VisibleIndex = 1
        Me.colDwgRecordID2.Width = 50
        '
        'colFilePath
        '
        Me.colFilePath.FieldName = "FilePath"
        Me.colFilePath.Name = "colFilePath"
        Me.colFilePath.Visible = True
        Me.colFilePath.VisibleIndex = 2
        Me.colFilePath.Width = 50
        '
        'colFileDescription
        '
        Me.colFileDescription.FieldName = "FileDescription"
        Me.colFileDescription.Name = "colFileDescription"
        Me.colFileDescription.Visible = True
        Me.colFileDescription.VisibleIndex = 3
        Me.colFileDescription.Width = 50
        '
        'colImgField
        '
        Me.colImgField.FieldName = "ImgField"
        Me.colImgField.Name = "colImgField"
        Me.colImgField.Visible = True
        Me.colImgField.VisibleIndex = 4
        Me.colImgField.Width = 50
        '
        'colFileName
        '
        Me.colFileName.FieldName = "FileName"
        Me.colFileName.Name = "colFileName"
        Me.colFileName.Visible = True
        Me.colFileName.VisibleIndex = 5
        Me.colFileName.Width = 50
        '
        'colFileExt
        '
        Me.colFileExt.FieldName = "FileExt"
        Me.colFileExt.Name = "colFileExt"
        Me.colFileExt.Visible = True
        Me.colFileExt.VisibleIndex = 6
        Me.colFileExt.Width = 50
        '
        'btnFileAttachSubmit
        '
        Me.btnFileAttachSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFileAttachSubmit.Location = New System.Drawing.Point(1108, 107)
        Me.btnFileAttachSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFileAttachSubmit.Name = "btnFileAttachSubmit"
        Me.btnFileAttachSubmit.Size = New System.Drawing.Size(112, 37)
        Me.btnFileAttachSubmit.TabIndex = 20
        Me.btnFileAttachSubmit.Text = "Submit New"
        Me.btnFileAttachSubmit.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(17, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(203, 13)
        Me.Label36.TabIndex = 8
        Me.Label36.Text = "8100-9/FAA Approval Attachments"
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(955, 107)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(148, 37)
        Me.btnView.TabIndex = 12
        Me.btnView.Text = "View Selected File"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNew.Location = New System.Drawing.Point(806, 186)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(101, 23)
        Me.btnSaveNew.TabIndex = 19
        Me.btnSaveNew.Text = "Save New"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        Me.btnSaveNew.Visible = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(692, 186)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(101, 23)
        Me.btnBrowse.TabIndex = 18
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnDeleteAttachment
        '
        Me.btnDeleteAttachment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAttachment.Location = New System.Drawing.Point(754, 107)
        Me.btnDeleteAttachment.Name = "btnDeleteAttachment"
        Me.btnDeleteAttachment.Size = New System.Drawing.Size(196, 37)
        Me.btnDeleteAttachment.TabIndex = 13
        Me.btnDeleteAttachment.Text = "Delete Selected Attachment"
        Me.btnDeleteAttachment.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label37.Location = New System.Drawing.Point(17, 191)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(36, 13)
        Me.Label37.TabIndex = 17
        Me.Label37.Text = "Path:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label38.Location = New System.Drawing.Point(17, 167)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(74, 13)
        Me.Label38.TabIndex = 16
        Me.Label38.Text = "Description:"
        '
        'txtFileDescription
        '
        Me.txtFileDescription.Location = New System.Drawing.Point(102, 167)
        Me.txtFileDescription.Name = "txtFileDescription"
        Me.txtFileDescription.Size = New System.Drawing.Size(577, 20)
        Me.txtFileDescription.TabIndex = 14
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(101, 191)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(577, 20)
        Me.txtFilePath.TabIndex = 15
        '
        'txtAttachRecordID
        '
        Me.txtAttachRecordID.Location = New System.Drawing.Point(602, 60)
        Me.txtAttachRecordID.Name = "txtAttachRecordID"
        Me.txtAttachRecordID.Size = New System.Drawing.Size(100, 20)
        Me.txtAttachRecordID.TabIndex = 21
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.btnReverseClosedEarr)
        Me.TabPage9.Controls.Add(Me.btnCloseIssue)
        Me.TabPage9.Controls.Add(Me.btnExportIssue)
        Me.TabPage9.Controls.Add(Me.btnViewIssue)
        Me.TabPage9.Controls.Add(Me.GridControl14)
        Me.TabPage9.Controls.Add(Me.txtIssuesRecordID)
        Me.TabPage9.Controls.Add(Me.txtTypeOfIssue)
        Me.TabPage9.Controls.Add(Me.txtEarrNumIssues)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(1502, 388)
        Me.TabPage9.TabIndex = 9
        Me.TabPage9.Text = "Production Issues"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'btnReverseClosedEarr
        '
        Me.btnReverseClosedEarr.Location = New System.Drawing.Point(1305, 3)
        Me.btnReverseClosedEarr.Name = "btnReverseClosedEarr"
        Me.btnReverseClosedEarr.Size = New System.Drawing.Size(121, 23)
        Me.btnReverseClosedEarr.TabIndex = 57
        Me.btnReverseClosedEarr.Text = "Reverse Closed Item"
        Me.btnReverseClosedEarr.UseVisualStyleBackColor = True
        '
        'btnCloseIssue
        '
        Me.btnCloseIssue.Location = New System.Drawing.Point(145, 3)
        Me.btnCloseIssue.Name = "btnCloseIssue"
        Me.btnCloseIssue.Size = New System.Drawing.Size(117, 23)
        Me.btnCloseIssue.TabIndex = 56
        Me.btnCloseIssue.Text = "Close Issue"
        Me.btnCloseIssue.UseVisualStyleBackColor = True
        '
        'btnExportIssue
        '
        Me.btnExportIssue.Location = New System.Drawing.Point(790, 3)
        Me.btnExportIssue.Name = "btnExportIssue"
        Me.btnExportIssue.Size = New System.Drawing.Size(117, 23)
        Me.btnExportIssue.TabIndex = 55
        Me.btnExportIssue.Text = "Export Grid"
        Me.btnExportIssue.UseVisualStyleBackColor = True
        '
        'btnViewIssue
        '
        Me.btnViewIssue.Location = New System.Drawing.Point(0, 3)
        Me.btnViewIssue.Name = "btnViewIssue"
        Me.btnViewIssue.Size = New System.Drawing.Size(136, 23)
        Me.btnViewIssue.TabIndex = 54
        Me.btnViewIssue.Text = "View Issue"
        Me.btnViewIssue.UseVisualStyleBackColor = True
        '
        'GridControl14
        '
        Me.GridControl14.DataSource = Me.bsIssues
        Me.GridControl14.Location = New System.Drawing.Point(3, 32)
        Me.GridControl14.MainView = Me.GridView14
        Me.GridControl14.Name = "GridControl14"
        Me.GridControl14.Size = New System.Drawing.Size(1496, 348)
        Me.GridControl14.TabIndex = 53
        Me.GridControl14.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView14})
        '
        'bsIssues
        '
        Me.bsIssues.DataMember = "tblDrawingsOfEARR"
        Me.bsIssues.DataSource = Me.DsIssues1
        '
        'DsIssues1
        '
        Me.DsIssues1.DataSetName = "dsIssues"
        Me.DsIssues1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView14
        '
        Me.GridView14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID9, Me.colEarr, Me.colIssueNumber, Me.colDrawNum, Me.colRev1, Me.colDrawNumRev, Me.colDrawTitle, Me.colResponse, Me.colIssueType, Me.colStatus8, Me.colOriginatorName, Me.colOriginatorDate, Me.colDateClosed, Me.colRequest, Me.colProgramName1, Me.colComments2, Me.colIssueTypes, Me.colDateIncorporated, Me.colProject, Me.colEQNNumber, Me.colCategory, Me.colERAS, Me.colERASUpdatedBy, Me.colDateERASUpdated})
        Me.GridView14.GridControl = Me.GridControl14
        Me.GridView14.LevelIndent = 0
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsBehavior.ReadOnly = True
        Me.GridView14.OptionsView.ShowGroupPanel = False
        Me.GridView14.PreviewIndent = 0
        '
        'colRecordID9
        '
        Me.colRecordID9.FieldName = "RecordID"
        Me.colRecordID9.Name = "colRecordID9"
        '
        'colEarr
        '
        Me.colEarr.FieldName = "Earr"
        Me.colEarr.Name = "colEarr"
        '
        'colIssueNumber
        '
        Me.colIssueNumber.FieldName = "IssueNumber"
        Me.colIssueNumber.Name = "colIssueNumber"
        Me.colIssueNumber.Visible = True
        Me.colIssueNumber.VisibleIndex = 1
        Me.colIssueNumber.Width = 68
        '
        'colDrawNum
        '
        Me.colDrawNum.Caption = "Document"
        Me.colDrawNum.FieldName = "DrawNum"
        Me.colDrawNum.Name = "colDrawNum"
        Me.colDrawNum.Visible = True
        Me.colDrawNum.VisibleIndex = 2
        Me.colDrawNum.Width = 42
        '
        'colRev1
        '
        Me.colRev1.Caption = "Doc Rev"
        Me.colRev1.FieldName = "Rev"
        Me.colRev1.Name = "colRev1"
        Me.colRev1.Visible = True
        Me.colRev1.VisibleIndex = 3
        Me.colRev1.Width = 48
        '
        'colDrawNumRev
        '
        Me.colDrawNumRev.FieldName = "DrawNumRev"
        Me.colDrawNumRev.Name = "colDrawNumRev"
        '
        'colDrawTitle
        '
        Me.colDrawTitle.FieldName = "DrawTitle"
        Me.colDrawTitle.Name = "colDrawTitle"
        '
        'colResponse
        '
        Me.colResponse.FieldName = "Response"
        Me.colResponse.Name = "colResponse"
        '
        'colIssueType
        '
        Me.colIssueType.FieldName = "IssueType"
        Me.colIssueType.Name = "colIssueType"
        Me.colIssueType.Visible = True
        Me.colIssueType.VisibleIndex = 4
        Me.colIssueType.Width = 56
        '
        'colStatus8
        '
        Me.colStatus8.FieldName = "Status"
        Me.colStatus8.Name = "colStatus8"
        Me.colStatus8.Visible = True
        Me.colStatus8.VisibleIndex = 5
        Me.colStatus8.Width = 43
        '
        'colOriginatorName
        '
        Me.colOriginatorName.FieldName = "OriginatorName"
        Me.colOriginatorName.Name = "colOriginatorName"
        '
        'colOriginatorDate
        '
        Me.colOriginatorDate.Caption = "Date Received"
        Me.colOriginatorDate.FieldName = "OriginatorDate"
        Me.colOriginatorDate.Name = "colOriginatorDate"
        Me.colOriginatorDate.Visible = True
        Me.colOriginatorDate.VisibleIndex = 6
        Me.colOriginatorDate.Width = 63
        '
        'colDateClosed
        '
        Me.colDateClosed.FieldName = "DateClosed"
        Me.colDateClosed.Name = "colDateClosed"
        Me.colDateClosed.Visible = True
        Me.colDateClosed.VisibleIndex = 7
        Me.colDateClosed.Width = 52
        '
        'colRequest
        '
        Me.colRequest.FieldName = "Request"
        Me.colRequest.Name = "colRequest"
        Me.colRequest.Visible = True
        Me.colRequest.VisibleIndex = 8
        Me.colRequest.Width = 280
        '
        'colProgramName1
        '
        Me.colProgramName1.Caption = "Program"
        Me.colProgramName1.FieldName = "ProgramName"
        Me.colProgramName1.Name = "colProgramName1"
        Me.colProgramName1.Visible = True
        Me.colProgramName1.VisibleIndex = 9
        Me.colProgramName1.Width = 64
        '
        'colComments2
        '
        Me.colComments2.FieldName = "Comments"
        Me.colComments2.Name = "colComments2"
        Me.colComments2.Visible = True
        Me.colComments2.VisibleIndex = 10
        Me.colComments2.Width = 471
        '
        'colIssueTypes
        '
        Me.colIssueTypes.Caption = "Issue Type"
        Me.colIssueTypes.FieldName = "Type"
        Me.colIssueTypes.Name = "colIssueTypes"
        Me.colIssueTypes.Visible = True
        Me.colIssueTypes.VisibleIndex = 0
        Me.colIssueTypes.Width = 62
        '
        'colDateIncorporated
        '
        Me.colDateIncorporated.FieldName = "DateIncorporated"
        Me.colDateIncorporated.Name = "colDateIncorporated"
        '
        'colProject
        '
        Me.colProject.FieldName = "Project"
        Me.colProject.Name = "colProject"
        '
        'colEQNNumber
        '
        Me.colEQNNumber.FieldName = "EQNNumber"
        Me.colEQNNumber.Name = "colEQNNumber"
        '
        'colCategory
        '
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        '
        'colERAS
        '
        Me.colERAS.FieldName = "ERAS"
        Me.colERAS.Name = "colERAS"
        Me.colERAS.Visible = True
        Me.colERAS.VisibleIndex = 11
        Me.colERAS.Width = 42
        '
        'colERASUpdatedBy
        '
        Me.colERASUpdatedBy.FieldName = "ERASUpdatedBy"
        Me.colERASUpdatedBy.Name = "colERASUpdatedBy"
        Me.colERASUpdatedBy.Visible = True
        Me.colERASUpdatedBy.VisibleIndex = 12
        Me.colERASUpdatedBy.Width = 95
        '
        'colDateERASUpdated
        '
        Me.colDateERASUpdated.FieldName = "DateERASUpdated"
        Me.colDateERASUpdated.Name = "colDateERASUpdated"
        Me.colDateERASUpdated.Visible = True
        Me.colDateERASUpdated.VisibleIndex = 13
        Me.colDateERASUpdated.Width = 92
        '
        'txtIssuesRecordID
        '
        Me.txtIssuesRecordID.Location = New System.Drawing.Point(346, 119)
        Me.txtIssuesRecordID.Name = "txtIssuesRecordID"
        Me.txtIssuesRecordID.Size = New System.Drawing.Size(100, 20)
        Me.txtIssuesRecordID.TabIndex = 50
        '
        'txtTypeOfIssue
        '
        Me.txtTypeOfIssue.Location = New System.Drawing.Point(227, 125)
        Me.txtTypeOfIssue.Name = "txtTypeOfIssue"
        Me.txtTypeOfIssue.Size = New System.Drawing.Size(100, 20)
        Me.txtTypeOfIssue.TabIndex = 51
        '
        'txtEarrNumIssues
        '
        Me.txtEarrNumIssues.Location = New System.Drawing.Point(482, 119)
        Me.txtEarrNumIssues.Name = "txtEarrNumIssues"
        Me.txtEarrNumIssues.Size = New System.Drawing.Size(100, 20)
        Me.txtEarrNumIssues.TabIndex = 52
        '
        'tabAttachments
        '
        Me.tabAttachments.Controls.Add(Me.GridControl10)
        Me.tabAttachments.Controls.Add(Me.cboConfigurationStatus)
        Me.tabAttachments.Controls.Add(Me.Label52)
        Me.tabAttachments.Controls.Add(Me.btnViewAttachment)
        Me.tabAttachments.Controls.Add(Me.txtFieldDescriptionAttach)
        Me.tabAttachments.Controls.Add(Me.Label51)
        Me.tabAttachments.Controls.Add(Me.btnDeleteAttach)
        Me.tabAttachments.Controls.Add(Me.btnSaveAttachment)
        Me.tabAttachments.Controls.Add(Me.btnBrowseAttachments)
        Me.tabAttachments.Controls.Add(Me.txtFileNameAttach)
        Me.tabAttachments.Controls.Add(Me.Label49)
        Me.tabAttachments.Controls.Add(Me.txtTargetAttach)
        Me.tabAttachments.Controls.Add(Me.Label50)
        Me.tabAttachments.Location = New System.Drawing.Point(4, 22)
        Me.tabAttachments.Name = "tabAttachments"
        Me.tabAttachments.Size = New System.Drawing.Size(1502, 388)
        Me.tabAttachments.TabIndex = 7
        Me.tabAttachments.Text = "Configuration Items"
        Me.tabAttachments.UseVisualStyleBackColor = True
        '
        'GridControl10
        '
        Me.GridControl10.DataSource = Me.bsAttachments
        Me.GridControl10.Location = New System.Drawing.Point(3, 3)
        Me.GridControl10.MainView = Me.GridView10
        Me.GridControl10.Name = "GridControl10"
        Me.GridControl10.Size = New System.Drawing.Size(1396, 136)
        Me.GridControl10.TabIndex = 0
        Me.GridControl10.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView10})
        '
        'bsAttachments
        '
        Me.bsAttachments.DataMember = "tblAttachments"
        Me.bsAttachments.DataSource = Me.DsAttachments1
        '
        'DsAttachments1
        '
        Me.DsAttachments1.DataSetName = "dsAttachments"
        Me.DsAttachments1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordIDAttach, Me.colDwgRecordID3, Me.colTarget, Me.colFileName1, Me.colIsActualDoc, Me.colFileDescription1})
        Me.GridView10.DetailHeight = 349
        Me.GridView10.GridControl = Me.GridControl10
        Me.GridView10.LevelIndent = 0
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsCustomization.AllowFilter = False
        Me.GridView10.OptionsCustomization.AllowSort = False
        Me.GridView10.PreviewIndent = 0
        '
        'colRecordIDAttach
        '
        Me.colRecordIDAttach.FieldName = "RecordID"
        Me.colRecordIDAttach.Name = "colRecordIDAttach"
        Me.colRecordIDAttach.OptionsColumn.ReadOnly = True
        Me.colRecordIDAttach.Visible = True
        Me.colRecordIDAttach.VisibleIndex = 0
        '
        'colDwgRecordID3
        '
        Me.colDwgRecordID3.FieldName = "DwgRecordID"
        Me.colDwgRecordID3.Name = "colDwgRecordID3"
        Me.colDwgRecordID3.OptionsColumn.ReadOnly = True
        Me.colDwgRecordID3.Visible = True
        Me.colDwgRecordID3.VisibleIndex = 1
        '
        'colTarget
        '
        Me.colTarget.FieldName = "Target"
        Me.colTarget.Name = "colTarget"
        Me.colTarget.OptionsColumn.ReadOnly = True
        Me.colTarget.Visible = True
        Me.colTarget.VisibleIndex = 2
        '
        'colFileName1
        '
        Me.colFileName1.FieldName = "FileName"
        Me.colFileName1.Name = "colFileName1"
        Me.colFileName1.OptionsColumn.ReadOnly = True
        Me.colFileName1.Visible = True
        Me.colFileName1.VisibleIndex = 3
        '
        'colIsActualDoc
        '
        Me.colIsActualDoc.FieldName = "IsActualDoc"
        Me.colIsActualDoc.Name = "colIsActualDoc"
        Me.colIsActualDoc.OptionsColumn.ReadOnly = True
        Me.colIsActualDoc.Visible = True
        Me.colIsActualDoc.VisibleIndex = 4
        '
        'colFileDescription1
        '
        Me.colFileDescription1.FieldName = "FileDescription"
        Me.colFileDescription1.Name = "colFileDescription1"
        Me.colFileDescription1.OptionsColumn.ReadOnly = True
        Me.colFileDescription1.Visible = True
        Me.colFileDescription1.VisibleIndex = 5
        '
        'cboConfigurationStatus
        '
        Me.cboConfigurationStatus.FormattingEnabled = True
        Me.cboConfigurationStatus.Location = New System.Drawing.Point(658, 201)
        Me.cboConfigurationStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboConfigurationStatus.Name = "cboConfigurationStatus"
        Me.cboConfigurationStatus.Size = New System.Drawing.Size(159, 21)
        Me.cboConfigurationStatus.TabIndex = 17
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(656, 181)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(102, 13)
        Me.Label52.TabIndex = 16
        Me.Label52.Text = "Configuration Status"
        '
        'btnViewAttachment
        '
        Me.btnViewAttachment.Location = New System.Drawing.Point(1087, 145)
        Me.btnViewAttachment.Name = "btnViewAttachment"
        Me.btnViewAttachment.Size = New System.Drawing.Size(179, 23)
        Me.btnViewAttachment.TabIndex = 15
        Me.btnViewAttachment.Text = "View Selected Attachment"
        Me.btnViewAttachment.UseVisualStyleBackColor = True
        '
        'txtFieldDescriptionAttach
        '
        Me.txtFieldDescriptionAttach.Location = New System.Drawing.Point(246, 202)
        Me.txtFieldDescriptionAttach.Name = "txtFieldDescriptionAttach"
        Me.txtFieldDescriptionAttach.Size = New System.Drawing.Size(402, 20)
        Me.txtFieldDescriptionAttach.TabIndex = 10
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(246, 181)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(85, 13)
        Me.Label51.TabIndex = 13
        Me.Label51.Text = "Field Description"
        '
        'btnDeleteAttach
        '
        Me.btnDeleteAttach.Location = New System.Drawing.Point(999, 197)
        Me.btnDeleteAttach.Name = "btnDeleteAttach"
        Me.btnDeleteAttach.Size = New System.Drawing.Size(93, 23)
        Me.btnDeleteAttach.TabIndex = 14
        Me.btnDeleteAttach.Text = "Delete"
        Me.btnDeleteAttach.UseVisualStyleBackColor = True
        '
        'btnSaveAttachment
        '
        Me.btnSaveAttachment.Location = New System.Drawing.Point(913, 197)
        Me.btnSaveAttachment.Name = "btnSaveAttachment"
        Me.btnSaveAttachment.Size = New System.Drawing.Size(80, 23)
        Me.btnSaveAttachment.TabIndex = 13
        Me.btnSaveAttachment.Text = "Save/Upload"
        Me.btnSaveAttachment.UseVisualStyleBackColor = True
        '
        'btnBrowseAttachments
        '
        Me.btnBrowseAttachments.Location = New System.Drawing.Point(832, 197)
        Me.btnBrowseAttachments.Name = "btnBrowseAttachments"
        Me.btnBrowseAttachments.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseAttachments.TabIndex = 11
        Me.btnBrowseAttachments.Text = "Browse"
        Me.btnBrowseAttachments.UseVisualStyleBackColor = True
        '
        'txtFileNameAttach
        '
        Me.txtFileNameAttach.Location = New System.Drawing.Point(18, 202)
        Me.txtFileNameAttach.Name = "txtFileNameAttach"
        Me.txtFileNameAttach.Size = New System.Drawing.Size(222, 20)
        Me.txtFileNameAttach.TabIndex = 8
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(15, 181)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(54, 13)
        Me.Label49.TabIndex = 1
        Me.Label49.Text = "File Name"
        '
        'txtTargetAttach
        '
        Me.txtTargetAttach.Location = New System.Drawing.Point(211, 89)
        Me.txtTargetAttach.Name = "txtTargetAttach"
        Me.txtTargetAttach.Size = New System.Drawing.Size(320, 20)
        Me.txtTargetAttach.TabIndex = 9
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(207, 67)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(38, 13)
        Me.Label50.TabIndex = 2
        Me.Label50.Text = "Target"
        '
        'DsIssues
        '
        Me.DsIssues.DataSetName = "dsIssues"
        Me.DsIssues.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(1221, 28)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(149, 31)
        Me.btnClose.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnClose, "Exit To Main Screen")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(251, 319)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(92, 50)
        Me.btnSave.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save Current Document")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(5, 28)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 35)
        Me.btnAdd.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Add New Document")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'chkShowStageComplete
        '
        Me.chkShowStageComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowStageComplete.Location = New System.Drawing.Point(698, 21)
        Me.chkShowStageComplete.Margin = New System.Windows.Forms.Padding(2)
        Me.chkShowStageComplete.Name = "chkShowStageComplete"
        Me.chkShowStageComplete.Size = New System.Drawing.Size(173, 32)
        Me.chkShowStageComplete.TabIndex = 14
        Me.chkShowStageComplete.Text = "Show GATE 6: Complete"
        Me.chkShowStageComplete.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(1060, 28)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(149, 31)
        Me.btnRefresh.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.btnRefresh, "Refresh data in main grid")
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnExportGrid
        '
        Me.btnExportGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportGrid.Image = CType(resources.GetObject("btnExportGrid.Image"), System.Drawing.Image)
        Me.btnExportGrid.Location = New System.Drawing.Point(898, 28)
        Me.btnExportGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExportGrid.Name = "btnExportGrid"
        Me.btnExportGrid.Size = New System.Drawing.Size(149, 31)
        Me.btnExportGrid.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.btnExportGrid, "Export data in main grid to excel")
        Me.btnExportGrid.UseVisualStyleBackColor = True
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(33, 373)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(65, 20)
        Me.Label27.TabIndex = 16
        Me.Label27.Text = "Number"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(322, 376)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(38, 20)
        Me.Label28.TabIndex = 17
        Me.Label28.Text = "Title"
        '
        'txtMainDrawingNumber
        '
        Me.txtMainDrawingNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMainDrawingNumber.Location = New System.Drawing.Point(108, 375)
        Me.txtMainDrawingNumber.Name = "txtMainDrawingNumber"
        Me.txtMainDrawingNumber.Size = New System.Drawing.Size(198, 20)
        Me.txtMainDrawingNumber.TabIndex = 26
        '
        'txtMainTitle
        '
        Me.txtMainTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMainTitle.Location = New System.Drawing.Point(382, 376)
        Me.txtMainTitle.Name = "txtMainTitle"
        Me.txtMainTitle.Size = New System.Drawing.Size(504, 20)
        Me.txtMainTitle.TabIndex = 27
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AdminToolStripMenuItem, Me.CertificationToolStripMenuItem, Me.MDLToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1584, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToMainMenuScreenToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ReturnToMainMenuScreenToolStripMenuItem
        '
        Me.ReturnToMainMenuScreenToolStripMenuItem.Name = "ReturnToMainMenuScreenToolStripMenuItem"
        Me.ReturnToMainMenuScreenToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.ReturnToMainMenuScreenToolStripMenuItem.Text = "<< Return to Main Menu Screen"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem, Me.ProgramsToolStripMenuItem, Me.ProjectsToolStripMenuItem, Me.CertificationStaffToolStripMenuItem, Me.LovMaintenanceToolStripMenuItem, Me.ProjectServerWorkflowSyncToolStripMenuItem, Me.GridEditToolStripMenuItem, Me.AIMNumbersListToolStripMenuItem, Me.ChangeDrawingNumberToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "&Admin"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'ProgramsToolStripMenuItem
        '
        Me.ProgramsToolStripMenuItem.Name = "ProgramsToolStripMenuItem"
        Me.ProgramsToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ProgramsToolStripMenuItem.Text = "Programs"
        '
        'ProjectsToolStripMenuItem
        '
        Me.ProjectsToolStripMenuItem.Name = "ProjectsToolStripMenuItem"
        Me.ProjectsToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ProjectsToolStripMenuItem.Text = "Projects"
        '
        'CertificationStaffToolStripMenuItem
        '
        Me.CertificationStaffToolStripMenuItem.Name = "CertificationStaffToolStripMenuItem"
        Me.CertificationStaffToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.CertificationStaffToolStripMenuItem.Text = "Certification Staff"
        '
        'LovMaintenanceToolStripMenuItem
        '
        Me.LovMaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemDescriptionToolStripMenuItem, Me.DocumentTypeToolStripMenuItem, Me.ResourceTypeToolStripMenuItem, Me.NameAssignmentsToolStripMenuItem, Me.PriorityToolStripMenuItem, Me.DRNADCNToolStripMenuItem, Me.NewReworkToolStripMenuItem, Me.WhiteBoardToolStripMenuItem, Me.NotificationRolesToolStripMenuItem, Me.JASCCodesToolStripMenuItem, Me.Level3DocTypeToolStripMenuItem, Me.ProductGroupToolStripMenuItem, Me.AircraftsToolStripMenuItem})
        Me.LovMaintenanceToolStripMenuItem.Name = "LovMaintenanceToolStripMenuItem"
        Me.LovMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.LovMaintenanceToolStripMenuItem.Text = "lov maintenance"
        '
        'SystemDescriptionToolStripMenuItem
        '
        Me.SystemDescriptionToolStripMenuItem.Name = "SystemDescriptionToolStripMenuItem"
        Me.SystemDescriptionToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SystemDescriptionToolStripMenuItem.Text = "System Description"
        '
        'DocumentTypeToolStripMenuItem
        '
        Me.DocumentTypeToolStripMenuItem.Name = "DocumentTypeToolStripMenuItem"
        Me.DocumentTypeToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DocumentTypeToolStripMenuItem.Text = "Document Type"
        '
        'ResourceTypeToolStripMenuItem
        '
        Me.ResourceTypeToolStripMenuItem.Name = "ResourceTypeToolStripMenuItem"
        Me.ResourceTypeToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ResourceTypeToolStripMenuItem.Text = "Resource Type"
        '
        'NameAssignmentsToolStripMenuItem
        '
        Me.NameAssignmentsToolStripMenuItem.Name = "NameAssignmentsToolStripMenuItem"
        Me.NameAssignmentsToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NameAssignmentsToolStripMenuItem.Text = "Name Assignments"
        '
        'PriorityToolStripMenuItem
        '
        Me.PriorityToolStripMenuItem.Name = "PriorityToolStripMenuItem"
        Me.PriorityToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PriorityToolStripMenuItem.Text = "Milestone"
        '
        'DRNADCNToolStripMenuItem
        '
        Me.DRNADCNToolStripMenuItem.Name = "DRNADCNToolStripMenuItem"
        Me.DRNADCNToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DRNADCNToolStripMenuItem.Text = "DRNADCN"
        '
        'NewReworkToolStripMenuItem
        '
        Me.NewReworkToolStripMenuItem.Name = "NewReworkToolStripMenuItem"
        Me.NewReworkToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NewReworkToolStripMenuItem.Text = "New/Rework"
        '
        'WhiteBoardToolStripMenuItem
        '
        Me.WhiteBoardToolStripMenuItem.Name = "WhiteBoardToolStripMenuItem"
        Me.WhiteBoardToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.WhiteBoardToolStripMenuItem.Text = "White Board"
        '
        'NotificationRolesToolStripMenuItem
        '
        Me.NotificationRolesToolStripMenuItem.Name = "NotificationRolesToolStripMenuItem"
        Me.NotificationRolesToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NotificationRolesToolStripMenuItem.Text = "Notification Roles"
        '
        'JASCCodesToolStripMenuItem
        '
        Me.JASCCodesToolStripMenuItem.Name = "JASCCodesToolStripMenuItem"
        Me.JASCCodesToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.JASCCodesToolStripMenuItem.Text = "JASC Codes"
        '
        'Level3DocTypeToolStripMenuItem
        '
        Me.Level3DocTypeToolStripMenuItem.Name = "Level3DocTypeToolStripMenuItem"
        Me.Level3DocTypeToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.Level3DocTypeToolStripMenuItem.Text = "Level 3 Doc Type"
        '
        'ProductGroupToolStripMenuItem
        '
        Me.ProductGroupToolStripMenuItem.Name = "ProductGroupToolStripMenuItem"
        Me.ProductGroupToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ProductGroupToolStripMenuItem.Text = "Product Group"
        '
        'AircraftsToolStripMenuItem
        '
        Me.AircraftsToolStripMenuItem.Name = "AircraftsToolStripMenuItem"
        Me.AircraftsToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AircraftsToolStripMenuItem.Text = "Aircrafts"
        '
        'ProjectServerWorkflowSyncToolStripMenuItem
        '
        Me.ProjectServerWorkflowSyncToolStripMenuItem.Enabled = False
        Me.ProjectServerWorkflowSyncToolStripMenuItem.Name = "ProjectServerWorkflowSyncToolStripMenuItem"
        Me.ProjectServerWorkflowSyncToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ProjectServerWorkflowSyncToolStripMenuItem.Text = "Project Server/Workflow Sync"
        '
        'GridEditToolStripMenuItem
        '
        Me.GridEditToolStripMenuItem.Name = "GridEditToolStripMenuItem"
        Me.GridEditToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.GridEditToolStripMenuItem.Text = "Grid Edit"
        '
        'AIMNumbersListToolStripMenuItem
        '
        Me.AIMNumbersListToolStripMenuItem.Name = "AIMNumbersListToolStripMenuItem"
        Me.AIMNumbersListToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.AIMNumbersListToolStripMenuItem.Text = "AIM Numbers List"
        '
        'ChangeDrawingNumberToolStripMenuItem
        '
        Me.ChangeDrawingNumberToolStripMenuItem.Name = "ChangeDrawingNumberToolStripMenuItem"
        Me.ChangeDrawingNumberToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ChangeDrawingNumberToolStripMenuItem.Text = "Change Drawing Number"
        '
        'CertificationToolStripMenuItem
        '
        Me.CertificationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterGridToolStripMenuItem})
        Me.CertificationToolStripMenuItem.Name = "CertificationToolStripMenuItem"
        Me.CertificationToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.CertificationToolStripMenuItem.Text = "Certification"
        '
        'FilterGridToolStripMenuItem
        '
        Me.FilterGridToolStripMenuItem.Name = "FilterGridToolStripMenuItem"
        Me.FilterGridToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.FilterGridToolStripMenuItem.Text = "Filter Grid"
        '
        'MDLToolStripMenuItem
        '
        Me.MDLToolStripMenuItem.Name = "MDLToolStripMenuItem"
        Me.MDLToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.MDLToolStripMenuItem.Text = "MDL"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpManualToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpManualToolStripMenuItem
        '
        Me.HelpManualToolStripMenuItem.Name = "HelpManualToolStripMenuItem"
        Me.HelpManualToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.HelpManualToolStripMenuItem.Text = "Help Manual"
        '
        'txtMainRecordID
        '
        Me.txtMainRecordID.Location = New System.Drawing.Point(411, 215)
        Me.txtMainRecordID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMainRecordID.Name = "txtMainRecordID"
        Me.txtMainRecordID.Size = New System.Drawing.Size(68, 20)
        Me.txtMainRecordID.TabIndex = 29
        '
        'txtMainProgram
        '
        Me.txtMainProgram.Location = New System.Drawing.Point(480, 214)
        Me.txtMainProgram.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMainProgram.Name = "txtMainProgram"
        Me.txtMainProgram.Size = New System.Drawing.Size(68, 20)
        Me.txtMainProgram.TabIndex = 30
        '
        'txtMainStatus
        '
        Me.txtMainStatus.Location = New System.Drawing.Point(550, 214)
        Me.txtMainStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMainStatus.Name = "txtMainStatus"
        Me.txtMainStatus.Size = New System.Drawing.Size(68, 20)
        Me.txtMainStatus.TabIndex = 31
        '
        'txtMainLocation
        '
        Me.txtMainLocation.Location = New System.Drawing.Point(632, 215)
        Me.txtMainLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMainLocation.Name = "txtMainLocation"
        Me.txtMainLocation.Size = New System.Drawing.Size(68, 20)
        Me.txtMainLocation.TabIndex = 32
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawings", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DocumentType", "DocumentType"), New System.Data.Common.DataColumnMapping("Priority", "Priority"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("DwgRequestBy", "DwgRequestBy"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DwgRequestDate", "DwgRequestDate"), New System.Data.Common.DataColumnMapping("DrawingTitle", "DrawingTitle"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("DrawingType", "DrawingType"), New System.Data.Common.DataColumnMapping("SystemDescription", "SystemDescription"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("LastActionDate", "LastActionDate"), New System.Data.Common.DataColumnMapping("ActualFinishDate", "ActualFinishDate"), New System.Data.Common.DataColumnMapping("ForecastStartDate", "ForecastStartDate"), New System.Data.Common.DataColumnMapping("ForecastFinishDate", "ForecastFinishDate"), New System.Data.Common.DataColumnMapping("PlannedFinishDate", "PlannedFinishDate"), New System.Data.Common.DataColumnMapping("EstimatedDurationHours", "EstimatedDurationHours"), New System.Data.Common.DataColumnMapping("PercentComplete", "PercentComplete"), New System.Data.Common.DataColumnMapping("DrawingFolderAssignDate", "DrawingFolderAssignDate"), New System.Data.Common.DataColumnMapping("DesignWIPDate", "DesignWIPDate"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("ModelTemplateDate", "ModelTemplateDate"), New System.Data.Common.DataColumnMapping("Drafter", "Drafter"), New System.Data.Common.DataColumnMapping("DrafterComplete", "DrafterComplete"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerComplete", "EngineerComplete"), New System.Data.Common.DataColumnMapping("SrEngineer", "SrEngineer"), New System.Data.Common.DataColumnMapping("SrEngineerComplete", "SrEngineerComplete"), New System.Data.Common.DataColumnMapping("Releaser", "Releaser"), New System.Data.Common.DataColumnMapping("ReleaserCompelte", "ReleaserCompelte"), New System.Data.Common.DataColumnMapping("Flammability", "Flammability"), New System.Data.Common.DataColumnMapping("FlammabilityComplete", "FlammabilityComplete"), New System.Data.Common.DataColumnMapping("Stress", "Stress"), New System.Data.Common.DataColumnMapping("StressComplete", "StressComplete"), New System.Data.Common.DataColumnMapping("Expr2", "Expr2"), New System.Data.Common.DataColumnMapping("RefID", "RefID"), New System.Data.Common.DataColumnMapping("DrafterPlannedCompleteDate", "DrafterPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("EngineerPlannedCompleteDate", "EngineerPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("SrEngineerPlannedCompleteDate", "SrEngineerPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("FlammabilityPlannedCompleteDate", "FlammabilityPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("StressPlannedCompleteDate", "StressPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("ReleaserPlannedCompleteDate", "ReleaserPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("Avionics", "Avionics"), New System.Data.Common.DataColumnMapping("AvionicsComplete", "AvionicsComplete"), New System.Data.Common.DataColumnMapping("AvionicsPlannedComplete", "AvionicsPlannedComplete"), New System.Data.Common.DataColumnMapping("Mechanical", "Mechanical"), New System.Data.Common.DataColumnMapping("MechanicalComplete", "MechanicalComplete"), New System.Data.Common.DataColumnMapping("MechanicalPlannedComplete", "MechanicalPlannedComplete"), New System.Data.Common.DataColumnMapping("WONumber", "WONumber"), New System.Data.Common.DataColumnMapping("NextHigherAssembly", "NextHigherAssembly"), New System.Data.Common.DataColumnMapping("InstallationDrawing", "InstallationDrawing"), New System.Data.Common.DataColumnMapping("WhiteBoardNumber", "WhiteBoardNumber"), New System.Data.Common.DataColumnMapping("DRNADCN", "DRNADCN"), New System.Data.Common.DataColumnMapping("FAAProjectNo", "FAAProjectNo"), New System.Data.Common.DataColumnMapping("PSCPDocsRequired", "PSCPDocsRequired"), New System.Data.Common.DataColumnMapping("CompanyFlightTestRequired", "CompanyFlightTestRequired"), New System.Data.Common.DataColumnMapping("DwgReqDate", "DwgReqDate"), New System.Data.Common.DataColumnMapping("NewRework", "NewRework"), New System.Data.Common.DataColumnMapping("Updated", "Updated"), New System.Data.Common.DataColumnMapping("UpdatedDate", "UpdatedDate"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("Seq", "Seq"), New System.Data.Common.DataColumnMapping("ADCN", "ADCN"), New System.Data.Common.DataColumnMapping("DCN", "DCN"), New System.Data.Common.DataColumnMapping("DRNADCNStatus", "DRNADCNStatus"), New System.Data.Common.DataColumnMapping("DRNADCNIncorporatedBy", "DRNADCNIncorporatedBy"), New System.Data.Common.DataColumnMapping("IncorporatedRev", "IncorporatedRev"), New System.Data.Common.DataColumnMapping("ProgramReal", "ProgramReal")})})
        '
        'txtMainInfoRecordID
        '
        Me.txtMainInfoRecordID.Location = New System.Drawing.Point(471, 236)
        Me.txtMainInfoRecordID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMainInfoRecordID.Name = "txtMainInfoRecordID"
        Me.txtMainInfoRecordID.Size = New System.Drawing.Size(68, 20)
        Me.txtMainInfoRecordID.TabIndex = 33
        '
        'btnAddNewRev
        '
        Me.btnAddNewRev.Image = CType(resources.GetObject("btnAddNewRev.Image"), System.Drawing.Image)
        Me.btnAddNewRev.Location = New System.Drawing.Point(154, 319)
        Me.btnAddNewRev.Name = "btnAddNewRev"
        Me.btnAddNewRev.Size = New System.Drawing.Size(92, 50)
        Me.btnAddNewRev.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.btnAddNewRev, "Add New Document Revision")
        Me.btnAddNewRev.UseVisualStyleBackColor = True
        '
        'btnSignOff
        '
        Me.btnSignOff.Image = CType(resources.GetObject("btnSignOff.Image"), System.Drawing.Image)
        Me.btnSignOff.Location = New System.Drawing.Point(446, 319)
        Me.btnSignOff.Name = "btnSignOff"
        Me.btnSignOff.Size = New System.Drawing.Size(92, 50)
        Me.btnSignOff.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.btnSignOff, "Click To View/Sign Off")
        Me.btnSignOff.UseVisualStyleBackColor = True
        '
        'btncancelobsolete
        '
        Me.btncancelobsolete.Image = CType(resources.GetObject("btncancelobsolete.Image"), System.Drawing.Image)
        Me.btncancelobsolete.Location = New System.Drawing.Point(348, 319)
        Me.btncancelobsolete.Name = "btncancelobsolete"
        Me.btncancelobsolete.Size = New System.Drawing.Size(92, 50)
        Me.btncancelobsolete.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.btncancelobsolete, "Mark document Cancel/Obsolete")
        Me.btncancelobsolete.UseVisualStyleBackColor = True
        Me.btncancelobsolete.Visible = False
        '
        'btnNumber
        '
        Me.btnNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNumber.Location = New System.Drawing.Point(5, 320)
        Me.btnNumber.Name = "btnNumber"
        Me.btnNumber.Size = New System.Drawing.Size(92, 50)
        Me.btnNumber.TabIndex = 46
        Me.btnNumber.Text = "Number"
        Me.ToolTip1.SetToolTip(Me.btnNumber, "Modify/Confirm Doc Number")
        Me.btnNumber.UseVisualStyleBackColor = True
        '
        'cboView
        '
        Me.cboView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboView.FormattingEnabled = True
        Me.cboView.Items.AddRange(New Object() {"All", "In Design", "In Design and Completed", "Current Revision", "Cancelled", "Obsolete", "Notifications"})
        Me.cboView.Location = New System.Drawing.Point(670, 24)
        Me.cboView.Margin = New System.Windows.Forms.Padding(2)
        Me.cboView.Name = "cboView"
        Me.cboView.Size = New System.Drawing.Size(202, 21)
        Me.cboView.TabIndex = 35
        Me.cboView.Text = "Current Revision"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "vwDrawingsRev", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DocumentType", "DocumentType"), New System.Data.Common.DataColumnMapping("Priority", "Priority"), New System.Data.Common.DataColumnMapping("Location", "Location"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("DwgRequestBy", "DwgRequestBy"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DwgRequestDate", "DwgRequestDate"), New System.Data.Common.DataColumnMapping("DrawingTitle", "DrawingTitle"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("DrawingType", "DrawingType"), New System.Data.Common.DataColumnMapping("SystemDescription", "SystemDescription"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("LastActionDate", "LastActionDate"), New System.Data.Common.DataColumnMapping("ActualFinishDate", "ActualFinishDate"), New System.Data.Common.DataColumnMapping("ForecastStartDate", "ForecastStartDate"), New System.Data.Common.DataColumnMapping("ForecastFinishDate", "ForecastFinishDate"), New System.Data.Common.DataColumnMapping("PlannedFinishDate", "PlannedFinishDate"), New System.Data.Common.DataColumnMapping("EstimatedDurationHours", "EstimatedDurationHours"), New System.Data.Common.DataColumnMapping("PercentComplete", "PercentComplete"), New System.Data.Common.DataColumnMapping("DrawingFolderAssignDate", "DrawingFolderAssignDate"), New System.Data.Common.DataColumnMapping("DesignWIPDate", "DesignWIPDate"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("ModelTemplateDate", "ModelTemplateDate"), New System.Data.Common.DataColumnMapping("Drafter", "Drafter"), New System.Data.Common.DataColumnMapping("DrafterComplete", "DrafterComplete"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerComplete", "EngineerComplete"), New System.Data.Common.DataColumnMapping("SrEngineer", "SrEngineer"), New System.Data.Common.DataColumnMapping("SrEngineerComplete", "SrEngineerComplete"), New System.Data.Common.DataColumnMapping("Releaser", "Releaser"), New System.Data.Common.DataColumnMapping("ReleaserCompelte", "ReleaserCompelte"), New System.Data.Common.DataColumnMapping("Flammability", "Flammability"), New System.Data.Common.DataColumnMapping("FlammabilityComplete", "FlammabilityComplete"), New System.Data.Common.DataColumnMapping("Stress", "Stress"), New System.Data.Common.DataColumnMapping("StressComplete", "StressComplete"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("RefID", "RefID"), New System.Data.Common.DataColumnMapping("DrafterPlannedCompleteDate", "DrafterPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("EngineerPlannedCompleteDate", "EngineerPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("SrEngineerPlannedCompleteDate", "SrEngineerPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("FlammabilityPlannedCompleteDate", "FlammabilityPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("StressPlannedCompleteDate", "StressPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("ReleaserPlannedCompleteDate", "ReleaserPlannedCompleteDate"), New System.Data.Common.DataColumnMapping("Avionics", "Avionics"), New System.Data.Common.DataColumnMapping("AvionicsComplete", "AvionicsComplete"), New System.Data.Common.DataColumnMapping("AvionicsPlannedComplete", "AvionicsPlannedComplete"), New System.Data.Common.DataColumnMapping("Mechanical", "Mechanical"), New System.Data.Common.DataColumnMapping("MechanicalComplete", "MechanicalComplete"), New System.Data.Common.DataColumnMapping("MechanicalPlannedComplete", "MechanicalPlannedComplete"), New System.Data.Common.DataColumnMapping("WONumber", "WONumber"), New System.Data.Common.DataColumnMapping("NextHigherAssembly", "NextHigherAssembly"), New System.Data.Common.DataColumnMapping("InstallationDrawing", "InstallationDrawing"), New System.Data.Common.DataColumnMapping("WhiteBoardNumber", "WhiteBoardNumber"), New System.Data.Common.DataColumnMapping("DRNADCN", "DRNADCN"), New System.Data.Common.DataColumnMapping("FAAProjectNo", "FAAProjectNo"), New System.Data.Common.DataColumnMapping("PSCPDocsRequired", "PSCPDocsRequired"), New System.Data.Common.DataColumnMapping("CompanyFlightTestRequired", "CompanyFlightTestRequired"), New System.Data.Common.DataColumnMapping("DwgReqDate", "DwgReqDate"), New System.Data.Common.DataColumnMapping("NewRework", "NewRework"), New System.Data.Common.DataColumnMapping("Updated", "Updated"), New System.Data.Common.DataColumnMapping("UpdatedDate", "UpdatedDate"), New System.Data.Common.DataColumnMapping("ADCN", "ADCN"), New System.Data.Common.DataColumnMapping("Visible", "Visible"), New System.Data.Common.DataColumnMapping("Seq", "Seq"), New System.Data.Common.DataColumnMapping("DCN", "DCN"), New System.Data.Common.DataColumnMapping("ProgramReal", "ProgramReal"), New System.Data.Common.DataColumnMapping("RevPurpose", "RevPurpose")})})
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsMainGrid
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl1.Location = New System.Drawing.Point(5, 62)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1508, 254)
        Me.GridControl1.TabIndex = 36
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgram, Me.colLocation, Me.colType, Me.colNewRework, Me.colPriority, Me.colDrawingNumber, Me.colDwgRevision, Me.colDrawingTitle, Me.colDRNADCN, Me.colADCN1, Me.colDrafter, Me.colStatus, Me.colWhiteBoardNumber, Me.colNotes, Me.colRecordID, Me.colDocumentType, Me.colDwgRequestBy, Me.colDwgRequestDate, Me.colDrawingType, Me.colSystemDescription, Me.colLastActionDate, Me.colActualFinishDate, Me.colForecastStartDate, Me.colForecastFinishDate, Me.colPlannedFinishDate, Me.colEstimatedDurationHours, Me.colPercentComplete, Me.colDrawingFolderAssignDate, Me.colDesignWIPDate, Me.colModelTemplateDate, Me.colDrafterComplete, Me.colEngineer, Me.colEngineerComplete, Me.colSrEngineer, Me.colSrEngineerComplete, Me.colReleaser, Me.colReleaserCompelte, Me.colFlammability, Me.colFlammabilityComplete, Me.colStress, Me.colStressComplete, Me.colRefID, Me.colDrafterPlannedCompleteDate, Me.colEngineerPlannedCompleteDate, Me.colSrEngineerPlannedCompleteDate, Me.colFlammabilityPlannedCompleteDate, Me.colStressPlannedCompleteDate, Me.colReleaserPlannedCompleteDate, Me.colAvionics, Me.colAvionicsComplete, Me.colAvionicsPlannedComplete, Me.colMechanical, Me.colMechanicalComplete, Me.colMechanicalPlannedComplete, Me.colWONumber, Me.colNextHigherAssembly, Me.colInstallationDrawing, Me.colFAAProjectNo, Me.colPSCPDocsRequired, Me.colCompanyFlightTestRequired, Me.colDwgReqDate, Me.colUpdated, Me.colUpdatedDate, Me.colSeq4, Me.colDCNUpperGrid, Me.colProgramReal, Me.colRevPurpose})
        Me.GridView1.DetailHeight = 227
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.LevelIndent = 0
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PreviewIndent = 0
        '
        'colProgram
        '
        Me.colProgram.Caption = "Project"
        Me.colProgram.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colProgram.FieldName = "Program"
        Me.colProgram.Name = "colProgram"
        Me.colProgram.OptionsColumn.ReadOnly = True
        Me.colProgram.Visible = True
        Me.colProgram.VisibleIndex = 4
        Me.colProgram.Width = 150
        '
        'colLocation
        '
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.OptionsColumn.ReadOnly = True
        '
        'colType
        '
        Me.colType.Caption = "Resource Type"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.OptionsColumn.ReadOnly = True
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 7
        Me.colType.Width = 140
        '
        'colNewRework
        '
        Me.colNewRework.FieldName = "NewRework"
        Me.colNewRework.Name = "colNewRework"
        Me.colNewRework.OptionsColumn.ReadOnly = True
        Me.colNewRework.Width = 192
        '
        'colPriority
        '
        Me.colPriority.Caption = "Milestone"
        Me.colPriority.FieldName = "Priority"
        Me.colPriority.Name = "colPriority"
        Me.colPriority.OptionsColumn.ReadOnly = True
        Me.colPriority.Visible = True
        Me.colPriority.VisibleIndex = 0
        '
        'colDrawingNumber
        '
        Me.colDrawingNumber.FieldName = "DrawingNumber"
        Me.colDrawingNumber.Name = "colDrawingNumber"
        Me.colDrawingNumber.OptionsColumn.ReadOnly = True
        Me.colDrawingNumber.Visible = True
        Me.colDrawingNumber.VisibleIndex = 1
        Me.colDrawingNumber.Width = 100
        '
        'colDwgRevision
        '
        Me.colDwgRevision.FieldName = "DwgRevision"
        Me.colDwgRevision.Name = "colDwgRevision"
        Me.colDwgRevision.OptionsColumn.ReadOnly = True
        '
        'colDrawingTitle
        '
        Me.colDrawingTitle.FieldName = "DrawingTitle"
        Me.colDrawingTitle.Name = "colDrawingTitle"
        Me.colDrawingTitle.OptionsColumn.ReadOnly = True
        Me.colDrawingTitle.Visible = True
        Me.colDrawingTitle.VisibleIndex = 2
        Me.colDrawingTitle.Width = 250
        '
        'colDRNADCN
        '
        Me.colDRNADCN.Caption = "DRN"
        Me.colDRNADCN.FieldName = "DRNADCN"
        Me.colDRNADCN.Name = "colDRNADCN"
        Me.colDRNADCN.OptionsColumn.ReadOnly = True
        '
        'colADCN1
        '
        Me.colADCN1.Caption = "ADCN"
        Me.colADCN1.FieldName = "ADCN"
        Me.colADCN1.Name = "colADCN1"
        Me.colADCN1.OptionsColumn.ReadOnly = True
        '
        'colDrafter
        '
        Me.colDrafter.FieldName = "Drafter"
        Me.colDrafter.Name = "colDrafter"
        Me.colDrafter.OptionsColumn.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 6
        Me.colStatus.Width = 250
        '
        'colWhiteBoardNumber
        '
        Me.colWhiteBoardNumber.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colWhiteBoardNumber.FieldName = "WhiteBoardNumber"
        Me.colWhiteBoardNumber.Name = "colWhiteBoardNumber"
        Me.colWhiteBoardNumber.OptionsColumn.ReadOnly = True
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.OptionsColumn.ReadOnly = True
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.Name = "colRecordID"
        '
        'colDocumentType
        '
        Me.colDocumentType.FieldName = "DocumentType"
        Me.colDocumentType.Name = "colDocumentType"
        '
        'colDwgRequestBy
        '
        Me.colDwgRequestBy.FieldName = "DwgRequestBy"
        Me.colDwgRequestBy.Name = "colDwgRequestBy"
        '
        'colDwgRequestDate
        '
        Me.colDwgRequestDate.FieldName = "DwgRequestDate"
        Me.colDwgRequestDate.Name = "colDwgRequestDate"
        '
        'colDrawingType
        '
        Me.colDrawingType.FieldName = "DrawingType"
        Me.colDrawingType.Name = "colDrawingType"
        '
        'colSystemDescription
        '
        Me.colSystemDescription.FieldName = "SystemDescription"
        Me.colSystemDescription.Name = "colSystemDescription"
        Me.colSystemDescription.Visible = True
        Me.colSystemDescription.VisibleIndex = 5
        Me.colSystemDescription.Width = 200
        '
        'colLastActionDate
        '
        Me.colLastActionDate.FieldName = "LastActionDate"
        Me.colLastActionDate.Name = "colLastActionDate"
        '
        'colActualFinishDate
        '
        Me.colActualFinishDate.FieldName = "ActualFinishDate"
        Me.colActualFinishDate.Name = "colActualFinishDate"
        '
        'colForecastStartDate
        '
        Me.colForecastStartDate.FieldName = "ForecastStartDate"
        Me.colForecastStartDate.Name = "colForecastStartDate"
        '
        'colForecastFinishDate
        '
        Me.colForecastFinishDate.FieldName = "ForecastFinishDate"
        Me.colForecastFinishDate.Name = "colForecastFinishDate"
        '
        'colPlannedFinishDate
        '
        Me.colPlannedFinishDate.FieldName = "PlannedFinishDate"
        Me.colPlannedFinishDate.Name = "colPlannedFinishDate"
        '
        'colEstimatedDurationHours
        '
        Me.colEstimatedDurationHours.FieldName = "EstimatedDurationHours"
        Me.colEstimatedDurationHours.Name = "colEstimatedDurationHours"
        '
        'colPercentComplete
        '
        Me.colPercentComplete.FieldName = "PercentComplete"
        Me.colPercentComplete.Name = "colPercentComplete"
        '
        'colDrawingFolderAssignDate
        '
        Me.colDrawingFolderAssignDate.FieldName = "DrawingFolderAssignDate"
        Me.colDrawingFolderAssignDate.Name = "colDrawingFolderAssignDate"
        '
        'colDesignWIPDate
        '
        Me.colDesignWIPDate.FieldName = "DesignWIPDate"
        Me.colDesignWIPDate.Name = "colDesignWIPDate"
        '
        'colModelTemplateDate
        '
        Me.colModelTemplateDate.FieldName = "ModelTemplateDate"
        Me.colModelTemplateDate.Name = "colModelTemplateDate"
        '
        'colDrafterComplete
        '
        Me.colDrafterComplete.FieldName = "DrafterComplete"
        Me.colDrafterComplete.Name = "colDrafterComplete"
        '
        'colEngineer
        '
        Me.colEngineer.FieldName = "Engineer"
        Me.colEngineer.Name = "colEngineer"
        '
        'colEngineerComplete
        '
        Me.colEngineerComplete.FieldName = "EngineerComplete"
        Me.colEngineerComplete.Name = "colEngineerComplete"
        '
        'colSrEngineer
        '
        Me.colSrEngineer.FieldName = "SrEngineer"
        Me.colSrEngineer.Name = "colSrEngineer"
        '
        'colSrEngineerComplete
        '
        Me.colSrEngineerComplete.FieldName = "SrEngineerComplete"
        Me.colSrEngineerComplete.Name = "colSrEngineerComplete"
        '
        'colReleaser
        '
        Me.colReleaser.FieldName = "Releaser"
        Me.colReleaser.Name = "colReleaser"
        '
        'colReleaserCompelte
        '
        Me.colReleaserCompelte.FieldName = "ReleaserCompelte"
        Me.colReleaserCompelte.Name = "colReleaserCompelte"
        '
        'colFlammability
        '
        Me.colFlammability.FieldName = "Flammability"
        Me.colFlammability.Name = "colFlammability"
        '
        'colFlammabilityComplete
        '
        Me.colFlammabilityComplete.FieldName = "FlammabilityComplete"
        Me.colFlammabilityComplete.Name = "colFlammabilityComplete"
        '
        'colStress
        '
        Me.colStress.FieldName = "Stress"
        Me.colStress.Name = "colStress"
        '
        'colStressComplete
        '
        Me.colStressComplete.FieldName = "StressComplete"
        Me.colStressComplete.Name = "colStressComplete"
        '
        'colRefID
        '
        Me.colRefID.FieldName = "RefID"
        Me.colRefID.Name = "colRefID"
        '
        'colDrafterPlannedCompleteDate
        '
        Me.colDrafterPlannedCompleteDate.FieldName = "DrafterPlannedCompleteDate"
        Me.colDrafterPlannedCompleteDate.Name = "colDrafterPlannedCompleteDate"
        '
        'colEngineerPlannedCompleteDate
        '
        Me.colEngineerPlannedCompleteDate.FieldName = "EngineerPlannedCompleteDate"
        Me.colEngineerPlannedCompleteDate.Name = "colEngineerPlannedCompleteDate"
        '
        'colSrEngineerPlannedCompleteDate
        '
        Me.colSrEngineerPlannedCompleteDate.FieldName = "SrEngineerPlannedCompleteDate"
        Me.colSrEngineerPlannedCompleteDate.Name = "colSrEngineerPlannedCompleteDate"
        '
        'colFlammabilityPlannedCompleteDate
        '
        Me.colFlammabilityPlannedCompleteDate.FieldName = "FlammabilityPlannedCompleteDate"
        Me.colFlammabilityPlannedCompleteDate.Name = "colFlammabilityPlannedCompleteDate"
        '
        'colStressPlannedCompleteDate
        '
        Me.colStressPlannedCompleteDate.FieldName = "StressPlannedCompleteDate"
        Me.colStressPlannedCompleteDate.Name = "colStressPlannedCompleteDate"
        '
        'colReleaserPlannedCompleteDate
        '
        Me.colReleaserPlannedCompleteDate.FieldName = "ReleaserPlannedCompleteDate"
        Me.colReleaserPlannedCompleteDate.Name = "colReleaserPlannedCompleteDate"
        '
        'colAvionics
        '
        Me.colAvionics.FieldName = "Avionics"
        Me.colAvionics.Name = "colAvionics"
        '
        'colAvionicsComplete
        '
        Me.colAvionicsComplete.FieldName = "AvionicsComplete"
        Me.colAvionicsComplete.Name = "colAvionicsComplete"
        '
        'colAvionicsPlannedComplete
        '
        Me.colAvionicsPlannedComplete.FieldName = "AvionicsPlannedComplete"
        Me.colAvionicsPlannedComplete.Name = "colAvionicsPlannedComplete"
        '
        'colMechanical
        '
        Me.colMechanical.FieldName = "Mechanical"
        Me.colMechanical.Name = "colMechanical"
        '
        'colMechanicalComplete
        '
        Me.colMechanicalComplete.FieldName = "MechanicalComplete"
        Me.colMechanicalComplete.Name = "colMechanicalComplete"
        '
        'colMechanicalPlannedComplete
        '
        Me.colMechanicalPlannedComplete.FieldName = "MechanicalPlannedComplete"
        Me.colMechanicalPlannedComplete.Name = "colMechanicalPlannedComplete"
        '
        'colWONumber
        '
        Me.colWONumber.FieldName = "WONumber"
        Me.colWONumber.Name = "colWONumber"
        '
        'colNextHigherAssembly
        '
        Me.colNextHigherAssembly.FieldName = "NextHigherAssembly"
        Me.colNextHigherAssembly.Name = "colNextHigherAssembly"
        Me.colNextHigherAssembly.Visible = True
        Me.colNextHigherAssembly.VisibleIndex = 8
        Me.colNextHigherAssembly.Width = 169
        '
        'colInstallationDrawing
        '
        Me.colInstallationDrawing.FieldName = "InstallationDrawing"
        Me.colInstallationDrawing.Name = "colInstallationDrawing"
        '
        'colFAAProjectNo
        '
        Me.colFAAProjectNo.FieldName = "FAAProjectNo"
        Me.colFAAProjectNo.Name = "colFAAProjectNo"
        '
        'colPSCPDocsRequired
        '
        Me.colPSCPDocsRequired.FieldName = "PSCPDocsRequired"
        Me.colPSCPDocsRequired.Name = "colPSCPDocsRequired"
        '
        'colCompanyFlightTestRequired
        '
        Me.colCompanyFlightTestRequired.FieldName = "CompanyFlightTestRequired"
        Me.colCompanyFlightTestRequired.Name = "colCompanyFlightTestRequired"
        '
        'colDwgReqDate
        '
        Me.colDwgReqDate.FieldName = "DwgReqDate"
        Me.colDwgReqDate.Name = "colDwgReqDate"
        '
        'colUpdated
        '
        Me.colUpdated.FieldName = "Updated"
        Me.colUpdated.Name = "colUpdated"
        '
        'colUpdatedDate
        '
        Me.colUpdatedDate.FieldName = "UpdatedDate"
        Me.colUpdatedDate.Name = "colUpdatedDate"
        '
        'colSeq4
        '
        Me.colSeq4.FieldName = "Seq"
        Me.colSeq4.Name = "colSeq4"
        '
        'colDCNUpperGrid
        '
        Me.colDCNUpperGrid.FieldName = "DCN"
        Me.colDCNUpperGrid.Name = "colDCNUpperGrid"
        Me.colDCNUpperGrid.Width = 117
        '
        'colProgramReal
        '
        Me.colProgramReal.Caption = "Program"
        Me.colProgramReal.FieldName = "ProgramReal"
        Me.colProgramReal.Name = "colProgramReal"
        Me.colProgramReal.Visible = True
        Me.colProgramReal.VisibleIndex = 3
        Me.colProgramReal.Width = 127
        '
        'colRevPurpose
        '
        Me.colRevPurpose.FieldName = "RevPurpose"
        Me.colRevPurpose.Name = "colRevPurpose"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(609, 28)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(38, 13)
        Me.Label31.TabIndex = 37
        Me.Label31.Text = "VIEW:"
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT RecordID, DwgRecordID, UMName, UMSpecialty, UMRecommendApproval, UMApprova" &
    "l, RequiredToApprove, Comments, DateSubmitted, DateNeeded, DateCommentsReturned" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   tblDrawingCertUMApproval"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DwgRecordID", System.Data.SqlDbType.Int, 0, "DwgRecordID"), New System.Data.SqlClient.SqlParameter("@UMName", System.Data.SqlDbType.NVarChar, 0, "UMName"), New System.Data.SqlClient.SqlParameter("@UMSpecialty", System.Data.SqlDbType.NVarChar, 0, "UMSpecialty"), New System.Data.SqlClient.SqlParameter("@UMRecommendApproval", System.Data.SqlDbType.NVarChar, 0, "UMRecommendApproval"), New System.Data.SqlClient.SqlParameter("@UMApproval", System.Data.SqlDbType.NVarChar, 0, "UMApproval"), New System.Data.SqlClient.SqlParameter("@RequiredToApprove", System.Data.SqlDbType.Bit, 0, "RequiredToApprove"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments"), New System.Data.SqlClient.SqlParameter("@DateSubmitted", System.Data.SqlDbType.[Date], 0, "DateSubmitted"), New System.Data.SqlClient.SqlParameter("@DateNeeded", System.Data.SqlDbType.[Date], 0, "DateNeeded"), New System.Data.SqlClient.SqlParameter("@DateCommentsReturned", System.Data.SqlDbType.[Date], 0, "DateCommentsReturned")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DwgRecordID", System.Data.SqlDbType.Int, 0, "DwgRecordID"), New System.Data.SqlClient.SqlParameter("@UMName", System.Data.SqlDbType.NVarChar, 0, "UMName"), New System.Data.SqlClient.SqlParameter("@UMSpecialty", System.Data.SqlDbType.NVarChar, 0, "UMSpecialty"), New System.Data.SqlClient.SqlParameter("@UMRecommendApproval", System.Data.SqlDbType.NVarChar, 0, "UMRecommendApproval"), New System.Data.SqlClient.SqlParameter("@UMApproval", System.Data.SqlDbType.NVarChar, 0, "UMApproval"), New System.Data.SqlClient.SqlParameter("@RequiredToApprove", System.Data.SqlDbType.Bit, 0, "RequiredToApprove"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments"), New System.Data.SqlClient.SqlParameter("@DateSubmitted", System.Data.SqlDbType.[Date], 0, "DateSubmitted"), New System.Data.SqlClient.SqlParameter("@DateNeeded", System.Data.SqlDbType.[Date], 0, "DateNeeded"), New System.Data.SqlClient.SqlParameter("@DateCommentsReturned", System.Data.SqlDbType.[Date], 0, "DateCommentsReturned"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMSpecialty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMSpecialty", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMSpecialty", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMSpecialty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMRecommendApproval", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMRecommendApproval", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMRecommendApproval", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMRecommendApproval", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMApproval", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMApproval", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMApproval", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMApproval", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RequiredToApprove", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RequiredToApprove", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RequiredToApprove", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequiredToApprove", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateSubmitted", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateSubmitted", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateSubmitted", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateSubmitted", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateNeeded", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateNeeded", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateNeeded", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateNeeded", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateCommentsReturned", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateCommentsReturned", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateCommentsReturned", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateCommentsReturned", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMSpecialty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMSpecialty", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMSpecialty", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMSpecialty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMRecommendApproval", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMRecommendApproval", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMRecommendApproval", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMRecommendApproval", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UMApproval", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UMApproval", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UMApproval", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UMApproval", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RequiredToApprove", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RequiredToApprove", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RequiredToApprove", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequiredToApprove", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateSubmitted", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateSubmitted", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateSubmitted", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateSubmitted", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateNeeded", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateNeeded", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateNeeded", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateNeeded", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateCommentsReturned", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateCommentsReturned", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateCommentsReturned", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateCommentsReturned", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter3.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawingCertUMApproval", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DwgRecordID", "DwgRecordID"), New System.Data.Common.DataColumnMapping("UMName", "UMName"), New System.Data.Common.DataColumnMapping("UMSpecialty", "UMSpecialty"), New System.Data.Common.DataColumnMapping("UMRecommendApproval", "UMRecommendApproval"), New System.Data.Common.DataColumnMapping("UMApproval", "UMApproval"), New System.Data.Common.DataColumnMapping("RequiredToApprove", "RequiredToApprove"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("DateSubmitted", "DateSubmitted"), New System.Data.Common.DataColumnMapping("DateNeeded", "DateNeeded"), New System.Data.Common.DataColumnMapping("DateCommentsReturned", "DateCommentsReturned")})})
        Me.SqlDataAdapter3.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT        RecordID, DwgRecordID, FAAOMTName, FAAOMTSpecialty, FAAOMTRecommend" &
    "Approval, FAAOMTApproval, RequiredToApprove, Comments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblDrawin" &
    "gCertFAAOMTApproval"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
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
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter4.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawingCertFAAOMTApproval", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DwgRecordID", "DwgRecordID"), New System.Data.Common.DataColumnMapping("FAAOMTName", "FAAOMTName"), New System.Data.Common.DataColumnMapping("FAAOMTSpecialty", "FAAOMTSpecialty"), New System.Data.Common.DataColumnMapping("FAAOMTRecommendApproval", "FAAOMTRecommendApproval"), New System.Data.Common.DataColumnMapping("FAAOMTApproval", "FAAOMTApproval"), New System.Data.Common.DataColumnMapping("RequiredToApprove", "RequiredToApprove"), New System.Data.Common.DataColumnMapping("Comments", "Comments")})})
        Me.SqlDataAdapter4.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT        tblDrawingCertAttachments.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblDrawingCertAttachme" &
    "nts"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
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
        'SqlDataAdapter5
        '
        Me.SqlDataAdapter5.DeleteCommand = Me.SqlDeleteCommand3
        Me.SqlDataAdapter5.InsertCommand = Me.SqlInsertCommand3
        Me.SqlDataAdapter5.SelectCommand = Me.SqlSelectCommand5
        Me.SqlDataAdapter5.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawingCertAttachments", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DwgRecordID", "DwgRecordID"), New System.Data.Common.DataColumnMapping("FilePath", "FilePath"), New System.Data.Common.DataColumnMapping("FileDescription", "FileDescription"), New System.Data.Common.DataColumnMapping("ImgField", "ImgField"), New System.Data.Common.DataColumnMapping("FileName", "FileName"), New System.Data.Common.DataColumnMapping("FileExt", "FileExt")})})
        Me.SqlDataAdapter5.UpdateCommand = Me.SqlUpdateCommand3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblCanceled
        '
        Me.lblCanceled.AutoSize = True
        Me.lblCanceled.BackColor = System.Drawing.Color.Red
        Me.lblCanceled.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanceled.Location = New System.Drawing.Point(751, 329)
        Me.lblCanceled.Name = "lblCanceled"
        Me.lblCanceled.Size = New System.Drawing.Size(311, 25)
        Me.lblCanceled.TabIndex = 40
        Me.lblCanceled.Text = "DOCUMENT IS CANCELLED"
        Me.lblCanceled.Visible = False
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT        tblAttachments.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblAttachments"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=engdwgtest;Persist Security Info=" &
    "True;User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DwgRecordID", System.Data.SqlDbType.Int, 0, "DwgRecordID"), New System.Data.SqlClient.SqlParameter("@Target", System.Data.SqlDbType.NVarChar, 0, "Target"), New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.NVarChar, 0, "FileName"), New System.Data.SqlClient.SqlParameter("@IsActualDoc", System.Data.SqlDbType.Bit, 0, "IsActualDoc"), New System.Data.SqlClient.SqlParameter("@FileDescription", System.Data.SqlDbType.NVarChar, 0, "FileDescription")})
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DwgRecordID", System.Data.SqlDbType.Int, 0, "DwgRecordID"), New System.Data.SqlClient.SqlParameter("@Target", System.Data.SqlDbType.NVarChar, 0, "Target"), New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.NVarChar, 0, "FileName"), New System.Data.SqlClient.SqlParameter("@IsActualDoc", System.Data.SqlDbType.Bit, 0, "IsActualDoc"), New System.Data.SqlClient.SqlParameter("@FileDescription", System.Data.SqlDbType.NVarChar, 0, "FileDescription"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Target", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Target", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Target", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Target", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IsActualDoc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IsActualDoc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IsActualDoc", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IsActualDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Target", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Target", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Target", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Target", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IsActualDoc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IsActualDoc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IsActualDoc", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IsActualDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileDescription", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter6
        '
        Me.SqlDataAdapter6.DeleteCommand = Me.SqlDeleteCommand4
        Me.SqlDataAdapter6.InsertCommand = Me.SqlInsertCommand4
        Me.SqlDataAdapter6.SelectCommand = Me.SqlSelectCommand6
        Me.SqlDataAdapter6.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblAttachments", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DwgRecordID", "DwgRecordID"), New System.Data.Common.DataColumnMapping("Target", "Target"), New System.Data.Common.DataColumnMapping("FileName", "FileName"), New System.Data.Common.DataColumnMapping("IsActualDoc", "IsActualDoc"), New System.Data.Common.DataColumnMapping("FileDescription", "FileDescription")})})
        Me.SqlDataAdapter6.UpdateCommand = Me.SqlUpdateCommand4
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblRecordDeleted
        '
        Me.lblRecordDeleted.AutoSize = True
        Me.lblRecordDeleted.BackColor = System.Drawing.Color.Red
        Me.lblRecordDeleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordDeleted.Location = New System.Drawing.Point(1080, 329)
        Me.lblRecordDeleted.Name = "lblRecordDeleted"
        Me.lblRecordDeleted.Size = New System.Drawing.Size(236, 25)
        Me.lblRecordDeleted.TabIndex = 41
        Me.lblRecordDeleted.Text = "RECORD OBSOLETE"
        '
        'lblTasksPending
        '
        Me.lblTasksPending.AutoSize = True
        Me.lblTasksPending.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblTasksPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTasksPending.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTasksPending.Location = New System.Drawing.Point(286, 9)
        Me.lblTasksPending.Name = "lblTasksPending"
        Me.lblTasksPending.Size = New System.Drawing.Size(52, 13)
        Me.lblTasksPending.TabIndex = 43
        Me.lblTasksPending.Text = "Label52"
        '
        'btnShowTree
        '
        Me.btnShowTree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowTree.Location = New System.Drawing.Point(604, 321)
        Me.btnShowTree.Name = "btnShowTree"
        Me.btnShowTree.Size = New System.Drawing.Size(141, 49)
        Me.btnShowTree.TabIndex = 48
        Me.btnShowTree.Text = "Display Document Tree"
        Me.btnShowTree.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT        RecordID, RecordIDParent, ProjectName, ProjectNumber, ProgramName, " &
    "ProgramNumber, System, DrawingNumber" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tblDrawingsProjects"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection2
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection2
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RecordIDParent", System.Data.SqlDbType.Int, 0, "RecordIDParent"), New System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.NVarChar, 0, "ProjectName"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.NVarChar, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@ProgramNumber", System.Data.SqlDbType.NVarChar, 0, "ProgramNumber"), New System.Data.SqlClient.SqlParameter("@System", System.Data.SqlDbType.NVarChar, 0, "System"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber")})
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RecordIDParent", System.Data.SqlDbType.Int, 0, "RecordIDParent"), New System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.NVarChar, 0, "ProjectName"), New System.Data.SqlClient.SqlParameter("@ProjectNumber", System.Data.SqlDbType.NVarChar, 0, "ProjectNumber"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@ProgramNumber", System.Data.SqlDbType.NVarChar, 0, "ProgramNumber"), New System.Data.SqlClient.SqlParameter("@System", System.Data.SqlDbType.NVarChar, 0, "System"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RecordIDParent", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RecordIDParent", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RecordIDParent", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordIDParent", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_System", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "System", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_System", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "System", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RecordIDParent", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RecordIDParent", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RecordIDParent", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordIDParent", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProjectNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProjectNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProjectNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_System", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "System", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_System", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "System", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daDrawingsProjects
        '
        Me.daDrawingsProjects.DeleteCommand = Me.SqlDeleteCommand5
        Me.daDrawingsProjects.InsertCommand = Me.SqlInsertCommand5
        Me.daDrawingsProjects.SelectCommand = Me.SqlSelectCommand7
        Me.daDrawingsProjects.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawingsProjects", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("RecordIDParent", "RecordIDParent"), New System.Data.Common.DataColumnMapping("ProjectName", "ProjectName"), New System.Data.Common.DataColumnMapping("ProjectNumber", "ProjectNumber"), New System.Data.Common.DataColumnMapping("ProgramName", "ProgramName"), New System.Data.Common.DataColumnMapping("ProgramNumber", "ProgramNumber"), New System.Data.Common.DataColumnMapping("System", "System"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber")})})
        Me.daDrawingsProjects.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=engdwgtest;Persist Security Info=" &
    "True;User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection3.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = resources.GetString("SqlSelectCommand8.CommandText")
        Me.SqlSelectCommand8.Connection = Me.SqlConnection2
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = resources.GetString("SqlInsertCommand6.CommandText")
        Me.SqlInsertCommand6.Connection = Me.SqlConnection2
        Me.SqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NextHigherAssembly", System.Data.SqlDbType.NVarChar, 0, "NextHigherAssembly"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DrawingTitle", System.Data.SqlDbType.NVarChar, 0, "DrawingTitle"), New System.Data.SqlClient.SqlParameter("@SystemDescription", System.Data.SqlDbType.NVarChar, 0, "SystemDescription"), New System.Data.SqlClient.SqlParameter("@DrawingNumOriginal", System.Data.SqlDbType.NVarChar, 0, "DrawingNumOriginal"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@Seq", System.Data.SqlDbType.NVarChar, 0, "Seq"), New System.Data.SqlClient.SqlParameter("@DrawingOrReport", System.Data.SqlDbType.NVarChar, 0, "DrawingOrReport"), New System.Data.SqlClient.SqlParameter("@NewRework", System.Data.SqlDbType.NVarChar, 0, "NewRework"), New System.Data.SqlClient.SqlParameter("@RecordIDFromDrawings", System.Data.SqlDbType.Int, 0, "RecordIDFromDrawings"), New System.Data.SqlClient.SqlParameter("@DocumentType", System.Data.SqlDbType.NVarChar, 0, "DocumentType"), New System.Data.SqlClient.SqlParameter("@Priority", System.Data.SqlDbType.NVarChar, 0, "Priority"), New System.Data.SqlClient.SqlParameter("@DwgReqDate", System.Data.SqlDbType.NVarChar, 0, "DwgReqDate"), New System.Data.SqlClient.SqlParameter("@ADCN", System.Data.SqlDbType.NVarChar, 0, "ADCN"), New System.Data.SqlClient.SqlParameter("@DrawingType", System.Data.SqlDbType.NVarChar, 0, "DrawingType"), New System.Data.SqlClient.SqlParameter("@DCN", System.Data.SqlDbType.NVarChar, 0, "DCN"), New System.Data.SqlClient.SqlParameter("@RowNumber", System.Data.SqlDbType.NVarChar, 0, "RowNumber"), New System.Data.SqlClient.SqlParameter("@DwgRevisionOriginal", System.Data.SqlDbType.NVarChar, 0, "DwgRevisionOriginal")})
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = resources.GetString("SqlUpdateCommand6.CommandText")
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NextHigherAssembly", System.Data.SqlDbType.NVarChar, 0, "NextHigherAssembly"), New System.Data.SqlClient.SqlParameter("@DrawingNumber", System.Data.SqlDbType.NVarChar, 0, "DrawingNumber"), New System.Data.SqlClient.SqlParameter("@DrawingTitle", System.Data.SqlDbType.NVarChar, 0, "DrawingTitle"), New System.Data.SqlClient.SqlParameter("@SystemDescription", System.Data.SqlDbType.NVarChar, 0, "SystemDescription"), New System.Data.SqlClient.SqlParameter("@DrawingNumOriginal", System.Data.SqlDbType.NVarChar, 0, "DrawingNumOriginal"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@DwgRevision", System.Data.SqlDbType.NVarChar, 0, "DwgRevision"), New System.Data.SqlClient.SqlParameter("@Seq", System.Data.SqlDbType.NVarChar, 0, "Seq"), New System.Data.SqlClient.SqlParameter("@DrawingOrReport", System.Data.SqlDbType.NVarChar, 0, "DrawingOrReport"), New System.Data.SqlClient.SqlParameter("@NewRework", System.Data.SqlDbType.NVarChar, 0, "NewRework"), New System.Data.SqlClient.SqlParameter("@RecordIDFromDrawings", System.Data.SqlDbType.Int, 0, "RecordIDFromDrawings"), New System.Data.SqlClient.SqlParameter("@DocumentType", System.Data.SqlDbType.NVarChar, 0, "DocumentType"), New System.Data.SqlClient.SqlParameter("@Priority", System.Data.SqlDbType.NVarChar, 0, "Priority"), New System.Data.SqlClient.SqlParameter("@DwgReqDate", System.Data.SqlDbType.NVarChar, 0, "DwgReqDate"), New System.Data.SqlClient.SqlParameter("@ADCN", System.Data.SqlDbType.NVarChar, 0, "ADCN"), New System.Data.SqlClient.SqlParameter("@DrawingType", System.Data.SqlDbType.NVarChar, 0, "DrawingType"), New System.Data.SqlClient.SqlParameter("@DCN", System.Data.SqlDbType.NVarChar, 0, "DCN"), New System.Data.SqlClient.SqlParameter("@RowNumber", System.Data.SqlDbType.NVarChar, 0, "RowNumber"), New System.Data.SqlClient.SqlParameter("@DwgRevisionOriginal", System.Data.SqlDbType.NVarChar, 0, "DwgRevisionOriginal"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NextHigherAssembly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NextHigherAssembly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NextHigherAssembly", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextHigherAssembly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SystemDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SystemDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumOriginal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumOriginal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumOriginal", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumOriginal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Seq", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Seq", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Seq", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Seq", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingOrReport", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingOrReport", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingOrReport", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingOrReport", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NewRework", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NewRework", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NewRework", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NewRework", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RecordIDFromDrawings", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RecordIDFromDrawings", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RecordIDFromDrawings", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordIDFromDrawings", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocumentType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocumentType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Priority", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Priority", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgReqDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgReqDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgReqDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgReqDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ADCN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ADCN", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ADCN", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ADCN", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DCN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DCN", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DCN", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DCN", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RowNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RowNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RowNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RowNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevisionOriginal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevisionOriginal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevisionOriginal", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevisionOriginal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = resources.GetString("SqlDeleteCommand6.CommandText")
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NextHigherAssembly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NextHigherAssembly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NextHigherAssembly", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextHigherAssembly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SystemDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SystemDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SystemDescription", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNumOriginal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNumOriginal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNumOriginal", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNumOriginal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Seq", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Seq", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Seq", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Seq", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingOrReport", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingOrReport", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingOrReport", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingOrReport", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_NewRework", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NewRework", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_NewRework", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NewRework", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RecordIDFromDrawings", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RecordIDFromDrawings", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RecordIDFromDrawings", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordIDFromDrawings", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DocumentType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DocumentType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DocumentType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Priority", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Priority", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Priority", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgReqDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgReqDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgReqDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgReqDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ADCN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ADCN", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ADCN", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ADCN", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DCN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DCN", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DCN", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DCN", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RowNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RowNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RowNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RowNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DwgRevisionOriginal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DwgRevisionOriginal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DwgRevisionOriginal", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DwgRevisionOriginal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daAssemblies
        '
        Me.daAssemblies.DeleteCommand = Me.SqlDeleteCommand6
        Me.daAssemblies.InsertCommand = Me.SqlInsertCommand6
        Me.daAssemblies.SelectCommand = Me.SqlSelectCommand8
        Me.daAssemblies.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblTree", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("NextHigherAssembly", "NextHigherAssembly"), New System.Data.Common.DataColumnMapping("DrawingNumber", "DrawingNumber"), New System.Data.Common.DataColumnMapping("DrawingTitle", "DrawingTitle"), New System.Data.Common.DataColumnMapping("SystemDescription", "SystemDescription"), New System.Data.Common.DataColumnMapping("DrawingNumOriginal", "DrawingNumOriginal"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("DwgRevision", "DwgRevision"), New System.Data.Common.DataColumnMapping("Seq", "Seq"), New System.Data.Common.DataColumnMapping("DrawingOrReport", "DrawingOrReport"), New System.Data.Common.DataColumnMapping("NewRework", "NewRework"), New System.Data.Common.DataColumnMapping("RecordIDFromDrawings", "RecordIDFromDrawings"), New System.Data.Common.DataColumnMapping("DocumentType", "DocumentType"), New System.Data.Common.DataColumnMapping("Priority", "Priority"), New System.Data.Common.DataColumnMapping("DwgReqDate", "DwgReqDate"), New System.Data.Common.DataColumnMapping("ADCN", "ADCN"), New System.Data.Common.DataColumnMapping("DrawingType", "DrawingType"), New System.Data.Common.DataColumnMapping("DCN", "DCN"), New System.Data.Common.DataColumnMapping("RowNumber", "RowNumber"), New System.Data.Common.DataColumnMapping("DwgRevisionOriginal", "DwgRevisionOriginal")})})
        Me.daAssemblies.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = resources.GetString("SqlSelectCommand9.CommandText")
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = resources.GetString("SqlInsertCommand7.CommandText")
        Me.SqlInsertCommand7.Connection = Me.SqlConnection1
        Me.SqlInsertCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DrawingNum", System.Data.SqlDbType.NVarChar, 0, "DrawingNum"), New System.Data.SqlClient.SqlParameter("@Rev", System.Data.SqlDbType.NVarChar, 0, "Rev"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@RequestBy", System.Data.SqlDbType.NVarChar, 0, "RequestBy"), New System.Data.SqlClient.SqlParameter("@RedlineDate", System.Data.SqlDbType.NVarChar, 0, "RedlineDate"), New System.Data.SqlClient.SqlParameter("@IndexNum", System.Data.SqlDbType.Int, 0, "IndexNum"), New System.Data.SqlClient.SqlParameter("@IncorporatedRev", System.Data.SqlDbType.NVarChar, 0, "IncorporatedRev"), New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.NVarChar, 0, "FileName"), New System.Data.SqlClient.SqlParameter("@RedlineNumber", System.Data.SqlDbType.NVarChar, 0, "RedlineNumber"), New System.Data.SqlClient.SqlParameter("@RedlineCount", System.Data.SqlDbType.Int, 0, "RedlineCount"), New System.Data.SqlClient.SqlParameter("@LiaisonSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "LiaisonSignedOffBy"), New System.Data.SqlClient.SqlParameter("@LiaisonSignedOffDate", System.Data.SqlDbType.NVarChar, 0, "LiaisonSignedOffDate"), New System.Data.SqlClient.SqlParameter("@OperationsSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "OperationsSignedOffBy"), New System.Data.SqlClient.SqlParameter("@OperationsSignedOffDate", System.Data.SqlDbType.NVarChar, 0, "OperationsSignedOffDate"), New System.Data.SqlClient.SqlParameter("@DesignEngSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "DesignEngSignedOffBy"), New System.Data.SqlClient.SqlParameter("@DesignEngSignedOffDate", System.Data.SqlDbType.NVarChar, 0, "DesignEngSignedOffDate")})
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = resources.GetString("SqlUpdateCommand7.CommandText")
        Me.SqlUpdateCommand7.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DrawingNum", System.Data.SqlDbType.NVarChar, 0, "DrawingNum"), New System.Data.SqlClient.SqlParameter("@Rev", System.Data.SqlDbType.NVarChar, 0, "Rev"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@RequestBy", System.Data.SqlDbType.NVarChar, 0, "RequestBy"), New System.Data.SqlClient.SqlParameter("@RedlineDate", System.Data.SqlDbType.NVarChar, 0, "RedlineDate"), New System.Data.SqlClient.SqlParameter("@IndexNum", System.Data.SqlDbType.Int, 0, "IndexNum"), New System.Data.SqlClient.SqlParameter("@IncorporatedRev", System.Data.SqlDbType.NVarChar, 0, "IncorporatedRev"), New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.NVarChar, 0, "FileName"), New System.Data.SqlClient.SqlParameter("@RedlineNumber", System.Data.SqlDbType.NVarChar, 0, "RedlineNumber"), New System.Data.SqlClient.SqlParameter("@RedlineCount", System.Data.SqlDbType.Int, 0, "RedlineCount"), New System.Data.SqlClient.SqlParameter("@LiaisonSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "LiaisonSignedOffBy"), New System.Data.SqlClient.SqlParameter("@LiaisonSignedOffDate", System.Data.SqlDbType.NVarChar, 0, "LiaisonSignedOffDate"), New System.Data.SqlClient.SqlParameter("@OperationsSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "OperationsSignedOffBy"), New System.Data.SqlClient.SqlParameter("@OperationsSignedOffDate", System.Data.SqlDbType.NVarChar, 0, "OperationsSignedOffDate"), New System.Data.SqlClient.SqlParameter("@DesignEngSignedOffBy", System.Data.SqlDbType.NVarChar, 0, "DesignEngSignedOffBy"), New System.Data.SqlClient.SqlParameter("@DesignEngSignedOffDate", System.Data.SqlDbType.NVarChar, 0, "DesignEngSignedOffDate"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Rev", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Rev", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Rev", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Rev", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RequestBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RequestBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RequestBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequestBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RedlineDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RedlineDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RedlineDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RedlineDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IndexNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IndexNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IndexNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndexNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IncorporatedRev", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IncorporatedRev", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IncorporatedRev", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorporatedRev", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RedlineNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RedlineNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RedlineNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RedlineNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RedlineCount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RedlineCount", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RedlineCount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RedlineCount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonSignedOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonSignedOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonSignedOffDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonSignedOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OperationsSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OperationsSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OperationsSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OperationsSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OperationsSignedOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OperationsSignedOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OperationsSignedOffDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OperationsSignedOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignEngSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignEngSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignEngSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignEngSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignEngSignedOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignEngSignedOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignEngSignedOffDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignEngSignedOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = resources.GetString("SqlDeleteCommand7.CommandText")
        Me.SqlDeleteCommand7.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawingNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawingNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawingNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawingNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Rev", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Rev", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Rev", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Rev", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RequestBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RequestBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RequestBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequestBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RedlineDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RedlineDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RedlineDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RedlineDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IndexNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IndexNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IndexNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndexNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IncorporatedRev", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IncorporatedRev", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IncorporatedRev", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncorporatedRev", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FileName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RedlineNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RedlineNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RedlineNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RedlineNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RedlineCount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RedlineCount", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RedlineCount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RedlineCount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonSignedOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonSignedOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonSignedOffDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonSignedOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OperationsSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OperationsSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OperationsSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OperationsSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OperationsSignedOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OperationsSignedOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OperationsSignedOffDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OperationsSignedOffDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignEngSignedOffBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignEngSignedOffBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignEngSignedOffBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignEngSignedOffBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DesignEngSignedOffDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DesignEngSignedOffDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DesignEngSignedOffDate", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesignEngSignedOffDate", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daRedlines
        '
        Me.daRedlines.DeleteCommand = Me.SqlDeleteCommand7
        Me.daRedlines.InsertCommand = Me.SqlInsertCommand7
        Me.daRedlines.SelectCommand = Me.SqlSelectCommand9
        Me.daRedlines.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblRedlines", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("DrawingNum", "DrawingNum"), New System.Data.Common.DataColumnMapping("Rev", "Rev"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("RequestBy", "RequestBy"), New System.Data.Common.DataColumnMapping("RedlineDate", "RedlineDate"), New System.Data.Common.DataColumnMapping("IndexNum", "IndexNum"), New System.Data.Common.DataColumnMapping("IncorporatedRev", "IncorporatedRev"), New System.Data.Common.DataColumnMapping("FileName", "FileName"), New System.Data.Common.DataColumnMapping("RedlineNumber", "RedlineNumber"), New System.Data.Common.DataColumnMapping("RedlineCount", "RedlineCount"), New System.Data.Common.DataColumnMapping("LiaisonSignedOffBy", "LiaisonSignedOffBy"), New System.Data.Common.DataColumnMapping("LiaisonSignedOffDate", "LiaisonSignedOffDate"), New System.Data.Common.DataColumnMapping("OperationsSignedOffBy", "OperationsSignedOffBy"), New System.Data.Common.DataColumnMapping("OperationsSignedOffDate", "OperationsSignedOffDate"), New System.Data.Common.DataColumnMapping("DesignEngSignedOffBy", "DesignEngSignedOffBy"), New System.Data.Common.DataColumnMapping("DesignEngSignedOffDate", "DesignEngSignedOffDate")})})
        Me.daRedlines.UpdateCommand = Me.SqlUpdateCommand7
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = resources.GetString("SqlSelectCommand10.CommandText")
        Me.SqlSelectCommand10.Connection = Me.SqlConnection4
        '
        'SqlConnection4
        '
        Me.SqlConnection4.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=EARR;Persist Security Info=True;U" &
    "ser ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection4.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = resources.GetString("SqlInsertCommand8.CommandText")
        Me.SqlInsertCommand8.Connection = Me.SqlConnection4
        Me.SqlInsertCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Earr", System.Data.SqlDbType.NVarChar, 0, "Earr"), New System.Data.SqlClient.SqlParameter("@IssueNumber", System.Data.SqlDbType.NVarChar, 0, "IssueNumber"), New System.Data.SqlClient.SqlParameter("@DrawNum", System.Data.SqlDbType.NVarChar, 0, "DrawNum"), New System.Data.SqlClient.SqlParameter("@Rev", System.Data.SqlDbType.NVarChar, 0, "Rev"), New System.Data.SqlClient.SqlParameter("@DrawNumRev", System.Data.SqlDbType.NVarChar, 0, "DrawNumRev"), New System.Data.SqlClient.SqlParameter("@DrawTitle", System.Data.SqlDbType.NVarChar, 0, "DrawTitle"), New System.Data.SqlClient.SqlParameter("@Response", System.Data.SqlDbType.NVarChar, 0, "Response"), New System.Data.SqlClient.SqlParameter("@IssueType", System.Data.SqlDbType.NVarChar, 0, "IssueType"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@OriginatorDate", System.Data.SqlDbType.[Date], 0, "OriginatorDate"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.[Date], 0, "DateClosed"), New System.Data.SqlClient.SqlParameter("@Request", System.Data.SqlDbType.NVarChar, 0, "Request"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@DateIncorporated", System.Data.SqlDbType.[Date], 0, "DateIncorporated"), New System.Data.SqlClient.SqlParameter("@Project", System.Data.SqlDbType.NVarChar, 0, "Project"), New System.Data.SqlClient.SqlParameter("@EQNNumber", System.Data.SqlDbType.NVarChar, 0, "EQNNumber"), New System.Data.SqlClient.SqlParameter("@Category", System.Data.SqlDbType.NVarChar, 0, "Category"), New System.Data.SqlClient.SqlParameter("@ERAS", System.Data.SqlDbType.NVarChar, 0, "ERAS"), New System.Data.SqlClient.SqlParameter("@DateERASUpdated", System.Data.SqlDbType.[Date], 0, "DateERASUpdated"), New System.Data.SqlClient.SqlParameter("@ERASUpdatedBy", System.Data.SqlDbType.NVarChar, 0, "ERASUpdatedBy")})
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = resources.GetString("SqlUpdateCommand8.CommandText")
        Me.SqlUpdateCommand8.Connection = Me.SqlConnection4
        Me.SqlUpdateCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Earr", System.Data.SqlDbType.NVarChar, 0, "Earr"), New System.Data.SqlClient.SqlParameter("@IssueNumber", System.Data.SqlDbType.NVarChar, 0, "IssueNumber"), New System.Data.SqlClient.SqlParameter("@DrawNum", System.Data.SqlDbType.NVarChar, 0, "DrawNum"), New System.Data.SqlClient.SqlParameter("@Rev", System.Data.SqlDbType.NVarChar, 0, "Rev"), New System.Data.SqlClient.SqlParameter("@DrawNumRev", System.Data.SqlDbType.NVarChar, 0, "DrawNumRev"), New System.Data.SqlClient.SqlParameter("@DrawTitle", System.Data.SqlDbType.NVarChar, 0, "DrawTitle"), New System.Data.SqlClient.SqlParameter("@Response", System.Data.SqlDbType.NVarChar, 0, "Response"), New System.Data.SqlClient.SqlParameter("@IssueType", System.Data.SqlDbType.NVarChar, 0, "IssueType"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@OriginatorName", System.Data.SqlDbType.NVarChar, 0, "OriginatorName"), New System.Data.SqlClient.SqlParameter("@OriginatorDate", System.Data.SqlDbType.[Date], 0, "OriginatorDate"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.[Date], 0, "DateClosed"), New System.Data.SqlClient.SqlParameter("@Request", System.Data.SqlDbType.NVarChar, 0, "Request"), New System.Data.SqlClient.SqlParameter("@ProgramName", System.Data.SqlDbType.NVarChar, 0, "ProgramName"), New System.Data.SqlClient.SqlParameter("@Comments", System.Data.SqlDbType.NVarChar, 0, "Comments"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@DateIncorporated", System.Data.SqlDbType.[Date], 0, "DateIncorporated"), New System.Data.SqlClient.SqlParameter("@Project", System.Data.SqlDbType.NVarChar, 0, "Project"), New System.Data.SqlClient.SqlParameter("@EQNNumber", System.Data.SqlDbType.NVarChar, 0, "EQNNumber"), New System.Data.SqlClient.SqlParameter("@Category", System.Data.SqlDbType.NVarChar, 0, "Category"), New System.Data.SqlClient.SqlParameter("@ERAS", System.Data.SqlDbType.NVarChar, 0, "ERAS"), New System.Data.SqlClient.SqlParameter("@DateERASUpdated", System.Data.SqlDbType.[Date], 0, "DateERASUpdated"), New System.Data.SqlClient.SqlParameter("@ERASUpdatedBy", System.Data.SqlDbType.NVarChar, 0, "ERASUpdatedBy"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Earr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Earr", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Earr", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Earr", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IssueNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IssueNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IssueNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IssueNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Rev", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Rev", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Rev", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Rev", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawNumRev", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawNumRev", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawNumRev", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawNumRev", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawTitle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Response", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Response", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Response", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Response", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IssueType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IssueType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IssueType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IssueType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateClosed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Request", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Request", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Request", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Request", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateIncorporated", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateIncorporated", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateIncorporated", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateIncorporated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Project", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Project", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Project", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Project", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EQNNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EQNNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EQNNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EQNNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Category", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Category", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Category", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Category", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ERAS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ERAS", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ERAS", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ERAS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateERASUpdated", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateERASUpdated", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateERASUpdated", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateERASUpdated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ERASUpdatedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ERASUpdatedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ERASUpdatedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ERASUpdatedBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = resources.GetString("SqlDeleteCommand8.CommandText")
        Me.SqlDeleteCommand8.Connection = Me.SqlConnection4
        Me.SqlDeleteCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Earr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Earr", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Earr", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Earr", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IssueNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IssueNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IssueNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IssueNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawNum", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawNum", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Rev", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Rev", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Rev", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Rev", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawNumRev", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawNumRev", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawNumRev", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawNumRev", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DrawTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DrawTitle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DrawTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Response", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Response", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Response", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Response", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_IssueType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "IssueType", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_IssueType", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IssueType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_OriginatorDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_OriginatorDate", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OriginatorDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateClosed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Request", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Request", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Request", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Request", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ProgramName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ProgramName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProgramName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Comments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Comments", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateIncorporated", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateIncorporated", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateIncorporated", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateIncorporated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Project", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Project", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Project", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Project", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EQNNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EQNNumber", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EQNNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EQNNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Category", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Category", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Category", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Category", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ERAS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ERAS", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ERAS", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ERAS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DateERASUpdated", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DateERASUpdated", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DateERASUpdated", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateERASUpdated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ERASUpdatedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ERASUpdatedBy", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ERASUpdatedBy", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ERASUpdatedBy", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daIssues
        '
        Me.daIssues.DeleteCommand = Me.SqlDeleteCommand8
        Me.daIssues.InsertCommand = Me.SqlInsertCommand8
        Me.daIssues.SelectCommand = Me.SqlSelectCommand10
        Me.daIssues.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblDrawingsOfEARR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("Earr", "Earr"), New System.Data.Common.DataColumnMapping("IssueNumber", "IssueNumber"), New System.Data.Common.DataColumnMapping("DrawNum", "DrawNum"), New System.Data.Common.DataColumnMapping("Rev", "Rev"), New System.Data.Common.DataColumnMapping("DrawNumRev", "DrawNumRev"), New System.Data.Common.DataColumnMapping("DrawTitle", "DrawTitle"), New System.Data.Common.DataColumnMapping("Response", "Response"), New System.Data.Common.DataColumnMapping("IssueType", "IssueType"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("OriginatorName", "OriginatorName"), New System.Data.Common.DataColumnMapping("OriginatorDate", "OriginatorDate"), New System.Data.Common.DataColumnMapping("DateClosed", "DateClosed"), New System.Data.Common.DataColumnMapping("Request", "Request"), New System.Data.Common.DataColumnMapping("ProgramName", "ProgramName"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("DateIncorporated", "DateIncorporated"), New System.Data.Common.DataColumnMapping("Project", "Project"), New System.Data.Common.DataColumnMapping("EQNNumber", "EQNNumber"), New System.Data.Common.DataColumnMapping("Category", "Category"), New System.Data.Common.DataColumnMapping("ERAS", "ERAS"), New System.Data.Common.DataColumnMapping("DateERASUpdated", "DateERASUpdated"), New System.Data.Common.DataColumnMapping("ERASUpdatedBy", "ERASUpdatedBy")})})
        Me.daIssues.UpdateCommand = Me.SqlUpdateCommand8
        '
        'colTypeIssues
        '
        Me.colTypeIssues.Caption = "Issue Type"
        Me.colTypeIssues.FieldName = "Type"
        Me.colTypeIssues.Name = "colTypeIssues"
        Me.colTypeIssues.Visible = True
        Me.colTypeIssues.VisibleIndex = 0
        Me.colTypeIssues.Width = 64
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Issue Type"
        Me.GridColumn4.FieldName = "Type"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 64
        '
        'SqlConnection5
        '
        Me.SqlConnection5.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=NCR;Persist Security Info=True;Us" &
    "er ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection5.FireInfoMessageEventOnUserErrors = False
        '
        'frmEngWorkflow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 811)
        Me.Controls.Add(Me.btnShowTree)
        Me.Controls.Add(Me.btnNumber)
        Me.Controls.Add(Me.btncancelobsolete)
        Me.Controls.Add(Me.lblTasksPending)
        Me.Controls.Add(Me.btnSignOff)
        Me.Controls.Add(Me.lblRecordDeleted)
        Me.Controls.Add(Me.lblCanceled)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.cboView)
        Me.Controls.Add(Me.btnAddNewRev)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtMainTitle)
        Me.Controls.Add(Me.txtMainDrawingNumber)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.chkShowStageComplete)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExportGrid)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.txtMainLocation)
        Me.Controls.Add(Me.txtMainStatus)
        Me.Controls.Add(Me.txtMainProgram)
        Me.Controls.Add(Me.txtMainRecordID)
        Me.Controls.Add(Me.txtMainInfoRecordID)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEngWorkflow"
        Me.Text = "Field Document Tracker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMainGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet241, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet201, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.cbomaininfoStress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbomaininforeleaser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbomaininfosrengineer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbomaininfoengineer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbomaininfodrafter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMainRev.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMainStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMainInformationTab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet211, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.GridControl12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAssemblies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAssemblies1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDrawingsProjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDrawingsProjects1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDetailsResourceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDetailsSystem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDetailsDocumentType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDetailsLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDetailsProgram.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.cboDRN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.GridControl13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRedlines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRedlines1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRedlineStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.cboSchedMilestone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSchedWhiteBoard.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.cboCertificationReviewStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOMTApproval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet261, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSUMApproval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet251, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridControl9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSearchAttachments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet271, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        CType(Me.GridControl14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsIssues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIssues1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAttachments.ResumeLayout(False)
        Me.tabAttachments.PerformLayout()
        CType(Me.GridControl10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAttachments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAttachments1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIssues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDrnAdcn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtmaininfotitle As TextBox
    Friend WithEvents dtmaininfoactualfinishdt As DateTimePicker
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNotesNotes As TextBox
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkShowStageComplete As CheckBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnExportGrid As Button
    Friend WithEvents dtmaininforeleasercomp As DateTimePicker
    Friend WithEvents dtmaininfosrengcomp As DateTimePicker
    Friend WithEvents dtmaininfoengcomp As DateTimePicker
    Friend WithEvents dtmaininfodraftercomp As DateTimePicker
    Friend WithEvents txtDetailsInstallationDrawing As TextBox
    Friend WithEvents txtDetailsNextAssemblyDrawing As TextBox
    Friend WithEvents mskSchedDuration As MaskedTextBox
    Friend WithEvents dtSchedForecastFinish As DateTimePicker
    Friend WithEvents dtSchedForecastStart As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents GridControl6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents bsMainGrid As BindingSource
    Friend WithEvents DataSet201 As DataSet20
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtMainDrawingNumber As TextBox
    Friend WithEvents txtMainTitle As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CertificationStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LovMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemDescriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResourceTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NameAssignmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PriorityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DRNADCNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewReworkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteBoardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectServerWorkflowSyncToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtMainRecordID As TextBox
    Friend WithEvents txtMainProgram As TextBox
    Friend WithEvents txtMainStatus As TextBox
    Friend WithEvents txtMainLocation As TextBox
    Friend WithEvents bsMainInformationTab As BindingSource
    Friend WithEvents DataSet211 As DataSet21
    Friend WithEvents colDwgRevision1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDRNADCN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingTitle1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualFinishDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafter1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafterComplete1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerComplete1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineerComplete1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaser1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaserCompelte1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriority1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRequestBy1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRequestDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystemDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActionDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForecastStartDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForecastFinishDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlannedFinishDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDurationHours1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPercentComplete1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingFolderAssignDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignWIPDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModelTemplateDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammability1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammabilityComplete1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStress1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStressComplete1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafterPlannedCompleteDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerPlannedCompleteDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineerPlannedCompleteDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammabilityPlannedCompleteDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStressPlannedCompleteDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaserPlannedCompleteDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionics1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionicsComplete1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionicsPlannedComplete1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanical1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanicalComplete1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanicalPlannedComplete1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWONumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNextHigherAssembly1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstallationDrawing1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhiteBoardNumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAProjectNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPSCPDocsRequired1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyFlightTestRequired1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgReqDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewRework1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdated1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdatedDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As SqlClient.SqlDataAdapter
    Friend WithEvents txtMainInfoRecordID As TextBox
    Friend WithEvents colRecordID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentType2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriority2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRequestBy2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNumber2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRequestDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingTitle2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingType2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystemDescription2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActionDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualFinishDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForecastStartDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForecastFinishDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlannedFinishDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDurationHours2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPercentComplete2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingFolderAssignDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignWIPDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModelTemplateDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafter2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafterComplete2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineer2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerComplete2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineer2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineerComplete2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaser2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaserCompelte2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammability2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammabilityComplete2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStress2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStressComplete2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpr2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafterPlannedCompleteDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerPlannedCompleteDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineerPlannedCompleteDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammabilityPlannedCompleteDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStressPlannedCompleteDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaserPlannedCompleteDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionics2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionicsComplete2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionicsPlannedComplete2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanical2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanicalComplete2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanicalPlannedComplete2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWONumber2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNextHigherAssembly2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstallationDrawing2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhiteBoardNumber2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDRNADCN2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAProjectNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPSCPDocsRequired2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyFlightTestRequired2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgReqDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewRework2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdated2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdatedDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRevision2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpr21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentType3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriority3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRequestBy3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNumber3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRequestDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingTitle3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingType3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystemDescription3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActionDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualFinishDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForecastStartDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForecastFinishDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlannedFinishDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDurationHours3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPercentComplete3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingFolderAssignDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignWIPDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModelTemplateDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafter3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafterComplete3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineer3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerComplete3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineer3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineerComplete3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaser3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaserCompelte3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammability3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammabilityComplete3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStress3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStressComplete3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafterPlannedCompleteDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerPlannedCompleteDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineerPlannedCompleteDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammabilityPlannedCompleteDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStressPlannedCompleteDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaserPlannedCompleteDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionics3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionicsComplete3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionicsPlannedComplete3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanical3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanicalComplete3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanicalPlannedComplete3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWONumber3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNextHigherAssembly3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstallationDrawing3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhiteBoardNumber3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDRNADCN3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAProjectNo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPSCPDocsRequired3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyFlightTestRequired3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgReqDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewRework3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdated3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdatedDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRevision3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeq1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label29 As Label
    Friend WithEvents colExpr23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWONumber5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlannedFinishDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForecastStartDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForecastFinishDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDurationHours5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPercentComplete5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriority5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordID5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentType5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRequestBy5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNumber5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRequestDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingTitle5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingType5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystemDescription5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActionDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualFinishDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingFolderAssignDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignWIPDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModelTemplateDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafter5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafterComplete5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineer5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerComplete5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineer5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineerComplete5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaser5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaserCompelte5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammability5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammabilityComplete5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStress5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStressComplete5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefID5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafterPlannedCompleteDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerPlannedCompleteDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineerPlannedCompleteDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammabilityPlannedCompleteDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStressPlannedCompleteDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaserPlannedCompleteDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionics5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionicsComplete5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionicsPlannedComplete5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanical5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanicalComplete5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanicalPlannedComplete5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNextHigherAssembly5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstallationDrawing5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhiteBoardNumber5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDRNADCN5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAProjectNo5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPSCPDocsRequired5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyFlightTestRequired5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgReqDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewRework5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdated5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdatedDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRevision5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeq3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAddNewRev As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label30 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecordID4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentType4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriority4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRequestBy4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNumber4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRequestDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingTitle4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingType4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystemDescription4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActionDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualFinishDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForecastStartDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForecastFinishDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlannedFinishDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDurationHours4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPercentComplete4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingFolderAssignDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignWIPDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModelTemplateDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafter4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafterComplete4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineer4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerComplete4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineer4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineerComplete4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaser4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaserCompelte4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammability4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammabilityComplete4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStress4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStressComplete4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpr22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefID4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafterPlannedCompleteDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerPlannedCompleteDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineerPlannedCompleteDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammabilityPlannedCompleteDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStressPlannedCompleteDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaserPlannedCompleteDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionics4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionicsComplete4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionicsPlannedComplete4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanical4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanicalComplete4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanicalPlannedComplete4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWONumber4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNextHigherAssembly4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstallationDrawing4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhiteBoardNumber4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDRNADCN4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAProjectNo4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPSCPDocsRequired4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyFlightTestRequired4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgReqDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewRework4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdated4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdatedDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRevision4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeq2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADCN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBrowseInstallationDrawing As Button
    Friend WithEvents btnBrowseNextAssemblyDrawing As Button
    Friend WithEvents cboView As ComboBox
    Friend WithEvents DataSet241 As DataSet24
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRequestBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRequestDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastActionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualFinishDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForecastStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForecastFinishDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlannedFinishDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDurationHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPercentComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingFolderAssignDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignWIPDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModelTemplateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafterComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineerComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaserCompelte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammability As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammabilityComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStressComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRevision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrafterPlannedCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerPlannedCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSrEngineerPlannedCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFlammabilityPlannedCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStressPlannedCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaserPlannedCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionics As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionicsComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvionicsPlannedComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanical As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanicalComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMechanicalPlannedComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWONumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNextHigherAssembly As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstallationDrawing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhiteBoardNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDRNADCN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAProjectNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPSCPDocsRequired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyFlightTestRequired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgReqDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewRework As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADCN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeq4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label31 As Label
    Friend WithEvents btnSyncUMApprovals As Button
    Friend WithEvents GridControl7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMSpecialty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMRecommendApproval As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colUMApproval As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colRequiredToApprove As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkShowAllUMApprovals As CheckBox
    Friend WithEvents Label32 As Label
    Friend WithEvents btnSyncOMTApprovals As Button
    Friend WithEvents txtComments As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents chkShowAllFAAOMTApprovals As CheckBox
    Friend WithEvents GridControl8 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRecordID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAOMTName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAOMTSpecialty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAOMTRecommendApproval As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAAOMTApproval As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox5 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colRequiredToApprove1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSaveUMApprovals As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter3 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet251 As DataSet25
    Friend WithEvents BSUMApproval As BindingSource
    Friend WithEvents bsOMTApproval As BindingSource
    Friend WithEvents DataSet261 As DataSet26
    Friend WithEvents SqlSelectCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter4 As SqlClient.SqlDataAdapter
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnFileAttachSubmit As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents btnView As Button
    Friend WithEvents btnSaveNew As Button
    Friend WithEvents GridControl9 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRecordID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFilePath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImgField As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileExt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnDeleteAttachment As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents txtFileDescription As TextBox
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents SqlSelectCommand5 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter5 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet271 As DataSet27
    Friend WithEvents bsSearchAttachments As BindingSource
    Friend WithEvents txtAttachRecordID As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnPercCompleteHelp As Button
    Friend WithEvents txtSchedWorkOrder As MaskedTextBox
    Friend WithEvents cboSchedPercComp As MaskedTextBox
    Friend WithEvents dtmaininfoStressComp As DateTimePicker
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents CertificationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilterGridToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MDLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboMainStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboMainRev As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbomaininfodrafter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbomaininfoStress As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbomaininforeleaser As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbomaininfosrengineer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbomaininfoengineer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDetailsDocumentType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDetailsLocation As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDetailsProgram As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDetailsSystem As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDetailsResourceType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboSchedWhiteBoard As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboCertificationReviewStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblCanceled As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents GridEditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label46 As Label
    Friend WithEvents cboADCN As MaskedTextBox
    Friend WithEvents cboDRN As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboSchedMilestone As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colADCN2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboDRNADCNIncorporatedBy As ComboBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents cboIncorporatedRev As ComboBox
    Friend WithEvents cboDRNADCNStatus As ComboBox
    Friend WithEvents AIMNumbersListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents maskedDetailsDCN As MaskedTextBox
    Friend WithEvents lblDCN As Label
    Friend WithEvents colDCNUpperGrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDCNDetailsTab As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatusCol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDRNADCNStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIncorporatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabAttachments As TabPage
    Friend WithEvents GridControl10 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlSelectCommand6 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter6 As SqlClient.SqlDataAdapter
    Friend WithEvents DsAttachments1 As dsAttachments
    Friend WithEvents bsAttachments As BindingSource
    Friend WithEvents colRecordIDAttach As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRecordID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTarget As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActualDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDeleteAttach As Button
    Friend WithEvents btnSaveAttachment As Button
    Friend WithEvents btnBrowseAttachments As Button
    Friend WithEvents txtTargetAttach As TextBox
    Friend WithEvents txtFileNameAttach As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents txtFieldDescriptionAttach As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents bsDrnAdcn As BindingSource
    Friend WithEvents colADCN3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADCN4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDRNDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDRNNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADCNNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDRNSchedule As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboPercentComplete As ComboBox
    Friend WithEvents lblRecordDeleted As Label
    Friend WithEvents btnSignOff As Button
    Friend WithEvents btnViewAttachment As Button
    Friend WithEvents ReturnToMainMenuScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents colDateSubmitted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateNeeded As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateCommentsReturned As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTasksPending As Label
    Friend WithEvents NotificationRolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btncancelobsolete As Button
    Friend WithEvents cboConfigurationStatus As ComboBox
    Friend WithEvents Label52 As Label
    Friend WithEvents JASCCodesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Level3DocTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductGroupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AircraftsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnNumber As Button
    Friend WithEvents btnShowTree As Button
    Friend WithEvents txtMainProjectName As TextBox
    Friend WithEvents GridControl11 As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsDrawingsProjects As BindingSource
    Friend WithEvents DsDrawingsProjects1 As dsDrawingsProjects
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecordID6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordIDParent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNumber6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chbIncludeChildren As CheckBox
    Friend WithEvents btnDeleteDrawingsProjects As Button
    Friend WithEvents btnSaveDrawingsProjects As Button
    Friend WithEvents SqlSelectCommand7 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As SqlClient.SqlCommand
    Friend WithEvents daDrawingsProjects As SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection3 As SqlClient.SqlConnection
    Friend WithEvents RepositoryItemComboBox6 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox7 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox8 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ProjectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnShowAssembly As Button
    Friend WithEvents btnRemoveAssembly As Button
    Friend WithEvents GridControl12 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecordID7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordIDFromDrawings As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNumber7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentType6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriority6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgReqDate6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingType6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystemDescription6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDwgRevision6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNextHigherAssembly6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADCN5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDCN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRowNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSequence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAddAssembly As Button
    Friend WithEvents SqlSelectCommand8 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As SqlClient.SqlCommand
    Friend WithEvents daAssemblies As SqlClient.SqlDataAdapter
    Friend WithEvents DsAssemblies1 As dsAssemblies
    Friend WithEvents bsAssemblies As BindingSource
    Friend WithEvents ChangeDrawingNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents colProgramReal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramRealDetailsTab As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HelpManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GridControl13 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSaveIncorporatedRev As Button
    Friend WithEvents txtRedlineFileName As TextBox
    Friend WithEvents lblRedlineFilename As Label
    Friend WithEvents btnDesignSignOff As Button
    Friend WithEvents btnPlannerSignOff As Button
    Friend WithEvents btnLiaisonSignOff As Button
    Friend WithEvents btnDeleteRedline As Button
    Friend WithEvents btnAddRedline As Button
    Friend WithEvents SqlSelectCommand9 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As SqlClient.SqlCommand
    Friend WithEvents daRedlines As SqlClient.SqlDataAdapter
    Friend WithEvents DsRedlines1 As dsRedlines
    Friend WithEvents bsRedlines As BindingSource
    Friend WithEvents colRecordID8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawingNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRedlineDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndexNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIncorporatedRev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRedlineNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRedlineCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLiaisonSignedOffBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLiaisonSignedOffDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperationsSignedOffBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperationsSignedOffDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignEngSignedOffBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignEngSignedOffDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRedlineRecordID As TextBox
    Friend WithEvents cboRedlineStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colRevPurpose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents btnExportIssue As Button
    Friend WithEvents btnViewIssue As Button
    Friend WithEvents GridControl14 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtIssuesRecordID As TextBox
    Friend WithEvents txtTypeOfIssue As TextBox
    Friend WithEvents txtEarrNumIssues As TextBox
    Friend WithEvents SqlSelectCommand10 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection4 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand8 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As SqlClient.SqlCommand
    Friend WithEvents daIssues As SqlClient.SqlDataAdapter
    Friend WithEvents DsIssues1 As dsIssues
    Friend WithEvents bsIssues As BindingSource
    Friend WithEvents DsIssues As dsIssues
    Friend WithEvents colRecordID9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEarr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRev1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawNumRev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrawTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResponse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginatorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginatorDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateClosed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueTypes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateIncorporated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEQNNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTypeIssues As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colERAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colERASUpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateERASUpdated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCloseIssue As Button
    Friend WithEvents SqlConnection5 As SqlClient.SqlConnection
    Friend WithEvents btnReverseClosedEarr As Button
End Class
