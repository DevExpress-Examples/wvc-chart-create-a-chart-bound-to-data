Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc

Namespace ChartLesson2.Controllers
    Public Class ChartController
        Inherits Controller

        Public Function Index() As ActionResult
            Using dbContext = New Models.NwindDbContext()
                Dim category = ( _
                    From c In dbContext.Categories _
                    Where c.CategoryName = "Beverages" _
                    Select c).First()
                Dim query = From p In dbContext.Products _
                            Where p.CategoryID = category.CategoryID _
                            Select p
                Return View(query.ToList())
            End Using
        End Function
    End Class
End Namespace
