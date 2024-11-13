---
Title: Multiple Colorbars - ScottPlot 5.0 Cookbook
Description: Multiple colorbars may be added to plots.
URL: /cookbook/5.0/Heatmap/HeatmapMultipleColorbar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Multiple Colorbars"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapMultipleColorbar"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiple Colorbars</h1>
</div>

Multiple colorbars may be added to plots.

[![](/cookbook/5.0/images/HeatmapMultipleColorbar.png?241112193154)](/cookbook/5.0/images/HeatmapMultipleColorbar.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapMultipleColorbar.png?241112193154" >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm1 = myPlot.Add.Heatmap(data);
hm1.Extent = new(0, 1, 0, 1);
hm1.Colormap = new ScottPlot.Colormaps.Turbo();
myPlot.Add.ColorBar(hm1);

var hm2 = myPlot.Add.Heatmap(data);
hm2.Extent = new(1.5, 2.5, 0, 1);
hm2.Colormap = new ScottPlot.Colormaps.Viridis();
myPlot.Add.ColorBar(hm2);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


