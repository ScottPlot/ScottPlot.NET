---
title: MultiPlot - ScottPlot FAQ
description: How to create multi-plot figures with ScottPlot
date: 2023-12-13
---

# Multi-Plot Figures

Multi-plot figures can be achieved one of two ways:

### Use the Multiplot System

* Place a single plot control and interact with its `Multiplot` property to add subplots and setup shared axes and layouts as documented in the [**ScottPlot Demo**](/demo/5.0/) and [**Shared Axes**](../shared-axes/) pages.

### Place Multiple Plot Controls

* Place multiple plot controls and interact the `Plot` property of each and use the `Layout` class to achieve shared axis limits as documented in the [**Shared Axis Demo**](/demo/5.0/#shared-axes) page.

## Shared Layout

`Plot` layouts are dynamically sized to accommodate changing tick label sizes, but this can result in misalignment across plots with different axis limits. See the [**Shared Layout FAQ Page**](../shared-layout) to learn how to resolve this issue.

![](/images/faq/multiplot/multiplot-alignment.png)