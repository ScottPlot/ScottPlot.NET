---
Title: Polar Axis - ScottPlot 5 Cookbook
Description: A polar axis can be added to the plot, then other plot types (marker, line, scatter, etc.) can be placed on top of it using its helper methods to translate polar coordinates to Cartesian units.
URL: /cookbook/5/PolarAxis/PolarQuickStart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Polar Axis", "Polar Axis"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/PolarAxis", "/cookbook/5/PolarAxis/PolarQuickStart"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis</h1>
</div>

A polar axis can be added to the plot, then other plot types (marker, line, scatter, etc.) can be placed on top of it using its helper methods to translate polar coordinates to Cartesian units.

[![](/cookbook/5/images/PolarQuickStart.png?251011113742)](/cookbook/5/images/PolarQuickStart.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5/images/PolarQuickStart.png?251011113742" >}}ScottPlot.Plot myPlot = new();

// add a polar axis to the plot
var polarAxis = myPlot.Add.PolarAxis();

IColormap colormap = new ScottPlot.Colormaps.Turbo();
foreach (double degrees in ScottPlot.Generate.Range(0, 360, 10))
{
    // use the polar axis to get X/Y coordinates given a position in polar space
    double radius = degrees / 360.0;
    Coordinates pt = polarAxis.GetCoordinates(radius, degrees);

    // place markers or other plot types using X/Y coordinates like normal
    var marker = myPlot.Add.Marker(pt);
    marker.Color = colormap.GetColor(radius);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/PolarAxis'>Polar Axis</a> category</div>


