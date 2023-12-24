---
Title: "Heatmap with Colorbar - ScottPlot 4.1 Cookbook"
Description: "Colorbars are often added when heatmaps are used."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/heatmap_colorbar/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Heatmap with Colorbar"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_colorbar/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_colorbar.png"
---

<h2><a id='heatmap-with-colorbar' href='/cookbook/4.1/recipes/heatmap_colorbar/'>Heatmap with Colorbar</a></h2>

Colorbars are often added when heatmaps are used.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] data2D = { { 1, 2, 3 },
         { 4, 5, 6 } };

var hm = plt.AddHeatmap(data2D, lockScales: false);
var cb = plt.AddColorbar(hm);
plt.Margins(0, 0);

plt.SaveFig("heatmap_colorbar.png");
```

<img src='../../images/heatmap_colorbar.png' class='d-block mx-auto my-5' />


