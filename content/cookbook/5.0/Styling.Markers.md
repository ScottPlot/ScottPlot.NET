---
Title: Markers - ScottPlot 5.0 Cookbook
Description: Many plot types have a MarkerStyle which can be customized.
URL: /cookbook/5.0/Styling/Markers
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Markers"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/Markers"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Markers



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Many plot types have a MarkerStyle which can be customized.

[![](/cookbook/5.0/images/Markers.png)](/cookbook/5.0/images/Markers.png)

```cs
ScottPlot.Plot myPlot = new();

int count = 21;
double[] xs = ScottPlot.Generate.Consecutive(count);
double[] ys = ScottPlot.Generate.Sin(count);

MarkerShape[] markerShapes = Enum.GetValues<MarkerShape>().ToArray();

for (int i = 0; i < markerShapes.Length; i++)
{
    double[] data = ys.Select(y => markerShapes.Length - y + i).ToArray();

    var scatter = myPlot.Add.Scatter(xs, data);

    scatter.Label = markerShapes[i].ToString();

    scatter.MarkerStyle = new MarkerStyle(
        shape: markerShapes[i],
        size: 10,
        color: scatter.LineStyle.Color);
}

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png");

```

