Public Class FormLogin
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        EmployeeTableAdapter.FillBy(Group22DataSet.Employee, TextBoxUserName.Text, TextBoxPassword.Text)

        If Group22DataSet.Employee.Rows.Count() > 0 Then
            MessageBox.Show("Welcome! You will now be directed to the system")
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

                .AccessControlToolStripMenuItem.DropDownItems(0).Text = "Sign Out"
                .ToolTipLogin.SetToolTip(.ButtonLogin, "Sign Out")
            End With

        Else
            MessageBox.Show("Error: Incorrect Username or Password")
            TextBoxUserName.Text = ""
            TextBoxPassword.Text = ""
        End If
    End Sub

End Class
