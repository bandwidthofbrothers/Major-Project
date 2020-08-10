Imports System.Data.SqlClient

Public Class FormReport
    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateReports()
    End Sub

    Private Sub updateReports()


        'Daily Reports

        Dim dateSelected As Date = MonthCalendar.SelectionStart.Date

        GroupBoxDaily.Text = "Statistics - " + dateSelected.ToShortDateString
        GroupBoxMonthly.Text = "Statistics - " + dateSelected.ToString("MMMM") + " " + dateSelected.ToString("yyyy")

        Dim firstDate As Date = CustomerOrderTableAdapter.getFirstOrderDate()
        Dim lastDate As Date = CustomerOrderTableAdapter.getLastOrderDate()

        GroupBoxAllTime.Text = "Statistics - " + firstDate.ToShortDateString + " to " + lastDate.ToShortDateString

        Dim dailyExpenses As Double = IngredientTableAdapter.getDailyExpenses(dateSelected.ToShortDateString)
        LabelExpenses.Text = dailyExpenses.ToString("c")

        Dim dailyIncome As Double = CustomerOrderTableAdapter.getDailyIncome(dateSelected.ToShortDateString)
        LabelIncome.Text = dailyIncome.ToString("c")

        Dim subtract As Double = dailyIncome - dailyExpenses

        If subtract = 0.0 Then
            LabelTextProfitLoss.Text = "Break Even: "
        ElseIf subtract > 0.0 Then
            LabelTextProfitLoss.Text = "Profit: "
        Else
            LabelTextProfitLoss.Text = "Loss:  "
        End If

        LabelProfitLoss.Text = subtract.ToString("c")

        Dim dailyMostSoldProduct As String = CustomerOrderTableAdapter.getDailyMostSoldProduct(dateSelected.ToShortDateString)
        LabelMostSoldProductName.Text = dailyMostSoldProduct

        Dim dailyLeastSoldProduct As String = CustomerOrderTableAdapter.getDailyLeastSoldProduct(dateSelected.ToShortDateString)
        LabelLeastSoldProductName.Text = dailyLeastSoldProduct

        'Daily Productivity Chart

        ChartDailyProductivity.Series(0).Points.Clear()

        Dim d As Date = MonthCalendar.SelectionStart

        Dim Hour As Integer = 8
        Dim TimeOne As TimeSpan
        Dim TimeTwo As TimeSpan

        Do While Hour < 18
            TimeOne = TimeSpan.FromHours(Hour)
            TimeTwo = TimeSpan.FromHours(Hour + 1)

            Dim conOne As SqlConnection
            Dim cndOne As SqlCommand
            conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

            Try
                conOne.Open()
                cndOne = New SqlCommand("SELECT DISTINCT COUNT(CustomerOrderID) FROM CustomerOrder WHERE OrderDate = @d AND OrderTime >= @TimeOne AND OrderTime < @TimeTwo", conOne)
                cndOne.Parameters.Add("@d", SqlDbType.Date).Value = d
                cndOne.Parameters.Add("@TimeOne", SqlDbType.Time).Value = TimeOne
                cndOne.Parameters.Add("@TimeTwo", SqlDbType.Time).Value = TimeTwo
                Dim drOne As SqlDataReader
                drOne = cndOne.ExecuteReader
                Do While drOne.Read
                    Me.ChartDailyProductivity.Series("Productivity").Points.AddXY(Hour, drOne.GetValue(0))
                Loop
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            conOne.Close()
            conOne.Dispose()
            conOne = Nothing

            Hour += 1
        Loop

        'Monthly Reports

        Dim MonthlyIncome As Double = CustomerOrderTableAdapter.getMonthlyIncome(dateSelected.Month, dateSelected.Year)
        LabelMonthlyIncome.Text = MonthlyIncome.ToString("c")

        Dim MonthlyExpenses As Double = IngredientTableAdapter.getMonthlyExpenses(dateSelected.Month, dateSelected.Year)
        LabelMonthlyExpenses.Text = MonthlyExpenses.ToString("c")

        subtract = MonthlyIncome - MonthlyExpenses

        If subtract = 0.0 Then
            LabelTextMonthlyProfitLoss.Text = "Break Even: "
        ElseIf subtract > 0.0 Then
            LabelTextMonthlyProfitLoss.Text = "Profit: "
        Else
            LabelTextMonthlyProfitLoss.Text = "Loss:  "
        End If

        LabelMonthlyProfitLoss.Text = subtract.ToString("c")

        Dim MonthlyMostSoldProduct As String = CustomerOrderTableAdapter.getMonthlyMostSoldProduct(dateSelected.Month, dateSelected.Year)
        LabelMonthlyMostSoldProduct.Text = MonthlyMostSoldProduct

        Dim MonthlyLeastSoldProduct As String = CustomerOrderTableAdapter.getMonthlyLeastSoldProduct(dateSelected.Month, dateSelected.Year)
        LabelMonthlyLeastSoldProduct.Text = MonthlyLeastSoldProduct

        drawMonthlyProductivtyGraph()

        'All Time Reports

        Dim income As Double = CustomerOrderTableAdapter.getAllTimeIncome()
        LabelAllTimeIncome.Text = income.ToString("C")

        Dim expenses As Double = IngredientTableAdapter.getAllTimeExpenses()
        LabelAllTimeExpenses.Text = expenses.ToString("c")

        subtract = income - expenses

        If subtract = 0.0 Then
            LabelTextAllTimeProfitLoss.Text = "Break Even: "
        ElseIf subtract > 0.0 Then
            LabelTextAllTimeProfitLoss.Text = "Profit: "
        Else
            LabelTextAllTimeProfitLoss.Text = "Loss:  "
        End If

        Dim MostSoldProduct As String = CustomerOrderTableAdapter.getAllTimeMostSoldProduct()
        LabelAllTimeMostSoldProduct.Text = MostSoldProduct

        Dim LeastSoldProduct As String = CustomerOrderTableAdapter.getAllTimeLeastSoldProduct()
        LabelAllTimeLeastSoldProduct.Text = LeastSoldProduct

        LabelAllTimeProfitLoss.Text = subtract.ToString("c")

        drawAllTimeProductivityGraph()
    End Sub

    Private Sub drawMonthlyProductivtyGraph()
        ChartMonthlyProductivity.Series(0).Points.Clear()

        Dim Count As Integer = 0
        Dim WeekDay As Integer = 1
        Dim DayOfWeek As String

        Do While Count < 7

            If WeekDay = 1 Then
                DayOfWeek = "Sunday"
            ElseIf WeekDay = 2 Then
                DayOfWeek = "Monday"
            ElseIf WeekDay = 3 Then
                DayOfWeek = "Tuesday"
            ElseIf WeekDay = 4 Then
                DayOfWeek = "Wednesday"
            ElseIf WeekDay = 5 Then
                DayOfWeek = "Thursday"
            ElseIf WeekDay = 6 Then
                DayOfWeek = "Friday"
            ElseIf WeekDay = 7 Then
                DayOfWeek = "Saturday"
            End If

            Dim conOne As SqlConnection
            Dim cndOne As SqlCommand
            conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")
            Try
                conOne.Open()
                cndOne = New SqlCommand("SELECT COUNT(DISTINCT SaleID) FROM CustomerOrder WHERE DATEPART(WEEKDAY, OrderDate) = @WeekDay AND MONTH(OrderDate) = @Month AND YEAR(OrderDate) = @CurrentYear;", conOne)
                cndOne.Parameters.Add("@WeekDay", SqlDbType.Int).Value = WeekDay
                cndOne.Parameters.Add("@Month", SqlDbType.Int).Value = MonthCalendar.SelectionStart.Month
                cndOne.Parameters.Add("@CurrentYear", SqlDbType.VarChar).Value = MonthCalendar.SelectionStart.Year

                Dim drOne As SqlDataReader
                drOne = cndOne.ExecuteReader
                Do While drOne.Read
                    Me.ChartMonthlyProductivity.Series("Orders").Points.AddXY(DayOfWeek, drOne.GetValue(0))
                Loop
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            conOne.Close()
            conOne.Dispose()
            conOne = Nothing

            Count += 1
            WeekDay += 1

        Loop
    End Sub

    Private Sub drawAllTimeProductivityGraph()
        ChartAllTimeProductivity.Series(0).Points.Clear()

        Dim Count As Integer = 0
        Dim WeekDay As Integer = 1
        Dim DayOfWeek As String

        Do While Count < 7

            If WeekDay = 1 Then
                DayOfWeek = "Sunday"
            ElseIf WeekDay = 2 Then
                DayOfWeek = "Monday"
            ElseIf WeekDay = 3 Then
                DayOfWeek = "Tuesday"
            ElseIf WeekDay = 4 Then
                DayOfWeek = "Wednesday"
            ElseIf WeekDay = 5 Then
                DayOfWeek = "Thursday"
            ElseIf WeekDay = 6 Then
                DayOfWeek = "Friday"
            ElseIf WeekDay = 7 Then
                DayOfWeek = "Saturday"
            End If

            Dim conOne As SqlConnection
            Dim cndOne As SqlCommand
            conOne = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")
            Try
                conOne.Open()
                cndOne = New SqlCommand("SELECT COUNT(DISTINCT SaleID) FROM CustomerOrder WHERE DATEPART(WEEKDAY, OrderDate) = @WeekDay;", conOne)
                cndOne.Parameters.Add("@WeekDay", SqlDbType.Int).Value = WeekDay

                Dim drOne As SqlDataReader
                drOne = cndOne.ExecuteReader
                Do While drOne.Read
                    Me.ChartAllTimeProductivity.Series("Orders").Points.AddXY(DayOfWeek, drOne.GetValue(0))
                Loop
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            conOne.Close()
            conOne.Dispose()
            conOne = Nothing

            Count += 1
            WeekDay += 1

        Loop
    End Sub

    Private Sub MonthCalendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar.DateChanged
        updateReports()
    End Sub

End Class