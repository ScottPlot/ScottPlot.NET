---
Title: "Heatmap with Empty Squares - ScottPlot 4.1 Cookbook"
Description: "You can use a 2D array of nullable doubles to indicate some squares do not contain data. This allows the user to display heatmaps with transparency and implement non-rectangular heatmaps."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/heatmap_transparent/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Heatmap with Empty Squares"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_transparent/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_transparent.png"
---

<h2><a href='/cookbook/4.1/recipes/heatmap_transparent/'>Heatmap with Empty Squares</a></h2>

You can use a 2D array of nullable doubles to indicate some squares do not contain data. This allows the user to display heatmaps with transparency and implement non-rectangular heatmaps.

```cs
var plt = new ScottPlot.Plot(600, 400);

double?[,] intensities = {
    { 1, 7, 4, null },
    { 9, null, 2, 4 },
    { 1, 4, null, 8 },
    { null, 2, 4, null }
};

var hmc = plt.AddHeatmap(intensities);
var cb = plt.AddColorbar(hmc);

plt.SaveFig("heatmap_transparent.png");
```

<img src='../../images/heatmap_transparent.png' class='d-block mx-auto my-5' />


