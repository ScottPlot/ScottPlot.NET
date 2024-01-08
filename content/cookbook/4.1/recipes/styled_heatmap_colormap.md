---
Title: "Styled Colormap - ScottPlot 4.1 Cookbook"
Description: "Viridis is the default colormap, but several alternatives are available."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/styled_heatmap_colormap/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Styled Colormap"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/styled_heatmap_colormap/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/styled_heatmap_colormap.png"
---

<h2><a id='styled-colormap' href='/cookbook/4.1/recipes/styled_heatmap_colormap/'>Styled Colormap</a></h2>

Viridis is the default colormap, but several alternatives are available.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[,] intensities = new double[100, 100];
for (int x = 0; x < 100; x++)
    for (int y = 0; y < 100; y++)
        intensities[x, y] = (Math.Sin(x * .2) + Math.Cos(y * .2)) * 100;

var hm = plt.AddHeatmap(intensities, Drawing.Colormap.Turbo);
var cb = plt.AddColorbar(hm);

plt.Style(Style.Black);

plt.SaveFig("styled_heatmap_colormap.png");
```

<img src='../../images/styled_heatmap_colormap.png' class='d-block mx-auto my-5' />


