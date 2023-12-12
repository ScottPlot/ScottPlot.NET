---
Title: "Tick Density - ScottPlot 4.1 Cookbook"
Description: "Axis tick density can be adjusted by the user. The largest the density is, the more ticks are displayed. Setting this value too high will result in overlapping tick labels."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/asis_tickdensity/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Tick Density"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/asis_tickdensity/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/asis_tickdensity.png"
---

<h2><a href='/cookbook/4.1/recipes/asis_tickdensity/'>Tick Density</a></h2>

Axis tick density can be adjusted by the user. The largest the density is, the more ticks are displayed. Setting this value too high will result in overlapping tick labels.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.XAxis.Label("Lower Density Ticks");
plt.XAxis.TickDensity(0.2);

plt.YAxis.Label("Higher Density Ticks");
plt.YAxis.TickDensity(3);

plt.SaveFig("asis_tickDensity.png");
```

<img src='../../images/asis_tickdensity.png' class='d-block mx-auto my-5' />


