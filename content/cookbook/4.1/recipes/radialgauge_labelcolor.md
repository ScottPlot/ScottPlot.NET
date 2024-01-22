---
Title: "Gauge Label Color - ScottPlot 4.1 Cookbook"
Description: "Level text fonts may be customized."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/radialgauge_labelcolor/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Gauge Label Color"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_labelcolor/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_labelcolor.png"
---

<h2><a id='gauge-label-color' href='/cookbook/4.1/recipes/radialgauge_labelcolor/'>Gauge Label Color</a></h2>

Level text fonts may be customized.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 20 };

var gauges = plt.AddRadialGauge(values);
gauges.Font.Color = Color.Black;

plt.SaveFig("radialgauge_labelcolor.png");
```

{{< /code-sp4 >}}

<img src='../../images/radialgauge_labelcolor.png' class='d-block mx-auto my-5' />


