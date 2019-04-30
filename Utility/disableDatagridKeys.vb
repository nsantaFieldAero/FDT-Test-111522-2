Public Class disableDatagridKeys
    Inherits DataGrid

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        '
        ' Disable the datagrid navigation keys.
        '

        'Need to change these on your datagrid form components and initialize components objects
        'Friend WithEvents yourFormDatagrid As Util.disableDatagridKeys instead of AS System.Windows.Forms.DataGrid
        'Me.yourFormDatagrid = New Util.disableDatagridKeys instead of New System.Windows.Forms.DataGrid

        Try
            Select Case msg.WParam.ToInt32()
                Case CInt(Keys.Tab), CInt(Keys.Right), CInt(Keys.Left), CInt(Keys.Enter)
                    Return True
            End Select
        Catch ex As Exception

        End Try


        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
