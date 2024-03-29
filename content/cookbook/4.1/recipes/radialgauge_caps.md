---
Title: "Gauge Caps - ScottPlot 4.1 Cookbook"
Description: "Caps can be customized for the starting and end of the gauges. "
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/radialgauge_caps/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Gauge Caps"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_caps/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_caps.png"
---

<h2><a id='gauge-caps' href='/cookbook/4.1/recipes/radialgauge_caps/'>Gauge Caps</a></h2>

Caps can be customized for the starting and end of the gauges. 

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 20 };

var gauges = plt.AddRadialGauge(values);
gauges.CircularBackground = false;
gauges.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
gauges.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;

plt.SaveFig("radialgauge_caps.png");
```

{{< /code-sp4 >}}

<img src='../../images/radialgauge_caps.png' class='d-block mx-auto my-5' />


