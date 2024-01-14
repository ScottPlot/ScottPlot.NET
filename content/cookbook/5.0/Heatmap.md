---
Title: Heatmap - ScottPlot 5.0 Cookbook
Description: Heatmaps display values from 2D data as an image with cells of different intensities
URL: /cookbook/5.0/Heatmap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap"]
Date: 2024-01-14
Version: ScottPlot 5.0.15
Version: ScottPlot 5.0.15
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Heatmap


<h2><a href='/cookbook/5.0/Heatmap/HeatmapQuickstart'>Heatmap Quickstart</a></h2>

Heatmaps can be created from 2D arrays

[![](/cookbook/5.0/images/HeatmapQuickstart.png)](/cookbook/5.0/images/HeatmapQuickstart.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 15);
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();
myPlot.Add.Heatmap(data);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Heatmap/HeatmapInverted'>Inverted Heatmap</a></h2>

Heatmaps can be inverted by reversing the order of colors in the colormap

[![](/cookbook/5.0/images/HeatmapInverted.png)](/cookbook/5.0/images/HeatmapInverted.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 15);
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm1 = myPlot.Add.Heatmap(data);
hm1.Colormap = new ScottPlot.Colormaps.Viridis();
hm1.Extent = new(0, 65, 0, 100);

var hm2 = myPlot.Add.Heatmap(data);
hm2.Colormap = new ScottPlot.Colormaps.Viridis().Reversed();
hm2.Extent = new(100, 165, 0, 100);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>

