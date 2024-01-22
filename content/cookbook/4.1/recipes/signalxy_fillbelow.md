---
Title: "SignalXY with Fill - ScottPlot 4.1 Cookbook"
Description: "Various options allow shading above/below the signal data."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/signalxy_fillbelow/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalXY", "SignalXY with Fill"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalxy", "/cookbook/4.1/recipes/signalxy_fillbelow/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalxy_fillbelow.png"
---

<h2><a id='signalxy-with-fill' href='/cookbook/4.1/recipes/signalxy_fillbelow/'>SignalXY with Fill</a></h2>

Various options allow shading above/below the signal data.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

(double[] xs, double[] ys) = DataGen.RandomWalk2D(new Random(0), 5_000);

var sigxy = plt.AddSignalXY(xs, ys);
sigxy.FillBelow();

plt.Margins(x: 0);

plt.SaveFig("signalxy_fillBelow.png");
```

{{< /code-sp4 >}}

<img src='../../images/signalxy_fillbelow.png' class='d-block mx-auto my-5' />


