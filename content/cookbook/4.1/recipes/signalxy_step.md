---
Title: "SignalXY Step Mode - ScottPlot 4.1 Cookbook"
Description: "Data points can be connected with steps (instead of straight lines)."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/signalxy_step/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalXY", "SignalXY Step Mode"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalxy", "/cookbook/4.1/recipes/signalxy_step/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalxy_step.png"
---

<h2><a id='signalxy-step-mode' href='/cookbook/4.1/recipes/signalxy_step/'>SignalXY Step Mode</a></h2>

Data points can be connected with steps (instead of straight lines).

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

(double[] xs, double[] ys) = DataGen.RandomWalk2D(new Random(0), 5_000);

var sigxy = plt.AddSignalXY(xs, ys);
sigxy.StepDisplay = true;
sigxy.MarkerSize = 0;

plt.SetAxisLimits(110, 140, 17.5, 27.5);

plt.SaveFig("signalxy_step.png");
```

{{< /code-sp4 >}}

<img src='../../images/signalxy_step.png' class='d-block mx-auto my-5' />


