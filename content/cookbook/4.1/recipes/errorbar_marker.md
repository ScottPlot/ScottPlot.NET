---
Title: "Error Bar Marker - ScottPlot 4.1 Cookbook"
Description: "An optional marker can be drawn at the center X/Y position for each error bar."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/errorbar_marker/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Error Bar", "Error Bar Marker"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-error-bar", "/cookbook/4.1/recipes/errorbar_marker/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/errorbar_marker.png"
---

<h2><a id='error-bar-marker' href='/cookbook/4.1/recipes/errorbar_marker/'>Error Bar Marker</a></h2>

An optional marker can be drawn at the center X/Y position for each error bar.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 50;
double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.NoisyBellCurve(rand, pointCount);
double[] yErr = DataGen.Random(rand, pointCount, multiplier: .2, offset: .05);

plt.AddErrorBars(xs, ys, null, yErr, markerSize: 5);

plt.SaveFig("errorBar_marker.png");
```

<img src='../../images/errorbar_marker.png' class='d-block mx-auto my-5' />


