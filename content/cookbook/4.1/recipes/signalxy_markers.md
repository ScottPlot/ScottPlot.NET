---
Title: "Customize Markers - ScottPlot 4.1 Cookbook"
Description: "SignalXY plots have markers which only appear when they are zoomed in."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/signalxy_markers/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalXY", "Customize Markers"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalxy", "/cookbook/4.1/recipes/signalxy_markers/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalxy_markers.png"
---

<h2><a id='customize-markers' href='/cookbook/4.1/recipes/signalxy_markers/'>Customize Markers</a></h2>

SignalXY plots have markers which only appear when they are zoomed in.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

var rand = new Random(0);
double[] ys = DataGen.RandomWalk(rand, 200);
double[] xs = DataGen.Consecutive(200);

var sig = plt.AddSignalXY(xs, ys);
sig.MarkerShape = MarkerShape.filledTriangleUp;
sig.MarkerSize = 10;

plt.SetAxisLimits(100, 120, 10, 15);

plt.SaveFig("signalxy_markers.png");
```

{{< /code-sp4 >}}

<img src='../../images/signalxy_markers.png' class='d-block mx-auto my-5' />


