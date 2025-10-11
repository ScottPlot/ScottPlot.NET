---
Title: Hide Grid - ScottPlot 5 Cookbook
Description: Grid lines can be hidden.
URL: /cookbook/5/CustomizingGrids/HideGrid/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Customizing Grids", "Hide Grid"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/CustomizingGrids", "/cookbook/5/CustomizingGrids/HideGrid"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Hide Grid</h1>
</div>

Grid lines can be hidden.

[![](/cookbook/5/images/HideGrid.png?251011113742)](/cookbook/5/images/HideGrid.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/GridRecipes.cs" imageUrl="/cookbook/5/images/HideGrid.png?251011113742" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/CustomizingGrids'>Customizing Grids</a> category</div>


