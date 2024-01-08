---
Title: Right Axis - ScottPlot 5.0 Cookbook
Description: New plots have one axis on every side. Axes on the right and top are invisible by default. To use the right axis, make it visible, then tell a plottable to use it. 
URL: /cookbook/5.0/MultiAxis/RightAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Advanced Axis Features", "Right Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiAxis", "/cookbook/5.0/MultiAxis/RightAxis"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Right Axis



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



New plots have one axis on every side. Axes on the right and top are invisible by default. To use the right axis, make it visible, then tell a plottable to use it. 

[![](/cookbook/5.0/images/RightAxis.png)](/cookbook/5.0/images/RightAxis.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

// plot data with very different scales
var sig1 = myPlot.Add.Signal(Generate.Sin(mult: 0.01));
var sig2 = myPlot.Add.Signal(Generate.Cos(mult: 100));

// tell each signal plot to use a different axis
sig1.Axes.YAxis = myPlot.Axes.Left;
sig2.Axes.YAxis = myPlot.Axes.Right;

// add additional styling options to each axis
myPlot.Axes.Left.Label.Text = "Left Axis";
myPlot.Axes.Right.Label.Text = "Right Axis";
myPlot.Axes.Left.Label.ForeColor = sig1.Color;
myPlot.Axes.Right.Label.ForeColor = sig2.Color;

myPlot.SavePng("demo.png");

```

