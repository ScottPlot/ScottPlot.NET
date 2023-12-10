---
title: Plottable Objects - ScottPlot FAQ
description: How to create plottable objects, add them to plots, and interact with their data and styling
---

# Working with Plottable Objects

* A **Plottable** is anything you can display on a plot. 

* The **scatter plot** is the most commonly used plottable, and many plottables can be added to a plot. Other plottables like the **signal plot** offer superior performance for large datasets, so all plottable types should be considered.

* **Call a control's `Render()` method** after modifying a plot's data or styling to request a redraw on the screen.

## Create Plottables with Helper Methods
The simplest way to plot data is to use helper methods. Helper methods create a plottable, customize it with optional methods, and add it to the plot.

```cs
double[] xs = { 1, 2, 3, 4, 5 };
double[] ys = { 1, 4, 9, 16, 25 };

var plt = new ScottPlot.Plot(400, 300);
plt.PlotScatter(xs, ys, color: Color.Red, lineWidth: 2);
plt.SaveFig("example.png");
```

![](create-plottable-red.png)

## Plottables can be Modified After Creation

Helper methods return the plottable they create, allowing further customization using public fields and methods. 

In GUI environments, this is how plottable style and data can be modified after it has already been added to the plot.

```cs
var plt = new ScottPlot.Plot(400, 300);
var scatter = plt.PlotScatter(xs, ys);
scatter.color = Color.Blue;
scatter.lineWidth = 2;
plt.SaveFig("example.png");
```

![](create-plottable-blue.png)

## Create Plottables Manually

Creating a plottable manually gives the user maximum ability to customize it. It also allows users to create their own plot types and add them to the plot.

```cs
var plt = new ScottPlot.Plot(400, 300);
var scatter = new ScottPlot.Plottable.ScatterPlot(xs, ys);
scatter.color = Color.Green;
scatter.lineWidth = 2;
plt.SaveFig("example.png");
```

![](create-plottable-green.png)