---
Title: Pie Chart Rotation - ScottPlot 5 Cookbook
Description: Pie charts may be rotated to control where the first slice begins.
URL: /cookbook/5/Pie/PieRotation/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Pie", "Pie Chart Rotation"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Pie", "/cookbook/5/Pie/PieRotation"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Pie Chart Rotation</h1>
</div>

Pie charts may be rotated to control where the first slice begins.

[![](/cookbook/5/images/PieRotation.png?251011113742)](/cookbook/5/images/PieRotation.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Pie.cs" imageUrl="/cookbook/5/images/PieRotation.png?251011113742" >}}ScottPlot.Plot myPlot = new();

double[] values = { 5, 2, 8, 4, 8 };
var pie = myPlot.Add.Pie(values);
pie.ExplodeFraction = .1;
pie.Rotation = Angle.FromDegrees(90);

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Pie'>Pie</a> category</div>


