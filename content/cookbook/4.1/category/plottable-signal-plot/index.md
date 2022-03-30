---
Title: Signal Plot - ScottPlot 4.1 Cookbook
Description: Plottable - Signal Plot recipes
Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook
---

## Signal Plot Quickstart

Signal plots are ideal for evenly-spaced data with thousands or millions of points.

```cs
var plt = new ScottPlot.Plot(600, 400);

var rand = new Random(0);
double[] values = DataGen.RandomWalk(rand, 100_000);
int sampleRate = 20_000;

// Signal plots require a data array and a sample rate (points per unit)
plt.AddSignal(values, sampleRate);

plt.Benchmark(enable: true);
plt.Title($"Signal Plot: One Million Points");

plt.SaveFig("signal_quickstart.png");
```

<div class='text-center'>
<a href='../../images/signal_quickstart.png'><img src='../../images/signal_quickstart.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Signal Offset

Signal plots can have X and Y offsets that shift all data by a defined amount.

```cs
var plt = new ScottPlot.Plot(600, 400);

var rand = new Random(0);
double[] values = DataGen.RandomWalk(rand, 100_000);
var sig = plt.AddSignal(values);
sig.OffsetX = 10_000;
sig.OffsetY = 100;

plt.SaveFig("signal_offset.png");
```

<div class='text-center'>
<a href='../../images/signal_offset.png'><img src='../../images/signal_offset.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Speed Test

Compare the speed to the same data plotted as a scatter plot.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(100_000, 1.0 / 20_000);
double[] values = DataGen.RandomWalk(null, 100_000);

plt.AddScatter(xs, values, Color.Red, markerSize: 0);

plt.Benchmark(enable: true);
plt.Title($"Scatter Plot: One Million Points");

plt.SaveFig("signal_advantage.png");
```

<div class='text-center'>
<a href='../../images/signal_advantage.png'><img src='../../images/signal_advantage.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Styled Signal Plot

Signal plots can be styled using public fields. Signal plots can also be offset by a defined X or Y amount.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] ys = DataGen.RandomWalk(null, 500);
int sampleRate = 10;

var sp2 = plt.AddSignal(ys, sampleRate, Color.Magenta);
sp2.OffsetY = 1000;
sp2.OffsetX = 300;
sp2.LineStyle = LineStyle.Dash;
sp2.LineWidth = 2;

plt.SaveFig("signal_styled.png");
```

<div class='text-center'>
<a href='../../images/signal_styled.png'><img src='../../images/signal_styled.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Step Display

Signal plots can be styled as step plots where points are connected by right angles instead of straight lines.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] ys = DataGen.Sin(51);

var sig = plt.AddSignal(ys);
sig.StepDisplay = true;
sig.MarkerSize = 0;

plt.SaveFig("signal_step.png");
```

<div class='text-center'>
<a href='../../images/signal_step.png'><img src='../../images/signal_step.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## 5 Million Points

Signal plots with millions of points can be interacted with in real time.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
for (int i = 0; i < 5; i++)
{
    // add a new signal plot with one million points
    double[] values = DataGen.RandomWalk(rand, 1_000_000);
    plt.AddSignal(values);
}
plt.Benchmark(enable: true);

plt.SaveFig("signal_5millionPoints.png");
```

<div class='text-center'>
<a href='../../images/signal_5millionpoints.png'><img src='../../images/signal_5millionpoints.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Display data density

When plotting extremely high density data, you can't always see the trends underneath all those overlapping data points. If you send an array of colors to PlotSignal(), it will use those colors to display density.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create an extremely noisy signal with a subtle sine wave beneath it
Random rand = new Random(0);
int pointCount = 100_000;
double[] signal1 = DataGen.Sin(pointCount, 3);
double[] noise = DataGen.RandomNormal(rand, pointCount, 0, 5);
double[] data = new double[pointCount];
for (int i = 0; i < data.Length; i++)
    data[i] = signal1[i] + noise[i];

// plot the noisy signal using the traditional method
var sp1 = plt.AddSignal(data);
sp1.OffsetY = -40;
sp1.Color = Color.Red;

// use a custom colors to display data of different densities
string[] colorCodes = { "#440154", "#39568C", "#1F968B", "#73D055" };
Color[] colors = colorCodes.Select(x => ColorTranslator.FromHtml(x)).ToArray();

var sp2 = plt.AddSignal(data);
sp2.DensityColors = colors;
sp2.Color = colors[0];

plt.Title("Color by Density vs. Solid Color");
plt.AxisAuto(0, .1);

plt.SaveFig("signal_density.png");
```

<div class='text-center'>
<a href='../../images/signal_density.png'><img src='../../images/signal_density.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Display first N points

When plotting live data it is useful to allocate a large array in memory then fill it with values as they come in. By setting the maxRenderIndex property of a scatter plot to can prevent rendering the end of the array (which is probably filled with zeros).

```cs
var plt = new ScottPlot.Plot(600, 400);

// create an array larger than we intend to display
double[] values = DataGen.RandomWalk(1000);

// only render the first N points of the signal
var sig = plt.AddSignal(values);
sig.MaxRenderIndex = 500;

plt.SaveFig("signal_firstNpoints.png");
```

<div class='text-center'>
<a href='../../images/signal_firstnpoints.png'><img src='../../images/signal_firstnpoints.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Plot a Range of Points

It is sometimes useful to only display values within a range of the source data array.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create an array larger than we intend to display
double[] values = DataGen.RandomWalk(1000);

// only render values between the two defined indexes
var sig = plt.AddSignal(values);
sig.MinRenderIndex = 400;
sig.MaxRenderIndex = 500;

plt.SaveFig("signal_range.png");
```

<div class='text-center'>
<a href='../../images/signal_range.png'><img src='../../images/signal_range.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Fill Below

Signal plots can be filled below with a solid color.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

var sig = plt.AddSignal(data);
sig.FillBelow();

plt.Margins(x: 0);

plt.SaveFig("signal_fillBelow.png");
```

<div class='text-center'>
<a href='../../images/signal_fillbelow.png'><img src='../../images/signal_fillbelow.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Gradient Fill Below

Signal plots can be filled below using a color gradient.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

var sig = plt.AddSignal(data);
sig.FillBelow(Color.Blue, Color.Transparent);

plt.Margins(x: 0);

plt.SaveFig("signal_fillBelowGradient.png");
```

<div class='text-center'>
<a href='../../images/signal_fillbelowgradient.png'><img src='../../images/signal_fillbelowgradient.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Gradient Fill Above

Signal plots can be filled above using a color gradient.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

var sig = plt.AddSignal(data);
sig.FillAbove(Color.Blue, Color.Transparent);

plt.Margins(x: 0);

plt.SaveFig("signal_fillAbove.png");
```

<div class='text-center'>
<a href='../../images/signal_fillabove.png'><img src='../../images/signal_fillabove.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Fill Above and Below

Signal plots can be filled above and below

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

var sig = plt.AddSignal(data);
sig.FillAboveAndBelow(Color.Green, Color.Red);
sig.Color = Color.Black;
sig.BaselineY = 7;

plt.Margins(x: 0);

plt.SaveFig("signal_fillAboveAndBelow.png");
```

<div class='text-center'>
<a href='../../images/signal_fillaboveandbelow.png'><img src='../../images/signal_fillaboveandbelow.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Gradient Fill Above and Below

Gradients can be used to fill above and below.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

plt.Style(Style.Gray1);

var sig = plt.AddSignal(data);
sig.MarkerSize = 0;
sig.Color = Color.Black;
sig.FillAboveAndBelow(Color.Green, Color.Transparent, Color.Transparent, Color.Red, 1);
sig.BaselineY = 5;

plt.Margins(x: 0);

plt.SaveFig("signal_gradientAboveAndBelowGradient.png");
```

<div class='text-center'>
<a href='../../images/signal_gradientaboveandbelowgradient.png'><img src='../../images/signal_gradientaboveandbelowgradient.png' /></a>
</div>

