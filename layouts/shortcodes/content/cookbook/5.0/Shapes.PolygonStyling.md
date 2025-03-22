---
Title: Polygon Plot Styling - ScottPlot 5.0 Cookbook
Description: Polygon plots can be fully customized.
URL: /cookbook/5.0/Shapes/PolygonStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes", "Polygon Plot Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes", "/cookbook/5.0/Shapes/PolygonStyling"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polygon Plot Styling</h1>
</div>

Polygon plots can be fully customized.

[![](/cookbook/5.0/images/PolygonStyling.png?250322130304)](/cookbook/5.0/images/PolygonStyling.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/PolygonStyling.png?250322130304" >}}ScottPlot.Plot myPlot = new();

Coordinates[] points =
{
    new (0, 0.25),
    new (0.3, 0.75),
    new (1, 1),
    new (0.7, 0.5),
    new (1, 0)
};

var poly = myPlot.Add.Polygon(points);
poly.FillColor = Colors.Green;
poly.FillHatchColor = Colors.Blue;
poly.FillHatch = new Gradient()
{
    GradientType = GradientType.Linear,
    AlignmentStart = Alignment.UpperRight,
    AlignmentEnd = Alignment.LowerLeft,
};

poly.LineColor = Colors.Black;
poly.LinePattern = LinePattern.Dashed;
poly.LineWidth = 2;

poly.MarkerShape = MarkerShape.OpenCircle;
poly.MarkerSize = 8;
poly.MarkerFillColor = Colors.Gold;
poly.MarkerLineColor = Colors.Brown;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Shapes'>Shapes</a> category</div>


