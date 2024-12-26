---
title: Shared Axes - ScottPlot FAQ
description: How to have two user controls with shared axes so when one pans, the other pans automatically
date: 2023-12-13
---

## Shared Axis Limits

Multiple plots can be configured so changes the axis limits of one plot are applied to other plots. The strategy used to achieve this behavior depends on how multiple plots have been added to the application:

* **Multiple Plot Controls:** The [**Shared Axis Demo**](/demo/5.0/#shared-axes) shows how to use `Plot.Axes.Link()` to automatically configure `AxisLimitsChanged` events to update all plots when axis limits of any plot are changed.

* **Using `Multiplot` in a Single Plot Control:** When the `Multiplot` class is used to place multiple plots, they may be easily synchronized using the `ShareX()` and `ShareY()` helper methods as described on the [**Multiplot FAQ Page**](../multiplot)

![](/images/demo/5.0/linked-axes.gif)

## Shared Layout

`Plot` layouts are dynamically sized to accommodate changing tick label sizes, but this can result in misalignment across plots with different axis limits. See the [**Shared Layout FAQ Page**](../shared-layout) to learn how to resolve this issue.

![](/images/faq/multiplot/multiplot-alignment.png)