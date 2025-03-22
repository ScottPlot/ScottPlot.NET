---
Title: Log Scale with Custom Tick Marks - ScottPlot 5.0 Cookbook
Description: Placement of minor tick marks in plots with logarithmic axes may my customized using a custom minor tick generator. Some may be bundled with ScottPlot as shown here, but users may create their own and apply them as seen here.
URL: /cookbook/5.0/CustomizingTicks/LogScaleMinorTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Log Scale with Custom Tick Marks"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/LogScaleMinorTicks"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Log Scale with Custom Tick Marks</h1>
</div>

Placement of minor tick marks in plots with logarithmic axes may my customized using a custom minor tick generator. Some may be bundled with ScottPlot as shown here, but users may create their own and apply them as seen here.

[![](/cookbook/5.0/images/LogScaleMinorTicks.png?250322130304)](/cookbook/5.0/images/LogScaleMinorTicks.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/LogScaleMinorTicks.png?250322130304" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(100);
double[] logYs = Generate.NoisyExponential(100).Select(Math.Log10).ToArray();
var sp = myPlot.Add.ScatterPoints(xs, logYs);

// this tick generator places 10 ticks (decimal distribution) between major log ticks
IMinorTickGenerator minorTickGen = new ScottPlot.TickGenerators.LogDecadeMinorTickGenerator();

// create a numeric tick generator that uses our custom minor tick generator
ScottPlot.TickGenerators.NumericAutomatic tickGen = new()
{
    MinorTickGenerator = minorTickGen,
    IntegerTicksOnly = true,
    LabelFormatter = (double y) =&gt; $"{Math.Pow(10, y):N0}",
};

// tell the left axis to use our custom tick generator and configure the grid to show ticks
myPlot.Axes.Left.TickGenerator = tickGen;
myPlot.Grid.MajorLineColor = Colors.Black.WithOpacity(.15);
myPlot.Grid.MinorLineColor = Colors.Black.WithOpacity(.05);
myPlot.Grid.MinorLineWidth = 1;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingTicks'>Customizing Ticks</a> category</div>


