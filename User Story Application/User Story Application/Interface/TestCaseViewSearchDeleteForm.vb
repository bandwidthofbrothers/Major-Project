Imports System.Data.SqlClient

Public Class TestCaseViewSearchDeleteForm

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim TestCaseNo As Integer = Integer.Parse(ListBox1.Text)

        Dim conTwo As SqlConnection
        Dim cndTwo As SqlCommand
        conTwo = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        Try
            conTwo.Open()
            cndTwo = New SqlCommand("SELECT TestCaseNo, TestCaseDetails, UserStoryNo FROM TestCases WHERE TestCaseNo = @TestCaseNo", conTwo)

            cndTwo.Parameters.Add("@TestCaseNo", SqlDbType.Int).Value = TestCaseNo

            Dim drTwo As SqlDataReader
            drTwo = cndTwo.ExecuteReader

            Do While drTwo.Read
                TextBox1.Text = drTwo.GetValue(0).ToString
                RichTextBox1.Text = drTwo.GetValue(1)
                TextBox2.Text = drTwo.GetValue(2).ToString
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conTwo.Close()
        conTwo.Dispose()
        conTwo = Nothing

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If MainMenuForm.TestCaseView Then
            Button1.Enabled = False
            TextBox1.ReadOnly = True
            RichTextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
        End If

        If MainMenuForm.TestCaseSearch Then
            ListBox1.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Label4.Text = "Search for Test Cases:"
            Label5.Visible = True
            TextBox3.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            TextBox1.ReadOnly = True
            RichTextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
        End If

        Dim TestCaseNo As Integer = 0

            Dim conOne As SqlConnection
        Dim cndOne As SqlCommand
        conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        Try
            conOne.Open()
            cndOne = New SqlCommand("SELECT TestCaseNo FROM TestCases WHERE TestCaseNo <> @TestCaseNo", conOne)
            cndOne.Parameters.Add("@TestCaseNo", SqlDbType.Int).Value = TestCaseNo
            Dim drOne As SqlDataReader
            drOne = cndOne.ExecuteReader
            ListBox1.Items.Clear()
            Do While drOne.Read
                ListBox1.Items.Add(drOne.GetValue(0).ToString)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conOne.Close()
        conOne.Dispose()
        conOne = Nothing

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MainMenuForm.TestCaseView = False
        MainMenuForm.TestCaseDelete = False
        MainMenuForm.TestCaseSearch = False
        Me.Close()
        MainMenuForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MainMenuForm.TestCaseView = False
        MainMenuForm.TestCaseDelete = False
        MainMenuForm.TestCaseSearch = False
        Me.Close()
        MainMenuForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim TestCaseNo As Integer = Integer.Parse(TextBox3.Text)

        Dim conOne As SqlConnection
        Dim cndOne As SqlCommand
        conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        Dim Search As Integer
        Dim Found As Boolean = False
        Try
            conOne.Open()
            cndOne = New SqlCommand("SELECT TestCaseNo FROM TestCases WHERE TestCaseNo = @TestCaseNo", conOne)
            cndOne.Parameters.Add("@TestCaseNo", SqlDbType.Int).Value = TestCaseNo
            Dim drOne As SqlDataReader
            drOne = cndOne.ExecuteReader
            Do While drOne.Read
                Search = drOne.GetValue(0)
                If Search = TestCaseNo Then
                    Dim conTwo As SqlConnection
                    Dim cndTwo As SqlCommand
                    conTwo = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

                    Try
                        conTwo.Open()
                        cndTwo = New SqlCommand("SELECT TestCaseNo, TestCaseDetails, UserStoryNo FROM TestCases WHERE TestCaseNo = @TestCaseNo", conTwo)

                        cndTwo.Parameters.Add("@TestCaseNo", SqlDbType.VarChar).Value = TestCaseNo

                        Dim drTwo As SqlDataReader
                        drTwo = cndTwo.ExecuteReader

                        Do While drTwo.Read
                            TextBox1.Text = drTwo.GetValue(0).ToString
                            RichTextBox1.Text = drTwo.GetValue(1)
                            TextBox2.Text = drTwo.GetValue(2).ToString
                        Loop
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    conTwo.Close()
                    conTwo.Dispose()
                    conTwo = Nothing
                    Found = True
                End If
            Loop
            If Found = False Then
                TextBox1.Text = ""
                RichTextBox1.Text = ""
                TextBox2.Text = ""
                MessageBox.Show("Test Case Not Found")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conOne.Close()
        conOne.Dispose()
        conOne = Nothing

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim TestCaseNo As Integer = Integer.Parse(ListBox1.Text)

        Dim Result As DialogResult = MessageBox.Show("Do you want to delete this Test Case?", "Delete", MessageBoxButtons.YesNo)

        Dim conThree As SqlConnection
        Dim cndThree As SqlCommand
        conThree = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        conThree.Open()
        If Result = DialogResult.Yes Then
            cndThree = New SqlCommand("DELETE FROM TestCases WHERE TestCaseNo = @TestCaseNo", conThree)
            cndThree.Parameters.Add("@TestCaseNo", SqlDbType.Int).Value = TestCaseNo
            Try
                If cndThree.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Test Case Deleted")
                Else
                    MessageBox.Show("Test Case Not Deleted")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        conThree.Close()
        conThree.Dispose()
        conThree = Nothing

    End Sub

End Class