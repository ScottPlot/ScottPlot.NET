---
Title: "Rotated X Ticks - ScottPlot 4.1 Cookbook"
Description: "Horizontal tick labels can be rotated as desired."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/ticks_rotated/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Rotated X Ticks"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/ticks_rotated/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_rotated.png"
---

<h2><a id='rotated-x-ticks' href='/cookbook/4.1/recipes/ticks_rotated/'>Rotated X Ticks</a></h2>

Horizontal tick labels can be rotated as desired.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.XAxis.Label("Horizontal Axis");
plt.YAxis.Label("Vertical Axis");

// rotate horizontal axis tick labels
plt.XAxis.TickLabelStyle(rotation: 45);

plt.SaveFig("ticks_rotated.png");
```

<img src='../../images/ticks_rotated.png' class='d-block mx-auto my-5' />


