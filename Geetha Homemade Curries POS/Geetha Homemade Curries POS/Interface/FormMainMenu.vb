Public Class FormMainMenu

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
        If LoginToolStripMenuItem.Text = "Login" Then
            FormLogin.Show()
        Else
            SignOut()
        End If
    End Sub

    Private Sub ButtonReports_Click(sender As Object, e As EventArgs) Handles ButtonReports.Click
        FormSetUp(FormReports)
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Dim answer As Integer

        answer = MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo + vbDefaultButton2, "Exit")

        If answer = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If LoginToolStripMenuItem.Text = "Login" Then
            FormLogin.Show()
        Else
            SignOut()
        End If

    End Sub

    Private Sub SignOut()
        Dim answer As Integer

        answer = MsgBox("Are you sure you want to sign out?", vbQuestion + vbYesNo + vbDefaultButton2, "Sign out")

        If answer = vbYes Then
            ButtonSale.Enabled = False
            ButtonMenu.Enabled = False
            ButtonReports.Enabled = False
            ButtonAccounts.Enabled = False
            ButtonExpenses.Enabled = False
            ButtonStaff.Enabled = False

            With MenuStrip
                .Items(1).Enabled = False
                .Items(2).Enabled = False
                .Items(3).Enabled = False
                .Items(4).Enabled = False
                .Items(5).Enabled = False
                .Items(6).Enabled = False
            End With

            LoginToolStripMenuItem.Text = "Login"
            ToolTipLogin.SetToolTip(Me.ButtonLogin, "Login")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim answer As Integer

        answer = MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo + vbDefaultButton2, "Exit")

        If answer = vbYes Then
            Me.Close()
        End If
    End Sub
End Class