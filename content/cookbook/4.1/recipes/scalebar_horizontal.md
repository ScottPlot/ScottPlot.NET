---
Title: "Horizontal Scale Bar - ScottPlot 4.1 Cookbook"
Description: "Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/scalebar_horizontal/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scale Bar", "Horizontal Scale Bar"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scale-bar", "/cookbook/4.1/recipes/scalebar_horizontal/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scalebar_horizontal.png"
---

<h2><a id='horizontal-scale-bar' href='/cookbook/4.1/recipes/scalebar_horizontal/'>Horizontal Scale Bar</a></h2>

Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// plot sample data 
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// show only the left axis
plt.XAxis.Hide();
plt.XAxis2.Hide();
plt.YAxis2.Hide();
plt.Grid(enable: false);

// add a horizontal scale bar (no Y height)
plt.AddScaleBar(5, 0, "100 ms", null);

plt.SaveFig("scalebar_horizontal.png");
```

{{< /code-sp4 >}}

<img src='../../images/scalebar_horizontal.png' class='d-block mx-auto my-5' />


