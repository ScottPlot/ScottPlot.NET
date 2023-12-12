---
Title: "Custom Dimensions - ScottPlot 4.1 Cookbook"
Description: "By default heatmaps start at the origin and each rectangle (cell) is 1 unit in size, but heatmap offset and cell size can be customized."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/heatmap_dimensions/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Custom Dimensions"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_dimensions/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_dimensions.png"
---

<h2><a id='custom-dimensions' href='/cookbook/4.1/recipes/heatmap_dimensions/'>Custom Dimensions</a></h2>

By default heatmaps start at the origin and each rectangle (cell) is 1 unit in size, but heatmap offset and cell size can be customized.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] data2D = { { 1, 2, 3 },
         { 4, 5, 6 } };

var hm = plt.AddHeatmap(data2D, lockScales: false);
hm.OffsetX = 10;
hm.OffsetY = 20;
hm.CellWidth = 5;
hm.CellHeight = 10;

plt.SaveFig("heatmap_dimensions.png");
```

<img src='../../images/heatmap_dimensions.png' class='d-block mx-auto my-5' />


