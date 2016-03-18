Public Class MainDataEntryForm



    Private Sub MainDataEntryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MASA_allDataSet.Flights' table. You can move, or remove it, as needed.
        Me.MASA_allDataSetFlightsTableAdapter.Fill(Me.MASA_allDataSet.Flights)
        'TODO: This line of code loads data into the 'NewFlights_Passenger.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter4.Fill(Me.NewFlights_Passenger.Members)
        'TODO: This line of code loads data into the 'NewFlights_PutSecondNameOnCheck.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter3.Fill(Me.NewFlights_PutSecondNameOnCheck.Members)
        'TODO: This line of code loads data into the 'NewFlights_PutOnCheck.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter2.Fill(Me.NewFlights_PutOnCheck.Members)
        'TODO: This line of code loads data into the 'NewFlights_Glider.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter.Fill(Me.NewFlights_Glider.Aircraft)
        'TODO: This line of code loads data into the 'NewFlights_Instructor.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter1.Fill(Me.NewFlights_Instructor.Members)
        'TODO: This line of code loads data into the 'NewFlights_GliderPilot.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.NewFlights_GliderPilot.Members)
        'TODO: This line of code loads data into the 'Enter_New_Instructor.Flights' table. You can move, or remove it, as needed.
        Me.Flights_Enter_New_InstructorFlightsTableAdapter.Fill(Me.Flights_Enter_New_Instructor.Flights)
        'TODO: This line of code loads data into the 'Enter_New_Glider_pilot.Flights' table. You can move, or remove it, as needed.
        Me.Flights_Enter_New_Glider_pilotFlightsTableAdapter.Fill(Me.Flights_Enter_New_Glider_pilot.Flights)
        'TODO: This line of code loads data into the 'OD_AOD_AirportName.Airport' table. You can move, or remove it, as needed.
        Me.OD_AOD_AirportNameAirportTableAdapter.Fill(Me.OD_AOD_AirportName.Airport)
        'TODO: This line of code loads data into the 'OD_AOD_TowPlane2.Airport' table. You can move, or remove it, as needed.
        Me.Not_usedOD_AOD_AirportTableAdapter.Fill(Me.OD_AOD_TowPlane2.Airport)
        'TODO: This line of code loads data into the 'OD_AOD_TowPlane2.Aircraft' table. You can move, or remove it, as needed.
        Me.OD_AOD_TowPlane2AircraftTableAdapter.Fill(Me.OD_AOD_TowPlane2.Aircraft)
        'TODO: This line of code loads data into the 'OD_AOD_TowPlane1.Aircraft' table. You can move, or remove it, as needed.
        Me.OD_AOD_TowPlane1AircraftTableAdapter.Fill(Me.OD_AOD_TowPlane1.Aircraft)
        'TODO: This line of code loads data into the 'OD_AOD_Tow3.Members' table. You can move, or remove it, as needed.
        Me.OD_AOD_Tow3MembersTableAdapter.Fill(Me.OD_AOD_Tow3.Members)
        'TODO: This line of code loads data into the 'OD_AOD_Tow2.Members' table. You can move, or remove it, as needed.
        Me.OD_AOD_Tow2MembersTableAdapter.Fill(Me.OD_AOD_Tow2.Members)
        'TODO: This line of code loads data into the 'OD_AOD_Tow1.Members' table. You can move, or remove it, as needed.
        Me.OD_AOD_Tow1MembersTableAdapter.Fill(Me.OD_AOD_Tow1.Members)
        'TODO: This line of code loads data into the 'OD_AOD_AOD2.Members' table. You can move, or remove it, as needed.
        Me.OD_AOD_AOD2MembersTableAdapter.Fill(Me.OD_AOD_AOD2.Members)
        'TODO: This line of code loads data into the 'OD_AOD_AOD1.Members' table. You can move, or remove it, as needed.
        Me.OD_AOD_AOD1MembersTableAdapter.Fill(Me.OD_AOD_AOD1.Members)
        'TODO: This line of code loads data into the 'OD_AOD_OD3.Members' table. You can move, or remove it, as needed.
        Me.OD_AOD_OD3MembersTableAdapter.Fill(Me.OD_AOD_OD3.Members)
        'TODO: This line of code loads data into the 'OD_AOD_OD2.Members' table. You can move, or remove it, as needed.
        Me.OD_AOD_OD2MembersTableAdapter.Fill(Me.OD_AOD_OD2.Members)
        'TODO: This line of code loads data into the 'OD_AOD_OD1.Members' table. You can move, or remove it, as needed.
        Me.OD_AOD_OD1MembersTableAdapter.Fill(Me.OD_AOD_OD1.Members)


        If Airport_nameComboBox.Items.Count > 0 Then     'set the airport displayed to be the "first one in the list"
            Airport_nameComboBox.SelectedIndex = 1
        End If

        ' Set the Format type and the CustomFormat string for both time pickers
        TakeOffTimePicker.Format = DateTimePickerFormat.Custom
        TakeOffTimePicker.CustomFormat = "HH:mm"
        LandingTimePicker.Format = DateTimePickerFormat.Custom
        LandingTimePicker.CustomFormat = "HH:mm"

    End Sub


    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OD_AOD_OD1MembersBindingSource.EndEdit()
        Me.OD_AOD_OD1TableAdapterManager.UpdateAll(Me.OD_AOD_OD1)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        ' debug item: this just does a quick debug.print with the index of the current selected tab
        Dim TabIndexValue As Integer
        TabIndexValue = TabControl1.SelectedIndex
        Debug.Print("You are in the TabControl.SelectedIndexChanged event. TabIndex:  " & TabIndexValue)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SaveFlightButton.Click
        'debug item:  TempTextBox displays the SELECTED item from ComboBox5, just to make sure
        'I can grab that value and display it.  OK to delete when done.
        TempTextBox.Text = TowPilotNameComboBox5.SelectedValue
    End Sub


    Private Sub ClearFormButton_Click(sender As Object, e As EventArgs) Handles ClearFormButton.Click
        'Reset all the selected comboBoxes back to "blank"
        'TowPilotNameComboBox5.SelectedIndex = -1
        'SetContentsBackToNothing()
        ''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''  This WORKS!!
        ''''''''''''''''''''''''''''''''''  Need to verify it will grab ALL controls
        ''''''''''''''''''''''''''''''''''  Need also to check for OTHER TYPES of controls and reset them to zero
        '''''
        '''''Dim ctl As Control = Me.GetNextControl(Me, True) 'Get the first control in the tab order.
        ''''''Dim ctl As Control = Me.GetNextControl(ActiveForm, True) 'Get the first control in the tab order.

        '''''Debug.Write("Starting to zero out all the controls...       ")

        '''''Do Until ctl Is Nothing
        '''''    Do some stuff here, Use ctl as the object name.
        '''''    If (TypeOf ctl Is ComboBox) Then
        '''''            DirectCast(ctl, ComboBox).SelectedIndex = -1  'this sets the combobox selected item to "nothing" 
        '''''        End If
        '''''        ctl = Me.GetNextControl(ctl, True) 'Get the next control in the tab order.
        '''''        ctl = Me.GetNextControl(ActiveForm, True) 'Get the next control in the tab order.

        '''''    Loop
        '''''   >>>END of "this works" section.

        '''''''''''''''''''''''''''''

        'To reset the form you need to list *every* box or object to be reset, and reset them individually.
        '(I wasn't able to find the recursive function that could be LIMITED to just the current tabIndex.)
        '(It ended up clearing the entire form, all of the tabs and couldn't be limtied.)

        TowPilotNameComboBox5.SelectedValue = -1
        GliderPilotNameComboBox.SelectedValue = -1
        FirstNameOnCheckComboBox.SelectedValue = -1
        Aircraft_nameComboBox.SelectedValue = -1
        InstructorNameComboBox.SelectedValue = -1
        SplitCostCheckBox.Checked = False
        PasengerNameComboBox.SelectedValue = -1
        PercentOnFirstCheck.Text = ""
        Aircraft_nameComboBox2.SelectedValue = -1
        SecondCheckNameComboBox.SelectedValue = -1
        FlightDurationTextBox.Text = ""
        TowAltitude.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        CostThisFlightTextBox.Text = ""
        RopeBreakCheckBox.Checked = False
        TakeOffTimePicker.Value = Now

        Debug.WriteLine("Completed zeroing.")

            'debug item:  TempTextBox displays the SELECTED item from ComboBox5, just to make sure
            'I can grab that value and display it.  OK to delete when done.
            TempTextBox.Text = TowPilotNameComboBox5.SelectedValue

    End Sub

    Private Sub SetTestValues_Click(sender As Object, e As EventArgs) Handles SetTestValues2.Click
        TowPilotNameComboBox5.SelectedIndex = 8
        GliderPilotNameComboBox.SelectedIndex = 1
        FirstNameOnCheckComboBox.SelectedIndex = 2
        Aircraft_nameComboBox.SelectedIndex = 3
        InstructorNameComboBox.SelectedIndex = 4
        SplitCostCheckBox.Checked = True
        PasengerNameComboBox.SelectedIndex = 5
        PercentOnFirstCheck.Text = "44"
        Aircraft_nameComboBox2.SelectedIndex = 6
        SecondCheckNameComboBox.SelectedIndex = 7
        FlightDurationTextBox.Text = "1:20"
        TowAltitude.Text = "3000"
        RadioButton1.Checked = True
        RadioButton2.Checked = False
        CostThisFlightTextBox.Text = "120.00"
        RopeBreakCheckBox.Checked = True

        Debug.WriteLine("Completed setting test values.")
    End Sub


    Private Sub SetTestValues_Click_1(sender As Object, e As EventArgs) Handles SetTestValues.Click
        ODNameComboBox1.SelectedIndex = 5
        ODNameComboBox2.SelectedIndex = 6
        ODNameComboBox3.SelectedIndex = 7
        AODNameComboBox1.SelectedIndex = 8
        AODNameComboBox2.SelectedIndex = 9
        Airport_nameComboBox.SelectedIndex = 2

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        'experimental save the data code
        MASA_allDataSetFlightsTableAdapter.Update(MASA_allDataSet.Flights)

    End Sub




    ''Below is one way to iterate through all controls on page...
    'Private Sub SetContentsBackToNothing()
    '    Dim cControl As Control

    '    For Each cControl In Controls
    '        If (TypeOf cControl Is ComboBox) Then
    '            DirectCast(cControl, ComboBox).SelectedIndex = -1
    '            cControl.Text = -1
    '            ' DirectCast(cControl, ComboBox).SelectedIndex = -1
    '        End If
    '    Next cControl
    'End Sub



    ''below is a second way to iterate through all controls on page...
    'Private Sub resetAllItemsOnTab(ByVal control As Control)
    '    For Each item As Control In control.Controls
    '        If TypeOf item Is TextBox Then
    '            DirectCast(item, TextBox).ReadOnly = True
    '        Else
    '            ' recurse and make eventual TextBoxes 
    '            ' on this control readonly
    '            resetAllItemsOnTab(item)
    '        End If
    '    Next
    'End Sub

    ''another example: 
    'Private Sub anotherway()
    '    For Each tp As TabPage In TabControl1.TabPages
    '        For Each ctl As Control In tp.Controls
    '            If TypeOf ctl Is DataGridView Then
    '                Dim dgv As DataGridView = DirectCast(ctl, DataGridView)
    '                'do some stuff here...
    '                'dgv.Columns(0).Width = 35
    '                'dgv.Columns(1).Width = controlWidth - 70
    '                'dgv.Columns(2).Width = 35
    '            End If
    '        Next
    '    Next
    'End Sub


    ''yet another example
    'Private Sub GetControls()
    '    For Each GroupBoxCntrol As Control In Me.Controls
    '        If TypeOf GroupBoxCntrol Is GroupBox Then
    '            For Each cntrl As Control In GroupBoxCntrol.Controls
    '                'do somethin here

    '            Next
    '        End If

    '    Next
    'End Sub

    ''more-looks promising
    'Private Sub zeroOut()
    '    Dim ctl As Control = Me.GetNextControl(Me, True) 'Get the first control in the tab order.

    '    Do Until ctl Is Nothing

    '        'do some stuff here, Use ctl here.

    '        ctl = Me.GetNextControl(ctl, True) 'Get the next control in the tab order.
    '    Loop

    'End Sub


End Class
