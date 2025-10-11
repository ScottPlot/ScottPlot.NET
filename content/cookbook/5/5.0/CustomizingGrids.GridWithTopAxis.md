---
Title: Grid with Top Axis - ScottPlot 5.0 Cookbook
Description: Grid lines use the bottom and left axes by default, but this behavior can be customized for plots which use other axes.
URL: /cookbook/5.0/CustomizingGrids/GridWithTopAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Grids", "Grid with Top Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingGrids", "/cookbook/5.0/CustomizingGrids/GridWithTopAxis"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Grid with Top Axis</h1>
</div>

Grid lines use the bottom and left axes by default, but this behavior can be customized for plots which use other axes.

[![](/cookbook/5.0/images/GridWithTopAxis.png?250126165944)](/cookbook/5.0/images/GridWithTopAxis.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/GridRecipes.cs" imageUrl="/cookbook/5.0/images/GridWithTopAxis.png?250126165944" >}}ScottPlot.Plot myPlot = new();

var sig = myPlot.Add.Signal(ScottPlot.Generate.Sin());
sig.Axes.XAxis = myPlot.Axes.Top;
myPlot.Grid.XAxis = myPlot.Axes.Top;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingGrids'>Customizing Grids</a> category</div>


