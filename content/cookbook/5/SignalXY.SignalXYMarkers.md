---
Title: SignalXY with Markers - ScottPlot 5 Cookbook
Description: Users can enable a marker to be displayedat each data point. However, this can reduce performance for extremely large datasets.
URL: /cookbook/5/SignalXY/SignalXYMarkers/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "SignalXY Plot", "SignalXY with Markers"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/SignalXY", "/cookbook/5/SignalXY/SignalXYMarkers"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY with Markers</h1>
</div>

Users can enable a marker to be displayedat each data point. However, this can reduce performance for extremely large datasets.

[![](/cookbook/5/images/SignalXYMarkers.png?260329072039)](/cookbook/5/images/SignalXYMarkers.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5/images/SignalXYMarkers.png?260329072039" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sig = myPlot.Add.SignalXY(xs, ys);
sig.MarkerStyle.Shape = MarkerShape.FilledCircle;
sig.MarkerStyle.Size = 5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/SignalXY'>SignalXY Plot</a> category</div>


