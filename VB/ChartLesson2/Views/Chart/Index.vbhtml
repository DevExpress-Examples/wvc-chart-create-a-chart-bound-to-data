@Code
    ViewData("Title") = "Chart Getting Started Lesson 2"

    ' Specifying obligatory properties of the Chart
    ' and customize the chart appearance.
    Dim settings = New ChartControlSettings With {
        .Name = "chart",
        .PaletteName = "Office 2013",
        .Width = 640,
        .Height = 360
    }

    ' Create a New series bound to data model.
    Dim view As SideBySideBarSeriesView = New SideBySideBarSeriesView()
    view.ColorEach = True
    view.FillStyle.FillMode = FillMode.Solid

    Dim series = New Series With {
        .View = view,
        .LegendTextPattern = "{A}"
    }
    series.ArgumentDataMember = "ProductName"
    series.ValueDataMembers.AddRange("UnitPrice")
    settings.Series.Add(series)

    ' Add a chart title.
    settings.Titles.Add(New ChartTitle With {.Text = "Beverage product prices comparison"})

    ' Configure the crosshair cursor options.
    settings.CrosshairOptions.ShowArgumentLabels = True
    settings.CrosshairOptions.ShowValueLabels = True
    settings.CrosshairOptions.ShowValueLine = True

    Html.DevExpress().Chart(settings).Bind(Model).GetHtml()
End Code
