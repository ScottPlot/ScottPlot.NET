---
Title: "Error Bar Quickstart - ScottPlot 4.1 Cookbook"
Description: "Error Bars allow more fine-grained control over how your error bars are shown."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/errorbar_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Error Bar", "Error Bar Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-error-bar", "/cookbook/4.1/recipes/errorbar_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/errorbar_quickstart.png"
---

<h2><a id='error-bar-quickstart' href='/cookbook/4.1/recipes/errorbar_quickstart/'>Error Bar Quickstart</a></h2>

Error Bars allow more fine-grained control over how your error bars are shown.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 20;

double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.RandomNormal(rand, pointCount, mean: 20, stdDev: 2);

double[] xErrPos = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();
double[] xErrNeg = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();
double[] yErrPos = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();
double[] yErrNeg = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();

plt.AddScatter(xs, ys, System.Drawing.Color.Blue, lineStyle: LineStyle.Dot);
plt.AddErrorBars(xs, ys, xErrPos, xErrNeg, yErrPos, yErrNeg, System.Drawing.Color.Blue);

plt.SaveFig("errorBar_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/errorbar_quickstart.png' class='d-block mx-auto my-5' />


