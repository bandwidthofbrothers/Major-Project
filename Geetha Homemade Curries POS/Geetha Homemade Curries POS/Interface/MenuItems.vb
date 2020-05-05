Imports System.Data.SqlClient

Public Class MenuItems


    Private Sub MenuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.MenuItem' table. You can move, or remove it, as needed.
        Me.MenuItemTableAdapter.Fill(Me.Group22DataSet.MenuItem)



    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

        Dim ID As Integer = 0
        ID = ItemTxtbox.Text

        MenuItemTableAdapter.Insert(ID, NameTxtbox.Text, CostTxtbox.Text, CategoryBox.Text, SmallTxtbox.Text, MedTxtbox.Text, LargeTxtbox.Text)



    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click


    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        Dim index As Integer
        index = DataGridView1.CurrentCell.RowIndex
        DataGridView1.Rows.RemoveAt(index)

    End Sub

    Private Sub CostTxtbox_TextChanged(sender As Object, e As EventArgs) Handles CostTxtbox.TextChanged

    End Sub
End Class