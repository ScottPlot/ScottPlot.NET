---
Title: Shapes - ScottPlot 5.0 Cookbook
Description: Basic shapes that can be added to plots
URL: /cookbook/5.0/Shapes/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Shapes</h1>


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Shapes/RectangleQuickstart'>Rectangle</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Shapes/RectangleQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Shapes">Category: Shapes</a>
</div>

A rectangle can be added to the plot and styled as desired.

[![](/cookbook/5.0/images/RectangleQuickstart.png?241029205813)](/cookbook/5.0/images/RectangleQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Shapes/CircleQuickstart'>Circle</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Shapes/CircleQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Shapes">Category: Shapes</a>
</div>

A circle can be placed on the plot and styled as desired.

[![](/cookbook/5.0/images/CircleQuickstart.png?241029205813)](/cookbook/5.0/images/CircleQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Shapes/EllipseQuickstart'>Ellipse</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Shapes/EllipseQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Shapes">Category: Shapes</a>
</div>

An ellipse can be placed on the plot and styled as desired.

[![](/cookbook/5.0/images/EllipseQuickstart.png?241029205813)](/cookbook/5.0/images/EllipseQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 10; i++)
{
    var el = myPlot.Add.Ellipse(0, 0, 1, 10, rotation: i * 10);
    double fraction = i / 10.0;
    el.LineColor = Colors.Blue.WithAlpha(fraction);
}

// force circles to remain circles
ScottPlot.AxisRules.SquareZoomOut squareRule = new(myPlot.Axes.Bottom, myPlot.Axes.Left);
myPlot.Axes.Rules.Add(squareRule);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Shapes/PolygonQuickstart'>Polygon Plot Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Shapes/PolygonQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Shapes">Category: Shapes</a>
</div>

Polygon plots can be added from a series of vertices, and must be in clockwise order.

[![](/cookbook/5.0/images/PolygonQuickstart.png?241029205813)](/cookbook/5.0/images/PolygonQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Shapes/PolygonStyling'>Polygon Plot Styling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Shapes/PolygonStyling">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Shapes">Category: Shapes</a>
</div>

Polygon plots can be fully customized.

[![](/cookbook/5.0/images/PolygonStyling.png?241029205813)](/cookbook/5.0/images/PolygonStyling.png?241029205813)

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


