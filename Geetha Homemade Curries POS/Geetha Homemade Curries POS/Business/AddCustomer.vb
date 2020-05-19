Imports System.Data.SqlClient

Public Class AddCustomer

    Dim connection As New SqlConnection("Data Source=146.230.177.46\ist3;Initial Catalog=group22;Persist Security Info=True;User ID=group22;Password=n24mc")

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group22DataSet)

    End Sub

    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Group22DataSet.Customer)


        CustomerIDTextBox.Clear()
        FirstNameTextBox.Clear()
        SurnameTextBox.Clear()
        PhoneNumberTextBox.Clear()
        AmountDueTextBox.Clear()


    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub

    Private Sub AddCustBtn_Click(sender As Object, e As EventArgs) Handles AddCustBtn.Click

        Dim insertQuery As String = "INSERT INTO Customer(CustomerID, FirstName, Surname, PhoneNumber, AmountDue)VALUES('" & CustomerIDTextBox.Text & "','" & FirstNameTextBox.Text & "','" & SurnameTextBox.Text & "','" & PhoneNumberTextBox.Text & "','" & AmountDueTextBox.Text & "')"

        ExecuteQuery(insertQuery)

        ViewCustomers.CustomerTableAdapter.Fill(Me.Group22DataSet.Customer)

        MessageBox.Show("Record added successfully")

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub
End Class