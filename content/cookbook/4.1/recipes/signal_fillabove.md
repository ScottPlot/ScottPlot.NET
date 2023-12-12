---
Title: "Gradient Fill Above - ScottPlot 4.1 Cookbook"
Description: "Signal plots can be filled above using a color gradient."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/signal_fillabove/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Gradient Fill Above"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_fillabove/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_fillabove.png"
---

<h2><a href='/cookbook/4.1/recipes/signal_fillabove/'>Gradient Fill Above</a></h2>

Signal plots can be filled above using a color gradient.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

var sig = plt.AddSignal(data);
sig.FillAbove(Color.Blue, Color.Transparent);

plt.Margins(x: 0);

plt.SaveFig("signal_fillAbove.png");
```

<img src='../../images/signal_fillabove.png' class='d-block mx-auto my-5' />


