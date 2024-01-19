---
Title: Error Bars - ScottPlot 5.0 Cookbook
Description: Error Bars communicate the range of possible values for a measurement
URL: /cookbook/5.0/ErrorBar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Error Bars"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ErrorBar"]
Date: 2024-01-19
Version: ScottPlot 5.0.19
Version: ScottPlot 5.0.19
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Error Bars


<h2><a href='/cookbook/5.0/ErrorBar/ErrorBarQuickstart'>Error Bar Quickstart</a></h2>

Error Bars go well with scatter plots.

[![](/cookbook/5.0/images/ErrorBarQuickstart.png)](/cookbook/5.0/images/ErrorBarQuickstart.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

int points = 30;

double[] xs = ScottPlot.Generate.Consecutive(points);
double[] ys = ScottPlot.Generate.RandomWalk(points);
double[] err = ScottPlot.Generate.RandomSample(points, 0.1, 1);

var scatter = myPlot.Add.Scatter(xs, ys);
var errorbars = myPlot.Add.ErrorBar(xs, ys, err);
errorbars.Color = scatter.Color;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/ErrorBar/CustomErrors'>ErrorBar Values</a></h2>

Error size can be set for all dimensions.

[![](/cookbook/5.0/images/CustomErrors.png)](/cookbook/5.0/images/CustomErrors.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

int points = 10;

double[] xs = ScottPlot.Generate.Consecutive(points);
double[] ys = ScottPlot.Generate.RandomWalk(points);
var scatter = myPlot.Add.Scatter(xs, ys);
scatter.LineStyle.Width = 0;

ScottPlot.Plottables.ErrorBar eb = new(
    xs: xs,
    ys: ys,
    xErrorsNegative: ScottPlot.Generate.RandomSample(points, .5),
    xErrorsPositive: ScottPlot.Generate.RandomSample(points, .5),
    yErrorsNegative: ScottPlot.Generate.RandomSample(points),
    yErrorsPositive: ScottPlot.Generate.RandomSample(points));

eb.Color = scatter.Color;

myPlot.Add.Plottable(eb);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

