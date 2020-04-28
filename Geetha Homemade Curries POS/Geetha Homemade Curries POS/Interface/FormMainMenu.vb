Public Class FormMainMenu
    Private Sub AccessControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccessControlToolStripMenuItem.Click
        FormLogin.Show()
    End Sub

    Private Sub FormMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormSetUp(FormMain)
    End Sub

    Public Sub FormSetUp(ChildForm As Form)
        Try
            If ActiveMdiChild.Name <> ChildForm.Name Then
                Me.ActiveMdiChild.Close()
            End If
        Catch ex As Exception

        End Try

        With ChildForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        FormLogin.Show()
    End Sub

    Private Sub ButtonReports_Click(sender As Object, e As EventArgs) Handles ButtonReports.Click
        FormSetUp(FormReports)
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class