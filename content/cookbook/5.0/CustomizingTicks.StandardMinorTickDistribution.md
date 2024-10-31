---
Title: Minor Tick Density - ScottPlot 5.0 Cookbook
Description: Minor tick marks are automatically generated at intervals between major tick marks. By default they are evenly spaced, but their density may be customized.
URL: /cookbook/5.0/CustomizingTicks/StandardMinorTickDistribution/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Minor Tick Density"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/StandardMinorTickDistribution"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingTicks/StandardMinorTickDistribution'>Minor Tick Density</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingTicks/StandardMinorTickDistribution">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingTicks">Category: Customizing Ticks</a>
</div>

Minor tick marks are automatically generated at intervals between major tick marks. By default they are evenly spaced, but their density may be customized.

[![](/cookbook/5.0/images/StandardMinorTickDistribution.png?241031194635)](/cookbook/5.0/images/StandardMinorTickDistribution.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// plot sample data
double[] xs = Generate.Consecutive(100);
double[] ys = Generate.NoisyExponential(100);
var sp = myPlot.Add.Scatter(xs, ys);
sp.LineWidth = 0;

// create a minor tick generator with 10 minor ticks per major tick
ScottPlot.TickGenerators.EvenlySpacedMinorTickGenerator minorTickGen = new(10);

// create a numeric tick generator that uses our custom minor tick generator
ScottPlot.TickGenerators.NumericAutomatic tickGen = new();
tickGen.MinorTickGenerator = minorTickGen;

// tell the left axis to use our custom tick generator
myPlot.Axes.Left.TickGenerator = tickGen;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


