---
Title: "Single Color Heatmap - ScottPlot 4.1 Cookbook"
Description: "A single-color heatmap can be created where cell transparency is defined by a 2D array containing values 0 to 1."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/heatmap_single_color/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Single Color Heatmap"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_single_color/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_single_color.png"
---

<h2><a id='single-color-heatmap' href='/cookbook/4.1/recipes/heatmap_single_color/'>Single Color Heatmap</a></h2>

A single-color heatmap can be created where cell transparency is defined by a 2D array containing values 0 to 1.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double?[,] data = DataGen.SampleImageDataNullable();

var hm1 = plt.AddHeatmap(Color.Red, data, lockScales: false);
hm1.OffsetX = 0;
hm1.OffsetY = 0;

var hm2 = plt.AddHeatmap(Color.Green, data, lockScales: false);
hm2.OffsetX = 30;
hm2.OffsetY = 20;

var hm3 = plt.AddHeatmap(Color.Blue, data, lockScales: false);
hm3.OffsetX = 60;
hm3.OffsetY = 40;

plt.SaveFig("heatmap_single_color.png");
```

{{< /code-sp4 >}}

<img src='../../images/heatmap_single_color.png' class='d-block mx-auto my-5' />


