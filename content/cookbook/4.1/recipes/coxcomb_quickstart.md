---
Title: "Coxcomb Chart - ScottPlot 4.1 Cookbook"
Description: "A Pie chart where the angle of slices is constant but the radii are not."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/coxcomb_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Coxcomb Chart", "Coxcomb Chart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-coxcomb", "/cookbook/4.1/recipes/coxcomb_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/coxcomb_quickstart.png"
---

<h2><a id='coxcomb-chart' href='/cookbook/4.1/recipes/coxcomb_quickstart/'>Coxcomb Chart</a></h2>

A Pie chart where the angle of slices is constant but the radii are not.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 11, 16, 7, 3, 14 };
var coxcomb = plt.AddCoxcomb(values);
coxcomb.FillColors = plt.Palette.GetColors(5, 0, .5);
coxcomb.SliceLabels = new string[] { "bikes", "blimps", "subs", "saucers", "rockets" };

plt.SaveFig("coxcomb_quickstart.png");
```

<img src='../../images/coxcomb_quickstart.png' class='d-block mx-auto my-5' />


