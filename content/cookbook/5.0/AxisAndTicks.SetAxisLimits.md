---
Title: Manually Set Axis Limits - ScottPlot 5.0 Cookbook
Description: Axis Limits can be set manually in different ways.
URL: /cookbook/5.0/AxisAndTicks/SetAxisLimits
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Manually Set Axis Limits"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/SetAxisLimits"]
Date: 12/13/2023 2:24:04 PM
Version: ScottPlot 5.0.10-beta
---

# Manually Set Axis Limits



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Axis Limits can be set manually in different ways.

[![](/cookbook/5.0/images/SetAxisLimits.png)](/cookbook/5.0/images/SetAxisLimits.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

// Interact with a specific axis
myPlot.XAxis.Min = -100;
myPlot.XAxis.Max = 150;
myPlot.YAxis.Min = -5;
myPlot.YAxis.Max = 5;

// Call a helper function
myPlot.SetAxisLimits(-100, 150, -5, 5);

myPlot.SavePng("demo.png");

```

