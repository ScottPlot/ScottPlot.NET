---
Title: "Signal Plot - ScottPlot 4.1 Cookbook"
Description: "Signal plots have evenly spaced Y points. Signal plots are very fast and can interactively display millions of data points. There are many different types of plottable objects, each serving a different purpose."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/quickstart_signal/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Quickstart", "Signal Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/quickstart", "/cookbook/4.1/recipes/quickstart_signal/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/quickstart_signal.png"
---

<h2><a id='signal-plot' href='/cookbook/4.1/recipes/quickstart_signal/'>Signal Plot</a></h2>

Signal plots have evenly spaced Y points. Signal plots are very fast and can interactively display millions of data points. There are many different types of plottable objects, each serving a different purpose.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[] values = DataGen.RandomWalk(1_000_000);
plt.AddSignal(values, sampleRate: 48_000);
plt.Title("One Million Points");

plt.SaveFig("quickstart_signal.png");
```

{{< /code-sp4 >}}

<img src='../../images/quickstart_signal.png' class='d-block mx-auto my-5' />


