---
Title: Hide Grid - ScottPlot 5.0 Cookbook
Description: Grid lines can be hidden.
URL: /cookbook/5.0/CustomizingGrids/HideGrid/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Grids", "Hide Grid"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingGrids", "/cookbook/5.0/CustomizingGrids/HideGrid"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Hide Grid



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Grid lines can be hidden.

[![](/cookbook/5.0/images/HideGrid.png)](/cookbook/5.0/images/HideGrid.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.HideGrid();

myPlot.SavePng("demo.png");

```

