---
Title: "Fill Above and Below - ScottPlot 4.1 Cookbook"
Description: "Signal plots can be filled above and below"
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/signal_fillaboveandbelow/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Fill Above and Below"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_fillaboveandbelow/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_fillaboveandbelow.png"
---

<h2><a id='fill-above-and-below' href='/cookbook/4.1/recipes/signal_fillaboveandbelow/'>Fill Above and Below</a></h2>

Signal plots can be filled above and below

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

var sig = plt.AddSignal(data);
sig.FillAboveAndBelow(Color.Green, Color.Red);
sig.Color = Color.Black;
sig.BaselineY = 7;

plt.Margins(x: 0);

plt.SaveFig("signal_fillAboveAndBelow.png");
```

<img src='../../images/signal_fillaboveandbelow.png' class='d-block mx-auto my-5' />


