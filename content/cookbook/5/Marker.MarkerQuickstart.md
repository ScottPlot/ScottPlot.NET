---
Title: Marker Quickstart - ScottPlot 5 Cookbook
Description: Markers are symbols placed at a location in coordinate space. Their shape, size, and color can be customized.
URL: /cookbook/5/Marker/MarkerQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Marker", "Marker Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Marker", "/cookbook/5/Marker/MarkerQuickstart"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Marker Quickstart</h1>
</div>

Markers are symbols placed at a location in coordinate space. Their shape, size, and color can be customized.

[![](/cookbook/5/images/MarkerQuickstart.png?260329072039)](/cookbook/5/images/MarkerQuickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5/images/MarkerQuickstart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Marker(25, .5);
myPlot.Add.Marker(35, .6);
myPlot.Add.Marker(45, .7);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Marker'>Marker</a> category</div>


