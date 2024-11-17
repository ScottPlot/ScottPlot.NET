---
Title: Pie Chart from Values - ScottPlot 5.0 Cookbook
Description: A pie chart can be created from a few values.
URL: /cookbook/5.0/Pie/PieQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie", "Pie Chart from Values"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie", "/cookbook/5.0/Pie/PieQuickstart"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Pie Chart from Values</h1>
</div>

A pie chart can be created from a few values.

[![](/cookbook/5.0/images/PieQuickstart.png?241117162641)](/cookbook/5.0/images/PieQuickstart.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Pie.cs" imageUrl="/cookbook/5.0/images/PieQuickstart.png?241117162641" >}}ScottPlot.Plot myPlot = new();

double[] values = { 5, 2, 8, 4, 8 };
var pie = myPlot.Add.Pie(values);
pie.ExplodeFraction = .1;

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Pie'>Pie</a> category</div>


