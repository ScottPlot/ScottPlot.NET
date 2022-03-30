---
Title: Scatter Plot - ScottPlot 4.1 Cookbook
Description: Plottable - Scatter Plot recipes
Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook
---

## Scatter Plot Quickstart

Scatter plots are best for small numbers of paired X/Y data points. For evenly-spaced data points Signal is much faster.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create sample X/Y data
int pointCount = 51;
double[] x = DataGen.Consecutive(pointCount);
double[] sin = DataGen.Sin(pointCount);
double[] cos = DataGen.Cos(pointCount);

// add scatter plots
plt.AddScatter(x, sin);
plt.AddScatter(x, cos);

plt.SaveFig("scatter_quickstart.png");
```

<div class='text-center'>
<a href='../../images/scatter_quickstart.png'><img src='../../images/scatter_quickstart.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Custom markers

Markers can be customized using optional arguments and public fields.

```cs
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 51;
double[] x = DataGen.Consecutive(pointCount);
double[] sin = DataGen.Sin(pointCount);
double[] cos = DataGen.Cos(pointCount);

// add scatter plots and customize markers
var sp1 = plt.AddScatter(x, sin, markerSize: 15);
sp1.MarkerShape = MarkerShape.openCircle;

var sp2 = plt.AddScatter(x, cos, markerSize: 7);
sp2.MarkerShape = MarkerShape.filledSquare;

plt.SaveFig("scatter_markers.png");
```

<div class='text-center'>
<a href='../../images/scatter_markers.png'><img src='../../images/scatter_markers.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## All marker shapes

Legend indicates names of all available marker shapes

```cs
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 51;
double[] xs = DataGen.Consecutive(pointCount);

string[] markerShapeNames = Enum.GetNames(typeof(MarkerShape));
for (int i = 0; i < markerShapeNames.Length; i++)
{
    Enum.TryParse(markerShapeNames[i], out MarkerShape ms);
    double[] ys = DataGen.Sin(pointCount, 2, -i);
    var sp = plt.AddScatter(xs, ys);
    sp.LineWidth = 2;
    sp.LineColor = Color.FromArgb(50, sp.LineColor);
    sp.MarkerSize = 7;
    sp.MarkerShape = ms;
    sp.Label = ms.ToString();
}

plt.Grid(enable: false);
var legend = plt.Legend();
legend.FontSize = 10;

plt.SaveFig("scatter_markerShape.png");
```

<div class='text-center'>
<a href='../../images/scatter_markershape.png'><img src='../../images/scatter_markershape.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Custom lines

Line color, size, and style can be customized. Setting markerSize to 0 prevents markers from being rendered.

```cs
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 51;
double[] x = DataGen.Consecutive(pointCount);
double[] sin = DataGen.Sin(pointCount);
double[] cos = DataGen.Cos(pointCount);
double[] cos2 = DataGen.Cos(pointCount, mult: -1);

plt.AddScatter(x, sin, color: Color.Magenta, lineWidth: 0, markerSize: 10);
plt.AddScatter(x, cos, color: Color.Green, lineWidth: 5, markerSize: 0);
plt.AddScatter(x, cos2, color: Color.Blue, lineWidth: 3, markerSize: 0, lineStyle: LineStyle.DashDot);

var legend = plt.Legend();
legend.FixedLineWidth = false;

plt.SaveFig("scatter_lineStyle.png");
```

<div class='text-center'>
<a href='../../images/scatter_linestyle.png'><img src='../../images/scatter_linestyle.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Random X/Y Points

X data for scatter plots does not have to be evenly spaced, making scatter plots are ideal for displaying random data like this.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 51;
double[] xs1 = DataGen.RandomNormal(rand, pointCount, 1);
double[] xs2 = DataGen.RandomNormal(rand, pointCount, 3);
double[] ys1 = DataGen.RandomNormal(rand, pointCount, 5);
double[] ys2 = DataGen.RandomNormal(rand, pointCount, 7);

plt.AddScatter(xs1, ys1, markerSize: 0, label: "lines only");
plt.AddScatter(xs2, ys2, lineWidth: 0, label: "markers only");
plt.Legend();

plt.SaveFig("scatter_random.png");
```

<div class='text-center'>
<a href='../../images/scatter_random.png'><img src='../../images/scatter_random.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Scatter Plot with Errorbars

An array of values can be supplied for error bars and redering options can be customized as desired

```cs
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 20;
Random rand = new Random(0);
double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.RandomWalk(rand, pointCount);
double[] xErr = DataGen.RandomNormal(rand, pointCount, .2);
double[] yErr = DataGen.RandomNormal(rand, pointCount);

var sp = plt.AddScatter(xs, ys);
sp.XError = xErr;
sp.YError = yErr;
sp.ErrorCapSize = 3;
sp.ErrorLineWidth = 1;
sp.LineStyle = LineStyle.Dot;

plt.SaveFig("scatter_errorbar.png");
```

<div class='text-center'>
<a href='../../images/scatter_errorbar.png'><img src='../../images/scatter_errorbar.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Lines Only

A shortcut method makes it easy to create a scatter plot with just lines (no markers)

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(51);
double[] ys = DataGen.Sin(51);

plt.AddScatterLines(xs, ys, Color.Red, 3);

plt.SaveFig("scatter_lineplot.png");
```

<div class='text-center'>
<a href='../../images/scatter_lineplot.png'><img src='../../images/scatter_lineplot.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Markers Only

A shortcut method makes it easy to create a scatter plot where markers are displayed at every point (without any connecting lines)

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(51);
double[] ys = DataGen.Sin(51);

plt.AddScatterPoints(xs, ys, Color.Navy, 10, MarkerShape.filledDiamond);

plt.SaveFig("scatter_pointsplot.png");
```

<div class='text-center'>
<a href='../../images/scatter_pointsplot.png'><img src='../../images/scatter_pointsplot.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Step Plot

A step plot is a special type of scatter plot where points are connected by right angles instead of straight lines.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(51);
double[] ys = DataGen.Sin(51);

plt.AddScatterStep(xs, ys);

plt.SaveFig("scatter_stepplot.png");
```

<div class='text-center'>
<a href='../../images/scatter_stepplot.png'><img src='../../images/scatter_stepplot.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Add markers

Want to place a marker at a position in X/Y space? AddMarker() will create a scatter plot with a single point.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new(0);
for (int i = 0; i < 100; i++)
{
    double x = rand.Next(100);
    double y = rand.Next(100);
    double fraction = rand.NextDouble();
    double size = (fraction + .1) * 30;
    var color = Drawing.Colormap.Turbo.GetColor(fraction, alpha: .8);
    var shape = Marker.Random(rand);
    plt.AddMarker(x, y, shape, size, color);
}

plt.SaveFig("scatter_AddMarker.png");
```

<div class='text-center'>
<a href='../../images/scatter_addmarker.png'><img src='../../images/scatter_addmarker.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Draggable Scatter Plot

Want to modify the scatter points interactively? A ScatterPlotDraggable lets you move the points around with the mouse. As you move the points around, the values in the original arrays change to reflect their new positions.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] x = ScottPlot.DataGen.Consecutive(50);
double[] y = ScottPlot.DataGen.Cos(50);

var scatter = new ScottPlot.Plottable.ScatterPlotDraggable(x, y)
{
    DragCursor = Cursor.Crosshair,
    DragEnabled = true,
};

plt.Add(scatter);

plt.SaveFig("scatter_draggable_vertical.png");
```

<div class='text-center'>
<a href='../../images/scatter_draggable_vertical.png'><img src='../../images/scatter_draggable_vertical.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Draggable Scatter Plot Vertical

You can restrict dragging to just X or Y directions.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] x = ScottPlot.DataGen.Consecutive(50);
double[] y = ScottPlot.DataGen.Cos(50);

var scatter = new ScottPlot.Plottable.ScatterPlotDraggable(x, y)
{
    DragCursor = Cursor.Crosshair,
    DragEnabled = true,   // controls whether anything can be dragged
    DragEnabledX = false, // controls whether points can be dragged horizontally 
    DragEnabledY = true,  // controls whether points can be dragged vertically
};

plt.Add(scatter);

plt.SaveFig("scatter_draggable.png");
```

<div class='text-center'>
<a href='../../images/scatter_draggable.png'><img src='../../images/scatter_draggable.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Forest Plot

Scatter plots can be used to create forest plots, which are useful for showing the agreement between multiple estimates.

```cs
var plt = new ScottPlot.Plot(600, 400);

var plot1 = plt.AddScatter(new double[] { 2.5 }, new double[] { 5 }, label: "John Doe et al.");
plot1.XError = new double[] { 0.2 };

var plot2 = plt.AddScatter(new double[] { 2.7 }, new double[] { 4 }, label: "Jane Doe et al.");
plot2.XError = new double[] { 0.3 };

var plot3 = plt.AddScatter(new double[] { 2.3 }, new double[] { 3 }, label: "Jim Doe et al.");
plot3.XError = new double[] { 0.6 };

var plot4 = plt.AddScatter(new double[] { 2.8 }, new double[] { 2 }, label: "Joel Doe et al.");
plot4.XError = new double[] { 0.3 };

var plot5 = plt.AddScatter(new double[] { 2.5 }, new double[] { 1 }, label: "Jacqueline Doe et al.");
plot5.XError = new double[] { 0.2 };

plt.AddVerticalLine(2.6, style: LineStyle.Dash);

plt.SetAxisLimits(0, 5, 0, 6);
plt.Legend();

plt.SaveFig("scatter_forest.png");
```

<div class='text-center'>
<a href='../../images/scatter_forest.png'><img src='../../images/scatter_forest.png' /></a>
</div>

