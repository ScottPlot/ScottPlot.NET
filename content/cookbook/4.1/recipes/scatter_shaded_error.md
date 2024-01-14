---
Title: "Scatter Plot with Shaded Error - ScottPlot 4.1 Cookbook"
Description: "A semitransparent polygon can be created and placed behind the scatter plot to represent standard deviation or standard error."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/scatter_shaded_error/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Scatter Plot with Shaded Error"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_shaded_error/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_shaded_error.png"
---

<h2><a id='scatter-plot-with-shaded-error' href='/cookbook/4.1/recipes/scatter_shaded_error/'>Scatter Plot with Shaded Error</a></h2>

A semitransparent polygon can be created and placed behind the scatter plot to represent standard deviation or standard error.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 20;
Random rand = new Random(0);
double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.RandomWalk(rand, pointCount, 2.0);
double[] yErr = DataGen.Random(rand, pointCount, 1.0, 1.0);

plt.AddScatter(xs, ys, Color.Blue);
plt.AddFillError(xs, ys, yErr, Color.FromArgb(50, Color.Blue));

plt.SaveFig("scatter_shaded_error.png");
```

{{< /code-sp4 >}}

<img src='../../images/scatter_shaded_error.png' class='d-block mx-auto my-5' />


