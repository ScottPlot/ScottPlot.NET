---
Title: "Single Gauge Mode - ScottPlot 4.1 Cookbook"
Description: "The SingleGauge mode draws all gauges stacked together as a single gauge. This is useful for showing a progress gauges composed of many individual smaller gauges."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radialgauge_single/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Single Gauge Mode"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_single/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_single.png"
---

<h2><a id='single-gauge-mode' href='/cookbook/4.1/recipes/radialgauge_single/'>Single Gauge Mode</a></h2>

The SingleGauge mode draws all gauges stacked together as a single gauge. This is useful for showing a progress gauges composed of many individual smaller gauges.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45 };

var gauges = plt.AddRadialGauge(values);
gauges.GaugeMode = ScottPlot.RadialGaugeMode.SingleGauge;
gauges.MaximumAngle = 180;
gauges.StartingAngle = 180;

plt.SaveFig("radialgauge_single.png");
```

<img src='../../images/radialgauge_single.png' class='d-block mx-auto my-5' />


