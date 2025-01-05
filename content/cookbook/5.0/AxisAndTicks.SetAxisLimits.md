---
Title: Set Axis Limits - ScottPlot 5.0 Cookbook
Description: Axis Limits can be set by the user.
URL: /cookbook/5.0/AxisAndTicks/SetAxisLimits/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Set Axis Limits"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/SetAxisLimits"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Set Axis Limits</h1>
</div>

Axis Limits can be set by the user.

[![](/cookbook/5.0/images/SetAxisLimits.png?250105183901)](/cookbook/5.0/images/SetAxisLimits.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5.0/images/SetAxisLimits.png?250105183901" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Axes.SetLimits(-100, 150, -5, 5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisAndTicks'>Axis and Ticks</a> category</div>


