---
title: Layout Mechanics and Customization - ScottPlot FAQ
description: Advanced configuration for the data area, axes, figure padding, etc.
date: 2023-12-13
---

# Advanced Layout Customization

This page summarizes how plot layouts are created automatically and how this behavior can be customized. For additional information and code examples, refer to the following Cookbook sections:
* [ScottPlot 4.1 Cookbook: Layout](https://scottplot.net/cookbook/4.1/#layout)
* [ScottPlot 4.1 Cookbook: Axis and Ticks](https://scottplot.net/cookbook/4.1/#axis-and-ticks)
* [ScottPlot 4.1 Cookbook: Advanced Axis Features](https://scottplot.net/cookbook/4.1/#advanced-axis-features)

## Figure Size and Data Area

✔️ The **Figure Rectangle** is the pixel size of the image or user control.

✔️ The **Data Rectangle** is portion of the figure where plottable objects are drawn.

![](images/areas.png)

### Automatic Layout System

The data rectangle is recalculated every time the plot is rendered. 

The automatic layout system is responsible for "shrinking" the data area as tick labels grow in size.

The automatic layout system measures all axes, recalculates tick positions and measures all their labels, and determines how much space is required on each side of the data rectangle. The calculated data area rectangle is then passed into plottables when they are rendered.

### Manual Data Area

The automatic layout system is recommended for virtually all users. However, users who want extreme customization can disable the automatic layout system and define the data rectangle manually ([Cookbook: Manual Data Area](https://scottplot.net/cookbook/4.1/category/layout/#manual-data-area)):

```cs
ScottPlot.PixelPadding padding = new(150, 30, 100, 10);
myPlot.ManualDataArea(padding);
```


## Axis Sizes Determine Data Area

✔️ The data area is reduced on each side to accommodate size covered by **axes**

✔️ **Axes** have a **Label** and **Ticks**

✔️ The size of each axis is calculated by the layout system

✔️ `YAxis` and `XAxis` are visible by default

✔️ `YAxis2` and `XAxis2` ticks are hidden by default. Even though they are not visible, these axes have a default minimum size which improves the default layout.

✔️ Setting a plot's title really just sets the `XAxis2.Label`

![](images/components.png)

## Components Influencing Axis Size

✔️ **Tick Marks** and **Tick Labels** - If enabled, ticks are recalculated at each render and the largest tick label is measured to determine how much space should be allocated for tick labels. 

✔️ **Axis Label** - If enabled, axis labels are measured at render time to determine how much space they occupy.

✔️ **Axis Padding** - A few extra pixels placed at the outer edge of an axis to ensure labels don't flow outside the figure area.

✔️ Axes without visible ticks or labels still have padding by default to provide a few pixels of empty space between the data rectangle and the edge of the plot.

![](images/axis.png)

### Configure Axis Size

The size of each axis is determined at render time.

Axis sizes can be "clamped" between a min/max value ([Cookbook: Axis Size](https://scottplot.net/cookbook/4.1/category/layout/#axis-size)):

```cs
myPlot.XAxis.Layout(minimumSize: 100, maximumSize: 150);
```

Axis sizes can be fixed by setting min and max size to the same value:

```cs
myPlot.XAxis.Layout(minimumSize: 123, maximumSize: 123);
```

Axis padding can be configured too ([Cookbook: Axis Padding](https://scottplot.net/cookbook/4.1/category/layout/#axis-padding)):

```cs
myPlot.XAxis.Layout(padding: 50);
```

### Multi-Axis Plots

If a plot has multiple axes, the size of each Axis is measured at render time, and the data area is reduced by the total size to accommodate all axes.

### Tick Label Measurement

Calculating tick label size requirements is more complex than it initially seems. Tick generation requires knowing the ideal tick density (number of ticks per pixel) which requires knowing both the estimated tick label length and the data area size... but these are the two measurements we are tying to determine in the first place. 

This chicken-and-egg problem is solved by generating ticks using an estimated layout (based on fixed pixel sizes for all axes), tick labels are then measured and a temporary data rectangle is created from these values, then a final set of ticks is generated based on these inputs, and their labels are measured to determine axis size and contribute to final data area.

## Hiding an Axis

There are multiple ways to customize visibility of individual axes

### Set Axis Component Visibility

One option for hiding an axis is to disable rendering of all its components. See [Cookbook: Axis - One Axis Only](https://scottplot.net/cookbook/4.1/category/axis-and-ticks/#one-axis-only) and adjacent cookbook recipes for more information.

```cs
plt.XAxis.Label(""); // removes text from the axis label
plt.XAxis.Ticks(false); // disables tick marks and labels
plt.XAxis.Line(false); // hides the black line framing the data area
```

### Set Axis Component Sizes

Another option for hiding individual axes is to use their `Layout()` to set the size of their components to. See [Cookbook: Layout - Axis Size](https://scottplot.net/cookbook/4.1/category/layout/#axis-size) and adjacent cookbook recipes for more information.

```cs
myPlot.XAxis.Layout(maximumSize: 0);
```

### Set Axis Visibility

Axes have an `IsVisible` flag that allows everything to be disabled with one command. Setting this to `false` hides the ticks, tick labels, axis label, and disables all axis padding.

```cs
formsPlot1.Plot.XAxis.IsVisible = false;
```

## Frameless Plots

A common use case is to have a plot whose data area _is_ the figure area, and all axes are hidden. A helper method has been created to facilitate this: [Cookbook: Frameless Plot](https://scottplot.net/cookbook/4.1/category/layout/#frameless-plot)

```cs
myPlot.Frameless();
```

![](images/frameless.png)

## Data Padding (Margins)

Everything discussed above relates to the _layout_ of the figure in pixel units.

Sometimes users wish to adjust _axis limits_ to zoom in or zoom out according to their data: [Cookbook: Data Margins](https://scottplot.net/cookbook/4.1/category/layout/#data-margins)
