---
Title: Heatmap Quickstart - ScottPlot 5 Cookbook
Description: Heatmaps can be created from 2D arrays
URL: /cookbook/5/Heatmap/HeatmapQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Heatmap", "Heatmap Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Heatmap", "/cookbook/5/Heatmap/HeatmapQuickstart"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Heatmap Quickstart</h1>
</div>

Heatmaps can be created from 2D arrays

[![](/cookbook/5/images/HeatmapQuickstart.png?260329072039)](/cookbook/5/images/HeatmapQuickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5/images/HeatmapQuickstart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();
myPlot.Add.Heatmap(data);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Heatmap'>Heatmap</a> category</div>


