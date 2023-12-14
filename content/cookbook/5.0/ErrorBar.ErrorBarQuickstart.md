---
Title: Error Bar Quickstart - ScottPlot 5.0 Cookbook
Description: Error Bars go well with scatter plots.
URL: /cookbook/5.0/ErrorBar/ErrorBarQuickstart/index.html
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Error Bars", "Error Bar Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ErrorBar", "/cookbook/5.0/ErrorBar/ErrorBarQuickstart"]
Date: 2023-12-14
Version: ScottPlot 5.0.10-beta
Version: ScottPlot 5.0.10-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Error Bar Quickstart



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Error Bars go well with scatter plots.

[![](/cookbook/5.0/images/ErrorBarQuickstart.png)](/cookbook/5.0/images/ErrorBarQuickstart.png)

```cs
ScottPlot.Plot myPlot = new();

int points = 30;

double[] xs = ScottPlot.Generate.Consecutive(points);
double[] ys = ScottPlot.Generate.RandomWalk(points);
double[] err = ScottPlot.Generate.Random(points, 0.1, 1);

var scatter = myPlot.Add.Scatter(xs, ys);
var errorbars = myPlot.Add.ErrorBar(xs, ys, err);
errorbars.Color = scatter.Color;

myPlot.SavePng("demo.png");

```

