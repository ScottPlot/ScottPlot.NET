---
Title: "Legend - ScottPlot 4.1 Cookbook"
Description: "Most plottable objects have a Label which defines how they appear in the legend"
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/quickstart_legend/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Quickstart", "Legend"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/quickstart", "/cookbook/4.1/recipes/quickstart_legend/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/quickstart_legend.png"
---

<h2><a id='legend' href='/cookbook/4.1/recipes/quickstart_legend/'>Legend</a></h2>

Most plottable objects have a Label which defines how they appear in the legend

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(51);
double[] sin = DataGen.Sin(51);
double[] cos = DataGen.Cos(51);

plt.AddScatter(xs, sin, label: "sin");
plt.AddScatter(xs, cos, label: "cos");
plt.Legend();

plt.SaveFig("quickstart_legend.png");
```

{{< /code-sp4 >}}

<img src='../../images/quickstart_legend.png' class='d-block mx-auto my-5' />


