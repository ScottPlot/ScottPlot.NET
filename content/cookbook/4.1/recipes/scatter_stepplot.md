---
Title: "Step Plot - ScottPlot 4.1 Cookbook"
Description: "A step plot is a special type of scatter plot where points are connected by right angles instead of straight lines."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/scatter_stepplot/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Step Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_stepplot/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_stepplot.png"
---

<h2><a id='step-plot' href='/cookbook/4.1/recipes/scatter_stepplot/'>Step Plot</a></h2>

A step plot is a special type of scatter plot where points are connected by right angles instead of straight lines.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(51);
double[] ys = DataGen.Sin(51);

plt.AddScatterStep(xs, ys);

plt.SaveFig("scatter_stepplot.png");
```

<img src='../../images/scatter_stepplot.png' class='d-block mx-auto my-5' />


