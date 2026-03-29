---
Title: Pie Chart from Values - ScottPlot 5 Cookbook
Description: A pie chart can be created from a few values.
URL: /cookbook/5/Pie/PieQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Pie", "Pie Chart from Values"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Pie", "/cookbook/5/Pie/PieQuickstart"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Pie Chart from Values</h1>
</div>

A pie chart can be created from a few values.

[![](/cookbook/5/images/PieQuickstart.png?260329072039)](/cookbook/5/images/PieQuickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Pie.cs" imageUrl="/cookbook/5/images/PieQuickstart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

double[] values = { 5, 2, 8, 4, 8 };
var pie = myPlot.Add.Pie(values);
pie.ExplodeFraction = .1;

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Pie'>Pie</a> category</div>


