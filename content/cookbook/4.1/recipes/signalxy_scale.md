---
Title: "SignalXY Scale - ScottPlot 4.1 Cookbook"
Description: "SignalXY plots can have a Y scale that multiply all data by a defined amount. ScaleY is applied before OffsetX and OffsetY."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/signalxy_scale/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalXY", "SignalXY Scale"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalxy", "/cookbook/4.1/recipes/signalxy_scale/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalxy_scale.png"
---

<h2><a id='signalxy-scale' href='/cookbook/4.1/recipes/signalxy_scale/'>SignalXY Scale</a></h2>

SignalXY plots can have a Y scale that multiply all data by a defined amount. ScaleY is applied before OffsetX and OffsetY.

```cs
var plt = new ScottPlot.Plot(600, 400);

// display 100,000 values between -1 and +1
double[] values = DataGen.Sin(100_000, oscillations: 10);
double[] xs = ScottPlot.Generate.Consecutive(values.Length);
var sigxy = plt.AddSignalXY(xs, values);

// scale Y by 500 so values span -500 to +500
sigxy.ScaleY = 500;

plt.SaveFig("signalxy_scale.png");
```

<img src='../../images/signalxy_scale.png' class='d-block mx-auto my-5' />


