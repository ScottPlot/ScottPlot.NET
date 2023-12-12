---
Title: "Gauge Label Color - ScottPlot 4.1 Cookbook"
Description: "Level text fonts may be customized."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radialgauge_labelcolor/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Gauge Label Color"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_labelcolor/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_labelcolor.png"
---

<h2><a href='/cookbook/4.1/recipes/radialgauge_labelcolor/'>Gauge Label Color</a></h2>

Level text fonts may be customized.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 20 };

var gauges = plt.AddRadialGauge(values);
gauges.Font.Color = Color.Black;

plt.SaveFig("radialgauge_labelcolor.png");
```

<img src='../../images/radialgauge_labelcolor.png' class='d-block mx-auto my-5' />


