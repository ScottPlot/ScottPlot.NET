---
Title: "Gauge Label Position - ScottPlot 4.1 Cookbook"
Description: "Gauge level text is positioned at the tip of each gauge by default, but this position can be adjusted by the user."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/radialgauge_labelpos/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Gauge Label Position"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_labelpos/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_labelpos.png"
---

<h2><a id='gauge-label-position' href='/cookbook/4.1/recipes/radialgauge_labelpos/'>Gauge Label Position</a></h2>

Gauge level text is positioned at the tip of each gauge by default, but this position can be adjusted by the user.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 20 };

var gauges = plt.AddRadialGauge(values);
gauges.LabelPositionFraction = 0;

plt.SaveFig("radialgauge_labelpos.png");
```

{{< /code-sp4 >}}

<img src='../../images/radialgauge_labelpos.png' class='d-block mx-auto my-5' />


