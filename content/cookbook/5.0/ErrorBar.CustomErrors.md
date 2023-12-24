---
Title: ErrorBar Values - ScottPlot 5.0 Cookbook
Description: Error size can be set for all dimensions.
URL: /cookbook/5.0/ErrorBar/CustomErrors
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Error Bars", "ErrorBar Values"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ErrorBar", "/cookbook/5.0/ErrorBar/CustomErrors"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# ErrorBar Values



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Error size can be set for all dimensions.

[![](/cookbook/5.0/images/CustomErrors.png)](/cookbook/5.0/images/CustomErrors.png)

```cs
ScottPlot.Plot myPlot = new();

int points = 10;

ScottPlot.RandomDataGenerator gen = new();

double[] xs = ScottPlot.Generate.Consecutive(points);
double[] ys = ScottPlot.Generate.RandomWalk(points);
var scatter = myPlot.Add.Scatter(xs, ys);
scatter.LineStyle.Width = 0;

ScottPlot.Plottables.ErrorBar eb = new(
    xs: xs,
    ys: ys,
    xErrorsNegative: gen.RandomSample(points, .5),
    xErrorsPositive: gen.RandomSample(points, .5),
    yErrorsNegative: gen.RandomSample(points),
    yErrorsPositive: gen.RandomSample(points));

eb.Color = scatter.Color;

myPlot.Add.Plottable(eb);

myPlot.SavePng("demo.png");

```

