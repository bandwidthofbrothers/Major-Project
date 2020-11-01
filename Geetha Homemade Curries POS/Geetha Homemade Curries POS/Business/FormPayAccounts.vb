Imports System.Data.SqlClient

Public Class FormPayAccounts

    Dim connection As SqlConnection = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")
    Dim command As SqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        command = New SqlCommand("SELECT CustomerID, FirstName, Surname, PhoneNumber, AmountDue, AmountCap FROM Customer WHERE  (CustomerID <> 4)", connection)
        PopulateGrid(command)

    End Sub

    Public Sub PopulateGrid(ByRef command)

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim search As String = TextBox1.Text

        Dim command As New SqlCommand("SELECT CustomerID, FirstName, Surname, PhoneNumber, AmountDue, AmountCap FROM Customer WHERE PhoneNumber LIKE @PhoneNumber + '%' AND (CustomerID <> 4)", connection)
        command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = search

        PopulateGrid(command)

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

        PopulateTextBoxes()

    End Sub

    Public Sub PopulateTextBoxes()

        TextBox4.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(4).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim amountDue As Decimal
        Dim amount As Decimal
        Dim ID As Integer

        Dim thisDate As Date = Today

        Dim checkConversion As Boolean

        Try
            amountDue = Convert.ToDecimal(TextBox2.Text)
            amount = Convert.ToDecimal(TextBox3.Text)
            ID = Convert.ToInt32(TextBox4.Text)
            checkConversion = True
        Catch ex As Exception
            MessageBox.Show("Select a Record")
            checkConversion = False
        End Try

        Dim checkAmount As Boolean

        If amount <> 0 And (amount > amountDue) = False Then
            checkAmount = True
        Else
            checkAmount = False
            MessageBox.Show("Invalid Input")
        End If

        Dim newTotal As Decimal = amountDue - amount

        Dim conTwo As SqlConnection = New SqlConnection("Server = 146.230.177.46\ist3; Database = group22; User Id = group22; Password = n24mc")

        conTwo.Open()
        command = New SqlCommand("UPDATE Customer SET AmountDue = @NewTotal WHERE CustomerID = @ID", conTwo)

        If checkAmount And checkConversion Then
            command.Parameters.Add("@NewTotal", SqlDbType.Decimal).Value = newTotal
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID
            Try
                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Amount Due Updated")
                    command = New SqlCommand("INSERT INTO Payment(CustomerID, AmountPaid, PaymentDate) VALUES(@ID, @amount, @thisDate)", conTwo)
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    command.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount
                    command.Parameters.Add("@thisDate", SqlDbType.Date).Value = thisDate
                    If command.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Payment Saved")
                    Else
                        MessageBox.Show("Payment Not Saved")
                    End If
                Else
                    MessageBox.Show("Amount Due Not Updated")
                End If
            Catch ex As Exception
                '' MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Update Cancelled")
        End If

        conTwo.Close()
        conTwo.Dispose()
        conTwo = Nothing

        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        command = New SqlCommand("SELECT CustomerID, FirstName, Surname, PhoneNumber, AmountDue, AmountCap FROM Customer WHERE (CustomerID <> 4)", connection)
        PopulateGrid(command)

        With FormMainMenu
            .FormSetUp(FormMain)
            .FormSetUp(ViewCustomers)
        End With

    End Sub

End Class
