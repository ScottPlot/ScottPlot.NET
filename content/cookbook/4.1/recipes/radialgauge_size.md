---
Title: "Gauge Size - ScottPlot 4.1 Cookbook"
Description: "The empty space between gauges can be adjusted as a fraction of their width. "
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radialgauge_size/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Gauge Size"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_size/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_size.png"
---

<h2><a href='/cookbook/4.1/recipes/radialgauge_size/'>Gauge Size</a></h2>

The empty space between gauges can be adjusted as a fraction of their width. 

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 20 };
var gauges = plt.AddRadialGauge(values);
gauges.SpaceFraction = .05;

plt.SaveFig("radialgauge_size.png");
```

<img src='../../images/radialgauge_size.png' class='d-block mx-auto my-5' />


