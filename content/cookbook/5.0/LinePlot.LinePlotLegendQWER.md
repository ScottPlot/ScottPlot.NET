---
Title: Line Plot Legend - ScottPlot 5.0 Cookbook
Description: Line plots with labels appear in the legend.
URL: /cookbook/5.0/LinePlot/LinePlotLegendQWER/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Line Plot", "Line Plot Legend"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/LinePlot", "/cookbook/5.0/LinePlot/LinePlotLegendQWER"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/LinePlot/LinePlotLegendQWER'>Line Plot Legend</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/LinePlot/LinePlotLegendQWER">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/LinePlot">Category: Line Plot</a>
</div>

Line plots with labels appear in the legend.

[![](/cookbook/5.0/images/LinePlotLegendQWER.png?241029205813)](/cookbook/5.0/images/LinePlotLegendQWER.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var sin = myPlot.Add.Signal(Generate.Sin());
sin.LegendText = "Sine";

var cos = myPlot.Add.Signal(Generate.Cos());
cos.LegendText = "Cosine";

var line = myPlot.Add.Line(1, 12, 12, 0);
line.LineWidth = 3;
line.MarkerSize = 10;
line.LegendText = "Line Plot";

myPlot.ShowLegend(Alignment.UpperRight);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


