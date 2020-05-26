Public Class FormSales
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
        setUpPanelForm(FormSalesCategories)
    End Sub
End Class