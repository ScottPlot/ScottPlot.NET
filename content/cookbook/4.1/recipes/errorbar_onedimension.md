---
Title: "Error Bars in One Dimension - ScottPlot 4.1 Cookbook"
Description: "If you only have error data for one dimension you can simply pass in null for the other dimension."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/errorbar_onedimension/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Error Bar", "Error Bars in One Dimension"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-error-bar", "/cookbook/4.1/recipes/errorbar_onedimension/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/errorbar_onedimension.png"
---

<h2><a id='error-bars-in-one-dimension' href='/cookbook/4.1/recipes/errorbar_onedimension/'>Error Bars in One Dimension</a></h2>

If you only have error data for one dimension you can simply pass in null for the other dimension.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 20;

double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.RandomNormal(rand, pointCount, mean: 20, stdDev: 2);

double[] yErr = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();

plt.AddScatter(xs, ys, System.Drawing.Color.Blue, lineStyle: LineStyle.Dot);
plt.AddErrorBars(xs, ys, null, yErr, System.Drawing.Color.Blue);

plt.SaveFig("errorBar_oneDimension.png");
```

{{< /code-sp4 >}}

<img src='../../images/errorbar_onedimension.png' class='d-block mx-auto my-5' />


