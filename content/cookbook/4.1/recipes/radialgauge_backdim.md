---
Title: "Background Gauges Dim - ScottPlot 4.1 Cookbook"
Description: "By default the full range of each gauge is drawn as a semitransparent ring. The amount of transparency can be adjusted as desired."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/radialgauge_backdim/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Background Gauges Dim"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_backdim/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_backdim.png"
---

<h2><a id='background-gauges-dim' href='/cookbook/4.1/recipes/radialgauge_backdim/'>Background Gauges Dim</a></h2>

By default the full range of each gauge is drawn as a semitransparent ring. The amount of transparency can be adjusted as desired.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 20 };

var gauges = plt.AddRadialGauge(values);
gauges.BackgroundTransparencyFraction = .5;

plt.SaveFig("radialgauge_backdim.png");
```

<img src='../../images/radialgauge_backdim.png' class='d-block mx-auto my-5' />


