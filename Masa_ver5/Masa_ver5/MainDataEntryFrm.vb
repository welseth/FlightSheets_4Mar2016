Public Class MainDataEntryForm
    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OD_AOD_OD1MembersBindingSource.EndEdit()
        Me.OD_AOD_OD1TableAdapterManager.UpdateAll(Me.OD_AOD_OD1)

    End Sub

    Private Sub MainDataEntryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox.SelectedIndexChanged

    End Sub

    Private Sub NameComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Airport_nameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Airport_nameComboBox.SelectedIndexChanged

    End Sub

    Private Sub Aircraft_NnumberComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


End Class
