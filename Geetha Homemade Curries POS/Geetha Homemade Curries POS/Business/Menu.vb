Imports System.Data.SqlClient
Public Class Menu

    Dim connection As New SqlConnection("Data Source=146.230.177.46\IST3;Initial Catalog=group22;Persist Security Info=True;User ID=group22;Password=***********")
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection.Open()

        Dim adapter As New SqlDataAdapter("SELECT * FROM MenuItems", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

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