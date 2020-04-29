Public Class EditUserStoryForm
    Private Sub EditUserStoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.UserStory' table. You can move, or remove it, as needed.
        Me.UserStoryTableAdapter.Fill(Me.DataSet.UserStory)
        'TODO: This line of code loads data into the 'DataSet.UserStory' table. You can move, or remove it, as needed.
        Me.UserStoryTableAdapter.Fill(Me.DataSet.UserStory)

    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        'UserStoryBindingSource.EndEdit()
        'UserStoryTableAdapter.Update(DataSet)

        MessageBox.Show("Update Successful")
    End Sub
End Class