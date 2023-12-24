---
Title: Multi-Axis - ScottPlot 5.0 Cookbook
Description: Additional axes may be added to plots. Plottables are displayed using the coordinate system of the primary axes by default, but any plottable can be displayed using any X and Y axis.
URL: /cookbook/5.0/MultiAxis/MultiAxisQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Advanced Axis Features", "Multi-Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiAxis", "/cookbook/5.0/MultiAxis/MultiAxisQuickstart"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Multi-Axis



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Additional axes may be added to plots. Plottables are displayed using the coordinate system of the primary axes by default, but any plottable can be displayed using any X and Y axis.

[![](/cookbook/5.0/images/MultiAxisQuickstart.png)](/cookbook/5.0/images/MultiAxisQuickstart.png)

```cs
ScottPlot.Plot myPlot = new();

// plottables use the standard X and Y axes by default
var sig1 = myPlot.Add.Signal(ScottPlot.Generate.Sin(51, mult: 0.01));
sig1.Axes.XAxis = myPlot.XAxis; // standard X axis
sig1.Axes.YAxis = myPlot.YAxis; // standard Y axis
myPlot.YAxis.Label.Text = "Primary Y Axis";

// create a second axis and add it to the plot
ScottPlot.AxisPanels.LeftAxis yAxis2 = new();
myPlot.YAxes.Add(yAxis2);

// add a new plottable and tell it to use the custom Y axis
var sig2 = myPlot.Add.Signal(ScottPlot.Generate.Cos(51, mult: 100));
sig2.Axes.XAxis = myPlot.XAxis; // standard X axis
sig2.Axes.YAxis = yAxis2; // custom Y axis
yAxis2.Label.Text = "Secondary Y Axis";

myPlot.SavePng("demo.png");

```

