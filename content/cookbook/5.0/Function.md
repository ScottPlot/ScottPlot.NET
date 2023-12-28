---
Title: Function - ScottPlot 5.0 Cookbook
Description: Function plots are a type of line plot where Y positions are defined by a function that depends on X rather than a collection of discrete data points.
URL: /cookbook/5.0/Function/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Function"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Function"]
Date: 2023-12-28
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Function



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



## Function Quickstart

Create a function plot from a formula.

[![](/cookbook/5.0/images/FunctionQuickstart.png)](/cookbook/5.0/images/FunctionQuickstart.png)

```cs
ScottPlot.Plot myPlot = new();

// Functions are defined as delegates with an input and output
var func1 = new Func<double, double>((x) => Math.Sin(x) * Math.Sin(x / 2));
var func2 = new Func<double, double>((x) => Math.Sin(x) * Math.Sin(x / 3));
var func3 = new Func<double, double>((x) => Math.Cos(x) * Math.Sin(x / 5));

// Add functions to the plot
myPlot.Add.Function(func1);
myPlot.Add.Function(func2);
myPlot.Add.Function(func3);

// Manually set axis limits because functions do not have discrete data points
myPlot.SetAxisLimits(-10, 10, -1.5, 1.5);

myPlot.SavePng("demo.png");

```

