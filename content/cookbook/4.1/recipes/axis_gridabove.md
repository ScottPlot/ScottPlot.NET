---
Title: "Draw Grid Above Plottables - ScottPlot 4.1 Cookbook"
Description: "Sometimes it's useful to draw the grid lines above the plottables rather than below."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/axis_gridabove/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Draw Grid Above Plottables"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/axis_gridabove/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axis_gridabove.png"
---

<h2><a id='draw-grid-above-plottables' href='/cookbook/4.1/recipes/axis_gridabove/'>Draw Grid Above Plottables</a></h2>

Sometimes it's useful to draw the grid lines above the plottables rather than below.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(51);
double[] sines = DataGen.Sin(51);
double[] cosines = DataGen.Cos(51);

plt.AddScatter(xs, sines);
plt.AddScatter(xs, cosines);
plt.AddFill(xs, sines);
plt.AddFill(xs, cosines);

plt.Grid(onTop: true);

plt.SaveFig("axis_gridAbove.png");
```

{{< /code-sp4 >}}

<img src='../../images/axis_gridabove.png' class='d-block mx-auto my-5' />


