Public Class FormMainMenu
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormSetUp(LoginForm)
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
End Class
