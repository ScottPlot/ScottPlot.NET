---
title: ScottPlot FAQ
description: Frequently asked questions about the ScottPlot library, user controls, and implementation suggestions.
date: 2023-12-13
---

{{< banner-sp5 >}}

# ScottPlot 5.0 FAQ

* [ScottPlot 5.0 Cookbook](/cookbook/5.0/)
* [ScottPlot 5.0 Demo Application](/demo/)
* [Locking the render system in multi-threaded/async environments](/faq/async/)
* [Launching interactive plot windows from console applications](/faq/launch-console/)

# ScottPlot 4.1 FAQ

{{< specific-sp4 >}}

### ScottPlot Basics
* [Creating, Adding, and Modifying Plottable objects](plottable)
* [Favor SignalPlot over ScatterPlot](scatter-vs-signal)
* [Axis Styles, Axis Limits, and Multiple Axes](axis)
* [Create Custom Plot Types](custom-plot-type)

### Plot: Axis and Tick Customizations
* [DateTime Axis Units](datetime)
* [Using Multiple or Additional Axes](multi-axis)

### Plot: Styling
* [Layout Customization](layout)
* [Frameless Plots and Data Margin](https://scottplot.net/faq/layout/#frameless-plots)
* [Anti-Aliasing](anti-aliasing)

### Plot: Data
* [Plotting Data Types Other than `double[]`](data-format)
* [Data Containing Gaps](data-gaps)
* [Data Containing NaN and Infinity](nan)
* [Plot Financial Data](finance)

### Plot: Miscellaneous
* [MultiPlot: Multiple Plots in a Single Image](multiplot)
* [MVVM Pattern and Data Binding](mvvm)
* [How to Print a ScottPlot](print)
* [Display Scaling (small text vs. blurry text)](dpi-scaling)
* [Font Issues on Linux or MacOS](linux-font)
* [How to tag plotted objects with custom objects](tag)

### User Control: Interactive Behavior
* [Low Quality while Dragging](anti-aliasing)
* [Multiple Plots with a Shared Axis](shared-axes)
* [Custom Right-Click Menu](right-click-menu)
* [Get the Mouse Position](mouse-position)
* [Show the Value of the Point Under the Cursor](mouse-position#highlight-the-data-point-near-the-cursor)
* [Advanced customization using the `Configuration` object](configuration)
* [Change what left, right, or middle buttons do](buttons)
* [Add ScottPlot control programmatically (WinForms)](add-winforms-programmatically)

### User Control: Live Data
* [How to display live, changing data in a ScottPlot control](live-data)
  * [Changing Values in Fixed-Length Data](live-data/#changing-fixed-length-data)
  * [Rolling/Shifting Values in Fixed-Length Data](live-data/#rolling-fixed-length-data)
  * [Growing Data with Partial Array Rendering](live-data/#growing-data-with-partial-array-rendering)
  * [Growing Data with ScatterPlotList](live-data/#growing-data-with-scatterplotlist)
  * [Growing Data with SignalPlotList](live-data/#growing-data-with-signalplotlist)

### Developer Notes
* [ScottPlot Versions](../versions)
* [What's New in ScottPlot 4.1](version-4.1)
* [What's New in ScottPlot 5.0](version-5.0)
* [ScottPlot's Dependencies by Version](dependencies)
* [Development Environment Setup](environment)
* [About ScottPlot](/about)
* [How to Create Reproducible Code Examples](repro)
