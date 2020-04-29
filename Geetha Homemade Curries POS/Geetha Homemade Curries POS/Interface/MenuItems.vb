Public Class MenuItems
    Private Sub MenuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.MenuItem' table. You can move, or remove it, as needed.
        Me.MenuItemTableAdapter.Fill(Me.DataSet.MenuItem)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class