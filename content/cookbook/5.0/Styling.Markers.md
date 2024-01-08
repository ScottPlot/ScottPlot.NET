---
Title: Markers - ScottPlot 5.0 Cookbook
Description: Many plot types have a MarkerStyle which can be customized.
URL: /cookbook/5.0/Styling/Markers/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Markers"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/Markers"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Markers



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Many plot types have a MarkerStyle which can be customized.

[![](/cookbook/5.0/images/Markers.png)](/cookbook/5.0/images/Markers.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

MarkerShape[] markerShapes = Enum.GetValues<MarkerShape>().ToArray();

for (int i = 0; i < markerShapes.Length; i++)
{
    double[] xs = Generate.Consecutive(20);
    double[] ys = Generate.Sin(20, offset: markerShapes.Length - i);
    var scatter = myPlot.Add.Scatter(xs, ys);
    scatter.MarkerStyle.Shape = markerShapes[i];
    scatter.MarkerStyle.Size = 10;
}

myPlot.SavePng("demo.png");

```

