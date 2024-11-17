---
Title: Marker Quickstart - ScottPlot 5.0 Cookbook
Description: Markers are symbols placed at a location in coordinate space. Their shape, size, and color can be customized.
URL: /cookbook/5.0/Marker/MarkerQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker", "Marker Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker", "/cookbook/5.0/Marker/MarkerQuickstart"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Marker Quickstart</h1>
</div>

Markers are symbols placed at a location in coordinate space. Their shape, size, and color can be customized.

[![](/cookbook/5.0/images/MarkerQuickstart.png?241117162641)](/cookbook/5.0/images/MarkerQuickstart.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5.0/images/MarkerQuickstart.png?241117162641" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Marker(25, .5);
myPlot.Add.Marker(35, .6);
myPlot.Add.Marker(45, .7);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Marker'>Marker</a> category</div>


