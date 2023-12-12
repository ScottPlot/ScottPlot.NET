---
Title: "Display first N points - ScottPlot 4.1 Cookbook"
Description: "When plotting live data it is useful to allocate a large array in memory then fill it with values as they come in. By setting the maxRenderIndex property of a scatter plot to can prevent rendering the end of the array (which is probably filled with zeros)."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/signal_firstnpoints/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Display first N points"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_firstnpoints/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_firstnpoints.png"
---

<h2><a id='display-first-n-points' href='/cookbook/4.1/recipes/signal_firstnpoints/'>Display first N points</a></h2>

When plotting live data it is useful to allocate a large array in memory then fill it with values as they come in. By setting the maxRenderIndex property of a scatter plot to can prevent rendering the end of the array (which is probably filled with zeros).

```cs
var plt = new ScottPlot.Plot(600, 400);

// create an array larger than we intend to display
double[] values = DataGen.RandomWalk(1000);

// only render the first N points of the signal
var sig = plt.AddSignal(values);
sig.MaxRenderIndex = 500;

plt.SaveFig("signal_firstNpoints.png");
```

<img src='../../images/signal_firstnpoints.png' class='d-block mx-auto my-5' />


