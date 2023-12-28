---
Title: "Palette Colormap - ScottPlot 4.1 Cookbook"
Description: "Heatmap data can be presented using a colormap defined by a fixed set of colors."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/heatmap_palette/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Palette Colormap"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_palette/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_palette.png"
---

<h2><a id='palette-colormap' href='/cookbook/4.1/recipes/heatmap_palette/'>Palette Colormap</a></h2>

Heatmap data can be presented using a colormap defined by a fixed set of colors.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] data = DataGen.SampleImageData();

// create a colormap from a defined set of colors
Color[] colors = { Color.Indigo, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Red, };

// display the colormap on the plot as a colorbar
ScottPlot.Drawing.Colormap cmap = new(colors);
var cbar = plt.AddColorbar(cmap);
cbar.MaxValue = 255;

// use custom tick positions
double[] tickPositions = Enumerable.Range(0, colors.Length + 1)
    .Select(x => (double)x / colors.Length)
    .ToArray();
string[] tickLabels = tickPositions.Select(x => $"{x * 255:N2}").ToArray();
cbar.SetTicks(tickPositions, tickLabels);

// add a heatmap using the custom colormap
plt.AddHeatmap(data, cmap);

plt.SaveFig("heatmap_palette.png");
```

<img src='../../images/heatmap_palette.png' class='d-block mx-auto my-5' />


