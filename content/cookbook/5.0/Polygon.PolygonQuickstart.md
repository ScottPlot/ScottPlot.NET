---
Title: Polygon Plot Quickstart - ScottPlot 5.0 Cookbook
Description: Polygon plots can be added from a series of vertices, and must be in clockwise order.
URL: /cookbook/5.0/Polygon/PolygonQuickstart
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polygon Plot", "Polygon Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Polygon", "/cookbook/5.0/Polygon/PolygonQuickstart"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Polygon Plot Quickstart



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Polygon plots can be added from a series of vertices, and must be in clockwise order.

[![](/cookbook/5.0/images/PolygonQuickstart.png)](/cookbook/5.0/images/PolygonQuickstart.png)

```cs
ScottPlot.Plot myPlot = new();

Coordinates[] vertices = new Coordinates[]
{
    new Coordinates(0,   0.25),
    new Coordinates(0.3, 0.75),
    new Coordinates(1,   1),
    new Coordinates(0.7, 0.5),
    new Coordinates(1,   0)
};
myPlot.Add.Polygon(vertices);
myPlot.AutoScale();

myPlot.SavePng("demo.png");

```

