Public Class EditUserStoryForm
    Private Sub EditUserStoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.UserStory' table. You can move, or remove it, as needed.
        Me.UserStoryTableAdapter.Fill(Me.DataSet.UserStory)
        'TODO: This line of code loads data into the 'DataSet.UserStory' table. You can move, or remove it, as needed.
        Me.UserStoryTableAdapter.Fill(Me.DataSet.UserStory)

    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim UserStoryNumber As Integer = ListBoxUserStory.SelectedValue

        Me.UserStoryTableAdapter.UpdateUserStory(TextBoxTitle.Text, ComboBoxUserRole.Text, TextBoxDescription.Text, DateTimePickerStartDate.Text,
                                                 DateTimePickerEndDate.Text, ComboBoxStatus.Text, ComboBoxPriority.Text, ListBoxUserStory.SelectedValue)
        MessageBox.Show("Update Successful")
        Me.UserStoryTableAdapter.Fill(Me.DataSet.UserStory)
    End Sub
End Class