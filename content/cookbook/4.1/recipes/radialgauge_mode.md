---
Title: "Sequential Gauge Mode - ScottPlot 4.1 Cookbook"
Description: "Sequential gauge mode indicates that the base of each gauge starts at the tip of the previous gauge."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radialgauge_mode/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Sequential Gauge Mode"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_mode/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_mode.png"
---

<h2><a id='sequential-gauge-mode' href='/cookbook/4.1/recipes/radialgauge_mode/'>Sequential Gauge Mode</a></h2>

Sequential gauge mode indicates that the base of each gauge starts at the tip of the previous gauge.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 50 };

var gauges = plt.AddRadialGauge(values);
gauges.GaugeMode = ScottPlot.RadialGaugeMode.Sequential;

plt.SaveFig("radialgauge_mode.png");
```

<img src='../../images/radialgauge_mode.png' class='d-block mx-auto my-5' />


