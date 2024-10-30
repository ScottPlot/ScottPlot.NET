---
Title: Marker with Colormap - ScottPlot 5.0 Cookbook
Description: A colormap may be used to style a collection of markers
URL: /cookbook/5.0/Marker/MarkersColormap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker", "Marker with Colormap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker", "/cookbook/5.0/Marker/MarkersColormap"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Marker/MarkersColormap'>Marker with Colormap</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Marker/MarkersColormap">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Marker">Category: Marker</a>
</div>

A colormap may be used to style a collection of markers

[![](/cookbook/5.0/images/MarkersColormap.png?241029205813)](/cookbook/5.0/images/MarkersColormap.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var markers = myPlot.Add.Markers(xs, ys);
markers.Colormap = new ScottPlot.Colormaps.MellowRainbow();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


