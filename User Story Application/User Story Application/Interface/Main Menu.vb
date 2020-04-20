Public Class FormMainMenu
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If MenuAccessControl.DropDownItems(0).Text = "Sign Out" Then
            MenuMemberControl.Enabled = False
            MenuUserStoryControl.Enabled = False
            MenuTestCaseControl.Enabled = False

            MenuAccessControl.DropDownItems(0).Text = "Login"
        Else
            FormSetUp(LoginForm)
        End If
    End Sub

    Friend Sub FormSetUp(ByVal ChildForm As Form)

        If Not ChildForm.IsMdiChild Then

            Try
                Me.ActiveMdiChild.Close()
            Catch ex As Exception

            End Try

            With ChildForm
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With

        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        FormSetUp(MemberControlForm)
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        FormSetUp(UserStory)
    End Sub
End Class
