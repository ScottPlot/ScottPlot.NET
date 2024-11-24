---
Title: Bar Plot Legend - ScottPlot 5.0 Cookbook
Description: A collection of bars can appear in the legend as a single item.
URL: /cookbook/5.0/Bar/BarLegend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bar Plot Legend"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarLegend"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Bar Plot Legend</h1>
</div>

A collection of bars can appear in the legend as a single item.

[![](/cookbook/5.0/images/BarLegend.png?241124170640)](/cookbook/5.0/images/BarLegend.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/BarLegend.png?241124170640" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


