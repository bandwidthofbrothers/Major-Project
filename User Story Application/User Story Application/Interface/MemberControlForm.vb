Imports System.Data.SqlClient

Public Class MemberControlForm

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If MainMenuForm.View = True Then
            Button1.Enabled = False
            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
            TextBox3.ReadOnly = True
            TextBox4.ReadOnly = True
            TextBox5.ReadOnly = True
        End If

        If MainMenuForm.Edit = True Then
            Button1.Enabled = True
            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = False
            TextBox3.ReadOnly = False
            TextBox4.ReadOnly = False
            TextBox5.ReadOnly = False
        End If

        If MainMenuForm.Search = True Then
            Button1.Enabled = False
            Button1.Visible = False
            Button2.Enabled = False
            Button2.Visible = False
            ListBox1.Visible = False
            Label1.Text = "Search for Group Members: "
            Label2.Visible = True
            TextBox6.Visible = True
            Button3.Visible = True
            Button4.Visible = True
        End If

        Dim FirstName As String = ""

        Dim conOne As SqlConnection
        Dim cndOne As SqlCommand
        conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        Try
            conOne.Open()
            cndOne = New SqlCommand("SELECT FirstName FROM Member WHERE FirstName <> @FirstName", conOne)
            cndOne.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName
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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim FirstName As String = ListBox1.Text

        Dim conTwo As SqlConnection
        Dim cndTwo As SqlCommand
        conTwo = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        Try
            conTwo.Open()
            cndTwo = New SqlCommand("SELECT GroupMemberNo, FirstName, Surname, UserName, Password FROM Member WHERE FirstName = @FirstName", conTwo)

            cndTwo.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName

            Dim drTwo As SqlDataReader
            drTwo = cndTwo.ExecuteReader

            Do While drTwo.Read
                TextBox1.Text = drTwo.GetValue(0).ToString
                TextBox2.Text = drTwo.GetValue(1)
                TextBox3.Text = drTwo.GetValue(2)
                TextBox4.Text = drTwo.GetValue(3)
                TextBox5.Text = drTwo.GetValue(4)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conTwo.Close()
        conTwo.Dispose()
        conTwo = Nothing

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim GroupMemberNo As Integer = Integer.Parse(TextBox1.Text)
        Dim FirstName As String = TextBox2.Text
        Dim Surname As String = TextBox3.Text
        Dim UserName As String = TextBox4.Text
        Dim Password As String = TextBox5.Text

        Dim conThree As SqlConnection
        Dim cndThree As SqlCommand
        conThree = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        conThree.Open()
        cndThree = New SqlCommand("UPDATE Member SET FirstName = @FirstName, Surname = @Surname, UserName = @UserName, Password = @Password WHERE GroupMemberNo = @GroupMemberNo", conThree)

        If FirstName <> "" And Surname <> "" And UserName <> "" And Password <> "" Then
            Try
                cndThree.Parameters.Add("@GroupMemberNo", SqlDbType.Int).Value = GroupMemberNo
                cndThree.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName
                cndThree.Parameters.Add("@Surname", SqlDbType.VarChar).Value = Surname
                cndThree.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName
                cndThree.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                If cndThree.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Information has been updated")
                Else
                    MessageBox.Show("Information Not Added")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Please enter all missing values")
        End If

        conThree.Close()
        conThree.Dispose()
        conThree = Nothing

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MainMenuForm.View = False
        MainMenuForm.Edit = False
        MainMenuForm.Search = False
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim FirstName As String = TextBox6.Text

        Dim conOne As SqlConnection
        Dim cndOne As SqlCommand
        conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        Dim Search As String
        Dim Found As Boolean = False
        Try
            conOne.Open()
            cndOne = New SqlCommand("SELECT FirstName FROM Member WHERE FirstName = @FirstName", conOne)
            cndOne.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName
            Dim drOne As SqlDataReader
            drOne = cndOne.ExecuteReader
            Do While drOne.Read
                Search = drOne.GetValue(0)
                If Search = FirstName Then
                    Dim conTwo As SqlConnection
                    Dim cndTwo As SqlCommand
                    conTwo = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

                    Try
                        conTwo.Open()
                        cndTwo = New SqlCommand("SELECT GroupMemberNo, FirstName, Surname, UserName, Password FROM Member WHERE FirstName = @FirstName", conTwo)

                        cndTwo.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName

                        Dim drTwo As SqlDataReader
                        drTwo = cndTwo.ExecuteReader

                        Do While drTwo.Read
                            TextBox1.Text = drTwo.GetValue(0).ToString
                            TextBox2.Text = drTwo.GetValue(1)
                            TextBox3.Text = drTwo.GetValue(2)
                            TextBox4.Text = drTwo.GetValue(3)
                            TextBox5.Text = drTwo.GetValue(4)
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
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                MessageBox.Show("Member Not Found")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conOne.Close()
        conOne.Dispose()
        conOne = Nothing

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MainMenuForm.View = False
        MainMenuForm.Edit = False
        MainMenuForm.Search = False
        Me.Close()
    End Sub
End Class