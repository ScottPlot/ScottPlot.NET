---
Title: Smooth Heatmap - ScottPlot 5.0 Cookbook
Description: Enable the `Smooth` property for anti-aliased rendering
URL: /cookbook/5.0/Heatmap/HeatmapSmooth/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Smooth Heatmap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapSmooth"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Heatmap/HeatmapSmooth'>Smooth Heatmap</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Heatmap/HeatmapSmooth">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Heatmap">Category: Heatmap</a>
</div>

Enable the `Smooth` property for anti-aliased rendering

[![](/cookbook/5.0/images/HeatmapSmooth.png?241029205813)](/cookbook/5.0/images/HeatmapSmooth.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

myPlot.Add.Text("Smooth = false", 0, 1.1);
var hm1 = myPlot.Add.Heatmap(data);
hm1.Position = new CoordinateRect(0, 1, 0, 1);

myPlot.Add.Text("Smooth = true", 1.1, 1.1);
var hm2 = myPlot.Add.Heatmap(data);
hm2.Position = new CoordinateRect(1.1, 2.1, 0, 1);
hm2.Smooth = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


