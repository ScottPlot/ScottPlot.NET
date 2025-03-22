---
Title: Arc - ScottPlot 5.0 Cookbook
Description: An arc is a curve along the partial circumference of a circle. The circle starts at the far right and extends counter-clockwise.
URL: /cookbook/5.0/Shapes/Arc/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes", "Arc"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes", "/cookbook/5.0/Shapes/Arc"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Arc</h1>
</div>

An arc is a curve along the partial circumference of a circle. The circle starts at the far right and extends counter-clockwise.

[![](/cookbook/5.0/images/Arc.png?250322130304)](/cookbook/5.0/images/Arc.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/Arc.png?250322130304" >}}ScottPlot.Plot myPlot = new();

Coordinates center = new(0, 0);
double radius = 1.0;
Angle start = Angle.FromDegrees(45);
Angle sweep = Angle.FromDegrees(135);

var circle = myPlot.Add.Circle(center, radius);
circle.FillColor = Colors.Blue.WithAlpha(.2);
circle.LineWidth = 0;

var arc = myPlot.Add.Arc(center, radius, start, sweep);
arc.LineWidth = 5;
arc.LineColor = Colors.Black;

myPlot.Axes.SquareUnits(); // use square units so circles are not stretched

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Shapes'>Shapes</a> category</div>


