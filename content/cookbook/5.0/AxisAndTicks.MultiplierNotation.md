---
Title: Multiplier Notation - ScottPlot 5.0 Cookbook
Description: Numeric tick labels may be displayed using multiplier notation (where tick labels are displayed using scientific notation with the eponent displayed in the corner of the plot). A helper method is available to set-up multiplier notation with a single statement, but users can interact with the object this method returns (not shown here) or inspect the code inside of that method to learn how to achieve enhanced customization abilities.
URL: /cookbook/5.0/AxisAndTicks/MultiplierNotation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Multiplier Notation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/MultiplierNotation"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiplier Notation</h1>
</div>

Numeric tick labels may be displayed using multiplier notation (where tick labels are displayed using scientific notation with the eponent displayed in the corner of the plot). A helper method is available to set-up multiplier notation with a single statement, but users can interact with the object this method returns (not shown here) or inspect the code inside of that method to learn how to achieve enhanced customization abilities.

[![](/cookbook/5.0/images/MultiplierNotation.png?250126165944)](/cookbook/5.0/images/MultiplierNotation.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5.0/images/MultiplierNotation.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// plot sample data with extremely large values
double[] xs = Generate.RandomSample(50, -1e10, 1e10);
double[] ys = Generate.RandomSample(50, -1e20, 1e20);
myPlot.Add.Scatter(xs, ys);

// enable multiplier notation on both primary axes
myPlot.Axes.SetupMultiplierNotation(myPlot.Axes.Left);
myPlot.Axes.SetupMultiplierNotation(myPlot.Axes.Bottom);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisAndTicks'>Axis and Ticks</a> category</div>


