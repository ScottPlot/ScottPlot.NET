---
Title: "Flipped Heatmap - ScottPlot 4.1 Cookbook"
Description: "Heatmaps can be flipped vertically and/or horizontally."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/heatmap_flip/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Flipped Heatmap"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_flip/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_flip.png"
---

<h2><a id='flipped-heatmap' href='/cookbook/4.1/recipes/heatmap_flip/'>Flipped Heatmap</a></h2>

Heatmaps can be flipped vertically and/or horizontally.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[,] data = ScottPlot.DataGen.SampleImageData();

var hm1 = plt.AddHeatmap(data, lockScales: false);
hm1.XMin = 0;

var hm2 = plt.AddHeatmap(data, lockScales: false);
hm2.XMin = 100;
hm2.FlipHorizontally = true;

var hm3 = plt.AddHeatmap(data, lockScales: false);
hm3.XMin = 200;
hm3.FlipVertically = true;

var hm4 = plt.AddHeatmap(data, lockScales: false);
hm4.XMin = 300;
hm4.FlipVertically = true;
hm4.FlipHorizontally = true;

plt.SaveFig("heatmap_flip.png");
```

{{< /code-sp4 >}}

<img src='../../images/heatmap_flip.png' class='d-block mx-auto my-5' />


