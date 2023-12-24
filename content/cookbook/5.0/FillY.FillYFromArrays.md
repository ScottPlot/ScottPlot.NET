---
Title: FillY From Array Data - ScottPlot 5.0 Cookbook
Description: FillY plots can be created from X, Y1, and Y2 arrays.
URL: /cookbook/5.0/FillY/FillYFromArrays
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "FillY plot", "FillY From Array Data"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/FillY", "/cookbook/5.0/FillY/FillYFromArrays"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# FillY From Array Data



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



FillY plots can be created from X, Y1, and Y2 arrays.

[![](/cookbook/5.0/images/FillYFromArrays.png)](/cookbook/5.0/images/FillYFromArrays.png)

```cs
ScottPlot.Plot myPlot = new();

RandomDataGenerator dataGen = new(0);

int count = 20;
double[] xs = ScottPlot.Generate.Consecutive(count);
double[] ys1 = dataGen.RandomWalk(count, offset: -5);
double[] ys2 = dataGen.RandomWalk(count, offset: 5);

var xyy = myPlot.Add.FillY(xs, ys1, ys2);
xyy.FillStyle.Color = Colors.Magenta.WithAlpha(100);

myPlot.SavePng("demo.png");

```

