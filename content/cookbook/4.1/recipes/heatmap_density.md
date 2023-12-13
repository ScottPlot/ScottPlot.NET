---
Title: "Interpolation by Density - ScottPlot 4.1 Cookbook"
Description: "Heatmaps can be created from random 2D data points using the count within a square of fixed size."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/heatmap_density/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Interpolation by Density"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_density/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_density.png"
---

<h2><a id='interpolation-by-density' href='/cookbook/4.1/recipes/heatmap_density/'>Interpolation by Density</a></h2>

Heatmaps can be created from random 2D data points using the count within a square of fixed size.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int[] xs = DataGen.RandomNormal(rand, 10000, 25, 10).Select(x => (int)x).ToArray();
int[] ys = DataGen.RandomNormal(rand, 10000, 25, 10).Select(y => (int)y).ToArray();

double[,] intensities = Tools.XYToIntensities(mode: IntensityMode.Density,
    xs: xs, ys: ys, width: 50, height: 50, sampleWidth: 4);

var hm = plt.AddHeatmap(intensities);
var cb = plt.AddColorbar(hm);

plt.SaveFig("heatmap_density.png");
```

<img src='../../images/heatmap_density.png' class='d-block mx-auto my-5' />


