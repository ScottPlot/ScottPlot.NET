---
Title: Polygon Plot Styling - ScottPlot 5.0 Cookbook
Description: Polygon plots can be fully customized.
URL: /cookbook/5.0/Shapes/PolygonStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes", "Polygon Plot Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes", "/cookbook/5.0/Shapes/PolygonStyling"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Shapes/PolygonStyling'>Polygon Plot Styling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Shapes/PolygonStyling">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Shapes">Category: Shapes</a>
</div>

Polygon plots can be fully customized.

[![](/cookbook/5.0/images/PolygonStyling.png?241031194635)](/cookbook/5.0/images/PolygonStyling.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


