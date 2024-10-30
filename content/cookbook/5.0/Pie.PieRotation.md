---
Title: Pie Chart Rotation - ScottPlot 5.0 Cookbook
Description: Pie charts may be rotated to control where the first slice begins.
URL: /cookbook/5.0/Pie/PieRotation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie", "Pie Chart Rotation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie", "/cookbook/5.0/Pie/PieRotation"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Pie/PieRotation'>Pie Chart Rotation</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Pie/PieRotation">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Pie">Category: Pie</a>
</div>

Pie charts may be rotated to control where the first slice begins.

[![](/cookbook/5.0/images/PieRotation.png?241029205813)](/cookbook/5.0/images/PieRotation.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = { 5, 2, 8, 4, 8 };
var pie = myPlot.Add.Pie(values);
pie.ExplodeFraction = .1;
pie.Rotation = Angle.FromDegrees(90);

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


