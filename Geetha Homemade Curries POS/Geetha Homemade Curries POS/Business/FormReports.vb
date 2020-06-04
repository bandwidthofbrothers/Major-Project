Imports System.Data.SqlClient

Public Class FormReports

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected

        Dim d As Date = MonthCalendar1.SelectionStart

        Dim conOne As SqlConnection
        Dim cndOne As SqlCommand
        conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = ist3af; User Id = ist3af; Password = fwa6ku")

        Dim Expenses As Decimal

        Try
            conOne.Open()
            cndOne = New SqlCommand("SELECT SUM(IngredientCost) FROM Ingredient WHERE DatePurchased = @d", conOne)
            cndOne.Parameters.Add("@d", SqlDbType.Date).Value = d
            Dim drOne As SqlDataReader
            drOne = cndOne.ExecuteReader
            Do While drOne.Read
                If IsDBNull(drOne.GetValue(0)) Then
                    Expenses = 0
                Else
                    Expenses = drOne.GetValue(0)
                End If
            Loop
            TextBox2.Text = "R" + Expenses.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conOne.Close()
        conOne.Dispose()
        conOne = Nothing

        Dim conTwo As SqlConnection
        Dim cndTwo As SqlCommand
        conTwo = New SqlConnection("Server = 146.230.177.46\ist3; Database = ist3af; User Id = ist3af; Password = fwa6ku")

        Dim Income As Decimal
        Dim MenuItemCost As Decimal
        Dim Quantity As Decimal

        Try
            conTwo.Open()
            cndTwo = New SqlCommand("SELECT MenuItemCost, Quantity FROM CustomerOrder, MenuItem WHERE CustomerOrder.MenuItemID = MenuItem.MenuItemID AND OrderDate = @d", conTwo)
            cndTwo.Parameters.Add("@d", SqlDbType.Date).Value = d
            Dim drTwo As SqlDataReader
            drTwo = cndTwo.ExecuteReader
            Do While drTwo.Read
                If IsDBNull(drTwo.GetValue(0)) And IsDBNull(drTwo.GetValue(0)) Then
                    Income = 0
                Else
                    MenuItemCost = drTwo.GetValue(0)
                    Quantity = drTwo.GetValue(1)
                    Income = Income + (MenuItemCost * Quantity)
                End If
            Loop
            TextBox1.Text = "R" + Income.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conTwo.Close()
        conTwo.Dispose()
        conTwo = Nothing

        Dim subtract As Decimal = Income - Expenses
        If subtract = 0.00 Then
            TextBox3.Text = "R" + subtract.ToString + " - Break Even"
        ElseIf subtract > 0.00 Then
            TextBox3.Text = "R" + subtract.ToString + " - Profit"
        Else
            TextBox3.Text = "R" + subtract.ToString + " - Loss"
        End If

        Chart1.Series(0).Points.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim CurrentYear As String = Now.Year
        Dim LeapYear As Boolean = Date.IsLeapYear(CurrentYear)
        Dim Month As String
        Dim StartDay As String = "01"
        Dim EndDay As String

        Dim MonthSelected As String
        Dim Check As Boolean
        If ComboBox1.SelectedItem = "" Then
            MessageBox.Show("Select a Month")
            Check = False
        Else
            MonthSelected = ComboBox1.SelectedItem
            Check = True
        End If

        If Check Then

            If MonthSelected = "January" Then
                Month = "01"
                EndDay = "31"
            ElseIf MonthSelected = "March" Then
                Month = "03"
                EndDay = "31"
            ElseIf MonthSelected = "April" Then
                Month = "04"
                EndDay = "30"
            ElseIf MonthSelected = "May" Then
                Month = "05"
                EndDay = "30"
            ElseIf MonthSelected = "June" Then
                Month = "06"
                EndDay = "30"
            ElseIf MonthSelected = "July" Then
                Month = "07"
                EndDay = "31"
            ElseIf MonthSelected = "August" Then
                Month = "08"
                EndDay = "31"
            ElseIf MonthSelected = "September" Then
                Month = "09"
                EndDay = "30"
            ElseIf MonthSelected = "October" Then
                Month = "10"
                EndDay = "31"
            ElseIf MonthSelected = "November" Then
                Month = "11"
                EndDay = "30"
            ElseIf MonthSelected = "December" Then
                Month = "12"
                EndDay = "31"
            End If

            If MonthSelected = "February" And LeapYear Then
                Month = "02"
                EndDay = "29"
            ElseIf MonthSelected = "February" And LeapYear = False Then
                Month = "02"
                EndDay = "28"
            End If

            Dim StartDate As String = CurrentYear + Month + StartDay
            Dim EndDate As String = CurrentYear + Month + EndDay

            Dim conOne As SqlConnection
            Dim cndOne As SqlCommand
            conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = ist3af; User Id = ist3af; Password = fwa6ku")

            Dim Expenses As Decimal

            Try
                conOne.Open()
                cndOne = New SqlCommand("SELECT SUM(IngredientCost) FROM Ingredient WHERE DatePurchased BETWEEN @StartDate AND @EndDate", conOne)
                cndOne.Parameters.Add("@StartDate", SqlDbType.VarChar).Value = StartDate
                cndOne.Parameters.Add("@EndDate", SqlDbType.VarChar).Value = EndDate
                Dim drOne As SqlDataReader
                drOne = cndOne.ExecuteReader
                Do While drOne.Read
                    If IsDBNull(drOne.GetValue(0)) Then
                        Expenses = 0
                    Else
                        Expenses = drOne.GetValue(0)
                    End If
                Loop
                TextBox5.Text = "R" + Expenses.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            conOne.Close()
            conOne.Dispose()
            conOne = Nothing

            Dim conTwo As SqlConnection
            Dim cndTwo As SqlCommand
            conTwo = New SqlConnection("Server = 146.230.177.46\ist3; Database = ist3af; User Id = ist3af; Password = fwa6ku")

            Dim Income As Decimal
            Dim MenuItemCost As Decimal
            Dim Quantity As Decimal

            Try
                conTwo.Open()
                cndTwo = New SqlCommand("SELECT MenuItemCost, Quantity FROM CustomerOrder, MenuItem WHERE CustomerOrder.MenuItemID = MenuItem.MenuItemID AND OrderDate BETWEEN @StartDate AND @EndDate", conTwo)
                cndTwo.Parameters.Add("@StartDate", SqlDbType.VarChar).Value = StartDate
                cndTwo.Parameters.Add("@EndDate", SqlDbType.VarChar).Value = EndDate
                Dim drTwo As SqlDataReader
                drTwo = cndTwo.ExecuteReader
                Do While drTwo.Read
                    If IsDBNull(drTwo.GetValue(0)) And IsDBNull(drTwo.GetValue(0)) Then
                        Income = 0
                    Else
                        MenuItemCost = drTwo.GetValue(0)
                        Quantity = drTwo.GetValue(1)
                        Income = Income + (MenuItemCost * Quantity)
                    End If
                Loop
                TextBox4.Text = "R" + Income.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            conTwo.Close()
            conTwo.Dispose()
            conTwo = Nothing

            Dim subtract As Decimal = Income - Expenses
            If subtract = 0.00 Then
                TextBox6.Text = "R" + subtract.ToString + " - Break Even"
            ElseIf subtract > 0.00 Then
                TextBox6.Text = "R" + subtract.ToString + " - Profit"
            Else
                TextBox6.Text = "R" + subtract.ToString + " - Loss"
            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Chart1.Series(0).Points.Clear()

        Dim d As Date = MonthCalendar1.SelectionStart

        Dim Hour As Integer = 8
        Dim TimeOne As TimeSpan
        Dim TimeTwo As TimeSpan

        Do While Hour < 18
            TimeOne = TimeSpan.FromHours(Hour)
            TimeTwo = TimeSpan.FromHours(Hour + 1)

            Dim conOne As SqlConnection
            Dim cndOne As SqlCommand
            conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = ist3af; User Id = ist3af; Password = fwa6ku")

            Try
                conOne.Open()
                cndOne = New SqlCommand("SELECT COUNT(CustomerOrderID) FROM CustomerOrder WHERE OrderDate = @d AND OrderTime >= @TimeOne AND OrderTime < @TimeTwo", conOne)
                cndOne.Parameters.Add("@d", SqlDbType.Date).Value = d
                cndOne.Parameters.Add("@TimeOne", SqlDbType.Time).Value = TimeOne
                cndOne.Parameters.Add("@TimeTwo", SqlDbType.Time).Value = TimeTwo
                Dim drOne As SqlDataReader
                drOne = cndOne.ExecuteReader
                Do While drOne.Read
                    Me.Chart1.Series("Orders").Points.AddXY(Hour, drOne.GetValue(0))
                Loop
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            conOne.Close()
            conOne.Dispose()
            conOne = Nothing

            Hour += 1
        Loop

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Chart1.Series(0).Points.Clear()

        Dim d As Date = MonthCalendar1.SelectionStart

        Dim NextDate As Date
        Dim CurrentDate As String
        Dim CurrentDay As Integer
        Dim CurrentMonth As Integer

        Dim Count As Integer = 0

        Do While Count < 7
            NextDate = d.AddDays(Count)
            CurrentDay = NextDate.Day
            CurrentMonth = NextDate.Month
            CurrentDate = CStr(CurrentDay) + "-" + CStr(CurrentMonth)

            Dim conOne As SqlConnection
            Dim cndOne As SqlCommand
            conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = ist3af; User Id = ist3af; Password = fwa6ku")
            Try
                conOne.Open()
                cndOne = New SqlCommand("SELECT COUNT(CustomerOrderID) FROM CustomerOrder WHERE OrderDate = @d", conOne)
                cndOne.Parameters.Add("@d", SqlDbType.Date).Value = NextDate

                Dim drOne As SqlDataReader
                drOne = cndOne.ExecuteReader
                Do While drOne.Read
                    Me.Chart1.Series("Orders").Points.AddXY(CurrentDate, drOne.GetValue(0))
                Loop
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            conOne.Close()
            conOne.Dispose()
            conOne = Nothing

            Count += 1
        Loop

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conOne As SqlConnection
        Dim cndOne As SqlCommand
        conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = ist3af; User Id = ist3af; Password = fwa6ku")

        Dim Max_MenuItemID As Integer
        Dim Max_TotalOrders As Integer

        Try
            conOne.Open()
            cndOne = New SqlCommand("SELECT TOP(1) CustomerOrder.MenuItemID, SUM(Quantity) As TotalOrders FROM CustomerOrder, MenuItem WHERE CustomerOrder.MenuItemID = MenuItem.MenuItemID GROUP BY CustomerOrder.MenuItemID ORDER BY TotalOrders DESC", conOne)
            Dim drOne As SqlDataReader
            drOne = cndOne.ExecuteReader
            Do While drOne.Read
                Max_MenuItemID = drOne.GetValue(0)
                Max_TotalOrders = drOne.GetValue(1)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conOne.Close()
        conOne.Dispose()
        conOne = Nothing

        Dim conTwo As SqlConnection
        Dim cndTwo As SqlCommand
        conTwo = New SqlConnection("Server = 146.230.177.46\ist3; Database = ist3af; User Id = ist3af; Password = fwa6ku")

        Dim Max_MenuItemName As String

        Try
            conTwo.Open()
            cndTwo = New SqlCommand("SELECT MenuItemName FROM MenuItem WHERE MenuItemID = @MenuItemID", conTwo)
            cndTwo.Parameters.Add("@MenuItemID", SqlDbType.VarChar).Value = Max_MenuItemID
            Dim drTwo As SqlDataReader
            drTwo = cndTwo.ExecuteReader
            Do While drTwo.Read
                Max_MenuItemName = drTwo.GetValue(0).ToString
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conTwo.Close()
        conTwo.Dispose()
        conTwo = Nothing

        TextBox7.Text = Max_MenuItemName + " - Total Orders: " + Max_TotalOrders.ToString

        Dim conThree As SqlConnection
        Dim cndThree As SqlCommand
        conThree = New SqlConnection("Server = 146.230.177.46\ist3; Database = ist3af; User Id = ist3af; Password = fwa6ku")

        Dim Min_MenuItemID As Integer
        Dim Min_TotalOrders As Integer

        Try
            conThree.Open()
            cndThree = New SqlCommand("SELECT TOP(1) CustomerOrder.MenuItemID, SUM(Quantity) As TotalOrders FROM CustomerOrder, MenuItem WHERE CustomerOrder.MenuItemID = MenuItem.MenuItemID GROUP BY CustomerOrder.MenuItemID ORDER BY TotalOrders ASC", conThree)
            Dim drThree As SqlDataReader
            drThree = cndThree.ExecuteReader
            Do While drThree.Read
                Min_MenuItemID = drThree.GetValue(0)
                Min_TotalOrders = drThree.GetValue(1)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conThree.Close()
        conThree.Dispose()
        conThree = Nothing

        Dim conFour As SqlConnection
        Dim cndFour As SqlCommand
        conFour = New SqlConnection("Server = 146.230.177.46\ist3; Database = ist3af; User Id = ist3af; Password = fwa6ku")

        Dim Min_MenuItemName As String

        Try
            conFour.Open()
            cndFour = New SqlCommand("SELECT MenuItemName FROM MenuItem WHERE MenuItemID = @MenuItemID", conFour)
            cndFour.Parameters.Add("@MenuItemID", SqlDbType.VarChar).Value = Min_MenuItemID
            Dim drFour As SqlDataReader
            drFour = cndFour.ExecuteReader
            Do While drFour.Read
                Min_MenuItemName = drFour.GetValue(0).ToString
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conFour.Close()
        conFour.Dispose()
        conFour = Nothing

        TextBox8.Text = Min_MenuItemName + " - Total Orders: " + Min_TotalOrders.ToString

    End Sub

End Class