---
Title: Many Markers - ScottPlot 5.0 Cookbook
Description: Collections of markers that are all styled the same may be added to the plot
URL: /cookbook/5.0/Marker/MarkersPlot/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker", "Many Markers"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker", "/cookbook/5.0/Marker/MarkersPlot"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Marker/MarkersPlot'>Many Markers</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Marker/MarkersPlot">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Marker">Category: Marker</a>
</div>

Collections of markers that are all styled the same may be added to the plot

[![](/cookbook/5.0/images/MarkersPlot.png?241031194635)](/cookbook/5.0/images/MarkersPlot.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);

myPlot.Add.Markers(xs, sin, MarkerShape.OpenCircle, 15, Colors.Green);
myPlot.Add.Markers(xs, cos, MarkerShape.FilledDiamond, 10, Colors.Magenta);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


