---
Title: Global Transparency - ScottPlot 5.0 Cookbook
Description: The transparency of the entire heatmap can be adjusted.
URL: /cookbook/5.0/Heatmap/HeatmapGlobalTransparency/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Global Transparency"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapGlobalTransparency"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Global Transparency</h1>
</div>

The transparency of the entire heatmap can be adjusted.

[![](/cookbook/5.0/images/HeatmapGlobalTransparency.png?250822231048)](/cookbook/5.0/images/HeatmapGlobalTransparency.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapGlobalTransparency.png?250822231048" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


