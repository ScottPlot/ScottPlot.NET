---
Title: Shapes - ScottPlot 5.0 Cookbook
Description: Basic shapes that can be added to plots
URL: /cookbook/5.0/Shapes/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes"]
Date: 2024-01-29
Version: ScottPlot 5.0.21
Version: ScottPlot 5.0.21
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Shapes


<h2><a href='/cookbook/5.0/Shapes/RectangleQuickstart'>Rectangle</a></h2>

A rectangle can be added to the plot and styled as desired.

[![](/cookbook/5.0/images/RectangleQuickstart.png?240128210832)](/cookbook/5.0/images/RectangleQuickstart.png?240128210832)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Shapes/CircleQuickstart'>Circle</a></h2>

A circle can be placed on the plot and styled as desired.

[![](/cookbook/5.0/images/CircleQuickstart.png?240128210832)](/cookbook/5.0/images/CircleQuickstart.png?240128210832)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// TODO: need a circle plot type

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Shapes/EllipseQuickstart'>Ellipse</a></h2>

An ellipse can be placed on the plot and styled as desired.

[![](/cookbook/5.0/images/EllipseQuickstart.png?240128210832)](/cookbook/5.0/images/EllipseQuickstart.png?240128210832)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// TODO: need ellipse plot type

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Shapes/PolygonQuickstart'>Polygon Plot Quickstart</a></h2>

Polygon plots can be added from a series of vertices, and must be in clockwise order.

[![](/cookbook/5.0/images/PolygonQuickstart.png?240128210832)](/cookbook/5.0/images/PolygonQuickstart.png?240128210832)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Shapes/PolygonStyling'>Polygon Plot Styling</a></h2>

Polygon plots can be fully customized.

[![](/cookbook/5.0/images/PolygonStyling.png?240128210832)](/cookbook/5.0/images/PolygonStyling.png?240128210832)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

Coordinates[] points =
{
    new (0, 0.25),
    new (0.3, 0.75),
    new (1, 1),
    new (0.7, 0.5),
    new (1, 0)
};

var poly = myPlot.Add.Polygon(points);

poly.FillStyle = new FillStyle
{
    Color = Colors.Green,
    HatchColor = Colors.Blue,
    Hatch = new Gradient()
    {
        GradiantType = GradiantType.Linear,
        AlignmentStart = Alignment.UpperRight,
        AlignmentEnd = Alignment.LowerLeft,
    }
};

poly.LineStyle = new LineStyle
{
    AntiAlias = true,
    Color = Colors.Black,
    Pattern = LinePattern.Dashed,
    Width = 2
};

poly.MarkerStyle = new MarkerStyle(MarkerShape.OpenCircle, 8);
poly.MarkerStyle.Fill.Color = Colors.Gold;
poly.MarkerStyle.Outline.Color = Colors.Brown;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

