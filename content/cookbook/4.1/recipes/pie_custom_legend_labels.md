---
Title: "Custom Legend Labels - ScottPlot 4.1 Cookbook"
Description: "Labels for slices and legend items can be independently configured."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/pie_custom_legend_labels/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Custom Legend Labels"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_custom_legend_labels/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_custom_legend_labels.png"
---

<h2><a href='/cookbook/4.1/recipes/pie_custom_legend_labels/'>Custom Legend Labels</a></h2>

Labels for slices and legend items can be independently configured.

```cs
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

<img src='../../images/pie_custom_legend_labels.png' class='d-block mx-auto my-5' />

