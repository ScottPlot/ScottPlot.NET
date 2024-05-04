---
Title: Quickstart - ScottPlot 5.0 Cookbook
Description: A survey of basic functionality in ScottPlot 5
URL: /cookbook/5.0/ScottPlotQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScottPlotQuickstart"]
Date: 2024-05-04
Version: ScottPlot 5.0.33
Version: ScottPlot 5.0.33
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Quickstart


<h2><a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartScatter'>Scatter Plot</a></h2>

Display paired X/Y data as a scatter plot.

[![](/cookbook/5.0/images/QuickstartScatter.png?240504011455)](/cookbook/5.0/images/QuickstartScatter.png?240504011455)

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


<h2><a href='/cookbook/5.0/ScottPlotQuickstart/CustomizingPlottables'>Customizing Plottables</a></h2>

Functions that add things to plots return the plottables they create. Interact with the properties of plottables to customize their styling and behavior.

[![](/cookbook/5.0/images/CustomizingPlottables.png?240504011455)](/cookbook/5.0/images/CustomizingPlottables.png?240504011455)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
var myScatter = myPlot.Add.Scatter(dataX, dataY);
myScatter.Color = Colors.Green.WithOpacity(.2);
myScatter.LineWidth = 5;
myScatter.MarkerSize = 15;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartSignal'>Signal Plot</a></h2>

Signal plots are optimized for displaying evenly spaced data.

[![](/cookbook/5.0/images/QuickstartSignal.png?240504011455)](/cookbook/5.0/images/QuickstartSignal.png?240504011455)

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


<h2><a href='/cookbook/5.0/ScottPlotQuickstart/SignalPerformance'>Signal Plot Performance</a></h2>

Signal plots can interactively display millions of data points in real time. Double-click the plot to display performance benchmarks.

[![](/cookbook/5.0/images/SignalPerformance.png?240504011455)](/cookbook/5.0/images/SignalPerformance.png?240504011455)

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


<h2><a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartAxisLabels'>Axis Labels</a></h2>

Axis labels can be extensively customized.

[![](/cookbook/5.0/images/QuickstartAxisLabels.png?240504011455)](/cookbook/5.0/images/QuickstartAxisLabels.png?240504011455)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.XLabel("Horizonal Axis");
myPlot.YLabel("Vertical Axis");
myPlot.Title("Plot Title");

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/ScottPlotQuickstart/Legend'>Legend</a></h2>

A legend displays plottables in a key along the edge of a plot. Most plottables have a Label property which configures what text appears in the legend.

[![](/cookbook/5.0/images/Legend.png?240504011455)](/cookbook/5.0/images/Legend.png?240504011455)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cos";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/ScottPlotQuickstart/AddPlottablesManually'>Add Plottables Manually</a></h2>

Although the Plot.Add class has many helpful methods for creating plottable objects and adding them to the plot, users can instantiate plottable objects themselves and use Add.Plottable() to place it on the plot. This stategy allows users to create their own plottables (implementing IPlottable) with custom appearance or behavior.

[![](/cookbook/5.0/images/AddPlottablesManually.png?240504011455)](/cookbook/5.0/images/AddPlottablesManually.png?240504011455)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// create a plottable and modify it as desired
ScottPlot.Plottables.Arrow arrow = new()
{
    Base = new Coordinates(1, 2),
    Tip = new Coordinates(3, 4),
};

// add the custom plottable to the plot
myPlot.Add.Plottable(arrow);

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

