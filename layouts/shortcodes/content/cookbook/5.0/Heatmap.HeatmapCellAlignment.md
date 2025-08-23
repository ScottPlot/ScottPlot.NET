---
Title: HeatmapCellAlignment - ScottPlot 5.0 Cookbook
Description: Heatmap cells are aligned in their centers by default. This means that the bottom left cell will be centered at (0, 0), and its lower left corner will be to the lower left of the origin. Setting sell alignment to lower left causes the lower left of the heatmap to be exactly at (0, 0).
URL: /cookbook/5.0/Heatmap/HeatmapCellAlignment/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "HeatmapCellAlignment"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapCellAlignment"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>HeatmapCellAlignment</h1>
</div>

Heatmap cells are aligned in their centers by default. This means that the bottom left cell will be centered at (0, 0), and its lower left corner will be to the lower left of the origin. Setting sell alignment to lower left causes the lower left of the heatmap to be exactly at (0, 0).

[![](/cookbook/5.0/images/HeatmapCellAlignment.png?250822231048)](/cookbook/5.0/images/HeatmapCellAlignment.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapCellAlignment.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[,] data = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
};

var hm = myPlot.Add.Heatmap(data);
hm.CellAlignment = Alignment.LowerLeft;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


