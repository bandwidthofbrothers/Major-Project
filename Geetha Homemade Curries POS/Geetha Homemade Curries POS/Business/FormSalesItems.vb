Public Class FormSalesItems

    Private Sub FormSalesItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.MenuItem' table. You can move, or remove it, as needed.
        Me.MenuItemTableAdapter.FillByCategory(Me.Group22DataSet.MenuItem, FormSales.currentCategory)
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim ID As Integer = DataGridView.CurrentRow.Cells(0).Value
        Dim name As String = DataGridView.CurrentRow.Cells(1).Value
        Dim price As Double = DataGridView.CurrentRow.Cells(3).Value
        Dim quantity As Integer = DataGridView.CurrentRow.Cells(4).Value

        If quantity = 0 Then
            quantity = 1
        End If

        Dim subTotal As Double = price * quantity

        FormSales.DataGridViewOrder.Rows.Add(ID, name, price, quantity, subTotal)
    End Sub
End Class