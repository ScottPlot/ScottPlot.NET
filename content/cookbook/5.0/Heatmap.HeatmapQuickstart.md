---
Title: Heatmap Quickstart - ScottPlot 5.0 Cookbook
Description: Heatmaps can be created from 2D arrays
URL: /cookbook/5.0/Heatmap/HeatmapQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Heatmap Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapQuickstart"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Heatmap Quickstart</h1>
</div>

Heatmaps can be created from 2D arrays

[![](/cookbook/5.0/images/HeatmapQuickstart.png?241103171511)](/cookbook/5.0/images/HeatmapQuickstart.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapQuickstart.png?241103171511" >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();
myPlot.Add.Heatmap(data);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


