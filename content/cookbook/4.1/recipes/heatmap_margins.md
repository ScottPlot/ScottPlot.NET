---
Title: "Heatmap with Tight Margins - ScottPlot 4.1 Cookbook"
Description: "The heatmap can fit the plot area exactly if margins are set to zero and the square axis lock is disabled."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/heatmap_margins/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Heatmap with Tight Margins"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_margins/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_margins.png"
---

<h2><a id='heatmap-with-tight-margins' href='/cookbook/4.1/recipes/heatmap_margins/'>Heatmap with Tight Margins</a></h2>

The heatmap can fit the plot area exactly if margins are set to zero and the square axis lock is disabled.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] data2D = { { 1, 2, 3 },
         { 4, 5, 6 } };

plt.AddHeatmap(data2D, lockScales: false);
plt.Margins(0, 0);

plt.SaveFig("heatmap_margins.png");
```

<img src='../../images/heatmap_margins.png' class='d-block mx-auto my-5' />


