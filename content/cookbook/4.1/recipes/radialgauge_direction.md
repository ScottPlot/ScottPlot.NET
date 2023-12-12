---
Title: "Gauge Direction - ScottPlot 4.1 Cookbook"
Description: "The direction of gauges can be customized. Clockwise is used by default."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radialgauge_direction/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Gauge Direction"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_direction/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_direction.png"
---

<h2><a href='/cookbook/4.1/recipes/radialgauge_direction/'>Gauge Direction</a></h2>

The direction of gauges can be customized. Clockwise is used by default.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 20 };

var gauges = plt.AddRadialGauge(values);
gauges.Clockwise = false;

plt.SaveFig("radialgauge_direction.png");
```

<img src='../../images/radialgauge_direction.png' class='d-block mx-auto my-5' />


