---
Title: Marker Shapes - ScottPlot 5.0 Cookbook
Description: Many marker shapes are available.
URL: /cookbook/5.0/Marker/MarkerShapes/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker", "Marker Shapes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker", "/cookbook/5.0/Marker/MarkerShapes"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Marker Shapes



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Many marker shapes are available.

[![](/cookbook/5.0/images/MarkerShapes.png)](/cookbook/5.0/images/MarkerShapes.png)

```cs
ScottPlot.Plot myPlot = new();

ScottPlot.Colormaps.Turbo colormap = new();

for (int i = 0; i < 100; i++)
{
    MarkerShape shape = Generate.RandomMarkerShape();
    Coordinates location = Generate.RandomCoordinates();
    float size = Generate.RandomInteger(5, 10);
    Color color = Generate.RandomColor(colormap);

    myPlot.Add.Marker(location, shape, size, color);
}

myPlot.SavePng("demo.png");

```

