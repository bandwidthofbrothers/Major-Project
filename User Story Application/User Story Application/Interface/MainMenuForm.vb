Public Class MainMenuForm

    Public Shared View As Boolean
    Public Shared Edit As Boolean
    Public Shared Search As Boolean

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If MenuAccessControl.DropDownItems(0).Text = "Sign Out" Then
            MenuMemberControl.Enabled = False
            MenuUserStoryControl.Enabled = False
            MenuTestCaseControl.Enabled = False

            closeActiveMdiChild()

            MenuAccessControl.DropDownItems(0).Text = "Login"
        Else
            FormSetUp(LoginForm)
        End If
    End Sub

    Friend Sub FormSetUp(ByVal ChildForm As Form)

        If Not ChildForm.IsMdiChild Then

            closeActiveMdiChild()

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
        View = True
        Edit = False
        Search = False

        closeActiveMdiChild()
        FormSetUp(MemberControlForm)
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        FormSetUp(ViewUserStoryForm)
    End Sub

    Private Sub ViewToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem2.Click
        FormSetUp(Test_Cases)
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Search = True
        View = False
        Edit = False

        closeActiveMdiChild()
        FormSetUp(MemberControlForm)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Edit = True
        View = False
        Search = False

        closeActiveMdiChild()
        FormSetUp(MemberControlForm)
    End Sub

    Private Sub closeActiveMdiChild()
        Try
            Me.ActiveMdiChild.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        FormSetUp(UserStoryForm)
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        FormSetUp(EditUserStoryForm)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        FormSetUp(DeleteUserStoryForm)
    End Sub
End Class
