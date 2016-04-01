Public Class Form1
    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MembersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OD_AOD_OD1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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





    End Sub







    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OD_AOD_OD1_ComboBox.SelectedIndexChanged
        Debug.Print("OD_AOD_OD1:  " & OD_AOD_OD1_ComboBox.Text)
        Debug.Print("OD_AOD_OD2:  " & OD_AOD_OD2_ComboBox.Text)
        Debug.Print("OD_AOD_OD3:  " & OD_AOD_OD3_ComboBox.Text)
        Debug.Print("AOD1:   " & OD_AOD_AOD1_ComboBox.Text)
        Debug.Print("AOD2:   " & OD_AOD_AOD2_ComboBox.Text)
        Debug.Print("Airport:   " & OD_AOD_AirportName_Combobox.Text & vbCrLf)

    End Sub

    Private Sub OD_AOD_OD2_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OD_AOD_OD2_ComboBox.SelectedIndexChanged
        Debug.Print("OD_AOD_OD1:  " & OD_AOD_OD1_ComboBox.Text)
        Debug.Print("OD_AOD_OD2:  " & OD_AOD_OD2_ComboBox.Text)
        Debug.Print("OD_AOD_OD3:  " & OD_AOD_OD3_ComboBox.Text)
        Debug.Print("AOD1:   " & OD_AOD_AOD1_ComboBox.Text)
        Debug.Print("AOD2:   " & OD_AOD_AOD2_ComboBox.Text)
        Debug.Print("Airport:   " & OD_AOD_AirportName_Combobox.Text & vbCrLf)
    End Sub

    Private Sub OD_AOD_OD3_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OD_AOD_OD3_ComboBox.SelectedIndexChanged
        Debug.Print("OD_AOD_OD1:  " & OD_AOD_OD1_ComboBox.Text)
        Debug.Print("OD_AOD_OD2:  " & OD_AOD_OD2_ComboBox.Text)
        Debug.Print("OD_AOD_OD3:  " & OD_AOD_OD3_ComboBox.Text)
        Debug.Print("AOD1:   " & OD_AOD_AOD1_ComboBox.Text)
        Debug.Print("AOD2:   " & OD_AOD_AOD2_ComboBox.Text)
        Debug.Print("Airport:   " & OD_AOD_AirportName_Combobox.Text & vbCrLf)
    End Sub

    Private Sub OD_AOD_AOD1_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OD_AOD_AOD1_ComboBox.SelectedIndexChanged
        Debug.Print("OD_AOD_OD1:  " & OD_AOD_OD1_ComboBox.Text)
        Debug.Print("OD_AOD_OD2:  " & OD_AOD_OD2_ComboBox.Text)
        Debug.Print("OD_AOD_OD3:  " & OD_AOD_OD3_ComboBox.Text)
        Debug.Print("AOD1:   " & OD_AOD_AOD1_ComboBox.Text)
        Debug.Print("AOD2:   " & OD_AOD_AOD2_ComboBox.Text)
        Debug.Print("Airport:   " & OD_AOD_AirportName_Combobox.Text & vbCrLf)
    End Sub

    Private Sub OD_AOD_AOD2_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OD_AOD_AOD2_ComboBox.SelectedIndexChanged
        Debug.Print("OD_AOD_OD1:  " & OD_AOD_OD1_ComboBox.Text)
        Debug.Print("OD_AOD_OD2:  " & OD_AOD_OD2_ComboBox.Text)
        Debug.Print("OD_AOD_OD3:  " & OD_AOD_OD3_ComboBox.Text)
        Debug.Print("AOD1:   " & OD_AOD_AOD1_ComboBox.Text)
        Debug.Print("AOD2:   " & OD_AOD_AOD2_ComboBox.Text)
        Debug.Print("Airport:   " & OD_AOD_AirportName_Combobox.Text & vbCrLf)
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OD_AOD_AirportName_Combobox.SelectedIndexChanged
        Debug.Print("OD_AOD_OD1:  " & OD_AOD_OD1_ComboBox.Text)
        Debug.Print("OD_AOD_OD2:  " & OD_AOD_OD2_ComboBox.Text)
        Debug.Print("OD_AOD_OD3:  " & OD_AOD_OD3_ComboBox.Text)
        Debug.Print("AOD1:   " & OD_AOD_AOD1_ComboBox.Text)
        Debug.Print("AOD2:   " & OD_AOD_AOD2_ComboBox.Text)
        Debug.Print("Airport:   " & OD_AOD_AirportName_Combobox.Text & vbCrLf)
    End Sub
End Class
