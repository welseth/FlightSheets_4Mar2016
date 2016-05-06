Imports System.Data.SqlClient
Imports System
Imports System.Data



Public Class Form1


    Dim New_Member_Name_DGVhasChanged As Boolean   'holds state when the new member name data grid has been edited in any way


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Add_Edit_Pilot_Names.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter23.Fill(Me.Add_Edit_Pilot_Names.Members)
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
        TabControl1.SelectedIndex = 3 'move to the member editing tab, then set datagrid enabled to false (first time only)
        MembersDataGridView.Enabled = False   'disable the "edit members list" datagrid so they can't change things without the pwd
        MembersDataGridView.ReadOnly = True
        FlightsDataGridView.Enabled = False
        FlightsDataGridView.ReadOnly = True
        btnEdit_Names_Save_new.Enabled = False   'Nothing has changed in the datagridview yet, so disable the "save" button

        TabControl1.SelectedIndex = 0

        'below code mostly to pretty-up the GUI once it's "ready for outside reviewers"
        Set_Test_Vals_Tab1.Visible = True
        SetTestValsTab2.Visible = True
        Button2.Visible = True
        'Dim final_deployed_code As Boolean
        'final_deployed_code = True    'set True if this is "deployed code", and it'll hide a bunch of extra textboxes and such
        'If final_deployed_code = True Then

        'Add_Edit_BindingNavigator.Visible = False  'hide this control, useful only for debuggins, not for deployed program
        'MASA_All_FlightsBindingNavigator.Visible = False
        'Label38.Visible = False
        'Label39.Visible = False
        'Label40.Visible = False
        'Label41.Visible = False
        'Label42.Visible = False
        'Label43.Visible = False
        'CostPerHour.Visible = False
        'Time.Visible = False
        'BaseTowCost.Visible = False
        'BaseTowFeeDollars.Visible = False
        'FtAboveBase.Visible = False
        'PerHundredRowRate.Visible = False
        'Label25.Visible = False
        'Label26.Visible = False
        'Label28.Visible = False
        'Label44.Visible = False
        'Label21.Visible = False
        'Label27.Visible = False
        'Label29.Visible = False
        'Label30.Visible = False
        'Label31.Visible = False
        'Label32.Visible = False
        'Label33.Visible = False
        'Label34.Visible = False
        'Label35.Visible = False
        'Label36.Visible = False
        'Label37.Visible = False
        'Seats_TextBox.Visible = False
        'Glider_TextBox.Visible = False
        'Tow_Plane_TextBox.Visible = False
        'Actual_Rope_Break_Rate_TextBox.Visible = False
        'Simulated_Rope_Break_Rate_TextBox.Visible = False
        'Base_Tow_Altitude_TextBox.Visible = False
        'Addtl_Per_Hndrd_Feet_Tow_TextBox.Visible = False
        'Aero_Retrieve_TextBox.Visible = False
        'Single_Seat_Penalty_Rate_TextBox.Visible = False
        'Single_Seat_Penalty_Start_Mins_TextBox.Visible = False
        'Dual_Seat_Penalty_Rate_TextBox.Visible = False
        'Dual_Seat_Penalty_Start_Mins_TextBox.Visible = False   'maybe this one
        'Base_Tow_Fee_Dollars.Visible = False
        'TextBox1.Visible = False

        'TabPage5.Visible = False
        'TabPage6.Visible = False
        'End If

    End Sub

    'Private Sub Save_Name_Edit_ToolStripButton_Click(sender As Object, e As EventArgs) Handles Save_Name_Edit_ToolStripButton.Click
    '    'This saves the user-edited list of member names.  They can add/delete/edit as needed.

    '    Dim newMemberRow As MASA_all_1Apr2016DataSet.MembersRow
    '    newMemberRow = Me.MASA_all_1Apr2016DataSet.Members.NewMembersRow()
    '    'load the NEW data into each and every field in the new record
    '    newMemberRow.Name = MembersDataGridView.Name
    '    newMemberRow.Instructor = MembersDataGridView.


    '    'ok, close everything and write to the DB file.
    '    Me.Validate()
    '    Me.Add_Edit_Pilot_Names_MembersBindingSource.EndEdit()

    '    'save the new row to the DB
    '    Try

    '        Me.MASA_All_Flights_TableAdapterManager.UpdateAll(Me.MASA_all_1Apr2016DataSet)
    '        'Me.pilot_na
    '    Catch ex As Exception
    '        MessageBox.Show("Update failed  " & vbCrLf & ex.Message)
    '    End Try
    'End Sub

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
            MessageBox.Show("Must Select Pilot In Charge (PIC)")
            Exit Sub
        End If

        If GliderComboBox.SelectedIndex > 0 Then
            newFlightRow.Glider = GliderComboBox.SelectedIndex
        Else
            MessageBox.Show("Must Select The Aircraft That Was Rented")
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
            MessageBox.Show("Must Select First Name On Invoice")
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
            MessageBox.Show("Add new FLIGHT failed" & vbCrLf & ex.Message)
        End Try

        'save the new row to the DB
        Try
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
        'Log out any member name editing ANY TIME the tab is changed
        Debug.WriteLine("You now signed-out.")
        UserName_Login_TextBox.Clear()
        Password_Login_TextBox.Clear()
        UserName_Login_TextBox.Focus()
        MembersDataGridView.Enabled = False
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


        If (temp_Time > two_seat_minutes) And (Glider_TextBox.Text = "True") And (Val(Seats_TextBox.Text) = 2) Then  '2-seater    '****This change is to hide TextBox
            'If (temp_Time > two_seat_minutes) And (Glider_TextBox.Text = "True") And (Val(AircraftBindingSource2.Current("Seats")) = 2) Then  '2-seater
            'Yes, penalty for 2-seater
            Penalty_CheckBox.Checked = True
            Override_CheckBox.Enabled = True
            Penalty_Label.Visible = True
            temp_Penalty = two_seat_penalty * (temp_Time - two_seat_minutes)  'penalty for "extra" minutes beyond permitted amount
            Debug.Print("2-seat:  TOO long. Temp_Penalty: " & temp_Penalty)
        End If
        If (temp_Time > single_seat_minutes) And (Glider_TextBox.Text = "True") And (Val(Seats_TextBox.Text) = 1) Then  '1-seater '****This change is to hide TextBox
            'If (temp_Time > single_seat_minutes) And (Glider_TextBox.Text = "True") And (Val(AircraftBindingSource2.Current("Seats")) = 1) Then  '1-seater
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
        Debug.Print("BindingSourceSeats TxtBx: " & AircraftBindingSource2.Current("Seats")) '*************

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




    Private Sub Edit_Names_Login_Button_Click(sender As Object, e As EventArgs) Handles Edit_Names_Login_Button.Click
        'This is the "user login" logic 
        'This section checks for valid username and passwords.  All authorized user info is stored in the UserNames table in the main DB.

        'check for null UserName
        If ((Trim(UserName_Login_TextBox.Text)) = "") Then
            MsgBox("User Name required.", vbExclamation)
            UserName_Login_TextBox.Focus()
            Exit Sub
        End If
        'check for null Password
        If ((Trim(Password_Login_TextBox.Text)) = "") Then
            MsgBox("Password required.", vbExclamation)
            Password_Login_TextBox.Focus()
            Exit Sub
        End If
        '
        'Lookup the password that matches the Username 
        'go read the DB and use the UserName and Pwd from that DB
        'Create the connection and the command object
        Dim thisPasswordConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MASA_all_1Apr2016.mdf;Integrated Security=True;Connect Timeout=30")
        Dim thisPasswordCommand As New SqlCommand("SELECT * from UserNames WHERE UserName= '" & Trim(UserName_Login_TextBox.Text) & "'", thisPasswordConnection)

        Try
            ' Open Connection
            thisPasswordConnection.Open()
            Debug.WriteLine("Connection to UserName DB Opened<<<")
            ' Execute Query pulling the password for the user-supplied username
            Dim strUsername As String = "Test 1" 'temp strings for debug, when done change these to "" (vbNull) <<<<<<<<<<<<<<
            Dim strPassword As String = "Test 2" 'temp strings for debug
            Debug.WriteLine("Next 2 lines below should show the letter 'Test 1' and 'Test 2'")
            Debug.WriteLine(strUsername)  'for whatever reason these debug.writeline commands must be on SEPARATE lines!
            Debug.WriteLine(strPassword)
            Dim thisReader As SqlDataReader = thisPasswordCommand.ExecuteReader()
            While (thisReader.Read())

                If Not thisReader.Item("UserName") Is DBNull.Value Then strUsername = thisReader.Item("UserName")
                If Not thisReader.Item("Password") Is DBNull.Value Then strPassword = thisReader.Item("Password")
                Debug.WriteLine("Next 2 lines below should show actual values pulled from the DB for the specific UserName:")
                Debug.WriteLine(strUsername)
                Debug.WriteLine(strPassword)
                'using string.compareOrdinal as this function includes case sensitivity
                If String.CompareOrdinal(strPassword, Password_Login_TextBox.Text) = 0 Then
                    'txtBxGoodPassword.Visible = True   'success, so flash the "good pwd" box once 
                    'System.Threading.Thread.Sleep(1100)
                    'txtBxGoodPassword.Visible = False
                    'clear out both Username and Password entry, make datagrid enabled 
                    Password_Login_TextBox.Text = ""
                    UserName_Login_TextBox.Text = ""
                    MembersDataGridView.ReadOnly = False
                    MembersDataGridView.Enabled = True  'enable the datagrid so new user info can be entered
                Else
                    'incorrect entry, clear out both Username and Pwd text boxes, yell at them.
                    Password_Login_TextBox.Clear()
                    UserName_Login_TextBox.Clear()
                    MsgBox("Try again", vbExclamation)
                    UserName_Login_TextBox.Focus()
                    MembersDataGridView.ReadOnly = True
                    MembersDataGridView.Enabled = False
                    Exit Sub
                End If
            End While

        Catch ex As SqlException
            ' Display the error
            Debug.WriteLine("Error: " & ex.ToString())
        Finally
            ' Close Connection
            thisPasswordConnection.Close()
            Debug.WriteLine("Connection Closed<<<")
        End Try

        'Now do the string compare and decide if the password matches
        'If String.Compare(str1, str2) = 0 And String.Compare(str3, str4) = 0 Then
        '    MessageBox.Show("str1 = str2 And str3 = str4")
        'Else
        '    MessageBox.Show("Else")
        'End If
        'Dim tmpPwdBoxColor As Color = Password_Login_TextBox.BackColor  'save whatever color the box was originally
        'Dim tmpUserBoxColor As Color = UserName_Login_TextBox.BackColor


        'This seems to be agood query:
        '        Dim queryString As String =
        '        "SELECT * from UserNames where UCase(trim(UserName)) = '" & UCase(Trim(txtUserInputFmTextBox)) & "'"
        '
        '  LOOK Here:
        '  http://www.java2s.com/Code/VB/Database-ADO.net/CatalogDatabase-ADO.net.htm
        ' this one might work??  :
        '  http://www.java2s.com/Code/VB/Database-ADO.net/UseSqlDataReadertoreadresultsetfromselectcommand.htm
        '
        '  Some connection strings...
        '  http://www.connectionstrings.com/sql-server/
        '
        ' Here's how to create connection strings in Visual Studio:
        '  http://www.itworld.com/article/3007292/development/how-to-create-sql-server-connection-strings-in-visual-studio.html
        '  Below connection string is the ACTUAL connection string for MASA's project:
        '  Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MASA_all_1Apr2016.mdf;Integrated Security=True;Connect Timeout=30
        '
        'Dim tempRecordSet As IDataRecord
        'Dim Password As String

        ''open the AdminUsers table
        ''(recordset object variables allow access to records and fields in tables and queries.
        ''This modified version opens a recordset via a SQL statement to pull the record (if any) where the field matches the txtUser 
        ''field in the form.
        ''Since the UserName field is a "must be unique" field, there should only be one record if any matches are found.
        'Set tempRecordSet = CurrentDb.OpenRecordset("select * from AdminUsers where UCase(trim(UserID)) = '" & UCase(Trim(txtUser)) & "'")

        ''retrieve the Password field from the AdminUsers table if the UserID matches the txtUser Field
        'If tempRecordSet.RecordCount <> 0 Then
        '    Password = UCase(Trim(tempRecordSet("Password")))
        'End If

        ''close the recordset and release the recordset object variable
        'tempRecordSet.Close
        'Set tempRecordSet = Nothing

        ''check the password
        'If Password <> UCase(Trim(txtPassword)) Then
        '    MsgBox "Incorrect password", vbExclamation
        'Else
        '    'passwords match, allow the user to the maintenance switchboard
        '    MsgBox "Congratulations! Right Password!!!", vbExclamation
        'End If
        'txtPassword = Empty
    End Sub

    Private Sub Edit_Names_Cancel_Login_Button_Click(sender As Object, e As EventArgs) Handles Edit_Names_Cancel_Login_Button.Click
        Debug.WriteLine("You just clicked CANCEL.")
        UserName_Login_TextBox.Clear()
        Password_Login_TextBox.Clear()
        UserName_Login_TextBox.Focus()
        MembersDataGridView.Enabled = False
        MembersDataGridView.ReadOnly = True
        btnEdit_Names_Save_new.Enabled = False  'nothing to save, we just cleared everything, so disable the Save button
    End Sub

    Private Sub Edit_Names_LogOUT_Button_Click(sender As Object, e As EventArgs) Handles Edit_Names_LogOUT_Button.Click
        Debug.WriteLine("You now signed-out.")
        UserName_Login_TextBox.Clear()
        Password_Login_TextBox.Clear()
        UserName_Login_TextBox.Focus()
        MembersDataGridView.Enabled = False
        MembersDataGridView.ReadOnly = True
        btnEdit_Names_Save_new.Enabled = False  'nothing to save, we just cleared everything, so disable the Save button
    End Sub


    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
        Handles MembersDataGridView.CellValueChanged
        New_Member_Name_DGVhasChanged = True  'the data grid view contents has changed, so set the changed-flag
        btnEdit_Names_Save_new.Enabled = True 'something changed so enable the save button
        Debug.WriteLine("Data Grid changed.")
    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MembersDataGridView.CurrentCellDirtyStateChanged
        New_Member_Name_DGVhasChanged = True  'the check boxes have changed, so set the changed-flag
        btnEdit_Names_Save_new.Enabled = True 'something changed so enable the save button
        Debug.WriteLine("Check boxes changed.")
    End Sub


    Private Sub btnEdit_Names_Save_new_Click(sender As Object, e As EventArgs) Handles btnEdit_Names_Save_new.Click
        '********************************
        '********************************
        'I copied word-for-word the "save new flights" logic to here.  NEED TO:
        ' -delete anything that doesn't apply to saving new member names
        ' -add proper code to create a new row in the DB table and save it.
        ' >>>Hoping this will be simpler since it's already "solved" !!! :-) 
        '
        'this section relies on DatGridView1_CellValueChanged and DataGridView1_CurrentCellDirtyStateChanged
        ' in order to determine if there is any info that actually needs to be saved out into the DB table.
        ' Both of these are done in separate Subs
        '       Set a boolean flag = true when either of those events occurs And 
        '           check the status of this flag when the form Is closed Or whenever 
        '            you want to ask the user for saving changes.

        'Save the info that the user entered into the form for the new member names

        'Need to create a neewMembersRow to store the new flight info into.
        Dim newMembersRow As MASA_all_1Apr2016DataSet.MembersRow
        newMembersRow = Me.MASA_all_1Apr2016DataSet.Members.NewMembersRow()   'not sure if NewMembersRow() is correct, look here if there are problems.

        'Dim newFlightRow As MASA_all_1Apr2016DataSet.FlightsRow
        'newFlightRow = Me.MASA_all_1Apr2016DataSet.Flights.NewFlightsRow()

        'Debug.Print("GliderPilotNameComboBox.SelectedIndex:  " & GliderPilotComboBox.SelectedIndex)
        'Debug.Print("GliderNameComboBox2.SelectedIndex: >>  " & GliderComboBox.SelectedIndex)

        ' load the new data into each, and every, field in the new record
        'Text boxes can't be blank, need to check that user didn't backspace and delete everything in the textbox.
        'Try
        '    newMembersRow.Name = MembersDataGridView.Name


        'Catch ex As Exception
        '    newFlightRow.Altitude_towed = "0"
        '    Debug.Print("Reset AltTowed to 0")
        'End Try

        '
        'ok, close everything and write to the DB file.
        ' EXCELLENT reference about EndEdit and AcceptChanges and when to use each is here:
        '   https://msdn.microsoft.com/en-us/library/bb384432.aspx

        Me.Validate()
        Me.MembersBindingSource.EndEdit()  'When the EndEdit method is called, all pending changes are applied to the underlying data source

        ''add new the row that has all the user-entered values into the *TABLE*
        'Try
        '    Me.MASA_all_1Apr2016DataSet.Members.Rows.Add(newMembersRow)    'Flights.Rows.Add(newFlightRow)
        '    Debug.WriteLine("Completed table write.")
        'Catch ex As Exception
        '    MessageBox.Show("Add new member failed" & vbCrLf & ex.Message)
        'End Try

        ' The changes have been put into the local datagrid table, so now commit/save the new row to the *DB*
        Try
            'Me.MASA_all_1Apr2016DataSet.AcceptChanges()
            MembersTableAdapter23.Update(Add_Edit_Pilot_Names_MembersBindingSource.DataSource)
        Catch ex As Exception
            MessageBox.Show("Update failed  " & vbCrLf & ex.Message)
        End Try
        btnEdit_Names_Save_new.Enabled = False   'we completed saving everything, so disable the "save" button

        Debug.WriteLine("Now FINISHED the DB .add and the DB .update")

    End Sub

    Private Sub QuitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs) Handles Label52.Click

    End Sub












    '    PASSWORD Code VVVV   PASSWORD Code VVVV   PASSWORD Code VVVV   PASSWORD Code VVVV
    'possible username/password code.
    'Private Sub cmdMaintenanceSwitchboard_Click()

    '    'check for null password
    '    If IsNull(Trim(txtUser)) Then
    '        MsgBox "User Name required.", vbExclamation
    '    txtUser.SetFocus
    '        Exit Sub
    '    End If

    '    'check for null password
    '    If IsNull(Trim(txtPassword)) Then
    '        MsgBox "Password required.", vbExclamation
    '    txtPassword.SetFocus
    '        Exit Sub
    '    End If

    '    'To use the following code, open the code window for a form.
    '    'Under the Tools/References menu, enable the "Microsoft DAO 3.6 Object Library"
    '    'and some may have to disable the "Microsoft ActiveX Data Objects Library"

    '    'declare variables (tempRecordSet becomes an object variable)
    '    Dim tempRecordSet As Recordset, Password As String

    ''open the AdminUsers table
    ''(recordset object variables allow access to records and fields in tables and queries.
    ''This modified version opens a recordset via a SQL statement to pull the record (if any) where the field matches the txtUser field in the form.
    ''Since the field is a primary key, there should only be one record if any matches are found.
    'Set tempRecordSet = CurrentDb.OpenRecordset("select * from AdminUsers where UCase(trim(UserID)) = '" & UCase(Trim(txtUser)) & "'")

    ''retrieve the Password field from the AdminUsers table if the UserID matches the txtUser Field
    'If tempRecordSet.RecordCount <> 0 Then
    '        Password = UCase(Trim(tempRecordSet("Password")))
    '    End If

    '    'close the recordset and release the recordset object variable
    '    tempRecordSet.Close
    'Set tempRecordSet = Nothing

    ''check the password
    'If Password <> UCase(Trim(txtPassword)) Then
    '        MsgBox "Incorrect password", vbExclamation
    'Else
    '        'passwords match, allow the user to the maintenance switchboard
    '        MsgBox "Congratulations! Right Password!!!", vbExclamation
    'End If
    '    txtPassword = Empty
    'End Sub


End Class
