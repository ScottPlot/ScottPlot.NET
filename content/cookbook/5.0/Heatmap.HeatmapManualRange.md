---
Title: Heatmap with Manual Color Range - ScottPlot 5.0 Cookbook
Description: The user can define the range of values to represent with colors in the colormap. Values outside that range will be clipped to the nearest color in the colormap.
URL: /cookbook/5.0/Heatmap/HeatmapManualRange/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Heatmap with Manual Color Range"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapManualRange"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Heatmap/HeatmapManualRange'>Heatmap with Manual Color Range</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Heatmap/HeatmapManualRange">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Heatmap">Category: Heatmap</a>
</div>

The user can define the range of values to represent with colors in the colormap. Values outside that range will be clipped to the nearest color in the colormap.

[![](/cookbook/5.0/images/HeatmapManualRange.png?241031194635)](/cookbook/5.0/images/HeatmapManualRange.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


