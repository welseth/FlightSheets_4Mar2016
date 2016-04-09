Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RatesAndFees2.RatesAndFees' table. You can move, or remove it, as needed.
        Me.RatesAndFeesTableAdapter1.Fill(Me.RatesAndFees2.RatesAndFees)
        'TODO: This line of code loads data into the 'RatesAndFees._RatesAndFees' table. You can move, or remove it, as needed.
        Me.RatesAndFeesTableAdapter.Fill(Me.RatesAndFees._RatesAndFees)
        'TODO: This line of code loads data into the 'MASA_all_1Apr2016DataSet.Flights' table. You can move, or remove it, as needed.
        Me.FlightsTableAdapter.Fill(Me.MASA_all_1Apr2016DataSet.Flights)
        'TODO: This line of code loads data into the 'Enter_SecondName2.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter22.Fill(Me.Enter_SecondName2.Members)
        'TODO: This line of code loads data into the 'Enter_SecondName1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter21.Fill(Me.Enter_SecondName1.Members)
        'TODO: This line of code loads data into the 'Enter_Glider2.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter3.Fill(Me.Enter_Glider2.Aircraft)
        'TODO: This line of code loads data into the 'Enter_Glider1.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter2.Fill(Me.Enter_Glider1.Aircraft)
        'TODO: This line of code loads data into the 'Enter_Passenger2.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter20.Fill(Me.Enter_Passenger2.Members)
        'TODO: This line of code loads data into the 'Enter_Passenger1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter19.Fill(Me.Enter_Passenger1.Members)
        'TODO: This line of code loads data into the 'Enter_Instructor2.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter18.Fill(Me.Enter_Instructor2.Members)
        'TODO: This line of code loads data into the 'Enter_Instructor1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter17.Fill(Me.Enter_Instructor1.Members)
        'TODO: This line of code loads data into the 'Enter_Tow_Plane2.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter1.Fill(Me.Enter_Tow_Plane2.Aircraft)
        'TODO: This line of code loads data into the 'Enter_Tow_Plane1.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter.Fill(Me.Enter_Tow_Plane1.Aircraft)
        'TODO: This line of code loads data into the 'Enter_FirstName2.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter16.Fill(Me.Enter_FirstName2.Members)
        'TODO: This line of code loads data into the 'Enter_FirstName1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter15.Fill(Me.Enter_FirstName1.Members)
        'TODO: This line of code loads data into the 'Enter_Glider_Pilot2.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter14.Fill(Me.Enter_Glider_Pilot2.Members)
        'TODO: This line of code loads data into the 'Enter_Glider_Pilot1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter13.Fill(Me.Enter_Glider_Pilot1.Members)
        'TODO: This line of code loads data into the 'Enter_Tow_Pilot1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter12.Fill(Me.Enter_Tow_Pilot1.Members)
        'TODO: This line of code loads data into the 'Enter_Tow_Pilot2.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter11.Fill(Me.Enter_Tow_Pilot2.Members)
        'TODO: This line of code loads data into the 'OD_AOD_Airport2.Airport' table. You can move, or remove it, as needed.
        Me.AirportTableAdapter1.Fill(Me.OD_AOD_Airport2.Airport)
        'TODO: This line of code loads data into the 'OD_AOD_Airport1.Airport' table. You can move, or remove it, as needed.
        Me.AirportTableAdapter.Fill(Me.OD_AOD_Airport1.Airport)
        'TODO: This line of code loads data into the 'OD_AOD_AOD4.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter10.Fill(Me.OD_AOD_AOD4.Members)
        'TODO: This line of code loads data into the 'OD_AOD_AOD3.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter9.Fill(Me.OD_AOD_AOD3.Members)
        'TODO: This line of code loads data into the 'OD_AOD_AOD1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter8.Fill(Me.OD_AOD_AOD1.Members)
        'TODO: This line of code loads data into the 'OD_AOD_AOD2.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter7.Fill(Me.OD_AOD_AOD2.Members)
        'TODO: This line of code loads data into the 'OD_AOD_OD6.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter6.Fill(Me.OD_AOD_OD6.Members)
        'TODO: This line of code loads data into the 'OD_AOD_OD5.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter5.Fill(Me.OD_AOD_OD5.Members)
        'TODO: This line of code loads data into the 'OD_AOD_OD4.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter4.Fill(Me.OD_AOD_OD4.Members)
        'TODO: This line of code loads data into the 'OD_AOD_OD3.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter3.Fill(Me.OD_AOD_OD3.Members)
        'TODO: This line of code loads data into the 'OD_AOD_OD2.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter2.Fill(Me.OD_AOD_OD2.Members)
        'TODO: This line of code loads data into the 'MASA_all_1Apr2016DataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter1.Fill(Me.MASA_all_1Apr2016DataSet.Members)
        'TODO: This line of code loads data into the 'OD_AOD_OD1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.OD_AOD_OD1.Members)

        'set the airport displayed to be the "first one in the list" when form loads first time.
        If OD_AOD_AirportName_Combobox.Items.Count > 0 Then
            OD_AOD_AirportName_Combobox.SelectedIndex = 1
        End If

        ' Set the Format type and the CustomFormat string for both time pickers when form loads first time.
        TakeOff_DateTimePicker.Format = DateTimePickerFormat.Custom
        TakeOff_DateTimePicker.CustomFormat = "HH:mm"
        Landing_DateTimePicker.Format = DateTimePickerFormat.Custom
        Landing_DateTimePicker.CustomFormat = "HH:mm"
        TakeOff_DateTimePicker.Value = Now
        Landing_DateTimePicker.Value = Now
        Todays_Date_DateTimePicker.Value = Now
        'Turn "off" all penalty-related boxes, checks, and visibility.
        Penalty_Label.Visible = False
        Override_CheckBox.Checked = False
        Override_CheckBox.Enabled = False
        Penalty_CheckBox.Enabled = False
        Penalty_CheckBox.Checked = False
        SimulatedRopeBreak_Label.Visible = False
        ActualRopeBreak_Label.Visible = False
        MinAltTowWarningText.Visible = False
        MinAltitudeWarning.Visible = False

    End Sub


    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Save_Button.Click
        'Save the data that the user entered into the form for each flight.
        'create a newFlightRow to store the new flight info into.

        Dim newFlightRow As MASA_all_1Apr2016DataSet.FlightsRow
        newFlightRow = Me.MASA_all_1Apr2016DataSet.Flights.NewFlightsRow()
        'Debug.Print(vbCrLf, vbCrLf)
        Debug.Print("GliderPilotNameComboBox.SelectedIndex:  " & GliderPilotComboBox.SelectedIndex)
        Debug.Print("GliderNameComboBox2.SelectedIndex: >>  " & GliderComboBox.SelectedIndex)

        ' load the new data into each, and every, field in the new record
        If GliderPilotComboBox.SelectedIndex > 0 Then
            newFlightRow.Glider_Pilot_Name = GliderPilotComboBox.SelectedIndex
        Else
            MessageBox.Show("Must Select Glider Pilot")
            Exit Sub
        End If

        If GliderComboBox.SelectedIndex > 0 Then
            newFlightRow.Glider = GliderComboBox.SelectedIndex
        Else
            MessageBox.Show("Must Select The Glider That Was Used")
            Exit Sub
        End If

        If (OD_AOD_OD1_ComboBox.SelectedIndex > 0) Or (OD_AOD_OD2_ComboBox.SelectedIndex > 0) Or (OD_AOD_OD3_ComboBox.SelectedIndex > 0) Then
            If (OD_AOD_OD1_ComboBox.SelectedIndex > 0) Then newFlightRow.OD1 = OD_AOD_OD1_ComboBox.SelectedIndex
            If (OD_AOD_OD2_ComboBox.SelectedIndex > 0) Then newFlightRow.OD2 = OD_AOD_OD2_ComboBox.SelectedIndex
            If (OD_AOD_OD3_ComboBox.SelectedIndex > 0) Then newFlightRow.OD3 = OD_AOD_OD3_ComboBox.SelectedIndex
        Else
            MessageBox.Show("Must Select The OD For These Flight Operations")
            Exit Sub
        End If

        If TowPilotNameComboBox.SelectedIndex > 0 Then
            newFlightRow.TowPilot1 = TowPilotNameComboBox.SelectedIndex
            newFlightRow.TowPilot2 = 0 'towpilot2 not used, but assigning anyway
            newFlightRow.TowPilot3 = 0  'towpilot3 not used, but assigning anyway
        Else
            MessageBox.Show("Must Select The Tow Pilot For These Flight Operations")
            Exit Sub
        End If

        If TowPlaneComboBox.SelectedIndex > 0 Then
            newFlightRow.TowPlane1 = TowPlaneComboBox.SelectedIndex
            newFlightRow.TowPlane2 = 0  'towplane2 not used anywhere, but assigning anyway
        Else
            MessageBox.Show("Must Select The Tow Plane For These Flight Operations")
            Exit Sub
        End If

        If OD_AOD_AirportName_Combobox.SelectedIndex > 0 Then
            newFlightRow.Airport_name = OD_AOD_AirportName_Combobox.SelectedIndex
        Else
            MessageBox.Show("Must Select The Airport For These Flight Operations")
            Exit Sub
        End If

        newFlightRow.Instructor_name = InstructorComboBox.SelectedIndex
        newFlightRow.Passenger_name = PassengerComboBox.SelectedIndex
        newFlightRow.OD2 = OD_AOD_OD2_ComboBox.SelectedIndex 'optional, might not be selected for this day's operations
        newFlightRow.OD3 = OD_AOD_OD3_ComboBox.SelectedIndex 'optional, might not be selected for this day's operations
        newFlightRow.AOD1 = OD_AOD_AOD1_ComboBox.SelectedIndex 'optional, might not be selected for this day's operations
        newFlightRow.AOD2 = OD_AOD_AOD2_ComboBox.SelectedIndex 'optional, might not be selected for this day's operations

        Debug.Print("Todays DateTimePicker1: " & Todays_Date_DateTimePicker.Value)
        'MessageBox.Show("DateTimePicker:  " & DateTimePicker1.Value)  'get rid of this after debugging is complete 
        Debug.Print("Glider Takeoff:  " & TakeOff_DateTimePicker.Value)
        newFlightRow.Glider_takeoff_time = TakeOff_DateTimePicker.Value
        Debug.Print("Glider Landing:  " & Landing_DateTimePicker.Value)
        newFlightRow.Glider_landing_time = Landing_DateTimePicker.Value
        newFlightRow.Tow_takeoff_time = Nothing 'CType(Nothing, DateTime)   'TowTakeoffTime not used, just setting it to Nothing
        newFlightRow.Tow_landing_time = Nothing 'CType(Nothing, DateTime)   'TowLandingTime not used, just setting it to Nothing
        newFlightRow._Date = Todays_Date_DateTimePicker.Value  'saves in format DateTime 

        newFlightRow.Rope_break = Actual_Rope_Break_CheckBox.Checked
        newFlightRow.Flight_minutes_integer = DateDiff(DateInterval.Minute, TakeOff_DateTimePicker.Value, Landing_DateTimePicker.Value)

        If FirstNameComboBox.SelectedIndex > 0 Then   'MUST assign who will pay invoice
            newFlightRow.First_name_on_invoice = FirstNameComboBox.SelectedIndex
        Else
            MessageBox.Show("Must Select Who Will Pay")
            Exit Sub   'DUMP out of the "writing to the DB" because there is NO primary pilot, we don't want to save anything without a pilot.
        End If

        newFlightRow.Split_cost = SplitCost.Checked
        newFlightRow.Second_name_on_invoice = SecondNameComboBox.SelectedIndex
        newFlightRow.Penalty_charge = Penalty_CheckBox.Checked

        'Text boxes can't be blank, need to check that user didn't backspace and delete everything in the textbox.
        Try
            newFlightRow.Altitude_towed = TowAltitude.Text
        Catch ex As Exception
            newFlightRow.Altitude_towed = "0"
            Debug.Print("Reset AltTowed to 0")
        End Try
        Try
            newFlightRow.Percent_1st_check = PercentFirstCheck.Text
        Catch ex As Exception
            newFlightRow.Percent_1st_check = "0"
            Debug.Print("Reset Percent to 0")
        End Try
        Try
            newFlightRow.Cost_this_flight = Cost_This_Flight_TextBox.Text
        Catch ex As Exception
            newFlightRow.Cost_this_flight = "0"
            Debug.Print("Reset CostThisFlight to 0")
        End Try


        'ok, close everything and write to the DB file.
        Me.Validate()
        Me.MembersBindingSource.EndEdit()

        'add new the row that as all the user-entered values into the table
        Try
            Me.MASA_all_1Apr2016DataSet.Flights.Rows.Add(newFlightRow)
        Catch ex As Exception
            MessageBox.Show("Add failed" & vbCrLf & ex.Message)
        End Try

        'save the new row to the DB
        Try
            'Me.Validate()   'this line is probably NOT needed. 
            'Me.MASA_All_BindingSource.EndEdit()  'this line is probably NOT needed
            Me.MASA_All_Flights_TableAdapterManager.UpdateAll(Me.MASA_all_1Apr2016DataSet)

        Catch ex As Exception
            MessageBox.Show("Update failed  " & vbCrLf & ex.Message)
        End Try

        Debug.WriteLine("Now FINISHED the DB .add and the DB .update")

        'now zero-out the already-saved data so the user can enter new rows
        Button1_Click_3(sender, e)
        Override_CheckBox.Checked = False  'un-set the penalty override box after saving details of flight 
        Override_CheckBox.Enabled = False  'we'll enable or disable the override only if there is a penalty
        Penalty_CheckBox.Enabled = False   'we don't ever want user to actually change this button. We do it programmatically.
        Penalty_CheckBox.Checked = False

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles ClearFormButton.Click
        'zero out most of the boxes, leave Times, percent, and Altitude as-is for convenience of user.
        TowPilotNameComboBox.SelectedIndex = 0
        TowPlaneComboBox.SelectedIndex = 0
        GliderPilotComboBox.SelectedIndex = 0
        FirstNameComboBox.SelectedIndex = 0
        InstructorComboBox.SelectedIndex = 0
        PassengerComboBox.SelectedIndex = 0
        GliderComboBox.SelectedIndex = 0
        TowAltitude.Text = "3000"
        SecondNameComboBox.SelectedIndex = 0
        SplitCost.Checked = False
        PercentFirstCheck.Text = "100"
        FlightDurationTextBox.Text = ""
        Penalty_CheckBox.Checked = False
        Actual_Rope_Break_CheckBox.Checked = False
        Cost_This_Flight_TextBox.Text = ""
        Override_CheckBox.Checked = False
        Override_CheckBox.Enabled = False
        Penalty_CheckBox.Enabled = False
        Penalty_CheckBox.Checked = False

    End Sub


    ' debug item
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OD_AOD_OD1_ComboBox.SelectedIndexChanged
        Debug.Print("OD_AOD_OD1:  " & OD_AOD_OD1_ComboBox.Text)
        Debug.Print("OD_AOD_OD2:  " & OD_AOD_OD2_ComboBox.Text)
        Debug.Print("OD_AOD_OD3:  " & OD_AOD_OD3_ComboBox.Text)
        Debug.Print("AOD1:   " & OD_AOD_AOD1_ComboBox.Text)
        Debug.Print("AOD2:   " & OD_AOD_AOD2_ComboBox.Text)
        Debug.Print("Airport:   " & OD_AOD_AirportName_Combobox.Text & vbCrLf)

    End Sub
    ' debug item
    Private Sub OD_AOD_OD2_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OD_AOD_OD2_ComboBox.SelectedIndexChanged
        Debug.Print("OD_AOD_OD1:  " & OD_AOD_OD1_ComboBox.Text)
        Debug.Print("OD_AOD_OD2:  " & OD_AOD_OD2_ComboBox.Text)
        Debug.Print("OD_AOD_OD3:  " & OD_AOD_OD3_ComboBox.Text)
        Debug.Print("AOD1:   " & OD_AOD_AOD1_ComboBox.Text)
        Debug.Print("AOD2:   " & OD_AOD_AOD2_ComboBox.Text)
        Debug.Print("Airport:   " & OD_AOD_AirportName_Combobox.Text & vbCrLf)
    End Sub
    ' debug item
    Private Sub OD_AOD_OD3_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OD_AOD_OD3_ComboBox.SelectedIndexChanged
        Debug.Print("OD_AOD_OD1:  " & OD_AOD_OD1_ComboBox.Text)
        Debug.Print("OD_AOD_OD2:  " & OD_AOD_OD2_ComboBox.Text)
        Debug.Print("OD_AOD_OD3:  " & OD_AOD_OD3_ComboBox.Text)
        Debug.Print("AOD1:   " & OD_AOD_AOD1_ComboBox.Text)
        Debug.Print("AOD2:   " & OD_AOD_AOD2_ComboBox.Text)
        Debug.Print("Airport:   " & OD_AOD_AirportName_Combobox.Text & vbCrLf)
    End Sub
    ' debug item
    Private Sub OD_AOD_AOD1_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OD_AOD_AOD1_ComboBox.SelectedIndexChanged
        Debug.Print("OD_AOD_OD1:  " & OD_AOD_OD1_ComboBox.Text)
        Debug.Print("OD_AOD_OD2:  " & OD_AOD_OD2_ComboBox.Text)
        Debug.Print("OD_AOD_OD3:  " & OD_AOD_OD3_ComboBox.Text)
        Debug.Print("AOD1:   " & OD_AOD_AOD1_ComboBox.Text)
        Debug.Print("AOD2:   " & OD_AOD_AOD2_ComboBox.Text)
        Debug.Print("Airport:   " & OD_AOD_AirportName_Combobox.Text & vbCrLf)
    End Sub
    ' debug item
    Private Sub OD_AOD_AOD2_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OD_AOD_AOD2_ComboBox.SelectedIndexChanged
        Debug.Print("OD_AOD_OD1:  " & OD_AOD_OD1_ComboBox.Text)
        Debug.Print("OD_AOD_OD2:  " & OD_AOD_OD2_ComboBox.Text)
        Debug.Print("OD_AOD_OD3:  " & OD_AOD_OD3_ComboBox.Text)
        Debug.Print("AOD1:   " & OD_AOD_AOD1_ComboBox.Text)
        Debug.Print("AOD2:   " & OD_AOD_AOD2_ComboBox.Text)
        Debug.Print("Airport:   " & OD_AOD_AirportName_Combobox.Text & vbCrLf)
    End Sub
    ' debug item
    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OD_AOD_AirportName_Combobox.SelectedIndexChanged
        Debug.Print("OD_AOD_OD1:  " & OD_AOD_OD1_ComboBox.Text)
        Debug.Print("OD_AOD_OD2:  " & OD_AOD_OD2_ComboBox.Text)
        Debug.Print("OD_AOD_OD3:  " & OD_AOD_OD3_ComboBox.Text)
        Debug.Print("AOD1:   " & OD_AOD_AOD1_ComboBox.Text)
        Debug.Print("AOD2:   " & OD_AOD_AOD2_ComboBox.Text)
        Debug.Print("Airport:   " & OD_AOD_AirportName_Combobox.Text & vbCrLf)
    End Sub
    ' debug item
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Set_Test_Vals_Tab1.Click
        OD_AOD_OD1_ComboBox.SelectedIndex = 1
        OD_AOD_OD2_ComboBox.SelectedIndex = 2
        OD_AOD_OD3_ComboBox.SelectedIndex = 3
        OD_AOD_AOD1_ComboBox.SelectedIndex = 4
        OD_AOD_AOD2_ComboBox.SelectedIndex = 5
        OD_AOD_AirportName_Combobox.SelectedIndex = 3
        Todays_Date_DateTimePicker.Value = "3/22/1983"
        Debug.Print("Finished setting Test Vals Tab1")
    End Sub
    ' debug item
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles SetTestValsTab2.Click
        TowPilotNameComboBox.SelectedIndex = 6
        TowPlaneComboBox.SelectedIndex = 3
        GliderPilotComboBox.SelectedIndex = 7
        FirstNameComboBox.SelectedIndex = 8
        InstructorComboBox.SelectedIndex = 9
        PassengerComboBox.SelectedIndex = 10
        GliderComboBox.SelectedIndex = 1
        TakeOff_DateTimePicker.Value = "3/25/2015 10:45:00"
        Landing_DateTimePicker.Value = "3/25/2015 11:45:00"
        TowAltitude.Text = "3000"
        SecondNameComboBox.SelectedIndex = 11
        SplitCost.Checked = True
        PercentFirstCheck.Text = "95"
        'FlightDurationTextBox.Text = "45"
        'Penalty_CheckBox.Checked = True
        Actual_Rope_Break_CheckBox.Checked = False
        'Cost_This_Flight_TextBox.Text = "9.99"
        TakeOff_DateTimePicker_ValueChanged(vbNull, EventArgs.Empty)
        MinAltTowWarningText.Visible = False
        MinAltitudeWarning.Visible = False
    End Sub
    ' debug item
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedIndex = 1
        Dim TabIndexValue As Integer
        TabIndexValue = TabControl1.SelectedIndex
        Debug.WriteLine("Changed Tab.  TabIndex:  " & TabIndexValue)
    End Sub
    ' debug item
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Todays_Date_DateTimePicker.ValueChanged
        'this is just a "date for reference", we don't actually use this date other than
        ' to store it in the DB.  So, we do nothing in this sub.
        Debug.Print("Date:  " & Todays_Date_DateTimePicker.Value)
    End Sub
    ' debug item
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        ' debug item: this just does a quick debug.print with the index of the current selected tab
        Dim TabIndexValue As Integer
        TabIndexValue = TabControl1.SelectedIndex
        Debug.WriteLine("Tab Just Changed TabIndex:  " & TabIndexValue)
    End Sub

    Private Sub FirstNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FirstNameComboBox.SelectedIndexChanged
        PercentFirstCheck.Text = 100   'just assume there'll only be ONE pilot, so set percentage to 100%
    End Sub

    Private Sub TakeOff_DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles TakeOff_DateTimePicker.ValueChanged
        'time was changed so calculate new minutes
        FlightDurationTextBox.Text = DateDiff(DateInterval.Minute, TakeOff_DateTimePicker.Value, Landing_DateTimePicker.Value) 'display the total time for this flight
        Cost_This_Flight_TextBox_TextChanged()
    End Sub

    Private Sub Landing_DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Landing_DateTimePicker.ValueChanged
        'time was changed so calculate new minutes
        FlightDurationTextBox.Text = DateDiff(DateInterval.Minute, TakeOff_DateTimePicker.Value, Landing_DateTimePicker.Value) 'display the total time for this flight
        Cost_This_Flight_TextBox_TextChanged()
    End Sub

    Private Sub Cost_This_Flight_TextBox_TextChanged()
        Dim temp_Cost_Per_Hour As Int32 = (Val(Aircraft_Cost_TextBox.Text))
        Dim temp_Time As Int32 = CType(DateDiff(DateInterval.Minute, TakeOff_DateTimePicker.Value, Landing_DateTimePicker.Value), Int32)
        Dim temp_Penalty As Int32 = 0
        Dim two_seat_penalty As Int32 = Val(Dual_Seat_Penalty_Rate_TextBox.Text)  'pulled from DB table 
        Dim single_seat_penalty As Int32 = Val(Single_Seat_Penalty_Rate_TextBox.Text)  'pulled from DB table 
        Dim two_seat_minutes As Int32 = Val(Dual_Seat_Penalty_Start_Mins_TextBox.Text)  'pulled from DB table
        Dim single_seat_minutes As Int32 = Val(Single_Seat_Penalty_Start_Mins_TextBox.Text)  'pulled from DB table
        Dim base_tow_altitude As Int32 = Val(Base_Tow_Altitude_TextBox.Text)  'pulled from DB table 
        Dim per_hundred_tow_rate As Int32 = Val(Addtl_Per_Hndrd_Feet_Tow_TextBox.Text)  'pulled from DB table
        Dim actual_rope_break As Int32 = Val(Actual_Rope_Break_Rate_TextBox.Text)  'pulled from DB table 
        Dim simulated_rope_break As Int32 = Val(Simulated_Rope_Break_Rate_TextBox.Text)  'pulled from DB table 
        Dim temp_feet_above_base_tow_hundreds As Int32
        temp_feet_above_base_tow_hundreds = ((Val(TowAltitude.Text) - base_tow_altitude) \ 100)   'divide by 100 , and truncate, return to lower 100 ft
        If temp_feet_above_base_tow_hundreds < 0 Then   'can't have "negative altitude", so set to zero if it's less.
            temp_feet_above_base_tow_hundreds = 0
        End If

        'check if the flight was too long, and so requires a penalty charge
        ' power plane does NOT get penalty
        '  2 seater glider:  longer than 60 mins needs penalty (this is stored in DB table)
        '  1 seater glider: longer than 120 mins needs penalty (this is stored in DB table)
        Penalty_CheckBox.Enabled = False  'we don't ever want user to actually change this button. We change it programmatically.
        Override_CheckBox.Enabled = False  'we'll enable or disable the override only if there is a penalty

        'Set the "penalty check box"
        If (temp_Time > 0) And (temp_Time <= two_seat_minutes) And (temp_Time <= single_seat_minutes) Then
            'No penalty
            Penalty_CheckBox.Checked = False
            Override_CheckBox.Enabled = False
            Penalty_Label.Visible = False
            temp_Penalty = 0
            Debug.Print("*NOT* over time")
        End If
        If (temp_Time > two_seat_minutes) And (Glider_TextBox.Text = "True") And (Val(Seats_TextBox.Text) = 2) Then  '2-seater
            'Yes, penalty for 2-seater
            Penalty_CheckBox.Checked = True
            Override_CheckBox.Enabled = True
            Penalty_Label.Visible = True
            temp_Penalty = two_seat_penalty * (temp_Time - two_seat_minutes)  'penalty for "extra" minutes beyond permitted amount
            Debug.Print("2-seat:  TOO long. Temp_Penalty: " & temp_Penalty)
        End If
        If (temp_Time > single_seat_minutes) And (Glider_TextBox.Text = "True") And (Val(Seats_TextBox.Text) = 1) Then  '1-seater
            'Yes, penalty for 1-seater
            Penalty_CheckBox.Checked = True
            Override_CheckBox.Enabled = True
            Penalty_Label.Visible = True
            temp_Penalty = single_seat_penalty * (temp_Time - single_seat_minutes)  'penalty for "extra" minutes beyone permitted amount
            Debug.Print("Single Seat:  TOO Long. Temp_Penalty: " & temp_Penalty)
        End If

        '-------------------------------------------------------------
        'now calc all the various options for the cost-for-this-flight
        Debug.Print("TempFeetAboveBaseTow Hundreds:  " & temp_feet_above_base_tow_hundreds)
        If Override_CheckBox.Checked = True Then
            Cost_This_Flight_TextBox.Text = String.Format("{0:n2}", ((temp_Cost_Per_Hour / 60) * temp_Time) +
                                                          Val(Base_Tow_Fee_Dollars.Text) +
                                                          (temp_feet_above_base_tow_hundreds * per_hundred_tow_rate))
            Debug.Print("OverRide = TRUE")
        ElseIf Override_CheckBox.Checked = False Then
            Debug.Print("OverRide = FALSE")
            Cost_This_Flight_TextBox.Text = String.Format("{0:n2}", (((temp_Cost_Per_Hour / 60) * temp_Time) +
                                                          Val(Base_Tow_Fee_Dollars.Text) +
                                                          (temp_feet_above_base_tow_hundreds * per_hundred_tow_rate) +
                                                          temp_Penalty))
        End If
        CostPerHour.Text = String.Format("{0:n2}", (temp_Cost_Per_Hour / 60))
        Time.Text = temp_Time
        BaseTowCost.Text = Base_Tow_Altitude_TextBox.Text
        FtAboveBase.Text = temp_feet_above_base_tow_hundreds
        PerHundredRowRate.Text = per_hundred_tow_rate
        BaseTowFeeDollars.Text = Base_Tow_Fee_Dollars.Text

        'now calculate RopeBreak situation. RopeBreak overrides *EVERYTHING**, so keep these lines at END END of the subroutine
        'all previous calculations are thrown away, RopeBreaks have fixed fees.
        If Actual_Rope_Break_CheckBox.CheckState = CheckState.Checked Then
            'fee is taken from DB
            Debug.Print("ACTUAL Break")
            Cost_This_Flight_TextBox.Text = String.Format("{0:n2}", Val(Actual_Rope_Break_Rate_TextBox.Text))
        End If
        If Simulated_Rope_Break_CheckBox.CheckState = CheckState.Checked Then
            'fee is taken from DB
            Debug.Print("SIMULATED Break")
            Cost_This_Flight_TextBox.Text = String.Format("{0:n2}", Val(Simulated_Rope_Break_Rate_TextBox.Text))
        End If

        Debug.Print("-------------temp_Time: " & temp_Time)
        Debug.Print("two seat mins: " & two_seat_minutes)
        Debug.Print("Glider TextBox:  " & Glider_TextBox.Text)
        Debug.Print("Seats Textbox: " & Seats_TextBox.Text)
        Debug.Print("temp_Cost_Per_Hour: " & temp_Cost_Per_Hour)
        Debug.Print("temp_Date: " & temp_Time)
        Debug.Print("OverRide Checked: " & Override_CheckBox.CheckState)
        Debug.Print("costThisFlight: " & Cost_This_Flight_TextBox.Text & vbCrLf & vbCrLf)
    End Sub

    Private Sub Override_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Override_CheckBox.CheckedChanged
        Cost_This_Flight_TextBox_TextChanged()
    End Sub
    Private Sub GliderComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GliderComboBox.SelectionChangeCommitted
        'each glider has a different cost, so update the cost text box
        Cost_This_Flight_TextBox_TextChanged()
    End Sub
    Private Sub Aircraft_Cost_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Aircraft_Cost_TextBox.TextChanged
        'cost per hour changed, so update the total cost text box
        Cost_This_Flight_TextBox_TextChanged()
    End Sub
    Private Sub Simulated_Rope_Break_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Simulated_Rope_Break_CheckBox.CheckedChanged
        'it's a simulated rope break, this overrides everything, so update the total cost text box
        If Simulated_Rope_Break_CheckBox.Checked = True Then
            Debug.Print("Simulated Break is CHECKED")
            Actual_Rope_Break_CheckBox.Checked = False
            SimulatedRopeBreak_Label.Visible = True
        Else
            SimulatedRopeBreak_Label.Visible = False
        End If
        Cost_This_Flight_TextBox_TextChanged()
    End Sub
    Private Sub Actual_Rope_Break_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Actual_Rope_Break_CheckBox.CheckedChanged
        'it's an actual rope break, this overrides everything, so update the total cost text box
        If Actual_Rope_Break_CheckBox.Checked = True Then
            Debug.Print("Actual Break is CHECKED")
            Simulated_Rope_Break_CheckBox.Checked = False
            ActualRopeBreak_Label.Visible = True
        Else
            ActualRopeBreak_Label.Visible = False
        End If
        Cost_This_Flight_TextBox_TextChanged()
    End Sub

    Private Sub TowAltitude_TextChanged(sender As Object, e As EventArgs) Handles TowAltitude.Validated
        Dim base_tow_altitude As Int32 = Val(Base_Tow_Altitude_TextBox.Text)  'pulled from DB table 
        If Val(TowAltitude.Text) < base_tow_altitude Then   'you CAN'T have a tow lower than the base, so set the altitude to base_tow_altitude
            TowAltitude.Text = base_tow_altitude
            TowAltitude.SelectAll()
            MinAltitudeWarning.Visible = True
            MinAltTowWarningText.Visible = True
        Else
            MinAltitudeWarning.Visible = False
            MinAltTowWarningText.Visible = False
        End If
        Cost_This_Flight_TextBox_TextChanged()
    End Sub

End Class
