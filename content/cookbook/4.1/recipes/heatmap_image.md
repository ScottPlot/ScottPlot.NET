---
Title: "Heatmap Image - ScottPlot 4.1 Cookbook"
Description: "Image data can be plotted using the heatmap plot type."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/heatmap_image/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Heatmap Image"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_image/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_image.png"
---

<h2><a id='heatmap-image' href='/cookbook/4.1/recipes/heatmap_image/'>Heatmap Image</a></h2>

Image data can be plotted using the heatmap plot type.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] imageData = DataGen.SampleImageData();
plt.AddHeatmap(imageData);

plt.SaveFig("heatmap_image.png");
```

<img src='../../images/heatmap_image.png' class='d-block mx-auto my-5' />


