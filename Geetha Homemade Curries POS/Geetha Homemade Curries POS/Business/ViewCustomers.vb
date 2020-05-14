Imports System.Data.SqlClient

Public Class ViewCustomers

    Dim connection As New SqlConnection("Data Source=146.230.177.46\ist3;Initial Catalog=group22;Persist Security Info=True;User ID=group22;Password=n24mc")

    Private Sub CustomerOrderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerOrderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerOrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group22DataSet)

    End Sub

    Private Sub ViewCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Group22D ataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Group22DataSet.Customer)
        'TODO: This line of code loads data into the 'Group22DataSet.CustomerOrder' table. You can move, or remove it, as needed.
        Me.CustomerOrderTableAdapter.Fill(Me.Group22DataSet.CustomerOrder)

    End Sub


    Private Sub AddCustBtn_Click(sender As Object, e As EventArgs) Handles AddCustBtn.Click

        AddCustomer.Show()

    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub

    Private Sub CustomerOrderBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles CustomerOrderBindingNavigator.RefreshItems

    End Sub

    Private Sub UpdateCustBtn_Click(sender As Object, e As EventArgs) Handles UpdateCustBtn.Click

        Dim updateQuery As String = "Update Customer Set FirstName = '" + FirstNameTextBox.Text + "' , Surname = '" + SurnameTextBox.Text + "' , PhoneNumber = '" + PhoneNumberTextBox.Text + "' , AmountDue = '" + AmountDueTextBox.Text + "' WHERE CustomerID = '" + CustomerIDTextBox.Text + "' "

        ExecuteQuery(updateQuery)

        MessageBox.Show("Record has been updated")

    End Sub

    Private Sub DltCustBtn_Click(sender As Object, e As EventArgs) Handles DltCustBtn.Click

        Dim deleteQuery As String = "Delete from Customer where customerID = " & CustomerIDTextBox.Text
        ExecuteQuery(deleteQuery)
        CustomerTableAdapter.Fill(Me.Group22DataSet.Customer)

        MessageBox.Show("Customer record deleted")


    End Sub

    Private Sub CustomerOrderDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerOrderDataGridView.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.CustomerOrderDataGridView.Rows(e.RowIndex)
            CustomerIDTextBox.Text = row.Cells(0).Value.ToString
            FirstNameTextBox.Text = row.Cells(1).Value.ToString
            SurnameTextBox.Text = row.Cells(2).Value.ToString
            PhoneNumberTextBox.Text = row.Cells(3).Value.ToString
            AmountDueTextBox.Text = row.Cells(4).Value.ToString
        End If

    End Sub

End Class