---
Title: Hide Grid - ScottPlot 5.0 Cookbook
Description: Grid lines can be hidden.
URL: /cookbook/5.0/CustomizingGrids/HideGrid/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Grids", "Hide Grid"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingGrids", "/cookbook/5.0/CustomizingGrids/HideGrid"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingGrids/HideGrid'>Hide Grid</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingGrids/HideGrid">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingGrids">Category: Customizing Grids</a>
</div>

Grid lines can be hidden.

[![](/cookbook/5.0/images/HideGrid.png?241031194635)](/cookbook/5.0/images/HideGrid.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


