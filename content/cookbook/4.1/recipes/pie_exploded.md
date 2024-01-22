---
Title: "Exploded Pie Chart - ScottPlot 4.1 Cookbook"
Description: "Exploded pie charts have a bit of space between their slices."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/pie_exploded/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Exploded Pie Chart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_exploded/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_exploded.png"
---

<h2><a id='exploded-pie-chart' href='/cookbook/4.1/recipes/pie_exploded/'>Exploded Pie Chart</a></h2>

Exploded pie charts have a bit of space between their slices.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 283, 184, 76, 43 };
var pie = plt.AddPie(values);
pie.Explode = true;

plt.SaveFig("pie_exploded.png");
```

{{< /code-sp4 >}}

<img src='../../images/pie_exploded.png' class='d-block mx-auto my-5' />


