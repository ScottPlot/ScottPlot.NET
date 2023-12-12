---
Title: "Gauge Colors - ScottPlot 4.1 Cookbook"
Description: "Gauge colors can be customized by changing the default palette. "
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radialgauge_colors/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Gauge Colors"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_colors/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_colors.png"
---

<h2><a href='/cookbook/4.1/recipes/radialgauge_colors/'>Gauge Colors</a></h2>

Gauge colors can be customized by changing the default palette. 

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 100, 80, 65, 45, 20 };
plt.Palette = ScottPlot.Palette.Nord;
plt.AddRadialGauge(values);

plt.SaveFig("radialgauge_colors.png");
```

<img src='../../images/radialgauge_colors.png' class='d-block mx-auto my-5' />


