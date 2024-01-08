---
Title: "Inverted Heatmap - ScottPlot 4.1 Cookbook"
Description: "An inverted heatmap can be created by reversing the colors in the colormap."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/heatmap_inverted/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Inverted Heatmap"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_inverted/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_inverted.png"
---

<h2><a id='inverted-heatmap' href='/cookbook/4.1/recipes/heatmap_inverted/'>Inverted Heatmap</a></h2>

An inverted heatmap can be created by reversing the colors in the colormap.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[,] data = DataGen.SampleImageData();

var hm1 = plt.AddHeatmap(data, lockScales: false);
hm1.Update(data, ScottPlot.Drawing.Colormap.Turbo);

var hm2 = plt.AddHeatmap(data, lockScales: false);
hm2.XMin = 75;
hm2.Update(data, ScottPlot.Drawing.Colormap.Turbo.Reversed());

plt.SaveFig("heatmap_inverted.png");
```

<img src='../../images/heatmap_inverted.png' class='d-block mx-auto my-5' />


