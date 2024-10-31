---
Title: Bar Plot Legend - ScottPlot 5.0 Cookbook
Description: A collection of bars can appear in the legend as a single item.
URL: /cookbook/5.0/Bar/BarLegend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bar Plot Legend"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarLegend"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Bar/BarLegend'>Bar Plot Legend</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Bar/BarLegend">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Bar">Category: Bar Plot</a>
</div>

A collection of bars can appear in the legend as a single item.

[![](/cookbook/5.0/images/BarLegend.png?241031194635)](/cookbook/5.0/images/BarLegend.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs1 = { 1, 2, 3, 4 };
double[] ys1 = { 5, 10, 7, 13 };
var bars1 = myPlot.Add.Bars(xs1, ys1);
bars1.LegendText = "Alpha";

double[] xs2 = { 6, 7, 8, 9 };
double[] ys2 = { 7, 12, 9, 15 };
var bars2 = myPlot.Add.Bars(xs2, ys2);
bars2.LegendText = "Beta";

myPlot.ShowLegend(Alignment.UpperLeft);
myPlot.Axes.Margins(bottom: 0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


