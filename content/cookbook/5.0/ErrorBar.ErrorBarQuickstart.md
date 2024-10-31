---
Title: Error Bar Quickstart - ScottPlot 5.0 Cookbook
Description: Error Bars go well with scatter plots.
URL: /cookbook/5.0/ErrorBar/ErrorBarQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Error Bars", "Error Bar Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ErrorBar", "/cookbook/5.0/ErrorBar/ErrorBarQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ErrorBar/ErrorBarQuickstart'>Error Bar Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ErrorBar/ErrorBarQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ErrorBar">Category: Error Bars</a>
</div>

Error Bars go well with scatter plots.

[![](/cookbook/5.0/images/ErrorBarQuickstart.png?241031194635)](/cookbook/5.0/images/ErrorBarQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

int points = 30;

double[] xs = Generate.Consecutive(points);
double[] ys = Generate.RandomWalk(points);
double[] err = Generate.RandomSample(points, 0.1, 1);

var scatter = myPlot.Add.Scatter(xs, ys);
var errorbars = myPlot.Add.ErrorBar(xs, ys, err);
errorbars.Color = scatter.Color;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


