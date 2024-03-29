---
Title: "SignalConst with X and Y data - ScottPlot 4.1 Cookbook"
Description: "SignalXYConst is a speed-optimized plot for displaying values (Ys) with unevenly-spaced positions (Xs) that are in ascending order. If your data is evenly-spaced, Signal and SignalConst is faster."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/signalxyconst_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalXY", "SignalConst with X and Y data"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalxy", "/cookbook/4.1/recipes/signalxyconst_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalxyconst_quickstart.png"
---

<h2><a id='signalconst-with-x-and-y-data' href='/cookbook/4.1/recipes/signalxyconst_quickstart/'>SignalConst with X and Y data</a></h2>

SignalXYConst is a speed-optimized plot for displaying values (Ys) with unevenly-spaced positions (Xs) that are in ascending order. If your data is evenly-spaced, Signal and SignalConst is faster.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// generate random, unevenly-spaced data
Random rand = new Random(0);
int pointCount = 100_000;
double[] ys = new double[pointCount];
double[] xs = new double[pointCount];
for (int i = 1; i < ys.Length; i++)
{
    ys[i] = ys[i - 1] + rand.NextDouble() - .5;
    xs[i] = xs[i - 1] + rand.NextDouble();
}

plt.AddSignalXYConst(xs, ys);

plt.SaveFig("signalxyconst_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/signalxyconst_quickstart.png' class='d-block mx-auto my-5' />


