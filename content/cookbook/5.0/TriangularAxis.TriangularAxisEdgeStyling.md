---
Title: Triangular Axis Edge Styling - ScottPlot 5.0 Cookbook
Description: Styling options for edge lines, tick marks, tick labels, and title text may be customized individually for each axis.
URL: /cookbook/5.0/TriangularAxis/TriangularAxisEdgeStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Triangular Axis", "Triangular Axis Edge Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/TriangularAxis", "/cookbook/5.0/TriangularAxis/TriangularAxisEdgeStyling"]
Date: 2025-01-13
Version: ScottPlot 5.0.53
Version: ScottPlot 5.0.53
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Triangular Axis Edge Styling</h1>
</div>

Styling options for edge lines, tick marks, tick labels, and title text may be customized individually for each axis.

[![](/cookbook/5.0/images/TriangularAxisEdgeStyling.png?250112204022)](/cookbook/5.0/images/TriangularAxisEdgeStyling.png?250112204022)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/TriangularAxis.cs" imageUrl="/cookbook/5.0/images/TriangularAxisEdgeStyling.png?250112204022" >}}ScottPlot.Plot myPlot = new();

var ta = myPlot.Add.TriangularAxis();

// the edge line extends from one corner to the other
ta.Left.EdgeLineStyle.Width = 3;
ta.Left.EdgeLineStyle.Color = Colors.Blue;

// tick labels and marks may be styled individually
ta.Left.TickLabelStyle.ForeColor = Colors.Blue;
ta.Left.TickMarkStyle.Color = Colors.Blue;
ta.Left.TickMarkStyle.Width = 3;
ta.Left.TickOffset = new(-10, 0);
ta.Left.TickLabelStyle.Bold = true;
ta.Left.TickLabelStyle.OffsetX = -4;

// an axis title may be added and styled
ta.Left.LabelText = "Hello, World";
ta.Left.LabelStyle.ForeColor = Colors.Blue;
ta.Left.LabelStyle.FontSize = 26;
ta.Left.LabelStyle.Bold = false;
ta.Left.LabelStyle.OffsetX = -20;

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


