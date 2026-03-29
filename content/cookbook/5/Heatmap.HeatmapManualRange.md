---
Title: Heatmap with Manual Color Range - ScottPlot 5 Cookbook
Description: The user can define the range of values to represent with colors in the colormap. Values outside that range will be clipped to the nearest color in the colormap.
URL: /cookbook/5/Heatmap/HeatmapManualRange/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Heatmap", "Heatmap with Manual Color Range"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Heatmap", "/cookbook/5/Heatmap/HeatmapManualRange"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Heatmap with Manual Color Range</h1>
</div>

The user can define the range of values to represent with colors in the colormap. Values outside that range will be clipped to the nearest color in the colormap.

[![](/cookbook/5/images/HeatmapManualRange.png?260329072039)](/cookbook/5/images/HeatmapManualRange.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5/images/HeatmapManualRange.png?260329072039" >}}ScottPlot.Plot myPlot = new();

// sample data values range from 0-255
double[,] data = SampleData.MonaLisa();

// add a heatmap and colorbar to the plot
var hm = myPlot.Add.Heatmap(data);
hm.Colormap = new ScottPlot.Colormaps.Turbo();
myPlot.Add.ColorBar(hm);

// force the colormap to span a manual range of values
hm.ManualRange = new(50, 150);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Heatmap'>Heatmap</a> category</div>


