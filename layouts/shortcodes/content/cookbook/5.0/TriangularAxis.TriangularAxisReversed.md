---
Title: Triangular Axis Reverse - ScottPlot 5.0 Cookbook
Description: Triangular axes typically ascend in a clockwise direction for general applications, but triangular plots with counterclockwise labeling are sometimes used for geological applications.
URL: /cookbook/5.0/TriangularAxis/TriangularAxisReversed/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Triangular Axis", "Triangular Axis Reverse"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/TriangularAxis", "/cookbook/5.0/TriangularAxis/TriangularAxisReversed"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Triangular Axis Reverse</h1>
</div>

Triangular axes typically ascend in a clockwise direction for general applications, but triangular plots with counterclockwise labeling are sometimes used for geological applications.

[![](/cookbook/5.0/images/TriangularAxisReversed.png?250322130304)](/cookbook/5.0/images/TriangularAxisReversed.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/TriangularAxis.cs" imageUrl="/cookbook/5.0/images/TriangularAxisReversed.png?250322130304" >}}ScottPlot.Plot myPlot = new();

// Add a COUNTER-CLOCKWISE triangular axis to the plot
var ta = myPlot.Add.TriangularAxis(clockwise: false);

// Get points from various locations in triangular space
Coordinates[] points = [
    ta.GetCoordinates(0.50, 0.40),
    ta.GetCoordinates(0.60, 0.40),
    ta.GetCoordinates(0.65, 0.50),
];

// Any plot type may be added on top of the triangular axis
myPlot.Add.Markers(points, MarkerShape.FilledCircle, 10, Colors.Red);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/TriangularAxis'>Triangular Axis</a> category</div>


