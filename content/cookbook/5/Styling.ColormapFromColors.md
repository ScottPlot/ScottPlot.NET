---
Title: Colormap Gradient from Colors - ScottPlot 5 Cookbook
Description: Colormaps can be created as a gradient between a collection of colors.
URL: /cookbook/5/Styling/ColormapFromColors/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Styling Plots", "Colormap Gradient from Colors"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Styling", "/cookbook/5/Styling/ColormapFromColors"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Colormap Gradient from Colors</h1>
</div>

Colormaps can be created as a gradient between a collection of colors.

[![](/cookbook/5/images/ColormapFromColors.png?251011113742)](/cookbook/5/images/ColormapFromColors.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5/images/ColormapFromColors.png?251011113742" >}}ScottPlot.Plot myPlot = new();

Color[] colors = [Colors.Red, Colors.Magenta, Colors.DarkGreen];
IColormap myColormap = Colormap.FromColors(colors);

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);
var markers = myPlot.Add.Markers(xs, ys);
markers.Colormap = myColormap;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Styling'>Styling Plots</a> category</div>


