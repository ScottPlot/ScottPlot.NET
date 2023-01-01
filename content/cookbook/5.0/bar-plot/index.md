---
title: Bar Plot - ScottPlot 5.0 Cookbook
description: Bar plots represent values as horizontal or vertical rectangles
url: /cookbook/5.0/bar-plot/
date: 1/1/2023 6:56:53 PM
---

This page is part of the [ScottPlot 5.0 Cookbook](../)

<div class="alert alert-warning" role="alert">
<strong>⚠️ WARNING:</strong> This page describes <code>ScottPlot 5.0.0-beta</code>, a preview version of ScottPlot available on NuGet. This package is not recommended for production use, and the API may change in future releases. Visit the <a href='/cookbook/4.1/'>ScottPlot 4.1 Cookbook</a> for information about the current stable version of ScottPlot.
</div>


## Bar Plot Quickstart

Bar plots can be added from a series of values.

[![](bar-plot-quickstart.png)](bar-plot-quickstart.png)

```cs
ScottPlot.Plot myPlot = new();

double[] values = { 5, 10, 7, 13 };
myPlot.Add.Bar(values);
myPlot.AutoScale();
myPlot.SetAxisLimits(bottom: 0);

myPlot.SavePng("bar-plot-quickstart.png");
```


## Bar Positioning

The exact position and size of each bar may be customized.

[![](bar-positioning.png)](bar-positioning.png)

```cs
ScottPlot.Plot myPlot = new();

List<ScottPlot.Plottables.Bar> bars = new()
{
    new() { Position = 5, Value = 5, ValueBase = 3, },
    new() { Position = 10, Value = 7, ValueBase = 0, },
    new() { Position = 15, Value = 3, ValueBase = 2, },
};

myPlot.Add.Bar(bars);

myPlot.SavePng("bar-positioning.png");
```


## Bar Series

Bar plots can be grouped into bar series and plotted together.

[![](bar-series.png)](bar-series.png)

```cs
ScottPlot.Plot myPlot = new();

List<ScottPlot.Plottables.Bar> bars1 = new() { new() { Value = 5 }, new() { Value = 7 }, new() { Value = 9 }, };
List<ScottPlot.Plottables.Bar> bars2 = new() { new() { Value = 3 }, new() { Value = 8 }, new() { Value = 5 }, };
List<ScottPlot.Plottables.Bar> bars3 = new() { new() { Value = 7 }, new() { Value = 10 }, new() { Value = 7 }, };

ScottPlot.Plottables.BarSeries series1 = new() { Bars = bars1, Label = "Series 1", Color = Colors.Red };
ScottPlot.Plottables.BarSeries series2 = new() { Bars = bars2, Label = "Series 2", Color = Colors.Green };
ScottPlot.Plottables.BarSeries series3 = new() { Bars = bars3, Label = "Series 3", Color = Colors.Blue };

List<ScottPlot.Plottables.BarSeries> seriesList = new() { series1, series2, series3 };

myPlot.Add.Bar(seriesList);

myPlot.AutoScale();
myPlot.SetAxisLimits(bottom: 0);

myPlot.SavePng("bar-series.png");
```

