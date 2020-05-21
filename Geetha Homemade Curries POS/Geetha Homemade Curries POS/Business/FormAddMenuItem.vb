Public Class FormAddMenuItem
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim name As String = TextBoxName.Text
        Dim category As String = ComboBoxCategory.Text

        Dim conversionSuccessful As Boolean = False
        Dim price As Decimal = Decimal.TryParse(TextBoxPrice.Text, conversionSuccessful)

        If conversionSuccessful Then
            Try
                price = Decimal.Parse(TextBoxPrice.Text, System.Globalization.NumberFormatInfo.CurrentInfo)

                MenuItemTableAdapter.InsertMenuItem(name, category, price)

                MessageBox.Show("Record added successfully")

                With FormViewExpenses
                    .IngredientTableAdapter.Fill(Me.Group22DataSet.Ingredient)
                    .Refresh()
                End With
            Catch ex As Exception
                MessageBox.Show("Error: Record added unsuccessfully")
            End Try
        Else
            MessageBox.Show("Error: Record added unsuccessfully")
        End If

        TextBoxName.Text = ""
        TextBoxPrice.Text = ""

    End Sub
End Class