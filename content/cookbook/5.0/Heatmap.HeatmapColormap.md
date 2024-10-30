---
Title: Heatmap with custom Colormap - ScottPlot 5.0 Cookbook
Description: A heatmap's Colormap is the logic used to convert from cell value to cell color and they can set by the user. ScottPlot comes with many common colormaps, but users may implement IColormap and apply their own. A colorbar can be added to indicate which colors map to which values.
URL: /cookbook/5.0/Heatmap/HeatmapColormap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Heatmap with custom Colormap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapColormap"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Heatmap/HeatmapColormap'>Heatmap with custom Colormap</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Heatmap/HeatmapColormap">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Heatmap">Category: Heatmap</a>
</div>

A heatmap's Colormap is the logic used to convert from cell value to cell color and they can set by the user. ScottPlot comes with many common colormaps, but users may implement IColormap and apply their own. A colorbar can be added to indicate which colors map to which values.

[![](/cookbook/5.0/images/HeatmapColormap.png?241029205813)](/cookbook/5.0/images/HeatmapColormap.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm1 = myPlot.Add.Heatmap(data);
hm1.Colormap = new ScottPlot.Colormaps.Turbo();

myPlot.Add.ColorBar(hm1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


