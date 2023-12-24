---
Title: Signal Plot Performance - ScottPlot 5.0 Cookbook
Description: Signal plots can interactively display millions of data points in real time. Double-click the plot to display performance benchmarks.
URL: /cookbook/5.0/Quickstart/SignalPerformance
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "ScottPlot 5 Quickstart", "Signal Plot Performance"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Quickstart", "/cookbook/5.0/Quickstart/SignalPerformance"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Signal Plot Performance



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Signal plots can interactively display millions of data points in real time. Double-click the plot to display performance benchmarks.

[![](/cookbook/5.0/images/SignalPerformance.png)](/cookbook/5.0/images/SignalPerformance.png)

```cs
ScottPlot.Plot myPlot = new();

double[] data = Generate.RandomWalk(1_000_000);
myPlot.Add.Signal(data);
myPlot.Title("Signal plot with one million points");

myPlot.SavePng("demo.png");

```

