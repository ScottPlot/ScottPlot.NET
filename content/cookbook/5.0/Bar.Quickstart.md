---
Title: Bar Plot Quickstart - ScottPlot 5.0 Cookbook
Description: Bar plots can be added from a series of values.
URL: /cookbook/5.0/Bar/Quickstart
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bar Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/Quickstart"]
Date: 12/13/2023 2:24:04 PM
Version: ScottPlot 5.0.10-beta
---

# Bar Plot Quickstart



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Bar plots can be added from a series of values.

[![](/cookbook/5.0/images/Quickstart.png)](/cookbook/5.0/images/Quickstart.png)

```cs
ScottPlot.Plot myPlot = new();

double[] values = { 5, 10, 7, 13 };
myPlot.Add.Bars(values);
myPlot.AutoScale();
myPlot.SetAxisLimits(bottom: 0);

myPlot.SavePng("demo.png");

```

