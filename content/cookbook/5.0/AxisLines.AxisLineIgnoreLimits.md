---
Title: Ignore When Autoscaling - ScottPlot 5.0 Cookbook
Description: Calling Plot.Axes.AutoScale() or middle-clicking the plot will set the axis limits to fit the data. By default the position of axis lines and spans are included in automatic axis limit calculations, but a flag can be set to ignore certain plottables when automatically scaling the plot.
URL: /cookbook/5.0/AxisLines/AxisLineIgnoreLimits/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines", "Ignore When Autoscaling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines", "/cookbook/5.0/AxisLines/AxisLineIgnoreLimits"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisLines/AxisLineIgnoreLimits'>Ignore When Autoscaling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisLines/AxisLineIgnoreLimits">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisLines">Category: Axis Lines</a>
</div>

Calling Plot.Axes.AutoScale() or middle-clicking the plot will set the axis limits to fit the data. By default the position of axis lines and spans are included in automatic axis limit calculations, but a flag can be set to ignore certain plottables when automatically scaling the plot.

[![](/cookbook/5.0/images/AxisLineIgnoreLimits.png?241031194635)](/cookbook/5.0/images/AxisLineIgnoreLimits.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

var hline = myPlot.Add.HorizontalLine(0.23);
hline.IsDraggable = true;
hline.EnableAutoscale = false;

var hSpan = myPlot.Add.HorizontalSpan(-10, 20);
hSpan.IsDraggable = true;
hSpan.EnableAutoscale = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


