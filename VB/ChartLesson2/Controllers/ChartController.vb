Imports System.Web.Mvc

Namespace Controllers
    Public Class ChartController
        Inherits Controller

        ' GET: Chart
        Function Index() As ActionResult
            Using dbContext = New NwindModel()
                Dim query = From product In dbContext.Products
                            Join category In dbContext.Categories On category.CategoryID Equals product.CategoryID
                            Where category.CategoryName = "Beverages"
                            Select product
                Dim result = query.ToList()
                Return View(result)
            End Using
        End Function
    End Class
End Namespace