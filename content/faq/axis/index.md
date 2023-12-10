---
title: Axes and Axis Limits - ScottPlot FAQ
description: Axis Styles, axis limits, and multiple axes in ScottPlot
---

# Axes and Axis Limits

ScottPlot displays data in a rectangular view of a 2D coordinate system. The edges of this view are referred to as **Axis Limits**, and this page discusses the various ways axis limits can be adjusted and customized.

## Definitions

### Axis Labels, Ticks, Lines, and Grid

* An **axis** displays information on one edge of a plot

* The **axis label** is the title displayed on an axis

* **Tick marks** are small lines drawn on the figure outside the data area

* **Tick labels** can be displayed for each tick mark

* **Grid lines** are lines at each tick mark drawn on the data area

* **Axis lines** are single lines drawn on the edge of the axis. Axis lines of the four primary axes form a rectangle that outlines the data area.

* Axes have **major ticks** and **minor ticks**. The default behavior is that both display axis lines and tick marks, but only major ticks display tick labels and grid lines.

### Primary, Secondary, and Additional Axes

* Plots have **4 axes** by default (2 primary, 2 secondary)

* **Primary axes** on the bottom (`Plot.XAxis`) and left (`Plot.YAxis`) are fully visible by default

* **Secondary axes** on the top (`Plot.XAxis2`) and right (`Plot.YAxis2`) only display axis lines by default

* The **Title** of a plot is just the axis label of the top axis (`Plot.XAxis2`)

* **Additional axes** can be added with `Plot.AddAxis()`

## Set Limits Manually

The plot area can be defined manually by calling `SetAxisLimits()` and passing in the edges of the rectangle you wish to view.

```cs
// show a plot from -10 to +10 on X axis and -20 to +20 on Y axis
myPlot.SetAxisLimits(-10, 10, -20, 20);
```

## Set Limits Automatically

The `AxisAuto()` command will evaluate every plotted object to determine the limits of the data it contains, then adjust the plot as needed to ensure all data is visible. Optional arguments allow the user to adjust how much extra padding to include around the periphery of the data.

```cs
// resize the plot view to accommodate the data
myPlot.AxisAuto();
```

## Reading Axis Limits

It may be helpful to reference the current axis limits so they can be saved, used for calculations in another part of an application, or applied to another plot. The `GetAxisLimits()` function returns an object which contains properties describing the plot's axis limits when the function was called.

```cs
// read current limits
var limits = myPlot.GetAxisLimits();

// properties hold axis view information
Console.WriteLine($"X goes from {limits.XMin} to {limits.XMax}");

// apply those limits to a different plot
myOtherPlot.SetAxisLimits(limits);
```

## Set Boundaries on the Axis Limits

Sometimes you want the user to be able to zoom in and out, but not farther than a range you control. The **boundaries** of the axis limits can be set using these functions:

```cs
// disable zooming out farther than 0 to +50 horizontally or -1 to +1 vertically
formsPlot1.Plot.XAxis.SetBoundary(0, 50);
formsPlot1.Plot.YAxis.SetBoundary(-1, 1);
```

```cs
// disable zooming in closer than 10 to 20 horizontally or 0.1 to 0.2 vertically
formsPlot1.Plot.XAxis.SetInnerBoundary(10, 20);
formsPlot1.Plot.YAxis.SetInnerBoundary(0.1, 0.2);
```

## Disable Zooming or Panning

This behavior can be controlled at the user control level. See the [User Control Configuration Object](../configuration/) page for more details.

```cs
// disable left-click-drag pan
formsPlot1.Configuration.Pan = false;

// disable right-click-drag zoom
formsPlot1.Configuration.Zoom = false;

// disable scroll wheel zoom
formsPlot1.Configuration.ScrollWheelZoom = false;

// disable middle-click-drag zoom window
formsPlot1.Configuration.MiddleClickDragZoom = false;
```

## Axis Limits in Multi-Axis Plots

It is possible to have multiple X or Y axes using ScottPlot, but the functions discussed above all work on the primary X and Y axis by default. All the advice above applies to multi-axis plots, but each of the functions discussed has optional "axis index" arguments which must be defined. For example:

```cs
plt.SetAxisLimits(yMin: -1, yMax: 1, yAxisIndex: 0); // primary Y axis
plt.SetAxisLimits(yMin: -5, yMax: 5, yAxisIndex: 1); // secondary Y axis
```

See the [ScottPlot Cookbook](/cookbook) and [Multi-Axis FAQ page](../multi-axis) for additional example.
