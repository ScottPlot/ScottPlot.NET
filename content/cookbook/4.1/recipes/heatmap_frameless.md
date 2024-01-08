---
Title: "Frameless Heatmap - ScottPlot 4.1 Cookbook"
Description: "Disable the frame and set margins to zero to create a heatmap plot that fills the entire image."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/heatmap_frameless/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Frameless Heatmap"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_frameless/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_frameless.png"
---

<h2><a id='frameless-heatmap' href='/cookbook/4.1/recipes/heatmap_frameless/'>Frameless Heatmap</a></h2>

Disable the frame and set margins to zero to create a heatmap plot that fills the entire image.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[,] imageData = DataGen.SampleImageData();
plt.AddHeatmap(imageData, lockScales: false);
plt.Frameless();
plt.Margins(0, 0);

plt.SaveFig("heatmap_frameless.png");
```

<img src='../../images/heatmap_frameless.png' class='d-block mx-auto my-5' />


