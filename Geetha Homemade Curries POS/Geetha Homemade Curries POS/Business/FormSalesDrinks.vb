Public Class FormSalesDrinks

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

    Private Sub PictureBoxHotDrinks_Click(sender As Object, e As EventArgs) Handles PictureBoxHotDrinks.Click
        setUpSalesItemsForm("Hot Drinks")
    End Sub

    Private Sub PictureBoxColdDrinks_Click(sender As Object, e As EventArgs) Handles PictureBoxColdDrinks.Click
        setUpSalesItemsForm("Cold Drinks")
    End Sub

End Class