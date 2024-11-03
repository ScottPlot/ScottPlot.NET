---
Title: Triangular Axis Styling - ScottPlot 5.0 Cookbook
Description: Triangular axis background and grid lines may be customized.
URL: /cookbook/5.0/TriangularAxis/TriangularAxisStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Triangular Axis", "Triangular Axis Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/TriangularAxis", "/cookbook/5.0/TriangularAxis/TriangularAxisStyling"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Triangular Axis Styling</h1>
</div>

Triangular axis background and grid lines may be customized.

[![](/cookbook/5.0/images/TriangularAxisStyling.png?241103171511)](/cookbook/5.0/images/TriangularAxisStyling.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/TriangularAxis.cs" imageUrl="/cookbook/5.0/images/TriangularAxisStyling.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/TriangularAxis'>Triangular Axis</a> category</div>


