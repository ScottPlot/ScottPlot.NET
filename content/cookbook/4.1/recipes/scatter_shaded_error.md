---
Title: "Scatter Plot with Shaded Error - ScottPlot 4.1 Cookbook"
Description: "A semitransparent polygon can be created and placed behind the scatter plot to represent standard deviation or standard error."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/scatter_shaded_error/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Scatter Plot with Shaded Error"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_shaded_error/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_shaded_error.png"
---

<h2><a href='/cookbook/4.1/recipes/scatter_shaded_error/'>Scatter Plot with Shaded Error</a></h2>

A semitransparent polygon can be created and placed behind the scatter plot to represent standard deviation or standard error.

```cs
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

<img src='../../images/scatter_shaded_error.png' class='d-block mx-auto my-5' />


