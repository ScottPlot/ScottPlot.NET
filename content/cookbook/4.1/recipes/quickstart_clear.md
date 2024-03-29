---
Title: "Clear Plottables - ScottPlot 4.1 Cookbook"
Description: "Call Clear() to remove all plottables from the plot. Overloads of Clear() allow you to remote one type of plottable, or a specific plottable."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/quickstart_clear/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Quickstart", "Clear Plottables"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/quickstart", "/cookbook/4.1/recipes/quickstart_clear/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/quickstart_clear.png"
---

<h2><a id='clear-plottables' href='/cookbook/4.1/recipes/quickstart_clear/'>Clear Plottables</a></h2>

Call Clear() to remove all plottables from the plot. Overloads of Clear() allow you to remote one type of plottable, or a specific plottable.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(51);
double[] sin = DataGen.Sin(51);
double[] cos = DataGen.Cos(51);

plt.AddScatter(xs, sin, color: Color.Red);
plt.Clear();
plt.AddScatter(xs, cos, color: Color.Blue);

plt.SaveFig("quickstart_clear.png");
```

{{< /code-sp4 >}}

<img src='../../images/quickstart_clear.png' class='d-block mx-auto my-5' />


