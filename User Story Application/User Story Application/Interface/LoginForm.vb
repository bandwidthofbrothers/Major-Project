Public Class LoginForm

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        MemberTableAdapter.FillBy(DataSetUserStory.Member, TextBoxUserName.Text, TextBoxPassword.Text)
        If DataSetUserStory.Member.Rows.Count > 0 Then
            MessageBox.Show("Welcome! You will now be directed to the system")

            With FormMainMenu
                .MenuMemberControl.Enabled = True
                .MenuUserStoryControl.Enabled = True
                .MenuTestCaseControl.Enabled = True
                .MenuAccessControl.DropDownItems(0).Text = "Sign Out"
            End With

            Me.Close()
        Else
            MessageBox.Show("Invalid User Details")
        End If
    End Sub
End Class