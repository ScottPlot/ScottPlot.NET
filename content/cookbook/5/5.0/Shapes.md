---
Title: Shapes - ScottPlot 5.0 Cookbook
Description: Basic shapes that can be added to plots
URL: /cookbook/5.0/Shapes/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Shapes</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Rectangle</h1>
<a href='/cookbook/5.0/Shapes/RectangleQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A rectangle can be added to the plot and styled as desired.

[![](/cookbook/5.0/images/RectangleQuickstart.png?250126165944)](/cookbook/5.0/images/RectangleQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/RectangleQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// add a rectangle by specifying points
myPlot.Add.Rectangle(0, 1, 0, 1);

// add a rectangle using more expressive shapes
Coordinates location = new(2, 0);
CoordinateSize size = new(1, 1);
CoordinateRect rect = new(location, size);
myPlot.Add.Rectangle(rect);

// style rectangles after they are added to the plot
var rp = myPlot.Add.Rectangle(4, 5, 0, 1);
rp.FillStyle.Color = Colors.Magenta.WithAlpha(.2);
rp.LineStyle.Color = Colors.Green;
rp.LineStyle.Width = 3;
rp.LineStyle.Pattern = LinePattern.Dashed;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Circle</h1>
<a href='/cookbook/5.0/Shapes/CircleQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A circle can be placed on the plot and styled as desired.

[![](/cookbook/5.0/images/CircleQuickstart.png?250126165944)](/cookbook/5.0/images/CircleQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/CircleQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

var c1 = myPlot.Add.Circle(1, 0, .5);
var c2 = myPlot.Add.Circle(2, 0, .5);
var c3 = myPlot.Add.Circle(3, 0, .5);

c1.FillStyle.Color = Colors.Blue;
c2.FillStyle.Color = Colors.Blue.Darken(.75);
c3.FillStyle.Color = Colors.Blue.Lighten(.75);

c1.LineWidth = 0;
c2.LineWidth = 0;
c3.LineWidth = 0;

// force circles to remain circles
ScottPlot.AxisRules.SquareZoomOut squareRule = new(myPlot.Axes.Bottom, myPlot.Axes.Left);
myPlot.Axes.Rules.Add(squareRule);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Ellipse</h1>
<a href='/cookbook/5.0/Shapes/EllipseQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

An ellipse can be placed on the plot and styled as desired.

[![](/cookbook/5.0/images/EllipseQuickstart.png?250126165944)](/cookbook/5.0/images/EllipseQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/EllipseQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 10; i++)
{
    var el = myPlot.Add.Ellipse(0, 0, 1, 10, rotation: Angle.FromDegrees(i * -10));
    double fraction = i / 10.0;
    el.LineColor = Colors.Blue.WithAlpha(fraction);
}

// force circles to remain circles
ScottPlot.AxisRules.SquareZoomOut squareRule = new(myPlot.Axes.Bottom, myPlot.Axes.Left);
myPlot.Axes.Rules.Add(squareRule);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polygon Plot Quickstart</h1>
<a href='/cookbook/5.0/Shapes/PolygonQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Polygon plots can be added from a series of vertices, and must be in clockwise order.

[![](/cookbook/5.0/images/PolygonQuickstart.png?250126165944)](/cookbook/5.0/images/PolygonQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/PolygonQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

Coordinates[] points =
{
    new(0,   0.25),
    new(0.3, 0.75),
    new(1,   1),
    new(0.7, 0.5),
    new(1,   0)
};

myPlot.Add.Polygon(points);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polygon Plot Styling</h1>
<a href='/cookbook/5.0/Shapes/PolygonStyling' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Polygon plots can be fully customized.

[![](/cookbook/5.0/images/PolygonStyling.png?250126165944)](/cookbook/5.0/images/PolygonStyling.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/PolygonStyling.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stacked Line Chart</h1>
<a href='/cookbook/5.0/Shapes/StackedLineChart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A stacked line chart may be achieved by combining primitive shapes onto a plot.

[![](/cookbook/5.0/images/StackedLineChart.png?250126165944)](/cookbook/5.0/images/StackedLineChart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/StackedLineChart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// prepare values for each line
double[] values1 = [8.4, 6.9, 6.5, 4.4];
double[] values2 = [7.9, 6.6, 6.4, 6.2];
double[] values3 = [6.2, 7.3, 5.5, 3.7];

// create a collection holding values for each line
double[][] allValues = [values1, values2, values3];

// calculate step points for each like by storing each point twice
double[] runningSum = new double[values1.Length];
for (int i = 0; i &lt; allValues.Length; i++)
{
    // add values on top of the running sum to achieve stacking effect
    runningSum = DataOperations.SumVertically([runningSum, allValues[i]]);

    List&lt;Coordinates&gt; points = [];
    for (int j = 0; j &lt; runningSum.Length; j++)
    {
        points.Add(new(j, runningSum[j]));
        points.Add(new(j + 1, runningSum[j]));
    }

    // plot the points as it is to show a line
    Coordinates[] lineCoordinates = [.. points];

    // add the start and end points
    points.Add(new(points.Last().X, 0));
    points.Add(new(points.First().X, 0));
    Coordinates[] fillCoordinates = [.. points];

    // add the polygon then top it with a line
    var line = myPlot.Add.ScatterLine(lineCoordinates);
    line.Color = ScottPlot.Palette.Default.GetColor(i);
    line.LineWidth = 2;

    var poly = myPlot.Add.Polygon(fillCoordinates);
    poly.FillColor = line.Color.Lighten(.5);
    poly.LineWidth = 0;
}

// reverse the order of everything so the smallest polygons
// (the first that were added) to be displayed on top and rendered last
myPlot.PlottableList.Reverse();

// use tight margins to prevent padding between the data and edge of the plot
myPlot.Axes.Margins(0, 0, 0, 0.1);

// add group labels
double[] positions = [0.5, 1.5, 2.5, 3.5];
string[] labels = { "Alfred", "Ralph", "Don", "James" };
myPlot.Axes.Bottom.SetTicks(positions, labels);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Arc</h1>
<a href='/cookbook/5.0/Shapes/Arc' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

An arc is a curve along the partial circumference of a circle. The circle starts at the far right and extends counter-clockwise.

[![](/cookbook/5.0/images/Arc.png?250126165944)](/cookbook/5.0/images/Arc.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/Arc.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Elliptical Arc</h1>
<a href='/cookbook/5.0/Shapes/EllipticalArc' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

An elliptical arc is a curve along the partial circumference of an ellipse. The ellipse starts at the far right and extends counter-clockwise.

[![](/cookbook/5.0/images/EllipticalArc.png?250126165944)](/cookbook/5.0/images/EllipticalArc.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/EllipticalArc.png?250126165944" >}}ScottPlot.Plot myPlot = new();

Coordinates center = new(0, 0);
double radiusX = 2.0;
double radiusY = 1.0;
Angle start = Angle.FromDegrees(45);
Angle sweep = Angle.FromDegrees(135);

var ellipse = myPlot.Add.Ellipse(center, radiusX, radiusY);
ellipse.FillColor = Colors.Blue.WithAlpha(.2);
ellipse.LineWidth = 0;

var arc = myPlot.Add.EllipticalArc(center, radiusX, radiusY, start, sweep);
arc.LineWidth = 5;
arc.LineColor = Colors.Black;

myPlot.Axes.SquareUnits(); // use square units so circles are not stretched

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Circle Sector</h1>
<a href='/cookbook/5.0/Shapes/CircleSector' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A circle sector is the 2D shape formed by the area inside a circle between an arc around its circumference and its center point.

[![](/cookbook/5.0/images/CircleSector.png?250126165944)](/cookbook/5.0/images/CircleSector.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/CircleSector.png?250126165944" >}}ScottPlot.Plot myPlot = new();

Coordinates center = new(0, 0);
double radius = 1.0;
Angle start = Angle.FromDegrees(45);
Angle sweep = Angle.FromDegrees(135);

var cs = myPlot.Add.CircleSector(center, radius, start, sweep);
cs.FillColor = Colors.Blue.WithAlpha(.2);
cs.LineColor = Colors.Black;
cs.LineWidth = 5;

myPlot.Axes.SquareUnits(); // use square units so circles are not stretched

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Ellipse Sector</h1>
<a href='/cookbook/5.0/Shapes/EllipseSector' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

An ellipse sector is the 2D shape formed by the area inside an ellipse between an arc around its edge and its center point.

[![](/cookbook/5.0/images/EllipseSector.png?250126165944)](/cookbook/5.0/images/EllipseSector.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/EllipseSector.png?250126165944" >}}ScottPlot.Plot myPlot = new();

Coordinates center = new(0, 0);
double radiusX = 2.0;
double radiusY = 1.0;
Angle start = Angle.FromDegrees(45);
Angle sweep = Angle.FromDegrees(135);

var cs = myPlot.Add.EllipticalSector(center, radiusX, radiusY, start, sweep);
cs.FillColor = Colors.Blue.WithAlpha(.2);
cs.LineColor = Colors.Black;
cs.LineWidth = 5;

myPlot.Axes.SquareUnits(); // use square units so circles are not stretched

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Annular Sector</h1>
<a href='/cookbook/5.0/Shapes/AnnularSector' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

An annular sector is the 2D shape between two circles (like a donut) and may be sliced to contain only the area between two angles relative to the center point.

[![](/cookbook/5.0/images/AnnularSector.png?250126165944)](/cookbook/5.0/images/AnnularSector.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/AnnularSector.png?250126165944" >}}ScottPlot.Plot myPlot = new();

Coordinates center = new(0, 0);
double outerRadius = 2.0;
double innerRadius = 1.0;
Angle start = Angle.FromDegrees(45);
Angle sweep = Angle.FromDegrees(135);

var cs = myPlot.Add.AnnularSector(center, outerRadius, innerRadius, start, sweep);
cs.FillColor = Colors.Blue.WithAlpha(.2);
cs.LineColor = Colors.Black;
cs.LineWidth = 5;

myPlot.Axes.SquareUnits(); // use square units so circles are not stretched

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Annular Elliptical Sector</h1>
<a href='/cookbook/5.0/Shapes/AnnularEllipticalSector' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

An annular elliptical sector is the 2D shape between two ellipses and may be sliced to contain only the area between two angles relative to the center point.

[![](/cookbook/5.0/images/AnnularEllipticalSector.png?250126165944)](/cookbook/5.0/images/AnnularEllipticalSector.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/AnnularEllipticalSector.png?250126165944" >}}ScottPlot.Plot myPlot = new();

Coordinates center = new(0, 0);
double outerRadiusX = 4.0;
double outerRadiusY = 2.0;
double innerRadiusX = 2.0;
double innerRadiusY = 1.0;
Angle start = Angle.FromDegrees(45);
Angle sweep = Angle.FromDegrees(135);

var cs = myPlot.Add.AnnularEllipticalSector(center, outerRadiusX, outerRadiusY, innerRadiusX, innerRadiusY, start, sweep);
cs.FillColor = Colors.Blue.WithAlpha(.2);
cs.LineColor = Colors.Black;
cs.LineWidth = 5;

myPlot.Axes.SquareUnits(); // use square units so circles are not stretched

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


