---
Title: Polar Axis - ScottPlot 5.0 Cookbook
Description: Create a polar axis and add it to the plot to display data on a circular coordinate system.
URL: /cookbook/5.0/Polar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Polar"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Polar Axis</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis</h1>
<a href='/cookbook/5.0/Polar/PolarQuickStart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A polar axis can be added to the plot, then other plot types (marker, line, scatter, etc.) can be placed on top of it using ints helper methods to translate polar coordinates to Cartesian units.

[![](/cookbook/5.0/images/PolarQuickStart.png?241101192719)](/cookbook/5.0/images/PolarQuickStart.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add a polar axis to the plot
var polarAxis = myPlot.Add.PolarAxis(radius: 100);

IColormap colormap = new ScottPlot.Colormaps.Turbo();
foreach (double fraction in ScottPlot.Generate.Range(0, 1, 0.02))
{
    // use the polar axis to get X/Y coordinates given a position in polar space
    double radius = 100 * fraction;
    double degrees = 360 * fraction;
    Coordinates pt = polarAxis.GetCoordinates(radius, degrees);

    // place markers or other plot types using X/Y coordinates like normal
    var marker = myPlot.Add.Marker(pt);
    marker.Color = colormap.GetColor(fraction);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Rotation</h1>
<a href='/cookbook/5.0/Polar/PolarRotation' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A polar axis may be rotated to define the angle of the 0 degree spoke.

[![](/cookbook/5.0/images/PolarRotation.png?241101192719)](/cookbook/5.0/images/PolarRotation.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis(radius: 100);
polarAxis.Rotation = Angle.FromDegrees(-90);

IColormap colormap = new ScottPlot.Colormaps.Turbo();
foreach (double fraction in ScottPlot.Generate.Range(0, 1, 0.02))
{
    double radius = 100 * fraction;
    double degrees = 360 * fraction;
    Coordinates pt = polarAxis.GetCoordinates(radius, degrees);
    var marker = myPlot.Add.Marker(pt);
    marker.Color = colormap.GetColor(fraction);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis with Arrows</h1>
<a href='/cookbook/5.0/Polar/PolarAxisArrow' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Arrows can be placed on a polar coordinate system with their base at the center and their tips used to indicate points in polar space. The Phaser plot type uses this strategy to display collections of similarly styled arrows.

[![](/cookbook/5.0/images/PolarAxisArrow.png?241101192719)](/cookbook/5.0/images/PolarAxisArrow.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

PolarCoordinates[] points = [
    new(10, Angle.FromDegrees(15)),
    new(20, Angle.FromDegrees(120)),
    new(30, Angle.FromDegrees(240)),
];

var polarAxis = myPlot.Add.PolarAxis(30);
polarAxis.Circles.ForEach(x => x.LinePattern = LinePattern.Dotted);
polarAxis.Spokes.ForEach(x => x.LinePattern = LinePattern.Dotted);

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Styling</h1>
<a href='/cookbook/5.0/Polar/PolarAxisStyling' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The lines of polar axes may be extensively styled. Polar axes have radial spokes (straight lines that extend from the origin to the maximum radius) and circular axis lines (concentric circles centered at the origin).

[![](/cookbook/5.0/images/PolarAxisStyling.png?241101192719)](/cookbook/5.0/images/PolarAxisStyling.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();

// style the spokes (straight lines extending from the center to mark rotations)
var radialPalette = new ScottPlot.Palettes.Category10();
for (int i = 0; i < polarAxis.Spokes.Count; i++)
{
    polarAxis.Spokes[i].LineColor = radialPalette.GetColor(i).WithAlpha(.5);
    polarAxis.Spokes[i].LineWidth = 4;
    polarAxis.Spokes[i].LabelStyle.ForeColor = radialPalette.GetColor(i);
    polarAxis.Spokes[i].LabelStyle.FontSize = 16;
    polarAxis.Spokes[i].LabelStyle.Bold = true;
}

// style the circles (concentric circles marking radius positions)
var circularColormap = new ScottPlot.Colormaps.Rain();
for (int i = 0; i < polarAxis.Circles.Count; i++)
{
    double fraction = (double)i / (polarAxis.Circles.Count - 1);
    polarAxis.Circles[i].LineColor = circularColormap.GetColor(fraction).WithAlpha(.5);
    polarAxis.Circles[i].LineWidth = 2;
    polarAxis.Circles[i].LinePattern = LinePattern.Dashed;
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Spoke Labels</h1>
<a href='/cookbook/5.0/Polar/PolarSpokeLabels' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Polar axis spokes may be individually labeled.

[![](/cookbook/5.0/images/PolarSpokeLabels.png?241101192719)](/cookbook/5.0/images/PolarSpokeLabels.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();

string[] labels = { "alpha", "beta", "gamma", "delta", "epsilon" };
polarAxis.SetSpokes(labels, 1.1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Tick Labels</h1>
<a href='/cookbook/5.0/Polar/PolarTickLabels' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Polar axis ticks are marked by circles which may be individually labeled.

[![](/cookbook/5.0/images/PolarTickLabels.png?241101192719)](/cookbook/5.0/images/PolarTickLabels.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();
polarAxis.Rotation = Angle.FromDegrees(-90);

double[] ticksPositions = { 5, 10, 15, 20 };
string[] tickLabels = { "A", "B", "C", "D" };
polarAxis.SetCircles(ticksPositions, tickLabels);

polarAxis.SetSpokes(count: 5, length: 22, degreeLabels: false);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Line Customization</h1>
<a href='/cookbook/5.0/Polar/PolarAxisLineCustomizations' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The angle and length of spokes and position of circles can be manually defined. Each spoke and circle may also be individually styled.

[![](/cookbook/5.0/images/PolarAxisLineCustomizations.png?241101192719)](/cookbook/5.0/images/PolarAxisLineCustomizations.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();

// define spoke angle and length
polarAxis.Spokes.Clear();
polarAxis.Spokes.Add(new(Angle.FromDegrees(0), 0.5));
polarAxis.Spokes.Add(new(Angle.FromDegrees(45), 0.75));
polarAxis.Spokes.Add(new(Angle.FromDegrees(90), 1.0));

// define circle radius
polarAxis.Circles.Clear();
polarAxis.Circles.Add(new(0.5));
polarAxis.Circles.Add(new(0.75));
polarAxis.Circles.Add(new(1.0));

// style individual spokes and circles
ScottPlot.Palettes.Category10 pal = new();
for (int i = 0; i < 3; i++)
{
    polarAxis.Circles[i].LineColor = pal.GetColor(i).WithAlpha(.5);
    polarAxis.Spokes[i].LineColor = pal.GetColor(i).WithAlpha(.5);

    polarAxis.Circles[i].LineWidth = 2 + i * 2;
    polarAxis.Spokes[i].LineWidth = 2 + i * 2;
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Radar Plot</h1>
<a href='/cookbook/5.0/Polar/PolarRadar' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Combining a polar axis with polygons is an alternative strategy for building radar plots.

[![](/cookbook/5.0/images/PolarRadar.png?241101192719)](/cookbook/5.0/images/PolarRadar.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();
polarAxis.Rotation = Angle.FromDegrees(-90);

// add labeled spokes
string[] labels = { "Alpha", "Beta", "Gamma", "Delta", "Epsilon" };
polarAxis.SetSpokes(labels, length: 5.5);

// add defined ticks
double[] ticks = { 1, 2, 3, 4, 5 };
polarAxis.SetCircles(ticks);

// convert radar values to coordinates
double[] values1 = { 5, 4, 5, 2, 3 };
double[] values2 = { 2, 3, 2, 4, 2 };
Coordinates[] cs1 = polarAxis.GetCoordinates(values1);
Coordinates[] cs2 = polarAxis.GetCoordinates(values2);

// add polygons for each dataset
var poly1 = myPlot.Add.Polygon(cs1);
poly1.FillColor = Colors.Green.WithAlpha(.5);
poly1.LineColor = Colors.Black;

var poly2 = myPlot.Add.Polygon(cs2);
poly2.FillColor = Colors.Blue.WithAlpha(.5);
poly2.LineColor = Colors.Black;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


