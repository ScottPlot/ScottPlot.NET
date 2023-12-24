---
Title: Line Plot Legend 123 - ScottPlot 5.0 Cookbook
Description: Line plots with labels appear in the legend.
URL: /cookbook/5.0/LinePlot/LinePlotLegendQWER
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Line Plot", "Line Plot Legend 123"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/LinePlot", "/cookbook/5.0/LinePlot/LinePlotLegendQWER"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Line Plot Legend 123



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Line plots with labels appear in the legend.

[![](/cookbook/5.0/images/LinePlotLegendQWER.png)](/cookbook/5.0/images/LinePlotLegendQWER.png)

```cs
ScottPlot.Plot myPlot = new();

var sin = myPlot.Add.Signal(Generate.Sin());
var cos = myPlot.Add.Signal(Generate.Cos());

var line = myPlot.Add.Line(1, 12, 12, 0);
line.LineStyle.Width = 3;
line.MarkerStyle.Size = 10;

sin.Label = "Sine";
cos.Label = "Cosine";
line.Label = "Line Plot";

myPlot.ShowLegend(Alignment.UpperRight);

myPlot.SavePng("demo.png");

```

