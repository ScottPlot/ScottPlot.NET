---
Title: Annular Elliptical Sector - ScottPlot 5 Cookbook
Description: An annular elliptical sector is the 2D shape between two ellipses and may be sliced to contain only the area between two angles relative to the center point.
URL: /cookbook/5/Shapes/AnnularEllipticalSector/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Shapes", "Annular Elliptical Sector"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Shapes", "/cookbook/5/Shapes/AnnularEllipticalSector"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Annular Elliptical Sector</h1>
</div>

An annular elliptical sector is the 2D shape between two ellipses and may be sliced to contain only the area between two angles relative to the center point.

[![](/cookbook/5/images/AnnularEllipticalSector.png?260329072039)](/cookbook/5/images/AnnularEllipticalSector.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5/images/AnnularEllipticalSector.png?260329072039" >}}ScottPlot.Plot myPlot = new();

Coordinates center = new(0, 0);
double outerRadiusX = 4.0;
double outerRadiusY = 2.0;
double innerRadiusX = 2.0;
double innerRadiusY = 1.0;
Angle start = Angle.FromDegrees(45);
Angle sweep = Angle.FromDegrees(135);

var cs = myPlot.Add.AnnularEllipticalSector(center, outerRadiusX, outerRadiusY, innerRadiusX, innerRadiusY, start, sweep);
cs.FillColor = Colors.Blue.WithAlpha(.2);
cs.LineColor = Colors.Black;
cs.LineWidth = 5;

myPlot.Axes.SquareUnits(); // use square units so circles are not stretched

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Shapes'>Shapes</a> category</div>


