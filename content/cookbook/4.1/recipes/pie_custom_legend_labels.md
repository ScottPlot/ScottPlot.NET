---
Title: "Custom Legend Labels - ScottPlot 4.1 Cookbook"
Description: "Labels for slices and legend items can be independently configured."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/pie_custom_legend_labels/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Custom Legend Labels"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_custom_legend_labels/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_custom_legend_labels.png"
---

<h2><a id='custom-legend-labels' href='/cookbook/4.1/recipes/pie_custom_legend_labels/'>Custom Legend Labels</a></h2>

Labels for slices and legend items can be independently configured.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 43, 283, 76, 184 };
string[] SliceLabels = { "Cat", "Dog", "Snake", "Frog", "Fox" };
string[] LegendLabels = { "Meow", "Woof", "Ssst", "Ribbit", "RingDing" };

var pie = plt.AddPie(values);
pie.SliceLabels = SliceLabels;
pie.ShowLabels = true;

pie.LegendLabels = LegendLabels;
plt.Legend();

plt.SaveFig("pie_custom_legend_labels.png");
```

{{< /code-sp4 >}}

<img src='../../images/pie_custom_legend_labels.png' class='d-block mx-auto my-5' />


