---
Title: Polar Axis with Arrows - ScottPlot 5 Cookbook
Description: Arrows can be placed on a polar coordinate system with their base at the center and their tips used to indicate points in polar space. The Phaser plot type uses this strategy to display collections of similarly styled arrows.
URL: /cookbook/5/PolarAxis/PolarAxisArrow/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Polar Axis", "Polar Axis with Arrows"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/PolarAxis", "/cookbook/5/PolarAxis/PolarAxisArrow"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis with Arrows</h1>
</div>

Arrows can be placed on a polar coordinate system with their base at the center and their tips used to indicate points in polar space. The Phaser plot type uses this strategy to display collections of similarly styled arrows.

[![](/cookbook/5/images/PolarAxisArrow.png?260329072039)](/cookbook/5/images/PolarAxisArrow.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5/images/PolarAxisArrow.png?260329072039" >}}ScottPlot.Plot myPlot = new();

PolarCoordinates[] points = [
    new(10, Angle.FromDegrees(15)),
    new(20, Angle.FromDegrees(120)),
    new(30, Angle.FromDegrees(240)),
];

var polarAxis = myPlot.Add.PolarAxis(radius: 30);
polarAxis.Circles.ForEach(x =&gt; x.LinePattern = LinePattern.Dotted);
polarAxis.Spokes.ForEach(x =&gt; x.LinePattern = LinePattern.Dotted);

IPalette palette = new ScottPlot.Palettes.Category10();
Coordinates center = polarAxis.GetCoordinates(0, 0);
for (int i = 0; i &lt; points.Length; i++)
{
    Coordinates tip = polarAxis.GetCoordinates(points[i]);
    var arrow = myPlot.Add.Arrow(center, tip);
    arrow.ArrowLineWidth = 0;
    arrow.ArrowFillColor = palette.GetColor(i).WithAlpha(.7);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/PolarAxis'>Polar Axis</a> category</div>


