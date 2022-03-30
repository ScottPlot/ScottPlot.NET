---
Title: Axis and Ticks - ScottPlot 4.1 Cookbook
Description: Axis and Ticks recipes
Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook
---

## Axis Customizations

Axes can be customized different ways. Axis labels and colors are the most common types of customizations.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// These shortcuts are the easiest way to set axis labels
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");
plt.Title("Axis Customization");

// Axes labels can be further customized for any axis
plt.YAxis.Label("Vertical Axis", Color.Magenta, size: 24, fontName: "Comic Sans MS");

// This method will set the color of axis labels, lines, ticks, and tick labels
plt.XAxis.Color(Color.Green);

plt.SaveFig("Axis_label.png");
```

<div class='text-center'>
<a href='../../images/axis_label.png'><img src='../../images/axis_label.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Disable Grid

Visibility of primary X and Y grids can be set using a single method.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// hide grids
plt.Grid(false);

plt.SaveFig("axis_gridDisableAll.png");
```

<div class='text-center'>
<a href='../../images/axis_griddisableall.png'><img src='../../images/axis_griddisableall.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Disable Vertical Grid

Grid line visibility can be controlled for each axis individually. Use this to selectively enable grid lines only for the axes of interest. Keep in mind that vertical grid lines are controlled by horizontal axes.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// each axis has its own visibility controls
plt.XAxis.Grid(false);

plt.SaveFig("axis_gridDisableOne.png");
```

<div class='text-center'>
<a href='../../images/axis_griddisableone.png'><img src='../../images/axis_griddisableone.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Grid Style

Common grid line configurations are available.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// these helper methods set grid 
plt.Grid(color: Color.FromArgb(50, Color.Green));
plt.Grid(lineStyle: LineStyle.Dot);

plt.SaveFig("asis_gridConfigure.png");
```

<div class='text-center'>
<a href='../../images/asis_gridconfigure.png'><img src='../../images/asis_gridconfigure.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Frameless Plots

Frameless plots can display data that appraoches the edge of the figure.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.AxisAuto(0, 0); // zero margin between data and edge of plot
plt.Frameless();

plt.SaveFig("asis_frameless.png");
```

<div class='text-center'>
<a href='../../images/asis_frameless.png'><img src='../../images/asis_frameless.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## One Axis Only

Axis ticks and lines can be disabled. Note that hiding them in this way preserves their whitespace. Setting XAxis.IsVisible to false would collapse the axis entirely. 

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// hide just the horizontal axis ticks
plt.XAxis.Ticks(false);

// hide the lines on the bottom, right, and top of the plot
plt.XAxis.Line(false);
plt.YAxis2.Line(false);
plt.XAxis2.Line(false);

plt.SaveFig("one_axisonly.png");
```

<div class='text-center'>
<a href='../../images/one_axisonly.png'><img src='../../images/one_axisonly.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Rotated X Ticks

Horizontal tick labels can be rotated as desired.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.XAxis.Label("Horizontal Axis");
plt.YAxis.Label("Vertical Axis");

// rotate horizontal axis tick labels
plt.XAxis.TickLabelStyle(rotation: 45);

plt.SaveFig("ticks_rotated.png");
```

<div class='text-center'>
<a href='../../images/ticks_rotated.png'><img src='../../images/ticks_rotated.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Rotated Y Ticks

Vertical tick labels can be rotated as desired.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.XAxis.Label("Horizontal Axis");
plt.YAxis.Label("Vertical Axis");

// rotate horizontal axis tick labels
plt.YAxis.TickLabelStyle(rotation: 45);

plt.SaveFig("ticks_rotatedY.png");
```

<div class='text-center'>
<a href='../../images/ticks_rotatedy.png'><img src='../../images/ticks_rotatedy.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Plotting DateTime Data

This example shows how to display DateTime data on the horizontal axis. Use DateTime.ToOADate() to convert DateTime[] to double[], plot the data,  then tell the axis to format tick labels as dates.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create data sample data
DateTime[] myDates = new DateTime[100];
for (int i = 0; i < myDates.Length; i++)
    myDates[i] = new DateTime(1985, 9, 24).AddDays(7 * i);

// Convert DateTime[] to double[] before plotting
double[] xs = myDates.Select(x => x.ToOADate()).ToArray();
double[] ys = DataGen.RandomWalk(myDates.Length);
plt.AddScatter(xs, ys);

// Then tell the axis to display tick labels using a time format
plt.XAxis.DateTimeFormat(true);

plt.SaveFig("ticks_dateTime.png");
```

<div class='text-center'>
<a href='../../images/ticks_datetime.png'><img src='../../images/ticks_datetime.png' /></a>
</div>

