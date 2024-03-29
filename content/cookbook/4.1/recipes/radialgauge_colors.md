---
Title: "Gauge Colors - ScottPlot 4.1 Cookbook"
Description: "Gauge colors can be customized by changing the default palette. "
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/radialgauge_colors/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Gauge Colors"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_colors/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_colors.png"
---

<h2><a id='gauge-colors' href='/cookbook/4.1/recipes/radialgauge_colors/'>Gauge Colors</a></h2>

Gauge colors can be customized by changing the default palette. 

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 100, 80, 65, 45, 20 };
plt.Palette = ScottPlot.Palette.Nord;
plt.AddRadialGauge(values);

plt.SaveFig("radialgauge_colors.png");
```

{{< /code-sp4 >}}

<img src='../../images/radialgauge_colors.png' class='d-block mx-auto my-5' />


