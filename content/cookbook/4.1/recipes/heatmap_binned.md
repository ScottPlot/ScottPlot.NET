---
Title: "Binned Histogram - ScottPlot 4.1 Cookbook"
Description: "Binned histograms are 2D heatmaps that use a colormap to display cell counts. Charts like this are commonly used in scientific and medical applications."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/heatmap_binned/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Binned Histogram"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_binned/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_binned.png"
---

<h2><a id='binned-histogram' href='/cookbook/4.1/recipes/heatmap_binned/'>Binned Histogram</a></h2>

Binned histograms are 2D heatmaps that use a colormap to display cell counts. Charts like this are commonly used in scientific and medical applications.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// create a binned histogram
var hist2d = plt.AddBinnedHistogram(100, 100);

// data is a collection of X/Y points
Coordinate[] flowData = DataGen.FlowCytometry();

// add X/Y points to the histogram
hist2d.AddRange(flowData);

plt.SaveFig("heatmap_binned.png");
```

{{< /code-sp4 >}}

<img src='../../images/heatmap_binned.png' class='d-block mx-auto my-5' />


