---
Title: "Lines Only - ScottPlot 4.1 Cookbook"
Description: "A shortcut method makes it easy to create a scatter plot with just lines (no markers)"
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/scatter_lineplot/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Lines Only"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_lineplot/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_lineplot.png"
---

<h2><a id='lines-only' href='/cookbook/4.1/recipes/scatter_lineplot/'>Lines Only</a></h2>

A shortcut method makes it easy to create a scatter plot with just lines (no markers)

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(51);
double[] ys = DataGen.Sin(51);

plt.AddScatterLines(xs, ys, Color.Red, 3);

plt.SaveFig("scatter_lineplot.png");
```

<img src='../../images/scatter_lineplot.png' class='d-block mx-auto my-5' />


