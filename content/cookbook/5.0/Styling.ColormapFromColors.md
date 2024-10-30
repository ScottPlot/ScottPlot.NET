---
Title: Colormap Gradient from Colors - ScottPlot 5.0 Cookbook
Description: Colormaps can be created as a gradient between a collection of colors.
URL: /cookbook/5.0/Styling/ColormapFromColors/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Colormap Gradient from Colors"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/ColormapFromColors"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Styling/ColormapFromColors'>Colormap Gradient from Colors</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Styling/ColormapFromColors">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Styling">Category: Styling Plots</a>
</div>

Colormaps can be created as a gradient between a collection of colors.

[![](/cookbook/5.0/images/ColormapFromColors.png?241029205813)](/cookbook/5.0/images/ColormapFromColors.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

Color[] colors = [Colors.Red, Colors.Magenta, Colors.DarkGreen];
IColormap myColormap = Colormap.FromColors(colors);

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);
var markers = myPlot.Add.Markers(xs, ys);
markers.Colormap = myColormap;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


