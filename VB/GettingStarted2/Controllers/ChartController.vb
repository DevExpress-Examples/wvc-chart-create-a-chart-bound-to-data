Imports System.Web.Mvc

Namespace Controllers
    Public Class ChartController
        Inherits Controller

        Function Index() As ActionResult
            Using context As New NwindDbContext
                Dim beveragesCategory As Category
                beveragesCategory = context.Categories.Where(Function(c) c.CategoryName = "Beverages").Single()
                Return View(beveragesCategory.Products.ToList())
            End Using
        End Function
    End Class
End Namespace