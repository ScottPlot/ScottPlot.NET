---
Title: Marker Legend - ScottPlot 5.0 Cookbook
Description: Markers with labels appear in the legend.
URL: /cookbook/5.0/Marker/MarkerLegend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker", "Marker Legend"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker", "/cookbook/5.0/Marker/MarkerLegend"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Marker Legend</h1>
</div>

Markers with labels appear in the legend.

[![](/cookbook/5.0/images/MarkerLegend.png?250822231048)](/cookbook/5.0/images/MarkerLegend.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5.0/images/MarkerLegend.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var sin = myPlot.Add.Signal(Generate.Sin());
sin.LegendText = "Sine";

var cos = myPlot.Add.Signal(Generate.Cos());
cos.LegendText = "Cosine";

var marker = myPlot.Add.Marker(25, .5);
marker.LegendText = "Marker";
myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Marker'>Marker</a> category</div>


