Public Class FormSalesCheckout

    Friend customerID = 4

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

            If row.Cells(1).Value = "Delivery Fee" Then

            Else
                Dim menuItemID As Integer = row.Cells(0).Value
                Dim quantity As Integer = row.Cells(3).Value
                'Fix Timespan conversion

                Dim choice = MessageBox.Show("Is this order placed over the phone?", "Phone Order?", MessageBoxButtons.YesNo)

                Dim orderMethod As String = ""

                If choice = DialogResult.Yes Then
                    orderMethod = "Phone"
                Else
                    orderMethod = "Store"
                End If

                choice = MessageBox.Show("Is this a cash sale?", "Phone Order?", MessageBoxButtons.YesNo)
                Dim change As Double = 0

                If choice = DialogResult.Yes Then

                    Dim incorrectInput As Boolean = True

                    While incorrectInput
                        Dim check As Boolean = False
                        Dim cash As Double = Double.TryParse(InputBox("Cash:"), check)


                        If check = True Then
                            change = cash - FormSales.totalDue
                            incorrectInput = False
                        Else
                            MessageBox.Show("Error: Please enter the correct amount")
                        End If

                    End While

                    MessageBox.Show("Change: " + change.ToString("c"))
                End If

                CustomerOrderTableAdapter.Insert(SaleID, menuItemID, quantity, orderDate, orderTime, employeeNumber, "In Progress", Me.customerID, orderMethod)

                FormOrders.addMenuItems(SaleID, row.Cells(1).Value, quantity)
            End If

        Next


        PrintDocument.Print() 'For Customer

        FormSales.Close()
        FormMainMenu.FormSetUp(FormSales)

        Me.Close()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim ReceiptFont As Font = New Drawing.Font("helvetica", 14)
        e.Graphics.DrawString("     Geetha's Homemade Curries", New Drawing.Font("helvetica", 14, FontStyle.Bold), Brushes.Black, 110, 100)
        e.Graphics.DrawString("9 Nevana Court Arbee Drive, Tongaat", ReceiptFont, Brushes.Black, 100, 120)
        e.Graphics.DrawString("                 062 871 8030", ReceiptFont, Brushes.Black, 100, 140)

        e.Graphics.DrawString("==============================", ReceiptFont, Brushes.Black, 100, 180)

        Dim OrderNumber As Integer = CustomerOrderTableAdapter.getMaxSaleID

        e.Graphics.DrawString("Order Number: " + OrderNumber.ToString, ReceiptFont, Brushes.Black, 100, 200)
        e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString, ReceiptFont, Brushes.Black, 100, 220)

        e.Graphics.DrawString("==============================", ReceiptFont, Brushes.Black, 100, 240)

        Dim y As Integer = 300
        Dim format As String = "{0,-30}{1,5}{2,8}"

        e.Graphics.DrawString(String.Format("{0,-20}{1,8}{2,8}", "Product Name", "Quantity", "Price"), ReceiptFont, Brushes.Black, 100, 260)

        For Each row As DataGridViewRow In DataGridViewOrder.Rows
            Dim output As String = String.Format(format, row.Cells(1).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString())
            e.Graphics.DrawString(output, ReceiptFont, Brushes.Black, 110, y)
            y += 20
        Next

        y += 20
        e.Graphics.DrawString("----------------------------------------------------", ReceiptFont, Brushes.Black, 100, y)

        y += 25
        e.Graphics.DrawString("Total: " + LabelTotal.Text, ReceiptFont, Brushes.Black, 100, y)

        y += 25
        e.Graphics.DrawString("==============================", ReceiptFont, Brushes.Black, 100, y)

        y += 40
        e.Graphics.DrawString("Thank You!", ReceiptFont, Brushes.Black, 215, y)
    End Sub
End Class