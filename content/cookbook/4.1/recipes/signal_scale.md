---
Title: "Signal Scale - ScottPlot 4.1 Cookbook"
Description: "Signal plots can have a Y scale that multiply all data by a defined amount. ScaleY is applied before OffsetX and OffsetY."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/signal_scale/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Signal Scale"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_scale/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_scale.png"
---

<h2><a id='signal-scale' href='/cookbook/4.1/recipes/signal_scale/'>Signal Scale</a></h2>

Signal plots can have a Y scale that multiply all data by a defined amount. ScaleY is applied before OffsetX and OffsetY.

```cs
var plt = new ScottPlot.Plot(600, 400);

// display 100,000 values between -1 and +1
double[] values = DataGen.Sin(100_000, oscillations: 10);
var sig = plt.AddSignal(values);

// scale Y by 500 so values span -500 to +500
sig.ScaleY = 500;

plt.SaveFig("signal_scale.png");
```

<img src='../../images/signal_scale.png' class='d-block mx-auto my-5' />


