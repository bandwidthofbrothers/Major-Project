Public Class FormAddCustomer
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Try
            Dim FirstName As String = TextBoxFirstName.Text
            Dim Surname As String = TextBoxSurname.Text
            Dim PhoneNumber As String = TextBoxPhoneNumber.Text

            Dim AmountDue As Decimal = Convert.ToDecimal(TextBoxAmountDue.Text)
            Dim AmountCap As Decimal = Convert.ToDecimal(TextBoxAmountCap.Text)

            Dim PhysicalAddress As String = TextBoxPhysicalAddress.Text
            Dim EmailAddress As String = TextBoxEmailAddress.Text
            Dim Password As String = TextBoxPassword.Text

            If (TextBoxPhoneNumber.Text <> "") And (TextBoxFirstName.Text <> "") And (TextBoxSurname.Text <> "") Then
                Try
                    AmountDue = Decimal.Parse(TextBoxAmountDue.Text, System.Globalization.NumberFormatInfo.CurrentInfo)
                    AmountCap = Decimal.Parse(TextBoxAmountCap.Text, System.Globalization.NumberFormatInfo.CurrentInfo)

                    CustomerTableAdapter.insert1(FirstName, Surname, PhoneNumber, AmountDue, AmountCap, PhysicalAddress, EmailAddress, Password)

                    MessageBox.Show("Record added successfully")

                    With FormMainMenu
                        .FormSetUp(FormMain)
                        .FormSetUp(ViewCustomers)
                    End With

                    TextBoxFirstName.Text = ""
                    TextBoxSurname.Text = ""
                    TextBoxPhoneNumber.Text = ""
                    TextBoxAmountDue.Text = ""
                    TextBoxAmountCap.Text = ""
                    TextBoxPhysicalAddress.Text = ""
                    TextBoxEmailAddress.Text = ""
                    TextBoxPassword.Text = ""

                    Me.TopMost = True

                Catch ex As Exception
                    MessageBox.Show("Error: Record added unsuccessfully")
                End Try
            Else
                MessageBox.Show("Error: Record added unsuccessfully. Ensure Fields are not blank")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Please enter valid fields")
        End Try

    End Sub
End Class