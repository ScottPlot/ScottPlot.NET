---
Title: "Radial Gauge - ScottPlot 4.1 Cookbook"
Description: "A radial gauge chart displays scalar data as circular gauges. "
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radialgauge_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radial Gauge", "Radial Gauge"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radialgauge", "/cookbook/4.1/recipes/radialgauge_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radialgauge_quickstart.png"
---

<h2><a href='/cookbook/4.1/recipes/radialgauge_quickstart/'>Radial Gauge</a></h2>

A radial gauge chart displays scalar data as circular gauges. 

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 100, 80, 65, 45, 20 };
plt.AddRadialGauge(values);

plt.SaveFig("radialgauge_quickstart.png");
```

<img src='../../images/radialgauge_quickstart.png' class='d-block mx-auto my-5' />


