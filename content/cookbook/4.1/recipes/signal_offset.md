---
Title: "Signal Offset - ScottPlot 4.1 Cookbook"
Description: "Signal plots can have X and Y offsets that shift all data by a defined amount."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/signal_offset/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Signal Offset"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_offset/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_offset.png"
---

<h2><a id='signal-offset' href='/cookbook/4.1/recipes/signal_offset/'>Signal Offset</a></h2>

Signal plots can have X and Y offsets that shift all data by a defined amount.

```cs
var plt = new ScottPlot.Plot(600, 400);

var rand = new Random(0);
double[] values = DataGen.RandomWalk(rand, 100_000);
var sig = plt.AddSignal(values);
sig.OffsetX = 10_000;
sig.OffsetY = 100;

plt.SaveFig("signal_offset.png");
```

<img src='../../images/signal_offset.png' class='d-block mx-auto my-5' />


