---
Title: Triangular Axis Titles - ScottPlot 5.0 Cookbook
Description: Triangular axis edges have a helper method to easily add a title and color all the edge components similarly.
URL: /cookbook/5.0/TriangularAxis/TriangularEdgeTitle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Triangular Axis", "Triangular Axis Titles"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/TriangularAxis", "/cookbook/5.0/TriangularAxis/TriangularEdgeTitle"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Triangular Axis Titles</h1>
</div>

Triangular axis edges have a helper method to easily add a title and color all the edge components similarly.

[![](/cookbook/5.0/images/TriangularEdgeTitle.png?241105214550)](/cookbook/5.0/images/TriangularEdgeTitle.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/TriangularAxis.cs" imageUrl="/cookbook/5.0/images/TriangularEdgeTitle.png?241105214550" >}}ScottPlot.Plot myPlot = new();

var ta = myPlot.Add.TriangularAxis();

// Give each axis a title and color
ta.Bottom.Title("Methane", Colors.Red);
ta.Left.Title("Nitrogen", Colors.Green);
ta.Right.Title("Oxygen", Colors.Blue);

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


