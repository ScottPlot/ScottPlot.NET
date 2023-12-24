---
Title: "5 Million Points - ScottPlot 4.1 Cookbook"
Description: "Signal plots with millions of points can be interacted with in real time."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/signal_5millionpoints/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "5 Million Points"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_5millionpoints/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_5millionpoints.png"
---

<h2><a id='5-million-points' href='/cookbook/4.1/recipes/signal_5millionpoints/'>5 Million Points</a></h2>

Signal plots with millions of points can be interacted with in real time.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
for (int i = 0; i < 5; i++)
{
    // add a new signal plot with one million points
    double[] values = DataGen.RandomWalk(rand, 1_000_000);
    plt.AddSignal(values);
}
plt.Benchmark(enable: true);

plt.SaveFig("signal_5millionPoints.png");
```

<img src='../../images/signal_5millionpoints.png' class='d-block mx-auto my-5' />


