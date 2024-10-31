---
Title: Grid Fill Color in Dark Mode - ScottPlot 5.0 Cookbook
Description: Grid and plot styling can be customize to achieve a pleasing effect in dark mode
URL: /cookbook/5.0/CustomizingGrids/GridAlternatingDarkMode/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Grids", "Grid Fill Color in Dark Mode"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingGrids", "/cookbook/5.0/CustomizingGrids/GridAlternatingDarkMode"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingGrids/GridAlternatingDarkMode'>Grid Fill Color in Dark Mode</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingGrids/GridAlternatingDarkMode">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingGrids">Category: Customizing Grids</a>
</div>

Grid and plot styling can be customize to achieve a pleasing effect in dark mode

[![](/cookbook/5.0/images/GridAlternatingDarkMode.png?241031194635)](/cookbook/5.0/images/GridAlternatingDarkMode.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add a green data line
var sig = myPlot.Add.Signal(Generate.SquareWaveFromSines());
sig.LineWidth = 3;
sig.Color = new("#2b9433");
sig.AlwaysUseLowDensityMode = true;

// give the plot a dark background with light text
myPlot.FigureBackground.Color = new("#1c1c1e");
myPlot.Axes.Color(new("#888888"));

// shade regions between major grid lines
myPlot.Grid.XAxisStyle.FillColor1 = new Color("#888888").WithAlpha(10);
myPlot.Grid.YAxisStyle.FillColor1 = new Color("#888888").WithAlpha(10);

// set grid line colors
myPlot.Grid.XAxisStyle.MajorLineStyle.Color = Colors.White.WithAlpha(15);
myPlot.Grid.YAxisStyle.MajorLineStyle.Color = Colors.White.WithAlpha(15);
myPlot.Grid.XAxisStyle.MinorLineStyle.Color = Colors.White.WithAlpha(5);
myPlot.Grid.YAxisStyle.MinorLineStyle.Color = Colors.White.WithAlpha(5);

// enable minor grid lines by defining a positive width
myPlot.Grid.XAxisStyle.MinorLineStyle.Width = 1;
myPlot.Grid.YAxisStyle.MinorLineStyle.Width = 1;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


