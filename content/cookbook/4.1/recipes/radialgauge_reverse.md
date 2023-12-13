---
Title: "Reverse Order - ScottPlot 4.1 Cookbook"
Description: "Gauges are displayed from the center outward by default but the order can be customized."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radialgauge_reverse/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Reverse Order"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_reverse/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_reverse.png"
---

<h2><a id='reverse-order' href='/cookbook/4.1/recipes/radialgauge_reverse/'>Reverse Order</a></h2>

Gauges are displayed from the center outward by default but the order can be customized.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 50 };

var gauges = plt.AddRadialGauge(values);
gauges.GaugeMode = ScottPlot.RadialGaugeMode.Sequential;
gauges.OrderInsideOut = false;

plt.SaveFig("radialgauge_reverse.png");
```

<img src='../../images/radialgauge_reverse.png' class='d-block mx-auto my-5' />


