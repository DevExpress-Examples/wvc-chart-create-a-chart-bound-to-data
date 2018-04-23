Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Product
    Public Property ProductID As Integer

    <Required>
    <StringLength(40)>
    Public Property ProductName As String

    Public Property SupplierID As Integer?

    Public Property CategoryID As Integer?

    <StringLength(20)>
    Public Property QuantityPerUnit As String

    <Column(TypeName:="smallmoney")>
    Public Property UnitPrice As Decimal?

    Public Property UnitsInStock As Short?

    Public Property UnitsOnOrder As Short?

    Public Property ReorderLevel As Short?

    Public Property Discontinued As Boolean

    <Column(TypeName:="text")>
    Public Property EAN13 As String

    Public Overridable Property Category As Category
End Class
