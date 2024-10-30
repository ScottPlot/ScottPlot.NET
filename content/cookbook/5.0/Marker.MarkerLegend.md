---
Title: Marker Legend - ScottPlot 5.0 Cookbook
Description: Markers with labels appear in the legend.
URL: /cookbook/5.0/Marker/MarkerLegend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker", "Marker Legend"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker", "/cookbook/5.0/Marker/MarkerLegend"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Marker/MarkerLegend'>Marker Legend</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Marker/MarkerLegend">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Marker">Category: Marker</a>
</div>

Markers with labels appear in the legend.

[![](/cookbook/5.0/images/MarkerLegend.png?241029205813)](/cookbook/5.0/images/MarkerLegend.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var sin = myPlot.Add.Signal(Generate.Sin());
sin.LegendText = "Sine";

var cos = myPlot.Add.Signal(Generate.Cos());
cos.LegendText = "Cosine";

var marker = myPlot.Add.Marker(25, .5);
marker.LegendText = "Marker";
myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


