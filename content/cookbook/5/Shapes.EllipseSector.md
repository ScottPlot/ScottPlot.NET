---
Title: Ellipse Sector - ScottPlot 5 Cookbook
Description: An ellipse sector is the 2D shape formed by the area inside an ellipse between an arc around its edge and its center point.
URL: /cookbook/5/Shapes/EllipseSector/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Shapes", "Ellipse Sector"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Shapes", "/cookbook/5/Shapes/EllipseSector"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Ellipse Sector</h1>
</div>

An ellipse sector is the 2D shape formed by the area inside an ellipse between an arc around its edge and its center point.

[![](/cookbook/5/images/EllipseSector.png?251011113742)](/cookbook/5/images/EllipseSector.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5/images/EllipseSector.png?251011113742" >}}ScottPlot.Plot myPlot = new();

Coordinates center = new(0, 0);
double radiusX = 2.0;
double radiusY = 1.0;
Angle start = Angle.FromDegrees(45);
Angle sweep = Angle.FromDegrees(135);

var cs = myPlot.Add.EllipticalSector(center, radiusX, radiusY, start, sweep);
cs.FillColor = Colors.Blue.WithAlpha(.2);
cs.LineColor = Colors.Black;
cs.LineWidth = 5;

myPlot.Axes.SquareUnits(); // use square units so circles are not stretched

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Shapes'>Shapes</a> category</div>


