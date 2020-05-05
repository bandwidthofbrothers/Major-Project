Imports System.Data.SqlClient

Public Class MenuItems
    Public ID As Integer = 0

    Dim connection As New SqlConnection("Server=STUDENT-250JE01; Database=group22; integrated security = false")

    Private Sub MenuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.MenuItem' table. You can move, or remove it, as needed.
        Me.MenuItemTableAdapter.Fill(Me.Group22DataSet.MenuItem)



    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

        Dim ID As Integer = 0
        ID = ItemTxtbox.Text

        'MenuItemTableAdapter.Insert(ID, firstnametextbox.te, CostTxtbox.Text, CategoryBox.Text, SmallTxtbox.Text, MedTxtbox.Text, LargeTxtbox.Text)



    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click


    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click


        ' MenuItemTableAdapter.DeleteQuery()

    End Sub



End Class