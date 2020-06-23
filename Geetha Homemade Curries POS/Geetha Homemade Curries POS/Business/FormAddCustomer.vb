Public Class FormAddCustomer
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim FirstName As String = TextBoxFirstName.Text
        Dim Surname As String = TextBoxSurname.Text
        Dim PhoneNumber As String = TextBoxPhoneNumber.Text

        Dim conversionSuccessful As Boolean = False
        Dim AmountDue As Decimal = Decimal.TryParse(TextBoxAmountDue.Text, conversionSuccessful)

        If conversionSuccessful Then
            Try
                AmountDue = Decimal.Parse(TextBoxAmountDue.Text, System.Globalization.NumberFormatInfo.CurrentInfo)

                CustomerTableAdapter.insert1(FirstName, Surname, PhoneNumber, AmountDue)

                MessageBox.Show("Record added successfully")

                With FormMainMenu
                    .FormSetUp(FormMain)
                    .FormSetUp(ViewCustomers)
                End With

                Me.TopMost = True
            Catch ex As Exception
                MessageBox.Show("Error: Record added unsuccessfully")
            End Try
        Else
            MessageBox.Show("Error: Record added unsuccessfully")
        End If

        TextBoxFirstName.Text = ""
        TextBoxSurname.Text = ""
        TextBoxPhoneNumber.Text = ""
        TextBoxAmountDue.Text = ""

    End Sub
End Class