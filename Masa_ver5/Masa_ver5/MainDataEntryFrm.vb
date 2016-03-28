Public Class MainDataEntryForm

#Const Still_debugging = True   'set this to "True" while working on the program, set to "False" when deploying


    Private Sub MainDataEntryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewFlights_Glider5.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter4.Fill(Me.NewFlights_Glider5.Aircraft)
        'TODO: This line of code loads data into the 'NewFlights_Glider4.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter3.Fill(Me.NewFlights_Glider4.Aircraft)
        'TODO: This line of code loads data into the 'NewFlights_Glider3.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter2.Fill(Me.NewFlights_Glider3.Aircraft)
        'TODO: This line of code loads data into the 'OD_AOD_TowPlane3.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter1.Fill(Me.OD_AOD_TowPlane3.Aircraft)
        'TODO: This line of code loads data into the 'MASA_allDataSet2.Flights' table. You can move, or remove it, as needed.
        Me.MASA_allDataSet_2_FlightsTableAdapter.Fill(Me.MASA_allDataSet2.Flights)
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

#If still_debugging = True Then
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        ' debug item: this just does a quick debug.print with the index of the current selected tab
        Dim TabIndexValue As Integer
        TabIndexValue = TabControl1.SelectedIndex
        Debug.WriteLine("You are in the TabControl.SelectedIndexChanged event. TabIndex:  " & TabIndexValue)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SaveFlightButton.Click
        'debug item:  TempTextBox displays the SELECTED item from ComboBox5, just to make sure
        'I can grab that value and display it.  OK to delete when done.
        'the below lines are the .update technique as outlined by MicroSoft
        '

        Dim FlightDuration As Long
        FlightDuration = DateDiff(DateInterval.Second, TakeOffTimePicker.Value, LandingTimePicker.Value)
        'FlightDuration = DirectCast(FlightDuration, Int32)
        Debug.WriteLine("Flightduration:  " & FlightDuration)  'print the calculated duration 
        Debug.WriteLine("OK, now starting the TableAdapter.Insert:")

        'MASA_allDataSet_2_FlightsTableAdapter.Insert(
        '            GliderPilotNameComboBox.SelectedIndex,
        '            Glider_nameComboBox.SelectedIndex,
        '            InstructorNameComboBox.SelectedIndex,
        '            PasengerNameComboBox.SelectedIndex,
        '            ODNameComboBox1.SelectedIndex,
        '            ODNameComboBox2.SelectedIndex,
        '            ODNameComboBox3.SelectedIndex,
        '            AODNameComboBox1.SelectedIndex,
        '            AODNameComboBox2.SelectedIndex,
        '            TowPilotNameComboBox5.SelectedIndex,
        '            TowPilotNameComboBox5.SelectedIndex,
        '            TowPilotNameComboBox5.SelectedIndex,
        '            Aircraft_nameComboBox.SelectedIndex,
        '            Aircraft_nameComboBox.SelectedIndex,
        '            DateTimePicker1.Value,
        '            FlightDuration,
        '            FlightDuration,
        '            FlightDuration,
        '            FlightDuration,
        '            TowAltitude.Text,
        '            RopeBreakCheckBox.Checked,
        '            Airport_nameComboBox.SelectedIndex,
        '            FlightDuration,
        '            FirstNameOnCheckComboBox.SelectedIndex,
        '            SplitCostCheckBox.Checked,
        '            PercentOnFirstCheck.Text,
        '            SecondCheckNameComboBox.SelectedIndex,
        '            PenaltyRadioButton.Checked,
        '            CostThisFlightTextBox.Text
        ')

        Dim newFlightRow As MASA_allDataSet2.FlightsRow
        newFlightRow = Me.MASA_allDataSet2.Flights.NewFlightsRow()
        ' load the new data into each field in the new record
        'Debug.Print("GliderPilotNameComboBox.SelectedIndex:  " & GliderPilotNameComboBox.SelectedIndex)
        'Debug.Print("GliderNameComboBox2.SelectedIndex: >>  " & GliderNameComboBox2.SelectedIndex)



        newFlightRow.TowPilot1 = TowPilotNameComboBox5.SelectedIndex
        newFlightRow.Glider_Pilot_Name = GliderPilotNameComboBox.SelectedIndex
        'newFlightRow.First_name_on_invoice = FirstNameOnCheckComboBox.SelectedIndex
        'newFlightRow.TowPlane1 = Aircraft_nameComboBox.SelectedIndex
        'newFlightRow.Instructor_name = InstructorNameComboBox.SelectedIndex
        'newFlightRow.Split_cost = SplitCostCheckBox.CheckState
        'newFlightRow.Passenger_name = PasengerNameComboBox.SelectedIndex
        'newFlightRow.Percent_1st_check = PercentOnFirstCheck.Text
        'newFlightRow.Glider = GliderNameComboBox2.SelectedIndex
        'newFlightRow.Second_name_on_invoice = SecondCheckNameComboBox.SelectedIndex

        'Debug.WriteLine("Value of TakeOfFTimePicker:   " & TakeOffTimePicker.Value.ToLongTimeString)
        'newFlightRow.Glider_takeoff_time = TakeOffTimePicker.Value.ToShortTimeString

        'newFlightRow.Glider_landing_time = LandingTimePicker.Value

        'newFlightRow.Altitude_towed = TowAltitude.Text
        'newFlightRow.Rope_break = RopeBreakCheckBox.Checked
        'newFlightRow.Penalty_charge = PenaltyRadioButton.Checked
        'newFlightRow.Cost_this_flight = CostThisFlightTextBox.Text
        'newFlightRow.OD1 = ODNameComboBox1.SelectedIndex
        'newFlightRow.OD2 = ODNameComboBox2.SelectedIndex
        'newFlightRow.OD3 = ODNameComboBox3.SelectedIndex
        'newFlightRow.AOD1 = AODNameComboBox1.SelectedIndex
        'newFlightRow.AOD2 = AODNameComboBox2.SelectedIndex
        'newFlightRow.TowPilot1 = TowPilotNameComboBox5.SelectedIndex



        'add new the row that as all the user-entered values into the table
        Try
            Me.MASA_allDataSet2.Flights.Rows.Add(newFlightRow)
        Catch ex As Exception
            MessageBox.Show("Add failed")
        End Try

        'save the new row to the DB
        Try
            Me.MASA_allDataSet_2_FlightsTableAdapter.Update(Me.MASA_allDataSet2.Flights)
        Catch ex As Exception
            MessageBox.Show("Update failed  " & newFlightRow.Glider_Pilot_Name)
        End Try

        Debug.WriteLine("Now FINISHED the DB .add and the DB .update")

    End Sub


    Private Sub ClearFormButton_Click(sender As Object, e As EventArgs) Handles ClearFormButton.Click
        'Reset all the selected comboBoxes back to "blank"

        ''''''''''''''''''''''''''''''  >>>>start of "this works" section.
        ''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''  This next commented-out code WORKS!!
        ''''''''''''''''''''''''''''''''''  but it does NOT limit to the current tab, instead it clears EVERY 
        ''''''''''''''''''''''''''''''''''  combobox on EVERY tab.  I'm saving it for possible future use, don't delete.
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
        '(I wasn't able to find a *working* recursive function that could be LIMITED to *just* the current tabIndex.)
        '(It ended up clearing the entire form, all of the tabs and couldn't be limited.)

        TowPilotNameComboBox5.SelectedIndex = 0
        GliderPilotNameComboBox.SelectedIndex = 0
        FirstNameOnCheckComboBox.SelectedIndex = 0
        Aircraft_nameComboBox.SelectedIndex = 0
        InstructorNameComboBox.SelectedIndex = 0
        SplitCostCheckBox.Checked = False
        PasengerNameComboBox.SelectedIndex = 0
        PercentOnFirstCheck.Text = vbNullChar
        GliderNameComboBox2.SelectedIndex = 0
        SecondCheckNameComboBox.SelectedIndex = 0
        FlightDurationTextBox.Text = vbNullChar
        TowAltitude.Text = vbNullChar
        PenaltyRadioButton.Checked = False
        RadioButton2.Checked = False
        CostThisFlightTextBox.Text = vbNullChar
        RopeBreakCheckBox.Checked = False
        TakeOffTimePicker.Value = Now

        Debug.WriteLine("Completed zeroing.")

        'debug item:  TempTextBox displays the SELECTED item from ComboBox5, just to make sure
        'I can grab that value and display it.  OK to delete when done.
        TempTextBox.Text = TowPilotNameComboBox5.SelectedIndex

    End Sub

    Private Sub SetTestValues_Click(sender As Object, e As EventArgs) Handles SetTestValues2.Click
        TowPilotNameComboBox5.SelectedIndex = 8
        GliderPilotNameComboBox.SelectedIndex = 2
        FirstNameOnCheckComboBox.SelectedIndex = 2
        Aircraft_nameComboBox.SelectedIndex = 3
        InstructorNameComboBox.SelectedIndex = 4
        SplitCostCheckBox.Checked = True
        PasengerNameComboBox.SelectedIndex = 5
        PercentOnFirstCheck.Text = "44"
        GliderNameComboBox2.SelectedIndex = 4
        SecondCheckNameComboBox.SelectedIndex = 7
        FlightDurationTextBox.Text = "1:20"
        TowAltitude.Text = "3000"
        PenaltyRadioButton.Checked = True
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
#End If  'end of conditional compilation for "debugging helper items"


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Change to the "second tab" when the user wants to enter Flight Data.
        TabControl1.SelectedIndex = 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Change to the "third tab" when the user is ready to print reports.
        TabControl1.SelectedIndex = 2

    End Sub

    Private Sub SaveToolStripButton_Click_1(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        'experimental save the data code
        'Start adding save-combobox-by-combobox code here.
        '

        Debug.WriteLine("ToolBar Save button was clicked.")


        'below .insert gives an error, I'm re-writing the code to try the .update technique instead, following the MicroSoft example fully.
        '        MASA_allDataSet_2_FlightsTableAdapter.Insert(
        '            GliderPilotNameComboBox.SelectedIndex,
        '            Glider_nameComboBox.SelectedIndex,
        '            InstructorNameComboBox.SelectedIndex,
        '            PasengerNameComboBox.SelectedIndex,
        '            ODNameComboBox1.SelectedIndex,
        '            ODNameComboBox2.SelectedIndex,
        '            ODNameComboBox3.SelectedIndex,
        '            AODNameComboBox1.SelectedIndex,
        '            AODNameComboBox2.SelectedIndex,
        '            TowPilotNameComboBox5.SelectedIndex,
        '            TowPilotNameComboBox5.SelectedIndex,
        '            TowPilotNameComboBox5.SelectedIndex,
        '            Aircraft_nameComboBox.SelectedIndex,
        '            Aircraft_nameComboBox.SelectedIndex,
        '            DateTimePicker1.Value,
        '            FlightDuration,
        '            FlightDuration,
        '            FlightDuration,
        '            FlightDuration,
        '            TowAltitude.Text,
        '            RopeBreakCheckBox.Checked,
        '            Airport_nameComboBox.SelectedIndex,
        '            FlightDuration,
        '            FirstNameOnCheckComboBox.SelectedIndex,
        '            SplitCostCheckBox.Checked,
        '            PercentOnFirstCheck.Text,
        '            SecondCheckNameComboBox.SelectedIndex,
        '            PenaltyRadioButton.Checked,
        '            CostThisFlightTextBox.Text
        ')
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        'Me.Validate()
        ' Me.OD_AOD_OD1MembersBindingSource.EndEdit()
        ' Me.OD_AOD_OD1TableAdapterManager.UpdateAll(Me.OD_AOD_OD1)


        'Me.MASA_allDataSet_2_FlightsBindingSource.EndEdit()
        'Me.MASA_allDataSet_2_TableAdapterManager.UpdateAll(Me.MASA_allDataSet2)
        'MASA_allDataSet_2_FlightsTableAdapter.Update(MASA_allDataSet2.Flights)

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
