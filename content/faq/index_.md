---
title: ScottPlot FAQ
description: Frequently asked questions about the ScottPlot library, user controls, and implementation suggestions.
url: "faq"
date: 2020-01-01
---

### Introduction to ScottPlot
* [Creating, Adding, and Modifying Plottable objects](plottable)
* [Favor SignalPlot over ScatterPlot](scatter-vs-signal)
* [Axis Styles, Axis Limits, and Multiple Axes](axis)

### Plot: Axis and Ticks
* [DateTime Axis Units](datetime)
* [Using Multiple or Additional Axes](multi-axis)

### Plot: Styling
* [Custom Padding around the Data Area](padding)
* [Frameless Plots and Data Margin](padding/#frameless-plot)
* [Anti-Aliasing](anti-aliasing)

### Plot: Data
* [Plotting Data Types Other than `double[]`](data-format)
* [Data Containing Gaps](data-gaps)
* [Data Containing NaN and Infinity](nan)

### Plot: Miscellaneous
* [MultiPlot: Multiple Plots in a Single Image](multiplot)
* [MVVM Pattern and Data Binding](mvvm)
* [How to Print a ScottPlot](print)
* [Display Scaling (small text vs. blurry text)](dpi-scaling)

### User Control: Interactive Behavior
* [Low Quality while Dragging](anti-aliasing)
* [Multiple Plots with a Shared Axis](shared-axes)
* [Custom Right-Click Menu](right-click-menu)
* [Get the Mouse Position](mouse-position)
* [Show the Value of the Point Under the Cursor](mouse-position#highlight-the-data-point-near-the-cursor)
* [Use RenderLock() in multi-threaded/async environments](async)

### User Control: Live Data
* [How to display live, changing data in a ScottPlot control](live-data)
  * [Changing Values in Fixed-Length Data](live-data/#changing-fixed-length-data)
  * [Rolling/Shifting Values in Fixed-Length Data](live-data/#rolling-fixed-length-data)
  * [Growing Data with Partial Array Rendering](live-data/#growing-data-with-partial-array-rendering)
  * [Growing Data with ScatterPlotList](live-data/#growing-data-with-scatterplotlist)
  * [Growing Data with SignalPlotList](live-data/#growing-data-with-signalplotlist)

### Version Notes
* [What's New in ScottPlot 4.1](version-4.1)
* [ScottPlot's Dependencies by Version](dependencies)

### About ScottPlot
* [Why the Name _ScottPlot_?](history)
* [Who Created ScottPlot and Why?](history)
* [ScottPlot vs. Other Plotting Libraries](compare)