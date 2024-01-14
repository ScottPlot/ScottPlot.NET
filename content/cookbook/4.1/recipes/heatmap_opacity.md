---
Title: "Heatmap Opacity - ScottPlot 4.1 Cookbook"
Description: "Heatmaps have an Opacity property that can be set anywhere from 0 (transparent) to 1 (opaque)."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/heatmap_opacity/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Heatmap Opacity"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_opacity/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_opacity.png"
---

<h2><a id='heatmap-opacity' href='/cookbook/4.1/recipes/heatmap_opacity/'>Heatmap Opacity</a></h2>

Heatmaps have an Opacity property that can be set anywhere from 0 (transparent) to 1 (opaque).

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[,] imageData = DataGen.SampleImageData();
var hm = plt.AddHeatmap(imageData);
hm.Opacity = 0.5;

plt.SaveFig("heatmap_opacity.png");
```

{{< /code-sp4 >}}

<img src='../../images/heatmap_opacity.png' class='d-block mx-auto my-5' />


