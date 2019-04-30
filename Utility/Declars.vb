Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Threading
Module Declars
    'Public sqlConn As SqlConnection
    Public rs As SqlDataReader
    Public i As Integer
    'Public u As New Utility
    Public dgComboBox As New ComboBox 'for datagrid-embedded comboboxes
    Public cm As CurrencyManager
    'Public eMailStr As String

    'Auto Size Columns
    'Public Const LVM_FIRST = &H1000
    'Public Const LVM_SETCOLUMNWIDTH = (LVM_FIRST + 30)
    'Public Const LVSCW_AUTOSIZE = -1
    'Public Const LVSCW_AUTOSIZE_USEHEADER = -2

    Public datePanel As StatusBarPanel
    Public timePanel As StatusBarPanel
    Public panelThread As Thread

    Public elapsedTimeDate As Date
    Public elapsedTimeControl As Control
    Public elapsedTimeThread As Thread

    Public DebugEnabled As String

    Public Declare Function SendMessage Lib "User32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal msg As Integer, _
        ByVal wParam As Integer, ByVal lParam As Integer) As Integer
End Module
