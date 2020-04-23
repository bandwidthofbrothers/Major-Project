Public Class ViewingUserStory
    Private Sub ViewingUserStory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.UserStory_Member' table. You can move, or remove it, as needed.
        Me.UserStory_MemberTableAdapter.Fill(Me.Group22DataSet.UserStory_Member)
        'TODO: This line of code loads data into the 'Group22DataSet.TestCases' table. You can move, or remove it, as needed.
        Me.TestCasesTableAdapter.Fill(Me.Group22DataSet.TestCases)
        'TODO: This line of code loads data into the 'Group22DataSet.UserStory' table. You can move, or remove it, as needed.
        Me.UserStoryTableAdapter.Fill(Me.Group22DataSet.UserStory)

    End Sub
End Class