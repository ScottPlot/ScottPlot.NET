---
Title: Signal Plot - ScottPlot 5.0 Cookbook
Description: Signal plots are optimized for displaying evenly spaced data.
URL: /cookbook/5.0/Quickstart/QuickstartSignal
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "ScottPlot 5 Quickstart", "Signal Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Quickstart", "/cookbook/5.0/Quickstart/QuickstartSignal"]
Date: 2023-12-13
Version: ScottPlot 5.0.10-beta
---

# Signal Plot



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Signal plots are optimized for displaying evenly spaced data.

[![](/cookbook/5.0/images/QuickstartSignal.png)](/cookbook/5.0/images/QuickstartSignal.png)

```cs
ScottPlot.Plot myPlot = new();

double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);
myPlot.Add.Signal(sin);
myPlot.Add.Signal(cos);

myPlot.SavePng("demo.png");

```

