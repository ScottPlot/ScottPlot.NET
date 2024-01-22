---
Title: "Heatmap Image - ScottPlot 4.1 Cookbook"
Description: "Image data can be plotted using the heatmap plot type."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/heatmap_image/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Heatmap Image"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_image/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_image.png"
---

<h2><a id='heatmap-image' href='/cookbook/4.1/recipes/heatmap_image/'>Heatmap Image</a></h2>

Image data can be plotted using the heatmap plot type.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[,] imageData = DataGen.SampleImageData();
plt.AddHeatmap(imageData);

plt.SaveFig("heatmap_image.png");
```

{{< /code-sp4 >}}

<img src='../../images/heatmap_image.png' class='d-block mx-auto my-5' />


