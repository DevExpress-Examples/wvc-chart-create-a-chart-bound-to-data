@Code
    ViewData("Title") = "Index"
End Code

@Html.DevExpress().Chart(Sub(settings)
                                  'Specify the obligatory Name property of the chart.
                                  settings.Name = "chart"

                                  ' Configure the chart appearance.
                                  settings.Width = 640
                                  settings.Height = 360
                                  settings.PaletteName = "Office 2013"

                                  ' Add a New series bound to data.
                                  settings.Series.Add(Sub(s)
                                                          ' Set argument and value data members.
                                                          s.SetDataMembers("ProductName", "UnitPrice")

                                                          ' Change a pattern used to form text in legend items.
                                                          s.LegendTextPattern = "{A}"

                                                          ' Configure the series appearance.
                                                          s.Views().SideBySideBarSeriesView(Sub(v)
                                                                                                v.FillStyle.FillMode = FillMode.Solid
                                                                                                v.ColorEach = True
                                                                                            End Sub)
                                                      End Sub)

                                  ' Add a chart title.
                                  settings.Titles.Add(Sub(t)
                                                          t.Text = "Beverage product prices comparison"
                                                      End Sub)
                                  ' Configure the crosshair cursor options.
                                  settings.CrosshairOptions.ShowArgumentLabels = True
                                  settings.CrosshairOptions.ShowValueLabels = True
                                  settings.CrosshairOptions.ShowValueLine = True
                              End Sub).Bind(Model).GetHtml()
