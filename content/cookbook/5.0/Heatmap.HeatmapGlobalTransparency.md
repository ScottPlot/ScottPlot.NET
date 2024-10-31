---
Title: Global Transparency - ScottPlot 5.0 Cookbook
Description: The transparency of the entire heatmap can be adjusted.
URL: /cookbook/5.0/Heatmap/HeatmapGlobalTransparency/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Global Transparency"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapGlobalTransparency"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Heatmap/HeatmapGlobalTransparency'>Global Transparency</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Heatmap/HeatmapGlobalTransparency">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Heatmap">Category: Heatmap</a>
</div>

The transparency of the entire heatmap can be adjusted.

[![](/cookbook/5.0/images/HeatmapGlobalTransparency.png?241031194635)](/cookbook/5.0/images/HeatmapGlobalTransparency.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

// create a line chart
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// plot the heatmap on top of the line chart
var hm = myPlot.Add.Heatmap(data);
hm.Position = new(10, 35, -1.5, .5);
hm.Opacity = 0.5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


