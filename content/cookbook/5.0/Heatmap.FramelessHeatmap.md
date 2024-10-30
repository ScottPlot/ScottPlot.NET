---
Title: Frameless Heatmap - ScottPlot 5.0 Cookbook
Description: A frameless heatmap can be achieved by disabling axis labels and ticks, then setting the margins to 0 so the data area tightly fits the data.
URL: /cookbook/5.0/Heatmap/FramelessHeatmap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Frameless Heatmap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/FramelessHeatmap"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Heatmap/FramelessHeatmap'>Frameless Heatmap</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Heatmap/FramelessHeatmap">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Heatmap">Category: Heatmap</a>
</div>

A frameless heatmap can be achieved by disabling axis labels and ticks, then setting the margins to 0 so the data area tightly fits the data.

[![](/cookbook/5.0/images/FramelessHeatmap.png?241029205813)](/cookbook/5.0/images/FramelessHeatmap.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


