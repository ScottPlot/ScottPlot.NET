---
Title: "Scale Bar - ScottPlot 4.1 Cookbook"
Description: "An L-shaped scalebar can be added in the corner of any plot. Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/scalebar_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scale Bar", "Scale Bar"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scale-bar", "/cookbook/4.1/recipes/scalebar_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scalebar_quickstart.png"
---

<h2><a id='scale-bar' href='/cookbook/4.1/recipes/scalebar_quickstart/'>Scale Bar</a></h2>

An L-shaped scalebar can be added in the corner of any plot. Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// remove traditional scale indicators
plt.Grid(enable: false);
plt.Frameless();

// add an L-shaped scalebar
plt.AddScaleBar(5, .25, "100 ms", "250 mV");

plt.SaveFig("scalebar_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/scalebar_quickstart.png' class='d-block mx-auto my-5' />


