---
Title: Heatmap Cell Size - ScottPlot 5.0 Cookbook
Description: Dimensions of a heatmap may be set by specifying how large a cell should be in pixel units.
URL: /cookbook/5.0/Heatmap/HeatmapCellSize/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Heatmap Cell Size"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapCellSize"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Heatmap Cell Size</h1>
</div>

Dimensions of a heatmap may be set by specifying how large a cell should be in pixel units.

[![](/cookbook/5.0/images/HeatmapCellSize.png?241117162641)](/cookbook/5.0/images/HeatmapCellSize.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapCellSize.png?241117162641" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


