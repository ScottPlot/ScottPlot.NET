---
Title: Signal Plot - ScottPlot 5.0 Cookbook
Description: Signal plots display evenly-spaced data
URL: /cookbook/5.0/Signal/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal"]
Date: 2024-01-17
Version: ScottPlot 5.0.17
Version: ScottPlot 5.0.17
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Signal Plot


<h2><a href='/cookbook/5.0/Signal/SignalQuickstart'>Signal Plot Quickstart</a></h2>

Signal plots are best for extremely large datasets. They use render using special optimizations that allow highspeed interactivity with plots containing millions of data points.

[![](/cookbook/5.0/images/SignalQuickstart.png)](/cookbook/5.0/images/SignalQuickstart.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] values = Generate.RandomWalk(1_000_000);

myPlot.Add.Signal(values);

myPlot.Title("Signal Plot with 1 Million Points");

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Signal/SignalStyling'>Signal Plot Styling</a></h2>

Signal plots can be styled in a variety of ways.

[![](/cookbook/5.0/images/SignalStyling.png)](/cookbook/5.0/images/SignalStyling.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin());
sig1.Color = Colors.Magenta;
sig1.LineWidth = 10;
sig1.Label = "Sine";

var sig2 = myPlot.Add.Signal(Generate.Cos());
sig2.Color = Colors.Green;
sig2.LineWidth = 5;
sig2.Label = "Cosine";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Signal/SignalOffset'>Signal Offset</a></h2>

Signal plots can be offset by a given X and Y value.

[![](/cookbook/5.0/images/SignalOffset.png)](/cookbook/5.0/images/SignalOffset.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] values = ScottPlot.Generate.Sin(51);

var sig1 = myPlot.Add.Signal(values);
sig1.Label = "Default";

var sig2 = myPlot.Add.Signal(values);
sig2.Data.XOffset = 10;
sig2.Data.YOffset = .25;
sig2.Label = "Offset";

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Signal/SignalMarkerSize'>Signal Marker Size</a></h2>

Signal plots can have markers displayed at each point which are only visible when the plot is zoomed in.

[![](/cookbook/5.0/images/SignalMarkerSize.png)](/cookbook/5.0/images/SignalMarkerSize.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Cos());
sig1.Label = "Default";
sig1.Data.YOffset = 3;

var sig2 = myPlot.Add.Signal(Generate.Cos());
sig2.Label = "Large Markers";
sig2.MaximumMarkerSize = 20;
sig2.Data.YOffset = 2;

var sig3 = myPlot.Add.Signal(Generate.Cos());
sig3.Label = "Hidden Markers";
sig3.MaximumMarkerSize = 0;
sig3.Data.YOffset = 1;

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Signal/SignalRenderIndexes'>Partial Signal Rendering</a></h2>

Even if a signal plot references a large array of data, rendering can be limited to a range of values. If set,only the range of data between the minimum and maximum render indexes will be displayed.

[![](/cookbook/5.0/images/SignalRenderIndexes.png)](/cookbook/5.0/images/SignalRenderIndexes.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] values = Generate.RandomWalk(1000);

var sigAll = myPlot.Add.Signal(values);
sigAll.Label = "Full";
sigAll.Data.YOffset = 80;

var sigLeft = myPlot.Add.Signal(values);
sigLeft.Label = "Left";
sigLeft.Data.YOffset = 60;
sigLeft.Data.MaximumIndex = 700;

var sigRight = myPlot.Add.Signal(values);
sigRight.Label = "Right";
sigRight.Data.YOffset = 40;
sigRight.Data.MinimumIndex = 300;

var sigMid = myPlot.Add.Signal(values);
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


<h2><a href='/cookbook/5.0/Signal/SignalGeneric'>Signal Generic</a></h2>

Signal plots support generic data types, although double is typically the most performant.

[![](/cookbook/5.0/images/SignalGeneric.png)](/cookbook/5.0/images/SignalGeneric.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

int[] values = Generate.RandomIntegers(1000, -100, 100);

myPlot.Add.Signal(values);

myPlot.Title("Signal Plot with 1 Million Points");

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Signal/SignalDateTime'>Signal DateTime</a></h2>

A signal plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.

[![](/cookbook/5.0/images/SignalDateTime.png)](/cookbook/5.0/images/SignalDateTime.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

DateTime start = new(2024, 1, 1);
double[] ys = Generate.RandomWalk(200);

var sig = myPlot.Add.Signal(ys);
sig.Data.XOffset = start.ToOADate();
sig.Data.Period = 1.0; // one day between each point

myPlot.Axes.DateTimeTicks(Edge.Bottom);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

