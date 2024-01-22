---
Title: "SignalConst Quickstart - ScottPlot 4.1 Cookbook"
Description: "SignalConst plots pre-processes data to render much faster than Signal plots. Pre-processing takes a little time up-front and requires 4x the memory of Signal."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/signalconst_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalConst", "SignalConst Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalconst", "/cookbook/4.1/recipes/signalconst_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalconst_quickstart.png"
---

<h2><a id='signalconst-quickstart' href='/cookbook/4.1/recipes/signalconst_quickstart/'>SignalConst Quickstart</a></h2>

SignalConst plots pre-processes data to render much faster than Signal plots. Pre-processing takes a little time up-front and requires 4x the memory of Signal.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[] values = DataGen.RandomWalk(1_000_000);
plt.AddSignalConst(values);
plt.Title("One Million Points");
plt.Benchmark();

plt.SaveFig("signalconst_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/signalconst_quickstart.png' class='d-block mx-auto my-5' />


