---
Title: Heatmap Rectangle - ScottPlot 5.0 Cookbook
Description: Dimensions of a heatmap may be set by defining a rectangle that the heatmap will be rendered inside.
URL: /cookbook/5.0/Heatmap/HeatmapRectangle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Heatmap Rectangle"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapRectangle"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Heatmap Rectangle</h1>
</div>

Dimensions of a heatmap may be set by defining a rectangle that the heatmap will be rendered inside.

[![](/cookbook/5.0/images/HeatmapRectangle.png?250126165944)](/cookbook/5.0/images/HeatmapRectangle.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapRectangle.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// create a heatmap of any size
double[,] data = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
};

// add the heatmap to the plot
var hm = myPlot.Add.Heatmap(data);

// place the heatmap in a rectangle defined in coordinate space
hm.Rectangle = new CoordinateRect(-5, 5, -5, 5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


