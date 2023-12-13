---
Title: "Heatmap Opacity - ScottPlot 4.1 Cookbook"
Description: "Heatmaps have an Opacity property that can be set anywhere from 0 (transparent) to 1 (opaque)."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/heatmap_opacity/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Heatmap Opacity"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_opacity/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_opacity.png"
---

<h2><a id='heatmap-opacity' href='/cookbook/4.1/recipes/heatmap_opacity/'>Heatmap Opacity</a></h2>

Heatmaps have an Opacity property that can be set anywhere from 0 (transparent) to 1 (opaque).

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] imageData = DataGen.SampleImageData();
var hm = plt.AddHeatmap(imageData);
hm.Opacity = 0.5;

plt.SaveFig("heatmap_opacity.png");
```

<img src='../../images/heatmap_opacity.png' class='d-block mx-auto my-5' />


