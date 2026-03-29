---
Title: Circle Sector - ScottPlot 5 Cookbook
Description: A circle sector is the 2D shape formed by the area inside a circle between an arc around its circumference and its center point.
URL: /cookbook/5/Shapes/CircleSector/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Shapes", "Circle Sector"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Shapes", "/cookbook/5/Shapes/CircleSector"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Circle Sector</h1>
</div>

A circle sector is the 2D shape formed by the area inside a circle between an arc around its circumference and its center point.

[![](/cookbook/5/images/CircleSector.png?260329072039)](/cookbook/5/images/CircleSector.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5/images/CircleSector.png?260329072039" >}}ScottPlot.Plot myPlot = new();

Coordinates center = new(0, 0);
double radius = 1.0;
Angle start = Angle.FromDegrees(45);
Angle sweep = Angle.FromDegrees(135);

var cs = myPlot.Add.CircleSector(center, radius, start, sweep);
cs.FillColor = Colors.Blue.WithAlpha(.2);
cs.LineColor = Colors.Black;
cs.LineWidth = 5;

myPlot.Axes.SquareUnits(); // use square units so circles are not stretched

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Shapes'>Shapes</a> category</div>


