---
Title: "Colormap - ScottPlot 4.1 Cookbook"
Description: "Viridis is the default colormap, but several alternatives are available."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/heatmap_colormap/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Colormap"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_colormap/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_colormap.png"
---

<h2><a id='colormap' href='/cookbook/4.1/recipes/heatmap_colormap/'>Colormap</a></h2>

Viridis is the default colormap, but several alternatives are available.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[,] intensities = new double[100, 100];
for (int x = 0; x < 100; x++)
    for (int y = 0; y < 100; y++)
        intensities[x, y] = (Math.Sin(x * .2) + Math.Cos(y * .2)) * 100;

var hm = plt.AddHeatmap(intensities, Drawing.Colormap.Turbo);
var cb = plt.AddColorbar(hm);

plt.SaveFig("heatmap_colormap.png");
```

{{< /code-sp4 >}}

<img src='../../images/heatmap_colormap.png' class='d-block mx-auto my-5' />


