Public Class FormAddExpense
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim description As String = TextBoxDescription.Text
        Dim datePurchased As String = DateTimePicker.Text

        Dim conversionSuccessful As Boolean = False
        Dim cost As Decimal = Decimal.TryParse(TextBoxCost.Text, conversionSuccessful)

        If conversionSuccessful Then
            Try
                cost = Decimal.Parse(TextBoxCost.Text, System.Globalization.NumberFormatInfo.CurrentInfo)
                MessageBox.Show(cost)
                IngredientTableAdapter.InsertIngredient(description, cost, datePurchased)

                MessageBox.Show("Record added successfully")

                With FormViewExpenses
                    .IngredientTableAdapter.Fill(Me.Group22DataSet.Ingredient)
                End With
            Catch ex As Exception
                MessageBox.Show("Error: Record added unsuccessfully")
            End Try
        Else
            MessageBox.Show("Error: Record added unsuccessfully")
        End If

        TextBoxDescription.Text = ""
        TextBoxCost.Text = ""

    End Sub
End Class