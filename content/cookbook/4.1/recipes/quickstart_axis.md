---
Title: "Axis Labels and Limits - ScottPlot 4.1 Cookbook"
Description: "Axis labels and limits can be customized"
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/quickstart_axis/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Quickstart", "Axis Labels and Limits"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/quickstart", "/cookbook/4.1/recipes/quickstart_axis/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/quickstart_axis.png"
---

<h2><a href='/cookbook/4.1/recipes/quickstart_axis/'>Axis Labels and Limits</a></h2>

Axis labels and limits can be customized

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] time = DataGen.Consecutive(51);
double[] voltage = DataGen.Sin(51);
plt.AddScatter(time, voltage);

// Axes can be customized
plt.XAxis.Label("Time (milliseconds)");
plt.YAxis.Label("Voltage (mV)");
plt.XAxis2.Label("Important Experiment");

// Set axis limits to control the view
plt.SetAxisLimits(-20, 80, -2, 2);

plt.SaveFig("quickstart_axis.png");
```

<img src='../../images/quickstart_axis.png' class='d-block mx-auto my-5' />

