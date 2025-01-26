---
Title: Ellipse - ScottPlot 5.0 Cookbook
Description: Ellipses are curves with a defined center and distinct X and Y radii. A circle is an ellipse with an X radius equal to its Y radius.
URL: /cookbook/5.0/Ellipse/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Ellipse"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Ellipse"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Ellipse</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Ellipse Quickstart</h1>
<a href='/cookbook/5.0/Ellipse/PlotEllipseQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Ellipses can be added to plots

[![](/cookbook/5.0/images/PlotEllipseQuickstart.png?250126165944)](/cookbook/5.0/images/PlotEllipseQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Ellipse.cs" imageUrl="/cookbook/5.0/images/PlotEllipseQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

Random rand = new(0);
for (int i = 0; i &lt; 5; i++)
{
    myPlot.Add.Ellipse(
        xCenter: rand.Next(-10, 10),
        yCenter: rand.Next(-10, 10),
        radiusX: rand.Next(1, 7),
        radiusY: rand.Next(1, 7));
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Circle Quickstart</h1>
<a href='/cookbook/5.0/Ellipse/PlotCircleQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Circles can be added to plots. Circles are really Ellipses with the same X and Y radius. Note that circles appear as ellipses unless the plot has a square coordinate system.

[![](/cookbook/5.0/images/PlotCircleQuickstart.png?250126165944)](/cookbook/5.0/images/PlotCircleQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Ellipse.cs" imageUrl="/cookbook/5.0/images/PlotCircleQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

Random rand = new(0);
for (int i = 0; i &lt; 5; i++)
{
    myPlot.Add.Circle(
        xCenter: rand.Next(-10, 10),
        yCenter: rand.Next(-10, 10),
        radius: rand.Next(1, 7));
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Circle with Locked Scale</h1>
<a href='/cookbook/5.0/Ellipse/CircleWithLockedScale' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

For circles to always appear circular, the coordinate system must be forced to always display square-shaped pixels. This can be achieved by enabling the axis scale lock.

[![](/cookbook/5.0/images/CircleWithLockedScale.png?250126165944)](/cookbook/5.0/images/CircleWithLockedScale.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Ellipse.cs" imageUrl="/cookbook/5.0/images/CircleWithLockedScale.png?250126165944" >}}ScottPlot.Plot myPlot = new();

Random rand = new(0);
for (int i = 0; i &lt; 5; i++)
{
    myPlot.Add.Circle(
        xCenter: rand.Next(-10, 10),
        yCenter: rand.Next(-10, 10),
        radius: rand.Next(1, 7));
}

// force pixels to have a 1:1 scale ratio
myPlot.Axes.SquareUnits();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Ellipse Styling</h1>
<a href='/cookbook/5.0/Ellipse/EllipseStyling' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Ellipses styles can be extensively customized

[![](/cookbook/5.0/images/EllipseStyling.png?250126165944)](/cookbook/5.0/images/EllipseStyling.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Ellipse.cs" imageUrl="/cookbook/5.0/images/EllipseStyling.png?250126165944" >}}ScottPlot.Plot myPlot = new();

var circle = myPlot.Add.Circle(center: Coordinates.Origin, radius: 5);
circle.LineStyle.Width = 5;
circle.LineStyle.Pattern = LinePattern.Dashed;
circle.LineStyle.Color = Colors.Green;
circle.FillStyle.Color = Colors.Navy;
circle.FillStyle.HatchColor = Colors.Red;
circle.FillStyle.Hatch = new ScottPlot.Hatches.Striped();

myPlot.Axes.SetLimits(-10, 10, -10, 10);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Ellipse Rotation</h1>
<a href='/cookbook/5.0/Ellipse/EllipseRotation' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Ellipses can also be rotated

[![](/cookbook/5.0/images/EllipseRotation.png?250126165944)](/cookbook/5.0/images/EllipseRotation.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Ellipse.cs" imageUrl="/cookbook/5.0/images/EllipseRotation.png?250126165944" >}}ScottPlot.Plot myPlot = new();

Coordinates center = new(0, 0);
double radiusX = 1;
double radiusY = 5;

for (int i = 0; i &lt; 5; i++)
{
    Angle angle = Angle.FromDegrees(i * 20);
    var el = myPlot.Add.Ellipse(center, radiusX, radiusY, angle);
    el.LineWidth = 3;
    el.LineColor = Colors.Blue.WithAlpha(0.1 + 0.2 * i);
}

// force pixels to have a 1:1 scale ratio
ScottPlot.AxisRules.SquareZoomOut rule = new(myPlot.Axes.Bottom, myPlot.Axes.Left);
myPlot.Axes.Rules.Add(rule);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


