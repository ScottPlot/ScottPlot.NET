---
Title: "Heatmap Quickstart - ScottPlot 4.1 Cookbook"
Description: "Heatmaps display a 2D array using a colormap."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/heatmap_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Heatmap Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_quickstart.png"
---

<h2><a id='heatmap-quickstart' href='/cookbook/4.1/recipes/heatmap_quickstart/'>Heatmap Quickstart</a></h2>

Heatmaps display a 2D array using a colormap.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[,] data2D = { { 1, 2, 3 },
         { 4, 5, 6 } };

plt.AddHeatmap(data2D);

plt.SaveFig("heatmap_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/heatmap_quickstart.png' class='d-block mx-auto my-5' />


