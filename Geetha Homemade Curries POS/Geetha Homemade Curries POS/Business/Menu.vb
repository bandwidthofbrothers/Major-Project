Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.MenuItem' table. You can move, or remove it, as needed.
        Me.MenuItemTableAdapter.Fill(Me.Group22DataSet.MenuItem)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        ItemTxtbox.Text = selectedRow.Cells(0).Value.ToString()
        NameTxtbox.Text = selectedRow.Cells(1).Value.ToString()
        CategoryBox.Text = selectedRow.Cells(2).Value.ToString()
        PriceTxtbox.Text = selectedRow.Cells(3).Value.ToString()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

    End Sub
End Class