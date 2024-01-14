---
Title: "Gauge Angular Range - ScottPlot 4.1 Cookbook"
Description: "By default gauges are full circles (360 degrees) but smaller gauges can be created by customizing the gauge size."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/radialgauge_range/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Gauge Angular Range"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_range/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_range.png"
---

<h2><a id='gauge-angular-range' href='/cookbook/4.1/recipes/radialgauge_range/'>Gauge Angular Range</a></h2>

By default gauges are full circles (360 degrees) but smaller gauges can be created by customizing the gauge size.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 20 };

var gauges = plt.AddRadialGauge(values);
gauges.MaximumAngle = 180;

plt.SaveFig("radialgauge_range.png");
```

{{< /code-sp4 >}}

<img src='../../images/radialgauge_range.png' class='d-block mx-auto my-5' />


