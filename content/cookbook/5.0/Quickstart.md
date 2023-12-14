---
Title: ScottPlot 5 Quickstart - ScottPlot 5.0 Cookbook
Description: A survey of basic functionality in ScottPlot 5
URL: /cookbook/5.0/Quickstart/index.html
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "ScottPlot 5 Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Quickstart"]
Date: 2023-12-14
Version: ScottPlot 5.0.10-beta
---

# ScottPlot 5 Quickstart



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



## Scatter Plot

Display paired X/Y data as a scatter plot.

[![](/cookbook/5.0/images/QuickstartScatter.png)](/cookbook/5.0/images/QuickstartScatter.png)

```cs
ScottPlot.Plot myPlot = new();

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
myPlot.Add.Scatter(dataX, dataY);

myPlot.SavePng("demo.png");

```


## Customizing Plottables

Functions that add things to plots return the plottables they create. Interact with the properties of plottables to customize their styling and behavior.

[![](/cookbook/5.0/images/CustomizingPlottables.png)](/cookbook/5.0/images/CustomizingPlottables.png)

```cs
ScottPlot.Plot myPlot = new();

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
var myScatter = myPlot.Add.Scatter(dataX, dataY);
myScatter.LineStyle.Width = 5;
myScatter.LineStyle.Color = Colors.Green.WithOpacity(.2);
myScatter.MarkerStyle.Fill.Color = Colors.Magenta;
myScatter.MarkerStyle.Size = 15;

myPlot.SavePng("demo.png");

```


## Signal Plot

Signal plots are optimized for displaying evenly spaced data.

[![](/cookbook/5.0/images/QuickstartSignal.png)](/cookbook/5.0/images/QuickstartSignal.png)

```cs
ScottPlot.Plot myPlot = new();

double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);
myPlot.Add.Signal(sin);
myPlot.Add.Signal(cos);

myPlot.SavePng("demo.png");

```


## Signal Plot Performance

Signal plots can interactively display millions of data points in real time. Double-click the plot to display performance benchmarks.

[![](/cookbook/5.0/images/SignalPerformance.png)](/cookbook/5.0/images/SignalPerformance.png)

```cs
ScottPlot.Plot myPlot = new();

double[] data = Generate.RandomWalk(1_000_000);
myPlot.Add.Signal(data);
myPlot.Title("Signal plot with one million points");

myPlot.SavePng("demo.png");

```


## Axis Labels

Axis labels can be extensively customized.

[![](/cookbook/5.0/images/QuickstartAxisLabels.png)](/cookbook/5.0/images/QuickstartAxisLabels.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.XAxis.Label.Text = "Horizonal Axis";
myPlot.YAxis.Label.Text = "Vertical Axis";
myPlot.TitlePanel.Label.Text = "Plot Title";

myPlot.SavePng("demo.png");

```


## Legend

A legend displays plottables in a key along the edge of a plot. Most plottables have a Label property which configures what text appears in the legend.

[![](/cookbook/5.0/images/Legend.png)](/cookbook/5.0/images/Legend.png)

```cs
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.Label = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.Label = "Cos";

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png");

```

