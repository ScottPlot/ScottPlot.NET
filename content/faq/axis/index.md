---
title: Axes and Axis Limits - ScottPlot FAQ
description: Axis Styles, axis limits, and multiple axes in ScottPlot
---

# Axes and Axis Limits

This page summarizes how axes are customized in ScottPlot

## Axis Labels, Ticks, Lines, and Grid

* An **axis** displays information on one edge of a plot

* The **axis label** is the title displayed on an axis

* **Tick marks** are small lines drawn on the figure outside the data area

* **Tick labels** can be displayed for each tick mark

* **Grid lines** are lines at each tick mark drawn on the data area

* **Axis lines** are single lines drawn on the edge of the axis. Axis lines of the four primary axes form a rectangle that outlines the data area.

* Axes have **major ticks** and **minor ticks**. The default behavior is that both display axis lines and tick marks, but only major ticks display tick labels and grid lines.

## Primary, Secondary, and Additional Axes

* Plots have **4 axes** by default (2 primary, 2 secondary)

* **Primary axes** on the bottom (`Plot.XAxis`) and left (`Plot.YAxis`) are fully visible by default

* **Secondary axes** on the top (`Plot.XAxis2`) and right (`Plot.YAxis2`) only display axis lines by default

* The **Title** of a plot is just the axis label of the top axis (`Plot.XAxis2`)

* **Additional axes** can be added with `Plot.AddAxis()`

## Axis Limits

* **SetAxisLimits()** manually defines limits for the primary axes

* **AxisAuto()** automatically adjusts primary axis limits to fit visible data

* **GetAxisLimits()** returns current limits for the primary axes

* **SetAxisBoundaries()** can be used to ensure axis limits stay within a defined boundary

## Multiple Axes

ScottPlot supports multiple X and Y axes. This topic is covered in the [Multi-Axis FAQ page](../multi-axis).