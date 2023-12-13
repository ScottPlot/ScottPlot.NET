---
Title: Legend - ScottPlot 5.0 Cookbook
Description: A legend displays plottables in a key along the edge of a plot. Most plottables have a Label property which configures what text appears in the legend.
URL: /cookbook/5.0/Quickstart/Legend
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "ScottPlot 5 Quickstart", "Legend"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Quickstart", "/cookbook/5.0/Quickstart/Legend"]
Date: 12/13/2023 2:24:04 PM
Version: ScottPlot 5.0.10-beta
---

# Legend



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



A legend displays plottables in a key along the edge of a plot. Most plottables have a Label property which configures what text appears in the legend.

[![](/cookbook/5.0/images/Legend.png)](/cookbook/5.0/images/Legend.png)

```cs
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.Label = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.Label = "Cos";

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png");

```

