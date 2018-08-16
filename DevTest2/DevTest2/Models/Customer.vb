Imports System.ComponentModel.DataAnnotations

Public Class Customer

    <Key>
    Public Property CustomerId As Integer
    Public Property Name As String
    Public Overridable Property Orders As ICollection(Of Order)

End Class
