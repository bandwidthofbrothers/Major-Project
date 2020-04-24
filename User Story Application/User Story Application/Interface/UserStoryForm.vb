Public Class UserStoryForm
    Private Sub UserStoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAMember.Fill(DSUserStory.Member)
    End Sub

    Private Sub ButtonRecordUserStory_Click(sender As Object, e As EventArgs) Handles ButtonRecordUserStory.Click
        Dim UserStoryNumber As Integer
        UserStoryNumber = TAUserStory.InsertUserStory(TextBoxUserStoryTitle.Text, ComboBoxUserRole.SelectedItem, TextBoxUserStoryDescription.Text,
                                                      DateTimePickerStartDate.Text, DateTimePickerEndDate.Text, ComboBoxStatus.SelectedItem, ComboBoxPriority.SelectedItem)

        TAUserMember.Insert(UserStoryNumber, ComboBoxProg1Name.SelectedValue, ComboBoxProg1Responsibility.SelectedItem)
        TAUserMember.Insert(UserStoryNumber, ComboBoxProg2Name.SelectedValue, ComboBoxProg2Responsibility.SelectedItem)

        Dim i As Integer = 0
        For i = 0 To ListBoxNewTestCaseDetails.Items.Count - 1
            TATestCase.Insert1(ListBoxNewTestCaseDetails.Items(i), UserStoryNumber)
        Next

    End Sub
End Class