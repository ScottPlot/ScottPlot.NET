---
Title: "Signal Plot Quickstart - ScottPlot 4.1 Cookbook"
Description: "Signal plots are ideal for evenly-spaced data with thousands or millions of points."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/signal_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Signal Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_quickstart.png"
---

<h2><a id='signal-plot-quickstart' href='/cookbook/4.1/recipes/signal_quickstart/'>Signal Plot Quickstart</a></h2>

Signal plots are ideal for evenly-spaced data with thousands or millions of points.

```cs
var plt = new ScottPlot.Plot(600, 400);

var rand = new Random(0);
double[] values = DataGen.RandomWalk(rand, 100_000);
int sampleRate = 20_000;

// Signal plots require a data array and a sample rate (points per unit)
plt.AddSignal(values, sampleRate);

plt.Benchmark(enable: true);
plt.Title($"Signal Plot: One Million Points");

plt.SaveFig("signal_quickstart.png");
```

<img src='../../images/signal_quickstart.png' class='d-block mx-auto my-5' />


