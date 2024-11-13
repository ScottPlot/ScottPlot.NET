---
Title: Marker with Colormap - ScottPlot 5.0 Cookbook
Description: A colormap may be used to style a collection of markers
URL: /cookbook/5.0/Marker/MarkersColormap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker", "Marker with Colormap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker", "/cookbook/5.0/Marker/MarkersColormap"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Marker with Colormap</h1>
</div>

A colormap may be used to style a collection of markers

[![](/cookbook/5.0/images/MarkersColormap.png?241112193154)](/cookbook/5.0/images/MarkersColormap.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5.0/images/MarkersColormap.png?241112193154" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var markers = myPlot.Add.Markers(xs, ys);
markers.Colormap = new ScottPlot.Colormaps.MellowRainbow();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Marker'>Marker</a> category</div>


