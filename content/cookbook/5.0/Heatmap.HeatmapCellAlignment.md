---
Title: HeatmapCellAlignment - ScottPlot 5.0 Cookbook
Description: Heatmap cells are aligned in their centers by default. This means that the bottom left cell will be centered at (0, 0), and its lower left corner will be to the lower left of the origin. Setting sell alignment to lower left causes the lower left of the heatmap to be exactly at (0, 0).
URL: /cookbook/5.0/Heatmap/HeatmapCellAlignment/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "HeatmapCellAlignment"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapCellAlignment"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Heatmap/HeatmapCellAlignment'>HeatmapCellAlignment</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Heatmap/HeatmapCellAlignment">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Heatmap">Category: Heatmap</a>
</div>

Heatmap cells are aligned in their centers by default. This means that the bottom left cell will be centered at (0, 0), and its lower left corner will be to the lower left of the origin. Setting sell alignment to lower left causes the lower left of the heatmap to be exactly at (0, 0).

[![](/cookbook/5.0/images/HeatmapCellAlignment.png?241029205813)](/cookbook/5.0/images/HeatmapCellAlignment.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] data = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
};

var hm = myPlot.Add.Heatmap(data);
hm.CellAlignment = Alignment.LowerLeft;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


