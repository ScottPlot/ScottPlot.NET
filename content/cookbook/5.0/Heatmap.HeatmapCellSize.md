---
Title: Heatmap Cell Size - ScottPlot 5.0 Cookbook
Description: Dimensions of a heatmap may be set by specifying how large a cell should be in pixel units.
URL: /cookbook/5.0/Heatmap/HeatmapCellSize/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Heatmap Cell Size"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapCellSize"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Heatmap/HeatmapCellSize'>Heatmap Cell Size</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Heatmap/HeatmapCellSize">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Heatmap">Category: Heatmap</a>
</div>

Dimensions of a heatmap may be set by specifying how large a cell should be in pixel units.

[![](/cookbook/5.0/images/HeatmapCellSize.png?241029205813)](/cookbook/5.0/images/HeatmapCellSize.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] data = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
};

var hm = myPlot.Add.Heatmap(data);
hm.CellAlignment = Alignment.LowerLeft;
hm.CellWidth = 100;
hm.CellHeight = 10;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


