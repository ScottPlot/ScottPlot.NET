---
Title: "Setting Multi Axis Limits - ScottPlot 4.1 Cookbook"
Description: "Axis limits can be set for each axis by indicating which axis index you are wish to modify when setting axis limits."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/multiaxis_limits/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Multi-Axis", "Setting Multi Axis Limits"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/multi-axis", "/cookbook/4.1/recipes/multiaxis_limits/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/multiaxis_limits.png"
---

<h2><a href='/cookbook/4.1/recipes/multiaxis_limits/'>Setting Multi Axis Limits</a></h2>

Axis limits can be set for each axis by indicating which axis index you are wish to modify when setting axis limits.

```cs
var plt = new ScottPlot.Plot(600, 400);

// signal one on the primary Y axis
var sig1 = plt.AddSignal(DataGen.Sin(51, mult: 1));
sig1.YAxisIndex = plt.LeftAxis.AxisIndex;

// signal two on the secondary Y axis
var sig2 = plt.AddSignal(DataGen.Cos(51, mult: 100));
sig2.YAxisIndex = plt.RightAxis.AxisIndex;
plt.RightAxis.Ticks(true);

// set axis limits for each axis individually
plt.SetAxisLimits(yMin: -2, yMax: 2, yAxisIndex: 0);
plt.SetAxisLimits(yMin: -200, yMax: 200, yAxisIndex: 1);

plt.SaveFig("multiAxis_limits.png");
```

<img src='../../images/multiaxis_limits.png' class='d-block mx-auto my-5' />


