Public Class ViewUserStoryForm
    Private Sub UserStoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UserStoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub ViewUserStoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.DataSet1.Member)
        'TODO: This line of code loads data into the 'DataSet.UserStory_Member' table. You can move, or remove it, as needed.
        Me.UserStory_MemberTableAdapter.Fill(Me.DataSet.UserStory_Member)
        'TODO: This line of code loads data into the 'DataSet.TestCases' table. You can move, or remove it, as needed.
        Me.TestCasesTableAdapter.Fill(Me.DataSet.TestCases)
        'TODO: This line of code loads data into the 'DataSet.UserStory' table. You can move, or remove it, as needed.
        Me.UserStoryTableAdapter.Fill(Me.DataSet.UserStory)

    End Sub

    Private Sub UserStory_MemberDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles UserStory_MemberDataGridView.SelectionChanged
        If UserStory_MemberDataGridView.Rows.Count > 0 Then
            MemberTableAdapter.FillBy1(DataSet.Member, UserStory_MemberDataGridView.Rows(UserStory_MemberDataGridView.CurrentRow.Index).Cells(0).Value)
        End If
    End Sub
End Class