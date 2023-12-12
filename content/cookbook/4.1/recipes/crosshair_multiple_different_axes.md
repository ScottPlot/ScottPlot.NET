---
Title: "Crosshairs on Multiple Axes - ScottPlot 4.1 Cookbook"
Description: "Crosshairs label coordinates on the primary axes by default, but the axis index can be changed allowing multiple crosshairs to label multiple axes."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/crosshair_multiple_different_axes/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Crosshair", "Crosshairs on Multiple Axes"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-crosshair", "/cookbook/4.1/recipes/crosshair_multiple_different_axes/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/crosshair_multiple_different_axes.png"
---

<h2><a id='crosshairs-on-multiple-axes' href='/cookbook/4.1/recipes/crosshair_multiple_different_axes/'>Crosshairs on Multiple Axes</a></h2>

Crosshairs label coordinates on the primary axes by default, but the axis index can be changed allowing multiple crosshairs to label multiple axes.

```cs
var plt = new ScottPlot.Plot(600, 400);

// add a signal and crosshair to the primary X and Y axis (index 0)
var signal1 = plt.AddSignal(DataGen.RandomWalk(null, 100));
var cross1 = plt.AddCrosshair(24, 5.29);
cross1.LineWidth = 2;

// add a signal and crosshair to the secondary X and Y axis (index 1)
var signal2 = plt.AddSignal(DataGen.RandomWalk(null, 50));
signal2.YAxisIndex = 1;
signal2.XAxisIndex = 1;

var cross2 = plt.AddCrosshair(33, 5.1);
cross2.HorizontalLine.PositionLabelOppositeAxis = true;
cross2.VerticalLine.PositionLabelOppositeAxis = true;
cross2.YAxisIndex = signal2.YAxisIndex;
cross2.XAxisIndex = signal2.XAxisIndex;
cross2.LineStyle = LineStyle.Dot;
cross2.LineWidth = 2;

// apply signal colors to the crosshairs
cross1.Color = signal1.Color;
cross2.Color = signal2.Color;

// add axis labels
plt.Title("Multiple Crosshairs for different Axes");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");
plt.YAxis2.Label("Signal2 Value");

// show ticks for axes where ticks are hidden by default
plt.YAxis2.Ticks(true);
plt.XAxis2.Ticks(true);

plt.SaveFig("crosshair_multiple_different_axes.png");
```

<img src='../../images/crosshair_multiple_different_axes.png' class='d-block mx-auto my-5' />


