Imports System.Web.Script.Serialization

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

            Dim choice2 As DialogResult = MessageBox.Show("Is this order a delivery?", "Delivery", MessageBoxButtons.YesNo)

            If choice2 = DialogResult.Yes Then
                Dim address As String = InputBox("Please enter the address", "Delivery")

                Dim from As String = "-29.572574, 31.115193"
                Dim Destination As String = address

                Dim webClient As New System.Net.WebClient
                Dim result As String = webClient.DownloadString("https://api.distancematrix.ai/maps/api/distancematrix/json?origins=" + from + "&destinations=" + Destination + "&key=ctU1PkJH0wJAaWD1EM3ivMZ0FmfuI")

                Try
                    Dim j As Object = New JavaScriptSerializer().Deserialize(Of Object)(result)

                    Dim distance As String = j("rows")(0)("elements")(0)("distance")("value")

                    Dim deliveryDistance As Double
                    deliveryDistance = Double.Parse(distance) / 1000

                    Dim deliveryFee = 0.0

                    If deliveryDistance < 0.5 Then
                        deliveryFee = 5
                    ElseIf deliveryDistance < 1 Then
                        deliveryFee = 10
                    ElseIf deliveryDistance < 1.5 Then
                        deliveryFee = 15
                    ElseIf deliveryDistance < 2 Then
                        deliveryFee = 20
                    ElseIf deliveryDistance > 2 Then
                        deliveryFee = 25
                    End If

                    FormSalesCheckout.DataGridViewOrder.Rows.Add(0, "Delivery Fee", deliveryFee, 1, deliveryFee)

                    Me.totalDue += deliveryFee
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If

            FormSalesCheckout.Show()
        End If
    End Sub
End Class