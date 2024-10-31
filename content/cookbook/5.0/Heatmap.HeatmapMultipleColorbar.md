---
Title: Multiple Colorbars - ScottPlot 5.0 Cookbook
Description: Multiple colorbars may be added to plots.
URL: /cookbook/5.0/Heatmap/HeatmapMultipleColorbar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Multiple Colorbars"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapMultipleColorbar"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Heatmap/HeatmapMultipleColorbar'>Multiple Colorbars</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Heatmap/HeatmapMultipleColorbar">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Heatmap">Category: Heatmap</a>
</div>

Multiple colorbars may be added to plots.

[![](/cookbook/5.0/images/HeatmapMultipleColorbar.png?241031194635)](/cookbook/5.0/images/HeatmapMultipleColorbar.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm1 = myPlot.Add.Heatmap(data);
hm1.Extent = new(0, 1, 0, 1);
hm1.Colormap = new ScottPlot.Colormaps.Turbo();
myPlot.Add.ColorBar(hm1);

var hm2 = myPlot.Add.Heatmap(data);
hm2.Extent = new(1.5, 2.5, 0, 1);
hm2.Colormap = new ScottPlot.Colormaps.Viridis();
myPlot.Add.ColorBar(hm2);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


