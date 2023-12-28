---
Title: "SignalXY Quickstart - ScottPlot 4.1 Cookbook"
Description: "SignalXY is a speed-optimized plot for displaying values (Ys) with unevenly-spaced positions (Xs) that are in ascending order. If your data is evenly-spaced, Signal and SignalConst is faster."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/signalxy_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalXY", "SignalXY Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalxy", "/cookbook/4.1/recipes/signalxy_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalxy_quickstart.png"
---

<h2><a id='signalxy-quickstart' href='/cookbook/4.1/recipes/signalxy_quickstart/'>SignalXY Quickstart</a></h2>

SignalXY is a speed-optimized plot for displaying values (Ys) with unevenly-spaced positions (Xs) that are in ascending order. If your data is evenly-spaced, Signal and SignalConst is faster.

```cs
var plt = new ScottPlot.Plot(600, 400);

(double[] xs, double[] ys) = DataGen.RandomWalk2D(new Random(0), 5_000);

plt.AddSignalXY(xs, ys);

plt.SaveFig("signalxy_quickstart.png");
```

<img src='../../images/signalxy_quickstart.png' class='d-block mx-auto my-5' />


