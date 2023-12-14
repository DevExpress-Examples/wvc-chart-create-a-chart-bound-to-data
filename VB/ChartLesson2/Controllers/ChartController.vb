Imports System.Linq
Imports System.Web.Mvc

Namespace ChartLesson2.Controllers

    Public Class ChartController
        Inherits Controller

        Public Function Index() As ActionResult
            Using dbContext = New Models.NwindDbContext()
                Dim category =(From c In dbContext.Categories Where Equals(c.CategoryName, "Beverages") Select c).First()
                Dim query = From p In dbContext.Products Where p.CategoryID = category.CategoryID Select p
                Return View(query.ToList())
            End Using
        End Function
    End Class
End Namespace
