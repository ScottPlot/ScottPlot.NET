---
Title: Smooth Heatmap - ScottPlot 5.0 Cookbook
Description: Enable the `Smooth` property for anti-aliased rendering
URL: /cookbook/5.0/Heatmap/HeatmapSmooth/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Smooth Heatmap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapSmooth"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Smooth Heatmap</h1>
</div>

Enable the `Smooth` property for anti-aliased rendering

[![](/cookbook/5.0/images/HeatmapSmooth.png?250126165944)](/cookbook/5.0/images/HeatmapSmooth.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapSmooth.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


