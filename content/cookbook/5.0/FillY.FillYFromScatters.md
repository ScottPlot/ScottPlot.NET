---
Title: FillY From Scatter Plots - ScottPlot 5.0 Cookbook
Description: FillY plots can be created from two scatter plots that share the same X values.
URL: /cookbook/5.0/FillY/FillYFromScatters/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "FillY plot", "FillY From Scatter Plots"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/FillY", "/cookbook/5.0/FillY/FillYFromScatters"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/FillY/FillYFromScatters'>FillY From Scatter Plots</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/FillY/FillYFromScatters">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/FillY">Category: FillY plot</a>
</div>

FillY plots can be created from two scatter plots that share the same X values.

[![](/cookbook/5.0/images/FillYFromScatters.png?241031194635)](/cookbook/5.0/images/FillYFromScatters.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

RandomDataGenerator dataGen = new(0);

int count = 20;
double[] xs = Generate.Consecutive(count);
double[] ys1 = dataGen.RandomWalk(count, offset: -5);
double[] ys2 = dataGen.RandomWalk(count, offset: 5);

var scatter1 = myPlot.Add.Scatter(xs, ys1);
var scatter2 = myPlot.Add.Scatter(xs, ys2);

var fill = myPlot.Add.FillY(scatter1, scatter2);
fill.FillColor = Colors.Blue.WithAlpha(.1);
fill.LineWidth = 0;

// push the fill behind the scatter plots
myPlot.MoveToBack(fill);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


