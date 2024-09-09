---
Title: Ellipse - ScottPlot 5.0 Cookbook
Description: Ellipses are curves with a defined center and distinct X and Y radii. A circle is an ellipse with an X radius equal to its Y radius.
URL: /cookbook/5.0/Ellipse/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Ellipse"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Ellipse"]
Date: 2024-09-09
Version: ScottPlot 5.0.39
Version: ScottPlot 5.0.39
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Ellipse


<h2><a href='/cookbook/5.0/Ellipse/PlotEllipseQuickstart'>Ellipse Quickstart</a></h2>

Ellipses can be added to plots

[![](/cookbook/5.0/images/PlotEllipseQuickstart.png?240908210824)](/cookbook/5.0/images/PlotEllipseQuickstart.png?240908210824)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

Random rand = new(0);
for (int i = 0; i < 5; i++)
{
    myPlot.Add.Ellipse(
        xCenter: rand.Next(-10, 10),
        yCenter: rand.Next(-10, 10),
        radiusX: rand.Next(1, 7),
        radiusY: rand.Next(1, 7));
}

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Ellipse/PlotCircleQuickstart'>Circle Quickstart</a></h2>

Circles can be added to plots. Circles are really Ellipses with the same X and Y radius. Note that circles appear as ellipses unless the plot has a square coordinate system.

[![](/cookbook/5.0/images/PlotCircleQuickstart.png?240908210824)](/cookbook/5.0/images/PlotCircleQuickstart.png?240908210824)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

Random rand = new(0);
for (int i = 0; i < 5; i++)
{
    myPlot.Add.Circle(
        xCenter: rand.Next(-10, 10),
        yCenter: rand.Next(-10, 10),
        radius: rand.Next(1, 7));
}

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Ellipse/CircleWithLockedScale'>Circle with Locked Scale</a></h2>

For circles to always appear circular, the coordinate system must be forced to always display square-shaped pixels. This can be achieved by enabling the axis scale lock.

[![](/cookbook/5.0/images/CircleWithLockedScale.png?240908210824)](/cookbook/5.0/images/CircleWithLockedScale.png?240908210824)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

Random rand = new(0);
for (int i = 0; i < 5; i++)
{
    myPlot.Add.Circle(
        xCenter: rand.Next(-10, 10),
        yCenter: rand.Next(-10, 10),
        radius: rand.Next(1, 7));
}

// force pixels to have a 1:1 scale ratio
myPlot.Axes.SquareUnits();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Ellipse/EllipseStyling'>Ellipse Styling</a></h2>

Ellipses styles can be extensively customized

[![](/cookbook/5.0/images/EllipseStyling.png?240908210824)](/cookbook/5.0/images/EllipseStyling.png?240908210824)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var circle = myPlot.Add.Circle(center: Coordinates.Origin, radius: 5);
circle.LineStyle.Width = 5;
circle.LineStyle.Pattern = LinePattern.Dashed;
circle.LineStyle.Color = Colors.Green;
circle.FillStyle.Color = Colors.Navy;
circle.FillStyle.HatchColor = Colors.Red;
circle.FillStyle.Hatch = new ScottPlot.Hatches.Striped();

myPlot.Axes.SetLimits(-10, 10, -10, 10);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Ellipse/EllipseRotation'>Ellipse Rotation</a></h2>

Ellipses can also be rotated

[![](/cookbook/5.0/images/EllipseRotation.png?240908210824)](/cookbook/5.0/images/EllipseRotation.png?240908210824)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

int count = 5;
for (int i = 0; i < count; i++)
{
    var el = myPlot.Add.Ellipse(
        center: Coordinates.Origin,
        radiusX: 1,
        radiusY: 5);

    el.Rotation = i * 180.0 / count;
}

// force pixels to have a 1:1 scale ratio
ScottPlot.AxisRules.SquareZoomOut rule = new(myPlot.Axes.Bottom, myPlot.Axes.Left);
myPlot.Axes.Rules.Add(rule);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

