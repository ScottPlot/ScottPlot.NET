---
Title: ErrorBar Values - ScottPlot 5.0 Cookbook
Description: Error size can be set for all dimensions.
URL: /cookbook/5.0/ErrorBar/CustomErrors/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Error Bars", "ErrorBar Values"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ErrorBar", "/cookbook/5.0/ErrorBar/CustomErrors"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ErrorBar/CustomErrors'>ErrorBar Values</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ErrorBar/CustomErrors">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ErrorBar">Category: Error Bars</a>
</div>

Error size can be set for all dimensions.

[![](/cookbook/5.0/images/CustomErrors.png?241031194635)](/cookbook/5.0/images/CustomErrors.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

int points = 10;

double[] xs = Generate.Consecutive(points);
double[] ys = Generate.RandomWalk(points);
var scatter = myPlot.Add.Scatter(xs, ys);
scatter.LineStyle.Width = 0;

ScottPlot.Plottables.ErrorBar eb = new(
    xs: xs,
    ys: ys,
    xErrorsNegative: Generate.RandomSample(points, .5),
    xErrorsPositive: Generate.RandomSample(points, .5),
    yErrorsNegative: Generate.RandomSample(points),
    yErrorsPositive: Generate.RandomSample(points));

eb.Color = scatter.Color;

myPlot.Add.Plottable(eb);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


