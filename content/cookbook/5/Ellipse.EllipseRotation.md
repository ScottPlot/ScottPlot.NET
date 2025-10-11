---
Title: Ellipse Rotation - ScottPlot 5.0 Cookbook
Description: Ellipses can also be rotated
URL: /cookbook/5.0/Ellipse/EllipseRotation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Ellipse", "Ellipse Rotation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Ellipse", "/cookbook/5.0/Ellipse/EllipseRotation"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Ellipse Rotation</h1>
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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Ellipse'>Ellipse</a> category</div>


