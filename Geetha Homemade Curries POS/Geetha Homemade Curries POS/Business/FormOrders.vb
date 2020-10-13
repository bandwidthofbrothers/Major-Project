Imports System.ComponentModel

Public Class FormOrders
    Public Sub addMenuItems(orderID As Integer, MenuItemName As String, Quantity As Integer)
        DataGridViewOrders.Rows.Add(orderID, MenuItemName, Quantity)
        DataGridViewOrders.Sort(DataGridViewOrders.Columns(0), ListSortDirection.Descending)
    End Sub

End Class