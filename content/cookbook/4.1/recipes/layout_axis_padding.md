---
Title: "Axis Padding - ScottPlot 4.1 Cookbook"
Description: "Axis label and ticks are enclosed in a rectangle that is automatically sized to accomodate them (optionally limited to a min/max size as seen earlier). This rectangle has a small amount of padding on all sides so axis labels do not touch the final pixel on the edge of the figure. The amount of extra padding around each axis can be customized."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/layout_axis_padding/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Layout", "Axis Padding"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/layout", "/cookbook/4.1/recipes/layout_axis_padding/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/layout_axis_padding.png"
---

<h2><a href='/cookbook/4.1/recipes/layout_axis_padding/'>Axis Padding</a></h2>

Axis label and ticks are enclosed in a rectangle that is automatically sized to accomodate them (optionally limited to a min/max size as seen earlier). This rectangle has a small amount of padding on all sides so axis labels do not touch the final pixel on the edge of the figure. The amount of extra padding around each axis can be customized.

```cs
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

<img src='../../images/layout_axis_padding.png' class='d-block mx-auto my-5' />


