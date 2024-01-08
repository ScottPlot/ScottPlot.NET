---
Title: Signal Plot Quickstart - ScottPlot 5.0 Cookbook
Description: Signal plots are best for extremely large datasets. They use render using special optimizations that allow highspeed interactivity with plots containing millions of data points.
URL: /cookbook/5.0/Signal/SignalQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Signal Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalQuickstart"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Signal Plot Quickstart



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Signal plots are best for extremely large datasets. They use render using special optimizations that allow highspeed interactivity with plots containing millions of data points.

[![](/cookbook/5.0/images/SignalQuickstart.png)](/cookbook/5.0/images/SignalQuickstart.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

double[] values = Generate.RandomWalk(1_000_000);

myPlot.Add.Signal(values);

myPlot.Title("Signal Plot with 1 Million Points");

myPlot.SavePng("demo.png");

```

