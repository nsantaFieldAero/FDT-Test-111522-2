Imports System.Windows.Forms
Imports System.Data.SqlClient
'Imports apInterface
Module modUtility
    Public Function FillRecordset(ByRef sql As String)  ', Optional ByRef theCursorType As ADODB.CursorTypeEnum = ADODB.CursorTypeEnum.adOpenForwardOnly, Optional ByRef theLockType As ADODB.LockTypeEnum = ADODB.LockTypeEnum.adLockReadOnly) As Boolean
        Dim sCmd = New SqlClient.SqlCommand(sql, gconn)
        'Fills passed recordset with records defined in SQL strifined in Sng.
        On Error GoTo FillError

        gconn.Open()

        rs = sCmd.ExecuteReader

        FillRecordset = True
        System.Windows.Forms.Application.DoEvents()
        Exit Function
FillError:
        FillRecordset = False
        MsgBox("There was an error while accessing the data." & vbLf & "Error: " & Err.Description & "." & vbLf & "SQL = " & sql, MsgBoxStyle.Exclamation)
    End Function
    Public Function FTM(ByRef theStr As String) As String
        ' The function Fixes Tick Marks or FixTicks
        FTM = Trim(Replace(theStr, "'", "''"))
    End Function
    Public Function ProperCase(ByVal theString As String) As String
        ' Function capitalizes first letter of each word in the string
        ProperCase = StrConv(theString, VbStrConv.ProperCase)
    End Function
    Public Sub addNode(ByVal tv As TreeView, ByVal Parent As Boolean, ByVal Text As String, ByVal Tag As String, ByVal ImageIndex As Integer, ByVal SelectedImageIndex As Integer, Optional ByVal atRoot As Boolean = False)
        Dim theNode As TreeNode
        If atRoot Then
            theNode = tv.SelectedNode.Parent.Parent.Nodes.Add(Text)
        ElseIf Parent Then
            theNode = tv.SelectedNode.Parent.Nodes.Add(Text)
        Else
            theNode = tv.SelectedNode.Nodes.Add(Text)
        End If
        theNode.Tag = Tag
        theNode.ImageIndex = ImageIndex
        theNode.SelectedImageIndex = SelectedImageIndex
        tv.SelectedNode = theNode
    End Sub
    Public Sub AutoSizeCol(ByVal lv As ListView)
        Dim ch As ColumnHeader
        For Each ch In lv.Columns
            ch.Width = -2
        Next
    End Sub
    Public Sub CenterForm(ByRef theForm As Form)
        'Centers passed on the screen
        theForm.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Public Sub CenterForm2(ByRef theForm As Form)
        theForm.StartPosition = FormStartPosition.CenterParent
    End Sub
    Public Function ExecuteSQL(ByRef sql As String) As Boolean
        'Executes a passed SQL string and returns true/false based on outcome
        Dim sCmd As New SqlCommand(sql, gconn)

        On Error GoTo ExecError
        ExecuteSQL = False
        sCmd.Connection.Open()
        sCmd.ExecuteNonQuery()
        sCmd.Connection.Close()
        ExecuteSQL = True
        Exit Function

ExecError:
        MsgBox("There was an error while executing SQL statement." & vbLf & "Error: " & ErrorToString() & "." & vbLf & "SQL = " & sql, MsgBoxStyle.Exclamation)
    End Function
    Public Function FillDataSet(ByRef theDS As DataSet, ByVal sql As String) ', Optional ByVal theTable As String)
        Dim theCMD As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, gconn)
        Dim theDA As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter()
        theCMD.Connection.Open()
        theDA.SelectCommand = theCMD
        theDS = New DataSet()
        theDA.Fill(theDS) ', theTable)
        theCMD.Connection.Close()
    End Function
    Public Sub SetCombo(ByRef cbo As ComboBox, ByRef theID As Integer)
        'Sets passed combo to passed ID in list
        cbo.SelectedIndex = -1
        cbo.SelectedValue = 0
        If theID = 0 Then Exit Sub
        cbo.SelectedValue = theID
    End Sub
    Public Function GetCheck(ByRef Chk As CheckBox) As Short
        'Return value of passed checkbox
        GetCheck = -Chk.CheckState
    End Function
    Public Function FillListView(ByRef sql As String, ByRef FillList As ListView, Optional ByRef bPreserve As Boolean = False, Optional ByRef Capitalize As Boolean = False, Optional ByRef DecPlaces As String = "") As Boolean
        Dim xitm As New ListViewItem()
        FillListView = False
        FillList.BeginUpdate()
        On Error GoTo FillListError
        FillRecordset(sql)

        WaitOn()

        FillList.Items.Clear()

        While rs.Read
            Select Case rs.Item(1).GetType.ToString
                Case "System.DBNull"
                    xitm = FillList.Items.Add("")
                Case "System.DateTime"
                    If rs.Item(1) = "1/1/1900" Then
                        xitm = FillList.Items.Add("")
                    Else
                        xitm = FillList.Items.Add(Format(rs.Item(1), "MM/dd/yyyy"))
                    End If
                Case "System.Double"
                    xitm = FillList.Items.Add(Format(rs.Item(1), "#,###,##0.00"))
                Case Else
                    If Capitalize Then
                        xitm = FillList.Items.Add(ProperCase(rs.Item(1)))
                    Else
                        xitm = FillList.Items.Add(rs.Item(1))
                    End If
            End Select
            xitm.Tag = rs.Item(0)

            For i = 2 To rs.FieldCount - 1
                If UCase(rs.GetName(i)) = "ACTIVE" Then
                    If CBool(rs.Item(i)) Then
                        xitm.Checked = True
                        GoTo NextItem
                    End If
                End If
                Select Case rs.Item(i).GetType.ToString
                    Case "System.DBNull"
                        xitm.SubItems.Add("")
                    Case "System.Int16"
                        If CBool(rs.Item(i)) Then
                            xitm.SubItems.Add(Format(rs.Item(i), "Yes/No"))
                        Else
                            xitm.SubItems.Add("")
                        End If
                    Case "System.DateTime"
                        If rs.Item(i) = "1/1/1900" Then
                            xitm.SubItems.Add("")
                        Else
                            xitm.SubItems.Add(Format(rs.Item(i), "MM/dd/yyyy"))
                        End If
                    Case "System.Double"
                        xitm.SubItems.Add(Format(rs.Item(i), "#,###,##0.00"))
                    Case Else
                        xitm.SubItems.Add(ProperCase(rs.Item(i)))
                End Select
NextItem:
            Next
        End While
        rs.Close()
        gconn.Close()
        FillListView = True
        FillList.EndUpdate()
        WaitOff()
        Exit Function
FillListError:
        MsgBox(ErrorToString())
    End Function
    Public Function gLoadCombo(ByRef cbo As ComboBox, ByRef sql As String, Optional ByRef Capitalize As Boolean = False, Optional ByRef PreserveItems As Boolean = False, Optional ByRef IncludeBlankItem As Boolean = False) As Boolean
        'Loads passed combo box with sql data - additional passed params format cbo. Returns boolean based on success/failure

        ' SQL string should return at least two fields:
        ' ID - with the ID to be used in ItemData
        ' DESCRIPTION - with description of the Item
        Dim cboDataSet As DataSet = New DataSet("cboDataSet")
        Dim cboTable As DataTable = New DataTable("cboTable")

        On Error GoTo LoadError

        cbo.BeginUpdate()

        gLoadCombo = False
        cbo.DataSource = Nothing

        If Not PreserveItems Then
            cbo.Items.Clear()
        End If

        cboTable.Columns.Add("ID", System.Type.GetType("System.Int32"))
        cboTable.Columns.Add("Description", System.Type.GetType("System.String"))

        cboDataSet.Tables.Add(cboTable)

        FillRecordset(sql)

        If IncludeBlankItem Then
            cboDataSet.Tables("cboTable").Rows.Add(New Object() {0, ""})
        End If
        WaitOn()
        While rs.Read()
            If Capitalize Then
                cboDataSet.Tables("cbotable").Rows.Add(New Object() {ISN(rs.Item("ID"), True), ProperCase(ISN(rs.Item("Description")))})
            Else
                cboDataSet.Tables("cbotable").Rows.Add(New Object() {ISN(rs.Item("ID"), True), ISN(rs.Item("Description"))})
            End If
        End While
        cbo.DataSource = cboDataSet.Tables("cboTable")
        cbo.DisplayMember = cboDataSet.Tables("cboTable").Columns("Description").ColumnName
        cbo.ValueMember = cboDataSet.Tables("cboTable").Columns("ID").ColumnName
        rs.Close()
        gconn.Close()

        cbo.SelectedIndex = -1
        cbo.Text = ""

        cboDataSet = Nothing
        cboTable = Nothing

        cbo.EndUpdate()
        WaitOff()
        Exit Function
LoadError:
        MsgBox(Err.Description)
        rs.Close()
    End Function
    Public Function LoadCombo(ByRef cbo As ComboBox, ByRef sql As String, Optional ByRef Capitalize As Boolean = False, Optional ByRef PreserveItems As Boolean = False) As Boolean
        'Loads passed combo box with sql data - additional passed params format cbo. Returns boolean based on success/failure

        ' SQL string should return at least two fields:
        ' ID - with the ID to be used in ItemData
        ' DESCRIPTION - with description of the Item
        Dim theCMD As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, gconn)
        Dim theDA As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter()
        Dim theDS As New DataSet()

        theDA.SelectCommand = theCMD
        theDA.Fill(theDS)
        cbo.DataSource = theDS.Tables(0)
        cbo.DisplayMember = theDS.Tables(0).Columns(1).ColumnName
        cbo.ValueMember = theDS.Tables(0).Columns(0).ColumnName
        If Capitalize Then
            For i = 0 To theDS.Tables(0).Rows.Count - 1
                theDS.Tables(0).Rows(i).Item(1) = ProperCase(theDS.Tables(0).Rows(i).Item(1))
            Next
        End If
        theDS = Nothing
        theDA = Nothing
        Exit Function
LoadError:
    End Function
    Public Function ISN(ByVal theValue As Object, Optional ByVal IsNumber As Boolean = False) As Object
        'Examines passed value and returns value based on passed boolean
        If IsDBNull(theValue) Then
            If IsNumber Then
                ISN = 0
            Else
                ISN = ""
            End If
        Else
            If IsNumber Then
                ISN = theValue
            Else
                ISN = Trim(theValue)
            End If
        End If
    End Function
    Public Function HasRight(ByVal RightID As Long) As Boolean
        ''Returns boolean based on whether passed long has rights
        'Dim obj As New clsUserRight()

        'On Error Resume Next
        'HasRight = False

        'For Each obj In CurrentUser.Permissions
        '    If obj.PermissionID = RightID Then HasRight = True
        'Next
    End Function
    Public Sub HideUpdateButtons()
        'Dim iCount As Short

        'With frmMain.DefInstance.tbToolBar.Buttons
        '    For iCount = 0 To 3
        '        .Item(iCount).Visible = False
        '    Next
        'End With
    End Sub
    Public Sub HL()
        'Highlights all text in a field
        Dim theTextBox As TextBox
        theTextBox = Form.ActiveForm.ActiveMdiChild.ActiveControl

        On Error Resume Next

        theTextBox.SelectionStart = 0
        theTextBox.SelectionLength = theTextBox.Text.Length

    End Sub
    Public Function LoadComboDays(ByRef cbo As ComboBox, Optional ByRef MonthNumber As Short = 1) As Boolean
        'Adds days to passed cbo and returns boolean based on success/failure

        On Error GoTo LoadError
        Dim i As Short
        Dim Days As Short

        LoadComboDays = False

        ' this will get us number of the days in the given month
        Days = Microsoft.VisualBasic.Day(DateSerial(2000, MonthNumber + 1, 1 - 1))
        'Clear Combo
        cbo.Items.Clear()
        For i = 1 To Days
            cbo.Items.Add(CStr(i))
            cbo.Items.Item(i) = i
        Next

        LoadComboDays = True

        Exit Function
LoadError:
    End Function
    Public Function LoadComboMonths(ByRef cbo As ComboBox, Optional ByRef Abbrev As Boolean = True) As Boolean
        'Adds months to passed cbo and returns boolean based on success/failure

        On Error GoTo LoadError

        LoadComboMonths = False
        'Clear Combo
        cbo.Items.Clear()
        For i = 1 To 12
            cbo.Items.Add(i)
            cbo.Items.Item(i) = MonthName(i, Abbrev)
        Next

        LoadComboMonths = True

        Exit Function
LoadError:
    End Function
    Public Function LoadComboYears(ByRef cbo As ComboBox, Optional ByRef Start As Short = 0, Optional ByRef Years As Short = 0) As Boolean
        'Adds years to passed cbo and returns boolean based on success/failure

        On Error GoTo LoadError
        Dim i As Short

        LoadComboYears = False
        cbo.Items.Clear()
        If Start = 0 Then
            Start = 1995
        End If
        If Years = 0 Then
            Years = 15
        End If
        For i = Start To Start + Years
            cbo.Items.Add(CStr(i)) 
        Next

        LoadComboYears = True

        Exit Function
LoadError:
    End Function
    Public Function RoundX(ByRef Num As Object) As Object
        'Rounds passed variant to specific  length and returns it as variant
        If Num < 1 Then
            RoundX = System.Math.Round(Num, 3)
        ElseIf Num < 10 Then
            RoundX = System.Math.Round(Num, 2)
        ElseIf Num < 100 Then
            RoundX = System.Math.Round(Num, 1)
        Else
            RoundX = Num
        End If
    End Function
    Public Sub SearchComboBox(ByRef combo As ComboBox, ByRef KeyCode As Short)
        'Looks in passed cbo for passed keycode and selects it

        Dim sTempString As String
        Dim Index As Integer

        If KeyCode >= System.Windows.Forms.Keys.D0 And KeyCode <= System.Windows.Forms.Keys.Divide Then 'KEY_A And KeyCode <= KEY_Z Then
            'only look at appropriate keys
            sTempString = combo.Text
            Index = combo.FindString(sTempString)
            combo.SelectedIndex = Index
            combo.SelectionStart = Len(sTempString)
            combo.SelectionLength = Len(combo.Text) - (Len(sTempString))
        End If
    End Sub
    'Public Sub SetcboSecurity(ByVal thegb As GroupBox)
    '    Dim this As Control
    '    Select Case CurrentUser.UserTypeID
    '        Case Is < 2
    '            For Each this In thegb.Controls
    '                If TypeOf this Is ComboBox Then
    '                    Select Case Mid(this.Name, 4)
    '                        Case "TimeGroup", "ToTimeGroup"
    '                            this.Enabled = False
    '                        Case "Department", "ToDepartment"
    '                            this.Enabled = False
    '                        Case "Employee", "ToEmployee"
    '                            this.Enabled = False
    '                    End Select
    '                End If
    '            Next
    '        Case Is < 3
    '            For Each this In thegb.Controls
    '                If TypeOf this Is ComboBox Then
    '                    Select Case Mid(this.Name, 4)
    '                        Case "TimeGroup", "ToTimeGroup"
    '                            this.Enabled = False
    '                        Case "Department", "ToDepartment"
    '                            this.Enabled = False
    '                    End Select
    '                End If
    '            Next
    '        Case Is < 4
    '            For Each this In thegb.Controls
    '                If TypeOf this Is ComboBox Then
    '                    Select Case Mid(this.Name, 4)
    '                        Case "TimeGroup", "ToTimeGroup"
    '                            this.Enabled = False
    '                    End Select
    '                End If
    '            Next
    '    End Select
    'End Sub
    Public Sub SetCheck(ByRef Chk As CheckBox, Optional ByRef theVal As Object = Nothing)
        'With passed checkbox, set it's value to 0 or 1
        If CShort(theVal) <> 0 Then
            Chk.CheckState = CheckState.Checked
        Else
            Chk.CheckState = CheckState.Unchecked
        End If
    End Sub
    Public Sub SetComboFromText(ByRef cbo As ComboBox, ByRef theStr As String)
        'Sets passed cbo to Index based on passed string
        cbo.SelectedIndex = cbo.FindStringExact(theStr)
    End Sub
    Sub ShowUpdateButtons(ByRef Records As Short)
        'Dim iCount As Short
        'With frmMain.DefInstance.tbToolBar.Buttons
        '    For iCount = 0 To 3
        '        .Item(iCount).Visible = False
        '    Next

        '    .Item(0).Visible = True

        '    If Records Then
        '        .Item(1).Visible = True
        '        .Item(2).Visible = True
        '        .Item(3).Visible = True
        '    End If
        'End With
    End Sub
    Public Function UpdatefromKey(ByRef KeyCode As Short) As Boolean
        'With frmMain.DefInstance.tbToolBar.Buttons
        '    If KeyCode = Keys.Insert And .Item(0).Visible = True Then
        '        frmMain.DefInstance.tbToolBar_ButtonClick(frmMain.DefInstance.tbToolBar, New ToolBarButtonClickEventArgs(frmMain.DefInstance.tbToolBar.Buttons(0)))
        '    ElseIf KeyCode = System.Windows.Forms.Keys.Return And .Item(1).Visible = True Then
        '        frmMain.DefInstance.tbToolBar_ButtonClick(frmMain.DefInstance.tbToolBar, New ToolBarButtonClickEventArgs(frmMain.DefInstance.tbToolBar.Buttons(1)))
        '    ElseIf KeyCode = System.Windows.Forms.Keys.Delete And .Item(2).Visible = True Then
        '        frmMain.DefInstance.tbToolBar_ButtonClick(frmMain.DefInstance.tbToolBar, New ToolBarButtonClickEventArgs(frmMain.DefInstance.tbToolBar.Buttons(2)))
        '    End If
        'End With
    End Function
    Public Function YN(ByRef Chk As CheckBox) As String
        'Returns Yes/ based on value of passed checkbox
        YN = ""
        If Chk.CheckState = CheckState.Checked Then YN = "Yes"
    End Function
    Public Sub WaitOn()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
    End Sub
    Public Sub WaitOff()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub
End Module
