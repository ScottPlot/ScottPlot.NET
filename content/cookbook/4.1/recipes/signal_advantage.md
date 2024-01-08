---
Title: "Speed Test - ScottPlot 4.1 Cookbook"
Description: "Compare the speed to the same data plotted as a scatter plot."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/signal_advantage/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Speed Test"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_advantage/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_advantage.png"
---

<h2><a id='speed-test' href='/cookbook/4.1/recipes/signal_advantage/'>Speed Test</a></h2>

Compare the speed to the same data plotted as a scatter plot.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(100_000, 1.0 / 20_000);
double[] values = DataGen.RandomWalk(null, 100_000);

plt.AddScatter(xs, values, Color.Red, markerSize: 0);

plt.Benchmark(enable: true);
plt.Title($"Scatter Plot: One Million Points");

plt.SaveFig("signal_advantage.png");
```

<img src='../../images/signal_advantage.png' class='d-block mx-auto my-5' />


