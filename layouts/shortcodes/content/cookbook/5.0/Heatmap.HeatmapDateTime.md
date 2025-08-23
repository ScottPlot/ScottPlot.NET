---
Title: Heatmap with DateTime Axis - ScottPlot 5.0 Cookbook
Description: Heatmaps can be displayed on plots which use dates instead of numbers on the horizontal axis.
URL: /cookbook/5.0/Heatmap/HeatmapDateTime/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Heatmap with DateTime Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapDateTime"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Heatmap with DateTime Axis</h1>
</div>

Heatmaps can be displayed on plots which use dates instead of numbers on the horizontal axis.

[![](/cookbook/5.0/images/HeatmapDateTime.png?250822231048)](/cookbook/5.0/images/HeatmapDateTime.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapDateTime.png?250822231048" >}}ScottPlot.Plot myPlot = new();

// add a heatmap to the plot
double[,] data = SampleData.MonaLisa();
var hm = myPlot.Add.Heatmap(data);

// define its height using numeric units
CoordinateRange yRange = new(0, 10);

// define its width using date units
DateTime start = new(2024, 01, 01);
DateTime end = new(2025, 01, 01);
CoordinateRange xRange = new(start.ToOADate(), end.ToOADate());

// apply width and height to the heatmap
hm.Rectangle = new(xRange, yRange);

// tell the plot to use date formatting for X axis tick labels
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


