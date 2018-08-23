Imports System.Data.Entity

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Return View()
    End Function

    Function CsvReport() As ActionResult

        Response.ContentType = "text/plain"
        Response.Write("CustomerId, Name, OrderCount, SalesTotal" & vbCr)

        Using db As New AppDbContext()

            Dim customerOrderData =
            (
                From Cust In db.Customers.Include(Function(o) o.Orders)
                Select Cust
            ).ToList

            For Each c In customerOrderData
                Response.Write(String.Format("{0}, {1}, ", c.CustomerId, c.Name))

                Dim orderCount As Integer = 0
                Dim salesTotal As Decimal = 0

                orderCount = c.Orders.Count
                salesTotal = c.Orders.Sum(Function(x) x.SalesTotal)

                Response.Write(String.Format("{0}, {1}", orderCount, salesTotal.ToString("0.##")) & vbCr)
            Next

        End Using

        Response.End()

        Return Nothing
    End Function

End Class
