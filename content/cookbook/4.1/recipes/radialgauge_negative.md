---
Title: "Negative Values - ScottPlot 4.1 Cookbook"
Description: "Radial gauge plots support positive and negative values."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radialgauge_negative/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Negative Values"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_negative/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_negative.png"
---

<h2><a href='/cookbook/4.1/recipes/radialgauge_negative/'>Negative Values</a></h2>

Radial gauge plots support positive and negative values.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, -65, 45, -20 };
plt.AddRadialGauge(values);

plt.SaveFig("radialgauge_negative.png");
```

<img src='../../images/radialgauge_negative.png' class='d-block mx-auto my-5' />


