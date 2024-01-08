---
Title: "Slices in Legend - ScottPlot 4.1 Cookbook"
Description: "Slices can be labeled in the legend."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/pie_legend/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Slices in Legend"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_legend/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_legend.png"
---

<h2><a id='slices-in-legend' href='/cookbook/4.1/recipes/pie_legend/'>Slices in Legend</a></h2>

Slices can be labeled in the legend.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 43, 283, 76, 184 };
string[] labels = { "C#", "JAVA", "Python", "F#", "PHP" };
var pie = plt.AddPie(values);
pie.SliceLabels = labels;
plt.Legend();

plt.SaveFig("pie_legend.png");
```

<img src='../../images/pie_legend.png' class='d-block mx-auto my-5' />


