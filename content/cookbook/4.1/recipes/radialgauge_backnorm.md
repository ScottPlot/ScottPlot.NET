---
Title: "Background Gauges Normalization - ScottPlot 4.1 Cookbook"
Description: "Gauge backgrounds are drawn as full circles by default. This behavior can be disabled to draw partial backgrounds for non-circular gauges."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/radialgauge_backnorm/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Background Gauges Normalization"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_backnorm/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_backnorm.png"
---

<h2><a id='background-gauges-normalization' href='/cookbook/4.1/recipes/radialgauge_backnorm/'>Background Gauges Normalization</a></h2>

Gauge backgrounds are drawn as full circles by default. This behavior can be disabled to draw partial backgrounds for non-circular gauges.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 20 };

var gauges = plt.AddRadialGauge(values);
gauges.CircularBackground = false;
gauges.MaximumAngle = 180;
gauges.StartingAngle = 180;

plt.SaveFig("radialgauge_backnorm.png");
```

<img src='../../images/radialgauge_backnorm.png' class='d-block mx-auto my-5' />


