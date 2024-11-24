---
Title: Smooth Scatter without Overshoot - ScottPlot 5.0 Cookbook
Description: The quadratic half point path strategy allows scatter plots to be displayed with smooth lines connecting points, but lines are eased in and out of points so they never 'overshoot' the values vertically.
URL: /cookbook/5.0/Scatter/ScatterQuad/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Smooth Scatter without Overshoot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterQuad"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Smooth Scatter without Overshoot</h1>
</div>

The quadratic half point path strategy allows scatter plots to be displayed with smooth lines connecting points, but lines are eased in and out of points so they never 'overshoot' the values vertically.

[![](/cookbook/5.0/images/ScatterQuad.png?241124170640)](/cookbook/5.0/images/ScatterQuad.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterQuad.png?241124170640" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(10);
double[] ys = Generate.RandomSample(10, 5, 15);

var sp = myPlot.Add.Scatter(xs, ys);
sp.PathStrategy = new ScottPlot.PathStrategies.QuadHalfPoint();
sp.LegendText = "Smooth";
sp.LineWidth = 2;
sp.MarkerSize = 10;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


