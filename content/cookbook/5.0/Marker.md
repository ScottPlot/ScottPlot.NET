---
Title: Marker - ScottPlot 5.0 Cookbook
Description: Markers can be placed on the plot in coordinate space.
URL: /cookbook/5.0/Marker/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker"]
Date: 2024-01-09
Version: ScottPlot 5.0.12-beta
Version: ScottPlot 5.0.12-beta
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Marker



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.12-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



<h2><a href='/cookbook/5.0/Marker/MarkerQuickstart'>Marker Quickstart</a></h2>

Markers are symbols placed at a location in coordinate space. Their shape, size, and color can be customized.

[![](/cookbook/5.0/images/MarkerQuickstart.png)](/cookbook/5.0/images/MarkerQuickstart.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 12);
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Marker(25, .5);
myPlot.Add.Marker(35, .6);
myPlot.Add.Marker(45, .7);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Marker/MarkerShapes'>Marker Shapes</a></h2>

Many marker shapes are available.

[![](/cookbook/5.0/images/MarkerShapes.png)](/cookbook/5.0/images/MarkerShapes.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 12);
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

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Marker/MarkerLegend'>Marker Legend</a></h2>

Markers with labels appear in the legend.

[![](/cookbook/5.0/images/MarkerLegend.png)](/cookbook/5.0/images/MarkerLegend.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 12);
ScottPlot.Plot myPlot = new();

var sin = myPlot.Add.Signal(Generate.Sin());
var cos = myPlot.Add.Signal(Generate.Cos());
var marker = myPlot.Add.Marker(25, .5);

sin.Label = "Sine";
cos.Label = "Cosine";
marker.Label = "Marker";
myPlot.ShowLegend();

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>

