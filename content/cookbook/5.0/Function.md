---
Title: Function - ScottPlot 5.0 Cookbook
Description: Function plots are a type of line plot where Y positions are defined by a function that depends on X rather than a collection of discrete data points.
URL: /cookbook/5.0/Function/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Function"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Function"]
Date: 2024-01-11
Version: ScottPlot 5.0.14-beta
Version: ScottPlot 5.0.14-beta
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Function



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.14-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



<h2><a href='/cookbook/5.0/Function/FunctionQuickstart'>Function Quickstart</a></h2>

Create a function plot from a formula.

[![](/cookbook/5.0/images/FunctionQuickstart.png)](/cookbook/5.0/images/FunctionQuickstart.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 14);
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
myPlot.Axes.SetLimits(-10, 10, -1.5, 1.5);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>

