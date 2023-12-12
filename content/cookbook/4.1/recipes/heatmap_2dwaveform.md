---
Title: "2D Waveform - ScottPlot 4.1 Cookbook"
Description: "This example demonstrates a heatmap with 1000 tiles"
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/heatmap_2dwaveform/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "2D Waveform"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_2dwaveform/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_2dwaveform.png"
---

<h2><a id='2d-waveform' href='/cookbook/4.1/recipes/heatmap_2dwaveform/'>2D Waveform</a></h2>

This example demonstrates a heatmap with 1000 tiles

```cs
var plt = new ScottPlot.Plot(600, 400);

int width = 100;
int height = 100;

double[,] intensities = new double[width, height];

for (int x = 0; x < width; x++)
    for (int y = 0; y < height; y++)
        intensities[x, y] = (Math.Sin(x * .2) + Math.Cos(y * .2)) * 100;

var hm = plt.AddHeatmap(intensities);
var cb = plt.AddColorbar(hm);

plt.SaveFig("heatmap_2dWaveform.png");
```

<img src='../../images/heatmap_2dwaveform.png' class='d-block mx-auto my-5' />


