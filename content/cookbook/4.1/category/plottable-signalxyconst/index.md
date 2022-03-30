---
Title: SignalXYConst - ScottPlot 4.1 Cookbook
Description: Plottable - SignalXYConst recipes
Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook
---

## SignalConst with X and Y data

SignalXYConst is a speed-optimized plot for displaying vaues (Ys) with unevenly-spaced positions (Xs) that are in ascending order. If your data is evenly-spaced, Signal and SignalConst is faster.

```cs
var plt = new ScottPlot.Plot(600, 400);

// generate random, unevenly-spaced data
Random rand = new Random(0);
int pointCount = 100_000;
double[] ys = new double[pointCount];
double[] xs = new double[pointCount];
for (int i = 1; i < ys.Length; i++)
{
    ys[i] = ys[i - 1] + rand.NextDouble() - .5;
    xs[i] = xs[i - 1] + rand.NextDouble();
}

plt.AddSignalXYConst(xs, ys);

plt.SaveFig("signalxyconst_quickstart.png");
```

<div class='text-center'>
<a href='../../images/signalxyconst_quickstart.png'><img src='../../images/signalxyconst_quickstart.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Different data types for xs and ys

SignalXYConst with (int)Xs and (float)Ys arrays

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 1_000_000;
double[] sine = DataGen.Sin(pointCount, 3);
double[] noise = DataGen.RandomNormal(rand, pointCount, 0, 0.5);
float[] ys = sine.Zip(noise, (s, n) => s + n).Select(x => (float)x).ToArray();
int[] xs = Enumerable.Range(0, pointCount)
    .Select(x => (int)x)
    .Select(x => x > 500_000 ? x + 1_000_000 : x)
    .Select(x => x > 200_000 ? x + 100_000 : x)
    .ToArray();

plt.AddSignalXYConst(xs, ys);

plt.SaveFig("signalxyconst_types.png");
```

<div class='text-center'>
<a href='../../images/signalxyconst_types.png'><img src='../../images/signalxyconst_types.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## SignalConst Step Mode

Data points can be connected with steps (instead of straight lines).

```cs
var plt = new ScottPlot.Plot(600, 400);

// generate random, unevenly-spaced data
Random rand = new Random(0);
int pointCount = 100_000;
double[] ys = new double[pointCount];
double[] xs = new double[pointCount];
for (int i = 1; i < ys.Length; i++)
{
    ys[i] = ys[i - 1] + rand.NextDouble() - .5;
    xs[i] = xs[i - 1] + rand.NextDouble();
}

var sigxyconst = plt.AddSignalXYConst(xs, ys);
sigxyconst.StepDisplay = true;
plt.SetAxisLimits(18700, 18730, -49.25, -46.75);

plt.SaveFig("signalxyconst_step.png");
```

<div class='text-center'>
<a href='../../images/signalxyconst_step.png'><img src='../../images/signalxyconst_step.png' /></a>
</div>

