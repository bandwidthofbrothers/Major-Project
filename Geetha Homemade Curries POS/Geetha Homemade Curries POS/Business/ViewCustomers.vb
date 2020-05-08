Imports System.Data.SqlClient

Public Class ViewCustomers

    Dim connection As New SqlConnection("Data Source=146.230.177.46\ist3;Initial Catalog=group22;Persist Security Info=True;User ID=group22;Password=n24mc")

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


    Private Sub AddCustBtn_Click(sender As Object, e As EventArgs) Handles AddCustBtn.Click

        Dim insertQuery As String = "INSERT INTO Customer(CustomerID, FirstName, Surname, PhoneNumber, AmountDue)VALUES('" & CustomerIDTextBox.Text & "','" & FirstNameTextBox.Text & "','" & SurnameTextBox.Text & "','" & PhoneNumberTextBox.Text & "','" & AmountDueTextBox.Text & "')"

        ExecuteQuery(insertQuery)

        MessageBox.Show("Record added successfully")

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

        Dim updateQuery As String = "Update Customer Set FirstName = '" & FirstNameTextBox.Text & "' , Surname = '" & SurnameTextBox.Text & "' , PhoneNumber = '" & PhoneNumberTextBox.Text & "' , AmountDue = '" & AmountDueTextBox.Text & "' WHERE CustomerID = '" & CustomerIDTextBox.Text & "'"
        ExecuteQuery(updateQuery)
        MessageBox.Show("Record has been updated")

    End Sub

    Private Sub DltCustBtn_Click(sender As Object, e As EventArgs) Handles DltCustBtn.Click

        Dim deleteQuery As String = "Delete from Customer where customerID = " & CustomerIDTextBox.Text
        ExecuteQuery(deleteQuery)
        MessageBox.Show("Customer record deleted")


    End Sub
End Class