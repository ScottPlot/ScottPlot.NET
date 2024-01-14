---
Title: "Slice Values - ScottPlot 4.1 Cookbook"
Description: "The value of each slice can be displayed at its center."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/pie_showvalues/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Slice Values"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_showvalues/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_showvalues.png"
---

<h2><a id='slice-values' href='/cookbook/4.1/recipes/pie_showvalues/'>Slice Values</a></h2>

The value of each slice can be displayed at its center.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 43, 283, 76, 184 };
var pie = plt.AddPie(values);
pie.ShowValues = true;

plt.SaveFig("pie_showValues.png");
```

{{< /code-sp4 >}}

<img src='../../images/pie_showvalues.png' class='d-block mx-auto my-5' />


