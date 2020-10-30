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

            Dim amountCap As Double = CustomerTableAdapter.getAmountCap(id)

            If amountDue > amountCap Then
                MessageBox.Show("Cannot pay on account, customer has reached account limit", "Account Limit", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FormSalesCheckout.Show()
            Else
                CustomerTableAdapter.UpdateAmountDue(amountDue, id)
                Me.Close()
                FormSalesCheckout.customerID = id
                FormSalesCheckout.processOrder()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: No customer selected", "Error")
        End Try
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Me.CustomerTableAdapter.FillBySearch(Me.Group22DataSet.Customer, TextBoxSearch.Text)
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        TextBoxSearch.Text = ""

        Me.CustomerTableAdapter.Fill(Me.Group22DataSet.Customer)
    End Sub
End Class