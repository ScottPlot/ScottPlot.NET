---
Title: Read Axis Limits - ScottPlot 5.0 Cookbook
Description: Use GetLimits() to obtain the current axis limits.
URL: /cookbook/5.0/AxisAndTicks/GetAxisLimits/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Read Axis Limits"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/GetAxisLimits"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Read Axis Limits</h1>
</div>

Use GetLimits() to obtain the current axis limits.

[![](/cookbook/5.0/images/GetAxisLimits.png?241117162641)](/cookbook/5.0/images/GetAxisLimits.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5.0/images/GetAxisLimits.png?241117162641" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

AxisLimits limits = myPlot.Axes.GetLimits();
double xMin = limits.Left;
double xMax = limits.Right;
double yMin = limits.Bottom;
double yMax = limits.Top;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisAndTicks'>Axis and Ticks</a> category</div>


