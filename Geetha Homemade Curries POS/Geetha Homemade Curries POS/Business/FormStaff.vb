Imports System.Data.SqlClient

Public Class FormStaff

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox8.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        TextBox8.AutoCompleteSource = AutoCompleteSource.CustomSource

        Dim FirstName As String = ""
        Dim Surname As String = ""

        Dim conOne As SqlConnection
        Dim cndOne As SqlCommand
        conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        Try
            conOne.Open()
            cndOne = New SqlCommand("SELECT EmployeeFirstName, EmployeeSurname FROM Employee WHERE EmployeeFirstName <> @FirstName AND EmployeeSurname <> @Surname", conOne)
            cndOne.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName
            cndOne.Parameters.Add("@Surname", SqlDbType.VarChar).Value = Surname
            Dim drOne As SqlDataReader
            drOne = cndOne.ExecuteReader
            ListBox1.Items.Clear()
            Do While drOne.Read
                ListBox1.Items.Add(drOne.GetValue(1) + " " + drOne.GetValue(0))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conOne.Close()
        conOne.Dispose()
        conOne = Nothing

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        If ListBox1.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim EmployeeFullName As String = (ListBox1.SelectedItem).ToString
        Dim FirstName = EmployeeFullName.Substring(EmployeeFullName.IndexOf(" ") + 1)
        Dim Surname = EmployeeFullName.Substring(0, EmployeeFullName.IndexOf(" "))

        Dim conTwo As SqlConnection
        Dim cndTwo As SqlCommand
        conTwo = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        Try
            conTwo.Open()
            cndTwo = New SqlCommand("SELECT EmployeeNumber, EmployeeFirstName, EmployeeSurname, EmployeePhoneNumber, JobTitle, Username, Password FROM Employee WHERE EmployeeFirstName = @FirstName AND EmployeeSurname = @Surname", conTwo)
            cndTwo.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName
            cndTwo.Parameters.Add("@Surname", SqlDbType.VarChar).Value = Surname

            Dim drTwo As SqlDataReader
            drTwo = cndTwo.ExecuteReader

            Do While drTwo.Read
                TextBox1.Text = drTwo.GetValue(0).ToString
                TextBox2.Text = drTwo.GetValue(1)
                TextBox3.Text = drTwo.GetValue(2)
                TextBox4.Text = drTwo.GetValue(3)
                TextBox5.Text = drTwo.GetValue(4)
                TextBox6.Text = drTwo.GetValue(5)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conTwo.Close()
        conTwo.Dispose()
        conTwo = Nothing

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim EmployeeNumber As Integer = Integer.Parse(TextBox1.Text)
        Dim FName As String = TextBox2.Text
        Dim SName As String = TextBox3.Text
        Dim PhoneNumber As String = TextBox4.Text
        Dim JobTitle As String = "Former Employee"
        Dim Username As String = TextBox6.Text

        Dim Result As Integer
        Result = MsgBox("Do you want to delete the profile of " + FName + " " + SName, vbQuestion + vbYesNo + vbDefaultButton2, "Delete")

        Dim conThree As SqlConnection
        Dim cndThree As SqlCommand
        conThree = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        conThree.Open()
        If Result = 6 Then
            cndThree = New SqlCommand("UPDATE Employee SET EmployeeFirstName = @FirstName, EmployeeSurname = @Surname, EmployeePhoneNumber = @PhoneNumber, JobTitle = @JobTitle, Username = @Username WHERE EmployeeNumber = @EmployeeNumber", conThree)
            cndThree.Parameters.Add("@EmployeeNumber", SqlDbType.Int).Value = EmployeeNumber
            cndThree.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FName
            cndThree.Parameters.Add("@Surname", SqlDbType.VarChar).Value = SName
            cndThree.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = PhoneNumber
            cndThree.Parameters.Add("@JobTitle", SqlDbType.VarChar).Value = JobTitle
            cndThree.Parameters.Add("@UserName", SqlDbType.VarChar).Value = Username
            Try
                If cndThree.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Staff Access Deleted")
                Else
                    MessageBox.Show("Staff Access Not Deleted")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        conThree.Close()
        conThree.Dispose()
        conThree = Nothing

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim EmployeeNumber As Integer = Integer.Parse(TextBox1.Text)
        Dim FirstName As String = TextBox2.Text
        Dim Surname As String = TextBox3.Text
        Dim PhoneNumber As String = TextBox4.Text
        Dim JobTitle As String = TextBox5.Text
        Dim Username As String = TextBox6.Text

        Dim conFour As SqlConnection
        Dim cndFour As SqlCommand
        conFour = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        conFour.Open()
        cndFour = New SqlCommand("UPDATE Employee SET EmployeeFirstName = @FirstName, EmployeeSurname = @Surname, EmployeePhoneNumber = @PhoneNumber, JobTitle = @JobTitle, Username = @Username WHERE EmployeeNumber = @EmployeeNumber", conFour)

        If FirstName <> "" And Surname <> "" And PhoneNumber <> "" And JobTitle <> "" And Username <> "" Then

            Try
                cndFour.Parameters.Add("@EmployeeNumber", SqlDbType.Int).Value = EmployeeNumber
                cndFour.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName
                cndFour.Parameters.Add("@Surname", SqlDbType.VarChar).Value = Surname
                cndFour.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = PhoneNumber
                cndFour.Parameters.Add("@JobTitle", SqlDbType.VarChar).Value = JobTitle
                cndFour.Parameters.Add("@UserName", SqlDbType.VarChar).Value = Username
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                If cndFour.ExecuteNonQuery() = 1 Then
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

        conFour.Close()
        conFour.Dispose()
        conFour = Nothing

    End Sub

    Private Sub TextBox8_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox8.MouseClick
        Label1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim EmployeeFullName As String = TextBox8.Text

        Try
            Dim FirstName As String = EmployeeFullName.Substring(EmployeeFullName.IndexOf(" ") + 1)
            Dim Surname As String = EmployeeFullName.Substring(0, EmployeeFullName.IndexOf(" "))

            Dim conTwo As SqlConnection
            Dim cndTwo As SqlCommand
            conTwo = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

            Try
                conTwo.Open()
                cndTwo = New SqlCommand("SELECT EmployeeNumber, EmployeeFirstName, EmployeeSurname, EmployeePhoneNumber, JobTitle, Username FROM Employee WHERE EmployeeFirstName = @FirstName AND EmployeeSurname = @Surname", conTwo)
                cndTwo.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName
                cndTwo.Parameters.Add("@Surname", SqlDbType.VarChar).Value = Surname

                Dim drTwo As SqlDataReader
                drTwo = cndTwo.ExecuteReader

                Do While drTwo.Read
                    TextBox1.Text = drTwo.GetValue(0).ToString
                    TextBox2.Text = drTwo.GetValue(1)
                    TextBox3.Text = drTwo.GetValue(2)
                    TextBox4.Text = drTwo.GetValue(3)
                    TextBox5.Text = drTwo.GetValue(4)
                    TextBox6.Text = drTwo.GetValue(5)
                Loop
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            conTwo.Close()
            conTwo.Dispose()
            conTwo = Nothing
        Catch ex As Exception
            MessageBox.Show("No results found")
        End Try


    End Sub

    Private Sub TextBox8_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox8.MouseDoubleClick

        Dim FirstName As String = ""
        Dim Surname As String = ""

        Dim conOne As SqlConnection
        Dim cndOne As SqlCommand
        conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        Try
            conOne.Open()
            cndOne = New SqlCommand("SELECT EmployeeFirstName, EmployeeSurname FROM Employee WHERE EmployeeFirstName <> @FirstName AND EmployeeSurname <> @Surname", conOne)
            cndOne.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName
            cndOne.Parameters.Add("@Surname", SqlDbType.VarChar).Value = Surname
            Dim drOne As SqlDataReader
            drOne = cndOne.ExecuteReader
            Do While drOne.Read
                TextBox8.AutoCompleteCustomSource.Add(drOne.GetValue(1) + " " + drOne.GetValue(0))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conOne.Close()
        conOne.Dispose()
        conOne = Nothing

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormAddStaff.Show()
    End Sub

    Private Sub ButtonResetPassword_Click(sender As Object, e As EventArgs) Handles ButtonResetPassword.Click
        Dim Result As DialogResult = MessageBox.Show("Do you want to reset password?", "Reset Password", MessageBoxButtons.YesNo)

        Dim ID As Integer = Integer.Parse(TextBox1.Text)
        Dim FirstName As String = TextBox2.Text
        Dim Surname As String = TextBox3.Text
        Dim PhoneNumber As String = TextBox4.Text

        Dim firstTwo_Name As String = FirstName.Substring(0, 2)

        Dim firstTwo_Surname As String = Surname.Substring(0, 2)

        Dim fourFive As String = PhoneNumber.Substring(4, 2)

        Dim lastNum As String = PhoneNumber.Substring(9, 1)

        Dim last As Integer = Integer.Parse(lastNum)
        Dim specialChar As String

        If last = 0 Or last = 1 Then
            specialChar = "!"
        ElseIf last = 2 Or last = 3 Then
            specialChar = "@"
        ElseIf last = 4 Or last = 5 Then
            specialChar = "#"
        ElseIf last = 6 Or last = 7 Then
            specialChar = "$"
        Else
            specialChar = "%"
        End If

        Dim password As String = firstTwo_Name + "_" + fourFive + specialChar + firstTwo_Surname

        Dim conOne As SqlConnection
        Dim cndOne As SqlCommand
        conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        If Result = DialogResult.Yes Then

            conOne.Open()
            cndOne = New SqlCommand("UPDATE Employee SET Password = @Password WHERE EmployeeNumber = @EmployeeNumber", conOne)
            cndOne.Parameters.Add("@Password", SqlDbType.VarChar).Value = password
            cndOne.Parameters.Add("@EmployeeNumber", SqlDbType.Int).Value = ID

            Try
                If cndOne.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Password Reset Completed")
                    MessageBox.Show("Your new password is: " + password, "New Password")
                Else
                    MessageBox.Show("Password Reset NOT Completed")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else

            MessageBox.Show("Password Reset Cancelled")

        End If

        conOne.Close()
        conOne.Dispose()
        conOne = Nothing
    End Sub
End Class