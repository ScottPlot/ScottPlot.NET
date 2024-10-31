---
Title: Smooth Scatter without Overshoot - ScottPlot 5.0 Cookbook
Description: The quadratic half point path strategy allows scatter plots to be displayed with smooth lines connecting points, but lines are eased in and out of points so they never 'overshoot' the values vertically.
URL: /cookbook/5.0/Scatter/ScatterQuad/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Smooth Scatter without Overshoot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterQuad"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterQuad'>Smooth Scatter without Overshoot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterQuad">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

The quadratic half point path strategy allows scatter plots to be displayed with smooth lines connecting points, but lines are eased in and out of points so they never 'overshoot' the values vertically.

[![](/cookbook/5.0/images/ScatterQuad.png?241031194635)](/cookbook/5.0/images/ScatterQuad.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(10);
double[] ys = Generate.RandomSample(10, 5, 15);

var sp = myPlot.Add.Scatter(xs, ys);
sp.PathStrategy = new ScottPlot.PathStrategies.QuadHalfPoint();
sp.LegendText = "Smooth";
sp.LineWidth = 2;
sp.MarkerSize = 10;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


