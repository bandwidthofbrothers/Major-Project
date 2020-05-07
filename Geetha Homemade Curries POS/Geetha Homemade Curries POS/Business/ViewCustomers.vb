Imports System.Data.SqlClient

Public Class ViewCustomers

    Private Sub CustomerOrderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerOrderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerOrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group22DataSet)

    End Sub

    Private Sub ViewCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Group22DataSet.Customer)
        'TODO: This line of code loads data into the 'Group22DataSet.CustomerOrder' table. You can move, or remove it, as needed.
        Me.CustomerOrderTableAdapter.Fill(Me.Group22DataSet.CustomerOrder)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CustomerBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            CustomerBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim CustDataRow As DataGridViewRow

        CustDataRow = DataGridView1.Rows(Index)

        newDataRow.Cells(0).Value = CustomerIDTextBox.Text
        newDataRow.Cells(1).Value = FirstNameTextBox.Text
        newDataRow.Cells(2).Value = SurnameTextBox.Text
        newDataRow.Cells(3).Value = PhoneNumberTextBox.Text
        newDataRow.Cells(4).Value = AmountDueTextBox.Text

        MessageBox.Show("Data successfully saved!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class