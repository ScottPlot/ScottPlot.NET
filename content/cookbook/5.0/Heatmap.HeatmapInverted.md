---
Title: Inverted Heatmap - ScottPlot 5.0 Cookbook
Description: Heatmaps can be inverted by reversing the order of colors in the colormap
URL: /cookbook/5.0/Heatmap/HeatmapInverted/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Inverted Heatmap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapInverted"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Heatmap/HeatmapInverted'>Inverted Heatmap</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Heatmap/HeatmapInverted">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Heatmap">Category: Heatmap</a>
</div>

Heatmaps can be inverted by reversing the order of colors in the colormap

[![](/cookbook/5.0/images/HeatmapInverted.png?241031194635)](/cookbook/5.0/images/HeatmapInverted.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm1 = myPlot.Add.Heatmap(data);
hm1.Colormap = new ScottPlot.Colormaps.Viridis();
hm1.Position = new(0, 65, 0, 100);

var hm2 = myPlot.Add.Heatmap(data);
hm2.Colormap = new ScottPlot.Colormaps.Viridis().Reversed();
hm2.Position = new(100, 165, 0, 100);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


