Public Class FormLogin
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If TextBoxUserName.Text = "Admin" And TextBoxPassword.Text = "Admin" Then
            MessageBox.Show("Welcome")
            Me.Close()

            With FormMainMenu
                .ButtonSale.Enabled = True
                .ButtonMenu.Enabled = True
                .ButtonReports.Enabled = True
                .ButtonAccounts.Enabled = True
                .ButtonExpenses.Enabled = True
                .ButtonStaff.Enabled = True

                With .MenuStrip
                    .Items(1).Enabled = True
                    .Items(2).Enabled = True
                    .Items(3).Enabled = True
                    .Items(4).Enabled = True
                    .Items(5).Enabled = True
                    .Items(6).Enabled = True
                End With

            End With
        End If
    End Sub
End Class
