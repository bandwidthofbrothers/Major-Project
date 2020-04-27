Imports System.Data.SqlClient

Public Class AddTestCase
    Dim connection As New SqlConnection("Server=STUDENT-250JE01; Database=Group22;Integrated Security=true")
    Private Sub AddTestCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.TestCases' table. You can move, or remove it, as needed.
        Me.TestCasesTableAdapter.Fill(Me.DataSet.TestCases)
        'TODO: This line of code loads data into the 'DataSet.UserStory' table. You can move, or remove it, as needed.
        Me.UserStoryTableAdapter.Fill(Me.DataSet.UserStory)



    End Sub

    Private Sub NewTestCaseBtn_Click(sender As Object, e As EventArgs) Handles NewTestCaseBtn.Click
        Dim command As New SqlCommand("Insert into TestCases(TestCaseDetails, UserStoryNo, TestCaseNo) values('" & TestCaseDetailsTextbox.Text & "', '" & UserStoryNoTextbox.Text & "', '" & TestCaseNoTextbox.Text & "')", connection)


        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New Test Case Added")
        Else
            MessageBox.Show("Test Case Not Added")

        End If
        connection.Close()


    End Sub
End Class