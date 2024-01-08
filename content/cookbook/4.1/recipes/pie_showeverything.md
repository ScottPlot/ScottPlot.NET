---
Title: "Label Everything - ScottPlot 4.1 Cookbook"
Description: "Slices can labeled with values, percentages, and lables, with a legend."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/pie_showeverything/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Label Everything"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_showeverything/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_showeverything.png"
---

<h2><a id='label-everything' href='/cookbook/4.1/recipes/pie_showeverything/'>Label Everything</a></h2>

Slices can labeled with values, percentages, and lables, with a legend.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 43, 283, 76, 184 };
string[] labels = { "C#", "JAVA", "Python", "F#", "PHP" };
var pie = plt.AddPie(values);
pie.SliceLabels = labels;
pie.ShowPercentages = true;
pie.ShowValues = true;
pie.ShowLabels = true;
plt.Legend();

plt.SaveFig("pie_showEverything.png");
```

<img src='../../images/pie_showeverything.png' class='d-block mx-auto my-5' />


