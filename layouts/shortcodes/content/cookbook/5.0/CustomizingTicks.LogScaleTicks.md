---
Title: Log Scale Tick Marks - ScottPlot 5.0 Cookbook
Description: The appearance of logarithmic scaling can be achieved by log-scaling the data to be displayed then customizing the minor ticks and grid.
URL: /cookbook/5.0/CustomizingTicks/LogScaleTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Log Scale Tick Marks"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/LogScaleTicks"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Log Scale Tick Marks</h1>
</div>

The appearance of logarithmic scaling can be achieved by log-scaling the data to be displayed then customizing the minor ticks and grid.

[![](/cookbook/5.0/images/LogScaleTicks.png?250322130304)](/cookbook/5.0/images/LogScaleTicks.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/LogScaleTicks.png?250322130304" >}}ScottPlot.Plot myPlot = new();

// start with original data
double[] xs = Generate.Consecutive(100);
double[] ys = Generate.NoisyExponential(100);

// log-scale the data and account for negative values
double[] logYs = ys.Select(Math.Log10).ToArray();

// add log-scaled data to the plot
myPlot.Add.ScatterPoints(xs, logYs);

// create a minor tick generator that places log-distributed minor ticks
ScottPlot.TickGenerators.LogMinorTickGenerator minorTickGen = new();

// create a numeric tick generator that uses our custom minor tick generator
ScottPlot.TickGenerators.NumericAutomatic tickGen = new();
tickGen.MinorTickGenerator = minorTickGen;

// create a custom tick formatter to set the label text for each tick
static string LogTickLabelFormatter(double y) =&gt; $"{Math.Pow(10, y):N0}";

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingTicks'>Customizing Ticks</a> category</div>


