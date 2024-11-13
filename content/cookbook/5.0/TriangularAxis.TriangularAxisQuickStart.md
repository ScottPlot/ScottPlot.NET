---
Title: Triangular Axis Quickstart - ScottPlot 5.0 Cookbook
Description: Create a triangular axis and add it to the plot to display data on a triangular grid, and interact with it to convert triangular units into Cartesian coordinates that can be used for placing any plot type on top.
URL: /cookbook/5.0/TriangularAxis/TriangularAxisQuickStart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Triangular Axis", "Triangular Axis Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/TriangularAxis", "/cookbook/5.0/TriangularAxis/TriangularAxisQuickStart"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Triangular Axis Quickstart</h1>
</div>

Create a triangular axis and add it to the plot to display data on a triangular grid, and interact with it to convert triangular units into Cartesian coordinates that can be used for placing any plot type on top.

[![](/cookbook/5.0/images/TriangularAxisQuickStart.png?241112193154)](/cookbook/5.0/images/TriangularAxisQuickStart.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/TriangularAxis.cs" imageUrl="/cookbook/5.0/images/TriangularAxisQuickStart.png?241112193154" >}}ScottPlot.Plot myPlot = new();

// Add a triangular axis to the plot
var ta = myPlot.Add.TriangularAxis();

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


