---
Title: "Fill Below - ScottPlot 4.1 Cookbook"
Description: "Signal plots can be filled below with a solid color."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/signal_fillbelow/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Fill Below"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_fillbelow/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_fillbelow.png"
---

<h2><a id='fill-below' href='/cookbook/4.1/recipes/signal_fillbelow/'>Fill Below</a></h2>

Signal plots can be filled below with a solid color.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

var sig = plt.AddSignal(data);
sig.FillBelow();

plt.Margins(x: 0);

plt.SaveFig("signal_fillBelow.png");
```

<img src='../../images/signal_fillbelow.png' class='d-block mx-auto my-5' />


