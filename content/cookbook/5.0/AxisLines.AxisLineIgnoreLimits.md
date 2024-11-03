---
Title: Ignore When Autoscaling - ScottPlot 5.0 Cookbook
Description: Calling Plot.Axes.AutoScale() or middle-clicking the plot will set the axis limits to fit the data. By default the position of axis lines and spans are included in automatic axis limit calculations, but a flag can be set to ignore certain plottables when automatically scaling the plot.
URL: /cookbook/5.0/AxisLines/AxisLineIgnoreLimits/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines", "Ignore When Autoscaling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines", "/cookbook/5.0/AxisLines/AxisLineIgnoreLimits"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Ignore When Autoscaling</h1>
</div>

Calling Plot.Axes.AutoScale() or middle-clicking the plot will set the axis limits to fit the data. By default the position of axis lines and spans are included in automatic axis limit calculations, but a flag can be set to ignore certain plottables when automatically scaling the plot.

[![](/cookbook/5.0/images/AxisLineIgnoreLimits.png?241103171511)](/cookbook/5.0/images/AxisLineIgnoreLimits.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisLines.cs" imageUrl="/cookbook/5.0/images/AxisLineIgnoreLimits.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisLines'>Axis Lines</a> category</div>


