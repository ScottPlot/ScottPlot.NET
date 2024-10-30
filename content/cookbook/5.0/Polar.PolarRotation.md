---
Title: Polar Axis Rotation - ScottPlot 5.0 Cookbook
Description: A polar axis may be rotated to define the angle of the 0 degree spoke.
URL: /cookbook/5.0/Polar/PolarRotation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis Rotation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Polar", "/cookbook/5.0/Polar/PolarRotation"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Polar/PolarRotation'>Polar Axis Rotation</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Polar/PolarRotation">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Polar">Category: Polar Axis</a>
</div>

A polar axis may be rotated to define the angle of the 0 degree spoke.

[![](/cookbook/5.0/images/PolarRotation.png?241029205813)](/cookbook/5.0/images/PolarRotation.png?241029205813)

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


