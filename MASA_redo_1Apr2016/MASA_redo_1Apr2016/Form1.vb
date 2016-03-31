Public Class Form1
    Private Sub AircraftBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AircraftBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AircraftBindingSource.EndEdit()
        Me.AircraftTableAdapterManager.UpdateAll(Me.MASA_allDataSet_all_features)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MASA_allDataSet_all_features.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.MASA_allDataSet_all_features.Members)
        'TODO: This line of code loads data into the 'MASA_allDataSet_all_features.Flights' table. You can move, or remove it, as needed.
        Me.FlightsTableAdapter.Fill(Me.MASA_allDataSet_all_features.Flights)
        'TODO: This line of code loads data into the 'MASA_allDataSet_all_features.Airport' table. You can move, or remove it, as needed.
        Me.AirportTableAdapter.Fill(Me.MASA_allDataSet_all_features.Airport)
        'TODO: This line of code loads data into the 'MASA_allDataSet_all_features.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter.Fill(Me.MASA_allDataSet_all_features.Aircraft)

    End Sub
End Class
