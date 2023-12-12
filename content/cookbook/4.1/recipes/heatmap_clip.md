---
Title: "Color Clipping - ScottPlot 4.1 Cookbook"
Description: "The value range displayed by the colormap can restricted to a narrow subset of the full data range. Tick labels at the edges of the colorbar can be made to show inequality symbols to indicate the range of data is being clipped when translating values to colors."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/heatmap_clip/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Color Clipping"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_clip/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_clip.png"
---

<h2><a href='/cookbook/4.1/recipes/heatmap_clip/'>Color Clipping</a></h2>

The value range displayed by the colormap can restricted to a narrow subset of the full data range. Tick labels at the edges of the colorbar can be made to show inequality symbols to indicate the range of data is being clipped when translating values to colors.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] imageData = DataGen.SampleImageData();
var heatmap = plt.AddHeatmap(imageData);
heatmap.Update(imageData, min: 75, max: 125);

var cb = plt.AddColorbar(heatmap);

// configure the colorbar to display inequality operators at the edges
cb.MaxIsClipped = true;
cb.MinIsClipped = true;

plt.SaveFig("heatmap_clip.png");
```

<img src='../../images/heatmap_clip.png' class='d-block mx-auto my-5' />


