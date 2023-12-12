---
Title: "Horizontal Scale Bar - ScottPlot 4.1 Cookbook"
Description: "Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/scalebar_horizontal/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scale Bar", "Horizontal Scale Bar"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scale-bar", "/cookbook/4.1/recipes/scalebar_horizontal/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scalebar_horizontal.png"
---

<h2><a href='/cookbook/4.1/recipes/scalebar_horizontal/'>Horizontal Scale Bar</a></h2>

Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension.

```cs
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

<img src='../../images/scalebar_horizontal.png' class='d-block mx-auto my-5' />


