---
Title: SignalXY - ScottPlot 4.1 Cookbook
Description: Plottable - SignalXY recipes
Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook
---

## SignalXY Quickstart

SignalXY is a speed-optimized plot for displaying vaues (Ys) with unevenly-spaced positions (Xs) that are in ascending order. If your data is evenly-spaced, Signal and SignalConst is faster.

```cs
var plt = new ScottPlot.Plot(600, 400);

(double[] xs, double[] ys) = DataGen.RandomWalk2D(new Random(0), 5_000);

plt.AddSignalXY(xs, ys);

plt.SaveFig("signalxy_quickstart.png");
```

<div class='text-center'>
<a href='../../images/signalxy_quickstart.png'><img src='../../images/signalxy_quickstart.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## SignalXY Offset

SignalXY plots can have X and Y offsets that shift all data by a defined amount.

```cs
var plt = new ScottPlot.Plot(600, 400);

(double[] xs, double[] ys) = DataGen.RandomWalk2D(new Random(0), 5_000);

var sig = plt.AddSignalXY(xs, ys);
sig.OffsetX = 10_000;
sig.OffsetY = 100;

plt.SaveFig("signalxy_offset.png");
```

<div class='text-center'>
<a href='../../images/signalxy_offset.png'><img src='../../images/signalxy_offset.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Signal Data with Gaps

Signal with defined Xs that contain gaps

```cs
var plt = new ScottPlot.Plot(600, 400);

var rand = new Random(0);
int pointCount = 10_000;
double[] sine = DataGen.Sin(pointCount, 3);
double[] noise = DataGen.RandomNormal(rand, pointCount, 0, 0.5);
double[] ys = sine.Zip(noise, (s, n) => s + n).ToArray();
double[] xs = Enumerable.Range(0, pointCount)
    .Select(x => (double)x)
    .Select(x => x > 3_000 ? x + 10_000 : x)
    .Select(x => x > 7_000 ? x + 20_000 : x)
    .ToArray();

plt.AddSignalXY(xs, ys);

plt.SaveFig("signalxy_gaps.png");
```

<div class='text-center'>
<a href='../../images/signalxy_gaps.png'><img src='../../images/signalxy_gaps.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Different Densities

Signal with mised low and high density data

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new(0);
int pointCount = 5_000;
double[] sine = DataGen.Sin(pointCount, 3);
double[] noise = DataGen.RandomNormal(rand, pointCount, 0, 0.5);
double[] ys = sine.Zip(noise, (s, n) => s + n).ToArray();
double[] xs = new double[pointCount];

double x = 0;
for (int i = 0; i < pointCount; i++)
{
    bool lowDensityPoint = (i % 1_000) < 10;
    x += lowDensityPoint ? 10 : .05;
    xs[i] = x;
}

plt.AddSignalXY(xs, ys);

plt.SaveFig("signalxy_density.png");
```

<div class='text-center'>
<a href='../../images/signalxy_density.png'><img src='../../images/signalxy_density.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## SignalXY Step Mode

Data points can be connected with steps (instead of straight lines).

```cs
var plt = new ScottPlot.Plot(600, 400);

(double[] xs, double[] ys) = DataGen.RandomWalk2D(new Random(0), 5_000);

var sigxy = plt.AddSignalXY(xs, ys);
sigxy.StepDisplay = true;
sigxy.MarkerSize = 0;

plt.SetAxisLimits(110, 140, 17.5, 27.5);

plt.SaveFig("signalxy_step.png");
```

<div class='text-center'>
<a href='../../images/signalxy_step.png'><img src='../../images/signalxy_step.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## SignalXY with Fill

Various options allow shading above/below the signal data.

```cs
var plt = new ScottPlot.Plot(600, 400);

(double[] xs, double[] ys) = DataGen.RandomWalk2D(new Random(0), 5_000);

var sigxy = plt.AddSignalXY(xs, ys);
sigxy.FillBelow();

plt.Margins(x: 0);

plt.SaveFig("signalxy_fillBelow.png");
```

<div class='text-center'>
<a href='../../images/signalxy_fillbelow.png'><img src='../../images/signalxy_fillbelow.png' /></a>
</div>

