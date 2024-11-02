---
Title: Minor Tick Density - ScottPlot 5.0 Cookbook
Description: Minor tick marks are automatically generated at intervals between major tick marks. By default they are evenly spaced, but their density may be customized.
URL: /cookbook/5.0/CustomizingTicks/StandardMinorTickDistribution/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Minor Tick Density"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/StandardMinorTickDistribution"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Minor Tick Density</h1>
</div>

Minor tick marks are automatically generated at intervals between major tick marks. By default they are evenly spaced, but their density may be customized.

[![](/cookbook/5.0/images/StandardMinorTickDistribution.png?241102170938)](/cookbook/5.0/images/StandardMinorTickDistribution.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/StandardMinorTickDistribution.png?241102170938" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingTicks'>Customizing Ticks</a> category</div>


