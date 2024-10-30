---
Title: Polar Axis - ScottPlot 5.0 Cookbook
Description: A polar axis can be added to the plot, then other plot types (marker, line, scatter, etc.) can be placed on top of it using ints helper methods to translate polar coordinates to Cartesian units.
URL: /cookbook/5.0/Polar/PolarQuickStart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Polar", "/cookbook/5.0/Polar/PolarQuickStart"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Polar/PolarQuickStart'>Polar Axis</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Polar/PolarQuickStart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Polar">Category: Polar Axis</a>
</div>

A polar axis can be added to the plot, then other plot types (marker, line, scatter, etc.) can be placed on top of it using ints helper methods to translate polar coordinates to Cartesian units.

[![](/cookbook/5.0/images/PolarQuickStart.png?241029205813)](/cookbook/5.0/images/PolarQuickStart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


