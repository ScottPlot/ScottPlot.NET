---
Title: Heatmap with Manual Color Range - ScottPlot 5.0 Cookbook
Description: The user can define the range of values to represent with colors in the colormap. Values outside that range will be clipped to the nearest color in the colormap.
URL: /cookbook/5.0/Heatmap/HeatmapManualRange/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Heatmap with Manual Color Range"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapManualRange"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Heatmap with Manual Color Range</h1>
</div>

The user can define the range of values to represent with colors in the colormap. Values outside that range will be clipped to the nearest color in the colormap.

[![](/cookbook/5.0/images/HeatmapManualRange.png?250126165944)](/cookbook/5.0/images/HeatmapManualRange.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapManualRange.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


