---
Title: Zoom to Fit Data - ScottPlot 5.0 Cookbook
Description: The axis limits can be automatically adjusted to fit the data. Optional arguments allow users to define the amount of whitespace around the edges of the data.
URL: /cookbook/5.0/AxisAndTicks/AutoScale/index.html
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Zoom to Fit Data"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/AutoScale"]
Date: 2023-12-14
Version: ScottPlot 5.0.10-beta
---

# Zoom to Fit Data



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



The axis limits can be automatically adjusted to fit the data. Optional arguments allow users to define the amount of whitespace around the edges of the data.

[![](/cookbook/5.0/images/AutoScale.png)](/cookbook/5.0/images/AutoScale.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

// set limits that do not fit the data
myPlot.SetAxisLimits(-100, 150, -5, 5);

// reset limits to fit the data
myPlot.AutoScale();

myPlot.SavePng("demo.png");

```

