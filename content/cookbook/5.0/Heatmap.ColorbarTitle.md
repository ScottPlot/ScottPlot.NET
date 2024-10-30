---
Title: Colorbar Title - ScottPlot 5.0 Cookbook
Description: A colorbar displays a colormap on an edge of the plot, and it has an optional label which can be customized to display a title.
URL: /cookbook/5.0/Heatmap/ColorbarTitle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Colorbar Title"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/ColorbarTitle"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Heatmap/ColorbarTitle'>Colorbar Title</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Heatmap/ColorbarTitle">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Heatmap">Category: Heatmap</a>
</div>

A colorbar displays a colormap on an edge of the plot, and it has an optional label which can be customized to display a title.

[![](/cookbook/5.0/images/ColorbarTitle.png?241029205813)](/cookbook/5.0/images/ColorbarTitle.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm = myPlot.Add.Heatmap(data);
hm.Colormap = new ScottPlot.Colormaps.Turbo();

var cb = myPlot.Add.ColorBar(hm);
cb.Label = "Intensity";
cb.LabelStyle.FontSize = 24;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


