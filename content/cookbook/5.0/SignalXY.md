---
Title: SignalXY Plot - ScottPlot 5.0 Cookbook
Description: SignalXY are a high performance plot type optimized for X/Y pairs where the X values are always ascending. For large datasets SignalXY plots are much more performant than Scatter plots (which allow unordered X points) but not as performant as Signal plots (which require fixed spacing between X points).
URL: /cookbook/5.0/SignalXY/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY"]
Date: 2024-03-24
Version: ScottPlot 5.0.23
Version: ScottPlot 5.0.23
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# SignalXY Plot


<h2><a href='/cookbook/5.0/SignalXY/SignalXYQuickstart'>SignalXY Quickstart</a></h2>

SignalXY plots are a high performance plot type for X/Y data where the X values are always ascending.

[![](/cookbook/5.0/images/SignalXYQuickstart.png?240324174053)](/cookbook/5.0/images/SignalXYQuickstart.png?240324174053)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// generate sample data with gaps
List<double> xList = new();
List<double> yList = new();
for (int i = 0; i < 5; i++)
{
    xList.AddRange(Generate.Consecutive(1000, first: 2000 * i));
    yList.AddRange(Generate.RandomSample(1000));
}
double[] xs = xList.ToArray();
double[] ys = yList.ToArray();

// add a SignalXY plot
myPlot.Add.SignalXY(xs, ys);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/SignalXY/SignalXYGeneric'>SignalXY Generic</a></h2>

SignalXY plots support generic data types, although double is typically the most performant.

[![](/cookbook/5.0/images/SignalXYGeneric.png?240324174053)](/cookbook/5.0/images/SignalXYGeneric.png?240324174053)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// generate sample data with gaps
List<int> xList = new();
List<float> yList = new();
for (int i = 0; i < 5; i++)
{
    xList.AddRange(Generate.Consecutive(1000, first: 2000 * i).Select(x => (int)x));
    yList.AddRange(Generate.RandomSample(1000).Select(x => (float)x));
}
int[] xs = xList.ToArray();
float[] ys = yList.ToArray();

// add a SignalXY plot
myPlot.Add.SignalXY(xs, ys);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/SignalXY/SignalXYRenderIndexes'>Partial SignalXY Rendering</a></h2>

Even if a SignalXY plot references a large array of data, rendering can be limited to a range of values. If set,only the range of data between the minimum and maximum render indexes will be displayed.

[![](/cookbook/5.0/images/SignalXYRenderIndexes.png?240324174053)](/cookbook/5.0/images/SignalXYRenderIndexes.png?240324174053)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(1000);
double[] ys = Generate.RandomWalk(1000);

var sigAll = myPlot.Add.SignalXY(xs, ys);
sigAll.Label = "Full";
sigAll.Data.YOffset = 80;

var sigLeft = myPlot.Add.SignalXY(xs, ys);
sigLeft.Label = "Left";
sigLeft.Data.YOffset = 60;
sigLeft.Data.MaximumIndex = 700;

var sigRight = myPlot.Add.SignalXY(xs, ys);
sigRight.Label = "Right";
sigRight.Data.YOffset = 40;
sigRight.Data.MinimumIndex = 300;

var sigMid = myPlot.Add.SignalXY(xs, ys);
sigMid.Label = "Mid";
sigMid.Data.YOffset = 20;
sigMid.Data.MinimumIndex = 300;
sigMid.Data.MaximumIndex = 700;

myPlot.ShowLegend(Alignment.UpperRight);
myPlot.Axes.Margins(top: .5);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/SignalXY/SignalXYOffset'>SignalXY Offset</a></h2>

A fixed offset can be applied to SignalXY plots.

[![](/cookbook/5.0/images/SignalXYOffset.png?240324174053)](/cookbook/5.0/images/SignalXYOffset.png?240324174053)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(1000);
double[] ys = Generate.Sin(1000);

var sig1 = myPlot.Add.SignalXY(xs, ys);

var sig2 = myPlot.Add.SignalXY(xs, ys);
sig2.Data.XOffset = 250;
sig2.Data.YOffset = .5;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/SignalXY/VerticalSignalXY'>Vertical SignalXY</a></h2>

Although SignalXY plots typically display data left-to-right, it is possible to use this plot type to display data bottom-to-top.

[![](/cookbook/5.0/images/VerticalSignalXY.png?240324174053)](/cookbook/5.0/images/VerticalSignalXY.png?240324174053)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(1000);
double[] ys = Generate.RandomWalk(1000);

var sig1 = myPlot.Add.SignalXY(xs, ys);
sig1.Data.Rotated = true;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/SignalXY/SignalXYVerticalInvertedX'>Vertical SignalXY with Inverted X Axis</a></h2>

Demonstrates how to display a rotated SignalXY plot (so it goes from bottom to top) which is also displayed on an inverted horizontal axis (where positive values are on the left).

[![](/cookbook/5.0/images/SignalXYVerticalInvertedX.png?240324174053)](/cookbook/5.0/images/SignalXYVerticalInvertedX.png?240324174053)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// add a signal plot
double[] xs = Generate.Consecutive(5_000);
double[] ys = Generate.Sin(count: xs.Length, oscillations: 4);

// rotate it so it is vertical
var signal = myPlot.Add.SignalXY(xs, ys);
signal.Data.Rotated = true;

// invert the horizontal axis
myPlot.Axes.SetLimitsX(1, -1);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/SignalXY/SignalXYVerticalInvertedY'>Vertical SignalXY with Inverted Y Axis</a></h2>

Demonstrates how to display a rotated SignalXY plot on an inverted vertical axis so data goes from top to bottom.

[![](/cookbook/5.0/images/SignalXYVerticalInvertedY.png?240324174053)](/cookbook/5.0/images/SignalXYVerticalInvertedY.png?240324174053)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// add a signal plot
double[] xs = Generate.Consecutive(5_000);
double[] ys = Generate.Sin(count: xs.Length, oscillations: 4);

// rotate it so it is vertical
var signal = myPlot.Add.SignalXY(xs, ys);
signal.Data.Rotated = true;

// invert the vertical axis
myPlot.Axes.SetLimitsY(5000, 0);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

