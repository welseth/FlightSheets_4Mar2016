Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub



    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Save_Button.Click
        'create a newFlightRow to store the new flight info into.
        Dim newFlightRow As MASA_all_1Apr2016DataSet.FlightsRow
        newFlightRow = Me.MASA_all_1Apr2016DataSet.Flights.NewFlightsRow()

        Debug.Print("GliderPilotNameComboBox.SelectedIndex:  " & GliderPilotComboBox.SelectedIndex)
        Debug.Print("GliderNameComboBox2.SelectedIndex: >>  " & GliderComboBox.SelectedIndex)

        ' load the new data into each, and every, field in the new record
        newFlightRow.Glider_Pilot_Name = GliderPilotComboBox.SelectedIndex
        newFlightRow.Glider = GliderComboBox.SelectedIndex
        newFlightRow.Instructor_name = InstructorComboBox.SelectedIndex
        newFlightRow.Passenger_name = PassengerComboBox.SelectedIndex
        newFlightRow.OD1 = OD_AOD_OD1_ComboBox.SelectedIndex
        newFlightRow.OD2 = OD_AOD_OD2_ComboBox.SelectedIndex
        newFlightRow.OD3 = OD_AOD_OD3_ComboBox.SelectedIndex
        newFlightRow.AOD1 = OD_AOD_AOD1_ComboBox.SelectedIndex
        newFlightRow.AOD2 = OD_AOD_AOD2_ComboBox.SelectedIndex
        newFlightRow.TowPilot1 = TowPilotNameComboBox.SelectedIndex
        newFlightRow.TowPilot2 = TowPilotNameComboBox.SelectedIndex  'towpilot2 not used, but assigning anyway
        newFlightRow.TowPilot3 = TowPilotNameComboBox.SelectedIndex  'towpilot3 not used, but assigning anyway
        newFlightRow.TowPlane1 = TowPlaneComboBox.SelectedIndex
        newFlightRow.TowPlane2 = TowPlaneComboBox.SelectedIndex  'towplane2 not used, but assigning anyway
        Debug.Print("Todays DateTimePicker1: " & Todays_Date_DateTimePicker.Value)
        'MessageBox.Show("DateTimePicker:  " & DateTimePicker1.Value)  'get rid of this after debugging is complete 
        Debug.Print("Glider Takeoff:  " & TakeOff_DateTimePicker.Value)
        newFlightRow.Glider_takeoff_time = TakeOff_DateTimePicker.Value
        Debug.Print("Glider Landing:  " & Landing_DateTimePicker.Value)
        newFlightRow.Glider_landing_time = Landing_DateTimePicker.Value
        newFlightRow.Tow_takeoff_time = TakeOff_DateTimePicker.Value
        newFlightRow.Tow_landing_time = Landing_DateTimePicker.Value
        newFlightRow._Date = Todays_Date_DateTimePicker.Value  'saves in format DateTime 
        newFlightRow.Altitude_towed = TowAltitude.Text
        newFlightRow.Rope_break = RopeBreakCheckBox.Checked
        newFlightRow.Airport_name = OD_AOD_AirportName_Combobox.SelectedIndex
        newFlightRow.Flight_minutes_integer = 132                                  '<<<<<<<<<<<<need to do the math on this one!!   >>>>>>>>>>>>>>>>>>
        newFlightRow.First_name_on_invoice = FirstNameComboBox.SelectedIndex
        newFlightRow.Split_cost = SplitCost.Checked
        newFlightRow.Percent_1st_check = PercentFirstCheck.Text
        newFlightRow.Second_name_on_invoice = SecondNameComboBox.SelectedIndex
        newFlightRow.Penalty_charge = PenaltyRadioButton.Checked
        newFlightRow.Cost_this_flight = Cost_This_Flight_TextBox.Text        '<<<<<<<<<<<<<<<<<<<<<<<<<<<need to do the math on this one!!!  >>>>>>>>>>>>>>>>>>


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
            Me.Validate()   'this line is probably NOT needed. 
            Me.MASA_All_BindingSource.EndEdit()  'this line is probably NOT needed
            Me.MASA_All_Flights_TableAdapterManager.UpdateAll(Me.MASA_all_1Apr2016DataSet)

        Catch ex As Exception
            MessageBox.Show("Update failed  " & vbCrLf & ex.Message)
        End Try

        Debug.WriteLine("Now FINISHED the DB .add and the DB .update")

        'now zero-out the already-saved data so the user can enter new rows
        ' but send "false" to NOT delete time and altitude
        Button1_Click_3(sender, e)

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
        PenaltyRadioButton.Checked = False
        RopeBreakCheckBox.Checked = False
        Cost_This_Flight_TextBox.Text = ""

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
        GliderComboBox.SelectedIndex = 4
        TakeOff_DateTimePicker.Value = "3/25/2015 10:01:01"
        Landing_DateTimePicker.Value = "3/25/2015 11:30:22"
        TowAltitude.Text = "3000"
        SecondNameComboBox.SelectedIndex = 11
        SplitCost.Checked = True
        PercentFirstCheck.Text = "95"
        FlightDurationTextBox.Text = "2hr 39min"
        PenaltyRadioButton.Checked = True
        RopeBreakCheckBox.Checked = True
        Cost_This_Flight_TextBox.Text = "9.99"
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
        Debug.Print("Date:  " & Todays_Date_DateTimePicker.Value)
    End Sub
    ' debug item
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        ' debug item: this just does a quick debug.print with the index of the current selected tab
        Dim TabIndexValue As Integer
        TabIndexValue = TabControl1.SelectedIndex
        Debug.WriteLine("Tab Just Changed TabIndex:  " & TabIndexValue)

    End Sub


End Class
