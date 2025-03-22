---
Title: Heatmap with Transparent Colormap - ScottPlot 5.0 Cookbook
Description: Custom colormaps may include transparency.
URL: /cookbook/5.0/Heatmap/HeatmapColormapTransparent/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Heatmap with Transparent Colormap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapColormapTransparent"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Heatmap with Transparent Colormap</h1>
</div>

Custom colormaps may include transparency.

[![](/cookbook/5.0/images/HeatmapColormapTransparent.png?250322130304)](/cookbook/5.0/images/HeatmapColormapTransparent.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapColormapTransparent.png?250322130304" >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();
var hm1 = myPlot.Add.Heatmap(data);

Color[] colors = [Colors.Navy, Colors.Transparent, Colors.Orange];
hm1.Colormap = new ScottPlot.Colormaps.CustomInterpolated(colors);

myPlot.Add.ColorBar(hm1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


