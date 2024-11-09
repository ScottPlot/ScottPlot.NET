---
Title: Grid Above Data - ScottPlot 5.0 Cookbook
Description: Grid lines are typically drawn beneath data, but grids can be configured to render on top of plottables too.
URL: /cookbook/5.0/CustomizingGrids/GridAbove/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Grids", "Grid Above Data"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingGrids", "/cookbook/5.0/CustomizingGrids/GridAbove"]
Date: 2024-11-09
Version: ScottPlot 5.0.44
Version: ScottPlot 5.0.44
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Grid Above Data</h1>
</div>

Grid lines are typically drawn beneath data, but grids can be configured to render on top of plottables too.

[![](/cookbook/5.0/images/GridAbove.png?241109132219)](/cookbook/5.0/images/GridAbove.png?241109132219)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/GridRecipes.cs" imageUrl="/cookbook/5.0/images/GridAbove.png?241109132219" >}}ScottPlot.Plot myPlot = new();

var sig = myPlot.Add.Signal(ScottPlot.Generate.Sin());
sig.LineWidth = 10;

myPlot.Grid.MajorLineWidth = 3;
myPlot.Grid.MajorLineColor = Colors.Black.WithAlpha(.2);
myPlot.Grid.IsBeneathPlottables = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingGrids'>Customizing Grids</a> category</div>


