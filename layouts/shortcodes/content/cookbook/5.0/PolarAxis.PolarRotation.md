---
Title: Polar Axis Rotation - ScottPlot 5.0 Cookbook
Description: A polar axis may be rotated to define the angle of the 0 degree spoke.
URL: /cookbook/5.0/PolarAxis/PolarRotation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis Rotation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PolarAxis", "/cookbook/5.0/PolarAxis/PolarRotation"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Rotation</h1>
</div>

A polar axis may be rotated to define the angle of the 0 degree spoke.

[![](/cookbook/5.0/images/PolarRotation.png?250822231048)](/cookbook/5.0/images/PolarRotation.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5.0/images/PolarRotation.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();
polarAxis.Rotation = Angle.FromDegrees(90); // default direction is counter-clockwise

IColormap colormap = new ScottPlot.Colormaps.Turbo();
foreach (double degrees in ScottPlot.Generate.Range(0, 360, 10))
{
    double radius = degrees / 360.0;
    Coordinates pt = polarAxis.GetCoordinates(radius, degrees);

    var marker = myPlot.Add.Marker(pt);
    marker.Color = colormap.GetColor(radius);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/PolarAxis'>Polar Axis</a> category</div>


