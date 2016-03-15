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


        If Airport_nameComboBox.Items.Count > 0 Then     'set the airport to be the "first one on the list"
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

    Private Sub TowPilotNameComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TowPilotNameComboBox5.LostFocus

        TempTextBox.Text = TowPilotNameComboBox5.SelectedValue

    End Sub
End Class
