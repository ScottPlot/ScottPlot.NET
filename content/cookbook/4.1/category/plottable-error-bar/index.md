---
Title: Error Bar - ScottPlot 4.1 Cookbook
Description: Plottable - Error Bar recipes
Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook
---

## Error Bar Quickstart

Error Bars allow more fine-grained control over how your error bars are shown.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 20;

double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.RandomNormal(rand, pointCount, mean: 20, stdDev: 2);

double[] xErrPos = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();
double[] xErrNeg = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();
double[] yErrPos = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();
double[] yErrNeg = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();

plt.AddScatter(xs, ys, System.Drawing.Color.Blue, lineStyle: LineStyle.Dot);
plt.AddErrorBars(xs, ys, xErrPos, xErrNeg, yErrPos, yErrNeg, System.Drawing.Color.Blue);

plt.SaveFig("errorBar_quickstart.png");
```

<div class='text-center'>
<a href='../../images/errorbar_quickstart.png'><img src='../../images/errorbar_quickstart.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Symmetric Error Bars

There's a shorthand method for error bars where the positive and negative error is the same.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 20;

double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.RandomNormal(rand, pointCount, mean: 20, stdDev: 2);

double[] xErr = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();
double[] yErr = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();

plt.AddScatter(xs, ys, System.Drawing.Color.Blue, lineStyle: LineStyle.Dot);
plt.AddErrorBars(xs, ys, xErr, yErr, System.Drawing.Color.Blue);

plt.SaveFig("errorBar_symmetric.png");
```

<div class='text-center'>
<a href='../../images/errorbar_symmetric.png'><img src='../../images/errorbar_symmetric.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Error Bars in One Dimension

If you only have error data for one dimension you can simply pass in null for the other dimension.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 20;

double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.RandomNormal(rand, pointCount, mean: 20, stdDev: 2);

double[] yErr = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();

plt.AddScatter(xs, ys, System.Drawing.Color.Blue, lineStyle: LineStyle.Dot);
plt.AddErrorBars(xs, ys, null, yErr, System.Drawing.Color.Blue);

plt.SaveFig("errorBar_oneDimension.png");
```

<div class='text-center'>
<a href='../../images/errorbar_onedimension.png'><img src='../../images/errorbar_onedimension.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Customization

You can customize the colour, cap size, and line width of the error bars.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 20;

double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.RandomNormal(rand, pointCount, mean: 20, stdDev: 2);

double[] yErr = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();

plt.AddScatter(xs, ys, System.Drawing.Color.Blue, lineStyle: LineStyle.Dot);

var errorBars = plt.AddErrorBars(xs, ys, null, yErr);
errorBars.CapSize = 8;
errorBars.Color = System.Drawing.Color.Green;
errorBars.LineWidth = 3;

plt.SaveFig("errorBar_customization.png");
```

<div class='text-center'>
<a href='../../images/errorbar_customization.png'><img src='../../images/errorbar_customization.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Error Bar Marker

An optional marker can be drawn at the center X/Y position for each error bar.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 50;
double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.NoisyBellCurve(rand, pointCount);
double[] yErr = DataGen.Random(rand, pointCount, multiplier: .2, offset: .05);

plt.AddErrorBars(xs, ys, null, yErr, markerSize: 5);

plt.SaveFig("errorBar_marker.png");
```

<div class='text-center'>
<a href='../../images/errorbar_marker.png'><img src='../../images/errorbar_marker.png' /></a>
</div>

