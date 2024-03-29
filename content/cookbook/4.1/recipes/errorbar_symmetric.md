---
Title: "Symmetric Error Bars - ScottPlot 4.1 Cookbook"
Description: "There's a shorthand method for error bars where the positive and negative error is the same."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/errorbar_symmetric/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Error Bar", "Symmetric Error Bars"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-error-bar", "/cookbook/4.1/recipes/errorbar_symmetric/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/errorbar_symmetric.png"
---

<h2><a id='symmetric-error-bars' href='/cookbook/4.1/recipes/errorbar_symmetric/'>Symmetric Error Bars</a></h2>

There's a shorthand method for error bars where the positive and negative error is the same.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 20;

double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.RandomNormal(rand, pointCount, mean: 20, stdDev: 2);

double[] xErr = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();
double[] yErr = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();

plt.AddScatter(xs, ys, System.Drawing.Color.Blue, lineStyle: LineStyle.Dot);
plt.AddErrorBars(xs, ys, xErr, yErr, System.Drawing.Color.Blue);

plt.SaveFig("errorBar_symmetric.png");
```

{{< /code-sp4 >}}

<img src='../../images/errorbar_symmetric.png' class='d-block mx-auto my-5' />


