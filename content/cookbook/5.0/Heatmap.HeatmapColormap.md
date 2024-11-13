---
Title: Heatmap with custom Colormap - ScottPlot 5.0 Cookbook
Description: A heatmap's Colormap is the logic used to convert from cell value to cell color and they can set by the user. ScottPlot comes with many common colormaps, but users may implement IColormap and apply their own. A colorbar can be added to indicate which colors map to which values.
URL: /cookbook/5.0/Heatmap/HeatmapColormap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Heatmap with custom Colormap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapColormap"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Heatmap with custom Colormap</h1>
</div>

A heatmap's Colormap is the logic used to convert from cell value to cell color and they can set by the user. ScottPlot comes with many common colormaps, but users may implement IColormap and apply their own. A colorbar can be added to indicate which colors map to which values.

[![](/cookbook/5.0/images/HeatmapColormap.png?241112193154)](/cookbook/5.0/images/HeatmapColormap.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapColormap.png?241112193154" >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm1 = myPlot.Add.Heatmap(data);
hm1.Colormap = new ScottPlot.Colormaps.Turbo();

myPlot.Add.ColorBar(hm1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


