---
title: Advanced Axis Features - ScottPlot 5.0 Cookbook
description: Tick mark customization and creation of multi-Axis plots
url: /cookbook/5.0/advanced-axis-features/
date: 1/1/2023 6:56:53 PM
---

This page is part of the [ScottPlot 5.0 Cookbook](../)

<div class="alert alert-warning" role="alert">
<strong>⚠️ WARNING:</strong> This page describes <code>ScottPlot 5.0.0-beta</code>, a preview version of ScottPlot available on NuGet. This package is not recommended for production use, and the API may change in future releases. Visit the <a href='/cookbook/4.1/'>ScottPlot 4.1 Cookbook</a> for information about the current stable version of ScottPlot.
</div>


## Multi-Axis

Additional axes may be added to plots. Plottables are displayed using the coordinate system of the primary axes by default, but any plottable can be displayed using any X and Y axis.

[![](multi-axis.png)](multi-axis.png)

```cs
ScottPlot.Plot myPlot = new();

// plottables use the standard X and Y axes by default
var sig1 = myPlot.Add.Signal(Generate.Sin(51, mult: 0.01));
sig1.Axes.XAxis = myPlot.XAxis; // standard X axis
sig1.Axes.YAxis = myPlot.YAxis; // standard Y axis
myPlot.YAxis.Label.Text = "Primary Y Axis";

// create a second axis and add it to the plot
ScottPlot.Axis.StandardAxes.LeftAxis yAxis2 = new();
myPlot.YAxes.Add(yAxis2);

// add a new plottable and tell it to use the custom Y axis
var sig2 = myPlot.Add.Signal(Generate.Cos(51, mult: 100));
sig2.Axes.XAxis = myPlot.XAxis; // standard X axis
sig2.Axes.YAxis = yAxis2; // custom Y axis
yAxis2.Label.Text = "Secondary Y Axis";

myPlot.SavePng("multi-axis.png");
```

