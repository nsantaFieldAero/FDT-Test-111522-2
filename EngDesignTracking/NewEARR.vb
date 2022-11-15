Imports System.ComponentModel

Public Class NewEARR

    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim da2 As SqlClient.SqlDataAdapter
    Dim ds2 As New DataSet
    Dim da3 As SqlClient.SqlDataAdapter
    Dim ds3 As New DataSet
    Dim da4 As SqlClient.SqlDataAdapter
    Dim ds4 As New DataSet
    Dim da5 As SqlClient.SqlDataAdapter
    Dim ds5 As New DataSet
    Dim da6 As SqlClient.SqlDataAdapter
    Dim ds6 As New DataSet
    Dim da7 As SqlClient.SqlDataAdapter
    Dim ds7 As New DataSet
    Dim da8 As SqlClient.SqlDataAdapter
    Dim ds8 As New DataSet
    Dim QC As String
    Dim QCBackup As String
    Dim OriginatorSignOff As Date
    Dim LiaisonEngineer As String
    Dim LiaisonEngineerBackup As String
    Dim EngineerManager As String
    Dim EngineerManagerBackup As String
    Dim Planner1 As String
    Dim Planner2 As String
    Dim EARRNUmber As Integer
    Public RowSelectedDrawingsGrid
    Dim DrawNumAdded As String

    Private Sub btnSubmitEARR_Click(sender As Object, e As EventArgs) Handles btnSubmitEARR.Click

        Dim errors As String = ""

        If Me.txtEARRNumber.Text = "" Then
            errors = "You are required to enter a earr number." & Environment.NewLine & "" & Environment.NewLine & ""

        End If
        If cboEARRType.Text = "" Then
            errors = errors + "You are required to enter a EARR type." & Environment.NewLine & "" & Environment.NewLine & ""

        End If
        If Me.cboProgramName.Text = "" Then
            errors = errors + "You are required to enter a program name." & Environment.NewLine & "" & Environment.NewLine & ""

        End If
        If Me.txtEndItemType.Text = "" Then
            errors = errors + "Your are required to enter a end item type." & Environment.NewLine & "" & Environment.NewLine & ""

        End If
        If Me.txtSerialNumber.Text = "" Then
            errors = errors + "You are required to enter a serial number." & Environment.NewLine & "" & Environment.NewLine & ""

        End If

        If Me.txtWorkOrder.Text = "" Then
            errors = errors + "You are required to enter a work order.seq number." & Environment.NewLine & "" & Environment.NewLine & ""

        End If

        If DrawNumAdded = "" Then
            errors = errors + "You are required to enter at least one drawing number." & Environment.NewLine & "" & Environment.NewLine & ""
        End If

        'If Me.txtDrawingNumber.Text = "" Then
        '    errors = errors + "You are required to enter a drawing number." & Environment.NewLine & "" & Environment.NewLine & ""

        'End If

        'If Me.txtDrawingRevision.Text = "" Then
        '    errors = errors + "You are required to enter a drawing revision." & Environment.NewLine & "" & Environment.NewLine & ""

        'End If

        If Me.txtRequest.Text = "" Then
            errors = errors + "You are required to enter a request." & Environment.NewLine & "" & Environment.NewLine & ""

        End If

        If Me.chkIncorpRedLineNo.Checked = False And Me.chkIncorpRedLineYes.Checked = False Then
            errors = errors + "You are required to check a box in the incorporate redline section." & Environment.NewLine & "" & Environment.NewLine & ""

        End If

        If Me.chkDrawingReqForConformityNo.Checked = False And Me.chkDrawingReqForConformityYes.Checked = False Then
            errors = errors + "You are required to check a box in the drawing required for conformity section." & Environment.NewLine & "" & Environment.NewLine & ""

        End If

        If errors <> "" Then
            errors = errors + "Please correct the errors above and submit."
            MsgBox(errors)
            Exit Sub

        End If
        '******NEEED TO GET NEXT EARR NUMBER!

        If Me.cboProgramName.Text = "" Or Me.cboEARRType.Text = "" Then
            MsgBox("You must select a Program Name and EARR Type before continuining.")
            Exit Sub
        End If

        If Me.txtWorkOrder.Text = "" Then
            MsgBox("IMPORTANT:  You must enter a valid work order and step in the format of wonumber.step in the work order number field unless you have checked fab shop.  If the EARR is for a work order with no step, enter the workordernumber.0")
        End If


        'If chkFabShop.Checked = True Then
        '    Me.txtWorkOrder.Text = "N/A"
        '    Me.txtEARRNumber.Text = Format(Now, "mmddyyyyhhss")


        'Else
        'Look for prior work.step records.
        da = New SqlClient.SqlDataAdapter("Select * from tblEARR Where WorkOrder = '" & Me.txtWorkOrder.Text & "' Order By RecordID Desc", SqlConnection2)
        da.Fill(ds, "EXIST")

        If ds.Tables("EXIST").Rows.Count > 0 And Me.txtWorkOrder.Text.Contains("FAB") Then
            MsgBox("You cannot have a duplicate fab shop EARR.")
            ds.Tables("EXIST").Clear()
            ds.Tables("EXIST").Dispose()
            Exit Sub
        ElseIf ds.Tables("EXIST").Rows.Count > 0 Then
            Dim s As String
            s = ds.Tables("EXIST").Rows(0).Item("EARRNUmber")
            Trim(s)
            Dim words As String() = s.Split(New Char() {"."c})

            Dim i As Integer
            i = Val(words(2)) + 1

            Me.txtEARRNumber.Text = Me.txtWorkOrder.Text + "." + Format(i, "")
        Else
            Me.txtEARRNumber.Text = Me.txtWorkOrder.Text + ".1"
        End If

        'End If


        'If exist, need to look at EARR number and get the last value.



        'Step 1:  Have Originator Confirm they intend to submit this.

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to submit this EARR?  By confirming yes you are agreeing that everything stated on the EARR is accurate to the best of your knowledge.",
                      "Title",
                      MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            OriginatorSignOff = Now
        Else
            MsgBox("This screen will now be closed.  If you want to re-enter a EARR you can at a later time.")
            Me.Close()
        End If



        'Step 2:  Based on program/EARR Type, populate the LiaisonManager name and the backup.

        If cboProgramName.Text = "Jaguar" And cboEARRType.Text = "Mechanical" Then
            'LiaisonEngineer = "jrovenstine@fieldaero.com"
            'LiaisonEngineerBackup = "brauenbuehler@fieldaero.com"
            ''No current Backup.
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "Jaguar" And cboEARRType.Text = "Electrical" Then
            'LiaisonEngineer = "mwebe@fieldaero.com"
            'LiaisonEngineerBackup = "radamek@fieldaero.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "2640 - Missionized Interior MMSA-C (G550)" And cboEARRType.Text = "Mechanical" Then
            'LiaisonEngineer = "rrathwell@fieldaero.com"
            'LiaisonEngineerBackup = "brauenbuehler@fieldaero.com"
            ''No current Backup.
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "2640 - Missionized Interior MMSA-C (G550)" And cboEARRType.Text = "Electrical" Then
            'LiaisonEngineer = "mwebe@fieldaero.com"
            'LiaisonEngineerBackup = "radamek@fieldaero.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "2635 - Jaguar" And cboEARRType.Text = "Mechanical" Then
            'LiaisonEngineer = "rrathwell@fieldaero.com"
            'LiaisonEngineerBackup = "brauenbuehler@fieldaero.com"
            ''No current Backup.
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "2635 - Jaguar" And cboEARRType.Text = "Electrical" Then
            'LiaisonEngineer = "mwebe@fieldaero.com"
            'LiaisonEngineerBackup = "radamek@fieldaero.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "Sherpa" And cboEARRType.Text = "Mechanical" Then
            'LiaisonEngineer = "jrovenstine@fieldaero.com"
            'LiaisonEngineerBackup = "brauenbuehler@fieldaero.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "Sherpa" And cboEARRType.Text = "Electrical" Then
            'LiaisonEngineer = "dmolloy@fieldaero.com"
            'LiaisonEngineerBackup = "dmolloy@fieldaero.com"
            ''No current Backup.
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "16033-CBP" Then
            'LiaisonEngineer = "akrause@fieldav.com"
            'LiaisonEngineerBackup = "jsprigg@fieldav.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "192181 – MIT ASTB" And cboEARRType.Text = "Mechanical" Then
            'LiaisonEngineer = "jlombardi@fieldaero.com"
            'LiaisonEngineerBackup = "blitvikov@fieldaero.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "192181 – MIT ASTB" And cboEARRType.Text = "Electrical" Then
            'LiaisonEngineer = "blitvikov@fieldaero.com"
            'LiaisonEngineerBackup = "jlombardi@fieldaero.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "Repetitive Sale" And cboEARRType.Text = "Mechanical" Then
            'LiaisonEngineer = "uniaz@fieldaero.com"
            'LiaisonEngineerBackup = "akrause@fieldaero.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "Repetitive Sale" And cboEARRType.Text = "Electrical" Then
            'LiaisonEngineer = "uniaz@fieldaero.com"
            'LiaisonEngineerBackup = "akrause@fieldaero.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "16190 - CAE" And cboEARRType.Text = "Mechanical" Then
            'LiaisonEngineer = "skeeley@fieldaero.com"
            'LiaisonEngineerBackup = "uniaz@fieldaero.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "16190 - CAE" And cboEARRType.Text = "Electrical" Then
            'LiaisonEngineer = "skeeley@fieldaero.com"
            'LiaisonEngineerBackup = "uniaz@fieldaero.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "192303 - SCG" And cboEARRType.Text = "Mechanical" Then
            'LiaisonEngineer = "kturner@fieldaero.com"
            'LiaisonEngineerBackup = "klu@fieldaero.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "192303 - SCG" And cboEARRType.Text = "Electrical" Then
            'LiaisonEngineer = "uniaz@fieldaero.com"
            'LiaisonEngineerBackup = "lwu@fieldaero.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        'Step 3:  Based on the program/EARR Type, populate the Engineering Manager name and the backup

        If cboProgramName.Text = "Jaguar" And cboEARRType.Text = "Mechanical" Then
            'EngineerManager = "rdetillier@fieldaero.com"
            'EngineerManagerBackup = "jwitter@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "Jaguar" And cboEARRType.Text = "Electrical" Then
            'EngineerManager = "jwitter@fieldaero.com"
            'EngineerManagerBackup = "mwebe@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "2640 - Missionized Interior MMSA-C (G550)" And cboEARRType.Text = "Mechanical" Then
            'EngineerManager = "pcampbell@fieldaero.com"
            'EngineerManagerBackup = "ohaswell@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "2640 - Missionized Interior MMSA-C (G550)" And cboEARRType.Text = "Electrical" Then
            'EngineerManager = "jwitter@fieldaero.com"
            'EngineerManagerBackup = "mwebe@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "2635 - Jaguar" And cboEARRType.Text = "Mechanical" Then
            'EngineerManager = "edoetzel@fieldaero.com"
            'EngineerManagerBackup = "pcampbell@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "2635 - Jaguar" And cboEARRType.Text = "Electrical" Then
            'EngineerManager = "jwitter@fieldaero.com"
            'EngineerManagerBackup = "mwebe@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "Sherpa" And cboEARRType.Text = "Mechanical" Then
            'EngineerManager = "rdetillier@fieldaero.com"
            'EngineerManagerBackup = "jwitter@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "Sherpa" And cboEARRType.Text = "Electrical" Then
            'EngineerManager = "jspillane@fieldaero.com"
            'EngineerManagerBackup = "dmolloy@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "16190 - CAE" And cboEARRType.Text = "Mechanical" Then
            'EngineerManager = "skeeley@fieldaero.com"
            'EngineerManagerBackup = "akrause@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "16190 - CAE" And cboEARRType.Text = "Electrical" Then
            'EngineerManager = "skeeley@fieldaero.com"
            'EngineerManagerBackup = "akrause@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "192303 - SCG" And cboEARRType.Text = "Mechanical" Then
            'EngineerManager = "esmith@fieldaero.com"
            'EngineerManagerBackup = "karcinas@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "192303 - SCG" And cboEARRType.Text = "Electrical" Then
            'EngineerManager = "akrause@fieldaero.com"
            'EngineerManagerBackup = "skeeley@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "16033-CBP" Then
            'EngineerManager = "akrause@fieldav.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "192181 – MIT ASTB" And cboEARRType.Text = "Mechanical" Then
            'EngineerManager = "rdasilva@fieldaero.com"
            'EngineerManagerBackup = "rblake@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "192181 – MIT ASTB" And cboEARRType.Text = "Electrical" Then
            'EngineerManager = "jmeaden@fieldaero.com"
            'EngineerManagerBackup = "jsprigg@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "Repetitive Sale" And cboEARRType.Text = "Mechanical" Then
            'EngineerManager = "rblake@fieldaero.com"
            'EngineerManagerBackup = "mhales@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        ElseIf cboProgramName.Text = "Repetitive Sale" And cboEARRType.Text = "Electrical" Then
            'EngineerManager = "akrause@fieldaero.com"
            'EngineerManagerBackup = "skeeley@fieldaero.com"
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Type2 = '" & cboEARRType.Text & "' And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        'Step 4:  Based on the program/EARR Type, populate the planner1 and planner2.

        If cboProgramName.Text = "Jaguar" Or cboProgramName.Text = "2640 - Missionized Interior MMSA-C (G550)" Or cboProgramName.Text = "2635 - Jaguar" Then
            'Planner1 = "RPATTERS@fieldaero.com"
            'Planner2 = "JWOODS@fieldaero.com"
            da7 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner1 = 'True' And EnterEARR = 'True'", SqlConnection2)
            da8 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner2 = 'True' And (Planner1 Is Null Or Planner1 = 0) And EnterEARR = 'True'", SqlConnection2)

            If chkFabShop.Checked = True Then
                'QC = "twahnon@fieldaero.com"
                'QCBackup = "dplummer@fieldaero.com"
                da5 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where FabShop = 'True' And (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QC = 'True' And EnterEARR = 'True'", SqlConnection2)
                da6 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where FabShop = 'True' And (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QCBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
            Else
                'QC = "rburr@fieldaero.com"
                'QCBackup = "dplummer@fieldaero.com"
                da5 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where FabShop != 'True' And (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QC = 'True' And EnterEARR = 'True'", SqlConnection2)
                da6 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where FabShop != 'True' And (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QCBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
            End If
        End If

        If Me.cboProgramName.Text = "QCTEST" Then
            'Planner1 = "acooper@fieldaero.com"
            'Planner2 = "acooper@fieldaero.com"
            'QC = "acooper@fieldaero.com"
            'QCBackup = "acooper@fieldaero.com"
            'LiaisonEngineer = "acooper@fieldaero.com"
            'LiaisonEngineerBackup = "acooper@fieldaero.com"
            'EngineerManager = "acooper@fieldaer.com"
            'EngineerManagerBackup = "acooper@fieldaero.com"
            da = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Liaison = 'True' And EnterEARR = 'True'", SqlConnection2)
            da2 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And LiaisonBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
            da3 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Engineer = 'True' And EnterEARR = 'True'", SqlConnection2)
            da4 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And EngineerBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
            da5 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QC = 'True' And EnterEARR = 'True'", SqlConnection2)
            da6 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QCBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
            da7 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner1 = 'True' And EnterEARR = 'True'", SqlConnection2)
            da8 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner2 = 'True' And EnterEARR = 'True'", SqlConnection2)

        End If

        If cboProgramName.Text = "Sherpa" Then
            'Planner1 = "dfuentez@fieldaero.com"
            'Planner2 = "RPATTERS@fieldaero.com"
            'QC = "rdclark@fieldaero.com"
            'QCBackup = "dyounts@fieldaero.com"
            da5 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QC = 'True' And EnterEARR = 'True'", SqlConnection2)
            da6 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QCBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
            da7 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner1 = 'True' And EnterEARR = 'True'", SqlConnection2)
            da8 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner2 = 'True' And EnterEARR = 'True'", SqlConnection2)

        End If

        If cboProgramName.Text = "16033-CBP" Then
            'Planner1 = "rhaggan@fieldav.com"
            'Planner2 = "kticknor@fieldav.com"
            'QC = "hdyck@fieldav.com"
            'QCBackup = "gbensusan@fieldav.com"
            da5 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QC = 'True' And EnterEARR = 'True'", SqlConnection2)
            da6 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QCBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
            da7 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner1 = 'True' And EnterEARR = 'True'", SqlConnection2)
            da8 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner2 = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "192181 – MIT ASTB" Then
            'Planner1 = "KTicknor@fieldaero.com"
            'Planner2 = "preteshwars@fieldaero.com"
            'QC = "dbrown@fieldaero.com"
            'QCBackup = "aboehm@fieldaero.com"
            da5 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QC = 'True' And EnterEARR = 'True'", SqlConnection2)
            da6 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QCBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
            da7 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner1 = 'True' And EnterEARR = 'True'", SqlConnection2)
            da8 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner2 = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "Repetitive Sale" Then
            'Planner1 = "araso@fieldaero.com"
            'Planner2 = "preteshwars@fieldaero.com"
            'QC = "icella@fieldaero.com"
            'QCBackup = "nsaqi@fieldaero.com"
            da5 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QC = 'True' And EnterEARR = 'True'", SqlConnection2)
            da6 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QCBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
            da7 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner1 = 'True' And EnterEARR = 'True'", SqlConnection2)
            da8 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner2 = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "16190 - CAE" Then
            'Planner1 = "araso@fieldaero.com"
            'Planner2 = "preteshwars@fieldaero.com"
            'QC = "mmischuk@fieldaero.com"
            'QCBackup = "nsaqi@fieldaero.com"
            da5 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QC = 'True' And EnterEARR = 'True'", SqlConnection2)
            da6 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QCBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
            da7 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner1 = 'True' And EnterEARR = 'True'", SqlConnection2)
            da8 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner2 = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If cboProgramName.Text = "192303 - SCG" Then
            'Planner1 = "araso@fieldaero.com"
            'Planner2 = "preteshwars@fieldaero.com"
            'QC = "icella@fieldaero.com"
            'QCBackup = "nsaqi@fieldaero.com"
            da5 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QC = 'True' And EnterEARR = 'True'", SqlConnection2)
            da6 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And QCBackup = 'True' And EnterEARR = 'True'", SqlConnection2)
            da7 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner1 = 'True' And EnterEARR = 'True'", SqlConnection2)
            da8 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where (Program = '" & cboProgramName.Text & "' Or Program2 = '" & cboProgramName.Text & "' Or Program3 = '" & cboProgramName.Text & "' Or Program4 = '" & cboProgramName.Text & "') And Planner2 = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        If chkFabShop.Checked = True Then
            'Planner1 = "rmartin@fieldaero.com"
            'Planner2 = "wquinn@fieldaero.com"
            da7 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where FabShop = 'True' And Planner1 = 'True' And EnterEARR = 'True'", SqlConnection2)
            da8 = New SqlClient.SqlDataAdapter("Select Email From tblUsersCreateEARR Where FabShop = 'True' And Planner2 = 'True' And EnterEARR = 'True'", SqlConnection2)
        End If

        da.Fill(ds, "Liaison")
        da2.Fill(ds, "LiaisonBackup")
        da3.Fill(ds, "Engineer")
        da4.Fill(ds, "EngineerBackup")
        da5.Fill(ds, "QC")
        da6.Fill(ds, "QCBackup")
        da7.Fill(ds, "Planner1")
        da8.Fill(ds, "Planner2")

        If ds.Tables("Liaison").Rows.Count > 0 Then
            LiaisonEngineer = ds.Tables("Liaison").Rows(0).Item("Email")

            ds.Tables("Liaison").Clear()
            ds.Tables("Liaison").Dispose()
        End If

        If ds.Tables("LiaisonBackup").Rows.Count > 0 Then
            LiaisonEngineerBackup = ds.Tables("LiaisonBackup").Rows(0).Item("Email")

            ds.Tables("LiaisonBackup").Clear()
            ds.Tables("LiaisonBackup").Dispose()
        End If

        If ds.Tables("Engineer").Rows.Count > 0 Then
            EngineerManager = ds.Tables("Engineer").Rows(0).Item("Email")

            ds.Tables("Engineer").Clear()
            ds.Tables("Engineer").Dispose()
        End If

        If ds.Tables("EngineerBackup").Rows.Count > 0 Then
            EngineerManagerBackup = ds.Tables("EngineerBackup").Rows(0).Item("Email")

            ds.Tables("EngineerBackup").Clear()
            ds.Tables("EngineerBackup").Dispose()
        End If

        If ds.Tables("QC").Rows.Count > 0 Then
            QC = ds.Tables("QC").Rows(0).Item("Email")

            ds.Tables("QC").Clear()
            ds.Tables("QC").Dispose()
        End If

        If ds.Tables("QCBackup").Rows.Count > 0 Then
            QCBackup = ds.Tables("QCBackup").Rows(0).Item("Email")

            ds.Tables("QCBackup").Clear()
            ds.Tables("QCBackup").Dispose()
        End If

        If ds.Tables("Planner1").Rows.Count > 0 Then
            Planner1 = ds.Tables("Planner1").Rows(0).Item("Email")

            ds.Tables("Planner1").Clear()
            ds.Tables("Planner1").Dispose()
        End If

        If ds.Tables("Planner2").Rows.Count > 0 Then
            Planner2 = ds.Tables("Planner2").Rows(0).Item("Email")

            ds.Tables("Planner2").Clear()
            ds.Tables("Planner2").Dispose()
        End If



        'Step 5:  Submit to database.
        'u.ExecuteSQL(SqlConnection2, "INSERT INTO tblEARR (EARRNumber,EARRStatus,EARRType,SerialNumber,WorkOrder,ProgramName,DrawingNumber,DrawingRevision,Request,IncorpRedLineYes,IncorpRedLineNo,DRawingReqForConformityYes,DrawingReqForConformityNo,EARRResponseDate,OriginatorName,OriginatorDate,OriginatorSignedOff,ReplyInstructions,EffectivityAll,EffectivityOther,EffectivityOtherText,DeviationMinor,DeviationMajor,AdditionalEngReqNoAction,AdditionalEngReqUpdate,ACFTInterface,Manufacturability,ProductImprovement,DWGError,DesignError,LiaisonManagerName,LiaisonManagerNameBackup,LiaisonManagerSignOffDate,EngineeringManagerName,EngineeringManagerNameBackup,EngineeringManagerSignOffDate,Planner1,Planner2, QCName, QCNameBackup, QCSignOff, FabShop, ProductionError, QCNotes, PlannerSignOffDate, PlannerNotes, EndItemType, DeviationNA, EstCompletionDate, Comments, Priority) Values ('" & Me.txtEARRNumber.Text & "', 'Pending', '" & u.FTM(Me.cboEARRType.Text) & "', '" & Me.txtSerialNumber.Text & "', '" & Me.txtWorkOrder.Text & "', '" & u.FTM(Me.cboProgramName.Text) & "', '" & Me.txtDrawingNumber.Text & "', '" & u.FTM(Me.txtDrawingRevision.Text) & "', '" & u.FTM(Me.txtRequest.Text) & "', '" & chkIncorpRedLineYes.CheckState & "', '" & Me.chkIncorpRedLineNo.CheckState & "','" & Me.chkDrawingReqForConformityYes.CheckState & "', '" & Me.chkDrawingReqForConformityNo.CheckState & "', '01/01/1900', '" & u.FTM(txtOriginatorName.Text) & "', '" & Me.dtOriginatorDate.Value & "', '" & Now & "', '',0,0,'', 0,0,0,0,0,0,0,0,0,'" & LiaisonEngineer & "', '" & LiaisonEngineerBackup & "', '01/01/1900', '" & EngineerManager & "', '" & EngineerManagerBackup & "', '01/01/1900', '" & Planner1 & "', '" & Planner2 & "', '" & Me.QC & "', '" & Me.QCBackup & "', '01/01/1900', '" & Me.chkFabShop.Checked & "', 'False', '', '01/01/1900', '', '" & u.FTM(Me.txtEndItemType.Text) & "', 'False', '1/1/1900', '', 'Normal')")
        u.ExecuteSQL(SqlConnection2, "INSERT INTO tblEARR (EARRNumber,EARRStatus,EARRType,SerialNumber,WorkOrder,ProgramName,Request,IncorpRedLineYes,IncorpRedLineNo,DRawingReqForConformityYes,DrawingReqForConformityNo,EARRResponseDate,OriginatorName,OriginatorDate,OriginatorSignedOff,ReplyInstructions,EffectivityAll,EffectivityOther,EffectivityOtherText,DeviationMinor,DeviationMajor,AdditionalEngReqNoAction,AdditionalEngReqUpdate,ACFTInterface,Manufacturability,ProductImprovement,DWGError,DesignError,LiaisonManagerName,LiaisonManagerNameBackup,LiaisonManagerSignOffDate,EngineeringManagerName,EngineeringManagerNameBackup,EngineeringManagerSignOffDate,Planner1,Planner2, QCName, QCNameBackup, QCSignOff, FabShop, ProductionError, QCNotes, PlannerSignOffDate, PlannerNotes, EndItemType, DeviationNA, EstCompletionDate, Comments, Priority, IssueType) Values ('" & Me.txtEARRNumber.Text & "', 'Pending', '" & u.FTM(Me.cboEARRType.Text) & "', '" & Me.txtSerialNumber.Text & "', '" & Me.txtWorkOrder.Text & "', '" & u.FTM(Me.cboProgramName.Text) & "', '" & u.FTM(Me.txtRequest.Text) & "', '" & chkIncorpRedLineYes.CheckState & "', '" & Me.chkIncorpRedLineNo.CheckState & "','" & Me.chkDrawingReqForConformityYes.CheckState & "', '" & Me.chkDrawingReqForConformityNo.CheckState & "', '01/01/1900', '" & u.FTM(txtOriginatorName.Text) & "', '" & Me.dtOriginatorDate.Value & "', '" & Now & "', '',0,0,'', 0,0,0,0,0,0,0,0,0,'" & LiaisonEngineer & "', '" & LiaisonEngineerBackup & "', '01/01/1900', '" & EngineerManager & "', '" & EngineerManagerBackup & "', '01/01/1900', '" & Planner1 & "', '" & Planner2 & "', '" & Me.QC & "', '" & Me.QCBackup & "', '01/01/1900', '" & Me.chkFabShop.Checked & "', 'False', '', '01/01/1900', '', '" & u.FTM(Me.txtEndItemType.Text) & "', 'False', '1/1/1900', '', 'Normal', 'EQN')")
        MsgBox("EARR has been submitted!")

        'Send Email to planners and eng liaisons
        u.SendEmail("system@fieldaero.com", Planner1 + "; " + Planner2 + "; " + LiaisonEngineer + "; " + LiaisonEngineerBackup, "A new EARR has been submitted for program:  " + Me.cboProgramName.Text, "Please respond to the EARR.  The EARR Number is:  " + Me.txtEARRNumber.Text)

        'Add the EARR number to the document numbers that were linked to it
        u.ExecuteSQL(SqlConnection2, "UPDATE tblDrawingsOfEARR Set Earr = '" & txtEARRNumber.Text & "', IssueNumber = '" & txtEARRNumber.Text & "', Status='Pending', OriginatorDate='" & dtOriginatorDate.Value & "', OriginatorName='" & u.FTM(txtOriginatorName.Text) & "', DateClosed='01/01/1900', Request='" & u.FTM(Me.txtRequest.Text) & "', IssueType='" & u.FTM(Me.cboEARRType.Text) & "', ProgramName='" & u.FTM(Me.cboProgramName.Text) & "', Comments = '" & u.FTM(Me.txtComments.Text) & "', Type = 'EARR' WHERE Earr = '' Or Earr Is Null")


        'Add the document numbers to the main tblEARR
        AddDrawingNumbers()


        Dim frmEARRGrid As New frmEARRGrid
        frmEARRGrid.Show()
        Me.Close()
    End Sub

    Public Function AddDrawingNumbers()

        'Add the document numbers to the main tblEARR
        'Get document numbers
        da = New SqlClient.SqlDataAdapter("Select DrawNum,Rev From tblDrawingsOfEARR Where Earr = '" & txtEARRNumber.Text & "'", SqlConnection2)
        da.Fill(ds, "DrawNumsAdded")
        Dim p As Integer = 0
        Dim DocNumsString As String = ""

        While p <= ds.Tables("DrawNumsAdded").Rows.Count - 1
            If DocNumsString = "" Then
                DocNumsString = ds.Tables("DrawNumsAdded").Rows(p).Item("DrawNum") & " " & ds.Tables("DrawNumsAdded").Rows(p).Item("Rev")
            Else
                DocNumsString = DocNumsString & ", " & ds.Tables("DrawNumsAdded").Rows(p).Item("DrawNum") & " " & ds.Tables("DrawNumsAdded").Rows(p).Item("Rev")
            End If

            p = p + 1
        End While

        ds.Tables("DrawNumsAdded").Clear()
        ds.Tables("DrawNumsAdded").Dispose()

        'Update the drawing number field with above created string
        u.ExecuteSQL(SqlConnection2, "UPDATE tblEARR SET DrawingNumber = '" & DocNumsString & "' Where EARRNumber = '" & txtEARRNumber.Text & "'")

    End Function

    Private Sub NewEARR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection2.ConnectionString = sqlString1

        Me.txtEARRNumber.Text = "Pending EARR Number"
        txtOriginatorName.Text = EARRORIGNAME
        dtOriginatorDate.Value = Now
        dtEARRResponseDate.Value = "01/01/1900"

        MsgBox("IMPORTANT:  You must enter a valid work order and step in the format of wonumber.step in the work order number field.  If the EARR is for a work order with no step, enter the workordernumber.0")

        ''Load Revisions Information
        'da = New SqlClient.SqlDataAdapter("Select * from tblRevisionsLookup Order By Sort Asc", SqlConnection2)
        'da.Fill(ds, "Revisions")

        'Dim i As Integer = 0
        'While i <= ds.Tables("Revisions").Rows.Count - 1
        '    Me.txtDrawingRevision.Items.Add(ds.Tables("Revisions").Rows(i).Item("Rev"))
        '    i = i + 1
        'End While
    End Sub

    Public Function GetDrawingNumbers()

        SqlConnection2.ConnectionString = sqlString1

        'Clear previous data from DrawingNumber grid if data already existed from before
        If IsNothing(ds.Tables("DrawNums")) Then
            'nothing
        Else
            ds.Tables("DrawNums").Clear()
            ds.Tables("DrawNums").Dispose()
        End If


        Try
            'Populate DrawingNumber grid
            da = New SqlClient.SqlDataAdapter("Select * From tblDrawingsOfEARR Where Earr Is Null Or Earr = ''", SqlConnection2)
            da.Fill(ds, "DrawNums")
            If ds.Tables("DrawNums").Rows.Count > 0 Then
                bsDrawingsOfEARR.DataSource = ds.Tables("DrawNums")
                GridControl1.DataSource = bsDrawingsOfEARR
                DrawNumAdded = "Yes"
            Else
                DrawNumAdded = ""
            End If


            'Dim dsView As New DataView()
            'dsView = ds.Tables(0).DefaultView
            'bs.DataSource = dsView
            'GridControl1.DataSource = bs

            'GridView11.Columns("RecordID").Visible = False
            'GridView1.Columns("PaymentNum").OptionsColumn.AllowEdit = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
        End Try
    End Function

    Private Sub btnAddDrawNum_Click(sender As Object, e As EventArgs) Handles btnAddDrawNum.Click

        If txtDrawNum.Text = "" Then
            MsgBox("Select a drawing number from the Browse button first")
            Exit Sub
        End If

        u.ExecuteSQL(SqlConnection2, "Insert into tblDrawingsOfEARR (DrawNum,Rev,Earr,IssueNumber,Response,DrawNumRev,DrawTitle) Values ('" & DocBrowseDrawNum & "', '" & RevBrowseDrawNum & "','','','', '" & DocBrowseDrawNum & "' + ' ' + '" & RevBrowseDrawNum & "', '" & u.FTM(TitleBrowseDrawNum) & "')")

        GetDrawingNumbers()

        txtDrawNum.Text = ""
        DocBrowseDrawNum = ""
        RevBrowseDrawNum = ""
        TitleBrowseDrawNum = ""
    End Sub

    Private Sub btnBrowseDrawNum_Click(sender As Object, e As EventArgs) Handles btnBrowseDrawNum.Click
        Dim frmEARRDrawingNumbers As New frmEARRDrawingNumbers
        frmEARRDrawingNumbers.ShowDialog()

        txtDrawNum.Text = DocBrowseDrawNum
    End Sub

    Private Sub btnRemoveDrawNum_Click(sender As Object, e As EventArgs) Handles btnRemoveDrawNum.Click

        Dim DrawNumToDelete As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DrawNum")
        Dim RevToDelete As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Rev")
        Dim RecIDToDelete As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecordID")

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove the selected drawing number?", "Title", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            If DrawNumToDelete <> "" Then
                u.ExecuteSQL(SqlConnection2, "Delete From tblDrawingsOfEARR Where DrawNum = '" & DrawNumToDelete & "' And Rev = '" & RevToDelete & "' And RecordID = '" & RecIDToDelete & "'")
                MsgBox("Drawing number deleted.")
            End If

            GetDrawingNumbers()
        End If

    End Sub

    Private Sub NewEARR_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'If drawing numbers were created but never assigned then delete them
        u.ExecuteSQL(SqlConnection2, "Delete From tblDrawingsOfEARR Where Earr Is Null Or Earr = ''")
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim frmEARRGrid As New frmEARRGrid
        frmEARRGrid.Show()
        Me.Close()
    End Sub

    Private Sub chkFabShop_CheckStateChanged(sender As Object, e As EventArgs) Handles chkFabShop.CheckStateChanged
        If Me.chkFabShop.Checked = True Then
            Me.txtWorkOrder.Text = "FAB.0"
        Else

            Me.txtWorkOrder.Text = ""
            MsgBox("You need to enter the work order.step number in the work order field.")

        End If
    End Sub

End Class