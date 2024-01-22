---
Title: "Smooth Heatmap - ScottPlot 4.1 Cookbook"
Description: "Heatmaps display values as rectangles with sharp borders by default. Enabling the Smooth feature uses bicubic interpolation to display the heatmap as a smooth gradient between values."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/heatmap_smooth/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Smooth Heatmap"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_smooth/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_smooth.png"
---

<h2><a id='smooth-heatmap' href='/cookbook/4.1/recipes/heatmap_smooth/'>Smooth Heatmap</a></h2>

Heatmaps display values as rectangles with sharp borders by default. Enabling the Smooth feature uses bicubic interpolation to display the heatmap as a smooth gradient between values.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

var rand = new Random(0);
double[,] data2D = DataGen.Random2D(rand, 5, 4);

var hm = plt.AddHeatmap(data2D, lockScales: false);
hm.Smooth = true;

plt.SaveFig("heatmap_smooth.png");
```

{{< /code-sp4 >}}

<img src='../../images/heatmap_smooth.png' class='d-block mx-auto my-5' />


