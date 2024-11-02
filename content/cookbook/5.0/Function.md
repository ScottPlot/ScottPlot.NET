---
Title: Function - ScottPlot 5.0 Cookbook
Description: Function plots are a type of line plot where Y positions are defined by a function that depends on X rather than a collection of discrete data points.
URL: /cookbook/5.0/Function/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Function"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Function"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Function</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Function Quickstart</h1>
<a href='/cookbook/5.0/Function/FunctionQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Create a function plot from a formula.

[![](/cookbook/5.0/images/FunctionQuickstart.png?241102170938)](/cookbook/5.0/images/FunctionQuickstart.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Function.cs" imageUrl="/cookbook/5.0/images/FunctionQuickstart.png?241102170938" >}}ScottPlot.Plot myPlot = new();

// Functions are defined as delegates with an input and output
static double func1(double x) => (Math.Sin(x) * Math.Sin(x / 2));
static double func2(double x) => (Math.Sin(x) * Math.Sin(x / 3));
static double func3(double x) => (Math.Cos(x) * Math.Sin(x / 5));

// Add functions to the plot
myPlot.Add.Function(func1);
myPlot.Add.Function(func2);
myPlot.Add.Function(func3);

// Manually set axis limits because functions do not have discrete data points
myPlot.Axes.SetLimits(-10, 10, -1.5, 1.5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Function Limit X</h1>
<a href='/cookbook/5.0/Function/FunctionLimitX' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A function can be limited to a range of X values.

[![](/cookbook/5.0/images/FunctionLimitX.png?241102170938)](/cookbook/5.0/images/FunctionLimitX.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Function.cs" imageUrl="/cookbook/5.0/images/FunctionLimitX.png?241102170938" >}}ScottPlot.Plot myPlot = new();

var func = new Func<double, double>((x) => Math.Sin(x) * Math.Sin(x / 2));

var f = myPlot.Add.Function(func);
f.MinX = -3;
f.MaxX = 3;

myPlot.Axes.SetLimits(-5, 5, -.2, 1.0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


