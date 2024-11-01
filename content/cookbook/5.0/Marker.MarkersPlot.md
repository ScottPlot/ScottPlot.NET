---
Title: Many Markers - ScottPlot 5.0 Cookbook
Description: Collections of markers that are all styled the same may be added to the plot
URL: /cookbook/5.0/Marker/MarkersPlot/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker", "Many Markers"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker", "/cookbook/5.0/Marker/MarkersPlot"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Many Markers</h1>
</div>

Collections of markers that are all styled the same may be added to the plot

[![](/cookbook/5.0/images/MarkersPlot.png?241101192719)](/cookbook/5.0/images/MarkersPlot.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);

myPlot.Add.Markers(xs, sin, MarkerShape.OpenCircle, 15, Colors.Green);
myPlot.Add.Markers(xs, cos, MarkerShape.FilledDiamond, 10, Colors.Magenta);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Marker'>Marker</a> category</div>


