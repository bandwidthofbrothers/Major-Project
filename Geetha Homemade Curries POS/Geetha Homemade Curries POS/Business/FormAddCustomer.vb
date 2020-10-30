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

        Dim conversionSuccessful2 As Boolean = False
        Dim AmountCap As Decimal = Decimal.TryParse(TextBoxAmountCap.Text, conversionSuccessful2)

        Dim PhysicalAddress As String = TextBoxPhysicalAddress.Text
        Dim EmailAddress As String = TextBoxEmailAddress.Text
        Dim Password As String = TextBoxPassword.Text

        If (conversionSuccessful2 = True) And (conversionSuccessful = True) And (TextBoxPhoneNumber.Text <> "") And (TextBoxFirstName.Text <> "") And (TextBoxSurname.Text <> "") Then
            Try
                AmountDue = Decimal.Parse(TextBoxAmountDue.Text, System.Globalization.NumberFormatInfo.CurrentInfo)
                AmountCap = Decimal.Parse(TextBoxAmountCap.Text, System.Globalization.NumberFormatInfo.CurrentInfo)

                CustomerTableAdapter.insert1(FirstName, Surname, PhoneNumber, AmountDue, AmountCap, PhysicalAddress, EmailAddress, Password)

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
            MessageBox.Show("Error: Record added unsuccessfully. Ensure Fields are not blank")
        End If

    End Sub
End Class