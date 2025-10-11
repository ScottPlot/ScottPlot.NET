---
Title: Clockwise Polar Axis - ScottPlot 5 Cookbook
Description: Clockwise polar plots are common for representing spatial orientation.
URL: /cookbook/5/PolarAxis/PolarClockwise/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Polar Axis", "Clockwise Polar Axis"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/PolarAxis", "/cookbook/5/PolarAxis/PolarClockwise"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Clockwise Polar Axis</h1>
</div>

Clockwise polar plots are common for representing spatial orientation.

[![](/cookbook/5/images/PolarClockwise.png?251011113742)](/cookbook/5/images/PolarClockwise.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5/images/PolarClockwise.png?251011113742" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/PolarAxis'>Polar Axis</a> category</div>


