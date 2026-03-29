---
Title: Elliptical Arc - ScottPlot 5 Cookbook
Description: An elliptical arc is a curve along the partial circumference of an ellipse. The ellipse starts at the far right and extends counter-clockwise.
URL: /cookbook/5/Shapes/EllipticalArc/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Shapes", "Elliptical Arc"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Shapes", "/cookbook/5/Shapes/EllipticalArc"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Elliptical Arc</h1>
</div>

An elliptical arc is a curve along the partial circumference of an ellipse. The ellipse starts at the far right and extends counter-clockwise.

[![](/cookbook/5/images/EllipticalArc.png?260329072039)](/cookbook/5/images/EllipticalArc.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5/images/EllipticalArc.png?260329072039" >}}ScottPlot.Plot myPlot = new();

Coordinates center = new(0, 0);
double radiusX = 2.0;
double radiusY = 1.0;
Angle start = Angle.FromDegrees(45);
Angle sweep = Angle.FromDegrees(135);

var ellipse = myPlot.Add.Ellipse(center, radiusX, radiusY);
ellipse.FillColor = Colors.Blue.WithAlpha(.2);
ellipse.LineWidth = 0;

var arc = myPlot.Add.EllipticalArc(center, radiusX, radiusY, start, sweep);
arc.LineWidth = 5;
arc.LineColor = Colors.Black;

myPlot.Axes.SquareUnits(); // use square units so circles are not stretched

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Shapes'>Shapes</a> category</div>


