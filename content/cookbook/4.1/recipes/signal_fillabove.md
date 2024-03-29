---
Title: "Gradient Fill Above - ScottPlot 4.1 Cookbook"
Description: "Signal plots can be filled above using a color gradient."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/signal_fillabove/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Gradient Fill Above"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_fillabove/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_fillabove.png"
---

<h2><a id='gradient-fill-above' href='/cookbook/4.1/recipes/signal_fillabove/'>Gradient Fill Above</a></h2>

Signal plots can be filled above using a color gradient.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

var sig = plt.AddSignal(data);
sig.FillAbove(Color.Blue, Color.Transparent);

plt.Margins(x: 0);

plt.SaveFig("signal_fillAbove.png");
```

{{< /code-sp4 >}}

<img src='../../images/signal_fillabove.png' class='d-block mx-auto my-5' />


