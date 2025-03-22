---
Title: Error Bar Quickstart - ScottPlot 5.0 Cookbook
Description: Error Bars go well with scatter plots.
URL: /cookbook/5.0/ErrorBar/ErrorBarQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Error Bars", "Error Bar Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ErrorBar", "/cookbook/5.0/ErrorBar/ErrorBarQuickstart"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Error Bar Quickstart</h1>
</div>

Error Bars go well with scatter plots.

[![](/cookbook/5.0/images/ErrorBarQuickstart.png?250322130304)](/cookbook/5.0/images/ErrorBarQuickstart.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/ErrorBar.cs" imageUrl="/cookbook/5.0/images/ErrorBarQuickstart.png?250322130304" >}}ScottPlot.Plot myPlot = new();

int points = 30;

double[] xs = Generate.Consecutive(points);
double[] ys = Generate.RandomWalk(points);
double[] err = Generate.RandomSample(points, 0.1, 1);

var scatter = myPlot.Add.Scatter(xs, ys);
var errorbars = myPlot.Add.ErrorBar(xs, ys, err);
errorbars.Color = scatter.Color;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ErrorBar'>Error Bars</a> category</div>


