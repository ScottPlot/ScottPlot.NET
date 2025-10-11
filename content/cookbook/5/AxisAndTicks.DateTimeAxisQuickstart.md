---
Title: DateTime Axis Quickstart - ScottPlot 5 Cookbook
Description: Axis tick labels can be displayed using a time format.
URL: /cookbook/5/AxisAndTicks/DateTimeAxisQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Axis and Ticks", "DateTime Axis Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/AxisAndTicks", "/cookbook/5/AxisAndTicks/DateTimeAxisQuickstart"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DateTime Axis Quickstart</h1>
</div>

Axis tick labels can be displayed using a time format.

[![](/cookbook/5/images/DateTimeAxisQuickstart.png?251011113742)](/cookbook/5/images/DateTimeAxisQuickstart.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5/images/DateTimeAxisQuickstart.png?251011113742" >}}ScottPlot.Plot myPlot = new();

// plot data using DateTime units
DateTime[] dates = Generate.ConsecutiveDays(100);
double[] ys = Generate.RandomWalk(100);
myPlot.Add.Scatter(dates, ys);

// tell the plot to display dates on the bottom axis
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/AxisAndTicks'>Axis and Ticks</a> category</div>


