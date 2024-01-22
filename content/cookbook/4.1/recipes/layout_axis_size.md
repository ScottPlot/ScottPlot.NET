---
Title: "Axis Size - ScottPlot 4.1 Cookbook"
Description: "The size of each axis can be individually customized. Note that axes automatically resize themselves to accomodate tick labels, but this method lets users customize the min/max boundaries of axis size. Set both numbers to the same value to force an axis to always be a specific size."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/layout_axis_size/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Layout", "Axis Size"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/layout", "/cookbook/4.1/recipes/layout_axis_size/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/layout_axis_size.png"
---

<h2><a id='axis-size' href='/cookbook/4.1/recipes/layout_axis_size/'>Axis Size</a></h2>

The size of each axis can be individually customized. Note that axes automatically resize themselves to accomodate tick labels, but this method lets users customize the min/max boundaries of axis size. Set both numbers to the same value to force an axis to always be a specific size.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");
plt.Title("Plot Title");
plt.Style(figureBackground: Color.SkyBlue);

plt.XAxis.Layout(minimumSize: 100, maximumSize: 150);

plt.SaveFig("layout_axis_size.png");
```

{{< /code-sp4 >}}

<img src='../../images/layout_axis_size.png' class='d-block mx-auto my-5' />


