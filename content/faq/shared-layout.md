---
title: Shared Layout - ScottPlot FAQ
description: How to align layouts across multiple controls
date: 2024-12-26
---

## Shared Layout

`Plot` layouts are dynamically sized to accommodate changing tick label sizes, but this can result in misalignment across plots with different axis limits. 

![](/images/faq/multiplot/multiplot-alignment.png)

Use the `Plot.Layout.Fixed()` method to apply a standard layout to multiple controls to achieve alignment.

```cs
// use a fixed padding on all edges of the data area
PixelPadding padding = new(100, 50, 100, 50);

// apply the same padding to all plots
myPlot1.Layout.Fixed(padding);
myPlot2.Layout.Fixed(padding);
```

{{< vertical-space >}}

### Related Pages
* [Shared Axis Limits](../shared-axes)
* [Multiplot](../multiplot)