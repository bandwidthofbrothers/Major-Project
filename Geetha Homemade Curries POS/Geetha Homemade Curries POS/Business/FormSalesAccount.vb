Public Class FormSalesAccount

    Friend amountDue As Double

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group22DataSet)

    End Sub

    Private Sub FormSalesAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Group22DataSet.Customer)

    End Sub

    Private Sub ButtonProceed_Click(sender As Object, e As EventArgs) Handles ButtonProceed.Click
        Try
            Dim id As Integer = CustomerDataGridView.CurrentRow.Cells(0).Value
            Dim amountOwed As Double = CustomerTableAdapter.getAmountDue(id)
            amountDue += amountOwed

            CustomerTableAdapter.UpdateAmountDue(amountDue, id)
            Me.Close()
            FormSalesCheckout.processOrder()

        Catch ex As Exception
            MessageBox.Show("Error: No customer selected", "Error")
        End Try
    End Sub
End Class