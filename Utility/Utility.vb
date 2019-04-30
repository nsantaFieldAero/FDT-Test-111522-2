Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Threading
Imports System
Imports System.IO
Imports Scripting
'Imports CDO

Public Class Utility
    'Some notes

    'Date manipulation
    'You can use the standard vb date functions (datediff, dateadd, etc.)
    'Or the date object methods i.e.
    'Dim d As Date = Now.AddDays(15)
    Private colBindings As Collection
    Public EmailerConn As New SqlClient.SqlConnection("data source=10.20.2.25;initial catalog=EMAILER;uid=emailer;pwd=ccemail$ervice;persist security info=False")
    Public gConn As New SqlClient.SqlConnection("data source=172.16.3.7\GETSMART;initial catalog=MASTER;uid=sa1;pwd=The water is wet!;persist security info=False")

    Public Sub displayContextMenuItems(ByVal contextMenu As ContextMenu, Optional ByVal hide As Boolean = False, Optional ByVal start As Integer = 0)
        If start < 1 Then start = 0

        With contextMenu.MenuItems
            .Item(0).Visible = True
            For i = start To .Count - 1
                .Item(i).Visible = True
                If hide Then .Item(i).Visible = False
            Next
        End With
    End Sub
    Public Function ExecuteORA(ByVal gConn As OracleClient.OracleConnection, ByRef sql As String, Optional ByVal displayError As Boolean = True) As Boolean
        'Executes a passed SQL string and returns true/false based on outcome
        Dim sCmd As New OracleClient.OracleCommand(sql, gConn)
        Try
            If sCmd.Connection.State = ConnectionState.Open Then
                sCmd.Connection.Close()
            End If
            sCmd.Connection.Open()
            sCmd.ExecuteNonQuery()
            sCmd.Connection.Close()
            ExecuteORA = True
        Catch ex As SystemException
            If displayError Then MsgBox("There was an error while executing SQL statement." & vbLf & "Error: " & ex.Message & "." & vbLf & "SQL = " & sql & +Err.Number, MsgBoxStyle.Exclamation)
            sCmd.Connection.Close()
        End Try
    End Function
    'Public Sub sendEmail(ByVal gconn As SqlConnection, ByVal toEmail As String, ByVal subject As String, ByVal body As String, ByVal gwUser As String, ByVal gwPassword As String)
    '    'Sends an email using sqlServer Master table stored procedure.
    '    Dim sql As String
    '    Try
    '        sql = "sp_Email '" + FTM(toEmail) + "','" + FTM(subject) + "','" + FTM(body) + "','" + FTM(gwUser) + "','" + FTM(gwPassword) + "'"
    '        ExecuteSQL(gconn, sql)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    'Public Sub sendEmail(ByVal gconn As SqlConnection, ByVal toEmail As String, ByVal subject As String, ByVal body As String)
    '    'Sends an email using sqlServer Master table xp_SendMail stored procedure.
    '    'Unfortunately, from what I've researched, you must have a MAPI client
    '    'such as Microsoft Outlook) installed on the computer that runs SQL Server.  
    '    Dim sql As String
    '    Try
    '        sql = "xp_Email @recipients = '" + FTM(toEmail) + "', @Subject = '" + FTM(subject) + "', @Message = '" + FTM(body) + "'"
    '        ExecuteSQL(gconn, sql)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Public Sub SendEmail(ByVal From As String, ByVal Recipient As String, ByVal Subject As String, ByVal Message As String)

        Dim sql As String
        Try
            sql = "sp_send_cdosysmail @From = '" + FTM(From) + "', @To = '" + FTM(Recipient) + "', @subject = '" & FTM(Subject) + "', @Body = '" + FTM(Message) + "'"
            ExecuteSQL(gConn, sql)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Public Sub sendEmailExchange(ByVal gconn As SqlConnection, ByVal fromEmail As String, ByVal toEmail As String, ByVal Subject As String, ByVal Body As String)
        'Sends email using sqlserver Master table cdosys for exchange
        Dim sql As String
        Try
            sql = "sp_send_cdosysmail '" + FTM(fromEmail) + "', '" + FTM(toEmail) + "', '" + FTM(Subject) + "', '" + FTM(Body) + "'"
            ExecuteSQL(gconn, sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub elapsedTime(ByVal theControl As Control, ByVal theDate As DateTime)
        elapsedTimeControl = theControl
        elapsedTimeDate = theDate
        elapsedTimeThread = New Thread(AddressOf showElaspedTime)
        elapsedTimeThread.Start()
    End Sub
    Public Sub showElaspedTime()
        Dim theValue As Single
        Dim theText As String
        Do
            Try
                theValue = DateDiff(Microsoft.VisualBasic.DateInterval.Minute, elapsedTimeDate, Now)
                theText = Int(theValue / 1440) & " day(s)"
                theValue = theValue - (Int(theValue / 1440) * 1440)
                theText += "  " & Int(theValue / 60) & " hr(s)"
                theValue = theValue - (Int(theValue / 60) * 60)
                theText += "  " & theValue & " min(s)"
                elapsedTimeControl.Text = theText
                'elapsedTimeThread.Sleep(60000)
                GC.Collect()
            Catch ex As Exception
            End Try
        Loop
    End Sub
    Public Function checkRequiredField(ByVal ctl As Control, ByVal msg As String) As Boolean
        checkRequiredField = False
        If TypeOf ctl Is ComboBox Then
            Dim cbo As ComboBox = ctl
            If cbo.SelectedIndex = -1 Then
                MessageBox.Show("A selection is required for " & msg & ".")
                Exit Function
            End If
        End If
        checkRequiredField = True
    End Function
    Public Sub stopElapsedTime(ByVal theControl As Control, ByVal theDate As DateTime)
        elapsedTimeThread.Abort()
    End Sub
    'Public Sub sendOutlookEmail(ByVal toEmail As String, ByVal subject As String, ByVal body As String, ByVal from As String)
    '    Dim o As Outlook.MailItemClass
    '    Dim mi As Outlook.MailItem

    '    mi.Subject = subject
    '    mi.Body = body
    '    mi.To = toEmail
    '    'mi.SenderName = from
    '    'mi.ReceivedByName = toEmail
    '    mi.Send()

    'End Sub
    Public Sub sendEmail(ByVal useCDO As Boolean, ByVal toEmail As String, ByVal subject As String, ByVal body As String, ByVal from As String)
        'Dim Configuration As New CDO.Configuration
        'Dim Fields
        'Fields = Configuration.Fields

        ''Fields("http://schemas.microsoft.com/cdo/configuration/sendusing") = "1"
        ''Fields("http://schemas.microsoft.com/cdo/configuration/smtpserverpickupdirectory") = "c:\inetpub\mailroot\pickup"
        'Fields("http://schemas.microsoft.com/cdo/configuration/sendusing") = "2"
        'Fields("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "10.20.2.30"
        'Fields("http://schemas.microsoft.com/cdo/configuration/savesentitems") = "True"
        'Configuration.Fields.Update()

        'Dim msgObj As New CDO.Message
        'Try
        '    With msgObj
        '        .Configuration = Configuration
        '        .Subject = subject
        '        .TextBody = body
        '        .To = toEmail
        '        .From = from
        '        .Send()
        '    End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message())
        'End Try
        'msgObj = Nothing
        'Configuration = Nothing
        'Fields = Nothing
    End Sub
    'Function sendEmail(ByRef fromAddress As String, ByVal toAddress As String, ByRef subject As String, ByRef message As String) As Boolean
    '    'Sends an email using web mail
    '    Try
    '        Dim oEmail As New System.Web.Mail.MailMessage
    '        With oEmail
    '            .BodyFormat = Web.Mail.MailFormat.Text '.Html
    '            .Body = FTM(message)
    '            .From = FTM(fromAddress)
    '            .To = FTM(toAddress)
    '            .Subject = FTM(subject)
    '        End With

    '        Dim oSendEmail As Web.Mail.SmtpMail
    '        oSendEmail.SmtpServer = "10.20.2.30"
    '        'oSendEmail.SmtpServer = "10.20.2.8"
    '        oSendEmail.Send(oEmail)

    '        oEmail = Nothing
    '        oSendEmail = Nothing
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function
    'Public Function sendEMail(ByRef mSession As MSMAPI.MAPISession, ByRef mMessage As MSMAPI.MAPIMessages, ByRef sSubject As String, ByRef sMessage As String, ByRef Address As String) As Boolean
    '    'Sends an email using vb6 MAPI control
    '    Try

    '        '********************************
    '        'TEMPORARY - FOR TESTING PURPOSES
    '        'Uncomment after testing
    '        'Exit Function
    '        '********************************

    '        'Do we want this or do we want to let it generate an error message
    '        'if it can't find the email address?
    '        If Address = "" Then Exit Function

    '        With mMessage
    '            .SessionID = mSession.SessionID
    '            .MsgIndex = -1
    '            .Compose()

    '            .RecipAddress = Address
    '            .RecipType = MSMAPI.RecipTypeConstants.mapToList
    '            .AddressResolveUI = True
    '            .ResolveName()

    '            ''Here we can add more recipients (i.e. primary support, staff assigned, etc.)
    '            '.RecipIndex = .RecipIndex + 1
    '            '.RecipType = mapCcList
    '            '.RecipAddress = "jwebster@co.clermont.oh.us"
    '            '.AddressResolveUI = True
    '            '.ResolveName

    '            .MsgNoteText = sMessage
    '            .MsgSubject = sSubject

    '            .MsgReceiptRequested = True
    '            .Send(False) 'True, if you want the email msg composer to come up.
    '        End With
    '    Catch ex As Exception
    '        If Err.Number = 32003 Then
    '            MsgBox("Message Failure")
    '        Else
    '            MsgBox("Unable to noftify, EMail Address not found")
    '        End If
    '    End Try
    'End Function
    'Public Function loginEMail(ByRef mSession As MSMAPI.MAPISession, ByVal emailProfileName As String) As Boolean
    '    'Note: Should do this at application startup or it slows things down too much.
    '    '************************************************************
    '    Try
    '        With mSession
    '            ' Set DownLoadMail to False to prevent immediate download.
    '            .DownLoadMail = False
    '            .LogonUI = True ' Use the underlying email system's logon UI.
    '            .UserName = emailProfileName 'This is the only way I could get it to work.
    '            .SignOn() ' Signon method.
    '            ' If successful, return True
    '            loginEMail = True
    '            ' Set NewSession to True and set 0
    '            ' variable flag to true
    '            .NewSession = True
    '        End With
    '        '************************************************************
    '    Catch ex As Exception
    '        If Err.Number = 32003 Then
    '            MsgBox("Email Login Error")
    '        End If
    '    End Try
    'End Function
    Public Sub loadComboDGColumns(ByVal dg As DataGrid, ByVal cbo As ComboBox)
        'Loads a combo with column headers from the sent datagrid.
        Dim csc As GridColumnStylesCollection
        Dim gcs As DataGridColumnStyle

        cbo.Items.Clear()

        csc = dg.TableStyles(0).GridColumnStyles
        For Each gcs In csc
            Try
                cbo.Items.Add(gcs.HeaderText)
            Catch
            End Try
        Next
        cbo.SelectedIndex = 0
    End Sub

    '    Public Sub searchDatagrid(ByVal dg As DataGrid, ByVal cm As CurrencyManager, ByVal txt As String, ByVal col As Integer, Optional ByVal all As Boolean = False, Optional ByVal startAtTop As Boolean = False)
    '        'Searches for and selects an item in the datagrid based on the sent text.
    '        'Problem: If the column being searched is wider than the datagrid, it blows up
    '        Dim r As Integer
    '        Dim s As Integer
    '        Dim found As Boolean
    '        Dim csc As GridColumnStylesCollection
    '        Dim gcs As DataGridColumnStyle
    '        Dim w As Integer

    '        Try
    '            dg.UnSelect(dg.CurrentRowIndex)

    '            csc = dg.TableStyles(0).GridColumnStyles

    '            If txt.Length = 0 Then
    '                dg.CurrentRowIndex = 0
    '                dg.Select(dg.CurrentRowIndex)
    '                Exit Sub
    '            End If

    '            If Not all Then
    '                w = csc(col).Width
    '                csc(col).Width = 1
    '            End If

    '            If UCase(txt) <= UCase(Mid(ISN(dg.Item(dg.CurrentRowIndex, col)), 1, Len(txt))) _
    '            Or startAtTop = True Then
    '                s = 0
    '            Else
    '                s = cm.Position
    '            End If
    '            For r = s To cm.Count - 1
    '                If all = True Then
    '                    'This looks in all columns
    '                    'csc = dg.TableStyles(0).GridColumnStyles
    '                    col = 0
    '                    For Each gcs In csc
    '                        Try
    '                            'MsgBox(dg.Item(r, col).GetType.ToString)

    '                            If dg.Item(r, col) Is DBNull.Value Then GoTo nextColumn
    '                            If dg.Item(r, col).GetType.ToString = "System.DateTime" Then
    '                                found = Format(dg.Item(r, col), "MM/dd/yyyy") Like UCase(txt) & "*"
    '                            ElseIf dg.Item(r, col).GetType.ToString = "System.Int32" Then
    '                                found = dg.Item(r, col) = txt
    '                            Else
    '                                found = UCase(dg.Item(r, col)) Like UCase(txt) & "*"
    '                            End If
    '                            If found Then
    '                                dg.CurrentRowIndex = r
    '                                Exit For
    '                            End If
    'nextColumn:
    '                            col += 1
    '                        Catch
    '                        End Try
    '                    Next
    '                    If found Then Exit For
    '                Else
    '                    Try

    '                        'MsgBox(dg.Item(r, col).GetType.ToString)

    '                        If dg.Item(r, col) Is DBNull.Value Then GoTo NextRow
    '                        If dg.Item(r, col).GetType.ToString = "System.DateTime" Then
    '                            found = Format(dg.Item(r, col), "MM/dd/yyyy") Like UCase(txt) & "*"
    '                        ElseIf dg.Item(r, col).GetType.ToString = "System.Int32" Then
    '                            found = dg.Item(r, col) = txt
    '                        Else
    '                            found = UCase(dg.Item(r, col)) Like UCase(txt) & "*"
    '                        End If
    '                        If found Then
    '                            dg.CurrentRowIndex = r
    '                            Exit For
    '                        End If
    '                    Catch ex As Exception
    '                        Exit For
    '                        'MsgBox(ex.Message)
    '                    End Try
    '                End If
    'nextRow:
    '            Next
    '            If Not all Then
    '                csc(col).Width = w
    '            End If
    '            dg.Select(dg.CurrentRowIndex)
    '        Catch ex As Exception
    '        End Try
    '    End Sub
    Public Sub searchDatagrid(ByVal dg As DataGrid, ByVal rowCount As Integer, ByVal txt As String, ByVal col As Integer, Optional ByVal all As Boolean = False, Optional ByVal startAtTop As Boolean = False)
        'Searches for and selects an item in the datagrid based on the sent text.
        Dim r As Integer
        Dim s As Integer
        Dim found As Boolean
        Dim csc As GridColumnStylesCollection
        Dim gcs As DataGridColumnStyle
        Dim w As Integer

        csc = dg.TableStyles(0).GridColumnStyles

        Try
            dg.UnSelect(dg.CurrentRowIndex)

            If txt.Length = 0 Then
                dg.CurrentRowIndex = 0
                dg.Select(dg.CurrentRowIndex)
                Exit Sub
            End If

            If Not all Then
                w = csc(col).Width
                csc(col).Width = 1
            End If

            If UCase(txt) <= UCase(Mid(dg.Item(dg.CurrentRowIndex, col), 1, Len(txt))) _
            Or startAtTop = True Then
                s = 0
            Else
                's = cm.Position
            End If
            For r = s To rowCount - 1
                If all = True Then
                    'This looks in all columns
                    'csc = dg.TableStyles(0).GridColumnStyles
                    col = 0
                    For Each gcs In csc
                        Try
                            If dg.Item(r, col).GetType.ToString = "System.DateTime" Then
                                found = Format(dg.Item(r, col), "MM/dd/yyyy") Like UCase(txt) & "*"
                            ElseIf dg.Item(r, col).GetType.ToString = "System.Int32" Then
                                found = dg.Item(r, col) = txt
                            Else
                                found = UCase(dg.Item(r, col)) Like UCase(txt) & "*"
                            End If
                            If found Then
                                dg.CurrentRowIndex = r
                                Exit For
                            End If
                            col += 1
                        Catch
                        End Try
                    Next
                    If found Then Exit For
                Else
                    Try
                        If dg.Item(r, col).GetType.ToString = "System.DateTime" Then
                            found = Format(dg.Item(r, col), "MM/dd/yyyy") Like UCase(txt) & "*"
                        ElseIf dg.Item(r, col).GetType.ToString = "System.Int32" Then
                            found = dg.Item(r, col) = txt
                        Else
                            found = UCase(dg.Item(r, col)) Like UCase(txt) & "*"
                        End If
                        If found Then
                            dg.CurrentRowIndex = r
                            Exit For
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Next
            If Not all Then
                csc(col).Width = w
            End If
            dg.Select(dg.CurrentRowIndex)
        Catch ex As Exception
        End Try
    End Sub
    Public Function FillRecordset(ByVal gConn As SqlConnection, ByRef sql As String) As SqlDataReader ', Optional ByRef theCursorType As ADODB.CursorTypeEnum = ADODB.CursorTypeEnum.adOpenForwardOnly, Optional ByRef theLockType As ADODB.LockTypeEnum = ADODB.LockTypeEnum.adLockReadOnly) As Boolean
        Dim sCmd As New SqlCommand(sql, gConn)
        'Fills datareader with records defined in SQL string
        'and returns the DataReader
        Try
            gConn.Open()

            rs = sCmd.ExecuteReader

            FillRecordset = rs
            sCmd = Nothing
            Exit Function
        Catch
            FillRecordset = Nothing
            MsgBox("There was an error while accessing the data." & vbLf & "Error: " & Err.Description & "." & vbLf & "SQL = " & sql, MsgBoxStyle.Exclamation)
        End Try
        sCmd = Nothing
    End Function
    Public Function FTM(ByRef theStr As String) As String
        ' The function Fixes Tick Marks or FixTicks
        Try
            FTM = Trim(Replace(theStr, "'", "''"))
        Catch ex As Exception
        End Try
    End Function

    Public Function ProperCase(ByVal theString As String) As String
        'Function capitalizes first letter of each word in the string
        ProperCase = StrConv(theString, VbStrConv.ProperCase)
    End Function
    Public Sub addNode(ByVal tv As TreeView, ByVal Parent As Boolean, ByVal Text As String, ByVal Tag As String, ByVal ImageIndex As Integer, ByVal SelectedImageIndex As Integer, Optional ByVal atRoot As Boolean = False)
        'Add a node to a treeview
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
    Public Sub addNode(ByVal nodeLevel As TreeNode, ByVal Text As String, ByVal Tag As String, ByVal ImageIndex As Integer, ByVal SelectedImageIndex As Integer, Optional ByVal atRoot As Boolean = False, Optional ByVal textColor As String = "")
        'Add a node to a treeview
        Dim theNode As TreeNode

        theNode = nodeLevel.Nodes.Add(Text)

        theNode.Tag = Tag
        theNode.ImageIndex = ImageIndex
        theNode.SelectedImageIndex = SelectedImageIndex
        If textColor <> "" Then theNode.ForeColor = Color.FromName(textColor)

    End Sub
    Public Sub AutoSizeCol(ByVal lv As ListView)
        'Auto-sizes the width of each column to the longest item.
        Dim ch As ColumnHeader
        For Each ch In lv.Columns
            ch.Width = -2
        Next
    End Sub
    'Sub AutoSizeCol(ByVal lv As AxMSComctlLib.AxListView)
    '    'Size columns in passed vb6 listview by lengths of column items
    '    With lv
    '        If .ListItems.Count > 0 Then
    '            For i = 1 To .ColumnHeaders.Count
    '                Call SendMessage(.hWnd, LVM_SETCOLUMNWIDTH, .ColumnHeaders(i).SubItemIndex, LVSCW_AUTOSIZE_USEHEADER)
    '            Next
    '        End If
    '    End With
    'End Sub
    Public Sub autoSizeCol(ByVal dg As DataGrid)
        'Size columns in passed datagrid by lengths of column items
        'Hopefully they'll allow a width property similar to the listview (-2) to do this automatically.
        Dim numRows As Integer
        Dim dv As DataView = dg.DataSource
        numRows = dv.Table.Rows.Count

        If numRows = 0 Then Exit Sub

        Dim csc As GridColumnStylesCollection
        Dim gcs As DataGridColumnStyle

        csc = dg.TableStyles(0).GridColumnStyles

        Dim width As Single
        Dim g As Graphics
        g = Graphics.FromHwnd(dg.Handle)
        Dim sf As StringFormat
        sf = New StringFormat(StringFormat.GenericTypographic)
        'This is used for taking care of leading and trailing padding of the etxt(field)
        'You can experiment with it to find the right padding factor for
        'your tables.
        Dim paddingFactorData As Integer = 15
        Dim paddingFactorHeader As Integer = 15
        'This var is used to check the size of the header text
        Dim headerSize As SizeF
        'Gets the size of the header text of the grid
        Dim col As Integer
        col = 0
        Try
            For Each gcs In csc
                width = 0
                headerSize = g.MeasureString(gcs.HeaderText, dg.Font, 500, sf)
                Dim size As SizeF
                Dim i As Integer
                i = 0

                Do While (i < numRows)
                    size = g.MeasureString(dg(i, col).ToString, dg.Font, 500, sf)
                    If (size.Width > width) Then
                        width = size.Width
                    End If
                    i = (i + 1)

                Loop

                'If the width of the header is less than the Maximum Column Data
                'width then use Max Column Width
                'Else Use the width of the column header
                If headerSize.Width < width Then
                    gcs.Width = CType(width, Integer) + (paddingFactorData)
                    'If gcs.Alignment <> HorizontalAlignment.Center Then gcs.Width = CType(width, Integer) + (paddingFactorData)
                    'This is for taking care of
                    'Padding of the text field
                Else
                    gcs.Width = CType(headerSize.Width, Integer) + (paddingFactorHeader) ' + 11
                    'If gcs.Alignment <> HorizontalAlignment.Center Then gcs.Width = CType(headerSize.Width, Integer) + (paddingFactorHeader)
                    'This is for taking
                    'care of Padding of the text field
                End If
                col += 1
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        g.Dispose()

    End Sub
    Public Sub autoSizeCol(ByVal dg As DataGrid, ByVal numRows As Integer)
        'Size columns in passed datagrid by lengths of column items
        'Hopefully they'll allow a width property similar to the listview (-2) to do this automatically.

        If numRows = 0 Then Exit Sub

        Dim csc As GridColumnStylesCollection
        Dim gcs As DataGridColumnStyle

        csc = dg.TableStyles(0).GridColumnStyles

        Dim width As Single
        Dim g As Graphics
        g = Graphics.FromHwnd(dg.Handle)
        Dim sf As StringFormat
        sf = New StringFormat(StringFormat.GenericTypographic)
        'This is used for taking care of leading and trailing padding of the etxt(field)
        'You can experiment with it to find the right padding factor for
        'your tables.
        Dim paddingFactorData As Integer = 15
        Dim paddingFactorHeader As Integer = 15
        'This var is used to check the size of the header text
        Dim headerSize As SizeF
        'Gets the size of the header text of the grid
        Dim col As Integer
        col = 0
        Try
            For Each gcs In csc
                width = 0
                headerSize = g.MeasureString(gcs.HeaderText, dg.Font, 500, sf)
                Dim size As SizeF
                Dim i As Integer
                i = 0

                Do While (i < numRows)
                    size = g.MeasureString(dg(i, col).ToString, dg.Font, 500, sf)
                    If (size.Width > width) Then
                        width = size.Width
                    End If
                    i = (i + 1)
                Loop

                'If the width of the header is less than the Maximum Column Data
                'width then use Max Column Width
                'Else Use the width of the column header
                If headerSize.Width < width Then
                    gcs.Width = CType(width, Integer) + (paddingFactorData)
                    'This is for taking care of
                    'Padding of the text field
                Else
                    gcs.Width = CType(headerSize.Width, Integer) + (paddingFactorHeader)
                    'This is for taking
                    'care of Padding of the text field
                End If
                col += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        g.Dispose()

    End Sub
    Public Sub autoSizeCol(ByVal dg As DataGrid, ByVal tbl As DataTable)
        'Size columns in passed datagrid by lengths of column items
        'Hopefully they'll allow a width property similar to the listview (-2) to do this automatically.
        Dim numRows As Integer
        dg.DataSource = tbl
        numRows = tbl.Rows.Count

        If numRows = 0 Then Exit Sub

        Dim csc As GridColumnStylesCollection
        Dim gcs As DataGridColumnStyle

        csc = dg.TableStyles(0).GridColumnStyles

        Dim width As Single
        Dim g As Graphics
        g = Graphics.FromHwnd(dg.Handle)
        Dim sf As StringFormat
        sf = New StringFormat(StringFormat.GenericTypographic)
        'This is used for taking care of leading and trailing padding of the etxt(field)
        'You can experiment with it to find the right padding factor for
        'your tables.
        Dim paddingFactorData As Integer = 15
        Dim paddingFactorHeader As Integer = 15
        'This var is used to check the size of the header text
        Dim headerSize As SizeF
        'Gets the size of the header text of the grid
        Dim col As Integer
        col = 0
        Try
            For Each gcs In csc
                width = 0
                headerSize = g.MeasureString(gcs.HeaderText, dg.Font, 500, sf)
                Dim size As SizeF
                Dim i As Integer
                i = 0

                Do While (i < numRows)
                    size = g.MeasureString(dg(i, col).ToString, dg.Font, 500, sf)
                    If (size.Width > width) Then
                        width = size.Width
                    End If
                    i = (i + 1)

                Loop

                'If the width of the header is less than the Maximum Column Data
                'width then use Max Column Width
                'Else Use the width of the column header
                If headerSize.Width < width Then
                    gcs.Width = CType(width, Integer) + (paddingFactorData)
                    'If gcs.Alignment <> HorizontalAlignment.Center Then gcs.Width = CType(width, Integer) + (paddingFactorData)
                    'This is for taking care of
                    'Padding of the text field
                Else
                    gcs.Width = CType(headerSize.Width, Integer) + (paddingFactorHeader)
                    'If gcs.Alignment <> HorizontalAlignment.Center Then gcs.Width = CType(headerSize.Width, Integer) + (paddingFactorHeader)
                    'This is for taking
                    'care of Padding of the text field
                End If
                col += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        g.Dispose()

    End Sub
    Public Sub CenterForm(ByRef theForm As Form)
        'Centers passed on the screen
        theForm.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Public Sub CenterForm2(ByRef theForm As Form)
        theForm.StartPosition = FormStartPosition.CenterParent
    End Sub
    Public Function ExecuteSQL(ByVal gConn As SqlConnection, ByRef sql As String, Optional ByVal displayError As Boolean = True) As Boolean
        'Executes a passed SQL string and returns true/false based on outcome
        Dim sCmd As New SqlCommand(sql, gConn)
        Try
            If sCmd.Connection.State = ConnectionState.Open Then
                sCmd.Connection.Close()
            End If
            sCmd.Connection.Open()
            sCmd.ExecuteNonQuery()
            sCmd.Connection.Close()
            ExecuteSQL = True
        Catch ex As SystemException
            If displayError Then MsgBox("There was an error while executing SQL statement." & vbLf & "Error: " & ex.Message & "." & vbLf & "SQL = " & sql & +Err.Number, MsgBoxStyle.Exclamation)
            sCmd.Connection.Close()
        End Try
    End Function
    Public Function ExecuteOLEDB(ByVal jConn As OleDb.OleDbConnection, ByRef sql As String) As Boolean
        Dim sCmd As New OleDb.OleDbCommand(sql, jConn)
        Try
            If sCmd.Connection.State = ConnectionState.Open Then
                sCmd.Connection.Close()
            End If
            sCmd.Connection.Open()
            sCmd.ExecuteNonQuery()
            sCmd.Connection.Close()
            ExecuteOLEDB = True
        Catch ex As Exception
            MsgBox("There was an error while executing OLEDB statement." & vbLf & "Error: " & ex.Message & "." & vbLf & "SQL = " & sql & +Err.Number, MsgBoxStyle.Exclamation)
        End Try
    End Function
    Public Function FillDataSet(ByVal gConn As SqlConnection, ByRef theDS As DataSet, ByVal sql As String) ', Optional ByVal theTable As String)
        Dim theCMD As SqlCommand = New SqlCommand(sql, gConn)
        Dim theDA As SqlDataAdapter = New SqlDataAdapter
        theCMD.Connection.Open()
        theDA.SelectCommand = theCMD
        theDS = New DataSet
        theDA.Fill(theDS) ', theTable)
        theCMD.Connection.Close()
        theCMD = Nothing
        theDA = Nothing
    End Function
    Public Sub SetCombo(ByRef cbo As ComboBox, ByRef theID As Integer)
        'Sets passed combo to passed ID in list
        Try
            cbo.SelectedIndex = -1
            cbo.SelectedValue = 0
            If theID = 0 Then Exit Sub
            cbo.SelectedValue = theID
        Catch
        End Try
    End Sub
    Public Sub SetComboTab(ByRef cbo As ComboBox, ByRef theID As Integer)
        'Sets passed combo to passed ID in list
        Try
            cbo.SelectedValue = theID
            cbo.SelectedIndex += 1
        Catch
            cbo.SelectedIndex = -1
        End Try
    End Sub
    Public Function GetCheck(ByRef Chk As CheckBox) As Short
        'Return value of passed checkbox
        GetCheck = -Chk.CheckState
    End Function
    Public Function GetCheck(ByRef radioButton As RadioButton) As Short
        'Return value of passed checkbox
        GetCheck = radioButton.Checked * -1
    End Function
    Public Function FillListView(ByVal gConn As SqlConnection, ByRef sql As String, ByRef FillList As ListView, Optional ByRef bPreserve As Boolean = False, Optional ByRef Capitalize As Boolean = False, Optional ByRef DecPlaces As String = "") As Boolean
        Dim xitm As New ListViewItem
        FillListView = False
        FillList.BeginUpdate()
        WaitOn()
        Try
            FillRecordset(gConn, sql)

            FillList.Items.Clear()

            While rs.Read
                Select Case rs.Item(1).GetType.ToString
                    Case "System.DBNull"
                        xitm = FillList.Items.Add("")
                    Case "System.DateTime"
                        If rs.Item(1) = "1/1/1900" Then
                            xitm = FillList.Items.Add("")
                        Else
                            xitm = FillList.Items.Add(Format(rs(1), "MM/dd/yyyy"))
                        End If
                    Case "System.Double"
                        xitm = FillList.Items.Add(Format(rs(1), "#,###,##0.00"))
                    Case Else
                        If Capitalize Then
                            xitm = FillList.Items.Add(ProperCase(rs(1)))
                        Else
                            xitm = FillList.Items.Add(rs(1))
                        End If
                End Select
                xitm.Tag = rs(0)

                For i = 2 To rs.FieldCount - 1
                    If UCase(rs.GetName(i)) = "ACTIVE" Then
                        If CBool(rs(i)) Then
                            xitm.Checked = True
                            GoTo NextItem
                        End If
                    End If
                    Select Case rs(i).GetType.ToString
                        Case "System.DBNull"
                            xitm.SubItems.Add("")
                        Case "System.Int16"
                            If CBool(rs(i)) Then
                                xitm.SubItems.Add(Format(rs(i), "Yes/No"))
                            Else
                                xitm.SubItems.Add("")
                            End If
                        Case "System.DateTime"
                            If rs(i) = "1/1/1900" Then
                                xitm.SubItems.Add("")
                            Else
                                xitm.SubItems.Add(Format(rs(i), "MM/dd/yyyy"))
                            End If
                        Case "System.Double"
                            xitm.SubItems.Add(Format(rs(i), "#,###,##0.00"))
                        Case Else
                            xitm.SubItems.Add(ProperCase(rs(i)))
                    End Select
NextItem:
                Next
            End While
            rs.Close()
            gConn.Close()
            FillListView = True
            FillList.EndUpdate()
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try

        WaitOff()
        Exit Function
    End Function
    '    Public Function FillListViewVB6(ByVal conn As SqlConnection, ByVal sSQL As String, ByVal FillList As AxMSComctlLib.AxListView, Optional ByVal bPreserve As Boolean = False, Optional ByVal iMaxRows As Integer = 0, Optional ByVal DecPlaces As Integer = 0, Optional ByVal pCase As Boolean = False) As Boolean
    '        'Fills passed listview with passed sql. Additional passed formatting params are used. Returns boolean based on success/failure
    '        'sSQL:      SQL query to execute
    '        'FillList:  ListView Object to fill
    '        'bPreserve: Flag to indicate whether or not to clear the ListView control
    '        'iMaxRows:  Maximum number of row to return

    '        Dim iCount As Integer
    '        Dim iNumColumns As Integer
    '        Dim xValue As Object
    '        Dim DecStr As String

    '        'DecStr = "#,###,###,##0." & String(DecPlaces, "0")

    '        FillListViewVB6 = False

    '        Try
    '            'Execute the sSQL Query
    '            Dim rs As SqlDataReader = FillRecordset(conn, sSQL)

    '            iNumColumns = rs.FieldCount

    '            'Clear the ListView control if the user sets bPreserve as false
    '            If bPreserve = False Then FillList.ListItems.Clear()

    '            While rs.Read
    '                'MsgBox(ISN(rs.Item(0), True) & "_")

    '                'Add a ListItem to the ListItem collection.  Use ListKey as the unique key for the ListIndex
    '                'Field 0 always needs to be the unique key and field 1 the text field
    '                FillList.ListItems.Add(, ISN(rs.Item(0), True) & "_")

    '                'There will always be one more column in the ListView, than there will be items
    '                'in the ListItems collection
    '                For iCount = 1 To iNumColumns - 1

    '                    'Match the ColumnHeader Key field with the database column name
    '                    'RS.fields(iCount - 1).Name: The name of the column is the ResultSet
    '                    'FillList.ColumnHeaders(RS.fields(iCount - 1).Name).SubItemIndex: The value of the index of the column that corresponds to the field name

    '                    If UCase(Left(rs.GetName(iCount), 6)) = "ACTIVE" Then
    '                        If CBool(ISN(rs.Item(iCount), True)) Then
    '                            FillList.ListItems(FillList.ListItems.Count - 1).Checked = True
    '                        Else
    '                            FillList.ListItems(FillList.ListItems.Count - 1).Checked = False
    '                        End If
    '                        GoTo NextItem
    '                    ElseIf UCase(Left(rs.GetName(iCount), 3)) = "YES" Then
    '                        xValue = Format(ISN(rs.Item(iCount), True), "Yes/No")
    '                    ElseIf UCase(Left(rs.GetName(iCount), 8)) = "DATETIME" Then
    '                        xValue = Format(ISN(rs.Item(iCount)), "mm/dd/yyyy hh:nn AM/PM")
    '                    ElseIf UCase(rs.GetName(iCount)) = "APPOINTMENTTIME" Then
    '                        xValue = Format(ISN(rs.Item(iCount)), "hh:MM AMPM")
    '                    ElseIf UCase(Left(rs.GetName(iCount), 3)) = "TAG" Then
    '                        FillList.ListItems(FillList.ListItems.Count - 1).Tag = ISN(rs.Item(iCount), True)
    '                    ElseIf UCase(Left(rs.GetName(iCount), 3)) = "ZIP" Then
    '                        xValue = Format(ISN(rs.Item(iCount), True), "#####-####")


    '                    ElseIf UCase(Left(rs.GetName(iCount), 5)) = "VALUE" _
    '                    Or UCase(Left(rs.GetName(iCount), 6)) = "AMOUNT" Then
    '                        xValue = Format(ISN(rs.Item(iCount)), DecStr)
    '                    ElseIf UCase(rs.GetName(iCount)) = "ACTIVITYDATE" _
    '                    Or UCase(rs.GetName(iCount)) = "ENDDATE" _
    '                    Or UCase(rs.GetName(iCount)) = "DATE" Then
    '                        xValue = Format(ISN(rs.Item(iCount)), "mm/dd/yyyy")
    '                    ElseIf UCase(rs.GetName(iCount)) = "NOTES" _
    '                    Or UCase(rs.GetName(iCount)) = "STATE" _
    '                    Or UCase(rs.GetName(iCount)) = "ORCSECTION" Then
    '                        xValue = ISN(rs.Item(iCount))
    '                    Else
    '                        xValue = ProperCase(ISN(rs.Item(iCount)))
    '                    End If

    '                    'GC mod 3/8/01
    '                    'if entry is a zero-value date, leave blank
    '                    If InStr(UCase(rs.GetName(iCount)), "DATE") <> 0 Then
    '                        If (rs.Item(iCount)) = CDate("1/1/1900") Then
    '                            xValue = ""
    '                        Else
    '                            xValue = Format(ISN(rs.Item(iCount)), "mm/dd/yyyy")
    '                        End If
    '                    End If

    '                    If iCount = 1 Then
    '                        FillList.ListItems(FillList.ListItems.Count).Text = xValue
    '                    ElseIf UCase(Left(rs.Item(iCount).Name, 3)) <> "TAG" Then
    '                        FillList.ListItems(FillList.ListItems.Count).SubItems(iCount - 1) = xValue
    '                    End If
    'NextItem:
    '                Next
    '                'GC 6/5/01; don't want to return true if no records.
    '                FillListViewVB6 = True
    '            End While
    '            rs.Close()
    '            conn.Close()
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '        Exit Function

    ''    End Function
    'Public Function gLoadCombo(ByVal gConn As SqlConnection, ByRef cbo As ComboBox, ByRef sql As String, Optional ByRef Capitalize As Boolean = False, Optional ByRef PreserveItems As Boolean = False, Optional ByRef IncludeBlankItem As Boolean = False) As Boolean
    '    'Loads passed combo box with sql data - additional passed params format cbo. Returns boolean based on success/failure

    '    ' SQL string should return at least two fields:
    '    ' ID - with the ID to be used in ItemData
    '    ' DESCRIPTION - with description of the Item
    '    Dim cboDataSet As DataSet = New DataSet("cboDataSet")
    '    Dim cboTable As DataTable = New DataTable("cboTable")
    '    WaitOn()
    '    Try
    '        cbo.BeginUpdate()

    '        gLoadCombo = False
    '        cbo.DataSource = Nothing

    '        If Not PreserveItems Then
    '            cbo.Items.Clear()
    '        End If

    '        cboTable.Columns.Add("ID", System.Type.GetType("System.Int32"))
    '        cboTable.Columns.Add("Description", System.Type.GetType("System.String"))

    '        cboDataSet.Tables.Add(cboTable)

    '        FillRecordset(gConn, sql)

    '        If IncludeBlankItem Then
    '            cboDataSet.Tables("cboTable").Rows.Add(New Object() {0, ""})
    '        End If

    '        While rs.Read()
    '            If Capitalize Then
    '                cboDataSet.Tables("cbotable").Rows.Add(New Object() {ISN(rs.Item("ID"), True), ProperCase(ISN(rs.Item("Description")))})
    '            Else
    '                cboDataSet.Tables("cbotable").Rows.Add(New Object() {ISN(rs.Item("ID"), True), ISN(rs.Item("Description"))})
    '            End If
    '        End While
    '        cbo.DataSource = cboDataSet.Tables("cboTable")
    '        cbo.DisplayMember = cboDataSet.Tables("cboTable").Columns("Description").ColumnName
    '        cbo.ValueMember = cboDataSet.Tables("cboTable").Columns("ID").ColumnName
    '        rs.Close()
    '        gConn.Close()

    '        cbo.EndUpdate()
    '    Catch ex As SyntaxErrorException
    '        MessageBox.Show(ex.Message)
    '        rs.Close()
    '        gConn.Close()
    '    End Try

    '    cbo.SelectedIndex = -1
    '    cboDataSet = Nothing
    '    cboTable = Nothing
    '    MsgBox(cbo.Items.Count)

    '    WaitOff()
    'End Function
    'Public Function LoadCombo(ByVal gConn As SqlConnection, ByRef cbo As ComboBox, ByRef sql As String, Optional ByRef Capitalize As Boolean = False, Optional ByRef PreserveItems As Boolean = False, Optional ByVal includeBlank As Boolean = False) As Boolean
    '    'Loads passed combo box with sql data - additional passed params format cbo. Returns boolean based on success/failure

    '    ' SQL string should return at least two fields:
    '    ' ID - with the ID to be used in ItemData
    '    ' DESCRIPTION - with description of the Item
    '    Dim theCMD As SqlCommand = New SqlCommand(sql, gConn)
    '    Dim theDA As SqlDataAdapter = New SqlDataAdapter(theCMD)
    '    Dim theDS As New DataSet

    '    cbo.Sorted = True
    '    'cbo.BeginUpdate()
    '    Try
    '        theDA.Fill(theDS)

    '        If Capitalize Then

    '            With theDS.Tables(0)
    '                For i = 0 To .Rows.Count - 1
    '                    .Rows(i).Item(1) = ProperCase(theDS.Tables(0).Rows(i).Item(1))
    '                Next
    '                If includeBlank Then
    '                    Dim r As DataRow = .NewRow
    '                    r.Item(0) = 0
    '                    r.Item(1) = ""
    '                    .Rows.Add(r)
    '                End If
    '            End With
    '        End If
    '        cbo.DataSource = theDS.Tables(0)
    '        cbo.DisplayMember = theDS.Tables(0).Columns(1).ColumnName
    '        cbo.ValueMember = theDS.Tables(0).Columns(0).ColumnName
    '        cbo.SelectedIndex = -1
    '        'temp
    '        MsgBox(cbo.Items.Count)
    '    Catch ex As SystemException
    '        MessageBox.Show(ex.Message)
    '    End Try
    '    'cbo.EndUpdate()

    '    theDS = Nothing
    '    theDA = Nothing
    'End Function
    Public Function LoadCombo(ByVal gConn As SqlConnection, ByRef cbo As ComboBox, ByRef sql As String, Optional ByRef Capitalize As Boolean = False, Optional ByVal excludeBlank As Boolean = False) As Boolean
        'Loads passed combo box with sql data - additional passed params format cbo. Returns boolean based on success/failure

        ' SQL string should return at least two fields:
        ' ID - with the ID to be used as the value member
        ' DESCRIPTION - with description of the Item for display member
        Dim theCMD As SqlCommand = New SqlCommand(sql, gConn)
        Dim theDA As SqlDataAdapter = New SqlDataAdapter(theCMD)
        Dim theDS As New DataSet

        If Not excludeBlank Then cbo.Sorted = True
        cbo.BeginUpdate()
        Try
            theDA.Fill(theDS)
            With theDS.Tables(0)
                If Capitalize Then
                    For i = 0 To .Rows.Count - 1
                        'Try
                        .Rows(i).Item(1) = ProperCase(.Rows(i).Item(1))
                        'Catch ex As Exception
                        'End Try
                    Next
                End If
                If Not excludeBlank Then
                    Dim r As DataRow = .NewRow
                    r.Item(0) = 0
                    r.Item(1) = ""
                    .Rows.Add(r)
                End If
            End With
            cbo.DataSource = theDS.Tables(0)
            cbo.DisplayMember = theDS.Tables(0).Columns(1).ColumnName
            cbo.ValueMember = theDS.Tables(0).Columns(0).ColumnName
            cbo.SelectedIndex = -1
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
        cbo.EndUpdate()

        theDS = Nothing
        theDA = Nothing
    End Function
    'Public Function LoadCombo(ByVal gConn As SqlConnection, ByRef cbo As ComboBox, ByRef sql As String, Optional ByRef Capitalize As Boolean = False, Optional ByVal excludeBlank As Boolean = False) As Boolean
    'THIS ONE WILL WORK ON THE SYSTEM TABLE FORM, BUT NOT THE OTHERS....GO FIGURE.
    '    'Loads passed combo box with sql data - additional passed params format cbo. Returns boolean based on success/failure

    '    ' SQL string should return at least two fields:
    '    ' ID - with the ID to be used in ItemData
    '    ' DESCRIPTION - with description of the Item
    '    Dim theCMD As SqlCommand = New SqlCommand(sql, gConn)
    '    Dim theDA As SqlDataAdapter = New SqlDataAdapter(theCMD)
    '    Dim theDS As New DataSet

    '    cbo.Sorted = True
    '    cbo.BeginUpdate()
    '    Try
    '        theDA.Fill(theDS)
    '        cbo.DataSource = theDS.Tables(0)
    '        cbo.DisplayMember = theDS.Tables(0).Columns(1).ColumnName
    '        cbo.ValueMember = theDS.Tables(0).Columns(0).ColumnName
    '        With theDS.Tables(0)
    '            If Not excludeBlank Then
    '                Dim r As DataRow = .NewRow
    '                r.Item(0) = 0
    '                r.Item(1) = ""
    '                .Rows.Add(r)
    '            End If
    '            .DefaultView.Sort = cbo.DisplayMember.ToString
    '            For i = 0 To .Rows.Count - 1
    '                If Capitalize Then
    '                    .Rows(i).Item(1) = ProperCase(theDS.Tables(0).Rows(i).Item(1))
    '                End If
    '            Next
    '        End With
    '        SetCombo(cbo, 0)
    '    Catch ex As SystemException
    '        MessageBox.Show(ex.Message)
    '    End Try
    '    cbo.EndUpdate()

    '    theDS = Nothing
    '    theDA = Nothing
    'End Function
    Public Function LoadCombo(ByRef cbo As ComboBox, ByVal dataView As DataView, ByVal sa As SqlClient.SqlDataAdapter, Optional ByRef Capitalize As Boolean = False, Optional ByVal excludeBlank As Boolean = False) As Boolean
        'SO FAR, HAVE TO DO THIS FOR THE SYSTEM TABLE FORMS??????
        'Loads passed combo box with data - additional passed params format cbo. Returns boolean based on success/failure

        ' ID - with the ID to be used as the value member
        ' DESCRIPTION - with description of the Item for display member
        Dim table As New DataTable
        Dim dv As New DataView

        table = dataView.Table.Copy
        dv = table.DefaultView
        dv.Sort = dataView.Sort
        With dv
            cbo.DataSource = dv
            cbo.DisplayMember = .Table.Columns(1).ColumnName
            cbo.ValueMember = .Table.Columns(0).ColumnName
            Try
                sa.Fill(.Table)

                If Capitalize Then
                    For i = 0 To .Count - 1
                        .Item(i).Item(1) = ProperCase(.Item(i).Item(1))
                    Next
                End If
                If Not excludeBlank Then
                    Dim r As DataRowView = .AddNew
                    r.BeginEdit()
                    r.Item(0) = 0
                    r.Item(1) = ""
                    r.EndEdit()
                End If
                cbo.SelectedIndex = -1

            Catch ex As SystemException
                MessageBox.Show(ex.Message)
            End Try
        End With
        dv = Nothing
        table = Nothing
    End Function
    Public Sub loadComboColors(ByVal cbo As ComboBox)
        Dim color As System.Drawing.Color
        Try
            For Each color In System.ComponentModel.TypeDescriptor.GetConverter(GetType(Color)).GetStandardValues
                cbo.Items.Add(color.ToKnownColor)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub selectDatagridRow(ByVal dataGrid As DataGrid, ByVal currencyManager As CurrencyManager)
        Try
            If currencyManager.Count = 0 Then Exit Sub
            dataGrid.CurrentRowIndex = currencyManager.Position
            dataGrid.Select(dataGrid.CurrentRowIndex)
        Catch
        End Try
    End Sub
    Public Sub findDatagridRow(ByVal dataGrid As DataGrid, ByVal currencyManager As CurrencyManager, ByVal dataRowView As DataRowView, ByVal findObject As Object())
        Try
            If currencyManager.Count = 0 Then Exit Sub
            dataGrid.UnSelect(dataGrid.CurrentRowIndex)
            dataGrid.CurrentRowIndex = dataRowView.DataView.Find(findObject)
            dataGrid.Select(dataGrid.CurrentRowIndex)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub findDatagridRow(ByVal dataGrid As DataGrid, ByVal dataRowView As DataRowView, ByVal findObject As Object())
        Try
            dataGrid.UnSelect(dataGrid.CurrentRowIndex)
            dataGrid.CurrentRowIndex = dataRowView.DataView.Find(findObject)
            dataGrid.Select(dataGrid.CurrentRowIndex)
        Catch
        End Try
    End Sub
    Public Function LoadCombo(ByRef cbo As ComboBox, ByVal table As DataTable, ByVal sa As SqlClient.SqlDataAdapter, Optional ByRef Capitalize As Boolean = False, Optional ByVal excludeBlank As Boolean = False) As Boolean
        'SO FAR, HAVE TO DO THIS FOR THE SYSTEM TABLE FORMS??????
        'Loads passed combo box with data - additional passed params format cbo. Returns boolean based on success/failure

        ' ID - with the ID to be used as the value member
        ' DESCRIPTION - with description of the Item for display member

        Dim dv As New DataView

        dv = table.DefaultView
        dv.Sort = table.DefaultView.Sort
        With dv
            cbo.DataSource = dv
            cbo.DisplayMember = .Table.Columns(1).ColumnName
            cbo.ValueMember = .Table.Columns(0).ColumnName
            Try
                sa.Fill(.Table)

                If Capitalize Then
                    For i = 0 To .Count - 1
                        .Item(i).Item(1) = ProperCase(.Item(i).Item(1))
                    Next
                End If
                If Not excludeBlank Then
                    Dim r As DataRowView = .AddNew
                    r.BeginEdit()
                    r.Item(0) = 0
                    r.Item(1) = ""
                    r.EndEdit()
                End If
                cbo.SelectedIndex = -1

            Catch ex As SystemException
                MessageBox.Show(ex.Message)
            End Try
        End With
        dv = Nothing
        table = Nothing
    End Function
    Public Function LoadComboItems(ByVal gConn As SqlConnection, ByRef cbo As ComboBox, ByRef sql As String, Optional ByRef Capitalize As Boolean = False, Optional ByVal includeBlank As Boolean = False) As Boolean
        'Loads passed combo box with sql data - additional passed params format cbo. Returns boolean based on success/failure

        ' SQL string should return at least two fields:
        ' ID - with the ID to be used in ItemData
        ' DESCRIPTION - with description of the Item
        Dim cboDataSet As DataSet = New DataSet
        Dim cboTable As DataTable = New DataTable

        Try

            cbo.BeginUpdate()

            LoadComboItems = False
            cbo.DataSource = Nothing

            cboTable.Columns.Add("ID", System.Type.GetType("System.Int32"))
            cboTable.Columns.Add("Description", System.Type.GetType("System.String"))

            cboDataSet.Tables.Add(cboTable)

            FillRecordset(gConn, sql)

            If includeBlank Then
                cboDataSet.Tables(0).Rows.Add(New Object() {0, ""})
            End If
            WaitOn()
            While rs.Read()
                If Capitalize Then
                    cboDataSet.Tables(0).Rows.Add(New Object() {ISN(rs.Item("ID"), True), ProperCase(ISN(rs.Item("Description")))})
                Else
                    cboDataSet.Tables(0).Rows.Add(New Object() {ISN(rs.Item("ID"), True), ISN(rs.Item("Description"))})
                End If
            End While
            cbo.DataSource = cboDataSet.Tables(0)
            cbo.DisplayMember = cboDataSet.Tables(0).Columns("Description").ColumnName
            cbo.ValueMember = cboDataSet.Tables(0).Columns("ID").ColumnName

            cbo.SelectedIndex = -1
            cbo.Text = ""
            LoadComboItems = True
        Catch

        End Try
        rs.Close()
        gConn.Close()

        cboDataSet = Nothing
        cboTable = Nothing

        cbo.EndUpdate()
        WaitOff()
    End Function
    Public Sub loadListbox(ByVal gConn As SqlConnection, ByRef lst As ListBox, ByRef sql As String, Optional ByRef Capitalize As Boolean = False, Optional ByRef PreserveItems As Boolean = False)
        'Loads passed listbox with sql data - additional passed params format lst.

        ' SQL string should return at least two fields:
        ' ID - with the ID to be used in Value Member
        ' DESCRIPTION - with description of the Item
        Dim theCMD As SqlCommand = New SqlCommand(sql, gConn)
        Dim theDA As SqlDataAdapter = New SqlDataAdapter(theCMD)
        Dim theDS As New DataSet
        Try
            theDA.Fill(theDS)

            If Capitalize Then

                With theDS.Tables(0)
                    For i = 0 To .Rows.Count - 1
                        .Rows(i).Item(1) = ProperCase(theDS.Tables(0).Rows(i).Item(1))
                    Next
                End With
            End If
            lst.DisplayMember = theDS.Tables(0).Columns(1).ColumnName
            lst.ValueMember = theDS.Tables(0).Columns(0).ColumnName
            lst.DataSource = theDS.Tables(0)
            lst.SelectedItem = Nothing
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
        theDS = Nothing
        theDA = Nothing
    End Sub
    Public Function ISN(ByVal theValue As Object, Optional ByVal IsNumber As Boolean = False) As Object
        'Examines passed value and returns value based on passed boolean
        If IsDBNull(theValue) _
        Or theValue Is Nothing Then
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
    Public Sub HL()
        'Highlights all text in a field
        Dim theTextBox As TextBox
        theTextBox = Form.ActiveForm.ActiveMdiChild.ActiveControl
        Try
            theTextBox.SelectionStart = 0
            theTextBox.SelectionLength = theTextBox.Text.Length
        Catch

        End Try
    End Sub
    Public Function LoadComboDays(ByRef cbo As ComboBox, Optional ByRef MonthNumber As Short = 1) As Boolean
        'Adds days to passed cbo and returns boolean based on success/failure
        Try
            Dim i As Short
            Dim Days As Short

            LoadComboDays = False

            ' this will get us number of the days in the given month
            Days = Microsoft.VisualBasic.Day(DateSerial(Now.Year, MonthNumber + 1, 0))
            cbo.Items.Clear()
            For i = 1 To Days
                cbo.Items.Add(CStr(i))
                cbo.Items.Item(i - 1) = i
            Next

            LoadComboDays = True
        Catch ex As System.Exception

        End Try
    End Function
    Public Function LoadComboMonths(ByRef cbo As ComboBox, Optional ByRef Abbrev As Boolean = False) As Boolean
        'Adds months to passed cbo and returns boolean based on success/failure
        LoadComboMonths = False
        Try
            cbo.Items.Clear()
            For i = 1 To 12
                cbo.Items.Add(i)
                cbo.Items.Item(i - 1) = MonthName(i, Abbrev)
            Next

            LoadComboMonths = True

        Catch

        End Try
    End Function
    Public Function LoadComboYears(ByRef cbo As ComboBox, Optional ByRef Start As Short = 0, Optional ByRef Years As Short = 0, Optional ByVal Descending As Boolean = False) As Boolean
        'Adds years to passed cbo and returns boolean based on success/failure
        Dim i As Short

        LoadComboYears = False
        Try
            cbo.Items.Clear()
            If Start = 0 Then
                Start = 1995
            End If
            If Years = 0 Then
                Years = 15
            End If
            If Descending Then
                For i = Start + Years To Start Step -1
                    cbo.Items.Add(CStr(i))
                Next
            Else
                For i = Start To Start + Years
                    cbo.Items.Add(CStr(i))
                Next
            End If
            LoadComboYears = True
        Catch

        End Try
    End Function
    Public Function RoundX(ByRef Num As Object) As Object
        'Rounds passed variant to specific  length and returns it as variant
        If Num < 1 Then
            RoundX = Math.Round(Num, 3)
        ElseIf Num < 10 Then
            RoundX = Math.Round(Num, 2)
        ElseIf Num < 100 Then
            RoundX = Math.Round(Num, 1)
        Else
            RoundX = Num
        End If
    End Function
    Public Sub SearchComboBox(ByRef combo As ComboBox, ByRef KeyCode As Short)
        'Looks in passed cbo for passed keycode and selects it

        Dim sTempString As String
        Dim Index As Integer

        If KeyCode >= Keys.D0 And KeyCode <= Keys.Divide Then
            'only look at appropriate keys
            sTempString = combo.Text
            Index = combo.FindString(sTempString)
            combo.SelectedIndex = Index
            combo.SelectionStart = Len(sTempString)
            combo.SelectionLength = Len(combo.Text) - (Len(sTempString))
        End If
    End Sub
    Public Sub SearchComboBox(ByRef combo As ComboBox, ByRef KeyCode As Short, ByVal includeBackspace As Boolean)
        'GC 11/20/03: Hopefully this is temporary.
        'I needed the overload to handle the goofy behavior of combo boxes
        'ie combos on group boxes that alternate between visible/invisible

        'Looks in passed cbo for passed keycode and selects it

        Dim sTempString As String
        Dim Index As Integer

        If KeyCode >= Keys.D0 And KeyCode <= Keys.Divide Or KeyCode = Keys.Back Then
            'only look at appropriate keys
            sTempString = combo.Text
            Index = combo.FindString(sTempString)
            combo.SelectedIndex = Index
            combo.SelectionStart = Len(sTempString)
            combo.SelectionLength = Len(combo.Text) - (Len(sTempString))
        End If
    End Sub
    Public Sub SearchListBox(ByRef lst As ListBox, ByRef str As String)
        'Looks in passed lst for passed string and selects it
        If lst Is Nothing Then Exit Sub
        If lst.Enabled = False Then Exit Sub
        With lst
            .ClearSelected()
            .SelectedIndex = -1
            Dim Index As Integer
            Index = .FindString(str)
            .SelectedIndex = Index
        End With
    End Sub
    Public Sub activateLocator(ByVal listBox As ListBox, ByVal textBox As TextBox, ByVal keyCode As System.Windows.Forms.KeyEventArgs)
        If keyCode.KeyCode = keyCode.KeyCode.Tab _
        Or listBox.Enabled = False Then Exit Sub
        If keyCode.KeyCode >= Keys.D0 And keyCode.KeyCode <= Keys.Divide Then
            With textBox
                .Focus()
                .Text = Chr(keyCode.KeyCode)
                .SelectionStart = 2
            End With
        End If
    End Sub
    Public Sub activateLocator(ByVal dataGrid As DataGrid, ByVal textBox As TextBox, ByVal keyCode As System.Windows.Forms.KeyEventArgs)
        If keyCode.KeyCode = keyCode.KeyCode.Tab _
        Or dataGrid.Enabled = False Then Exit Sub
        If keyCode.KeyCode >= Keys.D0 And keyCode.KeyCode <= Keys.Divide Then
            With textBox
                .Focus()
                .Text = Chr(keyCode.KeyCode)
                .SelectionStart = 2
            End With
        End If
    End Sub
    'Public Function GetCombo(ByRef cbo As System.Windows.Forms.ComboBox) As Integer
    '    'Returns a long for selected item in passed cbo
    '    GetCombo = 0
    '    If cbo.SelectedIndex <> -1 Then
    '        GetCombo = cbo.SelectedValue
    '    End If
    'End Function
    Public Function GetCombo(ByRef cbo As System.Windows.Forms.ComboBox) As Integer
        'Returns a long for selected item in passed cbo
        GetCombo = 0
        If cbo.Items.Count = 0 Then Exit Function
        Try
            Dim itm As DataRowView
            itm = cbo.SelectedItem
            GetCombo = itm(0)
        Catch
        End Try
    End Function
    Public Function GetComboChar(ByRef cbo As System.Windows.Forms.ComboBox) As String
        'Returns the 1st char for selected item in passed cbo
        GetComboChar = ""
        If cbo.SelectedIndex <> -1 Then
            GetComboChar = Left(cbo.SelectedItem, 1)
        End If
    End Function
    'Public Function GetComboTab(ByRef cbo As System.Windows.Forms.ComboBox) As Integer
    '    'Returns a long for selected item in passed cbo
    '    Try
    '        cbo.SelectedIndex -= 1
    '    Catch
    '        cbo.SelectedIndex = -1
    '    End Try
    '    GetComboTab = 0
    '    If cbo.SelectedIndex <> -1 Then
    '        Try
    '            GetComboTab = cbo.SelectedValue
    '        Catch
    '        End Try
    '    End If
    'End Function
    Public Function getDate(ByRef dtp As System.Windows.Forms.DateTimePicker, Optional ByVal Checkbox As Boolean = True, Optional ByVal useNull As Boolean = False) As Date
        'Returns a formatted date for passed datepicker date
        If Not Checkbox Then
            getDate = Format(dtp.Value, dtp.CustomFormat)
            Exit Function
        End If
        If Not useNull Then getDate = "1/1/1900"

        If dtp.Checked = True Then getDate = Format(dtp.Value, dtp.CustomFormat)
    End Function
    Public Sub setDate(ByVal dtp As DateTimePicker, ByVal dt As Date)
        Try
            dtp.Checked = False
            If Not IsDBNull(dt) _
            And dt <> "1/1/1900" Then
                dtp.Value = dt
                dtp.Checked = True
            End If
        Catch
        End Try
    End Sub
    Public Sub setDate(ByVal dtp As DateTimePicker, ByVal dt As Object)
        Try
            dtp.Checked = False
            If Not IsDBNull(dt) _
            And dt <> "1/1/1900" Then
                dtp.Value = dt
                dtp.Checked = True
            End If
        Catch
        End Try
    End Sub
    Public Sub SetCheck(ByRef Chk As CheckBox, Optional ByRef theVal As Object = Nothing)
        'With passed checkbox, set it's value to 0 or 1
        If CShort(theVal) <> 0 Then
            Chk.CheckState = CheckState.Checked
        Else
            Chk.CheckState = CheckState.Unchecked
        End If
    End Sub
    Public Sub SetComboFromText(ByRef cbo As ComboBox, ByRef theStr As String, Optional ByVal anyWhere As Boolean = False)
        'Sets passed cbo to Index based on passed string
        If Not anyWhere Then
            cbo.SelectedIndex = cbo.FindStringExact(theStr)
        Else
            cbo.SelectedIndex = cbo.FindString(theStr)
        End If
    End Sub
    Public Sub SetComboFromChar(ByRef cbo As ComboBox, ByRef theStr As String)
        'Sets passed cbo to Index based on passed string
        If theStr = "" Then Exit Sub
        cbo.SelectedIndex = cbo.FindString(theStr)
    End Sub
    Public Function YN(ByRef Chk As CheckBox) As String
        'Returns Yes/ based on value of passed checkbox
        YN = ""
        If Chk.CheckState = CheckState.Checked Then YN = "Yes"
    End Function
    Public Sub WaitOn()
        Cursor.Current = Cursors.WaitCursor
    End Sub
    Public Sub WaitOff()
        Cursor.Current = Cursors.Default
    End Sub
    Public Function HasRight(ByVal userRight As Object, ByVal col As Collection, ByVal RightID As Long) As Boolean
        'Returns boolean based on whether passed long has rights

        HasRight = True

        Try
            userRight = col.Item(RightID & "_")
        Catch
            HasRight = False
        End Try
    End Function
    Public Sub loadListboxYears(ByVal lst As ListBox, ByVal start As Short, ByVal years As Short)
        lst.Items.Clear()
        For i = start To start - years Step -1
            lst.Items.Add(CStr(i))
        Next
        lst.SelectedIndex = 0
    End Sub
    Public Function getScreenWidth() As Integer
        getScreenWidth = Screen.PrimaryScreen.Bounds.Width
    End Function
    Public Function getScreenHeight() As Integer
        getScreenHeight = Screen.PrimaryScreen.Bounds.Height
    End Function
    Public Sub anchorFormControls(ByVal frm As Form)
        Dim ctl As Control
        Dim ctls As Control
        For Each ctl In frm.Controls
            If Not TypeOf ctl Is Label Then
                ctl.Anchor = AnchorStyles.Top + AnchorStyles.Left + AnchorStyles.Bottom + AnchorStyles.Right
                For Each ctls In ctl.Controls
                    If Not TypeOf ctls Is Label Then
                        ctls.Anchor = AnchorStyles.Top + AnchorStyles.Left + AnchorStyles.Bottom + AnchorStyles.Right
                    End If
                Next
            End If
        Next
    End Sub
    Public Sub anchorFormControls(ByVal frm As Form, ByVal Top As Boolean, ByVal Bottom As Boolean, ByVal Left As Boolean, ByVal Right As Boolean)
        Dim ctl As Control
        Dim ctls As Control
        Dim a As Int32
        For Each ctl In frm.Controls
            'MsgBox(ctl.Name)
            If Not TypeOf ctl Is Label Then
                With ctl
                    a = 0
                    If Top Then a += AnchorStyles.Top
                    If Left Then a += AnchorStyles.Left
                    If Bottom Then a += AnchorStyles.Bottom
                    If Right Then a += AnchorStyles.Right
                    .Anchor = a
                End With
                For Each ctls In ctl.Controls
                    If Not TypeOf ctls Is Label Then
                        With ctls
                            a = 0
                            If Top Then a += AnchorStyles.Top
                            If Left Then a += AnchorStyles.Left
                            If Bottom Then a += AnchorStyles.Bottom
                            If Right Then a += AnchorStyles.Right
                            .Anchor = a
                        End With
                    End If
                Next
            End If
        Next
    End Sub
    Public Sub anchorFormControls(ByVal groupBox As GroupBox)
        Dim ctl As Control
        For Each ctl In groupBox.Controls
            If Not TypeOf ctl Is Label Then
                groupBox.Anchor = AnchorStyles.Top + AnchorStyles.Left + AnchorStyles.Bottom + AnchorStyles.Right
                If Not TypeOf ctl Is Label Then
                    ctl.Anchor = AnchorStyles.Top + AnchorStyles.Left + AnchorStyles.Bottom + AnchorStyles.Right
                End If
            End If
        Next
    End Sub
    Public Function clearBindings(ByVal what As Control, ByVal Bindings As Collection, Optional ByVal clearData As Boolean = True) As Collection
        Dim ctl As Control
        Dim ctls As Control
        Dim aBinding As New clsBindings

        'Saves and clears the current bindings
        'The bindings are stored in the collection "Bindings" and can be restored later
        'with restoreBindings sub.
        '"what" could be an entire form, a groupbox, an individual ctl, etc.
        clearBindings = Nothing
        clearBindings = New Collection

        Try
            If what.Controls.Count = 0 Then
                aBinding = New clsBindings
                aBinding.ctl = what
                aBinding.PropertyName = what.DataBindings.Item(0).PropertyName
                aBinding.Source = what.DataBindings.Item(0).DataSource
                aBinding.Member = what.DataBindings.Item(0).BindingMemberInfo.BindingMember
                clearBindings.Add(aBinding, aBinding.ctl.Name)
                what.DataBindings.Clear()
                If clearData And what.Enabled Then what.ResetText()
            Else
                For Each ctl In what.Controls
                    With ctl
                        If .DataBindings.Count Then
                            aBinding = New clsBindings
                            aBinding.ctl = ctl
                            aBinding.PropertyName = .DataBindings.Item(0).PropertyName
                            aBinding.Source = .DataBindings.Item(0).DataSource
                            aBinding.Member = .DataBindings.Item(0).BindingMemberInfo.BindingMember
                            clearBindings.Add(aBinding, .Name)
                            .DataBindings.Clear()
                            If clearData Then
                                If Not TypeOf ctl Is CheckBox And ctl.Enabled Then .ResetText()
                                If TypeOf ctl Is ComboBox And ctl.Enabled Then
                                    Dim cbo As ComboBox = ctl
                                    SetCombo(cbo, 0)
                                ElseIf TypeOf ctl Is DateTimePicker Then
                                    'For some reason, this won't uncheck the datepicker??
                                    Dim dtp As DateTimePicker = ctl
                                    If dtp.ShowCheckBox = True Then
                                        dtp.Checked = False
                                    End If
                                ElseIf TypeOf ctl Is CheckBox Then
                                    'Default to Checked?
                                    Dim cb As CheckBox = ctl
                                    cb.Checked = True
                                End If
                                .Focus()
                            ElseIf TypeOf ctl Is ComboBox And ctl.Enabled And clearData Then
                                Dim cbo As ComboBox = ctl
                                SetCombo(cbo, 0)
                            End If
                        End If
                    End With
                    For Each ctls In ctl.Controls
                        With ctls
                            If .DataBindings.Count <> 0 And Not TypeOf ctl Is GroupBox Then
                                aBinding = New clsBindings
                                aBinding.ctl = ctls
                                aBinding.PropertyName = .DataBindings.Item(0).PropertyName
                                aBinding.Source = .DataBindings.Item(0).DataSource
                                aBinding.Member = .DataBindings.Item(0).BindingMemberInfo.BindingMember
                                clearBindings.Add(aBinding, .Name)
                                .DataBindings.Clear()
                                If clearData Then
                                    If Not TypeOf ctls Is CheckBox And ctls.Enabled Then .ResetText()
                                    If TypeOf ctls Is ComboBox And ctls.Enabled Then
                                        Dim cbo As ComboBox = ctls
                                        SetCombo(cbo, 0)
                                        cbo.SelectedIndex = -1
                                    ElseIf TypeOf ctls Is CheckBox Then
                                        'Default to Checked?
                                        Dim cb As CheckBox = ctls
                                        cb.Checked = True
                                        '    'For some reason, this won't uncheck the datepicker??
                                        'ElseIf TypeOf ctls Is DateTimePicker Then
                                        '    Dim dtp As DateTimePicker = ctls
                                        '    If dtp.ShowCheckBox = True Then
                                        '        dtp.Checked = False
                                        '        'MsgBox(ctls.Name)
                                        'End If
                                    End If
                                ElseIf TypeOf ctls Is ComboBox And ctls.Enabled And clearData Then
                                    Dim cbo As ComboBox = ctls
                                    SetCombo(cbo, 0)
                                End If
                            End If
                        End With
                    Next
                Next
            End If
        Catch
        End Try
    End Function
    Public Function clearBindings(ByVal control As Control, ByVal Bindings As Collection, ByVal drv As DataRowView, Optional ByVal clearData As Boolean = True) As Collection
        Dim aBinding As New clsBindings
        Dim col As DataColumn
        Dim ctls As Control

        colBindings = Nothing
        colBindings = New Collection

        Dim bindingBase As BindingManagerBase = control.BindingContext(drv.DataView)

        Try
            For i = 0 To bindingBase.Bindings.Count - 1
                ctls = bindingBase.Bindings.Item(i).Control
                'Bindings were cleared for insert, but are saved in clsBindings
                Try
                    With ctls
                        If .DataBindings.Count Then
                            aBinding = New clsBindings
                            aBinding.ctl = ctls
                            aBinding.PropertyName = .DataBindings.Item(0).PropertyName
                            aBinding.Source = .DataBindings.Item(0).DataSource
                            aBinding.Member = .DataBindings.Item(0).BindingMemberInfo.BindingMember
                            colBindings.Add(aBinding, .Name)
                            .DataBindings.Clear()
                            If clearData Then
                                If Not TypeOf ctls Is CheckBox And ctls.Enabled Then .ResetText()
                                If TypeOf ctls Is ComboBox And ctls.Enabled Then
                                    Dim cbo As ComboBox = ctls
                                    SetCombo(cbo, 0)
                                ElseIf TypeOf ctls Is DateTimePicker Then
                                    'For some reason, this won't uncheck the datepicker??
                                    Dim dtp As DateTimePicker = ctls
                                    If dtp.ShowCheckBox = True Then
                                        dtp.Checked = False
                                    End If
                                ElseIf TypeOf ctls Is CheckBox Then
                                    'Default to Checked?
                                    Dim cb As CheckBox = ctls
                                    cb.Checked = True
                                End If
                                .Focus()
                            ElseIf TypeOf ctls Is ComboBox And ctls.Enabled And clearData Then
                                Dim cbo As ComboBox = ctls
                                SetCombo(cbo, 0)
                            End If
                        End If
                    End With
                Catch ex As Exception
                    'GoTo nextitem
                End Try
                i -= 1
            Next
        Catch ex As Exception
        End Try
    End Function
    Public Sub restoreBindings(ByVal Bindings As Collection)
        Dim aBinding As clsBindings

        For Each aBinding In Bindings
            Try
                aBinding.ctl.DataBindings.Add(aBinding.PropertyName, aBinding.Source, aBinding.Member)
            Catch ex As Exception
            End Try
        Next

        Bindings = Nothing
    End Sub
    Public Function formatZip4(ByVal str As String) As String
        For i = str.Length To 8
            str += "0"
        Next
        formatZip4 = str
    End Function
    Public Sub resetControlColors(ByVal control As Control)
        Try
            'Reset cbo colors
            control.BackColor = System.Drawing.SystemColors.Window
            control.ForeColor = System.Drawing.SystemColors.WindowText
        Catch ex As Exception
        End Try
    End Sub
    Public Sub setControlColors(ByVal control As Control, ByVal Backcolor As String, ByVal forecolor As String)
        Try
            'Reset cbo colors
            control.BackColor = System.Drawing.SystemColors.Window
            control.ForeColor = System.Drawing.SystemColors.WindowText

            'Set preferred colors
            Dim color As System.Drawing.Color
            control.BackColor = color.FromName(Backcolor)
            control.ForeColor = color.FromName(forecolor)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub launchFile(ByVal fileName As String)
        Try
            System.Diagnostics.Process.Start(fileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub resetControls(ByVal Control As Control)
        Dim ctl As Control
        Dim ctls As Control
        For Each ctl In Control.Controls
            If Not TypeOf ctl Is Label And Not TypeOf ctl Is GroupBox And Not TypeOf ctl Is Button And ctl.Tag = "" Then
                If TypeOf ctl Is CheckBox Then
                    Dim cb As CheckBox = ctl
                    cb.Checked = False
                ElseIf TypeOf ctl Is ListView Then
                    Dim lv As ListView = ctl
                    lv.Items.Clear()
                    'ElseIf TypeOf ctl Is DateTimePicker Then
                    '    Dim dtp As DateTimePicker = ctl
                    '    dtp.ResetText()
                    '    dtp.Checked = False
                Else
                    ctl.ResetText()
                End If
            End If
            'For Each ctls In ctl.Controls
            '    If Not TypeOf ctls Is Label And Not TypeOf ctls Is GroupBox And Not TypeOf ctls Is Button And ctls.Tag = "" Then
            '        If TypeOf ctls Is CheckBox Then
            '            Dim cb As CheckBox = ctls
            '            cb.Checked = False
            '        ElseIf TypeOf ctls Is ListView Then
            '            Dim lv As ListView = ctls
            '            lv.Items.Clear()
            '        Else
            '            ctls.ResetText()
            '        End If
            '    End If
            'Next
        Next
    End Sub
    '    Public Function saveDataRow(ByVal ctl As Control, ByVal drv As DataRowView, ByVal tbl As DataTable, ByVal sa As SqlClient.SqlDataAdapter, ByVal isNew As Boolean, ByVal Bindings As Collection, Optional ByVal dg As DataGrid = Nothing, Optional ByVal cm As CurrencyManager = Nothing, Optional ByVal extraColumns As Collection = Nothing) As Boolean
    '        Dim ctls As Control
    '        Dim col As DataColumn

    '        saveDataRow = False

    '        Try
    '            If isNew Then drv = drv.DataView.AddNew
    '            drv.BeginEdit()
    '            For Each ctls In ctl.Controls
    '                If isNew Then
    '                    'Bindings were cleared for insert, but are saved in clsBindings
    '                    Try
    '                        Dim c As Util.Utility.clsBindings
    '                        c = Bindings.Item(ctls.Name)
    '                        col = tbl.Columns(c.Member)
    '                    Catch ex As Exception
    '                        GoTo nextitem
    '                    End Try

    '                ElseIf ctls.DataBindings.Count = 0 Then
    '                    'Only need to look at bound controls
    '                    GoTo NextItem
    '                Else
    '                    Try
    '                        col = tbl.Columns(ctls.DataBindings.Item(0).BindingMemberInfo.BindingMember)
    '                    Catch ex As Exception
    '                        GoTo NextItem
    '                    End Try

    '                End If
    '                If TypeOf ctls Is TextBox Then
    '                    If col.DataType.ToString = "System.String" Then
    '                        drv(col.ColumnName) = ctls.Text
    '                    Else
    '                        drv(col.ColumnName) = Val(ctls.Text)
    '                    End If
    '                ElseIf TypeOf ctls Is ComboBox Then
    '                    Dim c As ComboBox = ctls
    '                    Try
    '                        If Not c.SelectedValue Is Nothing Then
    '                            drv(col.ColumnName) = ISN(c.SelectedValue, True)
    '                        Else
    '                            drv(col.ColumnName) = ISN(c.Text)
    '                        End If
    '                    Catch ex As Exception
    '                    End Try
    '                ElseIf TypeOf ctls Is DateTimePicker Then
    '                    Dim dtp As DateTimePicker = ctls
    '                    drv(col.ColumnName) = ISN(Format(dtp.Value, dtp.CustomFormat), True)
    '                ElseIf TypeOf ctls Is CheckBox Then
    '                    Dim c As CheckBox = ctls
    '                    If col.DataType.ToString = "system.Int16" Then
    '                        'Small integer in sqlServer (0,-1) older apps (ie VB6)
    '                        drv(col.ColumnName) = u.GetCheck(c)
    '                    Else
    '                        'Bit in sqlServer (0,1)
    '                        drv(col.ColumnName) = c.CheckState
    '                    End If
    '                End If
    '                Try
    '                    If col.AutoIncrement = True _
    '                    And isNew Then
    '                        drv.EndEdit()
    '                        sa.Update(tbl)
    '                        cm.Refresh()
    '                        drv.BeginEdit()
    '                    End If
    '                Catch ex As Exception
    '                    'MsgBox(ex.Message)
    '                End Try

    'NextItem:
    '            Next

    '            Dim cColumns As clsExtraColumns
    '            If Not extraColumns Is Nothing Then
    '                For Each cColumns In extraColumns
    '                    drv(cColumns.columnName) = cColumns.columnValue
    '                Next
    '            End If
    '            cColumns = Nothing

    '            'Don't even ask.
    '            If Not dg Is Nothing Then dg.Select()

    '            drv.EndEdit()
    '            Try
    '                sa.Update(tbl)
    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message)
    '                Exit Function
    '            End Try

    '            'Restore bindings from collection
    '            If isNew Then u.restoreBindings(Bindings)

    '            saveDataRow = True
    '        Catch ex As Exception
    '            MessageBox.Show("An error occured while trying to update the database." & vbLf & vbLf & ex.Message)
    '        End Try
    '        'colSort = Nothing
    '    End Function
    Public Function saveDataRow(ByVal ctl As Control, ByVal drv As DataRowView, ByVal tbl As DataTable, ByVal sa As SqlClient.SqlDataAdapter, ByVal isNew As Boolean, ByVal Bindings As Collection, Optional ByVal dg As DataGrid = Nothing, Optional ByVal cm As CurrencyManager = Nothing, Optional ByVal extraColumns As Collection = Nothing, Optional ByVal autosizeDataGrid As Boolean = True) As Boolean
        Dim ctls As Control
        Dim col As DataColumn
        Dim sortSplit As String()
        Dim colSort As New Collection
        Dim sortCount As Integer = 0
        Dim str As String
        Dim findObj() As Object

        saveDataRow = False
        'if we have a dataview sort string then parse it.
        If drv.DataView.Sort <> "" Then
            sortSplit = drv.DataView.Sort.Split(",")
            For Each str In sortSplit
                If UCase(Right(str, 4)) = "DESC" Then str = Left(str, Len(str) - 5)
                If UCase(Right(str, 3)) = "ASC" Then str = Left(str, Len(str) - 4)
                colSort.Add(sortCount, Trim(str))
                sortCount += 1
            Next
            ReDim findObj(sortCount - 1)
            sortCount = 0
        End If

        'now, on to it.
        Try
            If isNew Then drv = drv.DataView.AddNew
            drv.BeginEdit()

            'Unbound stuff----------------------------------------------------------------------------------------
            Dim cColumns As clsExtraColumns
            If Not extraColumns Is Nothing Then
                For Each cColumns In extraColumns
                    drv(cColumns.columnName) = cColumns.columnValue
                    Try
                        sortCount = colSort(cColumns.columnName)
                        If InStr(cColumns.columnValue, "(") <> 0 Then
                            findObj(sortCount) = Mid(cColumns.columnValue, 1, InStr(cColumns.columnValue, "(") - 2)
                        Else
                            findObj(sortCount) = cColumns.columnValue
                        End If
                    Catch ex As Exception
                    End Try
                Next
            End If
            cColumns = Nothing
            'Unbound stuff----------------------------------------------------------------------------------------

            'Bound stuff----------------------------------------------------------------------------------------
            For Each ctls In ctl.Controls
                If isNew Then
                    'Bindings were cleared for insert, but are saved in clsBindings
                    Try
                        Dim c As clsBindings
                        c = Bindings.Item(ctls.Name)
                        col = tbl.Columns(c.Member)
                    Catch ex As Exception
                        GoTo nextitem
                    End Try

                ElseIf ctls.DataBindings.Count = 0 Then
                    'Only need to look at bound controls
                    GoTo NextItem
                Else
                    Try
                        col = tbl.Columns(ctls.DataBindings.Item(0).BindingMemberInfo.BindingMember)
                    Catch ex As Exception
                        GoTo NextItem
                    End Try

                End If
                If TypeOf ctls Is TextBox Then
                    If col.DataType.ToString = "System.String" Then
                        drv(col.ColumnName) = ctls.Text
                    Else
                        drv(col.ColumnName) = Val(ctls.Text)
                    End If
                ElseIf TypeOf ctls Is ComboBox Then
                    Dim c As ComboBox = ctls
                    Try
                        If Not c.SelectedValue Is Nothing Then
                            drv(col.ColumnName) = ISN(c.SelectedValue, True)
                        ElseIf c.Text = "" Then
                            drv(col.ColumnName) = 0
                        Else
                            drv(col.ColumnName) = ISN(c.Text)
                        End If
                    Catch ex As Exception
                    End Try

                    Try
                        sortCount = colSort(c.DisplayMember)
                        If InStr(c.Text, "(") <> 0 Then
                            findObj(sortCount) = Mid(c.Text, 1, InStr(c.Text, "(") - 2)
                        Else
                            findObj(sortCount) = c.Text
                        End If
                    Catch ex As Exception
                    End Try
                ElseIf TypeOf ctls Is DateTimePicker Then
                    Dim dtp As DateTimePicker = ctls
                    drv(col.ColumnName) = ISN(Format(dtp.Value, dtp.CustomFormat), True)
                    Try
                        sortCount = colSort(col.ColumnName)
                        findObj(sortCount) = drv(col.ColumnName)
                    Catch ex As Exception
                    End Try
                ElseIf TypeOf ctls Is CheckBox Then
                    Dim c As CheckBox = ctls
                    If col.DataType.ToString = "system.Int16" Then
                        'Small integer in sqlServer (0,-1) older apps (ie VB6)
                        drv(col.ColumnName) = GetCheck(c)
                    Else
                        'Bit in sqlServer (0,1)
                        drv(col.ColumnName) = c.CheckState
                    End If
                    Try
                        sortCount = colSort(col.ColumnName)
                        findObj(sortCount) = drv(col.ColumnName)
                    Catch ex As Exception
                    End Try
                End If
                Try
                    If col.AutoIncrement = True _
                    And isNew Then
                        drv.EndEdit()
                        sa.Update(tbl)
                        cm.Refresh()
                        drv.BeginEdit()
                    End If
                    sortCount = colSort(col.ColumnName)
                    findObj(sortCount) = drv(col.ColumnName)
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try

NextItem:
            Next
            ''Unbound stuff----------------------------------------------------------------------------------------
            'Dim cColumns As clsExtraColumns
            'If Not extraColumns Is Nothing Then
            '    For Each cColumns In extraColumns
            '        drv(cColumns.columnName) = cColumns.columnValue
            '        Try
            '            sortCount = colSort(cColumns.columnName)
            '            If InStr(cColumns.columnValue, "(") <> 0 Then
            '                findObj(sortCount) = Mid(cColumns.columnValue, 1, InStr(cColumns.columnValue, "(") - 2)
            '            Else
            '                findObj(sortCount) = cColumns.columnValue
            '            End If
            '        Catch ex As Exception
            '        End Try
            '    Next
            'End If
            'cColumns = Nothing

            'Don't even ask.
            If Not dg Is Nothing Then dg.Select()

            drv.EndEdit()
            Try
                sa.Update(tbl)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Function
            End Try

            'Restore bindings from collection
            If isNew Then restoreBindings(Bindings)
            'Scroll to the item
            If Not dg Is Nothing And Not cm Is Nothing Then findDatagridRow(dg, cm, drv, findObj)
            If Not dg Is Nothing And autosizeDataGrid Then AutoSizeCol(dg)
            saveDataRow = True
        Catch ex As Exception
            MessageBox.Show("An error occured while trying to update the database." & vbLf & vbLf & ex.Message)
        End Try
        colSort = Nothing
    End Function
    Public Function saveDataRow(ByVal form As Form, ByVal drv As DataRowView, ByVal tbl As DataTable, ByVal sa As SqlClient.SqlDataAdapter, ByVal isNew As Boolean, Optional ByVal dg As DataGrid = Nothing, Optional ByVal extraColumns As Collection = Nothing) As Boolean
        'This was desinged for use with a separate update form
        Dim ctls As Control
        Dim bmBinding As Binding
        Dim col As DataColumn

        Dim bindingBase As BindingManagerBase = form.BindingContext(drv.DataView)

        saveDataRow = False

        Try
            Try
                If isNew Then drv = drv.DataView.AddNew
            Catch ex As Exception
            End Try
            drv.BeginEdit()
            If isNew Then
                'Bindings were cleared for insert, but are saved in clsBindings
                Try
                    Dim cb As clsBindings
                    For Each cb In colBindings
                        col = tbl.Columns(cb.Member)
                        ctls = cb.ctl
                        If TypeOf ctls Is TextBox Then
                            If col.DataType.ToString = "System.String" Then
                                drv(col.ColumnName) = ctls.Text
                            Else
                                drv(col.ColumnName) = Val(ctls.Text)
                            End If
                        ElseIf TypeOf ctls Is ComboBox Then
                            Dim c As ComboBox = ctls
                            Try
                                If Not c.SelectedValue Is Nothing Then
                                    drv(col.ColumnName) = ISN(c.SelectedValue, True)
                                ElseIf c.Text = "" Then
                                    drv(col.ColumnName) = 0
                                Else
                                    drv(col.ColumnName) = ISN(c.Text)
                                End If
                            Catch ex As Exception
                            End Try
                        ElseIf TypeOf ctls Is DateTimePicker Then
                            Dim dtp As DateTimePicker = ctls
                            drv(col.ColumnName) = ISN(Format(dtp.Value, dtp.CustomFormat), True)
                        ElseIf TypeOf ctls Is CheckBox Then
                            Dim c As CheckBox = ctls
                            If col.DataType.ToString = "system.Int16" Then
                                'Small integer in sqlServer (0,-1) older apps (ie VB6)
                                drv(col.ColumnName) = GetCheck(c)
                            Else
                                'Bit in sqlServer (0,1)
                                drv(col.ColumnName) = c.CheckState
                            End If
                        End If
                        Try
                            If col.AutoIncrement = True _
                            And isNew Then
                                drv.EndEdit()
                                sa.Update(tbl)
                                drv.BeginEdit()
                            End If
                        Catch ex As Exception
                            'MsgBox(ex.Message)
                        End Try
                    Next
                Catch ex As Exception
                    'GoTo nextitem
                End Try
            Else
                For Each bmBinding In bindingBase.Bindings
                    ctls = bmBinding.Control
                    If ctls.DataBindings.Count = 0 Then
                        'Only need to look at bound controls
                        GoTo NextItem
                    End If

                    Try
                        col = tbl.Columns(bmBinding.BindingMemberInfo.BindingField)
                    Catch ex As Exception
                        GoTo NextItem
                    End Try
                    If col Is Nothing Then GoTo NextItem

                    If TypeOf ctls Is TextBox Then
                        If col.DataType.ToString = "System.String" Then
                            drv(col.ColumnName) = ctls.Text
                        Else
                            drv(col.ColumnName) = Val(ctls.Text)
                        End If
                    ElseIf TypeOf ctls Is ComboBox Then
                        Dim c As ComboBox = ctls
                        Try
                            If Not c.SelectedValue Is Nothing Then
                                drv(col.ColumnName) = ISN(c.SelectedValue, True)
                            ElseIf c.Text = "" Then
                                drv(col.ColumnName) = 0
                            Else
                                drv(col.ColumnName) = ISN(c.Text)
                            End If
                        Catch ex As Exception
                        End Try
                    ElseIf TypeOf ctls Is DateTimePicker Then
                        Dim dtp As DateTimePicker = ctls
                        drv(col.ColumnName) = ISN(Format(dtp.Value, dtp.CustomFormat), True)
                    ElseIf TypeOf ctls Is CheckBox Then
                        Dim c As CheckBox = ctls
                        If col.DataType.ToString = "system.Int16" Then
                            'Small integer in sqlServer (0,-1) older apps (ie VB6)
                            drv(col.ColumnName) = GetCheck(c)
                        Else
                            'Bit in sqlServer (0,1)
                            drv(col.ColumnName) = c.CheckState
                        End If
                    End If
                    Try
                        If col.AutoIncrement = True _
                        And isNew Then
                            drv.EndEdit()
                            sa.Update(tbl)
                            drv.BeginEdit()
                        End If
                    Catch ex As Exception
                        'MsgBox(ex.Message)
                    End Try

NextItem:
                Next
            End If

            Dim cColumns As clsExtraColumns
            If Not extraColumns Is Nothing Then
                For Each cColumns In extraColumns
                    Try
                        drv(cColumns.columnName) = cColumns.columnValue
                    Catch ex As Exception
                    End Try

                Next
            End If
            cColumns = Nothing

            drv.EndEdit()
            Try
                sa.Update(tbl)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Function
            End Try

            saveDataRow = True

        Catch ex As Exception
            MessageBox.Show("An error occured while trying to update the database." & vbLf & vbLf & ex.Message)
        End Try
    End Function
	''Public Sub setDateTimePanels(ByVal panelDate As StatusBarPanel, ByVal panelTime As StatusBarPanel)
	''    datePanel = panelDate
	''    timePanel = panelTime
	''    panelThread = New Thread(AddressOf updateTime)
	''    panelThread.Start()
	''End Sub
	''Public Sub updateTime()
	''    Do
	''        datePanel.Text = Format(Now(), "MM/dd/yyyy")
	''        timePanel.Text = Format(Now(), "hh:mm tt")
	''        panelThread.Sleep(TimeSpan.FromSeconds(1))
	''        GC.Collect()
	''    Loop
	''End Sub
	Public Sub stopTime()
        panelThread.Abort()
    End Sub
#Region "Crystal Reports"
	''Public Sub crSetTextObj(ByVal rpt As ReportClass, ByVal textName As String, ByVal txtStr As String)
	''    Dim txtObj As TextObject

	''    txtObj = rpt.ReportDefinition.ReportObjects.Item(textName)
	''    txtObj.Text = txtStr
	''End Sub
	''Public Sub crAddTextObj(ByVal rpt As ReportClass, ByVal textName As String, ByVal txtStr As String)
	''       'Haven't figured out how to do this in .net

	''       'txtObj = rpt.ReportDefinition.ReportObjects.Item(textName)
	''       'txtObj.Text = txtStr
	''   End Sub
	''Public Sub crSectionSuppressState(ByVal rpt As ReportClass, ByVal sectionName As String, ByVal Suppress As Boolean)
	''       Dim section As Section
	''       section = rpt.ReportDefinition.Sections(sectionName)
	''       With section
	''           .SectionFormat.EnableSuppress = Suppress
	''       End With

	''       rpt.ReportDefinition.Sections(sectionName).SectionFormat.EnableSuppress = Suppress
	''   End Sub
	'Public Sub crSetMarginsAll(ByVal rpt As ReportClass, ByVal left As Integer, ByVal top As Integer, ByVal right As Integer, ByVal bottom As Integer)
	'    Dim margins As PageMargins

	'    margins = rpt.PrintOptions.PageMargins
	'    With margins
	'        .leftMargin = left
	'        .topMargin = top
	'        .rightMargin = right
	'        .bottomMargin = bottom
	'    End With
	'    ' Apply the page margins.
	'    rpt.PrintOptions.ApplyPageMargins(margins)
	'End Sub
	'Public Sub crSetMarginLeft(ByVal rpt As ReportClass, ByVal margin As Integer)
	'    Dim margins As PageMargins

	'    margins = rpt.PrintOptions.PageMargins
	'    margins.leftMargin = margin

	'    ' Apply the page margin.
	'    rpt.PrintOptions.ApplyPageMargins(margins)
	'End Sub
	'Public Sub crSetMarginRight(ByVal rpt As ReportClass, ByVal margin As Integer)
	'    Dim margins As PageMargins

	'    margins = rpt.PrintOptions.PageMargins
	'    margins.rightMargin = margin

	'    ' Apply the page margin.
	'    rpt.PrintOptions.ApplyPageMargins(margins)
	'End Sub
	'Public Sub crSetMarginTop(ByVal rpt As ReportClass, ByVal margin As Integer)
	'    Dim margins As PageMargins

	'    margins = rpt.PrintOptions.PageMargins
	'    margins.topMargin = margin

	'    ' Apply the page margin.
	'    rpt.PrintOptions.ApplyPageMargins(margins)
	'End Sub
	'Public Sub crSetMarginBottom(ByVal rpt As ReportClass, ByVal margin As Integer)
	'    Dim margins As PageMargins

	'    margins = rpt.PrintOptions.PageMargins
	'    margins.bottomMargin = margin

	'    ' Apply the page margin.
	'    rpt.PrintOptions.ApplyPageMargins(margins)
	'End Sub
#End Region
	Public Class clsBindings
        Public ctl As Control
        Public Source As Object
        Public Member As String
        Public PropertyName As String
    End Class
    Public Class clsExtraColumns
        Public columnValue As Object 'Long
        Public columnName As String

    End Class

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Function CopyDirectory(ByVal source As String, ByVal destination As String)

        Dim currentDirectory As DirectoryInfo = New DirectoryInfo(source)
        Dim file As FileInfo

        For Each file In currentDirectory.GetFiles()
            file.CopyTo(Path.Combine(destination, file.Name))
        Next

        Dim di As DirectoryInfo

        For Each di In currentDirectory.GetDirectories()

            Dim subDirectory As String = Path.Combine(destination, di.Name)
            Directory.CreateDirectory(subDirectory)

            CopyDirectory(di.FullName, subDirectory)

        Next
    End Function

    Public Function getADUserInfo(ByVal firstName As String, ByVal lastName As String) As String
        Dim propertyName As System.Collections.ICollection
        Dim UserProperty As System.DirectoryServices.PropertyCollection
        Dim UserPropertyValue As System.DirectoryServices.PropertyValueCollection
        Dim entry As New System.DirectoryServices.DirectoryEntry

        Try
            'Get the path
            Dim thePath As String
            Dim dirEntry As New DirectoryServices.DirectoryEntry("LDAP://CTLDATA1")
            Dim mySearcher As New System.DirectoryServices.DirectorySearcher(dirEntry)
            Dim result As System.DirectoryServices.SearchResult
            mySearcher.Filter = "(&(objectCategory=Person)(&(anr=" & firstName & ")(anr=" & lastName & ")))"

            For Each result In mySearcher.FindAll
                thePath = result.GetDirectoryEntry().Path
            Next
            Dim user As Object 'ActiveDs.IADs
            user = GetObject(thePath)

            Dim email As String = user.EmailAddress

            user = Nothing
            dirEntry = Nothing
            mySearcher = Nothing

            Return email
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function getDirectoryFiles(ByVal directory As String, Optional ByVal appPath As Boolean = False, Optional ByVal searchPattern As String = "") As Object

        'Returns a collection of files in the sent directory

        '******************************************************
        'Example code.....
        'Dim files As Object
        'Dim fileName As System.io.FileInfo
        'files = u.getDirectoryFiles("\\bauer2\gcalvert") or
        'files = u.getDirectoryFiles("", True) or
        'files = u.getDirectoryFiles("", True, "*.exe")

        'For Each fileName In files
        '    MsgBox(fileName.Name)
        'Next
        '******************************************************

        ' Create a reference to the sent directory.
        Try
            If appPath Then
                directory = AppDomain.CurrentDomain.BaseDirectory
            End If
            Dim dir As New System.IO.DirectoryInfo(directory)

            ' Create an array representing the files in the current directory.

            Dim fi As System.IO.FileInfo()
            If searchPattern <> "" Then
                fi = dir.GetFiles(searchPattern)
            Else
                fi = dir.GetFiles()
            End If

            getDirectoryFiles = fi

            dir = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    'Public Sub copyFile(ByVal fileName As String, ByVal destinationFolder As String)
    '    'destinationFolder can be a folder or a file
    '    'if it's a folder, copies sent file to sent folder
    '    'if it's a file copies/overwrites destination file

    '    'Dim f As New FileSystemObject

    '    Try
    '        If f.FileExists(fileName) Then f.CopyFile(fileName, destinationFolder, True)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    f = Nothing

    'End Sub

    Public Sub DisableNetworkConnection(ByVal XP As Boolean)
        If XP = True Then
            ' Switch Boolean (Scope: form or module level) 
            Dim LANEnable As Boolean = True

            ' ***** Either placed within a button or routine ***** 

            ' Control Panel Identifier 
            Const ssfCONTROLS = 3

            ' Enter the name of the connection to manipulate 
            Dim ConnectionName As String = "Local Area Connection 7"
            Dim EnableVerb As String = "En&able"
            Dim DisableVerb As String = "Disa&ble"

            ' Generate Shell item 
            Dim ShellApp As New Shell32.Shell
            ' Obtain the CP 
            Dim ControlPanel As Shell32.Folder = ShellApp.NameSpace(ssfCONTROLS)
            Dim FolderItem As Shell32.FolderItem
            Dim NetworkFolder As Shell32.Folder
            Dim LANConnection As Shell32.FolderItem

            ' Loop through the items in the control panel and obtain the Network Connections folder 
            For Each FolderItem In ControlPanel.Items()
                Debug.WriteLine("Loop 1: " & FolderItem.Name)
                If FolderItem.Name = "Network Connections" Then
                    ' When found - exit the loop 
                    NetworkFolder = FolderItem.GetFolder
                    Exit For
                End If
            Next

            ' Debug check 
            If NetworkFolder Is Nothing Then
                MessageBox.Show("Error - No network folder found")
                Exit Sub
            End If

            ' Obtain the appropriate connection record 
            For Each FolderItem In NetworkFolder.Items()
                Debug.WriteLine("Loop 2: " & FolderItem.Name)
                If FolderItem.Name = ConnectionName Then
                    ' When found - exit the loop 
                    LANConnection = FolderItem
                    Exit For
                End If
            Next

            ' Debug check 
            If LANConnection Is Nothing Then
                MessageBox.Show("Error - No LAN entry was not found")
                Exit Sub
            End If

            ' Swtich the LAN toggle 
            LANEnable = Not LANEnable

            Dim EnableVerbItem, DisableVerbItem, Verb As Shell32.FolderItemVerb

            ' Run through all available options and obtain the appropriate action 
            For Each Verb In LANConnection.Verbs
                Debug.WriteLine("Loop 3: " & Verb.Name)
                If Verb.Name = EnableVerb Then
                    EnableVerbItem = Verb
                    LANEnable = True
                End If
                If Verb.Name = DisableVerb Then
                    DisableVerbItem = Verb
                End If
            Next

            ' Perform the enable / disable 
            Try
                DisableVerbItem.DoIt()
            Catch ex As Exception

            End Try

            If LANEnable Then
                Try
                    EnableVerbItem.DoIt()
                Catch ex As Exception
                End Try
            Else
                Try
                    DisableVerbItem.DoIt()
                Catch ex As Exception
                End Try
            End If

        Else
            ' Switch Boolean (Scope: form or module level) 
            Dim LANEnable As Boolean = True

            ' ***** Either placed within a button or routine ***** 

            ' Control Panel Identifier 
            Const ssfCONTROLS = 3

            ' Enter the name of the connection to manipulate 
            Dim ConnectionName As String = "Local Area Connection 7"
            Dim EnableVerb As String = "En&able"
            Dim DisableVerb As String = "Disa&ble"

            ' Generate Shell item 
            Dim ShellApp As New Shell32.Shell
            ' Obtain the CP 
            Dim ControlPanel As Shell32.Folder = ShellApp.NameSpace(ssfCONTROLS)
            Dim FolderItem As Shell32.FolderItem
            Dim NetworkFolder As Shell32.Folder
            Dim LANConnection As Shell32.FolderItem

            ' Loop through the items in the control panel and obtain the Network Connections folder 
            For Each FolderItem In ControlPanel.Items()
                Debug.WriteLine("Loop 1: " & FolderItem.Name)
                If FolderItem.Name = "Network and Dial-up Connections" Then
                    ' When found - exit the loop 
                    NetworkFolder = FolderItem.GetFolder
                    Exit For
                End If
            Next

            ' Debug check 
            If NetworkFolder Is Nothing Then
                MessageBox.Show("Error - No network folder found")
                Exit Sub
            End If

            ' Obtain the appropriate connection record 
            For Each FolderItem In NetworkFolder.Items()
                Debug.WriteLine("Loop 2: " & FolderItem.Name)
                If FolderItem.Name = ConnectionName Then
                    ' When found - exit the loop 
                    LANConnection = FolderItem
                    Exit For
                End If
            Next

            ' Debug check 
            If LANConnection Is Nothing Then
                MessageBox.Show("Error - No LAN entry was not found")
                Exit Sub
            End If

            ' Swtich the LAN toggle 
            LANEnable = Not LANEnable

            Dim EnableVerbItem, DisableVerbItem, Verb As Shell32.FolderItemVerb

            ' Run through all available options and obtain the appropriate action 
            For Each Verb In LANConnection.Verbs
                Debug.WriteLine("Loop 3: " & Verb.Name)
                If Verb.Name = EnableVerb Then
                    EnableVerbItem = Verb
                    LANEnable = True
                End If
                If Verb.Name = DisableVerb Then
                    DisableVerbItem = Verb
                End If
            Next

            ' Perform the enable / disable 
            If LANEnable Then
                EnableVerbItem.DoIt()
            Else
                DisableVerbItem.DoIt()
            End If
        End If
    End Sub
    Public Sub disableDataGridColumns(ByVal datagrid As DataGrid)
        Dim tbc As DataGridTextBoxColumn
        'Dim bc As DataGridBoolColumn
        Try
            For Each tbc In datagrid.TableStyles(0).GridColumnStyles
                tbc.TextBox.Enabled = False
            Next
            'For Each bc In datagrid.TableStyles(0).GridColumnStyles

            'Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub killPreviousProcessInstances(ByVal currentProcesses As Process())
        'Sample call
        'u.killPreviousProcessInstances(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName))

        Dim process As Process
        For Each process In currentProcesses
            'Kill any instances except the current one
            If process.Id <> Diagnostics.Process.GetCurrentProcess.Id Then process.Kill()
        Next
    End Sub
    Public Function checkMultipleAppInstances(ByVal process As Process()) As Boolean
        'Checks to see if an instance of the application is already running, notifies the user and returns boolean

        'Sample Call
        'If u.checkMultipleAppInstances(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) = True Then End

        checkMultipleAppInstances = False
        If (UBound(process) > 0) = True Then
            MsgBox(Diagnostics.Process.GetCurrentProcess.ProcessName & " is already running.", , "Application Message")
            checkMultipleAppInstances = True
            Exit Function
        End If
    End Function

    Public Function EmailerService(ByVal Subject As String, ByVal Body As String, ByVal EmailFrom As String, ByVal EmailTo As String, ByVal Complete As Integer, ByVal DateSent As Date, ByVal Keycode As String)
        ExecuteSQL(EmailerConn, "INSERT INTO EMAIL (Subject, Body, EmailFrom, EmailTo, DateSent, Complete, KeyCode) Values ('" & FTM(ISN(Subject)) & "', '" & FTM(ISN(Body)) & "', '" & FTM(ISN(EmailFrom)) & "', '" & FTM(ISN(EmailTo)) & "', '" & DateSent & "', '" & Complete & "', '" & Keycode & "')")
        'MsgBox("The Notification Has Been Sent.")
    End Function

    'Public Function CheckSpelling(ByVal TextBox As Boolean, ByVal ComboBox As Boolean, Optional ByVal TextControl As TextBox = Nothing, Optional ByVal ComboControl As ComboBox = Nothing)
    '    If TextBox = True Then
    '        If TextControl.Text.Length > 0 Then
    '            'Make a word server object
    '            Dim word_server As New Word.Application

    '            'Hide The Server
    '            word_server.Visible = False

    '            'Make a word document
    '            Dim doc As Word.Document = word_server.Documents.Add
    '            Dim rng As Word.Range

    '            'Make a range to represent the document
    '            rng = doc.Range

    '            'copy the text into the document
    '            rng.Text = TextControl.Text

    '            'Activate the document and call its checkspelling method.
    '            doc.Activate()
    '            doc.CheckSpelling()

    '            'copy the results back into the text box, trimming off the trailing CR and LF characters.
    '            Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
    '            TextControl.Text = doc.Range().Text.Trim(chars)

    '            'Close the document, not saving changes
    '            doc.Close(SaveChanges:=False)

    '            'Close the word server.
    '            word_server.Quit()
    '        End If
    '    ElseIf ComboBox = True Then

    '        If ComboControl.Text.Length > 0 Then

    '            'Make a word server object
    '            Dim word_server As New Word.Application

    '            'Hide The Server
    '            word_server.Visible = False

    '            'Make a word document
    '            Dim doc As Word.Document = word_server.Documents.Add
    '            Dim rng As Word.Range

    '            'Make a range to represent the document
    '            rng = doc.Range

    '            'copy the text into the document
    '            rng.Text = ComboControl.Text

    '            'Activate the document and call its checkspelling method.
    '            doc.Activate()
    '            doc.CheckSpelling()

    '            'copy the results back into the text box, trimming off the trailing CR and LF characters.
    '            Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
    '            ComboControl.Text = doc.Range().Text.Trim(chars)

    '            'Close the document, not saving changes
    '            doc.Close(SaveChanges:=False)

    '            'Close the word server.
    '            word_server.Quit()

    '        End If
    '    End If

    'End Function
End Class
