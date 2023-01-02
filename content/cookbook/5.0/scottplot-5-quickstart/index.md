---
title: ScottPlot 5 Quickstart - ScottPlot 5.0 Cookbook
description: A survey of basic functionality in ScottPlot 5
url: /cookbook/5.0/scottplot-5-quickstart/
date: 1/2/2023 12:00:28 AM
---

This page is part of the [ScottPlot 5.0 Cookbook](../)


<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.0-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



## Scatter Plot

Display paired X/Y data as a scatter plot.

[![](scatter-plot.png)](scatter-plot.png)

```cs
ScottPlot.Plot myPlot = new();

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
myPlot.Add.Scatter(dataX, dataY);

myPlot.SavePng("scatter-plot.png");
```


## Customizing Plottables

Functions that add things to plots return the plottables they create. Interact with the properties of plottables to customize their styling and behavior.

[![](customizing-plottables.png)](customizing-plottables.png)

```cs
ScottPlot.Plot myPlot = new();

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
var myScatter = myPlot.Add.Scatter(dataX, dataY);
myScatter.LineStyle.Width = 5;
myScatter.LineStyle.Color = Colors.Green.WithOpacity(.2);
myScatter.MarkerStyle.Fill.Color = Colors.Magenta;
myScatter.MarkerStyle.Size = 15;

myPlot.SavePng("customizing-plottables.png");
```


## Signal Plot

Signal plots are optimized for displaying evenly spaced data.

[![](signal-plot.png)](signal-plot.png)

```cs
ScottPlot.Plot myPlot = new();

double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);
myPlot.Add.Signal(sin);
myPlot.Add.Signal(cos);

myPlot.SavePng("signal-plot.png");
```


## Signal Plot Performance

Signal plots can interactively display millions of data points in real time. Double-click the plot to display performance benchmarks.

[![](signal-plot-performance.png)](signal-plot-performance.png)

```cs
ScottPlot.Plot myPlot = new();

double[] data = Generate.RandomWalk(1_000_000);
myPlot.Add.Signal(data);
myPlot.Title.Label.Text = $"Signal plot with one million points.";

myPlot.SavePng("signal-plot-performance.png");
```


## Axis Labels

Axis labels can be extensively customized.

[![](axis-labels.png)](axis-labels.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.XAxis.Label.Text = "Horizonal Axis";
myPlot.YAxis.Label.Text = "Vertical Axis";
myPlot.Title.Label.Text = "Plot Title";

myPlot.SavePng("axis-labels.png");
```


## Legend

A legend displays plottables in a key along the edge of a plot. Most plottables have a Label property which configures what text appears in the legend.

[![](legend.png)](legend.png)

```cs
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.Label = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.Label = "Cos";

myPlot.SavePng("legend.png");
```

