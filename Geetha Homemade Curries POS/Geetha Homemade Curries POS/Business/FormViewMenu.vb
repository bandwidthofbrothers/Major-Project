Public Class FormViewMenu
    Private Sub FormViewMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.MenuItem' table. You can move, or remove it, as needed.
        Me.MenuItemTableAdapter.Fill(Me.Group22DataSet.MenuItem)

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            Dim MenuItemID As Integer = MenuItemDataGridView.CurrentRow.Cells(0).Value

            Me.MenuItemTableAdapter.DeleteQuery(MenuItemID)

            Me.MenuItemTableAdapter.Fill(Me.Group22DataSet.MenuItem)

            MessageBox.Show("Record deleted successfully")

        Catch ex As Exception
            MessageBox.Show("Error: Could not delete record")
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If Not TextBoxMenuItemID.Text = "" Then
            Try
                Dim ID As Integer = Integer.Parse(TextBoxMenuItemID.Text)
                Dim name As String = TextBoxName.Text
                Dim category As String = ComboBoxCategory.Text
                Dim price As Double = Double.Parse(TextBoxPrice.Text)

                MenuItemTableAdapter.Update1(name, category, price, ID)
                Me.MenuItemTableAdapter.Fill(Me.Group22DataSet.MenuItem)

                MessageBox.Show("Record updated successfully", "Update Successful")

            Catch ex As Exception
                MessageBox.Show("Error: Incorrect Format", "Error")
            End Try
        Else
            MessageBox.Show("Error: No record selected", "Error")
        End If
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        FormAddMenuItem.Show()
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        If TextBoxSearch.Text <> "" Then
            MenuItemTableAdapter.search(Group22DataSet.MenuItem, TextBoxSearch.Text)
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        MenuItemTableAdapter.Fill(Group22DataSet.MenuItem)
    End Sub

    Private Sub MenuItemDataGridView_Click(sender As Object, e As EventArgs) Handles MenuItemDataGridView.Click

    End Sub
End Class