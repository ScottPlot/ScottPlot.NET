---
Title: Axis Line with Limits - ScottPlot 5.0 Cookbook
Description: Axis lines extend infinitely in both directions by default, but upper and lower limits may be specified to limit the dimensions of axis lines.
URL: /cookbook/5.0/AxisLines/AxisLineLimits/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines", "Axis Line with Limits"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines", "/cookbook/5.0/AxisLines/AxisLineLimits"]
Date: 2024-11-09
Version: ScottPlot 5.0.44
Version: ScottPlot 5.0.44
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Line with Limits</h1>
</div>

Axis lines extend infinitely in both directions by default, but upper and lower limits may be specified to limit the dimensions of axis lines.

[![](/cookbook/5.0/images/AxisLineLimits.png?241109132219)](/cookbook/5.0/images/AxisLineLimits.png?241109132219)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisLines.cs" imageUrl="/cookbook/5.0/images/AxisLineLimits.png?241109132219" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var vLine = myPlot.Add.VerticalLine(24);
vLine.Minimum = -.5;
vLine.Maximum = 0.5;

var hLine = myPlot.Add.HorizontalLine(0.73);
hLine.Minimum = 10;
hLine.Maximum = 40;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisLines'>Axis Lines</a> category</div>


