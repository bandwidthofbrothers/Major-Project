Public Class FormSalesCheckout
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub FormSalesCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LabelTotal.Text = FormSales.totalDue.ToString("c")
    End Sub

    Private Sub ButtonProcessOrder_Click(sender As Object, e As EventArgs) Handles ButtonProcessOrder.Click
        Dim choice As DialogResult
        choice = MessageBox.Show("Process Order?", "Confirmation", MessageBoxButtons.YesNo)

        If choice = DialogResult.Yes Then

            choice = MessageBox.Show("Pay on Account?", "Account", MessageBoxButtons.YesNo)

            If choice = DialogResult.Yes Then
                FormSalesAccount.amountDue = FormSales.totalDue
                FormSalesAccount.Show()
                Me.Hide()
            Else
                processOrder()
            End If
        End If
    End Sub

    Public Sub processOrder()

        Dim employeeNumber As Integer = FormMainMenu.employeeNumber
        Dim SaleID As Integer = 0
        Dim orderTime As TimeSpan = DateTime.Now.TimeOfDay
        Dim orderDate As Date = DateTime.Now.ToShortDateString

        If CustomerOrderTableAdapter.getMaxSaleID() Is Nothing Then
            SaleID = 1
        Else
            SaleID = CustomerOrderTableAdapter.getMaxSaleID() + 1
        End If

        For Each row As DataGridViewRow In DataGridViewOrder.Rows
            Dim menuItemID As Integer = row.Cells(0).Value
            Dim quantity As Integer = row.Cells(3).Value
            'Fix Timespan conversion
            CustomerOrderTableAdapter.Insert(SaleID, menuItemID, quantity, orderDate, orderTime, employeeNumber)
        Next


        PrintDocument.Print()
        FormSales.Close()
        FormMainMenu.FormSetUp(FormSales)

        Me.Close()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim ReceiptFont As Font = New Drawing.Font("helvetica", 14)
        e.Graphics.DrawString("--------------------", ReceiptFont, Brushes.Black, 110, 100)

        Dim y As Integer = 110

        For Each row As DataGridViewRow In DataGridViewOrder.Rows
            e.Graphics.DrawString(row.Cells(1).Value.ToString, ReceiptFont, Brushes.Black, 110, y)
            y += 10
        Next

    End Sub
End Class