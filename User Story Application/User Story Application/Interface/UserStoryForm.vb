Public Class UserStoryForm
    Private Sub UserStoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAMember.Fill(DSUserStory.Member)
    End Sub
End Class