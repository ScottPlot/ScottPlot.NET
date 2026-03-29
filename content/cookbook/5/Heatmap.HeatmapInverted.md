---
Title: Inverted Heatmap - ScottPlot 5 Cookbook
Description: Heatmaps can be inverted by reversing the order of colors in the colormap
URL: /cookbook/5/Heatmap/HeatmapInverted/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Heatmap", "Inverted Heatmap"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Heatmap", "/cookbook/5/Heatmap/HeatmapInverted"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Inverted Heatmap</h1>
</div>

Heatmaps can be inverted by reversing the order of colors in the colormap

[![](/cookbook/5/images/HeatmapInverted.png?260329072039)](/cookbook/5/images/HeatmapInverted.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5/images/HeatmapInverted.png?260329072039" >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm1 = myPlot.Add.Heatmap(data);
hm1.Colormap = new ScottPlot.Colormaps.Viridis();
hm1.Position = new(0, 65, 0, 100);

var hm2 = myPlot.Add.Heatmap(data);
hm2.Colormap = new ScottPlot.Colormaps.Viridis().Reversed();
hm2.Position = new(100, 165, 0, 100);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Heatmap'>Heatmap</a> category</div>


