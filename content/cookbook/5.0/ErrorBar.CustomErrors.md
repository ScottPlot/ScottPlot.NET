---
Title: ErrorBar Values - ScottPlot 5.0 Cookbook
Description: Error size can be set for all dimensions.
URL: /cookbook/5.0/ErrorBar/CustomErrors/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Error Bars", "ErrorBar Values"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ErrorBar", "/cookbook/5.0/ErrorBar/CustomErrors"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>ErrorBar Values</h1>
</div>

Error size can be set for all dimensions.

[![](/cookbook/5.0/images/CustomErrors.png?241117162641)](/cookbook/5.0/images/CustomErrors.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/ErrorBar.cs" imageUrl="/cookbook/5.0/images/CustomErrors.png?241117162641" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ErrorBar'>Error Bars</a> category</div>


