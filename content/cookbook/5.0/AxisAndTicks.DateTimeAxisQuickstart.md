---
Title: DateTime Axis Quickstart - ScottPlot 5.0 Cookbook
Description: Axis tick labels can be displayed using a time format.
URL: /cookbook/5.0/AxisAndTicks/DateTimeAxisQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "DateTime Axis Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/DateTimeAxisQuickstart"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DateTime Axis Quickstart</h1>
</div>

Axis tick labels can be displayed using a time format.

[![](/cookbook/5.0/images/DateTimeAxisQuickstart.png?241101192719)](/cookbook/5.0/images/DateTimeAxisQuickstart.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// plot data using DateTime units
DateTime[] dates = Generate.ConsecutiveDays(100);
double[] ys = Generate.RandomWalk(100);
myPlot.Add.Scatter(dates, ys);

// tell the plot to display dates on the bottom axis
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisAndTicks'>Axis and Ticks</a> category</div>


