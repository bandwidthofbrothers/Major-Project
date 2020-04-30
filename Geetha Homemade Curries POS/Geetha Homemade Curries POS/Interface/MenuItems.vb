Imports System.Data.SqlClient

Public Class MenuItems


    Dim connection As New SqlConnection("Server=146.230.177.46\IST3; Database=group22; Integrated Security=true")

    Private Sub MenuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim command As New SqlCommand("", connection)
    End Sub
End Class