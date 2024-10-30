---
Title: Axis Specific Grid Customization - ScottPlot 5.0 Cookbook
Description: Axis-specific styling properties are available for extensive axis-specific customization of grid line styling.
URL: /cookbook/5.0/CustomizingGrids/GridCustomAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Grids", "Axis Specific Grid Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingGrids", "/cookbook/5.0/CustomizingGrids/GridCustomAxis"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingGrids/GridCustomAxis'>Axis Specific Grid Customization</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingGrids/GridCustomAxis">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingGrids">Category: Customizing Grids</a>
</div>

Axis-specific styling properties are available for extensive axis-specific customization of grid line styling.

[![](/cookbook/5.0/images/GridCustomAxis.png?241029205813)](/cookbook/5.0/images/GridCustomAxis.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Grid.XAxisStyle.MajorLineStyle.Color = Colors.Magenta.WithAlpha(.1);
myPlot.Grid.XAxisStyle.MajorLineStyle.Width = 5;

myPlot.Grid.YAxisStyle.MajorLineStyle.Color = Colors.Green.WithAlpha(.3);
myPlot.Grid.YAxisStyle.MajorLineStyle.Width = 2;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


