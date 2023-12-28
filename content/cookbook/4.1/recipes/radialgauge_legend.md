---
Title: "Gauge Labels in Legend - ScottPlot 4.1 Cookbook"
Description: "Radial gauge labels will appear in the legend if they are assigned. "
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/radialgauge_legend/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Gauge Labels in Legend"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_legend/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_legend.png"
---

<h2><a id='gauge-labels-in-legend' href='/cookbook/4.1/recipes/radialgauge_legend/'>Gauge Labels in Legend</a></h2>

Radial gauge labels will appear in the legend if they are assigned. 

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;
double[] values = { 100, 80, 65, 45, 20 };

var gauges = plt.AddRadialGauge(values);
gauges.Labels = new string[] { "alpha", "beta", "gamma", "delta", "epsilon" };
plt.Legend(true);

plt.SaveFig("radialgauge_legend.png");
```

<img src='../../images/radialgauge_legend.png' class='d-block mx-auto my-5' />


