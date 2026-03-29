---
Title: Heatmap with Custom Colormap - ScottPlot 5 Cookbook
Description: A heatmap's Colormap is the logic used to convert from cell value to cell color and they can set by the user. ScottPlot comes with many common colormaps, but users may implement IColormap and apply their own. A colorbar can be added to indicate which colors map to which values.
URL: /cookbook/5/Heatmap/HeatmapColormap/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Heatmap", "Heatmap with Custom Colormap"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Heatmap", "/cookbook/5/Heatmap/HeatmapColormap"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Heatmap with Custom Colormap</h1>
</div>

A heatmap's Colormap is the logic used to convert from cell value to cell color and they can set by the user. ScottPlot comes with many common colormaps, but users may implement IColormap and apply their own. A colorbar can be added to indicate which colors map to which values.

[![](/cookbook/5/images/HeatmapColormap.png?260329072039)](/cookbook/5/images/HeatmapColormap.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5/images/HeatmapColormap.png?260329072039" >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm1 = myPlot.Add.Heatmap(data);
hm1.Colormap = new ScottPlot.Colormaps.Turbo();

myPlot.Add.ColorBar(hm1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Heatmap'>Heatmap</a> category</div>


