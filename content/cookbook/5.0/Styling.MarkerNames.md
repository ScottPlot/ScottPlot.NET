---
Title: Marker Names - ScottPlot 5.0 Cookbook
Description: Markers can be referred to by their name.
URL: /cookbook/5.0/Styling/MarkerNames/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Marker Names"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/MarkerNames"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Marker Names



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Markers can be referred to by their name.

[![](/cookbook/5.0/images/MarkerNames.png)](/cookbook/5.0/images/MarkerNames.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

MarkerShape[] markerShapes = Enum.GetValues<MarkerShape>().ToArray();

for (int i = 0; i < markerShapes.Length; i++)
{
    var mp = myPlot.Add.Marker(x: i, y: 0);
    mp.MarkerStyle.Shape = markerShapes[i];
    mp.MarkerStyle.Size = 10;

    var txt = myPlot.Add.Text(markerShapes[i].ToString(), i, 0.15);
    txt.Label.Rotation = -90;
    txt.Label.Alignment = Alignment.MiddleLeft;
}

myPlot.Title("Marker Names");
myPlot.Axes.SetLimits(-1, markerShapes.Length, -1, 4);
myPlot.HideGrid();

myPlot.SavePng("demo.png");

```

