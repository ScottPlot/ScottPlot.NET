---
title: ScatterPlot vs SignalPlot - ScottPlot FAQ
description: Scatter and signal plots are the most commonly used plot types, so ensure you understand the pros and cons of each
date: 2023-12-13
---

{{< banner-sp5 >}}

{{< specific-sp4 >}}

# Signal Plots are More Performant than Scatter Plots

* **Scatter plots have paired X/Y data points.** Scatter plots are designed to display ***hundreds*** of points, but performance rapidly drops as the number of points increases, so scatter plots are not appropriate for large datasets.

* **Signal plots have Y data and a sample rate.** Signal plots are optimized for performance and can render datasets with ***millions*** of points at a high framerate.

* **SignalConst** plots uses an algorithm optimized for constant data values, allowing interactive rendering of ***hundreds of millions*** of data points at a high framerate.
