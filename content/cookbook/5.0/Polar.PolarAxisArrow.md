---
Title: Polar Axis with Arrows - ScottPlot 5.0 Cookbook
Description: Arrows can be placed on a polar coordinate system with their base at the center and their tips used to indicate points in polar space. The Phaser plot type uses this strategy to display collections of similarly styled arrows.
URL: /cookbook/5.0/Polar/PolarAxisArrow/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis with Arrows"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Polar", "/cookbook/5.0/Polar/PolarAxisArrow"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Polar/PolarAxisArrow'>Polar Axis with Arrows</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Polar/PolarAxisArrow">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Polar">Category: Polar Axis</a>
</div>

Arrows can be placed on a polar coordinate system with their base at the center and their tips used to indicate points in polar space. The Phaser plot type uses this strategy to display collections of similarly styled arrows.

[![](/cookbook/5.0/images/PolarAxisArrow.png?241031194635)](/cookbook/5.0/images/PolarAxisArrow.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

PolarCoordinates[] points = [
    new(10, Angle.FromDegrees(15)),
    new(20, Angle.FromDegrees(120)),
    new(30, Angle.FromDegrees(240)),
];

var polarAxis = myPlot.Add.PolarAxis(30);
polarAxis.Circles.ForEach(x => x.LinePattern = LinePattern.Dotted);
polarAxis.Spokes.ForEach(x => x.LinePattern = LinePattern.Dotted);

IPalette palette = new ScottPlot.Palettes.Category10();
Coordinates center = polarAxis.GetCoordinates(0, 0);
for (int i = 0; i < points.Length; i++)
{
    Coordinates tip = polarAxis.GetCoordinates(points[i]);
    var arrow = myPlot.Add.Arrow(center, tip);
    arrow.ArrowLineWidth = 0;
    arrow.ArrowFillColor = palette.GetColor(i).WithAlpha(.7);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


