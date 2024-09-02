---
Title: Heatmap with Manual Color Range - ScottPlot 5.0 Cookbook
Description: The user can define the range of values to represent with colors in the colormap. Values outside that range will be clipped to the nearest color in the colormap.
URL: /cookbook/5.0/Heatmap/HeatmapManualRange/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Heatmap with Manual Color Range"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapManualRange"]
Date: 2024-09-02
Version: ScottPlot 5.0.38
Version: ScottPlot 5.0.38
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Heatmap with Manual Color Range


The user can define the range of values to represent with colors in the colormap. Values outside that range will be clipped to the nearest color in the colormap.

[![](/cookbook/5.0/images/HeatmapManualRange.png?240902145058)](/cookbook/5.0/images/HeatmapManualRange.png?240902145058)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// sample data values range from 0-255
double[,] data = SampleData.MonaLisa();

// add a heatmap and colorbar to the plot
var hm = myPlot.Add.Heatmap(data);
hm.Colormap = new ScottPlot.Colormaps.Turbo();
myPlot.Add.ColorBar(hm);

// force the colormap to span a manual range of values
hm.ManualRange = new(50, 150);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

