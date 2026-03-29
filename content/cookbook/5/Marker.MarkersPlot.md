---
Title: Many Markers - ScottPlot 5 Cookbook
Description: Collections of markers that are all styled the same may be added to the plot
URL: /cookbook/5/Marker/MarkersPlot/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Marker", "Many Markers"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Marker", "/cookbook/5/Marker/MarkersPlot"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Many Markers</h1>
</div>

Collections of markers that are all styled the same may be added to the plot

[![](/cookbook/5/images/MarkersPlot.png?260329072039)](/cookbook/5/images/MarkersPlot.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5/images/MarkersPlot.png?260329072039" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);

myPlot.Add.Markers(xs, sin, MarkerShape.OpenCircle, 15, Colors.Green);
myPlot.Add.Markers(xs, cos, MarkerShape.FilledDiamond, 10, Colors.Magenta);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Marker'>Marker</a> category</div>


