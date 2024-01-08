---
Title: "Signal Data with Gaps - ScottPlot 4.1 Cookbook"
Description: "Signal with defined Xs that contain gaps"
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/signalxy_gaps/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalXY", "Signal Data with Gaps"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalxy", "/cookbook/4.1/recipes/signalxy_gaps/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalxy_gaps.png"
---

<h2><a id='signal-data-with-gaps' href='/cookbook/4.1/recipes/signalxy_gaps/'>Signal Data with Gaps</a></h2>

Signal with defined Xs that contain gaps

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

var rand = new Random(0);
int pointCount = 10_000;
double[] sine = DataGen.Sin(pointCount, 3);
double[] noise = DataGen.RandomNormal(rand, pointCount, 0, 0.5);
double[] ys = sine.Zip(noise, (s, n) => s + n).ToArray();
double[] xs = Enumerable.Range(0, pointCount)
    .Select(x => (double)x)
    .Select(x => x > 3_000 ? x + 10_000 : x)
    .Select(x => x > 7_000 ? x + 20_000 : x)
    .ToArray();

plt.AddSignalXY(xs, ys);

plt.SaveFig("signalxy_gaps.png");
```

<img src='../../images/signalxy_gaps.png' class='d-block mx-auto my-5' />


