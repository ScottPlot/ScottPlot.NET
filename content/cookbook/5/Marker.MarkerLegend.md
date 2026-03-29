---
Title: Marker Legend - ScottPlot 5 Cookbook
Description: Markers with labels appear in the legend.
URL: /cookbook/5/Marker/MarkerLegend/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Marker", "Marker Legend"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Marker", "/cookbook/5/Marker/MarkerLegend"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Marker Legend</h1>
</div>

Markers with labels appear in the legend.

[![](/cookbook/5/images/MarkerLegend.png?260329072039)](/cookbook/5/images/MarkerLegend.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5/images/MarkerLegend.png?260329072039" >}}ScottPlot.Plot myPlot = new();

var sin = myPlot.Add.Signal(Generate.Sin());
sin.LegendText = "Sine";

var cos = myPlot.Add.Signal(Generate.Cos());
cos.LegendText = "Cosine";

var marker = myPlot.Add.Marker(25, .5);
marker.LegendText = "Marker";
myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Marker'>Marker</a> category</div>


