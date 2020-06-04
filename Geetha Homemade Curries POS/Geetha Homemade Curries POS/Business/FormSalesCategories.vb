Public Class FormSalesCategories

    Private Sub PictureBoxCurries_Click(sender As Object, e As EventArgs) Handles PictureBoxCurries.Click
        setUpPanelForm(FormSalesCurries)
    End Sub

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

    Private Sub PictureBoxDrinks_Click(sender As Object, e As EventArgs) Handles PictureBoxDrinks.Click
        setUpPanelForm(FormSalesDrinks)
    End Sub

    Private Sub PictureBoxDishes_Click(sender As Object, e As EventArgs) Handles PictureBoxDishes.Click
        setUpPanelForm(FormSalesDishes)
    End Sub

    Private Sub PictureBoxBriyani_Click(sender As Object, e As EventArgs) Handles PictureBoxBriyani.Click
        setUpSalesItemsForm("Briyani")
    End Sub

    Private Sub PictureBoxBunnies_Click(sender As Object, e As EventArgs) Handles PictureBoxBunnies.Click
        setUpSalesItemsForm("Bunnies")
    End Sub

    Private Sub PictureBoxChutney_Click(sender As Object, e As EventArgs) Handles PictureBoxChutney.Click
        setUpSalesItemsForm("Chutney")
    End Sub

    Private Sub PictureBoxExtraSides_Click(sender As Object, e As EventArgs) Handles PictureBoxExtraSides.Click
        setUpSalesItemsForm("Extras/Sides")
    End Sub

    Private Sub PictureBoxPasta_Click(sender As Object, e As EventArgs) Handles PictureBoxPasta.Click
        setUpSalesItemsForm("Pasta")
    End Sub

    Private Sub PictureBoxRegulars_Click(sender As Object, e As EventArgs) Handles PictureBoxRegulars.Click
        setUpSalesItemsForm("Regulars")
    End Sub

    Private Sub PictureBoxRotiRolls_Click(sender As Object, e As EventArgs) Handles PictureBoxRotiRolls.Click
        setUpSalesItemsForm("Roti Rolls")
    End Sub

    Private Sub PictureBoxSpecials_Click(sender As Object, e As EventArgs) Handles PictureBoxSpecials.Click
        setUpSalesItemsForm("Specials")
    End Sub

    Private Sub PictureBoxToastedSandwiches_Click(sender As Object, e As EventArgs) Handles PictureBoxToastedSandwiches.Click
        setUpSalesItemsForm("Toasted Sandwiches")
    End Sub
End Class