---
Title: Colorbar Title - ScottPlot 5.0 Cookbook
Description: A colorbar displays a colormap on an edge of the plot, and it has an optional label which can be customized to display a title.
URL: /cookbook/5.0/Heatmap/ColorbarTitle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Colorbar Title"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/ColorbarTitle"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Colorbar Title</h1>
</div>

A colorbar displays a colormap on an edge of the plot, and it has an optional label which can be customized to display a title.

[![](/cookbook/5.0/images/ColorbarTitle.png?241124170640)](/cookbook/5.0/images/ColorbarTitle.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/ColorbarTitle.png?241124170640" >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm = myPlot.Add.Heatmap(data);
hm.Colormap = new ScottPlot.Colormaps.Turbo();

var cb = myPlot.Add.ColorBar(hm);
cb.Label = "Intensity";
cb.LabelStyle.FontSize = 24;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


