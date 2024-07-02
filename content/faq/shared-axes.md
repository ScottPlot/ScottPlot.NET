---
title: Shared Axes - ScottPlot FAQ
description: How to have two user controls with shared axes so when one pans, the other pans automatically
date: 2023-12-13
---

## Shared Axis

Two plots can have their axes linked so that interacting with one automatically updates the other.

See the [**Shared Axis demo**](/demo/5.0/#shared-axes) for more information.

![](/images/demo/5.0/linked-axes.gif)

## Shared Layout

Even if axis limits are identical between two controls, differences in tick length, axis label, or other styling options may result in data areas of slightly different sizes and an appearance of misalignment. The best way to achieve identical alignment between controls is to use a fixed padding system.

```cs
PixelPadding padding = new(100, 50, 100, 50);
myPlot.Layout.Fixed(padding);
```

See the [**ScottPlot Cookbook**](/cookbook) for more information.