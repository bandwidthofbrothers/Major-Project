Public Class FormSales

    Friend currentCategory As String
    Friend employeeNumber As Integer
    Friend totalDue As Decimal

    Private Sub FormSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setUpPanelForm(FormSalesCategories)
    End Sub

    Private Sub setUpPanelForm(form As Form)
        Try
            Panel.Controls.Clear()
            form.TopLevel = False
            Panel.Controls.Add(form)
            form.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        FormSalesItems.Close()
        setUpPanelForm(FormSalesCategories)
    End Sub

    Private Sub ButtonRemoveItem_Click(sender As Object, e As EventArgs) Handles ButtonRemoveItem.Click
        Try
            Dim choice As DialogResult
            choice = MessageBox.Show("Are you sure you want to remove this product", "Confirmation", MessageBoxButtons.YesNo)

            If choice = DialogResult.Yes Then
                DataGridViewOrder.Rows.RemoveAt(DataGridViewOrder.CurrentRow.Index)
                MessageBox.Show("Product Removed")
            Else
                MessageBox.Show("Deletion Cancelled")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Could not delete selected item")
        End Try
    End Sub

    Private Sub DataGridViewOrder_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridViewOrder.RowsAdded
        updateTotal()
    End Sub

    Private Sub updateTotal()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In DataGridViewOrder.Rows
            total += Decimal.Parse(row.Cells(4).Value)
        Next

        Me.totalDue = total
        LabelTotal.Text = Me.totalDue.ToString("c")
    End Sub

    Private Sub DataGridViewOrder_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridViewOrder.RowsRemoved
        updateTotal()
    End Sub

    Private Sub ButtonProceedToCheckout_Click(sender As Object, e As EventArgs) Handles ButtonProceedToCheckout.Click
        Dim choice As DialogResult
        choice = MessageBox.Show("Proceed to checkout?", "Confirmation", MessageBoxButtons.YesNo)

        If choice = DialogResult.Yes Then

            For Each row As DataGridViewRow In DataGridViewOrder.Rows
                FormSalesCheckout.DataGridViewOrder.Rows.Add(row.Cells(0).Value, row.Cells(1).Value,
                                                             row.Cells(2).Value, row.Cells(3).Value,
                                                             row.Cells(4).Value)
            Next

            FormSalesCheckout.Show()
        End If
    End Sub
End Class