---
Title: "Signal Plot with Smooth Lines - ScottPlot 4.1 Cookbook"
Description: "The Smooth field controls whether signal plot lines are drawn with smooth or straight line."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/signal_smooth/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Signal Plot with Smooth Lines"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_smooth/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_smooth.png"
---

<h2><a id='signal-plot-with-smooth-lines' href='/cookbook/4.1/recipes/signal_smooth/'>Signal Plot with Smooth Lines</a></h2>

The Smooth field controls whether signal plot lines are drawn with smooth or straight line.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);
plt.Palette = new ScottPlot.Palettes.ColorblindFriendly();

var sp = plt.AddSignal(data);
sp.Smooth = true;

plt.Legend();

plt.SaveFig("signal_smooth.png");
```

<img src='../../images/signal_smooth.png' class='d-block mx-auto my-5' />


