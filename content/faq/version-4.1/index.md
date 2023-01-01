---
title: What's New in ScottPlot 4.1
description: Notable changes between ScottPlot 4.0 and 4.1
---

**ScottPlot 4.1 replaced ScottPlot 4.0 in May, 2021.** This page summarizes major new features and changes likely to be encountered when upgrading from ScottPlot 4.0 and 4.1. The ScottPlot Cookbook is an excellent source of documentation for how to use the latest new features.

### Major New Features
* Support for multiple X and Y axes
* Extensive new customization options for axes, ticks, and grids
* Stateless rendering for improved performance and thread safety
* Simplified common configuration module for user controls
* Support for render requests that don't block the UI thread
* Improved event handling to allow customization of user controls

### Methods to Add Plottables Have New Names

Methods now start with the word `Add`. This is consistent with the fact that custom plottables can be instantiated and passed into `Plot.Add()`, and also makes it more obvious that a `Plot.Clear()` exists.

```cs
var plt = new ScottPlot.Plot();

// ScottPlot 4.0
plt.PlotBar()
plt.PlotSignal()
plt.PlotScatter()

// ScottPlot 4.1
plt.AddBar()
plt.AddSignal()
plt.AddScatter()
```

### Improved Naming for Plottables

Plottables are now in the `ScottPlot.Plottable` namespace and may have been renamed to improve readability. Public fields and methods have been renamed and capitalized to be more discoverable and idiomatic.

```cs
// ScottPlot 4.0
var old = new ScottPlot.PlottableBar();
old.fillColor = Color.Red;
old.lineWidth = 3;

// ScottPlot 4.1
var new = new ScottPlot.Plottable.BarPlot();
new.FillColor = Color.Red;
new.LineWidth = 3;
```

### Axis Manipulation

Setting and getting axis limits is a little more refined.

```cs
// ScottPlot 4.0
plt.Axis(x1: -10, x2: 10);
double[] oldLimits = plt.Axis();
Console.WriteLine($"horizontal from {oldLimits[0]} to {oldLimits[1]}");

// ScottPlot 4.1
plt.SetAxisLimits(xMin: -10, xMax: 10);
AxisLimits newLimits = plt.GetAxisLimits();
Console.WriteLine($"horizontal from {newLimits.XMin} to {newLimits.XMax}");
```

### Axis Styling

Configuration methods with dozens of optional arguments have been replaced by individual axis objects and smaller methods.

```cs
// ScottPlot 4.0
plt.Ticks(dateTimeX: true, xTickRotation: 45);

// ScottPlot 4.1
plt.XAxis.DateTimeFormat(enable: true);
plt.XAxis.TickLabelStyle(rotation: 45);
```

### Modifying Data in Plottables

To reduce likelihood of accidentally putting plottable data into a bad state, most plottables now have public `Update()` methods for replacing data arrays.

```cs
// ScottPlot 4.0
var old = plt.PlotScatter(xs, ys);
old.xs = newXs;
old.ys = newYs;

// ScottPlot 4.1
var new = plt.AddScatter(xs, ys);
new.Update(newXs, newYs);
```

### User Control Configuration

All controls now share a common `Configuration` class with public fields and methods which replace functionality that used to be found in the `Configure()` method.

```cs
// ScottPlot 4.0
formsPlot1.Configure(enableScrollWheelZoom: true);

// ScottPlot 4.1
formsPlot1.Configuration.ScrollWheelZoom = true;
```