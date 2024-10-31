---
Title: Heatmap Quickstart - ScottPlot 5.0 Cookbook
Description: Heatmaps can be created from 2D arrays
URL: /cookbook/5.0/Heatmap/HeatmapQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Heatmap Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Heatmap/HeatmapQuickstart'>Heatmap Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Heatmap/HeatmapQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Heatmap">Category: Heatmap</a>
</div>

Heatmaps can be created from 2D arrays

[![](/cookbook/5.0/images/HeatmapQuickstart.png?241031194635)](/cookbook/5.0/images/HeatmapQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();
myPlot.Add.Heatmap(data);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


