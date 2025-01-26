---
Title: Annular Sector - ScottPlot 5.0 Cookbook
Description: An annular sector is the 2D shape between two circles (like a donut) and may be sliced to contain only the area between two angles relative to the center point.
URL: /cookbook/5.0/Shapes/AnnularSector/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes", "Annular Sector"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes", "/cookbook/5.0/Shapes/AnnularSector"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Annular Sector</h1>
</div>

An annular sector is the 2D shape between two circles (like a donut) and may be sliced to contain only the area between two angles relative to the center point.

[![](/cookbook/5.0/images/AnnularSector.png?250126165944)](/cookbook/5.0/images/AnnularSector.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/AnnularSector.png?250126165944" >}}ScottPlot.Plot myPlot = new();

Coordinates center = new(0, 0);
double outerRadius = 2.0;
double innerRadius = 1.0;
Angle start = Angle.FromDegrees(45);
Angle sweep = Angle.FromDegrees(135);

var cs = myPlot.Add.AnnularSector(center, outerRadius, innerRadius, start, sweep);
cs.FillColor = Colors.Blue.WithAlpha(.2);
cs.LineColor = Colors.Black;
cs.LineWidth = 5;

myPlot.Axes.SquareUnits(); // use square units so circles are not stretched

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Shapes'>Shapes</a> category</div>


