---
Title: Grid Above Data - ScottPlot 5.0 Cookbook
Description: Grid lines are typically drawn beneath data, but grids can be configured to render on top of plottables too.
URL: /cookbook/5.0/CustomizingGrids/GridAbove/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Grids", "Grid Above Data"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingGrids", "/cookbook/5.0/CustomizingGrids/GridAbove"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingGrids/GridAbove'>Grid Above Data</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingGrids/GridAbove">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingGrids">Category: Customizing Grids</a>
</div>

Grid lines are typically drawn beneath data, but grids can be configured to render on top of plottables too.

[![](/cookbook/5.0/images/GridAbove.png?241029205813)](/cookbook/5.0/images/GridAbove.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var sig = myPlot.Add.Signal(ScottPlot.Generate.Sin());
sig.LineWidth = 10;

myPlot.Grid.MajorLineWidth = 3;
myPlot.Grid.MajorLineColor = Colors.Black.WithAlpha(.2);
myPlot.Grid.IsBeneathPlottables = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


