Public Class frmProjectWorkflowSync
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmProjectWorkflowSync_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString


        da = New SqlClient.SqlDataAdapter("Select PROJ_NAME from pub.MSP_Projects Order By PROJ_NAME Asc", SqlProjServer)
        da.Fill(ds, "PROJSERVERNAMES")

        Dim i As Integer = 0

        While i <= ds.Tables("PROJSERVERNAMES").Rows.Count - 1
            Me.cboProjectServerProjectNames.Items.Add(ds.Tables("PROJSERVERNAMES").Rows(i).Item("PROJ_NAME"))
            i = i + 1
        End While

        ds.Tables("PROJSERVERNAMES").Clear()
        ds.Tables("PROJSERVERNAMES").Dispose()

        da = New SqlClient.SqlDataAdapter("SELECT ProjectName From tblProjects Where Active = 'True'", SqlConnection1)
        da.Fill(ds, "WorkFlowPrograms")

        Dim z As Integer = 0

        While z <= ds.Tables("WorkFlowPrograms").Rows.Count - 1
            Me.cboEngWorkflowProjects.Items.Add(ds.Tables("WorkFlowPrograms").Rows(z).Item("ProjectName"))
            z = z + 1
        End While

        ds.Tables("WorkFlowPrograms").Clear()
        ds.Tables("WorkFlowPrograms").Dispose()

    End Sub

    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSync.Click
        MsgBox("Please click OK and wait!  A done message will be displayed when the sync is complete.")

        Dim msg As Integer = 0

        Dim DrawingNumber As String
        Dim DrawingRev As String
        Dim Drafter As String
        Dim WONumber As String
        Dim ADCN As String
        Dim DRN As String

        If optServertoWorkflow.Checked = True Then

            'Query by project name and get unique id.
            da = New SqlClient.SqlDataAdapter("Select PROJ_UID from pub.MSP_PROJECTS Where PROJ_NAME = '" & Me.cboProjectServerProjectNames.Text & "'", SqlProjServer)
            da.Fill(ds, "PROJ")

            'Get list of tasks and any key fields to push data from

            da = New SqlClient.SqlDataAdapter("Select ProjectUID, TaskSTartDate, TaskFinishDate, Convert(int, [WO Number]) As WONumber, [Drawing #] As DrawingNumber, Drafter, [Drawing Revision] As DrawingRev, DRN, ADCN FROM dbo.MSP_EpmTask_UserView Where ProjectUID = '" & ds.Tables("PROJ").Rows(0).Item("PROJ_UID").ToString & "'", SqlProjServer)
            da.Fill(ds, "TASKS")

            MsgBox(ds.Tables("TASKS").Rows.Count)

            'MsgBox(ds.Tables("TASKS").Rows.Count)

            Dim y As Integer = 0

            While y <= ds.Tables("TASKS").Rows.Count - 1

                'Get data for custom fields

                '''Drawing #

                If IsDBNull(ds.Tables("TASKS").Rows(y).Item("DrawingNumber")) Then
                    DrawingNumber = ""
                Else
                    DrawingNumber = ds.Tables("TASKS").Rows(y).Item("DrawingNumber")
                End If


                If IsDBNull(ds.Tables("TASKS").Rows(y).Item("DrawingRev")) Then
                    DrawingRev = ""
                Else
                    DrawingRev = ds.Tables("TASKS").Rows(y).Item("DrawingRev")
                End If

                'Drafter
                If IsDBNull(ds.Tables("TASKS").Rows(y).Item("Drafter")) Then
                    Drafter = ""
                Else
                    Drafter = ds.Tables("TASKS").Rows(y).Item("Drafter")
                End If

                'WO Number

                If IsDBNull(ds.Tables("TASKS").Rows(y).Item("WONumber")) Then
                    WONumber = ""
                Else
                    WONumber = ds.Tables("TASKS").Rows(y).Item("WONumber")
                End If

                If IsDBNull(ds.Tables("TASKS").Rows(y).Item("DRN")) Then
                    DRN = ""
                Else
                    DRN = ds.Tables("TASKS").Rows(y).Item("DRN")
                End If

                If IsDBNull(ds.Tables("TASKS").Rows(y).Item("ADCN")) Then
                    ADCN = ""
                Else
                    ADCN = ds.Tables("TASKS").Rows(y).Item("ADCN")
                End If

                'Update workflow where drawing # = and Drawing Revision =


                If DrawingNumber = "" Or DrawingRev = "" Then
                    'Do Nothing!
                Else
                    da = New SqlClient.SqlDataAdapter("Select DrafterSignedOffBy from tblDrawings Where Program = '" & cboEngWorkflowProjects.Text & "' AND DrawingNumber = '" & DrawingNumber & "' and DwgRevision = '" & DrawingRev & "' and ADCN = '" & ADCN & "' and DRNADCN = '" & DRN & "'", SqlConnection1)
                    da.Fill(ds, "DFSB")
                    If ds.Tables("DFSB").Rows.Count > 0 Then
                        If ds.Tables("DFSB").Rows(0).Item("DrafterSignedOffBy") = "" Then
                            'Try to update!
                            'If Drafter is not signed off, then we update the drafter field.
                            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set Drafter = '" & Drafter & "', WONumber = '" & WONumber & "', ForecastStartDate = '" & ds.Tables("TASKS").Rows(y).Item("TaskStartDate") & "', ForecastFinishDate = '" & ds.Tables("TASKS").Rows(y).Item("TaskFinishDate") & "', Updated = 'True', UpdatedDate = '" & Now & "' Where Program = '" & cboEngWorkflowProjects.Text & "' AND DrawingNumber = '" & DrawingNumber & "' and DwgRevision = '" & DrawingRev & "' and ADCN = '" & ADCN & "' and DRNADCN = '" & DRN & "'")

                        Else
                            'Try to update!
                            'If Drafter is signed off already, don't update the drafter field
                            u.ExecuteSQL(SqlConnection1, "Update tblDrawings Set WONumber = '" & WONumber & "',  ForecastStartDate = '" & ds.Tables("TASKS").Rows(y).Item("TaskStartDate") & "', ForecastFinishDate = '" & ds.Tables("TASKS").Rows(y).Item("TaskFinishDate") & "', Updated = 'True', UpdatedDate = '" & Now & "' Where Program = '" & cboEngWorkflowProjects.Text & "' AND DrawingNumber = '" & DrawingNumber & "' and DwgRevision = '" & DrawingRev & "' and ADCN = '" & ADCN & "' and DRNADCN = '" & DRN & "'")
                        End If
                        ds.Tables("DFSB").Clear()
                        ds.Tables("DFSB").Dispose()
                    End If


                    'msg = msg + 1
                End If
                y = y + 1
            End While
            MsgBox("Done.")
            ds.Tables("TASKS").Clear()
            ds.Tables("TASKS").Dispose()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class