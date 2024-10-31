---
Title: Ellipse Rotation - ScottPlot 5.0 Cookbook
Description: Ellipses can also be rotated
URL: /cookbook/5.0/Ellipse/EllipseRotation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Ellipse", "Ellipse Rotation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Ellipse", "/cookbook/5.0/Ellipse/EllipseRotation"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Ellipse/EllipseRotation'>Ellipse Rotation</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Ellipse/EllipseRotation">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Ellipse">Category: Ellipse</a>
</div>

Ellipses can also be rotated

[![](/cookbook/5.0/images/EllipseRotation.png?241031194635)](/cookbook/5.0/images/EllipseRotation.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


