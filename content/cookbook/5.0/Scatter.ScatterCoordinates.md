---
Title: Scatter Plot Coordinates - ScottPlot 5.0 Cookbook
Description: Scatter plots can be created from a collection of Coordinates.
URL: /cookbook/5.0/Scatter/ScatterCoordinates/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot Coordinates"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterCoordinates"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Scatter Plot Coordinates



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Scatter plots can be created from a collection of Coordinates.

[![](/cookbook/5.0/images/ScatterCoordinates.png)](/cookbook/5.0/images/ScatterCoordinates.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

Coordinates[] coordinates =
{
    new(1, 1),
    new(2, 4),
    new(3, 9),
    new(4, 16),
    new(5, 25),
};

myPlot.Add.Scatter(coordinates);

myPlot.SavePng("demo.png");

```

