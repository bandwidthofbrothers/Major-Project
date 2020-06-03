Imports System.Data.SqlClient

Public Class ViewCustomers

    Dim connection As New SqlConnection("Data Source=146.230.177.46\ist3;Initial Catalog=group22;Persist Security Info=True;User ID=group22;Password=n24mc")

    Private Sub CustomerOrderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
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

    Private Sub CustomerOrderBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

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

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub

    Private Sub DltCustBtn_Click(sender As Object, e As EventArgs) Handles DltCustBtn.Click

        Try
            Dim CustomerID As Integer = CustomerOrderDataGridView.CurrentRow.Cells(0).Value

            CustomerTableAdapter.Delete(CustomerID)

            CustomerTableAdapter.Fill(Me.Group22DataSet.Customer)

            MessageBox.Show("Record deleted successfully")

        Catch ex As Exception
            MessageBox.Show("Error: Could not delete record")
        End Try

    End Sub

    Private Sub UpdateCustBtn_Click(sender As Object, e As EventArgs) Handles UpdateCustBtn.Click

        If Not CustomerIDTextBox.Text = "" Then
            'Add try catch statement
            Dim ID As Integer = Integer.Parse(CustomerIDTextBox.Text)
            Dim FirstName As String = FirstNameTextBox.Text
            Dim Surname As String = SurnameTextBox.Text
            Dim PhoneNumber As String = PhoneNumberTextBox.Text
            Dim AmountDue As Double = Double.Parse(AmountDueTextBox.Text)

            CustomerTableAdapter.Update1(FirstName, Surname, PhoneNumber, AmountDue, ID)
            CustomerTableAdapter.Fill(Me.Group22DataSet.Customer)

            MessageBox.Show("Record updated successfully", "Update Successful")
        Else
            MessageBox.Show("Error: No record selected", "Error")
        End If

    End Sub

End Class