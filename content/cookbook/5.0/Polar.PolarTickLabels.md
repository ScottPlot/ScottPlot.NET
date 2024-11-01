---
Title: Polar Axis Tick Labels - ScottPlot 5.0 Cookbook
Description: Polar axis ticks are marked by circles which may be individually labeled.
URL: /cookbook/5.0/Polar/PolarTickLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis Tick Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Polar", "/cookbook/5.0/Polar/PolarTickLabels"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Tick Labels</h1>
</div>

Polar axis ticks are marked by circles which may be individually labeled.

[![](/cookbook/5.0/images/PolarTickLabels.png?241101192719)](/cookbook/5.0/images/PolarTickLabels.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();
polarAxis.Rotation = Angle.FromDegrees(-90);

double[] ticksPositions = { 5, 10, 15, 20 };
string[] tickLabels = { "A", "B", "C", "D" };
polarAxis.SetCircles(ticksPositions, tickLabels);

polarAxis.SetSpokes(count: 5, length: 22, degreeLabels: false);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Polar'>Polar Axis</a> category</div>


