---
Title: Crosshair Quickstart - ScottPlot 5 Cookbook
Description: A Crosshair combines a horizontal axis line and vertical axis line to mark a location in coordinate space.
URL: /cookbook/5/Crosshair/CrosshairQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Crosshair", "Crosshair Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Crosshair", "/cookbook/5/Crosshair/CrosshairQuickstart"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Crosshair Quickstart</h1>
</div>

A Crosshair combines a horizontal axis line and vertical axis line to mark a location in coordinate space.

[![](/cookbook/5/images/CrosshairQuickstart.png?260329072039)](/cookbook/5/images/CrosshairQuickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Crosshair.cs" imageUrl="/cookbook/5/images/CrosshairQuickstart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Crosshair(13, .25);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Crosshair'>Crosshair</a> category</div>


