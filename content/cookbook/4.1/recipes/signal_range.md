---
Title: "Plot a Range of Points - ScottPlot 4.1 Cookbook"
Description: "It is sometimes useful to only display values within a range of the source data array."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/signal_range/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Plot a Range of Points"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_range/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_range.png"
---

<h2><a id='plot-a-range-of-points' href='/cookbook/4.1/recipes/signal_range/'>Plot a Range of Points</a></h2>

It is sometimes useful to only display values within a range of the source data array.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create an array larger than we intend to display
double[] values = DataGen.RandomWalk(1000);

// only render values between the two defined indexes
var sig = plt.AddSignal(values);
sig.MinRenderIndex = 400;
sig.MaxRenderIndex = 500;

plt.SaveFig("signal_range.png");
```

<img src='../../images/signal_range.png' class='d-block mx-auto my-5' />


