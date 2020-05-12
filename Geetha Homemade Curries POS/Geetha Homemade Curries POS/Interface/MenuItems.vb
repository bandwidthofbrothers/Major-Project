Imports System.Data.SqlClient

Public Class MenuItems

    Dim index As Integer

    Private Sub MenuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.MenuItem' table. You can move, or remove it, as needed.
        Me.MenuItemTableAdapter.Fill(Me.Group22DataSet.MenuItem)



    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        'Dim ID As Integer
        'ID = ItemTxtbox.Text 





        ' MenuItemTableAdapter.Insert(ID, NameTxtbox.Text, CostTxtbox.Text, CategoryBox.Text, SmallTxtbox.Text, MedTxtbox.Text, LargeTxtbox.Text)

    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Try
            Dim ID As Integer = Integer.Parse(ItemTxtbox.Text)
            Dim name As String = NameTxtbox.Text
            Dim cost As Double = Double.Parse(CostTxtbox.Text)
            Dim category As String = CategoryBox.Text
            Dim small As Double = Double.Parse(SmallTxtbox.Text)
            Dim medium As Double = Double.Parse(MedTxtbox.Text)
            Dim large As Double = Double.Parse(LargeTxtbox.Text)

            'MenuItemTableAdapter.UpdateQuery(name, cost, category, small, medium, large, ID)

            MessageBox.Show("Record updated successfully")
        Catch ex As Exception
            MessageBox.Show("Error: Could not update record")
        End Try

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        Try
            Dim ItemID As Integer = DataGridView1.CurrentRow.Cells(0).Value

            'MenuItemTableAdapter.DeleteQuery(ItemID)

            MenuItemTableAdapter.Fill(Me.Group22DataSet.MenuItem)

            MessageBox.Show("Record deleted successfully")

        Catch ex As Exception
            MessageBox.Show("Error: Could not delete record")
        End Try





    End Sub

    Private Sub CostTxtbox_TextChanged(sender As Object, e As EventArgs) Handles CostTxtbox.TextChanged

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        ItemTxtbox.Text = selectedRow.Cells(0).Value.ToString()
        NameTxtbox.Text = selectedRow.Cells(1).Value.ToString()
        CostTxtbox.Text = selectedRow.Cells(2).Value.ToString()
        CategoryBox.Text = selectedRow.Cells(3).Value.ToString()
        SmallTxtbox.Text = selectedRow.Cells(4).Value.ToString()
        MedTxtbox.Text = selectedRow.Cells(5).Value.ToString()
        LargeTxtbox.Text = selectedRow.Cells(6).Value.ToString()


    End Sub

End Class