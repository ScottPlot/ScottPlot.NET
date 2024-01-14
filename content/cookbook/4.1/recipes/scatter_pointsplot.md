---
Title: "Markers Only - ScottPlot 4.1 Cookbook"
Description: "A shortcut method makes it easy to create a scatter plot where markers are displayed at every point (without any connecting lines)"
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/scatter_pointsplot/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Markers Only"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_pointsplot/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_pointsplot.png"
---

<h2><a id='markers-only' href='/cookbook/4.1/recipes/scatter_pointsplot/'>Markers Only</a></h2>

A shortcut method makes it easy to create a scatter plot where markers are displayed at every point (without any connecting lines)

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(51);
double[] ys = DataGen.Sin(51);

plt.AddScatterPoints(xs, ys, Color.Navy, 10, MarkerShape.filledDiamond);

plt.SaveFig("scatter_pointsplot.png");
```

{{< /code-sp4 >}}

<img src='../../images/scatter_pointsplot.png' class='d-block mx-auto my-5' />


