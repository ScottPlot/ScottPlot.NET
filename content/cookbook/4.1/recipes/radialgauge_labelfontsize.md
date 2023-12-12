---
Title: "Gauge Label Font Percentage - ScottPlot 4.1 Cookbook"
Description: "Size of the gauge level text as a fraction of the gauge width."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radialgauge_labelfontsize/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Gauge Label Font Percentage"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_labelfontsize/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_labelfontsize.png"
---

<h2><a id='gauge-label-font-percentage' href='/cookbook/4.1/recipes/radialgauge_labelfontsize/'>Gauge Label Font Percentage</a></h2>

Size of the gauge level text as a fraction of the gauge width.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 20 };

var gauges = plt.AddRadialGauge(values);
gauges.FontSizeFraction = .4;

plt.SaveFig("radialgauge_labelfontsize.png");
```

<img src='../../images/radialgauge_labelfontsize.png' class='d-block mx-auto my-5' />


