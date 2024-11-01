---
Title: Polar Axis Rotation - ScottPlot 5.0 Cookbook
Description: A polar axis may be rotated to define the angle of the 0 degree spoke.
URL: /cookbook/5.0/Polar/PolarRotation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis Rotation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Polar", "/cookbook/5.0/Polar/PolarRotation"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Rotation</h1>
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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Polar'>Polar Axis</a> category</div>


