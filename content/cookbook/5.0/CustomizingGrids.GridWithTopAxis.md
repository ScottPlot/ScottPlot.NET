---
Title: Grid with Top Axis - ScottPlot 5.0 Cookbook
Description: Grid lines use the bottom and left axes by default, but this behavior can be customized for plots which use other axes.
URL: /cookbook/5.0/CustomizingGrids/GridWithTopAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Grids", "Grid with Top Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingGrids", "/cookbook/5.0/CustomizingGrids/GridWithTopAxis"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingGrids/GridWithTopAxis'>Grid with Top Axis</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingGrids/GridWithTopAxis">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingGrids">Category: Customizing Grids</a>
</div>

Grid lines use the bottom and left axes by default, but this behavior can be customized for plots which use other axes.

[![](/cookbook/5.0/images/GridWithTopAxis.png?241029205813)](/cookbook/5.0/images/GridWithTopAxis.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var sig = myPlot.Add.Signal(ScottPlot.Generate.Sin());
sig.Axes.XAxis = myPlot.Axes.Top;
myPlot.Grid.XAxis = myPlot.Axes.Top;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


