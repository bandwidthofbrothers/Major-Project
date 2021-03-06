﻿Public Class FormAddMenuItem
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim name As String = TextBoxName.Text
        Dim category As String = ComboBoxCategory.Text

        Dim conversionSuccessful As Boolean = False
        Dim price As Decimal = Decimal.TryParse(TextBoxPrice.Text, conversionSuccessful)

        If conversionSuccessful Then
            Try
                price = Decimal.Parse(TextBoxPrice.Text, System.Globalization.NumberFormatInfo.CurrentInfo)

                MenuItemTableAdapter.InsertMenuItem(name, category, price)

                MessageBox.Show("Record added successfully")

                With FormMainMenu
                    .FormSetUp(FormMain)
                    .FormSetUp(FormViewMenu)
                End With

                Me.TopMost = True
            Catch ex As Exception
                MessageBox.Show("Error: Record added unsuccessfully")
            End Try
        Else
            MessageBox.Show("Error: Record added unsuccessfully")
        End If

        TextBoxName.Text = ""
        TextBoxPrice.Text = ""
        ComboBoxCategory.Text = ""

    End Sub

    Private Sub FormAddMenuItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class