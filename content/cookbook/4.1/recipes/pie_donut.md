---
Title: "Donut Chart - ScottPlot 4.1 Cookbook"
Description: "Donut plots are pie charts with a hollow center."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/pie_donut/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Donut Chart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_donut/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_donut.png"
---

<h2><a id='donut-chart' href='/cookbook/4.1/recipes/pie_donut/'>Donut Chart</a></h2>

Donut plots are pie charts with a hollow center.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 283, 184, 76, 43 };
var pie = plt.AddPie(values);
pie.Explode = true;
pie.DonutSize = .6;

plt.SaveFig("pie_donut.png");
```

<img src='../../images/pie_donut.png' class='d-block mx-auto my-5' />


