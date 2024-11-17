---
Title: Pie Chart Rotation - ScottPlot 5.0 Cookbook
Description: Pie charts may be rotated to control where the first slice begins.
URL: /cookbook/5.0/Pie/PieRotation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie", "Pie Chart Rotation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie", "/cookbook/5.0/Pie/PieRotation"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Pie Chart Rotation</h1>
</div>

Pie charts may be rotated to control where the first slice begins.

[![](/cookbook/5.0/images/PieRotation.png?241117162641)](/cookbook/5.0/images/PieRotation.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Pie.cs" imageUrl="/cookbook/5.0/images/PieRotation.png?241117162641" >}}ScottPlot.Plot myPlot = new();

double[] values = { 5, 2, 8, 4, 8 };
var pie = myPlot.Add.Pie(values);
pie.ExplodeFraction = .1;
pie.Rotation = Angle.FromDegrees(90);

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Pie'>Pie</a> category</div>


