Imports System.ComponentModel.DataAnnotations

Public Class Order

    <Key>
    Public Property OrderId As Integer
    Public Property OrderDate As DateTime?
    Public Property ShipDate As DateTime?
    Public Property SalesTotal As Decimal
    Public Property Customer As Customer

End Class
