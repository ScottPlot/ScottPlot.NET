---
Title: SignalXY with Markers - ScottPlot 5.0 Cookbook
Description: Users can enable a marker to be displayedat each data point. However, this can reduce performance for extremely large datasets.
URL: /cookbook/5.0/SignalXY/SignalXYMarkers/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "SignalXY with Markers"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYMarkers"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY with Markers</h1>
</div>

Users can enable a marker to be displayedat each data point. However, this can reduce performance for extremely large datasets.

[![](/cookbook/5.0/images/SignalXYMarkers.png?241102170938)](/cookbook/5.0/images/SignalXYMarkers.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYMarkers.png?241102170938" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sig = myPlot.Add.SignalXY(xs, ys);
sig.MarkerStyle.Shape = MarkerShape.FilledCircle;
sig.MarkerStyle.Size = 5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/SignalXY'>SignalXY Plot</a> category</div>


