Imports System.Data.SqlClient

Public Class Accounts

    Dim connection As New SqlConnection

    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Group22DataSet.Customer)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DltCustBtn_Click(sender As Object, e As EventArgs) Handles DltCustBtn.Click

    End Sub
End Class