Public Class FormSalesCurries
    Private Sub PictureBoxVegCurries_Click(sender As Object, e As EventArgs) Handles PictureBoxVegCurries.Click
        setUpSalesItemsForm("Veg Curry")
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

    Private Sub PictureBoxNonVegCurries_Click(sender As Object, e As EventArgs) Handles PictureBoxNonVegCurries.Click
        setUpSalesItemsForm("Non-Veg Curries")
    End Sub

End Class