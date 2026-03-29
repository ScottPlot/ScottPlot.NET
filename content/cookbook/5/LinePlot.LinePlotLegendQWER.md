---
Title: Line Plot Legend - ScottPlot 5 Cookbook
Description: Line plots with labels appear in the legend.
URL: /cookbook/5/LinePlot/LinePlotLegendQWER/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Line Plot", "Line Plot Legend"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/LinePlot", "/cookbook/5/LinePlot/LinePlotLegendQWER"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Line Plot Legend</h1>
</div>

Line plots with labels appear in the legend.

[![](/cookbook/5/images/LinePlotLegendQWER.png?260329072039)](/cookbook/5/images/LinePlotLegendQWER.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Line.cs" imageUrl="/cookbook/5/images/LinePlotLegendQWER.png?260329072039" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/LinePlot'>Line Plot</a> category</div>


