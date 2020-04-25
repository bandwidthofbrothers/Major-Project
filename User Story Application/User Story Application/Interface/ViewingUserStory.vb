Public Class ViewingUserStory
    Private Sub ViewingUserStory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group22DataSet.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.Group22DataSet.Member)
        'TODO: This line of code loads data into the 'Group22DataSet.UserStory_Member' table. You can move, or remove it, as needed.
        Me.UserStory_MemberTableAdapter.Fill(Me.Group22DataSet.UserStory_Member)
        'TODO: This line of code loads data into the 'Group22DataSet.TestCases' table. You can move, or remove it, as needed.
        Me.TestCasesTableAdapter.Fill(Me.Group22DataSet.TestCases)
        'TODO: This line of code loads data into the 'Group22DataSet.UserStory' table. You can move, or remove it, as needed.
        Me.UserStoryTableAdapter.Fill(Me.Group22DataSet.UserStory)

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub DataGridView3_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView3.SelectionChanged

        If DataGridView3.Rows.Count > 0 Then
            MemberTableAdapter1.Fill(Group22DataSet.Member, DataGridView3.Rows(DataGridView3.CurrentRow.Index).Cells(0).Value)

        End If
    End Sub
End Class