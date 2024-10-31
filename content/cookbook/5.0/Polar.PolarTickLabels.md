---
Title: Polar Axis Tick Labels - ScottPlot 5.0 Cookbook
Description: Polar axis ticks are marked by circles which may be individually labeled.
URL: /cookbook/5.0/Polar/PolarTickLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis Tick Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Polar", "/cookbook/5.0/Polar/PolarTickLabels"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Polar/PolarTickLabels'>Polar Axis Tick Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Polar/PolarTickLabels">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Polar">Category: Polar Axis</a>
</div>

Polar axis ticks are marked by circles which may be individually labeled.

[![](/cookbook/5.0/images/PolarTickLabels.png?241031194635)](/cookbook/5.0/images/PolarTickLabels.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();
polarAxis.Rotation = Angle.FromDegrees(-90);

double[] ticksPositions = { 5, 10, 15, 20 };
string[] tickLabels = { "A", "B", "C", "D" };
polarAxis.SetCircles(ticksPositions, tickLabels);

polarAxis.SetSpokes(count: 5, length: 22, degreeLabels: false);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


