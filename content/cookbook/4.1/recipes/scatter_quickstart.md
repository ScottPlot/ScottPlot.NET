---
Title: "Scatter Plot Quickstart - ScottPlot 4.1 Cookbook"
Description: "Scatter plots are best for small numbers of paired X/Y data points. For evenly-spaced data points Signal is much faster."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/scatter_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Scatter Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_quickstart.png"
---

<h2><a id='scatter-plot-quickstart' href='/cookbook/4.1/recipes/scatter_quickstart/'>Scatter Plot Quickstart</a></h2>

Scatter plots are best for small numbers of paired X/Y data points. For evenly-spaced data points Signal is much faster.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// create sample X/Y data
int pointCount = 51;
double[] x = DataGen.Consecutive(pointCount);
double[] sin = DataGen.Sin(pointCount);
double[] cos = DataGen.Cos(pointCount);

// add scatter plots
plt.AddScatter(x, sin);
plt.AddScatter(x, cos);

plt.SaveFig("scatter_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/scatter_quickstart.png' class='d-block mx-auto my-5' />


