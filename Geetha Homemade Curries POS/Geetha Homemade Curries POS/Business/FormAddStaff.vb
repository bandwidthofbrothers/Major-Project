Imports System.Data.SqlClient

Public Class FormAddStaff

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim FirstName As String = TextBox1.Text
        Dim Surname As String = TextBox2.Text
        Dim PhoneNumber As String = TextBox3.Text
        Dim JobTitle As String = TextBox4.Text
        Dim Username As String
        Dim Password As String
        Dim ID As String

        Dim check1, check2, check3, checkID As Boolean

        If FirstName <> "" And Surname <> "" And PhoneNumber <> "" And JobTitle <> "" Then
            check1 = True
        Else
            check1 = False
            MessageBox.Show("Enter all missing values", "ERROR")
        End If

        If check1 Then
            If Len(PhoneNumber) = 10 Then
                check2 = True
            Else
                check2 = False
                MessageBox.Show("Phone Number is incorrect", "ERROR")
            End If

            ID = InputBox("Enter ID number", "ID Number", 0)
            checkID = parseIdNo(ID)
            If Len(ID) = 13 And ID <> "" And checkID Then
                check3 = True
            Else
                check3 = False
                MessageBox.Show("ID Number is incorrect", "ERROR")
            End If

            If check3 = False Then
                ID = InputBox("Enter ID number", "ID Number", 0)
                checkID = parseIdNo(ID)
                check3 = True
            End If
        End If

        Dim conFour As SqlConnection
        Dim cndFour As SqlCommand
        conFour = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        conFour.Open()
        cndFour = New SqlCommand("Insert Into Employee(EmployeeFirstName, EmployeeSurname, EmployeePhoneNumber, JobTitle, Username, Password) Values (@FirstName, @Surname, @PhoneNumber, @JobTitle, @Username, @Password)", conFour)

        If check1 And check2 And check3 Then

            Dim myInitials As String
            If FirstName.Contains(" ") Then
                myInitials = FirstName.Substring(0, 1) & FirstName.Split(" ")(1).Substring(0, 1) & Surname.Substring(0, 1)
            Else
                myInitials = FirstName.Substring(0, 1) & Surname.Substring(0, 1)
            End If

            Dim DOB As String = ID.Substring(2, 4)

            Dim SpecialChar As String
            If JobTitle = "Administrator" Then
                SpecialChar = "*"
            ElseIf JobTitle = "Cashier" Then
                SpecialChar = "#"
            ElseIf JobTitle = "Manager" Then
                SpecialChar = "&"
            End If

            Username = FirstName.ToLower() + "." + Surname.ToLower()
            Password = myInitials + "_" + DOB + SpecialChar

            Try
                cndFour.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName
                cndFour.Parameters.Add("@Surname", SqlDbType.VarChar).Value = Surname
                cndFour.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = PhoneNumber
                cndFour.Parameters.Add("@JobTitle", SqlDbType.VarChar).Value = JobTitle
                cndFour.Parameters.Add("@UserName", SqlDbType.VarChar).Value = Username
                cndFour.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                If cndFour.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Staff Profile Added")
                Else
                    MessageBox.Show("Staff Profile Not Added")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        conFour.Close()
        conFour.Dispose()
        conFour = Nothing

        TextBox5.Text = Username
        TextBox6.Text = Password

    End Sub

    Public Function parseIdNo(ByVal idNo As String) As Boolean

        Try
            Dim a As Integer = 0
            For i As Integer = 0 To 5
                a += CInt(idNo.Substring(i * 2, 1))
            Next

            Dim b As Integer = 0
            For i As Integer = 0 To 5
                b = b * 10 + CInt(idNo.Substring(2 * i + 1, 1))
            Next
            b *= 2

            Dim c As Integer = 0
            Do
                c += b Mod 10
                b = Int(b / 10)
            Loop Until b <= 0
            c += a

            Dim d As Integer = 0
            d = 10 - (c Mod 10)
            If (d = 10) Then d = 0
            If d = CInt(idNo.Substring(12, 1)) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class