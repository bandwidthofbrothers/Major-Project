Imports System.Data.SqlClient

Public Class MenuItems


    Dim connection As New SqlConnection("Server=STUDENT-250JE01; Database=group22; integrated security = false")

    Private Sub MenuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.MenuItem' table. You can move, or remove it, as needed.
        Me.MenuItemTableAdapter.Fill(Me.Group22DataSet.MenuItem)
        'TODO: This line of code loads data into the 'DataSet.MenuItem' table. You can move, or remove it, as needed.
        Me.MenuItemTableAdapter.Fill(Me.DataSet.MenuItem)
        'TODO: This line of code loads data into the 'DataSet1.CustomerOrder' table. You can move, or remove it, as needed.

        Me.MenuItemTableAdapter1.Fill(Me.DataSet1.MenuItem)


    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click






    End Sub
End Class