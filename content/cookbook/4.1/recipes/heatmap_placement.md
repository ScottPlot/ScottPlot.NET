---
Title: "Size and Placement - ScottPlot 4.1 Cookbook"
Description: "Edges of the heatmap can be defined as an alternative to defining offset and cell size,"
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/heatmap_placement/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Size and Placement"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_placement/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_placement.png"
---

<h2><a id='size-and-placement' href='/cookbook/4.1/recipes/heatmap_placement/'>Size and Placement</a></h2>

Edges of the heatmap can be defined as an alternative to defining offset and cell size,

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[,] imageData = DataGen.SampleImageData();
var hm = plt.AddHeatmap(imageData, lockScales: false);

hm.XMin = -100;
hm.XMax = 100;
hm.YMin = -10;
hm.YMax = 10;

plt.SaveFig("heatmap_placement.png");
```

{{< /code-sp4 >}}

<img src='../../images/heatmap_placement.png' class='d-block mx-auto my-5' />


