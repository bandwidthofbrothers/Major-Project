Public Class DeleteUserStoryForm
    Private Sub DeleteUserStoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.UserStory' table. You can move, or remove it, as needed.
        Me.UserStoryTableAdapter.Fill(Me.DataSet.UserStory)

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            Dim UserStoryNumber As Integer = 0
            UserStoryNumber = UserStoryDataGridView.CurrentRow.Cells(0).Value

            UserStory_MemberTableAdapter.DeleteUserStory_Member(UserStoryNumber)
            TestCasesTableAdapter.DeleteTestCase(UserStoryNumber)
            UserStoryTableAdapter.DeleteUserStory(UserStoryNumber)

            Me.UserStoryTableAdapter.Fill(Me.DataSet.UserStory)
        Catch ex As Exception
            MessageBox.Show("Error: Please select a user story")
        End Try
    End Sub
End Class