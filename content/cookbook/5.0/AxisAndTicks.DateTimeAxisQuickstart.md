---
Title: DateTime Axis Quickstart - ScottPlot 5.0 Cookbook
Description: Axis tick labels can be displayed using a time format.
URL: /cookbook/5.0/AxisAndTicks/DateTimeAxisQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "DateTime Axis Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/DateTimeAxisQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisAndTicks/DateTimeAxisQuickstart'>DateTime Axis Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisAndTicks/DateTimeAxisQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisAndTicks">Category: Axis and Ticks</a>
</div>

Axis tick labels can be displayed using a time format.

[![](/cookbook/5.0/images/DateTimeAxisQuickstart.png?241031194635)](/cookbook/5.0/images/DateTimeAxisQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// plot data using DateTime units
DateTime[] dates = Generate.ConsecutiveDays(100);
double[] ys = Generate.RandomWalk(100);
myPlot.Add.Scatter(dates, ys);

// tell the plot to display dates on the bottom axis
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


