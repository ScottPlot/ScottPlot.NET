---
Title: "Manual Data Area - ScottPlot 4.1 Cookbook"
Description: "The layout system automatically measures axis labels and ticks to provide a plot with the largest data area possible. However, this can be problematic for animated plots (with changing tick label sizes) or when users wish to achieve pixel-perfect similarity between two different plots. In these cases the user can manually override the layout system and define exactly how large the data area is."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/layout_manual/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Layout", "Manual Data Area"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/layout", "/cookbook/4.1/recipes/layout_manual/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/layout_manual.png"
---

<h2><a id='manual-data-area' href='/cookbook/4.1/recipes/layout_manual/'>Manual Data Area</a></h2>

The layout system automatically measures axis labels and ticks to provide a plot with the largest data area possible. However, this can be problematic for animated plots (with changing tick label sizes) or when users wish to achieve pixel-perfect similarity between two different plots. In these cases the user can manually override the layout system and define exactly how large the data area is.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.Style(Style.Blue1);
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

var padding = new ScottPlot.PixelPadding(
    left: 150,
    right: 30,
    bottom: 100,
    top: 10);

plt.ManualDataArea(padding);

plt.SaveFig("layout_manual.png");
```

{{< /code-sp4 >}}

<img src='../../images/layout_manual.png' class='d-block mx-auto my-5' />


