---
Title: Clockwise Polar Axis - ScottPlot 5.0 Cookbook
Description: Clockwise polar plots are common for representing spatial orientation.
URL: /cookbook/5.0/PolarAxis/PolarClockwise/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Clockwise Polar Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PolarAxis", "/cookbook/5.0/PolarAxis/PolarClockwise"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Clockwise Polar Axis</h1>
</div>

Clockwise polar plots are common for representing spatial orientation.

[![](/cookbook/5.0/images/PolarClockwise.png?250822231048)](/cookbook/5.0/images/PolarClockwise.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5.0/images/PolarClockwise.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();
polarAxis.Clockwise = true;
polarAxis.Rotation = Angle.FromDegrees(-90); // direction will be counter-clockwise

IColormap colormap = new ScottPlot.Colormaps.Turbo();
foreach (double degrees in ScottPlot.Generate.Range(0, 360, 10))
{
    double fraction = degrees / 360.0;
    Coordinates pt = polarAxis.GetCoordinates(fraction, degrees);
    var marker = myPlot.Add.Marker(pt);
    marker.Color = colormap.GetColor(fraction);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/PolarAxis'>Polar Axis</a> category</div>


