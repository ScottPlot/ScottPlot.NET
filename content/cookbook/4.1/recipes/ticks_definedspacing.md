---
Title: "Defined Tick Spacing - ScottPlot 4.1 Cookbook"
Description: "The space between tick marks can be manually defined by setting the grid spacing."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/ticks_definedspacing/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Defined Tick Spacing"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/ticks_definedspacing/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_definedspacing.png"
---

<h2><a id='defined-tick-spacing' href='/cookbook/4.1/recipes/ticks_definedspacing/'>Defined Tick Spacing</a></h2>

The space between tick marks can be manually defined by setting the grid spacing.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot the positive data in the negative space
double[] values = DataGen.Sin(50);
var sig = plt.AddSignal(values);
sig.OffsetX = -50;

// then invert the sign of the axis tick labels
plt.XAxis.ManualTickSpacing(2);
plt.YAxis.ManualTickSpacing(.1);

plt.SaveFig("ticks_definedSpacing.png");
```

<img src='../../images/ticks_definedspacing.png' class='d-block mx-auto my-5' />


