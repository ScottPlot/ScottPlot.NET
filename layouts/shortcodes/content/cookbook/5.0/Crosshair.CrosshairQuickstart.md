---
Title: Crosshair Quickstart - ScottPlot 5.0 Cookbook
Description: A Crosshair combines a horizontal axis line and vertical axis line to mark a location in coordinate space.
URL: /cookbook/5.0/Crosshair/CrosshairQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Crosshair", "Crosshair Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Crosshair", "/cookbook/5.0/Crosshair/CrosshairQuickstart"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Crosshair Quickstart</h1>
</div>

A Crosshair combines a horizontal axis line and vertical axis line to mark a location in coordinate space.

[![](/cookbook/5.0/images/CrosshairQuickstart.png?250322130304)](/cookbook/5.0/images/CrosshairQuickstart.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Crosshair.cs" imageUrl="/cookbook/5.0/images/CrosshairQuickstart.png?250322130304" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Crosshair(13, .25);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Crosshair'>Crosshair</a> category</div>


