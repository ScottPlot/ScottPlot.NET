---
Title: ScottPlot 5 Quickstart - ScottPlot 5.0 Cookbook
Description: A survey of basic functionality in ScottPlot 5
URL: /cookbook/5.0/Quickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "ScottPlot 5 Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Quickstart"]
Date: 2024-01-18
Version: ScottPlot 5.0.18
Version: ScottPlot 5.0.18
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# ScottPlot 5 Quickstart


<h2><a href='/cookbook/5.0/Quickstart/QuickstartScatter'>Scatter Plot</a></h2>

Display paired X/Y data as a scatter plot.

[![](/cookbook/5.0/images/QuickstartScatter.png)](/cookbook/5.0/images/QuickstartScatter.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
myPlot.Add.Scatter(dataX, dataY);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Quickstart/CustomizingPlottables'>Customizing Plottables</a></h2>

Functions that add things to plots return the plottables they create. Interact with the properties of plottables to customize their styling and behavior.

[![](/cookbook/5.0/images/CustomizingPlottables.png)](/cookbook/5.0/images/CustomizingPlottables.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
var myScatter = myPlot.Add.Scatter(dataX, dataY);
myScatter.LineStyle.Width = 5;
myScatter.LineStyle.Color = Colors.Green.WithOpacity(.2);
myScatter.MarkerStyle.Fill.Color = Colors.Magenta;
myScatter.MarkerStyle.Size = 15;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Quickstart/QuickstartSignal'>Signal Plot</a></h2>

Signal plots are optimized for displaying evenly spaced data.

[![](/cookbook/5.0/images/QuickstartSignal.png)](/cookbook/5.0/images/QuickstartSignal.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);
myPlot.Add.Signal(sin);
myPlot.Add.Signal(cos);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Quickstart/SignalPerformance'>Signal Plot Performance</a></h2>

Signal plots can interactively display millions of data points in real time. Double-click the plot to display performance benchmarks.

[![](/cookbook/5.0/images/SignalPerformance.png)](/cookbook/5.0/images/SignalPerformance.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] data = Generate.RandomWalk(1_000_000);
myPlot.Add.Signal(data);
myPlot.Title("Signal plot with one million points");

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Quickstart/QuickstartAxisLabels'>Axis Labels</a></h2>

Axis labels can be extensively customized.

[![](/cookbook/5.0/images/QuickstartAxisLabels.png)](/cookbook/5.0/images/QuickstartAxisLabels.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Axes.Bottom.Label.Text = "Horizonal Axis";
myPlot.Axes.Left.Label.Text = "Vertical Axis";
myPlot.Axes.Top.Label.Text = "Plot Title";

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Quickstart/Legend'>Legend</a></h2>

A legend displays plottables in a key along the edge of a plot. Most plottables have a Label property which configures what text appears in the legend.

[![](/cookbook/5.0/images/Legend.png)](/cookbook/5.0/images/Legend.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.Label = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.Label = "Cos";

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

