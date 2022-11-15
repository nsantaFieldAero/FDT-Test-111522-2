Module basdeclares
    Public u As New Util.Utility
    '*****One of the two below connection strings must be specified.  One is for test, one for production.
    '*****Production Field Document Tracker Database
    'Public sqlString As String = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True;User ID=sa1;Password=The water is wet!"
    '*****Test Field Document Tracker Database
    Public sqlString As String = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWGTEST;Persist Security Info=True;User ID=sa1;Password=The water is wet!"
    'Public sqlString As String = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWGPRODTEST;Persist Security Info=True;User ID=sa1;Password=The water is wet!"


    'Public sqlString1 As String = "Server=172.16.3.7\GETSMART;Database=EARR;uid=sa1;pwd=The water is wet!;persist security info=False"
    Public sqlString1 As String = "Server=172.16.3.7\GETSMART;Database=EARRTEST;uid=sa1;pwd=The water is wet!;persist security info=False"

    Public RecordToEdit As Integer
    Public EditEARR As Integer = 0
    Public EARRSelected As String = ""
    Public RecordIDSubEARR As String
    Public EmailSubEARR As String
    Public PreviousUsernameSubEARR As String
    Public PreviousEmailSubEARR As String
    Public ProgramSubEARR As String
    Public ProgramTwoSubEARR As String
    Public ProgramThreeSubEARR As String
    Public ProgramFourSubEARR As String
    Public SubbedUserProgram As String
    Public SubbedUserType As String
    Public TypeSubEARR As String
    Public TypeTwoSubEARR As String
    Public NewSubbedEmail As String
    Public User As String
    Public Id As String
    Public GlobalSqlString As String
    Public GlobalSqlString2 As String
    Public EARRORIGNAME As String
    Public EARRREADONLY As Integer = 0
    Public EARRJaguarOnly As Boolean
    Public CertManagerProgram As String
    Public username As String
    Public CM As Boolean
    Public MDL As Boolean
    Public MDLUnlocked As Boolean
    Public DrawingNumberToEdit As String
    Public DocBrowse As String
    Public DocAdd As Integer
    Public ObsoleteRemarks As String
    Public Loc As String
    Public RevOrDRN As String
    Public DRN As String
    Public ADCN As String
    Public OpenMDL As Integer
    Public OpenMDLRev As String
    Public MDLOptionsRecordID As String
    Public MDLOptionsDrawingNumber As String
    Public MDLOptionsDrawingRev As String
    Public MDLOptionsDrawingTitle As String
    Public ChangeDocNumber As String
    Public ChangeDocTYpe As String
    Public MDLChangeRecordID As Integer
    Public DocumentType As String
    Public Title As String
    Public Program As String
    Public ProgramName As String
    Public GateStatus As String
    Public Systems As String

    Public DrnAllowed As String
    Public AdcnAllowed As String
    Public LocationForDrnAdcn As String
    Public DrawingNumberBeingModified As String
    Public AIMChosen As String
    Public RecordIDRevision As String
    Public initialStatus As String
    'Public StatusChange As String
    Public DocumentTypeForOperations As String
    Public RowSelectedUpperGrid
    Public RowSelectedLowerGrid
    Public ChangesLowerGridSaved As String

    Public AppJustOpened As Integer
    Public RevChangedToValue As String
    Public InitialRevValue As String
    Public MainRecordIDForSaveChanges As String
    Public RecordIDForIncorporated As String
    Public InitialStatusForIncorporated As String
    Public StatusChangedToForIncorporated As String
    Public InitialSeqForIncorporated As Integer
    'Public PreviousRecordID As String
    'Public RecordIDChangedToForIncorporated As String

    'Public valueInitialRev As String
    'Public valueChangedToRev As String
    Public DataIsSaved As String
    Public RecordIDForSave As String
    Public RevForSave As String
    Public SaveFrom As String
    Public Document As Integer

    Public countForPercentComplete As Integer
    Public TasksLabelText As String
    Public SelectNotificationsView As String
    Public CloseSignedOffForm As String = "No"
    Public DrafterSignOff As String
    Public SrEngineerSignOff As String
    Public StressSignOff As String
    Public OperationsSignOff As String
    Public ReleaserSignOff As String

    Public ProgramSelected As String   'in programs screen
    Public DrawingNumForEmails As String
    Public RevisionForEmails As String
    Public NotificationAlreadySentForGateOne As String

    Public DocTypeForGuide As String
    Public isCM_LeadEng_Admin As String
    Public IsCMOrLeadEngOrAdmin As String
    Public isLeadEngineer As String
    Public MDLNumberCreatedFormB As String
    Public CreateOrModifyDocNum As String
    Public RecordIdDocNumToModify As String
    Public DocNumberDocNumToModify As String
    Public DocTypeDocNumToModify As String
    Public SeriesDocNumToModify As String
    Public LocationDocNumToModify As String
    Public SystemDocNumToModify As String
    Public TitleDocNumToModify As String
    Public ProgramRealDocNumToModify As String
    Public ProgramDocNumToModify As String  'This actually will contain Project
    Public ClassificationDocNumToModify As String
    Public DocTypeSelectedLevelThree_DocNumToModify As String
    Public ResourceTypeDocNumToModify As String
    Public DrafterDocNumToModify As String
    Public NextHigherAssemblyDocNumToModify As String
    Public NewReworkFormB As String
    Public ClassificationFormB As String
    Public PrefixForCheckingReset As String
    Public DrafterFormB As String


    Public ProjectSelected As String   'in Projects screen

    Public JASCBtnFormA As String

    Public TitleBrowseAssembly As String
    Public RecordIDBrowse As String

    Public ShowAssemblyClicked As String = ""
    Public DrawingNumFromAssembly As String = ""
    Public DrawingsOnlyOrBoth As String = ""
    Public isAdmin As String

    Public AddRevFromRedline As String
    Public isLiaison As String
    Public isOperations As String
    Public isDrafter As String
    Public RedlineIndexNum As Integer
    Public LatestRedlineRev As String
    Public NextIndexNum As String
    Public RedlineFileName As String
    Public RedlinesCount As Integer
    Public RevSelectedRedline As String
    Public RedlineFilenameForEmail As String
    Public RevPurpose As String
    Public RevNotes As String
    Public CloseRevPurposeForm As String
    Public isDRN As String
    Public isADCN As String
    Public SignedOffAdcnDrnGateSix As String

    Public DrawNumForSignOff As String
    Public OpenSignOffForm As String
    Public AllowSignOffOpen As String
    Public isNewRecord As String        'ADD THIS LINE 07/14/2022

    '***EQN SOW --------------------------------------------------------------------------------------
    Public DocBrowseDrawNum As String
    Public TitleBrowseDrawNum As String
    Public RevBrowseDrawNum As String
    Public CreateRev As String
    Public InitialDrawNumFDT As String
    Public AddRevFromEARR As String
    Public DrawNumFromEARR As String
    Public RevEARR As String = ""
    Public DrawNumFromFormAorB As String = ""
    Public ResponseDocTitle As String = ""
    Public RunIfNotGateSix As String = ""
    Public ChangeRedline As String
    Public MoveGates As String
    Public EarrNumIssues As String

    '***NCR------------------------------------------------------------------------------------------------
    Public EmailUsername As String
    Public isCalgary As String

    Public isNewNCR As String

    'Public isChairperson As String
    Public isQAManager As String

    Public isEngineerNCR As String

    'Public isMRB As String
    Public isProdMgr As String
    Public isProgramMgr As String
    Public isDAO As String
    Public isLeadEngineerNCR As String
    Public isStress As String
    Public isDesign As String
    Public isLiaisonNCR As String

    Public isOperationsNCR As String

    Public isQC As String

    Public isCloseNCR As String

    Public isProdSupervisor As String
    Public isNCRAdmin As String
    Public isSuperUser As String

    Public RecordIDNCR As String
    Public LatestStep As String
    Public AcceptedStep As String
    Public ActualStep As String
    Public NCRNumber As String

    Public NCRNumIssues As String
    Public OriginatorName As String
    Public AbortedReason As String
    Public ReSubmitReason As String
    Public UserComingFromAddNCR As String
    Public LocationNCR As String

End Module
