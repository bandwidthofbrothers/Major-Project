Public Class FormMainMenu
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormSetUp(LoginForm)
    End Sub

    Friend Sub FormSetUp(ByVal ChildForm As Form)
        Try
            Me.ActiveMdiChild.Close()
        Catch ex As Exception

        End Try

        With ChildForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FormMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        FormSetUp(SearchMember)
    End Sub
End Class
