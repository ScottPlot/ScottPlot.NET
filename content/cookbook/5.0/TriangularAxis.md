---
Title: Triangular Axis - ScottPlot 5.0 Cookbook
Description: Create a triangular axis and add it to the plot to display data on a triangular coordinate system.
URL: /cookbook/5.0/TriangularAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Triangular Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/TriangularAxis"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Triangular Axis</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Triangular Axis Quickstart</h1>
<a href='/cookbook/5.0/TriangularAxis/TriangularAxisQuickStart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Create a triangular axis and add it to the plot to display data on a triangular grid, and interact with it to convert triangular units into Cartesian coordinates that can be used for placing any plot type on top.

[![](/cookbook/5.0/images/TriangularAxisQuickStart.png?241102170938)](/cookbook/5.0/images/TriangularAxisQuickStart.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/TriangularAxis.cs" imageUrl="/cookbook/5.0/images/TriangularAxisQuickStart.png?241102170938" >}}ScottPlot.Plot myPlot = new();

// Add a triangular axis to the plot
var ta = myPlot.Add.TriangularAxis();

// Get points from various locations in triangular space
Coordinates[] points = [
    ta.GetCoordinates(0.50, 0.80, 0.20),
    ta.GetCoordinates(0.50, 0.60, 0.40),
    ta.GetCoordinates(0.65, 0.70, 0.30),
    ta.GetCoordinates(0.80, 0.80, 0.20),
];

// Any plot type may be added on top of the triangular axis
myPlot.Add.Markers(points, MarkerShape.FilledCircle, 10, Colors.Red);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Triangular Axis Styling</h1>
<a href='/cookbook/5.0/TriangularAxis/TriangularAxisStyling' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Triangular axis background and grid lines may be customized.

[![](/cookbook/5.0/images/TriangularAxisStyling.png?241102170938)](/cookbook/5.0/images/TriangularAxisStyling.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/TriangularAxis.cs" imageUrl="/cookbook/5.0/images/TriangularAxisStyling.png?241102170938" >}}ScottPlot.Plot myPlot = new();

var ta = myPlot.Add.TriangularAxis();

// Customize the background
ta.FillStyle.Color = Colors.Blue.WithAlpha(.1);

// Customize the grid lines
ta.GridLineStyle.Color = Colors.Black.WithAlpha(.5);
ta.GridLineStyle.Pattern = LinePattern.Dotted;

// Add sample data
Coordinates[] points = [
    ta.GetCoordinates(0.50, 0.80, 0.20),
    ta.GetCoordinates(0.50, 0.60, 0.40),
    ta.GetCoordinates(0.65, 0.70, 0.30),
    ta.GetCoordinates(0.80, 0.80, 0.20),
];
myPlot.Add.Markers(points, MarkerShape.FilledCircle, 10, Colors.Red);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Triangular Axis Edge Styling</h1>
<a href='/cookbook/5.0/TriangularAxis/TriangularAxisEdgeStyling' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Styling options for edge lines, tick marks, tick labels, and title text may be customized individually for each axis.

[![](/cookbook/5.0/images/TriangularAxisEdgeStyling.png?241102170938)](/cookbook/5.0/images/TriangularAxisEdgeStyling.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/TriangularAxis.cs" imageUrl="/cookbook/5.0/images/TriangularAxisEdgeStyling.png?241102170938" >}}ScottPlot.Plot myPlot = new();

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
    ta.GetCoordinates(0.50, 0.80, 0.20),
    ta.GetCoordinates(0.50, 0.60, 0.40),
    ta.GetCoordinates(0.65, 0.70, 0.30),
    ta.GetCoordinates(0.80, 0.80, 0.20),
];
myPlot.Add.Markers(points, MarkerShape.FilledCircle, 10, Colors.Red);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Triangular Axis Titles</h1>
<a href='/cookbook/5.0/TriangularAxis/TriangularEdgeTitle' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Triangular axis edges have a helper method to easily add a title and color all the edge components similarly.

[![](/cookbook/5.0/images/TriangularEdgeTitle.png?241102170938)](/cookbook/5.0/images/TriangularEdgeTitle.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/TriangularAxis.cs" imageUrl="/cookbook/5.0/images/TriangularEdgeTitle.png?241102170938" >}}ScottPlot.Plot myPlot = new();

var ta = myPlot.Add.TriangularAxis();

// Give each axis a title and color
ta.Bottom.Title("Methane", Colors.Red);
ta.Left.Title("Nitrogen", Colors.Green);
ta.Right.Title("Oxygen", Colors.Blue);

// Add sample data
Coordinates[] points = [
    ta.GetCoordinates(0.50, 0.80, 0.20),
    ta.GetCoordinates(0.50, 0.60, 0.40),
    ta.GetCoordinates(0.65, 0.70, 0.30),
    ta.GetCoordinates(0.80, 0.80, 0.20),
];
myPlot.Add.Markers(points, MarkerShape.FilledCircle, 10, Colors.Red);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


