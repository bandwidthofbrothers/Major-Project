Public Class FormViewExpenses
    Private Sub IngredientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.IngredientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group22DataSet)

    End Sub

    Private Sub FormViewExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.Ingredient' table. You can move, or remove it, as needed.
        Me.IngredientTableAdapter.Fill(Me.Group22DataSet.Ingredient)
        'TODO: This line of code loads data into the 'Group22DataSet.Ingredient' table. You can move, or remove it, as needed.
        Me.IngredientTableAdapter.Fill(Me.Group22DataSet.Ingredient)

    End Sub

    Private Sub IngredientBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.IngredientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group22DataSet)

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            Dim IngredientID As Integer = IngredientDataGridView.CurrentRow.Cells(0).Value

            IngredientTableAdapter.DeleteIngredient(IngredientID)

            IngredientTableAdapter.Fill(Me.Group22DataSet.Ingredient)

            MessageBox.Show("Record deleted successfully")

        Catch ex As Exception
            MessageBox.Show("Error: Could not delete record")
        End Try
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        FormAddExpense.Show()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs)
        Me.Close()


    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If Not TextBoxIngredientID.Text = "" Then
            Try
                Dim ID As Integer = Integer.Parse(TextBoxIngredientID.Text)
                Dim description As String = TextBoxDescription.Text
                Dim datePurchased As String = DateTimePicker.Text
                Dim cost As Double = Double.Parse(TextBoxCost.Text)

                IngredientTableAdapter.UpdateIngredient(description, cost, datePurchased, ID)
                IngredientTableAdapter.Fill(Me.Group22DataSet.Ingredient)

                MessageBox.Show("Record updated successfully", "Update Successful")

            Catch ex As Exception
                MessageBox.Show("Error: Incorrect Format", "Error")
            End Try
        Else
            MessageBox.Show("Error: No record selected", "Error")
        End If
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        If TextBoxSearch.Text <> "" Then
            IngredientTableAdapter.search(Group22DataSet.Ingredient, TextBoxSearch.Text)
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        IngredientTableAdapter.Fill(Group22DataSet.Ingredient)
        TextBoxSearch.Text = ""
    End Sub
End Class