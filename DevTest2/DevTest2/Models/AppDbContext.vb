Imports System.Data.Entity

Public Class AppDbContext
    Inherits DbContext

    Public Sub New()

        MyBase.New()

        Database.SetInitializer(New AppDbInitializer())

    End Sub

    Public Property Customers As DbSet(Of Customer)
    Public Property Orders As DbSet(Of Order)

End Class
