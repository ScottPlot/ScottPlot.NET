---
Title: "Heatmap Clipping - ScottPlot 4.1 Cookbook"
Description: "Heatmaps can be clipped to an arbitrary polygon"
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/heatmap_clipping/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Heatmap Clipping"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_clipping/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_clipping.png"
---

<h2><a id='heatmap-clipping' href='/cookbook/4.1/recipes/heatmap_clipping/'>Heatmap Clipping</a></h2>

Heatmaps can be clipped to an arbitrary polygon

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] imageData = DataGen.SampleImageData();
var hm = plt.AddHeatmap(imageData, lockScales: false);
hm.ClippingPoints = new Coordinate[]
{
    new Coordinate(30, 15),
    new Coordinate(55, 40),
    new Coordinate(60, 45),
    new Coordinate(80, 60),
    new Coordinate(40, 95),
    new Coordinate(15, 90),
    new Coordinate(5, 50),
};

plt.SaveFig("heatmap_clipping.png");
```

<img src='../../images/heatmap_clipping.png' class='d-block mx-auto my-5' />


