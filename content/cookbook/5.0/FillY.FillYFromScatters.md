---
Title: FillY From Scatter Plots - ScottPlot 5.0 Cookbook
Description: FillY plots can be created from two scatter plots that share the same X values.
URL: /cookbook/5.0/FillY/FillYFromScatters/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "FillY plot", "FillY From Scatter Plots"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/FillY", "/cookbook/5.0/FillY/FillYFromScatters"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# FillY From Scatter Plots



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



FillY plots can be created from two scatter plots that share the same X values.

[![](/cookbook/5.0/images/FillYFromScatters.png)](/cookbook/5.0/images/FillYFromScatters.png)

```cs
ScottPlot.Plot myPlot = new();

RandomDataGenerator dataGen = new(0);

int count = 20;
double[] xs = ScottPlot.Generate.Consecutive(count);
double[] ys1 = dataGen.RandomWalk(count, offset: -5);
double[] ys2 = dataGen.RandomWalk(count, offset: 5);

var scatter1 = myPlot.Add.Scatter(xs, ys1);
var scatter2 = myPlot.Add.Scatter(xs, ys2);

var xyy = myPlot.Add.FillY(scatter1, scatter2);
xyy.FillStyle.Color = Colors.Blue.WithAlpha(100);

myPlot.SavePng("demo.png");

```

