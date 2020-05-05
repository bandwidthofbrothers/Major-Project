Imports System.Data.SqlClient

Public Class MenuItems


    Private Sub MenuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.MenuItem' table. You can move, or remove it, as needed.
        Me.MenuItemTableAdapter.Fill(Me.Group22DataSet.MenuItem)



    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim ID As Integer
        ID = ItemTxtbox.Text


        ' MenuItemTableAdapter.Insert(ID, NameTxtbox.Text, CostTxtbox.Text, CategoryBox.Text, SmallTxtbox.Text, MedTxtbox.Text, LargeTxtbox.Text)

    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If Not ItemTxtbox.Text = "" Then
            Try
                Dim ID As Integer = Integer.Parse(ItemTxtbox.Text)
                Dim name As String = NameTxtbox.Text
                Dim cost As Double = Double.Parse(CostTxtbox.Text)
                Dim category As String = CategoryBox.Text
                Dim SPrice As Double = Double.Parse(SmallTxtbox.Text)
                Dim MPrice As Double = Double.Parse(MedTxtbox.Text)
                Dim LPrice As Double = Double.Parse(LargeTxtbox.Text)
                MenuItemTableAdapter.UpdateQuery(ID, name, cost, category, SPrice, MPrice, LPrice)
                MenuItemTableAdapter.Fill(Me.Group22DataSet.MenuItem)

                MessageBox.Show("Record updated successfully", "Update Successful")

            Catch ex As Exception
                MessageBox.Show("Error: Incorrect Format", "Error")
            End Try
        Else
            MessageBox.Show("Error: No record selected", "Error")
        End If

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        Try
            Dim ItemID As Integer = DataGridView1.CurrentRow.Cells(0).Value

            MenuItemTableAdapter.DeleteQuery(ItemID)

            MenuItemTableAdapter.Fill(Me.Group22DataSet.MenuItem)

            MessageBox.Show("Record deleted successfully")

        Catch ex As Exception
            MessageBox.Show("Error: Could not delete record")
        End Try





    End Sub

    Private Sub CostTxtbox_TextChanged(sender As Object, e As EventArgs) Handles CostTxtbox.TextChanged

    End Sub
End Class