---
Title: Frameless Heatmap - ScottPlot 5.0 Cookbook
Description: A frameless heatmap can be achieved by disabling axis labels and ticks, then setting the margins to 0 so the data area tightly fits the data.
URL: /cookbook/5.0/Heatmap/FramelessHeatmap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Frameless Heatmap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/FramelessHeatmap"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Frameless Heatmap</h1>
</div>

A frameless heatmap can be achieved by disabling axis labels and ticks, then setting the margins to 0 so the data area tightly fits the data.

[![](/cookbook/5.0/images/FramelessHeatmap.png?250126165944)](/cookbook/5.0/images/FramelessHeatmap.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/FramelessHeatmap.png?250126165944" >}}ScottPlot.Plot myPlot = new();

double[,] data = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
};

// add a heatmap to the plot
myPlot.Add.Heatmap(data);

// hide axes on all edges of the figure
myPlot.Layout.Frameless();

// disable padding around the heatmap data
myPlot.Axes.Margins(0, 0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


