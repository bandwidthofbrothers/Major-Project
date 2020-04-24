Public Class UserStoryForm
    Private Sub UserStoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAMember.Fill(DSUserStory.Member)
    End Sub

    Private Sub ButtonRecordUserStory_Click(sender As Object, e As EventArgs) Handles ButtonRecordUserStory.Click

    End Sub
End Class