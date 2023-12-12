---
Title: "Signal Plot with Generic Data - ScottPlot 4.1 Cookbook"
Description: "Signal plots accept double arrays by default, but a generic signal plot exists which can display most numeric data types."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/signal_generic/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Signal Plot with Generic Data"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_generic/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_generic.png"
---

<h2><a id='signal-plot-with-generic-data' href='/cookbook/4.1/recipes/signal_generic/'>Signal Plot with Generic Data</a></h2>

Signal plots accept double arrays by default, but a generic signal plot exists which can display most numeric data types.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new(0);
int points = 10_000;

float[] valuesFLOAT = DataGen.RandomWalk<float>(rand, points, 1, 0);
short[] valuesSHORT = DataGen.RandomWalk<short>(rand, points, 1, 0);
Int16[] valuesINT16 = DataGen.RandomWalk<Int16>(rand, points, 1, 0);

plt.AddSignal(valuesFLOAT, label: "float[]");
plt.AddSignal(valuesSHORT, label: "short[]");
plt.AddSignal(valuesINT16, label: "Int16[]");

plt.Legend();

plt.SaveFig("signal_generic.png");
```

<img src='../../images/signal_generic.png' class='d-block mx-auto my-5' />


