---
Title: Triangular Axis Styling - ScottPlot 5 Cookbook
Description: Triangular axis background and grid lines may be customized.
URL: /cookbook/5/TriangularAxis/TriangularAxisStyling/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Triangular Axis", "Triangular Axis Styling"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/TriangularAxis", "/cookbook/5/TriangularAxis/TriangularAxisStyling"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Triangular Axis Styling</h1>
</div>

Triangular axis background and grid lines may be customized.

[![](/cookbook/5/images/TriangularAxisStyling.png?260329072039)](/cookbook/5/images/TriangularAxisStyling.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/TriangularAxis.cs" imageUrl="/cookbook/5/images/TriangularAxisStyling.png?260329072039" >}}ScottPlot.Plot myPlot = new();

var ta = myPlot.Add.TriangularAxis();

// Customize the background
ta.FillStyle.Color = Colors.Blue.WithAlpha(.1);

// Customize the grid lines
ta.GridLineStyle.Color = Colors.Black.WithAlpha(.5);
ta.GridLineStyle.Pattern = LinePattern.Dotted;

// Add sample data
Coordinates[] points = [
    ta.GetCoordinates(0.50, 0.40),
    ta.GetCoordinates(0.60, 0.40),
    ta.GetCoordinates(0.65, 0.50),
];
myPlot.Add.Markers(points, MarkerShape.FilledCircle, 10, Colors.Red);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/TriangularAxis'>Triangular Axis</a> category</div>


