Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class NwindModel
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=NwindModelSettings")
    End Sub

    Public Overridable Property Categories As DbSet(Of Category)
    Public Overridable Property Products As DbSet(Of Product)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Product)() _
            .Property(Function(e) e.UnitPrice) _
            .HasPrecision(10, 4)

        modelBuilder.Entity(Of Product)() _
            .Property(Function(e) e.EAN13) _
            .IsUnicode(False)
    End Sub
End Class
