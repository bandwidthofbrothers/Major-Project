Public Class FormReports
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        TextBoxSelectedDate.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString()
    End Sub
End Class