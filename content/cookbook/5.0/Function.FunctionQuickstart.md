---
Title: Function Quickstart - ScottPlot 5.0 Cookbook
Description: Create a function plot from a formula.
URL: /cookbook/5.0/Function/FunctionQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Function", "Function Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Function", "/cookbook/5.0/Function/FunctionQuickstart"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Function Quickstart</h1>
</div>

Create a function plot from a formula.

[![](/cookbook/5.0/images/FunctionQuickstart.png?250126165944)](/cookbook/5.0/images/FunctionQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Function.cs" imageUrl="/cookbook/5.0/images/FunctionQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// Functions are defined as delegates with an input and output
static double func1(double x) =&gt; (Math.Sin(x) * Math.Sin(x / 2));
static double func2(double x) =&gt; (Math.Sin(x) * Math.Sin(x / 3));
static double func3(double x) =&gt; (Math.Cos(x) * Math.Sin(x / 5));

// Add functions to the plot
myPlot.Add.Function(func1);
myPlot.Add.Function(func2);
myPlot.Add.Function(func3);

// Manually set axis limits because functions do not have discrete data points
myPlot.Axes.SetLimits(-10, 10, -1.5, 1.5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Function'>Function</a> category</div>


