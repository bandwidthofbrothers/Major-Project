Public Class FormSalesCategories

    Dim currentCategory As String = ""

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

    Private Sub PictureBoxDrinks_Click(sender As Object, e As EventArgs) Handles PictureBoxDrinks.Click
        setUpPanelForm(FormSalesDrinks)
    End Sub

    Private Sub PictureBoxDishes_Click(sender As Object, e As EventArgs) Handles PictureBoxDishes.Click
        setUpPanelForm(FormSalesDishes)
    End Sub

    Private Sub PictureBoxBriyani_Click(sender As Object, e As EventArgs) Handles PictureBoxBriyani.Click
        currentCategory = "Briyani"
        setUpPanelForm(FormSalesItems)
    End Sub
End Class