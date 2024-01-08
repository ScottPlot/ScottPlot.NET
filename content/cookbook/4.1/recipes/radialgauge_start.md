---
Title: "Gauge Starting Angle - ScottPlot 4.1 Cookbook"
Description: "The starting angle for gauges can be customized. 270 for North (default value), 0 for East, 90 for South, 180 for West, etc."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/radialgauge_start/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Gauge Starting Angle"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_start/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_start.png"
---

<h2><a id='gauge-starting-angle' href='/cookbook/4.1/recipes/radialgauge_start/'>Gauge Starting Angle</a></h2>

The starting angle for gauges can be customized. 270 for North (default value), 0 for East, 90 for South, 180 for West, etc.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 20 };

var gauges = plt.AddRadialGauge(values);
gauges.StartingAngle = 180;

plt.SaveFig("radialgauge_start.png");
```

<img src='../../images/radialgauge_start.png' class='d-block mx-auto my-5' />


