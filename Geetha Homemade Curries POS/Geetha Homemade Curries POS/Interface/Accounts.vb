Public Class Accounts
    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Group22DataSet.Customer)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub AddCustBtn_Click(sender As Object, e As EventArgs) Handles AddCustBtn.Click
        Dim ID As Integer = 0
        ID = CustomerIDTextBox.Text

        CustomerTableAdapter.Insert(ID, FirstNameTextBox.Text, SurnameTextBox.Text, PhoneNumberTextBox.Text, AmountDueTextBox.Text)
    End Sub

    Private Sub UptCustBtn_Click(sender As Object, e As EventArgs) Handles UptCustBtn.Click
        Try
            Me.Validate()
            Me.CustomerBindingSource.EndEdit()
            Me.CustomerTableAdapter.Update(Me.Group22DataSet.MenuItem)
            MsgBox("Update successful")

        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub
End Class