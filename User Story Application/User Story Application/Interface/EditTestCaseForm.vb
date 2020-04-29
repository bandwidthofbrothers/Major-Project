Public Class EditTestCaseForm
    Private Sub EditTestCaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.TestCases' table. You can move, or remove it, as needed.
        Me.TestCasesTableAdapter.Fill(Me.DataSet.TestCases)
        'TODO: This line of code loads data into the 'DataSet.UserStory' table. You can move, or remove it, as needed.
        Me.UserStoryTableAdapter.Fill(Me.DataSet.UserStory)

    End Sub

    Private Sub ButtonEditTestCase_Click(sender As Object, e As EventArgs) Handles ButtonEditTestCase.Click
        Dim TestCaseNumber As Integer = TestCaseBox.SelectedValue
        Dim UserStoryNumber As Integer = ListBoxUserStory.SelectedValue

        TestCasesTableAdapter.UpdateTestCaseDetails(TestCaseDetailsTextbox.Text, TestCaseNumber, UserStoryNumber)

        MessageBox.Show("Test Case updated successfully")
        Me.TestCasesTableAdapter.Fill(Me.DataSet.TestCases)

    End Sub
End Class