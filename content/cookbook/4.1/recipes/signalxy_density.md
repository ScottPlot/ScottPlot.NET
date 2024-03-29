---
Title: "Different Densities - ScottPlot 4.1 Cookbook"
Description: "Signal with mised low and high density data"
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/signalxy_density/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalXY", "Different Densities"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalxy", "/cookbook/4.1/recipes/signalxy_density/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalxy_density.png"
---

<h2><a id='different-densities' href='/cookbook/4.1/recipes/signalxy_density/'>Different Densities</a></h2>

Signal with mised low and high density data

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

Random rand = new(0);
int pointCount = 5_000;
double[] sine = DataGen.Sin(pointCount, 3);
double[] noise = DataGen.RandomNormal(rand, pointCount, 0, 0.5);
double[] ys = sine.Zip(noise, (s, n) => s + n).ToArray();
double[] xs = new double[pointCount];

double x = 0;
for (int i = 0; i < pointCount; i++)
{
    bool lowDensityPoint = (i % 1_000) < 10;
    x += lowDensityPoint ? 10 : .05;
    xs[i] = x;
}

plt.AddSignalXY(xs, ys);

plt.SaveFig("signalxy_density.png");
```

{{< /code-sp4 >}}

<img src='../../images/signalxy_density.png' class='d-block mx-auto my-5' />


