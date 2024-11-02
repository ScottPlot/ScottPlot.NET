---
Title: Flipped Heatmap - ScottPlot 5.0 Cookbook
Description: Heatmaps can be flipped horizontally and/or vertically
URL: /cookbook/5.0/Heatmap/HeatmapFlip/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Flipped Heatmap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapFlip"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Flipped Heatmap</h1>
</div>

Heatmaps can be flipped horizontally and/or vertically

[![](/cookbook/5.0/images/HeatmapFlip.png?241102170938)](/cookbook/5.0/images/HeatmapFlip.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapFlip.png?241102170938" >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

myPlot.Add.Text("default", 0, 1.5);
var hm1 = myPlot.Add.Heatmap(data);
hm1.Position = new CoordinateRect(0, 1, 0, 1);

myPlot.Add.Text("flip X", 2, 1.5);
var hm2 = myPlot.Add.Heatmap(data);
hm2.Position = new CoordinateRect(2, 3, 0, 1);
hm2.FlipHorizontally = true;

myPlot.Add.Text("flip Y", 4, 1.5);
var hm3 = myPlot.Add.Heatmap(data);
hm3.Position = new CoordinateRect(4, 5, 0, 1);
hm3.FlipVertically = true;

myPlot.Add.Text("flip X&Y", 6, 1.5);
var hm4 = myPlot.Add.Heatmap(data);
hm4.Position = new CoordinateRect(6, 7, 0, 1);
hm4.FlipHorizontally = true;
hm4.FlipVertically = true;

myPlot.Axes.SetLimits(-.5, 7.5, -1, 2);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


