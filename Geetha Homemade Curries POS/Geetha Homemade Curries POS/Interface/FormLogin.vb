Public Class FormLogin
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        EmployeeTableAdapter.FillBy(Group22DataSet.Employee, TextBoxUserName.Text, TextBoxPassword.Text)

        Dim userName As String = TextBoxUserName.Text
        Dim jobTitle As String = EmployeeTableAdapter.getJobTitle(userName)

        If jobTitle = "Former Employee" Then
            MessageBox.Show("You are no longer permitted to access the system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Group22DataSet.Employee.Rows.Count() > 0 Then
            MessageBox.Show("Welcome! You will now be directed to the system")
            Me.Close()


            Dim employeeNumber As Integer = EmployeeTableAdapter.getEmployeeNumber(userName)

            FormMainMenu.employeeNumber = employeeNumber

            If jobTitle = "Manager" Or jobTitle = "Administrator" Then
                With FormMainMenu
                    .ButtonSale.Enabled = True
                    .ButtonSale.Visible = True
                    .ButtonMenu.Enabled = True
                    .ButtonMenu.Visible = True
                    .ButtonReports.Enabled = True
                    .ButtonReports.Visible = True
                    .ButtonAccounts.Enabled = True
                    .ButtonAccounts.Visible = True
                    .ButtonExpenses.Enabled = True
                    .ButtonExpenses.Visible = True
                    .ButtonStaff.Enabled = True
                    .ButtonStaff.Visible = True

                    With .MenuStrip
                        .Items(1).Enabled = True
                        .Items(1).Visible = True
                        .Items(2).Enabled = True
                        .Items(2).Visible = True
                        .Items(3).Enabled = True
                        .Items(3).Visible = True
                        .Items(4).Enabled = True
                        .Items(4).Visible = True
                        .Items(5).Enabled = True
                        .Items(5).Visible = True
                        .Items(6).Enabled = True
                        .Items(6).Visible = True
                    End With

                    .AccessControlToolStripMenuItem.DropDownItems(0).Text = "Sign Out"
                    .ToolTipLogin.SetToolTip(.ButtonLogin, "Sign Out")

                End With
            Else
                With FormMainMenu
                    .ButtonSale.Enabled = True
                    .ButtonSale.Visible = True

                    With .MenuStrip
                        .Items(1).Enabled = True
                        .Items(1).Visible = True
                    End With

                    .AccessControlToolStripMenuItem.DropDownItems(0).Text = "Sign Out"
                    .ToolTipLogin.SetToolTip(.ButtonLogin, "Sign Out")

                End With
            End If

        Else
            MessageBox.Show("Error: Incorrect Username or Password")
            TextBoxUserName.Text = ""
            TextBoxPassword.Text = ""
        End If
    End Sub

End Class
