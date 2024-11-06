---
Title: Polar Axis - ScottPlot 5.0 Cookbook
Description: A polar axis can be added to the plot, then other plot types (marker, line, scatter, etc.) can be placed on top of it using its helper methods to translate polar coordinates to Cartesian units.
URL: /cookbook/5.0/PolarAxis/PolarQuickStart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PolarAxis", "/cookbook/5.0/PolarAxis/PolarQuickStart"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis</h1>
</div>

A polar axis can be added to the plot, then other plot types (marker, line, scatter, etc.) can be placed on top of it using its helper methods to translate polar coordinates to Cartesian units.

[![](/cookbook/5.0/images/PolarQuickStart.png?241105214550)](/cookbook/5.0/images/PolarQuickStart.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5.0/images/PolarQuickStart.png?241105214550" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/PolarAxis'>Polar Axis</a> category</div>


