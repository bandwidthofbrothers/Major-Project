Imports System.Data.SqlClient
Public Class FormMenu

    Dim connection As New SqlConnection("Data Source=146.230.177.46\IST3;Initial Catalog=group22;Persist Security Info=True;User ID=group22;Password=n24mc")

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        'connection.Open()

        command.ExecuteNonQuery()

        connection.Close()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection.Open()

        Dim adapter As New SqlDataAdapter("SELECT * FROM MenuItem", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        ItemTxtbox.Text = selectedRow.Cells(0).Value.ToString()
        NameTxtbox.Text = selectedRow.Cells(1).Value.ToString()
        CategoryTxtbox.Text = selectedRow.Cells(2).Value.ToString()
        PriceTxtbox.Text = selectedRow.Cells(3).Value.ToString()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

        Dim insertQuery As String = "INSERT INTO MenuItem(MenuItemID, MenuItemName, Category, MenuItemPrice) VALUES('" & ItemTxtbox.Text & "', '" & NameTxtbox.Text & "', '" & CategoryTxtbox.Text & "', '" & PriceTxtbox.Text & "')"

        ExecuteQuery(insertQuery)

        MessageBox.Show("Item added")
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click

        Dim updateQuery As String = "UPDATE MenuItem SET MenuItemName = '" & NameTxtbox.Text & "', Category = '" & CategoryTxtbox.Text & "', MenuItemPrice = '" & PriceTxtbox.Text & "' WHERE MenuItemID = '" & ItemTxtbox.Text & "'"

        ExecuteQuery(updateQuery)

        MessageBox.Show("Item updated")

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        Dim deleteQuery As String = "DELETE FROM MenuItem WHERE MenuItemID = '" & ItemTxtbox.Text & "'"

        ExecuteQuery(deleteQuery)

        MessageBox.Show("Item deleted")


    End Sub
End Class