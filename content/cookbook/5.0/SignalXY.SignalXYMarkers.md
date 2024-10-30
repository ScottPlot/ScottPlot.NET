---
Title: SignalXY with Markers - ScottPlot 5.0 Cookbook
Description: Users can enable a marker to be displayedat each data point. However, this can reduce performance for extremely large datasets.
URL: /cookbook/5.0/SignalXY/SignalXYMarkers/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "SignalXY with Markers"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYMarkers"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/SignalXY/SignalXYMarkers'>SignalXY with Markers</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/SignalXY/SignalXYMarkers">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/SignalXY">Category: SignalXY Plot</a>
</div>

Users can enable a marker to be displayedat each data point. However, this can reduce performance for extremely large datasets.

[![](/cookbook/5.0/images/SignalXYMarkers.png?241029205813)](/cookbook/5.0/images/SignalXYMarkers.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sig = myPlot.Add.SignalXY(xs, ys);
sig.MarkerStyle.Shape = MarkerShape.FilledCircle;
sig.MarkerStyle.Size = 5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


