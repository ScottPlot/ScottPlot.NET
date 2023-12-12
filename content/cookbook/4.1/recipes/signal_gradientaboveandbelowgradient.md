---
Title: "Gradient Fill Above and Below - ScottPlot 4.1 Cookbook"
Description: "Gradients can be used to fill above and below."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/signal_gradientaboveandbelowgradient/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Gradient Fill Above and Below"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_gradientaboveandbelowgradient/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_gradientaboveandbelowgradient.png"
---

<h2><a href='/cookbook/4.1/recipes/signal_gradientaboveandbelowgradient/'>Gradient Fill Above and Below</a></h2>

Gradients can be used to fill above and below.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

plt.Style(Style.Gray1);

var sig = plt.AddSignal(data);
sig.MarkerSize = 0;
sig.Color = Color.Black;
sig.FillAboveAndBelow(Color.Green, Color.Transparent, Color.Transparent, Color.Red, 1);
sig.BaselineY = 5;

plt.Margins(x: 0);

plt.SaveFig("signal_gradientAboveAndBelowGradient.png");
```

<img src='../../images/signal_gradientaboveandbelowgradient.png' class='d-block mx-auto my-5' />


