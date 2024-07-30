---
Title: Advanced Axis Features - ScottPlot 5.0 Cookbook
Description: How to further customize axes
URL: /cookbook/5.0/AdvancedAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Advanced Axis Features"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AdvancedAxis"]
Date: 2024-07-30
Version: ScottPlot 5.0.37
Version: ScottPlot 5.0.37
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Advanced Axis Features


<h2><a href='/cookbook/5.0/AdvancedAxis/InvertedAxis'>Inverted Axis</a></h2>

Users can display data on an inverted axis by setting axis limits setting the lower edge to a value more positive than the upper edge.

[![](/cookbook/5.0/images/InvertedAxis.png?240729212327)](/cookbook/5.0/images/InvertedAxis.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.SetLimitsY(bottom: 1.5, top: -1.5);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/InvertedAutoAxis'>Inverted Auto-Axis</a></h2>

Customize the logic for the automatic axis scaler to ensure that axis limits for a particular axis are always inverted when autoscaled.

[![](/cookbook/5.0/images/InvertedAutoAxis.png?240729212327)](/cookbook/5.0/images/InvertedAutoAxis.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.AutoScaler.InvertedY = true;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/SquareAxisUnits'>Square Axis Units</a></h2>

Axis rules can be put in place which force the vertical scale (units per pixel) to match the horizontal scale so circles always appear as circles and not stretched ellipses.

[![](/cookbook/5.0/images/SquareAxisUnits.png?240729212327)](/cookbook/5.0/images/SquareAxisUnits.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Circle(0, 0, 10);

// force pixels to have a 1:1 scale ratio
myPlot.Axes.SquareUnits();

// even if you try to "stretch" the axis, it will adjust the axis limits automatically
myPlot.Axes.SetLimits(-10, 10, -20, 20);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/ExperimentalAxisWithSubtitle'>Axis with Subtitle</a></h2>

Users can create their own fully custom axes to replace the default ones (as demonstrated in the demo app). Some experimental axes are available for users who may be interested in alternative axis display styles.

[![](/cookbook/5.0/images/ExperimentalAxisWithSubtitle.png?240729212327)](/cookbook/5.0/images/ExperimentalAxisWithSubtitle.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// Plot some sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// Instantiate a custom axis and customize it as desired
ScottPlot.AxisPanels.Experimental.LeftAxisWithSubtitle customAxisY = new()
{
    LabelText = "My Custom Y Axis",
    SubLabelText = "It comes with a subtitle for the axis"
};

// Remove the default Y axis and add the custom one to the plot
myPlot.Axes.Remove(myPlot.Axes.Left);
myPlot.Axes.AddLeftAxis(customAxisY);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/AxisAntiAliasing'>Axis AntiAliasing</a></h2>

To improve crispness of straight vertical and horizontal lines, Anti-aliasing is disabled by default for axis frames, tick marks, and grid lines. Anti-aliasing can be enabled for all these objects by calling the AntiAlias helper method.

[![](/cookbook/5.0/images/AxisAntiAliasing.png?240729212327)](/cookbook/5.0/images/AxisAntiAliasing.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
myPlot.Add.Scatter(dataX, dataY);

myPlot.Axes.AntiAlias(true);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/PolarQuickStart'>Polar Axis</a></h2>

A polar axis can be added to the plot, then other plot types (marker, line, scatter, etc.) can be placed on top of it using ints helper methods to translate polar coordinates to Cartesian units.

[![](/cookbook/5.0/images/PolarQuickStart.png?240729212327)](/cookbook/5.0/images/PolarQuickStart.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis(maximumRadius: 100);

for (int i = 0; i < 10; i++)
{
    double radius = Generate.RandomNumber(100);
    double degrees = Generate.RandomNumber(360);
    Coordinates pt = polarAxis.GetCoordinates(radius, degrees);
    myPlot.Add.Marker(pt);
}

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/PolarAxisArrow'>Polar Axis with Arrows</a></h2>

Arrows can be placed on a polar coordinate system with their base at the center and their tips used to indicate points in polar space. The Phaser plot type uses this strategy to display collections of similarly styled arrows.

[![](/cookbook/5.0/images/PolarAxisArrow.png?240729212327)](/cookbook/5.0/images/PolarAxisArrow.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

PolarCoordinates[] points = [
    new(10, Angle.FromDegrees(15)),
    new(20, Angle.FromDegrees(120)),
    new(30, Angle.FromDegrees(240)),
];

var polarAxis = myPlot.Add.PolarAxis(30);
polarAxis.LinePattern = LinePattern.Dotted;

IPalette palette = new ScottPlot.Palettes.Category10();
Coordinates center = polarAxis.GetCoordinates(0, 0);
for (int i = 0; i < points.Length; i++)
{
    Coordinates tip = polarAxis.GetCoordinates(points[i]);
    var arrow = myPlot.Add.Arrow(center, tip);
    arrow.ArrowLineWidth = 0;
    arrow.ArrowFillColor = palette.GetColor(i).WithAlpha(.7);
}

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/PolarAxisStyling'>Polar Axis Styling</a></h2>

The lines of polar axes may be extensively styled. Polar axes have radial spokes (straight lines that extend from the origin to the maximum radius) and circular axis lines (concentric circles centered at the origin).

[![](/cookbook/5.0/images/PolarAxisStyling.png?240729212327)](/cookbook/5.0/images/PolarAxisStyling.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var pol = myPlot.Add.PolarAxis();

// style the spokes (straight lines extending from the center to mark rotations)
var radialPalette = new ScottPlot.Palettes.Category10();
for (int i = 0; i < pol.Spokes.Count; i++)
{
    pol.Spokes[i].LineColor = radialPalette.GetColor(i).WithAlpha(.5);
    pol.Spokes[i].LineWidth = 4;
    pol.Spokes[i].LinePattern = LinePattern.DenselyDashed;
}

// style the circles (concentric circles marking radius positions)
var circularColormap = new ScottPlot.Colormaps.Rain();
for (int i = 0; i < pol.Circles.Count; i++)
{
    double fraction = (double)i / (pol.Circles.Count - 1);
    pol.Circles[i].LineColor = circularColormap.GetColor(fraction).WithAlpha(.5);
    pol.Circles[i].LineWidth = 2;
    pol.Circles[i].LinePattern = LinePattern.Dashed;
}

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/PolarAxisLineDensity'>Polar Line Density</a></h2>

Density of spokes and circles on polar axes can be customized using arguments passed into the functions that generate them.

[![](/cookbook/5.0/images/PolarAxisLineDensity.png?240729212327)](/cookbook/5.0/images/PolarAxisLineDensity.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var pol = myPlot.Add.PolarAxis();
pol.RegenerateCircles(count: 10);
pol.RegenerateSpokes(count: 4);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/PolarAxisLinePositions'>Polar Line Positions</a></h2>

The angle and length of spokes and position of circles can be manually defined. Each spoke and circle may also be individually styled.

[![](/cookbook/5.0/images/PolarAxisLinePositions.png?240729212327)](/cookbook/5.0/images/PolarAxisLinePositions.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var pol = myPlot.Add.PolarAxis();

// define spoke angle and length
pol.Spokes.Clear();
pol.Spokes.Add(new(Angle.FromDegrees(0), 0.5));
pol.Spokes.Add(new(Angle.FromDegrees(45), 0.75));
pol.Spokes.Add(new(Angle.FromDegrees(90), 1.0));

// define circle radius
pol.Circles.Clear();
pol.Circles.Add(new(0.5));
pol.Circles.Add(new(0.75));
pol.Circles.Add(new(1.0));

// style individual spokes and circles
ScottPlot.Palettes.Category10 pal = new();
for (int i = 0; i < 3; i++)
{
    pol.Circles[i].LineColor = pal.GetColor(i).WithAlpha(.5);
    pol.Spokes[i].LineColor = pal.GetColor(i).WithAlpha(.5);

    pol.Circles[i].LineWidth = 2 + i * 2;
    pol.Spokes[i].LineWidth = 2 + i * 2;
}

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

