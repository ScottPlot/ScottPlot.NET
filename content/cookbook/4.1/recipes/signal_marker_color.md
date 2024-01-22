---
Title: "Signal Marker Color - ScottPlot 4.1 Cookbook"
Description: "The markers that display when signal plots are zoomed in may have a different color than the lines connecting them"
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/signal_marker_color/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Signal Marker Color"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_marker_color/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_marker_color.png"
---

<h2><a id='signal-marker-color' href='/cookbook/4.1/recipes/signal_marker_color/'>Signal Marker Color</a></h2>

The markers that display when signal plots are zoomed in may have a different color than the lines connecting them

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[] values = DataGen.Sin(51);
var sig = plt.AddSignal(values);

sig.LineColor = Color.LightBlue;
sig.LineWidth = 3;
sig.MarkerColor = Color.Blue;

plt.SaveFig("signal_marker_color.png");
```

{{< /code-sp4 >}}

<img src='../../images/signal_marker_color.png' class='d-block mx-auto my-5' />


