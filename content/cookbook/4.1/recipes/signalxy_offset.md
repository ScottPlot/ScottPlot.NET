---
Title: "SignalXY Offset - ScottPlot 4.1 Cookbook"
Description: "SignalXY plots can have X and Y offsets that shift all data by a defined amount."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/signalxy_offset/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalXY", "SignalXY Offset"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalxy", "/cookbook/4.1/recipes/signalxy_offset/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalxy_offset.png"
---

<h2><a id='signalxy-offset' href='/cookbook/4.1/recipes/signalxy_offset/'>SignalXY Offset</a></h2>

SignalXY plots can have X and Y offsets that shift all data by a defined amount.

```cs
var plt = new ScottPlot.Plot(600, 400);

(double[] xs, double[] ys) = DataGen.RandomWalk2D(new Random(0), 5_000);

var sig = plt.AddSignalXY(xs, ys);
sig.OffsetX = 10_000;
sig.OffsetY = 100;

plt.SaveFig("signalxy_offset.png");
```

<img src='../../images/signalxy_offset.png' class='d-block mx-auto my-5' />


