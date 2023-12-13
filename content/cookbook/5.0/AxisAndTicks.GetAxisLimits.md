---
Title: Read Axis Limits - ScottPlot 5.0 Cookbook
Description: The current axis limits can be read in multiple ways.
URL: /cookbook/5.0/AxisAndTicks/GetAxisLimits
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Read Axis Limits"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/GetAxisLimits"]
Date: 12/13/2023 2:24:04 PM
Version: ScottPlot 5.0.10-beta
---

# Read Axis Limits



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



The current axis limits can be read in multiple ways.

[![](/cookbook/5.0/images/GetAxisLimits.png)](/cookbook/5.0/images/GetAxisLimits.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

// Interact with a specific axis
double top = myPlot.YAxis.Max;
double bottom = myPlot.YAxis.Min;

// Call a helper function
AxisLimits limits = myPlot.GetAxisLimits();
double left = limits.Rect.Left;
double center = limits.Rect.HorizontalCenter;

myPlot.SavePng("demo.png");

```

