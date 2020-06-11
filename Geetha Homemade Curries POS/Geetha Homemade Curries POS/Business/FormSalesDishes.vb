Public Class FormSalesDishes


    Private Sub setUpPanelForm(form As Form)
        Try
            With FormSales
                .Panel.Controls.Clear()
                form.TopLevel = False
                .Panel.Controls.Add(form)
                form.Show()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub setUpSalesItemsForm(category As String)
        FormSales.currentCategory = category
        setUpPanelForm(FormSalesItems)
    End Sub

    Private Sub PictureBoxVegDishes_Click(sender As Object, e As EventArgs) Handles PictureBoxVegDishes.Click
        setUpSalesItemsForm("Veg Dishes")
    End Sub

    Private Sub PictureBoxNonVegDishes_Click(sender As Object, e As EventArgs) Handles PictureBoxNonVegDishes.Click
        setUpSalesItemsForm("Non-Veg Dishes")
    End Sub

End Class