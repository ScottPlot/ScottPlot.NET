---
Title: "Signal Marker Color - ScottPlot 4.1 Cookbook"
Description: "The markers that display when signal plots are zoomed in may have a different color than the lines connecting them"
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/signal_marker_color/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Signal Marker Color"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_marker_color/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_marker_color.png"
---

<h2><a id='signal-marker-color' href='/cookbook/4.1/recipes/signal_marker_color/'>Signal Marker Color</a></h2>

The markers that display when signal plots are zoomed in may have a different color than the lines connecting them

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = DataGen.Sin(51);
var sig = plt.AddSignal(values);

sig.LineColor = Color.LightBlue;
sig.LineWidth = 3;
sig.MarkerColor = Color.Blue;

plt.SaveFig("signal_marker_color.png");
```

<img src='../../images/signal_marker_color.png' class='d-block mx-auto my-5' />


