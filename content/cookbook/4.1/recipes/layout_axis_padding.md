---
Title: "Axis Padding - ScottPlot 4.1 Cookbook"
Description: "Axis label and ticks are enclosed in a rectangle that is automatically sized to accomodate them (optionally limited to a min/max size as seen earlier). This rectangle has a small amount of padding on all sides so axis labels do not touch the final pixel on the edge of the figure. The amount of extra padding around each axis can be customized."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/layout_axis_padding/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Layout", "Axis Padding"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/layout", "/cookbook/4.1/recipes/layout_axis_padding/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/layout_axis_padding.png"
---

<h2><a id='axis-padding' href='/cookbook/4.1/recipes/layout_axis_padding/'>Axis Padding</a></h2>

Axis label and ticks are enclosed in a rectangle that is automatically sized to accomodate them (optionally limited to a min/max size as seen earlier). This rectangle has a small amount of padding on all sides so axis labels do not touch the final pixel on the edge of the figure. The amount of extra padding around each axis can be customized.

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

plt.XAxis.Layout(padding: 50);

plt.SaveFig("layout_axis_padding.png");
```

{{< /code-sp4 >}}

<img src='../../images/layout_axis_padding.png' class='d-block mx-auto my-5' />


