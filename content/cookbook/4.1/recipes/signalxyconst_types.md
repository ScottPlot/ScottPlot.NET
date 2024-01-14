---
Title: "Different data types for xs and ys - ScottPlot 4.1 Cookbook"
Description: "SignalXYConst with (int)Xs and (float)Ys arrays"
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/signalxyconst_types/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalXY", "Different data types for xs and ys"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalxy", "/cookbook/4.1/recipes/signalxyconst_types/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalxyconst_types.png"
---

<h2><a id='different-data-types-for-xs-and-ys' href='/cookbook/4.1/recipes/signalxyconst_types/'>Different data types for xs and ys</a></h2>

SignalXYConst with (int)Xs and (float)Ys arrays

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 1_000_000;
double[] sine = DataGen.Sin(pointCount, 3);
double[] noise = DataGen.RandomNormal(rand, pointCount, 0, 0.5);
float[] ys = sine.Zip(noise, (s, n) => s + n).Select(x => (float)x).ToArray();
int[] xs = Enumerable.Range(0, pointCount)
    .Select(x => (int)x)
    .Select(x => x > 500_000 ? x + 1_000_000 : x)
    .Select(x => x > 200_000 ? x + 100_000 : x)
    .ToArray();

plt.AddSignalXYConst(xs, ys);

plt.SaveFig("signalxyconst_types.png");
```

{{< /code-sp4 >}}

<img src='../../images/signalxyconst_types.png' class='d-block mx-auto my-5' />


