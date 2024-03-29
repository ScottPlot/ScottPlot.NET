---
Title: "Pie Chart - ScottPlot 4.1 Cookbook"
Description: "A pie chart illustrates numerical proportions as slices of a circle."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/pie_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Pie Chart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_quickstart.png"
---

<h2><a id='pie-chart' href='/cookbook/4.1/recipes/pie_quickstart/'>Pie Chart</a></h2>

A pie chart illustrates numerical proportions as slices of a circle.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 283, 184, 76, 43 };
plt.AddPie(values);

plt.SaveFig("pie_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/pie_quickstart.png' class='d-block mx-auto my-5' />


