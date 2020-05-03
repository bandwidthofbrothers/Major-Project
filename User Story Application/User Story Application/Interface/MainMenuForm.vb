Public Class MainMenuForm

    Public Shared View As Boolean
    Public Shared Edit As Boolean
    Public Shared Search As Boolean

    Public Shared TestCaseView As Boolean
    Public Shared TestCaseSearch As Boolean
    Public Shared TestCaseDelete As Boolean

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If MenuAccessControl.DropDownItems(0).Text = "Sign Out" Then

            Dim answer As Integer

            answer = MsgBox("Are you sure you want to sign out?", vbQuestion + vbYesNo + vbDefaultButton2, "Sign Out")

            If answer = vbYes Then
                MenuMemberControl.Enabled = False
                MenuUserStoryControl.Enabled = False
                MenuTestCaseControl.Enabled = False

                closeActiveMdiChild()

                MenuAccessControl.DropDownItems(0).Text = "Login"
            End If

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
        Dim answer As Integer

        answer = MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo + vbDefaultButton2, "Exit")

        If answer = vbYes Then
            Me.Close()
        End If
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
        TestCaseView = True
        TestCaseSearch = False
        TestCaseDelete = False

        closeActiveMdiChild()
        FormSetUp(TestCaseViewSearchDeleteForm)
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

    Private Sub SearchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem1.Click
        FormSetUp(SearchUserStoryForm)
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        FormSetUp(AddTestCase)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        FormSetUp(AddTestCase)
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        TestCaseView = False
        TestCaseSearch = False
        TestCaseDelete = True

        closeActiveMdiChild()
        FormSetUp(TestCaseViewSearchDeleteForm)
    End Sub

    Private Sub SearchToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem2.Click
        TestCaseView = False
        TestCaseSearch = True
        TestCaseDelete = False

        closeActiveMdiChild()
        FormSetUp(TestCaseViewSearchDeleteForm)
    End Sub

    Private Sub EditToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem2.Click
        FormSetUp(EditTestCaseForm)
    End Sub
End Class
