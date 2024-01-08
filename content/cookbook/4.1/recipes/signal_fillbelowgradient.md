---
Title: "Gradient Fill Below - ScottPlot 4.1 Cookbook"
Description: "Signal plots can be filled below using a color gradient."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/signal_fillbelowgradient/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Gradient Fill Below"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_fillbelowgradient/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_fillbelowgradient.png"
---

<h2><a id='gradient-fill-below' href='/cookbook/4.1/recipes/signal_fillbelowgradient/'>Gradient Fill Below</a></h2>

Signal plots can be filled below using a color gradient.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

var sig = plt.AddSignal(data);
sig.FillBelow(Color.Blue, Color.Transparent);

plt.Margins(x: 0);

plt.SaveFig("signal_fillBelowGradient.png");
```

<img src='../../images/signal_fillbelowgradient.png' class='d-block mx-auto my-5' />


