---
title: ScottPlot, NaN, and Infinity - ScottPlot FAQ
description: How does ScottPlot treat data arrays containing NaN and Infinity?
date: 2023-12-13
---

# Plotting Data Containing NaN and Infinity

NaN-checks are not routinely performed inside the render loop (a decision favoring maximal performance), so attempting to plot `double[]` containing NaN may result in unexpected behavior (including exceptions). In general it is a good idea to avoid plotting data containing any of:

Most plot types cannot display `double[]` containing:
* `Double.PositiveInfinity`
* `Double.NegativeInfinity`
* `Double.NaN`

## Scatter Plots with NaN data

The default behavior of Scatter plots is to throw an exception when users try to load it with data containing NaN. However, this behavior can be customized by assigning the `OnNaN` field.

### Ignore NaN

The `OnNaN = Ignore` behavior skips-over NaN values and connect the adjacent real values with lines.

![](scatter_nan_ignore.png)

```cs
var plt = new ScottPlot.Plot(600, 400);
var scatter1 =plt.AddScatter(xs, ys, Color.Gray);
var scatter2 = plt.AddScatter(xs, ysWithNan, Color.Black);
scatter2.OnNaN = ScottPlot.Plottable.ScatterPlot.NanBehavior.Ignore;
```

### Data Gaps with NaN

The `OnNaN = Gap` behavior treats NaN values as a line break, simulating the appearance of gaps in the data.

![](scatter_nan_gap.png)

```cs
var plt = new ScottPlot.Plot(600, 400);
var scatter1 = plt.AddScatter(xs, ys, Color.Gray);
var scatter2 = plt.AddScatter(xs, ysWithNan, Color.Black);
scatter2.OnNaN = ScottPlot.Plottable.ScatterPlot.NanBehavior.Gap;
```