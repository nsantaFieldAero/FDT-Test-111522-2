Imports DevExpress.DataAccess
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.Data

Public Class frmEngWorkflowTree

    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEngWorkflowTree_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Hide DrawingsOnly button if it is chosen to select both(drawings and reports), and do the opposite as well
        If DrawingsOnlyOrBoth = "DrawingsOnly" Then
            btnDrawingsOnly.Enabled = False
        Else
            btnDrawAndReport.Enabled = "False"
        End If


        'Show Find Panel which is set to OptionsFind.Behavior = Search
        TreeList2.ShowFindPanel()


        SqlConnection1.ConnectionString = sqlString
        Me.SqlConnection1.ConnectionString = sqlString


        ''TreeList1.Columns("RecordIDFromDrawings").Visible = False
        ''treeList1.Columns(treeList1.KeyFieldName).Visible = False


        TreeList2.Parent = Me
        'TreeList2.Dock = DockStyle.Fill

        'Specify the fields that arrange underlying data as a hierarchy.
        TreeList2.KeyFieldName = "RecordID"
        TreeList2.ParentFieldName = "NextHigherAssembly"

        'Allow the treelist to create columns bound to the fields the KeyFieldName and ParentFieldName properties specify.
        TreeList2.OptionsBehavior.PopulateServiceColumns = True

        'Specify the data source.
        TreeList2.DataSource = TreeDataGenerator.CreateData()

        'The treelist automatically creates columns for the public fields found in the data source. 
        'You do not need to call the TreeList.PopulateColumns method unless the treeList1.OptionsBehavior.AutoPopulateColumns option is disabled.


        'Hide the key columns. An end-user can access them from the Customization Form.
        TreeList2.Columns(TreeList2.KeyFieldName).Visible = False
        TreeList2.Columns(TreeList2.ParentFieldName).Visible = False

        TreeList2.ExpandAll()

        'TreeList2.VertScrollVisibility = ScrollVisibility.Always

        'Calculate the optimal column widths after the treelist is shown.
        Me.BeginInvoke(New MethodInvoker(Sub()
                                             TreeList2.BestFitColumns()
                                         End Sub))

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        ShowAssemblyClicked = "Yes"

        'Get DrawingNumber to show in Main screen
        Dim DocNumSelected As TreeListColumn = TreeList2.Columns("DrawingNumber")
        DrawingNumFromAssembly = TreeList2.GetFocusedRowCellValue(DocNumSelected)


        'Dim currentForm As Form = Form.ActiveForm

        frmEngWorkflow.Show()

        frmEngWorkflow.Activate()
        'Get data for DrawingNumber to be displayed on Main screen
        frmEngWorkflow.Search()
        frmEngWorkflow.GridView1.ClearColumnsFilter()

        'frmEngWorkflow.SearchMainInformation()
        'frmEngWorkflow.GridView1.ClearColumnsFilter()


        'THESE DID NOT WORK
        'frmEngWorkflow.Close()
        'frmEngWorkflow.Dispose()
        'frmEngWorkflow.Hide()
        'frmEngWorkflow.TopMost = True

        'Dim obj As New frmEngWorkflowTree
        'obj.TopMost = False
        ''Dim obj1 As New Panel
        ''obj1.Dock = DockStyle.Fill
        ''obj.Controls.Add(obj1)
        ''obj1.Controls.Add(obj)


        'PREVIOUS LINE OF CODE
        'frmEngWorkflow.ShowDialog()


        ShowAssemblyClicked = ""
    End Sub

    Private Sub btnDrawAndReport_Click(sender As Object, e As EventArgs) Handles btnDrawAndReport.Click

        DrawingsOnlyOrBoth = "DrawingsAndReports"
        Me.Close()

        Dim frmEngWorkflowTree As New frmEngWorkflowTree
        frmEngWorkflowTree.Show()
    End Sub

    Private Sub btnDrawingsOnly_Click(sender As Object, e As EventArgs) Handles btnDrawingsOnly.Click

        DrawingsOnlyOrBoth = "DrawingsOnly"
        Me.Close()

        Dim frmEngWorkflowTree As New frmEngWorkflowTree
        frmEngWorkflowTree.Show()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        'GET SEQUENCE NUMBER TO MAKE FILENAME TO SAVE UNIQUE
        Dim SeqNum As Integer
        Dim TodaysDate As String = DateTime.Now.ToString("MMddyyyy")

        da = New SqlClient.SqlDataAdapter("Select TOP 1 * From tblTreeIncreaseFileNameByOne Where Date = '" & TodaysDate & "' Order by RecordID desc", SqlConnection1)
        da.Fill(ds, "GetSeq")
        If ds.Tables("GetSeq").Rows.Count > 0 Then
            SeqNum = ds.Tables("GetSeq").Rows(0).Item("Seq")
        Else
            SeqNum = 1
        End If


        'Best fit cols
        TreeList2.BestFitColumns()
        TreeList2.OptionsView.AutoWidth = False
        'TreeList2.BestFitVisibleOnly = True
        'TreeList2.OptionsView.ColumnAutoWidth = False


        'Dim PathToSaveExcel As String = "ExportedTree_" & Now & ".xlsx"
        TreeList2.ExportToXlsx("C:\Temp\ExportedTree_" & TodaysDate & "_" & SeqNum & ".xlsx")
        MsgBox("Grid has been exported to c:\temp\")


        'ENTER NEXT SEQUENCE NUMBER THAT WILL BE USED FOR NEXT FILE THAT WILL BE SAVED
        SeqNum += 1
        u.ExecuteSQL(SqlConnection1, "Insert into tblTreeIncreaseFileNameByOne (Seq, Date) Values (" & SeqNum & ", '" & TodaysDate & "')")


        ds.Tables("GetSeq").Clear()
        ds.Tables("GetSeq").Dispose()
        SeqNum = 0
    End Sub

End Class


Public Class TreeData
    'Shared UniqueID As Integer = 37

    'Public Sub New()
    '    ID = Math.Min(System.Threading.Interlocked.Increment(UniqueID), UniqueID - 1)
    'End Sub

    Public Sub New(ByVal recordID As String, ByVal drawingNumber As String, ByVal nextAssembly As String, ByVal system As String, ByVal status As String, ByVal revision As String, ByVal title As String)
        Me.RecordID = recordID
        Me.DrawingNumber = drawingNumber
        Me.NextHigherAssembly = nextAssembly
        Me.System = system
        Me.Status = status
        Me.Revision = revision
        Me.Title = title
    End Sub

    Public Property RecordID As String
    Public Property DrawingNumber As String
    Public Property NextHigherAssembly As String
    Public Property System As String
    Public Property Status As String
    Public Property Revision As String
    Public Property Title As String
    '<DisplayFormat(DataFormatString:="p0")>
End Class

Public Class TreeDataGenerator
    Public Shared Function CreateData() As List(Of TreeData)

        '*************************************************************************************************************
        '-------------------------------------------------------------------------------------------------------------
        '**************** NextHigherAssembly, DrawingNumber And DrawingTitle in tblTree contain info about the parent and is used in the Assembly grid of the Details tab
        '**************** DrawingNumOriginal, DwgRevision, DrawingTitleChildren, Status... contain info about the children and is used in the creation of the Tree
        '-------------------------------------------------------------------------------------------------------------
        '*************************************************************************************************************


        Dim da As SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim a As Integer = 0

        Dim c As Integer = 0
        Dim NextAssembly As String
        Dim System As String
        Dim DrawingNum As String
        Dim DrawingNumOrig As String
        Dim RecordID As String
        Dim Status As String
        Dim Revision As String
        Dim Sequence As String
        Dim Title As String
        Dim NewRework As String
        Dim DrawingOrReport As String
        Dim InList As String = ""


        ''Delete All Data From tblTreeTemporary
        ''u.ExecuteSQL(frmEngWorkflowTree.SqlConnection1, "Delete From tblTreeTemporary")


        ''-----------------------------------------------------------------------------------------------------------------------------------------------
        ''Initial code to make sure the user selects the latest version of data for the Tree

        'u.ExecuteSQL(frmEngWorkflowTree.SqlConnection1, "INSERT into tblTreeToGet (Completed,DateCompleted) Values ('False', '01/01/1900')")


        'da = New SqlClient.SqlDataAdapter("Select RecordID From tblTreeToGet Where Completed = 'False'", frmEngWorkflowTree.SqlConnection1)
        'da.Fill(ds, "RecID")
        'Dim RecIDTreeToGet As String = ds.Tables("RecID").Rows(0).Item("RecordID")

        'ds.Tables("RecID").Clear()
        'ds.Tables("RecID").Dispose()



        ''***GET ALL DATA TO INSERT INTO tblTreeTemporary

        ''-----------------------------------------------------------------------------------------------------------------------------------------------
        ''Get Parent Records From vwDrawingsRev
        'If DrawingsOnlyOrBoth = "DrawingsOnly" Then
        '    da = New SqlClient.SqlDataAdapter("Select * From (SELECT RecordID,DrawingNumber,DocumentType,Priority,DwgReqDate,DrawingType,SystemDescription,Status,DrawingTitle,DwgRevision,NextHigherAssembly,ADCN,DCN,ROW_NUMBER() OVER (PARTITION BY DrawingNumber ORDER BY Seq desc, RecordID Desc) AS RowNumber,Seq,NewRework,DrawingOrReport FROM vwDrawingsRev Where (NewRework = 'Drawing' Or NewRework = 'New Drawing' Or NewRework = 'Rework Drawing') And (NextHigherAssembly = '' Or NextHigherAssembly Is Null) And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted') As A WHERE RowNumber = 1 Order By DrawingNumber, SystemDescription", frmEngWorkflowTree.SqlConnection1)
        'Else
        '    da = New SqlClient.SqlDataAdapter("Select * From (SELECT RecordID,DrawingNumber,DocumentType,Priority,DwgReqDate,DrawingType,SystemDescription,Status,DrawingTitle,DwgRevision,NextHigherAssembly,ADCN,DCN,ROW_NUMBER() OVER (PARTITION BY DrawingNumber ORDER BY Seq desc, RecordID Desc) AS RowNumber,Seq,NewRework,DrawingOrReport FROM vwDrawingsRev Where (NextHigherAssembly = '' Or NextHigherAssembly Is Null) And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted') As A WHERE RowNumber = 1 Order By DrawingNumber, SystemDescription", frmEngWorkflowTree.SqlConnection1)
        'End If

        'da.Fill(ds, "ParentRecords")

        ''Insert Data Selected Above Into tblTreeTemporary
        'While c <= ds.Tables("ParentRecords").Rows.Count - 1
        '    DrawingNum = ds.Tables("ParentRecords").Rows(c).Item("DrawingNumber")
        '    DrawingNumOrig = ds.Tables("ParentRecords").Rows(c).Item("DrawingNumber")

        '    If IsDBNull(ds.Tables("ParentRecords").Rows(c).Item("SystemDescription")) Then
        '        System = ""
        '    Else
        '        System = ds.Tables("ParentRecords").Rows(c).Item("SystemDescription")
        '    End If

        '    Title = ds.Tables("ParentRecords").Rows(c).Item("DrawingTitle")
        '    Status = ds.Tables("ParentRecords").Rows(c).Item("Status")
        '    Revision = ds.Tables("ParentRecords").Rows(c).Item("DwgRevision")
        '    Sequence = ds.Tables("ParentRecords").Rows(c).Item("Seq")

        '    u.ExecuteSQL(frmEngWorkflowTree.SqlConnection1, "INSERT into tblTreeTemporary (DrawingNumOriginal,SystemDescription,DrawingTitle,Status,DwgRevision,Seq,TreeToGetRecordID) Values ('" & DrawingNumOrig & "', '" & u.FTM(System) & "', '" & u.FTM(Title) & "', '" & Status & "', '" & Revision & "', '" & Sequence & "', '" & RecIDTreeToGet & "')")

        '    'This Is the list that will be used In the In Of the SQL clause that will Get the RecordID Of the parent records, And non - parent
        '    If InList = "" Then
        '        InList = "'" & DrawingNum & "'"
        '    Else
        '        InList = InList & ", '" & DrawingNum & "'"
        '    End If

        '    c += 1
        'End While

        'ds.Tables("ParentRecords").Clear()
        'ds.Tables("ParentRecords").Dispose()
        'DrawingNum = ""
        'DrawingNumOrig = ""
        'System = ""
        'Title = ""
        'Status = ""
        'Revision = ""
        'Sequence = ""


        ''-----------------------------------------------------------------------------------------------------------------------------------------------


        ''Get Records That Are Children of the Parent Records Just Added to tblTreeTemporary

        ''If DrawingsOnlyOrBoth = "DrawingsOnly" Then
        ''    da = New SqlClient.SqlDataAdapter("Select * From tblTree Where DrawingNumber IN (" & InList & ") And (NewRework = 'Drawing' Or NewRework = 'New Drawing' Or NewRework = 'Rework Drawing') And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By DrawingNumOriginal", frmEngWorkflowTree.SqlConnection1)
        ''Else
        'da = New SqlClient.SqlDataAdapter("Select * From tblTree Where DrawingNumber IN (" & InList & ") And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By DrawingNumOriginal", frmEngWorkflowTree.SqlConnection1)
        ''End If

        'da.Fill(ds, "ChildrenRecords")

        'c = 0
        'While c <= ds.Tables("ChildrenRecords").Rows.Count - 1

        '    If IsDBNull(ds.Tables("ChildrenRecords").Rows(c).Item("SystemDescription")) Then
        '        System = ""
        '    Else
        '        System = ds.Tables("ChildrenRecords").Rows(c).Item("SystemDescription")
        '    End If
        '    DrawingNum = ds.Tables("ChildrenRecords").Rows(c).Item("DrawingNumber")
        '    DrawingNumOrig = ds.Tables("ChildrenRecords").Rows(c).Item("DrawingNumOriginal")
        '    Title = ds.Tables("ChildrenRecords").Rows(c).Item("DrawingTitleChildren")
        '    Status = ds.Tables("ChildrenRecords").Rows(c).Item("Status")
        '    Revision = ds.Tables("ChildrenRecords").Rows(c).Item("DwgRevision")
        '    Sequence = ds.Tables("ChildrenRecords").Rows(c).Item("Seq")
        '    If IsDBNull(ds.Tables("ChildrenRecords").Rows(c).Item("NewRework")) Then
        '        NewRework = ""
        '    Else
        '        NewRework = ds.Tables("ChildrenRecords").Rows(c).Item("NewRework")
        '    End If

        '    'If DrawingNum = "16B-0000-1915" Or DrawingNumOrig = "16B-0000-1915" Then
        '    '    MsgBox("here")
        '    'End If

        '    'If the record just added was a parent and now is becoming a children of another record then delete
        '    'da = New SqlClient.SqlDataAdapter("Select * From tblTreeTemporary Where DrawingNumOriginal = '" & DrawingNum & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", frmEngWorkflowTree.SqlConnection1)
        '    'da.Fill(ds, "ParentRecord")

        '    'Get RecordID of Parent, to Insert Into NextHigherAssembly
        '    da = New SqlClient.SqlDataAdapter("Select RecordID From tblTreeTemporary Where DrawingNumOriginal = '" & DrawingNum & "' And TreeToGetRecordID = '" & RecIDTreeToGet & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By RecordID Desc", frmEngWorkflowTree.SqlConnection1)
        '    da.Fill(ds, "RecordIDParent")

        '    'Dim h As Integer = 0
        '    'If ds.Tables("RecordIDParent").Rows.Count = 1 Then

        '    RecordID = ds.Tables("RecordIDParent").Rows(0).Item("RecordID")

        '    u.ExecuteSQL(frmEngWorkflowTree.SqlConnection1, "INSERT into tblTreeTemporary (NextHigherAssembly,SystemDescription,DrawingNumber,DrawingNumOriginal,DrawingTitle,Status,DwgRevision,Seq,TreeToGetRecordID) Values ('" & RecordID & "', '" & u.FTM(System) & "', '" & DrawingNum & "', '" & DrawingNumOrig & "', '" & u.FTM(Title) & "', '" & Status & "', '" & Revision & "', '" & Sequence & "', '" & RecIDTreeToGet & "')")

        '    'ElseIf ds.Tables("RecordIDParent").Rows.Count = 2 Then

        '    '    RecordID = ds.Tables("RecordIDParent").Rows(1).Item("RecordID")
        '    '    u.ExecuteSQL(frmEngWorkflowTree.SqlConnection1, "INSERT into tblTreeTemporary (NextHigherAssembly,DrawingNumber,DrawingNumOriginal,DrawingTitle,Status,DwgRevision,Seq) Values ('" & RecordID & "', '" & DrawingNum & "', '" & DrawingNumOrig & "', '" & u.FTM(Title) & "', '" & Status & "', '" & Revision & "', '" & Sequence & "')")

        '    'ElseIf ds.Tables("RecordIDParent").Rows.Count > 2 Then

        '    'End If



        '    c += 1
        '    ds.Tables("RecordIDParent").Clear()
        '    ds.Tables("RecordIDParent").Dispose()
        'End While

        'ds.Tables("ChildrenRecords").Clear()
        'ds.Tables("ChildrenRecords").Dispose()
        'DrawingNum = ""
        'DrawingNumOrig = ""
        'System = ""
        'Title = ""
        'Status = ""
        'Revision = ""
        'Sequence = ""
        'RecordID = ""


        ''-----------------------------------------------------------------------------------------------------------------------------------------------


        ''Get All Other Children
        ''If DrawingsOnlyOrBoth = "DrawingsOnly" Then
        ''    da = New SqlClient.SqlDataAdapter("Select * From tblTree Where DrawingNumber NOT IN (" & InList & ") And (NewRework = 'Drawing' Or NewRework = 'New Drawing' Or NewRework = 'Rework Drawing') And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By DrawingNumOriginal", frmEngWorkflowTree.SqlConnection1)
        ''Else
        'da = New SqlClient.SqlDataAdapter("Select * From tblTree Where DrawingNumber NOT IN (" & InList & ") And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By DrawingNumOriginal", frmEngWorkflowTree.SqlConnection1)
        ''End If

        'da.Fill(ds, "ChildrenRecords")

        'c = 0
        'While c <= ds.Tables("ChildrenRecords").Rows.Count - 1

        '    If IsDBNull(ds.Tables("ChildrenRecords").Rows(c).Item("SystemDescription")) Then
        '        System = ""
        '    Else
        '        System = ds.Tables("ChildrenRecords").Rows(c).Item("SystemDescription")
        '    End If
        '    DrawingNum = ds.Tables("ChildrenRecords").Rows(c).Item("DrawingNumber")
        '    DrawingNumOrig = ds.Tables("ChildrenRecords").Rows(c).Item("DrawingNumOriginal")
        '    Title = ds.Tables("ChildrenRecords").Rows(c).Item("DrawingTitleChildren")
        '    Status = ds.Tables("ChildrenRecords").Rows(c).Item("Status")
        '    Revision = ds.Tables("ChildrenRecords").Rows(c).Item("DwgRevision")
        '    Sequence = ds.Tables("ChildrenRecords").Rows(c).Item("Seq")
        '    'Dim SystDesc As String = ds.Tables("ChildrenRecords").Rows(c).Item("SystemDescription")
        '    If IsDBNull(ds.Tables("ChildrenRecords").Rows(c).Item("NewRework")) Then
        '        NewRework = ""
        '    Else
        '        NewRework = ds.Tables("ChildrenRecords").Rows(c).Item("NewRework")
        '    End If

        '    'Get RecordID of Parent, to Insert Into NextHigherAssembly
        '    da = New SqlClient.SqlDataAdapter("Select RecordID From tblTreeTemporary Where DrawingNumOriginal = '" & DrawingNum & "' And TreeToGetRecordID = '" & RecIDTreeToGet & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", frmEngWorkflowTree.SqlConnection1)
        '    da.Fill(ds, "RecordIDParent")

        '    Dim d As Integer = 0
        '    If ds.Tables("RecordIDParent").Rows.Count > 0 Then

        '        While d <= ds.Tables("RecordIDParent").Rows.Count - 1

        '            RecordID = ds.Tables("RecordIDParent").Rows(d).Item("RecordID")

        '            u.ExecuteSQL(frmEngWorkflowTree.SqlConnection1, "INSERT into tblTreeTemporary (NextHigherAssembly,SystemDescription,DrawingNumber,DrawingNumOriginal,DrawingTitle,Status,DwgRevision,Seq,TreeToGetRecordID) Values ('" & RecordID & "', '" & u.FTM(System) & "', '" & DrawingNum & "', '" & DrawingNumOrig & "', '" & u.FTM(Title) & "', '" & Status & "', '" & Revision & "', '" & Sequence & "', '" & RecIDTreeToGet & "')")
        '            d += 1
        '        End While

        '        ds.Tables("RecordIDParent").Clear()
        '        ds.Tables("RecordIDParent").Dispose()
        '    Else
        '        u.ExecuteSQL(frmEngWorkflowTree.SqlConnection1, "INSERT into tblTreeTemporary (DrawingNumber,DrawingNumOriginal,DrawingTitle,Status,DwgRevision,Seq,TreeToGetRecordID,SystemDescription) Values ('" & DrawingNum & "', '" & DrawingNumOrig & "', '" & u.FTM(Title) & "', '" & Status & "', '" & Revision & "', '" & Sequence & "', '" & RecIDTreeToGet & "', '" & System & "')")
        '    End If

        '    c += 1
        'End While

        'ds.Tables("ChildrenRecords").Clear()
        'ds.Tables("ChildrenRecords").Dispose()
        'DrawingNum = ""
        'DrawingNumOrig = ""
        'System = ""
        'Title = ""
        'Status = ""
        'Revision = ""
        'Sequence = ""
        'RecordID = ""


        ''-----------------------------------------------------------------------------------------------------------------------------------------------


        ''Update NextHigherAssembly of All Records That Do Not Have One; because the process above maybe did Not have a record for a higher assembly
        'da = New SqlClient.SqlDataAdapter("Select * From tblTreeTemporary Where (NextHigherAssembly = '' Or NextHigherAssembly Is Null) And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted' Order By DrawingNumOriginal", frmEngWorkflowTree.SqlConnection1)
        'da.Fill(ds, "RecordsWithEmptyAssembly")

        'If ds.Tables("RecordsWithEmptyAssembly").Rows.Count > 0 Then

        '    Dim f As Integer = 0
        '    While f <= ds.Tables("RecordsWithEmptyAssembly").Rows.Count - 1

        '        If IsDBNull(ds.Tables("RecordsWithEmptyAssembly").Rows(f).Item("SystemDescription")) Then
        '            System = ""
        '        Else
        '            System = ds.Tables("RecordsWithEmptyAssembly").Rows(f).Item("SystemDescription")
        '        End If

        '        If IsDBNull(ds.Tables("RecordsWithEmptyAssembly").Rows(f).Item("DrawingNumber")) Then
        '            DrawingNum = ""
        '        Else
        '            DrawingNum = ds.Tables("RecordsWithEmptyAssembly").Rows(f).Item("DrawingNumber")
        '        End If

        '        DrawingNumOrig = ds.Tables("RecordsWithEmptyAssembly").Rows(f).Item("DrawingNumOriginal")

        '        If IsDBNull(ds.Tables("RecordsWithEmptyAssembly").Rows(f).Item("DrawingTitleChildren")) Then
        '            Title = ""
        '        Else
        '            Title = ds.Tables("RecordsWithEmptyAssembly").Rows(f).Item("DrawingTitleChildren")
        '        End If

        '        Status = ds.Tables("RecordsWithEmptyAssembly").Rows(f).Item("Status")
        '        Revision = ds.Tables("RecordsWithEmptyAssembly").Rows(f).Item("DwgRevision")
        '        Sequence = ds.Tables("RecordsWithEmptyAssembly").Rows(f).Item("Seq")

        '        If IsDBNull(ds.Tables("RecordsWithEmptyAssembly").Rows(f).Item("NewRework")) Then
        '            NewRework = ""
        '        Else
        '            NewRework = ds.Tables("RecordsWithEmptyAssembly").Rows(f).Item("NewRework")
        '        End If

        '        Dim RecordIDFirst As String = ds.Tables("RecordsWithEmptyAssembly").Rows(f).Item("RecordID")

        '        ''Delete From tblTreeTemporary the Record That Does Not Have an Assembly(NextHigherAssembly is empty). This Same Record Will Be Re-Created With NextHigherAssembly Populated
        '        'u.ExecuteSQL(frmEngWorkflowTree.SqlConnection1, "Delete From tblTreeTemporary Where RecordIDFirst = '" & RecordID & "'")

        '        'Re-Enter the Record Just Deleted But Populated the NextHigherAssembly Field Now
        '        da = New SqlClient.SqlDataAdapter("Select RecordID From tblTreeTemporary Where DrawingNumOriginal = '" & DrawingNum & "' And TreeToGetRecordID = '" & RecIDTreeToGet & "' And Status != 'Cancelled' And Status != 'Obsolete' And Status != 'Canceled' And Status != 'Deleted'", frmEngWorkflowTree.SqlConnection1)
        '        da.Fill(ds, "RecordIDParent")

        '        Dim d As Integer = 0
        '        If ds.Tables("RecordIDParent").Rows.Count > 0 Then

        '            While d <= ds.Tables("RecordIDParent").Rows.Count - 1

        '                RecordID = ds.Tables("RecordIDParent").Rows(d).Item("RecordID")

        '                If d = 0 Then
        '                    u.ExecuteSQL(frmEngWorkflowTree.SqlConnection1, "Update tblTreeTemporary Set NextHigherAssembly = '" & RecordID & "' Where RecordID = '" & RecordIDFirst & "'")
        '                Else
        '                    u.ExecuteSQL(frmEngWorkflowTree.SqlConnection1, "INSERT into tblTreeTemporary (NextHigherAssembly,SystemDescription,DrawingNumber,DrawingNumOriginal,DrawingTitle,Status,DwgRevision,Seq,TreeToGetRecordID) Values ('" & RecordID & "', '" & u.FTM(System) & "', '" & DrawingNum & "', '" & DrawingNumOrig & "', '" & u.FTM(Title) & "', '" & Status & "', '" & Revision & "', '" & Sequence & "', '" & RecIDTreeToGet & "')")
        '                End If

        '                d += 1
        '            End While

        '            ds.Tables("RecordIDParent").Clear()
        '            ds.Tables("RecordIDParent").Dispose()

        '        Else
        '            'Nothing

        '            'u.ExecuteSQL(frmEngWorkflowTree.SqlConnection1, "INSERT into tblTreeTemporary (DrawingNumber,DrawingNumOriginal,DrawingTitle,Status,DwgRevision,Seq) Values ('" & DrawingNum & "', '" & DrawingNumOrig & "', '" & u.FTM(Title) & "', '" & Status & "', '" & Revision & "', '" & Sequence & "')")
        '        End If

        '        f += 1
        '    End While

        '    ds.Tables("RecordsWithEmptyAssembly").Clear()
        '    ds.Tables("RecordsWithEmptyAssembly").Dispose()
        'End If

        'DrawingNum = ""
        'DrawingNumOrig = ""
        'System = ""
        'Title = ""
        'Status = ""
        'Revision = ""
        'Sequence = ""
        'RecordID = ""


        ''-----------------------------------------------------------------------------------------------------------------------------------------------

        'u.ExecuteSQL(frmEngWorkflowTree.SqlConnection1, "Update tblTreeToGet Set Completed = 'True', DateCompleted = '" & Now & "' Where RecordID = '" & RecIDTreeToGet & "'")
        'u.ExecuteSQL(frmEngWorkflowTree.SqlConnection1, "Delete From tblTreeTemporary Where TreeToGetRecordID != '" & RecIDTreeToGet & "'")
        'RecIDTreeToGet = ""




        '***CREATE TREE --------------------------------------------------------------------------------------------------------------------------------

        'Get the RecordID so we know what records to get
        Dim RecID As String
        da = New SqlClient.SqlDataAdapter("Select Top 1 RecordID From tblTreeToGet Where Completed = 'True' Order By RecordID Desc", frmEngWorkflowTree.SqlConnection1)
        da.Fill(ds, "RecIDTree")


        If ds.Tables("RecIDTree").Rows.Count = 0 Then
            MsgBox("There are not any records yet in the table for the Tree")
        Else
            RecID = ds.Tables("RecIDTree").Rows(0).Item("RecordID")
        End If

        ds.Tables("RecIDTree").Clear()
        ds.Tables("RecIDTree").Dispose()


        'Check if get all records(Drawings + Reports) or just the Drawings
        Dim DrawOrDrawReport As String
        '******** UNCOMMENT NEXT 5 LINES WHEN PROGRAM GOES TO DEVELOPMENT
        'If DrawingsOnlyOrBoth = "DrawingsOnly" Then
        '    DrawOrDrawReport = "And (NewRework = 'Drawing' Or NewRework = 'New Drawing' Or NewRework = 'Rework Drawing')"
        'Else
        '    DrawOrDrawReport = ""
        'End If
        ''Dim DrawOrDrawReport As String = ""



        Dim listData As List(Of TreeData) = New List(Of TreeData)()

        'Get Parent Records
        da = New SqlClient.SqlDataAdapter("Select * From tblTreeTemporary Where TreeToGetRecordID = '" & RecID & "' And (NextHigherAssembly = '' Or NextHigherAssembly Is Null Or NextHigherAssembly = 'N/A') " & DrawOrDrawReport & " Order By DrawingNumOriginal, SystemDescription", frmEngWorkflowTree.SqlConnection1)
        da.Fill(ds, "RecordsForTree")
        a = 1

GETRECORDSWITHASSEMBLY:
        If a > 1 Then
            da = New SqlClient.SqlDataAdapter("Select * From tblTreeTemporary Where TreeToGetRecordID = '" & RecID & "' And (NextHigherAssembly != '' Or NextHigherAssembly Is Not Null Or NextHigherAssembly != 'N/A') " & DrawOrDrawReport & " Order By DrawingNumOriginal", frmEngWorkflowTree.SqlConnection1)
            da.Fill(ds, "RecordsForTree")
        End If


        If ds.Tables("RecordsForTree").Rows.Count > 0 Then
NEXTRECORD:
            c = 0

            While c <= ds.Tables("RecordsForTree").Rows.Count - 1
                If IsDBNull(ds.Tables("RecordsForTree").Rows(c).Item("NextHigherAssembly")) Then
                    NextAssembly = ""
                Else
                    NextAssembly = ds.Tables("RecordsForTree").Rows(c).Item("NextHigherAssembly")
                End If

                DrawingNum = ds.Tables("RecordsForTree").Rows(c).Item("DrawingNumOriginal")
                RecordID = ds.Tables("RecordsForTree").Rows(c).Item("RecordID")
                Status = ds.Tables("RecordsForTree").Rows(c).Item("Status")

                'Per Owen 09/10/21, uncommented next 3 lines and corresponding End If because the System field will contain data for all records and not just the parent records
                'If a > 1 Then
                '    System = ""
                'Else
                If IsDBNull(ds.Tables("RecordsForTree").Rows(c).Item("SystemDescription")) Then
                    System = ""
                Else
                    System = ds.Tables("RecordsForTree").Rows(c).Item("SystemDescription")
                End If
                'End If

                If IsDBNull(ds.Tables("RecordsForTree").Rows(c).Item("DwgRevision")) Then
                    Revision = ""
                Else
                    Revision = ds.Tables("RecordsForTree").Rows(c).Item("DwgRevision")
                End If

                'If a > 1 Then
                If IsDBNull(ds.Tables("RecordsForTree").Rows(c).Item("DrawingTitle")) Then  'DrawingTitleChildren
                    Title = ""
                Else
                    Title = ds.Tables("RecordsForTree").Rows(c).Item("DrawingTitle")        'DrawingTitleChildren
                End If
                'Else
                '    Title = ds.Tables("RecordsForTree").Rows(c).Item("DrawingTitle")
                'End If


                If IsDBNull(ds.Tables("RecordsForTree").Rows(c).Item("NewRework")) Then
                    NewRework = ""
                Else
                    NewRework = ds.Tables("RecordsForTree").Rows(c).Item("NewRework")
                End If

                If IsDBNull(ds.Tables("RecordsForTree").Rows(c).Item("DrawingOrReport")) Then
                    DrawingOrReport = ""
                Else
                    DrawingOrReport = ds.Tables("RecordsForTree").Rows(c).Item("DrawingOrReport")
                End If

                c = c + 1


                'Do not create a hierarchy if it is a report
                If a > 1 Then
                    listData.Add(New TreeData(RecordID, DrawingNum, NextAssembly, System, Status, Revision, Title))
                Else
                    listData.Add(New TreeData(RecordID, DrawingNum, NextAssembly, System, Status, Revision, Title))
                End If
            End While
        End If

        'Just got the parent records, the ones without the Assembly field. Now get the children, the ones with the Assembly field populated
        If a = 1 Then
            a += 1
            c = 0
            ds.Tables("RecordsForTree").Clear()
            ds.Tables("RecordsForTree").Dispose()
            GoTo GETRECORDSWITHASSEMBLY
        End If

        Return listData

    End Function

End Class