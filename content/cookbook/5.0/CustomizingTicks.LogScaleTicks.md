---
Title: Log Scale Tick Marks - ScottPlot 5.0 Cookbook
Description: The appearance of logarithmic scaling can be achieved by log-scaling the data to be displayed then customizing the minor ticks and grid.
URL: /cookbook/5.0/CustomizingTicks/LogScaleTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Log Scale Tick Marks"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/LogScaleTicks"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingTicks/LogScaleTicks'>Log Scale Tick Marks</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingTicks/LogScaleTicks">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingTicks">Category: Customizing Ticks</a>
</div>

The appearance of logarithmic scaling can be achieved by log-scaling the data to be displayed then customizing the minor ticks and grid.

[![](/cookbook/5.0/images/LogScaleTicks.png?241031194635)](/cookbook/5.0/images/LogScaleTicks.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// start with original data
double[] xs = Generate.Consecutive(100);
double[] ys = Generate.NoisyExponential(100);

// log-scale the data and account for negative values
double[] logYs = ys.Select(Math.Log10).ToArray();

// add log-scaled data to the plot
var sp = myPlot.Add.Scatter(xs, logYs);
sp.LineWidth = 0;

// create a minor tick generator that places log-distributed minor ticks
ScottPlot.TickGenerators.LogMinorTickGenerator minorTickGen = new();

// create a numeric tick generator that uses our custom minor tick generator
ScottPlot.TickGenerators.NumericAutomatic tickGen = new();
tickGen.MinorTickGenerator = minorTickGen;

// create a custom tick formatter to set the label text for each tick
static string LogTickLabelFormatter(double y) => $"{Math.Pow(10, y):N0}";

// tell our major tick generator to only show major ticks that are whole integers
tickGen.IntegerTicksOnly = true;

// tell our custom tick generator to use our new label formatter
tickGen.LabelFormatter = LogTickLabelFormatter;

// tell the left axis to use our custom tick generator
myPlot.Axes.Left.TickGenerator = tickGen;

// show grid lines for minor ticks
myPlot.Grid.MajorLineColor = Colors.Black.WithOpacity(.15);
myPlot.Grid.MinorLineColor = Colors.Black.WithOpacity(.05);
myPlot.Grid.MinorLineWidth = 1;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


